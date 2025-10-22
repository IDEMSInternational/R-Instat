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
    Private bUseSelectedColumn As Boolean = False
    Private strSelectedColumn As String = ""
    Private strSelectedDataFrame As String = ""
    Private strEmpty As String = " "
    Private clsDefaultRFunction As New RFunction
    Private clsNewColNameDataframeFunction As New RFunction
    Private clsNewLabelDataframeFunction As New RFunction
    Private clsDummyFunction As New RFunction
    Private clsFixedFunction As New RFunction
    Private clsStartwithFunction, clsRegexFunction, clsEndswithFunction, clsMatchesFunction, clsContainsFunction As New RFunction
    Private WithEvents grdCurrentWorkSheet As Worksheet
    Private dctRowsNewNameChanged As New Dictionary(Of Integer, String)
    Private dctRowsCurrentName As New Dictionary(Of Integer, String)
    Private dctRowsNewLabelChanged As New Dictionary(Of Integer, String)
    Private dctNameRowsValues As New Dictionary(Of Integer, String)
    Private dctCaseOptions As New Dictionary(Of String, String)
    Private dctReplace As New Dictionary(Of String, String)
    Private bCurrentCell As Boolean = False

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
        DialogueSize()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 33

        ucrSelectVariables.SetParameter(New RParameter("data_name", 0))
        ucrSelectVariables.SetParameterIsString()

        ucrReceiverName.SetParameter(New RParameter("column_name", 1))
        ucrReceiverName.SetParameterIsString()
        ucrReceiverName.Selector = ucrSelectVariables

        ucrInputNewName.SetParameter(New RParameter("new_val", 2))
        'set validation of ucrInputNewName as an RVariable.(input should not have any R reserved words like 'if','while')
        ucrInputNewName.SetValidationTypeAsRVariable()

        ucrChkIncludeVariable.SetText("Include Variable Labels")
        ucrChkIncludeVariable.AddParameterValuesCondition(True, "checked", "True")
        ucrChkIncludeVariable.AddParameterValuesCondition(False, "checked", "False")

        ucrChkIncludeVariable.AddParameterValuesCondition(True, "check", "True")
        ucrChkIncludeVariable.AddParameterValuesCondition(False, "check", "False")

        ucrInputVariableLabel.SetParameter(New RParameter("label", 3))

        ucrPnlOptions.SetParameter(New RParameter("type", 4))
        ucrPnlOptions.AddRadioButton(rdoSingle)
        ucrPnlOptions.AddRadioButton(rdoMultiple)
        ucrPnlOptions.AddRadioButton(rdoRenameWith)
        ucrPnlOptions.AddRadioButton(rdoLabels)
        ucrPnlOptions.AddParameterValuesCondition(rdoSingle, "name", "single")
        ucrPnlOptions.AddParameterValuesCondition(rdoMultiple, "name", "multiple")
        ucrPnlOptions.AddParameterValuesCondition(rdoRenameWith, "name", "rename")
        ucrPnlOptions.AddParameterValuesCondition(rdoLabels, "name", "labels")

        ucrNudAbbreviate.SetParameter(New RParameter("minlength", 10))
        ucrNudAbbreviate.SetMinMax(Integer.MinValue, Integer.MaxValue)

        ucrPnlCase.SetParameter(New RParameter(".fn", 5))
        ucrPnlCase.AddRadioButton(rdoMakeCleanNames, "janitor::make_clean_names")
        ucrPnlCase.AddRadioButton(rdoToLower, "tolower")
        ucrPnlCase.AddRadioButton(rdoAbbreviate, "abbreviate")
        ucrPnlCase.AddRadioButton(rdoReplace, "stringr::str_replace")


        ucrPnlSelectData.AddRadioButton(rdoWholeDataFrame)
        ucrPnlSelectData.AddRadioButton(rdoSelectedColumn)
        ucrPnlSelectData.AddParameterValuesCondition(rdoWholeDataFrame, "checked", "whole")
        ucrPnlSelectData.AddParameterValuesCondition(rdoSelectedColumn, "checked", "selected")

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

        ucrInputEdit.SetParameter(New RParameter("edit", 7))
        dctReplace.Add("Starts With", Chr(34) & "starts_with" & Chr(34))
        dctReplace.Add("Ends With", Chr(34) & "ends_with" & Chr(34))
        dctReplace.Add("Matches", Chr(34) & "matches" & Chr(34))
        dctReplace.Add("Contains", Chr(34) & "contains" & Chr(34))
        dctReplace.Add("Matches All", Chr(34) & "contains" & Chr(34))
        dctReplace.Add("Contains All", Chr(34) & "contains" & Chr(34))
        ucrInputEdit.SetDropDownStyleAsNonEditable()
        ucrInputEdit.SetItems(dctReplace)

        ucrInputBy.SetParameter(New RParameter("replacement", 2))
        ucrInputBy.SetLinkedDisplayControl(lblBy)

        ucrInputReplace.SetParameter(New RParameter("pattern", 2))
        ucrInputReplace.SetLinkedDisplayControl(lblReplace)

        ucrChkIncludeRegularExpressions.SetText("Include Regular Expressions")

        ucrChkIncludeRegularExpressions.SetParameter(New RParameter("check", 0))
        ucrChkIncludeRegularExpressions.SetValuesCheckedAndUnchecked(True, False)

        ucrPnlOptions.AddToLinkedControls({ucrReceiverName, ucrInputNewName, ucrInputVariableLabel}, {rdoSingle}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrChkIncludeVariable, {rdoMultiple}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrPnlCase, ucrPnlSelectData}, {rdoRenameWith, rdoLabels}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlCase.AddToLinkedControls(ucrInputCase, {rdoMakeCleanNames}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Snake")
        ucrPnlCase.AddToLinkedControls(ucrNudAbbreviate, {rdoAbbreviate}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="8")
        ucrPnlCase.AddToLinkedControls(ucrInputReplace, {rdoReplace}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlCase.AddToLinkedControls(ucrInputBy, {rdoReplace}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrPnlCase.AddToLinkedControls(ucrInputEdit, {rdoReplace}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Starts With")
        ucrPnlSelectData.AddToLinkedControls(ucrReceiverColumns, {rdoSelectedColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverName.SetLinkedDisplayControl(lblCurrentName)
        ucrInputNewName.SetLinkedDisplayControl(lblName)
        ucrInputVariableLabel.SetLinkedDisplayControl(lblVariableLabel)
        ucrReceiverColumns.SetLinkedDisplayControl(lblColumns)
        ucrInputCase.SetLinkedDisplayControl(lblCase)
        ucrPnlCase.SetLinkedDisplayControl(grpOptions)
        ucrChkIncludeVariable.SetLinkedDisplayControl(grdRenameColumns)
        ucrInputBy.SetLinkedDisplayControl(lblBy)
        ucrInputReplace.SetLinkedDisplayControl(lblReplace)
        DialogueSize()
    End Sub

    Private Sub SetDefaults()
        clsDefaultRFunction = New RFunction
        clsNewColNameDataframeFunction = New RFunction
        clsNewLabelDataframeFunction = New RFunction
        clsDummyFunction = New RFunction
        clsStartwithFunction = New RFunction
        clsEndswithFunction = New RFunction
        clsMatchesFunction = New RFunction
        clsContainsFunction = New RFunction
        clsRegexFunction = New RFunction
        clsFixedFunction = New RFunction

        ucrSelectVariables.Reset()
        dctRowsNewNameChanged.Clear()
        dctRowsNewLabelChanged.Clear()
        dctRowsCurrentName.Clear()
        bCurrentCell = False
        clsNewColNameDataframeFunction.SetRCommand("data.frame")

        clsNewLabelDataframeFunction.SetRCommand("data.frame")

        clsDummyFunction.AddParameter("checked", "FALSE", iPosition:=0)
        clsDummyFunction.AddParameter("checked", "whole", iPosition:=1)
        clsDummyFunction.AddParameter("name", "single", iPosition:=2)
        clsDummyFunction.AddParameter("check", False, iPosition:=3)

        clsDefaultRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$rename_column_in_data")
        clsDefaultRFunction.AddParameter("type", Chr(34) & "single" & Chr(34), iPosition:=4)
        clsDefaultRFunction.AddParameter(".fn", "janitor::make_clean_names", iPosition:=5)
        clsDefaultRFunction.AddParameter("case", Chr(34) & "snake" & Chr(34), iPosition:=7)
        clsDefaultRFunction.AddParameter("minlength", "8", iPosition:=10)

        clsContainsFunction.SetPackageName("tidyselect")
        clsContainsFunction.SetRCommand("contains")
        clsContainsFunction.AddParameter("match", Chr(34) & ucrInputReplace.GetText & Chr(34), bIncludeArgumentName:=False, iPosition:=0)

        clsMatchesFunction.SetPackageName("tidyselect")
        clsMatchesFunction.SetRCommand("matches")
        clsMatchesFunction.AddParameter("match", Chr(34) & ucrInputReplace.GetText & Chr(34), bIncludeArgumentName:=False, iPosition:=0)

        clsEndswithFunction.SetPackageName("tidyselect")
        clsEndswithFunction.SetRCommand("ends_with")
        clsEndswithFunction.AddParameter("match", Chr(34) & ucrInputReplace.GetText & Chr(34), bIncludeArgumentName:=False, iPosition:=0)

        clsStartwithFunction.SetPackageName("tidyselect")
        clsStartwithFunction.SetRCommand("starts_with")
        clsStartwithFunction.AddParameter("match", Chr(34) & ucrInputReplace.GetText & Chr(34), bIncludeArgumentName:=False, iPosition:=0)

        clsFixedFunction.SetPackageName("stringr")
        clsFixedFunction.SetRCommand("fixed")

        clsRegexFunction.SetPackageName("stringr")
        clsRegexFunction.SetRCommand("regex")
        clsRegexFunction.AddParameter("ignore_case", "FALSE", bIncludeArgumentName:=False, iPosition:=3)
        clsRegexFunction.AddParameter("multiline", "FALSE", iPosition:=4)
        clsRegexFunction.AddParameter("comments", "FALSE", iPosition:=5)

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputReplace.AddAdditionalCodeParameterPair(clsStartwithFunction, New RParameter("match", bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrInputReplace.AddAdditionalCodeParameterPair(clsEndswithFunction, New RParameter("match", bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrInputReplace.AddAdditionalCodeParameterPair(clsMatchesFunction, New RParameter("match", bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)
        ucrInputReplace.AddAdditionalCodeParameterPair(clsContainsFunction, New RParameter("match", bNewIncludeArgumentName:=False), iAdditionalPairNo:=4)

        ucrSelectVariables.SetRCode(clsDefaultRFunction, bReset)
        ucrReceiverName.SetRCode(clsDefaultRFunction, bReset)
        ucrInputNewName.SetRCode(clsDefaultRFunction, bReset)
        ucrInputVariableLabel.SetRCode(clsDefaultRFunction, bReset)
        ucrChkIncludeRegularExpressions.SetRCode(clsDummyFunction, bReset)
        If bReset Then
            ucrPnlCase.SetRCode(clsDefaultRFunction, bReset)
            ucrInputReplace.SetRCode(clsDefaultRFunction, bReset)
            ucrChkIncludeVariable.SetRCode(clsDummyFunction, bReset)
            ucrPnlSelectData.SetRCode(clsDummyFunction, bReset)
            ucrPnlOptions.SetRCode(clsDummyFunction, bReset)
        End If
        ucrInputCase.SetRCode(clsDefaultRFunction, bReset)
        ucrNudAbbreviate.SetRCode(clsDefaultRFunction, bReset)
        ucrInputBy.SetRCode(clsDefaultRFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If rdoSingle.Checked Then
            ucrBase.OKEnabled(Not ucrReceiverName.IsEmpty() AndAlso Not ucrInputNewName.IsEmpty)
        ElseIf rdoMultiple.Checked Then
            ucrBase.OKEnabled(bCurrentCell)
        Else
            If rdoWholeDataFrame.Checked Then
                ucrBase.OKEnabled(rdoWholeDataFrame.Checked)
            Else
                ucrBase.OKEnabled(Not ucrReceiverColumns.IsEmpty)
            End If
        End If
    End Sub

    Private Sub AddChangedNewNameRows(iRow As Integer, strNewData As String)
        If Not dctRowsNewNameChanged.ContainsKey(iRow) Then
            dctRowsNewNameChanged.Add(iRow, strNewData)
        Else
            dctRowsNewNameChanged(iRow) = strNewData
        End If
    End Sub

    Private Sub AddChangedNewLabelRows(iRow As Integer, strNewData As String)
        'TODO this need to be implemented in the appropriare ucrControl
        If Not dctRowsNewLabelChanged.ContainsKey(iRow) Then
            dctRowsNewLabelChanged.Add(iRow, strNewData)
        Else
            dctRowsNewLabelChanged(iRow) = strNewData
        End If
    End Sub

    Private Sub AddRowNameValue(iRow As Integer, strNewData As String)
        'TODO this need to be implemented in the appropriare ucrControl
        If Not dctNameRowsValues.ContainsKey(iRow) Then
            dctNameRowsValues.Add(iRow, strNewData)
        End If
    End Sub

    Private Function GetValuesAsVector(dctValues As Dictionary(Of Integer, String)) As String
        'TODO this need to be implemented in the appropriare ucrControl
        Dim strValue As String = ""
        Dim i As Integer
        strValue = strValue & "c("
        For Each iRow As Integer In dctValues.Keys
            If i > 0 Then
                strValue = strValue & ","
            End If
            strValue = strValue & Chr(34) & dctValues(iRow) & Chr(34)
            i = i + 1
        Next
        strValue = strValue & ")"
        Return strValue
    End Function

    Private Sub ValidateNamesFromDictionary(iColIndex As Integer)
        'TODO this needs to be implemented in the appropriate ucrControl
        Select Case iColIndex
            Case 1
                For Each strValue In dctRowsNewNameChanged.Values
                    Dim parsedValue As Boolean
                    If String.IsNullOrEmpty(strValue) _
                            OrElse containsFrench(strValue) _
                            OrElse Boolean.TryParse(strValue, parsedValue) _
                            OrElse strValue.ToLower.Equals("t") OrElse strValue.ToLower.Equals("f") _
                            OrElse IsNumeric(strValue) Then
                        MsgBoxTranslate("The column name must not be a numeric or French accent or be a boolean e.g TRUE, FALSE, T, F.")
                        bCurrentCell = False
                        Exit For
                    End If
                    bCurrentCell = True
                Next
            Case 2
                bCurrentCell = True
        End Select
        TestOKEnabled()
    End Sub

    Private Function ValidateRVariable(strText As String, iCol As Integer) As String
        'TODO this need to be implemented in the appropriare ucrControl
        Dim strNewDataText As String = strText
        If iCol = 1 Then
            For Each chrCurr In strNewDataText
                If Not Char.IsLetterOrDigit(chrCurr) AndAlso Not chrCurr = "." AndAlso Not chrCurr = "_" Then
                    strNewDataText = strNewDataText.Replace(chrCurr, ".")
                End If
            Next
        End If
        Return strNewDataText
    End Function

    Private Sub grdCurrentWorkSheet_AfterPaste(sender As Object, e As RangeEventArgs) Handles grdCurrentWorkSheet.AfterPaste
        Dim iStartRowIndex As Integer = grdCurrentWorkSheet.SelectionRange.Row
        Dim iColIndex As Integer = grdCurrentWorkSheet.SelectionRange.Col

        If e.Range.Rows > 1 Then
            For iRow As Integer = iStartRowIndex To grdCurrentWorkSheet.SelectionRange.EndRow
                Dim strNewData As String = ValidateRVariable(grdCurrentWorkSheet.GetCellData(row:=iRow, col:=iColIndex), iColIndex)
                Dim strOldData As String = grdCurrentWorkSheet.GetCellData(row:=iRow, col:=0)
                GetOldNames(iRow, strOldData)
                RenameColumns(strNewData, iRow, iColIndex)
            Next
        Else
            Dim strNewData As String = ValidateRVariable(grdCurrentWorkSheet.GetCellData(row:=e.Range.Row, col:=iColIndex), iColIndex)
            Dim strOldData As String = grdCurrentWorkSheet.GetCellData(row:=e.Range.Row, col:=0)
            GetOldNames(e.Range.Row, strOldData)
            RenameColumns(strNewData, iStartRowIndex, iColIndex)
        End If
        ValidateNamesFromDictionary(iColIndex)
    End Sub

    Private Sub GetSelectedRows()
        For i As Integer = grdCurrentWorkSheet.SelectionRange.Row To grdCurrentWorkSheet.SelectionRange.Row + grdCurrentWorkSheet.SelectionRange.Rows - 1
            Dim iRow As Integer = grdCurrentWorkSheet.RowHeaders.Item(i).Index + 1
            AddChangedNewLabelRows(iRow, strEmpty)
        Next
    End Sub

    Private Sub Worksheet_AfterCellKeyDown(sender As Object, e As AfterCellKeyDownEventArgs) Handles grdCurrentWorkSheet.AfterCellKeyDown
        If (e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Delete OrElse e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Back) Then
            GetSelectedRows()
            clsNewLabelDataframeFunction.AddParameter("cols", GetValuesAsVector(dctRowsNewLabelChanged), iPosition:=0)
            clsNewLabelDataframeFunction.AddParameter("index", "c(" & String.Join(",", dctRowsNewLabelChanged.Keys.ToArray) & ")", iPosition:=1)
            clsDefaultRFunction.AddParameter("new_labels_df", clsRFunctionParameter:=clsNewLabelDataframeFunction, iPosition:=9)
        End If
    End Sub

    Private Function containsFrench(ByVal strData As String) As Boolean
        Dim bFind As Boolean = False
        Dim lstFrench As String = "ç,é,ê,î,ô,œ,û"
        Dim words As String() = lstFrench.Split(New Char() {","c})
        For Each word In words
            If strData.Contains(word) Then
                bFind = True
                Exit For
            End If
        Next
        Return bFind
    End Function

    Private Sub RenameColumns(strNewData As String, iRowIndex As Integer, iColIndex As Integer)
        GetVariables(strNewData, iRowIndex + 1, iColIndex)
        TestOKEnabled()
    End Sub

    Private Sub Worksheet_BeforeCellKeyDown(sender As Object, e As BeforeCellKeyDownEventArgs) Handles grdCurrentWorkSheet.BeforeCellKeyDown
        If (e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Delete OrElse e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Back) AndAlso e.Cell.Column = 1 Then
            MsgBoxTranslate("The column name must not be an empty string.", MsgBoxStyle.Information)
            e.IsCancelled = True
        End If
    End Sub

    Private Sub grdCurrSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdCurrentWorkSheet.AfterCellEdit
        Dim iCol As Integer = e.Cell.Column
        Dim strNewData As String = ValidateRVariable(e.NewData, iCol)

        Dim strFirstColumnData As String = grdCurrentWorkSheet(e.Cell.Row, 0).ToString()

        GetOldNames(e.Cell.Row, strFirstColumnData)
        RenameColumns(strNewData, e.Cell.Row, iCol)
        ValidateNamesFromDictionary(iCol)
    End Sub

    Private Sub GetOldNames(iRow As Integer, strOldName As String)
        If Not dctRowsCurrentName.ContainsKey(iRow) Then
            dctRowsCurrentName.Add(iRow, strOldName)
        Else
            dctRowsCurrentName(iRow) = strOldName
        End If
    End Sub

    Private Sub GetVariables(strNewData As String, iRowIndex As Integer, iColIndex As Integer)
        If rdoMultiple.Checked Then
            If iColIndex = 1 Then
                If strNewData <> "" Then
                    AddChangedNewNameRows(iRowIndex, strNewData)

                    clsNewColNameDataframeFunction.AddParameter("cols", GetValuesAsVector(dctRowsNewNameChanged), iPosition:=0)
                    clsNewColNameDataframeFunction.AddParameter("old_names", GetValuesAsVector(dctRowsCurrentName), iPosition:=1)
                    clsDefaultRFunction.AddParameter("new_column_names_df", clsRFunctionParameter:=clsNewColNameDataframeFunction, iPosition:=8)
                Else
                    clsNewColNameDataframeFunction.RemoveParameterByName("cols")
                    clsNewColNameDataframeFunction.RemoveParameterByName("index")
                    clsDefaultRFunction.RemoveParameterByName("new_column_names_df")
                End If
            End If

            If ucrChkIncludeVariable.Checked Then
                If iColIndex = 2 Then
                    If strNewData <> "" Then
                        AddChangedNewLabelRows(iRowIndex, strNewData)
                    Else
                        AddChangedNewLabelRows(iRowIndex, strEmpty)
                    End If

                    clsNewLabelDataframeFunction.AddParameter("cols", GetValuesAsVector(dctRowsNewLabelChanged), iPosition:=0)
                    clsNewLabelDataframeFunction.AddParameter("index", "c(" & String.Join(",", dctRowsNewLabelChanged.Keys.ToArray) & ")", iPosition:=1)
                    clsDefaultRFunction.AddParameter("new_labels_df", clsRFunctionParameter:=clsNewLabelDataframeFunction, iPosition:=9)
                End If
            Else
                clsDefaultRFunction.RemoveParameterByName("new_labels_df")
            End If
        End If
    End Sub

    Private Sub RemoveLabelsParams()
        clsDefaultRFunction.RemoveParameterByName("new_column_names_df")
        clsDefaultRFunction.RemoveParameterByName("new_labels_df")
    End Sub

    Private Sub RemoveParameters()
        If rdoMultiple.Checked OrElse rdoSingle.Checked Then
            clsDefaultRFunction.RemoveParameterByName(".fn")
            RemoveLabelsParams()
        End If
    End Sub

    Private Sub UpdateGrid()
        Dim vecColumns As GenericVector = Nothing
        Dim chrCurrColumns As CharacterVector
        Dim clsGetItems As New RFunction
        Dim clsGetColumnLabels As New RFunction
        Dim strCurrColumnLables() As String
        Dim expItems As SymbolicExpression

        grdRenameColumns.Worksheets.Clear()
        dctRowsNewNameChanged.Clear()
        dctNameRowsValues.Clear()
        dctRowsNewLabelChanged.Clear()

        grdCurrentWorkSheet = grdRenameColumns.CreateWorksheet(ucrSelectVariables.strCurrentDataFrame)
        grdCurrentWorkSheet.ColumnCount = 3

        grdCurrentWorkSheet.ColumnHeaders(0).Text = "Name"
        grdCurrentWorkSheet.ColumnHeaders(1).Text = "New Name"
        grdCurrentWorkSheet.ColumnHeaders(2).Text = "Label"
        grdCurrentWorkSheet.SetColumnsWidth(2, 1, 150)

        If rdoMultiple.Checked Then
            If ucrSelectVariables IsNot Nothing Then
                clsGetItems.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_names")
                clsGetItems.AddParameter("data_name", Chr(34) & ucrSelectVariables.strCurrentDataFrame & Chr(34), iPosition:=0)
                clsGetItems.AddParameter("as_list", "TRUE")
                expItems = frmMain.clsRLink.RunInternalScriptGetValue(clsGetItems.ToScript(), bSilent:=True)
                If expItems IsNot Nothing AndAlso Not expItems.Type = Internals.SymbolicExpressionType.Null Then
                    vecColumns = expItems.AsList
                    For i As Integer = 0 To vecColumns.Count - 1
                        chrCurrColumns = vecColumns(i).AsCharacter
                        Dim strText As String = vecColumns.Names(i)

                        If chrCurrColumns IsNot Nothing Then
                            grdCurrentWorkSheet.RowCount = chrCurrColumns.Count
                            For j As Integer = 0 To chrCurrColumns.Count - 1
                                grdCurrentWorkSheet.Item(row:=j, col:=0) = chrCurrColumns(j)
                                grdCurrentWorkSheet.GetCell(row:=j, col:=0).IsReadOnly = True
                                grdCurrentWorkSheet.Item(row:=j, col:=1) = chrCurrColumns(j)
                            Next
                            clsGetColumnLabels.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_labels")
                            clsGetColumnLabels.AddParameter("data_name", Chr(34) & vecColumns.Names(i) & Chr(34))
                            clsGetColumnLabels.AddParameter("columns", frmMain.clsRLink.GetListAsRString(chrCurrColumns.ToList))
                            expItems = frmMain.clsRLink.RunInternalScriptGetValue(clsGetColumnLabels.ToScript())
                            If expItems IsNot Nothing AndAlso Not expItems.Type = Internals.SymbolicExpressionType.Null Then
                                strCurrColumnLables = expItems.AsCharacter.ToArray
                            Else
                                strCurrColumnLables = New String(chrCurrColumns.Count - 1) {}
                            End If
                            For j = 0 To chrCurrColumns.Count - 1
                                grdCurrentWorkSheet.Item(row:=j, col:=2) = strCurrColumnLables(j)
                            Next
                        End If
                    Next
                End If

                For iRow As Integer = 0 To grdCurrentWorkSheet.RowCount - 1
                    AddRowNameValue(iRow, grdCurrentWorkSheet.Item(iRow, 0))
                Next
            End If
        End If

        grdCurrentWorkSheet.SetRangeDataFormat(New RangePosition(0, 0, grdCurrentWorkSheet.Rows, grdCurrentWorkSheet.Columns), DataFormat.CellDataFormatFlag.Text)
        grdCurrentWorkSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
        grdCurrentWorkSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        grdCurrentWorkSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToFillSerial, False)
        grdCurrentWorkSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.View_AllowCellTextOverflow, False)

        grdRenameColumns.AddWorksheet(grdCurrentWorkSheet)
        grdRenameColumns.SheetTabNewButtonVisible = False
        grdRenameColumns.SheetTabWidth = 450

        MakeLabelColumnVisible()
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

            ' 🔧 New safer handling for shapefiles or multiple labels
            Dim strSelectedVar As String = ucrReceiverName.GetVariableNames(bWithQuotes:=False).Trim()
            Dim colIndex As Integer = -1

            If strArr.Length = 1 Then
                strColLabel = strArr(0)
            ElseIf strArr.Length > 1 Then
                Dim selectedVars As String() = ucrReceiverName.GetVariableNames(bWithQuotes:=False).Split(","c)
                For i = 0 To selectedVars.Length - 1
                    If selectedVars(i).Trim() = strSelectedVar Then
                        colIndex = i
                        Exit For
                    End If
                Next

                If colIndex >= 0 AndAlso colIndex < strArr.Length Then
                    strColLabel = strArr(colIndex)
                Else
                    MessageBox.Show(Me, "Unexpected result: could not find the label for the selected column.", "Label Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If

        Return strColLabel
    End Function

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged, ucrPnlCase.ControlValueChanged, ucrPnlSelectData.ControlValueChanged, ucrInputCase.ControlValueChanged, ucrNudAbbreviate.ControlValueChanged, ucrReceiverColumns.ControlValueChanged
        If rdoSingle.Checked Then
            ucrReceiverName.SetMeAsReceiver()
        ElseIf rdoRenameWith.Checked OrElse rdoLabels.Checked Then
            ucrInputBy.Visible = rdoWholeDataFrame.Checked AndAlso rdoReplace.Checked
            ucrInputEdit.Visible = ucrInputBy.Visible
            ucrInputReplace.Visible = ucrInputBy.Visible
            rdoReplace.Visible = rdoWholeDataFrame.Checked
            If rdoWholeDataFrame.Checked Then
                ucrReceiverColumns.Visible = False
                clsDummyFunction.AddParameter("checked", "whole", iPosition:=1)
            Else
                clsDummyFunction.AddParameter("checked", "selected", iPosition:=1)
                ucrReceiverColumns.SetMeAsReceiver()
                If rdoReplace.Checked Then
                    rdoMakeCleanNames.Checked = True
                End If
            End If
        End If

        ucrSelectVariables.lstAvailableVariable.Visible = rdoSingle.Checked OrElse
    (rdoRenameWith.Checked AndAlso rdoSelectedColumn.Checked) OrElse
    (rdoLabels.Checked AndAlso rdoSelectedColumn.Checked)

        ucrSelectVariables.btnAdd.Visible = ucrSelectVariables.lstAvailableVariable.Visible
        ucrSelectVariables.btnDataOptions.Visible = ucrSelectVariables.lstAvailableVariable.Visible
        UpdateGrid()
        RemoveParameters()
        DialogueSize()
        RemovePattern()
        ConfigureTypeParameter()
        ConfigurePatternParameter()
        SetRegexControlVisibility()
    End Sub

    Private Sub DialogueSize()
        If rdoSingle.Checked OrElse rdoMultiple.Checked Then
            Me.Size = New Size(561, 391)
            Me.ucrBase.Location = New Point(12, 296)
        Else
            If rdoWholeDataFrame.Checked Then
                Me.Size = New Size(561, 454)
                Me.ucrBase.Location = New Point(37, 351)
                Me.grpOptions.Size = New Size(269, 184)
                Me.grpOptions.Location = New Point(227, 107)
                Me.ucrPnlCase.Size = New Size(260, 104)
                Me.ucrPnlCase.Location = New Point(3, 13)
            Else
                Me.Size = New Size(561, 453)
                Me.ucrBase.Location = New Point(37, 357)
                Me.grpOptions.Location = New Point(251, 224)
                Me.grpOptions.Size = New Size(269, 93)
                Me.ucrPnlCase.Size = New Size(260, 72)
                Me.ucrPnlCase.Location = New Point(3, 13)
            End If
        End If
    End Sub

    Private Sub MakeLabelColumnVisible()
        If ucrChkIncludeVariable.Checked Then
            grdCurrentWorkSheet.ShowColumns(2, 1)
        Else
            grdCurrentWorkSheet.HideColumns(2, 1)
        End If
    End Sub

    Private Sub ucrChkIncludeVariable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeVariable.ControlValueChanged
        MakeLabelColumnVisible()
    End Sub

    Private Sub ucrSelectVariables_DataFrameChanged() Handles ucrSelectVariables.DataFrameChanged
        RemoveLabelsParams()
        UpdateGrid()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        If Not ucrReceiverColumns.IsEmpty Then
            ucrReceiverColumns.Clear()
        End If
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged() Handles ucrInputNewName.ControlContentsChanged, ucrReceiverName.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged, ucrPnlSelectData.ControlContentsChanged, ucrReceiverColumns.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub grdCurrentWorkSheet_CellEditTextChanging(sender As Object, e As CellEditTextChangingEventArgs) Handles grdCurrentWorkSheet.CellEditTextChanging
        If grdCurrentWorkSheet.ColumnCount > 0 Then
            Dim iCol As Integer = e.Cell.Column
            Dim parsedValue As Boolean
            Dim strNewData As String = ValidateRVariable(e.Text, iCol)
            If Not strNewData.ToLower.Equals("t") AndAlso Not strNewData.ToLower.Equals("f") AndAlso Not IsNumeric(strNewData) AndAlso Not Boolean.TryParse(strNewData, parsedValue) Then
                Dim strFirstColumnData As String = grdCurrentWorkSheet(e.Cell.Row, 0).ToString()
                GetOldNames(e.Cell.Row, strFirstColumnData)
                RenameColumns(strNewData, e.Cell.Row, iCol)
                ValidateNamesFromDictionary(iCol)
            End If
        End If
    End Sub

    Private Sub RemovePattern()
        If rdoWholeDataFrame.Checked Then
            If (rdoRenameWith.Checked OrElse rdoLabels.Checked) AndAlso rdoReplace.Checked Then
                clsDefaultRFunction.RemoveParameterByName("label")
                clsDefaultRFunction.AddParameter("replacement", Chr(34) & ucrInputBy.GetText() & Chr(34), iPosition:=5)

                Select Case ucrInputEdit.GetText
                    Case "Starts With"
                        clsDefaultRFunction.AddParameter(".cols", clsRFunctionParameter:=clsStartwithFunction, iPosition:=3)
                        clsDefaultRFunction.AddParameter(".fn", "stringr::str_replace", iPosition:=2)
                    Case "Ends With"
                        clsDefaultRFunction.AddParameter(".cols", clsRFunctionParameter:=clsEndswithFunction, iPosition:=3)
                        clsDefaultRFunction.AddParameter(".fn", "stringr::str_replace", iPosition:=2)
                    Case "Matches"
                        clsDefaultRFunction.AddParameter(".cols", clsRFunctionParameter:=clsMatchesFunction, iPosition:=3)
                        clsDefaultRFunction.AddParameter(".fn", "stringr::str_replace", iPosition:=2)
                    Case "Contains"
                        clsDefaultRFunction.AddParameter(".cols", clsRFunctionParameter:=clsContainsFunction, iPosition:=3)
                        clsDefaultRFunction.AddParameter(".fn", "stringr::str_replace", iPosition:=2)
                    Case "Matches All"
                        clsDefaultRFunction.AddParameter(".cols", clsRFunctionParameter:=clsMatchesFunction, iPosition:=3)
                        clsDefaultRFunction.AddParameter(".fn", "stringr::str_replace_all", iPosition:=2)
                    Case "Contains All"
                        clsDefaultRFunction.AddParameter(".cols", clsRFunctionParameter:=clsContainsFunction, iPosition:=3)
                        clsDefaultRFunction.AddParameter(".fn", "stringr::str_replace_all", iPosition:=2)
                End Select

            Else
                clsDefaultRFunction.RemoveParameterByName("replacement")
                clsDefaultRFunction.RemoveParameterByName(".cols")
            End If
        Else
            clsDefaultRFunction.AddParameter(".cols", ucrReceiverColumns.GetVariableNames, iPosition:=3)
        End If
    End Sub

    Private Sub ConfigurePatternParameter()
        If rdoWholeDataFrame.Checked AndAlso (rdoRenameWith.Checked OrElse rdoLabels.Checked) AndAlso rdoReplace.Checked Then
            Dim patternValue As String = Chr(34) & ucrInputReplace.GetText & Chr(34)
            If ucrChkIncludeRegularExpressions.Checked AndAlso (ucrInputEdit.GetText = "Matches All" OrElse ucrInputEdit.GetText = "Matches") Then

                clsRegexFunction.AddParameter("pattern", patternValue, bIncludeArgumentName:=False, iPosition:=1)
                clsDefaultRFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=4)
            Else
                Select Case ucrInputEdit.GetText
                    Case "Contains", "Contains All"
                        clsFixedFunction.AddParameter("pattern", patternValue, bIncludeArgumentName:=False, iPosition:=1)
                        clsDefaultRFunction.AddParameter("pattern", clsRFunctionParameter:=clsFixedFunction, bIncludeArgumentName:=False, iPosition:=4)
                    Case Else
                        clsDefaultRFunction.AddParameter("pattern", patternValue, iPosition:=4)
                End Select
            End If
        Else
            clsDefaultRFunction.RemoveParameterByName("pattern")
        End If
    End Sub

    Private Sub ConfigureTypeParameter()
        If rdoLabels.Checked Then
            clsDefaultRFunction.AddParameter("type", Chr(34) & "rename_labels" & Chr(34), iPosition:=1)

        ElseIf rdoRenameWith.Checked Then
            clsDefaultRFunction.AddParameter("type", Chr(34) & "rename_with" & Chr(34), iPosition:=1)

        ElseIf rdoMultiple.Checked Then
            clsDefaultRFunction.AddParameter("type", Chr(34) & "multiple" & Chr(34), iPosition:=1)

        ElseIf rdoSingle.Checked Then

            clsDefaultRFunction.AddParameter("type", Chr(34) & "single" & Chr(34), iPosition:=1)
        End If
    End Sub

    Private Sub ucrInputEdit_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputEdit.ControlValueChanged, ucrInputBy.ControlValueChanged, ucrInputReplace.ControlValueChanged
        RemovePattern()
        ConfigureTypeParameter()
        ConfigurePatternParameter()
        SetRegexControlVisibility()
    End Sub

    Private Sub cmdAddkeyboard_Click(sender As Object, e As EventArgs) Handles cmdAddkeyboard.Click
        sdgConstructRegexExpression.ShowDialog()
        ucrInputReplace.SetName(sdgConstructRegexExpression.ucrReceiverForRegex.GetText())
    End Sub

    Private Sub ucrChkIncludeRegularExpressions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeRegularExpressions.ControlValueChanged
        RemovePattern()
        ConfigurePatternParameter()
        SetRegexControlVisibility()
    End Sub

    Private Sub SetRegexControlVisibility()
        ucrChkIncludeRegularExpressions.Visible = False
        cmdAddkeyboard.Visible = False

        If rdoWholeDataFrame.Checked AndAlso
           (rdoRenameWith.Checked OrElse rdoLabels.Checked) AndAlso
           rdoReplace.Checked AndAlso
           (ucrInputEdit.GetText = "Matches All" OrElse ucrInputEdit.GetText = "Matches") Then

            ucrChkIncludeRegularExpressions.Visible = True
            cmdAddkeyboard.Visible = ucrChkIncludeRegularExpressions.Checked
        End If
    End Sub
End Class
