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
        Me.lblYVariate.AutoSize = True
        Me.lblYVariate.Location = New System.Drawing.Point(255, 25)
        Me.lblYVariate.Name = "lblYVariate"
        Me.lblYVariate.Size = New System.Drawing.Size(49, 13)
        Me.lblYVariate.TabIndex = 4
        Me.lblYVariate.Tag = "Y_Variate"
        Me.lblYVariate.Text = "Y-variate"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(255, 79)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(37, 13)
        Me.lblFactor.TabIndex = 5
        Me.lblFactor.Tag = "Factor"
        Me.lblFactor.Text = "Factor"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 201)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 3
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(255, 96)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFactor.TabIndex = 2
        '
        'ucrReceiverYVariate
        '
        Me.ucrReceiverYVariate.Location = New System.Drawing.Point(255, 42)
        Me.ucrReceiverYVariate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYVariate.Name = "ucrReceiverYVariate"
        Me.ucrReceiverYVariate.Selector = Nothing
        Me.ucrReceiverYVariate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYVariate.TabIndex = 1
        '
        'ucrDataFrameAddRemove
        '
        Me.ucrDataFrameAddRemove.bShowHiddenColumns = False
        Me.ucrDataFrameAddRemove.bUseCurrentFilter = False
        Me.ucrDataFrameAddRemove.Location = New System.Drawing.Point(10, 10)
        Me.ucrDataFrameAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameAddRemove.Name = "ucrDataFrameAddRemove"
        Me.ucrDataFrameAddRemove.Size = New System.Drawing.Size(210, 180)
        Me.ucrDataFrameAddRemove.TabIndex = 6
        '
        'dlgNon_ParametricOneWayANOVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 255)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Non_Parametric_One_Way_ANOVA"
        Me.Text = "Non-Parametric One Way ANOVA"
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
