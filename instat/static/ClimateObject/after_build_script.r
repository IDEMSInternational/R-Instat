
#####################################################
#
#
#  see before_build_script.r  for instructions on use
#
#
####################################################

###
oldwd=getwd()
rdir=paste(oldwd,"/R",sep="")
rsavdir=paste(oldwd,"/Rsav",sep="")
setwd(rdir)
unlink(list.files(),recursive=TRUE)
setwd(rsavdir)
file.copy(list.files(),to=rdir,overwrite=TRUE,recursive=TRUE,copy.date=TRUE)
unlink(list.files(),recursive=TRUE)
setwd(oldwd)
