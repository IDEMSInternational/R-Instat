#==================================================================================================
# 
#' @title Boxplot method
#' @name cliboxplot
#' @author Fanuel 2015 (AMI)

#' @description \code{Box plot} 
#' produces box-and-whisker plot(s).
#' @param data_list A list for specifying what data should be used in the method.
#' @param var The variable to be plotted.
#' @param factor_level A logical indicating whether plotting should be done based on a factor e.g
#' boxplot of daily rainfall per month
#' @param factor The factor variable e.g month.
#' @param threshold  A numeric value that is used to select values to be plotted. For example, a threshold of rain for a rainy day. The default is 0.85.
#' @param whisklty Whisker line type.
#' @param fill_col Box color.
#' @param whiskcol Color of whisker.
#' @param title Boxplot title.
#' @param ylab The y-axis label.
#' @param xlab The X-axis label.
#' @param 
#' 
#' @examples
#' ClimateObj <- climate( data_tables = list( dataframe=dataframe ), date_formats = list( "%m/%d/%Y" ) )
#' Default dateformats: "%Y/%m/%d"
#' where "data" is a data.frame containing the desired data to be computed.
#' climateObj$cliboxplot(). 
#' The explanations for most of the arguments are in ?boxplot
#' @return box-and-whisker plot(s).
#'

climate$methods(cliboxplot=function( data_list=list(),var=rain_label,factor_level=TRUE, factor=month_label, threshold=0.85, whisklty=1, whiskcol="red",
                                                         fill_col="blue",title="Monthly Rainfall Amount",ylab="Rainfall (mm)",xlab="Month",
                                                         range = 1.5, width = NULL, varwidth = FALSE,notch = FALSE, outline = TRUE, plot = TRUE,
                                                         border = par("fg"), col = NULL, log = "",pars = list(boxwex = 0.8, staplewex = 0.5, outwex = 0.5),
                                                         horizontal = FALSE, add = FALSE, at = NULL,names=month.abb,data_period_label=daily_label){
  #--------------------------------------------------------------------------------------------#
  # This function plots the boxplot of the daily rainfall observations per month for all the years
  #-------------------------------------------------------------------------------------------#
  
  # rain variable is required for this method
  data_list = add_to_data_info_required_variable_list( data_list, list(var))  
  data_list=add_to_data_info_time_period(data_list, data_period_label)  
  # use data_list to get the required data objects
  climate_data_objs = get_climate_data_objects( data_list )
  
  for( data_obj in climate_data_objs ){
    
    threshold = data_obj$get_meta(threshold_label,missing(threshold),threshold)
    data_name=data_obj$get_meta( data_name_label )
    
    if( ! data_obj$is_present( month_label ) ){
      data_obj$add_year_month_day_cols()
    }
    # Get the title of the column of months
    factor_col = data_obj$getvname(factor)
    var_col =  data_obj$getvname(var)
    # Access data in methods
    curr_data_list = data_obj$get_data_for_analysis(data_list)
    for( curr_data in curr_data_list ) {
      
      if( factor_level == TRUE) {
        curr_dat <- curr_data[curr_data[[var_col]] > threshold, c(var_col,factor_col)]
        boxplot(curr_dat[[var_col]]~curr_dat[[factor_col]],whisklty=whisklty,whiskcol=whiskcol,col=fill_col,xlab=xlab,
                ylab=ylab, main= c(data_name, title),range = range, width = width, varwidth = varwidth,
                notch = notch, outline = outline, plot = plot,border = border, log = log,
                pars = pars,horizontal = horizontal, add = add, at = at,names=names )
      }else{
        curr_dat <- curr_data[curr_data[[var_col]] > threshold,c(var_col)]
        boxplot(curr_dat,whisklty=whisklty,whiskcol=whiskcol,col=fill_col,xlab=xlab,
                ylab=ylab, main= c(data_name, title),range = range, width = width, varwidth = varwidth,
                notch = notch, outline = outline, plot = plot,border = border, log = log,
                pars = pars,horizontal = horizontal, add = add, at = at )
      }
      
    }
  }  
} 
)  
