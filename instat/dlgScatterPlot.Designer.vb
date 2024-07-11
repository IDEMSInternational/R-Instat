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
Partial Class dlgScatterPlot
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
        Me.lblFactorOptional = New System.Windows.Forms.Label()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblSides = New System.Windows.Forms.Label()
        Me.contextMenuStripOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuItemPlotOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemPointOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemRugOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemSmoothOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemTextrepelOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemJitterOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemCountOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpGeom = New System.Windows.Forms.GroupBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblLegend = New System.Windows.Forms.Label()
        Me.lblPointsize = New System.Windows.Forms.Label()
        Me.lblShape = New System.Windows.Forms.Label()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.rdoPoint = New System.Windows.Forms.RadioButton()
        Me.lblHeith = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.rdoJitter = New System.Windows.Forms.RadioButton()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucr1stFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrChkLegend = New instat.ucrCheck()
        Me.ucrInputPosition = New instat.ucrInputComboBox()
        Me.ucrInputLegend = New instat.ucrInputComboBox()
        Me.ucrInputShape = New instat.ucrInputComboBox()
        Me.ucrNudPointsize = New instat.ucrNud()
        Me.ucrNudHeigth = New instat.ucrNud()
        Me.ucrNudWidth = New instat.ucrNud()
        Me.ucrPnlGeoms = New instat.UcrPanel()
        Me.cmdOptions = New instat.ucrSplitButton()
        Me.ucrInputSides = New instat.ucrInputComboBox()
        Me.ucrNudSize = New instat.ucrNud()
        Me.ucrChkAddRugPlot = New instat.ucrCheck()
        Me.ucrReceiverLabel = New instat.ucrReceiverSingle()
        Me.ucrChkWithSE = New instat.ucrCheck()
        Me.ucrChkLineofBestFit = New instat.ucrCheck()
        Me.ucrSaveScatterPlot = New instat.ucrSave()
        Me.ucrSelectorForScatter = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrVariablesAsFactorForScatter = New instat.ucrVariablesAsFactor()
        Me.ucrFactorOptionalReceiver = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkAddSidePlot = New instat.ucrCheck()
        Me.grpAdd = New System.Windows.Forms.GroupBox()
        Me.contextMenuStripOptions.SuspendLayout()
        Me.grpGeom.SuspendLayout()
        Me.grpAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFactorOptional
        '
        Me.lblFactorOptional.AutoSize = True
        Me.lblFactorOptional.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorOptional.Location = New System.Drawing.Point(347, 224)
        Me.lblFactorOptional.Name = "lblFactorOptional"
        Me.lblFactorOptional.Size = New System.Drawing.Size(111, 13)
        Me.lblFactorOptional.TabIndex = 4
        Me.lblFactorOptional.Tag = "By_Variable_Optional:"
        Me.lblFactorOptional.Text = "By Variable (Optional):"
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXVariable.Location = New System.Drawing.Point(349, 175)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(58, 13)
        Me.lblXVariable.TabIndex = 2
        Me.lblXVariable.Tag = "X_Variable:"
        Me.lblXVariable.Text = "X Variable:"
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVariable.Location = New System.Drawing.Point(347, 273)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(125, 13)
        Me.lblVariable.TabIndex = 6
        Me.lblVariable.Text = "Label Variable (Optional):"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(120, 43)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(30, 13)
        Me.lblSize.TabIndex = 12
        Me.lblSize.Text = "Size:"
        '
        'lblSides
        '
        Me.lblSides.AutoSize = True
        Me.lblSides.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSides.Location = New System.Drawing.Point(199, 43)
        Me.lblSides.Name = "lblSides"
        Me.lblSides.Size = New System.Drawing.Size(36, 13)
        Me.lblSides.TabIndex = 14
        Me.lblSides.Text = "Sides:"
        '
        'contextMenuStripOptions
        '
        Me.contextMenuStripOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemPlotOptions, Me.toolStripMenuItemPointOptions, Me.toolStripMenuItemRugOptions, Me.toolStripMenuItemSmoothOptions, Me.toolStripMenuItemTextrepelOptions, Me.toolStripMenuItemJitterOptions, Me.toolStripMenuItemCountOptions})
        Me.contextMenuStripOptions.Name = "contextMenuStripOk"
        Me.contextMenuStripOptions.Size = New System.Drawing.Size(172, 158)
        '
        'toolStripMenuItemPlotOptions
        '
        Me.toolStripMenuItemPlotOptions.Name = "toolStripMenuItemPlotOptions"
        Me.toolStripMenuItemPlotOptions.Size = New System.Drawing.Size(171, 22)
        Me.toolStripMenuItemPlotOptions.Text = "Plot Options"
        '
        'toolStripMenuItemPointOptions
        '
        Me.toolStripMenuItemPointOptions.Name = "toolStripMenuItemPointOptions"
        Me.toolStripMenuItemPointOptions.Size = New System.Drawing.Size(171, 22)
        Me.toolStripMenuItemPointOptions.Text = "Point Options"
        '
        'toolStripMenuItemRugOptions
        '
        Me.toolStripMenuItemRugOptions.Name = "toolStripMenuItemRugOptions"
        Me.toolStripMenuItemRugOptions.Size = New System.Drawing.Size(171, 22)
        Me.toolStripMenuItemRugOptions.Text = "Rug Options"
        '
        'toolStripMenuItemSmoothOptions
        '
        Me.toolStripMenuItemSmoothOptions.Name = "toolStripMenuItemSmoothOptions"
        Me.toolStripMenuItemSmoothOptions.Size = New System.Drawing.Size(171, 22)
        Me.toolStripMenuItemSmoothOptions.Text = "Smooth Options"
        '
        'toolStripMenuItemTextrepelOptions
        '
        Me.toolStripMenuItemTextrepelOptions.Name = "toolStripMenuItemTextrepelOptions"
        Me.toolStripMenuItemTextrepelOptions.Size = New System.Drawing.Size(171, 22)
        Me.toolStripMenuItemTextrepelOptions.Text = "Text_repel Options"
        '
        'toolStripMenuItemJitterOptions
        '
        Me.toolStripMenuItemJitterOptions.Name = "toolStripMenuItemJitterOptions"
        Me.toolStripMenuItemJitterOptions.Size = New System.Drawing.Size(171, 22)
        Me.toolStripMenuItemJitterOptions.Text = "Jitter Options"
        '
        'toolStripMenuItemCountOptions
        '
        Me.toolStripMenuItemCountOptions.Name = "toolStripMenuItemCountOptions"
        Me.toolStripMenuItemCountOptions.Size = New System.Drawing.Size(171, 22)
        Me.toolStripMenuItemCountOptions.Text = "Count Options"
        '
        'grpGeom
        '
        Me.grpGeom.Controls.Add(Me.ucrInputPosition)
        Me.grpGeom.Controls.Add(Me.lblPosition)
        Me.grpGeom.Controls.Add(Me.ucrInputLegend)
        Me.grpGeom.Controls.Add(Me.lblLegend)
        Me.grpGeom.Controls.Add(Me.ucrInputShape)
        Me.grpGeom.Controls.Add(Me.lblPointsize)
        Me.grpGeom.Controls.Add(Me.ucrNudPointsize)
        Me.grpGeom.Controls.Add(Me.lblShape)
        Me.grpGeom.Controls.Add(Me.rdoCount)
        Me.grpGeom.Controls.Add(Me.rdoPoint)
        Me.grpGeom.Controls.Add(Me.lblHeith)
        Me.grpGeom.Controls.Add(Me.ucrNudHeigth)
        Me.grpGeom.Controls.Add(Me.lblWidth)
        Me.grpGeom.Controls.Add(Me.ucrNudWidth)
        Me.grpGeom.Controls.Add(Me.rdoJitter)
        Me.grpGeom.Controls.Add(Me.ucrPnlGeoms)
        Me.grpGeom.Location = New System.Drawing.Point(9, 337)
        Me.grpGeom.Name = "grpGeom"
        Me.grpGeom.Size = New System.Drawing.Size(457, 109)
        Me.grpGeom.TabIndex = 23
        Me.grpGeom.TabStop = False
        Me.grpGeom.Text = "Geom"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(195, 50)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(47, 13)
        Me.lblPosition.TabIndex = 38
        Me.lblPosition.Text = "Position:"
        '
        'lblLegend
        '
        Me.lblLegend.AutoSize = True
        Me.lblLegend.Location = New System.Drawing.Point(59, 50)
        Me.lblLegend.Name = "lblLegend"
        Me.lblLegend.Size = New System.Drawing.Size(46, 13)
        Me.lblLegend.TabIndex = 36
        Me.lblLegend.Text = "Legend:"
        '
        'lblPointsize
        '
        Me.lblPointsize.AutoSize = True
        Me.lblPointsize.Location = New System.Drawing.Point(59, 21)
        Me.lblPointsize.Name = "lblPointsize"
        Me.lblPointsize.Size = New System.Drawing.Size(30, 13)
        Me.lblPointsize.TabIndex = 33
        Me.lblPointsize.Text = "Size:"
        '
        'lblShape
        '
        Me.lblShape.AutoSize = True
        Me.lblShape.Location = New System.Drawing.Point(186, 21)
        Me.lblShape.Name = "lblShape"
        Me.lblShape.Size = New System.Drawing.Size(41, 13)
        Me.lblShape.TabIndex = 31
        Me.lblShape.Text = "Shape:"
        '
        'rdoCount
        '
        Me.rdoCount.AutoSize = True
        Me.rdoCount.Location = New System.Drawing.Point(4, 46)
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.Size = New System.Drawing.Size(53, 17)
        Me.rdoCount.TabIndex = 30
        Me.rdoCount.TabStop = True
        Me.rdoCount.Text = "Count"
        Me.rdoCount.UseVisualStyleBackColor = True
        '
        'rdoPoint
        '
        Me.rdoPoint.AutoSize = True
        Me.rdoPoint.Location = New System.Drawing.Point(4, 20)
        Me.rdoPoint.Name = "rdoPoint"
        Me.rdoPoint.Size = New System.Drawing.Size(49, 17)
        Me.rdoPoint.TabIndex = 29
        Me.rdoPoint.TabStop = True
        Me.rdoPoint.Text = "Point"
        Me.rdoPoint.UseVisualStyleBackColor = True
        '
        'lblHeith
        '
        Me.lblHeith.AutoSize = True
        Me.lblHeith.Location = New System.Drawing.Point(180, 73)
        Me.lblHeith.Name = "lblHeith"
        Me.lblHeith.Size = New System.Drawing.Size(41, 13)
        Me.lblHeith.TabIndex = 27
        Me.lblHeith.Text = "Height:"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(60, 73)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(38, 13)
        Me.lblWidth.TabIndex = 25
        Me.lblWidth.Text = "Width:"
        '
        'rdoJitter
        '
        Me.rdoJitter.AutoSize = True
        Me.rdoJitter.Location = New System.Drawing.Point(4, 71)
        Me.rdoJitter.Name = "rdoJitter"
        Me.rdoJitter.Size = New System.Drawing.Size(47, 17)
        Me.rdoJitter.TabIndex = 24
        Me.rdoJitter.TabStop = True
        Me.rdoJitter.Text = "Jitter"
        Me.rdoJitter.UseVisualStyleBackColor = True
        '
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetBy.Location = New System.Drawing.Point(208, 458)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(52, 13)
        Me.lblFacetBy.TabIndex = 74
        Me.lblFacetBy.Tag = ""
        Me.lblFacetBy.Text = "Facet By:"
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Location = New System.Drawing.Point(335, 472)
        Me.ucrInputStation.Name = "ucrInputStation"
        Me.ucrInputStation.Size = New System.Drawing.Size(101, 21)
        Me.ucrInputStation.TabIndex = 76
        '
        'ucr1stFactorReceiver
        '
        Me.ucr1stFactorReceiver.AutoSize = True
        Me.ucr1stFactorReceiver.frmParent = Me
        Me.ucr1stFactorReceiver.Location = New System.Drawing.Point(208, 473)
        Me.ucr1stFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.Size = New System.Drawing.Size(121, 26)
        Me.ucr1stFactorReceiver.strNcFilePath = ""
        Me.ucr1stFactorReceiver.TabIndex = 75
        Me.ucr1stFactorReceiver.ucrSelector = Nothing
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(92, 472)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(112, 21)
        Me.ucrInputLegendPosition.TabIndex = 78
        '
        'ucrChkLegend
        '
        Me.ucrChkLegend.AutoSize = True
        Me.ucrChkLegend.Checked = False
        Me.ucrChkLegend.Location = New System.Drawing.Point(6, 473)
        Me.ucrChkLegend.Name = "ucrChkLegend"
        Me.ucrChkLegend.Size = New System.Drawing.Size(98, 24)
        Me.ucrChkLegend.TabIndex = 77
        '
        'ucrInputPosition
        '
        Me.ucrInputPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPosition.GetSetSelectedIndex = -1
        Me.ucrInputPosition.IsReadOnly = False
        Me.ucrInputPosition.Location = New System.Drawing.Point(240, 44)
        Me.ucrInputPosition.Name = "ucrInputPosition"
        Me.ucrInputPosition.Size = New System.Drawing.Size(83, 21)
        Me.ucrInputPosition.TabIndex = 39
        '
        'ucrInputLegend
        '
        Me.ucrInputLegend.AddQuotesIfUnrecognised = True
        Me.ucrInputLegend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegend.GetSetSelectedIndex = -1
        Me.ucrInputLegend.IsReadOnly = False
        Me.ucrInputLegend.Location = New System.Drawing.Point(111, 44)
        Me.ucrInputLegend.Name = "ucrInputLegend"
        Me.ucrInputLegend.Size = New System.Drawing.Size(61, 21)
        Me.ucrInputLegend.TabIndex = 37
        '
        'ucrInputShape
        '
        Me.ucrInputShape.AddQuotesIfUnrecognised = True
        Me.ucrInputShape.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputShape.GetSetSelectedIndex = -1
        Me.ucrInputShape.IsReadOnly = False
        Me.ucrInputShape.Location = New System.Drawing.Point(227, 16)
        Me.ucrInputShape.Name = "ucrInputShape"
        Me.ucrInputShape.Size = New System.Drawing.Size(96, 21)
        Me.ucrInputShape.TabIndex = 35
        '
        'ucrNudPointsize
        '
        Me.ucrNudPointsize.AutoSize = True
        Me.ucrNudPointsize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPointsize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPointsize.Location = New System.Drawing.Point(113, 17)
        Me.ucrNudPointsize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPointsize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPointsize.Name = "ucrNudPointsize"
        Me.ucrNudPointsize.Size = New System.Drawing.Size(45, 20)
        Me.ucrNudPointsize.TabIndex = 34
        Me.ucrNudPointsize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudHeigth
        '
        Me.ucrNudHeigth.AutoSize = True
        Me.ucrNudHeigth.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHeigth.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHeigth.Location = New System.Drawing.Point(227, 71)
        Me.ucrNudHeigth.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudHeigth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHeigth.Name = "ucrNudHeigth"
        Me.ucrNudHeigth.Size = New System.Drawing.Size(45, 20)
        Me.ucrNudHeigth.TabIndex = 28
        Me.ucrNudHeigth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudWidth
        '
        Me.ucrNudWidth.AutoSize = True
        Me.ucrNudWidth.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWidth.Location = New System.Drawing.Point(113, 71)
        Me.ucrNudWidth.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWidth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Name = "ucrNudWidth"
        Me.ucrNudWidth.Size = New System.Drawing.Size(45, 20)
        Me.ucrNudWidth.TabIndex = 26
        Me.ucrNudWidth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlGeoms
        '
        Me.ucrPnlGeoms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlGeoms.Location = New System.Drawing.Point(2, 14)
        Me.ucrPnlGeoms.Name = "ucrPnlGeoms"
        Me.ucrPnlGeoms.Size = New System.Drawing.Size(321, 89)
        Me.ucrPnlGeoms.TabIndex = 24
        '
        'cmdOptions
        '
        Me.cmdOptions.AutoSize = True
        Me.cmdOptions.ContextMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.Location = New System.Drawing.Point(10, 198)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(149, 23)
        Me.cmdOptions.SplitMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.TabIndex = 8
        Me.cmdOptions.Tag = "Plot Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrInputSides
        '
        Me.ucrInputSides.AddQuotesIfUnrecognised = True
        Me.ucrInputSides.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSides.GetSetSelectedIndex = -1
        Me.ucrInputSides.IsReadOnly = False
        Me.ucrInputSides.Location = New System.Drawing.Point(236, 40)
        Me.ucrInputSides.Name = "ucrInputSides"
        Me.ucrInputSides.Size = New System.Drawing.Size(94, 21)
        Me.ucrInputSides.TabIndex = 15
        '
        'ucrNudSize
        '
        Me.ucrNudSize.AutoSize = True
        Me.ucrNudSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSize.Location = New System.Drawing.Point(150, 41)
        Me.ucrNudSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSize.Name = "ucrNudSize"
        Me.ucrNudSize.Size = New System.Drawing.Size(45, 20)
        Me.ucrNudSize.TabIndex = 13
        Me.ucrNudSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkAddRugPlot
        '
        Me.ucrChkAddRugPlot.AutoSize = True
        Me.ucrChkAddRugPlot.Checked = False
        Me.ucrChkAddRugPlot.Location = New System.Drawing.Point(6, 38)
        Me.ucrChkAddRugPlot.Name = "ucrChkAddRugPlot"
        Me.ucrChkAddRugPlot.Size = New System.Drawing.Size(108, 23)
        Me.ucrChkAddRugPlot.TabIndex = 11
        '
        'ucrReceiverLabel
        '
        Me.ucrReceiverLabel.AutoSize = True
        Me.ucrReceiverLabel.frmParent = Me
        Me.ucrReceiverLabel.Location = New System.Drawing.Point(352, 286)
        Me.ucrReceiverLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLabel.Name = "ucrReceiverLabel"
        Me.ucrReceiverLabel.Selector = Nothing
        Me.ucrReceiverLabel.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverLabel.strNcFilePath = ""
        Me.ucrReceiverLabel.TabIndex = 7
        Me.ucrReceiverLabel.ucrSelector = Nothing
        '
        'ucrChkWithSE
        '
        Me.ucrChkWithSE.AutoSize = True
        Me.ucrChkWithSE.Checked = False
        Me.ucrChkWithSE.Location = New System.Drawing.Point(186, 17)
        Me.ucrChkWithSE.Name = "ucrChkWithSE"
        Me.ucrChkWithSE.Size = New System.Drawing.Size(133, 23)
        Me.ucrChkWithSE.TabIndex = 10
        '
        'ucrChkLineofBestFit
        '
        Me.ucrChkLineofBestFit.AutoSize = True
        Me.ucrChkLineofBestFit.Checked = False
        Me.ucrChkLineofBestFit.Location = New System.Drawing.Point(6, 16)
        Me.ucrChkLineofBestFit.Name = "ucrChkLineofBestFit"
        Me.ucrChkLineofBestFit.Size = New System.Drawing.Size(173, 24)
        Me.ucrChkLineofBestFit.TabIndex = 9
        '
        'ucrSaveScatterPlot
        '
        Me.ucrSaveScatterPlot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveScatterPlot.Location = New System.Drawing.Point(6, 505)
        Me.ucrSaveScatterPlot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveScatterPlot.Name = "ucrSaveScatterPlot"
        Me.ucrSaveScatterPlot.Size = New System.Drawing.Size(312, 24)
        Me.ucrSaveScatterPlot.TabIndex = 16
        '
        'ucrSelectorForScatter
        '
        Me.ucrSelectorForScatter.AutoSize = True
        Me.ucrSelectorForScatter.bDropUnusedFilterLevels = False
        Me.ucrSelectorForScatter.bShowHiddenColumns = False
        Me.ucrSelectorForScatter.bUseCurrentFilter = True
        Me.ucrSelectorForScatter.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForScatter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForScatter.Name = "ucrSelectorForScatter"
        Me.ucrSelectorForScatter.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForScatter.TabIndex = 0
        '
        'ucrVariablesAsFactorForScatter
        '
        Me.ucrVariablesAsFactorForScatter.AutoSize = True
        Me.ucrVariablesAsFactorForScatter.frmParent = Me
        Me.ucrVariablesAsFactorForScatter.Location = New System.Drawing.Point(347, 30)
        Me.ucrVariablesAsFactorForScatter.Name = "ucrVariablesAsFactorForScatter"
        Me.ucrVariablesAsFactorForScatter.Selector = Nothing
        Me.ucrVariablesAsFactorForScatter.Size = New System.Drawing.Size(125, 136)
        Me.ucrVariablesAsFactorForScatter.strNcFilePath = ""
        Me.ucrVariablesAsFactorForScatter.TabIndex = 1
        Me.ucrVariablesAsFactorForScatter.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForScatter.ucrVariableSelector = Nothing
        '
        'ucrFactorOptionalReceiver
        '
        Me.ucrFactorOptionalReceiver.AutoSize = True
        Me.ucrFactorOptionalReceiver.frmParent = Me
        Me.ucrFactorOptionalReceiver.Location = New System.Drawing.Point(352, 237)
        Me.ucrFactorOptionalReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorOptionalReceiver.Name = "ucrFactorOptionalReceiver"
        Me.ucrFactorOptionalReceiver.Selector = Nothing
        Me.ucrFactorOptionalReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrFactorOptionalReceiver.strNcFilePath = ""
        Me.ucrFactorOptionalReceiver.TabIndex = 5
        Me.ucrFactorOptionalReceiver.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.AutoSize = True
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(352, 188)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 3
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(28, 537)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 17
        '
        'ucrChkAddSidePlot
        '
        Me.ucrChkAddSidePlot.AutoSize = True
        Me.ucrChkAddSidePlot.Checked = False
        Me.ucrChkAddSidePlot.Location = New System.Drawing.Point(6, 67)
        Me.ucrChkAddSidePlot.Name = "ucrChkAddSidePlot"
        Me.ucrChkAddSidePlot.Size = New System.Drawing.Size(134, 23)
        Me.ucrChkAddSidePlot.TabIndex = 80
        '
        'grpAdd
        '
        Me.grpAdd.Controls.Add(Me.ucrChkLineofBestFit)
        Me.grpAdd.Controls.Add(Me.ucrChkAddSidePlot)
        Me.grpAdd.Controls.Add(Me.ucrChkAddRugPlot)
        Me.grpAdd.Controls.Add(Me.lblSides)
        Me.grpAdd.Controls.Add(Me.ucrNudSize)
        Me.grpAdd.Controls.Add(Me.lblSize)
        Me.grpAdd.Controls.Add(Me.ucrInputSides)
        Me.grpAdd.Controls.Add(Me.ucrChkWithSE)
        Me.grpAdd.Location = New System.Drawing.Point(9, 227)
        Me.grpAdd.Name = "grpAdd"
        Me.grpAdd.Size = New System.Drawing.Size(336, 95)
        Me.grpAdd.TabIndex = 81
        Me.grpAdd.TabStop = False
        Me.grpAdd.Text = "Add"
        '
        'dlgScatterPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(476, 595)
        Me.Controls.Add(Me.grpAdd)
        Me.Controls.Add(Me.ucrInputStation)
        Me.Controls.Add(Me.ucr1stFactorReceiver)
        Me.Controls.Add(Me.lblFacetBy)
        Me.Controls.Add(Me.ucrInputLegendPosition)
        Me.Controls.Add(Me.ucrChkLegend)
        Me.Controls.Add(Me.grpGeom)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.ucrReceiverLabel)
        Me.Controls.Add(Me.ucrSaveScatterPlot)
        Me.Controls.Add(Me.ucrSelectorForScatter)
        Me.Controls.Add(Me.ucrVariablesAsFactorForScatter)
        Me.Controls.Add(Me.ucrFactorOptionalReceiver)
        Me.Controls.Add(Me.lblFactorOptional)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgScatterPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scatter Plot"
        Me.contextMenuStripOptions.ResumeLayout(False)
        Me.grpGeom.ResumeLayout(False)
        Me.grpGeom.PerformLayout()
        Me.grpAdd.ResumeLayout(False)
        Me.grpAdd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrFactorOptionalReceiver As ucrReceiverSingle
    Friend WithEvents lblFactorOptional As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents lblXVariable As Label
    Friend WithEvents ucrVariablesAsFactorForScatter As ucrVariablesAsFactor
    Friend WithEvents ucrSelectorForScatter As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSaveScatterPlot As ucrSave
    Friend WithEvents ucrChkLineofBestFit As ucrCheck
    Friend WithEvents ucrChkWithSE As ucrCheck
    Friend WithEvents lblVariable As Label
    Friend WithEvents ucrReceiverLabel As ucrReceiverSingle
    Friend WithEvents ucrChkAddRugPlot As ucrCheck
    Friend WithEvents lblSize As Label
    Friend WithEvents ucrNudSize As ucrNud
    Friend WithEvents lblSides As Label
    Friend WithEvents ucrInputSides As ucrInputComboBox
    Friend WithEvents cmdOptions As ucrSplitButton
    Friend WithEvents contextMenuStripOptions As ContextMenuStrip
    Friend WithEvents toolStripMenuItemPlotOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemPointOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemRugOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemSmoothOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemTextrepelOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemJitterOptions As ToolStripMenuItem
    Friend WithEvents grpGeom As GroupBox
    Friend WithEvents lblHeith As Label
    Friend WithEvents ucrNudHeigth As ucrNud
    Friend WithEvents lblWidth As Label
    Friend WithEvents ucrNudWidth As ucrNud
    Friend WithEvents rdoJitter As RadioButton
    Friend WithEvents ucrPnlGeoms As UcrPanel
    Friend WithEvents rdoCount As RadioButton
    Friend WithEvents rdoPoint As RadioButton
    Friend WithEvents toolStripMenuItemCountOptions As ToolStripMenuItem
    Friend WithEvents lblPointsize As Label
    Friend WithEvents ucrNudPointsize As ucrNud
    Friend WithEvents lblShape As Label
    Friend WithEvents ucrInputShape As ucrInputComboBox
    Friend WithEvents ucrInputPosition As ucrInputComboBox
    Friend WithEvents lblPosition As Label
    Friend WithEvents ucrInputLegend As ucrInputComboBox
    Friend WithEvents lblLegend As Label
    Friend WithEvents ucrInputStation As ucrInputComboBox
    Friend WithEvents ucr1stFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblFacetBy As Label
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents ucrChkLegend As ucrCheck
    Friend WithEvents ucrChkAddSidePlot As ucrCheck
    Friend WithEvents grpAdd As GroupBox
End Class
