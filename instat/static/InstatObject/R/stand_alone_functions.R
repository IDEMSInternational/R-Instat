get_default_significant_figures <- function(data) {
  if(is.numeric(data)) return(3)
  else return(NA)  
}

convert_to_character_matrix <- function(data, format_decimal_places = TRUE, decimal_places, return_data_frame = TRUE, na_display = NULL, check.names = TRUE) {
  if(nrow(data) == 0) {
    out <- matrix(nrow = 0, ncol = ncol(data))
    colnames(out) <- colnames(data)
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

output_CPT <- function(data, lat_lon_data, station_latlondata, latitude, longitude, station, year, element, long.data = TRUE, na_code = -999) {
  
  if(missing(data)) stop("data should be provided")
  if(missing(station)) stop("station must be provided")
  if(missing(year) ||  missing(latitude) || missing(longitude)) stop("year, latitude and longiude must be provided")
  
  station_label <- "STN"
  lat_lon_labels <- c("LAT", "LON")
  
  if(missing(lat_lon_data)) {
    if(long.data) {
      data <- data %>% dplyr::select(!!! quos(station, year, element, latitude, longitude))
      names(data)[1] <- "station"
      names(data)[2] <- "year"
      names(data)[3] <- "element"
      names(data)[4] <- "latitude"
      names(data)[5] <- "longitude"
      
      data <- data %>% dplyr::filter(!is.na(station))
    }
    else stop("If all data is in one data frame then must have long.data = TRUE")
  }
  else {
    if(missing(station_latlondata)) stop("station must be provided for lat_lon_data")
    
    if(long.data) {
      yearly_data <- data %>% dplyr::select(!!! quos(station, year, element))
      names(yearly_data)[1] <-  "station"
      names(yearly_data)[2] <-  "year"
      names(yearly_data)[3] <-  "element"
      
      lat_lon_data <- lat_lon_data %>% dplyr::select(!!! quos(station_latlondata, latitude, longitude))
      names(lat_lon_data)[1] <- "station"
      names(lat_lon_data)[2] <- "latitude"
      names(lat_lon_data)[3] <- "longitude"
      
      data <- merge(yearly_data, lat_lon_data, by =  "station")
    }
    else {
      stations <- data.frame(data[station])
      year <- data_unstacked %>% dplyr::select(!!! quos(year))
      data <- data.frame(year, stations)
      stacked_data <- reshape2::melt(data, id.vars=c("year"))
      names(stacked_data)[2] <-  "station"
      names(stacked_data)[3] <- "element"
      
      lat_lon_data <- lat_lon_data %>% dplyr::select(!!! quos(station_latlondata, latitude, longitude))
      names(lat_lon_data)[1] <- "station"
      names(lat_lon_data)[2] <- "latitude"
      names(lat_lon_data)[3] <- "longitude"
      
      data <- merge(stacked_data, lat_lon_data, by = "station")
      
    }
  }
  
  unstacked_data <- data %>% dplyr::select(station, year, element) %>% tidyr::spread(key = station, value = element)
  names(unstacked_data)[1] <- station_label
  unstacked_data <- unstacked_data %>% mutate_all(funs(replace(., is.na(.), na_code)))
  
  lat_lon_data <- data %>% dplyr::group_by(station) %>% dplyr::summarise(latitude = min(latitude, na.rm = TRUE), longitude = min(longitude, na.rm = TRUE))
  if(anyNA(data$latitude) || anyNA(data$longitude)) warning("Missing values in latitude or longitude.")
  t_lat_lon_data <- t(lat_lon_data)
  station.names <- as.vector(t_lat_lon_data[1, ])
  t_lat_lon_data <- data.frame(t_lat_lon_data, stringsAsFactors = FALSE)
  t_lat_lon_data <- t_lat_lon_data %>% dplyr::slice(-1)
  names(t_lat_lon_data) <- station.names
  row.names(t_lat_lon_data) <- lat_lon_labels
  t_lat_lon_data <- tibble::rownames_to_column(t_lat_lon_data, station_label)
  
  cpt_data <- rbind(t_lat_lon_data, unstacked_data)
  return(cpt_data)
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

pentad <- function(date){
	temp_pentad <- 6*(lubridate::month(date)) - 5 + (lubridate::mday(date) > 5) + (lubridate::mday(date) > 10) + (lubridate::mday(date) > 15) + (lubridate::mday(date) > 20) + (lubridate::mday(date) > 25)
	return(temp_pentad)	
 }	 

nc_get_dim_min_max <- function(nc, dimension, time_as_date = TRUE) {
  if(!dimension %in% names(nc$dim)) stop(dimension, " not found in file.")
  vals <- nc$dim[[dimension]]$vals
  dim_axes <- ncdf4.helpers::nc.get.dim.axes(nc)
  time_dims <- names(dim_axes[which(dim_axes == "T")])
  if(dimension %in% time_dims && time_as_date) {
    time_vals <- c()
    try({
      pcict_time <- ncdf4.helpers::nc.get.time.series(nc, time.dim.name = dimension)
      posixct_time <- PCICt::as.POSIXct.PCICt(pcict_time)
      # RDotNet interprets Date class as numeric so character needed to preserve date
      time_vals <- as.character(as.Date(posixct_time))
    })
    if(length(time_vals) > 0 && !anyNA(time_vals)) vals <- time_vals
  }
  bounds <- c(min(vals, na.rm = TRUE), max(vals, na.rm = TRUE))
  return(bounds)
}

nc_as_data_frame <- function(nc, vars, keep_raw_time = TRUE, include_metadata = TRUE, boundary = NULL, lon_points = NULL, lat_points = NULL, id_points = NULL, show_requested_points = TRUE, great_circle_dist = TRUE) {
  if(sum(is.null(lon_points), is.null(lat_points)) == 1) stop("You must specificy both lon_points and lat_points")
  has_points <- (sum(is.null(lon_points), is.null(lat_points)) == 0)
  if(has_points && length(lon_points) != length(lat_points)) stop("lon_points and lat_points have unequal lengths.")
  if(has_points && !is.null(id_points) && length(id_points) != length(lat_points)) stop("id_points (if specified) must have the same length as lon_points and lat_points.")
  dim_names <- ncdf4.helpers::nc.get.dim.names(nc, vars[1])
  dim_values <- list()
  requested_points_added <- FALSE
  for(dim_name in dim_names) {
    #why no wrapper for this in ncdf4.helper?
    #(as.numeric ensures vectors no not have array class)
    dim_values[[dim_name]] <- as.numeric(nc$dim[[dim_name]]$vals)
    #This is not recommended but appears in tutorials
    #ncdf4::ncvar_get(nc, dim_name)
  }
  dim_axes <- ncdf4.helpers::nc.get.dim.axes(nc, vars[1])
  if(!is.null(boundary)) {
    if(!all(names(boundary) %in% dim_names)) stop("boundary contains dimensions not associated with", vars[1])
    if(anyNA(dim_axes)) {
      warning("Cannot subset data when some dimension axes cannot be identified.")
      start <- NA
      count <- NA
    }
    else {
      start <- c()
      count <- c()
      for(dim in c("X", "Y", "Z", "T", "S")) {
        if(dim %in% dim_axes) {
          dim_var <- names(dim_axes)[which(dim_axes == dim)]
          curr_dim_values <- dim_values[[dim_var]]
          if(dim_var %in% names(boundary) && !(has_points && dim %in% c("X", "Y"))) {
            if(dim == "T") {
              ind <- integer(0)
              try({
                pcict_time <- ncdf4.helpers::nc.get.time.series(nc, time.dim.name = dim_var)
                posixct_time <- PCICt::as.POSIXct.PCICt(pcict_time)
                time_vals <- as.Date(posixct_time)
                ind <- which(time_vals >= boundary[[dim_var]][[1]] & time_vals <= boundary[[dim_var]][[2]])
              })
            }
            else ind <- which(curr_dim_values >= boundary[[dim_var]][1] & curr_dim_values <= boundary[[dim_var]][2])
            # TODO This is temporary solution for when there is only one value for a dimension and there are rounding difference
            if(length(ind) == 0 && length(curr_dim_values) == 1 && round(curr_dim_values, 3) == round(boundary[[dim_var]][1], 3) && round(curr_dim_values, 3) == round(boundary[[dim_var]][2], 3)) ind <- 1
            if(length(ind) == 0) {
              stop("No values within the range specified for ", dim_var, ".")
            }
            else {
              start <- c(start, min(ind))
              count <- c(count, length(ind))
              dim_values[[dim_var]] <- dim_values[[dim_var]][ind]
            }
          }
          else {
            start <- c(start, 1)
            count <- c(count, length(curr_dim_values))
          }
        }
      }
      if(length(start) == 0) {
        start <- rep(1, length(dim_axes))
        count <- rep(-1, length(dim_axes))
      }
    }
  }
  else {
    start <- rep(1, length(dim_axes))
    count <- rep(-1, length(dim_axes))
  }
  start_list <- list()
  count_list <- list()
  dim_values_list <- list()
  if(has_points) {
    dim_axes <- ncdf4.helpers::nc.get.dim.axes(nc, vars[1])
    x_var <- names(dim_axes)[which(dim_axes == "X")]
    y_var <- names(dim_axes)[which(dim_axes == "Y")]
    if(length(x_var) == 0 || length(y_var) == 0) stop("Cannot select points because dimensions are not labelled correctly in the nc file. Modify the nc file or remove the points to import all data.")
    xs <- dim_values[[x_var]]
    ys <- dim_values[[y_var]]
    for(i in seq_along(lon_points)) {
      curr_start <- start
      curr_count <- count
      curr_dim_values <- dim_values
      xy_possible <- expand.grid(xs, ys)
      point_ind <- which.min(sp::spDistsN1(pts = as.matrix(xy_possible), pt = c(lon_points[i], lat_points[i]), longlat = great_circle_dist))
      x_ind <- which(xs == xy_possible[point_ind, 1])[1]
      curr_start[1] <- x_ind
      curr_count[1]  <- 1
      curr_dim_values[[x_var]] <- curr_dim_values[[x_var]][x_ind]
      y_ind <- which(ys == xy_possible[point_ind, 2])[1]
      curr_start[2] <- y_ind
      curr_count[2]  <- 1
      curr_dim_values[[y_var]] <- curr_dim_values[[y_var]][y_ind]
      if(show_requested_points) {
        curr_dim_values[[paste0("requested_", x_var)]] <- lon_points[i]
        curr_dim_values[[paste0("requested_", y_var)]] <- lat_points[i]
        if(!is.null(id_points)) curr_dim_values[["requested_id"]] <- id_points[i]
        requested_points_added <- TRUE
      }
      
      start_list[[i]] <- curr_start
      count_list[[i]] <- curr_count
      dim_values_list[[i]] <- curr_dim_values
    }
  }
  else {
    start_list[[1]] <- start
    count_list[[1]] <- count
    dim_values_list[[1]] <- dim_values
  }

  dim_axes <- ncdf4.helpers::nc.get.dim.axes(nc)
  time_dims <- names(dim_axes[which(dim_axes == "T" & names(dim_axes) %in% dim_names)])
  var_data_list <- list()
  for(i in seq_along(start_list)) {
    curr_dim_values <- dim_values_list[[i]]
    curr_var_data <- expand.grid(curr_dim_values, KEEP.OUT.ATTRS = FALSE, stringsAsFactors = FALSE)
    for(j in seq_along(curr_var_data)) {
      attr(curr_var_data[[j]], "dim") <- NULL
    }
    names(curr_var_data) <- names(curr_dim_values)
    included_vars <- dim_names
    for(var in vars) {
      curr_dim_names <- ncdf4.helpers::nc.get.dim.names(nc, var)
      if(!setequal(curr_dim_names, dim_names)) {
        warning("The dimensions of", var, "do not match the other variables.", var, "will be dropped.")
      }
      else {
        included_vars <- c(included_vars, var)
        curr_var_data[[var]] <- as.vector(ncdf4::ncvar_get(nc, var, start = start_list[[i]], count = count_list[[i]]))
      }
    }
    if(length(time_dims) == 1) {
      time_var <- time_dims
      raw_time_full <- nc$dim[[time_var]]$vals
      raw_time <- curr_dim_values[[time_var]]
      attr(raw_time, "dim") <- NULL
      df_names <- time_var
      time_df <- data.frame(raw_time)
      names(time_df) <- time_var
      try({
        # need to subset this if time var has been subsetted
        time_ind <- which(raw_time_full %in% raw_time)
        pcict_time <- ncdf4.helpers::nc.get.time.series(nc, time.dim.name = time_var)
        pcict_time <- pcict_time[time_ind]
        posixct_time <- PCICt::as.POSIXct.PCICt(pcict_time)
        time_df[[paste0(time_var, "_full")]] <- posixct_time
        time_df[[paste0(time_var, "_date")]] <- as.Date(posixct_time)
      })
      if(ncol(time_df) > 1) curr_var_data <- dplyr::full_join(curr_var_data, time_df, by = time_var)
      if(!keep_raw_time) {
        var_data[[time_var]] <- NULL
        included_vars <- included_vars[-which(included_vars == time_var)]
      }
    }
    var_data_list[[i]] <- curr_var_data
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
  if(length(var_data_list) > 1) {
    var_data <- dplyr::bind_rows(var_data_list)
  }
  else if(length(var_data_list) == 1) var_data <- var_data_list[[1]]
  else var_data_list <- data.frame()
  
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

is.logical.like <- function(x) {
  if(is.logical(x)) return(TRUE)
  else if(is.numeric(x)) return(all(na.omit(x) %in% c(1,0)))
  else return(FALSE)
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
###################

# cmsaf Plot.Region script

#
# This script displays a map of the selected product. 
# You can either specify a certain year / month from a data file with several time steps
# or plot one 2D field. 
# Prepare the your netcdf-files with the R-script "Prep.Data.R" or "Apply.Function.R"
##########################################################################################

plot.region <- function(lon, lat, product, time, time_point = as.Date("2002-01-01"), add2title = "CM SAF, ", lonmin = NA, lonmax = NA, latmin = NA, latmax = NA, height = 600, width = 600, plot.ano = FALSE, set.col.breaks = FALSE, brk.set = seq(240,310,5), colmin0 = NA, colmax0 = NA, ncol = 14, plotHighRes = FALSE, plotCoastline = TRUE, plotCountries = TRUE, plotRivers = FALSE, contour.thick = 2, plotCities = TRUE, pch.cities = 2, cex.cities = 1, label.cities = TRUE, plotCapitals = 1, cex.label.cities = 0.5, dlat = 0.25, plotOwnLocations = FALSE, loc_lon = c(), loc_lat = c(), loc_name = c(""), label_pos = 1, variable = "Tm", level = 5, CTY.type = 4) {
  
  # Set the variable name
  #varname <- nc$var[[datalev]]$name
  varname <- attr(product, "name")
  if(is.null(varname)) varname <- attr(product, "longname")
  if(is.null(varname)) varname <- ""
  
  # In HLW and HSH multiple variables are stored in each file
  if (varname == "HLW" || varname =="HSH") {
    varname <- paste(varname, "_", variable, sep="")
  }
  
  # Retrieve the unit, the missing_data-value, and the title of the data
  # unit <- ncatt_get(nc, varname,"units")$value
  # missval <- ncatt_get(nc,varname,"_FillValue")$value
  unit <- attr(product, "units")
  missval <- attr(product, "_FillValue")
  
  # if (ncatt_get(nc,varname,"title")$hasatt==TRUE) {
  #   name <- ncatt_get(nc,varname,"title")$value 
  # } else {
  #   name <- varname
  # }
  name <- attr(product, "title")
  if(is.null(name)) name <- varname
  
  # The offset and the scalefactor is required because
  # the Fill_Value attribute is not applied by the ncdf-package
  # The offset and scalefactor is automatically applied to all data
  # if (ncatt_get(nc,varname,"add_offset")$hasatt==TRUE) {
  #   offset.value <- ncatt_get(nc,varname,"add_offset")$value }
  # if (ncatt_get(nc,varname,"scale_factor")$hasatt==TRUE) {
  #   scale.factor <- ncatt_get(nc,varname,"scale_factor")$value }
  offset.value <- attr(product, "add_offset")
  if(is.null(offset.value)) offset.value <- 0
  scale.factor <- attr(product, "scale_factor")
  if(is.null(scale.factor)) scale.factor <- 1
  
  time.unit <- attr(time, "units")
  
  time_ind <- which(time == time_point)
  if(length(time_ind) == 0) stop("time_point of ", time_point, " not within range of data.")
  lon <- lon[time_ind]
  lon <- unique(lon)
  lat <- lat[time_ind]
  lat <- unique(lat)
  product <- product[time_ind]
  if(missing(lonmin)) lonmin <- min(lon, na.rm = TRUE)
  if(missing(lonmax)) lonmax <- max(lon, na.rm = TRUE)
  if(missing(latmin)) latmin <- min(lat, na.rm = TRUE)
  if(missing(latmax)) latmax <- max(lat, na.rm = TRUE)
  
  nx <- length(lon)
  ny <- length(lat)
  nt <- length(time)
    
  field <- matrix(product, nrow = nx, ncol = ny)
  
  na.ind <- which(field == (missval * scale.factor + offset.value))
  field[na.ind] <- NA
  
  z <- field
  zdate <- time_point
  
  # Set the plot ranges
  lonplot=c(lonmin,lonmax)
  latplot=c(latmin,latmax)
  
  # Define the HOAPS2011 data set
  HOAPS2011 <- c("PRE","EMP","EVA","LHF","NSH","SWS")
  
  # Retrieve the name of the variable and the data
  datalev <- 1
  if (varname %in% HOAPS2011) datalev <- 2
  if (varname == "CTY") datalev <- CTY.type
  
  #--------------------------------------------------#

  # Invert the latitude dimension if necessary
  if (lat[ny] < lat[1]) {
    sort.out <- sort(lat,index.return=TRUE)
    lat <- sort.out$x
    z <- z[,sort.out$ix]
  }
  
  # Calulate the mean, min, max for the selected region only
  lon.reg <- which(lon >= lonmin & lon <= lonmax)
  lat.reg <- which(lat >= latmin & lat <= latmax)
  z.reg <- z[lon.reg,lat.reg]
  
  # Set the title of the plot
  title <- paste(name," (",unit,"), ",sep="")
  if (varname == "HLW" || varname =="HSH") {
    title <- paste(varname," (",unit,"), level: ",level.out,", ",sep="")
  }
  #----------------------------------------------------------
  # Set the number of rows and columns of the plot
  par(mfrow = c(1,1))
  
  colmin <- colmin0
  colmax <- colmax0
  
  if (is.na(colmin) && is.na(colmax)) {
    colmin <- min(z.reg,na.rm=TRUE)
    colmax <- max(z.reg,na.rm=TRUE)
  }
  
  if (set.col.breaks) {
    brk <- brk.set
  } else {
    brk <- seq(colmin,colmax,length.out=ncol+1)
  } 
  
  # Set the colors and the color bar for the Difference plots
  col.breaks <- brk
  ncolor <- length(col.breaks)
  at.ticks <- seq(1,ncolor)
  names.ticks <- round(col.breaks[at.ticks])
  zlim <- c(1,ncolor)
  
  colors <- colorRamps::matlab.like(ncolor-1)
  if (plot.ano) colors[as.integer(ncolor/2)] <- rgb(1,1,1)
  
  # Generate the field to be plotted
  field.plot <- matrix(ncol=ny,nrow=nx)
  for (l in seq(1,ncolor-1) ) {
    idx <- which(z >= col.breaks[l] &
                   z < col.breaks[l+1],arr.ind=TRUE)
    field.plot[idx] <- l + 0.1
  }
  
  if (plotCoastline && plotCountries) (plotCoastline=FALSE)
  
  # Make the plot including color bar
  fields::image.plot(lon,lat,field.plot,xlab="longitude, deg E",ylab="latitude, deg N",
             main=paste(title,add2title,zdate,sep=""),
             legend.mar = 4, xlim=lonplot, ylim=latplot, zlim=zlim,
             nlevel=(ncolor-1), col=colors,lab.breaks=names.ticks)
  
  if (plotHighRes){  
    
    data("worldMapEnv", package = "maps")
    data("worldHiresMapEnv", package = "mapdata")
    data("countriesHigh", package = "rworldxtra")
    world <- as(countriesHigh,"SpatialLines")
    
    # add rivers
    if (plotRivers) {
      maps::map('rivers', add=TRUE, col="blue")
    }
    
    # add coastline
    if (plotCoastline) {
      maps::map('worldHires', add=TRUE, interior=F)
    }
    
    # add country borders
    if (plotCountries) {
      plot(world,add=TRUE)
    }
    
    # add cities
    if (plotCities) {    
      if (label.cities) { 
        maps::map.cities(pch=pch.cities,cex=cex.cities,capitals=plotCapitals,label=TRUE)
      }else{maps::map.cities(pch=pch.cities,cex=cex.cities,capitals=plotCapitals,label=FALSE)}
    }
    
    # add own locations
    if (plotOwnLocations){
      if (length(loc_lon)==length(loc_lat)&length(loc_lon)==length(loc_name)){
        for (i in 1:length(loc_lon)){
          points(loc_lon[i],loc_lat[i],pch=pch.cities)
          text(loc_lon[i],loc_lat[i],loc_name[i], pos=label_pos)
        }
      }
    }
    
  }else{
    
    data("worldMapEnv", package = "maps")
    
    # add rivers
    if (plotRivers) {
      maps::map('rivers', add=TRUE, col="blue")
    }
    
    # add coastline
    if (plotCoastline) {
      maps::map('world', add=TRUE, interior=F)
    }
    
    # add country borders
    if (plotCountries) {
      data("countriesLow", package = "rworldmap")
      world <- as(countriesLow,"SpatialLines")
      plot(world,add=TRUE)
    }
    
    # add cities
    if (plotCities) {    
      if (label.cities) { 
        maps::map.cities(pch=pch.cities,cex=cex.cities,capitals=plotCapitals,label=TRUE)
      }
      else {
        maps::map.cities(pch=pch.cities,cex=cex.cities,capitals=plotCapitals,label=FALSE)
      }
    }
    
    # add own locations
    if (plotOwnLocations){
      if (length(loc_lon)==length(loc_lat)&length(loc_lon)==length(loc_name)){
        for (i in 1:length(loc_lon)){
          points(loc_lon[i],loc_lat[i],pch=pch.cities)
          text(loc_lon[i],loc_lat[i],loc_name[i], pos=label_pos)
        }
      }
    }
  }
  
  # Draw lines around the plot
  axis(1,lwd=1,at=c(lonmin,lonmax),tick=TRUE,lwd.ticks=0,labels=FALSE)
  axis(2,lwd=1,at=c(latmin,latmax), tick=TRUE,lwd.ticks=0,labels=FALSE)
  axis(3,lwd=1,at=c(lonmin,lonmax),tick=TRUE,lwd.ticks=0,labels=FALSE)
  axis(4,lwd=1,at=c(latmin,latmax), tick=TRUE,lwd.ticks=0,labels=FALSE)
}

duplicated_cases <- function(col_name, ignore = NULL, tolerance=0.01) {
  col_name <- as.vector(col_name)
  col_data1 <- c(1, rep(NA, length(col_name) - 1))
  
  if(is.numeric(col_name)) {
    for(i in 2:length(col_name)) {
      if(!is.na(col_data1[i-1])) {
        col_data1[i] <- ifelse((col_name[i] >= (col_name[i-1] - tolerance)) & (col_name[i] <= (col_name[i-1] + tolerance)) & !(col_name[i] %in% ignore), col_data1[i-1] + 1, 1)
      }
      else {
        col_data1[i] <- ifelse(col_name[i] %in% ignore, 1, 1) 
      }
    }
  }
  else {
    for(i in 2:length(col_name)) {
      if(!is.na(col_data1[i-1])) {
        col_data1[i] <- ifelse((col_name[i] == col_name[i-1]) & !(col_name[i] %in% ignore), col_data1[i-1] + 1, 1)
      }
      else {
        col_data1[i] <- ifelse(col_name[i] %in% ignore, 1, 1) 
      }
    }
  }
  return(col_data1)
}

#This is Sam function from issue #4270
duplicated_count_index<-function(x, type = "count"){
  if(type == "count"){
    #make sure x is a dataframe or can be coerced into a dataframe
    x<-data.frame(x)
    
    #calculate the frequency of each combo. (using plyr:: because the function name is used in other packages so need explicit-ness)
    counts<-plyr::count(x)
    
    #merge onto dataset. Adding a call to suppressMessages() because join() likes to tell you stuff a bit unneccesarily otherwise.
    x<-suppressMessages(plyr::join(x, counts))
    
    #return column. Minus 1 so that the number represents number of other matches (i.e. doesn't include itself); so zero for unique, 1 for 1 match etc
    return(x$freq-1)
  }
  if(type == "index"){
    #make sure x is a dataframe or can be coerced into a dataframe
    x<-data.frame(x)
    
    x$hash<-apply(x, 1, paste, collapse = ";;")
    x$id<-1:nrow(x)
    
    x<-x[order(x$hash),]
    x$count<-1
    for(i in 2:nrow(x)){
      x$count[i]<-ifelse(x$hash[i]==x$hash[i-1],x$count[i-1]+1,1)
    }
    x<-x[order(x$id),]
    
    return(x$count)
  }
}


get_installed_packages_with_data <- function() {
  pack_data <- data(package = .packages(all.available = TRUE))
  pack_data <- pack_data[["results"]]
  return(unique(pack_data[,1]))
}

drop_unused_levels <- function(dat, columns) {
  for(i in seq_along(columns)) {
    if(is.factor(dat[[columns[i]]])) dat[[columns[i]]] <- droplevels(dat[[columns[i]]])
  }
  return(dat)
}

compare_columns <- function(x, y, use_unique = TRUE, sort_values = TRUE, firstnotsecond = TRUE, secondnotfirst = TRUE, display_intersection = FALSE, display_union = FALSE, display_values = TRUE) {
  x_name <- deparse(substitute(x))
  y_name <- deparse(substitute(y))
  if(use_unique) {
    x <- unique(x)
    y <- unique(y)
  }
  if(sort_values) {
    x <- sort(x)
    y <- sort(y)
  }
  equal <- setequal(x, y)
  cat(paste0("Columns contain all the same values: ", equal, "\n \n"))
  if(equal) {
    if(display_values) cat(paste0("Values: ", paste0("'", x, "'", collapse = ", "), "\n \n"))
  }
  if(!equal) {
    cat("First column:", x_name, "\n \n")
    cat("Second column:", y_name, "\n \n")
    if(firstnotsecond) {
      cat("Values in first not in second: ")
      setd <- dplyr::setdiff(x, y)
      if(length(setd) != 0) cat(paste0("'", setd, "'", collapse = ", "))
      cat("\n \n")
    }
    if(secondnotfirst) {
      cat("Values in second not in first: ")
      setd <- dplyr::setdiff(y, x)
      if(length(setd) != 0) cat(paste0("'", setd, "'", collapse = ", "))
      cat("\n \n")
    }
    if(display_intersection) {
      cat("Intersection (Values that appear in both columns):")
      inter <- dplyr::intersect(x, y)
      if(length(inter) != 0) cat(paste0("'", inter, "'", collapse = ", "))
      cat("\n \n")
    }
    if(display_union) cat(paste0("Union (Values that appear in either column): ", paste0("'", dplyr::union(x, y), "'", collapse = ", ")))
  }
}


consecutive_sum <- function(x, initial_value = NA){
  out = x
  for(i in 1:length(x)){
    if(!is.na(x[i])){
    if(x[i] != 0){
      if(i > 1){
        out[i]=x[i] + out[i-1]
    } else{
        out[i] = x[i] + initial_value
      }
    } 
    }
  }
  return(out)
}

max_consecutive_sum <- function(x){
  max(consecutive_sum(x, initial_value = 0))
}

hashed_id <- function(x, salt, algo = "crc32") {
  if (missing(salt)){
      y <- x
    }else{
      y <- paste(x, salt)
    }
  y <- sapply(y, function(X) digest::digest(X, algo = algo))
  as.character(y)

}

# Possible alternative but is slower:
# spells <- function(z) {
#   Reduce(function(x,y) {y = dplyr::if_else(y == 0, 0, x + 1)}, z[-1], 
#          init = dplyr::if_else(z[1] == 0, 0, NA_real_), accumulate = TRUE)
# }
.spells <- function(x) {
  y <- mat.or.vec(length(x), 1)
  if(length(x) > 0) {
    y[1] <- dplyr::if_else(x[1] == 0, 0, NA_real_)
    if(length(x) > 1) {
      for(i in 2:length(x)) {
        y[i] <- dplyr::if_else(x[i] == 0, 0, y[i-1] + 1)
      }
    }
  }
  return(y)
}