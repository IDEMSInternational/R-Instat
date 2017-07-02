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
Imports RDotNet
Public Class dlgImportFromODK
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsGetFormsFunction, clsDefaultRFunction As New RFunction

    Private Sub dlgImportFromODK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
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
    End Sub

    Private Sub SetDefaults()
        clsDefaultRFunction = New RFunction
        clsGetFormsFunction = New RFunction

        ucrInputChooseForm.bAllowNonConditionValues = True
        ucrInputChooseForm.SetName("")
        ucrInputUsername.SetName("")

        clsDefaultRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_from_ODK")
        clsDefaultRFunction.AddParameter("platform", Chr(34) & "kobo" & Chr(34))
        clsGetFormsFunction.SetRCommand("get_odk_form_names")
        clsGetFormsFunction.AddParameter("platform", Chr(34) & "kobo" & Chr(34))
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrInputChooseForm.IsEmpty AndAlso Not ucrInputUsername.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub pnlPlatform_ControlContentsChanged() Handles ucrPnlPlatform.ControlValueChanged
        If rdoOna.Checked Then
            clsGetFormsFunction.AddParameter("platform", Chr(34) & "ona" & Chr(34))
            ucrInputChooseForm.cboInput.Items.Clear()
            ucrInputChooseForm.SetText("")
        ElseIf rdoKobo.Checked Then
            clsGetFormsFunction.AddParameter("platform", Chr(34) & "kobo" & Chr(34))
            ucrInputChooseForm.cboInput.Items.Clear()
            ucrInputChooseForm.SetText("")
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

    Private Sub ucrInputUsername_ContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputUsername.ControlContentsChanged
        If ucrInputUsername.IsEmpty() Then
            cmdFindForms.Enabled = False
        Else
            cmdFindForms.Enabled = True
        End If
        ucrInputChooseForm.cboInput.Items.Clear()
        ucrInputChooseForm.SetText("")
        TestOKEnabled()
    End Sub

    Private Sub ucrInputChooseForm_ContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputChooseForm.ControlContentsChanged, ucrInputUsername.ControlContentsChanged ', ucrInputPassword.ControlContentsChanged 
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
End Class