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
Public Class ucrVariableName
    Dim firstChar As Char
    Dim CurrChar As Char
    Dim bAcceptableString As Boolean
    Public bUserTyped As Boolean = False
    Dim strReservedWords() As String = ({"if", "else", "repeat", "while", "function", "for", "in", "next", "break", "TRUE", "FALSE", "NULL", "Inf", "NaN", "NA", "NA_integer_", "NA_real_", "NA_complex_", "NA_character_"})
    Public Event NameChanged()
    'TODO this has a bug if using for setting default values in textbox if user does not use keyboard
    Private Sub txtValidation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValidation.KeyPress
        bUserTyped = True
    End Sub


    Public Sub Reset()
        bUserTyped = False
        txtValidation.Text = ""
    End Sub

    Public Function IsValidRString(strText As String) As Boolean
        If ValidateRString(strText) = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Returns integer as code for validation
    ' 0 : string is valid
    ' 1 : string is a reserved word
    ' 2 : string starts with invalid character
    ' 3 : string starts with "." followed by a number/nothing
    ' 4 : string contains a space
    ' 5 : string contains other invalid character
    Public Function ValidateRString(strText As String) As Integer
        If strText = "" Then
            Return 0
        End If

        If strReservedWords.Contains(strText) Then
            Return 1
        End If
        firstChar = strText(0)
        If Not Char.IsLetter(firstChar) Then
            If firstChar <> "." Then
                Return 2
            Else
                If txtValidation.Text.Length > 1 Then
                    If Char.IsNumber(txtValidation.Text(1)) Then
                        Return 3
                    End If
                Else
                    Return 3
                End If
            End If
        End If

        For Each CurrChar In txtValidation.Text
            bAcceptableString = Char.IsLetterOrDigit(CurrChar) Or CurrChar = "." Or CurrChar = "_"
            If Not bAcceptableString Then
                If CurrChar = " " Then
                    Return 4
                Else
                    Return 5
                End If
            End If
        Next
        Return 0
    End Function

    Public Sub ValidateTextBox()
        Dim iValidationCode As Integer
        iValidationCode = ValidateRString(txtValidation.Text)

        Select Case iValidationCode
            Case 0
                RaiseEvent NameChanged()
            Case 1
                MsgBox(Chr(34) & txtValidation.Text & Chr(34) & " is a reserved word in R and cannot be used.", vbOKOnly)
                txtValidation.Focus()
            Case 2
                MsgBox("This name cannot start with " & firstChar, vbOKOnly)
                txtValidation.Focus()
            Case 3
                MsgBox("This name cannot start with a dot followed by a number/nothing", vbOKOnly)
                txtValidation.Focus()
            Case 4
                MsgBox("This name cannot contain a space", vbOKOnly)
                txtValidation.Focus()
            Case 5
                MsgBox("This name cannot contain " & CurrChar, vbOKOnly)
                txtValidation.Focus()
        End Select

    End Sub

    Public Sub SetName(strName As String)
        If IsValidRString(strName) Then
            txtValidation.Text = strName
            RaiseEvent NameChanged()
        Else
            MsgBox(strName & "is not a valid R variable name", vbOKOnly)
        End If
    End Sub

    Private Sub txtValidation_Leave(sender As Object, e As EventArgs) Handles txtValidation.Leave
        ValidateTextBox()
    End Sub
End Class
