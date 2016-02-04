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
        Me.ucrReceiverRowStatistics = New instat.ucrReceiverMultiple()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.ucrNewColumnName = New instat.ucrNewColumnName()
        Me.grpStatistic = New System.Windows.Forms.GroupBox()
        Me.rdoMinimum = New System.Windows.Forms.RadioButton()
        Me.rdoMaximum = New System.Windows.Forms.RadioButton()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.rdoMean = New System.Windows.Forms.RadioButton()
        Me.rdoStandardDeviation = New System.Windows.Forms.RadioButton()
        Me.rdoSum = New System.Windows.Forms.RadioButton()
        Me.ucrSelectorDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpStatistic.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 309)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 60)
        Me.ucrBase.TabIndex = 6
        '
        'ucrReceiverRowStatistics
        '
        Me.ucrReceiverRowStatistics.Location = New System.Drawing.Point(272, 85)
        Me.ucrReceiverRowStatistics.Name = "ucrReceiverRowStatistics"
        Me.ucrReceiverRowStatistics.Size = New System.Drawing.Size(121, 106)
        Me.ucrReceiverRowStatistics.TabIndex = 18
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(269, 69)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(49, 13)
        Me.lblSelected.TabIndex = 19
        Me.lblSelected.Tag = "Selected"
        Me.lblSelected.Text = "Selected"
        '
        'ucrNewColumnName
        '
        Me.ucrNewColumnName.Location = New System.Drawing.Point(12, 268)
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        Me.ucrNewColumnName.Size = New System.Drawing.Size(367, 35)
        Me.ucrNewColumnName.TabIndex = 20
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
        Me.grpStatistic.TabIndex = 21
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
        Me.rdoMinimum.TabIndex = 0
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
        Me.rdoMaximum.TabIndex = 0
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
        Me.rdoCount.TabIndex = 0
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
        Me.rdoStandardDeviation.TabIndex = 0
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
        Me.rdoSum.TabIndex = 0
        Me.rdoSum.TabStop = True
        Me.rdoSum.Tag = "Sum"
        Me.rdoSum.Text = "Sum"
        Me.rdoSum.UseVisualStyleBackColor = True
        '
        'ucrSelectorDataFrame
        '
        Me.ucrSelectorDataFrame.Location = New System.Drawing.Point(12, 12)
        Me.ucrSelectorDataFrame.Name = "ucrSelectorDataFrame"
        Me.ucrSelectorDataFrame.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorDataFrame.TabIndex = 22
        '
        'dlgRowStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 377)
        Me.Controls.Add(Me.ucrSelectorDataFrame)
        Me.Controls.Add(Me.grpStatistic)
        Me.Controls.Add(Me.ucrNewColumnName)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrReceiverRowStatistics)
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
    Friend WithEvents ucrReceiverRowStatistics As ucrReceiverMultiple
    Friend WithEvents lblSelected As Label
    Friend WithEvents ucrNewColumnName As ucrNewColumnName
    Friend WithEvents grpStatistic As GroupBox
    Friend WithEvents rdoMinimum As RadioButton
    Friend WithEvents rdoMaximum As RadioButton
    Friend WithEvents rdoCount As RadioButton
    Friend WithEvents rdoMean As RadioButton
    Friend WithEvents rdoStandardDeviation As RadioButton
    Friend WithEvents rdoSum As RadioButton
    Friend WithEvents ucrSelectorDataFrame As ucrSelectorByDataFrameAddRemove
End Class
