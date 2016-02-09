#############################################################################
# TIMESERIES -SHINY
#' @title Get Timeseries from a climObject through shiny
#' @name timeseries_shiny
#' @author Rafael Posada, August 2015 (SASSCAL/DWD)
#' @description 
#' Allows plotting the data in a timeseries plot. It does not require 
#' any input since it takes all the information from the Climate Object
#'  
#' @return Returns a list of plots. This list can be then used by 
#' \code{graphics_frontend_shiny} to plot the timeseries into the shiny 
#' interface.
#' 
climate$methods(timeseries_shiny = function(){
  ###########################################################################
  # Required packages
  library(dygraphs)
  library(zoo)
  ###########################################################################
  # Create empty list where the plots will be saved 
  ptm <- proc.time()
  print("Creating timeseries...")
  
  ###########################################################################
  # Get the climate data Objects
  data_list <- list()
  climate_data_objs = .self$get_climate_data_objects(data_list)
  # Names of each data_object
  data_objs_names <- names(climate_data_objs)
  k <- vector("list",length(data_objs_names))
  names(k) <- data_objs_names
  
  for(i1 in 1:length(climate_data_objs)){
    data_obj <- climate_data_objs[[i1]]
    data_time_period = data_obj$data_time_period
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
    # GET COMMON VARIABLES
    # Name of station_id column
    station_id_col <- data_obj$getvname(station_label)
    # Get date_time_period ("daily","subdaily",etc.)
    data_time_period <- data_obj$data_time_period
    # Get var labels
    var_labels <- data_obj$get_var_labels()
    
    #########################################################################
    # Get the station id for each curr_data available
    for(i2 in 1:length(curr_data_list)){
      curr_data <- curr_data_list[[i2]]
      
      # Station id
      station_ids <- unique(curr_data[[station_id_col]])
      station_id <- station_ids[which(!is.na(station_ids))]
      
      
      # Names for each station_id
      k[[i1]][[i2]] <- vector("list",length(station_id))
      names(k[[i1]][[i2]]) <- as.character(station_id)
      
      for (i3 in 1:length(station_id)){
        # Names for each variable
        k[[i1]][[i2]][[i3]] <- vector("list",length(var_labels))
        names(k[[i1]][[i2]][[i3]]) <- var_labels
        
        # Find the data specifically for a given station
        id3 <- which(curr_data[[station_id_col]]==station_id[i3])
        curr_data_new <- curr_data[id3,]
        
        
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
          
          
          #k[[i1]][[i2]][[i3]]
          # Get the variable 
          var_col <- data_obj$getvname(as.character(var_labels[i4]))
          y <- curr_data[[var_col]]
          x <- curr_data[[date_col]]
          
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
          print(head(x))
          
          print(head(z5))
          n <- length(z5[1,])
          
          k[[i1]][[i2]][[i3]][[i4]] <- vector("list",n)
          names(k[[i1]][[i2]][[i3]][[i4]]) <- colnames(z5)
          
          # Define the options of the plot (e.g. color)
          if (var_labels[[i4]]=="rain"){
            colplot <- "blue"
            fg <- F
            stp <- T
            typeplot <- "function barChartPlotter(e) {
                          var ctx = e.drawingContext;
            var points = e.points;
            var y_bottom = e.dygraph.toDomYCoord(0);  // see     http://dygraphs.com/jsdoc/symbols/Dygraph.html#toDomYCoord
            
            // This should really be based on the minimum gap
            var bar_width = 2/3 * (points[1].canvasx - points[0].canvasx);
            ctx.fillStyle = e.color;
            
            // Do the actual plotting.
            for (var i = 0; i < points.length; i++) {
            var p = points[i];
            var center_x = p.canvasx;  // center of the bar
            
            ctx.fillRect(center_x - bar_width / 2, p.canvasy,
            bar_width, y_bottom - p.canvasy);
            ctx.strokeRect(center_x - bar_width / 2, p.canvasy,
            bar_width, y_bottom - p.canvasy);
            }
          }"
            
          }else{
            colplot <- "red"
            fg <- FALSE
            stp <- F
            typeplot <- NULL
          }
          
          #####################################################################
          for (i5 in 1:n){
            # Create Plots
            k[[i1]][[i2]][[i3]][[i4]][[i5]] <- 
              dygraph(z5[,i5],main =paste0(tit," - ", colnames(z5)[i5])) %>%
              dySeries("V1", var_labels[[i4]]) %>%
              dyOptions(titleHeight = 22,
                        axisLabelFontSize = 12,
                        stepPlot =stp, 
                        fillGraph=fg,
                        colors=colplot,
                        drawGrid =T,
                        useDataTimezone =F,
                        plotter = typeplot) %>%
              dyRangeSelector(height = 20)  %>%
              dyAxis("y", label = var_labels[[i4]])
          }
        }
      }
    }
  }
  print("Timeseries created!")
  proc.time() - ptm
  return(k)
})