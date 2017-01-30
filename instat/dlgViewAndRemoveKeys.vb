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
    Public bFirstLoad As Boolean = True
    Private clsDefaultFunction As New RFunction
    Private Sub dlgViewAndRemoveKeys_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()

        ucrBase.iHelpTopicID = 505

        'Setting Receiver
        ucrReceiverSelectedKey.Selector = ucrSelectorKeys
        ucrReceiverSelectedKey.SetMeAsReceiver()
        ucrReceiverSelectedKey.SetItemType("key")
        ucrReceiverSelectedKey.SetParameter(New RParameter("key_name", 1))
        ucrReceiverSelectedKey.SetParameterIsString()

        ucrSelectorKeys.SetParameter(New RParameter("data_name", 0))
        ucrSelectorKeys.SetParameterIsString()

        ucrRemoveKey.SetText("Remove Key")
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_key")

    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverSelectedKey.IsEmpty AndAlso ucrRemoveKey.Checked Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        ' Set default RFunction as the base function
        ucrRemoveKey.Checked = False
        ucrSelectorKeys.Reset()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
        TestOKEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorKeys.ControlContentsChanged, ucrReceiverSelectedKey.ControlContentsChanged, ucrRemoveKey.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
End Class