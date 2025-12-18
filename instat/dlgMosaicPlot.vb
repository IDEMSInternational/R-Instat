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

Imports instat
Imports instat.Translations

Public Class dlgMosaicPlot
    Private clsGgplotFunction As New RFunction
    Private clsMosaicGeomFunction, clsMosaicJitterFunction, clsMosaicTextFunction As New RFunction
    Private clsAesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsLocalAesFunction As New RFunction

    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScaleContinuousFunction As New RFunction
    Private clsYScaleContinuousFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private clsXElementLabels As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    Private bResetBoxLayerSubdialog As Boolean = True
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction

    Private clsFacetFunction As New RFunction
    Private clsFacetVariablesOperator As New ROperator
    Private clsFacetRowOp As New ROperator
    Private clsFacetColOp As New ROperator
    Private clsPipeOperator As New ROperator
    Private clsGroupByFunction As New RFunction

    Private ReadOnly strNone As String = "None"
    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Column"
    Private ReadOnly strFacetRowAll As String = "Facet Row + O"
    Private ReadOnly strFacetColAll As String = "Facet Col + O"

    Private bUpdateComboOptions As Boolean = True
    Private bUpdatingParameters As Boolean = False

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bRCodeSet As Boolean = True

    Private lstPreviousXVars As New List(Of String)

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
        Dim dctLegendPosition As New Dictionary(Of String, String)
        Dim dctLabelColours As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.iHelpTopicID = 594
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

        dctPartitionOptions.Add("Alternate (Horizontal first)", "ggmosaic::mosaic(" & Chr(34) & "h” & Chr(34) & ")")
        dctPartitionOptions.Add("Alternate (Vertical first)", "ggmosaic::mosaic(" & Chr(34) & "v” & Chr(34) & ")")
        dctPartitionOptions.Add("Double Decker", "ggmosaic::ddecker()")

        ucrInputPartitioning.SetParameter(New RParameter("divider", 5))
        ucrInputPartitioning.SetItems(dctPartitionOptions)
        ucrInputPartitioning.SetDropDownStyleAsNonEditable()
        ucrInputPartitioning.SetRDefault("ggmosaic::mosaic(" & Chr(34) & "h” & Chr(34) & ")")
        ucrInputPartitioning.bAllowNonConditionValues = True

        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 4))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.SetRDefault("FALSE")

        ucrChkXAxisLabelAngle.SetParameter(New RParameter("angle"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkXAxisLabelAngle.SetText("X axis labels angle:")
        ucrChkXAxisLabelAngle.AddToLinkedControls(ucrNudXAxisLabelsAngle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=90)

        ucrNudXAxisLabelsAngle.SetParameter(New RParameter("angle"))
        ucrNudXAxisLabelsAngle.SetMinMax(0, 360)

        ucrChkLegend.SetText("Legend:")
        ucrChkLegend.AddToLinkedControls({ucrInputLegendPosition}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="None")
        ucrInputLegendPosition.SetDropDownStyleAsNonEditable()
        ucrInputLegendPosition.SetParameter(New RParameter("legend.position"))
        dctLegendPosition.Add("None", Chr(34) & "none" & Chr(34))
        dctLegendPosition.Add("Left", Chr(34) & "left" & Chr(34))
        dctLegendPosition.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendPosition.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        ucrInputLegendPosition.SetItems(dctLegendPosition)
        ucrChkLegend.AddParameterPresentCondition(True, "legend.position")
        ucrChkLegend.AddParameterPresentCondition(False, "legend.position", False)

        ucr1stFactorReceiver.SetParameter(New RParameter("var1"))
        ucr1stFactorReceiver.Selector = ucrSelectorMosaicPlot
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr1stFactorReceiver.strSelectorHeading = "Factors"
        ucr1stFactorReceiver.bWithQuotes = False
        ucr1stFactorReceiver.SetParameterIsString()
        ucr1stFactorReceiver.SetValuesToIgnore({"."})
        ucr1stFactorReceiver.SetParameterPosition(1)
        ucr1stFactorReceiver.SetLinkedDisplayControl(lblFacetBy)

        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetCol, strFacetRowAll, strFacetColAll, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrChkJitter.SetText("Jitter")
        ucrChkJitter.AddParameterPresentCondition(True, "geom_mosaic_jitter")
        ucrChkJitter.AddParameterPresentCondition(False, "geom_mosaic_jitter", False)
        ucrChkJitter.AddToLinkedControls(ucrNudJitter, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkJitter.AddToLinkedControls(ucrColors, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="black")
        ucrColors.SetParameter(New RParameter("colour", 1))
        ucrColors.SetColours()
        ucrColors.SetLinkedDisplayControl(lblColourJitter)

        ucrNudJitter.SetParameter(New RParameter("size", 0))
        ucrNudJitter.SetMinMax(0, 100)
        ucrNudJitter.Increment = 0.1
        ucrNudJitter.DecimalPlaces = 1
        ucrNudJitter.SetLinkedDisplayControl(lblSizeJitter)
        ucrNudJitter.SetRDefault(1.0)

        ucrChkLabel.SetText("Label")
        ucrChkLabel.AddParameterPresentCondition(True, "geom_mosaic_text")
        ucrChkLabel.AddParameterPresentCondition(False, "geom_mosaic_text", False)
        ucrChkLabel.AddToLinkedControls(ucrNudSizeLabel, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLabel.AddToLinkedControls(ucrColorsLabel, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="black")
        ucrColorsLabel.SetParameter(New RParameter("colour", 1))
        ucrColorsLabel.SetColours()
        ucrColorsLabel.SetLinkedDisplayControl(lblColourLabel)

        ucrNudSizeLabel.SetParameter(New RParameter("size", 0))
        ucrNudSizeLabel.SetMinMax(0, 100)
        ucrNudSizeLabel.Increment = 0.1
        ucrNudSizeLabel.DecimalPlaces = 1
        ucrNudSizeLabel.SetLinkedDisplayControl(lblSizeLabel)
        ucrNudSizeLabel.SetRDefault(1.0)

        ucrSaveMosaicPlot.SetPrefix("mosaic")
        ucrSaveMosaicPlot.SetIsComboBox()
        ucrSaveMosaicPlot.SetCheckBoxText("Store Graph")
        ucrSaveMosaicPlot.SetSaveTypeAsGraph()
        ucrSaveMosaicPlot.SetDataFrameSelector(ucrSelectorMosaicPlot.ucrAvailableDataFrames)
        ucrSaveMosaicPlot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsGgplotFunction = New RFunction
        clsMosaicGeomFunction = New RFunction
        clsMosaicJitterFunction = New RFunction
        clsMosaicTextFunction = New RFunction
        clsAesFunction = New RFunction
        clsLocalAesFunction = New RFunction

        clsXElementLabels = New RFunction

        clsFacetFunction = New RFunction
        clsFacetVariablesOperator = New ROperator
        clsFacetRowOp = New ROperator
        clsFacetColOp = New ROperator
        clsPipeOperator = New ROperator
        clsGroupByFunction = New RFunction

        ucrInputStation.SetName(strFacetWrap)
        ucrInputStation.bUpdateRCodeFromControl = True

        ucrSelectorMosaicPlot.Reset()
        ucrSelectorMosaicPlot.SetGgplotFunction(clsBaseOperator)

        ucrSaveMosaicPlot.Reset()

        ucrReceiverX.SetMeAsReceiver()
        bResetSubdialog = True
        bResetBoxLayerSubdialog = True

        clsMosaicGeomFunction.SetPackageName("ggmosaic")
        clsMosaicGeomFunction.SetRCommand("geom_mosaic")
        clsMosaicGeomFunction.AddParameter("mapping", clsRFunctionParameter:=clsLocalAesFunction, iPosition:=1)

        clsMosaicJitterFunction.SetPackageName("ggmosaic")
        clsMosaicJitterFunction.SetRCommand("geom_mosaic_jitter")
        clsMosaicJitterFunction.AddParameter("mapping", clsRFunctionParameter:=clsLocalAesFunction, iPosition:=1)

        clsMosaicTextFunction.SetPackageName("ggmosaic")
        clsMosaicTextFunction.SetRCommand("geom_mosaic_text")
        clsMosaicTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsLocalAesFunction, iPosition:=1)

        clsLocalAesFunction.SetPackageName("ggplot2")
        clsLocalAesFunction.SetRCommand("aes")

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsGgplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geomfunc", clsRFunctionParameter:=clsMosaicGeomFunction, iPosition:=2)

        clsGgplotFunction.SetPackageName("ggplot2")
        clsGgplotFunction.SetRCommand("ggplot")

        clsAesFunction.SetPackageName("ggplot2")
        clsAesFunction.SetRCommand("aes")

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetRowOp.SetOperation("+")
        clsFacetRowOp.bBrackets = False
        clsFacetColOp.SetOperation("+")
        clsFacetColOp.bBrackets = False
        clsFacetVariablesOperator.SetOperation("~")
        clsFacetVariablesOperator.bForceIncludeOperation = True
        clsFacetVariablesOperator.bBrackets = False
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetVariablesOperator, iPosition:=0)

        clsPipeOperator.SetOperation("%>%")
        SetPipeAssignTo()

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction
        clsScaleColourViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)
        clsScaleFillViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)

        If Not dctThemeFunctions.TryGetValue("axis.text.x", clsXElementLabels) Then
            clsXElementLabels = New RFunction
        End If

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorMosaicPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False

        ucrSelectorMosaicPlot.SetRCode(clsGgplotFunction, bReset)
        If bReset Then
            ucrReceiverX.SetRCode(clsLocalAesFunction, bReset)
            ucrReceiverFill.SetRCode(clsLocalAesFunction, bReset)
            ucrColors.SetRCode(clsMosaicJitterFunction, bReset)
            ucrNudJitter.SetRCode(clsMosaicJitterFunction, bReset)
            ucrChkJitter.SetRCode(clsMosaicJitterFunction, bReset)
            ucrColorsLabel.SetRCode(clsMosaicTextFunction, bReset)
            ucrNudSizeLabel.SetRCode(clsMosaicTextFunction, bReset)
            ucrChkLabel.SetRCode(clsMosaicTextFunction, bReset)
        End If
        ucrReceiverConditions.SetRCode(clsLocalAesFunction, bReset)
        ucrReceiverWeights.SetRCode(clsLocalAesFunction, bReset)

        ucrInputPartitioning.SetRCode(clsMosaicGeomFunction, bReset)
        ucrChkOmitMissing.SetRCode(clsMosaicGeomFunction, bReset)
        ucrChkXAxisLabelAngle.SetRCode(clsXElementLabels, bReset)
        ucrNudXAxisLabelsAngle.SetRCode(clsXElementLabels, bReset)

        ucrSaveMosaicPlot.SetRCode(clsBaseOperator, bReset)

        ucrChkLegend.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)

        AddRemoveXAxisTextParameters()
        bRCodeSet = True
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverX.IsEmpty AndAlso ucrSaveMosaicPlot.IsComplete AndAlso ((ucrChkXAxisLabelAngle.Checked AndAlso ucrNudXAxisLabelsAngle.GetText() <> "") OrElse Not ucrChkXAxisLabelAngle.Checked) Then
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

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveMosaicPlot.ControlContentsChanged, ucrReceiverX.ControlContentsChanged, ucrChkXAxisLabelAngle.ControlContentsChanged, ucrNudXAxisLabelsAngle.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub AutoFacetStation()
        Dim currentReceiver As ucrReceiver = ucrSelectorMosaicPlot.CurrentReceiver

        If currentReceiver IsNot Nothing Then
            ucr1stFactorReceiver.AddItemsWithMetadataProperty(ucrSelectorMosaicPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Climatic_Type", {"station_label"})
            currentReceiver.SetMeAsReceiver()
            AddRemoveGroupBy()
        End If
    End Sub

    Private Sub ucrInput_ControlValueChanged(ucrChangedControl As ucrInputComboBox) Handles ucrInputStation.ControlValueChanged
        If Not bUpdateComboOptions Then
            Exit Sub
        End If
        Dim strChangedText As String = ucrChangedControl.GetText()
        If strChangedText <> strNone Then
            If Not (strChangedText = strFacetCol OrElse strChangedText = strFacetColAll _
            OrElse strChangedText = strFacetRow OrElse strChangedText = strFacetRowAll) _
            AndAlso Not ucrInputStation.Equals(ucrChangedControl) _
            AndAlso ucrInputStation.GetText() = strChangedText Then

                bUpdateComboOptions = False
                ucrInputStation.SetName(strNone)
                bUpdateComboOptions = True
            End If
            If (strChangedText = strFacetWrap AndAlso
            (ucrInputStation.GetText = strFacetRow OrElse ucrInputStation.GetText = strFacetRowAll _
            OrElse ucrInputStation.GetText = strFacetCol OrElse ucrInputStation.GetText = strFacetColAll)) _
        OrElse ((strChangedText = strFacetRow OrElse strChangedText = strFacetRowAll) _
            AndAlso ucrInputStation.GetText = strFacetWrap) _
        OrElse ((strChangedText = strFacetCol OrElse strChangedText = strFacetColAll) _
            AndAlso ucrInputStation.GetText = strFacetWrap) Then

                ucrInputStation.SetName(strNone)
            End If
        End If
        UpdateParameters()
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub

    Private Sub UpdateParameters()
        clsFacetVariablesOperator.RemoveParameterByName("var1")
        clsFacetColOp.RemoveParameterByName("col" & ucrInputStation.Name)
        clsFacetRowOp.RemoveParameterByName("row" & ucrInputStation.Name)
        clsBaseOperator.RemoveParameterByName("facets")
        bUpdatingParameters = True
        ucr1stFactorReceiver.SetRCode(Nothing)
        Select Case ucrInputStation.GetText()
            Case strFacetWrap
                ucr1stFactorReceiver.ChangeParameterName("var1")
                ucr1stFactorReceiver.SetRCode(clsFacetVariablesOperator)
            Case strFacetCol, strFacetColAll
                ucr1stFactorReceiver.ChangeParameterName("col" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsFacetColOp)
            Case strFacetRow, strFacetRowAll
                ucr1stFactorReceiver.ChangeParameterName("row" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsFacetRowOp)
        End Select
        If Not clsAesFunction.ContainsParameter("x") Then
            clsAesFunction.AddParameter("x", Chr(34) & Chr(34))
        End If
        bUpdatingParameters = False
    End Sub

    Private Sub AddRemoveFacets()
        Dim bWrap As Boolean = False
        Dim bCol As Boolean = False
        Dim bRow As Boolean = False
        Dim bColAll As Boolean = False
        Dim bRowAll As Boolean = False

        If bUpdatingParameters Then
            Exit Sub
        End If
        clsBaseOperator.RemoveParameterByName("facets")
        If Not ucr1stFactorReceiver.IsEmpty Then
            Select Case ucrInputStation.GetText()
                Case strFacetWrap
                    bWrap = True
                Case strFacetCol
                    bCol = True
                Case strFacetRow
                    bRow = True
                Case strFacetColAll
                    bColAll = True
                Case strFacetRowAll
                    bRowAll = True
            End Select
        End If
        If bWrap OrElse bRow OrElse bCol OrElse bColAll OrElse bRowAll Then
            clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction)
        End If
        If bWrap Then
            clsFacetFunction.SetRCommand("facet_wrap")
        End If
        If bRow OrElse bCol OrElse bRowAll OrElse bColAll Then
            clsFacetFunction.SetRCommand("facet_grid")
        End If
        If bRowAll OrElse bColAll Then
            clsFacetFunction.AddParameter("margin", "TRUE")
        Else
            clsFacetFunction.RemoveParameterByName("margin")
        End If
        If bRow OrElse bRowAll Then
            clsFacetVariablesOperator.AddParameter("left", clsROperatorParameter:=clsFacetRowOp, iPosition:=0)
        ElseIf (bCol OrElse bColAll) AndAlso bWrap = False Then
            clsFacetVariablesOperator.AddParameter("left", ".", iPosition:=0)
        Else
            clsFacetVariablesOperator.RemoveParameterByName("left")
        End If
        If bCol OrElse bColAll Then
            clsFacetVariablesOperator.AddParameter("right", clsROperatorParameter:=clsFacetColOp, iPosition:=1)
        ElseIf (bRow OrElse bColAll) AndAlso bWrap = False Then
            clsFacetVariablesOperator.AddParameter("right", ".", iPosition:=1)
        Else
            clsFacetVariablesOperator.RemoveParameterByName("right")
        End If
    End Sub

    Private Sub ucr1stFactorReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucr1stFactorReceiver.ControlValueChanged, ucrReceiverX.ControlValueChanged
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub

    Private Sub GetParameterValue(clsOperator As ROperator)
        Dim i As Integer = 0
        For Each clsTempParam As RParameter In clsOperator.clsParameters
            If clsTempParam.strArgumentValue <> "" AndAlso clsTempParam.strArgumentValue <> "." Then
                clsGroupByFunction.AddParameter(i, clsTempParam.strArgumentValue, bIncludeArgumentName:=False, iPosition:=i)
                i = i + 1
            End If
        Next
    End Sub

    Private Sub AddRemoveGroupBy()
        If clsPipeOperator.ContainsParameter("mutate") Then
            clsGroupByFunction.ClearParameters()
            If clsBaseOperator.ContainsParameter("facets") Then
                Select Case ucrInputStation.GetText()
                    Case strFacetWrap
                        GetParameterValue(clsFacetVariablesOperator)
                    Case strFacetCol, strFacetColAll
                        GetParameterValue(clsFacetColOp)
                    Case strFacetRow, strFacetRowAll
                        GetParameterValue(clsFacetRowOp)
                End Select
            End If
            If clsGroupByFunction.iParameterCount > 0 Then
                clsPipeOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFunction, iPosition:=1)
            Else
                clsPipeOperator.RemoveParameterByName("group_by")
            End If
        Else
            clsPipeOperator.RemoveParameterByName("group_by")
        End If
        SetPipeAssignTo()
    End Sub

    Private Sub SetPipeAssignTo()
        If ucrSelectorMosaicPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso clsPipeOperator.clsParameters.Count > 1 Then
            clsPipeOperator.SetAssignTo(ucrSelectorMosaicPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            clsPipeOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrSelectorMosaicPlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorMosaicPlot.ControlValueChanged
        AutoFacetStation()
        SetPipeAssignTo()
    End Sub

    Private Sub ucrReceiverX_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverX.ControlValueChanged
        Dim iXVarCount As Integer

        iXVarCount = lstPreviousXVars.Count
        If bRCodeSet Then
            If lstPreviousXVars.Contains(ucrReceiverFill.GetVariableNames(False)) AndAlso Not ucrReceiverX.GetVariableNamesAsList().Contains(ucrReceiverFill.GetVariableNames(False)) Then
                ucrReceiverFill.Clear()
                ucrReceiverX.SetMeAsReceiver()
            End If
            If iXVarCount = 0 AndAlso ucrReceiverX.lstSelectedVariables.Items.Count >= 1 AndAlso ucrReceiverFill.IsEmpty() Then
                ucrReceiverFill.Add(ucrReceiverX.lstSelectedVariables.Items(0).Text)
                ucrReceiverX.SetMeAsReceiver()
            ElseIf ucrReceiverX.IsEmpty Then
                ucrReceiverFill.Clear()
                ucrReceiverX.SetMeAsReceiver()
            End If
            lstPreviousXVars = ucrReceiverX.GetVariableNamesAsList()
        End If
    End Sub

    Private Sub AddRemoveXAxisTextParameters()
        If bRCodeSet Then
            If ucrChkXAxisLabelAngle.Checked AndAlso ucrNudXAxisLabelsAngle.Value <> 0 Then
                clsXElementLabels.AddParameter("hjust", 1)
            Else
                clsXElementLabels.RemoveParameterByName("hjust")
            End If
            If clsXElementLabels.clsParameters.Count > 0 Then
                clsThemeFunction.AddParameter("axis.text.x", clsRFunctionParameter:=clsXElementLabels)
            Else
                clsThemeFunction.RemoveParameterByName("axis.text.x")
            End If
            AddRemoveTheme()
        End If
    End Sub

    Private Sub AddRemoveTheme()
        If clsThemeFunction.iParameterCount > 0 Then
            ' The position MUST be larger than the position of the theme_* argument
            ' Otherwise the choice of theme will overwrite the options selected here.
            ' Currently set to large value as no reason this cannot be at the end currently
            clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=100)
        Else
            clsBaseOperator.RemoveParameterByName("theme")
        End If
    End Sub

    Private Sub ucrChkLegend_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLegend.ControlValueChanged, ucrInputLegendPosition.ControlValueChanged
        AddRemoveTheme()
    End Sub

    Private Sub XAxisLabelAngleControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkXAxisLabelAngle.ControlValueChanged, ucrNudXAxisLabelsAngle.ControlValueChanged
        AddRemoveXAxisTextParameters()
    End Sub

    Private Sub ucrReceiverFill_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFill.ControlValueChanged
        clsScaleColourViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)
        clsScaleFillViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)
    End Sub

    Private Sub PlotOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemPlotOptions.Click, cmdOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsAesFunction,
                         clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction,
                         clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction, clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction,
                         clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction,
                         clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrSelectorMosaicPlot, clsNewCoordPolarFunction:=clsCoordPolarFunction,
                         clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewFacetVariablesOperator:=clsFacetVariablesOperator,
                         clsNewAnnotateFunction:=clsAnnotateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, bNewEnableColour:=False, bNewEnableDiscrete:=False, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        ucr1stFactorReceiver.Add(sdgPlots.ucrReceiverFacetFactors.GetText)
        bResetSubdialog = False
        SetRCodeForControls(False)
        AddRemoveXAxisTextParameters()
    End Sub

    Private Sub toolStripMenuItemMosaicOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemMosaicOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsGgplotFunction, clsNewGeomFunc:=clsMosaicGeomFunction, clsNewGlobalAesFunc:=clsLocalAesFunction, clsNewLocalAes:=clsAesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorMosaicPlot, bApplyAesGlobally:=False, bReset:=bResetBoxLayerSubdialog)
        sdgLayerOptions.tbcLayers.SelectedTab = sdgLayerOptions.tbpGeomParameters
        sdgLayerOptions.tbpAesthetics.Enabled = False
        sdgLayerOptions.ShowDialog()
        sdgLayerOptions.tbpAesthetics.Enabled = True
        bResetBoxLayerSubdialog = False
        SetRCodeForControls(False)
    End Sub

    Private Sub openSdgLayerOptions(clsNewGeomFunc As RFunction)
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsGgplotFunction, clsNewGeomFunc:=clsNewGeomFunc,
                                   clsNewGlobalAesFunc:=clsAesFunction, clsNewLocalAes:=clsLocalAesFunction,
                                   bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorMosaicPlot,
                                   bApplyAesGlobally:=False, bReset:=bResetBoxLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetBoxLayerSubdialog = False
        'Coming from the sdgLayerOptions, clsRaesFunction and others have been modified. 
        '  One then needs to display these modifications on the dlgScatteredPlot.

        'The aesthetics parameters on the main dialog are repopulated as required.
        For Each clsParam In clsLocalAesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrReceiverX.Clear()
                Else
                    ucrReceiverX.Add(clsParam.strArgumentValue)
                End If
                'In the y case, the value stored in the clsReasFunction in the multiple variables 
                '  case is "value", however that one shouldn't be written in the multiple 
                '  variables receiver (otherwise it would stack all variables and the stack 
                '  ("value") itself!).
                'Warning: what if someone used the name value for one of it's variables 
                '  independently from the multiple variables method? Here if the receiver is 
                '  actually in single mode, the variable "value" will still be given back, which 
                '  throws the problem back to the creation of "value" in the multiple receiver case.
            ElseIf clsParam.strArgumentName = "conds" AndAlso (clsParam.strArgumentValue <> "value") Then
                'Still might be in the case of bSingleVariable with mapping y="".
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    'ucrReceiverConditions.Clear()
                Else
                    ucrReceiverConditions.Add(clsParam.strArgumentValue)
                End If
            ElseIf clsParam.strArgumentName = "fill" Then
                ucrReceiverFill.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOkEnabled()
    End Sub

    Private Sub ToolStripMenuItemMosaicJitter_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemMosaicJitter.Click
        openSdgLayerOptions(clsMosaicJitterFunction)
    End Sub

    Private Sub ToolStripMenuItemMosaicText_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemMosaicText.Click
        openSdgLayerOptions(clsMosaicTextFunction)
    End Sub

    Private Sub ucrChkJitter_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkJitter.ControlValueChanged, ucrColors.ControlValueChanged, ucrNudJitter.ControlValueChanged
        If ucrChkJitter.Checked Then
            clsBaseOperator.AddParameter("geom_mosaic_jitter", clsRFunctionParameter:=clsMosaicJitterFunction)
            If Not ucrColors.IsEmpty Then
                clsMosaicJitterFunction.AddParameter("colour", Chr(34) & ucrColors.GetText & Chr(34), iPosition:=1)
            Else
                clsMosaicJitterFunction.RemoveParameterByName("colour")
            End If
            If Not ucrNudJitter.IsEmpty Then
                clsMosaicJitterFunction.AddParameter("size", ucrNudJitter.GetText(), iPosition:=0)
            Else
                clsMosaicJitterFunction.RemoveParameterByName("size")
            End If
        Else
            clsBaseOperator.RemoveParameterByName("geom_mosaic_jitter")
        End If
        ToolStripMenuItemMosaicJitter.Enabled = ucrChkJitter.Checked
    End Sub

    Private Sub ucrChkLabel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLabel.ControlValueChanged, ucrColorsLabel.ControlValueChanged, ucrNudSizeLabel.ControlValueChanged
        If ucrChkLabel.Checked Then
            clsBaseOperator.AddParameter("geom_mosaic_text", clsRFunctionParameter:=clsMosaicTextFunction)
            If Not ucrColorsLabel.IsEmpty Then
                clsMosaicTextFunction.AddParameter("colour", Chr(34) & ucrColorsLabel.GetText & Chr(34), iPosition:=1)
            Else
                clsMosaicTextFunction.RemoveParameterByName("colour")
            End If
            If Not ucrNudSizeLabel.IsEmpty Then
                clsMosaicTextFunction.AddParameter("size", ucrNudSizeLabel.GetText(), iPosition:=0)
            Else
                clsMosaicTextFunction.RemoveParameterByName("size")
            End If
        Else
            clsBaseOperator.RemoveParameterByName("geom_mosaic_text")
        End If
        ToolStripMenuItemMosaicText.Enabled = ucrChkLabel.Checked
    End Sub
End Class