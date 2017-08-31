#Methods temporarily here to avoid conflicts
data_object$set("public", "merge_data", function(new_data, by = NULL, type = "left", match = "all") {
  #TODO how to use match argument with dplyr join functions
  old_metadata <- attributes(private$data)
  curr_data <- self$get_data_frame(use_current_filter = FALSE)

  if(type == "left") {
    new_data <- dplyr::left_join(curr_data, new_data, by)
  }
  else if(type == "right") {
    new_data <- dplyr::right_join(curr_data, new_data, by)
  }
  else if(type == "full") {
    new_data <- dplyr::full_join(curr_data, new_data, by)
  }
  else if(type == "inner") {
    new_data <- dplyr::inner_join(curr_data, new_data, by)
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
  self$add_defaults_variables_metadata(setdiff(names(new_data), names(curr_data)))
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

instat_object$set("public", "calculate_summary", function(data_name, columns_to_summarise = NULL, summaries, factors = c(), store_results = TRUE, drop = TRUE, na.rm = FALSE, return_output = FALSE, summary_name = NA, weights = NULL, result_names = NULL, percentage_type = "none", perc_total_columns = NULL, perc_total_factors = c(), perc_total_filter = NULL, perc_decimal = FALSE, perc_return_all = FALSE, silent = FALSE, additional_filter, ...) {
  include_columns_to_summarise <- TRUE
  if(is.null(columns_to_summarise) || length(columns_to_summarise) == 0) {
    # temporary fix for doing counts of a data frame
    # dplyr cannot count data frame groups without passing a column (https://stackoverflow.com/questions/44217265/passing-correct-data-frame-from-within-dplyrsummarise)
    # This is a known issue (https://github.com/tidyverse/dplyr/issues/2752)
    if(length(summaries) != 1 || summaries != count_label) {
      mes <- "When there are no columns to summarise can only use count function as summary"
      if(silent) {
        warning(mes, "Continuing summaries by using count only.")
        columns_to_summarise <- self$get_column_names(data_name)[1]
        summaries <- count_label
      }
      else {
        stop(mes)
      }
    }
    else columns_to_summarise <- self$get_column_names(data_name)[1]
    include_columns_to_summarise <- FALSE
  }
  if(!percentage_type %in% c("none", "factors", "columns", "filter")) stop("percentage_type: ", percentage_type, " not recognised.")
  if(percentage_type == "columns") {
    if(!(length(perc_total_columns) == 1 || length(perc_total_columns) == length(columns_to_summarise))) stop("perc_total_columns must either be of length 1 or the same length as columns_to_summarise")
  }
  if(!store_results) save <- 0
  else save <- 2
  
  summaries_display <- as.vector(sapply(summaries, function(x) ifelse(startsWith(x, "summary_"), substring(x, 9), x)))
  
  if(percentage_type == "factors") {
    manip_factors <- intersect(factors, perc_total_factors)
  }
  else manip_factors <- factors
  if(length(manip_factors) > 0) {
    calculated_from <- as.list(manip_factors)
    names(calculated_from) <- rep(data_name, length(manip_factors))
    calculated_from <- as.list(calculated_from)
    factor_by <- instat_calculation$new(type = "by", calculated_from = calculated_from)
    manipulations <- list(factor_by)
  }
  else manipulations <- list()
  if(percentage_type == "factors") {
    value_factors <- setdiff(factors, manip_factors)
    if(length(value_factors) > 0) {
      calculated_from <- as.list(value_factors)
      names(calculated_from) <- rep(data_name, length(value_factors))
      calculated_from <- as.list(calculated_from)
      factor_by <- instat_calculation$new(type = "by", calculated_from = calculated_from)
      value_manipulations <- list(factor_by)
    }
    else value_manipulations <- list()
  }
  sub_calculations <- list()
  
  i <- 0
  for(column_names in columns_to_summarise) {
    i <- i + 1
    # In the case of counting without columns, the first column column will be the "calculated from"
    # which will add unwanted column metadata
    calculated_from <- list(column_names)
    if(!is.null(weights)) calculated_from[[length(calculated_from) + 1]] <- weights
    names(calculated_from) <- rep(data_name, length(calculated_from))
    j <- 0
    for(summary_type in summaries) {
      j <- j + 1
      function_exp <- ""
      if(!is.null(weights)) {
        function_exp <- paste0(function_exp, ", weights = ", weights)
      }
      function_exp <- paste0(function_exp, ", na.rm =", na.rm, ")")
      if(is.null(result_names)) {
        result_name = summaries_display[j]
        if(include_columns_to_summarise) result_name = paste0(result_name, "_", column_names)
      }
      #TODO result_names could be horizontal/vertical vector, matrix or single value
      else result_name <- result_names[i,j]
      if(percentage_type == "none") {
        summary_calculation <- instat_calculation$new(type = "summary", result_name = result_name,
                                                      function_exp = paste0(summary_type, "(", column_names, function_exp),
                                                      calculated_from = calculated_from, save = save)
      }
      else {
        values_calculation <- instat_calculation$new(type = "summary", result_name = result_name,
                                                      function_exp = paste0(summary_type, "(", column_names, function_exp),
                                                      calculated_from = calculated_from, save = save)
        if(percentage_type == "columns") {
          if(length(perc_total_columns) == 1) perc_col_name <- perc_total_columns
          else perc_col_name <- perc_total_columns[i]
          totals_calculation <- instat_calculation$new(type = "summary", result_name = paste0(summaries_display[j], "_", perc_total_columns, "_totals"),
                                                       function_exp = paste0(summary_type, "(", perc_col_name, function_exp),
                                                       calculated_from = calculated_from, save = save)
        }
        else if(percentage_type == "filter") {
          #TODO
        }
        else if(percentage_type == "factors") {
          values_calculation$manipulations <- value_manipulations
          totals_calculation <- instat_calculation$new(type = "summary", result_name = paste0(result_name, "_totals"),
                                                       function_exp = paste0(summary_type, "(", column_names, function_exp),
                                                       calculated_from = calculated_from, save = save)
        }
        function_exp <- paste0(values_calculation$result_name, "/", totals_calculation$result_name)
        if(!perc_decimal) {
          function_exp <- paste0("(", function_exp, ") * 100")
        }
        perc_result_name <- paste0("perc_", result_name)
        summary_calculation <- instat_calculation$new(type = "calculation", result_name = perc_result_name,
                                                      function_exp = function_exp,
                                                      calculated_from = list(), save = save, sub_calculations = list(totals_calculation, values_calculation))
      }
      sub_calculations[[length(sub_calculations) + 1]] <- summary_calculation
    }
  }
  if(self$filter_applied(data_name)) {
    curr_filter <- self$get_current_filter(data_name)
    curr_filter_name <- curr_filter[["name"]]
    curr_filter_calc <- self$get_filter_as_instat_calculation(data_name, curr_filter_name)
    manipulations <- c(curr_filter_calc, manipulations)
  }
  if(!missing(additional_filter)) {
    manipulations <- c(additional_filter, manipulations)
  }
  combined_calc_sum <- instat_calculation$new(type="combination", sub_calculations = sub_calculations, manipulations = manipulations)
  out <- self$apply_instat_calculation(combined_calc_sum)
  if(return_output) {
    dat <- out$data
    if(percentage_type == "none" || perc_return_all) return(out$data)
    else {
      #This is a temp fix to only returning final percentage columns.
      #Depends on result name format used above for summary_calculation in percentage case
      dat[c(which(names(dat) %in% factors), which(startsWith(names(dat), "perc_")))]
    }
  }
}
)

instat_object$set("public", "summary", function(data_name, columns_to_summarise, summaries, factors = c(), store_results = FALSE, drop = FALSE, return_output = FALSE, summary_name = NA, add_cols = c(), filter_names = c(), ...) {
  calculated_from = list()
  calculated_from[[1]] <- list(data_name = data_name, columns = columns_to_summarise)
  #TODO Change this to store sub_calculations for each column
  alltypes_collection <- c(count_non_missing_label, count_missing_label, count_label, mode_label)
  numeric_collection <- c(count_non_missing_label, count_missing_label, count_label, mode_label, min_label, max_label, mean_label, sd_label, range_label, median_label, sum_label, var_label, lower_quart_label,upper_quart_label)
  factor_collection <-  c(count_non_missing_label, count_missing_label, count_label, mode_label) #maximum and minimum labels should be added when we distinguish ordered factors
  ordered_factor_collection <-  c(count_non_missing_label, count_missing_label, count_label, mode_label, min_label, max_label)
  i = 1
  for(col_new in columns_to_summarise) {
    col_data_type = self$get_variables_metadata(data_name = data_name, column = col_new, property = data_type_label)
    if(col_data_type == "numeric" || col_data_type == "integer") {
      column_summaries = intersect(summaries, numeric_collection)
    }
    else if(col_data_type == "factor") {
      column_summaries = intersect(summaries, factor_collection)
    }
    else if(col_data_type == paste0(c("ordered","factor"), collapse = ",")) {
      column_summaries = intersect(summaries, ordered_factor_collection)
    }
    else if(col_data_type == "character") {
      column_summaries = intersect(summaries, alltypes_collection)
    }
    else if(col_data_type == "logical") {
      #To be defined
    }
    else if(col_data_type == "Date") {
      #To be defined
    }
    if(length(column_summaries) == 0) {
      results <- data.frame(matrix(ncol = length(summaries) + 1))
      names(results) <- c(".id", summaries)
      column_summaries <- summaries
    }
    else {
      calc <- calculation$new(type = "summary", parameters = list(data_name = data_name, columns_to_summarise = col_new, summaries = column_summaries, factors = factors, store_results = store_results, drop = drop, return_output = return_output, summary_name = summary_name, add_cols = add_cols, ... = ...),  filters = filter_names, calculated_from = calculated_from)
      results <- self$apply_calculation(calc)
    }
    if(!is.null(results)) {
      results <- as.data.frame(t(results[,-1]))
      #row_names(results) <- get_summary_calculation_names(calc, column_summaries, col_new, calc_filters)
      names(results) <- col_new
      #use summaries as row names for now. This needs to change in the long run
      row.names(results) <- column_summaries
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
    else {
      calc_columns <- NULL
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
    
    out <- plyr::ddply(curr_data_filter, factors, function(x) apply(combinations, 1, FUN = function(y) {
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
quartile_label="summary_quartile"
lower_quart_label="lower_quartile"
upper_quart_label="upper_quartile"
skewness_label="summary_skewness"
summary_skewness_mc_label="summary_skewness_mc"
kurtosis_label="summary_kurtosis"
summary_coef_var_label="summary_coef_var"
summary_Qn_label="summary_Qn"
summary_Sn_label="summary_Sn"


# list of all summary function names
all_summaries=c(sum_label, mode_label, count_label, count_missing_label, count_non_missing_label, sd_label, var_label, median_label, range_label, min_label, max_label, mean_label,quartile_label, lower_quart_label, upper_quart_label, skewness_label, kurtosis_label, summary_coef_var_label, summary_skewness_mc_label, summary_Qn_label, summary_Sn_label)
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
  if(length(x)==0 || (na.rm && length(x[!is.na(x)])==0)) return(NA)
  else return(max(x, na.rm = na.rm))
} 

summary_min <- function (x, na.rm = FALSE,...) {
  #TODO This prevents warning and Inf being retured. Is this desirable?
  if(length(x)==0 || (na.rm && length(x[!is.na(x)])==0)) return(NA)
  else return(min(x, na.rm = na.rm))
} 

#get the range of the data
summary_range <- function(x, na.rm = FALSE, ...) {
  return(max(x, na.rm = na.rm) - min(x, na.rm = na.rm))
}

# median function
summary_median <- function(x, na.rm = FALSE,...) {
  return(median(x, na.rm = na.rm))
}

#quantile function
summary_quantile <- function(x, na.rm = FALSE, probs,...) {
  if(anyNA(x) && !na.rm) return(NA)
  # This prevents multiple values being returned
  else return(quantile(x, na.rm = na.rm, probs = probs)[[1]])
}

# lower quartile function
lower_quartile <- function(x, na.rm = FALSE,...) {
  return(summary_quantile(x, na.rm = na.rm, probs = 0.25))
}

# upper quartile function
upper_quartile <- function(x, na.rm = FALSE,...) {
  return(summary_quantile(x, na.rm = na.rm, probs = 0.75))
}

#Skewness e1071 function
summary_skewness <- function(x, na.rm = FALSE, type = 2,...){
  return( e1071::skewness(x, na.rm = na.rm, type = type))
}

#skewness mc function
summary_skewness_mc <- function(x, na.rm=FALSE,...){
  return(robustbase::mc(x, na.rm = na.rm))
}

#kurtosis function
summary_kurtosis <- function(x, na.rm = FALSE, type = 2,...){
  return(e1071::kurtosis(x, na.rm = na.rm, type = type))
}

#Coefficient of Variation function
summary_coef_var <- function(x,...){
  return(summary_sd(x) / summary_mean(x))
}

#median absolute deviation function
summary_median_absolute_deviation <- function(x, constant = 1.4826, na.rm = FALSE,low = FALSE, high = FALSE,...){
  return(stats::mad(x, constant = constant, na.rm = na.rm, low = low, high = high))  
}

#Qn function
summary_Qn <- function(x, constant = 2.21914, finite.corr = missing(constant),...){
  return(robustbase::Qn(x, constant = constant, finite.corr = finite.corr))
}

#sn function
summary_Sn <- function(x, constant = 1.1926, finite.corr = missing(constant)){
  return(robustbase::Sn(x, constant = constant, finite.corr = finite.corr))
}
  
instat_object$set("public", "summary_table", function(data_name, columns_to_summarise = NULL, summaries, factors = c(), n_column_factors = 1, store_results = TRUE, drop = TRUE, na.rm = FALSE, summary_name = NA, include_margins = FALSE, return_output = TRUE, treat_columns_as_factor = FALSE, page_by = "default", as_html = TRUE, signif_fig = 2, na_display = "", na_level_display = "NA", weights = NULL, caption = NULL, result_names = NULL, percentage_type = "none", perc_total_columns = NULL, perc_total_factors = c(), perc_total_filter = NULL, perc_decimal = FALSE, margin_name = "(All)", additional_filter, ...) {
  if(n_column_factors == 1 && length(factors) == 0) n_column_factors <- 0
  if(n_column_factors > length(factors)) stop("n_column_factors must be <= number of factors specified.")
  if(na_level_display == "") stop("na_level_display must be a non empty string")
  if(n_column_factors > 0) {
    column_factors <- factors[(length(factors) - n_column_factors + 1):length(factors)]
  }
  else column_factors <- c()
  if(n_column_factors == length(factors)) row_factors <- c()
  else row_factors <- setdiff(factors, column_factors)
  
  #TODO change code so that it assumes row factors are first in factors list i.e. factors <- c(row_factors, column_factors)
  factors <- c(column_factors, row_factors)
  
  # removes "summary_" from beginning of summary function names so that display is nice
  summaries_display <- sapply(summaries, function(x) ifelse(startsWith(x, "summary_"), substring(x, 9), x))
  
  if(!is.null(page_by) && page_by == "default") {
    if(length(columns_to_summarise) > 1 && length(summaries) > 1) {
      page_by <- c("summaries", "variables")
    }
    else if(length(summaries) > 1) {
      page_by <- "summaries"
    }
    else if(length(columns_to_summarise) > 1) {
      page_by <- "variables"
    }
    else page_by <- c()
  }
  if(include_margins) {
    #TODO fix these checks when we implement choice for page_by
    # if(length(columns_to_summarise) > 1 && length(summaries) > 1 && !setequal(page_by, c("summaries", "variables"))) {
    #   warning("Multiple summaries and variables with margins is currently only implemented through multiple pages. Overriding page_by to be c(summaries, variables)")
    #   page_by <- c("summaries", "variables")
    # }
    # else if(length(summaries) > 1 && (length(page_by) == 0 || page_by != "summaries")) {
    #   warning("Multiple summaries with margins is currently only implemented through multiple pages. Overriding page_by to be summaries")
    #   page_by <- "summaries"
    # }
    # else if(length(columns_to_summarise) > 1 && (length(page_by) == 0 || page_by != "variables")) {
    #   warning("Multiple variables with margins is currently only implemented through multiple pages. Overriding page_by to be variables")
    #   page_by <- "variables"
    # }
  }
  if(length(page_by) > 0) {
    out <- list()
    if(length(page_by) == 1 && page_by == "summaries") {
      for(i in seq_along(summaries)) {
        out[[paste(summaries_display[i], columns_to_summarise)]] <- self$summary_table(data_name = data_name, columns_to_summarise = columns_to_summarise, summaries = summaries[i], factors = factors, n_column_factors = n_column_factors, store_results = store_results, drop = drop, na.rm = na.rm, summary_name = summary_name, include_margins = include_margins, return_output = return_output, treat_columns_as_factor = treat_columns_as_factor, page_by = "default", as_html = as_html, weights = weights, na_display = na_display, result_names = result_names, percentage_type = percentage_type, perc_total_columns = perc_total_columns, perc_total_factors = perc_total_factors, perc_total_filter = perc_total_filter, perc_decimal = perc_decimal, margin_name = margin_name, additional_filter = additional_filter, perc_return_all = FALSE, ... = ...)
      }
    }
    else if(length(page_by) == 1 && page_by == "variables") {
      for(i in seq_along(columns_to_summarise)) {
        out[[paste(summaries_display, columns_to_summarise[i])]] <- self$summary_table(data_name = data_name, columns_to_summarise = columns_to_summarise[i], summaries = summaries, factors = factors, n_column_factors = n_column_factors, store_results = store_results, drop = drop, na.rm = na.rm, summary_name = summary_name, include_margins = include_margins, return_output = return_output, treat_columns_as_factor = treat_columns_as_factor, page_by = "default", as_html = as_html, weights = weights, na_display = na_display, result_names = result_names, percentage_type = percentage_type, perc_total_columns = perc_total_columns, perc_total_factors = perc_total_factors, perc_total_filter = perc_total_filter, perc_decimal = perc_decimal, margin_name = margin_name, additional_filter = additional_filter, perc_return_all = FALSE, ... = ...)
      }
    }
    else if(length(page_by) == 2  && all(page_by %in% c("variables", "summaries"))) {
      for(i in seq_along(columns_to_summarise)) {
        for(j in seq_along(summaries)) {
          out[[paste(summaries_display[j], columns_to_summarise[i])]] <- self$summary_table(data_name = data_name, columns_to_summarise = columns_to_summarise[i], summaries = summaries[j], factors = factors, n_column_factors = n_column_factors, store_results = store_results, drop = drop, na.rm = na.rm, summary_name = summary_name, include_margins = include_margins, return_output = return_output, treat_columns_as_factor = treat_columns_as_factor, page_by = "default", as_html = as_html, weights = weights, na_display = na_display, result_names = result_names, percentage_type = percentage_type, perc_total_columns = perc_total_columns, perc_total_factors = perc_total_factors, perc_total_filter = perc_total_filter, perc_decimal = perc_decimal, margin_name = margin_name, additional_filter = additional_filter, perc_return_all = FALSE, ... = ...)
        }
      }
    }
    else if(all(page_by %in% factors)) {
      levels_list <- lapply(page_by, function(x) levels(self$get_columns_from_data(data_name = data_name, col_names = x)))
      levels_data_frame <- expand.grid(levels_list)
      for(j in 1:ncol(levels_data_frame)) {
        levels_data_frame[,j] <- paste0(page_by[j], " == ", "'", levels_data_frame[,j], "'")
      }
      filter_expressions <- apply(levels_data_frame, 1, paste, collapse = " & ")
      calculated_from <- as.list(page_by)
      names(calculated_from) <- rep(data_name, length(page_by))
      curr_factors <- setdiff(factors, page_by)
      for(i in seq_along(filter_expressions)) {
        filter_calc <- instat_calculation$new(type = "filter", function_exp = filter_expressions[i], calculated_from = calculated_from)
        for(j in seq_along(summaries)) {
          for(k in seq_along(columns_to_summarise)) {
            out[[paste(filter_expressions[i], summaries_display[j], columns_to_summarise[k])]] <- self$summary_table(data_name = data_name, columns_to_summarise = columns_to_summarise[k], summaries = summaries[j], factors = curr_factors, n_column_factors = n_column_factors, store_results = store_results, drop = drop, na.rm = na.rm, summary_name = summary_name, include_margins = include_margins, return_output = return_output, treat_columns_as_factor = treat_columns_as_factor, page_by = "default", as_html = as_html, weights = weights, na_display = na_display, result_names = result_names, percentage_type = percentage_type, perc_total_columns = perc_total_columns, perc_total_factors = perc_total_factors, perc_total_filter = perc_total_filter, perc_decimal = perc_decimal, margin_name = margin_name, additional_filter = filter_calc, perc_return_all = FALSE, ... = ...)
          }
        }
      }
    }
    else stop("page_by not recognised")
    if(as_html) {
      if(length(out) == 1 ) {
        return(out[[1]])
      }
      else {
        tabs <- htmlTable::concatHtmlTables(out, headers = "")
        class(tabs) <- c("htmlTable", "character")
        return(tabs)
      }
    }
    else return(out)
  }
  else {
    cell_values <- self$calculate_summary(data_name = data_name, columns_to_summarise = columns_to_summarise, summaries = summaries, factors = factors, store_results = store_results, drop = drop, na.rm = na.rm, return_output = TRUE, weights = weights, result_names = result_names, percentage_type = percentage_type, perc_total_columns = perc_total_columns, perc_total_factors = perc_total_factors, perc_total_filter = perc_total_filter, perc_decimal = perc_decimal, margin_name = margin_name, additional_filter = additional_filter, perc_return_all = FALSE)
    for(i in seq_along(factors)) {
      levels(cell_values[[i]]) <- c(levels(cell_values[[i]]), na_level_display)
      cell_values[[i]][is.na(cell_values[[i]])] <- na_level_display
    }
    grps <- nrow(cell_values)
    cell_values <- reshape2:::melt.data.frame(cell_values, id.vars = factors, variable.name = "Summary-Variable", value.name = "Value")
    cell_values[["Variable"]] <- rep(rev(columns_to_summarise), each = nrow(cell_values)/length(columns_to_summarise))
    cell_values[["Summary"]] <- rep(rev(summaries_display), each = grps, length.out = nrow(cell_values))
    if(length(columns_to_summarise) > 1 || length(summaries) > 1) {
      cell_values[["Summary-Variable"]] <- NULL
      # TODO this relies on knowing order of output from calculate_summary
      #      better method should be implemented not relying on this.
      if(length(summaries) == 1) cell_values[["Summary"]] <- summaries_display
      summary_factors <- c("Variable", "Summary")
      if(!treat_columns_as_factor) {
        if(length(summaries) > 1) {
          cell_values[["Summary"]] <- paste(cell_values[["Summary"]], cell_values[["Variable"]], sep = "_")
        }
        else cell_values[["Summary"]] <- paste(summaries, cell_values[["Variable"]], sep = "_")
        cell_values[["Variable"]] <- NULL
        summary_factors <- "Summary"
      }
    }
    else {
      if(treat_columns_as_factor) {
        summary_factors <- "Variable"
      }
      else {
        summary_factors <- c()
        cell_values[["Variable"]] <- NULL
        cell_values[["Summary"]] <- NULL
      }
    }
    if(length(column_factors) > 0) {
      column_formula <- paste(column_factors, collapse = "+")
    }
    else column_formula <- "."
    if(length(c(row_factors, summary_factors)) > 0) {
      row_formula <- paste(c(row_factors, summary_factors), collapse = "+")
    }
    else row_formula <- "."
    shaped_cell_values <- reshape2::dcast(formula = as.formula(paste(row_formula, "~", column_formula)), value.var = "Value", data = cell_values)
    
    #This removes blank column caused by dcast having no row variables
    if(length(c(row_factors, summary_factors)) == 0) shaped_cell_values[[1]] <- NULL
    
    #Converts factor columns to character so we can relabel values if needed
    for(i in seq_along(row_factors)) {
      shaped_cell_values[[i]] <- as.character(shaped_cell_values[[i]])
    }
    if(include_margins && (length(row_factors) > 0 || length(column_factors) > 0)) {
      margin_tables <- list()
      power_sets <- rje::powerSet(factors)
      # We could need last set if only have row or column factors
      power_sets <- power_sets[-(c(length(power_sets)))]
      for(facts in power_sets) {
        if(length(facts) == 0) facts <- c()
        margin_tables[[length(margin_tables) + 1]] <- self$calculate_summary(data_name = data_name, columns_to_summarise = columns_to_summarise, summaries = summaries, factors = facts, store_results = store_results, drop = drop, na.rm = na.rm, return_output = TRUE, weights = weights, result_names = result_names, percentage_type = percentage_type, perc_total_columns = perc_total_columns, perc_total_factors = perc_total_factors, perc_total_filter = perc_total_filter, perc_decimal = perc_decimal, margin_name = margin_name, additional_filter = additional_filter, perc_return_all = FALSE)
      }
      # Column Factor - add as row margin
      if(length(row_factors) > 0) {
        column_factor_margin <- margin_tables[[which(sapply(power_sets, function(x) setequal(column_factors, x)))]][[length(column_factors) + 1]]
        new_row <- c(rep(NA, length(row_factors) + length(summary_factors)), column_factor_margin)
        shaped_cell_values <- rbind(shaped_cell_values, new_row)
        shaped_cell_values[nrow(shaped_cell_values), 1] <- margin_name
      }
      overall_value <- margin_tables[[1]][1,1]
      if(length(column_factors) > 0) {
        row_factor_margin <- margin_tables[[which(sapply(power_sets, function(x) setequal(row_factors, x)))]][[length(row_factors) + 1]]
        # append the vector for the summary of interest in row_factor_margin with the overall_value
        if(length(row_factors) > 0) {
          overall_row_margin <- c(row_factor_margin, overall_value)
        }
        else overall_row_margin <- overall_value
        # add into the unstacked dataset
        shaped_cell_values[[margin_name]] <- overall_row_margin
      }
      align <- paste0(paste(rep("c", ncol(shaped_cell_values) - 1), collapse = ""), "|", "c")
    }
    else align <- paste(rep("c", ncol(shaped_cell_values)))
    shaped_cell_values <- convert_to_character_matrix(shaped_cell_values, decimal_places = rep(signif_fig, ncol(shaped_cell_values)), na_display = na_display, check.names = FALSE)
    if(return_output) {
      if(is.null(caption)) {
        caption <- ""
        if(!missing(additional_filter)) caption <- paste(caption, additional_filter$function_exp, "|")
        if(percentage_type != "none") {
          if(perc_decimal) caption <- paste(caption, "Proportions")
          else caption <- paste(caption, "Percentages")
          if(percentage_type == "factors" && length(setdiff(factors, perc_total_factors)) > 0) caption <- paste0(caption, " (within ", paste(setdiff(factors, perc_total_factors), collapse = ", "), ")")
          caption <- paste0(caption, ":")
        }
        if(length(columns_to_summarise) > 1 && length(summaries) > 1) {
          caption <- paste(caption, "Summary of ", paste(columns_to_summarise, collapse = ","))
        }
        else if(length(columns_to_summarise) > 1) {
          caption <- paste(caption, summaries, "of", paste(columns_to_summarise, collapse = ","))
        }
        else if(length(summaries) > 1) {
          caption <- paste(caption, "Summary of", columns_to_summarise)
        }
        else {
          caption <- paste(caption, summaries_display, columns_to_summarise)
        }
        caption <- gsub("_", ".", caption)
        caption <- trimws(caption)
        notes <- ""
        if(length(row_factors) > 0) notes <- paste(notes, " Row Factors: ", paste0(row_factors, collapse = ", "))
        if(length(column_factors) > 0) notes <- paste(notes, " Column Factors: ", paste0(column_factors, collapse = ", "))
        if(length(weights) > 0) notes <- paste(notes, " Weights: ", paste0(weights, collapse = ", "))
      }
      if(as_html) {
        if(length(column_factors) == 0) {
          tab <- htmlTable::htmlTable(shaped_cell_values, caption = caption, total = include_margins, align = align, tfoot = notes, ... = ...)
          class(tab) <- class(tab)[!class(tab) == "html"]
          return(tab)
        }
        else {
          spanner_data <- unique(cell_values[column_factors])
          col_names <- c(row_factors, as.character(spanner_data[[length(spanner_data)]]))
          if(include_margins) {
            col_names <- c(col_names, margin_name)
          }
          names(shaped_cell_values) <- col_names
          if(length(column_factors) == 1) {
            cgroup <- c(rep("", length(row_factors)), column_factors)
            n.cgroup <- c(rep(1, length(row_factors)), nrow(spanner_data))
          }
          else if(length(column_factors) > 1) {
            # removes duplicate rows which exist when row factors present
            spanner_data <- unique(cell_values[column_factors])
            #TODO do this without having to call rle twice to improve efficiency
            lengths <- lapply(spanner_data[-length(spanner_data)], function(x) rle(as.character(x))$lengths)
            values <- lapply(spanner_data[-length(spanner_data)], function(x) rle(as.character(x))$values)
            span_length <- max(sapply(values, length))
            lengths <- sapply(lengths, function(x) c(rep(1, length(row_factors)), x, rep(NA, span_length - length(x))))
            values <- sapply(values, function(x) c(rep("", length(row_factors)), x, rep(NA, span_length - length(x))))
            cgroup <- t(values)
            n.cgroup <- t(lengths)
          }
          css.cell <- ""
          if(include_margins) {
            if(is.matrix(cgroup)) {
              cgroup <- cbind(cgroup, NA)
              n.cgroup <- cbind(n.cgroup, NA)
              for(i in 1:nrow(cgroup)) {
                cgroup[i, which(is.na(cgroup[i, ]))[1]] <- ""
                n.cgroup[i, which(is.na(n.cgroup[i, ]))[1]] <- 1
              }
            }
            else {
              cgroup[[length(cgroup) + 1]] <- ""
              n.cgroup[[length(n.cgroup) + 1]] <- 1
            }
            css.cell <- matrix("", nrow = nrow(shaped_cell_values), ncol = ncol(shaped_cell_values))
            if(length(column_factors) > 0) css.cell[ , ncol(css.cell)] <- "font-weight: 900;"
            if(length(row_factors) > 0) css.cell[nrow(css.cell), ] <- "border-top: 1px solid #BEBEBE; font-weight: 900;"
          }
          tab <- htmlTable::htmlTable(shaped_cell_values, caption = caption, total = FALSE, align = align, tfoot = notes, cgroup = cgroup, n.cgroup = n.cgroup, css.cell = css.cell, ... = ...)
          class(tab) <- class(tab)[!class(tab) == "html"]
          return(tab)
        }
      }
      else return(shaped_cell_values)
      #return(stargazer::stargazer(shaped_cell_values, type = "html", summary = FALSE, rownames = FALSE, title = caption, notes = notes, ... = ...))
    }
  }
}
)