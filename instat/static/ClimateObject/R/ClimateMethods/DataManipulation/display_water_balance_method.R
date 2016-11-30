#==================================================================================================
# Display Water Balance
#' @title Display Water Balance
#' @name display_water_balance
#' @author Danny and Frederic 2015 (AMI)

#' @description \code{display.water_balance} 
#' display water balance table given climate object
#' 
#' @param data_list list. 
#' 
#' @param WB.type character. Type of water balance to be displayed.It is for each year. 
#  
#' @examples
#' ClimateObj <- climate( data_tables = list( data ), date_formats = list( "%m/%d/%Y" ) )
#' Default dateformats: "%Y/%m/%d"
#' # where "data" is a data.frame containing the desired data to be computed.
#' climateObj$display_water_balance()
#' @return return tables of Water Balance 
#' 


climate$methods(display_water_balance = function(data_list = list(), print_tables = TRUE, col_name = "Water Balance",
                                                 capacity_max = 100, evaporation = 5, decimal_places = 0, 
                                                 months_list = month.abb, day_display = "Day"){
  
  # rain required
  data_list=add_to_data_info_required_variable_list(data_list, list(rain_label))
  
  # date period is "daily"
  data_list=add_to_data_info_time_period(data_list, daily_label)
  
  rettables = list()
  
  climate_data_objs = get_climate_data_objects(data_list)
  
  for(data_obj in climate_data_objs) {
    
    # check if the waterbalance column is present
    if( !(data_obj$is_present(waterbalance_label)) ) {
      # If not, add the column
      if(missing(capacity_max)) {
        data_obj$add_water_balance_col(col_name=col_name,evaporation=evaporation)
      }
      else { data_obj$add_water_balance_col(col_name,capacity_max,evaporation) }
    }
    
    # Do this after if to save repeating 
    waterbalance_col = data_obj$getvname(waterbalance_label)
    
    # Must add these columns if not present to display this way
    if( !(data_obj$is_present(year_label) && data_obj$is_present(month_label) && data_obj$is_present(day_label)) ) {
      data_obj$add_year_month_day_cols()
    }
    
    year_col = data_obj$getvname(year_label)
    month_col = data_obj$getvname(month_label)
    day_col = data_obj$getvname(day_label)
    
    # This is always how we access data in methods now.
    curr_data_list = data_obj$get_data_for_analysis(data_list)
    
    for( curr_data in curr_data_list ) {
      
      # Added extra argument decimal_places to allow flexibility
      curr_data[[waterbalance_col]] <- round(curr_data[[waterbalance_col]], digits = decimal_places)
      
      
      # initialize list of tables
      tables = list()
      
      # Split curr_data into single data frames for each year
      # It returns a list of data.frames, split by year 
      # This is much faster (6x faster when I checked) than subsetting
      # Split is not always appropriate but it is in this case
      years_split <- split(curr_data, list(as.factor(curr_data[[year_col]])))
      
      # counter to use in the loop
      i = 1
      
      # loop through the split data frames 
      for ( single_year in years_split ) {
        
        # Make data into table - rows:days, columns:months, values:water balance
        tables[[i]] <- dcast(single_year, single_year[[ day_col ]]~single_year[[ month_col ]], value.var = waterbalance_col)
        
        # Rename columns
        # Added day_display and months_list as extra arguments so it is more flexible
        
        end = length(colnames(tables[[i]]))
        names(tables[[i]])[ 1 ] <- day_display
        colnames(tables[[i]])[2:end] <- months_list[1:end-1]
        i = i + 1
      }
      
      # The names of years_split is the list of years as strings.
      # These are better labels than numbers so they can be identified better
      names(tables) <- names(years_split)
      # display water balance for multiple stations
      rettables[[data_obj$get_station_data( curr_data, station_label )]] = tables
    }
    
    # Only print if requested
    if(print_tables) {print(tables)}
    
    # Always return the tables list
    # If we don't return and don't print then the method does nothing!
    return(tables)
    
  }
  
}
)