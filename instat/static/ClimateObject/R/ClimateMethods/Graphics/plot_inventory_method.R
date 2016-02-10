#'  Inventory Plot 
#' @title Inventory Plot
#' @name plot_inventory
#' @author Abib Duut 2015
#' 
#' @description \code{inventory plot}
#' This displays the data present for multiple stations, which helps in visual comparisons of avaliable data across multiple stations. 
#' data should contain the following columns (but not neccessarily named as) station, date, rain.
#'  
#' @return an inventory plot for mutiple stations.
#'----------------------------------------------------------------------------------------------------------------------------
#'----------------------------------------------------------------------------------------------------------------------------
climate$methods(plot_inventory = function (data_list=list(),ylab,na.rm=TRUE,col=c("red","blue"),sort=FALSE,
                                                   var_label = rain_label, graph_parameter = par(mar=c(6,8,4,2)),
                                                   main_title="Inventory Data Plot: Rain"){
  
  #Require the columns needed in this method from the data.
  data_list = add_to_data_info_required_variable_list(data_list, list(var_label,date_label, station_label))
  
  # Merge the data into a single data frame so that we can do a by station analysis.
  data_list[[merge_data_label]]=TRUE
  # time period and station
  data_list = add_to_data_info_time_period(data_list, daily_label)
  
  climate_data_objs = get_climate_data_objects(data_list)
  
  for(data_obj in climate_data_objs) {
  
    data_name = data_obj$get_meta(data_name_label)
    date_col = data_obj$getvname(date_label)
    var_col = data_obj$getvname(var_label)
    station_col = data_obj$getvname(station_label)
  
     if(missing(ylab)){
      ylab = data_obj$getvname(var_label)
    }
    curr_data = data_obj$get_data_for_analysis(data_list)
    #Create binary field indicating whether variable of interest (Rain) is missing or non-missing
    curr_data$val<-as.numeric(is.na(curr_data[[var_col]]))
    station_list<-levels(curr_data[[station_col]])
      
    if(sort==TRUE){
      #Stations will be plotted from bottom to top but we want alphatically first to be on the top so sort stations into reverse alphabetical order. 
      curr_data<-curr_data[rev(order(curr_data[[station_col]])),]
      
      #reshape data into 1 row per day, 1 column per station, with values as calculated previously
      curr_data<-reshape(curr_data[,c(station_col,date_col,"val")],timevar=station_col,idvar=date_col,v.names="val",direction="wide")
    
      #where value is NA after reshape the station did not have a row for that date in the input - this is also missing data so overwrite accordingly.
      curr_data[is.na(curr_data)]<-1
      #sort by date
      curr_data<-curr_data[order(curr_data[[date_col]]),]
      #set plot window  
      par = graph_parameter 
      image(x=curr_data[[date_col]],y=1:(ncol(curr_data)-1),z=as.matrix(curr_data[,-1]),yaxt="n",ylab="",col=c("blue", "red"),xlab="",main= c( data_name, main_title))
      #add white spaces to help delineate the groups
      segments(x0=min(curr_data[[date_col]]),x1=max(curr_data[[date_col]]),y0=seq(0.5,ncol(curr_data)+0.5,by=1),col="white")
      #add labels
      text(x=min(curr_data[[date_col]]),y=1:(ncol(curr_data)-1),rev(sort(station_list)),xpd=T,pos=2,cex=0.75)
      
    }
    
    if(sort==FALSE){
    #reshape data into 1 row per day, 1 column per station, with values as calculated previously
    curr_data<-reshape(curr_data[,c(station_col,date_col,"val")],timevar=station_col,idvar=date_col,v.names="val",direction="wide")
    #where value is NA after reshape the station did not have a row for that date in the input - this is also missing data so overwrite accordingly.
    curr_data[is.na(curr_data)]<-1
    #sort by date
    curr_data<-curr_data[order(curr_data[[date_col]]),]
    #set plot window  
    par = graph_parameter 
    # for the plot 
    image(x=curr_data[[date_col]],y=1:(ncol(curr_data)-1),as.matrix(curr_data[,-1]),yaxt="n",ylab="",col=c("blue", "red"),xlab="",main= c( data_name, main_title))
    #add white spaces to help delineate the groups
    segments(x0=min(curr_data[[date_col]]),x1=max(curr_data[[date_col]]),y0=seq(0.5,ncol(curr_data)+0.5,by=1),col="white")
    #add labels
    text(x=min(curr_data[[date_col]]),y=1:(ncol(curr_data)-1),station_list,xpd=T,pos=2,cex=0.75)
    
    
    } 
      
    }
  }
)
