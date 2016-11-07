' Copyright (C) 2015
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat.Translations
Public Class dlgStartofRains
    Public bFirstLoad As Boolean = True
    Private Sub ucrBase_clickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk

        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If

        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim strScript As String

        strScript = "climate_obj$add_start_rain(data_list=list()"
        strScript = strScript & ", earliest_day=" & nudEarliest.Value.ToString()
        strScript = strScript & ", total_days=" & nudNumberofRainDays.Value.ToString()
        strScript = strScript & ", rain_total=" & nudTotalRain.Value.ToString()
        strScript = strScript & ", threshold=" & nudThreashold.Value.ToString()
        strScript = strScript & ", dry_spell_condition=" & chkDrySpell.Checked.ToString().ToUpper()
        If chkDrySpell.Checked Then
            strScript = strScript & ", dry_days=" & nudDryLength.Value.ToString()
            strScript = strScript & ", dry_length=" & nudWithin.Value.ToString()
        End If
        strScript = strScript & ", col_name=" & Chr(34) & ucrInputColumnName.Name & Chr(34)
        strScript = strScript & ",replace=TRUE)"

        frmMain.clsRLink.RunScript(strScript, False)
        'TODO fix this to update grids instead of calling FillData which no longer exists
        '        frmMain.FillData("climate_obj$climate_data_objects[[1]]$data")
        '        frmMain.FillData("climate_obj$used_data_objects[[1]]$data")
        Me.Hide()
    End Sub

    Private Sub SetDefaults()
        ucrBase.OKEnabled(False)
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
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
End Class