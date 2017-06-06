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
Public Class dlgColumnStructure
    Private bReset As Boolean = True
    Private clsColourByMetadata, clsColumnStructure, clsUncolourByMetadata As New RFunction
    'clsCourByStructure is here to construct the R-command that will colour columns according to their type in case it is required (see relevant tick box).
    Private bFirstLoad As Boolean = True
    Private Sub ucrSelectorColumnStructures_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        SetColumnStructureInReceiver()
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 51

        ucrSelectorColumnStructure.SetParameter(New RParameter("data_name", 0))
        ucrSelectorColumnStructure.SetParameterIsString()

        ucrReceiverLayout.SetParameter(New RParameter("struc_type_1", 1))
        ucrReceiverLayout.SetParameterIsString()
        ucrReceiverLayout.Selector = ucrSelectorColumnStructure
        ucrReceiverLayout.bExcludeFromSelector = True

        ucrReceiverTreatment.SetParameter(New RParameter("struc_type_2", 2))
        ucrReceiverTreatment.SetParameterIsString()
        ucrReceiverTreatment.Selector = ucrSelectorColumnStructure
        ucrReceiverTreatment.bExcludeFromSelector = True

        ucrReceiverMeasurement.SetParameter(New RParameter("struc_type_3", 3))
        ucrReceiverMeasurement.SetParameterIsString()
        ucrReceiverMeasurement.Selector = ucrSelectorColumnStructure
        ucrReceiverMeasurement.bExcludeFromSelector = True

        ucrChkColourColumnsByStructure.SetText("Colour Columns by Structure")
        ucrChkColourColumnsByStructure.AddFunctionNamesCondition(True, frmMain.clsRLink.strInstatDataObject & "$set_column_colours_by_metadata")
        ucrChkColourColumnsByStructure.AddFunctionNamesCondition(False, frmMain.clsRLink.strInstatDataObject & "$remove_column_colours")
        ucrChkColourColumnsByStructure.AddFunctionNamesCondition(True, frmMain.clsRLink.strInstatDataObject & "$remove_column_colours")
    End Sub

    Private Sub SetDefaults()
        clsColourByMetadata = New RFunction
        clsColumnStructure = New RFunction
        clsUncolourByMetadata = New RFunction

        ucrSelectorColumnStructure.Reset()
        SetColumnStructureInReceiver()
        ucrReceiverLayout.SetMeAsReceiver()

        clsColumnStructure.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_structure_columns")

        clsColourByMetadata.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_column_colours_by_metadata")
        clsColourByMetadata.AddParameter("property", Chr(34) & "Structure" & Chr(34))

        clsUncolourByMetadata.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_column_colours")

        ucrBase.clsRsyntax.SetBaseRFunction(clsColumnStructure)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorColumnStructure.AddAdditionalCodeParameterPair(clsColourByMetadata, ucrSelectorColumnStructure.GetParameter(), iAdditionalPairNo:=1)
        ucrSelectorColumnStructure.AddAdditionalCodeParameterPair(clsUncolourByMetadata, ucrSelectorColumnStructure.GetParameter(), iAdditionalPairNo:=2)

        ucrSelectorColumnStructure.SetRCode(clsColumnStructure, bReset)
        ucrReceiverLayout.SetRCode(clsColumnStructure, bReset)
        ucrReceiverTreatment.SetRCode(clsColumnStructure, bReset)
        ucrReceiverMeasurement.SetRCode(clsColumnStructure, bReset)
        ucrChkColourColumnsByStructure.SetRCode(clsUncolourByMetadata, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrSelectorColumnStructure.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
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

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        If ucrChkColourColumnsByStructure.Checked Then
            frmMain.clsRLink.RunScript(clsColourByMetadata.ToScript)
        Else
            frmMain.clsRLink.RunScript(clsUncolourByMetadata.ToScript)
        End If
    End Sub

    Private Sub SetColumnStructureInReceiver()
        If ucrSelectorColumnStructure.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrReceiverLayout.AddItemsWithMetadataProperty(ucrSelectorColumnStructure.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Structure", {"structure_type_1_label"})
            ucrReceiverTreatment.AddItemsWithMetadataProperty(ucrSelectorColumnStructure.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Structure", {"structure_type_2_label"})
            ucrReceiverMeasurement.AddItemsWithMetadataProperty(ucrSelectorColumnStructure.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Structure", {"structure_type_3_label"})
            ucrReceiverLayout.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrSelectorColumnStructure_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorColumnStructure.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class