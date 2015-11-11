Imports instat.Translations
Public Class frmVariables
    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Private Sub frmVariables_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadForm()
    End Sub

    Private Sub loadForm()
        gridVariables.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
        gridVariables.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowHorScroll, False)
        gridVariables.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, True)
        gridVariables.SheetTabNewButtonVisible = False
        gridVariables.SheetTabControlNewButtonVisible = False
        gridVariables.CurrentWorksheet.Resize(2, 2)
        autoTranslate(Me)
    End Sub
End Class