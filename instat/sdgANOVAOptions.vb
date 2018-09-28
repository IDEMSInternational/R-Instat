' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations

Public Class sdgANOVAOptions

    Public clsRModelFunction As RFunction
    Public clsRaovFunction As New RFunction
    Public bFirstLoad As Boolean = True


    Private Sub sdgANOVAOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        autoTranslate(Me)

        If bFirstLoad Then
            SetDefaultSettings()
            bFirstLoad = False
        End If
    End Sub

    Public Sub SetRModelFunction(clsRModelFunc As RFunction)
        clsRModelFunction = clsRModelFunc
    End Sub

    Public Sub SetDefaultSettings()
        chkANOVATable.Checked = True
    End Sub

    Private Sub AnovaTable()
        clsRaovFunction.SetRCommand("aov")
        clsRaovFunction.AddParameter("", clsRFunctionParameter:=clsRModelFunction)
        frmMain.clsRLink.RunScript(clsRaovFunction.ToScript(), 2)
    End Sub

    Public Sub Estimates()
        If (chkANOVATable.Checked) Then
            AnovaTable()
        End If
    End Sub
End Class