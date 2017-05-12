' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports unvell.ReoGrid
Imports unvell.ReoGrid.Events

Public Class sdgCombineGraphOptions
    Private bFirstLoad As Boolean = True
    Private bInitialiseControls As Boolean = False
    Public clsCombineGraph As New RFunction

    Public clsRsyntax As New RSyntax
    Public WithEvents grdCurrSheet As Worksheet
    Public clsMatrixFunction As New RFunction

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        grdLayout.SetSettings(WorkbookSettings.View_ShowSheetTabControl, False)
        grdLayout.SetSettings(WorkbookSettings.View_ShowHorScroll, False)
        grdLayout.SheetTabNewButtonVisible = False
        grdCurrSheet = grdLayout.CurrentWorksheet
        ucrNudRows.Minimum = 1
        ucrNudColumns.Minimum = 1
        grdCurrSheet.SetSettings(WorksheetSettings.Edit_DragSelectionToMoveCells, False)
    End Sub

    Private Sub sdgLayout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
        LoadGraphs()
        SetDefaultRowAndColumns()
    End Sub

    Private Sub InitialiseControls()
        grdCurrSheet.Rows = ucrNudRows.Value
        grdCurrSheet.Columns = ucrNudColumns.Value

        ucrNudColumns.SetParameter(New RParameter("ncol"))
        ucrNudRows.SetParameter(New RParameter("nrow"))

        ucrInputBottom.SetParameter(New RParameter("bottom"))
        ucrInputLeft.SetParameter(New RParameter("left"))
        ucrInputRight.SetParameter(New RParameter("right"))
        ucrInputTop.SetParameter(New RParameter("top"))

        ucrChkSpecifyOrder.SetText("Specify Order")
        ucrChkSpecifyOrder.AddToLinkedControls({ucrInputTop, ucrInputRight}, objValues:={True})
        bInitialiseControls = True
    End Sub

    Private Sub nucrNudRows_ControlContentsChanged() Handles ucrNudRows.ControlContentsChanged
        If grdCurrSheet IsNot Nothing Then
            grdCurrSheet.Rows = ucrNudRows.Value
        End If
    End Sub

    Private Sub ucrNudColumns_ControlContentsChanged() Handles ucrNudColumns.ControlContentsChanged
        If grdCurrSheet IsNot Nothing Then
            grdCurrSheet.Columns = ucrNudColumns.Value
        End If
    End Sub

    Public Sub SetDefaultRowAndColumns()
        Dim NoOfgraphs As Integer
        If dlgCombineforGraphics.ucrCombineGraphReceiver.lstSelectedVariables.Items.Count > 0 Then
            NoOfgraphs = dlgCombineforGraphics.ucrCombineGraphReceiver.lstSelectedVariables.Items.Count
            ucrNudRows.Value = Math.Ceiling(Math.Sqrt(NoOfgraphs))
            ucrNudColumns.Value = Math.Ceiling(NoOfgraphs / (Math.Ceiling(Math.Sqrt(NoOfgraphs))))
        End If
    End Sub

    Private Sub grdCurrSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdCurrSheet.AfterCellEdit
        grdCurrSheet.SelectionForwardDirection = SelectionForwardDirection.Down

        If e.NewData.ToString() <> "" Then
            If Not IsNumeric(e.NewData) Then
                MsgBox("Invalid value: " & e.NewData.ToString() & vbNewLine & "You entered a non numeric character. Please enter a numeric character within the range of available graphs", MsgBoxStyle.Exclamation, "Invalid Value")
                e.EndReason = EndEditReason.Cancel
            ElseIf e.NewData > lstGraphs.Items.Count Or e.NewData < 1 Then
                MsgBox("Invalid value: " & e.NewData.ToString() & vbNewLine & "This number is greater than the number of available graphs", MsgBoxStyle.Exclamation, "Invalid Value")
                e.EndReason = EndEditReason.Cancel
            End If
        End If
        SetMatrixFunction()
    End Sub

    Public Sub LoadGraphs()
        Dim i As Integer = 0
        lstGraphs.Items.Clear()
        For i = 0 To dlgCombineforGraphics.ucrCombineGraphReceiver.lstSelectedVariables.Items.Count - 1
            lstGraphs.Items.Add((i + 1) & Chr(32) & "." & dlgCombineforGraphics.ucrCombineGraphReceiver.lstSelectedVariables.Items(i).Text)
        Next
    End Sub

    Public Sub SetMatrixFunction()
        Dim i As Integer
        Dim j As Integer
        Dim lstNumbers As New List(Of Integer)
        Dim strMatrix As String = ""
        clsMatrixFunction.SetRCommand("matrix")

        If grdCurrSheet IsNot Nothing Then
            For i = 0 To grdCurrSheet.ColumnCount - 1
                For j = 0 To grdCurrSheet.RowCount - 1
                    If grdCurrSheet(row:=j, col:=i) Is Nothing Then
                        strMatrix = strMatrix & "NA"
                    Else
                        lstNumbers.Add(grdCurrSheet(row:=j, col:=i))
                        strMatrix = strMatrix & grdCurrSheet(row:=j, col:=i)
                    End If
                    If Not ((i = grdCurrSheet.ColumnCount - 1) AndAlso (j = grdCurrSheet.RowCount - 1)) Then
                        strMatrix = strMatrix & ","
                    End If

                Next
            Next
        End If
        strMatrix = "c" & "(" & strMatrix & ")"
        clsMatrixFunction.AddParameter("data", strMatrix)
        clsCombineGraph.AddParameter("layout_matrix", clsRFunctionParameter:=clsMatrixFunction)
        If lstNumbers.Distinct.Count = lstGraphs.Items.Count Then
            txtLayoutMessage.Text = "Ok: Layout contains all graphs"
        Else
            txtLayoutMessage.Text = "Layout incomplete: layout must contain all graphs."
        End If
    End Sub

    Private Sub chkSpecifyOrder_CheckedChanged() Handles ucrChkSpecifyOrder.ControlValueChanged
        If ucrChkSpecifyOrder.Checked = True Then
            grdLayout.Visible = True
            'SetMatrixFunction()
            SwitchNcolToMatrixFunc()
        Else
            grdLayout.Visible = False
            RemoveNcolFromMatrixfunc()
        End If
    End Sub

    Public Sub SwitchNcolToMatrixFunc()
        clsRsyntax.RemoveParameter("ncol")
        clsRsyntax.RemoveParameter("nrow")
        clsMatrixFunction.AddParameter("ncol", ucrNudColumns.Value)
        clsMatrixFunction.AddParameter("nrow", ucrNudRows.Value)
    End Sub

    Public Sub RemoveNcolFromMatrixfunc()
        clsMatrixFunction.RemoveParameterByName("ncol")
        clsMatrixFunction.RemoveParameterByName("nrow")
        clsRsyntax.RemoveParameter("layout_matrix")
        clsRsyntax.AddParameter("nrow", ucrNudRows.Value)
        clsRsyntax.AddParameter("ncol", ucrNudColumns.Value)
    End Sub

    Private Sub grdLayout_Leave(sender As Object, e As EventArgs) Handles grdLayout.Leave
        If grdCurrSheet.IsEditing Then
            grdCurrSheet.EndEdit(EndEditReason.NormalFinish)
            SetMatrixFunction()
        End If
    End Sub
    Public Sub SetRFunction(clsNewRFunction As RFunction, Optional bReset As Boolean = False)
        If Not bInitialiseControls Then
            InitialiseControls()
        End If

        clsCombineGraph = clsNewRFunction
        SetRCode(Me, clsCombineGraph, bReset)
    End Sub
End Class
