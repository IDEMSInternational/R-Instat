﻿Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports RDotNet
Imports unvell.ReoGrid
Imports unvell.ReoScript


Public Class frm_main
    Dim fileOpen As New rLink


    Private Sub frm_first_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grid.SetSettings(WorkbookSettings.View_ShowSheetTabControl, True)
        grid.SheetTabControlWidth = 200
        frmScript.MdiParent = Me
        frmScript.Show()
        frmScript.editor.Srm = grid.Srm

    End Sub

    Private Sub OpenToolBtn_Click(sender As Object, e As EventArgs) Handles OpenToolBtn.Click
        fileOpen.open()
    End Sub

    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        fileOpen.open()
    End Sub

    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        Dim sheet = grid.CreateWorksheet()
    End Sub

    Private Sub mnuScriptEditor_Click(sender As Object, e As EventArgs) Handles mnuScriptEditor.Click
        frmScript.Show()
    End Sub
End Class
