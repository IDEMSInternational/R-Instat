instat_object <- R6Class("instat_object",
                  public = list(
                    initialize = function() {
                    },
                    get_data_objects_changed = function() {
                      private$data_objects_changed
                    }
                  ),
                  private = list(
                    data_objects = list(),
                    metadata = list(),
                    models = list(),
                    data_objects_changed = FALSE
                  )
)

InstatDataObject <- instat_object$new()
InstatDataObject$get_data_objects_changed()
