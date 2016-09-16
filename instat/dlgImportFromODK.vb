'Instat-R
'Copyright (C) 2015
'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'You should have received a copy of the GNU General Public License k
'along with this program.  If not, see <http://www.gnu.org/licenses/>.
'
Imports instat.Translations
Public Class dlgImportFromODK
    Public bFirstLoad As Boolean = True
    Private Sub dlgImportFromODK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strClimateObject & "$")
    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub rdoKobo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoKobo.CheckedChanged, rdoOna.CheckedChanged
        If rdoOna.Checked Then

        Else

        End If
    End Sub

    Private Sub ucrInputUsername_NameChanged() Handles ucrInputUsername.NameChanged

    End Sub

    Private Sub ucrInputPassword_NameChanged() Handles ucrInputPassword.NameChanged

    End Sub

    Private Sub ucrInputChooseForm_NameChanged() Handles ucrInputChooseForm.NameChanged

    End Sub
End Class