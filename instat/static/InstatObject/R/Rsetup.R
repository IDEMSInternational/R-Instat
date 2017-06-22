# Necessary packages for the Instat Object
packs_lib <- c("reshape2", "lubridate","plyr", "dplyr", "rtf", "openxlsx", "ggplot2", "extRemes", "GGally", "agridat", "DAAG", "FactoMineR", "plotrix", "candisc", "R6", "openair", "circular", "survival", "Evapotranspiration", "clifro", "devtools", "factoextra", "circlize", "CircStats", "gridExtra", "ggfortify", "rio", "readxl", "lme4", "dummies", "ggthemes", "lazyeval", "stringr", "httr", "jsonlite", "fitdistrplus", "visreg", "climdex.pcic", "mosaic", "ncdf4", "getPass", "RMySQL", "DBI", "EnvStats", "signmedian.test", "sjPlot", "sjmisc", "plotly", "svglite", "htmlTable", "rje", "tidyr")
# Packages including dependencies (generated from miniCRAN package)
packs <- c("abind", "agridat", "arm", "assertthat", "backports", 
           "base64enc", "BH", "bindr", "bindrcpp", "bitops", "blme", "boot", 
           "broom", "candisc", "car", "caTools", "cellranger", "checkmate", 
           "chron", "circlize", "CircStats", "circular", "class", "clifro", 
           "climdex.pcic", "cluster", "coda", "codetools", "coin", "colorspace", 
           "cowplot", "crosstalk", "curl", "DAAG", "data.table", "DBI", 
           "dendextend", "DEoptimR", "devtools", "dichromat", "digest", 
           "diptest", "distillery", "dplyr", "DT", "dummies", "effects", 
           "ellipse", "EnvStats", "evaluate", "Evapotranspiration", "extRemes", 
           "factoextra", "FactoMineR", "faraway", "fitdistrplus", "flashClust", 
           "flexmix", "foreach", "foreign", "fpc", "gdata", "gdtools", "getPass", 
           "GGally", "ggdendro", "ggfortify", "ggplot2", "ggpubr", "ggrepel", 
           "ggsci", "ggsignif", "ggthemes", "git2r", "GlobalOptions", "glue", 
           "gplots", "gridExtra", "gtable", "gtools", "haven", "heplots", 
           "hexbin", "highr", "hms", "htmlTable", "htmltools", "htmlwidgets", 
           "httpuv", "httr", "iterators", "JBTools", "jsonlite", "kernlab", 
           "KernSmooth", "knitr", "labeling", "lattice", "latticeExtra", 
           "lazyeval", "leaps", "lme4", "Lmoments", "lmtest", "lubridate", 
           "magrittr", "mapproj", "maps", "markdown", "MASS", "Matrix", 
           "MatrixModels", "mclust", "memoise", "merTools", "mgcv", "mime", 
           "minqa", "mnormt", "modelr", "modeltools", "mosaic", "mosaicData", 
           "multcomp", "munsell", "mvtnorm", "ncdf.tools", "ncdf4", "nlme", 
           "nloptr", "nnet", "openair", "openssl", "openxlsx", "pbkrtest", 
           "PCICt", "pkgconfig", "plogr", "plotly", "plotrix", "plyr", "prabclus", 
           "prettyunits", "progress", "psych", "purrr", "quantreg", "R.methodsS3", 
           "R.oo", "R6", "raster", "RColorBrewer", "Rcpp", "RcppEigen", 
           "RCurl", "readr", "readxl", "rematch", "reshape", "reshape2", 
           "rio", "rje", "rlang", "rlist", "RMySQL", "RNetCDF", "robustbase", 
           "rrefine", "rstudioapi", "rtf", "sandwich", "scales", "scatterplot3d", 
           "selectr", "shape", "shiny", "signmedian.test", "sjlabelled", 
           "sjmisc", "sjPlot", "sjstats", "sourcetools", "sp", "SparseM", 
           "stringdist", "stringi", "stringr", "survival", "svglite", "TH.data", 
           "tibble", "tidyr", "trimcluster", "viridis", "viridisLite", "visreg", 
           "whisker", "withr", "XML", "xtable", "yaml", "zoo")

versions <- c("1.4-5", "1.12", "1.9-3", "0.2.0", "1.1.0", "0.1-3", 
              "1.62.0-1", "0.1", "0.1", "1.0-6", "1.0-4", "1.3-19", "0.4.2", 
              "0.7-2", "2.1-4", "1.17.1", "1.1.0", "1.8.2", "2.3-50", "0.4.0", 
              "0.2-4", "0.4-7", "7.3-14", "3.1-4", "1.1-6", "2.0.6", "0.19-1", 
              "0.2-15", "1.1-3", "1.3-2", "0.7.0", "1.0.0", "2.6", "1.22", 
              "1.10.4", "0.6-1", "1.5.2", "1.0-8", "1.13.2", "2.0-0", "0.6.12", 
              "0.75-7", "1.0-2", "0.7.0", "0.2", "1.5.6", "3.1-2", "0.3-8", 
              "2.2.1", "0.10", "1.10", "2.0-8", "1.0.4", "1.35", "1.0.7", "1.0-9", 
              "1.01-2", "2.3-14", "1.4.3", "0.8-68", "2.1-10", "2.18.0", "0.1.4", 
              "0.1-1", "1.3.1", "0.1-20", "0.4.1", "2.2.1", "0.1.3", "0.6.5", 
              "2.7", "0.2.0", "3.4.0", "0.18.0", "0.0.12", "1.0.0", "3.0.1", 
              "2.2.1", "0.2.0", "3.5.0", "1.0.0", "1.3-3", "1.27.1", "0.6", 
              "0.3", "1.9", "0.3.6", "0.8", "1.3.3", "1.2.1", "1.0.8", "0.7.2.9", 
              "1.5", "0.9-25", "2.23-15", "1.16", "0.3", "0.20-35", "0.6-28", 
              "0.2.0", "3.0", "1.1-13", "1.2-3", "0.9-35", "1.6.0", "1.5", 
              "1.2-5", "3.2.0", "0.8", "7.3-47", "1.2-10", "0.4-1", "5.3", 
              "1.1.0", "0.3.0", "1.8-17", "0.5", "1.2.4", "1.5-5", "0.1.0", 
              "0.2-21", "0.14.4", "0.14.0", "1.4-6", "0.4.3", "1.0-6", "0.7.1.295", 
              "1.16", "3.1-131", "1.0.4", "7.3-12", "2.1-0", "0.9.6", "4.0.17", 
              "0.4-7", "0.5-4", "2.0.1", "0.1-1", "4.7.0", "3.6-5", "1.8.4", 
              "2.2-6", "1.0.2", "1.1.2", "1.7.5", "0.2.2.2", "5.33", "1.7.1", 
              "1.21.0", "2.2.1", "2.5-8", "1.1-2", "0.12.11", "0.3.3.3.0", 
              "1.95-4.8", "1.1.1", "1.0.0", "1.0.1", "0.8.6", "1.4.2", "0.5.0", 
              "1.9", "0.1.1", "0.4.6.1", "0.10.11", "1.8-2", "0.92-7", "1.0", 
              "0.6", "0.4-11", "2.3-4", "0.4.1", "0.3-40", "0.3-1", "1.4.2", 
              "1.0.3", "1.5.1", "1.0.0", "2.5.0", "2.3.1", "0.10.0", "0.1.6", 
              "1.2-4", "1.77", "0.9.4.4", "1.1.5", "1.2.0", "2.41-3", "1.2.0", 
              "1.0-8", "1.3.3", "0.6.3", "0.1-2", "0.4.0", "0.2.0", "2.4-0", 
              "0.3-2", "1.0.2", "3.98-1.7", "1.8-2", "2.1.14", "1.8-0")

success <- invisible(mapply(function(p, v) length(find.package(p, quiet = TRUE)) > 0 && compareVersion(as.character(packageVersion(p)), v) >= 0, packs, versions))
if(!all(success)) install.packages(names(success)[!success], repos = paste0("file:///", getwd(), "/extras"), type = "win.binary")

# ggthemes temp added because themes list doesn't contain package names
for(pack in c("plyr", "dplyr", "ggplot2", "ggthemes", "svglite")) {
 library(pack, character.only = TRUE)
}

setwd(dirname(parent.frame(2)$ofile))
source("instat_object_R6.R")
source("data_object_R6.R")
source("labels_and_defaults.R")
source("stand_alone_functions.R")
files <- sort(dir(file.path(getwd(), 'Backend_Components/'), pattern=".R$", full.names = TRUE))
lapply(files, source, chdir = TRUE)