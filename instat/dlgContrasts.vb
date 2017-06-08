' Instat-R
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
Imports instat.Translations
Imports RDotNet
Imports unvell.ReoGrid
Imports unvell.ReoGrid.Events

Public Class dlgContrasts
    Public WithEvents grdCurrSheet As Worksheet
    Public bFirstLoad As Boolean = True
    Public bReset As Boolean = True
    Public clsNlevels, clsFactorColumn, clsContractMatrix, clsSetContrast As New RFunction

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        grdLayoutForContrasts.SetSettings(WorkbookSettings.View_ShowSheetTabControl, False)
        grdLayoutForContrasts.SetSettings(WorkbookSettings.View_ShowHorScroll, False)
        grdLayoutForContrasts.SheetTabNewButtonVisible = False
        grdCurrSheet = grdLayoutForContrasts.CurrentWorksheet
        grdCurrSheet.SetSettings(WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        grdCurrSheet.SelectionForwardDirection = SelectionForwardDirection.Down
    End Sub

    Private Sub dlgContrasts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrSelectorForContrast.SetRCode(clsSetContrast, bReset)
        ucrReceiverForContrasts.SetRCode(clsSetContrast, bReset)
        ucrInputContrastName.SetRCode(clsSetContrast, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiverForContrasts.IsEmpty OrElse (ucrInputContrastName.GetText = "User Defined" AndAlso IsEmptyCells()) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverForContrasts.Selector = ucrSelectorForContrast
        ucrReceiverForContrasts.SetMeAsReceiver()
        ucrReceiverForContrasts.SetIncludedDataTypes({"factor"})
        ucrBase.iHelpTopicID = 353

        Dim dctContrastTypes As New Dictionary(Of String, String)
        ucrInputContrastName.SetParameter(New RParameter("new_contrasts", 2))
        dctContrastTypes.Add("Treatment/Control", Chr(34) & "contr.treatment" & Chr(34))
        dctContrastTypes.Add("Helmert", Chr(34) & "contr.helmert" & Chr(34))
        dctContrastTypes.Add("Polynomials", Chr(34) & "contr.poly" & Chr(34))
        dctContrastTypes.Add("Sum to Zero", Chr(34) & "contr.sum" & Chr(34))
        dctContrastTypes.Add("User Defined", Chr(34) & "user_defined" & Chr(34))
        ucrInputContrastName.SetItems(dctContrastTypes)
        ucrInputContrastName.SetLinkedDisplayControl(lblSelectContrastName)
        ucrInputContrastName.SetDropDownStyleAsNonEditable()
        ucrSelectorForContrast.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForContrast.SetParameterIsString()

        ucrReceiverForContrasts.SetParameter(New RParameter("col_name", 1))
        ucrReceiverForContrasts.SetParameterIsString()

    End Sub

    Private Sub SetDefaults()
        clsContractMatrix = New RFunction
        clsNlevels = New RFunction
        clsFactorColumn = New RFunction
        clsSetContrast = New RFunction

        grdCurrSheet.Reset()

        ucrInputContrastName.Reset()
        ucrSelectorForContrast.Reset()

        clsSetContrast.AddParameter("new_contrasts", Chr(34) & "contr.treatment" & Chr(34))

        clsNlevels.SetRCommand("nlevels")
        clsContractMatrix.SetRCommand("matrix")
        clsFactorColumn.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsSetContrast.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_contrasts_of_factor")

        ucrBase.clsRsyntax.SetBaseRFunction(clsSetContrast)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Public Sub SetMatrixFunction()
        Dim i As Integer
        Dim j As Integer
        Dim strMatrix As String = ""
        If IsEmptyCells() OrElse ucrReceiverForContrasts.IsEmpty OrElse ucrInputContrastName.GetText <> "User Defined" Then
            clsContractMatrix.RemoveParameterByName("ncol")
            clsContractMatrix.RemoveParameterByName("data")
            clsContractMatrix.RemoveParameterByName("nrow")
            ucrBase.clsRsyntax.RemoveParameter("defined_contr_matrix")
        Else
            If grdCurrSheet IsNot Nothing Then
                For i = 0 To grdCurrSheet.ColumnCount - 1
                    For j = 0 To grdCurrSheet.RowCount - 1
                        strMatrix = strMatrix & grdCurrSheet(row:=j, col:=i)
                        If Not ((i = grdCurrSheet.ColumnCount - 1) AndAlso (j = grdCurrSheet.RowCount - 1)) Then
                            strMatrix = strMatrix & ","
                        End If
                    Next
                Next
            End If
            strMatrix = "c(" & strMatrix & ")"
            clsContractMatrix.AddParameter("data", strMatrix)
            clsContractMatrix.AddParameter("ncol", grdCurrSheet.Columns)
            clsContractMatrix.AddParameter("nrow", grdCurrSheet.Rows)
            ucrBase.clsRsyntax.AddParameter("defined_contr_matrix", clsRFunctionParameter:=clsContractMatrix)
        End If
    End Sub

    Private Sub SetGridDimensions()
        If Not ucrReceiverForContrasts.IsEmpty AndAlso ucrInputContrastName.GetText = "User Defined" Then
            Me.Size = New System.Drawing.Size(440 + grdLayoutForContrasts.Width, 294)
            clsFactorColumn.AddParameter("col_name", ucrReceiverForContrasts.GetVariableNames())
            clsFactorColumn.AddParameter("data_name", Chr(34) & ucrSelectorForContrast.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
            clsNlevels.AddParameter("x", clsRFunctionParameter:=clsFactorColumn)
            grdCurrSheet.Rows = frmMain.clsRLink.RunInternalScriptGetValue(clsNlevels.ToScript).AsNumeric(0)
            grdCurrSheet.Columns = grdCurrSheet.Rows - 1
            grdLayoutForContrasts.Enabled = True
        Else
            Me.Size = New System.Drawing.Size(435, 294)
            clsFactorColumn.RemoveParameterByName("col_name")
            clsNlevels.RemoveParameterByName("x")
            grdLayoutForContrasts.Enabled = False
        End If
        SetMatrixFunction()
    End Sub

    Private Sub grdCurrSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdCurrSheet.AfterCellEdit
        If e.NewData.ToString() <> "" Then
            If Not IsNumeric(e.NewData) Then
                MsgBox("Invalid value: " & e.NewData.ToString() & vbNewLine & "You entered a non numeric value. Please enter a numeric value ", MsgBoxStyle.Exclamation, "Invalid Value")
                e.EndReason = EndEditReason.Cancel
            ElseIf e.NewData Is Nothing Then
                MsgBox("All the cells in the grid must not be empty", MsgBoxStyle.Exclamation)
                e.EndReason = EndEditReason.Cancel
            End If
        End If
    End Sub

    Public Function IsEmptyCells() As Boolean
        For i = 0 To grdCurrSheet.ColumnCount - 1
            For j = 0 To grdCurrSheet.RowCount - 1
                If grdCurrSheet(row:=j, col:=i) Is Nothing Then
                    Return True
                End If
            Next
        Next
        Return False
    End Function

    Private Sub grdLayoutForContrasts_AfterCellKeyDown(sender As Object, e As EventArgs) Handles grdCurrSheet.AfterCellKeyDown
        SetMatrixFunction()
        TestOKEnabled()
    End Sub

    Private Sub grdLayoutForContrasts_Leave(sender As Object, e As EventArgs) Handles grdLayoutForContrasts.Leave
        If grdCurrSheet.IsEditing Then
            grdCurrSheet.EndEdit(EndEditReason.NormalFinish)
        End If
    End Sub

    Private Sub grdCurrSheet_CellDataChanged(sender As Object, e As EventArgs) Handles grdCurrSheet.CellDataChanged
        SetMatrixFunction()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverForContrasts_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverForContrasts.ControlContentsChanged
        If Not ucrReceiverForContrasts.IsEmpty Then
            grdLayoutForContrasts.Enabled = True
        Else
            grdLayoutForContrasts.Enabled = False
        End If
        SetGridDimensions()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputContrastName_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputContrastName.ControlContentsChanged
        SetGridDimensions()
        IsEmptyCells()
        TestOKEnabled()
    End Sub
End Class