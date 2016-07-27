link <- R6Class("link",
                       public = list(
                         initialize = function(from_data_frame = "", to_data_frame = "", type = "", calculation = NA) {
                           self$from_data_frame <- from_data_frame
                           self$to_data_frame <- to_data_frame
                           self$calculation <- calculation
                         },
                         from_data_frame = "",
                         to_data_frame = "",
                         calculation = NA
                       ),
                       private = list(
                       ),
                       active = list(
                       )
)

link$set("public", "equals", function(compare_link) {
  return(self$from_data_frame == compare_link$from_data_frame 
         && self$to_data_frame == compare_link$to_data_frame 
         && self$calculation[[]] == compare_link$calculation[[]])
}
)

link$set("public", "calculation_exists", function() {
  return("calculation" %in% class(self$calculation))
}
)

instat_object$set("public", "add_link", function(link_object) {
  if(!any(sapply(private$links, function(x) x$equals(link_object)))) {
    private$.links[[length(private$.links) + 1]] <- link_object
  }
}
)

instat_object$set("public", "link_exists", function(from_data_frame, to_data_frame, link_calc) {
  for(curr_link in private$.links) {
    if(curr_link$from_data_frame == from_data_frame && curr_link$to_data_frame == to_data_frame && curr_link$calculation_exists() && curr_link$calculation$type == link_calc$type) {
      if(link_calc$type == "summary") {
        if(("factors" %in% names(curr_link$calculation$parameters)) 
           && ("factors" %in% names(link_calc$parameters)) 
           && setequal(link_calc$parameters[["factors"]], curr_link$calculation$parameters[["factors"]])) {
             return(TRUE)
        }
        else return(FALSE)
      }
      else return(FALSE)
    }
  }
  return(FALSE)
}
)

