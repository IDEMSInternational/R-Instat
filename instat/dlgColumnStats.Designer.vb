' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

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
        Me.lblSummariseBy = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.cmdMissingOptions = New System.Windows.Forms.Button()
        Me.ucrChkOriginalLevel = New instat.ucrCheck()
        Me.ucrChkStoreResults = New instat.ucrCheck()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrChkPrintOutput = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevels = New instat.ucrCheck()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.cmdProportionsPercentages = New System.Windows.Forms.Button()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
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
        Me.lblSelectedVariables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectedVariables.Location = New System.Drawing.Point(273, 9)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(125, 13)
        Me.lblSelectedVariables.TabIndex = 1
        Me.lblSelectedVariables.Text = "Variable(s) to Summarise:"
        '
        'lblSummariseBy
        '
        Me.lblSummariseBy.AutoSize = True
        Me.lblSummariseBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummariseBy.Location = New System.Drawing.Point(272, 176)
        Me.lblSummariseBy.Name = "lblSummariseBy"
        Me.lblSummariseBy.Size = New System.Drawing.Size(76, 13)
        Me.lblSummariseBy.TabIndex = 5
        Me.lblSummariseBy.Text = "Summarise By:"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.cmdMissingOptions)
        Me.grpOptions.Controls.Add(Me.ucrChkOriginalLevel)
        Me.grpOptions.Controls.Add(Me.ucrChkStoreResults)
        Me.grpOptions.Controls.Add(Me.ucrChkOmitMissing)
        Me.grpOptions.Controls.Add(Me.ucrChkPrintOutput)
        Me.grpOptions.Controls.Add(Me.ucrChkDropUnusedLevels)
        Me.grpOptions.Location = New System.Drawing.Point(10, 196)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(258, 155)
        Me.grpOptions.TabIndex = 7
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'cmdMissingOptions
        '
        Me.cmdMissingOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMissingOptions.Location = New System.Drawing.Point(190, 114)
        Me.cmdMissingOptions.Name = "cmdMissingOptions"
        Me.cmdMissingOptions.Size = New System.Drawing.Size(62, 26)
        Me.cmdMissingOptions.TabIndex = 20
        Me.cmdMissingOptions.Tag = "MissingOptions"
        Me.cmdMissingOptions.Text = "Options"
        Me.cmdMissingOptions.UseVisualStyleBackColor = True
        '
        'ucrChkOriginalLevel
        '
        Me.ucrChkOriginalLevel.AutoSize = True
        Me.ucrChkOriginalLevel.Checked = False
        Me.ucrChkOriginalLevel.Location = New System.Drawing.Point(25, 42)
        Me.ucrChkOriginalLevel.Name = "ucrChkOriginalLevel"
        Me.ucrChkOriginalLevel.Size = New System.Drawing.Size(218, 23)
        Me.ucrChkOriginalLevel.TabIndex = 1
        '
        'ucrChkStoreResults
        '
        Me.ucrChkStoreResults.AutoSize = True
        Me.ucrChkStoreResults.Checked = False
        Me.ucrChkStoreResults.Location = New System.Drawing.Point(6, 17)
        Me.ucrChkStoreResults.Name = "ucrChkStoreResults"
        Me.ucrChkStoreResults.Size = New System.Drawing.Size(237, 23)
        Me.ucrChkStoreResults.TabIndex = 0
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.AutoSize = True
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(6, 117)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(178, 23)
        Me.ucrChkOmitMissing.TabIndex = 4
        '
        'ucrChkPrintOutput
        '
        Me.ucrChkPrintOutput.AutoSize = True
        Me.ucrChkPrintOutput.Checked = False
        Me.ucrChkPrintOutput.Location = New System.Drawing.Point(6, 67)
        Me.ucrChkPrintOutput.Name = "ucrChkPrintOutput"
        Me.ucrChkPrintOutput.Size = New System.Drawing.Size(246, 23)
        Me.ucrChkPrintOutput.TabIndex = 2
        '
        'ucrChkDropUnusedLevels
        '
        Me.ucrChkDropUnusedLevels.AutoSize = True
        Me.ucrChkDropUnusedLevels.Checked = False
        Me.ucrChkDropUnusedLevels.Location = New System.Drawing.Point(6, 92)
        Me.ucrChkDropUnusedLevels.Name = "ucrChkDropUnusedLevels"
        Me.ucrChkDropUnusedLevels.Size = New System.Drawing.Size(237, 23)
        Me.ucrChkDropUnusedLevels.TabIndex = 3
        '
        'cmdSummaries
        '
        Me.cmdSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSummaries.Location = New System.Drawing.Point(274, 302)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(134, 23)
        Me.cmdSummaries.TabIndex = 8
        Me.cmdSummaries.Tag = "Summaries"
        Me.cmdSummaries.Text = "Summaries..."
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'cmdProportionsPercentages
        '
        Me.cmdProportionsPercentages.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdProportionsPercentages.Location = New System.Drawing.Point(274, 328)
        Me.cmdProportionsPercentages.Name = "cmdProportionsPercentages"
        Me.cmdProportionsPercentages.Size = New System.Drawing.Size(134, 23)
        Me.cmdProportionsPercentages.TabIndex = 9
        Me.cmdProportionsPercentages.Tag = "Proportions/Percentages..."
        Me.cmdProportionsPercentages.Text = "Prop. and Percentages..."
        Me.cmdProportionsPercentages.UseVisualStyleBackColor = True
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.AutoSize = True
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(274, 127)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(119, 23)
        Me.ucrChkWeights.TabIndex = 3
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.AutoSize = True
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(274, 150)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWeights.strNcFilePath = ""
        Me.ucrReceiverWeights.TabIndex = 4
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrReceiverByFactor
        '
        Me.ucrReceiverByFactor.AutoSize = True
        Me.ucrReceiverByFactor.frmParent = Me
        Me.ucrReceiverByFactor.Location = New System.Drawing.Point(274, 190)
        Me.ucrReceiverByFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverByFactor.Name = "ucrReceiverByFactor"
        Me.ucrReceiverByFactor.Selector = Nothing
        Me.ucrReceiverByFactor.Size = New System.Drawing.Size(133, 100)
        Me.ucrReceiverByFactor.strNcFilePath = ""
        Me.ucrReceiverByFactor.TabIndex = 6
        Me.ucrReceiverByFactor.ucrSelector = Nothing
        '
        'ucrReceiverSelectedVariables
        '
        Me.ucrReceiverSelectedVariables.AutoSize = True
        Me.ucrReceiverSelectedVariables.frmParent = Me
        Me.ucrReceiverSelectedVariables.Location = New System.Drawing.Point(274, 24)
        Me.ucrReceiverSelectedVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelectedVariables.Name = "ucrReceiverSelectedVariables"
        Me.ucrReceiverSelectedVariables.Selector = Nothing
        Me.ucrReceiverSelectedVariables.Size = New System.Drawing.Size(133, 100)
        Me.ucrReceiverSelectedVariables.strNcFilePath = ""
        Me.ucrReceiverSelectedVariables.TabIndex = 2
        Me.ucrReceiverSelectedVariables.ucrSelector = Nothing
        '
        'ucrSelectorForColumnStatistics
        '
        Me.ucrSelectorForColumnStatistics.AutoSize = True
        Me.ucrSelectorForColumnStatistics.bDropUnusedFilterLevels = False
        Me.ucrSelectorForColumnStatistics.bShowHiddenColumns = False
        Me.ucrSelectorForColumnStatistics.bUseCurrentFilter = True
        Me.ucrSelectorForColumnStatistics.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForColumnStatistics.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForColumnStatistics.Name = "ucrSelectorForColumnStatistics"
        Me.ucrSelectorForColumnStatistics.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForColumnStatistics.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(6, 363)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 10
        '
        'dlgColumnStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(416, 419)
        Me.Controls.Add(Me.ucrChkWeights)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.cmdProportionsPercentages)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.ucrReceiverByFactor)
        Me.Controls.Add(Me.ucrReceiverSelectedVariables)
        Me.Controls.Add(Me.lblSummariseBy)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ucrSelectorForColumnStatistics)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgColumnStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Column_Statistics"
        Me.Text = "Column Summaries"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForColumnStatistics As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents lblSummariseBy As Label
    Friend WithEvents ucrReceiverSelectedVariables As ucrReceiverMultiple
    Friend WithEvents ucrReceiverByFactor As ucrReceiverMultiple
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents ucrChkStoreResults As ucrCheck
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents ucrChkPrintOutput As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevels As ucrCheck
    Friend WithEvents cmdProportionsPercentages As Button
    Friend WithEvents ucrChkOriginalLevel As ucrCheck
    Friend WithEvents ucrChkWeights As ucrCheck
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents cmdMissingOptions As Button
End Class
