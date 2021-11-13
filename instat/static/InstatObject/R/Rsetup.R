# Packages including dependencies
# Generated from install_packages.R, do not edit manually!
packs <- c("abind", "agricolae", "agridat", 
           "AlgDesign", "animation", "arrangements", "ash", 
           "askpass", "assertthat", "automap", "backports", 
           "base64enc", "bayestestR", "BH", "bit", 
           "bit64", "bitops", "boot", "brew", "brio", 
           "broom", "bslib", "cachem", "callr", 
           "candisc", "car", "carData", "caret", 
           "cellranger", "changepoint", "checkmate", "chillR", 
           "chron", "circlize", "CircStats", "circular", 
           "class", "classInt", "cli", "clifro", 
           "climdex.pcic", "clipr", "cluster", "cmsaf", 
           "cmsafops", "cmsafvis", "codetools", "colorRamps", 
           "colorspace", "colourpicker", "combinat", "commonmark", 
           "conquer", "corrplot", "countrycode", "cowplot", 
           "cpp11", "crayon", "credentials", "crosstalk", 
           "curl", "DAAG", "dae", "data.table", 
           "datawizard", "date", "DBI", "dendextend", 
           "DEoptimR", "desc", "DescTools", "devtools", 
           "diffobj", "digest", "distillery", "dotCall64", 
           "dplyr", "DT", "dummies", "e1071", "ecmwfr", 
           "effectsize", "ellipse", "ellipsis", "emmeans", 
           "EnvStats", "estimability", "evaluate", "Evapotranspiration", 
           "Exact", "expm", "extraDistr", "extrafont", 
           "extrafontdb", "extRemes", "factoextra", "FactoMineR", 
           "fansi", "faraway", "farver", "fastmap", 
           "fields", "filelock", "fitdistrplus", "flashClust", 
           "FNN", "fontawesome", "forcats", "foreach", 
           "forecast", "foreign", "Formula", "fracdiff", 
           "fs", "future.apply", "future", "gapminder", 
           "gcookbook", "generics", "GenSA", "geosphere", 
           "gert", "getPass", "GGally", "ggalt", 
           "ggdendro", "ggeffects", "ggfittext", "ggforce", 
           "ggformula", "ggfortify", "ggmosaic", "ggplot2", 
           "ggplotify", "ggpmisc", "ggpp", "ggpubr", 
           "ggrepel", "ggridges", "ggsci", "ggsignif", 
           "ggstance", "ggtext", "ggthemes", "gh", 
           "gitcreds", "gld", "GlobalOptions", "globals", 
           "glue", "gmp", "goftest", "gower", "gridExtra", 
           "gridGraphics", "gridtext", "gstat", "gtable", 
           "haven", "heplots", "hexbin", "highr", 
           "HistData", "Hmisc", "hms", "htmlTable", 
           "htmltools", "htmlwidgets", "httpuv", "httr", 
           "hunspell", "hydroGOF", "hydroTSM", "imputeTS", 
           "ini", "insight", "intervals", "ipred", 
           "isoband", "iterators", "janeaustenr", "janitor", 
           "jpeg", "jquerylib", "jsonlite", "Kendall", 
           "KernSmooth", "keyring", "klaR", "knitr", 
           "labeling", "labelled", "Lahman", "later", 
           "lattice", "latticeExtra", "lava", "lazyeval", 
           "leaflet.providers", "leaflet", "leaps", "lemon", 
           "lifecycle", "listenv", "lme4", "lmodel2", 
           "lmom", "lmomco", "Lmoments", "lmtest", 
           "lubridate", "magick", "magrittr", "mapdata", 
           "mapproj", "maps", "maptools", "markdown", 
           "MASS", "Matrix", "MatrixModels", "matrixStats", 
           "memoise", "mgcv", "mime", "miniUI", 
           "minqa", "MKdescr", "MKinfer", "ModelMetrics", 
           "modelr", "mosaic", "mosaicCore", "mosaicData", 
           "munsell", "mvtnorm", "ncdf4.helpers", "ncdf4", 
           "nlme", "nloptr", "nnet", "nortest", 
           "numDeriv", "nycflights13", "openair", "openssl", 
           "openxlsx", "parallelly", "parameters", "patchwork", 
           "pbkrtest", "pbs", "PCICt", "performance", 
           "pillar", "pkgbuild", "pkgconfig", "pkgload", 
           "plotly", "plotrix", "pls", "plyr", "png", 
           "polyclip", "polynom", "praise", "prettyunits", 
           "pROC", "processx", "prodlim", "productplots", 
           "progress", "progressr", "proj4", "promises", 
           "proxy", "ps", "purrr", "quadprog", "quantmod", 
           "quantreg", "questionr", "R.cache", "R.methodsS3", 
           "R.oo", "R.utils", "R6", "rainfarmr", 
           "rappdirs", "raster", "rasterVis", "rcmdcheck", 
           "RColorBrewer", "Rcpp", "RcppArmadillo", "RcppEigen", 
           "RcppRoll", "RCurl", "readODS", "readr", 
           "readxl", "recipes", "rematch", "rematch2", 
           "remotes", "reshape", "reshape2", "rgdal", 
           "rio", "rje", "rlang", "RMAWGEN", "RMySQL", 
           "robustbase", "rootSolve", "roxygen2", "rpart", 
           "rpivotTable", "rprojroot", "rrefine", "rstatix", 
           "rstudioapi", "rtf", "Rttf2pt1", "rversions", 
           "rvest", "rworldmap", "rworldxtra", "s2", 
           "sandwich", "sass", "scales", "scatterplot3d", 
           "SearchTrees", "selectr", "sessioninfo", "sf", 
           "shades", "shape", "shiny", "shinyFiles", 
           "shinyjs", "shinythemes", "signmedian.test", 
           "sjlabelled", "sjmisc", "sjPlot", "sjstats", 
           "snakecase", "SnowballC", "sodium", "sourcetools", 
           "sp", "spacetime", "spam", "SparseM", 
           "SPEI", "splus2R", "SQUAREM", "stinepack", 
           "stringdist", "stringi", "stringr", "strucchange", 
           "styler", "survival", "svglite", "sys", 
           "systemfonts", "terra", "testthat", "texmex", 
           "tibble", "tidyr", "tidyselect", "tidytext", 
           "timeDate", "tokenizers", "treemapify", "trend", 
           "tseries", "TTR", "tweenr", "tzdb", "units", 
           "urca", "usethis", "utf8", "vars", "vctrs", 
           "viridis", "viridisLite", "visdat", "visreg", 
           "vroom", "wakefield", "waldo", "weathermetrics", 
           "whisker", "withr", "wk", "xfun", "XML", 
           "xml2", "xopen", "xtable", "xts", "yaml", 
           "yulab.utils", "zip", "zoo", "zyp",
           # mmtable2 package from GitHub added manually to list
           # install with devtools::install_github("ianmoran11/mmtable2")
           "mmtable2")

versions <- c("1.4-5", "1.3-5", "1.18", "1.2.0", 
              "2.7", "1.1.9", "1.0-15", "1.1", "0.2.1", 
              "1.0-14", "1.3.0", "0.1-3", "0.11.5", 
              "1.75.0-0", "4.0.4", "4.0.5", "1.0-7", 
              "1.3-28", "1.0-6", "1.1.2", "0.7.10", 
              "0.3.1", "1.0.6", "3.7.0", "0.8-6", "3.0-11", 
              "3.0-4", "6.0-90", "1.1.0", "2.2.2", 
              "2.0.0", "0.72.5", "2.3-56", "0.4.13", 
              "0.2-6", "0.4-93", "7.3-19", "0.4-3", 
              "3.1.0", "3.2-5", "1.1-11", "0.7.1", 
              "2.1.2", "3.3.0", "1.2.1", "1.1.7", "0.2-18", 
              "2.3", "2.0-2", "1.1.1", "0.0-8", "1.7", 
              "1.2.0", "0.90", "1.3.0", "1.1.1", "0.4.0", 
              "1.4.2", "1.3.1", "1.1.1", "4.3.2", "1.24", 
              "3.2-11", "1.14.2", "0.2.1", "1.2-39", 
              "1.1.1", "1.15.2", "1.0-9", "1.4.0", 
              "0.99.43", "2.4.2", "0.3.5", "0.6.28", 
              "1.2-1", "1.0-1", "1.0.7", "0.19", "1.5.6", 
              "1.7-9", "1.3.0", "0.5", "0.4.2", "0.3.2", 
              "1.7.0", "2.4.0", "1.3", "0.14", "1.15", 
              "3.0", "0.999-6", "1.9.1", "0.17", "1.0", 
              "2.1-1", "1.0.7", "2.4", "0.5.0", "1.0.7", 
              "2.1.0", "1.1.0", "13.3", "1.0.2", "1.1-6", 
              "1.01-2", "1.1.3", "0.2.2", "0.5.1", 
              "1.5.1", "8.15", "0.8-81", "1.2-4", "1.5-1", 
              "1.5.0", "1.8.1", "1.23.0", "0.3.0", 
              "2.0", "0.1.1", "1.1.7", "1.5-14", "1.4.1", 
              "0.2-2", "2.1.2", "0.4.0", "0.1.22", 
              "1.1.1", "0.9.1", "0.3.3", "0.10.1", 
              "0.4.13", "0.3.3", "3.3.5", "0.1.0", 
              "0.4.4", "0.4.2", "0.4.0", "0.9.1", "0.5.3", 
              "2.9", "0.6.3", "0.3.5", "0.1.1", "4.2.4", 
              "1.3.0", "0.1.1", "2.6.2", "0.1.2", "0.14.0", 
              "1.4.2", "0.6-2", "1.2-3", "0.2.2", "2.3", 
              "0.5-1", "0.1.4", "2.0-8", "0.3.0", "2.4.3", 
              "1.3-9", "1.28.2", "0.9", "0.8-7", "4.6-0", 
              "1.1.1", "2.3.0", "0.5.2", "1.5.4", "1.6.3", 
              "1.4.2", "3.0.1", "0.4-0", "0.6-0", "3.2", 
              "0.3.1", "0.14.5", "0.15.2", "0.9-12", 
              "0.2.5", "1.0.13", "0.1.5", "2.1.0", 
              "0.1-9", "0.1.4", "1.7.2", "2.2", "2.23-20", 
              "1.2.0", "0.6-15", "1.36", "0.4.2", "2.9.0", 
              "9.0-0", "1.3.0", "0.20-45", "0.6-29", 
              "1.6.10", "0.2.2", "1.9.0", "2.0.4.1", 
              "3.1", "0.4.5", "1.0.1", "0.8.0", "1.1-27.1", 
              "1.7-3", "2.8", "2.3.7", "1.3-1", "0.9-38", 
              "1.8.0", "2.7.3", "2.0.1", "2.3.0", "1.2.7", 
              "3.4.0", "1.1-2", "1.1", "7.3-54", "1.3-4", 
              "0.5-0", "0.61.0", "2.0.0", "1.8-38", 
              "0.12", "0.1.1.1", "1.2.4", "0.7", "0.6", 
              "1.2.2.2", "0.1.8", "1.8.3", "0.9.0", 
              "0.20.2", "0.5.0", "1.1-3", "0.3-6", 
              "1.17", "3.1-153", "1.2.2.2", "7.3-16", 
              "1.0-4", "2016.8-1.1", "1.0.2", "2.8-5", 
              "1.4.5", "4.2.4", "1.28.1", "0.15.0", 
              "1.1.1", "0.5.1", "1.1", "0.5-4.1", "0.8.0", 
              "1.6.4", "1.2.0", "2.0.3", "1.2.3", "4.10.0", 
              "3.8-2", "2.8-0", "1.8.6", "0.1-7", "1.10-0", 
              "1.4-0", "1.0.0", "1.1.1", "1.18.0", 
              "3.5.2", "2019.11.13", "0.1.1", "1.2.2", 
              "0.9.0", "1.0-10.1", "1.2.0.1", "0.4-26", 
              "1.6.0", "0.3.4", "1.5-8", "0.4.18", 
              "5.86", "0.7.5", "0.15.0", "1.8.1", "1.24.0", 
              "2.11.0", "2.5.1", "0.1", "0.3.3", "3.5-2", 
              "0.51.0", "1.4.0", "1.1-2", "1.0.7", 
              "0.10.7.0.0", "0.3.3.9.1", "0.3.0", "1.98-1.5", 
              "1.7.0", "2.0.2", "1.3.1", "0.1.17", 
              "1.0.1", "2.1.2", "2.4.1", "0.8.8", "1.4.4", 
              "1.5-27", "0.5.27", "1.10.16", "0.4.12", 
              "1.3.7", "0.10.22", "0.93-9", "1.8.2.3", 
              "7.1.2", "4.1-15", "0.3.0", "2.0.2", 
              "1.1.2", "0.7.0", "0.13", "0.4-14.1", 
              "1.3.9", "2.1.1", "1.0.2", "1.3-6", "1.01", 
              "1.0.7", "3.0-1", "0.4.0", "1.1.1", "0.3-41", 
              "0.5.2", "0.4-2", "1.2.0", "1.0-3", "1.4.0", 
              "1.4.6", "1.7.1", "0.9.0", "2.0.0", "1.2.0", 
              "1.5.1", "1.1.8", "2.8.7", "2.8.9", "0.18.1", 
              "0.11.0", "0.7.0", "1.2.0", "0.1.7", 
              "1.4-5", "1.2-5", "2.7-0", "1.81", "1.7", 
              "1.3-3", "2021.1", "1.4", "0.9.8", "1.7.5", 
              "1.4.0", "1.5-2", "1.6.2", "3.2-13", 
              "2.0.0", "3.4", "1.0.3", "1.4-11", "3.1.0", 
              "2.4.8", "3.1.5", "1.1.4", "1.1.1", "0.3.2", 
              "3043.102", "0.2.1", "2.5.5", "1.1.4", 
              "0.10-48", "0.24.2", "1.0.2", "0.2.0", 
              "0.7-2", "1.3-0", "2.1.3", "1.2.2", "1.5-6", 
              "0.3.8", "0.6.2", "0.4.0", "0.5.3", "2.7.0", 
              "1.5.5", "0.3.6", "0.3.1", "1.2.2", "0.4", 
              "2.4.2", "0.5.0", "0.27", "3.99-0.8", 
              "1.3.2", "1.0.0", "1.8-4", "0.12.1", 
              "2.2.1", "0.0.4", "2.2.0", "1.8-9", "0.10-1.1",
              # mmtable2 package from GitHub added manually to list
              "0.1.3"
              )

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
  # latticeExtra because conditionalQuantile key positions work well when latticeExtra is loaded
  # texmex loaded because of extreme value distributions 
  # tidyr loaded because unite() function is required by mmtable() function from mmtable2 package 
  # purrr loaded because map_int() is required  by function(s) such as header_top_left() from mmtable2 package
  packs_to_load <- c("purrr", "plyr", "tidyr", "dplyr", "ggplot2", "ggthemes", "svglite", "ggfortify", "PCICt", "sp", "ggmosaic", "wakefield", "circular", "latticeExtra", "texmex")
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
files <- sort(dir(file.path(getwd(), 'Backend_Components/'), pattern=".R$", full.names = TRUE, recursive = TRUE))
invisible(lapply(files, source, chdir = TRUE))
