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
    Public strDataName As String = ""
    Public strFilePath As String = ""
    Private Sub dlgImportDataset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("read.csv")
        autoTranslate(Me)
        cboEncoding.Text = "Automatic"
        'Needs discussion for this
        rdoHeadingsYes.Checked = True

        ucrBase.clsRsyntax.AddParameter("header", "TRUE")
        cboRowNames.Text = "Automatic"

        ucrBase.clsRsyntax.AddParameter("row.names", "NULL")

        cboSeparator.Text = "Comma"
        ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & "," & Chr(34))

        cboDecimal.Text = "Period"
        ucrBase.clsRsyntax.AddParameter("dec", Chr(34) & "." & Chr(34))

        cboQuote.Text = "Double quote"
        ucrBase.clsRsyntax.AddParameter("quote", Chr(34) & "\" & Chr(34) & Chr(34))

        cboComment.Text = "None"
        ucrBase.clsRsyntax.AddParameter("comment.char", Chr(34) & Chr(34))

        txtNAStrings.Text = "NA"
        ucrBase.clsRsyntax.AddParameter("na.strings", "NA")

        SetName(strDataName)
        SetFilePath(strFilePath)
        'defaults for the preview data frame
        dataFrame.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
        refreshFrameView()
    End Sub

    Public Sub SetName(strName As String)
        strName = Replace(strName, " ", "")
        strName = Replace(strName, "-", "")
        txtName.Text = strName
        ucrBase.clsRsyntax.SetAssignTo(txtName.Text, strTempDataframe:=txtName.Text)
        strDataName = strName
    End Sub

    Public Sub SetFilePath(strFilePath As String)
        Dim sReader As New StreamReader(strFilePath)
        ucrBase.clsRsyntax.AddParameter("file", Chr(34) & strFilePath & Chr(34))
        txtInputFile.Text = sReader.ReadToEnd
    End Sub

    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave
        SetName(txtName.Text)
        refreshFrameView()
    End Sub

    Private Sub cboEncoding_Leave(sender As Object, e As EventArgs) Handles cboEncoding.Leave
        If cboEncoding.Text <> "Automatic" Then
            ucrBase.clsRsyntax.AddParameter("encoding", cboEncoding.Text)
            refreshFrameView()
        End If
    End Sub

    Private Sub cboRowNames_Leave(sender As Object, e As EventArgs) Handles cboRowNames.Leave
        If cboRowNames.Text <> "Automatic" Then
            Select Case cboRowNames.Text
                Case "Use first column"
                    ucrBase.clsRsyntax.AddParameter("row.names", 1)
                Case "Use numbers"
                    ucrBase.clsRsyntax.AddParameter("row.names", "NULL")
            End Select
        End If
        refreshFrameView()
    End Sub

    Private Sub cboSeparator_Leave(sender As Object, e As EventArgs) Handles cboSeparator.Leave
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

    Private Sub cboDecimal_Leave(sender As Object, e As EventArgs) Handles cboDecimal.Leave
        Select Case cboDecimal.Text
            Case "Period"
                ucrBase.clsRsyntax.AddParameter("dec", Chr(34) & "." & Chr(34))
            Case "Comma"
                ucrBase.clsRsyntax.AddParameter("dec", Chr(34) & "," & Chr(34))
        End Select
        refreshFrameView()
    End Sub

    Private Sub cboQuote_Leave(sender As Object, e As EventArgs) Handles cboQuote.Leave
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

    Private Sub cboComment_Leave(sender As Object, e As EventArgs) Handles cboComment.Leave
        If cboComment.Text = "None" Then
            ucrBase.clsRsyntax.AddParameter("comment.char", Chr(34) & Chr(34))
        Else
            ucrBase.clsRsyntax.AddParameter("comment.char", Chr(34) & cboComment.Text & Chr(34))
        End If
        refreshFrameView()
    End Sub

    Private Sub txtNAStrings_Leave(sender As Object, e As EventArgs) Handles txtNAStrings.Leave
        If txtNAStrings.Text = "NA" Then
            ucrBase.clsRsyntax.AddParameter("na.strings", txtNAStrings.Text)
        Else
            ucrBase.clsRsyntax.AddParameter("na.strings", Chr(34) & txtNAStrings.Text & Chr(34))
        End If
        refreshFrameView()
    End Sub

    Private Sub refreshFrameView()
        'Needs discusion
        ucrBase.clsRsyntax.SetAssignTo(strDataName, "")
        frmMain.clsRLink.clsEngine.Evaluate(ucrBase.clsRsyntax.GetScript())
        'ucrBase.clsRsyntax.SetAssignTo(strDataName, strDataName)
        dfTemp = frmMain.clsRLink.clsEngine.GetSymbol(txtName.Text).AsDataFrame
        frmMain.clsGrids.FillSheet(dfTemp, txtName.Text, dataFrame)
    End Sub

    Private Sub rdoHeadingsYes_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHeadingsYes.CheckedChanged
        If rdoHeadingsYes.Checked Then
            ucrBase.clsRsyntax.AddParameter("header", "TRUE")
        End If
    End Sub

    Private Sub rdoHeadingsYes_Leave(sender As Object, e As EventArgs) Handles rdoHeadingsYes.Leave
        refreshFrameView()
    End Sub

    Private Sub rdoHeadingsNo_Leave(sender As Object, e As EventArgs) Handles rdoHeadingsNo.Leave
        refreshFrameView()
    End Sub

    Private Sub rdoHeadingsNo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHeadingsNo.CheckedChanged
        If rdoHeadingsNo.Checked Then
            ucrBase.clsRsyntax.AddParameter("header", "FALSE")
        End If
    End Sub
End Class