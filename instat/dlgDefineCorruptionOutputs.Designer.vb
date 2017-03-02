<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDefineCorruptionOutputs
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverCorruptionOutputs = New instat.ucrReceiverMultiple()
        Me.ucrSelectorCorruptionOutputs = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblCorruptionOutputs = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 216)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 3
        '
        'ucrReceiverCorruptionOutputs
        '
        Me.ucrReceiverCorruptionOutputs.frmParent = Me
        Me.ucrReceiverCorruptionOutputs.Location = New System.Drawing.Point(271, 60)
        Me.ucrReceiverCorruptionOutputs.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCorruptionOutputs.Name = "ucrReceiverCorruptionOutputs"
        Me.ucrReceiverCorruptionOutputs.Selector = Nothing
        Me.ucrReceiverCorruptionOutputs.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverCorruptionOutputs.TabIndex = 2
        '
        'ucrSelectorCorruptionOutputs
        '
        Me.ucrSelectorCorruptionOutputs.bShowHiddenColumns = False
        Me.ucrSelectorCorruptionOutputs.bUseCurrentFilter = True
        Me.ucrSelectorCorruptionOutputs.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorCorruptionOutputs.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCorruptionOutputs.Name = "ucrSelectorCorruptionOutputs"
        Me.ucrSelectorCorruptionOutputs.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorCorruptionOutputs.TabIndex = 0
        '
        'lblCorruptionOutputs
        '
        Me.lblCorruptionOutputs.AutoSize = True
        Me.lblCorruptionOutputs.Location = New System.Drawing.Point(268, 45)
        Me.lblCorruptionOutputs.Name = "lblCorruptionOutputs"
        Me.lblCorruptionOutputs.Size = New System.Drawing.Size(98, 13)
        Me.lblCorruptionOutputs.TabIndex = 1
        Me.lblCorruptionOutputs.Text = "Corruption Outputs:"
        '
        'dlgDefineCorruptionOutputs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 274)
        Me.Controls.Add(Me.lblCorruptionOutputs)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverCorruptionOutputs)
        Me.Controls.Add(Me.ucrSelectorCorruptionOutputs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDefineCorruptionOutputs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Define Corruption Outputs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverCorruptionOutputs As ucrReceiverMultiple
    Friend WithEvents ucrSelectorCorruptionOutputs As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblCorruptionOutputs As Label
End Class
