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

# class to store calculations
# Fields:
# function_exp     : string - passed directly to one of dplyr functions e.g. "Yield > 50" for a filter or "Yield * Size" for a calculation
# type             : string - one of "by", "calculation", "filter", "summary", "combination" to determine the type of calculation to do
#                             corresponds directly to one of dplyr's functions (except combination).
#                             "by" - for dplyr's "group_by", to group the data by column(s) (usually factors) in preparation for doing summaries, for example.
#                             "calculation" - for dplyr's "mutate", a simple calculation to produce a column within the same data frame
#                             "filter" - for dplyr's "filter", to filter the rows of a data frame by any logical expression
#                             "summary" - for dplyr's "summarise", to produce summaries. Produces a singple value unless the data is already grouped, 
#                                         and then one value for each "group" is produced.
#                             "combunation" - for calculations which contain sub calculations (and possibly mutations) but no main calculation is needed.
# name             : string - a name for the calculation. If save_calc = FALSE then name is not used anywhere.
# result_name      : string - a name for the output (usually a column) produced by the calculation e.g. "YieldDouble"
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
# save_output      : logical- should the output produced by the calculation (usually a column) be saved into the instat object?
# save_calc        : logical- should the calculation itself be saved? If yes, it can be re-run at a later date.

instat_calculation <- R6Class("instat_calculation",
                       public = list(
                         initialize = function(function_exp = "", type = "", name = "", result_name = "", manipulations = list(),
                                               sub_calculations = list(), calculated_from = list(), save_output = FALSE, save_calc = FALSE) {
                           if((type == "calculation" || type == "summary") && missing(result_name)) stop("result_name must be provided for calculation and summary types")
                           if(type == "combination" && save_output) {
                             warning("combination types do not have a main calculation which can be saved. save_output will be stored as FALSE")
                             save_output <- FALSE
                             #TODO Should this do something else like set save_output = TRUE for all sub_calculations?
                           }
                           self$function_exp <- function_exp
                           self$type <- type
                           self$name <- name
                           self$result_name <- result_name
                           self$manipulations <- manipulations
                           self$sub_calculations <- sub_calculations
                           self$calculated_from <- calculated_from
                           self$save_output <- save_output
                           self$save_calc <- save_calc
                         },
                         name = "",
                         result_name = "",
                         type = "",
                         manipulations = list(),
                         sub_calculations = list(),
                         function_exp = "",
                         calculated_from = list(),
                         save_output = FALSE,
                         save_calc = FALSE
                       )
)

# Calculation labels
#These are the names of the list returned by apply_instat_calculation
c_data_label <- "data"
c_link_label <- "link"
c_require_merge_label <- "require_merge"

# This performs the calculation, including saving the output and calculation if required.
# A list of 3 elements is returned:
# $data : a data frame containing the output from the calculation, usually not just the output but also other columns at the same "level"
# $link : a link used to determine which data frame the output should be saved in.
# $require_merge : a logical value indicating whether the output requires a merge to be appended to an existing data frame

# This method is called recursively, and it would not be called by a user, another function would always handle the output and display
# results to the user (usually only the $data part of the list)
instat_object$set("public", "apply_instat_calculation", function(calc, curr_data_list, previous_manipulations) {
  
  # apply each manipulation first, and recursively store the output and pass to the next manipulation
  # because of this, manipulations are dependant on each other
  for(manipulation in calc$manipulations) {
    curr_data_list <- self$apply_instat_calculation(manipulation, curr_data_list, previous_manipulations)
    previous_manipulations[[length(previous_manipulations) + 1]] <- manipulation
  }
  # If curr_data_list is not empty, (either an argument or from manipulations)
  # then this is passed in to apply_instat_calculation for each sub_calculation
  # sub_calculations are independant of each other (the order does not affect the output)
  if(!missing(curr_data_list)) sub_calc_results <- curr_data_list
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
      overall_merge_required <- sub_calc_results[[c_require_merge_label]]
      current_calc_merge_required <- curr_sub_calc[[c_require_merge_label]]
      
      # A merge is required if a merge was already required, or if the current sub_calculation requires a merge
      sub_calc_results[[c_require_merge_label]] <- overall_merge_required || current_calc_merge_required
      
      #### Set the data and link
      # Defined as variables as these are used throughout 
      curr_calc_link_cols <- curr_sub_calc[[c_link_label]][["link_cols"]]
      overall_calc_link_cols <- sub_calc_results[[c_link_label]][["link_cols"]]
      
      if(sub_calc_results[[c_require_merge_label]]) {
        #TODO What if summary was done but no linking columns?
        if(length(curr_calc_link_cols) > 0 || length(overall_calc_link_cols) > 0) {
          # If either list has linking columns then a summary has been done so joining column(s) should be available to perform a merge
          # We join into the "biggest" data frame
          if(length(curr_calc_link_cols) == 0) {
            #In this case, the current sub_calculation has unsummarised data so it should be the first data frame of the merge
            sub_calc_results[[c_data_label]] <- full_join(curr_sub_calc[[c_data_label]], sub_calc_results[[c_data_label]], 
                                                        by = overall_calc_link_cols)
            # The join produces unsummarised data so the link should be updated to now have no linking columns
            sub_calc_results[[c_link_label]] <- curr_sub_calc[[c_link_label]]
          }
          else if(length(overall_calc_link_cols) == 0) {
            # In this case, the overall output has unsummarised data and the current calculation has summaried data,
            # so we merge the summarised data into the unsummarised data
            sub_calc_results[[c_data_label]] <- full_join(sub_calc_results[[c_data_label]], curr_sub_calc[[c_data_label]], 
                                                        by = curr_calc_link_cols)
            # The merge produces unsummarised data, so the link is unchanged.
          }
          else {
            # When both contain summairsed data we merge into the "biggest" data frame i.e. one with fewest linking columns
            # The joining columns are the intersection of two sets of linking columns
            # Which list's columns is contained in the other list, determines which data frame should come first in the merge 
            if(all(sub_calc_results[[c_link_label]][["link_cols"]] %in% curr_sub_calc[[c_link_label]][["link_cols"]])) {
              sub_calc_results[[c_link_label]] <- curr_sub_calc[[c_link_label]]
              sub_calc_results[[c_data_label]] <- full_join(curr_sub_calc[[c_data_label]], sub_calc_results[[c_data_label]],
                                                          by = intersect(curr_calc_link_cols, overall_calc_link_cols))
            }
            else if(all(curr_sub_calc[[c_link_label]][["link_cols"]] %in% sub_calc_results[[c_link_label]][["link_cols"]])) {
              sub_calc_results[[c_data_label]] <- full_join(sub_calc_results[[c_data_label]], curr_sub_calc[[c_data_label]], 
                                                          by = intersect(curr_calc_link_cols, overall_calc_link_cols))
            }
            # If one set is not a subset of the other, then they do not contain any common linking columns and a merge is impossible
            # No sensible calculation should require such a case.
            else stop("sub calculations cannot have disjoint linking columns")
          }
        }
        else {
          # If a merge is required but there are no linking columns in either data frame, then, the merge was not required by a summary
          # so it was required by a filter
          # To be able to join data that has been filtered, there must be a key (unique identifier) defined in the data frame
          # so that rows can property be matched from the merged data
          if(self$has_key(sub_calc_results[[c_link_label]][["from_data_frame"]])) {
            keys_list <- self$get_keys(sub_calc_results[[c_link_label]][["from_data_frame"]])
            joined <- FALSE
            # Look at each key already defined and if both data frames contain the columns of the key then the merge can be performed 
            for(curr_key in keys_list) {
              if(all(curr_key %in% names(sub_calc_results[[c_data_label]])) && all(curr_key %in% names(curr_sub_calc[[c_data_label]]))) {
                
                # Whichever data frame required the merge should be the second data frame in the merge
                # (output is the same in both cases but this should give a more sensible order on the rows in the output)
                # Note: if both require a merge then the order of the rows in the output may not be sensible, but this case should be rare
                #       as would require two different filters to be applied to make the row order strange
                if(overall_merge_required) {
                  suppressMessages(sub_calc_results[[c_data_label]] <- full_join(curr_sub_calc[[c_data_label]], sub_calc_results[[c_data_label]]))
                  joined <- TRUE
                }
                else if(current_calc_merge_required) {
                  suppressMessages(sub_calc_results[[c_data_label]] <- full_join(sub_calc_results[[c_data_label]], curr_sub_calc[[c_data_label]]))
                  joined <- TRUE
                }
                break
              }
            }
            # If no keys are in both data frames then impossible to join sensibly
            if(!joined) stop("Could not find a key to join by, which appeared in output from all sub calculations.")
          }
          # If no keys are defined then impossible to join sensibly
          else {
            stop("Cannot merge output from sub calculations because data frame does not have any defined keys.")
          }
        }
      }
      else {
        # If merge is not required then calculation output can just be added to the data as a new column
        # If this will replace a column then a warning is given.
        # Duplicate names should be dealt with internally before applying the calculation unless a replacement is desired.
        if(sub_calc$result_name %in% names(sub_calc_results[[c_data_label]])) warning(sub_calc$result_name, " is already a column in the existing data. The column will be replaced. This may have unintended consequences for the calculation")
        sub_calc_results[[c_data_label]][[sub_calc$result_name]] <- curr_sub_calc[[c_data_label]][[sub_calc$result_name]]
      }
    }
  }
  # If there were any sub_calculations then the input for the main calculation should be the output from the last sub_calculation
  # Otherwise it is the output from the mainipulations
  if(!first_sub_calc) curr_data_list <- sub_calc_results
  
  # Names of the data frames required for the calculation
  data_names <- unique(as.vector(names(calc$calculated_from)))
  # If argument was missing and there were no manipulations or sub_calculations then it should be created.
  if(missing(curr_data_list)) {
    if(length(data_names) == 0) stop("No data specified for calculation.")
    else if(length(data_names) > 1) stop("Calculations from multiple data frame not yet implemented")
    else {
      curr_data_list <- list()
      #TODO Add current filter as manipulation in calc definition if needed.
      # The data is the data from the instat object based on data_names
      curr_data_list[[c_data_label]] <- self$get_data_frame(data_names[[1]], use_current_filter = FALSE)
      # The link has from_data_frame based on data_names and no current linking columns
      link_list <- list(data_names[[1]], c())
      names(link_list) <- c("from_data_frame", "link_cols")
      curr_data_list[[c_link_label]] <- link_list
      # By default, a merge is not required
      curr_data_list[[c_require_merge_label]] <- FALSE
    }
  }
  
  col_names_exp = c()
  i = 1
  # This checks that the columns specified in calculated_from appear in the current data
  for(col_name in calc$calculated_from) {
    if(!(col_name %in% names(curr_data_list[[c_data_label]]))) {
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
    curr_data_list[[c_require_merge_label]] <- TRUE
  }
  # This type is grouping the data
  # The data remains unchanged so link and require merge remain unchanged
  else if(calc$type == "by") {
    # link unchanged
    curr_data_list[[c_data_label]] <- curr_data_list[[c_data_label]] %>% group_by_(.dots = col_names_exp, add = TRUE)
  }
  # This type is filtering the data
  # The data is at the same "level" so the link is unchanged
  # The rows are now different so a merge is required
  else if(calc$type == "filter") {
    curr_data_list[[c_data_label]] <- curr_data_list[[c_data_label]] %>% filter_(.dots = as.formula(paste0("~", calc$function_exp)))
    curr_data_list[[c_require_merge_label]] <- TRUE
  }
  # This type is merging the data
  # The link will be changed
  else if(calc$type == "join") {
    # link needs to change
    stop("join not yet implemented.")
  }
  # This type is when there is no main calculation but some subcalculations
  # There is no change to the data
  else if(calc$type == "combination") {
  }
  else stop("Cannot detect calculation type: ", calc$type)
  
  # This is done to clear the column attributes which are carried from the calculated columns
  # TODO test this to check for any unintended side effects
  # Seems only safw ay to do this, as.vector can't be used on factor, Date etc.
  if(calc$type == "calculation" || calc$type == "summary") {
    result_col <- curr_data_list[[c_data_label]][[calc$result_name]]
    for(att in names(attributes(result_col))[!names(attributes(result_col)) %in% c("levels", "class")]) {
      attr(curr_data_list[[c_data_label]][[calc$result_name]], att) <- NULL
    }
  }
  # if calc$save_output then column generated by calculation is saved into instat object
  # save_calc_output also checks calc$save_calc and saves it in the to_data_frame if TRUE
  if(calc$save_output) self$save_calc_output(calc, curr_data_list, previous_manipulations)
  else {
    # if output is not saved the calculation can still be saved but now it is saved with the from_data_frame
    # (to_data_frame may not exist)
    # TODO if multiple from_data_frames exist then where should calc be saved?
    if(calc$save_calc) self$save_calculation(data_names, calc)
  }
  # list is returned so it can be used recursively for manipulations, sub_calculations etc.
  return(curr_data_list)
}
)

# Called from apply_instat_calculation if calc$save_calc == TRUE
instat_object$set("public", "save_calc_output", function(calc, curr_data_list, previous_manipulations) {

  # This is done first because calc$name is used later when adding metadata
  #TODO This needs to change
  if(calc$name == "") calc$name <- next_default_item("calc", names(private$calculations))
  
  calc$manipulations <- c(previous_manipulations, calc$manipulations)
  
  # Variables used throughout method
  calc_from_data_name <- curr_data_list[[c_link_label]][["from_data_frame"]]
  calc_link_cols <- curr_data_list[[c_link_label]][["link_cols"]]
  
  # Below are similar checks as in apply_instat_calculation when merging sub_calculations
  if(curr_data_list[[c_require_merge_label]]) {
    #If require merge then either summary or filter has been done.
    if(length(calc_link_cols) > 0) {
      # If there are link columns, a summary has been done so joining column(s) should be available
      if(self$link_exists_from(calc_from_data_name, calc_link_cols)) {
        # If a link exists it means the to_data_frame already exists so we merge into it
        to_data_exists <- TRUE
        #gets the name of the to_data_frame based on the link
        to_data_name <- self$get_linked_to_data_name(calc_from_data_name, calc_link_cols)
        if(calc$result_name %in% names(self$get_column_names(to_data_name))) {
          #TODO Delete column with this name in to_data and give warning
          #     Delete is needed because merge will not replace
          #     If not wanting to replace, this should be checked when calculation is defined.
        }
        # merge_data merges into to_data_frame in instat object
        # method takes care of data frame attributes correctly
        # need to subset so that only the new column from this calc is added (not sub_calc columns as well as they have already been added if saved)
        # type = "full" so that we do not lose any data from either part of the merge
        self$get_data_objects(to_data_name)$merge_data(curr_data_list[[c_data_label]][c(calc_link_cols, calc$result_name)], by = calc_link_cols, type = "full")
      }
      else {
        # If no link exists then the to_data_frame doesn't exist so output from calc becomes new to_data_frame
        # and a link will be added to new to_data_frame
        to_data_list <- list()
        # Ensures that the to_data_name is a valid name that doesn't exist in list of current data frame names
        to_data_name <- paste(calc_from_data_name, "by", paste(calc_link_cols, collapse = "_"), sep="_")
        to_data_name <- make.names(to_data_name)
        to_data_name <- next_default_item(to_data_name, self$get_data_names(), include_index = FALSE)
        to_data_list[[to_data_name]] <- curr_data_list[[c_data_label]][c(calc_link_cols, calc$result_name)]
        self$import_data(to_data_list)
        to_data_exists <- TRUE
        # Add the link to the new to_data_frame
        new_key <- calc_link_cols
        names(new_key) <- new_key
        self$add_link(calc_from_data_name, to_data_name, new_key, keyed_link_label)
        # Add metadata to the linking columns 
        # This adds metadata: is_calculated = TRUE to the linking columns, which indicates that the column has been created by a calculation
        self$append_to_variables_metadata(to_data_name, calc_link_cols, is_calculated_label, TRUE)
        # This creates list to indicate the dependent columns of the link columns in the to_data_frame, the name of the list is the from_data_name
        # Need to do separately for each link column because they have different dependencies
        for(curr_link_col in calc_link_cols) {
          # TODO Maybe there should be one method to do this next section
          link_cols_in_from_data <- list(curr_link_col)
          names(link_cols_in_from_data) <- calc_from_data_name
          self$append_to_variables_metadata(to_data_name, curr_link_col, dependencies_label, link_cols_in_from_data)
          # Same list as above except has name to_data_frame, to be passed in to indicate the columns which depend on the link columns in the from_data_frame
          link_cols_in_to_data <- list(curr_link_col)
          names(link_cols_in_to_data) <- to_data_name
          self$add_dependent_columns(calc_from_data_name, curr_link_col, link_cols_in_to_data)
        }

        # Adds metadata at data frame level to indicate that the data frame is calculated
        self$append_to_dataframe_metadata(to_data_name, is_calculated_label, TRUE)
        # This adds metadata: calculated_from to the output column, with value as the name of the calculation
        # Only add this metadata if the calc has a name. If the calc is saved, it will always have a name
        # TODO If not saving then probably this shouldn't be added? If not saving would also expect calc$ == ""
        # TODO How should calculated_by work? sub_calc name or main calc name?
        if(calc$name != "") self$append_to_variables_metadata(to_data_name, calc_link_cols, calculated_by_label, calc$name)
      }
    }
    else {
      # If not linking columns but join required, then no summary has been done, so the join was required by a filter
      # to do the join there must be a key defined in from dataframe because output has a subset of rows of original data
      # The to_data_frame is the same as the from_data_frame in this case
      # TODO should we still add a link in this case?
      to_data_name <- calc_from_data_name
      # If the data frame has keys defined then go through each key and if all columns of the key are in the output data then the merge can be done
      if(self$has_key(calc_from_data_name)) {
        keys_list <- self$get_keys(calc_from_data_name)
        joined <- FALSE
        for(curr_key in keys_list) {
          if(all(curr_key %in% names(curr_data_list[[c_data_label]]))) {
            # subset first to only get output and key columns, do not want sub_calculation or extra columns to be merged as well
            self$get_data_objects(calc_from_data_name)$merge_data(curr_data_list[[c_data_label]][c(curr_key, calc$result_name)], by = curr_key, type = "full")
            joined <- TRUE
            break
          }
        }
        # Cannot do merge if not all columns of any key is found in the output
        if(!joined) stop("Could not find a key to join by, which appeared in output from this calculations.")
      }
      # Cannot do merge if the data frame has no ketys defined
      else {
        stop("Cannot merge output from this calculation because the data frame does not have any defined keys.")
      }
    }
  }
  else {
    # If join is not required, columns are simply added from the new calc into the exisiting calc's data
    # Because no join was required, the rows should match 1-1 in both data frames
    # Warning if this will replace an existing column.
    # If replacement is not wanted then result_name should be changed before applying the calculation
    if(calc$result_name %in% names(self$get_data_frame(calc_from_data_name))) warning(calc$result_name, " is already a column in the existing data. The column will be replaced. This may have unintended consequences for the calculation")
    self$add_columns_to_data(calc_from_data_name, calc$result_name, curr_data_list[[c_data_label]][[calc$result_name]])
    to_data_name <- calc_from_data_name
  }
  # Add metadata for the new column
  output_column <- calc$result_name
  names(output_column) <- to_data_name
  # Add metadata to calculated_from column, but only if they appear in the instat object data
  # for example, calculated_from may include sub_calculation columns which were not saved and so don't appear in the instat object data
  for(i in seq_along(calc$calculated_from)) {
    if(calc$calculated_from[[i]] %in% self$get_column_names(names(calc$calculated_from[i]))) {
      # This adds metadata: has_dependants = TRUE which indicates that the calculated_from columns have columns that depend on them 
      self$append_to_variables_metadata(names(calc$calculated_from[i]), calc$calculated_from[[i]], has_dependants_label, TRUE)
      # This adds the output_column to the calculated_from columns' list of dependent columns
      self$add_dependent_columns(names(calc$calculated_from[i]), calc$calculated_from[[i]], output_column)
    }
  }
  # This adds metadata: is_calculated = TRUE to the output column, which indicates that the column has been created by a calculation
  self$append_to_variables_metadata(to_data_name, calc$result_name, is_calculated_label, TRUE)
  #TODO write this method
  #TODO check metadata added
  calc_calculated_from <- calc$get_calculated_from()
  # This adds metadata: dependencies to the output column with value, a list of the calculated_from columns
  if(length(calc_calculated_from) > 0) self$append_to_variables_metadata(to_data_name, calc$result_name, dependencies_label, calc_calculated_from)
  # This adds metadata: calculated_from to the output column, with value as the name of the calculation
  # Only add this metadata if the calc has a name. If the calc is saved, it will always have a name
  # TODO If not saving then probably this shouldn't be added? If not saving would also expect calc$ == ""
  if(calc$name != "") self$append_to_variables_metadata(to_data_name, calc$result_name, calculated_by_label, calc$name)
  if(calc$save_calc) self$save_calculation(to_data_name, calc)
}
)