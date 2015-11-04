<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDescriptiveStatistics
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
        Me.UcrDataSelection1 = New instat.ucrDataSelection()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.grpgraphics = New System.Windows.Forms.GroupBox()
        Me.chkCumulativeFrequency = New System.Windows.Forms.CheckBox()
        Me.chkBoxPlot = New System.Windows.Forms.CheckBox()
        Me.chkStemAndLeaf = New System.Windows.Forms.CheckBox()
        Me.chkGraphics = New System.Windows.Forms.CheckBox()
        Me.UcrButtons1 = New instat.ucrButtons()
        Me.grpgraphics.SuspendLayout()
        Me.SuspendLayout()
        '
        'UcrDataSelection1
        '
        Me.UcrDataSelection1.Location = New System.Drawing.Point(27, 5)
        Me.UcrDataSelection1.Name = "UcrDataSelection1"
        Me.UcrDataSelection1.Size = New System.Drawing.Size(332, 122)
        Me.UcrDataSelection1.TabIndex = 0
        '
        'btnStatistics
        '
        Me.btnStatistics.Location = New System.Drawing.Point(7, 133)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(104, 23)
        Me.btnStatistics.TabIndex = 90
        Me.btnStatistics.Tag = "Choose_Statistics"
        Me.btnStatistics.Text = "Choose Statistics "
        Me.btnStatistics.UseVisualStyleBackColor = True
        '
        'grpgraphics
        '
        Me.grpgraphics.Controls.Add(Me.chkCumulativeFrequency)
        Me.grpgraphics.Controls.Add(Me.chkBoxPlot)
        Me.grpgraphics.Controls.Add(Me.chkStemAndLeaf)
        Me.grpgraphics.Location = New System.Drawing.Point(76, 164)
        Me.grpgraphics.Name = "grpgraphics"
        Me.grpgraphics.Size = New System.Drawing.Size(292, 28)
        Me.grpgraphics.TabIndex = 89
        Me.grpgraphics.TabStop = False
        '
        'chkCumulativeFrequency
        '
        Me.chkCumulativeFrequency.AutoSize = True
        Me.chkCumulativeFrequency.Location = New System.Drawing.Point(157, 5)
        Me.chkCumulativeFrequency.Name = "chkCumulativeFrequency"
        Me.chkCumulativeFrequency.Size = New System.Drawing.Size(128, 17)
        Me.chkCumulativeFrequency.TabIndex = 61
        Me.chkCumulativeFrequency.Tag = "Cumulative_Frequency"
        Me.chkCumulativeFrequency.Text = "Cumulative frequency"
        Me.chkCumulativeFrequency.UseVisualStyleBackColor = True
        '
        'chkBoxPlot
        '
        Me.chkBoxPlot.AutoSize = True
        Me.chkBoxPlot.Location = New System.Drawing.Point(96, 6)
        Me.chkBoxPlot.Name = "chkBoxPlot"
        Me.chkBoxPlot.Size = New System.Drawing.Size(65, 17)
        Me.chkBoxPlot.TabIndex = 60
        Me.chkBoxPlot.Tag = "Box_Plot"
        Me.chkBoxPlot.Text = "Box Plot"
        Me.chkBoxPlot.UseVisualStyleBackColor = True
        '
        'chkStemAndLeaf
        '
        Me.chkStemAndLeaf.AutoSize = True
        Me.chkStemAndLeaf.Location = New System.Drawing.Point(7, 5)
        Me.chkStemAndLeaf.Name = "chkStemAndLeaf"
        Me.chkStemAndLeaf.Size = New System.Drawing.Size(91, 17)
        Me.chkStemAndLeaf.TabIndex = 1
        Me.chkStemAndLeaf.Tag = "Stem_And_Leaf"
        Me.chkStemAndLeaf.Text = "Stem and leaf"
        Me.chkStemAndLeaf.UseVisualStyleBackColor = True
        '
        'chkGraphics
        '
        Me.chkGraphics.AutoSize = True
        Me.chkGraphics.Location = New System.Drawing.Point(7, 170)
        Me.chkGraphics.Name = "chkGraphics"
        Me.chkGraphics.Size = New System.Drawing.Size(71, 17)
        Me.chkGraphics.TabIndex = 88
        Me.chkGraphics.Tag = "Graphics"
        Me.chkGraphics.Text = "Graphics "
        Me.chkGraphics.UseVisualStyleBackColor = True
        '
        'UcrButtons1
        '
        Me.UcrButtons1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcrButtons1.Location = New System.Drawing.Point(0, 195)
        Me.UcrButtons1.Name = "UcrButtons1"
        Me.UcrButtons1.Size = New System.Drawing.Size(371, 30)
        Me.UcrButtons1.TabIndex = 91
        '
        'dlgDescriptiveStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 225)
        Me.Controls.Add(Me.UcrButtons1)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.grpgraphics)
        Me.Controls.Add(Me.chkGraphics)
        Me.Controls.Add(Me.UcrDataSelection1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescriptiveStatistics"
        Me.ShowIcon = False
        Me.Tag = "Descriptive_Statistics"
        Me.Text = "Descriptive Statistics"
        Me.grpgraphics.ResumeLayout(False)
        Me.grpgraphics.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrDataSelection1 As ucrDataSelection
    Friend WithEvents btnStatistics As Button
    Friend WithEvents grpgraphics As GroupBox
    Friend WithEvents chkCumulativeFrequency As CheckBox
    Friend WithEvents chkBoxPlot As CheckBox
    Friend WithEvents chkStemAndLeaf As CheckBox
    Friend WithEvents chkGraphics As CheckBox
    Friend WithEvents UcrButtons1 As ucrButtons
End Class
