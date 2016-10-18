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
                                               sub_calculations = list(), calculated_from = list()) {
                           self$function_exp <- function_exp
                           self$type <- type
                           self$name <- name
                           self$manipulations <- manipulations
                           self$sub_calculations <- sub_calculations
                           self$calculated_from <- calculated_from
                         },
                         name = "",
                         type = "",
                         manipulations = list(),
                         sub_calculations = list(),
                         function_exp = "",
                         calculated_from = list()
                       )
)

# village_group <- instat_calculation$new(type = "by", calculated_from = list(survey = "Village."))
# total <- instat_calculation$new(function_exp = "n()", type = "summary", name = "total")
# variety_group <- instat_calculation$new(type = "by", calculated_from = list(survey = "Variety."))
# val <- instat_calculation$new(function_exp = "n()", type = "summary", name = "val", 
#                               manipulations = list(variety_group))
# prop_calc <- instat_calculation$new(function_exp = "val/total", type = "calculation", 
#                                     name = "prop", manipulations = list(village_group), 
#                                     sub_calculations = list(total, val))

# pass in and return link with curr_data as one argument
instat_object$set("public", "apply_instat_calculation", function(calc, curr_data) {
  for(manipulation in calc$manipulations) {
    # now be pair (link + df)
    curr_data <- self$apply_instat_calculation(manipulation, curr_data)
  }
  if(!missing(curr_data)) sub_calc_results <- curr_data
  first_sub_calc = TRUE
  for(sub_calc in calc$sub_calculations) {
    curr_sub_calc <- self$apply_instat_calculation(sub_calc, curr_data)
    if(first_sub_calc) sub_calc_results <- curr_sub_calc
    # change to joining all parts of list (data, link, boolean)
    # to merge links from all sub calculations, take link of the "biggest" data frame
    # below is joining the data frame only
    # this needs to change to do the joining correctly
    # through a similar process used by save_calculation to know how to add output
    else sub_calc_results <- full_join(sub_calc_results, curr_sub_calc)
    first_sub_calc = FALSE
  }
  if(!first_sub_calc) curr_data <- sub_calc_results
  
  data_names <- unique(as.vector(names(calc$calculated_from)))
  if(missing(curr_data)) {
    if(length(data_names) == 0) stop("No data frame for calculation.")
    else {
      # change to set data part
      # create/get link from data to itself
      curr_data <- self$get_data_frame(data_names[[1]])
    }
  }
  
  col_names_exp = c()
  i = 1
  for(col_name in calc$calculated_from) {
    # change to names(curr_data[[data]])
    if(!(col_name %in% names(curr_data))) {
      stop(col_name, " not found in data.")
    }
    col_names_exp[[i]] <- interp(~ var, var = as.name(col_name))
    i = i + 1
  }
  
  # updating link as well
  # replace curr_data with curr_data[[data]]
  if(calc$type == "calculation") {
    # link unchanged
    curr_data <- curr_data %>% mutate_(.dots = setNames(list(as.formula(paste0("~", calc$function_exp))), calc$name))
  }
  else if(calc$type == "summary") {
    # modify link to include linking columns
    # set requires_key = TRUE
    curr_data <- curr_data %>% summarise_(.dots = setNames(list(as.formula(paste0("~", calc$function_exp))), calc$name))
  }
  else if(calc$type == "by") {
    # link unchanged
    curr_data <- curr_data %>% group_by_(.dots = col_names_exp, add = TRUE)
  }
  else if(calc$type == "filter") {
    # link unchanged
    # set requires_key = TRUE
    curr_data <- curr_data %>% filter_(.dots = setNames(list(as.formula(paste0("~", calc$function_exp))), calc$name))
  }
  else if(calc$type == "join") {
    # link unchanged?
    stop("join not yet implemented.")
  }
  # maybe change this to have empty main calculation with sub calculations type = "combination"
  else stop("Cannot detect calculation type:", calc$type)
  # curr_data needs to contain requires_key
  # if(calc$save) self$save_calc_result(calc, curr_data)
  # need to add metadata to new columns from calculation
  return(curr_data)
}
)