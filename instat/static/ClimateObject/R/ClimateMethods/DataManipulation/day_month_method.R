#==================================================================================================
# change format of the date
#' @title Get the format of date as day+month
#' @name day_month
#' @author Frederic Ntirenganya 2015 (AMI)
#' 
#' @description \code{change format of date to be day+month }
#' create a date column in the format day-month
#' 
#' @param data_list() data_list	A list containing stations for analysis, the years or periods to be analyzed and the required variables from the data. 
#' If blank, the system will choose all data appropriate for the analysis.
#' @param Time_period data time period.
#' @param Col_name	The name of the new column created.
#' @param Month_format  The format in which the months are stored.
#' @param Required_format  The required format of the day + month.
#'  
#'  @examples
#'  climateObj <- climate (data_tables = list (data), date_formats = list( "%m/%d/%Y" )) 
#'  Default dateformats: "%Y/%m/%d"
#' # where "data" is a data.frame containing the desired data to be computed.
#' 
#' @return Adds a day-month column on the data
#' 


climate$methods(day_month = function(data_list = list(), time_period = daily_label, col_name = "Day_Month", required_format = "%d %b") {
  
  #this method adds a date column in any required format, with the default adding a day-month column, i.e. in the format day+month ("17 Apr")
  #==============================================================================================
  # data time period 
  data_list = add_to_data_info_time_period(data_list, time_period)
  # a list of climate data objects
  climate_data_objs = get_climate_data_objects(data_list)
  
  for (data_obj in climate_data_objs) {
    
    date_col = data_obj$getvname(date_label)
   
    curr_data_list = data_obj$get_data_for_analysis(data_list)
    i = 1
    join_tables = list()
    joining_columns = data_obj$get_joining_columns()
    for (curr_data in curr_data_list) {
      curr_join_table = curr_data[joining_columns]
      curr_join_table[[col_name]] = format( curr_data[[ date_col ]], format = required_format)
      join_tables[[i]] <- curr_join_table
      i = i + 1
    }
    data_obj$join_data(join_tables, match="first", type="full")
    data_obj$append_to_changes(list(Added_col, col_name))
    data_obj$append_to_variables(dm_label, col_name)   
  }
}
)