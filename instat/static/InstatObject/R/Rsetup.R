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
            "climdex.pcic", "clipr", "clue", "cluster", 
            "cmsaf", "cmsafops", "cmsafvis", "codetools", 
            "colorRamps", "colorspace", "colourpicker", 
            "combinat", "commonmark", "corrplot", "corrr", 
            "countrycode", "cowplot", "cpp11", "crayon", 
            "credentials", "crosstalk", "curl", "DAAG", 
            "dae", "data.table", "datawizard", "date", 
            "DBI", "dendextend", "DEoptimR", "desc", 
            "DescTools", "devtools", "diffobj", "digest", 
            "distillery", "dotCall64", "dplyr", "dslabs", 
            "DT", "e1071", "ecmwfr", "effectsize", 
            "ellipse", "ellipsis", "emmeans", "EnvStats", 
            "estimability", "evaluate", "Evapotranspiration", 
            "Exact", "expm", "extraDistr", "extrafont", 
            "extrafontdb", "extRemes", "factoextra", "FactoMineR", 
            "fansi", "faraway", "farver", "fastDummies", 
            "fastmap", "fields", "filelock", "fitdistrplus", 
            "flashClust", "FNN", "fontawesome", "forcats", 
            "foreach", "forecast", "foreign", "formula.tools", 
            "Formula", "fracdiff", "fs", "future.apply", 
            "future", "gapminder", "gclus", "gcookbook", 
            "generics", "GenSA", "geosphere", "gert", 
            "getPass", "GGally", "ggalt", "ggdendro", 
            "ggeffects", "ggfittext", "ggforce", "ggformula", 
            "ggfortify", "ggmosaic", "ggplot2", "ggplotify", 
            "ggpmisc", "ggpp", "ggpubr", "ggrepel", 
            "ggridges", "ggsci", "ggsignif", "ggstance", 
            "ggtext", "ggthemes", "ggwordcloud", "gh", 
            "gitcreds", "gld", "GlobalOptions", "globals", 
            "glue", "gmp", "goftest", "gower", "gridExtra", 
            "gridGraphics", "gridtext", "gstat", "gtable", 
            "hardhat", "haven", "heplots", "hexbin", 
            "highr", "HistData", "Hmisc", "hms", 
            "htmlTable", "htmltools", "htmlwidgets", "httpuv", 
            "httr", "hunspell", "hydroGOF", "hydroTSM", 
            "imputeTS", "ini", "insight", "intervals", 
            "ipred", "isoband", "iterators", "janeaustenr", 
            "janitor", "jpeg", "jquerylib", "jsonlite", 
            "Kendall", "KernSmooth", "keyring", "klaR", 
            "knitr", "labeling", "labelled", "Lahman", 
            "later", "lattice", "latticeExtra", "lava", 
            "lazyeval", "leaflet.providers", "leaflet", 
            "leaps", "lemon", "lifecycle", "listenv", 
            "lme4", "lmodel2", "lmom", "lmomco", 
            "Lmoments", "lmtest", "lubridate", "magick", 
            "magrittr", "mapdata", "mapproj", "maps", 
            "maptools", "markdown", "MASS", "Matrix", 
            "MatrixModels", "mc2d", "memoise", "metR", 
            "mgcv", "mime", "miniUI", "minqa", "MKdescr", 
            "MKinfer", "mlbench", "ModelMetrics", "modelr", 
            "mosaic", "mosaicCore", "mosaicData", "munsell", 
            "mvtnorm", "ncdf4.helpers", "ncdf4", "nlme", 
            "nloptr", "nnet", "nortest", "numDeriv", 
            "nycflights13", "openair", "openssl", "openxlsx", 
            "operator.tools", "parallelly", "parameters", 
            "patchwork", "pbkrtest", "pbs", "PCICt", 
            "performance", "pillar", "pkgbuild", "pkgconfig", 
            "pkgload", "plotly", "plotrix", "pls", 
            "plyr", "png", "polyclip", "polynom", 
            "praise", "prettyunits", "pROC", "processx", 
            "prodlim", "productplots", "progress", "progressr", 
            "proj4", "promises", "proxy", "ps", "purrr", 
            "qap", "quadprog", "quantmod", "quantreg", 
            "questionr", "R.cache", "R.methodsS3", "R.oo", 
            "R.utils", "R6", "rainfarmr", "rappdirs", 
            "raster", "rasterVis", "rbibutils", "rcmdcheck", 
            "RColorBrewer", "rcorpora", "Rcpp", "RcppArmadillo", 
            "RcppEigen", "RcppRoll", "RCurl", "Rdpack", 
            "readODS", "readr", "readxl", "recipes", 
            "registry", "rematch", "rematch2", "remotes", 
            "repr", "reshape", "reshape2", "rgdal", 
            "rio", "rje", "rlang", "RMAWGEN", "RMySQL", 
            "robustbase", "rootSolve", "roxygen2", "rpart", 
            "rpivotTable", "rprojroot", "rrefine", "rstatix", 
            "rstudioapi", "rtf", "Rttf2pt1", "rversions", 
            "rvest", "rworldmap", "rworldxtra", "s2", 
            "sandwich", "sass", "scales", "scatterplot3d", 
            "SearchTrees", "selectr", "seriation", "sessioninfo", 
            "sf", "shades", "shape", "shiny", "shinyFiles", 
            "shinyjs", "shinythemes", "shinyWidgets", "signmedian.test", 
            "sjlabelled", "sjmisc", "sjPlot", "sjstats", 
            "skimr", "snakecase", "SnowballC", "sodium", 
            "sourcetools", "sp", "spacetime", "spam", 
            "SparseM", "SPEI", "splines2", "splus2R", 
            "SQUAREM", "statip", "stinepack", "stringdist", 
            "stringi", "stringr", "strucchange", "styler", 
            "survival", "svglite", "sys", "systemfonts", 
            "terra", "testthat", "texmex", "tibble", 
            "tidyr", "tidyselect", "tidytext", "timeDate", 
            "tokenizers", "treemapify", "trend", "tseries", 
            "TSP", "TTR", "tweenr", "tzdb", "units", 
            "urca", "usethis", "utf8", "vars", "vctrs", 
            "viridis", "viridisLite", "visdat", "visreg", 
            "vroom", "wakefield", "waldo", "weathermetrics", 
            "whisker", "withr", "wk", "xfun", "XML", 
            "xml2", "xopen", "xtable", "xts", "yaml", 
            "yulab.utils", "zip", "zoo", "zyp",
           # mmtable2 package from GitHub added manually to list
           # install with devtools::install_github("ianmoran11/mmtable2")
           "mmtable2")

versions <- c("1.4-5", "1.3-5", "1.20", "1.2.1", 
            "2.7", "1.1.9", "1.0-15", "1.1", "0.2.1", 
            "1.0-16", "1.4.1", "0.1-3", "0.12.1", 
            "1.78.0-0", "4.0.4", "4.0.5", "1.0-7", 
            "1.3-28", "1.0-7", "1.1.3", "0.8.0", 
            "0.3.1", "1.0.6", "3.7.0", "0.8-6", "3.0-13", 
            "3.0-5", "6.0-92", "1.1.0", "2.2.3", 
            "2.1.0", "0.72.7", "2.3-57", "0.4.15", 
            "0.2-6", "0.4-95", "7.3-20", "0.4-7", 
            "3.3.0", "3.2-5", "1.1-11", "0.8.0", 
            "0.3-61", "2.1.3", "3.4.2", "1.2.4", 
            "1.1.11", "0.2-18", "2.3.1", "2.0-3", 
            "1.1.1", "0.0-8", "1.8.0", "0.92", "0.4.3", 
            "1.4.0", "1.1.1", "0.4.2", "1.5.1", "1.3.2", 
            "1.2.0", "4.3.2", "1.25.3", "3.2-13", 
            "1.14.2", "0.4.1", "1.2-39", "1.1.2", 
            "1.15.2", "1.0-11", "1.4.1", "0.99.45", 
            "2.4.3", "0.3.5", "0.6.29", "1.2-1", 
            "1.0-1", "1.0.9", "0.7.4", "0.23", "1.7-11", 
            "1.3.0", "0.7.0", "0.4.3", "0.3.2", "1.7.4-1", 
            "2.7.0", "1.3", "0.15", "1.16", "3.1", 
            "0.999-6", "1.9.1", "0.18", "1.0", "2.1-2", 
            "1.0.7", "2.4", "1.0.3", "1.0.7", "2.1.0", 
            "1.6.3", "1.1.0", "13.3", "1.0.2", "1.1-8", 
            "1.01-2", "1.1.3.1", "0.2.2", "0.5.1", 
            "1.5.2", "8.16", "0.8-82", "1.7.1", "1.2-4", 
            "1.5-1", "1.5.2", "1.9.0", "1.26.1", 
            "0.3.0", "1.3.2", "2.0", "0.1.2", "1.1.7", 
            "1.5-14", "1.6.0", "0.2-2", "2.1.2", 
            "0.4.0", "0.1.23", "1.1.2", "0.9.1", 
            "0.3.3", "0.10.1", "0.4.14", "0.3.3", 
            "3.3.6", "0.1.0", "0.4.6", "0.4.4", "0.4.0", 
            "0.9.1", "0.5.3", "2.9", "0.6.3", "0.3.5", 
            "0.1.1", "4.2.4", "0.5.0", "1.3.0", "0.1.1", 
            "2.6.4", "0.1.2", "0.15.0", "1.6.2", 
            "0.6-5", "1.2-3", "1.0.0", "2.3", "0.5-1", 
            "0.1.4", "2.0-9", "0.3.0", "1.1.0", "2.5.0", 
            "1.3-9", "1.28.2", "0.9", "0.8-7", "4.7-0", 
            "1.1.1", "2.4.0", "0.5.2", "1.5.4", "1.6.5", 
            "1.4.3", "3.0.1", "0.4-0", "0.6-0", "3.2", 
            "0.3.1", "0.17.1", "0.15.2", "0.9-13", 
            "0.2.5", "1.0.14", "0.1.5", "2.1.0", 
            "0.1-9", "0.1.4", "1.8.0", "2.2.1", "2.23-20", 
            "1.3.0", "1.7-0", "1.39", "0.4.2", "2.9.1", 
            "10.0-1", "1.3.0", "0.20-45", "0.6-29", 
            "1.6.10", "0.2.2", "1.9.0", "2.1.1", 
            "3.1", "0.4.5", "1.0.1", "0.8.0", "1.1-29", 
            "1.7-3", "2.9", "2.3.7", "1.3-1", "0.9-40", 
            "1.8.0", "2.7.3", "2.0.3", "2.3.0", "1.2.8", 
            "3.4.0", "1.1-4", "1.1", "7.3-57", "1.4-1", 
            "0.5-0", "0.1-21", "2.0.1", "0.12.0", 
            "1.8-40", "0.12", "0.1.1.1", "1.2.4", 
            "0.7", "0.6", "2.1-3", "1.2.2.2", "0.1.8", 
            "1.8.3", "0.9.0", "0.20.2", "0.5.0", 
            "1.1-3", "0.3-6", "1.19", "3.1-157", 
            "2.0.3", "7.3-17", "1.0-4", "2016.8-1.1", 
            "1.0.2", "2.9-1", "2.0.2", "4.2.5", "1.6.3", 
            "1.32.0", "0.18.1", "1.1.1", "0.5.1", 
            "1.1", "0.5-4.1", "0.9.0", "1.7.0", "1.3.1", 
            "2.0.3", "1.2.4", "4.10.0", "3.8-2", 
            "2.8-0", "1.8.7", "0.1-7", "1.10-0", 
            "1.4-1", "1.0.0", "1.1.1", "1.18.0", 
            "3.6.0", "2019.11.13", "0.1.1", "1.2.2", 
            "0.10.1", "1.0-11", "1.2.0.1", "0.4-27", 
            "1.7.0", "0.3.4", "0.1-1", "1.5-8", "0.4.20", 
            "5.93", "0.7.7", "0.15.0", "1.8.1", "1.25.0", 
            "2.11.0", "2.5.1", "0.1", "0.3.3", "3.5-15", 
            "0.51.2", "2.2.8", "1.4.0", "1.1-3", 
            "2.0.0", "1.0.8.3", "0.11.1.1.0", "0.3.3.9.2", 
            "0.3.0", "1.98-1.7", "2.3.1", "1.7.0", 
            "2.1.2", "1.4.0", "0.2.0", "0.5-1", "1.0.1", 
            "2.1.2", "2.4.2", "1.1.4", "0.8.9", "1.4.4", 
            "1.5-32", "0.5.29", "1.11.0", "1.0.2", 
            "1.3.7", "0.10.23", "0.95-0", "1.8.2.3", 
            "7.2.0", "4.1.16", "0.3.0", "2.0.3", 
            "2.0.0", "0.7.0", "0.13", "0.4-14.1", 
            "1.3.10", "2.1.1", "1.0.2", "1.3-6", 
            "1.01", "1.0.7", "3.0-1", "0.4.1", "1.2.0", 
            "0.3-41", "0.5.3", "0.4-2", "1.3.5", 
            "1.2.2", "1.0-7", "1.4.0", "1.4.6", "1.7.1", 
            "0.9.2", "2.1.0", "1.2.0", "0.7.0", "1.5.1", 
            "1.2.0", "2.8.9", "2.8.10", "0.18.1", 
            "2.1.4", "0.11.0", "0.7.0", "1.2.1", 
            "0.1.7", "1.5-0", "1.2-7", "2.8-0", "1.81", 
            "1.7", "0.4.5", "1.3-3", "2021.1", "0.2.3", 
            "1.4", "0.9.8", "1.7.6", "1.4.0", "1.5-2", 
            "1.7.0", "3.3-1", "2.1.0", "3.4", "1.0.4", 
            "1.5-34", "3.1.4", "2.4.8", "3.1.7", 
            "1.2.0", "1.1.2", "0.3.3", "3043.102", 
            "0.2.1", "2.5.5", "1.1.4", "0.10-51", 
            "1.2-0", "0.24.3", "1.0.2", "0.3.0", 
            "0.8-0", "1.3-0", "2.1.6", "1.2.2", "1.5-6", 
            "0.4.1", "0.6.2", "0.4.0", "0.5.3", "2.7.0", 
            "1.5.7", "0.3.6", "0.4.0", "1.2.2", "0.4", 
            "2.5.0", "0.6.0", "0.31", "3.99-0.10", 
            "1.3.3", "1.0.0", "1.8-4", "0.12.1", 
            "2.3.5", "0.0.4", "2.2.0", "1.8-10", 
            "0.10-1.1",
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
  # PCICt needed to access PCICt class when importing NETcdf files
  # ggmosaic because geom_mosaic aes only work when ggmosaic is loaded
  # wakefield because many functions do not work without loading (https://github.com/trinker/wakefield/issues/11)
  # latticeExtra because conditionalQuantile key positions work well when latticeExtra is loaded
  # texmex loaded because of extreme value distributions
  # tidyr loaded because unite() function is required by mmtable() function from mmtable2 package
  # purrr loaded because map_int() is required  by function(s) such as header_top_left() from mmtable2 package
  # mc2d loaded because of triangular and continuous empirical distributions
  packs_to_load <- c("purrr", "plyr", "tidyr", "dplyr", "ggplot2", "ggthemes", "svglite", "ggfortify", "PCICt", "sp", "ggmosaic", "wakefield", "circular", "latticeExtra", "texmex", "mc2d")
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
