#------------------------------------------------------------------------
# This function plots annual totals of rainfall amount, per year
# It is here to demonstrate how an output method 
#
# It has the following optional arguments:
# data_list: Specify the subset of the data to use. 
# threshold: threshold which determines if a day is dry if the rainfall amount is below it. This overrides the threshold stored in the metadata if provided.
# 
# ----------------------------------------------------------------------------

climate$methods(plot_annual_rain_total = function(data_list=list(), threshold = 0.85)
  {    
  # get_climate_data_objects returns a list of the climate_data objects specified
  # in the arguements.
  # If no objects specified then all climate_data objects will be taken by default
  # TO DO have options such as colours and the rest
  data_list=add_to_data_info_required_variable_list(data_list, list(rain_label))
  data_list=add_to_data_info_time_period(data_list, yearly_label)
  climate_data_objs_list = get_climate_data_objects(data_list)
  
  for(data_obj in climate_data_objs_list) {
    curr_threshold = data_obj$get_meta(threshold_label,threshold)
    
    rain_col  = data_obj$variables[[rain_label]]
    # If doy or year column is not in the data frame, create it.
    if ( !(data_obj$is_present(dos_label)&data_obj$is_present(season_label))) {
      # add_doy_col function does not exist yet.
      data_obj$add_doy_col()
    }
    dos_col = data_obj$variables[[dos_label]]
    season_col = data_obj$variables[[season_label]]
    curr_data_list=data_obj$get_data_for_analysis(data_list)
  }
    
   
##############################################################################
#   data$year<-year(data$Date)
#   data$Rain<-as.numeric(data$Rain)
#   
#   #count NA's in data
#   mc<-ddply(data,.(year),summarize,sum(is.na(Rain)))
#   names(mc)<-c("year","count")
#   mc<-mc$year[mc$count>20]
#   
#   #find annual totals
#   an<-ddply(data,.(year),summarize,sum(na.omit(Rain)))
#   names(an)<-c("Year","tot")
#   
#   #exclude years in final cm
#   ned<-an$Year		
#   ned<-ned%in%mc
#   
#   an$ned<-ned	
#   nan<-subset(an,ned==F,select=c(Year,tot))
#   db<-nan
#   plot4<-plot(db$Year,db$tot,type="b",col="blue",pch=20,xlab="",ylim=c(0,max(db$tot)+5),ylab="Rain Total(mm)",main="Annual Rainfall Total")
#   abline(h=mean(db$tot[db$tot>0]),lty=2,col="red")
#   
  #summary of total	
  
  # n<-which.is.max(db$tot)
  # print(mean(db$tot))
  # print(paste(db$Year[n],db$tot[n]))
  # print(quantile(db$tot, 0.20))
  
  # m<-which.min(db$tot)
  # print(paste(db$Year[m],db$tot[m]))
  
  
  #Annual rainfall totals for across the years.  
  #Split data by year 
  #smb<-subset(data,!Rain==NA,select=c(Rain,Year))
  #smb<-as.data.frame(smb)
  #sdata<-split(smb$Rain,smb$Year)
  #stot<-sapply(sdata,sum,na.rm=TRUE)
  #stot<-as.data.frame(stot)
  #rw<-row.names(stot)
  #plot(rw,stot$stot,type="b",col="blue", pch=20,xlab="Year",ylab="Rain Total",main="Annual Rain Total")
  #abline(h=mean(stot$stot),lty=2,col="red")
  #grid(10,10,lwd=2)
  
  #This for plot summaries.
  #x<-summary(db$tot)
  
  #The value of summaries differ from that of instats, and add abline showing trend. Increase line width.
  
  #text(Average #annual# rainfall amount is "print("mincount")" mm. It ranges from "print("mincount")" mm to "print("mincount")"mm with 
  #"print("year")" and "print("year")" being the years with the least and most amount of rainfall recorded respectively. Also it can ve seen that 
  #"for" every "print("mincount")" out of "print("mincount")" years there is an expected annual rainfall of over "print("mincount")"mm 'in' this region and with 
  #	no visible trend.)
 # plot4 #;x
}
)