' Instat-R
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
Public Class dlgWaterBalance
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$display_water_balance()")
        ucrBase.clsRsyntax.iCallType = 0
        'frmMain.FillData("climate_obj$climate_data_objects[[1]]$data")
        'frmMain.FillData("climate_obj$used_data_objects[[1]]$data")
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

End Class