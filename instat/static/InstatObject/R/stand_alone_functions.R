get_default_significant_figures <- function(data) {
  if(is.numeric(data)) return(3)
  else return(NA)  
}

convert_to_character_matrix <- function(data, format_decimal_places = TRUE, decimal_places, return_data_frame = TRUE) {
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
      i = i + 1
    }
    colnames(out) <- colnames(data)
    rownames(out) <- rownames(data)
  }
  if(return_data_frame) out <- data.frame(out, stringsAsFactors = FALSE)
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
   password <- getPass(paste0(username, " password:"))
   if(!missing(username) && !missing(password)) {
     has_authentication <- TRUE
     user <- authenticate(username, password)
     odk_data <- GET(url, user)
   }
   else {
     has_authentication <- FALSE
     odk_data <- GET(url)
   }

   forms <- content(odk_data, "parse")
   form_names <- sapply(forms, function(x) x$title)    # get_odk_form_names_results <- get_odk_form_names(username, platform)
  # form_names <- get_odk_form_names_results[1]
  # forms <- get_odk_form_names_results[2]
  
  if(!form_name %in% form_names) stop(form_name, " not found in available forms:", paste(form_names, collapse = ", "))
  form_num <- which(form_names == form_name)
  form_id <- forms[[form_num]]$id
  
  if(has_authentication) curr_form <- GET(paste0(url,"/", form_id), user)
  else curr_form <- GET(paste0(url,"/", form_id))
  
  form_data <- content(curr_form, "text")
  #TODO Look at how to convert columns that are lists
  #     maybe use tidyr::unnest
  out <- fromJSON(form_data, flatten = TRUE)
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
  password <- getPass(paste0(username, " password:"))
  if(!missing(username) && !missing(password)) {
    has_authentication <- TRUE
    user <- authenticate(username, password)
    odk_data <- GET(url, user)
  }
  else {
    has_authentication <- FALSE
    odk_data <- GET(url)
  }
  
  forms <- content(odk_data, "parse")
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
    if(length(sst_cols) != 1)stop("Only one SST column should be provided for long data format.")
    if(missing(station_col)) stop("station_col must be provided for long data format.")
    if(!is.character(station_col)) stop("station must be of type character.")
    if(!all(station_col %in% names(data_name))) stop(station_col,  " is missing in data.")
    row.names(data_name) = NULL
    data_name <- droplevels(data_name)
    ssT_col_names = as.character(levels(data_name[,station_col]))
    Year = c("LAT","LON")
    selected_lat_lon = t(my_lat_lon_data[ssT_col_names, c("lat", "lon")])
    selected_lat_lon = cbind(Year, selected_lat_lon)
    my_data <- as.matrix(dcast(data = data_name, formula = as.formula(paste(year_col, "~station",sep = "")), value.var = sst_cols))
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
  temp_doy <- yday(date)
  temp_leap <- leap_year(date)
  temp_doy[(!is.na(temp_doy)) & temp_doy > 59 & (!temp_leap)] <- 1 + temp_doy[(!is.na(temp_doy)) & temp_doy > 59 & (!temp_leap)]
  return(temp_doy)
}

dekade <- function(date) {
  temp_dekade <- 3 * (month(date)) - 2 + (mday(date) > 10) + (mday(date) > 20)
  return(temp_dekade)
  }

  pentad <- function(date) {
  temp_pentad <- 6 * (month(date)) - 5 + (mday(date) > 5) + (mday(date) > 10) + (mday(date) > 15) + (mday(date) > 20) + (mday(date) > 25)
  return(temp_pentad)
  }

  open_NetCDF <- function(nc_data){
    variables = names(nc_data$var)
    lat_lon_names = names(nc_data$dim)
    lat_names = c("lat", "latitude","LAT","Lat", "LATITUDE")
    lon_names = c("lon", "longitude","LON","Lon", "LONGITUDE")
    time_names = c("time", "TIME","Time","period", "Period", "PERIOD")
    lat_found = FALSE
    lon_found = FALSE
    time_found = FALSE
    if (!lat_found){
      for (i in lat_lon_names){
        if(!is.na(match(i, lat_names))){
          lat <- as.numeric(ncvar_get(nc_data, i))
          lat_found = TRUE
        }
      }
    }
    
    if (!lon_found){
      for (i in lat_lon_names){
        if(!is.na(match(i, lon_names))){
          lon <- as.numeric(ncvar_get(nc_data, i))
          lon_found = TRUE
        }
      }
    }
    
    if (!time_found){
      for (i in lat_lon_names){
        if(!is.na(match(i, time_names))){
          time <- as.numeric(ncvar_get(nc_data, i))
          time_found = TRUE
        }
      }
    }
    
    if(!lon_found || (!lat_found))stop("Latitude and longitude names could not be recognised.")
    if(!time_found){
      warning("Time variable could not be found/recognised. Time will be set to 1.")
      time = 1
    } 
    period <- rep(time, each = (length(lat)*length(lon)))
    lat_rep <- rep(lat, each = length(lon))
    lon_rep <- rep(lon, length(lat))
    lat_lon <- as.data.frame(cbind(lat_rep, lon_rep))
    names(lat_lon) = c("lat","lon")
    station <- c()
    for (j in 1:nrow(lat_lon)){
      if(lat_lon[j,1] >= 0 && lat_lon[j,2] >= 0){
        station = append(station, paste(paste("N", lat_lon[j,1], sep = ""), paste("E", lat_lon[j,2], sep = ""), sep = "_"))
      }
      if(lat_lon[j,1] < 0 && lat_lon[j,2] >= 0){
        station = append(station, paste(paste("S", abs(lat_lon[j,1]), sep = ""), paste("E", lat_lon[j,2], sep = ""), sep = "_"))
      }
      if(lat_lon[j,1] >= 0 && lat_lon[j,2] < 0){
        station = append(station, paste(paste("N", lat_lon[j,1], sep = ""), paste("W", abs(lat_lon[j,2]), sep = ""), sep = "_"))
      }
      if(lat_lon[j,1] < 0 && lat_lon[j,2] < 0){
        station = append(station, paste(paste("S", abs(lat_lon[j,1]), sep = ""), paste("W", abs(lat_lon[j,2]), sep = ""), sep = "_"))
      }
    }
    lat_lon_df <- cbind(lat_lon, station)
    my_data <- cbind(period, lat_lon_df)
    for (current_var in variables){
      nc_value <- c()
      dataset <- ncvar_get(nc_data, current_var)
      
      if (length(dim(dataset))==1){
        nc_value = dataset
      }
      else if (length(dim(dataset))==2){
        year <- dataset[1:length(lon), 1:length(lat)]
        year = as.data.frame(t(year))
        year = stack(year)
        g <- as.numeric(year$values)
        nc_value = append(nc_value, g)
      }
      else if (length(dim(dataset))==3){
        for (k in 1:length(time)){
          year <- dataset[1:length(lon), 1:length(lat), k]
          year = as.data.frame(t(year))
          year = stack(year)
          g <- as.numeric(year$values)
          nc_value = append(nc_value, g)
        }
      }
      else{
        stop("The format of the data cannot be recognised")
      }
      my_data = cbind(my_data, nc_value)
      names(my_data)[length(names(my_data))]<-current_var
    }
    return(list(my_data, lat_lon_df))
  }