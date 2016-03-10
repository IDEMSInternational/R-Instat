Public Class ucrSaveGraph
    Public Event CheckedChanged(bChecked As Boolean)
    Private Sub ucrSaveGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrInputGraphName.SetDefaultTypeAsGraph()
        ucrInputGraphName.SetItemsTypeAsGraphs()
    End Sub

    Private Sub chkSaveGraph_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveGraph.CheckedChanged
        If chkSaveGraph.Checked Then
            ucrInputGraphName.Visible = True
        Else
            ucrInputGraphName.Visible = False
        End If
        RaiseEvent CheckedChanged(chkSaveGraph.Checked)
    End Sub
End Class
