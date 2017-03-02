data_object <- R6Class("data_object",
                         public = list(
                           initialize = function(data = data.frame(), data_name = "", 
                                                 variables_metadata = data.frame(), metadata = list(), 
                                                 imported_from = "", 
                                                 messages = TRUE, convert=TRUE, create = TRUE, 
                                                 start_point=1, filters = list(), objects = list(),
                                                 calculations = list(), keys = list(), keep_attributes = TRUE)
{
                             
  # Set up the data object
  self$set_data(data, messages)
  self$set_changes(list())
  #removed until this can be fixed.
  #self$set_variables_metadata(variables_metadata)
  
  # Set first so that "no_filter" is added
  self$set_filters(filters)
  if(keep_attributes) {
    self$set_meta(c(attributes(private$data), metadata))
  }
  else {
    self$set_meta(metadata)
    self$clear_variables_metadata()
  }
  self$add_defaults_meta()
  self$add_defaults_variables_metadata()
  #self$update_variables_metadata()
  self$set_objects(objects)
  self$set_calculations(calculations)
  self$set_keys(keys)
  
  # If no name for the data.frame has been given in the list we create a default one.
  # Decide how to choose default name index
  if ( !(is.null(data_name) || data_name == "" || missing(data_name))) {
    if(data_name != make.names(data_name)) {
      message("data_name is invalid. It will be made valid automatically.")
      data_name <- make.names(data_name)
    }
    self$append_to_metadata(data_name_label, data_name)
  }
  else if (!self$is_metadata(data_name_label)) {
    if (( is.null(data_name) || data_name == "" || missing(data_name))) {
      self$append_to_metadata(data_name_label,paste0("data_set_",sprintf("%03d", start_point)))
      if (messages) {
        message(paste0("No name specified in data_tables list for data frame ", start_point, ". 
                       Data frame will have default name: ", "data_set_",sprintf("%03d", start_point)))
      }
    }
    else self$append_to_metadata(data_name_label, data_name)     
  }
  
}
),
                         private = list(
                           data = data.frame(),
                           filters = list(),
                           objects = list(),
                           keys = list(),
                           calculations = list(),
                           changes = list(), 
                           .current_filter = list(),
                           .data_changed = FALSE,
                           .metadata_changed = FALSE, 
                           .variables_metadata_changed = FALSE 
                          ),
                          active = list(
                            data_changed = function(new_value) {
                              if(missing(new_value)) return(private$.data_changed)
                              else {
                                if(new_value != TRUE && new_value != FALSE) stop("new_val must be TRUE or FALSE")
                                private$.data_changed <- new_value
                                self$append_to_changes(list(Set_property, "data_changed"))
                              }
                            },
                            metadata_changed = function(new_value) {
                              if(missing(new_value)) return(private$.metadata_changed)
                              else {
                                if(new_value != TRUE && new_value != FALSE) stop("new_val must be TRUE or FALSE")
                                private$.metadata_changed <- new_value
                                self$append_to_changes(list(Set_property, "metadata_changed"))
                              }
                            },
                            variables_metadata_changed = function(new_value) {
                              if(missing(new_value)) return(private$.variables_metadata_changed)
                              else {
                                if(new_value != TRUE && new_value != FALSE) stop("new_val must be TRUE or FALSE")
                                private$.variables_metadata_changed <- new_value
                                self$append_to_changes(list(Set_property, "variable_data_changed"))
                              }
                            },
                            current_filter = function(filter) {
                              if(missing(filter)) {
                                return(self$get_filter_as_logical(private$.current_filter$name))
                              }
                              else {
                                private$.current_filter <- filter
                                self$data_changed <- TRUE
                                self$append_to_changes(list(Set_property, "current_filter"))
                              }
                            }
                          )
)

data_object$set("public", "set_data", function(new_data, messages=TRUE, check_names = TRUE) {
  if( ! is.data.frame(new_data) ) {
    stop("Data set must be of type: data.frame")
  }
  else {
    if ( length(new_data) == 0 && messages) {
      message("data of object:is empty. Data will be an empty data frame.")
    }
    if(check_names) {
      if(!all(names(new_data) == make.names(names(new_data)))) {
        warning("Not all column names are syntactically valid. make.names() will be used to force them to be valid.")
        names(new_data) <- make.names(names(new_data))
      }
    }
    private$data <- new_data
    self$append_to_changes(list(Set_property, "data"))
    self$data_changed <- TRUE
    self$variables_metadata_changed <- TRUE
    #      is_data_split<<-FALSE
  }
}
)

data_object$set("public", "set_meta", function(new_meta) {
  self$clear_metadata()
  if(!is.list(new_meta)) stop("new_meta must be of type: list")
  for(name in names(new_meta)) {
    self$append_to_metadata(name, new_meta[[name]])
  }
  self$metadata_changed <- TRUE
  self$append_to_changes(list(Set_property, "meta data"))
}
)

#Dangerous to call directly as could remove properties needed by InstatObject
data_object$set("public", "clear_metadata", function() {
  for(name in names(attributes(private$data))) {
    if(!name %in% c(data_type_label, data_name_label, "row.names", "names")) attr(private$data, name) <- NULL
  }
  self$add_defaults_meta()
  self$metadata_changed <- TRUE
  self$append_to_changes(list(Set_property, "meta data"))
}
)

#Removed until can be fixed with attributes
# data_object$set("public", "set_variables_metadata", function(new_meta) {
#   if(!is.data.frame(new_meta)) stop("variable metadata must be of type: data.frame")
#   
#   private$variables_metadata <- new_meta
#   self$append_to_changes(list(Set_property, "variable metadata"))
# }
# )

data_object$set("public", "set_changes", function(new_changes) {
  if(!is.list(new_changes)) stop("Changes must be of type: list")

    private$changes <- new_changes
    self$append_to_changes(list(Set_property, "changes"))  
}
)

data_object$set("public", "set_filters", function(new_filters) {
  if(!is.list(new_filters)) stop("Filters must be of type: list")
  
  self$append_to_changes(list(Set_property, "filters"))  
  private$filters <- new_filters
  if(!"no_filter" %in% names(private$filters)) {
    self$add_filter(filter = list(), filter_name = "no_filter", replace = TRUE, set_as_current = TRUE, na.rm = FALSE, is_no_filter = TRUE)
  }
}
)

data_object$set("public", "set_objects", function(new_objects) {
  if(!is.list(new_objects)) stop("new_objects must be of type: list")
  
  self$append_to_changes(list(Set_property, "objects"))  
  private$objects <- new_objects
}
)

data_object$set("public", "set_calculations", function(new_calculations) {
  if(!is.list(new_calculations)) stop("new_calculations must be of type: list")
  
  self$append_to_changes(list(Set_property, "calculations"))  
  private$calculations <- new_calculations
}
)

data_object$set("public", "set_keys", function(new_keys) {
  if(!is.list(new_keys)) stop("new_objects must be of type: list")
  
  self$append_to_changes(list(Set_property, "keys"))  
  private$keys <- new_keys
}
)

# data_object$set("public", "update_variables_metadata", function() {
#   #Not needed now using attributes
#   #if(ncol(private$data) !=  nrow(private$variables_metadata) || !all(colnames(private$data)==rownames(private$variables_metadata))) {
#   #  if(all(colnames(private$data) %in% rownames(private$variables_metadata))) {
#       #self$set_variables_metadata(private$variables_metadata[colnames(private$data),])
#    # }
#    # else {
#    # }
#   #}
#   for(col in colnames(self$get_data_frame())) {
#     if(!self$is_variables_metadata(display_decimal_label, col)) self$append_to_variables_metadata(col, display_decimal_label, get_default_decimal_places(self$get_columns_from_data(col, use_current_filter = FALSE)))
#     #self$append_to_variables_metadata(col, data_type_label, class(private$data[[col]]))
#     self$append_to_variables_metadata(col, name_label, col)
#   }
# }
# )

data_object$set("public", "set_data_changed", function(new_val) {
  self$data_changed <- new_val
}
)

data_object$set("public", "set_variables_metadata_changed", function(new_val) {
  self$variables_metadata_changed <- new_val
}
)

data_object$set("public", "set_metadata_changed", function(new_val) {
  self$metadata_changed <- new_val
}
)

data_object$set("public", "get_data_frame", function(convert_to_character = FALSE, include_hidden_columns = TRUE, use_current_filter = TRUE, filter_name = "", stack_data = FALSE, remove_attr = FALSE, retain_attr = FALSE, ...) {
  if(!stack_data) {
    if(!include_hidden_columns && self$is_variables_metadata(is_hidden_label)) {
      hidden <- self$get_variables_metadata(property = is_hidden_label)
      hidden[is.na(hidden)] <- FALSE
      out <- private$data[!self$get_variables_metadata(property = is_hidden_label)]
    }
    else out <- private$data
    if(use_current_filter && self$filter_applied()) {
      if(filter_name != "") {
        out <- out[self$current_filter & self$get_filter_as_logical(filter_name = filter_name), ]
      }
      else {
        out <- out[self$current_filter, ]
      }
    }
    else {
      if(filter_name != "") {
        out <- out[self$get_filter_as_logical(filter_name = filter_name), ]
      }
    }
    # This is needed as some R function misinterpret the class of a column
    # when there are extra attributes on columns
    if(remove_attr) {
      for(i in seq_along(out)) {
        attributes(out[[i]])[!names(attributes(out[[i]])) %in% c("class", "levels")] <- NULL
      }
    }
    
    # If a filter has been done, some column attributes are lost.
    # This ensures they are present in the returned data.
    if(retain_attr) {
      for(col_name in names(out)) {
        for(attr_name in names(attributes(private$data[[col_name]]))) {
          if(!attr_name %in% c("class", "levels")) {
            attr(out[[col_name]], attr_name) <- attr(private$data[[col_name]], attr_name)
          }
        }
      }
    }
    
    if(convert_to_character) {
      decimal_places = self$get_variables_metadata(property = display_decimal_label, column = names(out))
      decimal_places[is.na(decimal_places)] <- 0
      return(convert_to_character_matrix(out, TRUE, decimal_places))
    }
    else return(out)
  }
  else {
    return(melt(self$get_data_frame(include_hidden_columns = include_hidden_columns, use_current_filter = use_current_filter, filter_name = filter_name), ...))
  }
}
)

data_object$set("public", "get_variables_metadata", function(data_type = "all", convert_to_character = FALSE, property, column, error_if_no_property = TRUE, direct_from_attributes = FALSE) {
  #if(update) self$update_variables_metadata()
  if(direct_from_attributes) {
    if(missing(property)) return(attributes(self$get_columns_from_data(column, use_current_filter = FALSE)))
    else return(attr(self$get_columns_from_data(column, use_current_filter = FALSE), property))
  }
  else {
    i = 1
    out = list()
    for(col in self$get_data_frame(use_current_filter = FALSE)) {
      ind = which(names(attributes(col)) == "levels")
      if(length(ind) > 0) col_attributes <- attributes(col)[-ind]
      else col_attributes = attributes(col)
      if(is.null(col_attributes)) col_attributes <- list()
      col_attributes[[data_type_label]] <- class(col)
      for(att_name in names(col_attributes)) {
        #TODO Think how to do this more generally and cover all cases
        if(is.list(col_attributes[[att_name]]) || length(col_attributes[[att_name]]) > 1) col_attributes[[att_name]] <- paste(unlist(col_attributes[[att_name]]), collapse = ",")
        # TODO Possible alternative to include names of list
        # TODO See how to have data frame properly containing lists
        #if(is.list(col_attributes[[att_name]]) || length(col_attributes[[att_name]]) > 1) col_attributes[[att_name]] <- paste(names(unlist(col_attributes[[att_name]])), unlist(col_attributes[[att_name]]), collapse = ",")
      }
      #if(is.null(col_attributes)) {
      #  col_attributes <- data.frame(class = NA)
      #}
      col_attributes <- data.frame(col_attributes, stringsAsFactors = FALSE)
      out[[i]] <- col_attributes
      i = i + 1
    }
    #RLink crashes with bind_rows for data frames with ~50+ columns
    out <- rbind.fill(out)
    out <- as.data.frame(out)
    row.names(out) <- names(self$get_data_frame(use_current_filter = FALSE))
    if(data_type != "all") {
      if(data_type == "numeric") {
        out = out[out[[data_type_label]] %in% c("numeric", "integer"), ]
      }
      else {
        out = out[out[[data_type_label]] == data_type, ]        
      }
    }
    not_found <- FALSE
    if(!missing(property)) {
      if(!property %in% names(out)) {
        if(error_if_no_property) stop(property, " not found in variables metadata")
        not_found <- TRUE
      }
      if(!missing(column)) {
        if(!all(column %in% names(self$get_data_frame(use_current_filter = FALSE)))) stop(column, " not found in data")
        if(not_found) out <- rep(NA, length(column))
        else out <- out[column, property]
      }
      else {
        if(not_found) out <- rep(NA, length(names(self$get_data_frame(use_current_filter = FALSE))))
        else out <- out[, property]
      }
    }
    
    #TODO get convert_to_character_matrix to work on vectors
    if(convert_to_character && missing(property)) return(convert_to_character_matrix(out, FALSE))
    else return(out)
  }
}
)

data_object$set("public", "clear_variables_metadata", function() {
  for(column in self$get_data_frame(use_current_filter = FALSE)) {
    for(name in names(attributes(column))) {
      if(!name  %in% c(data_type_label, data_name_label)) attr(self, name) <- NULL
    }
  }
  self$add_defaults_variables_metadata()
}
)

data_object$set("public", "get_metadata", function(label, include_calculated = TRUE, excluded_not_for_display = TRUE) {
  curr_data <- self$get_data_frame(use_current_filter = FALSE)
  if(missing(label)) {
    if(include_calculated) {
      #Must be private$data because assigning attribute to data field
      attr(curr_data, row_count_label) <- nrow(curr_data)
      attr(curr_data, column_count_label) <- ncol(curr_data)
    }
    if(excluded_not_for_display) {
      ind <- which(names(attributes(curr_data)) %in% c("names", "row.names"))
      if(length(ind) > 0) out <- attributes(curr_data)[-ind]
    }
    else out <- attributes(curr_data)
    return(out)
  }
  else {
    if(label %in% names(attributes(curr_data))) return(attributes(curr_data)[[label]])
    else if(label == row_count_label) return(nrow(curr_data))
    else if(label == column_count_label) return(ncol(curr_data))
    else return("")
  }
}
)

data_object$set("public", "get_changes", function() {
  return(private$changes)
}
)

data_object$set("public", "get_calculations", function() {
  return(private$calculations)
}
)

data_object$set("public", "get_calculation_names", function() {
  return(names(private$calculations))
}
)

data_object$set("public", "add_columns_to_data", function(col_name = "", col_data, use_col_name_as_prefix = FALSE, hidden = FALSE, before = FALSE, adjacent_column, num_cols) {
  # Column name must be character
  if(!is.character(col_name)) stop("Column name must be of type: character")
  if(missing(num_cols)) {
    if(missing(col_data)) stop("One of num_cols or col_data must be specified.")
    if(!missing(col_data) && (is.matrix(col_data) || is.data.frame(col_data))) {
      num_cols = ncol(col_data)
    }
    else num_cols = 1
  }
  else {
    if(missing(col_data)) col_data = replicate(num_cols, rep(NA, self$get_data_frame_length()))
    else {
      if(length(col_data) != 1) stop("col_data must be a vector/matrix/data.frame of correct length or a single value to be repeated.")
      col_data = replicate(num_cols, rep(col_data, self$get_data_frame_length()))
    }
  }
  if( col_name != "" && (length(col_name) != 1) && (length(col_name) != num_cols) ) stop("col_name must be a character or character vector with the same length as the number of new columns")
  if(col_name == "") {
    if(!is.null(colnames(col_data)) && length(colnames(col_data)) == num_cols) {
      col_name = colnames(col_data)
    }
    else {
      col_name = "X"
      use_col_name_as_prefix = TRUE
    }
  }
  if(use_col_name_as_prefix && length(col_name) > 1) {
    stop("Cannot use col_name as prefix when col_name is a vector.")
  }
  
  if(length(col_name) != num_cols) {
    use_col_name_as_prefix = TRUE
  }
  
  replaced = FALSE
  previous_length = self$get_column_count()
  if(!missing(adjacent_column) && !adjacent_column %in% self$get_column_names()) stop(adjacent_column, "not found in the data")
  
  if(before) {
    if(!missing(adjacent_column)) ind = which(self$get_column_names() == adjacent_column)
    else ind = 1
  }
  else {
    if(!missing(adjacent_column)) ind = which(self$get_column_names() == adjacent_column) + 1
    else ind = previous_length + 1
  }

  for(i in 1:num_cols) {
    if(num_cols == 1) {
      curr_col = col_data
    }
    else curr_col = col_data[,i]
    if(is.matrix(curr_col) || is.data.frame(curr_col)) curr_col = curr_col[,1]
    if(use_col_name_as_prefix) curr_col_name = self$get_next_default_column_name(col_name)
    else curr_col_name = col_name[[i]]
    if(curr_col_name %in% names(self$get_data_frame(use_current_filter = FALSE))) {
      message(paste("A column named", curr_col_name, "already exists. The column will be replaced in the data"))
      self$append_to_changes(list(Replaced_col, curr_col_name))
      replaced = TRUE
    }
    
    else self$append_to_changes(list(Added_col, curr_col_name))
    
    private$data[[curr_col_name]] <- curr_col
    self$data_changed <- TRUE
    self$append_to_variables_metadata(curr_col_name, is_hidden_label, hidden)
    self$append_to_variables_metadata(curr_col_name, name_label, curr_col_name)
    self$append_to_variables_metadata(curr_col_name, display_decimal_label, get_default_decimal_places(self$get_columns_from_data(curr_col_name, use_current_filter = FALSE)))
    self$variables_metadata_changed <- TRUE
  }
  if(!replaced) {
    if(before && ind == 1) self$set_data(dplyr::select(self$get_data_frame(use_current_filter = FALSE) , c((previous_length + 1):(previous_length + num_cols), 1:previous_length)))
    else if(before || ind != previous_length + 1) self$set_data(dplyr::select(self$get_data_frame(use_current_filter = FALSE) , c(1:(ind - 1), (previous_length + 1):(previous_length + num_cols), ind:previous_length)))
  }
  else {
    if(!missing(before) || !missing(adjacent_column)) warning("Cannot reposition when one or move new columns replaces an old column.")
  }
}
)

data_object$set("public", "get_columns_from_data", function(col_names, force_as_data_frame = FALSE, use_current_filter = TRUE) {
  if(missing(col_names)) stop("no col_names to return")
  if(!all(col_names %in% names(self$get_data_frame(use_current_filter = FALSE)))) stop("Not all column names were found in data")
  
  if(length(col_names)==1) {
    if(force_as_data_frame) return(self$get_data_frame(use_current_filter = use_current_filter)[col_names])
    else return(self$get_data_frame(use_current_filter = use_current_filter)[[col_names]])
  }
  else return(self$get_data_frame(use_current_filter = use_current_filter)[col_names])
}
)

data_object$set("public", "frequency_tables", function(x_col_names, y_col_name, addmargins = FALSE,  proportions = FALSE, percentages = FALSE,  transpose = FALSE) {
  if(missing(x_col_names) || missing(y_col_name)) stop("Both x_col_names and y_col_name are required")
  multiply_by = 1
  for (i in 1:length(x_col_names)){
    if(transpose)(my_table = table(private$data[[y_col_name]], private$data[[x_col_names[i]]])) else(my_table = table(private$data[[x_col_names[i]]], private$data[[y_col_name]]))
    
    if(percentages && proportions)( multiply_by = 100)
    else if(percentages && !proportions)warning("Proportions should be set to true to display percentages.")
    if(addmargins && proportions)(print(addmargins(prop.table(my_table)*multiply_by))) #Is FUN appropriate here?
    else if(addmargins && !proportions)(print(addmargins(my_table)))
    else if(!addmargins && proportions)(print(prop.table(my_table)*multiply_by))
    else if(!addmargins && !proportions)(print(my_table))
  }
}
)

data_object$set("public", "anova_tables", function(x_col_names, y_col_name, signif.stars = FALSE, sign_level = FALSE, means = FALSE) {
  if(missing(x_col_names) || missing(y_col_name)) stop("Both x_col_names and y_col_names are required")
  if(sign_level || signif.stars)warning("This is nolonger descriptive")
  if(sign_level)(end_col = 5)else(end_col = 4)
  for (i in 1:length(x_col_names)){
    my_model = lm(formula = as.formula(paste(as.name(y_col_name),as.name(x_col_names[i]), sep = "~")), data=private$data)
    print(anova(my_model)[1:end_col], signif.stars = signif.stars)
    if(means)(print(model.tables(aov(my_model), type = "means")))
  }
}
)

data_object$set("public", "rename_column_in_data", function(curr_col_name = "", new_col_name="") {
  curr_data <- self$get_data_frame(use_current_filter = FALSE)
  # Column name must be character
  if (new_col_name %in% names(curr_data)){
    stop("Cannot rename this column. A column named: ",new_col_name," already exists in the data.")
  }
  if(!is.character(curr_col_name)) {
    stop("Current column name must be of type: character")
  }
  
  else if (!(curr_col_name %in% names(curr_data))) {
    stop(paste0("Cannot rename column: ",curr_col_name,". Column was not found in the data."))
  }
  
  else if (!is.character(new_col_name)) {
    stop("New column name must be of type: character")
  }
  
  else {
    if(sum(names(curr_data) == curr_col_name) > 1) {
      warning(paste0("Multiple columns have name: '", curr_col_name,"'. All such columns will be 
                     renamed."))
    }
    # Need to use private$data here because changing names of data field
    names(private$data)[names(curr_data) == curr_col_name] <- new_col_name
    self$append_to_variables_metadata(new_col_name, name_label, new_col_name)
    # TODO decide if we need to do these 2 lines
    self$append_to_changes(list(Renamed_col, curr_col_name, new_col_name))
    self$data_changed <- TRUE
    self$variables_metadata_changed <- TRUE
    }
}
)

data_object$set("public", "remove_columns_in_data", function(cols=c()) {
  for(col_name in cols){
    # Column name must be character
    if(!is.character(col_name)) {
      stop("Column name must be of type: character")
    }
    
    else if (!(col_name %in% names(self$get_data_frame(use_current_filter = FALSE)))) {
      stop(paste0("Column :'", col_name, " was not found in the data."))
    }
    
    else private$data[[col_name]] <- NULL
  }
  self$append_to_changes(list(Removed_col, cols))
  self$data_changed <- TRUE
  self$variables_metadata_changed <- TRUE
}
)

data_object$set("public", "replace_value_in_data", function(col_names, rows, old_value, old_is_missing = FALSE, start_value = NA, end_value = NA, new_value, new_is_missing = FALSE, closed_start_value = TRUE, closed_end_value = TRUE) {
  curr_data <- self$get_data_frame(use_current_filter = FALSE)
  # Column name must be character
  if(!all(is.character(col_names))) stop("Column name must be of type: character")
  if (!all(col_names %in% names(curr_data))) stop("Cannot find all columns in the data.")
  if(!missing(rows) && !all(rows %in% row.names(curr_data))) stop("Not all rows found in the data.")
  if(!is.na(start_value) && !is.numeric(start_value)) stop("start_value must be numeric")
  if(!is.na(end_value) && !is.numeric(end_value)) stop("start_value must be numeric")
  if(old_is_missing) {
    if(!missing(old_value)) stop("Specify only one of old_value and old_is_missing")
    old_value <- NA
  }
  if(new_is_missing) {
    if(!missing(new_value)) stop("Specify only one of new_value and new_is_missing")
    new_value <- NA
  }
  data_row_names <- row.names(curr_data)
  filter_applied <- self$filter_applied()
  if(filter_applied) curr_filter <- self$current_filter
  for(col_name in col_names) {
    done = FALSE
    str_data_type <- self$get_variables_metadata(property = data_type_label, column = col_name)
    curr_column <- self$get_columns_from_data(col_name, use_current_filter = FALSE)
    if("factor" %in% str_data_type) {
      if(!missing(rows)) {
        if(!is.na(new_value) && !new_value %in% levels(self$get_columns_from_data(col_name, use_current_filter = FALSE))) {
          stop("new_value must be an existing level of the factor column.")
        }
        replace_rows <- (data_row_names %in% rows)
      }
      else {
        if(filter_applied) stop("Cannot replace values in a factor column when a filter is applied. Remove the filter to do this replacement.")
        if(is.na(old_value)) {
          if(!is.na(new_value) && !new_value %in% levels(self$get_columns_from_data(col_name, use_current_filter = FALSE))) stop(new_value, " is not a level of this factor. Add this as a level of the factor before using replace.")
          replace_rows <- (is.na(curr_column))
        }
        else {
          self$edit_factor_level(col_name = col_name, old_level = old_value, new_level = new_value)
          done = TRUE
        }
      }
    }
    else if(str_data_type == "integer" || str_data_type == "numeric") {
      if(!is.na(new_value)) {
        if(!is.numeric(new_value)) stop(col_name, " is a numeric/integer column. new_value must be of the same type")
        if(str_data_type == "integer" && !(new_value %% 1 == 0)) stop(col_name, " is an integer column. new_value must be an integer")
      }
      if(!missing(rows)) {
        replace_rows <- (data_row_names %in% rows)
        if(!missing(old_value) || !is.na(start_value) || !is.na(end_value)) warning("old_value, start_value and end_value will be ignored because rows has been specified.")
      }
      else {
        if(!is.na(start_value) || !is.na(end_value)) {
          if(!missing(old_value)) warning("old_value will be ignored because start_value or end_value has been specified.")
          if(closed_start_value) start_value_ineq = match.fun(">=")
          else start_value_ineq = match.fun(">")
          if(closed_end_value) end_value_ineq = match.fun("<=")
          else end_value_ineq = match.fun("<")
          
          if(!is.na(start_value) && is.na(end_value)) {
            replace_rows <- start_value_ineq(curr_column, start_value)
          }
          else if(is.na(start_value) && !is.na(end_value)) {
            replace_rows <- end_value_ineq(curr_column, end_value)
          }
          else if(!is.na(start_value) && !is.na(end_value)) {
            replace_rows <- (start_value_ineq(curr_column,start_value) & end_value_ineq(curr_column, end_value))
          }
        }
        else {
          if(is.na(old_value)) replace_rows <- (is.na(curr_column))
          else replace_rows <- (curr_column == old_value)
        }
      }
    }
    else if(str_data_type == "character") {
      if(!missing(rows)) {
        replace_rows <- (data_row_names %in% rows)
        if(!missing(old_value)) warning("old_value will be ignored because rows has been specified.")
      }
      else {
        if(is.na(old_value)) replace_rows <- (is.na(curr_column))
        else replace_rows <- (curr_column == old_value)
      }
      new_value <- as.character(new_value)
    }
    else if(str_data_type == "logical") {
      #Removed because new columns are logical and we need to be able to type in new values
      #if(!is.logical(new_value)) stop(col_name, " is a logical column. new_value must be a logical value")
      if(!missing(rows)) {
        replace_rows <- (data_row_names %in% rows)
        if(!missing(old_value)) warning("old_value will be ignored because rows has been specified.")
      }
      else {
        if(is.na(old_value)) replace_rows <- (is.na(curr_column))
        else replace_rows <- (curr_column == old_value)
      }
    }
    #TODO add other data type cases
    else {
      if(!missing(rows)) {
        replace_rows <- (data_row_names %in% rows)
        if(!missing(old_value)) warning("old_value will be ignored because rows has been specified.")
      }
      else {
        if(is.na(old_value)) replace_rows <- (is.na(curr_column))
        else replace_rows <- (curr_column == old_value)
      }
    }
    if(!done) {
      replace_rows[is.na(replace_rows)] <- FALSE
      if(sum(replace_rows) > 0) {
        if(filter_applied) {
          replace_rows <- replace_rows & curr_filter
        }
        # Need private$data here as replacing values in data
        if(sum(replace_rows) > 0) private$data[[col_name]][replace_rows] <- new_value
        else message("No values to replace in ", col_name)
      }
      else message("No values to replace in ", col_name)
    }
  }
  #TODO need to think what to add to changes
  self$append_to_changes(list(Replaced_value, col_names))
  self$data_changed <- TRUE
  self$variables_metadata_changed <- TRUE
}
)

# 
# data_object$set("public", "replace_value_in_data", function(col_name = "", row, new_value = "") {
#   
#   # Column name must be character
#   if(!is.character(col_name)) {
#     stop("Column name must be of type: character")
#   }
#   
#   else if (!(col_name %in% names(private$data))) {
#     stop(paste("Cannot find column:",col_name,"in the data."))
#   }
#   
#   # Column data length must match number of rows of data.
#   else if (!(row %in% rownames(private$data))) {
#     stop("row not found in data")
#   }
#   index <- which(rownames(private$data) == row)
#   old_value <- private$data[[col_name]][[index]]
#   str_data_type <-self$get_variables_metadata(property = data_type_label, column = col_name)
#   if(str_data_type == "factor") {
#     if(!is.na(new_value) && !(new_value %in% levels(private$data[[col_name]]))) {
#       stop(new_value, " is not an existing level of the factor")
#     }
#   }
#   if(str_data_type == "integer") {
#     #TODO Check that what checks are needed here
#     new_value <- as.integer(new_value)
#   }
#   if(str_data_type == "numeric") {
#     new_value <- as.numeric(new_value)
#   }
#   private$data[[col_name]][[index]] <- new_value
#   self$append_to_changes(list(Replaced_value, col_name, row, old_value, new_value))
#   self$data_changed <- TRUE
#   self$variables_metadata_changed <- TRUE
# }
# )

data_object$set("public", "append_to_metadata", function(property, new_value = "") {
  
  if(missing(property)) stop("property must be specified.")
  
  if (!is.character(property)) stop("property must be of type: character")
  
  attr(private$data, property) <- new_value
  self$append_to_changes(list(Added_metadata, property, new_value))
  self$metadata_changed <- TRUE
}
)

data_object$set("public", "append_to_variables_metadata", function(col_names, property, new_val = "") {
  if(missing(property)) stop("property must be specified.")
  if(!is.character(property)) stop("property must be a character")
  if(!missing(col_names)) {
    if(!all(col_names %in% names(self$get_data_frame(use_current_filter = FALSE)))) stop("Not all of ", paste(col_names, collapse = ","), " found in data.")
    for(curr_col in col_names) {
      attr(private$data[[curr_col]], property) <- new_val
      self$append_to_changes(list(Added_variables_metadata, curr_col, property))
    }
  }
  else {
    for(col_name in names(self$get_data_frame(use_current_filter = FALSE))) {
      attr(private$data[[col_name]], property) <- new_val
    }
    self$append_to_changes(list(Added_variables_metadata, property, new_val))
  }
  self$variables_metadata_changed <- TRUE
  self$data_changed <- TRUE
}
)

data_object$set("public", "append_to_changes", function(value) {
  
  if( missing(value) ) {
    stop(" value arguements must be specified.")
  } 
  else {
    private$changes[[length(private$changes)+1]] <- value 
  }
}
)

data_object$set("public", "is_metadata", function(str) {
  return(str %in% names(attributes(private$data)))
}
)

data_object$set("public", "is_variables_metadata", function(str, col, return_vector = FALSE) {
  if(!str %in% names(self$get_variables_metadata())) return(FALSE)
  if(missing(col)) return(TRUE)
  else {
    out <- sapply(col, function(x) str %in% names(attributes(self$get_columns_from_data(x, use_current_filter = FALSE))))
    if(return_vector) return(out)
    else return(all(out))
  }
}
)

data_object$set("public", "add_defaults_meta", function() {
  if(!self$is_metadata(is_calculated_label)) self$append_to_metadata(is_calculated_label, FALSE)
}
)

data_object$set("public", "add_defaults_variables_metadata", function() {
  invisible(sapply(colnames(self$get_data_frame(use_current_filter = FALSE)), function(x) self$append_to_variables_metadata(x, name_label, x)))
  has_hidden <- self$is_variables_metadata(is_hidden_label) && !is.na(self$get_variables_metadata(property = is_hidden_label)) && self$get_variables_metadata(property = is_hidden_label)
  if(has_hidden) {
    for(column in colnames(self$get_data_frame(use_current_filter = FALSE))) {
      if(!self$is_variables_metadata(is_hidden_label, column)) {
        self$append_to_variables_metadata(column, property = is_hidden_label, new_val = FALSE)
      }
    }
  }
  else self$append_to_variables_metadata(property = is_hidden_label, new_val = FALSE)
  for(column in colnames(self$get_data_frame(use_current_filter = FALSE))) {
    if(has_hidden) {
      if(!self$is_variables_metadata(is_hidden_label, column)) self$append_to_variables_metadata(column, property = is_hidden_label, new_val = FALSE)
    }
    self$append_to_variables_metadata(column, name_label, column)
    self$append_to_variables_metadata(column, display_decimal_label, get_default_decimal_places(self$get_columns_from_data(column, use_current_filter = FALSE)))
  }
}
)

data_object$set("public", "remove_rows_in_data", function(row_names) {
  curr_data <- self$get_data_frame(use_current_filter = FALSE)
  if(!all(row_names %in% rownames(curr_data))) stop("Some of the row_names not found in data")
  rows_to_remove <- which(rownames(curr_data) %in% row_names)
  self$set_data(slice(curr_data, -rows_to_remove))
  self$append_to_changes(list(Removed_row, row_names))
  self$data_changed <- TRUE
}
)

data_object$set("public", "get_next_default_column_name", function(prefix) {
  next_default_item(prefix = prefix, existing_names = names(self$get_data_frame(use_current_filter = FALSE)))
} 
)

data_object$set("public", "reorder_columns_in_data", function(col_order) {
  if (ncol(self$get_data_frame(use_current_filter = FALSE)) != length(col_order)) stop("Columns to order should be same as columns in the data.")
  
  if(is.numeric(col_order)) {
    if(!(identical(sort(col_order), sort(as.numeric(1:ncol(data)))))) {
      stop("Invalid column order")
    }
  }
  else if(is.character(col_order)) {
    if(!(setequal(col_order,names(private$data)))) stop("Invalid column order")
  }
  else stop("column order must be a numeric or character vector")
  self$set_data(private$data[ ,col_order])
  self$append_to_changes(list(Col_order, col_order))
}
)

data_object$set("public", "insert_row_in_data", function(start_row, row_data = c(), number_rows = 1, before = FALSE) {
  curr_data <- self$get_data_frame(use_current_filter = FALSE)
  curr_row_names <- rownames(curr_data)
  if (!start_row %in% curr_row_names) {
    stop(paste(start_row, " not found in rows"))
  }
  row_position = which(curr_row_names == start_row)
  row_data <- curr_data[0, ]
  for(i in 1:number_rows) {
    row_data[i, ] <- NA
  }
  #row_data <- data.frame(matrix(NA, nrow = number_rows, ncol = ncol(curr_data)))
  #colnames(row_data) <- colnames(curr_data)
  if(length(curr_row_names[!is.na(as.numeric(curr_row_names))]) > 0) {
    rownames(row_data) <- max(as.numeric(curr_row_names), na.rm = TRUE) + 1:number_rows
  }
  else rownames(row_data) <- nrow(curr_data) + 1:(number_rows - 1)
  old_attr <- attributes(private$data)
  # Need to use rbind.fill (not bind_rows) because it preserves column attributes
  if(before && row_position == 1) {
    # This transfers attributes to new data so that they are kept after rbind.fill
    # Only needed when row_data is first argument to rbind.fill
    for(i in seq_along(row_data)) {
      attributes(row_data[[i]]) <- attributes(curr_data[[i]])
    }
    self$set_data(rbind.fill(row_data, curr_data))
  }
  else if(!before && row_position == nrow(curr_data)) {
    self$set_data(rbind.fill(curr_data, row_data))
  }
  else {
    if(before) {
      self$set_data(rbind.fill(slice(curr_data,(1:(row_position - 1))), row_data, slice(curr_data,row_position:nrow(curr_data))))
    }
    else {
      self$set_data(rbind.fill(slice(curr_data, (1:row_position)), row_data, slice(curr_data,(row_position + 1):nrow(curr_data))))
    }
  }
  for(attr_name in names(old_attr)) {
    if(!attr_name %in% c("names", "class", "row.names")) {
      self$append_to_metadata(attr_name, old_attr[[attr_name]])
    }
  }
  self$append_to_changes(list(Inserted_row, number_rows))
  self$data_changed <- TRUE
}
)

data_object$set("public", "get_data_frame_length", function(use_current_filter = FALSE) {
  return(nrow(self$get_data_frame(use_current_filter = use_current_filter)))
}
)

data_object$set("public", "get_factor_data_frame", function(col_name = "") {
  if(!(col_name %in% names(self$get_data_frame(use_current_filter = FALSE)))){
    stop(col_name, " is not a column in", get_metadata(data_name_label))
  }
  if(!(is.factor(self$get_columns_from_data(col_name, use_current_filter = FALSE)))){
    stop(col_name, " is not a factor column")
  }
  
  counts <- as.data.frame(table(self$get_columns_from_data(col_name, use_current_filter = FALSE)))
  counts <- plyr::rename(counts, replace = c("Var1" = "Levels", "Freq" = "Counts"))
  return(counts)
}
)

data_object$set("public", "get_column_factor_levels", function(col_name = "") {
  if(!(col_name %in% names(self$get_data_frame(use_current_filter = FALSE)))){
    stop(col_name, " is not a column in", get_metadata(data_name_label))
  }
  
  if(!(is.factor(self$get_columns_from_data(col_name, use_current_filter = FALSE)))){
    stop(col_name, " is not a factor column")
  }
  
  return(levels(self$get_columns_from_data(col_name, use_current_filter = FALSE)))
}
)

data_object$set("public", "sort_dataframe", function(col_names = c(), decreasing = FALSE, na.last = TRUE, by_row_names = FALSE, row_names_as_numeric = TRUE) {
  curr_data <- self$get_data_frame(use_current_filter = FALSE)
  string <- list()
  if(missing(col_names) || length(col_names) == 0) {
    if(by_row_names) {
      if(row_names_as_numeric) row_names_sort <- as.numeric(row.names(curr_data))
      else row_names_sort <- row.names(curr_data)
      if(decreasing) self$set_data(arrange(curr_data, desc(row_names_sort)))
      else self$set_data(arrange(curr_data, row_names_sort))
    }
    else message("No sorting to be done.")
  }
  else {
    col_names_exp = c()
    i = 1
    for(col_name in col_names){
      if(!(col_name %in% names(curr_data))) {
        stop(col_name, " is not a column in ", get_metadata(data_name_label))
      }
      if(decreasing) col_names_exp[[i]] <- interp(~ desc(var), var = as.name(col_name))
      else col_names_exp[[i]] <- interp(~ var, var = as.name(col_name))
      i = i + 1
    }
    if(by_row_names) warning("Cannot sort by columns and row names. Sorting will be done by given columns only.")
    self$set_data(arrange_(curr_data, .dots = col_names_exp))
  }
  self$data_changed <- TRUE
}
)

data_object$set("public", "convert_column_to_type", function(col_names = c(), to_type, factor_numeric = "by_levels", set_digits, set_decimals = FALSE) {
  for(col_name in col_names){
    if(!(col_name %in% names(self$get_data_frame(use_current_filter = FALSE)))){
      stop(col_name, " is not a column in ", get_metadata(data_name_label))
    }
  }
  
  if(length(to_type)>1){
    warning("Column(s) will be converted to type ", to_type[1])
    to_type = to_type[1]
  }
  
  
  if(!(to_type %in% c("integer", "factor", "numeric", "character", "ordered_factor"))){
    stop(to_type, " is not a valid type to convert to")
  }
  
  if(!(factor_numeric %in% c("by_levels", "by_ordinals"))){
    stop(factor_numeric, " can either be by_levels or by_ordinals.")
  }
  
  for(col_name in col_names) {
    curr_col <- self$get_columns_from_data(col_name, use_current_filter = FALSE)
    if(to_type=="factor") {
      # Warning: this is different from expected R behaviour
      # Any ordered columns would become unordered factors
	  if(!set_decimals){
	   self$add_columns_to_data(col_name = col_name, col_data = factor(curr_col, ordered = FALSE))
	  } 
	  else {self$add_columns_to_data(col_name = col_name, col_data = factor(round(curr_col, digits = set_digits), ordered = FALSE))
      }
    }
    else if(to_type =="integer") {
      self$add_columns_to_data(col_name = col_name, col_data = as.integer(curr_col))
    }
    else if(to_type == "ordered_factor") {
	   if(!set_decimals){
	   self$add_columns_to_data(col_name = col_name, col_data = factor(curr_col, ordered = TRUE))
	  } 
	  else {self$add_columns_to_data(col_name = col_name, col_data = factor(round(curr_col, digits = set_digits), ordered = TRUE))
	  }
    }
    else if(to_type == "integer") {
      self$add_columns_to_data(col_name = col_name, col_data = as.integer(curr_col))
    }
    else if(to_type == "numeric") {
      if(is.factor(curr_col) && (factor_numeric == "by_levels")) {
        self$add_columns_to_data(col_name = col_name, col_data = as.numeric(levels(curr_col))[curr_col])
      }
      else self$add_columns_to_data(col_name = col_name, col_data = as.numeric(curr_col))
    }
    else if(to_type == "character") {
      self$add_columns_to_data(col_name = col_name, col_data = as.character(curr_col))
    }
    self$append_to_variables_metadata(property = display_decimal_label, col_names = col_name, new_val = get_default_decimal_places(curr_col))
  }
  self$data_changed <- TRUE
  self$variables_metadata_changed <- TRUE
}
)

data_object$set("public", "copy_columns", function(col_names = "") {
  for(col_name in col_names){
    if(!(col_name %in% names(self$get_data_frame(use_current_filter = FALSE)))){
      stop(col_name, " is not a column in ", get_metadata(data_name_label))
    }
  }
  dat1 <- self$get_columns_from_data(col_names, use_current_filter = FALSE)
  
  for(name in col_names){
    names(dat1)[names(dat1) == name] <- self$get_next_default_column_name(prefix = paste(name, "copy", sep = "_" ) )
  }
  
  self$add_columns_to_data(col_name = names(dat1), col_data = dat1)
  self$append_to_changes(list(Copy_cols, col_names))
}
)

data_object$set("public", "drop_unused_factor_levels", function(col_name) {
  if(!col_name %in% names(self$get_data_frame(use_current_filter = FALSE))) stop(paste(col_name,"not found in data."))
  if(!is.factor(self$get_columns_from_data(col_name, use_current_filter = FALSE))) stop(paste(col_name,"is not a factor."))
  
  self$add_columns_to_data(col_name, droplevels(self$get_columns_from_data(col_name, use_current_filter = FALSE)))
} 
)

data_object$set("public", "set_factor_levels", function(col_name, new_levels) {
  if(!col_name %in% names(self$get_data_frame(use_current_filter = FALSE))) stop(paste(col_name,"not found in data."))
  if(!is.factor(self$get_columns_from_data(col_name, use_current_filter = FALSE))) stop(paste(col_name,"is not a factor."))
  if(length(new_levels) < length(levels(self$get_columns_from_data(col_name, use_current_filter = FALSE)))) stop("There must be at least as many new levels as current levels.")
  
  # Must be private$data because setting an attribute
  levels(private$data[[col_name]]) <- new_levels
  self$data_changed <- TRUE
  self$variables_metadata_changed <- TRUE
} 
)

data_object$set("public", "edit_factor_level", function(col_name, old_level, new_level) {
  if(!col_name %in% names(self$get_data_frame(use_current_filter = FALSE))) stop(paste(col_name,"not found in data."))
  if(!is.factor(self$get_columns_from_data(col_name, use_current_filter = FALSE))) stop(paste(col_name,"is not a factor."))
  self$add_columns_to_data(col_name, mapvalues(x = self$get_columns_from_data(col_name, use_current_filter = FALSE), from = old_level, to = new_level))
  self$data_changed <- TRUE
  self$variables_metadata_changed <- TRUE
} 
)


data_object$set("public", "set_factor_reference_level", function(col_name, new_ref_level) {
  if(!col_name %in% names(self$get_data_frame(use_current_filter = FALSE))) stop(paste(col_name,"not found in data."))
  if(!is.factor(self$get_columns_from_data(col_name, use_current_filter = FALSE))) stop(paste(col_name,"is not a factor."))
  if(!new_ref_level %in% levels(self$get_columns_from_data(col_name, use_current_filter = FALSE))) stop(paste(new_ref_level, "is not a level of the factor"))
  
  self$add_columns_to_data(col_name, relevel(self$get_columns_from_data(col_name, use_current_filter = FALSE), new_ref_level))
} 
)

data_object$set("public", "reorder_factor_levels", function(col_name, new_level_names) {
  if(!col_name %in% names(self$get_data_frame(use_current_filter = FALSE))) stop(paste(col_name,"not found in data."))
  if(!is.factor(self$get_columns_from_data(col_name, use_current_filter = FALSE))) stop(paste(col_name,"is not a factor."))
  if(length(new_level_names)!=length(levels(self$get_columns_from_data(col_name, use_current_filter = FALSE)))) stop("Incorrect number of new level names given.")
  if(!all(new_level_names %in% levels(self$get_columns_from_data(col_name, use_current_filter = FALSE)))) stop(paste("new_level_names must be a reordering of the current levels:",paste(levels(data[[col_name]]), collapse = " ")))
  self$add_columns_to_data(col_name = col_name, col_data = factor(self$get_columns_from_data(col_name, use_current_filter = FALSE), levels = new_level_names, ordered = is.ordered(self$get_columns_from_data(col_name, use_current_filter = FALSE))))
  self$variables_metadata_changed <- TRUE
}
)

data_object$set("public", "get_column_count", function(col_name, new_level_names) {
  return(ncol(private$data))
}
)

data_object$set("public", "get_column_names", function(as_list = FALSE, include = list(), exclude = list(), excluded_items = c()) {
  if(data_type_label %in% names(include) && "numeric" %in% include[[data_type_label]]) {
    include[[data_type_label]] = c(include[[data_type_label]], "integer")
  }
  if(data_type_label %in% names(exclude) && "numeric" %in% exclude[[data_type_label]]) {
    exclude[[data_type_label]] = c(exclude[[data_type_label]], "integer")
  }
  
  col_names = names(self$get_data_frame(use_current_filter = FALSE))
  var_metadata = self$get_variables_metadata()
  out = c()
  for(col in col_names) {
    if(length(include) > 0 || length(exclude) > 0) {
      curr_var_metadata = var_metadata[col, ]
      if(all(c(names(include), names(exclude)) %in% names(curr_var_metadata)) && all(sapply(names(include), function(prop) curr_var_metadata[[prop]] %in% include[[prop]]))
         && all(sapply(names(exclude), function(prop) !curr_var_metadata[[prop]] %in% exclude[[prop]]))) {
        out <- c(out, col)
      }
    }
    else out <- c(out, col)
  }
  if(length(excluded_items) > 0) {
    ex_ind = which(out %in% excluded_items)
    if(length(ex_ind) != length(excluded_items)) warning("Some of the excluded_items were not found in the data")
    if(length(ex_ind) > 0) out = out[-ex_ind]
  }
  if(as_list) {
    lst = list()
    lst[[self$get_metadata(data_name_label)]] <- out
    return(lst)
  }
  else return(out)
}
)

#TODO: Are there other types needed here?
data_object$set("public", "get_data_type", function(col_name = "") {
  if(!(col_name %in% names(self$get_data_frame(use_current_filter = FALSE)))){
    stop(paste(col_name, "is not a column in", get_metadata(data_name_label)))
  }
  type = ""
  curr_col <- self$get_columns_from_data(col_name, use_current_filter = FALSE)
  if(is.character(curr_col)) {
    type = "character"
  }
  else if(is.logical(private$data[[col_name]])) {
    type = "logical"
  }
  else if(is.Date(private$data[[col_name]])){
    # #TODO
    #we can add options for other forms of dates serch as POSIXct, POSIXlt, Date, chron, yearmon, yearqtr, zoo, zooreg, timeDate, xts, its, ti, jul, timeSeries, and fts objects.
    type = "Date"
  }
  else if(is.numeric(private$data[[col_name]])) {
    #TODO vectors with integer values but stored as numeric will return numeric.
    #     Is that desirable?
    if(is.integer(private$data[[col_name]])) {
      if(all(private$data[[col_name]]>0)) {
        type = "positive integer"
      }
      else type = "integer"
    }
    else type = "numeric"
  }
  else if(is.factor(curr_col)) {
    if(length(levels(curr_col))==2) type = "two level factor"
    else if(length(levels(curr_col))>2) type = "multilevel factor"
    else type = "factor"
  }
  return(type)
}
)

data_object$set("public", "set_hidden_columns", function(col_names = c()) {
  if(length(col_names) == 0) self$unhide_all_columns()
  else {
    if(!all(col_names %in% self$get_column_names())) stop("Not all col_names found in data")
    
    self$append_to_variables_metadata(col_names, is_hidden_label, TRUE)
    hidden_cols = self$get_column_names()[!self$get_column_names() %in% col_names]
    self$append_to_variables_metadata(hidden_cols, is_hidden_label, FALSE)
  }
}
)

data_object$set("public", "unhide_all_columns", function() {
  self$append_to_variables_metadata(self$get_column_names(), is_hidden_label, FALSE)
}
)

data_object$set("public", "set_row_names", function(row_names) {
  if(missing(row_names)) row_names = 1:nrow(self$get_data_frame(use_current_filter = FALSE))
  if(length(row_names) != nrow(self$get_data_frame(use_current_filter = FALSE))) stop("row_names must be a vector of same length as the data")
  if(anyDuplicated(row_names) != 0) stop("row_names must be unique")
  rownames(private$data) <- row_names
  self$data_changed <- TRUE
}
)

data_object$set("public", "set_col_names", function(col_names) {
  if(missing(col_names)) col_names = 1:ncol(self$get_data_frame(use_current_filter = FALSE))
  if(length(col_names) != ncol(self$get_data_frame(use_current_filter = FALSE))) stop("col_names must be a vector of same length as the data")
  if(anyDuplicated(col_names) != 0) stop("col_names must be unique")
  names(private$data) <- make.names(col_names)
  self$data_changed <- TRUE
}
)

data_object$set("public", "get_row_names", function() {
  return(rownames(self$get_data_frame(use_current_filter = FALSE)))
}

)

data_object$set("public", "get_col_names", function() {
  return(names(self$get_data_frame(use_current_filter = FALSE)))
}

)
data_object$set("public", "get_dim_dataframe", function() {
  return(dim(self$get_data_frame(use_current_filter = FALSE)))
}

)

data_object$set("public", "set_protected_columns", function(col_names) {
  if(!all(col_names %in% self$get_column_names())) stop("Not all col_names found in data")
  
  self$append_to_variables_metadata(col_names, is_protected_label, TRUE)
  other_cols = self$get_column_names()[!self$get_column_names() %in% col_names]
  self$append_to_variables_metadata(other_cols, is_protected_label, FALSE)
}
)

data_object$set("public", "add_filter", function(filter, filter_name = "", replace = TRUE, set_as_current = FALSE, na.rm = TRUE, is_no_filter = FALSE) {
  if(missing(filter)) stop("filter is required")
  if(filter_name == "") filter_name = next_default_item("Filter", names(private$filters))
  
  for(condition in filter) {
    if(length(condition) != 3 || !all(sort(names(condition)) == c("column", "operation", "value"))) {
      stop("filter must be a list of conditions containing: column, operation and value")
    }
    if(!condition[["column"]] %in% names(self$get_data_frame(use_current_filter = FALSE))) stop(condition[["column"]], " not found in data.")
  }
  if(filter_name %in% names(private$filters) && !replace) {
    warning("A filter named ", filter_name, " already exists. It will not be replaced.")
  }
  else {
    if(filter_name %in% names(private$filters)) message("A filter named ", filter_name, " already exists. It will be replaced by the new filter.")
    filter_calc = calculation$new(type = "filter", filter_conditions = filter, name = filter_name, parameters = list(na.rm = na.rm, is_no_filter = is_no_filter))
    private$filters[[filter_name]] <- filter_calc
    self$append_to_changes(list(Added_filter, filter_name))
    if(set_as_current) {
      self$current_filter <- filter_calc
      self$data_changed <- TRUE
    }
  }
}
)

data_object$set("public", "get_current_filter", function() {
  return(private$.current_filter)
}
)

data_object$set("public", "set_current_filter", function(filter_name = "") {
  if(!filter_name %in% names(private$filters)) stop(filter_name, " not found.")
  self$current_filter <- private$filters[[filter_name]]
}
)

data_object$set("public", "get_filter_names", function(as_list = FALSE, include = list(), exclude = list(), excluded_items = c()) {
  out = names(private$filters)
  if(length(excluded_items) > 0) {
    ex_ind = which(out %in% excluded_items)
    if(length(ex_ind) != length(excluded_items)) warning("Some of the excluded_items were not found in the list of filters")
    if(length(ex_ind) > 0) out = out[-ex_ind]
  }
  if(as_list) {
    lst = list()
    lst[[self$get_metadata(data_name_label)]] <- out
    return(lst)
  }
  else return(out)
}
)

data_object$set("public", "get_filter", function(filter_name) {
  if(missing(filter_name)) return(private$filters)
  if(!filter_name %in% names(private$filters)) stop(filter_name, " not found.")
  return(private$filters[[filter_name]])
}
)

data_object$set("public", "get_filter_as_logical", function(filter_name) {
  curr_filter <- self$get_filter(filter_name)
  i = 1
  if(length(curr_filter$filter_conditions) ==  0) out <- rep(TRUE, nrow(self$get_data_frame(use_current_filter = FALSE)))
  else {
    result = matrix(nrow = nrow(self$get_data_frame(use_current_filter = FALSE)), ncol = length(curr_filter$filter_conditions))
    for(condition in curr_filter$filter_conditions) {
      func = match.fun(condition[["operation"]])
      # TODO Have better hanlding and dealing with NA values in filter
      # and special options for NA in the dialog
      if(condition[["operation"]] == "==" && is.na(condition[["value"]])) result[ ,i] <- is.na(self$get_columns_from_data(condition[["column"]], use_current_filter = FALSE))
      else if(condition[["operation"]] == "!=" && is.na(condition[["value"]])) result[ ,i] <- !is.na(self$get_columns_from_data(condition[["column"]], use_current_filter = FALSE))
      else if(is.na(condition[["value"]])) stop("Cannot create a filter on missing values with operation: ", condition[["operation"]])
      else result[ ,i] <- func(self$get_columns_from_data(condition[["column"]], use_current_filter = FALSE), condition[["value"]])
      i = i + 1
    }
    out <- apply(result, 1, all)
    out[is.na(out)] <- !curr_filter$parameters[["na.rm"]]
  }
  return(out)
}
)

data_object$set("public", "filter_applied", function() {
  return(!private$.current_filter$parameters[["is_no_filter"]])
}
)

data_object$set("public", "remove_current_filter", function() {
  self$set_current_filter("no_filter")
}
)

data_object$set("public", "filter_string", function(filter_name) {
  if(!filter_name %in% names(private$filters)) stop(filter_name, " not found.")
  curr_filter <- self$get_filter(filter_name)
  out = "("
  i = 1
  for(condition in curr_filter$filter_conditions) {
    if(i != 1) out = paste(out, "&&")
    out = paste0(out, " (", condition[["column"]], " ", condition[["operation"]])
    if(condition[["operation"]] == "%in%") out = paste0(out, " c(", paste(condition[["value"]], collapse = ","), ")")
    else out = paste(out, condition[["value"]])
    out = paste0(out , ")")
    i = i + 1
  }
  out = paste(out, ")")
  return(out)
}
)

data_object$set("public", "get_variables_metadata_fields", function(as_list = FALSE, include = c(), exclude = c(), excluded_items = c()) {
  out = names(self$get_variables_metadata())
  if(length(excluded_items) > 0){
    ex_ind = which(out %in% excluded_items)
    if(length(ex_ind) != length(excluded_items)) warning("Some of the excluded_items were not found in the list of objects")
    if(length(ex_ind) > 0) out = out[-ex_ind]
  }
  if(as_list) {
    lst = list()
    lst[[self$get_metadata(data_name_label)]] <- out
    return(lst)
  }
  else return(out)
}
)

data_object$set("public", "add_object", function(object, object_name) {
  if(missing(object_name)) object_name = next_default_item("object", names(private$objects))
  if(object_name %in% names(private$objects)) message("An object called ", object_name, " already exists. It will be replaced.")
  private$objects[[object_name]] <- object
  self$append_to_changes(list(Added_object, object_name))
}
)

data_object$set("public", "get_objects", function(object_name, type = "", force_as_list = FALSE) {
  curr_objects = private$objects[self$get_object_names(type = type)]
  if(length(curr_objects) == 0) return(curr_objects)
  if(missing(object_name)) return(curr_objects)
  if(!is.character(object_name)) stop("object_name must be a character")
  if(!all(object_name %in% names(curr_objects))) stop(object_name, " not found in objects")
  if(length(object_name) == 1) {
    if(force_as_list) return(curr_objects[object_name])
    else return(curr_objects[[object_name]])
  }
  else return(curr_objects[object_name])
}
)

data_object$set("public", "get_object_names", function(type = "", as_list = FALSE, excluded_items = c()) {
  if(type == "") out = names(private$objects)
  else {
    if(type == model_label) out = names(private$objects)[!sapply(private$objects, function(x) any(c("ggplot", "gg", "gtable", "grob") %in% class(x)))]
    else if(type == graph_label) out = names(private$objects)[sapply(private$objects, function(x) any(c("ggplot", "gg", "gtable", "grob") %in% class(x)))]
    else stop("type: ", type, " not recognised")
  }
  if(length(excluded_items) > 0) {
    ex_ind = which(out %in% excluded_items)
    if(length(ex_ind) != length(excluded_items)) warning("Some of the excluded_items were not found in the list of objects")
    if(length(ex_ind) > 0) out = out[-ex_ind]
  }
  if(as_list) {
    lst = list()
    lst[[self$get_metadata(data_name_label)]] <- out
    return(lst)
  }
  else return(out)
}
)

data_object$set("public", "rename_object", function(object_name, new_name) {
  if(!object_name %in% names(private$objects)) stop(object_name, " not found in objects list")
  if(new_name %in% names(private$objects)) stop(new_name, " is already an object name. Cannot rename ", object_name, " to ", new_name)
  names(private$objects)[names(private$objects) == object_name] <- new_name
}
)

data_object$set("public", "delete_objects", function(object_names) {
  if(!all(object_names %in% names(private$objects))) stop("Not all object_names found in objects list")
  private$objects[names(private$objects) == object_names] <- NULL
}
)

data_object$set("public", "reorder_objects", function(new_order) {
  if(length(new_order) != length(private$objects) || !setequal(new_order, names(private$objects))) stop("new_order must be a permutation of the current object names.")
  self$set_objects(private$objects[new_order])
}
)

data_object$set("public", "data_clone", function(include_objects = TRUE, include_metadata = TRUE, include_logs = TRUE, include_filters = TRUE, include_calculations = TRUE) {
  if(include_objects) new_objects <- private$objects
  else new_objects <- list()
  if(include_filters) new_filters <- lapply(private$filters, function(x) x$data_clone())
  else new_filters <- list()
  if(include_calculations) new_calculations <- lapply(private$calculations, function(x) x$data_clone())
  else new_calculations <- list()
  
  ret <- data_object$new(data = private$data, data_name = self$get_metadata(data_name_label), filters = new_filters, objects = new_objects, calculations = new_calculations, keys = private$keys, keep_attributes = include_metadata)
  if(include_logs) ret$set_changes(private$changes)
  else ret$set_changes(list())
  if(include_filters) ret$current_filter <- self$get_current_filter()
  else {
    ret$remove_current_filter()
  }
  if(!include_metadata) {
    self$clear_metadata()
    self$clear_variables_metadata()
  }
  ret$data_changed <- TRUE
  ret$metadata_changed <- TRUE
  ret$variables_metadata_changed <- TRUE
  return(ret)
}
)

data_object$set("public", "freeze_columns", function(column) {
  self$unfreeze_columns()
  self$append_to_variables_metadata(column, is_frozen_label, TRUE)
}
)

data_object$set("public", "unfreeze_columns", function() {
  self$append_to_variables_metadata(self$get_column_names(), is_frozen_label, FALSE)
}
)

#TODO maybe get ride of this method as that you can't create a key without
#     the instat object also creating a self link
data_object$set("public", "add_key", function(col_names, key_name) {
  if(anyDuplicated(self$get_columns_from_data(col_names, use_current_filter = FALSE)) > 0) {
    stop("key columns must have unique combinations")
  }
  if(sum(is.na(self$get_columns_from_data(col_names, use_current_filter = FALSE))) > 0) {
    stop("key columns cannot have missing values")
  }
  if(self$is_key(col_names)) {
    message("A key with these columns already exists. No action will be taken.")
  }
  else {
    if(missing(key_name)) key_name <- next_default_item("key", names(private$keys))
    if(key_name %in% names(private$keys)) warning("A key called ", key_name, " already exists. It wil be replaced.")
    private$keys[[key_name]] <- col_names
    self$append_to_variables_metadata(col_names, is_key_label, TRUE)
    if(length(private$keys) == 1) self$append_to_variables_metadata(setdiff(self$get_column_names(), col_names), is_key_label, FALSE)
    self$append_to_metadata(is_linkable, TRUE)
    self$append_to_metadata(next_default_item(key_label, names(self$get_metadata())), paste(col_names, collapse = ","))
  }
}
)

data_object$set("public", "is_key", function(col_names) {
  return(any(sapply(private$keys, function(x) setequal(col_names,x))))
}
)

data_object$set("public", "has_key", function() {
  return(length(private$keys) > 0)
}
)

data_object$set("public", "get_keys", function(key_name) {
  if(!missing(key_name)) {
    if(!key_name %in% names(private$keys)) stop(key_name, " not found.")
    return(private$keys[[key_name]])
  }
  else return(private$keys)
}
)

data_object$set("public", "remove_key", function(key_name) {
  if(!key_name %in% names(private$keys)) stop(key_name, " not found.")
  private$keys[[key_name]] <- NULL
}
)

data_object$set("public", "set_structure_columns", function(struc_type_1, struc_type_2, struc_type_3) {
  if(!all(c(struc_type_1,struc_type_2,struc_type_3) %in% names(self$get_data_frame(use_current_filter = FALSE)))) stop("Some column names not recognised.")
  if(length(intersect(struc_type_1,struc_type_2)) > 0 || length(intersect(struc_type_1,struc_type_3)) > 0 || length(intersect(struc_type_2,struc_type_3)) > 0) {
    stop("Each column can only be assign one structure type.")
  }
  if(length(struc_type_1) > 0) self$append_to_variables_metadata(struc_type_1, structure_label, structure_type_1_label)
  if(length(struc_type_2) > 0) self$append_to_variables_metadata(struc_type_2, structure_label, structure_type_2_label)
  if(length(struc_type_3) > 0) self$append_to_variables_metadata(struc_type_3, structure_label, structure_type_3_label)
  all <- union(union(struc_type_1, struc_type_2), struc_type_3)
  other <- setdiff(names(self$get_data_frame(use_current_filter = FALSE)), all)
  self$append_to_variables_metadata(other, structure_label, NA)
}
)

data_object$set("public", "add_dependent_columns", function(columns, dependent_cols) {
  for(col in columns) {
    if(self$is_variables_metadata(dependent_columns_label, col)) {
      curr_dependents <- self$get_variables_metadata(property = dependent_columns_label, column = col, direct_from_attributes = TRUE)
      for(data_frame in names(dependent_cols)) {
        if(data_frame %in% names(curr_dependents)) {
          curr_dependents[[data_frame]] <- union(curr_dependents[[data_frame]], dependent_cols[[data_frame]])
        }
        else {
          curr_dependents[[data_frame]] <- dependent_cols[[data_frame]]
        }
      }
    }
    else curr_dependents <- as.list(dependent_cols)
    self$append_to_variables_metadata(col, dependent_columns_label, curr_dependents)
  }
}
)

data_object$set("public", "set_column_colours", function(columns, colours) {
  if(missing(columns)) columns <- names(self$get_data_frame(use_current_filter = TRUE))
  if(length(columns) != length(colours)) stop("columns must be the same length as colours")
  
  for(i in 1:length(columns)) {
    self$append_to_variables_metadata(columns[i], colour_label, colours[i])
  }
  other_cols <- self$get_column_names()[!self$get_column_names() %in% columns]
  self$append_to_variables_metadata(other_cols, colour_label, -1)
}
)

data_object$set("public", "has_colours", function(columns) {
  return(self$is_variables_metadata(str = colour_label))
}
)

data_object$set("public", "set_column_colours_by_metadata", function(columns, property) {
  if(missing(columns)) property_values <- self$get_variables_metadata(property = property)
  else property_values <- self$get_variables_metadata(property = property, column = columns)
  
  new_colours <- as.numeric(as.factor(property_values))
  new_colours[is.na(new_colours)] <- -1
  if(missing(columns)) self$set_column_colours(colours = new_colours)
  else self$set_column_colours(columns = columns, colours = new_colours)
}
)

data_object$set("public", "remove_column_colours", function() {
  if(self$is_variables_metadata(str = colour_label)) {
    self$append_to_variables_metadata(property = colour_label, new_val = -1)
  }
}
)

data_object$set("public", "graph_one_variable", function(columns, numeric = "geom_boxplot", categorical = "geom_bar", output = "facets", free_scale_axis = FALSE, ncol = NULL, coord_flip = FALSE, ...) {
  if(!all(columns %in% self$get_column_names())) {
    stop("Not all columns found in the data")
  }
  if(!output %in% c("facets", "combine", "single")) {
    stop("output must be one of: facets, combine or single")
  }
  if(!numeric %in% c("box_jitter", "violin_jitter", "violin_box")) {
    numeric_geom <- match.fun(numeric)
  }
  else {
    numeric_geom <- numeric
  }
  if(categorical %in% c("pie_chart")) {
    cat_geom <- categorical
  }
  else {
    cat_geom <- match.fun(categorical)
  }
  curr_data <- self$get_data_frame()
  column_types <- c()
  for(col in columns) {
    # TODO this could be method to avoid needing to get full data frame in this method
    # Everything non numeric is treated as categorical
    if(is.numeric(curr_data[[col]])) {
      column_types <- c(column_types, "numeric")
    }
    else {
      column_types <- c(column_types, "cat")
    }
  }
  if(output == "facets") {
    if(length(column_types) > 1) {
      warning("Cannot do facets with graphs of different types. Combine graphs will be used instead.")
      output <- "combine"
    }
    else column_types <- unique(column_types)
  }
  if(output == "facets") {
    if(column_types == "numeric") {
      curr_geom <- numeric_geom
      curr_geom_name <- numeric
    }
    else if(column_types == "cat") {
      curr_geom <- cat_geom
      curr_geom_name <- categorical
    }
    else {
      stop("Cannot plot columns of type:", column_types[i])
    }    
    curr_data <- self$get_data_frame(stack_data = TRUE, measure.vars = columns)
    if(curr_geom_name == "geom_boxplot" || curr_geom_name == "geom_point" || curr_geom_name == "geom_jitter" || curr_geom_name == "box_jitter" || curr_geom_name == "violin_jitter" || curr_geom_name == "violin_box") {
      g <- ggplot(data = curr_data, mapping = aes(x = "", y = value)) + xlab("")
    }
    else {
      g <- ggplot(data = curr_data, mapping = aes(x = value)) + ylab("")
    }
    
    if(curr_geom_name == "box_jitter") {
      g <- g + geom_boxplot() + geom_jitter() 
    }
    else if(curr_geom_name == "violin_jitter") {
      g <- g + geom_violin() + geom_jitter() 
    }
    else if(curr_geom_name == "violin_box") {
      g <- g + geom_violin() + geom_boxplot() 
    }
    else if(curr_geom_name == "pie_chart") {
      g <- g + geom_bar() + coord_polar(theta = "x")
    }
    else {
      g <- g + curr_geom()
    }

    if (coord_flip) {
      g <- g + coord_flip()
    }   
    if(free_scale_axis) {
      g <- g + facet_wrap(facets = ~ variable, scales = "free", ncol = ncol)
    }
    else { 
      g <- g + facet_wrap(facets = ~ variable, scales = "free_x", ncol = ncol)
    }
    
    return(g)    
  }
  else {
    graphs <- list()
    i = 1
    for(column in columns) {
      if(column_types[i] == "numeric") {
        curr_geom <- numeric_geom
        curr_geom_name <- numeric
      }
      else if(column_types[i] == "cat") {
        curr_geom <- cat_geom
        curr_geom_name <- categorical
      }
      else {
        stop("Cannot plot columns of type:", column_types[i])
      }
      if(curr_geom_name == "geom_boxplot" || curr_geom_name == "geom_point" || curr_geom_name == "box_jitter" || curr_geom_name == "violin_jitter" || curr_geom_name == "violin_box") {
        g <- ggplot(data = curr_data, mapping = aes_(x = "", y = as.name(column))) + xlab("")
      }
      else {
        g <- ggplot(data = curr_data, mapping = aes_(x = as.name(column))) + ylab("")
      }
      if (coord_flip) {
        g <- g + coord_flip()
      } 
      if(curr_geom_name == "box_jitter") {
        g <- g + geom_boxplot() + geom_jitter()
      }
      else if(curr_geom_name == "violin_jitter") {
        g <- g + geom_violin() + geom_jitter()
      }
      else if(curr_geom_name == "violin_box") {
        g <- g + geom_violin() + geom_boxplot()
      }
      else if(curr_geom_name == "pie_chart") {
        g <- g + geom_bar() + coord_polar(theta = "x")
      }
      else {
        g <- g + curr_geom()
      }
      graphs[[i]] <- g
      i = i + 1
    }
    if(output == "combine") {
      return(gridExtra::grid.arrange(grobs = graphs, ncol = ncol))
    }
    else {
      return(graphs)
    }
  }
}
)

data_object$set("public","make_date_yearmonthday", function(year, month, day, year_format = "%Y", month_format = "%m", day_format = "%d") {
  year_col <- self$get_columns_from_data(year, use_current_filter = FALSE)
  month_col <- self$get_columns_from_data(month, use_current_filter = FALSE)
  day_col <- self$get_columns_from_data(day, use_current_filter = FALSE)
  if(missing(year_format)) {
    year_counts <- str_count(year)
    if(anyDuplicated(year_counts) != 0) stop("Year column has inconsistent year formats")
    else {
      year_length <- year_counts[1]
      if(year_length == 2) year_format = "%y"
      else if(year_length == 4) year_format = "%Y"
      else stop("Cannot detect year format with ", year_length, " digits.")
    }
  }
  if(missing(month_format)) {
    if(all(month %in% month.name)) month_format = "%B"
    else if(all(month %in% month.abb)) month_format = "%b"
    else if(all(month %in% 1:12)) month_format = "%m"
    else stop("Cannot detect month format")
  }
  if(missing(day_format)) {
    #TODO
  }
  return(as.Date(paste(year_col, month_col, day_col), format = paste(year_format, month_format, day_format)))
}
)

# Not sure if doy_format should be a parameter? There seems to only be one format for it.
data_object$set("public","make_date_yeardoy", function(year, doy, year_format = "%Y", doy_format = "%j", doy_typical_length = "366") {
  year_col <- self$get_columns_from_data(year, use_current_filter = FALSE)
  doy_col <- self$get_columns_from_data(doy, use_current_filter = FALSE)
  
  if(missing(year_format)) {
    year_counts <- str_count(year)
    if(anyDuplicated(year_counts) != 0) stop("Year column has inconsistent year formats")
    else {
      year_length <- year_counts[1]
      if(year_length == 2) year_format = "%y"
      else if(year_length == 4) year_format = "%Y"
      else stop("Cannot detect year format with ", year_length, " digits.")
    }
  }
  if(doy_typical_length == "366") {
    if(is.factor(year_col)) {
      year_col <- as.numeric(levels(year_col))[year_col]
    }
    doy_col[(!leap_year(year_col)) & doy_col > 60] <- doy_col[(!leap_year(year_col)) & doy_col > 60] - 1
  }
  return(temp_date <- as.Date(paste(year_col, doy_col), format = paste(year_format, doy_format)))
}
)

data_object$set("public","set_contrasts_of_factor", function(col_name, new_contrasts, defined_contr_matrix) {
  if(!col_name %in% names(self$get_data_frame())) stop(col_name, " not found in the data")
  if(!is.factor(self$get_columns_from_data(col_name))) stop(factor, " is not a factor column.")
  factor_col <- self$get_columns_from_data(col_name)
  contr_col <- nlevels(factor_col) - 1
  contr_row <- nlevels(factor_col)
  if(new_contrasts == "user_defined") {
    if(any(is.na(defined_contr_matrix)) ||!is.numeric(defined_contr_matrix) ||nrow(defined_contr_matrix) != contr_row || ncol(defined_contr_matrix) != contr_col) stop(paste0("The contrast matrix should have ", contr_col, " column(s) and ",  contr_row, " row(s) "))
    }
    #checks needed on contrasts before assigning
    if(!(new_contrasts %in% c("contr.treatment", "contr.helmert", "contr.poly", "contr.sum", "user_defined"))) {
    stop(new_contrasts, " is not a valid contrast name")
  } 
  else if(!is.character(new_contrasts)) {
    stop("New column name must be of type: character")
  }
       contrasts(private$data[[col_name]]) <- new_contrasts
  }
)
#This method gets a date column and extracts part of the information such as year, month, week, weekday etc(depending on which parameters are set) and creates their respective new column(s)
data_object$set("public","split_date", function(data_name, col_name = "", week = FALSE, month_val = FALSE, month_abbr = FALSE, month_name = FALSE, weekday_val = FALSE, weekday_abbr = FALSE, weekday_name = FALSE, year = FALSE, day = FALSE, day_in_month = FALSE, day_in_year = FALSE, leap_year = FALSE, day_in_year_366 = FALSE, dekade = FALSE, pentad = FALSE) {
  col_data <- self$get_columns_from_data(col_name, use_current_filter = FALSE)
  if(!is.Date(col_data)) stop("This column must be a date or time!")
  if(day) {
    day_vector <- day(col_data)
	  col_name <- next_default_item(prefix = "day", existing_names = self$get_column_names(), include_index = FALSE)
    self$add_columns_to_data(col_name = col_name, col_data = day_vector)
  }
  if(week) {
    week_vector <- as.integer(week(col_data))
	  col_name <- next_default_item(prefix = "week", existing_names = self$get_column_names(), include_index = FALSE)
    self$add_columns_to_data(col_name = col_name, col_data = week_vector)
  }
  if(weekday_val) {
    weekday_val_vector <- as.integer(wday(col_data))
	  col_name <- next_default_item(prefix = "weekday_val", existing_names = self$get_column_names(), include_index = FALSE)
    self$add_columns_to_data(col_name = col_name, col_data = weekday_val_vector)
  }
  if(weekday_abbr) {
    weekday_abbr_vector <- wday(col_data, label = TRUE)
	  col_name <- next_default_item(prefix = "weekday_abbr", existing_names = self$get_column_names(), include_index = FALSE)
    self$add_columns_to_data(col_name = col_name, col_data = weekday_abbr_vector)
  }
  if(weekday_name) {
    weekday_name_vector <- wday(col_data, label = TRUE, abbr = FALSE)
	  col_name <- next_default_item(prefix = "weekday_name", existing_names = self$get_column_names(), include_index = FALSE)
    self$add_columns_to_data(col_name = col_name, col_data = weekday_name_vector)
  }
  if(month_val) {
    month_val_vector <- as.integer(month(col_data))
	  col_name <- next_default_item(prefix = "month_val", existing_names = self$get_column_names(), include_index = FALSE)
    self$add_columns_to_data(col_name = col_name, col_data = month_val_vector)
  }
  if(month_abbr) {
    month_abbr_vector <- month(col_data, label = TRUE)
	  col_name <- next_default_item(prefix = "month_abbr", existing_names = self$get_column_names(), include_index = FALSE)
    self$add_columns_to_data(col_name = col_name, col_data = month_abbr_vector)
  }
  if(month_name) {
    month_name_vector <- month(col_data, label = TRUE, abbr = FALSE)
	  col_name <- next_default_item(prefix = "month_name", existing_names = self$get_column_names(), include_index = FALSE)
    self$add_columns_to_data(col_name = col_name, col_data = month_name_vector)
  }
  if(year) {
    year_vector <- year(col_data)
	  col_name <- next_default_item(prefix = "year", existing_names = self$get_column_names(), include_index = FALSE)
    self$add_columns_to_data(col_name = col_name, col_data = year_vector)
  }
  if(day_in_month) {
    day_in_month_vector <- as.integer(mday(col_data))
	  col_name <- next_default_item(prefix = "day_in_month", existing_names = self$get_column_names(), include_index = FALSE)
    self$add_columns_to_data(col_name = col_name, col_data = day_in_month_vector)
	}
	if(day_in_year) {
    day_in_year_vector <- as.integer(yday(col_data))
	  col_name <- next_default_item(prefix = "day_in_year", existing_names = self$get_column_names(), include_index = FALSE)
    self$add_columns_to_data(col_name = col_name, col_data = day_in_year_vector)
	}
	if(day_in_year_366) {
    day_in_year_366_vector <- as.integer(yday_366(col_data))
	  col_name <- next_default_item(prefix = "doy_366", existing_names = self$get_column_names(), include_index = FALSE)
    self$add_columns_to_data(col_name = col_name, col_data = day_in_year_366_vector)
	}
  if(dekade) {
    dekade_vector <- as.integer(dekade(col_data))
    col_name <- next_default_item(prefix = "dekade", existing_names = self$get_column_names(), include_index = FALSE)
    self$add_columns_to_data(col_name = col_name, col_data = dekade_vector)
  }
  if(pentad) {
    pentad_vector <- as.integer(pentad(col_data))
    col_name <- next_default_item(prefix = "pentad", existing_names = self$get_column_names(), include_index = FALSE)
    self$add_columns_to_data(col_name = col_name, col_data = pentad_vector)
  }
	if(leap_year) {
    leap_year_vector <- leap_year(col_data)
	  col_name <- next_default_item(prefix = "leap_year", existing_names = self$get_column_names(), include_index = FALSE)
    self$add_columns_to_data(col_name = col_name, col_data = leap_year_vector)
	}
}
)


#TODO These should go in a separate climatic file
#************************************************
# labels for climatic column types
rain_label="rain"
rain_day_label="rain_day"
rain_day_lag_label="rain_day_lag"
date_label="date"
doy_label="doy"
year_label="year"
year_month_label="year_month"
date_time_label="date_time"
dos_label="dos" ##Day of Season
season_label="season"
month_label="month"
day_label="day"
dm_label="day_month"
time_label="time"
station_label="station"
date_asstring_label="date_asstring"
temp_min_label="temp_min"
temp_max_label="temp_max"
temp_air_label="temp_air"
temp_range_label="temp_range"
wet_buld_label="wet_bulb"
dry_bulb_label="dry_buld"
evaporation_label="evaporation"
element_factor_label="element_type"
identifier_label = "identifier"
capacity_label = "capacity_max"
wind_speed_label="wind_speed"
wind_direction_label="wind_direction"
lat_label="lat"
lon_label="lon"
alt_label="alt"
season_station_label="season_station"
date_station_label="date_station"
sunshine_hours_label="sunshine_hours"
radiation_label="radiation"
cloud_cover_label="cloud_cover"

all_climatic_column_types <- c(rain_label, rain_day_label, rain_day_lag_label, date_label, doy_label, year_label, year_month_label, date_time_label, dos_label, season_label, month_label, day_label, dm_label, time_label, station_label, date_asstring_label, temp_min_label, temp_max_label, temp_air_label, temp_range_label, wet_buld_label, dry_bulb_label, evaporation_label, element_factor_label, identifier_label, capacity_label, wind_speed_label, wind_direction_label, lat_label, lon_label, alt_label, season_station_label, date_station_label, sunshine_hours_label, radiation_label, cloud_cover_label)

# Column metadata
climatic_type_label = "Climatic_Type"

# Data frame metadata
is_climatic_label = "Is_Climatic"

instat_object$set("public","define_as_climatic", function(data_name, types) {
  self$append_to_dataframe_metadata(data_name, is_climatic_label, TRUE)
  for(curr_data_name in self$get_data_names()) {
    if(!self$get_data_objects(data_name)$is_metadata(is_climatic_label)) {
      self$append_to_dataframe_metadata(curr_data_name, is_climatic_label, FALSE)
    }
  }
  self$get_data_objects(data_name)$set_climatic_types(types)
}
)

data_object$set("public","set_climatic_types", function(types) {
  if(!all(names(types) %in% all_climatic_column_types)) stop("Cannot recognise the following climatic types: ", paste(names(types)[!names(types) %in% all_climatic_column_types], collapse = ", "))
  invisible(sapply(names(types), function(name) self$append_to_variables_metadata(types[name], climatic_type_label, name)))
}
)

#Method for creating inventory plot
data_object$set("public","make_inventory_plot", function(year, doy, col_name, add_to_data = FALSE, coord_flip = FALSE, threshold, facets) {
  curr_data <- self$get_data_frame()
  col_data <- self$get_columns_from_data(col_name)
  if(!is.numeric(col_data)) stop("The rainfall column should be numeric")
  recode <- ifelse(is.na(col_data), "missing", ifelse(col_data>threshold, "rain", "dry"))
  recode <- as.factor(recode)
  new_col <- next_default_item(prefix = "recode", existing_names = self$get_column_names(), include_index = FALSE)
  curr_data[[new_col]] <- recode
  if(add_to_data) {
    self$add_columns_to_data(col_name = new_col, col_data = recode)
  }
  
  g <- ggplot(data = curr_data, mapping = aes_(x = as.name(year), y = as.name(doy), colour = as.name(new_col), group = as.name(year))) + geom_point() + xlab(year) + ylab(col_name) + labs(color="Recode")
  if(!missing(facets)) {
    g <- g + facet_wrap(as.name(facets))
  }
  if(coord_flip) {
    g <- g + coord_flip()
  }
  return(g)
}
)

data_object$set("public","infill_missing_dates", function(date_name, factors) {
  date_col <- self$get_columns_from_data(date_name)
  if(!is.Date(date_col)) stop(date_name, " is not a Date column.")
  if(anyNA(date_col)) stop("Cannot do infilling as date column has missing values")
  if(missing(factors)) {
    if(anyDuplicated(date_col) > 0) stop("Cannot do infilling as date column has duplicate values.")
    min <- min(date_col)
    max <- max(date_col)
    full_dates <- seq(min, max, by = "day")
    if(length(full_dates) > length(date_col)) {
      message("Attempting to infill ", (length(full_dates) - length(date_col)), " missing dates...")
      full_dates <- data.frame(full_dates)
      names(full_dates) <- date_name
      self$merge_data(full_dates, by = date_name, type = "full")
      message("Missing dates infilled.")
      self$sort_dataframe(col_names = date_name)
    }
  }
  else {
    merge_required <- FALSE
    col_names_exp <- c()
    for(i in seq_along(factors)) {
      col_name <- factors[i]
      col_names_exp[[i]] <- interp(~ var, var = as.name(col_name))
    }
    grouped_data <- self$get_data_frame(use_current_filter = FALSE) %>% group_by_(.dots = col_names_exp)
    date_ranges <- grouped_data %>% summarise_(.dots = setNames(list(interp(~ min(var), var = as.name(date_name)), interp(~ max(var), var = as.name(date_name))), c("Min", "Max")))
    date_lengths <- grouped_data %>% summarise(Count = n())
    print(date_lengths)
    full_dates_list <- list()
    for(j in 1:nrow(date_ranges)) {
      full_dates <- seq(date_ranges$Min[j], date_ranges$Max[j], by = "day")
      if(length(full_dates) > date_lengths[[2]][j]) {
        message("Attempting to infill ", (length(full_dates) - date_lengths[[2]][j]), " missing dates for ", paste(unlist(date_ranges[1:length(factors)][j, ]), collapse = "-"))
        merge_required <- TRUE
      }
      full_dates <- data.frame(full_dates)
      names(full_dates) <- date_name
      for(k in seq_along(factors)) {
        full_dates[[factors[k]]] <- date_ranges[[k]][j]
      }
      full_dates_list[[j]] <- full_dates
    }
    if(merge_required) {
      all_dates_factors <- rbind.fill(full_dates_list)
      self$merge_data(all_dates_factors, by = c(date_name, factors), type = "full")
      self$sort_dataframe(col_names = c(date_name, factors))
    }
  }
}
)

data_object$set("public","get_key_names", function(include_overall = TRUE, include, exclude, include_empty = FALSE, as_list = FALSE, excluded_items = c()) {
  key_names <- names(private$keys)
  if(as_list) {
    out <- list()
    out[[self$get_metadata(data_name_label)]] <- key_names
  }
  else out <- key_names
  return(out)
}
)

# Labels for climatic column types
### Primary corruption column types
corruption_country_label="country"
corruption_region_label="region"
corruption_procuring_authority_label="procuring_authority"
corruption_award_date_label="award_date"
corruption_fiscal_year_label="fiscal_year"
corruption_signature_date_label="signature_date"
corruption_contract_title_label="contract_title"
corruption_contract_sector_label="contract_sector"
corruption_procurement_category_label="procurement_category"
corruption_winner_name_label="winner_name"
corruption_winner_country_label="winner_country"
corruption_original_contract_value_label="original_contract_value"
corruption_no_bids_received_label="no_bids_received"
corruption_no_bids_considered_label="no_bids_considered"
corruption_method_type_label="method_type"

all_primary_corruption_column_types <- c(corruption_country_label,
                                         corruption_region_label,
                                         corruption_procuring_authority_label,
                                         corruption_award_date_label,
                                         corruption_fiscal_year_label,
                                         corruption_signature_date_label,
                                         corruption_contract_title_label,
                                         corruption_contract_sector_label,
                                         corruption_procurement_category_label,
                                         corruption_winner_name_label,
                                         corruption_winner_country_label,
                                         corruption_original_contract_value_label,
                                         corruption_no_bids_received_label,
                                         corruption_no_bids_considered_label,
                                         corruption_method_type_label)

### Calculated corruption column types
corruption_award_year_label="award_year"
corruption_procedure_type_label="procedure_type"
corruption_country_iso2_label="country_iso2"
corruption_country_iso3_label="country_iso3"
corruption_w_country_iso2_label="w_country_iso2"
corruption_w_country_iso3_label="w_country_iso3"
corruption_procuring_authority_id_label="procuring_authority_id"
corruption_winner_id_label="winner_id"
corruption_foreign_winner_label="foreign_winner"
corruption_ppp_conversion_rate_label="ppp_conversion_rate"
corruption_ppp_adjusted_contract_value_label="ppp_adjusted_contr_value"
corruption_contract_value_cats_label="contr_value_cats"
corruption_procurement_type_cats_label="procurement_type_cats"
corruption_procurement_type_2_label="procurement_type2"
corruption_procurement_type_3_label="procurement_type3"
corruption_signature_period_label="signature_period"
corruption_signature_period_corrected_label="signature_period_corrected"
corruption_signature_period_5Q_label="signature_period5Q"
corruption_signature_period_25Q_label="signature_period25Q"
corruption_signature_period_cats_label="signature_period_cats"
corruption_secrecy_score_label="secrecy_score"
corruption_tax_haven_label="tax_haven"
corruption_tax_haven2_label="tax_haven2"
corruption_tax_haven3_label="tax_haven3"
corruption_tax_haven3bi_label="tax_haven3bi"
corruption_roll_num_winner_label="roll_num_winner"
corruption_roll_num_issuer_label="roll_num_issuer"
corruption_roll_sum_winner_label="roll_sum_winner"
corruption_roll_sum_issuer_label="roll_sum_issuer"
corruption_roll_share_winner_label="roll_share_winner"
corruption_single_bidder_label="single_bidder"
corruption_all_bids_label="all_bids"
corruption_all_bids_trimmed_label="all_bids_trimmed"
corruption_contract_value_share_over_threshold_label="contract_value_share_over_threshold"

all_calculated_corruption_column_types <- c(corruption_award_year_label,
                                            corruption_procedure_type_label,
                                            corruption_country_iso2_label,
                                            corruption_country_iso3_label,
                                            corruption_w_country_iso2_label,
                                            corruption_w_country_iso3_label,
                                            corruption_procuring_authority_id_label,
                                            corruption_winner_id_label,
                                            corruption_procedure_type_label,
                                            corruption_foreign_winner_label,
                                            corruption_ppp_conversion_rate_label,
                                            corruption_ppp_adjusted_contract_value_label,
                                            corruption_contract_value_cats_label,
                                            corruption_procurement_type_cats_label,
                                            corruption_procurement_type_2_label,
                                            corruption_procurement_type_3_label,
                                            corruption_signature_period_label,
                                            corruption_signature_period_corrected_label,
                                            corruption_signature_period_5Q_label,
                                            corruption_signature_period_25Q_label,
                                            corruption_signature_period_cats_label,
                                            corruption_secrecy_score_label,
                                            corruption_tax_haven_label,
                                            corruption_tax_haven2_label,
                                            corruption_tax_haven3_label,
                                            corruption_tax_haven3bi_label,
                                            corruption_roll_num_winner_label,
                                            corruption_roll_num_issuer_label,
                                            corruption_roll_sum_winner_label,
                                            corruption_roll_sum_issuer_label,
                                            corruption_roll_share_winner_label,
                                            corruption_single_bidder_label,
                                            corruption_all_bids_label,
                                            corruption_all_bids_trimmed_label,
                                            corruption_contract_value_share_over_threshold_label
                                            )

corruption_ctry_iso2_label="iso2"
corruption_ctry_iso3_label="iso3"
corruption_ctry_wb_ppp_label="wb_ppp"
corruption_ctry_ss_2009_label="ss_2009"
corruption_ctry_ss_2011_label="ss_2011"
corruption_ctry_ss_2013_label="ss_2013"
corruption_ctry_ss_2015_label="ss_2015"
corruption_ctry_small_state_label="small_state"

all_primary_corruption_country_level_column_types <- c(corruption_ctry_iso2_label,
                                                       corruption_ctry_iso3_label,
                                                       corruption_ctry_wb_ppp_label,
                                                       corruption_ctry_ss_2009_label,
                                                       corruption_ctry_ss_2011_label,
                                                       corruption_ctry_ss_2013_label,
                                                       corruption_ctry_ss_2015_label,
                                                       corruption_ctry_small_state_label
                                                       )

# Column metadata for corruption colums
corruption_type_label = "Corruption_Type"

# Data frame metadata for corruption dataframes
is_corruption_label = "Is_Corruption"

instat_object$set("public","define_as_corruption", function(data_name, primary_types = c(), calculated_types = c(), auto_generate = TRUE) {
  self$append_to_dataframe_metadata(data_name, is_corruption_label, TRUE)
  for(curr_data_name in self$get_data_names()) {
    if(!self$get_data_objects(data_name)$is_metadata(is_corruption_label)) {
      self$append_to_dataframe_metadata(curr_data_name, is_corruption_label, FALSE)
    }
  }
  self$get_data_objects(data_name)$set_corruption_types(primary_types, calculated_types, auto_generate)
}
)

instat_object$set("public","define_as_corruption_country_level_data", function(data_name, contract_level_data_name, types = c(), auto_generate = TRUE) {
  self$get_data_objects(data_name)$define_as_corruption_country_level_data(types, auto_generate)
}
)

data_object$set("public","define_as_corruption_country_level_data", function(contract_level_data_name, types = c(), auto_generate = TRUE) {
  invisible(sapply(names(primary_types), function(x) self$append_to_variables_metadata(primary_types[[x]], corruption_type_label, x)))
}
)

data_object$set("public","is_corruption_type_present", function(type) {
  return(self$is_metadata(is_corruption_label) && self$get_metadata(is_corruption_label) && self$is_variables_metadata(corruption_type_label) && (type %in% self$get_variables_metadata(property = corruption_type_label)))
}
)

instat_object$set("public","get_corruption_column_name", function(data_name, type) {
  self$get_data_objects(data_name)$get_corruption_column_name(type)
}
)

data_object$set("public","get_corruption_column_name", function(type) {
  if(self$is_corruption_type_present(type)) {
    var_metadata <- self$get_variables_metadata()
    col_name <- var_metadata[!is.na(var_metadata[[corruption_type_label]]) & var_metadata[[corruption_type_label]] == type, name_label]
    if(length(col_name >= 1)) return(col_name)
    else return("")
  }
  return("")
}
)

data_object$set("public","set_corruption_types", function(primary_types = c(), calculated_types = c(), auto_generate = TRUE) {
  if(!all(names(primary_types) %in% all_primary_corruption_column_types)) stop("Cannot recognise the following primary corruption data types: ", paste(names(primary_types)[!names(primary_types) %in% all_primary_corruption_column_types], collapse = ", "))
  if(!all(names(calculated_types) %in% all_calculated_corruption_column_types)) stop("Cannot recognise the following calculated corruption data types: ", paste(names(calculated_types)[!names(calculated_types) %in% all_calculated_corruption_column_types], collapse = ", "))
  invisible(sapply(names(primary_types), function(x) self$append_to_variables_metadata(primary_types[[x]], corruption_type_label, x)))
  invisible(sapply(names(calculated_types), function(x) self$append_to_variables_metadata(calculated_types[[x]], corruption_type_label, x)))
  if(auto_generate) {
    # Tried to make these independent of order called, but need to test
    self$generate_award_year()
    self$generate_procedure_type()
    self$generate_procuring_authority_id()
    self$generate_winner_id()
    self$generate_foreign_winner()
    self$generate_procurement_type_categories()
    self$generate_procurement_type_2()
    self$generate_procurement_type_3()
    self$generate_signature_period()
    self$generate_signature_period_corrected()
    self$generate_signature_period_5Q()
    self$generate_signature_period_25Q()
    self$generate_rolling_contract_no_winners()
    self$generate_rolling_contract_no_issuer()
    self$generate_rolling_contract_value_sum_issuer()
    self$generate_rolling_contract_value_sum_winner()
    self$generate_rolling_contract_value_share_winner()
    self$generate_single_bidder()
    self$generate_contract_value_share_over_threshold()
    self$generate_all_bids()
    self$generate_all_bids_trimmed()
  }
}
)

data_object$set("public","generate_award_year", function() {
  if(!self$is_corruption_type_present(corruption_award_year_label)) {
    if(!self$is_corruption_type_present(corruption_award_date_label)) message("Cannot auto generate ", corruption_award_year_label, " because ", corruption_award_date_label, " column is not present.")
    else {
      award_date <- self$get_columns_from_data(self$get_corruption_column_name(corruption_award_date_label))
      if(!is.Date(award_date)) message(message("Cannot auto generate ", corruption_award_year_label, " because ", corruption_award_date_label, " column is not of type Date."))
      else {
        col_name <- next_default_item(corruption_award_year_label, self$get_column_names(), include_index = FALSE)
        self$add_columns_to_data(col_name, year(award_date))
        self$append_to_variables_metadata(col_name, corruption_type_label, corruption_award_year_label)
        self$append_to_variables_metadata(col_name, "label", "Award year")
      }
    }
  }
}
)

data_object$set("public","generate_procedure_type", function() {
  if(!self$is_corruption_type_present(corruption_procedure_type_label)) {
    if(!self$is_corruption_type_present(corruption_method_type_label)) message("Cannot auto generate ", corruption_procedure_type_label, " because ", corruption_method_type_label, " is not defined.")
    else {
      procedure_type <- self$get_columns_from_data(self$get_corruption_column_name(corruption_method_type_label))
      procedure_type[procedure_type == "CQS"] <- "Selection Based On Consultant's Qualification"
      procedure_type[procedure_type == "SHOP"] <- "International Shopping"
      procedure_type <- factor(procedure_type, levels = c("Commercial Practices", "Direct Contracting", "Force Account", "INDB", "Individual", "International Competitive Bidding", "International Shopping", "Least Cost Selection", "Limited International Bidding", "National Competitive Bidding", "National Shopping", "Quality And Cost-Based Selection", "Quality Based Selection", "Selection Based On Consultant's Qualification", "Selection Under a Fixed Budget", "Service Delivery Contracts", "Single Source Selection"))
      
      col_name <- next_default_item(corruption_procedure_type_label, self$get_column_names(), include_index = FALSE)
      self$add_columns_to_data(col_name, procedure_type)
      self$append_to_variables_metadata(col_name, corruption_type_label, corruption_procedure_type_label)
      self$append_to_variables_metadata(col_name, "label", "Procedure type")
    }
  }
}
)

data_object$set("public","generate_procuring_authority_id", function() {
  if(!self$is_corruption_type_present(corruption_procuring_authority_id_label)) {
    if(!self$is_corruption_type_present(corruption_procuring_authority_label) | !self$is_corruption_type_present(corruption_country_label)) message("Cannot auto generate ", corruption_procuring_authority_id_label, " because ", corruption_procuring_authority_label, "or ", corruption_award_year_label, " is not defined.")
    else {
      id <- as.numeric(factor(paste0(self$get_columns_from_data(self$get_corruption_column_name(corruption_country_label)), self$get_columns_from_data(self$get_corruption_column_name(corruption_procuring_authority_label))), levels = unique(paste0(self$get_columns_from_data(self$get_corruption_column_name(corruption_country_label)), self$get_columns_from_data(self$get_corruption_column_name(corruption_procuring_authority_label))))))
      
      col_name <- next_default_item(corruption_procuring_authority_id_label, self$get_column_names(), include_index = FALSE)
      self$add_columns_to_data(col_name, id)
      self$append_to_variables_metadata(col_name, corruption_type_label, corruption_procuring_authority_id_label)
      self$append_to_variables_metadata(col_name, "label", "Procurement Auth. ID")
    }
  }
}
)

data_object$set("public","generate_winner_id", function() {
  if(!self$is_corruption_type_present(corruption_winner_id_label)) {
    if(!self$is_corruption_type_present(corruption_winner_name_label)) message("Cannot auto generate ", corruption_winner_id_label, " because ", corruption_winner_name_label, " is not defined.")
    else {
      id <- as.numeric(factor(self$get_columns_from_data(self$get_corruption_column_name(corruption_winner_name_label)), levels = unique(self$get_columns_from_data(self$get_corruption_column_name(corruption_winner_name_label)))))
      
      col_name <- next_default_item(corruption_winner_id_label, self$get_column_names(), include_index = FALSE)
      self$add_columns_to_data(col_name, id)
      self$append_to_variables_metadata(col_name, corruption_type_label, corruption_winner_id_label)
      self$append_to_variables_metadata(col_name, "label", "w_name ID")
    }
  }
}
)

data_object$set("public","generate_foreign_winner", function() {
  if(!self$is_corruption_type_present(corruption_foreign_winner_label)) {
    if(!self$is_corruption_type_present(corruption_country_label) || !self$is_corruption_type_present(corruption_winner_country_label)) message("Cannot auto generate ", corruption_foreign_winner_label, " because ", corruption_country_label, " or ", corruption_winner_country_label, " are not defined.")
    else {
      f_winner <- (self$get_columns_from_data(self$get_corruption_column_name(corruption_country_label)) != self$get_columns_from_data(self$get_corruption_column_name(corruption_winner_country_label)))
      
      col_name <- next_default_item(corruption_foreign_winner_label, self$get_column_names(), include_index = FALSE)
      self$add_columns_to_data(col_name, f_winner)
      self$append_to_variables_metadata(col_name, corruption_type_label, corruption_foreign_winner_label)
      self$append_to_variables_metadata(col_name, "label", "Foreign w_name dummy")
    }
  }
}
)

data_object$set("public","generate_procurement_type_categories", function() {
  if(!self$is_corruption_type_present(corruption_procurement_type_cats_label)) {
    if(!self$is_corruption_type_present(corruption_procedure_type_label)) message("Cannot auto generate ", corruption_procurement_type_cats_label, " because ", corruption_procedure_type_label, " are not defined.")
    else {
      procedure_type <- self$get_columns_from_data(self$get_corruption_column_name(corruption_procedure_type_label))
      procurement_type <- "other, missing"
      procurement_type[procedure_type == "Direct Contracting" | procedure_type == "Individual" | procedure_type == "Single Source Selection"] <- "single source"
      procurement_type[procedure_type == "Force Account" | procedure_type == "Service Delivery Contracts"] <- "own provision"
      procurement_type[procedure_type == "International Competitive Bidding" | procedure_type == "National Competitive Bidding"] <- "open"
      procurement_type[procedure_type == "International Shopping" | procedure_type == "Limited International Bidding" | procedure_type == "National Shopping"] <- "restricted"
      procurement_type[procedure_type == "Quality And Cost-Based Selection" | procedure_type == "Quality Based Selection" | procedure_type == "Selection Under a Fixed Budget"] <- "consultancy,cost"
      procurement_type[procedure_type == "Least Cost Selection" | procedure_type == "Selection Based On Consultant's Qualification"] <- "consultancy,cost"
      procurement_type <- factor(procurement_type, levels = c("open", "restricted", "single source", "consultancy,quality", "consultancy,cost", "own provision", "other, missing"))
      
      col_name <- next_default_item(corruption_procurement_type_cats_label, self$get_column_names(), include_index = FALSE)
      self$add_columns_to_data(col_name, procurement_type)
      self$append_to_variables_metadata(col_name, corruption_type_label, corruption_procurement_type_cats_label)
      self$append_to_variables_metadata(col_name, "label", "Main procurement type category")
    }
  }
}
)

data_object$set("public","generate_procurement_type_2", function() {
  if(!self$is_corruption_type_present(corruption_procurement_type_2_label)) {
    if(!self$is_corruption_type_present(corruption_procurement_type_cats_label)) message("Cannot auto generate ", corruption_procurement_type_2_label, " because ", corruption_procurement_type_cats_label, " are not defined.")
    else {
      procurement_type_cats <- self$get_columns_from_data(self$get_corruption_column_name(corruption_procurement_type_cats_label))
      procurement_type2 <- NA
      procurement_type2[procurement_type_cats == "open"] <- FALSE
      procurement_type2[procurement_type_cats == "restricted" | procurement_type_cats == "single source" | procurement_type_cats == "consultancy,quality" | procurement_type_cats == "consultancy,cost"] <- TRUE
      
      col_name <- next_default_item(corruption_procurement_type_2_label, self$get_column_names(), include_index = FALSE)
      self$add_columns_to_data(col_name, procurement_type2)
      self$append_to_variables_metadata(col_name, corruption_type_label, corruption_procurement_type_2_label)
      self$append_to_variables_metadata(col_name, "label", "Proc. type is restricted, single source, consultancy")
    }
  }
}
)

data_object$set("public","generate_procurement_type_3", function() {
  if(!self$is_corruption_type_present(corruption_procurement_type_3_label)) {
    if(!self$is_corruption_type_present(corruption_procurement_type_cats_label)) message("Cannot auto generate ", corruption_procurement_type_3_label, " because ", corruption_procurement_type_cats_label, " are not defined.")
    else {
      procurement_type_cats <- self$get_columns_from_data(self$get_corruption_column_name(corruption_procurement_type_cats_label))
      procurement_type3 <- NA
      procurement_type3[procurement_type_cats == "open"] <- "open procedure"
      procurement_type3[procurement_type_cats == "restricted" | procurement_type_cats == "single source"] <- "closed procedure risk"
      procurement_type3[procurement_type_cats == "consultancy,quality" | procurement_type_cats == "consultancy,cost"] <- "consultancy spending risk"
      procurement_type3 <- factor(procurement_type3, levels = c("open procedure", "closed procedure risk", "consultancy spending risk"))
      
      col_name <- next_default_item(corruption_procurement_type_3_label, self$get_column_names(), include_index = FALSE)
      self$add_columns_to_data(col_name, procurement_type3)
      self$append_to_variables_metadata(col_name, corruption_type_label, corruption_procurement_type_3_label)
      self$append_to_variables_metadata(col_name, "label", "Procedure type (open, closed, consultancy)")
    }
  }
}
)

data_object$set("public","generate_signature_period", function() {
  if(!self$is_corruption_type_present(corruption_signature_period_label)) {
    if(!self$is_corruption_type_present(corruption_award_date_label) || !self$is_corruption_type_present(corruption_signature_date_label)) message("Cannot auto generate ", corruption_signature_period_label, " because ", corruption_award_date_label, "or", corruption_signature_date_label, " are not defined.")
    else {
      signature_period <- self$get_columns_from_data(self$get_corruption_column_name(corruption_signature_date_label)) - self$get_columns_from_data(self$get_corruption_column_name(corruption_award_date_label))

      col_name <- next_default_item(corruption_signature_period_label, self$get_column_names(), include_index = FALSE)
      self$add_columns_to_data(col_name, signature_period)
      self$append_to_variables_metadata(col_name, corruption_type_label, corruption_signature_period_label)
      self$append_to_variables_metadata(col_name, "label", "Signature period")
    }
  }
}
)

data_object$set("public","generate_signature_period_corrected", function() {
  if(!self$is_corruption_type_present(corruption_signature_period_corrected_label)) {
    if(!self$is_corruption_type_present(corruption_signature_period_label)) self$generate_signature_period()
    signature_period_corrected <- self$get_columns_from_data(self$get_corruption_column_name(corruption_signature_period_label))
    signature_period_corrected[signature_period_corrected < 0 | signature_period_corrected > 730] <- NA
      
    col_name <- next_default_item(corruption_signature_period_corrected_label, self$get_column_names(), include_index = FALSE)
    self$add_columns_to_data(col_name, signature_period_corrected)
    self$append_to_variables_metadata(col_name, corruption_type_label, corruption_signature_period_corrected_label)
    self$append_to_variables_metadata(col_name, "label", "Signature period - corrected")
  }
}
)

data_object$set("public","generate_signature_period_5Q", function() {
  if(!self$is_corruption_type_present(corruption_signature_period_5Q_label)) {
    if(!self$is_corruption_type_present(corruption_signature_period_label)) self$generate_signature_period()
    signature_period_5Q <- .bincode(self$get_columns_from_data(self$get_corruption_column_name(corruption_signature_period_label)), quantile(self$get_columns_from_data(self$get_corruption_column_name(corruption_signature_period_label)), seq(0, 1, length.out = 5 + 1), type = 2, na.rm = TRUE), include.lowest = TRUE)

    col_name <- next_default_item(corruption_signature_period_5Q_label, self$get_column_names(), include_index = FALSE)
    self$add_columns_to_data(col_name, signature_period_5Q)
    self$append_to_variables_metadata(col_name, corruption_type_label, corruption_signature_period_5Q_label)
  }
}
)

data_object$set("public","generate_signature_period_25Q", function() {
  if(!self$is_corruption_type_present(corruption_signature_period_25Q_label)) {
    if(!self$is_corruption_type_present(corruption_signature_period_label)) self$generate_signature_period()
    signature_period_25Q <- .bincode(self$get_columns_from_data(self$get_corruption_column_name(corruption_signature_period_label)), quantile(self$get_columns_from_data(self$get_corruption_column_name(corruption_signature_period_label)), seq(0, 1, length.out = 25 + 1), type = 2, na.rm = TRUE), include.lowest = TRUE)
    
    col_name <- next_default_item(corruption_signature_period_25Q_label, self$get_column_names(), include_index = FALSE)
    self$add_columns_to_data(col_name, signature_period_25Q)
    self$append_to_variables_metadata(col_name, corruption_type_label, corruption_signature_period_25Q_label)
  }
}
)

data_object$set("public","generate_rolling_contract_no_winners", function() {
  if(!self$is_corruption_type_present(corruption_roll_num_winner_label)) {
    self$generate_procuring_authority_id()
    self$generate_winner_id()
    if(!self$is_corruption_type_present(corruption_procuring_authority_id_label) | !self$is_corruption_type_present(corruption_winner_id_label) | !self$is_corruption_type_present(corruption_award_date_label)) {
      message("Cannot auto generate ", corruption_roll_num_winner_label, " because ", corruption_procuring_authority_id_label, " or ", corruption_winner_id_label, " or ", corruption_award_date_label, " are not defined.")
    }
    else {
      temp <- self$get_data_frame(use_current_filter = FALSE)
      authority_id_label <- self$get_corruption_column_name(corruption_procuring_authority_id_label)
      winner_id_label <- self$get_corruption_column_name(corruption_winner_id_label)
      award_date_label <- self$get_corruption_column_name(corruption_award_date_label)
      col_name <- next_default_item(corruption_roll_num_winner_label, self$get_column_names(), include_index = FALSE)
      exp <- interp(~ sum(temp[[authority_id1]] == authority_id2 & temp[[winner_id1]] == winner_id2 & temp[[award_date1]] <= award_date2 & temp[[award_date1]] > award_date2 - 365), authority_id1 = authority_id_label, authority_id2 = as.name(authority_id_label), winner_id1 = winner_id_label, winner_id2 = as.name(winner_id_label), award_date1 = award_date_label, award_date2 = as.name(award_date_label))
      temp <- self$get_data_frame(use_current_filter = FALSE)
      temp <- temp %>% rowwise() %>% mutate_(.dots = setNames(list(exp), col_name))
      self$add_columns_to_data(col_name, temp[[col_name]])
      self$append_to_variables_metadata(col_name, corruption_type_label, corruption_roll_num_winner_label)
      self$append_to_variables_metadata(col_name, "label", "12 month rolling contract number of winner for each contract awarded")
    }
    
  }
}
)

data_object$set("public","generate_rolling_contract_no_issuer", function() {
  if(!self$is_corruption_type_present(corruption_roll_num_issuer_label)) {
    self$generate_procuring_authority_id()
    if(!self$is_corruption_type_present(corruption_procuring_authority_id_label) | !self$is_corruption_type_present(corruption_award_date_label)) {
      message("Cannot auto generate ", corruption_roll_num_issuer_label, " because ", corruption_procuring_authority_id_label, " or ", corruption_award_date_label, " are not defined.")
    }
    else {
      temp <- self$get_data_frame(use_current_filter = FALSE)
      authority_id_label <- self$get_corruption_column_name(corruption_procuring_authority_id_label)
      award_date_label <- self$get_corruption_column_name(corruption_award_date_label)
      col_name <- next_default_item(corruption_roll_num_issuer_label, self$get_column_names(), include_index = FALSE)
      exp <- interp(~ sum(temp[[authority_id1]] == authority_id2 & temp[[award_date1]] <= award_date2 & temp[[award_date1]] > award_date2 - 365), authority_id1 = authority_id_label, authority_id2 = as.name(authority_id_label), award_date1 = award_date_label, award_date2 = as.name(award_date_label))
      temp <- self$get_data_frame(use_current_filter = FALSE)
      temp <- temp %>% rowwise() %>% mutate_(.dots = setNames(list(exp), col_name))
      self$add_columns_to_data(col_name, temp[[col_name]])
      self$append_to_variables_metadata(col_name, corruption_type_label, corruption_roll_num_issuer_label)
      self$append_to_variables_metadata(col_name, "label", "12 month rolling contract number of issuer for each contract awarded")
    }
    
  }
}
)

data_object$set("public","generate_rolling_contract_value_sum_issuer", function() {
  if(!self$is_corruption_type_present(corruption_roll_sum_issuer_label)) {
    self$generate_procuring_authority_id()
    # Need better checks than just for original contract value
    if(!self$is_corruption_type_present(corruption_procuring_authority_id_label) | !self$is_corruption_type_present(corruption_award_date_label) | !self$is_corruption_type_present(corruption_original_contract_value_label)) {
      message("Cannot auto generate ", corruption_roll_num_issuer_label, " because ", corruption_procuring_authority_id_label, " or ", corruption_award_date_label, " are not defined.")
    }
    else {
      temp <- self$get_data_frame(use_current_filter = FALSE)
      authority_id_label <- self$get_corruption_column_name(corruption_procuring_authority_id_label)
      award_date_label <- self$get_corruption_column_name(corruption_award_date_label)
      if(self$is_corruption_type_present(corruption_ppp_adjusted_contract_value_label)) {
        contract_value_label <- self$get_corruption_column_name(corruption_ppp_adjusted_contract_value_label)
      }
      else if(self$is_corruption_type_present(corruption_ppp_conversion_rate_label)) {
        self$generate_ppp_adjusted_contract_value()
        contract_value_label <- self$get_corruption_column_name(corruption_ppp_adjusted_contract_value_label)
      }
      else {
        contract_value_label <- self$get_corruption_column_name(corruption_original_contract_value_label)
      }
      col_name <- next_default_item(corruption_roll_sum_issuer_label, self$get_column_names(), include_index = FALSE)
      exp <- interp(~ sum(temp[[contract_value]][temp[[authority_id1]] == authority_id2 & temp[[award_date1]] <= award_date2 & temp[[award_date1]] > award_date2 - 365]), authority_id1 = authority_id_label, authority_id2 = as.name(authority_id_label), award_date1 = award_date_label, award_date2 = as.name(award_date_label), contract_value = contract_value_label)
      temp <- self$get_data_frame(use_current_filter = FALSE)
      temp <- temp %>% rowwise() %>% mutate_(.dots = setNames(list(exp), col_name))
      self$add_columns_to_data(col_name, temp[[col_name]])
      self$append_to_variables_metadata(col_name, corruption_type_label, corruption_roll_sum_issuer_label)
      self$append_to_variables_metadata(col_name, "label", "12 month rolling sum of contract value of issuer")
    }
  }
}
)

data_object$set("public","generate_rolling_contract_value_sum_winner", function() {
  if(!self$is_corruption_type_present(corruption_roll_sum_winner_label)) {
    self$generate_procuring_authority_id()
    self$generate_winner_id()
    # Need better checks than just for original contract value
    if(!self$is_corruption_type_present(corruption_procuring_authority_id_label) | !self$is_corruption_type_present(corruption_winner_id_label) | !self$is_corruption_type_present(corruption_award_date_label) | !self$is_corruption_type_present(corruption_original_contract_value_label)) {
      message("Cannot auto generate ", corruption_roll_num_issuer_label, " because ", corruption_procuring_authority_id_label, " or ", corruption_winner_id_label, " or ", corruption_award_date_label, " are not defined.")
    }
    else {
      temp <- self$get_data_frame(use_current_filter = FALSE)
      authority_id_label <- self$get_corruption_column_name(corruption_procuring_authority_id_label)
      winner_id_label <- self$get_corruption_column_name(corruption_winner_id_label)
      award_date_label <- self$get_corruption_column_name(corruption_award_date_label)
      if(self$is_corruption_type_present(corruption_ppp_adjusted_contract_value_label)) {
        contract_value_label <- self$get_corruption_column_name(corruption_ppp_adjusted_contract_value_label)
      }
      else if(self$is_corruption_type_present(corruption_ppp_conversion_rate_label)) {
        self$generate_ppp_adjusted_contract_value()
        contract_value_label <- self$get_corruption_column_name(corruption_ppp_adjusted_contract_value_label)
      }
      else {
        contract_value_label <- self$get_corruption_column_name(corruption_original_contract_value_label)
      }
      col_name <- next_default_item(corruption_roll_sum_winner_label, self$get_column_names(), include_index = FALSE)
      exp <- interp(~ sum(temp[[contract_value]][temp[[authority_id1]] == authority_id2 & temp[[winner_id1]] == winner_id2 & temp[[award_date1]] <= award_date2 & temp[[award_date1]] > award_date2 - 365]), authority_id1 = authority_id_label, authority_id2 = as.name(authority_id_label), winner_id1 = winner_id_label, winner_id2 = as.name(winner_id_label), award_date1 = award_date_label, award_date2 = as.name(award_date_label), contract_value = contract_value_label)
      temp <- self$get_data_frame(use_current_filter = FALSE)
      temp <- temp %>% rowwise() %>% mutate_(.dots = setNames(list(exp), col_name))
      self$add_columns_to_data(col_name, temp[[col_name]])
      self$append_to_variables_metadata(col_name, corruption_type_label, corruption_roll_sum_winner_label)
      self$append_to_variables_metadata(col_name, "label", "12 month rolling sum of contract value of winner")
    }
  }
}
)

data_object$set("public","generate_rolling_contract_value_share_winner", function() {
  if(!self$is_corruption_type_present(corruption_roll_share_winner_label)) {
    self$generate_rolling_contract_value_sum_issuer()
    self$generate_rolling_contract_value_sum_winner()
    if(!self$is_corruption_type_present(corruption_roll_sum_winner_label) | !self$is_corruption_type_present(corruption_roll_sum_issuer_label)) {
      message("Cannot auto generate ", corruption_roll_share_winner_label, " because ", corruption_roll_sum_winner_label, " or ", corruption_roll_sum_issuer_label, " are not defined.")
    }
    else {
      share <- self$get_columns_from_data(self$get_corruption_column_name(corruption_roll_sum_winner_label)) / self$get_columns_from_data(self$get_corruption_column_name(corruption_roll_sum_issuer_label))
      
      col_name <- next_default_item(corruption_roll_share_winner_label, self$get_column_names(), include_index = FALSE)
      self$add_columns_to_data(col_name, share)
      self$append_to_variables_metadata(col_name, corruption_type_label, corruption_roll_share_winner_label)
      self$append_to_variables_metadata(col_name, "label", "12 month rolling contract share of winner for each contract awarded")
    }
  }
}
)

data_object$set("public","generate_single_bidder", function() {
  if(!self$is_corruption_type_present(corruption_single_bidder_label)) {
    self$generate_all_bids_trimmed()
    if(!self$is_corruption_type_present(corruption_all_bids_trimmed_label)) {
      message("Cannot auto generate ", corruption_single_bidder_label, " because ", corruption_all_bids_trimmed_label, " is not defined.")
    }
    else {
      single_bidder <- (self$get_columns_from_data(self$get_corruption_column_name(corruption_all_bids_trimmed_label)) == 1) 
      
      col_name <- next_default_item(corruption_single_bidder_label, self$get_column_names(), include_index = FALSE)
      self$add_columns_to_data(col_name, single_bidder)
      self$append_to_variables_metadata(col_name, corruption_type_label, corruption_single_bidder_label)
      self$append_to_variables_metadata(col_name, "label", "Single bidder dummy")
    }
  }
}
)

data_object$set("public","generate_contract_value_share_over_threshold", function() {
  if(!self$is_corruption_type_present(corruption_contract_value_share_over_threshold_label)) {
    self$generate_rolling_contract_value_share_winner()
    self$generate_rolling_contract_no_issuer()
    if(!self$is_corruption_type_present(corruption_roll_share_winner_label) | !self$is_corruption_type_present(corruption_roll_num_issuer_label)) {
      message("Cannot auto generate ", corruption_contract_value_share_over_threshold_label, " because ", corruption_roll_share_winner_label, " or ", corruption_roll_num_issuer_label, " are not defined.")
    }
    else {
      contr_share_over_threshold <- rep(NA, self$get_data_frame_length())
      contr_share_over_threshold[(self$get_columns_from_data(self$get_corruption_column_name(corruption_roll_num_issuer_label)) >= 3) & (self$get_columns_from_data(self$get_corruption_column_name(corruption_roll_share_winner_label)) >= 0.5)] <- TRUE
      contr_share_over_threshold[(self$get_columns_from_data(self$get_corruption_column_name(corruption_roll_num_issuer_label)) >= 3) & (self$get_columns_from_data(self$get_corruption_column_name(corruption_roll_share_winner_label)) < 0.5)] <- FALSE
      
      col_name <- next_default_item(corruption_contract_value_share_over_threshold_label, self$get_column_names(), include_index = FALSE)
      self$add_columns_to_data(col_name, contr_share_over_threshold)
      self$append_to_variables_metadata(col_name, corruption_type_label, corruption_contract_value_share_over_threshold_label)
      self$append_to_variables_metadata(col_name, "label", "Winner share at least 50% where issuers awarded at least 3 contracts")
    }
  }
}
)

data_object$set("public","generate_all_bids", function() {
  if(!self$is_corruption_type_present(corruption_all_bids_label)) {
    if(!self$is_corruption_type_present(corruption_no_bids_considered_label)) {
      message("Cannot auto generate ", corruption_all_bids_label, " because ", corruption_no_bids_considered_label, " is not defined.")
    }
    else {
      all_bids <- self$get_columns_from_data(self$get_corruption_column_name(corruption_no_bids_considered_label))
      if(self$is_corruption_type_present(corruption_no_bids_received_label)) {
        all_bids[is.na(all_bids)] <- self$get_columns_from_data(self$get_corruption_column_name(corruption_no_bids_received_label))[is.na(all_bids)]
      }

      col_name <- next_default_item(corruption_all_bids_label, self$get_column_names(), include_index = FALSE)
      self$add_columns_to_data(col_name, all_bids)
      self$append_to_variables_metadata(col_name, corruption_type_label, corruption_all_bids_label)
      self$append_to_variables_metadata(col_name, "label", "# Bids (all)")
    }
  }
}
)

data_object$set("public","generate_all_bids_trimmed", function() {
  if(!self$is_corruption_type_present(corruption_all_bids_trimmed_label)) {
    self$generate_all_bids()
    if(!self$is_corruption_type_present(corruption_all_bids_label)) {
      message("Cannot auto generate ", corruption_all_bids_trimmed_label, " because ", corruption_all_bids_label, " is not defined.")
    }
    else {
      all_bids_trimmed <- self$get_columns_from_data(self$get_corruption_column_name(corruption_all_bids_label))
      all_bids_trimmed[all_bids_trimmed > 50] <- 50
      
      col_name <- next_default_item(corruption_all_bids_trimmed_label, self$get_column_names(), include_index = FALSE)
      self$add_columns_to_data(col_name, all_bids_trimmed)
      self$append_to_variables_metadata(col_name, corruption_type_label, corruption_all_bids_trimmed_label)
      self$append_to_variables_metadata(col_name, "label", "# Bids (trimmed at 50)")
    }
  }
}
)