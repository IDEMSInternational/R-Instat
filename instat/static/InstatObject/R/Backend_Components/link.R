link <- R6Class("link",
                       public = list(
                         initialize = function(from_data_frame, to_data_frame, calculation) {
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

instat_object$set("public", "add_link", function(link_object) {
  if(!any(sapply(private$links, function(x) x$equals(link_object)))) {
    private$.links[[length(private$.links) + 1]] <- link_object
  }
}
)