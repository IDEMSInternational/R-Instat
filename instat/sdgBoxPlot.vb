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

Public Class sdgBoxPlot
    Public clsBoxplotFunction As RFunction

    Public Sub SetBoxPlotFunction(clsBoxPlotFunc As RFunction)
        clsBoxplotFunction = clsBoxPlotFunc
    End Sub
    Private Sub sdgBoxPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
        autoTranslate(Me)
        SetSubdialogDefaults()
    End Sub

    Public Sub SetSubdialogDefaults()
        chkHorizontalBoxplot.Checked = False
        chkNotchedBoxplot.Checked = False
        chkVariableWidth.Checked = False
    End Sub

    Private Sub chkVariableWidth_CheckedChanged(sender As Object, e As EventArgs) Handles chkVariableWidth.CheckedChanged
        If chkVariableWidth.Checked Then
            clsBoxplotFunction.AddParameter("varwidth", "TRUE")
        Else
            clsBoxplotFunction.RemoveParameterByName("varwidth")
        End If
    End Sub

    Private Sub chkNotchedBoxplot_CheckedChanged(sender As Object, e As EventArgs) Handles chkNotchedBoxplot.CheckedChanged
        If chkNotchedBoxplot.Checked Then
            clsBoxplotFunction.AddParameter("notch", "TRUE")
        Else
            clsBoxplotFunction.RemoveParameterByName("notch")
        End If
    End Sub
    Private Sub chkHorizontalBoxplot_CheckedChanged(sender As Object, e As EventArgs) Handles chkHorizontalBoxplot.CheckedChanged
        dlgBoxplot.SetOperator()
    End Sub
End Class