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

Imports instat.Translations
Public Class ucrModelOperators
    Public bFirstLoad As Boolean
    Public operation As String

    Public Sub New()
        InitializeComponent()
        operation = "+"
        bFirstLoad = True
    End Sub

    Private Sub cmdParallelLines_Click(sender As Object, e As EventArgs) Handles cmdParallelLines.Click
        operation = "+"
        RaiseEvent ParallelLines(sender, e)
    End Sub

    Private Sub cmdConditional_Click(sender As Object, e As EventArgs) Handles cmdConditional.Click
        operation = ":"
        RaiseEvent Conditional(sender, e)
    End Sub

    Private Sub cmdJointLines_Click(sender As Object, e As EventArgs) Handles cmdJointLines.Click
        operation = "*"
        RaiseEvent JointLines(sender, e)
    End Sub

    Private Sub cmdCommonIntercept_Click(sender As Object, e As EventArgs) Handles cmdCommonIntercept.Click
        operation = "/"
        RaiseEvent CommonIntercept(sender, e)
    End Sub

    Public Event ParallelLines(sender As Object, e As EventArgs)
    Public Event Conditional(sender As Object, e As EventArgs)
    Public Event JointLines(sender As Object, e As EventArgs)
    Public Event CommonIntercept(sender As Object, e As EventArgs)
End Class