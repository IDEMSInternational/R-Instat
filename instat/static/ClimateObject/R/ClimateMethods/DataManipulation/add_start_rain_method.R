#==================================================================================================
# START OF RAINS
#' @title Computational of start of the rain for various definitions
#' @name add_start_rain
#' @author Danny and ANdree 2015 (AMI)

#' @description \code{compute.start_rain} 
#' compute start of the rains given climate object
#' 
#' @param data_list list. 
#' 
#' @param Strt.Rains type character. Type of start of rains to be computed. It is yearly summary. 
#  
#' @examples
#' ClimateObj <- climate(data_tables = list( data ), date_formats = list("%m/%d/%Y"))
#' Default dateformats: "%Y/%m/%d"
#' # where "data" is a data.frame containing the desired data to be computed.
#' climateObj$add_start_rain()
#' @return return start of the rain for current definition 
#' 


climate$methods(add_start_rain = function(data_list=list(), earliest_day=92, total_days=2, rain_total=20, dry_length=30,
                                          dry_days=10, dry_spell_condition=FALSE, threshold = 0.85, col_name = "Start of Rain",
                                          replace=FALSE) {
  
  data_list=add_to_data_info_required_variable_list(data_list, rain_label)
  data_list=add_to_data_info_time_period(data_list, daily_label)
  climate_data_objs = get_climate_data_objects(data_list)
  
  for(data_obj in climate_data_objs) {
    
    # use get_meta to determine the correct threshold value to use
    threshold = data_obj$get_meta(threshold_label,missing(threshold),threshold)
    
    #if doy or year/dos is not in the data frame, create it.
    if( !( data_obj$is_present(dos_label) && data_obj$is_present(season_label) ) ) {
      data_obj$add_doy_col()
    }
    curr_data_list = add_to_data_info_required_data_objs_list(data_list, c(data_obj$get_meta(data_name_label)))
    .self$summary_calculation(curr_data_list, summary_time_period = yearly_label, required_summaries = start_of_rain_summary_label, required_variables = c(waterbalance_label, dos_label), column_names = col_name, replace = replace, earliest_day = earliest_day, total_days = total_days, rain_total = rain_total, dry_length = dry_length, dry_days = dry_days, dry_spell_condition = dry_spell_condition, threshold = threshold)
  }
      
}
)
