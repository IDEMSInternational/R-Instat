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

    Public Shared ReadOnly Property clsDefaultTheme As RParameter
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
End Class
