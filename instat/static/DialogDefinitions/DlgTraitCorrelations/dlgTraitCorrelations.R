get_index_names <- data_book$get_variables_metadata("_dataFrame")
rankings_object <- data_book$get_object(data_name="_dataFrame", object_name="rankings_list") $ object
baseline <- "_overallTrait"
multiple_vars <- "_traitsToCompareTo"
all_vars <- c(baseline, multiple_vars)
compare_variables  <- get_ranking_items(data=get_index_names, rankings_object, vars_to_get=all_vars, index ="rankings_index")
names(compare_variables ) <- all_vars
kendall_rankings <- ~ gosset::kendallTau(x=compare_variables[[.x]], y=compare_variables[[baseline]])
kendall_rankings <- purrr::map_dfr(.x=multiple_vars, kendall_rankings) %>% dplyr::mutate(.before=everything(), trait=multiple_vars)
kendall_rankings <- kendall_rankings %>% dplyr::select(-c(`Pr(>|z|)`, `Zvalue`))
rm(list=c("last_table", "kendall_rankings", "compare_variables ", "get_index_names", "rankings_object", "all_vars", "baseline", "multiple_vars"))