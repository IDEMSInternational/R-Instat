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
    Private bResetSubdialog As Boolean = False
    Private clsDoFillingFunction As New RFunction
    Private clsDummyFunction As New RFunction
    Private clsBaseFunction, clsDataListFunction As New RFunction

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
        ucrInputBins.SetItems({"1, 3, 5, 10, 15, 20", "1.5, 4, 8, 16, 32"})
        ucrInputBins.AddQuotesIfUnrecognised = False

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

        ucrInputSelectStation.SetFactorReceiver(ucrReceiverStation)
        ucrInputSelectStation.strQuotes = ""
    End Sub

    Private Sub SetDefaults()
        clsDoFillingFunction = New RFunction
        clsDummyFunction = New RFunction
        clsBaseFunction = New RFunction
        clsDataListFunction = New RFunction

        ucrSelectorOutfilling.Reset()
        ucrInputSelectStation.bFirstLevelDefault = True
        ucrInputBins.Reset()
        ucrReceiverStation.SetMeAsReceiver()

        ucrInputBins.SetName("1, 3, 5, 10, 15, 20")

        clsDummyFunction.AddParameter("omit", "False", iPosition:=0)

        clsDoFillingFunction.SetPackageName("outfillingR")
        clsDoFillingFunction.SetRCommand("do_infilling")
        clsDoFillingFunction.SetAssignTo("infill_data")
        clsDoFillingFunction.AddParameter("markovflag", "TRUE", iPosition:=6)

        clsDataListFunction.SetRCommand("list")
        clsDataListFunction.AddParameter("infilled_data", clsRFunctionParameter:=clsDoFillingFunction, iPosition:=0)

        clsBaseFunction.SetRCommand("data_book$import_data")
        clsBaseFunction.AddParameter("data_tables", clsRFunctionParameter:=clsDataListFunction, iPosition:=0)

        ucrBase.clsRsyntax.SetBaseRFunction(clsBaseFunction)

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrChkOmitMonths.SetRCode(clsDummyFunction, bReset)
        ucrSelectorOutfilling.SetRCode(clsDoFillingFunction, bReset)
        ucrReceiverDate.SetRCode(clsDoFillingFunction, bReset)
        ucrReceiverEstimates.SetRCode(clsDoFillingFunction, bReset)
        ucrReceiverLatitude.SetRCode(clsDoFillingFunction, bReset)
        ucrReceiverLongitude.SetRCode(clsDoFillingFunction, bReset)
        ucrReceiverRain.SetRCode(clsDoFillingFunction, bReset)
        ucrNudCount.SetRCode(clsDoFillingFunction, bReset)
        ucrNudDays.SetRCode(clsDoFillingFunction, bReset)
        ucrInputDist.SetRCode(clsDoFillingFunction, bReset)
        ucrInputMarkov.SetRCode(clsDoFillingFunction, bReset)
        ucrReceiverStation.SetRCode(clsDoFillingFunction, bReset)
        ucrInputSelectStation.SetRCode(clsDoFillingFunction, bReset)
        UpdateVisibility()
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
          Not ucrInputDist.IsEmpty AndAlso
          Not ucrInputMarkov.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrChkOmitMonths_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOmitMonths.ControlValueChanged
        UpdateVisibility()
    End Sub

    Private Sub UpdateVisibility()
        cmdOmitMonths.Visible = ucrChkOmitMonths.Checked
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
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverEstimates_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverEstimates.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverLatitude.ControlContentsChanged,
            ucrReceiverLongitude.ControlContentsChanged, ucrReceiverRain.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged, ucrInputBins.ControlContentsChanged,
            ucrInputDist.ControlContentsChanged, ucrInputMarkov.ControlContentsChanged, ucrNudCount.ControlContentsChanged, ucrNudDays.ControlContentsChanged
        TestOkEnabled()
    End Sub

    'Private Sub cmdOmitMonths_Click(sender As Object, e As EventArgs) Handles cmdOmitMonths.Click
    '    sdgSelectMonth.ShowDialog()
    '    bResetSubdialog = True
    'End Sub

    Private Sub ucrInputSelectStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSelectStation.ControlValueChanged, ucrReceiverStation.ControlValueChanged
        If Not ucrReceiverStation.IsEmpty AndAlso Not ucrInputSelectStation.IsEmpty Then
            clsDoFillingFunction.AddParameter("station_to_exclude ", Chr(34) & ucrInputSelectStation.GetValue() & Chr(34), iPosition:=10)

        Else
            clsDoFillingFunction.RemoveParameterByName("station_to_exclude")
        End If
    End Sub
End Class