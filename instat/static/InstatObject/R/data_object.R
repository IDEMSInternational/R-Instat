data_obj <- setRefClass("data_obj", 
                            fields = list(data = "data.frame", metadata = "list", 
                                          variables_metadata = "data.frame", changes = "list", 
                                          data_changed = "logical", variables_metadata_changed = "logical",
                                          metadata_changed = "logical"))



# INITIALIZE method
##############################################################################################
# Functions of reference classes are called methods.
# This is how you define a method for a specific reference class.
# Every reference class has an initialize method which tells R how to create new 
# data_obj objects.
# By the end of this method, all fields of data_obj should be defined.

data_obj$methods(initialize = function(data = data.frame(), data_name = "", 
                                       variables_metadata = data.frame(), metadata = list(), 
                                       imported_from = "", 
                                       messages = TRUE, convert=TRUE, create = TRUE, 
                                       start_point=1)
{
  
  # Set up the data object
  
  .self$set_changes(list())
  .self$set_data(data, messages)
  .self$set_variables_metadata(variables_metadata)
  .self$update_variables_metadata()
  .self$set_meta(metadata)
  
  # If no name for the data.frame has been given in the list we create a default one.
  # Decide how to choose default name index
  if (!.self$is_metadata(data_name_label)) {    
    if ( ( is.null(data_name) || data_name == "" || missing(data_name))) {
      metadata[[data_name_label]] <<- paste0("data_set_",sprintf("%03d", start_point))
      if (messages) {
        message(paste0("No name specified in data_tables list for data frame ", start_point, ". 
                       Data frame will have default name: ", "data_set_",sprintf("%03d", start_point)))
      }
      }
    else metadata[[data_name_label]] <<- data_name      
    }

  .self$add_defaults_meta()
}
)

data_obj$methods(set_data = function(new_data, messages=TRUE) {
  if( ! is.data.frame(new_data) ) {
    stop("Data set must be of type: data.frame")
  }
  else {
    if ( length(new_data) == 0 && messages) {
      message("data of object:is empty. data will be an empty data frame.")
    }
    data <<- new_data
    .self$append_to_changes(list(Set_property, "data"))
    .self$set_data_changed(TRUE)
    .self$set_variables_metadata_changed(TRUE)
    #      is_data_split<<-FALSE
  }
}
)

data_obj$methods(set_meta = function(new_meta) {
  if( ! is.list(new_meta) ) {
    stop("new_meta must be of type: list")
  }
  metadata <<- new_meta
  .self$set_metadata_changed(TRUE)
  .self$append_to_changes(list(Set_property, "meta data"))
}
)

data_obj$methods(set_variables_metadata = function(new_meta) {
  if( ! is.data.frame(new_meta) ) {
    stop("variable metadata must be of type: data.frame")
  }
  variables_metadata <<- new_meta
  .self$append_to_changes(list(Set_property, "variable metadata"))
}
)

data_obj$methods(set_changes = function(new_changes) {
  if( ! is.list(new_changes) ) {
    stop("Changes must be of type: list")
  }
  
  else {
    changes <<- new_changes
    .self$append_to_changes(list(Set_property, "changes"))  }
}
)

data_obj$methods(set_data_changed = function(new_val) {
  if( new_val != TRUE && new_val != FALSE ) {
    stop("new_val must be TRUE or FALSE")
  }
  data_changed <<- new_val
  .self$append_to_changes(list(Set_property, "data_changed"))
}
)

data_obj$methods(set_variables_metadata_changed = function(new_val) {
  if( new_val != TRUE && new_val != FALSE ) {
    stop("new_val must be TRUE or FALSE")
  }
  variables_metadata_changed <<- new_val
  .self$append_to_changes(list(Set_property, "variable_data_changed"))
}
)

data_obj$methods(set_metadata_changed = function(new_val) {
  if( new_val != TRUE && new_val != FALSE ) {
    stop("new_val must be TRUE or FALSE")
  }
  metadata_changed <<- new_val
  .self$append_to_changes(list(Set_property, "metadata_changed"))
}
)

data_obj$methods(update_variables_metadata = function() {
  
  if(length(colnames(data)) !=  length(rownames(variables_metadata)) || !all(colnames(data)==rownames(variables_metadata))) {
    if(all(colnames(data) %in% rownames(variables_metadata))) {
      variables_metadata <<- variables_metadata[colnames(data),]
    }
    else {
      for(col in colnames(data)[!colnames(data) %in% rownames(variables_metadata)]) {
        variables_metadata[col, name_label] <<- col
        variables_metadata[col, display_decimal_label] <<- if(is.numeric(data[[col]])) if(min(data[[col]], na.rm = T)>100) 0 else if(min(data[[col]], na.rm = T)>10) 1 else 2 else NA
      }
    }
  }
  .self$append_to_changes(list(Set_property, "variables_metadata"))
}
)

data_obj$methods(get_data = function() {
  return(data)
}
)

data_obj$methods(get_variables_metadata = function(include_all = TRUE) {
  .self$update_variables_metadata()
  if(!include_all) return(variables_metadata)
  else {
    out = variables_metadata
    out[[data_type_label]] = sapply(data, class)
    return(out)
  }
}
)

data_obj$methods(get_metadata = function(label) {
  if(missing(label)) return(metadata)
  else {
    if(label %in% names(metadata)) return(metadata[[label]])
    else return("")
  }
}
)


data_obj$methods(add_column_to_data = function(col_name = "", col_data) {
  
  # Column name must be character
  if( ! is.character(col_name) ) stop("Column name must be of type: character")
  
  col_data <- unlist(col_data)
  
  if(col_name %in% names(data)) {
    message(paste("A column named", col_name, "already exists. The column will be replaced in the data"))
    .self$append_to_changes(list(Replaced_col, col_name))
  }
  
  else .self$append_to_changes(list(Added_col, col_name))
  
  data[[col_name]] <<- col_data
  .self$set_data_changed(TRUE)
  .self$set_variables_metadata_changed(TRUE)
}
)

data_obj$methods(get_column_from_data = function(col_name) {
  if(missing(col_name)) stop("no col_name to return")
  if(!col_name %in% names(data)) stop(paste(col_name, "not found in data"))
  
  return(data[[col_name]])
}
)
  
data_obj$methods(rename_column_in_data = function(curr_col_name = "", new_col_name="") {
  
  # Column name must be character
  if( ! is.character(curr_col_name) ) {
    stop("Current column name must be of type: character")
  }
  
  else if (!(curr_col_name %in% names(data))) {
    stop(paste0("Cannot rename column: ",curr_col_name,". Column was not found in the data."))
  }
  
  else if (! is.character(new_col_name)) {
    stop("New column name must be of type: character")
  }
  
  else {
    if(sum(names(data) == curr_col_name) > 1) {
      warning(paste0("Multiple columns have name: '", curr_col_name,"'. All such columns will be 
                     renamed."))
    }
    names(data)[names(data) == curr_col_name] <<- new_col_name
    .self$append_to_changes(list(Renamed_col, curr_col_name, new_col_name))
    .self$set_data_changed(TRUE)
    .self$set_variables_metadata_changed(TRUE)
  }
}
)

data_obj$methods(remove_column_in_data = function(col_name = "") {
  
  # Column name must be character
  if( ! is.character(col_name) ) {
    stop("Column name must be of type: character")
  }
  
  else if (!(col_name %in% names(data))) {
    stop(paste0("Column :'", col_name, " was not found in the data."))
  }
  
  else {
    data[[ col_name ]] <<- NULL 
    .self$append_to_changes(list(Removed_col, col_name))
  }
  .self$set_data_changed(TRUE)
  .self$set_variables_metadata_changed(TRUE)
}
)

data_obj$methods(replace_value_in_data = function(col_name = "", index, new_value = "") {
  
  # Column name must be character
  if( ! is.character(col_name) ) {
    stop("Column name must be of type: character")
  }
  
  else if (!(col_name %in% names(data))) {
    stop(paste("Cannot find column:",col_name,"in the data."))
  }
  
  # Column data length must match number of rows of data.
  else if ( missing(index) || !(is.numeric(index)) ) {
    stop(paste("Specify the index of the value to be replaced as an integer."))
  }
  
  else if (   index != as.integer(index) || index < 1 || index >  nrow(data) ) {
    stop( paste("index must be an integer between 1 and", nrow(data), ".") )
  }
  
  if ( class(data[[col_name]][[index]]) != class(new_value)) {
    warning("Class of new value does not match the class of the replaced value.")
  }
  
  old_value = data[[col_name]][[index]]
  data[[col_name]][[index]] <<- new_value
  .self$append_to_changes(list(Replaced_value, col_name, index, old_value, new_value))
  .self$set_data_changed(TRUE)
  .self$set_variables_metadata_changed(TRUE)
}
)


data_obj$methods(append_to_metadata = function(name, value) {
  
  if( missing(name) || missing(value) ) {
    stop("name and value arguements must be specified.")
  } 
  
  
  else if ( ! is.character(name) ) {
    stop("name must be of type: character")
  }
  
  # Remember double brackets must be used when dealing with variable names.
  else {
    metadata[[name]] <<- value 
    .self$append_to_changes(list(Added_metadata, name))
  }
}
)

data_obj$methods(append_to_changes = function(value) {
  
  if( missing(value) ) {
    stop(" value arguements must be specified.")
  } 
  else {
    changes[[length(changes)+1]] <<- value 
  }
}
)

data_obj$methods(is_metadata = function(str) {
  out = FALSE
  
  if(str %in% names(metadata) ) {
    out = TRUE
  }
  return(out)
}
)

data_obj$methods(add_defaults_meta = function(user) {
  append_to_metadata(is_calculated_label,FALSE)
  }
)

data_obj$methods(remove_row_in_data = function(row_num) {

  if (   row_num != as.integer(row_num) || row_num < 1 || row_num >  nrow(data) ) {
    stop( paste("index must be an integer between 1 and", nrow(data), ".") )
  }
  else if (row_num > nrow(data)) {
      stop(paste0(" Row: '", row_num, " does not exist in the data."))
    }
  else {
    data <<- data[-row_num,]
    .self$append_to_changes(list(Removed_row, row_num))
  }
  .self$set_data_changed(TRUE)
}
)

data_obj$methods(get_next_default_column_name = function(prefix) {
  if(!is.character(prefix)) stop("prefix must be of type character")
  col_exists = TRUE
  i = 1
  while(col_exists) {
    if(!paste0(prefix,i) %in% names(data)) {
      col_exists = FALSE
      out = paste0(prefix,i)
    }
    i = i + 1
  }
  out
} 
)

data_obj$methods(insert_column_in_data = function(col_name = "", col_data =c(), col_number) {
  if (col_number <= 0) stop("You cannot put a column into the position less or equal to zero.")
  if (col_number %% 1 != 0) stop("col_number value should be an integer.")
  if (length(names(data)) < col_number) stop("The col_number argument exceeds the number of columns in the data.")

    
  if(length(col_data)==0){
      col_data <- rep(NA, nrow(data))
      warning(paste("You are inserting an empty column to", get_metadata(data_name_label)))
  }

  data[, col_name] <<- col_data
  if(col_number==1){
      data <<- cbind(data[ncol(data)], data[(col_number):ncol(data)-1])
    }
  else{
      data <<- cbind(data[1:(col_number -1)],data[ncol(data)], data[(col_number+1):ncol(data)-1])
    }
  
    .self$append_to_changes(list(Inserted_Col, col_number))
}
)

#Labels for strings which will be added to logs
Set_property="Set"
Added_col="Added column"
Replaced_col="Replaced column"
Renamed_col="Renamed column"
Removed_col="Removed column"
Added_metadata="Added metadata"
Converted_col_="Converted column"
Replaced_value="Replaced value"
Removed_row="Removed row"
Inserted_Col = "Inserted column"

#meta data labels
data_name_label="data_name"
is_calculated_label="is_calculated"
decimal_places_label="decimal_places"
columns_label="columns"

#variables_metadata labels
display_decimal_label="DisplayDecimal"
name_label="Name"
is_factor_label="IsFactor"
data_type_label="DataType"