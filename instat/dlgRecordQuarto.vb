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

'Imports System.IO
Imports instat.Translations

Public Class dlgRecordQuarto
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsSaveRDSFunction As New RFunction
    Public clsRLink As RLink

    Private Sub dlgRecordQuarto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            Initializedialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
        SetSaveWorkspaceControlsVisibility()

        autoTranslate(Me)
    End Sub

    Private Sub Initializedialog()
        ucrInputFileLocation.SetParameter(New RParameter("file", 1))
        ucrInputFileLocation.IsReadOnly = True
        ucrInputFileLocation.SetLinkedDisplayControl(lblFileLocation)

        ucrInputFilePath.SetParameter(New RParameter("file", 0))
        ucrInputFilePath.IsReadOnly = True

        ucrChkRenderDetails.SetText("Show Rendering Details")

        ucrChkHtml.SetText("HTML")
        ucrChkDocs.SetText("Document")
        ucrChkPdf.SetText("Pdf")
        ucrChkPptx.SetText("Powerpoint")

        ucrChkSaveReopen.SetText("Save and Reopen Workspace")

    End Sub

    Private Sub SetDefaults()
        clsSaveRDSFunction = New RFunction


        clsSaveRDSFunction.SetRCommand("saveRDS")

        clsSaveRDSFunction.AddParameter("object",
                                        frmMain.clsRLink.strInstatDataObject,
                                        iPosition:=0)

        ucrChkRenderDetails.Checked = False
        ucrChkHtml.Checked = True
        ucrChkPdf.Checked = True
        ucrChkPptx.Checked = True
        ucrChkDocs.Checked = True
    End Sub


    Private Sub SelectQuartoFileToSave()

        Using dlgSave As New SaveFileDialog

            dlgSave.Title = "Save Quarto File"

            dlgSave.Filter = "Quarto File (*.qmd)|*.qmd"

            If ucrInputFileLocation.GetText() <> "" Then
                dlgSave.InitialDirectory =
                    IO.Path.GetDirectoryName(
                        ucrInputFileLocation.GetText().Replace("/", "\"))
            Else
                dlgSave.InitialDirectory =
                    frmMain.clsInstatOptions.strWorkingDirectory
            End If

            If dlgSave.ShowDialog() = DialogResult.OK Then
                ucrInputFileLocation.SetName(
                    dlgSave.FileName.Replace("\", "/"))
            End If

            TestOkEnabled()

        End Using

    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        SelectQuartoFileToSave()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputFileLocation.SetRCode(clsSaveRDSFunction, bReset)
        ucrInputFilePath.SetRCode(clsSaveRDSFunction, bReset)
    End Sub

    Private Sub SaveDataBook()

        Dim strRdsFile As String = ucrInputFilePath.GetText

        If String.IsNullOrWhiteSpace(strRdsFile) Then
            Exit Sub
        End If

        clsSaveRDSFunction.AddParameter(
        "file",
        Chr(34) & strRdsFile.Replace("\", "/") & Chr(34),
        iPosition:=1)

        frmMain.clsRLink.RunScript(clsSaveRDSFunction.ToScript())
    End Sub

    Private Sub SaveQuartoFile()

        Dim strQmdFile As String = ucrInputFileLocation.GetText()

        If strQmdFile = "" Then
            Exit Sub
        End If

        Dim strTemplate As String =
    "---" & vbCrLf &
    "title: ""R-Instat Analysis""" & vbCrLf &
    "format:" & vbCrLf &
    "  html: default" & vbCrLf &
    "editor: visual" & vbCrLf &
    "---" & vbCrLf & vbCrLf

        IO.File.WriteAllText(strQmdFile.Replace("/", "\"), strTemplate)

    End Sub

    Private Sub TestOkEnabled()
        Dim bEnable As Boolean = Not ucrInputFileLocation.IsEmpty

        If ucrChkSaveReopen.Checked Then
            bEnable = bEnable AndAlso Not String.IsNullOrWhiteSpace(ucrInputFilePath.GetText())
        End If

        bEnable = bEnable AndAlso
              (ucrChkHtml.Checked OrElse
               ucrChkPdf.Checked OrElse
               ucrChkPptx.Checked OrElse
               ucrChkDocs.Checked)

        ucrBase.OKEnabled(bEnable)
    End Sub

    Private Function IsValid() As Boolean

        If String.IsNullOrWhiteSpace(ucrInputFileLocation.GetText()) Then
            Return False
        End If

        If Not ucrChkHtml.Checked AndAlso
       Not ucrChkPdf.Checked AndAlso
       Not ucrChkPptx.Checked AndAlso
       Not ucrChkDocs.Checked Then

            MsgBox("Please select at least one output format.")
            Return False
        End If

        Return True

    End Function

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk

        If Not IsValid() Then
            MsgBox("Please select a Quarto file location.")
            Exit Sub
        End If

        If MessageBox.Show(
            "This will close the current session and start a new Quarto recording session." &
            Environment.NewLine &
            Environment.NewLine &
            "Would you like to proceed?",
            "Record Quarto",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) = DialogResult.No Then

            Exit Sub

        End If

        SaveQuartoFile()
        Dim strRdsFile As String = ucrInputFilePath.GetText

        If ucrChkSaveReopen.Checked Then

            SaveDataBook()
            StartQuartoSession(strRdsFile)

        Else

            StartEmptyQuartoSession()
            frmMain.strSaveFilePath = ""

        End If

        frmMain.bRecordQuarto = True
        frmMain.strCurrentQuartoFile = ucrInputFileLocation.GetText()

        frmMain.bQuartoHTML = ucrChkHtml.Checked
        frmMain.bQuartoPDF = ucrChkPdf.Checked
        frmMain.bQuartoPPTX = ucrChkPptx.Checked
        frmMain.bQuartoDOCX = ucrChkDocs.Checked

        frmMain.strSaveFilePath = ucrInputFilePath.GetText()


        frmMain.ucrScriptWindow.CreateNewQuartoTab(
    IO.Path.GetFileName(frmMain.strCurrentQuartoFile))

        frmMain.bShowRenderDetails = ucrChkRenderDetails.Checked

        If ucrChkSaveReopen.Checked AndAlso
       Not String.IsNullOrWhiteSpace(frmMain.strSaveFilePath) Then

            frmMain.clsRecentItems.addToMenu(
            frmMain.strSaveFilePath.Replace("\", "/"))

            frmMain.bDataSaved = True
        End If


        Me.Close()
    End Sub

    Private Sub StartQuartoSession(strRdsFile As String)

        frmMain.clsRLink.RunScript(
        "rm(data_book, .graph_data_book)" & Environment.NewLine &
        "data_book <- DataBook$new()" & Environment.NewLine &
        "new_RDS <- readRDS(file=""" &
        strRdsFile.Replace("\", "/") &
        """)" & Environment.NewLine &
        "data_book$import_RDS(data_RDS=new_RDS)" & Environment.NewLine &
        "rm(new_RDS)"
    )

        frmMain.bRecordQuarto = True

    End Sub

    Private Sub StartEmptyQuartoSession()

        frmMain.clsRLink.RunScript(
        "rm(data_book, .graph_data_book)" & Environment.NewLine &
        "data_book <- DataBook$new()"
    )

        frmMain.bRecordQuarto = True

    End Sub

    Private Sub ucrInputFileLocation_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputFileLocation.ControlContentsChanged, ucrChkSaveReopen.ControlContentsChanged, ucrChkPptx.ControlContentsChanged, ucrChkPdf.ControlContentsChanged, ucrChkHtml.ControlContentsChanged, ucrChkDocs.ControlContentsChanged, ucrInputFilePath.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrChkSaveReopen_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSaveReopen.ControlValueChanged
        SetSaveWorkspaceControlsVisibility()
    End Sub

    Private Sub SetSaveWorkspaceControlsVisibility()
        ucrInputFilePath.Visible = ucrChkSaveReopen.Checked
        cmdBrowseFile.Visible = ucrChkSaveReopen.Checked
        lblSaveAs.Visible = ucrChkSaveReopen.Checked
    End Sub

    Private Sub cmdBrowseFile_Click(sender As Object, e As EventArgs) Handles cmdBrowseFile.Click
        Using dlgSave As New SaveFileDialog

            dlgSave.Title = "Save Data File"

            dlgSave.Filter = "RDS Data file (*.RDS)|*.RDS"

            dlgSave.DefaultExt = "RDS"

            dlgSave.AddExtension = True

            If ucrInputFilePath.GetText() <> "" Then
                dlgSave.InitialDirectory =
                IO.Path.GetDirectoryName(
                    ucrInputFilePath.GetText().Replace("/", "\"))
            Else
                dlgSave.InitialDirectory =
                frmMain.clsInstatOptions.strWorkingDirectory
            End If

            If dlgSave.ShowDialog() = DialogResult.OK Then
                ucrInputFilePath.SetName(
                dlgSave.FileName.Replace("\", "/"))
            End If

        End Using

        TestOkEnabled()

    End Sub
End Class