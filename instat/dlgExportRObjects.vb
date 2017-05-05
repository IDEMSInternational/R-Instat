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

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub InitialiseDialog()

        ucrBase.iHelpTopicID = 538

        ucrReceiverObjects.Selector = ucrSelectorObjects
        ucrSelectorObjects.SetParameter(New RParameter("data_name", 0))
        ucrSelectorObjects.ucrAvailableDataFrames.SetParameterIsString()
        ucrSelectorObjects.SetItemType("object")

        ucrReceiverObjects.SetParameter(New RParameter("object_names", 1))
        ucrReceiverObjects.SetParameterIsString()
        ucrInputExportFile.SetParameter(New RParameter("file", 2))

    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction

        ucrInputExportFile.IsReadOnly = True
        ucrInputExportFile.SetName("")
        ucrReceiverObjects.SetMeAsReceiver()
        ucrSelectorObjects.Reset()
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$export_objects")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        Dim dlgSave As New SaveFileDialog

        dlgSave.Title = "Export file dialog"
        dlgSave.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
        dlgSave.Filter = "Saved r objects (*.RData)|*.RData"
        If dlgSave.ShowDialog = DialogResult.OK Then
            If dlgSave.FileName <> "" Then
                ucrInputExportFile.SetName(Path.GetFullPath(dlgSave.FileName).ToString.Replace("\", "/"))
            End If
        End If
    End Sub

    Private Sub ucrInputExportFile_Click(sender As Object, e As EventArgs) Handles ucrInputExportFile.Click
        cmdBrowse_Click(sender, e)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrInputExportFile.IsEmpty AndAlso Not ucrReceiverObjects.IsEmpty AndAlso ucrSelectorObjects.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrInputExportFile_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrInputExportFile.ControlContentsChanged, ucrReceiverObjects.ControlContentsChanged, ucrSelectorObjects.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

End Class