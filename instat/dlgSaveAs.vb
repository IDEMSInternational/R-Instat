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

Public Class dlgSaveAs
    Dim bFirstLoad As Boolean = True

    Private Sub dlgSaveAs_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrInputFilePath.IsReadOnly = True
        ucrBase.clsRsyntax.SetFunction("saveRDS")
        ucrBase.clsRsyntax.AddParameter("object", frmMain.clsRLink.strInstatDataObject)
        txtConfirm.Text = "Click Ok to confirm the save"
    End Sub

    Private Sub SetDefaults()
        ucrInputFilePath.SetName("")
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrInputFilePath.IsEmpty() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        'adds the saved file to the recent paths
        'Disabled until implemented correctly
        'frmMain.clsRecentItems.addToMenu(ucrInputFilePath.GetText())
        frmMain.strSaveFilePath = ucrInputFilePath.GetText()
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
        TestOKEnabled()
    End Sub

    Private Sub ucrInputFilePath_NameChanged() Handles ucrInputFilePath.NameChanged
        If Not ucrInputFilePath.IsEmpty() Then
            ucrBase.clsRsyntax.AddParameter("file", Chr(34) & ucrInputFilePath.GetText() & Chr(34))
            txtConfirm.Show()
        Else
            ucrBase.clsRsyntax.RemoveParameter("file")
            txtConfirm.Hide()
        End If
    End Sub

    Private Sub ucrInputFilePath_Click(sender As Object, e As EventArgs) Handles ucrInputFilePath.Click
        If ucrInputFilePath.IsEmpty() Then
            SelectFileToSave()
        End If
    End Sub
End Class
