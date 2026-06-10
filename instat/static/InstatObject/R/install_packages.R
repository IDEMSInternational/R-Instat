# install_packages.R
# Compatibility wrapper: run the generated installer script.

args <- commandArgs(trailingOnly = FALSE)
file_arg <- "--file="
file_matches <- grep(file_arg, args, value = TRUE)
if (length(file_matches) > 0) {
  script_path <- sub(file_arg, "", file_matches[1])
  script_dir <- dirname(script_path)
} else {
  script_dir <- getwd()
}
source(file.path(script_dir, "install_packages_generated.R"), chdir = TRUE)
