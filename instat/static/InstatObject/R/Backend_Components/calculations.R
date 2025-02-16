library(instatCalculations)
library(databook)

# Calculation labels
#These are the names of the list returned by apply_instat_calculation
c_data_label <- "data"
c_link_label <- "link"
c_has_summary_label <- "has_summary"
c_has_filter_label <- "has_filter"

# This performs the calculation, including saving the output and calculation if required.
# A list of 4 elements is returned:
# $data : a data frame containing the output from the calculation, usually not just the output but also other columns at the same "level"
# $link : a link used to determine which data frame the output should be saved in.
# $has_summary : a logical value indicating whether a summary has been done
# $has_filter : a logical value indicating whether a filter has been done

# This method is called recursively, and it would not be called by a user, another function would always handle the output and display
# results to the user (usually only the $data part of the list)

# given a column name (column) and a calculated_from list (x)
# this returns the name of the data frame the column is associated with
find_df_from_calc_from <- function(x, column) {
  for(i in seq_along(x)) {
    if(column %in% x[[i]]) return(names(x)[i])
  }
  return("")
}