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

Public Class sdgCombineGraphOptions
    Private bFirstLoad As Boolean = True
    Public clsRsyntax As New RSyntax
    Private Sub sdgLayout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
        Me.BringToFront()
    End Sub

    Public Sub SetDefaults()
        ucrInputLeft.ResetText()
        ucrInputRight.ResetText()
        ucrInputTop.ResetText()
        ucrInputBottom.ResetText()
        SetDefaultRowAndColumns()
    End Sub

    Private Sub InitialiseDialog()

    End Sub

    Public Sub SetRSyntax(clsNewRSyntax As RSyntax)
        clsRsyntax = clsNewRSyntax
    End Sub

    Private Sub ucrInputTop_NameChanged() Handles ucrInputTop.NameChanged
        If Not ucrInputTop.IsEmpty Then
            clsRsyntax.AddParameter("top", ucrInputTop.GetText)
        Else
            clsRsyntax.RemoveParameter("top")
        End If

    End Sub

    Private Sub ucrInputBottom_NameChanged() Handles ucrInputBottom.NameChanged
        If Not ucrInputBottom.IsEmpty Then
            clsRsyntax.AddParameter("bottom", ucrInputBottom.GetText)
        Else
            clsRsyntax.RemoveParameter("bottom")
        End If
    End Sub

    Private Sub ucrInputRight_NameChanged() Handles ucrInputRight.NameChanged
        If Not ucrInputRight.IsEmpty Then
            clsRsyntax.AddParameter("right", ucrInputRight.GetText)
        Else
            clsRsyntax.RemoveParameter("right")
        End If
    End Sub

    Private Sub ucrInputLeft_NameChanged() Handles ucrInputLeft.NameChanged
        If Not ucrInputLeft.IsEmpty Then
            clsRsyntax.AddParameter("left", ucrInputLeft.GetText)
        Else
            clsRsyntax.RemoveParameter("left")
        End If

    End Sub

    Private Sub nudRows_TextChanged(sender As Object, e As EventArgs) Handles nudRows.TextChanged
        If nudRows.Text <> "" Then
            clsRsyntax.AddParameter("nrow", nudRows.Value)
        Else
            clsRsyntax.RemoveParameter("nrow")
        End If
    End Sub

    Private Sub nudColumns_TextChanged(sender As Object, e As EventArgs) Handles nudColumns.TextChanged
        If nudColumns.Text <> "" Then
            clsRsyntax.AddParameter("ncol", nudColumns.Value)
        Else
            clsRsyntax.RemoveParameter("ncol")
        End If
    End Sub

    Public Sub SetDefaultRowAndColumns()
        Dim NoOfgraphs As Integer
        If dlgCombineforGraphics.ucrCombineGraphReceiver.lstSelectedVariables.Items.Count > 0 Then
            NoOfgraphs = dlgCombineforGraphics.ucrCombineGraphReceiver.lstSelectedVariables.Items.Count
            nudColumns.Value = Math.Ceiling(Math.Sqrt(NoOfgraphs))
            nudRows.Value = Math.Ceiling((NoOfgraphs / Math.Sqrt(NoOfgraphs)))
        End If

    End Sub
End Class