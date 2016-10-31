Public Class ucrSaveGraph
    Public Event SaveGraphCheckedChanged()
    Public Event GraphNameChanged()
    Public Event ContentsChanged()
    Public bFirstLoad As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ucrInputGraphName.SetDefaultTypeAsGraph()
        ucrInputGraphName.SetItemsTypeAsGraphs()
        ucrInputGraphName.SetValidationTypeAsRVariable()
        bFirstLoad = True
    End Sub

    Private Sub ucrSaveGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Private Sub SetDefaults()
        chkSaveGraph.Checked = False
        ucrInputGraphName.Visible = False
    End Sub

    Public Sub Reset()
        SetDefaults()
    End Sub

    Public Sub SetDataFrameSelector(ucrNewDataFrameSelector As ucrDataFrame)
        ucrInputGraphName.SetDataFrameSelector(ucrNewDataFrameSelector)
    End Sub
    Private Sub chkSaveGraph_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveGraph.CheckedChanged
        ucrInputGraphName.Enabled = chkSaveGraph.Checked
        ucrInputGraphName.Visible = chkSaveGraph.Checked
        RaiseEvent SaveGraphCheckedChanged()
    End Sub

    Private Sub ucrInputGraphName_NameChanged() Handles ucrInputGraphName.NameChanged
        If chkSaveGraph.Checked Then
            RaiseEvent GraphNameChanged()
        End If
    End Sub

    Private Sub ucrInputGraphName_ContentsChanged() Handles ucrInputGraphName.ContentsChanged
        RaiseEvent ContentsChanged()
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

    Public WriteOnly Property strPrefix() As String
        Set(strNewPrefix As String)
            ucrInputGraphName.SetPrefix(strNewPrefix)
        End Set
    End Property
End Class
