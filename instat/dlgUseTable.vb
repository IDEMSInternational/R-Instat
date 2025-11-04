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
    Private clsGetGtTableFunction, clsSaveGtRFunction As New RFunction
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
        TestOKEnabled()
        autoTranslate(Me)
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

        ucrChkExport.SetText("Export Table")
        ucrChkExport.Checked = True ' Forces the controls to be hidden
        'cboFileType.Items.AddRange({"HTML (*.html)", "PDF (*.pdf)", "PNG (*.png)", "LaTeX (*.tex)", "RTF (*.rtf)", "Word (*.docx)"})
        cboFileType.Items.AddRange({"HTML (*.html)", "LaTeX (*.tex)", "RTF (*.rtf)"})
    End Sub

    Private Sub SetDefaults()
        clsGtTableROperator = New ROperator
        clsBaseOperator = New ROperator
        clsGetGtTableFunction = New RFunction
        clsSaveGtRFunction = New RFunction

        ucrTablesSelector.Reset()
        ucrTablesReceiver.SetMeAsReceiver()
        ucrSaveTable.Reset()
        ucrChkExport.Checked = False
        cboFileType.SelectedIndex = 0
        ucrFilePath.ResetPathControl()

        clsGetGtTableFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")

        clsGtTableROperator.SetOperation("%>%")
        clsGtTableROperator.bBrackets = False
        clsGtTableROperator.AddParameter(strParameterName:="gt_tbl", clsRFunctionParameter:=clsGetGtTableFunction, iPosition:=0, bIncludeArgumentName:=False)

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

        ' For export operations which is an after code
        clsSaveGtRFunction.SetPackageName("gt")
        clsSaveGtRFunction.SetRCommand("gtsave")
        clsSaveGtRFunction.AddParameter(strParameterName:="data", clsROperatorParameter:=clsGtTableROperator, iPosition:=0)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrTablesSelector.SetRCode(clsGetGtTableFunction, bReset)
        ucrTablesReceiver.SetRCode(clsGetGtTableFunction, bReset)

        ucrSaveTable.SetRCode(clsBaseOperator, bReset)
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled(False)

        If Not ucrTablesReceiver.IsEmpty Then
            If ucrSaveTable.IsComplete Then
                ucrBase.OKEnabled(True)
            End If

            If ucrChkExport.Checked AndAlso Not ucrFilePath.IsEmpty Then
                ucrBase.OKEnabled(True)
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub btnTableOptions_Click(sender As Object, e As EventArgs) Handles btnTableOptions.Click
        sdgTableOptions.Setup(ucrTablesSelector.strCurrentDataFrame,
                              clsGtTableROperator, {
                              EnumTableSubDialogTab.Header, EnumTableSubDialogTab.Stub,
                              EnumTableSubDialogTab.Columns, EnumTableSubDialogTab.Rows,
                              EnumTableSubDialogTab.Cells, EnumTableSubDialogTab.SourceNotes,
                              EnumTableSubDialogTab.Themes, EnumTableSubDialogTab.OtherStyle,
                              EnumTableSubDialogTab.Table},
                              strTableName:=ucrTablesReceiver.GetVariableNames(bWithQuotes:=False))
        sdgTableOptions.ShowDialog(Me)
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrTablesReceiver.ControlContentsChanged, ucrSaveTable.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkExport_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkExport.ControlContentsChanged
        If ucrChkExport.Checked Then
            lblFileType.Visible = True
            cboFileType.Visible = True
            ucrFilePath.Visible = True
            ucrBase.clsRsyntax.AddToAfterCodes(clsSaveGtRFunction)
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
        ucrFilePath.FilePathDialogFilter = GetFilePathDialogFilterText(cboFileType.SelectedItem)
    End Sub

    Private Sub ucrFilePath_FilePathChanged() Handles ucrFilePath.FilePathChanged
        If Not ucrFilePath.IsEmpty Then
            Dim strFileName As String = Path.GetFileName(ucrFilePath.FilePath)
            Dim strFilePath As String = Path.GetDirectoryName(ucrFilePath.FilePath).Replace("\", "/")

            clsSaveGtRFunction.AddParameter("filename", Chr(34) & strFileName & Chr(34), iPosition:=1)
            clsSaveGtRFunction.AddParameter("path", Chr(34) & strFilePath & Chr(34), iPosition:=2)
        End If
        TestOKEnabled()
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
End Class