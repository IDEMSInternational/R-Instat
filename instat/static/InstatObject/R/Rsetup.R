# Necessary packages for R-Instat
# packs_lib <- c("reshape2", "lubridate","plyr", "dplyr", "rtf", "openxlsx", "ggplot2", "extRemes", "GGally", "agridat", "DAAG", "FactoMineR", "plotrix", "candisc", "R6", "openair", "circular", "survival", "Evapotranspiration", "clifro", "devtools", "factoextra", "circlize", "CircStats", "gridExtra", "ggfortify", "rio", "readxl", "lme4", "dummies", "ggthemes", "lazyeval", "stringr", "httr", "jsonlite", "fitdistrplus", "visreg", "climdex.pcic", "mosaic", "ncdf4", "getPass", "RMySQL", "DBI", "EnvStats", "signmedian.test", "sjPlot", "sjmisc", "plotly", "svglite", "htmlTable", "rje", "tidyr", "faraway", "ncdf.tools", "rrefine", "dae", "gapminder", "questionr", "nycflights13", "Lahman", "ncdf4.helpers", "RcppRoll", "cmsaf", "sjlabelled", "maptools", "RColorBrewer", "colorRamps", "mapdata", "rworldmap", "rworldxtra", "e1071", "robustbase", "wakefield")
# Packages including dependencies (generated from miniCRAN package)
packs <- c("abind", "acepack", "agricolae", "agridat", "AlgDesign", 
           "arm", "assertthat", "backports", "base64enc", "bayesplot", "BH", 
           "bindr", "bindrcpp", "bitops", "boot", "broom", "candisc", "car", 
           "carData", "caTools", "cellranger", "checkmate", "chron", "circlize", 
           "CircStats", "circular", "class", "classInt", "cli", "clifro", 
           "climdex.pcic", "cluster", "cmsaf", "coda", "codetools", "coin", 
           "colorRamps", "colorspace", "combinat", "cowplot", "crayon", 
           "crosstalk", "curl", "DAAG", "dae", "data.table", "DBI", "deldir", 
           "dendextend", "DEoptimR", "devtools", "digest", "diptest", "distillery", 
           "dotCall64", "dplyr", "dummies", "e1071", "effects", "ellipse", 
           "emmeans", "EnvStats", "estimability", "evaluate", "Evapotranspiration", 
           "expm", "extRemes", "factoextra", "FactoMineR", "fansi", "faraway", 
           "fields", "fitdistrplus", "flashClust", "flexmix", "forcats", 
           "foreach", "foreign", "Formula", "fpc", "gapminder", "gdata", 
           "gdtools", "geosphere", "getPass", "GGally", "ggdendro", "ggeffects", 
           "ggformula", "ggfortify", "ggplot2", "ggpubr", "ggrepel", "ggridges", 
           "ggsci", "ggsignif", "ggstance", "ggthemes", "git2r", "glmmTMB", 
           "GlobalOptions", "glue", "gmodels", "goftest", "gplots", "gridExtra", 
           "gtable", "gtools", "haven", "heplots", "hexbin", "highr", "Hmisc", 
           "hms", "htmlTable", "htmltools", "htmlwidgets", "httpuv", "httr", 
           "iterators", "JBTools", "jsonlite", "kernlab", "KernSmooth", 
           "klaR", "knitr", "labeling", "labelled", "Lahman", "later", "lattice", 
           "latticeExtra", "lazyeval", "leaps", "LearnBayes", "lme4", "lmomco", 
           "Lmoments", "lmtest", "lubridate", "magrittr", "mapdata", "mapproj", 
           "maps", "maptools", "markdown", "MASS", "Matrix", "MatrixModels", 
           "mclust", "memoise", "mgcv", "mime", "miniUI", "minqa", "mnormt", 
           "modelr", "modeltools", "mosaic", "mosaicCore", "mosaicData", 
           "multcomp", "munsell", "mvtnorm", "ncdf.tools", "ncdf4.helpers", 
           "ncdf4", "nlme", "nloptr", "nnet", "nortest", "nycflights13", 
           "openair", "openssl", "openxlsx", "pbkrtest", "PCICt", "pillar", 
           "pkgconfig", "plogr", "plotly", "plotrix", "plyr", "prabclus", 
           "prediction", "prettyunits", "progress", "promises", "psych", 
           "purrr", "pwr", "quantreg", "questionr", "R.methodsS3", "R.oo", 
           "R6", "raster", "RColorBrewer", "Rcpp", "RcppEigen", "RcppRoll", 
           "RCurl", "readr", "readxl", "rematch", "reshape", "reshape2", 
           "rio", "rje", "rlang", "rlist", "RMySQL", "RNetCDF", "robustbase", 
           "rpart", "rrefine", "rstudioapi", "rtf", "rworldmap", "rworldxtra", 
           "sandwich", "scales", "scatterplot3d", "sf", "shape", "shiny", 
           "signmedian.test", "sjlabelled", "sjmisc", "sjPlot", "sjstats", 
           "snakecase", "sourcetools", "sp", "spam", "SparseM", "spData", 
           "spdep", "SPEI", "stringdist", "stringi", "stringr", "survey", 
           "survival", "svglite", "TH.data", "tibble", "tidyr", "tidyselect", 
           "TMB", "trimcluster", "units", "utf8", "viridis", "viridisLite", 
           "visreg", "wakefield", "weathermetrics", "whisker", "withr", 
           "XML", "xml2", "xtable", "yaml", "zip", "zoo")

versions <- c("1.4-5", "1.4.1", "1.2-8", "1.16", "1.1-7.3", "1.10-1", 
              "0.2.0", "1.1.2", "0.1-3", "1.6.0", "1.66.0-1", "0.1.1", "0.2.2", 
              "1.0-6", "1.3-20", "0.5.0", "0.8-0", "3.0-0", "3.0-1", "1.17.1.1", 
              "1.1.0", "1.8.5", "2.3-52", "0.4.4", "0.2-6", "0.4-93", "7.3-14", 
              "0.2-3", "1.0.0", "3.2-0", "1.1-9", "2.0.7-1", "1.9.4", "0.19-1", 
              "0.2-15", "1.2-2", "2.3", "1.3-2", "0.0-8", "0.9.3", "1.3.4", 
              "1.0.0", "3.2", "1.22", "3.0-12", "1.11.4", "1.0.0", "0.1-15", 
              "1.8.0", "1.0-8", "1.13.6", "0.6.15", "0.75-7", "1.0-4", "1.0-0", 
              "0.7.6", "1.5.6", "1.7-0", "4.0-2", "0.4.1", "1.2.3", "2.3.1", 
              "1.3", "0.11", "1.12", "0.999-2", "2.0-9", "1.0.5", "1.41", "0.3.0", 
              "1.0.7", "9.6", "1.0-9", "1.01-2", "2.3-14", "0.3.0", "1.4.4", 
              "0.8-71", "1.2-3", "2.1-11.1", "0.3.0", "2.18.0", "0.1.7", "1.5-7", 
              "0.2-2", "1.4.0", "0.1-20", "0.5.0", "0.9.0", "0.4.5", "3.0.0", 
              "0.1.7", "0.8.0", "0.5.0", "2.9", "0.4.0", "0.3.1", "4.0.0", 
              "0.23.0", "0.2.2.0", "0.1.0", "1.3.0", "2.18.1", "1.1-1", "3.0.1", 
              "2.3", "0.2.0", "3.8.1", "1.1.2", "1.3-5", "1.27.2", "0.7", "4.1-1", 
              "0.4.2", "1.12", "0.3.6", "1.2", "1.4.5", "1.3.1", "1.0.10", 
              "0.7.2.9", "1.5", "0.9-27", "2.23-15", "0.6-14", "1.20", "0.3", 
              "1.1.0", "6.0-0", "0.7.3", "0.20-35", "0.6-28", "0.2.1", "3.0", 
              "2.15.1", "1.1-17", "2.3.1", "1.2-3", "0.9-36", "1.7.4", "1.5", 
              "2.3.0", "1.2.6", "3.3.0", "0.9-3", "0.8", "7.3-50", "1.2-14", 
              "0.4-1", "5.4.1", "1.1.0", "1.8-24", "0.5", "0.1.1.1", "1.2.4", 
              "1.5-5", "0.1.2", "0.2-22", "1.4.0", "0.6.0", "0.17.0", "1.4-8", 
              "0.5.0", "1.0-8", "0.7.1.295", "0.3-3", "1.16", "3.1-137", "1.0.4", 
              "7.3-12", "1.0-4", "1.0.0", "2.4-2", "1.0.2", "4.1.0", "0.4-7", 
              "0.5-4.1", "1.3.0", "2.0.2", "0.2.0", "4.8.0", "3.7-2", "1.8.4", 
              "2.2-6", "0.3.6", "1.0.2", "1.2.0", "1.0.1", "1.8.4", "0.2.5", 
              "1.2-2", "5.36", "0.6.3", "1.7.1", "1.22.0", "2.2.2", "2.6-7", 
              "1.1-2", "0.12.18", "0.3.3.4.0", "0.3.0", "1.95-4.11", "1.1.1", 
              "1.1.0", "1.0.1", "0.8.7", "1.4.3", "0.5.10", "1.9", "0.2.1", 
              "0.4.6.1", "0.10.15", "1.9-1", "0.93-2", "4.1-13", "1.0", "0.7", 
              "0.4-13", "1.3-6", "1.01", "2.4-0", "1.0.0", "0.3-41", "0.6-3", 
              "1.4.4", "1.1.0", "1.5.1", "1.0.13", "2.7.4", "2.5.0", "0.16.0", 
              "0.9.2", "0.1.7", "1.3-1", "2.2-0", "1.77", "0.2.9.3", "0.7-8", 
              "1.7", "0.9.5.1", "1.1.7", "1.3.1", "3.33-2", "2.42-6", "1.2.1", 
              "1.0-9", "1.4.2", "0.8.1", "0.2.4", "1.7.14", "0.1-2.1", "0.6-0", 
              "1.1.4", "0.5.1", "0.3.0", "2.5-0", "0.3.3", "1.2.2", "0.3-2", 
              "2.1.2", "3.98-1.15", "1.2.0", "1.8-2", "2.2.0", "1.0.0", "1.8-3")

##################################################

# Returns package names from packs which are not installed with the correct version
packages_not_installed <- function() {
  success <- invisible(mapply(function(p, v) length(find.package(p, quiet = TRUE)) > 0 && compareVersion(as.character(packageVersion(p)), v) >= 0, packs, versions))
  return(names(success)[!success])
}

load_R_Instat_packages <- function() {
  # ggthemes temp added because themes list doesn't contain package names
  # sp needed for plot.region() function which requires sp loaded but gives errors through R-Instat
  # plyr and dplyr loaded in order to avoid conflicts
  # ggplot2 loaded for convenience
  # svglite and ggofrtify needed for View Graph dialog
  # PCICt needed to access PCICt class when importing NET cdf files
  packs_to_load <- c("plyr", "dplyr", "ggplot2", "ggthemes", "svglite", "ggfortify", "PCICt", "sp")
  for(pack in packs_to_load) {
    try(library(pack, character.only = TRUE))
  }
}

# Returns package names from packs_to_load which are not loaded
packages_not_loaded <- function() {
  return(packs_to_load[!packs_to_load %in% .packages()])
}

##################################################

success <- invisible(mapply(function(p, v) length(find.package(p, quiet = TRUE)) > 0 && compareVersion(as.character(packageVersion(p)), v) >= 0, packs, versions))
if(!all(success)) install.packages(names(success)[!success], repos = paste0("file:///", getwd(), "/extras"), type = "win.binary")

load_R_Instat_packages()

setwd(dirname(parent.frame(2)$ofile))
source("instat_object_R6.R")
source("data_object_R6.R")
source("labels_and_defaults.R")
source("stand_alone_functions.R")
files <- sort(dir(file.path(getwd(), 'Backend_Components/'), pattern=".R$", full.names = TRUE))
invisible(lapply(files, source, chdir = TRUE))