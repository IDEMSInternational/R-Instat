﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.grpStatistic = New System.Windows.Forms.GroupBox()
        Me.rdoMinimum = New System.Windows.Forms.RadioButton()
        Me.rdoMaximum = New System.Windows.Forms.RadioButton()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.rdoMean = New System.Windows.Forms.RadioButton()
        Me.rdoStandardDeviation = New System.Windows.Forms.RadioButton()
        Me.rdoNumberofMissing = New System.Windows.Forms.RadioButton()
        Me.rdoMedian = New System.Windows.Forms.RadioButton()
        Me.rdoSum = New System.Windows.Forms.RadioButton()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.cmdUserDefined = New System.Windows.Forms.Button()
        Me.ucrInputcboRowSummary = New instat.ucrInputComboBox()
        Me.ucrSelectorForRowStats = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverForRowStatistics = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpStatistic.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(269, 26)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(49, 13)
        Me.lblSelected.TabIndex = 1
        Me.lblSelected.Tag = "Selected"
        Me.lblSelected.Text = "Selected"
        '
        'grpStatistic
        '
        Me.grpStatistic.Controls.Add(Me.rdoMinimum)
        Me.grpStatistic.Controls.Add(Me.rdoMaximum)
        Me.grpStatistic.Controls.Add(Me.rdoCount)
        Me.grpStatistic.Controls.Add(Me.rdoMean)
        Me.grpStatistic.Controls.Add(Me.rdoStandardDeviation)
        Me.grpStatistic.Controls.Add(Me.rdoNumberofMissing)
        Me.grpStatistic.Controls.Add(Me.rdoMedian)
        Me.grpStatistic.Controls.Add(Me.rdoSum)
        Me.grpStatistic.Location = New System.Drawing.Point(12, 197)
        Me.grpStatistic.Name = "grpStatistic"
        Me.grpStatistic.Size = New System.Drawing.Size(410, 65)
        Me.grpStatistic.TabIndex = 3
        Me.grpStatistic.TabStop = False
        Me.grpStatistic.Tag = "Statistic"
        Me.grpStatistic.Text = "Statistic"
        '
        'rdoMinimum
        '
        Me.rdoMinimum.AutoSize = True
        Me.rdoMinimum.Location = New System.Drawing.Point(121, 19)
        Me.rdoMinimum.Name = "rdoMinimum"
        Me.rdoMinimum.Size = New System.Drawing.Size(66, 17)
        Me.rdoMinimum.TabIndex = 2
        Me.rdoMinimum.TabStop = True
        Me.rdoMinimum.Tag = "Minimum"
        Me.rdoMinimum.Text = "Minimum"
        Me.rdoMinimum.UseVisualStyleBackColor = True
        '
        'rdoMaximum
        '
        Me.rdoMaximum.AutoSize = True
        Me.rdoMaximum.Location = New System.Drawing.Point(241, 42)
        Me.rdoMaximum.Name = "rdoMaximum"
        Me.rdoMaximum.Size = New System.Drawing.Size(69, 17)
        Me.rdoMaximum.TabIndex = 5
        Me.rdoMaximum.TabStop = True
        Me.rdoMaximum.Tag = "Maximum"
        Me.rdoMaximum.Text = "Maximum"
        Me.rdoMaximum.UseVisualStyleBackColor = True
        '
        'rdoCount
        '
        Me.rdoCount.AutoSize = True
        Me.rdoCount.Location = New System.Drawing.Point(338, 42)
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.Size = New System.Drawing.Size(53, 17)
        Me.rdoCount.TabIndex = 7
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
        Me.rdoStandardDeviation.Location = New System.Drawing.Point(121, 42)
        Me.rdoStandardDeviation.Name = "rdoStandardDeviation"
        Me.rdoStandardDeviation.Size = New System.Drawing.Size(114, 17)
        Me.rdoStandardDeviation.TabIndex = 3
        Me.rdoStandardDeviation.TabStop = True
        Me.rdoStandardDeviation.Tag = "Standard_deviation"
        Me.rdoStandardDeviation.Text = "Standard deviation"
        Me.rdoStandardDeviation.UseVisualStyleBackColor = True
        '
        'rdoNumberofMissing
        '
        Me.rdoNumberofMissing.AutoSize = True
        Me.rdoNumberofMissing.Location = New System.Drawing.Point(6, 42)
        Me.rdoNumberofMissing.Name = "rdoNumberofMissing"
        Me.rdoNumberofMissing.Size = New System.Drawing.Size(112, 17)
        Me.rdoNumberofMissing.TabIndex = 1
        Me.rdoNumberofMissing.TabStop = True
        Me.rdoNumberofMissing.Tag = "Number_of_Missing"
        Me.rdoNumberofMissing.Text = "Number of Missing"
        Me.rdoNumberofMissing.UseVisualStyleBackColor = True
        '
        'rdoMedian
        '
        Me.rdoMedian.AutoSize = True
        Me.rdoMedian.Location = New System.Drawing.Point(335, 19)
        Me.rdoMedian.Name = "rdoMedian"
        Me.rdoMedian.Size = New System.Drawing.Size(60, 17)
        Me.rdoMedian.TabIndex = 6
        Me.rdoMedian.TabStop = True
        Me.rdoMedian.Tag = "Median"
        Me.rdoMedian.Text = "Median"
        Me.rdoMedian.UseVisualStyleBackColor = True
        '
        'rdoSum
        '
        Me.rdoSum.AutoSize = True
        Me.rdoSum.Location = New System.Drawing.Point(242, 19)
        Me.rdoSum.Name = "rdoSum"
        Me.rdoSum.Size = New System.Drawing.Size(46, 17)
        Me.rdoSum.TabIndex = 4
        Me.rdoSum.TabStop = True
        Me.rdoSum.Tag = "Sum"
        Me.rdoSum.Text = "Sum"
        Me.rdoSum.UseVisualStyleBackColor = True
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(14, 279)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(98, 13)
        Me.lblNewColumnName.TabIndex = 4
        Me.lblNewColumnName.Tag = "New_Column_Name"
        Me.lblNewColumnName.Text = "New Column Name"
        '
        'cmdUserDefined
        '
        Me.cmdUserDefined.Location = New System.Drawing.Point(319, 273)
        Me.cmdUserDefined.Name = "cmdUserDefined"
        Me.cmdUserDefined.Size = New System.Drawing.Size(100, 23)
        Me.cmdUserDefined.TabIndex = 6
        Me.cmdUserDefined.Tag = "User_Define"
        Me.cmdUserDefined.Text = "User Define"
        Me.cmdUserDefined.UseVisualStyleBackColor = True
        '
        'ucrInputcboRowSummary
        '
        Me.ucrInputcboRowSummary.Location = New System.Drawing.Point(171, 273)
        Me.ucrInputcboRowSummary.Name = "ucrInputcboRowSummary"
        Me.ucrInputcboRowSummary.Size = New System.Drawing.Size(137, 25)
        Me.ucrInputcboRowSummary.TabIndex = 5
        '
        'ucrSelectorForRowStats
        '
        Me.ucrSelectorForRowStats.Location = New System.Drawing.Point(13, 13)
        Me.ucrSelectorForRowStats.Name = "ucrSelectorForRowStats"
        Me.ucrSelectorForRowStats.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorForRowStats.TabIndex = 0
        '
        'ucrReceiverForRowStatistics
        '
        Me.ucrReceiverForRowStatistics.Location = New System.Drawing.Point(272, 42)
        Me.ucrReceiverForRowStatistics.Name = "ucrReceiverForRowStatistics"
        Me.ucrReceiverForRowStatistics.Selector = Nothing
        Me.ucrReceiverForRowStatistics.Size = New System.Drawing.Size(121, 106)
        Me.ucrReceiverForRowStatistics.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 309)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 60)
        Me.ucrBase.TabIndex = 7
        '
        'dlgRowStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 361)
        Me.Controls.Add(Me.cmdUserDefined)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.ucrInputcboRowSummary)
        Me.Controls.Add(Me.ucrSelectorForRowStats)
        Me.Controls.Add(Me.grpStatistic)
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
    Friend WithEvents grpStatistic As GroupBox
    Friend WithEvents rdoMinimum As RadioButton
    Friend WithEvents rdoMaximum As RadioButton
    Friend WithEvents rdoCount As RadioButton
    Friend WithEvents rdoMean As RadioButton
    Friend WithEvents rdoStandardDeviation As RadioButton
    Friend WithEvents rdoSum As RadioButton
    Friend WithEvents ucrSelectorForRowStats As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoNumberofMissing As RadioButton
    Friend WithEvents rdoMedian As RadioButton
    Friend WithEvents ucrInputcboRowSummary As ucrInputComboBox
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents cmdUserDefined As Button
End Class
