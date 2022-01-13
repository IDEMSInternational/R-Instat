<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgExtremesMethod
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
        Me.rdoLmoments = New System.Windows.Forms.RadioButton()
        Me.rdoBayesian = New System.Windows.Forms.RadioButton()
        Me.rdoGMLE = New System.Windows.Forms.RadioButton()
        Me.rdoMLE = New System.Windows.Forms.RadioButton()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.ucrPanelExtreme = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'rdoLmoments
        '
        Me.rdoLmoments.AutoSize = True
        Me.rdoLmoments.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLmoments.Location = New System.Drawing.Point(12, 101)
        Me.rdoLmoments.Name = "rdoLmoments"
        Me.rdoLmoments.Size = New System.Drawing.Size(76, 17)
        Me.rdoLmoments.TabIndex = 4
        Me.rdoLmoments.TabStop = True
        Me.rdoLmoments.Text = "L-moments"
        Me.rdoLmoments.UseVisualStyleBackColor = True
        '
        'rdoBayesian
        '
        Me.rdoBayesian.AutoSize = True
        Me.rdoBayesian.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBayesian.Location = New System.Drawing.Point(12, 78)
        Me.rdoBayesian.Name = "rdoBayesian"
        Me.rdoBayesian.Size = New System.Drawing.Size(68, 17)
        Me.rdoBayesian.TabIndex = 3
        Me.rdoBayesian.TabStop = True
        Me.rdoBayesian.Text = "Bayesian"
        Me.rdoBayesian.UseVisualStyleBackColor = True
        '
        'rdoGMLE
        '
        Me.rdoGMLE.AutoSize = True
        Me.rdoGMLE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGMLE.Location = New System.Drawing.Point(12, 42)
        Me.rdoGMLE.Name = "rdoGMLE"
        Me.rdoGMLE.Size = New System.Drawing.Size(206, 30)
        Me.rdoGMLE.TabIndex = 2
        Me.rdoGMLE.TabStop = True
        Me.rdoGMLE.Text = "General Maximum Likelihood Estimator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(GMLE)"
        Me.rdoGMLE.UseVisualStyleBackColor = True
        '
        'rdoMLE
        '
        Me.rdoMLE.AutoSize = True
        Me.rdoMLE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMLE.Location = New System.Drawing.Point(12, 19)
        Me.rdoMLE.Name = "rdoMLE"
        Me.rdoMLE.Size = New System.Drawing.Size(151, 17)
        Me.rdoMLE.TabIndex = 1
        Me.rdoMLE.TabStop = True
        Me.rdoMLE.Text = "Maximum Likelihood (MLE)"
        Me.rdoMLE.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.Location = New System.Drawing.Point(39, 124)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(224, 30)
        Me.ucrBase.TabIndex = 5
        '
        'ucrPanelExtreme
        '
        Me.ucrPanelExtreme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPanelExtreme.Location = New System.Drawing.Point(5, 11)
        Me.ucrPanelExtreme.Name = "ucrPanelExtreme"
        Me.ucrPanelExtreme.Size = New System.Drawing.Size(213, 119)
        Me.ucrPanelExtreme.TabIndex = 0
        '
        'sdgExtremesMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(230, 160)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.rdoLmoments)
        Me.Controls.Add(Me.rdoBayesian)
        Me.Controls.Add(Me.rdoGMLE)
        Me.Controls.Add(Me.rdoMLE)
        Me.Controls.Add(Me.ucrPanelExtreme)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgExtremesMethod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extremes Method"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents rdoLmoments As RadioButton
    Friend WithEvents rdoBayesian As RadioButton
    Friend WithEvents rdoGMLE As RadioButton
    Friend WithEvents rdoMLE As RadioButton
    Friend WithEvents ucrPanelExtreme As UcrPanel
End Class
