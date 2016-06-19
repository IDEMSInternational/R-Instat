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
    Public clsGgplotFunction As New RFunction
    Public bFirstLoad As Boolean = True
    Public bAesInGeom As Boolean
    Public strGlobalDataFrame As String = ""

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
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

    Public Sub SetRSyntax(clsRSyntax As RSyntax)

    End Sub

    Public Sub SetupLayer(clsTempGgPlot As RFunction, clsTempGeomFunc As RFunction, clsTempAesFunc As RFunction, Optional bFixAes As Boolean = False, Optional bFixGeom As Boolean = False, Optional strDataframe As String = "", Optional bUseGlobalAes As Boolean = True, Optional iNumVariablesForGeoms As Integer = -1, Optional clsTempLocalAes As RFunction = Nothing)
        If clsTempGeomFunc Is Nothing Then
            clsTempGeomFunc = New RFunction
        End If
        clsGeomFunction = clsTempGeomFunc
        clsAesFunction = clsTempAesFunc
        clsGgplotFunction = clsTempGgPlot
        ucrGeomWithAes.Setup(clsTempGgPlot, clsTempGeomFunc, clsTempAesFunc, bFixAes, bFixGeom, strDataframe, bUseGlobalAes, iNumVariablesForGeoms, clsTempLocalAes)
        ucrLayerParameter.Setup(clsTempGgPlot, clsTempGeomFunc, clsTempAesFunc, bFixAes, bFixGeom, strDataframe, bUseGlobalAes, iNumVariablesForGeoms, clsTempLocalAes)
    End Sub

    Public Function TestForOKEnabled() As Boolean
        Return ucrGeomWithAes.TestForOkEnabled()
    End Function

    Private Sub ucrSdgLayerBase_ClickReturn(sender As Object, e As EventArgs) Handles ucrSdgLayerBase.ClickReturn
        If ucrGeomWithAes.chkApplyOnAllLayers.Checked Then
            For Each clsParam In ucrGeomWithAes.clsGeomAesFunction.clsParameters
                clsAesFunction.AddParameter(clsParam)
            Next
            clsGeomFunction.RemoveParameterByName("mapping")
            clsGeomFunction.RemoveParameterByName("data")
            clsGgplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesFunction)
            clsGgplotFunction.AddParameter("data", clsRFunctionParameter:=ucrGeomWithAes.UcrSelector.ucrAvailableDataFrames.clsCurrDataFrame.Clone())
            strGlobalDataFrame = ucrGeomWithAes.UcrSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text
            ucrGeomWithAes.strGlobalDataFrame = strGlobalDataFrame
        Else
            If ucrGeomWithAes.clsGeomAesFunction.iParameterCount > 0 Then
                clsGeomFunction.AddParameter("mapping", clsRFunctionParameter:=ucrGeomWithAes.clsGeomAesFunction.Clone())
            Else
                clsGeomFunction.RemoveParameterByName("mapping")
            End If
            If ucrGeomWithAes.UcrSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> strGlobalDataFrame Then
                clsGeomFunction.AddParameter("data", clsRFunctionParameter:=ucrGeomWithAes.UcrSelector.ucrAvailableDataFrames.clsCurrDataFrame.Clone())
            Else
                clsGeomFunction.RemoveParameterByName("data")
            End If
        End If
    End Sub
End Class