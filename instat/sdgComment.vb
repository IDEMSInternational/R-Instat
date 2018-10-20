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


Public Class sdgComment
    Public Event evtLostFocus()

    Private Sub sdgComment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtComment.Focus()
    End Sub

    Private Sub txtComment_KeyDown(sender As Object, e As KeyEventArgs) Handles txtComment.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.Enter Then
            Me.Close()
        End If
    End Sub

    Public Sub setComment(strNewComment As String)
        txtComment.Text = strNewComment
    End Sub

    Public Function getComment() As String
        Return txtComment.Text
    End Function

    Private Sub txtComment_LostFocus(sender As Object, e As EventArgs) Handles txtComment.LostFocus
        RaiseEvent evtLostFocus()
    End Sub
End Class