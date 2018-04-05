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
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private strCurrDataName As String = ""

    Private Sub dlgPICSACrops_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False

        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 480

        ucrSelectorForCrops.SetParameter(New RParameter("data_name", 1))
        ucrSelectorForCrops.SetParameterIsString()

        'Station Receiver
        ucrReceiverStation.Selector = ucrSelectorForCrops
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        'Date Receiver
        ucrReceiverDate.Selector = ucrSelectorForCrops
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bAutoFill = True

        'Start Receiver
        ucrReceiverStart.SetParameter(New RParameter("start_day", 8))
        ucrReceiverStart.Selector = ucrSelectorForCrops
        ucrReceiverStart.SetClimaticType("start")
        ucrReceiverStart.bAutoFill = True

        'End Receiver
        ucrReceiverEnd.SetParameter(New RParameter("end_day", 9))
        ucrReceiverEnd.Selector = ucrSelectorForCrops
        ucrReceiverEnd.SetClimaticType("end")
        ucrReceiverEnd.bAutoFill = True

        'Year Receiver
        ucrReceiverYear.SetParameter(New RParameter("year", 2))
        ucrReceiverYear.Selector = ucrSelectorForCrops
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True

        'Day Receiver
        ucrReceiverDay.Selector = ucrSelectorForCrops
        ucrReceiverDay.SetClimaticType("day")
        ucrReceiverDay.bAutoFill = True

        'Rainfall Receiver
        ucrReceiverRainfall.SetParameter(New RParameter("rain", 3))
        ucrReceiverRainfall.Selector = ucrSelectorForCrops
        ucrReceiverRainfall.SetClimaticType("rain")
        ucrReceiverRainfall.bAutoFill = True

        'Planting date 
        ucrTxtBoxPlantingDate.SetParameter(New RParameter("planting_days", 5))
        ucrTxtBoxPlantingDate.SetValidationTypeAsNumeric()
        ucrTxtBoxPlantingDate.AddQuotesIfUnrecognised = False

        'Planting Length 
        ucrTxtBoxPlantingLength.SetParameter(New RParameter("planting_length", 6))
        ucrTxtBoxPlantingLength.SetValidationTypeAsNumeric()
        ucrTxtBoxPlantingLength.AddQuotesIfUnrecognised = False

        'Water amount 
        ucrTxtBoxWaterAmount.SetParameter(New RParameter("rain_totals", 4))
        ucrTxtBoxWaterAmount.SetValidationTypeAsNumeric()
        ucrTxtBoxWaterAmount.AddQuotesIfUnrecognised = False

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

        'ucrSaveDataFrame
        'ucrSaveDataFrame.SetParameter(New RParameter("definition_props", 8))
        ucrChkDataProp.SetText("Data Frame of Proportions")
        ucrChkDataProp.SetParameter(New RParameter("definition_props", 8))

        ucrChkPrintDataProp.SetText("Print Data Frame")
        ucrChkPrintDataProp.SetParameter(New RParameter("print_table", 9))

        'Linking of controls
        ucrChkDataProp.AddToLinkedControls(ucrChkPrintDataProp, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)

    End Sub

    Private Sub SetDefaults()
        clsCropsFunction = New RFunction
        clsCropsFunction.Clear()

        ucrSelectorForCrops.Reset()
        ucrReceiverStation.SetMeAsReceiver()
        ucrTxtBoxPlantingDate.Reset()
        ucrTxtBoxPlantingLength.Reset()
        ucrTxtBoxWaterAmount.Reset()

        'Crops Function
        clsCropsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$crops_definitions")
        clsCropsFunction.AddParameter("data_name", iPosition:=0)
        clsCropsFunction.AddParameter("year")
        clsCropsFunction.AddParameter("rain")
        clsCropsFunction.AddParameter("rain_totals")
        clsCropsFunction.AddParameter("plant_days")
        clsCropsFunction.AddParameter("plant_length")
        clsCropsFunction.AddParameter("season_data_name")
        clsCropsFunction.AddParameter("start_day")
        clsCropsFunction.AddParameter("end_day")
        clsCropsFunction.AddParameter("definition_props")
        clsCropsFunction.AddParameter("print_table")
        clsCropsFunction.SetAssignTo("crops_data")
        ucrBase.clsRsyntax.SetBaseRFunction(clsCropsFunction)

        'Planting date seq function 
        'clsSeqPlantingDate.SetRCommand("seq")
        'clsSeqPlantingDate.AddParameter("from", iPosition:=0)
        'clsSeqPlantingDate.AddParameter("step", iPosition:=0)
        'clsSeqPlantingDate.AddParameter("to", iPosition:=0)

        'Planting date seq function 
        'clsSeqPlantingLength.SetRCommand("seq")
        'clsSeqPlantingLength.AddParameter("from", iPosition:=0)
        'clsSeqPlantingLength.AddParameter("step", iPosition:=0)
        'clsSeqPlantingLength.AddParameter("to", iPosition:=0)

        'Rainfall amount seq function 
        'clsSeqRainfall.SetRCommand("seq")
        'clsSeqRainfall.AddParameter("from", iPosition:=0)
        'clsSeqRainfall.AddParameter("step", iPosition:=0)
        'clsSeqRainfall.AddParameter("to", iPosition:=0)

        TestOkEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverYear.SetRCode(clsCropsFunction, bReset)
        ucrReceiverRainfall.SetRCode(clsCropsFunction, bReset)
        ucrReceiverStart.SetRCode(clsCropsFunction, bReset)
        ucrReceiverEnd.SetRCode(clsCropsFunction, bReset)
        ucrTxtBoxPlantingDate.SetRCode(clsCropsFunction, bReset)
        ucrTxtBoxPlantingLength.SetRCode(clsCropsFunction, bReset)
        ucrTxtBoxWaterAmount.SetRCode(clsCropsFunction, bReset)
        ucrChkDataProp.SetRCode(clsCropsFunction, bReset)
        ucrChkPrintDataProp.SetRCode(clsCropsFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverRainfall.IsEmpty AndAlso Not ucrReceiverStart.IsEmpty AndAlso ucrReceiverEnd.IsEmpty AndAlso Not ucrTxtBoxPlantingDate.IsEmpty AndAlso Not ucrTxtBoxPlantingLength.IsEmpty AndAlso Not ucrTxtBoxWaterAmount.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    'Private Sub PlantingSingleOrSeq()
    'If rdPlantingSingle.Checked Then
    '       clsCropsFunction.AddParameter("planting_days", strParameterValue:=ucrNudPlantingSingleDayNum.Value, iPosition:=5)
    'ElseIf rdPlantingSeq.Checked Then
    '       clsCropsFunction.AddParameter("planting_days", clsRFunctionParameter:=clsSeqPlantingDate, iPosition:=5)
    'End If
    'End Sub

    Private Sub ucrSelectorForCrops_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForCrops.ControlValueChanged
        clsCropsFunction.AddParameter("data_name", ucrSelectorForCrops.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
    End Sub

    Private Sub ucrReceiverYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged
        clsCropsFunction.AddParameter("year", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")", iPosition:=2)
    End Sub

    Private Sub ucrReceiverRainfall_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRainfall.ControlValueChanged
        clsCropsFunction.AddParameter("rain", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")")
    End Sub

    Private Sub ucrReceiverStart_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStart.ControlValueChanged
        clsCropsFunction.AddParameter("start_day", "list(" & strCurrDataName & "=" & ucrReceiverStart.GetVariableNames & ")")
    End Sub

    Private Sub ucrReceiverEnd_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverEnd.ControlValueChanged
        clsCropsFunction.AddParameter("end_day", "list(" & strCurrDataName & "=" & ucrReceiverEnd.GetVariableNames & ")")
    End Sub

    Private Sub ucrTxtBoxPlantingDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrTxtBoxPlantingDate.ControlValueChanged
        clsCropsFunction.AddParameter("planting_days", ucrTxtBoxPlantingDate.GetText, iPosition:=5)
    End Sub

    Private Sub ucrTxtBoxPlantingLength_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrTxtBoxPlantingLength.ControlValueChanged
        clsCropsFunction.AddParameter("planting_length", ucrTxtBoxPlantingLength.GetText, iPosition:=6)
    End Sub

    Private Sub ucrTxtBoxWaterAmount_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrTxtBoxWaterAmount.ControlValueChanged
        clsCropsFunction.AddParameter("rain_totals", ucrTxtBoxPlantingDate.GetText, iPosition:=4)
    End Sub

    Private Sub ucrChkDataProp_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkDataProp.ControlContentsChanged
        If ucrChkDataProp.Checked Then
            clsCropsFunction.AddParameter("definition_props ", "TRUE", iPosition:=8)
        Else
            clsCropsFunction.AddParameter("definition_props", "FALSE", iPosition:=8)
        End If
    End Sub

    Private Sub ucrChkPrintDataProp_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkPrintDataProp.ControlContentsChanged
        If ucrChkDataProp.Checked AndAlso ucrChkPrintDataProp.Checked Then
            clsCropsFunction.AddParameter("print_table", "TRUE", iPosition:=9)
        ElseIf ucrChkDataProp.Checked AndAlso Not ucrChkPrintDataProp.Checked Then
            clsCropsFunction.AddParameter("definition_props", "FALSE", iPosition:=9)
        ElseIf Not ucrChkDataProp.Checked Then
            clsCropsFunction.AddParameter("definition_props", "FALSE", iPosition:=9)
        End If
    End Sub

End Class