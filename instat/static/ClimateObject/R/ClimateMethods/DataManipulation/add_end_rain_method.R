#==================================================================================================
# END OF RAINS
#' @title Computational of end of the rain with water balance definition
#' @name add_end_rain
#' @author Danny, Frederic and Fanuel 2015 (AMI)

#' @description \code{compute.end_rain} 
#' compute end of the rains given climate object
#' 
#' @param data_list	A list containing stations for analysis, the years or periods to be analysed and the required variables from the data.
#'  If blank, the system will choose all data appropriate for the analysis.
#' @param earliest_day  The earliest possible day for the end of the rains.
#' @param water_balance_col_name  The column name to use for the water balance column if it needs to be created. 
#' @param col_name  The column name to use for the end of the rains.
#' @param capacity_max	The maximum water balance.
#' @param evaporation  	Evaporation per day
#' @param Replace  	Logical indicating whether the column should be replaced if there is already a column in the data with the value of col_name.
#  
#' @examples
#' ClimateObj <- climate( data_tables = list( data ), date_formats = list( "%m/%d/%Y" ) )
#' Default dateformats: "%Y/%m/%d"
#' # where "data" is a data.frame containing the desired data to be computed.
#' climateObj$add_end_rain()
#' @return return end of the rain 
#' 


climate$methods(add_end_rain = function(data_list=list(), earliest_day = 228, water_balance_col_name = "Water Balance", 
                                        col_name = "End of the rains", capacity_max = 100, evaporation = 5,
                                        replace=FALSE) {
  
  
  # We don't restrict the years when calculating end of rain. We calculate for the
  # whole data set. When displaying we can show a subset of the data if needed.
  # year has been removed as an argument.
  
  data_list=add_to_data_info_required_variable_list(data_list, rain_label)
  data_list=add_to_data_info_time_period(data_list, daily_label)
  climate_data_objs = get_climate_data_objects(data_list)
  
  for(data_obj in climate_data_objs) {
    
    #if doy or year/dos season is not in the data frame, create it.
    if( !( data_obj$is_present(dos_label) && data_obj$is_present(season_label) ) ) {
      data_obj$add_doy_col()
    }
    
    season_col = data_obj$getvname(season_label)
    dos_col = data_obj$getvname(dos_label)
    
    if( !(data_obj$is_present(waterbalance_label)) ) {
      if(missing(capacity_max)) {
        data_obj$add_water_balance_col(col_name=water_balance_col_name,evaporation=evaporation)
      }
      else { data_obj$add_water_balance_col(water_balance_col_name,capacity_max,evaporation) }
    }

  }
  
  .self$summary_calculation(data_list, summary_time_period = yearly_label, required_summaries = end_of_rain_summary_label, required_variables = c(waterbalance_label, dos_label), column_names = col_name, replace = replace, earliest_day = earliest_day)
}
)
