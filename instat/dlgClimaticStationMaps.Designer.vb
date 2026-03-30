<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimaticStationMaps
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
        Me.grpPoints = New System.Windows.Forms.GroupBox()
        Me.grpBoxLabelOptions = New System.Windows.Forms.GroupBox()
        Me.lblLabels = New System.Windows.Forms.Label()
        Me.lblFacet = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblShape = New System.Windows.Forms.Label()
        Me.lbllatitude = New System.Windows.Forms.Label()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.grpMapOutline = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.contextMenuStripOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PlotOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemSFOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemMapping = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemPointOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemLabelRepelOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemTextRepelOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrChkLegend = New instat.ucrCheck()
        Me.cmdOptions = New instat.ucrSplitButton()
        Me.ucrChkAddPoints = New instat.ucrCheck()
        Me.ucrReceiverGeometry = New instat.ucrReceiverSingle()
        Me.ucrReceiverFill = New instat.ucrReceiverSingle()
        Me.ucrSelectorOutline = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucrChkColour = New instat.ucrCheck()
        Me.ucrChkLabelAll = New instat.ucrCheck()
        Me.ucrInputColour = New instat.ucrInputComboBox()
        Me.ucrNudSize = New instat.ucrNud()
        Me.ucrChkSize = New instat.ucrCheck()
        Me.ucrChkLabelledRectangle = New instat.ucrCheck()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverFacet = New instat.ucrReceiverSingle()
        Me.ucrReceiverColor = New instat.ucrReceiverSingle()
        Me.ucrReceiverShape = New instat.ucrReceiverSingle()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverLongitude = New instat.ucrReceiverSingle()
        Me.ucrSelectorStation = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSaveMap = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpPoints.SuspendLayout()
        Me.grpBoxLabelOptions.SuspendLayout()
        Me.grpMapOutline.SuspendLayout()
        Me.contextMenuStripOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPoints
        '
        Me.grpPoints.Controls.Add(Me.ucrInputStation)
        Me.grpPoints.Controls.Add(Me.grpBoxLabelOptions)
        Me.grpPoints.Controls.Add(Me.lblLabels)
        Me.grpPoints.Controls.Add(Me.ucrReceiverStation)
        Me.grpPoints.Controls.Add(Me.lblFacet)
        Me.grpPoints.Controls.Add(Me.ucrReceiverFacet)
        Me.grpPoints.Controls.Add(Me.lblColor)
        Me.grpPoints.Controls.Add(Me.lblShape)
        Me.grpPoints.Controls.Add(Me.lbllatitude)
        Me.grpPoints.Controls.Add(Me.ucrReceiverColor)
        Me.grpPoints.Controls.Add(Me.lblLongitude)
        Me.grpPoints.Controls.Add(Me.ucrReceiverShape)
        Me.grpPoints.Controls.Add(Me.ucrReceiverLatitude)
        Me.grpPoints.Controls.Add(Me.ucrReceiverLongitude)
        Me.grpPoints.Controls.Add(Me.ucrSelectorStation)
        Me.grpPoints.Location = New System.Drawing.Point(560, 12)
        Me.grpPoints.Margin = New System.Windows.Forms.Padding(4)
        Me.grpPoints.Name = "grpPoints"
        Me.grpPoints.Padding = New System.Windows.Forms.Padding(4)
        Me.grpPoints.Size = New System.Drawing.Size(556, 501)
        Me.grpPoints.TabIndex = 1
        Me.grpPoints.TabStop = False
        Me.grpPoints.Text = "Points"
        '
        'grpBoxLabelOptions
        '
        Me.grpBoxLabelOptions.Controls.Add(Me.ucrChkColour)
        Me.grpBoxLabelOptions.Controls.Add(Me.ucrChkLabelAll)
        Me.grpBoxLabelOptions.Controls.Add(Me.ucrInputColour)
        Me.grpBoxLabelOptions.Controls.Add(Me.ucrNudSize)
        Me.grpBoxLabelOptions.Controls.Add(Me.ucrChkSize)
        Me.grpBoxLabelOptions.Controls.Add(Me.ucrChkLabelledRectangle)
        Me.grpBoxLabelOptions.Location = New System.Drawing.Point(32, 308)
        Me.grpBoxLabelOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.grpBoxLabelOptions.Name = "grpBoxLabelOptions"
        Me.grpBoxLabelOptions.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBoxLabelOptions.Size = New System.Drawing.Size(321, 192)
        Me.grpBoxLabelOptions.TabIndex = 13
        Me.grpBoxLabelOptions.TabStop = False
        Me.grpBoxLabelOptions.Text = "Label Options:"
        '
        'lblLabels
        '
        Me.lblLabels.AutoSize = True
        Me.lblLabels.Location = New System.Drawing.Point(360, 144)
        Me.lblLabels.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLabels.Name = "lblLabels"
        Me.lblLabels.Size = New System.Drawing.Size(133, 20)
        Me.lblLabels.TabIndex = 5
        Me.lblLabels.Text = "Labels (Optional):"
        '
        'lblFacet
        '
        Me.lblFacet.AutoSize = True
        Me.lblFacet.Location = New System.Drawing.Point(360, 327)
        Me.lblFacet.Name = "lblFacet"
        Me.lblFacet.Size = New System.Drawing.Size(62, 20)
        Me.lblFacet.TabIndex = 11
        Me.lblFacet.Text = "Facets:"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(360, 267)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(123, 20)
        Me.lblColor.TabIndex = 9
        Me.lblColor.Text = "Color (Optional):"
        '
        'lblShape
        '
        Me.lblShape.AutoSize = True
        Me.lblShape.Location = New System.Drawing.Point(360, 206)
        Me.lblShape.Name = "lblShape"
        Me.lblShape.Size = New System.Drawing.Size(133, 20)
        Me.lblShape.TabIndex = 7
        Me.lblShape.Text = "Shape (Optional):"
        '
        'lbllatitude
        '
        Me.lbllatitude.AutoSize = True
        Me.lbllatitude.Location = New System.Drawing.Point(360, 82)
        Me.lbllatitude.Name = "lbllatitude"
        Me.lbllatitude.Size = New System.Drawing.Size(71, 20)
        Me.lbllatitude.TabIndex = 3
        Me.lbllatitude.Text = "Latitude:"
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.Location = New System.Drawing.Point(360, 22)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(84, 20)
        Me.lblLongitude.TabIndex = 1
        Me.lblLongitude.Text = "Longitude:"
        '
        'grpMapOutline
        '
        Me.grpMapOutline.Controls.Add(Me.ucrChkAddPoints)
        Me.grpMapOutline.Controls.Add(Me.Label1)
        Me.grpMapOutline.Controls.Add(Me.ucrReceiverGeometry)
        Me.grpMapOutline.Controls.Add(Me.lblFill)
        Me.grpMapOutline.Controls.Add(Me.ucrReceiverFill)
        Me.grpMapOutline.Controls.Add(Me.ucrSelectorOutline)
        Me.grpMapOutline.Location = New System.Drawing.Point(15, 18)
        Me.grpMapOutline.Margin = New System.Windows.Forms.Padding(4)
        Me.grpMapOutline.Name = "grpMapOutline"
        Me.grpMapOutline.Padding = New System.Windows.Forms.Padding(4)
        Me.grpMapOutline.Size = New System.Drawing.Size(536, 320)
        Me.grpMapOutline.TabIndex = 0
        Me.grpMapOutline.TabStop = False
        Me.grpMapOutline.Text = "Map Outline"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(346, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Geometry"
        '
        'lblFill
        '
        Me.lblFill.AutoSize = True
        Me.lblFill.Location = New System.Drawing.Point(346, 87)
        Me.lblFill.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Size = New System.Drawing.Size(105, 20)
        Me.lblFill.TabIndex = 3
        Me.lblFill.Text = "Fill (Optional):"
        '
        'contextMenuStripOptions
        '
        Me.contextMenuStripOptions.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.contextMenuStripOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlotOptionsToolStripMenuItem, Me.toolStripMenuItemSFOptions, Me.toolStripMenuItemMapping, Me.toolStripMenuItemPointOptions, Me.toolStripMenuItemLabelRepelOptions, Me.toolStripMenuItemTextRepelOptions})
        Me.contextMenuStripOptions.Name = "contextMenuStripOk"
        Me.contextMenuStripOptions.Size = New System.Drawing.Size(243, 196)
        '
        'PlotOptionsToolStripMenuItem
        '
        Me.PlotOptionsToolStripMenuItem.Name = "PlotOptionsToolStripMenuItem"
        Me.PlotOptionsToolStripMenuItem.Size = New System.Drawing.Size(242, 32)
        Me.PlotOptionsToolStripMenuItem.Text = "Plot Options"
        '
        'toolStripMenuItemSFOptions
        '
        Me.toolStripMenuItemSFOptions.Name = "toolStripMenuItemSFOptions"
        Me.toolStripMenuItemSFOptions.Size = New System.Drawing.Size(242, 32)
        Me.toolStripMenuItemSFOptions.Text = "SF Options"
        '
        'toolStripMenuItemMapping
        '
        Me.toolStripMenuItemMapping.Name = "toolStripMenuItemMapping"
        Me.toolStripMenuItemMapping.Size = New System.Drawing.Size(242, 32)
        Me.toolStripMenuItemMapping.Text = "Map Options"
        '
        'toolStripMenuItemPointOptions
        '
        Me.toolStripMenuItemPointOptions.Name = "toolStripMenuItemPointOptions"
        Me.toolStripMenuItemPointOptions.Size = New System.Drawing.Size(242, 32)
        Me.toolStripMenuItemPointOptions.Text = "Point Options"
        '
        'toolStripMenuItemLabelRepelOptions
        '
        Me.toolStripMenuItemLabelRepelOptions.Name = "toolStripMenuItemLabelRepelOptions"
        Me.toolStripMenuItemLabelRepelOptions.Size = New System.Drawing.Size(242, 32)
        Me.toolStripMenuItemLabelRepelOptions.Text = "Label Repel Options"
        '
        'toolStripMenuItemTextRepelOptions
        '
        Me.toolStripMenuItemTextRepelOptions.Name = "toolStripMenuItemTextRepelOptions"
        Me.toolStripMenuItemTextRepelOptions.Size = New System.Drawing.Size(242, 32)
        Me.toolStripMenuItemTextRepelOptions.Text = "Text Repel Options"
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(362, 351)
        Me.ucrInputLegendPosition.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(168, 32)
        Me.ucrInputLegendPosition.TabIndex = 30
        '
        'ucrChkLegend
        '
        Me.ucrChkLegend.AutoSize = True
        Me.ucrChkLegend.Checked = False
        Me.ucrChkLegend.Location = New System.Drawing.Point(201, 354)
        Me.ucrChkLegend.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkLegend.Name = "ucrChkLegend"
        Me.ucrChkLegend.Size = New System.Drawing.Size(147, 36)
        Me.ucrChkLegend.TabIndex = 29
        '
        'cmdOptions
        '
        Me.cmdOptions.AutoSize = True
        Me.cmdOptions.ContextMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.Location = New System.Drawing.Point(15, 348)
        Me.cmdOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(172, 34)
        Me.cmdOptions.SplitMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.TabIndex = 2
        Me.cmdOptions.Tag = "Plot Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrChkAddPoints
        '
        Me.ucrChkAddPoints.AutoSize = True
        Me.ucrChkAddPoints.Checked = False
        Me.ucrChkAddPoints.Location = New System.Drawing.Point(346, 156)
        Me.ucrChkAddPoints.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkAddPoints.Name = "ucrChkAddPoints"
        Me.ucrChkAddPoints.Size = New System.Drawing.Size(180, 51)
        Me.ucrChkAddPoints.TabIndex = 5
        '
        'ucrReceiverGeometry
        '
        Me.ucrReceiverGeometry.AutoSize = True
        Me.ucrReceiverGeometry.frmParent = Nothing
        Me.ucrReceiverGeometry.Location = New System.Drawing.Point(346, 48)
        Me.ucrReceiverGeometry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGeometry.Name = "ucrReceiverGeometry"
        Me.ucrReceiverGeometry.Selector = Nothing
        Me.ucrReceiverGeometry.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverGeometry.strNcFilePath = ""
        Me.ucrReceiverGeometry.TabIndex = 2
        Me.ucrReceiverGeometry.ucrSelector = Nothing
        '
        'ucrReceiverFill
        '
        Me.ucrReceiverFill.AutoSize = True
        Me.ucrReceiverFill.frmParent = Nothing
        Me.ucrReceiverFill.Location = New System.Drawing.Point(346, 111)
        Me.ucrReceiverFill.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFill.Name = "ucrReceiverFill"
        Me.ucrReceiverFill.Selector = Nothing
        Me.ucrReceiverFill.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverFill.strNcFilePath = ""
        Me.ucrReceiverFill.TabIndex = 4
        Me.ucrReceiverFill.ucrSelector = Nothing
        '
        'ucrSelectorOutline
        '
        Me.ucrSelectorOutline.AutoSize = True
        Me.ucrSelectorOutline.bDropUnusedFilterLevels = False
        Me.ucrSelectorOutline.bShowHiddenColumns = False
        Me.ucrSelectorOutline.bUseCurrentFilter = True
        Me.ucrSelectorOutline.Location = New System.Drawing.Point(6, 22)
        Me.ucrSelectorOutline.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOutline.Name = "ucrSelectorOutline"
        Me.ucrSelectorOutline.Size = New System.Drawing.Size(477, 411)
        Me.ucrSelectorOutline.TabIndex = 0
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Location = New System.Drawing.Point(388, 389)
        Me.ucrInputStation.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputStation.Name = "ucrInputStation"
        Me.ucrInputStation.Size = New System.Drawing.Size(152, 32)
        Me.ucrInputStation.TabIndex = 82
        '
        'ucrChkColour
        '
        Me.ucrChkColour.AutoSize = True
        Me.ucrChkColour.Checked = False
        Me.ucrChkColour.Location = New System.Drawing.Point(9, 142)
        Me.ucrChkColour.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkColour.Name = "ucrChkColour"
        Me.ucrChkColour.Size = New System.Drawing.Size(130, 46)
        Me.ucrChkColour.TabIndex = 9
        '
        'ucrChkLabelAll
        '
        Me.ucrChkLabelAll.AutoSize = True
        Me.ucrChkLabelAll.Checked = False
        Me.ucrChkLabelAll.Location = New System.Drawing.Point(9, 104)
        Me.ucrChkLabelAll.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkLabelAll.Name = "ucrChkLabelAll"
        Me.ucrChkLabelAll.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkLabelAll.TabIndex = 7
        '
        'ucrInputColour
        '
        Me.ucrInputColour.AddQuotesIfUnrecognised = True
        Me.ucrInputColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputColour.GetSetSelectedIndex = -1
        Me.ucrInputColour.IsReadOnly = False
        Me.ucrInputColour.Location = New System.Drawing.Point(142, 141)
        Me.ucrInputColour.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputColour.Name = "ucrInputColour"
        Me.ucrInputColour.Size = New System.Drawing.Size(170, 32)
        Me.ucrInputColour.TabIndex = 11
        '
        'ucrNudSize
        '
        Me.ucrNudSize.AutoSize = True
        Me.ucrNudSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSize.Location = New System.Drawing.Point(162, 62)
        Me.ucrNudSize.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSize.Name = "ucrNudSize"
        Me.ucrNudSize.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudSize.TabIndex = 10
        Me.ucrNudSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkSize
        '
        Me.ucrChkSize.AutoSize = True
        Me.ucrChkSize.Checked = False
        Me.ucrChkSize.Location = New System.Drawing.Point(9, 62)
        Me.ucrChkSize.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkSize.Name = "ucrChkSize"
        Me.ucrChkSize.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkSize.TabIndex = 8
        '
        'ucrChkLabelledRectangle
        '
        Me.ucrChkLabelledRectangle.AutoSize = True
        Me.ucrChkLabelledRectangle.Checked = False
        Me.ucrChkLabelledRectangle.Location = New System.Drawing.Point(9, 26)
        Me.ucrChkLabelledRectangle.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkLabelledRectangle.Name = "ucrChkLabelledRectangle"
        Me.ucrChkLabelledRectangle.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkLabelledRectangle.TabIndex = 6
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Nothing
        Me.ucrReceiverStation.Location = New System.Drawing.Point(360, 168)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 6
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverFacet
        '
        Me.ucrReceiverFacet.AutoSize = True
        Me.ucrReceiverFacet.frmParent = Nothing
        Me.ucrReceiverFacet.Location = New System.Drawing.Point(360, 351)
        Me.ucrReceiverFacet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacet.Name = "ucrReceiverFacet"
        Me.ucrReceiverFacet.Selector = Nothing
        Me.ucrReceiverFacet.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverFacet.strNcFilePath = ""
        Me.ucrReceiverFacet.TabIndex = 12
        Me.ucrReceiverFacet.ucrSelector = Nothing
        '
        'ucrReceiverColor
        '
        Me.ucrReceiverColor.AutoSize = True
        Me.ucrReceiverColor.frmParent = Nothing
        Me.ucrReceiverColor.Location = New System.Drawing.Point(360, 291)
        Me.ucrReceiverColor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColor.Name = "ucrReceiverColor"
        Me.ucrReceiverColor.Selector = Nothing
        Me.ucrReceiverColor.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverColor.strNcFilePath = ""
        Me.ucrReceiverColor.TabIndex = 10
        Me.ucrReceiverColor.ucrSelector = Nothing
        '
        'ucrReceiverShape
        '
        Me.ucrReceiverShape.AutoSize = True
        Me.ucrReceiverShape.frmParent = Nothing
        Me.ucrReceiverShape.Location = New System.Drawing.Point(360, 230)
        Me.ucrReceiverShape.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverShape.Name = "ucrReceiverShape"
        Me.ucrReceiverShape.Selector = Nothing
        Me.ucrReceiverShape.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverShape.strNcFilePath = ""
        Me.ucrReceiverShape.TabIndex = 8
        Me.ucrReceiverShape.ucrSelector = Nothing
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.AutoSize = True
        Me.ucrReceiverLatitude.frmParent = Nothing
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(360, 106)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 4
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrReceiverLongitude
        '
        Me.ucrReceiverLongitude.AutoSize = True
        Me.ucrReceiverLongitude.frmParent = Nothing
        Me.ucrReceiverLongitude.Location = New System.Drawing.Point(360, 46)
        Me.ucrReceiverLongitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.TabIndex = 2
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'ucrSelectorStation
        '
        Me.ucrSelectorStation.AutoSize = True
        Me.ucrSelectorStation.bDropUnusedFilterLevels = False
        Me.ucrSelectorStation.bShowHiddenColumns = False
        Me.ucrSelectorStation.bUseCurrentFilter = True
        Me.ucrSelectorStation.Location = New System.Drawing.Point(12, 24)
        Me.ucrSelectorStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStation.Name = "ucrSelectorStation"
        Me.ucrSelectorStation.Size = New System.Drawing.Size(477, 411)
        Me.ucrSelectorStation.TabIndex = 0
        '
        'ucrSaveMap
        '
        Me.ucrSaveMap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveMap.Location = New System.Drawing.Point(15, 478)
        Me.ucrSaveMap.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrSaveMap.Name = "ucrSaveMap"
        Me.ucrSaveMap.Size = New System.Drawing.Size(480, 33)
        Me.ucrSaveMap.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 525)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 4
        '
        'dlgClimaticStationMaps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1134, 609)
        Me.Controls.Add(Me.ucrInputLegendPosition)
        Me.Controls.Add(Me.ucrChkLegend)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.grpMapOutline)
        Me.Controls.Add(Me.grpPoints)
        Me.Controls.Add(Me.ucrSaveMap)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticStationMaps"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Climatic Maps"
        Me.grpPoints.ResumeLayout(False)
        Me.grpPoints.PerformLayout()
        Me.grpBoxLabelOptions.ResumeLayout(False)
        Me.grpBoxLabelOptions.PerformLayout()
        Me.grpMapOutline.ResumeLayout(False)
        Me.grpMapOutline.PerformLayout()
        Me.contextMenuStripOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSaveMap As ucrSave
    Friend WithEvents grpPoints As GroupBox
    Friend WithEvents lblLabels As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents grpMapOutline As GroupBox
    Friend WithEvents lblFill As Label
    Friend WithEvents ucrReceiverFill As ucrReceiverSingle
    Friend WithEvents ucrSelectorOutline As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFacet As Label
    Friend WithEvents ucrReceiverFacet As ucrReceiverSingle
    Friend WithEvents ucrSelectorStation As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblColor As Label
    Friend WithEvents lblShape As Label
    Friend WithEvents lbllatitude As Label
    Friend WithEvents ucrReceiverColor As ucrReceiverSingle
    Friend WithEvents lblLongitude As Label
    Friend WithEvents ucrReceiverShape As ucrReceiverSingle
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverLongitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverGeometry As ucrReceiverSingle
    Friend WithEvents ucrChkAddPoints As ucrCheck
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdOptions As ucrSplitButton
    Friend WithEvents contextMenuStripOptions As ContextMenuStrip
    Friend WithEvents toolStripMenuItemSFOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemMapping As ToolStripMenuItem
    Friend WithEvents PlotOptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemPointOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemLabelRepelOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemTextRepelOptions As ToolStripMenuItem
    Friend WithEvents grpBoxLabelOptions As GroupBox
    Friend WithEvents ucrChkLabelAll As ucrCheck
    Friend WithEvents ucrChkLabelledRectangle As ucrCheck
    Friend WithEvents ucrChkSize As ucrCheck
    Friend WithEvents ucrChkColour As ucrCheck
    Friend WithEvents ucrInputColour As ucrInputComboBox
    Friend WithEvents ucrNudSize As ucrNud
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents ucrChkLegend As ucrCheck
    Friend WithEvents ucrInputStation As ucrInputComboBox
End Class
