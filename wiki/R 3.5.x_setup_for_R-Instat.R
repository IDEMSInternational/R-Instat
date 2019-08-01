pkgs <- c("reshape2", "lubridate","plyr", "dplyr", "rtf", "openxlsx", "ggplot2", 
          "extRemes", "GGally", "agridat", "DAAG", "FactoMineR", "plotrix", "candisc", 
          "R6", "openair", "circular", "survival", "Evapotranspiration", "clifro", 
          "devtools", "factoextra", "circlize", "CircStats", "gridExtra", "ggfortify", 
          "rio", "readxl", "lme4", "dummies", "ggthemes", "lazyeval", "stringr", "httr", 
          "jsonlite", "fitdistrplus", "visreg", "climdex.pcic", "mosaic", "ncdf4", 
          "getPass", "RMySQL", "DBI", "EnvStats", "signmedian.test", "sjPlot", "sjmisc", 
          "plotly", "svglite", "htmlTable", "rje", "tidyr", "faraway", "ncdf.tools", 
          "rrefine", "dae", "gapminder", "questionr", "nycflights13", "Lahman", 
          "ncdf4.helpers", "RcppRoll", "cmsaf", "sjlabelled", "maptools", "RColorBrewer", 
          "colorRamps", "mapdata", "rworldmap", "rworldxtra", "e1071", "robustbase", 
          "wakefield", "Hmisc", "SPEI", "agricolae", "sf", "weathermetrics", "geosphere", 
          "ggmosaic", "readODS", "ggalt")
install.packages(pkgs)

pkgs <- c("diptest", "flexmix", "kernlab", "mclust", "modeltools", "trimcluster")
install.packages(pkgs)

require(devtools)
install_version("fpc", version = "2.1-11.1")
install_version("boot", version = "1.3-22")
install_version("cluster", version = "2.0.9")
install_version("MASS", version = "7.3-51.4")
install_version("Matrix", version = "1.2-17")
install_version("mgcv", version = "1.8-28")
install_version("rpart", version = "4.1-15")
