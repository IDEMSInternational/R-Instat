#=============================================================================
# Boxplot for count of variable.
#' @title Boxplot for count 
#' @name boxplot_count_variable
#' @author Abib Duut 2015 

#' @description \code{boxplot_count_variable} 
#' Creates boxplot for any given variable for any time_period from the climate object
#' 
#' @param data_list list. 
#' 
#' @param timeperiod character. Type of boxplot to plot. It can be either
#' "subyearly", "year", "season". Default value: "subyearly" 
#  
#' @examples
#' climObj <- climate(data_tables=list(data),date_format="%Y-%m-%d")
#' # where "data" is a data.frame containing the desired data to be plotted.
#' climObj$boxplot_count_variable()
#' @return boxplot plot
#' 
climate$methods( boxplot_count_variable = function(data_list= list(), timeperiod= subyearly, var_label= rain_label,varwidth=F, fill_col="blue", whisker_col="red", title="Boxplot of Monthly Rainy Days for all Years",whisklty=1){
  #--------------------------------------------------------------------------------------------#
  # This function plots the boxplot of the number of rain per month for all the years in the data 
  #     set
  #-------------------------------------------------------------------------------------------#
  # convert_data need to be set to TRUE. I am not sure of how to insert it without doing the following
  time_period<-paste(time_period, "_label")
  data_list=list(convert_data=TRUE)
  
  # rain variable is required for this method
  data_list = add_to_data_info_required_variable_list( data_list, list(var_label) )
  # subyearly data is required for this method
  data_list=add_to_data_info_time_period( data_list, time_period )
  # use data_list to get the required data objects
  climate_data_objs = get_climate_data_objects( data_list ) 
  
  for( data_obj in climate_data_objs){
    data_name = data_obj$get_meta(data_name_label)
    
    if( ! data_obj$is_present( time_period ) ){
      data_obj$add_year_month_day_cols()
    }
    # Get the title of the column of months
    time_col = data_obj$getvname(time_period )
    
    # Access data in methods
    curr_data_list = data_obj$get_data_for_analysis(data_list)
    
    for( curr_data in curr_data_list ) {
      # Draw the monthly boxplot
      boxplot( curr_data[["Number of Rain Days"]]~curr_data[[time_col]], whiskcol=whisker_col,col=fill_col, xlab=timeperiod,ylab="Count of Rain Days",
               main= c( data_name, title), whisklty=whisklty, varwidth=T )
    } 
  }
}
)
