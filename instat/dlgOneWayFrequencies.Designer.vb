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
Partial Class dlgOneWayFrequencies
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
        Me.grpTableGraphSort = New System.Windows.Forms.GroupBox()
        Me.rdoDescending = New System.Windows.Forms.RadioButton()
        Me.rdoAscending = New System.Windows.Forms.RadioButton()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.ucrPnlTableGraphSort = New instat.UcrPanel()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.rdoFrqGraph = New System.Windows.Forms.RadioButton()
        Me.rdoFrqTable = New System.Windows.Forms.RadioButton()
        Me.grpTableGraphOutput = New System.Windows.Forms.GroupBox()
        Me.rdoTableAsOutput = New System.Windows.Forms.RadioButton()
        Me.rdoTableAsDataFrame = New System.Windows.Forms.RadioButton()
        Me.ucrPnlTableOutput = New instat.UcrPanel()
        Me.rdoFrqStemLeaf = New System.Windows.Forms.RadioButton()
        Me.ucrNudStemLeafWidth = New instat.ucrNud()
        Me.ucrNudStemLeafScale = New instat.ucrNud()
        Me.ucrNudTableMinFreq = New instat.ucrNud()
        Me.ucrSaveFreq = New instat.ucrSave()
        Me.ucrNudTableGraphGroups = New instat.ucrNud()
        Me.ucrPnlFreq = New instat.UcrPanel()
        Me.ucrReceiverTableGraphWeights = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorFreq = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkGraphFlipCoordinates = New instat.ucrCheck()
        Me.ucrChkStemLeafScale = New instat.ucrCheck()
        Me.ucrChkTableMinFrq = New instat.ucrCheck()
        Me.ucrChkTableGraphWeights = New instat.ucrCheck()
        Me.ucrChkStemLeafWidth = New instat.ucrCheck()
        Me.ucrChkTableGraphGroupData = New instat.ucrCheck()
        Me.ucrReceiverTableGraph = New instat.ucrReceiverMultiple()
        Me.ucrReceiverStemAndLeaf = New instat.ucrReceiverMultiple()
        Me.grpTableGraphSort.SuspendLayout()
        Me.grpTableGraphOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTableGraphSort
        '
        Me.grpTableGraphSort.Controls.Add(Me.rdoDescending)
        Me.grpTableGraphSort.Controls.Add(Me.rdoAscending)
        Me.grpTableGraphSort.Controls.Add(Me.rdoNone)
        Me.grpTableGraphSort.Controls.Add(Me.ucrPnlTableGraphSort)
        Me.grpTableGraphSort.Location = New System.Drawing.Point(258, 185)
        Me.grpTableGraphSort.Name = "grpTableGraphSort"
        Me.grpTableGraphSort.Size = New System.Drawing.Size(177, 88)
        Me.grpTableGraphSort.TabIndex = 9
        Me.grpTableGraphSort.TabStop = False
        Me.grpTableGraphSort.Text = "Sort"
        '
        'rdoDescending
        '
        Me.rdoDescending.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDescending.Location = New System.Drawing.Point(6, 65)
        Me.rdoDescending.Name = "rdoDescending"
        Me.rdoDescending.Size = New System.Drawing.Size(155, 17)
        Me.rdoDescending.TabIndex = 3
        Me.rdoDescending.TabStop = True
        Me.rdoDescending.Text = "Descending"
        Me.rdoDescending.UseVisualStyleBackColor = True
        '
        'rdoAscending
        '
        Me.rdoAscending.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAscending.Location = New System.Drawing.Point(6, 43)
        Me.rdoAscending.Name = "rdoAscending"
        Me.rdoAscending.Size = New System.Drawing.Size(155, 17)
        Me.rdoAscending.TabIndex = 2
        Me.rdoAscending.TabStop = True
        Me.rdoAscending.Text = "Ascending"
        Me.rdoAscending.UseVisualStyleBackColor = True
        '
        'rdoNone
        '
        Me.rdoNone.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNone.Location = New System.Drawing.Point(6, 21)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(137, 16)
        Me.rdoNone.TabIndex = 1
        Me.rdoNone.TabStop = True
        Me.rdoNone.Text = "None"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'ucrPnlTableGraphSort
        '
        Me.ucrPnlTableGraphSort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlTableGraphSort.Location = New System.Drawing.Point(3, 14)
        Me.ucrPnlTableGraphSort.Name = "ucrPnlTableGraphSort"
        Me.ucrPnlTableGraphSort.Size = New System.Drawing.Size(158, 69)
        Me.ucrPnlTableGraphSort.TabIndex = 0
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(10, 228)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(96, 23)
        Me.cmdOptions.TabIndex = 11
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectedVariable.Location = New System.Drawing.Point(258, 64)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(93, 13)
        Me.lblSelectedVariable.TabIndex = 8
        Me.lblSelectedVariable.Text = "Selected Variable:"
        '
        'rdoFrqGraph
        '
        Me.rdoFrqGraph.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoFrqGraph.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFrqGraph.FlatAppearance.BorderSize = 2
        Me.rdoFrqGraph.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFrqGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoFrqGraph.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFrqGraph.Location = New System.Drawing.Point(156, 10)
        Me.rdoFrqGraph.Name = "rdoFrqGraph"
        Me.rdoFrqGraph.Size = New System.Drawing.Size(100, 28)
        Me.rdoFrqGraph.TabIndex = 2
        Me.rdoFrqGraph.Text = "Graph"
        Me.rdoFrqGraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFrqGraph.UseVisualStyleBackColor = True
        '
        'rdoFrqTable
        '
        Me.rdoFrqTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoFrqTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFrqTable.FlatAppearance.BorderSize = 2
        Me.rdoFrqTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFrqTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoFrqTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFrqTable.Location = New System.Drawing.Point(58, 10)
        Me.rdoFrqTable.Name = "rdoFrqTable"
        Me.rdoFrqTable.Size = New System.Drawing.Size(100, 28)
        Me.rdoFrqTable.TabIndex = 1
        Me.rdoFrqTable.Text = "Table"
        Me.rdoFrqTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFrqTable.UseVisualStyleBackColor = True
        '
        'grpTableGraphOutput
        '
        Me.grpTableGraphOutput.Controls.Add(Me.rdoTableAsOutput)
        Me.grpTableGraphOutput.Controls.Add(Me.rdoTableAsDataFrame)
        Me.grpTableGraphOutput.Controls.Add(Me.ucrPnlTableOutput)
        Me.grpTableGraphOutput.Location = New System.Drawing.Point(258, 275)
        Me.grpTableGraphOutput.Name = "grpTableGraphOutput"
        Me.grpTableGraphOutput.Size = New System.Drawing.Size(177, 75)
        Me.grpTableGraphOutput.TabIndex = 10
        Me.grpTableGraphOutput.TabStop = False
        Me.grpTableGraphOutput.Text = "Output "
        '
        'rdoTableAsOutput
        '
        Me.rdoTableAsOutput.AutoSize = True
        Me.rdoTableAsOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTableAsOutput.Location = New System.Drawing.Point(6, 20)
        Me.rdoTableAsOutput.Name = "rdoTableAsOutput"
        Me.rdoTableAsOutput.Size = New System.Drawing.Size(113, 17)
        Me.rdoTableAsOutput.TabIndex = 2
        Me.rdoTableAsOutput.Text = "As Summary Table"
        Me.rdoTableAsOutput.UseVisualStyleBackColor = True
        '
        'rdoTableAsDataFrame
        '
        Me.rdoTableAsDataFrame.AutoSize = True
        Me.rdoTableAsDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTableAsDataFrame.Location = New System.Drawing.Point(6, 46)
        Me.rdoTableAsDataFrame.Name = "rdoTableAsDataFrame"
        Me.rdoTableAsDataFrame.Size = New System.Drawing.Size(92, 17)
        Me.rdoTableAsDataFrame.TabIndex = 1
        Me.rdoTableAsDataFrame.Text = "As DataFrame"
        Me.rdoTableAsDataFrame.UseVisualStyleBackColor = True
        '
        'ucrPnlTableOutput
        '
        Me.ucrPnlTableOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlTableOutput.Location = New System.Drawing.Point(3, 16)
        Me.ucrPnlTableOutput.Name = "ucrPnlTableOutput"
        Me.ucrPnlTableOutput.Size = New System.Drawing.Size(174, 53)
        Me.ucrPnlTableOutput.TabIndex = 0
        '
        'rdoFrqStemLeaf
        '
        Me.rdoFrqStemLeaf.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoFrqStemLeaf.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFrqStemLeaf.FlatAppearance.BorderSize = 2
        Me.rdoFrqStemLeaf.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFrqStemLeaf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoFrqStemLeaf.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFrqStemLeaf.Location = New System.Drawing.Point(254, 10)
        Me.rdoFrqStemLeaf.Name = "rdoFrqStemLeaf"
        Me.rdoFrqStemLeaf.Size = New System.Drawing.Size(100, 28)
        Me.rdoFrqStemLeaf.TabIndex = 4
        Me.rdoFrqStemLeaf.Text = "Stem and Leaf"
        Me.rdoFrqStemLeaf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFrqStemLeaf.UseVisualStyleBackColor = True
        '
        'ucrNudStemLeafWidth
        '
        Me.ucrNudStemLeafWidth.AutoSize = True
        Me.ucrNudStemLeafWidth.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudStemLeafWidth.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudStemLeafWidth.Location = New System.Drawing.Point(140, 289)
        Me.ucrNudStemLeafWidth.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudStemLeafWidth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudStemLeafWidth.Name = "ucrNudStemLeafWidth"
        Me.ucrNudStemLeafWidth.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudStemLeafWidth.TabIndex = 16
        Me.ucrNudStemLeafWidth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudStemLeafScale
        '
        Me.ucrNudStemLeafScale.AutoSize = True
        Me.ucrNudStemLeafScale.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudStemLeafScale.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudStemLeafScale.Location = New System.Drawing.Point(139, 254)
        Me.ucrNudStemLeafScale.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudStemLeafScale.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudStemLeafScale.Name = "ucrNudStemLeafScale"
        Me.ucrNudStemLeafScale.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudStemLeafScale.TabIndex = 13
        Me.ucrNudStemLeafScale.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTableMinFreq
        '
        Me.ucrNudTableMinFreq.AutoSize = True
        Me.ucrNudTableMinFreq.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTableMinFreq.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTableMinFreq.Location = New System.Drawing.Point(142, 328)
        Me.ucrNudTableMinFreq.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTableMinFreq.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTableMinFreq.Name = "ucrNudTableMinFreq"
        Me.ucrNudTableMinFreq.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTableMinFreq.TabIndex = 21
        Me.ucrNudTableMinFreq.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSaveFreq
        '
        Me.ucrSaveFreq.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveFreq.Location = New System.Drawing.Point(10, 368)
        Me.ucrSaveFreq.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveFreq.Name = "ucrSaveFreq"
        Me.ucrSaveFreq.Size = New System.Drawing.Size(304, 24)
        Me.ucrSaveFreq.TabIndex = 22
        '
        'ucrNudTableGraphGroups
        '
        Me.ucrNudTableGraphGroups.AutoSize = True
        Me.ucrNudTableGraphGroups.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTableGraphGroups.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTableGraphGroups.Location = New System.Drawing.Point(142, 277)
        Me.ucrNudTableGraphGroups.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTableGraphGroups.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTableGraphGroups.Name = "ucrNudTableGraphGroups"
        Me.ucrNudTableGraphGroups.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTableGraphGroups.TabIndex = 18
        Me.ucrNudTableGraphGroups.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlFreq
        '
        Me.ucrPnlFreq.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlFreq.Location = New System.Drawing.Point(9, 6)
        Me.ucrPnlFreq.Name = "ucrPnlFreq"
        Me.ucrPnlFreq.Size = New System.Drawing.Size(410, 35)
        Me.ucrPnlFreq.TabIndex = 0
        '
        'ucrReceiverTableGraphWeights
        '
        Me.ucrReceiverTableGraphWeights.AutoSize = True
        Me.ucrReceiverTableGraphWeights.frmParent = Me
        Me.ucrReceiverTableGraphWeights.Location = New System.Drawing.Point(142, 254)
        Me.ucrReceiverTableGraphWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTableGraphWeights.Name = "ucrReceiverTableGraphWeights"
        Me.ucrReceiverTableGraphWeights.Selector = Nothing
        Me.ucrReceiverTableGraphWeights.Size = New System.Drawing.Size(90, 20)
        Me.ucrReceiverTableGraphWeights.strNcFilePath = ""
        Me.ucrReceiverTableGraphWeights.TabIndex = 15
        Me.ucrReceiverTableGraphWeights.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 400)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 24
        '
        'ucrSelectorFreq
        '
        Me.ucrSelectorFreq.AutoSize = True
        Me.ucrSelectorFreq.bDropUnusedFilterLevels = False
        Me.ucrSelectorFreq.bShowHiddenColumns = False
        Me.ucrSelectorFreq.bUseCurrentFilter = True
        Me.ucrSelectorFreq.Location = New System.Drawing.Point(10, 45)
        Me.ucrSelectorFreq.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFreq.Name = "ucrSelectorFreq"
        Me.ucrSelectorFreq.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorFreq.TabIndex = 5
        '
        'ucrChkGraphFlipCoordinates
        '
        Me.ucrChkGraphFlipCoordinates.AutoSize = True
        Me.ucrChkGraphFlipCoordinates.Checked = False
        Me.ucrChkGraphFlipCoordinates.Location = New System.Drawing.Point(10, 304)
        Me.ucrChkGraphFlipCoordinates.Name = "ucrChkGraphFlipCoordinates"
        Me.ucrChkGraphFlipCoordinates.Size = New System.Drawing.Size(210, 23)
        Me.ucrChkGraphFlipCoordinates.TabIndex = 19
        '
        'ucrChkStemLeafScale
        '
        Me.ucrChkStemLeafScale.AutoSize = True
        Me.ucrChkStemLeafScale.Checked = False
        Me.ucrChkStemLeafScale.Location = New System.Drawing.Point(10, 254)
        Me.ucrChkStemLeafScale.Name = "ucrChkStemLeafScale"
        Me.ucrChkStemLeafScale.Size = New System.Drawing.Size(126, 23)
        Me.ucrChkStemLeafScale.TabIndex = 12
        '
        'ucrChkTableMinFrq
        '
        Me.ucrChkTableMinFrq.AutoSize = True
        Me.ucrChkTableMinFrq.Checked = False
        Me.ucrChkTableMinFrq.Location = New System.Drawing.Point(10, 326)
        Me.ucrChkTableMinFrq.Name = "ucrChkTableMinFrq"
        Me.ucrChkTableMinFrq.Size = New System.Drawing.Size(210, 23)
        Me.ucrChkTableMinFrq.TabIndex = 20
        '
        'ucrChkTableGraphWeights
        '
        Me.ucrChkTableGraphWeights.AutoSize = True
        Me.ucrChkTableGraphWeights.Checked = False
        Me.ucrChkTableGraphWeights.Location = New System.Drawing.Point(10, 256)
        Me.ucrChkTableGraphWeights.Name = "ucrChkTableGraphWeights"
        Me.ucrChkTableGraphWeights.Size = New System.Drawing.Size(145, 23)
        Me.ucrChkTableGraphWeights.TabIndex = 14
        '
        'ucrChkStemLeafWidth
        '
        Me.ucrChkStemLeafWidth.AutoSize = True
        Me.ucrChkStemLeafWidth.Checked = False
        Me.ucrChkStemLeafWidth.Location = New System.Drawing.Point(10, 287)
        Me.ucrChkStemLeafWidth.Name = "ucrChkStemLeafWidth"
        Me.ucrChkStemLeafWidth.Size = New System.Drawing.Size(126, 23)
        Me.ucrChkStemLeafWidth.TabIndex = 15
        '
        'ucrChkTableGraphGroupData
        '
        Me.ucrChkTableGraphGroupData.AutoSize = True
        Me.ucrChkTableGraphGroupData.Checked = False
        Me.ucrChkTableGraphGroupData.Location = New System.Drawing.Point(10, 280)
        Me.ucrChkTableGraphGroupData.Name = "ucrChkTableGraphGroupData"
        Me.ucrChkTableGraphGroupData.Size = New System.Drawing.Size(145, 23)
        Me.ucrChkTableGraphGroupData.TabIndex = 17
        '
        'ucrReceiverTableGraph
        '
        Me.ucrReceiverTableGraph.AutoSize = True
        Me.ucrReceiverTableGraph.frmParent = Me
        Me.ucrReceiverTableGraph.Location = New System.Drawing.Point(258, 80)
        Me.ucrReceiverTableGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTableGraph.Name = "ucrReceiverTableGraph"
        Me.ucrReceiverTableGraph.Selector = Nothing
        Me.ucrReceiverTableGraph.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverTableGraph.strNcFilePath = ""
        Me.ucrReceiverTableGraph.TabIndex = 8
        Me.ucrReceiverTableGraph.ucrSelector = Nothing
        '
        'ucrReceiverStemAndLeaf
        '
        Me.ucrReceiverStemAndLeaf.AutoSize = True
        Me.ucrReceiverStemAndLeaf.frmParent = Me
        Me.ucrReceiverStemAndLeaf.Location = New System.Drawing.Point(257, 79)
        Me.ucrReceiverStemAndLeaf.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStemAndLeaf.Name = "ucrReceiverStemAndLeaf"
        Me.ucrReceiverStemAndLeaf.Selector = Nothing
        Me.ucrReceiverStemAndLeaf.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverStemAndLeaf.strNcFilePath = ""
        Me.ucrReceiverStemAndLeaf.TabIndex = 25
        Me.ucrReceiverStemAndLeaf.ucrSelector = Nothing
        '
        'dlgOneWayFrequencies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(435, 456)
        Me.Controls.Add(Me.ucrReceiverStemAndLeaf)
        Me.Controls.Add(Me.ucrNudStemLeafWidth)
        Me.Controls.Add(Me.ucrNudStemLeafScale)
        Me.Controls.Add(Me.rdoFrqStemLeaf)
        Me.Controls.Add(Me.ucrNudTableMinFreq)
        Me.Controls.Add(Me.grpTableGraphOutput)
        Me.Controls.Add(Me.ucrSaveFreq)
        Me.Controls.Add(Me.rdoFrqGraph)
        Me.Controls.Add(Me.ucrNudTableGraphGroups)
        Me.Controls.Add(Me.rdoFrqTable)
        Me.Controls.Add(Me.ucrPnlFreq)
        Me.Controls.Add(Me.ucrReceiverTableGraphWeights)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.grpTableGraphSort)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorFreq)
        Me.Controls.Add(Me.ucrChkGraphFlipCoordinates)
        Me.Controls.Add(Me.ucrChkStemLeafScale)
        Me.Controls.Add(Me.ucrChkTableMinFrq)
        Me.Controls.Add(Me.ucrChkStemLeafWidth)
        Me.Controls.Add(Me.ucrChkTableGraphGroupData)
        Me.Controls.Add(Me.ucrReceiverTableGraph)
        Me.Controls.Add(Me.ucrChkTableGraphWeights)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneWayFrequencies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frequencies"
        Me.grpTableGraphSort.ResumeLayout(False)
        Me.grpTableGraphOutput.ResumeLayout(False)
        Me.grpTableGraphOutput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorFreq As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpTableGraphSort As GroupBox
    Friend WithEvents rdoDescending As RadioButton
    Friend WithEvents rdoAscending As RadioButton
    Friend WithEvents rdoNone As RadioButton
    Friend WithEvents ucrPnlTableGraphSort As UcrPanel
    Friend WithEvents cmdOptions As Button
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrChkGraphFlipCoordinates As ucrCheck
    Friend WithEvents ucrReceiverTableGraphWeights As ucrReceiverSingle
    Friend WithEvents ucrChkTableGraphWeights As ucrCheck
    Friend WithEvents ucrNudTableGraphGroups As ucrNud
    Friend WithEvents ucrChkTableGraphGroupData As ucrCheck
    Friend WithEvents rdoFrqGraph As RadioButton
    Friend WithEvents rdoFrqTable As RadioButton
    Friend WithEvents ucrPnlFreq As UcrPanel
    Friend WithEvents ucrReceiverTableGraph As ucrReceiverMultiple
    Friend WithEvents ucrSaveFreq As ucrSave
    Friend WithEvents grpTableGraphOutput As GroupBox
    Friend WithEvents rdoTableAsOutput As RadioButton
    Friend WithEvents rdoTableAsDataFrame As RadioButton
    Friend WithEvents ucrPnlTableOutput As UcrPanel
    Friend WithEvents ucrNudTableMinFreq As ucrNud
    Friend WithEvents ucrChkTableMinFrq As ucrCheck
    Private WithEvents rdoFrqStemLeaf As RadioButton
    Friend WithEvents ucrNudStemLeafScale As ucrNud
    Friend WithEvents ucrChkStemLeafScale As ucrCheck
    Friend WithEvents ucrNudStemLeafWidth As ucrNud
    Friend WithEvents ucrChkStemLeafWidth As ucrCheck
    Friend WithEvents ucrReceiverStemAndLeaf As ucrReceiverMultiple
End Class
