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
    Public clsRsyntax As New RSyntax
    Public strNumericGeomFunction As String
    Public strCategoriacalGeomFunction As String
    Public strCategoricalGeomFunction As String

    Private Sub sdgOneVarGraph_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        autoTranslate(Me)
    End Sub

    Public Sub SetDefaults()
        lblNumberofColumns.Visible = False
        nudNumberofColumns.Visible = False
        chkSpecifyLayout.Checked = False
        chkFreeScaleAxisforFacets.Checked = False
        nudNumberofColumns.Value = 3
        ucrInputNumeric.Reset()
        ucrInputCategorical.Reset()
        ucrInputNumeric.SetName("Boxplot")
        ucrInputCategorical.SetName("Bar Chart")
        ucrInputNumeric.SetItems({"Boxplot", "Dot Plot", "Histogram", "Point Plot", "Density Plot", "Frequency Polygon"})
        ucrInputCategorical.SetItems({"Bar Chart", "Pie Chart", "Dot Plot"})
    End Sub

    Public Sub InitialiseDialog()
        nudNumberofColumns.Maximum = 10
        nudNumberofColumns.Minimum = 1
    End Sub

    Public Sub SetRSyntax(clsNewRSyntax As RSyntax)
        clsRsyntax = clsNewRSyntax
    End Sub

    Public Sub SetNumericGeomFunction(strNumeric As String)
        strNumericGeomFunction = strNumeric
    End Sub
    Public Sub SetCategoricalGeomFunction(strCategorical As String)
        strCategoriacalGeomFunction = strCategorical
    End Sub
    Private Sub chkSpecifyLayout_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpecifyLayout.CheckedChanged
        SpecifyLayoutControl()
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
        If ucrInputNumeric.cboInput.SelectedText = "Boxplot" Then
            strNumericGeomFunction = "geom_boxplot"

        ElseIf ucrInputNumeric.cboInput.SelectedText = "Histogram" Then
            strNumericGeomFunction = "geom_histogram"

        ElseIf ucrInputNumeric.cboInput.SelectedText = "Dot Plot" Then
            strNumericGeomFunction = "geom_dotplot"

        ElseIf ucrInputNumeric.cboInput.SelectedText = "Point Plot" Then
            strNumericGeomFunction = "geom_point"

        ElseIf ucrInputNumeric.cboInput.SelectedText = "Density Plot" Then
            strNumericGeomFunction = "geom_density"
        Else
            strNumericGeomFunction = "geom_freqpoly"
        End If
    End Sub

    Private Sub ucrInputNumeric_NameChanged() Handles ucrInputNumeric.NameChanged
        SetNumericGeomFunction()
    End Sub

    Public Sub SetCategoricalGeomFunction()
        If ucrInputCategorical.cboInput.SelectedText = "bar chart" Then
            strCategoriacalGeomFunction = "geom_bar"
        ElseIf ucrInputCategorical.cboInput.SelectedText = "pie chart" Then
            strCategoriacalGeomFunction = "geom_histogram"
        Else
            strCategoriacalGeomFunction = "geom_dotplot"
        End If
    End Sub
    Private Sub ucrInputCategorical_NameChanged() Handles ucrInputCategorical.NameChanged
        SetCategoricalGeomFunction()
    End Sub
End Class