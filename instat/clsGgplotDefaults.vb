Public Class GgplotDefaults
    Public Shared ReadOnly Property clsDefaultLabs As RFunction
        Get
            Dim clsTempFunc As New RFunction

            clsTempFunc.SetPackageName("ggplot2")
            clsTempFunc.SetRCommand("labs")
            clsTempFunc.AddParameter("title", Chr(34) & Chr(34))
            clsTempFunc.AddParameter("subtitle", Chr(34) & Chr(34))
            clsTempFunc.AddParameter("caption", Chr(34) & Chr(34))
            Return clsTempFunc
        End Get
    End Property

    Public Shared ReadOnly Property clsDefaultThemeParameter As RParameter
        Get
            Dim clsTempParam As New RParameter

            clsTempParam.SetArgumentName("theme")
            clsTempParam.SetArgumentValue("theme_grey()")
            Return clsTempParam
        End Get
    End Property

    Public Shared strThemes As String() = {"theme_bw", "theme_linedraw", "theme_light", "theme_minimal", "theme_classic", "theme_dark", "theme_void", "theme_base", "theme_calc", "theme_economist", "theme_few", "theme_fivethirtyeight", "theme_foundation", "theme_grey", "theme_gdocs", "theme_igray", "theme_map", "theme_par", "theme_solarized", "theme_hc", "theme_pander", "theme_solid", "theme_stata", "theme_tufte", "theme_wsj"}


    Public Shared ReadOnly Property clsXlabTitleFunction As RFunction
        Get
            Dim clsXlabTempFunc As New RFunction

            clsXlabTempFunc.SetPackageName("ggplot2")
            clsXlabTempFunc.SetRCommand("xlab")
            Return clsXlabTempFunc
        End Get
    End Property

    Public Shared ReadOnly Property clsYlabTitleFunction As RFunction
        Get
            Dim clsYlabTempFunc As New RFunction

            clsYlabTempFunc.SetPackageName("ggplot2")
            clsYlabTempFunc.SetRCommand("ylab")
            Return clsYlabTempFunc
        End Get
    End Property

    Public Shared ReadOnly Property clsXScalecontinuousFunction As RFunction
        Get
            Dim clsXlabScalesTempFunc As New RFunction

            clsXlabScalesTempFunc.SetPackageName("ggplot2")

            clsXlabScalesTempFunc.SetRCommand("scale_x_continuous")
            Return clsXlabScalesTempFunc
        End Get
    End Property

    Public Shared ReadOnly Property clsYScalecontinuousFunction As RFunction
        Get
            Dim clsYlabScalesTempFunc As New RFunction

            clsYlabScalesTempFunc.SetPackageName("ggplot2")
            clsYlabScalesTempFunc.SetRCommand("scale_y_continuous")

            Return clsYlabScalesTempFunc
        End Get
    End Property

    Public Shared ReadOnly Property clsFacetFunction As RFunction
        Get
            Dim clsFacetTempFunc As New RFunction
            Dim clsFacetVariablesOp As New ROperator("~")

            clsFacetTempFunc.SetPackageName("ggplot2")
            clsFacetTempFunc.SetRCommand("facet_wrap")
            clsFacetTempFunc.AddParameter("dir", Chr(34) & "h" & Chr(34))
            clsFacetTempFunc.AddParameter("facets", clsROperatorParameter:=clsFacetVariablesOp)
            Return clsFacetTempFunc
        End Get
    End Property

    Public Shared ReadOnly Property dctThemeFunctions As Dictionary(Of String, RFunction)
        Get
            Dim dctTemp As New Dictionary(Of String, RFunction)
            Dim clsElementText As RFunction

            clsElementText = New RFunction
            clsElementText.SetPackageName("ggplot2")
            clsElementText.SetRCommand("element_text")

            dctTemp.Add("axis.text.x", clsElementText.Clone())
            dctTemp.Add("axis.text.y", clsElementText.Clone())

            Return dctTemp
        End Get
    End Property

    Public Shared ReadOnly Property dctFonts As Dictionary(Of String, String)
        Get
            Dim dctTemp As New Dictionary(Of String, String)
            dctTemp.Add("Times Roman", Chr(34) & "Times" & Chr(34))
            dctTemp.Add("Courier", Chr(34) & "Courier" & Chr(34))
            dctTemp.Add("Couriersans", Chr(34) & "Couriersans" & Chr(34))
            dctTemp.Add("Serif", Chr(34) & "serif" & Chr(34))
            dctTemp.Add("NimbusSanCond", Chr(34) & "NimbusSanCond" & Chr(34))
            dctTemp.Add("CenturySch", Chr(34) & "CenturySch" & Chr(34))
            dctTemp.Add("NewCenturySchoolbook", Chr(34) & "NewCenturySchoolbook" & Chr(34))
            dctTemp.Add("Palatino", Chr(34) & "Palatino" & Chr(34))
            dctTemp.Add("Bookman", Chr(34) & "Bookman" & Chr(34))
            dctTemp.Add("URWBookman", Chr(34) & "URWBookman" & Chr(34))
            dctTemp.Add("URWGothic", Chr(34) & "URWGothic" & Chr(34))
            dctTemp.Add("NimbusRom", Chr(34) & "NimbusRom" & Chr(34))
            dctTemp.Add("URWPalladioURWTimes", Chr(34) & "URWPalladioURWTimes" & Chr(34))
            dctTemp.Add("NimbusMonURWHelvetica", Chr(34) & "NimbusMonURWHelvetica" & Chr(34))
            dctTemp.Add("Helvetica - Narrow", Chr(34) & "Helvetica - Narrow" & Chr(34))
            dctTemp.Add("Helveticaserif", Chr(34) & "Helveticaserif" & Chr(34))
            dctTemp.Add("Short", Chr(34) & "Short" & Chr(34))
            dctTemp.Add("Canonicalmono", Chr(34) & "Canonicalmono" & Chr(34))
            dctTemp.Add("AvantGarde", Chr(34) & "AvantGarde" & Chr(34))

            Return dctTemp
        End Get
    End Property

    Public Shared ReadOnly Property clsDefaultThemeFunction As RFunction
        Get
            Dim clsTempFunc As New RFunction

            clsTempFunc.SetPackageName("ggplot2")
            clsTempFunc.SetRCommand("theme")

            Return clsTempFunc
        End Get
    End Property
End Class