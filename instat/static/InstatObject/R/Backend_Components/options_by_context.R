option_label <- "option"
context_label <- "context"
measurement_label <- "measurement"

# Column metadata
obyc_type_label = "O_by_C_Type"

# Data frame metadata
is_obyc_label = "Is_O_by_C"

instat_object$set("public","define_as_options_by_context", function(data_name, option_types = NULL, context_types = NULL, measurement_types = NULL) {
  self$append_to_dataframe_metadata(data_name, is_obyc_label, TRUE)
  for(curr_data_name in self$get_data_names()) {
    if(!self$get_data_objects(data_name)$is_metadata(is_obyc_label)) {
      self$append_to_dataframe_metadata(curr_data_name, is_obyc_label, FALSE)
    }
  }
  self$get_data_objects(data_name)$set_options_by_context_types(option_types = option_types, context_types = context_types, measurement_types = measurement_types)
}
)

data_object$set("public","set_options_by_context_types", function(option_types = NULL, context_types = NULL, measurement_types = NULL) {
  self$append_to_variables_metadata(option_types, obyc_type_label, option_label)
  self$append_to_variables_metadata(context_types, obyc_type_label, context_label)
  self$append_to_variables_metadata(measurement_types, obyc_type_label, measurement_label)
  other_cols <- dplyr::setdiff(x = self$get_column_names(), y = c(option_types, context_types, measurement_types))
  self$append_to_variables_metadata(other_cols, obyc_type_label, NA)
}
)
