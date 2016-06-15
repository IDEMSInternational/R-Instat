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
    Public clsAesFunction As New RFunction
    Public bFirstLoad As Boolean = True
    Public bAesInGeom As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ucrGeomWithAes.SetGeomFunction(clsGeomFunction)
        ucrGeomWithAes.SetAesFunction(clsAesFunction)
        ucrLayerParameter.SetGeomFunction(clsGeomFunction)
    End Sub

    Private Sub sdgLayers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            'bFirstLoad = False
        Else
            ReopenDialog()
        End If
        autoTranslate(Me)
    End Sub
    Private Sub InitialiseDialog()
        ucrLayerParameter.ucrGeomWithAes = ucrGeomWithAes
        ucrGeomWithAes.ucrLayersControl = ucrLayerParameter
    End Sub
    Private Sub SetDefaults()
        ucrGeomWithAes.UcrSelector.Reset()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Public Sub SetRSyntax(clsRSyntaxIn As RSyntax)
        clsRsyntax = clsRSyntaxIn
    End Sub

    Public Sub SetupLayer(clsTempGeomFunc As RFunction, clsTempAesFunc As RFunction, Optional bFixAes As Boolean = False, Optional bFixGeom As Boolean = False, Optional strDataframe As String = "")
        clsGeomFunction = clsTempGeomFunc
        clsAesFunction = clsTempAesFunc

        If bFixAes Then
            bAesInGeom = False
            'disable check boxs
        End If
        If strDataframe <> "" Then
            ucrGeomWithAes.SetDataframe(strDataframe, Not bFixAes)
        End If
    End Sub

    Public Function TestForOKEnabled() As Boolean
        Return ucrGeomWithAes.TestForOkEnabled()
    End Function
End Class
