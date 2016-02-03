Public Class dlgAdvanceOptions
    Dim strScript As String
    Private Sub ucrBase_ClickReturn(sender As Object, e As EventArgs)
        'strScript = strScript & ", data_tables_meta_data=" & txtDataTablesMetaData.Text.ToString()
        'strScript = strScript & ", climate_object_meta_data=" & txt.Value.ToString()
        'strScript = strScript & ", data_tables_meta_data=" & txtDataTablesMetaData.Text.ToString()
        'strScript = strScript & ", data_tables_variables=" & txtDataTablesVariables.Text.ToString()
        'strScript = strScript & ", imported_from=" & txtImportedFrom.Text.ToString()
        'strScript = strScript & ", data_time_periods=" & txtDataTimePeriods.Text.ToString()
        'strScript = strScript & ", messages=" & chkMessages.Checked.ToString().ToUpper()
        'strScript = strScript & ", convert=" & chkConvert.Checked.ToString().ToUpper()
        'strScript = strScript & ", create=" & chkCreate.Checked.ToString().ToUpper()
    End Sub
    Private Sub dlgAdvanceOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class