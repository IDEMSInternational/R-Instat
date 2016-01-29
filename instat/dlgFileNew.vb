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

Public Class dlgFileNew
    Public clsMatrix As New RFunction

    Private Sub dlgFileNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        'TODO What should these defaults be?
        '     Defaults should be stored in Options dialog 
        txtRows.Text = 10
        txtColumns.Text = 2
        'TODO add this line back in with correct method name when Steve has written method
        'frmMain.clsRLink.clsEngine.Evaluate(frmMain.clsRLink.strInstatDataObject & "$get_next_default_object_name(" & Chr(34) & "Sheet" & Chr(34) & ")")
        'TODO remove line below when above is fixed
        txtName.Text = "Sheet1"
        ucrBase.clsRsyntax.SetFunction("matrix", clsMatrix)
        ucrBase.clsRsyntax.AddParameter("data", "NA", clsRFunction:=clsMatrix)
        ucrBase.clsRsyntax.AddParameter("nrow", txtRows.Text, clsRFunction:=clsMatrix)
        ucrBase.clsRsyntax.AddParameter("ncol", txtColumns.Text, clsRFunction:=clsMatrix)
        ucrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=clsMatrix)
        ucrBase.clsRsyntax.SetFunction("data.frame")
        ucrBase.clsRsyntax.SetAssignTo(txtName.Text, strTempDataframe:=txtName.Text)
    End Sub

    Private Sub txtColumns_Leave(sender As Object, e As EventArgs) Handles txtColumns.Leave
        ucrBase.clsRsyntax.AddParameter("ncol", txtColumns.Text, clsRFunction:=clsMatrix)
    End Sub

    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave
        ucrBase.clsRsyntax.SetAssignTo(txtName.Text, strTempDataframe:=txtName.Text)
    End Sub

    Private Sub txtRows_Leave(sender As Object, e As EventArgs) Handles txtRows.Leave
        ucrBase.clsRsyntax.AddParameter("nrow", txtRows.Text, clsRFunction:=clsMatrix)
    End Sub

End Class