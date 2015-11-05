Imports RDotNet
Public Class ucrSelector
    'Public CurrentReceiver As ucrReceiver

    Private Sub ucrDataSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cvdataset As CharacterVector
        Dim adataset As Array
        Dim i As Integer

        cvdataset = frmMain.clsRInterface.GetVariables("colnames(data)")
        adataset = cvdataset.ToArray
        For i = 0 To adataset.GetLength(0) - 1
            lstAvailableVariable.Items.Add(adataset(i))
        Next

    End Sub

    'Public Sub SetCurrentReciever(conReceiver As ucrReceiver)
    'CurrentReceiver = conReceiver
    'If (TypeOf conReceiver Is ucrReceiverSingle) Then
    '    lstAvailableVariable.SelectionMode = SelectionMode.MultiExtended
    'ElseIf (TypeOf conReceiver Is ucrReceiverMultiple) Then
    '    lstAvailableVariable.SelectionMode = SelectionMode.One
    'End If
    'End Sub

    'Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    '    If (lstAvailableVariable.SelectedItem <> "") Then
    '        CurrentReceiver.AddSelected(lstAvailableVariable.SelectedItems)
    '        lstAvailableVariable.Items.Remove(lstAvailableVariable.SelectedItem)

    '    Else
    '        MsgBox("No item was selected", vbInformation, "Selection message")
    '    End If
    'End Sub

    'Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
    '    If (lstSelectedVariables.SelectedItem <> "") Then
    '        lstAvailableVariable.Items.Add(lstSelectedVariables.SelectedItem)
    '        lstSelectedVariables.Items.Remove(lstSelectedVariables.SelectedItem)
    '    Else
    '        MsgBox("No item was selected", vbInformation, "Selection message")
    '    End If
    'End Sub

    Private Sub lstAvailableVariable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAvailableVariable.SelectedIndexChanged

    End Sub
End Class