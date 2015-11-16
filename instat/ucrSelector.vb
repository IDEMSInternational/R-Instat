Imports RDotNet
Imports instat.Translations
Public Class ucrSelector
    Public CurrentReceiver As ucrReceiver

    Private Sub ucrdataselection_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cvdataset As CharacterVector
        Dim adataset As Array
        Dim i As Integer

        translateEach(Controls)
        cvdataset = frmMain.clsRInterface.GetVariables("colnames(data_temp)")
        adataset = cvdataset.ToArray
        For i = 0 To adataset.GetLength(0) - 1
            If Not lstAvailableVariable.Items.Contains(adataset(i)) Then
                lstAvailableVariable.Items.Add(adataset(i))
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
            CurrentReceiver.EnterReceiver()
        Else
            MsgBox("No item was selected", vbInformation, "Selection message")
        End If
    End Sub

    Public Sub Remove()
        CurrentReceiver.RemoveSelected()
    End Sub
End Class