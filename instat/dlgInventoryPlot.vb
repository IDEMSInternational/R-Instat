Imports instat.Translations
Public Class dlgInventoryPlot
    Private Sub ucrButtons_clickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim strScript As String
        strScript = "climate_obj$plot_inventory(data_list=list()"
        strScript = strScript & ", col=c(" & Chr(34) & txtWetColour.Text.ToString() & Chr(34)
        strScript = strScript & "," & Chr(34) & txtDryColour.Text.ToString() & Chr(34) & ")"
        strScript = strScript & ", sort=" & chkSort.Checked.ToString().ToUpper
        strScript = strScript & ", na.rm=" & chkSort.Checked.ToString().ToUpper
        strScript = strScript & ", main_title=" & Chr(34) & txtPlotName.Text & Chr(34)
        strScript = strScript & ")"

        frmMain.clsRLink.RunScript(strScript, False)
        'frmMain.FillData("climate_obj$climate_data_objects[[1]]$data")
        'frmMain.FillData("climate_obj$used_data_objects[[1]]$data")
        Me.Hide()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 454
    End Sub

    Private Sub dlgStartofRains_Load(sender As Object, e As EventArgs) Handles Me.Load
        'UpdateVisible()
        autoTranslate(Me)
    End Sub

    Private Sub UpdateVisible()
        'lblDryLength.Visible = chkDrySpell.Checked
        'lblWithin.Visible = chkDrySpell.Checked
        'lblDays.Visible = chkDrySpell.Checked
        'nudDryLength.Visible = chkDrySpell.Checked
        'nudWithin.Visible = chkDrySpell.Checked
    End Sub

    Private Sub dlgInventoryPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub txtPlotName_TextChanged(sender As Object, e As EventArgs) Handles txtPlotName.TextChanged

    End Sub
End Class