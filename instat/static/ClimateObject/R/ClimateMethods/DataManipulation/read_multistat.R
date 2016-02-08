#' Reads multiple files from path names passed in from VB.
#' This mode 
#' @title read and .  
#' @name load_files_VB
#' @author Abib Duut 2015 
#'
#'@description \code{} 
#' This function reads and loads data from a directory or absolute file paths specified from VB into R.
#' It is particularly useful when loading data for multiple stations, 
#' and when creating a climate object for multiple stations. 
#' It writes a file to the user's current working directory in the users specified format, 
#' .csv or .txt. The user should have organise the files in a directory.
#' @param data_path_list
#' is a list of specified absolute files of data files or a path of a directory (particulary when reading and loading
#' more than 10 files. 
#' 
#' @examples
#'        load_files_VB # run this line in the working directory of your files.
#' @return This writes a file with the filename passed in by the user to the user's current directory.
#' 
#'------------------------------------------------------------------------------------------------
#'------------------------------------------------------------------------------------------------

load_files_VB<-function(data_path_list=list()){
                  data_path_list<-as.list(data_path_list)
                  if(!is.null(data_path_list))
                    #check if path contains file names.
                      filenames<-basename(as.character(data_path_list))
                          if(is.null(filenames)){
                            #read files from directory.
                            f<-list.files()
                            f<-as.data.frame(f)
                            f<-f[1]
                            nf<-noquote(tools::file_path_sans_ext(f$f))
                            mv<-paste(nf,'<-','read.', 'table', '("',f$f, '", header=T)' , sep='')
                            write.table(noquote(mv), file="filename.txt", quote=F, row.names=F, sep="");a<-getwd();nb<-paste(a,"filename.txt");source("nb")
                            filen<-noquote(paste(paste(nf,'=',nf),"",collapse=","))
                        filen    
                    }else{
                        len<-length(data_path_list)
                        tmp_fnamelist<-vector("list",len)
                        data_path_list<-basename(as.character(data_path_list))
                        tmp_list<-noquote(tools::file_path_sans_ext(data_path_list))
                        tmp_df_name_list<-as.data.frame(tmp_list)
                        
                        for(i in 1:len){
                            tmp_fnamelist[[i]]<-basename(as.character(data_path_list[[i]]))
                            i=i+1
                        }
                    mv<-paste(tmp_df_name_list,'<-','read.','table', '("',tmp_fnamelist, '", header=T)' , sep='')
                    write.table(noquote(mv), file="tmp_file.r", quote=F, row.names=F,col.names=F,sep=",")
                    a<-getwd(); nb<-paste(a,"/tmp_file.r",sep=''); source(nb)
                    filen<-noquote(paste(paste(tmp_df_name_list,'=',tmp_df_name_list),"",collapse=","))
                    
                filen    
        }            
}


