require("miniCRAN")

# Specify list of packages to download
pkgs <- c("reshape2", "lubridate","plyr", "dplyr", "rtf", "openxlsx", "ggplot2", "extRemes", "GGally", "agridat", "DAAG", "FactoMineR", "plotrix", "candisc", "R6", "openair", "circular", "survival", "Evapotranspiration", "clifro", "devtools", "factoextra", "circlize", "CircStats", "gridExtra", "ggfortify", "rio", "readxl", "lme4", "dummies", "ggthemes", "lazyeval", "stringr", "httr", "jsonlite", "fitdistrplus", "visreg", "climdex.pcic", "mosaic", "ncdf4", "getPass", "RMySQL", "DBI", "EnvStats", "signmedian.test", "sjPlot", "sjmisc", "plotly", "svglite", "htmlTable", "rje", "tidyr", "faraway", "ncdf.tools", "rrefine", "dae", "gapminder")
pkgList <- pkgDep(pkgs, type="win.binary", repos = "https://cran.rstudio.com/", suggests = FALSE, includeBasePkgs = FALSE, Rversion = "3.4")
pth = "C:/Users/Danny/Documents/RPackages"
makeRepo(pkgList, path = pth, type = "win.binary", Rversion = "3.4", repos = "https://cran.rstudio.com/")

#add extra packages to location
#then update
#updateRepoIndex(pth, type = "win.binary")

#install.packages("trimcluster", repos = paste0("file:///", pth), type = "win.binary")
#install.packages("maps", repos = paste0("file:///", pth), type = "win.binary")

pthbin = paste0(pth, "/bin/windows/contrib/3.4")
#list.files(pth, recursive=TRUE, full.names=FALSE)
View(pkgAvail(repos=pth, type="win.binary")[, c(1:3, 5)])
versions <- pkgAvail(repos=pth, type="win.binary")[,2]

#get list of packages in repo
#enquote(pkgList)
enquote(as.vector(pkgAvail(repos=pth, type="win.binary")[, c(1)]))
enquote(as.vector(pkgAvail(repos=pth, type="win.binary")[,2]))
