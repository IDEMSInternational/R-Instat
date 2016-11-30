##############################################################################
# WINDROSE - SHINY
#' @title Get Windrose from a climObject through shiny
#' @name wind_rose
#' @author Jens Riede, October 2015 (SASSCAL/DWD)
#' @description 
#' Allows plotting the wind data in a windrose plot. It does not require 
#' any input since it takes all the information from the Climate Object
#'  
#' @return Returns a list of plots. This list can be then used by 
#' \code{graphics_frontend_shiny} to plot the windroses into the shiny 
#' interface.
#' 
#' 
climate$methods(windrose_shiny = function(skala="bft", wr.type="default", ws.type = "meter"){
  ############################################################################
  # Required packages
  library(openair)
  
  ###########################################################################
  # Create empty list where the plots will be saved
  ptm <- proc.time()
  print("Creating windroses...")
  
  ###########################################################################
  # Get the climate data Objects
  data_list <- list()
  #climate_data_objs = climObj.wind$get_climate_data_objects(data_list)
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
    #var_labels <- climObj.wind$get_var_labels(data_obj)
    
    var_labels <- data_obj$get_var_labels()
    #    var_labels <- CO$get_var_labels(data_obj)
    
    #########################################################################
    # GET INFO if both variables Wind_speed and Wind_direction are available
    
    WR.check<-as.character(var_labels)
    tmp1<-0
    
    for(i in 1:length(WR.check)){
      if(WR.check[i] %in% c("wind_speed","wind_direction")){
        tmp1 <-tmp1+1
      }
    }
   if(tmp1 > 1){
      
      #########################################################################
      # Get the station id for each curr_data available
      for(i2 in c(1:length(curr_data_list))) {
        curr_data <- curr_data_list[[i2]]
        
        # Station id
        station_ids <- as.character(unique(curr_data[[station_id_col]]))
        station_id <- station_ids[which(!is.na(station_ids))]
        
        # Names for each station_id
        k[[i1]][[i2]] <- vector("list",length(station_id))
        names(k[[i1]][[i2]]) <- as.character(station_id)
        
        for (i3 in 1:length(station_id)){
          # Names for each variable
          k[[i1]][[i2]][[i3]] <- vector("list",1)
          names(k[[i1]][[i2]][[i3]]) <- "Wind_variabels"
          
          id3 <- which(curr_data[[station_id_col]]==station_id[i3])
          
          # Begin and end dates
          first.date <- curr_data[[date_col]][id3[1]]
          last.date <- curr_data[[date_col]][id3[length(id3)]]
          tperiod <- paste(first.date,"-",last.date, sep="")
          
          
          ######################################################################
          # Get the data of each variable
          # Get the variable
          if(wr.type == "single"){
            wr.type = "default"
          }
            
          ws <- curr_data[[data_obj$getvname(as.character(var_labels$wind_speed))]]
          wd<- curr_data[[data_obj$getvname(as.character(var_labels$wind_direction))]]
          wd[which(wd==-999)]<-NA
          wd[which(wd==990)]<-NA
          ws[which(ws==-999)]<-NA
          #ws <- curr_data[[data_obj$getvname(as.character(date_label$wind_speed))]]
          
          x <- curr_data[[date_col]]
          
          #x <- curr_data$date
          #print(head(x))
          # creating operational dataframe
          df<- data.frame(date= strptime(x,"%Y-%m-%d %H"),ws=ws, wd = wd)
          df<-na.omit(df)
          
          if(length(ws)==0 | length(wd)==0){
            print("insufficient data available pleas check wind speed and wind direction data")
          }
          if(skala =="bft"){
            breaks<-c(0,1.5,3.3,5.5,7.9,10.8,13.9)
            leg.scala<-c(" 0","1","2","3","4","5",">6 Bft")
          }
          if(skala =="meters"){
            breaks<-c(0,2,4,6,8,10,13)
            leg.scala<-c(" >0",">2",">4",">6",">8",">10",">13 m/s")
          }
          if(skala =="knots"){
            breaks<-c(0,1.5,3.3,5.5,7.9,10.8,13.9)
            leg.scala<-c(" >0",">4",">7",">11",">16",">22",">28 ktn")
          }
          temp.list<-list()
          keys <-list(header=paste("station_id",station_id), 
                      footer=paste("period",tperiod) ,  fit = "all", space = "bottom")
          
          temp.list <- pollutionRose(df, pollutant = "ws",key = keys,  annotate =F, paddle=F,
                                     auto.text = FALSE, grid.line = 5,breaks=breaks,type=wr.type)
          
          
          labels <- temp.list$plot$legend$bottom$args$key$labels
          temp.list$plot$legend$bottom$args$key$labels <- leg.scala
          
          temp.list$plot$main <- station_id
          #temp.list$plot$legend$top$args$key$labels<-""
          temp.list$plot$legend$bottom$args$key$height <- 1
          
          #####################################################################
          # Create plots
          #i4 <- 1
          i4=1
          k[[i1]][[i2]][[i3]][[i4]] <- list(temp.list)
         
        }
      }
      print("Windrose created!")
    }else{
      
      print("Please load both variables Wind_speed and Wind_direction into the climobject")
    }
  }
  
  
  return(k)
})
##############################################################################

