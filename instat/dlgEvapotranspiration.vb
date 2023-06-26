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
    Private clsETPenmanMonteith, clsHargreavesSamani, clsListFunction, clsDataFunctionPM, clsDataFunctionHS, clsReadInputs, clsVector, clsMissingDataVector, clsVarnamesVectorPM, clsVarnamesVectorHS, clsLibraryEvap As New RFunction
    Private clsDayFunc, clsMonthFunc, clsYearFunc As New RFunction
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
        dctInputSolar.Add("radiation", Chr(34) & "radiation" & Chr(34))
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
        clsETPenmanMonteith = New RFunction
        clsHargreavesSamani = New RFunction
        clsDataFunctionPM = New RFunction
        clsDataFunctionHS = New RFunction
        clsBaseOperator = New ROperator
        clsReadInputs = New RFunction
        clsDayFunc = New RFunction
        clsMonthFunc = New RFunction
        clsYearFunc = New RFunction
        clsLibraryEvap = New RFunction
        clsListFunction = New RFunction

        ucrSelectorEvapotranspiration.Reset()
        ucrReceiverHumidityMax.SetMeAsReceiver()
        ucrNewColName.Reset()

        bResetSubdialog = True

        clsDataFunctionPM.SetRCommand("data.frame")
        clsDataFunctionPM.AddParameter("Year", clsRFunctionParameter:=clsYearFunc)
        clsDataFunctionPM.AddParameter("Month", clsRFunctionParameter:=clsMonthFunc)
        clsDataFunctionPM.AddParameter("Day", clsRFunctionParameter:=clsDayFunc)

        clsDataFunctionHS.SetRCommand("data.frame")
        clsDataFunctionHS.AddParameter("Year", clsRFunctionParameter:=clsYearFunc)
        clsDataFunctionHS.AddParameter("Month", clsRFunctionParameter:=clsMonthFunc)
        clsDataFunctionHS.AddParameter("Day", clsRFunctionParameter:=clsDayFunc)

        clsDayFunc.SetPackageName("lubridate")
        clsDayFunc.SetRCommand("day")

        clsMonthFunc.SetPackageName("lubridate")
        clsMonthFunc.SetRCommand("month")

        clsYearFunc.SetRCommand("year")
        clsYearFunc.SetPackageName("lubridate")

        clsReadInputs.SetPackageName("Evapotranspiration")
        clsReadInputs.SetRCommand("ReadInputs")
        clsReadInputs.AddParameter("constants", "constants", iPosition:=2)
        clsReadInputs.AddParameter("stopmissing", clsRFunctionParameter:=clsMissingDataVector, iPosition:=3)
        clsReadInputs.AddParameter("timestep", Chr(34) & "daily" & Chr(34), iPosition:=4)
        clsReadInputs.AddParameter("interp_missing_days", "FALSE", iPosition:=5)
        clsReadInputs.AddParameter("interp_missing_entries", "FALSE", iPosition:=6)
        clsReadInputs.AddParameter("interp_abnormal", "FALSE", iPosition:=7)
        clsReadInputs.AddParameter("abnormal_method", "NULL", iPosition:=9)
        clsReadInputs.AddParameter("varnames", clsRFunctionParameter:=clsVarnamesVectorPM, iPosition:=0)
        clsReadInputs.AddParameter("climatedata", clsRFunctionParameter:=clsDataFunctionPM, iPosition:=1)
        clsReadInputs.AddParameter("missing_method", Chr(34) & "monthly average" & Chr(34), iPosition:=8)
        clsReadInputs.SetAssignTo("temp_data")

        clsVarnamesVectorPM.SetRCommand("c")
        clsVarnamesVectorPM.AddParameter("Tmax", Chr(34) & "Tmax" & Chr(34), bIncludeArgumentName:=False)
        clsVarnamesVectorPM.AddParameter("Tmin", Chr(34) & "Tmin" & Chr(34), bIncludeArgumentName:=False)
        clsVarnamesVectorPM.AddParameter("RHmax", Chr(34) & "RHmax" & Chr(34), bIncludeArgumentName:=False)
        clsVarnamesVectorPM.AddParameter("RHmin", Chr(34) & "RHmin" & Chr(34), bIncludeArgumentName:=False)
        clsVarnamesVectorPM.AddParameter("lon", 0, iPosition:=3)

        clsVarnamesVectorHS.SetRCommand("c")
        clsVarnamesVectorHS.AddParameter("Tmax", Chr(34) & "Tmax" & Chr(34), bIncludeArgumentName:=False)
        clsVarnamesVectorHS.AddParameter("Tmin", Chr(34) & "Tmin" & Chr(34), bIncludeArgumentName:=False)

        clsMissingDataVector.SetRCommand("c")
        clsMissingDataVector.AddParameter("x", 1, bIncludeArgumentName:=False)
        clsMissingDataVector.AddParameter("y", 1, bIncludeArgumentName:=False)
        clsMissingDataVector.AddParameter("z", 1, bIncludeArgumentName:=False)

        clsVector.SetRCommand("c")

        clsListFunction.ClearParameters()
        clsListFunction.SetRCommand("list")
        clsListFunction.AddParameter("Elev", 0, iPosition:=0)
        clsListFunction.AddParameter("lambda", 2.54, iPosition:=1)
        clsListFunction.AddParameter("lat_rad", 0, iPosition:=2)
        clsListFunction.AddParameter("sigma", 4.903 * 10 ^ -9, iPosition:=5)
        clsListFunction.AddParameter("Gsc", 0.082, iPosition:=3)
        clsListFunction.AddParameter("z", 2, iPosition:=4)
        clsListFunction.AddParameter("G", 0, iPosition:=6)
        clsListFunction.AddParameter("as", 0.25, iPosition:=7)
        clsListFunction.AddParameter("bs", 0.5, iPosition:=8)
        clsListFunction.SetAssignTo("constants")

        clsETPenmanMonteith.SetPackageName("Evapotranspiration")
        clsETPenmanMonteith.SetRCommand("ET.PenmanMonteith")
        clsETPenmanMonteith.AddParameter("data", clsRFunctionParameter:=clsReadInputs, iPosition:=0)
        clsETPenmanMonteith.AddParameter("constants", "constants", iPosition:=1)
        clsETPenmanMonteith.AddParameter("ts", Chr(34) & "daily" & Chr(34), iPosition:=2)
        clsETPenmanMonteith.AddParameter("solar", Chr(34) & "sunshine hours" & Chr(34), iPosition:=3)
        clsETPenmanMonteith.AddParameter("message", Chr(34) & "yes" & Chr(34), iPosition:=4)
        clsETPenmanMonteith.AddParameter("crops", Chr(34) & "short" & Chr(34), iPosition:=5)
        clsETPenmanMonteith.AddParameter("save.csv", Chr(34) & "no" & Chr(34), iPosition:=6)
        clsETPenmanMonteith.SetAssignTo("Penman_Monteith")

        clsHargreavesSamani.SetPackageName("Evapotranspiration")
        clsHargreavesSamani.SetRCommand("ET.HargreavesSamani")
        clsHargreavesSamani.AddParameter("data", clsRFunctionParameter:=clsReadInputs, iPosition:=0)
        clsHargreavesSamani.AddParameter("constants", "constants", iPosition:=1)
        clsHargreavesSamani.AddParameter("ts", Chr(34) & "daily" & Chr(34), iPosition:=2)
        clsHargreavesSamani.AddParameter("message", Chr(34) & "yes" & Chr(34), iPosition:=3)
        clsHargreavesSamani.AddParameter("save.csv", Chr(34) & "no" & Chr(34), iPosition:=4)
        clsHargreavesSamani.SetAssignTo("Hargreaves_Samani")

        clsBaseOperator.SetOperation("$")
        clsBaseOperator.bSpaceAroundOperation = False
        clsBaseOperator.AddParameter("ET.PenmanMonteith", clsRFunctionParameter:=clsETPenmanMonteith, iPosition:=0)
        clsBaseOperator.AddParameter("ET.Daily", strParameterValue:="ET.Daily", iPosition:=1)

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColName.GetText, strTempDataframe:=ucrSelectorEvapotranspiration.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColName.GetText)
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsListFunction, iPosition:=1)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverDate.AddAdditionalCodeParameterPair(clsMonthFunc, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverDate.AddAdditionalCodeParameterPair(clsYearFunc, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrReceiverTmax.AddAdditionalCodeParameterPair(clsDataFunctionHS, New RParameter("Tmax", 3), iAdditionalPairNo:=1)
        ucrReceiverTmin.AddAdditionalCodeParameterPair(clsDataFunctionHS, New RParameter("Tmin", 4), iAdditionalPairNo:=1)
        ucrInputTimeStep.AddAdditionalCodeParameterPair(clsHargreavesSamani, New RParameter("ts", 2), iAdditionalPairNo:=1)

        ucrReceiverDate.SetRCode(clsDayFunc, bReset)
        ucrReceiverTmax.SetRCode(clsDataFunctionPM, bReset)
        ucrReceiverTmin.SetRCode(clsDataFunctionPM, bReset)
        ucrReceiverHumidityMax.SetRCode(clsDataFunctionPM, bReset)
        ucrReceiverHumidityMin.SetRCode(clsDataFunctionPM, bReset)
        ucrReceiverWindSpeed.SetRCode(clsDataFunctionPM, bReset)
        ucrInputTimeStep.SetRCode(clsETPenmanMonteith, bReset)
        ucrInputCrop.SetRCode(clsETPenmanMonteith, bReset)
        ucrChkWind.SetRCode(clsETPenmanMonteith, bReset)
        ucrNewColName.SetRCode(clsBaseOperator, bReset)
        ucrPnlMethod.SetRCode(clsBaseOperator, bReset)
        If bReset Then
            ucrInputSolar.SetRCode(clsETPenmanMonteith, bReset)
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
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdEvapOptions_Click(sender As Object, e As EventArgs) Handles cmdEvapOptions.Click
        sdgMissingOptionsEvapotranspiration.SetRFunction(clsReadInputs, clsMissingDataVector, bResetSubdialog)
        bResetSubdialog = False
        sdgMissingOptionsEvapotranspiration.ShowDialog()
    End Sub

    Private Sub cmdHSMissingOptions_Click(sender As Object, e As EventArgs) Handles cmdHSMissingOptions.Click
        sdgHSMissingOptions.SetRFunction(clsReadInputs, clsMissingDataVector, bResetSubdialog)
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

    Private Sub cmdLocation_Click(sender As Object, e As EventArgs) Handles cmdLocation.Click
        sdgLocation.SetRFunction(clsNewVarnamesVectorHS:=clsVarnamesVectorHS, clsNewVarnamesVectorPM:=clsVarnamesVectorPM, clsNewListFunction:=clsListFunction, bReset:=bResetSubdialog)
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
        EnableDesableSubDialog()
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

    Private Sub EnableDesableSubDialog()
        If rdoPenmanMonteith.Checked Then
            cmdEvapOptions.Visible = True
            cmdPMConstants.Visible = True
            cmdHSMissingOptions.Visible = False
            cmdHSConstants.Visible = False
        Else
            cmdEvapOptions.Visible = False
            cmdPMConstants.Visible = False
            cmdHSMissingOptions.Visible = True
            cmdHSConstants.Visible = True
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
                clsETPenmanMonteith.AddParameter("solar", Chr(34) & "sunshine hours" & Chr(34), iPosition:=3)
                ucrReceiverRadiation.SetClimaticType("sunshine_hours")
                ucrReceiverRadiation.bAutoFill = True
                clsVarnamesVectorPM.AddParameter("n", Chr(34) & "n" & Chr(34), bIncludeArgumentName:=False)
                clsDataFunctionPM.AddParameter("n", clsRFunctionParameter:=ucrReceiverRadiation.GetVariables(), iPosition:=6)
                clsVarnamesVectorPM.RemoveParameterByName("Rs")
                clsVarnamesVectorPM.RemoveParameterByName("Cd")
                clsDataFunctionPM.RemoveParameterByName("Rs")
                clsDataFunctionPM.RemoveParameterByName("cd")
            Case "radiation"
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
    Private Sub ucrPnlMethod_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlMethod.ControlContentsChanged, ucrNewColName.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverTmax.ControlContentsChanged, ucrReceiverTmin.ControlContentsChanged, ucrReceiverHumidityMax.ControlContentsChanged, ucrReceiverHumidityMin.ControlContentsChanged, ucrReceiverRadiation.ControlContentsChanged, ucrReceiverWindSpeed.ControlContentsChanged, ucrInputTimeStep.ControlContentsChanged, ucrChkWind.ControlContentsChanged, ucrChkWind.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class

