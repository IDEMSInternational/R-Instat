link <- R6Class("link",
                       public = list(
                         initialize = function(from_data_frame = "", to_data_frame = "", type = "", calculation = NA) {
                           self$from_data_frame <- from_data_frame
                           self$to_data_frame <- to_data_frame
                           self$type <- type
                           self$calculation <- calculation
                         },
                         from_data_frame = "",
                         to_data_frame = "",
                         type = "",
                         calculation = NA
                       ),
                       private = list(
                       ),
                       active = list(
                       )
)

link$set("public", "equals", function(compare_link) {
  if(self$from_data_frame == compare_link$from_data_frame 
         && self$to_data_frame == compare_link$to_data_frame
         && self$type == compare_link$type) {
    if(self$type == keyed_link_label) {
      #print(self$calculation$parameters)
      #print(compare_link$calculation$parameters)
      if(setequal(self$calculation$parameters, compare_link$calculation$parameters) && setequal(names(self$calculation$parameters), names(compare_link$calculation$parameters))) {
        for(name in names(compare_link$calculation$parameters)) {
          if(compare_link$calculation$parameters[[name]] != self$calculation$parameters[[name]]) return(FALSE)
        }
      return(TRUE)
      }
      else return(FALSE)
    }
    else return(FALSE)
  }
  else return(FALSE)
}
)

link$set("public", "calculation_exists", function() {
  return("calculation" %in% class(self$calculation))
}
)

instat_object$set("public", "add_link", function(link_object) {
  if(!self$link_exists(link_object)) {
    if(link_object$type == keyed_link_label) {
      if(self$get_data_objects(link_object$to_data_frame)$key_exists(link_object$parameters)) {
        message("A link with this definition already exists. It will not be added again.")
      }
      else private$.links[[length(private$.links) + 1]] <- link_object
    }
  }
}
)

# instat_object$set("public", "link_exists", function(from_data_frame, to_data_frame, type, link_calc) {
#   new_link <- link$new(from_data_frame = from_data_frame, to_data_frame = to_data_frame, type = type, link_calc = link_calc)
#   return(any(sapply(private$.links, function(link) link$equals(new_link))))
# }
# )

instat_object$set("public", "link_exists", function(new_link) {
  return(any(sapply(private$.links, function(link) link$equals(new_link))))
}
)