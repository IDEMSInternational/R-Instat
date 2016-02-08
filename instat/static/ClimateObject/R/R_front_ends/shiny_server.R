#############################################################################
# SHINY-INTERFACE THROUGH R TO PLOT GRAPHICS
#' @title SHINY Graphic Frontend
#' @name graphics_frontend_shiny
#' @description Creates a UI interface using \code{shiny})
#' @author Rafael Posada, 2015 (SASSCAL/DWD)
#'
climate$methods(shiny_server = function(input,output,selected_plot){
  rm(list= ls(all=TRUE)[!(ls() %in% c('input','output','selected_plot'))])

  #########################################################################
  # Create a random name which will be used to create the uiOutputs
  temporal <- substr(UUIDgenerate(FALSE),1,6)

  #########################################################################
  #
  # PART 1: PROPERTIES OF GRAPHICS
  #
  #########################################################################
  #
  # A) TIMESERIES
  if (selected_plot=="Timeseries"){
    #######################################################################
    # 1) Create plots
    k <- .self$timeseries_shiny()
    abbr <- "ts"

    #######################################################################
    # 2) graphOutput
    # Set up a new function to be used as dygraphOutput
    graphOutput <- function(outputID,width="100%",height="280"){
      dygraphOutput(outputID,width,height)
    }

    #######################################################################
    # 3) uiOutputs
    # Create additional uiOutputs required for this type of graphic
    output$uiOutputs <- renderUI({
      uiOutputs <- list(uiOutput(temporal),tags$head(tags$script(
        src = "http://cavorite.com/labs/js/dygraphs-export/dygraph-extra.js")
      ),dygraphOutput("dygraph"))
      do.call(tagList,uiOutputs)
    })

    #######################################################################
    # 4) plotUIOutputList
    # Function to create a list of plotname_ui, which is where the graphics
    # are going to be plotted
    plotUIOutputList <- function(n4,tabs4_id,my_i3){
      plotname_ui_list <- lapply(1:n4,function(i){
        temporal <- substr(UUIDgenerate(FALSE),1,6)
        paste0(tabs4_id,my_i3,i,abbr,temporal)
      })
      return(plotname_ui_list)
    }

    #######################################################################
    # 5) plotOutputList
    # Function to create a list of plotnames and a list of download buttons.
    # There will be one plotname and one download button for each plot
    plotOutputList <- function(n5,tabs4_id,my_i3,my_i4){
      # 5.1) List of plotnames
      plotname_list <- lapply(1:n5,function(i){
        temporal <- substr(UUIDgenerate(FALSE),1,6)
        paste0(tabs4_id,my_i3,my_i4,i,abbr,temporal)
      })
      # 5.2) List of outputs for the plots
      plot_output_list <- lapply(1:n5, function(i) {
        plotname <- plotname_list[[i]]
        graphOutput(plotname)
      })
      # 5.3) List of outputs for the download button
      plot_output_list2 <- lapply(1:n5, function(i) {
        plotname <- plotname_list[[i]]
        download.button <- paste0(plotname,"download")
        uiOutput(download.button)
      })
      # 5.4) Place the download button after the plots
      plot_output_list3 <- mapply(plot_output_list,plot_output_list2,
                                  FUN=list,SIMPLIFY = FALSE)

      # 5.5) Final output
      plots_list <- list(plot_output_list=plot_output_list3,
                         plotname_list=plotname_list)
      return(plots_list)
    }

    #######################################################################
    # 6) renderGraphics
    # Set up RenderPlot function. This is a function which is used to actually
    # plot the graphics in the correct "ui" (i.e. in the "plotname")
    renderGraphics <- function(k2,plotname,plotname_ui){
      # 6.1) Name of download button
      download.button <- paste0(plotname,"download")
      download.button2 <- paste0(plotname,"download2")

      # 6.3) Create Download button
      output[[download.button]] <- renderUI({
        tags$a(id = download.button2,
               class = "btn btn-default shiny-download-link",
               icon("download"), "",
               download = paste0("plot.png"))
      })
      
      # 6.2) Function to be called by the download button
      function.name <- paste0(
        "function(",plotname,"){$('#",download.button2,
        "').attr('href', Dygraph.Export.asCanvas(",plotname,
        ").toDataURL());}")
      
      # 6.3) Create plot
      output[[plotname]] <- renderDygraph({k2 %>%
          dyCallbacks(drawCallback = function.name)})
      return(output)
    }
  }

  #########################################################################
  # B) HISTOGRAM
  if (selected_plot=="Histogram"){
    #######################################################################
    # 1) Create plots
    k <- .self$histogram_shiny()
    abbr <- "hist"

    #######################################################################
    # 2) graphOutput
    # Set up a new function to be used as ggvisOutput
    graphOutput <- as.function(ggvisOutput)

    #######################################################################
    # 3) uiOutputs
    # Create additional uiOutputs required for this type of graphic
    output$uiOutputs <- renderUI({
      uiOutputs <- list(uiOutput(temporal),
                        uiOutput("minVal"),
                        uiOutput("maxVal"),
                        uiOutput("slider")
      )
      do.call(tagList,uiOutputs)
    })
    # 3.1) Create reactive inputs for histogram
    output$minVal <- renderUI({numericInput("minValue", "Min. bin width",.1)})
    output$maxVal <- renderUI({numericInput("maxValue", "Max. bin width",10)})
    output$slider <- renderUI({
      if (is.null(input$minValue) || is.null(input$maxValue)){
        return()
      }else{
        sliderInput("inSlider", "Bin width", min=input$minValue,
                    max=input$maxValue,step = .1,
                    value=(input$maxValue+input$minValue)/2)
      }
    })
    input_width <- reactive({input$inSlider})

    #######################################################################
    # 4) plotUIOutputList
    # Function to create a list of plotname_ui, which is where the graphics
    # are going to be plotted
    plotUIOutputList <- function(n4,tabs4_id,my_i3){
      plotname_ui_list <- lapply(1:n4,function(i){
        paste0(tabs4_id,my_i3,i,abbr)
      })
      return(plotname_ui_list)
    }

    #######################################################################
    # 5) plotOutputList
    # Function to create a list of plotnames. There will be one plotname
    # for each plot
    plotOutputList <- function(n5,tabs4_id,my_i3,my_i4){
      # 5.1) List of plotnames
      plotname_list <- lapply(1:n5,function(i){
        paste0(tabs4_id,my_i3,my_i4,i,abbr,UUIDgenerate(FALSE))
      })
      # 5.2) List of outputs for the plots
      plot_output_list <- lapply(1:n5, function(i) {
        plotname <- plotname_list[[i]]
        graphOutput(plotname)
      })
      # 5.3) Final output
      plots_list <- list(plot_output_list=plot_output_list,
                         plotname_list=plotname_list)
      return(plots_list)
    }

    #######################################################################
    # 6) renderGraphics
    # Set up RenderPlot function. This is a function which is used to actually
    # plot the graphics in the correct "ui" (i.e. in the "plotname")
    renderGraphics <- function(k2,plotname,plotname_ui){
      plotname_ui2 <- paste(plotname_ui,"1")
      k2 %>% layer_histograms(width=input_width) %>%
        bind_shiny(plotname,plotname_ui2)
    }
  }

  #########################################################################
  # C) WINDROSE
  if (selected_plot=="Windrose"){
    print("windrose shiny Server")
    #######################################################################
    # 1) Create plots
    k <- .self$windrose_shiny()
    abbr <- "wr"

    #######################################################################
    # 2) graphOutput
    # Set up a new function to be used as ggvisOutput
    graphOutput <- as.function(plotOutput)

    #######################################################################
    # 3) uiOutputs
    # Create additional uiOutputs required for this type of graphic
    output$uiOutputs <- renderUI({
      uiOutputs <- list(uiOutput(temporal)
      )
      do.call(tagList,uiOutputs)
    })


    #######################################################################
    # 4) plotUIOutputList
    # Function to create a list of plotname_ui, which is where the graphics
    # are going to be plotted
    plotUIOutputList <- function(n4,tabs4_id,my_i3){
      plotname_ui_list <- lapply(1:n4,function(i){
        paste0(tabs4_id,my_i3,i,abbr)
      })
      return(plotname_ui_list)
    }

    #######################################################################
    # 5) plotOutputList
    # Function to create a list of plotnames. There will be one plotname
    # for each plot
    plotOutputList <- function(n5,tabs4_id,my_i3,my_i4){
      # 5.1) List of plotnames
      plotname_list <- lapply(1:n5,function(i){
        paste0(tabs4_id,my_i3,my_i4,i,abbr,UUIDgenerate(FALSE))
      })
      # 5.2) List of outputs for the plots
      plot_output_list <- lapply(1:n5, function(i) {
        plotname <- plotname_list[[i]]
        graphOutput(plotname)
      })
      # 5.3) Final output
      plots_list <- list(plot_output_list=plot_output_list,
                         plotname_list=plotname_list)
      return(plots_list)
    }

    #######################################################################
    # 6) renderGraphics
    # Set up RenderPlot function. This is a function which is used to actually
    # plot the graphics in the correct "ui" (i.e. in the "plotname")
    renderGraphics <- function(k2,plotname,plotname_ui){
      plotname_ui2 <- paste(plotname_ui,"1")
      #bind_shiny(plotname,plotname_ui2)
      output[[plotname]] <- renderPlot({k2})
      return(output)
    }
  }



  ############### END graphics ##########################################



  #########################################################################
  #
  # PART 2: CREATE TABS
  #
  #########################################################################
  # 1) DATA SET TABS
  n1 <- length(k)
  output[[temporal]] <- renderUI({
    Tabs1 <- lapply(1:n1,function(i){
      tabs1_name <- paste("data_set:",names(k[i]))
      tabs2_id <- paste0(abbr,i,temporal)
      tabPanel(tabs1_name,uiOutput(tabs2_id))
    })
    do.call(tabsetPanel,Tabs1)
  })

  plots_list_new <- list()

  #########################################################################
  # 2) CURRENT DATA TABS
  for(i1 in 1:n1){
    local({
      my_i1 <- i1
      n2 <- length(k[[my_i1]])
      tabs2_id <- paste0(abbr,my_i1,temporal)
      output[[tabs2_id]] <- renderUI({
        Tabs2 <- lapply(1:n2,function(i){
          tabs2_name <- paste0(names(k[[my_i1]][i]))
          tabs3_id <- paste0(tabs2_id,i,temporal)
          tabPanel(tabs2_name,uiOutput(tabs3_id))
        })
        do.call(tabsetPanel,Tabs2)
      })

      ###################################################################
      # 3) STATION_ID TABS
      for(i2  in 1:n2){
        local({
          my_i2 <- i2
          n3 <- length(k[[my_i1]][[my_i2]])
          tabs3_id <- paste0(tabs2_id,my_i2,temporal)
         output[[tabs3_id]] <- renderUI({
            Tabs3 <- lapply(1:n3,function(i){
              tabs3_name <- paste0("Station ID: ",
                                   names(k[[my_i1]][[my_i2]][i]))
              tabs4_id <- paste0(tabs3_id,i)
              tabPanel(tabs3_name, uiOutput(tabs4_id))
            })
            do.call(tabsetPanel,Tabs3)
          })

          #################################################################
          # 4) VARIABLES TABS
          for(i3  in 1:n3){
            local({
              my_i3 <- i3
              n4 <- length(k[[my_i1]][[my_i2]][[my_i3]])
              tabs4_id <- paste0(tabs3_id,my_i3)
              plotname_ui_list <- plotUIOutputList(n4,tabs4_id,my_i3)
              output[[tabs4_id]] <- renderUI({
                Tabs4 <- lapply(1:n4,function(i){
                  tabs3_name <- paste0("Var: ",
                                       names(k[[my_i1]][[my_i2]][[my_i3]][i]))
                  plotname_ui <- plotname_ui_list[[i]]
                  tabPanel(tabs3_name, uiOutput(plotname_ui))
                })
                do.call(tabsetPanel,Tabs4)
              })

              ###############################################################
              #
              # PART 3: PLOT THE GRAPHICS
              #
              ###############################################################
              # 1) Place the plotnames within each plotname_ui
              for (i4 in 1:n4){
                local ({
                  my_i4 <- i4
                  n5 <- length(k[[my_i1]][[my_i2]][[my_i3]][[my_i4]])
                  plotname_ui <- plotname_ui_list[[my_i4]]
                  plots_list <- plotOutputList(n5,tabs4_id,my_i3,my_i4)
                  plots_list_new[[my_i1]] <- plots_list
                  output[[plotname_ui]] <- renderUI({
                    plot_output_list <- plots_list$plot_output_list
                    do.call(tagList,plot_output_list)
                  })
                  # Plot subplots if necessary (e.g. for subdaily dataset
                  # that are not hourly)
                  for (i5 in 1:n5){
                    local({
                      my_i5 <- i5
                      plotname <- plots_list$plotname_list[[my_i5]]
                      k2 <- k[[my_i1]][[my_i2]][[my_i3]][[my_i4]][[my_i5]]
                      renderGraphics(k2,plotname,plotname_ui)
                    })
                  }

                  ##########################################################
#                   # WINDROSE
#                   if (selected_plot =="Windrose"){
#                     output[[plotname]] <- renderPlot({k[[my_i1]][[my_i2]][[my_i3]][[my_i4]]})
#                   }
                })
              }
            })
          }
        })
      }
    })
  }
  return(output)
})
