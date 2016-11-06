<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgSummaries
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
        Me.chkNonMissing = New System.Windows.Forms.CheckBox()
        Me.chkNMissing = New System.Windows.Forms.CheckBox()
        Me.chkNTotal = New System.Windows.Forms.CheckBox()
        Me.chkMode = New System.Windows.Forms.CheckBox()
        Me.grpCommon = New System.Windows.Forms.GroupBox()
        Me.grpNotOrderedFactor = New System.Windows.Forms.GroupBox()
        Me.chkMinimum = New System.Windows.Forms.CheckBox()
        Me.chkMaximum = New System.Windows.Forms.CheckBox()
        Me.grpNumeric = New System.Windows.Forms.GroupBox()
        Me.chkSum = New System.Windows.Forms.CheckBox()
        Me.chkMean = New System.Windows.Forms.CheckBox()
        Me.chkRange = New System.Windows.Forms.CheckBox()
        Me.chkVariance = New System.Windows.Forms.CheckBox()
        Me.chkStdDev = New System.Windows.Forms.CheckBox()
        Me.chkQuartiles = New System.Windows.Forms.CheckBox()
        Me.chkMedian = New System.Windows.Forms.CheckBox()
        Me.UcrButtonsSubdialogue1 = New instat.ucrButtonsSubdialogue()
        Me.grpCommon.SuspendLayout()
        Me.grpNotOrderedFactor.SuspendLayout()
        Me.grpNumeric.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkNonMissing
        '
        Me.chkNonMissing.AutoSize = True
        Me.chkNonMissing.Location = New System.Drawing.Point(13, 17)
        Me.chkNonMissing.Name = "chkNonMissing"
        Me.chkNonMissing.Size = New System.Drawing.Size(95, 17)
        Me.chkNonMissing.TabIndex = 0
        Me.chkNonMissing.Tag = "N_Non_Missing"
        Me.chkNonMissing.Text = "N Non Missing"
        Me.chkNonMissing.UseVisualStyleBackColor = True
        '
        'chkNMissing
        '
        Me.chkNMissing.AutoSize = True
        Me.chkNMissing.Location = New System.Drawing.Point(13, 37)
        Me.chkNMissing.Name = "chkNMissing"
        Me.chkNMissing.Size = New System.Drawing.Size(72, 17)
        Me.chkNMissing.TabIndex = 2
        Me.chkNMissing.Tag = "N_Missing"
        Me.chkNMissing.Text = "N Missing"
        Me.chkNMissing.UseVisualStyleBackColor = True
        '
        'chkNTotal
        '
        Me.chkNTotal.AutoSize = True
        Me.chkNTotal.Location = New System.Drawing.Point(151, 17)
        Me.chkNTotal.Name = "chkNTotal"
        Me.chkNTotal.Size = New System.Drawing.Size(61, 17)
        Me.chkNTotal.TabIndex = 1
        Me.chkNTotal.Tag = "N_Total"
        Me.chkNTotal.Text = "N Total"
        Me.chkNTotal.UseVisualStyleBackColor = True
        '
        'chkMode
        '
        Me.chkMode.AutoSize = True
        Me.chkMode.Location = New System.Drawing.Point(151, 37)
        Me.chkMode.Name = "chkMode"
        Me.chkMode.Size = New System.Drawing.Size(53, 17)
        Me.chkMode.TabIndex = 3
        Me.chkMode.Tag = "Mode"
        Me.chkMode.Text = "Mode"
        Me.chkMode.UseVisualStyleBackColor = True
        '
        'grpCommon
        '
        Me.grpCommon.Controls.Add(Me.chkMode)
        Me.grpCommon.Controls.Add(Me.chkNonMissing)
        Me.grpCommon.Controls.Add(Me.chkNMissing)
        Me.grpCommon.Controls.Add(Me.chkNTotal)
        Me.grpCommon.Location = New System.Drawing.Point(12, 8)
        Me.grpCommon.Name = "grpCommon"
        Me.grpCommon.Size = New System.Drawing.Size(244, 57)
        Me.grpCommon.TabIndex = 0
        Me.grpCommon.TabStop = False
        Me.grpCommon.Tag = "Common"
        Me.grpCommon.Text = "Common"
        '
        'grpNotOrderedFactor
        '
        Me.grpNotOrderedFactor.Controls.Add(Me.chkMinimum)
        Me.grpNotOrderedFactor.Controls.Add(Me.chkMaximum)
        Me.grpNotOrderedFactor.Location = New System.Drawing.Point(13, 72)
        Me.grpNotOrderedFactor.Name = "grpNotOrderedFactor"
        Me.grpNotOrderedFactor.Size = New System.Drawing.Size(243, 46)
        Me.grpNotOrderedFactor.TabIndex = 1
        Me.grpNotOrderedFactor.TabStop = False
        Me.grpNotOrderedFactor.Tag = "All_but_unrdered_factor"
        Me.grpNotOrderedFactor.Text = "All but (Unordered) factor"
        '
        'chkMinimum
        '
        Me.chkMinimum.AutoSize = True
        Me.chkMinimum.Location = New System.Drawing.Point(12, 19)
        Me.chkMinimum.Name = "chkMinimum"
        Me.chkMinimum.Size = New System.Drawing.Size(67, 17)
        Me.chkMinimum.TabIndex = 0
        Me.chkMinimum.Tag = "Minimum"
        Me.chkMinimum.Text = "Minimum"
        Me.chkMinimum.UseVisualStyleBackColor = True
        '
        'chkMaximum
        '
        Me.chkMaximum.AutoSize = True
        Me.chkMaximum.Location = New System.Drawing.Point(150, 19)
        Me.chkMaximum.Name = "chkMaximum"
        Me.chkMaximum.Size = New System.Drawing.Size(70, 17)
        Me.chkMaximum.TabIndex = 1
        Me.chkMaximum.Tag = "Maximum"
        Me.chkMaximum.Text = "Maximum"
        Me.chkMaximum.UseVisualStyleBackColor = True
        '
        'grpNumeric
        '
        Me.grpNumeric.Controls.Add(Me.chkSum)
        Me.grpNumeric.Controls.Add(Me.chkMean)
        Me.grpNumeric.Controls.Add(Me.chkRange)
        Me.grpNumeric.Controls.Add(Me.chkVariance)
        Me.grpNumeric.Controls.Add(Me.chkStdDev)
        Me.grpNumeric.Controls.Add(Me.chkQuartiles)
        Me.grpNumeric.Controls.Add(Me.chkMedian)
        Me.grpNumeric.Location = New System.Drawing.Point(13, 123)
        Me.grpNumeric.Name = "grpNumeric"
        Me.grpNumeric.Size = New System.Drawing.Size(243, 108)
        Me.grpNumeric.TabIndex = 2
        Me.grpNumeric.TabStop = False
        Me.grpNumeric.Tag = "Numeric"
        Me.grpNumeric.Text = "Numeric"
        '
        'chkSum
        '
        Me.chkSum.AutoSize = True
        Me.chkSum.Location = New System.Drawing.Point(12, 19)
        Me.chkSum.Name = "chkSum"
        Me.chkSum.Size = New System.Drawing.Size(47, 17)
        Me.chkSum.TabIndex = 0
        Me.chkSum.Tag = "Sum"
        Me.chkSum.Text = "Sum"
        Me.chkSum.UseVisualStyleBackColor = True
        '
        'chkMean
        '
        Me.chkMean.AutoSize = True
        Me.chkMean.Location = New System.Drawing.Point(12, 40)
        Me.chkMean.Name = "chkMean"
        Me.chkMean.Size = New System.Drawing.Size(53, 17)
        Me.chkMean.TabIndex = 2
        Me.chkMean.Tag = "Mean"
        Me.chkMean.Text = "Mean"
        Me.chkMean.UseVisualStyleBackColor = True
        '
        'chkRange
        '
        Me.chkRange.AutoSize = True
        Me.chkRange.Location = New System.Drawing.Point(12, 61)
        Me.chkRange.Name = "chkRange"
        Me.chkRange.Size = New System.Drawing.Size(58, 17)
        Me.chkRange.TabIndex = 4
        Me.chkRange.Tag = "Range"
        Me.chkRange.Text = "Range"
        Me.chkRange.UseVisualStyleBackColor = True
        '
        'chkVariance
        '
        Me.chkVariance.AutoSize = True
        Me.chkVariance.Enabled = False
        Me.chkVariance.Location = New System.Drawing.Point(150, 61)
        Me.chkVariance.Name = "chkVariance"
        Me.chkVariance.Size = New System.Drawing.Size(68, 17)
        Me.chkVariance.TabIndex = 5
        Me.chkVariance.Tag = "Variance"
        Me.chkVariance.Text = "Variance"
        Me.chkVariance.UseVisualStyleBackColor = True
        '
        'chkStdDev
        '
        Me.chkStdDev.AutoSize = True
        Me.chkStdDev.Location = New System.Drawing.Point(12, 82)
        Me.chkStdDev.Name = "chkStdDev"
        Me.chkStdDev.Size = New System.Drawing.Size(117, 17)
        Me.chkStdDev.TabIndex = 6
        Me.chkStdDev.Tag = "Standard_Deviation"
        Me.chkStdDev.Text = "Standard Deviation"
        Me.chkStdDev.UseVisualStyleBackColor = True
        '
        'chkQuartiles
        '
        Me.chkQuartiles.AutoSize = True
        Me.chkQuartiles.Enabled = False
        Me.chkQuartiles.Location = New System.Drawing.Point(150, 40)
        Me.chkQuartiles.Name = "chkQuartiles"
        Me.chkQuartiles.Size = New System.Drawing.Size(67, 17)
        Me.chkQuartiles.TabIndex = 3
        Me.chkQuartiles.Tag = "Quartiles"
        Me.chkQuartiles.Text = "Quartiles"
        Me.chkQuartiles.UseVisualStyleBackColor = True
        '
        'chkMedian
        '
        Me.chkMedian.AutoSize = True
        Me.chkMedian.Location = New System.Drawing.Point(150, 19)
        Me.chkMedian.Name = "chkMedian"
        Me.chkMedian.Size = New System.Drawing.Size(61, 17)
        Me.chkMedian.TabIndex = 1
        Me.chkMedian.Tag = "Median"
        Me.chkMedian.Text = "Median"
        Me.chkMedian.UseVisualStyleBackColor = True
        '
        'UcrButtonsSubdialogue1
        '
        Me.UcrButtonsSubdialogue1.Location = New System.Drawing.Point(62, 236)
        Me.UcrButtonsSubdialogue1.Name = "UcrButtonsSubdialogue1"
        Me.UcrButtonsSubdialogue1.Size = New System.Drawing.Size(142, 30)
        Me.UcrButtonsSubdialogue1.TabIndex = 3
        '
        'sdgSummaries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 266)
        Me.Controls.Add(Me.grpNumeric)
        Me.Controls.Add(Me.grpCommon)
        Me.Controls.Add(Me.grpNotOrderedFactor)
        Me.Controls.Add(Me.UcrButtonsSubdialogue1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgSummaries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Summaries"
        Me.Text = "Summaries"
        Me.grpCommon.ResumeLayout(False)
        Me.grpCommon.PerformLayout()
        Me.grpNotOrderedFactor.ResumeLayout(False)
        Me.grpNotOrderedFactor.PerformLayout()
        Me.grpNumeric.ResumeLayout(False)
        Me.grpNumeric.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrButtonsSubdialogue1 As ucrButtonsSubdialogue
    Friend WithEvents chkNonMissing As CheckBox
    Friend WithEvents chkNMissing As CheckBox
    Friend WithEvents chkNTotal As CheckBox
    Friend WithEvents chkMode As CheckBox
    Friend WithEvents grpCommon As GroupBox
    Friend WithEvents grpNumeric As GroupBox
    Friend WithEvents chkMean As CheckBox
    Friend WithEvents chkRange As CheckBox
    Friend WithEvents chkVariance As CheckBox
    Friend WithEvents chkStdDev As CheckBox
    Friend WithEvents chkQuartiles As CheckBox
    Friend WithEvents chkMedian As CheckBox
    Friend WithEvents chkSum As CheckBox
    Friend WithEvents grpNotOrderedFactor As GroupBox
    Friend WithEvents chkMinimum As CheckBox
    Friend WithEvents chkMaximum As CheckBox
End Class