# Output data for CPT
#' @title Output data in the form needed for CPT.
#' @name output_for_CPT
#' @author David Stern 2015

#' @description \code{output_for_CPT} 
#' creates a file with data in the format required for CPT (IRI format needed for seasonal forcast). 



climate$methods(output_for_CPT = function(data_list = list(), filename, interested_variables)
{  
  if (!is.list(interested_variables)) interested_variables=list(interested_variables)
  # interested variables required
#  data_list = add_to_data_info_required_variable_list(data_list, interested_variables)
  # date time period is "yearly"
  data_list = add_to_data_info_time_period(data_list, yearly_label)
  # a list of climate data objects
  data_list[[convert_data_label]]=TRUE
  climate_data_objs = get_climate_data_objects(data_list)
  
  for(interested_var in interested_variables) {
    first=TRUE
    #availmeta used to state which meta data to use with the data 0 is no station data available, 1 is just station name 2 is lat and lon and 3 also includes alt  
    if (.self$is_present_or_meta(station_label)) {
      if (.self$is_present_or_meta(list(lat_label,lon_label))) {
        if (.self$is_present_or_meta(alt_label)) {
          availmeta=3              
          outmetadata<-data.frame(labels=c("Station","Lat","Lon", "Alt"))
        } else {
          availmeta=2              
          outmetadata<-data.frame(labels=c("Station","Lat","Lon"))
        }              
      } else {
        availmeta=1              
        outmetadata<-data.frame(labels="Station")
      }
    } else {
      availmeta=0
    }
    for(data_obj in climate_data_objs) {
      date_col  = data_obj$getvname(date_label) 
      var_col  = data_obj$getvname(interested_var) 
      curr_data_list = data_obj$get_data_for_analysis(data_list)
      for( curr_data in curr_data_list ) {
        if (availmeta==3){
          outmetadata[[data_obj$get_station_data(curr_data, station_label)]]=c(data_obj$get_station_data(curr_data, station_label),data_obj$get_station_data(curr_data, lat_label),data_obj$get_station_data(curr_data, lon_label),data_obj$get_station_data(curr_data, alt_label))                
        } else if (availmeta==2){
          outmetadata[[data_obj$get_station_data(curr_data, station_label)]]=c(data_obj$get_station_data(curr_data, station_label),data_obj$get_station_data(curr_data, lat_label),data_obj$get_station_data(curr_data, lon_label))
        } else if (availmeta==1){
          outmetadata[[data_obj$get_station_data(curr_data, station_label)]]=data_obj$get_station_data(curr_data, station_label)
        }
        temp<-subset(curr_data , select=c(date_col, var_col))  	
        names(temp)<-c("Date",data_obj$get_station_data(curr_data, station_label))
        if (first) {
          outdata<-temp
          first=FALSE
        } else {
          outdata<-merge(outdata,temp,by="Date", all=TRUE)
        }
      }
    }
    if (length(interested_variables)>1) filenametemp=paste0(filename,interested_var)
    else filenametemp=filename
    if (availmeta>1) {
      write.table(outmetadata , file=filenametemp,sep="\t", quote=FALSE, row.names=FALSE, col.names=FALSE)
      write.table(outdata, file=filenametemp, sep="\t", quote=FALSE, row.names=FALSE, col.names=TRUE, append=TRUE)  
    } else {
      write.table(outdata, file=filenametemp, sep="\t", quote=FALSE, row.names=FALSE, col.names=TRUE)  
    }
  }
}
)