﻿' R- Instat
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
Partial Class dlgBarAndPieChart
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
        Me.components = New System.ComponentModel.Container()
        Me.lblByFactor = New System.Windows.Forms.Label()
        Me.rdoValue = New System.Windows.Forms.RadioButton()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.rdoFrequency = New System.Windows.Forms.RadioButton()
        Me.lblXvariable = New System.Windows.Forms.Label()
        Me.rdoPie = New System.Windows.Forms.RadioButton()
        Me.rdoDonut = New System.Windows.Forms.RadioButton()
        Me.lblLabelPosition = New System.Windows.Forms.Label()
        Me.lblLabelColour = New System.Windows.Forms.Label()
        Me.lblLabelSize = New System.Windows.Forms.Label()
        Me.lblLollipopSize = New System.Windows.Forms.Label()
        Me.lblReorder = New System.Windows.Forms.Label()
        Me.rdoTreeMap = New System.Windows.Forms.RadioButton()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.ttArea = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttFill = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblPlace = New System.Windows.Forms.Label()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.rdoWordCloud = New System.Windows.Forms.RadioButton()
        Me.lblWordcloudLabel = New System.Windows.Forms.Label()
        Me.lblWordcloudSize = New System.Windows.Forms.Label()
        Me.lblWordcloudColor = New System.Windows.Forms.Label()
        Me.lblWordcloudAngle = New System.Windows.Forms.Label()
        Me.contextMenuStripOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuItemPlotOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemBarchartOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemTextOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemLollipopOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemTreemapOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemTreemapTextOptionsOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemWordcloudOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdOptions = New instat.ucrSplitButton()
        Me.ucrChkReorderValue = New instat.ucrCheck()
        Me.ucrChkReorderFrequency = New instat.ucrCheck()
        Me.ucrInputPlace = New instat.ucrInputComboBox()
        Me.ucrInputLayout = New instat.ucrInputComboBox()
        Me.ucrReceiverLabel = New instat.ucrReceiverSingle()
        Me.ucrInputLabelSize = New instat.ucrInputComboBox()
        Me.ucrNudLollipopSize = New instat.ucrNud()
        Me.ucrNudMaxSize = New instat.ucrNud()
        Me.ucrChkLollipop = New instat.ucrCheck()
        Me.ucrInputLabelPosition = New instat.ucrInputComboBox()
        Me.ucrInputBarChartPositions = New instat.ucrInputComboBox()
        Me.ucrSaveBar = New instat.ucrSave()
        Me.ucrReceiverByFactor = New instat.ucrReceiverSingle()
        Me.ucrBarChartSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrReceiverArea = New instat.ucrReceiverSingle()
        Me.ucrReceiverWordcloudLabel = New instat.ucrReceiverSingle()
        Me.ucrInputReorderValue = New instat.ucrInputComboBox()
        Me.ucrReceiverWordcloudSize = New instat.ucrReceiverSingle()
        Me.ucrReceiverFill = New instat.ucrReceiverSingle()
        Me.ucrReceiverWordcloudColor = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrInputReorderX = New instat.ucrInputComboBox()
        Me.ucrInputAddReorder = New instat.ucrInputComboBox()
        Me.ucrPnlPolar = New instat.UcrPanel()
        Me.ucrInputLabelColour = New instat.ucrInputComboBox()
        Me.ucrChkStart = New instat.ucrCheck()
        Me.ucrInputStart = New instat.ucrInputComboBox()
        Me.ucrChkLayout = New instat.ucrCheck()
        Me.ucrChkFlipCoordinates = New instat.ucrCheck()
        Me.ucrChkPolarCoordinates = New instat.ucrCheck()
        Me.ucrVariablesAsFactorForBarChart = New instat.ucrVariablesAsFactor()
        Me.ucrReceiverWordcloudAngle = New instat.ucrReceiverSingle()
        Me.ucrChkAddLabelsText = New instat.ucrCheck()
        Me.ucrChkAddLabelsTreemap = New instat.ucrCheck()
        Me.ucrChkBacktoback = New instat.ucrCheck()
        Me.ucrChkIncreaseSize = New instat.ucrCheck()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucr1stFactorReceiver = New instat.ucrReceiverSingle()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrChkLegend = New instat.ucrCheck()
        Me.contextMenuStripOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblByFactor
        '
        Me.lblByFactor.AutoSize = True
        Me.lblByFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblByFactor.Location = New System.Drawing.Point(256, 286)
        Me.lblByFactor.Name = "lblByFactor"
        Me.lblByFactor.Size = New System.Drawing.Size(76, 13)
        Me.lblByFactor.TabIndex = 24
        Me.lblByFactor.Tag = "By_Factor:"
        Me.lblByFactor.Text = "By Factor (Fill):"
        '
        'rdoValue
        '
        Me.rdoValue.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoValue.BackColor = System.Drawing.SystemColors.Control
        Me.rdoValue.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoValue.FlatAppearance.BorderSize = 2
        Me.rdoValue.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoValue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoValue.Location = New System.Drawing.Point(116, 10)
        Me.rdoValue.Name = "rdoValue"
        Me.rdoValue.Size = New System.Drawing.Size(91, 28)
        Me.rdoValue.TabIndex = 2
        Me.rdoValue.TabStop = True
        Me.rdoValue.Tag = "Value"
        Me.rdoValue.Text = "Value"
        Me.rdoValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoValue.UseVisualStyleBackColor = False
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPosition.Location = New System.Drawing.Point(256, 364)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(47, 13)
        Me.lblPosition.TabIndex = 39
        Me.lblPosition.Text = "Position:"
        '
        'rdoFrequency
        '
        Me.rdoFrequency.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoFrequency.BackColor = System.Drawing.SystemColors.Control
        Me.rdoFrequency.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFrequency.FlatAppearance.BorderSize = 2
        Me.rdoFrequency.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFrequency.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoFrequency.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFrequency.Location = New System.Drawing.Point(27, 10)
        Me.rdoFrequency.Name = "rdoFrequency"
        Me.rdoFrequency.Size = New System.Drawing.Size(91, 28)
        Me.rdoFrequency.TabIndex = 1
        Me.rdoFrequency.TabStop = True
        Me.rdoFrequency.Tag = "Frequency"
        Me.rdoFrequency.Text = "Frequency"
        Me.rdoFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFrequency.UseVisualStyleBackColor = False
        '
        'lblXvariable
        '
        Me.lblXvariable.AutoSize = True
        Me.lblXvariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXvariable.Location = New System.Drawing.Point(256, 196)
        Me.lblXvariable.Name = "lblXvariable"
        Me.lblXvariable.Size = New System.Drawing.Size(58, 13)
        Me.lblXvariable.TabIndex = 5
        Me.lblXvariable.Text = "X Variable:"
        '
        'rdoPie
        '
        Me.rdoPie.AutoSize = True
        Me.rdoPie.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPie.Location = New System.Drawing.Point(115, 343)
        Me.rdoPie.Name = "rdoPie"
        Me.rdoPie.Size = New System.Drawing.Size(133, 17)
        Me.rdoPie.TabIndex = 34
        Me.rdoPie.TabStop = True
        Me.rdoPie.Text = "Pie                               "
        Me.rdoPie.UseVisualStyleBackColor = True
        '
        'rdoDonut
        '
        Me.rdoDonut.AutoSize = True
        Me.rdoDonut.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDonut.Location = New System.Drawing.Point(115, 365)
        Me.rdoDonut.Name = "rdoDonut"
        Me.rdoDonut.Size = New System.Drawing.Size(126, 17)
        Me.rdoDonut.TabIndex = 32
        Me.rdoDonut.TabStop = True
        Me.rdoDonut.Text = "Donut                        "
        Me.rdoDonut.UseVisualStyleBackColor = True
        '
        'lblLabelPosition
        '
        Me.lblLabelPosition.AutoSize = True
        Me.lblLabelPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabelPosition.Location = New System.Drawing.Point(26, 439)
        Me.lblLabelPosition.Name = "lblLabelPosition"
        Me.lblLabelPosition.Size = New System.Drawing.Size(47, 13)
        Me.lblLabelPosition.TabIndex = 24
        Me.lblLabelPosition.Text = "Position:"
        '
        'lblLabelColour
        '
        Me.lblLabelColour.AutoSize = True
        Me.lblLabelColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabelColour.Location = New System.Drawing.Point(176, 440)
        Me.lblLabelColour.Name = "lblLabelColour"
        Me.lblLabelColour.Size = New System.Drawing.Size(40, 13)
        Me.lblLabelColour.TabIndex = 26
        Me.lblLabelColour.Text = "Colour:"
        '
        'lblLabelSize
        '
        Me.lblLabelSize.AutoSize = True
        Me.lblLabelSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabelSize.Location = New System.Drawing.Point(280, 440)
        Me.lblLabelSize.Name = "lblLabelSize"
        Me.lblLabelSize.Size = New System.Drawing.Size(30, 13)
        Me.lblLabelSize.TabIndex = 56
        Me.lblLabelSize.Text = "Size:"
        '
        'lblLollipopSize
        '
        Me.lblLollipopSize.AutoSize = True
        Me.lblLollipopSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLollipopSize.Location = New System.Drawing.Point(123, 390)
        Me.lblLollipopSize.Name = "lblLollipopSize"
        Me.lblLollipopSize.Size = New System.Drawing.Size(30, 13)
        Me.lblLollipopSize.TabIndex = 42
        Me.lblLollipopSize.Text = "Size:"
        '
        'lblReorder
        '
        Me.lblReorder.AutoSize = True
        Me.lblReorder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblReorder.Location = New System.Drawing.Point(256, 323)
        Me.lblReorder.Name = "lblReorder"
        Me.lblReorder.Size = New System.Drawing.Size(48, 13)
        Me.lblReorder.TabIndex = 36
        Me.lblReorder.Text = "Reorder:"
        '
        'rdoTreeMap
        '
        Me.rdoTreeMap.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTreeMap.BackColor = System.Drawing.SystemColors.Control
        Me.rdoTreeMap.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTreeMap.FlatAppearance.BorderSize = 2
        Me.rdoTreeMap.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTreeMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTreeMap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTreeMap.Location = New System.Drawing.Point(205, 10)
        Me.rdoTreeMap.Name = "rdoTreeMap"
        Me.rdoTreeMap.Size = New System.Drawing.Size(91, 28)
        Me.rdoTreeMap.TabIndex = 3
        Me.rdoTreeMap.TabStop = True
        Me.rdoTreeMap.Tag = "Value"
        Me.rdoTreeMap.Text = "Treemap"
        Me.rdoTreeMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTreeMap.UseVisualStyleBackColor = False
        '
        'lblFill
        '
        Me.lblFill.AutoSize = True
        Me.lblFill.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFill.Location = New System.Drawing.Point(260, 94)
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Size = New System.Drawing.Size(22, 13)
        Me.lblFill.TabIndex = 40
        Me.lblFill.Text = "Fill:"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblArea.Location = New System.Drawing.Point(260, 55)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(32, 13)
        Me.lblArea.TabIndex = 10
        Me.lblArea.Text = "Area:"
        '
        'lblPlace
        '
        Me.lblPlace.AutoSize = True
        Me.lblPlace.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPlace.Location = New System.Drawing.Point(123, 368)
        Me.lblPlace.Name = "lblPlace"
        Me.lblPlace.Size = New System.Drawing.Size(37, 13)
        Me.lblPlace.TabIndex = 47
        Me.lblPlace.Text = "Place:"
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabel.Location = New System.Drawing.Point(211, 388)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(36, 13)
        Me.lblLabel.TabIndex = 52
        Me.lblLabel.Text = "Label:"
        '
        'rdoWordCloud
        '
        Me.rdoWordCloud.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoWordCloud.BackColor = System.Drawing.SystemColors.Control
        Me.rdoWordCloud.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWordCloud.FlatAppearance.BorderSize = 2
        Me.rdoWordCloud.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWordCloud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoWordCloud.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoWordCloud.Location = New System.Drawing.Point(294, 10)
        Me.rdoWordCloud.Name = "rdoWordCloud"
        Me.rdoWordCloud.Size = New System.Drawing.Size(91, 28)
        Me.rdoWordCloud.TabIndex = 4
        Me.rdoWordCloud.TabStop = True
        Me.rdoWordCloud.Tag = "Value"
        Me.rdoWordCloud.Text = "Wordcloud"
        Me.rdoWordCloud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoWordCloud.UseVisualStyleBackColor = False
        '
        'lblWordcloudLabel
        '
        Me.lblWordcloudLabel.AutoSize = True
        Me.lblWordcloudLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWordcloudLabel.Location = New System.Drawing.Point(260, 56)
        Me.lblWordcloudLabel.Name = "lblWordcloudLabel"
        Me.lblWordcloudLabel.Size = New System.Drawing.Size(36, 13)
        Me.lblWordcloudLabel.TabIndex = 9
        Me.lblWordcloudLabel.Text = "Label:"
        '
        'lblWordcloudSize
        '
        Me.lblWordcloudSize.AutoSize = True
        Me.lblWordcloudSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWordcloudSize.Location = New System.Drawing.Point(256, 95)
        Me.lblWordcloudSize.Name = "lblWordcloudSize"
        Me.lblWordcloudSize.Size = New System.Drawing.Size(30, 13)
        Me.lblWordcloudSize.TabIndex = 13
        Me.lblWordcloudSize.Text = "Size:"
        '
        'lblWordcloudColor
        '
        Me.lblWordcloudColor.AutoSize = True
        Me.lblWordcloudColor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWordcloudColor.Location = New System.Drawing.Point(256, 135)
        Me.lblWordcloudColor.Name = "lblWordcloudColor"
        Me.lblWordcloudColor.Size = New System.Drawing.Size(34, 13)
        Me.lblWordcloudColor.TabIndex = 17
        Me.lblWordcloudColor.Text = "Color:"
        '
        'lblWordcloudAngle
        '
        Me.lblWordcloudAngle.AutoSize = True
        Me.lblWordcloudAngle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWordcloudAngle.Location = New System.Drawing.Point(256, 175)
        Me.lblWordcloudAngle.Name = "lblWordcloudAngle"
        Me.lblWordcloudAngle.Size = New System.Drawing.Size(37, 13)
        Me.lblWordcloudAngle.TabIndex = 21
        Me.lblWordcloudAngle.Text = "Angle:"
        '
        'contextMenuStripOptions
        '
        Me.contextMenuStripOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemPlotOptions, Me.toolStripMenuItemBarchartOptions, Me.toolStripMenuItemTextOptions, Me.toolStripMenuItemLollipopOptions, Me.toolStripMenuItemTreemapOptions, Me.toolStripMenuItemTreemapTextOptionsOptions, Me.toolStripMenuItemWordcloudOptions})
        Me.contextMenuStripOptions.Name = "contextMenuStripOk"
        Me.contextMenuStripOptions.Size = New System.Drawing.Size(189, 158)
        '
        'toolStripMenuItemPlotOptions
        '
        Me.toolStripMenuItemPlotOptions.Name = "toolStripMenuItemPlotOptions"
        Me.toolStripMenuItemPlotOptions.Size = New System.Drawing.Size(188, 22)
        Me.toolStripMenuItemPlotOptions.Text = "Plot Options"
        '
        'toolStripMenuItemBarchartOptions
        '
        Me.toolStripMenuItemBarchartOptions.Name = "toolStripMenuItemBarchartOptions"
        Me.toolStripMenuItemBarchartOptions.Size = New System.Drawing.Size(188, 22)
        Me.toolStripMenuItemBarchartOptions.Text = "BarChart Options"
        '
        'toolStripMenuItemTextOptions
        '
        Me.toolStripMenuItemTextOptions.Name = "toolStripMenuItemTextOptions"
        Me.toolStripMenuItemTextOptions.Size = New System.Drawing.Size(188, 22)
        Me.toolStripMenuItemTextOptions.Text = "Text Options"
        '
        'toolStripMenuItemLollipopOptions
        '
        Me.toolStripMenuItemLollipopOptions.Name = "toolStripMenuItemLollipopOptions"
        Me.toolStripMenuItemLollipopOptions.Size = New System.Drawing.Size(188, 22)
        Me.toolStripMenuItemLollipopOptions.Text = "Lollipop Options"
        '
        'toolStripMenuItemTreemapOptions
        '
        Me.toolStripMenuItemTreemapOptions.Name = "toolStripMenuItemTreemapOptions"
        Me.toolStripMenuItemTreemapOptions.Size = New System.Drawing.Size(188, 22)
        Me.toolStripMenuItemTreemapOptions.Text = "Treemap Options"
        '
        'toolStripMenuItemTreemapTextOptionsOptions
        '
        Me.toolStripMenuItemTreemapTextOptionsOptions.Name = "toolStripMenuItemTreemapTextOptionsOptions"
        Me.toolStripMenuItemTreemapTextOptionsOptions.Size = New System.Drawing.Size(188, 22)
        Me.toolStripMenuItemTreemapTextOptionsOptions.Text = "Treemap Text Options"
        '
        'toolStripMenuItemWordcloudOptions
        '
        Me.toolStripMenuItemWordcloudOptions.Name = "toolStripMenuItemWordcloudOptions"
        Me.toolStripMenuItemWordcloudOptions.Size = New System.Drawing.Size(188, 22)
        Me.toolStripMenuItemWordcloudOptions.Text = "Wordcloud Options"
        '
        'cmdOptions
        '
        Me.cmdOptions.AutoSize = True
        Me.cmdOptions.ContextMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.Location = New System.Drawing.Point(10, 238)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(148, 25)
        Me.cmdOptions.SplitMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.TabIndex = 68
        Me.cmdOptions.Tag = "Plot Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrChkReorderValue
        '
        Me.ucrChkReorderValue.AutoSize = True
        Me.ucrChkReorderValue.Checked = False
        Me.ucrChkReorderValue.Location = New System.Drawing.Point(258, 236)
        Me.ucrChkReorderValue.Name = "ucrChkReorderValue"
        Me.ucrChkReorderValue.Size = New System.Drawing.Size(119, 23)
        Me.ucrChkReorderValue.TabIndex = 65
        '
        'ucrChkReorderFrequency
        '
        Me.ucrChkReorderFrequency.AutoSize = True
        Me.ucrChkReorderFrequency.Checked = False
        Me.ucrChkReorderFrequency.Location = New System.Drawing.Point(257, 189)
        Me.ucrChkReorderFrequency.Name = "ucrChkReorderFrequency"
        Me.ucrChkReorderFrequency.Size = New System.Drawing.Size(158, 23)
        Me.ucrChkReorderFrequency.TabIndex = 66
        '
        'ucrInputPlace
        '
        Me.ucrInputPlace.AddQuotesIfUnrecognised = True
        Me.ucrInputPlace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPlace.GetSetSelectedIndex = -1
        Me.ucrInputPlace.IsReadOnly = False
        Me.ucrInputPlace.Location = New System.Drawing.Point(166, 364)
        Me.ucrInputPlace.Name = "ucrInputPlace"
        Me.ucrInputPlace.Size = New System.Drawing.Size(88, 21)
        Me.ucrInputPlace.TabIndex = 53
        '
        'ucrInputLayout
        '
        Me.ucrInputLayout.AddQuotesIfUnrecognised = True
        Me.ucrInputLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLayout.GetSetSelectedIndex = -1
        Me.ucrInputLayout.IsReadOnly = False
        Me.ucrInputLayout.Location = New System.Drawing.Point(79, 339)
        Me.ucrInputLayout.Name = "ucrInputLayout"
        Me.ucrInputLayout.Size = New System.Drawing.Size(99, 21)
        Me.ucrInputLayout.TabIndex = 38
        '
        'ucrReceiverLabel
        '
        Me.ucrReceiverLabel.AutoSize = True
        Me.ucrReceiverLabel.frmParent = Me
        Me.ucrReceiverLabel.Location = New System.Drawing.Point(266, 383)
        Me.ucrReceiverLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLabel.Name = "ucrReceiverLabel"
        Me.ucrReceiverLabel.Selector = Nothing
        Me.ucrReceiverLabel.Size = New System.Drawing.Size(113, 21)
        Me.ucrReceiverLabel.strNcFilePath = ""
        Me.ucrReceiverLabel.TabIndex = 57
        Me.ucrReceiverLabel.ucrSelector = Nothing
        '
        'ucrInputLabelSize
        '
        Me.ucrInputLabelSize.AddQuotesIfUnrecognised = True
        Me.ucrInputLabelSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLabelSize.GetSetSelectedIndex = -1
        Me.ucrInputLabelSize.IsReadOnly = False
        Me.ucrInputLabelSize.Location = New System.Drawing.Point(330, 437)
        Me.ucrInputLabelSize.Name = "ucrInputLabelSize"
        Me.ucrInputLabelSize.Size = New System.Drawing.Size(57, 21)
        Me.ucrInputLabelSize.TabIndex = 58
        '
        'ucrNudLollipopSize
        '
        Me.ucrNudLollipopSize.AutoSize = True
        Me.ucrNudLollipopSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLollipopSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLollipopSize.Location = New System.Drawing.Point(170, 387)
        Me.ucrNudLollipopSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLollipopSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLollipopSize.Name = "ucrNudLollipopSize"
        Me.ucrNudLollipopSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLollipopSize.TabIndex = 43
        Me.ucrNudLollipopSize.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrNudMaxSize
        '
        Me.ucrNudMaxSize.AutoSize = True
        Me.ucrNudMaxSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxSize.Location = New System.Drawing.Point(104, 317)
        Me.ucrNudMaxSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxSize.Name = "ucrNudMaxSize"
        Me.ucrNudMaxSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxSize.TabIndex = 64
        Me.ucrNudMaxSize.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrChkLollipop
        '
        Me.ucrChkLollipop.AutoSize = True
        Me.ucrChkLollipop.Checked = False
        Me.ucrChkLollipop.Location = New System.Drawing.Point(10, 384)
        Me.ucrChkLollipop.Name = "ucrChkLollipop"
        Me.ucrChkLollipop.Size = New System.Drawing.Size(93, 23)
        Me.ucrChkLollipop.TabIndex = 41
        '
        'ucrInputLabelPosition
        '
        Me.ucrInputLabelPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLabelPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLabelPosition.GetSetSelectedIndex = -1
        Me.ucrInputLabelPosition.IsReadOnly = False
        Me.ucrInputLabelPosition.Location = New System.Drawing.Point(100, 436)
        Me.ucrInputLabelPosition.Name = "ucrInputLabelPosition"
        Me.ucrInputLabelPosition.Size = New System.Drawing.Size(57, 21)
        Me.ucrInputLabelPosition.TabIndex = 25
        '
        'ucrInputBarChartPositions
        '
        Me.ucrInputBarChartPositions.AddQuotesIfUnrecognised = True
        Me.ucrInputBarChartPositions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBarChartPositions.GetSetSelectedIndex = -1
        Me.ucrInputBarChartPositions.IsReadOnly = False
        Me.ucrInputBarChartPositions.Location = New System.Drawing.Point(257, 379)
        Me.ucrInputBarChartPositions.Name = "ucrInputBarChartPositions"
        Me.ucrInputBarChartPositions.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputBarChartPositions.TabIndex = 40
        '
        'ucrSaveBar
        '
        Me.ucrSaveBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveBar.Location = New System.Drawing.Point(10, 512)
        Me.ucrSaveBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveBar.Name = "ucrSaveBar"
        Me.ucrSaveBar.Size = New System.Drawing.Size(372, 24)
        Me.ucrSaveBar.TabIndex = 59
        '
        'ucrReceiverByFactor
        '
        Me.ucrReceiverByFactor.AutoSize = True
        Me.ucrReceiverByFactor.frmParent = Me
        Me.ucrReceiverByFactor.Location = New System.Drawing.Point(257, 301)
        Me.ucrReceiverByFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverByFactor.Name = "ucrReceiverByFactor"
        Me.ucrReceiverByFactor.Selector = Nothing
        Me.ucrReceiverByFactor.Size = New System.Drawing.Size(120, 21)
        Me.ucrReceiverByFactor.strNcFilePath = ""
        Me.ucrReceiverByFactor.TabIndex = 23
        Me.ucrReceiverByFactor.ucrSelector = Nothing
        '
        'ucrBarChartSelector
        '
        Me.ucrBarChartSelector.AutoSize = True
        Me.ucrBarChartSelector.bDropUnusedFilterLevels = False
        Me.ucrBarChartSelector.bShowHiddenColumns = False
        Me.ucrBarChartSelector.bUseCurrentFilter = True
        Me.ucrBarChartSelector.Location = New System.Drawing.Point(10, 52)
        Me.ucrBarChartSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrBarChartSelector.Name = "ucrBarChartSelector"
        Me.ucrBarChartSelector.Size = New System.Drawing.Size(213, 183)
        Me.ucrBarChartSelector.TabIndex = 5
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(7, 542)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 60
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(19, 6)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(372, 36)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'ucrReceiverArea
        '
        Me.ucrReceiverArea.AutoSize = True
        Me.ucrReceiverArea.frmParent = Me
        Me.ucrReceiverArea.Location = New System.Drawing.Point(257, 71)
        Me.ucrReceiverArea.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverArea.Name = "ucrReceiverArea"
        Me.ucrReceiverArea.Selector = Nothing
        Me.ucrReceiverArea.Size = New System.Drawing.Size(120, 21)
        Me.ucrReceiverArea.strNcFilePath = ""
        Me.ucrReceiverArea.TabIndex = 8
        Me.ucrReceiverArea.ucrSelector = Nothing
        '
        'ucrReceiverWordcloudLabel
        '
        Me.ucrReceiverWordcloudLabel.AutoSize = True
        Me.ucrReceiverWordcloudLabel.frmParent = Me
        Me.ucrReceiverWordcloudLabel.Location = New System.Drawing.Point(257, 71)
        Me.ucrReceiverWordcloudLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWordcloudLabel.Name = "ucrReceiverWordcloudLabel"
        Me.ucrReceiverWordcloudLabel.Selector = Nothing
        Me.ucrReceiverWordcloudLabel.Size = New System.Drawing.Size(120, 21)
        Me.ucrReceiverWordcloudLabel.strNcFilePath = ""
        Me.ucrReceiverWordcloudLabel.TabIndex = 7
        Me.ucrReceiverWordcloudLabel.ucrSelector = Nothing
        '
        'ucrInputReorderValue
        '
        Me.ucrInputReorderValue.AddQuotesIfUnrecognised = True
        Me.ucrInputReorderValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputReorderValue.GetSetSelectedIndex = -1
        Me.ucrInputReorderValue.IsReadOnly = False
        Me.ucrInputReorderValue.Location = New System.Drawing.Point(257, 261)
        Me.ucrInputReorderValue.Name = "ucrInputReorderValue"
        Me.ucrInputReorderValue.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputReorderValue.TabIndex = 22
        '
        'ucrReceiverWordcloudSize
        '
        Me.ucrReceiverWordcloudSize.AutoSize = True
        Me.ucrReceiverWordcloudSize.frmParent = Me
        Me.ucrReceiverWordcloudSize.Location = New System.Drawing.Point(257, 111)
        Me.ucrReceiverWordcloudSize.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWordcloudSize.Name = "ucrReceiverWordcloudSize"
        Me.ucrReceiverWordcloudSize.Selector = Nothing
        Me.ucrReceiverWordcloudSize.Size = New System.Drawing.Size(120, 21)
        Me.ucrReceiverWordcloudSize.strNcFilePath = ""
        Me.ucrReceiverWordcloudSize.TabIndex = 14
        Me.ucrReceiverWordcloudSize.ucrSelector = Nothing
        '
        'ucrReceiverFill
        '
        Me.ucrReceiverFill.AutoSize = True
        Me.ucrReceiverFill.frmParent = Me
        Me.ucrReceiverFill.Location = New System.Drawing.Point(257, 111)
        Me.ucrReceiverFill.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFill.Name = "ucrReceiverFill"
        Me.ucrReceiverFill.Selector = Nothing
        Me.ucrReceiverFill.Size = New System.Drawing.Size(120, 21)
        Me.ucrReceiverFill.strNcFilePath = ""
        Me.ucrReceiverFill.TabIndex = 15
        Me.ucrReceiverFill.ucrSelector = Nothing
        '
        'ucrReceiverWordcloudColor
        '
        Me.ucrReceiverWordcloudColor.AutoSize = True
        Me.ucrReceiverWordcloudColor.frmParent = Me
        Me.ucrReceiverWordcloudColor.Location = New System.Drawing.Point(257, 151)
        Me.ucrReceiverWordcloudColor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWordcloudColor.Name = "ucrReceiverWordcloudColor"
        Me.ucrReceiverWordcloudColor.Selector = Nothing
        Me.ucrReceiverWordcloudColor.Size = New System.Drawing.Size(120, 21)
        Me.ucrReceiverWordcloudColor.strNcFilePath = ""
        Me.ucrReceiverWordcloudColor.TabIndex = 16
        Me.ucrReceiverWordcloudColor.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.AutoSize = True
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(257, 212)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(120, 21)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 19
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrInputReorderX
        '
        Me.ucrInputReorderX.AddQuotesIfUnrecognised = True
        Me.ucrInputReorderX.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputReorderX.GetSetSelectedIndex = -1
        Me.ucrInputReorderX.IsReadOnly = False
        Me.ucrInputReorderX.Location = New System.Drawing.Point(257, 212)
        Me.ucrInputReorderX.Name = "ucrInputReorderX"
        Me.ucrInputReorderX.Size = New System.Drawing.Size(93, 21)
        Me.ucrInputReorderX.TabIndex = 12
        '
        'ucrInputAddReorder
        '
        Me.ucrInputAddReorder.AddQuotesIfUnrecognised = True
        Me.ucrInputAddReorder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputAddReorder.GetSetSelectedIndex = -1
        Me.ucrInputAddReorder.IsReadOnly = False
        Me.ucrInputAddReorder.Location = New System.Drawing.Point(257, 339)
        Me.ucrInputAddReorder.Name = "ucrInputAddReorder"
        Me.ucrInputAddReorder.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputAddReorder.TabIndex = 37
        '
        'ucrPnlPolar
        '
        Me.ucrPnlPolar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlPolar.Location = New System.Drawing.Point(106, 341)
        Me.ucrPnlPolar.Name = "ucrPnlPolar"
        Me.ucrPnlPolar.Size = New System.Drawing.Size(72, 45)
        Me.ucrPnlPolar.TabIndex = 33
        '
        'ucrInputLabelColour
        '
        Me.ucrInputLabelColour.AddQuotesIfUnrecognised = True
        Me.ucrInputLabelColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLabelColour.GetSetSelectedIndex = -1
        Me.ucrInputLabelColour.IsReadOnly = False
        Me.ucrInputLabelColour.Location = New System.Drawing.Point(220, 437)
        Me.ucrInputLabelColour.Name = "ucrInputLabelColour"
        Me.ucrInputLabelColour.Size = New System.Drawing.Size(57, 21)
        Me.ucrInputLabelColour.TabIndex = 54
        '
        'ucrChkStart
        '
        Me.ucrChkStart.AutoSize = True
        Me.ucrChkStart.Checked = False
        Me.ucrChkStart.Location = New System.Drawing.Point(10, 316)
        Me.ucrChkStart.Name = "ucrChkStart"
        Me.ucrChkStart.Size = New System.Drawing.Size(83, 23)
        Me.ucrChkStart.TabIndex = 28
        '
        'ucrInputStart
        '
        Me.ucrInputStart.AddQuotesIfUnrecognised = True
        Me.ucrInputStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStart.GetSetSelectedIndex = -1
        Me.ucrInputStart.IsReadOnly = False
        Me.ucrInputStart.Location = New System.Drawing.Point(104, 315)
        Me.ucrInputStart.Name = "ucrInputStart"
        Me.ucrInputStart.Size = New System.Drawing.Size(93, 21)
        Me.ucrInputStart.TabIndex = 30
        '
        'ucrChkLayout
        '
        Me.ucrChkLayout.AutoSize = True
        Me.ucrChkLayout.Checked = False
        Me.ucrChkLayout.Location = New System.Drawing.Point(10, 341)
        Me.ucrChkLayout.Name = "ucrChkLayout"
        Me.ucrChkLayout.Size = New System.Drawing.Size(108, 24)
        Me.ucrChkLayout.TabIndex = 35
        '
        'ucrChkFlipCoordinates
        '
        Me.ucrChkFlipCoordinates.AutoSize = True
        Me.ucrChkFlipCoordinates.Checked = False
        Me.ucrChkFlipCoordinates.Location = New System.Drawing.Point(10, 317)
        Me.ucrChkFlipCoordinates.Name = "ucrChkFlipCoordinates"
        Me.ucrChkFlipCoordinates.Size = New System.Drawing.Size(166, 23)
        Me.ucrChkFlipCoordinates.TabIndex = 29
        '
        'ucrChkPolarCoordinates
        '
        Me.ucrChkPolarCoordinates.AutoSize = True
        Me.ucrChkPolarCoordinates.Checked = False
        Me.ucrChkPolarCoordinates.Location = New System.Drawing.Point(10, 341)
        Me.ucrChkPolarCoordinates.Name = "ucrChkPolarCoordinates"
        Me.ucrChkPolarCoordinates.Size = New System.Drawing.Size(83, 23)
        Me.ucrChkPolarCoordinates.TabIndex = 31
        '
        'ucrVariablesAsFactorForBarChart
        '
        Me.ucrVariablesAsFactorForBarChart.AutoSize = True
        Me.ucrVariablesAsFactorForBarChart.frmParent = Me
        Me.ucrVariablesAsFactorForBarChart.Location = New System.Drawing.Point(257, 52)
        Me.ucrVariablesAsFactorForBarChart.Name = "ucrVariablesAsFactorForBarChart"
        Me.ucrVariablesAsFactorForBarChart.Selector = Nothing
        Me.ucrVariablesAsFactorForBarChart.Size = New System.Drawing.Size(125, 141)
        Me.ucrVariablesAsFactorForBarChart.strNcFilePath = ""
        Me.ucrVariablesAsFactorForBarChart.TabIndex = 6
        Me.ucrVariablesAsFactorForBarChart.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForBarChart.ucrVariableSelector = Nothing
        '
        'ucrReceiverWordcloudAngle
        '
        Me.ucrReceiverWordcloudAngle.AutoSize = True
        Me.ucrReceiverWordcloudAngle.frmParent = Me
        Me.ucrReceiverWordcloudAngle.Location = New System.Drawing.Point(257, 191)
        Me.ucrReceiverWordcloudAngle.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWordcloudAngle.Name = "ucrReceiverWordcloudAngle"
        Me.ucrReceiverWordcloudAngle.Selector = Nothing
        Me.ucrReceiverWordcloudAngle.Size = New System.Drawing.Size(120, 21)
        Me.ucrReceiverWordcloudAngle.strNcFilePath = ""
        Me.ucrReceiverWordcloudAngle.TabIndex = 20
        Me.ucrReceiverWordcloudAngle.ucrSelector = Nothing
        '
        'ucrChkAddLabelsText
        '
        Me.ucrChkAddLabelsText.AutoSize = True
        Me.ucrChkAddLabelsText.Checked = False
        Me.ucrChkAddLabelsText.Location = New System.Drawing.Point(10, 405)
        Me.ucrChkAddLabelsText.Name = "ucrChkAddLabelsText"
        Me.ucrChkAddLabelsText.Size = New System.Drawing.Size(135, 23)
        Me.ucrChkAddLabelsText.TabIndex = 46
        '
        'ucrChkAddLabelsTreemap
        '
        Me.ucrChkAddLabelsTreemap.AutoSize = True
        Me.ucrChkAddLabelsTreemap.Checked = False
        Me.ucrChkAddLabelsTreemap.Location = New System.Drawing.Point(10, 365)
        Me.ucrChkAddLabelsTreemap.Name = "ucrChkAddLabelsTreemap"
        Me.ucrChkAddLabelsTreemap.Size = New System.Drawing.Size(129, 24)
        Me.ucrChkAddLabelsTreemap.TabIndex = 61
        '
        'ucrChkBacktoback
        '
        Me.ucrChkBacktoback.AutoSize = True
        Me.ucrChkBacktoback.Checked = False
        Me.ucrChkBacktoback.Location = New System.Drawing.Point(10, 293)
        Me.ucrChkBacktoback.Name = "ucrChkBacktoback"
        Me.ucrChkBacktoback.Size = New System.Drawing.Size(93, 23)
        Me.ucrChkBacktoback.TabIndex = 27
        '
        'ucrChkIncreaseSize
        '
        Me.ucrChkIncreaseSize.AutoSize = True
        Me.ucrChkIncreaseSize.Checked = False
        Me.ucrChkIncreaseSize.Location = New System.Drawing.Point(10, 317)
        Me.ucrChkIncreaseSize.Name = "ucrChkIncreaseSize"
        Me.ucrChkIncreaseSize.Size = New System.Drawing.Size(88, 23)
        Me.ucrChkIncreaseSize.TabIndex = 63
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Location = New System.Drawing.Point(327, 478)
        Me.ucrInputStation.Name = "ucrInputStation"
        Me.ucrInputStation.Size = New System.Drawing.Size(86, 21)
        Me.ucrInputStation.TabIndex = 71
        '
        'ucr1stFactorReceiver
        '
        Me.ucr1stFactorReceiver.AutoSize = True
        Me.ucr1stFactorReceiver.frmParent = Me
        Me.ucr1stFactorReceiver.Location = New System.Drawing.Point(214, 479)
        Me.ucr1stFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.Size = New System.Drawing.Size(109, 26)
        Me.ucr1stFactorReceiver.strNcFilePath = ""
        Me.ucr1stFactorReceiver.TabIndex = 70
        Me.ucr1stFactorReceiver.ucrSelector = Nothing
        '
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetBy.Location = New System.Drawing.Point(214, 464)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(52, 13)
        Me.lblFacetBy.TabIndex = 69
        Me.lblFacetBy.Tag = ""
        Me.lblFacetBy.Text = "Facet By:"
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(97, 478)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(112, 21)
        Me.ucrInputLegendPosition.TabIndex = 73
        '
        'ucrChkLegend
        '
        Me.ucrChkLegend.AutoSize = True
        Me.ucrChkLegend.Checked = False
        Me.ucrChkLegend.Location = New System.Drawing.Point(10, 479)
        Me.ucrChkLegend.Name = "ucrChkLegend"
        Me.ucrChkLegend.Size = New System.Drawing.Size(98, 24)
        Me.ucrChkLegend.TabIndex = 72
        '
        'dlgBarAndPieChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(415, 596)
        Me.Controls.Add(Me.ucrInputStation)
        Me.Controls.Add(Me.ucr1stFactorReceiver)
        Me.Controls.Add(Me.lblFacetBy)
        Me.Controls.Add(Me.ucrInputLegendPosition)
        Me.Controls.Add(Me.ucrChkLegend)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrChkReorderValue)
        Me.Controls.Add(Me.ucrChkReorderFrequency)
        Me.Controls.Add(Me.ucrInputPlace)
        Me.Controls.Add(Me.lblPlace)
        Me.Controls.Add(Me.ucrInputLayout)
        Me.Controls.Add(Me.ucrReceiverLabel)
        Me.Controls.Add(Me.ucrInputLabelSize)
        Me.Controls.Add(Me.lblLabelColour)
        Me.Controls.Add(Me.ucrNudLollipopSize)
        Me.Controls.Add(Me.ucrNudMaxSize)
        Me.Controls.Add(Me.rdoWordCloud)
        Me.Controls.Add(Me.lblLabel)
        Me.Controls.Add(Me.rdoTreeMap)
        Me.Controls.Add(Me.lblLollipopSize)
        Me.Controls.Add(Me.ucrChkLollipop)
        Me.Controls.Add(Me.lblLabelSize)
        Me.Controls.Add(Me.ucrInputLabelPosition)
        Me.Controls.Add(Me.rdoDonut)
        Me.Controls.Add(Me.rdoPie)
        Me.Controls.Add(Me.rdoFrequency)
        Me.Controls.Add(Me.ucrInputBarChartPositions)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.ucrSaveBar)
        Me.Controls.Add(Me.rdoValue)
        Me.Controls.Add(Me.lblByFactor)
        Me.Controls.Add(Me.ucrReceiverByFactor)
        Me.Controls.Add(Me.ucrBarChartSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrReceiverArea)
        Me.Controls.Add(Me.ucrReceiverWordcloudLabel)
        Me.Controls.Add(Me.lblWordcloudSize)
        Me.Controls.Add(Me.lblFill)
        Me.Controls.Add(Me.lblWordcloudColor)
        Me.Controls.Add(Me.ucrInputReorderValue)
        Me.Controls.Add(Me.lblReorder)
        Me.Controls.Add(Me.ucrReceiverWordcloudSize)
        Me.Controls.Add(Me.ucrReceiverFill)
        Me.Controls.Add(Me.ucrReceiverWordcloudColor)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.lblWordcloudAngle)
        Me.Controls.Add(Me.ucrInputReorderX)
        Me.Controls.Add(Me.ucrInputAddReorder)
        Me.Controls.Add(Me.lblLabelPosition)
        Me.Controls.Add(Me.ucrPnlPolar)
        Me.Controls.Add(Me.ucrInputLabelColour)
        Me.Controls.Add(Me.ucrChkStart)
        Me.Controls.Add(Me.ucrInputStart)
        Me.Controls.Add(Me.ucrChkLayout)
        Me.Controls.Add(Me.ucrChkFlipCoordinates)
        Me.Controls.Add(Me.ucrChkPolarCoordinates)
        Me.Controls.Add(Me.lblWordcloudLabel)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.ucrVariablesAsFactorForBarChart)
        Me.Controls.Add(Me.lblXvariable)
        Me.Controls.Add(Me.ucrReceiverWordcloudAngle)
        Me.Controls.Add(Me.ucrChkAddLabelsText)
        Me.Controls.Add(Me.ucrChkAddLabelsTreemap)
        Me.Controls.Add(Me.ucrChkBacktoback)
        Me.Controls.Add(Me.ucrChkIncreaseSize)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgBarAndPieChart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Bar_Chart"
        Me.Text = "Bar  Chart"
        Me.contextMenuStripOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrBarChartSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverByFactor As ucrReceiverSingle
    Friend WithEvents lblByFactor As Label
    Friend WithEvents ucrSaveBar As ucrSave
    Friend WithEvents ucrChkFlipCoordinates As ucrCheck
    Friend WithEvents rdoValue As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents lblPosition As Label
    Friend WithEvents ucrInputBarChartPositions As ucrInputComboBox
    Friend WithEvents rdoFrequency As RadioButton
    Friend WithEvents ucrVariablesAsFactorForBarChart As ucrVariablesAsFactor
    Friend WithEvents lblXvariable As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents ucrChkBacktoback As ucrCheck
    Friend WithEvents ucrChkPolarCoordinates As ucrCheck
    Friend WithEvents ucrPnlPolar As UcrPanel
    Friend WithEvents rdoDonut As RadioButton
    Friend WithEvents rdoPie As RadioButton
    Friend WithEvents ucrChkAddLabelsText As ucrCheck
    Friend WithEvents lblLabelColour As Label
    Friend WithEvents lblLabelPosition As Label
    Friend WithEvents ucrInputLabelPosition As ucrInputComboBox
    Friend WithEvents ucrInputLabelColour As ucrInputComboBox
    Friend WithEvents lblLabelSize As Label
    Friend WithEvents ucrInputLabelSize As ucrInputComboBox
    Friend WithEvents ucrNudLollipopSize As ucrNud
    Friend WithEvents lblLollipopSize As Label
    Friend WithEvents ucrChkLollipop As ucrCheck
    Friend WithEvents ucrInputAddReorder As ucrInputComboBox
    Friend WithEvents lblReorder As Label
    Friend WithEvents ucrInputReorderX As ucrInputComboBox
    Friend WithEvents ucrInputReorderValue As ucrInputComboBox
    Friend WithEvents rdoTreeMap As RadioButton
    Friend WithEvents lblArea As Label
    Friend WithEvents lblFill As Label
    Friend WithEvents ucrReceiverFill As ucrReceiverSingle
    Friend WithEvents ucrReceiverLabel As ucrReceiverSingle
    Friend WithEvents ucrReceiverArea As ucrReceiverSingle
    Friend WithEvents ttArea As ToolTip
    Friend WithEvents ttFill As ToolTip
    Friend WithEvents ucrChkLayout As ucrCheck
    Friend WithEvents ucrChkStart As ucrCheck
    Friend WithEvents ucrInputStart As ucrInputComboBox
    Friend WithEvents ucrInputLayout As ucrInputComboBox
    Friend WithEvents ucrInputPlace As ucrInputComboBox
    Friend WithEvents lblPlace As Label
    Friend WithEvents lblLabel As Label
    Friend WithEvents rdoWordCloud As RadioButton
    Friend WithEvents lblWordcloudAngle As Label
    Friend WithEvents lblWordcloudColor As Label
    Friend WithEvents lblWordcloudSize As Label
    Friend WithEvents lblWordcloudLabel As Label
    Friend WithEvents ucrReceiverWordcloudLabel As ucrReceiverSingle
    Friend WithEvents ucrReceiverWordcloudSize As ucrReceiverSingle
    Friend WithEvents ucrReceiverWordcloudColor As ucrReceiverSingle
    Friend WithEvents ucrReceiverWordcloudAngle As ucrReceiverSingle
    Friend WithEvents ucrChkAddLabelsTreemap As ucrCheck
    Friend WithEvents ucrChkIncreaseSize As ucrCheck
    Friend WithEvents ucrNudMaxSize As ucrNud
    Friend WithEvents ucrChkReorderValue As ucrCheck
    Friend WithEvents ucrChkReorderFrequency As ucrCheck
    Friend WithEvents contextMenuStripOptions As ContextMenuStrip
    Friend WithEvents toolStripMenuItemPlotOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemBarchartOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemTextOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemTreemapOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemWordcloudOptions As ToolStripMenuItem
    Friend WithEvents cmdOptions As ucrSplitButton
    Friend WithEvents toolStripMenuItemLollipopOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemTreemapTextOptionsOptions As ToolStripMenuItem
    Friend WithEvents ucrInputStation As ucrInputComboBox
    Friend WithEvents ucr1stFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblFacetBy As Label
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents ucrChkLegend As ucrCheck
End Class