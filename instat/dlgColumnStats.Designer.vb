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
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.chkOmitMissing = New System.Windows.Forms.CheckBox()
        Me.chkdropUnusedLevels = New System.Windows.Forms.CheckBox()
        Me.chkStoreResults = New System.Windows.Forms.CheckBox()
        Me.chkPrintOutput = New System.Windows.Forms.CheckBox()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.ucrReceiverByFactor = New instat.ucrReceiverMultiple()
        Me.ucrReceiverSelectedVariables = New instat.ucrReceiverMultiple()
        Me.ucrSelectorForColumnStatistics = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(264, 27)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(123, 13)
        Me.lblSelectedVariables.TabIndex = 4
        Me.lblSelectedVariables.Text = "Variables To Summarise:"
        '
        'lblByFactors
        '
        Me.lblByFactors.AutoSize = True
        Me.lblByFactors.Location = New System.Drawing.Point(264, 155)
        Me.lblByFactors.Name = "lblByFactors"
        Me.lblByFactors.Size = New System.Drawing.Size(66, 13)
        Me.lblByFactors.TabIndex = 5
        Me.lblByFactors.Text = "By Factor(s):"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkOmitMissing)
        Me.grpOptions.Controls.Add(Me.chkdropUnusedLevels)
        Me.grpOptions.Controls.Add(Me.chkStoreResults)
        Me.grpOptions.Controls.Add(Me.chkPrintOutput)
        Me.grpOptions.Location = New System.Drawing.Point(9, 197)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(184, 112)
        Me.grpOptions.TabIndex = 9
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'chkOmitMissing
        '
        Me.chkOmitMissing.Location = New System.Drawing.Point(7, 85)
        Me.chkOmitMissing.Name = "chkOmitMissing"
        Me.chkOmitMissing.Size = New System.Drawing.Size(126, 25)
        Me.chkOmitMissing.TabIndex = 11
        Me.chkOmitMissing.Text = "Omit Missing Values"
        Me.chkOmitMissing.UseVisualStyleBackColor = True
        '
        'chkdropUnusedLevels
        '
        Me.chkdropUnusedLevels.Location = New System.Drawing.Point(7, 61)
        Me.chkdropUnusedLevels.Name = "chkdropUnusedLevels"
        Me.chkdropUnusedLevels.Size = New System.Drawing.Size(126, 25)
        Me.chkdropUnusedLevels.TabIndex = 1
        Me.chkdropUnusedLevels.Text = "Drop Unused Levels"
        Me.chkdropUnusedLevels.UseVisualStyleBackColor = True
        '
        'chkStoreResults
        '
        Me.chkStoreResults.AutoSize = True
        Me.chkStoreResults.Location = New System.Drawing.Point(7, 18)
        Me.chkStoreResults.Name = "chkStoreResults"
        Me.chkStoreResults.Size = New System.Drawing.Size(158, 17)
        Me.chkStoreResults.TabIndex = 10
        Me.chkStoreResults.Text = "Store Results in Data Frame"
        Me.chkStoreResults.UseVisualStyleBackColor = True
        '
        'chkPrintOutput
        '
        Me.chkPrintOutput.AutoSize = True
        Me.chkPrintOutput.Location = New System.Drawing.Point(7, 41)
        Me.chkPrintOutput.Name = "chkPrintOutput"
        Me.chkPrintOutput.Size = New System.Drawing.Size(174, 17)
        Me.chkPrintOutput.TabIndex = 0
        Me.chkPrintOutput.Text = "Print Results to Output Window"
        Me.chkPrintOutput.UseVisualStyleBackColor = True
        '
        'cmdSummaries
        '
        Me.cmdSummaries.Location = New System.Drawing.Point(330, 286)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(75, 23)
        Me.cmdSummaries.TabIndex = 10
        Me.cmdSummaries.Tag = "Summaries"
        Me.cmdSummaries.Text = "Summaries..."
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'ucrReceiverByFactor
        '
        Me.ucrReceiverByFactor.Location = New System.Drawing.Point(267, 172)
        Me.ucrReceiverByFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverByFactor.Name = "ucrReceiverByFactor"
        Me.ucrReceiverByFactor.Selector = Nothing
        Me.ucrReceiverByFactor.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverByFactor.TabIndex = 7
        '
        'ucrReceiverSelectedVariables
        '
        Me.ucrReceiverSelectedVariables.Location = New System.Drawing.Point(267, 46)
        Me.ucrReceiverSelectedVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelectedVariables.Name = "ucrReceiverSelectedVariables"
        Me.ucrReceiverSelectedVariables.Selector = Nothing
        Me.ucrReceiverSelectedVariables.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverSelectedVariables.TabIndex = 6
        '
        'ucrSelectorForColumnStatistics
        '
        Me.ucrSelectorForColumnStatistics.bShowHiddenColumns = False
        Me.ucrSelectorForColumnStatistics.bUseCurrentFilter = True
        Me.ucrSelectorForColumnStatistics.Location = New System.Drawing.Point(9, 7)
        Me.ucrSelectorForColumnStatistics.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForColumnStatistics.Name = "ucrSelectorForColumnStatistics"
        Me.ucrSelectorForColumnStatistics.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForColumnStatistics.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 317)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(402, 53)
        Me.ucrBase.TabIndex = 2
        '
        'dlgColumnStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 374)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.ucrReceiverByFactor)
        Me.Controls.Add(Me.ucrReceiverSelectedVariables)
        Me.Controls.Add(Me.lblByFactors)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ucrSelectorForColumnStatistics)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgColumnStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Column_Statistics"
        Me.Text = "Column Statistics"
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
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents chkdropUnusedLevels As CheckBox
    Friend WithEvents chkPrintOutput As CheckBox
    Friend WithEvents chkStoreResults As CheckBox
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents chkOmitMissing As CheckBox
End Class
