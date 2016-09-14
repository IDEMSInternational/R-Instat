<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgDescribeTwoVarGraph
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
        Me.UcrButtonsSubdialogue1 = New instat.ucrButtonsSubdialogue()
        Me.grpVariateByVariate = New System.Windows.Forms.GroupBox()
        Me.rdoLinePlot = New System.Windows.Forms.RadioButton()
        Me.rdoScatterPlot = New System.Windows.Forms.RadioButton()
        Me.grpVariateByFactor = New System.Windows.Forms.GroupBox()
        Me.rdoBoxPlot = New System.Windows.Forms.RadioButton()
        Me.grpFactorByVariate = New System.Windows.Forms.GroupBox()
        Me.rdoSummaryPlot = New System.Windows.Forms.RadioButton()
        Me.grpFactorByFactor = New System.Windows.Forms.GroupBox()
        Me.rdoDotPlot = New System.Windows.Forms.RadioButton()
        Me.rdoBarPlot = New System.Windows.Forms.RadioButton()
        Me.grpVariateByVariate.SuspendLayout()
        Me.grpVariateByFactor.SuspendLayout()
        Me.grpFactorByVariate.SuspendLayout()
        Me.grpFactorByFactor.SuspendLayout()
        Me.SuspendLayout()
        '
        'UcrButtonsSubdialogue1
        '
        Me.UcrButtonsSubdialogue1.Location = New System.Drawing.Point(76, 219)
        Me.UcrButtonsSubdialogue1.Name = "UcrButtonsSubdialogue1"
        Me.UcrButtonsSubdialogue1.Size = New System.Drawing.Size(142, 30)
        Me.UcrButtonsSubdialogue1.TabIndex = 0
        '
        'grpVariateByVariate
        '
        Me.grpVariateByVariate.Controls.Add(Me.rdoLinePlot)
        Me.grpVariateByVariate.Controls.Add(Me.rdoScatterPlot)
        Me.grpVariateByVariate.Location = New System.Drawing.Point(12, 12)
        Me.grpVariateByVariate.Name = "grpVariateByVariate"
        Me.grpVariateByVariate.Size = New System.Drawing.Size(260, 42)
        Me.grpVariateByVariate.TabIndex = 114
        Me.grpVariateByVariate.TabStop = False
        Me.grpVariateByVariate.Tag = "Variate_By_Variate"
        Me.grpVariateByVariate.Text = "Variate By Variate"
        '
        'rdoLinePlot
        '
        Me.rdoLinePlot.AutoSize = True
        Me.rdoLinePlot.Location = New System.Drawing.Point(159, 18)
        Me.rdoLinePlot.Name = "rdoLinePlot"
        Me.rdoLinePlot.Size = New System.Drawing.Size(63, 17)
        Me.rdoLinePlot.TabIndex = 116
        Me.rdoLinePlot.TabStop = True
        Me.rdoLinePlot.Tag = "LinePlot"
        Me.rdoLinePlot.Text = "LinePlot"
        Me.rdoLinePlot.UseVisualStyleBackColor = True
        '
        'rdoScatterPlot
        '
        Me.rdoScatterPlot.AutoSize = True
        Me.rdoScatterPlot.Location = New System.Drawing.Point(14, 17)
        Me.rdoScatterPlot.Name = "rdoScatterPlot"
        Me.rdoScatterPlot.Size = New System.Drawing.Size(77, 17)
        Me.rdoScatterPlot.TabIndex = 115
        Me.rdoScatterPlot.TabStop = True
        Me.rdoScatterPlot.Tag = "ScatterPlot"
        Me.rdoScatterPlot.Text = "ScatterPlot"
        Me.rdoScatterPlot.UseVisualStyleBackColor = True
        '
        'grpVariateByFactor
        '
        Me.grpVariateByFactor.Controls.Add(Me.rdoBoxPlot)
        Me.grpVariateByFactor.Location = New System.Drawing.Point(12, 57)
        Me.grpVariateByFactor.Name = "grpVariateByFactor"
        Me.grpVariateByFactor.Size = New System.Drawing.Size(260, 46)
        Me.grpVariateByFactor.TabIndex = 113
        Me.grpVariateByFactor.TabStop = False
        Me.grpVariateByFactor.Tag = "Variate_By_Factor"
        Me.grpVariateByFactor.Text = "Variate By Factor"
        '
        'rdoBoxPlot
        '
        Me.rdoBoxPlot.AutoSize = True
        Me.rdoBoxPlot.Location = New System.Drawing.Point(14, 23)
        Me.rdoBoxPlot.Name = "rdoBoxPlot"
        Me.rdoBoxPlot.Size = New System.Drawing.Size(61, 17)
        Me.rdoBoxPlot.TabIndex = 117
        Me.rdoBoxPlot.TabStop = True
        Me.rdoBoxPlot.Tag = "BoxPlot"
        Me.rdoBoxPlot.Text = "BoxPlot"
        Me.rdoBoxPlot.UseVisualStyleBackColor = True
        '
        'grpFactorByVariate
        '
        Me.grpFactorByVariate.Controls.Add(Me.rdoSummaryPlot)
        Me.grpFactorByVariate.Location = New System.Drawing.Point(12, 116)
        Me.grpFactorByVariate.Name = "grpFactorByVariate"
        Me.grpFactorByVariate.Size = New System.Drawing.Size(260, 43)
        Me.grpFactorByVariate.TabIndex = 114
        Me.grpFactorByVariate.TabStop = False
        Me.grpFactorByVariate.Tag = "Factor_By_Variate"
        Me.grpFactorByVariate.Text = "Factor By Variate"
        '
        'rdoSummaryPlot
        '
        Me.rdoSummaryPlot.AutoSize = True
        Me.rdoSummaryPlot.Location = New System.Drawing.Point(14, 19)
        Me.rdoSummaryPlot.Name = "rdoSummaryPlot"
        Me.rdoSummaryPlot.Size = New System.Drawing.Size(86, 17)
        Me.rdoSummaryPlot.TabIndex = 120
        Me.rdoSummaryPlot.TabStop = True
        Me.rdoSummaryPlot.Tag = "SummaryPlot"
        Me.rdoSummaryPlot.Text = "SummaryPlot"
        Me.rdoSummaryPlot.UseVisualStyleBackColor = True
        '
        'grpFactorByFactor
        '
        Me.grpFactorByFactor.Controls.Add(Me.rdoDotPlot)
        Me.grpFactorByFactor.Controls.Add(Me.rdoBarPlot)
        Me.grpFactorByFactor.Location = New System.Drawing.Point(12, 165)
        Me.grpFactorByFactor.Name = "grpFactorByFactor"
        Me.grpFactorByFactor.Size = New System.Drawing.Size(260, 42)
        Me.grpFactorByFactor.TabIndex = 114
        Me.grpFactorByFactor.TabStop = False
        Me.grpFactorByFactor.Tag = "Factor_By_Factor"
        Me.grpFactorByFactor.Text = "Factor By Factor"
        '
        'rdoDotPlot
        '
        Me.rdoDotPlot.AutoSize = True
        Me.rdoDotPlot.Location = New System.Drawing.Point(159, 15)
        Me.rdoDotPlot.Name = "rdoDotPlot"
        Me.rdoDotPlot.Size = New System.Drawing.Size(60, 17)
        Me.rdoDotPlot.TabIndex = 119
        Me.rdoDotPlot.TabStop = True
        Me.rdoDotPlot.Tag = "DotPlot"
        Me.rdoDotPlot.Text = "DotPlot"
        Me.rdoDotPlot.UseVisualStyleBackColor = True
        '
        'rdoBarPlot
        '
        Me.rdoBarPlot.AutoSize = True
        Me.rdoBarPlot.Location = New System.Drawing.Point(14, 15)
        Me.rdoBarPlot.Name = "rdoBarPlot"
        Me.rdoBarPlot.Size = New System.Drawing.Size(59, 17)
        Me.rdoBarPlot.TabIndex = 118
        Me.rdoBarPlot.TabStop = True
        Me.rdoBarPlot.Tag = "BarPlot"
        Me.rdoBarPlot.Text = "BarPlot"
        Me.rdoBarPlot.UseVisualStyleBackColor = True
        '
        'sdgDescribeTwoVarGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.grpFactorByFactor)
        Me.Controls.Add(Me.grpFactorByVariate)
        Me.Controls.Add(Me.grpVariateByVariate)
        Me.Controls.Add(Me.grpVariateByFactor)
        Me.Controls.Add(Me.UcrButtonsSubdialogue1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDescribeTwoVarGraph"
        Me.Text = "sdgDescribeTwoVarGraph"
        Me.grpVariateByVariate.ResumeLayout(False)
        Me.grpVariateByVariate.PerformLayout()
        Me.grpVariateByFactor.ResumeLayout(False)
        Me.grpVariateByFactor.PerformLayout()
        Me.grpFactorByVariate.ResumeLayout(False)
        Me.grpFactorByVariate.PerformLayout()
        Me.grpFactorByFactor.ResumeLayout(False)
        Me.grpFactorByFactor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrButtonsSubdialogue1 As ucrButtonsSubdialogue
    Friend WithEvents grpVariateByVariate As GroupBox
    Friend WithEvents rdoLinePlot As RadioButton
    Friend WithEvents rdoScatterPlot As RadioButton
    Friend WithEvents grpVariateByFactor As GroupBox
    Friend WithEvents rdoBoxPlot As RadioButton
    Friend WithEvents grpFactorByVariate As GroupBox
    Friend WithEvents rdoSummaryPlot As RadioButton
    Friend WithEvents grpFactorByFactor As GroupBox
    Friend WithEvents rdoDotPlot As RadioButton
    Friend WithEvents rdoBarPlot As RadioButton
End Class
