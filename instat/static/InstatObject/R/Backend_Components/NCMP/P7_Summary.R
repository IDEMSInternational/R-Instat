# December 2020
# These files have been obtained from https://github.com/ET-NCMP/NCMP and modified for use in R-Instat.
# Modifications have been made to the data input and output processes while carefully 
# maintaining consistent calculations processes as in the original files.

# This file is a modified version of P7_Summary.R.

###################################################################################
#                                                                                 #
#    The R-NCMPs package has been developed by the ET-NCMP.                       #
#    P7_Summary.R                                                                 #
#                                                                                 #
#    This program assembles the NCMPs to be sent to WMO.                          #
#                                                                                 #
#    Programmer:                                                                  #
#    Megan Hartwell, McMaster University, Canada                                  #
#    Lucie Vincent, Environment and Climate Change Canada                         #
#    December 2016                                                                #
#    Modified by Justin Peter, Bureau of Meteorology, Australia                   #
#    December 2017                                                                #
#    Added Count Records by Simon Grainger, Bureau of Meteorology, Australia      #
#    March 2018                                                                   #
###################################################################################

p7_summary <- function(a2, a4, a6, nyb, nye, ncmp_folder) {
  
  ###################################################################################
  #    Gathers input info from the user                                             #
  # For clarity, no longer do this as a separate function                           #
  ###################################################################################
  
  # The period for the Summary file is limited by the Region Average period,
  # although the count records can use a different one
  
  ylo <- attr(a4, "nyb")
  yhi <- attr(a4, "nye")
  
  if (missing(nyb)) nyb <- ylo
  if (nyb < ylo || nyb > yhi) stop("Beginning year for summary file period must be between ", ylo, " and ", yhi, ".")

  if (missing(nye)) nye <- yhi
  if (nye < nyb || nye > yhi) stop("End year for summary file period must be between ", nyb, " and ", yhi, ".")
  
  nyrs <- nye - nyb + 1L
  
  ###################################################################################
  # Information for indices to process                                              #
  # Note that the Guidance only requires the extreme warm day and cold nights       #
  # - i.e. TX90p, TN10p Region averages and TXx, TNn and RXday1 absolute records    #
  ###################################################################################
  # Names of input regional average files
  
  tname <- attr(a4, "tname")
  elez <- c("TMA", "PrAn", "PrA", "SPI", "TX90p", "TN10p")
  folder <- "A4_Region_Average"
  filez <- file.path(ncmp_folder, folder, paste(tname, elez, "Region_Avg.csv", sep = "_"))
  optionalz <- c(FALSE, FALSE, FALSE, FALSE, FALSE, FALSE)
  
  # Names of input count record files
  
  eler <- c("TXx", "TNn", "RXday1")
  folder <- "A6_Count_Records"
  filer <- file.path(folder, paste(tname, eler, "Count_Record.csv", sep = "_"))
  optionalr <- c(FALSE, FALSE, FALSE)
  
  # Concatenate these into a single variable to enable a single loop
  
  ele <- c(elez, eler)
  namex <- c(filez, filer)
  optional <- c(optionalz, optionalr)
  
  # Initialise storage for output tables
  # Use dummy tables for merging each diagnostic
  
  X <- data.frame(Year = rep(nyb:nye, each = 13), Month = rep(1:13, times = nyrs))
  X0 <- X
  nrec <- nrow(X)
  Xdum <- data.frame(X0, Index = rep(NA_real_, nrec), Count = rep(0L, nrec))
  
  ###################################################################################
  # Begins loop over diagnostic files                                               #
  ###################################################################################
  
  for (ne in seq_along(ele)) {
    
    # Set column names for this diagnostic
    # These are consistent with P4 and P6 files but not the Guidance
    # This may need to change, as it is arguable that TX90p and TXx are confusing
    # (although these names are ultimately based on the WMO ETCCDI definitions)
    
    if (ne <= 8L) {
      desc <- "Region Average"
      vname1 <- ""
    } else {
      desc <- "Count Record"
      vname1 <- ""
    }
    vnames <- paste(ele[ne], c(vname1, "No of Stns"))
    propervnames <- c("NCMP1", "No of Stns NCMP1",
                      "NCMP2", "No of Stns NCMP2",
                      "NCMP2b", "No of Stns NCMP2b",
                      "NCMP3", "No of Stns NCMP3", 
                      "NCMP4", "No of Stns NCMP4",
                      "NCMP5", "No of Stns NCMP5",
                      "Tmax records", "No of Stns reporting Tmax", 
                      "Tmin records", "No of Stns reporting Tmin",
                      "Precip records", "No of Stns reporting precip")
    
    # Check whether diagnostic has been calculated
    # If not, fill with the dummy table
    # Note that P6_Count_Records.R currently processes all 5 diagnostics at once
    
    if ((ne <= 6 && !ele[ne] %in% a4$ncmp_index) || (ne > 7 && !ele[ne] %in% a6$ncmp_index)) {
      cat(desc, "has not been calculated for", ele[ne], fill = TRUE)
      if (!optional[ne]) {
        cat("Summary file will be filled with missing values", fill = TRUE)
        names(Xdum)[3:4] <- propervnames
        X <- merge(X, Xdum, by = c("Year", "Month"))
        next
      }
    }
    
    # Read in diagnostic, and extract the requested years
    # The Guidance implies rounding to 2dp, but the annual extraction is to 3dp
    # Allowing for extra columns, e.g. planned station index of record counts
    if (ne <= 6) {
      In <- a4 %>% filter(ncmp_index == ele[ne])
      In$ncmp_index <- NULL
    } else {
      In <- a6 %>% filter(ncmp_index == ele[ne])
      In$region <- NULL
      In$ncmp_index <- NULL
      # Remove Count Accum column
      In[[ncol(In)]] <- NULL
    }
    names(In)[3:4] <- vnames
    if (ne <= 8L) In[,3] <- round(In[,3], 3)
    X <- merge(X, In[,1:4], by = c("Year", "Month"), all.x = TRUE)
  }
  
  ###################################################################################
  # Ends loop over diagnostic files                                                 #
  ###################################################################################
  # While by default merge() will sort the output rows, it does so as a character vector
  # Thus the months are in the order 1,10,11,12,13,2,...,9 (in an English locale)
  # Put back into the expected chronological order
  
  ind <- order(X[,"Year"], X[,"Month"])
  
  # Create a header for the Summary file
  # This consists of key metadata used in the analysis
  # The idea of a header, and combining the QC and homogenisation flags, differs from
  # the format in the Guidance, but no information has been lost
  # (unless one can do homogenisation *without* Quality Control, or these vary in time)
  
  desc <- c("Total number of Stations",
            "Climatological period start", "Climatological period end",
            "Temperature Quality Control level", "Precipitation Quality Control level",
            "Region Average grid resolution", "Version")
  vals <- c(attr(a2, "nstn"), attr(a2, "nyb"), attr(a2, "nye"), attr(a2, "qct"), attr(a2, "qcpr"),
            attr(a4, "res"), 2017)
  mess <- paste(desc, vals, sep=" = ")
  
  # Write header and table to single file - generates a warning which can be ignored
  # File has been tested as directly readable by Office 2016 Excel
  
  namex <- paste(tname, nyb, nye, "Summary.csv", sep = "_")
  namex <- file.path(ncmp_folder, namex)
  writeLines(mess, con = namex)
  write.table(X[ind,], file = namex, append = TRUE, row.names = FALSE, sep = ",")
  X <- dplyr::arrange(X, Year, Month)
  return(X)
}