calculation <- R6Class("calculation",
                         public = list(
                           initialize = function(function_name = "", parameters = list(), 
                                                 calculated_from = c(), is_recalculable = TRUE,
                                                 sub_calculations = list(), type = "", filter_conditions = list(),
                                                 filters = list(), name = "") {
                             self$function_name = function_name
                             self$parameters = parameters
                             self$calculated_from = c()
                             self$is_recalculable = is_recalculable
                             self$sub_calculations = sub_calculations
                             self$type = type
                             self$name = name
                             self$filter_conditions = filter_conditions
                             self$filters = filters
                           },
                           function_name = "",
                           parameters = list(), 
                           calculated_from = c(),
                           is_recalculable = TRUE,
                           sub_calculations = list(),
                           filter_conditions = list(),
                           filters = list(),
                           name = "",
                           type = ""
                         )
                       # ,
                       # Removed because filter_conditions can be public
                       # private = list(
                       #   .filter_conditions = list()
                       # )
                       # ,
                       # active = list(
                       #   filter_conditions = function(new_filter_conditions) {
                       #     if(missing(new_filter_conditions)) return(private$.filter_conditions)
                       #     else private$.filter_conditions <- new_filter_conditions
                       #   }
                       # )
)

calculation$set("public", "add_sub_calculation", function(sub_calculation, name) {
  sub_calculations[[name]] <- sub_calculation
}
)

calculation$set("public", "data_clone", function() {
  ret <- calculation$new(function_name = self$function_name, parameters = self$parameters, 
                         calculated_from = self$calculated_from, is_recalculable = self$is_recalculable,
                         sub_calculations = self$sub_calculations, type = self$type, 
                         filter_conditions = self$filter_conditions, filters = self$filters,
                         name = self$name)
  return(ret)
}
)

# calculation$set("public", "data_clone", function() {
#   ret = calculation$new(function_name = private$function_name, parameters = private$parameters, calculated_from = private$calculated_from, is_recalculable = private$is_recalculable, sub_calculations = private$sub_calculations, type = private$type, filter_conditions = private$.filter_conditions)
#   sub_calculations[[name]] <- sub_calculation
# }
# )

instat_object$set("public", "apply_calculation", function(calc) {
  if(calc$type == "summary") {
    out <- self$get_data_objects(calc[["parameters"]][["data_name"]])$calculate_summary(calc = calc, ... = calc[["parameters"]][["..."]])
    if(calc[["parameters"]][["store_results"]]) self$append_summaries_to_data_object(out, calc[["parameters"]][["data_name"]], calc[["parameters"]][["columns_to_summarise"]], calc[["parameters"]][["summaries"]], calc[["parameters"]][["factors"]], calc[["parameters"]][["summary_name"]], calc)
    if(calc[["parameters"]][["return_output"]]) return(out)
    else return(NULL)
  }
}
)

instat_object$set("public", "save_calculation", function(end_data_frame, calc) {
  self$get_data_objects(end_data_frame)$save_calculation(calc)
}
)

data_object$set("public", "save_calculation", function(calc) {
  if(calc$name == "") calc$name <- next_default_item("calc", names(private$calculations))
  if(calc$name %in% names(private$calculations)) warning("There is already a calculation called ", calc$name, ". It will be replaced.")
  private$calculations[[calc$name]] <- calc
  return(calc$name)
}
)

# class to store calculations
# Fields:
# function_exp     : string - passed directly to one of dplyr functions e.g. "Yield > 50" for a filter or "Yield * Size" for a calculation
# type             : string - one of "by", "calculation", "filter", "summary", "combination" to determine the type of calculation to do
#                             each corresponds directly to one of dplyr's functions (except combination).
#                             "by" - for dplyr's "group_by", to group the data by column(s) (usually factors) in preparation for doing summaries, for example.
#                             "sort" - for dplyr's "arrange", to sort the data by column(s)
#                             "calculation" - for dplyr's "mutate", a simple calculation to produce a column within the same data frame
#                             "filter" - for dplyr's "filter", to filter the rows of a data frame by any logical expression
#                             "summary" - for dplyr's "summarise", to produce summaries. Produces a singple value unless the data is already grouped, 
#                                         and then one value for each "group" is produced.
#                             "combunation" - for calculations which contain sub calculations (and possibly mutations) but no main calculation is needed.
# name             : string - a name for the calculation. If save_calc = FALSE then name is not used anywhere.
# result_name      : string - a name for the output (usually a column) produced by the calculation e.g. "YieldDouble"
# result_data_frame : string - a name for the data frame that the output should go to. This could be an existing data frame on a new one
#                             the default, "", means the linking system will be used to determine the data frame the output should below to
# manipulations    : list   - a list of calculations to be performed before any sub_calculations and the main calculation is performed.
#                             the order of these is important, as the output from each manipulation is the input to the next manipulation
#                             the output of the final manipulation is the input for all sub_calculations
#                             these are typically "by" and "filter" calculations, but could be any
# sub_calculations : list   - a list of calculations to be performed after manipulations, but before the main calculation
#                             typically these are calculations which must be calculated before the main calculation can be done.
#                             the output of the final manipulation is the input for all sub_calculations
#                             the order is not important, as the output from each sub_calculation is not passed as the input to the next sub_calculation
#                             If the order is important, then manipulations should be used instead.
# calculated_from  : list   - a list with values as the names of the columns the calculation depends on, 
#                             and names as the names of the data frames corresponding the columns e.g. list(survey = "Yield", survey = "Size")
# save             : integer- either, 0: nothing is saved, 1: calculation is saved but not the result or 2: calculation and result is saved
#                             (saving the result without saving the calculation was decided not to be a sensible option - prevents recalculating etc.
#                              saving calculation only is useful to reproduce results in output window without needing to save in a data frame e.g. single value summaries)  

instat_calculation <- R6Class("instat_calculation",
                       public = list(
                         initialize = function(function_exp = "", type = "", name = "", result_name = "", result_data_frame = "", manipulations = list(),
                                               sub_calculations = list(), calculated_from = list(), save = 0) {
                           if((type == "calculation" || type == "summary") && missing(result_name)) stop("result_name must be provided for calculation and summary types")
                           if(type == "combination" && save > 0) {
                             warning("combination types do not have a main calculation which can be saved. save_output will be stored as FALSE")
                             save <- 0
                             #TODO Should this do something else like set save_output = TRUE for all sub_calculations?
                           }
                           self$function_exp <- function_exp
                           self$type <- type
                           self$name <- name
                           self$result_name <- result_name
                           self$result_data_frame <- result_data_frame
						               self$manipulations <- manipulations
                           self$sub_calculations <- sub_calculations
                           self$calculated_from <- calculated_from
                           self$save <- save
                         },
                         name = "",
                         result_name = "",
						             result_data_frame = "",
                         type = "",
                         manipulations = list(),
                         sub_calculations = list(),
                         function_exp = "",
                         calculated_from = list(),
                         save = 0
                       )
)

instat_calculation$set("public", "data_clone", function() {
  ret <- instat_calculation$new(function_exp = self$function_exp, type = self$type,
                         name = self$name, result_name = self$result_name, 
                         manipulations = lapply(self$manipulations, function(x) x$data_clone()), 
                         sub_calculations = lapply(self$sub_calculations, function(x) x$data_clone()),
                         calculated_from = self$calculated_from, save = self$save)
  return(ret)
}
)

# Calculation labels
#These are the names of the list returned by apply_instat_calculation
c_data_label <- "data"
c_link_label <- "link"
c_has_summary_label <- "has_summary"
c_has_filter_label <- "has_filter"

# This performs the calculation, including saving the output and calculation if required.
# A list of 4 elements is returned:
# $data : a data frame containing the output from the calculation, usually not just the output but also other columns at the same "level"
# $link : a link used to determine which data frame the output should be saved in.
# $has_summary : a logical value indicating whether a summary has been done
# $has_filter : a logical value indicating whether a filter has been done

# This method is called recursively, and it would not be called by a user, another function would always handle the output and display
# results to the user (usually only the $data part of the list)
instat_object$set("public", "apply_instat_calculation", function(calc, curr_data_list, previous_manipulations = list()) {
  
  # apply each manipulation first, and recursively store the output and pass to the next manipulation
  # because of this, manipulations are dependant on each other
  for(manipulation in calc$manipulations) {
    curr_data_list <- self$apply_instat_calculation(manipulation, curr_data_list, previous_manipulations)
    previous_manipulations[[length(previous_manipulations) + 1]] <- manipulation
  }
  # If curr_data_list is not empty, (either an argument or from manipulations)
  # then this is passed in to apply_instat_calculation for each sub_calculation
  # sub_calculations are independant of each other (the order does not affect the output)
  if(!missing(curr_data_list)) {
    sub_calc_results <- curr_data_list
    curr_groups <- groups(curr_data_list[[c_data_label]])
  }
  else curr_groups <- c()
  first_sub_calc <- TRUE
  
  for(sub_calc in calc$sub_calculations) {
    curr_sub_calc <- self$apply_instat_calculation(sub_calc, curr_data_list, previous_manipulations)
    if(first_sub_calc) {
      sub_calc_results <- curr_sub_calc
      first_sub_calc <- FALSE
    }
    else {
      #### Set the require_merge logical
      # Defined as variables as these are needed later 
      #overall_merge_required <- sub_calc_results[[c_require_merge_label]]
      #current_calc_merge_required <- curr_sub_calc[[c_require_merge_label]]
      overall_has_summary <- sub_calc_results[[c_has_summary_label]]
      overall_has_filter <- sub_calc_results[[c_has_filter_label]]
      current_calc_has_summary <- curr_sub_calc[[c_has_summary_label]]
      current_calc_has_filter <- curr_sub_calc[[c_has_filter_label]]
      
      # A merge is required if a merge was already required, or if the current sub_calculation requires a merge
      #sub_calc_results[[c_require_merge_label]] <- overall_merge_required || current_calc_merge_required
      # TODO how to set new values for has summary/filter

      #### Set the data and link
      # Defined as variables as these are used throughout 
      curr_calc_link_cols <- curr_sub_calc[[c_link_label]][["link_cols"]]
      overall_calc_link_cols <- sub_calc_results[[c_link_label]][["link_cols"]]
      curr_calc_from <- curr_sub_calc[[c_link_label]][["from_data_frame"]]
      overall_calc_from <- sub_calc_results[[c_link_label]][["from_data_frame"]]
      
      # Warning if current sub calc result is already in the data
      if(sub_calc$result_name %in% names(sub_calc_results[[c_data_label]])) warning(sub_calc$result_name, " is already a column in the existing data. The column will be replaced. This may have unintended consequences for the calculation")
      
      # If either calc is a single value summary we don't do a merge.
      if((current_calc_has_summary && length(curr_calc_link_cols) == 0) || (overall_has_summary && length(overall_calc_link_cols) == 0)) {
        # Don't think this needs to be done separately now
        # If both calcs are single value summaries
        # if(current_calc_has_summary && length(curr_calc_link_cols) == 0 && overall_has_summary && length(overall_calc_link_cols) == 0) {
        #   sub_calc_results[[c_data_label]] <- mutate(sub_calc_results[[c_data_label]], curr_sub_calc[[c_data_label]])
        # }
        
        # If curr_calc is a single value, add this on to overall data as new column
        # QUESTION: Should there be checks here? This "works" with any two data frames
        #           because it's just adding a single value as a new column
        if(current_calc_has_summary && length(curr_calc_link_cols) == 0) {
          sub_calc_results[[c_data_label]][[sub_calc$result_name]] <- curr_sub_calc[[c_data_label]][[1]]
        }
        # If only overall is a single value, add this on to the current sub calc output
        # QUESTION: Should there be checks here? This "works" with any two data frames
        #           because it's just adding a single value as a new column
        else if(overall_has_summary && length(overall_calc_link_cols) == 0 && !(current_calc_has_summary && length(curr_calc_link_cols) == 0)) {
          temp_data <- curr_sub_calc[[c_data_label]]
          temp_data[[names(sub_calc_results[[c_data_label]])[1]]] <- sub_calc_results[[c_data_label]][[1]]
          sub_calc_results[[c_data_label]] <- temp_data
          sub_calc_results[[c_has_summary_label]] <- curr_sub_calc[[c_has_summary_label]]
          sub_calc_results[[c_has_filter_label]] <- curr_sub_calc[[c_has_filter_label]]
          sub_calc_results[[c_link_label]] <- curr_sub_calc[[c_link_label]]
          #TODO Multiple links needed
          #     Above changes the from_data_frame. Is that what we want?
        }
      }
      # In this case, both are simple calculations on the same data frame without filters
      # So we just add a column instead of a merge.
      else if(curr_calc_from == overall_calc_from && !overall_has_summary && !overall_has_filter && !current_calc_has_summary && !current_calc_has_filter) {
        sub_calc_results[[c_data_label]][[sub_calc$result_name]] <- curr_sub_calc[[c_data_label]][[sub_calc$result_name]]
      }
      # Otherwise we must do a merge.
      # If we can't do a merge, we stop here.
      else {
        # To be able to do a merge, a key in one of the DFs must be "equivalent" to a subset of a key in the other
        # If the DF is a summary, then the link columns define the only key
        if(overall_has_summary) {
          overall_links <- list()
          overall_links[[1]] <- overall_calc_link_cols
        }
        # Otherwise, there must be existing keys defined in the data frame
        else {
          if(!self$has_key(overall_calc_from))  stop("Cannot merge sub calculations as there is no key defined in ", overall_calc_from)
          overall_links <- self$get_keys(overall_calc_from)
        }
        if(current_calc_has_summary) {
          curr_calc_links <- list()
          curr_calc_links[[1]] <- curr_calc_link_cols
        }
        else {
          if(!self$has_key(curr_calc_from))  stop("Cannot merge sub calculations as there is no key defined in ", curr_calc_from)
          curr_calc_links <- self$get_keys(curr_calc_from)
        }
        by <- NULL
        for(temp_overall_link in overall_links) {
          for(temp_curr_link in curr_calc_links) {
            equ_curr_cols <- self$get_equivalent_columns(overall_calc_from, temp_overall_link, curr_calc_from)
            if(length(equ_curr_cols) > 0 && all(equ_curr_cols %in% temp_curr_link)) {
              by <- temp_overall_link
              names(by) <- equ_curr_cols
              join_into_overall <- FALSE
              break
            }
            equ_overall_cols <- self$get_equivalent_columns(curr_calc_from, temp_curr_link, overall_calc_from)
            if(length(equ_overall_cols) > 0 && all(equ_overall_cols %in% temp_overall_link)) {
              by <- temp_curr_link
              names(by) <- equ_overall_cols
              join_into_overall <- TRUE
              break
            }
            
          }
          if(length(by) > 0) break
        }
        if(length(by) == 0) {
          stop("Cannot find linking columns to merge output from sub calculations.")
        }
        
        # If the data frames are the same and filters have been used then need to subset before the join
        # so that we don't get duplicate columns
        joined <- FALSE
        if(curr_calc_from == overall_calc_from) {
          if(overall_has_filter && current_calc_has_filter) {
            # If both sub calcs have filter then the order of the rows in the output may not be sensible
            # if filters are different but this case should be rare
            # To avoid possibly losing data by subsetting columns we don't subset here and instead add to by columns
            additional_cols <- intersect(names(sub_calc_results[[c_data_label]]), names(curr_sub_calc[[c_data_label]]))
            additional_cols <- additional_cols[!additional_cols %in% by]
            if(length(additional_cols) > 0) by <- c(by, additional_cols)
            sub_calc_results[[c_data_label]] <- full_join(curr_sub_calc[[c_data_label]], sub_calc_results[[c_data_label]], by = by)
            joined <- TRUE
          }
          else if(overall_has_filter) {
            # If the overall data has a filter and current does not, then we should merge the overall into the current
            # We subset the current data to only have by and the output columns so that merge doesn't produce duplicate columns
            # Overall sub data should be full data so we don't lose any data by subsetting the current sub calc
            sub_calc_results[[c_data_label]] <- full_join(curr_sub_calc[[c_data_label]][c(as.vector(by), sub_calc$result_name)], sub_calc_results[[c_data_label]], by = by)
            # Current data has no filter so output now does not
            sub_calc_results[[c_has_filter_label]] <- FALSE
            joined <- TRUE
          }
          else if(current_calc_has_filter) {
            # If the current data has a filter and overall does not, then we should merge the current into the overall
            # We subset the current data to only have by and output columns so that merge doesn't produce duplicate columns
            # Overall sub data should be full data so we don't lose any data by subsetting the current sub calc
            sub_calc_results[[c_data_label]] <- full_join(sub_calc_results[[c_data_label]], curr_sub_calc[[c_data_label]][c(as.vector(by), sub_calc$result_name)], by = by)
            # Overall data has no filter so output does even though current does
            joined <- TRUE
          }
        }
        if(!joined) {
          if(join_into_overall) sub_calc_results[[c_data_label]] <- full_join(sub_calc_results[[c_data_label]], curr_sub_calc[[c_data_label]], by = by)
          else {
            sub_calc_results[[c_data_label]] <- full_join(curr_sub_calc[[c_data_label]], sub_calc_results[[c_data_label]], by = by)
            # The overall data will be joined into the current sub calc, so this becomes the new link
            sub_calc_results[[c_link_label]] <- curr_sub_calc[[c_link_label]]
          }
        }
      }
    }
  }

  # If there were any sub_calculations then the input for the main calculation should be the output from the last sub_calculation
  # Otherwise it is the output from the mainipulations
  if(!first_sub_calc) curr_data_list <- sub_calc_results
  
  #TODO investigate better way to do this
  #     Any case where we don't want this?
  for(var in curr_groups) {
    curr_data_list[[c_data_label]] <- curr_data_list[[c_data_label]] %>% group_by_(var, add = TRUE)
  }
  

  # Names of the data frames required for the calculation
  data_names <- unique(as.vector(names(calc$calculated_from)))
  # If argument was missing and there were no manipulations or sub_calculations then it should be created.
  if(missing(curr_data_list)) {
    if(length(data_names) == 0) stop("No data specified for calculation.")
    #else if(length(data_names) > 1) stop("Calculations from multiple data frame not yet implemented")
    else {
      curr_data_list <- list()
      #TODO Add current filter as manipulation in calc definition if needed.
      # The data is the data from the instat object based on data_names
      curr_data_list[[c_data_label]] <- self$get_data_frame(data_names[[1]], use_current_filter = FALSE)
      # The link has from_data_frame based on data_names and no current linking columns
      link_list <- list(data_names[[1]], c())
      names(link_list) <- c("from_data_frame", "link_cols")
      curr_data_list[[c_link_label]] <- link_list
      # By default, a summary or filter has not been done
      #curr_data_list[[c_require_merge_label]] <- FALSE
      curr_data_list[[c_has_summary_label]] <- FALSE
      curr_data_list[[c_has_filter_label]] <- FALSE
    }
  }
  
  col_names_exp = c()
  i = 1
  # This checks that the columns specified in calculated_from appear in the current data
  for(i in seq_along(calc$calculated_from)) {
    col_name <- calc$calculated_from[[i]]
    data_frame_name <- names(calc$calculated_from)[i]
    overall_calc_from <- curr_data_list[[c_link_label]][["from_data_frame"]]
    # TODO Is this a good check?
    if(!(col_name %in% names(curr_data_list[[c_data_label]]))) {
      if(curr_data_list[[c_has_summary_label]]) {
        overall_links <- list()
        overall_links[[1]] <- curr_data_list[[c_link_label]][["link_cols"]]
      }
      # Otherwise, there must be existing keys defined in the data frame
      else {
        if(!self$has_key(overall_calc_from))  stop("Cannot merge calculated_from columns into exisiting data as there is no key defined in ", curr_data_list[[c_link_label]][["from_data_frame"]])
        overall_links <- self$get_keys(overall_calc_from)
      }
      if(!self$has_key(data_frame_name))  stop("Cannot merge calculated_from columns into exisiting data as there is no key defined in ", data_frame_name)
      new_data_links <- self$get_keys(data_frame_name)
      #TODO Make this it's own method?
      by <- NULL
      for(temp_overall_link in overall_links) {
        for(temp_curr_link in new_data_links) {
          equ_curr_cols <- self$get_equivalent_columns(overall_calc_from, temp_overall_link, data_frame_name)
          if(length(equ_curr_cols) > 0) { # && all(equ_curr_cols %in% temp_curr_link)) {
            by <- temp_overall_link
            names(by) <- equ_curr_cols
            join_into_overall <- FALSE
            break
          }
          equ_overall_cols <- self$get_equivalent_columns(data_frame_name, temp_curr_link, overall_calc_from)
          if(length(equ_overall_cols) > 0) { #&& all(equ_overall_cols %in% temp_overall_link)) {
            by <- temp_curr_link
            names(by) <- equ_overall_cols
            join_into_overall <- TRUE
            break
          }
          
        }
        if(length(by) > 0) break
      }
      if(length(by) == 0) {
        stop("Cannot find linking columns to merge output from sub calculations with data for calculated_from.")
      }
      if(join_into_overall) curr_data_list[[c_data_label]] <- full_join(curr_data_list[[c_data_label]], self$get_data_frame(data_frame_name, use_current_filter = FALSE), by = by)
      else {
        curr_groups <- groups(curr_data_list[[c_data_label]])
        curr_data_list[[c_data_label]] <- full_join(self$get_data_frame(data_frame_name, use_current_filter = FALSE), curr_data_list[[c_data_label]], by = by)
        #TODO investigate better way to do this
        #     Any case where we don't want this?
        for(var in curr_groups) {
          curr_data_list[[c_data_label]] <- curr_data_list[[c_data_label]] %>% group_by_(var, add = TRUE)
        }
        # The overall data is joined into the current sub calc, so the curr_data_list is "reset" to default values
        curr_data_list[[c_link_label]] <- list(from_data_frame = data_frame_name, link_cols = c())
        curr_data_list[[c_has_summary_label]] <- FALSE
        curr_data_list[[c_has_filter_label]] <- FALSE
      }
    }
    # This is a character vector containing the column names in a format that can be passed to dplyr functions using Standard Evalulation
    col_names_exp[[i]] <- interp(~ var, var = as.name(col_name))
    i = i + 1
  }
  
  # this type is adding a column to the data
  # the data is at the same "level" so the link is unchanged
  if(calc$type == "calculation") {
    if(calc$result_name %in% names(curr_data_list[[c_data_label]])) warning(calc$result_name, " is already a column in the existing data. The column will be replaced. This may have unintended consequences for the calculation")
    curr_data_list[[c_data_label]] <- curr_data_list[[c_data_label]] %>% mutate_(.dots = setNames(list(as.formula(paste0("~", calc$function_exp))), calc$result_name))
  }
  # this type performs a summary
  # the data is not at a different "level" so the link is changed and link columns are the groups of the data before summarising
  # A merge is now required because the data is at a different "level"
  else if(calc$type == "summary") {
    curr_data_list[[c_link_label]][["link_cols"]] <- as.character(groups(curr_data_list[[c_data_label]]))
    curr_data_list[[c_data_label]] <- curr_data_list[[c_data_label]] %>% summarise_(.dots = setNames(list(as.formula(paste0("~", calc$function_exp))), calc$result_name))
    curr_data_list[[c_has_summary_label]] <- TRUE
  }
  # This type is grouping the data
  # The data remains unchanged so link and require merge remain unchanged
  else if(calc$type == "by") {
    # link unchanged
    curr_data_list[[c_data_label]] <- curr_data_list[[c_data_label]] %>% group_by_(.dots = col_names_exp, add = TRUE)
  }
  # This type is sorting the data
  # The rows are now in a different order so a merge is required
  else if(calc$type == "sort") {
    curr_data_list[[c_data_label]] <- curr_data_list[[c_data_label]] %>% arrange_(.dots = col_names_exp)
    curr_data_list[[c_has_filter_label]] <- TRUE
  }
  # This type is filtering the data
  # The data is at the same "level" so the link is unchanged
  # The rows are now different so a merge is required
  else if(calc$type == "filter") {
    curr_data_list[[c_data_label]] <- curr_data_list[[c_data_label]] %>% filter_(.dots = as.formula(paste0("~", calc$function_exp)))
    curr_data_list[[c_has_filter_label]] <- TRUE
  }
  # This type is when there is no main calculation but some sub_calculations
  # There is no change to the data
  else if(calc$type == "combination") {}
  else stop("Cannot detect calculation type: ", calc$type)
  
  # This is done to clear the column attributes which are carried from the calculated columns
  # TODO test this to check for any unintended side effects
  # Seems only safe way to do this, as.vector can't be used on factor, Date etc.
  if(calc$type == "calculation" || calc$type == "summary") {
    result_col <- curr_data_list[[c_data_label]][[calc$result_name]]
    for(att in names(attributes(result_col))[!names(attributes(result_col)) %in% c("levels", "class")]) {
      attr(curr_data_list[[c_data_label]][[calc$result_name]], att) <- NULL
    }
  }
  # if calc$save == 2 then column generated by calculation is saved into instat object and calc saved in to_data_frame
  if(calc$save == 2) self$save_calc_output(calc, curr_data_list, previous_manipulations)
  # if output is not saved the calculation can still be saved but now it is saved with the from_data_frame
  # (to_data_frame may not exist)
  else if(calc$save == 1) self$save_calculation(data_names, calc)
  # list is returned so it can be used recursively for manipulations, sub_calculations etc.
  return(curr_data_list)
}
)

# Call this to run a calculation and display the data
instat_object$set("public", "run_instat_calculation", function(calc, display = TRUE) {
  out <- self$apply_instat_calculation(calc)
  if(display) return(out$data)
}
)

# given a set of columns in one data frame, this will return named list with corresponding columns in second data frame, where a link exists
# TODO: Needs to update to not just look at direct links
instat_object$set("public", "get_corresponding_link_columns", function(first_data_frame_name, first_data_frame_columns, second_data_frame_name) {
  by <- c()
  if(self$link_exists_between(first_data_frame_name, second_data_frame_name)) {
    existing_link <- self$get_link_between(first_data_frame_name, second_data_frame_name)
    link_pairs <- unlist(existing_link$link_columns)
    for(link_column in first_data_frame_columns) {
      if(existing_link$from_data_frame == first_data_frame_name && existing_link$to_data_frame == second_data_frame_name) {
        if(link_column %in% names(link_pairs)) {
          by[link_column] <- link_pairs[which(names(link_pairs) == link_column)][1]
        }
        else by[link_column] <- link_column
      }
      else if(existing_link$from_data_frame == second_data_frame_name && existing_link$to_data_frame == first_data_frame_name) {
        if(link_column %in% link_pairs) {
          by[link_column] <- names(link_pairs)[which(link_pairs == link_column)][1]
        }
        else by[link_column] <- link_column
      }
    }
  }
  # If no link then do by by columns in first data frame
  else {
    by <- first_data_frame_columns
    names(by) <- first_data_frame_columns
  }
  return(by)
}
)

# finds a link between two data frames and returns named list used for by
# also checks link columns still are in both data frames
instat_object$set("public", "get_link_columns_from_data_frames", function(first_data_frame_name, first_data_frame_columns, second_data_frame_name, second_data_frame_columns) {
  by = c()
  if(self$link_exists_between(first_data_frame_name, second_data_frame_name)) {
    existing_link <- self$get_link_between(first_data_frame_name, second_data_frame_name)
    found <- FALSE
    for(curr_link_set in existing_link$link_columns) {
      if(existing_link$from_data_frame == first_data_frame_name && existing_link$to_data_frame == second_data_frame_name) {
        if(all(curr_link_set %in% first_data_frame_columns) && all(names(curr_link_set) %in% second_data_frame_columns)) {
          by <- curr_link_set
          break
        }
      }
      else if(existing_link$from_data_frame == second_data_frame_name && existing_link$to_data_frame == first_data_frame_name) {
        if(all(curr_link_set %in% second_data_frame_columns) && all(names(curr_link_set) %in% first_data_frame_columns)) {
          by <- names(curr_link_set)
          names(by) <- curr_link_set
          break
        }
      }
    }
  }
  return(by)
}
)

# Called from apply_instat_calculation if calc$save_calc == TRUE
instat_object$set("public", "save_calc_output", function(calc, curr_data_list, previous_manipulations) {

  # Add previous manipulations to calc so that it can be rerun on its own (it may have been a sub calculation)
  calc$manipulations <- c(previous_manipulations, calc$manipulations)
  calc_dependencies <- calc$get_dependencies()
  # Variables used throughout method
  calc_from_data_name <- curr_data_list[[c_link_label]][["from_data_frame"]]
  calc_link_cols <- curr_data_list[[c_link_label]][["link_cols"]]
  
  # Not sure this is correct. What if result is going into a differennt data frame?
  if(calc$result_name %in% names(self$get_data_frame(calc_from_data_name))) warning(calc$result_name, " is already a column in the existing data. The column will be replaced by the output from the calculation. This may have unintended consequences for the calculation")
  if(calc$result_data_frame != "") {
    to_data_name <- calc$result_data_frame
    if(to_data_name %in% names(self$get_data_names())) {
      #TODO
    }
    else {
      to_data_list <- list()
      # Ensures that the to_data_name is a valid name
      to_data_name <- calc$result_data_frame
      to_data_name <- make.names(to_data_name)
      to_data_name <- next_default_item(to_data_name, self$get_data_names(), include_index = FALSE)
      # Subset to only get linking columns and result (don't want sub calcs as well, saved separately)
      to_data_list[[to_data_name]] <- curr_data_list[[c_data_label]]
      self$import_data(to_data_list)
      to_data_exists <- TRUE
      if(length(calc_link_cols) > 0) {
        # Add the link to the new to_data_name
        new_key <- calc_link_cols
        names(new_key) <- calc_link_cols
        self$add_link(calc_from_data_name, to_data_name, new_key, keyed_link_label)
        # Add metadata to the linking columns 
        # This adds metadata: is_calculated = TRUE to the linking columns, which indicates that the column has been created by a calculation
        self$append_to_variables_metadata(to_data_name, calc_link_cols, is_calculated_label, TRUE)
      }
      
      # Adds metadata at data frame level to indicate that the data frame is calculated
      # Note: all columns do not have to be calculated for data frame to be set as calculated
      self$append_to_dataframe_metadata(to_data_name, is_calculated_label, TRUE)
    }
  }
  else {
    if(curr_data_list[[c_has_summary_label]]) {
      # If there has been a summary, we look for an existing data frame that this could be linked to
      link_def <- self$get_possible_linked_to_defintion(calc_from_data_name, calc_link_cols)
      # If this is not empty then it is a list of two items: 1. the data frame to link to 2. the columns to link to
      if(length(link_def) > 0) {
        to_data_exists <- TRUE
        to_data_name <- link_def[[1]]
        # The check above only confirms it is possible to have a direct link to link_def[[1]]
        # If there is not already a direct link between the data frames, we add one
        if(!self$link_exists_from(calc_from_data_name, calc_link_cols)) {
          link_pairs <- link_def[[2]]
          names(link_pairs) <- calc_link_cols
          self$add_link(calc_from_data_name, to_data_name, link_pairs, keyed_link_label)
        }
        # This is done so that calc$name can be used later and we know it won't be changed
        # We can only do this check once we know the to_data_frame as this is where the calc is stored
        if(calc$name %in% self$get_calculation_names(to_data_name)) {
          calc$name <- next_default_item(calc$name, self$get_calculation_names(to_data_name))
        }
        if(calc$result_name %in% self$get_column_names(to_data_name)) {
          #     Delete is needed because merge will not replace
          #     If not wanting to replace, this should be checked when calculation is defined.
          warning("A column named ", calc$result_name, " already exists in ", to_data_name, ". It will be replaced by the output from the calculation.")
          self$remove_columns_in_data(to_data_name, calc$result_name)
        }
        if(length(calc_link_cols) > 0) {
          # merge_data merges into to_data_frame in instat object
          # method takes care of data frame attributes correctly
          # need to subset so that only the new column from this calc is added (not sub_calc columns as well as they have already been added if saved)
          # type = "full" so that we do not lose any data from either part of the merge
          by <- calc_link_cols
          names(by) <- link_def[[2]]
          self$get_data_objects(to_data_name)$merge_data(curr_data_list[[c_data_label]][c(calc_link_cols, calc$result_name)], by = by, type = "full")
        }
        else {
          self$get_data_objects(to_data_name)$add_columns_to_data(calc$result_name, curr_data_list[[c_data_label]])
        }
      }
      else {
        # If no link exists then the to_data_frame doesn't exist so output from calc becomes new to_data_frame
        # and a link will be added to new to_data_frame
        to_data_list <- list()
        # Ensures that the to_data_name is a valid name that doesn't exist in list of current data frame names
        to_data_name <- paste(calc_from_data_name, "by", paste(calc_link_cols, collapse = "_"), sep="_")
        to_data_name <- make.names(to_data_name)
        to_data_name <- next_default_item(to_data_name, self$get_data_names(), include_index = FALSE)
        # Subset to only get linking columns and result (don't want sub calcs as well, saved separately)
        to_data_list[[to_data_name]] <- curr_data_list[[c_data_label]][c(calc_link_cols, calc$result_name)]
        self$import_data(to_data_list)
        to_data_exists <- TRUE
        # Add the link to the new to_data_frame
        new_key <- calc_link_cols
        names(new_key) <- calc_link_cols
        self$add_link(calc_from_data_name, to_data_name, new_key, keyed_link_label)
        
        if(length(calc_link_cols) > 0) {
          # Add metadata to the linking columns 
          # This adds metadata: is_calculated = TRUE to the linking columns, which indicates that the column has been created by a calculation
          self$append_to_variables_metadata(to_data_name, calc_link_cols, is_calculated_label, TRUE)
        }
        
        # Adds metadata at data frame level to indicate that the data frame is calculated
        # Note: all columns do not have to be calculated for data frame to be set as calculated
        self$append_to_dataframe_metadata(to_data_name, is_calculated_label, TRUE)
      }
    }
    else if(curr_data_list[[c_has_filter_label]]) {
      # If filter done and no summary done then to_data_frame == from_data_frame
      # to do the join there must be a key defined in from dataframe because output may have a subset of rows of original data
      # TODO should we still add a link in this case?
      to_data_name <- calc_from_data_name
      # If the data frame has keys defined then we use get_link_columns_from_data_frames to find the by
      if(self$has_key(calc_from_data_name)) {
        by <- self$get_link_columns_from_data_frames(calc_from_data_name, names(curr_data_list[[c_data_label]]), calc_from_data_name, self$get_column_names(calc_from_data_name))
        # subset to only get output and key columns, do not want sub_calculation or extra columns to be merged as well
        #TODO If by = NULL should we try the merge with a warning or just stop?
        if(length(by) == 0) stop("Cannot save output because the key columns are not present in the calculation output")
        self$get_data_objects(calc_from_data_name)$merge_data(curr_data_list[[c_data_label]][c(as.vector(by), calc$result_name)], by = by, type = "full")
      }
      # Cannot do merge if the data frame has no keys defined
      else {
        #TODO Should we try the merge?
        stop("Cannot save output from this calculation because the data frame does not have any defined keys.")
      }
    }
    else {
      # If no summary or join, then simply add result as new column
      # Because no join was required, the rows should match 1-1 in both data frames
      self$add_columns_to_data(calc_from_data_name, calc$result_name, curr_data_list[[c_data_label]][[calc$result_name]])
      to_data_name <- calc_from_data_name
      if(calc$name %in% self$get_calculation_names(to_data_name)) {
        calc$name <- next_default_item(calc$name, self$get_calculation_names(to_data_name))
      }
    }
  }
  
  # Add metadata for the new column
  output_column <- calc$result_name
  names(output_column) <- to_data_name
  # Add metadata to calculated_from columns
  # for example, calculated_from may include sub_calculation columns which were not saved and so don't appear in the instat object data
  for(i in seq_along(calc_dependencies)) {
      # This adds metadata: has_dependants = TRUE which indicates that the calculated_from columns have columns that depend on them 
      self$append_to_variables_metadata(names(calc_dependencies[i]), calc_dependencies[[i]], has_dependants_label, TRUE)
      # This adds the output_column to the calculated_from columns' list of dependent columns
      self$add_dependent_columns(names(calc_dependencies[i]), calc_dependencies[[i]], output_column)
  }
  # This adds metadata: is_calculated = TRUE to the output column, which indicates that the column has been created by a calculation
  if(calc$result_name != "") {
    self$append_to_variables_metadata(to_data_name, calc$result_name, is_calculated_label, TRUE)
    
    # This adds metadata: dependencies to the output column with value, a list of the calculated_from columns
    if(length(calc_dependencies) > 0) self$append_to_variables_metadata(to_data_name, calc$result_name, dependencies_label, calc_dependencies)
    # This adds metadata: calculated_by to the output column, with value as the name of the calculation
    self$append_to_variables_metadata(to_data_name, calc$result_name, calculated_by_label, calc$name)
  }
  self$save_calculation(to_data_name, calc)
}
)

# Could be a standalone method? Method of calculation?
instat_calculation$set("public", "get_dependencies", function(depens = c()) {
  for(manip in self$manipulations) {
    for(i in seq_along(manip$calculated_from)) {
      ind <- which(depens == manip$calculated_from[[i]])
      if(length(ind) == 0 || names(depens)[ind] != names(manip$calculated_from)[i]) {
        depens <- c(depens, manip$calculated_from[i])
      }
    }
  }
  for(sub_calc in self$sub_calculations) {
    depens <- sub_calc$get_dependencies(depens)
  }
  for(j in seq_along(self$calculated_from)) {
    ind <- which(depens == self$calculated_from[[j]])
    if(length(ind) == 0 || names(depens)[ind] != names(self$calculated_from)[j]) {
      depens <- c(depens, self$calculated_from[j])
    }
  }
  return(depens)
}
)