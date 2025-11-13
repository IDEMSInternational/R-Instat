Imports System.ComponentModel

Public Class ucrSelectorByOutputObject

    Public Overrides Sub LoadList()
        If CurrentReceiver Is Nothing Then
            lblObjectTypeLabel.Text = ""
            txtObjectName.Text = ""
        Else
            lblObjectTypeLabel.Text = "Table:" 'TODO. This can be expanded to graph and other output object types later
            txtObjectName.Text = CurrentReceiver.strObjectName
        End If
        MyBase.LoadList()
    End Sub

    Public Overrides Sub SetDataframe(strDataframe As String, Optional bEnableDataframe As Boolean = True, Optional bSilent As Boolean = False)
        strCurrentDataFrame = strDataframe
        If CurrentReceiver Is Nothing OrElse CurrentReceiver.bAttachedToPrimaryDataFrame Then
            strPrimaryDataFrame = strCurrentDataFrame
        End If
        'LoadList()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, toolStripAddSelected.Click
        Add()
    End Sub

    Private Sub toolStripAddAll_Click(sender As Object, e As EventArgs) Handles toolStripAddAll.Click
        AddAll()
    End Sub

    Private Sub toolStripHelp_Click(sender As Object, e As EventArgs) Handles toolStripHelp.Click
        Help.ShowHelp(Me, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "334")
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
