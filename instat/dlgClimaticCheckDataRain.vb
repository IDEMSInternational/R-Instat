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
Public Class dlgClimaticCheckDataRain
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private strCurrDataName As String = ""
    Private strRain As String = "Rain"
    'Large/Same/wetdays
    Private clsGroupByFunc, clsRainFilterFunc, clsRunCalcFunc, clsListFunc As New RFunction
    'Large 
    Private clsLargeOperator As New ROperator
    'Same
    Private clsRleFunc, clsRepFunc As New RFunction
    Private clsAndOperator, clsDollarOperator, clsGreterSameOperator As ROperator
    'Wetdays
    Private clsCumSumFuc, clsCumMaxFunc As New RFunction
    Private clsGreaterOperator, clsMinusOperator, clsMultiplOperator, clsGreatOperator As New ROperator
    'Combined Filters
    Private clsOrLargeSameOperator, clsOrLargeWetOperator, clsOrSameWetOperator As ROperator

    Private Sub dlgRain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            setDefaults()
        End If
        setRcodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        'temp disabled untill implemented
        ucrChkDryMonth.SetText("Dry Month")
        ucrChkDryMonth.Enabled = False
        ucrChkOutlier.SetText("Outlier")
        ucrChkOutlier.Enabled = False

        ucrReceiverStation.Selector = ucrSelectorRain
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        ucrReceiverYear.Selector = ucrSelectorRain
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True

        ucrReceiverDay.Selector = ucrSelectorRain
        ucrReceiverDay.SetClimaticType("day")
        ucrReceiverDay.bAutoFill = True

        ucrReceiverMonth.Selector = ucrSelectorRain
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True

        ucrReceiverElement.SetParameter(New RParameter("left", 0, bNewIncludeArgumentName:=False))
        ucrReceiverElement.Selector = ucrSelectorRain
        ucrReceiverElement.SetParameterIsString()
        ucrReceiverElement.bWithQuotes = False
        'ucrReceiverElement.SetClimaticType("Rain")
        'ucrReceiverElement.bAutoFill = True

        ucrNudLarge.SetParameter(New RParameter("right", 1))

        ucrReceiverDate.Selector = ucrSelectorRain
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bAutoFill = True

        ucrInputSave.SetParameter(New RParameter("result_data_frame", 4))
        ucrInputSave.SetValidationTypeAsRVariable()
        ucrInputSave.SetName("Rain_1")

        ucrChkLarge.SetText("Large")

        ucrChkSame.SetText("Same")

        ucrChkWetDays.SetText("Wet Days")

        ucrNudSame.SetParameter(New RParameter("right", 1, bNewIncludeArgumentName:=False))
        ucrNudWetDays.SetParameter(New RParameter("right", 1, bNewIncludeArgumentName:=False))

        'Linking of controls
        ucrChkLarge.AddToLinkedControls(ucrNudLarge, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=200)
        ucrChkSame.AddToLinkedControls(ucrNudSame, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)
        ucrChkWetDays.AddToLinkedControls(ucrNudWetDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10)
        ucrNudLarge.SetLinkedDisplayControl(lblmm)
    End Sub

    Private Sub setDefaults()
        Dim strLengths As String = "lengths"
        clsRleFunc = New RFunction
        clsRepFunc = New RFunction
        clsAndOperator = New ROperator
        clsDollarOperator = New ROperator
        clsGreterSameOperator = New ROperator
        clsOrLargeSameOperator = New ROperator
        clsOrLargeWetOperator = New ROperator
        clsOrSameWetOperator = New ROperator

        clsCumSumFuc.Clear()
        clsCumMaxFunc.Clear()
        clsGreaterOperator.Clear()
        clsMinusOperator.Clear()
        clsMultiplOperator.Clear()
        clsGreatOperator.Clear()
        clsGroupByFunc.Clear()
        clsRainFilterFunc.Clear()
        clsRunCalcFunc.Clear()
        clsListFunc.Clear()
        clsLargeOperator.Clear()
        clsAndOperator.Clear()
        clsRleFunc.Clear()
        clsDollarOperator.Clear()
        clsRepFunc.Clear()

        ucrSelectorRain.Reset()
        ucrReceiverStation.SetMeAsReceiver()

        clsGroupByFunc.SetRCommand("instat_calculation$new")
        clsGroupByFunc.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByFunc.SetAssignTo("grouping")

        clsAndOperator.SetOperation("&")
        clsAndOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsGreaterOperator, iPosition:=0)
        clsAndOperator.AddParameter("right", bIncludeArgumentName:=False, clsRFunctionParameter:=clsRepFunc, iPosition:=1)

        clsRleFunc.SetRCommand("rle")
        clsDollarOperator.SetOperation("$")
        clsDollarOperator.AddParameter("left", bIncludeArgumentName:=False, clsRFunctionParameter:=clsRleFunc, iPosition:=0)
        clsDollarOperator.AddParameter("right", bIncludeArgumentName:=False, strParameterValue:=strLengths, iPosition:=1)
        clsRepFunc.SetRCommand("rep")
        clsRepFunc.AddParameter("first", bIncludeArgumentName:=False, clsROperatorParameter:=clsDollarOperator, iPosition:=0)
        clsRepFunc.AddParameter("second", bIncludeArgumentName:=False, clsROperatorParameter:=clsDollarOperator, iPosition:=1)

        clsGreterSameOperator.bToScriptAsRString = True
        clsGreterSameOperator.SetOperation(">")
        clsGreterSameOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsAndOperator, iPosition:=0)
        'clsGretOperator.AddParameter("right",bIncludeArgumentName:=False,clsr)
        clsLargeOperator.bToScriptAsRString = True
        clsRainFilterFunc.SetRCommand("instat_calculation$new")
        clsRainFilterFunc.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsRainFilterFunc.AddParameter("manipulations", clsRFunctionParameter:=clsListFunc, iPosition:=4)
        clsRainFilterFunc.AddParameter("save", 2)
        clsLargeOperator.SetOperation(">")
        clsLargeOperator.AddParameter("left", iPosition:=0)
        clsLargeOperator.AddParameter("right", "60", iPosition:=1)
        clsListFunc.SetRCommand("list")
        clsListFunc.AddParameter("sub1", clsRFunctionParameter:=clsGroupByFunc, bIncludeArgumentName:=False, iPosition:=1)
        clsRainFilterFunc.SetAssignTo("rainfall_filter")

        clsCumSumFuc.SetRCommand("cumsum")
        clsGreaterOperator.SetOperation(">")
        clsGreaterOperator.AddParameter("y", "0", iPosition:=1, bIncludeArgumentName:=False)
        clsCumSumFuc.AddParameter("x", bIncludeArgumentName:=False, clsROperatorParameter:=clsGreaterOperator, iPosition:=0)

        clsGreatOperator.SetOperation(">")
        clsGreatOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsMinusOperator, iPosition:=0)
        clsGreatOperator.bToScriptAsRString = True
        clsMinusOperator.SetOperation("-")
        clsMinusOperator.AddParameter("left", bIncludeArgumentName:=False, clsRFunctionParameter:=clsCumSumFuc, iPosition:=0)
        clsMinusOperator.AddParameter("right", bIncludeArgumentName:=False, clsRFunctionParameter:=clsCumMaxFunc, iPosition:=1)

        clsCumMaxFunc.SetRCommand("cummax")
        clsCumMaxFunc.AddParameter("right", bIncludeArgumentName:=False, clsROperatorParameter:=clsMultiplOperator, iPosition:=0)
        clsMultiplOperator.SetOperation("*")
        clsMultiplOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsGreaterOperator, iPosition:=0)
        clsMultiplOperator.AddParameter("right", bIncludeArgumentName:=False, clsRFunctionParameter:=clsCumSumFuc, iPosition:=1)

        'Combined filter
        clsOrLargeSameOperator.SetOperation("|")
        clsOrLargeSameOperator.AddParameter("large", bIncludeArgumentName:=False, clsROperatorParameter:=clsLargeOperator, iPosition:=0)
        clsOrLargeSameOperator.AddParameter("same", bIncludeArgumentName:=False, clsROperatorParameter:=clsGreterSameOperator, iPosition:=1)
        clsOrLargeWetOperator.SetOperation("|")
        clsOrLargeWetOperator.AddParameter("large", bIncludeArgumentName:=False, clsROperatorParameter:=clsLargeOperator, iPosition:=0)
        clsOrLargeWetOperator.AddParameter("wet", bIncludeArgumentName:=False, clsROperatorParameter:=clsGreatOperator, iPosition:=1)
        clsOrSameWetOperator.SetOperation("|")
        clsOrSameWetOperator.AddParameter("same", bIncludeArgumentName:=False, clsROperatorParameter:=clsGreterSameOperator, iPosition:=0)
        clsOrSameWetOperator.AddParameter("wet", bIncludeArgumentName:=False, clsROperatorParameter:=clsGreatOperator, iPosition:=1)

        clsRunCalcFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsRunCalcFunc.AddParameter("calc", clsRFunctionParameter:=clsRainFilterFunc)
        clsRunCalcFunc.AddParameter("display", "FALSE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRunCalcFunc)
    End Sub

    Private Sub setRcodeForControls(bReset)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsGreaterOperator, New RParameter("left", 0), iAdditionalPairNo:=1)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsRleFunc, New RParameter("left", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrInputSave.SetRCode(clsRainFilterFunc, bReset)
        ucrReceiverElement.SetRCode(clsLargeOperator, bReset)

        ucrNudLarge.SetRCode(clsLargeOperator, bReset)
        ucrNudSame.SetRCode(clsGreterSameOperator, bReset)
        ucrNudWetDays.SetRCode(clsGreatOperator, bReset)

        ucrChkLarge.SetRCode(clsLargeOperator, bReset)
        ucrChkSame.SetRCode(clsGreterSameOperator, bReset)
        ucrChkWetDays.SetRCode(clsGreatOperator, bReset)
    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub GroupByOptions()
        If Not ucrReceiverStation.IsEmpty Then
            clsGroupByFunc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & ")", iPosition:=1)
        End If
    End Sub

    Private Sub FilterFunction()
        clsRainFilterFunc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverElement.GetVariableNames & ")", iPosition:=2)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        setDefaults()
        setRcodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        GroupByOptions()
    End Sub

    Private Sub ucrSelectorRain_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorRain.ControlValueChanged
        strCurrDataName = Chr(34) & ucrSelectorRain.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        GroupByOptions()
        FilterFunction()
    End Sub

    Private Sub ucrReceiverElement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlValueChanged, ucrNudLarge.ControlValueChanged
        FilterFunction()
    End Sub

    Private Sub ucrChkLarge_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLarge.ControlValueChanged, ucrChkSame.ControlValueChanged, ucrChkWetDays.ControlValueChanged, ucrNudWetDays.ControlValueChanged, ucrNudSame.ControlValueChanged
        If ucrChkLarge.Checked AndAlso Not ucrChkSame.Checked AndAlso Not ucrChkWetDays.Checked Then
            clsRainFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsLargeOperator, iPosition:=1)
        ElseIf ucrChkSame.Checked AndAlso Not ucrChkLarge.Checked AndAlso Not ucrChkWetDays.Checked Then
            clsRainFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsGreterSameOperator, iPosition:=1)
            'clsRainFilterFunc.AddParameter("function_exp", Chr(34) & strRain & ">0&" & "rep(rle(" & strRain & ")$lenghts," & "rle(" & strRain & ")$lengths)" & ">" & ucrNudSame.Value & Chr(34), iPosition:=1)
        ElseIf ucrChkWetDays.Checked AndAlso Not ucrChkLarge.Checked AndAlso Not ucrChkSame.Checked Then
            clsRainFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsGreatOperator, iPosition:=1)
            'clsRainFilterFunc.AddParameter("function_exp", Chr(34) & "(cumsum(" & strRain & ">0)-cummax((" & strRain & ">0)*cumsum(" & strRain & ">0" & ")))" & ">" & ucrNudWetDays.Value & Chr(34), iPosition:=1)
        ElseIf ucrChkLarge.Checked AndAlso ucrChkSame.Checked Then
            clsRainFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsOrLargeSameOperator, iPosition:=1)
        ElseIf ucrChkLarge.Checked AndAlso ucrChkWetDays.Checked Then
            clsRainFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsOrLargeWetOperator, iPosition:=1)
        ElseIf ucrChkSame.Checked AndAlso ucrChkWetDays.Checked Then
            clsRainFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsOrSameWetOperator, iPosition:=1)
        End If
    End Sub
End Class