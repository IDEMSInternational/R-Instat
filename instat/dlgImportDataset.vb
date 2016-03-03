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

    Private intLines As Integer = 10
    Dim bFirstLoad As Boolean = True

    Private Sub dlgImportDataset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'shows the dialog first then the open dialog
        Me.Show()

        'Removes the Sheet Tab control
        grdDataPreview.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
        grdDataPreview.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AutoFormatCell, False)

        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("read.csv")

        If bFirstLoad Then
            SetDefaultValues()
            bFirstLoad = False
        End If

        GetFileFromOpenDialog()

        txtName.Focus()

        RefreshFrameView()

    End Sub

    Private Sub SetDefaultValues()
        cboEncoding.Text = "Automatic"
        rdoHeadingsYes.Checked = True
        cboRowNames.Text = "Automatic"
        cboSeparator.SelectedIndex = cboSeparator.Items.IndexOf("Comma")
        cboDecimal.SelectedIndex = cboDecimal.Items.IndexOf("Period")
        cboQuote.SelectedIndex = cboQuote.Items.IndexOf("Double quote")
        cboComment.SelectedIndex = cboComment.Items.IndexOf("None")
        SetNAStringsText("NA")
        nudSkips.Value = 0
    End Sub

    Public Sub SetDataName(strName As String)
        txtName.Text = strName
        ucrBase.clsRsyntax.SetAssignTo(txtName.Text, strTempDataframe:=txtName.Text)
    End Sub

    Public Sub setLinesToRead(lines As Integer)
        intLines = lines
    End Sub

    Public Sub SetFilePath(strFilePath As String)
        ucrBase.clsRsyntax.AddParameter("file", Chr(34) & strFilePath & Chr(34))
        txtFilePath.Text = strFilePath
        RefreshFilePreview()
        RefreshFrameView()
    End Sub

    Public Sub RefreshFilePreview()
        Dim sReader As New StreamReader(txtFilePath.Text)
        txtInputFile.Text = ""
        For i = 1 To intLines + nudSkips.Value + 1
            txtInputFile.Text = txtInputFile.Text & sReader.ReadLine() & vbCrLf
            If sReader.Peek() = -1 Then
                Exit For
            End If
        Next
    End Sub

    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave

        ucrBase.clsRsyntax.SetAssignTo(txtName.Text, strTempDataframe:=txtName.Text)
        RefreshFrameView()

    End Sub

    Private Sub SetNAStringsText(strTemp As String)
        If strTemp = "NA" Then
            ucrBase.clsRsyntax.AddParameter("na.strings", strTemp)
        Else
            ucrBase.clsRsyntax.AddParameter("na.strings", Chr(34) & strTemp & Chr(34))
        End If
        txtNAStrings.Text = strTemp
    End Sub

    Private Sub cboEncoding_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboEncoding.SelectedIndexChanged

        If cboEncoding.Text <> "Automatic" Then
            ucrBase.clsRsyntax.AddParameter("encoding", cboEncoding.Text)
        Else
            ucrBase.clsRsyntax.RemoveParameter("encoding")
        End If
        RefreshFrameView()

    End Sub

    Private Sub cboRowNames_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboRowNames.SelectedIndexChanged

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
        RefreshFrameView()

    End Sub

    Private Sub cboSeparator_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSeparator.SelectedIndexChanged
        Select Case cboSeparator.SelectedItem
            Case "Whitespace"
                ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & "" & Chr(34))
            Case "Comma"
                ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & "," & Chr(34))
            Case "Semicolon"
                ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & ";" & Chr(34))
        End Select
        RefreshFrameView()
    End Sub

    Private Sub cboDecimal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDecimal.SelectedIndexChanged
        Select Case cboDecimal.Text
            Case "Period"
                ucrBase.clsRsyntax.AddParameter("dec", Chr(34) & "." & Chr(34))
            Case "Comma"
                ucrBase.clsRsyntax.AddParameter("dec", Chr(34) & "," & Chr(34))
        End Select
        RefreshFrameView()
    End Sub

    Private Sub cboQuote_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboQuote.SelectedIndexChanged
        If cboQuote.Text <> "None" Then
            Select Case cboQuote.Text
                Case "Double quote (" & Chr(34) & ")"
                    ucrBase.clsRsyntax.AddParameter("quote", Chr(34) & "\" & Chr(34) & Chr(34))
                Case "Single quote (" & Chr(39) & ")"
                    ucrBase.clsRsyntax.AddParameter("quote", Chr(34) & "\" & Chr(39) & Chr(34))
            End Select
        End If
        RefreshFrameView()
    End Sub

    Private Sub cboComment_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboComment.SelectedIndexChanged
        If cboComment.Text = "None" Then
            ucrBase.clsRsyntax.AddParameter("comment.char", Chr(34) & Chr(34))
        Else
            ucrBase.clsRsyntax.AddParameter("comment.char", Chr(34) & cboComment.Text & Chr(34))
        End If
        RefreshFrameView()
    End Sub

    Private Sub txtNAStrings_TextChanged(sender As Object, e As EventArgs) Handles txtNAStrings.Leave
        SetNAStringsText(txtNAStrings.Text)
        RefreshFrameView()
    End Sub

    Private Sub RefreshFrameView()
        Dim dfTemp As CharacterMatrix
        Dim bToBeAssigned As Boolean
        bToBeAssigned = ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned
        Try
            ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned = False
            ucrBase.clsRsyntax.AddParameter("nrows", intLines)
            dfTemp = frmMain.clsRLink.GetData(ucrBase.clsRsyntax.GetScript())
            ucrBase.clsRsyntax.RemoveParameter("nrows")
            ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned = bToBeAssigned
            frmMain.clsGrids.FillSheet(dfTemp, txtName.Text, grdDataPreview)
        Catch
            grdDataPreview.CurrentWorksheet.Reset()
        End Try
    End Sub

    Private Sub rdoHeadingsYesNo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHeadingsYes.CheckedChanged, rdoHeadingsNo.CheckedChanged

        If rdoHeadingsYes.Checked Then
            ucrBase.clsRsyntax.AddParameter("header", "TRUE")
        ElseIf rdoHeadingsNo.Checked Then
            ucrBase.clsRsyntax.AddParameter("header", "FALSE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("header")
        End If
        RefreshFrameView()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset

        SetDefaultValues()
        RefreshFrameView()

    End Sub

    'Loads the open dialog on load and click
    Private Sub GetFileFromOpenDialog()
        Dim dlgOpen As New OpenFileDialog
        Dim strFilePath As String = ""
        Dim strFileName As String = ""
        Dim strFileExt As String = ""

        dlgOpen.Filter = "Comma separated file (*.csv)|*.csv|RDS R-file (*.RDS)|*.RDS|All Data files (*.csv,*.RDS)|*.csv;*.RDS"
        dlgOpen.Title = "Open Data from file"

        If dlgOpen.ShowDialog() = DialogResult.OK Then
            'checks if the file name is not blank'
            If dlgOpen.FileName <> "" Then
                strFileName = Path.GetFileNameWithoutExtension(dlgOpen.FileName)
                strFilePath = Replace(dlgOpen.FileName, "\", "/")
                strFileExt = Path.GetExtension(strFilePath)
            End If
        End If

        Select Case strFileExt
            Case ".RDS"
                'TODO create dialog to do this
                'frmMain.clsRLink.LoadData(pair.Key, pair.Value, strFileExt)
            Case ".csv"
                'TODO where should this go?
                If Not frmMain.clsRLink.bInstatObjectExists Then
                    frmMain.clsRLink.CreateNewInstatObject()
                End If
                SetDataName(strFileName)
                SetFilePath(strFilePath)
        End Select
        ' TODO Remove LoadData sub in clsRLink once all opening is done through dialogs
    End Sub

    Private Sub nudSkips_ValueChanged(sender As Object, e As EventArgs) Handles nudSkips.ValueChanged
        ucrBase.clsRsyntax.AddParameter("skip", nudSkips.Value)
        'TODO R gives an error if skip is too large
        RefreshFilePreview()
        RefreshFrameView()
    End Sub

    Private Sub cmdOpenDataSet_Click(sender As Object, e As EventArgs) Handles cmdOpenDataSet.Click
        GetFileFromOpenDialog()
    End Sub

End Class