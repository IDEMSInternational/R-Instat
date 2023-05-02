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

Imports instat.Translations
Public Class dlgAddComment
    Private bUseSelectedPosition As Boolean = False
    Private strSelectedDataFrame As String = ""
    Private strSelectedRow As String = ""
    Private strSelectedColumn As String = ""
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsAddComment As New RFunction
    Private clsAddKeyFunction As New RFunction
    Private clsGetRowNamesFunction, clsInsertColumnFunction As New RFunction
    Private clsDummyFunction As New RFunction


    Private Sub dlgAddComment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        bReset = False
        SetRCodeForControls(bReset)
        If bUseSelectedPosition Then
            SetDefaultPosition()
        End If
        If bReset Then
            IdentifyKey()
        End If
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 508

        ucrPnlCellRowColumnDataFrame.AddRadioButton(rdoCell)
        ucrPnlCellRowColumnDataFrame.AddRadioButton(rdoRow)
        ucrPnlCellRowColumnDataFrame.AddRadioButton(rdoColumn)
        ucrPnlCellRowColumnDataFrame.AddRadioButton(rdoDataFrame)
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoCell, "column")
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoCell, "row")
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoRow, "row")
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoColumn, "column")
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoColumn, "row", False)
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoRow, "column", False)
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoDataFrame, "column", False)
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoDataFrame, "row", False)


        ucrPnlCellRowColumnDataFrame.AddToLinkedControls(ucrReceiverColumn, {rdoCell, rdoColumn}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlCellRowColumnDataFrame.AddToLinkedControls(ucrInputRow, {rdoCell, rdoRow}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrInputRow.SetLinkedDisplayControl(lblRow)
        ucrReceiverColumn.SetLinkedDisplayControl(lblColumn)

        ucrSelectorAddComment.SetParameter(New RParameter("data_name", 0))
        ucrSelectorAddComment.SetParameterIsString()

        ucrInputRow.SetParameter(New RParameter("row", iNewPosition:=1))
        ucrInputRow.SetValidationTypeAsNumeric()

        ucrReceiverColumn.Selector = ucrSelectorAddComment
        ucrReceiverColumn.SetParameter(New RParameter("column", iNewPosition:=2))
        ucrReceiverColumn.SetParameterIsString()

        ucrInputComment.SetParameter(New RParameter("comment", iNewPosition:=3))
        'ucrChkMakeColumnIntoKey
        ucrChkMakeColumnIntoKey.SetText("Make Row a Key for the Data Frame:")
        ucrChkMakeColumnIntoKey.AddParameterValuesCondition(True, "add_key", "True")
        ucrChkMakeColumnIntoKey.AddParameterValuesCondition(False, "add_key", "False")

    End Sub

    Private Sub SetDefaults()
        clsAddComment = New RFunction
        clsAddKeyFunction = New RFunction
        clsDummyFunction = New RFunction
        clsGetRowNamesFunction = New RFunction
        clsInsertColumnFunction = New RFunction


        ucrSelectorAddComment.Reset()
        ucrInputComment.IsMultiline = True
        IdentifyKey()
        ucrReceiverColumn.SetMeAsReceiver()
        clsDummyFunction.AddParameter("add_key", "True", iPosition:=0)

        clsGetRowNamesFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_row_names")
        clsGetRowNamesFunction.SetAssignTo("row")

        clsInsertColumnFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsInsertColumnFunction.AddParameter("before", "TRUE", iPosition:=0)
        clsInsertColumnFunction.AddParameter("col_data", "row", iPosition:=1)
        clsInsertColumnFunction.AddParameter("col_name", Chr(34) & "row" & Chr(34), iPosition:=2)


        clsAddKeyFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")
        clsAddKeyFunction.AddParameter("col_names", Chr(34) & "row" & Chr(34), iPosition:=1)


        clsAddComment.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_new_comment")
        ucrBase.clsRsyntax.SetBaseRFunction(clsAddComment)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorAddComment.AddAdditionalCodeParameterPair(clsAddKeyFunction, ucrSelectorAddComment.GetParameter, iAdditionalPairNo:=1)
        ucrSelectorAddComment.AddAdditionalCodeParameterPair(clsGetRowNamesFunction, ucrSelectorAddComment.GetParameter, iAdditionalPairNo:=2)
        ucrSelectorAddComment.AddAdditionalCodeParameterPair(clsInsertColumnFunction, ucrSelectorAddComment.GetParameter, iAdditionalPairNo:=3)

        ucrInputComment.SetRCode(clsAddComment, bReset)
        ucrReceiverColumn.SetRCode(clsAddComment, bReset)
        ucrInputRow.SetRCode(clsAddComment, bReset)
        ucrPnlCellRowColumnDataFrame.SetRCode(clsAddComment, bReset)
        ucrChkMakeColumnIntoKey.SetRCode(clsDummyFunction, bReset)
        ucrSelectorAddComment.SetRCode(clsAddComment, bReset)
        IdentifyKey()

    End Sub

    Private Sub TestOKEnabled()
        If (((rdoCell.Checked AndAlso Not ucrInputRow.IsEmpty AndAlso Not ucrReceiverColumn.IsEmpty) OrElse
           (rdoRow.Checked AndAlso Not ucrInputRow.IsEmpty) OrElse
           (rdoColumn.Checked AndAlso Not ucrReceiverColumn.IsEmpty) OrElse
           (rdoDataFrame.Checked)) AndAlso Not ucrInputComment.IsEmpty) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        IdentifyKey()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetDefaultPosition()
        ucrSelectorAddComment.SetDataframe(strSelectedDataFrame)
        ucrInputRow.SetName(strSelectedRow)
        If strSelectedColumn <> "" AndAlso strSelectedRow <> "" Then
            ucrReceiverColumn.Add(strSelectedColumn, strSelectedDataFrame)
            rdoCell.Checked = True
        ElseIf strSelectedColumn <> "" AndAlso strSelectedRow = "" Then
            ucrReceiverColumn.Add(strSelectedColumn, strSelectedDataFrame)
            rdoColumn.Checked = True
        ElseIf strSelectedColumn = "" AndAlso strSelectedRow <> "" Then
            rdoRow.Checked = True
        Else
            rdoDataFrame.Checked = True
        End If
        strSelectedDataFrame = ""
        strSelectedRow = ""
        strSelectedColumn = ""
        bUseSelectedPosition = False
    End Sub

    Public Sub SetPosition(strDataFrame As String, Optional strRow As String = "", Optional strColumn As String = "")
        strSelectedDataFrame = strDataFrame
        strSelectedRow = strRow
        strSelectedColumn = strColumn
        bUseSelectedPosition = True
    End Sub

    Private Sub AddRemoveKeyFromAfterCodes()

        ucrBase.clsRsyntax.ClearCodes()

        If ucrChkMakeColumnIntoKey.Checked Then
            ucrBase.clsRsyntax.AddToBeforeCodes(clsGetRowNamesFunction, iPosition:=0)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsInsertColumnFunction, iPosition:=1)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsAddKeyFunction, iPosition:=2)
        Else
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetRowNamesFunction)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsInsertColumnFunction)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsAddKeyFunction)
        End If
        ucrBase.clsRsyntax.SetBaseRFunction(clsAddComment)

    End Sub

    Private Sub IdentifyKey()
        If frmMain.clsRLink.IsVariablesMetadata(ucrSelectorAddComment.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Is_Key") Then
            ucrChkMakeColumnIntoKey.Enabled = False
            ucrChkMakeColumnIntoKey.Checked = False
        Else
            ucrChkMakeColumnIntoKey.Enabled = True
            ucrChkMakeColumnIntoKey.Checked = True
        End If
    End Sub

    Private Sub ucrChkMakeColumnIntoKey_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMakeColumnIntoKey.ControlValueChanged
        AddRemoveKeyFromAfterCodes()
        IdentifyKey()
    End Sub

    Private Sub ucrPnlCellRowColumnDataFrame_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlCellRowColumnDataFrame.ControlValueChanged
        ucrSelectorAddComment.ShowColumnSelector(rdoCell.Checked OrElse rdoColumn.Checked)

        AddRemoveKeyFromAfterCodes()
        IdentifyKey()
    End Sub

    Private Sub Control_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumn.ControlContentsChanged, ucrInputRow.ControlContentsChanged, ucrInputComment.ControlContentsChanged, ucrPnlCellRowColumnDataFrame.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorAddComment_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorAddComment.ControlValueChanged
        IdentifyKey()
    End Sub

    Private Sub ucrSelectorAddComment_DataFrameChanged() Handles ucrSelectorAddComment.DataFrameChanged
        IdentifyKey()
    End Sub
End Class