﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgClimograph
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblAbsolute = New System.Windows.Forms.Label()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.lblRain = New System.Windows.Forms.Label()
        Me.lblMaxtem = New System.Windows.Forms.Label()
        Me.lblMintem = New System.Windows.Forms.Label()
        Me.rdoClimograph = New System.Windows.Forms.RadioButton()
        Me.rdoWalterLieth = New System.Windows.Forms.RadioButton()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblFacet = New System.Windows.Forms.Label()
        Me.lblRainC = New System.Windows.Forms.Label()
        Me.lblElement1 = New System.Windows.Forms.Label()
        Me.lblElement2 = New System.Windows.Forms.Label()
        Me.lblMonthC = New System.Windows.Forms.Label()
        Me.rdoViridis = New System.Windows.Forms.RadioButton()
        Me.rdoPalette = New System.Windows.Forms.RadioButton()
        Me.rdoSinglecolour = New System.Windows.Forms.RadioButton()
        Me.contextMenuStripOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuItemPlotOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemBarchartOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemTmaxLineOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemTminLineOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.rdoClimateBars = New System.Windows.Forms.RadioButton()
        Me.lblRainBar = New System.Windows.Forms.Label()
        Me.lblElement1Bar = New System.Windows.Forms.Label()
        Me.lblElement2Bar = New System.Windows.Forms.Label()
        Me.lblMonthBar = New System.Windows.Forms.Label()
        Me.ucrReceiverRainBar = New instat.ucrReceiverSingle()
        Me.ucrReceiverElement1Bar = New instat.ucrReceiverSingle()
        Me.ucrReceiverElement2Bar = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonthBar = New instat.ucrReceiverSingle()
        Me.cmdOptions = New instat.ucrSplitButton()
        Me.ucrInputPalette = New instat.ucrInputComboBox()
        Me.ucrPnlColour = New instat.UcrPanel()
        Me.ucrInputColourPalette = New instat.ucrInputComboBox()
        Me.ucrChkColour = New instat.ucrCheck()
        Me.ucrChkTile = New instat.ucrCheck()
        Me.ucrChkText = New instat.ucrCheck()
        Me.ucrChkRibbon = New instat.ucrCheck()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrChkLegend = New instat.ucrCheck()
        Me.ucrInputFacet = New instat.ucrInputComboBox()
        Me.ucrReceiverFacet = New instat.ucrReceiverSingle()
        Me.ucrReceiverRainC = New instat.ucrReceiverSingle()
        Me.ucrReceiverElement1 = New instat.ucrReceiverSingle()
        Me.ucrReceiverElement2 = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonthC = New instat.ucrReceiverSingle()
        Me.ucrReceiverAbsolute = New instat.ucrReceiverSingle()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucr1stFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrReceiverRain = New instat.ucrReceiverSingle()
        Me.ucrReceiverMaxtem = New instat.ucrReceiverSingle()
        Me.ucrReceiverMintemp = New instat.ucrReceiverSingle()
        Me.ucrPnlClimograph = New instat.UcrPanel()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSave = New instat.ucrSave()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrSelectorClimograph = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputFacetBar = New instat.ucrInputComboBox()
        Me.ucrReceiverFacetBar = New instat.ucrReceiverSingle()
        Me.lblFacetBar = New System.Windows.Forms.Label()
        Me.contextMenuStripOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAbsolute
        '
        Me.lblAbsolute.AutoSize = True
        Me.lblAbsolute.Location = New System.Drawing.Point(267, 264)
        Me.lblAbsolute.Name = "lblAbsolute"
        Me.lblAbsolute.Size = New System.Drawing.Size(111, 13)
        Me.lblAbsolute.TabIndex = 76
        Me.lblAbsolute.Text = "Temperature min, min:"
        '
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetBy.Location = New System.Drawing.Point(267, 53)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(43, 13)
        Me.lblFacetBy.TabIndex = 63
        Me.lblFacetBy.Tag = ""
        Me.lblFacetBy.Text = "Station:"
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.Location = New System.Drawing.Point(267, 134)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(48, 13)
        Me.lblRain.TabIndex = 68
        Me.lblRain.Text = "RainFall:"
        '
        'lblMaxtem
        '
        Me.lblMaxtem.AutoSize = True
        Me.lblMaxtem.Location = New System.Drawing.Point(267, 177)
        Me.lblMaxtem.Name = "lblMaxtem"
        Me.lblMaxtem.Size = New System.Drawing.Size(93, 13)
        Me.lblMaxtem.TabIndex = 70
        Me.lblMaxtem.Text = "Temperature Max:"
        '
        'lblMintem
        '
        Me.lblMintem.AutoSize = True
        Me.lblMintem.Location = New System.Drawing.Point(267, 218)
        Me.lblMintem.Name = "lblMintem"
        Me.lblMintem.Size = New System.Drawing.Size(90, 13)
        Me.lblMintem.TabIndex = 72
        Me.lblMintem.Text = "Temperature Min:"
        '
        'rdoClimograph
        '
        Me.rdoClimograph.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoClimograph.BackColor = System.Drawing.SystemColors.Control
        Me.rdoClimograph.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoClimograph.FlatAppearance.BorderSize = 2
        Me.rdoClimograph.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoClimograph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoClimograph.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoClimograph.Location = New System.Drawing.Point(107, 10)
        Me.rdoClimograph.Name = "rdoClimograph"
        Me.rdoClimograph.Size = New System.Drawing.Size(79, 28)
        Me.rdoClimograph.TabIndex = 62
        Me.rdoClimograph.TabStop = True
        Me.rdoClimograph.Tag = ""
        Me.rdoClimograph.Text = "Climograph"
        Me.rdoClimograph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoClimograph.UseVisualStyleBackColor = False
        '
        'rdoWalterLieth
        '
        Me.rdoWalterLieth.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoWalterLieth.BackColor = System.Drawing.SystemColors.Control
        Me.rdoWalterLieth.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWalterLieth.FlatAppearance.BorderSize = 2
        Me.rdoWalterLieth.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWalterLieth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoWalterLieth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoWalterLieth.Location = New System.Drawing.Point(185, 10)
        Me.rdoWalterLieth.Name = "rdoWalterLieth"
        Me.rdoWalterLieth.Size = New System.Drawing.Size(80, 28)
        Me.rdoWalterLieth.TabIndex = 61
        Me.rdoWalterLieth.TabStop = True
        Me.rdoWalterLieth.Tag = ""
        Me.rdoWalterLieth.Text = "Walter Lieth"
        Me.rdoWalterLieth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoWalterLieth.UseVisualStyleBackColor = False
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(267, 93)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 66
        Me.lblMonth.Text = "Month:"
        '
        'lblFacet
        '
        Me.lblFacet.AutoSize = True
        Me.lblFacet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacet.Location = New System.Drawing.Point(267, 53)
        Me.lblFacet.Name = "lblFacet"
        Me.lblFacet.Size = New System.Drawing.Size(52, 13)
        Me.lblFacet.TabIndex = 84
        Me.lblFacet.Tag = ""
        Me.lblFacet.Text = "Facet By:"
        '
        'lblRainC
        '
        Me.lblRainC.AutoSize = True
        Me.lblRainC.Location = New System.Drawing.Point(267, 134)
        Me.lblRainC.Name = "lblRainC"
        Me.lblRainC.Size = New System.Drawing.Size(48, 13)
        Me.lblRainC.TabIndex = 89
        Me.lblRainC.Text = "RainFall:"
        '
        'lblElement1
        '
        Me.lblElement1.AutoSize = True
        Me.lblElement1.Location = New System.Drawing.Point(267, 177)
        Me.lblElement1.Name = "lblElement1"
        Me.lblElement1.Size = New System.Drawing.Size(90, 13)
        Me.lblElement1.TabIndex = 91
        Me.lblElement1.Text = "Element1 (TMax):"
        '
        'lblElement2
        '
        Me.lblElement2.AutoSize = True
        Me.lblElement2.Location = New System.Drawing.Point(267, 218)
        Me.lblElement2.Name = "lblElement2"
        Me.lblElement2.Size = New System.Drawing.Size(87, 13)
        Me.lblElement2.TabIndex = 93
        Me.lblElement2.Text = "Element2 (TMin):"
        '
        'lblMonthC
        '
        Me.lblMonthC.AutoSize = True
        Me.lblMonthC.Location = New System.Drawing.Point(267, 93)
        Me.lblMonthC.Name = "lblMonthC"
        Me.lblMonthC.Size = New System.Drawing.Size(40, 13)
        Me.lblMonthC.TabIndex = 87
        Me.lblMonthC.Text = "Month:"
        '
        'rdoViridis
        '
        Me.rdoViridis.AutoSize = True
        Me.rdoViridis.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoViridis.Location = New System.Drawing.Point(14, 382)
        Me.rdoViridis.Name = "rdoViridis"
        Me.rdoViridis.Size = New System.Drawing.Size(52, 17)
        Me.rdoViridis.TabIndex = 123
        Me.rdoViridis.TabStop = True
        Me.rdoViridis.Text = "Viridis"
        Me.rdoViridis.UseVisualStyleBackColor = True
        '
        'rdoPalette
        '
        Me.rdoPalette.AutoSize = True
        Me.rdoPalette.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPalette.Location = New System.Drawing.Point(14, 408)
        Me.rdoPalette.Name = "rdoPalette"
        Me.rdoPalette.Size = New System.Drawing.Size(58, 17)
        Me.rdoPalette.TabIndex = 121
        Me.rdoPalette.TabStop = True
        Me.rdoPalette.Text = "Palette"
        Me.rdoPalette.UseVisualStyleBackColor = True
        '
        'rdoSinglecolour
        '
        Me.rdoSinglecolour.AutoSize = True
        Me.rdoSinglecolour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSinglecolour.Location = New System.Drawing.Point(14, 433)
        Me.rdoSinglecolour.Name = "rdoSinglecolour"
        Me.rdoSinglecolour.Size = New System.Drawing.Size(87, 17)
        Me.rdoSinglecolour.TabIndex = 124
        Me.rdoSinglecolour.TabStop = True
        Me.rdoSinglecolour.Text = "Single Colour"
        Me.rdoSinglecolour.UseVisualStyleBackColor = True
        '
        'contextMenuStripOptions
        '
        Me.contextMenuStripOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemPlotOptions, Me.toolStripMenuItemBarchartOptions, Me.toolStripMenuItemTmaxLineOptions, Me.toolStripMenuItemTminLineOptions})
        Me.contextMenuStripOptions.Name = "contextMenuStripOk"
        Me.contextMenuStripOptions.Size = New System.Drawing.Size(181, 92)
        '
        'toolStripMenuItemPlotOptions
        '
        Me.toolStripMenuItemPlotOptions.Name = "toolStripMenuItemPlotOptions"
        Me.toolStripMenuItemPlotOptions.Size = New System.Drawing.Size(180, 22)
        Me.toolStripMenuItemPlotOptions.Text = "Plot Options"
        '
        'toolStripMenuItemBarchartOptions
        '
        Me.toolStripMenuItemBarchartOptions.Name = "toolStripMenuItemBarchartOptions"
        Me.toolStripMenuItemBarchartOptions.Size = New System.Drawing.Size(180, 22)
        Me.toolStripMenuItemBarchartOptions.Text = "BarChart Options"
        '
        'toolStripMenuItemTmaxLineOptions
        '
        Me.toolStripMenuItemTmaxLineOptions.Name = "toolStripMenuItemTmaxLineOptions"
        Me.toolStripMenuItemTmaxLineOptions.Size = New System.Drawing.Size(180, 22)
        Me.toolStripMenuItemTmaxLineOptions.Text = "Line Options (Tmax)"
        '
        'toolStripMenuItemTminLineOptions
        '
        Me.toolStripMenuItemTminLineOptions.Name = "toolStripMenuItemTminLineOptions"
        Me.toolStripMenuItemTminLineOptions.Size = New System.Drawing.Size(180, 22)
        Me.toolStripMenuItemTminLineOptions.Text = "Line Options (Tmin)"
        '
        'rdoClimateBars
        '
        Me.rdoClimateBars.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoClimateBars.BackColor = System.Drawing.SystemColors.Control
        Me.rdoClimateBars.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoClimateBars.FlatAppearance.BorderSize = 2
        Me.rdoClimateBars.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoClimateBars.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoClimateBars.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoClimateBars.Location = New System.Drawing.Point(263, 10)
        Me.rdoClimateBars.Name = "rdoClimateBars"
        Me.rdoClimateBars.Size = New System.Drawing.Size(91, 28)
        Me.rdoClimateBars.TabIndex = 128
        Me.rdoClimateBars.TabStop = True
        Me.rdoClimateBars.Tag = ""
        Me.rdoClimateBars.Text = "Climate Charts"
        Me.rdoClimateBars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoClimateBars.UseVisualStyleBackColor = False
        '
        'lblRainBar
        '
        Me.lblRainBar.AutoSize = True
        Me.lblRainBar.Location = New System.Drawing.Point(267, 134)
        Me.lblRainBar.Name = "lblRainBar"
        Me.lblRainBar.Size = New System.Drawing.Size(48, 13)
        Me.lblRainBar.TabIndex = 134
        Me.lblRainBar.Text = "RainFall:"
        '
        'lblElement1Bar
        '
        Me.lblElement1Bar.AutoSize = True
        Me.lblElement1Bar.Location = New System.Drawing.Point(267, 177)
        Me.lblElement1Bar.Name = "lblElement1Bar"
        Me.lblElement1Bar.Size = New System.Drawing.Size(90, 13)
        Me.lblElement1Bar.TabIndex = 136
        Me.lblElement1Bar.Text = "Element1 (TMax):"
        '
        'lblElement2Bar
        '
        Me.lblElement2Bar.AutoSize = True
        Me.lblElement2Bar.Location = New System.Drawing.Point(267, 218)
        Me.lblElement2Bar.Name = "lblElement2Bar"
        Me.lblElement2Bar.Size = New System.Drawing.Size(87, 13)
        Me.lblElement2Bar.TabIndex = 138
        Me.lblElement2Bar.Text = "Element2 (TMin):"
        '
        'lblMonthBar
        '
        Me.lblMonthBar.AutoSize = True
        Me.lblMonthBar.Location = New System.Drawing.Point(267, 93)
        Me.lblMonthBar.Name = "lblMonthBar"
        Me.lblMonthBar.Size = New System.Drawing.Size(40, 13)
        Me.lblMonthBar.TabIndex = 132
        Me.lblMonthBar.Text = "Month:"
        '
        'ucrReceiverRainBar
        '
        Me.ucrReceiverRainBar.AutoSize = True
        Me.ucrReceiverRainBar.frmParent = Me
        Me.ucrReceiverRainBar.Location = New System.Drawing.Point(267, 150)
        Me.ucrReceiverRainBar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainBar.Name = "ucrReceiverRainBar"
        Me.ucrReceiverRainBar.Selector = Nothing
        Me.ucrReceiverRainBar.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRainBar.strNcFilePath = ""
        Me.ucrReceiverRainBar.TabIndex = 135
        Me.ucrReceiverRainBar.ucrSelector = Nothing
        '
        'ucrReceiverElement1Bar
        '
        Me.ucrReceiverElement1Bar.AutoSize = True
        Me.ucrReceiverElement1Bar.frmParent = Me
        Me.ucrReceiverElement1Bar.Location = New System.Drawing.Point(267, 193)
        Me.ucrReceiverElement1Bar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement1Bar.Name = "ucrReceiverElement1Bar"
        Me.ucrReceiverElement1Bar.Selector = Nothing
        Me.ucrReceiverElement1Bar.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElement1Bar.strNcFilePath = ""
        Me.ucrReceiverElement1Bar.TabIndex = 137
        Me.ucrReceiverElement1Bar.ucrSelector = Nothing
        '
        'ucrReceiverElement2Bar
        '
        Me.ucrReceiverElement2Bar.AutoSize = True
        Me.ucrReceiverElement2Bar.frmParent = Me
        Me.ucrReceiverElement2Bar.Location = New System.Drawing.Point(267, 234)
        Me.ucrReceiverElement2Bar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement2Bar.Name = "ucrReceiverElement2Bar"
        Me.ucrReceiverElement2Bar.Selector = Nothing
        Me.ucrReceiverElement2Bar.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElement2Bar.strNcFilePath = ""
        Me.ucrReceiverElement2Bar.TabIndex = 139
        Me.ucrReceiverElement2Bar.ucrSelector = Nothing
        '
        'ucrReceiverMonthBar
        '
        Me.ucrReceiverMonthBar.AutoSize = True
        Me.ucrReceiverMonthBar.frmParent = Me
        Me.ucrReceiverMonthBar.Location = New System.Drawing.Point(267, 109)
        Me.ucrReceiverMonthBar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonthBar.Name = "ucrReceiverMonthBar"
        Me.ucrReceiverMonthBar.Selector = Nothing
        Me.ucrReceiverMonthBar.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonthBar.strNcFilePath = ""
        Me.ucrReceiverMonthBar.TabIndex = 133
        Me.ucrReceiverMonthBar.ucrSelector = Nothing
        '
        'cmdOptions
        '
        Me.cmdOptions.AutoSize = True
        Me.cmdOptions.ContextMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.Location = New System.Drawing.Point(11, 234)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(148, 25)
        Me.cmdOptions.SplitMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.TabIndex = 126
        Me.cmdOptions.Tag = "Plot Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrInputPalette
        '
        Me.ucrInputPalette.AddQuotesIfUnrecognised = True
        Me.ucrInputPalette.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPalette.GetSetSelectedIndex = -1
        Me.ucrInputPalette.IsReadOnly = False
        Me.ucrInputPalette.Location = New System.Drawing.Point(136, 407)
        Me.ucrInputPalette.Name = "ucrInputPalette"
        Me.ucrInputPalette.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputPalette.TabIndex = 122
        '
        'ucrPnlColour
        '
        Me.ucrPnlColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlColour.Location = New System.Drawing.Point(11, 379)
        Me.ucrPnlColour.Name = "ucrPnlColour"
        Me.ucrPnlColour.Size = New System.Drawing.Size(92, 77)
        Me.ucrPnlColour.TabIndex = 120
        '
        'ucrInputColourPalette
        '
        Me.ucrInputColourPalette.AddQuotesIfUnrecognised = True
        Me.ucrInputColourPalette.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputColourPalette.GetSetSelectedIndex = -1
        Me.ucrInputColourPalette.IsReadOnly = False
        Me.ucrInputColourPalette.Location = New System.Drawing.Point(136, 380)
        Me.ucrInputColourPalette.Name = "ucrInputColourPalette"
        Me.ucrInputColourPalette.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputColourPalette.TabIndex = 119
        '
        'ucrChkColour
        '
        Me.ucrChkColour.AutoSize = True
        Me.ucrChkColour.Checked = False
        Me.ucrChkColour.Location = New System.Drawing.Point(14, 358)
        Me.ucrChkColour.Name = "ucrChkColour"
        Me.ucrChkColour.Size = New System.Drawing.Size(198, 24)
        Me.ucrChkColour.TabIndex = 107
        '
        'ucrChkTile
        '
        Me.ucrChkTile.AutoSize = True
        Me.ucrChkTile.Checked = False
        Me.ucrChkTile.Location = New System.Drawing.Point(14, 297)
        Me.ucrChkTile.Name = "ucrChkTile"
        Me.ucrChkTile.Size = New System.Drawing.Size(147, 24)
        Me.ucrChkTile.TabIndex = 105
        '
        'ucrChkText
        '
        Me.ucrChkText.AutoSize = True
        Me.ucrChkText.Checked = False
        Me.ucrChkText.Location = New System.Drawing.Point(14, 327)
        Me.ucrChkText.Name = "ucrChkText"
        Me.ucrChkText.Size = New System.Drawing.Size(98, 24)
        Me.ucrChkText.TabIndex = 104
        '
        'ucrChkRibbon
        '
        Me.ucrChkRibbon.AutoSize = True
        Me.ucrChkRibbon.Checked = False
        Me.ucrChkRibbon.Location = New System.Drawing.Point(14, 269)
        Me.ucrChkRibbon.Name = "ucrChkRibbon"
        Me.ucrChkRibbon.Size = New System.Drawing.Size(147, 24)
        Me.ucrChkRibbon.TabIndex = 103
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(115, 461)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(112, 21)
        Me.ucrInputLegendPosition.TabIndex = 97
        '
        'ucrChkLegend
        '
        Me.ucrChkLegend.AutoSize = True
        Me.ucrChkLegend.Checked = False
        Me.ucrChkLegend.Location = New System.Drawing.Point(14, 462)
        Me.ucrChkLegend.Name = "ucrChkLegend"
        Me.ucrChkLegend.Size = New System.Drawing.Size(98, 24)
        Me.ucrChkLegend.TabIndex = 96
        '
        'ucrInputFacet
        '
        Me.ucrInputFacet.AddQuotesIfUnrecognised = True
        Me.ucrInputFacet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFacet.GetSetSelectedIndex = -1
        Me.ucrInputFacet.IsReadOnly = False
        Me.ucrInputFacet.Location = New System.Drawing.Point(379, 68)
        Me.ucrInputFacet.Name = "ucrInputFacet"
        Me.ucrInputFacet.Size = New System.Drawing.Size(86, 21)
        Me.ucrInputFacet.TabIndex = 86
        '
        'ucrReceiverFacet
        '
        Me.ucrReceiverFacet.AutoSize = True
        Me.ucrReceiverFacet.frmParent = Me
        Me.ucrReceiverFacet.Location = New System.Drawing.Point(267, 68)
        Me.ucrReceiverFacet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacet.Name = "ucrReceiverFacet"
        Me.ucrReceiverFacet.Selector = Nothing
        Me.ucrReceiverFacet.Size = New System.Drawing.Size(109, 26)
        Me.ucrReceiverFacet.strNcFilePath = ""
        Me.ucrReceiverFacet.TabIndex = 85
        Me.ucrReceiverFacet.ucrSelector = Nothing
        '
        'ucrReceiverRainC
        '
        Me.ucrReceiverRainC.AutoSize = True
        Me.ucrReceiverRainC.frmParent = Me
        Me.ucrReceiverRainC.Location = New System.Drawing.Point(267, 150)
        Me.ucrReceiverRainC.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainC.Name = "ucrReceiverRainC"
        Me.ucrReceiverRainC.Selector = Nothing
        Me.ucrReceiverRainC.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRainC.strNcFilePath = ""
        Me.ucrReceiverRainC.TabIndex = 90
        Me.ucrReceiverRainC.ucrSelector = Nothing
        '
        'ucrReceiverElement1
        '
        Me.ucrReceiverElement1.AutoSize = True
        Me.ucrReceiverElement1.frmParent = Me
        Me.ucrReceiverElement1.Location = New System.Drawing.Point(267, 193)
        Me.ucrReceiverElement1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement1.Name = "ucrReceiverElement1"
        Me.ucrReceiverElement1.Selector = Nothing
        Me.ucrReceiverElement1.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElement1.strNcFilePath = ""
        Me.ucrReceiverElement1.TabIndex = 92
        Me.ucrReceiverElement1.ucrSelector = Nothing
        '
        'ucrReceiverElement2
        '
        Me.ucrReceiverElement2.AutoSize = True
        Me.ucrReceiverElement2.frmParent = Me
        Me.ucrReceiverElement2.Location = New System.Drawing.Point(267, 234)
        Me.ucrReceiverElement2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement2.Name = "ucrReceiverElement2"
        Me.ucrReceiverElement2.Selector = Nothing
        Me.ucrReceiverElement2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElement2.strNcFilePath = ""
        Me.ucrReceiverElement2.TabIndex = 94
        Me.ucrReceiverElement2.ucrSelector = Nothing
        '
        'ucrReceiverMonthC
        '
        Me.ucrReceiverMonthC.AutoSize = True
        Me.ucrReceiverMonthC.frmParent = Me
        Me.ucrReceiverMonthC.Location = New System.Drawing.Point(267, 109)
        Me.ucrReceiverMonthC.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonthC.Name = "ucrReceiverMonthC"
        Me.ucrReceiverMonthC.Selector = Nothing
        Me.ucrReceiverMonthC.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonthC.strNcFilePath = ""
        Me.ucrReceiverMonthC.TabIndex = 88
        Me.ucrReceiverMonthC.ucrSelector = Nothing
        '
        'ucrReceiverAbsolute
        '
        Me.ucrReceiverAbsolute.AutoSize = True
        Me.ucrReceiverAbsolute.frmParent = Me
        Me.ucrReceiverAbsolute.Location = New System.Drawing.Point(267, 280)
        Me.ucrReceiverAbsolute.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAbsolute.Name = "ucrReceiverAbsolute"
        Me.ucrReceiverAbsolute.Selector = Nothing
        Me.ucrReceiverAbsolute.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverAbsolute.strNcFilePath = ""
        Me.ucrReceiverAbsolute.TabIndex = 77
        Me.ucrReceiverAbsolute.ucrSelector = Nothing
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Location = New System.Drawing.Point(379, 68)
        Me.ucrInputStation.Name = "ucrInputStation"
        Me.ucrInputStation.Size = New System.Drawing.Size(86, 21)
        Me.ucrInputStation.TabIndex = 65
        '
        'ucr1stFactorReceiver
        '
        Me.ucr1stFactorReceiver.AutoSize = True
        Me.ucr1stFactorReceiver.frmParent = Me
        Me.ucr1stFactorReceiver.Location = New System.Drawing.Point(267, 68)
        Me.ucr1stFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.Size = New System.Drawing.Size(109, 26)
        Me.ucr1stFactorReceiver.strNcFilePath = ""
        Me.ucr1stFactorReceiver.TabIndex = 64
        Me.ucr1stFactorReceiver.ucrSelector = Nothing
        '
        'ucrReceiverRain
        '
        Me.ucrReceiverRain.AutoSize = True
        Me.ucrReceiverRain.frmParent = Me
        Me.ucrReceiverRain.Location = New System.Drawing.Point(267, 150)
        Me.ucrReceiverRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRain.Name = "ucrReceiverRain"
        Me.ucrReceiverRain.Selector = Nothing
        Me.ucrReceiverRain.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRain.strNcFilePath = ""
        Me.ucrReceiverRain.TabIndex = 69
        Me.ucrReceiverRain.ucrSelector = Nothing
        '
        'ucrReceiverMaxtem
        '
        Me.ucrReceiverMaxtem.AutoSize = True
        Me.ucrReceiverMaxtem.frmParent = Me
        Me.ucrReceiverMaxtem.Location = New System.Drawing.Point(267, 193)
        Me.ucrReceiverMaxtem.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMaxtem.Name = "ucrReceiverMaxtem"
        Me.ucrReceiverMaxtem.Selector = Nothing
        Me.ucrReceiverMaxtem.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMaxtem.strNcFilePath = ""
        Me.ucrReceiverMaxtem.TabIndex = 71
        Me.ucrReceiverMaxtem.ucrSelector = Nothing
        '
        'ucrReceiverMintemp
        '
        Me.ucrReceiverMintemp.AutoSize = True
        Me.ucrReceiverMintemp.frmParent = Me
        Me.ucrReceiverMintemp.Location = New System.Drawing.Point(267, 234)
        Me.ucrReceiverMintemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMintemp.Name = "ucrReceiverMintemp"
        Me.ucrReceiverMintemp.Selector = Nothing
        Me.ucrReceiverMintemp.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMintemp.strNcFilePath = ""
        Me.ucrReceiverMintemp.TabIndex = 73
        Me.ucrReceiverMintemp.ucrSelector = Nothing
        '
        'ucrPnlClimograph
        '
        Me.ucrPnlClimograph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlClimograph.Location = New System.Drawing.Point(92, 5)
        Me.ucrPnlClimograph.Name = "ucrPnlClimograph"
        Me.ucrPnlClimograph.Size = New System.Drawing.Size(295, 41)
        Me.ucrPnlClimograph.TabIndex = 60
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(12, 520)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 75
        '
        'ucrSave
        '
        Me.ucrSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSave.Location = New System.Drawing.Point(14, 493)
        Me.ucrSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSave.Name = "ucrSave"
        Me.ucrSave.Size = New System.Drawing.Size(282, 24)
        Me.ucrSave.TabIndex = 74
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.AutoSize = True
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(267, 109)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 67
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrSelectorClimograph
        '
        Me.ucrSelectorClimograph.AutoSize = True
        Me.ucrSelectorClimograph.bDropUnusedFilterLevels = False
        Me.ucrSelectorClimograph.bShowHiddenColumns = False
        Me.ucrSelectorClimograph.bUseCurrentFilter = True
        Me.ucrSelectorClimograph.Location = New System.Drawing.Point(11, 48)
        Me.ucrSelectorClimograph.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorClimograph.Name = "ucrSelectorClimograph"
        Me.ucrSelectorClimograph.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorClimograph.TabIndex = 59
        '
        'ucrInputFacetBar
        '
        Me.ucrInputFacetBar.AddQuotesIfUnrecognised = True
        Me.ucrInputFacetBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFacetBar.GetSetSelectedIndex = -1
        Me.ucrInputFacetBar.IsReadOnly = False
        Me.ucrInputFacetBar.Location = New System.Drawing.Point(379, 68)
        Me.ucrInputFacetBar.Name = "ucrInputFacetBar"
        Me.ucrInputFacetBar.Size = New System.Drawing.Size(86, 21)
        Me.ucrInputFacetBar.TabIndex = 142
        '
        'ucrReceiverFacetBar
        '
        Me.ucrReceiverFacetBar.AutoSize = True
        Me.ucrReceiverFacetBar.frmParent = Me
        Me.ucrReceiverFacetBar.Location = New System.Drawing.Point(267, 68)
        Me.ucrReceiverFacetBar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacetBar.Name = "ucrReceiverFacetBar"
        Me.ucrReceiverFacetBar.Selector = Nothing
        Me.ucrReceiverFacetBar.Size = New System.Drawing.Size(109, 26)
        Me.ucrReceiverFacetBar.strNcFilePath = ""
        Me.ucrReceiverFacetBar.TabIndex = 141
        Me.ucrReceiverFacetBar.ucrSelector = Nothing
        '
        'lblFacetBar
        '
        Me.lblFacetBar.AutoSize = True
        Me.lblFacetBar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetBar.Location = New System.Drawing.Point(267, 53)
        Me.lblFacetBar.Name = "lblFacetBar"
        Me.lblFacetBar.Size = New System.Drawing.Size(52, 13)
        Me.lblFacetBar.TabIndex = 140
        Me.lblFacetBar.Tag = ""
        Me.lblFacetBar.Text = "Facet By:"
        '
        'dlgClimograph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 578)
        Me.Controls.Add(Me.ucrInputFacetBar)
        Me.Controls.Add(Me.ucrReceiverFacetBar)
        Me.Controls.Add(Me.lblFacetBar)
        Me.Controls.Add(Me.ucrReceiverRainBar)
        Me.Controls.Add(Me.lblRainBar)
        Me.Controls.Add(Me.ucrReceiverElement1Bar)
        Me.Controls.Add(Me.lblElement1Bar)
        Me.Controls.Add(Me.ucrReceiverElement2Bar)
        Me.Controls.Add(Me.lblElement2Bar)
        Me.Controls.Add(Me.ucrReceiverMonthBar)
        Me.Controls.Add(Me.lblMonthBar)
        Me.Controls.Add(Me.rdoClimateBars)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.rdoSinglecolour)
        Me.Controls.Add(Me.rdoViridis)
        Me.Controls.Add(Me.ucrInputPalette)
        Me.Controls.Add(Me.rdoPalette)
        Me.Controls.Add(Me.ucrPnlColour)
        Me.Controls.Add(Me.ucrInputColourPalette)
        Me.Controls.Add(Me.ucrChkColour)
        Me.Controls.Add(Me.ucrChkTile)
        Me.Controls.Add(Me.ucrChkText)
        Me.Controls.Add(Me.ucrChkRibbon)
        Me.Controls.Add(Me.ucrInputLegendPosition)
        Me.Controls.Add(Me.ucrChkLegend)
        Me.Controls.Add(Me.ucrInputFacet)
        Me.Controls.Add(Me.ucrReceiverFacet)
        Me.Controls.Add(Me.lblFacet)
        Me.Controls.Add(Me.ucrReceiverRainC)
        Me.Controls.Add(Me.lblRainC)
        Me.Controls.Add(Me.ucrReceiverElement1)
        Me.Controls.Add(Me.lblElement1)
        Me.Controls.Add(Me.ucrReceiverElement2)
        Me.Controls.Add(Me.lblElement2)
        Me.Controls.Add(Me.ucrReceiverMonthC)
        Me.Controls.Add(Me.lblMonthC)
        Me.Controls.Add(Me.ucrReceiverAbsolute)
        Me.Controls.Add(Me.lblAbsolute)
        Me.Controls.Add(Me.ucrInputStation)
        Me.Controls.Add(Me.ucr1stFactorReceiver)
        Me.Controls.Add(Me.lblFacetBy)
        Me.Controls.Add(Me.ucrReceiverRain)
        Me.Controls.Add(Me.lblRain)
        Me.Controls.Add(Me.ucrReceiverMaxtem)
        Me.Controls.Add(Me.lblMaxtem)
        Me.Controls.Add(Me.ucrReceiverMintemp)
        Me.Controls.Add(Me.lblMintem)
        Me.Controls.Add(Me.rdoClimograph)
        Me.Controls.Add(Me.rdoWalterLieth)
        Me.Controls.Add(Me.ucrPnlClimograph)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSave)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.ucrSelectorClimograph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimograph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Climograph"
        Me.contextMenuStripOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrReceiverAbsolute As ucrReceiverSingle
    Friend WithEvents lblAbsolute As Label
    Friend WithEvents ucrInputStation As ucrInputComboBox
    Friend WithEvents ucr1stFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblFacetBy As Label
    Friend WithEvents ucrReceiverRain As ucrReceiverSingle
    Friend WithEvents lblRain As Label
    Friend WithEvents ucrReceiverMaxtem As ucrReceiverSingle
    Friend WithEvents lblMaxtem As Label
    Friend WithEvents ucrReceiverMintemp As ucrReceiverSingle
    Friend WithEvents lblMintem As Label
    Friend WithEvents rdoClimograph As RadioButton
    Friend WithEvents rdoWalterLieth As RadioButton
    Friend WithEvents ucrPnlClimograph As UcrPanel
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSave As ucrSave
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents lblMonth As Label
    Friend WithEvents ucrSelectorClimograph As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputFacet As ucrInputComboBox
    Friend WithEvents ucrReceiverFacet As ucrReceiverSingle
    Friend WithEvents lblFacet As Label
    Friend WithEvents ucrReceiverRainC As ucrReceiverSingle
    Friend WithEvents lblRainC As Label
    Friend WithEvents ucrReceiverElement1 As ucrReceiverSingle
    Friend WithEvents lblElement1 As Label
    Friend WithEvents ucrReceiverElement2 As ucrReceiverSingle
    Friend WithEvents lblElement2 As Label
    Friend WithEvents ucrReceiverMonthC As ucrReceiverSingle
    Friend WithEvents lblMonthC As Label
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents ucrChkRibbon As ucrCheck
    Friend WithEvents ucrChkText As ucrCheck
    Friend WithEvents ucrChkTile As ucrCheck
    Friend WithEvents ucrChkLegend As ucrCheck
    Friend WithEvents rdoViridis As RadioButton
    Friend WithEvents ucrInputPalette As ucrInputComboBox
    Friend WithEvents rdoPalette As RadioButton
    Friend WithEvents ucrPnlColour As UcrPanel
    Friend WithEvents ucrInputColourPalette As ucrInputComboBox
    Friend WithEvents ucrChkColour As ucrCheck
    Friend WithEvents rdoSinglecolour As RadioButton
    Friend WithEvents contextMenuStripOptions As ContextMenuStrip
    Friend WithEvents toolStripMenuItemPlotOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemBarchartOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemTmaxLineOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemTminLineOptions As ToolStripMenuItem
    Friend WithEvents cmdOptions As ucrSplitButton
    Friend WithEvents rdoClimateBars As RadioButton
    Friend WithEvents ucrReceiverRainBar As ucrReceiverSingle
    Friend WithEvents lblRainBar As Label
    Friend WithEvents ucrReceiverElement1Bar As ucrReceiverSingle
    Friend WithEvents lblElement1Bar As Label
    Friend WithEvents ucrReceiverElement2Bar As ucrReceiverSingle
    Friend WithEvents lblElement2Bar As Label
    Friend WithEvents ucrReceiverMonthBar As ucrReceiverSingle
    Friend WithEvents lblMonthBar As Label
    Friend WithEvents ucrInputFacetBar As ucrInputComboBox
    Friend WithEvents ucrReceiverFacetBar As ucrReceiverSingle
    Friend WithEvents lblFacetBar As Label
End Class
