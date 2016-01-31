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
Public Class ucrVariableName
    Dim firstChar As Char
    Dim CurrChar As Char
    Dim myColName As String
    Dim bAcceptableString As Boolean
    Dim lstResevedWords As New List(Of String)

    Private Sub txtValidation_Leave(sender As Object, e As EventArgs) Handles txtValidation.Leave
        lstResevedWords.Add("if")
        lstResevedWords.Add("else")
        lstResevedWords.Add("repeat")
        lstResevedWords.Add("while")
        lstResevedWords.Add("function")
        lstResevedWords.Add("for")
        lstResevedWords.Add("in")
        lstResevedWords.Add("next")
        lstResevedWords.Add("break")
        lstResevedWords.Add("true")
        lstResevedWords.Add("false")
        lstResevedWords.Add("null")
        lstResevedWords.Add("NAN")
        lstResevedWords.Add("Inf")
        lstResevedWords.Add("NA")
        lstResevedWords.Add("NA integer")
        lstResevedWords.Add("NA real")
        lstResevedWords.Add("NA complex")
        lstResevedWords.Add("NA character")

        myColName = txtValidation.Text
        bAcceptableString = True
        If txtValidation.Text = "" Then
            Exit Sub
        End If

        For i = 0 To lstResevedWords.Count - 1
            If myColName.Contains(lstResevedWords.Item(i)) Then
                MsgBox(lstResevedWords.Item(i) & "is a reseved keyword", vbOKOnly)
                txtValidation.Focus()
            End If
        Next

        firstChar = txtValidation.Text(0)
        If Not Char.IsLetter(firstChar) Then
            If firstChar <> "." Then
                MsgBox("This name cannot start with " & firstChar, vbOKOnly)
                txtValidation.Focus()
                Exit Sub
            Else
                If txtValidation.Text.Length > 1 Then
                    If Char.IsNumber(txtValidation.Text(1)) Then
                        MsgBox("This name cannot start with an underscore followed by a number", vbOKOnly)
                        txtValidation.Focus()
                        Exit Sub
                    End If
                Else
                    MsgBox("This name cannot equal .", vbOKOnly)
                    txtValidation.Focus()
                    Exit Sub
                End If
            End If
        End If

        For Each CurrChar In txtValidation.Text
            bAcceptableString = Char.IsLetterOrDigit(CurrChar) Or CurrChar = "." Or CurrChar = "_"
            If Not bAcceptableString Then
                If CurrChar = " " Then
                    MsgBox("This name cannot contain a space", vbOKOnly)
                    txtValidation.Focus()
                Else
                    MsgBox("This name cannot contain " & CurrChar, vbOKOnly)
                    txtValidation.Focus()
                End If
                Exit For
            End If
        Next
    End Sub

    Private Sub lblColumnName_Click(sender As Object, e As EventArgs) Handles lblColumnName.Click

    End Sub

    Private Sub ucrVariableName_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
