data_object <- R6Class("data_object",
                         public = list(
                           initialize = function(data = data.frame(), data_name = "", 
                                                 variables_metadata = data.frame(), metadata = list(), 
                                                 imported_from = "", 
                                                 messages = TRUE, convert=TRUE, create = TRUE, 
                                                 start_point=1, filters = list())
{
                             
  # Set up the data object
  self$set_data(data, messages)                           
  self$set_changes(list())
  self$set_variables_metadata(variables_metadata)
  self$update_variables_metadata()
  self$set_meta(metadata)
  self$set_filters(filters)
  
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
  self$add_defaults_variables_metadata()
}
),
                         private = list(
                           data = data.frame(),
                           metadata = list(), 
                           variables_metadata = data.frame(),
                           filters = list(),
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
                                filter_string = ""
                                i = 1
                                result = matrix(nrow = nrow(private$data), ncol = length(private$.current_filter))
                                for(condition in private$.current_filter) {
                                  func = match.fun(condition[["operation"]])
                                  result[ ,i] = func(self$get_columns_from_data(condition[["column"]]), condition[["value"]])
                                  i = i + 1
                                }
                                return(apply(result, 1, all))
                              }
                              else {
                                private$.current_filter <- filter
                                self$data_changed <- TRUE
                                self$append_to_changes(list(Set_property, "current_filter"))
                              }
                            }
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
    self$data_changed <- TRUE
    self$variables_metadata_changed <- TRUE
    #      is_data_split<<-FALSE
  }
}
)

data_object$set("public", "set_meta", function(new_meta) {
  if(!is.list(new_meta)) stop("new_meta must be of type: list")

  private$metadata <- new_meta
  self$metadata_changed <- TRUE
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

data_object$set("public", "set_filters", function(new_filters) {
  if(!is.list(new_filters)) stop("Filters must be of type: list")
  
  self$append_to_changes(list(Set_property, "filters"))  
  private$filters <- new_filters
}
)

data_object$set("public", "update_variables_metadata", function() {
  
  if(ncol(private$data) !=  nrow(private$variables_metadata) || !all(colnames(private$data)==rownames(private$variables_metadata))) {
    if(all(colnames(private$data) %in% rownames(private$variables_metadata))) {
      self$set_variables_metadata(private$variables_metadata[colnames(private$data),])
    }
    else {
      for(col in colnames(private$data)[!colnames(private$data) %in% rownames(private$variables_metadata)]) {
        self$append_to_variables_metadata(col, name_label, col)
        self$append_to_variables_metadata(col, display_decimal_label, get_default_decimal_places(private$data[[col]]))
      }
    }
  }
  self$append_to_changes(list(Set_property, "variables_metadata"))
}
)

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

data_object$set("public", "get_data_frame", function(convert_to_character = FALSE, include_hidden_columns = TRUE, use_current_filter = FALSE) {
  if(!include_hidden_columns && self$is_variables_metadata(is_hidden_label)) out = private$data[ , !self$get_variables_metadata(property = is_hidden_label)]
  else out = private$data
  if(use_current_filter && length(private$.current_filter) > 0) {
    out = out[self$current_filter, ]
  }
  if(convert_to_character) {
    decimal_places = private$variables_metadata[[display_decimal_label]]
    return(convert_to_character_matrix(out, TRUE, decimal_places))
  }
  else return(out)
}
)

# TODO
data_object$set("public", "get_variables_metadata", function(include_all = TRUE, data_type = "all", convert_to_character = FALSE, property, column) {
  self$update_variables_metadata()
  if(!include_all) out = private$variables_metadata
  else {
    out = private$variables_metadata
    out[[data_type_label]] = sapply(private$data, class)
    if(data_type != "all") {
      if(data_type == "numeric") {
        out = out[out[[data_type_label]] %in% c("numeric", "integer"), ]
      }
      else {
        out = out[out[[data_type_label]] == data_type, ]        
      }
    }
  }
  
  if(!missing(property)) {
    if(!property %in% names(out)) stop(property, " not found in variables metadata")
    if(!missing(column)) {
      if(!all(column %in% names(private$data))) stop(column, " not found in data")
      out = out[column, property]
    }
    else out = out[, property]
  }
  
  #TODO get convert_to_character_matrix to work on vectors
  if(convert_to_character && missing(property)) return(convert_to_character_matrix(out, FALSE))
  else return(out)
}
)

data_object$set("public", "get_metadata", function(label, include_all = TRUE) {
  if(missing(label)) {
    out = private$metadata
    if(include_all) {
    out[[row_count_label]] <- nrow(private$data)
    out[[column_count_label]] <- ncol(private$data)
    }
    return(out)
  }
  else {
    if(label %in% names(private$metadata)) return(private$metadata[[label]])
    else if(label == row_count_label) return(nrow(private$data))
    else if(label == column_count_label) return(ncol(private$data))
    else return("")
  }
}
)

data_object$set("public", "get_changes", function() {
  return(private$changes)
}
)

data_object$set("public", "get_data", function() {
  return(private$data)
}
)

data_object$set("public", "add_columns_to_data", function(col_name = "", col_data, use_col_name_as_prefix = FALSE, hidden = FALSE, before = FALSE, adjacent_column, num_cols) {
  
  # Column name must be character
  if(!is.character(col_name)) stop("Column name must be of type: character")
  if(missing(num_cols)) {
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
  if( (length(col_name) != 1) && (length(col_name) != num_cols) ) stop("col_name must be a character or character vector with the same length as the number of new columns")
  
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
    if(!missing(col_data)) {
      if(num_cols == 1) curr_col = col_data
      else curr_col = unlist(col_data[,i])
    }

    if(use_col_name_as_prefix) curr_col_name = self$get_next_default_column_name(col_name)
    else curr_col_name = col_name[[i]]
    
    if(curr_col_name %in% names(private$data)) {
      message(paste("A column named", curr_col_name, "already exists. The column will be replaced in the data"))
      self$append_to_changes(list(Replaced_col, curr_col_name))
      replaced = TRUE
    }
    
    else self$append_to_changes(list(Added_col, curr_col_name))
    
    private$data[[curr_col_name]] <- curr_col
    self$data_changed <- TRUE
    self$append_to_variables_metadata(curr_col_name, is_hidden_label, hidden)
    self$variables_metadata_changed <- TRUE
  }
  if(!replaced) {
    if(before && ind == 1) self$set_data(self$get_data_frame()[ , c((previous_length + 1):(previous_length + num_cols), 1:previous_length)])
    else if(before || ind != previous_length + 1) self$set_data(self$get_data_frame()[ , c(1:(ind - 1), (previous_length + 1):(previous_length + num_cols), ind:previous_length)])
  }
  else {
    if(!missing(before) || !missing(adjacent_column)) warning("Cannot reposition when one or move new columns replaces an old column.")
  }
}
)

data_object$set("public", "get_columns_from_data", function(col_names, force_as_data_frame = FALSE, use_current_filter = FALSE) {
  if(missing(col_names)) stop("no col_names to return")
  if(!all(col_names %in% names(private$data))) stop("Not all column names were found in data")
  
  if(length(col_names)==1) {
    if(force_as_data_frame) return(self$get_data_frame(use_current_filter = use_current_filter)[col_names])
    else return(self$get_data_frame(use_current_filter = use_current_filter)[[col_names]])
  }
  else return(self$get_data_frame(use_current_filter = use_current_filter)[col_names])
}
)

data_object$set("public", "rename_column_in_data", function(curr_col_name = "", new_col_name="") {
  
  # Column name must be character
  if (new_col_name %in% names(private$data)){
    stop(paste0(new_col_name," exist in the data."))
  }
  if(!is.character(curr_col_name)) {
    stop("Current column name must be of type: character")
  }
  
  else if (!(curr_col_name %in% names(private$data))) {
    stop(paste0("Cannot rename column: ",curr_col_name,". Column was not found in the data."))
  }
  
  else if (!is.character(new_col_name)) {
    stop("New column name must be of type: character")
  }
  
  else {
    if(sum(names(private$data) == curr_col_name) > 1) {
      warning(paste0("Multiple columns have name: '", curr_col_name,"'. All such columns will be 
                     renamed."))
    }
    names(private$data)[names(private$data) == curr_col_name] <- new_col_name
    # TODO decide if we need to do these 2 lines
    rownames(private$variables_metadata)[rownames(private$variables_metadata) == curr_col_name] <- new_col_name
    self$append_to_variables_metadata(rownames(private$variables_metadata)[rownames(private$variables_metadata) == new_col_name], name_label, new_col_name)
    self$append_to_changes(list(Renamed_col, curr_col_name, new_col_name))
    self$data_changed <- TRUE
    self$variables_metadata_changed <- TRUE
    }
}
)

#TODO remove this method
data_object$set("public", "remove_columns_in_data_from_start_position", function(start_pos, col_numbers = 1) {
  if (start_pos <= 0) stop("You cannot remove a column into the position less or equal to zero.")
  if (start_pos %% 1 != 0) stop("start_pos value should be an integer.")
  if (ncol(private$data) < start_pos) stop("The start_pos argument exceeds the number of columns in the data.")
  col_names = names(private$data)[start_pos:(start_pos+col_numbers-1)]
  self$remove_columns_in_data(col_names)
}
)

data_object$set("public", "remove_columns_in_data", function(cols=c()) {
  for(col_name in cols){
    # Column name must be character
    if(!is.character(col_name)) {
      stop("Column name must be of type: character")
    }
    
    else if (!(col_name %in% names(private$data))) {
      stop(paste0("Column :'", col_name, " was not found in the data."))
    }
    
    else {
      private$data[[ col_name ]] <- NULL 
      # self$append_to_changes(list(Removed_col, col_name))
    }
  }
  self$append_to_changes(list(Removed_col, cols))
  self$data_changed <- TRUE
  self$variables_metadata_changed <- TRUE
}
)

data_object$set("public", "replace_value_in_data", function(col_name = "", row, new_value = "") {
  
  # Column name must be character
  if(!is.character(col_name)) {
    stop("Column name must be of type: character")
  }
  
  else if (!(col_name %in% names(private$data))) {
    stop(paste("Cannot find column:",col_name,"in the data."))
  }
  
  # Column data length must match number of rows of data.
  else if (!(row %in% rownames(private$data))) {
    stop("row not found in data")
  }
  index <- which(rownames(private$data) == row)
  old_value <- private$data[[col_name]][[index]]
  if(self$get_variables_metadata(property = data_type_label, column = col_name) == "factor") {
    if(!(new_value %in% levels(private$data[[col_name]]))) {
      stop(new_value, " is not an existing level of the factor")
    }
  }
  private$data[[col_name]][[index]] <- new_value
  self$append_to_changes(list(Replaced_value, col_name, row, old_value, new_value))
  self$data_changed <- TRUE
  self$variables_metadata_changed <- TRUE
}
)

data_object$set("public", "append_to_metadata", function(name, value) {
  
  if(missing(name) || missing(value)) {
    stop("name and value arguements must be specified.")
  } 
  
  else if (!is.character(name)) {
    stop("name must be of type: character")
  }
  
  # Remember double brackets must be used when dealing with variable names.
  else {
    private$metadata[[name]] <- value 
    self$append_to_changes(list(Added_metadata, name))
    self$metadata_changed <- TRUE
  }
}
)

data_object$set("public", "append_to_variables_metadata", function(col_names, property, new_val) {
  
  if(missing(col_names) || missing(property) || missing(new_val)) stop("col_names, property and new_val arguements must be specified.")
  
  if(!all(col_names %in% names(private$data))) stop(paste(col_names, "not found in data"))
  for(curr_col in col_names) {
    row = integer()
    if(ncol(private$variables_metadata)>0) row = which(rownames(private$variables_metadata)==curr_col)
    row_exists = TRUE
    if(length(row)==0) {
      row = nrow(private$variables_metadata) + 1
      row_exists = FALSE
    }
    col = which(colnames(private$variables_metadata)==property)
    propery_exists = TRUE
    if(length(col)==0) {
      col = ncol(private$variables_metadata) + 1
      propery_exists = FALSE
    }
    private$variables_metadata[row, col] <- new_val
    if(!row_exists) rownames(private$variables_metadata)[row] <- curr_col
    if(!propery_exists) colnames(private$variables_metadata)[col] <- property
    
    self$append_to_changes(list(Added_variables_metadata, curr_col, property))
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
  return(str %in% names(private$metadata))
}
)

data_object$set("public", "is_variables_metadata", function(str) {
  return(str %in% names(private$variables_metadata))
}
)

data_object$set("public", "add_defaults_meta", function() {
  self$append_to_metadata(is_calculated_label,FALSE)
}
)

data_object$set("public", "add_defaults_variables_metadata", function() {
  sapply(self$get_column_names(), function(col_name) self$append_to_variables_metadata(col_name, is_hidden_label, FALSE))
}
)

data_object$set("public", "remove_rows_in_data", function(row_names) {
  if(!all(row_names %in% rownames(private$data))) stop("Some of the row_names not found in data")
  self$set_data(private$data[!(rownames(private$data) %in% row_names), ])
  self$append_to_changes(list(Removed_row, row_names))
  self$data_changed <- TRUE
}
)

data_object$set("public", "get_next_default_column_name", function(prefix) {
  next_default_item(prefix = prefix, existing_names = names(private$data))
} 
)

#TODO delete and replace with add_columns_to_data
data_object$set("public", "insert_column_in_data", function(col_data =c(), start_pos = (length(names(data))+1), number_cols = 1) {
  if (start_pos <= 0) stop("You cannot put a column into the position less or equal to zero.")
  if (start_pos %% 1 != 0) stop("start_pos value should be an integer.")
  if ((ncol(private$data) + 1) < start_pos) stop("The start_pos argument exceeds the number of columns in the data plus one.")
  
  if(length(col_data)==0){
    col_data <- rep(NA, nrow(private$data))
    message(paste("You are inserting empty column(s) in:", self$get_metadata(data_name_label)))
  }
  for(j in 1:number_cols){
    col_name <- self$get_next_default_column_name("X") #change x 
    assign(col_name, col_data)
    self$add_columns_to_data(col_name, col_data)
  }
  if(start_pos==1){
    self$set_data(cbind(private$data[(ncol(private$data)-number_cols+1): ncol(private$data)], private$data[(start_pos):(ncol(private$data)-number_cols)]))
  }
  else if(start_pos==(ncol(private$data) + 1 - number_cols)){
    #data <<- data (do we need this?)
  }
  else{
    self$set_data(cbind(private$data[1:(start_pos -1)], private$data[(ncol(private$data)-number_cols+1): ncol(private$data)], private$data[start_pos:(ncol(private$data)-number_cols)]))
    
  }
  
  self$append_to_changes(list(Inserted_col, start_pos))
  self$data_changed <- TRUE
  self$variables_metadata_changed <- TRUE
}
)

# data_object$set("public", "move_columns_in_data", function(col_names = "", col_number) {
#   if (col_number <= 0) stop("You cannot move a column into the position less or equal to zero.")
#   if (col_number %% 1 != 0) stop("col_number value should be an integer.")
#   if (ncol(private$data) < col_number) stop("The col_number argument exceeds the number of columns in the data.")
#   
#   for(col_name in col_names){
#     if(!(col_name %in% names(private$data))){
#       stop(col_name, " is not a column in ", get_metadata(data_name_label))
#     }
#   }
#   
#   old_names = names(private$data)
#   dat1 <- private$data[(col_names)]
#   names(dat1) <- col_names
#   
#   for(name in col_names){
#     names(private$data)[names(private$data) == name] <- self$get_next_default_column_name(prefix = "to_delete")
#   }
#   
#   if(col_number==1){
#     self$set_data(cbind(dat1, private$data))
#   }
#   else if(col_number == ncol(private$data)){
#     self$set_data(cbind(private$data,dat1))
#   }
#   else{
#     self$set_data(cbind(private$data[1:(col_number)], dat1, private$data[(col_number+1):ncol(private$data)]))
#   }
#   new_names = names(private$data)
#   
#   for(name in new_names){
#     if(!(name %in% old_names)){
#       private$data[,name] <- NULL
#     }
#   }
#   self$append_to_changes(list(Move_col, col_names))
# }
# )

data_object$set("public", "reorder_columns_in_data", function(col_order) {
  if (ncol(private$data) != length(col_order)) stop("Columns to order should be same as columns in the data.")
  
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
  
  curr_row_names = rownames(private$data)
  if (!start_row %in% curr_row_names) {
    stop(paste(start_row, " not found in rows"))
  }
  row_position = which(curr_row_names == start_row)
  row_data <- matrix(NA, nrow = number_rows, ncol = ncol(private$data))
  colnames(row_data) <- colnames(private$data)
  if(length(curr_row_names[!is.na(as.numeric(curr_row_names))]) > 0) {
    rownames(row_data) <- max(as.numeric(curr_row_names), na.rm = TRUE) + 1:number_rows
  }
  else rownames(row_data) <- nrow(private$data) + 1:(number_rows - 1)
  
  if(before && row_position == 1) {
    self$set_data(rbind(row_data, private$data))
  }
  else if(!before && row_position == nrow(private$data)) {
    self$set_data(rbind(private$data, row_data))
  }
  else {
    if(before) {
      self$set_data(rbind(private$data[1:(row_position - 1), ], row_data, private$data[row_position:nrow(private$data), ]))
    }
    else {
      self$set_data(rbind(private$data[1:row_position, ], row_data, private$data[(row_position + 1):nrow(private$data), ]))
    }
  }
  self$append_to_changes(list(Inserted_row, number_rows))
  self$data_changed <- TRUE
}
)

data_object$set("public", "get_data_frame_length", function() {
  return(nrow(private$data))
}
)

data_object$set("public", "get_factor_data_frame", function(col_name = "") {
  if(!(col_name %in% names(private$data))){
    stop(col_name, " is not a column in", get_metadata(data_name_label))
  }
  if(!(is.factor(private$data[,c(col_name)]))){
    stop(col_name, " is not a factor column")
  }
  
  counts <- as.data.frame(table(private$data[,c(col_name)]))
  counts <- rename(counts, replace = c("Var1" = "Levels", "Freq" = "Counts"))
  return(counts)
}
)

data_object$set("public", "get_column_factor_levels", function(col_name = "") {
  if(!(col_name %in% names(private$data))){
    stop(col_name, " is not a column in", get_metadata(data_name_label))
  }
  
  if(!(is.factor(private$data[,col_name]))){
    stop(col_name, " is not a factor column")
  }
  
  return(levels(private$data[,col_name]))
}
)

data_object$set("public", "sort_dataframe", function(col_names = c(), decreasing = TRUE, na.last = TRUE) {
  string = list()
  for(col_name in col_names){
    if(!(col_name %in% names(private$data))){
      stop(col_name, " is not a column in ", get_metadata(data_name_label))
    }
  }
  if(length(col_names)==1){
    self$set_data(private$data[with(private$data, order(eval(parse(text = col_names)), decreasing = decreasing, na.last = na.last)), ])
  }else{
    self$set_data(private$data[ do.call(order, c(as.list(private$data[,col_names]), decreasing = decreasing, na.last = na.last)), ])
  }
  self$data_changed <- TRUE
}
)

data_object$set("public", "convert_column_to_type", function(col_names = c(), to_type = "factor", factor_numeric = "by_levels") {
  for(col_name in col_names){
    if(!(col_name %in% names(private$data))){
      stop(col_name, " is not a column in ", get_metadata(data_name_label))
    }
  }
  
  if(length(to_type)>1){
    warning("Column(s) will be converted to type ", to_type[1])
    to_type = to_type[1]
  }
  
  
  if(!(to_type %in% c("integer", "factor", "numeric", "character"))){
    stop(to_type, " is not a valid type to convert to")
  }
  
  if(!(factor_numeric %in% c("by_levels", "by_ordinals"))){
    stop(factor_numeric, " can either be by_levels or by_ordinals.")
  }
  
  for(col_name in col_names){
    if(to_type=="factor"){
      self$add_columns_to_data(col_name = col_name, col_data = as.factor(private$data[,col_name]))
    }
    
    if(to_type=="integer"){
      self$add_columns_to_data(col_name = col_name, col_data = as.integer(private$data[,col_name]))
    }
    
    if(to_type=="numeric"){
      if(is.factor(private$data[,col_name]) && (factor_numeric == "by_levels")){
        self$add_columns_to_data(col_name = col_name, col_data = as.numeric(levels(private$data[,col_name]))[private$data[,col_name]])
      }else{
        self$add_columns_to_data(col_name = col_name, col_data = as.numeric(private$data[,col_name]) )
      }
    }
    
    if(to_type=="character"){
      self$add_columns_to_data(col_name = col_name, col_data = as.character(private$data[,col_name]))
    }
  }
  self$data_changed <- TRUE
  self$variables_metadata_changed <- TRUE
}
)

data_object$set("public", "copy_columns", function(col_names = "") {
  for(col_name in col_names){
    if(!(col_name %in% names(private$data))){
      stop(col_name, " is not a column in ", get_metadata(data_name_label))
    }
  }
  dat1 <- private$data[(col_names)]
  
  for(name in col_names){
    names(dat1)[names(dat1) == name] <- self$get_next_default_column_name(prefix = paste(name, "copy", sep = "_" ) )
  }
  
  self$set_data(cbind(private$data, dat1))
  self$append_to_changes(list(Copy_cols, col_names))
}
)

data_object$set("public", "drop_unused_factor_levels", function(col_name) {
  if(!col_name %in% names(private$data)) stop(paste(col_name,"not found in data."))
  if(!is.factor(private$data[[col_name]])) stop(paste(col_name,"is not a factor."))
  
  self$add_columns_to_data(col_name, droplevels(private$data[[col_name]]))
} 
)

data_object$set("public", "set_factor_levels", function(col_name, new_levels) {
  if(!col_name %in% names(private$data)) stop(paste(col_name,"not found in data."))
  if(!is.factor(private$data[[col_name]])) stop(paste(col_name,"is not a factor."))
  if(length(new_levels) < length(levels(private$data[[col_name]]))) stop("There must be at least as many new levels as current levels.")
  
  levels(private$data[[col_name]]) <- new_levels
  self$data_changed <- TRUE
  self$variables_metadata_changed <- TRUE
} 
)

data_object$set("public", "set_factor_reference_level", function(col_name, new_ref_level) {
  if(!col_name %in% names(private$data)) stop(paste(col_name,"not found in data."))
  if(!is.factor(private$data[[col_name]])) stop(paste(col_name,"is not a factor."))
  if(!new_ref_level %in% levels(private$data[[col_name]])) stop(paste(new_ref_level, "is not a level of the factor"))
  
  self$add_columns_to_data(col_name, relevel(private$data[[col_name]], new_ref_level))
} 
)

data_object$set("public", "reorder_factor_levels", function(col_name, new_level_names) {
  if(!col_name %in% names(private$data)) stop(paste(col_name,"not found in data."))
  if(!is.factor(private$data[[col_name]])) stop(paste(col_name,"is not a factor."))
  if(length(new_level_names)!=length(levels(private$data[[col_name]]))) stop("Incorrect number of new level names given.")
  if(!all(new_level_names %in% levels(private$data[[col_name]]))) stop(paste("new_level_names must be a reordering of the current levels:",paste(levels(data[[col_name]]), collapse = " ")))
  self$add_columns_to_data(col_name = col_name, col_data = factor(private$data[[col_name]], levels = new_level_names))
  self$variables_metadata_changed <- TRUE
}
)

data_object$set("public", "get_column_count", function(col_name, new_level_names) {
  return(ncol(private$data))
}
)

data_object$set("public", "get_column_names", function(as_list = FALSE, include = list(), exclude = list()) {
  if(data_type_label %in% names(include) && "numeric" %in% include[[data_type_label]]) {
    include[[data_type_label]] = c(include[[data_type_label]], "integer")
  }
  if(data_type_label %in% names(exclude) && "numeric" %in% exclude[[data_type_label]]) {
    exclude[[data_type_label]] = c(exclude[[data_type_label]], "integer")
  }
  
  col_names = names(private$data)
  curr_var_metadata = self$get_variables_metadata()
  out = c()
  for(col in col_names) {
    if(all(sapply(names(include), function(prop) self$get_variables_metadata(property = prop, column = col) %in% include[[prop]]))
       && all(sapply(names(exclude), function(prop) !self$get_variables_metadata(property = prop, column = col) %in% exclude[[prop]]))) {
      out = c(out, col)
    }
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
  if(!(col_name %in% names(private$data))){
    stop(paste(col_name, "is not a column in", get_metadata(data_name_label)))
  }
  type = ""
  if(is.character(private$data[[col_name]])) {
    type = "character"
  }
  
  if(is.logical(private$data[[col_name]])) {
    type = "logical"
  }
  
  if(is.Date(private$data[[col_name]])){
    type = "Date"
  }
  
  if(is.numeric(private$data[[col_name]])) {
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
  
  if(is.factor(private$data[[col_name]])) {
    if(length(levels(private$data[[col_name]]))==2) type = "two level factor"
    else if(length(levels(private$data[[col_name]]))>2) type = "multilevel factor"
    else type = "factor"
  }
  return(type)
}
)

data_object$set("public", "set_hidden_columns", function(col_names) {
  if(col_names == "") self$unhide_all_columns()
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
  if(missing(row_names)) row_names = 1:nrow(private$data)
  if(length(row_names) != nrow(private$data)) stop("row_names must be a vector of same length as the data")
  if(anyDuplicated(row_names) != 0) stop("row_names must be unique")
  rownames(private$data) <- row_names
  self$data_changed <- TRUE
}
)

data_object$set("public", "set_protected_columns", function(col_names) {
  if(!all(col_names %in% self$get_column_names())) stop("Not all col_names found in data")
  
  self$append_to_variables_metadata(col_names, is_protected_label, TRUE)
  other_cols = self$get_column_names()[!self$get_column_names() %in% col_names]
  self$append_to_variables_metadata(other_cols, is_protected_label, FALSE)
}
)

data_object$set("public", "add_filter", function(filter, filter_name = "", replace = TRUE, set_as_current = FALSE) {
  if(missing(filter)) stop("filter is required")
  if(filter_name == "") filter_name = next_default_item("filter", names(private$filters))
  
  for(condition in filter) {
    if(length(condition) != 3 || !all(sort(names(condition)) == c("column", "operation", "value"))) {
      stop("filter must be a list of conditions containing: column, operation and value")
    }
    if(!condition[["column"]] %in% names(private$data)) stop(condition[["column"]], " not found in data.")
  }
  if(filter_name %in% names(private$filters) && replace) {
    warning("A filter named ", filter_name, " already exists. It will not be replaced.")
  }
  else {
    if(filter_name %in% names(private$filters)) message("A filter named ", filter_name, " already exists. It will be replaced by the new filter.")
    private$filters[[filter_name]] <- filter
    self$append_to_changes(list(Added_filter, filter_name))
    if(set_as_current) {
      self$current_filter <- filter
      self$data_changed <- TRUE
    }
  }
}
)

data_object$set("public", "get_current_filter", function() {
  return(private$.current_filter)
}
)

data_object$set("public", "filter_applied", function() {
  return(length(private$.current_filter) > 0)
}
)

data_object$set("public", "remove_current_filter", function() {
  self$current_filter <- list()
}
)