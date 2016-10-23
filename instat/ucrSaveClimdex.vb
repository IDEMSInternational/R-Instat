Public Class ucrSaveClimdex
    Public Event SaveClimdexCheckedChanged()
    Public Event ClimdexNameChanged()
    Public bFirstLoad As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'ucrInputClimdexName.SetDefaultTypeAsGraph()
        'ucrInputClimdexName.SetItemsTypeAsGraphs()
        ucrInputClimdexName.SetValidationTypeAsRVariable()
        bFirstLoad = True
    End Sub

    Private Sub ucrSaveClimdex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Private Sub SetDefaults()
        chkSaveClimdex.Checked = False
        ucrInputClimdexName.Visible = False
    End Sub

    Public Sub Reset()
        SetDefaults()
    End Sub

    Public Sub SetDataFrameSelector(ucrNewDataFrameSelector As ucrDataFrame)
        ucrInputClimdexName.SetDataFrameSelector(ucrNewDataFrameSelector)
    End Sub
    Private Sub chkSaveClimdex_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveClimdex.CheckedChanged
        ucrInputClimdexName.Enabled = chkSaveClimdex.Checked
        ucrInputClimdexName.Visible = chkSaveClimdex.Checked
        RaiseEvent SaveClimdexCheckedChanged()
    End Sub

    Private Sub ucrInputClimdexName_NameChanged() Handles ucrInputClimdexName.NameChanged
        If chkSaveClimdex.Checked Then
            RaiseEvent ClimdexNameChanged()
        End If
    End Sub

    Public ReadOnly Property bSaveClimdex() As Boolean
        Get
            Return chkSaveClimdex.Checked
        End Get
    End Property

    Public ReadOnly Property strClimdexName() As String
        Get
            Return ucrInputClimdexName.GetText()
        End Get
    End Property

    Public WriteOnly Property strPrefix() As String
        Set(strNewPrefix As String)
            ucrInputClimdexName.SetPrefix(strNewPrefix)
        End Set
    End Property
End Class
