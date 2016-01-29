Imports instat.Translations
Public Class dlgWaterBalance
    Private Sub ucrButtons_clickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim strScript As String
        strScript = "climate_obj$display_water_balance(data_list=list()"
        strScript = strScript & ", capacity_max=" & nudMaximumCapacity.ToString()
        strScript = strScript & ", evaporation=" & nudEvaporation.ToString()
        strScript = strScript & ", decimal_places=" & nudDecimalPlace.ToString()
        strScript = strScript & ", day_display=" & Chr(34) & txtDisplayDayName.Text.ToString() & Chr(34)

        If chkPrintTable.Checked Then
            strScript = strScript & ", print_tables=" & chkPrintTable.Checked.ToString().ToUpper
        End If

        strScript = strScript & ", col_name=" & Chr(34) & txtColumnName.Text & Chr(34)
        strScript = strScript & ")"
        frmMain.clsRLink.climateObject()
        frmMain.clsRLink.RunScript(strScript, False)
        'TODO fix this to update grids instead of calling FillData which no longer exists
        '        frmMain.FillData("climate_obj$climate_data_objects[[1]]$data")
        '        frmMain.FillData("climate_obj$used_data_objects[[1]]$data")
        Me.Hide()
    End Sub


    Private Sub dlgStartofRains_Load(sender As Object, e As EventArgs) Handles Me.Load
            'UpdateVisible()
            autoTranslate(Me)
        End Sub

    Private Sub dlgInventoryPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dlgWaterBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class