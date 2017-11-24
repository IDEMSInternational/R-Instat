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
    Private clsRleFunc, clsRepFunc, clsAsNumericFunc As New RFunction
    Private clsAndOperator, clsDollarOperator, clsGreaterSameOperator As New ROperator
    'Wetdays
    Private clsCumSumFuc, clsCumMaxFunc As New RFunction
    Private clsGreaterOperator, clsMinusOperator, clsMultiplOperator, clsGreatOperator, clsEqualOperator As New ROperator
    'Combined Filters
    Private clsOrOperator As New ROperator

    Private Sub dlgRain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstload Then
            InitialiseDialog()
        End If
        If bReset Then
            SetDefaults()
        End If
        setRcodeForControls(bReset)
        If bFirstload Then
            AutoFillRainColumn()
            bFirstload = False
        End If
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

        ucrNudLarge.SetParameter(New RParameter("right", 1))

        ucrReceiverDate.Selector = ucrSelectorRain
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bAutoFill = True

        ucrChkLarge.SetParameter(New RParameter("large", clsLargeOperator, 1), bNewChangeParameterValue:=False)
        ucrChkLarge.SetText("Large")

        ucrChkSame.SetParameter(New RParameter("same", clsGreaterSameOperator, 1), bNewChangeParameterValue:=False)
        ucrChkSame.SetText("Consecutive")

        ucrChkWetDays.SetParameter(New RParameter("wet_days", clsGreatOperator, 1, False), bNewChangeParameterValue:=False)
        ucrChkWetDays.SetText("Wet Days")

        ucrNudSame.SetParameter(New RParameter("right", 1, bNewIncludeArgumentName:=False))
        ucrNudWetDays.SetParameter(New RParameter("right", 1, bNewIncludeArgumentName:=False))

        'Linking of controls
        ucrChkLarge.AddToLinkedControls(ucrNudLarge, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=200)
        ucrChkSame.AddToLinkedControls(ucrNudSame, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)
        ucrChkWetDays.AddToLinkedControls(ucrNudWetDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10)
        ucrNudLarge.SetLinkedDisplayControl(lblmm)
        ucrNudSame.SetLinkedDisplayControl(lblDays)
        ucrNudWetDays.SetLinkedDisplayControl(lblDaysWet)
    End Sub

    Private Sub SetDefaults()
        Dim strLengths As String = "lengths"
        clsRleFunc = New RFunction
        clsRepFunc = New RFunction
        clsAsNumericFunc = New RFunction
        clsAndOperator = New ROperator
        clsDollarOperator = New ROperator
        clsOrOperator = New ROperator
        clsEqualOperator = New ROperator

        clsLargeOperator.Clear()
        clsGreaterSameOperator.Clear()
        clsGreatOperator.Clear()

        ucrSelectorRain.Reset()
        ucrReceiverStation.SetMeAsReceiver()

        'Group Function
        clsGroupByFunc.SetRCommand("instat_calculation$new")
        clsGroupByFunc.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByFunc.SetAssignTo("grouping")

        clsListFunc.SetRCommand("list")
        clsListFunc.AddParameter("sub1", clsRFunctionParameter:=clsGroupByFunc, bIncludeArgumentName:=False, iPosition:=1)

        'Main Filter
        clsRainFilterFunc.SetRCommand("instat_calculation$new")
        clsRainFilterFunc.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsRainFilterFunc.AddParameter("save", 2)
        clsRainFilterFunc.AddParameter("result_data_frame", Chr(34) & "Rainfall_Filter" & Chr(34))
        clsRainFilterFunc.SetAssignTo("rainfall_filter")

        'Large
        clsLargeOperator.SetOperation(">")
        clsLargeOperator.AddParameter("left", iPosition:=0)
        clsLargeOperator.AddParameter("right", "200", iPosition:=1)

        'Same
        clsGreaterOperator.SetOperation(">")
        clsGreaterOperator.AddParameter("y", "0", iPosition:=1, bIncludeArgumentName:=False)
        clsAndOperator.SetOperation("&")
        clsAndOperator.bBrackets = False
        clsAndOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsGreaterOperator, iPosition:=0)
        clsAndOperator.AddParameter("right", bIncludeArgumentName:=False, clsRFunctionParameter:=clsRepFunc, iPosition:=1)
        clsGreaterSameOperator.SetOperation(">=")
        clsGreaterSameOperator.bBrackets = False
        clsGreaterSameOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsAndOperator, iPosition:=0)
        clsAsNumericFunc.SetRCommand("as.numeric")
        clsRleFunc.SetRCommand("rle")
        clsRleFunc.AddParameter("numeric", bIncludeArgumentName:=False, clsRFunctionParameter:=clsAsNumericFunc, iPosition:=0)
        clsDollarOperator.SetOperation("$")
        clsDollarOperator.AddParameter("left", bIncludeArgumentName:=False, clsRFunctionParameter:=clsRleFunc, iPosition:=0)
        clsDollarOperator.AddParameter("right", bIncludeArgumentName:=False, strParameterValue:=strLengths, iPosition:=1)
        clsRepFunc.SetRCommand("rep")
        clsRepFunc.AddParameter("first", bIncludeArgumentName:=False, clsROperatorParameter:=clsDollarOperator, iPosition:=0)
        clsRepFunc.AddParameter("second", bIncludeArgumentName:=False, clsROperatorParameter:=clsDollarOperator, iPosition:=1)

        'Wet
        clsEqualOperator.SetOperation("==")
        clsEqualOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsGreaterOperator, iPosition:=0)
        clsEqualOperator.AddParameter("right", "0", bIncludeArgumentName:=False, iPosition:=1)
        clsCumSumFuc.SetRCommand("cumsum")
        clsGreatOperator.SetOperation(">")
        clsGreatOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsMinusOperator, iPosition:=0)
        clsMinusOperator.SetOperation("-")
        clsMinusOperator.AddParameter("left", bIncludeArgumentName:=False, clsRFunctionParameter:=clsCumSumFuc, iPosition:=0)
        clsMinusOperator.AddParameter("right", bIncludeArgumentName:=False, clsRFunctionParameter:=clsCumMaxFunc, iPosition:=1)
        clsCumMaxFunc.SetRCommand("cummax")
        clsCumMaxFunc.AddParameter("right", bIncludeArgumentName:=False, clsROperatorParameter:=clsMultiplOperator, iPosition:=0)
        clsMultiplOperator.SetOperation("*")
        clsMultiplOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsEqualOperator, iPosition:=0)
        clsMultiplOperator.AddParameter("right", bIncludeArgumentName:=False, clsRFunctionParameter:=clsCumSumFuc, iPosition:=1)
        clsCumSumFuc.AddParameter("x", bIncludeArgumentName:=False, clsROperatorParameter:=clsGreaterOperator, iPosition:=0)

        'Combined filters
        clsOrOperator.SetOperation("|")
        clsOrOperator.bBrackets = True
        clsOrOperator.bToScriptAsRString = True

        clsRainFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsOrOperator)

        clsRunCalcFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsRunCalcFunc.AddParameter("calc", clsRFunctionParameter:=clsRainFilterFunc)
        clsRunCalcFunc.AddParameter("display", "FALSE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRunCalcFunc)
    End Sub

    Private Sub setRcodeForControls(bReset)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsGreaterOperator, New RParameter("left", 0), iAdditionalPairNo:=1)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsAsNumericFunc, New RParameter("left", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverElement.SetRCode(clsLargeOperator, bReset)

        ucrNudLarge.SetRCode(clsLargeOperator, bReset)
        ucrNudSame.SetRCode(clsGreaterSameOperator, bReset)
        ucrNudWetDays.SetRCode(clsGreatOperator, bReset)

        ucrChkLarge.SetRCode(clsOrOperator, bReset)
        ucrChkSame.SetRCode(clsOrOperator, bReset)
        ucrChkWetDays.SetRCode(clsOrOperator, bReset)
    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub GroupByOptions()
        If Not ucrReceiverStation.IsEmpty Then
            clsGroupByFunc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & ")", iPosition:=1)
            clsRainFilterFunc.AddParameter("manipulations", clsRFunctionParameter:=clsListFunc, iPosition:=4)
        Else
            clsRainFilterFunc.RemoveParameterByName("manipulations")
        End If
    End Sub

    Private Sub FilterFunction()
        clsRainFilterFunc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverElement.GetVariableNames & ")", iPosition:=2)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
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
        AutoFillRainColumn()
    End Sub

    Private Sub ucrReceiverElement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlValueChanged, ucrNudLarge.ControlValueChanged
        FilterFunction()
    End Sub

    Private Sub AutoFillRainColumn()
        Dim strRainCol As String
        Dim strDataFrame As String

        strDataFrame = ucrSelectorRain.ucrAvailableDataFrames.cboAvailableDataFrames.Text
        strRainCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "rain_label")

        If strRainCol <> "" Then
            ucrReceiverElement.Add(strRainCol, strDataFrame)
        End If
    End Sub
End Class