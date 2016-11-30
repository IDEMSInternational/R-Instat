 # Missing Data Table 
#' @title Missing Data Table
#' @name missing data table
#' @author Abib Duut 2015
#' 
#' @description \code{missing data table}
#' This displays a table of missing data. 
#'  
#' @return a table of the number of missing data for each year. For years with more than twenty missing
#' are removed.



climate$methods( missing_data_table=function( data_list=list(), var_label = rain_label ){ 
  
  
      #Require the columns needed in this method from the data.
      data_list = add_to_data_info_required_variable_list( data_list, list(var_label, date_label) )
      
      # yearly data is required for this method
      data_list=add_to_data_info_time_period( data_list, yearly_label )
      #print(data_list)
      
      # use data_list to get the required data objects
      climate_data_objs = get_climate_data_objects( data_list )
      
      # Initialise output
      out = list()
      j = 1
      
  for( data_obj in climate_data_objects ){
    var_col = data_obj$getvname(var_label)
    
    #If no column of years present
    if( !(data_obj$is_present(year_label) ) ) {
      data_obj$add_year_month_day_cols()
    }
    year_col = data_obj$getvname(year_label)
        
    # Access data in methods
    curr_data_list = data_obj$get_data_for_analysis(data_list)
    
    for( curr_data in curr_data_list ) {
        
        # Add a column of rain to the data with a specific: "Rain" name for ddply use
        curr_data = cbind(curr_data, new_rain=curr_data[[var_col]])
        cm<-ddply( curr_data, c(Year = year_col), summarize, C = sum(is.na(new_rain)))
        if(sum(cm$C)==0) {
              out[[j]]<-"100% present, no data missing"
              names(out)[[j]] = data_obj$get_meta( data_name_label )
          
          }else{
                  cm1<-cm[cm$C>0,]
                  names(cm1)<-c("Year","Nos of Missing Days")
                  cm1<-as.list(cm1)
                  cm1<-as.data.frame(cm1)
                  curr_data$new_rain=NULL
                  out[[j]] = cm1
                  # Give the name of each data to each element in the list out
                  names(out)[[j]] = data_obj$get_meta( data_name_label )
      }  
    }
    
    
    j = j+1
  }
  return( out )
}
)

#-----------------------------------------------------------------------------------------------------#
#-----------------------------------------------------------------------------------------------------#
