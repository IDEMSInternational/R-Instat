library(reshape2)
library(lubridate)
library(plyr)
library(rtf)
library(ggplot2)
library(reshape)
#Labels for variables which will be recognised by the Climate objects
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

variables_to_summarize = c(rain_label, temp_min_label, temp_max_label, evaporation_label,temp_air_label)

rd_label = "wet_day"
dd_label = "dry_day"
rd_short_label = "w"
dd_short_label = "d"
rain_amount_label = "rain_amount"


start_of_label="start_of"
end_of_label="end_of"
seasonal_total_label = "seasonal_total"
seasonal_raindays_label = "seasonal_raindays"
extreme_event_day_label = "extreme_event_day"
running_summary_label = "running_summary"

running_rain_totals_label = "running_rain_total"
waterbalance_label = "waterbalance"
end_of_rain_label="end_of_rain"
start_of_rain_label="start_of_rain"
total_rainfall_label = "total_rainfall"
number_of_rain_days_label = "number_of_rain_days"
mean_temp_min_label = "mean_temp_min"
mean_temp_max_label = "mean_temp_max"
mean_evaporation_label = "mean_evaporation"
mean_rain_per_rain_day_label = "mean_rain_per_rain_day"
min_rainfall_label = "min_rainfall"
min_temp_min_label = "min_temp_min"
min_temp_max_label = "min_temp_max"
min_evaporation_label = "min_exaporation"
max_rainfall_label = "max_rainfall"
max_temp_min_label = "max_temp_min"
max_temp_max_label = "max_temp_max"
max_evaporation_label = "max_exaporation"
spell_length_label  = "spell_length"
#Labels for meta data which will be recognised by the Climate objects
data_name_label="data_name"
constructor_label="constructor"
threshold_label="threshold"
wind_threshold_label="wind_threshold"
season_start_day_label="season_start_day"
day_start_time_label="day_start_time"
station_meta_data_label="station_meta_data"
multiple_station_label="multiple_station"
multiple_element_label="multiple_element"
merged_from_label="merged_from"
summarized_from_label="summarized_from"
complete_dates_label="complete_dates"
summary_statistics_label="summary_statistics"
data_start_date_label="data_start_date"
data_end_date_label="data_end_date"
var_label="var"
lower_threshold_label="lower_threshold"
upper_threshold_label="upper_threshold"
lower_strict_label="lower_strict"
upper_strict_label="upper_strict"
na.rm_label="na.rm"

# Defaults
use_default_label="use_default"
default_threshold=0.85
default_na.rm=FALSE

#Labels to specify data in function specification list
station_list_label="station_list"
date_list_label="date_list"
start_date_label="start"
end_date_label="end"
time_period_label="time_period"
required_variable_list_label="required_variable_list"
merge_data_label="merge_data"
convert_data_label="convert_data"
require_all_variables_label="require_all_variables"
threshold_list_label = "threshold_list"
required_data_objs_list_label="required_data_objs_list"

#Labels for data time periods
daily_label="daily"
subdaily_label="subdaily"
subyearly_label="subyearly"
yearly_label="yearly"

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

# Try to identify columns automatically 
# This function is called in climate_data initialize method.

ident_var <- function (data,variables) {
  
  merged <- variables 
  if(!(station_label %in% names(merged))){
    for (label in c("Station","station","Station_id","station_id","ID","ID.", "Name", "name","StationName","StationID")){
      if (label %in% names(data)){
        merged[[station_label]]<-label
        break
      } 
    }
  }
  if(!(date_label %in% names(merged))) {
    for (label in c("Date","date", "Date.D", "DATE","record_date")){
      if (label %in% names(data)){
        merged[[date_label]]<-label
        break
      } 
    }
  }
  if(!(date_time_label %in% names(merged))) {
    for (label in c("Date time","date time","date_time")){
      if (label %in% names(data)){
        merged[[date_time_label]]<-label
        break
      } 
    }
  }
  if(!(date_asstring_label %in% names(merged))){
    for (label in c("recorded_at","Recorded_at")){
      if (label %in% names(data)){
        merged[[date_asstring_label]]<-label
        break
      } 
    }
  }
  if(!(rain_label %in% names(merged))) {
    for (label in c("Rain","rain","Observed","observed","obs_value", "Prec","prec","Precipitation","Precipitation (mm)","precipitation","precipitation (mm)", "RR","prcp")){
      if (label %in% names(data)){
        merged[[rain_label]]<-label
        break
      } 
    }
  } 
  if(!(year_label %in% names(merged))) {
    for (label in c("Year","year","Year.","year.","Year_1.")){
      if (label %in% names(data)){
        merged[[year_label]]<-label
        break
      } 
    }
  }
  if(!(month_label %in% names(merged))) {
    for (label in c("Month","month","Month.","month.","Month_1.", "Mon", "mon", "Mon.", "mon.")){
      if (label %in% names(data)){
        merged[[month_label]]<-label
        break
      } 
    }
  }
  if(!(day_label %in% names(merged))) {
    for (label in c("Day","day","Day.","day.")){
      if (label %in% names(data)){
        merged[[day_label]]<-label
        break
      } 
    }
  }
  if(!(doy_label %in% names(merged))) {
    for (label in c("DOY","doy","DOY.","doy.")){
      if (label %in% names(data)){
        merged[[doy_label]]<-label
        break
      } 
    }
  }
  if(!(time_label %in% names(merged))) {
    for (label in c("Time","time")){
      if (label %in% names(data)){
        merged[[time_label]]<-label
        break
      } 
    }
  }
  if(!(year_month_label %in% names(merged))) {
    for (label in c("Year Month","YearMonth")){
      if (label %in% names(data)){
        merged[[year_month_label]]<-label
        break
      } 
    }
  }
  if(!(temp_min_label %in% names(merged))) {
    for (label in c("Tmin","tmin","Tn","Temp min","temp_min")){
      if (label %in% names(data)){
        merged[[temp_min_label]]<-label
        break
      } 
    }
  }
  if(!(temp_max_label %in% names(merged))) {
    for (label in c("Tmax","tmax", "Tx","Temp max","temp_max")){
      if (label %in% names(data)){
        merged[[temp_max_label]]<-label
        break
      } 
    }
  }
  # Temp air
  if(!(temp_air_label %in% names(merged))) {
    for (label in c("temp_air","Air Temp","air temp","airtemp","tempair","air_temp")){
      if (label %in% names(data)){
        merged[[temp_air_label]]<-label
        break
      } 
    }
  }
  # Wind speed 
  if(!(wind_speed_label %in% names(merged))) {
    for (label in c("Windsp","windsp", "wind_speed","wind speed")){
      if (label %in% names(data)){
        merged[[wind_speed_label]]<-label
        break
      } 
    }
  }
  # Wind direction
  if(!(wind_direction_label %in% names(merged))) {
    for (label in c("Winddir","winddir", "wind_direction","wind direction")){
      if (label %in% names(data)){
        merged[[wind_direction_label]]<-label
        break
      } 
    }
  }
  if(!(lat_label %in% names(merged))) {
    for (label in c("lat","Lat","Latitude")){
      if (label %in% names(data)){
        merged[[lat_label]]<-label
        break
      } 
    }
  }
  if(!(lon_label %in% names(merged))) {
    for (label in c("lon","Lon","Longitude")){
      if (label %in% names(data)){
        merged[[lon_label]]<-label
        break
      } 
    }
  }
  if(!(alt_label %in% names(merged))) {
    for (label in c("alt","Alt","Altitude")){
      if (label %in% names(data)){
        merged[[alt_label]]<-label
        break
      } 
    }
  }  
  if(!(rain_day_label %in% names(merged))) {
    for (label in c("Rain day", "rain day", "Rain Day")){
      if (label %in% names(data)){
        merged[[alt_label]]<-label
        break
      } 
    }
  }  
  #TODO Identify Rain_Day_Lags!
  
  return(merged)    
  
}

# Defaults to manage data coming in from specific sources
# This function is called in climate_data initialize method.

add_defaults <- function (imported_from,user) {

  merged <- user 
  # If data is imported from a known source, we can use recognised default values.
  if( !is.null(imported_from) && imported_from == "CLIMSOFT" ) {
    #For example importing from climsoft we need to recognise the Data as and the rain columns
    if(!(date_asstring_label %in% names(merged))) merged[[date_asstring_label]]<-"Recorded_at"
    if(!(rain_label %in% names(merged))) merged[[rain_label]]<-"Observed"
    #For all other variable we will assume and assign the standard default values
    return(add_defaults("",merged))  
  }
  else {
    if( !(is.null(imported_from) || imported_from == "") && messages ) {
      warning(paste0("The imported_from value: ", imported_from, " was not recognised.
                          Default values for variables will be used."))
    }
    if(!(station_label %in% names(merged))) merged[[station_label]]<-"Station"
    if(!(date_label %in% names(merged))) merged[[date_label]]<-"Date"
    if(!(date_asstring_label %in% names(merged))) merged[[date_asstring_label]]<-"Date as string"
    if(!(date_time_label %in% names(merged))) merged[[date_time_label]]<-"Date time"
    if(!(rain_label %in% names(merged))) merged[[rain_label]]<-"Rain"
    if(!(year_label %in% names(merged))) merged[[year_label]]<-"Year"
    if(!(season_label %in% names(merged))) merged[[season_label]]<-merged[[year_label]]
    if(!(month_label %in% names(merged))) merged[[month_label]]<-"Month"
    if(!(day_label %in% names(merged))) merged[[day_label]]<-"Day"
    if(!(doy_label %in% names(merged))) merged[[doy_label]]<-"DOY"
    if(!(dos_label %in% names(merged))) merged[[dos_label]]<-merged[[doy_label]]
    if(!(time_label %in% names(merged))) merged[[time_label]]<-"Time"
    if(!(temp_min_label %in% names(merged))) merged[[temp_min_label]]<-"Temp min"
    if(!(temp_max_label %in% names(merged))) merged[[temp_max_label]]<-"Temp max"
    if(!(temp_air_label %in% names(merged))) merged[[temp_air_label]]<-"Temp air"
    if(!(evaporation_label %in% names(merged))) merged[[evaporation_label]]<-"Evaporation"
    if(!(wind_speed_label %in% names(merged))) merged[[wind_speed_label]]<-"Wind speed"
    if(!(wind_direction_label %in% names(merged))) merged[[wind_direction_label]]<-"Wind direction"
    if(!(rain_day_label %in% names(merged))) merged[[rain_day_label]]<-"Rain Day"
    if(!(rain_day_lag_label %in% names(merged))) merged[[rain_day_lag_label]]<-"Rain Day"
    return(merged)    
  }

}

# Defaults for meta data to manage data coming in from specific sources
# This function is called in climate_data initialize method.
add_defaults_meta <- function (imported_from,user) {
  
  merged <- user 
  # If data is imported from a known source, we can use recognised default values.
  if( !is.null(imported_from) && imported_from == "CLIMSOFT" ) {
    
    #For all other variable we will assume and assign the standard default values
    return(add_defaults_meta("",merged))  
  }
  else {
    if( !(is.null(imported_from) || imported_from == "") && messages ) {
      warning(paste0("The imported_from value: ", imported_from, " was not recognised.
                     Default values for variables will be used."))
    }
    if(!(threshold_label %in% names(merged))) merged[[threshold_label]]<- default_threshold
    if(!(wind_threshold_label %in% names(merged))) merged[[wind_threshold_label]]<- 0.3
    if(!(season_start_day_label %in% names(merged))) merged[[season_start_day_label]]<-1
    if(!(day_start_time_label %in% names(merged))) merged[[day_start_time_label]]<-0
    if(!(complete_dates_label %in% names(merged))) merged[[complete_dates_label]]<-FALSE
    if(!(na.rm_label %in% names(merged))) merged[[na.rm_label]]<- default_na.rm
    return(merged)    
  }
  
}

# Compare time periods to see if conversion is possible.
compare_time_periods <- function (desired_time_period,data_time_period) {
  
  out=FALSE
  if (desired_time_period==yearly_label) out=TRUE
  else if (desired_time_period==subyearly_label){
    if (data_time_period!=yearly_label) out=TRUE
  }
  else if (desired_time_period==daily_label){
    if (data_time_period==subdaily_label|data_time_period==daily_label) out=TRUE
  }
  else if (desired_time_period==subdaily_label){
    if (data_time_period==subdaily_label) out=TRUE
  }
  out
}


sum_check = function(table, earliest_day = 92, total_days = 2, threshold = 20) {
  
  #--------------------------------------------------------------------------------------------#
  # This functin uses a data frame (table) containing the variables Day of Year and 
  # Rainfall to calculates the first day of the year (past a certain day (earliest_day)) where 
  # the sum of the rainfall over that day and a given number of previous days (total_days) is 
  # above a given amount (threshold).
  # 
  # It returns a list of two numbers:
  #       [1]            : the day of year of the first instance after earliest_day where the sum of
  #                        rainfall of that day and the (total_days-1) previous days is greater than 
  #                        or equal to threshold (in mm).
  #       [2]            : the sum of the rainfall corresponding to the day of the year of 
  #                        the first output value.
  # 
  # If there are no such values, missing values will be returned.
  # 
  # It accepts the following arguments:
  #
  #       table          : a data frame of two variables, Day of Year in the first column,
  #                        and Rainfall in the second column. (no default)
  #       earliest_day   : the day of the year from which we want to start checking. 
  #                        The default is 92. 
  #       total_days     : the number of consecutive days we want to sum rainfall over.
  #                        The default is 2.
  #       threshold      : the rain value the sum of consecutive days should be equal to greater 
  #                        than. 
  #                        The default is 20 mm.
  #
  #  This function is called by the climate method start_rain to calculate the start of the rains.
  #-------------------------------------------------------------------------------------------#
  
  # Data validation
  if(!is.data.frame(table) || ncol(table) != 2 || !is.numeric(table[[1]]) || !is.numeric(table[[2]]) ) { 
    stop("table must be a data frame with two numeric columns.")
  }
  
  if(length(table[[1]]) != length(unique(table[[1]])) ) {
    stop("First column of table must be day of year and only contain one year")
  }
  if(!is.numeric(earliest_day) || length(earliest_day) != 1 || earliest_day != as.integer(earliest_day) 
     || earliest_day < 1 || earliest_day > 366) {
    stop("earliest_day must be an integer between 1 and 366")
  }
  
  if(!is.numeric(total_days) || length(total_days) != 1 || total_days != as.integer(total_days) 
     || total_days < 1 || total_days > 366) {
    stop("total_days must be an integer between 1 and 366")
  }
  
  if(!is.numeric(threshold) || length(threshold) != 1 || threshold < 0) {
    stop("threshold must be a non negative number")
  }
  #######################################################################
  
  # If there are no days in the day of year column after earliest_day, return missing values.
  if(length(table[[1]][table[[1]]>=earliest_day]) == 0) {
    return(c(NA,NA))
  }
  
  # Get the earliest day that is in the day of year column after earliest_day
  earliest_day = min(table[[1]][table[[1]]>=earliest_day])
  
  # first_day is the row number containing earliest_day.
  first_day = which(table[[1]]==earliest_day)
  
  # Initialize the output values to NA
  # doy: the first day of year the meets the requirements
  # qty: the rainfall sum corresponding to doy
  doy = NA
  qty = NA
  
  # Loop through table starting from the row containing earliest_day
  for(i in first_day:nrow(table)) {
    # temp_sum will keep track of the current sum of total_days consecutive days
    temp_sum = 0
    
    # Loop to calculate temp_sum for total_days days/
    for(j in (i-total_days+1):i) {
      # If j is a non positive row number or the rain value is NA, skip to the next day.
      if(j < 1 || is.na(table[[2]][j])) break
      else {
        temp_sum = temp_sum + table[[2]][[j]]
      }
    }
    # If temp_sum is at least threshold, set the output values and break from the loop.
    if(temp_sum >= threshold) {
      doy = table[[1]][[i]]
      qty = temp_sum
      break
    }
  }
  # return the day of year and the rainfall sum achieved.
  return(c(doy,qty))
}

dry_spell_check <- function(rain_col, period=length(rain_col), dry_days=10, threshold=0.85) {
  
  #--------------------------------------------------------------------------------------------#
  # This function returns a single logical value:
  #       [1]            : TRUE if there is a dry period of a given length within a certain period
  #                        at the beginning of a vector of rain values
  #                        FALSE if there is no dry period of the given lengh within the specified
  #                        period at the beginning of a vector of rain values.
  # A dry period of length n is defined as n consecutive days in which no day has an amount of rain
  # above a given threshold.
  # 
  # It accepts the following arguments:
  #
  #       rain_col       : a numeric vector of rain values. (no default)
  #       period         : the number of days in which you wish to check for a dry period,
  #                        starting with the first value of rain_col.
  #                        The default is length(rain_col)
  #       dry_days       : the number of consecutive days you require to be dry 
  #                        to define a dry period
  #                        The default is 2.
  #       threshold      : the value that, below which, a day is considered to be dry.
  #                       The default is 0.85 (mm)
  #
  #  This function is used in calculating the start of the rains.
  #-------------------------------------------------------------------------------------------#
  
  
  # data validation
  if( missing(rain_col) || !is.numeric(rain_col) ) stop("Please provide a numeric rain column.")
  
  if(!is.numeric(period) || length(period) != 1 || period != as.integer(period) 
     || period < 1) {
    stop("period must be a positive integer.")
  }
  
  if(!is.numeric(dry_days) || length(dry_days) != 1 || dry_days != as.integer(dry_days) 
     || dry_days < 1) {
    stop("dry_days must be a positive integer.")
  }
  
  # if the dry period is longer than the checking period 
  # or, the checking period is longer than the rain column
  # return NA
  if(dry_days > period || period > length(rain_col)) return(NA)
  
  # Initialize variables
  dry_spell=FALSE
  indic = 1
  
  # search for a dry spell until we reach the end of the period or until we 
  # find a dry spell
  while( indic <= (period - dry_days + 1) && !dry_spell ) {
    
    # Initialize dry_spell to TRUE. If it is not changed by the for loop below,
    # then we are in a dry spell.
    dry_spell = TRUE
    
    # loop through dry_days days to check if we are in a dry spell
    for(j in indic:(indic+dry_days-1)) {
      # if a rain value is missing, we cannot say the period is a dry period.
      # Go to the next potential dry spell.
      # If a day is a rain day, go to the next potential dry spell.
      if (is.na(rain_col[j]) || rain_col[j] > threshold) {
        dry_spell = FALSE
        break
      }
    }
    # Start checking for the next potential dry spell at the last known non-dry day.
    indic = j + 1
    
  }
  return(dry_spell)
}

doy_as_date <- function(doy, year) {
  if(missing(doy) || missing(year)) stop("Provide a day of year and year to convert.")
  
  if(doy==60 && !leap_year(year)) return(NA)
  
  if(!leap_year(year) && doy > 60) {
    return(as.Date(paste(year,doy-1), format="%Y %j"))
  }
  
  else return(as.Date(paste(year,doy), format="%Y %j"))
  
}

spell_length_count <- function(spell_length_col, threshold){
  
  spell_length_col[spell_length_col <= threshold] <- 0 
  
  if (spell_length_col[1]<threshold|is.na(spell_length_col[[1]])){
    spell_length_col[1]=NA      
  }
  for (i in 2:length(spell_length_col)){
    if ((spell_length_col[i]<threshold|is.na(spell_length_col[i])) & is.na(spell_length_col[i-1])){
      spell_length_col[i]=NA 
    }        
  }
  
  (!(spell_length_col)) * unlist(lapply(rle(spell_length_col)$lengths, seq_len))
}

longest_spell_length <- function(spell_length_col, threshold, factor, na.rm = FALSE) {
  spell_count = spell_length_count(spell_length_col, threshold)
  summary_calculation(summaries = list(max_label), variables = list(spell_count=spell_count), factor=factor, na.rm=na.rm)
}

add_to_data_info_threshold_list = function(data_info=list(), new_threshold_list="") {
  
  if (threshold_list_label %in% names(data_info)) {
    for(label in names(new_threshold_list)) {
      if(label %in% names(data_info[[threshold_list_label]])) warning(paste("overwriting user choice for", label))
      data_info[[threshold_list_label]][[label]] = new_threshold_list[[label]]
    }
    
  }
  else data_info[[threshold_list_label]] <- new_threshold_list
  
  return (data_info)
}

add_to_data_info_required_data_objs_list = function(data_info=list(), new_data_objs_list=c()) {
  
  if (required_data_objs_list_label %in% names(data_info)) {
    data_info[[required_data_objs_list_label]] = unique(c(data_info[[required_data_objs_list_label]], new_data_objs_list))
  }
  else data_info[[required_data_objs_list_label]] = new_data_objs_list
  
  data_info
}

add_to_data_info_date_list = function(data_info=list(), var = "", new_date_item=c()) {
  
  if (date_list_label %in% names(data_info)) {
    if(var %in% names(data_info[[date_list_label]])) {
      message(paste("Replacing date list in data_info for", var))
    }
    data_info[[date_list_label]][[var]] = new_date_item
  }
  else {
    data_info[[date_list_label]] = list(new_date_item)
    names(data_info[[date_list_label]]) = var
  }
  data_info
}

equal_lists = function(x,y) {
  length(unique(c(x,y)))==length(y) && length(unique(c(x,y)))==length(x)
#   if(length(x) != length(y)) return(FALSE)
#   if(!all(names(x) %in% names(y)) &&  !all(names(y) %in% names(x))) return(FALSE)
#   for(nam in names(x)) {
#     if(!is.null(names(x[[nam]]))) {
#       if(!equal_lists(x[[nam]],y[[nam]])) return(FALSE)
#     }
#     else {
#       if( !(length(unique(x,y))==length(y) && length(unique(x,y))==length(x)) ) return(FALSE)
#     }
#   }
#   TRUE
}

#######
# Day Of Year data frame and table
#######
# These are called by display_doy_table
doy_data_frame = data.frame(Date = seq(as.Date("2004-01-01"), as.Date("2004-12-31"), by = "day"))
doy_data_frame$Day = day(doy_data_frame$Date)
doy_data_frame$Month = month(doy_data_frame$Date)
doy_data_frame$DOY = 1:366

doy_table <- dcast( doy_data_frame, doy_data_frame[[ "Day" ]] ~ doy_data_frame[[ "Month" ]], value.var = "DOY")

#######

save_table_to_file = function(file, table, width = 8.5, height = 11, font.size = 6, title = "", font.size_header = 12, NA.string = "NA", row.names = row.names) {
  #set output file
  rtf<-RTF(file=file, width=width, height=height, font.size=font.size)
  #add title
  addHeader(rtf, title=title, font.size=font.size_header)
  #add table
  addTable(rtf, table, NA.string=NA.string, row.names=row.names)
  #save output file
  done(rtf)
}

get_data_start_end_dates = function(data, date_col, season_start_day) {
  # TO DO better method for getting subyeary and yearly dates
  temp_start_date = doy_as_date(season_start_day,year(min(data[[date_col]])))
  if( temp_start_date > min(data[[date_col]]) ) {
    start_date = temp_start_date
    year(start_date) <- year(start_date)-1
  }
  else {
    start_date = temp_start_date      
  }
  
  final_year = year(max(data[[date_col]]))
  final_month = month(start_date-1)
  final_day = day(start_date-1)
  temp_end_date = as.Date(paste(final_year,final_month,final_day,sep="-"))
  if( temp_end_date >= max(data[[date_col]]) ) {
    end_date = temp_end_date
  }
  else {
    end_date = as.Date(paste(final_year+1,final_month,final_day,sep="-"))
  }
  
  return(c(start_date,end_date))
}
