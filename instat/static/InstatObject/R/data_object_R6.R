data_object <- R6Class("data_object",
                         public = list(
                           initialize = function(data = data.frame(), data_name = "", 
                                                 variables_metadata = data.frame(), metadata = list(), 
                                                 imported_from = "", 
                                                 messages = TRUE, convert=TRUE, create = TRUE, 
                                                 start_point=1)
{
                             
  # Set up the data object
  self$set_data(data, messages)                           
  self$set_changes(list())
  self$set_variables_metadata(variables_metadata)
  self$update_variables_metadata()
  self$set_meta(metadata)
  
  # If no name for the data.frame has been given in the list we create a default one.
  # Decide how to choose default name index
  if (!self$is_metadata(data_name_label)) {    
    if ( ( is.null(data_name) || data_name == "" || missing(data_name))) {
      self$append_to_metadata(data_name_label,paste0("data_set_",sprintf("%03d", start_point)))
      if (messages) {
        message(paste0("No name specified in data_tables list for data frame ", start_point, ". 
                       Data frame will have default name: ", "data_set_",sprintf("%03d", start_point)))
      }
    }
    else self$append_to_metadata(data_name_label, data_name)     
  }
  
  self$add_defaults_meta()
}
),
                         private = list(
                           data = data.frame(),
                           metadata = list(), 
                           variables_metadata = data.frame(), 
                           changes = list(), 
                           data_changed = FALSE,
                           metadata_changed = FALSE, 
                           variables_metadata_changed = FALSE 
                          )
)

data_object$set("public", "set_data", function(new_data, messages=TRUE) {
  if( ! is.data.frame(new_data) ) {
    stop("Data set must be of type: data.frame")
  }
  else {
    if ( length(new_data) == 0 && messages) {
      message("data of object:is empty. Data will be an empty data frame.")
    }
    private$data <- new_data
    self$append_to_changes(list(Set_property, "data"))
    self$set_data_changed(TRUE)
    self$set_variables_metadata_changed(TRUE)
    #      is_data_split<<-FALSE
  }
}
)

data_object$set("public", "set_meta", function(new_meta) {
  if(!is.list(new_meta)) stop("new_meta must be of type: list")

  private$metadata <- new_meta
  self$set_metadata_changed(TRUE)
  self$append_to_changes(list(Set_property, "meta data"))
}
)

data_object$set("public", "set_variables_metadata", function(new_meta) {
  if(!is.data.frame(new_meta)) stop("variable metadata must be of type: data.frame")
  
  private$variables_metadata <- new_meta
  self$append_to_changes(list(Set_property, "variable metadata"))
}
)

data_object$set("public", "set_changes", function(new_changes) {
  if(!is.list(new_changes)) stop("Changes must be of type: list")

    private$changes <- new_changes
    self$append_to_changes(list(Set_property, "changes"))  
}
)

data_object$set("public", "set_data_changed", function(new_val) {
  if(new_val != TRUE && new_val != FALSE) stop("new_val must be TRUE or FALSE")
  
  private$data_changed <- new_val
  self$append_to_changes(list(Set_property, "data_changed"))
}
)

data_object$set("public", "set_variables_metadata_changed", function(new_val) {
  if(new_val != TRUE && new_val != FALSE) stop("new_val must be TRUE or FALSE")
  
  private$variables_metadata_changed <- new_val
  self$append_to_changes(list(Set_property, "variable_data_changed"))
}
)

data_object$set("public", "set_metadata_changed", function(new_val) {
  if( new_val != TRUE && new_val != FALSE ) stop("new_val must be TRUE or FALSE")
  
  private$metadata_changed <- new_val
  self$append_to_changes(list(Set_property, "metadata_changed"))
}
)

data_object$set("public", "update_variables_metadata", function() {
  
  if(length(colnames(data)) !=  length(rownames(variables_metadata)) || !all(colnames(data)==rownames(variables_metadata))) {
    if(all(colnames(data) %in% rownames(variables_metadata))) {
      self$set_variables_metadata(variables_metadata[colnames(data),])
    }
    else {
      for(col in colnames(data)[!colnames(data) %in% rownames(variables_metadata)]) {
        self$append_to_variables_metadata(col, name_label, col)
        self$append_to_variables_metadata(col, display_decimal_label, get_default_decimal_places(data[[col]]))
      }
    }
  }
  self$append_to_changes(list(Set_property, "variables_metadata"))
}
)

data_object$set("public", "get_data_frame", function(convert_to_character = FALSE) {
  if(convert_to_character) {
    decimal_places = private$variables_metadata[[display_decimal_label]]
    return(convert_to_character_matrix(data, TRUE, decimal_places))
  }
  else return(data)
}
)

# TODO
data_object$set("public", "get_variables_metadata", function(include_all = TRUE, data_type = "all", convert_to_character = FALSE) {
  self$update_variables_metadata()
  if(!include_all) out = variables_metadata
  else {
    out = variables_metadata
    out[[data_type_label]] = sapply(data, class)
    if(data_type != "all") {
      if(data_type == "numeric") {
        out = out[out[[data_type_label]] %in% c("numeric", "integer"), ]
      }
      else {
        out = out[out[[data_type_label]] == data_type, ]        
      }
    }
  }
  if(convert_to_character) return(convert_to_character_matrix(out, FALSE))
  else return(out)
}
)

data_object$set("public", "get_metadata", function(label) {
  if(missing(label)) return(metadata)
  else {
    if(label %in% names(metadata)) return(metadata[[label]])
    else return("")
  }
}
)

data_object$set("public", "add_columns_to_data", function(col_name = "", col_data, use_col_name_as_prefix) {
  
  # Column name must be character
  if(!is.character(col_name)) stop("Column name must be of type: character")
  if(is.matrix(col_data) || is.data.frame(col_data)) {
    num_cols = ncol(col_data)
    if( (length(col_name) != 1) && (length(col_name) != num_cols) ) stop("col_name must be a character or character vector with the same length as the number of new columns")
  }
  else {
    use_col_name_as_prefix = FALSE
    num_cols = 1
    col_data = data.frame(col_data)
  }
  
  if(missing(use_col_name_as_prefix)) {
    if(num_cols > 1 && length(col_name) == num_cols) use_col_name_as_prefix = FALSE
    else use_col_name_as_prefix = TRUE
  }
  
  for(i in 1:num_cols) {
    curr_col = unlist(col_data[,i])
    if(use_col_name_as_prefix) curr_col_name = .self$get_next_default_column_name(col_name)
    else curr_col_name = col_name[[i]]
    
    if(curr_col_name %in% names(data)) {
      message(paste("A column named", curr_col_name, "already exists. The column will be replaced in the data"))
      .self$append_to_changes(list(Replaced_col, curr_col_name))
    }
    
    else .self$append_to_changes(list(Added_col, curr_col_name))
    
    data[[curr_col_name]] <<- curr_col
    .self$set_data_changed(TRUE)
    .self$set_variables_metadata_changed(TRUE)
  }
}
)


























data_object$set("public", "append_to_metadata", function(name, value) {
  
  if( missing(name) || missing(value) ) {
    stop("name and value arguements must be specified.")
  } 
  
  
  else if ( ! is.character(name) ) {
    stop("name must be of type: character")
  }
  
  # Remember double brackets must be used when dealing with variable names.
  else {
    private$metadata[[name]] <- value 
    self$append_to_changes(list(Added_metadata, name))
    self$set_metadata_changed(TRUE)
  }
}
)

data_object$set("public", "append_to_variables_metadata", function(col_name, property, new_val) {
  
  if( missing(col_name) || missing(property) || missing(new_val) ) {
    stop("col_name, property and new_val arguements must be specified.")
  }
  if(!col_name %in% names(data)) stop("col_name not found in data")
  
  row = which(variables_metadata[,1]==col_name)
  col = which(colnames(variables_metadata)==property)
  private$variables_metadata[row, col] <- new_val
  
  self$append_to_changes(list(Added_variables_metadata, col_name, property))
  self$set_variables_metadata_changed(TRUE)
  self$set_data_changed(TRUE)
}
)

data_object$set("public", "append_to_changes", function(value) {
  
  if( missing(value) ) {
    stop(" value arguements must be specified.")
  } 
  else {
    private$changes[[length(changes)+1]] <- value 
  }
}
)


