Imports instat.Translations
Public Class dlgDeleteRows
    Public bFirstLoad As Boolean = True
    Private Sub dlgDeleteRows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("subset")
        ucrReceiverDeleteRows.Selector = ucrAddRemove
        ucrReceiverDeleteRows.SetMeAsReceiver()
        autoTranslate(Me)
        ucrBase.iHelpTopicID = 53

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()

    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiverDeleteRows.IsEmpty() = True And lstRowsToDelete IsNot Nothing Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)

        End If

    End Sub
    Private Sub SetDefaults()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
    Private Sub ucrReceiverDeleteRows_Enter(sender As Object, e As EventArgs) Handles ucrReceiverDeleteRows.Enter
        ucrReceiverDeleteRows.SetMeAsReceiver()
    End Sub
    Private Sub ucrReceiverDeleteColumns_SelectionChanged() Handles ucrReceiverDeleteRows.SelectionChanged
        If Not ucrReceiverDeleteRows.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverDeleteRows.GetVariables())
        Else
            ucrBase.clsRsyntax.RemoveParameter("x")
        End If
    End Sub
    Private Sub lstRowsToDelete_Leave(sender As Object, e As EventArgs) Handles lstRowsToDelete.Leave
        If Not lstRowsToDelete IsNot Nothing Then
            ucrBase.clsRsyntax.AddParameter("select", Chr(34) & lstRowsToDelete.Text & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter("select")
        End If
    End Sub


End Class