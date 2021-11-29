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

Imports System.ComponentModel
Imports instat.Translations
Public Class dlgSelectColumns
    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True
    Public clsAddColumnSelection As New RFunction
    Private clsConditionsList As RFunction
    Private clsFromToOperation As ROperator
    Private Sub dlgSelectColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRcodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrSelectorForColumnSelection.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForColumnSelection.SetParameterIsString()
        ucrSelectorForColumnSelection.HideShowAddOrDataOptionsButton(bDataOptionsVisible:=False)

        ucrReceiverMultipleVariables.Selector = ucrSelectorForColumnSelection
        ucrReceiverMultipleVariables.SetMeAsReceiver()

        ucrReceiverMultipleVariables.SetParameter(New RParameter("x", 0))
        ucrReceiverMultipleVariables.SetParameterIsString()

        ucrInputSelectOperation.SetItems({"Columns", "Starts with", "Ends with", "Contains", "Matches", "Numeric range", "Last column"})
        ucrInputSelectOperation.SetDropDownStyleAsNonEditable()

        ucrInputColumnType.SetItems({"Numeric", "Factor", "Character"})
        ucrInputColumnType.SetDropDownStyleAsNonEditable()

        ucrInputSelectOperation.AddToLinkedControls(ucrChkIgnoreCase, {"Starts with", "Ends with", "Contains", "Matches"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputSelectOperation.AddToLinkedControls(ucrReceiverMultipleVariables, {"Columns"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputSelectOperation.AddToLinkedControls({ucrNudFrom, ucrNudTo}, {"Numeric range"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputSelectOperation.AddToLinkedControls(ucrInputText, {"Numeric range", "Starts with", "Ends with", "Contains", "Matches"}, bNewLinkedHideIfParameterMissing:=True)
        'ucrInputSelectOperation.AddToLinkedControls(ucrInputColumnType, {"Where"}, bNewLinkedHideIfParameterMissing:=True)' TODO: uncomment once selection using where is added
        ucrReceiverMultipleVariables.SetLinkedDisplayControl(lblSeclectedColumns)
        ucrInputText.SetLinkedDisplayControl(lblString)
        ucrNudFrom.SetLinkedDisplayControl(lblFrom)
        ucrNudTo.SetLinkedDisplayControl(lblTo)
        ucrInputColumnType.SetLinkedDisplayControl(lblColumnType)

        ucrChkIgnoreCase.SetParameter(New RParameter("ignore.case", 1))
        ucrChkIgnoreCase.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkIgnoreCase.SetText("Ignore Case")

        ucrInputSelectName.SetItemsTypeAsColumnSelection()
        ucrInputSelectName.SetDataFrameSelector(ucrSelectorForColumnSelection.ucrAvailableDataFrames)
        ucrInputSelectName.SetPrefix("selection")
        ucrInputSelectName.SetDefaultTypeAsColumnSelection()

        ucrSelectPreview.txtInput.ReadOnly = True

        lstColumnSelections.Columns.Add("Operation")
        lstColumnSelections.Columns.Add("Value")

        ucrNudFrom.SetParameter(New RParameter("from", 0))
        ucrNudFrom.SetMinMax(1, Integer.MaxValue)

        ucrNudTo.SetParameter(New RParameter("to", 1))
        ucrNudTo.SetMinMax(1, Integer.MaxValue)
    End Sub

    Private Sub SetDefaults()
        clsAddColumnSelection = New RFunction
        clsConditionsList = New RFunction
        clsFromToOperation = New ROperator

        ucrSelectorForColumnSelection.Reset()
        ucrInputSelectOperation.SetText("Columns")
        ucrInputColumnType.SetText("Numeric")

        clsConditionsList.SetRCommand("list")

        clsFromToOperation.SetOperation(":")
        clsFromToOperation.AddParameter("from", 1, iPosition:=0)
        clsFromToOperation.AddParameter("to", 5, iPosition:=1)
        clsFromToOperation.bSpaceAroundOperation = False

        clsAddColumnSelection.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_column_selection")
        clsAddColumnSelection.AddParameter("column_selection", clsRFunctionParameter:=clsConditionsList, iPosition:=2)
        clsAddColumnSelection.AddParameter("and_or", Chr(34) & "|" & Chr(34), iPosition:=3)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrSelectorForColumnSelection.SetRCode(clsAddColumnSelection, bReset)
        ucrNudFrom.SetRCode(clsFromToOperation, bReset)
        ucrNudTo.SetRCode(clsFromToOperation, bReset)
    End Sub

    Public Sub SetDefaultDataFrame(Optional strDefaultDataframe As String = "")
        If strDefaultDataframe <> "" Then
            ucrSelectorForColumnSelection.SetDataframe(strDefaultDataframe, bEnableDataframe:=False)
            ucrSelectorForColumnSelection.ucrAvailableDataFrames.Enabled = False 'Note: This is potentially a duplication because for some reason setting  bEnableDataframe:=False in line 117 changes internally
        End If
    End Sub

    Private Sub cmdCombineWithAndOr_Click(sender As Object, e As EventArgs) Handles cmdCombineWithAndOr.Click
        If cmdCombineWithAndOr.Text.Contains("All combined with &&") Then
            cmdCombineWithAndOr.Text = "All combined with |"
            clsAddColumnSelection.AddParameter("and_or", Chr(34) & "|" & Chr(34), iPosition:=3)
        Else
            cmdCombineWithAndOr.Text = "All combined with &&"
            clsAddColumnSelection.AddParameter("and_or", Chr(34) & "&" & Chr(34), iPosition:=3)
        End If
    End Sub

    Private Sub ucrInputSelectName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSelectName.ControlValueChanged
        AddRemoveSelectionName()
    End Sub

    Private Sub AddRemoveSelectionName()
        If Not ucrInputSelectName.IsEmpty() Then
            clsAddColumnSelection.AddParameter("name", Chr(34) & ucrInputSelectName.GetText() & Chr(34), iPosition:=1)
        Else
            clsAddColumnSelection.RemoveParameterByName("name")
        End If
    End Sub

    Private Sub cmdAddCondition_Click(sender As Object, e As EventArgs) Handles cmdAddCondition.Click
        Dim clsCurrentConditionList As New RFunction
        Dim clsParametersList As New RFunction
        Dim lviCondition As ListViewItem
        Dim strValue As String = ""

        Dim strOperation As String = ucrInputSelectOperation.GetText()

        clsCurrentConditionList.SetRCommand("list")
        clsParametersList.SetRCommand("list")
        Select Case strOperation
            Case "Columns"
                clsCurrentConditionList.AddParameter("operation", Chr(34) & "base::match" & Chr(34), iPosition:=0)
                clsParametersList.AddParameter("x", ucrReceiverMultipleVariables.GetVariableNames, iPosition:=0)
                strValue = ucrReceiverMultipleVariables.GetVariableNames(False)
            Case "Starts with"
                clsCurrentConditionList.AddParameter("operation", Chr(34) & "tidyselect::starts_with" & Chr(34), iPosition:=0)
                clsParametersList.AddParameter("match", Chr(34) & ucrInputText.GetText & Chr(34), iPosition:=0)
                strValue = ucrInputText.GetText
                If ucrChkIgnoreCase.Checked Then
                    clsParametersList.AddParameter("ignore.case", "TRUE", iPosition:=1)
                Else
                    clsParametersList.AddParameter("ignore.case", "FALSE", iPosition:=1)
                End If
            Case "Ends with"
                clsCurrentConditionList.AddParameter("operation", Chr(34) & "tidyselect::ends_with" & Chr(34), iPosition:=0)
                clsParametersList.AddParameter("match", Chr(34) & ucrInputText.GetText & Chr(34), iPosition:=0)
                strValue = ucrInputText.GetText
                If ucrChkIgnoreCase.Checked Then
                    clsParametersList.AddParameter("ignore.case", "TRUE", iPosition:=1)
                Else
                    clsParametersList.AddParameter("ignore.case", "FALSE", iPosition:=1)
                End If
            Case "Contains"
                clsCurrentConditionList.AddParameter("operation", Chr(34) & "tidyselect::contains" & Chr(34), iPosition:=0)
                clsParametersList.AddParameter("match", Chr(34) & ucrInputText.GetText & Chr(34), iPosition:=0)
                strValue = ucrInputText.GetText
                If ucrChkIgnoreCase.Checked Then
                    clsParametersList.AddParameter("ignore.case", "TRUE", iPosition:=1)
                Else
                    clsParametersList.AddParameter("ignore.case", "FALSE", iPosition:=1)
                End If
            Case "Matches"
                clsCurrentConditionList.AddParameter("operation", Chr(34) & "tidyselect::matches" & Chr(34), iPosition:=0)
                clsParametersList.AddParameter("match", Chr(34) & ucrInputText.GetText & Chr(34), iPosition:=0)
                strValue = ucrInputText.GetText
                If ucrChkIgnoreCase.Checked Then
                    clsParametersList.AddParameter("ignore.case", "TRUE", iPosition:=1)
                Else
                    clsParametersList.AddParameter("ignore.case", "FALSE", iPosition:=1)
                End If
            Case "Numeric range"
                clsCurrentConditionList.AddParameter("operation", Chr(34) & "tidyselect::num_range" & Chr(34), iPosition:=0)
                clsParametersList.AddParameter("prefix", Chr(34) & ucrInputText.GetText & Chr(34), iPosition:=0)
                clsParametersList.AddParameter("range", clsROperatorParameter:=clsFromToOperation, iPosition:=1)
                strValue = clsFromToOperation.ToScript
                'TODO: this will be needed when selection depending of variable type e.g factors,characters etc is added!
                'Case "Where"
                'clsCurrentConditionList.AddParameter("operation", Chr(34) & "where" & Chr(34), iPosition:=0)
                'If ucrInputColumnType.GetText = "Numeric" Then
                'clsParametersList.AddParameter("fn", "is.numeric", iPosition:=0)
                'ElseIf ucrInputColumnType.GetText = "Factor" Then
                'clsParametersList.AddParameter("fn", "is.factor", iPosition:=0)
                'ElseIf ucrInputColumnType.GetText = "Character" Then
                'clsParametersList.AddParameter("fn", "is.character", iPosition:=0)
                'End If
            Case "Last column"
                strValue = "Last column"
                clsCurrentConditionList.AddParameter("operation", Chr(34) & "tidyselect::last_col" & Chr(34), iPosition:=0)
        End Select
        clsCurrentConditionList.AddParameter("parameters", clsRFunctionParameter:=clsParametersList, iPosition:=1)

        clsConditionsList.AddParameter("C" & clsConditionsList.clsParameters.Count, clsRFunctionParameter:=(clsCurrentConditionList))
        lviCondition = New ListViewItem({ucrInputSelectOperation.GetText, strValue})
        lstColumnSelections.Items.Add(lviCondition)
        lstColumnSelections.Columns(0).Width = -2
        lstColumnSelections.Columns(1).Width = -2
        ucrReceiverMultipleVariables.Clear()
        cmdAddCondition.Enabled = False
    End Sub

    Private Sub cmdClearConditions_Click(sender As Object, e As EventArgs) Handles cmdClearConditions.Click
        clsConditionsList.ClearParameters()
        lstColumnSelections.Items.Clear()
    End Sub

    Private Sub EnableDisableAddConditionButton()
        Dim bEnableOrDisable As Boolean = True
        Dim strOperation As String
        strOperation = ucrInputSelectOperation.GetText
        ucrSelectorForColumnSelection.HideShowAddOrDataOptionsButton(strOperation = "Columns", False)
        Select Case strOperation
            Case "Columns"
                If ucrReceiverMultipleVariables.IsEmpty Then
                    bEnableOrDisable = False
                End If
            Case "Starts with", "Ends with", "Contains", "Matches"
                If ucrInputText.IsEmpty Then
                    bEnableOrDisable = False
                End If
            Case "Numeric range"
                If ucrNudFrom.IsEmpty OrElse ucrNudTo.IsEmpty OrElse ucrInputText.IsEmpty Then
                    bEnableOrDisable = False
                End If
            Case "Where"
                'add where instance when enabled
        End Select
        cmdAddCondition.Enabled = bEnableOrDisable
    End Sub

    Private Sub ucrReceiverMultipleVariables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleVariables.ControlValueChanged, ucrInputSelectOperation.ControlValueChanged, ucrNudFrom.ControlValueChanged, ucrNudTo.ControlValueChanged, ucrInputText.ControlContentsChanged
        EnableDisableAddConditionButton()
    End Sub

    Private Sub ucrBase_ClickReturn(sender As Object, e As EventArgs) Handles ucrBase.ClickReturn
        AddRemoveSelectionName()
        If lstColumnSelections.Items.Count > 0 Then
            frmMain.clsRLink.RunScript(clsAddColumnSelection.ToScript, strComment:="Column selection subdialog: Created new column selection", bSilent:=True)
            dlgSelect.ucrReceiverSelect.Add(ucrInputSelectName.GetText())
            lstColumnSelections.Items.Clear()
            clsConditionsList.ClearParameters()
        End If
    End Sub

    Private Sub dlgSelectColumns_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not cmdAddCondition.Enabled Then
            Exit Sub
        End If

        Dim result As MsgBoxResult = MessageBox.Show(
            text:="Are you sure you want to return to the main dialog?" & Environment.NewLine &
                  "The condition for " & ucrInputSelectOperation.GetText & " has not been added." & Environment.NewLine &
                  "Click the ""Add Condition"" button if you want to add it.",
            caption:="Return to main dialog?", buttons:=MessageBoxButtons.YesNo, icon:=MessageBoxIcon.Information)
        e.Cancel = result = MsgBoxResult.No

    End Sub
End Class