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
Imports RDotNet
Imports instat.Translations
Public Class dlgPasteNewColumns
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsPasteFunction As RFunction
    'used to prevent TestOkEnabled from being called multiple times when loading the dialog. 
    Private bIsOnDialogLoad As Boolean

    Private Sub dlgPasteNewColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bIsOnDialogLoad = True
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        'reset the clip board data parameter value
        SetClipBoardDataParameter()
        SetRCodeForControls(bReset)
        bReset = False
        bIsOnDialogLoad = False
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        'todo. attach the help id later
        'ucrBase.iHelpTopicID = 332

        ucrDataFrameSelected.SetText("Paste copied data to:")
        ucrDataFrameSelected.SetParameter(New RParameter("data_name", 0))
        ucrDataFrameSelected.SetParameterIsString()

        ucrChkRowHeader.SetText("First row is header")
        ucrChkRowHeader.SetParameter(New RParameter("first_clip_row_is_header", 1))

        ucrNudPreviewLines.Minimum = 10
    End Sub

    Private Sub SetDefaults()
        clsPasteFunction = New RFunction

        ucrNudPreviewLines.Value = 10
        ucrDataFrameSelected.Reset()

        clsPasteFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$paste_from_clipboard")
        clsPasteFunction.AddParameter("first_clip_row_is_header", "TRUE", iPosition:=0)
        SetClipBoardDataParameter()
        ucrBase.clsRsyntax.SetBaseRFunction(clsPasteFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrDataFrameSelected.SetRCode(clsPasteFunction, bReset)
        ucrChkRowHeader.SetRCode(clsPasteFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        ucrBase.OKEnabled(Not String.IsNullOrEmpty(ucrDataFrameSelected.strCurrDataFrame) AndAlso ValidateAndPreviewCopiedData())
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrControls_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrDataFrameSelected.ControlContentsChanged, ucrChkRowHeader.ControlContentsChanged, ucrNudPreviewLines.ControlContentsChanged
        If Not bIsOnDialogLoad Then
            TestOkEnabled()
        End If
    End Sub

    Private Sub btnRefreshPreview_Click(sender As Object, e As EventArgs) Handles btnRefreshPreview.Click
        SetClipBoardDataParameter()
        TestOkEnabled()
    End Sub

    Public Sub SetClipBoardDataParameter()
        'please note addition of 'clip_board_text'  parameter makes the execution of the R code take longer
        'compared to letting R read from the clipboard dierectly.
        'However this has been added to achieve reproducibility in future
        Try
            'clipboard data may have an empty line which is ignored by clipr so just trim it here to get accurate length
            'escape any double quotes because of how clipr is implemented. See issue #7199 for more details
            Dim clipBoardText As String = My.Computer.Clipboard.GetText().Replace("""", "\""").Trim()
            Dim arrStrTemp() As String = clipBoardText.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
            If arrStrTemp.Length > 1000 Then
                MsgBox("Requested clipboard data has more than 1000 rows. Only a maximum of 1000 rows can be pasted")
                clsPasteFunction.AddParameter("clip_board_text", Chr(34) & "" & Chr(34), iPosition:=1)
            Else
                clsPasteFunction.AddParameter("clip_board_text", Chr(34) & clipBoardText & Chr(34), iPosition:=1)
            End If
        Catch ex As Exception
            'this error could be due to large clipboard data 
            MsgBox("Requested clipboard operation did not succeed. Large data detected")
        End Try
    End Sub

    ''' <summary>
    ''' validates copied data and displays it for preview.
    ''' returns true if copied data can be pasted to the selected data frame or false if not
    ''' </summary>
    ''' <returns></returns>
    Private Function ValidateAndPreviewCopiedData() As Boolean
        Try
            'set feedback controls default states
            panelNoDataPreview.Visible = True
            lblConfirmText.Text = "Could not preview data. Cannot be pasted."
            lblConfirmText.ForeColor = Color.Red

            'use clipr package to check if structure of data can be pasted to a data frame 
            Dim dfTemp As DataFrame
            Dim clsTempImport As New RFunction
            clsTempImport.SetPackageName("clipr")
            clsTempImport.SetRCommand("read_clip_tbl")
            clsTempImport.AddParameter("x", clsPasteFunction.GetParameter("clip_board_text").strArgumentValue, iPosition:=0)
            clsTempImport.AddParameter("header", If(ucrChkRowHeader.Checked, "TRUE", "FALSE"), iPosition:=1)

            'get the pasted data produced by clipr  
            dfTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsTempImport.ToScript(), bSilent:=True)?.AsDataFrame
            If dfTemp Is Nothing Then
                Return False
            End If

            'parameter 'nrows' commented out for future reference.
            'not added here because we are already limiting data pasting to 1000 rows
            'the lines preview is enforced at the sheet levet
            'clsTempImport.AddParameter("nrows", ucrNudPreviewLines.Value, iPosition:=2)

            dfTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsTempImport.ToScript(), bSilent:=True)?.AsDataFrame
            'show the data preview only. Limit the rows to those set in the ucrNudPreviewLines control
            frmMain.clsGrids.FillSheet(dfTemp, "temp", grdDataPreview, bIncludeDataTypes:=False,
                                       iColMax:=frmMain.clsGrids.iMaxCols, iRowMax:=ucrNudPreviewLines.Value)

            panelNoDataPreview.Visible = False
            lblConfirmText.Text = "Number of columns: " & dfTemp.ColumnCount & Environment.NewLine &
                                  "Number of rows: " & dfTemp.RowCount & Environment.NewLine & Environment.NewLine

            'validate allowed number of rows
            If dfTemp.RowCount = 0 Then
                lblConfirmText.Text = lblConfirmText.Text & "No copied data detected."
                Return False
            ElseIf dfTemp.RowCount < ucrDataFrameSelected.iDataFrameLength Then
                lblConfirmText.Text = lblConfirmText.Text & "Too few rows to paste into this data frame. This data frame requires " & ucrDataFrameSelected.iDataFrameLength & " rows."
                'please note, we could allow few rows to be pasted. the R code is already set up to allow
                'but as stated in issue #5991 by Danny this is unlikely to be the correct solution.
                'Left here for reference
                'lblConfirmText.Text = lblConfirmText.Text & Environment.NewLine &
                '                   (ucrDataFrameSelected.iDataFrameLength - dfTemp.RowCount) & " missing values will be added."
                Return False
            ElseIf dfTemp.RowCount > ucrDataFrameSelected.iDataFrameLength Then
                lblConfirmText.Text = lblConfirmText.Text & "Too many rows to paste into this data frame. This data frame requires " & ucrDataFrameSelected.iDataFrameLength & " rows."
                Return False
            Else
                lblConfirmText.Text = lblConfirmText.Text & "Correct length."
            End If


            lblConfirmText.ForeColor = Color.Green

            Return True
        Catch ex As Exception
            lblConfirmText.Text = "Could not preview data. Cannot be pasted."
            panelNoDataPreview.Visible = True
            Return False
        End Try
    End Function

End Class