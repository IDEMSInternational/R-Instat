####################################################################
# CREATE AN R-INTERFACE TO PLOT GRAPHICS
#' @title graphics Frontend
#' @name graphics_frontend
#' @description Allows the interaction with R using "Tcl/Tk" language (see 
#' package \code{tcltk})
#' @author Rafael Posada, 2015 (SASSCAL/DWD)

climate$methods(graphics_frontend = function(){
  
  # Required libraries
  library(tcltk)
  
  # Name of graphics available
  name.plots <- c("Wind Rose","Timeseries","Histogram")
  
  ###############################################################
  # INTERFACE
  tt<-tktoplevel()
  tl<-tklistbox(tt,height=4,selectmode="single",
                background="white",selectmode = "extended",
                exportselection = 0,width = 50, height = 5)
  tkgrid(tklabel(tt,text="List of available plots") )
  tkgrid(tl)
  for (i in c(1:length(name.plots)))
  {
    tkinsert(tl,"end",name.plots[i])
  }
  tkselection.set(tl,2) # Default selection
  
  #############################################################
  # OK BUTTON
  OnOK <- function()
  {
    choice <- name.plots[as.numeric(tkcurselection(tl))+1]
    
    if (choice=="Wind Rose"){
      WR.type <-typeWR()
      .self$windrose(list(),WR.type)
    }
    
    if (choice=="Timeseries"){
      .self$timeseries()
    }
    
    if (choice=="Histogram"){
      .self$histogram()
    }
    tkdestroy(tt)
    
    msg <- paste("You have selected: ",choice,sep="")
    tkmessageBox(message=msg)  
  }
  OK.but <-tkbutton(tt,text="   OK   ",command=OnOK)
  tkgrid(OK.but)
  tkfocus(tt)
  
  ##############################################################
  # CANCEL BUTTON
  OnCancel <- function(){
{
  tkdestroy(tt)
  
}
CANCEL.but <-tkbutton(tt,text=" Cancel ",command=OnCancel)
tkgrid(CANCEL.but)
tkfocus(tt)
  }
  #################################################################
  # SELECT TYPE OF WINDROSE 
  
  #' @title Selection of Windrose type
  #' @name typeWR
  #' @author Jens Riede, 2015 (SASSCAL/DWD)
  #' @description  This is needed for the windrose plots, to select which kind
  #'  of plot is desired to be displayed.
  #' 
  typeWR <- function(){
    require(tcltk)
    
    #### creates a menu
    ts<-tktoplevel()
    tktitle(ts)
    done<-tclVar("")
    tkwm.title(ts,"Windrose time scale options")
    heading<-tklabel(ts, text = "Windrose Options")
    single <- tkbutton(ts, text = "Single (Global mean)",
                       command = function() tclvalue(done) <- "single")
    year <- tkbutton(ts, text = "Month per year",
                     command = function() tclvalue(done) <- "year")
    seasonal <- tkbutton(ts, text = "Per season",
                         command = function() tclvalue(done) <- "season")
    weekday <- tkbutton(ts, text = "Days per week",
                        command = function() tclvalue(done) <- "weekday")
    
    tkgrid(heading, columnspan=2)
    tkgrid(single, year, seasonal, weekday)
    tkfocus(ts)
    tkwait.variable(done)
    WR.type <- as.character(tclvalue(done)) # Get and coerce content of a 
    # Tcl variable
    tkdestroy(ts)
    
    return(WR.type)
    
  }
})