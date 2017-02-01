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
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 468
        clsGetFormsFunction.SetRCommand("get_odk_form_names")


        ucrPnlPlatform.SetParameter(New RParameter("platform"))
        ucrPnlPlatform.AddRadioButton(rdoKobo, Chr(34) & "kobo" & Chr(34))
        ucrPnlPlatform.AddRadioButton(rdoOna, Chr(34) & "ona" & Chr(34))
        ucrPnlPlatform.SetRDefault(Chr(34) & "kobo" & Chr(34))

        ucrInputChooseForm.SetParameter(New RParameter("form_name"))
        ucrInputUsername.SetParameter(New RParameter("username"))
        ucrInputPassword.SetParameter(New RParameter("password"))
        ucrChkViewPassword.SetText("View Password")

    End Sub

    Private Sub TestOKEnabled()
        If Not ucrInputChooseForm.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultRFunction As New RFunction

        ucrInputUsername.SetName("")
        ucrInputPassword.SetName("")
        ucrInputChooseForm.Reset()
        EnableCommandButton()
        ucrInputPassword.txtInput.UseSystemPasswordChar = True

        clsDefaultRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_from_ODK")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction.Clone())
        TestOKEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrInputUsername_NameChanged() Handles ucrInputUsername.NameChanged
        'If ucrInputUsername.IsEmpty() Then
        '    ucrBase.clsRsyntax.RemoveParameter("username")
        '    clsGetFormsFunction.RemoveParameterByName("username")
        'Else
        '    ucrBase.clsRsyntax.AddParameter("username", Chr(34) & ucrInputUsername.GetText & Chr(34))
        '    clsGetFormsFunction.AddParameter("username", Chr(34) & ucrInputUsername.GetText & Chr(34))
        'End If
        'TestOKEnabled()
    End Sub
    Private Sub AllControls_ContentsChnaged() Handles ucrChkViewPassword.ControlContentsChanged, ucrInputChooseForm.ControlContentsChanged, ucrInputPassword.ControlContentsChanged, ucrPnlPlatform.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrInputPassword_NameChanged() Handles ucrInputPassword.ControlContentsChanged
        useSystemePassword()
        'If ucrInputPassword.IsEmpty() Then
        '    ucrBase.clsRsyntax.RemoveParameter("password")
        '    clsGetFormsFunction.RemoveParameterByName("password")
        'Else
        '    ucrBase.clsRsyntax.AddParameter("password", Chr(34) & ucrInputPassword.GetText & Chr(34))
        '    clsGetFormsFunction.AddParameter("password", Chr(34) & ucrInputPassword.GetText & Chr(34))
        'End If

    End Sub

    Private Sub ucrInputChooseForm_NameChanged() Handles ucrInputChooseForm.ControlContentsChanged
        'If ucrInputChooseForm.IsEmpty() Then
        '    ucrBase.clsRsyntax.RemoveParameter("form_name")
        'Else
        '    ucrBase.clsRsyntax.AddParameter("form_name", Chr(34) & ucrInputChooseForm.GetText & Chr(34))
        'End If
        'TestOKEnabled()
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

    Private Sub UsernamePassword_ContentsChanged() Handles ucrInputUsername.ContentsChanged, ucrInputPassword.ContentsChanged
        ucrInputChooseForm.cboInput.Items.Clear()
        ucrInputChooseForm.SetName("")
        EnableCommandButton()
    End Sub

    Private Sub chkViewPassword_CheckedChanged() Handles ucrChkViewPassword.ControlContentsChanged
        useSystemePassword()
    End Sub

    Private Sub useSystemePassword()
        If ucrChkViewPassword.Checked Then
            ucrInputPassword.txtInput.UseSystemPasswordChar = False
        Else
            ucrInputPassword.txtInput.UseSystemPasswordChar = True
        End If
    End Sub
End Class