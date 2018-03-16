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
    Public bUseSelectedColumn As Boolean = False
    Private strSelectedColumn As String = ""
    Private strSelectedDataFrame As String = ""
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgAddComment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
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
        If bUseSelectedColumn Then
            SetDefaultColumn()
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 508
        ucrReceiverColumn.Selector = ucrSelectorAddComment
        ucrReceiverColumn.SetMeAsReceiver()
        ucrReceiverRow.Selector = ucrSelectorAddComment
        ucrReceiverRow.SetMeAsReceiver()
        ucrPnlCellOrRow.AddRadioButton(rdoCell)
        ucrPnlCellOrRow.AddRadioButton(rdoRow)
        ucrPnlCellOrRow.AddToLinkedControls(ucrReceiverRow, {rdoRow}, bNewLinkedDisabledIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlCellOrRow.bAllowNonConditionValues = True
    End Sub

    Private Sub SetDefaults()
        ucrSelectorAddComment.Reset()
        ucrSelectorAddComment.Visible = False
        ucrInputComment.IsMultiline = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled(False) ' Temporary
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetDefaultColumn()
        rdoRow.Checked = True
        SetRCodeForControls(True)
        ucrSelectorAddComment.SetDataframe(strSelectedDataFrame)
        ucrReceiverColumn.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub

    Public Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedColumn = True
    End Sub

    Private Sub Control_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumn.ControlContentsChanged, ucrReceiverColumn.ControlContentsChanged, ucrInputComment.ControlContentsChanged, ucrPnlCellOrRow.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class