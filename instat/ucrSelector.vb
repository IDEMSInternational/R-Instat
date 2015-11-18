Imports RDotNet
Imports instat.Translations
Public Class ucrSelector
    Public CurrentReceiver As ucrReceiver

    Private Sub ucrdataselection_load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillListView()
    End Sub

    Public Sub SetCurrentReciever(conReceiver As ucrReceiver)
        CurrentReceiver = conReceiver
        If (TypeOf CurrentReceiver Is ucrReceiverSingle) Then
            'lstAvailableVariable.SelectionMode = SelectionMode.One
            lstAvailableVariable.MultiSelect = False
        ElseIf (TypeOf CurrentReceiver Is ucrReceiverMultiple) Then
            'lstAvailableVariable.SelectionMode = SelectionMode.MultiExtended
            lstAvailableVariable.MultiSelect = True
        End If
    End Sub
    'lstAvailableVariable.SelectedItems.Count > 0
    Public Sub Add()
        If (lstAvailableVariable.SelectedItems.Count > 0) Then
            CurrentReceiver.AddSelected()
            CurrentReceiver.Focus()
        Else
            MsgBox("No item was selected", vbInformation, "Selection message")
        End If
    End Sub

    Public Sub Remove()
        CurrentReceiver.RemoveSelected()
    End Sub
    Private Sub FillListView()
        Dim gvDataset, gvTemp As CharacterVector
        Dim dfTemp As DataFrame
        Dim grps As New ListViewGroup
        Dim i, j As Integer
        lstAvailableVariable.Columns.Add("Available Data", width:=100)
        gvDataset = frmMain.clsRInterface.GetVar("names(" & frmMain.clsRInterface.strInstatDataObject & "$get_variable_info())")
        For i = 0 To gvDataset.Count - 1
            grps = New ListViewGroup(gvDataset(i))
            lstAvailableVariable.Groups.Add(New ListViewGroup(gvDataset(i), HorizontalAlignment.Left))
            gvTemp = frmMain.clsRInterface.GetVar("as.character(" & frmMain.clsRInterface.strInstatDataObject & "$get_variable_info()$" & Chr(34) & gvDataset(i) & Chr(34) & "$Name)")
            For j = 0 To gvTemp.Count - 1
                lstAvailableVariable.Items.Add(gvTemp(j)).Group = lstAvailableVariable.Groups(i)
            Next

        Next
    End Sub
End Class