# ==============================================================================================================
#' @title Plot method
#' @name cliplot
#' @author Fanuel 2015 (AMI)

#' @description \code{Plot method} 
#' produces time series plot(s).
#'  
#' @param data_list A list for specifying what data should be used in the method.
#' @param var_x The variable to be plotted on the x-axis.
#' @param var_y The variable to be plotted on the y-axis. It could be a list incase of multiple variables 
#' on a single plot.
#' @param linetype The type of line e.g either continuous (default) or dotted.
#' @param color A list of colors of the line(s).
#' @param by_factor A logical indicating whether plotting should be done based on a factor on a single plot
#' e.g comparing a similar variable from different stations with the station as the factor.
#' @param x_axis_lab The x-axis label.
#' @param y_axis_lab The y-axis label.
#' @param main_title The main title of the plot.
#' @param size The size of the lines, the default is 0.
#' @param xlim The limit of the x-axis.
#' @param ylim The limit of the y-axis.
#' @param stat The statistical transformation to use on the data for this layer.
#' @param position The position adjustment to use for overlapping points on this layer.
#' @param factor_var The variable for grouping the lines on a single plot.
#' @param 
#' @examples
#' ClimateObj <- climate( data_tables = list( dataframe=dataframe ), date_formats = list( "%m/%d/%Y" ) )
#' Default dateformats: "%Y/%m/%d"
#' where "data" is a data.frame containing the desired data to be computed.
#' climateObj$cliplot(). 
#' climateObj$cliplot(var_y = "Total Rain", data_period_label = yearly_label).
#' @return time series plot(s).
#' 
#'data_period_label is included in the method to plot the summary_obj (yearly_summaries)
#'variables e.g start of the rain

climate$methods(cliplot = function(data_list=list(),var_x = year_label, var_y = rain_label, linetype=1,color=c("blue"),by_factor=FALSE,data_period_label = daily_label,
                                   x_axis_lab,y_axis_lab, main_title,size=0,xlim = NULL, ylim = NULL, wise = NULL,
                                    stat = "identity", position = "identity", show.legend = NA, inherit.aes = TRUE,factor_var,
                                    station_name=TRUE,variable.name = "variable", na.rm = FALSE){    
  
  data_list = add_to_data_info_required_variable_list(data_list,  list(var_x, var_y)) 
  data_list= add_to_data_info_merge(data_list,by_factor)
  data_list=add_to_data_info_time_period(data_list, data_period_label)
  #Get the data objects  
  climate_data_objs_list = get_climate_data_objects(data_list)
  
  for(data_obj in climate_data_objs_list) {    
    var_x_name = data_obj$getvname(var_x)
    var_y_name=c()
    for (i in 1:length(var_y)){
      var_y_name[i] = data_obj$getvname(var_y[i])
    }   
    
    if (station_name){    
      data_name = data_obj$get_meta(data_name_label)
    }else {
      data_name=NULL
    }
    if (missing(x_axis_lab)){
      x_axis_lab=var_x_name
    }    
    if (missing(y_axis_lab)){
      y_axis_lab=var_y_name      
    }
    if (missing(main_title)){
      main_title="plot"
    }
    main_title2=labs(title=paste(data_name,main_title))  
    xlabel=xlab(x_axis_lab)
    ylabel=ylab(y_axis_lab)
    curr_data_list = data_obj$get_data_for_analysis(data_list)
    if (by_factor){       
      print(ggplot(data= curr_data_list,aes_string(x=var_x_name, y=var_y_name, group=factor_var,colour=factor_var))+
        geom_line(linetype=linetype,stat = stat, position = position, show.legend = show.legend,
                  inherit.aes = inherit.aes, size=size) + xlabel+ylabel+main_title2 +
        scale_colour_manual(values=color)+ coord_cartesian(xlim = xlim, ylim = ylim, wise = wise) 
      )
    }else{      
      for( curr_data in curr_data_list ) { 
        curr_data=subset(curr_data,select=c(var_x_name, var_y_name))
        curr_data <- melt(curr_data, id.vars=var_x_name, variable.name = variable.name, na.rm = na.rm)
        print(ggplot(data= curr_data,aes_string(x=var_x_name, y="value", group=variable.name,colour=variable.name))+
          geom_line(linetype=linetype,stat = stat, position = position, show.legend = show.legend,
                    inherit.aes = inherit.aes, size=size) + xlabel+ylabel+main_title2 +
          scale_colour_manual(values=color)+ coord_cartesian(xlim = xlim, ylim = ylim) 
        )
      }
    }
  }
}
)