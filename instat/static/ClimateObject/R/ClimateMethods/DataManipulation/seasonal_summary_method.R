#==================================================================================================
# SEASONAL SUMMARIES
#' @title compute seasonal summaries.
#' @name seasonal_summary
#' @author Frederic, Fanuel, Steve, Danny 2015 (AMI)

#' @description \code{seasonal.summary} 
#' Adds  column(s) of sesonal summaries (e.g rain totals, number of rain days, and longest dry spell)
#' given climate object.
#' 
#' @param data_list A list used to specify what data should be used in the method.
#' @param variable_to_summarize A character of the label of the variable to be used for creating the summaries.
#' @param month_start A vector of months (in character or integer format) indicating when the calculation of seasonal summary should be started.
#' If not specified, the first month of the season will be used.
#' @param number_month An integer indicating the number of months to be considered in the 
#' calculation of seasonal summary. The default is 3.
#' @param threshold    A numeric value that will be used for functions such as count_over_threshold. For example, a threshold of rain for a rainy day. The default is 0.85.
#' @param summaries    A list of summary function to be used on variable_to_summarize e.g Sum, Mean, max, median, mean_over_threshold
#' @param month_col_names A vector of characters giving the name of each time period that will be generated from month_start and number_month. 
#' If not specified, a default format of "xxx-yyy" will be used were "xxx" is the three letter abriviation of the first month and "yyy" is the three letter abriviation of the last month
#' e.g. "Jan-Mar"
#' @param summary_col_names A vector of character giving a name o display for each summary of summaries.
#' This will be appended to month_col_names to create the variable names for the summary columns.
#' If not specified, the summary function names will be used, e.g. "Mean"
#' @param na.rm A logical that will be passed to the summary functions indicating whether NA values should be ignored in the data for calculations
#' @param  longest_dry_spell A logical indicating whether a column of longest dry spell 
#' should be appended to the yearly summary object, if the interest varibale is rain.
#' @param replace  A logical indicating whether the column values in yearly summary object should be 
#' replaced.
#' @param  na.rm A logical indicating whether missing values should be removed.
#' The default is FALSE
#' @param  replace A logical indicating whether a column in the summary data frame should be replaced if a column with that name already exists.
#' The default is FALSE
#' @examples
#' ClimateObj <- climate( data_tables = list(dataframe=dataframe), date_formats = list( "%m/%d/%Y" ) )
#' Default dateformats: "%Y/%m/%d"
#' # where "data" is a data.frame containing the desired data to be computed.
#' ClimateObj$seasonal_summary(summaries = list(sum_label, count_over_threshold_label, mean_over_threshold_label, min_label, max_label), month_start = c(1,4));View(climateObj$used_data_objects$dataframe$data)
#' @return 
#' 

climate$methods(seasonal_summary = function(data_list = list(), variable_to_summarize = "", month_start = "", number_month = 3,
                                            summaries = list(), month_col_names = "" , summary_col_names = "", na.rm = FALSE, replace = FALSE, ...) {

  # variable_to_require is requied and may not be rain
  data_list = add_to_data_info_required_variable_list(data_list, variable_to_summarize)
  # date time period is "daily"
  data_list = add_to_data_info_time_period(data_list, daily_label)
  # a list of climate data objects
  climate_data_objs = get_climate_data_objects(data_list)

  if(month_col_names != "" && length(month_col_names) != length(month_start) ) stop("If specified, month_col_names must be a list the same length as month_start")
  if(!missing(summary_col_names) && length(summary_col_names) != length(summaries) ) stop("If specified, summary_col_names must be a list the same length as summaries")
  if(number_month > 12) stop("number_month must be an integer less than or equal to 12.")
  
  for(data_obj in climate_data_objs) {
    
    var_col = data_obj$getvname(variable_to_summarize) 

    # Must add month column if not present
    if( !( data_obj$is_present(month_label)) ) {
      data_obj$add_year_month_day_cols()
    }
    month_col = data_obj$getvname(month_label)
    
    # must add seasonal column to the data
    if ( !(data_obj$is_present(season_label)) ) {
      data_obj$add_doy_col()
    }
    season_col = data_obj$getvname(season_label) 
    if("" %in% month_start) {
      curr_season_start_day = data_obj$get_meta(season_start_day_label)
      date = doy_as_date(curr_season_start_day, 1952)
      month_start = month(date)
    }

    # first check if it is a character
    # take the first 3 letters and check if they are all in month.abb
    if (is.character(month_start)) {
      month_start=tolower(substr(month_start,1,3))
      if ( !all(month_start %in% tolower(month.abb)) ) {
        stop("month_start not recognised. Enter the English names for months in full or short format; e.g Jan or January., or the numeric values of the months.")
      }
      month_start = match(month_start, tolower(month.abb))
    }
    # if numeric, check if they are in 1:12
    else if(is.numeric(month_start)) {
      if(!all(month_start %in% 1:12)) stop("month_start not recognised. Enter the English names for months in full or short format; e.g Jan or January, or the numeric values of the months.")
    }
    # otherwise stop
    else stop("month_start not recognised. Enter the English names for months in full or short format; e.g Jan or January, or the numeric values of the months.")

    # TODO check for cases when a period crosses over two seasons and reject
    # e.g. c(12,1,2) is not acceptable if year starts in January
    
    # create the list of periods using number_month - one element for each month_start
    # and each list element is a vector of months (in numeric format)
    months_lists = lapply(month_start, function(a,b) 1+(((a:(a+b-1)) -1) %% 12), b = number_month)
    # set the labels of the list in the format: "Jan-Mar"
    names(months_lists) = paste0(month.abb[month_start],"-", month.abb[1 + (month_start+number_month-2 %% 12)])
  }

  # loop through the periods of months_lists
  i = 1
  for (period in months_lists) {
    curr_data_list = add_to_data_info_date_list(data_list, month_col, period)
    if(month_col_names != "" && !missing(summary_col_names)) col_names = paste(month_col_names[[i]], summary_col_names)
    else if(month_col_names != "") col_names = paste(month_col_names[[i]], summaries, var_col)
    else if(!missing(summary_col_names)) col_names = paste(names(months_lists)[i], summary_col_names)
    else col_names = paste(names(months_lists)[i], summaries, var_col)
    
    .self$summary_calculation(curr_data_list, yearly_label, summaries, variable_to_summarize, na.rm = na.rm, replace = replace, column_names = list(col_names), ...)
    i = i + 1
  }


  
  
#       if(col_name %in% names(summary_obj$get_data()) && !replace) {
#         message(paste("A column named", col_name, "already exists. The column will not be replaced.
#                       To replace to column, re run this function and specify replace = TRUE."))
#         continue = FALSE
#       }
#       
#       definitions = list()
#       curr_definition = list(threshold = threshold, na.rm = na.rm)
#       for(summary in summaries) {
#         if(summary_obj$is_definition(names(summ_cols[i]), summary, curr_definition)) {
#           warning(paste("A column for", names(summ_cols[i]), "already exisits with definition", curr_definition, "It will not be added again."))
#         }
#       }
#       
#       curr_definition = list(month_start = month_start[i], number_month = number_month, threshold = threshold)
      
#       labs = c(seasonal_total_label , seasonal_raindays_label, spell_length_label)
#       conditions =c((season_rain_total && !season_rain_days && !longest_dry_spell)|(season_rain_total & season_rain_days & longest_dry_spell)|(season_rain_total & season_rain_days)|(season_rain_total & longest_dry_spell), 
#                     (season_rain_days && !season_rain_total && !longest_dry_spell)|(season_rain_days & season_rain_total & longest_dry_spell)|(season_rain_days & season_rain_total)|(season_rain_days & longest_dry_spell),
#                     (longest_dry_spell && !season_rain_days && !season_rain_total )|(season_rain_days & season_rain_total & longest_dry_spell)|(longest_dry_spell & season_rain_total)|(longest_dry_spell & season_rain_days ))
#       for(j in 1:length(col_names[[i]])){
#         if(conditions[j]){
#           if(col_names[[i]][j] %in% names(summary_obj$get_data()) && !replace) {
#             message(paste("A column named", col_names[[i]][j], "already exists. The column will not be replaced.
#                           To replace to column, re run this function and specify replace = TRUE."))
#             continue = FALSE
#           }
#           if(col_names[[i]][j] %in% names(summary_obj$get_data()) && replace){
#             message(paste("A column named", col_names[[i]][j], "already exists. The column will be replaced 
#                           in the data."))
#           }
#           if(labs[j] ==spell_length_label ){
#             if( continue && summary_obj$is_definition(spell_length_col,labs[j],curr_definition)) {
#               message("A column with this defintion already exists in the data.
#                     The column will not be added again.")
#               continue = FALSE
#             }
#           
#           }else{
#             if( continue && summary_obj$is_definition(rain_label,labs[j],curr_definition)) {
#               message("A column with this defintion already exists in the data.
#                     The column will not be added again.")
#               continue = FALSE
#             }
#           }
#         }
#       }
#       
#       if(continue) {
#         
#         curr_data_list = data_obj$get_data_for_analysis(data_list)
#         
#         for( curr_data in curr_data_list ) {
#           month_tot=rep(NA,length(unique(curr_data[[season_col]])))
#           dry_spells=raindays=month_tot
#           
#           rain.season = curr_data[which(curr_data[[month_col]] %in% months),c(season_col,rain_col,spell_length_col)]
#           
#           for (yr in unique(curr_data[[season_col]])) {
#             if(conditions[1]){
#               month_tot[yr-min(unique(curr_data[[season_col]])-1)]=func(rain.season[rain.season[,season_col]==yr,rain_col], na.rm = na.rm)
#             }
#             if(conditions[2]){
#               raindays[yr-min(unique(curr_data[[season_col]])-1)]=sum(rain.season[rain.season[,season_col]==yr,rain_col]>threshold, na.rm = na.rm)
#             }
#             if(conditions[3]){
#               dry_spells[yr-min(unique(curr_data[[season_col]])-1)]=max(rain.season[rain.season[,season_col]==yr,spell_length_col], na.rm = na.rm)
#             }
#           }
#           
#           result = list(month_tot, raindays, dry_spells)        
#         }
#                 
#         for (j in 1:length(col_names[[i]])){
#           if (conditions[j]){
#             if(labs[j] == spell_length_label ){
#               summary_obj$append_column_to_data(result[[j]], col_names[[i]][j])
#               label = summary_obj$get_summary_label(spell_length_label, labs[j],curr_definition)
#               summary_obj$append_to_variables(label, col_names[[i]][j])
#             }
#             else{
#               summary_obj$append_column_to_data(result[[j]], col_names[[i]][j])
#               label = summary_obj$get_summary_label(rain_label, labs[j],curr_definition)
#               summary_obj$append_to_variables(label, col_names[[i]][j])
#             }
#           }
#         }        
#       }
#       i = i + 1
#     }
#   }
}
)
#==================TO DO=======================================================================================
# Restrict daily values between a given limit.
# To consider days of the season instead of the months when specifying the season over which to calculate the summary.

