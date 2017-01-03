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
        'Each ucrLayerParameter has a field of type ucrGeomListWithAes and reciprocally as both of them "collaborate to provide full description of a Layer".
        'The obvious linking is performed here in sdgLayerOptions.
    End Sub

    Private Sub SetDefaults()
        ucrGeomWithAes.ucrGeomWithAesSelector.Reset()
        strGlobalDataFrame = ""
    End Sub

    Private Sub ReopenDialog()

    End Sub


    Public Sub SetupLayer(clsTempGgPlot As RFunction, clsTempGeomFunc As RFunction, clsTempAesFunc As RFunction, Optional bFixAes As Boolean = False, Optional bFixGeom As Boolean = False, Optional strDataframe As String = "", Optional bApplyAesGlobally As Boolean = True, Optional bIgnoreGlobalAes As Boolean = False, Optional iNumVariablesForGeoms As Integer = -1, Optional clsTempLocalAes As RFunction = Nothing)
        If clsTempGeomFunc Is Nothing Then
            clsTempGeomFunc = New RFunction
        End If
        clsGeomFunction = clsTempGeomFunc
        clsAesFunction = clsTempAesFunc
        clsGgplotFunction = clsTempGgPlot
        ucrGeomWithAes.Setup(clsTempGgPlot, clsTempGeomFunc, clsTempAesFunc, bFixAes, bFixGeom, strDataframe, bApplyAesGlobally, bIgnoreGlobalAes, iNumVariablesForGeoms, clsTempLocalAes)
        ucrLayerParameter.Setup(clsTempGgPlot, clsTempGeomFunc, clsTempAesFunc, bFixAes, bFixGeom, strDataframe, bApplyAesGlobally, bIgnoreGlobalAes, iNumVariablesForGeoms, clsTempLocalAes) 'Don't really need to give all parameters through as this function just calls the mother Setup from ucrGeom who doesn't use some of them which are optional, such as clsTempLocalAes...
    End Sub

    Public Function TestForOKEnabled() As Boolean
        Return ucrGeomWithAes.TestForOkEnabled()
    End Function

    Private Sub PartiallyMandatoryAesFillingMethod(clsRelevantAesFunction As RFunction)
        'This sub is called to add "" mapping for axis x or y when no variables are mapped to them (only relavant for a few geoms). The mapping is added in the global or local aes depending on whether apply on all layers is checked or not (choice of clsRelevantAesFunction).
        Dim bTempIgnoreGlobalAes As Boolean
        bTempIgnoreGlobalAes = ((clsGeomFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "inherit.aes") <> -1) AndAlso (clsGeomFunction.GetParameter("inherit.aes").strArgumentValue = "FALSE"))
        If clsGeomFunction.strRCommand = "geom_boxplot" OrElse clsGeomFunction.strRCommand = "geom_dotplot" Then
            If (clsAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "x") = -1 OrElse bTempIgnoreGlobalAes) AndAlso ucrGeomWithAes.clsGeomAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "x") = -1 Then
                clsRelevantAesFunction.AddParameter("x", Chr(34) & Chr(34))
            End If
        ElseIf clsGeomFunction.strRCommand = "geom_point" OrElse clsGeomFunction.strRCommand = "geom_line" Then
            If (clsAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "x") = -1 OrElse bTempIgnoreGlobalAes) AndAlso ucrGeomWithAes.clsGeomAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "x") = -1 Then
                clsRelevantAesFunction.AddParameter("x", Chr(34) & Chr(34))
            End If
            If (clsAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "y") = -1 OrElse bTempIgnoreGlobalAes) AndAlso ucrGeomWithAes.clsGeomAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "y") = -1 Then
                clsRelevantAesFunction.AddParameter("y", Chr(34) & Chr(34))
            End If
        End If
    End Sub

    Private Sub ucrSdgLayerBase_ClickReturn(sender As Object, e As EventArgs) Handles ucrSdgLayerBase.ClickReturn
        Dim clsRelevantAesFunction As New RFunction 'Will be used in the partially mandatory aes filling method below.

        'Two situations: apply on all layers checked or not. Would edit the global or local aes accordingly. 
        If ucrGeomWithAes.chkApplyOnAllLayers.Checked Then
            'First, in case the chkApplyOnAllLayers is checked, what is by default understood as local mapping (clsGeomAesFunction) needs to become global mapping: the Aes parameters in clsGeomAesFunction are sent through to clsAesFunction.
            For Each clsParam In ucrGeomWithAes.clsGeomAesFunction.clsParameters
                clsAesFunction.AddParameter(clsParam) 'Warning: This never removes the parameters that have been previously inserted...
            Next
            'Now, we don't want the parameters "mapping" and "data" in the Layer as these will be fixed globally and then inherited.
            clsGeomFunction.RemoveParameterByName("mapping")
            clsGeomFunction.RemoveParameterByName("data")
            'Here the global ggplot function takes the relevant "mapping" and "data" parameters as required by "ApplyOnAllLayers".
            clsGgplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesFunction)
            clsGgplotFunction.AddParameter("data", clsRFunctionParameter:=ucrGeomWithAes.ucrGeomWithAesSelector.ucrAvailableDataFrames.clsCurrDataFrame.Clone())
            'The data frame that is selected in the dataframe selector (lives in ucrGeomWithAes) is communicated to the sdgLayerOptions and the ucrGeomWithAes
            'Question to be discussed: could these two strGlobalDataFrame and ucrGeomWithAes.strGlobalDataFrame not be linked together in sdgLayerOptions.initialisedialog() ? 
            'Question: why do we even do this ? Should it not have been done earlier ? What's the point of changing parameters on sdgLayerOptions right before closing it ?
            strGlobalDataFrame = ucrGeomWithAes.ucrGeomWithAesSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text
            ucrGeomWithAes.strGlobalDataFrame = strGlobalDataFrame
        Else 'Warning: in case the sdgLayerOptions has been called by specific dlg, need to refill the aes on that dlg. Imagine the ApplyOnAllLayers has been unticked ? Problem... Also in order to solve this, would need to know on the specific dialog if it has been unticked or not in order to know how to fill in the aes receivers ! The linking will be restudied anyway. There are many ways to go, see discussion on github.
            If ucrGeomWithAes.clsGeomAesFunction.iParameterCount > 0 Then
                clsGeomFunction.AddParameter("mapping", clsRFunctionParameter:=ucrGeomWithAes.clsGeomAesFunction.Clone())
            Else
                clsGeomFunction.RemoveParameterByName("mapping")
            End If
            If ucrGeomWithAes.ucrGeomWithAesSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> strGlobalDataFrame Then
                clsGeomFunction.AddParameter("data", clsRFunctionParameter:=ucrGeomWithAes.ucrGeomWithAesSelector.ucrAvailableDataFrames.clsCurrDataFrame.Clone())
            Else
                clsGeomFunction.RemoveParameterByName("data")
            End If
        End If

        'Partially mandatory aes filling method
        If ucrGeomWithAes.chkApplyOnAllLayers.Checked Then
            PartiallyMandatoryAesFillingMethod(clsAesFunction)

            'Warning: in some cases, this is sources of errors in R: is a continuous variable is mapped to y (for instance plot1 <- ggplot(diamonds,aes(y=price,x="") + geom_boxplot()), and in some layer where global aes are ignored, "" is mapped to y (e.g. plot1 + geom_point(inherit.aes = FALSE, mapping = aes(x="",y="")) ), then an error occurs as a discrete vriable cannot be mapped to a continuous scale.
            'Warning: again coming from specific plots, If ApplyOnAllLayers is unticked, the linking will make this mehtod fail.
        ElseIf clsGeomFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "mapping") <> -1 Then
            PartiallyMandatoryAesFillingMethod(clsGeomFunction.clsParameters.Find(Function(x) x.strArgumentName = "mapping").clsArgumentCodeStructure)
        Else
            clsRelevantAesFunction.SetRCommand("aes")
            PartiallyMandatoryAesFillingMethod(clsRelevantAesFunction)
            If clsRelevantAesFunction.iParameterCount > 0 Then
                clsGeomFunction.AddParameter("mapping", clsRFunctionParameter:=clsRelevantAesFunction.Clone())
            End If
        End If

        'Adding stat = identity method 
        If clsGeomFunction.strRCommand = "geom_bar" OrElse clsGeomFunction.strRCommand = "geom_density" OrElse clsGeomFunction.strRCommand = "geom_freqpoly" Then
            'If there is a y in the global aes, and the global aes are not ignored or if there is a y in the local aes then in case stat has not been set manually, stat is set to identity.
            If (((clsAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "y") <> -1) AndAlso ((clsGeomFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "inherit.aes") = -1) OrElse (clsGeomFunction.GetParameter("inherit.aes").strArgumentValue = "TRUE"))) OrElse (ucrGeomWithAes.clsGeomAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "y") <> -1)) AndAlso (clsGeomFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "stat") = -1) Then
                clsGeomFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34))
                'Task: send a message to the user saying that stat = identity has been added as a parameter in order to avoid error. Can be modified on the LayerParameter tab.
                'In case the "y" mapping has been removed after editing the layer, the added "stat" parameter should probably be removed so it is important for the user to know it has been added in automatically, in case he wants to go to the layer parameters tab and remove it.
            End If
        End If

    End Sub
End Class