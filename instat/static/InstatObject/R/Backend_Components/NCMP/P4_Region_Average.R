# December 2020
# These files have been obtained from https://github.com/ET-NCMP/NCMP and modified for use in R-Instat.
# Modifications have been made to the data input and output processes while carefully 
# maintaining consistent calculations processes as in the original files.

# This file is a modified version of P4_Region_Average.R.

###################################################################################
#                                                                                 #
#    The R-NCMPs package has been developed by the ET-NCMP.                       #
#    P4_Region_Average.R                                                          #
#                                                                                 #
#    This program calculates the regional average of 8 different indices.         #
#    For further details please refer to the User Manual.                         #
#                                                                                 #
#    Programmers:                                                                 #
#    Megan Hartwell, McMaster University, Canada                                  #
#    Lucie Vincent, Environment and Climate Change Canada                         #
#    December 2016                                                                #
#    Modified by Simon Grainger, Bureau of Meteorology, Australia                 #
#    February 2017 - Cleaned up, code is more "R-like"                            #
#    Modified by John Kennedy, Met Office, UK                                     #
#    June 2017 - move function defs to support sript, added precip anomaly        #
###################################################################################

# a2: data.frame containing 21 indices from p2_indices()
# station: name of station column in a2
# year: name of year column in a2
# month: name of month column in a2
# a3: data.frame containing variogram output from p3_variogram()
# ne: (optional) which indices to compute region average for, 1 to 8.
# station_df: data.frame will station metadata
# name: name of station column in station_df (to link with a2[[station]])
# lat: name of latitude column in station_df
# lon: name of longitude column in station_df
# nyb: start year
# nye: end year
# uncode: UN country code for region as 
# defined in https://www.nationsonline.org/oneworld/countrycodes/countrycodes_a.htm or 0 for other region
# label: (Optional) An alternative name for the country selected.
# res: A grid spacing in degrees for the interpolation. One of 0.1, 0.25, 0.5, 1 or 2.
# igrid: If TRUE output grid square data.

# ne options:
# 1: NCMP 1, Monthly Mean Temperature Anomaly
# 2: NCMP 2, Monthly Total Precipitation Anomaly Normalized
# 3: NCMP 2, Monthly Total Precipitation Anomaly
# 4: NCMP 3, Standardized Precipitation Index
# 5: NCMP 4, Percentage of Warm Days
# 6: NCMP 4, Percentage of Warm Nights
# 7: NCMP 5, Percentage of Cold Days
# 8: NCMP 5, Percentage of Cold Nights
p4_region_average <- function(a2, station, year, month, a3, ne = 1:8,
                              station_df, name, lat, lon,
                              nyb = 1950, nye, uncode, label, res,
                              igrid = FALSE) {

  data(package = "maptools", wrld_simpl)
  
  ###################################################################################
  # Set variables with key thresholds for region averages                           #
  # These are values which have been determined by the ET-NCMP for the purposes of  #
  # generating NCMPs and may differ from other standards or guidlines               #
  # ***** DO NOT CHANGE THE VALUE OF THESE VARIABLES *****                          #
  ###################################################################################
  
  yrlo <- 1900L           # earliest possible year for analysis period
  yrhi <- as.POSIXlt(Sys.time())$year + 1899L # latest possible year == current - 1
  DmaxT <- 3000           # maximum separation (km) for temperature indices
  DmaxP <- 2000           # maximum separation (km) for precipitation indices
  
  stations_data <- as.character(unique(a2[[station]]))
  stations_metadata <- as.character(unique(station_df[[name]]))
  if (!all(stations_data %in% stations_metadata)) stop("Station information not available for all stations that appear in data.")
  stations <- stations_data
  nstn <- length(stations)
  
  gvals <- c(0.1, 0.25, 0.5, 1, 2)
  if (!res %in% gvals) stop("Resolution must be one of ", paste(gvals, collapse=", "))
  
  # Allow a broad range of analysis periods, but suggest running up to last year
  
  if (nyb < yrlo || nyb > yrhi) stop("Beginning year must be between ", ytlo, " and ", yrhi)
  if (nye < nyb || nyb > yrhi) stop("Beginning year must be between beginning year and ", yrhi)
  
  # Get name of country or region to calculate for
  # The easiest identifier is the ISO 3166-1 3 letter code, but internally use the UN code
  # Currently not considering the region and subregion numeric codes  

  # The first check generates a valid ISO 3166-1 code
  uncode <- as.integer(uncode)
  if (uncode != 0 && !uncode %in% wrld_simpl@data$UN) stop(uncode, " is not a valid UN country code.", 
                                                           " See www.nationsonline.org/oneworld/countrycodes.htm for country codes", 
                                                           " or set to 0 for region.")
  
  if (uncode == 0) {
    tcode = "REG"
    uncode = "0"
    tname = "Region"
  } else {
    ix <- which(is.element(wrld_simpl@data$UN, uncode))
    tcode <- levels(wrld_simpl@data$ISO3)[wrld_simpl@data[ix, "ISO3"]]
    tname <- levels(wrld_simpl@data$NAME)[wrld_simpl@data[ix, "NAME"]]
  }

  if(!missing(label) && label != "") tname <- label
  tname <- gsub("[[:space:]]|[[:punct:]]", "_", tname)  # Replace punctuation and spaces
  
  # Which diagnostic to compute
  # Removed the option to process all diagnostics in one run of the script
  
  ele <- c("TMA", "PrAn", "PrA", "SPI", "TX90p", "TN90p", "TX10p", "TN10p")  # NCMP index element

  cnames <- c(month.name,"Annual")
  
  # list of data frames returned
  out <- list()
  
  ###################################################################################
  #    Read the modified station list                                               #
  ###################################################################################
  # With the number of stations already set, extract the subset to use
  
  files <- data.frame(Station = station_df[[name]],
                      Lat = station_df[[lat]],
                      Long = station_df[[lon]], 
                      stringsAsFactors = FALSE)
  # Ensure stations are in same order as in the data so that calculations match up.
  files <- files[match(stations, files$Station), ]
  Station <- files$Station
  olats <- files$Lat
  olons <- files$Long
  
  ###################################################################################
  #    Set up grid squares                                                          #
  # This will be different as round(x,0) rounds rather than truncates towards zero  #
  # The land grid point check requires that longitudes are in the range -180 to 180 #
  # Have enforced this in the modified station file,                                #
  # but need to consider the case that they cross the dateline (ie Pacific Ocean)   #
  ###################################################################################
  
  latmin <- floor(min(olats))     # min station latitude, rounded down
  latmax <- ceiling(max(olats))   # max station latitude, rounded up
  latr <- latmax - latmin         # range of latitudes
  lngmin <- floor(min(olons))     # min station longitude, rounded down
  lngmax <- ceiling(max(olons))   # max station longitude, rounded up
  lngr <- lngmax - lngmin         # range of longitudes
  if (lngr > 180) {
    lngr <- 360 - lngr
    lngmin <- lngmax
  }
  
  # Set size of squares in degrees (now user-set)
  
  slng <- res
  slat <- res
  xlng <- as.integer(ceiling(lngr / slng))  # All station longitudes
  xlat <- as.integer(ceiling(latr / slat))  # All station latitudes
  gridsq <- xlng * xlat  # Number of grid squares
  
  # Get latitude and longitude for all grid squares
  # This requires repeating the individual values
  
  lata <- latmin + slat * (0:xlat)                        # vector of latitude edges
  lnga <- lngmin + slng * (0:xlng)                        # vector of longitude edges
  latn <- rep(lata[-(xlat + 1)], times = xlng)            # min lat of each grid square
  latx <- rep(lata[-1], times = xlng)                     # max lat of each grid square
  lngn <- rep(lnga[-(xlng+1)], each = xlat)               # min long of each grid square
  lngx <- rep(lnga[-1],each = xlat)                       # max long of each grid square
  latc <- rep(lata[-(xlat + 1)] + slat / 2, times = xlng) # centre lat of each grid square
  lngc <- rep(lnga[-(xlng+1)] + slng / 2, each = xlat)    # centre long of each grid square
  
  d1 <- distance(latn, lngn, latn, lngx)  # length of southern edge of each grid square
  d2 <- distance(latx, lngn, latx, lngx)  # length of northern edge of each grid square
  d3 <- distance(latn, lngc, latx, lngc)  # height of each grid square
  A <- (d1 + d2) / 2 * d3                 # area (km^2) of each grid square
  
  Dsq <- cbind(Grid = 1:gridsq, latn, latx, lngn, lngx, Lat = latc, Long = lngc, Area = A)
  
  # Find which grid square each station is in
  # This may be useful as a backup if no land grid squares are found
  # Need to allow for crossing the Dateline - should work but not tested
  # Vectorised the calculation, although this is harder to follow
  
  olons[olons < lngmin] <- olons[olons < lngmin] + 360
  ilat <- lapply(olats, function(x) which(Dsq[,2] <= x & Dsq[,3] > x))
  ilon <- lapply(olons, function(x) which(Dsq[,4] <= x & Dsq[,5] > x))
  c1 <- mapply(intersect, ilat, ilon)
  if (!is.vector(c1, mode = "integer"))
  {stop("Error calculating grid squares for stations", call. = FALSE)}

  ###################################################################################
  #    Find which grid squares are on land and in our country                       #
  # This has now been tested for generating a regional average                      #
  # Consider extending this to ensure that include grid squares with stations       #
  # - this may make more sense for regions, for example                             #
  ###################################################################################
  # Convert centre of grid squares to a SpatialPoints object
  # Reset longitude range to -180 to 180 if have crossed the Dateline
  
  lngc[lngc >= 180] <- lngc[lngc >= 180] - 360
  L <- cbind(lngc, latc)
  pts <- sp::SpatialPoints(L, proj4string = sp::CRS(sp::proj4string(wrld_simpl)))
  
  # Which grid points are inside a land map database, and what are their UN codes?
  # Country sqs == land point and matching UN code
  # Region sqs == any land points within grid box
  
  country <- sp::over(pts, wrld_simpl)$UN
  land <- !is.na(country)
  if (tcode == "REG") {
    sqs <- land
  } else {
    sqs <- (land & country == uncode)
  }

  ###################################################################################
  #    Calculate Distances:                                                         #
  ###################################################################################
  # Vectorised calculation - generate lat/long for all pairs of stations
  # The use of cosine distance will generate warnings
  # - these can be ignored but need to reset the diagonal (same station) to zero
  
  lat1 <- matrix(olats, nrow = nstn, ncol = nstn)
  long1 <- matrix(olons, nrow = nstn, ncol = nstn)
  lat2 <- matrix(olats, nrow = nstn, ncol = nstn, byrow = TRUE)
  long2 <- matrix(olons, nrow = nstn, ncol = nstn, byrow = TRUE)
  D <- distance(lat1, long1, lat2, long2)  # vectorised calculation
  diag(D) <- 0
  D <- round(D, 2)  # Round distances to 2dp
  
  # Distances between stations and grid square centres
  # No checking whether a station location is on a centre - would also give a warning
  
  lat1 <- matrix(olats, nrow = nstn, ncol = gridsq)
  long1 <- matrix(olons, nrow = nstn, ncol = gridsq)
  lat2 <- matrix(Dsq[,6], nrow = nstn, ncol = gridsq, byrow = TRUE)
  long2 <- matrix(Dsq[,7], nrow = nstn, ncol = gridsq, byrow = TRUE)
  Dio <- distance(lat1, long1, lat2, long2)
  Dio <- round(Dio, 2)

  # Maximum distance of 2000 km for precipiation indices, 3000 km for temperature
  # Reduced further by actual maximum separation for small networks,
  # but what about large areas, including "regions"?
  # Use this to restrict distance between stations and to grid squares
  # Is this the most appropriate way to limit the weighting for remote stations?
  
  grid_squares_out <- list()
  year_month_out <- list()
  ann_out <- list()
  for (e in ne) {
    Dmax1 <- round(max(D), -2)  # Maximum distance between stations (rounded to 100km)
    if (e %in% 2:4) Dmax2 <- DmaxP else Dmax2 <- DmaxT
    
    Dmax <- min(Dmax1, Dmax2)
    Dn <- pmin(D, Dmax)
    Dion <- pmin(Dio, Dmax)
    
    nyrs <- nye - nyb + 1L                                       # variable number of years
    NCMP <- matrix(NA, nrow = nyrs, ncol = 13)   # empty matrix for region avg, dim nyrsx12
    NT <- matrix(0L, nrow = nyrs, ncol = 13)                     # empty matrix dim nyrsx12
    
    ###################################################################################
    #    Read variogram:                                                              #
    ###################################################################################
    var <- a3 %>% filter(ncmp_index == ele[e])
    
    ###################################################################################
    #    Read index data for all stations:                                            #
    # Instead of assign/get, define list of tables for each station                   #
    ###################################################################################
    # Converting PrAn from percentage back to ratio
    
    NCMP.stn <- vector("list", nstn)
    for (i in 1:nstn) {
      I1 <- a2 %>% dplyr::filter(.data[[station]] == stations[i])
      I1 <- tidyr::pivot_wider(I1, id_cols = tidyselect::all_of(year), names_from = tidyselect::all_of(month),
                               values_from = tidyselect::all_of(ele[e]))
      I1 <- data.frame(I1)
      if (e == 2L) I1[,2:14] <- I1[,2:14] / 100
      if (e == 3L) I1[,2:14] <- I1[,2:14] / 100  # scale to ensure matrix inversion behaves well
      NCMP.stn[[i]] <- I1
    }
    
    ###################################################################################
    # Begins loop over months                                                         #
    ###################################################################################
    grid_squares <- list()
    for (nm in 1:13) {
      
      ###################################################################################
      # Generate variograms for this month for all years                                #
      # Should not result in NA - if it did would end up with all NA upon inversion     #
      # However, taking the approach of dropping entries for missing obs,               #
      # so matrix inversion is still required for each yr/mo                            #
      ###################################################################################
      
      # Copy the variogram best fit function and parameters from input table
      
      s1 <- var[nm, "s"]
      n1 <- var[nm, "n"]
      r1 <- var[nm, "r"]
      f <- get(var[nm, "Function"])
      
      # Calculate inter-station variogram values and set diagonaly to nugget
      # diag(C0) <- 0 # original code set diagonal to zero.
      
      C0 <- f(Dn, n1, r1, s1)
      diag(C0) <- n1
      
      # Calculate station-to-grid square variogram values
      # Keep only the valid grid squares for our country or region
      
      F <- rbind(f(Dion, n1, r1, s1), rep(1, gridsq))
      F <- F[,sqs]
      
      ###################################################################################
      # Loop over years                                                                 #
      ###################################################################################
      
      for (ny in nyb:nye) {
        
        ###################################################################################
        #    Fill vector of index values for all stns for set yr/mo                       #
        ###################################################################################
        # For each station extract the value for this year
        
        z <- ny - nyb + 1            # index of year plus month
        d <- c(rep(NA, nstn), 1)     # Empty vector for index, with last entry set to 1
        for (i in 1:nstn) {
          I1 <- NCMP.stn[[i]]        # Copy of table for this index
          iz <- match(ny, I1[,1])    # Check for correct year within table
          if (!is.na(iz)) d[i] <- I1[iz, nm + 1]  # Copy if year is present
        }
        
        ###################################################################################
        #    Calculates region average of set yr/mo                                       #
        # Do this only using where have valid observations, and only if > 0               #
        ###################################################################################
        
        iobs <- which(!is.na(d))       # Index of contributing stations + end row
        ntot <- length(iobs) - 1L      # Count of number of contributing stations
        NT[z,nm] <- ntot
        if (ntot > 0L) {               # Have contributing stations
          C <- matrix(0, nrow = ntot + 1, ncol = ntot + 1)     # 0 == value for last row/col
          C[1:ntot, 1:ntot] <- C0[iobs[1:ntot], iobs[1:ntot]]  # variogram of valid
          C[1:ntot, ntot+1] <- 1                               # set last col to 1
          C[ntot+1, 1:ntot] <- 1                               # set bottom row to 1
          Cinv <- solve(C)                                     # invert C
          
          # Calculate value for each valid grid square and then area-weighted average
          # It seems here that there is effectively no weight for each grid square, and
          # hence all (sqs) grid squares will have a non-missing value
          # However kriging can generate an error estimate (not calculated here)
          
          Ix <- t(d[iobs]) %*% Cinv %*% F[iobs,]     # Matrix multiplication
          if (e == 2L) Ix <- Ix * 100 # If prec anom ratio (and prec anom?) multiply by 100
          if (e == 3L) Ix <- Ix * 100 # scale PrA so that matrix inversion works
          NCMP[z, nm] <- weighted.mean(Ix, Dsq[sqs, 8]) # Find area average - no NA
        } else {                      # No contributing stations
          Ix <- rep(NA, length(sqs))  # Set all grid sqs to missing
          NCMP[z, nm] <- NA   # Make it clear regional av is also missing
        }
        
        #    Region average calculated. Done!
        # If requested, write the grid square values to CSV file
        
        if (igrid) {
          if (all(is.na(Ix))) X <- cbind(Dsq[sqs, c(1, 6:8)], Index = Ix)
          else X <- cbind(Dsq[sqs, c(1, 6:8)], Index = t(Ix))
          X <- data.frame(X)
          grid_squares[[paste(ny, nm, sep = "_")]] <- X
        }
      }
    }
    if (igrid) {
      grids_df <- dplyr::bind_rows(grid_squares, .id = "year_month")
      grids_df <- tidyr::separate(grids_df, year_month, c("year", "month"), "_")
      grids_df$month <- as.numeric(grids_df$month)
      grids_df <- dplyr::arrange(grids_df, Grid, year, month)
      grid_squares_out[[ele[e]]] <- grids_df
    }
    
    ###################################################################################
    # End loop of years (inner) and months (outer)                                    #
    ###################################################################################
    
    ###################################################################################
    #    Write region average                                                         #
    # Writes the annual value as month == 13                                          #
    # This is the format given in the Guidance and used by P5/P7                      #
    # But useful to also write annual series separately - chronological and ranked    #
    # (The latter was done in P5_Trends_Graphs.R but makes more sense here)           #
    ###################################################################################
    
    X_year_month <- data.frame(Year = rep(nyb:nye, each = 13), Month = rep(1:13, times = nyrs),
                               Index = as.vector(t(NCMP)), No_of_Stns = as.vector(t(NT)), check.names = FALSE)
    year_month_out[[ele[e]]] <- X_year_month
    
    # Round extracted annual values to 3dp (the original file retains the full precision)
    iz <- which(X_year_month[,'Month'] == 13L)
    Xann <- X_year_month[iz, -2]
    Xann[,"Index"] <- round(Xann[,"Index"], 3)
    ann_out[[ele[e]]] <- Xann
  }
  X_year_month <- dplyr::bind_rows(year_month_out, .id = "ncmp_index")
  
  dy <- date()
  attr(X_year_month, "dy") <- dy
  attr(X_year_month, "nstn") <- nstn
  attr(X_year_month, "nyb") <- nyb
  attr(X_year_month, "nye") <- nye
  attr(X_year_month, "tcode") <- tcode
  attr(X_year_month, "tname") <- tname
  attr(X_year_month, "res") <- res
  attr(X_year_month, "uncode") <- uncode
  
  X_ann <- dplyr::bind_rows(ann_out, .id = "ncmp_index")
  attr(X_ann, "dy") <- dy
  attr(X_ann, "nstn") <- nstn
  attr(X_ann, "nyb") <- nyb
  attr(X_ann, "nye") <- nye
  attr(X_ann, "tcode") <- tcode
  attr(X_ann, "tname") <- tname
  attr(X_ann, "res") <- res
  attr(X_ann, "uncode") <- uncode

  out[[paste(tname, "avg", res, "annual", sep = "_")]] <- X_ann
  out[[paste(tname, "region_avg", sep = "_")]] <- X_year_month
  
  if (igrid) {
    grids_df <- dplyr::bind_rows(grid_squares_out, .id = "ncmp_index")
    out[[paste(tname, "grids", sep = "_")]] <- grids_df
  }
  return(out)
}