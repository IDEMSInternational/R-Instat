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