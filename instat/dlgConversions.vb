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

    Private dctRainUnits As New Dictionary(Of String, String)
    Private dctTemperatureUnits As New Dictionary(Of String, String)
    Private dctWindSpeedUnits As New Dictionary(Of String, String)

    Private clsConversionFunction As New RFunction
    Private clsDayLengthFunction As New RFunction

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

        ucrPnlConversions.AddRadioButton(rdoUnits)
        ucrPnlConversions.AddRadioButton(rdoDayLength)

        ucrPnlConversions.AddFunctionNamesCondition(rdoUnits, {"convert_precip", "convert_temperature", "convert_wind_speed"})
        ucrPnlConversions.AddFunctionNamesCondition(rdoDayLength, "daylength")

        ucrPnlLatitude.AddRadioButton(rdoValue)
        ucrPnlLatitude.AddRadioButton(rdoVariable)

        ucrReceiverElement.SetParameter(New RParameter("precip", 0, False))
        ucrReceiverElement.bWithQuotes = False
        ucrReceiverElement.SetParameterIsRFunction()
        ucrReceiverElement.Selector = ucrSelectorConversions

        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Station Variables"
        ucrReceiverStation.Selector = ucrSelectorConversions

        ucrReceiverDate.SetParameter(New RParameter("doy", 1))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorConversions

        'ucrReceiverLatitude.SetParameter(New RParameter("lat", 0))
        ucrReceiverLatitude.bWithQuotes = False
        ucrReceiverLatitude.SetParameterIsRFunction()
        ucrReceiverLatitude.Selector = ucrSelectorConversions

        'ucrInputLatitude.SetParameter(New RParameter("lat", 0))
        ucrInputLatitude.SetValidationTypeAsRVariable()

        ucrInputElement.SetItems({"Rains", "Temperature", "Wind Speed"})
        ucrInputElement.SetDropDownStyleAsNonEditable()
        ucrInputElement.SetName("Rains")

        ucrInputFrom.SetParameter(New RParameter("old_metric", 1))
        ucrInputFrom.SetDropDownStyleAsNonEditable()

        ucrInputTo.SetParameter(New RParameter("new_metric", 2))
        ucrInputTo.SetDropDownStyleAsNonEditable()

        dctRainUnits.Add("Inches", Chr(34) & "inches" & Chr(34))
        dctRainUnits.Add("mm", Chr(34) & "mm" & Chr(34))
        dctRainUnits.Add("cm", Chr(34) & "cm" & Chr(34))

        ucrInputTo.SetItems(dctRainUnits)
        ucrInputTo.SetRDefault("mm")
        ucrInputFrom.SetItems(dctRainUnits)
        ucrInputFrom.SetRDefault("mm")

        'dctTemperatureUnits.Add("Celsius", Chr(34) & "celsius" & Chr(34))
        'dctTemperatureUnits.Add("Fahrenheit", Chr(34) & "fahrenheit" & Chr(34))
        'dctTemperatureUnits.Add("Kelvin", Chr(34) & "kelvin" & Chr(34))

        'dctWindSpeedUnits.Add("knots: Knots", Chr(34) & "knots" & Chr(34))
        'dctWindSpeedUnits.Add("mph: Miles per hour", Chr(34) & "mph" & Chr(34))
        'dctWindSpeedUnits.Add("mps: Meters per second", Chr(34) & "mps" & Chr(34))
        'dctWindSpeedUnits.Add("ftps: Feet per second", Chr(34) & "ftps" & Chr(34))
        'dctWindSpeedUnits.Add("kmph: Kilometers per hour", Chr(34) & "kmph" & Chr(34))

        ucrNudDecimal.SetParameter(New RParameter("round", 3))
        ucrNudDecimal.SetMinMax(0, 3)

        ucrPnlConversions.AddToLinkedControls(ucrReceiverElement, {rdoUnits}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlConversions.AddToLinkedControls(ucrInputElement, {rdoUnits}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlConversions.AddToLinkedControls(ucrInputFrom, {rdoUnits}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlConversions.AddToLinkedControls(ucrInputTo, {rdoUnits}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlConversions.AddToLinkedControls(ucrNudDecimal, {rdoUnits}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=1)

        ucrPnlConversions.AddToLinkedControls(ucrReceiverStation, {rdoDayLength}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlConversions.AddToLinkedControls(ucrReceiverDate, {rdoDayLength}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlConversions.AddToLinkedControls(ucrPnlLatitude, {rdoDayLength}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlLatitude.AddToLinkedControls(ucrInputLatitude, {rdoValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlLatitude.AddToLinkedControls(ucrReceiverLatitude, {rdoVariable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverElement.SetLinkedDisplayControl(lblElement)
        ucrInputElement.SetLinkedDisplayControl(lblElementName)
        ucrInputFrom.SetLinkedDisplayControl(lblFrom)
        ucrInputTo.SetLinkedDisplayControl(lblTo)
        ucrNudDecimal.SetLinkedDisplayControl(lblDecimal)
        ucrInputLatitude.SetLinkedDisplayControl(lblDecimalValue)
        ucrReceiverStation.SetLinkedDisplayControl(lblStation)
        ucrReceiverDate.SetLinkedDisplayControl(lblDate)

        ucrSaveConversions.SetPrefix("Conversion")
        ucrSaveConversions.SetIsComboBox()
        ucrSaveConversions.SetCheckBoxText("Result into:")
        ucrSaveConversions.SetSaveTypeAsColumn()
        ucrSaveConversions.SetDataFrameSelector(ucrSelectorConversions.ucrAvailableDataFrames)
        ucrSaveConversions.SetAssignToIfUncheckedValue("")
    End Sub

    Private Sub SetDefaults()
        clsConversionFunction = New RFunction

        ucrSelectorConversions.Reset()
        ucrSaveConversions.Reset()
        ucrReceiverElement.SetMeAsReceiver()

        clsConversionFunction.SetPackageName("weathermetrics")
        clsConversionFunction.SetRCommand("convert_precip")

        clsDayLengthFunction.SetPackageName("geosphere")
        clsDayLengthFunction.SetRCommand("daylength")

        ucrBase.clsRsyntax.SetBaseRFunction(clsConversionFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        'ucrReceiverElement.AddAdditionalCodeParameterPair(clsTempFunction, (New RParameter("temperature", 0)), iAdditionalPairNo:=1)
        'ucrReceiverElement.AddAdditionalCodeParameterPair(clsWindSpeedFunction, (New RParameter("wind_speed", 0)), iAdditionalPairNo:=1)
        'ucrInputFrom.AddAdditionalCodeParameterPair(clsTempFunction, (New RParameter("old_metric", 1)), iAdditionalPairNo:=1)
        'ucrInputFrom.AddAdditionalCodeParameterPair(clsWindSpeedFunction, (New RParameter("old_metric", 1)), iAdditionalPairNo:=1)
        'ucrInputTo.AddAdditionalCodeParameterPair(clsTempFunction, (New RParameter("new_metric", 2)), iAdditionalPairNo:=1)
        'ucrInputTo.AddAdditionalCodeParameterPair(clsWindSpeedFunction, (New RParameter("new_metric", 2)), iAdditionalPairNo:=1)
        'ucrNudDecimal.AddAdditionalCodeParameterPair(clsTempFunction, (New RParameter("round", 3)), iAdditionalPairNo:=1)
        'ucrNudDecimal.AddAdditionalCodeParameterPair(clsWindSpeedFunction, (New RParameter("round", 3)), iAdditionalPairNo:=1)

        ucrReceiverElement.SetRCode(clsConversionFunction, bReset)
        ucrInputFrom.SetRCode(clsConversionFunction, bReset)
        ucrInputTo.SetRCode(clsConversionFunction, bReset)
        ucrNudDecimal.SetRCode(clsConversionFunction, bReset)

        ucrReceiverDate.SetRCode(clsDayLengthFunction, bReset)
        ucrReceiverLatitude.SetRCode(clsDayLengthFunction, bReset)
        ucrInputLatitude.SetRCode(clsDayLengthFunction, bReset)

    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub ucrInputElement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputElement.ControlValueChanged
        ClimaticElement()
    End Sub

    Private Sub ucrInputFrom_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputFrom.ControlValueChanged, ucrInputTo.ControlValueChanged
        ClimaticElement()
    End Sub

    Private Sub ClimaticElement()

        Select Case ucrInputElement.GetText()

            Case ucrInputElement.GetText = "Rains"
                clsConversionFunction.SetRCommand("convert_precip")
                ucrReceiverElement.ChangeParameterName("precip")
                ucrInputFrom.SetItems(dctRainUnits)
                ucrInputTo.SetItems(dctRainUnits)

            Case ucrInputElement.GetText = "Temperature"
                clsConversionFunction.SetRCommand("convert_temperature")
                ucrReceiverElement.ChangeParameterName("temperature")
                ucrInputFrom.SetItems(dctTemperatureUnits)
                ucrInputTo.SetItems(dctTemperatureUnits)

            Case ucrInputElement.GetText = "Wind Speed"
                clsConversionFunction.SetRCommand("convert_wind_speed")
                ucrReceiverElement.ChangeParameterName("wind_speed")
                ucrInputFrom.SetItems(dctWindSpeedUnits)
                ucrInputTo.SetItems(dctWindSpeedUnits)
        End Select
    End Sub

    Private Sub LatOptions()
        If rdoValue.Checked Then
            clsDayLengthFunction.AddParameter("lat", Chr(34) & ucrInputLatitude.GetText & Chr(34), iPosition:=0)
        ElseIf rdoVariable.Checked Then
            ucrReceiverLatitude.SetMeAsReceiver()
            clsDayLengthFunction.AddParameter("lat", Chr(34) & ucrReceiverLatitude.GetVariableNames & Chr(34), iPosition:=0)
        End If
    End Sub

    Private Sub ucrPnlLatitude_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlLatitude.ControlValueChanged
        LatOptions()
    End Sub

    Private Sub ucrReceiverLatitude_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLatitude.ControlValueChanged, ucrInputLatitude.ControlValueChanged
        LatOptions()
    End Sub
End Class