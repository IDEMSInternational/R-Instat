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
    Private iBasicHeight As Integer
    Private iBaseMaxY As Integer
    Private iSaveMaxY As Integer
    Private clsETPenmanMonteith, clsHargreavesSamani, clsDataFunctionPM, clsDataFunctionHS, clsDataFunction, clsReadInputs, clsVector, clsMissingDataVector, clsVarnamesVectorPM, clsVarnamesVectorHS, clsLibraryEvap As New RFunction
    Private clsDayFunc, clsMonthFunc, clsYearFunc As New RFunction
    Private clsBaseOperator, clsDailyOperatorHS As New ROperator

    Private Sub dlgdlgEvapotranspiration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            iBasicHeight = Me.Height
            iBaseMaxY = ucrBase.Location.Y
            iSaveMaxY = ucrNewColName.Location.Y
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        DialogSize()
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 565
        ucrBase.clsRsyntax.iCallType = 2

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
        'ucrReceiverHumidityMax.bAutoFill = True

        ucrReceiverHumidityMin.SetParameter(New RParameter("RHmin", 5))
        ucrReceiverHumidityMin.SetParameterIsRFunction()
        'ucrReceiverHumidityMin.bAutoFill = True

        ucrReceiverWindSpeed.SetParameter(New RParameter("u2", 7))
        ucrReceiverWindSpeed.SetParameterIsRFunction()
        'ucrReceiverWindSpeed.SetClimaticType("wind_speed")
        'ucrReceiverWindSpeed.bAutoFill = True

        ucrInputTimeStep.SetParameter(New RParameter("ts", 2))
        dctInputTimeStep.Add("daily", Chr(34) & "daily" & Chr(34))
        dctInputTimeStep.Add("monthly", Chr(34) & "monthly" & Chr(34))
        dctInputTimeStep.Add("annual", Chr(34) & "annual" & Chr(34))
        ucrInputTimeStep.SetItems(dctInputTimeStep)
        ucrInputTimeStep.SetDropDownStyleAsNonEditable()

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

        ucrChkWind.SetParameter(New RParameter("wind", 4))
        ucrChkWind.SetText("Wind Speed")
        ucrChkWind.SetValuesCheckedAndUnchecked(Chr(34) & "yes" & Chr(34), Chr(34) & "no" & Chr(34))
        ucrChkWind.SetRDefault(Chr(34) & "yes" & Chr(34))

        ' Missing Options 
        ucrChkInterpMissingDays.SetParameter(New RParameter("interp_missing_days", 5))
        ucrChkInterpMissingDays.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkInterpMissingDays.SetRDefault("FALSE")
        ucrChkInterpMissingDays.SetText("Interpolate Missing Days")

        ucrChkInterpMissingEntries.SetParameter(New RParameter("interp_missing_entries", 6))
        ucrChkInterpMissingEntries.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkInterpMissingEntries.SetRDefault("FALSE")
        ucrChkInterpMissingEntries.SetText("Interpolate Missing Entries")

        ucrInputMissingMethod.SetParameter(New RParameter("missing_method", 8))
        dctInputMissingMethod.Add("monthly average", Chr(34) & "monthly average" & Chr(34))
        dctInputMissingMethod.Add("seasonal average", Chr(34) & "seasonal average" & Chr(34))
        dctInputMissingMethod.Add("DoY average", Chr(34) & "DoY average" & Chr(34))
        dctInputMissingMethod.Add("neighbouring average", Chr(34) & "neighbouring average" & Chr(34))
        ucrInputMissingMethod.SetItems(dctInputMissingMethod)
        ucrInputMissingMethod.SetDropDownStyleAsNonEditable()

        ucrNudMaxMissingData.SetParameter(New RParameter("x", bNewIncludeArgumentName:=False))
        ucrNudMaxMissingData.SetMinMax(1, 99)

        ucrNudMaxMissingDays.SetParameter(New RParameter("y", bNewIncludeArgumentName:=False))
        ucrNudMaxMissingDays.SetMinMax(1, 99)

        ucrNudMaxDurationMissingData.SetParameter(New RParameter("z", bNewIncludeArgumentName:=False))
        ucrNudMaxDurationMissingData.SetMinMax(1, 99)

        'panel setting
        ucrPnlMethod.AddRadioButton(rdoPenmanMonteith)
        ucrPnlMethod.AddRadioButton(rdoHargreavesSamani)
        ucrPnlMethod.AddParameterValueFunctionNamesCondition(rdoPenmanMonteith, "ET.PenmanMonteith", "ET.PenmanMonteith")
        ucrPnlMethod.AddParameterValueFunctionNamesCondition(rdoHargreavesSamani, "ET.HargreavesSamani", "ET.HargreavesSamani")

        ucrPnlMethod.AddToLinkedControls(ucrInputCrop, {rdoPenmanMonteith}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethod.AddToLinkedControls(ucrReceiverHumidityMax, {rdoPenmanMonteith}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPnlMethod.AddToLinkedControls(ucrReceiverHumidityMin, {rdoPenmanMonteith}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPnlMethod.AddToLinkedControls(ucrInputTimeStep, {rdoPenmanMonteith, rdoHargreavesSamani}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkWind.AddToLinkedControls(ucrReceiverWindSpeed, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethod.AddToLinkedControls(ucrReceiverRadiation, {rdoPenmanMonteith}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethod.AddToLinkedControls(ucrChkWind, {rdoPenmanMonteith}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethod.AddToLinkedControls(ucrInputSolar, {rdoPenmanMonteith}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethod.AddToLinkedControls(ucrInputMissingMethod, {rdoPenmanMonteith}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="monthly average")

        ucrChkWind.SetLinkedDisplayControl(grpWindSpeed)
        ucrReceiverRadiation.SetLinkedDisplayControl(lblRadiation)
        ucrReceiverHumidityMax.SetLinkedDisplayControl(lblHumidityMax)
        ucrReceiverHumidityMin.SetLinkedDisplayControl(lblHumidityMin)
        ucrInputTimeStep.SetLinkedDisplayControl(lblTimeStep)
        ucrInputSolar.SetLinkedDisplayControl(lblSolar)
        ucrInputMissingMethod.SetLinkedDisplayControl(lblMissingMethod)
        ucrInputCrop.SetLinkedDisplayControl(lblCrop)

        'ucrSave Column
        ucrNewColName.SetLabelText("New Column Name:")
        ucrNewColName.SetDataFrameSelector(ucrSelectorEvapotranspiration.ucrAvailableDataFrames)
        ucrNewColName.SetIsComboBox()
        ucrNewColName.SetSaveTypeAsColumn()
        ucrNewColName.SetPrefix("evapotranspiration")
    End Sub

    Private Sub SetDefaults()
        clsETPenmanMonteith = New RFunction
        clsHargreavesSamani = New RFunction
        clsDataFunctionPM = New RFunction
        clsDataFunctionHS = New RFunction
        clsBaseOperator = New ROperator
        clsDailyOperatorHS = New ROperator
        clsReadInputs = New RFunction
        clsDayFunc = New RFunction
        clsMonthFunc = New RFunction
        clsYearFunc = New RFunction
        clsLibraryEvap = New RFunction

        ucrSelectorEvapotranspiration.Reset()
        ucrReceiverHumidityMax.SetMeAsReceiver()
        ucrNewColName.Reset()

        clsLibraryEvap.SetRCommand("library")
        clsLibraryEvap.AddParameter("Evapotranspiration", "Evapotranspiration", bIncludeArgumentName:=False)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsLibraryEvap, iPosition:=0)

        clsDataFunctionPM.SetRCommand("data.frame")
        clsDataFunctionPM.AddParameter("Year", clsRFunctionParameter:=clsYearFunc)
        clsDataFunctionPM.AddParameter("Month", clsRFunctionParameter:=clsMonthFunc)
        clsDataFunctionPM.AddParameter("Day", clsRFunctionParameter:=clsDayFunc)

        clsDataFunctionHS.SetRCommand("data.frame")
        clsDataFunctionHS.AddParameter("Year", clsRFunctionParameter:=clsYearFunc)
        clsDataFunctionHS.AddParameter("Month", clsRFunctionParameter:=clsMonthFunc)
        clsDataFunctionHS.AddParameter("Day", clsRFunctionParameter:=clsDayFunc)

        clsDayFunc.SetRCommand("day")
        clsDayFunc.SetPackageName("lubridate")

        clsMonthFunc.SetRCommand("month")
        clsMonthFunc.SetPackageName("lubridate")

        clsYearFunc.SetRCommand("year")
        clsYearFunc.SetPackageName("lubridate")

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
        clsReadInputs.AddParameter("abnormal_method", "NULL", iPosition:=9)
        clsReadInputs.AddParameter("varnames", clsRFunctionParameter:=clsVarnamesVectorPM, iPosition:=0)
        clsReadInputs.AddParameter("climatedata", clsRFunctionParameter:=clsDataFunctionPM, iPosition:=1)
        clsReadInputs.SetAssignTo("temp_data")

        clsVarnamesVectorPM.SetRCommand("c")
        clsVarnamesVectorPM.AddParameter("Tmax", Chr(34) & "Tmax" & Chr(34), bIncludeArgumentName:=False)
        clsVarnamesVectorPM.AddParameter("Tmin", Chr(34) & "Tmin" & Chr(34), bIncludeArgumentName:=False)
        clsVarnamesVectorPM.AddParameter("RHmax", Chr(34) & "RHmax" & Chr(34), bIncludeArgumentName:=False)
        clsVarnamesVectorPM.AddParameter("RHmin", Chr(34) & "RHmin" & Chr(34), bIncludeArgumentName:=False)
        'clsVarnamesVectorPM.AddParameter("n", Chr(34) & "n" & Chr(34), bIncludeArgumentName:=False)


        clsVarnamesVectorHS.SetRCommand("c")
        clsVarnamesVectorHS.AddParameter("Tmax", Chr(34) & "Tmax" & Chr(34), bIncludeArgumentName:=False)
        clsVarnamesVectorHS.AddParameter("Tmin", Chr(34) & "Tmin" & Chr(34), bIncludeArgumentName:=False)

        clsMissingDataVector.SetRCommand("c")
        clsMissingDataVector.AddParameter("x", 1, bIncludeArgumentName:=False)
        clsMissingDataVector.AddParameter("y", 1, bIncludeArgumentName:=False)
        clsMissingDataVector.AddParameter("z", 1, bIncludeArgumentName:=False)

        clsVector.SetRCommand("c")

        clsETPenmanMonteith.SetPackageName("Evapotranspiration")
        clsETPenmanMonteith.SetRCommand("ET.PenmanMonteith")
        clsETPenmanMonteith.AddParameter("data", clsRFunctionParameter:=clsReadInputs, iPosition:=0)
        clsETPenmanMonteith.AddParameter("constants", "constants", iPosition:=1, bIncludeArgumentName:=False)
        clsETPenmanMonteith.AddParameter("ts", Chr(34) & "daily" & Chr(34), iPosition:=2)
        clsETPenmanMonteith.AddParameter("message", Chr(34) & "yes" & Chr(34), iPosition:=3)
        clsETPenmanMonteith.AddParameter("crops", Chr(34) & "short" & Chr(34), iPosition:=4)
        clsETPenmanMonteith.AddParameter("save.csv", Chr(34) & "no" & Chr(34), iPosition:=5)
        clsETPenmanMonteith.SetAssignTo("Penman_Monteith")

        clsHargreavesSamani.SetPackageName("Evapotranspiration")
        clsHargreavesSamani.SetRCommand("ET.HargreavesSamani")
        clsHargreavesSamani.AddParameter("data", clsRFunctionParameter:=clsReadInputs, iPosition:=0)
        clsHargreavesSamani.AddParameter("constants", "constants", iPosition:=1, bIncludeArgumentName:=False)
        clsHargreavesSamani.AddParameter("ts", Chr(34) & "daily" & Chr(34), iPosition:=2)
        clsHargreavesSamani.AddParameter("message", Chr(34) & "yes" & Chr(34), iPosition:=3)
        clsHargreavesSamani.AddParameter("save.csv", Chr(34) & "no" & Chr(34), iPosition:=4)
        clsHargreavesSamani.SetAssignTo("Hargreaves_Samani")

        clsBaseOperator.SetOperation("$")
        clsBaseOperator.AddParameter("ET.PenmanMonteith", clsRFunctionParameter:=clsETPenmanMonteith, iPosition:=0)
        clsBaseOperator.AddParameter("ET.Daily", strParameterValue:="ET.Daily", iPosition:=1)

        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColName.GetText, strTempDataframe:=ucrSelectorEvapotranspiration.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColName.GetText)
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverDate.AddAdditionalCodeParameterPair(clsMonthFunc, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverDate.AddAdditionalCodeParameterPair(clsYearFunc, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrReceiverTmax.AddAdditionalCodeParameterPair(clsDataFunctionHS, New RParameter("Tmax", 3), iAdditionalPairNo:=1)
        ucrReceiverTmin.AddAdditionalCodeParameterPair(clsDataFunctionHS, New RParameter("Tmin", 4), iAdditionalPairNo:=1)
        ucrInputTimeStep.AddAdditionalCodeParameterPair(clsHargreavesSamani, New RParameter("ts", 2), iAdditionalPairNo:=1)

        ucrPnlMethod.SetRCode(clsBaseOperator, bReset)
        ucrReceiverDate.SetRCode(clsDayFunc, bReset)
        ucrReceiverTmax.SetRCode(clsDataFunctionPM, bReset)
        ucrReceiverTmin.SetRCode(clsDataFunctionPM, bReset)
        ucrReceiverHumidityMax.SetRCode(clsDataFunctionPM, bReset)
        ucrReceiverHumidityMin.SetRCode(clsDataFunctionPM, bReset)
        ucrReceiverWindSpeed.SetRCode(clsDataFunctionPM, bReset)
        ucrInputTimeStep.SetRCode(clsETPenmanMonteith, bReset)
        ucrInputSolar.SetRCode(clsETPenmanMonteith, bReset)
        ucrInputCrop.SetRCode(clsETPenmanMonteith, bReset)
        ucrChkWind.SetRCode(clsETPenmanMonteith, bReset)
        ucrNewColName.SetRCode(clsBaseOperator, bReset)
        ucrNudMaxMissingData.SetRCode(clsMissingDataVector, bReset)
        ucrNudMaxMissingDays.SetRCode(clsMissingDataVector, bReset)
        ucrNudMaxDurationMissingData.SetRCode(clsMissingDataVector, bReset)
        ucrChkInterpMissingDays.SetRCode(clsReadInputs, bReset)
        ucrChkInterpMissingEntries.SetRCode(clsReadInputs, bReset)
        ucrInputMissingMethod.SetRCode(clsReadInputs, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If rdoPenmanMonteith.Checked Then
            If ucrNewColName.IsComplete AndAlso Not ucrReceiverDate.IsEmpty() AndAlso Not ucrReceiverTmax.IsEmpty() AndAlso Not ucrReceiverTmin.IsEmpty() AndAlso Not ucrReceiverHumidityMax.IsEmpty() AndAlso Not ucrReceiverHumidityMin.IsEmpty() AndAlso Not ucrReceiverRadiation.IsEmpty() AndAlso Not ucrInputTimeStep.IsEmpty AndAlso ucrNudMaxMissingData.GetText <> "" AndAlso ucrNudMaxMissingDays.GetText <> "" AndAlso ucrNudMaxDurationMissingData.GetText <> "" Then
                ucrBase.OKEnabled(True)
            End If
            If ucrChkWind.Checked And ucrReceiverWindSpeed.IsEmpty Then
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoHargreavesSamani.Checked Then
            If ucrNewColName.IsComplete AndAlso Not ucrReceiverDate.IsEmpty() AndAlso Not ucrReceiverTmax.IsEmpty() AndAlso Not ucrReceiverTmin.IsEmpty() AndAlso Not ucrInputTimeStep.IsEmpty() AndAlso ucrNudMaxMissingData.GetText <> "" AndAlso ucrNudMaxMissingDays.GetText <> "" AndAlso ucrNudMaxDurationMissingData.GetText <> "" Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub DialogSize()
        If rdoPenmanMonteith.Checked Then
            Me.Size = New System.Drawing.Size(Me.Width, iBasicHeight)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY)
            ucrNewColName.Location = New Point(ucrNewColName.Location.X, iSaveMaxY)
        ElseIf rdoHargreavesSamani.Checked Then
            ucrReceiverDate.SetMeAsReceiver()
            Me.Size = New System.Drawing.Size(Me.Width, iBasicHeight * 0.9)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY / 1.15)
            ucrNewColName.Location = New Point(ucrNewColName.Location.X, iSaveMaxY / 1.183)
        End If
    End Sub

    Private Sub Method()
        If rdoPenmanMonteith.Checked Then
            clsReadInputs.AddParameter("varnames", clsRFunctionParameter:=clsVarnamesVectorPM, iPosition:=0)
            clsReadInputs.AddParameter("climatedata", clsRFunctionParameter:=clsDataFunctionPM, iPosition:=1)
        ElseIf rdoHargreavesSamani.Checked Then
            clsReadInputs.AddParameter("varnames", clsRFunctionParameter:=clsVarnamesVectorHS, iPosition:=0)
            clsReadInputs.AddParameter("climatedata", clsRFunctionParameter:=clsDataFunctionHS, iPosition:=1)
        End If
    End Sub

    Private Sub ucrPnlMethod_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMethod.ControlValueChanged
        Method()
        DialogSize()
        If rdoPenmanMonteith.Checked Then
            clsBaseOperator.AddParameter("ET.PenmanMonteith", clsRFunctionParameter:=clsETPenmanMonteith, iPosition:=0)
        Else
            clsBaseOperator.RemoveParameterByName("ET.PenmanMonteith")
        End If
        If rdoHargreavesSamani.Checked Then
            clsBaseOperator.AddParameter("ET.HargreavesSamani", clsRFunctionParameter:=clsHargreavesSamani, iPosition:=0)
        Else
            clsBaseOperator.RemoveParameterByName("ET.HargreavesSamani")
        End If

    End Sub

    Private Sub ucrReceiverWindSpeed_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverWindSpeed.ControlValueChanged, ucrChkWind.ControlValueChanged
        If ucrChkWind.Checked AndAlso Not ucrReceiverWindSpeed.IsEmpty Then
            clsVarnamesVectorPM.AddParameter("u2", Chr(34) & "u2" & Chr(34), bIncludeArgumentName:=False)
        Else
            clsVarnamesVectorPM.RemoveParameterByName("u2")
            ucrReceiverHumidityMax.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrInputSolar_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSolar.ControlValueChanged, ucrReceiverRadiation.ControlValueChanged
        Select Case ucrInputSolar.GetText
            Case "sunshine hours"
                ucrReceiverRadiation.SetClimaticType("sunshine_hours")
                ucrReceiverRadiation.bAutoFill = True
                clsVarnamesVectorPM.AddParameter("n", Chr(34) & "n" & Chr(34), bIncludeArgumentName:=False)
                clsDataFunctionPM.AddParameter("n", clsRFunctionParameter:=ucrReceiverRadiation.GetVariables(), iPosition:=6)
                clsVarnamesVectorPM.RemoveParameterByName("Rs")
                clsVarnamesVectorPM.RemoveParameterByName("Cd")
                clsDataFunctionPM.RemoveParameterByName("Rs")
                clsDataFunctionPM.RemoveParameterByName("cd")
            Case "data"
                ucrReceiverRadiation.SetClimaticType("radiation")
                ucrReceiverRadiation.bAutoFill = True
                clsVarnamesVectorPM.AddParameter("Rs", Chr(34) & "Rs" & Chr(34), bIncludeArgumentName:=False)
                clsDataFunctionPM.AddParameter("Rs", clsRFunctionParameter:=ucrReceiverRadiation.GetVariables(), iPosition:=6)
                clsVarnamesVectorPM.RemoveParameterByName("n")
                clsVarnamesVectorPM.RemoveParameterByName("Cd")
                clsDataFunctionPM.RemoveParameterByName("n")
                clsDataFunctionPM.RemoveParameterByName("cd")
            Case "cloud"
                ucrReceiverRadiation.SetClimaticType("cloud_cover")
                ucrReceiverRadiation.bAutoFill = True
                clsVarnamesVectorPM.AddParameter("Cd", Chr(34) & "Cd" & Chr(34), bIncludeArgumentName:=False)
                clsDataFunctionPM.AddParameter("Cd", clsRFunctionParameter:=ucrReceiverRadiation.GetVariables(), iPosition:=6)
                clsVarnamesVectorPM.RemoveParameterByName("n")
                clsVarnamesVectorPM.RemoveParameterByName("Rs")
                clsDataFunctionPM.RemoveParameterByName("n")
                clsDataFunctionPM.RemoveParameterByName("Rs")
        End Select
    End Sub

    Private Sub ucrPnlMethod_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlMethod.ControlContentsChanged, ucrNewColName.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverTmax.ControlContentsChanged, ucrReceiverTmin.ControlContentsChanged, ucrReceiverHumidityMax.ControlContentsChanged, ucrReceiverHumidityMin.ControlContentsChanged, ucrReceiverRadiation.ControlContentsChanged, ucrReceiverWindSpeed.ControlContentsChanged, ucrInputTimeStep.ControlContentsChanged, ucrNudMaxMissingData.ControlContentsChanged, ucrNudMaxDurationMissingData.ControlContentsChanged, ucrNudMaxMissingDays.ControlContentsChanged, ucrChkWind.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class

