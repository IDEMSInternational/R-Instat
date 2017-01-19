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
    Public bFirstLoad As Boolean = True
    Private Sub dlgAddComment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 508
        ucrReceiverRow.Selector = ucrSelectorAddComment
    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub SetDefaults()
        rdoRow.Checked = True
        rdoCell.Checked = False
        ucrReceiverRow.Visible = False
        ucrReceiverColumn.Visible = False
        lblColumn.Visible = False
        lblRow.Visible = False
        ucrSelectorAddComment.Reset()
    End Sub

    Private Sub rdoRow_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRow.CheckedChanged, rdoCell.CheckedChanged
        SetRadioButtons()
    End Sub

    Private Sub ucrSelectorAddComment_DataFrameChanged() Handles ucrSelectorAddComment.DataFrameChanged

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub SetRadioButtons()
        If rdoRow.Checked Then
            ucrDataFrame.Visible = True
            ucrSelectorAddComment.Visible = False
            ucrReceiverRow.Visible = False
            lblColumn.Visible = False
            lblRow.Visible = False
        Else
            ucrReceiverRow.SetMeAsReceiver()
            ucrSelectorAddComment.Visible = True
            ucrReceiverRow.Visible = True
            ucrReceiverColumn.Visible = True
            ucrReceiverRow.Visible = True
            lblColumn.Visible = True
            lblRow.Visible = True
            ucrDataFrame.Visible = False
        End If
    End Sub
    Private Sub ucrReceiverKeyColumn_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverRow.SelectionChanged
        SetRadioButtons()
    End Sub
End Class