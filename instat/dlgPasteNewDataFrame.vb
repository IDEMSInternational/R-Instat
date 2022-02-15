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
Public Class dlgPasteNewDataFrame

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsAddDataFunction, clsDataListFunction, clsPasteFunction As New RFunction

    Private Sub dlgPasteNewDataFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        'todo. attach the help id later
        'ucrBase.iHelpTopicID = 

        ucrSaveNewDFName.SetIsTextBox()
        ucrSaveNewDFName.SetSaveTypeAsDataFrame()
        ucrSaveNewDFName.SetLabelText("New Data Frame Name:")
        ucrSaveNewDFName.SetPrefix("data")

        ucrChkRowHeader.SetText("First row is header")
        ucrChkRowHeader.SetParameter(New RParameter("header", 1))

        ucrNudPreviewLines.SetMinMax(iNewMin:=10, iNewMax:=1000)
    End Sub

    Private Sub SetDefaults()
        clsAddDataFunction = New RFunction
        clsDataListFunction = New RFunction
        clsPasteFunction = New RFunction

        'todo 29/05/2021. this is temporarily done this way because of how
        'function ConstructAssignTo in clsRCodeStructure is currently implemented.
        'It doesn't construct "assignTo" statements correctly
        clsAddDataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_data")
        clsAddDataFunction.AddParameter("data_tables", clsRFunctionParameter:=clsDataListFunction, iPosition:=0)
        clsDataListFunction.SetRCommand("list")
        clsDataListFunction.AddParameter(strParameterName:=ucrSaveNewDFName.GetText, clsRFunctionParameter:=clsPasteFunction, iPosition:=0)

        clsPasteFunction.SetPackageName("clipr")
        clsPasteFunction.SetRCommand("read_clip_tbl")
        SetClipBoardDataParameter()
        clsPasteFunction.AddParameter("header", "TRUE", iPosition:=1)

        ucrBase.clsRsyntax.SetBaseRFunction(clsAddDataFunction)

        ucrNudPreviewLines.Value = 10
        ucrSaveNewDFName.Reset()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrChkRowHeader.SetRCode(clsPasteFunction, bReset)
        'todo 29/05/2021. this is temporarily commented out
        'ucrSaveNewDFName.SetRCode(clsPasteFunction, bReset)
    End Sub

    ''' <summary>
    ''' enables base "OK" and "ToScript" buttons if all entries are valid, disables if not.
    ''' </summary>
    ''' <param name="bValidateCopiedData">if true, copied data will also be validated</param>
    Private Sub TestOkEnabled(Optional bValidateCopiedData As Boolean = True)
        'validation of copied data isn't necessary for situations like checking the typed data frame name
        If bValidateCopiedData Then
            ucrBase.OKEnabled(ucrSaveNewDFName.IsComplete AndAlso ValidateAndPreviewCopiedData())
        Else
            ucrBase.OKEnabled(ucrSaveNewDFName.IsComplete)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrSaveNewDFName_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrSaveNewDFName.ControlContentsChanged
        clsDataListFunction.ClearParameters()
        clsDataListFunction.AddParameter(strParameterName:=ucrSaveNewDFName.GetText, clsRFunctionParameter:=clsPasteFunction)
        'TestOkEnabled called here because validation of copied data is not necessary and may take long for large data
        TestOkEnabled(bValidateCopiedData:=False)
    End Sub

    Private Sub ucrControls_ControlValueChangedChanged(ucrchangedControl As ucrCore) Handles ucrChkRowHeader.ControlValueChanged, ucrNudPreviewLines.ControlValueChanged
        'TestOkEnabled called here because ucrChkRowHeader.ControlContentsChanged event is called before the R code is set by the control
        'todo. this could be changed if the ucrCheck raising of ControlContentsChanged event is modified
        TestOkEnabled()
    End Sub

    Private Sub btnRefreshPreview_Click(sender As Object, e As EventArgs) Handles btnRefreshPreview.Click
        SetClipBoardDataParameter()
        TestOkEnabled()
    End Sub

    Private Sub SetClipBoardDataParameter()
        'please note addition of this parameter makes the execution of the R code take longer
        'compared to letting R read from the clipboard.
        'However this has been added to achieve reproducibility in future
        Try
            'clipboard data may have an empty line which is ignored by clipr so just trim it here to get accurate length
            'escape any double quotes because of how clipr is implemented. See issue #7199 for more details
            Dim clipBoardText As String = My.Computer.Clipboard.GetText.Trim().Replace("""", "\""")
            Dim arrStrTemp() As String = clipBoardText.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
            If arrStrTemp.Length > 1000 Then
                MsgBox("Requested clipboard data has more than 1000 rows. Only a maximum of 1000 rows can be pasted")
                clsPasteFunction.AddParameter("x", Chr(34) & "" & Chr(34), iPosition:=0)
            Else
                clsPasteFunction.AddParameter("x", Chr(34) & clipBoardText & Chr(34), iPosition:=0)
            End If
        Catch ex As Exception
            'this error could be due to large clipboard data 
            MsgBox("Requested clipboard operation did not succeed. Large data detected")
        End Try
    End Sub

    ''' <summary>
    ''' validates copied data and displays it for preview.
    ''' </summary>
    ''' <returns>returns true if copied data can be pasted to the selected data frame or false if not</returns>
    Private Function ValidateAndPreviewCopiedData() As Boolean
        Try
            'set feedback controls default states
            panelNoDataPreview.Visible = True
            lblConfirmText.Text = ""
            lblConfirmText.ForeColor = Color.Red

            'use clipr::read_clip_tbl command to check if structure of data can be pasted to a data frame 
            Dim clsTempImport As RFunction = clsPasteFunction.Clone()
            'limit the rows to those set in the ucrNudPreviewLines control
            clsTempImport.AddParameter("nrows", ucrNudPreviewLines.Value)

            'get the data frame produced by clipr data frame 
            Dim dfTemp As DataFrame = frmMain.clsRLink.RunInternalScriptGetValue(clsTempImport.ToScript(), bSilent:=True)?.AsDataFrame
            If dfTemp Is Nothing Then
                Return False
            End If
            'try to show preview the data only
            frmMain.clsGrids.FillSheet(dfTemp, "temp", grdDataPreview, bIncludeDataTypes:=False, iColMax:=frmMain.clsGrids.iMaxCols)
            lblConfirmText.Text = "Click Ok to paste data to new data frame."
            lblConfirmText.ForeColor = Color.Green
            panelNoDataPreview.Visible = False
            Return True
        Catch ex As Exception
            lblConfirmText.Text = "Could not preview data. Cannot be pasted."
            panelNoDataPreview.Visible = True
            Return False
        End Try

    End Function

End Class
