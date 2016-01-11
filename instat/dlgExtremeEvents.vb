
Imports instat.Translations
Public Class dlgExtremeEvents
    Private Sub ucrBase_clickOk(sender As Object, e As EventArgs) Handles UcrButtons1.ClickOk
        Dim strScript As String
        strScript = "climate_obj$extreme_events(data_list=list()"
        strScript = strScript & ", start_day=" & nudStartDay.Value.ToString()
        strScript = strScript & ", end_day=" & nudEndDay.Value.ToString()
        strScript = strScript & ", total_days=" & nudTotalDays.Value.ToString()
        strScript = strScript & ", col_names=c(" & Chr(34) & txtColumNameExtremeEvent.Text.ToString() & Chr(34)
        strScript = strScript & "," & Chr(34) & txtColumnNameEventDay.Text.ToString() & Chr(34) & ")"
        strScript = strScript & ", val_threshold=" & chkThresholdValue.Checked.ToString().ToUpper()
        strScript = strScript & ", na.rm=" & chkRemoveNA.Checked.ToString().ToUpper()

        If chkThresholdValue.Checked Then
            strScript = strScript & ", threshold_value=" & nudThreshold.Value.ToString()
        End If
        strScript = strScript & ",replace=True)"
        frmMain.clsRInterface.climateObject()
        frmMain.clsRInterface.RunScript(strScript, False)
        'TODO fix this to update grids instead of calling FillData which no longer exists
        '        frmMain.FillData("climate_obj$climate_data_objects[[1]]$data")
        '        frmMain.FillData("climate_obj$used_data_objects[[1]]$data")
        Me.Hide()
    End Sub

    Private Sub chkDrySpell_CheckedChanged(sender As Object, e As EventArgs) Handles chkThresholdValue.CheckedChanged
        UpdateVisible()
    End Sub

    Private Sub dlgStartofRains_Load(sender As Object, e As EventArgs) Handles Me.Load
        UpdateVisible()
        autoTranslate(Me)

    End Sub

    Private Sub UpdateVisible()
        lblThreshold.Visible = chkThresholdValue.Checked
    End Sub

    Private Sub ucrBase_Load(sender As Object, e As EventArgs) Handles UcrButtons1.Load

    End Sub

    Private Sub txtColumnNameExtremeEvent_Click(sender As Object, e As EventArgs) Handles lblColumnNameExtremeEvent.Click

    End Sub

    Private Sub dlgExtremeEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class