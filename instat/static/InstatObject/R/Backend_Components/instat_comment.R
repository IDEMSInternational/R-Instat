# A comment is metadata for a row or cell of a data frame
# A DataSheet will contain a list of instat_comment objects as part of the metadata for the data frame
# id : numeric/character - A unique identifier for the comment. id must be unique within a data frame.
#                     This could be a number or a character
# key_values : named character vector - This identifies the row the comment is on. 
#                                        The names are the names of the key columns in the data frame
#                                        The values are the values of those columns at the row the comment is on.
# column : character - If the comment is on a cell, column is the name of the column of the cell
# value : single value - If the comment is on a cell, value is the value in the cell at the time the comment was created.
# type : character - The type of comment. One of "critical", "warning", "messaged"
# comment : character - The comment text
# label : character - A label or grouping for the comment e.g. if comments are produced by an operation they may all have the same label.
#                     This then allows similar comments to be identified e.g. for editing/deleting
# calculation : character - If the comment was created through a calculation e.g. filtering the data frame, calculation shows how the calculation done on the data frame
# time_stamp : POSIXct, POSIXt - Date and time the comment was created on.
# replies : list - A list of replies to the comment. A reply could be a comment itself
# resolved : logical - Is the comment marked as resolved (default FALSE).
# active : logical - Is the comment marked as active (default TRUE)
# attributes : list - A named list of additional information about the comment.

comment_types <- c("critical", "warning", "message", "")

instat_comment <- R6::R6Class("instat_comment",
                    public = list(
                      initialize = function(id = "",
                                            key_values = c(),
                                            column = "",
                                            value = "",
                                            type = "",
                                            comment = "",
                                            label = "",
                                            calculation = "",
                                            time_stamp = "",
                                            replies = list(),
                                            resolved = FALSE,
                                            active = TRUE,
                                            attributes = list()) {
                        self$id <- id
                        self$key_values <- key_values
                        self$column <- column
                        self$value <- value
                        if(!type %in% comment_types) stop("type must be blank or one of: ", paste(comment_types, collapse = ","))
                        self$type <- type
                        self$comment <- comment
                        self$label <- label
                        self$calculation <- calculation
                        if(time_stamp == "") time_stamp <- Sys.time()
                        self$time_stamp <- time_stamp
                        self$replies <- replies
                        self$resolved <- resolved
                        self$active <- active
                        self$attributes <- attributes
                      },
                      id = "",
                      key_values = c(),
                      column = "",
                      value = "",
                      type = "",
                      comment = "",
                      label = "",
                      calculation = "",
                      time_stamp = "",
                      replies = list(),
                      resolved = FALSE,
                      active = TRUE,
                      attributes = list()
                    ),
                    private = list(),
                    active = list()
)

instat_comment$set("public", "data_clone", function(...) {
  replies <- list()
  for(curr_reply in self$replies) {
    if("instat_comment" %in% class(curr_reply)) replies[[length(replies) + 1]] <- curr_reply$data_clone()
    else replies[[length(replies) + 1]] <- curr_reply
  }
  ret <- instat_comment$new(id = self$id,
                            key_values = self$key_values,
                            column = self$column,
                            value = self$value,
                            type = self$type,
                            comment = self$comment,
                            label = self$label,
                            calculation = self$calculation,
                            time_stamp = self$time_stamp,
                            replies = replies,
                            resolved = self$resolved,
                            active = self$active,
                            attributes = self$attributes)
  return(ret)
}
)

DataBook$set("public", "add_comment", function(data_name, new_comment) {
  self$get_data_objects(data_name)$add_comment(new_comment)
}
)

DataSheet$set("public", "add_comment", function(new_comment) {
  if(!self$has_key()) stop("Define a key before adding comments. Comments can only be added to data frames when rows can be identified by a key.")
  if(!"instat_comment" %in% class(new_comment)) stop("new_comment must be of class 'instat_comment'")
  if(!self$is_key(names(new_comment$key_values))) stop("The columns specified as the names of key_values must be a key in the data frame")
  all_comment_ids <- self$get_comment_ids()
  if(length(all_comment_ids) > 0 && new_comment$id %in% all_comment_ids) warning("A comment with id: ", new_comment$id, " already exists. It will be replaced.")
  if(new_comment$id == "") new_comment$id <- as.character(max(as.numeric(all_comment_ids), 0, na.rm = TRUE) + 1)
  private$comments[[new_comment$id]] <- new_comment
}
)

DataBook$set("public", "delete_comment", function(data_name, comment_id) {
  self$get_data_objects(data_name)$delete_comment(comment_id)
}
)

DataSheet$set("public", "delete_comment", function(comment_id) {
  if(!comment_id %in% self$get_comment_ids()) stop("No comment with id: ", comment_id, " was found.")
  private$comments[[comment_id]] <- NULL
}
)

DataBook$set("public", "get_comment_ids", function(data_name) {
  return(self$get_data_objects(data_name)$get_comment_ids())
}
)

DataSheet$set("public", "get_comment_ids", function() {
  return(names(private$comments))
}
)

DataBook$set("public", "get_comments_as_data_frame", function(data_name) {
  return(self$get_data_objects(data_name)$get_comments_as_data_frame())
}
)

DataSheet$set("public", "get_comments_as_data_frame", function() {
  id <- sapply(private$comments, function(x) x$id)
  # Needs expanding for each key column
  key_columns <- unique(unlist(sapply(private$comments, function(x) names(x$key_values))))
  # key_vals <- list()
  # for(col in key_columns) {
  #   key_vals[[col]] <- sapply(private$comments, function(x) x$key_values[col])
  # }
  column <- sapply(private$comments, function(x) x$column)
  # Not sure what value will be yet
  value <- sapply(private$comments, function(x) x$value)
  type <- sapply(private$comments, function(x) x$type)
  comment <- sapply(private$comments, function(x) x$comment)
  label <- sapply(private$comments, function(x) x$label)
  calculation <- sapply(private$comments, function(x) x$calculation)
  # Returned as character to prevent sapply coercing to numeric
  time_stamp <- sapply(private$comments, function(x) as.character(x$time_stamp))
  # TODO how to display replies in data frame?
  no_replies <- sapply(private$comments, function(x) length(x$no_replies))
  resolved <- sapply(private$comments, function(x) x$resolved)
  active <- sapply(private$comments, function(x) x$active)
  # TODO how to display attributes in data frame?
  no_attributes <- sapply(private$comments, function(x) length(x$attributes))
  return(data.frame(id = id, key_values = key_values, column = column, value = value, type = type, comment = comment, label = label, calculation = calculation, time_stamp = time_stamp, no_replies = no_replies, resolved = resolved, active = active, no_attributes = no_attributes))
}
)