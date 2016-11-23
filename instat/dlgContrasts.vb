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
    Public clsNlevels, clsFactorColumn, clsContractMatrix As New RFunction
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        grdLayoutForContrasts.SetSettings(WorkbookSettings.View_ShowSheetTabControl, False)
        grdLayoutForContrasts.SetSettings(WorkbookSettings.View_ShowHorScroll, False)
        grdLayoutForContrasts.SheetTabNewButtonVisible = False
        grdCurrSheet = grdLayoutForContrasts.CurrentWorksheet
        grdCurrSheet.SetSettings(WorksheetSettings.Edit_DragSelectionToMoveCells, False)
    End Sub

    Private Sub dlgContrasts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If ((Not ucrReceiverForContrasts.IsEmpty) AndAlso Not ((ucrInputContrastName.IsEmpty) OrElse (ucrInputContrastName.GetText = "User Defined" AndAlso IsEmptyCells()))) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverForContrasts.Selector = ucrSelectorForContrast
        ucrReceiverForContrasts.SetMeAsReceiver()
        ucrReceiverForContrasts.SetIncludedDataTypes({"factor"})
        ucrBase.iHelpTopicID = 353
        clsNlevels.SetRCommand("nlevels")
        clsContractMatrix.SetRCommand("matrix")
        clsFactorColumn.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        ucrInputContrastName.SetItems({"Treatment/Control", "Helmert", "Polynomials", "Sum to Zero", "User Defined"})
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_contrasts_of_factor")
        grdCurrSheet.SelectionForwardDirection = SelectionForwardDirection.Down
    End Sub

    Private Sub SetDefaults()
        ucrInputContrastName.SetName("Treatment/Control")
        ucrSelectorForContrast.Reset()
        SelectContrast()
        grdCurrSheet.Reset()
        ' ucrInputContrastName.SetEditable(True)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverForContrasts_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForContrasts.SelectionChanged
        If Not ucrReceiverForContrasts.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("col_name", ucrReceiverForContrasts.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("col_name")
        End If
        SelectContrast()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorForContrast_DataFrameChanged() Handles ucrSelectorForContrast.DataFrameChanged
        clsFactorColumn.AddParameter("data_name", Chr(34) & ucrSelectorForContrast.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorForContrast.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrInputContrast_NameChangedChanged() Handles ucrInputContrastName.NameChanged
        If Not ucrInputContrastName.IsEmpty Then
            SelectContrast()
        Else
            ucrBase.clsRsyntax.RemoveParameter("new_contrasts")
        End If
        TestOKEnabled()
    End Sub

    Private Sub SetGrdDimensions()
        If Not ucrReceiverForContrasts.IsEmpty AndAlso ucrInputContrastName.GetText = "User Defined" Then
            clsFactorColumn.AddParameter("col_name", ucrReceiverForContrasts.GetVariableNames())
            clsNlevels.AddParameter("x", clsRFunctionParameter:=clsFactorColumn)
            grdCurrSheet.Rows = frmMain.clsRLink.RunInternalScriptGetValue(clsNlevels.ToScript).AsNumeric(0)
            grdCurrSheet.Columns = grdCurrSheet.Rows - 1
        Else
            clsFactorColumn.RemoveParameterByName("col_name")
            clsNlevels.RemoveParameterByName("x")
        End If
    End Sub

    Private Sub SelectContrast()
        Select Case ucrInputContrastName.GetText
            Case "Treatment/Control"
                Me.Size = New System.Drawing.Size(435, 294)
                ucrBase.clsRsyntax.AddParameter("new_contrasts", Chr(34) & "contr.treatment" & Chr(34))
            Case "Helmert"
                Me.Size = New System.Drawing.Size(435, 294)
                ucrBase.clsRsyntax.AddParameter("new_contrasts", Chr(34) & "contr.helmert" & Chr(34))
            Case "Polynomials"
                Me.Size = New System.Drawing.Size(435, 294)
                ucrBase.clsRsyntax.AddParameter("new_contrasts", Chr(34) & "contr.poly" & Chr(34))
            Case "Sum to Zero"
                Me.Size = New System.Drawing.Size(435, 294)
                ucrBase.clsRsyntax.AddParameter("new_contrasts", Chr(34) & "contr.sum" & Chr(34))
            Case "User Defined"
                SetGrdDimensions()
                If Not ucrReceiverForContrasts.IsEmpty Then
                    Me.Size = New System.Drawing.Size(440 + grdLayoutForContrasts.Width, 294)
                Else
                    Me.Size = New System.Drawing.Size(435, 294)
                End If
                ucrBase.clsRsyntax.AddParameter("new_contrasts", Chr(34) & "user_defined" & Chr(34))
        End Select
    End Sub

    Public Sub SetMatrixFunction()
        Dim i As Integer
        Dim j As Integer
        Dim strMatrix As String = ""
        If Not IsEmptyCells() Then
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
            strMatrix = "c" & "(" & strMatrix & ")"

            clsContractMatrix.AddParameter("data", strMatrix)
        Else
            clsContractMatrix.RemoveParameterByName("data")
        End If
        clsContractMatrix.AddParameter("ncol", grdCurrSheet.Columns)
        clsContractMatrix.AddParameter("nrow", grdCurrSheet.Rows)
        ucrBase.clsRsyntax.AddParameter("defined_contr_matrix", clsRFunctionParameter:=clsContractMatrix)
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
        SetMatrixFunction()
        TestOKEnabled()
    End Sub

    Private Function IsEmptyCells() As Boolean
        For i = 0 To grdCurrSheet.ColumnCount - 1
            For j = 0 To grdCurrSheet.RowCount - 1
                If grdCurrSheet(row:=j, col:=i) Is Nothing Then
                    Return True
                End If
            Next
        Next
        Return False
    End Function

    Private Sub grdLayoutForContrasts_Leave(sender As Object, e As EventArgs) Handles grdLayoutForContrasts.Leave
        If grdCurrSheet.IsEditing Then
            grdCurrSheet.EndEdit(EndEditReason.NormalFinish)
        End If
    End Sub
End Class