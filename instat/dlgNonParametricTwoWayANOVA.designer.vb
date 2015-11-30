<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgNonParametricTwoWayANOVA
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
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverCounts = New instat.ucrReceiverSingle()
        Me.ucrReceiverRowF = New instat.ucrReceiverSingle()
        Me.ucrReceiverColF = New instat.ucrReceiverSingle()
        Me.lblCounts = New System.Windows.Forms.Label()
        Me.lblRowF = New System.Windows.Forms.Label()
        Me.lblColumnFactor = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(13, 51)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 127)
        Me.ucrAddRemove.TabIndex = 0
        '
        'ucrReceiverCounts
        '
        Me.ucrReceiverCounts.Location = New System.Drawing.Point(259, 53)
        Me.ucrReceiverCounts.Name = "ucrReceiverCounts"
        Me.ucrReceiverCounts.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverCounts.TabIndex = 1
        '
        'ucrReceiverRowF
        '
        Me.ucrReceiverRowF.Location = New System.Drawing.Point(259, 106)
        Me.ucrReceiverRowF.Name = "ucrReceiverRowF"
        Me.ucrReceiverRowF.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverRowF.TabIndex = 2
        '
        'ucrReceiverColF
        '
        Me.ucrReceiverColF.Location = New System.Drawing.Point(259, 151)
        Me.ucrReceiverColF.Name = "ucrReceiverColF"
        Me.ucrReceiverColF.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverColF.TabIndex = 3
        '
        'lblCounts
        '
        Me.lblCounts.AutoSize = True
        Me.lblCounts.Location = New System.Drawing.Point(266, 40)
        Me.lblCounts.Name = "lblCounts"
        Me.lblCounts.Size = New System.Drawing.Size(40, 13)
        Me.lblCounts.TabIndex = 4
        Me.lblCounts.Tag = "Counts"
        Me.lblCounts.Text = "Counts"
        '
        'lblRowF
        '
        Me.lblRowF.AutoSize = True
        Me.lblRowF.Location = New System.Drawing.Point(265, 94)
        Me.lblRowF.Name = "lblRowF"
        Me.lblRowF.Size = New System.Drawing.Size(62, 13)
        Me.lblRowF.TabIndex = 5
        Me.lblRowF.Tag = "Row_Factor"
        Me.lblRowF.Text = "Row Factor"
        '
        'lblColumnFactor
        '
        Me.lblColumnFactor.AutoSize = True
        Me.lblColumnFactor.Location = New System.Drawing.Point(266, 139)
        Me.lblColumnFactor.Name = "lblColumnFactor"
        Me.lblColumnFactor.Size = New System.Drawing.Size(75, 13)
        Me.lblColumnFactor.TabIndex = 6
        Me.lblColumnFactor.Tag = "Column_Factor"
        Me.lblColumnFactor.Text = "Column Factor"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(3, 283)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 7
        '
        'dlgNonParametricOneWayANOVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 317)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblColumnFactor)
        Me.Controls.Add(Me.lblRowF)
        Me.Controls.Add(Me.lblCounts)
        Me.Controls.Add(Me.ucrReceiverColF)
        Me.Controls.Add(Me.ucrReceiverRowF)
        Me.Controls.Add(Me.ucrReceiverCounts)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Name = "dlgNonParametricOneWayANOVA"
        Me.Text = "dlgNon-Parametric Two Way ANOVA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverCounts As ucrReceiverSingle
    Friend WithEvents ucrReceiverRowF As ucrReceiverSingle
    Friend WithEvents ucrReceiverColF As ucrReceiverSingle
    Friend WithEvents lblCounts As Label
    Friend WithEvents lblRowF As Label
    Friend WithEvents lblColumnFactor As Label
    Friend WithEvents ucrBase As ucrButtons
End Class
