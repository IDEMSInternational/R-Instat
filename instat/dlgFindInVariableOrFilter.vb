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
    Private iClick As Integer = 1
    Private iFisrtRow As Integer = 0
    Private bFindNext As Boolean = False
    Private clsDummyFunction As New RFunction
    Private clsGetRowsFunction As New RFunction
    Private lstRowNumbers As List(Of String)

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
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrSelectorFind.SetParameter(New RParameter("data", 0))
        ucrSelectorFind.SetParameterIsString()

        ucrPnlOptions.AddRadioButton(rdoVariable)
        ucrPnlOptions.AddRadioButton(rdoInFilter)
        rdoInFilter.Enabled = False
        ucrPnlOptions.AddParameterValuesCondition(rdoVariable, "check", "variable")
        ucrPnlOptions.AddParameterValuesCondition(rdoInFilter, "check", "filter")

        ucrPnlSelect.AddRadioButton(rdoCell)
        ucrPnlSelect.AddRadioButton(rdoRow)
        ucrPnlSelect.AddParameterValuesCondition(rdoCell, "select", "cell")
        ucrPnlSelect.AddParameterValuesCondition(rdoRow, "select", "row")

        ucrReceiverVariable.SetParameter(New RParameter("col_name", 1))
        'ucrReceiverVariable.bWithQuotes = False
        ucrReceiverVariable.SetParameterIsString()
        ucrReceiverVariable.bUseFilteredData = False
        ucrReceiverVariable.Selector = ucrSelectorFind

        ucrInputPattern.SetItems({"TRUE", "FALSE"})

        ucrChkIgnoreCase.SetText("Ignore Case")
        ucrChkIgnoreCase.SetParameter(New RParameter("ignore_case", 3))
        ucrChkIgnoreCase.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkIncludeRegularExpressions.SetText("Use Regular Expression")
        ucrChkIncludeRegularExpressions.SetParameter(New RParameter("use_regex", 4))
        ucrChkIncludeRegularExpressions.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrPnlOptions.AddToLinkedControls(ucrInputPattern, {rdoVariable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverFilter, {rdoInFilter}, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverFilter.SetLinkedDisplayControl(lblFilter)
        ucrInputPattern.SetLinkedDisplayControl(lblPattern)
    End Sub

    Private Sub SetDefaults()
        clsDummyFunction = New RFunction
        clsGetRowsFunction = New RFunction

        ucrSelectorFind.Reset()
        ucrInputPattern.SetName("TRUE")

        iFisrtRow = 0

        clsDummyFunction.AddParameter("check", "variable", iPosition:=0)
        clsDummyFunction.AddParameter("select", "cell", iPosition:=1)

        clsGetRowsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_rows")
        clsGetRowsFunction.AddParameter("ignore_case", "TRUE", iPosition:=3)
        clsGetRowsFunction.AddParameter("use_regex", "FALSE", iPosition:=4)

        ucrReceiverVariable.SetMeAsReceiver()
        cmdFindNext.Enabled = False
    End Sub


    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrSelectorFind.SetRCode(clsGetRowsFunction, bReset)
        ucrReceiverVariable.SetRCode(clsGetRowsFunction, bReset)
        ucrChkIgnoreCase.SetRCode(clsGetRowsFunction, bReset)
        ucrChkIncludeRegularExpressions.SetRCode(clsGetRowsFunction, bReset)
        ucrPnlOptions.SetRCode(clsDummyFunction, bReset)
        ucrPnlSelect.SetRCode(clsDummyFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverVariable.IsEmpty AndAlso Not ucrInputPattern.IsEmpty Then
            cmdFind.Enabled = True
        Else
            cmdFind.Enabled = False
        End If
    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click
        Try
            Dim strPattern As String = ucrInputPattern.GetText
            If strPattern <> "" Then
                lstRowNumbers = New List(Of String)
                lstRowNumbers = frmMain.clsRLink.RunInternalScriptGetValue(clsGetRowsFunction.ToScript()).AsCharacter.ToList

                cmdFindNext.Enabled = lstRowNumbers.Count > 1
                If iFisrtRow = lstRowNumbers.Count Then
                    iFisrtRow = 0
                End If

                Dim iStartRow As Integer = frmMain.ucrDataViewer.GetCurrentDataFrameFocus().clsVisibleDataFramePage.intStartRow
                Dim iEndRow As Integer = frmMain.ucrDataViewer.GetCurrentDataFrameFocus().clsVisibleDataFramePage.intEndRow
                Dim iRow As Integer = lstRowNumbers(iFisrtRow)
                Dim bFirstRow As Boolean = iRow >= iStartRow AndAlso iRow <= iEndRow
                If Not bFirstRow Then
                    frmMain.ucrDataViewer.GoToFirstRowFound(iRow)
                    iFisrtRow += 1
                End If

                frmMain.ucrDataViewer.SearchInGrid(lstRows:=lstRowNumbers,
                                                   strVariable:=ucrReceiverVariable.GetVariableNames,
                                                   bFindNext:=bFindNext)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdFindNext_Click(sender As Object, e As EventArgs) Handles cmdFindNext.Click
        If iClick <= lstRowNumbers.Count Then
            frmMain.ucrDataViewer.SearchInGrid(lstRows:=lstRowNumbers,
                                   strVariable:=ucrReceiverVariable.GetVariableNames,
                                   bFindNext:=True,
                                   iClick:=iClick)
            iClick += 1
        End If
    End Sub

    Private Sub cmdAddkeyboard_Click(sender As Object, e As EventArgs) Handles cmdAddkeyboard.Click
        sdgConstructRegexExpression.ShowDialog()
        ucrInputPattern.SetName(sdgConstructRegexExpression.ucrReceiverForRegex.GetText())
    End Sub

    Private Sub ucrSelectorFind_DataFrameChanged() Handles ucrSelectorFind.DataFrameChanged
        'cmdFindNext.Enabled = False
        bFindNext = False
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrInputPattern_TextChanged(sender As Object, e As EventArgs)
        'cmdFindNext.Enabled = False
        bFindNext = False
    End Sub

    Private Sub ucrInputPattern_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputPattern.ControlValueChanged, ucrChkIncludeRegularExpressions.ControlValueChanged
        clsGetRowsFunction.AddParameter("pattern", Chr(34) & ucrInputPattern.GetText() & Chr(34), iPosition:=2)
        cmdAddkeyboard.Visible = ucrChkIncludeRegularExpressions.Checked
    End Sub

    Private Sub ucrReceiverVariable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVariable.ControlValueChanged
        bFindNext = False
    End Sub

    Private Sub ucrInputPattern_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVariable.ControlContentsChanged, ucrInputPattern.ControlContentsChanged
        TestOkEnabled()
    End Sub

End Class