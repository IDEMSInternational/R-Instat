#======================================================================================
#  MISSING VALUES FOR RAINFALL AMOUNT
#' @title Plot the missing values for the rainfall amount, per year
#' @name plot_missing_values_rain
#' @author AMI group 2015 

#' @description \code{Plot.missing.values} 
#' Plot the missing values for the rainfall amount given a climate object
#' 
#' @param data_list	A list containing stations for analysis, the years or periods to be analysed and the required variables from the data. 
#' If blank, the system will choose all data appropriate for the analysis.
#' @param na.rm A logical indicating whether missing values should be removed.
#' @param fill_col The colour of the plot indicating whether a day is rainy, dry or NA respectively.
#' @param main Character string or expression giving a title of the plot.
#' @param xlab A title for the x axis.
#' @param ylab A title for the y axis.
#' @param legend_position The location of the legend on the graph.
#' @param station_name A logical indicating whether the character string of the station name should be added to the plot.
#' @param log Character, indicating which axes should be in log scale.
#' @param asp Numeric, giving the aspect ratio y/x.
#' @param horiz logical;if TRUE, set the legend horizontally rather than vertically.
#' @param pch A vector of plotting characters or symbols.
#' 
#' @examples
#' climateObj <- climate$new( data_tables = list( data ), date_formats = list( "%m/%d/%Y" ) )
#' # where "data" is a data.frame containing the desired data to be plotted.
#' climateObj$plot_missing_values_rain()
#' @return Plot the missing values
#' 

climate$methods(plot_missing_values_rain = function(data_list=list(), threshold = 0.85, main = "Rain Present",xlab = "Year",legend_position="topright",log = "",asp = NA,horiz=TRUE,
                                                    ylab = "Day of Year",station_name = TRUE, fill_col=c("blue","yellow","red"),ylim = c(0,500),legend = c("Rain","Dry","NA"),pch="-"){    
  
  #=======================================================================================
  # This function plots the missing values for the rainfall amount, per year
  # It is here to demonstrate how an output method 
  # It has the following optional arguments:
  # data_list: Specify the subset of the data to use. 
  # threshold: threshold which determines if a day is dry if the rainfall amount is below it. This overrides the threshold stored in the metadata if provided.
  # fill_col: A list of colours to use the first is for rain days the second for dry and the third for missing, missing dates are blank
  #===============================================================================================
  
  # get_climate_data_objects returns a list of the climate_data objects specified
  # in the arguements.
  # If no objects specified then all climate_data objects will be taken by default
  # TO DO have options such as colours and the rest
  data_list=add_to_data_info_required_variable_list(data_list, list( rain_label ))
  data_list=add_to_data_info_time_period(data_list, daily_label)
  climate_data_objs_list = get_climate_data_objects(data_list)
  
  for(data_obj in climate_data_objs_list) {
    
    data_name = data_obj$get_meta(data_name_label)
    
    curr_threshold = data_obj$get_meta(threshold_label, threshold)
    
    rain_col  = data_obj$getvname( rain_label )
    # If doy or year column is not in the data frame, create it.
    if ( !(data_obj$is_present( dos_label ) && data_obj$is_present( season_label ))) {
    
      data_obj$add_doy_col()
    }
    dos_col = data_obj$getvname( dos_label )
    season_col = data_obj$getvname( season_label )
    
    curr_data_list = data_obj$get_data_for_analysis( data_list )
    
    for( curr_data in curr_data_list ) {
      if (!station_name){
        data_name=NULL
      }
      a2 <- subset( curr_data, curr_data[[ rain_col ]] > curr_threshold)
      a3 <- subset( curr_data, curr_data[[ rain_col ]] <= curr_threshold)
      a1<-curr_data[is.na( curr_data[[ rain_col]] ),]      
      
      plot(curr_data[[ season_col ]],curr_data[[ dos_col ]], xlim = c(range(min(curr_data[[ season_col ]]), max(curr_data[[ season_col ]]))), 
           ylim = ylim, log = log, asp = asp, xlab = xlab, ylab =ylab, main = c(data_name,main))
      legend(legend_position,legend = legend, fill = fill_col, horiz = horiz)
      points(as.numeric(a1[[ season_col ]]),a1[[ dos_col ]], pch=pch, col = fill_col[3])
      points(as.numeric(a2[[ season_col ]]),a2[[ dos_col ]], pch=pch, col = fill_col[1])
      points(as.numeric(a3[[ season_col ]]),a3[[ dos_col ]], pch=pch,col = fill_col[2])
      
      # TO DO output multiple plots in multiple ways   legend 
    }
  }
}
)
