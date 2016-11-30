##############################################################################
# TIMESERIES
#' @title Get timeseries from the Climsoft data
#' @name timeseries
#' @author Rafael Posada 2015 (SASSCAL/DWD)
#' @description 
#' Allows plotting the data in a timeseries plot.
#'  
#' @return It returns a timeseries plot.
#' 
climate$methods(gsub2 = function(pattern, replacement, x, ...) {
  for(i in 1:length(pattern))
    x <- gsub(pattern[i], replacement[i], x, ...)
  x
})

climate$methods(timeseries = function(data_list = list()){
  #######################################################################
  require(ggplot2)
  # CLIMATE DATA OBJS
  climate_data_objs = get_climate_data_objects(data_list)
  
  for(data_obj in climate_data_objs) {
    data_name = data_obj$get_meta(data_name_label)   
    
    #####################################################################
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
      # Get the data of each variable
      for (i in var_label){
        # Get the variable 
        var_col = data_obj$getvname(as.character(i))
        y <- curr_data[[var_col]]
        x <- curr_data[[date_col]]
        
        # Differ between "subdaily" and other time periods
        if (data_time_period=="subdaily"){
          # Make sure to use always the same time format:
          x <- as.POSIXct(as.character(x),tz="UTC")
          # Get the time period stamp of the dataset
          time_diff <- diff(x)
          # Count cases with the same time stamp
          time_stamp <- table(diff(x))
          
          # a) get the time difference units (minutes, hours, etc.)
          time_units <- units(time_diff)
          if(time_units=="hours"){
            id <- which(time_stamp==max(time_stamp))
            time_interval <- names(time_stamp)[id]
            if (time_interval==1){
              data_time_period <- paste(time_interval,time_units)
            }
          }
          if(time_units=="mins"){
            id <- which(time_stamp==max(time_stamp))
            time_interval <- names(time_stamp)[id]
            data_time_period <-  paste(time_interval,time_units)
          }
        }
        
        data2 <- data.frame(x,y)
        
        ######################################################################
        # GET THE MAX & MIN LIMITS
        n.std <- 4
        std.dev <- sd(y,na.rm=TRUE)
        mean <- mean(y,na.rm=TRUE)
        yaxis.max <- round(mean+(n.std*std.dev),digits=2)
        yaxis.min <- round(mean-(n.std*std.dev),digits=2)
        if (yaxis.min<0 & grepl("temp",var_col)==FALSE){
          yaxis.min=0
        }
        
        ######################################################################
        # CHECK IF THE ELEMENT IS RAIN OR NOT
        if (i=="rain"){
          plot.type <- "h"
          plot.color <- "blue"
        }else{
          plot.type <- "o"
          plot.color <- "red"
        }
        
        Sys.sleep(0.1) # this is to avoid an error that pops up when trying 
        # to plot two plots at a time (something to do with
        # rversion in grDevices)
        
        #######################################################
        # COMMON VARIABLES
        # xticks and yticks
        xticks <- pretty(x,20)
        yaxis.min <- min(y,na.rm=TRUE)
        yaxis.max <- max(y,na.rm=TRUE)
        yticks <- pretty(c(yaxis.min,yaxis.max),n=15)
        
        # Title and subtitle
        tit<- toupper(paste("Station id: ",station_id," - ",var_col, "-",
                            data_time_period))
        subtit <- toupper(paste(first.date,"-",last.date))
        
        # Legend
        # Total number of cases for the given time inverval
        tt.total <- paste("Total Cases: ",length(y))
        
        # Number of cases above the maximum limit
        above.max <- which(y>yaxis.max)
        above.percent <- round((length(above.max)/length(y))*100,2)
        tt.above <- paste("Cases > ",round(yaxis.max,2),": ",length(above.max),
                          " (",above.percent,"%)",sep="")
        
        # Number of cases below the minimum limit
        below.min <- which(y<yaxis.min)
        below.percent <- round((length(below.min)/length(y))*100,2)
        tt.below <- paste("Cases < ",round(yaxis.min,2),": ",length(below.min),
                          " (",below.percent,"%)",sep="")
        
        # Number of NA cases 
        na.cases <- which(is.na(y))
        na.percent <- round((length(na.cases)/length(y))*100,2)
        tt.na <- paste("'NA'-Cases: ",length(na.cases),
                       " (",na.percent,"%)",sep="")
        
        #######################################################
        # Plot
        if (data_time_period=="subdaily"){
          time <- format(data2$x,"%H:%M:%S")
          data2$time <- time
          k <- ggplot(data2, aes(x,y,group=time))# dataset
          k <- k + facet_wrap(~ time, nrow=length(unique(data2$time)))
        }else{
          k <- ggplot(data2, aes(x,y))# dataset
          
        }
        if (class(xticks)[1]=="POSIXct" || class(xticks)[1]=="POSIXlt"){
          k <- k + scale_x_datetime(breaks = xticks) # Create x ticks  
        }else{
          k <- k + scale_x_date(breaks = xticks) # Create x ticks  
        }
        if (i =="rain"){
          k <- k + geom_bar(stat="identity",colour=plot.color,na.rm=TRUE)  # type of plotting
        }else{
          k <- k + geom_line(colour=plot.color,na.rm=TRUE)  # type of plotting
        }
        # Themes
        k <- k + theme_bw()
        k <- k + theme(panel.grid.major= element_line(color = "gray80"))
        k <- k + theme(panel.grid.minor= element_line(color = "gray80",
                                                      linetype = "dotted"))
        # title and labels
        k <- k + labs(x=date_col,y=var_col,title=paste0(tit,"\n(",subtit,")\n",
                                                        tt.total,"\n",
                                                        tt.na,"\n",
                                                        tt.above,"\n",
                                                        tt.below))
        k <- k + theme(axis.text.x=element_text(angle=-45, hjust=0, vjust=1), 
                       plot.title = element_text(size = 10,  colour = "gray20"))
        suppressWarnings(print(k))
      }
    }
  }
})