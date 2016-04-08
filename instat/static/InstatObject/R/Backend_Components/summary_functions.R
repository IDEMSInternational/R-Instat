#Methods temporarily here to avoid conflicts
instat_obj$methods(calculate_summary = function(data_name, columns_to_summarise, summaries, factors, store_results = TRUE, drop = FALSE, return_output = TRUE,...) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  if(!data_name %in% names(data_objects)) stop(paste("dataframe: ", data_name, " not found"))
  
  out = data_objects[[data_name]]$calculate_summary(columns_to_summarise = columns_to_summarise, summaries = summaries, factors = factors, store_results = store_results, drop = drop, ... = ...)
  if(return_output) return(out)
} 
)

data_obj$methods(calculate_summary = function(columns_to_summarise, summaries, factors, store_results = TRUE, drop = FALSE,...) {
  if(!all(columns_to_summarise %in% names(data))) stop(paste("Some of the columns from:",columns_to_summarise,"were not found in the data."))
  if(missing(summaries)) stop("summaries must be specified")
  if(!all(summaries %in% all_summaries)) stop(paste("Some of the summaries from:",summaries,"were not recognised."))
  if(!all(factors %in% names(data))) stop(paste("Some of the factors:",factors,"were not found in the data."))
  
  if(length(summaries)==1) {
    if(length(columns_to_summarise) == 1) out = ddply(data, factors, function(x) match.fun(summaries)(x[[columns_to_summarise]],...), .drop = drop)
    else out = ddply(data, factors, function(x) sapply(columns_to_summarise, function(y) match.fun(summaries)(x[[y]]),...), .drop = drop)
  }
   else {
     if(length(columns_to_summarise) == 1) out = ddply(data, factors, function(x) sapply(summaries, function(y) match.fun(y)(x[[columns_to_summarise]],...)), .drop = drop)
     else out = ddply(data, factors, function(x) apply(expand.grid(summaries,columns_to_summarise), 1, FUN = function(y) match.fun(y[[1]])(x[[y[[2]]]],...)), .drop = drop)
   }
  return(out)
}
)

# climate$methods(summary_calculation = function(data_list = list(), summary_time_period, required_summaries = list(), required_variables = list(), subyearly_factor, column_names = rep(list(rep("",length(required_summaries))),length(required_variables)), replace = FALSE, ...) {
#        if(length(curr_var_name)==1) out[[curr_label]] = as.vector(by(curr_data[[curr_var_name]], curr_factors, match.fun(single_summary), ...))
#         else out[[curr_label]] = as.vector(by(curr_data[curr_var_name], curr_factors, match.fun(single_summary), ...))
#         # TODO make get_summary_label a climate method
#         # TODO think how to use get_summary_label when required_variables[[i]] is a list
#         labels[[curr_label]] = .self$get_summary_name(summary_time_period, data_obj)$get_summary_label(required_variables[[i]][[1]], single_summary, curr_definition)
#         j = j + 1
#       }
#       i = i + 1
#     }
#     mapply(function(x,y) .self$append_to_summary(time_period = summary_time_period, data_obj = data_obj, col_data = out[[x]], col_name = x, label = y, replace = replace), names(out), labels)
#   }
#   
# }
# )

# summary function labels
sum_label="summary_sum"
mode_label="summary_mode"
count_label="summary_count"
sd_label = "summary_sd"
median_label = "summary_median"
range_label = "summary_range"
min_label="summary_min"
max_label="summary_max"
mean_label="summary_mean"


# list of all summary function names
all_summaries=c(sum_label, mode_label, count_label, sd_label, median_label, range_label, min_label, max_label, mean_label)

summary_mode <- function(x,...) {
  ux <- unique(x)
  ux[which.max(tabulate(match(x, ux)))]
}

summary_mean <- function (x, na.rm = FALSE, trim = 0,...) {
  if( length(x)==0 || (na.rm && length(x[!is.na(x)])==0) ) return(NA)
  else return(mean(x, na.rm=na.rm, trim = trim))
}

summary_sum <- function (x, na.rm = FALSE,...) {
  sum(x, na.rm = na.rm)
} 

summary_count <- function(x,...) {
  length(x)
}

summary_sd <- function(x, na.rm = FALSE,...) {
  return(sd(x,na.rm = na.rm))
}

summary_max <- function (x, na.rm = FALSE,...) {
  #TODO This prevents warning and -Inf being retured. Is this desirable?
  if( length(x)==0 || (na.rm && length(x[!is.na(x)])==0) ) return(NA)
  else max(x, na.rm = na.rm)
} 

summary_min <- function (x, na.rm = FALSE,...) {
  #TODO This prevents warning and Inf being retured. Is this desirable?
  if( length(x)==0 || (na.rm && length(x[!is.na(x)])==0) ) return(NA)
  else min(x, na.rm = na.rm)
} 

#get the range of the data
summary_range <- function(x, na.rm = FALSE, ...){
  max(x, na.rm = na.rm) - min(x, na.rm = na.rm)  
}

# median function
summary_median <- function(x, na.rm = FALSE,...) {
  median(x, na.rm = na.rm)
}