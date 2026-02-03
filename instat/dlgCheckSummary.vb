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
Imports unvell.ReoGrid
Imports unvell.ReoGrid.Events

Public Class dlgCheckSummary

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private clsRecentIfElseFunction As New RFunction
    Private clsInnerIfElseFunction As New RFunction
    Private clsMaxFunction As New RFunction
    Private clsMaxYearAssign As New RFunction
    Private clsFactorFunction As New RFunction
    Private clsDummyFunction As New RFunction

    Private WithEvents grdRecentWorkSheet As Worksheet
    Private bUpdatingRecentGrid As Boolean = False

    Private ReadOnly Property ucrBase As ucrButtons
        Get
            Return UcrButtons1
        End Get
    End Property

    Private Sub dlgCheckSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = -1

        ucrPnlOptions.AddRadioButton(rdoRecent)
        ucrPnlOptions.AddRadioButton(rdoOutliers)
        ucrPnlOptions.AddRadioButton(rdoTable)
        ucrPnlOptions.AddRadioButton(rdoTrend)

        ucrReceiverYear.SetParameter(New RParameter("x", 0))
        ucrReceiverYear.Selector = ucrSelectorForRecode
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.SetIncludedDataTypes({"numeric"}, bStrict:=True)
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"
        ucrReceiverYear.SetMeAsReceiver()
        ucrReceiverYear.bUseFilteredData = False

        InitialiseRecentGrid()

        ucrSaveNewColumn.SetSaveTypeAsColumn()
        ucrSaveNewColumn.SetDataFrameSelector(ucrSelectorForRecode.ucrAvailableDataFrames)
        ucrSaveNewColumn.SetIsComboBox()
        ucrSaveNewColumn.SetLabelText("New Column Name:")

        UpdateVisiblePanels()
    End Sub

    Private Sub SetDefaults()
        clsRecentIfElseFunction = New RFunction
        clsInnerIfElseFunction = New RFunction
        clsMaxFunction = New RFunction
        clsMaxYearAssign = New RFunction
        clsFactorFunction = New RFunction
        clsDummyFunction = New RFunction

        rdoRecent.Checked = True

        ucrSelectorForRecode.Reset()
        ucrSaveNewColumn.Reset()

        If Not ucrSaveNewColumn.bUserTyped Then
            ucrSaveNewColumn.SetPrefix("recent_years")
        End If

        ResetRecentGridToDefaults()

        clsMaxFunction.SetRCommand("max")
        clsMaxFunction.AddParameter("na.rm", "TRUE")

        clsMaxYearAssign.SetAssignToObject("max_year")
        clsMaxYearAssign.SetRCommand("max")
        clsMaxYearAssign.AddParameter("na.rm", "TRUE")

        clsInnerIfElseFunction.SetRCommand("ifelse")
        clsRecentIfElseFunction.SetRCommand("ifelse")

        clsFactorFunction.SetRCommand("factor")
        clsFactorFunction.AddParameter("ordered", "TRUE")

        clsDummyFunction.SetRCommand("c")

        UpdateRecentRCode()

        UpdateVisiblePanels()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverYear.SetRCode(clsDummyFunction, bReset)
        ucrSaveNewColumn.SetRCode(clsFactorFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles UcrButtons1.ClickReset
        bReset = True
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        UpdateVisiblePanels()
        ucrReceiverYear.SetMeAsReceiver()
        If rdoRecent.Checked Then
            UpdateRecentRCode()
        End If
        TestOKEnabled()
    End Sub

    Private Sub UpdateVisiblePanels()
        pnlRecent.Visible = rdoRecent.Checked

        If Not rdoRecent.Checked Then
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsMaxYearAssign)
            ucrBase.clsRsyntax.SetBaseRFunction(clsDummyFunction)
        End If
    End Sub

    Private Sub TestOKEnabled()
        If rdoRecent.Checked Then
            ucrBase.OKEnabled(Not ucrReceiverYear.IsEmpty AndAlso ucrSaveNewColumn.IsComplete() AndAlso IsRecentGridValid())
        Else
            ucrBase.OKEnabled(Not ucrReceiverYear.IsEmpty)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlContentsChanged,
        ucrSaveNewColumn.ControlContentsChanged
        If rdoRecent.Checked Then
            UpdateRecentRCode()
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseRecentGrid()
        grdRecent.Worksheets.Clear()
        grdRecentWorkSheet = grdRecent.CreateWorksheet("Recent")
        grdRecent.AddWorksheet(grdRecentWorkSheet)
        grdRecent.CurrentWorksheet = grdRecentWorkSheet
        grdRecentWorkSheet.SetSettings(WorksheetSettings.View_ShowRowHeader, False)
        grdRecentWorkSheet.SetSettings(WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        grdRecentWorkSheet.SetSettings(WorksheetSettings.Edit_DragSelectionToFillSerial, False)
        grdRecentWorkSheet.SetSettings(WorksheetSettings.Edit_Readonly, False)
        grdRecentWorkSheet.SelectionForwardDirection = SelectionForwardDirection.Down

        grdRecentWorkSheet.Resize(3, 3)
        grdRecentWorkSheet.ColumnHeaders(0).Text = "Ordinal"
        grdRecentWorkSheet.ColumnHeaders(1).Text = "Label"
        grdRecentWorkSheet.ColumnHeaders(2).Text = "years"
        grdRecentWorkSheet.ColumnHeaders(0).Width = 50
        grdRecentWorkSheet.ColumnHeaders(1).Width = 120
        grdRecentWorkSheet.ColumnHeaders(2).Width = 70

        ResetRecentGridToDefaults()
    End Sub

    Private Sub ResetRecentGridToDefaults()
        If grdRecentWorkSheet Is Nothing Then
            Exit Sub
        End If

        bUpdatingRecentGrid = True
        Try
            grdRecentWorkSheet(0, 0) = 3
            grdRecentWorkSheet(1, 0) = 2
            grdRecentWorkSheet(2, 0) = 1

            grdRecentWorkSheet(0, 1) = "last10"
            grdRecentWorkSheet(1, 1) = "to30"
            grdRecentWorkSheet(2, 1) = "older"

            grdRecentWorkSheet(0, 2) = 10
            grdRecentWorkSheet(1, 2) = 30
            grdRecentWorkSheet(2, 2) = ""

            grdRecentWorkSheet.SetRangeDataFormat(0, 0, 3, 3, unvell.ReoGrid.DataFormat.CellDataFormatFlag.Text)

            For iRow As Integer = 0 To 2
                grdRecentWorkSheet.GetCell(iRow, 0).IsReadOnly = True
            Next
            grdRecentWorkSheet.GetCell(2, 2).IsReadOnly = True
        Finally
            bUpdatingRecentGrid = False
        End Try
    End Sub

    Private Sub grdRecentWorkSheet_BeforeCellEdit(sender As Object, e As CellBeforeEditEventArgs) Handles grdRecentWorkSheet.BeforeCellEdit
        If (e.Cell.Column = 0) OrElse (e.Cell.Row = 2 AndAlso e.Cell.Column = 2) Then
            e.IsCancelled = True
        End If
    End Sub

    Private Sub grdRecentWorkSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdRecentWorkSheet.AfterCellEdit
        If bUpdatingRecentGrid Then
            Exit Sub
        End If
        If rdoRecent.Checked Then
            UpdateRecentRCode()
            TestOKEnabled()
        End If
    End Sub

    Private Function GetRecentGridValue(iRow As Integer, iCol As Integer) As String
        If grdRecentWorkSheet Is Nothing Then
            Return ""
        End If
        Dim obj As Object = grdRecentWorkSheet(iRow, iCol)
        If obj Is Nothing Then
            Return ""
        End If
        Return obj.ToString().Trim()
    End Function

    Private Function IsRecentGridValid() As Boolean
        Dim strLabel1 As String = GetRecentGridValue(0, 1)
        Dim strLabel2 As String = GetRecentGridValue(1, 1)
        Dim strLabel3 As String = GetRecentGridValue(2, 1)

        If strLabel1 = "" OrElse strLabel2 = "" OrElse strLabel3 = "" Then
            Return False
        End If

        Dim iYears1 As Integer
        Dim iYears2 As Integer
        If Not Integer.TryParse(GetRecentGridValue(0, 2), iYears1) Then
            Return False
        End If
        If Not Integer.TryParse(GetRecentGridValue(1, 2), iYears2) Then
            Return False
        End If
        If iYears1 <= 0 OrElse iYears2 <= 0 Then
            Return False
        End If
        If iYears1 >= iYears2 Then
            Return False
        End If
        Return True
    End Function

    Private Function QuoteRString(strText As String) As String
        If strText Is Nothing Then
            strText = ""
        End If


        Dim strEscaped As String = strText.Replace("\\", "\\\\").Replace(Chr(34), "\\" & Chr(34))
        Return Chr(34) & strEscaped & Chr(34)
    End Function

    Private Sub UpdateRecentRCode()

        If grdRecentWorkSheet Is Nothing OrElse ucrReceiverYear.IsEmpty OrElse Not IsRecentGridValid() Then
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsMaxYearAssign)
            Exit Sub
        End If

        Dim clsYearColumn As RFunction = ucrReceiverYear.GetVariables()
        clsYearColumn.RemoveAssignTo()

        Dim strLabel1 As String = GetRecentGridValue(0, 1)
        Dim strLabel2 As String = GetRecentGridValue(1, 1)
        Dim strLabel3 As String = GetRecentGridValue(2, 1)
        Dim strYears1 As String = GetRecentGridValue(0, 2)
        Dim strYears2 As String = GetRecentGridValue(1, 2)

        Dim clsCond1 As New ROperator
        Dim clsCond2 As New ROperator
        Dim clsMinus1 As New ROperator
        Dim clsMinus2 As New ROperator

        clsMaxYearAssign.ClearParameters()
        clsMaxYearAssign.SetAssignToObject("max_year")
        clsMaxYearAssign.SetRCommand("max")
        clsMaxYearAssign.AddParameter("x", clsRFunctionParameter:=clsYearColumn, iPosition:=0, bIncludeArgumentName:=False)
        clsMaxYearAssign.AddParameter("na.rm", "TRUE")
        ucrBase.clsRsyntax.AddToBeforeCodes(clsMaxYearAssign, iPosition:=0)

        clsMinus1.SetOperation("-")
        clsMinus1.AddParameter("m", "max_year", iPosition:=0, bIncludeArgumentName:=False)
        clsMinus1.AddParameter("n", strYears1, iPosition:=1, bIncludeArgumentName:=False)

        clsMinus2.SetOperation("-")
        clsMinus2.AddParameter("m", "max_year", iPosition:=0, bIncludeArgumentName:=False)
        clsMinus2.AddParameter("n", strYears2, iPosition:=1, bIncludeArgumentName:=False)

        clsCond1.SetOperation(">")
        clsCond1.AddParameter("x", clsRFunctionParameter:=clsYearColumn, iPosition:=0, bIncludeArgumentName:=False)
        clsCond1.AddParameter("y", clsROperatorParameter:=clsMinus1, iPosition:=1, bIncludeArgumentName:=False)

        clsCond2.SetOperation(">")
        clsCond2.AddParameter("x", clsRFunctionParameter:=clsYearColumn, iPosition:=0, bIncludeArgumentName:=False)
        clsCond2.AddParameter("y", clsROperatorParameter:=clsMinus2, iPosition:=1, bIncludeArgumentName:=False)

        clsInnerIfElseFunction.ClearParameters()
        clsInnerIfElseFunction.SetRCommand("ifelse")
        clsInnerIfElseFunction.AddParameter("test", clsROperatorParameter:=clsCond2, iPosition:=0)
        clsInnerIfElseFunction.AddParameter("yes", QuoteRString(strLabel2), iPosition:=1)
        clsInnerIfElseFunction.AddParameter("no", QuoteRString(strLabel3), iPosition:=2)

        clsRecentIfElseFunction.ClearParameters()
        clsRecentIfElseFunction.SetRCommand("ifelse")
        clsRecentIfElseFunction.AddParameter("test", clsROperatorParameter:=clsCond1, iPosition:=0)
        clsRecentIfElseFunction.AddParameter("yes", QuoteRString(strLabel1), iPosition:=1)
        clsRecentIfElseFunction.AddParameter("no", clsRFunctionParameter:=clsInnerIfElseFunction, iPosition:=2)

        Dim clsLevels As New RFunction
        clsLevels.SetRCommand("c")
        clsLevels.AddParameter("l3", QuoteRString(strLabel3), iPosition:=0, bIncludeArgumentName:=False)
        clsLevels.AddParameter("l2", QuoteRString(strLabel2), iPosition:=1, bIncludeArgumentName:=False)
        clsLevels.AddParameter("l1", QuoteRString(strLabel1), iPosition:=2, bIncludeArgumentName:=False)

        clsFactorFunction.ClearParameters()
        clsFactorFunction.SetRCommand("factor")
        clsFactorFunction.AddParameter("x", clsRFunctionParameter:=clsRecentIfElseFunction, iPosition:=0)
        clsFactorFunction.AddParameter("levels", clsRFunctionParameter:=clsLevels, iPosition:=1)
        clsFactorFunction.AddParameter("ordered", "TRUE", iPosition:=2)

        ucrBase.clsRsyntax.SetBaseRFunction(clsFactorFunction)
    End Sub
End Class
