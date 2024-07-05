<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.ucrChkText = New instat.ucrCheck()
        Me.ucrChkRibbon = New instat.ucrCheck()
        Me.ucrInputLabels = New instat.ucrInputTextBox()
        Me.ucrInputName = New instat.ucrInputTextBox()
        Me.ucrChkColourIdntity = New instat.ucrCheck()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrChkLegend = New instat.ucrCheck()
        Me.cmdOptions = New instat.ucrSplitButton()
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
        Me.ucrChkTile = New instat.ucrCheck()
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
        Me.rdoClimograph.Location = New System.Drawing.Point(149, 10)
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
        Me.rdoWalterLieth.Location = New System.Drawing.Point(227, 10)
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
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(9, 399)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 100
        Me.lblName.Text = "Name:"
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.Location = New System.Drawing.Point(190, 399)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(41, 13)
        Me.lblLabel.TabIndex = 102
        Me.lblLabel.Text = "Labels:"
        '
        'ucrChkText
        '
        Me.ucrChkText.AutoSize = True
        Me.ucrChkText.Checked = False
        Me.ucrChkText.Location = New System.Drawing.Point(12, 335)
        Me.ucrChkText.Name = "ucrChkText"
        Me.ucrChkText.Size = New System.Drawing.Size(98, 24)
        Me.ucrChkText.TabIndex = 104
        '
        'ucrChkRibbon
        '
        Me.ucrChkRibbon.AutoSize = True
        Me.ucrChkRibbon.Checked = False
        Me.ucrChkRibbon.Location = New System.Drawing.Point(12, 269)
        Me.ucrChkRibbon.Name = "ucrChkRibbon"
        Me.ucrChkRibbon.Size = New System.Drawing.Size(147, 24)
        Me.ucrChkRibbon.TabIndex = 103
        '
        'ucrInputLabels
        '
        Me.ucrInputLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputLabels.AutoSize = True
        Me.ucrInputLabels.IsMultiline = False
        Me.ucrInputLabels.IsReadOnly = False
        Me.ucrInputLabels.Location = New System.Drawing.Point(243, 394)
        Me.ucrInputLabels.Name = "ucrInputLabels"
        Me.ucrInputLabels.Size = New System.Drawing.Size(117, 21)
        Me.ucrInputLabels.TabIndex = 101
        '
        'ucrInputName
        '
        Me.ucrInputName.AddQuotesIfUnrecognised = True
        Me.ucrInputName.AutoSize = True
        Me.ucrInputName.IsMultiline = False
        Me.ucrInputName.IsReadOnly = False
        Me.ucrInputName.Location = New System.Drawing.Point(62, 394)
        Me.ucrInputName.Name = "ucrInputName"
        Me.ucrInputName.Size = New System.Drawing.Size(117, 21)
        Me.ucrInputName.TabIndex = 99
        '
        'ucrChkColourIdntity
        '
        Me.ucrChkColourIdntity.AutoSize = True
        Me.ucrChkColourIdntity.Checked = False
        Me.ucrChkColourIdntity.Location = New System.Drawing.Point(12, 369)
        Me.ucrChkColourIdntity.Name = "ucrChkColourIdntity"
        Me.ucrChkColourIdntity.Size = New System.Drawing.Size(189, 24)
        Me.ucrChkColourIdntity.TabIndex = 98
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(112, 424)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(112, 21)
        Me.ucrInputLegendPosition.TabIndex = 97
        '
        'ucrChkLegend
        '
        Me.ucrChkLegend.AutoSize = True
        Me.ucrChkLegend.Checked = False
        Me.ucrChkLegend.Location = New System.Drawing.Point(12, 421)
        Me.ucrChkLegend.Name = "ucrChkLegend"
        Me.ucrChkLegend.Size = New System.Drawing.Size(98, 24)
        Me.ucrChkLegend.TabIndex = 96
        '
        'cmdOptions
        '
        Me.cmdOptions.AutoSize = True
        Me.cmdOptions.Location = New System.Drawing.Point(11, 234)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(148, 25)
        Me.cmdOptions.TabIndex = 95
        Me.cmdOptions.Tag = "Plot Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
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
        Me.ucrPnlClimograph.Location = New System.Drawing.Point(107, 5)
        Me.ucrPnlClimograph.Name = "ucrPnlClimograph"
        Me.ucrPnlClimograph.Size = New System.Drawing.Size(236, 41)
        Me.ucrPnlClimograph.TabIndex = 60
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(12, 480)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 75
        '
        'ucrSave
        '
        Me.ucrSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSave.Location = New System.Drawing.Point(12, 453)
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
        'ucrChkTile
        '
        Me.ucrChkTile.AutoSize = True
        Me.ucrChkTile.Checked = False
        Me.ucrChkTile.Location = New System.Drawing.Point(11, 299)
        Me.ucrChkTile.Name = "ucrChkTile"
        Me.ucrChkTile.Size = New System.Drawing.Size(147, 24)
        Me.ucrChkTile.TabIndex = 105
        '
        'dlgClimograph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 543)
        Me.Controls.Add(Me.ucrChkTile)
        Me.Controls.Add(Me.ucrChkText)
        Me.Controls.Add(Me.ucrChkRibbon)
        Me.Controls.Add(Me.lblLabel)
        Me.Controls.Add(Me.ucrInputLabels)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.ucrInputName)
        Me.Controls.Add(Me.ucrChkColourIdntity)
        Me.Controls.Add(Me.ucrInputLegendPosition)
        Me.Controls.Add(Me.ucrChkLegend)
        Me.Controls.Add(Me.cmdOptions)
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
    Friend WithEvents cmdOptions As ucrSplitButton
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents ucrChkLegend As ucrCheck
    Friend WithEvents ucrChkColourIdntity As ucrCheck
    Friend WithEvents lblName As Label
    Friend WithEvents ucrInputName As ucrInputTextBox
    Friend WithEvents lblLabel As Label
    Friend WithEvents ucrInputLabels As ucrInputTextBox
    Friend WithEvents ucrChkRibbon As ucrCheck
    Friend WithEvents ucrChkText As ucrCheck
    Friend WithEvents ucrChkTile As ucrCheck
End Class
