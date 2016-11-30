
climate$methods(Number_missing_values=function( data_list=list(), interest_var=rain_label,data_period_label=daily_label,colname_year="Year",
                                              colname_missing="Nos of Missing observations",period=year_label){ 
  #--------------------------------------------------------------------------------------------#
  # This function returns a data frame with two columns, the first one containing  years and the second
  #      one the number of missing obsevations per year. 
  #-------------------------------------------------------------------------------------------#
  
  # rain variable is required for this method
  data_list = add_to_data_info_required_variable_list( data_list, list(interest_var) )
  
  # daily data is required for this method
  data_list=add_to_data_info_time_period( data_list, data_period_label)
  
  # use data_list to get the required data objects
  climate_data_objs = get_climate_data_objects( data_list )
  #print(climate_data_objs)
  # Initialise output
  out = list()
  j = 1
  
  for( data_obj in climate_data_objects ){
    #If no column of years present
    if( !(data_obj$is_present(year_label) ) ) {
      data_obj$add_year_month_day_cols()
    }
    
    period_col = data_obj$getvname(period)
    interest_col = data_obj$getvname(interest_var)
    print(period_col);print(interest_col)  
    # Access data in methods
    curr_data_list = data_obj$get_data_for_analysis(data_list)
    
    for( curr_data in curr_data_list ) {
      #getting the number of missing values per year
      missing_data <- aggregate(is.na(curr_data[[interest_col]]), by=list(curr_data[[c(period_col)]]), FUN=sum)
     
      #Name the columns
      names(missing_data)<-c(colname_year,colname_missing)      
    }
    out[[j]] = missing_data
    # Give the name of each data to each element in the list out
    names(out)[[j]] = data_obj$get_meta( data_name_label )
    j = j+1
  }
  return( out )
}
)
