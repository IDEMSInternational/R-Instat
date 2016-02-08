##############################################################################
# HISTOGRAM - SHINY
#' @title Get Histograms from a climObject through shiny
#' @name histogram_shiny
#' @author Rafael Posada, August 2015 (SASSCAL/DWD)
#' @description 
#' Allows plotting the data in a histogram plot. It does not require 
#' any input since it takes all the information from the Climate Object
#'  
#' @return Returns a list of plots. This list can be then used by 
#' \code{graphics_frontend_shiny} to plot the histograms into the shiny 
#' interface.
#' 
#' 
climate$methods(histogram_shiny = function(){
  ############################################################################
  # Required packages
  library(ggvis)
  library(zoo)
  ###########################################################################
  # Create empty list where the plots will be saved
  ptm <- proc.time()
  print("Creating histograms...")
  
  ###########################################################################
  # Get the climate data Objects
  data_list <- list()
  climate_data_objs <- .self$get_climate_data_objects(data_list)
  # Names of each data_object
  data_objs_names <- names(climate_data_objs)
  k <- vector("list",length(data_objs_names))
  names(k) <- data_objs_names
  
  for(i1 in c(1:length(climate_data_objs))) {
    data_obj <- climate_data_objs[[i1]]
    
    #########################################################################
    # GET COMMON VARIABLES
    # Name of station_id column
    station_id_col <- data_obj$getvname(station_label)
    # Get date_time_period ("daily","subdaily",etc.)
    data_time_period <- data_obj$data_time_period
    # Get var labels
    var_labels <- data_obj$get_var_labels()
    
    #########################################################################
    # Get the right date label for each data_obj
    if(data_time_period!="subdaily"){
      date_col <- data_obj$getvname(date_label)
    }else{
      date_col <- data_obj$getvname(date_time_label)
    }
    
    #########################################################################
    # Get current data 
    curr_data_list <- data_obj$get_data_for_analysis(data_list)
    # Names of curr_data in k
    curr_data_names <- paste0("curr_data",c(1:length(curr_data_list)))
    k[[i1]] <- vector("list",length(curr_data_names))
    names(k[[i1]]) <- curr_data_names
    
    #########################################################################
    # Get the station id for each curr_data available
    for(i2 in 1:length(curr_data_list)){
      curr_data <- curr_data_list[[i2]]
      
      # Station id
      station_ids <- as.character(unique(curr_data[[station_id_col]]))
      station_id <- station_ids[which(!is.na(station_ids))]
      
      # Names for each station_id
      k[[i1]][[i2]] <- vector("list",length(station_id))
      names(k[[i1]][[i2]]) <- as.character(station_id)
      
      for (i3 in 1:length(station_id)){
        # Names for each variable
        k[[i1]][[i2]][[i3]] <- vector("list",length(var_labels))
        names(k[[i1]][[i2]][[i3]]) <- var_labels
        
        id3 <- which(curr_data[[station_id_col]]==station_id[i3])
        curr_data_new <- curr_data[id3,]
        
        # Begin and end dates
        first.date <- curr_data[[date_col]][id3[1]]
        last.date <- curr_data[[date_col]][id3[length(id3)]]
        tperiod <- paste(first.date,"-",last.date, sep="")
        
        ######################################################################
        # Get the data of each variable
        for (i4 in c(1:length(var_labels))){
          var_col <- data_obj$getvname(as.character(var_labels[i4]))
          # Find the dates when the data are available
          id4 <-  which(!is.na(curr_data_new[,var_col]))
          # Begin and end dates
          first.date <- curr_data_new[[date_col]][id4[1]]
          last.date <- curr_data_new[[date_col]][id4[length(id4)]]
          tperiod <- paste(first.date,"-",last.date, sep="")
          
          # Title
          tit <- paste0("Station ID: ",station_id," || ",
                        names(climate_data_objs)[i1]," || ",
                        first.date," to ",last.date)
          
          y <- curr_data[[var_col]]
          x <- curr_data[[date_col]]

#           if(is.factor(x)){
#             x<-format(strptime(
#               as.character(x),"%d.%m.%Y %H"),
#               "%Y-%m-%d %H:%M:%S")
#           }
          #################################################################
          # Create "zooObject"
          x <- as.POSIXct(x,format = data_obj$date_format,tz = "UTC")
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
            if ((tolower(data_time_interval) != "1 h") && 
                (tolower(data_time_interval) != "60 min") &&
                (tolower(data_time_interval) != "3600 secs")){
              #if (as.numeric(time_interval) > 1){
              times <- sort(unique(strftime(merged.data$x,format="%H:%M:%S",
                                            tz="UTC")))
              dates <- unique(strftime(merged.data$x,format="%Y-%m-%d",
                                       tz="UTC"))
              
              full.new <- as.Date(seq.POSIXt(x[1],x[length(x)],by="1 day"),
                                  format = "%Y-%m-%d")
              all.dates.frame.new <- data.frame(list(x=full.new))
              merged.data.new <- data.frame(x=all.dates.frame.new$x)
              tmp1 <- merged.data
              for (i0 in c(1:length(times))){
                data00 <- subset(tmp1,
                                 strftime(tmp1$x,
                                          format="%H:%M:%S",tz="UTC")==times[i0])
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
          
          ######################################################################
          # z5 <- .self$get_zooObj(x,y,data_time_period)
          ######################################################################

          n <- length(z5[1,])
          
          k[[i1]][[i2]][[i3]][[i4]] <- vector("list",n)
          names(k[[i1]][[i2]][[i3]][[i4]]) <- colnames(z5)
          
          #####################################################################
          # Define the options of the plot (e.g. color)
          if (var_labels[[i4]]=="rain"){
            colplot <- "blue"
          }else{
            colplot <- "red"
          }
          
          #####################################################################
          # Create plots
          for (i5 in 1:n){
            tit <- paste0("Station ID: ",station_id," || ",
                          names(climate_data_objs)[i1]," || ",
                          first.date," to ",last.date)
            
            data.hist.prev <- coredata(z5[,i5])
            data.hist <- data.hist.prev[!is.na(data.hist.prev)]
            mtc <-  as.data.frame(data.hist)
            k[[i1]][[i2]][[i3]][[i4]][[i5]] <- mtc %>% 
              ggvis(~data.hist,fill:=colplot) %>%
              add_axis("x",title_offset = 50,
                       title=as.character(var_labels[i4]),
                       properties = axis_props(
                         axis = list(stroke = "white"),
                         title = list(fontSize = 16),
                         labels = list(fontSize = 16)
                       )) %>%
              .self$add_title(x_lab = "", title=tit) %>%
              add_axis("y",title_offset = 70,
                       properties = axis_props(
                         axis = list(stroke = "white"),
                         title = list(fontSize = 16),
                         labels = list(fontSize = 16)
                       )) %>%
              set_options(renderer = "canvas")
          }
        }
      }
    }
  }
  print("Histograms created!")
  proc.time() - ptm
  return(k)
})
##############################################################################
# Funtion to add a title to the "histogram
climate$methods(add_title=function(vis, ..., x_lab = "X units", 
                                   title = "Plot Title") 
{
  add_axis(vis, "x", values= "",ticks = 0,title = x_lab,properties=axis_props(labels=list(fontSize=0))) %>%
    add_axis("x", orient = "top", ticks = 0, title = title,values="",
             properties = axis_props(
               axis = list(stroke = "white"),
               title = list(fontSize = 16),
               labels = list(fontSize = 0)
             ), ...)
})
