' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

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
