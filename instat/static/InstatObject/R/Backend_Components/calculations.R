calculation <- R6Class("calculation",
                         public = list(
                           initialize = function(function_name = "", parameters = list(), 
                                                 calculated_from = c(), is_recalculable = TRUE,
                                                 sub_calculations = list(), type = "", filter_list = list()) {
                             private$function_name = function_name
                             private$parameters = parameters
                             private$calculated_from = c()
                             private$is_recalculable = is_recalculable
                             private$sub_calculations = sub_calculations
                             private$type = type
                             private$.filter_list = filter_list
                           }
                         ),
                       private = list(
                         function_name = "",
                         parameters = list(), 
                         calculated_from = c(),
                         is_recalculable = TRUE,
                         sub_calculations = list(),
                         type = "",
                         .filter_list = list()
                       ),
                       active = list(
                         filter_list = function(new_filter_list) {
                           if(missing(new_filter_list)) return(private$.filter_list)
                           else private$.filter_list <- new_filter_list
                         }
                       )
)

calculation$set("public", "add_sub_calculation", function(sub_calculation, name) {
  sub_calculations[[name]] <- sub_calculation
}
)