Imports instat.Translations
Public Class frmMetaData
    Private Sub frmMetaData_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadForm()
    End Sub

    Private Sub loadForm()
        gridMetaData.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
        gridMetaData.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowHorScroll, False)
        gridMetaData.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, True)
        gridMetaData.SheetTabNewButtonVisible = False
        gridMetaData.SheetTabControlNewButtonVisible = False
        gridMetaData.CurrentWorksheet.Resize(2, 2)
        autoTranslate(Me)
    End Sub
    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub
End Class