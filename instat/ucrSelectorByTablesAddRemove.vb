Imports System.ComponentModel

Public Class ucrSelectorByTablesAddRemove
    Public Overrides Sub LoadList()
        Debug.Print("LoadList called")

        lstAvailableVariable.Items.Clear()

        Debug.Print("SelectedDataFrame: " & ucrAvailableTables.SelectedDataFrame)
        Debug.Print("SelectedTable: " & ucrAvailableTables.SelectedTable)

        If ucrAvailableTables.SelectedDataFrame <> "" AndAlso ucrAvailableTables.SelectedTable <> "" Then
            Dim lstColNames As List(Of String) = frmMain.clsRLink.GetColumnNamesFromTable(
            strDataName:=ucrAvailableTables.SelectedDataFrame,
            strTableName:=ucrAvailableTables.SelectedTable
        )

            If lstColNames IsNot Nothing Then
                Debug.Print("Column names found: " & String.Join(", ", lstColNames))
                For Each strCol As String In lstColNames
                    lstAvailableVariable.Items.Add(strCol)
                Next
            Else
                Debug.Print("lstColNames is Nothing!")
            End If
        Else
            Debug.Print("One of the selectors is blank")
        End If
    End Sub


    Private Sub ucrAvailableTables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrAvailableTables.ControlValueChanged
        LoadList()
        OnControlValueChanged()
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

    Private Sub contextMenuStripAdd_Opening(sender As Object, e As CancelEventArgs) Handles contextMenuStripAdd.Opening
        If CurrentReceiver Is Nothing Then
            toolStripAddSelected.Enabled = False
            toolStripAddAll.Enabled = False
        Else
            toolStripAddSelected.Enabled = lstAvailableVariable.SelectedItems.Count > 0
            toolStripAddAll.Enabled = TypeOf CurrentReceiver Is ucrReceiverMultiple
        End If
    End Sub
End Class
