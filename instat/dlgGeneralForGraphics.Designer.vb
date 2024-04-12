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
        Me.grpAethetics = New System.Windows.Forms.GroupBox()
        Me.ucrChkUseasNumeric = New instat.ucrCheck()
        Me.ucrReceiverY = New instat.ucrReceiverSingle()
        Me.lblYVariable = New System.Windows.Forms.Label()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.ucrLabelReceiver = New instat.ucrReceiverSingle()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.ucrColourReceiver = New instat.ucrReceiverSingle()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.ucrFillReceiver = New instat.ucrReceiverSingle()
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
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.ucrInputAddCode = New instat.ucrInputComboBox()
        Me.ucrChkAddCode = New instat.ucrCheck()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucr1stFactorReceiver = New instat.ucrReceiverSingle()
        Me.cmdOptions = New instat.ucrSplitButton()
        Me.cmdRHelp = New instat.ucrSplitButton()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrChkFlipCoordinates = New instat.ucrCheck()
        Me.ucrChkLegend = New instat.ucrCheck()
        Me.ucrSave = New instat.ucrSave()
        Me.ucrGraphicsSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrAdditionalLayers = New instat.ucrAdditionalLayers()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpAethetics.SuspendLayout()
        Me.ContextMenuPackagesList.SuspendLayout()
        Me.contextMenuStripOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAethetics
        '
        Me.grpAethetics.Controls.Add(Me.ucrChkUseasNumeric)
        Me.grpAethetics.Controls.Add(Me.ucrReceiverY)
        Me.grpAethetics.Controls.Add(Me.lblYVariable)
        Me.grpAethetics.Controls.Add(Me.lblXVariable)
        Me.grpAethetics.Controls.Add(Me.ucrReceiverX)
        Me.grpAethetics.Controls.Add(Me.lblLabel)
        Me.grpAethetics.Controls.Add(Me.ucrLabelReceiver)
        Me.grpAethetics.Controls.Add(Me.lblColour)
        Me.grpAethetics.Controls.Add(Me.ucrColourReceiver)
        Me.grpAethetics.Controls.Add(Me.lblFill)
        Me.grpAethetics.Controls.Add(Me.ucrFillReceiver)
        Me.grpAethetics.Location = New System.Drawing.Point(277, 31)
        Me.grpAethetics.Name = "grpAethetics"
        Me.grpAethetics.Size = New System.Drawing.Size(174, 257)
        Me.grpAethetics.TabIndex = 23
        Me.grpAethetics.TabStop = False
        Me.grpAethetics.Text = "Aethetics:"
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
        Me.ucrReceiverY.frmParent = Me
        Me.ucrReceiverY.Location = New System.Drawing.Point(24, 36)
        Me.ucrReceiverY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverY.Name = "ucrReceiverY"
        Me.ucrReceiverY.Selector = Nothing
        Me.ucrReceiverY.Size = New System.Drawing.Size(125, 20)
        Me.ucrReceiverY.strNcFilePath = ""
        Me.ucrReceiverY.TabIndex = 1
        Me.ucrReceiverY.ucrSelector = Nothing
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
        'ucrReceiverX
        '
        Me.ucrReceiverX.AutoSize = True
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(24, 81)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(125, 27)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 3
        Me.ucrReceiverX.ucrSelector = Nothing
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
        'ucrLabelReceiver
        '
        Me.ucrLabelReceiver.AutoSize = True
        Me.ucrLabelReceiver.frmParent = Me
        Me.ucrLabelReceiver.Location = New System.Drawing.Point(25, 229)
        Me.ucrLabelReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrLabelReceiver.Name = "ucrLabelReceiver"
        Me.ucrLabelReceiver.Selector = Nothing
        Me.ucrLabelReceiver.Size = New System.Drawing.Size(125, 25)
        Me.ucrLabelReceiver.strNcFilePath = ""
        Me.ucrLabelReceiver.TabIndex = 9
        Me.ucrLabelReceiver.ucrSelector = Nothing
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
        'ucrColourReceiver
        '
        Me.ucrColourReceiver.AutoSize = True
        Me.ucrColourReceiver.frmParent = Me
        Me.ucrColourReceiver.Location = New System.Drawing.Point(25, 189)
        Me.ucrColourReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrColourReceiver.Name = "ucrColourReceiver"
        Me.ucrColourReceiver.Selector = Nothing
        Me.ucrColourReceiver.Size = New System.Drawing.Size(125, 25)
        Me.ucrColourReceiver.strNcFilePath = ""
        Me.ucrColourReceiver.TabIndex = 7
        Me.ucrColourReceiver.ucrSelector = Nothing
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
        'ucrFillReceiver
        '
        Me.ucrFillReceiver.AutoSize = True
        Me.ucrFillReceiver.frmParent = Me
        Me.ucrFillReceiver.Location = New System.Drawing.Point(25, 150)
        Me.ucrFillReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFillReceiver.Name = "ucrFillReceiver"
        Me.ucrFillReceiver.Selector = Nothing
        Me.ucrFillReceiver.Size = New System.Drawing.Size(125, 25)
        Me.ucrFillReceiver.strNcFilePath = ""
        Me.ucrFillReceiver.TabIndex = 5
        Me.ucrFillReceiver.ucrSelector = Nothing
        '
        'ContextMenuPackagesList
        '
        Me.ContextMenuPackagesList.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuPackagesList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListBaseToolStripMenuItem, Me.GeomtextpathToolStripMenuItem, Me.GGallyToolStripMenuItem, Me.GgaltToolStripMenuItem, Me.GgdendroToolStripMenuItem, Me.GgeffectsToolStripMenuItem, Me.GgfittextToolStripMenuItem, Me.GgforceToolStripMenuItem, Me.GgformulaToolStripMenuItem, Me.GgfortifyToolStripMenuItem, Me.GgmcmcToolStripMenuItem, Me.GgmosaicToolStripMenuItem, Me.GgplotifyToolStripMenuItem, Me.GgpmiscToolStripMenuItem, Me.GgppToolStripMenuItem, Me.GgpubrToolStripMenuItem, Me.GgrepelToolStripMenuItem, Me.GgridgesToolStripMenuItem, Me.GgsciToolStripMenuItem, Me.GgsignifToolStripMenuItem, Me.GgstanceToolStripMenuItem, Me.GgtextToolStripMenuItem, Me.GgthemesToolStripMenuItem, Me.GgwordbuildToolStripMenuItem})
        Me.ContextMenuPackagesList.Name = "ContextMenuStrip1"
        Me.ContextMenuPackagesList.Size = New System.Drawing.Size(150, 532)
        '
        'ListBaseToolStripMenuItem
        '
        Me.ListBaseToolStripMenuItem.Name = "ListBaseToolStripMenuItem"
        Me.ListBaseToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ListBaseToolStripMenuItem.Text = "ggplot2"
        '
        'GeomtextpathToolStripMenuItem
        '
        Me.GeomtextpathToolStripMenuItem.Name = "GeomtextpathToolStripMenuItem"
        Me.GeomtextpathToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GeomtextpathToolStripMenuItem.Text = "geomtextpath"
        '
        'GGallyToolStripMenuItem
        '
        Me.GGallyToolStripMenuItem.Name = "GGallyToolStripMenuItem"
        Me.GGallyToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GGallyToolStripMenuItem.Text = "GGally"
        '
        'GgaltToolStripMenuItem
        '
        Me.GgaltToolStripMenuItem.Name = "GgaltToolStripMenuItem"
        Me.GgaltToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GgaltToolStripMenuItem.Text = "ggalt"
        '
        'GgdendroToolStripMenuItem
        '
        Me.GgdendroToolStripMenuItem.Name = "GgdendroToolStripMenuItem"
        Me.GgdendroToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GgdendroToolStripMenuItem.Text = "ggdendro"
        '
        'GgeffectsToolStripMenuItem
        '
        Me.GgeffectsToolStripMenuItem.Name = "GgeffectsToolStripMenuItem"
        Me.GgeffectsToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GgeffectsToolStripMenuItem.Text = "ggeffects"
        '
        'GgfittextToolStripMenuItem
        '
        Me.GgfittextToolStripMenuItem.Name = "GgfittextToolStripMenuItem"
        Me.GgfittextToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GgfittextToolStripMenuItem.Text = "ggfittext"
        '
        'GgforceToolStripMenuItem
        '
        Me.GgforceToolStripMenuItem.Name = "GgforceToolStripMenuItem"
        Me.GgforceToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GgforceToolStripMenuItem.Text = "ggforce"
        '
        'GgformulaToolStripMenuItem
        '
        Me.GgformulaToolStripMenuItem.Name = "GgformulaToolStripMenuItem"
        Me.GgformulaToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GgformulaToolStripMenuItem.Text = "ggformula"
        '
        'GgfortifyToolStripMenuItem
        '
        Me.GgfortifyToolStripMenuItem.Name = "GgfortifyToolStripMenuItem"
        Me.GgfortifyToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GgfortifyToolStripMenuItem.Text = "ggfortify"
        '
        'GgmcmcToolStripMenuItem
        '
        Me.GgmcmcToolStripMenuItem.Name = "GgmcmcToolStripMenuItem"
        Me.GgmcmcToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GgmcmcToolStripMenuItem.Text = "ggmcmc"
        '
        'GgmosaicToolStripMenuItem
        '
        Me.GgmosaicToolStripMenuItem.Name = "GgmosaicToolStripMenuItem"
        Me.GgmosaicToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GgmosaicToolStripMenuItem.Text = "ggmosaic"
        '
        'GgplotifyToolStripMenuItem
        '
        Me.GgplotifyToolStripMenuItem.Name = "GgplotifyToolStripMenuItem"
        Me.GgplotifyToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GgplotifyToolStripMenuItem.Text = "ggplotify"
        '
        'GgpmiscToolStripMenuItem
        '
        Me.GgpmiscToolStripMenuItem.Name = "GgpmiscToolStripMenuItem"
        Me.GgpmiscToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GgpmiscToolStripMenuItem.Text = "ggpmisc"
        '
        'GgppToolStripMenuItem
        '
        Me.GgppToolStripMenuItem.Name = "GgppToolStripMenuItem"
        Me.GgppToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GgppToolStripMenuItem.Text = "ggpp"
        '
        'GgpubrToolStripMenuItem
        '
        Me.GgpubrToolStripMenuItem.Name = "GgpubrToolStripMenuItem"
        Me.GgpubrToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GgpubrToolStripMenuItem.Text = "ggpubr"
        '
        'GgrepelToolStripMenuItem
        '
        Me.GgrepelToolStripMenuItem.Name = "GgrepelToolStripMenuItem"
        Me.GgrepelToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GgrepelToolStripMenuItem.Text = "ggrepel"
        '
        'GgridgesToolStripMenuItem
        '
        Me.GgridgesToolStripMenuItem.Name = "GgridgesToolStripMenuItem"
        Me.GgridgesToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GgridgesToolStripMenuItem.Text = "ggridges"
        '
        'GgsciToolStripMenuItem
        '
        Me.GgsciToolStripMenuItem.Name = "GgsciToolStripMenuItem"
        Me.GgsciToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GgsciToolStripMenuItem.Text = "ggsci"
        '
        'GgsignifToolStripMenuItem
        '
        Me.GgsignifToolStripMenuItem.Name = "GgsignifToolStripMenuItem"
        Me.GgsignifToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GgsignifToolStripMenuItem.Text = "ggsignif"
        '
        'GgstanceToolStripMenuItem
        '
        Me.GgstanceToolStripMenuItem.Name = "GgstanceToolStripMenuItem"
        Me.GgstanceToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GgstanceToolStripMenuItem.Text = "ggstance"
        '
        'GgtextToolStripMenuItem
        '
        Me.GgtextToolStripMenuItem.Name = "GgtextToolStripMenuItem"
        Me.GgtextToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GgtextToolStripMenuItem.Text = "ggtext"
        '
        'GgthemesToolStripMenuItem
        '
        Me.GgthemesToolStripMenuItem.Name = "GgthemesToolStripMenuItem"
        Me.GgthemesToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GgthemesToolStripMenuItem.Text = "ggthemes"
        '
        'GgwordbuildToolStripMenuItem
        '
        Me.GgwordbuildToolStripMenuItem.Name = "GgwordbuildToolStripMenuItem"
        Me.GgwordbuildToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
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
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetBy.Location = New System.Drawing.Point(277, 396)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(52, 13)
        Me.lblFacetBy.TabIndex = 12
        Me.lblFacetBy.Tag = ""
        Me.lblFacetBy.Text = "Facet By:"
        '
        'ucrInputAddCode
        '
        Me.ucrInputAddCode.AddQuotesIfUnrecognised = True
        Me.ucrInputAddCode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputAddCode.GetSetSelectedIndex = -1
        Me.ucrInputAddCode.IsReadOnly = False
        Me.ucrInputAddCode.Location = New System.Drawing.Point(159, 362)
        Me.ucrInputAddCode.Name = "ucrInputAddCode"
        Me.ucrInputAddCode.Size = New System.Drawing.Size(316, 21)
        Me.ucrInputAddCode.TabIndex = 218
        '
        'ucrChkAddCode
        '
        Me.ucrChkAddCode.AutoSize = True
        Me.ucrChkAddCode.Checked = False
        Me.ucrChkAddCode.Location = New System.Drawing.Point(159, 333)
        Me.ucrChkAddCode.Name = "ucrChkAddCode"
        Me.ucrChkAddCode.Size = New System.Drawing.Size(175, 24)
        Me.ucrChkAddCode.TabIndex = 217
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Location = New System.Drawing.Point(389, 411)
        Me.ucrInputStation.Name = "ucrInputStation"
        Me.ucrInputStation.Size = New System.Drawing.Size(86, 21)
        Me.ucrInputStation.TabIndex = 14
        '
        'ucr1stFactorReceiver
        '
        Me.ucr1stFactorReceiver.AutoSize = True
        Me.ucr1stFactorReceiver.frmParent = Me
        Me.ucr1stFactorReceiver.Location = New System.Drawing.Point(277, 411)
        Me.ucr1stFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.Size = New System.Drawing.Size(109, 26)
        Me.ucr1stFactorReceiver.strNcFilePath = ""
        Me.ucr1stFactorReceiver.TabIndex = 13
        Me.ucr1stFactorReceiver.ucrSelector = Nothing
        '
        'cmdOptions
        '
        Me.cmdOptions.AutoSize = True
        Me.cmdOptions.ContextMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.Location = New System.Drawing.Point(6, 361)
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
        Me.cmdRHelp.Location = New System.Drawing.Point(368, 449)
        Me.cmdRHelp.Name = "cmdRHelp"
        Me.cmdRHelp.Size = New System.Drawing.Size(91, 25)
        Me.cmdRHelp.SplitMenuStrip = Me.ContextMenuPackagesList
        Me.cmdRHelp.TabIndex = 213
        Me.cmdRHelp.Text = "R Help"
        Me.cmdRHelp.UseVisualStyleBackColor = True
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(107, 411)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(125, 21)
        Me.ucrInputLegendPosition.TabIndex = 15
        '
        'ucrChkFlipCoordinates
        '
        Me.ucrChkFlipCoordinates.AutoSize = True
        Me.ucrChkFlipCoordinates.Checked = False
        Me.ucrChkFlipCoordinates.Location = New System.Drawing.Point(301, 304)
        Me.ucrChkFlipCoordinates.Name = "ucrChkFlipCoordinates"
        Me.ucrChkFlipCoordinates.Size = New System.Drawing.Size(174, 24)
        Me.ucrChkFlipCoordinates.TabIndex = 13
        '
        'ucrChkLegend
        '
        Me.ucrChkLegend.AutoSize = True
        Me.ucrChkLegend.Checked = False
        Me.ucrChkLegend.Location = New System.Drawing.Point(6, 411)
        Me.ucrChkLegend.Name = "ucrChkLegend"
        Me.ucrChkLegend.Size = New System.Drawing.Size(98, 24)
        Me.ucrChkLegend.TabIndex = 14
        '
        'ucrSave
        '
        Me.ucrSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSave.Location = New System.Drawing.Point(6, 450)
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
        Me.ucrAdditionalLayers.Location = New System.Drawing.Point(6, 174)
        Me.ucrAdditionalLayers.Name = "ucrAdditionalLayers"
        Me.ucrAdditionalLayers.Size = New System.Drawing.Size(247, 181)
        Me.ucrAdditionalLayers.TabIndex = 8
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(6, 483)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 9
        '
        'dlgGeneralForGraphics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(478, 547)
        Me.Controls.Add(Me.ucrInputAddCode)
        Me.Controls.Add(Me.ucrChkAddCode)
        Me.Controls.Add(Me.ucrInputStation)
        Me.Controls.Add(Me.ucr1stFactorReceiver)
        Me.Controls.Add(Me.lblFacetBy)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.cmdRHelp)
        Me.Controls.Add(Me.grpAethetics)
        Me.Controls.Add(Me.ucrInputLegendPosition)
        Me.Controls.Add(Me.ucrChkFlipCoordinates)
        Me.Controls.Add(Me.ucrChkLegend)
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
        Me.Text = "General Graphics"
        Me.grpAethetics.ResumeLayout(False)
        Me.grpAethetics.PerformLayout()
        Me.ContextMenuPackagesList.ResumeLayout(False)
        Me.contextMenuStripOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrGraphicsSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSave As ucrSave
    Friend WithEvents ucrChkLegend As ucrCheck
    Friend WithEvents ucrChkFlipCoordinates As ucrCheck
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents grpAethetics As GroupBox
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
    Friend WithEvents ucrInputStation As ucrInputComboBox
    Friend WithEvents ucr1stFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblFacetBy As Label
    Friend WithEvents ucrInputAddCode As ucrInputComboBox
    Friend WithEvents ucrChkAddCode As ucrCheck
    Friend WithEvents ucrAdditionalLayers As ucrAdditionalLayers
End Class
