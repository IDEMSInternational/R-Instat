#==================================================================================================================
# DISPLAY DAY OF THE YEAR 
#' @title Get the table of day of the year
#' @name display_doy
#' @author Frederic Ntirenganya, Danny Parsons 2015 (AMI)
#' 
#' @description \code{get.table_doy }
#' Display day of the year in a table  
#'  
#' @param row.names logical, if FALSE the row names attributed to the dataframe are removed 
#' @param month_list  character vector for the names of the months
#' @param file   the path of the output file
#' @param width  the width of the output page
#' @param height   the width of the output page
#' @param day_display  character for the column name containing the day of the month
#' @param font_size  default font size for the document in the points
#' @param na.string character string of missing value to be displayed in the table
#' @param save_table Logical, if TRUE save the output file
#' 
#' @examples
#' ClimateObj <- climate( data_table = list( data ), date_formats = list( "%m/%d/%Y" ) )
#' Default dateformats: "%Y/%m/%d"
#' # where "data" is a data.frame containing the desired variable to be displayed.
#' climateObj$display_doy()
#' @return It returns  a table

display_doy <- function(months_list = month.abb, day_display = "Day", file="DOY.doc", save_table = FALSE,
                        row.names = FALSE, width=8.5, height=11, font.size=6, title="DOY table", font.size_header=10, NA.string="") {
  
  # doy_table is created in labels_and_defaults.R and can be called here
  # Not created in this method to save computation
  
  names( doy_table )[ 1 ] <- day_display
  colnames( doy_table )[2:13] <- months_list
  #Always print table
  print( doy_table, row.names = row.names )
  #Some one might want this file. 
  if(save_table) {
    save_table_to_file(file = file, table = doy_table, width = width, height = height, font.size = font.size, title = title, font.size_header = font.size_header, NA.string = NA.string, row.names = row.names)
  }
}