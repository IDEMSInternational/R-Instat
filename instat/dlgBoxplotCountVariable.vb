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
Public Class dlgBoxplotCountVariable
    Public bFirstLoad As Boolean = True
    Private Sub dlgBoxplotCountVariable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()

    End Sub

    Private Sub TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction("climate_obj$boxplot_method")
    End Sub
    Private Sub SetDefaults()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub chkVarwidth_ValueChanged(sender As Object, e As EventArgs) Handles chkVarwidth.CheckedChanged
        If chkVarwidth.Checked Then
            ucrBase.clsRsyntax.AddParameter("varwidth", chkVarwidth.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub ucrInputTitle_Leave(sender As Object, e As EventArgs) Handles ucrInputTitle.Leave
        ucrBase.clsRsyntax.AddParameter("title", Chr(34) & ucrInputTitle.Text.ToString() & Chr(34))

    End Sub

    Private Sub ucrInputVariable_TextChanged(sender As Object, e As EventArgs) Handles ucrInputVariable.TextChanged
        ucrBase.clsRsyntax.AddParameter("var_label", Chr(34) & ucrInputVariable.Text.ToString() & Chr(34))

    End Sub

    Private Sub ucrInputColour_TextChanged(sender As Object, e As EventArgs) Handles ucrInputColour.TextChanged
        ucrBase.clsRsyntax.AddParameter("fill_col", Chr(34) & ucrInputColour.Text.ToString() & Chr(34))

    End Sub

    Private Sub ucrInputWhiskerColour_TextChanged(sender As Object, e As EventArgs) Handles ucrInputWhiskerColour.TextChanged
        ucrBase.clsRsyntax.AddParameter("whisker_col", Chr(34) & ucrInputWhiskerColour.Text.ToString() & Chr(34))

    End Sub

    Private Sub ucrInputTimeperiod_TextChanged(sender As Object, e As EventArgs) Handles ucrInputTimePeriod.TextChanged
        ucrBase.clsRsyntax.AddParameter("time_period", Chr(34) & ucrInputTimePeriod.Text.ToString() & Chr(34))

    End Sub

    Private Sub nudWhiskLineType_ValueChanged(sender As Object, e As EventArgs) Handles nudWhiskLineType.ValueChanged
        ucrBase.clsRsyntax.AddParameter("whiskerlty", nudWhiskLineType.Value.ToString())

    End Sub
End Class