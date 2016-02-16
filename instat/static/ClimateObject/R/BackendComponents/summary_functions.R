# summary function labels
sum_label="summary_sum"
mode_label="summary_mode"
count_label="summary_count"
count_over_threshold_label="summary_count_over_threshold"
sd_label = "summary_sd"
median_label = "summary_median"
range_label = "summary_range"
count_label = "summary_count"
min_label="summary_min"
max_label="summary_max"
mean_label="summary_mean"
running_summary_label="summary_running_summary"
start_of_rain_summary_label="summary_start_of_rain"
end_of_rain_summary_label="summary_end_of_rain"

# list of summary functions
summaries_list=c(sum_label, mode_label, count_label, sd_label, median_label, range_label, count_label, min_label, max_label, mean_label, running_summary_label, start_of_rain_summary_label, end_of_rain_summary_label, count_over_threshold_label)

summary_mode <- function(x,...) {
  ux <- unique(x)
  ux[which.max(tabulate(match(x, ux)))]
}

summary_mean <- function (x, na.rm = FALSE,...) {
  if( length(x)==0 || (na.rm && length(x[!is.na(x)])==0) ) return(NA)
  else mean(x, na.rm=na.rm,...)
}

summary_sum <- function (x, na.rm = FALSE,...) {
  sum(x, na.rm = FALSE)
} 

summary_count <- function(x,...) {
  length(x)
}

summary_sd <- function(x, na.rm = FALSE,...) {
  return(sd(x,...))
}

summary_max <- function (x, na.rm = FALSE,...) {
  if( length(x)==0 || (na.rm && length(x[!is.na(x)])==0) ) return(NA)
  else max(x, na.rm = na.rm)
} 

summary_min <- function (x, na.rm = FALSE,...) {
  if( length(x)==0 || (na.rm && length(x[!is.na(x)])==0) ) return(NA)
  else min(x, na.rm = na.rm)
} 

#get the range of the data
summary_range <- function(x, na.rm = TRUE, ...){
  max(x, na.rm = na.rm) - min(x, na.rm = na.rm)  
}

# median function
summary_median <- function(x, ...) {
  odd.even <- length(x)%%2
  if (odd.even == 0)(sort(x)[length(x)/2] + sort(x)[1 + length(x)/2])/2
  else sort(x)[ceiling(length(x)/2)]
}

#in progress with return and print 
# summary_count <- function(x, proportions = c(120,140,160,180,200), na.rm = TRUE, ...){
#   count = c()
#   for (i in 1:length(proportions)){
#     count[i] = sum(x <= proportions[i], na.rm = na.rm)
#     return(paste("count <=", proportions[i], "is", count[i]))
#   }
# }

# results as percent of data (in progress)
summary_percents = function(x,data, proportions = c(120,140,160,180,200), na.rm = FALSE, ...){
  count = c()
  percent = c()
  for (i in 1:length(proportions)){
    count[i] = sum(x <= proportions[i], na.rm = na.rm)
    percent[i] = (count[i]/nrow(data))*100
    print(paste("% of data <=", proportions[i], "is", percent[i]))
  }
}

# proportion of data (in progress)
summary_proportions <- function(x, data, proportions = c(120,140,160,180,200), na.rm = FALSE, ...){
  count = c()
  proportion = c()
  for (i in 1:length(proportions)){
    count[i] = sum(x <= proportions[i], na.rm = na.rm)
    proportion[i] = (count[i]/nrow(data))
    print(paste("proportion <=", proportions[i], "is", proportion[i]))
  }
}

summary_running_summary <- function(data, total_days = 1, func = max_label, na.rm = FALSE,...) {
  h=c()
  for (i in 1:(length(data)-total_days+1)){
    h[i] <- match.fun(sum_label)(data[i:(i+total_days-1)], na.rm = na.rm)
  }
  
 # print(h)
  if(missing(func)) return(h)
  else {
    func = match.fun(func)
    return(func(h, na.rm = na.rm))
  }
}

summary_start_of_rain <- function(data, earliest_day = 92, total_days = 2, rain_total = 20, dry_spell_condition = FALSE, threshold = 0.85, dry_length = 30, dry_days = 10,...) {
  # initialize to 0 incase conditions are never met
  start_of_rain = 0
  
  # initialize current earliest day
  curr_earliest_day = earliest_day
  
  # if dry spell required use the simple sum_check to get start of the rain
  if(!dry_spell_condition) start_of_rain = sum_check(data, curr_earliest_day, total_days, rain_total)[1]
  
  else {
    # If sum and dry spell conditions are required
    
    # indicates whether both conditions have been met and 
    # start of rain has been found
    # initialize to FALSE
    found = FALSE
    
    num_rows = nrow(data)
    
    # while start of the rain has not been found and our earliest day to check is not too
    # close to the end of year we continue looking for the start of the rain
    # if the dry_length is greater than the remaining number of rows
    # we will not be able to check for dry spells so we cannot get a start of the rain
    
    while( !found && sum(data[[1]]==curr_earliest_day)>0 && dry_length <= num_rows -  which(data[[1]]==curr_earliest_day) ) {
      # get the first day after earliest_day which is over rain_total
      day = sum_check(data, curr_earliest_day, total_days, rain_total)[1]
      
      # if the dry_length is greater than the remaining number of rows
      # we can no longer check for dry spells so end the loop
      # also if day is missing, end the loop.
      # NA will be returned
      if( is.na(day) || dry_length > num_rows - which(data[[1]]==day) ) break
      
      # start day to check for a dry spell is the day after the day found by sum_check
      start_row = which(data[[1]]==day+1)
      
      # if there is no dry spell we have found the start of the rain
      # found = TRUE will mean the loop does not run again
      if( !dry_spell_check(data[start_row:num_rows, 2], dry_length, dry_days, threshold) ) {
        start_of_rain = day
        found = TRUE
      }
      else {
        # in the worst case there was a dry spell of length dry_days start after day.
        # The next check should begin after this potential dry spell.
        # if this day is beyond the end of the year, exit the loop to return NA.
        if(is.na(which(data[[1]]==day + dry_length))) break
        else curr_earliest_day = day + dry_length
      }
    }
  }
  start_of_rain
}

summary_end_of_rain <- function(data, earliest_day = 228,...) {
  data = data[data[2] >= earliest_day, ]

  water_balance = data[[1]]
  dos = data[[2]]

  # default value if end of season not found
  end_rain = NA
  
  # subsetting above may give an empty data frame
  if(nrow(data)==0) return(end_rain)
  
  for(i in 1:nrow(data)) {
    if( !is.na(water_balance[i]) 
        && water_balance[i] == 0 ) {  
      end_rain = dos[i]
      break
    }
  }
  end_rain
}

summary_count_over_threshold <- function(x, na.rm = FALSE, threshold = 0.85, strict_ineq = TRUE,...) {
  if(strict_ineq) return(sum(x>threshold, na.rm=na.rm))
  else return(sum(x>=threshold, na.rm=na.rm))
  
}