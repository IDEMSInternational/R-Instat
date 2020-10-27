# Packages including dependencies
# Generated from install_packages.R, do not edit manually!
packs <- c("abind", "agricolae", "agridat", 
           "AlgDesign", "animation", "ash", "askpass", 
           "assertthat", "backports", "base64enc", "bayestestR", 
           "BH", "bitops", "boot", "brew", "broom", 
           "callr", "candisc", "car", "carData", 
           "cellranger", "changepoint", "checkmate", "chillR", 
           "chron", "circlize", "CircStats", "circular", 
           "class", "classInt", "cli", "clifro", 
           "climdex.pcic", "clipr", "cluster", "cmsaf", 
           "cmsafops", "cmsafvis", "colorRamps", "colorspace", 
           "colourpicker", "combinat", "commonmark", "conquer", 
           "corrplot", "countrycode", "covr", "cowplot", 
           "cpp11", "crayon", "crosstalk", "curl", 
           "DAAG", "dae", "data.table", "date", 
           "DBI", "dendextend", "DEoptimR", "desc", 
           "devtools", "digest", "distillery", "dotCall64", 
           "dplyr", "DT", "dummies", "e1071", "effectsize", 
           "ellipse", "ellipsis", "emmeans", "EnvStats", 
           "estimability", "evaluate", "Evapotranspiration", 
           "extraDistr", "extrafont", "extrafontdb", "extRemes", 
           "factoextra", "FactoMineR", "fansi", "faraway", 
           "farver", "fastmap", "fields", "fitdistrplus", 
           "flashClust", "FNN", "forcats", "forecast", 
           "foreign", "Formula", "fracdiff", "fs", 
           "gapminder", "gdtools", "generics", "geosphere", 
           "getPass", "GGally", "ggalt", "ggdendro", 
           "ggeffects", "ggfittext", "ggforce", "ggformula", 
           "ggfortify", "ggmosaic", "ggplot2", "ggpmisc", 
           "ggpubr", "ggrepel", "ggridges", "ggsci", 
           "ggsignif", "ggstance", "ggtext", "ggthemes", 
           "gh", "git2r", "GlobalOptions", "glue", 
           "goftest", "gridExtra", "gridtext", "gtable", 
           "haven", "heplots", "hexbin", "highr", 
           "Hmisc", "hms", "htmlTable", "htmltools", 
           "htmlwidgets", "httpuv", "httr", "imputeTS", 
           "ini", "insight", "isoband", "jpeg", 
           "jsonlite", "Kendall", "KernSmooth", "klaR", 
           "knitr", "labeling", "labelled", "Lahman", 
           "later", "lattice", "latticeExtra", "lazyeval", 
           "leaflet.providers", "leaflet", "leaps", "lifecycle", 
           "lme4", "lmomco", "Lmoments", "lmtest", 
           "lubridate", "magick", "magrittr", "mapdata", 
           "mapproj", "maps", "maptools", "markdown", 
           "MASS", "Matrix", "MatrixModels", "matrixStats", 
           "memoise", "mgcv", "mime", "miniUI", 
           "minqa", "modelr", "mosaic", "mosaicCore", 
           "mosaicData", "munsell", "mvtnorm", "ncdf4", 
           "nlme", "nloptr", "nnet", "nortest", 
           "numDeriv", "nycflights13", "openair", "openssl", 
           "openxlsx", "parameters", "patchwork", "pbkrtest", 
           "pbs", "PCICt", "performance", "pillar", 
           "pkgbuild", "pkgconfig", "pkgload", "plotly", 
           "plotrix", "pls", "plyr", "png", "polyclip", 
           "polynom", "praise", "prettyunits", "processx", 
           "productplots", "progress", "proj4", "promises", 
           "ps", "purrr", "quadprog", "quantmod", 
           "quantreg", "questionr", "R.cache", "R.methodsS3", 
           "R.oo", "R.utils", "R6", "rainfarmr", 
           "raster", "rcmdcheck", "RColorBrewer", "Rcpp", 
           "RcppArmadillo", "RcppEigen", "RcppRoll", "RCurl", 
           "readODS", "readr", "readxl", "rematch", 
           "rematch2", "remotes", "reshape", "reshape2", 
           "rex", "rio", "rje", "rlang", "rlist", 
           "RMAWGEN", "RMySQL", "robustbase", "roxygen2", 
           "rpart", "rprojroot", "rrefine", "rstatix", 
           "rstudioapi", "rtf", "Rttf2pt1", "rversions", 
           "rvest", "rworldmap", "rworldxtra", "sandwich", 
           "scales", "scatterplot3d", "selectr", "sessioninfo", 
           "sf", "shades", "shape", "shiny", "shinyFiles", 
           "shinyjs", "shinythemes", "signmedian.test", 
           "sjlabelled", "sjmisc", "sjPlot", "sjstats", 
           "sourcetools", "sp", "spam", "SparseM", 
           "SPEI", "splus2R", "statmod", "stinepack", 
           "stringdist", "stringi", "stringr", "strucchange", 
           "styler", "survival", "svglite", "sys", 
           "systemfonts", "testthat", "tibble", "tidyr", 
           "tidyselect", "timeDate", "treemapify", "trend", 
           "tseries", "TTR", "tweenr", "units", 
           "urca", "usethis", "utf8", "vars", "vctrs", 
           "viridis", "viridisLite", "visdat", "visreg", 
           "wakefield", "weathermetrics", "whisker", "withr", 
           "xfun", "XML", "xml2", "xopen", "xtable", 
           "xts", "yaml", "zip", "zoo")

versions <- c("1.4-5", "1.3-3", "1.17", "1.2.0", 
              "2.6", "1.0-15", "1.1", "0.2.1", "1.1.10", 
              "0.1-3", "0.7.2", "1.72.0-3", "1.0-6", 
              "1.3-25", "1.0-6", "0.7.1", "3.5.1", 
              "0.8-3", "3.0-10", "3.0-4", "1.1.0", 
              "2.2.2", "2.0.0", "0.70.24", "2.3-56", 
              "0.4.10", "0.2-6", "0.4-93", "7.3-17", 
              "0.4-3", "2.1.0", "3.2-3", "1.1-11", 
              "0.7.1", "2.1.0", "3.0.0", "1.0.0", "1.0.1", 
              "2.3", "1.4-1", "1.1.0", "0.0-8", "1.7", 
              "1.0.2", "0.84", "1.2.0", "3.5.1", "1.1.0", 
              "0.2.3", "1.3.4", "1.1.0.1", "4.3", "1.24", 
              "3.1-27", "1.13.0", "1.2-39", "1.1.0", 
              "1.14.0", "1.0-8", "1.2.0", "2.3.2", 
              "0.6.25", "1.1", "1.0-0", "1.0.2", "0.16", 
              "1.5.6", "1.7-4", "0.3.3", "0.4.2", "0.3.1", 
              "1.5.1", "2.3.1", "1.3", "0.14", "1.15", 
              "1.9.1", "0.17", "1.0", "2.0-12", "1.0.7", 
              "2.3", "0.4.1", "1.0.7", "2.0.3", "1.0.1", 
              "11.6", "1.1-1", "1.01-2", "1.1.3", "0.5.0", 
              "8.13", "0.8-80", "1.2-3", "1.5-1", "1.5.0", 
              "0.3.0", "0.2.2", "0.0.2", "1.5-10", 
              "0.2-2", "2.0.0", "0.4.0", "0.1.22", 
              "0.16.0", "0.9.0", "0.3.2", "0.9.4", 
              "0.4.11", "0.2.0", "3.3.2", "0.3.6", 
              "0.4.0", "0.8.2", "0.5.2", "2.9", "0.6.0", 
              "0.3.4", "0.1.0", "4.2.0", "1.1.0", "0.27.1", 
              "0.1.2", "1.4.2", "1.2-2", "2.3", "0.1.1", 
              "0.3.0", "2.3.1", "1.3-5", "1.28.1", 
              "0.8", "4.4-1", "0.5.3", "2.1.0", "0.5.0", 
              "1.5.2", "1.5.4", "1.4.2", "3.1", "0.3.1", 
              "0.9.6", "0.2.2", "0.1-8.1", "1.7.1", 
              "2.2", "2.23-17", "0.6-15", "1.30", "0.3", 
              "2.7.0", "8.0-0", "1.1.0.1", "0.20-41", 
              "0.6-29", "0.2.2", "1.9.0", "2.0.3", 
              "3.1", "0.2.0", "1.1-23", "2.3.6", "1.3-1", 
              "0.9-38", "1.7.9", "2.4.0", "1.5", "2.3.0", 
              "1.2.7", "3.3.0", "1.0-2", "1.1", "7.3-53", 
              "1.2-18", "0.4-1", "0.57.0", "1.1.0", 
              "1.8-33", "0.9", "0.1.1.1", "1.2.4", 
              "0.1.8", "1.8.2", "0.8.0", "0.20.1", 
              "0.5.0", "1.1-1", "1.17", "3.1-149", 
              "1.2.2.2", "7.3-14", "1.0-4", "2016.8-1.1", 
              "1.0.1", "2.7-6", "1.4.3", "4.2.2", "0.8.6", 
              "1.0.1", "0.4-8.6", "1.1", "0.5-4.1", 
              "0.5.0", "1.4.6", "1.1.0", "2.0.3", "1.1.0", 
              "4.9.2.1", "3.7-8", "2.7-3", "1.8.6", 
              "0.1-7", "1.10-0", "1.4-0", "1.0.0", 
              "1.1.1", "3.4.4", "0.1.1", "1.2.2", "1.0-10", 
              "1.1.1", "1.4.0", "0.3.4", "1.5-8", "0.4.17", 
              "5.73", "0.7.3", "0.14.0", "1.8.1", "1.24.0", 
              "2.10.1", "2.4.1", "0.1", "3.3-13", "1.3.3", 
              "1.1-2", "1.0.5", "0.9.900.3.0", "0.3.3.7.0", 
              "0.3.0", "1.98-1.2", "1.7.0", "1.4.0", 
              "1.3.1", "1.0.1", "2.1.2", "2.2.0", "0.8.8", 
              "1.4.4", "1.2.0", "0.5.16", "1.10.16", 
              "0.4.8", "0.4.6.1", "1.3.7", "0.10.20", 
              "0.93-6", "7.1.1", "4.1-15", "1.3-2", 
              "1.1.0", "0.6.0", "0.11", "0.4-14.1", 
              "1.3.8", "2.0.2", "0.3.6", "1.3-6", "1.01", 
              "3.0-0", "1.1.1", "0.3-41", "0.4-2", 
              "1.1.1", "0.9-6", "1.4.0", "1.4.5", "1.5.0", 
              "0.8.0", "2.0.0", "1.1.2", "1.5.1", "1.1.7", 
              "2.8.5", "2.8.5", "0.18.0", "0.1.7", 
              "1.4-4", "2.5-1", "1.78", "1.7", "1.2-2", 
              "1.4.34", "1.4", "0.9.6.3", "1.5.3", 
              "1.4.0", "1.5-2", "1.3.2", "3.2-7", "1.2.3.2", 
              "3.4", "0.3.2", "2.3.2", "3.0.4", "1.1.2", 
              "1.1.0", "3043.102", "2.5.3", "1.1.4", 
              "0.10-47", "0.24.2", "1.0.1", "0.6-7", 
              "1.3-0", "1.6.3", "1.1.4", "1.5-3", "0.3.4", 
              "0.5.1", "0.3.0", "0.5.3", "2.7.0", "0.3.6", 
              "1.2.2", "0.4", "2.3.0", "0.18", "3.99-0.5", 
              "1.3.2", "1.0.0", "1.8-4", "0.12.1", 
              "2.2.1", "2.1.1", "1.8-8")

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
  # svglite and ggfortify needed for View Graph dialog
  # PCICt needed to access PCICt class when importing NET cdf files
  # ggmosaic because geom_mosaic aes only work when ggmosaic is loaded
  # wakefield because many functions do not work without loading (https://github.com/trinker/wakefield/issues/11)
  packs_to_load <- c("plyr", "dplyr", "ggplot2", "ggthemes", "svglite", "ggfortify", "PCICt", "sp", "ggmosaic", "wakefield", "circular")
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
source("instat_object_R6.R")
source("data_object_R6.R")
source("labels_and_defaults.R")
source("stand_alone_functions.R")
files <- sort(dir(file.path(getwd(), 'Backend_Components/'), pattern=".R$", full.names = TRUE))
invisible(lapply(files, source, chdir = TRUE))