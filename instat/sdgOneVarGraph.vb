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
        ucrInputOther.Reset()
    End Sub

    Public Sub InitialiseDialog()
        ucrInputNumeric.SetName("Boxplot")
        ucrInputOther.SetName("Bar")
        ucrInputNumeric.SetItems({"Boxplot", "Dot Plot", "Histogram", "Point Plot", "Density Plot", "Frequency Polygon"})
        ucrInputOther.SetItems({"Bar", "Pie", "Dot Plot"})

        nudNumberofColumns.Maximum = 10
        nudNumberofColumns.Minimum = 1
    End Sub

    Public Sub SetRSyntax(clsNewRSyntax As RSyntax)
        clsRsyntax = clsNewRSyntax
    End Sub
    Private Sub chkSpecifyLayout_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpecifyLayout.CheckedChanged
        If chkSpecifyLayout.Checked Then
            lblNumberofColumns.Visible = True
            nudNumberofColumns.Visible = True
        Else
            lblNumberofColumns.Visible = False
            nudNumberofColumns.Visible = False
        End If
    End Sub
End Class