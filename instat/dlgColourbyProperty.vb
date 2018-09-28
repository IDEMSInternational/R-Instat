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
Public Class dlgColourbyProperty
    Public bFirstLoad As Boolean = True
    Private clsColourByMetadata As New RFunction
    Private clsRemoveColour As New RFunction
    Private bReset As Boolean = True

    Private Sub dlgColourbyProperty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 391

        ucrSelectorColourByMetadata.SetParameter(New RParameter("data_name", 0))
        ucrSelectorColourByMetadata.SetParameterIsString()

        ucrReceiverMetadataProperty.SetParameter(New RParameter("property", 1))
        ucrReceiverMetadataProperty.SetParameterIsString()
        ucrReceiverMetadataProperty.Selector = ucrSelectorColourByMetadata
        ucrReceiverMetadataProperty.SetMeAsReceiver()
        ucrReceiverMetadataProperty.SetItemType("metadata")
        ucrReceiverMetadataProperty.strSelectorHeading = "Metadata Property"

        ucrChkRemoveColours.SetText("Remove Colour")
        ucrChkRemoveColours.AddFunctionNamesCondition(True, frmMain.clsRLink.strInstatDataObject & "$remove_column_colours")
        ucrChkRemoveColours.AddFunctionNamesCondition(False, frmMain.clsRLink.strInstatDataObject & "$set_column_colours_by_metadata")
    End Sub

    Private Sub SetDefaults()
        clsColourByMetadata = New RFunction
        clsRemoveColour = New RFunction

        ucrSelectorColourByMetadata.Reset()

        clsColourByMetadata.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_column_colours_by_metadata")
        clsRemoveColour.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_column_colours")

        ucrBase.clsRsyntax.SetBaseRFunction(clsColourByMetadata)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorColourByMetadata.AddAdditionalCodeParameterPair(clsRemoveColour, ucrSelectorColourByMetadata.GetParameter(), iAdditionalPairNo:=1)
        ucrSelectorColourByMetadata.SetRCode(clsColourByMetadata, bReset)
        ucrReceiverMetadataProperty.SetRCode(clsColourByMetadata, bReset)
        ucrChkRemoveColours.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverMetadataProperty.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrChkRemoveColours_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRemoveColours.ControlValueChanged
        If ucrChkRemoveColours.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsRemoveColour)
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsColourByMetadata)
        End If
    End Sub

    Private Sub Controls_ControContententsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorColourByMetadata.ControlContentsChanged, ucrReceiverMetadataProperty.ControlContentsChanged, ucrChkRemoveColours.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class