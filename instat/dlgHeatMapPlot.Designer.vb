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
Partial Class dlgHeatMapPlot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgHeatMapPlot))
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.lblLabelPosition = New System.Windows.Forms.Label()
        Me.lblLabelColour = New System.Windows.Forms.Label()
        Me.lblLabelSize = New System.Windows.Forms.Label()
        Me.lblReorderVariableX = New System.Windows.Forms.Label()
        Me.lblReorderValue = New System.Windows.Forms.Label()
        Me.rdoChoroplethMap = New System.Windows.Forms.RadioButton()
        Me.rdoHeatMap = New System.Windows.Forms.RadioButton()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.lblFillChoropleth = New System.Windows.Forms.Label()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.contextMenuStripOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuItemPlotOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemTileOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemPolygonOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemJitterOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.lblYvariable = New System.Windows.Forms.Label()
        Me.lblHeith = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.ucrChkJitter = New instat.ucrCheck()
        Me.ucrNudHeigth = New instat.ucrNud()
        Me.ucrNudWidth = New instat.ucrNud()
        Me.ucrReceiverY = New instat.ucrReceiverSingle()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucr1stFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrChkLegend = New instat.ucrCheck()
        Me.cmdOptions = New instat.ucrSplitButton()
        Me.ucrReceiverFill = New instat.ucrReceiverSingle()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrInputReorderValue = New instat.ucrInputComboBox()
        Me.ucrHeatMapSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverLongitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverFillChoropleth = New instat.ucrReceiverSingle()
        Me.ucrInputReorderVariableX = New instat.ucrInputComboBox()
        Me.ucrInputSize = New instat.ucrInputComboBox()
        Me.ucrInputPosition = New instat.ucrInputComboBox()
        Me.ucrInputColour = New instat.ucrInputComboBox()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrReceiverGroup = New instat.ucrReceiverSingle()
        Me.ucrChkAddLabels = New instat.ucrCheck()
        Me.ucrChkPoints = New instat.ucrCheck()
        Me.ucrChkFlipCoordinates = New instat.ucrCheck()
        Me.grpColour = New System.Windows.Forms.GroupBox()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.ucrInputValue = New instat.ucrInputTextBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.rdoViridis = New System.Windows.Forms.RadioButton()
        Me.ucrColourTo = New instat.ucrColors()
        Me.ucrColourFrom = New instat.ucrColors()
        Me.ucrInputPalette = New instat.ucrInputComboBox()
        Me.rdoPalette = New System.Windows.Forms.RadioButton()
        Me.rdoGradient = New System.Windows.Forms.RadioButton()
        Me.ucrPnlColour = New instat.UcrPanel()
        Me.ucrInputColourPalette = New instat.ucrInputComboBox()
        Me.contextMenuStripOptions.SuspendLayout()
        Me.grpColour.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblXVariable
        '
        resources.ApplyResources(Me.lblXVariable, "lblXVariable")
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Tag = "X_Variable:"
        '
        'lblFill
        '
        resources.ApplyResources(Me.lblFill, "lblFill")
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Tag = "fill"
        '
        'lblLabelPosition
        '
        resources.ApplyResources(Me.lblLabelPosition, "lblLabelPosition")
        Me.lblLabelPosition.Name = "lblLabelPosition"
        '
        'lblLabelColour
        '
        resources.ApplyResources(Me.lblLabelColour, "lblLabelColour")
        Me.lblLabelColour.Name = "lblLabelColour"
        '
        'lblLabelSize
        '
        resources.ApplyResources(Me.lblLabelSize, "lblLabelSize")
        Me.lblLabelSize.Name = "lblLabelSize"
        '
        'lblReorderVariableX
        '
        resources.ApplyResources(Me.lblReorderVariableX, "lblReorderVariableX")
        Me.lblReorderVariableX.Name = "lblReorderVariableX"
        '
        'lblReorderValue
        '
        resources.ApplyResources(Me.lblReorderValue, "lblReorderValue")
        Me.lblReorderValue.Name = "lblReorderValue"
        '
        'rdoChoroplethMap
        '
        resources.ApplyResources(Me.rdoChoroplethMap, "rdoChoroplethMap")
        Me.rdoChoroplethMap.BackColor = System.Drawing.SystemColors.Control
        Me.rdoChoroplethMap.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoChoroplethMap.FlatAppearance.BorderSize = 2
        Me.rdoChoroplethMap.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoChoroplethMap.Name = "rdoChoroplethMap"
        Me.rdoChoroplethMap.TabStop = True
        Me.rdoChoroplethMap.Tag = "ChoroplethMap"
        Me.rdoChoroplethMap.UseVisualStyleBackColor = False
        '
        'rdoHeatMap
        '
        resources.ApplyResources(Me.rdoHeatMap, "rdoHeatMap")
        Me.rdoHeatMap.BackColor = System.Drawing.SystemColors.Control
        Me.rdoHeatMap.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHeatMap.FlatAppearance.BorderSize = 2
        Me.rdoHeatMap.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHeatMap.Name = "rdoHeatMap"
        Me.rdoHeatMap.TabStop = True
        Me.rdoHeatMap.Tag = "HeatMap"
        Me.rdoHeatMap.UseVisualStyleBackColor = False
        '
        'lblLongitude
        '
        resources.ApplyResources(Me.lblLongitude, "lblLongitude")
        Me.lblLongitude.Name = "lblLongitude"
        '
        'lblLatitude
        '
        resources.ApplyResources(Me.lblLatitude, "lblLatitude")
        Me.lblLatitude.Name = "lblLatitude"
        '
        'lblFillChoropleth
        '
        resources.ApplyResources(Me.lblFillChoropleth, "lblFillChoropleth")
        Me.lblFillChoropleth.Name = "lblFillChoropleth"
        Me.lblFillChoropleth.Tag = "fill"
        '
        'lblGroup
        '
        resources.ApplyResources(Me.lblGroup, "lblGroup")
        Me.lblGroup.Name = "lblGroup"
        '
        'contextMenuStripOptions
        '
        Me.contextMenuStripOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemPlotOptions, Me.toolStripMenuItemTileOptions, Me.toolStripMenuItemPolygonOptions, Me.toolStripMenuItemJitterOptions})
        Me.contextMenuStripOptions.Name = "contextMenuStripOk"
        resources.ApplyResources(Me.contextMenuStripOptions, "contextMenuStripOptions")
        '
        'toolStripMenuItemPlotOptions
        '
        Me.toolStripMenuItemPlotOptions.Name = "toolStripMenuItemPlotOptions"
        resources.ApplyResources(Me.toolStripMenuItemPlotOptions, "toolStripMenuItemPlotOptions")
        '
        'toolStripMenuItemTileOptions
        '
        Me.toolStripMenuItemTileOptions.Name = "toolStripMenuItemTileOptions"
        resources.ApplyResources(Me.toolStripMenuItemTileOptions, "toolStripMenuItemTileOptions")
        '
        'toolStripMenuItemPolygonOptions
        '
        Me.toolStripMenuItemPolygonOptions.Name = "toolStripMenuItemPolygonOptions"
        resources.ApplyResources(Me.toolStripMenuItemPolygonOptions, "toolStripMenuItemPolygonOptions")
        '
        'toolStripMenuItemJitterOptions
        '
        Me.toolStripMenuItemJitterOptions.Name = "toolStripMenuItemJitterOptions"
        resources.ApplyResources(Me.toolStripMenuItemJitterOptions, "toolStripMenuItemJitterOptions")
        '
        'lblFacetBy
        '
        resources.ApplyResources(Me.lblFacetBy, "lblFacetBy")
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Tag = ""
        '
        'lblYvariable
        '
        resources.ApplyResources(Me.lblYvariable, "lblYvariable")
        Me.lblYvariable.Name = "lblYvariable"
        '
        'lblHeith
        '
        resources.ApplyResources(Me.lblHeith, "lblHeith")
        Me.lblHeith.Name = "lblHeith"
        '
        'lblWidth
        '
        resources.ApplyResources(Me.lblWidth, "lblWidth")
        Me.lblWidth.Name = "lblWidth"
        '
        'ucrChkJitter
        '
        resources.ApplyResources(Me.ucrChkJitter, "ucrChkJitter")
        Me.ucrChkJitter.Checked = False
        Me.ucrChkJitter.Name = "ucrChkJitter"
        '
        'ucrNudHeigth
        '
        resources.ApplyResources(Me.ucrNudHeigth, "ucrNudHeigth")
        Me.ucrNudHeigth.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHeigth.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHeigth.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudHeigth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHeigth.Name = "ucrNudHeigth"
        Me.ucrNudHeigth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudWidth
        '
        resources.ApplyResources(Me.ucrNudWidth, "ucrNudWidth")
        Me.ucrNudWidth.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWidth.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWidth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Name = "ucrNudWidth"
        Me.ucrNudWidth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverY
        '
        resources.ApplyResources(Me.ucrReceiverY, "ucrReceiverY")
        Me.ucrReceiverY.frmParent = Me
        Me.ucrReceiverY.Name = "ucrReceiverY"
        Me.ucrReceiverY.Selector = Nothing
        Me.ucrReceiverY.strNcFilePath = ""
        Me.ucrReceiverY.ucrSelector = Nothing
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputStation, "ucrInputStation")
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Name = "ucrInputStation"
        '
        'ucr1stFactorReceiver
        '
        resources.ApplyResources(Me.ucr1stFactorReceiver, "ucr1stFactorReceiver")
        Me.ucr1stFactorReceiver.frmParent = Me
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.strNcFilePath = ""
        Me.ucr1stFactorReceiver.ucrSelector = Nothing
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputLegendPosition, "ucrInputLegendPosition")
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        '
        'ucrChkLegend
        '
        resources.ApplyResources(Me.ucrChkLegend, "ucrChkLegend")
        Me.ucrChkLegend.Checked = False
        Me.ucrChkLegend.Name = "ucrChkLegend"
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.ContextMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.SplitMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.Tag = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrReceiverFill
        '
        resources.ApplyResources(Me.ucrReceiverFill, "ucrReceiverFill")
        Me.ucrReceiverFill.frmParent = Me
        Me.ucrReceiverFill.Name = "ucrReceiverFill"
        Me.ucrReceiverFill.Selector = Nothing
        Me.ucrReceiverFill.strNcFilePath = ""
        Me.ucrReceiverFill.ucrSelector = Nothing
        '
        'ucrSaveGraph
        '
        resources.ApplyResources(Me.ucrSaveGraph, "ucrSaveGraph")
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrPnlOptions
        '
        resources.ApplyResources(Me.ucrPnlOptions, "ucrPnlOptions")
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        '
        'ucrInputReorderValue
        '
        Me.ucrInputReorderValue.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputReorderValue, "ucrInputReorderValue")
        Me.ucrInputReorderValue.GetSetSelectedIndex = -1
        Me.ucrInputReorderValue.IsReadOnly = False
        Me.ucrInputReorderValue.Name = "ucrInputReorderValue"
        '
        'ucrHeatMapSelector
        '
        resources.ApplyResources(Me.ucrHeatMapSelector, "ucrHeatMapSelector")
        Me.ucrHeatMapSelector.bDropUnusedFilterLevels = False
        Me.ucrHeatMapSelector.bShowHiddenColumns = False
        Me.ucrHeatMapSelector.bUseCurrentFilter = True
        Me.ucrHeatMapSelector.Name = "ucrHeatMapSelector"
        '
        'ucrReceiverLongitude
        '
        resources.ApplyResources(Me.ucrReceiverLongitude, "ucrReceiverLongitude")
        Me.ucrReceiverLongitude.frmParent = Me
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'ucrReceiverLatitude
        '
        resources.ApplyResources(Me.ucrReceiverLatitude, "ucrReceiverLatitude")
        Me.ucrReceiverLatitude.frmParent = Me
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrReceiverFillChoropleth
        '
        resources.ApplyResources(Me.ucrReceiverFillChoropleth, "ucrReceiverFillChoropleth")
        Me.ucrReceiverFillChoropleth.frmParent = Me
        Me.ucrReceiverFillChoropleth.Name = "ucrReceiverFillChoropleth"
        Me.ucrReceiverFillChoropleth.Selector = Nothing
        Me.ucrReceiverFillChoropleth.strNcFilePath = ""
        Me.ucrReceiverFillChoropleth.ucrSelector = Nothing
        '
        'ucrInputReorderVariableX
        '
        Me.ucrInputReorderVariableX.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputReorderVariableX, "ucrInputReorderVariableX")
        Me.ucrInputReorderVariableX.GetSetSelectedIndex = -1
        Me.ucrInputReorderVariableX.IsReadOnly = False
        Me.ucrInputReorderVariableX.Name = "ucrInputReorderVariableX"
        '
        'ucrInputSize
        '
        Me.ucrInputSize.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputSize, "ucrInputSize")
        Me.ucrInputSize.GetSetSelectedIndex = -1
        Me.ucrInputSize.IsReadOnly = False
        Me.ucrInputSize.Name = "ucrInputSize"
        '
        'ucrInputPosition
        '
        Me.ucrInputPosition.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputPosition, "ucrInputPosition")
        Me.ucrInputPosition.GetSetSelectedIndex = -1
        Me.ucrInputPosition.IsReadOnly = False
        Me.ucrInputPosition.Name = "ucrInputPosition"
        '
        'ucrInputColour
        '
        Me.ucrInputColour.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputColour, "ucrInputColour")
        Me.ucrInputColour.GetSetSelectedIndex = -1
        Me.ucrInputColour.IsReadOnly = False
        Me.ucrInputColour.Name = "ucrInputColour"
        '
        'ucrReceiverX
        '
        resources.ApplyResources(Me.ucrReceiverX, "ucrReceiverX")
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrReceiverGroup
        '
        resources.ApplyResources(Me.ucrReceiverGroup, "ucrReceiverGroup")
        Me.ucrReceiverGroup.frmParent = Me
        Me.ucrReceiverGroup.Name = "ucrReceiverGroup"
        Me.ucrReceiverGroup.Selector = Nothing
        Me.ucrReceiverGroup.strNcFilePath = ""
        Me.ucrReceiverGroup.ucrSelector = Nothing
        '
        'ucrChkAddLabels
        '
        resources.ApplyResources(Me.ucrChkAddLabels, "ucrChkAddLabels")
        Me.ucrChkAddLabels.Checked = False
        Me.ucrChkAddLabels.Name = "ucrChkAddLabels"
        '
        'ucrChkPoints
        '
        resources.ApplyResources(Me.ucrChkPoints, "ucrChkPoints")
        Me.ucrChkPoints.Checked = False
        Me.ucrChkPoints.Name = "ucrChkPoints"
        '
        'ucrChkFlipCoordinates
        '
        resources.ApplyResources(Me.ucrChkFlipCoordinates, "ucrChkFlipCoordinates")
        Me.ucrChkFlipCoordinates.Checked = False
        Me.ucrChkFlipCoordinates.Name = "ucrChkFlipCoordinates"
        '
        'grpColour
        '
        Me.grpColour.Controls.Add(Me.lblValue)
        Me.grpColour.Controls.Add(Me.lblTo)
        Me.grpColour.Controls.Add(Me.ucrInputValue)
        Me.grpColour.Controls.Add(Me.lblFrom)
        Me.grpColour.Controls.Add(Me.rdoViridis)
        Me.grpColour.Controls.Add(Me.ucrColourTo)
        Me.grpColour.Controls.Add(Me.ucrColourFrom)
        Me.grpColour.Controls.Add(Me.ucrInputPalette)
        Me.grpColour.Controls.Add(Me.rdoPalette)
        Me.grpColour.Controls.Add(Me.rdoGradient)
        Me.grpColour.Controls.Add(Me.ucrPnlColour)
        Me.grpColour.Controls.Add(Me.ucrInputColourPalette)
        resources.ApplyResources(Me.grpColour, "grpColour")
        Me.grpColour.Name = "grpColour"
        Me.grpColour.TabStop = False
        '
        'lblValue
        '
        resources.ApplyResources(Me.lblValue, "lblValue")
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Tag = ""
        '
        'ucrInputValue
        '
        Me.ucrInputValue.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputValue, "ucrInputValue")
        Me.ucrInputValue.IsMultiline = False
        Me.ucrInputValue.IsReadOnly = False
        Me.ucrInputValue.Name = "ucrInputValue"
        '
        'lblTo
        '
        resources.ApplyResources(Me.lblTo, "lblTo")
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Tag = "fill"
        '
        'lblFrom
        '
        resources.ApplyResources(Me.lblFrom, "lblFrom")
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Tag = ""
        '
        'rdoViridis
        '
        resources.ApplyResources(Me.rdoViridis, "rdoViridis")
        Me.rdoViridis.Name = "rdoViridis"
        Me.rdoViridis.TabStop = True
        Me.rdoViridis.UseVisualStyleBackColor = True
        '
        'ucrColourTo
        '
        Me.ucrColourTo.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrColourTo, "ucrColourTo")
        Me.ucrColourTo.GetSetSelectedIndex = -1
        Me.ucrColourTo.IsReadOnly = False
        Me.ucrColourTo.Name = "ucrColourTo"
        '
        'ucrColourFrom
        '
        Me.ucrColourFrom.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrColourFrom, "ucrColourFrom")
        Me.ucrColourFrom.GetSetSelectedIndex = -1
        Me.ucrColourFrom.IsReadOnly = False
        Me.ucrColourFrom.Name = "ucrColourFrom"
        '
        'ucrInputPalette
        '
        Me.ucrInputPalette.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputPalette, "ucrInputPalette")
        Me.ucrInputPalette.GetSetSelectedIndex = -1
        Me.ucrInputPalette.IsReadOnly = False
        Me.ucrInputPalette.Name = "ucrInputPalette"
        '
        'rdoPalette
        '
        resources.ApplyResources(Me.rdoPalette, "rdoPalette")
        Me.rdoPalette.Name = "rdoPalette"
        Me.rdoPalette.TabStop = True
        Me.rdoPalette.UseVisualStyleBackColor = True
        '
        'rdoGradient
        '
        resources.ApplyResources(Me.rdoGradient, "rdoGradient")
        Me.rdoGradient.Name = "rdoGradient"
        Me.rdoGradient.TabStop = True
        Me.rdoGradient.UseVisualStyleBackColor = True
        '
        'ucrPnlColour
        '
        resources.ApplyResources(Me.ucrPnlColour, "ucrPnlColour")
        Me.ucrPnlColour.Name = "ucrPnlColour"
        '
        'ucrInputColourPalette
        '
        Me.ucrInputColourPalette.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputColourPalette, "ucrInputColourPalette")
        Me.ucrInputColourPalette.GetSetSelectedIndex = -1
        Me.ucrInputColourPalette.IsReadOnly = False
        Me.ucrInputColourPalette.Name = "ucrInputColourPalette"
        '
        'dlgHeatMapPlot
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpColour)
        Me.Controls.Add(Me.ucrChkJitter)
        Me.Controls.Add(Me.lblHeith)
        Me.Controls.Add(Me.ucrNudHeigth)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.ucrNudWidth)
        Me.Controls.Add(Me.lblYvariable)
        Me.Controls.Add(Me.ucrReceiverY)
        Me.Controls.Add(Me.ucrInputStation)
        Me.Controls.Add(Me.ucr1stFactorReceiver)
        Me.Controls.Add(Me.lblFacetBy)
        Me.Controls.Add(Me.ucrInputLegendPosition)
        Me.Controls.Add(Me.ucrChkLegend)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblGroup)
        Me.Controls.Add(Me.lblFillChoropleth)
        Me.Controls.Add(Me.rdoChoroplethMap)
        Me.Controls.Add(Me.rdoHeatMap)
        Me.Controls.Add(Me.lblFill)
        Me.Controls.Add(Me.ucrReceiverFill)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrInputReorderValue)
        Me.Controls.Add(Me.ucrHeatMapSelector)
        Me.Controls.Add(Me.lblLongitude)
        Me.Controls.Add(Me.ucrReceiverLongitude)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrReceiverLatitude)
        Me.Controls.Add(Me.lblLatitude)
        Me.Controls.Add(Me.lblReorderValue)
        Me.Controls.Add(Me.ucrReceiverFillChoropleth)
        Me.Controls.Add(Me.ucrInputReorderVariableX)
        Me.Controls.Add(Me.ucrInputSize)
        Me.Controls.Add(Me.lblLabelPosition)
        Me.Controls.Add(Me.ucrInputPosition)
        Me.Controls.Add(Me.lblLabelColour)
        Me.Controls.Add(Me.ucrInputColour)
        Me.Controls.Add(Me.lblLabelSize)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.lblReorderVariableX)
        Me.Controls.Add(Me.ucrReceiverGroup)
        Me.Controls.Add(Me.ucrChkAddLabels)
        Me.Controls.Add(Me.ucrChkPoints)
        Me.Controls.Add(Me.ucrChkFlipCoordinates)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgHeatMapPlot"
        Me.contextMenuStripOptions.ResumeLayout(False)
        Me.grpColour.ResumeLayout(False)
        Me.grpColour.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrHeatMapSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents lblXVariable As Label
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents lblFill As Label
    Friend WithEvents ucrReceiverFill As ucrReceiverSingle
    Friend WithEvents ucrChkAddLabels As ucrCheck
    Friend WithEvents lblLabelPosition As Label
    Friend WithEvents ucrInputPosition As ucrInputComboBox
    Friend WithEvents lblLabelColour As Label
    Friend WithEvents ucrInputColour As ucrInputComboBox
    Friend WithEvents ucrInputSize As ucrInputComboBox
    Friend WithEvents lblLabelSize As Label
    Friend WithEvents lblReorderVariableX As Label
    Friend WithEvents ucrInputReorderVariableX As ucrInputComboBox
    Friend WithEvents ucrInputReorderValue As ucrInputComboBox
    Friend WithEvents lblReorderValue As Label
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents rdoChoroplethMap As RadioButton
    Friend WithEvents rdoHeatMap As RadioButton
    Friend WithEvents ucrChkFlipCoordinates As ucrCheck
    Friend WithEvents lblLongitude As Label
    Friend WithEvents ucrReceiverLongitude As ucrReceiverSingle
    Friend WithEvents lblLatitude As Label
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents lblFillChoropleth As Label
    Friend WithEvents ucrReceiverFillChoropleth As ucrReceiverSingle
    Friend WithEvents lblGroup As Label
    Friend WithEvents ucrReceiverGroup As ucrReceiverSingle
    Friend WithEvents ucrChkPoints As ucrCheck
    Friend WithEvents cmdOptions As ucrSplitButton
    Friend WithEvents contextMenuStripOptions As ContextMenuStrip
    Friend WithEvents toolStripMenuItemPlotOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemTileOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemPolygonOptions As ToolStripMenuItem
    Friend WithEvents ucrInputStation As ucrInputComboBox
    Friend WithEvents ucr1stFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblFacetBy As Label
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents ucrChkLegend As ucrCheck
    Friend WithEvents lblYvariable As Label
    Friend WithEvents ucrReceiverY As ucrReceiverSingle
    Friend WithEvents lblHeith As Label
    Friend WithEvents ucrNudHeigth As ucrNud
    Friend WithEvents lblWidth As Label
    Friend WithEvents ucrNudWidth As ucrNud
    Friend WithEvents ucrChkJitter As ucrCheck
    Friend WithEvents toolStripMenuItemJitterOptions As ToolStripMenuItem
    Friend WithEvents ucrColourFrom As ucrColors
    Friend WithEvents ucrColourTo As ucrColors
    Friend WithEvents rdoGradient As RadioButton
    Friend WithEvents grpColour As GroupBox
    Friend WithEvents rdoViridis As RadioButton
    Friend WithEvents ucrInputPalette As ucrInputComboBox
    Friend WithEvents rdoPalette As RadioButton
    Friend WithEvents ucrPnlColour As UcrPanel
    Friend WithEvents ucrInputColourPalette As ucrInputComboBox
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblValue As Label
    Friend WithEvents ucrInputValue As ucrInputTextBox
End Class