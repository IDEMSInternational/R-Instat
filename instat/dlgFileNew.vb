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
Imports RDotNet

Public Class dlgFileNew
    Public clsMatrix As New RFunction
    Public strDefaultSheetPrefix As String = "Sheet"
    Public iDefaultColumnNumber As Integer = 2
    Public iDefaultRowNumber As Integer = 10

    Private Sub dlgFileNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        'TODO What should these defaults be?
        '     Defaults should be stored in Options dialog 
        txtRows.Text = iDefaultRowNumber
        txtColumns.Text = iDefaultColumnNumber

        txtName.Text = frmMain.clsRLink.GetDefaultDataFrameName(strDefaultSheetPrefix).ToString()
        clsMatrix.SetRCommand("matrix")
        clsMatrix.AddParameter("data", "NA")
        clsMatrix.AddParameter("nrow", txtRows.Text)
        clsMatrix.AddParameter("ncol", txtColumns.Text)

        ucrBase.clsRsyntax.SetFunction("data.frame")
        ucrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=clsMatrix)

        ucrBase.clsRsyntax.SetAssignTo(txtName.Text, strTempDataframe:=txtName.Text)
    End Sub

    Private Sub txtColumns_Leave(sender As Object, e As EventArgs) Handles txtColumns.Leave
        clsMatrix.AddParameter("ncol", txtColumns.Text)
    End Sub

    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave
        ucrBase.clsRsyntax.SetAssignTo(txtName.Text, strTempDataframe:=txtName.Text)
    End Sub

    Private Sub txtRows_Leave(sender As Object, e As EventArgs) Handles txtRows.Leave
        clsMatrix.AddParameter("nrow", txtRows.Text)
    End Sub

End Class