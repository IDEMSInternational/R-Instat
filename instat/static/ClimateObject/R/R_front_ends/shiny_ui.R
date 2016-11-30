#############################################################################
# SHINY-INTERFACE THROUGH R TO PLOT GRAPHICS
#' @title SHINY Graphic Frontend
#' @name graphics_frontend_shiny
#' @description Creates a UI interface using \code{shiny})
#' @author Rafael Posada, 2015 (SASSCAL/DWD)
#'
climate$methods(shiny_ui = function(){
  library(shiny)
  # Create UI interface
  shinyUI(
    basicPage(
      uiOutput("uiOutputs")
    )
  )
})
