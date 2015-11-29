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
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.grpgraphics = New System.Windows.Forms.GroupBox()
        Me.chkCumulativeFrequency = New System.Windows.Forms.CheckBox()
        Me.chkBoxPlot = New System.Windows.Forms.CheckBox()
        Me.chkStemAndLeaf = New System.Windows.Forms.CheckBox()
        Me.chkGraphics = New System.Windows.Forms.CheckBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverSingle = New instat.ucrReceiverSingle()
        Me.lblSelectedColumn = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpgraphics.SuspendLayout()
        Me.SuspendLayout()
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
        'ucrBase
        '
        Me.ucrBase.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ucrBase.Location = New System.Drawing.Point(0, 195)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(407, 30)
        Me.ucrBase.TabIndex = 91
        '
        'ucrSelectorAddRemove
        '
        Me.ucrSelectorAddRemove.Location = New System.Drawing.Point(7, 0)
        Me.ucrSelectorAddRemove.Name = "ucrSelectorAddRemove"
        Me.ucrSelectorAddRemove.Size = New System.Drawing.Size(203, 127)
        Me.ucrSelectorAddRemove.TabIndex = 92
        '
        'ucrReceiverSingle
        '
        Me.ucrReceiverSingle.Location = New System.Drawing.Point(216, 32)
        Me.ucrReceiverSingle.Name = "ucrReceiverSingle"
        Me.ucrReceiverSingle.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverSingle.TabIndex = 93
        '
        'lblSelectedColumn
        '
        Me.lblSelectedColumn.AutoSize = True
        Me.lblSelectedColumn.Location = New System.Drawing.Point(216, 9)
        Me.lblSelectedColumn.Name = "lblSelectedColumn"
        Me.lblSelectedColumn.Size = New System.Drawing.Size(87, 13)
        Me.lblSelectedColumn.TabIndex = 94
        Me.lblSelectedColumn.Tag = "Selected_Column"
        Me.lblSelectedColumn.Text = "Selected Column"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(267, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Label1"
        '
        'dlgDescriptiveStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 225)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSelectedColumn)
        Me.Controls.Add(Me.ucrReceiverSingle)
        Me.Controls.Add(Me.ucrSelectorAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.btnStatistics)
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
    Friend WithEvents btnStatistics As Button
    Friend WithEvents grpgraphics As GroupBox
    Friend WithEvents chkCumulativeFrequency As CheckBox
    Friend WithEvents chkBoxPlot As CheckBox
    Friend WithEvents chkStemAndLeaf As CheckBox
    Friend WithEvents chkGraphics As CheckBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverSingle As ucrReceiverSingle
    Friend WithEvents lblSelectedColumn As Label
    Friend WithEvents Label1 As Label
End Class
