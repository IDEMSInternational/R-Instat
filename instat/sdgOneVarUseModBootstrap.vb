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
        'bootmethod = "param" is default
        clsRsyntax.AddParameter("niter")

    End Sub

    Public Sub SetDefaults()

    End Sub


End Class