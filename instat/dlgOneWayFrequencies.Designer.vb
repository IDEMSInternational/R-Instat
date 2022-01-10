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
        Me.grpSort = New System.Windows.Forms.GroupBox()
        Me.rdoDescending = New System.Windows.Forms.RadioButton()
        Me.rdoAscending = New System.Windows.Forms.RadioButton()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSort = New instat.UcrPanel()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.rdoGraph = New System.Windows.Forms.RadioButton()
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.rdoBoth = New System.Windows.Forms.RadioButton()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.rdoAsHtml = New System.Windows.Forms.RadioButton()
        Me.rdoAsText = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOutput = New instat.UcrPanel()
        Me.rdoStemAndLeaf = New System.Windows.Forms.RadioButton()
        Me.lblSelectVariableStemAndLeaf = New System.Windows.Forms.Label()
        Me.ucrReceiverStemAndLeaf = New instat.ucrReceiverSingle()
        Me.ucrNudScale = New instat.ucrNud()
        Me.ucrSaveDataFrame = New instat.ucrSave()
        Me.ucrNudMinFreq = New instat.ucrNud()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrNudGroups = New instat.ucrNud()
        Me.ucrPnlFrequencies = New instat.UcrPanel()
        Me.ucrChkGroupData = New instat.ucrCheck()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorOneWayFreq = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkFlip = New instat.ucrCheck()
        Me.ucrChkMinFrq = New instat.ucrCheck()
        Me.ucrChkScale = New instat.ucrCheck()
        Me.ucrReceiverOneWayFreq = New instat.ucrReceiverMultiple()
        Me.ucrChkWidth = New instat.ucrCheck()
        Me.ucrNudWidth = New instat.ucrNud()
        Me.grpSort.SuspendLayout()
        Me.grpOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSort
        '
        Me.grpSort.Controls.Add(Me.rdoDescending)
        Me.grpSort.Controls.Add(Me.rdoAscending)
        Me.grpSort.Controls.Add(Me.rdoNone)
        Me.grpSort.Controls.Add(Me.ucrPnlSort)
        Me.grpSort.Location = New System.Drawing.Point(258, 185)
        Me.grpSort.Name = "grpSort"
        Me.grpSort.Size = New System.Drawing.Size(167, 88)
        Me.grpSort.TabIndex = 9
        Me.grpSort.TabStop = False
        Me.grpSort.Text = "Sort"
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
        'ucrPnlSort
        '
        Me.ucrPnlSort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSort.Location = New System.Drawing.Point(3, 14)
        Me.ucrPnlSort.Name = "ucrPnlSort"
        Me.ucrPnlSort.Size = New System.Drawing.Size(158, 69)
        Me.ucrPnlSort.TabIndex = 0
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
        'rdoGraph
        '
        Me.rdoGraph.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGraph.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatAppearance.BorderSize = 2
        Me.rdoGraph.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGraph.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGraph.Location = New System.Drawing.Point(116, 10)
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.Size = New System.Drawing.Size(100, 28)
        Me.rdoGraph.TabIndex = 2
        Me.rdoGraph.Text = "Graph"
        Me.rdoGraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'rdoTable
        '
        Me.rdoTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTable.Location = New System.Drawing.Point(18, 10)
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.Size = New System.Drawing.Size(100, 28)
        Me.rdoTable.TabIndex = 1
        Me.rdoTable.Text = "Table"
        Me.rdoTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTable.UseVisualStyleBackColor = True
        '
        'rdoBoth
        '
        Me.rdoBoth.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBoth.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.FlatAppearance.BorderSize = 2
        Me.rdoBoth.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBoth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBoth.Location = New System.Drawing.Point(214, 10)
        Me.rdoBoth.Name = "rdoBoth"
        Me.rdoBoth.Size = New System.Drawing.Size(100, 28)
        Me.rdoBoth.TabIndex = 3
        Me.rdoBoth.Text = "Both"
        Me.rdoBoth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBoth.UseVisualStyleBackColor = True
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.rdoAsHtml)
        Me.grpOutput.Controls.Add(Me.rdoAsText)
        Me.grpOutput.Controls.Add(Me.ucrPnlOutput)
        Me.grpOutput.Location = New System.Drawing.Point(258, 275)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(165, 75)
        Me.grpOutput.TabIndex = 10
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Output "
        '
        'rdoAsHtml
        '
        Me.rdoAsHtml.AutoSize = True
        Me.rdoAsHtml.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAsHtml.Location = New System.Drawing.Point(6, 43)
        Me.rdoAsHtml.Name = "rdoAsHtml"
        Me.rdoAsHtml.Size = New System.Drawing.Size(102, 17)
        Me.rdoAsHtml.TabIndex = 2
        Me.rdoAsHtml.Text = "HTML (Browser)"
        Me.rdoAsHtml.UseVisualStyleBackColor = True
        '
        'rdoAsText
        '
        Me.rdoAsText.AutoSize = True
        Me.rdoAsText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAsText.Location = New System.Drawing.Point(6, 20)
        Me.rdoAsText.Name = "rdoAsText"
        Me.rdoAsText.Size = New System.Drawing.Size(129, 17)
        Me.rdoAsText.TabIndex = 1
        Me.rdoAsText.Text = "Text (Output Window)"
        Me.rdoAsText.UseVisualStyleBackColor = True
        '
        'ucrPnlOutput
        '
        Me.ucrPnlOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOutput.Location = New System.Drawing.Point(3, 16)
        Me.ucrPnlOutput.Name = "ucrPnlOutput"
        Me.ucrPnlOutput.Size = New System.Drawing.Size(150, 53)
        Me.ucrPnlOutput.TabIndex = 0
        '
        'rdoStemAndLeaf
        '
        Me.rdoStemAndLeaf.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoStemAndLeaf.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStemAndLeaf.FlatAppearance.BorderSize = 2
        Me.rdoStemAndLeaf.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStemAndLeaf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoStemAndLeaf.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStemAndLeaf.Location = New System.Drawing.Point(314, 10)
        Me.rdoStemAndLeaf.Name = "rdoStemAndLeaf"
        Me.rdoStemAndLeaf.Size = New System.Drawing.Size(100, 28)
        Me.rdoStemAndLeaf.TabIndex = 4
        Me.rdoStemAndLeaf.Text = "Stem and Leaf"
        Me.rdoStemAndLeaf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStemAndLeaf.UseVisualStyleBackColor = True
        '
        'lblSelectVariableStemAndLeaf
        '
        Me.lblSelectVariableStemAndLeaf.AutoSize = True
        Me.lblSelectVariableStemAndLeaf.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectVariableStemAndLeaf.Location = New System.Drawing.Point(257, 63)
        Me.lblSelectVariableStemAndLeaf.Name = "lblSelectVariableStemAndLeaf"
        Me.lblSelectVariableStemAndLeaf.Size = New System.Drawing.Size(93, 13)
        Me.lblSelectVariableStemAndLeaf.TabIndex = 6
        Me.lblSelectVariableStemAndLeaf.Text = "Selected Variable:"
        '
        'ucrReceiverStemAndLeaf
        '
        Me.ucrReceiverStemAndLeaf.AutoSize = True
        Me.ucrReceiverStemAndLeaf.frmParent = Me
        Me.ucrReceiverStemAndLeaf.Location = New System.Drawing.Point(258, 79)
        Me.ucrReceiverStemAndLeaf.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStemAndLeaf.Name = "ucrReceiverStemAndLeaf"
        Me.ucrReceiverStemAndLeaf.Selector = Nothing
        Me.ucrReceiverStemAndLeaf.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStemAndLeaf.strNcFilePath = ""
        Me.ucrReceiverStemAndLeaf.TabIndex = 7
        Me.ucrReceiverStemAndLeaf.ucrSelector = Nothing
        '
        'ucrNudScale
        '
        Me.ucrNudScale.AutoSize = True
        Me.ucrNudScale.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudScale.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudScale.Location = New System.Drawing.Point(142, 235)
        Me.ucrNudScale.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudScale.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudScale.Name = "ucrNudScale"
        Me.ucrNudScale.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudScale.TabIndex = 13
        Me.ucrNudScale.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSaveDataFrame
        '
        Me.ucrSaveDataFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveDataFrame.Location = New System.Drawing.Point(10, 376)
        Me.ucrSaveDataFrame.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveDataFrame.Name = "ucrSaveDataFrame"
        Me.ucrSaveDataFrame.Size = New System.Drawing.Size(254, 24)
        Me.ucrSaveDataFrame.TabIndex = 23
        '
        'ucrNudMinFreq
        '
        Me.ucrNudMinFreq.AutoSize = True
        Me.ucrNudMinFreq.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinFreq.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinFreq.Location = New System.Drawing.Point(142, 328)
        Me.ucrNudMinFreq.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinFreq.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinFreq.Name = "ucrNudMinFreq"
        Me.ucrNudMinFreq.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMinFreq.TabIndex = 21
        Me.ucrNudMinFreq.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 352)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(254, 24)
        Me.ucrSaveGraph.TabIndex = 22
        '
        'ucrNudGroups
        '
        Me.ucrNudGroups.AutoSize = True
        Me.ucrNudGroups.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudGroups.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudGroups.Location = New System.Drawing.Point(142, 277)
        Me.ucrNudGroups.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudGroups.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudGroups.Name = "ucrNudGroups"
        Me.ucrNudGroups.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudGroups.TabIndex = 18
        Me.ucrNudGroups.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlFrequencies
        '
        Me.ucrPnlFrequencies.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlFrequencies.Location = New System.Drawing.Point(9, 6)
        Me.ucrPnlFrequencies.Name = "ucrPnlFrequencies"
        Me.ucrPnlFrequencies.Size = New System.Drawing.Size(410, 35)
        Me.ucrPnlFrequencies.TabIndex = 0
        '
        'ucrChkGroupData
        '
        Me.ucrChkGroupData.AutoSize = True
        Me.ucrChkGroupData.Checked = False
        Me.ucrChkGroupData.Location = New System.Drawing.Point(10, 280)
        Me.ucrChkGroupData.Name = "ucrChkGroupData"
        Me.ucrChkGroupData.Size = New System.Drawing.Size(145, 23)
        Me.ucrChkGroupData.TabIndex = 17
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.AutoSize = True
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(142, 254)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(90, 20)
        Me.ucrReceiverWeights.strNcFilePath = ""
        Me.ucrReceiverWeights.TabIndex = 15
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.AutoSize = True
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(10, 256)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(145, 23)
        Me.ucrChkWeights.TabIndex = 14
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 410)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 24
        '
        'ucrSelectorOneWayFreq
        '
        Me.ucrSelectorOneWayFreq.AutoSize = True
        Me.ucrSelectorOneWayFreq.bDropUnusedFilterLevels = False
        Me.ucrSelectorOneWayFreq.bShowHiddenColumns = False
        Me.ucrSelectorOneWayFreq.bUseCurrentFilter = True
        Me.ucrSelectorOneWayFreq.Location = New System.Drawing.Point(10, 45)
        Me.ucrSelectorOneWayFreq.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOneWayFreq.Name = "ucrSelectorOneWayFreq"
        Me.ucrSelectorOneWayFreq.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorOneWayFreq.TabIndex = 5
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.AutoSize = True
        Me.ucrChkFlip.Checked = False
        Me.ucrChkFlip.Location = New System.Drawing.Point(10, 304)
        Me.ucrChkFlip.Name = "ucrChkFlip"
        Me.ucrChkFlip.Size = New System.Drawing.Size(210, 23)
        Me.ucrChkFlip.TabIndex = 19
        '
        'ucrChkMinFrq
        '
        Me.ucrChkMinFrq.AutoSize = True
        Me.ucrChkMinFrq.Checked = False
        Me.ucrChkMinFrq.Location = New System.Drawing.Point(10, 326)
        Me.ucrChkMinFrq.Name = "ucrChkMinFrq"
        Me.ucrChkMinFrq.Size = New System.Drawing.Size(210, 23)
        Me.ucrChkMinFrq.TabIndex = 20
        '
        'ucrChkScale
        '
        Me.ucrChkScale.AutoSize = True
        Me.ucrChkScale.Checked = False
        Me.ucrChkScale.Location = New System.Drawing.Point(10, 235)
        Me.ucrChkScale.Name = "ucrChkScale"
        Me.ucrChkScale.Size = New System.Drawing.Size(126, 23)
        Me.ucrChkScale.TabIndex = 12
        '
        'ucrReceiverOneWayFreq
        '
        Me.ucrReceiverOneWayFreq.AutoSize = True
        Me.ucrReceiverOneWayFreq.frmParent = Me
        Me.ucrReceiverOneWayFreq.Location = New System.Drawing.Point(258, 79)
        Me.ucrReceiverOneWayFreq.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOneWayFreq.Name = "ucrReceiverOneWayFreq"
        Me.ucrReceiverOneWayFreq.Selector = Nothing
        Me.ucrReceiverOneWayFreq.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverOneWayFreq.strNcFilePath = ""
        Me.ucrReceiverOneWayFreq.TabIndex = 8
        Me.ucrReceiverOneWayFreq.ucrSelector = Nothing
        '
        'ucrChkWidth
        '
        Me.ucrChkWidth.AutoSize = True
        Me.ucrChkWidth.Checked = False
        Me.ucrChkWidth.Location = New System.Drawing.Point(10, 260)
        Me.ucrChkWidth.Name = "ucrChkWidth"
        Me.ucrChkWidth.Size = New System.Drawing.Size(126, 23)
        Me.ucrChkWidth.TabIndex = 15
        '
        'ucrNudWidth
        '
        Me.ucrNudWidth.AutoSize = True
        Me.ucrNudWidth.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWidth.Location = New System.Drawing.Point(142, 260)
        Me.ucrNudWidth.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWidth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Name = "ucrNudWidth"
        Me.ucrNudWidth.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWidth.TabIndex = 16
        Me.ucrNudWidth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgOneWayFrequencies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(435, 470)
        Me.Controls.Add(Me.ucrNudWidth)
        Me.Controls.Add(Me.ucrReceiverStemAndLeaf)
        Me.Controls.Add(Me.ucrNudScale)
        Me.Controls.Add(Me.lblSelectVariableStemAndLeaf)
        Me.Controls.Add(Me.rdoStemAndLeaf)
        Me.Controls.Add(Me.ucrSaveDataFrame)
        Me.Controls.Add(Me.ucrNudMinFreq)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.rdoBoth)
        Me.Controls.Add(Me.rdoGraph)
        Me.Controls.Add(Me.ucrNudGroups)
        Me.Controls.Add(Me.rdoTable)
        Me.Controls.Add(Me.ucrPnlFrequencies)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.grpSort)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorOneWayFreq)
        Me.Controls.Add(Me.ucrChkFlip)
        Me.Controls.Add(Me.ucrChkScale)
        Me.Controls.Add(Me.ucrReceiverOneWayFreq)
        Me.Controls.Add(Me.ucrChkMinFrq)
        Me.Controls.Add(Me.ucrChkWeights)
        Me.Controls.Add(Me.ucrChkWidth)
        Me.Controls.Add(Me.ucrChkGroupData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneWayFrequencies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frequencies"
        Me.grpSort.ResumeLayout(False)
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorOneWayFreq As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpSort As GroupBox
    Friend WithEvents rdoDescending As RadioButton
    Friend WithEvents rdoAscending As RadioButton
    Friend WithEvents rdoNone As RadioButton
    Friend WithEvents ucrPnlSort As UcrPanel
    Friend WithEvents cmdOptions As Button
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrChkFlip As ucrCheck
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents ucrChkWeights As ucrCheck
    Friend WithEvents ucrNudGroups As ucrNud
    Friend WithEvents ucrChkGroupData As ucrCheck
    Friend WithEvents rdoGraph As RadioButton
    Friend WithEvents rdoTable As RadioButton
    Friend WithEvents ucrPnlFrequencies As UcrPanel
    Friend WithEvents rdoBoth As RadioButton
    Friend WithEvents ucrReceiverOneWayFreq As ucrReceiverMultiple
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents grpOutput As GroupBox
    Friend WithEvents rdoAsHtml As RadioButton
    Friend WithEvents rdoAsText As RadioButton
    Friend WithEvents ucrPnlOutput As UcrPanel
    Friend WithEvents ucrNudMinFreq As ucrNud
    Friend WithEvents ucrChkMinFrq As ucrCheck
    Friend WithEvents ucrSaveDataFrame As ucrSave
    Friend WithEvents lblSelectVariableStemAndLeaf As Label
    Private WithEvents rdoStemAndLeaf As RadioButton
    Friend WithEvents ucrNudScale As ucrNud
    Friend WithEvents ucrChkScale As ucrCheck
    Friend WithEvents ucrReceiverStemAndLeaf As ucrReceiverSingle
    Friend WithEvents ucrNudWidth As ucrNud
    Friend WithEvents ucrChkWidth As ucrCheck
End Class
