Imports instat.Translations
Public Class dlgInventoryPlot

    Private Sub ucrBase_clickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim strScript As String
        strScript = "climate_obj$inventory_plot(data_list=list()"
        strScript = strScript & ", col=c(" & txtWetColour.ToString()
        strScript = strScript & "," & txtDryColour.ToString() & ")"

        If chkSort.Checked Then
            strScript = strScript & ", sort=" & chkSort.Checked.ToString().ToUpper
        End If

        strScript = strScript & ", main_title=" & Chr(34) & txtPlotName.Text & Chr(34)
        strScript = strScript & ")"
        frmMain.clsRInterface.climateObject()
        frmMain.clsRInterface.RunScript(strScript, False)
        'frmMain.FillData("climate_obj$climate_data_objects[[1]]$data")
        'frmMain.FillData("climate_obj$used_data_objects[[1]]$data")
        Me.Hide()
    End Sub

    'Private Sub chkDrySpell_CheckedChanged(sender As Object, e As EventArgs) Handles chkDrySpell.CheckedChanged
    '    UpdateVisible()
    'End Sub

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

    Private Sub ucrBase_Load(sender As Object, e As EventArgs) Handles ucrBase.Load

    End Sub

    Private Sub lblColumnName_Click(sender As Object, e As EventArgs) Handles lblColumnName.Click

    End Sub

    Private Sub dlgInventoryPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class