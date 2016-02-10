Oldwd= getwd()
setwd(dirname(parent.frame(2)$ofile))
source('labels_and_defaults.R')
source('climate_data_refclass.R')
source('climate_refclass.R')
files <- sort(dir(file.path(getwd(), 'ClimateMethods/DataManipulation/'),pattern=".R$", full.names = TRUE))
lapply(files, source, chdir = TRUE)
files <- sort(dir(file.path(getwd(), 'ClimateMethods/Graphics/'),pattern=".R$", full.names = TRUE))
lapply(files, source, chdir = TRUE)
files <- sort(dir(file.path(getwd(), 'ClimateMethods/Models/'),pattern=".R$", full.names = TRUE))
lapply(files, source, chdir = TRUE)
files <- sort(dir(file.path(getwd(), 'R_front_ends/'),pattern=".R$", full.names = TRUE))
lapply(files, source, chdir = TRUE)
files <- sort(dir(file.path(getwd(), 'BackendComponents/'),pattern=".R$", full.names = TRUE))
lapply(files, source, chdir = TRUE)
setwd(Oldwd)
  
ClimateCO <- function (data_tables = list(), climate_obj_meta_data = list(), 
                       data_tables_meta_data = rep(list(list()),length(data_tables)),
                       data_tables_variables = rep(list(list()),length(data_tables)), 
                       imported_from = as.list(rep("",length(data_tables))),
                       data_time_periods = as.list(rep("daily",length(data_tables))),
                       messages=TRUE, convert=TRUE, create=TRUE,
                       date_formats = as.list(rep("%d/%m/%Y",length(data_tables)))) {
  CO<<-climate$new(data_tables=data_tables, climate_obj_meta_data=climate_obj_meta_data, data_tables_meta_data=data_tables_meta_data, data_tables_variables=data_tables_variables, 
                   imported_from=imported_from, data_time_periods=data_time_periods, messages=messages, convert=convert, create=create,
                   date_formats=date_formats)
  return=TRUE
}
ClimateCOfromSQL <- function (SQL) {
  CO<<-climate$new()
  CO$import_sqldata(SQL)
  return=TRUE
}