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
Imports RDotNet

Public Class dlgImportFromODK
    Public bFirstLoad As Boolean = True
    Private clsGetFormsFunction As New RFunction

    Private Sub dlgImportFromODK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 468
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$import_from_ODK")
        clsGetFormsFunction.SetRCommand("get_odk_form_names")
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrInputChooseForm.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        rdoKobo.Checked = True
        ucrInputUsername.SetName("")
        ucrInputPassword.SetName("")
        ucrInputChooseForm.Reset()
        chkViewPassword.Checked = False
        EnableCommandButton()
        ucrInputPassword.txtInput.UseSystemPasswordChar = True
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub rdoKobo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoKobo.CheckedChanged, rdoOna.CheckedChanged
        If rdoOna.Checked Then
            ucrBase.clsRsyntax.AddParameter("platform", Chr(34) & "ona" & Chr(34))
            clsGetFormsFunction.AddParameter("platform", Chr(34) & "ona" & Chr(34))
        ElseIf rdoKobo.Checked Then
            ucrBase.clsRsyntax.AddParameter("platform", Chr(34) & "kobo" & Chr(34))
            clsGetFormsFunction.AddParameter("platform", Chr(34) & "kobo" & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter("platform")
            clsGetFormsFunction.RemoveParameterByName("platform")
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrInputUsername_NameChanged() Handles ucrInputUsername.NameChanged
        If ucrInputUsername.IsEmpty() Then
            ucrBase.clsRsyntax.RemoveParameter("username")
            clsGetFormsFunction.RemoveParameterByName("username")
        Else
            ucrBase.clsRsyntax.AddParameter("username", Chr(34) & ucrInputUsername.GetText & Chr(34))
            clsGetFormsFunction.AddParameter("username", Chr(34) & ucrInputUsername.GetText & Chr(34))
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrInputPassword_NameChanged()
        useSystemePassword()
        If ucrInputPassword.IsEmpty() Then
            ucrBase.clsRsyntax.RemoveParameter("password")
            clsGetFormsFunction.RemoveParameterByName("password")
        Else
            ucrBase.clsRsyntax.AddParameter("password", Chr(34) & ucrInputPassword.GetText & Chr(34))
            clsGetFormsFunction.AddParameter("password", Chr(34) & ucrInputPassword.GetText & Chr(34))
        End If

        TestOKEnabled()
    End Sub

    Private Sub ucrInputChooseForm_NameChanged() Handles ucrInputChooseForm.NameChanged
        If ucrInputChooseForm.IsEmpty() Then
            ucrBase.clsRsyntax.RemoveParameter("form_name")
        Else
            ucrBase.clsRsyntax.AddParameter("form_name", Chr(34) & ucrInputChooseForm.GetText & Chr(34))
        End If
        TestOKEnabled()
    End Sub

    Private Sub cmdFindForms_click(sender As Object, e As EventArgs) Handles cmdFindForms.Click
        Dim strFormNames() As String
        Dim expTemp As SymbolicExpression

        Cursor = Cursors.WaitCursor
        expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsGetFormsFunction.ToScript())
        Cursor = Cursors.Default
        If expTemp IsNot Nothing Then
            strFormNames = expTemp.AsCharacter().ToArray()
            If strFormNames.Length > 0 Then
                ucrInputChooseForm.SetItems(strFormNames)
                ucrInputChooseForm.SetName(ucrInputChooseForm.cboInput.Items(0))
            Else
                ucrInputChooseForm.cboInput.Items.Clear()
            End If
        Else
            ucrInputChooseForm.cboInput.Items.Clear()
        End If
    End Sub

    Private Sub EnableCommandButton()
        If Not ucrInputPassword.IsEmpty AndAlso Not ucrInputUsername.IsEmpty Then
            cmdFindForms.Enabled = True
        Else
            cmdFindForms.Enabled = False
        End If
    End Sub

    Private Sub UsernamePassword_ContentsChanged() Handles ucrInputUsername.ContentsChanged
        ucrInputChooseForm.cboInput.Items.Clear()
        ucrInputChooseForm.SetName("")
        EnableCommandButton()
    End Sub

    Private Sub chkViewPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkViewPassword.CheckedChanged
        useSystemePassword()
    End Sub

    Private Sub useSystemePassword()
        If chkViewPassword.Checked Then
            ucrInputPassword.txtInput.UseSystemPasswordChar = False
        Else
            ucrInputPassword.txtInput.UseSystemPasswordChar = True
        End If
    End Sub
End Class