#' Create Climate Data Objects.
#' This is for Instat,which is dependent on the load_files_VB().
#' @title create_climate_object().  
#' @name create_climate_object()
#' @author Abib Duut 2015 
#'
#'@description \code{create_climate_object} 
#' This creates climate data objects for one or multiple files, however this is best used to create data objects for 
#' multiple files.This would be used for as a backend fucntion for the new Instat which is an interfacing of R with VB.NET
#' This fun
#' @param data_path_list 
#' this can either be the full absolute path of data files or absolute path of a directory containing datafiles.
#' @examples
#'        create_climate_obj() # run this line in the working directory of your files.
#' @return This would return a list of climate data objects.
#'------------------------------------------------------------------------------------------------
#'------------------------------------------------------------------------------------------------
  create_climate_obj<-function(data_path_list=list(), climate_obj_meta_data = list(), 
                                  data_tables_meta_data = rep(list(list()),length(data_tables)),
                                  data_tables_variables = rep(list(list()),length(data_tables)), 
                                  imported_from = as.list(rep("",length(data_tables))),
                                  data_time_periods = as.list(rep("daily",length(data_tables))),
                                  messages=TRUE, convert=TRUE, create=TRUE,
                                  date_formats = as.list(rep("%d/%m/%Y",length(data_tables)))){
                                    
     data_tables<-load_files_VB(data_path_list = data_path_list)
    
    clidata_obj<-climate$new(data_tables=data_tables, climate_obj_meta_data =climate_obj_meta_data, data_tables_meta_data = data_tables_meta_data ,data_tables_variables =data_tables_variables , 
                           imported_from =imported_from,data_time_periods = data_time_periods,messages=messages, convert=convert, create=create, date_formats=date_formats)
    

    clidata_obj
      }

    

