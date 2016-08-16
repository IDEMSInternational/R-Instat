#Methods temporarily here to avoid conflicts
data_object$set("public", "merge_data", function(new_data, by = NULL, type = "left", match = "all") {
  #TODO how to use match argument with dplyr join functions
  old_metadata <- attributes(private$data)
  curr_data <- self$get_data_frame(use_current_filter = FALSE)

  if(type == "left") {
    new_data <- left_join(curr_data, new_data, by)
  }
  else if(type == "right") {
    new_data <- right_join(curr_data, new_data, by)
  }
  else if(type == "full") {
    new_data <- full_join(curr_data, new_data, by)
  }
  else if(type == "inner") {
    new_data <- inner_join(curr_data, new_data, by)
  }
  else stop("type must be one of left, right, inner or full")
  self$set_data(new_data)
  self$append_to_changes(Merged_data)
  for(name in names(old_metadata)) {
    if(!name %in% c("names", "class", "row.names")) {
      self$append_to_metadata(name, old_metadata[[name]])
    }
  }
  self$append_to_metadata(is_calculated_label, TRUE)
  self$add_defaults_meta()
  self$add_defaults_variables_metadata()
}
)

instat_object$set("public", "append_summaries_to_data_object", function(out, data_name, columns_to_summarise, summaries, factors = c(), summary_name, calc, calc_name = "") {
  if(!is.character(data_name)) stop("data_name must be of type character")
  factors_list <- factors
  names(factors_list) <- factors
  link_calc <- calculation$new(type = "summary", parameters = factors_list)
  link_obj <- link$new(from_data_frame = data_name, type = keyed_link_label, calculation = link_calc)
  exists = FALSE
  for(data_obj in self$get_data_objects()) {
    link_obj$to_data_frame <- data_obj$get_metadata(data_name_label)
    if(self$link_exists(link_obj)) {
      exists = TRUE
      summary_obj <- data_obj
      summary_name <- summary_obj$get_metadata(data_name_label)
      break
    }
  }
  if(exists) {
    #temp fix to avoid error merging data with overlapping names
    curr_data <- summary_obj$get_data_frame(use_current_filter = FALSE)
    for(i in 1:length(names(out))) {
      curr_col_name <- names(out)[[i]]
      if((!curr_col_name %in% factors) && curr_col_name %in% names(curr_data)) {
        names(out)[[i]] <- next_default_item(curr_col_name, names(curr_data))
      }
    }
    summary_obj$merge_data(out, by = factors, type = "inner", match = "first")
  }
  else {
    summary_data <- list()
    if(missing(summary_name) || is.na(summary_name)) summary_name <- paste(data_name, "by", paste(factors, collapse = "_"), sep="_")
    summary_name <- make.names(summary_name)
    summary_name <- next_default_item(summary_name, self$get_data_names(), include_index = FALSE)
    summary_data[[summary_name]] <- out
    self$import_data(summary_data)
    summary_obj <- self$get_data_objects(summary_name)
    summary_obj$add_key(factors)
    # add link
    link_obj$to_data_frame <- summary_name
    self$add_link(link_obj)
  }
  
  calc_out_columns <- names(out)[-(1:length(factors))]
  dependent_cols <- list(calc_out_columns)
  names(dependent_cols) <- summary_name
  dependencies_cols <- list(columns_to_summarise)
  names(dependencies_cols) <- data_name
  print(summary_obj$get_data_frame())
  calc_name <- self$save_calculation(summary_name, calc)
  self$append_to_variables_metadata(data_name, columns_to_summarise, has_dependants_label, TRUE)
  self$add_dependent_columns(data_name, columns_to_summarise, dependent_cols)
  self$append_to_variables_metadata(summary_name, calc_out_columns, is_calculated_label, TRUE)
  self$append_to_variables_metadata(summary_name, calc_out_columns, calculated_by_label, calc_name)
  if(!exists) {
    self$append_to_variables_metadata(summary_name, names(out)[1:length(factors)], is_calculated_label, TRUE)
    self$append_to_variables_metadata(summary_name, names(out)[1:length(factors)], calculated_by_label, calc_name)
  }
  self$append_to_variables_metadata(summary_name, calc_out_columns, dependencies_label, dependencies_cols)
} 
)

instat_object$set("public", "calculate_summary", function(data_name, columns_to_summarise, summaries, factors = c(), store_results = TRUE, drop = FALSE, return_output = FALSE, summary_name = NA, add_cols = c(), filters = list(), ...) {
  calculated_from = list()
  calculated_from[[1]] <- list(data_name = data_name, columns = columns_to_summarise)
  #TODO Change this to store sub_calculations for each column
  calc <- calculation$new(type = "summary", parameters = list(data_name = data_name, columns_to_summarise = columns_to_summarise, summaries = summaries, factors = factors, store_results = store_results, drop = drop, return_output = return_output, summary_name = summary_name, add_cols = add_cols, filters = filters, ... = ...), calculated_from = calculated_from)
  results <- self$apply_calculation(calc)
  if(!is.null(results)) return(results)
}
)

data_object$set("public", "calculate_summary", function(calc, ...) {
  columns_to_summarise = calc[["parameters"]][["columns_to_summarise"]]
  summaries = calc[["parameters"]][["summaries"]]
  factors = calc[["parameters"]][["factors"]]
  drop = calc[["parameters"]][["drop"]]
  add_cols = calc[["parameters"]][["add_cols"]]
  filters = calc[["filters"]]
  
  if(missing(columns_to_summarise)) stop("columns_to_summarise must be specified")
  if(missing(summaries)) stop("summaries must be specified")
  # Removed since curr_data_filter has same columns
  # curr_data_full <- self$get_data_frame(use_current_filter = FALSE)
  # if(!all(columns_to_summarise %in% names(curr_data_full))) stop(paste("Some of the columns from:",paste(columns_to_summarise, collapse = ","),"were not found in the data."))
  # if(!all(summaries %in% all_summaries)) stop(paste("Some of the summaries from:",paste(summaries, collapse = ","),"were not recognised."))
  # if(!all(factors %in% names(curr_data_full))) stop(paste("Some of the factors:","c(",paste(factors, collapse = ","),") were not found in the data."))
  combinations = expand.grid(summaries,columns_to_summarise)
  # Removed to only keep general case
  # if(length(summaries)==1) {
  #   if(length(columns_to_summarise) == 1) out = ddply(curr_data_filter, factors, function(x) match.fun(summaries)(x[[columns_to_summarise]],...), .drop = drop)
  #   else out = ddply(curr_data_filter, factors, function(x) sapply(columns_to_summarise, function(y) match.fun(summaries)(x[[y]],...)), .drop = drop)
  # }
  # else {
  #   if(length(columns_to_summarise) == 1) out = ddply(curr_data_filter, factors, function(x) sapply(summaries, function(y) match.fun(y)(x[[columns_to_summarise]],...)), .drop = drop)
  #   else out = ddply(curr_data_filter, factors, function(x) apply(combinations, 1, FUN = function(y) match.fun(y[[1]])(x[[y[[2]]]],...)), .drop = drop)
  # }
  i = 1
  out = list()
  if(length(filters) > 0) {
    
  }
  for(temp_filter in filters) {
    curr_data_filter <- self$get_data_frame(use_current_filter = TRUE, filter_name = temp_filter$name)
    if(!all(columns_to_summarise %in% names(curr_data_filter))) stop(paste("Some of the columns from:",paste(columns_to_summarise, collapse = ","),"were not found in the data."))
    if(!all(summaries %in% all_summaries)) stop(paste("Some of the summaries from:",paste(summaries, collapse = ","),"were not recognised."))
    if(!all(factors %in% names(curr_data_filter))) stop(paste("Some of the factors:","c(",paste(factors, collapse = ","),") were not found in the data."))
    
    out[[i]] <- ddply(curr_data_filter, factors, function(x) apply(combinations, 1, FUN = function(y) {
      na.rm <- missing_values_check(x[[y[[2]]]])
      if("na.rm" %in% names(list(...))) stop("na.rm should not be specified. Use xxx to specify missing values handling.")
      match.fun(y[[1]])(temp_data, add_cols = x[add_cols], na.rm = na.rm, ...)
    }
    ), .drop = drop)
    names(out[[i]])[-(1:length(factors))] <- get_summary_calculation_names(calc, summaries, columns_to_summarise, temp_filter)
    if(i > 1) {
      out[[i]][1:length(factors)] <- NULL
      out[[i]] <- out[[i]][-(1:length(factors))]
    }
    i = i + 1
  }
  out <- bind_cols(out)
  return(out)
}
)

get_summary_calculation_names <- function(calc, summaries, columns_to_summarise, filter) {
  return(apply(expand.grid(substring(summaries, 9), columns_to_summarise, filter$name), 1, paste, collapse="_"))
}

missing_values_check <- function(x) {
  return(FALSE)
}

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

summary_mean <- function (x, add_cols, weights="", na.rm = FALSE, trim = 0,...) {
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