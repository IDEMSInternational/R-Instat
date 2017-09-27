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
Partial Class dlgTwoWayFrequencies
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
        Me.lblRowFactor = New System.Windows.Forms.Label()
        Me.lblColumnFactor = New System.Windows.Forms.Label()
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.rdoGraph = New System.Windows.Forms.RadioButton()
        Me.grpFreqTypeTable = New System.Windows.Forms.GroupBox()
        Me.ucrChkCount = New instat.ucrCheck()
        Me.ucrChkCell = New instat.ucrCheck()
        Me.ucrChkColumn = New instat.ucrCheck()
        Me.ucrChkRow = New instat.ucrCheck()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.rdoBoth = New System.Windows.Forms.RadioButton()
        Me.grpFreqTypeGraph = New System.Windows.Forms.GroupBox()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.rdoCell = New System.Windows.Forms.RadioButton()
        Me.rdoRow = New System.Windows.Forms.RadioButton()
        Me.rdoColumn = New System.Windows.Forms.RadioButton()
        Me.ucrPnlFreqType = New instat.UcrPanel()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrSelectorTwoWayFrequencies = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkFlip = New instat.ucrCheck()
        Me.ucrPnlFreqDisplay = New instat.UcrPanel()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrReceiverColumnFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverRowFactor = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpFreqTypeTable.SuspendLayout()
        Me.grpFreqTypeGraph.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRowFactor
        '
        Me.lblRowFactor.AutoSize = True
        Me.lblRowFactor.Location = New System.Drawing.Point(260, 78)
        Me.lblRowFactor.Name = "lblRowFactor"
        Me.lblRowFactor.Size = New System.Drawing.Size(112, 13)
        Me.lblRowFactor.TabIndex = 5
        Me.lblRowFactor.Text = "Row Variable (Factor):"
        '
        'lblColumnFactor
        '
        Me.lblColumnFactor.AutoSize = True
        Me.lblColumnFactor.Location = New System.Drawing.Point(260, 121)
        Me.lblColumnFactor.Name = "lblColumnFactor"
        Me.lblColumnFactor.Size = New System.Drawing.Size(78, 13)
        Me.lblColumnFactor.TabIndex = 7
        Me.lblColumnFactor.Text = "Column Factor:"
        '
        'rdoTable
        '
        Me.rdoTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoTable.Location = New System.Drawing.Point(66, 12)
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.Size = New System.Drawing.Size(100, 28)
        Me.rdoTable.TabIndex = 1
        Me.rdoTable.Text = "Table"
        Me.rdoTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTable.UseVisualStyleBackColor = True
        '
        'rdoGraph
        '
        Me.rdoGraph.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoGraph.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatAppearance.BorderSize = 2
        Me.rdoGraph.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGraph.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoGraph.Location = New System.Drawing.Point(164, 12)
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.Size = New System.Drawing.Size(100, 28)
        Me.rdoGraph.TabIndex = 2
        Me.rdoGraph.Text = "Graph"
        Me.rdoGraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'grpFreqTypeTable
        '
        Me.grpFreqTypeTable.Controls.Add(Me.ucrChkCount)
        Me.grpFreqTypeTable.Controls.Add(Me.ucrChkCell)
        Me.grpFreqTypeTable.Controls.Add(Me.ucrChkColumn)
        Me.grpFreqTypeTable.Controls.Add(Me.ucrChkRow)
        Me.grpFreqTypeTable.Location = New System.Drawing.Point(263, 166)
        Me.grpFreqTypeTable.Name = "grpFreqTypeTable"
        Me.grpFreqTypeTable.Size = New System.Drawing.Size(116, 116)
        Me.grpFreqTypeTable.TabIndex = 9
        Me.grpFreqTypeTable.TabStop = False
        Me.grpFreqTypeTable.Text = "Table Frequencies"
        '
        'ucrChkCount
        '
        Me.ucrChkCount.Checked = False
        Me.ucrChkCount.Location = New System.Drawing.Point(10, 19)
        Me.ucrChkCount.Name = "ucrChkCount"
        Me.ucrChkCount.Size = New System.Drawing.Size(82, 20)
        Me.ucrChkCount.TabIndex = 0
        '
        'ucrChkCell
        '
        Me.ucrChkCell.Checked = False
        Me.ucrChkCell.Location = New System.Drawing.Point(10, 88)
        Me.ucrChkCell.Name = "ucrChkCell"
        Me.ucrChkCell.Size = New System.Drawing.Size(82, 20)
        Me.ucrChkCell.TabIndex = 3
        '
        'ucrChkColumn
        '
        Me.ucrChkColumn.Checked = False
        Me.ucrChkColumn.Location = New System.Drawing.Point(10, 65)
        Me.ucrChkColumn.Name = "ucrChkColumn"
        Me.ucrChkColumn.Size = New System.Drawing.Size(82, 20)
        Me.ucrChkColumn.TabIndex = 2
        '
        'ucrChkRow
        '
        Me.ucrChkRow.Checked = False
        Me.ucrChkRow.Location = New System.Drawing.Point(10, 42)
        Me.ucrChkRow.Name = "ucrChkRow"
        Me.ucrChkRow.Size = New System.Drawing.Size(82, 20)
        Me.ucrChkRow.TabIndex = 1
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(10, 229)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(119, 23)
        Me.cmdOptions.TabIndex = 11
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'rdoBoth
        '
        Me.rdoBoth.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBoth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoBoth.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.FlatAppearance.BorderSize = 2
        Me.rdoBoth.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBoth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoBoth.Location = New System.Drawing.Point(262, 12)
        Me.rdoBoth.Name = "rdoBoth"
        Me.rdoBoth.Size = New System.Drawing.Size(100, 28)
        Me.rdoBoth.TabIndex = 3
        Me.rdoBoth.Text = "Both"
        Me.rdoBoth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBoth.UseVisualStyleBackColor = True
        '
        'grpFreqTypeGraph
        '
        Me.grpFreqTypeGraph.Controls.Add(Me.rdoCount)
        Me.grpFreqTypeGraph.Controls.Add(Me.rdoCell)
        Me.grpFreqTypeGraph.Controls.Add(Me.rdoRow)
        Me.grpFreqTypeGraph.Controls.Add(Me.rdoColumn)
        Me.grpFreqTypeGraph.Controls.Add(Me.ucrPnlFreqType)
        Me.grpFreqTypeGraph.Location = New System.Drawing.Point(358, 166)
        Me.grpFreqTypeGraph.Name = "grpFreqTypeGraph"
        Me.grpFreqTypeGraph.Size = New System.Drawing.Size(117, 116)
        Me.grpFreqTypeGraph.TabIndex = 10
        Me.grpFreqTypeGraph.TabStop = False
        Me.grpFreqTypeGraph.Text = "Graph Frequencies"
        '
        'rdoCount
        '
        Me.rdoCount.AutoSize = True
        Me.rdoCount.Location = New System.Drawing.Point(10, 19)
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.Size = New System.Drawing.Size(53, 17)
        Me.rdoCount.TabIndex = 1
        Me.rdoCount.TabStop = True
        Me.rdoCount.Text = "Count"
        Me.rdoCount.UseVisualStyleBackColor = True
        '
        'rdoCell
        '
        Me.rdoCell.AutoSize = True
        Me.rdoCell.Location = New System.Drawing.Point(10, 88)
        Me.rdoCell.Name = "rdoCell"
        Me.rdoCell.Size = New System.Drawing.Size(59, 17)
        Me.rdoCell.TabIndex = 4
        Me.rdoCell.TabStop = True
        Me.rdoCell.Text = "Cell (%)"
        Me.rdoCell.UseVisualStyleBackColor = True
        '
        'rdoRow
        '
        Me.rdoRow.AutoSize = True
        Me.rdoRow.Location = New System.Drawing.Point(10, 42)
        Me.rdoRow.Name = "rdoRow"
        Me.rdoRow.Size = New System.Drawing.Size(64, 17)
        Me.rdoRow.TabIndex = 2
        Me.rdoRow.TabStop = True
        Me.rdoRow.Text = "Row (%)"
        Me.rdoRow.UseVisualStyleBackColor = True
        '
        'rdoColumn
        '
        Me.rdoColumn.AutoSize = True
        Me.rdoColumn.Location = New System.Drawing.Point(10, 65)
        Me.rdoColumn.Name = "rdoColumn"
        Me.rdoColumn.Size = New System.Drawing.Size(77, 17)
        Me.rdoColumn.TabIndex = 3
        Me.rdoColumn.TabStop = True
        Me.rdoColumn.Text = "Column (%)"
        Me.rdoColumn.UseVisualStyleBackColor = True
        '
        'ucrPnlFreqType
        '
        Me.ucrPnlFreqType.Location = New System.Drawing.Point(9, 17)
        Me.ucrPnlFreqType.Name = "ucrPnlFreqType"
        Me.ucrPnlFreqType.Size = New System.Drawing.Size(82, 93)
        Me.ucrPnlFreqType.TabIndex = 0
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(9, 314)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveGraph.TabIndex = 16
        '
        'ucrSelectorTwoWayFrequencies
        '
        Me.ucrSelectorTwoWayFrequencies.bShowHiddenColumns = False
        Me.ucrSelectorTwoWayFrequencies.bUseCurrentFilter = True
        Me.ucrSelectorTwoWayFrequencies.Location = New System.Drawing.Point(9, 43)
        Me.ucrSelectorTwoWayFrequencies.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTwoWayFrequencies.Name = "ucrSelectorTwoWayFrequencies"
        Me.ucrSelectorTwoWayFrequencies.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorTwoWayFrequencies.TabIndex = 4
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.Checked = False
        Me.ucrChkFlip.Location = New System.Drawing.Point(9, 288)
        Me.ucrChkFlip.Name = "ucrChkFlip"
        Me.ucrChkFlip.Size = New System.Drawing.Size(183, 20)
        Me.ucrChkFlip.TabIndex = 14
        '
        'ucrPnlFreqDisplay
        '
        Me.ucrPnlFreqDisplay.Location = New System.Drawing.Point(42, 11)
        Me.ucrPnlFreqDisplay.Name = "ucrPnlFreqDisplay"
        Me.ucrPnlFreqDisplay.Size = New System.Drawing.Size(349, 29)
        Me.ucrPnlFreqDisplay.TabIndex = 0
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(9, 262)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkWeights.TabIndex = 12
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(113, 265)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWeights.strNcFilePath = ""
        Me.ucrReceiverWeights.TabIndex = 13
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrReceiverColumnFactor
        '
        Me.ucrReceiverColumnFactor.frmParent = Me
        Me.ucrReceiverColumnFactor.Location = New System.Drawing.Point(263, 136)
        Me.ucrReceiverColumnFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnFactor.Name = "ucrReceiverColumnFactor"
        Me.ucrReceiverColumnFactor.Selector = Nothing
        Me.ucrReceiverColumnFactor.Size = New System.Drawing.Size(121, 20)
        Me.ucrReceiverColumnFactor.strNcFilePath = ""
        Me.ucrReceiverColumnFactor.TabIndex = 8
        Me.ucrReceiverColumnFactor.ucrSelector = Nothing
        '
        'ucrReceiverRowFactor
        '
        Me.ucrReceiverRowFactor.frmParent = Me
        Me.ucrReceiverRowFactor.Location = New System.Drawing.Point(263, 93)
        Me.ucrReceiverRowFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRowFactor.Name = "ucrReceiverRowFactor"
        Me.ucrReceiverRowFactor.Selector = Nothing
        Me.ucrReceiverRowFactor.Size = New System.Drawing.Size(121, 20)
        Me.ucrReceiverRowFactor.strNcFilePath = ""
        Me.ucrReceiverRowFactor.TabIndex = 6
        Me.ucrReceiverRowFactor.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 337)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 15
        '
        'dlgTwoWayFrequencies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 394)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.grpFreqTypeGraph)
        Me.Controls.Add(Me.rdoBoth)
        Me.Controls.Add(Me.ucrSelectorTwoWayFrequencies)
        Me.Controls.Add(Me.grpFreqTypeTable)
        Me.Controls.Add(Me.ucrChkFlip)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.rdoTable)
        Me.Controls.Add(Me.rdoGraph)
        Me.Controls.Add(Me.lblColumnFactor)
        Me.Controls.Add(Me.ucrPnlFreqDisplay)
        Me.Controls.Add(Me.lblRowFactor)
        Me.Controls.Add(Me.ucrChkWeights)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.ucrReceiverColumnFactor)
        Me.Controls.Add(Me.ucrReceiverRowFactor)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTwoWayFrequencies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Two Way Frequencies"
        Me.grpFreqTypeTable.ResumeLayout(False)
        Me.grpFreqTypeGraph.ResumeLayout(False)
        Me.grpFreqTypeGraph.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorTwoWayFrequencies As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRowFactor As ucrReceiverSingle
    Friend WithEvents lblColumnFactor As Label
    Friend WithEvents lblRowFactor As Label
    Friend WithEvents ucrChkWeights As ucrCheck
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents ucrReceiverColumnFactor As ucrReceiverSingle
    Friend WithEvents rdoTable As RadioButton
    Friend WithEvents rdoGraph As RadioButton
    Friend WithEvents ucrPnlFreqDisplay As UcrPanel
    Friend WithEvents grpFreqTypeTable As GroupBox
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrChkFlip As ucrCheck
    Friend WithEvents rdoBoth As RadioButton
    Friend WithEvents grpFreqTypeGraph As GroupBox
    Friend WithEvents rdoCount As RadioButton
    Friend WithEvents rdoCell As RadioButton
    Friend WithEvents rdoRow As RadioButton
    Friend WithEvents rdoColumn As RadioButton
    Friend WithEvents ucrPnlFreqType As UcrPanel
    Friend WithEvents ucrChkCount As ucrCheck
    Friend WithEvents ucrChkCell As ucrCheck
    Friend WithEvents ucrChkColumn As ucrCheck
    Friend WithEvents ucrChkRow As ucrCheck
    Friend WithEvents ucrSaveGraph As ucrSave
End Class
