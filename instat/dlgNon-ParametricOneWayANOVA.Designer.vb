<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgNon_ParametricOneWayANOVA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgNon_ParametricOneWayANOVA))
        Me.lblYVariate = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverYVariate = New instat.ucrReceiverSingle()
        Me.ucrDataFrameAddRemove = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblYVariate
        '
        resources.ApplyResources(Me.lblYVariate, "lblYVariate")
        Me.lblYVariate.Name = "lblYVariate"
        Me.lblYVariate.Tag = "Y_Variate"
        '
        'lblFactor
        '
        resources.ApplyResources(Me.lblFactor, "lblFactor")
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Tag = "Factor"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverFactor
        '
        resources.ApplyResources(Me.ucrReceiverFactor, "ucrReceiverFactor")
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        '
        'ucrReceiverYVariate
        '
        resources.ApplyResources(Me.ucrReceiverYVariate, "ucrReceiverYVariate")
        Me.ucrReceiverYVariate.Name = "ucrReceiverYVariate"
        Me.ucrReceiverYVariate.Selector = Nothing
        '
        'ucrDataFrameAddRemove
        '
        Me.ucrDataFrameAddRemove.bShowHiddenColumns = False
        Me.ucrDataFrameAddRemove.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrDataFrameAddRemove, "ucrDataFrameAddRemove")
        Me.ucrDataFrameAddRemove.Name = "ucrDataFrameAddRemove"
        '
        'dlgNon_ParametricOneWayANOVA
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrDataFrameAddRemove)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblYVariate)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrReceiverYVariate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgNon_ParametricOneWayANOVA"
        Me.Tag = "Non_Parametric_One_Way_ANOVA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverYVariate As ucrReceiverSingle
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblYVariate As Label
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrDataFrameAddRemove As ucrSelectorByDataFrameAddRemove
End Class
