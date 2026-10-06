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
Imports System.IO
Imports instat.Translations
Public Class dlgUseTable
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsGetGtTableFunction, clsGtSaveFunction, clsWebshotFunction As New RFunction
    Private clsGetTableFileUrlFunction, clsPasteFileUriFunction As New RFunction
    Private clsGtTableROperator, clsBaseOperator As New ROperator

    Private Sub dlgUseTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrTablesSelector.SetParameter(New RParameter("data_name", 0))
        ucrTablesSelector.SetParameterIsString()

        ucrTablesReceiver.SetParameter(New RParameter("object_name", 1))
        ucrTablesReceiver.Selector = ucrTablesSelector
        ucrTablesReceiver.SetParameterIsString()
        ucrTablesReceiver.strSelectorHeading = "Tables"
        ucrTablesReceiver.SetItemType(RObjectTypeLabel.Table)

        ucrSaveTable.SetPrefix("use_table")
        ucrSaveTable.SetSaveType(strRObjectType:=RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
        ucrSaveTable.SetDataFrameSelector(ucrTablesSelector.ucrAvailableDataFrames)
        ucrSaveTable.SetCheckBoxText("Store New Table")
        ucrSaveTable.SetIsComboBox()
        ucrSaveTable.SetAssignToIfUncheckedValue("last_table")

        ucrChkSelectTheme.SetText("Theme")
        ucrChkSelectTheme.Checked = True
        ucrCboSelectThemes.SetItems({"Dark Theme", "538 Theme", "Dot Matrix Theme", "Espn Theme", "Excel Theme", "Guardian Theme", "NY Times Theme", "PFF Theme"})
        ucrCboSelectThemes.SetDropDownStyleAsNonEditable()
        ucrHeader.Setup(clsGtTableROperator, bShowSubtitle:=False)

        ucrChkExport.SetText("Export Table")
        ucrChkExport.Checked = True ' Forces the controls to be hidden
        cboFileType.Items.AddRange({"HTML (*.html)", "PDF (*.pdf)", "PNG (*.png)", "LaTeX (*.tex)", "Word (*.docx)", "RTF (*.rtf)"})
    End Sub

    Private Sub SetDefaults()
        clsGtTableROperator = New ROperator
        clsBaseOperator = New ROperator
        clsGetGtTableFunction = New RFunction
        clsGtSaveFunction = New RFunction
        clsWebshotFunction = New RFunction
        clsGetTableFileUrlFunction = New RFunction
        clsPasteFileUriFunction = New RFunction

        ucrTablesSelector.Reset()
        ucrTablesReceiver.SetMeAsReceiver()
        ucrSaveTable.Reset()
        ucrChkSelectTheme.Checked = False
        ucrChkExport.Checked = False
        cboFileType.SelectedIndex = 0
        ucrFilePath.ResetPathControl()

        ucrBase.clsRsyntax.GetAfterCodes().Clear()
        clsGetGtTableFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")

        clsGtTableROperator.SetOperation("%>%")
        clsGtTableROperator.bBrackets = False
        clsGtTableROperator.AddParameter(strParameterName:="gt_tbl", clsRFunctionParameter:=clsGetGtTableFunction, iPosition:=0, bIncludeArgumentName:=False)
        ucrHeader.Setup(clsGtTableROperator, bShowSubtitle:=False)

        ' Set base operator
        clsBaseOperator.SetOperation("%>%")
        clsBaseOperator.bBrackets = False
        clsBaseOperator.AddParameter(strParameterName:="gt_tbl_operator", clsROperatorParameter:=clsGtTableROperator, iPosition:=0, bIncludeArgumentName:=False)
        clsBaseOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                                  strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                                  strRObjectFormatToAssignTo:=RObjectFormat.Html,
                                                  strRDataFrameNameToAddObjectTo:=ucrTablesSelector.strCurrentDataFrame,
                                                  strObjectName:="last_table")

        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)

        clsGtSaveFunction.SetPackageName("gt")
        clsGtSaveFunction.SetRCommand("gtsave")
        clsGtSaveFunction.AddParameter("data", clsROperatorParameter:=clsGtTableROperator, iPosition:=0)

        clsWebshotFunction.SetPackageName("webshot")
        clsWebshotFunction.SetRCommand("webshot")

        clsGetTableFileUrlFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
        clsGetTableFileUrlFunction.AddParameter("as_file", "TRUE", iPosition:=2)

        clsPasteFileUriFunction.SetRCommand("paste0")
        clsPasteFileUriFunction.AddParameter("prefix", Chr(34) & "file:///" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
        clsPasteFileUriFunction.AddParameter("filepath", clsRFunctionParameter:=clsGetTableFileUrlFunction, bIncludeArgumentName:=False, iPosition:=1)

        clsWebshotFunction.AddParameter("url", clsRFunctionParameter:=clsPasteFileUriFunction, iPosition:=0)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrTablesSelector.SetRCode(clsGetGtTableFunction, bReset)
        ucrTablesReceiver.SetRCode(clsGetGtTableFunction, bReset)

        ucrSaveTable.SetRCode(clsBaseOperator, bReset)
    End Sub

    Private Sub TestOKEnabled()
        Dim bEnableOk As Boolean = Not ucrTablesReceiver.IsEmpty AndAlso ucrSaveTable.IsComplete
        If bEnableOk AndAlso ucrChkExport.Checked Then
            bEnableOk = Not ucrFilePath.IsEmpty
        End If
        ucrBase.OKEnabled(bEnableOk)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub btnTableOptions_Click(sender As Object, e As EventArgs) Handles btnTableOptions.Click
        ' Set contents of the ucrHeader to the operator just incase they have not been set 
        ucrHeader.SetValuesToOperator(clsOperator:=clsGtTableROperator)

        sdgTableOptions.Setup(ucrTablesSelector.strCurrentDataFrame,
                              clsGtTableROperator, {
                              EnumTableSubDialogTab.Header,
                              EnumTableSubDialogTab.Columns, EnumTableSubDialogTab.Rows,
                              EnumTableSubDialogTab.Cells, EnumTableSubDialogTab.SourceNotes,
                              EnumTableSubDialogTab.Themes, EnumTableSubDialogTab.OtherStyle,
                              EnumTableSubDialogTab.Table},
                              strTableName:=ucrTablesReceiver.GetVariableNames(bWithQuotes:=False))
        sdgTableOptions.ShowDialog(Me)

        ' Get any new header contents from operator 
        ucrHeader.Setup(clsGtTableROperator, bShowSubtitle:=False)

        ' TODO. Temporary fix until the themes custom control is implemented
        ucrChkSelectTheme.Checked = sdgTableOptions.ucrChkSelectTheme.Checked
        If ucrChkSelectTheme.Checked Then
            ucrCboSelectThemes.SetText(sdgTableOptions.ucrCboSelectThemes.GetText)
        End If
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrTablesReceiver.ControlContentsChanged, ucrSaveTable.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkExport_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkExport.ControlContentsChanged
        If ucrChkExport.Checked Then
            lblFileType.Visible = True
            cboFileType.Visible = True
            ucrFilePath.Visible = True
            UpdateExportAfterCodes()
        Else
            lblFileType.Visible = False
            cboFileType.Visible = False
            ucrFilePath.Visible = False
            ucrBase.clsRsyntax.GetAfterCodes().Clear()
        End If
        TestOKEnabled()
    End Sub

    Private Sub cboFileType_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboFileType.SelectedValueChanged
        ucrFilePath.Clear()
        ucrFilePath.FilePathDialogFilter = GetFilePathDialogFilterText(cboFileType.SelectedItem?.ToString())
        UpdateExportAfterCodes()
        TestOKEnabled()
    End Sub

    Private Sub ucrFilePath_FilePathChanged() Handles ucrFilePath.FilePathChanged
        UpdateExportAfterCodes()
        TestOKEnabled()
    End Sub

    Private Sub UpdateExportAfterCodes()
        ucrBase.clsRsyntax.GetAfterCodes().Clear()

        If ucrChkExport.Checked AndAlso Not ucrFilePath.IsEmpty AndAlso cboFileType.SelectedItem IsNot Nothing Then

            Dim strFileType As String = cboFileType.SelectedItem.ToString()
            Dim strFilePath As String = ucrFilePath.FilePath.Replace("\", "/")

            If strFileType.Contains(".png") OrElse strFileType.Contains(".pdf") Then
                clsWebshotFunction.RemoveParameterByName("file")
                clsWebshotFunction.AddParameter("file", Chr(34) & strFilePath & Chr(34), iPosition:=1)
                ucrBase.clsRsyntax.AddToAfterCodes(clsWebshotFunction)
            Else
                Dim strFileName As String = Path.GetFileName(strFilePath)
                Dim strDir As String = Path.GetDirectoryName(strFilePath)
                If strDir IsNot Nothing Then strDir = strDir.Replace("\", "/")

                clsGtSaveFunction.RemoveParameterByName("filename")
                clsGtSaveFunction.RemoveParameterByName("path")
                clsGtSaveFunction.AddParameter("filename", Chr(34) & strFileName & Chr(34), iPosition:=1)
                If strDir IsNot Nothing Then
                    clsGtSaveFunction.AddParameter("path", Chr(34) & strDir & Chr(34), iPosition:=2)
                End If

                ucrBase.clsRsyntax.AddToAfterCodes(clsGtSaveFunction)
            End If
        End If
    End Sub

    Private Function GetExportObjectName() As String
        If ucrSaveTable.ucrChkSave IsNot Nothing AndAlso ucrSaveTable.ucrChkSave.Checked Then
            Return ucrSaveTable.GetText()
        End If
        Return "last_table"
    End Function

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        ucrHeader.SetValuesToOperator(clsOperator:=clsGtTableROperator)

        Dim strDataName As String = ucrTablesSelector.strCurrentDataFrame
        Dim strOutputName As String = GetExportObjectName()

        clsGetTableFileUrlFunction.RemoveParameterByName("data_name")
        clsGetTableFileUrlFunction.RemoveParameterByName("object_name")

        clsGetTableFileUrlFunction.AddParameter("data_name", Chr(34) & strDataName & Chr(34), iPosition:=0)
        clsGetTableFileUrlFunction.AddParameter("object_name", Chr(34) & strOutputName & Chr(34), iPosition:=1)
    End Sub

    ''' <summary>
    ''' TODO. Later push this functionality to ucrFilePath control. It's also needed by dlgExportDataset
    ''' Expected string format: "filetype (*.ext)" 
    ''' </summary>
    ''' <param name="strText"></param>
    ''' <returns></returns>
    Private Function GetFilePathDialogFilterText(strText As String) As String
        If String.IsNullOrEmpty(strText) Then
            Return ""
        End If

        'example of filter string format returned: Excel files|*.xlsx
        Dim arrStr() As String = strText.Split({"(", ")"}, StringSplitOptions.RemoveEmptyEntries)
        Return arrStr(0) & "|" & arrStr(1)
    End Function

    Private Sub ucrChkSelectTheme_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSelectTheme.ControlValueChanged
        If ucrChkSelectTheme.Checked Then
            ucrCboSelectThemes.Visible = True
            ucrCboSelectThemes.SetName("Dark Theme") ' Set default theme
        Else
            ucrCboSelectThemes.Visible = False
            clsGtTableROperator.RemoveParameterByName("theme_format")
        End If
    End Sub

    ' TODO. This is a replication of what is in the tables sub-dialog.
    Private Sub ucrCboSelectThemes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCboSelectThemes.ControlValueChanged
        If Not ucrChkSelectTheme.Checked OrElse ucrCboSelectThemes.IsEmpty() Then
            Exit Sub
        End If

        Dim strCommand As String = ""
        Select Case ucrCboSelectThemes.GetText
            Case "Dark Theme"
                strCommand = "gt_theme_dark"
            Case "538 Theme"
                strCommand = "gt_theme_538"
            Case "Dot Matrix Theme"
                strCommand = "gt_theme_dot_matrix"
            Case "Espn Theme"
                strCommand = "gt_theme_espn"
            Case "Excel Theme"
                strCommand = "gt_theme_excel"
            Case "Guardian Theme"
                strCommand = "gt_theme_guardian"
            Case "NY Times Theme"
                strCommand = "gt_theme_nytimes"
            Case "PFF Theme"
                strCommand = "gt_theme_pff"
        End Select

        If strCommand = "" Then
            Exit Sub ' Do nothing
        End If

        Dim clsThemeRFunction As New RFunction
        clsThemeRFunction.SetPackageName("gtExtras")
        clsThemeRFunction.SetRCommand(strCommand)
        clsGtTableROperator.AddParameter("theme_format", clsRFunctionParameter:=clsThemeRFunction)
    End Sub
End Class