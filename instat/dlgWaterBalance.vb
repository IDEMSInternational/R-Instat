Imports instat.Translations
Public Class dlgWaterBalance

    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$display_water_balance()")
        ucrBase.clsRsyntax.iCallType = 1
        frmMain.FillData("climate_obj$climate_data_objects[[1]]$data")
        frmMain.FillData("climate_obj$used_data_objects[[1]]$data")
        Me.Hide()

    End Sub

    Private Sub txtColunmName_Leave(sender As Object, e As EventArgs) Handles txtColumnName.Leave
        ucrBase.clsRsyntax.AddParameter("col_name", Chr(34) & txtColumnName.Text & Chr(34))
    End Sub

    Private Sub nudEvapration_Leave(sender As Object, e As EventArgs) Handles nudEvaporation.Leave
        ucrBase.clsRsyntax.AddParameter("evaporation", nudEvaporation.Value)
    End Sub

    Private Sub nudDecimalPlace_Leave(sender As Object, e As EventArgs) Handles nudDecimalPlace.Leave

        ucrBase.clsRsyntax.AddParameter("decimal_places", nudDecimalPlace.Value)
    End Sub
    Private Sub txtDisplayDayName_Leave(sender As Object, e As EventArgs) Handles txtDisplayDayName.Leave

        ucrBase.clsRsyntax.AddParameter("day_display", txtDisplayDayName.Text)
    End Sub

    Private Sub nudMaximumCapacity_Leave(sender As Object, e As EventArgs) Handles nudMaximumCapacity.Leave

        ucrBase.clsRsyntax.AddParameter("capacity_max", nudMaximumCapacity.Value)
    End Sub
    Private Sub chkPrintTable_Leave(sender As Object, e As EventArgs) Handles chkPrintTable.Leave
        If chkPrintTable.Checked Then
            ucrBase.clsRsyntax.AddParameter("print_tables", chkPrintTable.Checked.ToString.ToUpper())

        End If
    End Sub



End Class