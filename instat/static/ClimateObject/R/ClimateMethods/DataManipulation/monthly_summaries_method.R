climate$methods(monthly_summary=function( data_list=list(),upper_lim = " ", lower_lim = 0, start_day = 1, end_day = 366, threshold=0, na.rm=TRUE, summ = mean, decimals = 2){
  #--------------------------------------------------------------------------------------------#
  # This function plots the boxplot of the daily rainfall observations per month for all the years
  #-------------------------------------------------------------------------------------------#
  
  # rain variable is required for this method
  data_list = add_to_data_info_required_variable_list( data_list, list(rain_label) )
  
  # daily data is required for this method
  data_list=add_to_data_info_time_period( data_list, daily_label )
  
  # use data_list to get the required data objects
  climate_data_objs = get_climate_data_objects( data_list )
  
  for( data_obj in climate_data_objs ){
    
    threshold = data_obj$get_meta_new(threshold_label,missing(threshold),threshold)
    data_name=data_obj$get_meta( data_name_label )
    
    if( ! data_obj$is_present( month_label ) ){
      data_obj$add_year_month_day_cols()
    }
    # Get titles of interested columns
    month_col <- data_obj$getvname(month_label)
    rain_col <-  data_obj$getvname(rain_label)
    year_col <- data_obj$getvname(year_label)
    doy_col <- data_obj$getvname(doy_label)

    # Access data in methods
    curr_data_list <- data_obj$get_data_for_analysis(data_list)
    for( curr_data in curr_data_list ) {
      dat <- curr_data[(curr_data[[doy_col]] >= start_day & curr_data[[doy_col]] <= end_day), c(year_col, rain_col,month_col,doy_col)]

      if(missing(upper_lim)){
        upper_lim = max(dat[[rain_col]], na.rm = na.rm)
      }
      for (i in 1:nrow(dat)){
        if(dat[[rain_col]][i]<lower_lim || dat[[rain_col]][i]>upper_lim){
          dat[[rain_col]][i]<-NA
        }
      }
      dat[[month_col]] <- month(dat[[month_col]], label=T)  
      ss <- dcast(dat,  dat[[year_col]] ~ dat[[month_col]], summ, value.var = rain_col, na.rm = na.rm)
      names(ss)[names(ss)=="dat[[year_col]]"] <- "Year"

      for(i in 2:(ncol(ss))){
        ss[,i] = round(ss[,i], decimals)
        sa = which(ss[,i] %in% c(NA, -Inf, NaN))
        ss[sa,i]<-"*"  
      }
      
      return(ss)
    }
  }
  
} 
)
