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
Public Class dlgFindNonnumericValues
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsIsNaFunction, clsIsNaNumericFunction, clsAsNumericFunction, clsSummaryFunction As New RFunction
    Private clsNonNumericCalcFunc, clsNonNumericFilterFunc, clsRunCalcFunction, clslSubCalcListFunc, clsGetColumnsFunction As New RFunction
    Private clsCurrRunCalc As RFunction
    Private clsNotEqualToOperator As New ROperator
    Private strCurrDataName As String

    Private Sub dlgShowNonnumericValues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 545
        ucrSelectorShowNonNumericValues.SetParameter(New RParameter("data_name", 0))
        ucrSelectorShowNonNumericValues.SetParameterIsString()
       
        ucrReceiverColumn.Selector = ucrSelectorShowNonNumericValues
        ucrSelectorShowNonNumericValues.bUseCurrentFilter = False

        ucrReceiverColumn.SetParameter(New RParameter("x", 1))
        ucrReceiverColumn.SetParameterIsString()
        ucrReceiverColumn.bWithQuotes = False
        ucrReceiverColumn.SetIncludedDataTypes({"character"})
        ucrReceiverColumn.strSelectorHeading = "characters"

        ucrInputColumnName.SetParameter(New RParameter("result_name", 3))
        ucrInputColumnName.SetDataFrameSelector(ucrSelectorShowNonNumericValues.ucrAvailableDataFrames)

        ucrChkShowSummary.SetText("Display summary")
        ucrChkShowSummary.AddRSyntaxContainsFunctionNamesCondition(True, {"summary"})
        ucrChkShowSummary.AddRSyntaxContainsFunctionNamesCondition(False, {"summary"}, False)

        ucrChkFilterNonumerics.SetText("Create subset of non-numeric cases")
        ucrChkFilterNonumerics.AddParameterValuesCondition(True, "type", Chr(34) & "filter" & Chr(34))
        ucrChkFilterNonumerics.AddParameterValuesCondition(False, "type", Chr(34) & "filter" & Chr(34), False)
    End Sub

    Private Sub SetDefaults()
        Dim strLogicalColumn As String = "nonum"
        clsIsNaFunction = New RFunction
        clsIsNaNumericFunction = New RFunction
        clsSummaryFunction = New RFunction
        clsNotEqualToOperator = New ROperator

        clsNonNumericCalcFunc.Clear()
        clsNonNumericFilterFunc.Clear()
        clslSubCalcListFunc.Clear()
        clsRunCalcFunction.Clear()

        ucrReceiverColumn.SetMeAsReceiver()
        ucrSelectorShowNonNumericValues.Reset()
        ucrBase.clsRsyntax.ClearCodes()

        clsIsNaFunction.SetRCommand("is.na")

        clsNotEqualToOperator.SetOperation("!=")
        clsNotEqualToOperator.AddParameter("left", clsRFunctionParameter:=clsIsNaFunction, iPosition:=0)
        clsNotEqualToOperator.AddParameter("right", clsRFunctionParameter:=clsIsNaNumericFunction, iPosition:=1)
        clsNotEqualToOperator.bToScriptAsRString = True

        clsIsNaNumericFunction.SetRCommand("is.na")
        clsIsNaNumericFunction.AddParameter("numeric", bIncludeArgumentName:=False, clsRFunctionParameter:=clsAsNumericFunction)

        clsAsNumericFunction.SetRCommand("as.numeric")

        clsNonNumericCalcFunc.SetRCommand("instat_calculation$new")
        clsNonNumericCalcFunc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsNonNumericCalcFunc.AddParameter("function_exp", clsROperatorParameter:=clsNotEqualToOperator, iPosition:=1)
        clsNonNumericCalcFunc.AddParameter("result_name", Chr(34) & strLogicalColumn & Chr(34), iPosition:=3)
        clsNonNumericCalcFunc.AddParameter("save", 2, iPosition:=4)
        clsNonNumericCalcFunc.SetAssignTo("non_numerics_calculation")

        clsNonNumericFilterFunc.SetRCommand("instat_calculation$new")
        clsNonNumericFilterFunc.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsNonNumericFilterFunc.AddParameter("sub_calculations", clsRFunctionParameter:=clslSubCalcListFunc, iPosition:=2)
        clsNonNumericFilterFunc.AddParameter("result_data_frame", Chr(34) & "Filter" & Chr(34), iPosition:=3)
        clsNonNumericFilterFunc.AddParameter("save", 2, iPosition:=4)
        clsNonNumericFilterFunc.SetAssignTo("non_numerics_filter")

        clslSubCalcListFunc.SetRCommand("list")
        clslSubCalcListFunc.AddParameter("sub1", clsRFunctionParameter:=clsNonNumericCalcFunc, bIncludeArgumentName:=False)

        clsGetColumnsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")

        clsSummaryFunction.SetRCommand("summary")
        clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=clsGetColumnsFunction)
        clsSummaryFunction.iCallType = 2

        clsCurrRunCalc = clsNonNumericCalcFunc

        clsRunCalcFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsRunCalcFunction.AddParameter("calc", clsRFunctionParameter:=clsNonNumericCalcFunc)
        clsRunCalcFunction.AddParameter("display", "FALSE")

        ucrBase.clsRsyntax.SetBaseRFunction(clsRunCalcFunction)
        ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, iPosition:=0)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverColumn.AddAdditionalCodeParameterPair(clsAsNumericFunction, New RParameter("x", 1), iAdditionalPairNo:=1)
        ucrInputColumnName.AddAdditionalCodeParameterPair(clsGetColumnsFunction, New RParameter("col_names", 1), iAdditionalPairNo:=1)
        ucrInputColumnName.AddAdditionalCodeParameterPair(clsNonNumericFilterFunc, New RParameter("function_exp", 1), iAdditionalPairNo:=2)

        ucrReceiverColumn.SetRCode(clsIsNaFunction, bReset)
        ucrInputColumnName.SetRCode(clsNonNumericCalcFunc, bReset)
        ucrChkShowSummary.SetRSyntax(ucrBase.clsRsyntax, bReset)
        ucrChkFilterNonumerics.SetRCode(clsCurrRunCalc, bReset)
        ucrSelectorShowNonNumericValues.SetRCode(clsGetColumnsFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverColumn.IsEmpty AndAlso Not ucrInputColumnName.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrChkShowSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkShowSummary.ControlValueChanged
        If ucrChkShowSummary.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, iPosition:=0)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSummaryFunction)
        End If
    End Sub

    Private Sub ucrReceiverColumn_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumn.ControlValueChanged
        clsNonNumericCalcFunc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverColumn.GetVariableNames & ")", iPosition:=2)
    End Sub

    Private Sub ucrSelectorShowNonNumericValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorShowNonNumericValues.ControlValueChanged
        strCurrDataName = Chr(34) & ucrSelectorShowNonNumericValues.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34)
    End Sub

    Private Sub ucrChkFilter_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFilterNonumerics.ControlValueChanged
        If ucrChkFilterNonumerics.Checked Then
            clsCurrRunCalc = clsNonNumericFilterFunc
        Else
            clsCurrRunCalc = clsNonNumericCalcFunc
        End If
        clsRunCalcFunction.AddParameter("calc", clsRFunctionParameter:=clsCurrRunCalc)
    End Sub

    Private Sub ucrReceiverColumn_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumn.ControlContentsChanged, ucrInputColumnName.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class
