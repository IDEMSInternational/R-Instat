<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgColumnStats
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
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.lblByFactors = New System.Windows.Forms.Label()
        Me.grpSummaries = New System.Windows.Forms.GroupBox()
        Me.chkSum = New System.Windows.Forms.CheckBox()
        Me.chkStDev = New System.Windows.Forms.CheckBox()
        Me.chkMedian = New System.Windows.Forms.CheckBox()
        Me.chkMissingValues = New System.Windows.Forms.CheckBox()
        Me.chkMaximum = New System.Windows.Forms.CheckBox()
        Me.chkMinimum = New System.Windows.Forms.CheckBox()
        Me.chkMean = New System.Windows.Forms.CheckBox()
        Me.chkCount = New System.Windows.Forms.CheckBox()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.chkdropUnusedLevels = New System.Windows.Forms.CheckBox()
        Me.chkReturnOutput = New System.Windows.Forms.CheckBox()
        Me.chkStoreResults = New System.Windows.Forms.CheckBox()
        Me.ucrInputStoreResults = New instat.ucrInputComboBox()
        Me.ucrReceiverByFactor = New instat.ucrReceiverMultiple()
        Me.ucrReceiverSelectedVariables = New instat.ucrReceiverMultiple()
        Me.ucrSelectorForColumnStatistics = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.chkRange = New System.Windows.Forms.CheckBox()
        Me.chkMode = New System.Windows.Forms.CheckBox()
        Me.grpSummaries.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(243, 13)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(99, 13)
        Me.lblSelectedVariables.TabIndex = 4
        Me.lblSelectedVariables.Text = "Selected Varable(s)"
        '
        'lblByFactors
        '
        Me.lblByFactors.AutoSize = True
        Me.lblByFactors.Location = New System.Drawing.Point(243, 141)
        Me.lblByFactors.Name = "lblByFactors"
        Me.lblByFactors.Size = New System.Drawing.Size(63, 13)
        Me.lblByFactors.TabIndex = 5
        Me.lblByFactors.Text = "By Factor(s)"
        '
        'grpSummaries
        '
        Me.grpSummaries.Controls.Add(Me.chkMode)
        Me.grpSummaries.Controls.Add(Me.chkRange)
        Me.grpSummaries.Controls.Add(Me.chkSum)
        Me.grpSummaries.Controls.Add(Me.chkStDev)
        Me.grpSummaries.Controls.Add(Me.chkMedian)
        Me.grpSummaries.Controls.Add(Me.chkMissingValues)
        Me.grpSummaries.Controls.Add(Me.chkMaximum)
        Me.grpSummaries.Controls.Add(Me.chkMinimum)
        Me.grpSummaries.Controls.Add(Me.chkMean)
        Me.grpSummaries.Controls.Add(Me.chkCount)
        Me.grpSummaries.Location = New System.Drawing.Point(13, 197)
        Me.grpSummaries.Name = "grpSummaries"
        Me.grpSummaries.Size = New System.Drawing.Size(200, 148)
        Me.grpSummaries.TabIndex = 8
        Me.grpSummaries.TabStop = False
        Me.grpSummaries.Text = "Summaries"
        '
        'chkSum
        '
        Me.chkSum.AutoSize = True
        Me.chkSum.Location = New System.Drawing.Point(96, 91)
        Me.chkSum.Name = "chkSum"
        Me.chkSum.Size = New System.Drawing.Size(47, 17)
        Me.chkSum.TabIndex = 7
        Me.chkSum.Text = "Sum"
        Me.chkSum.UseVisualStyleBackColor = True
        '
        'chkStDev
        '
        Me.chkStDev.AutoSize = True
        Me.chkStDev.Location = New System.Drawing.Point(96, 67)
        Me.chkStDev.Name = "chkStDev"
        Me.chkStDev.Size = New System.Drawing.Size(59, 17)
        Me.chkStDev.TabIndex = 6
        Me.chkStDev.Text = "St.Dev"
        Me.chkStDev.UseVisualStyleBackColor = True
        '
        'chkMedian
        '
        Me.chkMedian.AutoSize = True
        Me.chkMedian.Location = New System.Drawing.Point(96, 43)
        Me.chkMedian.Name = "chkMedian"
        Me.chkMedian.Size = New System.Drawing.Size(61, 17)
        Me.chkMedian.TabIndex = 5
        Me.chkMedian.Text = "Median"
        Me.chkMedian.UseVisualStyleBackColor = True
        '
        'chkMissingValues
        '
        Me.chkMissingValues.AutoSize = True
        Me.chkMissingValues.Location = New System.Drawing.Point(96, 20)
        Me.chkMissingValues.Name = "chkMissingValues"
        Me.chkMissingValues.Size = New System.Drawing.Size(97, 17)
        Me.chkMissingValues.TabIndex = 4
        Me.chkMissingValues.Text = "MIssing Values"
        Me.chkMissingValues.UseVisualStyleBackColor = True
        '
        'chkMaximum
        '
        Me.chkMaximum.AutoSize = True
        Me.chkMaximum.Location = New System.Drawing.Point(7, 91)
        Me.chkMaximum.Name = "chkMaximum"
        Me.chkMaximum.Size = New System.Drawing.Size(70, 17)
        Me.chkMaximum.TabIndex = 3
        Me.chkMaximum.Text = "Maximum"
        Me.chkMaximum.UseVisualStyleBackColor = True
        '
        'chkMinimum
        '
        Me.chkMinimum.AutoSize = True
        Me.chkMinimum.Location = New System.Drawing.Point(7, 67)
        Me.chkMinimum.Name = "chkMinimum"
        Me.chkMinimum.Size = New System.Drawing.Size(67, 17)
        Me.chkMinimum.TabIndex = 2
        Me.chkMinimum.Text = "Minimum"
        Me.chkMinimum.UseVisualStyleBackColor = True
        '
        'chkMean
        '
        Me.chkMean.AutoSize = True
        Me.chkMean.Location = New System.Drawing.Point(7, 43)
        Me.chkMean.Name = "chkMean"
        Me.chkMean.Size = New System.Drawing.Size(53, 17)
        Me.chkMean.TabIndex = 1
        Me.chkMean.Text = "Mean"
        Me.chkMean.UseVisualStyleBackColor = True
        '
        'chkCount
        '
        Me.chkCount.AutoSize = True
        Me.chkCount.Location = New System.Drawing.Point(7, 20)
        Me.chkCount.Name = "chkCount"
        Me.chkCount.Size = New System.Drawing.Size(54, 17)
        Me.chkCount.TabIndex = 0
        Me.chkCount.Text = "Count"
        Me.chkCount.UseVisualStyleBackColor = True
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkdropUnusedLevels)
        Me.grpOptions.Controls.Add(Me.chkReturnOutput)
        Me.grpOptions.Location = New System.Drawing.Point(246, 264)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(164, 81)
        Me.grpOptions.TabIndex = 9
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'chkdropUnusedLevels
        '
        Me.chkdropUnusedLevels.AutoSize = True
        Me.chkdropUnusedLevels.Location = New System.Drawing.Point(7, 40)
        Me.chkdropUnusedLevels.Name = "chkdropUnusedLevels"
        Me.chkdropUnusedLevels.Size = New System.Drawing.Size(89, 30)
        Me.chkdropUnusedLevels.TabIndex = 1
        Me.chkdropUnusedLevels.Text = "Drop Unused" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Levels"
        Me.chkdropUnusedLevels.UseVisualStyleBackColor = True
        '
        'chkReturnOutput
        '
        Me.chkReturnOutput.AutoSize = True
        Me.chkReturnOutput.Location = New System.Drawing.Point(7, 20)
        Me.chkReturnOutput.Name = "chkReturnOutput"
        Me.chkReturnOutput.Size = New System.Drawing.Size(93, 17)
        Me.chkReturnOutput.TabIndex = 0
        Me.chkReturnOutput.Text = "Return Output"
        Me.chkReturnOutput.UseVisualStyleBackColor = True
        '
        'chkStoreResults
        '
        Me.chkStoreResults.AutoSize = True
        Me.chkStoreResults.Location = New System.Drawing.Point(11, 356)
        Me.chkStoreResults.Name = "chkStoreResults"
        Me.chkStoreResults.Size = New System.Drawing.Size(89, 17)
        Me.chkStoreResults.TabIndex = 10
        Me.chkStoreResults.Text = "Store Results"
        Me.chkStoreResults.UseVisualStyleBackColor = True
        '
        'ucrInputStoreResults
        '
        Me.ucrInputStoreResults.IsReadOnly = False
        Me.ucrInputStoreResults.Location = New System.Drawing.Point(109, 352)
        Me.ucrInputStoreResults.Name = "ucrInputStoreResults"
        Me.ucrInputStoreResults.Size = New System.Drawing.Size(104, 21)
        Me.ucrInputStoreResults.TabIndex = 11
        '
        'ucrReceiverByFactor
        '
        Me.ucrReceiverByFactor.Location = New System.Drawing.Point(246, 158)
        Me.ucrReceiverByFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverByFactor.Name = "ucrReceiverByFactor"
        Me.ucrReceiverByFactor.Selector = Nothing
        Me.ucrReceiverByFactor.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverByFactor.TabIndex = 7
        '
        'ucrReceiverSelectedVariables
        '
        Me.ucrReceiverSelectedVariables.Location = New System.Drawing.Point(246, 32)
        Me.ucrReceiverSelectedVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelectedVariables.Name = "ucrReceiverSelectedVariables"
        Me.ucrReceiverSelectedVariables.Selector = Nothing
        Me.ucrReceiverSelectedVariables.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverSelectedVariables.TabIndex = 6
        '
        'ucrSelectorForColumnStatistics
        '
        Me.ucrSelectorForColumnStatistics.Location = New System.Drawing.Point(13, 13)
        Me.ucrSelectorForColumnStatistics.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForColumnStatistics.Name = "ucrSelectorForColumnStatistics"
        Me.ucrSelectorForColumnStatistics.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForColumnStatistics.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(11, 379)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 2
        '
        'chkRange
        '
        Me.chkRange.AutoSize = True
        Me.chkRange.Location = New System.Drawing.Point(7, 115)
        Me.chkRange.Name = "chkRange"
        Me.chkRange.Size = New System.Drawing.Size(58, 17)
        Me.chkRange.TabIndex = 8
        Me.chkRange.Text = "Range"
        Me.chkRange.UseVisualStyleBackColor = True
        '
        'chkMode
        '
        Me.chkMode.AutoSize = True
        Me.chkMode.Location = New System.Drawing.Point(96, 115)
        Me.chkMode.Name = "chkMode"
        Me.chkMode.Size = New System.Drawing.Size(53, 17)
        Me.chkMode.TabIndex = 9
        Me.chkMode.Text = "Mode"
        Me.chkMode.UseVisualStyleBackColor = True
        '
        'dlgColumnStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 444)
        Me.Controls.Add(Me.ucrInputStoreResults)
        Me.Controls.Add(Me.chkStoreResults)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.grpSummaries)
        Me.Controls.Add(Me.ucrReceiverByFactor)
        Me.Controls.Add(Me.ucrReceiverSelectedVariables)
        Me.Controls.Add(Me.lblByFactors)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ucrSelectorForColumnStatistics)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgColumnStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Column_Statistics"
        Me.Text = "Column Statistics"
        Me.grpSummaries.ResumeLayout(False)
        Me.grpSummaries.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForColumnStatistics As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents lblByFactors As Label
    Friend WithEvents ucrReceiverSelectedVariables As ucrReceiverMultiple
    Friend WithEvents ucrReceiverByFactor As ucrReceiverMultiple
    Friend WithEvents grpSummaries As GroupBox
    Friend WithEvents chkMedian As CheckBox
    Friend WithEvents chkMissingValues As CheckBox
    Friend WithEvents chkMaximum As CheckBox
    Friend WithEvents chkMinimum As CheckBox
    Friend WithEvents chkMean As CheckBox
    Friend WithEvents chkCount As CheckBox
    Friend WithEvents chkSum As CheckBox
    Friend WithEvents chkStDev As CheckBox
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents chkdropUnusedLevels As CheckBox
    Friend WithEvents chkReturnOutput As CheckBox
    Friend WithEvents chkStoreResults As CheckBox
    Friend WithEvents ucrInputStoreResults As ucrInputComboBox
    Friend WithEvents chkMode As CheckBox
    Friend WithEvents chkRange As CheckBox
End Class
