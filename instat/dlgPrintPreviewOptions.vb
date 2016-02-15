Public Class dlgPrintPreviewOptions
    Private Sub cmdPrevSheet_Click(sender As Object, e As EventArgs) Handles cmdPrevSheet.Click
        Dim sheetPreview = frmEditor.grdData.CurrentWorksheet

        Using session = sheetPreview.CreatePrintSession()
            Using previewPrint As New PrintPreviewDialog()
                previewPrint.Document = session.PrintDocument
                previewPrint.SetBounds(200, 200, 1024, 768)
                previewPrint.PrintPreviewControl.Zoom = 1.0
                previewPrint.ShowDialog(Me)
            End Using
        End Using
    End Sub

    Private Sub cmdPrtSheet_Click(sender As Object, e As EventArgs) Handles cmdPrtSheet.Click
        Dim docToPrint As Printing.PrintDocument = Nothing
        Try
            docToPrint = frmEditor.grdData.CurrentWorksheet.CreatePrintSession().PrintDocument

        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, Me.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End Try
        Using pd = New PrintDialog()
            pd.Document = docToPrint
            pd.UseEXDialog = True
            If pd.ShowDialog() = DialogResult.OK Then
                docToPrint.PrinterSettings = pd.PrinterSettings
                docToPrint.Print()
            End If
        End Using
    End Sub
End Class