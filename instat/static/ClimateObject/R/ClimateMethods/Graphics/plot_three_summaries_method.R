# Three summaries plot for variable
#' @title Plot three summaries  
#' @name plot_three_summaries
#' @author Abib Duut 2015 

#' @description \code{plot_three_summaries} 
#' This gives of plot of the three summaries, max, min , and the mean for each month for the years of data. 
#' @param data_list list. 
#' 
#' @examples
#' climObj <- climate(data_tables=list(data),date_format="%Y-%m-%d")
#' # where "data" is a data.frame containing the desired data to be plotted.
#' climObj$plot_three_summaries()
#' @return plot of the three summaries; the mean, the max and the min.
#' 
climate$methods( plot_three_summaries=function( data_list=list(),var="", title="Summary Values of Monthly Rainfall (mm)", max_color="blue", mean_color="green", min_color="red",ylab="", 
                                                      type = "b", lwd=2, pch =21, lty=1){
		  # convert_data need to be set to TRUE. I am not sure of how to insert it without doing the ff.
		  data_list=list(convert_data=TRUE)
		  # rain variable is required for this method
		  data_list = add_to_data_info_required_variable_list( data_list, list(var) )
		  # subyearly data is required for this method
		  data_list=add_to_data_info_time_period( data_list, subyearly_label )
		  # use data_list to get the required data objects
		  climate_data_objs = get_climate_data_objects( data_list ) 
		  
  for( data_obj in climate_data_objs){
	    data_name = data_obj$get_meta(data_name_label)
	    
    if( ! data_obj$is_present( month_label ) ){
      data_obj$add_year_month_day_cols()
      
    }
		# Get the title of the column of months
		month_col = data_obj$getvname(month_label)
		# Access data in methods
		curr_data_list = data_obj$get_data_for_analysis(data_list)

	for( curr_data in curr_data_list ) {
	total_var = "Total Var"
	curr_data$Total_var = curr_data[[total_var]]
      
	      # Split the data according to the month and compute the mean, min and max
	      m_stat <-ddply(  curr_data, c( month_col ), summarise, Mean = mean( Total_var, na.rm=T),
		               Minimum = min( Total_var, na.rm=T ), Maximum = max( Total_var, na.rm=T)  )
	      # Assigning labels to months.
	      m_stat[[month_col]] <- month(m_stat[[month_col]], label=T)
	      plot(  m_stat$Mean, type= type, lwd = lwd,lty=lty,
		              xaxt = "n", ylim = c(0, max(m_stat$Maximum, na.rm=T)+5 ), col=mean_color,
		              xlab = "", ylab = ylab,
		              main = c( data_name,title) )
	      axis(  1, at = 1 : length( m_stat[[month_col]] ),  labels = m_stat[[month_col]]  )
	      lines(  m_stat$Minimum, col = min_color, type =type, lwd = lwd, lty=lty )
	      lines(  m_stat$Maximum, col = max_color, type =type, lwd = lwd, lty=lty )
	      legend(  "topleft", legend = c(  "Mean", "Minimum", "Maximum"  ),
		       lty = lty, lwd = lwd, pch = pch, col = c( mean_color, min_color, max_color ),
		       ncol = 2, bty = "n", cex = 0.8,
		       text.col = c( mean_color, min_color, max_color ) )
      } 
    }
  } 
)


