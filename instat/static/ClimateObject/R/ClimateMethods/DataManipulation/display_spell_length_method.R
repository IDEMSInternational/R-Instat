#==================================================================================================
# Climatic Extremes
#' @title Spell Length Table.
#' @name display_spell_length
#' @author Fanuel and Steve 2015 (AMI)

#' @description  
#' Displays the spell length table per year per month.
#' @param col_name  The name of the spell length column.  
#' @param months_list The names of the months.
#' @param day_display The name of the first column in th table.
#' @param na.rm  A logical indicating whether missing values should be removed.
#' @examples
#' ClimateObj <- climate( data_tables = list( dataframe=dataframe ), date_formats = list( "%m/%d/%Y" ) )
#' Default dateformats: "%Y/%m/%d"
#' where "data" is a data.frame containing the desired data to be computed.
#' climateObj$display_spell_length().
#' @return return yearly tables of spell lengths.
climate$methods(display_spell_length = function(data_list = list(), col_name = "spell length", na.rm=TRUE, threshold=0.85, 
                                                months_list = month.abb, day_display = "Day"){
  
  data_list=add_to_data_info_required_variable_list(data_list, list(rain_label))
  
  data_list=add_to_data_info_time_period(data_list, daily_label)
  
  rettables = list()
  
  climate_data_objs = get_climate_data_objects(data_list)
  
  for(data_obj in climate_data_objs) {
    
    if( !(data_obj$is_present(spell_length_label)) ) {
      data_obj$add_spell_length_col(col_name=col_name, threshold = threshold)
    }
    spell_length_col = data_obj$getvname(spell_length_label)

    if( !(data_obj$is_present(year_label) && data_obj$is_present(month_label) && data_obj$is_present(day_label)) ) {
      data_obj$add_year_month_day_cols()
    }
    
    if( !(data_obj$is_present(season_label)) ) data_obj$add_doy_col()
    
    season_col = data_obj$getvname( season_label )
    month_col = data_obj$getvname(month_label)
    day_col = data_obj$getvname(day_label)
    
    curr_data_list = data_obj$get_data_for_analysis(data_list)
    
    for( curr_data in curr_data_list ) {
      factor_col = factor(curr_data[[season_col]], levels = unique(curr_data[[season_col]]), ordered = TRUE)
      for (k in 1:length(curr_data[[spell_length_col]])){
        if (is.na(curr_data[[spell_length_col]][[k]])){
          curr_data[[spell_length_col]][[k]]="m" 
        }        
      }

      tables = list()
      years_split <- split(curr_data, factor_col)
      
      # initialize the counter
      i = 1
      for ( single_year in years_split ) {
        tables[[i]] <- dcast(single_year, single_year[[ day_col ]]~single_year[[ month_col ]], value.var = spell_length_col)
        
        end = length(colnames(tables[[i]]))
        names(tables[[i]])[ 1 ] <- day_display
        colnames(tables[[i]])[2:end] <- months_list[1:end-1]
        
        Day = " "
        dat1 = tables[[i]][,2:13]
        dat2 = sapply(dat1[,1:12], as.numeric)
        summ =suppressWarnings(as.data.frame(lapply(as.data.frame(dat2), max, na.rm = na.rm)))
        overall_max = c("Maximum",rep(NA,10),"(Overall:",paste(max(summ, na.rm=na.rm),")",sep = ""))
        tables[[i]] = rbind(tables[[i]], overall_max)
        tables[[i]] = join(tables[[i]], cbind(Day,summ), by = c("Day",month.abb), type = "full", match = "all")
        missing = c(" ",rep(NA,13))
        
        for(j in 2:13){
          sa = which(tables[[i]][,j] %in% 0)
          sb = which(tables[[i]][,j] %in% NA)
          sc = which(tables[[i]][,j] %in% -Inf)
          sf = which(tables[[i]][,j] %in% "m")
          tables[[i]][sa,j]<-"--"
          tables[[i]][sb,j]<-" "
          tables[[i]][sc,j]<-"m"
          missing[j] <- length(sf)
        }
        overall_miss_max = c("Missing",rep(" ",10),"(Overall:",paste(sum(as.numeric(missing[2:13]), na.rm=na.rm),")",sep = ""))
        if(max(as.numeric(missing[2:13]), na.rm=na.rm)>0){
          tables[[i]] = rbind(tables[[i]], overall_miss_max, missing)
        }
        i = i + 1
      }

      names(tables) <- names(years_split)
      rettables[[data_obj$get_station_data( curr_data, station_label )]] = tables
    }
    
    return(tables)
    
  }
  
}
)