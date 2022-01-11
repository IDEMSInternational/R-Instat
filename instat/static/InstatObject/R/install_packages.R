require("miniCRAN")
r_version <- "4.1"
# Specify list of packages to download
pkgs <- c("reshape2", "lubridate","plyr", "dplyr", "rtf", "openxlsx", "ggplot2", "extRemes", "GGally", "agridat", "DAAG", "FactoMineR", "plotrix", "candisc", "R6", "openair", "circular", "survival", "Evapotranspiration", "clifro", "devtools", "factoextra", "circlize", "CircStats", "gridExtra", "ggfortify", "rio", "readxl", "lme4", "dummies", "ggthemes", "lazyeval", "stringr", "httr", "jsonlite", "fitdistrplus", "visreg", "climdex.pcic", "mosaic", "ncdf4", "ncdf4.helpers", "getPass", "RMySQL", "DBI", "EnvStats", "signmedian.test", "sjPlot", "sjmisc", "plotly", "svglite", "htmlTable", "rje", "tidyr", "faraway", "rrefine", "dae", "gapminder", "questionr", "nycflights13", "Lahman", "RcppRoll", "cmsaf", "sjlabelled", "maptools", "RColorBrewer", "colorRamps", "mapdata", "rworldmap", "rworldxtra", "e1071", "robustbase", "wakefield", "Hmisc", "SPEI", "agricolae", "sf", "weathermetrics", "geosphere", "ggmosaic", "readODS", "ggalt", "ggpmisc", "treemapify", "stringdist", "imputeTS", "chillR", "patchwork", "changepoint", "trend", "pbs", "visdat", "texmex", "zyp", "DescTools", "MKinfer", "ggplotify", "clipr", "ecmwfr", "hydroGOF", "lemon", "HistData", "caret", "rpivotTable", "gcookbook", "tidytext", "janitor", "ggwordcloud")
pkgList <- pkgDep(pkgs, type="win.binary", repos = "https://cran.rstudio.com/", suggests = FALSE, includeBasePkgs = FALSE, Rversion = r_version)
pth <- "C:/Users/Danny/Documents/RPackages"
makeRepo(pkgList, path = pth, type = "win.binary", Rversion = r_version, repos = "https://cran.rstudio.com/")

#add extra packages to location
#then update
#updateRepoIndex(pth, type = "win.binary")

#install.packages("trimcluster", repos = paste0("file:///", pth), type = "win.binary")
#install.packages("maps", repos = paste0("file:///", pth), type = "win.binary")

pthbin <- paste0(pth, "/bin/windows/contrib/", r_version)
#list.files(pth, recursive=TRUE, full.names=FALSE)
View(pkgAvail(repos=pth, type="win.binary", Rversion = r_version)[, c(1:3, 5)])
versions <- pkgAvail(repos=pth, type="win.binary", Rversion = r_version)[,2]

#get list of packages in repo
#enquote(pkgList)
enquote(as.vector(pkgAvail(repos=pth, type="win.binary", Rversion = r_version)[, c(1)]))
enquote(as.vector(pkgAvail(repos=pth, type="win.binary", Rversion = r_version)[,2]))
