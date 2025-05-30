Imports System.ComponentModel

Public Class ucrSelectorByTablesAddRemove
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, toolStripAddSelected.Click
        Add()
    End Sub

    Private Sub toolStripAddAll_Click(sender As Object, e As EventArgs) Handles toolStripAddAll.Click
        AddAll()
    End Sub

    Private Sub toolStripHelp_Click(sender As Object, e As EventArgs) Handles toolStripHelp.Click
        Help.ShowHelp(Me, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "334")
    End Sub

    Public Sub ShowColumnSelector(bShow As Boolean)
        btnAdd.Visible = bShow
        lstAvailableVariable.Visible = bShow
    End Sub

    Public Overrides Sub SetVariablesEnabled(bEnable As Boolean)
        MyBase.SetVariablesEnabled(bEnable)
        btnAdd.Enabled = bEnable
    End Sub

    Public Overrides Sub SetVariablesVisible(bVisible As Boolean)
        MyBase.SetVariablesVisible(bVisible)
        btnAdd.Visible = bVisible
    End Sub

    Public Sub HideShowAddOrDataOptionsOrListView(Optional bAddVisible As Boolean = True,
                                                  Optional bDataOptionsVisible As Boolean = True,
                                                  Optional bListVariables As Boolean = True)
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
    End Sub
End Class
