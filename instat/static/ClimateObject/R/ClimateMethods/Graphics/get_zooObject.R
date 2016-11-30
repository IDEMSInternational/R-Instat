climate$methods(get_var_labels = function(){
  # GET VARIABLE TO PLOT
  # Rain
  var_label=list()
  if (data_obj$is_present(rain_label)){
    var_label[[rain_label]]=rain_label
  }
  # Minimum Temperature
  if (data_obj$is_present(temp_min_label)) {
    var_label[[temp_min_label]]=temp_min_label
  }
  # Maximum Temperature
  if (data_obj$is_present(temp_max_label)){
    var_label[[temp_max_label]]=temp_max_label
  }
  # Observed Temperature
  if (data_obj$is_present(temp_air_label)){
    var_label[[temp_air_label]]=temp_air_label
  }
  # Wind speed 
  if (data_obj$is_present(wind_speed_label)){
    var_label[[wind_speed_label]]=wind_speed_label
  }
  # Wind direction
  if (data_obj$is_present(wind_direction_label)) {
    var_label[[wind_direction_label]]=wind_direction_label
  }
  return(var_label)
})

##############################################################################
# GET ZOO OBJECT 
#' @title Create a zoo object for plotting
#' @name get_zooObj
#' @author Rafael Posada August, 2015 (SASSCAL/DWD)
#' @description It allows converting the data_objs into a zooObject, which 
#' is necessary to correcly plot timeseries
#' @param var_label character string. Name of the element that is going to be 
#' plotted 
#'  
#' @return It returns zooObject
#' 
climate$methods(get_zooObj = function(var_label){
  #######################################################################
  library(zoo)
  
  # CLIMATE DATA OBJS
  climate_data_objs = get_climate_data_objects(data_list)
  
  for(data_obj in climate_data_objs) {
    data_name = data_obj$get_meta(data_name_label)
    
    ######################################################################
    # GET COMMON VARIABLES
    # Name of station_id column
    station_id_col = data_obj$getvname(station_label)
    # Get date_time_period ("daily","subdaily",etc.)
    data_time_period = data_obj$data_time_period
    # Get the data frame for analysis
    curr_data_list = data_obj$get_data_for_analysis(data_list)
    
    # loop for computing 
    for( curr_data in curr_data_list ) {
      if(data_time_period!="subdaily"){
        date_col = data_obj$getvname(date_label)
      }else{
        date_col = data_obj$getvname(date_time_label)
      }
      
      # Begin and end dates
      first.date <- curr_data[[date_col]][1]
      last.date <- curr_data[[date_col]][nrow(curr_data)]
      tperiod <- paste(first.date,"-",last.date, sep="")
      
      # Station id
      station_ids <- unique(curr_data[[station_id_col]])
      station_id <- station_ids[which(!is.na(station_ids))]
      
      output_new <- list()
      # Get the data of each variable
      #for (i in var_label){
      i <- var_label
      # Get the variable 
      var_col = data_obj$getvname(as.character(i))
      y <- curr_data[[var_col]]
      x <- curr_data[[date_col]]
      
      # Make sure to use always the same time format:
      x <- as.POSIXct(as.character(x),tz="UTC")
      # Get the time period stamp of the dataset
      time_diff <- diff(x)
      # Count cases with the same time stamp
      time_stamp <- table(diff(x))
      
      # a) get the time difference units (minutes, hours, etc.)
      time_units <- units(time_diff)
      
      id <- which(time_stamp==max(time_stamp))
      time_interval <- names(time_stamp)[id]
      
      data_time_interval <- paste(time_interval,time_units)
      
      full <- seq.POSIXt(x[1],x[length(x)],by=data_time_interval)
      
      all.dates.frame <- data.frame(list(x=full))
      
      
      merged.data <- merge(all.dates.frame,data.frame(x,y),all=T)
      
      # Split the dataset if the time_interval is higher than 1 (meaning
      # that the timeseries is not a continuum)
      if (data_time_period=="subdaily"){
        if (as.numeric(time_interval) > 1){
          times <- sort(unique(strftime(merged.data$x,format="%H:%M:%S",tz="UTC")))
          dates <- unique(strftime(merged.data$x,format="%Y-%m-%d",tz="UTC"))
          # id00 <- unique(times)
          
          full.new <- as.Date(seq.POSIXt(x[1],x[length(x)],by="1 day"),format = "%Y-%m-%d")
          all.dates.frame.new <- data.frame(list(x=full.new))
          merged.data.new <- data.frame(x=all.dates.frame.new$x)
          tmp1 <- merged.data
          for (i0 in c(1:length(times))){
            print(times[i0])
            data00 <- subset(tmp1,strftime(tmp1$x,format="%H:%M:%S",tz="UTC")==times[i0])
            data00$x <- as.Date(data00$x,"%Y-%m-%d",tz="UTC")
            colnames(data00)[2] <- times[i0]
            tmp2 <- merge(all.dates.frame.new,data00,all=T)
            merged.data.new <- cbind(merged.data.new,tmp2[,2])
            colnames(merged.data.new)[i0+1] <- times[i0]
          }
          merged.data <- merged.data.new
        }
      }
      z5 <- with(merged.data,zoo(merged.data[,c(2:ncol(merged.data))],
                                 order.by=merged.data$x))
      
    }
  }
  return(z5)
})