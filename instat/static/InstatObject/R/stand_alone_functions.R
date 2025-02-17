# convert_to_character_matrix -  get_default_significant_figures

# climdex, climatic_details - make_factor


convert_to_character_matrix <- function(data, format_decimal_places = TRUE, decimal_places, is_scientific = FALSE, return_data_frame = TRUE, na_display = NULL, check.names = TRUE) {
  if(nrow(data) == 0) {
    out <- matrix(nrow = 0, ncol = ncol(data))
    colnames(out) <- colnames(data)
  }
  else {
    out = matrix(nrow = nrow(data), ncol = ncol(data))
    if(!format_decimal_places) decimal_places=rep(NA, ncol(data))
    else if(missing(decimal_places)) decimal_places = sapply(data, get_default_significant_figures)
    i = 1
    for (curr_col in colnames(data)) {
      #if its a geometry list-column then convert to text using sf package.
      #see issue #7165
      if ("sfc" %in% class(data[[i]])) {
        out[, i] <- sf::st_as_text(data[[i]])
      } else if (is.na(decimal_places[i])) {
        #use as.character() for non numeric column vales because format() adds extra spaces to the text
        #which are recognised oddly by the R.Net
        out[, i] <- as.character(data[[i]])
      } else {
        out[,i] <- format(data[[i]], digits = decimal_places[i], scientific = is_scientific[i])
      }
      if (!is.null(na_display)) {
        out[is.na(data[[i]]), i] <- na_display
      }
      i = i + 1
    }
    colnames(out) <- colnames(data)
    rownames(out) <- rownames(data)
  }
  if(return_data_frame) out <- data.frame(out, stringsAsFactors = FALSE, check.names = check.names)
  return(out)
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
      units <- ncdf4::ncatt_get(nc, dimension, "units")
      if(units$hasatt && units$value == "julian_day") {
        # RDotNet interprets Date class as numeric so character needed to preserve date
        time_vals <- as.character(as.Date(vals, origin = structure(-2440588, class = "Date")))
      }
      else {
        pcict_time <- ncdf4.helpers::nc.get.time.series(nc, time.dim.name = dimension)
        posixct_time <- PCICt::as.POSIXct.PCICt(pcict_time)
        # RDotNet interprets Date class as numeric so character needed to preserve date
        time_vals <- as.character(as.Date(posixct_time))
      }
    })
    if(length(time_vals) > 0 && !anyNA(time_vals)) vals <- time_vals
  }
  bounds <- c(min(vals, na.rm = TRUE), max(vals, na.rm = TRUE))
  return(bounds)
}

nc_as_data_frame <- function(nc, vars, keep_raw_time = TRUE, include_metadata = TRUE, boundary = NULL, lon_points = NULL, lat_points = NULL, id_points = NULL, show_requested_points = TRUE, great_circle_dist = TRUE) {
  if(missing(vars)) vars <- ncdf4.helpers::nc.get.variable.list(nc)
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
                print(dim_var)
                units <- ncdf4::ncatt_get(nc, dim_var, "units")
                if(units$hasatt && units$value == "julian_day") {
                  # RDotNet interprets Date class as numeric so character needed to preserve date
                  time_vals <- as.Date(curr_dim_values, origin = structure(-2440588, class = "Date"))
                }
                else {
                  pcict_time <- ncdf4.helpers::nc.get.time.series(nc, time.dim.name = dim_var)
                  posixct_time <- PCICt::as.POSIXct.PCICt(pcict_time)
                  time_vals <- as.Date(posixct_time)
                }
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
        curr_dim_values[[paste0(x_var, "_point")]] <- lon_points[i]
        curr_dim_values[[paste0(y_var, "_point")]] <- lat_points[i]
        if(!is.null(id_points)) curr_dim_values[["station"]] <- id_points[i]
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
        units <- ncdf4::ncatt_get(nc, time_var, "units")
        if(units$hasatt && units$value == "julian_day") {
          time_df[["date"]] <- as.Date(raw_time, origin = structure(-2440588, class = "Date"))
        }
        else {
          pcict_time <- ncdf4.helpers::nc.get.time.series(nc, time.dim.name = time_var)
          pcict_time <- pcict_time[time_ind]
          posixct_time <- PCICt::as.POSIXct.PCICt(pcict_time)
          time_df[["date"]] <- as.Date(posixct_time)
          time_df[["datetime"]] <- posixct_time
        }
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

multiple_nc_as_data_frame <- function(path, vars, keep_raw_time = TRUE, include_metadata = TRUE, boundary = NULL, lon_points = NULL, lat_points = NULL, id_points = NULL, show_requested_points = TRUE, great_circle_dist = TRUE, id = "id") {
  filepaths <- list.files(path = path, pattern="*\\.nc", full.names = TRUE)
  filenames <- basename(filepaths)
  nc_list <- list()
  
  n_files <- length(filepaths)
  is_win <- Sys.info()['sysname'] == "Windows"
  if (is_win) pb <- winProgressBar(title = "Reading files", min = 0, max = n_files)
  for(i in seq_along(filepaths)) {
    nc <- ncdf4::nc_open(filename = filepaths[i])
    dat <- nc_as_data_frame(nc = nc, vars = vars, keep_raw_time = keep_raw_time, include_metadata = include_metadata, boundary = boundary, lon_points = lon_points, lat_points = lat_points, id_points = id_points, show_requested_points = show_requested_points, great_circle_dist = great_circle_dist)
    nc_list[[length(nc_list) + 1]] <- dat
    ncdf4::nc_close(nc)
    info <- paste0("Reading file ", i, " of ", n_files, " - ", round(100*i/n_files), "%")
    if (is_win) setWinProgressBar(pb, value = i, title = info, label = info)
  }
  if (is_win) close(pb)
  names(nc_list) <- tools::file_path_sans_ext(filenames)
  merged_data <- dplyr::bind_rows(nc_list, .id = id)
  return(merged_data)
}

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

max_consecutive_sum <- function(x){
  max(consecutive_sum(x, initial_value = 0))
}

# Possible alternative but is slower:
# spells <- function(z) {
#   Reduce(function(x,y) {y = dplyr::if_else(y == 0, 0, x + 1)}, z[-1], 
#          init = dplyr::if_else(z[1] == 0, 0, NA_real_), accumulate = TRUE)
# }
.spells <- function(x, initial_value = NA_real_) {
  y <- mat.or.vec(length(x), 1)
  if(length(x) > 0) {
    y[1] <- dplyr::if_else(x[1] == 0, 0, initial_value + 1)
    if(length(x) > 1) {
      for(i in 2:length(x)) {
        y[i] <- dplyr::if_else(x[i] == 0, 0, y[i-1] + 1)
      }
    }
  }
  return(y)
}

convert_to_dec_deg <- function (dd, mm = 0 , ss = 0, dir) {
  if(missing(dd))  stop("dd must be supplied")
  if(!missing(dir)) {
    dir <- toupper(dir)
    if(!all(na.omit(dir) %in% c("E", "W", "N", "S"))) stop("dir must only contain direction letters E, W, N or S")
    if(any(na.omit(dd) < 0)) stop("dd must be positive if dir is supplied") 
  }
  if(!all(mm >= 0 & mm <= 60, na.rm = TRUE)) stop("mm must be between 0 and 60")
  if(!all(ss >= 0 & ss <= 60, na.rm = TRUE)) stop("ss must be between 0 and 60")
  sgn <- ifelse(is.na(dir), NA, ifelse(dir %in% c("S", "W"), -1, 1))
  decdeg <- (dd + ((mm * 60) + ss)/3600) * sgn
  return(decdeg)
}

convert_yy_to_yyyy <- function (x, base) {
    if(missing(base))  stop("base year must be supplied")
    dplyr::if_else(x+2000 <= base, x+2000, x+1900)
}

add_xy_area_range <- function(path, min_lon, max_lon, min_lat, max_lat, dim_x = "X", dim_y = "Y") {
  paste0(
    path, "/", dim_x, "/",
    "(", ifelse(min_lon < 0, paste0(abs(min_lon), "W"), paste0(min_lon, "E")), ")", "/",
    "(", ifelse(max_lon < 0, paste0(abs(max_lon), "W"), paste0(max_lon, "E")), ")", "/",
    "RANGEEDGES", "/",
    dim_y, "/",
    "(", ifelse(min_lat < 0, paste0(abs(min_lat), "S"), paste0(min_lat, "N")), ")", "/",
    "(", ifelse(max_lat < 0, paste0(abs(max_lat), "S"), paste0(max_lat, "N")), ")", "/",
    "RANGEEDGES", "/"
  )
}

add_xy_point_range <- function(path, min_lon, min_lat, dim_x = "X", dim_y = "Y") {
  paste0(
    path, "/", dim_x, "/",
    "(", ifelse(min_lon < 0, paste0(abs(min_lon), "W"), paste0(min_lon, "E")), ")", "/",
    "VALUES", "/",
    dim_y, "/",
    "(", ifelse(min_lat < 0, paste0(abs(min_lat), "S"), paste0(min_lat, "N")), ")", "/",
    "VALUES", "/"
  )
}

add_t_range <- function(path, min_date, max_date, dim_t = "T") {
  paste0(
    path, dim_t, "/",
    "(", lubridate::day(min_date), "%20", lubridate::month(min_date, label = TRUE),
    "%20", lubridate::year(min_date), ")", "/",
    "(", lubridate::day(max_date), "%20", lubridate::month(max_date, label = TRUE),
    "%20", lubridate::year(max_date), ")", "/",
    "RANGEEDGES", "/"
  )
}

add_nc <- function(path) {
  paste0(path, "data.nc")
}
              
fourier_series <- function(x, n, period) {
  p2 <- "2 * pi"
  h <-  seq_len(n)
  paste0("sin(", x, " * ", h, " * ", p2, " / ", period, ")", " + ", 
         "cos(", x, " * ", h, " * ", p2, " / ", period, ")", 
         collapse = " + ")
}


climatic_missing <- function(data, date, elements = ..., stations,
                             start = TRUE, end = FALSE){
  
  
  if (missing(date)){
    stop('argument "date" is missing, with no default')
  }
  
  if (missing(elements)){
    stop('argument "elements" is missing, with no default')
  }
  
  # stack data
  data.stack <- data %>%
    tidyr::pivot_longer(cols = c({{ elements }}),
                 names_to = "Element",
                 values_to = "value")
  
  # sort start/end times

    # set start date
    if (start){
      data.stack <- data.stack %>%
        dplyr::group_by({{ stations }}, Element) %>%
        dplyr::mutate(start = ({{ date }})[which.min(is.na( value ))])
      
    }else{
      data.stack <- data.stack %>%
        dplyr::group_by({{ stations }}) %>%
        dplyr::mutate(start = dplyr::first( {{ date }} ))
    }
    
    # set end date
    if (end){
      data.stack <- data.stack %>%
        dplyr::group_by({{ stations }}, Element ) %>%
        dplyr::mutate(end = ({{ date }} )[dplyr::last(which(!is.na( value )))])
    }else{
      data.stack <- data.stack %>%
        dplyr::group_by({{ stations }} ) %>%
        dplyr::mutate(end = dplyr::last({{ date }}))
    }
    
    # number and percentage missing
    summary.data <- data.stack %>%
                                 dplyr::group_by({{ stations }}, Element) %>%
                                 dplyr::filter(({{ date }}) >= start & ({{ date }}) <= end) %>%
                                 dplyr::summarise(From = dplyr::first(start),
                                                  To = dplyr::last(end),
                                                  Missing = sum(is.na(value)),
                                                  `%` = round(sum(is.na(value))/n()*100, 1))
    
    # complete years
    complete.years <- data.stack %>%
      dplyr::group_by({{ stations }}) %>%
      dplyr::filter(({{ date }}) >= start & ({{ date }}) <= end) %>%
      dplyr::group_by(lubridate::year({{ date }}), {{ stations }}, Element) %>%
      dplyr::summarise(count = sum(is.na(value)))
    complete.years <- complete.years %>%
      dplyr::group_by({{ stations }}, Element) %>%
      dplyr::summarise(Full_Years = sum(count == 0))
    
  
    # bind together
    summary.data <- merge(summary.data, complete.years)
    
    if (missing(stations)){
      summary.data$stations <- NULL
    }

  return(summary.data)
}  

  
  
climatic_details <- function(data, date, elements = ..., stations,
                 order = TRUE,
                 day = FALSE,
                 month = TRUE,
                 year = FALSE, level = FALSE){
  
  
  if (missing(date)){
    stop('argument "date" is missing, with no default')
  }
  
  if (missing(elements)){
    stop('argument "elements" is missing, with no default')
  }
  
  i <- 0
  list_tables <- NULL
  
  # stack data
  data.stack <- data %>%
    tidyr::pivot_longer(cols = c({{ elements }}),
                 names_to = "Element",
                 values_to = "Value") %>%
    dplyr::mutate(Element = make_factor(Element))
  
  # sort start/end times
  
  if (!any(day, month, year)){
         warning('At least one of day, month, year need to be selected')
  }
    
    if (day){
      i = i + 1
      detail.table.day = data.stack %>%
        dplyr::group_by({{ stations }}, Element) %>%
        dplyr::mutate(element.na = data.table::rleid(Value)) %>%
        dplyr::filter(is.na(Value)) %>%
        dplyr::group_by(element.na, {{ stations }}, Element) %>%
        dplyr::summarise(From = dplyr::first({{ date }}),
                  To = dplyr::last({{ date }}),
                  Count = dplyr::n()) %>%
        mutate(Level = "Day")
      
      if (order){
        detail.table.day <- detail.table.day %>% dplyr::arrange(From)
      } else {  
        detail.table.day <- detail.table.day %>% dplyr::arrange(Element)
      }
      
      detail.table.day <- detail.table.day %>% dplyr::ungroup() %>% dplyr::select(-c("element.na"))
      list_tables[[i]] <- detail.table.day
      
    }
    
    if (month){
      i = i + 1
      detail.table.month <- data.stack %>%
        dplyr::mutate(Date.ym = zoo::as.yearmon({{ date }}))  %>%
        dplyr::group_by(Date.ym, {{ stations }}, Element)
      
      detail.table.month <- detail.table.month %>%
        dplyr::summarise(no = n(),
                  na = sum(is.na(Value)),
                  From = dplyr::first({{ date }}),
                  To = dplyr::last({{ date }})) %>%
        dplyr::mutate(is.complete = ifelse(no == na, 1, 0)) # 0 if all are missing

      detail.table.month <- detail.table.month %>%
        dplyr::group_by({{ stations }}, Element) %>%
        dplyr::mutate(element.na = data.table::rleid(is.complete)) %>%
        dplyr::filter(is.complete == 1) %>%
        dplyr::group_by(element.na, {{ stations }}, Element) %>%
        dplyr::summarise(From = dplyr::first(From),
                  To = dplyr::last(To),
                  Count = n()) %>%
        mutate(Level = "Month")
      
      if (order){
        detail.table.month <- detail.table.month %>% dplyr::arrange(From)
      } else {
        detail.table.month <- detail.table.month %>% dplyr::arrange(Element)
      }
      
      detail.table.month <- detail.table.month %>% dplyr::ungroup() %>% dplyr::select(-c("element.na"))
      list_tables[[i]] <- detail.table.month
    }
    
    if (year) {
      i = i + 1
      detail.table.year <- data.stack %>%
        dplyr::mutate(Date.y = lubridate::year({{ date }}))  %>%
        dplyr::group_by(Date.y, {{ stations }}, Element)
      
      detail.table.year <- detail.table.year %>%
        dplyr::summarise(no = n(),
                  na = sum(is.na(Value)),
                  From = dplyr::first({{ date }}),
                  To = dplyr::last({{ date }})) %>%
        dplyr::mutate(is.complete = ifelse(no == na, 1, 0)) # 0 if all are missing
      
      detail.table.year <- detail.table.year %>%
        dplyr::group_by({{ stations }}, Element) %>%
        dplyr::mutate(element.na = data.table::rleid(is.complete)) %>%
        dplyr::filter(is.complete == 1) %>%
        dplyr::group_by(element.na, {{ stations }}, Element) %>%
        dplyr::summarise(From = dplyr::first(From),
                  To = dplyr::last(To),
                  Count = n()) %>%
        mutate(Level = "Year")
      
      if (order){
        detail.table.year <- detail.table.year %>% dplyr::arrange(From)
      } else {
        detail.table.year <- detail.table.year %>% dplyr::arrange(Element)
      }
      
      detail.table.year <- detail.table.year %>% dplyr::ungroup() %>% dplyr::select(-c("element.na"))
      list_tables[[i]] <- detail.table.year
    }
  
  detail.table.all <- plyr::ldply(list_tables, data.frame) %>%
                      dplyr::mutate(Level = make_factor(Level))
  
  return(detail.table.all)

}

# wwr_export function is meant to reshape data into formats required by WMO for submission of climatic data
# this gives Yearly data records with monthly and annual data for a particular year:
wwr_export <- function(data, year, month, mean_station_pressure, mean_sea_level_pressure, 
                       mean_temp, total_precip, mean_max_temp, mean_min_temp, mean_rel_hum, link, link_by,
                       station_data, wmo_number, latitude, longitude, country_name, station_name, 
                       height_station, height_barometer, wigos_identifier, folder) {
  
  stopifnot(link_by %in% c("wmo_number", "station_name"))
  if (any(nchar(station_data[[year]]) != 4)) stop("year must be a 4 digit number.")
  if (!missing(wmo_number)) {
    # Convert to character to avoid incorrect 
    if (is.factor(station_data[[wmo_number]])) station_data[[wmo_number]] <- as.character(station_data[[wmo_number]])
    if (any(is.na(as.numeric(station_data[[wmo_number]])))) stop("wmo_number must not contain missing values and must be a number.")
    if (any(nchar(as.character(station_data[[wmo_number]])) > 5, na.rm = TRUE)) stop("wmo_number must be no more than 5 digits.")
  }
  
  if (link_by == "wmo_number") {
    station_link <- wmo_number
  } else station_link <- station_name
  if (!all(unique(data[[link]]) %in% station_data[[station_link]])) {
    stop("station_data is missing information for the following stations
         found in the data:",
         paste(which(!unique(data[[link]]) %in% station_data[[wmo_number]]), collapse = ", "))
  }
  if (!missing(wmo_number)) {
    station_data[[wmo_number]] <- as.numeric(station_data[[wmo_number]])
    station_data[[wmo_number]] <- ifelse(is.na(station_data[[wmo_number]]),
                                         "", sprintf("%05d", station_data[[wmo_number]]))
  } else {
    wmo_number <- ".wmo_number"
    station_data[[wmo_number]] <- ""
  }
  station_data[[latitude]] <- dd_to_dms(station_data[[latitude]], lat = TRUE)
  station_data[[longitude]] <- dd_to_dms(station_data[[longitude]], lat = FALSE)
  if (!missing(height_station)) {
    station_data[[height_station]] <- ifelse(is.na(station_data[[height_station]]),
                                             "", round(station_data[[height_station]]))
  } else {
    height_station <- ".height_station"
    station_data[[height_station]] <- ""
  }
  if (!missing(height_barometer)) {
    station_data[[height_barometer]] <- ifelse(is.na(station_data[[height_barometer]]),
                                               "", round(station_data[[height_barometer]], 1))
  } else {
    height_barometer <- ".height_barometer"
    station_data[[height_barometer]] <- ""
  }
  if (missing(wigos_identifier)) {
    wigos_identifier <- ".wigos_identifier"
    station_data[[wigos_identifier]] <- ""
  }
  if (!missing(mean_station_pressure)) {
    df_2_means <- data %>%
      dplyr::group_by(!!! rlang::syms(c(link, year))) %>%
      dplyr::summarise(mean = sprintf("%6s", round(summary_mean(.data[[mean_station_pressure]], na.rm = TRUE), 1)), .groups = "keep")
    data[[mean_station_pressure]] <- ifelse(is.na(data[[mean_station_pressure]]), 
                                            "", round(data[[mean_station_pressure]], 1))
    data[[mean_station_pressure]] <- sprintf("%6s", data[[mean_station_pressure]])
    df_2 <- data %>% tidyr::pivot_wider(id_cols = tidyselect::all_of(c(link, year)),
                                        names_from = tidyselect::all_of(month),
                                        values_from = tidyselect::all_of(mean_station_pressure),
                                        values_fill = strrep(" ", 6))
  }
  if (!missing(mean_sea_level_pressure)) {
    df_3_means <- data %>%
      dplyr::group_by(!!! rlang::syms(c(link, year))) %>%
      dplyr::summarise(mean = sprintf("%6s", round(summary_mean(.data[[mean_sea_level_pressure]], na.rm = TRUE), 1)), .groups = "keep")
    data[[mean_sea_level_pressure]] <- ifelse(is.na(data[[mean_sea_level_pressure]]), 
                                              "", round(data[[mean_sea_level_pressure]], 1))
    data[[mean_sea_level_pressure]] <- sprintf("%6s", data[[mean_sea_level_pressure]])
    df_3 <- data %>% tidyr::pivot_wider(id_cols = tidyselect::all_of(c(link, year)),
                                        names_from = tidyselect::all_of(month),
                                        values_from = tidyselect::all_of(mean_sea_level_pressure),
                                        values_fill = strrep(" ", 6))
  }
  if (!missing(mean_temp)) {
    df_4_means <- data %>%
      dplyr::group_by(!!! rlang::syms(c(link, year))) %>%
      dplyr::summarise(mean = sprintf("%6s", round(summary_mean(.data[[mean_temp]], na.rm = TRUE), 1)), .groups = "keep")
    data[[mean_temp]] <- ifelse(is.na(data[[mean_temp]]), 
                                "", round(data[[mean_temp]], 1))
    data[[mean_temp]] <- sprintf("%6s", data[[mean_temp]])
    df_4 <- data %>% tidyr::pivot_wider(id_cols = tidyselect::all_of(c(link, year)),
                                        names_from = tidyselect::all_of(month),
                                        values_from = tidyselect::all_of(mean_temp),
                                        values_fill = strrep(" ", 6))
  }
  if (!missing(total_precip)) {
    df_5_means <- data %>%
      dplyr::group_by(!!! rlang::syms(c(link, year))) %>%
      dplyr::summarise(mean = sprintf("%6s", format(summary_sum(.data[[total_precip]], na.rm = TRUE), digits = 1, nsmall = 1)), .groups = "keep")
    data[[total_precip]] <- ifelse(is.na(data[[total_precip]]), 
                                   "", ifelse(data[[total_precip]] <= 0.05, 0, format(data[[total_precip]], digits = 1, nsmall = 1)))
    data[[total_precip]] <- sprintf("%6s", data[[total_precip]])
    df_5 <- data %>% tidyr::pivot_wider(id_cols = tidyselect::all_of(c(link, year)),
                                        names_from = tidyselect::all_of(month),
                                        values_from = tidyselect::all_of(total_precip),
                                        values_fill = strrep(" ", 6))
  }
  if (!missing(mean_max_temp)) {
    df_6_means <- data %>%
      group_by(!!! rlang::syms(c(link, year))) %>%
      dplyr::summarise(mean = sprintf("%6s", round(summary_mean(.data[[mean_max_temp]], na.rm = TRUE), 1)), .groups = "keep")
    data[[mean_max_temp]] <- ifelse(is.na(data[[mean_max_temp]]), 
                                    "", round(data[[mean_max_temp]], 1))
    data[[mean_max_temp]] <- sprintf("%6s", data[[mean_max_temp]])
    df_6 <- data %>% tidyr::pivot_wider(id_cols = tidyselect::all_of(c(link, year)),
                                        names_from = tidyselect::all_of(month),
                                        values_from = tidyselect::all_of(mean_max_temp),
                                        values_fill = strrep(" ", 6))
  }
  if (!missing(mean_min_temp)) {
    df_7_means <- data %>%
      dplyr::group_by(!!! rlang::syms(c(link, year))) %>%
      dplyr::summarise(mean = sprintf("%6s", round(summary_mean(.data[[mean_min_temp]], na.rm = TRUE), 1)), .groups = "keep")
    data[[mean_min_temp]] <- ifelse(is.na(data[[mean_min_temp]]), 
                                    "", round(data[[mean_min_temp]], 1))
    data[[mean_min_temp]] <- sprintf("%6s", data[[mean_min_temp]])
    df_7 <- data %>% tidyr::pivot_wider(id_cols = tidyselect::all_of(c(link, year)),
                                        names_from = tidyselect::all_of(month),
                                        values_from = tidyselect::all_of(mean_min_temp),
                                        values_fill = strrep(" ", 6))
  }
  if (!missing(mean_rel_hum)) {
    if (any(data[[mean_rel_hum]] < 0 | data[[mean_rel_hum]] > 100, na.rm = TRUE)) stop("Mean Relative Humidity must be a percentage between 0 and 100.")
    df_8_means <- data %>%
      dplyr::group_by(!!! rlang::syms(c(link, year))) %>%
      dplyr::summarise(mean = sprintf("%6s", round(summary_mean(.data[[mean_rel_hum]], na.rm = TRUE), 0)), .groups = "keep")
    data[[mean_rel_hum]] <- ifelse(is.na(data[[mean_rel_hum]]), 
                                   "", round(data[[mean_rel_hum]], 1))
    data[[mean_rel_hum]] <- sprintf("%6s", data[[mean_rel_hum]])
    df_8 <- data %>% tidyr::pivot_wider(id_cols = tidyselect::all_of(c(link, year)),
                                        names_from = tidyselect::all_of(month),
                                        values_from = tidyselect::all_of(mean_rel_hum),
                                        values_fill = strrep(" ", 6))
  }
  
  month_header <- paste0("Year", " ", paste(c("Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", 
                                              "Aug", "Sep", "Oct", "Nov", "Dec", "ANNUAL"), 
                                            collapse = strrep(" ", 4)))
  for (i in seq_along(station_data[[station_link]])) {
    # filter data for single station
    curr_df <- data %>% dplyr::filter(.data[[link]] == station_data[[station_link]][i])
    # lines to be written to txt file
    lines <- c()
    # add header lines
    lines <- append(lines, paste0("WMO Number:", strrep(" ", 28),
                                  station_data[[wmo_number]][i]))
    lines <- append(lines, paste0("Station Name:", strrep(" ", 26),
                                  station_data[[station_name]][i]))
    lines <- append(lines, paste0("Country Name:", strrep(" ", 26),
                                  station_data[[country_name]][i]))
    lines <- append(lines, paste0("Latitude (DD MM SS N/S):", strrep(" ", 15),
                                  station_data[[latitude]][i]))
    lines <- append(lines, paste0("Longitude (DDD MM SS E/W):", strrep(" ", 13),
                                  station_data[[longitude]][i]))
    lines <- append(lines, paste0("Station Height (whole meters):", strrep(" ", 9),
                                  station_data[[height_station]][i]))
    lines <- append(lines, paste0("Barometer Height (meters, to tenths):", strrep(" ", 2),
                                  station_data[[height_barometer]][i]))
    lines <- append(lines, paste0("WIGOS Station Identifier (WSI):", strrep(" ", 8),
                                  station_data[[wigos_identifier]][i]))
    if (!missing(mean_station_pressure)) {
      lines <- append(lines, "")
      lines <- append(lines, "(2) Mean Station Pressure (precision to tenths of hPa)")
      lines <- append(lines, "")
      lines <- append(lines, month_header)
      lines <- append(lines, "")
      df_2_tmp <- df_2 %>% dplyr::filter(.data[[link]] == station_data[[station_link]][i])
      df_2_mean_tmp <- df_2_means
      vals <- apply(df_2_tmp, 1, function(r) paste0(r[2:14], collapse = " "))
      vals <- paste(vals, df_2_means %>% 
                      dplyr::filter(.data[[link]] == station_data[[station_link]][i]) %>%
                      dplyr::pull(mean))
      lines <- append(lines, vals)
    }
    if (!missing(mean_sea_level_pressure)) {
      lines <- append(lines, "")
      lines <- append(lines, "(3) Mean Sea Level Pressure (precision to tenths of hPa)")
      lines <- append(lines, "")
      lines <- append(lines, month_header)
      lines <- append(lines, "")
      df_3_tmp <- df_3 %>% dplyr::filter(.data[[link]] == station_data[[station_link]][i])
      df_3_mean_tmp <- df_3_means
      vals <- apply(df_3_tmp, 1, function(r) paste0(r[2:14], collapse = " "))
      vals <- paste(vals, df_3_means %>% 
                      dplyr::filter(.data[[link]] == station_data[[station_link]][i]) %>%
                      dplyr::pull(mean))
      lines <- append(lines, vals)
    }
    if (!missing(mean_temp)) {
      lines <- append(lines, "")
      lines <- append(lines, "(4) Mean Daily Air Temperature (precision to tenths of degrees Celsius)")
      lines <- append(lines, "")
      lines <- append(lines, month_header)
      lines <- append(lines, "")
      df_4_tmp <- df_4 %>% dplyr::filter(.data[[link]] == station_data[[station_link]][i])
      df_4_mean_tmp <- df_4_means
      vals <- apply(df_4_tmp, 1, function(r) paste0(r[2:14], collapse = " "))
      vals <- paste(vals, df_4_means %>% 
                      dplyr::filter(.data[[link]] == station_data[[station_link]][i]) %>%
                      dplyr::pull(mean))
      lines <- append(lines, vals)
    }
    if (!missing(total_precip)) {
      lines <- append(lines, "")
      lines <- append(lines, "(5) Total Precipitation (precision to tenths of mm)")
      lines <- append(lines, "")
      lines <- append(lines, month_header)
      lines <- append(lines, "")
      df_5_tmp <- df_5 %>% dplyr::filter(.data[[link]] == station_data[[station_link]][i])
      df_5_mean_tmp <- df_5_means
      vals <- apply(df_5_tmp, 1, function(r) paste0(r[2:14], collapse = " "))
      vals <- paste(vals, df_5_means %>% 
                      dplyr::filter(.data[[link]] == station_data[[station_link]][i]) %>%
                      dplyr::pull(mean))
      lines <- append(lines, vals)
    }
    if (!missing(mean_max_temp)) {
      lines <- append(lines, "")
      lines <- append(lines, "(6) Mean Daily Maximum Air Temperature (precision to tenths of degree Celsius)")
      lines <- append(lines, "")
      lines <- append(lines, month_header)
      lines <- append(lines, "")
      df_6_tmp <- df_6 %>% dplyr::filter(.data[[link]] == station_data[[station_link]][i])
      df_6_mean_tmp <- df_6_means
      vals <- apply(df_6_tmp, 1, function(r) paste0(r[2:14], collapse = " "))
      vals <- paste(vals, df_6_means %>% 
                      dplyr::filter(.data[[link]] == station_data[[station_link]][i]) %>%
                      dplyr::pull(mean))
      lines <- append(lines, vals)
    }
    if (!missing(mean_min_temp)) {
      lines <- append(lines, "")
      lines <- append(lines, "(7) Mean Daily Minimum Air Temperature (precision to tenths of degree Celsius)")
      lines <- append(lines, "")
      lines <- append(lines, month_header)
      lines <- append(lines, "")
      df_7_tmp <- df_7 %>% dplyr::filter(.data[[link]] == station_data[[station_link]][i])
      df_7_mean_tmp <- df_7_means
      vals <- apply(df_7_tmp, 1, function(r) paste0(r[2:14], collapse = " "))
      vals <- paste(vals, df_7_means %>% 
                     dplyr::filter(.data[[link]] == station_data[[station_link]][i]) %>%
                      dplyr::pull(mean))
      lines <- append(lines, vals)
    }
    if (!missing(mean_rel_hum)) {
      lines <- append(lines, "")
      lines <- append(lines, "(8) Mean of the Daily Relative Humidity (whole percent)")
      lines <- append(lines, "")
      lines <- append(lines, month_header)
      lines <- append(lines, "")
      df_8_tmp <- df_8 %>% dplyr::filter(.data[[link]] == station_data[[station_link]][i])
      df_8_mean_tmp <- df_8_means
      vals <- apply(df_8_tmp, 1, function(r) paste0(r[2:14], collapse = " "))
      vals <- paste(vals, df_8_means %>% 
                      dplyr::filter(.data[[link]] == station_data[[station_link]][i]) %>%
                      dplyr::pull(mean))
      lines <- append(lines, vals)
    }
    writeLines(lines, paste0(folder, "/", station_data[[station_link]][i], "-", format(Sys.time(), "%Y%m%d_%H%M%S"), ".txt"))
  }
  cat(i, "file(s) created at:", folder)
}

dd_to_dms <- function(x, lat) {
  if (lat) dir <- ifelse(x >= 0, "N", "S")
  else dir <- ifelse(x >= 0, "E", "W")
  x <- abs(x)
  d <- trunc(x)
  m <- trunc((x - d) * 60)
  s <- round((x - d - m/60) * 3600)
  return(paste(sprintf(ifelse(lat, "%02d", "%03d"), d), sprintf("%02d", m), sprintf("%02d", s), dir))
}

plot_mrl <- function(data, station_name, element_name, umin, umax, ncol = 1,
                     xlab = "Threshold", ylab = "Mean excess", fill = "red",
                     col = "black", rug = TRUE, addNexcesses = TRUE, textsize = 4) {
  if (!missing(station_name)) {
    plts <- list()
    station_col <- data[, station_name]
    stations <- unique(station_col)
    for (i in seq_along(stations)) {
      d <- data[station_col == stations[i], ]
      element_col <- d[, element_name]
      if (missing(umin)) {
        umin <- min(element_col, na.rm = TRUE)
      }
      if (missing(umax)) {
        umax <- max(element_col, na.rm = TRUE)
      }
      plts[[i]] <- texmex::mrl(na.exclude(element_col), umin = umin, umax = umax) %>%
        ggplot2::ggplot(xlab = xlab, ylab = ylab, main = stations[i], fill = fill,
          col = col, rug = rug, addNexcesses = addNexcesses, textsize = textsize
        )
    }
    patchwork::wrap_plots(plts, ncol = ncol)
  }
  else {
    element_col <- data[, element_name]
    if (missing(umin)) {
      umin <- min(element_col, na.rm = TRUE)
    }
    if (missing(umax)) {
      umax <- max(element_col, na.rm = TRUE)
    }
    texmex::mrl(data = na.exclude(element_col), umin = umin, umax = umax) %>%
      ggplot2::ggplot(xlab = xlab, ylab = ylab, fill = fill, col = col, rug = rug, 
                      addNexcesses = addNexcesses, textsize = textsize
      )
  }
}


### Constants
month_abb_english <- c("Jan","Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec")
month_name_english <- c("January", "February", "March", "April", "May", "June", "July", 
                        "August", "September", "October", "November", "December")

# factored out code for a multiple indices for a single station.
# Called by climdex().
# Not intended to be used externally.
climdex_single_station <- function(ci, freq = "annual", indices, year, month,
                                   spells.can.span.years = FALSE, gsl.mode = gsl.mode,
                                   threshold = 1) {
  stopifnot(freq %in% c("annual", "monthly"))
  if (freq == "monthly" && missing(month)) stop("month is required for freq = 'monthly'.")
  if (missing(indices)) stop("No indices specified.")
  for (i in seq_along(indices)) {
    vals <- switch(indices[i],
                   "fd" = climdex.pcic::climdex.fd(ci),
                   "su" = climdex.pcic::climdex.su(ci),
                   "id" = climdex.pcic::climdex.id(ci),
                   "tr" = climdex.pcic::climdex.tr(ci),
                   "wsdi" = climdex.pcic::climdex.wsdi(ci, spells.can.span.years = spells.can.span.years),
                   "csdi" = climdex.pcic::climdex.csdi(ci, spells.can.span.years = spells.can.span.years),
                   "gsl" = climdex.pcic::climdex.gsl(ci, gsl.mode = gsl.mode),
                   "txx" = climdex.pcic::climdex.txx(ci, freq = freq),
                   "txn" = climdex.pcic::climdex.txn(ci, freq = freq),
                   "tnx" = climdex.pcic::climdex.tnx(ci, freq = freq),
                   "tnn" = climdex.pcic::climdex.tnn(ci, freq = freq),
                   "tn10p" = climdex.pcic::climdex.tn10p(ci, freq = freq),
                   "tx10p" = climdex.pcic::climdex.tx10p(ci, freq = freq),
                   "tn90p" = climdex.pcic::climdex.tn90p(ci, freq = freq),
                   "tx90p" = climdex.pcic::climdex.tx90p(ci, freq = freq),
                   "dtr" = climdex.pcic::climdex.dtr(ci, freq = freq),
                   "rx1day" = climdex.pcic::climdex.rx1day(ci, freq = freq),
                   "rx5day" = climdex.pcic::climdex.rx5day(ci, freq = freq),
                   "sdii" = climdex.pcic::climdex.sdii(ci),
                   "r10mm" = climdex.pcic::climdex.r10mm(ci),
                   "r20mm" = climdex.pcic::climdex.r20mm(ci),
                   "rnnmm" = climdex.pcic::climdex.rnnmm(ci, threshold = threshold),
                   "cdd" = climdex.pcic::climdex.cdd(ci, spells.can.span.years = spells.can.span.years),
                   "cwd" = climdex.pcic::climdex.cwd(ci, spells.can.span.years = spells.can.span.years),
                   "r95ptot" = climdex.pcic::climdex.r95ptot(ci),
                   "r99ptot" = climdex.pcic::climdex.r99ptot(ci),
                   "prcptot" = climdex.pcic::climdex.prcptot(ci),
                   stop("index name ", indices[i], " not recognised.")
    )
    if (i == 1) {
      if (freq == "annual") {
        df_ind <- data.frame(names(vals), unname(vals))
        names(df_ind) <- c(year, indices[i])
      } else {
        df_ind <- data.frame(stringr::str_split_fixed(string = names(vals), n = 2, pattern = "-"), vals, row.names = NULL)
        names(df_ind) <- c(year, month, indices[i])
        df_ind[[month]] <- as.numeric(df_ind[[month]])
      }
    }
    else {
      df_ind[[indices[i]]] <- unname(vals)
    }
    if (indices[[i]] == "rnnmm") names(df_ind)[ncol(df_ind)] <- paste(indices[[i]], threshold, sep = "_")
  }
  return(df_ind)
}

climdex <- function(data, station, date, year, month, prec, tmax, tmin, indices, freq = "annual",
                    base.range = c(1961, 1990), n = 5, northern.hemisphere = TRUE,
                    quantiles = NULL, temp.qtiles = c(0.1, 0.9), 
                    prec.qtiles = c(0.95, 0.99), max.missing.days = c(annual = 15, monthly = 3), 
                    min.base.data.fraction.present = 0.1, spells.can.span.years = FALSE,
                    gsl.mode = "GSL", threshold = 1) {
  stopifnot(freq %in% c("annual", "monthly"))
  if (freq == "monthly" && missing(month)) stop("month is required for freq = 'monthly'.")
  
  # All indices can be calculated annually. Only some have monthly versions as well.
  year_only_indices <- c("fd", "su", "id", "tr", "wsdi", "csdi", "gsl", "sdii", "r10mm", 
                         "r20mm", "rnnmm", "cdd", "cwd", "r95ptot", "r99ptot", "prcptot")
  if (freq == "monthly" && any(indices %in% year_only_indices)) stop("Some indices selected are not available on a monthly frequency.")
  
  # climdex.pcic only calculates for a single station at a time so need to do individually then dplyr::bind_rows() together.
  if (!missing(station)) {
    stations <- unique(data[[station]])
    # If data[[station]] is a factor this ensure stations are in factor order (and drops levels that don't appear in the data).
    if (is.factor(data[[station]])) stations <- intersect(levels(data[[station]]), stations)
    df_list <- vector(mode = "list", length = length(stations))
    for (s in seq_along(stations)) {
      df_station <- data %>% dplyr::filter(.data[[station]] == stations[s])
      ci <- climdex.pcic::climdexInput.raw(prec = df_station[[prec]], tmax = df_station[[tmax]], tmin = df_station[[tmin]], 
                                           base.range = base.range, northern.hemisphere = northern.hemisphere, 
                                           temp.qtiles = temp.qtiles, prec.qtiles = prec.qtiles, 
                                           max.missing.days = max.missing.days,
                                           min.base.data.fraction.present = min.base.data.fraction.present,
                                           tmax.dates = PCICt::as.PCICt(x = as.character(df_station[[date]]), cal="gregorian"),
                                           tmin.dates = PCICt::as.PCICt(x = as.character(df_station[[date]]), cal="gregorian"),
                                           prec.dates = PCICt::as.PCICt(x = as.character(df_station[[date]]), cal="gregorian"))
      df_list[[stations[s]]] <- climdex_single_station(ci = ci, freq = freq, indices = indices, year = year, month = month,
                                                       spells.can.span.years = spells.can.span.years, gsl.mode = gsl.mode,
                                                       threshold = threshold)
    }
    df_out <- dplyr::bind_rows(df_list, .id = station)
  }
  else {
    ci <- climdex.pcic::climdexInput.raw(prec = data[[prec]], tmax = data[[tmax]], tmin = data[[tmin]], 
                                         base.range = c(1961, 1990), northern.hemisphere = TRUE, 
                                         temp.qtiles = c(0.1, 0.9), prec.qtiles = c(0.95, 0.99), 
                                         max.missing.days = c(annual = 15, monthly = 3), 
                                         min.base.data.fraction.present=0.1, 
                                         tmax.dates = PCICt::as.PCICt(x = as.character(data[[date]]), cal="gregorian"), 
                                         tmin.dates = PCICt::as.PCICt(x = as.character(data[[date]]), cal="gregorian"), 
                                         prec.dates = PCICt::as.PCICt(x = as.character(data[[date]]), cal="gregorian"))
    df_out <- climdex_single_station(ci = ci, freq = freq, indices = indices, year = year, month = month, gsl.mode = gsl.mode)
  }
  # Make the type of the year/month column(s) the same in the output as in data.
  if (!missing(station)) {
    # TODO This is done in several places and should be extracted as a function.
    if (is.numeric(data[[station]])) df_out[[station]] <- as.numeric(df_out[[station]])
    else if (is.factor(data[[station]])) df_out[[station]] <- make_factor(df_out[[station]])
    else if (is.character(data[[station]])) df_out[[station]] <- as.character(df_out[[station]])
    else warning("Cannot recognise the class of station column. Link between data frames may be unstable.")
  }
  if (is.numeric(data[[year]])) df_out[[year]] <- as.numeric(df_out[[year]])
  else if (is.factor(data[[year]])) df_out[[year]] <- make_factor(df_out[[year]])
  else if (is.character(data[[year]])) df_out[[year]] <- as.character(df_out[[year]])
  if (freq == "monthly") {
    if (is.numeric(data[[month]])) df_out[[month]] <- as.numeric(df_out[[month]])
    else if (is.factor(data[[month]])) {
      lvs <- levels(data[[month]])
      if (length(lvs) == 12) df_out[[month]] <- factor(df_out[[month]], labels = lvs, ordered = is.ordered(data[[month]]))
      else {
        warning("month is a factor but does not have 12 levels. Output may not link correctly to data.")
        df_out[[month]] <- make_factor(df_out[[month]])
      }
    }
    else if (is.character(data[[month]])) {
      mns <- unique(data[[month]])
      # Also check English names as month.abb and month.name are locale dependent.
      if (length(mns) == 12) {
        if (setequal(mns, month.abb)) df_out[[month]] <- month.abb[df_out[[month]]]
        else if (setequal(mns, month.name)) df_out[[month]] <- month.name[df_out[[month]]]
        else if (setequal(mns, month_name_english)) df_out[[month]] <- month_abb_english[df_out[[month]]]
        else if (setequal(mns, month_name_english)) df_out[[month]] <- month_name_english[df_out[[month]]]
        else if (setequal(mns, tolower(month_name_english))) df_out[[month]] <- tolower(month_abb_english)[df_out[[month]]]
        else if (setequal(mns, tolower(month_name_english))) df_out[[month]] <- tolower(month_name_english)[df_out[[month]]]
        else if (setequal(mns, toupper(month_name_english))) df_out[[month]] <- toupper(month_abb_english)[df_out[[month]]]
        else if (setequal(mns, toupper(month_name_english))) df_out[[month]] <- toupper(month_name_english)[df_out[[month]]]
        else warning("Cannot determine format of month column in data. Output may not link correctly to data.")
      } else {
        warning("month does not have 12 unique values. Output may not link correctly to data.")
        df_out[[month]] <- as.character(df_out[[month]])
      }
    }
  }
  return(df_out)
}

spei_input <- function(data, station, year, month, element) {
  if (missing(station)) id_cols <- c(year, month) else id_cols <- c(station, year, month)
  # SPEI package assumes data is ordered so must be sorted
  data_sort <- data %>% dplyr::arrange(!!! rlang::syms(id_cols))
  data <- data_sort
  # There should be a better way to check this.
  if (!all(data == data_sort, na.rm = TRUE)) stop("data must be sorted by (", paste(id_cols, collapse = ", "), ") for SPEI/SPI to be calculated correctly.")
  # Monthly data i.e. one value per month (per station) is required
  if (anyDuplicated(data %>% dplyr::select(!!! rlang::syms(id_cols)))) stop("Multiple values per month detected. SPEI/SPI requires monthly data.")
  if (!missing(station)) {
    for (s in unique(data[[station]])) {
      df <- data %>% dplyr::filter(.data[[station]] == s)
      dates_seq <- seq.Date(from = as.Date(paste(df[[year]][1], as.numeric(df[[month]][1]), 1), format = "%Y %m %d"),
                            to = as.Date(paste(tail(df[[year]], 1), tail(as.numeric(df[[month]]), 1), 1), format = "%Y %m %d"),
                            by = "1 month")
      if (length(dates_seq) != nrow(df)) stop("Less rows than expected. data has gaps for missing months in '", s, "'. SPEI/SPI requires no date gaps.")
    }
  } else {
    dates_seq <- seq.Date(from = as.Date(paste(data[[year]][1], as.numeric(data[[month]][1]), 1), format = "%Y %m %d"),
                          to = as.Date(paste(tail(data[[year]], 1), tail(as.numeric(data[[month]]), 1), 1), format = "%Y %m %d"),
                          by = "1 month")
    if (length(dates_seq) != nrow(data)) stop("Less rows than expected. data has gaps for missing months. SPEI/SPI requires no date gaps.")
  }
  cols <- c(id_cols, element)
  start <- c(data[[year]][1], data[[month]][1])
  # If multiple stations, needs to be in "wide" format for SPEI
  if (!missing(station)) {
    ts_data <- tidyr::pivot_wider(data, id_cols = tidyselect::all_of(c(year, month)), 
                                  names_from = tidyselect::all_of(station), values_from = tidyselect::all_of(element),
                                  values_fill = NA)
    ts_data <- ts_data %>% dplyr::arrange(!!! rlang::syms(c(year, month)))
    # Not sure how to do this using dplyr::select
    ts_data[id_cols] <- NULL
    ts_data <- ts(as.matrix(ts_data), frequency = 12, start = start)
  } else {
    ts_data <- ts(as.matrix(data[[element]]), frequency = 12, start = start)
  }
  ts_data
}

# This function extracts the SPEI/SPI column from an spei object x.
# It requires the original data in order to return a vector of the correct length by removing NA values introduced when unstacking.
# An alternative to this is to have a single wrapper SPEI/SPI function to handle this.
# The advantage of this method is that it doesn't hide the call to SPEI/SPI in R-Instat and is compatible with the existing dialog.
# The wrapper function may be a prefered long-term solution.
spei_output <- function(x, data, station, year, month) {
  if (! inherits(x, "spei")) stop("x must be an object of class 'spei'")
  vals <- x$fitted
  # If is.mts then multiple stations. Need to unstack and merge to ensure correct values obtained.
  if (is.mts(vals)) {
    df_spei <- as.data.frame(vals)
    # ind will be the year in fractions
    df_spei$ind <- zoo::index(x$fitted)
    # Stack all stations to get back into tidy format.
    df_spei <- tidyr::pivot_longer(df_spei, cols = 1:ncol(vals))
    # Integer part is year
    df_spei$yy <- trunc(df_spei$ind)
    # Remainder is fraction of month. Use round to ensure exact integers for merging.
    df_spei$mm <- ((df_spei$ind - df_spei$yy) * 12) + 1
    df_spei$mm <- round(df_spei$mm)
    if (!(is.numeric(data[[month]]) | is.factor(data[[month]]))) stop("month must be numeric or factor to ensure SPEI/SPI values are calculated correctly.")
    # If factor, this assumes levels are in correct order.
    data[[month]] <- as.numeric(data[[month]])
    by <- c("name", "yy", "mm")
    names(by) <- c(station, year, month)
    # Need to merge to know which NA values are true and which were introduced when unstacking.
    df_new <- dplyr::left_join(data, df_spei, by = by)
    col <- df_new$value
  } else {
    # If single station, then no extra missing values were introduced. Data just needs to be made into a vector.
    col <- as.vector(vals)
  }
  col

}

# This function has been adapted from extRemes::threshrange.plot().
# It has been adapted for use in R-Instat and uses ggplot2 graphical system rather than base plot().
threshold_Plot <- function(x, r, type = c("GP", "PP", "Exponential"), nint = 10,
                      alpha = 0.05, na.action = na.omit, xlb = "", main = NULL , verbose = FALSE,
                      ...) {
  type <- match.arg(type)
  x <- na.action(x)
  n <- length(x)
  lst_plots <- list()
  if (missing(r)) {
    r <- quantile(x, probs = c(0.75, 0.99))
  }
  u.i <- matrix(seq(from = r[1], to = r[2],length.out =  nint), ncol = 1)
  thfun <- function(u, x, type, a, verbose, ...) {
    fit <- try(extRemes::fevd(
      x = x, threshold = u, type = type, verbose = verbose,
      ...
    ), silent = verbose)
    if (verbose) {
      print(fit)
    }
    if (all(class(fit) != "try-error")) {
      if (!is.element(type, c("PP", "Exponential"))) {
        res <- try(distillery::ci(fit,
                      type = "parameter", alpha = a,
                      R = 100, tscale = TRUE, ...
        ), silent = verbose)
      } else {
        res <- try(distillery::ci(fit,
                      type = "parameter", alpha = a,
                      R = 100, ...
        ), silent = verbose)
      }
      if (verbose) {
        print(res)
      }
    }
    else {
      res <- fit
    }
    if (any(class(res) == "try-error")) {
      if (type == "PP") {
        res <- matrix(NA, 3, 3)
      } else if (type != "Exponential") {
        res <- matrix(NA, 2, 3)
      } else {
        res <- rep(NA, 3)
      }
    }
    return(res)
  }
  out <- apply(u.i, 1, thfun,
               x = x, type = type, a = alpha,
               verbose = verbose, ...
  )
  if (type == "PP") {
    rownames(out) <- c(
      "low.loc", "low.scale", "low.shape",
      "location", "scale", "shape", "up.loc", "up.scale",
      "up.shape"
    )
  } else if (type != "Exponential") {
    rownames(out) <- c(
      "low.t.scale", "low.shape", "t.scale",
      "shape", "up.t.scale", "up.shape"
    )
  } else {
    rownames(out) <- c("low.scale", "scale", "up.scale")
  }
  m1 <- deparse(match.call())
  if (type == "PP") {
    yl <- range(c(out[c("low.loc", "location", "up.loc"), ]), finite = TRUE)
    lst_plots[[1]] <- ggplot2::qplot(
      x = u.i, y = out["location", ], ylim = yl, xlab = xlb,
      ylab = "location", geom = c("line", "point"), main = main
    ) +
      ggplot2::geom_pointrange(mapping = ggplot2::aes(ymin = out["low.loc", ], ymax = out["up.loc", ]))
    yl <- range(c(out[c("low.scale", "scale", "up.scale"), ]), finite = TRUE)
    lst_plots[[2]] <- ggplot2::qplot(
      x = u.i, y = out["scale", ], ylim = yl, xlab = xlb, ylab = "scale",
      geom = c("point", "line")
    ) +
      ggplot2::geom_pointrange(mapping = ggplot2::aes(ymin = out["low.scale", ], ymax = out["up.scale", ]))
    yl <- range(c(out[c("low.shape", "shape", "up.shape"), ]), finite = TRUE)
    lst_plots[[3]] <- ggplot2::qplot(u.i, out["shape", ],
                                     ylim = yl, xlab = "Threshold",
                                     ylab = "shape", geom = c("point", "line")
    ) +
      ggplot2::geom_pointrange(mapping = ggplot2::aes(ymin = out["low.shape", ], ymax = out["up.shape", ]))
  }
  else if (type != "Exponential") {
    yl <- range(c(out[c("low.t.scale", "t.scale", "up.t.scale"), ]), finite = TRUE)
    lst_plots[[1]] <- ggplot2::qplot(
      x = u.i, y = out["t.scale", ], ylim = yl, xlab = xlb, ylab = "reparameterized scale",
      geom = c("point", "line"), main = main) +
      ggplot2::geom_pointrange(mapping = ggplot2::aes(ymin = out["low.t.scale", ], ymax = out["up.t.scale", ]))
    yl <- range(c(out[c("low.shape", "shape", "up.shape"), ]), finite = TRUE)
    lst_plots[[2]] <- ggplot2::qplot(
      x = u.i, y = out["shape", ], ylim = yl, xlab = "Threshold",
      ylab = "shape", geom = c("point", "line")
    ) +
      ggplot2::geom_pointrange(mapping = ggplot2::aes(ymin = out["low.shape", ], ymax = out["up.shape", ]))
  }
  else {
    yl <- range(c(out[c("low.scale", "scale", "up.scale"), 
    ]), finite = TRUE)
    return(ggplot2::qplot(
      x = u.i, y = out["scale", ], ylim = yl, xlab = "Threshold",
      ylab = "scale", geom = c("point", "line"), main = main
    ) +
      ggplot2::geom_pointrange(mapping = ggplot2::aes(ymin = out["low.scale", ], ymax = out["up.scale", ])))
  }
  patchwork::wrap_plots(lst_plots, ncol = 1) 
}

# This function produces multiple threshold plots for various stations at a time.
plot_multiple_threshold <- function(data, station_col_name, element_col_name, r, type = c("GP", "PP", "Exponential"), nint = 10,
                            alpha = 0.05, ncol = 1, xlb = "", main = NULL , verbose = FALSE,...) {
  if (!missing(station_col_name)) {
    plts <- list()
    station_col <- data[, station_col_name]
    stations <- unique(station_col)
    for (i in seq_along(stations)) {
      d <- data[station_col == stations[i], ]
      element_col <- d[, element_col_name]
      plts[[i]] <- threshold_Plot(x = element_col, main = stations[i], r = r, type = type, nint = nint, alpha = alpha, verbose = verbose)
    }
    patchwork::wrap_plots(plts, ncol = ncol)
  }
  else {
    element_col <- data[, element_col_name]
    threshold_Plot(x = element_col, r = r, type = type, nint = nint, alpha = alpha, verbose = verbose)
  }
}


plot_declustered <- function(data, station_col_name, element_col_name, threshold, r = NULL, xlab = NULL, ylab = NULL, ncol = 1, print_summary = FALSE) {
  if (!missing(station_col_name)) {
    plts <- list()
    station_col <- data[, station_col_name]
    stations <- unique(station_col)
    for (i in seq_along(stations)) {
      station <- stations[i]
      d <- data[station_col == station, ]
      obj <- texmex::declust(y = na.exclude(d[, element_col_name]), r = r, threshold = threshold)
      if (print_summary) {
        cat("Station:", paste0("", station, ""), "\n \n")
        cat("Threshold", obj$threshold, "\n")
        cat("Declustering using the intervals method, run length", obj$r, "\n")
        cat("Identified", obj$nClusters, "clusters.", "\n")
        cat("------------------------------------------------------", "\n \n")
      } else {
        plts[[i]] <- obj %>%
          ggplot2::ggplot(xlab = xlab, ylab = ylab, main = stations[i])
      }
    }
    if (!print_summary) {
      patchwork::wrap_plots(plts, ncol = ncol)
    }
  }
  else {
    obj <- texmex::declust(y = na.exclude(data[, element_col_name]), r = r, threshold = threshold)
    if (print_summary) {
      cat("Threshold", obj$threshold, "\n")
      cat("Declustering using the intervals method, run length", obj$r, "\n")
      cat("Identified", obj$nClusters, "clusters.", "\n")
    } else {
      obj %>% ggplot2::ggplot(xlab = xlab, ylab = ylab)
    }
  }
}

#This function creates a wrapper around functions from openair package
other_rose_plots <- function(data, type1_col_name, type2_col_name, date_col_name, wd_col_name, ws_col_name, main_method, single_pollutant, multiple_pollutant, ...) {
  type <- "default"
  if (!missing(type1_col_name) && !missing(type2_col_name)) {
    type <- c(type1_col_name, type2_col_name)
  }
  if (missing(type1_col_name) && !missing(type2_col_name)) {
    type <- type2_col_name
  }
  if (!missing(type1_col_name) && missing(type2_col_name)) {
    type <- type1_col_name
  }
  if (!main_method %in% c("percentile_rose", "polar_plot", "polar_annulus", "polar_cluster", "polar_frequency")) stop("Method must be either percentile_rose, polar_plot, polar_annulus, polar_cluster or polar_frequency.")
  if (missing(data)) stop("Data is missing with no default.")
  col_names <- colnames(data)
  fun_col_names <- c(date_col_name, wd_col_name)
  if (!all(fun_col_names %in% col_names)) stop(paste(fun_col_names[!fun_col_names %in% col_names], ","), " column(s) missing in the dataframe.")
  if (!"date" %in% col_names) data <- dplyr::rename(data, date = !!date_col_name)
  if (!"wd" %in% col_names) data <- dplyr::rename(data, wd = !!wd_col_name)
  if (main_method == "percentile_rose") {
    if (!"ws" %in% col_names) data <- dplyr::rename(data, ws = !!ws_col_name)
    openair::percentileRose(mydata = data, type = type, pollutant = multiple_pollutant, ...)
  } else if (main_method == "polar_plot") {
    openair::polarPlot(mydata = data, type = type, pollutant = multiple_pollutant,  ...)
  } else if (main_method == "polar_annulus") {
    if (!"ws" %in% col_names) data <- dplyr::rename(data, ws = !!ws_col_name)
    openair::polarAnnulus(mydata = data, type = type, pollutant = multiple_pollutant,  ...)
  } else if (main_method == "polar_cluster") {
    openair::polarCluster(mydata = data, type = type, pollutant = single_pollutant, ...)
  } else if (main_method == "polar_frequency") {
    if (!"ws" %in% col_names) data <- dplyr::rename(data, ws = !!ws_col_name)
    openair::polarFreq(mydata = data, type = type, pollutant = single_pollutant, ...)
  }
}

#This function creates a wrapper around windRose and pollutionRose functions from openair package
wind_pollution_rose <- function(mydata, date_name, pollutant, type1_col_name, type2_col_name, ...) {
  type <-  "default"
  if (!missing(type1_col_name) && !missing(type2_col_name)) {
    type <- c(type1_col_name, type2_col_name)
  }
  if (missing(type1_col_name) && !missing(type2_col_name)) {
    type <- type2_col_name
  }
  if (!missing(type1_col_name) && missing(type2_col_name)) {
    type <- type1_col_name
  }
  if (!("date" %in% colnames(mydata))) {
    mydata <- dplyr::rename(mydata, date = !!date_name)
  }
  if (missing(pollutant)) {
    openair::windRose(mydata = mydata, type = type, ...)
  } else {
    openair::pollutionRose(mydata = mydata, type = type, pollutant, ...)
  }
}

n_non_numeric <- function(x) {
  x <- as.character(x)
  sum(is.na(x) != is.na(suppressWarnings(as.numeric(x))))
}


# Returns a three-letter string representing a specific quarter in a year (e.g. "JFM", "AMJ" etc.). 
get_quarter_label <-   function(quarter, start_month){
  if (!start_month %in% 1:12) stop(start_month, " is an invalid start month, must be in range of 1:12")
  if (!all(quarter %in% 1:4)) stop(quarter, " is an invalid quarter, must be in range of 1:4")
  mabb <- rep(substr(month.abb, 1, 1), times = 2)[start_month:(11 + start_month)]
  qtr <- sapply(quarter, function(x){start_pos <- 1 + ((x-1) * 3)
  paste(mabb[start_pos:(start_pos+2)], collapse = "")})
  return(factor(x = qtr, levels = unique(qtr)))
}

# for issue 8342 - adding in a count of the number of elements that have missing values by period (and station)
cumulative_inventory <- function(data, station = NULL, from, to){
  if (is.null(station)){
    data <- data %>%
      dplyr::group_by(.data[[from]], .data[[to]]) %>%
      dplyr::mutate(cum=dplyr::n())
    data <- data %>%
      dplyr::group_by(.data[[from]]) %>%
      dplyr::mutate(cum1 = dplyr::n()) %>% 
      dplyr::mutate(cum1 = ifelse(cum == cum1, # are they all in the same period?
                                  yes = cum,  
                                  no = ifelse(cum == max(cum),
                                              cum,
                                              max(cum) + 0.5)))
  } else {
      data <- data %>%
        dplyr::group_by(.data[[station]], .data[[from]], .data[[to]]) %>%
        dplyr::mutate(cum=dplyr::n())
      data <- data %>%
        dplyr::group_by(.data[[station]], .data[[from]]) %>%
        dplyr::mutate(cum1 = dplyr::n()) %>% 
        dplyr::mutate(cum1 = ifelse(cum == cum1, # are they all in the same period?
                                    yes = cum,  
                                    no = ifelse(cum == max(cum),
                                                cum,
                                                max(cum) + 0.5)))
    }
    return(data)
}

WB_evaporation <- function(water_balance, frac, capacity, evaporation_value, rain){
  if (water_balance >= frac*capacity){
    evaporation <- evaporation_value
  } else {
    if (rain == 0){
      evaporation <- evaporation_value * ((water_balance)/(frac*capacity))
    } else {
      if (water_balance < frac*capacity){
        if (rain > evaporation_value){
          evaporation <- evaporation_value
        } else {
          evaporation <- evaporation_value * ((water_balance)/(frac*capacity))
          evaporation <- evaporation + ((evaporation_value - evaporation)*(rain/evaporation_value))
        }
      } else {
        evaporation <- evaporation_value
        }
    }
  }
  return(evaporation)
}

write_weather_data <- function(year, month, day, rain, mn_tmp, mx_tmp, missing_code, output_file) {
  # Create a data frame with the provided inputs
  weather_data <- data.frame(year = year,
                             month = month,
                             day = day,
                             rain = rain,
                             mn_tmp = mn_tmp,
                             mx_tmp = mx_tmp)
  
  # Replace missing values with the specified code
  weather_data[is.na(weather_data)] <- missing_code
  
  # Write the data frame to a text file
  write.table(weather_data, file = output_file, sep = "\t", row.names = FALSE, col.names = TRUE, quote = FALSE)
  
  cat("Weather data has been written to", output_file, "\n")
}

prepare_walter_lieth <- function(data, month, tm_min, ta_min){
  dat_long_int <- NULL
  for (j in seq(nrow(data) - 1)) {
    intres <- NULL
     for (i in seq_len(ncol(data))) {
      if (is.character(data[j, i]) | is.factor(data[j, i])) {
        val <- as.data.frame(data[j, i])
      }
      else {
        interpol <- approx(x = data[c(j, j + 1), "indrow"],
                           y = data[c(j, j + 1), i],
                           n = 50)
        val <- as.data.frame(interpol$y)
      }
      names(val) <- names(data)[i]
      intres <- dplyr::bind_cols(intres, val)
    }
    dat_long_int <- dplyr::bind_rows(dat_long_int, intres)
  }
  dat_long_int$interpolate <- TRUE
  dat_long_int[[month]] <- ""
  data$interpolate <- FALSE
  dat_long_int <- dat_long_int[!dat_long_int$indrow %in% data$indrow, ]
  dat_long_end <- dplyr::bind_rows(data, dat_long_int)
  dat_long_end <- dat_long_end[order(dat_long_end$indrow), ]
  dat_long_end <- dat_long_end[dat_long_end$indrow >= 0 & dat_long_end$indrow <= 12, ]
  dat_long_end <- tibble::as_tibble(dat_long_end)
  
  getpolymax <- function(x, y, y_lim) {
    initpoly <- FALSE
    yres <- NULL
     xres <- NULL
    for (i in seq_len(length(y))) {
      lastobs <- i == length(x)
      if (y[i] > y_lim[i]) {
        if (isFALSE(initpoly)) {
          xres <- c(xres, x[i])
          yres <- c(yres, y_lim[i])
          initpoly <- TRUE
        }
        xres <- c(xres, x[i])
        yres <- c(yres, y[i])
        if (lastobs) {
          xres <- c(xres, x[i], NA)
          yres <- c(yres, y_lim[i], NA)
        }
      }
      else {
        if (initpoly) {
          xres <- c(xres, x[i - 1], NA)
          yres <- c(yres, y_lim[i - 1], NA)
          initpoly <- FALSE
        }
      }
    }
    poly <- tibble::tibble(x = xres, y = yres)
    return(poly)
  }
  getlines <- function(x, y, y_lim) {
    yres <- NULL
    xres <- NULL
    ylim_res <- NULL
    for (i in seq_len(length(y))) {
      if (y[i] > y_lim[i]) {
        xres <- c(xres, x[i])
        yres <- c(yres, y[i])
        ylim_res <- c(ylim_res, y_lim[i])
      }
    }
    line <- tibble::tibble(x = xres, y = yres, ylim_res = ylim_res)
    return(line)
  }
  prep_max_poly <- getpolymax(x = dat_long_end$indrow, y = pmax(dat_long_end$pm_reesc, 
                                                                50), y_lim = rep(50, length(dat_long_end$indrow)))
  tm_max_line <- getlines(x = dat_long_end$indrow, y = dat_long_end$tm, 
                          y_lim = dat_long_end$pm_reesc)
  pm_max_line <- getlines(x = dat_long_end$indrow, y = pmin(dat_long_end$pm_reesc, 
                                                            50), y_lim = dat_long_end$tm)
  dat_real <- dat_long_end[dat_long_end$interpolate == FALSE, 
                           c("indrow", ta_min)]
  x <- NULL
  y <- NULL
  for (i in seq_len(nrow(dat_real))) {
    if (dat_real[i, ][[ta_min]] < 0) {
      x <- c(x, NA, rep(dat_real[i, ]$indrow - 0.5, 2), 
             rep(dat_real[i, ]$indrow + 0.5, 2), NA)
      y <- c(y, NA, -3, 0, 0, -3, NA)
       }
    else {
      x <- c(x, NA)
      y <- c(y, NA)
    }
  }
  probfreeze <- tibble::tibble(x = x, y = y)
  rm(dat_real)
  dat_real <- dat_long_end[dat_long_end$interpolate == FALSE, 
                           c("indrow", tm_min)]
  x <- NULL
  y <- NULL
  for (i in seq_len(nrow(dat_real))) {
    if (dat_real[i, ][[tm_min]] < 0) {
      x <- c(x, NA, rep(dat_real[i, ]$indrow - 0.5, 2), 
             rep(dat_real[i, ]$indrow + 0.5, 2), NA)
      y <- c(y, NA, -3, 0, 0, -3, NA)
    }
    else {
      x <- c(x, NA)
      y <- c(y, NA)
    }
  }
  surefreeze <- tibble::tibble(x = x, y = y)
  return_list <- list(dat_long_end,
                      tm_max_line,
                      pm_max_line,
                      prep_max_poly,
                      probfreeze,
                      surefreeze)
  names(return_list) <- c("dat_long_end", "tm_max_line", "pm_max_line",
                          "prep_max_poly", "prob_freeze", "surefreeze")
  return(return_list)
}
ggwalter_lieth <- function (data, month, station = NULL, p_mes, tm_max, tm_min, ta_min, station_name = "", 
                            alt = NA, per = NA, pcol = "#002F70", 
                            tcol = "#ff0000", pfcol = "#9BAEE2", sfcol = "#3C6FC4", 
                            shem = FALSE, p3line = FALSE, ...) 
                            {

  # Preprocess data with vectorised operations
  data <- data %>%
    dplyr::mutate(tm = (.data[[tm_max]] + .data[[tm_min]]) / 2,
                  pm_reesc = dplyr::if_else(.data[[p_mes]] < 100, .data[[p_mes]] * 0.5, .data[[p_mes]] * 0.05 + 45),
                  p3line = .data[[p_mes]] / 3) %>%
    dplyr::mutate(across(.data[[month]], ~ forcats::fct_expand(.data[[month]], ""))) %>%
    dplyr::arrange(.data[[month]])
    # do this for each station, if we have a station
  if (!is.null(station)){
    data <- data %>% group_by(!!sym(station))
  }
  data <- data %>%
    group_modify(~{
      # Add dummy rows at the beginning and end for each group
      .x <- bind_rows(.x[nrow(.x), , drop = FALSE], .x, .x[1, , drop = FALSE])
      # Clear month value for the dummy rows
      .x[c(1, nrow(.x)), which(names(.x) == data[[month]])] <- ""
      # Add an index column for plotting or further transformations
      .x <- cbind(indrow = seq(-0.5, 12.5, 1), .x)
      .x
    })
  
  if (!is.null(station)){
    data <- data %>% ungroup()
  }
  data <- data.frame(data)

   # split by station
  if (is.null(station)){
    data_list <- prepare_walter_lieth(data, month, tm_min, ta_min)
    # data things
    dat_long_end <- data_list$dat_long_end
    tm_max_line <- data_list$tm_max_line
    pm_max_line <- data_list$pm_max_line
    prep_max_poly <- data_list$prep_max_poly
    probfreeze <- data_list$prob_freeze
    surefreeze <- data_list$surefreeze
  } else {
    results <-
      map(.x = unique(data[[station]]),
          .f = ~{filtered_data <- data %>% filter(!!sym(station) == .x)
          prepare_walter_lieth(filtered_data, month, tm_min, ta_min)})
    # Function to bind rows for a specific sub-element across all main elements
    n <- length(results)
    m <- length(results[[1]])
     station_name <- unique(data[[station]])
    binds <- NULL
    combined <- NULL
    for (j in 1:m){
      for (i in 1:n) { # for each station data set
        binds[[i]] <- results[[i]][[j]] %>% mutate(!!sym(station) := station_name[i])
      }
      combined[[j]] <- do.call(rbind, binds) # Combine all the sub-elements row-wise
    }
    # data things
    dat_long_end <- combined[[1]]
    tm_max_line <- combined[[2]]
    pm_max_line <- combined[[3]]
    prep_max_poly <- combined[[4]]
    probfreeze <- combined[[5]]
    surefreeze <- combined[[6]]
  }
  
  # data frame pretty things ------------------------------------------------------
  ticks <- data.frame(x = seq(0, 12), ymin = -3, ymax = 0)
  month_breaks <- dat_long_end[dat_long_end[[month]] != "", ]$indrow
  month_labs <- dat_long_end[dat_long_end[[month]] != "", ][[month]]
  
  ymax <- max(60, 10 * floor(max(dat_long_end$pm_reesc)/10) + 10)
  ymin <- min(-3, min(dat_long_end$tm))
  range_tm <- seq(0, ymax, 10)
  if (ymin < -3) {
    ymin <- floor(ymin/10) * 10
    range_tm <- seq(ymin, ymax, 10)
  }
  templabs <- paste0(range_tm)
  templabs[range_tm > 50] <- ""
  range_prec <- range_tm * 2
  range_prec[range_tm > 50] <- range_tm[range_tm > 50] * 20 - 900
  preclabs <- paste0(range_prec)
  preclabs[range_tm < 0] <- ""
  
  wandlplot <- ggplot2::ggplot() + ggplot2::geom_line(data = dat_long_end, 
                                                      aes(x = .data$indrow, y = .data$pm_reesc), color = pcol) + 
    ggplot2::geom_line(data = dat_long_end, aes(x = .data$indrow, 
                                                y = .data$tm), color = tcol)
  if (nrow(tm_max_line > 0)) {
    wandlplot <- wandlplot + ggplot2::geom_segment(aes(x = .data$x, 
                                                       y = .data$ylim_res, xend = .data$x, yend = .data$y), 
                                                   data = tm_max_line, color = tcol, alpha = 0.2)
  }
  if (nrow(pm_max_line > 0)) {
    wandlplot <- wandlplot + ggplot2::geom_segment(aes(x = .data$x, 
                                                       y = .data$ylim_res, xend = .data$x, yend = .data$y), 
                                                   data = pm_max_line, color = pcol, alpha = 0.2)
  }
  if (p3line) {
    wandlplot <- wandlplot + ggplot2::geom_line(data = dat_long_end, 
                                                aes(x = .data$indrow, y = .data$p3line), color = pcol)
  }
  if (max(dat_long_end$pm_reesc) > 50) {
    wandlplot <- wandlplot + ggplot2::geom_polygon(data = prep_max_poly, aes(x, y),
                                                   fill = pcol)
  }
  if (min(dat_long_end[[ta_min]]) < 0) {
    wandlplot <- wandlplot + ggplot2::geom_polygon(data = probfreeze, aes(x = x, y = y),
                                                   fill = pfcol, colour = "black")
  }
   if (min(dat_long_end[[tm_min]]) < 0) {
    wandlplot <- wandlplot + geom_polygon(data = surefreeze, aes(x = x, y = y),
                                          fill = sfcol, colour = "black")
  }
  wandlplot <- wandlplot + geom_hline(yintercept = c(0, 50), 
                                      linewidth = 0.5) +
    geom_segment(data = ticks, aes(x = x, xend = x, y = ymin, yend = ymax)) +
    scale_x_continuous(breaks = month_breaks, name = "", labels = month_labs, expand = c(0, 0)) + 
    scale_y_continuous("C", limits = c(ymin, ymax), labels = templabs, 
     breaks = range_tm, sec.axis = dup_axis(name = "mm", labels = preclabs))
  wandlplot <- wandlplot +
    ggplot2::theme_classic() +
    ggplot2::theme(axis.line.x.bottom = element_blank(), 
                   axis.title.y.left = element_text(angle = 0, 
                                                    vjust = 0.9, size = 10, colour = tcol,
                                                    margin = unit(rep(10, 4), "pt")),
                   axis.text.x.bottom = element_text(size = 10), 
                   axis.text.y.left = element_text(colour = tcol, size = 10), 
                   axis.title.y.right = element_text(angle = 0, vjust = 0.9, 
                                                     size = 10, colour = pcol,
                                                     margin = unit(rep(10, 4), "pt")),
                   axis.text.y.right = element_text(colour = pcol, size = 10))
  
  if (!is.null(station)){
    wandlplot <- wandlplot + facet_wrap(station)
  }
  
  return(wandlplot)
}

set_library_paths <- function(library_path) {
  # Update the library paths
  .libPaths(c(library_path, .libPaths()))
  
  # Check if there are more than 2 library paths
  if (length(.libPaths()) > 2) {
    # Get the current library paths
    current_paths <- .libPaths()
    
    # Select valid indices (1 and 3) only if they exist
    valid_indices <- c(1, 3)[c(1, 3) <= length(current_paths)]
    
    # Set the library paths to the valid ones
    .libPaths(current_paths[valid_indices])
  }
}
