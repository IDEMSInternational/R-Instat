# A link is a relationship between two data frames
# from_data_frame : character - the name of the first data frame of the link
# to_data_frame   : character - the name of the second data frame of the link
# type            : character - the type of link e.g. "keyed"
# link_columns    : list      - a list where each element defines how the data frames are linked
#                               It is a list because two data frames may be linked in different ways
#                               Each element of the list is a named character vector 
#                               where the name-element pairs of the vector define linking columns between the data frames
#                               the name is the name of column in from_data_frame
#                               the element is the corresponding name of a column in to_data_frame
link <- R6::R6Class("link",
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

link$set("public", "data_clone", function(...) {
  ret <- link$new(from_data_frame = self$from_data_frame, to_data_frame = self$to_data_frame,
                  type = self$type, link_columns = self$link_columns)
  return(ret)
}
)

link$set("public", "rename_data_frame_in_link", function(old_data_name, new_data_name) {
  if(self$from_data_frame == old_data_name) self$from_data_frame <- new_data_name
  if(self$to_data_frame == old_data_name) self$to_data_frame <- new_data_name
}
)

link$set("public", "rename_column_in_link", function(data_name, old_column_name, new_column_name) {
  print(self$link_columns)
  if(self$from_data_frame == data_name) {
    for(i in seq_along(self$link_columns)) {
      names(self$link_columns[[i]])[which(old_column_name %in% names(self$link_columns[[i]]))] <- new_column_name
    }
  }
  if(self$to_data_frame == data_name) {
    for(i in seq_along(self$link_columns)) {
      self$link_columns[[i]][which(old_column_name %in% self$link_columns[[i]])] <- new_column_name
    }
  }
}
)

DataBook$set("public", "update_links_rename_data_frame", function(old_data_name, new_data_name) {
  for(i in seq_along(private$.links)) {
    private$.links[[i]]$rename_data_frame_in_link(old_data_name, new_data_name)
  }
}
)

DataBook$set("public", "update_links_rename_column", function(data_name, old_column_name, new_column_name) {
  for(i in seq_along(private$.links)) {
    private$.links[[i]]$rename_column_in_link(data_name, old_column_name, new_column_name)
  }
}
)

DataBook$set("public", "add_link", function(from_data_frame, to_data_frame, link_pairs, type, link_name) {
  if(length(names(link_pairs)) != length(link_pairs)) stop("link_pairs must be a named vector or list.")
  if(!self$link_exists_between(from_data_frame, to_data_frame)) {
    # This means when creating a link to single value data frame, there will be no key in to_data_frame
    # Will this cause any issues?
    if(length(link_pairs) > 0 && !self$is_key(to_data_frame, link_pairs)) {
      message("link columns must be a key in the to_data_frame\nAttempting to create key...")
      self$add_key(to_data_frame, as.character(link_pairs))
      message("New key created")
    }
    new_link <- link$new(from_data_frame = from_data_frame, to_data_frame = to_data_frame, link_columns = list(link_pairs), type = type)
    if(missing(link_name)) link_name <- next_default_item("link", names(private$.links))
    if(link_name %in% names(private$.links)) warning("A link called ", link_name, " already exists. It wil be replaced.")
    private$.links[[link_name]] <- new_link
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
      if(from_on_left && length(link_pairs) == length(curr_link_pairs) && setequal(names(link_pairs), names(curr_link_pairs))) {
        message("A link with these columns already exists. A new link will not be added.")
        found <- TRUE
        break
      }
      else if(!from_on_left && length(link_pairs) == length(curr_link_pairs) && (setequal(link_pairs, names(curr_link_pairs)))) {
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
  if (from_data_frame != to_data_frame){
    cat(paste("Link name:", link_name),
        paste("From data frame:", from_data_frame),
        paste("To data frame:", to_data_frame),
        paste("Link columns:", paste(names(link_pairs), "=", link_pairs, collapse = ", ")),
        sep = "\n")
  }
}
)

DataBook$set("public", "get_link_names", function(data_name, include_overall = TRUE, include, exclude, include_empty = FALSE, as_list = FALSE, excluded_items = c(), exclude_self_links = TRUE) {
  if(exclude_self_links) {
    out <- c()
    i <- 1
    for(link in private$.links) {
      if(link$from_data_frame != link$to_data_frame) out <- c(out, names(private$.links)[i])
      i <- i + 1
    }
  }
  else out <- names(private$.links)
  if(as_list) {
    lst <- list()
    lst[[overall_label]] <- out
    return(lst)
  }
  else return(out)
}
)

DataBook$set("public", "link_exists_from", function(curr_data_frame, link_pairs) {
  link_exists <- FALSE
  for(curr_link in private$.links) {
    if(curr_link$from_data_frame == curr_data_frame) {
      for(curr_link_pairs in curr_link$link_columns) {
        if(length(link_pairs) == length(curr_link_pairs) && setequal(link_pairs, names(curr_link_pairs))) {
          return(TRUE)
          break
        }
      }
    }
  }
  return(FALSE)
}
)

DataBook$set("public", "link_exists_from_by_to", function(first_data_frame, link_pairs, second_data_frame) {
  link_exists <- FALSE
  for(curr_link in private$.links) {
    if(curr_link$from_data_frame == first_data_frame && curr_link$to_data_frame == second_data_frame) {
      for(curr_link_pairs in curr_link$link_columns) {
        if(length(link_pairs) == length(curr_link_pairs) && setequal(link_pairs, names(curr_link_pairs))) {
          return(TRUE)
          break
        }
      }
    }
  }
  return(FALSE)
}
)

DataBook$set("public", "get_linked_to_data_name", function(from_data_frame, link_cols = c(), include_self = FALSE) {
  out <- c()
  if(include_self) out <- c(out, from_data_frame)
  for(curr_link in private$.links) {
    if(curr_link$from_data_frame == from_data_frame) {
      if(length(link_cols) == 0) {
        out <- c(out, curr_link$to_data_frame)
      }
      else {
        for(curr_link_pairs in curr_link$link_columns) {
          if(length(link_cols) == length(curr_link_pairs) && setequal(link_cols, names(curr_link_pairs))) {
            out <- c(out, curr_link$to_data_frame)
          }
        }
      }
    }
  }
  return(unique(out))
}
)

DataBook$set("public", "get_linked_to_definition", function(from_data_frame, link_pairs) {
  to_data_name <- self$get_linked_to_data_name(from_data_frame, link_pairs)
  if(length(to_data_name) > 0) {
    # TODO what happens if there is more than 1?
    to_data_name <- to_data_name[1]
    curr_link <- self$get_link_between(from_data_frame, to_data_name)
    for(curr_link in private$.links) {
      for(curr_link_pairs in curr_link$link_columns) {
        if(length(link_pairs) == length(curr_link_pairs) && setequal(link_pairs, names(curr_link_pairs))) {
          return(list(to_data_name, as.vector(curr_link_pairs[link_pairs])))
        }
      }
    }
  }
  return(list())
}
)

DataBook$set("public", "get_possible_linked_to_defintion", function(from_data_frame, link_pairs) {
  def <- self$get_linked_to_definition(from_data_frame, link_pairs)
  if(length(def) != 0) return(def)
  else {
    prev_data_links <- list(list(from_data_frame, link_pairs))
    continue <- TRUE
    while(continue) {
      curr_data_links <- prev_data_links
      curr_data_names <- sapply(curr_data_links, function(x) x[[1]])
      for(to_data_name in self$get_data_names()) {
        i = 1
        for(curr_from_data_frame in curr_data_names) {
          curr_link_cols <- self$link_between_containing(curr_from_data_frame, curr_data_links[[i]][[2]], to_data_name)
          # Is it enough to check unqiue data frames?
          if(length(curr_link_cols) != 0 && !(to_data_name %in% sapply(curr_data_links, function(x) x[[1]]))) {
            curr_data_links[[length(curr_data_links) + 1]] <- list(to_data_name, curr_link_cols)
          }
          i = i + 1
        }
      }
      if(length(prev_data_links) != length(curr_data_links)) {
        curr_data_names <- sapply(curr_data_links, function(x) x[[1]])
        prev_data_names <- sapply(prev_data_links, function(x) x[[1]])
        for(i in seq_along(curr_data_names)) {
          if(curr_data_names[i] %in% setdiff(curr_data_names, prev_data_names)) {
            def <- self$get_linked_to_definition(curr_data_names[i], curr_data_links[[i]][[2]])
            if(length(def) > 0) return(def)
          }
        }
        prev_data_links <- curr_data_links
      }
      else continue <- FALSE
    }
    return(c())
  }
}
)

DataBook$set("public", "get_equivalent_columns", function(from_data_name, columns, to_data_name) {
  if(from_data_name == to_data_name) equivalent_columns <- columns
  else equivalent_columns <- self$link_between_containing(from_data_name, columns, to_data_name)
  if(length(equivalent_columns) != 0) return(equivalent_columns)
  else {
    prev_data_links <- list(list(from_data_name, columns))
    continue <- TRUE
    while(continue) {
      curr_data_links <- prev_data_links
      curr_data_names <- sapply(curr_data_links, function(x) x[[1]])
      for(temp_data_name in self$get_data_names()) {
        i = 1
        for(curr_from_data_frame in curr_data_names) {
          if(curr_from_data_frame == temp_data_name) curr_link_cols <- curr_data_links[[i]][[2]]
          curr_link_cols <- self$link_between_containing(curr_from_data_frame, curr_data_links[[i]][[2]], temp_data_name)
          if(length(curr_link_cols) != 0) {
            if(temp_data_name == to_data_name) {
              return(curr_link_cols)
            }
            else if(!(temp_data_name %in% sapply(curr_data_links, function(x) x[[1]]))) {
              curr_data_links[[length(curr_data_links) + 1]] <- list(temp_data_name, curr_link_cols)
            }
          }
          i = i + 1
        }
      }
      if(length(prev_data_links) == length(curr_data_links)) continue <- FALSE
      else prev_data_links <- curr_data_links
    }
    return(c())
  }
}
)

# If ordered = TRUE then from_data_frame must be from_data_frame in the link
# otherwise from_data_frame could be to_data_frame in the link
DataBook$set("public", "link_exists_between", function(from_data_frame, to_data_frame, ordered = FALSE) {
  if(ordered) {
    return(any(sapply(private$.links, function(link) link$from_data_frame == from_data_frame && link$to_data_frame == to_data_frame)))
  }
  else {
    return(any(sapply(private$.links, function(link) link$from_data_frame == from_data_frame && link$to_data_frame == to_data_frame))
           || any(sapply(private$.links, function(link) link$from_data_frame == to_data_frame && link$to_data_frame == from_data_frame)))
  }
}
)

DataBook$set("public", "link_between_containing", function(from_data_frame, containing_columns, to_data_frame) {
  if(self$link_exists_between(from_data_frame, to_data_frame)) {
    curr_link <- self$get_link_between(from_data_frame, to_data_frame)
    for(curr_link_pairs in curr_link$link_columns) {
      if(curr_link$from_data_frame == from_data_frame) {
        if(all(containing_columns %in% names(curr_link_pairs))) {
          out <- c()
          for(col in containing_columns) {
            ind <- which(names(curr_link_pairs) == col)
            out <- c(out, curr_link_pairs[[ind]])
          }
          return(out)
        }
      }
      else {
        if(all(containing_columns %in% curr_link_pairs)) {
          out <- c()
          for(col in containing_columns) {
            ind <- which(curr_link_pairs == col)
            out <- c(out, names(curr_link_pairs)[ind])
          }
          return(out)
        }
      }
    }
  }
  return(c())
}
)

DataBook$set("public", "get_link_between", function(from_data_frame, to_data_frame, ordered = FALSE) {
  if(ordered) {
    for(curr_link in private$.links) {
      if((curr_link$from_data_frame == from_data_frame && curr_link$to_data_frame == to_data_frame)) {
        return(curr_link)
      }
    }
  }
  else {
    for(curr_link in private$.links) {
      if((curr_link$from_data_frame == from_data_frame && curr_link$to_data_frame == to_data_frame) || (curr_link$from_data_frame == to_data_frame && curr_link$to_data_frame == from_data_frame)) {
        return(curr_link)
      }
    }
  }
  return(NULL)
}
)

DataBook$set("public", "view_link", function(link_name) {
  temp_link <- self$get_links(link_name)
  out <- ""
  if(length(temp_link) > 0) {
    out <- cat(paste(
                      paste("Link name:", link_name),
                      paste("From data frame:", temp_link$from_data_frame),
                      paste("To data frame:", temp_link$to_data_frame),
                      paste("Link columns:", paste(names(temp_link$link_columns), "=", temp_link$link_columns, collapse = ", ")), sep = "\n"))
  }
}
)

# A function to convert the variables in the linked "to data frame"" to be the same class as that of the "from data frame"".
DataBook$set("public", "convert_linked_variable", function(from_data_frame, link_cols) {
  to_data_name <- self$get_linked_to_data_name(from_data_frame, link_cols=c(link_cols))
  if (!is.null(to_data_name)){
    linked_variable_name <- self$get_link_between(from_data_frame, to_data_name)$link_columns[[1]]
    
    # loop through all columns given in variable argument
    for (i in seq_along(linked_variable_name)){
      variable_type <- self$get_column_data_types(data_name = from_data_frame, columns = names(linked_variable_name[i]))
      linked_variable_type <- self$get_column_data_types(data_name = to_data_name, columns=linked_variable_name[i])
      
      if (variable_type != linked_variable_type){
        self$convert_column_to_type(data_name=to_data_name, col_names=linked_variable_name[i], to_type=variable_type)
      }
    }
  }
}
)
