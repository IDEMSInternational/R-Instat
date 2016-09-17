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
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$import_from_ODK")
    End Sub

    Private Sub TestOKEnabled()
        If cmdFindForms.Enabled = True AndAlso ucrInputChooseForm.IsEmpty = False AndAlso (rdoKobo.Checked Or rdoOna.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        rdoKobo.Checked = True
        ucrInputUsername.Reset()
        ucrInputPassword.Reset()
        ucrInputChooseForm.Reset()
        enambleCommandButton()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub rdoKobo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoKobo.CheckedChanged, rdoOna.CheckedChanged
        If rdoOna.Checked Then
            ucrBase.clsRsyntax.AddParameter("username", Chr(34) & "ona" & Chr(34))
        Else
            ucrBase.clsRsyntax.AddParameter("username", Chr(34) & "kobo" & Chr(34))
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrInputUsername_NameChanged() Handles ucrInputUsername.NameChanged
        ucrBase.clsRsyntax.AddParameter("username", Chr(34) & ucrInputUsername.GetText & Chr(34))
        enambleCommandButton()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputPassword_NameChanged() Handles ucrInputPassword.NameChanged
        ucrBase.clsRsyntax.AddParameter("password", Chr(34) & ucrInputPassword.GetText & Chr(34))
        enambleCommandButton()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputChooseForm_NameChanged() Handles ucrInputChooseForm.NameChanged
        ucrBase.clsRsyntax.AddParameter("form_name", Chr(34) & ucrInputChooseForm.GetText & Chr(34))
        TestOKEnabled()
    End Sub

    Private Sub cmdFindForms_click(sender As Object, e As EventArgs) Handles cmdFindForms.Click

        'Dim frmnames As String
        'Dim strrcommand As String
        'strrcommand = ucrBase.clsRsyntax.clsBaseFunction.ToScript()
        'frmnames = frmMain.clsRLink.RunInternalScriptGetValue(strrcommand, bSilent:=True).ToString
        'ucrInputChooseForm.cboInput.Text = frmnames
    End Sub
    Private Sub enambleCommandButton()
        If ((ucrInputPassword.IsEmpty = False) AndAlso (ucrInputUsername.IsEmpty = False)) Then
            cmdFindForms.Enabled = True
        Else
            cmdFindForms.Enabled = False
        End If
    End Sub

End Class