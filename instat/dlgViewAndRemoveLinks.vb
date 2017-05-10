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
Public Class dlgViewAndRemoveLinks
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsVewLinks As New RFunction
    Private clsDeleteLinks As New RFunction

    Private Sub dlgViewAndRemoveLinks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverViewLinks.AddAdditionalCodeParameterPair(clsDeleteLinks, New RParameter("link_name", 0), iAdditionalPairNo:=1)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 507
        ucrReceiverViewLinks.Selector = ucrSelectorLinks
        ucrReceiverViewLinks.SetMeAsReceiver()
        ucrReceiverViewLinks.SetParameter(New RParameter("link_name", 0))
        ucrReceiverViewLinks.SetParameterIsString()
        ucrSelectorLinks.SetItemType("link")
        ucrpnlDeleteView.AddRadioButton(rdoDeleteLink)
        ucrpnlDeleteView.AddRadioButton(rdoViewLink)
        ucrpnlDeleteView.AddFunctionNamesCondition(rdoDeleteLink, frmMain.clsRLink.strInstatDataObject & "$remove_link")
        ucrpnlDeleteView.AddFunctionNamesCondition(rdoViewLink, frmMain.clsRLink.strInstatDataObject & "$view_link")

    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverViewLinks.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        clsDeleteLinks = New RFunction
        clsVewLinks = New RFunction
        clsDeleteLinks.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_link")
        clsVewLinks.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$view_link")
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.SetBaseRFunction(clsVewLinks)
    End Sub

    Private Sub ucrpnlDeleteView_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrpnlDeleteView.ControlValueChanged
        If rdoDeleteLink.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsDeleteLinks)
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsVewLinks)
        End If
    End Sub

    Private Sub ucrReceiverViewLinks_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverViewLinks.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class