# install_packages.R
# Compatibility wrapper: run the generated installer script.

args <- commandArgs(trailingOnly = FALSE)
file_arg <- "--file="
script_path <- sub(file_arg, "", args[grep(file_arg, args)])
script_dir <- dirname(normalizePath(script_path))
source(file.path(script_dir, "install_packages_generated.R"), chdir = TRUE)
