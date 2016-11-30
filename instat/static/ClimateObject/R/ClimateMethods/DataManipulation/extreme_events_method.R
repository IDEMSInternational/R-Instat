#==================================================================================================
# Climatic Extremes
#' @title Climatic Extremes.
#' @name extreme_events
#' @author Fanuel and Steve 2015 (AMI)

#' @description \code{climatic extremes} 
#' Adds a column of extreme events summed or averaged over a number of days and the day when the event occured (e.g maximum, minimum and extreme event day) given climate object
#' It also outputs the days when a fixed limit was exceeded i.e values over threshold
#' @param data_list list needed to get data for climate data objects.  
#' @param year A vector of numeric years from which to get the extreme, default is all years in the data.
#' @param required_var The variable name from which to get the extreme events, must be a character
#' @param na.rm  A logical scalar. Should the NAs (including NaN) be removed?
#' @param max_min A logical scalar. Should the maximum or the minimum be computed?
#' @param extreme Compute max or min
#' @param sum_day Numeric argument. nummber of days to sum or average over
#' @param val_threshold A logical a scalar. Should the Values over threshold be computed?
#' @param threshold_value Numeric argument. A fixed limit over which Valaues over threshold are computed
#' @param start_day A numeric argument. It shows when in the season the computation started.
#' @param end_day A numeric argument. It shows when in the season the computation ended.
#' @param values_between A logical scalar. Should the computation be done with values between a range?
#' @param lower_lim, upper_lim Numeric values. A range of values over which the computation occurs.
#' @param col_name, col_name2 Character arguments. col_name for extreme events and col_name2 for the day
#' the event occured.
#' @examples
#' ClimateObj <- climate( data_tables = list( dataframe=dataframe ), date_formats = list( "%m/%d/%Y" ) )
#' Default dateformats: "%Y/%m/%d"
#' where "data" is a data.frame containing the desired data to be computed.
#' climateObj$extreme_events() ; View(climateObj$used_data_objects$dataframe$data)
#' @return return columns of extreme events i.e maximum or minimum with the day of event and the values over threshold
#'
climate$methods(extreme_events=function(data_list=list(), required_var=rain_label,na.rm=TRUE,extreme_max=TRUE, extreme_min = FALSE,total_days=1,val_threshold=FALSE,
                                        threshold_value=0,start_day=1, end_day=366, values_between=FALSE,lower_lim,upper_lim,
                                        col_names=c("Yearly Maximum","extreme event day"),replace=FALSE){
  # DONE max, min sum over sum_day days
  # with the doy of last day in the sum where (first - in cases of multiple maximums) max/min occured on
  # print all doys when variable is over a threshold
  # max, min within a range (lower_lim and upper_lim)
  
  
  #required variable
  data_list = add_to_data_info_required_variable_list(data_list, list(required_var))
  # date time period
  data_list = add_to_data_info_time_period(data_list, daily_label)
  
  # a list of climate data objects
  climate_data_objs = get_climate_data_objects(data_list)
  for(data_obj in climate_data_objs) {    
    
    #add season column to the data
    if ( !(data_obj$is_present(season_label))) {
      data_obj$add_doy_col()
    }
    #if dos is not in the data create it
    if( !( data_obj$is_present(dos_label) && data_obj$is_present(season_label) ) ) {
      data_obj$add_doy_col()
    }
    
    #get names of the columns in the data   
    var_col = data_obj$getvname(required_var)
    
    dos_col = data_obj$getvname(dos_label) 
    
    season_col= data_obj$getvname(season_label)
    
    summary_obj <- get_summary_name(yearly_label, data_obj)       
    
    curr_data_list = data_obj$get_data_for_analysis(data_list)

    curr_definition = list(total_days = total_days, na.rm = na.rm)
    extremes = c(max_label,min_label)[c(extreme_max, extreme_min)]
    for (curr_data in curr_data_list) {
      summ_cols = list()
      if(extreme_max) summ_cols = summary_calculation(summaries = running_summary_label, variables = list(var = curr_data[[var_col]]), factor = curr_data[[season_col]], threshold = threshold, na.rm = na.rm, total_days = total_days, func = max_label)
      if(extreme_min) summ_cols[[length(summ_cols)+1]] = summary_calculation(summaries = running_summary_label, variables = list(var = curr_data[[var_col]]), factor = curr_data[[season_col]], threshold = threshold, na.rm = na.rm, total_days = total_days, func = min_label)
      
      names(summ_cols) <- col_names
      
      for(j in 1:length(summ_cols)) {
        summary_obj$append_column_to_data(as.vector(summ_cols[[j]]), names(summ_cols)[[j]])
        summ_label = summary_obj$get_summary_label(required_var, extremes[[j]], curr_definition)
        summary_obj$append_to_variables(summ_label, names(summ_cols)[[j]])
      }
      
      
    }  
    
  }
  
}
)
    
    
    
    
    ######################################################
    
#     continue = TRUE
#     
#     curr_definition = list(sum_day = sum_day, start_day = start_day, end_day=end_day)
#     
#     #labels=c(max_min_label, extreme_event_label)
#   
#     if(max_min && !val_threshold){
#       for (i in 1:length(col)){
#           
#         if(col_name[i] %in% names(summary_obj$get_data()) && !replace) {
#           message(paste("A column named", col_name[i], "already exists. The column will not be replaced.
#                         To replace to column, re run this function and specify replace = TRUE."))
#           continue = FALSE
#         }
#         
#         if(col_name[i] %in% names(summary_obj$get_data()) && replace){
#           message(paste("A column named", col_name[i], "already exists. The column will be replaced 
#                         in the data."))
#         }
#         
#         if( continue && summary_obj$is_definition(required_var,extreme_event_day_label,curr_definition)) {
#           message("A column with this defintion already exists in the data.
#                   The column will not be added again.")
#           continue = FALSE
#         }
#       }
#     }  
#     if (continue){
#     
#       curr_data_list = data_obj$get_data_for_analysis(data_list)
#       
#       for (curr_data in curr_data_list){
#         
#         years <- unique(curr_data[[season_col]])
#         
#         mx=rep(NA,length(years))
#         
#         doy=mx
#         
#         thresh=list()
#         
#         for (yr in years){
#           
#           if (values_between){
#             if (missing(upper_lim)){
#               upper_lim=max(curr_data[[var_col]],na.rm=na.rm)
#             }
#             if (missing(lower_lim)){
#               lower_lim=min(curr_data[[var_col]],na.rm=na.rm)
#             }
#             sub=subset(curr_data,curr_data[[season_col]]==yr & curr_data[[dos_col]]>=start_day & curr_data[[dos_col]]<=end_day & curr_data[[var_col]]>= lower_lim & curr_data[[var_col]]<= upper_lim)
#             }else{
#               sub=subset(curr_data,curr_data[[season_col]]==yr & curr_data[[dos_col]]>=start_day & curr_data[[dos_col]]<=end_day)
#               }
#            val=rowSums(outer(1:(length(sub[[var_col]])-sum_day+1),1:sum_day,FUN=function(i,j){sub[[var_col]][(j - 1) + i]}),na.rm=na.rm)      
#           
#             if(max_min ){
#               doy_1=sub[[dos_col]][sum_day-1+which(val %in% extreme(val,na.rm=na.rm))]
#               if (length(doy_1)>1){
#                 doy[[yr-min(unique(curr_data[[season_col]])-1)]]=min(doy_1) 
#                 }else{
#                   doy[[yr-min(unique(curr_data[[season_col]])-1)]]=doy_1 
#                 }
#               mx[[yr-min(unique(curr_data[[season_col]])-1)]]=extreme(val,na.rm=na.rm)          
#           }       
#           
#           if (val_threshold){
#             doy_1=sub[[dos_col]][sum_day-1+which(val>threshold_value, arr.ind=TRUE)]
#             thresh[[yr-min(unique(curr_data[[season_col]])-1)]]=c(yr,doy_1)          
#           }       
#         }
#         result=list(mx,doy)       
#         if (max_min){
#           for (j in 1:length(col_name)){        
#             summary_obj$append_column_to_data(result[[j]], col_name[j])
#             label = summary_obj$get_summary_label(required_var,extreme_event_day_label,curr_definition)
#             summary_obj$append_to_variables(label, col_name[j])
#           } 
#           
#         }
#         if (val_threshold){
#           return(thresh)
#         }      
#       }
#     }
#   }  
# }
# )
#=========TO Do=========================================================================================================
#Include Peaks over Threshold
#Include Separate periods by at least 'some' day for both values over threshold and Peaks over threshold
