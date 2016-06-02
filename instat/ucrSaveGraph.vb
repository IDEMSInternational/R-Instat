Public Class ucrSaveGraph
    Public Event SaveGraphCheckedChanged()
    Public Event GraphNameChanged()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ucrInputGraphName.SetDefaultTypeAsGraph()
        ucrInputGraphName.SetItemsTypeAsGraphs()
    End Sub

    Public Sub SetDataFrameSelector(ucrNewDataFrameSelector As ucrDataFrame)
        ucrInputGraphName.SetDataFrameSelector(ucrNewDataFrameSelector)
    End Sub
    Private Sub chkSaveGraph_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveGraph.CheckedChanged
        If chkSaveGraph.Checked Then
            ucrInputGraphName.Enabled = True
        Else
            ucrInputGraphName.Enabled = False
        End If
        RaiseEvent SaveGraphCheckedChanged()
    End Sub

    Private Sub ucrInputGraphName_NameChanged() Handles ucrInputGraphName.NameChanged
        If chkSaveGraph.Checked Then
            RaiseEvent GraphNameChanged()
        End If
    End Sub

    Public ReadOnly Property bSaveGraph() As Boolean
        Get
            Return chkSaveGraph.Checked
        End Get
    End Property

    Public ReadOnly Property strGraphName() As String
        Get
            Return ucrInputGraphName.GetText()
        End Get
    End Property

End Class
