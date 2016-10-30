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

import_CPT <- function(dataset, data_from = 5){
  start_year <-min(get_years_from_data(dataset))
  end_year <-max(get_years_from_data(dataset))
  duration =length(get_years_from_data(dataset))

  lon = get_lon_from_data(dataset)
  lat = get_lat_from_data(dataset)
  
  column_names<-c()
  for (i in 1:length(lat)){
    for (j in 1:length(lon)){
      column_names = append(column_names, paste(paste("lat", lat[i], sep = ""), paste("lon", lon[j], sep = ""), sep = "_"))
    }
  }
  my_data = as.data.frame(matrix(NA, nrow = duration, ncol = (length(lat)*length(lon)+1)))
  my_data[,1] = get_years_from_data(dataset)
  names(my_data) <- c("year",column_names)
  for (k in 1:duration){
    nam <- paste("year", start_year + k-1, sep = "_")
    year <-matrix(NA, nrow = length(lat), ncol = length(lon))
    for (i in 1:length(lat)){
      for (j in 1:length(lon)){
        dat = as.numeric(as.character(dataset[data_from+i, j+1]))
        year[i,j] = dat
        j=j+1
      }
      i=i+1
    }
    year=as.data.frame(t(year))
    year=stack(year)
    data_from = data_from+length(lat)+2
    g=as.numeric(year$values)
    my_data[k,2:ncol(my_data)] = g
    k=k+1
  }
  return(my_data)
}

get_years_from_data <- function(dataset){
  return(as.numeric(format(as.Date(na.omit(t(unique(dataset[3,2:ncol(dataset)])))), '%Y')))
}

get_lat_from_data <- function(dataset){
  return(unique(na.omit(as.numeric(as.character(dataset[5:nrow(dataset),1])))))
}

get_lon_from_data <- function(dataset){
  return(as.numeric(na.omit(t(unique(dataset[5,2:ncol(dataset)])))))
}