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

Public Class sdgLayout
    Private bFirstLoad As Boolean = True
    Public clsRSyntax As New RSyntax
    Private Sub sdgLayout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
        Me.BringToFront()
    End Sub

    Public Sub SetDefaults()
        ucrInputTop.ResetText()
        ucrInputRight.ResetText()
        ucrInputLeft.ResetText()
        ucrInputBottom.ResetText()
    End Sub
    Private Sub InitialiseDialog()

    End Sub
    Public Sub SetRSyntax(clsRSyntaxIn As RSyntax)
        clsRSyntax = clsRSyntaxIn
    End Sub
    Private Sub nudRows_ValueChanged(sender As Object, e As EventArgs) Handles nudRows.ValueChanged
        clsRSyntax.AddParameter("nrow", nudRows.Value)
    End Sub

    Private Sub nudColumns_ValueChanged(sender As Object, e As EventArgs) Handles nudColumns.ValueChanged
        clsRSyntax.AddParameter("ncol", nudRows.Value)
    End Sub

    Private Sub ucrInputTop_NameChanged() Handles ucrInputTop.NameChanged
        If Not ucrInputTop.IsEmpty Then
            clsRSyntax.AddParameter("top", ucrInputTop.GetText())
        Else
            clsRSyntax.RemoveParameter("top")
        End If
    End Sub

    Private Sub ucrInputBottom_NameChanged() Handles ucrInputBottom.NameChanged
        If Not ucrInputTop.IsEmpty Then
            clsRSyntax.AddParameter("bottom", ucrInputBottom.GetText())
        Else
            clsRSyntax.RemoveParameter("bottom")
        End If
    End Sub

    Private Sub ucrInputRight_NameChanged() Handles ucrInputRight.NameChanged
        If Not ucrInputTop.IsEmpty Then
            clsRSyntax.AddParameter("right", ucrInputRight.GetText())
        Else
            clsRSyntax.RemoveParameter("right")
        End If
    End Sub

    Private Sub ucrInputLeft_NameChanged() Handles ucrInputLeft.NameChanged
        If Not ucrInputTop.IsEmpty Then
            clsRSyntax.AddParameter("left", ucrInputLeft.GetText())
        Else
            clsRSyntax.RemoveParameter("left")
        End If
    End Sub
End Class