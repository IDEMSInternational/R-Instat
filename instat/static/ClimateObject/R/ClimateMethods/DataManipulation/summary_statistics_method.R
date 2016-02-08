climate$methods(summary_statistics = function(data_list=list(),interest_var, proportions=c(),counts=TRUE, percents=FALSE,
                                              data_period_label=daily_label, digits=4, statistics=TRUE, percentiles=c(),
                                              convert=FALSE,na.rm=FALSE,append=TRUE,output_name="my_output.txt")
  
{    
  if (!is.list(interest_var)){
    interest_var=list(interest_var)
  }  
  data_list=add_to_data_info_required_variable_list(data_list, interest_var)
  data_list=c(data_list,convert_data=convert)
  data_list=add_to_data_info_time_period(data_list, data_period_label)
  climate_data_objs_list = get_climate_data_objects(data_list)  
  for(data_obj in climate_data_objs_list) {
    data_name = data_obj$get_meta(data_name_label)
    # Access data in methods
    curr_data_list = data_obj$get_data_for_analysis(data_list)
    #print(curr_data_list)
    for( curr_data in curr_data_list ) {
      
      #Check if the column of interest is inputted
      #---------------------------------------------------------------------------------#      
      for (j in 1:length(interest_var)){
        interest_col=data_obj$getvname(interest_var[[j]])
        
        #---------------------------------------------------------------------------------#
        sink(output_name,append=append,type="output")      
        print(paste("summary statistics for",interest_col,"in",data_name,"data"))
        
        if (statistics==TRUE){
          #-------------------------------------------------------------------------------#
          #get the number of observations 
          #-------------------------------------------------------------------------------#
          print(paste(" data No. of observations:",  nrow(curr_data)))
          
          #-------------------------------------------------------------------------------#
          #get the minimum, mean, median and the maximum from the column of interest
          #-------------------------------------------------------------------------------#
          print(summary(curr_data[[interest_col]]))
          
          #------------------------------------------------------------------------------#
          #get the range of the data
          #------------------------------------------------------------------------------#
          print(paste("Range:", max(curr_data[[interest_col]], na.rm = na.rm) - min(curr_data[[interest_col]], na.rm = na.rm) ))
          
          #-------------------------------------------------------------------------------#
          #calculate the standard deviation
          #-------------------------------------------------------------------------------#
          print(paste("sd.deviation:", round(sd(curr_data[[interest_col]], na.rm = na.rm), digits =digits )))
          
          #-------------------------------------------------------------------------------#
          #calculate the percentiles
          #-------------------------------------------------------------------------------#
          if( !(length( percentiles ) == 0 ) ) {
            print(quantile(curr_data[[interest_col]], percentiles,na.rm=na.rm))
          }
        }
        
        #---------------------------------------------------------------------------------#
        #Initializing empty vectors and looping to get the counts and percentages 
        #---------------------------------------------------------------------------------#
        count=c()
        percent=c()
        for (i in 1:length(proportions)){
          
          #---------------------------------------------------------------------------------#
          #returns count only if true
          #---------------------------------------------------------------------------------#
          if (counts==TRUE){
            count[i]=sum(curr_data[[interest_col]]<=proportions[i], na.rm = na.rm)
            print(paste("count <=", proportions[i], "is", count[i]))
          }
          
          #----------------------------------------------------------------------------------#
          #returns percents only if true
          #----------------------------------------------------------------------------------#
          if (percents==TRUE){
            percent[i]=round((count[i]/nrow(curr_data))*100,digits=digits)
            print(paste("% of data <=", proportions[i], "is", percent[i]))
          }
        }       
      }
      sink()      
    }
  } 
}
)