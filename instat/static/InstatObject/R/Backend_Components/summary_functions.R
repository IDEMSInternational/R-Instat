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
sum_label <- "summary_sum"
mode_label <- "summary_mode"
count_label <- "summary_count_all"
count_missing_label <- "summary_count_miss"
count_non_missing_label <- "summary_count"
sd_label <- "summary_sd"
var_label <- "summary_var"
median_label <- "summary_median"
range_label <- "summary_range"
min_label <- "summary_min"
max_label <- "summary_max"
mean_label <- "summary_mean"
trimmed_mean_label <- "summary_trimmed_mean"
quartile_label <- "summary_quartile"
p10_label <- "p10"
p20_label <- "p20"
p25_label <- "p25"
p30_label <- "p30"
p33_label <- "p33"
p40_label <- "p40"
p60_label <- "p60"
p67_label <- "p67"
p70_label <- "p70"
p75_label <- "p75"
p80_label <- "p80"
p90_label <- "p90"
skewness_label <- "summary_skewness"
summary_skewness_mc_label <- "summary_skewness_mc"
summary_outlier_limit_label <- "summary_outlier_limit"
kurtosis_label <- "summary_kurtosis"
summary_coef_var_label <- "summary_coef_var"
summary_median_absolute_deviation_label <- "summary_median_absolute_deviation"
summary_Qn_label <- "summary_Qn"
summary_Sn_label <- "summary_Sn"
cor_label <- "summary_cor"
cov_label <- "summary_cov"
first_label <- "summary_first"
last_label <- "summary_last"
nth_label <- "summary_nth"
n_distinct_label <- "summary_n_distinct"
proportion_label <- "proportion_calc"
count_calc_label <- "count_calc"
standard_error_mean_label <- "standard_error_mean"
circular_mean_label <- "summary_circular_mean"
circular_median_label <- "summary_circular_median"
circular_medianHL_label <- "summary_circular_medianHL"
circular_min_label <- "summary_circular_min"
circular_max_label <- "summary_circular_max"
circular_Q1_label <- "summary_circular_Q1"
circular_Q3_label <- "summary_circular_Q3"
circular_quantile_label <- "summary_circular_quantile"
circular_sd_label <- "summary_circular_sd"
circular_var_label <- "summary_circular_var"
circular_ang_dev_label <- "summary_circular_ang_dev"
circular_ang_var_label <- "summary_circular_ang_var"
circular_rho_label <- "summary_circular_rho"
circular_range_label <- "summary_circular_range"
mean_error_label <- "me"
mean_absolute_error_label <- "mae"
root_mean_square_error_label <- "rmse"
normalised_mean_square_error_label <- "nrmse"
percent_bias_label <- "PBIAS"
nash_Sutcliffe_efficiency_label <- "NSE"
modified_Nash_Sutcliffe_efficiency_label <- "mNSE"
relative_Nash_Sutcliffe_efficiency_label <- "rNSE"
Index_of_agreement_label <- "d"
modified_index_of_aggrement_label <- "md"
relative_index_of_agreement_label <- "rd"
coefficient_of_determination_label <- "R2"
coefficient_of_persistence_label <- "cp"
kling_Gupta_efficiency_label <- "KGE"
mean_squared_error_label <- "mse"
ratio_of_standard_deviations_label <- "rSD"
ratio_of_RMSE_label <- "rsr"
sum_of_squared_residuals_label <- "ssq"
volumetric_efficiency_label <- "VE"
which_min_label <- "summary_which_min"
which_max_label <- "summary_which_max"
where_min_label <- "summary_where_min"
where_max_label <- "summary_where_max"


# list of all summary function names
# the order of this list determines the order summaries appears in certain functions
all_summaries <- c(
  count_label, count_non_missing_label, count_missing_label,
  min_label, p10_label, p20_label, p25_label, p30_label, p33_label, p40_label, p60_label, p67_label, p70_label, p75_label, p80_label, p90_label, quartile_label, median_label,
  summary_median_absolute_deviation_label, summary_coef_var_label,
  summary_Qn_label, summary_Sn_label,
  mode_label, mean_label, which_min_label, which_max_label,where_max_label,
  trimmed_mean_label, max_label, sum_label, where_min_label,
  sd_label, var_label, range_label, standard_error_mean_label,
  skewness_label, summary_skewness_mc_label, kurtosis_label,
  summary_outlier_limit_label,
  cor_label, cov_label, first_label, last_label, nth_label, n_distinct_label,
  proportion_label, count_calc_label,
  circular_min_label, circular_Q1_label, circular_quantile_label,
  circular_median_label, circular_medianHL_label, circular_mean_label,
  circular_Q3_label, circular_max_label,
  circular_sd_label, circular_var_label, circular_range_label,
  circular_ang_dev_label, circular_ang_var_label, circular_rho_label,
  mean_error_label, mean_absolute_error_label, root_mean_square_error_label,
  normalised_mean_square_error_label, percent_bias_label, nash_Sutcliffe_efficiency_label,
  modified_Nash_Sutcliffe_efficiency_label, relative_Nash_Sutcliffe_efficiency_label,
  Index_of_agreement_label, modified_index_of_aggrement_label, relative_index_of_agreement_label,
  coefficient_of_determination_label, coefficient_of_persistence_label,
  kling_Gupta_efficiency_label, mean_squared_error_label, ratio_of_standard_deviations_label,
  ratio_of_RMSE_label, sum_of_squared_residuals_label, volumetric_efficiency_label
)

# which of the summaries should return a Date value when x is a Date?
date_summaries <- c(
  min_label, p10_label, p20_label, p25_label, p30_label, p33_label, p40_label, p60_label, p67_label, p70_label, p75_label, p80_label, p90_label, quartile_label, median_label,
  mode_label, mean_label, trimmed_mean_label, which_min_label, which_max_label, where_min_label,
  max_label, first_label, last_label, nth_label, where_max_label,
  circular_min_label, circular_Q1_label, circular_quantile_label,
  circular_median_label, circular_medianHL_label, circular_mean_label,
  circular_Q3_label, circular_max_label
)

summary_mode <- function(x,...) {
  ux <- unique(x)
  out <- ux[which.max(tabulate(match(x, ux)))]
  if(is.factor(x)) out <- as.character(out)
  if(is.null(out)) return(NA)
  else return(out)
}

na_check <- function(x, na_type = c(), na_consecutive_n = NULL, na_max_n = NULL, na_max_prop = NULL, na_min_n = NULL, na_FUN = NULL, ...) {
  res <- c()
  for (i in seq_along(na_type)) {
    type <- na_type[i]
    if (type %in% c("n","'n'")) {
      res[i] <- summary_count_miss(x) <= na_max_n
    }
    else if (type %in% c("prop","'prop'")) {
      res[i] <- (summary_count_miss(x) / summary_count(x)) <= na_max_prop / 100
    }
    else if (type %in% c("n_non_miss","'n_non_miss'")) {
      res[i] <- summary_count(x) >= na_min_n
    }
    else if (type %in% c("FUN","'FUN'")) {
      res[i] <- na_FUN(x, ...)
    }
    else if (type %in% c("con","'con'")) {
      is_na_rle <- rle(is.na(x))
      res[i] <- max(is_na_rle$lengths[is_na_rle$values]) <= na_consecutive_n
    }
    else {
      stop("Invalid na_type specified for missing values check.")
    }
    if (!res[i]) {
      return(FALSE)
    }
  }
  return(all(res))
}

summary_mean_circular <- function (x, na.rm = FALSE, control.circular = list(), na_type = "", ...) {
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else return(circular::mean.circular(x, na.rm = na.rm, trim = trim, control.circular = control.circular)[[1]])
}

summary_median_circular <- function (x, na.rm = FALSE, na_type = "", ...) {
  if(!na.rm & anyNA(x)) return(NA)
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else return(circular::median.circular(x, na.rm = na.rm)[[1]])
}

summary_medianHL_circular <- function (x, na.rm = FALSE, method = c("HL1","HL2","HL3"), prop = NULL, na_type = "", ...) {
  if(!na.rm & anyNA(x)) return(NA)
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else return(circular::medianHL.circular(x, na.rm = na.rm, method = method, prop = prop)[[1]])
}

summary_min_circular <- function (x, na.rm = FALSE, names = FALSE, type = 7, na_type = "", ...) {
  if(length(x)==0 || (na.rm && length(x[!is.na(x)])==0)||(!na.rm & anyNA(x))) return(NA)
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else return(circular::quantile.circular(x, probs = 0, na.rm = na.rm, names = names, type = type)[[1]])
}

summary_max_circular <- function (x, na.rm = FALSE, names = FALSE, type = 7, na_type = "", ...) {
  if(length(x)==0 || (na.rm && length(x[!is.na(x)])==0)||(!na.rm & anyNA(x))) return(NA)
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else return(circular::quantile.circular(x, probs = 1, na.rm = na.rm, names = names, type = type)[[1]])
}

summary_quantile_circular <- function (x, probs = seq(0, 1, 0.25), na.rm = FALSE, names = FALSE, type = 7, na_type = "", ...) {
  if(length(x)==0 || (na.rm && length(x[!is.na(x)])==0)||(!na.rm & anyNA(x))) return(NA)
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else return(circular::quantile.circular(x, probs = probs, na.rm = na.rm, names = names, type = type)[[1]])
}

summary_Q3_circular <- function (x, na.rm = FALSE, names = FALSE, type = 7, na_type = "", ...) {
  if(length(x)==0 || (na.rm && length(x[!is.na(x)])==0)||(!na.rm & anyNA(x))) return(NA)
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else return(circular::quantile.circular(x, probs = 0.75, na.rm = na.rm, names = names, type = type)[[1]])
}

summary_Q1_circular <- function (x, na.rm = FALSE, names = FALSE, type = 7, na_type = "", ...) {
  if(length(x)==0 || (na.rm && length(x[!is.na(x)])==0)||(!na.rm & anyNA(x))) return(NA)
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else return(circular::quantile.circular(x, probs = 0.25, na.rm = na.rm, names = names, type = type)[[1]])
}

summary_sd_circular <- function (x, na.rm = FALSE, na_type = "", ...) {
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else return(circular::sd.circular(x, na.rm = na.rm))
}

summary_var_circular <- function (x, na.rm = FALSE, na_type = "", ...) {
  if(length(x)==0 || (na.rm && length(x[!is.na(x)])==0)) return(NA)
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else return(circular::var.circular(x, na.rm = na.rm))
}

summary_ang_dev_circular <- function (x, na.rm = FALSE, na_type = "", ...) {
  if(length(x)==0 || (na.rm && length(x[!is.na(x)])==0)) return(NA)
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else return(circular::angular.deviation(x, na.rm = na.rm))
}

summary_ang_var_circular <- function (x, na.rm = FALSE, na_type = "", ...) {
  if(length(x)==0 || (na.rm && length(x[!is.na(x)])==0)) return(NA)
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else return(circular::angular.variance(x, na.rm = na.rm))
}

summary_range_circular <- function (x, test = FALSE, na.rm = FALSE, finite = FALSE, control.circular = list(),  na_type = "", ...) {
  if(length(x)==0 || (na.rm && length(x[!is.na(x)])==0)) return(NA)
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else return(circular::range.circular(x, test = test, na.rm = na.rm, finite = finite,  control.circular = control.circular)[[1]])
}

summary_rho_circular <- function (x, na.rm = FALSE, na_type = "", ...) {
  if(length(x)==0 || (na.rm && length(x[!is.na(x)])==0)) return(NA)
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else return(circular::rho.circular(x, na.rm = na.rm))
}

summary_quantile_circular <- function (x, probs = seq(0, 1, 0.25), na.rm = FALSE, names = FALSE, type = 7, na_type = "", ...) {
  if(length(x)==0 || (na.rm && length(x[!is.na(x)])==0)||(!na.rm & anyNA(x))) return(NA)
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else return(circular::quantile.circular(x, probs = probs, na.rm = na.rm, names = names, type = type)[[1]])
}

summary_mean <- function (x, add_cols, weights = NULL, na.rm = FALSE, trim = 0, na_type = "", ...) {
  if( length(x)==0 || (na.rm && length(x[!is.na(x)])==0) ) return(NA)
  else {
    if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
    else {
      if (missing(weights) || is.null(weights))
        return(mean(x, na.rm = na.rm, trim = trim))
      else 
        return(stats::weighted.mean(x, w = weights, na.rm = na.rm))
    }
  }
}

summary_trimmed_mean <- function (x, add_cols, weights = NULL, na.rm = FALSE, trimmed = 0, na_type = "", ...) {
  if( length(x)==0 || (na.rm && length(x[!is.na(x)])==0) ) return(NA)
  else {
    if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
    else 
      return(mean(x, na.rm = na.rm, trim = trimmed))
  }
}

summary_sum <- function (x, weights = NULL, na.rm = FALSE, na_type = "", ...) {
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else {
    if (missing(weights) || is.null(weights)) return(sum(x, na.rm = na.rm))
    else return(sum(x * weights, na.rm = na.rm))
  }
}


summary_count_all <- function(x, ...) {
  return(length(x))
}


summary_count_miss <- function(x, ...) {
  return(sum(is.na(x)))
}

summary_count <- function(x, ...) {
  return(sum(!is.na(x)))
}

summary_sd <- function(x, na.rm = FALSE, weights = NULL, na_type = "", ...) {
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if (missing(weights) || is.null(weights)) {
      return(sd(x, na.rm = na.rm))
    } else {
      return(sqrt(Hmisc::wtd.var(x, weights = weights, na.rm = na.rm)))
    }
  }  
}

summary_var <- function(x, na.rm = FALSE, weights = NULL, na_type = "", ...) {
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if (missing(weights) || is.null(weights)) {
      return(var(x,na.rm = na.rm))
    }
    else {
      return(Hmisc::wtd.var(x, weights = weights, na.rm = na.rm))
    }
  }
}

summary_max <- function (x, na.rm = FALSE, na_type = "", ...) {
  #TODO This prevents warning and -Inf being retured. Is this desirable?
  if(length(x)==0 || (na.rm && length(x[!is.na(x)])==0)) return(NA)
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    return(max(x, na.rm = na.rm))
  } 
}

summary_min <- function (x, na.rm = FALSE, na_type = "", ...) {
  #TODO This prevents warning and Inf being retured. Is this desirable?
  if(length(x)==0 || (na.rm && length(x[!is.na(x)])==0)) return(NA)
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    return(min(x, na.rm = na.rm))
  } 
}

summary_which_max <- function (x, na.rm = TRUE, na_type = "", ...) {
  if(length(x)==0 || (na.rm && length(x[!is.na(x)])==0)) return(NA)
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    # Get the minimum value
    max_value <- max(x, na.rm = na.rm)
    # Return all indices where x is equal to the minimum value
    return(which(x == max_value))
  } 
}

summary_which_min <- function(x, na.rm = TRUE, na_type = "", ...) {
  if(length(x) == 0 || (na.rm && length(x[!is.na(x)]) == 0)) return(NA)
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else {
    # Get the minimum value
    min_value <- min(x, na.rm = na.rm)
    # Return all indices where x is equal to the minimum value
    return(which(x == min_value))
  }
}

summary_where_max <- function(x, summary_where_y=NULL, na.rm = TRUE, na_type = "", ...) {  
  # Check if vectors are empty
  if (length(x) == 0 || length(summary_where_y) == 0) {
    return(NA)
  }
  
  # Handle NA values
  if (na.rm) {
    valid_indices <- !is.na(x) & !is.na(summary_where_y)
    x <- x[valid_indices]
    summary_where_y <- summary_where_y[valid_indices]
  }
  
  # Find the index of the maximum value in x
  max_index <- which.max(x)
  
  # Return the corresponding value in summary_where_y
  return(summary_where_y[max_index])
}

summary_where_min <- function(x, summary_where_y=NULL, na.rm = TRUE, na_type = "", ...) {
  # Check if vectors are empty
  if (length(x) == 0 || length(summary_where_y) == 0) {
    return(NA)
  }
  
  # Handle NA values
  if (na.rm) {
    valid_indices <- !is.na(x) & !is.na(summary_where_y)
    x <- x[valid_indices]
    summary_where_y <- summary_where_y[valid_indices]
  }
  
  # Find the index of the minimum value in x
  min_index <- summary_which_min(x, na.rm = na.rm, na_type = na_type, ...)
  
  # Return the corresponding value in summary_where_y
  return(summary_where_y[min_index])
}
    
# get the range of the data
summary_range <- function(x, na.rm = FALSE, na_type = "", ...) {
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    return(max(x, na.rm = na.rm) - min(x, na.rm = na.rm))
  }
}

# median function
summary_median <- function(x, na.rm = FALSE, weights = NULL, na_type = "", ...) {
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(missing(weights) || is.null(weights)) {
      if (stringr::str_detect(class(x), pattern = "ordered") || stringr::str_detect(class(x), pattern = "Date")) {
          return(quantile(x, na.rm = na.rm, probs = 0.5, type = 1)[[1]])
      } else {
          return(median(x, na.rm = na.rm))
      }
    } else {
      return(Hmisc::wtd.quantile(x, weights = weights, probs = 0.5, na.rm = na.rm))
    }
  }
}

# quantile function
summary_quantile <- function(x, na.rm = FALSE, weights = NULL, probs, na_type = "", ...) {
  if(!na.rm && anyNA(x)) return(NA)
  # This prevents multiple values being returned
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else {
    if(missing(weights) || is.null(weights)) {
      if (stringr::str_detect(class(x), pattern = "ordered") || stringr::str_detect(class(x), pattern = "Date")) {
          return(quantile(x, na.rm = na.rm, probs = probs, type = 1)[[1]])
      } else {
          return(quantile(x, na.rm = na.rm, probs = probs)[[1]])
      }
    }
    else {
      return(Hmisc::wtd.quantile(x, weights = weights, probs = probs, na.rm = na.rm))
    }
  }
}

# p10 function
p10 <- function(x, na.rm = FALSE, na_type = "", weights = NULL, na_max_prop = NULL, ...) {
  summary_quantile(x = x, na.rm = na.rm, na_type = na_type, weights = weights, probs = 0.1, na_max_prop = na_max_prop, ...)
}

# p20 function
p20 <- function(x, na.rm = FALSE, na_type = "", weights = NULL, na_max_prop = NULL,...) {
  summary_quantile(x = x, na.rm = na.rm, na_type = na_type, weights = weights, probs = 0.2, na_max_prop = na_max_prop, ...)
}

# p25 function
p25 <- function(x, na.rm = FALSE, na_type = "", weights = NULL, na_max_prop = NULL, ...) {
  summary_quantile(x = x, na.rm = na.rm, na_type = na_type, weights = weights, probs = 0.25, na_max_prop = na_max_prop, ...)
}

# p30 function
p30 <- function(x, na.rm = FALSE, na_type = "", weights = NULL, na_max_prop = NULL, ...) {
  summary_quantile(x = x, na.rm = na.rm, na_type = na_type, weights = weights, probs = 0.3, na_max_prop = na_max_prop, ...)
}

# p33 function
p33 <- function(x, na.rm = FALSE, na_type = "", weights = NULL, na_max_prop = NULL, ...) {
  summary_quantile(x = x, na.rm = na.rm, na_type = na_type, weights = weights, probs = 0.33, na_max_prop = na_max_prop, ...)
}

# p40 function
p40 <- function(x, na.rm = FALSE, na_type = "", weights = NULL, na_max_prop = NULL, ...) {
  summary_quantile(x = x, na.rm = na.rm, na_type = na_type, weights = weights, probs = 0.4, na_max_prop = na_max_prop, ...)
}

# p60 function
p60 <- function(x, na.rm = FALSE, na_type = "", weights = NULL, na_max_prop = NULL, ...) {
  summary_quantile(x = x, na.rm = na.rm, na_type = na_type, weights = weights, probs = 0.6, na_max_prop = na_max_prop, ...)
}

# p67 function
p67 <- function(x, na.rm = FALSE, na_type = "", weights = NULL, na_max_prop = NULL, ...) {
  summary_quantile(x = x, na.rm = na.rm, na_type = na_type, weights = weights, probs = 0.67, na_max_prop = na_max_prop, ...)
}

# p70 function
p70 <- function(x, na.rm = FALSE, na_type = "", weights = NULL, na_max_prop = NULL, ...) {
  summary_quantile(x = x, na.rm = na.rm, na_type = na_type, weights = weights, probs = 0.7, na_max_prop = na_max_prop, ...)
}

# p75 function
p75 <- function(x, na.rm = FALSE, na_type = "", weights = NULL, na_max_prop = NULL, ...) {
  summary_quantile(x = x, na.rm = na.rm, na_type = na_type, weights = weights, probs = 0.75, na_max_prop = na_max_prop, ...)
}

# p80 function
p80 <- function(x, na.rm = FALSE, na_type = "", weights = NULL, na_max_prop = NULL, ...) {
  summary_quantile(x = x, na.rm = na.rm, na_type = na_type, weights = weights, probs = 0.8, na_max_prop = na_max_prop, ...)
}

# p90 function
p90 <- function(x, na.rm = FALSE, na_type = "", weights = NULL, na_max_prop = NULL, ...) {
  summary_quantile(x = x, na.rm = na.rm, na_type = na_type, weights = weights, probs = 0.9, na_max_prop = na_max_prop, ...)
}

# Skewness e1071 function
summary_skewness <- function(x, weights = NULL, na.rm = FALSE, type = 2, na_type = "", ...) {
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if (missing(weights) || is.null(weights)) {
      return(e1071::skewness(x, na.rm = na.rm, type = type))
    }
    if (length(weights) != length(x)) stop("'x' and 'weights' must have the same length")
    if (na.rm) {
      i <- !is.na(x) && !is.na(weights)
      weights <- weights[i]
      x <- x[i]
    }
    ( sum( weights * (x - Weighted.Desc.Stat::w.mean(x, weights))^3 ) / sum(weights)) / Weighted.Desc.Stat::w.sd(x, weights)^3
  }
}

# skewness mc function
summary_skewness_mc <- function(x, na.rm = FALSE, na_type = "", ...) {
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    return(robustbase::mc(x, na.rm = na.rm))
  }
}

# skewness outlier limit function
summary_outlier_limit <- function(x, coef = 1.5, bupperlimit = TRUE, bskewedcalc = FALSE, skewnessweight = 4, na.rm = TRUE, na_type = "", omit = FALSE, value = 0, ...){ 
  if(omit){
    #This is needed when we need rainy days defined(Rain>=0.85)
    #if(value!=0){
    # x <- x[x>=value]
    #}else{
    x <- x[x>value]
    #}
  }
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    quart <- quantile(x, na.rm = na.rm)
    Q1 <- quart[[2]]
    Q3 <- quart[[4]]
    IQR <- Q3 - Q1
    MC <- 0
    if(bskewedcalc){
      MC <- robustbase::mc(x, na.rm = na.rm)
    }
    if(bupperlimit){
      Q3 + coef*exp(skewnessweight*MC)*IQR
    } else {
      Q1 - coef*exp(-skewnessweight*MC)*IQR
    }
  }
}

# kurtosis function
summary_kurtosis <- function(x, na.rm = FALSE, weights = NULL, type = 2, na_type = "", ...) {
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if (missing(weights) || is.null(weights)) {
      return(e1071::kurtosis(x, na.rm = na.rm, type = type))
    }
    if (length(weights) != length(x)) 
      stop("'x' and 'weights' must have the same length")
    if (na.rm) {
      i <- !is.na(x) && !is.na(weights)
      weights <- weights[i]
      x <- x[i]
    }
    ((sum(weights * (x - Weighted.Desc.Stat::w.mean(x, weights))^4)/sum(weights))/Weighted.Desc.Stat::w.sd(x, weights)^4) - 3
  }
}

# Coefficient of Variation function
summary_coef_var <- function(x, na.rm = FALSE, weights = NULL, na_type = "", ...) {
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if (missing(weights) || is.null(weights)) {
      return(summary_sd(x) / summary_mean(x))
    }
    if (length(weights) != length(x)) 
      stop("'x' and 'weights' must have the same length")
    if (na.rm) {
      i <- !is.na(x) && !is.na(weights)
      weights <- weights[i]
      x <- x[i]
    }
    Weighted.Desc.Stat::w.cv(x = x, mu = weights)
  }
}

# median absolute deviation function
summary_median_absolute_deviation <- function(x, constant = 1.4826, na.rm = FALSE, na_type = "", weights = NULL, low = FALSE, high = FALSE, ...) {
  if (na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else {
    if (missing(weights) || is.null(weights)) {
      return(stats::mad(x, constant = constant, na.rm = na.rm, low = low, high = high))
    }
    else {
      Weighted.Desc.Stat::w.ad(x = x, mu = weights)
    }
  }
}

# Qn function
summary_Qn <- function(x, constant = 2.21914, finite.corr = missing(constant), na.rm = FALSE, na_type = "", ...) {
  if(!na.rm && anyNA(x)) return(NA)
  else {
    if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
    else{
      x <- x[!is.na(x)]
      return(robustbase::Qn(x, constant = constant, finite.corr = finite.corr))
    }
  }
}

# Sn function
summary_Sn <- function(x, constant = 1.1926, finite.corr = missing(constant), na.rm = FALSE, na_type = "", ...) {
  if(!na.rm && anyNA(x)) return(NA)
  else {
    if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
    else{
      x <- x[!is.na(x)]
      return(robustbase::Qn(x, constant = constant, finite.corr = finite.corr))
    }
  }
}

# cor function
summary_cor <- function(x, y, na.rm = FALSE, na_type = "", weights = NULL, method = c("pearson", "kendall", "spearman"), cor_use = c("everything", "all.obs", "complete.obs", "na.or.complete", "pairwise.complete.obs"), ...) {
  cor_use <- match.arg(cor_use)
  if (na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else {
    if (missing(weights) || is.null(weights)) {
      return(cor(x = x, y = y, use = cor_use, method = method))
    }
    else {
      weights::wtd.cor(x = x, y = y, weight = weights)[1]
    }
  }
}

# cov function 
summary_cov <- function(x, y, na.rm = FALSE, weights = NULL, na_type = "", method = c("pearson", "kendall", "spearman"), use = c( "everything", "all.obs", "complete.obs", "na.or.complete", "pairwise.complete.obs"), ...) {
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if (missing(weights) || is.null(weights)) {
      return(cov(x = x, y = y, use = use, method = method))
    }
    if (length(weights) != length(x)) 
      stop("'x' and 'weights' must have the same length")
    if (na.rm) {
      i <- !is.na(x) && !is.na(weights)
      weights <- weights[i]
      x <- x[i]
    }
    (sum(weights * x * y)/sum(weights)) - (Weighted.Desc.Stat::w.mean(x = x, mu = weights) * Weighted.Desc.Stat::w.mean(x = y, mu = weights))
  }
}

# first function
summary_first <- function(x, order_by = NULL, ...) {
  return(dplyr::first(x = x, order_by = order_by))
}

# last function
summary_last <- function(x, order_by = NULL, ...) {
  return(dplyr::last(x = x, order_by = order_by))
}

# nth function
summary_nth <- function(x, nth_value, order_by = NULL, ...) {
  return(dplyr::nth(x = x, n = nth_value, order_by = order_by))
}

# n_distinct function
summary_n_distinct<- function(x, na.rm = FALSE, ...) {
  return(dplyr::n_distinct(x, na.rm = na.rm))
}

# sample function
summary_sample <- function(x, replace = FALSE, seed, ...){
  if(!missing(seed)) set.seed(seed = seed)
  return(sample(x = x, size = 1, replace = replace))
}

#Proportions functions
proportion_calc <- function(x, prop_test = "==", prop_value, As_percentage = FALSE, na.rm = FALSE, na_type = "", ... ){ 
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(!na.rm){
      if(sum(is.na(x)) > 0) return(NA)
      y <- x[eval(parse(text = paste("x", prop_value, sep = prop_test)))]
      if(!As_percentage){
        return(round(length(y)/length(x),digits = 2))
      }
      else {
        return(round((length(y)/length(x)*100),digits = 2 ))
      }  
    }
    else {
      remove.na <- na.omit(x)
      y <- remove.na[eval(parse(text = paste("remove.na", prop_value, sep = prop_test)))]
      if (!As_percentage){
        return(round(length(y)/length(remove.na), digits = 2))
      }
      else{
        return(round(length(y)/length(remove.na)*100, digits = 2 ))
      }
    }
  }
}

#count function
count_calc <- function(x, count_test = "==", count_value, na.rm = FALSE, na_type = "", ...){ 
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if (!na.rm){
      if (sum(is.na(x)) > 0) return(NA)
      return(length(x[eval(parse(text = paste("x", count_value, sep = count_test)))]))
    }
    else{
      y <- na.omit(x)
      return(length(y[eval(parse(text = paste("y", count_value, sep = count_test)))]))
    }
  }
}

#standard error of mean function
standard_error_mean <- function(x, na.rm = FALSE, na_type = "", ...){
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if (!na.rm){
      if(sum(is.na(x) > 0)) return(NA)
      return(sd(x)/sqrt(length(x)))
    }
    else{
      y <- na.omit(x)
      return(sd(y)/sqrt(length(y)))
    }
  }
}

#Verification functions 
#HydroGOF Package

#Mean error
me <- function(x, y, na.rm = FALSE, na_type = "", ...){
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(length(x[is.na(x)])==length(x)||length(y[is.na(y)])==length(y)) return(NA)
    return(hydroGOF::me(sim = y, obs = x, na.rm = na.rm))
  }
} 

#Mean absolute error
mae <- function(x, y, na.rm = FALSE, na_type = "", ...){
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(length(x[is.na(x)])==length(x)||length(y[is.na(y)])==length(y)) return(NA)
    return(hydroGOF::mae(sim = y, obs = x, na.rm = na.rm))
  }
} 

#Root mean square error
rmse <- function(x, y, na.rm = FALSE, na_type = "", ...){
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(length(x[is.na(x)])==length(x)||length(y[is.na(y)])==length(y)) return(NA)
    return(hydroGOF::rmse(sim = y, obs = x, na.rm = na.rm))
  }
}

#Normalised mean square error
nrmse <- function(x, y, na.rm = FALSE, na_type = "", ...){
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(length(x[is.na(x)])==length(x)||length(y[is.na(y)])==length(y)) return(NA)
    return(hydroGOF::nrmse(sim = y, obs = x, na.rm = na.rm))
  }
} 

#Percent bias
PBIAS <- function(x, y, na.rm = FALSE, na_type = "", ...){
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(length(x[is.na(x)])==length(x)||length(y[is.na(y)])==length(y)) return(NA)
    return(hydroGOF::pbias(sim = y, obs = x, na.rm = na.rm))
  }
}

#Nash-Sutcliffe efficiency
NSE <- function(x, y, na.rm = FALSE, na_type = "", ...){
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(length(x[is.na(x)])==length(x)||length(y[is.na(y)])==length(y)) return(NA)
    return(hydroGOF::NSeff(sim = y, obs = x, na.rm = na.rm))
  }
}

#Modified Nash-Sutcliffe efficiency
mNSE <- function(x, y, j = 1, na.rm = FALSE, na_type = "", ...){
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(length(x[is.na(x)])==length(x)||length(y[is.na(y)])==length(y)) return(NA)
    return(hydroGOF::mNSE(sim = y, obs = x, j = j, na.rm = na.rm))
  }
} 

#Relative Nash-Sutcliffe efficiency
rNSE <- function(x, y, na.rm = FALSE, na_type = "", ...){
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(length(x[is.na(x)])==length(x)||length(y[is.na(y)])==length(y)) return(NA)
    return(hydroGOF::rNSeff(sim = y, obs = x, na.rm = na.rm))
  }
}

#Index of agreement
d <- function(x, y, na.rm = FALSE, na_type = "", ...){
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(length(x[is.na(x)])==length(x)||length(y[is.na(y)])==length(y)) return(NA)
    return(hydroGOF::d(sim = y, obs = x, na.rm = na.rm))
  }
}

#Modified index of agreement
md <- function(x, y, j = 1, na.rm = FALSE, na_type = "", ...){
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(length(x[is.na(x)])==length(x)||length(y[is.na(y)])==length(y)) return(NA)
    return(hydroGOF::md(sim = y, obs = x, j = j,  na.rm = na.rm))
  }
}


#Relative index of agreement
rd <- function(x, y, na.rm = FALSE, na_type = "", ...){
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(length(x[is.na(x)])==length(x)||length(y[is.na(y)])==length(y)) return(NA)
    return(hydroGOF::rd(sim = y, obs = x, na.rm = na.rm))
  }
}


#Coefficient of determination
R2 <- function(x, y, na.rm = FALSE, na_type = "", ...){
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(length(x[is.na(x)])==length(x)||length(y[is.na(y)])==length(y)) return(NA)
    return(hydroGOF::br2(sim = y, obs = x, na.rm = na.rm))
  }
}

#Coefficient of persistence
cp <- function(x, y, na.rm = FALSE, na_type = "", ...){
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(length(unique(y))==1||length(x[is.na(x)])==length(x)||length(y[is.na(y)])==length(y)) return(NA)
    return(hydroGOF::cp(sim = y, obs = x, na.rm = na.rm))
  }
}

#Kling-Gupta efficiency
KGE <- function(x, y, na.rm = FALSE, na_type = "", ...){
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(length(x[is.na(x)])==length(x)||length(y[is.na(y)])==length(y)) return(NA)
    return(hydroGOF::KGE(sim = y, obs = x, na.rm = na.rm))
  }
}

#mean squared error
mse <- function(x, y, na.rm = FALSE, na_type = "", ...){
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(length(x[is.na(x)])==length(x)||length(y[is.na(y)])==length(y)) return(NA)
    return(hydroGOF::mse(sim = y, obs = x, na.rm = na.rm))
  }
} 


#Ratio of standard deviations
rSD <- function(x, y, na.rm = FALSE, na_type = "", ...){
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(length(x[is.na(x)])==length(x)||length(y[is.na(y)])==length(y)) return(NA)
    return(hydroGOF::rSD(sim = y, obs = x, na.rm = na.rm))
  }
}

#Ratio of RMSE
rsr <- function(x, y, na.rm = FALSE, na_type = "", ...){
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(length(x[is.na(x)])==length(x)||length(y[is.na(y)])==length(y)) return(NA)
    return(hydroGOF::rsr(sim = y, obs = x, na.rm = na.rm))
  }
}

#Sum of squared residuals
ssq <- function(x, y, na.rm = FALSE, na_type = "", ...){
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(length(x[is.na(x)])==length(x)||length(y[is.na(y)])==length(y)) return(NA)
    return(hydroGOF::ssq(sim = y, obs = x, na.rm = na.rm))
  }
}

#Volumetric efficiency
VE <- function(x, y, na.rm = FALSE, na_type = "", ...){
  if(na.rm && na_type != "" && !na_check(x, na_type = na_type, ...)) return(NA)
  else{
    if(length(x[is.na(x)])==length(x)||length(y[is.na(y)])==length(y)) return(NA)
    return(hydroGOF::VE(sim = y, obs = x, na.rm = na.rm))
  }
}

#Verification package

#Categorical/Categorical

##Percent Correct  
pc <- function(x, y, frcst.type, obs.type, ...){
  A <- verification::verify(obs = x, pred = y,  frcst.type = frcst.type, obs.type = obs.type)
  return(A$pc)  
}

##Heidke Skill Score   
hss <- function(x, y, frcst.type, obs.type, ...){
  A <- verification::verify(obs = x, pred = y,  frcst.type = frcst.type, obs.type = obs.type)
  return(A$hss)  
}

##Pierce Skill Score   
pss <- function(x, y, frcst.type, obs.type, ...){
  A <- verification::verify(obs = x, pred = y,  frcst.type = frcst.type, obs.type = obs.type)
  return(A$pss)  
}

##Gerrity Score       
GS <- function(x, y, frcst.type, obs.type, ...){
  A <- verification::verify(obs = x, pred = y,  frcst.type = frcst.type, obs.type = obs.type)
  return(A$gs)  
}

#Binary/Binary

##Hit rate aka PODy
PODy <- function(x, y, frcst.type, obs.type, ...){
  A <- verification::verify(obs = x, pred = y,  frcst.type = frcst.type, obs.type = obs.type)
  return(A$POD)  
}

##Threat score
TS <- function(x, y, frcst.type, obs.type, ...){
  A <- verification::verify(obs = x, pred = y,  frcst.type = frcst.type, obs.type = obs.type)
  return(A$TS)  
}

##Equitable threat score
ETS <- function(x, y, frcst.type, obs.type, ...){
  A <- verification::verify(obs = x, pred = y,  frcst.type = frcst.type, obs.type = obs.type)
  return(A$ETS)  
}

##False alarm ratio
FAR <- function(x, y, frcst.type, obs.type, ...){
  A <- verification::verify(obs = x, pred = y,  frcst.type = frcst.type, obs.type = obs.type)
  return(A$FAR)  
}

##Heidke skill score
HSS <- function(x, y, frcst.type, obs.type, ...){
  A <- verification::verify(obs = x, pred = y,  frcst.type = frcst.type, obs.type = obs.type)
  return(A$HSS)  
}

##Percent correct
PC <- function(x, y, frcst.type, obs.type, ...){
  A <- verification::verify(obs = x, pred = y,  frcst.type = frcst.type, obs.type = obs.type)
  return(A$PC)  
}

##Bias
BIAS <- function(x, y, frcst.type, obs.type, ...){
  A <- verification::verify(obs = x, pred = y,  frcst.type = frcst.type, obs.type = obs.type)
  return(A$BIAS)  
}

##Extreme dependency score
EDS <- function(x, y, frcst.type, obs.type, ...){
  A <- verification::verify(obs = x, pred = y,  frcst.type = frcst.type, obs.type = obs.type)
  return(A$eds)  
}

##Symmetric extreme dependency score
SEDS <- function(x, y, frcst.type, obs.type, ...){
  A <- verification::verify(obs = x, pred = y,  frcst.type = frcst.type, obs.type = obs.type)
  return(A$seds)  
}

##Extremal dependency index
EDI <- function(x, y, frcst.type, obs.type, ...){
  A <- verification::verify(obs = x, pred = y,  frcst.type = frcst.type, obs.type = obs.type)
  return(A$EDI)  
}

##Symmetric Extremal dependence index
SEDI <- function(x, y, frcst.type, obs.type, ...){
  A <- verification::verify(obs = x, pred = y,  frcst.type = frcst.type, obs.type = obs.type)
  return(A$SEDI)  
}

##TODO:Check if there are summaries that only apply to (Probabilistic-binary) types.

DataBook$set("public", "summary_table", function(data_name, columns_to_summarise = NULL, summaries, factors = c(), store_table = FALSE, store_results = FALSE, drop = TRUE, na.rm = FALSE, summary_name = NA, include_margins = FALSE, margins = "outer", return_output = FALSE, treat_columns_as_factor = FALSE, page_by = NULL, signif_fig = 2, na_display = "", na_level_display = "NA", weights = NULL, caption = NULL, result_names = NULL, percentage_type = "none", perc_total_columns = NULL, perc_total_factors = c(), perc_total_filter = NULL, perc_decimal = FALSE, include_counts_with_percentage = FALSE, margin_name = "(All)", additional_filter, ...) {
  # TODO: write in errors
  if (na_level_display == "") stop("na_level_display must be a non empty string")
  # removes "summary_" from beginning of summary function names so that display is nice
  summaries_display <- sapply(summaries, function(x) ifelse(startsWith(x, "summary_"), substring(x, 9), x))
  
  # todo: add in code to store results if store_results = TRUE on the dialog
  # only give this option if there is 1 column factor.
  if (!store_results) {
    save <- 0
  } else {
    save <- 2
  }

  cell_values <- self$calculate_summary(data_name = data_name, columns_to_summarise = columns_to_summarise, summaries = summaries, factors = factors, store_results = FALSE, drop = drop, na.rm = na.rm, return_output = TRUE, weights = weights, result_names = result_names, percentage_type = percentage_type, perc_total_columns = perc_total_columns, perc_total_factors = perc_total_factors, perc_total_filter = perc_total_filter, perc_decimal = perc_decimal, include_counts_with_percentage = include_counts_with_percentage, margin_name = margin_name, additional_filter = additional_filter, perc_return_all = FALSE, signif_fig = signif_fig, sep = "__", ...)
  for (i in seq_along(factors)) {
    levels(cell_values[[i]]) <- c(levels(cell_values[[i]]), na_level_display)
    cell_values[[i]][is.na(cell_values[[i]])] <- na_level_display
  }
  cell_values <- cell_values %>% dplyr::mutate(dplyr::across(where(is.numeric), round, signif_fig))
  cell_values <- cell_values %>%
    tidyr::pivot_longer(cols = !factors, names_to = "summary-variable", values_to = "value", values_transform = list(value = as.character))
  if (treat_columns_as_factor && !is.null(columns_to_summarise)) {
    cell_values <- cell_values %>%
      tidyr::separate(col = "summary-variable", into = c("summary", "variable"), sep = "__")
  }
  shaped_cell_values <- cell_values %>% dplyr::relocate(value, .after = last_col())
  
  for (i in seq_along(factors)) {
    levels(shaped_cell_values[[i]]) <- c(levels(shaped_cell_values[[i]]), margin_name) 
  }
  
  # If margins ---------------------------------------------------------------------------
  if (include_margins) {
    margin_tables <- list()
    power_sets <- rje::powerSet(factors)
    # We could need last set if only have row or column factors
    power_sets_outer <- power_sets[-(c(length(power_sets)))]
    if (treat_columns_as_factor && !is.null(columns_to_summarise)) {
      order_names <- unique(paste(shaped_cell_values$summary, shaped_cell_values$variable, sep = "__"))
    } else {
      order_names <- unique(shaped_cell_values$summary)
    }
    for (facts in power_sets_outer) {
      if (length(facts) == 0) facts <- c()
      margin_tables[[length(margin_tables) + 1]] <- self$calculate_summary(data_name = data_name, columns_to_summarise = columns_to_summarise, summaries = summaries, factors = facts, store_results = FALSE, drop = drop, na.rm = na.rm, return_output = TRUE, weights = weights, result_names = result_names, percentage_type = percentage_type, perc_total_columns = perc_total_columns, perc_total_factors = perc_total_factors, perc_total_filter = perc_total_filter, perc_decimal = perc_decimal, include_counts_with_percentage = include_counts_with_percentage, margin_name = margin_name, additional_filter = additional_filter, perc_return_all = FALSE, signif_fig = signif_fig, sep = "__", ...)
    }
    # for outer margins
    margin_item <- length(summaries) * length(columns_to_summarise)
    
    if (("outer" %in% margins) && (length(factors) > 0)) {
      # to prevent changing all variables to dates/converting dates to numeric
      for (i in 1:length(margin_tables)){
        margin_tables[[i]] <- margin_tables[[i]] %>% dplyr::mutate(dplyr::across(where(is.numeric), round, signif_fig))
        margin_tables[[i]] <- margin_tables[[i]] %>% purrr::modify_if(lubridate::is.Date, as.character)
      }
      outer_margins <- plyr::ldply(margin_tables)
      # Change shape
      if (length(margin_tables) == 1) {
        outer_margins <- plyr::ldply(margin_tables[[1]])
        names(outer_margins) <- c("summary-variable", "value")
      } else {
        outer_margins <- outer_margins %>%
          tidyr::pivot_longer(cols = 1:margin_item, values_to = "value", names_to = "summary-variable", values_transform = list(value = as.character))
      }
      if (treat_columns_as_factor && !is.null(columns_to_summarise)) {
        outer_margins <- outer_margins %>%
          tidyr::separate(col = "summary-variable", into = c("summary", "variable"), sep = "__")
      }
    } else {
      outer_margins <- NULL
    }
    if ("summary" %in% margins || ("outer" %in% margins && length(factors) == 0)) {
      summary_margins <- NULL
      if (is.null(columns_to_summarise)){
        power_sets_summary <- power_sets[-(length(power_sets))]
      } else {
        if ("outer" %in% margins) {
          power_sets_summary <- power_sets
        } else {
          power_sets_summary <- power_sets[(c(length(power_sets)))]
        }
      }
      
      for (facts in power_sets_summary) {
        if (length(facts) == 0) facts <- c()
        if (is.null(columns_to_summarise)){
          summary_margins_df <- data_book$get_data_frame(data_name = data_name) %>%
            dplyr::select(c(tidyselect::all_of(factors)))
          data_book$import_data(data_tables = list(summary_margins_df = summary_margins_df))
          summary_margins[[length(summary_margins) + 1]] <- data_book$calculate_summary(data_name = "summary_margins_df", columns_to_summarise = NULL, summaries = summaries, factors = facts, store_results = FALSE, drop = drop, na.rm = na.rm, return_output = TRUE, weights = weights, result_names = result_names, percentage_type = percentage_type, perc_total_columns = perc_total_columns, perc_total_factors = perc_total_factors, perc_total_filter = perc_total_filter, perc_decimal = perc_decimal, include_counts_with_percentage = include_counts_with_percentage, margin_name = margin_name, additional_filter = additional_filter, perc_return_all = FALSE, signif_fig = signif_fig, ...)
        } else {
          summary_margins_df <- data_book$get_data_frame(data_name = data_name) %>%
            dplyr::select(c(tidyselect::all_of(factors), tidyselect::all_of(columns_to_summarise))) %>%
            tidyr::pivot_longer(cols = columns_to_summarise, values_transform = list(value = as.character))
          data_book$import_data(data_tables = list(summary_margins_df = summary_margins_df))
          summary_margins[[length(summary_margins) + 1]] <- data_book$calculate_summary(data_name = "summary_margins_df", columns_to_summarise = "value", summaries = summaries, factors = facts, store_results = FALSE, drop = drop, na.rm = na.rm, return_output = TRUE, weights = weights, result_names = result_names, percentage_type = percentage_type, perc_total_columns = perc_total_columns, perc_total_factors = perc_total_factors, perc_total_filter = perc_total_filter, perc_decimal = perc_decimal, include_counts_with_percentage = include_counts_with_percentage, margin_name = margin_name, additional_filter = additional_filter, perc_return_all = FALSE, signif_fig = signif_fig, ...)
          
        }
        data_book$delete_dataframes(data_names = "summary_margins_df")
      }
      summary_margins <- plyr::ldply(summary_margins)
      if (treat_columns_as_factor && !is.null(columns_to_summarise)) {
        # remove "_value" in them
        for (col in 1:ncol(summary_margins)) {
          colnames(summary_margins)[col] <- sub("_value", "", colnames(summary_margins)[col])
        }
        summary_margins <- summary_margins %>%
          tidyr::pivot_longer(cols = !factors, names_to = "summary", values_to = "value", values_transform = list(value = as.character))
      } else {
        if (length(summary_margins) == 1) {
          summary_margins <- data.frame(summary_margins, `summary-variable` = "count", factors = NA)
          names(summary_margins) <- c("value", "summary-variable", factors)
        }else {
          for (col in 1:ncol(summary_margins)) {
            # TODO: if the colname is the same as a factor, then do nothing
            colnames(summary_margins)[col] <- sub("_value", "_all", colnames(summary_margins)[col])
          }
          summary_margins <- summary_margins %>% dplyr::mutate(dplyr::across(where(is.numeric), round, signif_fig))
          summary_margins <- summary_margins %>%
            tidyr::pivot_longer(cols = !factors, names_to = "summary-variable", values_to = "value", values_transform = list(value = as.character))
        }
      }
    } else {
      summary_margins <- NULL
    }
    if (!is.null(summary_margins) || !is.null(outer_margins)) {
      margin_tables_all <- (dplyr::bind_rows(summary_margins, outer_margins))
      margin_tables_all <- margin_tables_all %>%
        dplyr::mutate_at(vars(-value), ~ replace(., is.na(.), margin_name)) %>%
        dplyr::mutate(value = as.character(value))
      
      # if there is one factor, then we do not yet have the factor name in the df
      # (this will be added in by dplyr::bind_rows(s_c_v, m_t_a))
      # by introducing it in the outer_margins bit, we have to add it in "manually"
      # this then loses the class of it, creating issues for ordered vs non-ordered factors
      # so we do these changes here.
      if (length(factors) > 1){
        for (i in factors){
          shaped_cell_values_levels <- levels(shaped_cell_values[[i]])
          margin_tables_all <- margin_tables_all %>%
            dplyr::mutate_at(i, ~ forcats::fct_expand(., shaped_cell_values_levels),
                             i, ~ forcats::fct_relevel(., shaped_cell_values_levels))
        }     
      }
      shaped_cell_values <- dplyr::bind_rows(shaped_cell_values, margin_tables_all) %>%
        dplyr::mutate_at(vars(-c(value)), tidyr::replace_na, margin_name) %>%
        dplyr::mutate_at(vars(-c(value)), ~forcats::as_factor(forcats::fct_relevel(.x, margin_name, after = Inf)))
    }
  }
  # To all data --------------------------------------------------------------------------
  # Used to make all values numeric, but stopped because of issues with ordered factors/dates.
  # I don't think this line is needed anymore, but will keep it commented for now in case it becomes more apparent in the future
  #if (percentage_type == "none" || include_counts_with_percentage == FALSE){
  #  shaped_cell_values <- shaped_cell_values %>% dplyr::mutate(value = as.numeric(as.character(value)),
  #                                                             value = round(value, signif_fig))
  #}
  if (treat_columns_as_factor && !is.null(columns_to_summarise)){
    shaped_cell_values <- shaped_cell_values %>%
      dplyr::mutate(summary = as.factor(summary)) %>% dplyr::mutate(summary = forcats::fct_relevel(summary, summaries_display)) %>%
      dplyr::mutate(variable = as.factor(variable)) %>% dplyr::mutate(variable= forcats::fct_relevel(variable, columns_to_summarise))
  }
  if (!treat_columns_as_factor && !is.null(columns_to_summarise)){
   shaped_cell_values <- shaped_cell_values %>%
       dplyr::mutate(`summary-variable` = forcats::as_factor(`summary-variable`))
   }
  if (store_table) {
    data_book$import_data(data_tables = list(shaped_cell_values = shaped_cell_values))
  }
  return(tibble::as_tibble(shaped_cell_values))
})
