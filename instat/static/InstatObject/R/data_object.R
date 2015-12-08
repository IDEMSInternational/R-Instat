data_obj <- setRefClass("data_obj", 
                            fields = list(data = "data.frame", meta_data = "list", 
                                          variable_metadata = "data.frame",changes = "list"))



# INITIALIZE method
##############################################################################################
# Functions of reference classes are called methods.
# This is how you define a method for a specific reference class.
# Every reference class has an initialize method which tells R how to create new 
# data_obj objects.
# By the end of this method, all fields of data_obj should be defined.

data_obj$methods(initialize = function(data = data.frame(), data_name = "", 
                                       variable_metadata = data.frame(), meta_data = list(), 
                                       imported_from = "", 
                                       messages = TRUE, convert=TRUE, create = TRUE, 
                                       start_point=1)
{
  
  # Set up the Climate data object
  
  .self$set_changes(list())
  .self$set_data(data, messages)
  .self$set_variable_metadata(variable_metadata)
  .self$update_variable_metadata(data, messages)
  .self$set_meta(meta_data)

  # If no name for the data.frame has been given in the list we create a default one.
  # Decide how to choose default name index
  if (!.self$is_meta_data(data_name_label)) {    
    if ( ( is.null(data_name) || data_name == "" || missing(data_name))) {
      meta_data[[data_name_label]] <<- paste0("data_set_",sprintf("%03d", start_point))
      if (messages) {
        message(paste0("No name specified in data_tables list for data frame ", start_point, ". 
                       Data frame will have default name: ", "data_set_",sprintf("%03d", start_point)))
      }
      }
    else meta_data[[data_name_label]] <<- data_name      
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
    #      is_data_split<<-FALSE
  }
}
)

data_obj$methods(set_meta = function(new_meta) {
  if( ! is.list(new_meta) ) {
    stop("new_meta must be of type: list")
  }
  meta_data <<- new_meta
  .self$append_to_changes(list(Set_property, "meta data"))
}
)

data_obj$methods(set_variable_metadata = function(new_meta) {
  if( ! is.data.frame(new_meta) ) {
    stop("variable metadata must be of type: data.frame")
  }
  variable_metadata <<- new_meta
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

data_obj$methods(update_variable_metadata = function(new_data, messages=TRUE) {
  if( is.data.frame(new_data) ) {
    if (nrow(variable_metadata)==0){
      variable_metadata <<- data.frame(Name=colnames(new_data), DisplayDecimal=sapply(new_data, function(x) if(is.numeric(x)) if(min(x, na.rm = T)>100) 0 else 2 else NA))
    } 
    .self$append_to_changes(list(Set_property, "variable_metadata"))
  }
}
)

data_obj$methods(get_data = function() {
  return(data)
}
)

data_obj$methods(get_variable_metadata = function() {
  return(variable_metadata)
}
)

data_obj$methods(get_meta_data = function() {
  return((meta_data))
}
)

data_obj$methods(append_column_to_data = function(column_data, col_name = "", replace = FALSE) {
  
  # Column name must be character
  if( ! is.character(col_name) ) stop("Column name must be of type: character")
  
  # Column data length must match number of rows of data.
  if ( !( length(column_data) == nrow(data) ) ) {
    stop(paste("Number of rows in new column does not match the number of rows in the data set.
               There must be", nrow(data), "entries in the new column."))
  }
  
  
  column_data <- unlist(column_data)
  # If no name given, generate a default column name.
  if (col_name == "") {
    col_name = paste0("column_",sprintf("%02d", length(names(data))+1))
  }
  
  if(col_name %in% names(data)) {
    message(paste("A column named", col_name, "already exists."))
    if(replace) {
      message("The variable will be replaced in the data")
      data[[col_name]] <<- column_data
      .self$append_to_changes(list(Replaced_col, col_name))
    }
    else message("The column will not be replaced. Specify replace = TRUE to replace this column.")
  }
  
  else {
    data[[col_name]] <<- column_data
    .self$append_to_changes(list(Added_col, col_name))
  }
}
)

data_obj$methods(replace_column_in_data = function(col_name = "", column_data) {
  
  # Column name must be character
  if( ! is.character(col_name) ) {
    stop("Column name must be of type: character")
  }
  
  else if (!(col_name %in% names(data))) {
    stop(paste0("Cannot replace column: ",col_name,". Column was not found in the data."))
  }
  
  # Column data length must match number of rows of data.
  else if ( !( length(column_data) == nrow(data) ) )
    stop(paste("Number of rows in new column does not match the number of rows in the data set.
               There must be", nrow(data), "entries in the new column."))
  
  else {
    data[[col_name]] <<- column_data
    .self$append_to_changes(list(Replaced_col, col_name))
    #      is_data_split<<-FALSE
  }
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
  
}
)


data_obj$methods(append_to_meta_data = function(name, value) {
  
  if( missing(name) || missing(value) ) {
    stop("name and value arguements must be specified.")
  } 
  
  
  else if ( ! is.character(name) ) {
    stop("name must be of type: character")
  }
  
  # Remember double brackets must be used when dealing with variable names.
  else {
    meta_data[[name]] <<- value 
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

data_obj$methods(is_meta_data = function(str) {
  out = FALSE
  
  if(str %in% names(meta_data) ) {
    out = TRUE
  }
  return(out)
}
)

data_obj$methods(add_defaults_meta = function(user) {
  append_to_meta_data(is_calculated_label,FALSE)
  }
)

#Labels for strings which will be added to logs
Set_property="Set"
Added_col="Added column"
Added_col_label="Added variable"
Replaced_col="Replaced column"
Renamed_col="Renamed column"
Removed_col="Removed column"
Added_metadata="Added metadata"
Converted_col_="Converted column"
Replaced_value="Replaced value"

#meta data labels
data_name_label="data_name"
is_calculated_label="is_calculated"
decimal_places_label="decimal_places"
columns_label="columns"