DataBook <- R6::R6Class("DataBook",
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
                            
                            private$.data_sheets_changed <- FALSE
                          }
                        ),
                        private = list(
                          .data_sheets = list(),
                          .metadata = list(),
                          .objects = list(),
                          .links = list(),
                          .data_sheets_changed = FALSE,
                          .database_connection = NULL,
                          .last_graph = NULL
                        ),
                        active = list(
                          data_objects_changed = function(new_value) {
                            if(missing(new_value)) return(private$.data_sheets_changed)
                            else {
                              if(new_value != TRUE && new_value != FALSE) stop("new_value must be TRUE or FALSE")
                              private$.data_sheets_changed <- new_value
                              #TODO is this behaviour we want?
                              invisible(sapply(self$get_data_objects(), function(x) x$data_changed <- new_value))
                            }
                          }
                        )
)

DataBook$set("public", "import_data", function(data_tables = list(), data_tables_variables_metadata = rep(list(data.frame()),length(data_tables)),
                                               data_tables_metadata = rep(list(list()),length(data_tables)),
                                               data_tables_filters = rep(list(list()),length(data_tables)),
                                               imported_from = as.list(rep("",length(data_tables))), 
                                               data_names = NULL,
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
    
    if(!is.null(data_names) && length(data_names) != length(data_names)) {
      stop("If data_names is specified it must be a list of the same length as data_tables")
    }
    
    # loop through the data_tables list and create a data object for each
    # data.frame given
    new_data_objects = list()
    for ( i in (1:length(data_tables)) ) {
      curr_name <- names(data_tables)[[i]]
      if(is.null(curr_name) && !is.null(data_names)) curr_name <- data_names[i]
      if(tolower(curr_name) %in% tolower(names(private$.data_sheets))) {
        warning("Cannot have data frames with the same name only differing by case. Data frame will be renamed.")
        curr_name <- next_default_item(tolower(curr_name), tolower(names(private$.data_sheets)))
      }
      
      new_data = DataSheet$new(data=data_tables[[i]], data_name = curr_name,
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

# TODO update parameter name to new_data_book
DataBook$set("public", "replace_instat_object", function(new_instat_object) {
  self$set_data_objects(list())
  for(curr_obj in new_instat_object$get_data_objects()) {
    self$append_data_object(curr_obj$get_metadata(data_name_label), curr_obj$data_clone())
  }
  self$set_meta(new_instat_object$get_metadata())
  self$set_objects(new_instat_object$get_objects(data_name = overall_label, as_list = FALSE))
  self$data_objects_changed <- TRUE
}
)

DataBook$set("public", "set_data_objects", function(new_data_objects) {
  if(!is.list(new_data_objects) || (length(new_data_objects) > 0 && !all("data_object" %in% sapply(new_data_objects, class)))) {
    stop("new_data_objects must be a list of data_objects")
  }
  else private$.data_sheets <- new_data_objects
}
)

DataBook$set("public", "copy_data_object", function(data_name, new_name, filter_name = "", reset_row_names = TRUE) {
  new_obj <- self$get_data_objects(data_name)$data_clone()
  if(filter_name != "") {
    subset_data <- self$get_data_objects(data_name)$get_data_frame(use_current_filter = FALSE, filter_name = filter_name, retain_attr = TRUE)
    if(reset_row_names) rownames(subset_data) <- 1:nrow(subset_data)
    new_obj$remove_current_filter()
    new_obj$set_data(subset_data)
  }
  self$append_data_object(new_name, new_obj)
}
)


DataBook$set("public", "import_RDS", function(data_RDS, keep_existing = TRUE, overwrite_existing = FALSE, include_objects = TRUE,
                                              include_metadata = TRUE, include_logs = TRUE, include_filters = TRUE, include_calculations = TRUE, include_comments = TRUE)
  # TODO add include_calcuations options
{
  # 'instat_object' is previously used class name, some files may have this name.
  if(any(c("instat_object", "DataBook") %in% class(data_RDS))) {
    if(!keep_existing && include_objects && include_metadata && include_logs && include_filters && include_calculations && include_comments) {
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
        data_obj_clone <- self$clone_data_object(data_RDS$get_data_objects(data_obj_name), include_objects = include_objects, include_metadata = include_metadata, include_logs = include_logs, include_filters = include_filters, include_calculations = include_calculations, include_comments = include_comments)
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

DataBook$set("public", "clone_data_object", function(curr_data_object, include_objects = TRUE, include_metadata = TRUE, include_logs = TRUE, include_filters = TRUE, include_calculations = TRUE, include_comments = TRUE, ...) {
  curr_names <- names(curr_data_object)
  if("get_data_frame" %in% curr_names) new_data <- curr_data_object$get_data_frame(use_current_filter = FALSE)
  else stop("Cannot import data. No 'get_data_frame' method.")
  if("get_metadata" %in% curr_names) new_data_name <- curr_data_object$get_metadata(data_name_label)
  if(include_objects && "get_objects" %in% curr_names) new_objects <- curr_data_object$get_objects()
  else new_objects <- list()
  if(include_filters && "get_filter" %in% curr_names) new_filters <- lapply(curr_data_object$get_filter(), function(x) x$data_clone())
  else new_filters <- list()
  if(include_calculations && "get_calculations" %in% curr_names) new_calculations <- lapply(curr_data_object$get_calculations(), function(x) self$clone_instat_calculation(x))
  else new_calculations <- list()
  if(include_comments && "get_comments" %in% curr_names) new_comments <- lapply(curr_data_object$get_comments(), function(x) x$data_clone())
  else new_comments <- list()
  if("get_keys" %in% curr_names) new_keys <- curr_data_object$get_keys()
  else new_keys <- list()
  
  new_data_object <- DataSheet$new(data = new_data, data_name = new_data_name, filters = new_filters, objects = new_objects, calculations = new_calculations, keys = new_keys, comments = new_comments, keep_attributes = include_metadata)
  if(include_logs && "get_changes" %in% curr_names) {
    new_changes <- curr_data_object$get_changes()
  }
  else new_changes <- list()
  new_data_object$set_changes(new_changes)
  if(include_filters && "current_filter" %in% curr_names) new_data_object$current_filter <- curr_data_object$get_current_filter()
  else new_data_object$remove_current_filter()
  if(!include_metadata) {
    new_data_object$clear_metadata()
    new_data_object$clear_variables_metadata()
  }
  new_data_object$data_changed <- TRUE
  new_data_object$metadata_changed <- TRUE
  new_data_object$variables_metadata_changed <- TRUE
  return(new_data_object)
}
)

DataBook$set("public", "clone_instat_calculation", function(curr_instat_calculation, ...) {
  
  new_manips <- lapply(curr_instat_calculation$manipulations, function(x) self$clone_instat_calculation(x))
  new_subs <- lapply(curr_instat_calculation$sub_calculations, function(x) self$clone_instat_calculation(x))
  new_instat_calculation <- instat_calculation$new(function_exp = curr_instat_calculation$function_exp, 
                                                   type = curr_instat_calculation$type,
                                                   name = curr_instat_calculation$name, 
                                                   result_name = curr_instat_calculation$result_name, 
                                                   manipulations = new_manips,
                                                   sub_calculations = new_subs,
                                                   calculated_from = curr_instat_calculation$calculated_from, 
                                                   save = curr_instat_calculation$save)
  return(new_instat_calculation)
}
)

DataBook$set("public", "import_from_ODK", function(username, form_name, platform) {
  out <- import_from_ODK(username, form_name, platform)
  data_list <- list(out)
  names(data_list) <- form_name
  self$import_data(data_tables = data_list)
}
)

# Now appending/merging not setting so maybe should be renamed
DataBook$set("public", "set_meta", function(new_meta) {
  if(!is.list(new_meta)) stop("new_meta must be of type: list")
  for(name in names(attributes(self))) {
    if(!name  %in% c("class")) attr(self, name) <- NULL
  }
  for(name in names(new_meta)) {
    self$append_to_metadata(name, new_meta[[name]])
  }
}
)

DataBook$set("public", "set_objects", function(new_objects) {
  if(!is.list(new_objects)) stop("new_objects must be of type: list")
  private$.objects <- new_objects 
}
)

DataBook$set("public", "append_data_object", function(name, obj) {
  if(!is.character(name)) stop("name must be a character")
  # obj could be of old class type 'data_object'
  if(!any(c("data_object", "DataSheet") %in% class(obj))) {
    stop("obj must be a data object")
  }
  obj$append_to_metadata(data_name_label, name)
  private$.data_sheets[[name]] <- obj
}
)

DataBook$set("public", "get_data_objects", function(data_name, as_list = FALSE, ...) {
  if(missing(data_name)) {
    return(private$.data_sheets)
  }
  else{
    if(all(is.character(data_name))) type = "character"
    else if(all(is.numeric(data_name)) && all((data_name %% 1) == 0)) type = "integer"
    else stop("data_name must be of type character or integer")
    
    if(type=="character" && !all(data_name %in% names(private$.data_sheets))) stop(paste(data_name, "not found"))
    if(type=="integer" && (!all(1 <= data_name) || !all(data_name <= length(private$.data_sheets)))) stop(paste(data_name, "not found"))
    if(length(data_name) > 1 || as_list) return(private$.data_sheets[data_name])
    else return(private$.data_sheets[[data_name]])
  }
}
)

DataBook$set("public", "get_data_frame", function(data_name, convert_to_character = FALSE, stack_data = FALSE, include_hidden_columns = TRUE, use_current_filter = TRUE, filter_name = "", remove_attr = FALSE, retain_attr = FALSE, max_cols, max_rows, drop_unused_filter_levels = FALSE, ...) {
  if(!stack_data) {
    if(missing(data_name)) data_name <- self$get_data_names()
    if(length(data_name) > 1) {
      retlist <- list()
      for (curr_name in data_name) {
        retlist[[curr_name]] = self$get_data_objects(curr_name)$get_data_frame(convert_to_character = convert_to_character, include_hidden_columns = include_hidden_columns, use_current_filter = use_current_filter, filter_name = filter_name, remove_attr = remove_attr, retain_attr = retain_attr, max_cols = max_cols, max_rows = max_rows, drop_unused_filter_levels = drop_unused_filter_levels)
      }
      return(retlist)
    }
    else return(self$get_data_objects(data_name)$get_data_frame(convert_to_character = convert_to_character, include_hidden_columns = include_hidden_columns, use_current_filter = use_current_filter, filter_name = filter_name, remove_attr = remove_attr, retain_attr = retain_attr, max_cols = max_cols, max_rows = max_rows, drop_unused_filter_levels = drop_unused_filter_levels))
  }
  else {
    if(missing(data_name)) stop("data to be stacked is missing")
    if(!data_name %in% names(private$.data_sheets)) stop(paste(data_name, "not found."))
    return(self$get_data_objects(data_name)$get_data_frame(include_hidden_columns = include_hidden_columns, use_current_filter = use_current_filter, filter_name = filter_name, stack_data = TRUE, ...))
  }
}
)

DataBook$set("public", "get_variables_metadata", function(data_name, data_type = "all", convert_to_character = FALSE, property, column, error_if_no_property = TRUE, direct_from_attributes = FALSE) { 
  if(missing(data_name)) {
    retlist <- list()
    for (curr_obj in private$.data_sheets) {
      retlist[[curr_obj$get_metadata(data_name_label)]] = curr_obj$get_variables_metadata(data_type = data_type, convert_to_character = convert_to_character, property = property, column = column, error_if_no_property = error_if_no_property, direct_from_attributes = direct_from_attributes)
    }
    return(retlist)
  }
  else return(self$get_data_objects(data_name)$get_variables_metadata(data_type = data_type, convert_to_character = convert_to_character, property = property, column = column, error_if_no_property = error_if_no_property, direct_from_attributes = direct_from_attributes))
} 
)

DataBook$set("public", "get_column_data_types", function(data_name, columns) {
  return(self$get_data_objects(data_name)$get_column_data_types(columns = columns))
}
)

DataBook$set("public", "get_column_labels", function(data_name, columns) {
  return(self$get_data_objects(data_name)$get_column_labels(columns = columns))
}
)

DataBook$set("public", "get_data_frame_metadata", function(data_name, label, include_calculated = TRUE, excluded_not_for_display = TRUE) {
  return(self$get_data_objects(data_name)$get_metadata(label = label, include_calculated = include_calculated, excluded_not_for_display = excluded_not_for_display))
}
)

DataBook$set("public", "get_combined_metadata", function(convert_to_character = FALSE) { 
  retlist <- data.frame()
  i = 1
  for (curr_obj in private$.data_sheets) {
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

DataBook$set("public", "get_metadata", function(name, ...) {
  if(missing(name)) return(private$.metadata)
  if(!is.character(name)) stop("name must be a character")
  if(!name %in% names(private$.metadata)) stop(paste(name, "not found in metadata"))
  return(private$.metadata[[name]])
} 
)

DataBook$set("public", "get_data_names", function(as_list = FALSE, include, exclude, excluded_items, include_hidden = TRUE, ...) { 
  ret <- names(private$.data_sheets)
  if(!include_hidden) {
    ret <- ret[sapply(ret, function(x) !isTRUE(self$get_data_objects(x)$get_metadata(label = is_hidden_label)))]
  }
  if(as_list) return(list(data_names = ret))
  else return(ret)
} 
)

DataBook$set("public", "get_data_changed", function(data_name) {
  if(missing(data_name)) {
    if(self$data_objects_changed) return (TRUE)
    for(curr_obj in private$.data_sheets) {
      if(curr_obj$data_changed) return(TRUE)
    }
    return(FALSE)
  }
  else {
    return(self$get_data_objects(data_name)$data_changed)
  }
} 
)

DataBook$set("public", "get_variables_metadata_changed", function(data_name) { 
  if(missing(data_name)) {
    if(private$.data_sheets_changed) return(TRUE)
    return(any(sapply(private$.data_sheets, function(x) x$variables_metadata_changed)))
  }
  else {
    return(self$get_data_objects(data_name)$variables_metadata_changed)
  }
} 
)

DataBook$set("public", "get_metadata_changed", function(data_name) { 
  if(missing(data_name)) {
    if(private$.data_sheets_changed) return(TRUE)
    for(curr_obj in private$.data_sheets) {
      if(curr_obj$metadata_changed) return(TRUE)
    }
    return(FALSE)
  }
  else {
    return(self$get_data_objects(data_name)$metadata_changed)
  }
} 
)

DataBook$set("public", "get_calculations", function(data_name) {
  return(self$get_data_objects(data_name)$get_calculations())
} 
)

DataBook$set("public", "get_calculation_names", function(data_name, as_list = FALSE, excluded_items = c()) {
  return(self$get_data_objects(data_name)$get_calculation_names(as_list = as_list, excluded_items = excluded_items))
} 
)

DataBook$set("public", "dataframe_count", function() {
  return(length(private$.data_sheets))
} 
)

DataBook$set("public", "set_data_frames_changed", function(data_name = "", new_val) {
  if(data_name == "") {
    for(curr_obj in private$.data_sheets) {
      curr_obj$data_changed <- new_val
    }
  }
  else self$get_data_objects(data_name)$set_data_changed(new_val)
} 
)

DataBook$set("public", "set_variables_metadata_changed", function(data_name = "", new_val) {
  if(data_name == "") {
    for(curr_obj in private$.data_sheets) {
      curr_obj$variables_metadata_changed <- new_val
    }
  }
  else self$get_data_objects(data_name)$set_variables_metadata_changed(new_val)
} 
)

DataBook$set("public", "set_metadata_changed", function(data_name = "", new_val) {
  if(data_name == "") {
    for(curr_obj in private$.data_sheets) {
      curr_obj$set_metadata_changed(new_val)
    }
  }
  else self$get_data_objects(data_name)$set_metadata_changed(new_val)
} 
)

DataBook$set("public", "add_columns_to_data", function(data_name, col_name = "", col_data, use_col_name_as_prefix = FALSE, hidden = FALSE, before, adjacent_column, num_cols, require_correct_length = TRUE, keep_existing_position = TRUE) {
  self$get_data_objects(data_name)$add_columns_to_data(col_name, col_data, use_col_name_as_prefix = use_col_name_as_prefix, hidden = hidden, before = before, adjacent_column = adjacent_column, num_cols = num_cols, require_correct_length = require_correct_length, keep_existing_position = keep_existing_position)
}
)

DataBook$set("public", "get_columns_from_data", function(data_name, col_names, from_stacked_data = FALSE, force_as_data_frame = FALSE, use_current_filter = TRUE, remove_labels = FALSE, drop_unused_filter_levels = FALSE) {
  if(missing(data_name)) stop("data_name is required")
  if(!from_stacked_data) {
    if(!data_name %in% names(private$.data_sheets)) stop(data_name, "not found")
    self$get_data_objects(data_name)$get_columns_from_data(col_names, force_as_data_frame, use_current_filter = use_current_filter, remove_labels = remove_labels, drop_unused_filter_levels = drop_unused_filter_levels)
  }
  else {
    if(!exists(data_name)) stop(paste(data_name, "not found."))
    if(!all(sapply(col_names, function(x) x %in% names(data_name)))) stop("Not all column names were found in data")
    if(length(col_names)==1 && !force_as_data_frame) return (data_name[[col_names]])
    else return(data_name[col_names])
  }
}
)

DataBook$set("public", "add_object", function(data_name, object, object_name) {
  if(missing(data_name)) {
    if(missing(object_name)) object_name = next_default_item("object", names(private$.objects))
    if(object_name %in% names(private$.objects)) message(paste("An object called", object_name, "already exists. It will be replaced."))
    private$.objects[[object_name]] <- object
  }
  else self$get_data_objects(data_name)$add_object(object = object, object_name = object_name)
}
) 

DataBook$set("public", "get_objects", function(data_name, object_name, include_overall = TRUE, as_list = FALSE, type = "", include_empty = FALSE, force_as_list = FALSE, print_graph = TRUE, ...) {
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
    if(!missing(object_name) && length(object_name) == 1) {
      if(print_graph && (ggplot2::is.ggplot(out) || any(c("gg", "ggmultiplot", "openair","recordedplot") %in% class(out)))) return(print(out))
      else return(out)
    }
    else return(out)
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
    else {
      if(print_graph && (ggplot2::is.ggplot(out) || any(c("gg", "ggmultiplot", "openair","recordedplot") %in% class(out)))) return(print(out))
      else return(out)
    }
  }
}
)

DataBook$set("public", "get_object_names", function(data_name, include_overall = TRUE, include, exclude, type = "", include_empty = FALSE, as_list = FALSE, excluded_items = c()) {
  if(type == "") overall_object_names = names(private$.objects)
  else {
    if(type == model_label) overall_object_names = names(private$.objects)[!sapply(private$.objects, function(x) any(c("ggplot", "gg", "gtable", "grob", "ggmultiplot", "ggsurv", "ggsurvplot", "htmlTable", "Surv") %in% class(x)))]
    else if(type == graph_label) overall_object_names = names(private$.objects)[sapply(private$.objects, function(x) any(c("ggplot", "gg", "gtable", "grob", "ggmultiplot", "ggsurv", "ggsurvplot", "openair","recordedplot") %in% class(x)))]
    else if(type == surv_label) overall_object_names = names(private$.objects)[sapply(private$.objects, function(x) any(c("Surv") %in% class(x)))]
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

DataBook$set("public", "rename_object", function(data_name, object_name, new_name, object_type = "object") {
  if(missing(data_name) || data_name == overall_label) {
    if(!object_name %in% names(private$.objects)) stop(object_name, " not found in overall objects list")
    if(new_name %in% names(private$.objects)) stop(new_name, " is already an object name. Cannot rename ", object_name, " to ", new_name)
    names(private$.objects)[names(private$.objects) == object_name] <- new_name
  }
  else self$get_data_objects(data_name)$rename_object(object_name = object_name, new_name = new_name, object_type = object_type)
}
)

DataBook$set("public", "delete_objects", function(data_name, object_names, object_type = "object") {
  if(missing(data_name) || data_name == overall_label) {
    if(!all(object_names %in% names(private$.objects))) stop("Not all object_names found in overall objects list")
  }
  else self$get_data_objects(data_name)$delete_objects(object_names = object_names, object_type = object_type)
}
)

DataBook$set("public", "reorder_objects", function(data_name, new_order) {
  if(missing(data_name) || data_name == overall_label) {
    if(length(new_order) != length(private$.objects) || !setequal(new_order, names(private$.objects))) stop("new_order must be a permutation of the current object names.")
    self$set_objects(private$.objects[new_order])
  }
  else self$get_data_objects(data_name)$reorder_objects(new_order = new_order)
}
)

DataBook$set("public", "get_from_object", function(data_name, object_name, value1, value2, value3) {
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

DataBook$set("public", "add_model", function(data_name, model, model_name) {
  self$add_object(data_name = data_name, object = model, object_name = model_name)
}
)

DataBook$set("public", "get_models", function(data_name, model_name, include_overall = TRUE, force_as_list = FALSE) {
  self$get_objects(data_name = data_name, object_name = model_name, include_overall = include_overall, type = model_label, force_as_list = force_as_list)
}
)

DataBook$set("public", "get_model_names", function(data_name, include_overall = TRUE, include, exclude, include_empty = FALSE, as_list = FALSE, excluded_items = c()) {
  self$get_object_names(data_name = data_name, include_overall = include_overall, include, exclude, type = model_label, include_empty = include_empty, as_list = as_list, excluded_items = excluded_items)
}
)

DataBook$set("public", "get_from_model", function(data_name, model_name, value1, value2, value3) {
  self$get_from_object(data_name = data_name, object_name = model_name, value1 = value1, value2 = value2, value3 = value3)
}
)

DataBook$set("public", "add_graph", function(data_name, graph, graph_name) {
  self$add_object(data_name = data_name, object = graph, object_name = graph_name)
  last_graph_name <- self$get_data_objects(data_name)$get_last_graph_name()
  if(!is.null(last_graph_name)) private$.last_graph <- c(data_name, last_graph_name)
}
)

DataBook$set("public", "get_graphs", function(data_name, graph_name, include_overall = TRUE, force_as_list = FALSE, print_graph = TRUE) {
  self$get_objects(data_name = data_name, object_name = graph_name, include_overall = include_overall, type = graph_label, force_as_list = force_as_list, print_graph = print_graph)
}
)

DataBook$set("public", "get_graph_names", function(data_name, include_overall = TRUE, include, exclude, include_empty = FALSE, as_list = FALSE, excluded_items = c()) {
  self$get_object_names(data_name = data_name, include_overall = include_overall, include, exclude, type = graph_label, include_empty = include_empty, as_list = as_list, excluded_items = excluded_items)
}
)

DataBook$set("public", "get_last_graph", function(print_graph = TRUE) {
  if(!is.null(private$.last_graph) && length(private$.last_graph) == 2) {
    self$get_objects(data_name = private$.last_graph[1], object_name = private$.last_graph[2], type = graph_label, print_graph = print_graph)
  }
}
)

DataBook$set("public", "add_surv", function(data_name, surv, surv_name) {
  self$add_object(data_name = data_name, object =surv, object_name =surv_name)
}
)

DataBook$set("public", "get_surv", function(data_name, surv_name, include_overall = TRUE, force_as_list = FALSE) {
  self$get_objects(data_name = data_name, object_name = surv_name, include_overall = include_overall, type = surv_label, force_as_list = force_as_list)
}
)

DataBook$set("public", "get_surv_names", function(data_name, include_overall = TRUE, include, exclude, include_empty = FALSE, as_list = FALSE, excluded_items = c()) {
  self$get_object_names(data_name = data_name, include_overall = include_overall, include, exclude, type = surv_label, include_empty = include_empty, as_list = as_list, excluded_items = excluded_items)
}
)

DataBook$set("public", "add_table", function(data_name, table, table_name) {
  self$add_object(data_name = data_name, object = table, object_name = table_name)
}
)

DataBook$set("public", "get_tables", function(data_name, table_name, include_overall = TRUE, force_as_list = FALSE) {
  self$get_objects(data_name = data_name, object_name = table_name, include_overall = include_overall, type = table_label, force_as_list = force_as_list)
}
)

DataBook$set("public", "get_table_names", function(data_name, include_overall = TRUE, include, exclude, include_empty = FALSE, as_list = FALSE, excluded_items = c()) {
  self$get_object_names(data_name = data_name, include_overall = include_overall, include, exclude, type = table_label, include_empty = include_empty, as_list = as_list, excluded_items = excluded_items)
}
)

DataBook$set("public", "add_filter", function(data_name, filter, filter_name = "", replace = TRUE, set_as_current_filter = FALSE, na.rm = TRUE, is_no_filter = FALSE, and_or = "&") {
  if(missing(filter)) stop("filter is required")
  self$get_data_objects(data_name)$add_filter(filter, filter_name, replace, set_as_current_filter, na.rm = na.rm, is_no_filter = is_no_filter, and_or = and_or)
}
) 

DataBook$set("public","add_filter_as_levels", function(data_name, filter_levels, column){
  self$get_data_objects(data_name)$add_filter_as_levels(filter_levels, column)
})


DataBook$set("public", "current_filter", function(data_name) {
  return(self$get_data_objects(data_name)$current_filter)
}
)

DataBook$set("public", "set_current_filter", function(data_name, filter_name = "") {
  self$get_data_objects(data_name)$set_current_filter(filter_name)
}
)

DataBook$set("public", "get_filter", function(data_name, filter_name) {
  return(self$get_data_objects(data_name)$get_filter(filter_name))
}
)

DataBook$set("public", "get_filter_as_logical", function(data_name, filter_name) {
  return(self$get_data_objects(data_name)$get_filter_as_logical(filter_name))
}
)

DataBook$set("public", "get_current_filter", function(data_name) {
  self$get_data_objects(data_name)$get_current_filter()
}
)

DataBook$set("public", "get_current_filter_name", function(data_name) {
  self$get_data_objects(data_name)$get_current_filter()$name
}
)

DataBook$set("public", "get_filter_names", function(data_name, as_list = FALSE, include = list(), exclude = list(), excluded_items = c()) {
  if(missing(data_name)) {
    #TODO what to do with excluded_items in this case
    return(lapply(self$get_data_objects(), function(x) x$get_filter_names(include = include, exclude = exclude)))
  } 
  else {
    return(self$get_data_objects(data_name)$get_filter_names(as_list = as_list, include = include, exclude = exclude, excluded_items = excluded_items))
  }
}
)

DataBook$set("public", "remove_current_filter", function(data_name) {
  self$get_data_objects(data_name)$remove_current_filter()
}
)

DataBook$set("public", "filter_applied", function(data_name) {
  self$get_data_objects(data_name)$filter_applied()
}
)

DataBook$set("public", "filter_string", function(data_name, filter_name) {
  self$get_data_objects(data_name)$filter_string(filter_name)
}
)

DataBook$set("public", "get_filter_as_instat_calculation", function(data_name, filter_name) {
  self$get_data_objects(data_name)$get_filter_as_instat_calculation(filter_name)
}
)

DataBook$set("public", "replace_value_in_data", function(data_name, col_names, rows, old_value, old_is_missing = FALSE, start_value = NA, end_value = NA, new_value, new_is_missing = FALSE, closed_start_value = TRUE, closed_end_value = TRUE, locf = FALSE, from_last = FALSE) {
  self$get_data_objects(data_name)$replace_value_in_data(col_names, rows, old_value, old_is_missing, start_value, end_value, new_value, new_is_missing, closed_start_value, closed_end_value, locf, from_last)
}
)

DataBook$set("public", "rename_column_in_data", function(data_name, column_name, new_val, label = "") {
  self$get_data_objects(data_name)$rename_column_in_data(column_name, new_val, label)
  self$update_links_rename_column(data_name = data_name, old_column_name = column_name, new_column_name = new_val)
} 
)

DataBook$set("public", "frequency_tables", function(data_name, x_col_names, y_col_name, n_column_factors = 1, store_results = TRUE, drop = TRUE, na.rm = FALSE, summary_name = NA, include_margins = FALSE, return_output = TRUE, treat_columns_as_factor = FALSE, page_by = "default", as_html = TRUE, signif_fig = 2, na_display = "", na_level_display = "NA", weights = NULL, caption = NULL, result_names = NULL, percentage_type = "none", perc_total_columns = NULL, perc_total_factors = c(), perc_total_filter = NULL, perc_decimal = FALSE, margin_name = "(All)", additional_filter, ...) {
  for(i in seq_along(x_col_names)) {
    cat(x_col_names[i], "by", y_col_name, "\n")
    print(data_book$summary_table(data_name = data_name, summaries = count_label, factors=c(x_col_names[i], y_col_name), n_column_factors = n_column_factors, store_results = store_results, drop = drop, na.rm = na.rm, summary_name = summary_name, include_margins = include_margins, return_output = return_output, treat_columns_as_factor = treat_columns_as_factor, page_by = page_by, as_html = as_html, signif_fig = signif_fig, na_display = na_display, na_level_display = na_level_display, weights = weights, caption = caption, result_names = result_names, percentage_type = percentage_type, perc_total_columns = perc_total_columns, perc_total_factors = perc_total_factors, perc_total_filter = perc_total_filter, perc_decimal = perc_decimal, margin_name = margin_name, additional_filter = additional_filter, ... = ...))
    cat("\n")
  }
} 
)

DataBook$set("public", "anova_tables", function(data_name, x_col_names, y_col_name, signif.stars = FALSE, sign_level = FALSE, means = FALSE) {
  self$get_data_objects(data_name)$anova_tables(x_col_names = x_col_names, y_col_name = y_col_name, signif.stars = signif.stars, sign_level = sign_level, means = means)
} 
)

DataBook$set("public", "cor", function(data_name, x_col_names, y_col_name, use = "everything", method = c("pearson", "kendall", "spearman")) {
  self$get_data_objects(data_name)$cor(x_col_names = x_col_names, y_col_name = y_col_name, use = use, method = method)
} 
)

DataBook$set("public", "remove_columns_in_data", function(data_name, cols, allow_delete_all = FALSE) {
  self$get_data_objects(data_name)$remove_columns_in_data(cols = cols, allow_delete_all = allow_delete_all)
} 
)

DataBook$set("public", "remove_rows_in_data", function(data_name, row_names) {
  self$get_data_objects(data_name)$remove_rows_in_data(row_names = row_names)
} 
)

DataBook$set("public", "get_next_default_column_name", function(data_name, prefix) {
  if(missing(data_name)) {
    out = list()
    for(curr_obj in private$.data_sheets) {
      out[[curr_obj$get_metadata(data_name_label)]] = curr_obj$get_next_default_column_name(prefix)
    }
    return(out)
  }
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(private$.data_sheets)) stop("dataframe: ", data_name, " not found")
  return(self$get_data_objects(data_name)$get_next_default_column_name(prefix))
} 
)

DataBook$set("public", "get_column_names", function(data_name, as_list = FALSE, include = list(), exclude = list(), excluded_items = c(), max_no) {
  if(missing(data_name)) {
    #TODO what to do with excluded items in this case?
    return(lapply(self$get_data_objects(), function(x) x$get_column_names(include = include, exclude = exclude, max_no = max_no)))
  } 
  else {
    return(self$get_data_objects(data_name)$get_column_names(as_list, include, exclude, excluded_items = excluded_items, max_no = max_no))
  }
}
)

DataBook$set("public", "reorder_columns_in_data", function(data_name, col_order){
  self$get_data_objects(data_name)$reorder_columns_in_data(col_order = col_order)
}
)

#TODO Think how to use row_data argument
DataBook$set("public", "insert_row_in_data", function(data_name, start_row, row_data = c(), number_rows = 1, before = FALSE) {
  self$get_data_objects(data_name)$insert_row_in_data(start_row = start_row, row_data = row_data, number_rows = number_rows, before = before)
}
)

DataBook$set("public", "get_data_frame_length", function(data_name, use_current_filter = FALSE) {
  self$get_data_objects(data_name)$get_data_frame_length(use_current_filter)
}
)

DataBook$set("public", "get_next_default_dataframe_name", function(prefix, include_index = TRUE, start_index = 1) {
  next_default_item(prefix = prefix, existing_names = names(private$.data_sheets), include_index = include_index, start_index = start_index)
} 
)

DataBook$set("public", "delete_dataframes", function(data_names) {
  # TODO need a set or append
  for(name in data_names) {
    private$.data_sheets[[name]] <- NULL
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
    if(!is.null(private$.last_graph) && private$.last_graph[1] %in% data_names) private$.last_graph <- NULL
  }
} 
)

DataBook$set("public", "remove_link", function(link_name) {
  if(!link_name %in% names(private$.links)) stop(link_name, " not found.")
  private$.links[[link_name]] <- NULL
}
)

DataBook$set("public", "get_column_factor_levels", function(data_name,col_name = "") {
  self$get_data_objects(data_name)$get_column_factor_levels(col_name)
} 
)

DataBook$set("public", "get_factor_data_frame", function(data_name, col_name = "", include_levels = TRUE, include_NA_level = FALSE) {
  self$get_data_objects(data_name)$get_factor_data_frame(col_name = col_name, include_levels = include_levels, include_NA_level = include_NA_level)
} 
)

DataBook$set("public", "sort_dataframe", function(data_name, col_names = c(), decreasing = FALSE, na.last = TRUE, by_row_names = FALSE, row_names_as_numeric = TRUE) {
  self$get_data_objects(data_name)$sort_dataframe(col_names = col_names, decreasing = decreasing, na.last = na.last, by_row_names = by_row_names, row_names_as_numeric = row_names_as_numeric)
} 
)

DataBook$set("public", "rename_dataframe", function(data_name, new_value = "", label = "") {
  data_obj <- self$get_data_objects(data_name)
  if(data_name != new_value) {
    if(tolower(new_value) %in% tolower(names(private$.data_sheets)[-which(names(private$.data_sheets) == data_name)])) stop("Cannot rename data frame since ", new_value, " is an existing data frame.")
    names(private$.data_sheets)[names(private$.data_sheets) == data_name] <- new_value
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

DataBook$set("public", "convert_column_to_type", function(data_name, col_names = c(), to_type, factor_values = NULL, set_digits, set_decimals = FALSE, keep_attr = TRUE, ignore_labels = FALSE, keep.labels = TRUE) {
  self$get_data_objects(data_name)$convert_column_to_type(col_names = col_names, to_type = to_type, factor_values = factor_values, set_digits = set_digits,set_decimals = set_decimals, keep_attr = keep_attr, ignore_labels = ignore_labels, keep.labels = keep.labels)
}
)

DataBook$set("public", "append_to_variables_metadata", function(data_name, col_names, property, new_val = "") {
  self$get_data_objects(data_name)$append_to_variables_metadata(col_names, property, new_val)
} 
)

DataBook$set("public", "append_to_dataframe_metadata", function(data_name, property, new_val = "") {
  self$get_data_objects(data_name)$append_to_metadata(property, new_val)
} 
)

DataBook$set("public", "append_to_metadata", function(property, new_val = "", allow_override_special = FALSE) {
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

DataBook$set("public", "add_metadata_field", function(data_name, property, new_val = "") {
  if(missing(property)) stop("property and new_val arguments must be specified.")
  if(data_name == overall_label) {
    invisible(sapply(self$get_data_objects(), function(x) x$append_to_metadata(property, new_val)))
  }
  else invisible(sapply(self$get_data_objects(data_name, as_list = TRUE), function(x) x$append_to_variables_metadata(property = property, new_val = new_val)))
}
)

DataBook$set("public", "reorder_dataframes", function(data_frames_order) {
  if(length(data_frames_order) != length(names(private$.data_sheets))) stop("number data frames to order should be equal to number of dataframes in the object")
  if(!setequal(data_frames_order,names(private$.data_sheets))) stop("data_frames_order must be a permutation of the dataframe names.")
  
  self$set_data_objects(private$.data_sheets[data_frames_order])
  self$data_objects_changed <- TRUE
} 
)

DataBook$set("public", "copy_columns", function(data_name, col_names = "") {
  self$get_data_objects(data_name)$copy_columns(col_names = col_names)
} 
)

DataBook$set("public", "drop_unused_factor_levels", function(data_name, col_name) {
  self$get_data_objects(data_name)$drop_unused_factor_levels(col_name = col_name)
} 
)

DataBook$set("public", "set_factor_levels", function(data_name, col_name, new_labels, new_levels, set_new_labels = TRUE) {
  self$get_data_objects(data_name)$set_factor_levels(col_name = col_name, new_labels = new_labels, new_levels = new_levels, set_new_labels = set_new_labels)
} 
)

DataBook$set("public", "edit_factor_level", function(data_name, col_name,old_level, new_level) {
  self$get_data_objects(data_name)$edit_factor_level(col_name = col_name, old_level = old_level, new_level = new_level)
} 
)

DataBook$set("public", "set_factor_reference_level", function(data_name, col_name, new_ref_level) {
  self$get_data_objects(data_name)$set_factor_reference_level(col_name = col_name, new_ref_level = new_ref_level)
} 
)

DataBook$set("public", "get_column_count", function(data_name) {
  return(self$get_data_objects(data_name)$get_column_count())
} 
)

DataBook$set("public", "reorder_factor_levels", function(data_name, col_name, new_level_names) {
  self$get_data_objects(data_name)$reorder_factor_levels(col_name = col_name, new_level_names = new_level_names)
} 
)

DataBook$set("public","get_data_type", function(data_name, col_name) {
  self$get_data_objects(data_name)$get_data_type(col_name = col_name)
} 
)

DataBook$set("public","copy_data_frame", function(data_name, new_name, label = "") {
  if(new_name %in% names(private$.data_sheets)) stop("Cannot copy data frame since ", new_name, " is an existing data frame.")
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

DataBook$set("public","set_hidden_columns", function(data_name, col_names = c()) {
  self$get_data_objects(data_name)$set_hidden_columns(col_names = col_names)
} 
)

DataBook$set("public","unhide_all_columns", function(data_name) {
  if(missing(data_name)) invisible(sapply(self$get_data_objects(), function(obj) obj$unhide_all_columns()))
  else self$get_data_objects(data_name)$unhide_all_columns()
} 
)

DataBook$set("public","set_hidden_data_frames", function(data_names = c()) {
  invisible(sapply(data_names, function(x) self$append_to_dataframe_metadata(data_name = x, property = is_hidden_label, new_val = TRUE)))
  unhide_data_names <- setdiff(self$get_data_names(), data_names)
  invisible(sapply(unhide_data_names, function(x) self$append_to_dataframe_metadata(data_name = x, property = is_hidden_label, new_val = FALSE)))
} 
)

DataBook$set("public","get_hidden_data_frames", function() {
  all_data_names <- names(private$.data_sheets)
  visible_data_names <- all_data_names[sapply(all_data_names, function(x) !isTRUE(self$get_data_objects(x)$get_metadata(label = is_hidden_label)))]
  hidden_data_names <- setdiff(all_data_names, visible_data_names)
  return(hidden_data_names)
} 
)

DataBook$set("public","set_row_names", function(data_name, row_names) {
  self$get_data_objects(data_name)$set_row_names(row_names = row_names)
} 
)

DataBook$set("public","get_row_names", function(data_name) {
  self$get_data_objects(data_name)$get_row_names()
} 
)

DataBook$set("public","set_protected_columns", function(data_name, col_names) {
  self$get_data_objects(data_name)$set_protected_columns(col_names = col_names)
} 
)

DataBook$set("public","get_metadata_fields", function(data_name, include_overall, as_list = FALSE, include, exclude, excluded_items = c()) {
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

DataBook$set("public","freeze_columns", function(data_name, column) {
  self$get_data_objects(data_name)$freeze_columns(column = column)
} 
)

DataBook$set("public","unfreeze_columns", function(data_name) {
  self$get_data_objects(data_name)$unfreeze_columns()
} 
)

DataBook$set("public","is_variables_metadata", function(data_name, property, column, return_vector = FALSE) {
  self$get_data_objects(data_name)$is_variables_metadata(property, column, return_vector)
} 
)

DataBook$set("public","data_frame_exists", function(data_name) {
  return(data_name %in% names(private$.data_sheets))
} 
)

DataBook$set("public","add_key", function(data_name, col_names, key_name) {
  self$get_data_objects(data_name)$add_key(col_names, key_name)
  names(col_names) <- col_names
  self$add_link(data_name, data_name, col_names, keyed_link_label)
  invisible(sapply(self$get_data_objects(), function(x) if(!x$is_metadata(is_linkable)) x$append_to_metadata(is_linkable, FALSE)))
}
)

DataBook$set("public","is_key", function(data_name, col_names) {
  self$get_data_objects(data_name)$is_key(col_names)
}
)

DataBook$set("public","has_key", function(data_name) {
  self$get_data_objects(data_name)$has_key()
}
)

DataBook$set("public","get_keys", function(data_name, key_name) {
  self$get_data_objects(data_name)$get_keys(key_name)
}
)

DataBook$set("public","get_comments", function(data_name, comment_id) {
  self$get_data_objects(data_name)$get_comments(comment_id)
}
)

DataBook$set("public","get_links", function(link_name, ...) {
  if(!missing(link_name)) {
    if(!link_name %in% names(private$.links)) stop(link_name, " not found.")
    return(private$.links[[link_name]])
  }
  else return(private$.links)
}
)

DataBook$set("public","set_structure_columns", function(data_name, struc_type_1 = c(), struc_type_2 = c(), struc_type_3 = c()) {
  self$get_data_objects(data_name)$set_structure_columns(struc_type_1, struc_type_2, struc_type_3)
}
)

DataBook$set("public","add_dependent_columns", function(data_name, columns, dependent_cols) {
  self$get_data_objects(data_name)$add_dependent_columns(columns, dependent_cols)
}
)

DataBook$set("public","set_column_colours", function(data_name, columns, colours) {
  self$get_data_objects(data_name)$set_column_colours(columns, colours)
}
)

DataBook$set("public","has_colours", function(data_name, columns) {
  self$get_data_objects(data_name)$has_colours(columns)
}
)

DataBook$set("public", "remove_column_colours", function(data_name) {
  self$get_data_objects(data_name)$remove_column_colours()
}
)

DataBook$set("public","set_column_colours_by_metadata", function(data_name, columns, property) {
  self$get_data_objects(data_name)$set_column_colours_by_metadata(columns, property)
}
)

DataBook$set("public","graph_one_variable", function(data_name, columns, numeric = "geom_boxplot", categorical = "geom_bar", character = "geom_bar", output = "facets", free_scale_axis = FALSE, ncol = NULL, coord_flip  = FALSE, ...) {
  self$get_data_objects(data_name)$graph_one_variable(columns = columns, numeric = numeric, categorical = categorical, output = output, free_scale_axis = free_scale_axis, ncol = ncol, coord_flip = coord_flip, ... = ...)
}
)

DataBook$set("public","make_date_yearmonthday", function(data_name, year, month, day, f_year, f_month, f_day, year_format = "%Y", month_format = "%m") {
  self$get_data_objects(data_name)$make_date_yearmonthday(year = year, month = month, day = day, f_year = f_year, f_month = f_month, f_day = f_day, year_format = year_format, month_format = month_format)
}
)

DataBook$set("public","make_date_yeardoy", function(data_name, year, doy, year_format = "%Y", doy_format = "%j", doy_typical_length = "366") {
  self$get_data_objects(data_name)$make_date_yeardoy(year = year, doy = doy, year_format = year_format, doy_format = doy_format, doy_typical_length = doy_typical_length)
}
)

DataBook$set("public","set_contrasts_of_factor", function(data_name, col_name, new_contrasts, defined_contr_matrix) {
  self$get_data_objects(data_name)$set_contrasts_of_factor(col_name = col_name, new_contrasts = new_contrasts, defined_contr_matrix = defined_contr_matrix)
}
)

DataBook$set("public","create_factor_data_frame", function(data_name, factor, factor_data_frame_name, include_contrasts = TRUE, replace = FALSE) {
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
      # TODO what if there is more than 1?
      if(length(curr_factor_df_name) > 0) self$delete_dataframe(curr_factor_df_name[1])
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

DataBook$set("public","split_date", function(data_name, col_name = "", year_val = FALSE, year_name = FALSE, leap_year = FALSE,  month_val = FALSE, month_abbr = FALSE, month_name = FALSE, week_val = FALSE, week_abbr = FALSE, week_name = FALSE, weekday_val = FALSE, weekday_abbr = FALSE, weekday_name = FALSE,  day = FALSE, day_in_month = FALSE, day_in_year = FALSE, day_in_year_366 = FALSE, pentad_val = FALSE, pentad_abbr = FALSE, dekad_val = FALSE, dekad_abbr = FALSE, quarter_val = FALSE, quarter_abbr = FALSE, with_year = FALSE, s_start_month = 1, s_start_day_in_month = 1, days_in_month = FALSE) {
  self$get_data_objects(data_name)$split_date(col_name = col_name , year_val = year_val, year_name = year_name, leap_year =  leap_year, month_val = month_val, month_abbr = month_abbr, month_name = month_name, week_val = week_val, week_abbr = week_abbr, week_name = week_name,  weekday_val = weekday_val, weekday_abbr = weekday_abbr,  weekday_name =  weekday_name, day = day,  day_in_month = day_in_month, day_in_year = day_in_year,   day_in_year_366 = day_in_year_366, pentad_val = pentad_val, pentad_abbr = pentad_abbr, dekad_val = dekad_val, dekad_abbr = dekad_abbr, quarter_val = quarter_val,  quarter_abbr = quarter_abbr, with_year = with_year, s_start_month = s_start_month, s_start_day_in_month = s_start_day_in_month, days_in_month = days_in_month)
}
)

DataBook$set("public", "import_SST", function(dataset, data_from = 5, data_names = c()) {
  data_list <- convert_SST(dataset, data_from)
  if(length(data_list) != length(data_names))stop("data_names vector should be of length 2")
  names(data_list) = data_names
  self$import_data(data_tables = data_list)
  self$add_key(data_names[2], c("lat", "lon"))
  self$add_link(from_data_frame = data_names[1], to_data_frame = data_names[2], link_pairs = c(lat = "lat", lon = "lon"), type = keyed_link_label)
}
)

DataBook$set("public","make_inventory_plot", function(data_name, date_col, station_col = NULL, year_col = NULL, doy_col = NULL, element_cols = NULL, add_to_data = FALSE, year_doy_plot = FALSE, coord_flip = FALSE, facet_by = NULL, graph_title = "Inventory Plot", graph_subtitle = NULL, graph_caption = NULL, title_size = NULL, subtitle_size = NULL, caption_size = NULL, labelXAxis, labelYAxis, xSize = NULL, ySize = NULL, Xangle = NULL, Yangle = NULL, scale_xdate, fromXAxis = NULL, toXAxis = NULL, byXaxis = NULL, date_ylabels, legend_position = NULL, xlabelsize = NULL, ylabelsize = NULL, scale = NULL, dir = "", row_col_number, nrow = NULL, ncol = NULL, key_colours = c("red", "grey"), display_rain_days = FALSE, facet_xsize = 7, facet_ysize = 11, scale_ydate = FALSE, date_ybreaks, step = 1, rain_cats = list(breaks = c(0, 0.85, Inf), labels = c("Dry", "Rain"), key_colours = c("tan3", "blue"))) {
  self$get_data_objects(data_name)$make_inventory_plot(date_col = date_col, station_col = station_col, year_col = year_col, doy_col = doy_col, element_cols = element_cols, add_to_data = add_to_data, year_doy_plot = year_doy_plot, coord_flip = coord_flip, facet_by = facet_by, graph_title = graph_title, key_colours = key_colours, display_rain_days = display_rain_days, rain_cats = rain_cats, graph_subtitle = graph_subtitle, graph_caption = graph_caption, title_size = title_size, subtitle_size = subtitle_size, caption_size = caption_size, labelXAxis = labelXAxis, labelYAxis = labelYAxis, xSize = xSize, ySize = ySize, Xangle = Xangle, Yangle = Yangle, scale_xdate = scale_xdate, fromXAxis = fromXAxis, toXAxis = toXAxis, byXaxis = byXaxis, xlabelsize = xlabelsize, scale_ydate = scale_ydate, date_ybreaks = date_ybreaks, step = step, ylabelsize = ylabelsize, date_ylabels = date_ylabels, legend_position = legend_position, dir = dir, row_col_number = row_col_number, nrow = nrow, ncol = ncol, scale = scale, facet_xsize = facet_xsize, facet_ysize = facet_ysize)
}
)

DataBook$set("public", "import_NetCDF", function(nc, path, name, only_data_vars = TRUE, keep_raw_time = TRUE, include_metadata = TRUE, boundary, lon_points = NULL, lat_points = NULL, id_points = NULL, show_requested_points = TRUE, great_circle_dist = FALSE) {
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
    if(!missing(boundary)) curr_boundary <- boundary[names(boundary) %in% dim_groups[[i]]]
    else curr_boundary <- NULL
    curr_name <- make.names(curr_name)
    curr_name <- next_default_item(curr_name, self$get_data_names(), include_index = FALSE)
    if(!missing(path)) data_list[[curr_name]] <- multiple_nc_as_data_frame(path = path, vars = var_groups[[i]], keep_raw_time = keep_raw_time, include_metadata = include_metadata, boundary = curr_boundary, lon_points = lon_points, lat_points = lat_points, id_points = id_points, show_requested_points = show_requested_points, great_circle_dist = great_circle_dist)
    else data_list[[curr_name]] <- nc_as_data_frame(nc = nc, vars = var_groups[[i]], keep_raw_time = keep_raw_time, include_metadata = include_metadata, boundary = curr_boundary, lon_points = lon_points, lat_points = lat_points, id_points = id_points, show_requested_points = show_requested_points, great_circle_dist = great_circle_dist)
    tmp_list <- list()
    tmp_list[[curr_name]] <- data_list[[curr_name]]
    data_names <- c(data_names, curr_name)
    self$import_data(data_tables = tmp_list)
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

# DataBook$set("public", "import_NetCDF", function(nc_data, main_data_name, loc_data_name, latitude_col_name = "", longitude_col_name = "") {
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

DataBook$set("public", "infill_missing_dates", function(data_name, date_name, factors, start_month, start_date, end_date, resort = TRUE) {
  self$get_data_objects(data_name)$infill_missing_dates(date_name = date_name, factor = factors, start_month = start_month, start_date = start_date, end_date = end_date, resort = resort)
}
)

DataBook$set("public", "get_key_names", function(data_name, include_overall = TRUE, include, exclude, include_empty = FALSE, as_list = FALSE, excluded_items = c()) {
  self$get_data_objects(data_name)$get_key_names(include_overall = include_overall, include, exclude, include_empty = include_empty, as_list = as_list, excluded_items = excluded_items)
}
)

DataBook$set("public", "remove_key", function(data_name, key_name) {
  self$get_data_objects(data_name)$remove_key(key_name)
}
)

DataBook$set("public", "add_climdex_indices", function(data_name, climdex_output, freq = "annual", station, year, month) {
  stopifnot(freq %in% c("annual", "monthly"))
  if (missing(climdex_output)) stop("climdex_output is required.")
  if (missing(year)) stop("year is required.")
  if (freq == "monthly" && missing(month)) stop("month is required for freq = 'monthly'.")
  
  col_year <- self$get_columns_from_data(data_name = data_name, col_names = year)
  if (!missing(station)) col_station <- self$get_columns_from_data(data_name = data_name, col_names = station)
  if (freq == "monthly") col_month <- self$get_columns_from_data(data_name = data_name, col_names = month)
  links_cols <- year
  if (!missing(station)) links_cols <- c(station, links_cols)
  if (freq == "monthly") links_cols <- c(links_cols, month)
  linked_data_name <- self$get_linked_to_data_name(data_name, links_cols)
  if (length(linked_data_name) == 0) {
    # The classes should be the same if climdex_output comes from climdex() function.
    # If not, try to match the classes so that they are sensibly linked.
    # TODO These checks are repeated and could be extracted out.
    if (!missing(station) && !all(class(col_station) == class(climdex_output[[station]]))) {
      if (is.numeric(col_station)) climdex_output[[station]] <- as.numeric(climdex_output[[station]])
      else if (is.factor(col_station)) climdex_output[[station]] <- make_factor(climdex_output[[station]])
      else if (is.character(col_station)) climdex_output[[station]] <- as.character(climdex_output[[station]])
      else warning("Cannot recognise the class of station column. Link between data frames may be unstable.")
    }
    if (!all(class(col_year) == class(climdex_output[[year]]))) {
      if (is.numeric(col_year)) climdex_output[[year]] <- as.numeric(climdex_output[[year]])
      else if (is.factor(col_year)) climdex_output[[year]] <- make_factor(climdex_output[[year]])
      else if (is.character(col_year)) climdex_output[[year]] <- as.character(climdex_output[[year]])
      else warning("Cannot recognise the class of year column. Link between data frames may be unstable.")
    }
    if (freq == "monthly" && !all(class(col_month) == class(climdex_output[[month]]))) {
      if (is.numeric(col_month)) climdex_output[[month]] <- as.numeric(climdex_output[[month]])
      else if (is.factor(col_month)) {
        lvs <- levels(col_month)
        if (length(lvs) == 12) climdex_output[[month]] <- factor(climdex_output[[month]], labels = lvs, ordered = is.ordered(col_month))
        else {
          warning("month is a factor but does not have 12 levels. Output may not link correctly to data.")
          climdex_output[[month]] <- make_factor(climdex_output[[month]])
        }
      }
      else if (is.character(col_month)) {
        mns <- unique(col_month)
        # Also check English names as month.abb and month.name constants are locale dependent.
        if (length(mns) == 12) {
          if (setequal(mns, month.abb)) climdex_output[[month]] <- month.abb[climdex_output[[month]]]
          else if (setequal(mns, month.name)) climdex_output[[month]] <- month.name[climdex_output[[month]]]
          else if (setequal(mns, month_abb_english)) climdex_output[[month]] <- month_abb_english[climdex_output[[month]]]
          else if (setequal(mns, month_name_english)) climdex_output[[month]] <- month_name_english[climdex_output[[month]]]
          else if (setequal(mns, tolower(month_abb_english))) climdex_output[[month]] <- tolower(month_abb_english)[climdex_output[[month]]]
          else if (setequal(mns, tolower(month_name_english))) climdex_output[[month]] <- tolower(month_name_english)[climdex_output[[month]]]
          else if (setequal(mns, toupper(month_abb_english))) climdex_output[[month]] <- toupper(month_abb_english)[climdex_output[[month]]]
          else if (setequal(mns, toupper(month_name_english))) climdex_output[[month]] <- toupper(month_name_english)[climdex_output[[month]]]
          else warning("Cannot determine format of month column in data. Output may not link correctly to data.")
        } else {
          warning("month does not have 12 unique values. Output may not link correctly to data.")
          climdex_output[[month]] <- as.character(climdex_output[[month]])
        }
      }
    }
    data_list <- list(climdex_output)
    new_data_name <- paste(data_name, "by", paste(links_cols, collapse = "_"), sep = "_")
    new_data_name <- next_default_item(prefix = new_data_name , existing_names = self$get_data_names(), include_index = FALSE)
    names(data_list) <- new_data_name
    self$import_data(data_tables = data_list)
    self$add_key(new_data_name, links_cols)
    key_list <- as.list(links_cols)
    names(key_list) <- links_cols
    self$add_link(from_data_frame = data_name, to_data_frame = new_data_name, link_pairs = key_list, type = keyed_link_label)
  } else {
    # TODO what if there are multiple linked data frames?
    linked_data_name <- linked_data_name[1]
    year_col_name_linked <- self$get_equivalent_columns(from_data_name = data_name, to_data_name = linked_data_name, columns = year)
    by <- year
    names(by) <- year_col_name_linked
    if (!missing(station)) {
      station_col_name_linked <- self$get_equivalent_columns(from_data_name = data_name, to_data_name = linked_data_name, columns = station)
      linked_station_data <- self$get_columns_from_data(data_name = linked_data_name, col_names = station_col_name_linked)
      by <- c(station, by)
      names(by)[1] <- station_col_name_linked
    }
    if (freq == "monthly") {
      month_col_name_linked <- self$get_equivalent_columns(from_data_name = data_name, to_data_name = linked_data_name, columns = month)
      linked_month_data <- self$get_columns_from_data(data_name = linked_data_name, col_names = month_col_name_linked)
      by <- c(by, month)
      names(by)[3] <- month_col_name_linked
    }
    linked_year_data <- self$get_columns_from_data(data_name = linked_data_name, col_names = year_col_name_linked)
    if (!missing(station) && !all(class(linked_station_data) == class(climdex_output[[station]]))) {
      if (is.numeric(linked_station_data)) climdex_output[[station]] <- as.numeric(climdex_output[[station]])
      else if (is.factor(linked_station_data)) climdex_output[[station]] <- make_factor(climdex_output[[station]])
      else if (is.character(linked_station_data)) climdex_output[[station]] <- as.character(climdex_output[[station]])
    }
    if (!all(class(linked_year_data) == class(climdex_output[[year]]))) {
      if (is.numeric(linked_year_data)) climdex_output[[year]] <- as.numeric(climdex_output[[year]])
      else if (is.factor(linked_year_data)) climdex_output[[year]] <- make_factor(climdex_output[[year]])
      else if (is.character(linked_year_data)) climdex_output[[year]] <- as.character(climdex_output[[year]])
    }
    if (freq == "monthly" && !all(class(linked_month_data) == class(climdex_output[[month]]))) {
      if (is.numeric(linked_month_data)) climdex_output[[month]] <- as.numeric(climdex_output[[month]])
      else if (is.factor(linked_month_data)) {
        lvs <- levels(linked_month_data)
        if (length(lvs) == 12) climdex_output[[year]] <- factor(climdex_output[[month]], labels = lvs)
        else {
          warning("month is a factor but does not have 12 levels. Output may not link correctly to data.")
          climdex_output[[month]] <- make_factor(climdex_output[[month]])
        }
      }
      else if (is.character(linked_month_data)) {
        mns <- unique(linked_month_data)
        # Also check English names as month.abb and month.name are locale dependent.
        if (length(mns) == 12) {
          if (setequal(mns, month.abb)) climdex_output[[month]] <- month.abb[climdex_output[[month]]]
          else if (setequal(mns, month.name)) climdex_output[[month]] <- month.name[climdex_output[[month]]]
          else if (setequal(mns, month_abb_english)) climdex_output[[month]] <- month_abb_english[climdex_output[[month]]]
          else if (setequal(mns, month_name_english)) climdex_output[[month]] <- month_name_english[climdex_output[[month]]]
          else if (setequal(mns, tolower(month_abb_english))) climdex_output[[month]] <- tolower(month_abb_english)[climdex_output[[month]]]
          else if (setequal(mns, tolower(month_name_english))) climdex_output[[month]] <- tolower(month_name_english)[climdex_output[[month]]]
          else if (setequal(mns, toupper(month_abb_english))) climdex_output[[month]] <- toupper(month_abb_english)[climdex_output[[month]]]
          else if (setequal(mns, toupper(month_name_english))) climdex_output[[month]] <- toupper(month_name_english)[climdex_output[[month]]]
          else warning("Cannot determine format of month column in data. Output may not link correctly to data.")
        } else {
          warning("month does not have 12 unique values. Output may not link correctly to data.")
          climdex_output[[month]] <- as.character(climdex_output[[month]])
        }
      }
    }
    # TODO could make this a try/catch and then if merging fails put data in new data frame
    self$merge_data(data_name = linked_data_name, new_data = climdex_output, by = by)
  }
}
)

DataBook$set("public", "is_metadata", function(data_name, str) {
  self$get_data_objects(data_name)$is_metadata(str = str)
}
)

DataBook$set("public", "get_climatic_column_name", function(data_name, col_name) {
  self$get_data_objects(data_name)$get_climatic_column_name(col_name = col_name)
}
)

DataBook$set("public", "merge_data", function(data_name, new_data, by = NULL, type = "left", match = "all") {
  self$get_data_objects(data_name)$merge_data(new_data = new_data, by = by, type = type, match = match)
}
)

DataBook$set("public", "get_corruption_data_names", function() {
  corruption_names <- c()
  for(curr_name in self$get_data_names()) {
    if(self$get_data_objects(curr_name)$is_metadata(corruption_data_label) && self$get_data_objects(curr_name)$get_metadata(corruption_data_label)) {
      corruption_names <- c(corruption_names, curr_name)
    }
  }
  return(corruption_names)
}
)

DataBook$set("public", "get_corruption_contract_data_names", function() {
  corruption_names <- c()
  for(curr_name in self$get_data_names()) {
    if(self$get_data_objects(curr_name)$is_metadata(corruption_data_label) && self$get_data_objects(curr_name)$get_metadata(corruption_data_label) == corruption_contract_level_label) {
      corruption_names <- c(corruption_names, curr_name)
    }
  }
  return(corruption_names)
}
)

DataBook$set("public", "get_database_variable_names", function(query, data_name, include_overall = TRUE, include, exclude, include_empty = FALSE, as_list = FALSE, excluded_items = c()) {
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

DataBook$set("public", "get_nc_variable_names", function(file = "", as_list = FALSE, ...) {
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

DataBook$set("public", "has_database_connection", function() {
  return(!is.null(self$get_database_connection()))
}
)

DataBook$set("public", "database_connect", function(dbname, user, host, port, drv = RMySQL::MySQL()) {
  #launches an input box prompt for entering password. 
  #done this way so that password characters are not displayed in the output window
  password <- getPass::getPass(paste0(user, " password:"))
  if(length(password) > 0){
    out <- DBI::dbConnect(drv = drv, dbname = dbname, user = user, password = password, host = host, port = port)
    if(!is.null(out)) {
      self$set_database_connection(out)
    }
  }
}
)

DataBook$set("public", "get_database_connection", function() {
  return(private$.database_connection)
}
)

DataBook$set("public", "set_database_connection", function(dbi_connection) {
  private$.database_connection <- dbi_connection
}
)

DataBook$set("public", "database_disconnect", function() {
  if(!is.null(self$get_database_connection())) {
    DBI::dbDisconnect(private$.database_connection)
    self$set_database_connection(NULL)
  }
}
)

DataBook$set("public", "import_from_climsoft", function(stationfiltercolumn = "stationId", stations = c(), elementfiltercolumn = "elementId", elements = c(), include_observation_data = FALSE, include_observation_flags = FALSE, unstack_data = FALSE, include_elements_info = FALSE, start_date = NULL, end_date = NULL) {
  #need to perform checks here
  con <- self$get_database_connection()
  
  #get stations database data and station ids values
  if (length(stations) > 0) {
    #construct a string of station values from the passed station vector eg of result ('191','122')
    passed_station_values <- paste0("(", paste0("'", stations, "'", collapse =  ", "), ")")
    
    #get the station info of the passed station values
    db_station_info <- DBI::dbGetQuery(con, paste0( "SELECT * FROM station WHERE ", stationfiltercolumn, " IN ", passed_station_values,  ";"))
    
    #set values of station ids only
    if (stationfiltercolumn == "stationId") {
      station_ids_values <- passed_station_values
    } else{
      station_ids_values <- paste0("(", paste0("'", db_station_info$stationId, "'", collapse = ", "),")")
    }
  }
  
  #if true get observation data
  if (include_observation_data) {
    #if there are no elements passed then stop and throw error
    if (length(elements) < 1) stop("start_date must be of type Date.")
    
    #set values of element ids only
    if (elementfiltercolumn == "elementId") {
      #get element id values directly from passed data
      element_ids_values <- paste0("(", paste0(elements, collapse = ", "), ")")
    } else{
      #get element id values from the database
      passed_element_values <- paste0("(", paste0("'", elements, "'", collapse = ", "), ")")
      db_elements_ids <- DBI::dbGetQuery( con, paste0("SELECT elementId FROM obselement WHERE ", elementfiltercolumn,  " IN ",  passed_element_values, ";" ))
      element_ids_values <- paste0("(", paste0(sprintf("%d", db_elements_ids$elementId), collapse = ", "), ")")
    }
    
    if(include_elements_info) {
      db_elements_info <- DBI::dbGetQuery(con, paste0("SELECT elementId, elementName, abbreviation, description, elementtype, upperLimit, lowerLimit, units FROM obselement WHERE elementId ", " IN ", element_ids_values, ";" ))
    }
    
    flags_column_col_sql <- " "
    if (include_observation_flags) {
      flags_column_col_sql <- ", observationfinal.flag AS flag"
    }
    
    #get databounds filter query if dates have been passed
    date_bounds_filter <- ""
    if (!is.null(start_date)) {
      if (!lubridate::is.Date(start_date))
        stop("start_date must be of type Date.")
      start_date <- format(start_date, format = "%Y-%m-%d")
      date_bounds_filter = paste0(date_bounds_filter, " AND obsDatetime >= ", sQuote(start_date))
    }
    if (!is.null(end_date)) {
      if (!lubridate::is.Date(end_date))
        stop("end_date must be of type Date.")
      end_date <- format(end_date, format = "%Y-%m-%d")
      date_bounds_filter <- paste0(date_bounds_filter," AND obsDatetime <=", sQuote(end_date))
    }
    
    #construct observation data sql query and get data from database
    if (length(stations) > 0) {
      #if stations passed get observation data of selected elements of passed stations
      db_observation_data <- DBI::dbGetQuery(con, paste0("SELECT observationfinal.recordedFrom As station, obselement.abbreviation AS element, observationfinal.obsDatetime AS datetime, observationfinal.obsValue AS obsvalue", flags_column_col_sql, " FROM observationfinal INNER JOIN obselement ON observationfinal.describedBy = obselement.elementId WHERE observationfinal.recordedFrom IN ", station_ids_values, " AND observationfinal.describedBy IN ", element_ids_values, date_bounds_filter, " ORDER BY observationfinal.recordedFrom, observationfinal.describedBy;"))
    } else{
      #if stations have not been passed get observation data of passed elements of all stations
      db_observation_data <- DBI::dbGetQuery(con, paste0("SELECT observationfinal.recordedFrom As station, obselement.abbreviation AS element, observationfinal.obsDatetime AS datetime, observationfinal.obsValue AS obsvalue", flags_column_col_sql, " FROM observationfinal INNER JOIN obselement ON observationfinal.describedBy = obselement.elementId WHERE observationfinal.describedBy IN ", element_ids_values, date_bounds_filter, " ORDER BY observationfinal.recordedFrom, observationfinal.describedBy;"))
      
      #then get the stations ids (uniquely) from the observation data and use the ids to get station info
      station_ids_values <- paste0("(", paste0("'", as.character(unique(db_observation_data$station) ), "'", collapse = ", "), ")")
      db_station_info <- DBI::dbGetQuery(con, paste0("SELECT * FROM station WHERE stationId IN ", station_ids_values, ";" ))
    }
    
    station_data_name <- next_default_item("stations_info", self$get_data_names(), include_index = FALSE)
    elements_data_name <- next_default_item("elements_info", self$get_data_names(), include_index = FALSE)
    observation_data_name <- next_default_item("observation_data", self$get_data_names(), include_index = FALSE)
    
    #elements info could be optional
    if (include_elements_info) {
      data_list <- list(db_station_info, db_elements_info, db_observation_data)
      names(data_list) <- c(station_data_name, elements_data_name, observation_data_name)
    } else{
      data_list <- list(db_station_info, db_observation_data)
      names(data_list) <- c(station_data_name, observation_data_name)
    }
    
  } else{
    if (length(stations) > 0) {
      data_list <- list(db_station_info)
      names(data_list) <- next_default_item("stations_info", self$get_data_names())
    }
  }
  
  #import the data as separate data frames
  self$import_data(data_tables = data_list)
  
  #if observation data was included, and key links, convert columns and optionally unstack data
  if (include_observation_data) {
    #add relationship key between the observation data and station data 
    #linked by stationId and recordedFrom columns
    self$add_key(station_data_name, c("stationId"))
    self$add_link(from_data_frame = observation_data_name, to_data_frame = station_data_name, link_pairs = c(recordedFrom = "stationId"), type = keyed_link_label)
    
    #convert stations in observation data to factors
    self$convert_column_to_type(data_name = observation_data_name, col_names = "station", to_type = "factor")
    #convert elements in observation data to factors
    self$convert_column_to_type(data_name = observation_data_name, col_names = "element", to_type = "factor")
    #convert flags to factors if included
    if(include_observation_flags){
      self$convert_column_to_type(data_name = observation_data_name, col_names = "flag", to_type = "factor")
    }
    #create a plain date column from the observation data datetime column values
    obsdate <- self$get_columns_from_data(data_name = observation_data_name, col_names = "datetime", use_current_filter = FALSE)
    self$add_columns_to_data(data_name = observation_data_name, col_name = "date", col_data = as.Date(x = obsdate), before = FALSE, adjacent_column = "datetime")
    
    if(unstack_data){
      observation_data <- self$get_data_frame(data_name = observation_data_name)
      observation_data_unstacked <- reshape2::dcast(data = observation_data, formula = station + datetime + date ~ element, value.var = "obsvalue")
      self$import_data(data_tables = list(observation_data_unstacked = observation_data_unstacked))
    }
  }

})

DataBook$set("public", "import_from_iri", function(download_from, data_file, data_frame_name, location_data_name, path, X1, X2 = NA, Y1, Y2 = NA, get_area_point = "area"){
  
  data_list <- import_from_iri(download_from  = download_from, data_file = data_file, path = path, X1 = X1, X2 = X2, Y1 = Y1, Y2 = Y2, get_area_point = get_area_point)
  names(data_list) = c(next_default_item(prefix = data_frame_name , existing_names = self$get_data_names(), include_index = FALSE), next_default_item(prefix = location_data_name , existing_names = self$get_data_names(), include_index = FALSE))
  self$import_data(data_tables = data_list)
  loc_col_names <- names(data_list[[2]])
  self$add_key(location_data_name, loc_col_names)
  names(loc_col_names) <- loc_col_names
  self$add_link(from_data_frame = names(data_list)[1], to_data_frame = names(data_list)[2], link_pairs = loc_col_names, type = keyed_link_label)
} 
)

DataBook$set("public", "export_workspace", function(data_names, file, include_graphs = TRUE, include_models = TRUE, include_metadata = TRUE) {
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

DataBook$set("public", "set_links", function(new_links) {
  private$.links <- new_links
} 
)

DataBook$set("public","display_daily_graph", function(data_name, date_col = NULL, station_col = NULL, year_col = NULL, doy_col = NULL, climatic_element = NULL, upper_limit = 100, bar_colour = "blue", rug_colour = "red") {
  self$get_data_objects(data_name)$display_daily_graph(date_col = date_col,station_col = station_col, year_col = year_col, doy_col = doy_col, climatic_element = climatic_element, rug_colour = rug_colour, bar_colour = bar_colour, upper_limit = upper_limit)
}
)

DataBook$set("public","create_variable_set", function(data_name, set_name, columns) {
  self$get_data_objects(data_name)$create_variable_set(set_name = set_name, columns = columns)
}
)

DataBook$set("public","update_variable_set", function(data_name, set_name, columns, new_set_name) {
  self$get_data_objects(data_name)$update_variable_set(set_name = set_name, columns = columns, new_set_name = new_set_name)
}
)

DataBook$set("public","delete_variable_sets", function(data_name, set_names) {
  self$get_data_objects(data_name)$delete_variable_sets(set_names = set_names)
}
)

DataBook$set("public","get_variable_sets_names", function(data_name, include_overall = TRUE, include, exclude, include_empty = FALSE, as_list = FALSE, excluded_items = c()) {
  self$get_data_objects(data_name)$get_variable_sets_names(include_overall = include_overall, include = include, exclude = exclude, include_empty = include_empty, as_list = as_list, excluded_items = excluded_items)
}
)

DataBook$set("public","get_variable_sets", function(data_name, set_names, force_as_list = FALSE) {
  self$get_data_objects(data_name)$get_variable_sets(set_names = set_names, force_as_list = force_as_list)
}
)

DataBook$set("public", "crops_definitions", function(data_name, year, station, rain, day, rain_totals, plant_days, plant_lengths, start_check = TRUE, season_data_name, start_day, end_day, definition_props = TRUE, print_table = TRUE) {
  plant_day_name <- "plant_day"
  plant_length_name <- "plant_length"
  rain_total_name <- "rain_total"
  
  is_station <- !missing(station)
  
  if(missing(year)) stop("Year column must be specified.")
  if(!is_station) by <- year
  else by <- c(year, station)
  if(missing(season_data_name)) season_data_name <- data_name
  if(season_data_name != data_name) {
    season_by <- self$get_equivalent_columns(from_data_name = data_name, columns = by, to_data_name = season_data_name)
    if(is.null(season_by)) stop("The data frames specified must be linked by the year/station columns.")
  }
  year_col <- self$get_columns_from_data(data_name, year)
  unique_year <- na.omit(unique(year_col))
  
  expand_list <- list()
  names_list <- c()
  
  expand_list[[length(expand_list) + 1]] <- rain_totals
  names_list[length(names_list) + 1] <- rain_total_name
  
  expand_list[[length(expand_list) + 1]] <- plant_lengths
  names_list[length(names_list) + 1] <- plant_length_name
  
  expand_list[[length(expand_list) + 1]] <- plant_days
  names_list[length(names_list) + 1] <- plant_day_name
  
  expand_list[[length(expand_list) + 1]] <- unique_year
  names_list[length(names_list) + 1] <- year
  
  if(is_station) {
    station_col <- self$get_columns_from_data(data_name, station)
    unique_station <- na.omit(unique(station_col))
    expand_list[[length(expand_list) + 1]] <- unique_station
    names_list[length(names_list) + 1] <- station
  }
  df <- setNames(expand.grid(expand_list), names_list)
  daily_data <- self$get_data_frame(data_name)
  if(season_data_name != data_name) {
    join_by <- by
    names(join_by) <- season_by
    season_data <- self$get_data_frame(season_data_name)
    vars <- c(season_by, start_day, end_day)
    season_data <- season_data %>% dplyr::select(!!! rlang::syms(vars))
    df <- dplyr::left_join(df, season_data, by = join_by)
  }
  else {
    col_names <- c(by, start_day, end_day)
    season_data <- daily_data %>% 
      dplyr::select(!!! rlang::syms(col_names)) %>%
      dplyr::group_by(!!! rlang::syms(by)) %>%
      dplyr::summarise(!! rlang::sym(start_day) := dplyr::first(!! rlang::sym(start_day)),
                       !! rlang::sym(end_day) := dplyr::first(!! rlang::sym(end_day)))
    df <- dplyr::left_join(df, season_data, by = by)
  }
  
  # Plant day condition
  if(start_check) {
    df$plant_day_cond <- (df[[start_day]] <= df[[plant_day_name]])
  }
  
  # Plant length condition
  df$length_cond <- (df[[plant_day_name]] + df[[plant_length_name]] <= df[[end_day]])
  
  # Rain total condition
  df[["rain_total_actual"]] <- sapply(1:nrow(df), 
                                      function(x) {
                                        ind <- daily_data[[year]] == df[[year]][x] & daily_data[[day]] >= df[[plant_day_name]][x] & 
                                          daily_data[[day]] < (df[[plant_day_name]][x] + df[[plant_length_name]][x])
                                        if(is_station) ind <- ind & (daily_data[[station]] == df[[station]][x])
                                        rain_values <- daily_data[[rain]][ind]
                                        sum_rain <- sum(rain_values, na.rm = TRUE)
                                        # TODO + 1 is needed because of non leap years
                                        # if period include 29 Feb then period is 1 less than required length
                                        if(length(rain_values) + 1 < df[[plant_length_name]][x] || (anyNA(rain_values) && sum_rain < df[[rain_total_name]][x])) sum_rain <- NA
                                        sum_rain
                                      }
  )
  df$rain_cond <- df[[rain_total_name]] <= df[["rain_total_actual"]]
  
  # All three conditions met
  df$overall_cond <- ((if(start_check) df$plant_day_cond else TRUE) & df$length_cond & df$rain_cond)
  
  crops_name <- "crop_def"
  crops_name <- next_default_item(prefix = crops_name, existing_names = self$get_data_names(), include_index = FALSE)
  data_tables <- list(df)
  names(data_tables) <- crops_name
  self$import_data(data_tables = data_tables)
  if(season_data_name != data_name) {
    crops_by <- season_by
    names(crops_by) <- by
    self$add_link(crops_name, season_data_name, crops_by, keyed_link_label)
  }
  if(definition_props) {
    calc_from <- list()
    if(!missing(station)) calc_from[[length(calc_from) + 1]] <- station
    calc_from[[length(calc_from) + 1]] <- plant_day_name
    calc_from[[length(calc_from) + 1]] <- plant_length_name
    calc_from[[length(calc_from) + 1]] <- rain_total_name
    names(calc_from) <- rep(crops_name, length(calc_from))
    grouping <- instat_calculation$new(type = "by", calculated_from = calc_from)
    prop_calc_from <- list("overall_cond")
    names(prop_calc_from) <- crops_name
    propor_table <- instat_calculation$new(function_exp="sum(overall_cond, na.rm = TRUE)/length(na.omit(overall_cond))",
                                           save = 2, calculated_from = prop_calc_from,
                                           manipulations = list(grouping),
                                           type="summary", result_name = "prop_success", result_data_frame = "crop_prop")
    prop_data_frame <- self$run_instat_calculation(propor_table, display = TRUE)
    if(print_table) {
      prop_data_frame$prop_success <- round(prop_data_frame$prop_success, 2)
      prop_table_unstacked <- reshape2::dcast(formula = as.formula(paste(if(!missing(station)) paste(station, "+"), plant_length_name, "+", rain_total_name, "~", plant_day_name)), data = prop_data_frame, value.var = "prop_success")
      if(!missing(station)) f <- interaction(prop_table_unstacked[[station]], prop_table_unstacked[[plant_length_name]], lex.order = TRUE)
      else f <- prop_table_unstacked[[plant_length_name]]
      prop_table_split <- split(prop_table_unstacked, f)
      return(prop_table_split)
    }
  }
}
)

#' Converting grid (wide) format daily climatic data into tidy (long format) data
#' @param x Input data frame
#' @param format Either "years", "months" or "days" to indicate what the stacking columns represent
#' @param day the name of the column containing day of month values (if format != "days")
#' @param month the name of the column containing month values (if format != "months")
#' @param year the name of the column containing year values (required if format != "years")
#' @param stack_years when format = "years" stack_years specifies the years. Must be same length as stack_cols
#' If not specified, the function will try to determine the years using the format "Xyyyy" where "X" is any character and "yyyy" is the year.
#' @param stack_cols a character vector of columns to stack
#' if format == "days" 31 columns (in order) for each day of the month are expected, or 62 with alternate value/flag columns
#' if format == "months" 12 columns (in order) for each month are expected
#' if format == "years" any number of year columns can be given. These should be named with format "Xyyyy"
#' where "X" is any character and "yyyy" is the year
#' @param station (optional) when format = "days" or "months" the name of a station column can be given
#' when the data is for multiple stations
#' @param element (optional) when format = "days" or "months" the name of an element column can be given
#' when the data is for multiple elements
#' @param element_name (optional) if data is for single element, element_name is the name of the column containing
#' the values. Default is "value". Ignored if element not missing.
#' @param ignore_invalid If TRUE, rows with non missing element values on invalid dates e.g. 31 Sep or 29 Feb in non leap years, will be removed.
#' If FALSE (the default) an error will be given with details of where the values occur.
#' Strongly recommended to first run with FALSE and then TRUE after examining or correcting any issues.
#' @param silent If TRUE, detailed output, such as rows with non missing element values on invalid dates or duplicate values will be suppressed.
#' @param unstack_elements If TRUE, when there are multiple elements there will be one column for each element (unstacked), otherwise there will be an element
#' column and a value column. This also applies to flag columns if included.
#' @param new_name Name for the new data frame.
#' @export
#' @examples
#' yearcols <- data.frame(month = rep(1:12, times = c(31,29,31,30,31,30,31,31,30,31,30,31)),
#' day = c(1:31,1:29,1:31,1:30,1:31,1:30,1:31,1:31,1:30,1:31,1:30,1:31),
#' X2000 = rnorm(366), X2001 = rnorm(366), X2002 = rnorm(366), X2003 = rnorm(366))
#' yearcols[60,4:6] <- NA
#' tidy_climatic_data(x = yearcols, format = "years", stack_cols = c("X2000", "X2001", "X2002", "X2003"), element_name = "tmin")

DataBook$set("public","tidy_climatic_data", function(x, format, stack_cols, day, month, year, stack_years, station, element, element_name = "value", ignore_invalid = FALSE, silent = FALSE, unstack_elements = TRUE, new_name) {
  
  if(!format %in% c("days", "months", "years")) stop("format must be either 'days', 'months' or 'years'")
  if(!all(stack_cols %in% names(x))) stop("Some of the stack_cols were not found in x.")
  if(!missing(day) && !day %in% names(x)) stop("day column not found in x.")
  if(!missing(month) && !month %in% names(x)) stop("month column not found in x.")
  if(!missing(year) && !year %in% names(x)) stop("year column not found in x.")
  if(!missing(station) && !station %in% names(x)) stop("station column not found in x.")
  if(!missing(element) && !element %in% names(x)) stop("element column not found in x.")
  # Default to FALSE and updated if format == "days"
  flags <- FALSE
  
  # check day column is valid (if specified)
  if(!missing(day)) {
    day_data <- x[[day]]
    if(anyNA(day_data)) stop("day column contains: ", sum(is.na(day_data)), " missing values")
    if(!is.numeric(day_data)) stop("day column must be numeric")
    invalid_day <- (day_data < 1 | day_data > 31 | (day_data %% 1) != 0)
    if(any(invalid_day)) {
      invalid_values <- unique(day_data[invalid_day])
      stop("day column contains the following invalid values: ", paste(invalid_values, collapse = ",")) 
    }
  }
  
  # check month column is valid (if specified)
  if(!missing(month)) {
    month_data <- x[[month]]
    # Initialise no month format
    month_format <- ""
    if(anyNA(month_data)) stop("month column contains: ", sum(is.na(month_data)), " missing values")
    if(is.numeric(month_data)) {
      invalid_month <- (month_data < 1 | month_data > 12 | (month_data %% 1) != 0)
      if(any(invalid_month)) {
        invalid_values <- unique(month_data[invalid_month])
        stop("month column contains the following invalid values: ", paste(invalid_values, collapse = ",")) 
      }
      # Month format will be used in as.Date()
      month_format <- "%m"
    }
    # This case is for numeric months but stored as character e.g. c("1", "2")
    else if(all(!is.na(as.numeric(month_data)))) {
      if(all(as.numeric(month_data) %in% 1:12)) {
        month_format <- "%m"
        # This ensures format is correct and removes any spaces etc. e.g. "1 " -> 1
        x[[month]] <- as.numeric(month_data)
      }
    }
    else {
      # Convert to title case to match month.name and month.abb
      month_data_title <- stringr::str_to_title(month_data)
      if(all(month_data_title %in% month.abb)) month_format <- "%b"
      else if(all(month_data_title %in% month.name)) month_format <- "%B"
      if(month_format == "") {
        invalid_short <- unique(month_data[!month_data_title %in% month.abb])
        invalid_long <- unique(month_data[!month_data_title %in% month.name])
        if(length(invalid_short) < 12) {
          stop("Some month values were not unrecognised.\nIf specifying short names the following are invalid: ", paste(invalid_short, collapse = ", "), "\nAlternatively use a numeric month column.")
        }
        else if(length(invalid_long) < 12) {
          stop("Some month values were not unrecognised.\nIf specifying full names the following are invalid: ", paste(invalid_long, collapse = ", "), "\nAlternatively use a numeric month column.")
        }
        else stop("No values in the month column were recognised.\nUse either\n short names: ", paste(month.abb, collapse = ", "), "\nfull names: ", paste(month.name, collapse = ", "), "\nor numbers 1 to 12.")
      }
      # Put title case months into the data as this will be needed to make the date column
      x[[month]] <- month_data_title 
    }
  }
  
  # check year column is valid (if specified)
  if(!missing(year)) {
    year_data <- x[[year]]
    if(anyNA(year_data)) stop("year column contains: ", sum(is.na(year_data)), " missing values")
    year_format <- ""
    if(!is.numeric(year_data)) {
      if(all(!is.na(as.numeric(year_data)))) {
        x[[year]] <- as.numeric(year_data)
        year_data <- x[[year]]
      }
      else stop("Cannot recognise years from year column. Try using a numeric year column.")
    }
    if(all(stringr::str_length(year_data) == 4)) year_format <- "%Y"
    else if(all(stringr::str_length(year_data) == 2)) year_format <- "%y"
    else stop("Inconsistent values found in year column. Year column must be column of four digit years or column of two digit years")
  }
  
  if(format == "days") {
    ndays <- 31
    # month column required in this case
    if(missing(month)) stop("month column is required when format == 'days'")
    
    # year column required in this case
    if(missing(year)) stop("year column is required when format == 'days'")
    
    # stack column checks
    if(length(stack_cols) != ndays && length(stack_cols) != 2 * ndays) stop("You have specified: ", length(stack_cols), " stack columns\nThere must be exactly ", ndays, " or ", 2 * ndays, " stack columns when format == 'days'")
    
    # TRUE if flag columns are included
    flags <- length(stack_cols) == 2 * ndays
    if(flags) {
      # We assume that value/flag columns alternate and are in correct order i.e. c(value1, flag1, value2, flag2, ..., value31, flag31)
      val_col_names <- stack_cols[seq(1, 2 * ndays - 1, 2)]
      flag_col_names <- stack_cols[seq(2, 2 * ndays, 2)]
      # TODO This should be a more global function
      if(!all(sapply(x[, val_col_names], function(col) is.numeric(col) || (is.logical(col) && all(is.na(col)))))) stop("Every other column must be numeric to represent values (starting with the first columns). \nThe following value columns are not numeric: ", paste(stack_cols[!sapply(x[, val_col_names], is.numeric)], collapse = ","))
      # Name of flag column
      flag_name <- "flag"
    }
    else {
      if(!all(sapply(x[, stack_cols], function(col) is.numeric(col) || (is.logical(col) && all(is.na(col)))))) stop("All stack_cols must be numeric\nThe following stack_cols are not numeric: ", paste(stack_cols[!sapply(x[, stack_cols], is.numeric)], collapse = ","))
    }
    
    # This ensures all other columns are dropped
    y <- data.frame(year = x[[year]], month = x[[month]], x[ , stack_cols])
    if(!missing(station)) y$station <- x[[station]]
    if(!missing(element)) y$element <- x[[element]]
    # In case element_name is the name of an existing column in y
    if(element_name %in% names(y)) element_name <- next_default_item(prefix = element_name, existing_names = names(y))
    if(flags) {
      # renaming the stack_cols with a consistent pattern makes it possible for pivot_longer to stack both sets of columns together and construct the day column correctly
      # This assumes stack_cols are in the correct order i.e. c(value1, flag1, value2, flag2, ..., value31, flag31)
      new_stack_cols <- paste(c("value", "flag"), rep(1:ndays, each = 2), sep = "_")
      names(y)[names(y) %in% stack_cols] <- new_stack_cols
      # ".value" is a special sentinel used in names_to to ensure names of value columns come from the names of cols. See ?pivot_longer values_to section for details.
      y <- tidyr::pivot_longer(y, cols = tidyselect::all_of(new_stack_cols), names_to = c(".value", "day"), names_sep = "_")
    }
    else {
      # renaming the stack_cols so that the day column can be constructed correctly
      # This assumes stack_cols are in the correct order i.e. 1 - 31
      new_stack_cols <- paste0("day", 1:ndays)
      names(y)[names(y) %in% stack_cols] <- new_stack_cols
      y <- tidyr::pivot_longer(y, cols = tidyselect::all_of(new_stack_cols), names_to = "day", values_to = element_name)
      # extract day number from e.g. "day10"
      y$day <- substr(y$day, 4, 5)
    }
    
    y$date <- as.Date(paste(y$year, y$month, y$day), format = paste(year_format, month_format, "%d"))
  }
  else if(format == "months") {
    if(!all(sapply(x[, stack_cols], function(col) is.numeric(col) || (is.logical(col) && all(is.na(col)))))) stop("All stack_cols must be numeric\nThe following stack_cols are not numeric: ", paste(stack_cols[!sapply(x[, stack_cols], is.numeric)], collapse = ","))
    
    # month column required in this case
    if(missing(day)) stop("day column is required when format == 'months'")
    
    # year column required in this case
    if(missing(year)) stop("year column is required when format == 'months'")
    
    # stack column checks
    if(length(stack_cols) != 12) stop("You have specified: ", length(stack_cols), " stack columns\nThere must be exactly 12 stack columns when format == 'months'")
    
    # This ensures all other columns are dropped
    y <- data.frame(year = x[[year]], day = x[[day]], x[ , stack_cols])
    if(!missing(station)) y$station <- x[[station]]
    if(!missing(element)) y$element <- x[[element]]
    # In case element_name is the name of an existing column in y
    if(element_name %in% names(y)) element_name <- next_default_item(prefix = element_name, existing_names = names(y))
    # renaming the stack_cols so that the day column can be constructed correctly
    # This assumes stack_cols are in the correct order i.e. 1 - 12
    new_stack_cols <- paste0("month", 1:12)
    names(y)[names(y) %in% stack_cols] <- new_stack_cols
    y <- tidyr::pivot_longer(y, cols = tidyselect::all_of(new_stack_cols), names_to = "month", values_to = element_name)
    # extract month number from e.g. "month10"
    y$month <- substr(y$month, 6, 7)
    
    y$date <- as.Date(paste(y$year, y$month, y$day), format = paste(year_format, "%m", "%d"))
  }
  else if(format == "years") {
    if(!all(sapply(x[, stack_cols], function(col) is.numeric(col) || (is.logical(col) && all(is.na(col)))))) stop("All stack_cols must be numeric\nThe following stack_cols are not numeric: ", paste(stack_cols[!sapply(x[, stack_cols], is.numeric)], collapse = ","))
    
    by_cols <- c()
    if(!missing(station)) by_cols <- c(by_cols, station)
    if(!missing(element)) by_cols <- c(by_cols, element)
    
    if(length(by_cols) > 0) {
      group_lengths <- x %>% dplyr::group_by(!!! rlang::syms(by_cols)) %>% dplyr::summarise(n = n())
      if(any(group_lengths$n != 366)) stop("data must have exactly 366 rows per station per element when format = 'years'")
    }
    else if(nrow(x) != 366) stop("data must have exactly 366 rows for a single station and element when format = 'years'")
    
    if(!missing(stack_years) && length(year_list) != length(stack_cols)) stop("stack_years must be the same length as stack_cols")
    
    # stack_years allows to specify the years represented by stack_cols.
    # If this is blank, attempt to infer stack_years by assuming stack_cols are in the format c("X1990", "X1991", ...)
    if(missing(stack_years)) {
      # Remove first character and convert to numeric
      stack_years <- as.numeric(stringr::str_sub(stack_cols, 2))
      invalid_ind <- is.na(stack_years) | stringr::str_length(stack_years) != 4
      if(any(invalid_ind)) {
        cat("Unrecognised year columns:", paste(stack_years[invalid_ind], collapse = ", "))
        stop("Cannot determine year of some columns. Year columns must be named with format 'Xyyyy' where X is any character and yyyy is the year.")
      }
    }
    x$doy <- 1:366
    # This ensures all other columns are dropped
    y <- data.frame(doy = x$doy, x[ , stack_cols])
    if(!missing(station)) y$station <- x[[station]]
    if(!missing(element)) y$element <- x[[element]]
    # In case element_name is the name of an existing column in y
    if(element_name %in% names(y)) element_name <- next_default_item(prefix = element_name, existing_names = names(y))
    y <- tidyr::pivot_longer(y, cols = tidyselect::all_of(stack_cols), names_to = "year", values_to = element_name)
    
    # This assumes stack_cols and stack_years are in the same order
    y$year <- plyr::mapvalues(y$year, stack_cols, stack_years)
    
    # Replacing day 60 with 0 for non-leap years. This will result in NA dates.
    y$doy[(!lubridate::leap_year(as.numeric(y$year))) & y$doy == 60] <- 0
    y$doy[(!lubridate::leap_year(as.numeric(y$year))) & y$doy > 60] <- y$doy[(!lubridate::leap_year(as.numeric(y$year))) & y$doy > 60] - 1
    y$date <- as.Date(paste(y$year, y$doy), format = paste("%Y", "%j"))
    # Put day 0 back as 60. Needed in error displaying only.
    y$doy[y$doy == 0] <- 60
  }
  
  continue <- TRUE
  # check if there are any non missing values on missing dates
  # this is a problem as missing dates are invalid dates so should not have values
  invalid_ind <- is.na(y$date) & !is.na(y[[element_name]])
  if(sum(invalid_ind) > 0) {
    cat("There are:", sum(invalid_ind), "measurement values on invalid dates.\n")
    if(!silent) {
      cat("\n*** Invalid dates ***\n\n")
      invalid_data <- dplyr::filter(y, invalid_ind)
      if(format == "days" || format == "months") {
        invalid_data_display <- invalid_data %>% dplyr::select(year, month, day)
      }
      else {
        invalid_data_display <- invalid_data %>% dplyr::select(year, doy)
      }
      # Also make a data.frame (instead of tibble) so that display will show all rows.
      if(!missing(station)) {
        invalid_data_display <- data.frame(station = invalid_data$station, invalid_data_display)
      }
      if(!missing(element)) {
        invalid_data_display <- data.frame(element = invalid_data$element, invalid_data_display)
      }
      invalid_data_display <- data.frame(invalid_data_display)
      invalid_data_display[[element_name]] <- invalid_data[[element_name]]
      print(invalid_data_display, row.names = FALSE)
    }
    if(ignore_invalid) cat("Warning: These rows have been removed.\n")
    else {
      # This should be a stop but then detailed output can't be displayed by R-Instat
      cat("There are:", sum(invalid_ind), "measurement values on invalid dates. Correct these or specify ignore_invalid = TRUE to ignore them. See output for more details.\n")
      continue <- FALSE
    }
  }
  
  # This should have been a stop above but then detailed output can't be displayed by R-Instat
  if(!continue) return()
  
  # Standard format of slowest varying structure variables first (station then element then date) followed by measurements
  if(!missing(station)) z <- data.frame(station = forcats::as_factor(y$station), date = y$date)
  else z <- data.frame(date = y$date)
  if(!missing(element)) z$element <- y$element
  z[[element_name]] <- y[[element_name]]
  if(flags) z[[flag_name]] <- y[[flag_name]]
  
  # Initialise id columns used for sorting data
  id_cols <- c()
  if(!missing(station)) id_cols <- c(id_cols, "station")
  
  z <- dplyr::filter(z, !is.na(date))
  
  # If data contains multiple elements, optionally unstack the element column
  if(!missing(element)) {
    if(unstack_elements) {
      # pivot_wider allows unstacking multiple column sets, used when flags included.
      values_from <- c(element_name)
      if(flags) values_from <- c(values_from, flag_name)
      # first check for unique combinations to ensure no duplicates
      z_dup <- duplicated(z %>% dplyr::select(-tidyselect::all_of(values_from)))
      if(any(z_dup > 0)) {
        # This should be a stop but then detailed output can't be displayed by R-Instat
        cat("\nError: Cannot tidy data as some elements have multiple values on the same date. Check and resolve duplicates first.\n")
        z_check <- z %>% filter(z_dup > 0)
        if(!silent) {
          cat("\n*** Duplicates ***\n\n")
          print(z_check, row.names = FALSE)
        }
        continue <- FALSE
      }
      else z <- tidyr::pivot_wider(z, names_from = element, values_from = tidyselect::all_of(values_from))
    }
    # If not unstacking then need to sort by element column
    else id_cols <- c(id_cols, "element")
  }
  
  # This should have been a stop above but then detailed output can't be displayed by R-Instat
  if(!continue) return()
  
  # Add this last to ensure date varies fastest
  id_cols <- c(id_cols, "date")
  # TODO Find a better way to do this. Update if there could be more the 3 id cols.
  if(length(id_cols) == 1) {
    z <- z %>% dplyr::arrange(.data[[id_cols[1]]])
  }
  else if(length(id_cols) == 2) {
    z <- z %>% dplyr::arrange(.data[[id_cols[1]]], .data[[id_cols[2]]])
  }
  else if(length(id_cols) == 3) {
    z <- z %>% dplyr::arrange(.data[[id_cols[1]]], .data[[id_cols[2]]], .data[[id_cols[3]]])
  }
  if(missing(new_name) || new_name == "") new_name <- next_default_item("data", existing_names = self$get_data_names())
  data_list <- list(z)
  names(data_list) <- new_name
  self$import_data(data_tables=data_list)
}
)

DataBook$set("public","get_geometry", function(data) {
  if(missing(data)) stop("data_name is required")
  else if("sf" %in% class(data)) return(attr(data, "sf_column"))
  else if("geometry" %in% colnames(data)) return("geometry")
  else return("")
}
)
DataBook$set("public","package_check", function(package) {
  out <- list()
  av_packs <- available.packages()
  av_packs <- data.frame(av_packs)
  if(package %in% rownames(installed.packages())) {
    out[[1]] <- 1
    v_machine <- as.character(packageVersion(package))
    v_web <- as.character(av_packs[av_packs$Package == package, "Version"])
    out[[2]] <- compareVersion(v_machine, v_web)
    out[[3]] <- v_machine
    out[[4]] <- v_web
    return(out)
  }
  else {
    #check if the package name is typed right
    if(package %in% av_packs) {
      out[[1]] <- 2
      return(out)
    }
    else {
      #wrong  spelling check you spelling
      out[[1]] <- 0
      return(out)
    }
  }
}
)

DataBook$set("public", "download_from_IRI", function(source, data, path = tempdir(), min_lon, max_lon, min_lat, max_lat, min_date, max_date, name, download_type = "Point", import = TRUE) {
  init_URL <- "https://iridl.ldeo.columbia.edu/SOURCES/"
  dim_x <- "X"
  dim_y <- "Y"
  dim_t <- "T"
  if (source == "UCSB_CHIRPS") {
    prexyaddress <- paste0(init_URL, ".UCSB/.CHIRPS/.v2p0")
    if (data == "daily_improved_global_0p25_prcp") {
      extension <- ".daily-improved/.global/.0p25/.prcp"
    } # 1 Jan 1981 to 31 Jul 2020
    else if (data == "daily_improved_global_0p05_prcp") {
      extension <- ".daily-improved/.global/.0p05/.prcp"
    } # 1 Jan 1981 to 31 Jul 2020
    else if (data == "dekad_prcp") {
      extension <- ".dekad/.prcp"
    } # (days since 1960-01-01) ordered [ (1-10 Jan 1981) (11-20 Jan 1981) (21-31 Jan 1981) ... (21-31 Aug 2020)]
    else if (data == "monthly_global_prcp") {
      extension <- ".monthly/.global/.precipitation"
    } # grid: /T (months since 1960-01-01) ordered (Jan 1981) to (Jul 2020) by 1.0 N= 475 pts :grid
    else {
      stop("Data file does not exist for CHIRPS V2P0 data")
    }
  } else if (source == "TAMSAT_v3.0") {
    dim_x <- "lon"
    dim_y <- "lat"
    prexyaddress <- paste0(init_URL, ".Reading/.Meteorology/.TAMSAT/.TARCAT/.v3p0")
    if (data == "daily_rfe") {
      dim_t <- "time"
      extension <- ".daily/.rfe"
    } # grid: /time (julian_day) ordered (1 Jan 1983) to (10 Sep 2020) by 1.0 N= 13768 pts :grid
    else if (data == "dekadal_rfe") {
      extension <- ".dekadal/.rfe"
    } # grid: /T (days since 1960-01-01) ordered [ (1-10 Jan 1983) (11-20 Jan 1983) (21-31 Jan 1983) ... (1-10 Sep 2020)] N= 1357 pts :grid
    else if (data == "monthly_rfe") {
      dim_t <- "time"
      extension <- ".monthly/.rfe"
    } # grid: /time (months since 1960-01-01) ordered (Jan 1983) to (Aug 2020) by 1.0 N= 452 pts :grid
    else if (data == "monthly_rfe_calc") {
      dim_t <- "time"
      extension <- ".monthly/.rfe_calc"
    } # grid: /time (months since 1960-01-01) ordered (Feb 1983) to (Sep 2020) by 1.0 N= 452 pts :grid
    else {
      stop("Data file does not exist for TAMSAT_v3.0 data")
    }
  } else if (source == "TAMSAT_v3.1") {
    prexyaddress <- paste0(init_URL, ".Reading/.Meteorology/.TAMSAT/.TARCAT/.v3p1")
    if (data == "daily_rfe") {
      extension <- ".daily/.rfe"
    } # grid: /T (julian_day) ordered (1 Jan 1983) to (10 Sep 2020) by 1.0 N= 13768 pts :grid
    else if (data == "daily_rfe_filled") {
      extension <- ".daily/.rfe_filled"
    } # grid: /T (julian_day) ordered (1 Jan 1983) to (10 Sep 2020) by 1.0 N= 13768 pts :grid
    else if (data == "dekadal_rfe") {
      extension <- ".dekadal/.rfe"
    } # grid: /T (days since 1960-01-01) ordered [ (1-10 Jan 1983) (11-20 Jan 1983) (21-31 Jan 1983) ... (1-10 Sep 2020)] N= 1357 pts :grid
    else if (data == "dekadal_rfe_filled") {
      extension <- ".dekadal/.rfe_filled"
    } # grid: /T (days since 1960-01-01) ordered [ (1-10 Jan 1983) (11-20 Jan 1983) (21-31 Jan 1983) ... (1-10 Sep 2020)] N= 1357 pts :grid
    else if (data == "monthly_rfe") {
      extension <- ".monthly/.rfe"
    } # grid: /T (months since 1960-01-01) ordered (Jan 1983) to (Aug 2020) by 1.0 N= 452 pts :grid
    else if (data == "monthly_rfe_filled") {
      extension <- ".monthly/.rfe_filled"
    } # grid: /T (months since 1960-01-01) ordered (Jan 1983) to (Aug 2020) by 1.0 N= 452 pts :grid
    else {
      stop("Data file does not exist for TAMSAT_v3.1 data")
    }
  } else if (source == "NOAA") {
    prexyaddress <- paste0(init_URL, ".NOAA/.NCEP/.CPC/.FEWS/.Africa")
    if (data == "daily_rfev2_est_prcp") {
      extension <- ".DAILY/.RFEv2/.est_prcp"
    } # (days since 2000-10-31 12:00:00) ordered (31 Oct 2000) to (12 Sep 2020)
    else if (data == "10day_rfev2_est_prcp") {
      extension <- ".TEN-DAY/.RFEv2/.est_prcp"
    } # grid: /T (days since 1960-01-01) ordered [ (1-10 Dec 1999) (11-20 Dec 1999) (21-31 Dec 1999) ... (1-10 Sep 2020)] N= 748 pts :grid
    else if (data == "daily_est_prcp") {
      extension <- ".DAILY/.ARC2/.daily/.est_prcp"
    } # (days since 1960-01-01 12:00:00) ordered (1 Jan 1983) to (12 Sep 2020)
    else if (data == "monthly_est_prcp") {
      extension <- ".DAILY/.ARC2/.monthly/.est_prcp"
    } # (months since 1960-01-01) ordered (Jan 1983) to (Aug 2020)
    else {
      stop("Data file does not exist for NOAA data")
    }
  } else if (source == "NOAA_CMORPH_DAILY" || source == "NOAA_CMORPH_3HOURLY" || source == "NOAA_CMORPH_DAILY_CALCULATED") {
    if (source == "NOAA_CMORPH_DAILY") {
      prexyaddress <- paste0(init_URL, ".NOAA/.NCEP/.CPC/.CMORPH/.daily")
    }
    else if (source == "NOAA_CMORPH_3HOURLY") {
      prexyaddress <- paste0(init_URL, ".NOAA/.NCEP/.CPC/.CMORPH/.3-hourly")
    }
    else if (source == "NOAA_CMORPH_DAILY_CALCULATED") {
      prexyaddress <- paste0(init_URL, ".NOAA/.NCEP/.CPC/.CMORPH/.daily_calculated")
    }
    if (data == "mean_microwave_only_est_prcp") {
      extension <- ".mean/.microwave-only/.comb"
    }
    else if (data == "mean_morphed_est_prcp") {
      extension <- ".mean/.morphed/.cmorph"
    }
    else if (data == "orignames_mean_microwave_only_est_prcp") {
      extension <- ".orignames/.mean/.microwave-only/.comb"
    }
    else if (data == "orignames_mean_morphed_est_prcp") {
      extension <- ".orignames/.mean/.morphed/.cmorph"
    }
    else if (data == "renamed102015_mean_microwave_only_est_prcp") {
      extension <- ".renamed102015/.mean/.microwave-only/.comb"
    }
    else if (data == "renamed102015_mean_morphed_est_prcp") {
      extension <- ".renamed102015/.mean/.morphed/.cmorph"
    }
    else {
      stop("Data file does not exist for NOAA CMORPH data")
    }
  } else if (source == "NASA") {
    prexyaddress <- paste0(init_URL, ".NASA/.GES-DAAC/.TRMM_L3/.TRMM_3B42/.v7")
    if (data == "daily_prcp") {
      extension <- ".daily/.precipitation"
    } # (days since 1998-01-01 00:00:00) ordered (1 Jan 1998) to (31 May 2015)
    else if (data == "3_hourly_prcp") {
      extension <- ".three-hourly/.precipitation"
    } # (days since 1998-01-01 00:00:00) ordered (2230 31 Dec 1997 - 0130 1 Jan 1998) to (2230 30 May 2015 - 0130 31 May 2015)
    else {
      stop("Data file does not exist for NASA TRMM 3B42 data")
    }
  } else {
    stop("Source not specified correctly.")
  }
  prexyaddress <- paste(prexyaddress, extension, sep = "/")
  if (download_type == "Area") {
    URL <- add_xy_area_range(path = prexyaddress, min_lon = min_lon, min_lat = min_lat, max_lon = max_lon, max_lat = max_lat, dim_x = dim_x, dim_y = dim_y)
  }
  else if (download_type == "Point") {
    URL <- add_xy_point_range(path = prexyaddress, min_lon = min_lon, min_lat = min_lat, dim_x = dim_x, dim_y = dim_y)
  }
  if (!missing(min_date) & !missing(max_date)) {
    URL <- URL %>% add_t_range(min_date = min_date, max_date = max_date, dim_t = dim_t)
  }
  URL <- URL %>% add_nc()
  file_name <- tempfile(pattern = tolower(source), tmpdir = path, fileext = ".nc")
  result <- download.file(url = URL, destfile = file_name, method = "libcurl", mode = "wb", cacheOK = FALSE)
  if (import && result == 0) {
    nc <- ncdf4::nc_open(filename = file_name)
    self$import_NetCDF(nc = nc, name = name)
    ncdf4::nc_close(nc = nc)
  } else if (result != 0) {
    stop("No file downloaded please check your internet connection")
  }
  if (missing(path)) {
    file.remove(file_name)
  }
})

DataBook$set("public", "patch_climate_element", function(data_name, date_col_name = "", var = "", vars = c(), max_mean_bias = NA, max_stdev_bias = NA, column_name, station_col_name = station_col_name) {
  self$get_data_objects(data_name)$patch_climate_element(date_col_name = date_col_name, var = var, vars = vars, max_mean_bias = max_mean_bias, max_stdev_bias = max_stdev_bias, column_name = column_name, station_col_name = station_col_name)
})

DataBook$set("public", "visualize_element_na", function(data_name, element_col_name, element_col_name_imputed, station_col_name, x_axis_labels_col_name, ncol = 2, type = "distribution", xlab = NULL, ylab = NULL, legend = TRUE, orientation = "horizontal", interval_size = interval_size, x_with_truth = NULL, measure = "percent") {
  self$get_data_objects(data_name)$visualize_element_na(element_col_name = element_col_name, element_col_name_imputed = element_col_name_imputed, station_col_name = station_col_name, x_axis_labels_col_name = x_axis_labels_col_name, ncol = ncol, type = type, xlab = xlab, ylab = ylab, legend = legend, orientation = orientation, interval_size = interval_size, x_with_truth = x_with_truth, measure = measure)
})