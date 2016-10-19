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
  if(calc$name %in% names(private$calculations)) warning("There is already a calculation called ", calc_name, ". It will be replaced.")
  private$calculations[[calc$name]] <- calc
  return(calc$name)
}
)

instat_calculation <- R6Class("instat_calculation",
                       public = list(
                         initialize = function(function_exp = "", type = "", name = "", manipulations = list(),
                                               sub_calculations = list(), calculated_from = list(), save_output = FALSE) {
                           self$function_exp <- function_exp
                           self$type <- type
                           self$name <- name
                           self$manipulations <- manipulations
                           self$sub_calculations <- sub_calculations
                           self$calculated_from <- calculated_from
                           self$save_output <- save_output
                         },
                         name = "",
                         type = "",
                         manipulations = list(),
                         sub_calculations = list(),
                         function_exp = "",
                         calculated_from = list(),
                         save_output = FALSE
                       )
)

# pass in and return link with curr_data_list as one argument
instat_object$set("public", "apply_instat_calculation", function(calc, curr_data_list) {
  data_label <- "data"
  link_label <- "link"
  require_merge_label <- "require_merge"
  
  for(manipulation in calc$manipulations) {
    curr_data_list <- self$apply_instat_calculation(manipulation, curr_data_list)
  }
  if(!missing(curr_data_list)) sub_calc_results <- curr_data_list
  first_sub_calc <- TRUE
  for(sub_calc in calc$sub_calculations) {
    curr_sub_calc <- self$apply_instat_calculation(sub_calc, curr_data_list)
    if(first_sub_calc) {
      sub_calc_results <- curr_sub_calc
      first_sub_calc <- FALSE
    }
    else {
      #### Set the require_merge boolean
      sub_calc_results[[require_merge_label]] <- sub_calc_results[[require_merge_label]] || curr_sub_calc[[require_merge_label]]
      
      #### Set the data
      # check new required merge
      curr_calc_link_cols <- curr_sub_calc[[link_label]][["link_cols"]]
      overall_calc_link_cols <- sub_calc_results[[link_label]][["link_cols"]]
      if(sub_calc_results[[require_merge_label]]) {
        if(length(curr_calc_link_cols) > 0 || length(overall_calc_link_cols) > 0) {
          # In this case, a summary has been done so joining column(s) should be available
          # Join into the "biggest" data frame
          if(length(curr_calc_link_cols) == 0) {
            sub_calc_results[[data_label]] <- full_join(curr_sub_calc[[data_label]], sub_calc_results[[data_label]], 
                                                        by = overall_calc_link_cols)
            sub_calc_results[[link_label]] <- curr_sub_calc[[link_label]]
          }
          else if(length(overall_calc_link_cols) == 0) {
            sub_calc_results[[data_label]] <- full_join(sub_calc_results[[data_label]], curr_sub_calc[[data_label]], 
                                                        by = curr_calc_link_cols)
          }
          else {
            if(all(sub_calc_results[[link_label]][["link_cols"]] %in% curr_sub_calc[[link_label]][["link_cols"]])) {
              sub_calc_results[[link_label]] <- curr_sub_calc[[link_label]]
              sub_calc_results[[data_label]] <- full_join(curr_sub_calc[[data_label]], sub_calc_results[[data_label]],
                                                          by = intersect(curr_calc_link_cols, overall_calc_link_cols))
            }
            else if(all(curr_sub_calc[[link_label]][["link_cols"]] %in% sub_calc_results[[link_label]][["link_cols"]])) {
              sub_calc_results[[data_label]] <- full_join(sub_calc_results[[data_label]], curr_sub_calc[[data_label]], 
                                                          by = intersect(curr_calc_link_cols, overall_calc_link_cols))
            }
            else stop("sub calculations cannot have disjoint linking columns")
            #TODO need to check they have the same from_data_frame?
          }
        }
        else {
          # In this case, join required but no summary has been done, so the join was required by a filter
          # to do the join there must be a key defined in the "largest" dataframe
          # Because no summary has been done, key can always be checked in from_data_frame of link??
          if(self$has_key(sub_calc_results[[link_label]][["from_data_frame"]])) {
            keys_list <- self$get_keys(sub_calc_results[[link_label]][["from_data_frame"]])
            joined <- FALSE
            for(curr_key in keys_list) {
              if(all(curr_key %in% names(sub_calc_results[[data_label]])) && all(curr_key %in% names(curr_sub_calc[[data_label]]))) {
                # subsets to only get output and key columns, but then join result includes lots of missing values
                #sub_calc_results[[data_label]] <- full_join(sub_calc_results[[data_label]], curr_sub_calc[[data_label]][c(sub_calc$name, curr_key)], by = curr_key)
                #TODO This will join on all columns in the original data (including key), is there any case this could be a problem?
                #TODO Could add suppressMessages() here to prevent message about join
                if(sub_calc_results[[require_merge_label]]) {
                  sub_calc_results[[data_label]] <- full_join(curr_sub_calc[[data_label]], sub_calc_results[[data_label]])
                  joined <- TRUE
                }
                else if(curr_sub_calc[[require_merge_label]]) {
                  sub_calc_results[[data_label]] <- full_join(sub_calc_results[[data_label]], curr_sub_calc[[data_label]])
                  joined <- TRUE
                }
                break
              }
            }
            if(!joined) stop("Could not find a key to join by, which appeared in output from all sub calculations.")
          }
          else {
            stop("Cannot merge output from sub calculations because data frame does not have any defined keys.")
          }
        }
      }
      else {
        # In this case, no join required so columns are simply added from the new calc into the exisiting calc's data
        if(sub_calc$name %in% names(sub_calc_results[[data_label]])) warning(sub_calc$name, " is already a column in the existing data. The column will be replaced. This may have unintended consequences for the calculation")
        sub_calc_results[[data_label]][[sub_calc$name]] <- curr_sub_calc[[data_label]][[sub_calc$name]]
      }
    }
  }
  if(!first_sub_calc) curr_data_list <- sub_calc_results
  
  data_names <- unique(as.vector(names(calc$calculated_from)))
  if(missing(curr_data_list)) {
    if(length(data_names) == 0) stop("No data specified for calculation.")
    else if(length(data_names) > 1) stop("Calculations from multiple data frame not yet implemented")
    else {
      # change to set data part
      # create/get link from data to itself
      # set require_merge boolean to FALSE as default
      curr_data_list <- list()
      #TODO How does current filter work with this? Should current filter be ignored here? (use_current_filter = FALSE)
      #TODO Add current filter as manipulation in calc definition if needed.
      curr_data_list[[data_label]] <- self$get_data_frame(data_names[[1]], use_current_filter = FALSE)
      link_list <- list(data_names[[1]], c())
      names(link_list) <- c("from_data_frame", "link_cols")
      curr_data_list[[link_label]] <- link_list
      curr_data_list[[require_merge_label]] <- FALSE
    }
  }
  
  col_names_exp = c()
  i = 1
  for(col_name in calc$calculated_from) {
    if(!(col_name %in% names(curr_data_list[[data_label]]))) {
      stop(col_name, " not found in data.")
    }
    col_names_exp[[i]] <- interp(~ var, var = as.name(col_name))
    i = i + 1
  }
  
  if(calc$type == "calculation") {
    # link unchanged
    if(calc$name %in% names(curr_data_list[[data_label]])) warning(calc$name, " is already a column in the existing data. The column will be replaced. This may have unintended consequences for the calculation")
    curr_data_list[[data_label]] <- curr_data_list[[data_label]] %>% mutate_(.dots = setNames(list(as.formula(paste0("~", calc$function_exp))), calc$name))
  }
  else if(calc$type == "summary") {
    # modify link to include linking columns
    # set requires_key = TRUE
    # from_data_frame only changes in join
    # TODO Is this always replacing the link_cols?
    curr_data_list[[link_label]][["link_cols"]] <- as.character(groups(curr_data_list[[data_label]]))
    curr_data_list[[data_label]] <- curr_data_list[[data_label]] %>% summarise_(.dots = setNames(list(as.formula(paste0("~", calc$function_exp))), calc$name))
    curr_data_list[[require_merge_label]] <- TRUE
  }
  else if(calc$type == "by") {
    # link unchanged
    curr_data_list[[data_label]] <- curr_data_list[[data_label]] %>% group_by_(.dots = col_names_exp, add = TRUE)
  }
  else if(calc$type == "filter") {
    # link unchanged
    # set requires_key = TRUE
    curr_data_list[[data_label]] <- curr_data_list[[data_label]] %>% filter_(.dots = as.formula(paste0("~", calc$function_exp)))
    curr_data_list[[require_merge_label]] <- TRUE
  }
  else if(calc$type == "join") {
    # link needs to change
    stop("join not yet implemented.")
  }
  else if(calc$type == "combination") {
    # No main calculation, but could (should?) have sub calculations
  }
  else stop("Cannot detect calculation type: ", calc$type)
  
  #TODO How should save work with main calculation/sub calculations mainly when main calc is "combination"
  if(calc$save_output) self$save_calc_output(calc, curr_data_list)
  # need to add metadata to new columns from calculation
  return(curr_data_list)
}
)

instat_object$set("public", "save_calc_output", function(calc, curr_data_list) {
  data_label <- "data"
  link_label <- "link"
  require_merge_label <- "require_merge"
  
  calc_from_data_name <- curr_data_list[[link_label]][["from_data_frame"]]
  calc_link_cols <- curr_data_list[[link_label]][["link_cols"]]
  
  if(curr_data_list[[require_merge_label]]) {
    if(length(calc_link_cols) > 0) {
      # In this case, a summary has been done so joining column(s) should be available
      if(self$link_exists_from(calc_from_data_name, calc_link_cols)) {
        # In this case to_data_frame already exists so we merge with it
        to_data_exists <- TRUE
        to_data_name <- self$get_linked_to_data_name(calc_from_data_name, calc_link_cols)
        to_data <- self$get_data_frame(to_data_name, use_current_filter = FALSE)
        # Probably not needed because merge will take care of this?
        if(calc$name %in% names(to_data)) {
          #TODO Delete column with this name in to_data
        #   curr_data_list[[data_label]][[calc$name]] <- next_default_item(calc$name, names(to_data))
        }
        #merge_data method takes care of data frame attributes correctly
        #need to subset so that only column from this calc is added (not sub_calc columns as well)
        self$get_data_objects(to_data_name)$merge_data(curr_data_list[[data_label]][c(calc_link_cols, calc$name)], by = calc_link_cols, type = "full")
      }
      else {
        # In this case, to_data_frame doesn't exist so output from calc becomes new data frame
        # link will be added to new data frame
        to_data_exists <- TRUE
        to_data_list <- list()
        to_data_name <- paste(calc_from_data_name, "by", paste(calc_link_cols, collapse = "_"), sep="_")
        to_data_name <- make.names(to_data_name)
        to_data_name <- next_default_item(to_data_name, self$get_data_names(), include_index = FALSE)
        to_data_list[[to_data_name]] <- curr_data_list[[data_label]][c(calc_link_cols, calc$name)]
        self$import_data(to_data_list)
        new_key <- calc_link_cols
        names(new_key) <- new_key
        self$add_link(calc_from_data_name, to_data_name, new_key, keyed_link_label)
      }
      
      if(!to_data_exists) {
        # Add some metadata if the data frame did not already exist
        # TODO Is this correct? link cols may be changed by new calculation e.g. when using filters levels are different
        self$append_to_variables_metadata(to_data_name, calc_link_cols, is_calculated_label, TRUE)
        self$append_to_variables_metadata(to_data_name, calc_link_cols, calculated_by_label, calc$calculated_from)
        self$append_to_dataframe_metadata(to_data_name, is_calculated_label, TRUE)
      }
      
    }
    else {
      # In this case, join required but no summary has been done, so the join was required by a filter
      # to do the join there must be a key defined in from dataframe
      # Because no summary has been done, key can always be checked in from_data_frame of link??
      to_data_name <- calc_from_data_name
      if(self$has_key(calc_from_data_name)) {
        keys_list <- self$get_keys(calc_from_data_name)
        joined <- FALSE
        for(curr_key in keys_list) {
          if(all(curr_key %in% names(curr_data_list[[data_label]]))) {
            # subset first to only get output and key columns
            # Needed so that sub calculations are not added as well
            #TODO Could add suppressMessages() here to prevent message about join
            self$get_data_objects(calc_from_data_name)$merge_data(curr_data_list[[data_label]][c(curr_key, calc$name)], by = curr_key, type = "full")
            joined <- TRUE
            break
          }
        }
        if(!joined) stop("Could not find a key to join by, which appeared in output from this calculations.")
      }
      else {
        stop("Cannot merge output from this calculation because the data frame does not have any defined keys.")
      }
    }
  }
  else {
    # In this case, no join required so columns are simply added from the new calc into the exisiting calc's data
    if(calc$name %in% names(self$get_data_frame(calc_from_data_name))) warning(calc$name, " is already a column in the existing data. The column will be replaced. This may have unintended consequences for the calculation")
    self$add_columns_to_data(calc_from_data_name, calc$name, curr_data_list[[data_label]][[calc$name]])
  }
  # Add metadata for new column
  output_column <- calc$name
  names(output_column) <- to_data_name
  calc_from_columns <- as.character(calc$calculated_from)[as.character(calc$calculated_from) %in% self$get_column_names(calc_from_data_name)]
  if(length(calc_from_columns) > 0) {
    self$append_to_variables_metadata(calc_from_data_name, as.character(calc$calculated_from), has_dependants_label, TRUE)
    self$add_dependent_columns(calc_from_data_name, as.character(calc$calculated_from), output_column)
  }
  self$append_to_variables_metadata(to_data_name, calc$name, is_calculated_label, TRUE)
  self$append_to_variables_metadata(to_data_name, calc$name, dependencies_label, calc$calculated_from)
  if(length(calc$calculated_from) > 0) self$append_to_variables_metadata(to_data_name, calc$name, calculated_by_label, calc$calculated_from)
}
)