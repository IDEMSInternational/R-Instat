Sys.setenv(TZ='GMT')
Sys.setlocale("LC_TIME", "C")

#Install packages from CRAN archive
install.packages("http://cran.r-project.org/src/contrib/Archive/signmedian.test/signmedian.test_1.5.1.tar.gz", repos=NULL, type="source")

#Install packages from win.binary
install.packages("stringi", dependencies = FALSE,  repos='https://cloud.r-project.org', type = "win.binary")
install.packages("stringr", dependencies = FALSE, repos='http://cran.us.r-project.org', type = "win.binary")
install.packages("RMySQL", dependencies = FALSE, repos='http://cran.us.r-project.org', type = "win.binary")
install.packages("terra", dependencies = FALSE, repos='http://cran.us.r-project.org', type = "win.binary")
install.packages("XML", dependencies = FALSE, repos='http://cran.us.r-project.org', type = "win.binary")

#Install packages from CRAN 
packs <-
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
    "mosaic",
    "ncdf4",
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
    # Statistical Analysis and Data Display: Heiberger and Holland
    "HH",
    #Datasets from the Datasaurus Dozen
    "datasauRus",
    "desplot",
    #applying formatting on vectors and data frames to make data presentation easier, richer, more flexible and hopefully convey more information
    "formattable",
    #A 'ggplot2' extension that allows text to follow curved paths.
    "geomtextpath",
    "moderndive",
    # Data Sets Useful for Modeling Examples
    "modeldata",
    # Data for an Introduction to Statistical Learning with Applications in R
    "ISLR",
    #Create Waffle Chart Visualizations
    "waffle",
    # Data and Code Behind the Stories and Interactives at 'FiveThirtyEight'
    "fivethirtyeight",
    "CGPfunctions",
    "ggside",
    "Weighted.Desc.Stat",
    "weights",
    "nanonext",
    "collapse",
    "curl",
    "ClimMobTools",
    "gtsummary",
    "PlackettLuce"
 )

install.packages(packs, dependencies = TRUE, repos='https://cloud.r-project.org', type="win.binary")

install.packages("https://cran.r-project.org/src/contrib/Archive/getPass/getPass_0.2-2.tar.gz", repos=NULL, type="source")
install.packages("https://cran.r-project.org/src/contrib/Archive/PCICt/PCICt_0.5-4.tar.gz", repos=NULL, type="source")
install.packages("https://cran.r-project.org/src/contrib/Archive/ncdf4.helpers/ncdf4.helpers_0.3-7.tar.gz", repos=NULL, type="source")
install.packages("https://cran.r-project.org/src/contrib/Archive/climdex.pcic/climdex.pcic_1.1-11.tar.gz", repos=NULL, type="source")

# Only use internal library
if (length(.libPaths()) >= 2){
  current_paths <- .libPaths()
  .libPaths(current_paths[c(1, 3)[c(1, 3) <= length(current_paths)]])
}

#install development packages not on CRAN
devtools::install_github("ianmoran11/mmtable2")
devtools::install_github("michael-franke/aida-package")
devtools::install_github("rijaf-iri/CDT")
devtools::install_github("IDEMSInternational/rapidpror")
devtools::install_github("IDEMSInternational/epicsawrap")
devtools::install_github("IDEMSInternational/instatCalculations", dependencies = FALSE, force = TRUE)
devtools::install_github("IDEMSInternational/instatExtras", dependencies = TRUE, upgrade = "always", force = TRUE)
devtools::install_github("IDEMSInternational/databook", dependencies = FALSE, force = TRUE)
devtools::install_github("IDEMSInternational/instatClimatic", dependencies = FALSE, force = TRUE)
