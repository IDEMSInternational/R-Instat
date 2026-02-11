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
Imports System.Text.RegularExpressions


Public Class dlgPICSACrops
    Private clsCropsFunction As New RFunction
    Private clsDummyFunction As New RFunction
    Private clsSequenceFunction, clsSequencewaterFunction, clsSequencePlantingFunction As New RFunction
    Private clsGetDataNamesFunction, clsSetDiffFunction, clsUpdatedDataNamesFunction, clsStartsWithFunction,
            clsGetDataFrameFunction, clsGetCropDefinitionFunction, clsGetSeasonStartDefinitionFunction,
            clsStartsWithPropsFunction, clsGetDataFramePropsFunction As New RFunction

    Private clsFirstBracketOperator, clsEmptySpaceOperator, clsEmptySpacePropsOperator As New ROperator

    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private strCurrDataName As String = ""
    Private lstEndReceivers As New List(Of ucrReceiverSingle)
    Private lstStartReceivers As New List(Of ucrReceiverSingle)
    Private bisFilling As Boolean = False

    Dim lstRecognisedTypes As New List(Of KeyValuePair(Of String, List(Of String)))

    Private Sub dlgPICSACrops_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
        AutoFillReceivers(lstEndReceivers)
        AutoFillReceivers(lstStartReceivers)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 480
        ' Sub dialog not yet created.
        cmdOptions.Visible = False

        Dim kvpEnd As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("end_season", {"end_season", "end_rains", "end_rain_filled", "end_season_filled"}.ToList())
        Dim kvpStart As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("start_rain", {"start_rain"}.ToList())

        lstRecognisedTypes.AddRange({kvpEnd, kvpStart})

        lstEndReceivers.AddRange({ucrReceiverEnd})

        lstStartReceivers.AddRange({ucrReceiverStart})

        ucrSelectorForCrops.SetLabelText("Data Frame (Daily):")
        ucrSelectorForCrops.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForCrops.SetParameterIsString()

        ucrSelectorSummary.SetLabelText("Data Frame (Summary):")
        ucrSelectorSummary.SetParameter(New RParameter("season_data_name", 8))
        ucrSelectorSummary.SetParameterIsString()

        'Year Receiver
        ucrReceiverYear.Selector = ucrSelectorForCrops
        ucrReceiverYear.SetParameter(New RParameter("year", 1))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True

        'Station Receiver
        ucrReceiverStation.Selector = ucrSelectorForCrops
        ucrReceiverStation.SetParameter(New RParameter("station", 2))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        'Rain Receiver
        ucrReceiverRainfall.SetParameter(New RParameter("rain", 3))
        ucrReceiverRainfall.Selector = ucrSelectorForCrops
        ucrReceiverRainfall.SetParameterIsString()
        ucrReceiverRainfall.SetClimaticType("rain")
        ucrReceiverRainfall.bAutoFill = True

        'Day Receiver
        ucrReceiverDay.Selector = ucrSelectorForCrops
        ucrReceiverDay.SetParameter(New RParameter("day", 4))
        ucrReceiverDay.SetParameterIsString()
        ucrReceiverDay.SetClimaticType("doy")
        ucrReceiverDay.bAutoFill = True

        'Start Receiver
        ucrReceiverStart.Selector = ucrSelectorSummary
        ucrReceiverStart.SetParameter(New RParameter("start_day", 8))
        ucrReceiverStart.SetParameterIsString()
        ucrReceiverStart.SetDataType("numeric")
        ucrReceiverStart.Tag = "start_rain"

        'End Receiver
        ucrReceiverEnd.Selector = ucrSelectorSummary
        ucrReceiverEnd.SetParameter(New RParameter("end_day", 9))
        ucrReceiverEnd.SetParameterIsString()
        ucrReceiverEnd.SetDataType("numeric")
        ucrReceiverEnd.Tag = "end_season"

        ucrPnlStartCheck.AddRadioButton(rdoYes)
        ucrPnlStartCheck.AddRadioButton(rdoNo)
        ucrPnlStartCheck.AddRadioButton(rdoBoth)
        ucrPnlStartCheck.AddParameterValuesCondition(rdoYes, "check", "yes")
        ucrPnlStartCheck.AddParameterValuesCondition(rdoNo, "check", "no")
        ucrPnlStartCheck.AddParameterValuesCondition(rdoBoth, "check", "both")

        ucrInputPlantingDates.SetParameter(New RParameter("plant_days", 5))
        ucrInputPlantingDates.SetValidationTypeAsNumericList()
        ucrInputPlantingDates.SetItems({"160", "92, 122, 153", "124, 184, 10", "92, 152, 15"})
        ucrInputPlantingDates.AddQuotesIfUnrecognised = False
        ucrInputPlantingDates.bAllowNonConditionValues = True
        ttPlanting.SetToolTip(ucrInputPlantingDates.cboInput,
        "The day number for planting." + Environment.NewLine +
        "Starting from January, April 1st is day 92. Starting from July, November 1st is day 124." + Environment.NewLine + Environment.NewLine +
        "Enter three comma-separated numbers to generate a sequence: from, to, by." + Environment.NewLine +
        "For example, 93, 183, 15 produces 93, 108, 123, …, 183.")


        'Planting Length 
        ucrInputCropLengths.SetParameter(New RParameter("plant_lengths", 6))
        ucrInputCropLengths.SetValidationTypeAsNumericList()
        ucrInputCropLengths.SetItems({"120", "100, 140, 10", "120, 150, 180", "60, 120, 10"})
        ucrInputCropLengths.AddQuotesIfUnrecognised = False
        ucrInputCropLengths.bAllowNonConditionValues = True
        ttPlanting.SetToolTip(ucrInputCropLengths.cboInput,
        "The crop duration in days. Often between 60 (2 months) and 150 (5 months)." + Environment.NewLine + Environment.NewLine +
        "Enter three comma-separated numbers to generate a sequence: from, to, by." + Environment.NewLine +
        "For example, 45, 180, 30 produces 45, 75, 105, ..., 180.")

        'Water amount 
        ucrInputWaterAmounts.SetParameter(New RParameter("rain_totals", 7))
        ucrInputWaterAmounts.SetValidationTypeAsNumericList()
        ucrInputWaterAmounts.SetItems({"600", "300, 500, 700", "200, 600, 50", "500, 700, 25"})
        ucrInputWaterAmounts.AddQuotesIfUnrecognised = False
        ucrInputWaterAmounts.bAllowNonConditionValues = True
        ttPlanting.SetToolTip(ucrInputWaterAmounts.cboInput,
        "The amount of water (rainfall) needed for the crop, usually between 250mm and 1000mm." + Environment.NewLine + Environment.NewLine +
        "Enter three comma-separated numbers to generate a sequence: from, to, by." + Environment.NewLine +
        "For example, 200, 1200, 50 produces 200, 250, 300, ..., 1200.")


        'Planting Date Panel
        'ucrPnlPlantingDate.SetParameter(New RParameter("planting_days", clsCropsFunction, 5))
        'ucrPnlPlantingDate.AddRadioButton(rdPlantingSingle)
        'ucrPnlPlantingDate.AddRadioButton(rdPlantingSeq)
        'ucrPnlPlantingDate.AddParameterPresentCondition(rdPlantingSingle, "plant_days", False)
        'ucrPnlPlantingDate.AddParameterPresentCondition(rdPlantingSeq, "plant_days", False)
        'ucrPnlPlantingDate.AddToLinkedControls(ucrNudPlantingSingleDayNum, {rdPlantingSingle}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        'ucrPnlPlantingDate.AddToLinkedControls(ucrNudPlantingSeqFrom, {rdPlantingSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        'ucrPnlPlantingDate.AddToLinkedControls(ucrNudPlantingSeqStep, {rdPlantingSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        'ucrPnlPlantingDate.AddToLinkedControls(ucrNudPlantingSeqTo, {rdPlantingSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)

        'Planting Length Panel
        'ucrPnlLength.SetParameter(New RParameter("planting_length", clsCropsFunction, 6))
        'ucrPnlLength.AddRadioButton(rdLengthSingle)
        'ucrPnlLength.AddRadioButton(rdLengthSeq)
        'ucrPnlLength.AddParameterPresentCondition(rdLengthSingle, "plant_lengths", False)
        'ucrPnlLength.AddParameterPresentCondition(rdLengthSeq, "plant_lengths", False)
        'ucrPnlLength.AddToLinkedControls(ucrNudLengthSingleDays, {rdLengthSingle}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        'ucrPnlLength.AddToLinkedControls(ucrNudLengthSeqFrom, {rdLengthSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        'ucrPnlLength.AddToLinkedControls(ucrNudLengthSeqStep, {rdLengthSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        'ucrPnlLength.AddToLinkedControls(ucrNudLengthSeqTo, {rdLengthSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)

        'Water Amount Panel 
        'ucrPanlWater.SetParameter(New RParameter("rain_totals", clsCropsFunction, 4))
        'ucrPanlWater.AddRadioButton(rdWaterSingle)
        'ucrPanlWater.AddRadioButton(rdWaterSeq)
        'ucrPanlWater.AddParameterPresentCondition(rdWaterSingle, "rain_totals", False)
        'ucrPanlWater.AddParameterPresentCondition(rdWaterSeq, "rain_totals", False)
        'ucrPanlWater.AddToLinkedControls(ucrNudLengthSingleDays, {rdWaterSingle}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        'ucrPanlWater.AddToLinkedControls(ucrNudLengthSeqFrom, {rdWaterSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        'ucrPanlWater.AddToLinkedControls(ucrNudLengthSeqStep, {rdWaterSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        'ucrPanlWater.AddToLinkedControls(ucrNudLengthSeqTo, {rdWaterSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)

        'Planting Date Single
        'ucrNudPlantingSingleDayNum.SetMinMax(1, 366)

        'Planting Date Sequence From, Step and To
        'ucrNudPlantingSeqFrom.SetParameter(New RParameter("from", clsSeqPlantingDate, 1))
        'ucrNudPlantingSeqFrom.SetMinMax(1, 366)
        'ucrNudPlantingSeqStep.SetParameter(New RParameter("step", clsSeqPlantingDate, 2))
        'ucrNudPlantingSeqStep.SetMinMax(1, 366)
        'ucrNudPlantingSeqTo.SetParameter(New RParameter("to", clsSeqPlantingDate, 3))
        'ucrNudPlantingSeqTo.SetMinMax(1, 366)

        'Planting Length Seq From, Step and To
        'ucrNudLengthSeqFrom.SetParameter(New RParameter("from", clsSeqPlantingLength))
        'ucrNudLengthSeqStep.SetParameter(New RParameter("step", clsSeqPlantingLength))
        'ucrNudLengthSeqTo.SetParameter(New RParameter("to", clsSeqPlantingLength))

        'Rainfall amount Seq From, Step and To
        'ucrNudWaterSeqFrom.SetParameter(New RParameter("from", clsSeqRainfall))
        'ucrNudWaterSeqStep.SetParameter(New RParameter("step", clsSeqRainfall))
        'ucrNudWaterSeqTo.SetParameter(New RParameter("to", clsSeqRainfall))

        ucrChkDataCrops.SetText("Return Crops Data")
        ucrChkDataCrops.SetParameter(New RParameter("return_crops_table", 11), bNewChangeParameterValue:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkDataCrops.SetRDefault("TRUE")
        ucrChkDataCrops.AddToLinkedControls(ucrSaveDefinitionCrops, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)

        ucrChkDataProp.SetText("Calculate Proportions")
        ucrChkDataProp.SetParameter(New RParameter("definition_props", 12), bNewChangeParameterValue:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkDataProp.SetRDefault("TRUE")

        ucrSaveDefinitionCrops.SetPrefix("crops_data_definition")
        ucrSaveDefinitionCrops.SetSaveType(strRObjectType:=RObjectTypeLabel.StructureLabel, strRObjectFormat:=RObjectFormat.Text)
        ucrSaveDefinitionCrops.SetIsComboBox()
        ucrSaveDefinitionCrops.SetCheckBoxText("Store Crops Data Definitions")
        ucrSaveDefinitionCrops.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
        ucrSaveDefinitionCrops.SetDataFrameSelector(ucrSelectorForCrops.ucrAvailableDataFrames)

        ucrSaveDefinitionProportions.SetPrefix("crops_proportion_definition")
        ucrSaveDefinitionProportions.SetSaveType(strRObjectType:=RObjectTypeLabel.StructureLabel, strRObjectFormat:=RObjectFormat.Text)
        ucrSaveDefinitionProportions.SetIsComboBox()
        ucrSaveDefinitionProportions.SetCheckBoxText("Store Proportion Definitions")
        ucrSaveDefinitionProportions.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
        ucrSaveDefinitionProportions.SetDataFrameSelector(ucrSelectorForCrops.ucrAvailableDataFrames)

        'Linking of controls
        ucrChkDataProp.AddToLinkedControls({ucrChkDataCrops, ucrSaveDefinitionProportions}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
        AutoFillReceivers(lstEndReceivers)
        AutoFillReceivers(lstStartReceivers)
    End Sub

    Private Sub SetDefaults()
        clsCropsFunction = New RFunction
        clsDummyFunction = New RFunction
        clsSequenceFunction = New RFunction
        clsSequencePlantingFunction = New RFunction
        clsSequencewaterFunction = New RFunction

        clsGetDataNamesFunction = New RFunction
        clsSetDiffFunction = New RFunction
        clsUpdatedDataNamesFunction = New RFunction
        clsStartsWithFunction = New RFunction
        clsGetDataFrameFunction = New RFunction
        clsGetCropDefinitionFunction = New RFunction
        clsGetSeasonStartDefinitionFunction = New RFunction
        clsStartsWithPropsFunction = New RFunction
        clsGetDataFramePropsFunction = New RFunction


        clsFirstBracketOperator = New ROperator
        clsEmptySpaceOperator = New ROperator
        clsEmptySpacePropsOperator = New ROperator

        'Currently this must come before reset to ensure autofilling is done correctly
        'Once autofilling is being triggered correctly this can go after Reset.
        ucrSelectorForCrops.Reset()
        ucrSelectorSummary.Reset()
        ucrSaveDefinitionProportions.Reset()
        ucrSaveDefinitionCrops.Reset()
        ucrReceiverRainfall.SetMeAsReceiver()
        ucrReceiverStart.SetMeAsReceiver()

        clsDummyFunction.AddParameter("check", "both", iPosition:=0)

        'Crops Function
        clsCropsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$crops_definitions")

        clsSequenceFunction.SetRCommand("seq")
        clsSequencePlantingFunction.SetRCommand("seq")
        clsSequencewaterFunction.SetRCommand("seq")

        ' Temp disabled until list working correctly

        clsGetDataNamesFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_names")
        clsGetDataNamesFunction.SetAssignTo("existing_dfs")

        clsUpdatedDataNamesFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_names")

        clsSetDiffFunction.SetRCommand("setdiff")
        clsSetDiffFunction.AddParameter("x", clsRFunctionParameter:=clsUpdatedDataNamesFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsSetDiffFunction.AddParameter("y", "existing_dfs", iPosition:=1, bIncludeArgumentName:=False)

        clsFirstBracketOperator.SetOperation("[")
        clsFirstBracketOperator.AddParameter("x", clsRFunctionParameter:=clsSetDiffFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsFirstBracketOperator.AddParameter("y", "1]", iPosition:=1, bIncludeArgumentName:=False)
        clsFirstBracketOperator.SetAssignTo("new_df_name")
        clsFirstBracketOperator.bSpaceAroundOperation = False

        clsStartsWithFunction.SetRCommand("startsWith")
        clsStartsWithFunction.AddParameter("x", "new_df_name", iPosition:=0, bIncludeArgumentName:=False)
        clsStartsWithFunction.AddParameter("y", Chr(34) & "crop_def" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)

        clsStartsWithPropsFunction.SetRCommand("startsWith")
        clsStartsWithPropsFunction.AddParameter("x", "new_df_name", iPosition:=0, bIncludeArgumentName:=False)
        clsStartsWithPropsFunction.AddParameter("y", Chr(34) & "crop_prop" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)

        clsEmptySpaceOperator.SetOperation("")
        clsEmptySpaceOperator.AddParameter("x", "new_df_name", iPosition:=0, bIncludeArgumentName:=False)
        clsEmptySpaceOperator.AddParameter("y", "[", iPosition:=1, bIncludeArgumentName:=False)
        clsEmptySpaceOperator.AddParameter("z", clsRFunctionParameter:=clsStartsWithFunction, iPosition:=2, bIncludeArgumentName:=False)
        clsEmptySpaceOperator.AddParameter("z1", "]", iPosition:=3, bIncludeArgumentName:=False)
        clsEmptySpaceOperator.bSpaceAroundOperation = False
        clsEmptySpaceOperator.SetAssignTo("new_crop_def")

        clsEmptySpacePropsOperator.SetOperation("")
        clsEmptySpacePropsOperator.AddParameter("x", "new_df_name", iPosition:=0, bIncludeArgumentName:=False)
        clsEmptySpacePropsOperator.AddParameter("y", "[", iPosition:=1, bIncludeArgumentName:=False)
        clsEmptySpacePropsOperator.AddParameter("z", clsRFunctionParameter:=clsStartsWithPropsFunction, iPosition:=2, bIncludeArgumentName:=False)
        clsEmptySpacePropsOperator.AddParameter("z1", "]", iPosition:=3, bIncludeArgumentName:=False)
        clsEmptySpacePropsOperator.bSpaceAroundOperation = False
        clsEmptySpacePropsOperator.SetAssignTo("new_crop_prop")

        clsGetDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetDataFrameFunction.AddParameter("x", clsROperatorParameter:=clsEmptySpaceOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsGetDataFrameFunction.SetAssignTo("crop_def")

        clsGetDataFramePropsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetDataFramePropsFunction.AddParameter("x", clsROperatorParameter:=clsEmptySpacePropsOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsGetDataFramePropsFunction.SetAssignTo("crop_prop")

        clsGetCropDefinitionFunction.SetRCommand("get_crop_definition")
        clsGetCropDefinitionFunction.AddParameter("x", clsRFunctionParameter:=clsGetDataFrameFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsGetSeasonStartDefinitionFunction.SetRCommand("get_season_start_definition")
        clsGetSeasonStartDefinitionFunction.AddParameter("x", clsRFunctionParameter:=clsGetDataFramePropsFunction, iPosition:=0, bIncludeArgumentName:=False)

        ucrInputPlantingDates.SetName("160")
        ucrInputCropLengths.SetName("120")
        ucrInputWaterAmounts.SetName("600")
        clsCropsFunction.AddParameter("return_crops_table", "TRUE", iPosition:=11)
        clsCropsFunction.AddParameter("definition_props", "TRUE", iPosition:=12)


        AddDataNames()
        AddDefinitionCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsCropsFunction)
        ucrBase.clsRsyntax.iCallType = 2
        TestOkEnabled()
        AddingStartCheckParm()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        'TODO This should be done further done.
        ' This ensures the correct data frame is set before attempting to fill the receiver
        'ucrReceiverYear.SetMeAsReceiver()
        'Disabled as selector cannot yet auto set when multiple data frame are selected.
        ucrSelectorForCrops.SetRCode(clsCropsFunction, bReset)
        ucrSelectorSummary.SetRCode(clsCropsFunction, bReset)
        ucrReceiverYear.SetRCode(clsCropsFunction, bReset)
        ucrReceiverStation.SetRCode(clsCropsFunction, bReset)
        ucrReceiverRainfall.SetRCode(clsCropsFunction, bReset)
        ucrReceiverDay.SetRCode(clsCropsFunction, bReset)
        'ucrReceiverStart.SetMeAsReceiver()
        ucrReceiverStart.SetRCode(clsCropsFunction, bReset)
        ucrReceiverEnd.SetRCode(clsCropsFunction, bReset)

        ' Disabled as list validation not working correctly with reading/writing controls
        ucrChkDataProp.SetRCode(clsCropsFunction, bReset)
        ucrChkDataCrops.SetRCode(clsCropsFunction, bReset)
        ucrSaveDefinitionCrops.SetRCode(clsGetCropDefinitionFunction, bReset)
        ucrSaveDefinitionProportions.SetRCode(clsGetSeasonStartDefinitionFunction, bReset)
        If bReset Then
            ucrPnlStartCheck.SetRCode(clsDummyFunction, bReset)
        End If
        AddingStartCheckParm()
        AutoFillReceivers(lstEndReceivers)
        AutoFillReceivers(lstStartReceivers)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        Dim bOkEnabled = True
        If Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverRainfall.IsEmpty AndAlso Not ucrReceiverStart.IsEmpty AndAlso Not ucrReceiverDay.IsEmpty AndAlso Not ucrReceiverEnd.IsEmpty AndAlso Not ucrInputPlantingDates.IsEmpty AndAlso Not ucrInputCropLengths.IsEmpty AndAlso Not ucrInputWaterAmounts.IsEmpty AndAlso (ucrChkDataCrops.Checked OrElse ucrChkDataProp.Checked) Then
            bOkEnabled = True
        Else
            bOkEnabled = False
        End If

        If ucrSaveDefinitionCrops.ucrChkSave.Checked AndAlso Not ucrSaveDefinitionCrops.IsComplete Then
            bOkEnabled = False
        End If

        If ucrSaveDefinitionProportions.ucrChkSave.Checked AndAlso Not ucrSaveDefinitionProportions.IsComplete Then
            bOkEnabled = False
        End If

        ucrBase.OKEnabled(bOkEnabled)
    End Sub

    Private Sub ucrReceiverYear_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlContentsChanged, ucrReceiverRainfall.ControlContentsChanged, ucrReceiverStart.ControlContentsChanged, ucrReceiverEnd.ControlContentsChanged, ucrReceiverDay.ControlContentsChanged,
            ucrInputCropLengths.ControlContentsChanged, ucrInputPlantingDates.ControlContentsChanged, ucrInputWaterAmounts.ControlContentsChanged, ucrSaveDefinitionCrops.ControlContentsChanged, ucrSaveDefinitionProportions.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorForCrops_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForCrops.ControlValueChanged, ucrSelectorSummary.ControlValueChanged
        If ucrSelectorForCrops.CurrentReceiver Is Nothing OrElse ucrSelectorForCrops.CurrentReceiver.bAttachedToPrimaryDataFrame Then
            clsCropsFunction.AddParameter("data_name", Chr(34) & ucrSelectorForCrops.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        Else
            clsCropsFunction.AddParameter("season_data_name", Chr(34) & ucrSelectorSummary.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=8)
        End If
        AutoFillReceivers(lstEndReceivers)
        AutoFillReceivers(lstStartReceivers)
    End Sub

    Private Sub Save_Definitions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDataCrops.ControlValueChanged, ucrChkDataProp.ControlValueChanged,
             ucrSaveDefinitionCrops.ControlValueChanged, ucrSaveDefinitionProportions.ControlValueChanged
        AddDefinitionCodes()
    End Sub

    Private Sub AddDefinitionCodes()
        If ucrChkDataCrops.Checked AndAlso ucrSaveDefinitionCrops.ucrChkSave.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsGetCropDefinitionFunction, iPosition:=2)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetCropDefinitionFunction)
        End If

        If ucrChkDataProp.Checked AndAlso ucrSaveDefinitionProportions.ucrChkSave.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsGetSeasonStartDefinitionFunction, iPosition:=3)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetSeasonStartDefinitionFunction)
        End If
        AddDataNames()
    End Sub

    Private Sub AddDataNames()
        If ucrSaveDefinitionProportions.ucrChkSave.Checked OrElse ucrSaveDefinitionCrops.ucrChkSave.Checked Then
            ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataNamesFunction, iPosition:=1)
            ucrBase.clsRsyntax.AddToAfterCodes(clsFirstBracketOperator, iPosition:=1)
        Else
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataNamesFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsFirstBracketOperator)
        End If
    End Sub

    Private Sub PlantingDaysParam()
        Dim strPlantingDates As String = ucrInputPlantingDates.GetText

        If ucrInputPlantingDates.IsEmpty Then
            clsSequencePlantingFunction.RemoveParameterByName("plant")
            clsCropsFunction.RemoveParameterByName("plant_days")
        Else
            Dim plantingDates As String() = ucrInputPlantingDates.GetText().Split(","c)

            If plantingDates.Length = 3 Then
                Dim first As Integer = Integer.Parse(plantingDates(0).Trim())
                Dim second As Integer = Integer.Parse(plantingDates(1).Trim())
                Dim third As Integer = Integer.Parse(plantingDates(2).Trim())

                If third < second Then
                    ' Assume a sequence and run the sequence function
                    clsSequencePlantingFunction.AddParameter("plant", strPlantingDates, iPosition:=5, bIncludeArgumentName:=False)
                    clsCropsFunction.AddParameter("plant_days", clsRFunctionParameter:=clsSequencePlantingFunction)
                Else
                    ' List the values as provided
                    clsCropsFunction.AddParameter("plant_days", "c(" & strPlantingDates & ")", iPosition:=5)
                End If
            Else
                ' List the values as provided
                clsCropsFunction.AddParameter("plant_days", "c(" & strPlantingDates & ")", iPosition:=5)
            End If
        End If
    End Sub

    Private Sub ucrPnlStartCheck_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlStartCheck.ControlValueChanged
        AddingStartCheckParm()
    End Sub

    Private Sub AddingStartCheckParm()
        If rdoYes.Checked Then
            clsCropsFunction.AddParameter("start_check", Chr(34) & "yes" & Chr(34), iPosition:=10)
        ElseIf rdoNo.Checked Then
            clsCropsFunction.AddParameter("start_check", Chr(34) & "no" & Chr(34), iPosition:=10)
        Else
            clsCropsFunction.AddParameter("start_check", Chr(34) & "both" & Chr(34), iPosition:=10)
        End If
    End Sub

    Private Sub ucrInputCropLengths_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputCropLengths.ControlValueChanged
        Dim strCropLengths As String = ucrInputCropLengths.GetText

        If ucrInputCropLengths.IsEmpty Then
            clsSequenceFunction.RemoveParameterByName("plant")
            clsCropsFunction.RemoveParameterByName("plant_lengths")
        Else
            Dim plantingDates As String() = ucrInputCropLengths.GetText().Split(","c)

            If plantingDates.Length = 3 Then
                Dim first As Integer = Integer.Parse(plantingDates(0).Trim())
                Dim second As Integer = Integer.Parse(plantingDates(1).Trim())
                Dim third As Integer = Integer.Parse(plantingDates(2).Trim())

                If third < second Then
                    ' Assume a sequence and run the sequence function
                    clsSequenceFunction.AddParameter("plant", strCropLengths, iPosition:=5, bIncludeArgumentName:=False)
                    clsCropsFunction.AddParameter("plant_lengths", clsRFunctionParameter:=clsSequenceFunction)
                Else
                    ' List the values as provided
                    clsCropsFunction.AddParameter("plant_lengths", "c(" & strCropLengths & ")", iPosition:=6)
                End If
            Else
                ' List the values as provided
                clsCropsFunction.AddParameter("plant_lengths", "c(" & strCropLengths & ")", iPosition:=6)
            End If
        End If
    End Sub

    Private Sub ucrInputPlantingDates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputPlantingDates.ControlValueChanged
        PlantingDaysParam()
    End Sub

    Private Sub ucrInputWaterAmounts_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputWaterAmounts.ControlValueChanged
        Dim strWaterAmounts As String = ucrInputWaterAmounts.GetText

        If ucrInputWaterAmounts.IsEmpty Then
            clsCropsFunction.RemoveParameterByName("rain_totals")
            clsSequencewaterFunction.RemoveParameterByName("totals")
        Else
            Dim plantingDates As String() = ucrInputWaterAmounts.GetText().Split(","c)

            If plantingDates.Length = 3 Then
                Dim first As Integer = Integer.Parse(plantingDates(0).Trim())
                Dim second As Integer = Integer.Parse(plantingDates(1).Trim())
                Dim third As Integer = Integer.Parse(plantingDates(2).Trim())

                If third < second Then
                    ' Assume a sequence and run the sequence function
                    clsSequencewaterFunction.AddParameter("totals", strWaterAmounts, iPosition:=5, bIncludeArgumentName:=False)
                    clsCropsFunction.AddParameter("rain_totals", clsRFunctionParameter:=clsSequencewaterFunction)
                Else
                    ' List the values as provided
                    clsCropsFunction.AddParameter("rain_totals", "c(" & strWaterAmounts & ")", iPosition:=7)
                End If
            Else
                ' List the values as provided
                clsCropsFunction.AddParameter("rain_totals", "c(" & strWaterAmounts & ")", iPosition:=7)
            End If
        End If
    End Sub

    Private Sub AutoFillReceivers(lstReceivers As List(Of ucrReceiverSingle))
        If bisFilling OrElse lstReceivers Is Nothing Then
            Exit Sub
        End If

        bisFilling = True

        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver = ucrSelectorSummary.CurrentReceiver
        Dim strSelectedValue As String
        Dim bFound As Boolean = False

        For Each ucrTempReceiver As ucrReceiver In lstReceivers
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedValues(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                Dim lstAvailable As List(Of String) = ucrSelectorSummary.lstAvailableVariable.Items.Cast(Of ListViewItem) _
                .Select(Function(item) Regex.Replace(item.Text.ToLower(), "[^\w]", String.Empty)).ToList()

                If lstRecognisedValues.Contains("end_season") AndAlso lstAvailable.Contains("end_season") Then
                    strSelectedValue = "end_season"
                Else
                    strSelectedValue = lstRecognisedValues.FirstOrDefault(Function(val) lstAvailable.Contains(val))
                End If

                If Not String.IsNullOrEmpty(strSelectedValue) Then
                    Dim matchingItem As ListViewItem = ucrSelectorSummary.lstAvailableVariable.Items.Cast(Of ListViewItem) _
                    .FirstOrDefault(Function(item) Regex.Replace(item.Text.ToLower(), "[^\w]", String.Empty) = strSelectedValue)

                    If matchingItem IsNot Nothing Then
                        ucrTempReceiver.Add(matchingItem.Text, ucrSelectorSummary.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                    End If
                End If
            End If
        Next

        If ucrCurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver.SetMeAsReceiver()
        End If

        bisFilling = False
    End Sub

    Private Function GetRecognisedValues(strVariable As String) As List(Of String)
        Dim lstValues As New List(Of String)

        For Each kvpTemp As KeyValuePair(Of String, List(Of String)) In lstRecognisedTypes
            If kvpTemp.Key = strVariable Then
                lstValues = kvpTemp.Value
                Exit For
            End If
        Next
        Return lstValues
    End Function
End Class
