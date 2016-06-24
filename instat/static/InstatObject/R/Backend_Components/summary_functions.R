#Methods temporarily here to avoid conflicts
data_object$set("public", "merge_data", function(new_data, by = NULL, type = "left", match = "all") {
  self$set_data(join(private$data, new_data, by, type, match))
  self$append_to_changes(Merged_data)
  self$add_defaults_meta()
}
)

instat_object$set("public", "append_summaries_to_data_object", function(out, data_name, columns_to_summarise, summaries, factors = c(), summary_name) {
  if(!is.character(data_name)) stop("data_name must be of type character")
  exists = FALSE
  for(data_obj in self$get_data_objects()) {
    if(data_obj$is_metadata(summarised_from_label) 
       && data_obj$get_metadata(summarised_from_label)[[1]] == data_name 
       && setequal(data_obj$get_metadata(summarised_from_label)[[2]],factors)) {
      exists = TRUE
      summary_obj = data_obj
      break
    }
  }
  if(exists) summary_obj$merge_data(out, by = factors, type = "inner", match = "first")
  else {
    summary_data = list()
    if(missing(summary_name)) summary_name = paste(data_name, "by", paste(factors, collapse = "-"), sep="_")
    summary_name = make.names(summary_name)
    summary_data[[summary_name]] = out
    self$import_data(summary_data)
    summary_obj = self$get_data_objects(summary_name)
    summary_obj$append_to_metadata(summarised_from_label, list(from = data_name, by = factors))
    summary_obj$append_to_metadata(key_label, factors)
  }
} 
)

instat_object$set("public", "calculate_summary", function(data_name, columns_to_summarise, summaries, factors = c(), store_results = TRUE, drop = FALSE, return_output = FALSE, summary_name,...) {
  # itermediate methd needed here apply_calculation which calls calculate_summary when calculation type = summary
  # always use apply_calculation to run calculation e.g. type = filter, stack
  out = self$get_data_objects(data_name)$calculate_summary(columns_to_summarise = columns_to_summarise, summaries = summaries, factors = factors, store_results = store_results, drop = drop, ... = ...)
  if(store_results) self$append_summaries_to_data_object(out, data_name, columns_to_summarise, summaries, factors, summary_name)
  if(return_output) return(out)
}
)

data_object$set("public", "calculate_summary", function(columns_to_summarise, summaries, factors = c(), store_results = TRUE, drop = FALSE,...) {
  if(missing(columns_to_summarise)) stop("columns_to_summarise must be specified")
  if(missing(summaries)) stop("summaries must be specified")
  if(!all(columns_to_summarise %in% names(private$data))) stop(paste("Some of the columns from:",paste(columns_to_summarise, collapse = ","),"were not found in the data."))
  if(!all(summaries %in% all_summaries)) stop(paste("Some of the summaries from:",paste(summarise, collapse = ","),"were not recognised."))
  if(!all(factors %in% names(private$data))) stop(paste("Some of the factors:","c(",paste(factors, collapse = ","),") were not found in the data."))
  
  combinations = expand.grid(summaries,columns_to_summarise)
  if(length(summaries)==1) {
    if(length(columns_to_summarise) == 1) out = ddply(private$data, factors, function(x) match.fun(summaries)(x[[columns_to_summarise]],...), .drop = drop)
    else out = ddply(private$data, factors, function(x) sapply(columns_to_summarise, function(y) match.fun(summaries)(x[[y]]),...), .drop = drop)
  }
  else {
    if(length(columns_to_summarise) == 1) out = ddply(private$data, factors, function(x) sapply(summaries, function(y) match.fun(y)(x[[columns_to_summarise]],...)), .drop = drop)
    else out = ddply(private$data, factors, function(x) apply(combinations, 1, FUN = function(y) match.fun(y[[1]])(x[[y[[2]]]],...)), .drop = drop)
  }
  names(out)[-(1:length(factors))] <- apply(combinations, 1, paste, collapse="_")
  return(out)
}
)

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