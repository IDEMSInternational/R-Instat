#All date conversion methods are in this same file, initial methods enable these date derived elements to always remain updated.

#=============================================================================
# date col check
#' @title Check the date column is valid and creates it if needed.
#' @name date_col_check
#' @author Danny Parsons/David Stern 2015
#' 
#' @description \code{date_col_check} 
#' This method checks that a date column exists or can be created
#' 
#' @param date_format Specifies the format in which a date column is stored. 
#' 
#' @param convert True or False determines whether date column is converted to date class. True by deault.
#' 
#' @param create True or False determines whether date column is created if it doesn't exist. True by deault.
#' 
#' @param messages True or False determines whether warning messages are given for reomved data. True by deault.
#'  

#==========================================================================
# TODO implement full range of options particularly for subdaily data

climate_data$methods(date_col_check = function(date_format = "%d/%m/%Y", convert = TRUE, create = TRUE, messages=TRUE)
{ 
  # Check if there is a date column already
  # Check if the date is in the Date class
  # If convert == TRUE convert class to date class
  
  if(data_time_period==subdaily_label) {
    
    if (.self$is_present(date_time_label)) {
      date_time_col = getvname(date_time_label)
      if (!is.POSIXct(data[[date_time_col]])) {
        if (messages) message("date-time column is not stored as POSIXct class.")
        if (convert) {
          if (messages) message("Attempting to convert date column to POSIXct class.")
          new_col = as.POSIXct(data[[date_time_col]], format = date_format)
          .self$replace_column_in_data(date_time_col,new_col)
        }
      }
    }
    else if(create && is_present(date_label) && is_present(time_label)) {
      time_col = getvname(time_label)
      if(grepl(":",data[[time_col]][[1]])) {
        if(nchar(data[[time_col]][[1]]==5)) time_format = "%H:%M"
        else if(nchar(data[[time_col]][[1]]==8)) time_format = "%H:%M:%S"
        else stop("Cannot recognise the format of time column.")
      }
      else if(nchar(data[[time_col]][[1]]==4)) time_format = "%H%M"
      else if(nchar(data[[time_col]][[1]]==6)) time_format = "%H%M%S"
      else stop("Cannot recognise the format of time column.")
      date_col = getvname(date_label)
      new_col = as.POSIXct(paste(data[[date_col]],data[[time_col]]),
                           format = paste("%Y-%m-%d",time_format))
      .self$append_column_to_data(new_col, getvname(date_time_label), replace = TRUE)        
    }
    else if (create && is_present(date_asstring_label)) 
    {
      date_string_col = getvname(date_asstring_label)
      new_col = as.POSIXct(data[[date_string_col]], format = date_format)
      .self$append_column_to_data(new_col,getvname(date_time_label), replace = TRUE)
    }
    else if (create && is_present(date_label)) 
    {
      date_col = getvname(date_label)
      new_col = as.POSIXct(data[[date_col]], format = date_format)
      .self$append_column_to_data(new_col,getvname(date_time_label), replace = TRUE)
    }
    
  }
  if (.self$is_present(date_label)) {
    date_col = getvname(date_label)
    if (!lubridate::is.Date(data[[date_col]])) {
      if (messages) message("date column is not stored as Date class.")
      if (convert) {
        if (messages) message("Attempting to convert date column to Date class.")

        if(missing(date_format)) {
          new_col = as.Date(as.character(data[[date_col]]))
        }
        else {
          new_col = as.Date(as.character(data[[date_col]]), format = date_format)
        }
        #if the two digit year format is used then by default R makes dates into the future whereas it makes more sense in our context to assume dates are in the past. 
        if (grepl("%y",date_format)) {
          .self$replace_column_in_data(date_col,as.Date(ifelse(new_col > Sys.Date(),format(new_col, "19%y-%m-%d"), format(new_col))))
        } else {
          .self$replace_column_in_data(date_col,new_col)
        }
      }
    }
  }
  
  # Else if date string column is there and create == TRUE create date column
  else if (create && is_present(date_asstring_label)) 
  {
    date_string_col = getvname(date_asstring_label)
    new_col = as.Date(data[[date_string_col]], format = date_format)
    .self$append_column_to_data(new_col,getvname(date_label), replace = TRUE)
  }
  
  # Else if date time column is there and create == TRUE create date column
  else if (create && is_present(date_time_label)) 
  {
    date_string_col = getvname(date_time_label)
    new_col = as.Date(data[[date_string_col]], format = date_format)
    .self$append_column_to_data(new_col,getvname(date_label), replace = TRUE)
  }
  
  # If the year, month, day column are there and create == TRUE create date column
  # TODO Should we be able to handle Month column with different formats e.g. 1, "Jan" in same data frame?
  else if (create && is_present(year_label) && is_present(month_label) && is_present(day_label))
  {
    day_col = data[[getvname(day_label)]]
    month_col = data[[getvname(month_label)]]
    year_col = data[[getvname(year_label)]]
    
    if(all(month.abb %in% month_col)) {
      month_col = match(month_col,month.abb)
    }
    
    if(all(month.name %in% month_col)) {
      month_col = match(month_col,month.abb)
    }
    new_col = as.Date(paste(year_col, month_col, day_col, sep="-"))
    .self$append_column_to_data(new_col, getvname(date_label), replace = TRUE)
  }
  
  else if (create && is_present(year_label) && is_present(doy_label)) {
    year_col = data[[getvname(year_label)]]
    doy_col = data[[getvname(doy_label)]]
    new_col = do.call(c,mapply(doy_as_date,as.list(doy_col),as.list(year_col), SIMPLIFY=FALSE))
    #.self$append_column_to_data(new_col,getvname(date_label), replace = TRUE)
    .self$append_column_to_data(new_col,getvname(date_label), replace = TRUE) #not sure---steve
  }
  
  # Else check time period specific cases
  else if (data_time_period==subdaily_label || data_time_period==daily_label) {
    warning("Cannot create or edit a date column. There is insufficient information in the
            data frame to have a date column.")
  }
  
  else if (data_time_period==subyearly_label) {
    
    if (create == TRUE && is_present(year_month_label)) {
      year_month_col = data[[getvname(year_month_label)]]
      new_col = as.Date(paste(year_month_col,"1"), format = paste(date_format,"%d"))
      .self$append_column_to_data(new_col,variables[[date_label]], replace = TRUE)
    }
    
    else if (create && is_present(year_label) && is_present(month_label)) {
      year_col = data[[getvname(year_label)]]
      month_col = data[[getvname(month_label)]]
      if(all(month.abb %in% month_col)) {
        month_col = match(month_col,month.abb)
      }
      if(all(month.name %in% month_col)) {
        month_col = match(month_col,month.abb)
      }
      new_col = as.Date(paste(year_col,month_col,"1"), format = "%Y %m %d")
      .self$append_column_to_data(new_col,variables[[date_label]], replace = TRUE)
    }
    
    else {warning("Cannot create or edit a date column. There is insufficient information in the
                  data frame to have a date column.")}
    }
  
  else if (data_time_period==yearly_label) {
    if (create && is_present(year_label)) {
      year_col = variables[[year_label]]
      new_col = as.Date(paste(data[[year_col]],1,1), format = "%Y %m %d")
      .self$append_column_to_data(new_col,variables[[date_label]], replace = TRUE)
    }
    
    else {warning("Cannot create or edit a date column. There is insufficient information in the
                  data frame to have a date column.")}
    }
  }
)

#=============================================================================
# Update Date columns
#' @title Check and fill in missind dates
#' @name update_date_cols
#' @author Danny Parsons/David Stern 2015
#' 
#' @description \code{update_date_cols} 
#' This method forces an update of all date related columns
#' 
#' ?@param messages True or False determines whether warning messages are given for reomved data. True by deault. 
#' 

climate_data$methods(update_date_cols = function()
{
  updated_year_col = FALSE
  if(is_present(list(doy_label, dos_label, season_label),require_all=FALSE)) {
    .self$add_doy_col(update=TRUE)
    updated_year_col = TRUE
  }
  if(is_present(list(day_label,month_label),require_all=FALSE)||((!updated_year_col)&&is_present(year_label))) {
    .self$add_year_month_day_cols(update=TRUE)
  }
} 
)

#=============================================================================
# missing dates check
#' @title Check and fill in missind dates
#' @name missing_dates_check
#' @author Danny Parsons/David Stern 2015
#' 
#' @description \code{missing_dates_check} 
#' This method checks for and fills in missing dates as well as removing rows where the date is missing or invalid
#' 
#' @param messages True or False determines whether warning messages are given for reomved data. True by deault. 
#' 

climate_data$methods(missing_dates_check = function(messages = TRUE)
{    
  # TO DO fill in missing dates for other time periods. Also check for DOY DOS ...
  
  if(data_time_period == daily_label) {
    date_col = getvname(date_label)
    if(anyNA(data[[date_col]])){
      if (messages){
        warning("The following data has been removed from your dataset because the date column was missing")
        warning(subset(data,is.na(data[[date_col]])))
      }
      .self$set_data(subset(data,!is.na(data[[date_col]])), messages)
    }
  }
  
  if(!get_meta(complete_dates_label)) {
    changed=FALSE
    curr_data_list = .self$get_data_for_analysis(list())
    dates_tables = list()
    i = 1
    for (curr_data in curr_data_list){
      full_dates=list()
      if(data_time_period == daily_label) {      
        start_end_dates = get_data_start_end_dates(curr_data, date_col, season_start_day = .self$get_meta(season_start_day_label))
        full_dates = seq(start_end_dates[[1]], start_end_dates[[2]], by = "day")
      }
      if(length(full_dates) > nrow(curr_data)) {
        curr_date_table = data.frame(full_dates)
        names(curr_date_table) <- date_col
        if (is_present(station_label)) curr_date_table[[getvname(station_label)]]<- get_station_data(curr_data,station_label)
        dates_tables[[i]] <- curr_date_table
        i = i + 1  
        if (!changed) changed=TRUE
      }
    }
    dates_merge = do.call("rbind",dates_tables)
    if (changed) {
      .self$join_data(dates_merge, match="first", type="full")
      append_to_meta_data(complete_dates_label,TRUE)
      .self$update_date_cols() 
    }
  }
} 
)

#=============================================================================
# add year month day cols
#' @title Add year, month and day columns
#' @name add_year_month_day_cols
#' @author Danny Parsons/David Stern 2015
#' 
#' @description \code{add_year_month_day_cols} 
#' This method adds or updates Year Month and Day Columns from the date column 
#' 
#' @param update True or False determines whether existing columns are replaced. False by deault. 
#' 
#' @param YearLabel Variable label for Year column, "Year" by default
#' 
#' @param MonthLabel Variable label for Month column, "Month" by default
#' 
#' @param DayLabel Variable label for Day column, "Day" by default
#'  

climate_data$methods(add_year_month_day_cols = function(update=FALSE, YearLabel="Year", MonthLabel="Month", DayLabel="Day")
{
  if (.self$is_present(date_label)){
    date_col = variables[[date_label]]
    if (!.self$is_present(year_label) || update){
      if (.self$is_present(year_label) && update){ 
        YearLabel= variables[[year_label]]
      } else {
        .self$append_to_variables(year_label, YearLabel)
      }
      .self$append_column_to_data(factor(year(data[[date_col]]), ordered = TRUE), YearLabel, replace = TRUE) 
    }
    if (!data_time_period==yearly_label){      
      if (!.self$is_present(month_label) || update){
        if (.self$is_present(month_label) && update) {
          MonthLabel= variables[[month_label]]
        } else {
          .self$append_to_variables(month_label, MonthLabel)
        }
        .self$append_column_to_data (factor(month(data[[date_col]]), ordered = TRUE), MonthLabel, replace = TRUE) 
      }
      if (!data_time_period==subyearly_label) {
        if (!.self$is_present(day_label) || update){
          if (.self$is_present(day_label) && update) {
            DayLabel= variables[[day_label]]
          } else {
            .self$append_to_variables(day_label, DayLabel)
          }
          .self$append_column_to_data (factor(day(data[[date_col]]), ordered = TRUE), DayLabel, replace = TRUE) 
        }
      }
    }
  }
  else warning("No Date column. Check that your data has date information and create a date colum using date_col_check.")
}
)


# climate method as a wrapper of the climate_data method: add_year_month_day_cols
climate$methods(add_year_month_day_cols = function(data_list = list(), update=FALSE, YearLabel="Year", MonthLabel="Month", DayLabel="Day")
{
  climate_data_objs_list = .self$get_climate_data_objects(data_list)
  
  for(data_obj in climate_data_objs_list) {
    data_obj$add_year_month_day_cols(update = update, YearLabel = YearLabel, MonthLabel = MonthLabel, DayLabel = DayLabel)
  }
}
)



#=============================================================================
# add day of year cols
#' @title Add Day of Year columns
#' @name add_doy_col
#' @author Danny Parsons/David Stern 2015
#' 
#' @description \code{add_doy_col} 
#' This method adds or updates Day of Year and Season Columns from the date column. 
#' The concept of Season and Day of Season is to allow the specification of the start of year. 
#' 
#' @param update True or False determines whether existing collumns are replaced. False by deault. 
#' 
#' @param YearLabel Variable label for Year column, "Year" by default
#' 
#' @param DOYLabel Variable label for Day of the Year column, "DOY" by default
#' 
#' @param SeasonLabel Variable label for Season column, "Season" by default
#'  
#' @param DOSLabel Variable label for Day of the Season column, "DOS" by default
#'  

climate_data$methods(add_doy_col = function(update=FALSE, YearLabel="Year", DOYLabel="DOY", SeasonLabel="Season", DOSLabel="DOS")
{
  if (.self$is_present(date_label)){    
    date_col = variables[[date_label]]
    if (!.self$is_present(year_label) || update){
      if (.self$is_present(year_label) && update) YearLabel= variables[[year_label]]
      .self$append_column_to_data (factor(year(data[[date_col]]), ordered = TRUE), YearLabel, replace = TRUE) 
      .self$append_to_variables(year_label, YearLabel)
    }
    if (!.self$is_present(doy_label) || update){
      if (.self$is_present(doy_label) && update) DOYLabel= variables[[doy_label]]
      TEMPDOY = yday(data[[date_col]])      
      temply=leap_year(data[[date_col]])
      TEMPDOY[((TEMPDOY > 59) & (!(temply)))] <- 1 + TEMPDOY[((TEMPDOY > 59)&(!(temply)))]
      .self$append_column_to_data (TEMPDOY, DOYLabel, replace = TRUE) 
      .self$append_to_variables(doy_label, DOYLabel)
    }
    if (is_meta_data(season_start_day_label)){
      #--------------------------------------------------------------#
      # find the specified start date of the year in 366 form
      #--------------------------------------------------------------#
      if (.self$is_present(dos_label)) {
        if (variables[[dos_label]]==variables[[doy_label]]) append_to_variables(dos_label,DOSLabel)
        if (update) DOSLabel = variables[[dos_label]]
      }
      if (.self$is_present(season_label)) {
        if (variables[[season_label]]==variables[[year_label]]) append_to_variables(season_label,SeasonLabel)
        if (update) SeasonLabel = variables[[season_label]]
      }
      if (update||(!(.self$is_present(dos_label))||(!.self$is_present(season_label)))) {
        if (1<meta_data[[season_start_day_label]] & meta_data[[season_start_day_label]]<367){
          TEMPDOY <- data[[variables[[doy_label]]]]
          TEMPDOS <- TEMPDOY - meta_data[[season_start_day_label]] + 1
          #TO DO allow flexibility for how season is written.
          TEMPSEASON=data[[variables[[year_label]]]]
          TEMPSEASON[(TEMPDOS < 1)]<-paste(as.numeric(TEMPSEASON[(TEMPDOS < 1)])-1, TEMPSEASON[(TEMPDOS < 1)],sep = "-")
          TEMPSEASON[(TEMPDOS > 0)]<-paste(TEMPSEASON[(TEMPDOS > 0)], as.numeric(TEMPSEASON[(TEMPDOS > 0)])+1,sep = "-")
          TEMPDOS[(TEMPDOS < 1)] <- TEMPDOS[(TEMPDOS < 1)] + 366
          .self$append_column_to_data (TEMPDOS, DOSLabel, replace = TRUE) 
          .self$append_to_variables(dos_label, DOSLabel)
          .self$append_column_to_data (as.factor(TEMPSEASON), SeasonLabel, replace = TRUE) 
          .self$append_to_variables(season_label, SeasonLabel)
        }
        else{
          .self$append_to_variables(dos_label, DOYLabel)
          .self$append_to_variables(season_label, YearLabel)
        }
      }
      else{
        .self$append_to_variables(dos_label, DOYLabel)
        .self$append_to_variables(season_label, YearLabel)
      }      
    }
  }
  else warning("No Date column. Check that your data has date information and create a date colum using date_col_check.")
}
)

climate_data$methods(date_format_check = function(convert = TRUE, messages=TRUE) {
  
  if(is_present(month_label)) {
    month_col = data[[getvname(month_label)]]
    if(!is.factor(month_col)) {
      if(convert && all(month.abb %in% month_col)) {
        if(messages) message("Converting month column to ordered factor.")
        replace_column_in_data(getvname(month_label),factor(data[[getvname(month_label)]], month.abb, ordered=TRUE))
      }
      
      else if(convert && all(month.name %in% month_col)) {
        if(messages) message("Converting month column to ordered factor.")
        replace_column_in_data(getvname(month_label),factor(data[[getvname(month_label)]], month.name, ordered=TRUE))
      }
      else if(convert && is.numeric(month_col)) {
        if(messages) message("Converting month column to ordered factor.")
        replace_column_in_data(getvname(month_label),factor(data[[getvname(month_label)]], ordered=TRUE))
      }
      
      else {
        warning("Month column is not stored as a factor and the format was not recognised so could not be converted to a factor.")
      }
    }
  }
  
}
)