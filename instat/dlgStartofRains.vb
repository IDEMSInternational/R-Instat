
Imports instat.Translations
Public Class dlgStartofRains
    Private Sub ucrBase_clickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim strScript As String
        strScript = "climate_obj$add_start_rain(data_list=list()"
        strScript = strScript & ", earliest_day=" & nudEarliest.Value.ToString()
        strScript = strScript & ", total_days=" & nudNumberofRainDays.Value.ToString()
        strScript = strScript & ", rain_total=" & nudTotalRain.Value.ToString()
        strScript = strScript & ", threshold=" & nudThreshold.Value.ToString()
        strScript = strScript & ", dry_spell_condition=" & chkDrySpell.Checked.ToString().ToUpper()
        If chkDrySpell.Checked Then
            strScript = strScript & ", dry_days=" & nudDryLength.Value.ToString()
            strScript = strScript & ", dry_length=" & nudWithin.Value.ToString()
        End If
        strScript = strScript & ", col_name=" & Chr(34) & txtColumnName.Text & Chr(34)
        strScript = strScript & ",replace=TRUE)"

        frmMain.clsRLink.RunScript(strScript, False)
        'TODO fix this to update grids instead of calling FillData which no longer exists
        '        frmMain.FillData("climate_obj$climate_data_objects[[1]]$data")
        '        frmMain.FillData("climate_obj$used_data_objects[[1]]$data")
        Me.Hide()
    End Sub

    Private Sub chkDrySpell_CheckedChanged(sender As Object, e As EventArgs) Handles chkDrySpell.CheckedChanged
        UpdateVisible()
    End Sub

    Private Sub dlgStartofRains_Load(sender As Object, e As EventArgs) Handles Me.Load
        UpdateVisible()
        autoTranslate(Me)

    End Sub

    Private Sub UpdateVisible()
        lblDryLength.Visible = chkDrySpell.Checked
        lblWithin.Visible = chkDrySpell.Checked
        lblDays.Visible = chkDrySpell.Checked
        nudDryLength.Visible = chkDrySpell.Checked
        nudWithin.Visible = chkDrySpell.Checked
    End Sub

    Private Sub ucrBase_Load(sender As Object, e As EventArgs) Handles ucrBase.Load

    End Sub

    Private Sub lblColumnName_Click(sender As Object, e As EventArgs) Handles lblColumnName.Click

    End Sub
End Class