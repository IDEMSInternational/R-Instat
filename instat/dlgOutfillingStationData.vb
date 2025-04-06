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
    Public clsDoFillingFunction As New RFunction
    Private clsDummyFunction As New RFunction
    Private clsSelectFunction, clsSelectFunction2 As New RFunction

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
        EnsureSaveResultsChecked()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        Dim dctLogical As New Dictionary(Of String, String)
        ucrBase.iHelpTopicID = 489

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

        ucrInputOmitMonths.SetParameter(New RParameter("target_months", 10))
        ucrInputOmitMonths.SetValidationTypeAsNumericList()
        ucrInputOmitMonths.SetItems({"5,6,7,8,9", "1, 2, 3, 11, 12", "1,2,12"})
        ucrInputOmitMonths.AddQuotesIfUnrecognised = False

        ucrInputMarkov.SetParameter(New RParameter("markovflag", 6))
        dctLogical.Add("TRUE", "TRUE")
        dctLogical.Add("FALSE", "FALSE")
        ucrInputMarkov.SetItems(dctLogical)
        ucrInputMarkov.SetDropDownStyleAsNonEditable()

        ucrChkOmitMonths.SetText("Dry Month(s)")
        ucrChkOmitMonths.AddParameterValuesCondition(True, "omit", "True")
        ucrChkOmitMonths.AddParameterValuesCondition(False, "omit", "False")
        ucrChkOmitMonths.AddToLinkedControls({ucrInputOmitMonths}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkStationToExclude.SetText("Stations")
        ucrChkStationToExclude.AddParameterValuesCondition(True, "exclude", "True")
        ucrChkStationToExclude.AddParameterValuesCondition(False, "exclude", "False")

        ucrNudRandomSeed.SetParameter(New RParameter("set_seed", 10))
        ucrNudRandomSeed.SetMinMax(1, Integer.MaxValue)

        ucrChkRandomSeed.SetText("Random Seed")
        ucrChkRandomSeed.AddParameterValuesCondition(True, "seed", "True")
        ucrChkRandomSeed.AddParameterValuesCondition(False, "seed", "False")
        ucrChkRandomSeed.AddToLinkedControls({ucrNudRandomSeed}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=999)

        ucrSaveResultEst.SetSaveTypeAsColumn()
        ucrSaveResultEst.SetIsComboBox()
        ucrSaveResultEst.SetCheckBoxText("Estimated")
        ucrSaveResultEst.SetDataFrameSelector(ucrSelectorOutfilling.ucrAvailableDataFrames)
        ucrSaveResultEst.setLinkedReceiver(ucrReceiverEstimates)

        ucrSaveResultGen.SetSaveTypeAsColumn()
        ucrSaveResultGen.SetIsComboBox()
        ucrSaveResultGen.SetCheckBoxText("Outfilled")
        ucrSaveResultGen.SetDataFrameSelector(ucrSelectorOutfilling.ucrAvailableDataFrames)
        ucrSaveResultGen.setLinkedReceiver(ucrReceiverEstimates)
    End Sub

    Private Sub SetDefaults()
        clsDoFillingFunction = New RFunction
        clsDummyFunction = New RFunction
        clsSelectFunction = New RFunction
        clsSelectFunction2 = New RFunction

        ucrSelectorOutfilling.Reset()
        ucrReceiverStation.SetMeAsReceiver()
        EnsureSaveResultsChecked()
        ucrSaveResultEst.Reset()

        ucrSaveResultGen.Reset()

        bResetSubdialog = True

        ucrInputOmitMonths.SetName("5,6,7,8,9")

        clsDummyFunction.AddParameter("omit", "False", iPosition:=0)
        clsDummyFunction.AddParameter("exclude", "False", iPosition:=1)
        clsDummyFunction.AddParameter("seed", "False", iPosition:=2)

        clsDoFillingFunction.SetPackageName("outfillingR")
        clsDoFillingFunction.SetRCommand("do_infilling")
        clsDoFillingFunction.SetAssignTo("infill_data")
        clsDoFillingFunction.AddParameter("markovflag", "TRUE", iPosition:=6)
        clsDoFillingFunction.SetAssignTo("outfilled_data")

        clsSelectFunction.SetPackageName("dplyr")
        clsSelectFunction.SetRCommand("select")
        clsSelectFunction.AddParameter("est", clsRFunctionParameter:=clsDoFillingFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsSelectFunction.AddParameter("gen", Chr(34) & "generated_rainfall" & Chr(34), bIncludeArgumentName:=False, iPosition:=1)

        clsSelectFunction2.SetPackageName("dplyr")
        clsSelectFunction2.SetRCommand("select")
        clsSelectFunction2.AddParameter("out", "outfilled_data", bIncludeArgumentName:=False, iPosition:=0)
        clsSelectFunction2.AddParameter("filled", Chr(34) & "outfilled_rainfall" & Chr(34), bIncludeArgumentName:=False, iPosition:=1)

        ucrBase.clsRsyntax.AddToAfterCodes(clsSelectFunction, 0)
        ucrBase.clsRsyntax.AddToAfterCodes(clsSelectFunction2, 1)

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrChkOmitMonths.SetRCode(clsDummyFunction, bReset)
        ucrChkRandomSeed.SetRCode(clsDummyFunction, bReset)
        ucrSelectorOutfilling.SetRCode(clsDoFillingFunction, bReset)
        ucrReceiverDate.SetRCode(clsDoFillingFunction, bReset)
        ucrReceiverEstimates.SetRCode(clsDoFillingFunction, bReset)
        ucrReceiverLatitude.SetRCode(clsDoFillingFunction, bReset)
        ucrReceiverLongitude.SetRCode(clsDoFillingFunction, bReset)
        ucrReceiverRain.SetRCode(clsDoFillingFunction, bReset)
        ucrNudRandomSeed.SetRCode(clsDoFillingFunction, bReset)
        ucrInputMarkov.SetRCode(clsDoFillingFunction, bReset)
        ucrReceiverStation.SetRCode(clsDoFillingFunction, bReset)
        ucrSaveResultEst.SetRCode(clsSelectFunction, bReset)
        ucrSaveResultGen.SetRCode(clsSelectFunction2, bReset)
        AddTargetMonthsVar()
        FilterFactorsVisibility()
        ucrChkStationToExclude.SetRCode(clsDummyFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverStation.IsEmpty AndAlso
       Not ucrReceiverEstimates.IsEmpty AndAlso
       Not ucrReceiverDate.IsEmpty AndAlso
       Not ucrReceiverLatitude.IsEmpty AndAlso
       Not ucrReceiverLongitude.IsEmpty AndAlso
       Not ucrReceiverRain.IsEmpty AndAlso
       (Not ucrChkStationToExclude.Checked OrElse (ucrChkStationToExclude.Checked AndAlso sdgFiltersFromFactor.GetSelectedStations() <> "")) AndAlso
       (ucrSaveResultEst.ucrChkSave.Checked AndAlso ucrSaveResultEst.IsComplete()) AndAlso
       (ucrSaveResultGen.ucrChkSave.Checked AndAlso ucrSaveResultGen.IsComplete()) AndAlso
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
            ucrReceiverLongitude.ControlContentsChanged, ucrReceiverRain.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged, ucrChkStationToExclude.ControlContentsChanged, ucrInputMarkov.ControlContentsChanged, ucrSaveResultGen.ControlContentsChanged, ucrSaveResultEst.ControlContentsChanged
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

        sdgFiltersFromFactor.enumFactorMode = sdgFiltersFromFactor.FactorMode.OutFilling
        sdgFiltersFromFactor.ShowDialog()

        ' Retrieve the selected stations and add them to the main function
        Dim strSelectedStations As String = sdgFiltersFromFactor.GetSelectedStations()

        If strSelectedStations <> "" Then
            clsDoFillingFunction.AddParameter("stations_to_include", strSelectedStations)
        Else
            clsDoFillingFunction.RemoveParameterByName("stations_to_include")
        End If
        TestOkEnabled()
        bResetSubdialog = False
    End Sub

    Private Sub ucrChkStationToExclude_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkStationToExclude.ControlValueChanged
        FilterFactorsVisibility()
        If ucrChkStationToExclude.Checked Then
            clsDummyFunction.AddParameter("exclude", "True", iPosition:=1)

        Else
            clsDummyFunction.AddParameter("exclude", "False", iPosition:=1)

        End If
    End Sub

    Private Sub FilterFactorsVisibility()
        cmdFilterFromFactors.Visible = ucrChkStationToExclude.Checked
    End Sub

    Private Sub EnsureSaveResultsChecked()
        ucrSaveResultEst.ucrChkSave.Checked = True
        ucrSaveResultGen.ucrChkSave.Checked = True
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgAdvOptions.SetRCode(clsNewDoFillingFunction:=clsDoFillingFunction, bReset:=bResetSubdialog)
        sdgAdvOptions.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub SetDataFramePrefix()
        Dim strDataframeName As String = ucrReceiverEstimates.GetVariableNames(False)
        Dim strDataframeNameGen As String = ucrReceiverEstimates.GetVariableNames(False)

        If Not ucrReceiverEstimates.IsEmpty Then
            If ucrSaveResultEst.ucrChkSave.Checked Then
                ucrSaveResultEst.SetPrefix(strDataframeName & "_" & "gen")
            End If
            If ucrSaveResultGen.ucrChkSave.Checked Then
                ucrSaveResultGen.SetPrefix(strDataframeNameGen & "_" & "out")
            End If
        End If
    End Sub

End Class