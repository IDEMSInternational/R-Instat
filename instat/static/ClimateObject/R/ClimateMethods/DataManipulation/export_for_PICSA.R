#' Export data for PICSA
#' @title Output data in the form needed by PICSA.
#' @name export_for_PICSA
#' @author Abib Duut 2015
#' @description \code{export_for_PICSA} 
#' creates a file with data in the format required for PICSA. 





climate$methods(export_for_PICSA =function(data_list = list(), month_start = c(5,11), number_month = 5, threshold = use_default_label, 
                                            summaries = list(sum_label, count_label, mean_label),
                                            use_threshold_as_lower = c(FALSE, TRUE, TRUE), strict_threshold = FALSE,
                                            longest_dry_spell = TRUE, longest_dry_spell_name = "Longest dry spell", spell_length_name = "Spell Length",
                                            na.rm = FALSE, replace = FALSE, month_col_names = list("SeasonA","SeasonB"), 
                                            summary_col_names = c("Total Rainfall", "Number of rainy days", "Mean rain per rainy day"),...) 
    

{  
      #first call the seasonal summary method with the right agruments
      .self$seasonal_summary.rain(data_list = data_list, month_start = month_start, number_month =number_month, threshold = threshold, summaries = summaries, use_threshold_as_lower = use_threshold_as_lower, strict_threshold = strict_threshold,longest_dry_spell = longest_dry_spell, longest_dry_spell_name = longest_dry_spell_name, spell_length_name = spell_length_name, na.rm = na.rm, replace = replace, month_col_names = month_col_names, summary_col_names = summary_col_names)
      .self$add_start_rain(col_name="Start_of_Rain_Season_A")
      .self$add_start_rain(col_name="Start_of_Rain_Season_B")
      .self$add_end_rain(col_name="End_of_Rain_Season_A")
      .self$add_end_rain(col_name="End_of_Rain_Season_B")
      
      # date time period is "yearly"
      data_list = add_to_data_info_time_period(data_list, yearly_label)
      # a list of climate data objects
      climate_data_objs = get_climate_data_objects(data_list)
     	  for(data_obj in climate_data_objs){
     	        data_name= data_obj$get_meta(data_name_label)
	            curr_data_list = data_obj$get_data_for_analysis(data_list)
	      
		          for( curr_data in curr_data_list ) {
		              for (i in 1:length(summary_col_names) ){
		                  for (j in  1:length(month_col_names)){
		                        names(curr_data)[names(curr_data) == paste(month_col_names[[j]],summary_col_names[[i]])] <-paste(summary_col_names[[i]], month_col_names[[j]], sep=" ")
		                        uninterested_col<-names(curr_data) %in% c("Date","Number of Rainy Days","Mean Rain per Rainy Day","Number of rainy days SeasonA", "SeasonA Mean rain per rainy day", "Number of rainy days SeasonB","SeasonB Mean rain per rainy day","SeasonA Longest dry spell", "SeasonB Longest dry spell" )
                            curr_data<-curr_data[!uninterested_col]		                  
                            
      		                  #,select=c("Year","Total Rain","Total Rainfall SeasonA","Total Rainfall SeasonB")
                            curr_data$Length_of_Season_A<-curr_data$End_of_Rain_Season_A - curr_data$Start_of_Rain_Season_A
                            curr_data$Length_of_Season_B<-curr_data$End_of_Rain_Season_B - curr_data$Start_of_Rain_Season_B
                            View(head(curr_data))
      		                  write.csv(curr_data, file=paste(data_name,".csv"),sep = ",",col.names=T, row.names = F,quote = F, na="*")            
                              # }    
    		          }
              }
          }  
    	  }
    }
)









    






