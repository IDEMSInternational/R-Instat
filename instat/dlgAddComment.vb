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
    Public bUseSelectedPosition As Boolean = False
    Private strSelectedDataFrame As String = ""
    Private strSelectedRow As String = ""
    Private strSelectedColumn As String = ""
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsAddComment As RFunction

    Private Sub dlgAddComment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        bReset = False
        autoTranslate(Me)
        SetRCodeForControls(bReset)
        If bUseSelectedPosition Then
            SetDefaultPosition()
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 508

        ucrPnlCellOrRow.AddRadioButton(rdoCell)
        ucrPnlCellOrRow.AddRadioButton(rdoRow)
        ucrPnlCellOrRow.AddParameterPresentCondition(rdoCell, "column", True)
        ucrPnlCellOrRow.AddParameterPresentCondition(rdoRow, "column", False)
        ucrPnlCellOrRow.AddToLinkedControls(ucrReceiverColumn, {rdoCell}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrSelectorAddComment.SetParameter(New RParameter("data_name", 0))
        ucrSelectorAddComment.SetParameterIsString()

        ucrInputRow.SetParameter(New RParameter("row", iNewPosition:=1))
        ucrInputRow.SetValidationTypeAsNumeric()

        ucrReceiverColumn.Selector = ucrSelectorAddComment
        ucrReceiverColumn.SetParameter(New RParameter("column", iNewPosition:=2))
        ucrReceiverColumn.SetParameterIsString()
        ucrReceiverColumn.SetLinkedDisplayControl(lblColumn)

        ucrInputComment.SetParameter(New RParameter("comment", iNewPosition:=3))
    End Sub

    Private Sub SetDefaults()
        clsAddComment = New RFunction

        ucrSelectorAddComment.Reset()
        ucrInputComment.IsMultiline = True

        ucrReceiverColumn.SetMeAsReceiver()

        clsAddComment.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_new_comment")
        ucrBase.clsRsyntax.SetBaseRFunction(clsAddComment)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrInputRow.IsEmpty() AndAlso Not ucrInputComment.IsEmpty AndAlso (Not ucrReceiverColumn.IsEmpty OrElse rdoRow.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetDefaultPosition()
        ucrSelectorAddComment.SetDataframe(strSelectedDataFrame)
        ucrInputRow.SetName(strSelectedRow)
        If strSelectedColumn <> "" Then
            ucrReceiverColumn.Add(strSelectedColumn, strSelectedDataFrame)
            rdoCell.Checked = True
        Else
            rdoRow.Checked = True
        End If
        strSelectedDataFrame = ""
        strSelectedRow = ""
        strSelectedColumn = ""
        bUseSelectedPosition = False
    End Sub

    Public Sub SetPosition(strDataFrame As String, strRow As String, Optional strColumn As String = "")
        strSelectedDataFrame = strDataFrame
        strSelectedRow = strRow
        strSelectedColumn = strColumn
        bUseSelectedPosition = True
    End Sub

    Private Sub Control_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumn.ControlContentsChanged, ucrInputRow.ControlContentsChanged, ucrInputComment.ControlContentsChanged, ucrPnlCellOrRow.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlCellOrRow_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlCellOrRow.ControlValueChanged
        ucrSelectorAddComment.ShowColumnSelector(rdoCell.Checked)
    End Sub
End Class