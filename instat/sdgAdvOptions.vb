'R-Instat
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

Public Class sdgAdvOptions
    Public bControlsInitialised As Boolean = False

    Public clsDoFillingFunction As New RFunction
    Private clsDummyFunction As New RFunction
    Private bInitialised As Boolean = False

    Private Sub sdgAdvOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctDist As New Dictionary(Of String, String)
        ucrButtonsOptions.iHelpTopicID = 708

        'Add radio buttons to the panel and prevents them from shifting outside the panel on reopening
        If Not bInitialised Then
            ucrPnlBins.AddRadioButton(rdoAutoCalculate)
            ucrPnlBins.AddRadioButton(rdoSpecifyBins)
            ucrPnlBins.AddParameterValuesCondition(rdoAutoCalculate, "autobins", "True")
            ucrPnlBins.AddParameterValuesCondition(rdoSpecifyBins, "autobins", "False")
            bInitialised = True
        End If

        ucrPnlBins.AddToLinkedControls({ucrChkCalcByMonth, ucrNudBins}, {rdoAutoCalculate}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlBins.AddToLinkedControls(ucrInputBins, {rdoSpecifyBins}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrChkCalcByMonth.SetText("Calculate by Month")
        ucrChkCalcByMonth.AddParameterValuesCondition(True, "calc", "True")
        ucrChkCalcByMonth.AddParameterValuesCondition(False, "calc", "False")

        ucrInputBins.SetParameter(New RParameter("custom_bins", 5))
        ucrInputBins.SetValidationTypeAsNumericList()
        ucrInputBins.SetItems({"1, 3, 5, 10, 15, 20", "1.2, 4, 8, 16, 32"})
        ucrInputBins.SetName("1, 3, 5, 10, 15, 20")
        ucrInputBins.AddQuotesIfUnrecognised = False
        ucrInputBins.SetLinkedDisplayControl(lblBins)

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

        ucrNudBins.SetParameter(New RParameter("n_bins ", 10))
        ucrNudBins.SetLinkedDisplayControl(lblNumberBins)
        ucrNudBins.SetMinMax(1, Integer.MaxValue)
        ucrNudBins.SetRDefault(7)

    End Sub

    Public Sub SetRCode(clsNewDoFillingFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsDummyFunction = New RFunction

        clsDummyFunction.AddParameter("calc", "True", iPosition:=0)
        clsDummyFunction.AddParameter("autobins", "True", iPosition:=1)

        clsDoFillingFunction = clsNewDoFillingFunction

        ucrNudCount.SetRCode(clsDoFillingFunction, bReset)
        ucrNudDays.SetRCode(clsDoFillingFunction, bReset)
        ucrInputDist.SetRCode(clsDoFillingFunction, bReset)
        ucrNudBins.SetRCode(clsDoFillingFunction, bReset)
        If bReset Then
            ucrChkCalcByMonth.SetRCode(clsDummyFunction, bReset)
            ucrPnlBins.SetRCode(clsDummyFunction, bReset)
        End If

    End Sub

    Private Sub AddCustomBinsParmeter()
        If rdoSpecifyBins.Checked Then
            If Not ucrInputBins.IsEmpty Then
                clsDoFillingFunction.AddParameter("custom_bins", "c(" & ucrInputBins.GetText & ")", iPosition:=5)
            Else
                clsDoFillingFunction.RemoveParameterByName("custom_bins")
            End If
        Else
            clsDoFillingFunction.RemoveParameterByName("custom_bins")
        End If
    End Sub

    Private Sub ucrInputBins_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputBins.ControlValueChanged
        AddCustomBinsParmeter()
    End Sub

    Private Sub ucrNudCount_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudCount.ControlValueChanged
        If Not ucrNudCount.IsEmpty Then
            clsDoFillingFunction.AddParameter("count_filter", ucrNudCount.GetText, iPosition:=8)
        Else
            clsDoFillingFunction.RemoveParameterByName("count_filter")
        End If
    End Sub

    Private Sub ucrInputDist_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputDist.ControlValueChanged
        If Not ucrInputDist.IsEmpty Then
            clsDoFillingFunction.AddParameter("distribution_flag", Chr(34) & ucrInputDist.GetText & Chr(34), iPosition:=7)
        Else
            clsDoFillingFunction.RemoveParameterByName("distribution_flag")
        End If
    End Sub

    Private Sub ucrNudDays_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudDays.ControlValueChanged
        If Not ucrNudDays.IsEmpty Then
            clsDoFillingFunction.AddParameter("min_rainy_days_threshold", ucrNudDays.GetText, iPosition:=9)
        Else
            clsDoFillingFunction.RemoveParameterByName("min_rainy_days_threshold")
        End If
    End Sub

    Private Sub AddNumberOfBinsParameter()
        If rdoAutoCalculate.Checked Then
            If Not ucrNudBins.IsEmpty Then
                clsDoFillingFunction.AddParameter("n_bins", ucrNudBins.GetText, iPosition:=10)
            Else
                clsDoFillingFunction.RemoveParameterByName("n_bins")
            End If
        Else
            clsDoFillingFunction.RemoveParameterByName("n_bins")
        End If
    End Sub

    Private Sub ucrNudBins_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudBins.ControlValueChanged
        AddNumberOfBinsParameter()
    End Sub

    Private Sub AddByMonthParameter()
        If rdoAutoCalculate.Checked Then
            If ucrChkCalcByMonth.Checked Then
                clsDoFillingFunction.AddParameter("by_month", "TRUE", iPosition:=112)
            Else
                clsDoFillingFunction.RemoveParameterByName("by_month")
            End If
        Else
            clsDoFillingFunction.RemoveParameterByName("by_month")
        End If
    End Sub

    Private Sub ucrChkCalcByMonth_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCalcByMonth.ControlValueChanged
        AddByMonthParameter()
    End Sub

    Private Sub ucrPnlBins_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlBins.ControlValueChanged
        AddCustomBinsParmeter()
        AddNumberOfBinsParameter()
        AddByMonthParameter()

        ' Always add autobins with a value
        clsDoFillingFunction.RemoveParameterByName("autobins")
        clsDoFillingFunction.AddParameter("autobins", If(rdoAutoCalculate.Checked, "TRUE", "FALSE"), iPosition:=11)
    End Sub

End Class