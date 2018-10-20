# ObyC types
option_1_label <- "option_1"
option_other_label <- "option_other"
context_1_label <- "context_1"
context_2_label <- "context_2"
context_3_label <- "context_3"
context_4_label <- "context_4"
context_other_label <- "context_other"
measurement_1_label <- "measurement_1"
measurement_other_label <- "measurement_other"
id_1_label <- "id_1"
id_other_label <- "id_other"
blocking_1_label <- "blocking_1"
blocking_other_label <- "blocking_other"

obyc_all_types <- c(option_1_label, option_other_label, context_1_label, context_2_label, context_3_label, context_4_label, context_other_label, measurement_1_label, measurement_other_label, id_1_label, id_other_label, blocking_1_label, blocking_other_label)

# Column metadata
obyc_type_label = "O_by_C_Type"

# Data frame metadata
is_obyc_label = "Is_O_by_C"

DataBook$set("public","define_as_options_by_context", function(data_name, obyc_types = NULL, key_columns = NULL) {
  self$append_to_dataframe_metadata(data_name, is_obyc_label, TRUE)
  for(curr_data_name in self$get_data_names()) {
    if(!self$get_data_objects(data_name)$is_metadata(is_obyc_label)) {
      self$append_to_dataframe_metadata(curr_data_name, is_obyc_label, FALSE)
    }
  }
  self$get_data_objects(data_name)$set_options_by_context_types(obyc_types = obyc_types, key_columns = key_columns)
}
)

DataSheet$set("public","set_options_by_context_types", function(obyc_types = NULL, key_columns = NULL) {
  if(!all(names(obyc_types) %in% obyc_all_types)) stop("Cannot recognise the following types: ", paste(names(obyc_types)[!names(obyc_types) %in% obyc_all_types], collapse = ", "))
  invisible(sapply(names(obyc_types), function(name) self$append_to_variables_metadata(obyc_types[[name]], obyc_type_label, name)))
  other_cols <- dplyr::setdiff(x = self$get_column_names(), y = unlist(obyc_types))
  self$append_to_variables_metadata(other_cols, obyc_type_label, NA)
}
)
