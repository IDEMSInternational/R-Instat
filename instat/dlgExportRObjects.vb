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
Imports System.IO
Imports instat.Translations
Public Class dlgExportRObjects
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsGetObjectsFunction, clsSaveRDS As New RFunction

    Private Sub dlgExportRObjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 538

        ucrSelectorObjects.SetParameter(New RParameter("data_name", 1))
        ucrSelectorObjects.ucrAvailableDataFrames.SetParameterIsString()

        ucrReceiverObjects.SetParameter(New RParameter("object_name", 2))
        ucrReceiverObjects.SetParameterIsString()
        ucrReceiverObjects.Selector = ucrSelectorObjects
        ucrReceiverObjects.SetMeAsReceiver()
        ucrReceiverObjects.strSelectorHeading = "Objects"
        ucrReceiverObjects.SetItemType("object")

        ucrInputExportFile.SetParameter(New RParameter("file", 0))
        ucrInputExportFile.IsReadOnly = True
    End Sub

    Private Sub SetDefaults()
        clsGetObjectsFunction = New RFunction
        clsSaveRDS = New RFunction

        ucrInputExportFile.SetName("")
        ucrSelectorObjects.Reset()
        clsGetObjectsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_objects")
        clsSaveRDS.SetRCommand("saveRDS")
        clsSaveRDS.AddParameter("object", clsRFunctionParameter:=clsGetObjectsFunction)
        ucrBase.clsRsyntax.SetBaseRFunction(clsSaveRDS)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorObjects.SetRCode(clsGetObjectsFunction, bReset)
        ucrReceiverObjects.SetRCode(clsGetObjectsFunction, bReset)
        ucrInputExportFile.SetRCode(clsSaveRDS, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrInputExportFile.IsEmpty AndAlso Not ucrReceiverObjects.IsEmpty AndAlso ucrSelectorObjects.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        Dim dlgSave As New SaveFileDialog

        dlgSave.Title = "Export R Objects"
        dlgSave.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
        dlgSave.Filter = "Serialized R Objects (*.rds)|*.rds"
        If dlgSave.ShowDialog = DialogResult.OK Then
            If dlgSave.FileName <> "" Then
                ucrInputExportFile.SetName(Path.GetFullPath(dlgSave.FileName).ToString.Replace("\", "/"))
            End If
        End If
    End Sub

    Private Sub ucrInputExportFile_Click(sender As Object, e As EventArgs) Handles ucrInputExportFile.Click
        cmdBrowse_Click(sender, e)
    End Sub

    Private Sub ucrInputExportFile_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrReceiverObjects.ControlContentsChanged, ucrSelectorObjects.ControlContentsChanged, ucrInputExportFile.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class