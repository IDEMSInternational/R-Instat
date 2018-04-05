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
    Private clsSeqPlantingDate, clsSeqPlantingLength, clsSeqRainfall As New RFunction
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True

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

        ucrSelectorForCrops.SetParameter(New RParameter("data_name", clsCropsFunction, 1))
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
        ucrReceiverStart.SetParameter(New RParameter("start_day", clsCropsFunction, 8, bNewIncludeArgumentName:=False))
        ucrReceiverStart.Selector = ucrSelectorForCrops
        ucrReceiverStart.SetClimaticType("start")
        ucrReceiverStart.bAutoFill = True

        'End Receiver
        ucrReceiverEnd.SetParameter(New RParameter("end_day", clsCropsFunction, 9, bNewIncludeArgumentName:=False))
        ucrReceiverEnd.Selector = ucrSelectorForCrops
        ucrReceiverEnd.SetClimaticType("end")
        ucrReceiverEnd.bAutoFill = True

        'Year Receiver
        ucrReceiverYear.SetParameter(New RParameter("year", clsCropsFunction, 2, bNewIncludeArgumentName:=False))
        ucrReceiverYear.Selector = ucrSelectorForCrops
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True

        'Day Receiver
        ucrReceiverDay.Selector = ucrSelectorForCrops
        ucrReceiverDay.SetClimaticType("day")
        ucrReceiverDay.bAutoFill = True

        'Rainfall Receiver
        ucrReceiverRainfall.SetParameter(New RParameter("rain", clsCropsFunction, 3, bNewIncludeArgumentName:=False))
        ucrReceiverRainfall.Selector = ucrSelectorForCrops
        ucrReceiverRainfall.SetClimaticType("rain")
        ucrReceiverRainfall.bAutoFill = True

        'Planting Date Panel
        ucrPnlPlantingDate.SetParameter(New RParameter("planting_days", clsCropsFunction, 5))
        ucrPnlPlantingDate.AddRadioButton(rdPlantingSingle)
        ucrPnlPlantingDate.AddRadioButton(rdPlantingSeq)
        'ucrPnlPlantingDate.AddParameterPresentCondition(rdPlantingSingle, "plant_days", False)
        'ucrPnlPlantingDate.AddParameterPresentCondition(rdPlantingSeq, "plant_days", False)
        ucrPnlPlantingDate.AddToLinkedControls(ucrNudPlantingSingleDayNum, {rdPlantingSingle}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPnlPlantingDate.AddToLinkedControls(ucrNudPlantingSeqFrom, {rdPlantingSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPnlPlantingDate.AddToLinkedControls(ucrNudPlantingSeqStep, {rdPlantingSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPnlPlantingDate.AddToLinkedControls(ucrNudPlantingSeqTo, {rdPlantingSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)

        'Planting Length Panel
        ucrPnlLength.SetParameter(New RParameter("planting_length", clsCropsFunction, 6))
        ucrPnlLength.AddRadioButton(rdLengthSingle)
        ucrPnlLength.AddRadioButton(rdLengthSeq)
        'ucrPnlLength.AddParameterPresentCondition(rdLengthSingle, "plant_lengths", False)
        'ucrPnlLength.AddParameterPresentCondition(rdLengthSeq, "plant_lengths", False)
        ucrPnlLength.AddToLinkedControls(ucrNudLengthSingleDays, {rdLengthSingle}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPnlLength.AddToLinkedControls(ucrNudLengthSeqFrom, {rdLengthSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPnlLength.AddToLinkedControls(ucrNudLengthSeqStep, {rdLengthSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPnlLength.AddToLinkedControls(ucrNudLengthSeqTo, {rdLengthSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)

        'Water Amount Panel 
        ucrPanlWater.SetParameter(New RParameter("rain_totals", clsCropsFunction, 4))
        ucrPanlWater.AddRadioButton(rdWaterSingle)
        ucrPanlWater.AddRadioButton(rdWaterSeq)
        'ucrPanlWater.AddParameterPresentCondition(rdWaterSingle, "rain_totals", False)
        'ucrPanlWater.AddParameterPresentCondition(rdWaterSeq, "rain_totals", False)
        ucrPanlWater.AddToLinkedControls(ucrNudLengthSingleDays, {rdWaterSingle}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPanlWater.AddToLinkedControls(ucrNudLengthSeqFrom, {rdWaterSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPanlWater.AddToLinkedControls(ucrNudLengthSeqStep, {rdWaterSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPanlWater.AddToLinkedControls(ucrNudLengthSeqTo, {rdWaterSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)

        'Planting Date Single
        ucrNudPlantingSingleDayNum.SetMinMax(1, 366)

        'Planting Date Sequence From, Step and To
        ucrNudPlantingSeqFrom.SetParameter(New RParameter("from", clsSeqPlantingDate, 1))
        ucrNudPlantingSeqFrom.SetMinMax(1, 366)
        ucrNudPlantingSeqStep.SetParameter(New RParameter("step", clsSeqPlantingDate, 2))
        ucrNudPlantingSeqStep.SetMinMax(1, 366)
        ucrNudPlantingSeqTo.SetParameter(New RParameter("to", clsSeqPlantingDate, 3))
        ucrNudPlantingSeqTo.SetMinMax(1, 366)

        'Planting Length Seq From, Step and To
        ucrNudLengthSeqFrom.SetParameter(New RParameter("from", clsSeqPlantingLength))
        ucrNudLengthSeqStep.SetParameter(New RParameter("step", clsSeqPlantingLength))
        ucrNudLengthSeqTo.SetParameter(New RParameter("to", clsSeqPlantingLength))

        'Rainfall amount Seq From, Step and To
        ucrNudWaterSeqFrom.SetParameter(New RParameter("from", clsSeqRainfall))
        ucrNudWaterSeqStep.SetParameter(New RParameter("step", clsSeqRainfall))
        ucrNudWaterSeqTo.SetParameter(New RParameter("to", clsSeqRainfall))

        'ucrSaveDataFrame
        ucrSaveDataFrame.SetIsTextBox()
        ucrSaveDataFrame.SetSaveTypeAsDataFrame()
        ucrSaveDataFrame.SetLabelText("Save Result As:")
        'ucrSaveDataFrame.SetPrefix("data")
        ucrSaveDataFrame.Enabled = False

    End Sub

    Private Sub SetDefaults()
        clsCropsFunction = New RFunction
        clsCropsFunction.Clear()

        ucrSelectorForCrops.Reset()
        ucrReceiverStation.SetMeAsReceiver()

        'InstatDataObject$crops_definitions(data_name = "dodoma", year = "Year", rain = "Rain", rain_totals = c(200, 300), plant_days = seq(from = 90, to = 180, by = 20), plant_lengths = seq(from = 60, to = 80, by = 20), season_data_name = "dodoma_by_Year", start_day = "start", end_day = "end", definition_props = TRUE, print_table = TRUE)
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
        clsSeqPlantingDate.SetRCommand("seq")
        clsSeqPlantingDate.AddParameter("from", iPosition:=0)
        clsSeqPlantingDate.AddParameter("step", iPosition:=0)
        clsSeqPlantingDate.AddParameter("to", iPosition:=0)

        'Planting date seq function 
        clsSeqPlantingLength.SetRCommand("seq")
        clsSeqPlantingLength.AddParameter("from", iPosition:=0)
        clsSeqPlantingLength.AddParameter("step", iPosition:=0)
        clsSeqPlantingLength.AddParameter("to", iPosition:=0)

        'Rainfall amount seq function 
        clsSeqRainfall.SetRCommand("seq")
        clsSeqRainfall.AddParameter("from", iPosition:=0)
        clsSeqRainfall.AddParameter("step", iPosition:=0)
        clsSeqRainfall.AddParameter("to", iPosition:=0)

        TestOkEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        'SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverRainfall.IsEmpty AndAlso Not ucrReceiverStart.IsEmpty AndAlso ucrReceiverEnd.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub PlantingSingleOrSeq()
        If rdPlantingSingle.Checked Then
            clsCropsFunction.AddParameter("planting_days", strParameterValue:=ucrNudPlantingSingleDayNum.Value, iPosition:=5)
        ElseIf rdPlantingSeq.Checked Then
            clsCropsFunction.AddParameter("planting_days", clsRFunctionParameter:=clsSeqPlantingDate, iPosition:=5)
        End If
    End Sub

    Private Sub ucrSelectorForCrops_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForCrops.ControlValueChanged
        clsCropsFunction.AddParameter("data_name", ucrSelectorForCrops.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
    End Sub

    Private Sub ucrReceiverYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged
        clsCropsFunction.AddParameter("year", ucrReceiverYear.GetVariableNames())
    End Sub

    Private Sub ucrReceiverRainfall_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRainfall.ControlValueChanged
        clsCropsFunction.AddParameter("rain", ucrReceiverRainfall.GetVariableNames())
    End Sub

    Private Sub ucrReceiverStart_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStart.ControlValueChanged
        clsCropsFunction.AddParameter("start_day", ucrReceiverStart.GetVariableNames())
    End Sub

    Private Sub ucrReceiverEnd_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverEnd.ControlValueChanged
        clsCropsFunction.AddParameter("end_day", ucrReceiverEnd.GetVariableNames())
    End Sub

End Class