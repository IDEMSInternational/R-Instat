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

Public Class dlgPICSACrops
    Private clsCropsFunction As New RFunction
    Private clsDummyFunction As New RFunction
    Private clsSequenceFunction, clsSequencewaterFunction, clsSequencePlantingFunction As New RFunction
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private strCurrDataName As String = ""

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
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 480
        ' Sub dialog not yet created.
        cmdOptions.Visible = False

        ucrSelectorForCrops.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForCrops.SetParameterIsString()

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
        ucrReceiverStart.SetParameter(New RParameter("start_day", 8))
        ucrReceiverStart.SetParameterIsString()
        ucrReceiverStart.SetDataType("numeric")
        ucrReceiverStart.Selector = ucrSelectorForCrops
        ucrReceiverStart.bAttachedToPrimaryDataFrame = False

        'End Receiver
        ucrReceiverEnd.Selector = ucrSelectorForCrops
        ucrReceiverEnd.SetParameter(New RParameter("end_day", 9))
        ucrReceiverEnd.SetParameterIsString()
        ucrReceiverEnd.SetDataType("numeric")
        ucrReceiverEnd.bAttachedToPrimaryDataFrame = False

        ucrPnlStartCheck.AddRadioButton(rdoYes)
        ucrPnlStartCheck.AddRadioButton(rdoNo)
        ucrPnlStartCheck.AddRadioButton(rdoBoth)
        ucrPnlStartCheck.AddParameterValuesCondition(rdoYes, "check", "yes")
        ucrPnlStartCheck.AddParameterValuesCondition(rdoNo, "check", "no")
        ucrPnlStartCheck.AddParameterValuesCondition(rdoBoth, "check", "both")

        ucrInputPlantingDates.SetParameter(New RParameter("plant_days", 5))
        ucrInputPlantingDates.SetValidationTypeAsNumericList()
        ucrInputPlantingDates.SetItems({"160", "80, 90, 100, 110, 120", "92, 122, 153", "124, 184, 10", "92, 152, 15"})
        ucrInputPlantingDates.AddQuotesIfUnrecognised = False
        ucrInputPlantingDates.bAllowNonConditionValues = True

        'Planting Length 
        ucrInputCropLengths.SetParameter(New RParameter("plant_lengths", 6))
        ucrInputCropLengths.SetValidationTypeAsNumericList()
        ucrInputCropLengths.SetItems({"120", "100, 110, 120, 130, 140", "80, 90, 100, 110", "120, 150, 180", "60, 120, 10"})
        ucrInputCropLengths.AddQuotesIfUnrecognised = False
        ucrInputCropLengths.bAllowNonConditionValues = True

        'Water amount 
        ucrInputWaterAmounts.SetParameter(New RParameter("rain_totals", 7))
        ucrInputWaterAmounts.SetValidationTypeAsNumericList()
        ucrInputWaterAmounts.SetItems({"600", "300, 400, 500, 600, 700", "300, 500, 700", "200, 600, 50", "500, 700, 25"})
        ucrInputWaterAmounts.AddQuotesIfUnrecognised = False
        ucrInputWaterAmounts.bAllowNonConditionValues = True

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

        ucrChkDataProp.SetText("Calculate Proportions")
        ucrChkDataProp.SetParameter(New RParameter("definition_props", 8), bNewChangeParameterValue:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkDataProp.SetRDefault("TRUE")

        ucrChkPrintDataProp.SetText("Print Proportions Table(s)")
        ucrChkPrintDataProp.SetParameter(New RParameter("print_table", 9), bNewChangeParameterValue:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkPrintDataProp.SetRDefault("TRUE")

        'Linking of controls
        ucrChkDataProp.AddToLinkedControls(ucrChkPrintDataProp, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
    End Sub

    Private Sub SetDefaults()
        clsCropsFunction = New RFunction
        clsDummyFunction = New RFunction
        clsSequenceFunction = New RFunction
        clsSequencePlantingFunction = New RFunction
        clsSequencewaterFunction = New RFunction
        'Currently this must come before reset to ensure autofilling is done correctly
        'Once autofilling is being triggered correctly this can go after Reset.
        ucrSelectorForCrops.Reset()
        ucrReceiverRainfall.SetMeAsReceiver()

        clsDummyFunction.AddParameter("check", "both", iPosition:=0)

        'Crops Function
        clsCropsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$crops_definitions")

        clsSequenceFunction.SetRCommand("seq")
        clsSequencePlantingFunction.SetRCommand("seq")
        clsSequencewaterFunction.SetRCommand("seq")

        ' Temp disabled until list working correctly

        ucrInputPlantingDates.SetName("160")
        ucrInputCropLengths.SetName("120")
        ucrInputWaterAmounts.SetName("600")
        clsCropsFunction.AddParameter("definition_props", "TRUE", iPosition:=11)
        clsCropsFunction.AddParameter("print_table", "TRUE", iPosition:=12)
        ucrBase.clsRsyntax.SetBaseRFunction(clsCropsFunction)
        ucrBase.clsRsyntax.iCallType = 2
        TestOkEnabled()
        AddingStartCheckParm()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        'TODO This should be done further done.
        ' This ensures the correct data frame is set before attempting to fill the receiver
        'ucrReceiverYear.SetMeAsReceiver()
        ucrSelectorForCrops.SetDataframe(ucrReceiverYear.GetDataName())
        'Disabled as selector cannot yet auto set when multiple data frame are selected.
        'ucrSelectorForCrops.SetRCode(clsCropsFunction, bReset)
        ucrReceiverYear.SetRCode(clsCropsFunction, bReset)
        ucrReceiverStation.SetRCode(clsCropsFunction, bReset)
        ucrReceiverRainfall.SetRCode(clsCropsFunction, bReset)
        ucrReceiverDay.SetRCode(clsCropsFunction, bReset)
        'ucrReceiverStart.SetMeAsReceiver()
        ucrSelectorForCrops.SetDataframe(ucrReceiverStart.GetDataName())
        ucrReceiverStart.SetRCode(clsCropsFunction, bReset)
        ucrReceiverEnd.SetRCode(clsCropsFunction, bReset)

        ' Disabled as list validation not working correctly with reading/writing controls
        ucrChkDataProp.SetRCode(clsCropsFunction, bReset)
        ucrChkPrintDataProp.SetRCode(clsCropsFunction, bReset)
        If bReset Then
            ucrPnlStartCheck.SetRCode(clsDummyFunction, bReset)
        End If
        AddingStartCheckParm()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverRainfall.IsEmpty AndAlso Not ucrReceiverStart.IsEmpty AndAlso Not ucrReceiverDay.IsEmpty AndAlso Not ucrReceiverEnd.IsEmpty AndAlso Not ucrInputPlantingDates.IsEmpty AndAlso Not ucrInputCropLengths.IsEmpty AndAlso Not ucrInputWaterAmounts.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrReceiverYear_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlContentsChanged, ucrReceiverRainfall.ControlContentsChanged, ucrReceiverStart.ControlContentsChanged, ucrReceiverEnd.ControlContentsChanged, ucrReceiverDay.ControlContentsChanged,
            ucrInputCropLengths.ControlContentsChanged, ucrInputPlantingDates.ControlContentsChanged, ucrInputWaterAmounts.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorForCrops_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForCrops.ControlValueChanged
        If ucrSelectorForCrops.CurrentReceiver Is Nothing OrElse ucrSelectorForCrops.CurrentReceiver.bAttachedToPrimaryDataFrame Then
            clsCropsFunction.AddParameter("data_name", Chr(34) & ucrSelectorForCrops.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        Else
            clsCropsFunction.AddParameter("season_data_name", Chr(34) & ucrSelectorForCrops.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=8)
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

End Class