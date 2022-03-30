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

Imports instat
Imports instat.Translations
Public Class dlgFindNonnumericValues
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bUseSelectedColumn As Boolean = False
    Private strSelectedColumn As String = ""
    Private strSelectedDataFrame As String = ""
    Private clsIsNaFunction, clsIsNaNumericFunction, clsAsNumericFunction, clsAsCharacterFunction, clsSummaryFunction As New RFunction
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
        TestOKEnabled()
        If bUseSelectedColumn Then
            SetSelectedColumn()
        End If
        autoTranslate(Me)
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
        ucrReceiverColumn.SetIncludedDataTypes({"factor", "character"}, bStrict:=True)
        ucrReceiverColumn.strSelectorHeading = "Factors and Characters"

        'save control
        ucrSaveColumn.SetPrefix("nonum")
        ucrSaveColumn.SetSaveTypeAsColumn()
        ucrSaveColumn.SetIsComboBox()
        ucrSaveColumn.SetLabelText("Logical Column")
        ucrSaveColumn.SetDataFrameSelector(ucrSelectorShowNonNumericValues.ucrAvailableDataFrames)
        ucrSaveColumn.SetPositionParametersDirectly(False, "result_name")
        'makes the ucrSave control to position new column after selected column
        ucrSaveColumn.setLinkedReceiver(ucrReceiverColumn)

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
        clsAsCharacterFunction = New RFunction

        clsNonNumericCalcFunc.Clear()
        clsNonNumericFilterFunc.Clear()
        clslSubCalcListFunc.Clear()
        clsRunCalcFunction.Clear()

        ucrReceiverColumn.SetMeAsReceiver()
        ucrSelectorShowNonNumericValues.Reset()
        ucrSaveColumn.Reset()
        ucrBase.clsRsyntax.ClearCodes()

        clsIsNaFunction.SetRCommand("is.na")

        clsNotEqualToOperator.SetOperation("!=")
        clsNotEqualToOperator.AddParameter("left", clsRFunctionParameter:=clsIsNaFunction, iPosition:=0)
        clsNotEqualToOperator.AddParameter("right", clsRFunctionParameter:=clsIsNaNumericFunction, iPosition:=1)
        clsNotEqualToOperator.bToScriptAsRString = True

        clsIsNaNumericFunction.SetRCommand("is.na")
        clsIsNaNumericFunction.AddParameter("numeric", bIncludeArgumentName:=False, clsRFunctionParameter:=clsAsNumericFunction)

        clsAsCharacterFunction.SetRCommand("as.character")
        clsAsNumericFunction.SetRCommand("as.numeric")
        clsAsNumericFunction.AddParameter("x", clsRFunctionParameter:=clsAsCharacterFunction, bIncludeArgumentName:=False, iPosition:=1)

        clsNonNumericCalcFunc.SetRCommand("instat_calculation$new")
        clsNonNumericCalcFunc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsNonNumericCalcFunc.AddParameter("function_exp", clsROperatorParameter:=clsNotEqualToOperator, iPosition:=1)
        clsNonNumericCalcFunc.AddParameter("result_name", Chr(34) & strLogicalColumn & Chr(34), iPosition:=3)
        clsNonNumericCalcFunc.AddParameter("save", 2, iPosition:=4)

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
        ucrReceiverColumn.AddAdditionalCodeParameterPair(clsAsCharacterFunction, New RParameter("x", 1), iAdditionalPairNo:=1)
        ucrReceiverColumn.SetRCode(clsIsNaFunction, bReset)
        ucrSaveColumn.SetRCode(clsNonNumericCalcFunc, bReset)
        ucrChkShowSummary.SetRSyntax(ucrBase.clsRsyntax, bReset)
        ucrChkFilterNonumerics.SetRCode(clsCurrRunCalc, bReset)
        ucrSelectorShowNonNumericValues.SetRCode(clsGetColumnsFunction, bReset)
    End Sub

    Public Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedColumn = True
    End Sub

    Private Sub SetSelectedColumn()
        ucrSelectorShowNonNumericValues.SetDataframe(strSelectedDataFrame)
        ucrReceiverColumn.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled(Not ucrReceiverColumn.IsEmpty AndAlso ucrSaveColumn.IsComplete)
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

    Private Sub ucrReceiverColumn_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumn.ControlContentsChanged, ucrSaveColumn.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrSaveColumn_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveColumn.ControlValueChanged
        'change the parameter values
        clsNonNumericCalcFunc.AddParameter(strParameterName:="result_name", strParameterValue:=Chr(34) & ucrSaveColumn.GetText & Chr(34), iPosition:=3)
        clsNonNumericFilterFunc.AddParameter(strParameterName:="function_exp", strParameterValue:=Chr(34) & ucrSaveColumn.GetText & Chr(34), iPosition:=1)
        clsGetColumnsFunction.AddParameter(strParameterName:="col_names", strParameterValue:=Chr(34) & ucrSaveColumn.GetText & Chr(34), iPosition:=1)
    End Sub

End Class
