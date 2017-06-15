<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgAddNewDistribution
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
        Me.ucrBaseSubDialog = New instat.ucrButtonsSubdialogue()
        Me.ucrNewDistributions = New instat.ucrDistributionsWithParameters()
        Me.grpChangeLimits = New System.Windows.Forms.GroupBox()
        Me.nudYlimUpper = New System.Windows.Forms.NumericUpDown()
        Me.nudXlimUpper = New System.Windows.Forms.NumericUpDown()
        Me.nudYlimLower = New System.Windows.Forms.NumericUpDown()
        Me.nudXlimLower = New System.Windows.Forms.NumericUpDown()
        Me.lblYlim = New System.Windows.Forms.Label()
        Me.lblXlim = New System.Windows.Forms.Label()
        Me.grpPlot = New System.Windows.Forms.GroupBox()
        Me.rdoProbability = New System.Windows.Forms.RadioButton()
        Me.rdoDensity = New System.Windows.Forms.RadioButton()
        Me.cmdAddDistribution = New System.Windows.Forms.Button()
        Me.lstAddedDistribution = New System.Windows.Forms.ListBox()
        Me.lblAddedDistribution = New System.Windows.Forms.Label()
        Me.grpChangeLimits.SuspendLayout()
        CType(Me.nudYlimUpper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudXlimUpper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudYlimLower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudXlimLower, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPlot.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBaseSubDialog
        '
        Me.ucrBaseSubDialog.Location = New System.Drawing.Point(13, 344)
        Me.ucrBaseSubDialog.Name = "ucrBaseSubDialog"
        Me.ucrBaseSubDialog.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSubDialog.TabIndex = 6
        '
        'ucrNewDistributions
        '
        Me.ucrNewDistributions.Location = New System.Drawing.Point(12, 12)
        Me.ucrNewDistributions.Name = "ucrNewDistributions"
        Me.ucrNewDistributions.Size = New System.Drawing.Size(253, 194)
        Me.ucrNewDistributions.TabIndex = 0
        '
        'grpChangeLimits
        '
        Me.grpChangeLimits.Controls.Add(Me.nudYlimUpper)
        Me.grpChangeLimits.Controls.Add(Me.nudXlimUpper)
        Me.grpChangeLimits.Controls.Add(Me.nudYlimLower)
        Me.grpChangeLimits.Controls.Add(Me.nudXlimLower)
        Me.grpChangeLimits.Controls.Add(Me.lblYlim)
        Me.grpChangeLimits.Controls.Add(Me.lblXlim)
        Me.grpChangeLimits.Location = New System.Drawing.Point(13, 198)
        Me.grpChangeLimits.Name = "grpChangeLimits"
        Me.grpChangeLimits.Size = New System.Drawing.Size(200, 71)
        Me.grpChangeLimits.TabIndex = 1
        Me.grpChangeLimits.TabStop = False
        Me.grpChangeLimits.Text = "Change Limits"
        '
        'nudYlimUpper
        '
        Me.nudYlimUpper.Location = New System.Drawing.Point(137, 43)
        Me.nudYlimUpper.Name = "nudYlimUpper"
        Me.nudYlimUpper.Size = New System.Drawing.Size(42, 20)
        Me.nudYlimUpper.TabIndex = 5
        '
        'nudXlimUpper
        '
        Me.nudXlimUpper.Location = New System.Drawing.Point(137, 16)
        Me.nudXlimUpper.Name = "nudXlimUpper"
        Me.nudXlimUpper.Size = New System.Drawing.Size(42, 20)
        Me.nudXlimUpper.TabIndex = 4
        '
        'nudYlimLower
        '
        Me.nudYlimLower.Location = New System.Drawing.Point(78, 43)
        Me.nudYlimLower.Name = "nudYlimLower"
        Me.nudYlimLower.Size = New System.Drawing.Size(42, 20)
        Me.nudYlimLower.TabIndex = 3
        '
        'nudXlimLower
        '
        Me.nudXlimLower.Location = New System.Drawing.Point(78, 16)
        Me.nudXlimLower.Name = "nudXlimLower"
        Me.nudXlimLower.Size = New System.Drawing.Size(42, 20)
        Me.nudXlimLower.TabIndex = 2
        '
        'lblYlim
        '
        Me.lblYlim.AutoSize = True
        Me.lblYlim.Location = New System.Drawing.Point(7, 46)
        Me.lblYlim.Name = "lblYlim"
        Me.lblYlim.Size = New System.Drawing.Size(26, 13)
        Me.lblYlim.TabIndex = 1
        Me.lblYlim.Text = "Ylim"
        '
        'lblXlim
        '
        Me.lblXlim.AutoSize = True
        Me.lblXlim.Location = New System.Drawing.Point(7, 20)
        Me.lblXlim.Name = "lblXlim"
        Me.lblXlim.Size = New System.Drawing.Size(26, 13)
        Me.lblXlim.TabIndex = 0
        Me.lblXlim.Text = "Xlim"
        '
        'grpPlot
        '
        Me.grpPlot.Controls.Add(Me.rdoProbability)
        Me.grpPlot.Controls.Add(Me.rdoDensity)
        Me.grpPlot.Location = New System.Drawing.Point(13, 276)
        Me.grpPlot.Name = "grpPlot"
        Me.grpPlot.Size = New System.Drawing.Size(200, 36)
        Me.grpPlot.TabIndex = 2
        Me.grpPlot.TabStop = False
        Me.grpPlot.Text = "Plot"
        '
        'rdoProbability
        '
        Me.rdoProbability.AutoSize = True
        Me.rdoProbability.Location = New System.Drawing.Point(104, 15)
        Me.rdoProbability.Name = "rdoProbability"
        Me.rdoProbability.Size = New System.Drawing.Size(73, 17)
        Me.rdoProbability.TabIndex = 1
        Me.rdoProbability.TabStop = True
        Me.rdoProbability.Text = "Probability"
        Me.rdoProbability.UseVisualStyleBackColor = True
        '
        'rdoDensity
        '
        Me.rdoDensity.AutoSize = True
        Me.rdoDensity.Location = New System.Drawing.Point(7, 15)
        Me.rdoDensity.Name = "rdoDensity"
        Me.rdoDensity.Size = New System.Drawing.Size(60, 17)
        Me.rdoDensity.TabIndex = 0
        Me.rdoDensity.TabStop = True
        Me.rdoDensity.Text = "Density"
        Me.rdoDensity.UseVisualStyleBackColor = True
        '
        'cmdAddDistribution
        '
        Me.cmdAddDistribution.Location = New System.Drawing.Point(13, 315)
        Me.cmdAddDistribution.Name = "cmdAddDistribution"
        Me.cmdAddDistribution.Size = New System.Drawing.Size(120, 23)
        Me.cmdAddDistribution.TabIndex = 3
        Me.cmdAddDistribution.Text = "Add Distribution"
        Me.cmdAddDistribution.UseVisualStyleBackColor = True
        '
        'lstAddedDistribution
        '
        Me.lstAddedDistribution.FormattingEnabled = True
        Me.lstAddedDistribution.Location = New System.Drawing.Point(271, 44)
        Me.lstAddedDistribution.Name = "lstAddedDistribution"
        Me.lstAddedDistribution.Size = New System.Drawing.Size(120, 147)
        Me.lstAddedDistribution.TabIndex = 5
        '
        'lblAddedDistribution
        '
        Me.lblAddedDistribution.AutoSize = True
        Me.lblAddedDistribution.Location = New System.Drawing.Point(268, 28)
        Me.lblAddedDistribution.Name = "lblAddedDistribution"
        Me.lblAddedDistribution.Size = New System.Drawing.Size(93, 13)
        Me.lblAddedDistribution.TabIndex = 4
        Me.lblAddedDistribution.Text = "Added Distribution"
        '
        'sdgAddNewDistribution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 375)
        Me.Controls.Add(Me.lblAddedDistribution)
        Me.Controls.Add(Me.lstAddedDistribution)
        Me.Controls.Add(Me.cmdAddDistribution)
        Me.Controls.Add(Me.grpPlot)
        Me.Controls.Add(Me.grpChangeLimits)
        Me.Controls.Add(Me.ucrNewDistributions)
        Me.Controls.Add(Me.ucrBaseSubDialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgAddNewDistribution"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Distribution"
        Me.grpChangeLimits.ResumeLayout(False)
        Me.grpChangeLimits.PerformLayout()
        CType(Me.nudYlimUpper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudXlimUpper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudYlimLower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudXlimLower, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPlot.ResumeLayout(False)
        Me.grpPlot.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSubDialog As ucrButtonsSubdialogue
    Friend WithEvents ucrNewDistributions As ucrDistributionsWithParameters
    Friend WithEvents grpChangeLimits As GroupBox
    Friend WithEvents nudXlimLower As NumericUpDown
    Friend WithEvents lblYlim As Label
    Friend WithEvents lblXlim As Label
    Friend WithEvents nudYlimUpper As NumericUpDown
    Friend WithEvents nudXlimUpper As NumericUpDown
    Friend WithEvents nudYlimLower As NumericUpDown
    Friend WithEvents grpPlot As GroupBox
    Friend WithEvents rdoProbability As RadioButton
    Friend WithEvents rdoDensity As RadioButton
    Friend WithEvents cmdAddDistribution As Button
    Friend WithEvents lstAddedDistribution As ListBox
    Friend WithEvents lblAddedDistribution As Label
End Class
