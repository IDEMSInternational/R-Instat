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
Imports System.Windows.Forms

Public Class ucrSelectorByDataFrameAddRemove
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, toolStripAddSelected.Click
        Add()
    End Sub

    Private Sub toolStripAddAll_Click(sender As Object, e As EventArgs) Handles toolStripAddAll.Click
        AddAll()
    End Sub

    Private Sub toolStripHelp_Click(sender As Object, e As EventArgs) Handles toolStripHelp.Click
        Help.ShowHelp(Me, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "334")
    End Sub

    Private Sub btnDataOptions_Click(sender As Object, e As EventArgs) Handles btnDataOptions.Click
        ShowDataOptionsDialog()
        If ParentForm IsNot Nothing Then
            For Each ctr In ParentForm.Controls
                If TypeOf ctr Is ucrSelector Then
                    ctr.LoadList()
                End If
            Next
        End If
    End Sub

    Public Sub ShowCheckBoxScalar(bShowScalarCheck As Boolean)
        checkBoxScalar.Visible = bShowScalarCheck
    End Sub

    Public Sub ResetCheckBoxScalar()
        checkBoxScalar.Checked = False
    End Sub

    Public Sub ShowColumnSelector(bShow As Boolean)
        btnAdd.Visible = bShow
        btnDataOptions.Visible = bShow
        lstAvailableVariable.Visible = bShow
    End Sub

    Public Overrides Sub SetVariablesEnabled(bEnable As Boolean)
        MyBase.SetVariablesEnabled(bEnable)
        btnAdd.Enabled = bEnable
        btnDataOptions.Enabled = bEnable
    End Sub

    Public Overrides Sub SetVariablesVisible(bVisible As Boolean)
        MyBase.SetVariablesVisible(bVisible)
        btnAdd.Visible = bVisible
        btnDataOptions.Visible = bVisible
    End Sub

    Public Overrides Sub EnableDataOptions(strCurrentType As String)
        If strCurrentType = "column" Then
            btnDataOptions.Enabled = True
        Else
            btnDataOptions.Enabled = False
        End If
    End Sub

    Public Sub HideShowAddOrDataOptionsOrListView(Optional bAddVisible As Boolean = True,
                                                  Optional bDataOptionsVisible As Boolean = True,
                                                  Optional bListVariables As Boolean = True)
        btnDataOptions.Visible = bDataOptionsVisible
        btnAdd.Visible = bAddVisible
        lstAvailableVariable.Visible = bListVariables
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

        ' Ensure context menu items are translated when the menu opens.
        ' Use the dedicated helper that translates ContextMenuStrip instances.
        Try
            Translations.autoTranslateContextMenu(contextMenuStripAdd)
            ' extra fallback: ensure specific items are translated if needed
            toolStripAddSelected.Text = Translations.GetTranslation(toolStripAddSelected.Text)
            toolStripAddAll.Text = Translations.GetTranslation(toolStripAddAll.Text)
            toolStripHelp.Text = Translations.GetTranslation(toolStripHelp.Text)
        Catch ex As Exception
            ' Non-fatal: don't prevent context menu from opening if translation fails.
            ' Optionally log the error for debugging:
            ' MsgBox("Translation error in contextMenuStripAdd_Opening: " & ex.Message)
        End Try
    End Sub
End Class