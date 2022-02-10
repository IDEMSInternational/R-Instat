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
Imports RDotNet
Imports unvell.ReoGrid
Imports unvell.ReoGrid.Events

Public Class dlgName
    Dim bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Dim bUseSelectedColumn As Boolean = False
    Dim strSelectedColumn As String = ""
    Dim strSelectedDataFrame As String = ""
    Private clsDefaultRFunction As New RFunction
    Private clsRenameColumns As New RFunction
    Private WithEvents grdCurrentWorkSheet As Worksheet
    Private bIncludeCopyOfLevels As Boolean
    Private dctRowsChanged As New Dictionary(Of Integer, String)
    Private dctNameRowsValues As New Dictionary(Of Integer, String)

    Private Sub dlgName_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        If bUseSelectedColumn Then
            SetSelectedColumn()
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 33
        Dim dctCaseOptions As New Dictionary(Of String, String)

        'Selector
        ucrSelectVariables.SetParameter(New RParameter("data_name", 0))
        ucrSelectVariables.SetParameterIsString()

        'Receiver
        ucrReceiverName.SetParameter(New RParameter("column_name", 1))
        ucrReceiverName.SetParameterIsString()
        ucrReceiverName.Selector = ucrSelectVariables

        'New Name Input
        ucrInputNewName.SetParameter(New RParameter("new_val", 2))
        'set validation of ucrInputNewName as an RVariable.(input should not have any R reserved words like 'if','while')
        ucrInputNewName.SetValidationTypeAsRVariable()

        ucrChkIncludeVariable.SetText("Include Variable Labels")

        'Label Input
        ucrInputVariableLabel.SetParameter(New RParameter("label", 3))

        ucrPnlOptions.SetParameter(New RParameter("type", 4))
        ucrPnlOptions.AddRadioButton(rdoSingle, Chr(34) & "single" & Chr(34))
        ucrPnlOptions.AddRadioButton(rdoMultiple, Chr(34) & "" & Chr(34))
        ucrPnlOptions.AddRadioButton(rdoRenameWith, Chr(34) & "multiple" & Chr(34))

        ucrPnlOptions.AddToLinkedControls({ucrReceiverName, ucrInputNewName, ucrInputVariableLabel}, {rdoSingle}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverColumns, {rdoRenameWith}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrPnlCase, {rdoRenameWith}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrChkIncludeVariable, {rdoMultiple}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlCase.AddToLinkedControls(ucrInputCase, {rdoMakeCleanNames}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Snake")
        ucrReceiverName.SetLinkedDisplayControl(lblCurrentName)
        ucrInputNewName.SetLinkedDisplayControl(lblName)
        ucrInputVariableLabel.SetLinkedDisplayControl(lblVariableLabel)
        ucrReceiverColumns.SetLinkedDisplayControl(lblColumns)
        ucrInputCase.SetLinkedDisplayControl(lblCase)
        ucrPnlCase.SetLinkedDisplayControl(grpOptions)
        ucrChkIncludeVariable.SetLinkedDisplayControl(grdRenameColumns)

        ucrPnlCase.SetParameter(New RParameter(".fn", 5))
        ucrPnlCase.AddRadioButton(rdoToLower, "tolower")
        ucrPnlCase.AddRadioButton(rdoMakeCleanNames, "janitor::make_clean_names")

        ucrReceiverColumns.SetParameter(New RParameter(".cols", 6))
        ucrReceiverColumns.Selector = ucrSelectVariables
        ucrReceiverColumns.SetParameterIsString()

        ucrInputCase.SetParameter(New RParameter("case", 7))
        dctCaseOptions.Add("Snake", Chr(34) & "snake" & Chr(34))
        dctCaseOptions.Add("Small camel", Chr(34) & "small_camel" & Chr(34))
        dctCaseOptions.Add("Big camel", Chr(34) & "big_camel" & Chr(34))
        dctCaseOptions.Add("Screaming snake", Chr(34) & "screaming_snake" & Chr(34))
        dctCaseOptions.Add("Parsed", Chr(34) & "parsed" & Chr(34))
        dctCaseOptions.Add("Mixed", Chr(34) & "mixed" & Chr(34))
        dctCaseOptions.Add("Lower upper", Chr(34) & "lower_upper" & Chr(34))
        dctCaseOptions.Add("Upper lower", Chr(34) & "upper_lower" & Chr(34))
        dctCaseOptions.Add("Swap", Chr(34) & "swap" & Chr(34))
        dctCaseOptions.Add("All caps", Chr(34) & "all_caps" & Chr(34))
        dctCaseOptions.Add("Lower camel", Chr(34) & "lower_camel" & Chr(34))
        dctCaseOptions.Add("Upper camel", Chr(34) & "upper_camel" & Chr(34))
        dctCaseOptions.Add("Internal parsing", Chr(34) & "internal_parsing" & Chr(34))
        dctCaseOptions.Add("None", Chr(34) & "none" & Chr(34))
        dctCaseOptions.Add("Flip", Chr(34) & "flip" & Chr(34))
        dctCaseOptions.Add("Sentence", Chr(34) & "sentence" & Chr(34))
        dctCaseOptions.Add("Random", Chr(34) & "random" & Chr(34))
        dctCaseOptions.Add("Title", Chr(34) & "title" & Chr(34))
        ucrInputCase.SetDropDownStyleAsNonEditable()
        ucrInputCase.SetItems(dctCaseOptions)
    End Sub

    Public Sub SetDefaults()
        clsDefaultRFunction = New RFunction

        ucrSelectVariables.Reset()

        clsDefaultRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$rename_column_in_data")
        clsDefaultRFunction.AddParameter("type", Chr(34) & "single" & Chr(34), iPosition:=4)
        clsDefaultRFunction.AddParameter(".fn", "tolower", iPosition:=5)
        clsDefaultRFunction.AddParameter("case", Chr(34) & "snake" & Chr(34), iPosition:=7)

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction)
    End Sub

    Private Sub TestOKEnabled()
        If rdoSingle.Checked Then
            If Not ucrReceiverName.IsEmpty() AndAlso Not ucrInputNewName.IsEmpty() Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoRenameWith.Checked Then
            If Not ucrReceiverColumns.IsEmpty() Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(grdCurrentWorkSheet IsNot Nothing)
        End If
    End Sub

    Private Sub AddChangedRow(iRow As Integer, strNewData As String)
        If Not dctRowsChanged.ContainsKey(iRow) Then
            dctRowsChanged.Add(iRow, strNewData)
        End If
    End Sub

    Private Sub AddRowNameValue(iRow As Integer, strNewData As String)
        If Not dctNameRowsValues.ContainsKey(iRow) Then
            dctNameRowsValues.Add(iRow, strNewData)
        End If
    End Sub

    Private Sub grdCurrSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdCurrentWorkSheet.AfterCellEdit
        AddChangedRow(e.Cell.Row, e.NewData)

        If grdCurrentWorkSheet IsNot Nothing Then
            For i As Integer = 0 To dctNameRowsValues.Keys.Count - 1
                If dctRowsChanged.ContainsKey(i) Then
                    clsRenameColumns.AddParameter(dctRowsChanged(i), dctNameRowsValues(i), iPosition:=i + 1)
                End If
            Next
        End If
    End Sub

    Private Sub UpdateGrid()
        grdRenameColumns.Worksheets.Clear()

        grdCurrentWorkSheet = grdRenameColumns.CreateWorksheet(ucrSelectVariables.strCurrentDataFrame)
        grdCurrentWorkSheet.ColumnCount = 2
        grdCurrentWorkSheet.RowCount = ucrSelectVariables.lstAvailableVariable.Items.Count

        grdCurrentWorkSheet.ColumnHeaders(0).Text = "Name"
        grdCurrentWorkSheet.ColumnHeaders(1).Text = "New Name"

        If rdoMultiple.Checked Then
            If Not ucrSelectVariables.IsEmpty Then
                For i As Integer = 0 To ucrSelectVariables.lstAvailableVariable.Items.Count - 1
                    For j = 0 To grdCurrentWorkSheet.Columns - 1
                        If grdCurrentWorkSheet.ColumnHeaders(j).Text = "Name" Then
                            grdCurrentWorkSheet.Item(row:=i, col:=j) = ucrSelectVariables.lstAvailableVariable.Items(i).Text
                            grdCurrentWorkSheet.GetCell(row:=i, col:=j).IsReadOnly = True
                        ElseIf grdCurrentWorkSheet.ColumnHeaders(j).Text = "New Name" Then
                            grdCurrentWorkSheet.Item(row:=i, col:=j) = ucrSelectVariables.lstAvailableVariable.Items(i).Text
                        End If
                    Next
                Next

                For i As Integer = 0 To grdCurrentWorkSheet.Rows - 1
                    For j As Integer = 0 To grdCurrentWorkSheet.Columns - 1
                        If grdCurrentWorkSheet.ColumnHeaders(j).Text = "Name" Then
                            AddRowNameValue(i, grdCurrentWorkSheet.Item(row:=i, col:=j))
                        End If
                    Next
                Next
            End If
        End If

        If bIncludeCopyOfLevels Then
            grdCurrentWorkSheet.AppendColumns(1)
            grdCurrentWorkSheet.ColumnHeaders(grdCurrentWorkSheet.ColumnCount - 1).Text = "New Label"
            For i As Integer = 0 To GetListColsLabel().Count - 1
                For j As Integer = 0 To grdCurrentWorkSheet.Columns - 1
                    If grdCurrentWorkSheet.ColumnHeaders(j).Text = "New Label" Then
                        grdCurrentWorkSheet.Item(row:=i, col:=j) = GetListColsLabel().Item(i)
                    End If
                Next
            Next
        End If

        grdCurrentWorkSheet.SetRangeDataFormat(New RangePosition(0, 0, grdCurrentWorkSheet.Rows, grdCurrentWorkSheet.Columns), DataFormat.CellDataFormatFlag.Text)
        grdCurrentWorkSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
        grdCurrentWorkSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        grdCurrentWorkSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToFillSerial, False)
        grdCurrentWorkSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.View_AllowCellTextOverflow, False)

        grdRenameColumns.AddWorksheet(grdCurrentWorkSheet)
        grdRenameColumns.SheetTabNewButtonVisible = False
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Public Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedColumn = True
    End Sub

    Private Sub SetSelectedColumn()
        ucrSelectVariables.SetDataframe(strSelectedDataFrame)
        ucrReceiverName.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverName_ControlValueChanged() Handles ucrReceiverName.ControlValueChanged
        'if the receiver is not empty
        If Not ucrReceiverName.IsEmpty Then
            'if the user has not typed anything then change the ucrInputNewName contents
            ucrInputNewName.SetName(ucrReceiverName.GetVariableNames(bWithQuotes:=False))
            'get the label of the column selected(from ucrReceiverName) and set it as ucrInputVariableLabel value
            ucrInputVariableLabel.SetName(GetColLabel())

        Else
            'if the receiver is empty. These 2 controls should be empty
            ucrInputNewName.SetName("")
            ucrInputVariableLabel.SetName("")
        End If

    End Sub

    'Gets the label of the column selected(from ucrReceiverName) 
    Private Function GetColLabel()
        Dim strColLabel As String = ""
        Dim clsColmnLabelsRFunction = New RFunction
        Dim expItems As SymbolicExpression

        clsColmnLabelsRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_labels")
        clsColmnLabelsRFunction.AddParameter("data_name", Chr(34) & ucrSelectVariables.strCurrentDataFrame & Chr(34), iPosition:=0)
        clsColmnLabelsRFunction.AddParameter("columns", ucrReceiverName.GetVariableNames(bWithQuotes:=True), iPosition:=1)

        expItems = frmMain.clsRLink.RunInternalScriptGetValue(clsColmnLabelsRFunction.ToScript(), bSilent:=True)

        If expItems IsNot Nothing AndAlso Not (expItems.Type = Internals.SymbolicExpressionType.Null) Then
            Dim strArr As String() = expItems.AsCharacter.ToArray
            If strArr IsNot Nothing Then
                'the number of labels for a column expected is 1
                If strArr.Length = 1 Then
                    strColLabel = strArr(0)
                ElseIf strArr.Length > 1 Then
                    MessageBox.Show(Me, "Developer error: retrieved column label should be one.", "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    strColLabel = strArr(strArr.Length - 1)
                End If
            End If
        End If
        Return strColLabel
    End Function

    Private Function GetListColsLabel() As List(Of String)
        Dim lstColLabel As New List(Of String)
        Dim clsColmnLabelsRFunction = New RFunction
        Dim expItems As SymbolicExpression

        clsColmnLabelsRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_labels")
        clsColmnLabelsRFunction.AddParameter("data_name", Chr(34) & ucrSelectVariables.strCurrentDataFrame & Chr(34), iPosition:=0)

        'This is to be done in R to avoid the app to slow down when getting the list of label
        For i As Integer = 0 To dctNameRowsValues.Keys.Count - 1
            clsColmnLabelsRFunction.AddParameter("columns", Chr(34) & dctNameRowsValues(i) & Chr(34), iPosition:=i)
            expItems = frmMain.clsRLink.RunInternalScriptGetValue(clsColmnLabelsRFunction.ToScript(), bSilent:=True)
            If expItems IsNot Nothing AndAlso Not (expItems.Type = Internals.SymbolicExpressionType.Null) Then
                Dim strArr As String() = expItems.AsCharacter.ToArray
                If strArr IsNot Nothing Then
                    'the number of labels for a column expected is 1
                    If strArr.Length = 1 Then
                        lstColLabel.Add(strArr(0))
                    ElseIf strArr.Length > 1 Then
                        MessageBox.Show(Me, "Developer error: retrieved column label should be one.", "Developer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        lstColLabel.Add(strArr(strArr.Length - 1))
                    End If
                End If
            End If
        Next
        Return lstColLabel
    End Function

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        If rdoSingle.Checked Then
            ucrReceiverName.SetMeAsReceiver()
        ElseIf rdoRenameWith.Checked Then
            ucrReceiverColumns.SetMeAsReceiver()
        Else
        End If
        UpdateGrid()
    End Sub

    Private Sub ucrChkIncludeVariable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeVariable.ControlValueChanged
        bIncludeCopyOfLevels = If(ucrChkIncludeVariable.Checked, True, False)
        UpdateGrid()
    End Sub

    Private Sub ucrSelectVariables_DataFrameChanged() Handles ucrSelectVariables.DataFrameChanged
        UpdateGrid()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        If Not ucrReceiverColumns.IsEmpty Then
            ucrReceiverColumns.Clear()
        End If
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged() Handles ucrInputNewName.ControlContentsChanged, ucrReceiverName.ControlContentsChanged, ucrReceiverColumns.ControlContentsChanged, ucrSelectVariables.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class
