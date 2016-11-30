#  yearly summaries
#' @title plot yearly summaries
#' @name plot_yearly_summary
#' @author Frederic Ntirenganya 2015 (AMI) and Stephen Kogo (AMI)
#' 
#' @description \code{yearly.summaries.plot}
#' plot yearly summaries of interest from climate object
#'  
#' @param data_list=list() – this is a list containing stations for analysis, 
#' the years or periods to be analyzed and the required variables from the data.
#' @param col1  The color for the graph
#' @param xlab, ylab   Title for the x axis and y axis respectively.
#' @param na.rm A logical, when it is true the missing values are removed.
#' @param pch  A vector of plotting characters
#' @param ylim The lowest limit for y axis
#' @param type The  type of plot to be drawn
#' @param lty  The line type
#' @param lwd The line width
#' @param interest_var This indicates the variable to be plotted
#' @param var_label  The variable to be summarized 
#' @param ygrid where the rectangular grid starts 
#' @param graph_parameter  Set graphical parameter
#' @param plot_window logical, if true set up the coordinate system for a graphics window
#' @param main_title  Overall title for the plot
#' @param grid  logical, if true adds an nx by ny rectangular grid to an existing plot
#' 
#' @examples

#' climate_obj <- climate(data_tables=list(data),date_format="%Y-%m-%d")
#' # where "data" is a data.frame containing the desired data to be plotted.
#' climate_obj$plot_yearly_summary()
#' the default plot is the number of yearly number of rainy days 
#' @return it returns a timeseries plot of the specified summary

climate$methods(plot_yearly_summary = function (data_list = list(), col = "blue", ylab, xlab = "Year",
                                                na.rm = TRUE, pch = 20, ylim = 0, type = "b",lty = 2,
                                                lwd = 2, interest_var = "Number of Rainy Days",
                                                var_label = rain_label, ygrid = 0, 
                                                graph_parameter = par(mfrow = c(2,2)),plot_window = FALSE,
                                                main_title = "Summary per Year", grid=FALSE){
  # convert data 
  data_list = c(data_list, convert_data=TRUE)
  # time period
  data_list = add_to_data_info_time_period(data_list, yearly_label)
  
  climate_data_objs = get_climate_data_objects(data_list)
  
  for(data_obj in climate_data_objs) {
    data_name = data_obj$get_meta(data_name_label)
    
    # Must add these columns if not present 
    if( !(data_obj$is_present(year_label) ) ) { 
      data_obj$add_year_col() 
    }
    year_col = data_obj$getvname(year_label)
    
    interset_var_col = data_obj$getvname (interest_var) 
    
    if(missing(ylab)){
      ylab = data_obj$getvname(interest_var)
    }    
    curr_data_list = data_obj$get_data_for_analysis(data_list)
    if (plot_window){   
      par = graph_parameter 
    } 
    # loop for plotting 
    for( curr_data in curr_data_list ) { 
      plot( curr_data[[year_col]], curr_data[[interset_var_col]], type = type,
                                    pch = pch, xlab = xlab, col=col, ylim= c(ylim, 
                                    max(as.numeric(curr_data[[interset_var_col]]), na.rm = na.rm)),
                                    xlim = c( min(as.numeric(curr_data[[year_col]]), na.rm = na.rm),
                                    max( as.numeric(curr_data[[year_col]]), na.rm = na.rm)),
                                    ylab=ylab, main= c( data_name, main_title))
      
      if (grid){
        grid(length(curr_data[[year_col]]),ygrid, lwd = lwd)
      }  
    }
  }
  par(mfrow=c(1,1))
}
)