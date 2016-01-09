<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDescriptiveStatistics
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.cmdStatistics = New System.Windows.Forms.Button()
        Me.grpgraphics = New System.Windows.Forms.GroupBox()
        Me.chkCumulativeFrequency = New System.Windows.Forms.CheckBox()
        Me.chkBoxPlot = New System.Windows.Forms.CheckBox()
        Me.chkStemAndLeaf = New System.Windows.Forms.CheckBox()
        Me.chkGraphics = New System.Windows.Forms.CheckBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataSelector = New instat.ucrSelectorAddRemove()
        Me.ucrObjectReceiver = New instat.ucrReceiverSingle()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.grpgraphics.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdStatistics
        '
        Me.cmdStatistics.Location = New System.Drawing.Point(7, 133)
        Me.cmdStatistics.Name = "cmdStatistics"
        Me.cmdStatistics.Size = New System.Drawing.Size(104, 23)
        Me.cmdStatistics.TabIndex = 90
        Me.cmdStatistics.Tag = "Choose_Statistics"
        Me.cmdStatistics.Text = "Choose Statistics "
        Me.cmdStatistics.UseVisualStyleBackColor = True
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
        Me.chkCumulativeFrequency.Location = New System.Drawing.Point(189, 5)
        Me.chkCumulativeFrequency.Name = "chkCumulativeFrequency"
        Me.chkCumulativeFrequency.Size = New System.Drawing.Size(128, 17)
        Me.chkCumulativeFrequency.TabIndex = 61
        Me.chkCumulativeFrequency.Tag = "Cumulative_frequency"
        Me.chkCumulativeFrequency.Text = "Cumulative frequency"
        Me.chkCumulativeFrequency.UseVisualStyleBackColor = True
        '
        'chkBoxPlot
        '
        Me.chkBoxPlot.AutoSize = True
        Me.chkBoxPlot.Location = New System.Drawing.Point(112, 6)
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
        Me.chkStemAndLeaf.Tag = "Stem_and_Leaf"
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
        'ucrBase
        '
        Me.ucrBase.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ucrBase.Location = New System.Drawing.Point(0, 195)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(407, 30)
        Me.ucrBase.TabIndex = 91
        '
        'ucrDataSelector
        '
        Me.ucrDataSelector.Location = New System.Drawing.Point(3, 1)
        Me.ucrDataSelector.Name = "ucrDataSelector"
        Me.ucrDataSelector.Size = New System.Drawing.Size(203, 127)
        Me.ucrDataSelector.TabIndex = 92
        '
        'ucrObjectReceiver
        '
        Me.ucrObjectReceiver.Location = New System.Drawing.Point(212, 31)
        Me.ucrObjectReceiver.Name = "ucrObjectReceiver"
        Me.ucrObjectReceiver.Size = New System.Drawing.Size(120, 26)
        Me.ucrObjectReceiver.TabIndex = 93
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.Location = New System.Drawing.Point(213, 12)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(90, 13)
        Me.lblSelectedVariable.TabIndex = 94
        Me.lblSelectedVariable.Tag = "Selected_Variable"
        Me.lblSelectedVariable.Text = "Selected Variable"
        '
        'dlgDescriptiveStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 225)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.ucrObjectReceiver)
        Me.Controls.Add(Me.ucrDataSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.cmdStatistics)
        Me.Controls.Add(Me.grpgraphics)
        Me.Controls.Add(Me.chkGraphics)
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
    Friend WithEvents cmdStatistics As Button
    Friend WithEvents grpgraphics As GroupBox
    Friend WithEvents chkCumulativeFrequency As CheckBox
    Friend WithEvents chkBoxPlot As CheckBox
    Friend WithEvents chkStemAndLeaf As CheckBox
    Friend WithEvents chkGraphics As CheckBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataSelector As ucrSelectorAddRemove
    Friend WithEvents ucrObjectReceiver As ucrReceiverSingle
    Friend WithEvents lblSelectedVariable As Label
End Class
