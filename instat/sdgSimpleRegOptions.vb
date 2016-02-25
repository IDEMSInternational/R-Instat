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
Public Class sdgSimpleRegOptions
    Public clsRsyntax As RSyntax
    Public clsRaovFunction As New RFunction
    Public bFirstLoad As Boolean = True

    Private Sub sdgSimpleRegOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            bFirstLoad = False
            SetDefaults()
        End If
    End Sub

    Private Sub anovatable()
        clsRaovFunction.SetRCommand("aov")
        clsRaovFunction.AddParameter("", clsRFunctionParameter:=dlgRegressionSimple.ucrBase.clsRsyntax.clsBaseFunction)
        frmMain.clsRLink.RunScript(clsRaovFunction.ToScript(), 2)
    End Sub

    Public Sub SetDefaults()
        chkAnovaTable.Checked = False
    End Sub

    Public Sub RegOptions()
        If (chkAnovaTable.Checked) Then
            anovatable() 'is this the right way. How do I get it to the main dialogue?
        End If
    End Sub
End Class