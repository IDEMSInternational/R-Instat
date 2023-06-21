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
Public Class dlgThreeVariablePivotTable
    Private bFirstLoad As Boolean = True
    Private bRcodeSet As Boolean = False
    Private bReset As Boolean = True

    Public enumPivotMode As PivotMode = PivotMode.Describe

    Public Enum PivotMode
        Describe
        Climatic
    End Enum

    Private clsConcatenateFunction, clsFlattenFunction,
         clsLevelsFunction, clsPasteFunction,
        clsRelevelPasteFunction, clsRPivotTableFunction,
        clsSelectFunction, clsDummyFunction As New RFunction
    Private clsPipeOperator, clsLevelsDollarOperator As New ROperator

    Private Sub dlgThreeVariablePivotTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        AutofillMode()
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 417
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorPivot.SetParameter(New RParameter("data", iNewPosition:=0))
        ucrSelectorPivot.SetParameterIsrfunction()

        ucrReceiverInitialRowFactors.SetParameter(New RParameter("rows", iNewPosition:=1))
        ucrReceiverInitialRowFactors.SetParameterIsString()
        ucrReceiverInitialRowFactors.strSelectorHeading = "Numerics"
        ucrReceiverInitialRowFactors.SetIncludedDataTypes({"numeric"})
        ucrReceiverInitialRowFactors.Selector = ucrSelectorPivot

        ucrReceiverInitialColumnFactor.SetParameter(New RParameter("cols", iNewPosition:=2))
        ucrReceiverInitialColumnFactor.SetParameterIsString()
        ucrReceiverInitialColumnFactor.Selector = ucrSelectorPivot

        ucrReceiverSelectedVariable.Selector = ucrSelectorPivot

        ucrReceiverAdditionalRowFactor.SetParameter(New RParameter("val", iNewPosition:=4))
        ucrReceiverAdditionalRowFactor.SetParameterIsString()
        ucrReceiverAdditionalRowFactor.Selector = ucrSelectorPivot

        ucrChkSelectedVariable.AddParameterIsRFunctionCondition(False, "data", True)
        ucrChkSelectedVariable.AddParameterIsRFunctionCondition(True, "data", False)

        ucrReceiverFactorLevels.SetParameter(New RParameter("variable", iNewPosition:=1))
        ucrReceiverFactorLevels.SetParameterIsString()
        ucrReceiverFactorLevels.bWithQuotes = False
        ucrReceiverFactorLevels.Selector = ucrSelectorPivot
        ttFactorLevels.SetToolTip(ucrReceiverFactorLevels.txtReceiverSingle,
                                  "Use when default (alphabetical) order of factor levels is inappropriate.")

        ucrChkSelectedVariable.SetText("Select Variable(s)")
        ucrChkSelectedVariable.AddToLinkedControls(ucrReceiverSelectedVariable, {True}, bNewLinkedHideIfParameterMissing:=True)
        ttSelectedVariable.SetToolTip(ucrChkSelectedVariable.chkCheck, "Include the dataframe if unchecked")

        ucrChkIncludeSubTotals.SetText("Subtotals")
        ucrChkIncludeSubTotals.SetParameter(New RParameter("subtotals", iNewPosition:=3))
        ucrChkIncludeSubTotals.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkIncludeSubTotals.SetRDefault("FALSE")

        ucrChkNumericVariable.SetText("Numeric Variable (Optional):")
        ucrChkNumericVariable.SetParameter(New RParameter("subtotals", iNewPosition:=0))
        ucrChkNumericVariable.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkNumericVariable.SetRDefault("TRUE")
        ucrChkNumericVariable.AddToLinkedControls({ucrReceiverAdditionalRowFactor}, {True}, bNewLinkedHideIfParameterMissing:=True,
                                                  bNewLinkedAddRemoveParameter:=True, bNewLinkedUpdateFunction:=True)
        ucrChkNumericVariable.AddToLinkedControls({ucrInputTableChart}, {True}, bNewLinkedHideIfParameterMissing:=True,
                                                  bNewLinkedAddRemoveParameter:=True, bNewLinkedUpdateFunction:=True,
                                                  objNewDefaultState:="Table", bNewLinkedChangeToDefaultState:=True)
        ucrChkNumericVariable.AddToLinkedControls({ucrInputSummary}, {True}, bNewLinkedHideIfParameterMissing:=True,
                                                  bNewLinkedAddRemoveParameter:=True, bNewLinkedUpdateFunction:=True,
                                                  objNewDefaultState:="Average", bNewLinkedChangeToDefaultState:=True)

        ucrInputTableChart.SetParameter(New RParameter("rendererName", iNewPosition:=5))
        ucrInputTableChart.SetItems({"Table", "Table Barchart", "Heatmap", "Row Heatmap", "Col Heatmap",
         "Treemap", "Horizontal Bar Chart", "Horizontal Stacked Barchart", "Bar Chart", "Stacked Bar Chart",
         "Line Chart", "Area chart", "Scatter Chart"}, bAddConditions:=True)
        ucrInputTableChart.SetText("Table")
        ucrInputTableChart.SetLinkedDisplayControl(lblTableChart)

        ucrInputSummary.SetParameter(New RParameter("aggregatorName", iNewPosition:=6))
        ucrInputSummary.SetItems({"Average", "Count Unique Values", "List Unique Values", "Sum", "Integer Sum",
                                    "Count", "Median", "Sample Variance", "Sample Standard Deviation", "Minimum",
                                    "Maximum", "First", "Last", "Sum over Sum", "80% Upper Bound", "80% Lower Bound",
                                    "Sum as Fraction of Totals", "Sum as Fraction of Rows", "Sum as Fraction of Columns",
                                    "Count as Fraction of Total", "Count as Fraction of Rows", "Count as Fraction of Columns"}, bAddConditions:=True)
        ucrInputSummary.SetText("Average")
        ucrInputSummary.SetLinkedDisplayControl(lblSummary)

        ucrSavePivot.SetPrefix("pivot_table")
        ucrSavePivot.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
        ucrSavePivot.SetDataFrameSelector(ucrSelectorPivot.ucrAvailableDataFrames)
        ucrSavePivot.SetIsComboBox()
        ucrSavePivot.SetCheckBoxText("Save Table")
        ucrSavePivot.SetAssignToIfUncheckedValue("last_table")
    End Sub

    Private Sub SetDefaults()
        clsConcatenateFunction = New RFunction
        clsFlattenFunction = New RFunction
        clsLevelsFunction = New RFunction
        clsPasteFunction = New RFunction
        clsRelevelPasteFunction = New RFunction
        clsRPivotTableFunction = New RFunction
        clsSelectFunction = New RFunction
        clsDummyFunction = New RFunction

        clsLevelsDollarOperator = New ROperator
        clsPipeOperator = New ROperator

        ucrReceiverInitialRowFactors.SetMeAsReceiver()
        ucrSelectorPivot.Reset()
        ucrSavePivot.Reset()

        clsDummyFunction.AddParameter("subtotals", "TRUE", iPosition:=0)

        clsLevelsDollarOperator.SetOperation("$")

        clsLevelsFunction.SetRCommand("levels")
        clsLevelsFunction.AddParameter("x", clsROperatorParameter:=clsLevelsDollarOperator, iPosition:=0)

        clsPasteFunction.SetRCommand("paste0")
        clsPasteFunction.AddParameter("first_parameter", Chr(34) & "\" & Chr(34) & Chr(34),
                                      iPosition:=0, bIncludeArgumentName:=False)
        clsPasteFunction.AddParameter("second_parameter", clsRFunctionParameter:=clsLevelsFunction,
                                      iPosition:=1, bIncludeArgumentName:=False)
        clsPasteFunction.AddParameter("third_parameter", Chr(34) & "\" & Chr(34) & "," & Chr(34),
                                      iPosition:=2, bIncludeArgumentName:=False)

        clsFlattenFunction.SetPackageName("stringr")
        clsFlattenFunction.SetRCommand("str_flatten")
        clsFlattenFunction.AddParameter("string", clsRFunctionParameter:=clsPasteFunction, iPosition:=0)
        clsFlattenFunction.SetAssignTo("survey_levels")

        clsRelevelPasteFunction.SetRCommand("paste0")
        clsRelevelPasteFunction.AddParameter("first_paramete", Chr(34) & "function(attr) {  var sortAs = $.pivotUtilities.sortAs;  return sortAs([" & Chr(34) & ", survey_levels," & Chr(34) & "]); }" & Chr(34),
                                            bIncludeArgumentName:=False, iPosition:=0)
        clsRelevelPasteFunction.SetAssignTo("relevel_variables")

        clsConcatenateFunction.SetRCommand("c")

        clsSelectFunction.SetPackageName("dplyr")
        clsSelectFunction.SetRCommand("select")
        clsSelectFunction.AddParameter("concatenate", clsRFunctionParameter:=clsConcatenateFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("columns", clsRFunctionParameter:=clsSelectFunction, iPosition:=1)
        clsPipeOperator.SetAssignTo("data_selected")

        clsRPivotTableFunction.SetPackageName("rpivotTable")
        clsRPivotTableFunction.SetRCommand("rpivotTable")
        clsRPivotTableFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorPivot.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsRPivotTableFunction.SetAssignTo("last_table")

        clsRPivotTableFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                                   strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                                   strRObjectFormatToAssignTo:=RObjectFormat.Html,
                                                   strRDataFrameNameToAddObjectTo:=ucrSelectorPivot.strCurrentDataFrame,
                                                   strObjectName:="last_table")

        ucrBase.clsRsyntax.SetBaseRFunction(clsRPivotTableFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRcodeSet = False
        ucrSelectorPivot.AddAdditionalCodeParameterPair(clsLevelsDollarOperator, ucrSelectorPivot.GetParameter, iAdditionalPairNo:=1)

        ucrSelectorPivot.SetRCode(clsPipeOperator, bReset)
        ucrReceiverInitialColumnFactor.SetRCode(clsRPivotTableFunction, bReset)
        ucrReceiverFactorLevels.SetRCode(clsLevelsDollarOperator, bReset)
        ucrChkNumericVariable.SetRCode(clsDummyFunction, bReset)
        ucrReceiverInitialRowFactors.SetRCode(clsRPivotTableFunction, bReset)
        ucrSavePivot.SetRCode(clsRPivotTableFunction, bReset)
        ucrChkSelectedVariable.SetRCode(clsRPivotTableFunction, bReset)
        ucrChkIncludeSubTotals.SetRCode(clsRPivotTableFunction, bReset)
        bRcodeSet = True
    End Sub

    Private Sub TestOkEnabled()
        If ucrSavePivot.IsComplete AndAlso Not String.IsNullOrEmpty(ucrSelectorPivot.ucrAvailableDataFrames.cboAvailableDataFrames.Text) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        AutofillMode()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrChkSelectedVariable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSelectedVariable.ControlValueChanged
        If ucrChkSelectedVariable.Checked Then
            ucrReceiverSelectedVariable.SetMeAsReceiver()
        Else
            ucrReceiverInitialRowFactors.SetMeAsReceiver()
        End If
        ChangeDataParameterValue()
    End Sub

    Private Sub ucrSelectorPivot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorPivot.ControlValueChanged
        ChangeDataParameterValue()
        AutofillMode()
        clsRPivotTableFunction._strDataFrameNameToAddAssignToObject = ucrSelectorPivot.strCurrentDataFrame
    End Sub

    Private Sub ChangeDataParameterValue()
        If ucrChkSelectedVariable.Checked Then
            clsRPivotTableFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
        Else
            clsRPivotTableFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorPivot.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        End If
    End Sub

    Private Sub ReceiversChanged(ucrChangedControls As ucrCore) Handles ucrReceiverInitialColumnFactor.ControlValueChanged, ucrReceiverSelectedVariable.ControlValueChanged,
        ucrReceiverInitialRowFactors.ControlValueChanged, ucrReceiverAdditionalRowFactor.ControlValueChanged, ucrReceiverFactorLevels.ControlValueChanged, ucrChkNumericVariable.ControlValueChanged

        If ucrChkSelectedVariable.Checked Then
            Dim lstColumns As New List(Of String)
            Dim iPosition As Integer = 0
            Dim strColumnVariableName As String = ucrReceiverInitialColumnFactor.GetVariableNames(bWithQuotes:=False)
            Dim strRowVariableName As String = ucrReceiverAdditionalRowFactor.GetVariableNames(bWithQuotes:=False)
            Dim strFactorLevelsVariable As String = ucrReceiverFactorLevels.GetVariableNames(False)
            clsConcatenateFunction.ClearParameters()
            If Not ucrReceiverInitialRowFactors.IsEmpty Then
                CheckForDuplication(lstColumns, ucrReceiverInitialRowFactors, iPosition)
            End If

            If Not ucrReceiverSelectedVariable.IsEmpty Then
                CheckForDuplication(lstColumns, ucrReceiverSelectedVariable, iPosition)
            End If

            If Not ucrReceiverInitialColumnFactor.IsEmpty AndAlso Not lstColumns.Contains(strColumnVariableName) Then
                lstColumns.Add(ucrReceiverInitialColumnFactor.GetVariableNames(bWithQuotes:=False))
                clsConcatenateFunction.AddParameter("col" & iPosition, strColumnVariableName, iPosition:=iPosition, bIncludeArgumentName:=False)
                iPosition += 1
            End If

            If Not ucrReceiverAdditionalRowFactor.IsEmpty AndAlso
                Not lstColumns.Contains(strRowVariableName) AndAlso ucrChkNumericVariable.Checked Then
                clsConcatenateFunction.AddParameter("col" & iPosition, strRowVariableName, iPosition:=iPosition, bIncludeArgumentName:=False)
                iPosition += 1
            End If
            If Not ucrReceiverFactorLevels.IsEmpty AndAlso
                Not lstColumns.Contains(strFactorLevelsVariable) Then
                clsConcatenateFunction.AddParameter("factor_level", strFactorLevelsVariable,
                                  bIncludeArgumentName:=False, iPosition:=iPosition)

            End If
        End If

        If enumPivotMode = PivotMode.Climatic Then
            clsRPivotTableFunction.RemoveParameterByName("sorters")
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsFlattenFunction)

        Else
            ucrBase.clsRsyntax.AddToBeforeCodes(clsFlattenFunction, 0)
            clsRPivotTableFunction.AddParameter(strParameterName:="sorters", clsRFunctionParameter:=clsRelevelPasteFunction, iPosition:=3)
        End If

        If ucrChkNumericVariable.Checked AndAlso enumPivotMode = PivotMode.Climatic Then
            clsRPivotTableFunction.AddParameter("val", ucrReceiverAdditionalRowFactor.GetVariableNames(), iPosition:=3)
            clsRPivotTableFunction.AddParameter("rendererName", Chr(34) & ucrInputTableChart.GetText() & Chr(34), iPosition:=4)
            clsRPivotTableFunction.AddParameter("aggregatorName", Chr(34) & ucrInputSummary.GetText() & Chr(34), iPosition:=5)
        Else
            clsRPivotTableFunction.RemoveParameterByName("val")
            clsRPivotTableFunction.RemoveParameterByName("rendererName")
            clsRPivotTableFunction.RemoveParameterByName("aggregatorName")
        End If
    End Sub

    Private Sub CheckForDuplication(lstNewColumns As List(Of String), ucrNewReceiver As ucrReceiverMultiple, ByRef iNewposition As Integer)
        For Each strColumn In ucrNewReceiver.GetVariableNamesList(bWithQuotes:=False)
            If lstNewColumns.Contains(strColumn) Then
                Continue For
            End If
            lstNewColumns.Add(strColumn)
            clsConcatenateFunction.AddParameter("col" & iNewposition, strColumn, iPosition:=iNewposition, bIncludeArgumentName:=False)
            iNewposition += 1
        Next
    End Sub

    Private Sub AutofillMode()
        Select Case enumPivotMode
            Case PivotMode.Describe
                ucrReceiverInitialRowFactors.bAutoFill = False

                ucrReceiverInitialColumnFactor.bAutoFill = False

                ucrReceiverFactorLevels.SetDataType("factor")
                ucrReceiverFactorLevels.bAutoFill = False

                ucrReceiverAdditionalRowFactor.SetIncludedDataTypes({"numeric", "Date", "logical"})
                ucrReceiverAdditionalRowFactor.bAutoFill = False
            Case PivotMode.Climatic
                Dim strMonthCol As String
                Dim strDataFrame As String
                Dim strRainCol As String
                Dim strYearCol As String
                Dim strDayCol As String

                strDataFrame = ucrSelectorPivot.ucrAvailableDataFrames.cboAvailableDataFrames.Text
                strMonthCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "month_label")
                strRainCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "rain_label")
                strYearCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "year_label")
                strDayCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "day_label")
                If Not String.IsNullOrEmpty(strRainCol) Then
                    ucrReceiverAdditionalRowFactor.Add(strRainCol, strDataFrame)
                End If

                If Not String.IsNullOrEmpty(strMonthCol) Then
                    ucrReceiverFactorLevels.Add(strMonthCol, strDataFrame)
                    ucrReceiverInitialColumnFactor.Add(strMonthCol, strDataFrame)
                End If
        End Select
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelectedVariable.ControlContentsChanged,
            ucrReceiverInitialColumnFactor.ControlContentsChanged, ucrChkSelectedVariable.ControlContentsChanged, ucrSavePivot.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrInputSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSummary.ControlValueChanged
        If ucrChkNumericVariable.Checked AndAlso Not ucrInputSummary.IsEmpty Then
            clsRPivotTableFunction.AddParameter("aggregatorName", Chr(34) & ucrInputSummary.GetText() & Chr(34), iPosition:=5)
        Else
            clsRPivotTableFunction.RemoveParameterByName("aggregatorName")
        End If
    End Sub

    Private Sub ucrInputTableChart_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputTableChart.ControlValueChanged
        If ucrChkNumericVariable.Checked AndAlso Not ucrInputTableChart.IsEmpty Then
            clsRPivotTableFunction.AddParameter("rendererName", Chr(34) & ucrInputTableChart.GetText() & Chr(34), iPosition:=4)
        Else
            clsRPivotTableFunction.RemoveParameterByName("rendererName")
        End If
    End Sub
End Class