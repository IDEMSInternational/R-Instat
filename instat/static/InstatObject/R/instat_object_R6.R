instat_object <- R6Class("instat_object",
                  public = list(
                    initialize = function(data_tables = list(), instat_obj_metadata = list(), 
                                          data_tables_variables_metadata = rep(list(data.frame()),length(data_tables)),
                                          data_tables_metadata = rep(list(list()),length(data_tables)),
                                          imported_from = as.list(rep("",length(data_tables))),
                                          messages=TRUE, convert=TRUE, create=TRUE) 
{ 
    self$set_meta(instat_obj_metadata)
    self$set_models(list())
                      
    if (missing(data_tables) || length(data_tables) == 0) {
    private$.data_objects <- list()
    }
                      
    else {
    self$import_data(data_tables=data_tables, data_tables_variables_metadata=data_tables_variables_metadata, 
    data_tables_metadata=data_tables_metadata, 
    imported_from=imported_from, messages=messages, convert=convert, create=create)
    }
                      
    private$.data_objects_changed <- FALSE
    }
                                            
                                            

                   
                    
                  ),
                  private = list(
                    .data_objects = list(),
                    .metadata = list(),
                    .models = list(),
                    .data_objects_changed = FALSE
                  ),
                  active = list(
                    data_objects_changed = function(new_value) {
                      if(missing(new_value)) return(private$.data_objects_changed)
                      else {
                        if(new_value != TRUE && new_value != FALSE) stop("new_value must be TRUE or FALSE")
                        private$.data_objects_changed <- new_value
                      }
                    }
                  )
)

instat_object$set("public", "import_data", function(data_tables = list(), data_tables_variables_metadata = rep(list(data.frame()),length(data_tables)),
                                          data_tables_metadata = rep(list(list()),length(data_tables)),
                                          imported_from = as.list(rep("",length(data_tables))), 
                                          messages=TRUE, convert=TRUE, create=TRUE)
{
  if (missing(data_tables) || length(data_tables) == 0) {
    stop("No data found. No data objects can be created.")
  }
  
  else {
    
    if (!(class(data_tables) == "list"))  {
      stop("data_tables must be a list of data frames")
    }
    
    if (length(unique(names(data_tables))) != length(names(data_tables)) ) {
      stop("There are duplicate names in the data tables list.")
    }
    
    if (!(length(data_tables_variables_metadata) == length(data_tables))) { 
      stop("If data_tables_variables_metadata is specified, it must be a list of metadata lists with the same
           length as data_tables.")
    }
    
    if (!(length(data_tables_metadata) == length(data_tables))) { 
      stop("If data_tables_metadata is specified, it must be a list of metadata lists with the same
           length as data_tables.")
    }
    
    if (length(imported_from) != length(data_tables) ) { 
      stop("imported_from must be a list of the same length as data_tables")
    }
    
    # loop through the data_tables list and create a data object for each
    # data.frame given
    new_data_objects = list()
    
    for ( i in (1:length(data_tables)) ) {
      new_data = data_object$new(data=data_tables[[i]], data_name = names(data_tables)[[i]],
                              variables_metadata = data_tables_variables_metadata[[i]],
                              metadata = data_tables_metadata[[i]], 
                              imported_from = imported_from[[i]], 
                              start_point = i, 
                              messages = messages, convert = convert, create = create)
      # Add this new data object to our list of data objects
      self$append_data_object(new_data$get_metadata(data_name_label), new_data)
    }
    }
  }
)

# Import RDS FUNCTION
##############################################################################################
# instat_object$set("public", "import_RDS", function(data_RDS, keep_existing =TRUE, overwrite_existing=FALSE, include_models=TRUE,
#                                          include_graphics=TRUE, include_metadata=TRUE, include_logs=TRUE,messages=TRUE)
# { 
#   if(class(data_RDS) == "instat_object"){ 
#     if (!keep_existing & include_models & include_graphics & include_metadata & include_logs){
#       self$replace_instat_object(new_instatObj = data_RDS)
#     } else {
#       if (!keep_existing) {
#         self$clear_data()
#         self$set_meta(list())
#         self$set_models(list())
#       }
#       for ( i in (1:length(data_RDS$data_objects)) ) {
#         if (!(data_RDS$data_objects[[i]]$metadata[[data_name_label]] %in% names(private$.data_objects)) | overwrite_existing){
#           #TODO in data_object if (!include_models) data_RDS$data_objects[i]$clear_models
#           #TODO in data_object if (!include_graphics) data_RDS$data_objects[i]$clear_graphics
#           if (!include_metadata) {
#             data_RDS$data_objects[[i]]$set_meta(list()) 
#             data_RDS$data_objects[[i]]$set_variables_metadata(data.frame()) 
#             
#           }
#           if (!include_logs) data_RDS$data_objects[i]$set_changes(list())
#           # Add this new data object to our list of data objects
#           self$append_data_objects(data_RDS$data_objects[[i]]$metadata[[data_name_label]],data_RDS$data_objects[[i]])
#         }
#       }
#       if (include_models & length(data_RDS$models) > 0){
#         for ( i in (1:length(data_RDS$models)) ) {
#           if (!(names(data_RDS$models)[i] %in% names(private$models)) | overwrite_existing){ 
#             self$add_model(data_RDS$models[i],names(data_RDS$models)[i])
#           }
#         }
#       }
#       if (include_metadata & length(data_RDS$metadata) > 0){
#         for ( i in (1:length(data_RDS$metadata)) ) {
#           if (!(names(data_RDS$metadata)[i] %in% names(private$metadata)) | overwrite_existing){ 
#             self$metadata[names(data_RDS$models)[i]] <- data_RDS$metadata[i] #todo this should be in an addmetadata method
#           }
#         }
#       }
#     }
#     private$.data_objects_changed <- TRUE
#   }
#   else if (is.data.frame(data_RDS)) {
#     self$import_data(data_tables = list(data_RDS = data_RDS))
#   }
#   else{
#     if (messages){
#       stop(paste("RDS_data: ", data_RDS, " Unidentified Object"))#TODO work on messages and error handling
#     }
#   }
# }
# )

instat_object$set("public", "replace_instat_object", function(new_instatObj) {
  self$set_data_objects(new_instatObj$get_data_objects())
  self$set_meta(new_instatObj$get_metadata())
  self$set_models(new_instatObj$get_models())
  self$data_objects_changed <- TRUE
}
)

instat_object$set("public", "set_data_objects", function(new_data_objects) {
  if(!is.list(new_data_objects) || !all(lapply(new_objects_list, class)=="data_object")) stop("new_data_objects must be a list of data_objects")
  else private$.data_objects <- new_data_objects
}
)


instat_object$set("public", "set_meta", function(new_meta) {
  if(!is.list(new_meta)) stop("new_meta must be of type: list")
    
  private$.metadata <- new_meta
}
)

instat_object$set("public", "set_models", function(new_models) {
  if(!is.list(new_models)) stop("new_models must be of type: list")
  
  private$.models <- new_models 
}
)

instat_object$set("public", "append_data_object", function(name, obj) {
  if( !class(name) == "character") {
    stop("name must be a character")
  }
  
  if ( !"data_object" %in% class(obj)) {
    stop("obj must be a data object")
  }
  
  private$.data_objects[[name]] <- obj 
}
)

instat_object$set("public", "get_data_objects", function(data_name) {
  if(missing(data_name)) {
    return(private$.data_objects)
  }
  else{
    if(all(is.character(data_name))) type = "character"
    else if(all(is.numeric(data_name)) && all((data_name %% 1) == 0)) type = "integer"
    else stop("data_name must be of type character or integer")
    
    if(type=="character" && !all(data_name %in% names(private$.data_objects))) stop(paste(data_name, "not found"))
    if(type=="integer" && (!all(1 <= data_name) || !all(data_name <= length(private$.data_objects)))) stop(paste(data_name, "not found"))
    if(length(data_name) > 1) return(private$.data_objects[data_name])
    else return(private$.data_objects[[data_name]])
  }
}
)

instat_object$set("public", "get_data_frame", function(data_name, convert_to_character = FALSE, stack_data = FALSE,...) {
  if(!stack_data) {
    if(missing(data_name)) {
      retlist <- list()
      for ( i in (1:length(private$.data_objects)) ) {
        retlist[[names(private$.data_objects)[[i]]]] = data_objects[[i]]$get_data_frame(convert_to_character = convert_to_character)
      }
      return(retlist)
    }
    else return(self$get_data_objects(data_name)$get_data_frame(convert_to_character = convert_to_character))
  }
  else {
    if(missing(data_name)) stop("data to be stacked is missing")
    if(!data_name %in% names(private$.data_objects)) stop(paste(data_name, "not found."))
    return(melt(self$get_data_objects(data_name)$get_data_frame(), ...))
  }
}
)

instat_object$set("public", "get_variables_metadata", function(data_name, data_type = "all", convert_to_character = FALSE) { 
  if(missing(data_name)) {
    retlist <- list()
    for (curr_obj in private$.data_objects) {
      retlist[[curr_obj$get_metadata(data_name_label)]] = curr_obj$get_variables_metadata(data_type = data_type, convert_to_character = convert_to_character)
    }
    return(retlist)
  }
  else return(self$get_data_objects(data_name)$get_variables_metadata(data_type = data_type, convert_to_character = convert_to_character))
} 
)

instat_object$set("public", "get_combined_metadata", function(convert_to_character = FALSE) { 
  retlist <- data.frame()
  for (curr_obj in private$.data_objects) {
    templist = curr_obj$get_metadata()
    for ( j in (1:length(templist)) ) {
      retlist[curr_obj$get_metadata(data_name_label), names(templist[j])] = templist[[j]]         
    }
  }
  if(convert_to_character) return(convert_to_character_matrix(retlist, FALSE))
  else return(retlist)
} 
)

instat_object$set("public", "get_data_names", function() { 
  return(names(private$.data_objects))
} 
)

instat_object$set("public", "get_data_changed", function(data_name) {
  if(missing(data_name)) {
    if(self$data_objects_changed) return (TRUE)
    for(curr_obj in private$.data_objects) {
      if(curr_obj$data_changed) return(TRUE)
    }
    return(FALSE)
  }
  else {
    return(self$get_data_objects(data_name)$data_changed)
  }
} 
)

instat_object$set("public", "get_variables_metadata_changed", function(data_obj) { 
  if(missing(data_obj)) {
    if(private$.data_objects_changed) return(TRUE)
    return(any(lapply(private$.data_objects, function(x) x$variables_metadata_changed)))
  }
  else {
    return(self$get_data_objects(data_obj)$variables_metadata_changed)
  }
} 
)

instat_object$set("public", "get_metadata_changed", function(data_obj) { 
  if(missing(data_obj)) {
    if(private$.data_objects_changed) return (TRUE)
    for(curr_obj in private$.data_objects) {
      if(curr_obj$metadata_changed) return(TRUE)
    }
    return(FALSE)
  }
  else {
    return(self$get_data_objects(data_obj)$metadata_changed)
  }
} 
)

instat_object$set("public", "set_data_frames_changed", function(data_name = "", new_val) {
  if(data_name == "") {
    for(curr_obj in private$.data_objects) {
      curr_obj$data_changed <- new_val
    }
  }
  
  else self$get_data_objects(data_name)$set_data_changed(new_val)
  
} 
)

instat_object$set("public", "set_variables_metadata_changed", function(data_name = "", new_val) {
  if(data_name == "") {
    for(curr_obj in private$.data_objects) {
      curr_obj$variables_metadata_changed <- new_val
    }
  }
  
  else self$get_data_objects(data_name)$set_variables_metadata_changed(new_val)
} 
)

instat_object$set("public", "set_metadata_changed", function(data_name = "", new_val) {
  if(data_name == "") {
    for(curr_obj in private$.data_objects) {
      curr_obj$set_metadata_changed(new_val)
    }
  }
  
  else self$get_data_objects(data_name)$set_metadata_changed(new_val)
} 
)

instat_object$set("public", "add_columns_to_data", function(data_name, col_name, col_data, use_col_name_as_prefix) {
  if(missing(data_name)) stop("data_name is required")
  if(!data_name %in% names(private$.data_objects)) stop(paste(data_name, "not found"))
  
  if(missing(use_col_name_as_prefix)) private$.data_objects(data_name)$add_columns_to_data(col_name, col_data)
  else self$get_data_objects(data_name)$add_columns_to_data(col_name, col_data, use_col_name_as_prefix = use_col_name_as_prefix)
}
)

instat_object$set("public", "get_columns_from_data", function(data_name, col_names, from_stacked_data = FALSE,
                                                    force_as_data_frame = FALSE) {
  if(missing(data_name)) stop("data_name is required")
  if(!from_stacked_data) {
    if(!data_name %in% names(private$.data_objects)) stop(paste(data_name, "not found"))
    self$get_data_objects(data_name)$get_columns_from_data(col_names, force_as_data_frame)
  }
  else {
    if(!exists(data_name)) stop(paste(data_name, "not found."))
    if(!all(sapply(col_names, function(x) x %in% names(data_name)))) stop("Not all column names were found in data")
    if(length(col_names)==1) return (data_name[[col_names]])
    else return(data_name[col_names])
  }
}
)

instat_object$set("public", "add_model", function(model, model_name = paste("model",length(models)+1)) {
  if(missing(model)) stop("model is required")
  if(model_name %in% names(private$.models)) message(paste("A model called", model_name, "already exists. It will be replaced."))
  
  private$.models[[model_name]] <- model #self$set_models(private$.models[[model_name]])
}
) 

instat_object$set("public", "get_model", function(model_name) {
  if(missing(model_name)) stop("model_name must be given.")
  if(!is.character(model_name)) stop("name must be a character")
  if(!model_name %in% names(private$.models)) stop(model_name, "not found in models")
  private$.models[[model_name]]
}
)

instat_object$set("public", "get_model_names", function() {
  return(names(private$.models))
}
)

instat_object$set("public", "replace_value_in_data", function(data_name, col_name, index, new_value) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  self$get_data_objects(data_name)$replace_value_in_data(col_name, index, new_value)
} 
)

instat_object$set("public", "rename_column_in_data", function(data_name, column_name, new_val) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  self$get_data_objects(data_name)$rename_column_in_data(column_name, new_val)
} 
)

instat_object$set("public", "remove_columns_in_data_from_start_position", function(data_name, start_pos, col_numbers) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  self$get_data_objects(data_name)$remove_columns_in_data_from_start_position(start_pos = start_pos, col_numbers = col_numbers)
} 
)

instat_object$set("public", "remove_columns_in_data", function(data_name, cols) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  self$get_data_objects(data_name)$remove_columns_in_data(cols = cols)
} 
)

instat_object$set("public", "remove_rows_in_data", function(data_name, start_pos, num_rows) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  self$get_data_objects(data_name)$remove_rows_in_data(start_pos  = start_pos, num_rows = num_rows)
} 
)

instat_object$set("public", "get_next_default_column_name", function(data_name, prefix) {
  if(missing(data_name)) {
    out = list()
    for(curr_obj in private$.data_objects) {
      out[[curr_obj$get_metadata(data_name_label)]] = curr_obj$get_next_default_column_name(prefix)
    }
    return(out)
  }
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  return(self$get_data_objects(data_name)$get_next_default_column_name(prefix))
} 
)

instat_object$set("public", "get_column_names", function(data_name) {
  if(missing(data_name)) stop("data_name must be given")
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  return(names(self$get_data_objects(data_name)$data))
}
)

instat_object$set("public", "insert_column_in_data", function(data_name, col_data =c(), start_pos, number_cols) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  self$get_data_objects(data_name)$insert_column_in_data(col_data = col_data, start_pos = start_pos, number_cols = number_cols )
}
)

# instat_object$set("public", "move_columns_in_data", function(data_name, col_names = "", col_number){
#   if(!is.character(data_name)) stop("data_name must be of type character")
#   if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
#   
#   self$get_data_objects(data_name)$move_columns_in_data(col_names = col_names, col_number = col_number)
# }
# )

instat_object$set("public", "order_columns_in_data", function(data_name, col_order){
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  self$get_data_objects(data_name)$order_columns_in_data(col_order = col_order)
}
)

instat_object$set("public", "insert_row_in_data", function(data_name, start_pos, row_data = c(), number_rows) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  self$get_data_objects(data_name)$insert_row_in_data(start_pos  = start_pos, row_data = row_data, number_rows = number_rows)
}
)

instat_object$set("public", "length_of_data", function(data_name) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  self$get_data_objects(data_name)$length_of_data()
}
)

instat_object$set("public", "get_next_default_dataframe_name", function(prefix, include_index = TRUE, start_index = 1) {
  next_default_item(prefix = prefix, existing_names = names(private$.data_objects), include_index = include_index, start_index = start_index)
} 
)

instat_object$set("public", "delete_dataframe", function(data_name) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  # TODO need a set or append
  data_objects[[data_name]]<<-NULL
  data_objects_changed <<- TRUE
} 
)

instat_object$set("public", "get_column_factor_levels", function(data_name,col_name = "") {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  self$get_data_objects(data_name)$get_column_factor_levels(col_name)
} 
)

instat_object$set("public", "sort_dataframe", function(data_name, col_names = c(), decreasing = FALSE, na.last = TRUE) {
  #data_name = is.character(data_name)
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  self$get_data_objects(data_name)$sort_dataframe(col_names = col_names, decreasing = decreasing, na.last = na.last)
} 
)

instat_object$set("public", "rename_dataframe", function(data_name, new_value = "") {
  data_obj = self$get_data_objects(data_name)
  names(private$.data_objects)[names(private$.data_objects) == data_name] <- new_value
  data_obj$append_to_metadata(data_name_label, new_value)
} 
)

instat_object$set("public", "convert_column_to_type", function(data_name, col_names = c(), to_type ="factor", factor_numeric = "by_levels") {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  self$get_data_objects(data_name)$convert_column_to_type(col_names = col_names, to_type = to_type, factor_numeric = factor_numeric)
} 
)

instat_object$set("public", "append_to_variables_metadata", function(data_name, col_name, property, new_val) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  self$get_data_objects(data_name)$append_to_variables_metadata(col_name, property, new_val)
} 
)

instat_object$set("public", "append_to_dataframe_metadata", function(data_name, property, new_val) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  self$get_data_objects(data_name)$append_to_metadata(property, new_val)
} 
)

instat_object$set("public", "order_dataframes", function(data_frames_order) {
  if(length(data_frames_order) != length(names(private$.data_objects))) stop("number data frames to order should be equal to number of dataframes in the object")
  if(!setequal(data_frames_order,names(private$.data_objects))) stop("data_frames_order must be a permutation of the dataframe names.")

  self$set_data_objects(data_objects[names(data_frames_order)])
  self$data_objects_changed <- TRUE
} 
)

instat_object$set("public", "copy_columns", function(data_name, col_names = "") {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  self$get_data_objects(data_name)$copy_columns(col_names = col_names)
} 
)

instat_object$set("public", "drop_unused_factor_levels", function(data_name, col_name) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  self$get_data_objects(data_name)$drop_unused_factor_levels(col_name = col_name)
} 
)

instat_object$set("public", "set_factor_levels", function(data_name, col_name, new_levels) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  self$get_data_objects(data_name)$set_factor_levels(col_name = col_name, new_levels = new_levels)
} 
)

instat_object$set("public", "set_factor_reference_level", function(data_name, col_name, new_ref_level) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  self$get_data_objects(data_name)$set_factor_reference_level(col_name = col_name, new_ref_level = new_ref_level)
} 
)

instat_object$set("public", "get_column_count", function(data_name) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  return(ncol(self$get_data_objects(data_name)$data))
} 
)

instat_object$set("public", "reorder_factor_levels", function(data_name, col_name, new_level_names) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  self$get_data_objects(data_name)$reorder_factor_levels(col_name = col_name, new_level_names = new_level_names)
} 
)



