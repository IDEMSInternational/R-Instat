instat_object <- R6Class("instat_object",
                  public = list(
                    initialize = function(data_tables = list(), instat_obj_metadata = list(), 
                                          data_tables_variables_metadata = rep(list(data.frame()),length(data_tables)),
                                          data_tables_metadata = rep(list(list()),length(data_tables)),
                                          data_tables_filters = rep(list(list()),length(data_tables)),
                                          imported_from = as.list(rep("",length(data_tables))),
                                          messages=TRUE, convert=TRUE, create=TRUE) 
{ 
    self$set_meta(instat_obj_metadata)
    self$set_models(list())
                      
    if (missing(data_tables) || length(data_tables) == 0) {
    self$set_data_objects(list())
    }
                      
    else {
    self$import_data(data_tables=data_tables, data_tables_variables_metadata=data_tables_variables_metadata, 
    data_tables_metadata=data_tables_metadata, 
    imported_from=imported_from, messages=messages, convert=convert, create=create, data_tables_filters = data_tables_filters)
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
                      #TODO is this behaviour we want?
                      sapply(self$get_data_objects(), function(x) x$data_changed <- new_value)
                    }
                  }
                )
)

instat_object$set("public", "import_data", function(data_tables = list(), data_tables_variables_metadata = rep(list(data.frame()),length(data_tables)),
                                                    data_tables_metadata = rep(list(list()),length(data_tables)),
                                                    data_tables_filters = rep(list(list()),length(data_tables)),
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
                                 messages = messages, convert = convert, create = create, 
                                 filters = data_tables_filters[[i]])
      # Add this new data object to our list of data objects
      self$append_data_object(new_data$get_metadata(data_name_label), new_data)
    }
  }
}
)

instat_object$set("public", "replace_instat_object", function(new_instatObj) {
  self$set_data_objects(new_instatObj$get_data_objects())
  self$set_meta(new_instatObj$get_metadata())
  self$set_models(new_instatObj$get_models())
  self$data_objects_changed <- TRUE
  lapply(new_instatObj$get_data_objects(), function(x) x$set_data_changed(TRUE))
}
)

instat_object$set("public", "set_data_objects", function(new_data_objects) {
  if(!is.list(new_data_objects) || (length(new_data_objects) > 0 && !all("data_object" %in% sapply(new_data_objects, class)))) {
    stop("new_data_objects must be a list of data_objects")
  }
  else private$.data_objects <- new_data_objects
}
)

#' Title
#'
#' @param data_RDS 
#' @param keep_existing 
#' @param overwrite_existing 
#' @param include_models 
#' @param include_graphics 
#' @param include_metadata 
#' @param include_logs 
#' @param messages 
#'
#' @return
#' @export
#'
#' @examples
instat_object$set("public", "import_RDS", function(data_RDS, keep_existing =TRUE, overwrite_existing=FALSE, include_models=TRUE,
                                         include_graphics=TRUE, include_metadata=TRUE, include_logs=TRUE,messages=TRUE)
{ 
  if("instat_object" %in% class(data_RDS)) {
    if(!keep_existing && include_models && include_graphics && include_metadata && include_logs) {
      self$replace_instat_object(new_instatObj = data_RDS) 
    } 
    else {
      if(!keep_existing) {
        self$set_data_objects(list())
        self$set_meta(list())
        self$set_models(list())
      }
      for ( curr_data_obj in data_RDS$get_data_objects() ) {
        if (!(curr_data_obj$get_metadata(data_name_label) %in% self$get_data_names()) || overwrite_existing){
          #TODO in data_object if (!include_models) data_RDS$data_objects[i]$clear_models
          #TODO in data_object if (!include_graphics) data_RDS$data_objects[i]$clear_graphics
          curr_data_name = curr_data_obj$get_metadata(data_name_label)
          if (!include_metadata) {
            curr_data_obj$set_meta(list()) 
            curr_data_obj$add_defaults_meta()
            curr_data_obj$set_variables_metadata(data.frame())
            curr_data_obj$update_variables_metadata() 
          }
          if (!include_logs) curr_data_obj$set_changes(list())
          # Add this new data object to our list of data objects
          self$append_data_object(curr_data_name,curr_data_obj)
        }
      }
      new_models_list = data_RDS$get_models()
      new_models_count = length(new_models_list)
      if (include_models && new_models_count > 0) {
        for ( i in (1:new_models_count) ) {
          if (!(names(new_models_list)[i] %in% names(private$.models)) || overwrite_existing) { 
            self$add_model(new_models_list[i],names(new_models_list)[i])
          }
        }
      }
      new_metadata = data_RDS$get_metadata()
      new_metadata_count = length(new_metadata)
      if (include_metadata & new_metadata_count > 0) {
        for ( i in (1:new_metadata_count) ) {
          if (!(names(new_metadata)[i] %in% names(metadata)) || overwrite_existing) {
            self$append_to_metadata(names(new_metadata)[i], new_metadata[[i]])
          }
        }
      }
    }
    self$data_objects_changed <- TRUE
  }
  else if (is.data.frame(data_RDS)) {
    self$import_data(data_tables = list(data_RDS = data_RDS))
  }
  else{
    if (messages){
      stop(paste("Cannot import an object of type", class(data_RDS))) #TODO work on messages and error handling
    }
  }
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

instat_object$set("public", "get_data_frame", function(data_name, convert_to_character = FALSE, stack_data = FALSE, include_hidden_columns = TRUE, use_current_filter = FALSE,...) {
  if(!stack_data) {
    if(missing(data_name)) {
      retlist <- list()
      for ( i in (1:length(private$.data_objects)) ) {
        retlist[[names(private$.data_objects)[[i]]]] = data_objects[[i]]$get_data_frame(convert_to_character = convert_to_character, include_hidden_columns = include_hidden_columns, use_current_filter = use_current_filter)
      }
      return(retlist)
    }
    else return(self$get_data_objects(data_name)$get_data_frame(convert_to_character = convert_to_character, include_hidden_columns = include_hidden_columns, use_current_filter = use_current_filter))
  }
  else {
    if(missing(data_name)) stop("data to be stacked is missing")
    if(!data_name %in% names(private$.data_objects)) stop(paste(data_name, "not found."))
    return(melt(self$get_data_objects(data_name)$get_data_frame(include_hidden_columns = include_hidden_columns, use_current_filter = use_current_filter), ...))
  }
}
)

instat_object$set("public", "get_variables_metadata", function(data_name, data_type = "all", convert_to_character = FALSE, property, column) { 
  if(missing(data_name)) {
    retlist <- list()
    for (curr_obj in private$.data_objects) {
      retlist[[curr_obj$get_metadata(data_name_label)]] = curr_obj$get_variables_metadata(data_type = data_type, convert_to_character = convert_to_character, property = property, column = column)
    }
    return(retlist)
  }
  else return(self$get_data_objects(data_name)$get_variables_metadata(data_type = data_type, convert_to_character = convert_to_character, property = property, column = column))
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

instat_object$set("public", "get_metadata", function(name) {
  if(missing(name)) return(private$.metadata)
  if(!is.character(name)) stop("name must be a character")
  if(!name %in% names(private$.metadata)) stop(paste(name, "not found in metadata"))
  return(private$.metadata[[name]])
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
    return(any(sapply(private$.data_objects, function(x) x$variables_metadata_changed)))
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

instat_object$set("public", "dataframe_count", function() {
  return(length(private$.data_objects))
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

instat_object$set("public", "add_columns_to_data", function(data_name, col_name, col_data, use_col_name_as_prefix = FALSE, hidden = FALSE, before = FALSE, adjacent_column, num_cols) {
  if(missing(use_col_name_as_prefix)) self$get_data_objects(data_name)$add_columns_to_data(col_name, col_data, hidden = hidden, before = before, adjacent_column = adjacent_column, num_cols = num_cols)
  else self$get_data_objects(data_name)$add_columns_to_data(col_name, col_data, use_col_name_as_prefix = use_col_name_as_prefix, hidden = hidden, before = before, adjacent_column = adjacent_column, num_cols = num_cols)
}
)

instat_object$set("public", "get_columns_from_data", function(data_name, col_names, from_stacked_data = FALSE,
                                                    force_as_data_frame = FALSE, use_current_filter = FALSE) {
  if(missing(data_name)) stop("data_name is required")
  if(!from_stacked_data) {
    if(!data_name %in% names(private$.data_objects)) stop(paste(data_name, "not found"))
    self$get_data_objects(data_name)$get_columns_from_data(col_names, force_as_data_frame, use_current_filter = use_current_filter)
  }
  else {
    if(!exists(data_name)) stop(paste(data_name, "not found."))
    if(!all(sapply(col_names, function(x) x %in% names(data_name)))) stop("Not all column names were found in data")
    if(length(col_names)==1 && !force_as_data_frame) return (data_name[[col_names]])
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

instat_object$set("public", "get_models", function(model_name) {
  if(missing(model_name)) return(private$.models)
  if(!is.character(model_name)) stop("name must be a character")
  if(!model_name %in% names(private$.models)) stop(model_name, "not found in models")
  private$.models[[model_name]]
}
)

instat_object$set("public", "get_from_model", function(model_name, value1, value2, value3) {
  curr_model = self$get_models(model_name)
  if(missing(value1)) stop("value1 must be specified.")
  if(!value1 %in% names(curr_model)) stop(paste(value1, "not found in", model_name))
  if(missing(value2)) {
    if(!missing(value3)) warning(paste("value2 is missing so value3 =",value3, "will be ignored."))
    return(curr_model[[value1]])
  }
  else {
    if(!value2 %in% names(curr_model[[value1]])) stop(paste0(value2, " not found in ", model_name,"[[\"",value1,"\"]]"))
    if(missing(value3)) return(curr_model[[value1]][[value2]])
    else {
      if(!value3 %in% names(curr_model[[value1]][[value2]])) stop(paste0(value3, " not found in ", model_name,"[[\"",value1,"\"]]","[[\"",value2,"\"]]"))
      return(curr_model[[value1]][[value2]][[value3]])
    }
  }
}
)

instat_object$set("public", "get_model_names", function() {
  return(names(private$.models))
}
)

instat_object$set("public", "add_filter", function(data_name, filter, filter_name = "", replace = TRUE, set_as_current_filter = FALSE) {
  if(missing(filter)) stop("filter is required")
  self$get_data_objects(data_name)$add_filter(filter, filter_name, replace, set_as_current_filter)
}
) 

instat_object$set("public", "current_filter", function(data_name) {
  return(self$get_data_objects(data_name)$current_filter)
}
)

instat_object$set("public", "get_current_filter", function(data_name) {
  self$get_data_objects(data_name)$get_current_filter()
}
)

instat_object$set("public", "remove_current_filter", function(data_name) {
  self$get_data_objects(data_name)$remove_current_filter()
}
)

instat_object$set("public", "filter_applied", function(data_name) {
  self$get_data_objects(data_name)$filter_applied()
}
)

instat_object$set("public", "replace_value_in_data", function(data_name, col_name, row, new_value) {
  self$get_data_objects(data_name)$replace_value_in_data(col_name, row, new_value)
} 
)

instat_object$set("public", "rename_column_in_data", function(data_name, column_name, new_val) {
  self$get_data_objects(data_name)$rename_column_in_data(column_name, new_val)
} 
)

#TODO remove this method
instat_object$set("public", "remove_columns_in_data_from_start_position", function(data_name, start_pos, col_numbers) {
  self$get_data_objects(data_name)$remove_columns_in_data_from_start_position(start_pos = start_pos, col_numbers = col_numbers)
} 
)

instat_object$set("public", "remove_columns_in_data", function(data_name, cols) {
  self$get_data_objects(data_name)$remove_columns_in_data(cols = cols)
} 
)

instat_object$set("public", "remove_rows_in_data", function(data_name, row_names) {
  self$get_data_objects(data_name)$remove_rows_in_data(row_names = row_names)
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

instat_object$set("public", "get_column_names", function(data_name, as_list = FALSE, include = list(), exclude = list()) {
  if(missing(data_name)) {
    return(lapply(self$get_data_objects(), function(x) x$get_column_names(include = include, exclude = exclude)))
  } 
  else {
    return(self$get_data_objects(data_name)$get_column_names(as_list, include, exclude))
  }
}
)

#TODO delete and replace with add_columns_to_data
instat_object$set("public", "insert_column_in_data", function(data_name, col_data =c(), start_pos, number_cols) {
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

instat_object$set("public", "reorder_columns_in_data", function(data_name, col_order){
  self$get_data_objects(data_name)$reorder_columns_in_data(col_order = col_order)
}
)

#TODO Think how to use row_data argument
instat_object$set("public", "insert_row_in_data", function(data_name, start_row, row_data = c(), number_rows, before = FALSE) {
  self$get_data_objects(data_name)$insert_row_in_data(start_row = start_row, row_data = row_data, number_rows = number_rows, before = before)
}
)

instat_object$set("public", "get_data_frame_length", function(data_name) {
  self$get_data_objects(data_name)$get_data_frame_length()
}
)

instat_object$set("public", "get_next_default_dataframe_name", function(prefix, include_index = TRUE, start_index = 1) {
  next_default_item(prefix = prefix, existing_names = names(private$.data_objects), include_index = include_index, start_index = start_index)
} 
)

instat_object$set("public", "delete_dataframe", function(data_name) {
  # TODO need a set or append
  private$.data_objects[[data_name]] <- NULL
  data_objects_changed <- TRUE
} 
)

instat_object$set("public", "get_column_factor_levels", function(data_name,col_name = "") {
  self$get_data_objects(data_name)$get_column_factor_levels(col_name)
} 
)

instat_object$set("public", "get_factor_data_frame", function(data_name,col_name = "") {
  self$get_data_objects(data_name)$get_factor_data_frame(col_name)
} 
)

instat_object$set("public", "sort_dataframe", function(data_name, col_names = c(), decreasing = FALSE, na.last = TRUE) {
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
  self$get_data_objects(data_name)$convert_column_to_type(col_names = col_names, to_type = to_type, factor_numeric = factor_numeric)
} 
)

instat_object$set("public", "append_to_variables_metadata", function(data_name, col_names, property, new_val) {
  self$get_data_objects(data_name)$append_to_variables_metadata(col_names, property, new_val)
} 
)

instat_object$set("public", "append_to_dataframe_metadata", function(data_name, property, new_val) {
  self$get_data_objects(data_name)$append_to_metadata(property, new_val)
} 
)

instat_object$set("public", "append_to_metadata", function(property, new_val) {
  if(missing(property) || missing(new_val)) {
    stop("property and new_val arguments must be specified.")
  } 
  
  if(!is.character(property)) stop("property must be of type character")
  
  private$.metadata[[property]] <- new_val
  self$metadata_changed <- TRUE
  #TODO should there be a changes list?
  #self$append_to_changes(list(Added_metadata, property))
} 
)

instat_object$set("public", "reorder_dataframes", function(data_frames_order) {
  if(length(data_frames_order) != length(names(private$.data_objects))) stop("number data frames to order should be equal to number of dataframes in the object")
  if(!setequal(data_frames_order,names(private$.data_objects))) stop("data_frames_order must be a permutation of the dataframe names.")

  self$set_data_objects(private$.data_objects[data_frames_order])
  self$data_objects_changed <- TRUE
} 
)

instat_object$set("public", "copy_columns", function(data_name, col_names = "") {
  self$get_data_objects(data_name)$copy_columns(col_names = col_names)
} 
)

instat_object$set("public", "drop_unused_factor_levels", function(data_name, col_name) {
  self$get_data_objects(data_name)$drop_unused_factor_levels(col_name = col_name)
} 
)

instat_object$set("public", "set_factor_levels", function(data_name, col_name, new_levels) {
  self$get_data_objects(data_name)$set_factor_levels(col_name = col_name, new_levels = new_levels)
} 
)

instat_object$set("public", "set_factor_reference_level", function(data_name, col_name, new_ref_level) {
  self$get_data_objects(data_name)$set_factor_reference_level(col_name = col_name, new_ref_level = new_ref_level)
} 
)

instat_object$set("public", "get_column_count", function(data_name) {
  return(self$get_data_objects(data_name)$get_column_count())
} 
)

instat_object$set("public", "reorder_factor_levels", function(data_name, col_name, new_level_names) {
  self$get_data_objects(data_name)$reorder_factor_levels(col_name = col_name, new_level_names = new_level_names)
} 
)

instat_object$set("public","get_data_type", function(data_name, col_name) {
  self$get_data_objects(data_name)$get_data_type(col_name = col_name)
} 
)

instat_object$set("public","copy_data_frame", function(data_name, new_name) {
  curr_obj = self$get_data_objects(data_name)$clone(deep = TRUE)
  
  if(missing(new_name)) new_name = next_default_item(data_name, self$get_data_names())
  self$append_data_object(new_name, curr_obj)
} 
)

instat_object$set("public","set_hidden_columns", function(data_name, col_names) {
  self$get_data_objects(data_name)$set_hidden_columns(col_names = col_names)
} 
)

instat_object$set("public","unhide_all_columns", function(data_name) {
  if(missing(data_name)) sapply(self$get_data_objects(), function(obj) obj$unhide_all_columns())
  else self$get_data_objects(data_name)$unhide_all_columns()
} 
)

instat_object$set("public","set_row_names", function(data_name, row_names) {
  self$get_data_objects(data_name)$set_row_names(row_names = row_names)
} 
)

instat_object$set("public","set_protected_columns", function(data_name, col_names) {
  self$get_data_objects(data_name)$set_protected_columns(col_names = col_names)
} 
)