col_names <- c("_colNames")
get_index_names  <- data_book$get_variables_metadata(data_name="_dataFrame", column=col_names)
rankings_object <- data_book$get_object(data_name="_dataFrame", "rankings_list")$object
rankings_object <- get_ranking_items(data=get_index_names , vars_to_get=col_names, index="rankings_index", rankings_object)

names(rankings_object) <- col_names
last_graph <- plot_network(rankings_object[[1]])
data_book$add_object(data_name="_dataFrame", object_name="last_graph", object_type_label="graph", object_format="image", object=instatExtras::check_graph(graph_object=last_graph))
data_book$get_object_data(data_name="_dataFrame", object_name="last_graph", as_file=TRUE)
rm(list=c("last_graph", "rankings_object", "get_index_names ", "col_names"))