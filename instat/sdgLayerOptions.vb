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
    Public strGlobalDataFrame As String

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
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
        'Why does the order in equality not matter here ? Should intuitively be the other way around. 
    End Sub

    Private Sub SetDefaults()
        ucrGeomWithAes.UcrSelector.Reset()
        strGlobalDataFrame = ""
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
        'Warning, when coming back to a layer where the geom was not fixed, the geom is now fixed... 
        'when is fix aes used ?
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
        If clsGeomFunction.strRCommand = "geom_bar" OrElse clsGeomFunction.strRCommand = "geom_density" OrElse clsGeomFunction.strRCommand = "geom_freqpoly" Then
            If (clsAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "y") <> -1 OrElse ucrGeomWithAes.clsGeomAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "y")) AndAlso clsGeomFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "identity") = -1 Then
                clsGeomFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34))
            End If
            If clsGeomFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "stat") <> -1 Then
                If ucrGeomWithAes.clsGeomAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "y") Then
                    ucrGeomWithAes.clsGeomAesFunction.RemoveParameterByName("stat")
                ElseIf clsAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "y") = -1 Then
                    clsAesFunction.RemoveParameterByName("stat")
                End If
            End If
        ElseIf clsGeomFunction.strRCommand = "geom_boxplot" OrElse clsGeomFunction.strRCommand = "geom_dotplot" Then
            If clsAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "x") = -1 AndAlso ucrGeomWithAes.clsGeomAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "x") = -1 Then
                clsAesFunction.AddParameter("x", Chr(34) & Chr(34))
            End If
        End If
    End Sub
End Class