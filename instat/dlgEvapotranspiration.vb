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
    Private bResetSubdialog As Boolean = True
    Private iBasicHeight As Integer
    Private iBaseMaxY As Integer
    Private iSaveMaxY As Integer
    Private iEvapOptions, iHSConstants, iLocation As Integer
    Private iHSMissingOptions As Integer
    Private clsETPenmanMonteithFunction, clsHargreavesSamaniFunction, clsListFunction, clsDataFunctionPMFunction, clsDataFunctionHSFunction, clsDataFunctionPTFunction, clsETPriestleyTaylorFunction, clsReadInputsFunction, clsVectorFunction, clsMissingDataVectorFunction, clsVarnamesVectorPTFunction, clsVarnamesVectorPMFunction, clsVarnamesVectorHSFunction, clsLibraryEvapFunction As New RFunction
    Private clsDayFuncFunction, clsMonthFuncFunction, clsYearFuncFunction As New RFunction
    Private clsBaseOperator As New ROperator

    Private Sub dlgEvapotranspiration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            iBasicHeight = Me.Height
            iBaseMaxY = ucrBase.Location.Y
            iSaveMaxY = ucrNewColName.Location.Y
            iEvapOptions = cmdEvapOptions.Location.Y
            iHSMissingOptions = cmdHSMissingOptions.Location.Y
            iHSConstants = cmdHSConstants.Location.Y
            iLocation = cmdLocation.Location.Y
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

        Dim dctInputCrops As New Dictionary(Of String, String)
        Dim dctInputTimeStep As New Dictionary(Of String, String)
        Dim dctInputSolar As New Dictionary(Of String, String)

        ucrReceiverDate.Selector = ucrSelectorEvapotranspiration
        ucrReceiverTmax.Selector = ucrSelectorEvapotranspiration
        ucrReceiverTmin.Selector = ucrSelectorEvapotranspiration
        ucrReceiverExtraRadiation.Selector = ucrSelectorEvapotranspiration
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

        ucrReceiverRadiation.SetParameter(New RParameter("radiation", 1))
        ucrReceiverRadiation.SetParameterIsRFunction()

        ucrReceiverTmin.SetParameter(New RParameter("Tmin", 3))
        ucrReceiverTmin.SetParameterIsRFunction()
        ucrReceiverTmin.SetClimaticType("temp_min")
        ucrReceiverTmin.bAutoFill = True

        ucrReceiverExtraRadiation.SetParameter(New RParameter("R_a", 4))
        ucrReceiverExtraRadiation.SetParameterIsRFunction()
        ucrReceiverExtraRadiation.SetClimaticType("R_a")

        ucrReceiverHumidityMax.SetParameter(New RParameter("RHmax", 4))
        ucrReceiverHumidityMax.SetParameterIsRFunction()
        ucrReceiverHumidityMax.SetClimaticType("hum_max")
        ucrReceiverHumidityMax.bAutoFill = True

        ucrReceiverHumidityMin.SetParameter(New RParameter("RHmin", 5))
        ucrReceiverHumidityMin.SetParameterIsRFunction()
        ucrReceiverHumidityMin.SetClimaticType("hum_min")
        ucrReceiverHumidityMin.bAutoFill = True

        ucrReceiverWindSpeed.SetParameter(New RParameter("u2", 7))
        ucrReceiverWindSpeed.SetParameterIsRFunction()
        ucrReceiverWindSpeed.SetClimaticType("wind_speed")
        ucrReceiverWindSpeed.bAutoFill = True

        ucrInputTimeStep.SetParameter(New RParameter("ts", 2))
        dctInputTimeStep.Add("daily", Chr(34) & "daily" & Chr(34))
        dctInputTimeStep.Add("monthly", Chr(34) & "monthly" & Chr(34))
        dctInputTimeStep.Add("annual", Chr(34) & "annual" & Chr(34))
        ucrInputTimeStep.SetItems(dctInputTimeStep)
        ucrInputTimeStep.SetDropDownStyleAsNonEditable()

        ucrInputSolar.SetParameter(New RParameter("solar", 3))
        dctInputSolar.Add("sunshine hours", Chr(34) & "sunshine hours" & Chr(34))
        dctInputSolar.Add("cloud", Chr(34) & "cloud" & Chr(34))
        dctInputSolar.Add("radiation", Chr(34) & "data" & Chr(34))
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

        ucrNudAlpha.SetParameter(New RParameter("alpha", 4))
        ucrNudAlpha.SetMinMax(0, 1)
        ucrNudAlpha.DecimalPlaces = 2
        ucrNudAlpha.Increment = 0.05
        ucrNudAlpha.SetLinkedDisplayControl(lblAlpha)

        'panel setting
        ucrPnlMethod.AddRadioButton(rdoPenmanMonteith)
        ucrPnlMethod.AddRadioButton(rdoHargreavesSamani)
        ucrPnlMethod.AddRadioButton(rdoPriestleyTaylor)
        ucrPnlMethod.AddParameterValueFunctionNamesCondition(rdoPenmanMonteith, "ET.PenmanMonteith", "ET.PenmanMonteith")
        ucrPnlMethod.AddParameterValueFunctionNamesCondition(rdoHargreavesSamani, "ET.HargreavesSamani", "ET.HargreavesSamani")
        ucrPnlMethod.AddParameterValueFunctionNamesCondition(rdoPriestleyTaylor, "ET.PriestleyTaylor", "ET.PriestleyTaylor")

        ucrPnlMethod.AddToLinkedControls(ucrInputCrop, {rdoPenmanMonteith}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethod.AddToLinkedControls({ucrReceiverHumidityMax, ucrReceiverHumidityMin}, {rdoPenmanMonteith, rdoPriestleyTaylor}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPnlMethod.AddToLinkedControls(ucrInputTimeStep, {rdoPenmanMonteith, rdoHargreavesSamani, rdoPriestleyTaylor}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkWind.AddToLinkedControls(ucrReceiverWindSpeed, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethod.AddToLinkedControls(ucrReceiverRadiation, {rdoPenmanMonteith, rdoPriestleyTaylor}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethod.AddToLinkedControls(ucrChkWind, {rdoPenmanMonteith}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethod.AddToLinkedControls(ucrInputSolar, {rdoPenmanMonteith, rdoPriestleyTaylor}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethod.AddToLinkedControls(ucrReceiverExtraRadiation, {rdoHargreavesSamani}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethod.AddToLinkedControls(ucrNudAlpha, {rdoPriestleyTaylor}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.23")

        ucrReceiverExtraRadiation.SetLinkedDisplayControl(lblRa)
        ucrReceiverRadiation.SetLinkedDisplayControl(lblRadiation)
        ucrReceiverHumidityMax.SetLinkedDisplayControl(lblHumidityMax)
        ucrReceiverHumidityMin.SetLinkedDisplayControl(lblHumidityMin)
        ucrInputTimeStep.SetLinkedDisplayControl(lblTimeStep)
        ucrInputSolar.SetLinkedDisplayControl(lblSolar)
        ucrInputCrop.SetLinkedDisplayControl(lblCrop)

        'ucrSave Column
        ucrNewColName.SetLabelText("New Column Name:")
        ucrNewColName.SetDataFrameSelector(ucrSelectorEvapotranspiration.ucrAvailableDataFrames)
        ucrNewColName.SetIsComboBox()
        ucrNewColName.SetSaveTypeAsColumn()
        ucrNewColName.SetPrefix("evapotranspiration")
    End Sub

    Private Sub SetDefaults()
        clsETPenmanMonteithFunction = New RFunction
        clsHargreavesSamaniFunction = New RFunction
        clsDataFunctionPMFunction = New RFunction
        clsDataFunctionHSFunction = New RFunction
        clsDataFunctionPTFunction = New RFunction
        clsETPriestleyTaylorFunction = New RFunction
        clsBaseOperator = New ROperator
        clsReadInputsFunction = New RFunction
        clsDayFuncFunction = New RFunction
        clsMonthFuncFunction = New RFunction
        clsYearFuncFunction = New RFunction
        clsLibraryEvapFunction = New RFunction
        clsListFunction = New RFunction

        ucrSelectorEvapotranspiration.Reset()
        ucrReceiverHumidityMax.SetMeAsReceiver()
        ucrNewColName.Reset()

        bResetSubdialog = True

        clsDataFunctionPMFunction.SetRCommand("data.frame")
        clsDataFunctionPMFunction.AddParameter("Year", clsRFunctionParameter:=clsYearFuncFunction)
        clsDataFunctionPMFunction.AddParameter("Month", clsRFunctionParameter:=clsMonthFuncFunction)
        clsDataFunctionPMFunction.AddParameter("Day", clsRFunctionParameter:=clsDayFuncFunction)

        clsDataFunctionHSFunction.SetRCommand("data.frame")
        clsDataFunctionHSFunction.AddParameter("Year", clsRFunctionParameter:=clsYearFuncFunction)
        clsDataFunctionHSFunction.AddParameter("Month", clsRFunctionParameter:=clsMonthFuncFunction)
        clsDataFunctionHSFunction.AddParameter("Day", clsRFunctionParameter:=clsDayFuncFunction)

        clsDataFunctionPTFunction.SetRCommand("data.frame")
        clsDataFunctionPTFunction.AddParameter("Year", clsRFunctionParameter:=clsYearFuncFunction)
        clsDataFunctionPTFunction.AddParameter("Month", clsRFunctionParameter:=clsMonthFuncFunction)
        clsDataFunctionPTFunction.AddParameter("Day", clsRFunctionParameter:=clsDayFuncFunction)

        clsDayFuncFunction.SetPackageName("lubridate")
        clsDayFuncFunction.SetRCommand("day")

        clsMonthFuncFunction.SetPackageName("lubridate")
        clsMonthFuncFunction.SetRCommand("month")

        clsYearFuncFunction.SetRCommand("year")
        clsYearFuncFunction.SetPackageName("lubridate")

        clsReadInputsFunction.SetPackageName("Evapotranspiration")
        clsReadInputsFunction.SetRCommand("ReadInputs")
        clsReadInputsFunction.AddParameter("constants", "constants", iPosition:=2)
        clsReadInputsFunction.AddParameter("stopmissing", clsRFunctionParameter:=clsMissingDataVectorFunction, iPosition:=3)
        clsReadInputsFunction.AddParameter("timestep", Chr(34) & "daily" & Chr(34), iPosition:=4)
        clsReadInputsFunction.AddParameter("interp_missing_days", "FALSE", iPosition:=5)
        clsReadInputsFunction.AddParameter("interp_missing_entries", "FALSE", iPosition:=6)
        clsReadInputsFunction.AddParameter("interp_abnormal", "FALSE", iPosition:=7)
        clsReadInputsFunction.AddParameter("abnormal_method", "NULL", iPosition:=9)
        clsReadInputsFunction.AddParameter("varnames", clsRFunctionParameter:=clsVarnamesVectorPMFunction, iPosition:=0)
        clsReadInputsFunction.AddParameter("climatedata", clsRFunctionParameter:=clsDataFunctionPMFunction, iPosition:=1)
        clsReadInputsFunction.AddParameter("missing_method", Chr(34) & "monthly average" & Chr(34), iPosition:=8)
        clsReadInputsFunction.SetAssignTo("temp_data")

        clsVarnamesVectorPTFunction.SetRCommand("c")
        clsVarnamesVectorPTFunction.AddParameter("Tmax", Chr(34) & "Tmax" & Chr(34), iPosition:=0)
        clsVarnamesVectorPTFunction.AddParameter("Tmin", Chr(34) & "Tmin" & Chr(34), iPosition:=1)
        clsVarnamesVectorPTFunction.AddParameter("RHmax", Chr(34) & "RHmax" & Chr(34), iPosition:=2)
        clsVarnamesVectorPTFunction.AddParameter("RHmin", Chr(34) & "RHmin" & Chr(34), iPosition:=3)

        clsVarnamesVectorPMFunction.SetRCommand("c")
        clsVarnamesVectorPMFunction.AddParameter("Tmax", Chr(34) & "Tmax" & Chr(34), bIncludeArgumentName:=False)
        clsVarnamesVectorPMFunction.AddParameter("Tmin", Chr(34) & "Tmin" & Chr(34), bIncludeArgumentName:=False)
        clsVarnamesVectorPMFunction.AddParameter("RHmax", Chr(34) & "RHmax" & Chr(34), bIncludeArgumentName:=False)
        clsVarnamesVectorPMFunction.AddParameter("RHmin", Chr(34) & "RHmin" & Chr(34), bIncludeArgumentName:=False)

        clsVarnamesVectorHSFunction.SetRCommand("c")
        clsVarnamesVectorHSFunction.AddParameter("Tmax", Chr(34) & "Tmax" & Chr(34), bIncludeArgumentName:=False)
        clsVarnamesVectorHSFunction.AddParameter("Tmin", Chr(34) & "Tmin" & Chr(34), bIncludeArgumentName:=False)

        clsMissingDataVectorFunction.SetRCommand("c")
        clsMissingDataVectorFunction.AddParameter("x", 1, bIncludeArgumentName:=False)
        clsMissingDataVectorFunction.AddParameter("y", 1, bIncludeArgumentName:=False)
        clsMissingDataVectorFunction.AddParameter("z", 1, bIncludeArgumentName:=False)

        clsVectorFunction.SetRCommand("c")

        clsListFunction.ClearParameters()
        clsListFunction.SetRCommand("list")
        clsListFunction.SetAssignTo("constants")

        clsETPenmanMonteithFunction.SetPackageName("Evapotranspiration")
        clsETPenmanMonteithFunction.SetRCommand("ET.PenmanMonteith")
        clsETPenmanMonteithFunction.AddParameter("data", clsRFunctionParameter:=clsReadInputsFunction, iPosition:=0)
        clsETPenmanMonteithFunction.AddParameter("constants", "constants", iPosition:=1)
        clsETPenmanMonteithFunction.AddParameter("ts", Chr(34) & "daily" & Chr(34), iPosition:=2)
        clsETPenmanMonteithFunction.AddParameter("solar", Chr(34) & "sunshine hours" & Chr(34), iPosition:=3)
        clsETPenmanMonteithFunction.AddParameter("message", Chr(34) & "yes" & Chr(34), iPosition:=4)
        clsETPenmanMonteithFunction.AddParameter("crops", Chr(34) & "short" & Chr(34), iPosition:=5)
        clsETPenmanMonteithFunction.AddParameter("save.csv", Chr(34) & "no" & Chr(34), iPosition:=6)
        clsETPenmanMonteithFunction.SetAssignTo("Penman_Monteith")

        clsHargreavesSamaniFunction.SetPackageName("Evapotranspiration")
        clsHargreavesSamaniFunction.SetRCommand("ET.HargreavesSamani")
        clsHargreavesSamaniFunction.AddParameter("data", clsRFunctionParameter:=clsReadInputsFunction, iPosition:=0)
        clsHargreavesSamaniFunction.AddParameter("constants", "constants", iPosition:=1)
        clsHargreavesSamaniFunction.AddParameter("ts", Chr(34) & "daily" & Chr(34), iPosition:=2)
        clsHargreavesSamaniFunction.AddParameter("message", Chr(34) & "yes" & Chr(34), iPosition:=3)
        clsHargreavesSamaniFunction.AddParameter("save.csv", Chr(34) & "no" & Chr(34), iPosition:=4)
        clsHargreavesSamaniFunction.SetAssignTo("Hargreaves_Samani")

        clsETPriestleyTaylorFunction.SetPackageName("Evapotranspiration")
        clsETPriestleyTaylorFunction.SetRCommand("ET.PriestleyTaylor")
        clsETPriestleyTaylorFunction.AddParameter("data", clsRFunctionParameter:=clsReadInputsFunction, iPosition:=0)
        clsETPriestleyTaylorFunction.AddParameter("constants", "constants", iPosition:=1, bIncludeArgumentName:=False)
        clsETPriestleyTaylorFunction.AddParameter("ts", Chr(34) & "daily" & Chr(34), iPosition:=2)
        clsETPriestleyTaylorFunction.AddParameter("message", Chr(34) & "yes" & Chr(34), iPosition:=3)
        clsETPriestleyTaylorFunction.AddParameter("alpha", 0.23, iPosition:=4)
        clsETPriestleyTaylorFunction.AddParameter("save.csv", Chr(34) & "no" & Chr(34), iPosition:=5)
        clsETPriestleyTaylorFunction.SetAssignTo("Priestley_Taylor")

        clsBaseOperator.SetOperation("$")
        clsBaseOperator.bSpaceAroundOperation = False
        clsBaseOperator.AddParameter("ET.PenmanMonteith", clsRFunctionParameter:=clsETPenmanMonteithFunction, iPosition:=0)
        clsBaseOperator.AddParameter("ET.Daily", strParameterValue:="ET.Daily", iPosition:=1)

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsListFunction, iPosition:=1)

        Constants()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverDate.AddAdditionalCodeParameterPair(clsMonthFuncFunction, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverDate.AddAdditionalCodeParameterPair(clsYearFuncFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrReceiverTmax.AddAdditionalCodeParameterPair(clsDataFunctionHSFunction, New RParameter("Tmax", 3), iAdditionalPairNo:=1)
        ucrReceiverTmin.AddAdditionalCodeParameterPair(clsDataFunctionHSFunction, New RParameter("Tmin", 4), iAdditionalPairNo:=1)
        ucrReceiverExtraRadiation.AddAdditionalCodeParameterPair(clsDataFunctionHSFunction, New RParameter("R_a", 6), iAdditionalPairNo:=1)
        ucrReceiverTmax.AddAdditionalCodeParameterPair(clsDataFunctionPTFunction, New RParameter("Tmax", 3), iAdditionalPairNo:=2)
        ucrReceiverTmin.AddAdditionalCodeParameterPair(clsDataFunctionPTFunction, New RParameter("Tmin", 4), iAdditionalPairNo:=2)
        ucrInputTimeStep.AddAdditionalCodeParameterPair(clsHargreavesSamaniFunction, New RParameter("ts", 2), iAdditionalPairNo:=1)
        ucrInputTimeStep.AddAdditionalCodeParameterPair(clsETPriestleyTaylorFunction, New RParameter("ts", 2), iAdditionalPairNo:=2)
        ucrInputSolar.AddAdditionalCodeParameterPair(clsETPriestleyTaylorFunction, New RParameter("solar", 3), iAdditionalPairNo:=1)
        ucrReceiverHumidityMax.AddAdditionalCodeParameterPair(clsDataFunctionPTFunction, New RParameter("RHmax", 4), iAdditionalPairNo:=1)
        ucrReceiverHumidityMin.AddAdditionalCodeParameterPair(clsDataFunctionPTFunction, New RParameter("RHmin", 5), iAdditionalPairNo:=1)

        ucrReceiverDate.SetRCode(clsDayFuncFunction, bReset)
        ucrReceiverTmax.SetRCode(clsDataFunctionPMFunction, bReset)
        ucrReceiverTmin.SetRCode(clsDataFunctionPMFunction, bReset)
        ucrReceiverHumidityMax.SetRCode(clsDataFunctionPMFunction, bReset)
        ucrReceiverHumidityMin.SetRCode(clsDataFunctionPMFunction, bReset)
        ucrInputTimeStep.SetRCode(clsETPenmanMonteithFunction, bReset)
        ucrInputCrop.SetRCode(clsETPenmanMonteithFunction, bReset)
        ucrChkWind.SetRCode(clsETPenmanMonteithFunction, bReset)
        ucrNewColName.SetRCode(clsBaseOperator, bReset)
        ucrPnlMethod.SetRCode(clsBaseOperator, bReset)
        ucrNudAlpha.SetRCode(clsETPriestleyTaylorFunction, bReset)
        If bReset Then
            ucrReceiverWindSpeed.SetRCode(clsDataFunctionPMFunction, bReset)
            ucrInputSolar.SetRCode(clsETPenmanMonteithFunction, bReset)
        End If
    End Sub

    Private Sub TestOKEnabled()
        If rdoPenmanMonteith.Checked Then
            If ucrNewColName.IsComplete AndAlso Not ucrReceiverDate.IsEmpty() AndAlso Not ucrReceiverTmax.IsEmpty() AndAlso Not ucrReceiverTmin.IsEmpty() AndAlso
               Not ucrReceiverHumidityMax.IsEmpty() AndAlso Not ucrReceiverHumidityMin.IsEmpty() AndAlso
               Not ucrReceiverRadiation.IsEmpty() AndAlso Not ucrInputTimeStep.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
            If ucrChkWind.Checked And ucrReceiverWindSpeed.IsEmpty Then
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoHargreavesSamani.Checked Then
            If ucrNewColName.IsComplete AndAlso Not ucrReceiverDate.IsEmpty() AndAlso Not ucrReceiverTmax.IsEmpty() AndAlso Not ucrReceiverTmin.IsEmpty() AndAlso Not ucrInputTimeStep.IsEmpty() Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoPriestleyTaylor.Checked Then
            If ucrNewColName.IsComplete AndAlso Not ucrReceiverDate.IsEmpty() AndAlso Not ucrReceiverTmax.IsEmpty() AndAlso Not ucrReceiverTmin.IsEmpty() AndAlso
                Not ucrReceiverHumidityMax.IsEmpty() AndAlso Not ucrReceiverHumidityMin.IsEmpty() AndAlso Not ucrReceiverRadiation.IsEmpty() AndAlso
                Not ucrInputTimeStep.IsEmpty AndAlso Not ucrInputTimeStep.IsEmpty Then
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

    Private Sub cmdEvapOptions_Click(sender As Object, e As EventArgs) Handles cmdEvapOptions.Click
        sdgMissingOptionsEvapotranspiration.SetRFunction(clsReadInputsFunction, clsMissingDataVectorFunction, bResetSubdialog)
        bResetSubdialog = False
        sdgMissingOptionsEvapotranspiration.ShowDialog()
    End Sub

    Private Sub cmdHSMissingOptions_Click(sender As Object, e As EventArgs) Handles cmdHSMissingOptions.Click
        sdgHSMissingOptions.SetRFunction(clsReadInputsFunction, clsMissingDataVectorFunction, bResetSubdialog)
        bResetSubdialog = False
        sdgHSMissingOptions.ShowDialog()
    End Sub

    Private Sub cmdPMConstants_Click(sender As Object, e As EventArgs) Handles cmdPMConstants.Click
        sdgPMConstants.SetRFunction(clsNewListFunction:=clsListFunction, bReset:=bResetSubdialog)
        sdgPMConstants.ShowDialog()
        bResetSubdialog = False
        TestOKEnabled()
    End Sub

    Private Sub cmdHSConstants_Click(sender As Object, e As EventArgs) Handles cmdHSConstants.Click
        sdgHSConstants.SetRFunction(clsNewListFunction:=clsListFunction, bReset:=bResetSubdialog)
        sdgHSConstants.ShowDialog()
        bResetSubdialog = False
        TestOKEnabled()
    End Sub

    Private Sub cmdPTConstants_Click(sender As Object, e As EventArgs) Handles cmdPTConstants.Click
        sdgPTConstants.SetRFunction(clsNewListFunction:=clsListFunction, bReset:=bResetSubdialog)
        sdgPTConstants.ShowDialog()
        bResetSubdialog = False
        TestOKEnabled()
    End Sub

    Private Sub cmdLocation_Click(sender As Object, e As EventArgs) Handles cmdLocation.Click
        sdgLocation.SetRFunction(clsNewVarnamesVectorHSFunction:=clsVarnamesVectorHSFunction, clsNewVarnamesVectorPMFunction:=clsVarnamesVectorPMFunction, clsNewVarnamesVectorPTFunction:=clsVarnamesVectorPTFunction, clsNewListFunction:=clsListFunction, bReset:=bResetSubdialog)
        sdgLocation.ShowDialog()
        bResetSubdialog = False
        TestOKEnabled()
    End Sub

    Private Sub DialogSize()
        If rdoPenmanMonteith.Checked Then
            Me.Size = New System.Drawing.Size(Me.Width, iBasicHeight)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY)
            ucrNewColName.Location = New Point(ucrNewColName.Location.X, iSaveMaxY)
            cmdEvapOptions.Location = New Point(cmdEvapOptions.Location.X, iEvapOptions)
            cmdLocation.Location = New Point(cmdLocation.Location.X, iLocation)
        ElseIf rdoHargreavesSamani.Checked Then
            ucrReceiverDate.SetMeAsReceiver()
            Me.Size = New System.Drawing.Size(Me.Width, iBasicHeight * 0.9)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY / 1.15)
            ucrNewColName.Location = New Point(ucrNewColName.Location.X, iSaveMaxY / 1.183)
            cmdHSMissingOptions.Location = New Point(cmdHSMissingOptions.Location.X, iHSMissingOptions / 1.187)
            cmdHSConstants.Location = New Point(cmdHSConstants.Location.X, iHSConstants / 1.187)
            cmdLocation.Location = New Point(cmdLocation.Location.X, iLocation / 1.187)
        ElseIf rdoPriestleyTaylor.Checked Then
            Me.Size = New System.Drawing.Size(Me.Width, iBasicHeight)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY / 1.01)
            ucrNewColName.Location = New Point(ucrNewColName.Location.X, iSaveMaxY / 1.01)
            cmdHSMissingOptions.Location = New Point(cmdHSMissingOptions.Location.X, iHSMissingOptions / 1.005)
            cmdHSConstants.Location = New Point(cmdHSConstants.Location.X, iHSConstants / 1.005)
            cmdLocation.Location = New Point(cmdLocation.Location.X, iLocation / 1.005)
        End If
    End Sub

    Private Sub Method()
        If rdoPenmanMonteith.Checked Then
            clsReadInputsFunction.AddParameter("varnames", clsRFunctionParameter:=clsVarnamesVectorPMFunction, iPosition:=0)
            clsReadInputsFunction.AddParameter("climatedata", clsRFunctionParameter:=clsDataFunctionPMFunction, iPosition:=1)
        ElseIf rdoHargreavesSamani.Checked Then
            clsReadInputsFunction.AddParameter("varnames", clsRFunctionParameter:=clsVarnamesVectorHSFunction, iPosition:=0)
            clsReadInputsFunction.AddParameter("climatedata", clsRFunctionParameter:=clsDataFunctionHSFunction, iPosition:=1)
        ElseIf rdoPriestleyTaylor.Checked Then
            clsReadInputsFunction.AddParameter("varnames", clsRFunctionParameter:=clsVarnamesVectorPTFunction, iPosition:=0)
            clsReadInputsFunction.AddParameter("climatedata", clsRFunctionParameter:=clsDataFunctionPTFunction, iPosition:=1)
        End If
    End Sub

    Private Sub ucrPnlMethod_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMethod.ControlValueChanged
        Method()
        Solar()
        Constants()
        DialogSize()
        EnableDesableSubDialog()
        If rdoPenmanMonteith.Checked Then
            clsBaseOperator.AddParameter("ET.PenmanMonteith", clsRFunctionParameter:=clsETPenmanMonteithFunction, iPosition:=0)
        Else
            clsBaseOperator.RemoveParameterByName("ET.PenmanMonteith")
        End If
        If rdoHargreavesSamani.Checked Then
            clsBaseOperator.AddParameter("ET.HargreavesSamani", clsRFunctionParameter:=clsHargreavesSamaniFunction, iPosition:=0)
        Else
            clsBaseOperator.RemoveParameterByName("ET.HargreavesSamani")
        End If
        If rdoPriestleyTaylor.Checked Then
            clsBaseOperator.AddParameter("ET.PriestleyTaylor", clsRFunctionParameter:=clsETPriestleyTaylorFunction, iPosition:=0)
        Else
            clsBaseOperator.RemoveParameterByName("ET.PriestleyTaylor")
        End If
    End Sub

    Private Sub EnableDesableSubDialog()
        If rdoPenmanMonteith.Checked Then
            cmdEvapOptions.Visible = True
            cmdPMConstants.Visible = True
            cmdHSMissingOptions.Visible = False
            cmdHSConstants.Visible = False
            cmdPTConstants.Visible = False
        ElseIf rdoHargreavesSamani.Checked Then
            cmdEvapOptions.Visible = False
            cmdPMConstants.Visible = False
            cmdPTConstants.Visible = False
            cmdHSMissingOptions.Visible = True
            cmdHSConstants.Visible = True
        Else
            cmdEvapOptions.Visible = False
            cmdPMConstants.Visible = False
            cmdHSMissingOptions.Visible = True
            cmdPTConstants.Visible = True
            cmdHSConstants.Visible = False
        End If
    End Sub

    Private Sub ucrReceiverWindSpeed_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverWindSpeed.ControlValueChanged, ucrChkWind.ControlValueChanged
        If ucrChkWind.Checked AndAlso Not ucrReceiverWindSpeed.IsEmpty Then
            clsVarnamesVectorPMFunction.AddParameter("x", Chr(34) & "u2" & Chr(34), bIncludeArgumentName:=False)
        Else
            clsVarnamesVectorPMFunction.RemoveParameterByName("x")
            ucrReceiverHumidityMax.SetMeAsReceiver()
        End If
    End Sub

    Private Sub Constants()
        If rdoPenmanMonteith.Checked Then
            clsVarnamesVectorPMFunction.RemoveParameterByName("lon")
            clsListFunction.AddParameter("sigma", 4.903 * 10 ^ -9, iPosition:=5)
            clsListFunction.AddParameter("z", 2, iPosition:=4)
            clsListFunction.AddParameter("G", 0, iPosition:=6)
            clsListFunction.AddParameter("as", 0.23, iPosition:=7)
            clsListFunction.AddParameter("bs", 0.5, iPosition:=8)
            clsListFunction.AddParameter("lambda", 2.45, iPosition:=1)
            clsListFunction.AddParameter("Gsc", 0.082, iPosition:=3)
            clsListFunction.RemoveParameterByName("alphaPT")
        ElseIf rdoHargreavesSamani.Checked Then
            clsVarnamesVectorHSFunction.RemoveParameterByName("lon")
            clsListFunction.AddParameter("lambda", 2.54, iPosition:=1)
            clsListFunction.AddParameter("Gsc", 0.082, iPosition:=3)
            clsListFunction.RemoveParameterByName("alphaPT")
            clsListFunction.RemoveParameterByName("sigma")
            clsListFunction.RemoveParameterByName("z")
            clsListFunction.RemoveParameterByName("G")
            clsListFunction.RemoveParameterByName("as")
            clsListFunction.RemoveParameterByName("bs")
        Else
            clsVarnamesVectorPTFunction.RemoveParameterByName("lon")
            clsListFunction.AddParameter("lambda", 2.54, iPosition:=1)
            clsListFunction.AddParameter("Gsc", 0.082, iPosition:=3)
            clsListFunction.AddParameter("sigma", 4.903 * 10 ^ -9, iPosition:=5)
            clsListFunction.AddParameter("G", 0, iPosition:=6)
            clsListFunction.AddParameter("as", 0.23, iPosition:=7)
            clsListFunction.AddParameter("bs", 0.5, iPosition:=8)
            clsListFunction.AddParameter("alphaPT", 1.26, iPosition:=9)
            clsListFunction.RemoveParameterByName("z")
        End If
    End Sub

    Private Sub Solar()
        If rdoPenmanMonteith.Checked AndAlso ucrInputSolar.GetText = "sunshine hours" Then
            ucrReceiverRadiation.SetClimaticType("sunshine_hours")
            ucrReceiverRadiation.bAutoFill = True
            clsETPenmanMonteithFunction.AddParameter("solar", Chr(34) & "sunshine hours" & Chr(34), iPosition:=3)
            clsVarnamesVectorPMFunction.AddParameter("n", Chr(34) & "n" & Chr(34), bIncludeArgumentName:=False)
            clsDataFunctionPMFunction.AddParameter("n", clsRFunctionParameter:=ucrReceiverRadiation.GetVariables(), iPosition:=6)
            clsVarnamesVectorPMFunction.RemoveParameterByName("Rs")
            clsVarnamesVectorPMFunction.RemoveParameterByName("Cd")
            clsDataFunctionPMFunction.RemoveParameterByName("Rs")
            clsDataFunctionPMFunction.RemoveParameterByName("cd")
        ElseIf rdoPenmanMonteith.Checked AndAlso ucrInputSolar.GetText = "radiation" Then
            ucrReceiverRadiation.SetClimaticType("radiation")
            ucrReceiverRadiation.bAutoFill = True
            clsETPenmanMonteithFunction.AddParameter("solar", Chr(34) & "data" & Chr(34), iPosition:=3)
            clsVarnamesVectorPMFunction.AddParameter("Rs", Chr(34) & "Rs" & Chr(34), bIncludeArgumentName:=False)
            clsDataFunctionPMFunction.AddParameter("Rs", clsRFunctionParameter:=ucrReceiverRadiation.GetVariables(), iPosition:=6)
            clsVarnamesVectorPMFunction.RemoveParameterByName("n")
            clsVarnamesVectorPMFunction.RemoveParameterByName("Cd")
            clsDataFunctionPMFunction.RemoveParameterByName("n")
            clsDataFunctionPMFunction.RemoveParameterByName("cd")
        ElseIf rdoPenmanMonteith.Checked AndAlso ucrInputSolar.GetText = "cloud" Then
            ucrReceiverRadiation.SetClimaticType("cloud_cover")
            ucrReceiverRadiation.bAutoFill = True
            clsETPenmanMonteithFunction.AddParameter("solar", Chr(34) & "cloud" & Chr(34), iPosition:=3)
            clsVarnamesVectorPMFunction.AddParameter("Cd", Chr(34) & "Cd" & Chr(34), bIncludeArgumentName:=False)
            clsDataFunctionPMFunction.AddParameter("Cd", clsRFunctionParameter:=ucrReceiverRadiation.GetVariables(), iPosition:=6)
            clsVarnamesVectorPMFunction.RemoveParameterByName("n")
            clsVarnamesVectorPMFunction.RemoveParameterByName("Rs")
            clsDataFunctionPMFunction.RemoveParameterByName("n")
            clsDataFunctionPMFunction.RemoveParameterByName("Rs")
        ElseIf rdoPriestleyTaylor.Checked AndAlso ucrInputSolar.GetText = "sunshine hours" Then
            ucrReceiverRadiation.SetClimaticType("sunshine_hours")
            ucrReceiverRadiation.bAutoFill = True
            clsETPriestleyTaylorFunction.AddParameter("solar", Chr(34) & "sunshine hours" & Chr(34), iPosition:=3)
            clsVarnamesVectorPTFunction.AddParameter("n", Chr(34) & "n" & Chr(34), bIncludeArgumentName:=False)
            clsDataFunctionPTFunction.AddParameter("n", clsRFunctionParameter:=ucrReceiverRadiation.GetVariables(), iPosition:=6)
            clsVarnamesVectorPTFunction.RemoveParameterByName("Rs")
            clsVarnamesVectorPTFunction.RemoveParameterByName("Cd")
            clsDataFunctionPTFunction.RemoveParameterByName("Rs")
            clsDataFunctionPTFunction.RemoveParameterByName("cd")
        ElseIf rdoPriestleyTaylor.Checked AndAlso ucrInputSolar.GetText = "radiation" Then
            ucrReceiverRadiation.SetClimaticType("radiation")
            ucrReceiverRadiation.bAutoFill = True
            clsETPriestleyTaylorFunction.AddParameter("solar", Chr(34) & "data" & Chr(34), iPosition:=3)
            clsVarnamesVectorPTFunction.AddParameter("Rs", Chr(34) & "Rs" & Chr(34), bIncludeArgumentName:=False)
            clsDataFunctionPTFunction.AddParameter("Rs", clsRFunctionParameter:=ucrReceiverRadiation.GetVariables(), iPosition:=6)
            clsDataFunctionPTFunction.RemoveParameterByName("n")
            clsDataFunctionPTFunction.RemoveParameterByName("cd")
            clsVarnamesVectorPTFunction.RemoveParameterByName("n")
            clsVarnamesVectorPTFunction.RemoveParameterByName("cd")
        ElseIf rdoPriestleyTaylor.Checked AndAlso ucrInputSolar.GetText = "cloud" Then
            ucrReceiverRadiation.SetClimaticType("cloud_cover")
            ucrReceiverRadiation.bAutoFill = True
            clsETPriestleyTaylorFunction.AddParameter("solar", Chr(34) & "cloud" & Chr(34), iPosition:=3)
            clsVarnamesVectorPTFunction.AddParameter("Cd", Chr(34) & "Cd" & Chr(34), bIncludeArgumentName:=False)
            clsDataFunctionPTFunction.AddParameter("Cd", clsRFunctionParameter:=ucrReceiverRadiation.GetVariables(), iPosition:=6)
            clsDataFunctionPTFunction.RemoveParameterByName("n")
            clsDataFunctionPTFunction.RemoveParameterByName("Rs")
            clsVarnamesVectorPTFunction.RemoveParameterByName("n")
            clsVarnamesVectorPTFunction.RemoveParameterByName("Rs")
        End If
    End Sub

    Private Sub ucrInputSolar_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSolar.ControlValueChanged
        Solar()
    End Sub

    Private Sub ucrSelectorEvapotranspiration_DataFrameChanged() Handles ucrSelectorEvapotranspiration.DataFrameChanged
        Method()
    End Sub

    Private Sub ucrSelectorEvapotranspiration_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorEvapotranspiration.ControlValueChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColName.GetText, strTempDataframe:=ucrSelectorEvapotranspiration.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColName.GetText)
        Method()
    End Sub

    Private Sub ucrReceiverRadiation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRadiation.ControlValueChanged
        Solar()
    End Sub

    Private Sub ucrPnlMethod_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlMethod.ControlContentsChanged, ucrNewColName.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverTmax.ControlContentsChanged, ucrReceiverTmin.ControlContentsChanged, ucrReceiverHumidityMax.ControlContentsChanged, ucrReceiverHumidityMin.ControlContentsChanged, ucrReceiverRadiation.ControlContentsChanged, ucrReceiverWindSpeed.ControlContentsChanged, ucrInputTimeStep.ControlContentsChanged, ucrChkWind.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class

