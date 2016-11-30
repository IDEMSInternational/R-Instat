' Instat+R
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

Public Class sdgMerge
    Private clsRSyntax As New RSyntax
    Private bFirstLoad As Boolean = True

    Private Sub sdgMerge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Public Sub SetDefaults()
        rdoLeftJoin.Checked = True
    End Sub

    Public Sub SetRSyntax(clsNewRSyntax As RSyntax)
        clsRSyntax = clsNewRSyntax
    End Sub

    Private Sub JoinType()
        If rdoLeftJoin.Checked Then
            clsRSyntax.SetFunction("left_join")
        ElseIf rdoFullJoin.Checked Then
            clsRSyntax.SetFunction("full_join")
        ElseIf rdoInnerJoin.Checked Then
            clsRSyntax.SetFunction("inner_join")
        ElseIf rdoRightJoin.Checked Then
            clsRSyntax.SetFunction("right_join")
        ElseIf rdoSemiJoin.Checked Then
            clsRSyntax.SetFunction("semi_join")
        ElseIf rdoAntiJoin.Checked Then
            clsRSyntax.SetFunction("anti_join")
        Else
            clsRSyntax.SetFunction("")
        End If
    End Sub

    Private Sub JoinType_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAntiJoin.CheckedChanged, rdoFullJoin.CheckedChanged, rdoInnerJoin.CheckedChanged, rdoLeftJoin.CheckedChanged, rdoRightJoin.CheckedChanged, rdoSemiJoin.CheckedChanged
        JoinType()
    End Sub
End Class