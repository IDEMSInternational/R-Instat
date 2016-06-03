﻿' Instat-R
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
    Public clsGeomFunction As New RFunction
    Private bFirstLoad As Boolean = True

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ucrGeomWithAes.SetGeomFunction(clsGeomFunction)
        ucrLayerParameter.SetGeomFunction(clsGeomFunction)

    End Sub



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

    Private Sub InitialiseDialog()
        ucrLayerParameter.ucrGeomWithAes = ucrGeomWithAes
        ucrGeomWithAes.ucrLayersControl = ucrLayerParameter

        ucrGeomWithAes.SetGeomFunction(clsGeomFunction)
        ucrLayerParameter.SetGeomFunction(clsGeomFunction)
    End Sub

    Private Sub SetDefaults()
        ucrGeomWithAes.UcrSelector.Reset()
    End Sub
    Private Sub ReopenDialog()

    End Sub
End Class
