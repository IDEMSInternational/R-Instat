Sys.setenv(TZ='GMT')

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
packs <- c("abind", "agricolae", "agridat", "AlgDesign", "animation", 
        "anytime", "arrangements", "ash", "askpass", "assertthat", "automap", 
        "backports", "base64enc", "bayestestR", "BH", "bit", "bit64", 
        "bitops", "boot", "brew", "brio", "broom", "bslib", "ca", "cachem", 
        "callr", "candisc", "car", "carData", "caret", "cellranger", 
        "changepoint", "checkmate", "chillR", "chron", "circlize", "CircStats", 
        "circular", "class", "classInt", "cli", "clifro", "climdex.pcic", 
        "clipr", "clock", "clue", "cluster", "cmsaf", "cmsafops", "cmsafvis", 
        "codetools", "coin", "colorRamps", "colorspace", "colourpicker", 
        "combinat", "commonmark", "confintr", "corrplot", "corrr", "countrycode", 
        "cowplot", "cpp11", "crayon", "credentials", "crosstalk", "curl", 
        "DAAG", "dae", "data.table", "datawizard", "date", "DBI", "deldir", 
        "dendextend", "DEoptimR", "desc", "DescTools", "devtools", "diffobj", 
        "digest", "distillery", "dotCall64", "downlit", "dplyr", "dslabs", 
        "DT", "e1071", "ecmwfr", "effectsize", "ellipse", "ellipsis", 
        "emmeans", "EnvStats", "estimability", "evaluate", "Evapotranspiration", 
        "Exact", "exactRankTests", "expm", "extraDistr", "extrafont", 
        "extrafontdb", "extRemes", "factoextra", "FactoMineR", "fansi", 
        "faraway", "farver", "fastDummies", "fastmap", "fields", "filelock", 
        "fitdistrplus", "flashClust", "FNN", "fontawesome", "forcats", 
        "foreach", "forecast", "foreign", "formula.tools", "Formula", 
        "fracdiff", "fs", "future.apply", "future", "gapminder", "gclus", 
        "gcookbook", "generics", "GenSA", "geosphere", "gert", "getPass", 
        "GGally", "ggalt", "ggdendro", "ggeffects", "ggfittext", "ggforce", 
        "ggformula", "ggfortify", "ggmosaic", "ggplot2", "ggplotify", 
        "ggpmisc", "ggpp", "ggpubr", "ggrepel", "ggridges", "ggsci", 
        "ggsignif", "ggstance", "ggtext", "ggthemes", "ggwordcloud", 
        "gh", "gitcreds", "gld", "GlobalOptions", "globals", "glue", 
        "gmp", "gnm", "goftest", "gower", "gridExtra", "gridGraphics", 
        "gridtext", "gstat", "gtable", "hardhat", "haven", "heplots", 
        "hexbin", "highr", "HistData", "Hmisc", "hms", "htmlTable", "htmltools", 
        "htmlwidgets", "httpuv", "httr", "hunspell", "hydroGOF", "hydroTSM", 
        "imputeTS", "ini", "insight", "interp", "intervals", "ipred", 
        "isoband", "iterators", "janeaustenr", "janitor", "jpeg", "jquerylib", 
        "jsonlite", "Kendall", "KernSmooth", "keyring", "klaR", "knitr", 
        "labeling", "labelled", "Lahman", "later", "lattice", "latticeExtra", 
        "lava", "lazyeval", "leaflet.providers", "leaflet", "leaps", 
        "lemon", "libcoin", "lifecycle", "listenv", "lme4", "lmodel2", 
        "lmom", "lmomco", "Lmoments", "lmtest", "lubridate", "lwgeom", 
        "magick", "magrittr", "mapdata", "mapproj", "maps", "maptools", 
        "markdown", "MASS", "Matrix", "MatrixModels", "matrixStats", 
        "mc2d", "memoise", "metR", "mgcv", "mime", "miniUI", "minqa", 
        "MKdescr", "MKinfer", "mlbench", "ModelMetrics", "modelr", "modeltools", 
        "mosaic", "mosaicCore", "mosaicData", "multcomp", "multcompView", 
        "munsell", "mvtnorm", "ncdf4.helpers", "ncdf4", "nlme", "nloptr", 
        "nnet", "nortest", "numDeriv", "nycflights13", "openair", "openssl", 
        "openxlsx", "operator.tools", "parallelly", "parameters", "patchwork", 
        "pbkrtest", "pbs", "PCICt", "performance", "pillar", "pingr", 
        "pkgbuild", "pkgconfig", "pkgdown", "pkgload", "plotly", "plotrix", 
        "pls", "plyr", "png", "polyclip", "polynom", "praise", "prettyunits", 
        "pROC", "processx", "prodlim", "productplots", "profvis", "progress", 
        "progressr", "proj4", "promises", "proxy", "ps", "purrr", "qap", 
        "quadprog", "quantmod", "quantreg", "questionr", "qvcalc", "R.cache", 
        "R.methodsS3", "R.oo", "R.utils", "R6", "ragg", "rainfarmr", 
        "rappdirs", "raster", "rasterVis", "rbibutils", "rcmdcheck", 
        "RColorBrewer", "rcorpora", "Rcpp", "RcppArmadillo", "RcppEigen", 
        "RcppRoll", "RCurl", "Rdpack", "readODS", "readr", "readxl", 
        "recipes", "registry", "relimp", "rematch", "rematch2", "remotes", 
        "repr", "reshape", "reshape2", "rgdal", "rio", "rje", "rlang", 
        "rmarkdown", "RMAWGEN", "robustbase", "rootSolve", 
        "roxygen2", "rpart", "rpivotTable", "rprojroot", "rrefine", "rstatix", 
        "rstudioapi", "rtf", "Rttf2pt1", "rversions", "rvest", "rworldmap", 
        "rworldxtra", "s2", "sandwich", "sass", "scales", "scatterplot3d", 
        "SearchTrees", "selectr", "seriation", "sessioninfo", "sf", "sftime", 
        "shades", "shape", "shiny", "shinyFiles", "shinyjs", "shinythemes", 
        "shinyWidgets", "sjlabelled", "sjmisc", "sjPlot", 
        "sjstats", "skimr", "snakecase", "SnowballC", "sodium", "sourcetools", 
        "sp", "spacetime", "spam", "SparseM", "SPEI", "splines2", "splus2R", 
        "SQUAREM", "stars", "statip", "stinepack", "stringdist", 
        "strucchange", "styler", "survival", "svglite", "sys", 
        "systemfonts", "testthat", "texmex", "textshaping", 
        "TH.data", "tibble", "tidyr", "tidyselect", "tidytext", "timechange", 
        "timeDate", "tinytex", "tokenizers", "treemapify", "trend", "tseries", 
        "TSP", "TTR", "tweenr", "tzdb", "units", "urca", "urlchecker", 
        "usethis", "utf8", "vars", "vcd", "vcdExtra", "vctrs", "viridis", 
        "viridisLite", "visdat", "visreg", "vroom", "wakefield", "waldo", 
        "weathermetrics", "whisker", "withr", "wk", "xfun", "xml2", 
        "xopen", "xtable", "xts", "yaml", "yulab.utils", "zip", "zoo", 
        "zyp")

install.packages(packs, dependencies = FALSE, repos='https://cloud.r-project.org', type="both")

#install development packages not on CRAN
devtools::install_github("ianmoran11/mmtable2")
