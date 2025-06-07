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

        ucrBase.clsRsyntax.ClearCodes()
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
        sdgTableOptionsAfter.Setup(ucrTablesSelector.strCurrentDataFrame, clsGtTableROperator)
        sdgTableOptionsAfter.ShowDialog()
        AddRemoveGetDataObjColumn()
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

    'Public Sub AddRemoveGetDataObjColumn()
    '    Dim clsGetDataObjFunction As New RFunction
    '    clsGetDataObjFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
    '    clsGetDataObjFunction.AddParameter("data_name", Chr(34) & sdgTableOptionsAfter.ucrColumns.ucrColumnLabels.ucrSelectorCols.strCurrentDataFrame & Chr(34))
    '    clsGetDataObjFunction.AddParameter("object_name", sdgTableOptionsAfter.ucrColumns.ucrColumnLabels.ucrReceiverSingleCol.GetVariableNames())
    '    clsGetDataObjFunction.SetAssignTo("last_table")

    '    Dim clsGetDataObjWidthFunction As New RFunction
    '    clsGetDataObjWidthFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
    '    clsGetDataObjWidthFunction.AddParameter("data_name", Chr(34) & sdgTableOptionsAfter.ucrColumns.ucrColumnWidth.ucrSelectorCols.strCurrentDataFrame & Chr(34))
    '    clsGetDataObjWidthFunction.AddParameter("object_name", sdgTableOptionsAfter.ucrColumns.ucrColumnWidth.ucrReceiverSingleCol.GetVariableNames())
    '    clsGetDataObjWidthFunction.SetAssignTo("last_table")

    '    Dim clsGetDataObjMissingFunction As New RFunction
    '    clsGetDataObjMissingFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
    '    clsGetDataObjMissingFunction.AddParameter("data_name", Chr(34) & sdgTableOptionsAfter.ucrColumns.ucrColumnMissingTexts.ucrSelectorCols.strCurrentDataFrame & Chr(34))
    '    clsGetDataObjMissingFunction.AddParameter("object_name", sdgTableOptionsAfter.ucrColumns.ucrColumnMissingTexts.ucrReceiverSingleCol.GetVariableNames())
    '    clsGetDataObjMissingFunction.SetAssignTo("last_table")

    '    Dim clsGetDataObjStyleFunction As New RFunction
    '    clsGetDataObjStyleFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
    '    clsGetDataObjStyleFunction.AddParameter("data_name", Chr(34) & sdgTableOptionsAfter.ucrColumns.ucrColumnMissingTexts.ucrSelectorCols.strCurrentDataFrame & Chr(34))
    '    clsGetDataObjStyleFunction.AddParameter("object_name", sdgTableOptionsAfter.ucrColumns.ucrColumnMissingTexts.ucrReceiverSingleCol.GetVariableNames())
    '    clsGetDataObjStyleFunction.SetAssignTo("last_table")

    '    Dim clsGetDataFootFunction As New RFunction
    '    clsGetDataFootFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
    '    clsGetDataFootFunction.AddParameter("data_name", Chr(34) & sdgTableOptionsAfter.ucrColumns.ucrColumnFootNote.ucrSelectorCols.strCurrentDataFrame & Chr(34))
    '    clsGetDataFootFunction.AddParameter("object_name", sdgTableOptionsAfter.ucrColumns.ucrColumnFootNote.ucrReceiverSingleCol.GetVariableNames())
    '    clsGetDataFootFunction.SetAssignTo("last_table")

    '    Dim clsGetDataObjSpannerFunction As New RFunction
    '    clsGetDataObjSpannerFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
    '    clsGetDataObjSpannerFunction.AddParameter("data_name", Chr(34) & sdgTableOptionsAfter.ucrColumns.ucrColumnSpanners.ucrSelectorCols.strCurrentDataFrame & Chr(34))
    '    clsGetDataObjSpannerFunction.AddParameter("object_name", sdgTableOptionsAfter.ucrColumns.ucrColumnSpanners.ucrReceiverSingleCol.GetVariableNames())
    '    clsGetDataObjSpannerFunction.SetAssignTo("last_table")

    '    Dim clsGetDataObjNanoFunction As New RFunction
    '    clsGetDataObjNanoFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
    '    clsGetDataObjNanoFunction.AddParameter("data_name", Chr(34) & sdgTableOptionsAfter.ucrColumns.ucrColumnNanoPlots.ucrSelectorCols.strCurrentDataFrame & Chr(34))
    '    clsGetDataObjNanoFunction.AddParameter("object_name", sdgTableOptionsAfter.ucrColumns.ucrColumnNanoPlots.ucrReceiverSingleCol.GetVariableNames())
    '    clsGetDataObjNanoFunction.SetAssignTo("last_table")
    '    ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjSpannerFunction)
    '    ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjStyleFunction)
    '    ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataFootFunction)
    '    ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjNanoFunction)
    '    ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjMissingFunction)
    '    ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjFunction)
    '    ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjWidthFunction)
    '    If sdgTableOptionsAfter.ucrColumns.rdoColLabel.Checked Then
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjSpannerFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjStyleFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataFootFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjNanoFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjMissingFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjWidthFunction)
    '        If Not sdgTableOptionsAfter.ucrColumns.ucrColumnLabels.ucrReceiverSingleCol.IsEmpty Then
    '            ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataObjFunction, iPosition:=0)
    '        Else
    '            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjFunction)
    '        End If
    '    ElseIf sdgTableOptionsAfter.ucrColumns.rdoColWidth.Checked Then
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjSpannerFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjStyleFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataFootFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjNanoFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjMissingFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjFunction)
    '        If Not sdgTableOptionsAfter.ucrColumns.ucrColumnWidth.ucrReceiverSingleCol.IsEmpty Then
    '            ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataObjWidthFunction, iPosition:=0)
    '        Else
    '            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjWidthFunction)
    '        End If
    '    ElseIf sdgTableOptionsAfter.ucrColumns.rdoColMissing.Checked Then
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjSpannerFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjStyleFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataFootFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjNanoFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjWidthFunction)
    '        If Not sdgTableOptionsAfter.ucrColumns.ucrColumnMissingTexts.ucrReceiverSingleCol.IsEmpty Then
    '            ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataObjMissingFunction, iPosition:=0)
    '        Else
    '            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjMissingFunction)
    '        End If
    '    ElseIf sdgTableOptionsAfter.ucrColumns.rdoColStyles.Checked Then
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjSpannerFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataFootFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjNanoFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjMissingFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjWidthFunction)
    '        If Not sdgTableOptionsAfter.ucrColumns.ucrColumnStyles.ucrReceiverSingleCol.IsEmpty Then
    '            ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataObjStyleFunction, iPosition:=0)
    '        Else
    '            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjStyleFunction)
    '        End If
    '    ElseIf sdgTableOptionsAfter.ucrColumns.rdoColFootNotes.Checked Then
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjSpannerFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjStyleFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjNanoFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjMissingFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjWidthFunction)
    '        If Not sdgTableOptionsAfter.ucrColumns.ucrColumnFootNote.ucrReceiverSingleCol.IsEmpty Then
    '            ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataFootFunction, iPosition:=0)
    '        Else
    '            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataFootFunction)
    '        End If
    '    ElseIf sdgTableOptionsAfter.ucrColumns.rdoColSpanners.Checked Then
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjStyleFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataFootFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjNanoFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjMissingFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjWidthFunction)
    '        If Not sdgTableOptionsAfter.ucrColumns.ucrColumnSpanners.ucrReceiverSingleCol.IsEmpty Then
    '            ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataObjSpannerFunction, iPosition:=0)
    '        Else
    '            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjSpannerFunction)
    '        End If
    '    ElseIf sdgTableOptionsAfter.ucrColumns.rdoColNanoPlot.Checked Then
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjSpannerFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjStyleFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataFootFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjMissingFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjFunction)
    '        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjWidthFunction)
    '        If Not sdgTableOptionsAfter.ucrColumns.ucrColumnNanoPlots.ucrReceiverSingleCol.IsEmpty Then
    '            ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataObjNanoFunction, iPosition:=0)
    '        Else
    '            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataObjNanoFunction)
    '        End If
    '    End If
    'End Sub
    Public Sub AddRemoveGetDataObjColumn()

        ' Étape 1 : Supprimer les fonctions get_object_data existantes
        Dim lstBeforeCodes As List(Of RCodeStructure) = ucrBase.clsRsyntax.GetBeforeCodes()

        ' Supprimer en commençant par la fin pour éviter les erreurs d'indexation
        For i As Integer = lstBeforeCodes.Count - 1 To 0 Step -1
            Dim clsFunc As RFunction = TryCast(lstBeforeCodes(i), RFunction)
            If clsFunc IsNot Nothing AndAlso clsFunc.strRCommand.Contains("get_object_data") Then
                ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsFunc)
            End If
        Next

        ' Étape 2 : Créer et ajouter la nouvelle fonction selon le bouton coché
        Dim clsGetDataObjFunction As New RFunction
        clsGetDataObjFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
        clsGetDataObjFunction.SetAssignTo("last_table")

        If sdgTableOptionsAfter.ucrColumns.rdoColLabel.Checked AndAlso Not sdgTableOptionsAfter.ucrColumns.ucrColumnLabels.ucrReceiverSingleCol.IsEmpty Then
            clsGetDataObjFunction.AddParameter("data_name", Chr(34) & sdgTableOptionsAfter.ucrColumns.ucrColumnLabels.ucrSelectorCols.strCurrentDataFrame & Chr(34))
            clsGetDataObjFunction.AddParameter("object_name", sdgTableOptionsAfter.ucrColumns.ucrColumnLabels.ucrReceiverSingleCol.GetVariableNames())
        ElseIf sdgTableOptionsAfter.ucrColumns.rdoColWidth.Checked AndAlso Not sdgTableOptionsAfter.ucrColumns.ucrColumnWidth.ucrReceiverSingleCol.IsEmpty Then
            clsGetDataObjFunction.AddParameter("data_name", Chr(34) & sdgTableOptionsAfter.ucrColumns.ucrColumnWidth.ucrSelectorCols.strCurrentDataFrame & Chr(34))
            clsGetDataObjFunction.AddParameter("object_name", sdgTableOptionsAfter.ucrColumns.ucrColumnWidth.ucrReceiverSingleCol.GetVariableNames())
        ElseIf sdgTableOptionsAfter.ucrColumns.rdoColMissing.Checked AndAlso Not sdgTableOptionsAfter.ucrColumns.ucrColumnMissingTexts.ucrReceiverSingleCol.IsEmpty Then
            clsGetDataObjFunction.AddParameter("data_name", Chr(34) & sdgTableOptionsAfter.ucrColumns.ucrColumnMissingTexts.ucrSelectorCols.strCurrentDataFrame & Chr(34))
            clsGetDataObjFunction.AddParameter("object_name", sdgTableOptionsAfter.ucrColumns.ucrColumnMissingTexts.ucrReceiverSingleCol.GetVariableNames())
        ElseIf sdgTableOptionsAfter.ucrColumns.rdoColStyles.Checked AndAlso Not sdgTableOptionsAfter.ucrColumns.ucrColumnStyles.ucrReceiverSingleCol.IsEmpty Then
            clsGetDataObjFunction.AddParameter("data_name", Chr(34) & sdgTableOptionsAfter.ucrColumns.ucrColumnStyles.ucrSelectorCols.strCurrentDataFrame & Chr(34))
            clsGetDataObjFunction.AddParameter("object_name", sdgTableOptionsAfter.ucrColumns.ucrColumnStyles.ucrReceiverSingleCol.GetVariableNames())
        ElseIf sdgTableOptionsAfter.ucrColumns.rdoColFootNotes.Checked AndAlso Not sdgTableOptionsAfter.ucrColumns.ucrColumnFootNote.ucrReceiverSingleCol.IsEmpty Then
            clsGetDataObjFunction.AddParameter("data_name", Chr(34) & sdgTableOptionsAfter.ucrColumns.ucrColumnFootNote.ucrSelectorCols.strCurrentDataFrame & Chr(34))
            clsGetDataObjFunction.AddParameter("object_name", sdgTableOptionsAfter.ucrColumns.ucrColumnFootNote.ucrReceiverSingleCol.GetVariableNames())
        ElseIf sdgTableOptionsAfter.ucrColumns.rdoColSpanners.Checked AndAlso Not sdgTableOptionsAfter.ucrColumns.ucrColumnSpanners.ucrReceiverSingleCol.IsEmpty Then
            clsGetDataObjFunction.AddParameter("data_name", Chr(34) & sdgTableOptionsAfter.ucrColumns.ucrColumnSpanners.ucrSelectorCols.strCurrentDataFrame & Chr(34))
            clsGetDataObjFunction.AddParameter("object_name", sdgTableOptionsAfter.ucrColumns.ucrColumnSpanners.ucrReceiverSingleCol.GetVariableNames())
        ElseIf sdgTableOptionsAfter.ucrColumns.rdoColNanoPlot.Checked AndAlso Not sdgTableOptionsAfter.ucrColumns.ucrColumnNanoPlots.ucrReceiverSingleCol.IsEmpty Then
            clsGetDataObjFunction.AddParameter("data_name", Chr(34) & sdgTableOptionsAfter.ucrColumns.ucrColumnNanoPlots.ucrSelectorCols.strCurrentDataFrame & Chr(34))
            clsGetDataObjFunction.AddParameter("object_name", sdgTableOptionsAfter.ucrColumns.ucrColumnNanoPlots.ucrReceiverSingleCol.GetVariableNames())
        Else
            Exit Sub
        End If

        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataObjFunction, iPosition:=0)
    End Sub
End Class