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
Partial Class dlgGeneralForGraphics
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
        Me.grpAesthetics = New System.Windows.Forms.GroupBox()
        Me.lblYVariable = New System.Windows.Forms.Label()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.ContextMenuPackagesList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ListBaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeomtextpathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GGallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgaltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgdendroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgeffectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgfittextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgforceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgformulaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgfortifyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgmcmcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgmosaicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgplotifyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgpmiscToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgpubrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgrepelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgridgesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgsciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgsignifToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgstanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgtextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgthemesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GgwordbuildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.contextMenuStripOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuItemPlotOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemFacets = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemLayers = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemTitles = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemXaxis = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemYaxis = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemThemes = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemCoordinates = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemColour = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemAnnotation = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblFillidentity = New System.Windows.Forms.Label()
        Me.lblColouridentity = New System.Windows.Forms.Label()
        Me.grpLegend = New System.Windows.Forms.GroupBox()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucr1stFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrChkColour = New instat.ucrCheck()
        Me.ucrChkLegend = New instat.ucrCheck()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrInputAddLegendRibbon = New instat.ucrInputComboBox()
        Me.ucrChkFill = New instat.ucrCheck()
        Me.ucrInputAddLegendLine = New instat.ucrInputComboBox()
        Me.ucrInputAddCode = New instat.ucrInputComboBox()
        Me.ucrChkAddCode = New instat.ucrCheck()
        Me.cmdOptions = New instat.ucrSplitButton()
        Me.cmdRHelp = New instat.ucrSplitButton()
        Me.ucrChkUseasNumeric = New instat.ucrCheck()
        Me.ucrReceiverY = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrLabelReceiver = New instat.ucrReceiverSingle()
        Me.ucrColourReceiver = New instat.ucrReceiverSingle()
        Me.ucrFillReceiver = New instat.ucrReceiverSingle()
        Me.ucrChkFlipCoordinates = New instat.ucrCheck()
        Me.ucrSave = New instat.ucrSave()
        Me.ucrGraphicsSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrAdditionalLayers = New instat.ucrAdditionalLayers()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpAesthetics.SuspendLayout()
        Me.ContextMenuPackagesList.SuspendLayout()
        Me.contextMenuStripOptions.SuspendLayout()
        Me.grpLegend.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAesthetics
        '
        Me.grpAesthetics.Controls.Add(Me.ucrChkUseasNumeric)
        Me.grpAesthetics.Controls.Add(Me.ucrReceiverY)
        Me.grpAesthetics.Controls.Add(Me.lblYVariable)
        Me.grpAesthetics.Controls.Add(Me.lblXVariable)
        Me.grpAesthetics.Controls.Add(Me.ucrReceiverX)
        Me.grpAesthetics.Controls.Add(Me.lblLabel)
        Me.grpAesthetics.Controls.Add(Me.ucrLabelReceiver)
        Me.grpAesthetics.Controls.Add(Me.lblColour)
        Me.grpAesthetics.Controls.Add(Me.ucrColourReceiver)
        Me.grpAesthetics.Controls.Add(Me.lblFill)
        Me.grpAesthetics.Controls.Add(Me.ucrFillReceiver)
        Me.grpAesthetics.Location = New System.Drawing.Point(313, 31)
        Me.grpAesthetics.Name = "grpAesthetics"
        Me.grpAesthetics.Size = New System.Drawing.Size(158, 257)
        Me.grpAesthetics.TabIndex = 23
        Me.grpAesthetics.TabStop = False
        Me.grpAesthetics.Text = "Aesthetics:"
        '
        'lblYVariable
        '
        Me.lblYVariable.AutoSize = True
        Me.lblYVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYVariable.Location = New System.Drawing.Point(26, 23)
        Me.lblYVariable.Name = "lblYVariable"
        Me.lblYVariable.Size = New System.Drawing.Size(58, 13)
        Me.lblYVariable.TabIndex = 0
        Me.lblYVariable.Tag = "Y_Variable:"
        Me.lblYVariable.Text = "Y Variable:"
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXVariable.Location = New System.Drawing.Point(26, 67)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(58, 13)
        Me.lblXVariable.TabIndex = 2
        Me.lblXVariable.Tag = "X_Variable:"
        Me.lblXVariable.Text = "X Variable:"
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabel.Location = New System.Drawing.Point(27, 213)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(36, 13)
        Me.lblLabel.TabIndex = 8
        Me.lblLabel.Tag = "Label:"
        Me.lblLabel.Text = "Label:"
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColour.Location = New System.Drawing.Point(27, 173)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(40, 13)
        Me.lblColour.TabIndex = 6
        Me.lblColour.Tag = "Fill_Colour:"
        Me.lblColour.Text = "Colour:"
        '
        'lblFill
        '
        Me.lblFill.AutoSize = True
        Me.lblFill.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFill.Location = New System.Drawing.Point(27, 134)
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Size = New System.Drawing.Size(22, 13)
        Me.lblFill.TabIndex = 4
        Me.lblFill.Tag = "Fill_Colour:"
        Me.lblFill.Text = "Fill:"
        '
        'ContextMenuPackagesList
        '
        Me.ContextMenuPackagesList.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuPackagesList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListBaseToolStripMenuItem, Me.GeomtextpathToolStripMenuItem, Me.GGallyToolStripMenuItem, Me.GgaltToolStripMenuItem, Me.GgdendroToolStripMenuItem, Me.GgeffectsToolStripMenuItem, Me.GgfittextToolStripMenuItem, Me.GgforceToolStripMenuItem, Me.GgformulaToolStripMenuItem, Me.GgfortifyToolStripMenuItem, Me.GgmcmcToolStripMenuItem, Me.GgmosaicToolStripMenuItem, Me.GgplotifyToolStripMenuItem, Me.GgpmiscToolStripMenuItem, Me.GgppToolStripMenuItem, Me.GgpubrToolStripMenuItem, Me.GgrepelToolStripMenuItem, Me.GgridgesToolStripMenuItem, Me.GgsciToolStripMenuItem, Me.GgsignifToolStripMenuItem, Me.GgstanceToolStripMenuItem, Me.GgtextToolStripMenuItem, Me.GgthemesToolStripMenuItem, Me.GgwordbuildToolStripMenuItem})
        Me.ContextMenuPackagesList.Name = "ContextMenuStrip1"
        Me.ContextMenuPackagesList.Size = New System.Drawing.Size(149, 532)
        '
        'ListBaseToolStripMenuItem
        '
        Me.ListBaseToolStripMenuItem.Name = "ListBaseToolStripMenuItem"
        Me.ListBaseToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ListBaseToolStripMenuItem.Text = "ggplot2"
        '
        'GeomtextpathToolStripMenuItem
        '
        Me.GeomtextpathToolStripMenuItem.Name = "GeomtextpathToolStripMenuItem"
        Me.GeomtextpathToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GeomtextpathToolStripMenuItem.Text = "geomtextpath"
        '
        'GGallyToolStripMenuItem
        '
        Me.GGallyToolStripMenuItem.Name = "GGallyToolStripMenuItem"
        Me.GGallyToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GGallyToolStripMenuItem.Text = "GGally"
        '
        'GgaltToolStripMenuItem
        '
        Me.GgaltToolStripMenuItem.Name = "GgaltToolStripMenuItem"
        Me.GgaltToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgaltToolStripMenuItem.Text = "ggalt"
        '
        'GgdendroToolStripMenuItem
        '
        Me.GgdendroToolStripMenuItem.Name = "GgdendroToolStripMenuItem"
        Me.GgdendroToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgdendroToolStripMenuItem.Text = "ggdendro"
        '
        'GgeffectsToolStripMenuItem
        '
        Me.GgeffectsToolStripMenuItem.Name = "GgeffectsToolStripMenuItem"
        Me.GgeffectsToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgeffectsToolStripMenuItem.Text = "ggeffects"
        '
        'GgfittextToolStripMenuItem
        '
        Me.GgfittextToolStripMenuItem.Name = "GgfittextToolStripMenuItem"
        Me.GgfittextToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgfittextToolStripMenuItem.Text = "ggfittext"
        '
        'GgforceToolStripMenuItem
        '
        Me.GgforceToolStripMenuItem.Name = "GgforceToolStripMenuItem"
        Me.GgforceToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgforceToolStripMenuItem.Text = "ggforce"
        '
        'GgformulaToolStripMenuItem
        '
        Me.GgformulaToolStripMenuItem.Name = "GgformulaToolStripMenuItem"
        Me.GgformulaToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgformulaToolStripMenuItem.Text = "ggformula"
        '
        'GgfortifyToolStripMenuItem
        '
        Me.GgfortifyToolStripMenuItem.Name = "GgfortifyToolStripMenuItem"
        Me.GgfortifyToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgfortifyToolStripMenuItem.Text = "ggfortify"
        '
        'GgmcmcToolStripMenuItem
        '
        Me.GgmcmcToolStripMenuItem.Name = "GgmcmcToolStripMenuItem"
        Me.GgmcmcToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgmcmcToolStripMenuItem.Text = "ggmcmc"
        '
        'GgmosaicToolStripMenuItem
        '
        Me.GgmosaicToolStripMenuItem.Name = "GgmosaicToolStripMenuItem"
        Me.GgmosaicToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgmosaicToolStripMenuItem.Text = "ggmosaic"
        '
        'GgplotifyToolStripMenuItem
        '
        Me.GgplotifyToolStripMenuItem.Name = "GgplotifyToolStripMenuItem"
        Me.GgplotifyToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgplotifyToolStripMenuItem.Text = "ggplotify"
        '
        'GgpmiscToolStripMenuItem
        '
        Me.GgpmiscToolStripMenuItem.Name = "GgpmiscToolStripMenuItem"
        Me.GgpmiscToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgpmiscToolStripMenuItem.Text = "ggpmisc"
        '
        'GgppToolStripMenuItem
        '
        Me.GgppToolStripMenuItem.Name = "GgppToolStripMenuItem"
        Me.GgppToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgppToolStripMenuItem.Text = "ggpp"
        '
        'GgpubrToolStripMenuItem
        '
        Me.GgpubrToolStripMenuItem.Name = "GgpubrToolStripMenuItem"
        Me.GgpubrToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgpubrToolStripMenuItem.Text = "ggpubr"
        '
        'GgrepelToolStripMenuItem
        '
        Me.GgrepelToolStripMenuItem.Name = "GgrepelToolStripMenuItem"
        Me.GgrepelToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgrepelToolStripMenuItem.Text = "ggrepel"
        '
        'GgridgesToolStripMenuItem
        '
        Me.GgridgesToolStripMenuItem.Name = "GgridgesToolStripMenuItem"
        Me.GgridgesToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgridgesToolStripMenuItem.Text = "ggridges"
        '
        'GgsciToolStripMenuItem
        '
        Me.GgsciToolStripMenuItem.Name = "GgsciToolStripMenuItem"
        Me.GgsciToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgsciToolStripMenuItem.Text = "ggsci"
        '
        'GgsignifToolStripMenuItem
        '
        Me.GgsignifToolStripMenuItem.Name = "GgsignifToolStripMenuItem"
        Me.GgsignifToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgsignifToolStripMenuItem.Text = "ggsignif"
        '
        'GgstanceToolStripMenuItem
        '
        Me.GgstanceToolStripMenuItem.Name = "GgstanceToolStripMenuItem"
        Me.GgstanceToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgstanceToolStripMenuItem.Text = "ggstance"
        '
        'GgtextToolStripMenuItem
        '
        Me.GgtextToolStripMenuItem.Name = "GgtextToolStripMenuItem"
        Me.GgtextToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgtextToolStripMenuItem.Text = "ggtext"
        '
        'GgthemesToolStripMenuItem
        '
        Me.GgthemesToolStripMenuItem.Name = "GgthemesToolStripMenuItem"
        Me.GgthemesToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgthemesToolStripMenuItem.Text = "ggthemes"
        '
        'GgwordbuildToolStripMenuItem
        '
        Me.GgwordbuildToolStripMenuItem.Name = "GgwordbuildToolStripMenuItem"
        Me.GgwordbuildToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GgwordbuildToolStripMenuItem.Text = " ggwordbuild"
        '
        'contextMenuStripOptions
        '
        Me.contextMenuStripOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemPlotOptions, Me.toolStripMenuItemFacets, Me.toolStripMenuItemLayers, Me.toolStripMenuItemTitles, Me.toolStripMenuItemXaxis, Me.toolStripMenuItemYaxis, Me.toolStripMenuItemThemes, Me.toolStripMenuItemCoordinates, Me.toolStripMenuItemColour, Me.toolStripMenuItemAnnotation})
        Me.contextMenuStripOptions.Name = "contextMenuStripOk"
        Me.contextMenuStripOptions.Size = New System.Drawing.Size(141, 224)
        '
        'toolStripMenuItemPlotOptions
        '
        Me.toolStripMenuItemPlotOptions.Name = "toolStripMenuItemPlotOptions"
        Me.toolStripMenuItemPlotOptions.Size = New System.Drawing.Size(140, 22)
        Me.toolStripMenuItemPlotOptions.Text = "Plot Options"
        '
        'toolStripMenuItemFacets
        '
        Me.toolStripMenuItemFacets.Name = "toolStripMenuItemFacets"
        Me.toolStripMenuItemFacets.Size = New System.Drawing.Size(140, 22)
        Me.toolStripMenuItemFacets.Text = "Facets"
        '
        'toolStripMenuItemLayers
        '
        Me.toolStripMenuItemLayers.Name = "toolStripMenuItemLayers"
        Me.toolStripMenuItemLayers.Size = New System.Drawing.Size(140, 22)
        Me.toolStripMenuItemLayers.Text = "Layers"
        '
        'toolStripMenuItemTitles
        '
        Me.toolStripMenuItemTitles.Name = "toolStripMenuItemTitles"
        Me.toolStripMenuItemTitles.Size = New System.Drawing.Size(140, 22)
        Me.toolStripMenuItemTitles.Text = "Titles"
        '
        'toolStripMenuItemXaxis
        '
        Me.toolStripMenuItemXaxis.Name = "toolStripMenuItemXaxis"
        Me.toolStripMenuItemXaxis.Size = New System.Drawing.Size(140, 22)
        Me.toolStripMenuItemXaxis.Text = "X-Axis"
        '
        'toolStripMenuItemYaxis
        '
        Me.toolStripMenuItemYaxis.Name = "toolStripMenuItemYaxis"
        Me.toolStripMenuItemYaxis.Size = New System.Drawing.Size(140, 22)
        Me.toolStripMenuItemYaxis.Text = "Y-Axis"
        '
        'toolStripMenuItemThemes
        '
        Me.toolStripMenuItemThemes.Name = "toolStripMenuItemThemes"
        Me.toolStripMenuItemThemes.Size = New System.Drawing.Size(140, 22)
        Me.toolStripMenuItemThemes.Text = "Themes"
        '
        'toolStripMenuItemCoordinates
        '
        Me.toolStripMenuItemCoordinates.Name = "toolStripMenuItemCoordinates"
        Me.toolStripMenuItemCoordinates.Size = New System.Drawing.Size(140, 22)
        Me.toolStripMenuItemCoordinates.Text = "Coordinates"
        '
        'toolStripMenuItemColour
        '
        Me.toolStripMenuItemColour.Name = "toolStripMenuItemColour"
        Me.toolStripMenuItemColour.Size = New System.Drawing.Size(140, 22)
        Me.toolStripMenuItemColour.Text = "Colour"
        '
        'toolStripMenuItemAnnotation
        '
        Me.toolStripMenuItemAnnotation.Name = "toolStripMenuItemAnnotation"
        Me.toolStripMenuItemAnnotation.Size = New System.Drawing.Size(140, 22)
        Me.toolStripMenuItemAnnotation.Text = "Annotation"
        '
        'lblFillidentity
        '
        Me.lblFillidentity.AutoSize = True
        Me.lblFillidentity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFillidentity.Location = New System.Drawing.Point(211, 22)
        Me.lblFillidentity.Name = "lblFillidentity"
        Me.lblFillidentity.Size = New System.Drawing.Size(41, 13)
        Me.lblFillidentity.TabIndex = 224
        Me.lblFillidentity.Text = "Labels:"
        '
        'lblColouridentity
        '
        Me.lblColouridentity.AutoSize = True
        Me.lblColouridentity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColouridentity.Location = New System.Drawing.Point(211, 48)
        Me.lblColouridentity.Name = "lblColouridentity"
        Me.lblColouridentity.Size = New System.Drawing.Size(41, 13)
        Me.lblColouridentity.TabIndex = 223
        Me.lblColouridentity.Text = "Labels:"
        '
        'grpLegend
        '
        Me.grpLegend.Controls.Add(Me.ucrInputStation)
        Me.grpLegend.Controls.Add(Me.ucr1stFactorReceiver)
        Me.grpLegend.Controls.Add(Me.lblFacetBy)
        Me.grpLegend.Controls.Add(Me.ucrChkColour)
        Me.grpLegend.Controls.Add(Me.ucrChkLegend)
        Me.grpLegend.Controls.Add(Me.ucrInputLegendPosition)
        Me.grpLegend.Controls.Add(Me.ucrInputAddLegendRibbon)
        Me.grpLegend.Controls.Add(Me.ucrChkFill)
        Me.grpLegend.Controls.Add(Me.ucrInputAddLegendLine)
        Me.grpLegend.Controls.Add(Me.lblColouridentity)
        Me.grpLegend.Controls.Add(Me.lblFillidentity)
        Me.grpLegend.Location = New System.Drawing.Point(6, 390)
        Me.grpLegend.Name = "grpLegend"
        Me.grpLegend.Size = New System.Drawing.Size(469, 118)
        Me.grpLegend.TabIndex = 227
        Me.grpLegend.TabStop = False
        Me.grpLegend.Text = "Legend"
        '
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetBy.Location = New System.Drawing.Point(246, 72)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(52, 13)
        Me.lblFacetBy.TabIndex = 227
        Me.lblFacetBy.Tag = ""
        Me.lblFacetBy.Text = "Facet By:"
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Location = New System.Drawing.Point(358, 87)
        Me.ucrInputStation.Name = "ucrInputStation"
        Me.ucrInputStation.Size = New System.Drawing.Size(86, 21)
        Me.ucrInputStation.TabIndex = 229
        '
        'ucr1stFactorReceiver
        '
        Me.ucr1stFactorReceiver.AutoSize = True
        Me.ucr1stFactorReceiver.frmParent = Nothing
        Me.ucr1stFactorReceiver.Location = New System.Drawing.Point(246, 87)
        Me.ucr1stFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.Size = New System.Drawing.Size(109, 26)
        Me.ucr1stFactorReceiver.strNcFilePath = ""
        Me.ucr1stFactorReceiver.TabIndex = 228
        Me.ucr1stFactorReceiver.ucrSelector = Nothing
        '
        'ucrChkColour
        '
        Me.ucrChkColour.AutoSize = True
        Me.ucrChkColour.Checked = False
        Me.ucrChkColour.Location = New System.Drawing.Point(6, 55)
        Me.ucrChkColour.Name = "ucrChkColour"
        Me.ucrChkColour.Size = New System.Drawing.Size(147, 23)
        Me.ucrChkColour.TabIndex = 222
        '
        'ucrChkLegend
        '
        Me.ucrChkLegend.AutoSize = True
        Me.ucrChkLegend.Checked = False
        Me.ucrChkLegend.Location = New System.Drawing.Point(6, 87)
        Me.ucrChkLegend.Name = "ucrChkLegend"
        Me.ucrChkLegend.Size = New System.Drawing.Size(98, 24)
        Me.ucrChkLegend.TabIndex = 14
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(107, 87)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(125, 21)
        Me.ucrInputLegendPosition.TabIndex = 15
        '
        'ucrInputAddLegendRibbon
        '
        Me.ucrInputAddLegendRibbon.AddQuotesIfUnrecognised = True
        Me.ucrInputAddLegendRibbon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputAddLegendRibbon.GetSetSelectedIndex = -1
        Me.ucrInputAddLegendRibbon.IsReadOnly = False
        Me.ucrInputAddLegendRibbon.Location = New System.Drawing.Point(261, 16)
        Me.ucrInputAddLegendRibbon.Name = "ucrInputAddLegendRibbon"
        Me.ucrInputAddLegendRibbon.Size = New System.Drawing.Size(183, 23)
        Me.ucrInputAddLegendRibbon.TabIndex = 226
        '
        'ucrChkFill
        '
        Me.ucrChkFill.AutoSize = True
        Me.ucrChkFill.Checked = False
        Me.ucrChkFill.Location = New System.Drawing.Point(6, 25)
        Me.ucrChkFill.Name = "ucrChkFill"
        Me.ucrChkFill.Size = New System.Drawing.Size(147, 23)
        Me.ucrChkFill.TabIndex = 221
        '
        'ucrInputAddLegendLine
        '
        Me.ucrInputAddLegendLine.AddQuotesIfUnrecognised = True
        Me.ucrInputAddLegendLine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputAddLegendLine.GetSetSelectedIndex = -1
        Me.ucrInputAddLegendLine.IsReadOnly = False
        Me.ucrInputAddLegendLine.Location = New System.Drawing.Point(261, 45)
        Me.ucrInputAddLegendLine.Name = "ucrInputAddLegendLine"
        Me.ucrInputAddLegendLine.Size = New System.Drawing.Size(183, 23)
        Me.ucrInputAddLegendLine.TabIndex = 225
        '
        'ucrInputAddCode
        '
        Me.ucrInputAddCode.AddQuotesIfUnrecognised = True
        Me.ucrInputAddCode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputAddCode.GetSetSelectedIndex = -1
        Me.ucrInputAddCode.IsReadOnly = False
        Me.ucrInputAddCode.Location = New System.Drawing.Point(159, 367)
        Me.ucrInputAddCode.Name = "ucrInputAddCode"
        Me.ucrInputAddCode.Size = New System.Drawing.Size(316, 21)
        Me.ucrInputAddCode.TabIndex = 218
        '
        'ucrChkAddCode
        '
        Me.ucrChkAddCode.AutoSize = True
        Me.ucrChkAddCode.Checked = False
        Me.ucrChkAddCode.Location = New System.Drawing.Point(159, 347)
        Me.ucrChkAddCode.Name = "ucrChkAddCode"
        Me.ucrChkAddCode.Size = New System.Drawing.Size(175, 23)
        Me.ucrChkAddCode.TabIndex = 217
        '
        'cmdOptions
        '
        Me.cmdOptions.AutoSize = True
        Me.cmdOptions.ContextMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.Location = New System.Drawing.Point(6, 359)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(128, 25)
        Me.cmdOptions.SplitMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.TabIndex = 216
        Me.cmdOptions.Tag = "Plot Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdRHelp
        '
        Me.cmdRHelp.AutoSize = True
        Me.cmdRHelp.ContextMenuStrip = Me.ContextMenuPackagesList
        Me.cmdRHelp.Location = New System.Drawing.Point(368, 510)
        Me.cmdRHelp.Name = "cmdRHelp"
        Me.cmdRHelp.Size = New System.Drawing.Size(91, 25)
        Me.cmdRHelp.SplitMenuStrip = Me.ContextMenuPackagesList
        Me.cmdRHelp.TabIndex = 213
        Me.cmdRHelp.Text = "R Help"
        Me.cmdRHelp.UseVisualStyleBackColor = True
        '
        'ucrChkUseasNumeric
        '
        Me.ucrChkUseasNumeric.AutoSize = True
        Me.ucrChkUseasNumeric.Checked = False
        Me.ucrChkUseasNumeric.Location = New System.Drawing.Point(24, 107)
        Me.ucrChkUseasNumeric.Name = "ucrChkUseasNumeric"
        Me.ucrChkUseasNumeric.Size = New System.Drawing.Size(126, 24)
        Me.ucrChkUseasNumeric.TabIndex = 4
        '
        'ucrReceiverY
        '
        Me.ucrReceiverY.AutoSize = True
        Me.ucrReceiverY.frmParent = Nothing
        Me.ucrReceiverY.Location = New System.Drawing.Point(24, 36)
        Me.ucrReceiverY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverY.Name = "ucrReceiverY"
        Me.ucrReceiverY.Selector = Nothing
        Me.ucrReceiverY.Size = New System.Drawing.Size(125, 20)
        Me.ucrReceiverY.strNcFilePath = ""
        Me.ucrReceiverY.TabIndex = 1
        Me.ucrReceiverY.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.AutoSize = True
        Me.ucrReceiverX.frmParent = Nothing
        Me.ucrReceiverX.Location = New System.Drawing.Point(24, 81)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(125, 27)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 3
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrLabelReceiver
        '
        Me.ucrLabelReceiver.AutoSize = True
        Me.ucrLabelReceiver.frmParent = Nothing
        Me.ucrLabelReceiver.Location = New System.Drawing.Point(25, 229)
        Me.ucrLabelReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrLabelReceiver.Name = "ucrLabelReceiver"
        Me.ucrLabelReceiver.Selector = Nothing
        Me.ucrLabelReceiver.Size = New System.Drawing.Size(125, 25)
        Me.ucrLabelReceiver.strNcFilePath = ""
        Me.ucrLabelReceiver.TabIndex = 9
        Me.ucrLabelReceiver.ucrSelector = Nothing
        '
        'ucrColourReceiver
        '
        Me.ucrColourReceiver.AutoSize = True
        Me.ucrColourReceiver.frmParent = Nothing
        Me.ucrColourReceiver.Location = New System.Drawing.Point(25, 189)
        Me.ucrColourReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrColourReceiver.Name = "ucrColourReceiver"
        Me.ucrColourReceiver.Selector = Nothing
        Me.ucrColourReceiver.Size = New System.Drawing.Size(125, 25)
        Me.ucrColourReceiver.strNcFilePath = ""
        Me.ucrColourReceiver.TabIndex = 7
        Me.ucrColourReceiver.ucrSelector = Nothing
        '
        'ucrFillReceiver
        '
        Me.ucrFillReceiver.AutoSize = True
        Me.ucrFillReceiver.frmParent = Nothing
        Me.ucrFillReceiver.Location = New System.Drawing.Point(25, 150)
        Me.ucrFillReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFillReceiver.Name = "ucrFillReceiver"
        Me.ucrFillReceiver.Selector = Nothing
        Me.ucrFillReceiver.Size = New System.Drawing.Size(125, 25)
        Me.ucrFillReceiver.strNcFilePath = ""
        Me.ucrFillReceiver.TabIndex = 5
        Me.ucrFillReceiver.ucrSelector = Nothing
        '
        'ucrChkFlipCoordinates
        '
        Me.ucrChkFlipCoordinates.AutoSize = True
        Me.ucrChkFlipCoordinates.Checked = False
        Me.ucrChkFlipCoordinates.Location = New System.Drawing.Point(313, 303)
        Me.ucrChkFlipCoordinates.Name = "ucrChkFlipCoordinates"
        Me.ucrChkFlipCoordinates.Size = New System.Drawing.Size(158, 24)
        Me.ucrChkFlipCoordinates.TabIndex = 13
        '
        'ucrSave
        '
        Me.ucrSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSave.Location = New System.Drawing.Point(6, 511)
        Me.ucrSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSave.Name = "ucrSave"
        Me.ucrSave.Size = New System.Drawing.Size(282, 24)
        Me.ucrSave.TabIndex = 16
        '
        'ucrGraphicsSelector
        '
        Me.ucrGraphicsSelector.AutoSize = True
        Me.ucrGraphicsSelector.bDropUnusedFilterLevels = False
        Me.ucrGraphicsSelector.bShowHiddenColumns = False
        Me.ucrGraphicsSelector.bUseCurrentFilter = True
        Me.ucrGraphicsSelector.Location = New System.Drawing.Point(6, 4)
        Me.ucrGraphicsSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrGraphicsSelector.Name = "ucrGraphicsSelector"
        Me.ucrGraphicsSelector.Size = New System.Drawing.Size(226, 185)
        Me.ucrGraphicsSelector.TabIndex = 0
        '
        'ucrAdditionalLayers
        '
        Me.ucrAdditionalLayers.AutoSize = True
        Me.ucrAdditionalLayers.Location = New System.Drawing.Point(6, 181)
        Me.ucrAdditionalLayers.Name = "ucrAdditionalLayers"
        Me.ucrAdditionalLayers.Size = New System.Drawing.Size(301, 180)
        Me.ucrAdditionalLayers.TabIndex = 8
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(6, 540)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 9
        '
        'dlgGeneralForGraphics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(484, 597)
        Me.Controls.Add(Me.grpLegend)
        Me.Controls.Add(Me.ucrInputAddCode)
        Me.Controls.Add(Me.ucrChkAddCode)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.cmdRHelp)
        Me.Controls.Add(Me.grpAesthetics)
        Me.Controls.Add(Me.ucrChkFlipCoordinates)
        Me.Controls.Add(Me.ucrSave)
        Me.Controls.Add(Me.ucrGraphicsSelector)
        Me.Controls.Add(Me.ucrAdditionalLayers)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgGeneralForGraphics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "General "
        Me.Text = "General"
        Me.grpAesthetics.ResumeLayout(False)
        Me.grpAesthetics.PerformLayout()
        Me.ContextMenuPackagesList.ResumeLayout(False)
        Me.contextMenuStripOptions.ResumeLayout(False)
        Me.grpLegend.ResumeLayout(False)
        Me.grpLegend.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrGraphicsSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSave As ucrSave
    Friend WithEvents ucrChkLegend As ucrCheck
    Friend WithEvents ucrChkFlipCoordinates As ucrCheck
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents grpAesthetics As GroupBox
    Friend WithEvents lblColour As Label
    Friend WithEvents ucrColourReceiver As ucrReceiverSingle
    Friend WithEvents lblFill As Label
    Friend WithEvents ucrFillReceiver As ucrReceiverSingle
    Friend WithEvents lblLabel As Label
    Friend WithEvents ucrLabelReceiver As ucrReceiverSingle
    Friend WithEvents cmdRHelp As ucrSplitButton
    Friend WithEvents ContextMenuPackagesList As ContextMenuStrip
    Friend WithEvents ListBaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeomtextpathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GGallyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgaltToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgdendroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgeffectsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgfittextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgforceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgformulaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgfortifyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgmcmcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgmosaicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgplotifyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgpmiscToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgpubrToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgrepelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgridgesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgsciToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgsignifToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgstanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgtextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgthemesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GgwordbuildToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ucrChkUseasNumeric As ucrCheck
    Friend WithEvents ucrReceiverY As ucrReceiverSingle
    Friend WithEvents lblYVariable As Label
    Friend WithEvents lblXVariable As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents cmdOptions As ucrSplitButton
    Friend WithEvents contextMenuStripOptions As ContextMenuStrip
    Friend WithEvents toolStripMenuItemPlotOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemFacets As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemLayers As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemTitles As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemXaxis As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemYaxis As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemThemes As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemCoordinates As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemColour As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemAnnotation As ToolStripMenuItem
    Friend WithEvents ucrInputAddCode As ucrInputComboBox
    Friend WithEvents ucrChkAddCode As ucrCheck
    Friend WithEvents ucrAdditionalLayers As ucrAdditionalLayers
    Friend WithEvents ucrInputAddLegendRibbon As ucrInputComboBox
    Friend WithEvents ucrInputAddLegendLine As ucrInputComboBox
    Friend WithEvents lblFillidentity As Label
    Friend WithEvents lblColouridentity As Label
    Friend WithEvents ucrChkColour As ucrCheck
    Friend WithEvents ucrChkFill As ucrCheck
    Friend WithEvents grpLegend As GroupBox
    Friend WithEvents ucrInputStation As ucrInputComboBox
    Friend WithEvents ucr1stFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblFacetBy As Label
End Class
