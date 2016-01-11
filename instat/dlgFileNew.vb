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
    Private Sub dlgFileNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        'ucrBase.clsRsyntax.SetFunction("data.frame(matrix")
        'ucrBase.clsRsyntax.SetAssignTo(txtName.Text)
    End Sub

    Private Sub txtColumns_Leave(sender As Object, e As EventArgs) Handles txtColumns.Leave
        '        ucrBase.clsRsyntax.AddParameter("ncol", txtColumns.Text)
    End Sub

    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave
        '        ucrBase.clsRsyntax.SetAssignTo(txtName.Text)
    End Sub

    Private Sub txtRows_Leave(sender As Object, e As EventArgs) Handles txtRows.Leave
        '        ucrBase.clsRsyntax.AddParameter("nrow", txtRows.Text)
    End Sub

    Private Sub ucrBase_Load(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        frmMain.clsRInterface.LoadData(txtName.Text, "data.frame(matrix(NA, nrow = " & txtRows.Text & ", ncol = " & txtColumns.Text & "))")
        frmMain.clsGrids.UpdateGrids()
    End Sub
End Class