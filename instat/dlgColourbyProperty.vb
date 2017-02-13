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
Public Class dlgColourbyProperty
    Public bFirstLoad As Boolean = True
    Public clsDefaultFuncAdd As New RFunction
    Public clsDefaultRemove

    Private Sub dlgColourbyProperty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            TestOKEnabled()
            bFirstLoad = False
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 391

        ucrReceiverMetadataProperty.Selector = ucrSelectorColourByMetadata
        ucrReceiverMetadataProperty.SetItemType("metadata")
        ucrReceiverMetadataProperty.SetMeAsReceiver()

        ucrchkRemoveColours.SetText("Remove Colour(s)")

        ucrReceiverMetadataProperty.SetParameter(New RParameter("property"))
        ucrReceiverMetadataProperty.SetParameterIsString()

        ucrSelectorColourByMetadata.SetParameter(New RParameter("data_name"))
        ucrSelectorColourByMetadata.SetParameterIsString()

        clsDefaultFuncAdd.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_column_colours_by_metadata")
        'ucrchkRemoveColours.SetParameter(frmMain.clsRLink.strInstatDataObject & "$remove_column_colours")
    End Sub

    Private Sub SetDefaults()
        '  SetOrRemoveColours()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFuncAdd.Clone())
        ucrSelectorColourByMetadata.Reset()
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
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
        TestOKEnabled()
    End Sub

    Private Sub Controls_ControContententsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorColourByMetadata.ControlContentsChanged, ucrReceiverMetadataProperty.ControlContentsChanged, ucrchkRemoveColours.ControlContentsChanged
        TestOKEnabled()
    End Sub

    'Private Sub SetOrRemoveColours()
    '    If ucrchkRemoveColours.Checked Then
    '        ucrSelectorColourByMetadata.Reset()
    '        ucrSelectorColourByMetadata.SetCurrentReceiver(Nothing)
    '        ucrReceiverMetadataProperty.Enabled = False
    '        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFuncAdd)
    '    Else
    '        ucrReceiverMetadataProperty.Enabled = True
    '    End If
    '    TestOKEnabled()
    'End Sub

End Class