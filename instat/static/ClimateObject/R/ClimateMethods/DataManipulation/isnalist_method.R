# number of NAs in a vector
#' @title Get the number of nAs in a particular vector
#' @name isna.list
#' @author Frederic Ntirenganya 2015 (AMI)
#' 
#' @description \code{NAs in a vector }
#' find out how many NAs are in a particular vector
#'  
#' @return It returs the number of NAs.

climate$methods(isna.list = function(data_list = list(), var, period = daily_label ){
  #=======================================================
  #this method find out how many NAs are in a particular vector
  #========================================================
  # required variable
  data_list=add_to_data_info_required_variable_list(data_list, list(var))
  
  data_list=add_to_data_info_time_period(data_list, period)
  
  climate_data_objs = get_climate_data_objects(data_list)
  
  for(data_obj in climate_data_objs) {
    
    var_col = data_obj$getvname(var)    
    # access data in methods .
    curr_data_list = data_obj$get_data_for_analysis(data_list)
    
    for( curr_data in curr_data_list ) {
      number_NAs <- length(which(is.na(curr_data[[var_col]]) == TRUE))
    }
    print(number_NAs)
    
  }
}
)

