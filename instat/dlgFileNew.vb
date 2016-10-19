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
    Public bFirstLoad As Boolean = True

    Private Sub dlgFileNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        'TODO What should these defaults be?
        '     Defaults should be stored in Options dialog 

        ucrName.Text = frmMain.clsRLink.GetDefaultDataFrameName(strDefaultSheetPrefix).ToString()
        ucrBase.clsRsyntax.SetAssignTo(ucrName.Text, strTempDataframe:=ucrName.Text)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        nudRows.Maximum = 10000
        nudRows.Minimum = 1
        nudColumns.Maximum = 10000
        nudColumns.Minimum = 1
        ucrName.SetValidationTypeAsRVariable()
        clsMatrix.SetRCommand("matrix")
        clsMatrix.AddParameter("data", "NA")
        ucrBase.clsRsyntax.SetFunction("data.frame")
        ucrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=clsMatrix)
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub SetDefaults()
        nudRows.Value = 10
        nudColumns.Value = 2
    End Sub

    Private Sub nudColumns_ValueChanged(sender As Object, e As EventArgs) Handles nudColumns.ValueChanged
        clsMatrix.AddParameter("ncol", nudColumns.Value.ToString())
    End Sub

    Private Sub nudRows_ValueChanged(sender As Object, e As EventArgs) Handles nudRows.ValueChanged
        clsMatrix.AddParameter("nrow", nudRows.Value.ToString())
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrName.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrName_NameChanged() Handles ucrName.NameChanged
        TestOKEnabled()
End Class
End Sub