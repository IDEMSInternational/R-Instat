# December 2020
# These files have been obtained from https://github.com/ET-NCMP/NCMP and modified for use in R-Instat.
# Modifications have been made to the data input and output processes while carefully 
# maintaining consistent calculations processes as in the original files.

# This file is a modified version of P5_Trends_Graphs.R.

###################################################################################
#                                                                                 #
#    The R-NCMPs package has been developed by the ET-NCMP.                       #
#    P5_Trends_Graphs.R                                                           #
#                                                                                 #
#    This program reads the indices calculated previously and calculates the      #
#    trend for the period specified by the user. It produces a map of each of     #
#    these trends by station.For further details please refer to the User Manual  #
#                                                                                 #
#    Programmers:                                                                 #
#    Megan Hartwell, McMaster University, Canada                                  #
#    Lucie Vincent, Environment and Climate Change Canada                         #
#    December 2016                                                                #
#    Modified by Simon Grainger, Bureau of Meteorology, Australia                 #
#    December 2017 - Fixed bugs introduced in February 2017 version               #
#                                                                                 #
###################################################################################

# a2: data.frame containing 21 indices from p2_indices()
# station: name of station column in a2
# a2_year: name of year column in a2
# month: name of month column in a2
# a4: data.frame containing main output data.frame() from p4_region_average()
# a4_year: name of year column in a4
# a4_month: name of month column in a4
# ne: (optional) which indices to compute region average for, 1 to 8.
# nyba: (optional) start year for region average (if missing will use beginning year from a4)
# nyea: (optional) end year for region average (if missing will use end year from a4)
# nyb: (optional) start year for station trend (if missing will use nyba)
# nye: (optional) end year for station trend (if missing will use nyea)
# station_df: data.frame will station metadata
# name: name of station column in station_df (to link with a2[[station]])
# lat: name of latitude column in station_df
# lon: name of longitude column in station_df
# ncmp_folder: directory to output graphs and maps. ncmp_folder/A5_Trends_Graphs will be created for output.

# ne options:
# 1: NCMP 1, Monthly Mean Temperature Anomaly
# 2: NCMP 2, Monthly Total Precipitation Anomaly Normalized
# 3: NCMP 2, Monthly Total Precipitation Anomaly
# 4: NCMP 3, Standardized Precipitation Index
# 5: NCMP 4, Percentage of Warm Days
# 6: NCMP 4, Percentage of Warm Nights
# 7: NCMP 5, Percentage of Cold Days
# 8: NCMP 5, Percentage of Cold Nights
p5_trends_graphs <- function(a2, station, a2_year, month, a4, a4_year, a4_month, ne = 1:8, nyba, nyea, nyb, nye, ncmp_folder,
                             station_df, name, lat, lon) {
  # The mapdata package is used for the high resolution world map, but the
  # basic "world" database in maps seems equivalent to the wrld_simpl object in maptools
  
  ###################################################################################
  # Set variables with key thresholds for calculating and plotting trends           #
  # These are values which have been determined by the ET-NCMP for the purposes of  #
  # generating NCMPs and may differ from other standards or guidlines               #
  # ***** DO NOT CHANGE THE VALUE OF THESE VARIABLES *****                          #
  ###################################################################################
  
  ylo <- 1900L            # earliest possible year for station trends
  yhi <- as.POSIXlt(Sys.time())$year + 1899L # latest possible year == current - 1
  yalo <- attr(a4, "nyb")    # start year of region average period
  yahi <- attr(a4, "nye")    # end year of region average period
  tthresh <- 11L          # number of years required to calculated a trend

  # Lower trend threshold if the analysis period is too short
  # Hopefully this avoids an infinite loop when defining the trend periods
  
  nyrs <- yahi - yalo + 1L
  if (nyrs < tthresh) {
    warning("Region Average period is too short for reliable trends - resetting threshold", call. = FALSE)
    tthresh <- nyrs
  }
  
  ###################################################################################
  #    Gathers input info from the user                                             #
  # For clarity, no longer do this as a separate function                           #
  ###################################################################################
  
  stations_data <- as.character(unique(a2[[station]]))
  stations_metadata <- as.character(unique(station_df[[name]]))
  if (!all(stations_data %in% stations_metadata)) stop("Station information not available for all stations that appear in data.")
  stations <- stations_data
  nstn <- length(stations)

  # For region average trends the constraint is analysis period
  # Need to modify this by the minimum years threshold (as per climatologies)
  # (and confirm there is no infinite loop)
  
  yr1 <- yalo
  yr2 <- yahi - tthresh + 1L

  if (missing(nyba)) nyba <- yalo
  if (nyba < yr1 || nyba > yr2) stop("Beginning year for region average must be between ", yr1, " and ", yr2)

  yr1 <- nyba + tthresh - 1L
  yr2 <- yahi

  if (missing(nyea)) nyea <- yahi
  if (nyea < yr1 || nyea > yr2) stop("End year for region average must be between ", yr1, " and ", yr2)
  
  # For plotting station trends, allow the full range of years
  # but recommend the current region average trend period
  
  yr1 <- ylo
  yr2 <- yhi - tthresh + 1L
  
  if (missing(nyb)) nyb <- nyba
  if (nyb < yr1 || nyb > yr2) stop("Beginning year for station trend must be between ", yr1, " and ", yr2)
  
  yr1 <- nyb + tthresh - 1L
  yr2 <- yhi

  if (missing(nye)) nye <- nyea
  if (nye < yr1 || nye > yr2) stop("End year for station trend must be between ", yr1, " and ", yr2)
  
  ###################################################################################
  # Set up variables for the 16 station indices to analyse                          #
  ###################################################################################
  
  ncmpn <- c(1L, 2L, 3L, 6L, 5L, 4L, 5L, 4L, 6L, 6L, 6L, 6L, 1L, 2L, 2L, 2L)
  ntrend <- length(ncmpn)  # number of indices to analyse
  iext <- (ncmpn == 6L)    # which indices are extremes indices
  
  # Element relating to NCMP Index
  
  ele2 <- c("TMA", "PrAn", "SPI", "RXday1", "TX10p", "TX90p", "TN10p", "TN90p",
            "TXn", "TXx", "TNn", "TNx", "TM", "Pr", "PrA", "PrR")
  
  # Descriptive title relating to NCMP Index
  
  ele3 <- c("Annual Mean Temp Anom (TMA)", "Ann Tot Prec Anom Norm (PrAn)",
            "Standard Prec Index (SPI)", "Extreme Prec (RXday1)",
            "Cold Days (# of tmax < 10 perc)", "Warm Days (# of tmax > 90 perc)",
            "Cold Nights (# of tmin < 10 perc)", "Warm Nights (# of tmin > 90 perc)",
            "Extreme Cold Day (TXn)", "Extreme Warm Day (TXx)",
            "Extreme Cold Night (TNn)", "Extreme Warm Night (TNx)",
            "Annual Mean Temp (TM)", "Annual Total Prec (Pr)",
            "Annual Total Prec Anom (PrAn)", "Annual Total Prec Ratio (PrR)")
  
  ###################################################################################
  #    Read the modified station list                                               #
  ###################################################################################
  # With the number of stations already set, just need to extract the names
  
  files <- data.frame(Station = station_df[[name]],
                      Lat = station_df[[lat]],
                      Long = station_df[[lon]], stringsAsFactors = FALSE)
  # Ensure stations are in same order as in the data so that calculations match up.
  files <- files[match(stations, files$Station), ]
  Station <- files$Station
  
  # Output table of trend values
  
  X <- data.frame(Station,
                  NA_real_, "?", NA_real_, "?", NA_real_, "?", NA_real_, "?",
                  NA_real_, "?", NA_real_, "?", NA_real_, "?", NA_real_, "?",
                  NA_real_, "?", NA_real_, "?", NA_real_, "?", NA_real_, "?",
                  NA_real_, "?", NA_real_, "?", NA_real_, "?", NA_real_, "?", 
                  stringsAsFactors = FALSE)
  names(X) <- c("Station", as.vector(t(matrix(c(ele2, paste(ele2, "S", sep = "_")), ncol = 2))))
  
  ###################################################################################
  # Information for plots                                                           #
  # Currently only plotting the first 12, but will add the remainder                #
  # Also determining the range of the monthly means from the annual range    #
  ###################################################################################
  
  ymin <- c(-4, -50, -4, NA, rep(0,  4), rep(NA, 8))
  ymax <- c( 4,  50,  4, NA, rep(25, 4), rep(NA, 8))
  ylabel <- c("deg C", "%", "no units", "mm", rep("%", 4), rep("deg C", 5), "mm", "mm", "%")
  
  # Titles of graphs - use descriptive form in 'ele3'
  
  title <- paste("(", letters[1:ntrend], ") ", gsub("_", " ", ele3), sep = "")
  
  # Output PDF file names by station
  ncmp_folder <- file.path(ncmp_folder, "A5_Trends_Graphs")
  folder2 <- c("Graphs_Annual_Station", "Maps_Annual_Station", "Graphs_Annual_Region")
  nybt <- c(nyb, nyb, nyba)
  nyet <- c(nye, nye, nyea)
  odirs <- file.path(ncmp_folder, paste(folder2, nybt, nyet, sep = "_"))  # adds separator "/"
  
  # list of data frames to output
  output_data <- list()
  
  for (dname in odirs) dir.create(dname, recursive = TRUE)
  
  namep <- file.path(odirs[1], paste(Station, "_annual.pdf", sep = ""))
  
  sq <- seq(from = 2, to = ntrend * 2, by = 2) # sequence of even numbers
  
  ###################################################################################
  # Begins loop for station trends                                                  #
  ###################################################################################
  
  a2[[a2_year]] <- as.integer(a2[[a2_year]])
  for (i in 1:nstn) {
    # Open PDF for plots
    
    pdf(namep[i], width = 7, height = 5)
    par(mfrow = c(2,2), mar = c(3, 3, 2, 0.5) + 0.1, mgp = c(2, 0.5, 0), tcl = -0.25, las = 1)
    
    ###################################################################################
    # Begins loop for indices                                                         #
    ###################################################################################
    
    trend <- rep(NA, ntrend)  # store annual estimated trend
    pval <- rep(NA, ntrend)   # store annual estimated p-value

    a2_station <- a2 %>% dplyr::filter(.data[[station]] == stations[i])
    for (j in 1:ntrend) {
      
      In <- tidyr::pivot_wider(a2_station, id_cols = tidyselect::all_of(a2_year), names_from = tidyselect::all_of(month),
                               values_from = tidyselect::all_of(ele2[j]))
      In <- data.frame(In)
      # Calculate annual trends, using the Zhang method, if have enough data
      # The commented out code is for linear least squares trend
      
      ref <- (In[[a2_year]] >= nyb & In[[a2_year]] <= nye)  # Select trend years
      if (sum(!is.na(In[ref, 'Annual'])) >= tthresh) {
        q <- zyp::zyp.trend.vector(In[ref,'Annual'], In[ref,a2_year], method = 'zhang')
        trend[j] <- q['trendp']         # Extract trend over period to vector
        pval[j] <- q['sig']             # Extract p-value to vector
        #      lq <- lm(Annual ~ Year,In,ref)  # Linear best fit
        #      q <- coef(summary(lq))          # Extract coefficients
        #      trend[j] <- q[2,1]*nyrs         # Trend per year times number of years
        #      pval[j] <- q[2,4]
      }
      
      # Plot annual values for index (currently the first 12 only)
      # Allow for dynamic range for any variable by setting the default value to NA
      # RX1day is a special case - lower limit is zero, upper is set to 50 above
      
      if (j <= 12L) {
        if (!is.na(ymin[j])) {
          ylim <- c(ymin[j], ymax[j])
        } else if (ele2[j] == 'RXday1') {
          ylim <- c(0, ceiling(max(In[ref,'Annual'], na.rm = TRUE) / 50) * 50)
        } else {
          yrng <- range(In[ref,'Annual'], na.rm = TRUE)
          ylim <- c(floor(yrng[1]), ceiling(yrng[2]))  # expanded to nearest integer
        }
        plot(In[ref,a2_year], In[ref,'Annual'], xlab = "Year", ylab = ylabel[j], main = title[j],
             col = "Blue", type = "l", ylim = ylim, yaxs = "i")
        
        # Only plot trend line if it has been estimated
        
        if (!is.na(trend[j])) {
          abline(q[c('intercept', 'trend')], col = "Red", lty = 2)
          #        abline(q[,1],col="Red",lty=2)
        }
      }
    }
    
    ###################################################################################
    # Ends loop for calculating trends for indices                                    #
    ###################################################################################
    # Close PDF file
    
    dev.off()
    
    # Copy trend and p-value into output table
    # Currently converting p-value into "y"/"n" significance flag - should this be changed?
    
    X[i, sq] <- round(trend, 2)
    X[i, sq + 1] <- ifelse(is.na(pval), "?", ifelse(pval < 0.05, "y", "n"))
  }
  
  ###################################################################################
  # Ends loop for stations                                                          #
  ###################################################################################
  
  ###################################################################################
  #    Write station annual trends (over period) and significance to file           #
  # Consider separating as per Region Averages (and now Count Records)              #
  ###################################################################################
  
  X_trend <- tidyr::pivot_longer(X, cols = seq(2, 32, 2), names_to = "ncmp_index",
                                 values_to = "trend")
  X_trend <- X_trend %>% select(Station, ncmp_index, trend)
  X_pvalue <- tidyr::pivot_longer(X, cols = seq(3, 33, 2), names_to = "ncmp_index",
                                  values_to = "signif")
  X_out <- X_trend
  X_out$signif <- X_pvalue$signif
  
  output_data[[paste("stn", "Trends", nyb, nye, "Annual", sep = "_")]] <- X_out

  ###################################################################################
  # Map annual trends by station                                                    #
  ###################################################################################
  # Add station lat/lon back into trends
  
  Dt <- cbind(files[1:nstn,], X[,-1])
  
  # Note that have enforced -180 <= longitudes <= 180 in modified station file
  # to work generally with the maps package and the Greenwich Meridian
  # But this means tackling the Dateline - can use the "world2" map here
  
  lonrng <- range(Dt[,3])
  if (lonrng[2] - lonrng[1] > 180) {
    ind <- which(Dt[,3] < 0)        # should be at least 1
    Dt[ind, 3] <- Dt[ind, 3] + 360  # needed since world2 map has range 0-360
    xlim <- c(ceiling(lonrng[2]), floor(lonrng[1]) + 360)
    wmap <- "world2"
  } else {
    xlim <- c(floor(lonrng[1]), ceiling(lonrng[2]))
    wmap <- "world"
  }
  latrng <- range(Dt[,2])
  ylim <- c(floor(latrng[1]), ceiling(latrng[2]))
  
  # Names of maps produced - why JPEG and not PDF as per other graphs?
  mapf <- file.path(odirs[2], paste("Map_", c("Stns",ele2), "_Annual.jpg", sep = ""))
  
  # Prec normalised anomaly (2) is %
  # Need to check/set the units for the last 4 indices
  
  uts <- c("Deg C", "%", "no units", "mm", rep(c("%", "Deg C", NA), each = 4))
  
  ###################################################################################
  #    Functions for size colour and direction of triangles for mapping             #
  # These are all vectorised, so should be able to call once for each graph         #
  # Set up size divisions and colours for triangles by index                        #
  # Missing values => NA => no triangle                                             #
  ###################################################################################
  # Are the symbol colours being reconsidered?
  # The 'multiple' for the last 4 indices will need to be tested
  
  multiple <- c(1, 10, 1, 10, 3, 3, 3, 3, 2, 2, 2, 2, 1, 50, 50, 10)    
  colup <- c("red", rep("darkgreen", 3), rep("red", 9), rep("darkgreen", 3))
  coldown <- ifelse(colup == "red", "blue", "tan4")  # consistently match colup
  
  Size <- function(x)      # input: trend, output: size with limit (seems to work)
  {pmin(trunc(abs(x) / multiple[i]) + 1, 3)}
  
  Type <- function(x)      # input: trend, output: symbol triangle up/down
  {ifelse(x >= 0, 24, 25)}
  
  Colour <- function(x, i)  # input: trend, index, output colour
  {ifelse(x >= 0, colup[i], coldown[i])}
  
  Back <- function(x, y, i)  # input: trend, signif, index, output: fill if signif
  {ifelse(y == 'y', Colour(x,i), "white")} 
  
  ###################################################################################
  #    Map Stations                                                                 #
  # Now using the standard resolution world map instead of high resolution          #
  ###################################################################################
  
  # Plot the station locations
  
  jpeg(mapf[1])
  maps::map(wmap, xlim = xlim, ylim = ylim, col = "gray80", fill = TRUE)  # grey fill of continents
  points(Dt[,3], Dt[,2], pch = 16, col = "Red", cex = 1.0)          # dots of lat/long (check size)
  title(main = "Stn locations")                                     # map title
  dev.off()
  
  # Changed to plot all (16) indices - need to test the last 4
  # The plot titles may need modification
  
  for (i in 1:ntrend) {
    S <- Size(Dt[, 2 * i + 2])               # Size of all triangles
    Ty <- Type(Dt[, 2 * i + 2])              # Type (up/down) of all triangles
    Cr <- Colour(Dt[, 2 * i + 2], i)          # Colour of all triangles
    Bg <- Back(Dt[, 2 * i + 2],Dt[,2 * i + 3], i) # Fill of all triangles (if significant)
    
    jpeg(mapf[i + 1])
    maps::map(wmap, xlim = xlim, ylim = ylim, col = "gray80", fill = TRUE)
    title(main = title[i])
    points(Dt[,3], Dt[,2], pch = Ty, col = Cr, bg = Bg, cex = 0.4 * S + 0.9, lwd = 2)
    
    # Legend only shows the filled triangles
    # Consider the text size 'cex'
    
    S <- 0.4 * c(2:0, 0:2) + 0.9
    Cr <- rep(c(colup[i], coldown[i]), each = 3)
    Ty <- rep(24:25, each = 3)
    n1 <- c(Inf, 2:-2)
    n2 <- c(2:-2, -Inf)
    lT <- paste(n2 * multiple[i], "< x <", n1 * multiple[i])
    legend("topleft", legend = lT, title = uts[i], pch = Ty, col = Cr, pt.cex = S, cex = 0.8, pt.bg = Cr)
    dev.off()
  }

  ###################################################################################
  # Calculate monthly trends for regional averages                                  #
  ###################################################################################
  
  # Element relating to NCMP Index
  
  ele <- c("TMA", "PrAn", "PrA", "SPI", "TX90p", "TN90p", "TX10p", "TN10p")
  
  # Names of input regional average files
  
  tname <- attr(a4, "tname")

  # Names of output regional average graphs
  
  namep <- file.path(odirs[3], paste(tname, ele, "Annual.pdf", sep = "_"))
  
  # Titles of graphs
  
  title <- c("Mean Temperature Anom (TMA)", "Total Precipitation Anom Norm (PrAn)",
             "Total Precipitation Anom (PrA)", "Standard Prec Index (SPI)",
             "% Warm Days (tmax > 90th percentile)", "% Warm Nights (tmin > 90th percentile)",
             "% Cold Days (tmax < 10th percentile)", "% Cold Nights (tmin < 10th percentile)")
  
  # Range for graphs - need to allow the Prec Anom (at least) to vary
  # (although the issue might be with the Prec Anom estimation)
  
  ymin <- c(-4, -50, NA, -2, rep(0, 4))
  ymax <- c(4, 50, NA, 2, rep(25, 4))
  ylabel <- c("deg C", "%", "mm", "no units", rep("%", 4)) # Labels for y axis
  
  ###################################################################################
  # Begins loop for indices                                                         #
  ###################################################################################
  
  region_trends_out <- list()
  for (i in ne) {
    # Output data.frame for trend and significance
    # Changed column names for consistency with other output tables
    
    X <- data.frame(title[i],
                    NA_real_, "?", NA_real_, "?", NA_real_, "?", NA_real_, "?",
                    NA_real_, "?", NA_real_, "?", NA_real_, "?", NA_real_, "?",
                    NA_real_, "?", NA_real_, "?", NA_real_, "?", NA_real_, "?",
                    NA_real_, "?",
                    stringsAsFactors = FALSE)
    cnames <- c(month_name_english, "Annual")
    names(X) <- c("NCMP", as.vector(t(matrix(c(cnames, paste(cnames, "S", sep = "_")), ncol = 2))))
    
    sq <- seq(from = 2, to = 26, by = 2) # sequence of even numbers
    
    # Read in regional average data for all months for this index
    
    In <- a4 %>% filter(ncmp_index == ele[i])
    if (nrow(In) == 0) cat("Regional average has not yet been calculated for ", ele[i], "in A4 - skipping", fill = TRUE)

    trend <- rep(NA, 13)  # store monthly estimated trend over period
    pval <- rep(NA, 13)   # store monthly estimated p-value
    
    # Calculations for trends by month
    # Although have enforced a minimum period for trend analysis,
    # allow for missing values generated by no station data
    
    for (j in 1:13) {
      ref <- which(In[[a4_year]] >= nyba & In[[a4_year]] <= nyea & In[[a4_month]] == j)
      if (sum(!is.na(In[ref, 'Index'])) >= tthresh) {
        q <- zyp::zyp.trend.vector(In[ref, 'Index'], In[ref, a4_year], method = 'zhang')
        trend[j] <- q['trendp']         # Extract trend over period to vector
        pval[j] <- q['sig']             # Extract p-value to vector
        #      lq <- lm(Index ~ Year,In,ref)   # Linear best fit
        #      q <- coef(summary(lq))          # Extract coefficients
        #      trend[j] <- q[2,1]*nyra         # Trend per year times number of years
        #      pval[j] <- q[2,4]
      }
    }
    
    # Copy trend and p-value into output table
    # Currently converting p-value into "y"/"n" significance flag - should this be changed?
    
    X[1, sq] <- round(trend, 2)
    X[1, sq + 1] <- ifelse(is.na(pval), "?", ifelse(pval < 0.05, "y", "n"))
    
    X_trend <- tidyr::pivot_longer(X, cols = seq(2, 26, 2), names_to = "month",
                                   values_to = "trend")
    X_trend <- X_trend %>% select(NCMP, month, trend)
    X_pvalue <- tidyr::pivot_longer(X, cols = seq(3, 27, 2), names_to = "month",
                                    values_to = "signif")
    X <- X_trend
    X$signif <- X_pvalue$signif
    
    region_trends_out[[ele[i]]] <- X
    
    # Plot annual series and trend
    # These are preserved as the last index in the loop (j == 13)
    
    pdf(namep[i])
    if (!is.na(ymin[i])) {
      ylim <- c(ymin[i], ymax[i])
    } else {
      yrng <- range(In[ref,'Index'], na.rm = TRUE)
      ylim <- c(floor(yrng[1]), ceiling(yrng[2]))
    }
    plot(In[ref, a4_year],In[ref, 'Index'], type = "l", col = "Blue", ylim = ylim, yaxs = "i",
         xlab = "Year", ylab = ylabel[i], main = title[i], las = 1)
    if (!is.na(trend[j])) {  # Add trend line if calculated
      abline(q[c("intercept","trend")], col = "Red", lty = 2)
      #    abline(q[,1],col="Red",lty=2)
    }
    dev.off()
  }
  X <- dplyr::bind_rows(region_trends_out, .id = "ncmp_index")
  output_data[[paste(tname, "Trends", nyb, nye, "Region", "Avg", sep = "_")]] <- X
  
  ###################################################################################
  # Ends loop for calculating and plotting regional average trends                  #
  ###################################################################################
  
  ###################################################################################
  #    Write regional average trends (over period) and significance to file         #
  ###################################################################################
  
  return(output_data)
}