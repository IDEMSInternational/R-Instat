install.packages("miniCRAN")

core_pkgs <- c("reshape2", "lubridate","plyr", "dplyr", "rtf", "openxlsx", "ggplot2", "extRemes", "GGally", "agridat", "DAAG", "FactoMineR", "plotrix", "candisc", "R6", "openair", "circular", "survival", "Evapotranspiration", "clifro", "devtools", "factoextra", "circlize", "CircStats", "gridExtra", "ggfortify", "rio", "readxl", "lme4", "dummies", "ggthemes", "lazyeval", "stringr", "httr", "jsonlite", "fitdistrplus", "visreg", "climdex.pcic", "mosaic", "ncdf4", "ncdf4.helpers", "getPass", "RMySQL", "DBI", "EnvStats", "signmedian.test", "sjPlot", "sjmisc", "plotly", "svglite", "htmlTable", "rje", "tidyr", "faraway", "rrefine", "dae", "gapminder", "questionr", "nycflights13", "Lahman", "RcppRoll", "cmsaf", "sjlabelled", "maptools", "RColorBrewer", "colorRamps", "mapdata", "rworldmap", "rworldxtra", "e1071", "robustbase", "wakefield", "Hmisc", "SPEI", "agricolae", "sf", "weathermetrics", "geosphere", "ggmosaic", "readODS", "ggalt", "ggpmisc", "treemapify", "stringdist", "imputeTS", "chillR", "patchwork", "changepoint", "trend", "pbs", "visdat")

pkgList <- miniCRAN::pkgDep(core_pkgs, type = "win.binary", repos = "https://cran.rstudio.com/", 
                  suggests = FALSE, includeBasePkgs = TRUE, Rversion = "4.0")

install.packages(pkgList, lib = "../library", 
                 repos = "https://cran.rstudio.com/", dependencies = FALSE)