'Imports instat.Translations
'Public Class dlgYearRaincount
'    Private Sub ucrBase_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
'        autoTranslate(Me)
'        ucrBase.clsRsyntax.SetFunction("climate_obj$plot_yearly_rain_count")
'        ucrBase.clsRsyntax.iCallType = 0
'    End Sub

'    Private Sub dlgYearRaincount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'    End Sub
'End Class

Imports instat.Translations
Public Class dlgYearRaincount
    Private Sub dlgYearRaincount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$plot_yearly_rain_count")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        ucrBase.clsRsyntax.AddParameter("title", Chr(34) & txtTitle.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtVariable_TextChanged(sender As Object, e As EventArgs) Handles txtVariable.TextChanged

    End Sub

    Private Sub txtVariableLabel_TextChanged(sender As Object, e As EventArgs) Handles txtVariableLabel.TextChanged
        ucrBase.clsRsyntax.AddParameter("var_label", Chr(34) & txtVariableLabel.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtType_TextChanged(sender As Object, e As EventArgs) Handles txtType.TextChanged
        ucrBase.clsRsyntax.AddParameter("type", Chr(34) & txtVariable.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtXLabel_TextChanged(sender As Object, e As EventArgs) Handles txtXLabel.TextChanged
        ucrBase.clsRsyntax.AddParameter("xlab", Chr(34) & txtXLabel.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtYLabel_TextChanged(sender As Object, e As EventArgs) Handles txtYLabel.TextChanged
        ucrBase.clsRsyntax.AddParameter("ylab", Chr(34) & txtYLabel.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtColour2_TextChanged(sender As Object, e As EventArgs) Handles txtColour2.TextChanged
        ucrBase.clsRsyntax.AddParameter("col2", Chr(34) & txtColour2.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtColour1_TextChanged(sender As Object, e As EventArgs) Handles txtColour1.TextChanged
        ucrBase.clsRsyntax.AddParameter("col1", Chr(34) & txtColour1.Text.ToString() & Chr(34))

    End Sub

    Private Sub chkGrid_CheckedChanged(sender As Object, e As EventArgs) Handles chkGrid.CheckedChanged
        If chkGrid.Checked Then
            ucrBase.clsRsyntax.AddParameter("grid", chkGrid.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkPlotWindow_CheckedChanged(sender As Object, e As EventArgs) Handles chkPlotWindow.CheckedChanged
        If chkPlotWindow.Checked Then
            ucrBase.clsRsyntax.AddParameter("plot_window", chkPlotWindow.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkRemoveNA_CheckedChanged(sender As Object, e As EventArgs) Handles chkRemoveNA.CheckedChanged
        If chkRemoveNA.Checked Then
            ucrBase.clsRsyntax.AddParameter("na.rm", chkRemoveNA.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub nudLineWidth1_ValueChanged(sender As Object, e As EventArgs) Handles nudLineWidth1.ValueChanged
        ucrBase.clsRsyntax.AddParameter("lwd", nudLineWidth1.Value.ToString())

    End Sub

    Private Sub nudLineWidth2_ValueChanged(sender As Object, e As EventArgs) Handles nudLineWidth2.ValueChanged
        ucrBase.clsRsyntax.AddParameter("lwd2", nudLineWidth2.Value.ToString())

    End Sub

    Private Sub nudLineType_ValueChanged(sender As Object, e As EventArgs) Handles nudLineType.ValueChanged
        ucrBase.clsRsyntax.AddParameter("lty", nudLineType.Value.ToString())

    End Sub

    Private Sub nudYGrid_ValueChanged(sender As Object, e As EventArgs) Handles nudYGrid.ValueChanged
        ucrBase.clsRsyntax.AddParameter("ygrid", nudYGrid.Value.ToString())

    End Sub

    Private Sub nudYLimits_ValueChanged(sender As Object, e As EventArgs) Handles nudYLimits.ValueChanged
        ucrBase.clsRsyntax.AddParameter("ylim", nudYLimits.Value.ToString())

    End Sub

    Private Sub nudPlotCharacter_ValueChanged(sender As Object, e As EventArgs) Handles nudPlotCharacter.ValueChanged
        ucrBase.clsRsyntax.AddParameter("pch", nudPlotCharacter.Value.ToString())

    End Sub
End Class