<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgOneVarFitModDisplay
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
        Me.tbcPlots = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rdoPPPlot = New System.Windows.Forms.RadioButton()
        Me.rdoQQPlot = New System.Windows.Forms.RadioButton()
        Me.rdoDensityPlot = New System.Windows.Forms.RadioButton()
        Me.rdoCDFPlot = New System.Windows.Forms.RadioButton()
        Me.rdoPlotAll = New System.Windows.Forms.RadioButton()
        Me.rdoNoPlot = New System.Windows.Forms.RadioButton()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.tbcQuantiles = New System.Windows.Forms.TabPage()
        Me.tbcPlots.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcPlots
        '
        Me.tbcPlots.Controls.Add(Me.TabPage1)
        Me.tbcPlots.Controls.Add(Me.tbcQuantiles)
        Me.tbcPlots.Location = New System.Drawing.Point(10, 10)
        Me.tbcPlots.Name = "tbcPlots"
        Me.tbcPlots.SelectedIndex = 0
        Me.tbcPlots.Size = New System.Drawing.Size(161, 203)
        Me.tbcPlots.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.rdoPPPlot)
        Me.TabPage1.Controls.Add(Me.rdoQQPlot)
        Me.TabPage1.Controls.Add(Me.rdoDensityPlot)
        Me.TabPage1.Controls.Add(Me.rdoCDFPlot)
        Me.TabPage1.Controls.Add(Me.rdoPlotAll)
        Me.TabPage1.Controls.Add(Me.rdoNoPlot)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(153, 177)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Plots"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'rdoPPPlot
        '
        Me.rdoPPPlot.AutoSize = True
        Me.rdoPPPlot.Location = New System.Drawing.Point(8, 135)
        Me.rdoPPPlot.Name = "rdoPPPlot"
        Me.rdoPPPlot.Size = New System.Drawing.Size(60, 17)
        Me.rdoPPPlot.TabIndex = 5
        Me.rdoPPPlot.Text = "PP-Plot"
        Me.rdoPPPlot.UseVisualStyleBackColor = True
        '
        'rdoQQPlot
        '
        Me.rdoQQPlot.AutoSize = True
        Me.rdoQQPlot.Location = New System.Drawing.Point(8, 112)
        Me.rdoQQPlot.Name = "rdoQQPlot"
        Me.rdoQQPlot.Size = New System.Drawing.Size(62, 17)
        Me.rdoQQPlot.TabIndex = 4
        Me.rdoQQPlot.Text = "QQ-Plot"
        Me.rdoQQPlot.UseVisualStyleBackColor = True
        '
        'rdoDensityPlot
        '
        Me.rdoDensityPlot.AutoSize = True
        Me.rdoDensityPlot.Location = New System.Drawing.Point(8, 89)
        Me.rdoDensityPlot.Name = "rdoDensityPlot"
        Me.rdoDensityPlot.Size = New System.Drawing.Size(81, 17)
        Me.rdoDensityPlot.TabIndex = 3
        Me.rdoDensityPlot.Text = "Density Plot"
        Me.rdoDensityPlot.UseVisualStyleBackColor = True
        '
        'rdoCDFPlot
        '
        Me.rdoCDFPlot.AutoSize = True
        Me.rdoCDFPlot.Location = New System.Drawing.Point(8, 66)
        Me.rdoCDFPlot.Name = "rdoCDFPlot"
        Me.rdoCDFPlot.Size = New System.Drawing.Size(67, 17)
        Me.rdoCDFPlot.TabIndex = 2
        Me.rdoCDFPlot.Text = "CDF Plot"
        Me.rdoCDFPlot.UseVisualStyleBackColor = True
        '
        'rdoPlotAll
        '
        Me.rdoPlotAll.AutoSize = True
        Me.rdoPlotAll.Location = New System.Drawing.Point(8, 43)
        Me.rdoPlotAll.Name = "rdoPlotAll"
        Me.rdoPlotAll.Size = New System.Drawing.Size(68, 17)
        Me.rdoPlotAll.TabIndex = 1
        Me.rdoPlotAll.Text = "Multi-Plot"
        Me.rdoPlotAll.UseVisualStyleBackColor = True
        '
        'rdoNoPlot
        '
        Me.rdoNoPlot.AutoSize = True
        Me.rdoNoPlot.Checked = True
        Me.rdoNoPlot.Location = New System.Drawing.Point(8, 20)
        Me.rdoNoPlot.Name = "rdoNoPlot"
        Me.rdoNoPlot.Size = New System.Drawing.Size(60, 17)
        Me.rdoNoPlot.TabIndex = 0
        Me.rdoNoPlot.TabStop = True
        Me.rdoNoPlot.Text = "No Plot"
        Me.rdoNoPlot.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(14, 219)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrBase.TabIndex = 1
        '
        'tbcQuantiles
        '
        Me.tbcQuantiles.Location = New System.Drawing.Point(4, 22)
        Me.tbcQuantiles.Name = "tbcQuantiles"
        Me.tbcQuantiles.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcQuantiles.Size = New System.Drawing.Size(153, 177)
        Me.tbcQuantiles.TabIndex = 1
        Me.tbcQuantiles.Text = "Quantiles"
        Me.tbcQuantiles.UseVisualStyleBackColor = True
        '
        'sdgOneVarFitModDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(176, 256)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.tbcPlots)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarFitModDisplay"
        Me.Text = "Display Options"
        Me.tbcPlots.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcPlots As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents rdoPPPlot As RadioButton
    Friend WithEvents rdoQQPlot As RadioButton
    Friend WithEvents rdoDensityPlot As RadioButton
    Friend WithEvents rdoCDFPlot As RadioButton
    Friend WithEvents rdoPlotAll As RadioButton
    Friend WithEvents rdoNoPlot As RadioButton
    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents tbcQuantiles As TabPage
End Class
