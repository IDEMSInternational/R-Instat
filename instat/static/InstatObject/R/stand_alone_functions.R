get_default_decimal_places <- function(data) {
  if(is.numeric(data)) {
    min_data <- min(data, na.rm = TRUE)
    if(class(data) %in% "integer" || min_data > 100) {
      return(0)
    }
    else {
      if(min_data > 10) {
        return(1)
      }
      else {  
        return(2) 
      }
    }
  }
  else return(NA)  
}

convert_to_character_matrix <- function(data, format_decimal_places = TRUE, decimal_places) {
  out = matrix(nrow = nrow(data), ncol = ncol(data))
  if(!format_decimal_places) decimal_places=rep(NA, ncol(data))
  else if(missing(decimal_places)) decimal_places = sapply(data, get_default_decimal_places)
  i = 1
  for(curr_col in colnames(data)) {
    if(is.na(decimal_places[i])) {
      out[,i] <- as.character(data[[i]])
    }
    else {
      out[,i] <- as.character(format(data[[i]], nsmall = decimal_places[i]))
    }
    i = i + 1
  }
  colnames(out) <- colnames(data)
  rownames(out) <- rownames(data)
  return(out)
}

next_default_item = function(prefix, existing_names = c(), include_index = TRUE, start_index = 1) {
  if(!is.character(prefix)) stop("prefix must be of type character")
  
  if(!include_index) {
    if(!prefix %in% existing_names) return(prefix)
  }
  
  item_name_exists = TRUE
  start_index = 1
  while(item_name_exists) {
    out = paste0(prefix,start_index)
    if(!out %in% existing_names) {
      item_name_exists = FALSE
    }
    start_index = start_index + 1
  }
  return(out)
}