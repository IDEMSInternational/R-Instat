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
    Public clsCoordPolarFunction As New RFunction

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
    End Sub

    Public Sub InitialiseDialog()
        clsCoordPolarFunction.SetRCommand("coord_polar")
        ucrInputNumeric.SetItems({"Boxplot", "Dot Plot", "Histogram", "Point Plot", "Density Plot", "Frequency Polygon", "Violin Plot", "Jitter Plot", "Boxplot + Jitter", "Violin +Jitter", "Violin + Boxplot"})
        ucrInputCategorical.SetItems({"Bar Chart", "Pie Chart", "Dot Plot"})
        nudNumberofColumns.Maximum = 10
        nudNumberofColumns.Minimum = 1

    End Sub

    Public Sub SetRSyntax(clsNewRSyntax As RSyntax)
        clsRsyntax = clsNewRSyntax
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
                clsRsyntax.AddParameter("numeric", Chr(34) & "geom_boxplot" & Chr(34))
            Case "Histogram"
                clsRsyntax.AddParameter("numeric", Chr(34) & "geom_histogram" & Chr(34))
            Case "Dot Plot"
                clsRsyntax.AddParameter("numeric", Chr(34) & "geom_dotplot" & Chr(34))
            Case "Point Plot"
                clsRsyntax.AddParameter("numeric", Chr(34) & "geom_point" & Chr(34))
            Case "Density Plot"
                clsRsyntax.AddParameter("numeric", Chr(34) & "geom_density" & Chr(34))
            Case "Frequency Polygon"
                clsRsyntax.AddParameter("numeric", Chr(34) & "geom_freqpoly" & Chr(34))
            Case "Violin Plot"
                clsRsyntax.AddParameter("numeric", Chr(34) & "geom_violin" & Chr(34))
            Case "Jitter Plot"
                clsRsyntax.AddParameter("numeric", Chr(34) & "geom_jitter" & Chr(34))
            Case "Boxplot + Jitter"
                clsRsyntax.AddParameter("numeric", Chr(34) & "box_jitter" & Chr(34))
            Case "Violin +Jitter"
                clsRsyntax.AddParameter("numeric", Chr(34) & "violin_jitter" & Chr(34))
            Case "Violin + Boxplot"
                clsRsyntax.AddParameter("numeric", Chr(34) & "violin_box" & Chr(34))
            Case Else
                clsRsyntax.RemoveParameter("numeric")
        End Select
    End Sub

    Private Sub ucrInputNumeric_NameChanged() Handles ucrInputNumeric.NameChanged
        SetNumericGeomFunction()
    End Sub

    Public Sub SetCategoricalGeomFunction()
        Select Case ucrInputCategorical.GetText
            Case "Bar Chart"
                clsRsyntax.AddParameter("categorical", Chr(34) & "geom_bar" & Chr(34))
                clsRsyntax.RemoveParameter("polar")
            Case "Dot Plot"
                clsRsyntax.AddParameter("categorical", Chr(34) & "geom_dotplot" & Chr(34))
                clsRsyntax.RemoveParameter("polar")
            Case "Pie Chart"
                clsRsyntax.AddParameter("categorical", Chr(34) & "geom_bar" & Chr(34))
                clsRsyntax.AddParameter("polar", "TRUE")
            Case Else
                clsRsyntax.RemoveParameter("categorical")
                clsRsyntax.RemoveParameter("polar")
        End Select
    End Sub
    Private Sub ucrInputCategorical_NameChanged() Handles ucrInputCategorical.NameChanged
        SetCategoricalGeomFunction()
    End Sub
    
    Private Sub chkFreeScaleAxisforFacets_CheckedChanged(sender As Object, e As EventArgs) Handles chkFreeScaleAxisforFacets.CheckedChanged
        If chkFreeScaleAxisforFacets.Checked Then
            clsRsyntax.AddParameter("free_scale_axis", "TRUE")
        Else
            clsRsyntax.RemoveParameter("free_scale_axis")
        End If
    End Sub

    Private Sub nudNumberofColumns_TextChanged(sender As Object, e As EventArgs) Handles nudNumberofColumns.TextChanged, chkSpecifyLayout.CheckedChanged
        SpecifyLayoutControl()
        If nudNumberofColumns.Text <> "" AndAlso chkSpecifyLayout.Checked Then
            clsRsyntax.AddParameter("ncol", nudNumberofColumns.Value)
        Else
            clsRsyntax.RemoveParameter("ncol")
        End If
    End Sub
End Class
