#==================================================================================================
# GRIDDED CPT FORMAT TO TABULAR
#' @title Transform domain gridded data to tabular.
#' @name SST_domain
#' @author Stephen 2015 (AMI)

#' @description \code{SST_domain} 
#' Creates a dataframe of X-variables data spanning a chosen domain 
#' 
#' @param data (list), domain (vector), W_E (Logical). 
#' 
#' @param domain = c('min_lat','max_lat', 'min_lon', 'max_lon') , W_E Default = FALSE (whether 
#' domain crosses Greenwich Meridian)
#  
#' @examples
#' > Ghana_domain <- Climate$SST_domain(data, c(-40.0, 4.0, 10.0, 325.0))
#' @return return tabular data for the specified domain
#' 

#Extracting years
climate$methods(SST_domain = function(data, domain, W_E = FALSE){
  options(warn=-1)
  dat2 <- as.data.frame(t(data[3,])) # row containing the date
  end_year <- max(as.numeric(substr(dat2[,1], 1, 4)), na.rm=T)
  start_year <-  min(as.numeric(substr(dat2[,1], 1, 4)), na.rm=T)
  
  year_data <- 5 #row where observations begins
  lat_number <- dim(as.data.frame(unique(data[,1])))[1] - year_data
  lon <- as.numeric(t(data[5,2:ncol(data)]))
  lat <- as.numeric(as.character(data[(year_data + 1):(lat_number + year_data),1]))
  
  duration <- end_year-start_year + 1
  pb <- txtProgressBar(min = 0, max = duration, style = 3) # progress bar for the main loop
  for (k in 1:duration){
    nam <- paste("year", start_year + k-1, sep = "_")
    g=''
    year0 <- matrix(,nrow = length(lat), ncol = length(lon))
    for (i in 1:length(lat)){
      for (j in 1:length(lon)){
        dat = as.numeric(as.character(data[year_data+i, j+1]))
        year0[i,j] = dat
        j=j+1
      } 
      i=i+1
    }
    k=k+1
    year <- as.data.frame(t(year0))
    year <- stack(year)
    year_data <- year_data + length(lat) + 2
    g <- as.numeric(year$values)
    assign(nam, g)
    
    # progress bar
    close(pb)
    setTxtProgressBar(pb, k)
    Sys.sleep(0.1)
  }
  
  var_names <- paste("year", start_year: end_year, sep = "_")
  data_all <- mget(var_names)
  z <- as.data.frame(data_all)
  yy <- as.data.frame(z)
  
  #labels
  
  longitude <- rep(lon, length(lat))
  latitude <- rep(lat, each = length(lon))
  yy <- cbind(latitude, longitude, yy)
  
  # Choosing the domain of interest
  assignVec <- Vectorize("assign",c("x","value"))
  assignVec(c('min_lat','max_lat', 'min_lon', 'max_lon'),domain,envir = .GlobalEnv)
  
  #W_E <-  TRUE # Domain crossing GMT line eg Ghana spans longigitude (325 to 10)
  
  domain_data0 <- if(W_E){
    subset(yy, (yy$lon <= min_lon | yy$lon >= max_lon)& (yy$lat >= min_lat & yy$lat <= max_lat))
  } else {
    subset(yy, (yy$lon >= min_lon & yy$lon <= max_lon)& (yy$lat >= min_lat & yy$lat <= max_lat))
  }
  
  domain_data<- as.data.frame(t(domain_data0[,1:ncol(domain_data0)])) #Final dataset
  return(domain_data)
}
)
