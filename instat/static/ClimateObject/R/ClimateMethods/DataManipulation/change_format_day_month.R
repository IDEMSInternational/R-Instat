# change format of the date
#' @title Get the format of date as day+month
#' @name change_format_day_month
#' @author Frederic Ntirenganya 2015 (AMI)
#' 
#' @description \code{change format of date to be day+month }
#' create a date column in the format day-month
#'  
#' @return It adds a day-month column on the data_obj
 

climate$methods(change_format_day_month = function(data_list = list(), periods = daily_label, col_name = "Day_Month", month_format = "%m", required_format = "%d-%b", option = 1){
  
  #this method Changes the format of date so that the date appear in the format day+month (i.e. "17 Apr" rather than "108")
  #given the day of year,  or year, month, and day or date.
  # it takes a specific date of the year and create a column of the date in the format day-month.
  #==============================================================================================
  # data time period is "daily"
  data_list = add_to_data_info_time_period(data_list, periods)
  # a list of climate data objects
  climate_data_objs = get_climate_data_objects(data_list)
  
  for (data_obj in climate_data_objs){
    
    date_col = data_obj$getvname(date_label)
    # Must add these columns if not present
    if( !( data_obj$is_present(year_label) && data_obj$is_present(month_label) && data_obj$is_present(day_label)) ) {
      data_obj$add_year_month_day_cols()
    }
    year_col = data_obj$getvname(year_label)
    month_col = data_obj$getvname(month_label)
    day_col = data_obj$getvname(day_label)
    
    # Must add doy column to the data if not present
    if ( !(data_obj$is_present(doy_label))) {
      data_obj$add_doy_col()
    }
      doy_col = data_obj$getvname(doy_label) 
    #print(doy_col)
      
      #Check if option is within 1,2 or 3
      if(option < 1 || option > 3) stop("Please enter values of options whithin the range  1, 2, or 3")  
      
      curr_data_list = data_obj$get_data_for_analysis(data_list)
      #print(curr_data_list)
      for (curr_data in curr_data_list){
        
        #Initialise the vector which will contain the result
        day_month_col <- c()
        if (option == 1){
        for ( i in 1 : length( curr_data[[doy_col]] ) ) {
          if ( curr_data[[doy_col]][i] == 60 ) {
            day_month_col[ i ] = "29 Feb"
          }
          if ( curr_data[[doy_col]][i] < 60 ){
            day_month_col[i] =  format( strptime( curr_data[[doy_col]][i], format = "%j" ), format = required_format)
          }
          if( curr_data[[doy_col]][i] > 60  ){
            day_month_col[i] =  format( strptime( curr_data[[doy_col]][i] - 1, format = "%j" ), format = required_format)
          } # end brace added   
        }
          if(option == 2){
            day_month_col = format( strptime(curr_data[[date_col]], format="%Y-%m-%d"), format = required_format)      
          }else if(option == 3){
            day_month_col = format( strptime( paste( curr_data[[year_col]], curr_data[[month_col]], curr_data[[day_col]]), format = paste("%Y", month_format, "%d") ), 
                                    format = required_format)
          } # end brace added
          
        }
        print(class(day_month_col))
      }# curr_data
    }#data_obj
  
  data_obj$append_column_to_data(day_month_col, col_name)
  data_obj$append_to_variables(dm_label, col_name) 
  
}

)

