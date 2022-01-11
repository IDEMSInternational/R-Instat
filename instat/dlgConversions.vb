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
Public Class dlgConversions
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsPrecipitationFunction, clsTemperatureFunction, clsWindSpeedFunction, clsConvertToDegreeFunction As New RFunction
    Private clsRoundFunction As New RFunction
    Private clsDayLengthFunction As New RFunction
    Private clsDummyFunction As New RFunction

    Private Sub dlgConversions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 563
        Dim dctPrecipitationUnits As New Dictionary(Of String, String)
        Dim dctTemperatureUnits As New Dictionary(Of String, String)
        Dim dctWindSpeedUnits As New Dictionary(Of String, String)
        Dim dctDirectionPairs As New Dictionary(Of String, String)

        Dim lstLabels As New List(Of Control)
        lstLabels.AddRange({lblFrom, lblTo, lblDecimal})

        ucrPnlConversions.AddRadioButton(rdoUnits)
        ucrPnlConversions.AddRadioButton(rdoDayLength)
        ucrPnlConversions.AddRadioButton(rdoCoordinates)

        ucrPnlConversions.AddFunctionNamesCondition(rdoUnits, {"convert_precip", "convert_temperature", "convert_wind_speed"})
        ucrPnlConversions.AddFunctionNamesCondition(rdoDayLength, "daylength")
        ucrPnlConversions.AddFunctionNamesCondition(rdoCoordinates, "convert_to_dec_deg")

        ucrPnlLatitude.AddRadioButton(rdoSingleValue)
        ucrPnlLatitude.AddRadioButton(rdoColumn)

        ucrPnlElements.AddRadioButton(rdoRain)
        ucrPnlElements.AddRadioButton(rdoTemperature)
        ucrPnlElements.AddRadioButton(rdoWindSpeed)

        ucrPnlElements.AddFunctionNamesCondition(rdoRain, "convert_precip")
        ucrPnlElements.AddFunctionNamesCondition(rdoTemperature, "convert_temperature")
        ucrPnlElements.AddFunctionNamesCondition(rdoWindSpeed, "convert_wind_speed")

        ucrChkVariable.SetText("Variable")
        ucrChkVariable.SetParameter(New RParameter("checked", 0))
        ucrChkVariable.SetValuesCheckedAndUnchecked("True", "False")
        ucrChkVariable.SetRDefault("True")

        ucrReceiverElement.SetParameter(New RParameter("precip", 0))
        ucrReceiverElement.bWithQuotes = False
        ucrReceiverElement.SetParameterIsRFunction()
        ucrReceiverElement.Selector = ucrSelectorConversions
        ucrReceiverElement.bUseFilteredData = False

        ucrReceiverDate.SetParameter(New RParameter("doy", 2))
        ucrReceiverDate.SetParameterIsRFunction()
        ucrReceiverDate.Selector = ucrSelectorConversions
        ucrReceiverDate.bUseFilteredData = False

        ucrReceiverLatitude.SetParameter(New RParameter("lat", 1))
        ucrReceiverLatitude.bWithQuotes = False
        ucrReceiverLatitude.SetParameterIsRFunction()
        ucrReceiverLatitude.Selector = ucrSelectorConversions
        ucrReceiverLatitude.bUseFilteredData = False

        ucrReceiverDegrees.Selector = ucrSelectorConversions
        ucrReceiverDegrees.bUseFilteredData = False

        ucrReceiverMinutes.Selector = ucrSelectorConversions
        ucrReceiverMinutes.bUseFilteredData = False

        ucrReceiverSeconds.Selector = ucrSelectorConversions
        ucrReceiverSeconds.bUseFilteredData = False

        ucrReceiverLetters.Selector = ucrSelectorConversions
        ucrReceiverLetters.bUseFilteredData = False

        ucrInputLatitude.SetValidationTypeAsNumeric(dcmMin:=-90, dcmMax:=90)

        ucrInputFromPrecipitation.SetParameter(New RParameter("old_metric", 1))
        dctPrecipitationUnits.Add("cm", Chr(34) & "cm" & Chr(34))
        dctPrecipitationUnits.Add("inches", Chr(34) & "inches" & Chr(34))
        dctPrecipitationUnits.Add("mm", Chr(34) & "mm" & Chr(34))
        ucrInputFromPrecipitation.SetItems(dctPrecipitationUnits)
        ucrInputFromPrecipitation.SetDropDownStyleAsNonEditable()

        ucrInputToPrecipitation.SetParameter(New RParameter("new_metric", 2))
        ucrInputToPrecipitation.SetItems(dctPrecipitationUnits)
        ucrInputToPrecipitation.SetDropDownStyleAsNonEditable()

        ucrInputFromTemperature.SetParameter(New RParameter("old_metric", 1))
        dctTemperatureUnits.Add("Celsius", Chr(34) & "celsius" & Chr(34))
        dctTemperatureUnits.Add("Fahrenheit", Chr(34) & "fahrenheit" & Chr(34))
        dctTemperatureUnits.Add("Kelvin", Chr(34) & "kelvin" & Chr(34))
        ucrInputFromTemperature.SetItems(dctTemperatureUnits)
        ucrInputFromTemperature.SetDropDownStyleAsNonEditable()

        ucrInputToTemperature.SetParameter(New RParameter("new_metric", 2))
        ucrInputToTemperature.SetItems(dctTemperatureUnits)
        ucrInputToTemperature.SetDropDownStyleAsNonEditable()

        ucrInputFromWindSpeed.SetParameter(New RParameter("old_metric", 1))
        dctWindSpeedUnits.Add("Feet per second (ftps)", Chr(34) & "ftps" & Chr(34))
        dctWindSpeedUnits.Add("Kilometres per hour (kmph)", Chr(34) & "kmph" & Chr(34))
        dctWindSpeedUnits.Add("Knots", Chr(34) & "knots" & Chr(34))
        dctWindSpeedUnits.Add("Metres per second (mps)", Chr(34) & "mps" & Chr(34))
        dctWindSpeedUnits.Add("Miles per hour (mph)", Chr(34) & "mph" & Chr(34))
        ucrInputFromWindSpeed.SetItems(dctWindSpeedUnits)
        ucrInputFromWindSpeed.SetDropDownStyleAsNonEditable()

        ucrInputToWindSpeed.SetParameter(New RParameter("new_metric", 2))
        ucrInputToWindSpeed.SetItems(dctWindSpeedUnits)
        ucrInputToWindSpeed.SetDropDownStyleAsNonEditable()

        ucrNudDecimal.SetParameter(New RParameter("round", 3))
        ucrNudDecimal.SetMinMax(0, 5)

        ucrPnlConversions.AddToLinkedControls(ucrReceiverElement, {rdoUnits}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlConversions.AddToLinkedControls(ucrNudDecimal, {rdoUnits}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlConversions.AddToLinkedControls(ucrPnlElements, {rdoUnits}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoRain)

        ucrPnlConversions.AddToLinkedControls(ucrReceiverDate, {rdoDayLength}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlConversions.AddToLinkedControls(ucrPnlLatitude, {rdoDayLength}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoSingleValue)

        ucrPnlLatitude.AddToLinkedControls(ucrInputLatitude, {rdoSingleValue}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlLatitude.AddToLinkedControls(ucrReceiverLatitude, {rdoColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrInputDirection.SetParameter(New RParameter("dir", 3))
        dctDirectionPairs.Add("N", Chr(34) & "N" & Chr(34))
        dctDirectionPairs.Add("S", Chr(34) & "S" & Chr(34))
        dctDirectionPairs.Add("W", Chr(34) & "W" & Chr(34))
        dctDirectionPairs.Add("E", Chr(34) & "E" & Chr(34))
        ucrInputDirection.SetItems(dctDirectionPairs)
        ucrInputDirection.SetDropDownStyleAsNonEditable()

        ucrPnlElements.AddToLinkedControls(ucrInputFromPrecipitation, {rdoRain}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlElements.AddToLinkedControls(ucrInputToPrecipitation, {rdoRain}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlElements.AddToLinkedControls(ucrInputFromTemperature, {rdoTemperature}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Kelvin")
        ucrPnlElements.AddToLinkedControls(ucrInputToTemperature, {rdoTemperature}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Celsius")
        ucrPnlElements.AddToLinkedControls(ucrInputFromWindSpeed, {rdoWindSpeed}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Knots")
        ucrPnlElements.AddToLinkedControls(ucrInputToWindSpeed, {rdoWindSpeed}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Metres per second (mps)")
        ucrPnlConversions.AddToLinkedControls(ucrReceiverDegrees, {rdoCoordinates}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlConversions.AddToLinkedControls(ucrReceiverMinutes, {rdoCoordinates}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlConversions.AddToLinkedControls(ucrReceiverSeconds, {rdoCoordinates}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlConversions.AddToLinkedControls(ucrInputDirection, {rdoCoordinates}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlConversions.AddToLinkedControls(ucrSaveConversions, {rdoUnits, rdoDayLength}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlConversions.AddToLinkedControls({ucrChkVariable}, {rdoCoordinates}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputDirection.AddToLinkedControls(ucrReceiverLetters, {"Variable"}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkVariable.AddToLinkedControls({ucrInputDegree, ucrInputMinute, ucrInputSecond}, {False}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkVariable.AddToLinkedControls(ucrSaveColumn, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverDegrees.SetLinkedDisplayControl(lblDegrees)
        ucrReceiverMinutes.SetLinkedDisplayControl(lblMinutes)
        ucrReceiverSeconds.SetLinkedDisplayControl(lblSeconds)
        ucrInputDirection.SetLinkedDisplayControl(lblDirection)

        ucrReceiverElement.SetLinkedDisplayControl(lblElement)
        ucrNudDecimal.SetLinkedDisplayControl(lstLabels)
        ucrReceiverDate.SetLinkedDisplayControl(lblDate)
        ucrPnlLatitude.SetLinkedDisplayControl(grpLatitude)
        ucrPnlElements.SetLinkedDisplayControl(grpElements)

        ucrSaveConversions.SetSaveTypeAsColumn()
        ucrSaveConversions.SetDataFrameSelector(ucrSelectorConversions.ucrAvailableDataFrames)
        ucrSaveConversions.SetIsComboBox()
        ucrSaveConversions.SetLabelText("Result into:")

        ucrSaveColumn.SetSaveTypeAsColumn()
        ucrSaveColumn.SetDataFrameSelector(ucrSelectorConversions.ucrAvailableDataFrames)
        ucrSaveColumn.SetIsComboBox()
        ucrSaveColumn.SetLabelText("Result into:")
        ucrSaveColumn.SetPrefix("coord")
        ucrSaveColumn.setLinkedReceiver(ucrReceiverDegrees)
    End Sub

    Private Sub SetDefaults()
        clsPrecipitationFunction = New RFunction
        clsTemperatureFunction = New RFunction
        clsWindSpeedFunction = New RFunction
        clsDayLengthFunction = New RFunction
        clsConvertToDegreeFunction = New RFunction
        clsRoundFunction = New RFunction
        clsDummyFunction = New RFunction

        ucrSelectorConversions.Reset()
        ucrSaveConversions.Reset()
        ucrInputLatitude.SetName("")
        ucrInputDegree.SetName("")
        ucrInputMinute.SetName("")
        ucrInputSecond.SetName("")
        ucrReceiverElement.SetMeAsReceiver()

        clsPrecipitationFunction.SetPackageName("weathermetrics")
        clsPrecipitationFunction.SetRCommand("convert_precip")
        clsPrecipitationFunction.AddParameter("round", 1, iPosition:=3)
        clsPrecipitationFunction.AddParameter("old_metric", Chr(34) & "inches" & Chr(34), iPosition:=1)
        clsPrecipitationFunction.AddParameter("new_metric", Chr(34) & "mm" & Chr(34), iPosition:=2)

        clsTemperatureFunction.SetPackageName("weathermetrics")
        clsTemperatureFunction.SetRCommand("convert_temperature")

        clsWindSpeedFunction.SetPackageName("weathermetrics")
        clsWindSpeedFunction.SetRCommand("convert_wind_speed")

        clsDayLengthFunction.SetPackageName("geosphere")
        clsDayLengthFunction.SetRCommand("daylength")

        clsConvertToDegreeFunction.SetRCommand("convert_to_dec_deg")
        clsConvertToDegreeFunction.AddParameter("dir", Chr(34) & "N" & Chr(34), iPosition:=3)

        clsRoundFunction.SetRCommand("round")
        clsRoundFunction.AddParameter("x", clsRFunctionParameter:=clsConvertToDegreeFunction, iPosition:=0)
        clsRoundFunction.AddParameter("digits", 3, iPosition:=1)

        clsPrecipitationFunction.SetAssignTo(ucrSaveConversions.GetText, strTempDataframe:=ucrSelectorConversions.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveConversions.GetText, bAssignToIsPrefix:=True)
        ucrBase.clsRsyntax.SetBaseRFunction(clsPrecipitationFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsTemperatureFunction, (New RParameter("temperature", 0)), iAdditionalPairNo:=1)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsWindSpeedFunction, (New RParameter("wind_speed", 0)), iAdditionalPairNo:=2)
        ucrNudDecimal.AddAdditionalCodeParameterPair(clsTemperatureFunction, (New RParameter("round", 3)), iAdditionalPairNo:=1)
        ucrNudDecimal.AddAdditionalCodeParameterPair(clsWindSpeedFunction, (New RParameter("round", 3)), iAdditionalPairNo:=2)
        ucrSaveConversions.AddAdditionalRCode(clsTemperatureFunction, iAdditionalPairNo:=1)
        ucrSaveConversions.AddAdditionalRCode(clsWindSpeedFunction, iAdditionalPairNo:=2)
        ucrSaveConversions.AddAdditionalRCode(clsDayLengthFunction, iAdditionalPairNo:=3)

        ucrReceiverElement.SetRCode(clsPrecipitationFunction, bReset)
        ucrInputFromPrecipitation.SetRCode(clsPrecipitationFunction, bReset)
        ucrInputToPrecipitation.SetRCode(clsPrecipitationFunction, bReset)
        ucrInputFromTemperature.SetRCode(clsTemperatureFunction, bReset)
        ucrInputToTemperature.SetRCode(clsTemperatureFunction, bReset)
        ucrInputFromWindSpeed.SetRCode(clsWindSpeedFunction, bReset)
        ucrInputToWindSpeed.SetRCode(clsWindSpeedFunction, bReset)
        ucrNudDecimal.SetRCode(clsPrecipitationFunction, bReset)
        ucrChkVariable.SetRCode(clsDummyFunction, bReset)
        ucrSaveConversions.SetRCode(clsPrecipitationFunction, bReset)
        ucrSaveColumn.SetRCode(clsRoundFunction, bReset)
        ucrInputDirection.SetRCode(clsConvertToDegreeFunction, bReset)

        If bReset Then
            ucrPnlConversions.SetRCode(clsPrecipitationFunction, bReset)
        End If
        ucrReceiverDate.SetRCode(clsDayLengthFunction, bReset)
        ucrReceiverLatitude.SetRCode(clsDayLengthFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoUnits.Checked AndAlso Not ucrReceiverElement.IsEmpty AndAlso ucrNudDecimal.GetText <> "" AndAlso ucrSaveConversions.IsComplete Then
            If rdoRain.Checked AndAlso ucrInputFromPrecipitation.GetText <> ucrInputToPrecipitation.GetText Then
                ucrBase.OKEnabled(True)
            ElseIf rdoTemperature.Checked AndAlso ucrInputFromTemperature.GetText <> ucrInputToTemperature.GetText Then
                ucrBase.OKEnabled(True)
            ElseIf rdoWindSpeed.Checked AndAlso ucrInputFromWindSpeed.GetText <> ucrInputToWindSpeed.GetText Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoDayLength.Checked AndAlso Not ucrReceiverDate.IsEmpty AndAlso ((rdoSingleValue.Checked AndAlso Not ucrInputLatitude.IsEmpty) OrElse
               (rdoColumn.Checked AndAlso Not ucrReceiverLatitude.IsEmpty)) Then
            ucrBase.OKEnabled(True)
        ElseIf rdoCoordinates.Checked Then
            If (Not ucrReceiverDegrees.IsEmpty AndAlso ucrSaveConversions.IsComplete AndAlso ucrChkVariable.Checked) OrElse
               (Not ucrChkVariable.Checked AndAlso Not ucrInputDegree.IsEmpty) Then
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
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub SetBaseFunction()
        If rdoRain.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsPrecipitationFunction)
        ElseIf rdoTemperature.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsTemperatureFunction)
        ElseIf rdoWindSpeed.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsWindSpeedFunction)
        End If
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub ucrPnlLatitude_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlLatitude.ControlValueChanged
        If rdoDayLength.Checked Then
            If rdoColumn.Checked Then
                ucrReceiverLatitude.SetMeAsReceiver()
            ElseIf rdoSingleValue.Checked Then
                ucrReceiverDate.SetMeAsReceiver()
            End If
        End If
        ChangeLatParameter()
    End Sub

    Private Sub ucrPnlConversions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlConversions.ControlValueChanged

        If rdoDayLength.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsDayLengthFunction)
            ucrBase.clsRsyntax.iCallType = 0
            ucrReceiverDate.SetMeAsReceiver()
            ucrSaveConversions.SetPrefix("day_length")
            ucrSaveConversions.setLinkedReceiver(ucrReceiverDate)
        ElseIf rdoUnits.Checked Then
            SetBaseFunction()
            ucrReceiverElement.SetMeAsReceiver()
            ucrSaveConversions.SetPrefix("conversion")
            ucrSaveConversions.setLinkedReceiver(ucrReceiverElement)
        ElseIf rdoCoordinates.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsRoundFunction)
            ucrReceiverDegrees.SetMeAsReceiver()
            ChangeParameter()
        End If
        ChangeLatParameter()
    End Sub

    Private Sub ucrPnlElements_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlElements.ControlValueChanged
        SetBaseFunction()
    End Sub

    Private Sub ucrInputDirection_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputDirection.ControlValueChanged, ucrReceiverLetters.ControlValueChanged
        Dim clsGetDirVariable As RFunction = ucrReceiverLetters.GetVariables
        If ucrInputDirection.GetText = "Variable" Then
            If Not ucrReceiverDegrees.IsEmpty Then
                ucrReceiverLetters.SetMeAsReceiver()
            End If
            If Not ucrReceiverLetters.IsEmpty Then
                    clsConvertToDegreeFunction.AddParameter("dir", clsRFunctionParameter:=clsGetDirVariable, iPosition:=3)
                End If
            End If
        ChangeParameter()
    End Sub

    Private Sub ChangeParameter()
        Dim clsGetDegreeVariable As RFunction = ucrReceiverDegrees.GetVariables
        Dim clsGetMinuteVariable As RFunction = ucrReceiverMinutes.GetVariables
        Dim clsGetSecondVariable As RFunction = ucrReceiverSeconds.GetVariables

        If Not ucrReceiverDegrees.IsEmpty Then
            clsConvertToDegreeFunction.AddParameter("dd", clsRFunctionParameter:=clsGetDegreeVariable, iPosition:=0)
        Else
            clsConvertToDegreeFunction.RemoveParameterByPosition(0)
        End If
        If Not ucrReceiverMinutes.IsEmpty Then
            clsConvertToDegreeFunction.AddParameter("mm", clsRFunctionParameter:=clsGetMinuteVariable, iPosition:=1)
        Else
            clsConvertToDegreeFunction.RemoveParameterByPosition(1)
        End If
        If Not ucrReceiverSeconds.IsEmpty Then
            clsConvertToDegreeFunction.AddParameter("ss", clsRFunctionParameter:=clsGetSecondVariable, iPosition:=2)
        Else
            clsConvertToDegreeFunction.RemoveParameterByPosition(2)
        End If

        If Not ucrChkVariable.Checked Then
            If Not ucrInputDegree.IsEmpty Then
                clsConvertToDegreeFunction.AddParameter("dd", ucrInputDegree.GetText, iPosition:=0)
            Else
                clsConvertToDegreeFunction.RemoveParameterByPosition(0)
            End If

            If Not ucrInputMinute.IsEmpty Then
                clsConvertToDegreeFunction.AddParameter("mm", ucrInputMinute.GetText, iPosition:=1)
            Else
                clsConvertToDegreeFunction.RemoveParameterByPosition(1)
            End If
            If Not ucrInputSecond.IsEmpty Then
                clsConvertToDegreeFunction.AddParameter("ss", ucrInputSecond.GetText, iPosition:=2)
            Else
                clsConvertToDegreeFunction.RemoveParameterByPosition(2)
            End If
            ucrBase.clsRsyntax.RemoveAssignTo()
            ucrBase.clsRsyntax.iCallType = 1
        Else
            ucrBase.clsRsyntax.iCallType = 0
        End If
        If ucrChkVariable.Checked AndAlso Not ucrInputDirection.cboInput.Items.Contains("Variable") Then
            ucrInputDirection.cboInput.Items.Add("Variable")
        ElseIf Not ucrChkVariable.Checked AndAlso ucrInputDirection.GetText = "Variable" Then
            ucrInputDirection.cboInput.Items.Remove("Variable")
            ucrInputDirection.cboInput.SelectedIndex = 0
        End If
    End Sub

    Private Sub ucrChkVariable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkVariable.ControlValueChanged
        ChangeParameter()
    End Sub

    Private Sub ucrInputDegree_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputDegree.ControlValueChanged, ucrInputMinute.ControlValueChanged, ucrInputSecond.ControlValueChanged
        ChangeParameter()
    End Sub

    Private Sub ucrReceiverDegrees_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDegrees.ControlValueChanged, ucrReceiverMinutes.ControlValueChanged, ucrReceiverSeconds.ControlValueChanged
        ChangeParameter()
    End Sub

    Private Sub ChangeLatParameter()
        'This is done since the "lat" parameter is being given by two controls (ucrReceiverLatitude and ucrInputLatitude)
        'TODO: There should be a better way to do this (setting same parameter by more than one control)
        If rdoSingleValue.Checked AndAlso ucrInputLatitude.GetText <> "" Then
            clsDayLengthFunction.AddParameter("lat", ucrInputLatitude.GetText, iPosition:=0)
        ElseIf Not rdoSingleValue.Checked AndAlso ucrInputLatitude.IsEmpty Then
            clsDayLengthFunction.RemoveParameterByPosition(0)
        End If
    End Sub

    Private Sub ucrInputLatitude_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputLatitude.ControlValueChanged, ucrPnlLatitude.ControlValueChanged
        ChangeLatParameter()
    End Sub

    Private Sub ucrPnlConversions_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlConversions.ControlContentsChanged, ucrReceiverElement.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrNudDecimal.ControlContentsChanged, ucrPnlLatitude.ControlContentsChanged, ucrInputLatitude.ControlContentsChanged, ucrReceiverLatitude.ControlContentsChanged, ucrInputFromPrecipitation.ControlContentsChanged, ucrInputToPrecipitation.ControlContentsChanged, ucrInputFromTemperature.ControlContentsChanged, ucrInputToTemperature.ControlContentsChanged, ucrInputFromWindSpeed.ControlContentsChanged, ucrInputToWindSpeed.ControlContentsChanged, ucrPnlElements.ControlContentsChanged, ucrReceiverDegrees.ControlContentsChanged, ucrChkVariable.ControlContentsChanged, ucrInputDegree.ControlContentsChanged, ucrSaveConversions.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class