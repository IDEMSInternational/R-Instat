# check_packages.R
# Verifies that all required R packages are installed.
# When adding a package to install_packages.R, add it here too.
#
# Usage: Rscript check_packages.R [workspace_root] [output_file]
#   workspace_root  Unused; kept for workflow compatibility
#   output_file     Path to write the markdown report (default: package-check-report.txt)

args        <- commandArgs(trailingOnly = TRUE)
output_file <- if (length(args) >= 2) args[2] else "package-check-report.txt"

# --------------------------------------------------------------------------
# Full list of required packages (mirrors install_packages.R)
# --------------------------------------------------------------------------
packages <- c(
  # CRAN archive packages
  "signmedian.test",
  "getPass",
  "PCICt",
  "ncdf4.helpers",
  "climdex.pcic",
  "rpivotTable",

  # CRAN packages
  "stringi",
  "stringr",
  "RMySQL",
  "terra",
  "XML",
  "reshape2",
  "lubridate",
  "plyr",
  "dplyr",
  "rtf",
  "ggplot2",
  "extRemes",
  "GGally",
  "agridat",
  "FactoMineR",
  "R6",
  "openair",
  "circular",
  "survival",
  "Evapotranspiration",
  "clifro",
  "devtools",
  "factoextra",
  "circlize",
  "gridExtra",
  "ggfortify",
  "rio",
  "readxl",
  "lme4",
  "ggthemes",
  "httr",
  "jsonlite",
  "fitdistrplus",
  "visreg",
  "mosaic",
  "ncdf4",
  "DBI",
  "EnvStats",
  "sjPlot",
  "sjmisc",
  "plotly",
  "svglite",
  "tidyr",
  "rrefine",
  "dae",
  "gapminder",
  "questionr",
  "nycflights13",
  "RcppRoll",
  "cmsaf",
  "sjlabelled",
  "maptools",
  "mapdata",
  "e1071",
  "robustbase",
  "wakefield",
  "Hmisc",
  "SPEI",
  "agricolae",
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
  "clipr",
  "ecmwfr",
  "hydroGOF",
  "lemon",
  "caret",
  "gcookbook",
  "tidytext",
  "janitor",
  "ggwordcloud",
  "rcorpora",
  "mlbench",
  "splines2",
  "mc2d",
  "skimr",
  "fastDummies",
  "statip",
  "corrr",
  "dslabs",
  "coin",
  "conf.design",
  "pingr",
  "vcdExtra",
  "apsimx",
  "primes",
  "Zseq",
  "gtExtras",
  "segmented",
  "verification",
  "prediction",
  "agriTutorial",
  "arm",
  "rstanarm",
  "statsr",
  "statquotes",
  "HH",
  "datasauRus",
  "desplot",
  "formattable",
  "geomtextpath",
  "moderndive",
  "modeldata",
  "ISLR",
  "waffle",
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
  "quarto",
  "PlackettLuce",

  # GitHub packages (IDEMSInternational/instatCalculations, etc.)
  "aida",
  "CDT",
  "rapidpror",
  "epicsawrap",
  "instatCalculations",
  "instatExtras",
  "databook",
  "instatClimatic"
)

# --------------------------------------------------------------------------
# Check against installed packages and report
# --------------------------------------------------------------------------
installed   <- rownames(installed.packages())
missing     <- packages[!packages %in% installed]

n_total     <- length(packages)
n_missing   <- length(missing)
n_installed <- n_total - n_missing

if (n_missing == 0) {
  status_icon <- "\u2705"
  status_line <- paste("All", n_total, "packages are installed.")
} else {
  status_icon <- "\u274c"
  status_line <- paste(n_missing, "of", n_total, "package(s) are not installed.")
}

report <- c(
  "<!-- package-check-report:start -->",
  paste("##", status_icon, "R Package Check"),
  "",
  paste0("**", status_line, "**"),
  "",
  "| Metric | Count |",
  "|--------|-------|",
  paste0("| Total packages checked | ", n_total, " |"),
  paste0("| Installed              | ", n_installed, " |"),
  paste0("| Missing                | ", n_missing, " |")
)

if (n_missing > 0) {
  report <- c(report, "", "### Missing Packages", "")
  report <- c(report, paste0("- `", missing, "`"))
}

report <- c(report, "", "<!-- package-check-report:end -->")

writeLines(report, output_file)
cat(paste(report, collapse = "\n"), "\n")

if (n_missing > 0) quit(status = 1L)

