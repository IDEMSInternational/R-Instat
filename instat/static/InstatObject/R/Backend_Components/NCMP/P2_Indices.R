# December 2020
# These files have been obtained from https://github.com/ET-NCMP/NCMP and modified for use in R-Instat.
# Modifications have been made to the data input and output processes while carefully 
# maintaining consistent calculations processes as in the original files.

# This file is a modified version of P2_Indices.R and Support_Indices.R.

###################################################################################
#                                                                                 #
#    The R-NCMPs package has been developed by the ET-NCMP.                       #
#    P2_Indices.R                                                                 #
#                                                                                 #
#    This program calculates 21 indices defined as the 6 NCMPs by ET-NCMP.        #
#    For further details please refer to the User Manual.                         #
#                                                                                 #
#    Programmers:                                                                 #
#    Megan Hartwell, McMaster University, Canada                                  #
#    Lucie Vincent, Environment and Climate Change Canada                         #
#    December 2016                                                                #
#    Modified by Simon Grainger, Bureau of Meteorology, Australia                 #
#    February 2017 - Cleaned up, code is more "R-like"                            #
#    Modified by John Kennedy, Met Office, UK                                     #
#    June 2017 - removed commented out code                                       #
#    Modified by Simon Grainger, Bureau of Meteorology, Australia                 #
#    March 2018 - Improved handling of missing values, zero climatological rain   #
#                                                                                 #
###################################################################################

# Correction of climdex.pcic function to correctly calculate percent days diagnostics in the
# presence of too few years. This was generating warnings, and causing an unrealistic negative
# bias in the estimated values (a bias *is* expected, but this *was* a miscalculation)
# For ease of use, also circumventing most climdex.pcic wrapper functions

percent.days.op.threshold.mod <- function(ci,freq,type)
{
  stopifnot(inherits(ci,"climdexInput"))
  freq <- match.arg(freq,c("monthly","annual"))
  type <- match.arg(type,c("TN10p","TN90p","TX10p","TX90p"))
  fo <- switch(type,
               TN10p = c("tmin","q10","<"), TN90p = c("tmin","q90",">"),
               TX10p = c("tmax","q10","<"), TX90p = c("tmax","q90",">"))
  vn <- fo[1]
  qn <- fo[2]
  f <- match.fun(fo[3])
  dat <- f(ci@data[[vn]], ci@quantiles[[vn]]$outbase[[qn]][ci@jdays])
  inset <- ci@dates >= ci@base.range[1] & ci@dates <= ci@base.range[2]
  if (sum(inset) > 0L && length(ci@dates) >= 720L) {
    temp.base <- ci@data[[vn]][inset]
    years.base <- as.POSIXlt(ci@dates[inset])$year + 1900L
    years.base.range <- range(years.base)
    byrs <- years.base.range[2] - years.base.range[1] + 1L
    base.thresholds <- ci@quantiles[[vn]]$inbase[[qn]]
    bdim <- dim(base.thresholds)
    dim(base.thresholds) <- c(bdim[1] * bdim[2], bdim[3])
    yday.byr.indices <- ci@jdays[inset] + (years.base - years.base.range[1]) * bdim[1]
    f.result <- f(rep(temp.base, byrs - 1L), base.thresholds[yday.byr.indices,1:(byrs-1)])
    dim(f.result) <- c(length(yday.byr.indices), byrs - 1L)
    dat[inset] <- rowSums(f.result, na.rm = TRUE)/(byrs - 1)
  }
  dat[is.nan(dat)] <- NA
  na.mask <- ifelse(climdex.pcic:::tapply.fast(dat,ci@date.factors[[freq]],
                                               function(x) sum(is.na(x)) > ci@max.missing.days[freq]),NA,1)
  ret <- climdex.pcic:::tapply.fast(dat, ci@date.factors[[freq]], mean, na.rm = TRUE) * 
    100 * na.mask
  ret[is.nan(ret)] <- NA
  ret * ci@namasks[[freq]][[vn]]
}

# df: data.frame will daily data
# station: name of station column in df
# date: name of date column in df
# precip: name of precipitation/rain column in df
# tmax: name of tmax column in df
# tmin: name of tmin column in df
# qct: Quality Control level for temperature data: 0, 1 or 2
# qcpr: Quality Control level for precipitation data: 0, 1 or 2
# nybr: start year for climatological period
# nyer: end year for climatological period
# station_df: data.frame will station metadata
# name: name of station column in station_df (to link with df[[station]])
# lat: name of latitude column in station_df
# lon: name of longitude column in station_df
p2_indices <- function(df, station, date, precip, tmax, tmin, qct = 0, qcpr = 0, nybr = 1981, nyer = 2010,
                       station_df, name, lat, lon) {
  
  ###################################################################################
  # Set variables with key thresholds for climatological reference period           #
  # and for the number of missing days within a month and a year                    #
  # These are values which have been determined by the ET-NCMP for the purposes of  #
  # generating NCMPs and may differ from other standards or guidlines               #
  # ***** DO NOT CHANGE THE VALUE OF THESE VARIABLES *****                          #
  ###################################################################################
  
  stnhi <- 200L  # maximum number of stations
  yrlo <- 1900L  # earliest possible year for reference period
  yrhi <- as.POSIXlt(Sys.time())$year + 1899L # latest possible year == current - 1
  yclo <- 1981L  # recommended start year for climatological period (WMO-1201, 2017)
  ychi <- 2010L  # recommended end year for climatological period (WMO-1201, 2017)
  cthresh <- 20L # number of years required for calculating a valid climatology
  missm <- 10L   # No. of missing days allowable for valid month (WMO-1201, 2017)
  missa <- 36L   # No. of missing days allowable for valid year (no standard)
  
  stopifnot(qct %in% 0:2)
  stopifnot(qcpr %in% 0:2)
  
  yr1 <- yrlo
  yr2 <- yrhi - cthresh + 1L
  if (nybr < yr1 || nybr > yr2) stop("Start year for climatological period must be between ", yr1, " and ", yr2, ".")
  yr1 <- nybr + cthresh - 1L
  yr2 <- yrhi
  if (nyer < yr1 || nyer > yr2) stop("End year for climatological period must be between ", yr1, " and ", yr2, ".")
  
  files <- data.frame(FileName = station_df[[name]],
                      Lat = station_df[[lat]],
                      Long = station_df[[lon]], stringsAsFactors = FALSE)

  stations_data <- as.character(unique(df[[station]]))
  stations_metadata <- as.character(unique(station_df[[station]]))
  if (!all(stations_data %in% stations_metadata)) stop("Station information not available for all stations that appear in data.")
  stations <- stations_data
  nstn <- length(stations)
  
  ###################################################################################
  # Set up miscellaneous variables                                                  #
  ###################################################################################
  
  max.miss <- c(monthly = missm, annual = missa)  # for climdexInput.raw
  
  # Output column names (now standard across CSV files)
  cnames <- c("Year", month_name_english, "Annual")
  
  # Fixed days per month
  Days <- c(31L, 28L, 31L, 30L, 31L, 30L, 31L, 31L, 30L, 31L, 30L, 31L)
  
  namex <- c("TM", "TMA", 
             "PrA", "PrAn", "Pr", "PrR", 
             "SPI", 
             "TX90p", "TN90p", 
             "TX10p", "TN10p", 
             "RXday1_date", "RXday1", "TXx_date", "TXx", "TNx_date", "TNx",
             "TXn_date", "TXn", "TNn_date", "TNn")
  labx <- c("Monthly Mean Temp", "Monthly Mean Temp Anom",
            "Monthly Total Prec Anom", "Monthly Total Prec Anom Norm", "Monthly Total Prec", "Monthly Total Prec Ratio",
            "Standard Prec Index",
            "Warm Days", "Warm Nights",
            "Cold Days", "Cold Nights",
            "Extreme Prec Date", "Extreme Prec", "Extreme Warm Day Date", "Extreme Warm Day", "Extreme Warm Night Date", "Extreme Warm Night",
            "Extreme Cold Day Date", "Extreme Cold Day", "Extreme Cold Night Date", "Extreme Cold Night")

  ###################################################################################
  # Begins loop for reading data files and doing calculations                       #
  ###################################################################################
  
  by_month_stations <- vector(mode = "list", length = nstn)
  names(by_month_stations) <- stations
  for (i in 1:nstn) {

    data <- df %>% dplyr::filter(.data[[station]] == stations[i])
    data <- data.table::data.table(Year = lubridate::year(data[[date]]),
                                   Mo = lubridate::month(data[[date]]),
                                   Day = lubridate::mday(data[[date]]),
                                   Prec = data[[precip]],
                                   Tx = data[[tmax]],
                                   Tn = data[[tmin]]
    )
    
    ###################################################################################
    #    Find mean temperature and monthly values                                     #
    ###################################################################################
    
    Tm <- (data[,"Tx"] + data[,"Tn"])/2.0
    data$Tm <- Tm
    
    # Copy for creating monthly values
    data1 <- data
    data1$Prec[data1$Prec < 1] <- 0  # replace prec less than 1 with 0
    
    # Calculate monthly values where missing days are below the threshold
    # Would be desirable to allow for leap years, but this would be rather harder
    # as need to account for partial months and years 
    
    Month <- data1[,.(
      Pr = ifelse(Days[Mo] - sum(!is.na(Prec)) > missm, NA_real_, sum(Prec, na.rm=TRUE)),
      Tm = ifelse(Days[Mo] - sum(!is.na(Tm)) > missm, NA_real_, mean(Tm, na.rm=TRUE))), by = .(Year, Mo)]
    
    # Calculate annual value where missing days are below the threshold
    Year <- data1[,.(
      Pr.Y = ifelse(365L - sum(!is.na(Prec)) > missa, NA_real_, sum(Prec, na.rm = TRUE)),
      Tm.Y = ifelse(365L - sum(!is.na(Tm)) > missa, NA_real_, mean(Tm, na.rm = TRUE))), by = Year]
    
    # Shape monthly values into table by year
    # This now explicitly uses data.table::dcast >= 1.9.6
    
    Month.Y <- data.table::dcast(Month, Year~Mo, value.var = c("Pr", "Tm"), sep = ".", fill = NA)
    Month.Y <- data.table::merge.data.table(Month.Y, Year, by = "Year")  # No need to sort (in all locales?)
    Month.Y <- round(Month.Y, 2)  # round table to 2 digits
    
    # Having dcast multiple variables, split them back up for further processing
    # This seems to be the only way to evaluate the correct column names
    
    colp <- c("Year", paste("Pr", c(1:12,"Y"), sep = "."))
    Prec <- Month.Y[, colp, with = FALSE]
    colnames(Prec) <- cnames
    
    colt <- c("Year", paste("Tm", c(1:12, "Y"), sep = "."))
    Temp <- Month.Y[, colt, with = FALSE]
    colnames(Temp) <- cnames
    
    by_month <- tidyr::pivot_longer(Prec, cols = 2:14, names_to = "month", names_ptypes = list(month = factor(levels = cnames[2:14])),
                                    values_to = namex[5])
    Temp_stack <- tidyr::pivot_longer(Temp, cols = 2:14, names_to = "month", names_ptypes = list(month = factor(levels = cnames[2:14])),
                                      values_to = namex[1])
    by_month[[namex[1]]] <- Temp_stack[[namex[1]]]

    ###################################################################################
    #    Calculate climatology for mean temp and avg prec                             #
    # Save swapping by using R internal representation of missing values == NA(_real_)#
    # Require 'cthresh' years (recommend == 20) for non-missing value                 #
    ###################################################################################
    
    ref <- (Prec$Year >= nybr & Prec$Year <= nyer)
    Clim.T <- ifelse(colSums(!is.na(Temp[ref,])) >= cthresh,colMeans(Temp[ref,] , na.rm=TRUE) , NA_real_)
    Clim.P <- ifelse(colSums(!is.na(Prec[ref,])) >= cthresh,colMeans(Prec[ref,], na.rm=TRUE) , NA_real_)

    ###################################################################################
    #    Fill zeroes in precipitation climatology                                     #
    # Use full period to calculate an extended precipitation climatology              #
    # and fill zeroes in the shorter standard precipitation climatology if needed.    #
    # if it is still zero, set it to 0.1 mm                                           #
    ###################################################################################
    ref_ext <- (Prec$Year >= 0 & Prec$Year <= 9999)
    Clim_ext.P <- ifelse(colSums(!is.na(Prec[ref_ext,])) >= cthresh, colMeans(Prec[ref_ext,], na.rm = TRUE), NA_real_)
    for (mn in 2:13) {
      if (!is.na(Clim.P[mn])) {
        if (Clim.P[mn] == 0) { 
          cat("Replacing zero in climatology period with average for full series", fill = TRUE)
          Clim.P[mn] <- Clim_ext.P[mn]
          if (Clim.P[mn] == 0) { Clim.P[mn] <- 0.1 }
        }
      }
    }
    
    ###################################################################################
    #    Calculate the temperature anomaly for mean temp                              #
    # Subtract Climatology from each row                                              #
    # Note that NA, column names etc are taken care of, but leave Year unchanged      #
    ###################################################################################
    # Utilises R vector recycling, but need to transpose Temp to do this
    
    Clim.T[1] <- 0
    Temp.Anom <- round(t(t(Temp) - Clim.T), 2)
    Temp.Anom_stack <- tidyr::pivot_longer(as.data.frame(Temp.Anom), cols = 2:14, names_to = "month", 
                                           names_ptypes = list(month = factor(levels = cnames[2:14])),
                                           values_to = namex[2])
    by_month[[namex[2]]] <- Temp.Anom_stack[[namex[2]]]
    
    ###################################################################################
    #    Calculate the precipitation ratios and anomalies                             #
    # This is a bit more difficult to deal with the Year column                       #
    ###################################################################################
    
    Clim.P[1] <- 100
    Prec.Rat <- round(t(t(Prec)/Clim.P*100),1)
    Clim.P[1] <- 0
    Prec.Anom <- round(t(t(Prec) - Clim.P),1)
    Prec.Nor.Anom <- round(t((t(Prec)-Clim.P)/Clim.P*100),1)
    Prec.Nor.Anom[,"Year"] <- Prec.Anom[,"Year"]

    Prec.Rat_stack <- tidyr::pivot_longer(as.data.frame(Prec.Rat), cols = 2:14, names_to = "month",
                                          names_ptypes = list(month = factor(levels = cnames[2:14])),
                                          values_to = namex[6])
    by_month[[namex[6]]] <- Prec.Rat_stack[[namex[6]]]
    Prec.Anom_stack <- tidyr::pivot_longer(as.data.frame(Prec.Anom), cols = 2:14, names_to = "month",
                                          names_ptypes = list(month = factor(levels = cnames[2:14])),
                                          values_to = namex[3])
    by_month[[namex[3]]] <- Prec.Anom_stack[[namex[3]]]
    Prec.Nor.Anom_stack <- tidyr::pivot_longer(as.data.frame(Prec.Nor.Anom), cols = 2:14, names_to = "month",
                                          names_ptypes = list(month = factor(levels = cnames[2:14])),
                                          values_to = namex[4])
    by_month[[namex[4]]] <- Prec.Nor.Anom_stack[[namex[4]]]
    
    ###################################################################################
    #    Calculate the standardized precpitation index                                #
    ###################################################################################
    # Currently replacing zeroes with NA to get the correct log values
    # But this results in zero monthly rainfall with missing SPI - probably not right
    # The PZero variable suggests that this can be better handled
    # Also can investigate definitions suitable for arid climates
    
    nyrs <- nrow(Prec)            # get dim of Prec; Prec monthly total when daily >=1
    Prec2 <- Prec[,-1, with = FALSE] # Exclude Year column
    PZero <- colSums(Prec2 == 0, na.rm = TRUE)/nyrs # fraction of 0 values, by counting
    Prec2[Prec2 == 0] <- NA
    
    A <- log(colMeans(Prec2, na.rm = TRUE)) - colMeans(log(Prec2), na.rm = TRUE)
    Alpha <- ((1+sqrt(1+4*A/3))/(4*A))          # Find alpha parameter for each month
    Beta <- colMeans(Prec2, na.rm = TRUE)/Alpha    # Find  beta parameter for each month
    
    Gamma.Prob <- apply(Prec2, 1, pgamma, shape = Alpha, scale = Beta)   # Implicit over rows
    Prob <- PZero+(1-PZero)*Gamma.Prob         # normalize with prob of zero; bet 0-1
    SPI <- round(qnorm(Prob, mean = 0, sd = 1), 1) # input prob into normal quantile func bet -3-3
    SPI <- cbind(Prec[,.(Year)], t(SPI))
    
    SPI_stack <- tidyr::pivot_longer(SPI, cols = 2:14, names_to = "month",
                                     names_ptypes = list(month = factor(levels = cnames[2:14])),
                                     values_to = namex[7])
    by_month[[namex[7]]] <- SPI_stack[[namex[7]]]

    ###################################################################################
    #    Calculate the daily 10th and 90th % of Tx & Tn                               #
    # Due to a probable error in climdex.pcic:::percent.days.op.threshold when have   #
    # less than the base period, bypass the wrappers and use a modified,              #
    # and hopefully correct, calculation of monthly and annual percentages            #
    ###################################################################################
    
    dd <- data[, paste(Year, Mo, Day, sep = "-")]    # YYYY-MM-DD as string from data.table
    D1 <- PCICt::as.PCICt(dd, cal = "gregorian")         # String represented as Gregorian date
    D <- climdex.pcic::climdexInput.raw(tmax = data[,Tx], tmin = data[,Tn], prec = data[,Prec],
                          tmax.dates = D1, tmin.dates = D1,prec.dates = D1,
                          base.range = c(nybr, nyer), max.missing.days = max.miss)
    dd <- strsplit(levels(D@date.factors$monthly), "-")    # have padded partial years
    Year <- as.integer(sapply(dd,"[[",1))
    Mo <- as.integer(sapply(dd,"[[",2))
    
    # This setup allows for looping over the percentile variables
    # 1 = Warm days, 2 = Warm nights, 3 = Cold days, 4 = Cold nights
    
    for (ix in 8:11) {
      ne <- namex[ix]
      
      # Calculate monthly and annual percentages for this diagnostic - round to 2dp
      NCMP45.M <- round(percent.days.op.threshold.mod(D, "monthly", ne), 2)
      NCMP45.Y <- round(percent.days.op.threshold.mod(D, "annual", ne), 2)
      
      # Combine monthly and annual values by casting monthly table into years
      
      NCMP45 <- data.table::data.table(Year, Mo, NCMP45.M)
      NCMP45 <- data.table::dcast(NCMP45, Year~Mo, value.var = "NCMP45.M")
      NCMP45 <- cbind(NCMP45, NCMP45.Y)
      
      # Write to file with standardised column names
      
      colnames(NCMP45) <- cnames
      NCMP45_stack <- tidyr::pivot_longer(NCMP45, cols = 2:14, names_to = "month",
                                          names_ptypes = list(month = factor(levels = cnames[2:14])),
                                          values_to = namex[ix])
      by_month[[namex[ix]]] <- NCMP45_stack[[namex[ix]]]
    }

    ###################################################################################
    #    Calculate the Highest and Lowest Values Tx, Tn and RX1                       #
    # This is known to cause problems with extended periods of missing data,          #
    # and currently prevents the use of precipitation-only stations                   #
    # This is probably caused by which.max/min() returning integer(0)                 #
    # when no data is valid for that month/year                                       #
    # This also defines monthly extreme if *any* value is present, as opposed to      #
    # applying missing value limits for monthly mean/totals                           #
    # One alternative is to use climdex.pcic, although extracting day of month        #
    # then becomes more difficult                                                     #
    # Another alternative is calculate these alongside the basic monthly indices      #
    # in the data.table object - although that might get a bit messy                  #
    ###################################################################################
    
    # Retain only the Day and value in each row (or add dateMD/DY if used)
    # If extreme monthly precipitation is zero, sensible to set day index to missing
    
    RX1X <- data[,.SD[which.max(Prec),.(Day,Prec)], by = .(Year,Mo)]
    RX1X[,Day := ifelse(RX1X[,Prec] == 0, NA, RX1X[,Day])]
    TxXX <- data[,.SD[which.max(Tx),.(Day,Tx)], by = .(Year,Mo)]
    TnXX <- data[,.SD[which.max(Tn),.(Day,Tn)], by = .(Year,Mo)]
    TxNN <- data[,.SD[which.min(Tx),.(Day,Tx)], by = .(Year,Mo)]
    TnNN <- data[,.SD[which.min(Tn),.(Day,Tn)], by = .(Year,Mo)]
    
    # If no data, set all index values to missing - use a dummy table for all cases
    # This does not appear to be working as intended, given the observed issues
    
    yrs <- range(data[,Year])
    dummy <- data.table::data.table(Year = c(yrs[1]:yrs[2], "xxxx"), t(rep(NA, 13)))
    
    # By putting the 5 records into a list, it is possible to loop over them
    # However, must distinguish between max and min records, and make sure that the
    # order lines up with the indices as defined by "ele"
    
    listVX <- list(RX1X, TxXX, TnXX, TxNN, TnNN)
    rn <- c("HiPr", "HiTx", "HiTn", "LoTx", "LoTn")       # row names for end of table
    colV <- c("Year", paste("Var", 1:12, sep="_"), "Var") # Std column names for variable
    colD <- c("Year", paste("Day", 1:12, sep="_")) # Standard column names for day index
    
    for (ne in 1:5) {
      ix <- ne * 2L + 10L          # offset into "namex" for file names
      VarX <- listVX[[ne]]       # copy of records table
      colnames(VarX)[4] <- "Var" # standard data column name - works in data.table
      if (nrow(VarX) == 0L) {
        dummy[nrow(dummy),1] <- rn[ne]
        Var <- dummy
        Var.D <- dummy
      } else {
        
        # Extract the extreme values for each month and year
        # This should give the actual years for which extreme indices were calculated
        # Also extract month and value for absolute extreme (ie over all days in data)
        
        if (ne <= 3L) {
          MVarX <- VarX[,.SD[which.max(Var)],by=.(Mo)]
          YVarX <- VarX[,.SD[which.max(Var)],by=.(Year)]
          Var.MY <- as.numeric(VarX[,.SD[which.max(Var),.(Mo,Var)]])
        } else {
          MVarX <- VarX[,.SD[which.min(Var)],by=.(Mo)]
          YVarX <- VarX[,.SD[which.min(Var)],by=.(Year)]
          Var.MY <- as.numeric(VarX[,.SD[which.min(Var),.(Mo,Var)]])
        }
        
        # Combine monthly and annual records - do need to worry about the table order
        
        MVarX <- MVarX[order(Mo)]
        VarX.D <- data.table::dcast(VarX, Year~Mo, value.var = c("Day", "Var"),fill = NA)
        VarX.all <- data.table::merge.data.table(VarX.D, YVarX, by = "Year")
        
        # Separate extreme value and day index
        # Day index "Annual" value is the month of extreme value
        
        Var <- VarX.all[,colV, with = FALSE]
        Var.D <- VarX.all[,colD, with = FALSE]
        # DP Replaced month.abb with 1:12 so that annual value can be stacked with month values.
        # DP May need to convert back to month.abb in other scripts that use this.
        Var.D$Annual <- (1:12)[as.matrix(VarX.all[,.(Mo)])]
        
        # Add monthly row to output: year of extreme to index, value to data
        # This is somewhat murky - and putting month/extreme of extreme in "annual"
        
        # DP Removed to avoid merging issues in long format. Overall extremes can be calculated if necessary.
        # xx <- c(rn[ne], as.list(MVarX[,Var]), Var.MY[2])
        # Var <- rbind(Var, xx)
        # xx <- c(rn[ne], as.list(MVarX[,Year]), month.abb[Var.MY[1]])
        # Var.D <- rbind(Var.D, xx)
      }
      
      # Write extreme and day index to file
      colnames(Var) <- cnames
      colnames(Var.D) <- cnames
      Var_stack <- tidyr::pivot_longer(Var, cols = 2:14, names_to = "month",
                                          names_ptypes = list(month = factor(levels = cnames[2:14])),
                                          values_to = namex[ix+1L])
      # DP Sometimes output skips missing years so need to merge instead of adding column.
      if (nrow(Var_stack) != nrow(by_month)) {
        by_month <- dplyr::left_join(by_month, Var_stack, by = c("Year", "month"))
      } else by_month[[namex[ix+1L]]] <- Var_stack[[namex[ix+1L]]]
      
      Var.D_stack <- tidyr::pivot_longer(Var.D, cols = 2:14, names_to = "month",
                                         names_ptypes = list(month = factor(levels = cnames[2:14])),
                                         values_to = namex[ix])
      if (nrow(Var.D_stack) != nrow(by_month)) {
        by_month <- dplyr::left_join(by_month, Var.D_stack, by = c("Year", "month"))
      } else by_month[[namex[ix]]] <- Var.D_stack[[namex[ix]]]
    }
    by_month_stations[[stations[i]]] <- by_month
  }
  by_month <- dplyr::bind_rows(by_month_stations, .id = station)
  for (i in seq_along(namex)) {
    attr(by_month[[namex[i]]], "label") <- labx[i]
  }
  
  # Order columns as in NCMP 1-6 order specified in user manual.
  by_month <- dplyr::select(by_month, c(station, Year, month,
                                        # NCMP1
                                        TM, TMA, 
                                        # NCMP2
                                        Pr, PrA, PrAn, PrR,
                                        # NCMP3
                                        SPI,
                                        # NCMP4
                                        TX90p, TN90p,
                                        # NCMP5
                                        TX10p, TN10p,
                                        # NCMP6
                                        TXn, TXn_date, TNn, TNn_date, RXday1, RXday1_date, TXx, TXx_date, TNx, TNx_date))

  ###################################################################################
  # Ends loop for stations                                                          #
  ###################################################################################
  
  dy <- date()
  attr(by_month, "dy") <- dy
  attr(by_month, "nstn") <- nstn
  attr(by_month, "nybr") <- nybr
  attr(by_month, "nyer") <- nyer
  attr(by_month, "qct") <- qct
  attr(by_month, "qcpr") <- qcpr
  
  return(by_month)
}