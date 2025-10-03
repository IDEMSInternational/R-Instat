# Ensure that the correct packages and executables are installed
if (!requireNamespace("quarto", quietly = TRUE))
  stop("install.packages('quarto') needed.")
if (system("quarto --version", ignore.stdout = TRUE, ignore.stderr = TRUE) != 0)
  stop("Install Quarto CLI: https://quarto.org/ ")

STEM <- "inline"          # basename for all temporary files

src <- '<<QUARTO_SCRIPT>>'

# Clean up any stale inline.* files
tmpdir <- tempdir()
unlink(list.files(tmpdir, pattern = paste0("^", STEM, "\\..*$"), full.names = TRUE))

# Write the fresh .qmd 
qmd <- file.path(tmpdir, paste0(STEM, ".qmd"))
writeLines(src, qmd)

# Render all formats listed in the Quarto script
old <- setwd(tmpdir); on.exit(setwd(old))
quarto::quarto_render(basename(qmd), quiet = TRUE)

# Find all files generated (excluding the '.qmd' file itself)
stem <- tools::file_path_sans_ext(basename(qmd))
files <- list.files(tmpdir,
                    pattern = paste0("^", stem, "\\..+$"),
                    full.names = TRUE)
files <- files[!grepl("\\.qmd$", files)]

# Open each generated file in the default application
for (f in files) browseURL(f)

# Print the full paths of the rendered files
cat("Rendered files (full paths):\n")
cat(paste("  ", files, collapse = "\n"), "\n")
