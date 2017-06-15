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

            clsTempParam.SetArgumentName("theme_name")
            clsTempParam.SetArgumentValue("theme_grey()")
            Return clsTempParam
        End Get
    End Property

    Public Shared ReadOnly Property strThemes As String()
        Get
            Dim strTemp As String()
            'TODO need to make proper functions and set package names
            strTemp = {"theme_bw", "theme_linedraw", "theme_light", "theme_minimal", "theme_classic", "theme_dark", "theme_void", "theme_base", "theme_calc", "theme_economist", "theme_few", "theme_fivethirtyeight", "theme_foundation", "theme_grey", "theme_gdocs", "theme_igray", "theme_map", "theme_par", "theme_solarized", "theme_hc", "theme_pander", "theme_solid", "theme_stata", "theme_tufte", "theme_wsj"}
            System.Array.Sort(Of String)(strTemp)
            Return strTemp
        End Get
    End Property

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

    Public Shared ReadOnly Property clsAesFunction As RFunction
        Get
            Dim clslocalAesTempFunc As New RFunction
            clslocalAesTempFunc.SetPackageName("ggplot2")
            clslocalAesTempFunc.SetRCommand("aes")
            Return clslocalAesTempFunc
        End Get
    End Property

    Public Shared ReadOnly Property dctThemeFunctions As Dictionary(Of String, RFunction)
        Get
            Dim dctTemp As New Dictionary(Of String, RFunction)
            Dim clsElementText As RFunction
            Dim clsElementLine As RFunction
            Dim clsElementRect As RFunction

            Dim clsUnit As RFunction

            clsElementText = New RFunction
            clsElementLine = New RFunction
            clsElementRect = New RFunction
            clsElementRect = New RFunction

            clsUnit = New RFunction

            clsUnit.SetPackageName("grid")
            clsElementText.SetPackageName("ggplot2")
            clsElementLine.SetPackageName("ggplot2")
            clsElementRect.SetPackageName("ggplot2")
            clsElementText.SetRCommand("element_text")
            clsElementLine.SetRCommand("element_line")
            clsElementRect.SetRCommand("element_rect")
            clsUnit.SetRCommand("unit")

            dctTemp.Add("line", clsElementLine.Clone())
            dctTemp.Add("rect", clsElementRect.Clone())
            dctTemp.Add("text", clsElementText.Clone())
            dctTemp.Add("title", clsElementText.Clone())
            'dctTemp.Add("aspect.ratio", clsElementText.Clone())
            dctTemp.Add("axis.title", clsElementText.Clone())
            dctTemp.Add("axis.title.x", clsElementText.Clone())
            dctTemp.Add("axis.title.x.top", clsElementText.Clone())
            dctTemp.Add("axis.title.y", clsElementText.Clone())
            dctTemp.Add("axis.title.y.right", clsElementText.Clone())
            dctTemp.Add("axis.text", clsElementText.Clone())
            dctTemp.Add("axis.text.x", clsElementText.Clone())
            dctTemp.Add("axis.text.x.top", clsElementText.Clone())
            dctTemp.Add("axis.text.y", clsElementText.Clone())
            dctTemp.Add("axis.text.y.right", clsElementText.Clone())
            dctTemp.Add("axis.ticks", clsElementLine.Clone())
            dctTemp.Add("axis.ticks.x", clsElementLine.Clone())
            dctTemp.Add("axis.ticks.y", clsElementLine.Clone())
            dctTemp.Add("axis.ticks.length", clsUnit.Clone())
            dctTemp.Add("axis.line", clsElementLine.Clone())
            dctTemp.Add("axis.line.x", clsElementLine.Clone())
            dctTemp.Add("axis.line.y", clsElementLine.Clone())
            dctTemp.Add("legend.background", clsElementRect.Clone())
            ' dctTemp.Add("legend.margin", clsElementLine.Clone())
            dctTemp.Add("legend.spacing", clsUnit.Clone())
            dctTemp.Add("legend.spacing.x", clsUnit.Clone())
            dctTemp.Add("legend.spacing.y", clsUnit.Clone())
            dctTemp.Add("legend.key", clsElementRect.Clone())
            dctTemp.Add("legend.key.size", clsUnit.Clone())
            dctTemp.Add("legend.key.height", clsUnit.Clone())
            dctTemp.Add("legend.key.width", clsUnit.Clone())
            dctTemp.Add("legend.text", clsElementText.Clone())
            'dctTemp.Add("legend.text.align", clsElementText.Clone())
            dctTemp.Add("legend.title", clsElementText.Clone())
            'dctTemp.Add("legend.title.align", clsElementText.Clone())

            'dctTemp.Add("legend.box.margin", clsElementText.Clone())
            dctTemp.Add("legend.box.background", clsElementRect.Clone())
            'dctTemp.Add("legend.box.spacing", clsElementText.Clone())
            dctTemp.Add("panel.background", clsElementRect.Clone())
            dctTemp.Add("panel.border", clsElementRect.Clone())
            dctTemp.Add("panel.spacing", clsUnit.Clone())
            dctTemp.Add("panel.spacing.x", clsUnit.Clone())
            dctTemp.Add("panel.spacing.y", clsUnit.Clone())
            dctTemp.Add("panel.grid", clsElementLine.Clone())
            dctTemp.Add("panel.grid.major", clsElementLine.Clone())
            dctTemp.Add("panel.grid.minor", clsElementLine.Clone())
            dctTemp.Add("panel.grid.major.x", clsElementLine.Clone())
            dctTemp.Add("panel.grid.major.y", clsElementLine.Clone())
            dctTemp.Add("panel.grid.minor.x", clsElementLine.Clone())
            dctTemp.Add("panel.grid.minor.y", clsElementLine.Clone())
            'dctTemp.Add("Panel.ontop", clsElementRect.Clone())
            dctTemp.Add("plot.background", clsElementRect.Clone())
            dctTemp.Add("plot.title", clsElementText.Clone())
            dctTemp.Add("plot.subtitle", clsElementText.Clone())
            dctTemp.Add("plot.caption", clsElementText.Clone())
            dctTemp.Add("plot.margin", clsUnit.Clone())
            dctTemp.Add("strip.background", clsElementRect.Clone())
            ' dctTemp.Add("strip.placement", clsElementLine.Clone())
            dctTemp.Add("strip.text", clsElementText.Clone())
            dctTemp.Add("strip.text.x", clsElementText.Clone())
            dctTemp.Add("strip.text.y", clsElementText.Clone())
            dctTemp.Add("strip.switch.pad.grid", clsUnit.Clone())
            dctTemp.Add("strip.switch.pad.wrap", clsUnit.Clone())
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

    Public Shared ReadOnly Property dctFontFace As Dictionary(Of String, String)
        Get
            Dim dctTempFontFace As New Dictionary(Of String, String)
            dctTempFontFace.Add("Plain", Chr(34) & "plain" & Chr(34))
            dctTempFontFace.Add("Bold", Chr(34) & "bold" & Chr(34))
            dctTempFontFace.Add("Italic", Chr(34) & "italic" & Chr(34))
            dctTempFontFace.Add("Bold italic", Chr(34) & "bold.italic" & Chr(34))
            Return dctTempFontFace
        End Get
    End Property

    Public Shared ReadOnly Property dctColour As Dictionary(Of String, String)
        Get
            Dim dctTempColour As New Dictionary(Of String, String)
            dctTempColour.Add("Black", Chr(34) & "black" & Chr(34))
            dctTempColour.Add("Red", Chr(34) & "red" & Chr(34))
            dctTempColour.Add("Blue", Chr(34) & "blue" & Chr(34))
            dctTempColour.Add("Grey", Chr(34) & "grey" & Chr(34))
            dctTempColour.Add("Yellow", Chr(34) & "yellow" & Chr(34))
            dctTempColour.Add("Yellow-Green", Chr(34) & "yellowgreen" & Chr(34))
            Return dctTempColour
        End Get
    End Property

    Public Shared ReadOnly Property dctLineType As Dictionary(Of String, String)
        Get
            Dim dctTempLineType As New Dictionary(Of String, String)
            dctTempLineType.Add("Blank", Chr(34) & "blank" & Chr(34))
            dctTempLineType.Add("Solid", Chr(34) & "solid" & Chr(34))
            dctTempLineType.Add("Dashed", Chr(34) & "dashed" & Chr(34))
            dctTempLineType.Add("Dotted", Chr(34) & "dotted" & Chr(34))
            dctTempLineType.Add("Dot-dash", Chr(34) & "dotdash" & Chr(34))
            dctTempLineType.Add("Long-dash", Chr(34) & "longdash" & Chr(34))
            dctTempLineType.Add("Two-Dash", Chr(34) & "twodash" & Chr(34))
            dctTempLineType.Add("1F", Chr(34) & "1F" & Chr(34))
            dctTempLineType.Add("F1", Chr(34) & "F1" & Chr(34))
            dctTempLineType.Add("4C88C488", Chr(34) & "4C88C488" & Chr(34))
            dctTempLineType.Add("12345678", Chr(34) & "12345678" & Chr(34))
            Return dctTempLineType
        End Get
    End Property

    Public Shared ReadOnly Property dctLineEnd As Dictionary(Of String, String)
        Get
            Dim dctTempLineEnd As New Dictionary(Of String, String)
            dctTempLineEnd.Add("None", Chr(34) & "NULL" & Chr(34))
            dctTempLineEnd.Add("round", Chr(34) & "round" & Chr(34))
            dctTempLineEnd.Add("butt", Chr(34) & "butt" & Chr(34))
            dctTempLineEnd.Add("square", Chr(34) & "square" & Chr(34))
            Return dctTempLineEnd
        End Get
    End Property

    Public Shared ReadOnly Property dctUnits As Dictionary(Of String, String)
        Get
            Dim dctTempUnits As New Dictionary(Of String, String)
            dctTempUnits.Add("Normalised Parent Coordinates", Chr(34) & "npc" & Chr(34))
            dctTempUnits.Add("Centimetres", Chr(34) & "cm" & Chr(34))
            dctTempUnits.Add("Inches", Chr(34) & "inches" & Chr(34))
            dctTempUnits.Add("Millimetres", Chr(34) & "mm" & Chr(34))
            dctTempUnits.Add("Points", Chr(34) & "points" & Chr(34))
            dctTempUnits.Add("Picas", Chr(34) & "picas" & Chr(34))
            dctTempUnits.Add("Big Points", Chr(34) & "bigpts" & Chr(34))
            dctTempUnits.Add("Dida", Chr(34) & "dida" & Chr(34))
            dctTempUnits.Add("Cicero", Chr(34) & "cicero" & Chr(34))
            dctTempUnits.Add("Scaled Points", Chr(34) & "scaledpts" & Chr(34))
            dctTempUnits.Add("Lines", Chr(34) & "lines" & Chr(34))
            dctTempUnits.Add("Character", Chr(34) & "char" & Chr(34))
            dctTempUnits.Add("Native", Chr(34) & "native" & Chr(34))
            dctTempUnits.Add("String Width", Chr(34) & "strwidth" & Chr(34))
            dctTempUnits.Add("String Height", Chr(34) & "strheight" & Chr(34))
            dctTempUnits.Add("Square Normalised Parent Coordinates", Chr(34) & "snpc" & Chr(34))
            dctTempUnits.Add("Grop Height", Chr(34) & "grobheight" & Chr(34))
            dctTempUnits.Add("Grop Width", Chr(34) & "grobwidth" & Chr(34))
            Return dctTempUnits
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

    Public Shared ReadOnly Property dctTransformations As Dictionary(Of String, String)
        Get
            Dim dcttempTransfromations As New Dictionary(Of String, String)
            dcttempTransfromations.Add("asn", Chr(34) & "asn" & Chr(34))
            dcttempTransfromations.Add("atanh", Chr(34) & "atanh" & Chr(34))
            dcttempTransfromations.Add("boxcox", Chr(34) & "boxcox" & Chr(34))
            dcttempTransfromations.Add("exp", Chr(34) & "exp" & Chr(34))
            dcttempTransfromations.Add("identity", Chr(34) & "identity" & Chr(34))
            dcttempTransfromations.Add("log", Chr(34) & "log" & Chr(34))
            dcttempTransfromations.Add("log10", Chr(34) & "log10" & Chr(34))
            dcttempTransfromations.Add("log1p", Chr(34) & "log1p" & Chr(34))
            dcttempTransfromations.Add("log2", Chr(34) & "log2" & Chr(34))
            dcttempTransfromations.Add("logit", Chr(34) & "logit" & Chr(34))
            dcttempTransfromations.Add("probability", Chr(34) & "probability" & Chr(34))
            dcttempTransfromations.Add("probit", Chr(34) & "probit" & Chr(34))
            dcttempTransfromations.Add("reciprocal", Chr(34) & "reciprocal" & Chr(34))
            dcttempTransfromations.Add("reverse", Chr(34) & "reverse" & Chr(34))
            dcttempTransfromations.Add("sqrt", Chr(34) & "sqrt" & Chr(34))
            Return dcttempTransfromations
        End Get
    End Property


    Public Shared ReadOnly Property dctXPosition As Dictionary(Of String, String)
        Get
            Dim dctTempXPosition As New Dictionary(Of String, String)
            dctTempXPosition.Add("Top", Chr(34) & "top" & Chr(34))
            dctTempXPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
            Return dctTempXPosition
        End Get
    End Property

    Public Shared ReadOnly Property dctYPosition As Dictionary(Of String, String)
        Get
            Dim dctTempYPosition As New Dictionary(Of String, String)
            dctTempYPosition.Add("Left", Chr(34) & "left" & Chr(34))
            dctTempYPosition.Add("Right", Chr(34) & "right" & Chr(34))
            Return dctTempYPosition
        End Get
    End Property
End Class