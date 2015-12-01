Imports RDotNet
Imports instat.Translations
Public Class ucrSelector
    Public CurrentReceiver As ucrReceiver

    Private Sub ucrdataselection_load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.clsRInterface.FillListView(lstAvailableVariable)
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
End Class