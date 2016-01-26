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

Public Class dlgImportDataset
    Public strFilePath As String

    Private Sub dlgImportDataset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("read.csv")
        autoTranslate(Me)
        cboEncoding.Text = "Automatic"
        rdoYes.Checked = True
        cboRowNames.Text = "Automatic"

        cboSeparator.Text = "Comma"
        ucrBase.clsRsyntax.AddParameter("sep", "Comma")

        cboDecimal.Text = "Period"
        ucrBase.clsRsyntax.AddParameter("dec", Chr(34) & "." & Chr(34))

        cboQuote.Text = "Double quote"
        ucrBase.clsRsyntax.AddParameter("quote", Chr(34) & "\" & Chr(34) & Chr(34))

        cboComment.Text = "None"
        ucrBase.clsRsyntax.AddParameter("comment.Char", "None")

        txtNAStrings.Text = "NA"
        ucrBase.clsRsyntax.AddParameter("na.strings", "NA")

    End Sub

    Public Sub SetName(strName As String)
        strName = Replace(strName, " ", "")
        strName = Replace(strName, "-", "")
        txtName.Text = strName
        ucrBase.clsRsyntax.SetAssignTo(txtName.Text, strTempDataframe:=txtName.Text)
    End Sub

    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave
        ucrBase.clsRsyntax.SetAssignTo(txtName.Text, strTempDataframe:=txtName.Text)
    End Sub

    Private Sub cboEncoding_Leave(sender As Object, e As EventArgs) Handles cboEncoding.Leave
        If cboEncoding.Text <> "Automatic" Then
            ucrBase.clsRsyntax.AddParameter("encoding", cboEncoding.Text)
        End If
    End Sub

    Private Sub cboRowNames_Leave(sender As Object, e As EventArgs) Handles cboRowNames.Leave
        If cboRowNames.Text <> "Automatic" Then

            ucrBase.clsRsyntax.AddParameter("row.names", cboRowNames.Text)
        End If
    End Sub

    Private Sub cboSeparator_Leave(sender As Object, e As EventArgs) Handles cboSeparator.Leave
        ucrBase.clsRsyntax.AddParameter("sep", cboSeparator.Text)
    End Sub

    Private Sub cboDecimal_Leave(sender As Object, e As EventArgs) Handles cboDecimal.Leave
        Select Case cboDecimal.Text
            Case "Period"
                ucrBase.clsRsyntax.AddParameter("dec", Chr(34) & "." & Chr(34))
            Case "Comma"
                ucrBase.clsRsyntax.AddParameter("dec", Chr(34) & "," & Chr(34))
        End Select
    End Sub

    Private Sub cboQuote_Leave(sender As Object, e As EventArgs) Handles cboQuote.Leave
        ucrBase.clsRsyntax.AddParameter("quote", cboQuote.Text)
    End Sub

    Private Sub cboComment_Leave(sender As Object, e As EventArgs) Handles cboComment.Leave
        ucrBase.clsRsyntax.AddParameter("comment.Char", cboComment.Text)
    End Sub

    Private Sub txtNAStrings_Leave(sender As Object, e As EventArgs) Handles txtNAStrings.Leave
        ucrBase.clsRsyntax.AddParameter("na.strings", txtNAStrings.Text)
    End Sub

End Class