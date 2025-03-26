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
    Private clsConcatenateFunction,
          clsDummyFunction,
        clsRelevelPasteFunction, clsGetDataFrameFunction, clsRPivotTableFunction,
        clsSelectFunction As New RFunction
    Private clsPipeOperator As New ROperator
    Public enumPivotMode As PivotMode = PivotMode.Prepare
    Private lstSubtotalRenderers As String()
    Private lstNormalRenderers As String()
    Private isChkNumericSingleChecked As Boolean = False
    Private isChkNumericMultipleChecked As Boolean = False
    Private isHandlingChange As Boolean = False

    Public Enum PivotMode
        Prepare
        Describe
        Climatic
    End Enum

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
        autoTranslate(Me)
        TestOkEnabled()
        AutofillMode()
        ConfigureLinkedControls()
        DialogSize()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrPnlOptions.AddRadioButton(rdoSingle)
        ucrPnlOptions.AddRadioButton(rdoMultiple)
        ucrPnlOptions.AddRadioButton(rdoDataFrame)
        ucrPnlOptions.AddParameterValuesCondition(rdoSingle, "checked", "single")
        ucrPnlOptions.AddParameterValuesCondition(rdoMultiple, "checked", "multiple")
        ucrPnlOptions.AddParameterValuesCondition(rdoDataFrame, "checked", "dataframe")

        ucrSelectorPivot.SetParameter(New RParameter("data", iNewPosition:=0))
        ucrSelectorPivot.SetParameterIsrfunction()

        ucrReceiverInitialRowFactors.SetParameter(New RParameter("rows", iNewPosition:=1))
        ucrReceiverInitialRowFactors.SetParameterIsString()
        ucrReceiverInitialRowFactors.Selector = ucrSelectorPivot

        ucrReceiverInitialColumnFactor.SetParameter(New RParameter("cols", iNewPosition:=2))
        ucrReceiverInitialColumnFactor.SetParameterIsString()
        ucrReceiverInitialColumnFactor.Selector = ucrSelectorPivot
        ucrReceiverInitialColumnFactor.SetLinkedDisplayControl(lblInitialColumnFactor)

        ucrReceiverSelectedVariable.Selector = ucrSelectorPivot

        ucrReceiverMultipleAddRows.SetParameter(New RParameter("measure.vars", iNewPosition:=2))
        ucrReceiverMultipleAddRows.SetParameterIsString()
        ucrReceiverMultipleAddRows.Selector = ucrSelectorPivot
        ucrReceiverMultipleAddRows.SetLinkedDisplayControl(lblVariables)

        ucrReceiverAdditionalRowFactor.SetParameter(New RParameter("val", iNewPosition:=4))
        ucrReceiverAdditionalRowFactor.SetParameterIsString()
        ucrReceiverAdditionalRowFactor.Selector = ucrSelectorPivot

        ucrChkSelectedVariable.AddParameterIsRFunctionCondition(False, "data", True)
        ucrChkSelectedVariable.AddParameterIsRFunctionCondition(True, "data", False)
        ucrChkSelectedVariable.SetText("Select Variable(s)")
        ucrChkSelectedVariable.AddToLinkedControls(ucrReceiverSelectedVariable, {True}, bNewLinkedHideIfParameterMissing:=True)
        ttSelectedVariable.SetToolTip(ucrChkSelectedVariable.chkCheck, "Include the dataframe if unchecked")

        ucrChkFactorsOrder.AddParameterValuesCondition(True, "order", "True")
        ucrChkFactorsOrder.AddParameterValuesCondition(False, "order", "False")
        ucrChkFactorsOrder.SetText("Factor Labels in Order")

        ucrChkIncludeSubTotals.SetText("Subtotals")
        ucrChkIncludeSubTotals.SetParameter(New RParameter("subtotals", iNewPosition:=3))
        ucrChkIncludeSubTotals.AddParameterValuesCondition(True, "total", "True")
        ucrChkIncludeSubTotals.AddParameterValuesCondition(False, "total", "False")

        ucrChkNumericVariable.SetText("Variable (Optional):")
        ucrChkNumericVariable.AddParameterPresentCondition(True, "rendererName")
        ucrChkNumericVariable.AddParameterPresentCondition(False, "rendererName", False)
        ucrChkNumericVariable.AddToLinkedControls({ucrReceiverAdditionalRowFactor}, {True}, bNewLinkedHideIfParameterMissing:=True,
        bNewLinkedAddRemoveParameter:=True, bNewLinkedUpdateFunction:=True)
        ucrChkNumericVariable.AddToLinkedControls({ucrInputTableChart}, {True}, bNewLinkedHideIfParameterMissing:=True,
        bNewLinkedAddRemoveParameter:=True, bNewLinkedUpdateFunction:=True,
                                                  objNewDefaultState:="Table", bNewLinkedChangeToDefaultState:=True)
        ucrChkNumericVariable.AddToLinkedControls({ucrInputSummary}, {True}, bNewLinkedHideIfParameterMissing:=True,
                                                  bNewLinkedAddRemoveParameter:=True, bNewLinkedUpdateFunction:=True,
                                                  objNewDefaultState:="Average", bNewLinkedChangeToDefaultState:=True)

        Dim lstCommonRenderers As String() = {
    "Treemap", "Horizontal Bar Chart", "Horizontal Stacked Bar Chart",
    "Bar Chart", "Stacked Bar Chart", "Line Chart", "Area Chart", "Scatter Chart"
}

        ' Define renderers for the unchecked case (normal)
        lstNormalRenderers = {
    "Table", "Table Barchart", "Heatmap", "Row Heatmap", "Col Heatmap"
}.Concat(lstCommonRenderers).ToArray()

        ' Define renderers for the checked case (subtotal versions)
        lstSubtotalRenderers = {
    "Table With Subtotal", "Table With Subtotal Bar Chart", "Table With Subtotal Heatmap",
    "Table With Subtotal Row Heatmap", "Table With Subtotal Col Heatmap"
}.Concat(lstCommonRenderers).ToArray()

        ucrInputTableChart.SetParameter(New RParameter("rendererName", iNewPosition:=5))
        ucrInputTableChart.SetLinkedDisplayControl(lblTableChart)

        ucrInputSummary.SetParameter(New RParameter("aggregatorName", iNewPosition:=6))
        ucrInputSummary.SetItems({"Average", "Count Unique Values", "List Unique Values", "Sum", "Integer Sum",
                                    "Count", "Median", "Sample Variance", "Sample Standard Deviation", "Minimum",
                                    "Maximum", "First", "Last", "Sum over Sum", "80% Upper Bound", "80% Lower Bound",
                                    "Sum as Fraction of Totals", "Sum as Fraction of Rows", "Sum as Fraction of Columns",
                                    "Count as Fraction of Total", "Count as Fraction of Rows", "Count as Fraction of Columns"}, bAddConditions:=True)
        ucrInputSummary.SetLinkedDisplayControl(lblSummary)
        ucrPnlOptions.AddToLinkedControls(ucrChkNumericVariable, {rdoSingle}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlOptions.AddToLinkedControls(ucrReceiverMultipleAddRows, {rdoMultiple}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlOptions.AddToLinkedControls({ucrChkIncludeSubTotals, ucrReceiverInitialColumnFactor, ucrChkSelectedVariable}, {rdoSingle, rdoMultiple}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)


        ucrSavePivot.SetPrefix("pivot_table")
        ucrSavePivot.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
        ucrSavePivot.SetDataFrameSelector(ucrSelectorPivot.ucrAvailableDataFrames)
        ucrSavePivot.SetIsComboBox()
        ucrSavePivot.SetCheckBoxText("Store Table")
        ucrSavePivot.SetAssignToIfUncheckedValue("last_table")
        UpdateRendererOptions()
        ConfigureLinkedControls()
        DialogSize()
    End Sub

    Private Sub SetDefaults()
        clsConcatenateFunction = New RFunction
        clsRelevelPasteFunction = New RFunction
        clsRPivotTableFunction = New RFunction
        clsSelectFunction = New RFunction
        clsGetDataFrameFunction = New RFunction
        clsPipeOperator = New ROperator

        ucrReceiverInitialRowFactors.SetMeAsReceiver()
        ucrSelectorPivot.Reset()
        ucrSavePivot.Reset()
        ucrInputTableChart.Reset()

        clsDummyFunction.AddParameter("order", "True", iPosition:=0)
        clsDummyFunction.AddParameter("checked", "single", iPosition:=1)
        clsDummyFunction.AddParameter("total", "False", iPosition:=2)

        clsRelevelPasteFunction.SetRCommand("return_variable_levels")
        clsRelevelPasteFunction.SetAssignTo("relevel_variables")

        clsConcatenateFunction.SetRCommand("c")

        clsSelectFunction.SetPackageName("dplyr")
        clsSelectFunction.SetRCommand("select")
        clsSelectFunction.AddParameter("concatenate", clsRFunctionParameter:=clsConcatenateFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("columns", clsRFunctionParameter:=clsSelectFunction, iPosition:=1)

        clsRPivotTableFunction.SetPackageName("rpivotTable")
        clsRPivotTableFunction.SetRCommand("rpivotTable")
        clsRPivotTableFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorPivot.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsRPivotTableFunction.SetAssignTo("last_table")

        clsGetDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetDataFrameFunction.AddParameter("stack_data", "TRUE", iPosition:=1)

        clsRPivotTableFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                                   strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                                   strRObjectFormatToAssignTo:=RObjectFormat.Html,
                                                   strRDataFrameNameToAddObjectTo:=ucrSelectorPivot.strCurrentDataFrame,
                                                   strObjectName:="last_table")

        ucrBase.clsRsyntax.SetBaseRFunction(clsRPivotTableFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRcodeSet = False
        ucrSelectorPivot.SetRCode(clsPipeOperator, bReset)
        'ucrReceiverInitialColumnFactor.SetRCode(clsRPivotTableFunction, bReset)
        ucrChkNumericVariable.SetRCode(clsRPivotTableFunction, bReset)
        ucrReceiverInitialRowFactors.SetRCode(clsRPivotTableFunction, bReset)
        ucrSavePivot.SetRCode(clsRPivotTableFunction, bReset)
        ucrChkSelectedVariable.SetRCode(clsRPivotTableFunction, bReset)
        ucrChkIncludeSubTotals.SetRCode(clsDummyFunction, bReset)
        ucrChkFactorsOrder.SetRCode(clsDummyFunction, bReset)
        ucrPnlOptions.SetRCode(clsDummyFunction, bReset)
        bRcodeSet = True
        SetFactorSortingOrder()
        AddingVariable()

    End Sub

    Private Sub TestOkEnabled()
        ' Base condition for enabling OK
        If ucrSavePivot.IsComplete AndAlso Not String.IsNullOrEmpty(ucrSelectorPivot.ucrAvailableDataFrames.cboAvailableDataFrames.Text) Then
            ' Additional conditions only if rdoMultiple is checked
            If rdoMultiple.Checked Then
                If ucrReceiverMultipleAddRows.lstSelectedVariables.Items.Count > 1 Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                        Exit Sub
                    End If

            Else
                ' If any other radio button is checked, enable OK based on the base condition
                ucrBase.OKEnabled(True)
            End If
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
            If rdoSingle.Checked AndAlso ucrChkNumericVariable.Checked Then
                ucrReceiverAdditionalRowFactor.SetMeAsReceiver()
            Else
                ucrReceiverInitialRowFactors.SetMeAsReceiver()
            End If
        End If
        ChangeDataParameterValue()
    End Sub

    Private Sub ucrSelectorPivot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorPivot.ControlValueChanged
        ChangeDataParameterValue()
        AutofillMode()
        SetFactorSortingOrder()
        clsRPivotTableFunction._strDataFrameNameToAddAssignToObject = ucrSelectorPivot.strCurrentDataFrame
        clsGetDataFrameFunction.SetAssignTo(ucrSelectorPivot.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        clsPipeOperator.SetAssignTo(ucrSelectorPivot.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
    End Sub

    Private Sub ChangeDataParameterValue()
        If ucrChkSelectedVariable.Checked Then
            clsRPivotTableFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
        Else
            clsRPivotTableFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorPivot.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        End If
    End Sub

    Private Sub ReceiversChanged(ucrChangedControls As ucrCore) Handles ucrReceiverSelectedVariable.ControlValueChanged,
        ucrReceiverInitialRowFactors.ControlValueChanged, ucrReceiverAdditionalRowFactor.ControlValueChanged
        If Not bRcodeSet Then
            Exit Sub
        End If

        If ucrChkSelectedVariable.Checked Then
            Dim lstColumns As New List(Of String)
            Dim iPosition As Integer = 0
            Dim strColumnVariableName As String = ucrReceiverInitialColumnFactor.GetVariableNames(bWithQuotes:=False)
            Dim strRowVariableName As String = ucrReceiverAdditionalRowFactor.GetVariableNames(bWithQuotes:=False)
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
        End If
        SetFactorSortingOrder()
    End Sub

    Private Sub AutofillMode()
        Select Case enumPivotMode
            Case PivotMode.Prepare
                ucrBase.iHelpTopicID = 319

                ucrReceiverInitialRowFactors.bAutoFill = False

                ucrReceiverInitialColumnFactor.bAutoFill = False

                ucrReceiverAdditionalRowFactor.bAutoFill = False
            Case PivotMode.Describe
                ucrBase.iHelpTopicID = 417

                ucrReceiverInitialRowFactors.bAutoFill = False

                ucrReceiverInitialColumnFactor.bAutoFill = False

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

                ucrBase.iHelpTopicID = 558

                If Not String.IsNullOrEmpty(strRainCol) Then
                    ucrChkNumericVariable.Checked = True
                    ucrReceiverAdditionalRowFactor.Add(strRainCol, strDataFrame)
                Else
                    ucrChkNumericVariable.Checked = False
                End If

                If Not String.IsNullOrEmpty(strMonthCol) Then
                    ucrReceiverInitialColumnFactor.Add(strMonthCol, strDataFrame)
                End If
                If ucrSelectorPivot.lstAvailableVariable.Items.Count > 0 AndAlso
                   Not String.IsNullOrEmpty(strYearCol) AndAlso Not String.IsNullOrEmpty(strDayCol) Then
                    Dim lstItems(1) As KeyValuePair(Of String, String)
                    lstItems(0) = New KeyValuePair(Of String, String)(strDataFrame, strYearCol)
                    lstItems(1) = New KeyValuePair(Of String, String)(strDataFrame, strDayCol)
                    ucrReceiverInitialRowFactors.AddMultiple(lstItems)
                End If
        End Select
    End Sub

    Private Sub SetFactorSortingOrder()

        Dim DataFrame As String = ucrSelectorPivot.strCurrentDataFrame

        ' Ensure clsRelevelPasteFunction is reset before checking conditions
        clsRPivotTableFunction.RemoveParameterByName("sorters")
        clsRelevelPasteFunction.RemoveParameterByName("data")
        clsRelevelPasteFunction.RemoveParameterByName("data_stack")
        clsRPivotTableFunction.RemoveParameterByName("val")

        If ucrChkFactorsOrder.Checked Then
            clsDummyFunction.AddParameter("order", "True", iPosition:=0)
            If rdoSingle.Checked Then
                clsRelevelPasteFunction.AddParameter("data", DataFrame, iPosition:=0, bIncludeArgumentName:=False)
                clsRPivotTableFunction.AddParameter("sorters", clsRFunctionParameter:=clsRelevelPasteFunction, iPosition:=3)
                clsDummyFunction.AddParameter("checked", "single", iPosition:=1)
                If ucrChkNumericVariable.Checked Then
                    clsRPivotTableFunction.AddParameter("val", ucrReceiverAdditionalRowFactor.GetVariableNames, iPosition:=3)
                Else
                    clsRPivotTableFunction.RemoveParameterByName("val")
                End If
            ElseIf rdoMultiple.Checked Then
                clsDummyFunction.AddParameter("checked", "multiple", iPosition:=1)
                clsGetDataFrameFunction.AddParameter("data_name", Chr(34) & DataFrame & Chr(34), iPosition:=0)
                clsGetDataFrameFunction.AddParameter("measure.vars", ucrReceiverMultipleAddRows.GetVariableNames(), iPosition:=2)
                clsRelevelPasteFunction.AddParameter("data_stack", clsRFunctionParameter:=clsGetDataFrameFunction, bIncludeArgumentName:=False)
                clsRPivotTableFunction.AddParameter("sorters", clsRFunctionParameter:=clsRelevelPasteFunction, iPosition:=3)
                clsRPivotTableFunction.AddParameter("val", Chr(34) & "value" & Chr(34), iPosition:=3)
            ElseIf rdoDataFrame.Checked Then
                clsRelevelPasteFunction.AddParameter("data", DataFrame, iPosition:=0, bIncludeArgumentName:=False)
                clsRPivotTableFunction.AddParameter("sorters", clsRFunctionParameter:=clsRelevelPasteFunction, iPosition:=3)
                clsDummyFunction.AddParameter("checked", "dataframe", iPosition:=1)
            End If
        Else
            clsDummyFunction.AddParameter("order", "False", iPosition:=0)
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

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelectedVariable.ControlContentsChanged, ucrChkSelectedVariable.ControlContentsChanged, ucrSavePivot.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged, ucrChkNumericVariable.ControlContentsChanged, ucrReceiverMultipleAddRows.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrChkNumericVariable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkNumericVariable.ControlValueChanged
        If rdoSingle.Checked AndAlso ucrChkNumericVariable.Checked Then
            ucrReceiverAdditionalRowFactor.SetMeAsReceiver()
        ElseIf Not ucrChkNumericVariable.Checked AndAlso ucrChkSelectedVariable.Checked Then
            ucrReceiverSelectedVariable.SetMeAsReceiver()
        Else
            ucrReceiverInitialRowFactors.SetMeAsReceiver()
        End If
        ConfigureLinkedControls()
        SetFactorSortingOrder()
        AddingVariable()
    End Sub

    Private Sub ucrChkFactorsOrder_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFactorsOrder.ControlValueChanged
        SetFactorSortingOrder()
    End Sub

    Private Sub UpdateRendererOptions()
        ' Decide which list to use based on checkbox state
        Dim lstFinalRenderers As String()

        If ucrChkIncludeSubTotals.Checked Then
            lstFinalRenderers = lstSubtotalRenderers
        Else
            lstFinalRenderers = lstNormalRenderers
        End If

        ' Update available items
        ucrInputTableChart.SetItems({}, bAddConditions:=False)
        ucrInputTableChart.SetItems(lstFinalRenderers, bAddConditions:=True)

        ' Set the first item as the default selection if the list is not empty
        If lstFinalRenderers.Length > 0 Then
            ucrInputTableChart.SetText(lstFinalRenderers(0))
        Else
            ucrInputTableChart.SetText("")
        End If

        ' Refresh the control
        ucrInputTableChart.Refresh()
    End Sub

    Private Sub ucrChkIncludeSubTotals_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeSubTotals.ControlValueChanged
        UpdateRendererOptions()
        If ucrChkIncludeSubTotals.Checked Then
            clsRPivotTableFunction.AddParameter("subtotals", "TRUE", iPosition:=3)
        Else
            clsRPivotTableFunction.RemoveParameterByName("subtotals")
        End If
        'ConfigureLinkedControls()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        'If isHandlingChange Then Exit Sub ' Prevent recursion

        'isHandlingChange = True ' Set flag to prevent event re-entry

        '' Store the current checkbox state before switching
        'Dim previousState As Boolean = ucrChkNumericVariable.Checked

        '' Restore the saved state first before updating the variables
        'If rdoSingle.Checked Then
        '    ucrChkNumericVariable.Checked = isChkNumericSingleChecked ' Restore saved state
        '    isChkNumericMultipleChecked = previousState ' Save the current state
        'ElseIf rdoMultiple.Checked Then
        '    ucrChkNumericVariable.Checked = isChkNumericMultipleChecked ' Restore saved state
        '    isChkNumericSingleChecked = previousState ' Save the current state
        'End If

        ' Perform additional actions
        SetFactorSortingOrder()
        ConfigureLinkedControls()
        AddingVariable()
        DialogSize()
        'isHandlingChange = False ' Reset flag
    End Sub


    Private Sub ConfigureLinkedControls()
        '' Set all receivers to be hidden initially
        'ucrReceiverAdditionalRowFactor.Visible = False
        'ucrReceiverMultipleAddRows.Visible = False

        '' Update the checkbox text based on the selected radio button
        'If rdoSingle.Checked Then
        '    ucrChkNumericVariable.SetText("Variable (Optional):")
        'ElseIf rdoMultiple.Checked Then
        '    ucrChkNumericVariable.SetText("Variables:")
        'End If

        '' Ensure the correct receiver is displayed based on checkbox state
        'If ucrChkNumericVariable.Checked Then
        '    If rdoSingle.Checked Then
        '        ucrReceiverAdditionalRowFactor.Visible = True
        '    ElseIf rdoMultiple.Checked Then
        '        ucrReceiverMultipleAddRows.Visible = True
        '    End If
        'End If
    End Sub

    Private Sub ucrReceiverMultipleAddRows_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleAddRows.ControlValueChanged
        SetFactorSortingOrder()
    End Sub

    Private Sub AddingVariable()
        ' Remove "cols" parameter when rdoDataFrame is checked
        If rdoDataFrame.Checked Then
            clsRPivotTableFunction.RemoveParameterByName("cols")
            Exit Sub
        End If

        Dim strVariables As String = ucrReceiverInitialColumnFactor.GetVariableNames()

        ' Check if multiple variables are selected
        If rdoMultiple.Checked Then
            If strVariables <> "" Then
                ' Remove the outer c() if it exists
                strVariables = strVariables.Replace("c(", "").Replace(")", "")
                ' Append "variable" properly
                clsRPivotTableFunction.AddParameter("cols", "c(" & strVariables & ", ""variable"")", iPosition:=2)
            Else
                ' If no variables are selected, just pass "variable" alone
                clsRPivotTableFunction.AddParameter("cols", "c(""variable"")", iPosition:=2)
            End If
        ElseIf rdoSingle.Checked Then
            clsRPivotTableFunction.AddParameter("cols", strVariables, iPosition:=2)
        End If
    End Sub

    Private Sub ucrReceiverInitialColumnFactor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverInitialColumnFactor.ControlValueChanged
        AddingVariable()
    End Sub

    Private Sub DialogSize()
        If rdoSingle.Checked Then
            Me.Size = New Size(433, 606)
            Me.ucrBase.Location = New Point(9, 510)
            ucrSavePivot.Location = New Point(9, 480)
        ElseIf rdoMultiple.Checked Then
            Me.Size = New Size(433, 606)
            Me.ucrBase.Location = New Point(9, 510)
            ucrSavePivot.Location = New Point(9, 480)
        Else
            Me.Size = New Size(433, 430)
            Me.ucrBase.Location = New Point(9, 400)
            ucrSavePivot.Location = New Point(9, 370)
        End If
    End Sub

End Class