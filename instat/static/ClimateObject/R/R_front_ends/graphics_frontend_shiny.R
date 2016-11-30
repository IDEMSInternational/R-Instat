#############################################################################
# SHINY-INTERFACE THROUGH R TO PLOT GRAPHICS
#' @title SHINY Graphic Frontend
#' @name graphics_frontend_shiny
#' @description Creates a UI interface using \code{shiny})
#' @author Rafael Posada, 2015 (SASSCAL/DWD)
#'
climate$methods(graphics_frontend_shiny = function(selected_plot="Timeseries"){
  
  shinyApp(
    ui = shinyUI(
      basicPage(
        uiOutput("uiOutputs")
      )
    ),
    server = function(input,output){
      print("graphic_frontend_shiny")
      .self$shiny_server(input,output,selected_plot)
    }
  )
  
  
})
