
Imports instat.Translations
Public Class dlgEndofRains
    Private Sub ucrBase_clickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim strScript As String
        strScript = "climate_obj$add_end_rain(data_list=list()"
        strScript = strScript & ", earliest_day=" & nudEarliest.Value.ToString()
        strScript = strScript & ", evaporation=" & nudEvaporation.Value.ToString()
        strScript = strScript & ", capacity_max=" & nudCapacityMax.Value.ToString()
        strScript = strScript & ", col_name=" & Chr(34) & txtColumnName.Text & Chr(34) & ", water_balance_col_name=" & Chr(34) & txtColumnName.Text & Chr(34)
        strScript = strScript & ",replace=TRUE)"

        frmMain.clsRLink.RunScript(strScript, False)
        'TODO fix this to update grids instead of calling FillData which no longer exists
        '        frmMain.FillData("climate_obj$climate_data_objects[[1]]$data")
        '        frmMain.FillData("climate_obj$used_data_objects[[1]]$data")
        Me.Hide()
    End Sub


    Private Sub dlgEndofRains_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'UpdateVisible()
        autoTranslate(Me)
    End Sub

    'Private Sub UpdateVisible()
    '    lblDryLength.Visible = chkDrySpell.Checked
    '    lblWithin.Visible = chkDrySpell.Checked
    '    lblDays.Visible = chkDrySpell.Checked
    '    nudDryLength.Visible = chkDrySpell.Checked
    '    nudWithin.Visible = chkDrySpell.Checked
    'End Sub

    Private Sub ucrBase_Load(sender As Object, e As EventArgs) Handles ucrBase.Load

    End Sub

    Private Sub lblColumnName_Click(sender As Object, e As EventArgs) Handles lblColumnName.Click

    End Sub

    Private Sub lblThreashold_Click(sender As Object, e As EventArgs) Handles lblCapacityMax.Click

    End Sub
End Class
