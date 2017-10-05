# Necessary packages for R-Instat
packs_lib <- c("reshape2", "lubridate","plyr", "dplyr", "rtf", "openxlsx", "ggplot2", "extRemes", "GGally", "agridat", "DAAG", "FactoMineR", "plotrix", "candisc", "R6", "openair", "circular", "survival", "Evapotranspiration", "clifro", "devtools", "factoextra", "circlize", "CircStats", "gridExtra", "ggfortify", "rio", "readxl", "lme4", "dummies", "ggthemes", "lazyeval", "stringr", "httr", "jsonlite", "fitdistrplus", "visreg", "climdex.pcic", "mosaic", "ncdf4", "getPass", "RMySQL", "DBI", "EnvStats", "signmedian.test", "sjPlot", "sjmisc", "plotly", "svglite", "htmlTable", "rje", "tidyr", "faraway", "ncdf.tools", "rrefine", "dae", "gapminder", "questionr", "nycflights13", "Lahman", "ncdf4.helpers", "RcppRoll", "cmsaf", "sjlabelled", "maptools", "RColorBrewer", "colorRamps", "mapdata", "rworldmap", "rworldxtra")
# Packages including dependencies (generated from miniCRAN package)
packs <- c("abind", "agridat", "arm", "assertthat", "backports", 
           "base64enc", "BH", "bindr", "bindrcpp", "bitops", "blme", "boot", 
           "broom", "candisc", "car", "caTools", "cellranger", "checkmate", 
           "chron", "circlize", "CircStats", "circular", "class", "classInt", 
           "clifro", "climdex.pcic", "cluster", "cmsaf", "coda", "codetools", 
           "coin", "colorRamps", "colorspace", "cowplot", "crosstalk", "curl", 
           "DAAG", "dae", "data.table", "DBI", "dendextend", "DEoptimR", 
           "devtools", "dichromat", "digest", "diptest", "distillery", "dotCall64", 
           "dplyr", "DT", "dummies", "e1071", "effects", "ellipse", "EnvStats", 
           "evaluate", "Evapotranspiration", "extRemes", "factoextra", "FactoMineR", 
           "faraway", "fields", "fitdistrplus", "flashClust", "flexmix", 
           "forcats", "foreach", "foreign", "fpc", "gapminder", "gdata", 
           "gdtools", "getPass", "GGally", "ggdendro", "ggeffects", "ggformula", 
           "ggfortify", "ggplot2", "ggpubr", "ggrepel", "ggsci", "ggsignif", 
           "ggthemes", "git2r", "glmmTMB", "GlobalOptions", "glue", "gplots", 
           "gridExtra", "gtable", "gtools", "haven", "heplots", "hexbin", 
           "highr", "hms", "htmlTable", "htmltools", "htmlwidgets", "httpuv", 
           "httr", "iterators", "JBTools", "jsonlite", "kernlab", "KernSmooth", 
           "knitr", "labeling", "labelled", "Lahman", "lattice", "latticeExtra", 
           "lazyeval", "leaps", "lme4", "Lmoments", "lmtest", "lubridate", 
           "magrittr", "mapdata", "mapproj", "maps", "maptools", "markdown", 
           "MASS", "Matrix", "MatrixModels", "mclust", "memoise", "merTools", 
           "mgcv", "mime", "miniUI", "minqa", "mnormt", "modelr", "modeltools", 
           "mosaic", "mosaicCore", "mosaicData", "multcomp", "munsell", 
           "mvtnorm", "ncdf.tools", "ncdf4.helpers", "ncdf4", "nlme", "nloptr", 
           "nnet", "nycflights13", "openair", "openssl", "openxlsx", "pbkrtest", 
           "PCICt", "pkgconfig", "plogr", "plotly", "plotrix", "plyr", "prabclus", 
           "prediction", "prettyunits", "progress", "psych", "purrr", "pwr", 
           "quantreg", "questionr", "R.methodsS3", "R.oo", "R6", "raster", 
           "RColorBrewer", "Rcpp", "RcppEigen", "RcppRoll", "RCurl", "readr", 
           "readxl", "rematch", "reshape", "reshape2", "rio", "rje", "rlang", 
           "rlist", "RMySQL", "RNetCDF", "robustbase", "rrefine", "rstudioapi", 
           "rtf", "rworldmap", "rworldxtra", "sandwich", "scales", "scatterplot3d", 
           "selectr", "shape", "shiny", "signmedian.test", "sjlabelled", 
           "sjmisc", "sjPlot", "sjstats", "sourcetools", "sp", "spam", "SparseM", 
           "stringdist", "stringi", "stringr", "survival", "svglite", "TH.data", 
           "tibble", "tidyr", "tidyselect", "TMB", "trimcluster", "viridis", 
           "viridisLite", "visreg", "whisker", "withr", "XML", "xtable", 
           "yaml", "zoo")

versions <- c("1.4-5", "1.12", "1.9-3", "0.2.0", "1.1.0", "0.1-3", 
              "1.65.0-1", "0.1", "0.2", "1.0-6", "1.0-4", "1.3-20", "0.4.2", 
              "0.7-2", "2.1-5", "1.17.1", "1.1.0", "1.8.3", "2.3-50", "0.4.1", 
              "0.2-4", "0.4-93", "7.3-14", "0.1-24", "3.1-4", "1.1-6", "2.0.6", 
              "1.8.1", "0.19-1", "0.2-15", "1.2-1", "2.3", "1.3-2", "0.8.0", 
              "1.0.0", "2.8.1", "1.22", "3.0-04", "1.10.4", "0.7", "1.5.2", 
              "1.0-8", "1.13.3", "2.0-0", "0.6.12", "0.75-7", "1.0-4", "0.9-04", 
              "0.7.3", "0.2", "1.5.6", "1.6-8", "3.1-2", "0.3-8", "2.2.1", 
              "0.10.1", "1.11", "2.0-8", "1.0.5", "1.36", "1.0.7", "9.0", "1.0-9", 
              "1.01-2", "2.3-14", "0.2.0", "1.4.3", "0.8-69", "2.1-10", "0.2.0", 
              "2.18.0", "0.1.6", "0.2-2", "1.3.2", "0.1-20", "0.2.1", "0.6", 
              "0.4.1", "2.2.1", "0.1.5", "0.6.5", "2.7", "0.4.0", "3.4.0", 
              "0.19.0", "0.1.1", "0.0.12", "1.1.1", "3.0.1", "2.3", "0.2.0", 
              "3.5.0", "1.1.0", "1.3-3", "1.27.1", "0.6", "0.3", "1.9", "0.3.6", 
              "0.9", "1.3.5", "1.3.1", "1.0.8", "0.7.2.9", "1.5", "0.9-25", 
              "2.23-15", "1.17", "0.3", "1.0.0", "6.0-0", "0.20-35", "0.6-28", 
              "0.2.0", "3.0", "1.1-13", "1.2-3", "0.9-35", "1.6.0", "1.5", 
              "2.2-6", "1.2-5", "3.2.0", "0.9-2", "0.8", "7.3-47", "1.2-11", 
              "0.4-1", "5.3", "1.1.0", "0.3.0", "1.8-20", "0.5", "0.1.1", "1.2.4", 
              "1.5-5", "0.1.1", "0.2-21", "1.1.0", "0.4.0", "0.14.0", "1.4-7", 
              "0.4.3", "1.0-6", "0.7.1.295", "0.3-3", "1.16", "3.1-131", "1.0.4", 
              "7.3-12", "0.2.2", "2.1-5", "0.9.7", "4.0.17", "0.4-7", "0.5-4", 
              "2.0.1", "0.1-1", "4.7.1", "3.6-6", "1.8.4", "2.2-6", "0.2.0", 
              "1.0.2", "1.1.2", "1.7.8", "0.2.3", "1.2-1", "5.33", "0.6.1", 
              "1.7.1", "1.21.0", "2.2.2", "2.5-8", "1.1-2", "0.12.12", "0.3.3.3.0", 
              "0.2.2", "1.95-4.8", "1.1.1", "1.0.0", "1.0.1", "0.8.7", "1.4.2", 
              "0.5.5", "1.9", "0.1.2", "0.4.6.1", "0.10.13", "1.8-2", "0.92-7", 
              "1.0", "0.7", "0.4-11", "1.3-6", "1.01", "2.4-0", "0.5.0", "0.3-40", 
              "0.3-1", "1.4.3", "1.0.5", "1.5.1", "1.0.1", "2.6.1", "2.3.3", 
              "0.11.0", "0.1.6", "1.2-5", "2.1-1", "1.77", "0.9.4.6", "1.1.5", 
              "1.2.0", "2.41-3", "1.2.0", "1.0-8", "1.3.4", "0.7.1", "0.2.0", 
              "1.7.11", "0.1-2", "0.4.0", "0.2.0", "2.4-1", "0.3-2", "2.0.0", 
              "3.98-1.9", "1.8-2", "2.1.14", "1.8-0")

success <- invisible(mapply(function(p, v) length(find.package(p, quiet = TRUE)) > 0 && compareVersion(as.character(packageVersion(p)), v) >= 0, packs, versions))
if(!all(success)) install.packages(names(success)[!success], repos = paste0("file:///", getwd(), "/extras"), type = "win.binary")

# Returns package names from packs which are not installed with the correct version
packages_not_installed <- function() {
  success <- invisible(mapply(function(p, v) length(find.package(p, quiet = TRUE)) > 0 && compareVersion(as.character(packageVersion(p)), v) >= 0, packs, versions))
  return(names(success)[!success])
}

# ggthemes temp added because themes list doesn't contain package names
# sp needed for plot.region() function which requires sp loaded but gives errors through R-Instat
# plyr and dplyr loaded in order to avoid conflicts
# ggplot2 loaded for convenience
# svglite and ggofrtify needed for View Graph dialog
# PCICt needed to access PCICt class when importing NET cdf files
packs_to_load <- c("plyr", "dplyr", "ggplot2", "ggthemes", "svglite", "ggfortify", "PCICt", "sp", "danny")
for(pack in packs_to_load) {
 try(library(pack, character.only = TRUE))
}

# Returns package names from packs_to_load which are not loaded
packages_not_loaded <- function() {
  return(packs_to_load[!packs_to_load %in% .packages()])
}

setwd(dirname(parent.frame(2)$ofile))
source("instat_object_R6.R")
source("data_object_R6.R")
source("labels_and_defaults.R")
source("stand_alone_functions.R")
files <- sort(dir(file.path(getwd(), 'Backend_Components/'), pattern=".R$", full.names = TRUE))
lapply(files, source, chdir = TRUE)