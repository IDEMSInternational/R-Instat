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
Public Class dlgFindInVariableOrFilter
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private iCurrentOccurenceIndex As Integer
    Private iCountClick As Integer
    Private clsDummyFunction As New RFunction
    Private clsGetRowsFunction, clsGetRowHeadersFunction, clsGetFilterRowNamesFunction As New RFunction
    Private clsGetDataFrameFunction As New RFunction

    Private Sub dlgFindInVariableOrFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRcodeForControls(bReset)

        bReset = False
        TestOkEnabled()
        AddToMenu()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrSelectorFind.SetParameter(New RParameter("data_name", 0))
        ucrSelectorFind.SetParameterIsString()

        ucrPnlOptions.AddRadioButton(rdoVariable)
        ucrPnlOptions.AddRadioButton(rdoInFilter)
        ucrPnlOptions.SetParameter(New RParameter("check", 0))
        ucrPnlOptions.AddParameterValuesCondition(rdoVariable, "check", "variable")
        ucrPnlOptions.AddParameterValuesCondition(rdoInFilter, "check", "filter")

        ucrPnlSelect.AddRadioButton(rdoCell)
        ucrPnlSelect.AddRadioButton(rdoRow)
        ucrPnlSelect.SetParameter(New RParameter("select", 1))
        ucrPnlSelect.AddParameterValuesCondition(rdoCell, "select", "cell")
        ucrPnlSelect.AddParameterValuesCondition(rdoRow, "select", "row")

        ucrReceiverVariable.SetParameter(New RParameter("column", 1))
        ucrReceiverVariable.SetParameterIsString()
        ucrReceiverVariable.bUseFilteredData = False
        ucrReceiverVariable.Selector = ucrSelectorFind

        ucrInputPattern.SetItems({"NA", "TRUE", "FALSE"})

        ucrChkIgnoreCase.SetText("Ignore Case")
        ucrChkIgnoreCase.SetParameter(New RParameter("ignore_case", 3))
        ucrChkIgnoreCase.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkIncludeRegularExpressions.SetText("Use Regular Expression")
        ucrChkIncludeRegularExpressions.SetParameter(New RParameter("use_regex", 4))
        ucrChkIncludeRegularExpressions.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        'ucrPnlOptions.AddToLinkedControls(ucrInputPattern, {rdoVariable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrInputPattern, ucrPnlSelect, ucrChkIgnoreCase, ucrChkIncludeRegularExpressions}, {rdoVariable}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputPattern.SetLinkedDisplayControl(lblPattern)
        ucrPnlSelect.SetLinkedDisplayControl(grpSelect)
    End Sub

    Private Sub SetDefaults()
        clsDummyFunction = New RFunction
        clsGetRowsFunction = New RFunction
        clsGetRowHeadersFunction = New RFunction
        clsGetFilterRowNamesFunction = New RFunction
        clsGetDataFrameFunction = New RFunction

        ucrSelectorFind.Reset()
        ucrInputPattern.SetName("")
        lblMatching.Visible = False

        clsDummyFunction.AddParameter("check", "variable", iPosition:=0)
        clsDummyFunction.AddParameter("select", "cell", iPosition:=1)

        clsGetFilterRowNamesFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_filter_row_names")

        clsGetDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")

        clsGetRowHeadersFunction.SetRCommand("getRowHeadersWithText")
        clsGetRowHeadersFunction.AddParameter("data", clsRFunctionParameter:=clsGetDataFrameFunction, iPosition:=0)
        clsGetRowHeadersFunction.AddParameter("ignore_case", "TRUE", iPosition:=3)
        clsGetRowHeadersFunction.AddParameter("use_regex", "FALSE", iPosition:=4)

        ucrReceiverVariable.SetMeAsReceiver()
        cmdFindNext.Enabled = False
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrSelectorFind.AddAdditionalCodeParameterPair(clsGetFilterRowNamesFunction, ucrSelectorFind.GetParameter, iAdditionalPairNo:=1)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsGetFilterRowNamesFunction, New RParameter("filter_name"), iAdditionalPairNo:=1)
        ucrSelectorFind.SetRCode(clsGetDataFrameFunction, bReset)
        ucrReceiverVariable.SetRCode(clsGetRowHeadersFunction, bReset)
        ucrChkIgnoreCase.SetRCode(clsGetRowHeadersFunction, bReset)
        ucrChkIncludeRegularExpressions.SetRCode(clsGetRowHeadersFunction, bReset)
        ucrPnlOptions.SetRCode(clsDummyFunction, bReset)
        ucrPnlSelect.SetRCode(clsDummyFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        cmdFind.Enabled = (rdoVariable.Checked AndAlso Not ucrReceiverVariable.IsEmpty AndAlso Not ucrInputPattern.IsEmpty) OrElse
            (rdoInFilter.Checked AndAlso Not ucrReceiverVariable.IsEmpty)
    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click
        Try
            If (rdoVariable.Checked AndAlso String.IsNullOrEmpty(ucrInputPattern.GetText)) Then
                Exit Sub
            End If
            Dim lstRowNumbers As New List(Of Integer)
            lstRowNumbers = frmMain.clsRLink.RunInternalScriptGetValue(clsGetRowsFunction.ToScript()).AsInteger.ToList
            lblMatching.Visible = False

            If lstRowNumbers.Count <= 0 Then
                lblMatching.ForeColor = Color.Red
                lblMatching.Text = "There are no entries matching " & ucrInputPattern.GetText
                lblMatching.Visible = True
                Exit Sub
            End If

            Dim iFirstRowOnPageRowNumber As Integer = frmMain.ucrDataViewer.GetFirstRowHeader ' e.g. 1 for first page, 1001, for second page etc.
            Dim iCurrentOccurenceRowNumber As Integer = lstRowNumbers(iCurrentOccurenceIndex - 1) ' e.g. if 5 occurences of "Chris", then iCurrentOccurenceIndex is a value between 1 and 5
            ' Iterate over the list of row numbers to find the page where the row is displayed.
            For i As Integer = 1 To lstRowNumbers.Count 'loop through occurences
                Dim iLoopOccurenceRowNumber As Integer = lstRowNumbers(i - 1)
                If iLoopOccurenceRowNumber >= iFirstRowOnPageRowNumber _ 'if row number of loop occurence is on or after current page
                        AndAlso (iCurrentOccurenceRowNumber < iLoopOccurenceRowNumber OrElse iCountClick = 1) Then 'And row number of previous occurence < row number of loop occurence. Or this is the first time we are clicking
                    iCurrentOccurenceIndex = i 'set the current occurence to be loop occurence
                    Exit For
                End If
            Next

            If iCurrentOccurenceRowNumber = lstRowNumbers.Max Then
                If iCurrentOccurenceIndex > iCountClick Then
                    iCountClick = iCurrentOccurenceIndex
                Else
                    iCountClick = 1
                End If
                iCurrentOccurenceIndex = 1
            End If

            Dim strColumn As String = "filter"

            If rdoVariable.Checked Then
                strColumn = ucrReceiverVariable.GetVariableNames
            End If

            Dim iRow As Integer = lstRowNumbers(iCurrentOccurenceIndex - 1)
            Dim iRowPage As Integer = Math.Ceiling(CDbl(iRow / frmMain.clsInstatOptions.iMaxRows))
            frmMain.ucrDataViewer.GoToSpecificRowPage(iRowPage)
            Dim bApplyCell As Boolean = (rdoVariable.Checked AndAlso rdoRow.Checked) OrElse rdoInFilter.Checked
            frmMain.ucrDataViewer.SearchInGrid(rowNumbers:=lstRowNumbers, strColumn:=strColumn,
                                                       iRow:=iRow, bCellOrRow:=Not bApplyCell)
            iCountClick += 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdAddkeyboard_Click(sender As Object, e As EventArgs) Handles cmdAddkeyboard.Click
        sdgConstructRegexExpression.ShowDialog()
        ucrInputPattern.SetName(sdgConstructRegexExpression.ucrReceiverForRegex.GetText())
    End Sub

    Private Sub ucrSelectorFind_DataFrameChanged() Handles ucrSelectorFind.DataFrameChanged
        cmdFindNext.Enabled = False
        iCountClick = 1
        iCurrentOccurenceIndex = 1
    End Sub

    Private Sub ucrInputPattern_TextChanged(sender As Object, e As EventArgs) Handles ucrInputPattern.TextChanged
        cmdFindNext.Enabled = False
        iCountClick = 1
        iCurrentOccurenceIndex = 1
    End Sub

    Private Sub ucrInputPattern_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputPattern.ControlValueChanged, ucrChkIncludeRegularExpressions.ControlValueChanged
        Dim strPattern As String = ucrInputPattern.GetText
        If ucrInputPattern.GetText <> "NA" Then
            strPattern = Chr(34) & strPattern & Chr(34)
        End If
        clsGetRowHeadersFunction.AddParameter("searchText", strPattern, iPosition:=2)
        cmdAddkeyboard.Visible = ucrChkIncludeRegularExpressions.Checked
    End Sub

    Private Sub AddToMenu()
        If frmMain.clsRecentItems IsNot Nothing Then
            frmMain.clsRecentItems.addToMenu(Me)
        End If
    End Sub

    Private Sub ucrReceiverVariable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVariable.ControlValueChanged
        iCountClick = 1
        iCurrentOccurenceIndex = 1
    End Sub

    Private Sub ucrInputPattern_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVariable.ControlContentsChanged, ucrInputPattern.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlSelect_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSelect.ControlValueChanged
        If rdoCell.Checked Then
            clsDummyFunction.AddParameter("select", "cell", iPosition:=1)
        Else
            clsDummyFunction.AddParameter("select", "row", iPosition:=1)
        End If
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        ucrReceiverVariable.Clear()
        lblMatching.Visible = False
        If rdoVariable.Checked Then
            clsGetRowsFunction = clsGetRowHeadersFunction
            clsDummyFunction.AddParameter("check", "variable", iPosition:=0)
            ucrReceiverVariable.SetItemType("column")
            ucrReceiverVariable.strSelectorHeading = "Variables"
            lblVariable.Text = "Variable:"
        ElseIf rdoInFilter.Checked Then
            clsGetRowsFunction = clsGetFilterRowNamesFunction
            clsDummyFunction.AddParameter("check", "filter", iPosition:=0)
            ucrReceiverVariable.SetItemType("filter")
            ucrReceiverVariable.strSelectorHeading = "Filters"
            lblVariable.Text = "Filter:"
        End If
    End Sub
End Class