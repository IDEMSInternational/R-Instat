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
        Me.ucrReceiverCorruptionOutput = New instat.ucrReceiverMultiple()
        Me.ucrSelectorCorruptionOutput = New instat.ucrSelectorByDataFrameAddRemove()
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
        'ucrReceiverCorruptionOutput
        '
        Me.ucrReceiverCorruptionOutput.frmParent = Me
        Me.ucrReceiverCorruptionOutput.Location = New System.Drawing.Point(271, 60)
        Me.ucrReceiverCorruptionOutput.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCorruptionOutput.Name = "ucrReceiverCorruptionOutput"
        Me.ucrReceiverCorruptionOutput.Selector = Nothing
        Me.ucrReceiverCorruptionOutput.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverCorruptionOutput.TabIndex = 2
        '
        'ucrSelectorCorruptionOutput
        '
        Me.ucrSelectorCorruptionOutput.bShowHiddenColumns = False
        Me.ucrSelectorCorruptionOutput.bUseCurrentFilter = True
        Me.ucrSelectorCorruptionOutput.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorCorruptionOutput.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCorruptionOutput.Name = "ucrSelectorCorruptionOutput"
        Me.ucrSelectorCorruptionOutput.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorCorruptionOutput.TabIndex = 0
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
        Me.Controls.Add(Me.ucrReceiverCorruptionOutput)
        Me.Controls.Add(Me.ucrSelectorCorruptionOutput)
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
    Friend WithEvents ucrReceiverCorruptionOutput As ucrReceiverMultiple
    Friend WithEvents ucrSelectorCorruptionOutput As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblCorruptionOutputs As Label
End Class
