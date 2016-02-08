#####################################################
#
#  This script can be used if the R directory has directory
#  structure
#
#  The use is
#
#   source(before_build_script.r)
#   <use the RStudio build tools to build, e.g. a source build
#   source(after_buile_script.r)
#   
#   The before_build_script.r first copies
#   the R directory structure to directory Rsav
#   It then deleted everything under R and copies
#   a flat version of Rsav.  So after the script is run
#   all *.r files are at the top level of R, as
#   the packaging tools expect.
#
#   note that the zipped build will include the *.r files
#   twice, once in a flat R directory and once in a directory
#   Rsav with directory structure.
#
#
#   The after_build_script.r restores things.   Date stamps
#   are preserved, so things work well with Git  (tested under Linux)
#   and roxygen (not tested)
#
##################################################




oldwd=getwd()
rdir=paste(oldwd,"/R",sep="")
rsavdir=paste(oldwd,"/Rsav",sep="")
setwd(rsavdir)
unlink(list.files(),recursive=TRUE)
setwd(rdir)
file.copy(list.files(),to=rsavdir,overwrite=TRUE,recursive=TRUE,copy.date=TRUE)
unlink(list.files(),recursive=TRUE)
setwd(rsavdir)
file.copy(list.files(recursive=TRUE),to=rdir,overwrite=TRUE,copy.date=TRUE)
setwd(oldwd)

