# Packages including dependencies
# Generated from install_packages.R, do not edit manually!
packs <- c("abind", "agricolae", "agridat", 
           "agriTutorial", "AlgDesign", "animation", "anytime", 
           "apsimx", "arm", "arrangements", "ash", 
           "askpass", "assertthat", "automap", "backports", 
           "base64enc", "BayesFactor", "bayesplot", "bayestestR", 
           "BH", "bigD", "bit", "bit64", "bitops", 
           "blob", "boot", "brew", "brio", "broom", 
           "bslib", "ca", "cachem", "callr", "candisc", 
           "car", "carData", "caret", "cellranger", 
           "changepoint", "checkmate", "chillR", "chron", 
           "circlize", "CircStats", "circular", "class", 
           "classInt", "cli", "clifro", "climdex.pcic", 
           "clipr", "clock", "clue", "cluster", 
           "cmsaf", "cmsafops", "cmsafvis", "coda", 
           "codetools", "coin", "collapse", "colorRamps", 
           "colorspace", "colourpicker", "combinat", "commonmark", 
           "conf.design", "confintr", "contfrac", "corrplot", 
           "corrr", "countrycode", "cowplot", "cpp11", 
           "crayon", "credentials", "crosstalk", "cubature", 
           "curl", "DAAG", "dae", "data.table", 
           "datawizard", "date", "DBI", "deldir", 
           "dendextend", "DEoptimR", "desc", "DescTools", 
           "deSolve", "desplot", "devtools", "diagram", 
           "diffobj", "digest", "distillery", "distributional", 
           "dotCall64", "downlit", "dplyr", "dslabs", 
           "DT", "dtw", "dygraphs", "e1071", "ecmwfr", 
           "effectsize", "ellipse", "ellipsis", "elliptic", 
           "emmeans", "EnvStats", "estimability", "evaluate", 
           "Evapotranspiration", "Exact", "exactRankTests", 
           "expm", "extraDistr", "extrafont", "extrafontdb", 
           "extRemes", "factoextra", "FactoMineR", "fansi", 
           "faraway", "farver", "fastDummies", "fastmap", 
           "fields", "filelock", "fitdistrplus", "flashClust", 
           "FNN", "fontawesome", "forcats", "foreach", 
           "forecast", "foreign", "formattable", "formula.tools", 
           "Formula", "fracdiff", "fs", "future.apply", 
           "future", "gapminder", "gclus", "gcookbook", 
           "generics", "GenSA", "geomtextpath", "geosphere", 
           "gert", "getPass", "GGally", "ggalt", 
           "ggeffects", "ggfittext", "ggforce", "ggformula", 
           "ggfortify", "ggmosaic", "ggplot2", "ggplotify", 
           "ggpmisc", "ggpp", "ggpubr", "ggrepel", 
           "ggridges", "ggsci", "ggsignif", "ggstance", 
           "ggtext", "ggthemes", "ggwordcloud", "gh", 
           "gitcreds", "gld", "GlobalOptions", "globals", 
           "glue", "gmp", "gnm", "goftest", "gower", 
           "gridExtra", "gridGraphics", "gridtext", "gstat", 
           "gt", "gtable", "gtExtras", "gtools", 
           "hardhat", "haven", "heplots", "here", 
           "hexbin", "highr", "HistData", "Hmisc", 
           "hms", "htmlTable", "htmltools", "htmlwidgets", 
           "httpuv", "httr", "httr2", "hydroGOF", 
           "hydroTSM", "hypergeo", "igraph", "imputeTS", 
           "ini", "inline", "insight", "interp", 
           "intervals", "ipred", "isoband", "iterators", 
           "janeaustenr", "janitor", "jpeg", "jquerylib", 
           "jsonlite", "juicyjuice", "Kendall", "KernSmooth", 
           "keyring", "klaR", "knitr", "labeling", 
           "labelled", "Lahman", "later", "lattice", 
           "latticeExtra", "lava", "lazyeval", "leaps", 
           "lemon", "libcoin", "lifecycle", "listenv", 
           "lme4", "lmerTest", "lmodel2", "lmom", 
           "lmomco", "Lmoments", "lmtest", "loo", 
           "lubridate", "lwgeom", "magick", "magrittr", 
           "mapdata", "mapproj", "maps", "maptools", 
           "markdown", "MASS", "Matrix", "MatrixModels", 
           "matrixStats", "mc2d", "memoise", "metR", 
           "mgcv", "mice", "miceadds", "mime", "miniUI", 
           "minqa", "mitools", "MKdescr", "MKinfer", 
           "mlbench", "ModelMetrics", "modelr", "modeltools", 
           "mosaic", "mosaicCore", "mosaicData", "multcomp", 
           "multcompView", "munsell", "mvtnorm", "ncdf4.helpers", 
           "ncdf4", "nlme", "nloptr", "nnet", "nortest", 
           "numDeriv", "nycflights13", "openair", "openssl", 
           "openxlsx", "operator.tools", "paletteer", 
           "parallelly", "parameters", "patchwork", "pbapply", 
           "pbkrtest", "pbs", "PCICt", "performance", 
           "pillar", "pingr", "pkgbuild", "pkgconfig", 
           "pkgdown", "pkgload", "plogr", "plotly", 
           "plotrix", "pls", "plyr", "png", "polyclip", 
           "polynom", "posterior", "praise", "prediction", 
           "prettyunits", "primes", "prismatic", "pROC", 
           "processx", "prodlim", "productplots", "profvis", 
           "progress", "progressr", "proj4", "promises", 
           "proxy", "ps", "purrr", "qap", "quadprog", 
           "quantmod", "quantreg", "questionr", "qvcalc", 
           "R.cache", "R.methodsS3", "R.oo", "R.utils", 
           "R6", "ragg", "rainfarmr", "rappdirs", 
           "raster", "rasterVis", "rbibutils", "rcmdcheck", 
           "RColorBrewer", "rcorpora", "Rcpp", "RcppArmadillo", 
           "RcppEigen", "RcppParallel", "RcppRoll", "RCurl", 
           "Rdpack", "readODS", "readr", "readxl", 
           "recipes", "registry", "relimp", "rematch", 
           "rematch2", "remotes", "repr", "reshape", 
           "reshape2", "rio", "rje", "rlang", "rmarkdown", 
           "RMAWGEN", "RMySQL", "robustbase", "rootSolve", 
           "roxygen2", "rpart", "rpivotTable", "rprojroot", 
           "rrefine", "RSQLite", "rstan", "rstanarm", 
           "rstantools", "rstatix", "rstudioapi", "rtf", 
           "Rttf2pt1", "rversions", "rvest", "rworldmap", 
           "rworldxtra", "s2", "sandwich", "sass", 
           "scales", "scatterplot3d", "SearchTrees", "segmented", 
           "selectr", "seriation", "sessioninfo", "sf", 
           "sftime", "shades", "shape", "shiny", 
           "shinyFiles", "shinyjs", "shinystan", "shinythemes", 
           "shinyWidgets", "sjlabelled", "sjmisc", "sjPlot", 
           "sjstats", "skimr", "snakecase", "SnowballC", 
           "sodium", "sourcetools", "sp", "spacetime", 
           "spam", "SparseM", "SPEI", "splines2", 
           "splus2R", "SQUAREM", "StanHeaders", "stars", 
           "statip", "statquotes", "statsr", "stinepack", 
           "stringdist", "stringi", "stringr", "strucchange", 
           "styler", "survival", "svglite", "sys", 
           "systemfonts", "tensorA", "terra", "testthat", 
           "texmex", "textshaping", "TH.data", "threejs", 
           "tibble", "tidyr", "tidyselect", "tidytext", 
           "timechange", "timeDate", "tinytex", "TLMoments", 
           "tokenizers", "treemapify", "trend", "tseries", 
           "TSP", "TTR", "tweenr", "tzdb", "units", 
           "urca", "urlchecker", "usethis", "utf8", 
           "uuid", "V8", "vars", "vcd", "vcdExtra", 
           "vctrs", "verification", "viridis", "viridisLite", 
           "visdat", "visreg", "vroom", "wakefield", 
           "waldo", "weathermetrics", "whisker", "withr", 
           "wk", "wordcloud", "xfun", "XML", "xml2", 
           "xopen", "xtable", "xts", "yaml", "yulab.utils", 
           "zip", "zoo", "Zseq", "zyp",
           # mmtable2 package from GitHub added manually to list
           # install with devtools::install_github("ianmoran11/mmtable2")
           # aida-package package from GitHub added manually to list
            # install with remotes::install_github('michael-franke/aida-package')
            # CDT package from GitHub added manually to list
            # install with devtools::install_github("rijaf-iri/CDT")
           "mmtable2",  "aida", "CDT"
           )

versions <- c("1.4-5", "1.3-5", "1.21", "0.1.5", 
              "1.2.1", "2.7", "0.3.9", "2.3.1", "1.13-1", 
              "1.1.9", "1.0-15", "1.1", "0.2.1", "1.1-9", 
              "1.4.1", "0.1-3", "0.9.12-4.4", "1.10.0", 
              "0.13.1", "1.81.0-1", "0.2.0", "4.0.5", 
              "4.0.5", "1.0-7", "1.2.4", "1.3-28.1", 
              "1.0-8", "1.1.3", "1.0.4", "0.4.2", "0.71.1", 
              "1.0.7", "3.7.3", "0.8-6", "3.1-2", "3.0-5", 
              "6.0-94", "1.1.0", "2.2.4", "2.1.0", 
              "0.72.8", "2.3-60", "0.4.15", "0.2-6", 
              "0.4-95", "7.3-21", "0.4-9", "3.6.1", 
              "3.2-5", "1.1-11", "0.8.0", "0.6.1", 
              "0.3-64", "2.1.4", "3.4.4", "1.2.6", 
              "1.1.12", "0.19-4", "0.2-19", "1.4-2", 
              "1.9.5", "2.3.1", "2.1-0", "1.2.0", "0.0-8", 
              "1.9.0", "2.0.0", "1.0.0", "1.1-12", 
              "0.92", "0.4.4", "1.4.0", "1.1.1", "0.4.3", 
              "1.5.2", "1.3.2", "1.2.0", "2.0.4.6", 
              "5.0.0", "1.25.4", "3.2.15", "1.14.8", 
              "0.7.1", "1.2-42", "1.1.3", "1.0-6", 
              "1.17.1", "1.0-12", "1.4.2", "0.99.48", 
              "1.35", "1.10", "2.4.5", "1.6.5", "0.3.5", 
              "0.6.31", "1.2-1", "0.3.2", "1.0-2", 
              "0.4.2", "1.1.2", "0.7.4", "0.27", "1.23-1", 
              "1.1.1.6", "1.7-13", "1.5.0", "0.8.2", 
              "0.4.5", "0.3.2", "1.4-0", "1.8.5", "2.7.0", 
              "1.4.1", "0.20", "1.16", "3.2", "0.8-35", 
              "0.999-7", "1.9.1", "0.19", "1.0", "2.1-3", 
              "1.0.7", "2.8", "1.0.4", "1.0.8", "2.1.1", 
              "1.6.3", "1.1.1", "14.1", "1.0.2", "1.1-8", 
              "1.01-2", "1.1.3.2", "0.5.1", "1.0.0", 
              "1.5.2", "8.21", "0.8-84", "0.2.1", "1.7.1", 
              "1.2-5", "1.5-2", "1.5.2", "1.10.0", 
              "1.32.0", "1.0.0", "1.3.2", "2.0", "0.1.3", 
              "1.1.8", "0.1.1", "1.5-18", "1.9.2", 
              "0.2-2", "2.1.2", "0.4.0", "1.2.1", "0.10.0", 
              "0.4.1", "0.10.4", "0.4.16", "0.3.3", 
              "3.4.2", "0.1.0", "0.5.2", "0.5.2", "0.6.0", 
              "0.9.3", "0.5.4", "3.0.0", "0.6.4", "0.3.6", 
              "0.1.2", "4.2.4", "0.5.0", "1.4.0", "0.1.2", 
              "2.6.6", "0.1.2", "0.16.2", "1.6.2", 
              "0.7-1", "1.1-2", "1.2-3", "1.0.1", "2.3", 
              "0.5-1", "0.1.5", "2.1-1", "0.8.0", "0.3.3", 
              "0.4.5", "3.9.4", "1.3.0", "2.5.2", "1.4-2", 
              "1.0.1", "1.28.3", "0.10", "0.8-7", "5.0-1", 
              "1.1.3", "2.4.1", "0.5.5", "1.6.2", "1.6.9", 
              "1.4.5", "0.2.2", "0.4-0", "0.6-0", "1.2-13", 
              "1.4.2", "3.3", "0.3.1", "0.3.19", "0.19.1", 
              "1.1-4", "0.15.3", "0.9-14", "0.2.7", 
              "1.0.14", "1.0.0", "2.2.0", "0.1-10", 
              "0.1.4", "1.8.4", "0.1.0", "2.2.1", "2.23-20", 
              "1.3.1", "1.7-2", "1.42", "0.4.2", "2.11.0", 
              "10.0-1", "1.3.0", "0.21-8", "0.6-30", 
              "1.7.2.1", "0.2.2", "3.1", "0.4.6", "1.0-9", 
              "1.0.3", "0.9.0", "1.1-32", "3.1-3", 
              "1.7-3", "2.9", "2.4.7", "1.3-1", "0.9-40", 
              "2.6.0", "1.9.2", "0.2-11", "2.7.4", 
              "2.0.3", "2.3.1", "1.2.11", "3.4.1", 
              "1.1-6", "1.6", "7.3-58.3", "1.5-4", 
              "0.5-1", "0.63.0", "0.1-22", "2.0.1", 
              "0.14.0", "1.8-42", "3.15.0", "3.16-18", 
              "0.12", "0.1.1.1", "1.2.5", "2.4", "0.8", 
              "1.1", "2.1-3", "1.2.2.2", "0.1.11", 
              "0.2-23", "1.8.4.2", "0.9.2.1", "0.20.3", 
              "1.4-23", "0.1-9", "0.5.0", "1.1-3", 
              "0.3-6", "1.21", "3.1-162", "2.0.3", 
              "7.3-18", "1.0-4", "2016.8-1.1", "1.0.2", 
              "2.16-0", "2.0.6", "4.2.5.2", "1.6.3", 
              "1.5.0", "1.35.0", "0.21.0", "1.1.2", 
              "1.7-0", "0.5.2", "1.1", "0.5-4.4", "0.10.3", 
              "1.9.0", "2.0.2", "1.4.0", "2.0.3", "2.0.7", 
              "1.3.2", "0.2.0", "4.10.1", "3.8-2", 
              "2.8-1", "1.8.8", "0.1-8", "1.10-4", 
              "1.4-1", "1.4.1", "1.0.0", "0.3.14", 
              "1.1.1", "1.4.0", "1.1.1", "1.18.0", 
              "3.8.1", "2023.03.31", "0.1.1", "0.3.7", 
              "1.2.2", "0.13.0", "1.0-12", "1.2.0.1", 
              "0.4-27", "1.7.5", "1.0.1", "0.1-2", 
              "1.5-8", "0.4.22", "5.95", "0.7.8", "1.0.2", 
              "0.16.0", "1.8.2", "1.25.0", "2.12.2", 
              "2.5.1", "1.2.5", "0.1", "0.3.3", "3.6-20", 
              "0.51.5", "2.2.13", "1.4.0", "1.1-3", 
              "2.0.0", "1.0.10", "0.12.2.0.0", "0.3.3.9.3", 
              "5.1.7", "0.3.0", "1.98-1.12", "2.4", 
              "1.7.0", "2.1.4", "1.4.2", "1.0.5", "0.5-1", 
              "1.0-5", "1.0.1", "2.1.2", "2.4.2", "1.1.6", 
              "0.8.9", "1.4.4", "0.5.29", "1.12.1", 
              "1.1.0", "2.21", "1.3.7", "0.10.25", 
              "0.95-1", "1.8.2.3", "7.2.3", "4.1.19", 
              "0.3.0", "2.0.3", "2.1.0", "2.3.1", "2.21.7", 
              "2.21.4", "2.3.1", "0.7.2", "0.14", "0.4-14.1", 
              "1.3.12", "2.1.2", "1.0.3", "1.3-6", 
              "1.01", "1.1.2", "3.0-2", "0.4.5", "1.2.1", 
              "0.3-43", "0.5.5", "1.6-4", "0.4-2", 
              "1.4.2", "1.2.2", "1.0-12", "0.2-0", 
              "1.4.0", "1.4.6", "1.7.4", "0.9.3", "2.1.0", 
              "2.6.0", "1.2.0", "0.7.6", "1.2.0", "2.8.9", 
              "2.8.14", "0.18.2", "2.1.5", "0.11.0", 
              "0.7.0", "1.2.1", "0.1.7-1", "1.6-0", 
              "1.3-0", "2.9-1", "1.81", "1.8.1", "0.4.8", 
              "1.3-3", "2021.1", "2.21.0-7", "0.6-1", 
              "0.2.3", "0.3.1", "0.3.0", "1.4", "0.9.10", 
              "1.7.12", "1.5.0", "1.5-3", "1.9.1", 
              "3.5-5", "2.1.1", "3.4.1", "1.0.4", "0.36.2", 
              "1.7-23", "3.1.7", "2.4.8", "0.3.6", 
              "1.1-2", "0.3.3", "3.2.1", "1.3.0", "1.2.0", 
              "0.4.1", "0.2.0", "4022.108", "0.45", 
              "0.7.5.3", "0.3.0", "2.5.5", "1.1.5", 
              "0.10-53", "1.2-4", "0.24.3", "2.0.2", 
              "0.3.0", "0.8-1", "1.3-3", "1.0.1", "2.1.6", 
              "1.2.3", "1.1-0", "4.3.0", "1.5-9", "1.4-11", 
              "0.8-4", "0.6.1", "1.42", "0.6.2", "0.4.1", 
              "0.6.0", "2.7.0", "1.6.1", "0.3.6", "0.4.0", 
              "1.2.2", "0.4.1", "2.5.0", "0.7.2", "2.6", 
              "0.39", "3.99-0.14", "1.3.3", "1.0.0", 
              "1.8-4", "0.13.1", "2.3.7", "0.0.6", 
              "2.3.0", "1.8-12", "0.2.1", "0.11-1",
              # mmtable2 package from GitHub added manually to list
              # aida-package package from GitHub added manually to list
              # CDT package from GitHub added manually to list
              "0.1.3","0.4.3","6.5" 
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
