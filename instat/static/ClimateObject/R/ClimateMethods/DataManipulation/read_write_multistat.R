#' Read multiple filenames and load files into R.
#'This was inspired by work for James K. Musyoka.
#' @title read and write multiple files.  
#' @name read_load_multifile()
#' @author Abib Duut 2015 
#'
#'@description \code{read_load_multifile} 
#' This reads and loads data from a directory on your computer into R.
#' It is particularly useful when loading data for multiple stations, 
#' and when creating a climate object for multiple stations. 
#' It writes a file to the user's current working directory in the users specified format, 
#' .csv or .txt. The user should have organise the files in a directory.
#' @param filename
#' format this could one of the two flat file formats .csv, .txt
#' 
#' @examples
#'        read_write_multistat() # run this line in the working directory of your files.
#' @return This writes a file with the filename passed in by the user to the user's current directory.
#' 
#'------------------------------------------------------------------------------------------------
#'------------------------------------------------------------------------------------------------

read_write_multistat<-function( path_to_file="",filename=as.list(), format= "csv"){
                    if(!is.null(path_to_file)){
                      setwd(path_to_file)
                      f<-list.files()  
                      f<-as.data.frame(f)
                      f<-f[1]
                      nf<-noquote(tools::file_path_sans_ext(f$f))
                      
                    }else if(!is.null(filename)){
                        fname_list<-lapply(tk_choose_files(caption=""), list)
                           for(fname in fname_list){
                                tmp_name<-noquote(basename(as.character(fname)))
                             
                           }
                        #file_list<-lapply(tk_choose_files(caption=""), read.table(header=T))
                      }
                      mv<-paste(nf,'<-','read.', format, '("',f$f, '", header=T)' , sep='')
                      write.table(noquote(mv), file=as.character(filename), quote=F, row.names=F, sep=",")
                      filen<-noquote(paste(paste(nf,'=', nf),"",collapse=","))
                  filen    
}
  