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
    "lubridate"
 )

install.packages(packs, dependencies = TRUE, repos='https://cloud.r-project.org', type="win.binary")

#install.packages("https://cran.r-project.org/src/contrib/Archive/getPass/getPass_0.2-2.tar.gz", repos=NULL, type="source")
#install.packages("https://cran.r-project.org/src/contrib/Archive/PCICt/PCICt_0.5-4.tar.gz", repos=NULL, type="source")
#install.packages("https://cran.r-project.org/src/contrib/Archive/ncdf4.helpers/ncdf4.helpers_0.3-7.tar.gz", repos=NULL, type="source")
#install.packages("https://cran.r-project.org/src/contrib/Archive/climdex.pcic/climdex.pcic_1.1-11.tar.gz", repos=NULL, type="source")

# Only use internal library
if (length(.libPaths()) >= 2){
  current_paths <- .libPaths()
  .libPaths(current_paths[c(1, 3)[c(1, 3) <= length(current_paths)]])
}

#install development packages not on CRAN
#devtools::install_github("ianmoran11/mmtable2")
#devtools::install_github("michael-franke/aida-package")
#devtools::install_github("rijaf-iri/CDT")
#devtools::install_github("IDEMSInternational/rapidpror")
#devtools::install_github("IDEMSInternational/epicsawrap")
#devtools::install_github("IDEMSInternational/instatCalculations", dependencies = FALSE, force = TRUE)
#devtools::install_github("IDEMSInternational/instatExtras", dependencies = TRUE, upgrade = "always", force = TRUE)
#devtools::install_github("IDEMSInternational/databook", dependencies = FALSE, force = TRUE)
#devtools::install_github("IDEMSInternational/instatClimatic", dependencies = FALSE, force = TRUE)
