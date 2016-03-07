<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgRowStats
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
        Me.ucrBase = New instat.ucrButtons()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.ucrNewColumnSelectorForRowStats = New instat.ucrNewColumnName()
        Me.grpStatistic = New System.Windows.Forms.GroupBox()
        Me.rdoMinimum = New System.Windows.Forms.RadioButton()
        Me.rdoMaximum = New System.Windows.Forms.RadioButton()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.rdoMean = New System.Windows.Forms.RadioButton()
        Me.rdoStandardDeviation = New System.Windows.Forms.RadioButton()
        Me.rdoSum = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverForRowStatistics = New instat.ucrReceiverMultiple()
        Me.ucrSelectorForRowStats = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpStatistic.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 309)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 60)
        Me.ucrBase.TabIndex = 5
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(269, 69)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(49, 13)
        Me.lblSelected.TabIndex = 1
        Me.lblSelected.Tag = "Selected"
        Me.lblSelected.Text = "Selected"
        '
        'ucrNewColumnSelectorForRowStats
        '
        Me.ucrNewColumnSelectorForRowStats.Location = New System.Drawing.Point(12, 268)
        Me.ucrNewColumnSelectorForRowStats.Name = "ucrNewColumnSelectorForRowStats"
        Me.ucrNewColumnSelectorForRowStats.Size = New System.Drawing.Size(367, 35)
        Me.ucrNewColumnSelectorForRowStats.TabIndex = 4
        Me.ucrNewColumnSelectorForRowStats.ucrDataFrameSelector = Nothing
        '
        'grpStatistic
        '
        Me.grpStatistic.Controls.Add(Me.rdoMinimum)
        Me.grpStatistic.Controls.Add(Me.rdoMaximum)
        Me.grpStatistic.Controls.Add(Me.rdoCount)
        Me.grpStatistic.Controls.Add(Me.rdoMean)
        Me.grpStatistic.Controls.Add(Me.rdoStandardDeviation)
        Me.grpStatistic.Controls.Add(Me.rdoSum)
        Me.grpStatistic.Location = New System.Drawing.Point(12, 197)
        Me.grpStatistic.Name = "grpStatistic"
        Me.grpStatistic.Size = New System.Drawing.Size(381, 65)
        Me.grpStatistic.TabIndex = 3
        Me.grpStatistic.TabStop = False
        Me.grpStatistic.Tag = "Statistic"
        Me.grpStatistic.Text = "Statistic"
        '
        'rdoMinimum
        '
        Me.rdoMinimum.AutoSize = True
        Me.rdoMinimum.Location = New System.Drawing.Point(154, 19)
        Me.rdoMinimum.Name = "rdoMinimum"
        Me.rdoMinimum.Size = New System.Drawing.Size(66, 17)
        Me.rdoMinimum.TabIndex = 1
        Me.rdoMinimum.TabStop = True
        Me.rdoMinimum.Tag = "Minimum"
        Me.rdoMinimum.Text = "Minimum"
        Me.rdoMinimum.UseVisualStyleBackColor = True
        '
        'rdoMaximum
        '
        Me.rdoMaximum.AutoSize = True
        Me.rdoMaximum.Location = New System.Drawing.Point(154, 42)
        Me.rdoMaximum.Name = "rdoMaximum"
        Me.rdoMaximum.Size = New System.Drawing.Size(69, 17)
        Me.rdoMaximum.TabIndex = 4
        Me.rdoMaximum.TabStop = True
        Me.rdoMaximum.Tag = "Maximum"
        Me.rdoMaximum.Text = "Maximum"
        Me.rdoMaximum.UseVisualStyleBackColor = True
        '
        'rdoCount
        '
        Me.rdoCount.AutoSize = True
        Me.rdoCount.Location = New System.Drawing.Point(260, 42)
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.Size = New System.Drawing.Size(53, 17)
        Me.rdoCount.TabIndex = 5
        Me.rdoCount.TabStop = True
        Me.rdoCount.Tag = "Count"
        Me.rdoCount.Text = "Count"
        Me.rdoCount.UseVisualStyleBackColor = True
        '
        'rdoMean
        '
        Me.rdoMean.AutoSize = True
        Me.rdoMean.Location = New System.Drawing.Point(6, 19)
        Me.rdoMean.Name = "rdoMean"
        Me.rdoMean.Size = New System.Drawing.Size(52, 17)
        Me.rdoMean.TabIndex = 0
        Me.rdoMean.TabStop = True
        Me.rdoMean.Tag = "Mean"
        Me.rdoMean.Text = "Mean"
        Me.rdoMean.UseVisualStyleBackColor = True
        '
        'rdoStandardDeviation
        '
        Me.rdoStandardDeviation.AutoSize = True
        Me.rdoStandardDeviation.Location = New System.Drawing.Point(6, 42)
        Me.rdoStandardDeviation.Name = "rdoStandardDeviation"
        Me.rdoStandardDeviation.Size = New System.Drawing.Size(114, 17)
        Me.rdoStandardDeviation.TabIndex = 3
        Me.rdoStandardDeviation.TabStop = True
        Me.rdoStandardDeviation.Tag = "Standard_deviation"
        Me.rdoStandardDeviation.Text = "Standard deviation"
        Me.rdoStandardDeviation.UseVisualStyleBackColor = True
        '
        'rdoSum
        '
        Me.rdoSum.AutoSize = True
        Me.rdoSum.Location = New System.Drawing.Point(260, 19)
        Me.rdoSum.Name = "rdoSum"
        Me.rdoSum.Size = New System.Drawing.Size(46, 17)
        Me.rdoSum.TabIndex = 2
        Me.rdoSum.TabStop = True
        Me.rdoSum.Tag = "Sum"
        Me.rdoSum.Text = "Sum"
        Me.rdoSum.UseVisualStyleBackColor = True
        '
        'ucrReceiverForRowStatistics
        '
        Me.ucrReceiverForRowStatistics.Location = New System.Drawing.Point(272, 85)
        Me.ucrReceiverForRowStatistics.Name = "ucrReceiverForRowStatistics"
        Me.ucrReceiverForRowStatistics.Selector = Nothing
        Me.ucrReceiverForRowStatistics.Size = New System.Drawing.Size(121, 106)
        Me.ucrReceiverForRowStatistics.TabIndex = 2
        '
        'ucrSelectorForRowStats
        '
        Me.ucrSelectorForRowStats.Location = New System.Drawing.Point(13, 13)
        Me.ucrSelectorForRowStats.Name = "ucrSelectorForRowStats"
        Me.ucrSelectorForRowStats.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorForRowStats.TabIndex = 0
        '
        'dlgRowStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 377)
        Me.Controls.Add(Me.ucrSelectorForRowStats)
        Me.Controls.Add(Me.grpStatistic)
        Me.Controls.Add(Me.ucrNewColumnSelectorForRowStats)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrReceiverForRowStatistics)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgRowStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Row_statistics"
        Me.Text = "Row statistics"
        Me.grpStatistic.ResumeLayout(False)
        Me.grpStatistic.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverForRowStatistics As ucrReceiverMultiple
    Friend WithEvents lblSelected As Label
    Friend WithEvents ucrNewColumnSelectorForRowStats As ucrNewColumnName
    Friend WithEvents grpStatistic As GroupBox
    Friend WithEvents rdoMinimum As RadioButton
    Friend WithEvents rdoMaximum As RadioButton
    Friend WithEvents rdoCount As RadioButton
    Friend WithEvents rdoMean As RadioButton
    Friend WithEvents rdoStandardDeviation As RadioButton
    Friend WithEvents rdoSum As RadioButton
    Friend WithEvents ucrSelectorForRowStats As ucrSelectorByDataFrameAddRemove
End Class
