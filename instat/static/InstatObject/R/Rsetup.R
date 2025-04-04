# Packages including dependencies
# Generated from install_packages.R, do not edit manually!
packs <- c("abind", "agricolae", "agridat", "agriTutorial", 
           "AlgDesign", "apsimx", "arm", "arrangements", "ash", "askpass", 
           "assertthat", "backports", "base64enc", "BayesFactor", "bayesplot", 
           "bayestestR", "BH", "bigD", "bit", "bit64", "bitops", "blob", 
           "boot", "brew", "brio", "broom", "bslib", "ca", "cachem", "callr", 
           "candisc", "car", "carData", "caret", "cellranger", "CGPfunctions", 
           "changepoint", "checkmate", "chillR", "chron", "circlize", "CircStats", 
           "circular", "class", "classInt", "cli", "clifro", "clipr", "clock", 
           "clue", "cluster", "cmsaf", "cmsafops", "cmsafvis", "coda", "codetools", 
           "coin", "collapse", "colorRamps", "colorspace", "colourpicker", 
           "commonmark", "conf.design", "confintr", "contfrac", "corrplot", 
           "corrr", "countrycode", "cowplot", "cpp11", "crayon", "credentials", 
           "crosstalk", "cubature", "curl", "CVXR", "DAAG", "dae", "data.table", 
           "datasauRus", "datawizard", "date", "DBI", "deldir", "dendextend", 
           "DEoptimR", "Deriv", "desc", "DescTools", "deSolve", "desplot", 
           "devtools", "diagram", "diffobj", "digest", "distillery", "distributional", 
           "doBy", "dotCall64", "downlit", "dplyr", "dslabs", "DT", "dtw", 
           "dygraphs", "e1071", "ecmwfr", "ECOSolveR", "effectsize", "ellipse", 
           "ellipsis", "elliptic", "emmeans", "EnvStats", "estimability", 
           "evaluate", "Evapotranspiration", "Exact", "exactRankTests", 
           "expm", "extraDistr", "extrafont", "extrafontdb", "extRemes", 
           "factoextra", "FactoMineR", "fansi", "faraway", "farver", "fastDummies", 
           "fastmap", "fields", "filelock", "fitdistrplus", "fivethirtyeight", 
           "flashClust", "FNN", "fontawesome", "forcats", "foreach", "forecast", 
           "foreign", "formattable", "formula.tools", "Formula", "fracdiff", 
           "fs", "future.apply", "future", "gapminder", "gclus", "gcookbook", 
           "gdata", "generics", "GenSA", "geomtextpath", "geosphere", "gert", 
           "getPass", "GGally", "ggalt", "ggeffects", "ggfittext", "ggformula", 
           "ggfortify", "ggmosaic", "ggplot2", "ggplotify", "ggpmisc", "ggpp", 
           "ggpubr", "ggrepel", "ggridges", "ggsci", "ggside", "ggsignif", 
           "ggstats", "ggtext", "ggthemes", "ggwordcloud", "gh", "gitcreds", 
           "gld", "glmnet", "GlobalOptions", "globals", "glue", "gmp", "gnm", 
           "goftest", "gower", "gridExtra", "gridGraphics", "gridtext", 
           "gt", "gtable", "gtExtras", "gtools", "hardhat", "haven", "heplots", 
           "here", "hexbin", "HH", "highr", "HistData", "Hmisc", "hms", 
           "htmlTable", "htmltools", "htmlwidgets", "httpuv", "httr", "httr2", 
           "hydroGOF", "hydroTSM", "hypergeo", "igraph", "imputeTS", "infer", 
           "ini", "inline", "insight", "interp", "inum", "ipred", "ISLR", 
           "isoband", "iterators", "janeaustenr", "janitor", "jomo", "jpeg", 
           "jquerylib", "jsonlite", "juicyjuice", "Kendall", "KernSmooth", 
           "keyring", "knitr", "labeling", "labelled", "Lahman", "later", 
           "lattice", "latticeExtra", "lava", "lazyeval", "leaps", "lemon", 
           "libcoin", "lifecycle", "listenv", "litedown", "lme4", "lmerTest", 
           "lmodel2", "lmom", "lmomco", "Lmoments", "lmtest", "loo", "lubridate", 
           "magrittr", "mapdata", "mapproj", "maps", "markdown", "MASS", 
           "Matrix", "MatrixModels", "matrixStats", "mc2d", "memoise", "metR", 
           "mgcv", "mice", "miceadds", "microbenchmark", "mime", "miniUI", 
           "minqa", "minty", "mitml", "mitools", "MKdescr", "MKinfer", "mlbench", 
           "modeldata", "ModelMetrics", "modelr", "modeltools", "moderndive", 
           "mosaic", "mosaicCore", "mosaicData", "multcomp", "multcompView", 
           "munsell", "mvtnorm", "nanonext", "ncdf4.helpers", "ncdf4", "nlme", 
           "nloptr", "nnet", "nortest", "numDeriv", "nycflights13", "openair", 
           "openssl", "openxlsx", "operator.tools", "ordinal", "osqp", "paletteer", 
           "pan", "parallelly", "parameters", "partykit", "patchwork", "pbapply", 
           "pbkrtest", "pbs", "PCICt", "performance", "permute", "pillar", 
           "pingr", "pkgbuild", "pkgconfig", "pkgdown", "pkgload", "PlackettLuce", 
           "plogr", "plotly", "plotrix", "pls", "plyr", "png", "polynom", 
           "posterior", "praise", "prediction", "prettyunits", "primes", 
           "prismatic", "pROC", "processx", "prodlim", "productplots", "profvis", 
           "progress", "progressr", "proj4", "promises", "proxy", "ps", 
           "psychotools", "psychotree", "purrr", "qap", "quadprog", "quantmod", 
           "quantreg", "questionr", "QuickJSR", "qvcalc", "R.cache", "R.methodsS3", 
           "R.oo", "R.utils", "R6", "ragg", "rainfarmr", "rappdirs", "raster", 
           "rasterVis", "rbibutils", "rcmdcheck", "RColorBrewer", "rcorpora", 
           "Rcpp", "RcppArmadillo", "RcppEigen", "RcppParallel", "RcppRoll", 
           "RCurl", "Rdpack", "reactable", "reactR", "readODS", "readr", 
           "readxl", "recipes", "reformulas", "registry", "relimp", "rematch", 
           "rematch2", "remotes", "repr", "reshape", "reshape2", "rgl", 
           "rio", "rje", "rlang", "rmarkdown", "RMAWGEN", "Rmpfr", "RMySQL", 
           "robustbase", "rootSolve", "roxygen2", "rpart", "rpivotTable", 
           "rprojroot", "rrefine", "RSpectra", "RSQLite", "rstan", "rstanarm", 
           "rstantools", "rstatix", "rstudioapi", "rtf", "Rttf2pt1", "rversions", 
           "rvest", "rworldmap", "rworldxtra", "s2", "sandwich", "sass", 
           "scales", "scatterplot3d", "scs", "SearchTrees", "segmented", 
           "selectr", "seriation", "sessioninfo", "sf", "shades", "shape", 
           "shiny", "shinyFiles", "shinyjs", "shinystan", "shinythemes", 
           "shinyWidgets", "sjlabelled", "sjmisc", "sjPlot", "sjstats", 
           "skimr", "snakecase", "SnowballC", "sodium", "sourcetools", "sp", 
           "spam", "SparseM", "sparsevctrs", "SPEI", "splines2", "splus2R", 
           "SQUAREM", "StanHeaders", "statip", "statquotes", "statsr", "stinepack", 
           "stringdist", "stringi", "stringr", "strucchange", "styler", 
           "survival", "svglite", "sys", "systemfonts", "tensorA", "terra", 
           "testthat", "texmex", "textshaping", "TH.data", "threejs", "tibble", 
           "tidyr", "tidyselect", "tidytext", "timechange", "timeDate", 
           "tinytex", "TLMoments", "tokenizers", "treemapify", "trend", 
           "tryCatchLog", "tseries", "TSP", "TTR", "tzdb", "ucminf", "units", 
           "urca", "urlchecker", "usethis", "utf8", "V8", "vars", "vcd", 
           "vcdExtra", "vctrs", "vegan", "verification", "viridis", "viridisLite", 
           "visdat", "visreg", "vroom", "waffle", "wakefield", "waldo", 
           "weathermetrics", "Weighted.Desc.Stat", "weights", "whisker", 
           "withr", "wk", "wordcloud", "writexl", "xfun", "XML", "xml2", 
           "xopen", "xtable", "xts", "yaml", "yulab.utils", "zip", "zoo", 
           "Zseq", "zyp",
           # mmtable2 package from GitHub added manually to list
           # install with devtools::install_github("ianmoran11/mmtable2")
           # aida-package package from GitHub added manually to list
           # install with remotes::install_github('michael-franke/aida-package')
           # CDT package from GitHub added manually to list
           # install with devtools::install_github("rijaf-iri/CDT")
           # instatClimatic package from GitHub added manually to list
           # install with devtools::install_github("IDEMSInternational/instatClimatic", upgrade = "always")
           # instatExtras package from GitHub added manually to list
           # install with GitHub devtools::install_github("IDEMSInternational/instatExtras", upgrade = "always")
           # databook package from GitHub added manually to list
           # install with devtools::install_github("IDEMSInternational/databook", upgrade = "always")
           # instatCalculations package from GitHub added manually to list
           # install with GitHub devtools::install_github("IDEMSInternational/instatCalculations", upgrade = "always")
           
           "mmtable2",  "aida", "CDT", "instatExtras", "instatClimatic", "databook", "instatCalculations"
           )

versions <- c("1.4-8", "1.3-7", "1.24", "0.1.5", "1.2.1.1", "2.8.235", 
              "1.14-4", "1.1.9", "1.0-15", "1.2.1", "0.2.1", "1.5.0", "0.1-3", 
              "0.9.12-4.7", "1.11.1", "0.15.2", "1.87.0-1", "0.3.1", "4.6.0", 
              "4.6.0-1", "1.0-9", "1.2.4", "1.3-31", "1.0-10", "1.1.5", "1.0.8", 
              "0.9.0", "0.71.1", "1.1.0", "3.7.6", "0.9.0", "3.1-3", "3.0-5", 
              "7.0-1", "1.1.0", "0.6.3", "2.3", "2.3.2", "0.76", "2.3-62", 
              "0.4.16", "0.2-6", "0.5-1", "7.3-23", "0.4-11", "3.6.4", "3.2-5", 
              "0.8.0", "0.7.3", "0.3-66", "2.1.8.1", "3.5.2", "1.4.0", "1.2.9", 
              "0.19-4.1", "0.2-20", "1.4-3", "2.1.0", "2.3.4", "2.1-1", "1.3.0", 
              "1.9.5", "2.0.0", "1.0.2", "1.1-12", "0.95", "0.4.4", "1.6.1", 
              "1.1.3", "0.5.2", "1.5.3", "2.0.2", "1.2.1", "2.1.1", "6.2.2", 
              "1.0-15", "1.25.6", "3.2.30", "1.17.0", "0.1.9", "1.0.2", "1.2-42", 
              "1.2.3", "2.0-4", "1.19.0", "1.1-3-1", "4.1.6", "1.4.3", "0.99.60", 
              "1.40", "1.10", "2.4.5", "1.6.5", "0.3.5", "0.6.37", "1.2-2", 
              "0.5.0", "4.6.25", "1.2", "0.4.4", "1.1.4", "0.8.0", "0.33", 
              "1.23-1", "1.1.1.6", "1.7-16", "2.0.3", "0.5.5", "1.0.0", "0.5.0", 
              "0.3.2", "1.4-0", "1.11.0", "3.0.0", "1.5.1", "1.0.3", "1.16", 
              "3.3", "0.8-35", "1.0-0", "1.10.0", "0.19", "1.0", "2.2", "1.0.7", 
              "2.11", "1.0.6", "1.0.9", "2.1.2", "1.7.5", "1.2.0", "16.3.1", 
              "1.0.3", "1.2-2", "0.6.2", "1.01-2", "1.1.4.1", "0.5.3", "1.0.0", 
              "1.5.2", "8.23.0", "0.8-90", "0.2.1", "1.7.1", "1.2-5", "1.5-3", 
              "1.6.5", "1.11.3", "1.34.0", "1.0.0", "1.3.3", "2.0.1", "3.0.1", 
              "0.1.3", "1.1.14.1", "0.1.5", "1.5-20", "2.1.5", "0.2-4", "2.2.1", 
              "0.4.0", "2.2.1", "0.10.2", "0.12.0", "0.4.17", "0.3.3", "3.5.1", 
              "0.1.2", "0.6.1", "0.5.8-1", "0.6.0", "0.9.6", "0.5.6", "3.2.0", 
              "0.3.1", "0.6.4", "0.9.0", "0.1.2", "5.1.0", "0.6.2", "1.4.1", 
              "0.1.2", "2.6.7", "4.1-8", "0.1.2", "0.16.3", "1.8.0", "0.7-5", 
              "1.1-5", "1.2-3", "1.0.2", "2.3", "0.5-1", "0.1.5", "0.11.1", 
              "0.3.6", "0.5.0", "3.9.5", "1.4.1", "2.5.4", "1.7.3", "1.0.1", 
              "1.28.5", "3.1-53", "0.11", "0.9-1", "5.2-3", "1.1.3", "2.4.3", 
              "0.5.8.1", "1.6.4", "1.6.15", "1.4.7", "1.1.2", "0.6-0.1", "0.7-0.1", 
              "1.2-14", "2.1.4", "3.3", "1.0.7", "0.3.1", "0.3.21", "1.1.0", 
              "1.1-6", "1.0-5", "0.9-15", "1.4", "0.2.7", "1.0.14", "1.0.0", 
              "2.2.1", "2.7-6", "0.1-11", "0.1.4", "2.0.0", "0.1.0", "2.2.1", 
              "2.23-26", "1.3.2", "1.50", "0.4.3", "2.14.0", "12.0-0", "1.4.1", 
              "0.22-7", "0.6-30", "1.8.1", "0.2.2", "3.2", "0.5.0", "1.0-10", 
              "1.0.4", "0.9.1", "0.6", "1.1-37", "3.1-3", "1.7-4", "3.2", "2.5.1", 
              "1.3-1", "0.9-40", "2.8.0", "1.9.4", "2.0.3", "2.3.1", "1.2.11", 
              "3.4.2.1", "2.0", "7.3-65", "1.7-3", "0.5-4", "1.5.0", "0.2.1", 
              "2.0.1", "0.18.0", "1.9-2", "3.17.0", "3.17-44", "1.5.0", "0.13", 
              "0.1.1.1", "1.2.8", "0.0.5", "0.4-5", "2.4", "0.8", "1.2", "2.1-6", 
              "1.4.0", "1.2.2.2", "0.1.11", "0.2-23", "0.7.0", "1.9.1", "0.9.4.0", 
              "0.20.4", "1.4-28", "0.1-10", "0.5.1", "1.3-3", "1.5.2", "0.3-7", 
              "1.24", "3.1-168", "2.2.1", "7.3-20", "1.0-4", "2016.8-1.1", 
              "1.0.2", "2.18-2", "2.3.2", "4.2.8", "1.6.3", "2023.12-4.1", 
              "0.6.3.3", "1.6.0", "1.9", "1.43.0", "0.24.2", "1.2-23", "1.3.0", 
              "1.7-2", "0.5.3", "1.1", "0.5-4.4", "0.13.0", "0.9-7", "1.10.1", 
              "2.0.5", "1.4.7", "2.0.3", "2.1.1", "1.4.0", "0.4.3", "0.2.0", 
              "4.10.4", "3.8-4", "2.8-5", "1.8.9", "0.1-8", "1.4-1", "1.6.1", 
              "1.0.0", "0.3.18", "1.2.0", "1.6.1", "1.1.2", "1.18.5", "3.8.6", 
              "2024.06.25", "0.1.1", "0.4.0", "1.2.3", "0.15.1", "1.0-15", 
              "1.3.2", "0.4-27", "1.9.0", "0.7-4", "0.16-1", "1.0.4", "0.1-2", 
              "1.5-8", "0.4.26", "6.1", "0.8.0", "1.7.0", "1.0.4", "0.16.0", 
              "1.8.2", "1.27.0", "2.13.0", "2.6.1", "1.3.3", "0.1", "0.3.3", 
              "3.6-32", "0.51.6", "2.3", "1.4.0", "1.1-3", "2.0.1", "1.0.14", 
              "14.4.1-1", "0.3.4.0.2", "5.1.10", "0.3.1", "1.98-1.17", "2.6.3", 
              "0.4.4", "0.6.1", "2.3.2", "2.1.5", "1.4.5", "1.2.1", "0.4.0", 
              "0.5-1", "1.0-5", "2.0.0", "2.1.2", "2.5.0", "1.1.7", "0.8.9", 
              "1.4.4", "1.3.18", "1.2.3", "1.12.1", "1.1.5", "2.29", "1.3.7", 
              "1.0-0", "0.11.1", "0.99-4-1", "1.8.2.4", "7.3.2", "4.1.24", 
              "0.3.0", "2.0.4", "2.1.0", "0.16-2", "2.3.9", "2.32.7", "2.32.1", 
              "2.4.0", "0.7.2", "0.17.1", "0.4-14.1", "1.3.12", "2.1.2", "1.0.4", 
              "1.3-8", "1.01", "1.1.7", "3.1-1", "0.4.9", "1.3.0", "0.3-44", 
              "3.2.4", "0.5.5", "2.1-4", "0.4-2", "1.5.7", "1.2.3", "1.0-20", 
              "1.4.0", "1.4.6.1", "1.10.0", "0.9.3", "2.1.0", "2.6.0", "1.2.0", 
              "0.9.0", "1.2.0", "2.8.10", "2.8.17", "0.19.0", "2.1.5", "0.11.1", 
              "0.7.1", "1.4.0", "0.1.7-1", "2.2-0", "2.11-1", "1.84-2", "0.3.2", 
              "1.8.1", "0.5.4", "1.3-5", "2021.1", "2.32.10", "0.2.3", "0.3.2", 
              "0.3.0", "1.5", "0.9.15", "1.8.7", "1.5.1", "1.5-4", "1.10.3", 
              "3.8-3", "2.1.3", "3.4.3", "1.2.1", "0.36.2.1", "1.8-42", "3.2.3", 
              "2.4.9", "1.0.0", "1.1-3", "0.3.3", "3.2.1", "1.3.1", "1.2.1", 
              "0.4.2", "0.3.0", "4041.110", "0.56", "0.7.5.3", "0.3.0", "2.5.6", 
              "1.1.6", "1.3.1", "0.10-58", "1.2-4", "0.24.4", "0.5.0", "1.2.2", 
              "0.8-7", "1.3-4", "1.0.1", "3.1.0", "1.2.4", "6.0.3", "1.6-1", 
              "1.4-13", "0.8-5", "0.6.5", "2.6-10", "1.44", "0.6.5", "0.4.2", 
              "0.6.0", "2.7.0", "1.6.5", "1.0.2", "0.3.6", "0.6.1", "1.2.2", 
              "1.0", "1.0.4", "0.4.1", "3.0.2", "0.9.4", "2.6", "1.5.2", "0.52", 
              "3.99-0.18", "1.3.8", "1.0.1", "1.8-4", "0.14.1", "2.3.10", "0.2.0", 
              "2.3.2", "1.8-13", "0.2.1", "0.11-1",
              # mmtable2 package from GitHub added manually to list
              # aida-package package from GitHub added manually to list
              # CDT package from GitHub added manually to list
              # instatClimatic package from GitHub added manually to list
              # instatExtras package from GitHub added manually to list
              # databook package from GitHub added manually to list
              # instatCalculations package from GitHub added manually to list
              
              "0.1.3", "0.4.3", "6.5", "0.2.1", "0.2.1", "0.1.4", "0.1.2"
              )

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
