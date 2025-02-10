Sys.setenv(TZ='GMT')
Sys.setlocale("LC_TIME", "C")

#Install packages from CRAN archive
install.packages("http://cran.r-project.org/src/contrib/Archive/signmedian.test/signmedian.test_1.5.1.tar.gz", repos=NULL, type="source")

#Install packages from win.binary
install.packages("stringi", dependencies = FALSE,  repos='https://cloud.r-project.org', type = "win.binary")
install.packages("stringr", dependencies = FALSE, repos='http://cran.us.r-project.org', type = "win.binary")
install.packages("RMySQL", dependencies = FALSE, repos='http://cran.us.r-project.org', type = "win.binary")
install.packages("terra", dependencies = FALSE, repos='http://cran.us.r-project.org', type = "win.binary")
install.packages("XML", dependencies = FALSE, repos='http://cran.us.r-project.org', type = "win.binary")

# Packages including dependencies
# Generated from install_packages.R, do not edit manually!
# Above packages taken out
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
           "crosstalk", "cubature", "curl", "DAAG", "dae", "data.table", 
           "datasauRus", "datawizard", "date", "DBI", "deldir", "dendextend", 
           "DEoptimR", "Deriv", "desc", "DescTools", "deSolve", "desplot", 
           "devtools", "diagram", "diffobj", "digest", "distillery", "distributional", 
           "doBy", "dotCall64", "downlit", "dplyr", "dslabs", "DT", "dtw", 
           "dygraphs", "e1071", "ecmwfr", "effectsize", "ellipse", "ellipsis", 
           "elliptic", "emmeans", "EnvStats", "estimability", "evaluate", 
           "Evapotranspiration", "Exact", "exactRankTests", "expm", "extraDistr", 
           "extrafont", "extrafontdb", "extRemes", "factoextra", "FactoMineR", 
           "fansi", "faraway", "farver", "fastDummies", "fastmap", "fields", 
           "filelock", "fitdistrplus", "fivethirtyeight", "flashClust", 
           "FNN", "fontawesome", "forcats", "foreach", "forecast", "foreign", 
           "formattable", "formula.tools", "Formula", "fracdiff", "fs", 
           "future.apply", "future", "gapminder", "gclus", "gcookbook", 
           "generics", "GenSA", "geomtextpath", "geosphere", "gert", "getPass", 
           "GGally", "ggalt", "ggeffects", "ggfittext", "ggformula", "ggfortify", 
           "ggmosaic", "ggplot2", "ggplotify", "ggpmisc", "ggpp", "ggpubr", 
           "ggrepel", "ggridges", "ggsci", "ggside", "ggsignif", "ggstats", 
           "ggtext", "ggthemes", "ggwordcloud", "gh", "gitcreds", "gld", 
           "glmnet", "GlobalOptions", "globals", "glue", "gmp", "gnm", "goftest", 
           "gower", "gridExtra", "gridGraphics", "gridtext", "gt", "gtable", 
           "gtExtras", "gtools", "hardhat", "haven", "heplots", "here", 
           "hexbin", "HH", "highr", "HistData", "Hmisc", "hms", "htmlTable", 
           "htmltools", "htmlwidgets", "httpuv", "httr", "httr2", "hydroGOF", 
           "hydroTSM", "hypergeo", "igraph", "imputeTS", "infer", "ini", 
           "inline", "insight", "interp", "inum", "ipred", "ISLR", "isoband", 
           "iterators", "janeaustenr", "janitor", "jomo", "jpeg", "jquerylib", 
           "jsonlite", "juicyjuice", "Kendall", "KernSmooth", "keyring", 
           "knitr", "labeling", "labelled", "Lahman", "later", "lattice", 
           "latticeExtra", "lava", "lazyeval", "leaps", "lemon", "libcoin", 
           "lifecycle", "listenv", "lme4", "lmerTest", "lmodel2", "lmom", 
           "lmomco", "Lmoments", "lmtest", "loo", "lubridate", "magrittr", 
           "mapdata", "mapproj", "maps", "markdown", "MASS", "Matrix", "MatrixModels", 
           "matrixStats", "mc2d", "memoise", "metR", "mgcv", "mice", "miceadds", 
           "microbenchmark", "mime", "miniUI", "minqa", "minty", "mitml", 
           "mitools", "MKdescr", "MKinfer", "mlbench", "modeldata", "ModelMetrics", 
           "modelr", "modeltools", "moderndive", "mosaic", "mosaicCore", 
           "mosaicData", "multcomp", "multcompView", "munsell", "mvtnorm", 
           "ncdf4.helpers", "ncdf4", "nlme", "nloptr", "nnet", "nortest", 
           "numDeriv", "nycflights13", "openair", "openssl", "openxlsx", 
           "operator.tools", "ordinal", "paletteer", "pan", "parallelly", 
           "parameters", "partykit", "patchwork", "pbapply", "pbkrtest", 
           "pbs", "PCICt", "performance", "permute", "pillar", "pingr", 
           "pkgbuild", "pkgconfig", "pkgdown", "pkgload", "plogr", "plotly", 
           "plotrix", "pls", "plyr", "png", "polynom", "posterior", "praise", 
           "prediction", "prettyunits", "primes", "prismatic", "pROC", "processx", 
           "prodlim", "productplots", "profvis", "progress", "progressr", 
           "proj4", "promises", "proxy", "ps", "purrr", "qap", "quadprog", 
           "quantmod", "quantreg", "questionr", "QuickJSR", "qvcalc", "R.cache", 
           "R.methodsS3", "R.oo", "R.utils", "R6", "ragg", "rainfarmr", 
           "rappdirs", "raster", "rasterVis", "rbibutils", "rcmdcheck", 
           "RColorBrewer", "rcorpora", "Rcpp", "RcppArmadillo", "RcppEigen", 
           "RcppParallel", "RcppRoll", "RCurl", "Rdpack", "reactable", "reactR", 
           "readODS", "readr", "readxl", "recipes", "registry", "relimp", 
           "rematch", "rematch2", "remotes", "repr", "reshape", "reshape2", 
           "rgl", "rio", "rje", "rlang", "rmarkdown", "RMAWGEN", "Rmpfr", 
           #"RMySQL",
           "robustbase", "rootSolve", "roxygen2", "rpart", "rpivotTable", 
           "rprojroot", "rrefine", "RSQLite", "rstan", "rstanarm", "rstantools", 
           "rstatix", "rstudioapi", "rtf", "Rttf2pt1", "rversions", "rvest", 
           "rworldmap", "rworldxtra", "s2", "sandwich", "sass", "scales", 
           "scatterplot3d", "SearchTrees", "segmented", "selectr", "seriation", 
           "sessioninfo", "sf", "shades", "shape", "shiny", "shinyFiles", 
           "shinyjs", "shinystan", "shinythemes", "shinyWidgets", "sjlabelled", 
           "sjmisc", "sjPlot", "sjstats", "skimr", "snakecase", "SnowballC", 
           "sodium", "sourcetools", "sp", "spam", "SparseM", "SPEI", "splines2", 
           "splus2R", "SQUAREM", "StanHeaders", "statip", "statquotes", 
           "statsr", "stinepack", "stringdist", 
           #"stringi", 
           #"stringr", 
           "strucchange", 
           "styler", "survival", "svglite", "sys", "systemfonts", "tensorA", 
           #"terra",
           "testthat", "texmex", "textshaping", "TH.data", "threejs", 
           "tibble", "tidyr", "tidyselect", "tidytext", "timechange", "timeDate", 
           "tinytex", "TLMoments", "tokenizers", "treemapify", "trend", 
           "tryCatchLog", "tseries", "TSP", "TTR", "tzdb", "ucminf", "units", 
           "urca", "urlchecker", "usethis", "utf8", "V8", "vars", "vcd", 
           "vcdExtra", "vctrs", "vegan", "verification", "viridis", "viridisLite", 
           "visdat", "visreg", "vroom", "waffle", "wakefield", "waldo", 
           "weathermetrics", "whisker", "withr", "wk", "wordcloud", "writexl", 
           "xfun", 
           #"XML", 
           "xml2", "xopen", "xtable", "xts", "yaml", "yulab.utils", 
           "zip", "zoo", "Zseq", "zyp")

install.packages(packs, dependencies = FALSE, repos='https://cloud.r-project.org', type="win.binary")

# Only use internal library
if (length(.libPaths()) >= 2){
  current_paths <- .libPaths()
  .libPaths(current_paths[c(1, 3)[c(1, 3) <= length(current_paths)]])
}

#install development packages not on CRAN
devtools::install_github("ianmoran11/mmtable2")
devtools::install_github("michael-franke/aida-package")
devtools::install_github("rijaf-iri/CDT")
devtools::install_github("IDEMSInternational/rapidpror")
devtools::install_github("IDEMSInternational/epicsawrap")
