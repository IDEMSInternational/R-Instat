# Defining the reference class "instat_obj"
# This reference class can contain multiple data_objs

instat_obj <- setRefClass("instat_obj", 
                          fields = list(data_objects = "list", 
                                        metadata = "list", models = "list", 
                                        data_objects_changed = "logical")
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
  
  .self$data_objects_changed <<- FALSE
  
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
instat_obj$methods(import_RDS = function(data_RDS, keep_existing =TRUE, overwrite_existing=FALSE, include_models=TRUE,
                                         include_graphics=TRUE, include_metadata=TRUE, include_logs=TRUE,messages=TRUE)
{ 
  if(class(data_RDS) == "instat_obj"){ 
    if (!keep_existing & include_models & include_graphics & include_metadata & include_logs){
      .self$replace_instat_object(new_instatObj = data_RDS) 
    } else {
      if (!keep_existing) {
        .self$clear_data()
        .self$set_meta(list())
        .self$set_models(list())
      }
      for ( i in (1:length(data_RDS$data_objects)) ) {
        if (!(data_RDS$data_objects[[i]]$metadata[[data_name_label]] %in% names(data_objects)) | overwrite_existing){
          #TODO in data_object if (!include_models) data_RDS$data_objects[i]$clear_models
          #TODO in data_object if (!include_graphics) data_RDS$data_objects[i]$clear_graphics
		  curr_data_name = data_RDS$data_objects[[i]]$metadata[[data_name_label]]
          if (!include_metadata) {
            data_RDS$data_objects[[i]]$set_meta(list()) 
			data_RDS$data_objects[[i]]$add_defaults_meta()
            data_RDS$data_objects[[i]]$set_variables_metadata(data.frame())
			data_RDS$data_objects[[i]]$update_variables_metadata() 
            
          }
          if (!include_logs) data_RDS$data_objects[i]$set_changes(list())
          # Add this new data object to our list of data objects
          .self$append_data_objects(curr_data_name,data_RDS$data_objects[[i]])
        }
      }
      if (include_models & length(data_RDS$models) > 0){
        for ( i in (1:length(data_RDS$models)) ) {
          if (!(names(data_RDS$models)[i] %in% names(models)) | overwrite_existing){ 
            .self$add_model(data_RDS$models[i],names(data_RDS$models)[i])
          }
        }
      }
      if (include_metadata & length(data_RDS$metadata) > 0){
        for ( i in (1:length(data_RDS$metadata)) ) {
          if (!(names(data_RDS$metadata)[i] %in% names(metadata)) | overwrite_existing){ 
            .self$metadata[names(data_RDS$models)[i]]<<-data_RDS$metadata[i] #todo this should be in an addmetadata method
          }
        }
      }
    }
    data_objects_changed <<- TRUE
  }
  else if (is.data.frame(data_RDS)) {
    .self$import_data(data_tables = list(data_RDS = data_RDS))
  }
  else{
    if (messages){
    stop(paste("RDS_data: ", data_RDS, " Unidentified Object"))#TODO work on messages and error handling
    }
  }
}
)

instat_obj$methods(replace_instat_object = function(new_instatObj) { 
   data_objects<<-new_instatObj$data_objects  
   .self$set_meta(new_instatObj$metadata) 
   .self$set_models(new_instatObj$models) 
   data_objects_changed <<- TRUE 
   lapply(data_objects, function(x) x$set_data_changed(TRUE))
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
  data_objects[[name]]$data_changed <<- TRUE
}
)

instat_obj$methods(clear_data = function() {
  
  data_objects <<- list()
}
)

instat_obj$methods(get_data_frame = function(data_name, convert_to_character = FALSE, 
                                             stack_data = FALSE,...) {
  if(!stack_data) {
    if(missing(data_name)) {
      retlist <- list()
      for ( i in (1:length(data_objects)) ) {
        retlist[[names(data_objects)[[i]]]] = data_objects[[i]]$get_data_frame(convert_to_character = convert_to_character)
      }
      return(retlist)
    }
    else return(data_objects[[data_name]]$get_data_frame(convert_to_character = convert_to_character))
  }
  else {
    if(missing(data_name)) stop("data to be stacked is missing")
    if(!data_name %in% names(data_objects)) stop(paste(data_name, "not found."))
    return(melt(data_objects[[data_name]]$get_data_frame(), ...))
  }
}
)

instat_obj$methods(get_variables_metadata = function(data_name, data_type = "all", convert_to_character = FALSE) { 
  if(missing(data_name)) {
    retlist <- list()
    for ( i in (1:length(data_objects)) ) {
      retlist[[names(data_objects)[[i]]]] = data_objects[[i]]$get_variables_metadata(data_type = data_type, convert_to_character = convert_to_character)
    }
    return(retlist)
  }
  else return(data_objects[[data_name]]$get_variables_metadata(data_type = data_type, convert_to_character = convert_to_character))
} 
)

instat_obj$methods(get_combined_metadata = function(convert_to_character = FALSE) { 
  retlist <- data.frame()
  for ( i in (1:length(data_objects)) ) {
    templist=data_objects[[i]]$get_metadata()
    for ( j in (1:length(templist)) ) {
      retlist[names(data_objects)[[i]],names(templist[j])] =templist[[j]]         
    }
  }
  if(convert_to_character) return(convert_to_character_matrix(retlist, FALSE))
  else return(retlist)
} 
)

instat_obj$methods(get_data_names = function() { 
  return(names(.self$data_objects))
} 
)

instat_obj$methods(get_data_changed = function(data_name) {
  if(missing(data_name)) {
    if(data_objects_changed) return (TRUE)
    for(curr_obj in data_objects) {
      if(curr_obj$data_changed) return(TRUE)
    }
    return(FALSE)
  }
  else {
    return(data_objects[[data_name]]$data_changed)
  }
} 
)

instat_obj$methods(get_variables_metadata_changed = function(data_obj) { 
  if(missing(data_obj)) {
    if(data_objects_changed) return (TRUE)
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
    if(data_objects_changed) return (TRUE)
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

instat_obj$methods(set_data_frames_changed = function(data_name = "", new_val) {
  if(data_name == "") {
    for(curr_obj in data_objects) {
      curr_obj$set_data_changed(new_val)
    }
  }
  
  else data_objects[[data_name]]$set_data_changed(new_val)
  
} 
)

instat_obj$methods(set_variables_metadata_changed = function(data_name = "", new_val) {
  if(data_name == "") {
    for(curr_obj in data_objects) {
      curr_obj$set_variables_metadata_changed(new_val)
    }
  }
  
  else data_objects[[data_name]]$set_variables_metadata_changed(new_val)
} 
)

instat_obj$methods(set_metadata_changed = function(data_name = "", new_val) {
  if(data_name == "") {
    for(curr_obj in data_objects) {
      curr_obj$set_metadata_changed(new_val)
    }
  }
  
  else data_objects[[data_name]]$set_metadata_changed(new_val)
} 
)

instat_obj$methods(add_columns_to_data = function(data_name, col_name, col_data, use_col_name_as_prefix) {
  if(missing(data_name)) stop("data_name is required")
  if(!data_name %in% names(data_objects)) stop(paste(data_name, "not found"))
  
  if(missing(use_col_name_as_prefix)) data_objects[[data_name]]$add_columns_to_data(col_name, col_data)
  else data_objects[[data_name]]$add_columns_to_data(col_name, col_data, use_col_name_as_prefix = use_col_name_as_prefix)
}
)

instat_obj$methods(get_columns_from_data = function(data_name, col_names, from_stacked_data = FALSE,
                                                    force_as_data_frame = FALSE) {
  if(missing(data_name)) stop("data_name is required")
  if(!from_stacked_data) {
    if(!data_name %in% names(data_objects)) stop(paste(data_name, "not found"))
    data_objects[[data_name]]$get_columns_from_data(col_names, force_as_data_frame)
  }
  else {
    if(!exists(data_name)) stop(paste(data_name, "not found."))
    if(!all(sapply(col_names, function(x) x %in% names(data_name)))) stop("Not all column names were found in data")
    if(length(col_names)==1) return (data_name[[col_names]])
    else return(data_name[col_names])
  }
}
)

instat_obj$methods(add_model = function(model, model_name = paste("model",length(models)+1)) {
  if(missing(model)) stop("model is required")
  if(model_name %in% names(models)) message(paste("A model called", model_name, "already exists. It will be replaced."))
  
  models[[model_name]] <<- model
}
)

instat_obj$methods(get_model = function(model_name) {
  if(missing(model_name)) return(models)
  if(!is.character(model_name)) stop("name must be a character")
  if(!model_name %in% names(models)) stop(model_name, "not found in models")
  models[[model_name]]
}
)

instat_obj$methods(get_model_names = function() {
  return(names(models))
}
)

instat_obj$methods(get_from_model = function(model_name, value1, value2, value3) {
  if(missing(model_name)) stop("model_name must be specified.")
  if(!is.character(model_name)) stop("name must be a character")
  if(!model_name %in% names(models)) stop(model_name, "not found in models")
  if(missing(value1)) stop("value1 must be specified.")
  if(!value1 %in% names(get_model(model_name))) stop(paste(value1, "not found in", model_name))
  if(missing(value2)) {
    if(!missing(value3)) warning(paste("value2 is missing so value3 =",value3, "will be ignored."))
    return(get_model(model_name)[[value1]])
  }
  else {
    if(!value2 %in% names(get_model(model_name)[[value1]])) stop(paste0(value2, " not found in ", model_name,"[[\"",value1,"\"]]"))
    if(missing(value3)) return(get_model(model_name)[[value1]][[value2]])
    else {
      if(!value3 %in% names(get_model(model_name)[[value1]][[value2]])) stop(paste0(value3, " not found in ", model_name,"[[\"",value1,"\"]]","[[\"",value2,"\"]]"))
      return(get_model(model_name)[[value1]][[value2]][[value3]])
    }
  }
}
)

instat_obj$methods(replace_value_in_data = function(data_name, col_name, index, new_value) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  data_objects[[data_name]]$replace_value_in_data(col_name, index, new_value)
} 
)

instat_obj$methods(rename_column_in_data = function(data_name, column_name, new_val) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  data_objects[[data_name]]$rename_column_in_data(column_name, new_val)
} 
)

instat_obj$methods(remove_columns_in_data_from_start_position = function(data_name, start_pos, col_numbers) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  data_objects[[data_name]]$remove_columns_in_data_from_start_position(start_pos = start_pos, col_numbers = col_numbers)
} 
)

instat_obj$methods(remove_columns_in_data = function(data_name, cols) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  data_objects[[data_name]]$remove_columns_in_data(cols = cols)
} 
)

instat_obj$methods(remove_rows_in_data = function(data_name, start_pos, num_rows) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  data_objects[[data_name]]$remove_rows_in_data(start_pos  = start_pos, num_rows = num_rows)
} 
)

instat_obj$methods(get_next_default_column_name = function(data_name, prefix) {
  if(missing(data_name)) {
    out = list()
    for(curr_obj in data_objects) {
      out[[curr_obj$get_metadata(data_name_label)]] = curr_obj$get_next_default_column_name(prefix)
    }
    return(out)
  }
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  return(data_objects[[data_name]]$get_next_default_column_name(prefix))
} 
)

instat_obj$methods(get_column_names = function(data_name) {
  if(missing(data_name)) stop("data_name must be given")
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  return(names(data_objects[[data_name]]$data))
}
)

instat_obj$methods(insert_column_in_data = function(data_name, col_data =c(), start_pos, number_cols) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  data_objects[[data_name]]$insert_column_in_data(col_data = col_data, start_pos = start_pos, number_cols = number_cols )
}
)

# instat_obj$methods(move_columns_in_data = function(data_name, col_names = "", col_number){
#   if(!is.character(data_name)) stop("data_name must be of type character")
#   if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
#   
#   data_objects[[data_name]]$move_columns_in_data(col_names = col_names, col_number = col_number)
# }
# )

instat_obj$methods(order_columns_in_data = function(data_name, col_order){
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  data_objects[[data_name]]$order_columns_in_data(col_order = col_order)
}
)

instat_obj$methods(insert_row_in_data = function(data_name, start_pos, row_data = c(), number_rows) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  data_objects[[data_name]]$insert_row_in_data(start_pos  = start_pos, row_data = row_data, number_rows = number_rows)
}
)

instat_obj$methods(length_of_data = function(data_name) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  data_objects[[data_name]]$length_of_data()
}
)

instat_obj$methods(get_next_default_dataframe_name = function(prefix, include_index = TRUE, start_index = 1) {
  next_default_item(prefix = prefix, existing_names = names(data_objects), include_index = include_index, start_index = start_index)
} 
)

instat_obj$methods(delete_dataframe = function(data_name = data_name) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
 data_objects[[data_name]]$get_data_frame()<<-NULL
  data_objects_changed <<- TRUE
} 
)

instat_obj$methods(get_column_factor_levels = function(data_name,col_name = "") {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  data_objects[[data_name]]$get_column_factor_levels(col_name)
} 
)

instat_obj$methods(sort_dataframe = function(data_name, col_names = c(), decreasing = FALSE, na.last = TRUE) {
  #data_name = is.character(data_name)
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  data_objects[[data_name]]$sort_dataframe(col_names = col_names, decreasing = decreasing, na.last = na.last)
} 
)

instat_obj$methods(rename_dataframe = function(data_name, new_value = "") {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  for (i in 1:length(names(data_objects))){
    if(names(data_objects)[i] == data_name){
      names(data_objects)[i] <<- new_value
    }
  }
  
  data_objects[[new_value]]$append_to_metadata(data_name_label, new_value)
} 
)

instat_obj$methods(convert_column_to_type = function(data_name, col_names = c(), to_type ="factor", factor_numeric = "by_levels") {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  data_objects[[data_name]]$convert_column_to_type(col_names = col_names, to_type = to_type, factor_numeric = factor_numeric)
} 
)

instat_obj$methods(append_to_variables_metadata = function(data_name, col_name, property, new_val) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  data_objects[[data_name]]$append_to_variables_metadata(col_name, property, new_val)
} 
)

instat_obj$methods(append_to_dataframe_metadata = function(data_name, property, new_val) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  data_objects[[data_name]]$append_to_metadata(property, new_val)
} 
)


instat_obj$methods(order_dataframes = function(data_frames_order) {
  if(length(data_frames_order) != length(names(data_objects))) stop("number data frames to order should be equal to number of dataframes in the object")
  for(name in names(data_objects)){
    if(!(name %in% data_frames_order)){
      stop(name, "is missing in data frames to order")
    }
  }
  new_data_objects = list()
  for(i in 1:length(names(data_objects))){
    new_data_objects[[i]] = data_objects[[data_frames_order[i]]]
  }
  names(new_data_objects) <- data_frames_order
  data_objects <<- new_data_objects
  data_objects_changed <<- TRUE
} 
)

instat_obj$methods(copy_columns = function(data_name, col_names = "") {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  data_objects[[data_name]]$copy_columns(col_names = col_names)
} 
)

instat_obj$methods(drop_unused_factor_levels = function(data_name, col_name) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  data_objects[[data_name]]$drop_unused_factor_levels(col_name = col_name)
} 
)

instat_obj$methods(set_factor_levels = function(data_name, col_name, new_levels) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  data_objects[[data_name]]$set_factor_levels(col_name = col_name, new_levels = new_levels)
} 
)

instat_obj$methods(set_factor_reference_level = function(data_name, col_name, new_ref_level) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  data_objects[[data_name]]$set_factor_reference_level(col_name = col_name, new_ref_level = new_ref_level)
} 
)

instat_obj$methods(get_column_count = function(data_name) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  return(ncol(data_objects[[data_name]]$data))
} 
)

instat_obj$methods(reorder_factor_levels = function(data_name, col_name, new_level_names) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  data_objects[[data_name]]$reorder_factor_levels(col_name = col_name, new_level_names = new_level_names)
} 
)