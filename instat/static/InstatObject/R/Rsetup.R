# Necessary packages for the Instat Object
packs_lib <- c("reshape2", "lubridate","plyr", "dplyr", "rtf", "openxlsx", "ggplot2", "extRemes", "GGally", "agridat", "DAAG", "FactoMineR", "plotrix", "candisc", "R6", "openair", "circular", "survival", "Evapotranspiration", "clifro", "devtools", "factoextra", "circlize", "CircStats", "gridExtra", "ggfortify", "rio", "readxl", "lme4", "dummies", "ggthemes", "lazyeval", "stringr", "httr", "jsonlite", "fitdistrplus", "visreg", "climdex.pcic", "mosaic", "ncdf4", "getPass", "RMySQL", "DBI", "EnvStats", "signmedian.test", "sjPlot", "sjmisc", "plotly", "svglite", "htmlTable", "rje")
# Packages including dependencies (generated from miniCRAN package)
packs <- c("reshape2", "lubridate", "plyr", "dplyr", "rtf", "openxlsx", 
  "ggplot2", "extRemes", "GGally", "agridat", "DAAG", "FactoMineR", 
  "plotrix", "candisc", "R6", "openair", "circular", "survival", 
  "Evapotranspiration", "clifro", "devtools", "factoextra", "circlize", 
  "CircStats", "gridExtra", "ggfortify", "rio", "readxl", "lme4", 
  "dummies", "ggthemes", "lazyeval", "stringr", "httr", "jsonlite", 
  "fitdistrplus", "visreg", "climdex.pcic", "mosaic", "ncdf4", 
  "getPass", "RMySQL", "DBI", "EnvStats", "signmedian.test", "sjPlot", 
  "sjmisc", "plotly", "svglite", "htmlTable", "rje", "Rcpp", "stringi", 
  "magrittr", "assertthat", "tibble", "BH", "rlang", "R.oo", "R.methodsS3", 
  "digest", "gtable", "MASS", "scales", "RColorBrewer", "dichromat", 
  "munsell", "labeling", "colorspace", "Lmoments", "distillery", 
  "car", "mgcv", "nnet", "pbkrtest", "quantreg", "nlme", "Matrix", 
  "SparseM", "MatrixModels", "lattice", "minqa", "nloptr", "RcppEigen", 
  "progress", "reshape", "prettyunits", "latticeExtra", "cluster", 
  "ellipse", "flashClust", "leaps", "scatterplot3d", "knitr", "evaluate", 
  "highr", "markdown", "yaml", "mime", "heplots", "mapproj", "hexbin", 
  "maps", "boot", "zoo", "XML", "selectr", "RCurl", "bitops", "memoise", 
  "whisker", "rstudioapi", "git2r", "withr", "curl", "openssl", 
  "abind", "dendextend", "ggpubr", "ggrepel", "tidyr", "fpc", "viridis", 
  "ggsci", "mclust", "flexmix", "prabclus", "class", "diptest", 
  "mvtnorm", "robustbase", "kernlab", "trimcluster", "viridisLite", 
  "modeltools", "DEoptimR", "GlobalOptions", "shape", "foreign", 
  "haven", "data.table", "readr", "hms", "cellranger", "rematch", 
  "PCICt", "caTools", "mosaicData", "ggdendro", "broom", "effects", 
  "merTools", "modelr", "psych", "purrr", "sjstats", "arm", "DT", 
  "shiny", "blme", "mnormt", "stringdist", "coin", "lmtest", "sandwich", 
  "coda", "multcomp", "htmltools", "htmlwidgets", "httpuv", "xtable", 
  "sourcetools", "TH.data", "codetools", "base64enc", "crosstalk", 
  "gdtools", "checkmate", "backports")
success <- invisible(sapply(packs, function(x) length(find.package(x, quiet = TRUE))>0))
if(!all(success)) install.packages(names(success)[!success], repos = paste0("file:///", getwd(), "/extras"), type = "win.binary")
#success <- suppressWarnings(sapply(packs, require, character.only = TRUE))
#if(!all(success)) install.packages(names(success)[!success], repos = paste0("file:///", getwd(), "/RPackages"), type = "win.binary")
#require will ensure packages load correctly, but not sensible to load all
#sapply(names(success)[!success], require, character.only = TRUE)
#Needed when ggfortify was not on CRAN
#if(!suppressWarnings(require(ggfortify))) install.packages(paste0(getwd(), "/RPackages", "/ggfortify_0.1.0.tar.gz"), repos = NULL, type="source")
for(pack in packs_lib) {
  library(pack, character.only = TRUE)
}

setwd(dirname(parent.frame(2)$ofile))
source("instat_object_R6.R")
source("data_object_R6.R")
source("labels_and_defaults.R")
source("stand_alone_functions.R")
files <- sort(dir(file.path(getwd(), 'Backend_Components/'),pattern=".R$", full.names = TRUE))
lapply(files, source, chdir = TRUE)