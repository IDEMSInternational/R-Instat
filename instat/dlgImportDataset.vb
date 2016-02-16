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
Imports System.IO
Imports RDotNet

Public Class dlgImportDataset

    Dim dfTemp As DataFrame
    Private strDataName As String = ""
    Private strFilePath As String = ""
    Private intLines As Integer = 10
    Dim bFirstLoad As Boolean = True

    Private Sub dlgImportDataset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'shows the dialog first then the open dialog
        Me.Show()
        showOpenDialog()
        'removes the sheet Tab control
        dataFrame.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)

        autoTranslate(Me)

        If bFirstLoad Then
            SetDefaultValues()
            bFirstLoad = False
        End If
        txtName.Focus()

        refreshFrameView()

    End Sub

    Private Sub SetDefaultValues()
        ucrBase.clsRsyntax.SetFunction("read.csv")
        cboEncoding.Text = "Automatic"
        rdoHeadingsYes.Checked = True
        cboRowNames.Text = "Automatic"
        cboSeparator.Text = "Comma"
        cboDecimal.Text = "Period"
        cboQuote.Text = "Double quote"
        cboComment.Text = "None"
        txtNAStrings.Text = "NA"
        nudSkips.Value = 0
    End Sub

    Public Sub SetName(strName As String)
        txtName.Text = strName
        strDataName = strName
        ucrBase.clsRsyntax.SetAssignTo(txtName.Text, strTempDataframe:=txtName.Text)
    End Sub

    Public Sub setLinesToRead(lines As Integer)
        intLines = lines
    End Sub

    Public Sub SetFilePath(strFilePath As String)
        Dim sReader As New StreamReader(strFilePath)
        ucrBase.clsRsyntax.AddParameter("file", Chr(34) & strFilePath & Chr(34))
        txtFileOPenPath.Text = strFilePath
        txtInputFile.Text = ""

        For i = 1 To 10 + nudSkips.Value
            txtInputFile.Text = txtInputFile.Text & sReader.ReadLine() & vbCrLf
            If sReader.Peek() = -1 Then
                Exit For
            End If
        Next

    End Sub

    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave

        ucrBase.clsRsyntax.SetAssignTo(txtName.Text, strTempDataframe:=txtName.Text)
        refreshFrameView()

    End Sub

    Private Sub cboEncoding_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboEncoding.SelectionChangeCommitted

        If cboEncoding.Text <> "Automatic" Then
            ucrBase.clsRsyntax.AddParameter("encoding", cboEncoding.Text)
        Else
            ucrBase.clsRsyntax.RemoveParameter("encoding")
        End If
        refreshFrameView()

    End Sub

    Private Sub cboRowNames_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboRowNames.SelectionChangeCommitted

        If cboRowNames.Text <> "Automatic" Then
            Select Case cboRowNames.Text
                Case "Use first column"
                    ucrBase.clsRsyntax.AddParameter("row.names", 1)
                Case "Use numbers"
                    ucrBase.clsRsyntax.AddParameter("row.names", "NULL")
            End Select
        Else
            ucrBase.clsRsyntax.RemoveParameter("row.names")
        End If
        refreshFrameView()

    End Sub

    Private Sub cboSeparator_SelectionChanged(sender As Object, e As EventArgs) Handles cboSeparator.SelectionChangeCommitted
        Select Case cboSeparator.Text
            Case "Whitespace"
                ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & "" & Chr(34))
            Case "Comma"
                ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & "," & Chr(34))
            Case "Semicolon"
                ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & ";" & Chr(34))
        End Select
        refreshFrameView()
    End Sub

    Private Sub cboDecimal_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboDecimal.SelectionChangeCommitted
        Select Case cboDecimal.Text
            Case "Period"
                ucrBase.clsRsyntax.AddParameter("dec", Chr(34) & "." & Chr(34))
            Case "Comma"
                ucrBase.clsRsyntax.AddParameter("dec", Chr(34) & "," & Chr(34))
        End Select
        refreshFrameView()
    End Sub

    Private Sub cboQuote_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboQuote.SelectionChangeCommitted
        If cboQuote.Text <> "None" Then
            Select Case cboQuote.Text
                Case "Double quote (" & Chr(34) & ")"
                    ucrBase.clsRsyntax.AddParameter("quote", Chr(34) & "\" & Chr(34) & Chr(34))
                Case "Single quote (" & Chr(39) & ")"
                    ucrBase.clsRsyntax.AddParameter("quote", Chr(34) & "\" & Chr(39) & Chr(34))
            End Select
        End If
        refreshFrameView()
    End Sub

    Private Sub cboComment_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboComment.SelectionChangeCommitted
        If cboComment.Text = "None" Then
            ucrBase.clsRsyntax.AddParameter("comment.char", Chr(34) & Chr(34))
        Else
            ucrBase.clsRsyntax.AddParameter("comment.char", Chr(34) & cboComment.Text & Chr(34))
        End If
        refreshFrameView()
    End Sub

    Private Sub txtNAStrings_TextChanged(sender As Object, e As EventArgs) Handles txtNAStrings.TextChanged
        If txtNAStrings.Text = "NA" Then
            ucrBase.clsRsyntax.AddParameter("na.strings", txtNAStrings.Text)
        Else
            ucrBase.clsRsyntax.AddParameter("na.strings", Chr(34) & txtNAStrings.Text & Chr(34))
        End If
        refreshFrameView()
    End Sub

    Private Sub refreshFrameView()
        Dim bToBeAssigned As Boolean
        bToBeAssigned = ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned
        ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned = False
        ucrBase.clsRsyntax.AddParameter("nrows", intLines)
        dfTemp = frmMain.clsRLink.GetData(ucrBase.clsRsyntax.GetScript())
        ucrBase.clsRsyntax.RemoveParameter("nrows")
        ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned = bToBeAssigned
        frmMain.clsGrids.FillSheet(dfTemp, txtName.Text, dataFrame)
    End Sub

    Private Sub rdoHeadingsYes_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHeadingsYes.CheckedChanged, rdoHeadingsNo.CheckedChanged

        If rdoHeadingsYes.Checked Then
            ucrBase.clsRsyntax.AddParameter("header", "TRUE")
        ElseIf rdoHeadingsNo.Checked Then
            ucrBase.clsRsyntax.AddParameter("header", "FALSE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("header")
        End If
        refreshFrameView()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset

        SetDefaultValues()
        refreshFrameView()

    End Sub
    'Function to show the open dialog

    Public Function OpenFromFileDialog() As KeyValuePair(Of String, String)
        Dim dlgOpen As New OpenFileDialog
        Dim strFilePath, strFileName As String
        dlgOpen.Filter = "Comma separated file (*.csv)|*.csv|RDS R-file (*.RDS)|*.RDS|All Data files (*.csv,*.RDS)|*.csv;*.RDS"
        dlgOpen.Title = "Open Data from file"
        If dlgOpen.ShowDialog() = DialogResult.OK Then
            'checks if the file name is not blank'
            If dlgOpen.FileName <> "" Then
                strFileName = Path.GetFileNameWithoutExtension(dlgOpen.FileName)
                strFilePath = Replace(dlgOpen.FileName, "\", "/")
                Return New KeyValuePair(Of String, String)(strFileName, strFilePath)
            End If
        End If
        Return New KeyValuePair(Of String, String)("", "")
    End Function

    'Loads the open dialog on load and click
    Private Sub showOpenDialog()
        Dim pair As KeyValuePair(Of String, String)
        Dim strFileExt As String

        pair = OpenFromFileDialog()
        'pair.key is the File Name
        'pair.value is the File Path

        ' TODO Probably remove LoadData sub in clsRLink once all opening is done through dialogs
        If Not IsNothing(pair.Key) Then
            strFileExt = Path.GetExtension(pair.Value)
            Select Case strFileExt
                Case ".RDS"
                    'TODO create dialog to do this
                    frmMain.clsRLink.LoadData(pair.Key, pair.Value, strFileExt)
                Case ".csv"
                    'TODO where should this go?
                    If Not frmMain.clsRLink.bInstatObjectExists Then
                        frmMain.clsRLink.CreateNewInstatObject()
                    End If
                    SetName(pair.Key)
                    SetFilePath(pair.Value)
                    strFilePath = pair.Value
            End Select
        End If
    End Sub

    Private Sub nudSkips_ValueChanged(sender As Object, e As EventArgs) Handles nudSkips.ValueChanged
        ucrBase.clsRsyntax.AddParameter("skip", nudSkips.Value)
        If Not bFirstLoad Then
            refreshFrameView()
        End If
    End Sub

    Private Sub cmdOpenDataSet_Click(sender As Object, e As EventArgs) Handles cmdOpenDataSet.Click
        showOpenDialog()
    End Sub
End Class