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
Public Class dlgSaveAs
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgSaveAs_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 332
        ucrInputFilePath.IsReadOnly = True
        lblConfirm.Text = "Click Ok to confirm the save"
        ucrInputFilePath.SetParameter(New RParameter("file", 0))
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
        TestOKEnabled()
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        ucrInputFilePath.Reset()
        ucrInputFilePath.SetName("")
        clsDefaultFunction.SetRCommand("saveRDS")
        clsDefaultFunction.AddParameter("object", frmMain.clsRLink.strInstatDataObject)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrInputFilePath.IsEmpty() Then
            lblConfirm.Show()
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
            lblConfirm.Hide()
        End If
    End Sub

    Private Sub cmdEditorSave_Click(sender As Object, e As EventArgs) Handles cmdChooseFile.Click
        SelectFileToSave()
    End Sub

    Private Sub SelectFileToSave()
        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Save Data File"
            dlgSave.Filter = "RDS Data file (*.RDS)|*.RDS"
            If ucrInputFilePath.GetText() <> "" Then
                dlgSave.InitialDirectory = ucrInputFilePath.GetText().Replace("/", "\")
            Else
                dlgSave.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
            End If
            If dlgSave.ShowDialog() = DialogResult.OK Then
                ucrInputFilePath.SetName(dlgSave.FileName.Replace("\", "/"))
            End If
            TestOKEnabled()
        End Using
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
    End Sub

    Private Sub ucrInputFilePath_Click(sender As Object, e As EventArgs) Handles ucrInputFilePath.Click
        If ucrInputFilePath.IsEmpty() Then
            SelectFileToSave()
        End If
    End Sub

    Private Sub ucrInputFilePath_ControContenetsChanged(ucrchangedControl As ucrCore) Handles ucrInputFilePath.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        frmMain.strSaveFilePath = ucrInputFilePath.GetText()
        frmMain.clsRecentItems.addToMenu(Replace(ucrInputFilePath.GetText(), "/", "\"))
    End Sub
End Class
