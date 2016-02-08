#==================================================================================================
#' @title Plot Daily summary.
#' @name daily_summary_plot
#' @author Fanuel and Steve 2015 (AMI)

#' @description \code{plot.daily.summary} 
#' Computes and plots daily summary e.g mean
#'  
#' @param data_list this is a list containing stations for analysis, 
#' the years or periods to be analyzed and the required variables from the data.
#' @param var   This contains the variables list of interest in the plot.
#' @param col  The color for the line
#' @param lwd width of the line
#' @param type type of the plot
#' @param lty  The line type
#' @param summary_color color of the summary line
#' @param summary_lty  summary line type
#' @param plot_summary logical expression on whether to plot summary line or not
#' @param title  Overall title for the plot
#' @param na.rm logical expession on whether to exlude or include missing values
#' @param summary_func the function to include in the plot
#' @param xlab, ylab   Title for the x axis and y axis respectively.
#' 
#' @examples
#' ClimateObj <- climate( data_tables = list( data ), date_formats = list( "%m/%d/%Y" ) )
#' Default dateformats: "%Y/%m/%d"
#' # where "data" is a data.frame containing the desired data to be computed.
#' climateObj$daily_summary_plot()
#' @return return plot(s) of daily summary
#

climate$methods( daily_summary_plot = function(data_list=list(),var=rain_label, col="blue", lwd=3, type="l", 
                                               lty=1, summary_color="black", summary_lty=2, summary_lwd=1, 
                                               plot_summary=FALSE, title= "Daily Mean Rainfall Amounts", na.rm=TRUE,
                                               summary_func=mean, xlab = "Day of Year", ylab = "Mean Rainfall"){
                                               
  #--------------------------------------------------------------------------------------------#
  # This function plots the average rainfall observations per day for all teh years. 
  #-------------------------------------------------------------------------------------------#
  # rain variable is required for this method
  data_list = add_to_data_info_required_variable_list( data_list, list(var) )
  
  # daily data is required for this method
  data_list=add_to_data_info_time_period( data_list, daily_label )
  
  # use data_list to get the required data objects
  climate_data_objs = get_climate_data_objects( data_list )  
  for( data_obj in climate_data_objs ){
    
    data_name = data_obj$get_meta(data_name_label)
    
    #if day of year column not present add one
    if( !data_obj$is_present( dos_label )){
      data_obj$add_doy_col()
    }
    
    dos_col = data_obj$getvname(dos_label)
    rain_col = data_obj$getvname(var)
    
    curr_data_list = data_obj$get_data_for_analysis( data_list )
    
    for( curr_data in curr_data_list){
      
      # Add a column of rain to the data with a specific: "new_rain_col" name for ddply use
      #curr_data = cbind(curr_data, new_rain_col=curr_data[[rain_col]])
      
      #db <-  ddply(  curr_data, c(DOY=dos_col),  summarise, Mean = mean( na.omit(new_rain_col) )  )
      db=aggregate(curr_data[[rain_col]], by=curr_data[c(dos_col)], FUN=summary_func,na.rm=na.rm)
      names(db) <- c("DOY","Mean")
      
      plot( db$DOY, db$Mean, ann=F, col=col, lwd=lwd, type=type, lty=lty ) 
      title( main = c( data_name,title),  xlab = xlab,  ylab = ylab )
      grid( 10, 10,lwd = 1 )
      # If the line of the mean of total rainfall is required. But this only plot for teh first plot in case we 
      #have multiple climate object.
      # still need to fix that. 
      if( plot_summary == TRUE ){
        par(new=T)
        abline(h = summary_func( db$Mean ), lty = summary_lty,  col = summary_color, lwd=summary_lwd)
      }     
      
    } 
  } 
  
} 
)