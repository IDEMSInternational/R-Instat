# December 2020
# These files have been obtained from https://github.com/ET-NCMP/NCMP and modified for use in R-Instat.
# Modifications have been made to the data input and output processes while carefully 
# maintaining consistent calculations processes as in the original files.

# This file is a modified version of P6_Count_Records.R.

###################################################################################
#                                                                                 #
#    The R-NCMPs package has been developed by the ET-NCMP.                       #
#    P6_Count_Records.R                                                           #
#                                                                                 #
#    This program counts the number of records for 5 different indices.           #
#    For further details please refer to the User Manual.                         #
#                                                                                 #
#    Programmers:                                                                 #
#    Megan Hartwell, McMaster University, Canada                                  #
#    Lucie Vincent, Environment and Climate Change Canada                         #
#    December 2016                                                                #
#    Modified by Simon Grainger, Bureau of Meteorology, Australia                 #
#    December 2017                                                                #
#                                                                                 #
###################################################################################

# a2: data.frame containing 21 indices from p2_indices()
# station: name of station column in a2
# a2_year: name of year column in a2
# month: name of month column in a2
# a4: data.frame containing the main data.frame output from p4_region_average
# station_df: data.frame will station metadata
# name: name of station column in station_df (to link with a2[[station]])
# lat: name of latitude column in station_df
# lon: name of longitude column in station_df
# nyb: (optional) start year for count period (if missing will use beginning year from a4)
# nye: (optional) end year for count period (if missing will use end year from a4)
p6_count_records <- function(a2, station, a2_year, month, a4, nyb, nye,
                             station_df, name, lat, lon) {

  ###################################################################################
  # Set variables with key thresholds for estimating variogram functions            #
  # These are values which have been determined by the ET-NCMP for the purposes of  #
  # generating NCMPs and may differ from other standards or guidelines              #
  # The ET-NCMP recommendation is to use the region average period                  #
  # ***** DO NOT CHANGE THE VALUE OF THESE VARIABLES *****                          #
  ###################################################################################
  
  ylo <- 1900L            # earliest possible year for count records
  yhi <- as.POSIXlt(Sys.time())$year + 1899L  # latest possible year == current - 1
  yclo <- attr(a4, "nyb") # recommended start year of count record period
  ychi <- attr(a4, "nye") # recommended end year of count record period
  nthresh <- 30L          # minimum number of years for valid station record
  
  ###################################################################################
  #    Gathers input info from the user                                             #
  # For clarity, no longer do this as a separate function                           #
  ###################################################################################
  
  # Number of stations to process
  # Can exclude stations at the end of the list, but arbitrary selection requires
  # editing of 'P2_Station_List.txt'
  # Suppressing warning messages - about converting strings to integer
  
  stations_data <- as.character(unique(a2[[station]]))
  stations_metadata <- as.character(unique(station_df[[name]]))
  if (!all(stations_data %in% stations_metadata)) stop("Station information not available for all stations that appear in data.")
  stations <- stations_data
  nstn <- length(stations)

  # For counting station records, allow the full range of years
  # but recommend the current region average period
  # Adjust for the minimum station length - should be OK
  
  yr1 <- ylo
  yr2 <- yhi - nthresh + 1L
  
  if (missing(nyb)) nyb <- yclo
  if (nyb < yr1 || nyb > yr2) stop("Beginning year for count record period must be between ", yr1, " and ", yr2, ".")

  yr1 <- nyb + nthresh - 1L
  yr2 <- yhi
  
  if (missing(nye)) nye <- ychi
  if (nye < yr1 || nye > yr2) stop("End year for count record period must be between ", yr1, " and ", yr2, ".")

  nyrs <- nye - nyb + 1L

  ###################################################################################
  # Set up variables for the 5 station extremes to count                            #
  ###################################################################################
  # For looping, do minimum extremes first, then the maxima
  
  ncmpn <- c(6L, 6L, 6L, 6L, 6L)
  folder <- "A2_Indices"
  folder2 <- paste("NCMP", ncmpn, sep = "")
  folder3 <- c("Extreme_Cold_Day", "Extreme_Cold_Night",
               "Extreme_Warm_Day", "Extreme_Warm_Night", "Extreme_Prec")
  dirs <- file.path(folder, folder2, folder3)  # adds separator "/"
  
  # Element relating to NCMP Index
  
  ele <- c("TXn", "TNn", "TXx", "TNx", "RXday1")
  tname <- attr(a4, "tname")

  ###################################################################################
  #    Read the modified station list                                               #
  ###################################################################################
  # With the number of stations already set, extract the subset to use
  
  files <- data.frame(Station = station_df[[name]],
                      Lat = station_df[[lat]],
                      Long = station_df[[lon]], stringsAsFactors = FALSE)
  
  # Ensure stations are in same order as in the data so that calculations match up.
  files <- files[match(stations, files$Station), ]
  Station <- files$Station
  
  ###################################################################################
  # Begins loop over NCMP indices                                                   #
  ###################################################################################
  
  Yrc <- nyb:nye  # vector of record count period years
  cYrc <- as.character(Yrc)
  cnames <- c(month_name_english, "Annual")  # only used internally
  output_data <- list()
  for (ne in 1:5) {
    # Initialise counter arrays for this index
    # Using the years for dimension names makes it easier to match periods
    
    Icount <- matrix(0L, nyrs, 13L, dimnames = list(Yrc, cnames))
    Irec <- matrix(0L, nyrs, 13L, dimnames = list(Yrc, cnames))
    Irecc <- matrix(0L, nyrs, 13L, dimnames = list(Yrc, cnames))
    
    ###################################################################################
    # Begins loop over stations		                                          #
    ###################################################################################
    
    for (i in 1:nstn) {
      
      ###################################################################################
      #    Read index data for all stations:                                            #
      # These are formatted as year by row, with months + annual extreme,               #
      # with an extra row at the bottom for the station extreme value                   #
      # Within P2_Indices.R, the extreme values were found by applying which.max/min()  #
      # This is has the effect of producing a NULL value when a month is missing,       #
      # causing the data.table to collapse missing years - an issue which has to        #
      # addressed when trying to determine whether have 30 years of station data        #
      # Another problem with the way that the records are generated is that the         #
      # missing days threshold is not applied, i.e. set extreme if have one day in month#
      # A significant rewrite of P2_Indices.R is required to pad out missing years      #
      # with missing extremes - which would likely fix several other issues             #
      ###################################################################################
      
      a2_station <- a2 %>% dplyr::filter(.data[[station]] == stations[i])
      I1 <- tidyr::pivot_wider(a2_station, id_cols = tidyselect::all_of(a2_year), names_from = tidyselect::all_of(month),
                               values_from = tidyselect::all_of(ele[ne]))
      I1 <- data.frame(I1)
      row.names(I1) <- I1[[a2_year]]
      I1[[a2_year]] <- NULL

      # For now, skip if less than 30 years, and print message if first 30 years is incomplete
      # Have to allow for missing years in the table as indicated above
      
      nyr <- nrow(I1)
      if (nyr < nthresh) {
        cat("Less than", nthresh, "years at", Station[i], "- skipping", fill = TRUE)
        next
      }
      
      cYr <- rownames(I1)                 # station years as character vector
      Yr <- as.integer(cYr)               # station years as integer vector
      y1 <- Yr[1]                         # first year of station
      y2 <- y1 + nthresh - 1L             # last year of initial period
      Irs <- which(is.element(Yr, y1:y2)) # indices of initial period

      # Which station years are in the reporting period?
      # Consequently, increment counter for stations reporting - logical F/T to integer 0/1
      Ir <- is.element(Yr, Yrc)
      Icount[cYr[Ir], ] <- Icount[cYr[Ir], ] + !is.na(I1[Ir, ])
      
      # Find accumulation of record min/max depending on the NCMP index
      # cummin/max requires NA to be reset to +/-Inf to work as intended
      
      if (ne <= 2L) {
        I1[is.na(I1)] <- +Inf
        Ival <- sapply(I1, cummin)
      } else {
        I1[is.na(I1)] <- -Inf
        Ival <- sapply(I1, cummax)
      }
      
      # Having done this, can extract the index (from the start year) of
      # each cumulative record from the sum of the run lengths
      # The need to append to the time series generates a spurious "record" after
      # the end of the data, but this is able to be ignored when converting to years
      
      Irl <- apply(Ival, 2, function(x) cumsum(c(1L, rle(x)$lengths)))
      
      # For each month, convert to the year of the record, subject to not more
      # than one cumulative record in the first 30 years
      # Also save the year of the absolute (non-cumulative) record
      
      ilen <- sapply(Irl, length)  # number of records for each month (+ 1 spurious)
      for (j in 1:13) {
        jmax <- max(which(Yr[Irl[[j]]] <= y2))  # index of last record in start period
        jrec <- which(is.element(Yr[Irl[[j]]], Yrc) & 1:ilen[j] >= jmax)  # index of valid records
        jlen <- length(jrec)
        if (jlen > 0L) {               # have at least one valid record for this month
          jcYr <- cYr[Irl[[j]][jrec]]  # year of valid records, as character
          Irecc[jcYr, j] <- Irecc[jcYr, j] + 1L
          Irec[jcYr[jlen], j] <- Irec[jcYr[jlen], j] + 1L
        }
      }
      
      # Ends loop over months
      
    }
    
    ###################################################################################
    # Ends loop over stations                                                         #
    ###################################################################################
    
    ###################################################################################
    #    Write record counts                                                          #
    ###################################################################################
    # This is now in a format consistent with the Region Averages
    # However the separate files and column names are not consistent with the Guidance
    
    X <- data.frame(Year = rep(Yrc, each = 13), Month = rep(1:13, times = nyrs),
                    Count = as.vector(t(Irec)), "No of Stns" = as.vector(t(Icount)), check.names = FALSE)
    X[,"Count Accum"] <- as.vector(t(Irecc))  # Replace absolute count with accumulated
    output_data[[ele[ne]]] <- X
  }
  
  ###################################################################################
  # Ends loop over indices                                                          #
  ###################################################################################
  # It is probably useful to retain a "configuration" file for counting records
  
  out <- dplyr::bind_rows(output_data, .id = "ncmp_index")
  out$region <- tname
  out <- dplyr::select(out, region, dplyr::everything())
  dy <- date()
  attr(out, "dy") <- dy
  attr(out, "tname") <- tname
  attr(out, "nstn") <- nstn
  attr(out, "nyb") <- nyb
  attr(out, "nye") <- nye
  return(out)
}