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

Public Class ucrFilter
    Public bFirstLoad As Boolean
    Public clsFilterView As ROperator
    Public clsFilterFunction As RFunction
    Private clsConditionsList As RFunction
    Public bFilterDefined As Boolean
    Public Event FilterChanged()
    Public strDefaultColumn = ""
    Public strDefaultDataFrame = ""

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bFirstLoad = True
        bFilterDefined = False
        clsFilterView = New ROperator
        clsFilterView.strOperation = "&"
        clsFilterFunction = New RFunction
        clsFilterFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_filter")
        clsConditionsList = New RFunction
        clsConditionsList.SetRCommand("list")
        clsFilterFunction.AddParameter("filter", clsRFunctionParameter:=clsConditionsList)
    End Sub

    Private Sub ucrFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseControl()
            SetDefaults()
            bFirstLoad = False
        End If
        ClearConditions()
        If strDefaultDataFrame <> "" Then
            ucrSelectorForFitler.SetDataframe(strDefaultDataFrame, False)
        End If
        If strDefaultColumn <> "" Then
            ucrFilterByReceiver.Add(strDefaultColumn)
            SetDefaultColumn("")
        End If
    End Sub

    Private Sub InitialiseControl()
        ucrFilterPreview.txtInput.ReadOnly = True
        ucrFilterByReceiver.Selector = ucrSelectorForFitler
        ucrFilterOperation.SetItems({"==", "<", "<=", ">", ">=", "!=", "is.na", "! is.na"})
        ucrFilterOperation.SetDropDownStyleAsNonEditable()
        ucrFactorLevels.SetAsMultipleSelector()
        ucrFactorLevels.SetReceiver(ucrFilterByReceiver)
        ucrFactorLevels.SetIncludeLevels(False)
        ucrFactorLevels.bIncludeNA = True
        clsFilterView.bForceIncludeOperation = False
        lstFilters.Columns.Add("Variable")
        lstFilters.Columns.Add("Condition")
        ucrInputFilterName.SetItemsTypeAsFilters()
        ucrInputFilterName.SetDataFrameSelector(ucrSelectorForFitler.ucrAvailableDataFrames)
        ucrInputFilterName.SetPrefix("Filter")
        ucrInputFilterName.SetDefaultTypeAsFilter()
        ucrSelectorForFitler.btnDataOptions.Visible = False
        ucrLogicalCombobox.SetItems({"TRUE", "FALSE"})
        ucrLogicalCombobox.SetDropDownStyleAsNonEditable()
        ttpCombineWithAndOr.SetToolTip(cmdCombineWithAndOr, "With more than one condition, e.g. (year > 1990) & (year < 2021) they have all to be TRUE.")
    End Sub

    Private Sub SetDefaults()
        ucrFilterOperation.SetName("==")
        ucrLogicalCombobox.SetName("TRUE")
        ucrFilterByReceiver.SetMeAsReceiver()
        VariableTypeProperties()
    End Sub

    Private Sub VariableTypeProperties()
        ucrReceiverExpression.Visible = False
        lblSelectLevels.Visible = False
        ucrFactorLevels.Visible = False
        cmdToggleSelectAll.Visible = False
        ucrFilterOperation.Visible = False
        ucrLogicalCombobox.Visible = False
        ucrDatePicker.Visible = False
        grpNumeric.Visible = False
        If Not ucrFilterByReceiver.IsEmpty() Then
            If ucrFilterByReceiver.strCurrDataType.ToLower.Contains("factor") Then
                lblSelectLevels.Visible = True
                ucrFactorLevels.Visible = True
                cmdToggleSelectAll.Visible = True
                'ucrFactorLevels.SetSelectionAllLevels(False) 'by default don't select any factors
                SetToggleButtonSettings()
            Else
                ucrFilterOperation.Visible = True
                If ucrFilterOperation.GetText() <> "is.na" AndAlso ucrFilterOperation.GetText() <> "! is.na" Then
                    Select Case ucrFilterByReceiver.strCurrDataType.ToLower
                        Case "logical"
                            ucrLogicalCombobox.Visible = True
                        Case "date"
                            ucrDatePicker.Visible = True
                        Case Else
                            ucrReceiverExpression.Visible = True
                            grpNumeric.Visible = True
                    End Select
                End If
            End If
        End If
    End Sub

    Private Sub CheckAddEnabled()
        If (ucrFilterByReceiver.IsEmpty() AndAlso ucrReceiverExpression.bIsVisible AndAlso ucrReceiverExpression.IsEmpty()) OrElse ucrFilterByReceiver.IsEmpty() Then
            cmdAddCondition.Enabled = False
        Else
            If ucrFilterByReceiver.strCurrDataType.ToLower.Contains("factor") Then
                cmdAddCondition.Enabled = Not String.IsNullOrEmpty(ucrFactorLevels.GetSelectedLevels())
            Else
                Select Case ucrFilterOperation.GetText()
                    Case "is.na", "! is.na"
                        cmdAddCondition.Enabled = True
                    Case Else
                        Select Case ucrFilterByReceiver.strCurrDataType.ToLower
                            Case "logical"
                                cmdAddCondition.Enabled = Not ucrLogicalCombobox.IsEmpty
                            Case "date"
                                cmdAddCondition.Enabled = Not IsNothing(ucrDatePicker.DateValue())
                            Case Else
                                cmdAddCondition.Enabled = Not ucrReceiverExpression.IsEmpty
                        End Select
                End Select
            End If
        End If
    End Sub

    Private Sub SetToggleButtonSettings()
        If ucrFactorLevels.IsAllSelected() Then
            cmdToggleSelectAll.Text = "Deselect All Levels"
            cmdToggleSelectAll.FlatStyle = FlatStyle.Flat
        Else
            cmdToggleSelectAll.Text = "Select All Levels"
            cmdToggleSelectAll.FlatStyle = FlatStyle.Popup
        End If
    End Sub

    Private Sub ucrValueForFilter_ContentsChanged()
        CheckAddEnabled()
    End Sub

    Private Sub ucrFilterReceiver_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrFilterByReceiver.ControlContentsChanged
        'for logical columns add {"==", "is.na", "!is.na"} only
        Dim selectedIndex As Integer = ucrFilterOperation.GetSetSelectedIndex
        ucrFilterOperation.SetItems(If(ucrFilterByReceiver.strCurrDataType.ToLower = "logical", {"==", "is.na", "! is.na"}, {"==", "<", "<=", ">", ">=", "!=", "is.na", "! is.na"}))
        If ucrFilterByReceiver.strCurrDataType.ToLower IsNot "logical" AndAlso selectedIndex < ucrFilterOperation.GetItemsCount Then
            ucrFilterOperation.GetSetSelectedIndex = selectedIndex
        Else
            ucrFilterOperation.GetSetSelectedIndex = 0
        End If
        VariableTypeProperties()
        CheckAddEnabled()
    End Sub

    Private Sub ucrFilterOperation_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrFilterOperation.ControlContentsChanged
        VariableTypeProperties()
        CheckAddEnabled()
    End Sub

    Private Sub ucrReceiverExpression_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverExpression.ControlContentsChanged
        CheckAddEnabled()
    End Sub

    Private Sub cmdAddFilter_Click(sender As Object, e As EventArgs) Handles cmdAddCondition.Click
        Dim clsCurrentConditionView As New ROperator
        Dim clsCurrentConditionList As New RFunction
        Dim lviCondition As ListViewItem
        Dim strCondition As String
        Dim clsDateFunction As RFunction

        clsCurrentConditionList.SetRCommand("list")
        clsCurrentConditionView.AddParameter(iPosition:=0, strParameterValue:=ucrFilterByReceiver.GetVariableNames(False))
        clsCurrentConditionList.AddParameter("column", ucrFilterByReceiver.GetVariableNames())
        If ucrFilterByReceiver.strCurrDataType.Contains("factor") Then
            clsCurrentConditionView.SetOperation("%in%")
            clsCurrentConditionList.AddParameter("operation", Chr(34) & "%in%" & Chr(34))
            strCondition = ucrFactorLevels.GetSelectedLevels()
        Else
            clsCurrentConditionView.SetOperation(ucrFilterOperation.GetText())
            clsCurrentConditionList.AddParameter("operation", Chr(34) & ucrFilterOperation.GetText() & Chr(34))
            If ucrFilterOperation.GetText() = "is.na" OrElse ucrFilterOperation.GetText() = "! is.na" Then
                strCondition = ""
            Else
                If ucrFilterByReceiver.strCurrDataType.ToLower = "character" Then
                    strCondition = Chr(34) & ucrReceiverExpression.GetText() & Chr(34)
                ElseIf ucrFilterByReceiver.strCurrDataType.ToLower = "date" Then
                    clsDateFunction = ucrDatePicker.ValueAsRDate()
                    strCondition = clsDateFunction.ToScript()
                ElseIf ucrFilterByReceiver.strCurrDataType.ToLower = "logical" Then
                    strCondition = ucrLogicalCombobox.GetText()
                Else
                    strCondition = ucrReceiverExpression.GetText()
                End If
            End If
        End If
        If Not String.IsNullOrEmpty(strCondition) Then
            clsCurrentConditionView.AddParameter("condition", strCondition.Replace(Chr(34), Chr(39)))
            clsCurrentConditionList.AddParameter("value", strCondition)
        End If
        clsConditionsList.AddParameter("C" & clsConditionsList.clsParameters.Count, clsRFunctionParameter:=(clsCurrentConditionList))
        lviCondition = New ListViewItem({ucrFilterByReceiver.GetVariableNames(), clsCurrentConditionView.strOperation & " " & strCondition})
        lstFilters.Items.Add(lviCondition)
        If clsFilterView.clsParameters.Count = 0 Then
            clsFilterView.AddParameter(iPosition:=0, clsROperatorParameter:=(clsCurrentConditionView))
        Else
            clsFilterView.AddParameter(strParameterName:="Condition" & clsFilterView.clsParameters.Count - 1, clsROperatorParameter:=(clsCurrentConditionView))
        End If
        lstFilters.Columns(0).Width = -2
        lstFilters.Columns(1).Width = -2
        ucrFilterPreview.SetName(clsFilterView.ToScript())
        ucrFilterByReceiver.Clear()
        ucrReceiverExpression.AddtoCombobox(ucrReceiverExpression.GetText)
        RaiseEvent FilterChanged()
    End Sub

    Private Sub cmdToggleSelectAll_Click(sender As Object, e As EventArgs) Handles cmdToggleSelectAll.Click
        ucrFactorLevels.SetSelectionAllLevels(Not ucrFactorLevels.IsAllSelected())
    End Sub

    Private Sub ucrFactorLevels_SelectedLevelChanged() Handles ucrFactorLevels.SelectedLevelChanged
        SetToggleButtonSettings()
        CheckAddEnabled()
    End Sub

    Private Sub ucrSelectorForFitler_DataFrameChanged() Handles ucrSelectorForFitler.DataFrameChanged
        ClearConditions()
        clsFilterFunction.AddParameter("data_name", Chr(34) & ucrSelectorForFitler.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
    End Sub

    Private Sub cmdClearConditions_Click(sender As Object, e As EventArgs) Handles cmdClearConditions.Click
        ClearConditions()
    End Sub

    Private Sub ucrFilter_FilterChanged() Handles Me.FilterChanged
        bFilterDefined = lstFilters.Items.Count > 0
    End Sub

    Private Sub ucrInputFilterName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputFilterName.ControlValueChanged
        If clsFilterFunction IsNot Nothing Then
            If Not ucrInputFilterName.IsEmpty() Then
                clsFilterFunction.AddParameter("filter_name", Chr(34) & ucrInputFilterName.GetText() & Chr(34))
            Else
                clsFilterFunction.RemoveParameterByName("filter_name")
            End If
        End If
    End Sub

    Private Sub ClearConditions()
        clsFilterView.ClearParameters()
        clsConditionsList.ClearParameters()
        lstFilters.Items.Clear()
        ucrFilterPreview.SetName("")
        RaiseEvent FilterChanged()
    End Sub

    Public Function GetFilteredVariables(Optional bWithQuotes As Boolean = True) As List(Of String)
        Dim lstVariables As New List(Of String)

        For Each itmTemp As ListViewItem In lstFilters.Items
            If bWithQuotes Then
                lstVariables.Add(itmTemp.Text)
            Else
                lstVariables.Add(itmTemp.Text.Replace(Chr(34), ""))
            End If
        Next
        Return lstVariables
    End Function

    Public Sub SetDefaultColumn(strColumn As String)
        strDefaultColumn = strColumn
    End Sub

    Public Sub SetDefaultDataFrame(strDataFrame As String)
        strDefaultDataFrame = strDataFrame
    End Sub

    Private Sub cmd7_Click(sender As Object, e As EventArgs) Handles cmd7.Click
        ucrReceiverExpression.AddToReceiverAtCursorPosition("7")
    End Sub

    Private Sub cmd8_Click(sender As Object, e As EventArgs) Handles cmd8.Click
        ucrReceiverExpression.AddToReceiverAtCursorPosition("8")
    End Sub

    Private Sub cmd9_Click(sender As Object, e As EventArgs) Handles cmd9.Click
        ucrReceiverExpression.AddToReceiverAtCursorPosition("9")
    End Sub

    Private Sub cmdDivide_Click(sender As Object, e As EventArgs) Handles cmdDivide.Click
        ucrReceiverExpression.AddToReceiverAtCursorPosition("/")
    End Sub

    Private Sub cmdDot_Click(sender As Object, e As EventArgs) Handles cmdDot.Click
        ucrReceiverExpression.AddToReceiverAtCursorPosition(".")
    End Sub

    Private Sub cmd4_Click(sender As Object, e As EventArgs) Handles cmd4.Click
        ucrReceiverExpression.AddToReceiverAtCursorPosition("4")
    End Sub

    Private Sub cmd5_Click(sender As Object, e As EventArgs) Handles cmd5.Click
        ucrReceiverExpression.AddToReceiverAtCursorPosition("5")
    End Sub

    Private Sub cmd6_Click(sender As Object, e As EventArgs) Handles cmd6.Click
        ucrReceiverExpression.AddToReceiverAtCursorPosition("6")
    End Sub

    Private Sub cmdMultiply_Click(sender As Object, e As EventArgs) Handles cmdMultiply.Click
        ucrReceiverExpression.AddToReceiverAtCursorPosition("*")
    End Sub

    Private Sub cmdPower_Click(sender As Object, e As EventArgs) Handles cmdPower.Click
        ucrReceiverExpression.AddToReceiverAtCursorPosition("^")
    End Sub

    Private Sub cmd1_Click(sender As Object, e As EventArgs) Handles cmd1.Click
        ucrReceiverExpression.AddToReceiverAtCursorPosition("1")
    End Sub

    Private Sub cmd2_Click(sender As Object, e As EventArgs) Handles cmd2.Click
        ucrReceiverExpression.AddToReceiverAtCursorPosition("2")
    End Sub

    Private Sub cmd3_Click(sender As Object, e As EventArgs) Handles cmd3.Click
        ucrReceiverExpression.AddToReceiverAtCursorPosition("3")
    End Sub

    Private Sub cmdMinus_Click(sender As Object, e As EventArgs) Handles cmdMinus.Click
        ucrReceiverExpression.AddToReceiverAtCursorPosition("-")
    End Sub

    Private Sub cmdComma_Click(sender As Object, e As EventArgs) Handles cmdComma.Click
        ucrReceiverExpression.AddToReceiverAtCursorPosition(",")
    End Sub

    Private Sub cmd0_Click(sender As Object, e As EventArgs) Handles cmd0.Click
        ucrReceiverExpression.AddToReceiverAtCursorPosition("0")
    End Sub

    Private Sub cmdBrackets_Click(sender As Object, e As EventArgs) Handles cmdBrackets.Click
        ucrReceiverExpression.AddToReceiverAtCursorPosition("()", 1)
    End Sub

    Private Sub cmdPlus_Click(sender As Object, e As EventArgs) Handles cmdPlus.Click
        ucrReceiverExpression.AddToReceiverAtCursorPosition("+")
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ucrReceiverExpression.Clear()
    End Sub

    ''' <summary> Handles event triggered when cmdCombineWithAndOr Button is clicked.
    ''' The purpose of this button is to change the filter operator to either AND(&amp;) or OR(|).
    ''' The user clicks the button to trigger a change in the operator. 
    ''' This subroutine changes the oparator, passes "and_or" parameter into clsFilterFunction, 
    ''' updates the button label and set the tooltip text for the button.
    ''' Filter preview is also updated.
    ''' Button text and the tooltip displayed on hover is changed whenever the button is clicked.
    ''' </summary>
    ''' <param name="sender"> Not used. </param>
    ''' <param name="e"> Not used. </param>
    Private Sub cmdCombineWithAndOr_Click(sender As Object, e As EventArgs) Handles cmdCombineWithAndOr.Click
        If cmdCombineWithAndOr.Text.Contains("All combined with |") Then
            clsFilterView.strOperation = "&"
            clsFilterFunction.AddParameter("and_or", Chr(34) & "&" & Chr(34), iPosition:=3)
            cmdCombineWithAndOr.Text = " All combined with &&"
            ttpCombineWithAndOr.SetToolTip(cmdCombineWithAndOr, "With more than one condition, e.g. (year > 1990) & (year < 2021) they have all to be TRUE.")
        Else
            clsFilterView.strOperation = "|"
            clsFilterFunction.AddParameter("and_or", Chr(34) & "|" & Chr(34), iPosition:=3)
            cmdCombineWithAndOr.Text = "All combined with |"
            ttpCombineWithAndOr.SetToolTip(cmdCombineWithAndOr, "With more than one condition, e.g. (sunhrs >14) | (sunhrs <0) then just one need be TRUE.")
        End If
        ucrFilterPreview.SetName(clsFilterView.ToScript())
    End Sub
End Class
