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
Public Class sdgOneVarGraph
    Public bFirstLoad As Boolean = True
    Public clsGraphOneVariable As New RFunction
    Public strNumericGeomFunction As String
    Public strCategoriacalGeomFunction As String
    Public clsCoordPolarFunction As New RFunction

    Private Sub sdgOneVarGraph_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        autoTranslate(Me)
        UpdateControls(Me, clsGraphOneVariable)
    End Sub

    Public Sub SetDefaults()
        lblNumberofColumns.Visible = False
        nudNumberofColumns.Visible = False
        chkSpecifyLayout.Checked = False
        chkFreeScaleAxisforFacets.Checked = False
        nudNumberofColumns.Value = 3
        ucrInputNumeric.Reset()
        ucrInputCategorical.Reset()
        'ucrInputNumeric.SetName("Boxplot")
        'ucrInputCategorical.SetName("Bar Chart")
    End Sub

    Public Sub InitialiseDialog()
        Dim lstNumericPairs As New List(Of KeyValuePair(Of String, String))
        Dim lstCategoricalPairs As New List(Of KeyValuePair(Of String, String))

        lstNumericPairs.Add(New KeyValuePair(Of String, String)("Boxplot", Chr(34) & "geom_boxplot" & Chr(34)))
        lstNumericPairs.Add(New KeyValuePair(Of String, String)("Dotplot", "geom_dotplot"))
        lstNumericPairs.Add(New KeyValuePair(Of String, String)("Histogram", "geom_histogram"))
        ucrInputNumeric.SetItems(lstNumericPairs)
        'ucrInputNumeric.SetItems({"Boxplot", "Dot Plot", "Histogram", "Point Plot", "Density Plot", "Frequency Polygon", "Violin Plot", "Jitter Plot", "Boxplot + Jitter", "Violin + Jitter", "Violin + Boxplot"})

        lstCategoricalPairs.Add(New KeyValuePair(Of String, String)("Bar Chart", "geom_bar"))
        lstCategoricalPairs.Add(New KeyValuePair(Of String, String)("Pie Chart", "pie_chart"))
        lstCategoricalPairs.Add(New KeyValuePair(Of String, String)("Dot Plot", "geom_dotplot"))
        ucrInputCategorical.SetItems(lstCategoricalPairs)
        'ucrInputCategorical.SetItems({"Bar Chart", "Pie Chart", "Dot Plot"})
        clsCoordPolarFunction.SetRCommand("coord_polar")
        nudNumberofColumns.Maximum = 10
        nudNumberofColumns.Minimum = 1
        ucrInputNumeric.SetParameterName("numeric")
        ucrInputCategorical.SetParameterName("categorical")
    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction)
        clsGraphOneVariable = clsNewRFunction
    End Sub

    Private Sub SpecifyLayoutControl()
        If chkSpecifyLayout.Checked Then
            lblNumberofColumns.Visible = True
            nudNumberofColumns.Visible = True
        Else
            lblNumberofColumns.Visible = False
            nudNumberofColumns.Visible = False
        End If
    End Sub

    Public Sub SetNumericGeomFunction()
        Select Case ucrInputNumeric.GetText
            Case "Boxplot"
                clsGraphOneVariable.AddParameter("numeric", Chr(34) & "geom_boxplot" & Chr(34))
            Case "Histogram"
                clsGraphOneVariable.AddParameter("numeric", Chr(34) & "geom_histogram" & Chr(34))
            Case "Dot Plot"
                clsGraphOneVariable.AddParameter("numeric", Chr(34) & "geom_dotplot" & Chr(34))
            Case "Point Plot"
                clsGraphOneVariable.AddParameter("numeric", Chr(34) & "geom_point" & Chr(34))
            Case "Density Plot"
                clsGraphOneVariable.AddParameter("numeric", Chr(34) & "geom_density" & Chr(34))
            Case "Frequency Polygon"
                clsGraphOneVariable.AddParameter("numeric", Chr(34) & "geom_freqpoly" & Chr(34))
            Case "Violin Plot"
                clsGraphOneVariable.AddParameter("numeric", Chr(34) & "geom_violin" & Chr(34))
            Case "Jitter Plot"
                clsGraphOneVariable.AddParameter("numeric", Chr(34) & "geom_jitter" & Chr(34))
            Case "Boxplot + Jitter"
                clsGraphOneVariable.AddParameter("numeric", Chr(34) & "box_jitter" & Chr(34))
            Case "Violin + Jitter"
                clsGraphOneVariable.AddParameter("numeric", Chr(34) & "violin_jitter" & Chr(34))
            Case "Violin + Boxplot"
                clsGraphOneVariable.AddParameter("numeric", Chr(34) & "violin_box" & Chr(34))
            Case Else
                clsGraphOneVariable.RemoveParameterByName("numeric")
        End Select
    End Sub

    Private Sub ucrInputNumeric_NameChanged() Handles ucrInputNumeric.NameChanged
        SetNumericGeomFunction()
    End Sub

    Public Sub SetCategoricalGeomFunction()
        Select Case ucrInputCategorical.GetText
            Case "Bar Chart"
                clsGraphOneVariable.AddParameter("categorical", Chr(34) & "geom_bar" & Chr(34))
                clsGraphOneVariable.RemoveParameterByName("polar")
            Case "Dot Plot"
                clsGraphOneVariable.AddParameter("categorical", Chr(34) & "geom_dotplot" & Chr(34))
                clsGraphOneVariable.RemoveParameterByName("polar")
            Case "Pie Chart"
                clsGraphOneVariable.AddParameter("categorical", Chr(34) & "geom_bar" & Chr(34))
                clsGraphOneVariable.AddParameter("polar", "TRUE")
            Case Else
                clsGraphOneVariable.RemoveParameterByName("categorical")
                clsGraphOneVariable.RemoveParameterByName("polar")
        End Select
    End Sub

    Private Sub ucrInputCategorical_NameChanged() Handles ucrInputCategorical.NameChanged
        SetCategoricalGeomFunction()
    End Sub

    Private Sub chkFreeScaleAxisforFacets_CheckedChanged(sender As Object, e As EventArgs) Handles chkFreeScaleAxisforFacets.CheckedChanged
        If chkFreeScaleAxisforFacets.Checked Then
            clsGraphOneVariable.AddParameter("free_scale_axis", "TRUE")
        Else
            clsGraphOneVariable.RemoveParameterByName("free_scale_axis")
        End If
    End Sub

    Private Sub nudNumberofColumns_TextChanged(sender As Object, e As EventArgs) Handles nudNumberofColumns.TextChanged, chkSpecifyLayout.CheckedChanged
        SpecifyLayoutControl()
        If nudNumberofColumns.Text <> "" AndAlso chkSpecifyLayout.Checked Then
            clsGraphOneVariable.AddParameter("ncol", nudNumberofColumns.Value)
        Else
            clsGraphOneVariable.RemoveParameterByName("ncol")
        End If
    End Sub
End Class
