#there are still some bits of work to be done to finish cleaning this code.
#Appending functions there is currently a mismatch between adding col's to the data and adding variables I think these should probably be joined together in certain cases. 
#To get this to work really properly with respect to the get, set and append functions we may want to move to an R6 class where issues of private and public are properly adressed.


# Defining the reference class "climate_data".
# The fields are the properties every climate_data object will have.

climate_data <- setRefClass("climate_data", 
                            fields = list(data = "data.frame", meta_data = "list", 
                                          variables = "list", changes = "list", data_time_period="character", date_format="character"))



# INITIALIZE method
##############################################################################################
# Functions of reference classes are called methods.
# This is how you define a method for a specific reference class.
# Every reference class has an initialize method which tells R how to create new 
# climate_data objects.
# By the end of this method, all fields of climate_data should be defined.
# Notice that we don't have a climate_data object as an input.
# We can refer to any field of a climate_data object by name. e.g. data or variables

climate_data$methods(initialize = function(data = data.frame(), data_name = "", meta_data = list(), 
                                           variables = list(), imported_from = "", 
                                           messages = TRUE, convert=TRUE, create = TRUE, identify_variables = TRUE, 
                                           start_point=1, check_dates=TRUE, check_missing_dates = TRUE, 
                                           date_format = "%m/%d/%Y", data_time_period = "daily")
{
  
  # Set up the Climate data object
  
  .self$set_changes(list())
  .self$set_data(data, messages)
  .self$set_meta(add_defaults_meta(imported_from, meta_data))
  if (identify_variables) {
    .self$set_variables(add_defaults(imported_from, ident_var(data,variables)))
  }
  else{
    .self$set_variables(add_defaults(imported_from, variables))
  }
  
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
  
  .self$set_data_time_period(data_time_period)
  .self$set_date_format(date_format)
  
  .self$date_format_check(convert=convert, messages=messages)
  
  if (check_dates){
    .self$date_col_check(date_format=date_format, convert=convert, create = create, messages=messages)
  }
  
  .self$check_multiple_data()
  
   if (check_missing_dates){
     .self$missing_dates_check(messages)
   }
   
}
)




# Getter methods
##############################################################################################
# We can create methods to extract fields from a climate_data object.
# These are called getter methods and are usually very simple functions.
# Notice that no input is needed.

climate_data$methods(get_data = function() {
  return(data)
}
)

climate_data$methods(get_data_for_analysis = function(data_info) {
  #TO DO error checking
  #This method for returning the subsets of the data is not optermised! It can be improved in a number of ways but should work very solidly and reliably in it's current form.
  
  merged_data=FALSE
  if (merge_data_label %in% names(data_info)){
    if (data_info[[merge_data_label]]){
      merged_data=TRUE
    }
  }
  return_data = data
  #  if (merged_data) return_data = data
  #  else{
  #    .self$check_split_data()
  #    return_data = split_data
  #  }
  if (station_list_label %in% names(data_info) & .self$is_present(station_label)) {
    return_data=return_data[return_data[[.self$getvname(station_label)]]==data_info[[station_list_label]],] #TO DO check this syntax is correct
  }
  if (date_list_label %in% names(data_info)) {
    for (tempname in names(data_info[[date_list_label]])){
      if (.self$is_present(tempname)){
        return_data=return_data[return_data[[.self$getvname(tempname)]] %in% data_info[[date_list_label]][[tempname]],] #TO DO add functionallity for start and end dates.
      }
    }
  }  
  if (!merged_data) return_data = .self$get_split_data(return_data)
  return (return_data)
  
}
)

climate_data$methods(get_variables = function() {
  return(variables)
}
)

#TO DO replace all direct calls with this!
climate_data$methods(getvname = function(label, create=FALSE) {
  if (label %in% names(variables)) {
    if (create) {
      if (!is_present(label)){
        if (label==year_label || label==month_label || label==day_label){
          add_year_month_day_cols()
        } else if (label==dos_label || label==season_label || label==doy_label) {
          .self$add_doy_col()
        }# TODO Add other columns that could be created on the fly like time!
      }
    }
    return(variables[[label]])
  } else{
    return(label)
  }
}
)

climate_data$methods(get_changes = function() {
  return(changes)
}
)

climate_data$methods(get_data_time_period = function() {
  return(data_time_period)
}
)

climate_data$methods(get_station_data = function(currdata, label) {
  
  if (.self$is_present_or_meta(label)){
    if (.self$is_present(label)) {
      return (as.character(currdata[[getvname(label)]][[1]]))
    } else if (is_meta(label)){
      return (as.character(meta_data[[label]]))
    } else if (is_meta(station_list_label) & is_present(station_label) ) {
      return (as.character(meta_data[[station_list_label]][station_label==currdata[[station_label =getvname(station_label)]][[1]],label]))
    } 
  } else if ((label==station_label)) {
    return (get_meta(data_name_label))
  }
}
)

climate_data$methods(get_meta= function(label="", value_missing = FALSE, overrider="") {
  
  if (label=="") return(meta_data)
  else if ( !(missing(overrider)) && !(is.na(overrider)) && !value_missing ) return(overrider)
  else if (.self$is_meta_data(label)) return(meta_data[[label]])
  else return (overrider)
}
)

# Setter methods
##############################################################################################
# Similar to getter methods but used for setting a new value to one of the fields
# We usually do some validation before assigning.
#TO DO these setting methods are very dangerous if called directly, we need to either be much more carefull or make them private

climate_data$methods(set_data = function(new_data, messages=TRUE) {
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

climate_data$methods(set_meta = function(new_meta) {
  if( ! is.list(new_meta) ) {
    stop("Meta data must be of type: list")
  } else {
    meta_data <<- new_meta
    .self$append_to_changes(list(Set_property, "meta data"))
  }
}
)


climate_data$methods(set_variables = function(new_variables) {
  if( ! is.list(new_variables) ) {
    stop("Variables must be of type: list")
  }
  
  else {
    variables <<- new_variables
    .self$append_to_changes(list(Set_property, "variables"))
  }
}
)

climate_data$methods(set_changes = function(new_changes) {
  if( ! is.list(new_changes) ) {
    stop("Changes must be of type: list")
  }
  
  else {
    changes <<- new_changes
    .self$append_to_changes(list(Set_property, "changes"))  }
}
)

climate_data$methods(set_data_time_period = function(new_data_time_period) {
  if( ! is.character(new_data_time_period) ) {
    stop("Changes must be of type: character")
  }
  
  else {
    data_time_period <<- new_data_time_period
    .self$append_to_changes(list(Set_property, "data_time_period"))  }
}
)

############################################################################
climate_data$methods(set_date_format = function(new_date_format) {
  if( ! is.character(new_date_format) ) {
    stop("Changes must be of type: character")
  }
  
  else {
    date_format <<- new_date_format
    .self$append_to_changes(list(Set_property, "date_format"))  }
}
)

############################################################################################
# We may want to add something to a field instead of replacing the whole field.
# For that we use append methods.


climate_data$methods(append_column_to_data = function(column_data, col_name = "", label, replace = FALSE) {
  
  # Column name must be character
  if( ! is.character(col_name) ) {
    stop("Column name must be of type: character")
  }
  
  # Column data length must match number of rows of data.
  else if ( !( length(column_data) == nrow(data) ) )
    stop(paste("Number of rows in new column does not match the number of rows in the data set.
                 There must be", nrow(data), "entries in the new column."))
  
  else {
    # If no name given, generate a default column name.
    if (col_name == "") {
      col_name = paste0("column_",sprintf("%02d", length(names(data))+1))
    }
    column_data <- unlist(column_data)
    data[[col_name]] <<- column_data
    .self$append_to_changes(list(Added_col, col_name))
    
    if(!missing(label)) {
      .self$append_to_variables(label,col_name)
    }
    
  }
}
)

climate_data$methods(replace_column_in_data = function(col_name = "", column_data) {
  
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

climate_data$methods(rename_column_in_data = function(curr_col_name = "", new_col_name="") {
  
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
    if(curr_col_name %in% variables) {
      .self$append_to_variables(names(which(variables==curr_col_name)), new_col_name)
    }
    
  }
}
)

climate_data$methods(remove_column_in_data = function(col_name = "") {
  
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

climate_data$methods(replace_value_in_data = function(col_name = "", index, new_value = "") {
  
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


climate_data$methods(append_to_meta_data = function(name, value) {
  
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

climate_data$methods(append_to_variables = function(label = "", value) {
  
  if( missing(label) || missing(value) ) {
    stop("label and value arguements must be specified.")
  } 
  
  
  else if ( ! is.character(label) ) {
    stop("label must be of type: character")
  }
  else {
    variables[[label]] <<- value 
    .self$append_to_changes(list(Added_col_label, label))
  }
}
)

climate_data$methods(append_to_changes = function(value) {
  
  if( missing(value) ) {
    stop(" value arguements must be specified.")
  } 
  else {
    changes[[length(changes)+1]] <<- value 
  }
}
)


# Other methods
############################################################################################

# is_present can check if a given variable name (or list of variable names) is in the data.frame or not.
# This will be used by other functions when doing calculations or to determine
# if extra columns should be added.
# TO DO check functionality for missing cols and if there are multiple elements in long format (currently will return true even if there are no instances possibly correct as like returning true when all values are missing?)

climate_data$methods(is_present = function(str, require_all=TRUE) {
  out = FALSE
  if (is.character(str) && length(str)==1){
    if(str %in% names(variables) ) {
      var_name = variables[[str]]
      if(var_name %in% names(data)) {
        out = TRUE
      }
    } else if(str %in% names(data)) {
      out = TRUE
    }
  }
  else if (is.character(str) || is.list(str)){
    for (temp in str){
      out=is_present(temp)
      if (require_all) if (!out) break
      if (!require_all) if (out) break
    }
  }
  return(out)
}
)

# is_present_or_meta can check if a given variable name (or list of variable names) is in the data.frame or the meta_data or neither.
# This will be used by other functions particularly related to station level data such as latitude, longditude etc. 
# TO DO check functionality for missing cols and if there are multiple elements in long format (currently will return true even if there are no instances possibly correct as like returning true when all values are missing?)

climate_data$methods(is_present_or_meta = function(str, require_all=TRUE) {
  out = FALSE
  if (is.character(str)){
    if(is_present(str)) {
      out = TRUE
    } else if(str %in% names(meta_data)){
      out = TRUE
    } else if(station_list_label %in% names(meta_data)){
      if(str %in% names(meta_data[[station_list_label]])) {
        out = TRUE
      }
    }
  }
  else if (is.list(str)){
    for (temp in str){
      out=is_present_or_meta(temp)
      if (require_all) if (!out) break
      if (!require_all) if (out) break
    }
  }
  return(out)
}
)

# is_meta_data can check if a given bit of meta data is available or not
# This will be used by other functions when doing calculations or to determine
# if extra columns should be added.

climate_data$methods(is_meta_data = function(str) {
  out = FALSE
  
  if(str %in% names(meta_data) ) {
    out = TRUE
  }
  return(out)
}
)

# check_multiple_data checks if there are factor columns with either more than one station or more than one element 
# This will be used to know if the data needs to be subsetted or not.

climate_data$methods(check_multiple_data = function() {
  
  if(!(.self$is_meta_data(multiple_station_label))) {
    if (.self$is_present(station_label)){
      if (nlevels(as.factor(data[[.self$getvname(station_label)]]))>1) meta_data[[multiple_station_label]]<<-TRUE
      else meta_data[[multiple_station_label]]<<-FALSE
    }
    else meta_data[[multiple_station_label]]<<-FALSE
  }
  if(!(.self$is_meta_data(multiple_element_label))) {
    if (.self$is_present(element_factor_label)){
      if (nlevels(as.factor(data[[.self$getvname(element_factor_label)]]))>1) meta_data[[multiple_element_label]]<<-TRUE
      else meta_data[[multiple_element_label]]<<-FALSE
    }
    else meta_data[[multiple_element_label]]<<-FALSE
  }
}
)

# check_split_data assigns the data to the split_data taking into account station and element TO DO this probably needs to be optermised for large data
# Replaced by get_split_data below since the split data is no longer stored
#
#climate_data$methods(check_split_data = function() {
#  
#  if(!(is_data_split)) {
#    if (meta_data[[multiple_station_label]]==TRUE & meta_data[[multiple_element_label]]==TRUE){
#      split_data <<- split(data, list(as.factor(data[[.self$getvname(station_label)]]),as.factor(data[[.self$getvname(element_factor_label)]])))
#    }
#    else if (meta_data[[multiple_station_label]]==TRUE){
#      split_data <<- split(data, as.factor(data[[.self$getvname(station_label)]]))
#    }
#    else if (meta_data[[multiple_element_label]]==TRUE){
#      split_data <<- split(data, as.factor(data[[.self$getvname(element_factor_label)]]))
#    }
#    else split_data <<- list(data)
#    is_data_split<<-TRUE
#  }
#}
#)

climate_data$methods(get_split_data = function(return_data) {
  
  if (meta_data[[multiple_station_label]]==TRUE & meta_data[[multiple_element_label]]==TRUE){
    split_data <- split(return_data, list(as.factor(return_data[[.self$getvname(station_label)]]),as.factor(return_data[[.self$getvname(element_factor_label)]])))
  }
  else if (meta_data[[multiple_station_label]]==TRUE){
    split_data <- split(return_data, as.factor(return_data[[.self$getvname(station_label)]]))
  }
  else if (meta_data[[multiple_element_label]]==TRUE){
    split_data <- split(return_data, as.factor(data[[.self$getvname(element_factor_label)]]))
  }
  else split_data <- list(return_data)
  return(split_data)
}
)

climate_data$methods(summarize_data = function(new_time_period, start_point = 1, 
                                               num_rain_days_col = "Number of Rain Days", total_col = "Total",
                                               mean_col = "Mean", period_col_name = "Period", 
                                               mean_rain_name = "Average rain per rain day", factor_col)
  
  # TO DO remove date formats, remove threshold, 
{
  if(missing(new_time_period)) {
    stop("Specify the time period you want the summarized data to be in.")
  }
  
  if(!compare_time_periods(new_time_period,data_time_period)) {
    stop("Cannot summarize data to a shorter time period.")
  }
  
  summarize_name = paste(.self$meta_data[[data_name_label]],new_time_period)
  date_col_name = getvname(date_label)
  date_col = data[[date_col_name]]
  
  curr_data_name = get_meta(data_name_label)
  
  # default threshold only used if threshold not in meta_data
  threshold = 0.85
  
  # na.rm default value
  # TODO make this come from meta_data?
  na.rm = FALSE
  
  if(new_time_period == daily_label) {
    
    # TO DO work out how to do missing_dates_check for subdaily data
    .self$missing_dates_check()
    
    unique_dates = unique(data[[date_col_name]])
    
    summarized_data = data.frame(unique_dates)
    names(summarized_data) <- date_col_name
    summary_obj = climate_data$new(data = summarized_data, data_name = summarize_name, 
                                   start_point = start_point, data_time_period = new_time_period,
                                   # This can be removed once missing_dates_check works for subdaily data
                                   check_missing_dates = FALSE)
    
    fac_list = data[[date_col_name]]
  }
  
  else if(new_time_period == subyearly_label) {
    
    yr_values = year(data[[date_col_name]])
    fac_list = list(data[[factor_col]], yr_values)
    new_dates = as.Date.POSIXct(as.vector(by(as.POSIXct(data[[date_col_name]]), fac_list, min)))

    factor_values = paste(data[[factor_col]], yr_values, sep="-")
    append_column_to_data(factor_values,paste(factor_col, "factor levels"))
    
    summarized_data = data.frame(new_dates)
    names(summarized_data) <- date_col_name

    summary_obj = climate_data$new(data = summarized_data, data_name = summarize_name, 
                                   start_point = start_point, data_time_period = new_time_period)
    
    summary_obj$append_to_variables(date_label,date_col_name)
  }
  
  else if(new_time_period == yearly_label) {
    
    start_date = .self$get_data_start_end_dates()[[1]]
    end_date = .self$get_data_start_end_dates()[[2]]+1
    year(end_date) = year(end_date)-1
    season_dates = seq(start_date,end_date,"year")
    
    if(!is_present(season_label)) .self$add_doy_col()
    season_col = getvname(season_label)
    unique_seasons = unique(data[[season_col]])
    
    summarized_data = data.frame(unique_seasons)
    names(summarized_data) <- season_col
    summarized_data[[date_col_name]] <- season_dates
    
    summary_obj = climate_data$new(data = summarized_data, data_name = summarize_name, 
                                   start_point = start_point, data_time_period = new_time_period)
    
    summary_obj$append_to_variables(season_label,season_col)
    
    fac_list = list(data[[season_col]])
  }
  
  summary_obj$append_to_variables(date_label,date_col_name)
  
  summary_obj$append_to_meta_data(summary_statistics_label,list())
  
  summ_date_col_name = summary_obj$getvname(date_label)

  if(new_time_period != yearly_label) {
    if( !summary_obj$is_present(month_label) && .self$is_present(month_label) ) {
      summary_obj$append_column_to_data(month(summary_obj$get_data()[[summ_date_col_name]]),getvname(month_label))
      summary_obj$append_to_variables(month_label,getvname(month_label))
    }
  }
  
  if( new_time_period == daily_label ) {
    if( !summary_obj$is_present(day_label) && .self$is_present(day_label) ) {
      summary_obj$append_column_to_data(day(summary_obj$get_data()[[summ_date_col_name]]),getvname(day_label))
      summary_obj$append_to_variables(day_label,getvname(day_label))
    }
  }
  
  if( !summary_obj$is_present(season_label) && .self$is_present(season_label) ) {
    #TO DO use date column in summary_obj to look up corresponding season in original data
  }
  
  if( !summary_obj$is_present(year_label) && .self$is_present(year_label) ) {
    summary_obj$append_column_to_data(year(summary_obj$get_data()[[summ_date_col_name]]),getvname(year_label))
    summary_obj$append_to_variables(year_label,getvname(year_label))
  }
  
  
  summarized_row_num = nrow(summary_obj$data)

  # variables_to_summarize defined in labels_and_defaults
  logic_vars = sapply(variables_to_summarize, is_present)
  variables_to_summarize_present = variables_to_summarize[logic_vars]
  
  for(var in variables_to_summarize_present) {
    # For the variables that are present we create summaries
    curr_col_name = .self$getvname(var)
    
    # For rain we will add number total rainfall
    # And for yearly summaries from subdaily or daily also number of rainy days and average rain on rainy day
    if(var == rain_label) {
      threshold = get_meta(threshold_label,missing(threshold),threshold)
      
      # This way ensures correct list label is given
      temp_var_list <- list(data[[curr_col_name]])
      names(temp_var_list) <- curr_col_name
      x <- summary_calculation(list(sum_label), temp_var_list, factor = fac_list, na.rm=na.rm)
      summary_obj$append_column_to_data(x[[1]], names(x)[[1]])
      rain_sum_label = summary_obj$get_summary_label(var, sum_label, list(na.rm=na.rm))
      summary_obj$append_to_variables(rain_sum_label, names(x)[[1]])
      
      # TO DO how do we do this when summarizing from subdaily?
      if( (data_time_period == daily_label) ) {
        
        x <- summary_calculation(list(mean_over_threshold_label), temp_var_list, factor = fac_list, na.rm=na.rm, threshold = threshold)
        
        summary_obj$append_column_to_data(x[[1]], names(x)[[1]])

        mean_rain_label = summary_obj$get_summary_label(var, mean_over_threshold_label, list(na.rm=na.rm, threshold = threshold))
        summary_obj$append_to_variables(mean_rain_label, names(x)[[1]])
        
        
        # number of rainy days (count)
        x <- summary_calculation(list(count_over_threshold_label), temp_var_list, factor = fac_list, na.rm=na.rm, threshold = threshold)
        summary_obj$append_column_to_data(x[[1]], names(x)[[1]])

        rain_days_label = summary_obj$get_summary_label(var, count_over_threshold_label, list(na.rm=na.rm, threshold=threshold))
        summary_obj$append_to_variables(rain_days_label, names(x)[[1]])
        
      }
    }
    
    else {
      
      # For all other variables we add the mean only.  
      mean_var_data = as.vector(by(data[[curr_col_name]],fac_list, mean, na.rm = na.rm))
      mean_var_name = paste(mean_col,curr_col_name)
      summary_obj$append_column_to_data(mean_var_data, mean_var_name)
      mean_var_label = summary_obj$get_summary_label(var, mean_label, list(na.rm=na.rm))
      summary_obj$append_to_variables(mean_var_label, mean_var_name)
    }
      
  }
  
  summary_obj$append_to_meta_data(summarized_from_label, curr_data_name)
  
  summary_obj
  
}
)

climate_data$methods(add_water_balance_col = function(col_name = "Water Balance", capacity_max = 100, evaporation = 5)
{
  
  # Complete dates needed for calculations
  missing_dates_check()
  
  # Always use the methods to get value from objects. Never access directly.
  rain_col = getvname(rain_label)
  date_col = getvname(date_label)
  
  # Do all data_object level checks before calling get_data_for_analysis
  evap_present = is_present(evaporation_label)
  if(evap_present) evaporation_col = getvname(evaporation_label)
  
  # New get_meta method (waiting for David to check)
  capacity_max = get_meta(capacity_label,missing(capacity_max),capacity_max)
  
  # Use an empty data_list here because we want to calculate water balance
  # for the whole data set.
  # Displaying water balance can use a non empty data_list here if we want to view a subset of the data
  curr_data_list = get_data_for_analysis(data_info = list())
  
  for( curr_data in curr_data_list ) {
    # This needs to be changed to consider case when data will come as split
    # Index comparisions etc.
    
    num_rows <- nrow(curr_data)
    
    # List of the indices of all NAs in the rain column
    #indicNAs <- which (curr_data[[ rain_col ]] %in% NA)
    
    # Create a column for water balance filled with NAs
    # We will append to data_object only when it is complete
    water_balance_col = rep(NA,num_rows)
    
    # Initialization
    if( is.na(curr_data[[rain_col]][[1]]) ) {
      water_balance_col[[1]] <- NA
    }
    else {water_balance_col[[1]] <- 0}
    
    #       if(length(indicNAs) != 0) {
    #         ind_nonrecord = indicNAs[ !(day(curr_data[[date_col]][indicNAs]) == 29 & month(curr_data[[date_col]][indicNAs]) == 2) ]
    #       }
    #       else {ind_nonrecord <- indicNAs}
    
    #      ind_nonrecord <- indicNAs
    
    # assign the NAs due to non recording values to be zero.
    #       for(  j in ind_nonrecord  ) {
    #         curr_data[[ rain_col ]][ j ] = 0
    #       }
    
    
    reset <- which(day(curr_data[[ date_col ]]) == 1 &  month(curr_data[[ date_col ]]) == 1)
    
    # Two different formulas for computing water balance depending on what kind of evaporation
    # you have.
    for (  iday in 2 : num_rows  ) {
      if(evap_present) {evaporation <- evap_col[[iday]]}
      
      if( iday %in% reset && is.na(water_balance_col[iday - 1]) ) {
        water_balance_col[[iday]] <- 0
      }
      else {
        water_balance_col[[iday]] <- water_balance_col[[iday - 1]] + curr_data[[rain_col]][iday] - evaporation
      }
      
      if( !is.na(water_balance_col[iday]) ) {
        if ( water_balance_col[iday] < 0 ) {
          water_balance_col[iday] <- 0
        }
        else if( water_balance_col[iday] > capacity_max ) {
          water_balance_col[iday] <- capacity_max
        }
      }
    }
  }
  
  # Last step is to append the water balance column to the data
  # and add to variables so that water balance can be recognised.
  append_column_to_data(water_balance_col,col_name)
  append_to_variables(waterbalance_label, col_name)
}
)


climate_data$methods(get_summary_label = function(element="", statistic="", definition=list()) {
  
  if( !is_meta_data(summary_statistics_label)) {
    append_to_meta_data(summary_statistics_label,list())
  }
  
  if( !(element %in% names(meta_data[[summary_statistics_label]])) ) {
    meta_data[[summary_statistics_label]][[element]] <<- list()
  }
  
  if( !(statistic %in% names(meta_data[[summary_statistics_label]][[element]])) ) {
    meta_data[[summary_statistics_label]][[element]][[statistic]] <<- list()    
  }
  
  label = paste(element,statistic,length(meta_data[[summary_statistics_label]][[element]][[statistic]])+1)
  meta_data[[summary_statistics_label]][[element]][[statistic]][[label]] <<- definition
  
  return(label)
}
)

climate_data$methods(is_definition = function(element="", statistic="", definition=list()) {
  
  found_match = FALSE
  
  if( is_meta_data(summary_statistics_label) 
      && element %in% names(meta_data[[summary_statistics_label]])
      && statistic %in% names(meta_data[[summary_statistics_label]][[element]]) ) {
    for(def in meta_data[[summary_statistics_label]][[element]][[statistic]]) {
      if(length(def) != length(definition)) break
      match = TRUE
      for(item in names(def)) {
        if( !(item %in% names(definition) && def[[item]] == definition[[item]]) ) {
          match = FALSE
          break
        }
      }
      if(match) {
        found_match = TRUE
        break
      }
    }
  }
  
  return(found_match)
  
}
)

climate_data$methods(view_definition = function(col_name) {
  
  if (col_name %in% names(data)) {
    
    label = names(which(variables==col_name))
    if(is_meta_data(summary_statistics_label)) {
      for(element in meta_data[[summary_statistics_label]]) {
        for(statistic in element) {
          if(label %in% names(statistic)) {
            ind = which(names(statistic)==label)
            return(statistic[[ind]])
          }
        }
      }
    }
  }
  else return(NA)
}
)

# Moved to Labels and defaults 
# climate_data$methods(get_data_start_end_dates = function() {
#   # TO DO better method for getting subyeary and yearly dates
#   date_col = getvname(date_label)
#   temp_start_date = doy_as_date(get_meta(season_start_day_label),year(min(data[[date_col]])))
#   if( temp_start_date > min(data[[date_col]]) ) {
#     start_date = temp_start_date
#     year(start_date) <- year(start_date)-1
#   }
#   else {
#     start_date = temp_start_date      
#   }
#   
#   final_year = year(max(data[[date_col]]))
#   final_month = month(start_date-1)
#   final_day = day(start_date-1)
#   temp_end_date = as.Date(paste(final_year,final_month,final_day,sep="-"))
#   if( temp_end_date >= max(data[[date_col]]) ) {
#     end_date = temp_end_date
#   }
#   else {
#     end_date = as.Date(paste(final_year+1,final_month,final_day,sep="-"))
#   }
#   
#   return(c(start_date,end_date))
# }
# )

climate_data$methods(time_period_check = function(messages=TRUE) {
  
  date_col = data[[getvname(date_label)]]
  diff_values = difftime(tail(date_col,-1),head(date_col,-1), units="days")
  min_diff = min(diff_values)
  median_diff = median(diff_values)
  mode_diff = mode_stat(diff_values)
  
  if(min_diff < 1) {
    data_time_period <<- subdaily_label
  }
  else if (min_diff == 1) {
    data_time_period <<- daily_label
  }
  else if (min_diff > 1 && min_diff < 365) {
    data_time_period <<- subyearly_label
  }
  else if (min_diff == 365) {
    data_time_period <<- yearly_label
  }
  else {
    stop("Cannot determine the data time period.")
  }
  
  if(messages) message(paste("Detected time period:", data_time_period))
  if(messages && (min_diff != median_diff) ) {
    warning(paste("The data time period does not match with the median time difference:", median_diff))
  }
  if(messages && min_diff != mode_diff) {
    warning(paste("The data time period does not match with the mode time difference:", mode_diff))
  }
  
}
)

climate_data$methods(add_spell_length_col = function(col_name = "Spell Length", threshold=0.85)
{
  
  # Complete dates needed for calculations
  missing_dates_check()

  if(!is_present(rain_label)) stop("rain variable is required to calculate spell length")
  rain_col = getvname(rain_label)  
  threshold = get_meta(threshold_label, missing(threshold), threshold)
  curr_data_list = get_data_for_analysis(data_info = list())
  
  for( curr_data in curr_data_list ) {    
    
    num_rows <- nrow(curr_data)       
    
    spell_length_col=spell_length_count(curr_data[[rain_col]], threshold)   
    
  }
  append_column_to_data(spell_length_col,col_name)
  append_to_variables(spell_length_label, col_name)
}
)

climate_data$methods(add_rain_day_column = function(col_name = "Rain Day", threshold=0.85)
{
    
  if(!is_present(rain_label)) stop("rain variable is required to calculate Rain day column")
  rain_col = getvname(rain_label)  
  threshold = get_meta(threshold_label, missing(threshold), threshold)
  curr_data = get_data_for_analysis(data_info = list(merge_data=TRUE))
  wd=curr_data[[rain_col]]>threshold
  wd[wd==TRUE]=rd_short_label
  wd[wd==FALSE]=dd_short_label

  append_column_to_data(wd,col_name)
  append_to_variables(rain_day_label, col_name)
}
)

climate_data$methods(add_rain_day_lags_column = function(lag_prefix = "Rain Day", lag_order=1)
{
  
  # Complete dates needed for calculations
  missing_dates_check()
  
  if(!is_present(rain_day_label)) add_rain_day_column()
  rain_day_col_name = getvname(rain_day_label)

  curr_data_list = get_data_for_analysis(data_info = list())
  staion_lag_tables = list()
  i = 1
  for (curr_data in curr_data_list) {
    
    curr_lag_data = as.data.frame(matrix(nrow=nrow(curr_data),ncol=0))
    
    date_col = curr_data[[getvname(date_label)]]
    curr_lag_data[[getvname(date_label)]] = date_col
    
    if(is_present(station_label)) {
      station_col = curr_data[[getvname(station_label)]]
      curr_lag_data[[getvname(station_label)]] = station_col
    }
    
    curr_lag_data[[rain_day_col_name]] = curr_data[[rain_day_col_name]]
    
    wet_dry <- as.data.frame(matrix(nrow=nrow(curr_data),ncol=lag_order+1))
    wet_dry[ ,1] = curr_data[[rain_day_col_name]]
    
    for(n in 1:lag_order) {

      wet_dry[ ,n+1] = c(NA,wet_dry[1:(nrow(curr_data)-1),n])
      lags=do.call("paste",c(as.list(wet_dry[,1:n+1]),sep=""))
      lags[grep("NA",lags)] <- NA
      print(lags)
      
      lagname=paste(lag_prefix, n)
      curr_lag_data[[lagname]] = sapply(lags,function(x) substring(x,2))
    }
    
    staion_lag_tables[[i]] <- curr_lag_data
    i = i + 1
  }
  
  
  lags_merge = do.call("rbind",staion_lag_tables)
  .self$join_data(lags_merge, match="first", type="full", by = c(getvname(date_label), getvname(station_label)))
  
  for(n in 1:(lag_order)) {
    laglabel = paste(rain_day_lag_label, n, sep="_")
    lagname = paste(lag_prefix, n, sep="_")
    append_to_variables(laglabel, lagname)
  }
}
)

climate_data$methods(add_running_rain_totals_col = function(col_name = "Running Rain Total",threshold = 0.85, total_days = 1)
{
  
  # Complete dates needed for calculations
  missing_dates_check()
  
  rain_col = getvname(rain_label)  
  
  curr_data_list = get_data_for_analysis(data_info = list())
  
  for( curr_data in curr_data_list ) {    
    
    num_rows <- nrow(curr_data)      
    
    
    running_totals_col = curr_data[[rain_col]]
    running_totals_col[running_totals_col <= threshold] <- 0
    running_totals_col = c(rep(NA, (total_days -1)),running_sum(data = running_totals_col, total_days = total_days))
  }    
  append_column_to_data(running_totals_col,col_name)
  append_to_variables(running_rain_totals_label, col_name)
}
)

climate_data$methods(join_data = function(joining_data, match = "first", type = "full", by = NULL) {
  set_data(join(joining_data, get_data(), match=match, type=type, by = by))
}
)