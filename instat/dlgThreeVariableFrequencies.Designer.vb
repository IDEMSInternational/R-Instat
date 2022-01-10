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
Partial Class dlgThreeVariableFrequencies
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
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.rdoGraph = New System.Windows.Forms.RadioButton()
        Me.lblGroupby = New System.Windows.Forms.Label()
        Me.lblColumnfactor = New System.Windows.Forms.Label()
        Me.lblRowfactor = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.rdoColumn = New System.Windows.Forms.RadioButton()
        Me.rdoRow = New System.Windows.Forms.RadioButton()
        Me.rdoCell = New System.Windows.Forms.RadioButton()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.grpFreqTypeTable = New System.Windows.Forms.GroupBox()
        Me.ucrChkRow = New instat.ucrCheck()
        Me.ucrChkCount = New instat.ucrCheck()
        Me.ucrChkColumn = New instat.ucrCheck()
        Me.ucrChkCell = New instat.ucrCheck()
        Me.lblGroupsby = New System.Windows.Forms.Label()
        Me.grpFreqTypeGraph = New System.Windows.Forms.GroupBox()
        Me.ucrPnlFreqType = New instat.UcrPanel()
        Me.rdoBoth = New System.Windows.Forms.RadioButton()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrReceiverGroupBy2nd = New instat.ucrReceiverSingle()
        Me.ucrReceiverGroupsBy1st = New instat.ucrReceiverSingle()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrReceiverColumnFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverRowFactor = New instat.ucrReceiverSingle()
        Me.ucrPnlFrequencyDisplay = New instat.UcrPanel()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorThreeVariableFrequencies = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkFlip = New instat.ucrCheck()
        Me.grpFreqTypeTable.SuspendLayout()
        Me.grpFreqTypeGraph.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoTable
        '
        Me.rdoTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTable.Location = New System.Drawing.Point(59, 12)
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.Size = New System.Drawing.Size(105, 28)
        Me.rdoTable.TabIndex = 1
        Me.rdoTable.Text = "Table"
        Me.rdoTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTable.UseVisualStyleBackColor = True
        '
        'rdoGraph
        '
        Me.rdoGraph.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoGraph.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGraph.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatAppearance.BorderSize = 2
        Me.rdoGraph.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGraph.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoGraph.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGraph.Location = New System.Drawing.Point(162, 12)
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.Size = New System.Drawing.Size(105, 28)
        Me.rdoGraph.TabIndex = 2
        Me.rdoGraph.Text = "Graph"
        Me.rdoGraph.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'lblGroupby
        '
        Me.lblGroupby.AutoSize = True
        Me.lblGroupby.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroupby.Location = New System.Drawing.Point(236, 170)
        Me.lblGroupby.Name = "lblGroupby"
        Me.lblGroupby.Size = New System.Drawing.Size(86, 13)
        Me.lblGroupby.TabIndex = 9
        Me.lblGroupby.Text = "Grouping Factor:"
        '
        'lblColumnfactor
        '
        Me.lblColumnfactor.AutoSize = True
        Me.lblColumnfactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumnfactor.Location = New System.Drawing.Point(236, 126)
        Me.lblColumnfactor.Name = "lblColumnfactor"
        Me.lblColumnfactor.Size = New System.Drawing.Size(78, 13)
        Me.lblColumnfactor.TabIndex = 7
        Me.lblColumnfactor.Text = "Column Factor:"
        '
        'lblRowfactor
        '
        Me.lblRowfactor.AutoSize = True
        Me.lblRowfactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRowfactor.Location = New System.Drawing.Point(236, 82)
        Me.lblRowfactor.Name = "lblRowfactor"
        Me.lblRowfactor.Size = New System.Drawing.Size(112, 13)
        Me.lblRowfactor.TabIndex = 5
        Me.lblRowfactor.Text = "Row Variable (Factor):"
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(10, 227)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(121, 23)
        Me.cmdOptions.TabIndex = 15
        Me.cmdOptions.Text = " Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'rdoColumn
        '
        Me.rdoColumn.AutoSize = True
        Me.rdoColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoColumn.Location = New System.Drawing.Point(10, 85)
        Me.rdoColumn.Name = "rdoColumn"
        Me.rdoColumn.Size = New System.Drawing.Size(77, 17)
        Me.rdoColumn.TabIndex = 3
        Me.rdoColumn.TabStop = True
        Me.rdoColumn.Text = "Column (%)"
        Me.rdoColumn.UseVisualStyleBackColor = True
        '
        'rdoRow
        '
        Me.rdoRow.AutoSize = True
        Me.rdoRow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRow.Location = New System.Drawing.Point(10, 59)
        Me.rdoRow.Name = "rdoRow"
        Me.rdoRow.Size = New System.Drawing.Size(64, 17)
        Me.rdoRow.TabIndex = 2
        Me.rdoRow.TabStop = True
        Me.rdoRow.Text = "Row (%)"
        Me.rdoRow.UseVisualStyleBackColor = True
        '
        'rdoCell
        '
        Me.rdoCell.AutoSize = True
        Me.rdoCell.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCell.Location = New System.Drawing.Point(10, 111)
        Me.rdoCell.Name = "rdoCell"
        Me.rdoCell.Size = New System.Drawing.Size(59, 17)
        Me.rdoCell.TabIndex = 4
        Me.rdoCell.TabStop = True
        Me.rdoCell.Text = "Cell (%)"
        Me.rdoCell.UseVisualStyleBackColor = True
        '
        'rdoCount
        '
        Me.rdoCount.AutoSize = True
        Me.rdoCount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCount.Location = New System.Drawing.Point(10, 33)
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.Size = New System.Drawing.Size(53, 17)
        Me.rdoCount.TabIndex = 1
        Me.rdoCount.TabStop = True
        Me.rdoCount.Text = "Count"
        Me.rdoCount.UseVisualStyleBackColor = True
        '
        'grpFreqTypeTable
        '
        Me.grpFreqTypeTable.Controls.Add(Me.ucrChkRow)
        Me.grpFreqTypeTable.Controls.Add(Me.ucrChkCount)
        Me.grpFreqTypeTable.Controls.Add(Me.ucrChkColumn)
        Me.grpFreqTypeTable.Controls.Add(Me.ucrChkCell)
        Me.grpFreqTypeTable.Location = New System.Drawing.Point(292, 279)
        Me.grpFreqTypeTable.Name = "grpFreqTypeTable"
        Me.grpFreqTypeTable.Size = New System.Drawing.Size(121, 131)
        Me.grpFreqTypeTable.TabIndex = 13
        Me.grpFreqTypeTable.TabStop = False
        Me.grpFreqTypeTable.Text = "Table Frequencies"
        '
        'ucrChkRow
        '
        Me.ucrChkRow.AutoSize = True
        Me.ucrChkRow.Checked = False
        Me.ucrChkRow.Location = New System.Drawing.Point(12, 59)
        Me.ucrChkRow.Name = "ucrChkRow"
        Me.ucrChkRow.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkRow.TabIndex = 1
        '
        'ucrChkCount
        '
        Me.ucrChkCount.AutoSize = True
        Me.ucrChkCount.Checked = False
        Me.ucrChkCount.Location = New System.Drawing.Point(12, 33)
        Me.ucrChkCount.Name = "ucrChkCount"
        Me.ucrChkCount.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkCount.TabIndex = 0
        '
        'ucrChkColumn
        '
        Me.ucrChkColumn.AutoSize = True
        Me.ucrChkColumn.Checked = False
        Me.ucrChkColumn.Location = New System.Drawing.Point(13, 85)
        Me.ucrChkColumn.Name = "ucrChkColumn"
        Me.ucrChkColumn.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkColumn.TabIndex = 2
        '
        'ucrChkCell
        '
        Me.ucrChkCell.AutoSize = True
        Me.ucrChkCell.Checked = False
        Me.ucrChkCell.Location = New System.Drawing.Point(12, 111)
        Me.ucrChkCell.Name = "ucrChkCell"
        Me.ucrChkCell.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkCell.TabIndex = 3
        '
        'lblGroupsby
        '
        Me.lblGroupsby.AutoSize = True
        Me.lblGroupsby.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroupsby.Location = New System.Drawing.Point(236, 214)
        Me.lblGroupsby.Name = "lblGroupsby"
        Me.lblGroupsby.Size = New System.Drawing.Size(134, 13)
        Me.lblGroupsby.TabIndex = 11
        Me.lblGroupsby.Text = "Grouping Factor (Optional):"
        '
        'grpFreqTypeGraph
        '
        Me.grpFreqTypeGraph.Controls.Add(Me.rdoCount)
        Me.grpFreqTypeGraph.Controls.Add(Me.rdoColumn)
        Me.grpFreqTypeGraph.Controls.Add(Me.rdoRow)
        Me.grpFreqTypeGraph.Controls.Add(Me.rdoCell)
        Me.grpFreqTypeGraph.Controls.Add(Me.ucrPnlFreqType)
        Me.grpFreqTypeGraph.Location = New System.Drawing.Point(165, 279)
        Me.grpFreqTypeGraph.Name = "grpFreqTypeGraph"
        Me.grpFreqTypeGraph.Size = New System.Drawing.Size(121, 131)
        Me.grpFreqTypeGraph.TabIndex = 14
        Me.grpFreqTypeGraph.TabStop = False
        Me.grpFreqTypeGraph.Text = "Graph Frequencies"
        '
        'ucrPnlFreqType
        '
        Me.ucrPnlFreqType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlFreqType.Location = New System.Drawing.Point(7, 33)
        Me.ucrPnlFreqType.Name = "ucrPnlFreqType"
        Me.ucrPnlFreqType.Size = New System.Drawing.Size(92, 95)
        Me.ucrPnlFreqType.TabIndex = 0
        '
        'rdoBoth
        '
        Me.rdoBoth.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBoth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoBoth.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBoth.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.FlatAppearance.BorderSize = 2
        Me.rdoBoth.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBoth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoBoth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBoth.Location = New System.Drawing.Point(265, 12)
        Me.rdoBoth.Name = "rdoBoth"
        Me.rdoBoth.Size = New System.Drawing.Size(105, 28)
        Me.rdoBoth.TabIndex = 3
        Me.rdoBoth.Text = "Both"
        Me.rdoBoth.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoBoth.UseVisualStyleBackColor = True
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 415)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(344, 21)
        Me.ucrSaveGraph.TabIndex = 20
        '
        'ucrReceiverGroupBy2nd
        '
        Me.ucrReceiverGroupBy2nd.AutoSize = True
        Me.ucrReceiverGroupBy2nd.frmParent = Me
        Me.ucrReceiverGroupBy2nd.Location = New System.Drawing.Point(239, 230)
        Me.ucrReceiverGroupBy2nd.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGroupBy2nd.Name = "ucrReceiverGroupBy2nd"
        Me.ucrReceiverGroupBy2nd.Selector = Nothing
        Me.ucrReceiverGroupBy2nd.Size = New System.Drawing.Size(121, 20)
        Me.ucrReceiverGroupBy2nd.strNcFilePath = ""
        Me.ucrReceiverGroupBy2nd.TabIndex = 12
        Me.ucrReceiverGroupBy2nd.ucrSelector = Nothing
        '
        'ucrReceiverGroupsBy1st
        '
        Me.ucrReceiverGroupsBy1st.AutoSize = True
        Me.ucrReceiverGroupsBy1st.frmParent = Me
        Me.ucrReceiverGroupsBy1st.Location = New System.Drawing.Point(239, 183)
        Me.ucrReceiverGroupsBy1st.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGroupsBy1st.Name = "ucrReceiverGroupsBy1st"
        Me.ucrReceiverGroupsBy1st.Selector = Nothing
        Me.ucrReceiverGroupsBy1st.Size = New System.Drawing.Size(121, 20)
        Me.ucrReceiverGroupsBy1st.strNcFilePath = ""
        Me.ucrReceiverGroupsBy1st.TabIndex = 10
        Me.ucrReceiverGroupsBy1st.ucrSelector = Nothing
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.AutoSize = True
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(113, 256)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(128, 20)
        Me.ucrReceiverWeights.strNcFilePath = ""
        Me.ucrReceiverWeights.TabIndex = 17
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.AutoSize = True
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(10, 256)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkWeights.TabIndex = 16
        '
        'ucrReceiverColumnFactor
        '
        Me.ucrReceiverColumnFactor.AutoSize = True
        Me.ucrReceiverColumnFactor.frmParent = Me
        Me.ucrReceiverColumnFactor.Location = New System.Drawing.Point(239, 139)
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
        Me.ucrReceiverRowFactor.AutoSize = True
        Me.ucrReceiverRowFactor.frmParent = Me
        Me.ucrReceiverRowFactor.Location = New System.Drawing.Point(239, 95)
        Me.ucrReceiverRowFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRowFactor.Name = "ucrReceiverRowFactor"
        Me.ucrReceiverRowFactor.Selector = Nothing
        Me.ucrReceiverRowFactor.Size = New System.Drawing.Size(121, 20)
        Me.ucrReceiverRowFactor.strNcFilePath = ""
        Me.ucrReceiverRowFactor.TabIndex = 6
        Me.ucrReceiverRowFactor.ucrSelector = Nothing
        '
        'ucrPnlFrequencyDisplay
        '
        Me.ucrPnlFrequencyDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlFrequencyDisplay.Location = New System.Drawing.Point(59, 12)
        Me.ucrPnlFrequencyDisplay.Name = "ucrPnlFrequencyDisplay"
        Me.ucrPnlFrequencyDisplay.Size = New System.Drawing.Size(314, 29)
        Me.ucrPnlFrequencyDisplay.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 438)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 19
        '
        'ucrSelectorThreeVariableFrequencies
        '
        Me.ucrSelectorThreeVariableFrequencies.AutoSize = True
        Me.ucrSelectorThreeVariableFrequencies.bDropUnusedFilterLevels = False
        Me.ucrSelectorThreeVariableFrequencies.bShowHiddenColumns = False
        Me.ucrSelectorThreeVariableFrequencies.bUseCurrentFilter = True
        Me.ucrSelectorThreeVariableFrequencies.Location = New System.Drawing.Point(10, 43)
        Me.ucrSelectorThreeVariableFrequencies.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorThreeVariableFrequencies.Name = "ucrSelectorThreeVariableFrequencies"
        Me.ucrSelectorThreeVariableFrequencies.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorThreeVariableFrequencies.TabIndex = 4
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.AutoSize = True
        Me.ucrChkFlip.Checked = False
        Me.ucrChkFlip.Location = New System.Drawing.Point(10, 282)
        Me.ucrChkFlip.Name = "ucrChkFlip"
        Me.ucrChkFlip.Size = New System.Drawing.Size(197, 23)
        Me.ucrChkFlip.TabIndex = 18
        '
        'dlgThreeVariableFrequencies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(416, 492)
        Me.Controls.Add(Me.rdoBoth)
        Me.Controls.Add(Me.ucrReceiverGroupBy2nd)
        Me.Controls.Add(Me.lblGroupsby)
        Me.Controls.Add(Me.grpFreqTypeTable)
        Me.Controls.Add(Me.ucrReceiverGroupsBy1st)
        Me.Controls.Add(Me.ucrChkWeights)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblColumnfactor)
        Me.Controls.Add(Me.lblRowfactor)
        Me.Controls.Add(Me.ucrReceiverColumnFactor)
        Me.Controls.Add(Me.ucrReceiverRowFactor)
        Me.Controls.Add(Me.lblGroupby)
        Me.Controls.Add(Me.rdoTable)
        Me.Controls.Add(Me.rdoGraph)
        Me.Controls.Add(Me.ucrPnlFrequencyDisplay)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorThreeVariableFrequencies)
        Me.Controls.Add(Me.grpFreqTypeGraph)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrChkFlip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgThreeVariableFrequencies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Three Variable Frequencies"
        Me.grpFreqTypeTable.ResumeLayout(False)
        Me.grpFreqTypeTable.PerformLayout()
        Me.grpFreqTypeGraph.ResumeLayout(False)
        Me.grpFreqTypeGraph.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorThreeVariableFrequencies As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPnlFrequencyDisplay As UcrPanel
    Friend WithEvents rdoTable As RadioButton
    Friend WithEvents rdoGraph As RadioButton
    Friend WithEvents lblGroupby As Label
    Friend WithEvents lblColumnfactor As Label
    Friend WithEvents lblRowfactor As Label
    Friend WithEvents ucrReceiverColumnFactor As ucrReceiverSingle
    Friend WithEvents ucrReceiverRowFactor As ucrReceiverSingle
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrChkWeights As ucrCheck
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents ucrChkFlip As ucrCheck
    Friend WithEvents ucrReceiverGroupsBy1st As ucrReceiverSingle
    Friend WithEvents grpFreqTypeTable As GroupBox
    Friend WithEvents rdoCount As RadioButton
    Friend WithEvents rdoCell As RadioButton
    Friend WithEvents rdoRow As RadioButton
    Friend WithEvents rdoColumn As RadioButton
    Friend WithEvents ucrPnlFreqType As UcrPanel
    Friend WithEvents ucrChkRow As ucrCheck
    Friend WithEvents ucrChkCount As ucrCheck
    Friend WithEvents ucrChkColumn As ucrCheck
    Friend WithEvents ucrChkCell As ucrCheck
    Friend WithEvents ucrReceiverGroupBy2nd As ucrReceiverSingle
    Friend WithEvents lblGroupsby As Label
    Friend WithEvents grpFreqTypeGraph As GroupBox
    Friend WithEvents rdoBoth As RadioButton
    Friend WithEvents ucrSaveGraph As ucrSave
End Class
