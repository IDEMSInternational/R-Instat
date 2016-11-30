#' Annual Variable Total
#' @title annual variable total  
#' @name plot_annual_variable_total
#' @author Abib Duut 2015 

#' @description \code{plot_annual_variable_total} 
#' This gives of plot of the annual variable total for each month for the years of data. 
#' @param data_list list. 
#' 
#' @examples
#' climObj <- climate(data_tables=list(data),date_format="%Y-%m-%d")
#' # where "data" is a data.frame containing the desired data to be plotted.
#' climObj$plot_annual_variable_total()
#' @return plot of the three summaries; the mean, the max and the min.
#' 
#'------------------------------------------------------------------------------------------------
#'------------------------------------------------------------------------------------------------

climate$methods( plot_annual_variable_total = function(data_list=list(), title = "Annual Variable Total", col="blue", pch=20, type="b", ylim=0,lty=1,lwd=1,
                                                   mean_lty=2, mean_color="black", plot_mean=TRUE, mean_lwd=1){
	  #--------------------------------------------------------------------------------------------#
	  # This function plots the annual variable total 
	  #-------------------------------------------------------------------------------------------#
	  # convert_data need to be set to TRUE. I am not sure of how to insert it without doing the ff.
	  #data_list=list(convert_data=TRUE)
	  # variable of interest is required for this method
	  data_list = add_to_data_info_required_variable_list( data_list, list(rain_label, date_label) )
	  print("1")
	  # yearly data is required for this method
	  data_list=add_to_data_info_time_period( data_list, daily_label )
	  print("2")
	  # use data_list to get the required data objects
	  climate_data_objs = get_climate_data_objects( data_list ) 
	  
	  
		  for( data_obj in climate_data_objs){
		    data_name = data_obj$get_meta(data_name_label)
		    year_col = data_obj$getvname(year_label)
		    rain_col = data_obj$getvname(rain_label)
			    
			    if( ! data_obj$is_present( year_label ) ){
			      data_obj$add_year_month_day_cols()
			    }
		    print("4")
		   
	    # Access data in methods
	    curr_data_list = data_obj$get_data_for_analysis(data_list)
		    for( curr_data in curr_data_list){
	      	
	      	curr_data = cbind(curr_data, new_rain=curr_data[[rain_col]])
	      	mc<-ddply(curr_data,.(curr_data[[year_col]]),summarize,sum(is.na(curr_data[[rain_col]])))
		      names(mc)<-c("year","count")
		      mc<-mc$year[mc$count>20]
		      print("6")
		      
		      #find annual totals
		      an<-ddply(curr_data,.(curr_data[[year_col]]),summarize, sum(na.omit(curr_data[[rain_col]])))
		      names(an)<-c("Year","tot")
		      
		      #exclude years in final cm
		      ned<-an$Year		
		      ned<-ned%in%mc
		      
		      an$ned<-ned	
		      nan<-subset(an,ned==F,select=c(Year,tot))     
	      	curr_data[[year_col]]<-nan$Year
	      	curr_data[[total_rain]]<-nan$tot
	      	              
	     		plot(  curr_data[[year_col]], curr_data[[total_rain]], type = type, col = col, pch = pch, ylim= c(ylim, max(curr_data[[total_rain]], na.rm=TRUE)), lty=lty, lwd=lwd,
				      xlim = c( min(curr_data[[year_col]], na.rm=TRUE), max( curr_data[[year_col]], na.rm=TRUE)), xlab = "Year", ylab = "Rain Total", main =c(data_name, title))
	     		print("5")
		      # still need to fix that. 
		      if( plot_mean == TRUE ){
		        print("6")
			   plot(  curr_data[[year_col]], curr_data[[total_rain]], type = type, col = col, pch = pch, ylim= c(ylim, max(curr_data[[total_rain]], na.rm=TRUE)), lty=lty, lwd=lwd,
				      xlim = c( min(curr_data[[year_col]], na.rm=TRUE), max( curr_data[[year_col]], na.rm=TRUE)), xlab = "Year", ylab = "Rain Total", main =c(data_name, title))
			    par(new=T)
			abline(h=mean(curr_data[[total_rain]]), lty = mean_lty,  col = mean_color, lwd=mean_lwd)
      }
    }
  }
}
)


#------------------------------------------------------------------------------------------------#
#------------------------------------------------------------------------------------------------#


