# Defining the reference class "climate"
# This reference class can contain multiple climate_data objects
# The fields are the properties every climate_data object will have.

# climate_data_objects : A list of climate_data objects
# used_data_tables     : A list of extra climate_data objects, created during use
# meta_data            : Any information about the climate object. e.g. "name"


climate <- setRefClass("climate", 
                            fields = list(climate_data_objects = "list", used_data_objects = "list", 
                                          meta_data = "list")
)

# INITIALIZE method
##############################################################################################
# Functions of reference classes are called methods.
# This is how you define a method for a specific reference class.
# Every reference class has an initialize method which tells R how to create new 
# climate objects.
# By the end of this method, all fields of climate_data should be defined.
# Notice that we don't have a climate object as an input.
# We can refer to any field of a climate_data object by name. e.g. climate_data_objects

# data_tables           : list of data.frames - each one will be used to create a climate_data
#                         object
# data_tables_meta_data : list of meta_data lists - one for each data.frame
# data_tables_variables : list of variables lists - one for each data.frame
# climate_obj_meta_data : the meta_data for the climate object
# imported_from         : list of strings telling us where the data has come from
#                         - one for each data.frame                         

climate$methods(initialize = function(data_tables = list(), climate_obj_meta_data = list(), 
                                      data_tables_meta_data = rep(list(list()),length(data_tables)),
                                      data_tables_variables = rep(list(list()),length(data_tables)), 
                                      imported_from = as.list(rep("",length(data_tables))),
                                      data_time_periods = as.list(rep("daily",length(data_tables))),
                                      messages=TRUE, convert=TRUE, create=TRUE,
                                      date_formats = as.list(rep("%d/%m/%Y",length(data_tables))))
{

  meta_data <<- climate_obj_meta_data
  used_data_objects <<- list()
  
  if (missing(data_tables) || length(data_tables) == 0) {
    climate_data_objects <<- list()
    used_data_objects <<- list()
    meta_data <<- list()
  }
  
  else {
    .self$import_data(data_tables=data_tables,data_tables_meta_data=data_tables_meta_data, data_tables_variables=data_tables_variables, 
                      imported_from=imported_from, data_time_periods=data_time_periods, messages=messages, convert=convert, create=create,
                      date_formats=date_formats)
  }
  
}
)

# IMPORT DATA FUNCTION
##############################################################################################

climate$methods(import_data = function(data_tables = list(), data_tables_meta_data = rep(list(list()),length(data_tables)),
                                       data_tables_variables = rep(list(list()),length(data_tables)), 
                                       imported_from = as.list(rep("",length(data_tables))), 
                                       data_time_periods = as.list(rep("daily",length(data_tables))),
                                       messages=TRUE, convert=TRUE, create=TRUE, 
                                       date_formats = as.list(rep("%d/%m/%Y",length(data_tables))))
{

  if (missing(data_tables) || length(data_tables) == 0) {
    stop("No data found. No climate_data objects can be created.")
  }
  
  else {
    
    if ( ! (class(data_tables) == "list") )  {
      stop("data_tables must be a list of data frames")
    }
    
    if (length(unique(names(data_tables))) != length(names(data_tables)) ) {
      stop("There are duplicate names in the data tables list.")
    }
    
    if ( !(length(data_tables_meta_data) == length(data_tables)) ) { 
      stop("If data_tables_meta_data is specified, it must be a list of meta_data lists with the same
           length as data_tables.")
    }
    
    if ( !(length(data_tables_variables) == length(data_tables)) ) { 
      stop("If data_tables_variables is specified, it must be a list of variables lists with the same
           length as data_tables.")
    }
    
    if ( length(imported_from) != length(data_tables) ) { 
      stop("imported_from must be a list of the same length as data_tables")
    }
    
    if ( length(data_time_periods) != length(data_tables) ) { 
      stop("data_time_periods must be a list of the same length as data_tables")
    }

    if ( length(date_formats) != length(data_tables)  ) { 
      stop("date_formats must be a list of the same length as data_tables")
    }
    # loop through the data_tables list and create a climate_data object for each
    # data.frame given
    
    new_climate_data_objects = list()
    
    for ( i in (1:length(data_tables)) ) {
      
      new_data = climate_data$new(data=data_tables[[i]], data_name = names(data_tables)[[i]], 
                                  meta_data = data_tables_meta_data[[i]], variables = data_tables_variables[[i]], 
                                  imported_from = imported_from[[i]], 
                                  data_time_period = data_time_periods[[i]], start_point = i, 
                                  messages = messages, convert = convert, create = create,
                                  date_format = date_formats[[i]])
      
      # Add this new climate_data object to our list of climate_data objects
      .self$append_climate_data_objects( new_data$meta_data[[data_name_label]],new_data)
      
    }
  }
}
)
#TODO this is just a temporary function for abib to use while we understand the clidata formate
climate$methods(import_clidata = function(data_table, dataname="Clidata")
{

  temp<-melt(data_table,id=1:5,variable.name="Day",value.name="Rain")
  temp$Day= as.numeric(substr(temp$Day, 4, 5))

  #---------------------------------------------------------#
  # And write to climate data object
  #---------------------------------------------------------#
  new_data = climate_data$new(data=temp, data_name = dataname)
  
  # Add this new climate_data object to our list of climate_data objects
  .self$append_climate_data_objects( new_data$meta_data[[data_name_label]],new_data)
  
}
)

#TODO this is just a temporary function to use while we set up a more general ODBC link
climate$methods(import_sqldata = function(SQLquery, dataname="SQLdata",dbname="mysql_climsoft_db_v4", username="root", password="admin")
{
  
  con<-dbConnect(RMySQL::MySQL(),dbname=dbname, username=username, password=password )
  temp= dbSendQuery(con, SQLquery)
  
    #---------------------------------------------------------#
  # And write to climate data object
  #---------------------------------------------------------#
  new_data = climate_data$new(data=temp, data_name = dataname)
  
  # Add this new climate_data object to our list of climate_data objects
  .self$append_climate_data_objects( new_data$meta_data[[data_name_label]],new_data)
  
}
)
# Getter methods
###############################################################################################
# We can create methods to extract fields from a climate_data object.
# These are called getter methods and are usually very simple functions.
# Notice that no input is needed.

# get_climate_data_objects returns some of the climate_data objects in the climate object
# It will also create new ones if needed
# Specification by data_info

climate$methods(get_climate_data_objects = function(data_info= list()) {
  
  climate_data_list = list()

  if(time_period_label %in% names(data_info) ) {
    time_period=data_info[[time_period_label]]
  } else {
    time_period="any"
  } 
  #Convert data by default
  data_info = .self$add_to_data_info_convert(data_info)

  for (temp in climate_data_objects) {
    name = temp$meta_data[[data_name_label]]
    if(required_data_objs_list_label %in% names(data_info)) {
      if(!name %in% data_info[[required_data_objs_list_label]]) {
        next
      }
    }
    if (time_period==temp$data_time_period||time_period=="any"){
      if (required_variable_list_label %in% names(data_info)){
        if (!temp$is_present(data_info[[required_variable_list_label]])){
          next
        }
      }
      climate_data_list[[name]] <- temp 
    }
    else if (convert_data_label %in% names(data_info)){
      if (data_info[[convert_data_label]]){
        if(compare_time_periods(time_period,temp$data_time_period)){
          climate_data_list[[name]] <- .self$get_summary_name(time_period, temp)
        }
      }
    }
    #TO DO think hard whether we should restrict based on stations or not my inclination is not at the data object level.
  }
  #TODO Merge within Time tevels when any is selected.
  if (merge_data_label %in% names(data_info)){
    if (data_info[[merge_data_label]]){
      if (length(climate_data_list)>1){
        merge_obj <- .self$merge_vertical(climate_data_list)
        name = merge_obj$meta_data[[data_name_label]]
        climate_data_list <- list()
        climate_data_list[[name]] <- merge_obj 
      }
    }
  }

  return(climate_data_list)
  
}
)

climate$methods(get_used_data_objects = function() {
  return(used_data_objects)
}
)

climate$methods(get_meta_data = function() {
  return(meta_data)
}
)

# Create and edit data info methods
###############################################################################################
climate$methods(create_data_info = function(time_period="", station_list="", date_list="", required_variable_list="") {
  data_info=list()
  if (!missing(time_period)){
    #TO DO check that it is a valid time period
    data_info[[time_period_label]] <- time_period
  }
  if (!missing(station_list)){
    #TO DO check that it is valid 
    data_info[[station_list_label]] <- station_list
  }
  if (!missing(date_list)){
    #TO DO check that it is valid 
    data_info[[date_list_label]] <- date_list
  }
  if (!missing(required_variable_list)){
    #TO DO check that it is valid 
    data_info[[required_variable_list_label]] <- required_variable_list
  }
  
  return (data_info)
}
)

climate$methods(add_to_data_info_merge = function(data_info=list(), merged=FALSE) {
  if (merge_data_label %in% names(data_info)){
    if (data_info[[merge_data_label]]!=merged & !missing(merged)){
      warning ("overwriting user choice for merging data")
      data_info[[merge_data_label]]<-merged
    }
  }
  else data_info[[merge_data_label]]<-merged
  return (data_info)
}
)

climate$methods(add_to_data_info_convert = function(data_info=list(), convert=TRUE) {
  if (convert_data_label %in% names(data_info)){
    if (data_info[[convert_data_label]]!=convert & !missing(convert)){
      warning ("overwriting user choice for converting data")
      data_info[[convert_data_label]]<-convert
    }
  }
  else data_info[[convert_data_label]]<-convert
  return (data_info)
}
)

climate$methods(add_to_data_info_time_period = function(data_info=list(), time_period="") {
  if (time_period_label %in% names(data_info)){
    if (data_info[[time_period_label]]!=time_period & !missing(time_period)){
      warning ("overwriting user choice for time period")
      data_info[[time_period_label]]<-time_period
    }
  }
  else data_info[[time_period_label]]<-time_period
  return (data_info)
}
)

climate$methods(add_to_data_info_required_variable_list = function(data_info=list(), required_variable_list="") {
  if (!missing(required_variable_list)){
    #TO DO check required_variable_list is valid
    if (required_variable_list_label %in% names(data_info)){
      data_info[[required_variable_list_label]]<-c(data_info[[required_variable_list_label]],required_variable_list) #TO DO Check what happens to repeats 
    }
    else data_info[[required_variable_list_label]]<-required_variable_list
  }
  return (data_info)
}
)

#TO DO other creat and add methods

# Append methods
###############################################################################################
climate$methods(append_climate_data_objects = function(name, obj) {
  if( !class(name) == "character") {
    stop("name must be a character")
  }
  
  if ( !class(obj) == "climate_data") {
    stop("obj must be a climate_data object")
  }

  climate_data_objects[[name]] <<- obj
}
)

climate$methods(append_used_data_objects = function(data, data_name, meta_data = list(), variables = list(),
                                                    imported_from = "",   messages = TRUE, convert=TRUE, 
                                                    create = TRUE, identify_variables = TRUE, 
                                                    check_dates=TRUE, check_missing_dates = TRUE, 
                                                    date_format = "%m/%d/%Y", data_time_period) {
  new_data_obj = climate_data$new(data=data, data_name = data_name, meta_data = meta_data, 
                                  variables = variables, imported_from = imported_from, 
                              data_time_period = data_time_period, start_point = length(used_data_objects) + 1, 
                              messages = messages, convert = convert, create = create,
                              date_format = date_format)
  
  used_data_objects[[new_data_obj$get_meta(data_name_label)]] <<- new_data_obj
}
)

# is_present_or_meta can check if a given variable name (or list of variable names) is in the data.frame or the meta_data or neither.
# This will be used by other functions particularly related to station level data such as latitude, longditude etc. 
# TO DO check functionality for missing cols and if there are multiple elements in long format (currently will return true even if there are no instances possibly correct as like returning true when all values are missing?)

climate$methods(is_present_or_meta = function(str, require_all=TRUE, require_in_all=TRUE) {
  out = FALSE
  for (temp in climate_data_objects) {
    out=temp$is_present_or_meta(str,require_all)
    if (require_in_all) if (!out) break
    if (!require_in_all) if (out) break
  }
  return(out)
}
)


# Other methods
#############################################################################################
# All analysis functions will be methods of climate objects and NOT climate_data objects.
# This is because we can call the method once to do the calculations on multiple data.frames
# at the same time.
# All these methods will allow the user to specify which climate_data objects they want
# to do the analysis on.



  #------------------------------------------------------------------------
  # This function plots the missing values for the rainfall amount, per year
  # It is here to demonstrate how an output method 
  #
  # It has the following optional arguments:
  # data_list: Specify the subset of the data to use. 
  # threshold: threshold which determines if a day is dry if the rainfall amount is below it. This overrides the threshold stored in the metadata if provided.
  # fill_col: A list of colours to use the first is for rain days the second for dry and the third for missing, missing dates are blank
  # 
  # ----------------------------------------------------------------------------

climate$methods(plot_missing_values_rain = function(data_list=list(), threshold = 0.85, fill_col=c("blue","yellow","red"))
{    
  # get_climate_data_objects returns a list of the climate_data objects specified
  # in the arguements.
  # If no objects specified then all climate_data objects will be taken by default
  # TO DO have options such as colours and the rest
  data_list=add_to_data_info_required_variable_list(data_list, list(rain_label))
  data_list=add_to_data_info_time_period(data_list, daily_label)
  climate_data_objs_list = get_climate_data_objects(data_list)
  
  for(data_obj in climate_data_objs_list) {
    curr_threshold = data_obj$get_meta(threshold_label,threshold)
    
    rain_col  = data_obj$variables[[rain_label]]
    # If doy or year column is not in the data frame, create it.
    if ( !(data_obj$is_present(dos_label)&data_obj$is_present(season_label))) {
      # add_doy_col function does not exist yet.
      data_obj$add_doy_col()
    }
    dos_col = data_obj$variables[[dos_label]]
    season_col = data_obj$variables[[season_label]]
    curr_data_list=data_obj$get_data_for_analysis(data_list)
    
    for( curr_data in curr_data_list ) {
      a2<-subset(curr_data, curr_data[[rain_col]] > curr_threshold)
      a3<-subset(curr_data, curr_data[[rain_col]] <= curr_threshold)
      a1<-curr_data[is.na(curr_data[[rain_col]]),]
      #plot2<-plot.new()

      plot(curr_data[[season_col]],curr_data[[dos_col]], ylim=c(0,500), log = "", asp = NA, xlab="Year",ylab="Day of Year", main="Rain Present")
      #plot.window(xlim=c(min(curr_data[[season_col]]),max(curr_data[[season_col]])),ylim=c(0,500), log = "", asp = NA) #TO DO Tidy up graphical parameters
      #title(xlab="Year",ylab="Day of Year", main="Rain Present") #TO DO Need to think hard about how display name are stored
      legend("topright",c("Rain","Dry","NA"),fill=fill_col,horiz=TRUE)
      points(as.numeric(a1[[season_col]]),a1[[dos_col]],pch="-",col=fill_col[3])
      points(as.numeric(a2[[season_col]]),a2[[dos_col]],pch="-",col=fill_col[1])
      points(as.numeric(a3[[season_col]]),a3[[dos_col]],pch="-",col=fill_col[2])
      
      # TO DO output multiple plots in multiple ways
      #plot2
    }
  }
}
)


#==========================================================================
# date_col_check
# Method to check if date column is present and in correct format
# If the column is not there then it is created
# Danny's changes:
# Changed name
# Added convert and create arguements
# Added date_format as arguement
# Date column name is not changed if date column is already there
# Created replace_column_in_data method for climate_data to use to change class of date column


climate$methods(date_col_check = function(data_list=list(), date_format = "%d/%m/%Y", convert = TRUE,
                                          create = TRUE) 
{
  
  climate_data_objs = get_climate_data_objects(data_list)
  
  for(data_obj in climate_data_objs){
    data_obj$date_col_check(date_format= date_format, convert=convert, create=create)
    
  }
}
)

climate$methods(merge_vertical = function(climate_data_objs = climate_data_objects,
                                          identifier = "Station") 
{

  # TO DO: should argument be data_list instead of climate_data_objs?
  #        do we allow to merge subsets of the data or only whole data objects?
  #        what meta data should be stored in the merged data object so it can be
  #        uniquiely identified later.
  
  
  if(length(climate_data_objs) == 0) {
    stop("No climate_data objects have been given to merge.")
  }
  
  time_periods = list()
  for(data_obj in climate_data_objs) {
    time_periods = c(time_periods,data_obj$data_time_period)
  }
  
  if(length(unique(time_periods)) != 1) {
    stop("Cannot merge data sets that are using different time periods.")
  }
  
  merge_time_period = time_periods[[1]]
  
  for(used_obj in used_data_objects) {
    if(merge_time_period == used_obj$data_time_period && used_obj$is_meta_data(merged_from_label)
      && length(used_obj$meta_data[[merged_from_label]]) == length(names(climate_data_objs))
      && length(union(used_obj$meta_data[[merged_from_label]], names(climate_data_objs))) == length(names(climate_data_objs)) ) {
        return(used_obj)
    }
  }
  
  # identified_variables : data frame showing which recognised variables are in each data set
  identified_variables = data.frame(data_object=names(climate_data_objs))

  # vars : the list of variables found in the variables list for data objects
  #       some of these variables may not actually be in the data set
  vars = list()
  
  for(data_obj in climate_data_objs) {
    vars = c(vars,names(data_obj$variables))
  }
  vars = unique(vars)
  
  # used_vars : the subset of vars containing only the variables that appear in at least 
  #             one of the data sets
  used_vars = list()
  vars_names = list()
  
  for(curr_var in vars) {

    new_col = c()
    
    # new_col : logical vector showing which data sets contain curr_var
    for(data_obj in climate_data_objs) {    
      new_col = c(new_col,data_obj$is_present(curr_var))
      if( data_obj$is_present(curr_var) && !(curr_var %in% names(vars_names)) ) {
        vars_names[[curr_var]] <- data_obj$getvname(curr_var)
      }
    }
    
    # We are only interested in variables that appear in at least 1 data set
    if(sum(new_col) >= 1) {
      
      # Add new_col to identified_variables data frame
      identified_variables[,curr_var] = new_col
      used_vars = c(used_vars, curr_var)
    }
  }
  
  #######################################################################

  i = 1
  data_to_merge = list()
  for(data_obj in climate_data_objs) {
    
    curr_data_list = data_obj$get_data_for_analysis(data_info = list())
    
    for(curr_data in curr_data_list ) {
      
      if(identifier %in% names(curr_data)) {
        stop(paste0("There is already a column in: '", data_obj$get_meta("data_name"), "' with name: '",
                    identifier,"'. The identifier cannot be an exisiting column name."))
      }
      
      # Add an identifier column to each data set containing the data object name
      data_name = data_obj$get_meta(data_name_label)
      curr_data[[identifier]] <- factor(rep(data_name,nrow(data_obj$data)))
      date_col = vars_names[[date_label]]
      
      for(var_name in used_vars) {
        # The same variable may have different names in different data sets
        # so we rename these columns to be the same in each data set.
        if(identified_variables[i,var_name]) {
          old_col_name = data_obj$getvname(var_name)
          names(curr_data)[names(curr_data) == old_col_name] <- vars_names[[var_name]]
        }
    
        # If the variable is not present, but can be generated from other columns
        # create that column. e.g. year can be created from date column
          
        else if( var_name == year_label ) {
          year_col = vars_names[[var_name]]
          curr_data[[year_col]] <- factor(year(curr_data[[date_col]]), ordered = TRUE)
        }
    
        else if( var_name == month_label ) {
          month_col = vars_names[[var_name]]
          curr_data[[month_col]] <- factor(month(curr_data[[date_col]]), ordered = TRUE)
        }
    
        else if( var_name == day_label ) {
          day_col = vars_names[[var_name]]
          curr_data[[day_col]] <- factor(day(curr_data[[date_col]]), ordered = TRUE)
        }
          
      }
    data_to_merge[[length(data_to_merge)+1]] <- curr_data
    }
    i = i + 1
  }
  merge_data = rbind.fill(data_to_merge)

#   merged_obj = climate_data$new(data = merge_data, data_name = merge_name, start_point = length(used_data_objects)+1,
#                                   data_time_period = merge_time_period, check_missing_dates=FALSE)
#     
#   merged_obj$append_to_meta_data(merged_from_label, names(climate_data_objs))
  merge_name = paste(paste(names(climate_data_objs), collapse = '-'),"merged")  
  .self$append_used_data_objects(merge_data, data_name = merge_name, meta_data = list(merged_from = names(climate_data_objs)), data_time_period = merge_time_period)
  
  # return the merged object
  .self$used_data_objects[[ merge_name ]]

}
)

climate$methods(summary_created = function(time_period, data_obj) {
  
  if(missing(time_period)) {
    stop("Specify the time period of the summarized data.")
  }
  
  data_name = data_obj$get_meta(data_name_label)

  if(compare_time_periods(time_period,data_obj$data_time_period)) {
    summary_exist = FALSE
    for(used_obj in used_data_objects) {
      if(used_obj$is_meta_data(summarized_from_label) 
         && used_obj$get_meta(summarized_from_label) == data_name
         && used_obj$data_time_period == time_period) {
        summary_exist = TRUE
        break
      }
    }
  }
  summary_exist
}
)

climate$methods(get_summary_name = function(time_period, data_obj) 
{
  if(missing(time_period)) stop("Specify the time period of the summarized data.")
  if(missing(data_obj)) stop("Specify the data object to be summarized.")
  
  data_name = data_obj$get_meta(data_name_label)
  
  summary_exist = .self$summary_created(time_period, data_obj)

  ## TODO Add functionality so that create_summary only creates for data_obj
  if(!summary_exist) .self$create_summary(new_time_period = time_period)

  for(used_obj in used_data_objects) {
    if(used_obj$is_meta_data(summarized_from_label) 
       && used_obj$get_meta(summarized_from_label) == data_name
       && used_obj$data_time_period == time_period) {
      return(used_obj)
    }
  }
}
)

climate$methods(append_to_summary = function(time_period, data_obj, col_data, col_name="", label="",
                                             replace=FALSE)
{
  if(missing(time_period)) stop("Specify the time period of the summarized data.")
  if(missing(data_obj)) stop("Specify the data_obj.")
  
  summarized_obj = .self$get_summary_name(time_period, data_obj)
  summarized_obj$append_column_to_data(col_data, col_name, label, replace)
  
}
)


climate$methods(display_water_balance = function(data_list = list(), print_tables = TRUE, col_name = "Water Balance",
                                                 capacity_max = 100, evaporation = 5, decimal_places = 0, 
                                                 months_list = month.abb, day_display = "Day")
{
  
  # rain required
  data_list=add_to_data_info_required_variable_list(data_list, list(rain_label))
  
  # date period is "daily"
  data_list=add_to_data_info_time_period(data_list, daily_label)
  climate_data_objs = get_climate_data_objects(data_list)
  
  for(data_obj in climate_data_objs) {
    
    # check if the waterbalance column is present
    if( !(data_obj$is_present(waterbalance_label)) ) {
      # If not, add the column
      if(missing(capacity_max)) {
        data_obj$add_water_balance_col(col_name=col_name,evaporation=evaporation)
      }
      else { data_obj$add_water_balance_col(col_name,capacity_max,evaporation) }
    }
    
    # Do this after if to save repeating 
    waterbalance_col = data_obj$getvname(waterbalance_label)
    
    # Must add these columns if not present to display this way
    if( !(data_obj$is_present(year_label) && data_obj$is_present(month_label) && data_obj$is_present(day_label)) ) {
      data_obj$add_year_month_day_cols()
    }
    
    year_col = data_obj$getvname(year_label)
    month_col = data_obj$getvname(month_label)
    day_col = data_obj$getvname(day_label)
    
    # This is always how we access data in methods now.
    curr_data_list = data_obj$get_data_for_analysis(data_list)
    
    for( curr_data in curr_data_list ) {
      
      # Added extra argument decimal_places to allow flexibility
      curr_data[[waterbalance_col]] <- round(curr_data[[waterbalance_col]], digits = decimal_places)
      
      
      # initialize list of tables
      tables = list()
      
      # Split curr_data into single data frames for each year
      # It returns a list of data.frames, split by year 
      # This is much faster (6x faster when I checked) than subsetting
      # Split is not always appropriate but it is in this case
      years_split <- split(curr_data, list(as.factor(curr_data[[year_col]])))
      
      # counter to use in the loop
      i = 1
      
      # loop through the split data frames 
      for ( single_year in years_split ) {
        
        # Make data into table - rows:days, columns:months, values:water balance
        tables[[i]] <- dcast(single_year, single_year[[ day_col ]]~single_year[[ month_col ]], value.var = waterbalance_col)
        
        # Rename columns
        # Added day_display and months_list as extra arguments so it is more flexible
        
        end = length(colnames(tables[[i]]))
        names(tables[[i]])[ 1 ] <- day_display
        colnames(tables[[i]])[2:end] <- months_list[1:end-1]
        i = i + 1
      }
      
      # The names of years_split is the list of years as strings.
      # These are better labels than numbers so they can be identified better
      names(tables) <- names(years_split)
    }
    
    # Only print if requested
    if(print_tables) {print(tables)}
    
    # Always return the tables list
    # If we don't return and don't print then the method does nothing!
    return(tables)
    
  }
  
}
)

# summaries : list of summary functions to be used e.g. mean, min, max etc.
#             summaries_list on line 52 shows which summary functions are recognised. This may be added to as more summaries are needed.
# variable  : list of variable names to be summaried. Each element should be a character corresponding to a column in data
# factor    : A list of names of factor columns to be used by the by function. Each factor must correspond to a column in the data.
# other arguments are used for the summary functions and may not be needed for all summaries


# single subset of the data for each call
# do all summaries on all variables
# single or multiple thresholds allowed. Convert single into list of multiple repeated
climate$methods(summary_calculation = function(data_list = list(), summary_time_period, required_summaries = list(), required_variables = list(), subyearly_factor, column_names = rep(list(rep("",length(required_summaries))),length(required_variables)), replace = FALSE, ...) {
  if(missing(summary_time_period)) stop("Specify the time period you want the summarized data to be in.")
  if(missing(required_summaries)) stop("required_summaries must be specified")
  if(missing(required_variables)) stop("required_variables must be specified")
  if(!all(required_summaries %in% summaries_list)) stop("required_summaries can only contain recognise summary functions")
  if(length(column_names) != length(required_variables)) stop("column_names must the same length as required_variables")
  if(!all(sapply(column_names, function(x) length(x)==length(required_summaries)))) stop("Each element of column names must be the same length as required_summaries")
  
  data_list=add_to_data_info_required_variable_list(data_list, required_variables)
  
  climate_data_objs = get_climate_data_objects(data_list)
  
  # Check time periods of climate_data_objs are compatible with summary_time_period 
  curr_time_periods = unique(as.vector(sapply(climate_data_objs, function(x) x$data_time_period)))
  if(!all(sapply(curr_time_periods, function(x) compare_time_periods(summary_time_period, x)))) stop(paste("Cannot summarize to",summary_time_period, "from all of ",curr_time_periods))
  
  for(data_obj in climate_data_objs) {

    # Needed for factor columns
    data_obj$add_year_month_day_cols()
    
    # Set factor columns
    factor = c()

    if(data_obj$is_meta_data(multiple_station_label) && data_obj$get_meta(multiple_station_label)) {
      station_col = data_obj$getvname(station_label)
      if(summary_time_period == daily_label) {
        date_col = data_obj$getvname(date_label)
        if(!data_obj$is_present(date_station_label)) data_obj$append_column_to_data(factor(paste0(data_obj$get_data()[[date_col]], data_obj$get_data()[[station_col]])), paste0(date_col, "-",station_col), date_station_label)
        factor = data_obj$getvname(date_station_label)
      }
      else if(summary_time_period == subyearly_label) {
        if(missing(subyearly_factor)) stop("To summarize to subyearly level specify a factor column")
        factor = subyearly_factor
      }
      else if(summary_time_period == yearly_label) {
        if(!data_obj$is_present(season_label)) data_obj$add_year_month_day_cols()
        season_col = data_obj$getvname(season_label)
        if(!data_obj$is_present(season_station_label)) data_obj$append_column_to_data(factor(paste0(data_obj$get_data()[[season_col]], data_obj$get_data()[[station_col]])), paste0(season_col, "-",station_col), season_station_label)
        factor = data_obj$getvname(season_station_label)
      }
    }
    
    else {
      if(summary_time_period == daily_label) factor = date_label
      else if(summary_time_period == subyearly_label) {
        if(missing(subyearly_factor)) stop("To summarize to subyearly level specify a factor column")
        factor = subyearly_factor
      }
      else if(summary_time_period == yearly_label) {
        if(!data_obj$is_present(season_label)) data_obj$add_year_month_day_cols()
        factor = season_label
      }
    }
    # Convert factor columns to factors if needed
    for( single_fact in factor) {
      if(!data_obj$is_present(single_fact)) stop(paste(single_fact, "not found in data."))
      if(!is.factor(data_obj$get_data()[[data_obj$getvname(single_fact)]])) {
        message(paste("Converting", data_obj$getvname(single_fact), "to a factor for summary calculations"))
        data_obj$replace_column_in_data(data_obj$getvname(single_fact),as.factor(data_obj$get_data()[[data_obj$getvname(single_fact)]]))
      }
    }
    
    curr_required_variables = list()
    for(var in required_variables) {
      curr_required_variables[[length(curr_required_variables)+1]] = data_obj$getvname(var)
      #curr_required_variables[[length(curr_required_variables)+1]] = data_obj$getvname(var)
    }

    # data should not be split. We want a single data frame to do calculations by factors
    # Here is where any subsetting of the data (e.g. by date or threshold) is done
    curr_data_list = .self$add_to_data_info_merge(data_list, merged = TRUE)
    curr_data = data_obj$get_data_for_analysis(curr_data_list)

    # curr_factors needs to be a list of columns
    # So do this after subsetting the data
    curr_factors = list()
    for(fac in factor) {
      curr_factors[[data_obj$getvname(fac)]] = curr_data[[data_obj$getvname(fac)]]
    }
    
    out = list()
    labels = list()
    i = 1
    #print(curr_required_variables)
    for(curr_var_name in curr_required_variables) {
      j = 1
      for(single_summary in required_summaries) {
        if(column_names[[i]][[j]] == "") {
          curr_label = single_summary
          for(curr_var_name_item in curr_var_name) {
            curr_label = paste(curr_label, curr_var_name_item)
          }
        }
        else curr_label = column_names[[i]][[j]]
        curr_definition = .self$create_definition(data_list, arguments = list(...))
        # TODO make get_summary_name a climate method
        if(.self$get_summary_name(summary_time_period, data_obj)$is_definition(required_variables[[i]], single_summary, curr_definition)) {
          message(paste("A column for", required_variables[[i]], single_summary, "already exists with the given definition. It will not be added again."))
          j = j + 1
          next
        }
        if(length(curr_var_name)==1) out[[curr_label]] = as.vector(by(curr_data[[curr_var_name]], curr_factors, match.fun(single_summary), ...))
        else out[[curr_label]] = as.vector(by(curr_data[curr_var_name], curr_factors, match.fun(single_summary), ...))
        # TODO make get_summary_label a climate method
        # TODO think how to use get_summary_label when required_variables[[i]] is a list
        labels[[curr_label]] = .self$get_summary_name(summary_time_period, data_obj)$get_summary_label(required_variables[[i]][[1]], single_summary, curr_definition)
        j = j + 1
      }
      i = i + 1
    }
    mapply(function(x,y) .self$append_to_summary(time_period = summary_time_period, data_obj = data_obj, col_data = out[[x]], col_name = x, label = y, replace = replace), names(out), labels)
  }
  
}
)

climate$methods(create_summary = function(data_list = list(), new_time_period, factor_col)
  
{
  if(missing(new_time_period)) stop("Specify the time period you want the summarized data to be in.")
  
  climate_data_objs = get_climate_data_objects(data_list)
  
  # Check time periods of climate_data_objs are compatible with summary_time_period 
  curr_time_periods = unique(as.vector(sapply(climate_data_objs, function(x) x$data_time_period)))
  if(!all(sapply(curr_time_periods, function(x) compare_time_periods(new_time_period, x)))) stop(paste("Cannot summarize to",summary_time_period, "from",new_time_periods))
  
  climate_data_objs_to_create = climate_data_objs[as.vector(sapply(climate_data_objs, function(x) !summary_created(new_time_period, x)))]
  
  for(data_obj in climate_data_objs_to_create) {
    
    curr_data_name = data_obj$get_meta(data_name_label)
    curr_data = data_obj$get_data()
    summarize_name = paste(curr_data_name,new_time_period)
    date_col_name = data_obj$getvname(date_label)
    date_col = curr_data[[date_col_name]]
    
    # TODO Make 0.85 a threshold constant
    threshold = data_obj$get_meta(threshold_label, TRUE, overrider = 0.85)
    
    # na.rm default value
    # TODO Make FALSE a constant
    # Have functionality to have maximum number of missing values allowed before returning missing
    na.rm = data_obj$get_meta(na.rm_label, overrider = FALSE)
    
    if(new_time_period == daily_label) {
      
      # TO DO work out how to do missing_dates_check for subdaily data
      data_obj$missing_dates_check()
      
      unique_dates = unique(data[[date_col_name]])
      
      summarized_data = data.frame(unique_dates)
      names(summarized_data) <- date_col_name
      .self$append_used_data_objects(data = summarized_data, data_name = summarize_name, 
                                     data_time_period = new_time_period,
                                     # This can be removed once missing_dates_check works for subdaily data
                                     check_missing_dates = FALSE, 
                                     meta_data = list(summarized_from = data_obj$get_meta(data_name_label)))

      summary_obj = .self$get_summary_name(new_time_period, data_obj)
      fac_list = curr_data[[date_col_name]]
    }
    
    else if(new_time_period == subyearly_label) {
      
      yr_values = year(curr_data[[date_col_name]])
      fac_list = list(curr_data[[factor_col]], yr_values)
      new_dates = as.Date.POSIXct(as.vector(by(as.POSIXct(curr_data[[date_col_name]]), fac_list, min)))
      
      factor_values = paste(curr_data[[factor_col]], yr_values, sep="-")
      data_obj$append_column_to_data(factor_values,paste(factor_col, "factor levels"))
      
      summarized_data = data.frame(new_dates)
      names(summarized_data) <- date_col_name
      
      .self$append_used_data_objects(data = summarized_data, data_name = summarize_name, 
                                     data_time_period = new_time_period, meta_data = list(summarized_from = data_obj$get_meta(data_name_label)))
      
      summary_obj = .self$get_summary_name(new_time_period, data_obj)
    }
    
    else if(new_time_period == yearly_label) {
      
      start_date = get_data_start_end_dates(data_obj$get_data(), date_col_name, data_obj$get_meta(season_start_day_label))[[1]]
      end_date = get_data_start_end_dates(data_obj$get_data(), date_col_name, data_obj$get_meta(season_start_day_label))[[2]]+1
      year(end_date) = year(end_date)-1
      season_dates = seq(start_date,end_date,"year")
      
      if(!data_obj$is_present(season_label)) data_obj$add_doy_col()
      season_col = data_obj$getvname(season_label)
      curr_data = data_obj$get_data()
      unique_seasons = sort(unique(curr_data[[season_col]]))
      
      if(data_obj$is_meta_data(multiple_station_label) && data_obj$get_meta(multiple_station_label)) {
        station_col = data_obj$getvname(station_label)
        summarized_data = unique(curr_data[c(station_col, season_col)])
        summarized_data = summarized_data[order(summarized_data[[season_col]], summarized_data[[station_col]]), ]
        rownames(summarized_data) <- NULL
        if(!data_obj$is_present(season_station_label)) data_obj$append_column_to_data(paste0(curr_data[[season_col]],"-",curr_data[[station_col]]), "Season-Station", season_station_label)
        season_station_col = data_obj$getvname(season_station_label)
        fac_list = list(curr_data[[season_station_col]])
      }
      
      else {
        summarized_data = data.frame(unique_seasons)
        names(summarized_data) <- season_col
        summarized_data[[date_col_name]] <- season_dates
        fac_list = list(curr_data[[season_col]])
      }
      .self$append_used_data_objects(data = summarized_data, data_name = summarize_name, 
                                     data_time_period = new_time_period, meta_data = list(summarized_from = data_obj$get_meta(data_name_label)))

      summary_obj = .self$get_summary_name(new_time_period, data_obj)
      summary_obj$append_to_variables(season_label,season_col)
      
    }
    
    summary_obj$append_to_variables(date_label,date_col_name)
    summary_obj$append_to_meta_data(summary_statistics_label,list())
    
    summ_date_col_name = summary_obj$getvname(date_label)
    
    if(new_time_period != yearly_label) {
      if( !summary_obj$is_present(month_label) && data_obj$is_present(month_label) ) {
        summary_obj$append_column_to_data(month(summary_obj$get_data()[[summ_date_col_name]]),data_obj$getvname(month_label))
        summary_obj$append_to_variables(month_label,data_obj$getvname(month_label))
      }
    }
    
    if( new_time_period == daily_label ) {
      if( !summary_obj$is_present(day_label) && data_obj$is_present(day_label) ) {
        summary_obj$append_column_to_data(day(summary_obj$get_data()[[summ_date_col_name]]),data_obj$getvname(day_label))
        summary_obj$append_to_variables(day_label,data_obj$getvname(day_label))
      }
    }
    
    if( !summary_obj$is_present(season_label) && data_obj$is_present(season_label) ) {
      #TO DO use date column in summary_obj to look up corresponding season in original data
    }
    
    if( !summary_obj$is_present(year_label) && data_obj$is_present(year_label) ) {
      summary_obj$append_column_to_data(year(summary_obj$get_data()[[summ_date_col_name]]),data_obj$getvname(year_label))
      summary_obj$append_to_variables(year_label,data_obj$getvname(year_label))
    }

    curr_data_list = add_to_data_info_required_data_objs_list(data_list, c(curr_data_name))
    # Add Total Rainfall
    .self$summary_calculation(curr_data_list, new_time_period, required_summaries = sum_label, required_variables = rain_label, na.rm = na.rm, column_names = list("Total Rain"))
    
    # Add number of rainy days and mean rain per rainy day 
    data_list_rain_threshold = add_to_data_info_threshold_list(curr_data_list, list(var = rain_label, lower_threshold = threshold))
    .self$summary_calculation(data_list_rain_threshold, new_time_period, required_summaries = c(count_over_threshold_label, mean_label), required_variables = rain_label, na.rm = na.rm, column_names = list(c("Number of Rainy Days", "Mean Rain per Rainy Day")))
    
    variables_to_summarize_present = variables_to_summarize[sapply(variables_to_summarize, data_obj$is_present)]
    if(rain_label %in% variables_to_summarize_present) variables_to_summarize_present = variables_to_summarize_present[-which(variables_to_summarize_present==rain_label)]
    .self$summary_calculation(curr_data_list, new_time_period, required_summaries = mean_label, required_variables = variables_to_summarize_present, na.rm = na.rm)
    
  }
  

  ###############################
  ## Check from here
  ##############################
#   # variables_to_summarize defined in labels_and_defaults
#   logic_vars = sapply(variables_to_summarize, is_present)
#   variables_to_summarize_present = variables_to_summarize[logic_vars]
#   
#   for(var in variables_to_summarize_present) {
#     # For the variables that are present we create summaries
#     curr_col_name = data_obj$getvname(var)
#     
#     # For rain we will add number total rainfall
#     # And for yearly summaries from subdaily or daily also number of rainy days and average rain on rainy day
#     if(var == rain_label) {
#       threshold = get_meta(threshold_label,missing(threshold),threshold)
#       
#       # This way ensures correct list label is given
#       temp_var_list <- list(data[[curr_col_name]])
#       names(temp_var_list) <- curr_col_name
#       x <- summary_calculation(list(sum_label), temp_var_list, factor = fac_list, na.rm=na.rm)
#       summary_obj$append_column_to_data(x[[1]], names(x)[[1]])
#       rain_sum_label = summary_obj$get_summary_label(var, sum_label, list(na.rm=na.rm))
#       summary_obj$append_to_variables(rain_sum_label, names(x)[[1]])
#       
#       # TO DO how do we do this when summarizing from subdaily?
#       if( (data_time_period == daily_label) ) {
#         
#         x <- summary_calculation(list(mean_over_threshold_label), temp_var_list, factor = fac_list, na.rm=na.rm, threshold = threshold)
#         
#         summary_obj$append_column_to_data(x[[1]], names(x)[[1]])
#         
#         mean_rain_label = summary_obj$get_summary_label(var, mean_over_threshold_label, list(na.rm=na.rm, threshold = threshold))
#         summary_obj$append_to_variables(mean_rain_label, names(x)[[1]])
#         
#         
#         # number of rainy days (count)
#         x <- summary_calculation(list(count_over_threshold_label), temp_var_list, factor = fac_list, na.rm=na.rm, threshold = threshold)
#         summary_obj$append_column_to_data(x[[1]], names(x)[[1]])
#         
#         rain_days_label = summary_obj$get_summary_label(var, count_over_threshold_label, list(na.rm=na.rm, threshold=threshold))
#         summary_obj$append_to_variables(rain_days_label, names(x)[[1]])
#         
#       }
#     }
#     
#     else {
#       
#       # For all other variables we add the mean only.  
#       mean_var_data = as.vector(by(data[[curr_col_name]],fac_list, mean, na.rm = na.rm))
#       mean_var_name = paste(mean_col,curr_col_name)
#       summary_obj$append_column_to_data(mean_var_data, mean_var_name)
#       mean_var_label = summary_obj$get_summary_label(var, mean_label, list(na.rm=na.rm))
#       summary_obj$append_to_variables(mean_var_label, mean_var_name)
#     }
#     
#   }
#   
#   summary_obj$append_to_meta_data(summarized_from_label, curr_data_name)
#   
#   summary_obj
#   
}
)

climate$methods(create_definition = function(data_list = list(), arguments) {
  return(c(data_list, arguments))
}
)

climate$methods(create_climate_obj_from_instat_obj= function(InstatObj) {
  InstatObj$get_data_names()
  names(InstatObj$climate_data_objects)
}

)