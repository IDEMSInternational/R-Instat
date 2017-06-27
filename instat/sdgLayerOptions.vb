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
    Public clsGeomFunction As New RFunction
    Public clsAesFunction As New RFunction
    'clsAesFunction is the global aes function, used as mapping value in the ggplot function.
    Public clsGgplotFunction As New RFunction
    'clsGgplotFunction is the global ggplot function, linked through the ucrAdditionalLayers to either sdgPlots or dlgGeneralForGraphics.
    Public bFirstLoad As Boolean = True
    Public bAesInGeom As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Private Sub sdgLayers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrLayerParameter.ucrGeomWithAes = ucrGeomWithAes
        ucrGeomWithAes.ucrLayersControl = ucrLayerParameter
        ucrSdgLayerBase.iHelpTopicID = 569
        tbcLayers.SelectedIndex = 0
        'Each ucrLayerParameter has a field of type ucrGeomListWithAes and reciprocally as both of them "collaborate to provide full description of a Layer".
        'The obvious linking is performed here in sdgLayerOptions.
    End Sub

    Private Sub SetDefaults()
        ucrGeomWithAes.Reset()
    End Sub

    Public Sub SetupLayer(clsNewGgPlot As RFunction, clsNewGeomFunc As RFunction, clsNewGlobalAesFunc As RFunction, clsNewLocalAes As RFunction, Optional bFixGeom As Boolean = False, Optional ucrNewBaseSelector As ucrSelector = Nothing, Optional bApplyAesGlobally As Boolean = True, Optional iNumVariablesForGeoms As Integer = -1, Optional bReset As Boolean = False, Optional iTabToDisplay As Integer = 0, Optional strDataFrame As String = "")
        'If iTabToDisplay > 0 AndAlso iTabToDisplay <= tbcLayers.TabCount - 1 Then
        '    tbcLayers.SelectedIndex = iTabToDisplay
        'End If

        If bReset Then
            tbcLayers.SelectedIndex = 0
        End If
        clsGeomFunction = clsNewGeomFunc
        clsAesFunction = clsNewGlobalAesFunc
        clsGgplotFunction = clsNewGgPlot
        ucrGeomWithAes.Setup(clsNewGgPlot, clsNewGeomFunc, clsNewGlobalAesFunc, clsNewLocalAes, bFixGeom, ucrNewBaseSelector, bApplyAesGlobally, iNumVariablesForGeoms, bReset, strDataFrame)
        ucrLayerParameter.Setup(clsNewGgPlot, clsNewGeomFunc, clsNewGlobalAesFunc, clsNewLocalAes, bFixGeom, ucrNewBaseSelector, bApplyAesGlobally, iNumVariablesForGeoms, bReset, strDataFrame)
    End Sub

    Public Function TestForOKEnabled() As Boolean
        Return ucrGeomWithAes.TestForOkEnabled()
    End Function

    Private Sub ucrSdgLayerBase_ClickReturn(sender As Object, e As EventArgs) Handles ucrSdgLayerBase.ClickReturn
        ucrGeomWithAes.UpdateGlobalAndLocalAesFromInter()
    End Sub

    Public Function GetGlobalDataFrame() As String
        Return ucrGeomWithAes.strGlobalDataFrame
    End Function
End Class