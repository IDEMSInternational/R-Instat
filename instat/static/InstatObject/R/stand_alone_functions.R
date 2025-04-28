### Constants
month_abb_english <- c("Jan","Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec")
month_name_english <- c("January", "February", "March", "April", "May", "June", "July", 
                        "August", "September", "October", "November", "December")

 format_gt_table <- function(df) {
  df %>%
    gt::gt() %>%
    gt::cols_label(.list = setNames(colnames(df), colnames(df)))
}