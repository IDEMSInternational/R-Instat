#install.packages("miniCRAN")
library("miniCRAN")

# Specify list of packages to download
pkgs <- c("openxlsx", "reshape2", "lubridate","plyr", "rtf", "ggplot2", "extRemes", "GGally", "CCA", "plotrix", "agridat", "DAAG", "FactoMineR", "plotrix", "agridat", "candisc", "R6", "openair", "circular", "survival", "Evapotranspiration", "clifro", "devtools", "factoextra", "circlize", "CircStats", "proto", "tidyr", "gridExtra", "tidyr", "ggfortify", "rio", "readxl", "lme4", "dummies", "ggthemes", "lazyeval", "stringr", "httr", "jsonlite", "fitdistrplus", "visreg")
pkgList <- pkgDep(pkgs, type="win.binary", suggests = FALSE, includeBasePkgs = FALSE, Rversion = "3.3")
pth = "C:/Users/Danny/Documents/RPackages"
revolution <- c(CRAN="http://cran.microsoft.com")
makeRepo(pkgList, path = pth, type = "win.binary", Rversion = "3.3")

#add extra packages to location
#then update
updateRepoIndex(pth, type = "win.binary")

install.packages("trimcluster", repos = paste0("file:///", pth), type = "win.binary")
install.packages("maps", repos = paste0("file:///", pth), type = "win.binary")

install.packages(paste0("C:/Users/Danny/Downloads", "/ggfortify_0.1.0.tar.gz"), repos = NULL, type="source")
pthbin = paste0(pth, "/bin/windows/contrib/3.3")
#list.files(pth, recursive=TRUE, full.names=FALSE)
View(pkgAvail(repos=pth, type="win.binary")[, c(1:3, 5)])

#get list of packages in repo
enquote(pkgList)
enquote(unique(as.vector(pkgAvail(repos=pth, type="win.binary")[, c(1)])))
