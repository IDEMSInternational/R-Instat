# packs and versions will be added to file when installer created

##################################################

# Returns package names from packs which are not installed with the correct version
packages_not_installed <- function() {
  success <- invisible(mapply(function(p, v) length(find.package(p, quiet = TRUE)) > 0 && compareVersion(as.character(packageVersion(p)), v) >= 0, packs, versions))
  return(names(success)[!success])
}

load_R_Instat_packages <- function() {
  # ggthemes temp added because themes list doesn't contain package names
  # sp needed for plot.region() function which requires sp loaded but gives errors through R-Instat ## note that this function is now in instatClimatic.
  # plyr and dplyr loaded in order to avoid conflicts
  # ggplot2 loaded for convenience
  # svglite and ggfortify needed for View Graph dialog
  # PCICt needed to access PCICt class when importing NETcdf files  # this is loaded in with instatClimatic now I think.
  # ggmosaic because geom_mosaic aes only work when ggmosaic is loaded
  # wakefield because many functions do not work without loading (https://github.com/trinker/wakefield/issues/11)
  # latticeExtra because conditionalQuantile key positions work well when latticeExtra is loaded
  # texmex loaded because of extreme value distributions
  # tidyr loaded because unite() function is required by mmtable() function from mmtable2 package
  # purrr loaded because map_int() is required  by function(s) such as header_top_left() from mmtable2 package
  # mc2d loaded because of triangular and continuous empirical distributions
  packs_to_load <- c("ggplot2", "gt", "dplyr", "tidyr", "purrr", "instatExtras", "instatClimatic", "databook", "instatCalculations")
  for(pack in packs_to_load) {
    try(library(pack, character.only = TRUE))
  }
}

# Returns package names from packs_to_load which are not loaded
packages_not_loaded <- function() {
  return(packs_to_load[!packs_to_load %in% .packages()])
}

##################################################

# Now do not install packages on start up
# success <- invisible(mapply(function(p, v) length(find.package(p, quiet = TRUE)) > 0 && compareVersion(as.character(packageVersion(p)), v) >= 0, packs, versions))
# if(!all(success)) install.packages(names(success)[!success], repos = paste0("file:///", getwd(), "/extras"), type = "win.binary")

load_R_Instat_packages()

setwd(dirname(parent.frame(2)$ofile))
# source("instat_object_R6.R")
# source("data_object_R6.R")
source("labels_and_defaults.R")
source("stand_alone_functions.R")
files <- sort(dir(file.path(getwd(), 'Backend_Components/'), pattern=".R$", full.names = TRUE, recursive = TRUE))
invisible(lapply(files, source, chdir = TRUE))
