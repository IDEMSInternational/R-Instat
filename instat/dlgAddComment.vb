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
Public Class dlgAddComment
    Dim bUseSelectedColumn As Boolean = False
    Dim strSelectedColumn As String = ""
    Dim strSelectedDataFrame As String = ""
    Public bFirstLoad As Boolean = True
    Private Sub dlgAddComment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        If bUseSelectedColumn Then
            SetDefaultColumn()
        End If
        TestOKEnabled()
    End Sub


    Public Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedColumn = True
    End Sub

    Private Sub SetDefaultColumn()
        ucrSelectorAddComment.SetDataframe(strSelectedDataFrame)
        ucrReceiverColumn.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 508
        ucrReceiverColumn.Selector = ucrSelectorAddComment
        ucrReceiverColumn.SetMeAsReceiver()
    End Sub
    Private Sub TestOKEnabled()

    End Sub

    Private Sub SetDefaults()
        'Setting Defaults
        ucrDataFrame.Visible = True
        ucrSelectorAddComment.Reset()
        ucrSelectorAddComment.Visible = False
        rdoRow.Checked = True
        rdoCell.Checked = False
        ucrReceiverRow.Enabled = False
        ucrReceiverColumn.Enabled = False
        lblColumn.Enabled = False
        lblRow.Enabled = False
        ucrInputComment.IsMultiline = True
    End Sub

    Private Sub rdoRow_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRow.CheckedChanged, rdoCell.CheckedChanged
        'Setting radio buttons events
        If rdoRow.Checked Then
            ucrDataFrame.Visible = True
            ucrSelectorAddComment.Visible = False
            ucrReceiverRow.Enabled = False
            lblColumn.Enabled = False
            lblRow.Enabled = False
        Else
            ucrReceiverRow.SetMeAsReceiver()
            ucrSelectorAddComment.Visible = True
            ucrReceiverRow.Enabled = True
            ucrReceiverColumn.Enabled = True
            ucrReceiverRow.Enabled = True
            lblColumn.Enabled = True
            lblRow.Enabled = True
            ucrDataFrame.Visible = False
        End If

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

End Class