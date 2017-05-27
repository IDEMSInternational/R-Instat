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
Public Class dlgViewAndRemoveKeys
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsGetKey As New RFunction
    Private clsRemoveKey As New RFunction
    Private Sub dlgViewAndRemoveKeys_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.iHelpTopicID = 505

        'Selector
        ucrSelectorKeys.SetParameter(New RParameter("data_name", 0))
        ucrSelectorKeys.SetParameterIsString()

        'Receiver
        ucrReceiverSelectedKey.SetParameter(New RParameter("key_name", 1))
        ucrReceiverSelectedKey.SetParameterIsString()
        ucrReceiverSelectedKey.Selector = ucrSelectorKeys
        ucrReceiverSelectedKey.SetMeAsReceiver()
        ucrReceiverSelectedKey.SetItemType("key")
        ucrReceiverSelectedKey.strSelectorHeading = "Keys"

        ucrPnlKeys.AddRadioButton(rdoViewKey)
        ucrPnlKeys.AddRadioButton(rdoDeleteKey)
        ucrPnlKeys.AddFunctionNamesCondition(rdoViewKey, frmMain.clsRLink.strInstatDataObject & "$get_keys")
        ucrPnlKeys.AddFunctionNamesCondition(rdoDeleteKey, frmMain.clsRLink.strInstatDataObject & "$remove_key")
    End Sub

    Private Sub SetDefaults()
        clsGetKey = New RFunction
        clsRemoveKey = New RFunction

        ucrSelectorKeys.Reset()

        clsGetKey.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_keys")
        clsRemoveKey.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_key")

        ucrBase.clsRsyntax.SetBaseRFunction(clsGetKey)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverSelectedKey.AddAdditionalCodeParameterPair(clsRemoveKey, New RParameter("key_name", 1), iAdditionalPairNo:=1)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverSelectedKey.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog() 'Temporary fixes remove key error on reopen of the dialog
        ucrSelectorKeys.Reset()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlKeys_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlKeys.ControlValueChanged
        If rdoDeleteKey.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsRemoveKey)
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsGetKey)
        End If
        SetRCodeForControls(False)
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelectedKey.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class