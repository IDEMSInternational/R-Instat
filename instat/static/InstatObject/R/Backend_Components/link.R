# a link can contain multiple ways to link two data frames
link <- R6Class("link",
                       public = list(
                         initialize = function(from_data_frame = "", to_data_frame = "", type = "", link_columns = list()) {
                           self$from_data_frame <- from_data_frame
                           self$to_data_frame <- to_data_frame
                           self$type <- type
                           self$link_columns <- link_columns
                         },
                         from_data_frame = "",
                         to_data_frame = "",
                         # TODO Is type needed anymore?
                         type = "",
                         # remove calculation
                         # replace with list of list of pairs of linking columns
                         # each list of pairs of columns corresponds to a key in the to_data_frame
                         link_columns = list()
                       ),
                       private = list(),
                       active = list()
)

link$set("public", "data_clone", function() {
  ret <- link$new(from_data_frame = self$from_data_frame, to_data_frame = self$to_data_frame,
                  type = self$type, link_columns = self$link_columns)
  return(ret)
}
)

instat_object$set("public", "add_link", function(from_data_frame, to_data_frame, link_pairs, type) {
  if(length(names(link_pairs)) != length(link_pairs)) stop("link_pairs must be a named vector or list.")
  if(!self$link_exists_between(from_data_frame, to_data_frame)) {
    if(!self$is_key(to_data_frame, link_pairs)) {
      message("link columns must be a key in the to_data_frame\nAttempting to create key...")
      self$add_key(to_data_frame, as.character(link_pairs))
      message("New key created")
    }
    new_link <- link$new(from_data_frame = from_data_frame, to_data_frame = to_data_frame, link_columns = list(link_pairs), type = type)
    private$.links[[length(private$.links) + 1]] <- new_link
  }
  else {
    index <- integer(0)
    for(i in 1:length(private$.links)) {
      if(private$.links[[i]]$from_data_frame == from_data_frame && private$.links[[i]]$to_data_frame == to_data_frame) {
        index <- i
        from_on_left <- TRUE
        break
      }
      else if(private$.links[[i]]$from_data_frame == to_data_frame && private$.links[[i]]$to_data_frame == from_data_frame) {
        index <- i
        from_on_left <- FALSE
        break
      }
    }
    # This should never happen because we are inside the Else of link_exists_between
    if(length(index) == 0) stop("link not found")
    
    if(type != private$.links[[index]]$type) stop("Cannot add link of type ", type, ". These data frames are already linked by type: ", private$.links[[index]]$type)
    curr_link_columns <- private$.links[[index]]$link_columns
    curr_num_links <- length(curr_link_columns)
    found <- FALSE
    for(curr_link_pairs in curr_link_columns) {
      # Are these the right checks on the link columns?
      if(from_on_left && length(link_pairs) == length(curr_link_pairs) && (setequal(link_pairs, curr_link_pairs) || setequal(names(link_pairs), names(curr_link_pairs)))) {
        message("A link with these columns already exists. A new link will not be added.")
        found <- TRUE
        break
      }
      else if(!from_on_left && length(link_pairs) == length(curr_link_pairs) && (setequal(link_pairs, names(curr_link_pairs)) || setequal(names(link_pairs), curr_link_pairs))) {
        message("A link with these columns already exists. A new link will not be added.")
        found <- TRUE
        break
      }
    }
    if(!found) {
      if(!self$is_key(to_data_frame, link_pairs)) {
        message("link columns must be a key in the to_data_frame\nAttempting to create key...")
        self$add_key(to_data_frame, as.character(link_pairs))
        message("new key created")
      }
      if(from_on_left) private$.links[[index]]$link_columns[[curr_num_links + 1]] <- link_pairs
      else {
        new_link_pairs <- names(link_pairs)
        names(new_link_pairs) <- link_pairs
        private$.links[[index]]$link_columns[[curr_num_links + 1]] <- new_link_pairs
      }
    }
  }
}
)

instat_object$set("public", "link_exists_from", function(from_data_frame, link_pairs) {
  link_exists <- FALSE
  for(curr_link in private$.links) {
    if(curr_link$from_data_frame == from_data_frame) {
      for(curr_link_pairs in curr_link$link_columns) {
        if(length(link_pairs) == length(curr_link_pairs) && setequal(link_pairs, names(curr_link_pairs))) {
          link_exists <- TRUE
          break
        }
      }
    }
  }
  return(link_exists)
}
)

instat_object$set("public", "get_linked_to_data_name", function(from_data_frame, link_pairs) {
  data_name <- ""
  for(curr_link in private$.links) {
    if(curr_link$from_data_frame == from_data_frame) {
      for(curr_link_pairs in curr_link$link_columns) {
        if(length(link_pairs) == length(curr_link_pairs) && setequal(link_pairs, names(curr_link_pairs))) {
          data_name <- curr_link$to_data_frame
          break
        }
      }
    }
  }
  if(data_name != "") return(data_name)
  else stop("to_data_frame not found")
}
)

instat_object$set("public", "link_exists_between", function(from_data_frame, to_data_frame) {
  return(any(sapply(private$.links, function(link) link$from_data_frame == from_data_frame && link$to_data_frame == to_data_frame))
         || any(sapply(private$.links, function(link) link$from_data_frame == to_data_frame && link$to_data_frame == from_data_frame)))
}
)

instat_object$set("public", "get_link_between", function(from_data_frame, to_data_frame) {
  for(curr_link in private$.links) {
    if((curr_link$from_data_frame == from_data_frame && curr_link$to_data_frame == to_data_frame) || (curr_link$from_data_frame == to_data_frame && curr_link$to_data_frame == from_data_frame)) {
      return(curr_link)
    }
  }
}
)