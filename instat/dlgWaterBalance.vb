Imports instat.Translations
Public Class dlgWaterBalance

    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$display_water_balance()")
        ucrBase.clsRsyntax.iCallType = 0
        frmMain.FillData("climate_obj$climate_data_objects[[1]]$data")
        frmMain.FillData("climate_obj$used_data_objects[[1]]$data")
        Me.Hide()

    End Sub

    Private Sub txtColunmName_Leave(sender As Object, e As EventArgs) Handles txtColumnName.Leave
        ucrBase.clsRsyntax.AddParameter("col_name", Chr(34) & txtColumnName.Text & Chr(34))
        ucrBase.clsRsyntax.AddParameter("evaporation", Chr(34) & txtColumnName.Text & Chr(34))
        ucrBase.clsRsyntax.AddParameter("decimal_places", Chr(34) & txtColumnName.Text & Chr(34))
        ucrBase.clsRsyntax.AddParameter("day_display", Chr(34) & txtColumnName.Text & Chr(34))
        ucrBase.clsRsyntax.AddParameter("capacity_max", Chr(34) & txtColumnName.Text & Chr(34))
        If chkPrintTable.Checked Then
            ucrBase.clsRsyntax.AddParameter("print_tables", Chr(34) & txtColumnName.Text & Chr(34))

        End If
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