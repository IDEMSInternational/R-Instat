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
Public Class dlgInventoryMethod

    Private Sub dlgInventoryMethod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$plot_inventory")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        ucrBase.clsRsyntax.AddParameter("main_title", Chr(34) & txtTitle.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtVariableLabel_TextChanged(sender As Object, e As EventArgs) Handles txtVariableLabel.TextChanged
        ucrBase.clsRsyntax.AddParameter("var_label", Chr(34) & txtVariableLabel.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtColour_TextChanged(sender As Object, e As EventArgs) Handles txtColour.TextChanged
        ucrBase.clsRsyntax.AddParameter("col", Chr(34) & txtTitle.Text.ToString() & Chr(34)) ' a vector.need to change. not figured out the implementation 

    End Sub

    Private Sub txtYLabel_TextChanged(sender As Object, e As EventArgs) Handles txtYLabel.TextChanged
        ucrBase.clsRsyntax.AddParameter("ylab", Chr(34) & txtYLabel.Text.ToString() & Chr(34))

    End Sub

    Private Sub chkSort_CheckedChanged(sender As Object, e As EventArgs) Handles chkSort.CheckedChanged
        If chkSort.Checked Then
            ucrBase.clsRsyntax.AddParameter("sort", Chr(34) & chkSort.Checked.ToString().ToUpper() & Chr(34))
        End If
    End Sub

    Private Sub chkRemoveNA_CheckedChanged(sender As Object, e As EventArgs) Handles chkRemoveNA.CheckedChanged
        If chkRemoveNA.Checked Then
            ucrBase.clsRsyntax.AddParameter("na.rm", Chr(34) & chkRemoveNA.Checked.ToString().ToUpper() & Chr(34))
        End If
    End Sub
End Class