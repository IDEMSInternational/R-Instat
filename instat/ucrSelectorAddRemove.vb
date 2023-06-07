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

Imports System.ComponentModel
Public Class ucrSelectorAddRemove
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, toolStripAddSelected.Click
        Add()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        'call 
        ShowDataOptionsDialog()
    End Sub

    Public Overrides Sub EnableDataOptions(strCurrentType As String)
        If strCurrentType = "column" Then
            cmdOptions.Enabled = True
        Else
            cmdOptions.Enabled = False
        End If
    End Sub

    Private Sub contextMenuStripAdd_Opening(sender As Object, e As CancelEventArgs) Handles contextMenuStripAdd.Opening
        'todo. this code block should be set under CurrentReceiver change event
        'once the event is added it can be removed from here.
        If CurrentReceiver Is Nothing Then
            toolStripAddSelected.Enabled = False
            toolStripAddAll.Enabled = False
        Else
            toolStripAddSelected.Enabled = lstAvailableVariable.SelectedItems.Count > 0
            toolStripAddAll.Enabled = TypeOf CurrentReceiver Is ucrReceiverMultiple
        End If
    End Sub

    Private Sub toolStripAddAll_Click(sender As Object, e As EventArgs) Handles toolStripAddAll.Click
        AddAll()
    End Sub

    Private Sub toolStripHelp_Click(sender As Object, e As EventArgs) Handles toolStripHelp.Click
        Help.ShowHelp(Me, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "334")
    End Sub
End Class
