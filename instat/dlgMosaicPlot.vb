' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations

Public Class dlgMosaicPlot
    Private clsGgplotFunction As New RFunction
    Private clsMosaicGeomFunction As New RFunction
    Private clsAesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsLocalAesFunction As New RFunction

    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScaleContinuousFunction As New RFunction
    Private clsYScaleContinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    Private bResetBoxLayerSubdialog As Boolean = True

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private iXVarCount As Integer = 0

    Private Sub dlgMosaicPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctPartitionOptions As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        'ucrBase.iHelpTopicID = 
        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorMosaicPlot.SetParameter(New RParameter("data", 0))
        ucrSelectorMosaicPlot.SetParameterIsrfunction()

        ucrReceiverX.SetParameter(New RParameter("x", 0))
        ucrReceiverX.SetVariablesListPackageName("ggmosaic")
        ucrReceiverX.SetVariablesListFunctionName("product")
        ucrReceiverX.bForceVariablesAsList = True
        ucrReceiverX.Selector = ucrSelectorMosaicPlot
        ucrReceiverX.SetIncludedDataTypes({"factor"})
        ucrReceiverX.strSelectorHeading = "Factors"
        ucrReceiverX.SetParameterIsString()
        ucrReceiverX.bWithQuotes = False

        ucrReceiverFill.SetParameter(New RParameter("fill", 1))
        ucrReceiverFill.Selector = ucrSelectorMosaicPlot
        ucrReceiverFill.SetIncludedDataTypes({"factor"})
        ucrReceiverFill.strSelectorHeading = "Factors"
        ucrReceiverFill.SetParameterIsString()
        ucrReceiverFill.bWithQuotes = False

        ucrReceiverConditions.SetParameter(New RParameter("conds", 2))
        ucrReceiverConditions.SetVariablesListPackageName("ggmosaic")
        ucrReceiverConditions.SetVariablesListFunctionName("product")
        ucrReceiverConditions.bForceVariablesAsList = True
        ucrReceiverConditions.Selector = ucrSelectorMosaicPlot
        ucrReceiverConditions.SetIncludedDataTypes({"factor"})
        ucrReceiverConditions.strSelectorHeading = "Factors"
        ucrReceiverConditions.SetParameterIsString()
        ucrReceiverConditions.bWithQuotes = False

        ucrReceiverWeights.SetParameter(New RParameter("weight", 3))
        ucrReceiverWeights.Selector = ucrSelectorMosaicPlot
        ucrReceiverWeights.SetIncludedDataTypes({"numeric"})
        ucrReceiverWeights.strSelectorHeading = "Numerics"
        ucrReceiverWeights.SetParameterIsString()
        ucrReceiverWeights.bWithQuotes = False

        dctPartitionOptions.Add("Alternate Spines (Horizontal first)", "ggmosaic::mosaic(" & Chr(34) & "h” & Chr(34) & ")")
        dctPartitionOptions.Add("Alternate Spines (Vertical first)", "ggmosaic::mosaic(" & Chr(34) & "v” & Chr(34) & ")")
        dctPartitionOptions.Add("Double Decker", "ggmosaic::ddecker()")

        ucrInputPartitioning.SetParameter(New RParameter("divider", 5))
        ucrInputPartitioning.SetItems(dctPartitionOptions)
        ucrInputPartitioning.SetDropDownStyleAsNonEditable()
        ucrInputPartitioning.SetRDefault("ggmosaic::mosaic(" & Chr(34) & "h” & Chr(34) & ")")

        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 4))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.SetRDefault("FALSE")

        ucrSaveMosaicPlot.SetPrefix("mosaic")
        ucrSaveMosaicPlot.SetIsComboBox()
        ucrSaveMosaicPlot.SetCheckBoxText("Save Graph")
        ucrSaveMosaicPlot.SetSaveTypeAsGraph()
        ucrSaveMosaicPlot.SetDataFrameSelector(ucrSelectorMosaicPlot.ucrAvailableDataFrames)
        ucrSaveMosaicPlot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsGgplotFunction = New RFunction
        clsMosaicGeomFunction = New RFunction
        clsAesFunction = New RFunction
        clsLocalAesFunction = New RFunction

        ucrSelectorMosaicPlot.Reset()
        ucrSelectorMosaicPlot.SetGgplotFunction(clsBaseOperator)

        ucrSaveMosaicPlot.Reset()

        ucrReceiverX.SetMeAsReceiver()
        bResetSubdialog = True
        bResetBoxLayerSubdialog = True

        clsMosaicGeomFunction.SetPackageName("ggmosaic")
        clsMosaicGeomFunction.SetRCommand("geom_mosaic")
        clsMosaicGeomFunction.AddParameter("mapping", clsRFunctionParameter:=clsLocalAesFunction, iPosition:=1)

        clsLocalAesFunction.SetPackageName("ggplot2")
        clsLocalAesFunction.SetRCommand("aes")

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsGgplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geomfunc", clsRFunctionParameter:=clsMosaicGeomFunction, iPosition:=2)

        clsGgplotFunction.SetPackageName("ggplot2")
        clsGgplotFunction.SetRCommand("ggplot")

        clsAesFunction.SetPackageName("ggplot2")
        clsAesFunction.SetRCommand("aes")

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorMosaicPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorMosaicPlot.SetRCode(clsGgplotFunction, bReset)
        ucrReceiverX.SetRCode(clsLocalAesFunction, bReset)
        ucrReceiverFill.SetRCode(clsLocalAesFunction, bReset)
        ucrReceiverConditions.SetRCode(clsLocalAesFunction, bReset)
        ucrReceiverWeights.SetRCode(clsLocalAesFunction, bReset)

        ucrInputPartitioning.SetRCode(clsMosaicGeomFunction, bReset)
        ucrChkOmitMissing.SetRCode(clsMosaicGeomFunction, bReset)
        'ucrChkXAxisLabelAngle.SetRCode(, bReset)

        ucrSaveMosaicPlot.SetRCode(clsBaseOperator, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverX.IsEmpty AndAlso ucrSaveMosaicPlot.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsAesFunction, clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction, clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrSelectorMosaicPlot, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub cmdMosaicPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdMosaicPlotOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsGgplotFunction, clsNewGeomFunc:=clsMosaicGeomFunction, clsNewGlobalAesFunc:=clsAesFunction, clsNewLocalAes:=clsLocalAesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorMosaicPlot, bApplyAesGlobally:=True, bReset:=bResetBoxLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetBoxLayerSubdialog = False
        SetRCodeForControls(False)
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveMosaicPlot.ControlContentsChanged, ucrReceiverX.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverX_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverX.ControlValueChanged
        If iXVarCount = 0 AndAlso ucrReceiverX.lstSelectedVariables.Items.Count >= 1 AndAlso ucrReceiverFill.IsEmpty() Then
            ucrReceiverFill.Add(ucrReceiverX.lstSelectedVariables.Items(0).Text)
            ucrReceiverX.SetMeAsReceiver()
        ElseIf ucrReceiverX.IsEmpty Then
            ucrReceiverFill.Clear()
            ucrReceiverX.SetMeAsReceiver()
        End If
        iXVarCount = ucrReceiverX.GetCount()
    End Sub
End Class