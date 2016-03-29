Imports RDotNet
Imports System.IO
Public Class sdgImportExcel
    Private intLines As Integer = 11
    Public Sub receiveExcel(strFilePath As String)
        Dim i As Integer
        Dim dfSheetList As CharacterMatrix
        txtFilePath.Text = strFilePath
        dfSheetList = frmMain.clsRLink.clsEngine.Evaluate("getSheetNames(" & Chr(34) & strFilePath & Chr(34) & ")").AsCharacterMatrix
        'fills the combo box
        cboAvailableSheets.Items.Clear()
        cboAvailableSheets.SelectedIndex = -1
        For i = 0 To dfSheetList.RowCount - 1
            cboAvailableSheets.Items.Add(dfSheetList(i, 0))
        Next
        ucrBase.clsRsyntax.AddParameter("xlsxFile", Chr(34) & strFilePath & Chr(34))
    End Sub

    Private Sub cboAvailableSheets_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboAvailableSheets.SelectedValueChanged
        ucrBase.clsRsyntax.SetAssignTo(cboAvailableSheets.SelectedItem, cboAvailableSheets.SelectedItem)
        ucrBase.clsRsyntax.AddParameter("sheet", Chr(34) & cboAvailableSheets.SelectedItem & Chr(34))
        TestOkEnabled()
        RefreshFrameView()
    End Sub

    Private Sub sdgImportExcel_Load(sender As Object, e As EventArgs) Handles Me.Load
        ucrBase.clsRsyntax.SetFunction("readWorkbook")
        setDefaultValues()
        'Removes the Sheet Tab control
        grdPreview.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
        grdPreview.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AutoFormatCell, False)

        TestOkEnabled()
    End Sub

    Private Sub setDefaultValues()
        nudStartRow.Value = 1
        chkColumnNames.Checked = True
        chkDates.Checked = False
        chkSkipEmptyRows.Checked = True
        txtRegionName.Text = "None"
        cboAvailableSheets.SelectedIndex = -1
    End Sub

    Private Sub TestOkEnabled()
        If cboAvailableSheets.SelectedItem <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub RefreshFrameView()
        Dim dfTemp As CharacterMatrix
        Dim bToBeAssigned As Boolean
        bToBeAssigned = ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned
        Try
            ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned = False
            ucrBase.clsRsyntax.AddParameter("rows", "1:" & intLines)
            dfTemp = frmMain.clsRLink.GetData(ucrBase.clsRsyntax.GetScript())
            ucrBase.clsRsyntax.RemoveParameter("rows")
            ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned = bToBeAssigned
            frmMain.clsGrids.FillSheet(dfTemp, Path.GetFileNameWithoutExtension(txtFilePath.Text), grdPreview)
        Catch
            grdPreview.CurrentWorksheet.Reset()
        End Try
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        dlgImportDataset.Close()
    End Sub

    Private Sub nudStartRow_ValueChanged(sender As Object, e As EventArgs) Handles nudStartRow.ValueChanged
        If cboAvailableSheets.SelectedItem <> "" Then
            ucrBase.clsRsyntax.AddParameter("startRow", nudStartRow.Value)
            RefreshFrameView()
        End If
    End Sub

    Private Sub chkColumnNames_CheckStateChanged(sender As Object, e As EventArgs) Handles chkColumnNames.CheckStateChanged
        If cboAvailableSheets.SelectedItem <> "" Then
            If chkColumnNames.Checked Then
                ucrBase.clsRsyntax.AddParameter("colNames", "TRUE")
            Else
                ucrBase.clsRsyntax.AddParameter("colNames", "FALSE")
            End If
            RefreshFrameView()
        End If
    End Sub

    Private Sub chkDates_CheckStateChanged(sender As Object, e As EventArgs) Handles chkDates.CheckStateChanged
        If cboAvailableSheets.SelectedItem <> "" Then
            If chkDates.Checked Then
                ucrBase.clsRsyntax.AddParameter("detectDates", "TRUE")
            Else
                ucrBase.clsRsyntax.AddParameter("detectDates", "FALSE")
            End If
            RefreshFrameView()
        End If
    End Sub

    Private Sub chkNames_CheckStateChanged(sender As Object, e As EventArgs) Handles chkNames.CheckStateChanged
        If cboAvailableSheets.SelectedItem <> "" Then
            If chkNames.Checked Then
                ucrBase.clsRsyntax.AddParameter("check.names", "TRUE")
            Else
                ucrBase.clsRsyntax.AddParameter("check.names", "FALSE")
            End If
            RefreshFrameView()
        End If
    End Sub

    Private Sub chkSkipEmptyRows_CheckStateChanged(sender As Object, e As EventArgs) Handles chkSkipEmptyRows.CheckStateChanged
        If cboAvailableSheets.SelectedItem <> "" Then
            If chkSkipEmptyRows.Checked Then
                ucrBase.clsRsyntax.AddParameter("skipEmptyRows", "TRUE")
            Else
                ucrBase.clsRsyntax.AddParameter("skipEmptyRows", "FALSE")
            End If
            RefreshFrameView()
        End If
    End Sub
End Class