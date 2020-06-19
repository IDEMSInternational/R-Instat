install.packages("miniCRAN")

core_pkgs <- c("reshape2", "lubridate","plyr", "dplyr", "rtf", "openxlsx", "ggplot2", 
               "extRemes", "GGally", "agridat", "FactoMineR", "plotrix", "candisc", "R6", 
               "openair", "circular", "survival", "Evapotranspiration", "clifro", "devtools", 
               "factoextra", "circlize", "CircStats", "gridExtra", "ggfortify", "rio", 
               "readxl", "lme4", "dummies", "ggthemes", "lazyeval", "stringr", "httr", 
               "jsonlite", "fitdistrplus", "visreg", "climdex.pcic", "mosaic", "ncdf4", 
               "getPass", "RMySQL", "DBI", "EnvStats", "signmedian.test", "sjPlot", 
               "sjmisc", "plotly", "svglite", "htmlTable", "rje", "tidyr", "faraway", 
               "ncdf.tools", "rrefine", "dae", "gapminder", "questionr", "nycflights13", 
               "Lahman", "RcppRoll", "cmsaf", "sjlabelled", "maptools", "RColorBrewer", 
               "colorRamps", "mapdata", "rworldmap", "rworldxtra", "e1071", "robustbase", 
               "wakefield", "Hmisc", "SPEI", "agricolae", "sf", "weathermetrics", 
               "geosphere", "ggmosaic", "readODS", "ggalt", "ggpmisc", "treemapify",
			   "hydroGOF", "hydroTSM", "verification", "DescTools",
			   "PCICt", "abind") # Added because of ncdf4.helpers
			   # You must unzip ncdf4.helpers folder into library folder manually
			   # Download from here https://drive.google.com/file/d/1UqwqVDxMvlHNocUa0i6uiGFT24zwGdgB/view?usp=sharing

pkgList <- miniCRAN::pkgDep(core_pkgs, type = "win.binary", repos = "https://cran.rstudio.com/", 
                  suggests = FALSE, includeBasePkgs = TRUE, Rversion = "3.6")

install.packages(pkgList, lib = "../library", 
                 repos = "https://cran.rstudio.com/")