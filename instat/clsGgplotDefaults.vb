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
            clsXlabTempFunc.SetRCommand("xlabs")
            clsXlabTempFunc.AddParameter("label", Chr(34) & Chr(34))
            Return clsXlabTempFunc
        End Get
    End Property
End Class
