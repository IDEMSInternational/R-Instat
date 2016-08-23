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
    self$set_objects(list())
                      
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
                  .objects = list(),
                  .links = list(),
                  .data_objects_changed = FALSE
                ),
                active = list(
                  data_objects_changed = function(new_value) {
                    if(missing(new_value)) return(private$.data_objects_changed)
                    else {
                      if(new_value != TRUE && new_value != FALSE) stop("new_value must be TRUE or FALSE")
                      private$.data_objects_changed <- new_value
                      #TODO is this behaviour we want?
                      invisible(sapply(self$get_data_objects(), function(x) x$data_changed <- new_value))
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
  for(curr_obj in new_instatObj$get_data_objects()) {
    self$append_data_object(curr_obj$get_metadata(data_name_label), curr_obj$data_clone())
  }
  self$set_meta(new_instatObj$get_metadata())
  self$set_objects(new_instatObj$get_objects(data_name = overall_label, as_list = FALSE))
  self$data_objects_changed <- TRUE
  invisible(lapply(new_instatObj$get_data_objects(), function(x) x$set_data_changed(TRUE)))
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
instat_object$set("public", "import_RDS", function(data_RDS, keep_existing = TRUE, overwrite_existing = FALSE, include_objects = TRUE,
                                         include_metadata = TRUE, include_logs = TRUE, include_filters = TRUE, messages = TRUE)
# TODO add include_calcuations options
{ 
  if("instat_object" %in% class(data_RDS)) {
    if(!keep_existing && include_objects && include_metadata && include_logs && include_filters) {
      self$replace_instat_object(new_instatObj = data_RDS)
    } 
    else {
      if(!keep_existing) {
        self$set_data_objects(list())
        self$set_meta(list())
        self$set_objects(list())
      }
      for (curr_data_obj in data_RDS$get_data_objects()) {
        if (!(curr_data_obj$get_metadata(data_name_label) %in% self$get_data_names()) || overwrite_existing){
          if (!include_objects) curr_data_obj$set_objects(list())
          curr_data_name = curr_data_obj$get_metadata(data_name_label)
          if (!include_metadata) {
            curr_data_obj$set_meta(list()) 
            curr_data_obj$add_defaults_meta()
            curr_data_obj$add_defaults_variables_metadata()
            curr_data_obj$set_variables_metadata(data.frame())
            #curr_data_obj$update_variables_metadata()
          }
          if (!include_logs) curr_data_obj$set_changes(list())

          if(!include_filters) {
            curr_data_obj$set_filters(list())
            curr_data_obj$remove_current_filter()
          }
          self$append_data_object(curr_data_name, curr_data_obj)
        }
      }
      new_objects_list = data_RDS$get_objects(data_name = overall_label)
      new_objects_count = length(new_objects_list)
      if (include_objects && new_objects_count > 0) {
        for ( i in (1:new_objects_count) ) {
          if (!(names(new_objects_list)[i] %in% names(private$.objects)) || overwrite_existing) {
            self$add_object(object = new_objects_list[i], object_name = names(new_objects_list)[i])
          }
        }
      }
      new_metadata = data_RDS$get_metadata()
      new_metadata_count = length(new_metadata)
      if (include_metadata && new_metadata_count > 0) {
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
  else {
    if(messages){
      #TODO work on messages and error handling
      #     use build in R defaults for messages
      stop(paste("Cannot import an objects of clss", class(data_RDS)))
    }
  }
}
)

# Now appending/merging not setting so maybe should be renamed
instat_object$set("public", "set_meta", function(new_meta) {
  if(!is.list(new_meta)) stop("new_meta must be of type: list")
  for(name in names(new_meta)) {
    self$append_to_metadata(name, new_meta[[name]])
  }
}
)

instat_object$set("public", "set_objects", function(new_objects) {
  if(!is.list(new_objects)) stop("new_objects must be of type: list")
  
  private$.objects <- new_objects 
}
)

instat_object$set("public", "append_data_object", function(name, obj) {
  if( !class(name) == "character") {
    stop("name must be a character")
  }
  
  if ( !"data_object" %in% class(obj)) {
    stop("obj must be a data object")
  }
  obj$append_to_metadata(data_name_label, name)
  private$.data_objects[[name]] <- obj 
}
)

instat_object$set("public", "get_data_objects", function(data_name, as_list = FALSE) {
  if(missing(data_name)) {
    return(private$.data_objects)
  }
  else{
    if(all(is.character(data_name))) type = "character"
    else if(all(is.numeric(data_name)) && all((data_name %% 1) == 0)) type = "integer"
    else stop("data_name must be of type character or integer")
    
    if(type=="character" && !all(data_name %in% names(private$.data_objects))) stop(paste(data_name, "not found"))
    if(type=="integer" && (!all(1 <= data_name) || !all(data_name <= length(private$.data_objects)))) stop(paste(data_name, "not found"))
    if(length(data_name) > 1 || as_list) return(private$.data_objects[data_name])
    else return(private$.data_objects[[data_name]])
  }
}
)

instat_object$set("public", "get_data_frame", function(data_name, convert_to_character = FALSE, stack_data = FALSE, include_hidden_columns = TRUE, use_current_filter = TRUE, filter_name = "", ...) {
  if(!stack_data) {
    if(missing(data_name)) {
      retlist <- list()
      for ( i in (1:length(private$.data_objects)) ) {
        retlist[[names(private$.data_objects)[[i]]]] = data_objects[[i]]$get_data_frame(convert_to_character = convert_to_character, include_hidden_columns = include_hidden_columns, use_current_filter = use_current_filter, filter_name = filter_name)
      }
      return(retlist)
    }
    else return(self$get_data_objects(data_name)$get_data_frame(convert_to_character = convert_to_character, include_hidden_columns = include_hidden_columns, use_current_filter = use_current_filter, filter_name = filter_name))
  }
  else {
    if(missing(data_name)) stop("data to be stacked is missing")
    if(!data_name %in% names(private$.data_objects)) stop(paste(data_name, "not found."))
    return(melt(self$get_data_objects(data_name)$get_data_frame(include_hidden_columns = include_hidden_columns, use_current_filter = use_current_filter, filter_name = filter_name), ...))
  }
}
)

instat_object$set("public", "get_variables_metadata", function(data_name, data_type = "all", convert_to_character = FALSE, property, column, error_if_no_property = TRUE, direct_from_attributes = FALSE) { 
  if(missing(data_name)) {
    retlist <- list()
    for (curr_obj in private$.data_objects) {
      retlist[[curr_obj$get_metadata(data_name_label)]] = curr_obj$get_variables_metadata(data_type = data_type, convert_to_character = convert_to_character, property = property, column = column, error_if_no_property = error_if_no_property, direct_from_attributes = direct_from_attributes)
    }
    return(retlist)
  }
  else return(self$get_data_objects(data_name)$get_variables_metadata(data_type = data_type, convert_to_character = convert_to_character, property = property, column = column, error_if_no_property = error_if_no_property, direct_from_attributes = direct_from_attributes))
} 
)

instat_object$set("public", "get_combined_metadata", function(convert_to_character = FALSE) { 
  retlist <- data.frame()
  for (curr_obj in private$.data_objects) {
    templist = curr_obj$get_metadata()
    for ( j in (1:length(templist)) ) {
      if(length(templist[[j]]) > 1) templist[[j]] <- paste(as.character(templist[[j]]), collapse = ",")
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

instat_object$set("public", "get_variables_metadata_changed", function(data_name) { 
  if(missing(data_name)) {
    if(private$.data_objects_changed) return(TRUE)
    return(any(sapply(private$.data_objects, function(x) x$variables_metadata_changed)))
  }
  else {
    return(self$get_data_objects(data_name)$variables_metadata_changed)
  }
} 
)

instat_object$set("public", "get_metadata_changed", function(data_name) { 
  if(missing(data_name)) {
    if(private$.data_objects_changed) return(TRUE)
    for(curr_obj in private$.data_objects) {
      if(curr_obj$metadata_changed) return(TRUE)
    }
    return(FALSE)
  }
  else {
    return(self$get_data_objects(data_name)$metadata_changed)
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

instat_object$set("public", "add_columns_to_data", function(data_name, col_name = "", col_data, use_col_name_as_prefix = FALSE, hidden = FALSE, before = FALSE, adjacent_column, num_cols) {
  if(missing(use_col_name_as_prefix)) self$get_data_objects(data_name)$add_columns_to_data(col_name, col_data, hidden = hidden, before = before, adjacent_column = adjacent_column, num_cols = num_cols)
  else self$get_data_objects(data_name)$add_columns_to_data(col_name, col_data, use_col_name_as_prefix = use_col_name_as_prefix, hidden = hidden, before = before, adjacent_column = adjacent_column, num_cols = num_cols)
}
)

instat_object$set("public", "get_columns_from_data", function(data_name, col_names, from_stacked_data = FALSE,
                                                    force_as_data_frame = FALSE, use_current_filter = TRUE) {
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

instat_object$set("public", "add_object", function(data_name, object, object_name) {
  if(missing(data_name)) {
    if(missing(object_name)) object_name = next_default_item("object", names(private$.objects))
    if(object_name %in% names(private$.objects)) message(paste("An object called", object_name, "already exists. It will be replaced."))
    private$.objects[[object_name]] <- object
  }
  else self$get_data_objects(data_name)$add_object(object = object, object_name = object_name)
}
) 

instat_object$set("public", "get_objects", function(data_name, object_name, include_overall = TRUE, as_list = FALSE, type = "", include_empty = FALSE, force_as_list = FALSE) {
  #TODO implement force_as_list in all cases
  if(missing(data_name)) {
    if(!missing(object_name)) {
      curr_objects = private$.objects[self$get_object_names(data_name = overall_label, type = type)]
      if(!(object_name %in% names(curr_objects))) stop(object_name, "not found.")
      else out = curr_objects[[object_name]]
    }
    else {
      out = sapply(self$get_data_objects(as_list = TRUE), function(x) x$get_objects(type = type))
      if(include_overall) out[[overall_label]] <- private$.objects[self$get_object_names(data_name = overall_label, type = type)]
      if(!include_empty) out = out[sapply(out, function(x) length(x) > 0)]
    }
    return(out)
  }
  else {
    if(data_name == overall_label) {
      curr_objects = private$.objects[self$get_object_names(data_name = data_name, type = type)]
      if(!missing(object_name)) {
        if(!(object_name %in% names(curr_objects))) stop(object_name, "not found.")
        else out = curr_objects[[object_name]]
      }
      else out = curr_objects
    }
    else out = self$get_data_objects(data_name)$get_objects(object_name = object_name, type = type, force_as_list = force_as_list)
	if(as_list) {
      lst = list()
      lst[[data_name]][[object_name]] <- out
      return(lst)
    }
    else return(out)
  }
}
)

instat_object$set("public", "get_object_names", function(data_name, include_overall = TRUE, include, exclude, type = "", include_empty = FALSE, as_list = FALSE, excluded_items = c()) {
  if(type == "") overall_object_names = names(private$.objects)
  else {
    if(type == model_label) overall_object_names = names(private$.objects)[!sapply(private$.objects, function(x) any(c("ggplot", "gg") %in% class(x)))]
    else if(type == graph_label) overall_object_names = names(private$.objects)[sapply(private$.objects, function(x) any(c("ggplot", "gg") %in% class(x)))]
    else stop("type: ", type, " not recognised")
  }
  if(missing(data_name)) {
    if(missing(type)) out = sapply(self$get_data_objects(), function(x) x$get_object_names()) 
    else out = sapply(self$get_data_objects(), function(x) x$get_object_names(type = type))
    if(include_overall) out[[overall_label]] <- overall_object_names
    if(!include_empty) out = out[sapply(out, function(x) length(x) > 0)]
    if(as_list) out = as.list(out)
    return(out)
  }
  else {
    if(data_name == overall_label) {
      if(length(excluded_items) > 0) {
        ex_ind = which(overall_object_names %in% excluded_items)
        if(length(ex_ind) != length(excluded_items)) warning("Some of the excluded_items were not found in the list of objects")
        if(length(ex_ind) > 0) overall_object_names = overall_object_names[-ex_ind]
      }
      if(as_list) {
        lst = list()
        lst[[overall_label]] <- overall_object_names
        return(lst)
      }
      else return(overall_object_names)
    }
    else return(self$get_data_objects(data_name)$get_object_names(type, as_list = as_list, excluded_items = excluded_items))
  }
}
)

instat_object$set("public", "rename_object", function(data_name, object_name, new_name) {
  if(missing(data_name) || data_name == overall_label) {
    if(!object_name %in% names(private$.objects)) stop(object_name, " not found in overall objects list")
    if(new_name %in% names(private$.objects)) stop(new_name, " is already an object name. Cannot rename ", object_name, " to ", new_name)
    names(private$.objects)[names(private$.objects) == object_name] <- new_name
  }
  else self$get_data_objects(data_name)$rename_object(object_name = object_name, new_name = new_name)
}
)

instat_object$set("public", "delete_objects", function(data_name, object_names) {
  if(missing(data_name) || data_name == overall_label) {
    if(!all(object_names %in% names(private$.objects))) stop("Not all object_names found in overall objects list")
    private$.objects[names(private$.objects) == object_names] <- NULL
  }
  else self$get_data_objects(data_name)$delete_objects(object_names = object_names)
}
)

instat_object$set("public", "reorder_objects", function(data_name, new_order) {
  if(missing(data_name) || data_name == overall_label) {
    if(length(new_order) != length(private$.objects) || !setequal(new_order, names(private$.objects))) stop("new_order must be a permutation of the current object names.")
    self$set_objects(private$.objects[new_order])
  }
  else self$get_data_objects(data_name)$reorder_objects(new_order = new_order)
}
)

instat_object$set("public", "get_from_object", function(data_name, object_name, value1, value2, value3) {
  if(missing(data_name) || missing(object_name)) stop("data_name and object_name must both be specified.")
  curr_object = self$get_objects(data_name = data_name, object_name = object_name)
  if(missing(value1)) {
    if(!missing(value2) || !missing(value3)) warning("value1 is missing so value2 and value3 will be ignored.")
    return(curr_object[])
  }
  if(!value1 %in% names(curr_object)) stop(value1, " not found in ", object_name)
  if(missing(value2)) {
    if(!missing(value3)) warning("value2 is missing so value3 will be ignored.")
    return(curr_object[[value1]])
  }
  else {
    if(!value2 %in% names(curr_object[[value1]])) stop(paste0(value2, " not found in ", object_name,"[[\"",value1,"\"]]"))
    if(missing(value3)) return(curr_object[[value1]][[value2]])
    else {
      if(!value3 %in% names(curr_object[[value1]][[value2]])) stop(paste0(value3, " not found in ", object_name,"[[\"",value1,"\"]]","[[\"",value2,"\"]]"))
      return(curr_object[[value1]][[value2]][[value3]])
    }
  }
}
)

instat_object$set("public", "add_model", function(data_name, model, model_name) {
  self$add_object(data_name = data_name, object = model, object_name = model_name)
}
)

instat_object$set("public", "get_models", function(data_name, model_name, include_overall = TRUE, force_as_list = FALSE) {
  self$get_objects(data_name = data_name, object_name = model_name, include_overall = include_overall, type = model_label, force_as_list = force_as_list)
}
)

instat_object$set("public", "get_model_names", function(data_name, include_overall = TRUE, include, exclude, include_empty = FALSE, as_list = FALSE, excluded_items = c()) {
  self$get_object_names(data_name = data_name, include_overall = include_overall, include, exclude, type = model_label, include_empty = include_empty, as_list = as_list, excluded_items = excluded_items)
}
)

instat_object$set("public", "get_from_model", function(data_name, model_name, value1, value2, value3) {
  self$get_from_object(data_name = data_name, object_name = model_name, value1 = value1, value2 = value2, value3 = value3)
}
)

instat_object$set("public", "add_graph", function(data_name, graph, graph_name) {
  self$add_object(data_name = data_name, object = graph, object_name = graph_name)
}
)

instat_object$set("public", "get_graphs", function(data_name, graph_name, include_overall = TRUE, force_as_list = FALSE) {
  self$get_objects(data_name = data_name, object_name = graph_name, include_overall = include_overall, type = graph_label, force_as_list = force_as_list)
}
)

instat_object$set("public", "get_graph_names", function(data_name, include_overall = TRUE, include, exclude, include_empty = FALSE, as_list = FALSE, excluded_items = c()) {
  self$get_object_names(data_name = data_name, include_overall = include_overall, include, exclude, type = graph_label, include_empty = include_empty, as_list = as_list, excluded_items = excluded_items)
}
)

instat_object$set("public", "add_filter", function(data_name, filter, filter_name = "", replace = TRUE, set_as_current_filter = FALSE, na.rm = TRUE, is_no_filter = FALSE) {
  if(missing(filter)) stop("filter is required")
  self$get_data_objects(data_name)$add_filter(filter, filter_name, replace, set_as_current_filter, na.rm = na.rm, is_no_filter = is_no_filter)
}
) 

instat_object$set("public", "current_filter", function(data_name) {
  return(self$get_data_objects(data_name)$current_filter)
}
)

instat_object$set("public", "set_current_filter", function(data_name, filter_name = "") {
  self$get_data_objects(data_name)$set_current_filter(filter_name)
}
)

instat_object$set("public", "get_filter", function(data_name, filter_name) {
  return(self$get_data_objects(data_name)$get_filter(filter_name))
}
)

instat_object$set("public", "get_filter_as_logical", function(data_name, filter_name) {
  return(self$get_data_objects(data_name)$get_filter_as_logical(filter_name))
}
)

instat_object$set("public", "get_current_filter", function(data_name) {
  self$get_data_objects(data_name)$get_current_filter()
}
)

instat_object$set("public", "get_filter_names", function(data_name, as_list = FALSE, include = list(), exclude = list(), excluded_items = c()) {
  if(missing(data_name)) {
    #TODO what to do with excluded_items in this case
    return(lapply(self$get_data_objects(), function(x) x$get_filter_names(include = include, exclude = exclude)))
  } 
  else {
    return(self$get_data_objects(data_name)$get_filter_names(as_list = as_list, include = include, exclude = exclude, excluded_items = excluded_items))
  }
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

instat_object$set("public", "filter_string", function(data_name, filter_name) {
  self$get_data_objects(data_name)$filter_string(filter_name)
}
)

instat_object$set("public", "replace_value_in_data", function(data_name, col_names, rows, old_value, start_value = NA, end_value = NA, new_value, closed_start_value = TRUE, closed_end_value = TRUE) {
  self$get_data_objects(data_name)$replace_value_in_data(col_names, rows, old_value, start_value, end_value, new_value, closed_start_value, closed_end_value)
} 
)
# instat_object$set("public", "replace_value_in_data", function(data_name, col_name, row, new_value) {
#   self$get_data_objects(data_name)$replace_value_in_data(col_name, row, new_value)
# } 
# )

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

instat_object$set("public", "get_column_names", function(data_name, as_list = FALSE, include = list(), exclude = list(), excluded_items = c()) {
  if(missing(data_name)) {
    #TODO what to do with excluded items in this case?
    return(lapply(self$get_data_objects(), function(x) x$get_column_names(include = include, exclude = exclude)))
  } 
  else {
    return(self$get_data_objects(data_name)$get_column_names(as_list, include, exclude, excluded_items = excluded_items))
  }
}
)

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

instat_object$set("public", "sort_dataframe", function(data_name, col_names = c(), decreasing = FALSE, na.last = TRUE, by_row_names = FALSE, row_names_as_numeric = TRUE) {
  self$get_data_objects(data_name)$sort_dataframe(col_names = col_names, decreasing = decreasing, na.last = na.last, by_row_names = by_row_names, row_names_as_numeric = row_names_as_numeric)
} 
)

instat_object$set("public", "rename_dataframe", function(data_name, new_value = "") {
  data_obj = self$get_data_objects(data_name)
  names(private$.data_objects)[names(private$.data_objects) == data_name] <- new_value
  data_obj$append_to_metadata(data_name_label, new_value)
  data_obj$set_data_changed(TRUE)
} 
)

instat_object$set("public", "convert_column_to_type", function(data_name, col_names = c(), to_type ="factor", factor_numeric = "by_levels") {
  self$get_data_objects(data_name)$convert_column_to_type(col_names = col_names, to_type = to_type, factor_numeric = factor_numeric)
} 
)

instat_object$set("public", "append_to_variables_metadata", function(data_name, col_names, property, new_val = "") {
  self$get_data_objects(data_name)$append_to_variables_metadata(col_names, property, new_val)
} 
)

instat_object$set("public", "append_to_dataframe_metadata", function(data_name, property, new_val = "") {
  self$get_data_objects(data_name)$append_to_metadata(property, new_val)
} 
)

instat_object$set("public", "append_to_metadata", function(property, new_val = "") {
  if(missing(property)) stop("property and new_val arguments must be specified.")
  
  if(!is.character(property)) stop("property must be of type character")
  
  attr(self, property) <- new_val
  self$metadata_changed <- TRUE
  self$append_to_changes(list(Added_metadata, property))
}
)

instat_object$set("public", "add_metadata_field", function(data_name, property, new_val = "") {
  if(missing(property)) stop("property and new_val arguments must be specified.")
  if(data_name == overall_label) {
    invisible(sapply(self$get_data_objects(), function(x) x$append_to_metadata(property, new_val)))
  }
  else invisible(sapply(self$get_data_objects(data_name, as_list = TRUE), function(x) x$append_to_variables_metadata(property = property, new_val = new_val)))
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

instat_object$set("public", "edit_factor_level", function(data_name, col_name,old_level, new_level) {
  self$get_data_objects(data_name)$edit_factor_level(col_name = col_name, old_level = old_level, new_level = new_level)
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
  curr_obj$data_changed <- TRUE
} 
)

instat_object$set("public","set_hidden_columns", function(data_name, col_names) {
  self$get_data_objects(data_name)$set_hidden_columns(col_names = col_names)
} 
)

instat_object$set("public","unhide_all_columns", function(data_name) {
  if(missing(data_name)) invisible(sapply(self$get_data_objects(), function(obj) obj$unhide_all_columns()))
  else self$get_data_objects(data_name)$unhide_all_columns()
} 
)

instat_object$set("public","set_row_names", function(data_name, row_names) {
  self$get_data_objects(data_name)$set_row_names(row_names = row_names)
} 
)

instat_object$set("public","get_row_names", function(data_name) {
  self$get_data_objects(data_name)$get_row_names()
} 
)

instat_object$set("public","set_protected_columns", function(data_name, col_names) {
  self$get_data_objects(data_name)$set_protected_columns(col_names = col_names)
} 
)

instat_object$set("public","get_metadata_fields", function(data_name, include_overall, as_list = FALSE, include, exclude, excluded_items = c()) {
  if(!missing(data_name)) {
    if(data_name == overall_label) {
      out = names(self$get_combined_metadata())
      if(length(excluded_items) > 0){
        ex_ind = which(out %in% excluded_items)
        if(length(ex_ind) != length(excluded_items)) warning("Some of the excluded_items were not found in the list of objects")
        if(length(ex_ind) > 0) out = out[-ex_ind]
      }
      if(as_list) {
        lst = list()
        lst[[data_name]] <- out
        return(lst)
      }
      else return(out)
    }
    else return(self$get_data_objects(data_name)$get_variables_metadata_fields(as_list = as_list, include = include, exclude = exclude, excluded_items = excluded_items))
  }
  else {
    #TODO what to do with excluded_items in this case
    out = list()
    if(include_overall) out[[overall_label]] <- names(self$get_combined_metadata())
    for(data_obj_name in self$get_data_names()) {
      out[[data_obj_name]] <- self$get_data_objects(data_obj_name)$get_variables_metadata_fields(as_list = FALSE, include = include, exclude = exclude)
    }
    return(out)
  }
} 
)

instat_object$set("public","freeze_columns", function(data_name, column) {
  self$get_data_objects(data_name)$freeze_columns(column = column)
} 
)

instat_object$set("public","unfreeze_columns", function(data_name) {
  self$get_data_objects(data_name)$unfreeze_columns()
} 
)

instat_object$set("public","is_variables_metadata", function(data_name, property, column) {
  self$get_data_objects(data_name)$is_variables_metadata(property, column)
} 
)

instat_object$set("public","data_frame_exists", function(data_name) {
  return(data_name %in% names(private$.data_objects))
} 
)

instat_object$set("public","add_key", function(data_name, col_names) {
  self$get_data_objects(data_name)$add_key(col_names)
  invisible(sapply(self$get_data_objects(), function(x) if(!x$is_metadata(is_linkable)) x$append_to_metadata(is_linkable, FALSE)))
}
)

instat_object$set("public","get_links", function() {
  return(private$.links)
}
)

instat_object$set("public","set_structure_columns", function(data_name, struc_type_1 = c(), struc_type_2 = c(), struc_type_3 = c()) {
  self$get_data_objects(data_name)$set_structure_columns(struc_type_1, struc_type_2, struc_type_3)
}
)

instat_object$set("public","add_dependent_columns", function(data_name, columns, dependent_cols) {
  self$get_data_objects(data_name)$add_dependent_columns(columns, dependent_cols)
}
)