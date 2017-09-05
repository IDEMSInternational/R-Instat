instat_object <- R6::R6Class("instat_object",
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
                           .data_objects_changed = FALSE,
                           .database_connection = NULL
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
    
    if(!(is.list(data_tables)))  {
      stop("data_tables must be a list of data frames")
    }
    
    if(anyDuplicated(names(data_tables))) {
      stop("There are duplicate names in the data tables list.")
    }
    
    if(length(data_tables_variables_metadata) != length(data_tables)) { 
      stop("If data_tables_variables_metadata is specified, it must be a list of metadata lists with the same length as data_tables.")
    }
    
    if(length(data_tables_metadata) != length(data_tables)) { 
      stop("If data_tables_metadata is specified, it must be a list of metadata lists with the same length as data_tables.")
    }
    
    if (length(imported_from) != length(data_tables)) { 
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

instat_object$set("public", "replace_instat_object", function(new_instat_object) {
  self$set_data_objects(list())
  for(curr_obj in new_instat_object$get_data_objects()) {
    self$append_data_object(curr_obj$get_metadata(data_name_label), curr_obj$data_clone())
  }
  self$set_meta(new_instat_object$get_metadata())
  self$set_objects(new_instat_object$get_objects(data_name = overall_label, as_list = FALSE))
  self$data_objects_changed <- TRUE
}
)

instat_object$set("public", "set_data_objects", function(new_data_objects) {
  if(!is.list(new_data_objects) || (length(new_data_objects) > 0 && !all("data_object" %in% sapply(new_data_objects, class)))) {
    stop("new_data_objects must be a list of data_objects")
  }
  else private$.data_objects <- new_data_objects
}
)

instat_object$set("public", "copy_data_object", function(data_name, new_name, filter_name = "", reset_row_names = TRUE) {
  new_obj <- self$get_data_objects(data_name)$data_clone()
  if(filter_name != "") {
    subset_data <- self$get_data_objects(data_name)$get_data_frame(use_current_filter = FALSE, filter_name = filter_name, retain_attr = TRUE)
    if(reset_row_names) rownames(subset_data) <- 1:nrow(subset_data)
    new_obj$set_data(subset_data)
  }
  self$append_data_object(new_name, new_obj)
}
)


instat_object$set("public", "import_RDS", function(data_RDS, keep_existing = TRUE, overwrite_existing = FALSE, include_objects = TRUE,
                                                   include_metadata = TRUE, include_logs = TRUE, include_filters = TRUE, include_calculations = TRUE)
  # TODO add include_calcuations options
{
  if("instat_object" %in% class(data_RDS)) {
    if(!keep_existing && include_objects && include_metadata && include_logs && include_filters && include_calculations) {
      self$replace_instat_object(new_instat_object = data_RDS)
    }
    else {
      if(!keep_existing) {
        self$set_data_objects(list())
        self$set_meta(list())
        self$set_objects(list())
        self$set_links(list())
        self$set_database_connection(NULL)
      }
      new_links_list <- data_RDS$get_links()
      for(data_obj_name in data_RDS$get_data_names()) {
        data_obj_clone <- data_RDS$get_data_objects(data_obj_name)$data_clone(include_objects = include_objects, include_metadata = include_metadata, include_logs = include_logs, include_filters = include_filters, include_calculations = include_calculations)
        if(data_obj_name %in% self$get_data_names() && !overwrite_existing) {
          new_name <- next_default_item(data_obj_name, self$get_data_names())
          data_obj_clone$append_to_metadata(data_name_label, new_name)
          if(new_name != data_obj_name) {
            for(i in seq_along(new_links_list)) {
              new_links_list[[i]]$rename_data_frame_in_link(data_obj_name, new_name)
            }
          }
        }
        #if(!data_obj_clone$is_metadata(data_name_label)) data_obj_clone$append_to_metadata(data_name_label, new_name)
        curr_data_name = data_obj_clone$get_metadata(data_name_label)
        self$append_data_object(curr_data_name, data_obj_clone)
      }
      for(i in seq_along(new_links_list)) {
        curr_link <- new_links_list[[i]]
        for(j in seq_along(curr_link$link_columns)) {
          self$add_link(from_data_frame = curr_link$from_data_frame, to_data_frame = curr_link$to_data_frame, link_pairs = curr_link$link_columns[[j]], type = curr_link$type, link_name = names(new_links_list)[i])
        }
      }
      new_objects_list <- data_RDS$get_objects(data_name = overall_label)
      new_objects_count <- length(new_objects_list)
      if(include_objects && new_objects_count > 0) {
        for(i in (1:new_objects_count)) {
          if(!(names(new_objects_list)[i] %in% names(private$.objects)) || overwrite_existing) {
            self$add_object(object = new_objects_list[i], object_name = names(new_objects_list)[i])
          }
        }
      }
      new_metadata <- data_RDS$get_metadata()
      new_metadata_count <- length(new_metadata)
      if(include_metadata && new_metadata_count > 0) {
        for(i in (1:new_metadata_count)) {
          if(!(names(new_metadata)[i] %in% names(private$metadata)) || overwrite_existing) {
            self$append_to_metadata(names(new_metadata)[i], new_metadata[[i]])
          }
        }
      }
    }
    self$data_objects_changed <- TRUE
  }
  else if(is.data.frame(data_RDS) || is.matrix(data_RDS)) {
    self$import_data(data_tables = list(data_RDS = data_RDS))
  }
  else stop("Cannot import an objects of class", paste(class(data_RDS), collapse = ","))
}
)

instat_object$set("public", "import_from_ODK", function(username, form_name, platform) {
  out <- import_from_ODK(username, form_name, platform)
  data_list <- list(out)
  names(data_list) <- form_name
  self$import_data(data_tables = data_list)
}
)

# Now appending/merging not setting so maybe should be renamed
instat_object$set("public", "set_meta", function(new_meta) {
  if(!is.list(new_meta)) stop("new_meta must be of type: list")
  for(name in names(attributes(self))) {
    if(!name  %in% c("class")) attr(self, name) <- NULL
  }
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
  if(!is.character(name)) stop("name must be a character")
  if(!"data_object" %in% class(obj)) {
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

instat_object$set("public", "get_data_frame", function(data_name, convert_to_character = FALSE, stack_data = FALSE, include_hidden_columns = TRUE, use_current_filter = TRUE, filter_name = "", remove_attr = FALSE, retain_attr = FALSE, max_cols, max_rows, ...) {
  if(!stack_data) {
    if(missing(data_name)) data_name <- self$get_data_names()
    if(length(data_name) > 1) {
      retlist <- list()
      for (curr_name in data_name) {
        retlist[[curr_name]] = self$get_data_objects(curr_name)$get_data_frame(convert_to_character = convert_to_character, include_hidden_columns = include_hidden_columns, use_current_filter = use_current_filter, filter_name = filter_name, remove_attr = remove_attr, retain_attr = retain_attr, max_cols = max_cols, max_rows = max_rows)
      }
      return(retlist)
    }
    else return(self$get_data_objects(data_name)$get_data_frame(convert_to_character = convert_to_character, include_hidden_columns = include_hidden_columns, use_current_filter = use_current_filter, filter_name = filter_name, remove_attr = remove_attr, retain_attr = retain_attr, max_cols = max_cols, max_rows = max_rows))
  }
  else {
    if(missing(data_name)) stop("data to be stacked is missing")
    if(!data_name %in% names(private$.data_objects)) stop(paste(data_name, "not found."))
    return(self$get_data_objects(data_name)$get_data_frame(include_hidden_columns = include_hidden_columns, use_current_filter = use_current_filter, filter_name = filter_name, stack_data = TRUE, ...))
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

instat_object$set("public", "get_column_data_types", function(data_name, columns) {
  return(self$get_data_objects(data_name)$get_column_data_types(columns = columns))
}
)

instat_object$set("public", "get_combined_metadata", function(convert_to_character = FALSE) { 
  retlist <- data.frame()
  i = 1
  for (curr_obj in private$.data_objects) {
    templist = curr_obj$get_metadata()
    for (j in (1:length(templist))) {
      if(length(templist[[j]]) > 1 || is.list(templist[[j]])) templist[[j]] <- paste(as.character(templist[[j]]), collapse = ",")
      retlist[i, names(templist[j])] = templist[[j]]
    }
    if(all(c(data_name_label, label_label) %in% names(retlist))) retlist <- retlist[ ,c(c(data_name_label, label_label), sort(setdiff(names(retlist), c(data_name_label, label_label))))]
    else if(data_name_label %in% names(retlist)) retlist <- retlist[ ,c(data_name_label, sort(setdiff(names(retlist), data_name_label)))]
    i = i + 1
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

instat_object$set("public", "get_data_names", function(as_list = FALSE, include, exclude, excluded_items) { 
  if(as_list) return(list(data_names = names(private$.data_objects)))
  else return(names(private$.data_objects))
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

instat_object$set("public", "get_calculations", function(data_name) {
  return(self$get_data_objects(data_name)$get_calculations())
} 
)

instat_object$set("public", "get_calculation_names", function(data_name) {
  return(self$get_data_objects(data_name)$get_calculation_names())
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

instat_object$set("public", "add_columns_to_data", function(data_name, col_name = "", col_data, use_col_name_as_prefix = FALSE, hidden = FALSE, before = FALSE, adjacent_column, num_cols, require_correct_length = TRUE) {
  if(missing(use_col_name_as_prefix)) self$get_data_objects(data_name)$add_columns_to_data(col_name, col_data, hidden = hidden, before = before, adjacent_column = adjacent_column, num_cols = num_cols, require_correct_length = require_correct_length)
  else self$get_data_objects(data_name)$add_columns_to_data(col_name, col_data, use_col_name_as_prefix = use_col_name_as_prefix, hidden = hidden, before = before, adjacent_column = adjacent_column, num_cols = num_cols, require_correct_length = require_correct_length)
}
)

instat_object$set("public", "get_columns_from_data", function(data_name, col_names, from_stacked_data = FALSE, force_as_data_frame = FALSE, use_current_filter = TRUE, remove_labels = FALSE) {
  if(missing(data_name)) stop("data_name is required")
  if(!from_stacked_data) {
    if(!data_name %in% names(private$.data_objects)) stop(data_name, "not found")
    self$get_data_objects(data_name)$get_columns_from_data(col_names, force_as_data_frame, use_current_filter = use_current_filter, remove_labels = remove_labels)
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
    if(type == model_label) overall_object_names = names(private$.objects)[!sapply(private$.objects, function(x) any(c("ggplot", "gg", "gtable", "grob", "htmlTable") %in% class(x)))]
    else if(type == graph_label) overall_object_names = names(private$.objects)[sapply(private$.objects, function(x) any(c("ggplot", "gg", "gtable", "grob") %in% class(x)))]
    else if(type == table_label) overall_object_names = names(private$.objects)[sapply(private$.objects, function(x) any(c("htmlTable") %in% class(x)))]
    else stop("type: ", type, " not recognised")
  }
  if(missing(data_name)) {
    if(missing(type)) out = sapply(self$get_data_objects(), function(x) x$get_object_names()) 
    else out = sapply(self$get_data_objects(), function(x) x$get_object_names(type = type))
    #temp disabled as causes a bug
    #if(include_overall) out[[overall_label]] <- overall_object_names
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
      if(!value3 %in% names(curr_object[[value1]][[value2]])) stop(value3, " not found in ", object_name,"[[\"",value1,"\"]]","[[\"",value2,"\"]]")
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

instat_object$set("public", "add_table", function(data_name, table, table_name) {
  self$add_object(data_name = data_name, object = table, object_name = table_name)
}
)

instat_object$set("public", "get_tables", function(data_name, table_name, include_overall = TRUE, force_as_list = FALSE) {
  self$get_objects(data_name = data_name, object_name = table_name, include_overall = include_overall, type = table_label, force_as_list = force_as_list)
}
)

instat_object$set("public", "get_table_names", function(data_name, include_overall = TRUE, include, exclude, include_empty = FALSE, as_list = FALSE, excluded_items = c()) {
  self$get_object_names(data_name = data_name, include_overall = include_overall, include, exclude, type = table_label, include_empty = include_empty, as_list = as_list, excluded_items = excluded_items)
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

instat_object$set("public", "get_filter_as_instat_calculation", function(data_name, filter_name) {
  self$get_data_objects(data_name)$get_filter_as_instat_calculation(filter_name)
}
)

instat_object$set("public", "replace_value_in_data", function(data_name, col_names, rows, old_value, old_is_missing = FALSE, start_value = NA, end_value = NA, new_value, new_is_missing = FALSE, closed_start_value = TRUE, closed_end_value = TRUE, locf = FALSE, from_last = FALSE) {
  self$get_data_objects(data_name)$replace_value_in_data(col_names, rows, old_value, old_is_missing, start_value, end_value, new_value, new_is_missing, closed_start_value, closed_end_value, locf, from_last)
}
)

instat_object$set("public", "rename_column_in_data", function(data_name, column_name, new_val, label = "") {
  self$get_data_objects(data_name)$rename_column_in_data(column_name, new_val, label)
} 
)

instat_object$set("public", "frequency_tables", function(data_name, x_col_names, y_col_name, addmargins = FALSE, proportions = FALSE, percentages = FALSE, transpose = FALSE) {
  self$get_data_objects(data_name)$frequency_tables(x_col_names, y_col_name, addmargins = addmargins, proportions = proportions, percentages = percentages, transpose = transpose)
} 
)

instat_object$set("public", "anova_tables", function(data_name, x_col_names, y_col_name, signif.stars = FALSE, sign_level = FALSE, means = FALSE) {
  self$get_data_objects(data_name)$anova_tables(x_col_names = x_col_names, y_col_name = y_col_name, signif.stars = signif.stars, sign_level = sign_level, means = means)
} 
)

instat_object$set("public", "remove_columns_in_data", function(data_name, cols, allow_delete_all = FALSE) {
  self$get_data_objects(data_name)$remove_columns_in_data(cols = cols, allow_delete_all = allow_delete_all)
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
  if(!data_name %in% names(private$.data_objects)) stop("dataframe: ", data_name, " not found")
  return(self$get_data_objects(data_name)$get_next_default_column_name(prefix))
} 
)

instat_object$set("public", "get_column_names", function(data_name, as_list = FALSE, include = list(), exclude = list(), excluded_items = c(), max_no) {
  if(missing(data_name)) {
    #TODO what to do with excluded items in this case?
    return(lapply(self$get_data_objects(), function(x) x$get_column_names(include = include, exclude = exclude, max_no = max_no)))
  } 
  else {
    return(self$get_data_objects(data_name)$get_column_names(as_list, include, exclude, excluded_items = excluded_items, max_no = max_no))
  }
}
)

instat_object$set("public", "reorder_columns_in_data", function(data_name, col_order){
  self$get_data_objects(data_name)$reorder_columns_in_data(col_order = col_order)
}
)

#TODO Think how to use row_data argument
instat_object$set("public", "insert_row_in_data", function(data_name, start_row, row_data = c(), number_rows = 1, before = FALSE) {
  self$get_data_objects(data_name)$insert_row_in_data(start_row = start_row, row_data = row_data, number_rows = number_rows, before = before)
}
)

instat_object$set("public", "get_data_frame_length", function(data_name, use_current_filter = FALSE) {
  self$get_data_objects(data_name)$get_data_frame_length(use_current_filter)
}
)

instat_object$set("public", "get_next_default_dataframe_name", function(prefix, include_index = TRUE, start_index = 1) {
  next_default_item(prefix = prefix, existing_names = names(private$.data_objects), include_index = include_index, start_index = start_index)
} 
)

instat_object$set("public", "delete_dataframes", function(data_names) {
  # TODO need a set or append
  for(name in data_names) {
    private$.data_objects[[name]] <- NULL
    data_objects_changed <- TRUE
    link_names <- c()
    for(i in seq_along(private$.links)) {
      if(private$.links[[i]]$from_data_frame == name || private$.links[[i]]$to_data_frame == name) {
        link_names <- c(link_names, names(private$.links)[i])
      }
    }
    for(link_name in link_names) {
      #TODO Should we be able to disable links instead of deleting?
      self$remove_link(link_name)
    }
  }
} 
)

instat_object$set("public", "remove_link", function(link_name) {
  if(!link_name %in% names(private$.links)) stop(link_name, " not found.")
  private$.links[[link_name]] <- NULL
}
)

instat_object$set("public", "get_column_factor_levels", function(data_name,col_name = "") {
  self$get_data_objects(data_name)$get_column_factor_levels(col_name)
} 
)

instat_object$set("public", "get_factor_data_frame", function(data_name, col_name = "", include_levels = TRUE) {
  self$get_data_objects(data_name)$get_factor_data_frame(col_name = col_name, include_levels = include_levels)
} 
)

instat_object$set("public", "sort_dataframe", function(data_name, col_names = c(), decreasing = FALSE, na.last = TRUE, by_row_names = FALSE, row_names_as_numeric = TRUE) {
  self$get_data_objects(data_name)$sort_dataframe(col_names = col_names, decreasing = decreasing, na.last = na.last, by_row_names = by_row_names, row_names_as_numeric = row_names_as_numeric)
} 
)

instat_object$set("public", "rename_dataframe", function(data_name, new_value = "", label = "") {
  data_obj <- self$get_data_objects(data_name)
  if(data_name != new_value) {
    if(new_value %in% names(private$.data_objects)) stop("Cannot rename data frame since ", new_value, " is an existing data frame.")
    names(private$.data_objects)[names(private$.data_objects) == data_name] <- new_value
    data_obj$append_to_metadata(data_name_label, new_value)
    self$update_links_rename_data_frame(data_name, new_value)
  }
  if(label != "") {
    data_obj$append_to_metadata(property = "label" , new_val = label)
  }
  data_obj$set_data_changed(TRUE)
  data_obj$set_metadata_changed(TRUE)
  data_obj$set_variables_metadata_changed(TRUE)
}
)

instat_object$set("public", "convert_column_to_type", function(data_name, col_names = c(), to_type, factor_values = NULL, set_digits, set_decimals = FALSE, keep_attr = TRUE, ignore_labels = FALSE) {
  self$get_data_objects(data_name)$convert_column_to_type(col_names = col_names, to_type = to_type, factor_values = factor_values, set_digits = set_digits,set_decimals = set_decimals, keep_attr = keep_attr, ignore_labels = ignore_labels)
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

instat_object$set("public", "append_to_metadata", function(property, new_val = "", allow_override_special = FALSE) {
  if(missing(property)) stop("property and new_val arguments must be specified.")
  
  if(!is.character(property)) stop("property must be of type character")
  if(!allow_override_special && property %in% c("class")) message("Cannot override property: ", property, ". Specify allow_override_special = TRUE to replace this property.")
  else {
    attr(self, property) <- new_val
    self$metadata_changed <- TRUE
    self$append_to_changes(list(Added_metadata, property))
  }
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

instat_object$set("public", "set_factor_levels", function(data_name, col_name, new_labels, new_levels, set_new_labels = TRUE) {
  self$get_data_objects(data_name)$set_factor_levels(col_name = col_name, new_labels = new_labels, new_levels = new_levels, set_new_labels = set_new_labels)
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

instat_object$set("public","copy_data_frame", function(data_name, new_name, label = "") {
  if(new_name %in% names(private$.data_objects)) stop("Cannot copy data frame since ", new_name, " is an existing data frame.")
  curr_obj <- self$get_data_objects(data_name)$clone(deep = TRUE)
  
  if(missing(new_name)) new_name <- next_default_item(data_name, self$get_data_names())
  self$append_data_object(new_name, curr_obj)
  new_data_obj <- self$get_data_objects(new_name)
  new_data_obj$data_changed <- TRUE
  new_data_obj$set_data_changed(TRUE)
  if(label != "") {
    new_data_obj$append_to_metadata(property = "label" , new_val = label)
    new_data_obj$set_metadata_changed(TRUE)
  }
} 
)

instat_object$set("public","set_hidden_columns", function(data_name, col_names = c()) {
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

instat_object$set("public","is_variables_metadata", function(data_name, property, column, return_vector = FALSE) {
  self$get_data_objects(data_name)$is_variables_metadata(property, column, return_vector)
} 
)

instat_object$set("public","data_frame_exists", function(data_name) {
  return(data_name %in% names(private$.data_objects))
} 
)

instat_object$set("public","add_key", function(data_name, col_names, key_name) {
  self$get_data_objects(data_name)$add_key(col_names, key_name)
  names(col_names) <- col_names
  self$add_link(data_name, data_name, col_names, keyed_link_label)
  invisible(sapply(self$get_data_objects(), function(x) if(!x$is_metadata(is_linkable)) x$append_to_metadata(is_linkable, FALSE)))
}
)

instat_object$set("public","is_key", function(data_name, col_names) {
  self$get_data_objects(data_name)$is_key(col_names)
}
)

instat_object$set("public","has_key", function(data_name) {
  self$get_data_objects(data_name)$has_key()
}
)

instat_object$set("public","get_keys", function(data_name, key_name) {
  self$get_data_objects(data_name)$get_keys(key_name)
}
)

instat_object$set("public","get_links", function(link_name) {
  if(!missing(link_name)) {
    if(!link_name %in% names(private$.links)) stop(link_name, " not found.")
    return(private$.links[[link_name]])
  }
  else return(private$.links)
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

instat_object$set("public","set_column_colours", function(data_name, columns, colours) {
  self$get_data_objects(data_name)$set_column_colours(columns, colours)
}
)

instat_object$set("public","has_colours", function(data_name, columns) {
  self$get_data_objects(data_name)$has_colours(columns)
}
)

instat_object$set("public", "remove_column_colours", function(data_name) {
  self$get_data_objects(data_name)$remove_column_colours()
}
)

instat_object$set("public","set_column_colours_by_metadata", function(data_name, columns, property) {
  self$get_data_objects(data_name)$set_column_colours_by_metadata(columns, property)
}
)

instat_object$set("public","graph_one_variable", function(data_name, columns, numeric = "geom_boxplot", categorical = "geom_bar", character = "geom_bar", output = "facets", free_scale_axis = FALSE, ncol = NULL, coord_flip  = FALSE, ...) {
  self$get_data_objects(data_name)$graph_one_variable(columns = columns, numeric = numeric, categorical = categorical, output = output, free_scale_axis = free_scale_axis, ncol = ncol, coord_flip = coord_flip, ... = ...)
}
)

instat_object$set("public","make_date_yearmonthday", function(data_name, year, month, day, year_format = "%Y", month_format = "%m", day_format = "%d") {
  self$get_data_objects(data_name)$make_date_yearmonthday(year = year, month = month, day = day, year_format = year_format, month_format = month_format, day_format = day_format)
}
)

instat_object$set("public","make_date_yeardoy", function(data_name, year, doy, year_format = "%Y", doy_format = "%j", doy_typical_length = "366") {
  self$get_data_objects(data_name)$make_date_yeardoy(year = year, doy = doy, year_format = year_format, doy_format = doy_format, doy_typical_length = doy_typical_length)
}
)

instat_object$set("public","set_contrasts_of_factor", function(data_name, col_name, new_contrasts, defined_contr_matrix) {
  self$get_data_objects(data_name)$set_contrasts_of_factor(col_name = col_name, new_contrasts = new_contrasts, defined_contr_matrix = defined_contr_matrix)
}
)

instat_object$set("public","create_factor_data_frame", function(data_name, factor, factor_data_frame_name, include_contrasts = TRUE, replace = FALSE) {
  curr_data_obj <- self$get_data_objects(data_name)
  if(!factor %in% names(curr_data_obj$get_data_frame())) stop(factor, " not found in the data")
  if(!is.factor(curr_data_obj$get_columns_from_data(factor))) stop(factor, " is not a factor column.")
  create <- TRUE
  if(self$link_exists_from(data_name, factor)) {
    message("Factor data frame already exists.")
    if(replace) {
      message("Current factor data frame will be replaced.")
      factor_named <- factor
      names(factor_named) <- factor
      curr_factor_df_name <- self$get_linked_to_data_name(data_name, factor_named)
      self$delete_dataframe(curr_factor_df_name)
    }
    else {
      warning("replace = FALSE so no action will be taken.")
      create <- FALSE
    }
  }
  if(create) {
    data_frame_list <- list()
    if(missing(factor_data_frame_name)) factor_data_frame_name <- paste0(data_name, "_", factor)
    factor_data_frame_name <- make.names(factor_data_frame_name)
    factor_data_frame_name <- next_default_item(factor_data_frame_name, self$get_data_names(), include_index = FALSE)
    
    factor_column <- curr_data_obj$get_columns_from_data(factor)
    factor_data_frame <- data.frame(levels(factor_column))
    names(factor_data_frame) <- factor
    if(include_contrasts) {
      factor_data_frame <- cbind(factor_data_frame, contrasts(factor_column))
    }
    row.names(factor_data_frame) <- 1:nrow(factor_data_frame)
    names(factor_data_frame)[2:ncol(factor_data_frame)] <- paste0("C", 1:(ncol(factor_data_frame)-1))
    data_frame_list[[factor_data_frame_name]] <- factor_data_frame
    self$import_data(data_frame_list)
    factor_data_obj <- self$get_data_objects(factor_data_frame_name)
    #TODO We shoud now never call add_key directly from the data object method because it needs to add a link as well at this point to itself
    factor_data_obj$add_key(factor)
    names(factor) <- factor
    self$add_link(from_data_frame = data_name, to_data_frame = factor_data_frame_name, link_pairs = factor, type = keyed_link_label)
  }
}
)

instat_object$set("public","split_date", function(data_name, col_name = "", year = FALSE, day = FALSE, week = FALSE,  month_val = FALSE, month_abbr = FALSE, month_name = FALSE, weekday_val = FALSE, weekday_abbr = FALSE, weekday_name = FALSE, day_in_month = FALSE, day_in_year = FALSE,  leap_year = FALSE, day_in_year_366 = FALSE, dekade = FALSE, pentad = FALSE, s_doy = FALSE, s_year = FALSE, s_start_day_in_month = 1, s_start_month = 8) {
  self$get_data_objects(data_name)$split_date(col_name = col_name , week = week, month_val = month_val,  month_abbr = month_abbr, month_name = month_name, weekday_val = weekday_val, weekday_abbr = weekday_abbr,  weekday_name =  weekday_name, day = day, year = year, day_in_month = day_in_month, day_in_year = day_in_year,  leap_year =  leap_year, day_in_year_366 = day_in_year_366, dekade = dekade, pentad = pentad, s_doy = s_doy, s_year = s_year, s_start_day_in_month = s_start_day_in_month, s_start_month = s_start_month)
}
)

instat_object$set("public", "import_SST", function(dataset, data_from = 5, data_names = c()) {
  data_list <- convert_SST(dataset, data_from)
  if(length(data_list) != length(data_names))stop("data_names vector should be of length 2")
  names(data_list) = data_names
  self$import_data(data_tables = data_list)
  self$add_key(data_names[2], c("lat", "lon"))
  self$add_link(from_data_frame = data_names[1], to_data_frame = data_names[2], link_pairs = c(lat = "lat", lon = "lon"), type = keyed_link_label)
}
)

instat_object$set("public","make_inventory_plot", function(data_name, date_col, station_col = NULL, year_col = NULL, doy_col = NULL, element_cols = NULL, add_to_data = FALSE, year_doy_plot = FALSE, coord_flip = FALSE, facet_by = NULL, graph_title = "Inventory Plot", key_colours = c("red", "grey"), display_rain_days = FALSE, rain_cats = list(breaks = c(0, 0.85, Inf), labels = c("Dry", "Rain"), key_colours = c("tan3", "blue"))) {
  self$get_data_objects(data_name)$make_inventory_plot(date_col = date_col, station_col = station_col, year_col = year_col, doy_col = doy_col, element_cols = element_cols, add_to_data = add_to_data, year_doy_plot = year_doy_plot, coord_flip = coord_flip, facet_by = facet_by, graph_title = graph_title, key_colours = key_colours, display_rain_days = display_rain_days, rain_cats = rain_cats)
}
)

instat_object$set("public", "import_NetCDF", function(nc, name, only_data_vars = TRUE, keep_raw_time = TRUE, include_metadata = TRUE, boundary) {
  if(only_data_vars) {
    all_var_names <- ncdf4.helpers::nc.get.variable.list(nc)
  }
  else {
    all_var_names <- names(nc$var)
  }
  remaining_var_names <- all_var_names
  var_groups <- list()
  dim_groups <- list()
  while(length(remaining_var_names) > 0) {
    grp <- remaining_var_names[1]
    dim_names <- ncdf4.helpers::nc.get.dim.names(nc, remaining_var_names[1])
    dim_groups[[length(dim_groups) + 1]] <- dim_names
    for(curr_var_name in remaining_var_names[-1]) {
      if(setequal(ncdf4.helpers::nc.get.dim.names(nc, curr_var_name), dim_names)) {
        grp <- c(grp, curr_var_name)
      }
    }
    remaining_var_names <- remaining_var_names[-which(remaining_var_names %in% grp)]
    var_groups[[length(var_groups) + 1]] <- grp
  }
  
  data_list <- list()
  use_prefix <- (length(seq_along(var_groups)) > 1)
  data_names <- c()
  for(i in seq_along(var_groups)) {
    if(use_prefix) curr_name <- paste0(name, "_", i)
    else curr_name <- name
    data_names <- c(data_names, curr_name)
    curr_boundary <- boundary[names(boundary) %in% dim_groups[[i]]]
    data_list[[curr_name]] <- nc_as_data_frame(nc, var_groups[[i]], keep_raw_time = keep_raw_time, include_metadata = include_metadata, boundary = curr_boundary)
    tmp_list <- list()
    tmp_list[[curr_name]] <- data_list[[curr_name]]
    self$import_data(data_tables = tmp_list)
    self$add_key(curr_name, dim_groups[[i]])
  }
  for(i in seq_along(data_names)) {
    for(j in seq_along(data_names)) {
      if(i != j && !self$link_exists_between(data_names[i], data_names[j]) && all(dim_groups[[i]] %in% dim_groups[[j]])) {
        pairs <- dim_groups[[i]]
        names(pairs) <- pairs
        self$add_link(data_names[j], data_names[i], pairs, keyed_link_label)
      }
    }
  }
}
)

# instat_object$set("public", "import_NetCDF", function(nc_data, main_data_name, loc_data_name, latitude_col_name = "", longitude_col_name = "") {
#   nc_result <- open_NetCDF(nc_data = nc_data, latitude_col_name = latitude_col_name, longitude_col_name = longitude_col_name)
#   if(length(nc_result) != 3)stop("Output from open_NetCDF should be a list of length 3")
#   
#   data_list = nc_result[c(1,2)]
#   
#   names(data_list) = c(main_data_name, next_default_item(prefix = loc_data_name, existing_names = self$get_data_names(), include_index = FALSE))
#   self$import_data(data_tables = data_list)
#   self$add_key(names(data_list)[2], nc_result[3][[1]])
#   named_char_vec  <- nc_result[3][[1]]
#   names(named_char_vec) <- named_char_vec
#   self$add_link(from_data_frame = names(data_list)[1], to_data_frame = names(data_list)[2], link_pairs = named_char_vec, type = keyed_link_label)
# }
# )

instat_object$set("public", "infill_missing_dates", function(data_name, date_name, factors) {
  self$get_data_objects(data_name)$infill_missing_dates(date_name = date_name, factor = factors)
}
)

instat_object$set("public", "get_key_names", function(data_name, include_overall = TRUE, include, exclude, include_empty = FALSE, as_list = FALSE, excluded_items = c()) {
  self$get_data_objects(data_name)$get_key_names(include_overall = include_overall, include, exclude, include_empty = include_empty, as_list = as_list, excluded_items = excluded_items)
}
)

instat_object$set("public", "remove_key", function(data_name, key_name) {
  self$get_data_objects(data_name)$remove_key(key_name)
}
)

instat_object$set("public", "add_climdex_indices", function(data_name, indices = list(), freq = "annual") {
  for(i in seq_along(indices)) {
    l <- list(indices[[i]])
    names(l) <- names(indices)[i]
    self$add_single_climdex_index(data_name = data_name, indices = l)
  }
}
)

instat_object$set("public", "add_single_climdex_index", function(data_name, indices = list(), freq = "annual") {
  if(!self$get_data_objects(data_name)$get_metadata(is_climatic_label))stop("Define data as climatic.")
  mix_monthly_annual = c("Monthly_Minimum_of_Daily_Minimum_Temperature", "Percentage_of_Days_When_Tmax_is_Above_90th_Percentile","Percentage_of_Days_When_Tmin_is_Above_90th_Percentile","Percentage_of_Days_When_Tmax_is_Below_10th_Percentile","Percentage_of_Days_When_Tmin_is_Below_10th_Percentile", "Monthly_Maximum_Consecutive_5day_Precipitation", "Monthly_Maximum_1day_Precipitation","Monthly_Maximum_of_Daily_Maximum_Temperature", "Monthly_Maximum_of_Daily_Minimum_Temperature","Monthly_Minimum_of_Daily_Maximum_Temperature", "Mean_Diurnal_Temperature_Range")
  
  if(((names(indices) %in% mix_monthly_annual) && freq=="monthly")){
    yy = as.data.frame(indices[[1]],row.names = NULL)
    yy1 <- cbind(Row.Names = rownames(yy), yy)
    split_data = str_split_fixed(string=yy1[,1], n=2, pattern="-")
    my_data = cbind(yy1, split_data)
    names(my_data) = c("Year_month", names(indices), "Year", "Month")
    my_data <- my_data[c(1,3,4,2)]
    my_data$Year = as.integer(as.character(my_data$Year))
    my_data$Month = as.integer(as.character(my_data$Month))
    year_col = self$get_climatic_column_name(data_name, year_label)
    month_col = self$get_climatic_column_name(data_name, month_label)
    key_list = list("Year", "Month")
    names(key_list) = c(as.name(year_col), as.name(month_col))
    if(self$get_linked_to_data_name(data_name, key_list)==""){
      data_list = list(my_data)
      names(data_list) = paste(data_name, "monthly", sep = "_")
      self$import_data(data_tables = data_list)
      self$add_key(paste(data_name, "monthly", sep = "_"), c("Year", "Month"))
      self$add_link(from_data_frame = data_name, to_data_frame = paste(data_name, "monthly", sep = "_"), link_pairs = key_list, type = keyed_link_label)
    }
    else{
      #self$merge_data(by=c("Year_month","Year", "Month"), data_name = self$get_linked_to_data_name(data_name, key_list), new_data = my_data )
      self$merge_data(data_name = self$get_linked_to_data_name(data_name, key_list), new_data = my_data )
    }
  }
  else{
    yy = as.data.frame(indices[[1]],row.names = NULL)
    my_data <- cbind(Row.Names = rownames(yy), yy)
    names(my_data) = c("Year", names(indices))
    my_data$Year = as.integer(as.character(my_data$Year))
    year_col = self$get_climatic_column_name(data_name, year_label)
    key_list = list("Year")
    names(key_list) = c(as.name(year_col))
    if(self$get_linked_to_data_name(data_name, key_list)==""){
      warning("Yearly_data is missing, it will be created.")
      data_list = list(my_data)
      names(data_list) = paste(data_name, "yearly", sep = "_")
      self$import_data(data_tables = data_list)
      self$add_key(paste(data_name, "yearly", sep = "_"), c("Year"))
      self$add_link(from_data_frame = data_name, to_data_frame = paste(data_name, "yearly", sep = "_"), link_pairs = key_list, type = keyed_link_label)
    }
    else{
      #self$merge_data(by=c("Year"), data_name=self$get_linked_to_data_name(data_name, key_list), new_data = my_data )
      self$merge_data(data_name=self$get_linked_to_data_name(data_name, key_list), new_data = my_data )
    }
  }
  
}
)

instat_object$set("public", "is_metadata", function(data_name, str) {
  self$get_data_objects(data_name)$is_metadata(str = str)
}
)

instat_object$set("public", "get_climatic_column_name", function(data_name, col_name) {
  self$get_data_objects(data_name)$get_climatic_column_name(col_name = col_name)
}
)

instat_object$set("public", "merge_data", function(data_name, new_data, by = NULL, type = "left", match = "all") {
  self$get_data_objects(data_name)$merge_data(new_data = new_data, by = by, type = type, match = match)
}
)

instat_object$set("public", "get_corruption_data_names", function() {
  corruption_names <- c()
  for(curr_name in self$get_data_names()) {
    if(self$get_data_objects(curr_name)$is_metadata(corruption_data_label) && self$get_data_objects(curr_name)$get_metadata(corruption_data_label)) {
      corruption_names <- c(corruption_names, curr_name)
    }
  }
  return(corruption_names)
}
)

instat_object$set("public", "get_corruption_contract_data_names", function() {
  corruption_names <- c()
  for(curr_name in self$get_data_names()) {
    if(self$get_data_objects(curr_name)$is_metadata(corruption_data_label) && self$get_data_objects(curr_name)$get_metadata(corruption_data_label) == corruption_contract_level_label) {
      corruption_names <- c(corruption_names, curr_name)
    }
  }
  return(corruption_names)
}
)

instat_object$set("public", "get_database_variable_names", function(query, data_name, include_overall = TRUE, include, exclude, include_empty = FALSE, as_list = FALSE, excluded_items = c()) {
  if(self$has_database_connection()) {
    temp_data <- DBI::dbGetQuery(self$get_database_connection(), query)
    if(as_list) {
      out <- list()
      out[["database"]] <- temp_data[[1]]
      return(out)
    }
    else return(temp_data[[1]])
  }
  else return(list())
}
)

instat_object$set("public", "get_nc_variable_names", function(file = "", as_list = FALSE, ...) {
  if(file == "") {
    vars <- ""
  }
  else {
    nc_file <- nc_open(file)
    vars <- names(nc_file$dim)
  }
  if(as_list) {
    out <- list()
    out[["dim variables"]] <- vars
    return(out)
  }
  else return(vars)
}
)

instat_object$set("public", "has_database_connection", function() {
  return(!is.null(self$get_database_connection()))
}
)

instat_object$set("public", "database_connect", function(dbname, user, host, port, drv = RMySQL::MySQL()) {
 password <- getPass::getPass(paste0(user, " password:"))
  out <- NULL
  out <- DBI::dbConnect(drv = drv, dbname = dbname, user = user, password = password, host = host, port = port)
  if(!is.null(out)) {
    self$set_database_connection(out)
  }
}
)

instat_object$set("public", "get_database_connection", function() {
  return(private$.database_connection)
}
)

instat_object$set("public", "set_database_connection", function(dbi_connection) {
  private$.database_connection <- dbi_connection
}
)

instat_object$set("public", "database_disconnect", function() {
  if(!is.null(self$get_database_connection())) {
    DBI::dbDisconnect(private$.database_connection)
    self$set_database_connection(NULL)
  }
}
)

instat_object$set("public", "import_from_climsoft", function(stations = c(), elements = c(), include_observation_data = FALSE, start_date = "", end_date = "") {
  #need to perform checks here
  con = self$get_database_connection()
  if(!is.null(stations)){
    my_stations = paste0("(", paste(as.character(stations), collapse=", "), ")")
    station_info <- DBI::dbGetQuery(con, paste0("SELECT * FROM station WHERE stationID in ", my_stations, ";"))
  }
  date_bounds=""
  if(start_date!=""){
    if(try(!is.na(as.Date( start_date, format= "%Y-%m-%d")))){
      date_bounds = paste0(date_bounds, " AND obsDatetime >",sQuote(start_date))
    }
    else{
      stop("start_date format should be yyyy-mm-yy.")
    }
  }
  if(end_date!=""){
    if(try(!is.na(as.Date(end_date, format= "%Y-%m-%d")))){
      date_bounds = paste0(date_bounds, " AND obsDatetime <",sQuote(end_date))
    }
    else{
      stop("end_date format should be yyyy-mm-yy.")
    }
  }
  
  if (length(elements) > 0){
    my_elements = paste0("(", paste0(sprintf("'%s'", elements), collapse = ", "), ")")
    element_ids = DBI::dbGetQuery(con, paste0("SELECT elementID FROM obselement WHERE elementName in", my_elements,";"))
    element_id_vec = paste0("(", paste0(sprintf("%d", element_ids$elementID), collapse = ", "), ")")
  }
  if(include_observation_data){
    if(!is.null(stations)){
      station_data <-  DBI::dbGetQuery(con, paste0("SELECT observationfinal.recordedFrom, observationfinal.describedBy, obselement.abbreviation, obselement.elementName,observationfinal.obsDatetime,observationfinal.obsValue FROM obselement,observationfinal WHERE obselement.elementId=observationfinal.describedBy AND observationfinal.recordedFrom IN", my_stations, "AND observationfinal.describedBy IN", element_id_vec, date_bounds, " ORDER BY observationfinal.recordedFrom, observationfinal.describedBy;"))
    }
    else{
      station_data <-  DBI::dbGetQuery(con, paste0("SELECT observationfinal.recordedFrom, observationfinal.describedBy, obselement.abbreviation, obselement.elementName,observationfinal.obsDatetime,observationfinal.obsValue FROM obselement,observationfinal WHERE obselement.elementId=observationfinal.describedBy AND observationfinal.describedBy IN", element_id_vec, date_bounds, " ORDER BY observationfinal.recordedFrom, observationfinal.describedBy;"))
      my_stations = paste0("(", paste(as.character(unique(station_data$recordedFrom)), collapse=", "), ")")
      station_info <-  DBI::dbGetQuery(con, paste0("SELECT * FROM station WHERE stationID in ", my_stations, ";"))
    }

    data_list <- list(station_info, station_data)
    names(data_list) = c("station_info","station_data")
  }
  else{
    data_list <- list(station_info)
    names(data_list) = "station_info"
  }
  self$import_data(data_tables = data_list)
  
  self$add_key("station_info", c("stationId"))
  if(include_observation_data)(self$add_link(from_data_frame = "station_data", to_data_frame = "station_info", link_pairs = c(recordedFrom = "stationId"), type = keyed_link_label))
}
)

instat_object$set("public", "import_from_iri", function(download_from, data_file, data_frame_name, location_data_name, path, X1, X2 = NA, Y1, Y2 = NA, get_area_point = "area"){
  
  data_list <- import_from_iri(download_from  = download_from, data_file = data_file, path = path, X1 = X1, X2 = X2, Y1 = Y1, Y2 = Y2, get_area_point = get_area_point)
  names(data_list) = c(next_default_item(prefix = data_frame_name , existing_names = self$get_data_names(), include_index = FALSE), next_default_item(prefix = location_data_name , existing_names = self$get_data_names(), include_index = FALSE))
  self$import_data(data_tables = data_list)
  loc_col_names <- names(data_list[[2]])
  self$add_key(location_data_name, loc_col_names)
  names(loc_col_names) <- loc_col_names
  self$add_link(from_data_frame = names(data_list)[1], to_data_frame = names(data_list)[2], link_pairs = loc_col_names, type = keyed_link_label)
} 
)

instat_object$set("public", "export_workspace", function(data_names, file, include_graphs = TRUE, include_models = TRUE, include_metadata = TRUE) {
  e <- new.env()
  for(temp_name in data_names) {
    e[[temp_name]] <- self$get_data_frame(temp_name, use_current_filter = FALSE)
    if(include_graphs) {
      graphs <- self$get_graphs(temp_name)
      graph_names <- names(graphs)
      for(i in seq_along(graphs)) {
        e[[paste(temp_name, graph_names[i], sep = "_")]] <- graphs[[i]]
      }
    }
    if(include_models) {
      models <- self$get_models(temp_name)
      model_names <- names(models)
      for(i in seq_along(models)) {
        e[[paste(temp_name, model_names[i], sep = "_")]] <- models[[i]]
      }
    }
    if(include_metadata) {
      var_metadata <- self$get_variables_metadata(temp_name)
      e[[paste(temp_name, "variables_metadata", sep = "_")]] <- var_metadata
    }
  }
  save(list = ls(all.names = TRUE, envir = e), envir = e, file = file)
} 
)

instat_object$set("public", "set_links", function(new_links) {
  private$.links <- new_links
} 
)