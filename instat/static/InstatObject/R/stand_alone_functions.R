get_default_significant_figures <- function(data) {
  if(is.numeric(data)) return(3)
  else return(NA)  
}

convert_to_character_matrix <- function(data, format_decimal_places = TRUE, decimal_places, return_data_frame = TRUE, na_display = NULL, check.names = TRUE) {
  if(nrow(data) == 0) {
    out <- data
  }
  else {
    out = matrix(nrow = nrow(data), ncol = ncol(data))
    if(!format_decimal_places) decimal_places=rep(NA, ncol(data))
    else if(missing(decimal_places)) decimal_places = sapply(data, get_default_significant_figures)
    i = 1
    for(curr_col in colnames(data)) {
      if(is.na(decimal_places[i])) {
        out[,i] <- as.character(data[[i]])
      }
      else {
        out[,i] <- format(data[[i]], digits = decimal_places[i], scientific = FALSE)
      }
      if(!is.null(na_display)) {
        out[is.na(data[[i]]),i] <- na_display
      }
      i = i + 1
    }
    colnames(out) <- colnames(data)
    rownames(out) <- rownames(data)
  }
  if(return_data_frame) out <- data.frame(out, stringsAsFactors = FALSE, check.names = check.names)
  return(out)
}

next_default_item = function(prefix, existing_names = c(), include_index = TRUE, start_index = 1) {
  if(!is.character(prefix)) stop("prefix must be of type character")
  
  if(!include_index) {
    if(!prefix %in% existing_names) return(prefix)
  }
  
  item_name_exists = TRUE
  start_index = 1
  while(item_name_exists) {
    out = paste0(prefix,start_index)
    if(!out %in% existing_names) {
      item_name_exists = FALSE
    }
    start_index = start_index + 1
  }
  return(out)
}

import_from_ODK = function(username, form_name, platform) {
  if(platform == "kobo") {
    url <- "https://kc.kobotoolbox.org/api/v1/data"
  }
  else if(platform == "ona") {
    url <- "https://api.ona.io/api/v1/data"
  }
  else stop("Unrecognised platform.")
  password <- getPass::getPass(paste0(username, " password:"))
  if(!missing(username) && !missing(password)) {
    has_authentication <- TRUE
    user <- httr::authenticate(username, password)
    odk_data <- httr::GET(url, user)
  }
  else {
    has_authentication <- FALSE
    odk_data <- httr::GET(url)
  }
  
  forms <- httr::content(odk_data, "parse")
  form_names <- sapply(forms, function(x) x$title)    # get_odk_form_names_results <- get_odk_form_names(username, platform)
  # form_names <- get_odk_form_names_results[1]
  # forms <- get_odk_form_names_results[2]
  
  if(!form_name %in% form_names) stop(form_name, " not found in available forms:", paste(form_names, collapse = ", "))
  form_num <- which(form_names == form_name)
  form_id <- forms[[form_num]]$id
  
  if(has_authentication) curr_form <- httr::GET(paste0(url,"/", form_id), user)
  else curr_form <- httr::GET(paste0(url,"/", form_id))
  
  form_data <- httr::content(curr_form, "text")
  #TODO Look at how to convert columns that are lists
  #     maybe use tidyr::unnest
  out <- jsonlite::fromJSON(form_data, flatten = TRUE)
  return(out)
}

get_odk_form_names = function(username, platform) {
  #TODO This should not be repeated
  if(platform == "kobo") {
    url <- "https://kc.kobotoolbox.org/api/v1/data"
  }
  else if(platform == "ona") {
    url <- "https://api.ona.io/api/v1/data"
  }
  else stop("Unrecognised platform.")
  password <- getPass::getPass(paste0(username, " password:"))
  if(!missing(username) && !missing(password)) {
    has_authentication <- TRUE
    user <- httr::authenticate(username, password)
    odk_data <- httr::GET(url, user)
  }
  else {
    has_authentication <- FALSE
    odk_data <- httr::GET(url)
  }
  
  forms <- httr::content(odk_data, "parse")
  form_names <- sapply(forms, function(x) x$title)
  return(form_names)
}

convert_SST <- function(datafile, data_from = 5){
  start_year <- get_years_from_data(datafile)[1]
  end_year <- get_years_from_data(datafile)[length(get_years_from_data(datafile))]
  duration <- get_years_from_data(datafile)
  lon <- get_lon_from_data(datafile)
  lat <- get_lat_from_data(datafile)
  lat_lon_df <- lat_lon_dataframe(datafile)
  period <- rep(get_years_from_data(datafile), each = (length(lat)*length(lon)))
  SST_value <- c()
  
  for (k in duration){
    year <- matrix(NA, nrow = length(lat), ncol = length(lon))
    for (i in 1:length(lat)){
      for (j in 1:length(lon)){
        dat <- as.numeric(as.character(datafile[data_from+i, j+1]))
        year[i,j] <- dat
        j = j+1
      }
      i = i+1
    }
    year = as.data.frame(t(year))
    year = stack(year)
    data_from = data_from + length(lat) + 2
    g <- as.numeric(year$values)
    SST_value = append(SST_value, g)
  }
  my_data = cbind(period, lat_lon_df, SST_value)
  return(list(my_data, lat_lon_df))
}

get_years_from_data <- function(datafile){
  return(na.omit(t(unique(datafile[3,2:ncol(datafile)]))))
}

get_lat_from_data <- function(datafile){
  return(unique(na.omit(as.numeric(as.character(datafile[5:nrow(datafile),1])))))
}

get_lon_from_data <- function(datafile){
  return(na.omit(as.numeric(unique(t(datafile[5,2:ncol(datafile)])))))
}

lat_lon_dataframe <- function(datafile){
  latitude  <- get_lat_from_data(datafile)
  longitude <- get_lon_from_data(datafile)
  lat <- rep(latitude, each = length(longitude))
  lon <- rep(longitude, length(latitude))
  lat_lon <- as.data.frame(cbind(lat, lon))
  station <- c()
  for (j in 1:nrow(lat_lon)){
    if(lat_lon[j,1]>=0){
      station = append(station, paste(paste("latN", lat_lon[j,1], sep = ""), paste("lon", lat_lon[j,2], sep = ""), sep = "_"))
    }
    else{
      station = append(station, paste(paste("latS", abs(lat_lon[j,1]), sep = ""), paste("lon", lat_lon[j,2], sep = ""), sep = "_"))
    }
  }
  return(cbind(lat_lon,station))
}

output_for_CPT = function(data_name, lat_lon_data, long = TRUE, year_col, sst_cols, station_col = ""){
  if(missing(data_name) || missing(data_name)) stop("data_name and lat_lon_data should be provided.")
  if(missing(year_col) || missing(sst_cols)) stop("year_col and sst_cols must be provided.")
  if(!is.character(year_col) || !is.character(sst_cols)) stop("year_col and sst_cols must be of type character.")
  if(!all(c(year_col, sst_cols) %in% names(data_name))) stop("Some column(s) are missing in data")
  my_lat_lon_data <- lat_lon_data
  row.names(my_lat_lon_data) <- lat_lon_data$station
  if (long){
    if(length(sst_cols) != 1) stop("Only one SST column should be provided for long data format.")
    if(missing(station_col)) stop("station_col must be provided for long data format.")
    if(!is.character(station_col)) stop("station must be of type character.")
    if(!all(station_col %in% names(data_name))) stop(station_col,  " is missing in data.")
    row.names(data_name) = NULL
    data_name <- droplevels(data_name)
    ssT_col_names = as.character(levels(data_name[,station_col]))
    Year = c("LAT","LON")
    selected_lat_lon = t(my_lat_lon_data[ssT_col_names, c("lat", "lon")])
    selected_lat_lon = cbind(Year, selected_lat_lon)
    my_data <- as.matrix(reshape2::dcast(data = data_name, formula = as.formula(paste(year_col, "~station",sep = "")), value.var = sst_cols))
    my_data = as.data.frame(rbind(selected_lat_lon, my_data))
  }
  else{
    ssT_col_names = sst_cols
    selected_lat_lon = t(my_lat_lon_data[ssT_col_names, c("lat", "lon")])
    my_data = data_name[,c(ssT_col_names)]
    if(length(ssT_col_names)==1){
      my_data = as.data.frame(my_data)
      names(my_data) = ssT_col_names
    }
    my_data = rbind(selected_lat_lon, my_data)
    Year = c("LAT","LON", as.vector(data_name[,c(year_col)]))
    my_data = as.data.frame(cbind(Year, my_data))
  }
  data.table::setnames(my_data, "Year", "STN")
  return(my_data)
}

yday_366 <- function(date) {
  temp_doy <- lubridate::yday(date)
  temp_leap <- lubridate::leap_year(date)
  temp_doy[(!is.na(temp_doy)) & temp_doy > 59 & (!temp_leap)] <- 1 + temp_doy[(!is.na(temp_doy)) & temp_doy > 59 & (!temp_leap)]
  return(temp_doy)
}

dekade <- function(date) {
  temp_dekade <- 3 * (lubridate::month(date)) - 2 + (lubridate::mday(date) > 10) + (lubridate::mday(date) > 20)
  return(temp_dekade)
}

pentad <- function(date) {
  m <- lubridate::month(date)
  temp_pentad <- 6 * (m) - 5 + (m > 5) + (m > 10) + (m > 15) + (m > 20) + (m > 25)
  return(temp_pentad)
}

nc_as_data_frame <- function(nc, vars, keep_raw_time = TRUE, include_metadata = TRUE) {
  dim_names <- ncdf4.helpers::nc.get.dim.names(nc, vars[1])
  
  dim_values <- list()
  for(dim_name in dim_names) {
    #why no wrapper for this in ncdf4.helper?
    dim_values[[length(dim_values) + 1]] <- nc$dim[[dim_name]]$vals
    #This is not recommended but appears in tutorials
    #ncdf4::ncvar_get(nc, dim_name)
  }
  var_data <- expand.grid(dim_values, KEEP.OUT.ATTRS = FALSE)
  for(i in seq_along(var_data)) {
    attr(var_data[[i]], "dim") <- NULL
  }
  names(var_data) <- dim_names
  included_vars <- dim_names
  for(var in vars) {
    curr_dim_names <- ncdf4.helpers::nc.get.dim.names(nc, var)
    if(!setequal(curr_dim_names, dim_names)) {
      warning("The dimensions of", var, "do not match the other variables.", var, "will be dropped.")
    }
    else {
      included_vars <- c(included_vars, var)
      var_data[[var]] <- as.vector(ncdf4::ncvar_get(nc, var))
    }
  }
  
  dim_axes <- ncdf4.helpers::nc.get.dim.axes(nc)
  time_dims <- names(dim_axes[which(dim_axes == "T" & names(dim_axes) %in% dim_names)])
  if(length(time_dims) == 1) {
    time_var <- time_dims
    raw_time <- nc$dim[[time_var]]$vals
    attr(raw_time, "dim") <- NULL
    df_names <- time_var
    time_df <- data.frame(raw_time)
    names(time_df) <- time_var
    try({
      pcict_time <- ncdf4.helpers::nc.get.time.series(nc, time.dim.name = time_var)
      posixct_time <- PCICt::as.POSIXct.PCICt(pcict_time)
      time_df[[paste0(time_var, "_full")]] <- posixct_time
      time_df[[paste0(time_var, "_date")]] <- as.Date(posixct_time)
    })
    if(ncol(time_df) > 1) var_data <- dplyr::full_join(var_data, time_df, by = time_var)
    if(!keep_raw_time) {
      var_data[[time_var]] <- NULL
      included_vars <- included_vars[-which(included_vars == time_var)]
    }
  }
  # # Following conventions in http://www.unidata.ucar.edu/software/netcdf/docs/attribute_conventions.html
  # if(replace_missing) {
  #   for(inc_var in included_vars) {
  #     
  #     numeric_var <- is.numeric(var_data[[inc_var]])
  #     integer_var <- is.integer(var_data[[inc_var]])
  #     valid_range <- ncdf4::ncatt_get(nc, var, "valid_range")
  #     valid_min <- ncdf4::ncatt_get(nc, var, "valid_min")
  #     valid_max <- ncdf4::ncatt_get(nc, var, "valid_max")
  #     fill_value <- ncdf4::ncatt_get(nc, var, "_FillValue")
  #     missing_value <- ncdf4::ncatt_get(nc, var, "missing_value")
  # 
  #     if(numeric_var && valid_range[[1]]) {
  #       var_data[[inc_var]][var_data[[inc_var]] < valid_range[[2]][1] | var_data[[inc_var]] > valid_range[[2]][2]] <- NA
  #     }
  #     else if(numeric_var && (valid_min[[1]] || valid_max[[1]])) {
  #       if(valid_min[[1]]) {
  #         var_data[[inc_var]][var_data[[inc_var]] < valid_min[[2]]] <- NA
  #       }
  #       if(valid_max[[2]]) {
  #         var_data[[inc_var]][var_data[[inc_var]] > valid_max[[2]]] <- NA
  #       }
  #     }
  #     else if(fill_value[[1]]) {
  #       val <- fill_value[[2]]
  #       if(numeric_var) {
  #         # Not sure this is safe if 'integer' types from file do not import as
  #         # 'integer' types in R.
  #         if(integer_var) width <- 1
  #         else width <- 2 * .Machine$double.xmin
  #         
  #         if(val > 0) var_data[[inc_var]][var_data[[inc_var]] > val + width] <- NA
  #         else var_data[[inc_var]][var_data[[inc_var]] < val - width] <- NA
  #       }
  #       else {
  #         # Should we do this? Non numeric not mentioned in convention
  #         var_data[[inc_var]][var_data[[inc_var]] %in% val] <- NA
  #       }
  #     }
  #     if(missing_value[[1]]) var_data[[inc_var]][var_data[[inc_var]] %in% missing_value[[2]]] <- NA
  #   }
  # }
  
  if(include_metadata) {
    for(col_name in included_vars) {
      col_attr <- ncdf4::ncatt_get(nc, col_name)
      for(i in seq_along(col_attr)) {
        attr(var_data[[col_name]], names(col_attr)[i]) <- col_attr[[i]]
      }
    }
    global_attr <- ncdf4::ncatt_get(nc, 0)
    for(i in seq_along(global_attr)) {
      attr(var_data, names(global_attr)[i]) <- global_attr[[i]]
    }
  }
  return(var_data)
}

# open_NetCDF <- function(nc_data, latitude_col_name, longitude_col_name, default_names){
#   variables = names(nc_data$var)
#   lat_lon_names = names(nc_data$dim)
#   #we may need to add latitude_col_name, longitude_col_name to the character vector of valid names
#   lat_names = c("lat", "latitude", "LAT", "Lat", "LATITUDE")
#   lon_names = c("lon", "longitude", "LON", "Lon", "LONGITUDE")
#   time_names = c("time", "TIME", "Time", "period", "Period", "PERIOD")
#   if (stringr::str_trim(latitude_col_name) != ""){
#     lat_names <- c(lat_names, latitude_col_name)
#   }
#   if (str_trim(longitude_col_name) != ""){
#     lon_names <- c(lon_names, longitude_col_name)
#   }
#   lat_in <- which(lat_lon_names %in% lat_names)
#   lat_found <- (length(lat_in) == 1)
#   if(lat_found) {
#     lat <- as.numeric(ncdf4::ncvar_get(nc_data, lat_lon_names[lat_in]))
#   }
#   
#   lon_in <- which(lat_lon_names %in% lon_names)
#   lon_found <- (length(lon_in) == 1)
#   if(lon_found) {
#     lon <- as.numeric(ncdf4::ncvar_get(nc_data, lat_lon_names[lon_in]))
#   }
#   
#   time_in <- which(lat_lon_names %in% time_names)
#   time_found <- (length(time_in) == 1)
#   if(time_found) {
#     time <- as.numeric(ncdf4::ncvar_get(nc_data, lat_lon_names[time_in]))
#   }
#   
#   if(!lon_found || (!lat_found)) stop("Latitude and longitude names could not be recognised.")
#   if(!time_found) {
#     warning("Time variable could not be found/recognised. Time will be set to 1.")
#     time = 1
#   } 
#   period <- rep(time, each = (length(lat)*length(lon)))
#   lat_rep <- rep(lat, each = length(lon))
#   lon_rep <- rep(lon, length(lat))
#   # if (!default_names){
#   #   #we need to check if the names are valid
#   #   new_lat_lon_column_names <- c(latitude_col_name, longitude_col_name)
#   # }
#   # else{
#   new_lat_lon_column_names <- c(lat_lon_names[lat_in], lat_lon_names[lon_in])
#   #}
#   lat_lon <- as.data.frame(cbind(lat_rep, lon_rep))
#   names(lat_lon) = new_lat_lon_column_names
#   station = ifelse(lat_rep >= 0 & lon_rep >= 0, paste(paste("N", lat_rep, sep = ""), paste("E", lon_rep, sep = ""), sep = "_"), 
#                    ifelse(lat_rep < 0 & lon_rep >= 0, paste(paste("S", abs(lat_rep), sep = ""), paste("E", lon_rep, sep = ""), sep = "_"), 
#                           ifelse(lat_rep >= 0 & lon_rep < 0, paste(paste("N", lat_rep, sep = ""), paste("W", abs(lon_rep), sep = ""), sep = "_") , 
#                                  paste(paste("S", abs(lat_rep), sep = ""), paste("W", abs(lon_rep), sep = ""), sep = "_"))))
#   
#   lat_lon_df <- cbind(lat_lon, station)
#   my_data <- cbind(period, lat_lon_df)
#   
#   for (current_var in variables){
#     dataset <- ncdf4::ncvar_get(nc_data, current_var)
#     if(length(dim(dataset)) == 1) {
#       nc_value = dataset
#     }
#     else if(length(dim(dataset)) == 2) {
#       nc_value = as.vector(t(dataset))
#     }
#     else if(length(dim(dataset)) == 3) {
#       lonIdx <- which(!is.na(lon))
#       latIdx <- which(!is.na(lat))
#       timeIdx <- which(!is.na(time))
#       new_dataset <- dataset[lonIdx, latIdx, timeIdx]
#       nc_value = as.vector(new_dataset)
#     }
#     else {
#       stop("The format of the data cannot be recognised")
#     }
#     my_data = cbind(my_data, nc_value)
#     names(my_data)[length(names(my_data))] <- current_var
#   }
#   return(list(my_data, lat_lon_df, new_lat_lon_column_names))
# }


import_from_iri <- function(download_from, data_file, path, X1, X2,Y1,Y2, get_area_point){
  if(path == ""){
    gaugelocdir = getwd()
  }
  else {
    if(!dir.exists(path)){
      dir.create(path)
    }
    gaugelocdir = path
  }
  
  if(download_from == "CHIRPS_V2P0"){
    prexyaddress <- "https://iridl.ldeo.columbia.edu/SOURCES/.UCSB/.CHIRPS/.v2p0"
    if(data_file == "daily_0p05") {
      extension <- ".daily/.global/.0p05/.prcp"
    }
    else if(data_file == "daily_0p25") {
      extension <- ".daily/.global/.0p25/.prcp"
    }
    else if(data_file == "daily_improved_0p05") {
      extension <- ".daily-improved/.global/.0p05/.prcp"
    }
    else if(data_file == "daily_improved_0p25") {
      extension <- ".daily-improved/.global/.0p25/.prcp"
    }
    else if(data_file == "dekad") {
      extension <- ".dekad/.prcp"
    }
    else if(data_file == "monthly_c8113") {
      extension <- ".monthly/.global/.c8113/.precipitation"
    }
    else if(data_file == "monthly_deg1p0") {
      extension <- ".monthly/.global/.deg1p0/.precipitation"
    }
    else if(data_file == "monthly_NMME_deg1p0") {
      extension <- ".monthly/.global/.NMME_deg1p0/.precipitation"
    }
    else if(data_file == "monthly_prcp") {
      extension <- ".monthly/.global/.precipitation"
    }
    
    else stop("Data file does not exist for CHIRPS V2P0 data")
    #Annual and 2Monthly and 3monthly does not exist for CHIRPS_V2P0
  }
  else if(download_from == "TAMSAT") {
    prexyaddress <- "http://iridl.ldeo.columbia.edu/home/.remic/.Reading/.Meteorology/.TAMSAT"
    if(data_file == "rainfall_estimates") {
      extension <- ".TAMSAT-RFE/.rfe"
    }
    else if(data_file == "reconstructed_rainfall_anomaly") {
      extension <- ".TAMSAT-RFE/.rfediff"
    }
    else if(data_file == "sahel_dry_mask") {
      extension <- ".TAMSAT-RFE/.sahel_drymask"
    }
    else if(data_file == "SPI_1_dekad") {
      extension <- ".TAMSAT-RFE/.SPI-rfe_1-dekad_Sahel"
    }
    #monthly,climatology and TAMSAT RFE 0p1 are yet to be implemented.
    else stop("Data file does not exist for TAMSAT data")
  }
  else if(download_from=="NOAA_ARC2") {
    prexyaddress<-paste("http://iridl.ldeo.columbia.edu/SOURCES/.NOAA/.NCEP/.CPC/.FEWS/.Africa/.DAILY/.ARC2")
    if(data_file == "daily_estimated_prcp") {
      extension <- ".daily/.est_prcp"
    }
    else if(data_file == "monthly_average_estimated_prcp") {
      extension <- ".monthly/.est_prcp"
    }
    else stop("Data file does not exist for NOAA ARC2 data")
  }
  else if(download_from=="NOAA_RFE2") {
    prexyaddress <- "http://iridl.ldeo.columbia.edu/SOURCES/.NOAA/.NCEP/.CPC/.FEWS/.Africa"
    if(data_file == "daily_estimated_prcp"){
      extension <- ".DAILY/.RFEv2/.est_prcp"
    }
    else stop("Data file does not exist for NOAA RFE2 data")
  }
  else if(download_from=="NOAA_CMORPH_DAILY" || download_from=="NOAA_CMORPH_3HOURLY" || download_from=="NOAA_CMORPH_DAILY_CALCULATED") {
    if(download_from=="NOAA_CMORPH_DAILY") {
      prexyaddress <- "http://iridl.ldeo.columbia.edu/SOURCES/.NOAA/.NCEP/.CPC/.CMORPH/.daily"
    }
    else if(download_from == "NOAA_CMORPH_3HOURLY") {
      prexyaddress <- "http://iridl.ldeo.columbia.edu/SOURCES/.NOAA/.NCEP/.CPC/.CMORPH/.3-hourly"
    }
    if(download_from == "NOAA_CMORPH_DAILY_CALCULATED") {
      prexyaddress <- "http://iridl.ldeo.columbia.edu/SOURCES/.NOAA/.NCEP/.CPC/.CMORPH/.daily_calculated"
    }
    
    if(data_file == "mean_microwave_only_est_prcp") {
      extension <- ".mean/.microwave-only/.comb"
    }
    else if(data_file == "mean_morphed_est_prcp") {
      extension <- ".mean/.morphed/.cmorph"
    }
    if(data_file == "orignames_mean_microwave_only_est_prcp") {
      extension <- ".orignames/.mean/.microwave-only/.comb"
    }
    else if(data_file == "orignames_mean_morphed_est_prcp") {
      extension <- ".orignames/.mean/.morphed/.cmorph"
    }
    if(data_file == "renamed102015_mean_microwave_only_est_prcp") {
      extension <- ".renamed102015/.mean/.microwave-only/.comb"
    }
    else if(data_file == "renamed102015_mean_morphed_est_prcp") {
      extension <- ".renamed102015/.mean/.morphed/.cmorph"
    }
    else stop("Data file does not exist for NOAA CMORPH data")
  }
  else if(download_from=="NASA_TRMM_3B42") {
    prexyaddress <- "https://iridl.ldeo.columbia.edu/SOURCES/.NASA/.GES-DAAC/.TRMM_L3/.TRMM_3B42/.v7"
    if(data_file == "daily_estimated_prcp") {
      extension <- ".daily/.precipitation"
    }
    else if(data_file == "3_hourly_estimated_prcp") {
      extension <- ".three-hourly/.precipitation"
    }
    else if(data_file == "3_hourly_pre_gauge_adjusted_infrared_est_prcp") {
      extension <- ".three-hourly/.IRprecipitation"
    }
    else if(data_file == "3_hourly_pre_gauge_adjusted_microwave_est_prcp") {
      extension <- ".three-hourly/.HQprecipitation"
    }
    else stop("Data file does not exist for NASA TRMM 3B42 data")
  }
  else{
    stop("Source not specified correctly.")
  }
  
  prexyaddress = paste(prexyaddress, extension, sep="/")
  #we need to add time range to get the data
  if(get_area_point == "area") {
    xystuff <- paste("X", X1, X2, "RANGEEDGES/Y", Y1, Y2, "RANGEEDGES", sep = "/")
    postxyaddress <- "ngridtable+table-+skipanyNaN+4+-table+.csv" 
  }
  else if(get_area_point == "point") {
    xystuff <- paste("X", X1, "VALUES/Y", Y1, "VALUES", sep = "/")
    postxyaddress <- "T+exch+table-+text+text+skipanyNaN+-table+.csv" 
  }
  else stop("Unrecognised download type.")
  
  address <- paste(prexyaddress,xystuff,postxyaddress,sep="/")
  
  file.name <- paste(gaugelocdir,"tmp_iri.csv", sep="/")
  download.file(address, file.name, quiet=FALSE)
  dataout <- read.table(paste(gaugelocdir, "tmp_iri.csv", sep="/"), sep = ",", header = TRUE)
  if(nrow(dataout) == 0) stop("There is no data for the selected point/area.")
  
  if(get_area_point == "point") {
    Longitude <- rep(X1, nrow(dataout))
    Latitude = rep(Y1, nrow(dataout))
    dataout = cbind(Longitude, Latitude, dataout)
  }
  
  lat_lon_dataframe = unique(dataout[,c(1,2)])
  
  file.remove(paste(gaugelocdir,"tmp_iri.csv",sep="/"))
  return(list(dataout,lat_lon_dataframe))
}

is.binary <- function(x) {
  if(is.logical(x)) return(TRUE)
  else if(is.numeric(x)) return(all(na.omit(x) %in% c(1,0)))
  else if(is.factor(x)) return(nlevels(x) == 2)
  else return(FALSE)
}

get_column_attributes <- function(x, drop = c("class", "levels")) {
  tmp_attr <- attributes(x)
  tmp_attr <- tmp_attr[!names(tmp_attr) %in% drop]
  return(tmp_attr)
}

split_items_in_groups <- function(items, num) {
  if(length(items) %% num != 0) stop("The number of items must be divisible by the number of groups")
  x <- split(items, rep(1:num, each = length(items)/num))
  return(x)
}

cancor_coef <- function(object) {
  object[c("xcoef", "ycoef")]
}