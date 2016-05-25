Public Class ucrSaveGraph
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ucrInputGraphName.SetDefaultTypeAsGraph()
        ucrInputGraphName.SetItemsTypeAsGraphs()
    End Sub

    Public Event CheckedChanged(bChecked As Boolean)

    Private Sub chkSaveGraph_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveGraph.CheckedChanged
        If chkSaveGraph.Checked Then
            ucrInputGraphName.Visible = True
        Else
            ucrInputGraphName.Visible = False
        End If
        RaiseEvent CheckedChanged(chkSaveGraph.Checked)
    End Sub
End Class
