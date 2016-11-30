#==================================================================================================
# Climatic Extremes
#' @title Display of running totals.
#' @name display_rain_running_total
#' @author Fanuel and Steve 2015 (AMI)

#' @description  
#' Displays the running totals per year per month.
#' @param col_name  The name of the running total column.  
#' @param months_list The names of the months.
#' @param day_display The name of the first column in the table.
#' @param na.rm  A logical indicating whether missing values should be removed.
#' @param total_days Number of days to be totalled over.
#' @param decimal_places Number of decimal places.
#' @param threshold A value over which a day is considered rainy. 
#' @examples
#' ClimateObj <- climate( data_tables = list( dataframe=dataframe ), date_formats = list( "%m/%d/%Y" ) )
#' Default dateformats: "%Y/%m/%d"
#' where "data" is a data.frame containing the desired data to be computed.
#' climateObj$display_rain_running_total().
#' @return return yearly tables of rain running totals
climate$methods(display_rain_running_total = function(data_list = list(), col_name = "Running Rain Total", na.rm=TRUE, threshold=0.85, 
                                                months_list = month.abb, day_display = "Day", total_days = 1,  decimal_places = 0){
  
  data_list=add_to_data_info_required_variable_list(data_list, list(rain_label))
  
  data_list=add_to_data_info_time_period(data_list, daily_label)
  
  rettables = list()
  
  climate_data_objs = get_climate_data_objects(data_list)
  
  for(data_obj in climate_data_objs) {
    
    if( !(data_obj$is_present(spell_length_label)) ) {
      data_obj$add_running_rain_totals_col(col_name=col_name, threshold = threshold, total_days = total_days)
    }
    running_total_col = data_obj$getvname(running_rain_totals_label)
    head(data_obj$data)
    if( !(data_obj$is_present(year_label) && data_obj$is_present(month_label) && data_obj$is_present(day_label)) ) {
      data_obj$add_year_month_day_cols()
    }
    
    year_col = data_obj$getvname(year_label)
    month_col = data_obj$getvname(month_label)
    day_col = data_obj$getvname(day_label)
    
    curr_data_list = data_obj$get_data_for_analysis(data_list)
    
    for( curr_data in curr_data_list ) {
      curr_data[[running_total_col]] <- round(curr_data[[running_total_col]], digits = decimal_places)
      for (k in 1:length(curr_data[[running_total_col]])){
        if (is.na(curr_data[[running_total_col]][[k]])){
          curr_data[[running_total_col]][[k]]="m" 
        }        
      }
      
      tables = list()
      years_split <- split(curr_data, list(as.factor(curr_data[[year_col]])))
      
      # initialize the counter
      i = 1
      for ( single_year in years_split ) {
        tables[[i]] <- dcast(single_year, single_year[[ day_col ]]~single_year[[ month_col ]], value.var = running_total_col)
        
        end = length(colnames(tables[[i]]))
        names(tables[[i]])[ 1 ] <- day_display
        colnames(tables[[i]])[2:end] <- months_list[1:end-1]
        
        Day = " "
        missing = c(" ",rep(NA,13))
        
        for(j in 2:13){
          sa = which(tables[[i]][,j] %in% 0)
          sb = which(tables[[i]][,j] %in% NA)
          sc = which(tables[[i]][,j] %in% -Inf)
          sf = which(tables[[i]][,j] %in% "m")
          tables[[i]][sa,j]<-"--"
          tables[[i]][sb,j]<-" "
          tables[[i]][sc,j]<-"m"
          missing[j] <- length(sf)
        }
        overall_miss_max = c("Missing",rep(" ",10),"(Overall:",paste(sum(as.numeric(missing[2:13]), na.rm=na.rm),")",sep = ""))
        if(max(as.numeric(missing[2:13]), na.rm=na.rm)>0){
          tables[[i]] = rbind(tables[[i]], overall_miss_max, missing)
        }
        i = i + 1
      }
      
      names(tables) <- names(years_split)
      rettables[[data_obj$get_station_data( curr_data, station_label )]] = tables
    }
    
    return(tables)
    
  }
  
}
)