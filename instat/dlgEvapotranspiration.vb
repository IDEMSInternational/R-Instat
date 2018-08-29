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

Public Class dlgEvapotranspiration
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsETPenmanMonteith, clsHargreavesSamani, clsDataFunctionPM, clsDataFunctionHS, clsDataFunction, clsReadInputs, clsVector, clsMissingDataVector, clsVarnamesVectorPM, clsVarnamesVectorHS As New RFunction
    Private clsDayFunc, clsMonthFunc, clsYearFunc As New RFunction
    Private clsDailyOperatorPM, clsDailyOperatorHS As New ROperator

    Private Sub dlgdlgEvapotranspiration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2
        'ucrBase.iHelpTopicID = 510
        Dim dctInputCrops As New Dictionary(Of String, String)
        Dim dctInputTimeStep As New Dictionary(Of String, String)
        Dim dctInputSolar As New Dictionary(Of String, String)
        Dim dctInputMissingMethod As New Dictionary(Of String, String)


        ucrReceiverDate.Selector = ucrSelectorEvapotranspiration
        ucrReceiverTmax.Selector = ucrSelectorEvapotranspiration
        ucrReceiverTmin.Selector = ucrSelectorEvapotranspiration
        ucrReceiverHumidityMax.Selector = ucrSelectorEvapotranspiration
        ucrReceiverHumidityMin.Selector = ucrSelectorEvapotranspiration
        ucrReceiverRadiation.Selector = ucrSelectorEvapotranspiration
        ucrReceiverWindSpeed.Selector = ucrSelectorEvapotranspiration

        'receivers
        ucrReceiverDate.SetLinkedDisplayControl(lblDate)
        ucrReceiverTmax.SetLinkedDisplayControl(lblTmax)
        ucrReceiverTmin.SetLinkedDisplayControl(lblTmin)
        ucrReceiverHumidityMax.SetLinkedDisplayControl(lblHumidityMax)
        ucrReceiverHumidityMin.SetLinkedDisplayControl(lblHumidityMin)
        ucrReceiverWindSpeed.SetLinkedDisplayControl(lblWindSpeed)
        ucrInputSolar.SetLinkedDisplayControl(lblSolar)
        ucrInputMissingMethod.SetLinkedDisplayControl(lblMissingMethod)

        ucrReceiverDate.SetParameter(New RParameter("x", 0))
        ucrReceiverDate.SetParameterIsRFunction()
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bAutoFill = True


        ucrReceiverTmax.SetParameter(New RParameter("Tmax", 3))
        ucrReceiverTmax.SetParameterIsRFunction()
        ucrReceiverTmax.SetClimaticType("temp_max")
        ucrReceiverTmax.bAutoFill = True


        ucrReceiverTmin.SetParameter(New RParameter("Tmin", 3))
        ucrReceiverTmin.SetParameterIsRFunction()
        ucrReceiverTmin.SetClimaticType("temp_min")
        ucrReceiverTmin.bAutoFill = True


        ucrReceiverHumidityMax.SetParameter(New RParameter("RHmax", 4))
        ucrReceiverHumidityMax.SetParameterIsRFunction()
        'UcrReceiverHumidityMax.bAutoFill = True


        ucrReceiverHumidityMin.SetParameter(New RParameter("RHmin", 5))
        ucrReceiverHumidityMin.SetParameterIsRFunction()
        'UcrReceiverHumidityMin.bAutoFill = True


        ucrReceiverRadiation.SetParameter(New RParameter("n", 6))
        ucrReceiverRadiation.SetParameterIsRFunction()
        ucrReceiverRadiation.SetClimaticType("sunshine_hours")
        ucrReceiverRadiation.bAutoFill = True


        ucrReceiverWindSpeed.SetParameter(New RParameter("u2", 7))
        ucrReceiverWindSpeed.SetParameterIsRFunction()
        ucrReceiverWindSpeed.SetClimaticType("wind_speed")
        ucrReceiverWindSpeed.bAutoFill = True

        ucrInputTimeStep.SetParameter(New RParameter("ts", 2))
        ucrInputTimeStep.SetRDefault(Chr(34) & "daily" & Chr(34))
        dctInputTimeStep.Add("daily", Chr(34) & "daily" & Chr(34))
        dctInputTimeStep.Add("monthly", Chr(34) & "monthly" & Chr(34))
        dctInputTimeStep.Add("annual", Chr(34) & "annual" & Chr(34))
        ucrInputTimeStep.SetItems(dctInputTimeStep)
        ucrInputTimeStep.SetDropDownStyleAsNonEditable()
        ucrInputTimeStep.SetLinkedDisplayControl(lblTimeStep)

        ucrInputSolar.SetParameter(New RParameter("solar", 3))
        ucrInputSolar.SetRDefault(Chr(34) & "sunshine hours" & Chr(34))
        dctInputSolar.Add("sunshine hours", Chr(34) & "sunshine hours" & Chr(34))
        dctInputSolar.Add("cloud", Chr(34) & "cloud" & Chr(34))
        dctInputSolar.Add("data", Chr(34) & "data" & Chr(34))
        ucrInputSolar.SetItems(dctInputSolar)
        ucrInputSolar.SetDropDownStyleAsNonEditable()

        ucrInputCrop.SetParameter(New RParameter("crops", 5))
        dctInputCrops.Add("short", Chr(34) & "short" & Chr(34))
        dctInputCrops.Add("tall", Chr(34) & "tall" & Chr(34))
        ucrInputCrop.SetItems(dctInputCrops)
        ucrInputCrop.SetRDefault(Chr(34) & "short" & Chr(34))
        ucrInputCrop.SetDropDownStyleAsNonEditable()
        ucrInputCrop.SetLinkedDisplayControl(lblCrop)

        ucrChkWind.SetParameter(New RParameter("wind", 4))
        ucrChkWind.SetText("Wind")
        ucrChkWind.SetValuesCheckedAndUnchecked(Chr(34) & "yes" & Chr(34), Chr(34) & "no" & Chr(34))
        ucrChkWind.SetRDefault(Chr(34) & "yes" & Chr(34))

        ' Missing Options 
        ucrChkInterpMissingDays.SetParameter(New RParameter("interp_missing_days"))
        ucrChkInterpMissingDays.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkInterpMissingDays.SetRDefault("FALSE")
        ucrChkInterpMissingDays.SetText("Interpolate Missing Days")

        ucrChkInterpMissingEntries.SetParameter(New RParameter("interp_missing_entries"))
        ucrChkInterpMissingEntries.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkInterpMissingEntries.SetRDefault("FALSE")
        ucrChkInterpMissingEntries.SetText("Interpolate Missing Entries")

        ucrInputMissingMethod.SetParameter(New RParameter("missing_method"))
        ucrInputMissingMethod.SetDropDownStyleAsNonEditable()
        dctInputMissingMethod.Add("monthly average", Chr(34) & "monthly average" & Chr(34))
        dctInputMissingMethod.Add("seasonal average", Chr(34) & "seasonal average" & Chr(34))
        dctInputMissingMethod.Add("DoY average", Chr(34) & "DoY average" & Chr(34))
        dctInputMissingMethod.Add("neighbouring average", Chr(34) & "neighbouring average" & Chr(34))
        ucrInputMissingMethod.SetItems(dctInputMissingMethod)

        ucrNudMaxMissingData.SetParameter(New RParameter("x", bNewIncludeArgumentName:=False))
        ucrNudMaxMissingData.SetMinMax(1, 99)

        ucrNudMaxMissingDays.SetParameter(New RParameter("y", bNewIncludeArgumentName:=False))
        ucrNudMaxMissingDays.SetMinMax(1, 99)

        ucrNudMaxDurationMissingData.SetParameter(New RParameter("z", bNewIncludeArgumentName:=False))
        ucrNudMaxDurationMissingData.SetMinMax(1, 99)

        'ucrSave Date Column
        ucrNewColName.SetPrefix("Evapotranspiration")
        ucrNewColName.SetLabelText("New Column Name:")
        ucrNewColName.SetDataFrameSelector(ucrSelectorEvapotranspiration.ucrAvailableDataFrames)
        ucrNewColName.SetIsComboBox()
        ucrNewColName.SetSaveTypeAsColumn()
        ucrNewColName.SetAssignToBooleans(bTempAssignToIsPrefix:=True)

        'panel setting
        ucrPnlMethod.AddRadioButton(rdoPenmanMonteith)
        ucrPnlMethod.AddRadioButton(rdoHargreavesSamani)
        ucrPnlMethod.AddFunctionNamesCondition(rdoPenmanMonteith, "ET.PenmanMonteith")
        ucrPnlMethod.AddFunctionNamesCondition(rdoHargreavesSamani, "ET.HargreavesSamani")

        ucrPnlMethod.AddToLinkedControls(ucrInputCrop, {rdoPenmanMonteith}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=Chr(34) & "short" & Chr(34))
        ucrPnlMethod.AddToLinkedControls(ucrReceiverHumidityMax, {rdoPenmanMonteith}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPnlMethod.AddToLinkedControls(ucrReceiverHumidityMin, {rdoPenmanMonteith}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPnlMethod.AddToLinkedControls(ucrInputTimeStep, {rdoPenmanMonteith, rdoHargreavesSamani}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=Chr(34) & "daily" & Chr(34))
        'ucrPnlMethod.AddToLinkedControls(ucrPnlSolar, {rdoPenmanMonteith}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlSolar.AddToLinkedControls(ucrReceiverRadiation, {rdoPenmanMonteith}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        'ucrPnlSolar.AddToLinkedControls(ucrInputSolar, {rdoPenmanMonteith}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=Chr(34) & "sunshine hours" & Chr(34))
        'ucrPnlSolar.SetLinkedDisplayControl(grpSolar)
        ucrReceiverRadiation.SetLinkedDisplayControl(lblRadiation)
        ucrPnlMethod.AddToLinkedControls(ucrPnlWindSpeed, {rdoPenmanMonteith}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlWindSpeed.AddToLinkedControls(ucrReceiverWindSpeed, {rdoPenmanMonteith}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPnlWindSpeed.AddToLinkedControls(ucrChkWind, {rdoPenmanMonteith}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=True)
        ucrPnlWindSpeed.SetLinkedDisplayControl(grpWindSpeed)

    End Sub

    Private Sub SetDefaults()
        clsETPenmanMonteith = New RFunction
        clsHargreavesSamani = New RFunction
        clsDataFunctionPM = New RFunction
        clsDataFunctionHS = New RFunction
        clsDailyOperatorPM = New ROperator
        clsDailyOperatorHS = New ROperator
        clsReadInputs = New RFunction
        clsDayFunc = New RFunction
        clsMonthFunc = New RFunction
        clsYearFunc = New RFunction

        ucrSelectorEvapotranspiration.Reset()
        ucrReceiverDate.SetMeAsReceiver()

        ucrInputMissingMethod.SetName("monthly average")
        ucrInputTimeStep.SetName("daily")
        ucrInputSolar.SetName("sunshine hours")
        ucrInputCrop.SetName("short")

        ucrNewColName.Reset()

        ChkInterpMissingData()

        clsDataFunctionPM.SetRCommand("data.frame")
        clsDataFunctionHS.SetRCommand("data.frame")

        clsDayFunc.SetRCommand("day")
        clsDayFunc.SetPackageName("lubridate")

        clsMonthFunc.SetRCommand("month")
        clsMonthFunc.SetPackageName("lubridate")

        clsYearFunc.SetRCommand("year")
        clsYearFunc.SetPackageName("lubridate")

        'clsLibraryEvap.SetRCommand("library")
        'clsLibraryEvap.AddParameter("Evapotranspiration", "Evapotranspiration", bIncludeArgumentName:=False)
        'ucrBase.clsRsyntax.AddToBeforeCodes(clsLibraryEvap, iPosition:=0)

        clsDataFunction.SetRCommand("data")
        clsDataFunction.AddParameter("constants", Chr(34) & "constants" & Chr(34), bIncludeArgumentName:=False)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsDataFunction, iPosition:=1)

        clsReadInputs.SetPackageName("Evapotranspiration")
        clsReadInputs.SetRCommand("ReadInputs")
        clsReadInputs.AddParameter("constants", "constants", iPosition:=2, bIncludeArgumentName:=False)
        clsReadInputs.AddParameter("stopmissing", clsRFunctionParameter:=clsMissingDataVector, iPosition:=3)
        clsReadInputs.AddParameter("timestep", Chr(34) & "daily" & Chr(34), iPosition:=4)
        clsReadInputs.AddParameter("interp_missing_days", "FALSE", iPosition:=5)
        clsReadInputs.AddParameter("interp_missing_entries", "FALSE", iPosition:=6)
        clsReadInputs.AddParameter("interp_abnormal", "FALSE", iPosition:=7)
        clsReadInputs.AddParameter("missing_method", "NULL", iPosition:=8)
        clsReadInputs.AddParameter("abnormal_method", "NULL", iPosition:=9)
        clsReadInputs.AddParameter("varnames", clsRFunctionParameter:=clsVarnamesVectorPM, iPosition:=0)
        clsReadInputs.AddParameter("climatedata", clsRFunctionParameter:=clsDataFunctionPM, iPosition:=1)
        clsReadInputs.SetAssignTo("temp_data")

        clsDataFunctionPM.AddParameter("Year", clsRFunctionParameter:=clsYearFunc)
        clsDataFunctionPM.AddParameter("Month", clsRFunctionParameter:=clsMonthFunc)
        clsDataFunctionPM.AddParameter("Day", clsRFunctionParameter:=clsDayFunc)

        clsVarnamesVectorPM.SetRCommand("c")
        clsVarnamesVectorPM.AddParameter("Tmax", Chr(34) & "Tmax" & Chr(34), bIncludeArgumentName:=False)
        clsVarnamesVectorPM.AddParameter("Tmin", Chr(34) & "Tmin" & Chr(34), bIncludeArgumentName:=False)
        clsVarnamesVectorPM.AddParameter("RHmax", Chr(34) & "RHmax" & Chr(34), bIncludeArgumentName:=False)
        clsVarnamesVectorPM.AddParameter("RHmin", Chr(34) & "RHmin" & Chr(34), bIncludeArgumentName:=False)
        clsVarnamesVectorPM.AddParameter("n", Chr(34) & "n" & Chr(34), bIncludeArgumentName:=False)
        clsVarnamesVectorPM.AddParameter("u2", Chr(34) & "u2" & Chr(34), bIncludeArgumentName:=False)

        clsVarnamesVectorHS.SetRCommand("c")
        clsVarnamesVectorHS.AddParameter("Tmax", Chr(34) & "Tmax" & Chr(34), bIncludeArgumentName:=False)
        clsVarnamesVectorHS.AddParameter("Tmin", Chr(34) & "Tmin" & Chr(34), bIncludeArgumentName:=False)

        clsMissingDataVector.SetRCommand("c")
        clsVector.SetRCommand("c")

        clsETPenmanMonteith.SetPackageName("Evapotranspiration")
        clsHargreavesSamani.SetPackageName("Evapotranspiration")

        clsETPenmanMonteith.SetRCommand("ET.PenmanMonteith")
        clsETPenmanMonteith.AddParameter("data", clsRFunctionParameter:=clsReadInputs, iPosition:=0)
        clsETPenmanMonteith.AddParameter("constants", "constants", iPosition:=1, bIncludeArgumentName:=False)
        clsETPenmanMonteith.SetAssignTo("Penman_Monteith")
        clsETPenmanMonteith.AddParameter("ts", Chr(34) & "daily" & Chr(34), iPosition:=2)
        clsETPenmanMonteith.AddParameter("save.csv", Chr(34) & "no" & Chr(34))

        clsHargreavesSamani.SetRCommand("ET.HargreavesSamani")
        clsHargreavesSamani.AddParameter("data", clsRFunctionParameter:=clsReadInputs, iPosition:=0)
        clsHargreavesSamani.AddParameter("constants", "constants", iPosition:=1, bIncludeArgumentName:=False)
        clsHargreavesSamani.SetAssignTo("Hargreaves_Samani")
        clsHargreavesSamani.AddParameter("ts", Chr(34) & "daily" & Chr(34), iPosition:=2)
        clsHargreavesSamani.AddParameter("save.csv", Chr(34) & "no" & Chr(34))

        clsDailyOperatorPM.SetOperation("$")
        clsDailyOperatorPM.AddParameter("ET.PenmanMonteith", clsRFunctionParameter:=clsETPenmanMonteith, iPosition:=0)
        clsDailyOperatorPM.AddParameter("ET.Daily", strParameterValue:="ET.Daily", iPosition:=1)

        clsDailyOperatorHS.SetOperation("$")
        clsDailyOperatorHS.AddParameter("ET.HargreavesSamani", clsRFunctionParameter:=clsHargreavesSamani, iPosition:=0)
        clsDailyOperatorHS.AddParameter("ET.Daily", strParameterValue:="ET.Daily", iPosition:=1)

        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColName.GetText, strTempDataframe:=ucrSelectorEvapotranspiration.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColName.GetText)
        ucrBase.clsRsyntax.SetBaseROperator(clsDailyOperatorPM)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverDate.AddAdditionalCodeParameterPair(clsMonthFunc, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverDate.AddAdditionalCodeParameterPair(clsYearFunc, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrReceiverTmax.AddAdditionalCodeParameterPair(clsDataFunctionHS, New RParameter("Tmax", 3), iAdditionalPairNo:=1)
        ucrReceiverTmin.AddAdditionalCodeParameterPair(clsDataFunctionHS, New RParameter("Tmin", 4), iAdditionalPairNo:=1)
        ucrInputTimeStep.AddAdditionalCodeParameterPair(clsHargreavesSamani, New RParameter("ts", 2), iAdditionalPairNo:=1)

        ucrPnlMethod.SetRCode(ucrBase.clsRsyntax.clsBaseOperator, bReset)
        ucrReceiverDate.SetRCode(clsDayFunc, bReset)
        ucrReceiverTmax.SetRCode(clsDataFunctionPM, bReset)
        ucrReceiverTmin.SetRCode(clsDataFunctionPM, bReset)
        ucrReceiverHumidityMax.SetRCode(clsDataFunctionPM, bReset)
        ucrReceiverHumidityMin.SetRCode(clsDataFunctionPM, bReset)
        ucrReceiverRadiation.SetRCode(clsDataFunctionPM, bReset)
        ucrReceiverWindSpeed.SetRCode(clsDataFunctionPM, bReset)
        ucrInputTimeStep.SetRCode(clsETPenmanMonteith, bReset)
        ucrInputSolar.SetRCode(clsETPenmanMonteith, bReset)
        ucrInputCrop.SetRCode(clsETPenmanMonteith, bReset)
        ucrChkWind.SetRCode(clsETPenmanMonteith, bReset)
        ucrNewColName.SetRCode(ucrBase.clsRsyntax.clsBaseOperator, bReset)
        ucrNudMaxMissingData.SetRCode(clsMissingDataVector, bReset)
        ucrNudMaxMissingDays.SetRCode(clsMissingDataVector, bReset)
        ucrNudMaxDurationMissingData.SetRCode(clsMissingDataVector, bReset)
        ucrChkInterpMissingDays.SetRCode(clsReadInputs, bReset)
        ucrChkInterpMissingEntries.SetRCode(clsReadInputs, bReset)
        ucrInputMissingMethod.SetRCode(clsReadInputs, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If rdoPenmanMonteith.Checked And ucrChkWind.Checked Then
            If ucrNewColName.IsComplete AndAlso Not ucrReceiverDate.IsEmpty() AndAlso Not ucrReceiverTmax.IsEmpty() AndAlso Not ucrReceiverTmin.IsEmpty() AndAlso Not ucrReceiverHumidityMax.IsEmpty() AndAlso Not ucrReceiverHumidityMin.IsEmpty() AndAlso Not ucrReceiverRadiation.IsEmpty() AndAlso Not ucrReceiverWindSpeed.IsEmpty AndAlso Not ucrInputTimeStep.IsEmpty AndAlso Not ucrInputSolar.IsEmpty AndAlso Not ucrInputCrop.IsEmpty AndAlso ucrNudMaxMissingData.GetText <> "" AndAlso ucrNudMaxMissingDays.GetText <> "" AndAlso ucrNudMaxDurationMissingData.GetText <> "" Then
                ucrBase.OKEnabled(True)
            End If
        ElseIf rdoPenmanMonteith.Checked And Not ucrChkWind.Checked Then
            If ucrNewColName.IsComplete AndAlso Not ucrReceiverDate.IsEmpty() AndAlso Not ucrReceiverTmax.IsEmpty() AndAlso Not ucrReceiverTmin.IsEmpty() AndAlso Not ucrReceiverHumidityMax.IsEmpty() AndAlso Not ucrReceiverHumidityMin.IsEmpty() AndAlso Not ucrReceiverRadiation.IsEmpty() AndAlso Not ucrInputTimeStep.IsEmpty AndAlso Not ucrInputSolar.IsEmpty AndAlso Not ucrInputCrop.IsEmpty AndAlso ucrNudMaxMissingData.GetText <> "" AndAlso ucrNudMaxMissingDays.GetText <> "" AndAlso ucrNudMaxDurationMissingData.GetText <> "" Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoHargreavesSamani.Checked Then
            If ucrNewColName.IsComplete AndAlso Not ucrReceiverDate.IsEmpty() AndAlso Not ucrReceiverTmax.IsEmpty() AndAlso Not ucrReceiverTmin.IsEmpty() AndAlso Not ucrInputTimeStep.IsEmpty() AndAlso ucrNudMaxMissingData.GetText <> "" AndAlso ucrNudMaxMissingDays.GetText <> "" AndAlso ucrNudMaxDurationMissingData.GetText <> "" Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        SetBase()
    End Sub

    Private Sub Method()
        If rdoPenmanMonteith.Checked Then
            clsReadInputs.AddParameter("varnames", clsRFunctionParameter:=clsVarnamesVectorPM, iPosition:=0)
            clsReadInputs.AddParameter("climatedata", clsRFunctionParameter:=clsDataFunctionPM, iPosition:=1)
            clsDataFunctionPM.AddParameter("Year", clsRFunctionParameter:=clsYearFunc)
            clsDataFunctionPM.AddParameter("Month", clsRFunctionParameter:=clsMonthFunc)
            clsDataFunctionPM.AddParameter("Day", clsRFunctionParameter:=clsDayFunc)
        ElseIf rdoHargreavesSamani.Checked Then
            clsReadInputs.AddParameter("varnames", clsRFunctionParameter:=clsVarnamesVectorHS, iPosition:=0)
            clsReadInputs.AddParameter("climatedata", clsRFunctionParameter:=clsDataFunctionHS, iPosition:=1)
            clsDataFunctionHS.AddParameter("Year", clsRFunctionParameter:=clsYearFunc)
            clsDataFunctionHS.AddParameter("Month", clsRFunctionParameter:=clsMonthFunc)
            clsDataFunctionHS.AddParameter("Day", clsRFunctionParameter:=clsDayFunc)
        End If
    End Sub

    Private Sub SolarOptions()
        Select Case ucrInputSolar.GetText
            Case "sunshine hours"
                ucrReceiverRadiation.SetParameter(New RParameter("n", 6))
                ucrReceiverRadiation.SetParameterIsRFunction()
                ucrReceiverRadiation.SetClimaticType("sunshine_hours")
                ucrReceiverRadiation.bAutoFill = True
                ' lblRadiation.Visible = False
                lblSunshineHrs.Visible = True
                lblCloudCover.Visible = False
                clsVarnamesVectorPM.AddParameter("n", Chr(34) & "n" & Chr(34), bIncludeArgumentName:=False)
                clsVarnamesVectorPM.RemoveParameterByName("Rs")
                clsVarnamesVectorPM.RemoveParameterByName("Cd")
            Case "data"
                ucrReceiverRadiation.SetParameter(New RParameter("Rs", 6))
                ucrReceiverRadiation.SetParameterIsRFunction()
                ucrReceiverRadiation.SetClimaticType("radiation")
                ucrReceiverRadiation.bAutoFill = True
                ' lblRadiation.Visible = True
                lblSunshineHrs.Visible = False
                lblCloudCover.Visible = False
                clsVarnamesVectorPM.AddParameter("Rs", Chr(34) & "Rs" & Chr(34), bIncludeArgumentName:=False)
                clsVarnamesVectorPM.RemoveParameterByName("n")
                clsVarnamesVectorPM.RemoveParameterByName("Cd")
            Case "cloud"
                ucrReceiverRadiation.SetParameter(New RParameter("Cd", 6))
                ucrReceiverRadiation.SetParameterIsRFunction()
                ucrReceiverRadiation.SetClimaticType("cloud_cover")
                ucrReceiverRadiation.bAutoFill = True
                'lblRadiation.Visible = False
                lblSunshineHrs.Visible = False
                lblCloudCover.Visible = True
                clsVarnamesVectorPM.AddParameter("Cd", Chr(34) & "Cd" & Chr(34), bIncludeArgumentName:=False)
                clsVarnamesVectorPM.RemoveParameterByName("n")
                clsVarnamesVectorPM.RemoveParameterByName("Rs")
        End Select
    End Sub

    Private Sub ChkInterpMissingData()
        If ucrChkInterpMissingDays.Checked AndAlso ucrChkInterpMissingEntries.Checked Then
            ucrInputMissingMethod.Visible = True
        Else
            ucrInputMissingMethod.Visible = False
            clsReadInputs.AddParameter("missing_method", "NULL")
        End If
    End Sub

    Private Sub WindSpeed()
        If ucrChkWind.Checked Then
            ucrReceiverWindSpeed.Visible = True
            clsVarnamesVectorPM.AddParameter("u2", Chr(34) & "u2" & Chr(34), bIncludeArgumentName:=False)
        Else
            ucrReceiverWindSpeed.Visible = False
            clsVarnamesVectorPM.RemoveParameterByName("u2")
        End If
    End Sub

    Private Sub SetBase()
        If rdoPenmanMonteith.Checked Then
            ucrBase.clsRsyntax.SetBaseROperator(clsDailyOperatorPM)
        ElseIf rdoHargreavesSamani.Checked Then
            ucrBase.clsRsyntax.SetBaseROperator(clsDailyOperatorHS)
        End If
    End Sub

    Private Sub ucrPnlMethod_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlMethod.ControlContentsChanged
        Method()
        SetBase()
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlSolar_ControlContentsChanged(ucrChangedControl As ucrCore)
        SolarOptions()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverTmax_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverHumidityMin.ControlValueChanged, ucrReceiverHumidityMax.ControlValueChanged, ucrReceiverTmin.ControlValueChanged, ucrReceiverTmax.ControlValueChanged, ucrReceiverDate.ControlValueChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverWindSpeed_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverWindSpeed.ControlValueChanged
        WindSpeed()
        TestOKEnabled()
    End Sub

    Private Sub UcrInputSolar_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSolar.ControlValueChanged, ucrReceiverRadiation.ControlValueChanged
        SolarOptions()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputTimeStep_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputTimeStep.ControlValueChanged, ucrInputSolar.ControlValueChanged, ucrInputCrop.ControlValueChanged, ucrInputSolar.ControlValueChanged, ucrInputMissingMethod.ControlValueChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrNudMaxMissingData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudMaxMissingData.ControlValueChanged, ucrNudMaxDurationMissingData.ControlValueChanged, ucrNudMaxMissingDays.ControlValueChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrNewColName_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewColName.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkInterpMissingDays_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkInterpMissingDays.ControlContentsChanged, ucrChkInterpMissingEntries.ControlContentsChanged
        ChkInterpMissingData()
    End Sub

    Private Sub UcrChkWind_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkWind.ControlContentsChanged
        WindSpeed()
    End Sub
End Class

