#==================================================================================================
# SEASONAL SUMMARIES RAIN
#' @title compute seasonal summaries for rain.
#' @name seasonal_summary.rain
#' @author Danny 2015 (AMI)

#' @description \code{seasonal.summary.rain} 
#' Adds  column(s) of sesonal summaries for rain (e.g rain totals, number of rain days, and longest dry spell)
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

climate$methods(seasonal_summary.rain = function(data_list = list(), month_start = 1, number_month = 3, threshold = use_default_label, 
                                            summaries = list(sum_label, count_label, mean_label),
                                            use_threshold_as_lower = c(FALSE, TRUE, TRUE), strict_threshold = FALSE,
                                            longest_dry_spell = TRUE, longest_dry_spell_name = "Longest dry spell", spell_length_name = "Spell Length",
                                            na.rm = FALSE, replace = FALSE, month_col_names = "", 
                                            summary_col_names = c("Total Rain", "Number of rainy days", "Mean rain per rainy day"),...) {
  
  if(length(use_threshold_as_lower) != length(summaries)) stop("use_threshold_as_lower must be the same length as summaries")
  if(sum(use_threshold_as_lower) > 0) {
    data_list_with_threshold = add_to_data_info_threshold_list(data_list, list(var = rain_label, lower_threshold = threshold, lower_strict = strict_threshold))
    summaries_with_threshold = summaries[use_threshold_as_lower]
    summary_col_names_with_threshold = summary_col_names[use_threshold_as_lower]
    seasonal_summary(data_list = data_list_with_threshold, variable_to_summarize = rain_label, month_start = month_start, number_month = number_month, summaries = summaries_with_threshold, month_col_names = month_col_names, summary_col_names = summary_col_names_with_threshold, na.rm = na.rm, replace = replace,...)
  }
  summaries_without_threshold = summaries[!use_threshold_as_lower]
  summary_col_names_without_threshold = summary_col_names[!use_threshold_as_lower]
  summary_col_names_without_threshold = summary_col_names[!use_threshold_as_lower]
  seasonal_summary(data_list = data_list, variable_to_summarize = rain_label, month_start = month_start, number_month = number_month, summaries = summaries_without_threshold, month_col_names = month_col_names, summary_col_names = summary_col_names_without_threshold, na.rm = na.rm, replace = replace,...)
  
  if(longest_dry_spell) {
    
    # rain is requied
    data_list = add_to_data_info_required_variable_list(data_list, rain_label)
    # date time period is "daily"
    data_list = add_to_data_info_time_period(data_list, daily_label)
    # a list of climate data objects
    climate_data_objs = get_climate_data_objects(data_list)
    
    for(data_obj in climate_data_objs) {
      curr_threshold = data_obj$get_meta(threshold_label,missing(threshold),threshold)
      data_obj$add_spell_length_col(col_name = spell_length_name, threshold = curr_threshold)
    }
    
    seasonal_summary(data_list = data_list, variable_to_summarize = spell_length_label, month_start = month_start, number_month = number_month, summaries = max_label, month_col_names = month_col_names, summary_col_names = longest_dry_spell_name, na.rm = na.rm, replace = replace)
  }
  
}
)
