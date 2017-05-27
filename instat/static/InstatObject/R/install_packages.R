require("miniCRAN")

# Specify list of packages to download
pkgs <- c("reshape2", "lubridate","plyr", "dplyr", "rtf", "openxlsx", "ggplot2", "extRemes", "GGally", "agridat", "DAAG", "FactoMineR", "plotrix", "candisc", "R6", "openair", "circular", "survival", "Evapotranspiration", "clifro", "devtools", "factoextra", "circlize", "CircStats", "gridExtra", "ggfortify", "rio", "readxl", "lme4", "dummies", "ggthemes", "lazyeval", "stringr", "httr", "jsonlite", "fitdistrplus", "visreg", "climdex.pcic", "mosaic", "ncdf4", "getPass", "RMySQL", "DBI", "EnvStats", "signmedian.test", "sjPlot", "sjmisc", "plotly", "svglite", "htmlTable", "rje")
pkgList <- pkgDep(pkgs, type="win.binary", suggests = FALSE, includeBasePkgs = FALSE, Rversion = "3.4")
pth = "C:/Users/Danny/Documents/RPackages"
revolution <- c(CRAN="http://cran.microsoft.com")
makeRepo(pkgList, path = pth, type = "win.binary", Rversion = "3.4")

#add extra packages to location
#then update
#updateRepoIndex(pth, type = "win.binary")

#install.packages("trimcluster", repos = paste0("file:///", pth), type = "win.binary")
#install.packages("maps", repos = paste0("file:///", pth), type = "win.binary")

#install.packages(paste0("C:/Users/Danny/Downloads", "/ggfortify_0.1.0.tar.gz"), repos = NULL, type="source")
pthbin = paste0(pth, "/bin/windows/contrib/3.4")
#list.files(pth, recursive=TRUE, full.names=FALSE)
View(pkgAvail(repos=pth, type="win.binary")[, c(1:3, 5)])

#get list of packages in repo
enquote(pkgList)
enquote(unique(as.vector(pkgAvail(repos=pth, type="win.binary")[, c(1)])))
