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
Public Class frmConvertToNumeric
    Private iNNonNumeric As Integer = 0
    Private strColumnName As String
    Private strDataFrameName As String
    Private bFirstLoad As Boolean = True

    Private Sub frmConvertToNumeric_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        cmdNormalConvert.DialogResult = DialogResult.Yes
        cmdLabelledConvert.DialogResult = DialogResult.No
        cmdCancel.DialogResult = DialogResult.Cancel
    End Sub

    Public Sub SetNonNumeric(iNumber As Integer)
        iNNonNumeric = iNumber
        lblN.Text = iNNonNumeric
    End Sub

    Public Sub SetColumnName(strName As String)
        strColumnName = strName
        lblColumnName.Text = strColumnName
    End Sub

    Public Sub SetDataFrameName(strDataFrame As String)
        strDataFrameName = strDataFrame
    End Sub

    Public Sub CheckLabels(bCheck As Boolean)
        If bCheck Then
            cmdLabelledConvert.Text = Translations.GetTranslation("Labelled Convert")
        Else
            cmdLabelledConvert.Text = Translations.GetTranslation("Ordinal Convert")
        End If
        lblOrdinal.Visible = Not bCheck
    End Sub

    Private Sub frmConvertToNumeric_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Me.DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        Help.ShowHelp(Me.Parent, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "614")
    End Sub

    Private Sub cmdInspectValues_Click(sender As Object, e As EventArgs) Handles cmdInspectValues.Click
        Me.Close()
        dlgFindNonnumericValues.SetCurrentColumn(strColumnName, strDataFrameName)
        dlgFindNonnumericValues.ShowDialog()
    End Sub
End Class