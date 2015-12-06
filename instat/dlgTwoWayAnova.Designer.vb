<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTwoWayAnova
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverCounts = New instat.ucrReceiverSingle()
        Me.ucrReceiverRowFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverColumnFactor = New instat.ucrReceiverSingle()
        Me.lblCounts = New System.Windows.Forms.Label()
        Me.lblRowFactor = New System.Windows.Forms.Label()
        Me.lblColumnFactor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(2, 237)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(2, 24)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 127)
        Me.ucrAddRemove.TabIndex = 1
        '
        'ucrReceiverCounts
        '
        Me.ucrReceiverCounts.Location = New System.Drawing.Point(255, 40)
        Me.ucrReceiverCounts.Name = "ucrReceiverCounts"
        Me.ucrReceiverCounts.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverCounts.TabIndex = 2
        '
        'ucrReceiverRowFactor
        '
        Me.ucrReceiverRowFactor.Location = New System.Drawing.Point(255, 83)
        Me.ucrReceiverRowFactor.Name = "ucrReceiverRowFactor"
        Me.ucrReceiverRowFactor.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverRowFactor.TabIndex = 3
        '
        'ucrReceiverColumnFactor
        '
        Me.ucrReceiverColumnFactor.Location = New System.Drawing.Point(255, 125)
        Me.ucrReceiverColumnFactor.Name = "ucrReceiverColumnFactor"
        Me.ucrReceiverColumnFactor.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverColumnFactor.TabIndex = 4
        '
        'lblCounts
        '
        Me.lblCounts.AutoSize = True
        Me.lblCounts.Location = New System.Drawing.Point(261, 28)
        Me.lblCounts.Name = "lblCounts"
        Me.lblCounts.Size = New System.Drawing.Size(40, 13)
        Me.lblCounts.TabIndex = 5
        Me.lblCounts.Tag = "Counts"
        Me.lblCounts.Text = "Counts"
        '
        'lblRowFactor
        '
        Me.lblRowFactor.AutoSize = True
        Me.lblRowFactor.Location = New System.Drawing.Point(261, 71)
        Me.lblRowFactor.Name = "lblRowFactor"
        Me.lblRowFactor.Size = New System.Drawing.Size(59, 13)
        Me.lblRowFactor.TabIndex = 6
        Me.lblRowFactor.Tag = "Row_factor"
        Me.lblRowFactor.Text = "Row factor"
        '
        'lblColumnFactor
        '
        Me.lblColumnFactor.AutoSize = True
        Me.lblColumnFactor.Location = New System.Drawing.Point(261, 113)
        Me.lblColumnFactor.Name = "lblColumnFactor"
        Me.lblColumnFactor.Size = New System.Drawing.Size(72, 13)
        Me.lblColumnFactor.TabIndex = 7
        Me.lblColumnFactor.Tag = "Column_factor"
        Me.lblColumnFactor.Text = "Column factor"
        '
        'dlgTwoWayAnova
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 270)
        Me.Controls.Add(Me.lblColumnFactor)
        Me.Controls.Add(Me.lblRowFactor)
        Me.Controls.Add(Me.lblCounts)
        Me.Controls.Add(Me.ucrReceiverColumnFactor)
        Me.Controls.Add(Me.ucrReceiverRowFactor)
        Me.Controls.Add(Me.ucrReceiverCounts)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.Name = "dlgTwoWayAnova"
        Me.Text = "Non Two Way ANOVA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverCounts As ucrReceiverSingle
    Friend WithEvents ucrReceiverRowFactor As ucrReceiverSingle
    Friend WithEvents ucrReceiverColumnFactor As ucrReceiverSingle
    Friend WithEvents lblCounts As Label
    Friend WithEvents lblRowFactor As Label
    Friend WithEvents lblColumnFactor As Label
End Class
