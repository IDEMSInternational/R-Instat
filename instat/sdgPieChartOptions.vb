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
Public Class sdgPieChartOptions
    Public clsPieChartFunction As RFunction
    Public Sub SetPieChartFunction(clsPieChartFunc As RFunction)
        clsPieChartFunction = clsPieChartFunc
    End Sub

    Public Sub SetDefaults()
        nudStartPoint.Value = "0"
        chkClockwise.Checked = True
    End Sub
    Private Sub nudStartPoint_TextChanged(sender As Object, e As EventArgs) Handles nudStartPoint.TextChanged
        If nudStartPoint.Value <> "" Then
            clsPieChartFunction.AddParameter("start", nudStartPoint.Value)
            clsPieChartFunction.RemoveParameterByName("start")
        End If
    End Sub

    Private Sub chkClockwise_CheckedChanged(sender As Object, e As EventArgs) Handles chkClockwise.CheckedChanged
        If Not chkClockwise.Checked Then
            clsPieChartFunction.AddParameter("direction", -1)
        Else
            clsPieChartFunction.AddParameter("direction", 1)
        End If
    End Sub
End Class