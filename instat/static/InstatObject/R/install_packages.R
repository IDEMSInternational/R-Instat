require("miniCRAN")
r_version <- "4.1"
# Specify list of packages to download
pkgs <-
  c(
    "reshape2",
    "lubridate",
    "plyr",
    "dplyr",
    "rtf",
    "openxlsx",
    "ggplot2",
    "extRemes",
    "GGally",
    "agridat",
    "DAAG",
    "FactoMineR",
    "plotrix",
    "candisc",
    "R6",
    "openair",
    "circular",
    "survival",
    "Evapotranspiration",
    "clifro",
    "devtools",
    "factoextra",
    "circlize",
    "CircStats",
    "gridExtra",
    "ggfortify",
    "rio",
    "readxl",
    "lme4",
    "ggthemes",
    "lazyeval",
    "stringr",
    "httr",
    "jsonlite",
    "fitdistrplus",
    "visreg",
    "climdex.pcic",
    "mosaic",
    "ncdf4",
    "ncdf4.helpers",
    "getPass",
    "RMySQL",
    "DBI",
    "EnvStats",
    "sjPlot",
    "sjmisc",
    "plotly",
    "svglite",
    "htmlTable",
    "rje",
    "tidyr",
    "faraway",
    "rrefine",
    "dae",
    "gapminder",
    "questionr",
    "nycflights13",
    "Lahman",
    "RcppRoll",
    "cmsaf",
    "sjlabelled",
    "maptools",
    "RColorBrewer",
    "colorRamps",
    "mapdata",
    "rworldmap",
    "rworldxtra",
    "e1071",
    "robustbase",
    "wakefield",
    "Hmisc",
    "SPEI",
    "agricolae",
    # For reading shapefiles in Climatic > File > Import and Tidy Shapefile
    "sf",
    "weathermetrics",
    "geosphere",
    "ggmosaic",
    "readODS",
    "ggalt",
    "ggpmisc",
    "treemapify",
    "stringdist",
    "imputeTS",
    "chillR",
    "patchwork",
    "changepoint",
    "trend",
    "pbs",
    "visdat",
    "texmex",
    "zyp",
    "DescTools",
    "MKinfer",
    "ggplotify",
    # For reproducible pasting of data directly into the grid
    "clipr",
    # For downloading data from the CDS in Climatic > File > Import from CDS (Climate Data Store)
    "ecmwfr",
    # For comparison measures used in Climatic > Compare > Summary
    "hydroGOF",
    "lemon",
    "HistData",
    "caret",
    "rpivotTable",
    # For datasets
    "gcookbook",
    "tidytext",
    "janitor",
    "ggwordcloud",
    # Has many useful datasets, described in the R-Instat help.They include prime numbers, Fibonacci numbers, names of dinosaurs, and the chemical elements. 
    "rcorpora",
    # Includes a set of interesting data sets, designed particularly for machine learning.
    "mlbench",
    # For producing periodic and natural splines in Climatic > Compare > Seasonal Plot
    "splines2",
    # For density, distribution function and random generation for triangular and continuous empirical distributions 
    # Model > Probability Distributions > Show Model
    # Model > Probability Distributions > Random Samples
    "mc2d",
    # For creating extra summary statistics in Describe > Two/Three Variables > Summarise
    "skimr",
    # For fast creation of dummy (binary) variables from categories variables in Prepare > Column:Factor > Dummy Variables
    "fastDummies",
    # For most frequent values in Prepare > Column:Numeric > Row Summaries
    "statip",
    # also install mmtable2 from GitHub devtools::install_github("ianmoran11/mmtable2")
    # install.packages('remotes')
    # also install aida-package from GitHub remotes::install_github('michael-franke/aida-package')
    # also install CDT from GitHub devtools::install_github("rijaf-iri/CDT")
    "corrr",
    "dslabs",
    "coin",
    #This small library contains a series of simple tools for constructing and manipulating confounded and fractional factorial designs.
    "conf.design",
    "pingr",
    "vcdExtra",
    # For inspect, read, edit and run files for 'APSIM'
    "apsimx",
    #Fast functions for dealing with prime numbers, such as testing whether a number is prime and generating a sequence prime numbers.
    "primes",
    #Generates well-known integer sequences. 'gmp' package is adopted for computing with arbitrarily large numbers.
    "Zseq",
    # Extending 'gt' for Beautiful HTML Tables.
    "gtExtras",
    "segmented", 
    # Utilities for verifying discrete, continuous and probabilistic forecasts, and forecasts expressed as parametric distributions are included.
    "verification",
    "prediction",
    # Tutorial Analysis of Some Agricultural Experiments. 
    "agriTutorial", 
    "arm", 
    "rstanarm", 
    "statsr",
    "statquotes",
    "desplot",
    #applying formatting on vectors and data frames to make data presentation easier, richer, more flexible and hopefully convey more information
    "formattable",
    #A 'ggplot2' extension that allows text to follow curved paths.
    "geomtextpath",
    "collapse"
 )
pkgList <- pkgDep(pkgs, type="win.binary", repos = "https://cran.rstudio.com/", suggests = FALSE, includeBasePkgs = FALSE, Rversion = r_version)
pth <- "C:/Users/Antoine/Documents/RPackages"
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
