' Instat-R
' Copyright (C) 2015
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat.Translations
Public Class sdgDescribeTwoVarGraph
    ' Public bControlsInitialised As Boolean = False
    'Public clsGraphOneVariable As New ROperator
    Public bFirstLoad As Boolean = True

    Private Sub sdgDescribeTwoVarGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            bFirstLoad = False
        End If
    End Sub

    Public Sub InitialiseControls()
        'Dim dctNumericByNumericPairs As New Dictionary(Of String, String)
        'Dim dctucrNumericByCategorical As New Dictionary(Of String, String)
        'Dim dctucrCategoricalByNumeric As New Dictionary(Of String, String)
        'Dim dctucrCategoricalByCategorical As New Dictionary(Of String, String)

        'dctNumericByNumericPairs.Add("Scatter plot", Chr(34) & "geom_point" & Chr(34))
        'dctNumericByNumericPairs.Add("Line plot", Chr(34) & "geom_boxplot" & Chr(34))
        'dctNumericByNumericPairs.Add("Scatter and line plot", Chr(34) & "geom_line" & Chr(34))
        '' dctNumericByNumericPairs.Add("Scatter and line plot", Chr(34) & "geom_point" & Chr(34))
        'ucrNumericByNumeric.SetItems(dctNumericByNumericPairs)

        'dctucrNumericByCategorical.Add("Box plot", Chr(34) & "geom_boxplot" & Chr(34))
        'dctucrNumericByCategorical.Add("Histogram", Chr(34) & "geom_histogram" & Chr(34))
        'dctucrNumericByCategorical.Add("Density plot", Chr(34) & "geom_density" & Chr(34))
        'dctucrNumericByCategorical.Add("Frequency polygon", Chr(34) & "geom_freqpoly" & Chr(34))
        'dctucrNumericByCategorical.Add("Dot plot", Chr(34) & "geom_dotplot" & Chr(34))
        'dctucrNumericByCategorical.Add("Point plot", Chr(34) & "geom_point" & Chr(34))
        'ucrNumericByCategorical.SetItems(dctucrNumericByCategorical)


        'dctucrCategoricalByNumeric.Add("Box plot", Chr(34) & "geom_boxplot" & Chr(34))
        'dctucrCategoricalByNumeric.Add("Histogram", Chr(34) & "geom_histogram" & Chr(34))
        'dctucrCategoricalByNumeric.Add("Density plot", Chr(34) & "geom_density" & Chr(34))
        'dctucrCategoricalByNumeric.Add("Frequency polygon", Chr(34) & "geom_freqpoly" & Chr(34))
        'dctucrCategoricalByNumeric.Add("Dot plot", Chr(34) & "geom_dotplot" & Chr(34))
        'dctucrCategoricalByNumeric.Add("Point plot", Chr(34) & "geom_point" & Chr(34))
        'ucrCategoricalByNumeric.SetItems(dctucrCategoricalByNumeric)

        'dctucrCategoricalByCategorical.Add("Dot plot", Chr(34) & "geom_dotplot" & Chr(34))
        'dctucrCategoricalByCategorical.Add("Point plot", Chr(34) & "geom_point" & Chr(34))
        'ucrCategoricalByCategorical.SetItems(dctucrCategoricalByCategorical)

        ucrNumericByNumeric.SetItems({"Scatter plot", "Line plot", "Scatter and line plot"})
        ucrNumericByNumeric.SetName("Scatter plot")
        ucrNumericByNumeric.SetDropDownStyleAsNonEditable()
        ucrNumericByCategorical.SetItems({"Box plot", "Histogram", "Density plot", "Frequency polygon", "Dot plot", "Point plot"})
        'How different is the point plot from the summary plot?
        ucrNumericByCategorical.SetName("Box plot")
        ucrNumericByCategorical.SetDropDownStyleAsNonEditable()
        'ucrCategoricalByNumeric.SetItems({"Summary plot"})
        ucrCategoricalByNumeric.SetItems({"Box plot", "Histogram", "Density plot", "Frequency polygon", "Dot plot", "Point plot"})
        ucrCategoricalByNumeric.SetName("Box plot")
        ucrCategoricalByNumeric.SetDropDownStyleAsNonEditable()
        ucrCategoricalByCategorical.SetItems({"Bar plot", "Dot plot"})
        ucrCategoricalByCategorical.SetName("Bar plot")
        ucrCategoricalByCategorical.SetDropDownStyleAsNonEditable()
    End Sub

    'Public Sub GrpBoxEnable()
    '    If ((dlgDescribeTwoVarGraph.strVarType = "numeric" OrElse dlgDescribeTwoVarGraph.strVarType = "integer") And (dlgDescribeTwoVarGraph.strSecondVarType = "numeric" OrElse dlgDescribeTwoVarGraph.strSecondVarType = "integer")) Then
    '        ucrNumericByNumeric.Enabled = True
    '        ucrNumericByCategorical.Enabled = False
    '        ucrCategoricalByNumeric.Enabled = False
    '        ucrCategoricalByCategorical.Enabled = False
    '    ElseIf ((dlgDescribeTwoVarGraph.strVarType = "numeric" OrElse dlgDescribeTwoVarGraph.strVarType = "integer") And (dlgDescribeTwoVarGraph.strSecondVarType = "factor" OrElse dlgDescribeTwoVarGraph.strSecondVarType = "character" OrElse dlgDescribeTwoVarGraph.strSecondVarType = "logical")) Then
    '        ucrNumericByNumeric.Enabled = False
    '        ucrNumericByCategorical.Enabled = True
    '        ucrCategoricalByNumeric.Enabled = False
    '        ucrCategoricalByCategorical.Enabled = False
    '    ElseIf ((dlgDescribeTwoVarGraph.strVarType = "factor" OrElse dlgDescribeTwoVarGraph.strVarType = "character" OrElse dlgDescribeTwoVarGraph.strVarType = "logical") And (dlgDescribeTwoVarGraph.strSecondVarType = "numeric" OrElse dlgDescribeTwoVarGraph.strSecondVarType = "integer")) Then
    '        ucrNumericByNumeric.Enabled = False
    '        ucrNumericByCategorical.Enabled = False
    '        ucrCategoricalByNumeric.Enabled = True
    '        ucrCategoricalByCategorical.Enabled = False
    '    ElseIf ((dlgDescribeTwoVarGraph.strVarType = "factor" OrElse dlgDescribeTwoVarGraph.strVarType = "character" OrElse dlgDescribeTwoVarGraph.strVarType = "logical") And (dlgDescribeTwoVarGraph.strSecondVarType = "factor" OrElse dlgDescribeTwoVarGraph.strSecondVarType = "character" OrElse dlgDescribeTwoVarGraph.strSecondVarType = "logical")) Then
    '        ucrNumericByNumeric.Enabled = False
    '        ucrNumericByCategorical.Enabled = False
    '        ucrCategoricalByNumeric.Enabled = False
    '        lblCategoricalByCategorical.Enabled = True
    '        ucrCategoricalByCategorical.Enabled = True
    '    End If
    'End Sub

    'Public Sub SetRFunction(clsNewGraphOneVariable As ROperator, Optional bReset As Boolean = False)
    '    If Not bControlsInitialised Then
    '        InitialiseControls()
    '    End If
    '    clsGraphOneVariable = clsNewGraphOneVariable

    'End Sub

    Private Sub ucrGraphs_NameChanged() Handles ucrNumericByNumeric.NameChanged, ucrNumericByCategorical.NameChanged, ucrCategoricalByNumeric.NameChanged, ucrCategoricalByCategorical.NameChanged
        dlgDescribeTwoVarGraph.Results()
    End Sub
End Class