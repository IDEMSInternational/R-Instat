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
Public Class dlgThemes
    Private bFirstLoad As Boolean = True
    Private Sub dlgThemes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()

        End If
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrInputThemeLists.cboInput.Items.Add("theme_bw")
        ucrInputThemeLists.cboInput.Items.Add("theme_linedraw")
        ucrInputThemeLists.cboInput.Items.Add("theme_light")
        ucrInputThemeLists.cboInput.Items.Add("theme_minimal")
        ucrInputThemeLists.cboInput.Items.Add("theme_classic")
        ucrInputThemeLists.cboInput.Items.Add("theme_dark")
        ucrInputThemeLists.cboInput.Items.Add("theme_void")

        'from ggthemes
        ucrInputThemeLists.cboInput.Items.Add("theme_base")
        ucrInputThemeLists.cboInput.Items.Add("theme_calc")
        ucrInputThemeLists.cboInput.Items.Add("theme_economist")
        ucrInputThemeLists.cboInput.Items.Add("theme_economist")
        ucrInputThemeLists.cboInput.Items.Add("theme_excel")
        ucrInputThemeLists.cboInput.Items.Add("theme_few")
        ucrInputThemeLists.cboInput.Items.Add("theme_fivethirtyeight")
        ucrInputThemeLists.cboInput.Items.Add("theme_foundation")
        ucrInputThemeLists.cboInput.Items.Add("theme_gdocs")
        ucrInputThemeLists.cboInput.Items.Add("theme_hc")
        ucrInputThemeLists.cboInput.Items.Add("theme_igray")
        ucrInputThemeLists.cboInput.Items.Add("theme_map")
        ucrInputThemeLists.cboInput.Items.Add("theme_pander")
        ucrInputThemeLists.cboInput.Items.Add("theme_par")
        ucrInputThemeLists.cboInput.Items.Add("theme_solarized")
        ucrInputThemeLists.cboInput.Items.Add("theme_solid")
        ucrInputThemeLists.cboInput.Items.Add("theme_stata")
        ucrInputThemeLists.cboInput.Items.Add("theme_tufte")
        ucrInputThemeLists.cboInput.Items.Add("theme_wsj")
    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub ReopenDialog()

    End Sub
    Private Sub TestOkEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub cmdCreateNewTheme_Click(sender As Object, e As EventArgs) Handles cmdCreateNewTheme.Click
        dlgCreateNewTheme.ShowDialog()
    End Sub
End Class