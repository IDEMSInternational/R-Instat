# Defining the reference class "instat_obj"
# This reference class can contain multiple data_objs

instat_obj <- setRefClass("instat_obj", 
                       fields = list(data_objects = "list", 
                                     meta_data = "list")
)

# INITIALIZE method
##############################################################################################
# Functions of reference classes are called methods.
# This is how you define a method for a specific reference class.
# Every reference class has an initialize method which tells R how to create new 
# instat objects.

instat_obj$methods(initialize = function(data_tables = list(), instat_obj_meta_data = list(), 
                                         data_tables_variable_metadata = rep(list(data.frame()),length(data_tables)),
                                         data_tables_meta_data = rep(list(list()),length(data_tables)),
                                         imported_from = as.list(rep("",length(data_tables))),
                                         messages=TRUE, convert=TRUE, create=TRUE)
{
  
  meta_data <<- instat_obj_meta_data

  if (missing(data_tables) || length(data_tables) == 0) {
    data_objects <<- list()
  }
  
  else {
    .self$import_data(data_tables=data_tables, data_tables_variable_metadata=data_tables_variable_metadata, 
                      data_tables_meta_data=data_tables_meta_data, 
                      imported_from=imported_from, messages=messages, convert=convert, create=create)
  }
  
}
)

# IMPORT DATA FUNCTION
##############################################################################################

instat_obj$methods(import_data = function(data_tables = list(), data_tables_variable_metadata = rep(list(data.frame()),length(data_tables)),
                                          data_tables_meta_data = rep(list(list()),length(data_tables)),
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
    
    if ( !(length(data_tables_variable_metadata) == length(data_tables)) ) { 
      stop("If data_tables_variable_metadata is specified, it must be a list of meta_data lists with the same
           length as data_tables.")
    }
    
    if ( !(length(data_tables_meta_data) == length(data_tables)) ) { 
      stop("If data_tables_meta_data is specified, it must be a list of meta_data lists with the same
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
                              variable_metadata = data_tables_variable_metadata[[i]],
                              meta_data = data_tables_meta_data[[i]], 
                              imported_from = imported_from[[i]], 
                              start_point = i, 
                              messages = messages, convert = convert, create = create)
      
      # Add this new data object to our list of data objects
      .self$append_data_objects(new_data$meta_data[[data_name_label]],new_data)
    }
    }
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
#retlist <- list()
instat_obj$methods(get_data_list = function() { 
  retlist <- list()
  for ( i in (1:length(data_objects)) ) {
    retlist[[names(data_objects)[[i]]]] = data_objects[[i]]$get_data()
  }
  return(retlist)
  } 
)

instat_obj$methods(get_variable_info = function() { 
  retlist <- list()
  for ( i in (1:length(data_objects)) ) {
    retlist[[names(data_objects)[[i]]]] = data_objects[[i]]$get_variable_metadata()
  }
  return(retlist)
} 
)

instat_obj$methods(get_meta_data = function() { 
  retlist <- data.frame()
  for ( i in (1:length(data_objects)) ) {
    templist=data_objects[[i]]$get_meta_data()
    for ( j in (1:length(templist)) ) {
      retlist[names(data_objects)[[i]],names(templist[j])] =templist[[j]]         
    }
  }
  return(retlist)
} 
)
