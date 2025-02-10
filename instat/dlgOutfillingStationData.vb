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

Public Class dlgOutfillingStationData
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog = False
    Private clsDoFillingFunction As New RFunction
    Private clsDummyFunction As New RFunction

    Private Sub dlgOutfillingStationData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim dctLogical As New Dictionary(Of String, String)
        Dim dctDist As New Dictionary(Of String, String)

        ucrSelectorOutfilling.SetParameter(New RParameter("data", 0))
        ucrSelectorOutfilling.SetParameterIsrfunction()

        ucrReceiverStation.SetParameter(New RParameter("station", 1))
        ucrReceiverStation.Selector = ucrSelectorOutfilling
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.SetLinkedDisplayControl(lblStation)

        ucrReceiverDate.SetParameter(New RParameter("date", 2))
        ucrReceiverDate.Selector = ucrSelectorOutfilling
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.SetLinkedDisplayControl(lblDate)

        ucrReceiverRain.SetParameter(New RParameter("rainfall", 3))
        ucrReceiverRain.Selector = ucrSelectorOutfilling
        ucrReceiverRain.SetParameterIsString()
        ucrReceiverRain.SetClimaticType("rain")
        ucrReceiverRain.bAutoFill = True
        ucrReceiverRain.SetLinkedDisplayControl(lblRain)

        ucrReceiverEstimates.SetParameter(New RParameter("rainfall_estimate_column", 4))
        ucrReceiverEstimates.Selector = ucrSelectorOutfilling
        ucrReceiverEstimates.SetParameterIsString()
        ucrReceiverEstimates.SetLinkedDisplayControl(lblEstimates)

        ucrReceiverLongitude.SetParameter(New RParameter("lon", 5))
        ucrReceiverLongitude.Selector = ucrSelectorOutfilling
        ucrReceiverLongitude.SetParameterIsString()
        ucrReceiverLongitude.SetClimaticType("lon")
        ucrReceiverLongitude.bAutoFill = True
        ucrReceiverLongitude.SetLinkedDisplayControl(lblLong)

        ucrReceiverLatitude.SetParameter(New RParameter("lat", 6))
        ucrReceiverLatitude.Selector = ucrSelectorOutfilling
        ucrReceiverLatitude.SetParameterIsString()
        ucrReceiverLatitude.SetClimaticType("lat")
        ucrReceiverLatitude.bAutoFill = True
        ucrReceiverLatitude.SetLinkedDisplayControl(lblLatitude)

        ucrInputBins.SetParameter(New RParameter("custom_bins", 5))
        ucrInputBins.SetValidationTypeAsNumericList()
        ucrInputBins.SetItems({"1, 3, 5, 10, 15, 20", "1.2, 4, 8, 16, 32"})
        ucrInputBins.AddQuotesIfUnrecognised = False

        ucrInputOmitMonths.SetParameter(New RParameter("target_months", 10))
        ucrInputOmitMonths.SetValidationTypeAsNumericList()
        ucrInputOmitMonths.SetItems({"5,6,7,8,9", "1, 2, 3, 11, 12", "1,2,12"})
        ucrInputOmitMonths.AddQuotesIfUnrecognised = False

        ucrInputMarkov.SetParameter(New RParameter("markovflag", 6))
        dctLogical.Add("TRUE", "TRUE")
        dctLogical.Add("FALSE", "FALSE")
        ucrInputMarkov.SetItems(dctLogical)
        ucrInputMarkov.SetDropDownStyleAsNonEditable()

        ucrInputDist.SetParameter(New RParameter("distribution_flag", 7))
        dctDist.Add("gamma", Chr(34) & "gamma" & Chr(34))
        dctDist.Add("lognormal", Chr(34) & "lognormal" & Chr(34))
        ucrInputDist.SetItems(dctDist)
        ucrInputDist.SetRDefault(Chr(34) & "gamma" & Chr(34))
        ucrInputDist.SetDropDownStyleAsNonEditable()

        ucrNudCount.SetParameter(New RParameter("count_filter", 8))
        ucrNudCount.SetLinkedDisplayControl(lblCount)
        ucrNudCount.SetMinMax(1, Integer.MaxValue)
        ucrNudCount.SetRDefault(10)

        ucrNudDays.SetParameter(New RParameter("min_rainy_days_threshold", 9))
        ucrNudDays.SetLinkedDisplayControl(lblDays)
        ucrNudDays.SetMinMax(1, Integer.MaxValue)
        ucrNudDays.SetRDefault(50)

        ucrChkOmitMonths.SetText("Dry Month(s)")
        ucrChkOmitMonths.AddParameterValuesCondition(True, "omit", "True")
        ucrChkOmitMonths.AddParameterValuesCondition(False, "omit", "False")
        ucrChkOmitMonths.AddToLinkedControls({ucrInputOmitMonths}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkStationToExclude.SetText("Station(s) to Exclude")
        ucrChkStationToExclude.AddParameterValuesCondition(True, "exclude", "True")
        ucrChkStationToExclude.AddParameterValuesCondition(False, "exclude", "False")
        'ucrChkStationToExclude.AddToLinkedControls({ucrInputSelectStation}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrNudRandomSeed.SetParameter(New RParameter("set_seed", 10))
        ucrNudRandomSeed.SetMinMax(1, Integer.MaxValue)

        ucrChkRandomSeed.SetText("Random Seed")
        ucrChkRandomSeed.AddParameterValuesCondition(True, "seed", "True")
        ucrChkRandomSeed.AddParameterValuesCondition(False, "seed", "False")
        ucrChkRandomSeed.AddToLinkedControls({ucrNudRandomSeed}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=999)

        ucrSaveColumn.SetSaveTypeAsColumn()
        ucrSaveColumn.SetDataFrameSelector(ucrSelectorOutfilling.ucrAvailableDataFrames)
        ucrSaveColumn.SetLabelText("Prefix for New Columns:")
        ucrSaveColumn.SetIsComboBox()

        'ucrSaveColumn.setLinkedReceiver(ucrReceiverSplitTextColumn)
    End Sub

    Private Sub SetDefaults()
        clsDoFillingFunction = New RFunction
        clsDummyFunction = New RFunction

        ucrSelectorOutfilling.Reset()
        ucrInputBins.Reset()
        ucrReceiverStation.SetMeAsReceiver()

        ucrSaveColumn.Reset()

        bResetSubdialog = True

        ucrInputBins.SetName("1, 3, 5, 10, 15, 20")
        ucrInputOmitMonths.SetName("5,6,7,8,9")

        clsDummyFunction.AddParameter("omit", "False", iPosition:=0)
        clsDummyFunction.AddParameter("exclude", "False", iPosition:=1)
        clsDummyFunction.AddParameter("seed", "False", iPosition:=2)

        clsDoFillingFunction.SetPackageName("outfillingR")
        clsDoFillingFunction.SetRCommand("do_infilling")
        clsDoFillingFunction.SetAssignTo("infill_data")
        clsDoFillingFunction.AddParameter("markovflag", "TRUE", iPosition:=6)

        clsDoFillingFunction.SetAssignTo(ucrSaveColumn.GetText(), strTempDataframe:=ucrSelectorOutfilling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveColumn.GetText())

        ucrBase.clsRsyntax.SetBaseRFunction(clsDoFillingFunction)
        'ucrBase.clsRsyntax.SetAssignTo(ucrSaveResultInto.GetText(), strTempColumn:=ucrSaveResultInto.GetText(),
        '                                  strTempDataframe:=ucrSelectorOutfilling.ucrAvailableDataFrames.cboAvailableDataFrames.Text,
        '                                  bAssignToIsPrefix:=ucrBase.clsRsyntax.clsBaseCommandString.bAssignToIsPrefix,
        '                                  bAssignToColumnWithoutNames:=ucrBase.clsRsyntax.clsBaseCommandString.bAssignToColumnWithoutNames,
        '                                  bInsertColumnBefore:=ucrBase.clsRsyntax.clsBaseCommandString.bInsertColumnBefore,
        '                                  bRequireCorrectLength:=ucrBase.clsRsyntax.clsBaseCommandString.bRequireCorrectLength)

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrChkOmitMonths.SetRCode(clsDummyFunction, bReset)
        ucrChkStationToExclude.SetRCode(clsDummyFunction, bReset)
        ucrChkRandomSeed.SetRCode(clsDummyFunction, bReset)
        ucrSelectorOutfilling.SetRCode(clsDoFillingFunction, bReset)
        ucrReceiverDate.SetRCode(clsDoFillingFunction, bReset)
        ucrReceiverEstimates.SetRCode(clsDoFillingFunction, bReset)
        ucrReceiverLatitude.SetRCode(clsDoFillingFunction, bReset)
        ucrReceiverLongitude.SetRCode(clsDoFillingFunction, bReset)
        ucrReceiverRain.SetRCode(clsDoFillingFunction, bReset)
        ucrNudCount.SetRCode(clsDoFillingFunction, bReset)
        ucrNudDays.SetRCode(clsDoFillingFunction, bReset)
        ucrNudRandomSeed.SetRCode(clsDoFillingFunction, bReset)
        ucrInputDist.SetRCode(clsDoFillingFunction, bReset)
        ucrInputMarkov.SetRCode(clsDoFillingFunction, bReset)
        ucrReceiverStation.SetRCode(clsDoFillingFunction, bReset)
        ucrSaveColumn.SetRCode(clsDoFillingFunction, bReset)
        AddTargetMonthsVar()
        FilterFactorsVisibility()
        If bReset Then
            ucrChkStationToExclude.SetRCode(clsDummyFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverStation.IsEmpty AndAlso
          Not ucrReceiverEstimates.IsEmpty AndAlso
          Not ucrReceiverDate.IsEmpty AndAlso
          Not ucrReceiverLatitude.IsEmpty AndAlso
          Not ucrReceiverLongitude.IsEmpty AndAlso
          Not ucrReceiverRain.IsEmpty AndAlso
          Not ucrNudCount.IsEmpty AndAlso
          Not ucrNudDays.IsEmpty AndAlso
          Not ucrInputBins.IsEmpty AndAlso
          ucrSaveColumn.IsComplete() AndAlso
          Not ucrInputDist.IsEmpty AndAlso
          Not ucrInputMarkov.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrChkOmitMonths_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOmitMonths.ControlValueChanged
        AddTargetMonthsVar()
    End Sub

    Private Sub AddTargetMonthsVar()
        If ucrChkOmitMonths.Checked AndAlso Not ucrInputOmitMonths.IsEmpty Then
            clsDoFillingFunction.AddParameter("target_months", "c(" & ucrInputOmitMonths.GetText & ")", iPosition:=10)
            clsDummyFunction.AddParameter("omit", "True", iPosition:=0)
        Else
            clsDoFillingFunction.RemoveParameterByName("target_months")
            clsDummyFunction.AddParameter("omit", "False", iPosition:=0)
        End If
    End Sub

    Private Sub ucrInputBins_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputBins.ControlValueChanged
        If Not ucrInputBins.IsEmpty Then
            clsDoFillingFunction.AddParameter("custom_bins", "c(" & ucrInputBins.GetText & ")", iPosition:=5)
        Else
            clsDoFillingFunction.RemoveParameterByName("custom_bins")
        End If
    End Sub

    Private Sub ucrNudCount_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudCount.ControlValueChanged
        If Not ucrNudCount.IsEmpty Then
            clsDoFillingFunction.AddParameter("count_filter", ucrNudCount.GetText, iPosition:=8)
        Else
            clsDoFillingFunction.RemoveParameterByName("count_filter")
        End If
    End Sub

    Private Sub ucrNudDays_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudDays.ControlValueChanged
        If Not ucrNudDays.IsEmpty Then
            clsDoFillingFunction.AddParameter("min_rainy_days_threshold", ucrNudDays.GetText, iPosition:=9)
        Else
            clsDoFillingFunction.RemoveParameterByName("min_rainy_days_threshold")
        End If
    End Sub

    Private Sub ucrInputDist_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputDist.ControlValueChanged
        If Not ucrInputDist.IsEmpty Then
            clsDoFillingFunction.AddParameter("distribution_flag", Chr(34) & ucrInputDist.GetText & Chr(34), iPosition:=7)
        Else
            clsDoFillingFunction.RemoveParameterByName("distribution_flag")
        End If
    End Sub

    Private Sub ucrInputMarkov_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputMarkov.ControlValueChanged
        If Not ucrInputMarkov.IsEmpty Then
            clsDoFillingFunction.AddParameter("markovflag", ucrInputMarkov.GetText, iPosition:=6)
        Else
            clsDoFillingFunction.RemoveParameterByName("markovflag")
        End If
    End Sub

    Private Sub ucrReceiverEstimates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverEstimates.ControlValueChanged
        If Not ucrReceiverEstimates.IsEmpty Then
            clsDoFillingFunction.AddParameter("rfe", ucrReceiverEstimates.GetVariableNames, iPosition:=10)
        Else
            clsDoFillingFunction.RemoveParameterByName("rfe")
        End If
        SetDataFramePrefix()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverEstimates_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverEstimates.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverLatitude.ControlContentsChanged,
            ucrReceiverLongitude.ControlContentsChanged, ucrReceiverRain.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged, ucrInputBins.ControlContentsChanged,
            ucrInputDist.ControlContentsChanged, ucrInputMarkov.ControlContentsChanged, ucrNudCount.ControlContentsChanged, ucrNudDays.ControlContentsChanged, ucrSaveColumn.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrInputOmitMonths_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputOmitMonths.ControlValueChanged
        AddTargetMonthsVar()
    End Sub

    Private Sub ucrNudRandomSeed_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudRandomSeed.ControlValueChanged, ucrChkRandomSeed.ControlValueChanged
        If ucrChkRandomSeed.Checked AndAlso Not ucrNudRandomSeed.IsEmpty Then
            clsDoFillingFunction.AddParameter("set_seed", ucrNudRandomSeed.GetText, iPosition:=10)
            clsDummyFunction.AddParameter("seed", "True", iPosition:=2)
        Else
            clsDoFillingFunction.RemoveParameterByName("set_seed")
            clsDummyFunction.AddParameter("seed", "False", iPosition:=2)
        End If
    End Sub

    Private Sub cmdFilterFromFactors_Click(sender As Object, e As EventArgs) Handles cmdFilterFromFactors.Click
        ' Ensure the dataframe and parameters are set before showing the dialog
        sdgFiltersFromFactor.SetRcodeAndDefaultDataFrame(ucrSelectorOutfilling, bReset:=bResetSubdialog)
        sdgFiltersFromFactor.ShowDialog()

        ' Retrieve the selected stations and add them to the main function
        Dim strSelectedStations As String = sdgFiltersFromFactor.GetSelectedStations()

        If strSelectedStations <> "" Then
            clsDoFillingFunction.AddParameter("stations_to_include", strSelectedStations)
        Else
            clsDoFillingFunction.RemoveParameterByName("stations_to_include")
        End If

        bResetSubdialog = False
    End Sub

    Private Sub ucrChkStationToExclude_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkStationToExclude.ControlValueChanged
        FilterFactorsVisibility()
    End Sub

    Private Sub FilterFactorsVisibility()
        cmdFilterFromFactors.Visible = ucrChkStationToExclude.Checked
    End Sub

    Private Sub SetDataFramePrefix()
        Dim strDataframeName As String = ucrReceiverEstimates.GetVariableNames(False)
        If strDataframeName = "" OrElse ucrSaveColumn.bUserTyped Then
            Exit Sub
        End If
        If Not ucrReceiverEstimates.IsEmpty Then
            ucrSaveColumn.SetPrefix(strDataframeName & "_")

        End If
    End Sub

End Class