# Packages including dependencies (generated from miniCRAN package)
packs <- c("abind", "acepack", "agricolae", 
           "agridat", "AlgDesign", "ash", "askpass", 
           "assertthat", "automap", "backports", "base64enc", 
           "bayestestR", "BH", "bitops", "boot", 
           "brew", "broom", "callr", "candisc", 
           "car", "carData", "caTools", "cellranger", 
           "checkmate", "chron", "circlize", "CircStats", 
           "circular", "class", "classInt", "cli", 
           "clifro", "climdex.pcic", "clipr", "clisymbols", 
           "cluster", "cmsaf", "codetools", "colorRamps", 
           "colorspace", "combinat", "commonmark", "covr", 
           "cowplot", "crayon", "crosstalk", "curl", 
           "dae", "data.table", "DBI", "dendextend", 
           "DEoptimR", "desc", "DescTools", "devtools", 
           "digest", "distillery", "dotCall64", "dplyr", 
           "DT", "dtw", "dummies", "e1071", "effectsize", 
           "ellipse", "ellipsis", "emmeans", "EnvStats", 
           "estimability", "evaluate", "Evapotranspiration", 
           "expm", "extrafont", "extrafontdb", "extRemes", 
           "factoextra", "FactoMineR", "fansi", "faraway", 
           "farver", "fastmap", "fields", "fitdistrplus", 
           "flashClust", "FNN", "forcats", "foreach", 
           "foreign", "Formula", "fs", "gapminder", 
           "gdata", "gdtools", "generics", "geosphere", 
           "getPass", "GGally", "ggalt", "ggdendro", 
           "ggeffects", "ggfittext", "ggformula", "ggfortify", 
           "ggmosaic", "ggplot2", "ggpmisc", "ggpubr", 
           "ggrepel", "ggsci", "ggsignif", "ggstance", 
           "ggthemes", "gh", "git2r", "GlobalOptions", 
           "glue", "goftest", "gplots", "gridExtra", 
           "gstat", "gtable", "gtools", "haven", 
           "heplots", "hexbin", "highr", "Hmisc", 
           "hms", "htmlTable", "htmltools", "htmlwidgets", 
           "httpuv", "httr", "hydroGOF", "hydroTSM", 
           "ini", "insight", "intervals", "iterators", 
           "JBTools", "jpeg", "jsonlite", "KernSmooth", 
           "klaR", "knitr", "labeling", "labelled", 
           "Lahman", "later", "lattice", "latticeExtra", 
           "lazyeval", "leaflet", "leaflet.providers", 
           "leaps", "lifecycle", "lme4", "lmomco", 
           "Lmoments", "lsei", "lubridate", "magrittr", 
           "mapdata", "mapproj", "maps", "maptools", 
           "markdown", "MASS", "Matrix", "MatrixModels", 
           "memoise", "mgcv", "mime", "miniUI", 
           "minqa", "modelr", "mosaic", "mosaicCore", 
           "mosaicData", "munsell", "mvtnorm", "ncdf.tools", 
           "ncdf4", "ncdf4.helpers", "nlme", "nloptr", 
           "nnet", "nortest", "npsurv", "numDeriv", 
           "nycflights13", "openair", "openssl", "openxlsx", 
           "parameters", "pbkrtest", "PCICt", "performance", 
           "pillar", "pkgbuild", "pkgconfig", "pkgload", 
           "plogr", "plotly", "plotrix", "plyr", 
           "png", "polynom", "praise", "prettyunits", 
           "processx", "productplots", "progress", "proj4", 
           "promises", "proxy", "ps", "purrr", "quantreg", 
           "questionr", "R.methodsS3", "R.oo", "R6", 
           "rainfarmr", "raster", "rcmdcheck", "RColorBrewer", 
           "Rcpp", "RcppArmadillo", "RcppEigen", "RcppRoll", 
           "RCurl", "readODS", "readr", "readxl", 
           "rematch", "remotes", "reshape", "reshape2", 
           "rex", "rio", "rje", "rlang", "rlist", 
           "RMySQL", "RNetCDF", "robustbase", "roxygen2", 
           "rpart", "rprojroot", "rrefine", "rstudioapi", 
           "rtf", "Rttf2pt1", "rversions", "rworldmap", 
           "rworldxtra", "scales", "scatterplot3d", "sessioninfo", 
           "sf", "shades", "shape", "shiny", "signmedian.test", 
           "sjlabelled", "sjmisc", "sjPlot", "sjstats", 
           "sourcetools", "sp", "spacetime", "spam", 
           "SparseM", "spatial", "SPEI", "splus2R", 
           "stringi", "stringr", "survival", "svglite", 
           "sys", "systemfonts", "testthat", "tibble", 
           "tidyr", "tidyselect", "translations", "treemapify", 
           "units", "usethis", "utf8", "vctrs", 
           "verification", "viridis", "viridisLite", "visreg", 
           "wakefield", "weathermetrics", "whisker", "withr", 
           "xfun", "XML", "xml2", "xopen", "xtable", 
           "xts", "yaml", "zip", "zoo")

versions <- c("1.4-5", "1.4.1", "1.3-2", "1.16", 
              "1.2.0", "1.0-15", "1.1", "0.2.1", "1.0-14", 
              "1.1.5", "0.1-3", "0.5.1", "1.72.0-3", 
              "1.0-6", "1.3-24", "1.0-6", "0.5.4", 
              "3.4.1", "0.8-0", "3.0-6", "3.0-3", "1.18.0", 
              "1.1.0", "1.9.4", "2.3-55", "0.4.8", 
              "0.2-6", "0.4-93", "7.3-15", "0.4-2", 
              "2.0.1", "3.2-2", "1.1-11", "0.7.0", 
              "1.2.0", "2.1.0", "2.0.1", "0.2-16", 
              "2.3", "1.4-1", "0.0-8", "1.7", "3.4.0", 
              "1.0.0", "1.3.4", "1.0.0", "4.3", "3.1-21", 
              "1.12.8", "1.1.0", "1.13.2", "1.0-8", 
              "1.2.0", "0.99.32", "2.2.1", "0.6.23", 
              "1.0-6", "1.0-0", "0.8.3", "0.12", "1.21-3", 
              "1.5.6", "1.7-3", "0.1.1", "0.4.1", "0.3.0", 
              "1.4.4", "2.3.1", "1.3", "0.14", "1.14", 
              "0.999-4", "0.17", "1.0", "2.0-11", "1.0.6", 
              "2.2", "0.4.1", "1.0.7", "2.0.3", "1.0.1", 
              "10.3", "1.0-14", "1.01-2", "1.1.3", 
              "0.4.0", "1.4.7", "0.8-75", "1.2-3", 
              "1.3.1", "0.3.0", "2.18.0", "0.2.1", 
              "0.0.2", "1.5-10", "0.2-2", "1.4.0", 
              "0.4.0", "0.1-20", "0.14.1", "0.8.1", 
              "0.9.2", "0.4.8", "0.2.0", "3.2.1", "0.3.3", 
              "0.2.4", "0.8.1", "2.9", "0.6.0", "0.3.3", 
              "4.2.0", "1.1.0", "0.26.1", "0.1.1", 
              "1.3.1", "1.2-2", "3.0.1.2", "2.3", "2.0-4", 
              "0.3.0", "3.8.1", "2.2.0", "1.3-5", "1.28.1", 
              "0.8", "4.3-0", "0.5.3", "1.13.3", "0.4.0", 
              "1.5.1", "1.5.2", "1.4.1", "0.3-10", 
              "0.5-1", "0.3.1", "0.8.1", "0.15.1", 
              "1.0.12", "0.7.2.9", "0.1-8.1", "1.6.1", 
              "2.23-16", "0.6-14", "1.27", "0.3", "2.2.2", 
              "7.0-1", "1.0.0", "0.20-38", "0.6-29", 
              "0.2.2", "2.0.3", "1.9.0", "3.1", "0.1.0", 
              "1.1-21", "2.3.2", "1.3-1", "1.2-0", 
              "1.7.4", "1.5", "2.3.0", "1.2.7", "3.3.0", 
              "0.9-9", "1.1", "7.3-51.5", "1.2-18", 
              "0.4-1", "1.1.0", "1.8-31", "0.8", "0.1.1.1", 
              "1.2.4", "0.1.5", "1.5.0", "0.6.0", "0.17.0", 
              "0.5.0", "1.0-11", "0.7.1.295", "1.17", 
              "0.3-4", "3.1-143", "1.2.1", "7.3-12", 
              "1.0-4", "0.4-0", "2016.8-1.1", "1.0.1", 
              "2.7-0", "1.4.1", "4.1.4", "0.4.1", "0.4-7", 
              "0.5-4.1", "0.4.3", "1.4.3", "1.0.6", 
              "2.0.3", "1.0.2", "0.2.0", "4.9.1", "3.7-7", 
              "1.8.5", "0.1-7", "1.4-0", "1.0.0", "1.1.1", 
              "3.4.1", "0.1.1", "1.2.2", "1.0-8.1", 
              "1.1.0", "0.4-23", "1.3.0", "0.3.3", 
              "5.54", "0.7.0", "1.7.1", "1.23.0", "2.4.1", 
              "0.1", "3.0-12", "1.3.3", "1.1-2", "1.0.3", 
              "0.9.800.4.0", "0.3.3.7.0", "0.3.0", "1.98-1.1", 
              "1.6.7", "1.3.1", "1.3.1", "1.0.1", "2.1.0", 
              "0.8.8", "1.4.3", "1.1.2", "0.5.16", 
              "1.10.13", "0.4.3", "0.4.6.1", "0.10.19", 
              "2.1-1", "0.93-5", "7.0.2", "4.1-15", 
              "1.3-2", "1.0", "0.10", "0.4-14", "1.3.8", 
              "2.0.1", "1.3-6", "1.01", "1.1.0", "0.3-41", 
              "1.1.1", "0.8-1", "1.4.0", "1.4.4", "1.4.0", 
              "1.5.1", "1.1.3", "2.8.3", "2.8.2", "0.17.8", 
              "0.1.7", "1.3-2", "1.2-3", "2.5-1", "1.78", 
              "7.3-11", "1.7", "1.2-2", "1.4.4", "1.4.0", 
              "3.1-8", "1.2.2", "3.3", "0.1.1", "2.3.1", 
              "2.1.3", "1.0.2", "0.2.5", "3.6.2", "2.5.3", 
              "0.6-5", "1.5.1", "1.1.4", "0.2.2", "1.42", 
              "0.5.1", "0.3.0", "2.6-0", "0.3.3", "1.2.2", 
              "0.4", "2.1.2", "0.12", "3.99-0.3", "1.2.2", 
              "1.0.0", "1.8-4", "0.12-0", "2.2.1", 
              "2.0.4", "1.8-7")

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