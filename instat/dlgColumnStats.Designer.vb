<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgColumnStats
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
        Me.tabColumnStatistics = New System.Windows.Forms.TabControl()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.ucrReceiverMultiple = New instat.ucrReceiverMultiple()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.grpStatistcsRequired = New System.Windows.Forms.GroupBox()
        Me.chkMedian = New System.Windows.Forms.CheckBox()
        Me.chkMissing = New System.Windows.Forms.CheckBox()
        Me.chkSum = New System.Windows.Forms.CheckBox()
        Me.chkStDev = New System.Windows.Forms.CheckBox()
        Me.chkMaximum = New System.Windows.Forms.CheckBox()
        Me.chkMinimum = New System.Windows.Forms.CheckBox()
        Me.chkMean = New System.Windows.Forms.CheckBox()
        Me.chkCount = New System.Windows.Forms.CheckBox()
        Me.grpForByFactors = New System.Windows.Forms.GroupBox()
        Me.chkByFactor = New System.Windows.Forms.CheckBox()
        Me.chkForFactor = New System.Windows.Forms.CheckBox()
        Me.tabSave = New System.Windows.Forms.TabPage()
        Me.chkSaveFittedValuesAndDeviations = New System.Windows.Forms.CheckBox()
        Me.chkSaveStatistics = New System.Windows.Forms.CheckBox()
        Me.tabOptions = New System.Windows.Forms.TabPage()
        Me.chkRestrictDataValues = New System.Windows.Forms.CheckBox()
        Me.grpMissingValues = New System.Windows.Forms.GroupBox()
        Me.chkFeb29th = New System.Windows.Forms.CheckBox()
        Me.chkTrace = New System.Windows.Forms.CheckBox()
        Me.chkMissingData = New System.Windows.Forms.CheckBox()
        Me.chkSetSummaryToMissingIfOver = New System.Windows.Forms.CheckBox()
        Me.chkIgnoreMissingValues = New System.Windows.Forms.CheckBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.tabColumnStatistics.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.grpStatistcsRequired.SuspendLayout()
        Me.grpForByFactors.SuspendLayout()
        Me.tabSave.SuspendLayout()
        Me.tabOptions.SuspendLayout()
        Me.grpMissingValues.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabColumnStatistics
        '
        Me.tabColumnStatistics.Controls.Add(Me.tabGeneral)
        Me.tabColumnStatistics.Controls.Add(Me.tabSave)
        Me.tabColumnStatistics.Controls.Add(Me.tabOptions)
        Me.tabColumnStatistics.Location = New System.Drawing.Point(1, 3)
        Me.tabColumnStatistics.Name = "tabColumnStatistics"
        Me.tabColumnStatistics.SelectedIndex = 0
        Me.tabColumnStatistics.Size = New System.Drawing.Size(554, 269)
        Me.tabColumnStatistics.TabIndex = 8
        Me.tabColumnStatistics.Tag = "Column_Statistics"
        '
        'tabGeneral
        '
        Me.tabGeneral.Controls.Add(Me.lblSelectedVariables)
        Me.tabGeneral.Controls.Add(Me.ucrReceiverMultiple)
        Me.tabGeneral.Controls.Add(Me.ucrAddRemove)
        Me.tabGeneral.Controls.Add(Me.grpStatistcsRequired)
        Me.tabGeneral.Controls.Add(Me.grpForByFactors)
        Me.tabGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(546, 243)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Tag = "General"
        Me.tabGeneral.Text = "General"
        Me.tabGeneral.UseVisualStyleBackColor = True
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(236, 6)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(95, 13)
        Me.lblSelectedVariables.TabIndex = 12
        Me.lblSelectedVariables.Tag = "Selected_Variables"
        Me.lblSelectedVariables.Text = "Selected Variables"
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.Location = New System.Drawing.Point(225, 22)
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Size = New System.Drawing.Size(134, 135)
        Me.ucrReceiverMultiple.TabIndex = 11
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(0, 19)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(208, 140)
        Me.ucrAddRemove.TabIndex = 10
        '
        'grpStatistcsRequired
        '
        Me.grpStatistcsRequired.Controls.Add(Me.chkMedian)
        Me.grpStatistcsRequired.Controls.Add(Me.chkMissing)
        Me.grpStatistcsRequired.Controls.Add(Me.chkSum)
        Me.grpStatistcsRequired.Controls.Add(Me.chkStDev)
        Me.grpStatistcsRequired.Controls.Add(Me.chkMaximum)
        Me.grpStatistcsRequired.Controls.Add(Me.chkMinimum)
        Me.grpStatistcsRequired.Controls.Add(Me.chkMean)
        Me.grpStatistcsRequired.Controls.Add(Me.chkCount)
        Me.grpStatistcsRequired.Location = New System.Drawing.Point(381, 19)
        Me.grpStatistcsRequired.Name = "grpStatistcsRequired"
        Me.grpStatistcsRequired.Size = New System.Drawing.Size(159, 117)
        Me.grpStatistcsRequired.TabIndex = 9
        Me.grpStatistcsRequired.TabStop = False
        Me.grpStatistcsRequired.Tag = "Statistcs_Required"
        Me.grpStatistcsRequired.Text = "StatistcsRequired"
        '
        'chkMedian
        '
        Me.chkMedian.AutoSize = True
        Me.chkMedian.Location = New System.Drawing.Point(87, 43)
        Me.chkMedian.Name = "chkMedian"
        Me.chkMedian.Size = New System.Drawing.Size(61, 17)
        Me.chkMedian.TabIndex = 0
        Me.chkMedian.Tag = "Median"
        Me.chkMedian.Text = "Median"
        Me.chkMedian.UseVisualStyleBackColor = True
        '
        'chkMissing
        '
        Me.chkMissing.AutoSize = True
        Me.chkMissing.Location = New System.Drawing.Point(87, 20)
        Me.chkMissing.Name = "chkMissing"
        Me.chkMissing.Size = New System.Drawing.Size(64, 17)
        Me.chkMissing.TabIndex = 0
        Me.chkMissing.Tag = "Missing"
        Me.chkMissing.Text = "Missing "
        Me.chkMissing.UseVisualStyleBackColor = True
        '
        'chkSum
        '
        Me.chkSum.AutoSize = True
        Me.chkSum.Location = New System.Drawing.Point(87, 89)
        Me.chkSum.Name = "chkSum"
        Me.chkSum.Size = New System.Drawing.Size(47, 17)
        Me.chkSum.TabIndex = 0
        Me.chkSum.Tag = "Sum"
        Me.chkSum.Text = "Sum"
        Me.chkSum.UseVisualStyleBackColor = True
        '
        'chkStDev
        '
        Me.chkStDev.AutoSize = True
        Me.chkStDev.Location = New System.Drawing.Point(87, 66)
        Me.chkStDev.Name = "chkStDev"
        Me.chkStDev.Size = New System.Drawing.Size(62, 17)
        Me.chkStDev.TabIndex = 0
        Me.chkStDev.Tag = "St_Dev"
        Me.chkStDev.Text = "St. Dev"
        Me.chkStDev.UseVisualStyleBackColor = True
        '
        'chkMaximum
        '
        Me.chkMaximum.AutoSize = True
        Me.chkMaximum.Location = New System.Drawing.Point(6, 89)
        Me.chkMaximum.Name = "chkMaximum"
        Me.chkMaximum.Size = New System.Drawing.Size(73, 17)
        Me.chkMaximum.TabIndex = 0
        Me.chkMaximum.Tag = "Maximum"
        Me.chkMaximum.Text = "Maximum "
        Me.chkMaximum.UseVisualStyleBackColor = True
        '
        'chkMinimum
        '
        Me.chkMinimum.AutoSize = True
        Me.chkMinimum.Location = New System.Drawing.Point(7, 66)
        Me.chkMinimum.Name = "chkMinimum"
        Me.chkMinimum.Size = New System.Drawing.Size(67, 17)
        Me.chkMinimum.TabIndex = 0
        Me.chkMinimum.Tag = "Minimum"
        Me.chkMinimum.Text = "Minimum"
        Me.chkMinimum.UseVisualStyleBackColor = True
        '
        'chkMean
        '
        Me.chkMean.AutoSize = True
        Me.chkMean.Location = New System.Drawing.Point(7, 43)
        Me.chkMean.Name = "chkMean"
        Me.chkMean.Size = New System.Drawing.Size(53, 17)
        Me.chkMean.TabIndex = 0
        Me.chkMean.Tag = "Mean"
        Me.chkMean.Text = "Mean"
        Me.chkMean.UseVisualStyleBackColor = True
        '
        'chkCount
        '
        Me.chkCount.AutoSize = True
        Me.chkCount.Location = New System.Drawing.Point(7, 20)
        Me.chkCount.Name = "chkCount"
        Me.chkCount.Size = New System.Drawing.Size(57, 17)
        Me.chkCount.TabIndex = 0
        Me.chkCount.Tag = "Count"
        Me.chkCount.Text = "Count "
        Me.chkCount.UseVisualStyleBackColor = True
        '
        'grpForByFactors
        '
        Me.grpForByFactors.Controls.Add(Me.chkByFactor)
        Me.grpForByFactors.Controls.Add(Me.chkForFactor)
        Me.grpForByFactors.Location = New System.Drawing.Point(6, 161)
        Me.grpForByFactors.Name = "grpForByFactors"
        Me.grpForByFactors.Size = New System.Drawing.Size(262, 66)
        Me.grpForByFactors.TabIndex = 8
        Me.grpForByFactors.TabStop = False
        '
        'chkByFactor
        '
        Me.chkByFactor.AutoSize = True
        Me.chkByFactor.Location = New System.Drawing.Point(7, 43)
        Me.chkByFactor.Name = "chkByFactor"
        Me.chkByFactor.Size = New System.Drawing.Size(74, 17)
        Me.chkByFactor.TabIndex = 1
        Me.chkByFactor.Tag = "By_Factor"
        Me.chkByFactor.Text = "By Factor "
        Me.chkByFactor.UseVisualStyleBackColor = True
        '
        'chkForFactor
        '
        Me.chkForFactor.AutoSize = True
        Me.chkForFactor.Location = New System.Drawing.Point(7, 12)
        Me.chkForFactor.Name = "chkForFactor"
        Me.chkForFactor.Size = New System.Drawing.Size(74, 17)
        Me.chkForFactor.TabIndex = 0
        Me.chkForFactor.Tag = "For_Factor"
        Me.chkForFactor.Text = "For Factor"
        Me.chkForFactor.UseVisualStyleBackColor = True
        '
        'tabSave
        '
        Me.tabSave.Controls.Add(Me.chkSaveFittedValuesAndDeviations)
        Me.tabSave.Controls.Add(Me.chkSaveStatistics)
        Me.tabSave.Location = New System.Drawing.Point(4, 22)
        Me.tabSave.Name = "tabSave"
        Me.tabSave.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSave.Size = New System.Drawing.Size(546, 243)
        Me.tabSave.TabIndex = 1
        Me.tabSave.Tag = "Save"
        Me.tabSave.Text = "Save"
        Me.tabSave.UseVisualStyleBackColor = True
        '
        'chkSaveFittedValuesAndDeviations
        '
        Me.chkSaveFittedValuesAndDeviations.AutoSize = True
        Me.chkSaveFittedValuesAndDeviations.Location = New System.Drawing.Point(9, 57)
        Me.chkSaveFittedValuesAndDeviations.Name = "chkSaveFittedValuesAndDeviations"
        Me.chkSaveFittedValuesAndDeviations.Size = New System.Drawing.Size(183, 17)
        Me.chkSaveFittedValuesAndDeviations.TabIndex = 1
        Me.chkSaveFittedValuesAndDeviations.Tag = "Save_fitted_values_and_deviations"
        Me.chkSaveFittedValuesAndDeviations.Text = "Save fitted values and deviations"
        Me.chkSaveFittedValuesAndDeviations.UseVisualStyleBackColor = True
        '
        'chkSaveStatistics
        '
        Me.chkSaveStatistics.AutoSize = True
        Me.chkSaveStatistics.Location = New System.Drawing.Point(9, 18)
        Me.chkSaveStatistics.Name = "chkSaveStatistics"
        Me.chkSaveStatistics.Size = New System.Drawing.Size(99, 17)
        Me.chkSaveStatistics.TabIndex = 2
        Me.chkSaveStatistics.Tag = "Save_Statistics"
        Me.chkSaveStatistics.Text = "Save Statistics "
        Me.chkSaveStatistics.UseVisualStyleBackColor = True
        '
        'tabOptions
        '
        Me.tabOptions.Controls.Add(Me.chkRestrictDataValues)
        Me.tabOptions.Controls.Add(Me.grpMissingValues)
        Me.tabOptions.Location = New System.Drawing.Point(4, 22)
        Me.tabOptions.Name = "tabOptions"
        Me.tabOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOptions.Size = New System.Drawing.Size(546, 243)
        Me.tabOptions.TabIndex = 2
        Me.tabOptions.Tag = "Options"
        Me.tabOptions.Text = "Options"
        Me.tabOptions.UseVisualStyleBackColor = True
        '
        'chkRestrictDataValues
        '
        Me.chkRestrictDataValues.AutoSize = True
        Me.chkRestrictDataValues.Location = New System.Drawing.Point(7, 6)
        Me.chkRestrictDataValues.Name = "chkRestrictDataValues"
        Me.chkRestrictDataValues.Size = New System.Drawing.Size(123, 17)
        Me.chkRestrictDataValues.TabIndex = 2
        Me.chkRestrictDataValues.Tag = "Restrict_data_values"
        Me.chkRestrictDataValues.Text = "Restrict data values "
        Me.chkRestrictDataValues.UseVisualStyleBackColor = True
        '
        'grpMissingValues
        '
        Me.grpMissingValues.Controls.Add(Me.chkFeb29th)
        Me.grpMissingValues.Controls.Add(Me.chkTrace)
        Me.grpMissingValues.Controls.Add(Me.chkMissingData)
        Me.grpMissingValues.Controls.Add(Me.chkSetSummaryToMissingIfOver)
        Me.grpMissingValues.Controls.Add(Me.chkIgnoreMissingValues)
        Me.grpMissingValues.Location = New System.Drawing.Point(7, 46)
        Me.grpMissingValues.Name = "grpMissingValues"
        Me.grpMissingValues.Size = New System.Drawing.Size(303, 100)
        Me.grpMissingValues.TabIndex = 3
        Me.grpMissingValues.TabStop = False
        '
        'chkFeb29th
        '
        Me.chkFeb29th.AutoSize = True
        Me.chkFeb29th.Location = New System.Drawing.Point(232, 14)
        Me.chkFeb29th.Name = "chkFeb29th"
        Me.chkFeb29th.Size = New System.Drawing.Size(44, 17)
        Me.chkFeb29th.TabIndex = 0
        Me.chkFeb29th.Text = "* * *"
        Me.chkFeb29th.UseVisualStyleBackColor = True
        '
        'chkTrace
        '
        Me.chkTrace.AutoSize = True
        Me.chkTrace.Location = New System.Drawing.Point(191, 14)
        Me.chkTrace.Name = "chkTrace"
        Me.chkTrace.Size = New System.Drawing.Size(37, 17)
        Me.chkTrace.TabIndex = 0
        Me.chkTrace.Text = "* *"
        Me.chkTrace.UseVisualStyleBackColor = True
        '
        'chkMissingData
        '
        Me.chkMissingData.AutoSize = True
        Me.chkMissingData.Location = New System.Drawing.Point(142, 14)
        Me.chkMissingData.Name = "chkMissingData"
        Me.chkMissingData.Size = New System.Drawing.Size(30, 17)
        Me.chkMissingData.TabIndex = 0
        Me.chkMissingData.Text = "*"
        Me.chkMissingData.UseVisualStyleBackColor = True
        '
        'chkSetSummaryToMissingIfOver
        '
        Me.chkSetSummaryToMissingIfOver.AutoSize = True
        Me.chkSetSummaryToMissingIfOver.Location = New System.Drawing.Point(6, 57)
        Me.chkSetSummaryToMissingIfOver.Name = "chkSetSummaryToMissingIfOver"
        Me.chkSetSummaryToMissingIfOver.Size = New System.Drawing.Size(211, 17)
        Me.chkSetSummaryToMissingIfOver.TabIndex = 0
        Me.chkSetSummaryToMissingIfOver.Tag = "Set_summary_if_they_are_over"
        Me.chkSetSummaryToMissingIfOver.Text = "Set summary to missing  if they are over"
        Me.chkSetSummaryToMissingIfOver.UseVisualStyleBackColor = True
        '
        'chkIgnoreMissingValues
        '
        Me.chkIgnoreMissingValues.AutoSize = True
        Me.chkIgnoreMissingValues.Location = New System.Drawing.Point(5, 14)
        Me.chkIgnoreMissingValues.Name = "chkIgnoreMissingValues"
        Me.chkIgnoreMissingValues.Size = New System.Drawing.Size(131, 17)
        Me.chkIgnoreMissingValues.TabIndex = 0
        Me.chkIgnoreMissingValues.Tag = "Ignore_missing_values"
        Me.chkIgnoreMissingValues.Text = "Ignore missing Values "
        Me.chkIgnoreMissingValues.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(72, 279)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 2
        '
        'dlgColumnStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 332)
        Me.Controls.Add(Me.tabColumnStatistics)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgColumnStats"
        Me.Tag = "Column_Statistics"
        Me.Text = "Column Statistics"
        Me.tabColumnStatistics.ResumeLayout(False)
        Me.tabGeneral.ResumeLayout(False)
        Me.tabGeneral.PerformLayout()
        Me.grpStatistcsRequired.ResumeLayout(False)
        Me.grpStatistcsRequired.PerformLayout()
        Me.grpForByFactors.ResumeLayout(False)
        Me.grpForByFactors.PerformLayout()
        Me.tabSave.ResumeLayout(False)
        Me.tabSave.PerformLayout()
        Me.tabOptions.ResumeLayout(False)
        Me.tabOptions.PerformLayout()
        Me.grpMissingValues.ResumeLayout(False)
        Me.grpMissingValues.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents tabColumnStatistics As TabControl
    Friend WithEvents tabGeneral As TabPage
    Friend WithEvents grpStatistcsRequired As GroupBox
    Friend WithEvents chkMedian As CheckBox
    Friend WithEvents chkMissing As CheckBox
    Friend WithEvents chkSum As CheckBox
    Friend WithEvents chkStDev As CheckBox
    Friend WithEvents chkMaximum As CheckBox
    Friend WithEvents chkMinimum As CheckBox
    Friend WithEvents chkMean As CheckBox
    Friend WithEvents chkCount As CheckBox
    Friend WithEvents grpForByFactors As GroupBox
    Friend WithEvents chkByFactor As CheckBox
    Friend WithEvents chkForFactor As CheckBox
    Friend WithEvents tabSave As TabPage
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents ucrReceiverMultiple As ucrReceiverMultiple
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents chkSaveFittedValuesAndDeviations As CheckBox
    Friend WithEvents chkSaveStatistics As CheckBox
    Friend WithEvents tabOptions As TabPage
    Friend WithEvents chkRestrictDataValues As CheckBox
    Friend WithEvents grpMissingValues As GroupBox
    Friend WithEvents chkFeb29th As CheckBox
    Friend WithEvents chkTrace As CheckBox
    Friend WithEvents chkMissingData As CheckBox
    Friend WithEvents chkSetSummaryToMissingIfOver As CheckBox
    Friend WithEvents chkIgnoreMissingValues As CheckBox
End Class
