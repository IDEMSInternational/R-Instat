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
    Private bReset As Boolean = True
    Private clsGetFormsFunction As New RFunction

    Private Sub dlgImportFromODK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If

        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 468

        ucrPnlPlatform.SetParameter(New RParameter("platform", 0))
        ucrPnlPlatform.AddRadioButton(rdoKobo, Chr(34) & "kobo" & Chr(34))
        ucrPnlPlatform.AddRadioButton(rdoOna, Chr(34) & "ona" & Chr(34))

        ucrInputChooseForm.SetParameter(New RParameter("form_name", 3))
        ucrInputChooseForm.bAllowNonConditionValues = True
        ucrInputUsername.SetParameter(New RParameter("username", 1))
        ucrInputPassword.SetParameter(New RParameter("password", 2))

        ucrChkViewPassword.SetText("View Password")
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrInputChooseForm.IsEmpty AndAlso Not ucrInputPassword.IsEmpty AndAlso Not ucrInputUsername.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultRFunction As New RFunction

        ucrInputChooseForm.Reset()
        ucrInputPassword.Reset()
        ucrInputUsername.Reset()

        ucrInputUsername.SetName("")
        ucrInputPassword.SetName("")
        ucrInputChooseForm.SetName("")

        ucrChkViewPassword.Checked = False
        ucrInputPassword.txtInput.UseSystemPasswordChar = True

        clsDefaultRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_from_ODK")
        clsDefaultRFunction.AddParameter("platform", Chr(34) & "kobo" & Chr(34))

        clsGetFormsFunction.SetRCommand("get_odk_form_names")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction.Clone())
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
    End Sub

    Private Sub pnlPlatform_ControlContentsChanged() Handles ucrPnlPlatform.ControlValueChanged
        If rdoOna.Checked Then
            clsGetFormsFunction.AddParameter("platform", Chr(34) & "ona" & Chr(34))
        ElseIf rdoKobo.Checked Then
            clsGetFormsFunction.AddParameter("platform", Chr(34) & "kobo" & Chr(34))
        End If
    End Sub
    Private Sub ucrInputUsername_NameChanged() Handles ucrInputUsername.ControlValueChanged
        If ucrInputUsername.IsEmpty() Then
            clsGetFormsFunction.RemoveParameterByName("username")
        Else
            clsGetFormsFunction.AddParameter("username", Chr(34) & ucrInputUsername.GetText & Chr(34))
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrInputPassword_NameChanged() Handles ucrInputPassword.ControlValueChanged
        UseSystemPassword()
        If ucrInputPassword.IsEmpty() Then
            clsGetFormsFunction.RemoveParameterByName("password")
        Else
            clsGetFormsFunction.AddParameter("password", Chr(34) & ucrInputPassword.GetText & Chr(34))
        End If
    End Sub

    Private Sub AllControls_ContentsChnaged() Handles ucrInputChooseForm.ControlContentsChanged, ucrInputPassword.ControlContentsChanged, ucrInputUsername.ControlContentsChanged
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

    Private Sub UsernamePassword_ContentsChanged() Handles ucrInputUsername.ControlContentsChanged, ucrInputPassword.ControlContentsChanged
        If Not ucrInputPassword.IsEmpty AndAlso Not ucrInputUsername.IsEmpty Then
            cmdFindForms.Enabled = True
        Else
            cmdFindForms.Enabled = False
        End If
    End Sub

    Private Sub chkViewPassword_CheckedChanged() Handles ucrChkViewPassword.ControlContentsChanged
        UseSystemPassword()
    End Sub

    Private Sub UseSystemPassword()
        If ucrChkViewPassword.Checked Then
            ucrInputPassword.txtInput.UseSystemPasswordChar = False
        Else
            ucrInputPassword.txtInput.UseSystemPasswordChar = True
        End If
    End Sub
End Class