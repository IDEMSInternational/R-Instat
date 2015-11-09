Imports RDotNet
Imports instat.Translations
Public Class ucrSelector
    Public CurrentReceiver As ucrReceiver

    Private Sub ucrDataSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cvDataset As CharacterVector
        Dim aDataset As Array
        Dim i As Integer

        translateEach(Controls)
        cvDataset = frmMain.clsRInterface.GetVariables("colnames(data)")
        aDataset = cvDataset.ToArray
        For i = 0 To aDataset.GetLength(0) - 1
            If Not lstAvailableVariable.Items.Contains(aDataset(i)) Then
                lstAvailableVariable.Items.Add(aDataset(i))
            End If
        Next
    End Sub

    Public Sub SetCurrentReciever(conReceiver As ucrReceiver)
        CurrentReceiver = conReceiver
        If (TypeOf CurrentReceiver Is ucrReceiverSingle) Then
            lstAvailableVariable.SelectionMode = SelectionMode.One
        ElseIf (TypeOf CurrentReceiver Is ucrReceiverMultiple) Then
            lstAvailableVariable.SelectionMode = SelectionMode.MultiExtended
        End If
    End Sub

    Public Sub Add()
        If (lstAvailableVariable.SelectedItems.Count > 0) Then
            CurrentReceiver.AddSelected()
        Else
            MsgBox("No item was selected", vbInformation, "Selection message")
        End If
    End Sub

    Public Sub Remove()
        CurrentReceiver.RemoveSelected()
    End Sub
End Class