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
        nudRows.Minimum = 1
        nudRows.Minimum = 1
        grdCurrSheet.SetSettings(WorksheetSettings.Edit_DragSelectionToMoveCells, False)
    End Sub

    Private Sub sdgLayout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        Me.BringToFront()
        LoadGraphs()
    End Sub

    Public Sub SetDefaults()
        ucrInputLeft.ResetText()
        ucrInputRight.ResetText()
        ucrInputTop.ResetText()
        ucrInputBottom.ResetText()
        SetDefaultRowAndColumns()
        chkSpecifyOrder.Checked = False
        grdLayout.Visible = False
    End Sub

    Private Sub InitialiseDialog()
        grdCurrSheet.Rows = nudRows.Value
        grdCurrSheet.Columns = nudColumns.Value
    End Sub

    Public Sub SetRSyntax(clsNewRSyntax As RSyntax)
        clsRsyntax = clsNewRSyntax
    End Sub

    Private Sub ucrInputTop_NameChanged() Handles ucrInputTop.NameChanged
        If Not ucrInputTop.IsEmpty Then
            clsRsyntax.AddParameter("top", ucrInputTop.GetText)
        Else
            clsRsyntax.RemoveParameter("top")
        End If
    End Sub

    Private Sub ucrInputBottom_NameChanged() Handles ucrInputBottom.NameChanged
        If Not ucrInputBottom.IsEmpty Then
            clsRsyntax.AddParameter("bottom", ucrInputBottom.GetText)
        Else
            clsRsyntax.RemoveParameter("bottom")
        End If
    End Sub

    Private Sub ucrInputRight_NameChanged() Handles ucrInputRight.NameChanged
        If Not ucrInputRight.IsEmpty Then
            clsRsyntax.AddParameter("right", ucrInputRight.GetText)
        Else
            clsRsyntax.RemoveParameter("right")
        End If
    End Sub

    Private Sub ucrInputLeft_NameChanged() Handles ucrInputLeft.NameChanged
        If Not ucrInputLeft.IsEmpty Then
            clsRsyntax.AddParameter("left", ucrInputLeft.GetText)
        Else
            clsRsyntax.RemoveParameter("left")
        End If

    End Sub

    Private Sub nudRows_TextChanged(sender As Object, e As EventArgs) Handles nudRows.TextChanged
        If nudRows.Text <> "" Then
            clsRsyntax.AddParameter("nrow", nudRows.Value)
        Else
            clsRsyntax.RemoveParameter("nrow")
        End If
        If grdCurrSheet IsNot Nothing Then
            grdCurrSheet.Rows = nudRows.Value
        End If
    End Sub

    Private Sub nudColumns_TextChanged(sender As Object, e As EventArgs) Handles nudColumns.TextChanged
        If nudColumns.Text <> "" Then
            clsRsyntax.AddParameter("ncol", nudColumns.Value)
        Else
            clsRsyntax.RemoveParameter("ncol")
        End If

        If grdCurrSheet IsNot Nothing Then
            grdCurrSheet.Columns = nudColumns.Value
        End If
    End Sub

    Public Sub SetDefaultRowAndColumns()
        Dim NoOfgraphs As Integer
        If dlgCombineforGraphics.ucrCombineGraphReceiver.lstSelectedVariables.Items.Count > 0 Then
            NoOfgraphs = dlgCombineforGraphics.ucrCombineGraphReceiver.lstSelectedVariables.Items.Count
            nudColumns.Value = Math.Ceiling(Math.Sqrt(NoOfgraphs))
            nudRows.Value = Math.Ceiling((NoOfgraphs / Math.Sqrt(NoOfgraphs)))
        End If
    End Sub

    Private Sub grdCurrSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdCurrSheet.AfterCellEdit
        grdCurrSheet.SelectionForwardDirection = SelectionForwardDirection.Down

        If Not IsNumeric(e.NewData) Then
            MsgBox("Invalid value: " & e.NewData.ToString() & vbNewLine & "You entered a non numeric character. Please enter a numeric character withinthe range of availble graphs", MsgBoxStyle.Exclamation, "Invalid Value")
            e.EndReason = EndEditReason.Cancel
        ElseIf e.NewData > lstGraphs.Items.Count Or e.NewData < 1 Then
            MsgBox("Invalid value: " & e.NewData.ToString() & vbNewLine & "This number is greater than the number of availble graphs", MsgBoxStyle.Exclamation, "Invalid Value")
            e.EndReason = EndEditReason.Cancel
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
        Dim strMatrix As String = ""
        clsMatrixFunction.SetRCommand("matrix")

        If grdCurrSheet IsNot Nothing Then
            For i = 0 To grdCurrSheet.ColumnCount - 1
                For j = 0 To grdCurrSheet.RowCount - 1
                    If Not ((i = grdCurrSheet.ColumnCount - 1) And (j = grdCurrSheet.RowCount - 1)) Then
                        strMatrix = strMatrix & grdCurrSheet(row:=j, col:=i) & ","
                    Else
                        strMatrix = strMatrix & grdCurrSheet(row:=j, col:=i)
                    End If
                Next
            Next

        End If
        strMatrix = "c" & "(" & strMatrix & ")"
        clsMatrixFunction.AddParameter("data", strMatrix)
        clsRsyntax.AddParameter("layout_matrix", clsRFunctionParameter:=clsMatrixFunction)
    End Sub

    Private Sub chkSpecifyOrder_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpecifyOrder.CheckedChanged
        If chkSpecifyOrder.Checked = True Then
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
        clsMatrixFunction.AddParameter("ncol", nudColumns.Value)
        clsMatrixFunction.AddParameter("nrow", nudRows.Value)
    End Sub

    Public Sub RemoveNcolFromMatrixfunc()
        clsMatrixFunction.RemoveParameterByName("ncol")
        clsMatrixFunction.RemoveParameterByName("nrow")
        clsRsyntax.RemoveParameter("layout_matrix")
        clsRsyntax.AddParameter("nrow", nudRows.Value)
        clsRsyntax.AddParameter("ncol", nudColumns.Value)
    End Sub

    Private Sub grdLayout_Leave(sender As Object, e As EventArgs) Handles grdLayout.Leave
        If grdCurrSheet.IsEditing Then
            grdCurrSheet.EndEdit(EndEditReason.NormalFinish)
            SetMatrixFunction()
        End If
    End Sub
End Class

