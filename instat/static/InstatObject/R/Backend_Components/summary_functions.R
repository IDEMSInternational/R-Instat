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
  #TODO will column/row count be correct here?
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
  
  exists = FALSE
  if(self$link_exists_from(data_name, factors)) {
    summary_name <- self$get_linked_to_data_name(data_name, factors)
    summary_obj <- self$get_data_objects(summary_name)
    exists <- TRUE
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
    # TODO Should the be done here or in add_link?
    #summary_obj$add_key(factors)
    names(factors) <- factors
    self$add_link(data_name, summary_name, factors, keyed_link_label)
  }
  
  calc_out_columns <- names(out)[-(1:length(factors))]
  dependent_cols <- list(calc_out_columns)
  names(dependent_cols) <- summary_name
  dependencies_cols <- list(columns_to_summarise)
  names(dependencies_cols) <- data_name
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

instat_object$set("public", "calculate_summary", function(data_name, columns_to_summarise = NULL, summaries, factors = c(), store_results = TRUE, drop = TRUE, na.rm = FALSE, return_output = FALSE, summary_name = NA, ...) {
  if(!store_results) {
    save <- 0
  }
  else {
    save <- 2
  } 
  calculated_from <- as.list(factors)
  names(calculated_from) <- rep(data_name, length(factors))
  calculated_from <- as.list(calculated_from)
  factor_by <- instat_calculation$new(type = "by", calculated_from = calculated_from)
    
  sub_calculations <- list()
  
  if(is.null(columns_to_summarise)) {
    for(summary_type in summaries) {
      summary_calculation <- instat_calculation$new(type = "summary", result_name = summary_type,
                                                    function_exp = paste0(summary_type, "()"), save = save)
      sub_calculations[[length(sub_calculations) + 1]] <- summary_calculation
    }
  }
  else {
    for(column_name in columns_to_summarise) {
      calculated_from <- list(column_name)
      names(calculated_from) <- data_name
      for(summary_type in summaries) {
        summary_calculation <- instat_calculation$new(type = "summary", result_name = paste0(summary_type, "_", column_name),
                                                      function_exp = paste0(summary_type, "(", column_name, ", na.rm =", na.rm, ")"),
                                                      calculated_from = calculated_from, save = save)
        sub_calculations[[length(sub_calculations) + 1]] <- summary_calculation
      }
    }
  }
  combined_calc_sum <- instat_calculation$new(type="combination", sub_calculations = sub_calculations, manipulations = list(factor_by))
  out <- self$apply_instat_calculation(combined_calc_sum)
  if(return_output) return(out$data)
}
)

instat_object$set("public", "summary", function(data_name, columns_to_summarise, summaries, factors = c(), store_results = FALSE, drop = FALSE, return_output = FALSE, summary_name = NA, add_cols = c(), filter_names = c(), ...) {
  calculated_from = list()
  calculated_from[[1]] <- list(data_name = data_name, columns = columns_to_summarise)
  #TODO Change this to store sub_calculations for each column
  alltypes_collection <- c(count_non_missing_label, count_missing_label, count_label, mode_label)
  numeric_collection <- c(count_non_missing_label, count_missing_label, count_label, mode_label, min_label, max_label, mean_label, sd_label, range_label, median_label, sum_label, var_label)
  factor_collection <-  c(count_non_missing_label, count_missing_label, count_label, mode_label) #maximum and minimum labels should be added when we distinguish ordered factors
  ordered_factor_collection <-  c(count_non_missing_label, count_missing_label, count_label, mode_label, min_label, max_label)
  i = 1
  for(col_new in columns_to_summarise){
    col_data_type = self$get_variables_metadata(data_name = data_name, column = col_new, property = data_type_label)
    if(col_data_type == "numeric" || col_data_type == "integer"){
      column_summaries = intersect(summaries, numeric_collection)
    }
    else if(col_data_type == "factor"){
      column_summaries = intersect(summaries, factor_collection)
    }
    else if(col_data_type == paste0(c("ordered","factor"), collapse = ",")){
      column_summaries = intersect(summaries, ordered_factor_collection)
    }
    else if(col_data_type == "character"){
      column_summaries = intersect(summaries, alltypes_collection)
    }
    else if(col_data_type == "logical"){
      #To be defined
    }
    else if(col_data_type == "Date"){
      #To be defined
    }
    calc <- calculation$new(type = "summary", parameters = list(data_name = data_name, columns_to_summarise = col_new, summaries = column_summaries, factors = factors, store_results = store_results, drop = drop, return_output = return_output, summary_name = summary_name, add_cols = add_cols, ... = ...),  filters = filter_names, calculated_from = calculated_from)
    results <- self$apply_calculation(calc)
    if(!is.null(results)){
      results<-as.data.frame(t(results[,-1]))
      #row_names(results) <- get_summary_calculation_names(calc, column_summaries, col_new, calc_filters)
      names( results) <- col_new
      #use summaries as row names for now. This needs to change in the long run
      row.names( results) <- column_summaries
      if(i == 1) {
        calc_columns <- results
      }
      else {
        calc_columns <- merge(calc_columns, results, by=0, all=TRUE, sort = FALSE)#Sort should be user defined
        #we need to clarify which filters are being used
        rownames(calc_columns)=calc_columns$Row.names
        calc_columns<-calc_columns[,-1]
      }
      i = i + 1
    }
    else{
      warning("There is no output to return")
    }
  }
  return(calc_columns)
}
)

data_object$set("public", "calculate_summary", function(calc, ...) {
  columns_to_summarise = calc[["parameters"]][["columns_to_summarise"]]
  summaries = calc[["parameters"]][["summaries"]]
  factors = calc[["parameters"]][["factors"]]
  drop = calc[["parameters"]][["drop"]]
  add_cols = calc[["parameters"]][["add_cols"]]
  if("na.rm" %in% names(calc[["parameters"]])) na.rm = calc[["parameters"]][["na.rm"]]
  else na.rm = FALSE
  filter_names = calc[["filters"]]
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
  if(length(filter_names) == 0) {
    filter_names <- "no_filter"
  }
  i = 1
  for(filter_name in filter_names) {
    curr_data_filter <- self$get_data_frame(use_current_filter = TRUE, filter_name = filter_name)
    curr_filter <- self$get_filter(filter_name)
    if(self$filter_applied()) {
      calc_filters <- list(self$get_current_filter(), curr_filter)
    }
    else calc_filters <- list(curr_filter)
    if(!all(columns_to_summarise %in% names(curr_data_filter))) stop(paste("Some of the columns from:",paste(columns_to_summarise, collapse = ","),"were not found in the data."))
    if(!all(summaries %in% all_summaries)) stop(paste("Some of the summaries from:",paste(summaries, collapse = ","),"were not recognised."))
    if(!all(factors %in% names(curr_data_filter))) stop(paste("Some of the factors:","c(",paste(factors, collapse = ","),") were not found in the data."))
    
    out <- ddply(curr_data_filter, factors, function(x) apply(combinations, 1, FUN = function(y) {
      # temp disabled to allow na.rm to be passed in
      #na.rm <- missing_values_check(x[[y[[2]]]])
      if("na.rm" %in% names(list(...))) stop("na.rm should not be specified. Use xxx to specify missing values handling.")
      match.fun(y[[1]])(x[[y[[2]]]], add_cols = x[add_cols], na.rm = na.rm, ...)
    }
    ), .drop = drop)
    names(out)[-(1:length(factors))] <- get_summary_calculation_names(calc, summaries, columns_to_summarise, calc_filters)
    if(i == 1) {
      calc_columns <- out
    }
    else {
      calc_columns <- full_join(calc_columns, out)
    }
    i = i + 1
  }
  return(calc_columns)
}
)

get_summary_calculation_names <- function(calc, summaries, columns_to_summarise, calc_filters) {
  filter_description <- ""
  i = 1
  for(filt in calc_filters) {
    if(!filt$parameters[["is_no_filter"]]) {
      if(i == 1) filter_description <- filt$name
      else filter_description <- paste(filter_description, filt$name, sep = ".")
    }
    i = i + 1
  }
  if(filter_description == "") {
    out <- apply(expand.grid(paste0(substring(summaries, 9),"."), columns_to_summarise), 1, paste, collapse="")
  }
  else out <- apply(expand.grid(paste0(substring(summaries, 9),"."), paste0(columns_to_summarise, "_"), filter_description), 1, paste, collapse="")
  out <- make.names(out)
  return(out)
}

missing_values_check <- function(x) {
  return(FALSE)
}

# summary function labels
sum_label="summary_sum"
mode_label="summary_mode"
count_label="summary_count"
count_missing_label="summary_count_missing"
count_non_missing_label="summary_count_non_missing"
sd_label = "summary_sd"
var_label = "summary_var"
median_label = "summary_median"
range_label = "summary_range"
min_label="summary_min"
max_label="summary_max"
mean_label="summary_mean"
#quartiles need to be added as a summary

# list of all summary function names
all_summaries=c(sum_label, mode_label, count_label, count_missing_label, count_non_missing_label, sd_label, var_label, median_label, range_label, min_label, max_label, mean_label)
summary_mode <- function(x,...) {
  ux <- unique(x)
  out <- ux[which.max(tabulate(match(x, ux)))]
  if(is.factor(x)) out <- as.character(out)
  if(is.null(out)) return(NA)
  else return(out)
}

summary_mean <- function (x, add_cols, weights="", na.rm = FALSE, trim = 0,...) {
  if( length(x)==0 || (na.rm && length(x[!is.na(x)])==0) ) return(NA)
  else return(mean(x, na.rm=na.rm, trim = trim))
}

summary_sum <- function (x, na.rm = FALSE,...) {
  return(sum(x, na.rm = na.rm))
}

summary_count <- function(x,...) {
  return(length(x))
}

summary_count_missing <- function(x,...) {
  return(sum(is.na(x)))
}

summary_count_non_missing <- function(x,...) {
  return(sum(!is.na(x)))
}

summary_sd <- function(x, na.rm = FALSE,...) {
  return(sd(x,na.rm = na.rm))
}

summary_var <- function(x, na.rm = FALSE,...) {
  return(var(x,na.rm = na.rm))
}

summary_max <- function (x, na.rm = FALSE,...) {
  #TODO This prevents warning and -Inf being retured. Is this desirable?
  if( length(x)==0 || (na.rm && length(x[!is.na(x)])==0) ) return(NA)
  else return(max(x, na.rm = na.rm))
} 

summary_min <- function (x, na.rm = FALSE,...) {
  #TODO This prevents warning and Inf being retured. Is this desirable?
  if( length(x)==0 || (na.rm && length(x[!is.na(x)])==0) ) return(NA)
  else return(min(x, na.rm = na.rm))
} 

#get the range of the data
summary_range <- function(x, na.rm = FALSE, ...){
  return(max(x, na.rm = na.rm) - min(x, na.rm = na.rm))
}

# median function
summary_median <- function(x, na.rm = FALSE,...) {
  return(median(x, na.rm = na.rm))
}





instat_object$set("public", "summary_table", function(data_name, columns_to_summarise = NULL, summaries, row_factors = c(), column_factors = c(), store_results = TRUE, drop = TRUE, na.rm = FALSE, summary_name = NA, include_margins = TRUE, ...) {
  
  factors <- c(column_factors, row_factors)
  cell_values <- self$calculate_summary(data_name = data_name, columns_to_summarise = columns_to_summarise, summaries = summaries, factors = factors, store_results = store_results, drop = drop, na.rm = na.rm, return_output = TRUE)
  
  if(include_margins) {
    margin_tables <- list()
    power_sets <- powerSet(factors)
    for(facts in head(power_sets, -1)) { # OR power_sets[-length(power_sets)])
      margin_tables[[length(margin_tables) + 1]] <- self$calculate_summary(data_name = data_name, columns_to_summarise = columns_to_summarise, summaries = summaries, factors = facts, store_results = store_results, drop = drop, na.rm = na.rm, return_output = return_output)
      # How to save that calculate_margins bit
    }
  }
  column_factor_margin <- margin_tables[2]   # in long term where is [[2]], e.g. which(powerSet(c(1,2,3, 4)) == "1"
  
  # which will then be which(powerSet(c(1,2,3,4)) == "column_factors")?
  # which(power_sets == "column_factors")
  
  row_factor_margin <- margin_tables[length(margin_tables)] # last one. (last is usually 1,2,3 but here it is not because we have removed the last term)
  
  
  overall_value <- margin_tables[1]
  # unstack cell data by column factor
  # get the three margins (row, column, overall)
  # make them into 2 vectors (one row and one column)
  # do rbind and cbind to add them???
}
)
