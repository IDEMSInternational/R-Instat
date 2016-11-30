#==================================================================================================================
# DISPLAY DAILY
#' @title Get the tables of daily data
#' @name Display_daily
#' @author Frederic Ntirenganya 2015 (AMI)
#' 
#' @description \code{Display daily data in tables }
#' Display daily data in tables for any variable 
#'  
#' @param data_list list. this is a list containing stations for analysis, the years or periods to be analyzed and the required variables from the data 
#' @param Print_tables Logical,if true, the method print the table in the console
#' @param Row.names Logical, if FALSE the row names attributed to the dataframe are removed
#' @param Na.rm Logical, if true remove the missing value
#' @param Variable  This is the variable to be displayed
#' @param Threshold The least amount of rainfall for which a day is considered rainy
#' @param Month_list The three-letter abbreviations for the English month names
#' @param Day_display Column name showing the day of the month
#'   
#' @examples
#' ClimateObj <- climate( data_tables = list( data ), date_formats = list( "%m/%d/%Y" ) )
#' Default dateformats: "%Y/%m/%d"
#' # where "data" is a data.frame containing the desired variable to be displayed.
#' climateObj$display_daily()
#' @return It returns tables list
#TODO allow any monthly summaries to be added
climate$methods(display_daily_rain = function(data_list = list(), print_tables = FALSE, month_summaries = c(sum_label, max_label, count_over_threshold_label),  
                                         na.rm = FALSE, variable = rain_label, threshold = 0.85, months_list = month.abb, day_display = "Day", decimal_places = 2, 
                                         summary_names = c("Total", "Max", "Values > threshold")) {
  
  .self$display_daily(data_list = data_list, print_tables = print_tables, month_summaries = month_summaries, na.rm = na.rm, variable = variable, threshold = threshold, 
                      months_list = months_list, day_display = day_display, decimal_places = decimal_places, summary_names = summary_names)
}
)
