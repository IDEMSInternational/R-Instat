get_default_decimal_places <- function(data) {
  if(is.numeric(data)) {
    min_data <- min(data, na.rm = TRUE)
    if(class(data) %in% "integer" || min_data > 100) {
      return(0)
    }
    else {
      if(min_data > 10) {
        return(1)
      }
      else {  
        return(2) 
      }
    }
  }
  else return(NA)  
}

convert_to_character_matrix <- function(data, format_decimal_places = TRUE, decimal_places, return_data_frame = TRUE) {
  if(nrow(data) == 0) {
    out <- data
  }
  else {
    out = matrix(nrow = nrow(data), ncol = ncol(data))
    if(!format_decimal_places) decimal_places=rep(NA, ncol(data))
    else if(missing(decimal_places)) decimal_places = sapply(data, get_default_decimal_places)
    i = 1
    for(curr_col in colnames(data)) {
      if(is.na(decimal_places[i])) {
        out[,i] <- as.character(data[[i]])
      }
      else {
        out[,i] <- as.character(format(data[[i]], nsmall = decimal_places[i]))
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

import_from_ODK = function(username, password, form_name, platform) {
  if(platform == "kobo") {
    url <- "https://kc.kobotoolbox.org/api/v1/data"
  }
  else if(platform == "ona") {
    url <- "https://api.ona.io/api/v1/data"
  }
  else stop("Unrecognised platform.")
  
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

get_odk_form_names = function(username, password, platform) {
  #TODO This should not be repeated
  if(platform == "kobo") {
    url <- "https://kc.kobotoolbox.org/api/v1/data"
  }
  else if(platform == "ona") {
    url <- "https://api.ona.io/api/v1/data"
  }
  else stop("Unrecognised platform.")
  
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
  start_year <-get_years_from_data(datafile)[1]
  end_year <-get_years_from_data(datafile)[length(get_years_from_data(datafile))]
  duration =get_years_from_data(datafile)

  lon = get_lon_from_data(datafile)
  lat = get_lat_from_data(datafile)
  lat_lon_df = lat_lon_dataframe(datafile)
  
  my_data = as.data.frame(matrix(NA, nrow = length(duration), ncol = (length(lat)*length(lon)+1)))
  my_data[,1] = get_years_from_data(datafile)
  names(my_data) <- c("period", as.character(lat_lon_df$station))
  v=1
  for (k in duration){
    nam <- k #paste("year", start_year + k-1, sep = "_")
    year <-matrix(NA, nrow = length(lat), ncol = length(lon))
    for (i in 1:length(lat)){
      for (j in 1:length(lon)){
        dat = as.numeric(as.character(datafile[data_from+i, j+1]))
        year[i,j] = dat
        j=j+1
      }
      i=i+1
    }
    year=as.data.frame(t(year))
    year=stack(year)
    data_from = data_from+length(lat)+2
    g=as.numeric(year$values)
    my_data[v,2:ncol(my_data)] = g
    v=v+1
  }
  my_data_stacked <- melt(data=my_data, id.vars="period", value.name="value", measure.vars=as.character(lat_lon_df$station))
  names(my_data_stacked) = c("period", "station","sst_value")
  
  return(list(my_data_stacked, my_data, lat_lon_df))
}

get_years_from_data <- function(datafile){
  return(na.omit(t(unique(datafile[3,2:ncol(datafile)])))) #will apply order
}

get_lat_from_data <- function(datafile){
  return(unique(na.omit(as.numeric(as.character(datafile[5:nrow(datafile),1])))))
}

get_lon_from_data <- function(datafile){
  return(as.numeric(na.omit(t(unique(datafile[5,2:ncol(datafile)])))))
}

lat_lon_dataframe <- function(datafile){
  latitude  = get_lat_from_data(datafile)
  longitude = get_lon_from_data(datafile)
  lat = rep(latitude, each = length(longitude))
  lon = rep(longitude, length(latitude))
  lat_lon = as.data.frame(cbind(lat, lon))
  
  station <- c()
  for (j in 1:nrow(lat_lon)){
    station = append(station, paste(paste("lat", lat_lon[j,1], sep = ""), paste("lon", lat_lon[j,2], sep = ""), sep = "_"))
  }
  return(cbind(lat_lon,station))
}