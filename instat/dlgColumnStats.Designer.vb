﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.ucrChkStoreResults = New instat.ucrCheck()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrChkPrintOutput = New instat.ucrCheck()
        Me.ucrChkdropUnusedLevels = New instat.ucrCheck()
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
        Me.lblSelectedVariables.TabIndex = 1
        Me.lblSelectedVariables.Text = "Variables To Summarise:"
        '
        'lblByFactors
        '
        Me.lblByFactors.AutoSize = True
        Me.lblByFactors.Location = New System.Drawing.Point(264, 155)
        Me.lblByFactors.Name = "lblByFactors"
        Me.lblByFactors.Size = New System.Drawing.Size(66, 13)
        Me.lblByFactors.TabIndex = 3
        Me.lblByFactors.Text = "By Factor(s):"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrChkStoreResults)
        Me.grpOptions.Controls.Add(Me.ucrChkOmitMissing)
        Me.grpOptions.Controls.Add(Me.ucrChkPrintOutput)
        Me.grpOptions.Controls.Add(Me.ucrChkdropUnusedLevels)
        Me.grpOptions.Location = New System.Drawing.Point(9, 190)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(160, 121)
        Me.grpOptions.TabIndex = 5
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'ucrChkStoreResults
        '
        Me.ucrChkStoreResults.bAddRemoveParameter = True
        Me.ucrChkStoreResults.bChangeParameterValue = True
        Me.ucrChkStoreResults.Checked = False
        Me.ucrChkStoreResults.Location = New System.Drawing.Point(6, 17)
        Me.ucrChkStoreResults.Name = "ucrChkStoreResults"
        Me.ucrChkStoreResults.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkStoreResults.TabIndex = 0
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.bAddRemoveParameter = True
        Me.ucrChkOmitMissing.bChangeParameterValue = True
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(6, 94)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkOmitMissing.TabIndex = 3
        '
        'ucrChkPrintOutput
        '
        Me.ucrChkPrintOutput.bAddRemoveParameter = True
        Me.ucrChkPrintOutput.bChangeParameterValue = True
        Me.ucrChkPrintOutput.Checked = False
        Me.ucrChkPrintOutput.Location = New System.Drawing.Point(6, 43)
        Me.ucrChkPrintOutput.Name = "ucrChkPrintOutput"
        Me.ucrChkPrintOutput.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkPrintOutput.TabIndex = 1
        '
        'ucrChkdropUnusedLevels
        '
        Me.ucrChkdropUnusedLevels.bAddRemoveParameter = True
        Me.ucrChkdropUnusedLevels.bChangeParameterValue = True
        Me.ucrChkdropUnusedLevels.Checked = False
        Me.ucrChkdropUnusedLevels.Location = New System.Drawing.Point(6, 69)
        Me.ucrChkdropUnusedLevels.Name = "ucrChkdropUnusedLevels"
        Me.ucrChkdropUnusedLevels.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkdropUnusedLevels.TabIndex = 2
        '
        'cmdSummaries
        '
        Me.cmdSummaries.Location = New System.Drawing.Point(330, 286)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(75, 23)
        Me.cmdSummaries.TabIndex = 6
        Me.cmdSummaries.Tag = "Summaries"
        Me.cmdSummaries.Text = "Summaries..."
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'ucrReceiverByFactor
        '
        Me.ucrReceiverByFactor.bAddRemoveParameter = True
        Me.ucrReceiverByFactor.bChangeParameterValue = True
        Me.ucrReceiverByFactor.frmParent = Me
        Me.ucrReceiverByFactor.Location = New System.Drawing.Point(267, 172)
        Me.ucrReceiverByFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverByFactor.Name = "ucrReceiverByFactor"
        Me.ucrReceiverByFactor.Selector = Nothing
        Me.ucrReceiverByFactor.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverByFactor.TabIndex = 4
        '
        'ucrReceiverSelectedVariables
        '
        Me.ucrReceiverSelectedVariables.bAddRemoveParameter = True
        Me.ucrReceiverSelectedVariables.bChangeParameterValue = True
        Me.ucrReceiverSelectedVariables.frmParent = Me
        Me.ucrReceiverSelectedVariables.Location = New System.Drawing.Point(267, 46)
        Me.ucrReceiverSelectedVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelectedVariables.Name = "ucrReceiverSelectedVariables"
        Me.ucrReceiverSelectedVariables.Selector = Nothing
        Me.ucrReceiverSelectedVariables.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverSelectedVariables.TabIndex = 2
        '
        'ucrSelectorForColumnStatistics
        '
        Me.ucrSelectorForColumnStatistics.bAddRemoveParameter = True
        Me.ucrSelectorForColumnStatistics.bChangeParameterValue = True
        Me.ucrSelectorForColumnStatistics.bShowHiddenColumns = False
        Me.ucrSelectorForColumnStatistics.bUseCurrentFilter = True
        Me.ucrSelectorForColumnStatistics.Location = New System.Drawing.Point(9, 7)
        Me.ucrSelectorForColumnStatistics.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForColumnStatistics.Name = "ucrSelectorForColumnStatistics"
        Me.ucrSelectorForColumnStatistics.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForColumnStatistics.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 317)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(402, 53)
        Me.ucrBase.TabIndex = 7
        '
        'dlgColumnStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 381)
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
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents ucrChkStoreResults As ucrCheck
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents ucrChkPrintOutput As ucrCheck
    Friend WithEvents ucrChkdropUnusedLevels As ucrCheck
End Class
