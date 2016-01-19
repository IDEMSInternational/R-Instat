# Defining the reference class "instat_obj"
# This reference class can contain multiple data_objs

instat_obj <- setRefClass("instat_obj", 
                       fields = list(data_objects = "list", 
                                     metadata = "list", models = "list")
)

# INITIALIZE method
##############################################################################################
# Functions of reference classes are called methods.
# This is how you define a method for a specific reference class.
# Every reference class has an initialize method which tells R how to create new 
# instat objects.

instat_obj$methods(initialize = function(data_tables = list(), instat_obj_metadata = list(), 
                                         data_tables_variables_metadata = rep(list(data.frame()),length(data_tables)),
                                         data_tables_metadata = rep(list(list()),length(data_tables)),
                                         imported_from = as.list(rep("",length(data_tables))),
                                         messages=TRUE, convert=TRUE, create=TRUE)
{
  
  .self$set_meta(instat_obj_metadata)
  .self$set_models(list())

  if (missing(data_tables) || length(data_tables) == 0) {
    data_objects <<- list()
  }
  
  else {
    .self$import_data(data_tables=data_tables, data_tables_variables_metadata=data_tables_variables_metadata, 
                      data_tables_metadata=data_tables_metadata, 
                      imported_from=imported_from, messages=messages, convert=convert, create=create)
  }
  
}
)

# IMPORT DATA FUNCTION
##############################################################################################

instat_obj$methods(import_data = function(data_tables = list(), data_tables_variables_metadata = rep(list(data.frame()),length(data_tables)),
                                          data_tables_metadata = rep(list(list()),length(data_tables)),
                                          imported_from = as.list(rep("",length(data_tables))), 
                                          messages=TRUE, convert=TRUE, create=TRUE)
{
  
  if (missing(data_tables) || length(data_tables) == 0) {
    stop("No data found. No data objects can be created.")
  }
  
  else {
    
    if ( ! (class(data_tables) == "list") )  {
      stop("data_tables must be a list of data frames")
    }
    
    if (length(unique(names(data_tables))) != length(names(data_tables)) ) {
      stop("There are duplicate names in the data tables list.")
    }
    
    if ( !(length(data_tables_variables_metadata) == length(data_tables)) ) { 
      stop("If data_tables_variables_metadata is specified, it must be a list of metadata lists with the same
           length as data_tables.")
    }
    
    if ( !(length(data_tables_metadata) == length(data_tables)) ) { 
      stop("If data_tables_metadata is specified, it must be a list of metadata lists with the same
           length as data_tables.")
    }
    
    if ( length(imported_from) != length(data_tables) ) { 
      stop("imported_from must be a list of the same length as data_tables")
    }
    
    # loop through the data_tables list and create a data object for each
    # data.frame given
    
    new_data_objects = list()
    
    for ( i in (1:length(data_tables)) ) {
      new_data = data_obj$new(data=data_tables[[i]], data_name = names(data_tables)[[i]],
                              variables_metadata = data_tables_variables_metadata[[i]],
                              metadata = data_tables_metadata[[i]], 
                              imported_from = imported_from[[i]], 
                              start_point = i, 
                              messages = messages, convert = convert, create = create)
      
      # Add this new data object to our list of data objects
      .self$append_data_objects(new_data$metadata[[data_name_label]],new_data)
    }
    }
  }
)

instat_obj$methods(set_meta = function(new_meta) {
  if( ! is.list(new_meta) ) {
    stop("new_meta must be of type: list")
  }
  metadata <<- new_meta
}
)

instat_obj$methods(set_models = function(new_models) {
  if( ! is.list(new_models) ) {
    stop("new_models must be of type: list")
  }
  models <<- new_models
}
)

instat_obj$methods(append_data_objects = function(name, obj) {
  if( !class(name) == "character") {
    stop("name must be a character")
  }
  
  if ( !class(obj) == "data_obj") {
    stop("obj must be a data object")
  }
  
  data_objects[[name]] <<- obj
}
)

instat_obj$methods(get_data = function(obj_name) { 
  if(missing(obj_name)) {
    retlist <- list()
    for ( i in (1:length(data_objects)) ) {
      retlist[[names(data_objects)[[i]]]] = data_objects[[i]]$get_data()
    }
    return(retlist)
  }
  else return(data_objects[[obj_name]]$get_data())
  } 
)

instat_obj$methods(get_variables_metadata = function(data_name) { 
  if(missing(data_name)) {
    retlist <- list()
  for ( i in (1:length(data_objects)) ) {
    retlist[[names(data_objects)[[i]]]] = data_objects[[i]]$get_variables_metadata()
  }
  return(retlist)
  }
  else return(data_objects[[data_name]]$get_variables_metadata())
} 
)

instat_obj$methods(get_combined_metadata = function() { 
  retlist <- data.frame()
  for ( i in (1:length(data_objects)) ) {
    templist=data_objects[[i]]$get_metadata()
    for ( j in (1:length(templist)) ) {
      retlist[names(data_objects)[[i]],names(templist[j])] =templist[[j]]         
    }
  }
  return(retlist)
} 
)

instat_obj$methods(get_data_names = function() { 
  return(names(.self$data_objects))
} 
)

instat_obj$methods(get_data_changed = function(obj_name) {
  if(missing(obj_name)) {
    for(curr_obj in data_objects) {
      if(curr_obj$data_changed) return(TRUE)
    }
    return(FALSE)
  }
  else {
    return(data_objects[[obj_name]]$data_changed)
  }
} 
)

instat_obj$methods(get_variables_metadata_changed = function(data_obj) { 
  if(missing(data_obj)) {
    for(curr_obj in data_objects) {
      if(curr_obj$variables_metadata_changed) return(TRUE)
    }
    return(FALSE)
  }
  else {
    return(data_objects[[data_obj]]$variables_metadata_changed)
  }
} 
)

instat_obj$methods(get_metadata_changed = function(data_obj) { 
  if(missing(data_obj)) {
    for(curr_obj in data_objects) {
      if(curr_obj$metadata_changed) return(TRUE)
    }
    return(FALSE)
  }
  else {
    return(data_objects[[data_obj]]$metadata_changed)
  }
} 
)

instat_obj$methods(set_data_frames_changed = function(obj_name = "", new_val) {
  if(obj_name == "") {
    for(curr_obj in data_objects) {
      curr_obj$set_data_changed(new_val)
    }
  }
  
  else data_objects[[obj_name]]$set_data_changed(new_val)
  
} 
)

instat_obj$methods(set_variables_metadata_changed = function(obj_name = "", new_val) {
  if(obj_name == "") {
    for(curr_obj in data_objects) {
      curr_obj$set_variables_metadata_changed(new_val)
    }
  }
  
  else data_objects[[obj_name]]$set_variables_metadata_changed(new_val)
} 
)

instat_obj$methods(set_metadata_changed = function(obj_name = "", new_val) {
  if(obj_name == "") {
    for(curr_obj in data_objects) {
      curr_obj$set_metadata_changed(new_val)
    }
  }
  
  else data_objects[[obj_name]]$set_metadata_changed(new_val)
} 
)

instat_obj$methods(add_column_to_data = function(obj_name, col_name, col_data) {
  if(missing(obj_name)) stop("obj_name is required")
  if(!obj_name %in% names(data_objects)) stop(paste(obj_name, "not found"))
  
  data_objects[[obj_name]]$add_column_to_data(col_name, col_data)
}
)

instat_obj$methods(get_column_from_data = function(obj_name, col_name) {
  if(missing(obj_name)) stop("obj_name is required")
  if(!obj_name %in% names(data_objects)) stop(paste(obj_name, "not found"))
  
  data_objects[[obj_name]]$get_column_from_data(col_name)
}
)

instat_obj$methods(add_model = function(model, model_name = paste("model",length(models)+1)) {
  if(missing(model)) stop("model is required")
  if(model_name %in% names(models)) message(paste("A model called", model_name, "already exists. It will be replaced."))
  
  models[[model_name]] <<- model
}
)

instat_obj$methods(get_model = function(model_name) {
  if(missing(model_name)) stop("model_name is required")
  if(!is.character(name)) stop("name must be a character")
  if(!name %in% names(models)) stop(name, "not found in models")
  models[[model_name]]
}
)

instat_obj$methods(replace_value_in_data = function(obj_name, column_name, row_number, new_val) {
  if(!is.character(obj_name)) stop("obj_name must be of type character")
  if(!obj_name %in% names(data_objects)) stop(paste("dataframe: ", obj_name, " not found"))
  
  data_objects[[obj_name]]$replace_value_in_data(column_name, row_number, new_val)
} 
)

instat_obj$methods(rename_column_in_data = function(obj_name, column_name, new_val) {
    if(!is.character(obj_name)) stop("obj_name must be of type character")
    if(!obj_name %in% names(data_objects)) stop(paste("dataframe: ", obj_name, " not found"))
    
    data_objects[[obj_name]]$rename_column_in_data(column_name, new_val)
  } 
  )

instat_obj$methods(remove_column_in_data = function(obj_name, column_name) {
  if(!is.character(obj_name)) stop("obj_name must be of type character")
  if(!obj_name %in% names(data_objects)) stop(paste("dataframe: ", obj_name, " not found"))
  
  data_objects[[obj_name]]$remove_column_in_data(column_name)
} 
)

instat_obj$methods(remove_row_in_data = function(obj_name, row_num) {
  if(!is.character(obj_name)) stop("obj_name must be of type character")
  if(!obj_name %in% names(data_objects)) stop(paste("dataframe: ", obj_name, " not found"))
  
  data_objects[[obj_name]]$remove_row_in_data(row_num)
} 
)

instat_obj$methods(get_next_default_column_name = function(obj_name, prefix) {
  if(missing(obj_name)) {
    out = list()
    for(curr_obj in data_objects) {
      out[[curr_obj$get_metadata(data_name_label)]] = curr_obj$get_next_default_column_name(prefix)
    }
    return(out)
  }
  if(!is.character(obj_name)) stop("obj_name must be of type character")
  if(!obj_name %in% names(data_objects)) stop(paste("dataframe: ", obj_name, " not found"))
  
  return(data_objects[[obj_name]]$get_next_default_column_name(prefix))
} 
)

instat_obj$methods(get_column_names = function(obj_name) {
  if(missing(obj_name)) stop("obj_name must be given")
  if(!is.character(obj_name)) stop("obj_name must be of type character")
  if(!obj_name %in% names(data_objects)) stop(paste("dataframe: ", obj_name, " not found"))
  return(names(data_objects[[obj_name]]$data))
}
)

instat_obj$methods(insert_column_in_data = function(obj_name, col_name = "", col_data = c(), col_number) {
  if(!is.character(obj_name)) stop("obj_name must be of type character")
  if(!obj_name %in% names(data_objects)) stop(paste("dataframe: ", obj_name, " not found"))
  
  data_objects[[obj_name]]$insert_column_in_data(col_name = col_name, col_data = col_data, col_number = col_number)
}
)

instat_obj$methods(move_column_in_data = function(obj_name, col_name = "", col_number) {
  if(!is.character(obj_name)) stop("obj_name must be of type character")
  if(!obj_name %in% names(data_objects)) stop(paste("dataframe: ", obj_name, " not found"))
  
  data_objects[[obj_name]]$move_column_in_data(col_name = col_name, col_number = col_number)
}
)