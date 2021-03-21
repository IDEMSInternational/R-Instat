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
Public Class dlgExportRWorkspace
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultFunction As New RFunction
    Private Sub dlgExportRWorkspace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 555

        ucrReceiverMultiple.SetParameter(New RParameter("data_names", 0))
        ucrReceiverMultiple.SetParameterIsString()
        ucrReceiverMultiple.Selector = ucrSelectorForDataFrames
        ucrReceiverMultiple.strSelectorHeading = "Data Frames"
        ucrReceiverMultiple.SetItemType("dataframe")

        ucrFilePath.SetPathControlParameter(New RParameter("file", 1))

        ucrChkMetadata.SetParameter(New RParameter("include_metadata", 2))
        ucrChkMetadata.SetText("Include Metadata")
        ucrChkMetadata.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMetadata.SetRDefault("TRUE")

        ucrChkGraphs.SetParameter(New RParameter("include_graphs", 3))
        ucrChkGraphs.SetText("Include Graphs")
        ucrChkGraphs.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkGraphs.SetRDefault("TRUE")

        ucrChkModels.SetParameter(New RParameter("include_models", 4))
        ucrChkModels.SetText("Include Models")
        ucrChkModels.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkModels.SetRDefault("TRUE")
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction

        ucrFilePath.ResetPathControl()
        ucrSelectorForDataFrames.Reset()
        ucrReceiverMultiple.SetMeAsReceiver()

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$export_workspace")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        'ucrSelectorForDataFrames.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)  'todo. check if needed
        ucrReceiverMultiple.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkMetadata.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkGraphs.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkModels.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrFilePath.SetPathControlRcode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        ucrBase.OKEnabled(Not ucrFilePath.IsEmpty AndAlso Not ucrReceiverMultiple.IsEmpty)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrInputExportFile_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrReceiverMultiple.ControlContentsChanged
        'ucrReceiverMultiple is a multireceiver. So give a default suggested name if it has 1 item only
        ucrFilePath.DefaultFileSuggestionName = If(ucrReceiverMultiple.GetVariableNamesList().Length = 1, ucrReceiverMultiple.GetVariableNames(bWithQuotes:=False), "")
        TestOkEnabled()
    End Sub

    Private Sub ucrFilePath_FilePathChanged() Handles ucrFilePath.FilePathChanged
        TestOkEnabled()
    End Sub
End Class
