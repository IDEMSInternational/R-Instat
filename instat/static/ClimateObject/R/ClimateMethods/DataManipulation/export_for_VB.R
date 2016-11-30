#' Export of dataframes from VB.NET
#' @title Output dataframes in the form needed for VB.
#' @name export_for_VB
#' @author Abib Duut 2015

#' @description \code{export_for_VB} 
#' returns a list of dataframes in the format required for  VB forms.


climate$methods(export_for_VB = function(data_list = list())
{ 
  
  # use data_list to get the required data objects
  climate_data_objs = get_climate_data_objects( data_list )
  
        for(data_obj in climate_data_objs){
            curr_data_list = data_obj$get_data_for_analysis(data_list)
            N<-length(data_list)
            tmp_curr_data<-vector("list", N)
              for( i in 1:N ) {
                tmp_curr_data[[i]]<-curr_data_list[[i]]
              }
      
          }  
  tmp_curr_data
  }
)