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
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrChkOriginalLevel = New instat.ucrCheck()
        Me.ucrChkStoreResults = New instat.ucrCheck()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrChkPrintOutput = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevels = New instat.ucrCheck()
        Me.ucrReceiverByFactor = New instat.ucrReceiverMultiple()
        Me.ucrReceiverSelectedVariables = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorForData = New instat.ucrSelectorByTablesAddRemove()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectedVariables.Location = New System.Drawing.Point(410, 14)
        Me.lblSelectedVariables.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(191, 20)
        Me.lblSelectedVariables.TabIndex = 1
        Me.lblSelectedVariables.Text = "Variable(s) to Summarise:"
        '
        'lblSummariseBy
        '
        Me.lblSummariseBy.AutoSize = True
        Me.lblSummariseBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummariseBy.Location = New System.Drawing.Point(408, 264)
        Me.lblSummariseBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSummariseBy.Name = "lblSummariseBy"
        Me.lblSummariseBy.Size = New System.Drawing.Size(115, 20)
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
        Me.grpOptions.Location = New System.Drawing.Point(9, 346)
        Me.grpOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Padding = New System.Windows.Forms.Padding(4)
        Me.grpOptions.Size = New System.Drawing.Size(387, 232)
        Me.grpOptions.TabIndex = 7
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'cmdMissingOptions
        '
        Me.cmdMissingOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMissingOptions.Location = New System.Drawing.Point(285, 174)
        Me.cmdMissingOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMissingOptions.Name = "cmdMissingOptions"
        Me.cmdMissingOptions.Size = New System.Drawing.Size(93, 39)
        Me.cmdMissingOptions.TabIndex = 20
        Me.cmdMissingOptions.Tag = "MissingOptions"
        Me.cmdMissingOptions.Text = "Options"
        Me.cmdMissingOptions.UseVisualStyleBackColor = True
        '
        'cmdSummaries
        '
        Me.cmdSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSummaries.Location = New System.Drawing.Point(411, 453)
        Me.cmdSummaries.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(201, 34)
        Me.cmdSummaries.TabIndex = 8
        Me.cmdSummaries.Tag = "Summaries"
        Me.cmdSummaries.Text = "Summaries..."
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.AutoSize = True
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(411, 190)
        Me.ucrChkWeights.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(178, 34)
        Me.ucrChkWeights.TabIndex = 3
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.AutoSize = True
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(411, 225)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverWeights.strNcFilePath = ""
        Me.ucrReceiverWeights.TabIndex = 4
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrChkOriginalLevel
        '
        Me.ucrChkOriginalLevel.AutoSize = True
        Me.ucrChkOriginalLevel.Checked = False
        Me.ucrChkOriginalLevel.Location = New System.Drawing.Point(38, 63)
        Me.ucrChkOriginalLevel.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkOriginalLevel.Name = "ucrChkOriginalLevel"
        Me.ucrChkOriginalLevel.Size = New System.Drawing.Size(327, 34)
        Me.ucrChkOriginalLevel.TabIndex = 1
        '
        'ucrChkStoreResults
        '
        Me.ucrChkStoreResults.AutoSize = True
        Me.ucrChkStoreResults.Checked = False
        Me.ucrChkStoreResults.Location = New System.Drawing.Point(9, 26)
        Me.ucrChkStoreResults.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkStoreResults.Name = "ucrChkStoreResults"
        Me.ucrChkStoreResults.Size = New System.Drawing.Size(356, 51)
        Me.ucrChkStoreResults.TabIndex = 0
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.AutoSize = True
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(9, 176)
        Me.ucrChkOmitMissing.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(267, 51)
        Me.ucrChkOmitMissing.TabIndex = 4
        '
        'ucrChkPrintOutput
        '
        Me.ucrChkPrintOutput.AutoSize = True
        Me.ucrChkPrintOutput.Checked = False
        Me.ucrChkPrintOutput.Location = New System.Drawing.Point(9, 100)
        Me.ucrChkPrintOutput.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkPrintOutput.Name = "ucrChkPrintOutput"
        Me.ucrChkPrintOutput.Size = New System.Drawing.Size(369, 34)
        Me.ucrChkPrintOutput.TabIndex = 2
        '
        'ucrChkDropUnusedLevels
        '
        Me.ucrChkDropUnusedLevels.AutoSize = True
        Me.ucrChkDropUnusedLevels.Checked = False
        Me.ucrChkDropUnusedLevels.Location = New System.Drawing.Point(9, 138)
        Me.ucrChkDropUnusedLevels.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkDropUnusedLevels.Name = "ucrChkDropUnusedLevels"
        Me.ucrChkDropUnusedLevels.Size = New System.Drawing.Size(356, 34)
        Me.ucrChkDropUnusedLevels.TabIndex = 3
        '
        'ucrReceiverByFactor
        '
        Me.ucrReceiverByFactor.AutoSize = True
        Me.ucrReceiverByFactor.frmParent = Me
        Me.ucrReceiverByFactor.Location = New System.Drawing.Point(411, 285)
        Me.ucrReceiverByFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverByFactor.Name = "ucrReceiverByFactor"
        Me.ucrReceiverByFactor.Selector = Nothing
        Me.ucrReceiverByFactor.Size = New System.Drawing.Size(200, 150)
        Me.ucrReceiverByFactor.strNcFilePath = ""
        Me.ucrReceiverByFactor.TabIndex = 6
        Me.ucrReceiverByFactor.ucrSelector = Nothing
        '
        'ucrReceiverSelectedVariables
        '
        Me.ucrReceiverSelectedVariables.AutoSize = True
        Me.ucrReceiverSelectedVariables.frmParent = Me
        Me.ucrReceiverSelectedVariables.Location = New System.Drawing.Point(411, 36)
        Me.ucrReceiverSelectedVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelectedVariables.Name = "ucrReceiverSelectedVariables"
        Me.ucrReceiverSelectedVariables.Selector = Nothing
        Me.ucrReceiverSelectedVariables.Size = New System.Drawing.Size(200, 150)
        Me.ucrReceiverSelectedVariables.strNcFilePath = ""
        Me.ucrReceiverSelectedVariables.TabIndex = 2
        Me.ucrReceiverSelectedVariables.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 588)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 10
        '
        'ucrSelectorForData
        '
        Me.ucrSelectorForData.AutoSize = True
        Me.ucrSelectorForData.bShowHiddenColumns = False
        Me.ucrSelectorForData.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorForData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForData.Name = "ucrSelectorForData"
        Me.ucrSelectorForData.Size = New System.Drawing.Size(326, 333)
        Me.ucrSelectorForData.TabIndex = 12
        '
        'dlgColumnStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(625, 676)
        Me.Controls.Add(Me.ucrSelectorForData)
        Me.Controls.Add(Me.ucrChkWeights)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.ucrReceiverByFactor)
        Me.Controls.Add(Me.ucrReceiverSelectedVariables)
        Me.Controls.Add(Me.lblSummariseBy)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents ucrChkOriginalLevel As ucrCheck
    Friend WithEvents ucrChkWeights As ucrCheck
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents cmdMissingOptions As Button
    Friend WithEvents ucrSelectorForData As ucrSelectorByTablesAddRemove
End Class
