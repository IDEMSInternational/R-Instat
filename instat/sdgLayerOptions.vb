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
Public Class sdgLayerOptions
    Public clsRsyntax As RSyntax
    Public clsGeomFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private Sub sdgLayers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        autoTranslate(Me)
    End Sub

    Public Sub SetRSyntax(clsRSyntaxIn As RSyntax)
        clsRsyntax = clsRSyntaxIn
    End Sub

    Private Sub InitialiseDialog()
        clsGeomFunction.SetRCommand(ucrGeomWithAes.cboGeomList.SelectedItem)
        clsRsyntax.SetOperatorParameter(False, clsRFunc:=ucrGeomWithAes.clsGeomFunction)
    End Sub

    Private Sub SetDefaults()
        ucrGeomWithAes.UcrSelector.Reset()
    End Sub
    Private Sub ReopenDialog()

    End Sub
End Class
