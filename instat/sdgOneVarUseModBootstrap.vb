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

Public Class sdgOneVarUseModBootstrap
    Public clsRBootMethod As New RFunction
    Public clsRsyntax As New RSyntax
    Public bfirstload As Boolean = True

    Private Sub sdgOneVarUseModBootstrap(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseDialog()
        clsRsyntax.AddParameter("bootmethod")
        clsRsyntax.AddParameter("niter")
        ' add in CI's,
        ' do we want this to be plotted? 
        nudIterations.Minimum = 1
        nudIterations.Maximum = 10001
        nudCI.Minimum = 0
        nudCI.Maximum = 1
        nudIterations.Increment = 100
        nudCI.Increment = 0.05
    End Sub

    Public Sub SetDefaults()
        chkParametric.Checked = True
        nudCI.Value = 0.95
        nudIterations.Value = 1001
    End Sub

    Public Sub SetMyRSyntax(clsRNewSyntax As RSyntax)
        clsRsyntax = clsRNewSyntax
    End Sub

    Private Sub chkParametric_CheckedChanged(sender As Object, e As EventArgs) Handles chkParametric.CheckedChanged
        If chkParametric.Checked Then
            clsRsyntax.AddParameter("bootmethod", Chr(34) & "param" & Chr(34))
        Else
            clsRsyntax.AddParameter("bootmethod", Chr(34) & "nonparam" & Chr(34))
        End If
    End Sub

    Private Sub nudIterations_ValueChanged(sender As Object, e As EventArgs) Handles nudIterations.ValueChanged
        clsRsyntax.AddParameter("niter", nudIterations.Value.ToString())
    End Sub

    ' confidence interval 
End Class