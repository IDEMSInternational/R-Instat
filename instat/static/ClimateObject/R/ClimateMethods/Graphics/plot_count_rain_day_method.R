#=============================================================================
#' This method counts the number of rain days for each month for the years of data.
#' @title Plot count of rain day
#' @name plot_count_rain_days
#' @author Abib Duut 2015 

#' @description \code{plot_count_rain_days} 
#' this plots shows the number of rain days for each month for the number of years of data.
#' 
#' @param data_list list. 
#' 
#' @examples
#' climObj <- climate(data_tables=list(data),date_format="%Y-%m-%d")
#' # where "data" is a data.frame containing the desired data to be plotted.
#' climObj$plot_count_rain_days()
#' @return  a time series plot.
#' 
#'------------------------------------------------------------------------------------------------#
#'------------------------------------------------------------------------------------------------#

climate$methods( plot_count_rain_days = function( data_list=list(), col="blue", type="b", lty=1, lwd=1,title="Annual Rain Counts Across Given years", mean_color="black",xlab=xlab,ylab="Rain Counts", 
                                                   plot_mean=TRUE, pch=20, mean_lty=2, mean_lwd=1, ylim=0 ){
  #--------------------------------------------------------------------------------------------#
  # This function plots the annual number rainy days
  #-------------------------------------------------------------------------------------------#
  # convert_data need to be set to TRUE. I am not sure of how to insert it without doing the following
  data_list=list(convert_data=TRUE)
  # rain variable is required for this method
  data_list = add_to_data_info_required_variable_list( data_list, list(rain_label) )
  # yearly data is required for this method
  data_list=add_to_data_info_time_period( data_list, yearly_label )
  # use data_list to get the required data objects
  climate_data_objs = get_climate_data_objects( data_list ) 
  
  for( data_obj in climate_data_objs){
	    data_name = data_obj$get_meta(data_name_label)
	    # Get the title of the column of years
	    year_col = data_obj$getvname(year_label)
	    
	    if( ! data_obj$is_present( year_label ) ){
	      data_obj$add_year_month_day_cols()
	    }
    
	    # Access data in methods
	    curr_data_list = data_obj$get_data_for_analysis(data_list)
	    
	    for( curr_data in curr_data_list){
	      numbr_rain_days="Number of Rain Days"
	      
 	     plot( curr_data[[year_col]], curr_data[[numbr_rain_days]],ann=F, type = type, ylim = c(ylim, max(curr_data[[numbr_rain_days]], na.rm=TRUE) ), xlab,ylab , xlim=c(min(curr_data[[year_col]], na.rm=TRUE), max(curr_data[[year_col]],na.rm=TRUE)), col = col, lwd=lwd, lty=lty, pch=pch)
      	     title( main = c( data_name,title) )
      	     grid( 10,10,lwd=1 )
      if( plot_mean==TRUE ){
        par(new=T)
        abline( h = mean( curr_data[[numbr_rain_days]] ), col = mean_color, lty=mean_lty, lwd=mean_lwd )
      }
	    }
	  }   
	}
 )

