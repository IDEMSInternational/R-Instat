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
Partial Class sdgPlots
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgPlots))
        Me.tbpPlotsOptions = New System.Windows.Forms.TabControl()
        Me.tbpFacet = New System.Windows.Forms.TabPage()
        Me.ucrChkDrop = New instat.ucrCheck()
        Me.ucrNudNumberofRows = New instat.ucrNud()
        Me.ucrChkNoOfRowsOrColumns = New instat.ucrCheck()
        Me.ucrChkIncludeFacets = New instat.ucrCheck()
        Me.ucrChkLabeler = New instat.ucrCheck()
        Me.ucrChkFreeSpace = New instat.ucrCheck()
        Me.ucrChkFreeScalesY = New instat.ucrCheck()
        Me.ucrChkFreeScalesX = New instat.ucrCheck()
        Me.ucrChkMargin = New instat.ucrCheck()
        Me.ucrFacetSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.rdoHorizontal = New System.Windows.Forms.RadioButton()
        Me.rdoVertical = New System.Windows.Forms.RadioButton()
        Me.lblFactor2 = New System.Windows.Forms.Label()
        Me.lblFactor1 = New System.Windows.Forms.Label()
        Me.ucr2ndFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucr1stFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrPnlHorizonatalVertical = New instat.UcrPanel()
        Me.tbpLayers = New System.Windows.Forms.TabPage()
        Me.ucrPlotsAdditionalLayers = New instat.ucrAdditionalLayers()
        Me.tbpTitles = New System.Windows.Forms.TabPage()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpLegendTitle = New System.Windows.Forms.GroupBox()
        Me.ucrChkOverwriteLegendTitle = New instat.ucrCheck()
        Me.ucrChkDisplayLegendTitle = New instat.ucrCheck()
        Me.ucrInputLegend = New instat.ucrInputTextBox()
        Me.rdoLegendTitleCustom = New System.Windows.Forms.RadioButton()
        Me.rdoLegendTitleAuto = New System.Windows.Forms.RadioButton()
        Me.ucrPnlLegendTitle = New instat.UcrPanel()
        Me.ucrInputGraphCaption = New instat.ucrInputTextBox()
        Me.ucrInputGraphSubTitle = New instat.ucrInputTextBox()
        Me.ucrInputGraphTitle = New instat.ucrInputTextBox()
        Me.tbpXAxis = New System.Windows.Forms.TabPage()
        Me.ucrXAxis = New instat.ucrAxes()
        Me.tbpYAxis = New System.Windows.Forms.TabPage()
        Me.ucrYAxis = New instat.ucrAxes()
        Me.tbpTheme = New System.Windows.Forms.TabPage()
        Me.cmdSimpleOptions = New System.Windows.Forms.Button()
        Me.urChkSelectTheme = New instat.ucrCheck()
        Me.grpCommonOptions = New System.Windows.Forms.GroupBox()
        Me.ucrNudYaxisMarkSize = New instat.ucrNud()
        Me.ucrNudXaxisMarkSize = New instat.ucrNud()
        Me.ucrNudYSize = New instat.ucrNud()
        Me.ucrNudXSize = New instat.ucrNud()
        Me.ucrNudXAngle = New instat.ucrNud()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrChkYaxisTickMarkLabelSize = New instat.ucrCheck()
        Me.ucrChkXaxisTickMarkLabelSize = New instat.ucrCheck()
        Me.ucrChkYaxisSize = New instat.ucrCheck()
        Me.ucrChkXaxisSize = New instat.ucrCheck()
        Me.ucrChkXaxisAngle = New instat.ucrCheck()
        Me.ucrChkLegendPosition = New instat.ucrCheck()
        Me.lblFont = New System.Windows.Forms.Label()
        Me.cmdAllOptions = New System.Windows.Forms.Button()
        Me.ucrInputThemes = New instat.ucrInputComboBox()
        Me.tbpCoordinates = New System.Windows.Forms.TabPage()
        Me.grpPolarCordinates = New System.Windows.Forms.GroupBox()
        Me.ucrInputPolarCoordinates = New instat.ucrInputComboBox()
        Me.lblPolarCoordinate = New System.Windows.Forms.Label()
        Me.lblStartingAngle = New System.Windows.Forms.Label()
        Me.ucrChkUsePolarCoordinates = New instat.ucrCheck()
        Me.lblPi = New System.Windows.Forms.Label()
        Me.ucrChkDirectionAnticlockwise = New instat.ucrCheck()
        Me.ucrInputStartingAngle = New instat.ucrInputTextBox()
        Me.ucrChkSameScale = New instat.ucrCheck()
        Me.ucrChkHorizontalPlot = New instat.ucrCheck()
        Me.tbpColour = New System.Windows.Forms.TabPage()
        Me.ucrChkAddFillScale = New instat.ucrCheck()
        Me.grpColourScale = New System.Windows.Forms.GroupBox()
        Me.ucrChkColourDiscrete = New instat.ucrCheck()
        Me.ucrNudColourScaleTransparency = New instat.ucrNud()
        Me.ucrInputColourScalePalette = New instat.ucrInputComboBox()
        Me.ucrNudColourScaleMapEnds = New instat.ucrNud()
        Me.ucrNudColourScaleMapBegins = New instat.ucrNud()
        Me.ucrChkColourScaleReverseOrder = New instat.ucrCheck()
        Me.lblColourScaleMapEnds = New System.Windows.Forms.Label()
        Me.lblColourScaleMapBegins = New System.Windows.Forms.Label()
        Me.lblColourScalePalette = New System.Windows.Forms.Label()
        Me.lblColourScaleTransparency = New System.Windows.Forms.Label()
        Me.grpFillScale = New System.Windows.Forms.GroupBox()
        Me.ucrChkFillDiscrete = New instat.ucrCheck()
        Me.ucrNudFillScaleTransparency = New instat.ucrNud()
        Me.ucrNudFillScaleMapEnds = New instat.ucrNud()
        Me.ucrNudFillScaleMapBegins = New instat.ucrNud()
        Me.ucrInputFillScaleColour = New instat.ucrInputComboBox()
        Me.ucrChkFillScaleReverseColourOrder = New instat.ucrCheck()
        Me.lblFillScaleMapEnds = New System.Windows.Forms.Label()
        Me.lblFillScaleBeginColour = New System.Windows.Forms.Label()
        Me.lblFillScaleColourPalettte = New System.Windows.Forms.Label()
        Me.lblFillScaleTransparency = New System.Windows.Forms.Label()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.ucrChkAddColour = New instat.ucrCheck()
        Me.tbpPlotsOptions.SuspendLayout()
        Me.tbpFacet.SuspendLayout()
        Me.tbpLayers.SuspendLayout()
        Me.tbpTitles.SuspendLayout()
        Me.grpLegendTitle.SuspendLayout()
        Me.tbpXAxis.SuspendLayout()
        Me.tbpYAxis.SuspendLayout()
        Me.tbpTheme.SuspendLayout()
        Me.grpCommonOptions.SuspendLayout()
        Me.tbpCoordinates.SuspendLayout()
        Me.grpPolarCordinates.SuspendLayout()
        Me.tbpColour.SuspendLayout()
        Me.grpColourScale.SuspendLayout()
        Me.grpFillScale.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpPlotsOptions
        '
        Me.tbpPlotsOptions.Controls.Add(Me.tbpFacet)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpLayers)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpTitles)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpXAxis)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpYAxis)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpTheme)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpCoordinates)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpColour)
        resources.ApplyResources(Me.tbpPlotsOptions, "tbpPlotsOptions")
        Me.tbpPlotsOptions.Name = "tbpPlotsOptions"
        Me.tbpPlotsOptions.SelectedIndex = 0
        '
        'tbpFacet
        '
        Me.tbpFacet.Controls.Add(Me.ucrChkDrop)
        Me.tbpFacet.Controls.Add(Me.ucrNudNumberofRows)
        Me.tbpFacet.Controls.Add(Me.ucrChkNoOfRowsOrColumns)
        Me.tbpFacet.Controls.Add(Me.ucrChkIncludeFacets)
        Me.tbpFacet.Controls.Add(Me.ucrChkLabeler)
        Me.tbpFacet.Controls.Add(Me.ucrChkFreeSpace)
        Me.tbpFacet.Controls.Add(Me.ucrChkFreeScalesY)
        Me.tbpFacet.Controls.Add(Me.ucrChkFreeScalesX)
        Me.tbpFacet.Controls.Add(Me.ucrChkMargin)
        Me.tbpFacet.Controls.Add(Me.ucrFacetSelector)
        Me.tbpFacet.Controls.Add(Me.rdoHorizontal)
        Me.tbpFacet.Controls.Add(Me.rdoVertical)
        Me.tbpFacet.Controls.Add(Me.lblFactor2)
        Me.tbpFacet.Controls.Add(Me.lblFactor1)
        Me.tbpFacet.Controls.Add(Me.ucr2ndFactorReceiver)
        Me.tbpFacet.Controls.Add(Me.ucr1stFactorReceiver)
        Me.tbpFacet.Controls.Add(Me.ucrPnlHorizonatalVertical)
        resources.ApplyResources(Me.tbpFacet, "tbpFacet")
        Me.tbpFacet.Name = "tbpFacet"
        Me.tbpFacet.Tag = "Facet"
        Me.tbpFacet.UseVisualStyleBackColor = True
        '
        'ucrChkDrop
        '
        Me.ucrChkDrop.Checked = False
        resources.ApplyResources(Me.ucrChkDrop, "ucrChkDrop")
        Me.ucrChkDrop.Name = "ucrChkDrop"
        '
        'ucrNudNumberofRows
        '
        Me.ucrNudNumberofRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudNumberofRows, "ucrNudNumberofRows")
        Me.ucrNudNumberofRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberofRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofRows.Name = "ucrNudNumberofRows"
        Me.ucrNudNumberofRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkNoOfRowsOrColumns
        '
        Me.ucrChkNoOfRowsOrColumns.Checked = False
        resources.ApplyResources(Me.ucrChkNoOfRowsOrColumns, "ucrChkNoOfRowsOrColumns")
        Me.ucrChkNoOfRowsOrColumns.Name = "ucrChkNoOfRowsOrColumns"
        '
        'ucrChkIncludeFacets
        '
        Me.ucrChkIncludeFacets.Checked = False
        resources.ApplyResources(Me.ucrChkIncludeFacets, "ucrChkIncludeFacets")
        Me.ucrChkIncludeFacets.Name = "ucrChkIncludeFacets"
        '
        'ucrChkLabeler
        '
        Me.ucrChkLabeler.Checked = False
        resources.ApplyResources(Me.ucrChkLabeler, "ucrChkLabeler")
        Me.ucrChkLabeler.Name = "ucrChkLabeler"
        '
        'ucrChkFreeSpace
        '
        Me.ucrChkFreeSpace.Checked = False
        resources.ApplyResources(Me.ucrChkFreeSpace, "ucrChkFreeSpace")
        Me.ucrChkFreeSpace.Name = "ucrChkFreeSpace"
        '
        'ucrChkFreeScalesY
        '
        Me.ucrChkFreeScalesY.Checked = False
        resources.ApplyResources(Me.ucrChkFreeScalesY, "ucrChkFreeScalesY")
        Me.ucrChkFreeScalesY.Name = "ucrChkFreeScalesY"
        '
        'ucrChkFreeScalesX
        '
        Me.ucrChkFreeScalesX.Checked = False
        resources.ApplyResources(Me.ucrChkFreeScalesX, "ucrChkFreeScalesX")
        Me.ucrChkFreeScalesX.Name = "ucrChkFreeScalesX"
        '
        'ucrChkMargin
        '
        Me.ucrChkMargin.Checked = False
        resources.ApplyResources(Me.ucrChkMargin, "ucrChkMargin")
        Me.ucrChkMargin.Name = "ucrChkMargin"
        '
        'ucrFacetSelector
        '
        Me.ucrFacetSelector.bDropUnusedFilterLevels = False
        Me.ucrFacetSelector.bShowHiddenColumns = False
        Me.ucrFacetSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrFacetSelector, "ucrFacetSelector")
        Me.ucrFacetSelector.Name = "ucrFacetSelector"
        '
        'rdoHorizontal
        '
        resources.ApplyResources(Me.rdoHorizontal, "rdoHorizontal")
        Me.rdoHorizontal.Name = "rdoHorizontal"
        Me.rdoHorizontal.TabStop = True
        Me.rdoHorizontal.Tag = "Horizontal"
        Me.rdoHorizontal.UseVisualStyleBackColor = True
        '
        'rdoVertical
        '
        resources.ApplyResources(Me.rdoVertical, "rdoVertical")
        Me.rdoVertical.Name = "rdoVertical"
        Me.rdoVertical.TabStop = True
        Me.rdoVertical.Tag = "Vertical"
        Me.rdoVertical.UseVisualStyleBackColor = True
        '
        'lblFactor2
        '
        resources.ApplyResources(Me.lblFactor2, "lblFactor2")
        Me.lblFactor2.Name = "lblFactor2"
        '
        'lblFactor1
        '
        resources.ApplyResources(Me.lblFactor1, "lblFactor1")
        Me.lblFactor1.Name = "lblFactor1"
        Me.lblFactor1.Tag = ""
        '
        'ucr2ndFactorReceiver
        '
        Me.ucr2ndFactorReceiver.frmParent = Nothing
        resources.ApplyResources(Me.ucr2ndFactorReceiver, "ucr2ndFactorReceiver")
        Me.ucr2ndFactorReceiver.Name = "ucr2ndFactorReceiver"
        Me.ucr2ndFactorReceiver.Selector = Nothing
        Me.ucr2ndFactorReceiver.strNcFilePath = ""
        Me.ucr2ndFactorReceiver.ucrSelector = Nothing
        '
        'ucr1stFactorReceiver
        '
        Me.ucr1stFactorReceiver.frmParent = Nothing
        resources.ApplyResources(Me.ucr1stFactorReceiver, "ucr1stFactorReceiver")
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.strNcFilePath = ""
        Me.ucr1stFactorReceiver.ucrSelector = Nothing
        '
        'ucrPnlHorizonatalVertical
        '
        resources.ApplyResources(Me.ucrPnlHorizonatalVertical, "ucrPnlHorizonatalVertical")
        Me.ucrPnlHorizonatalVertical.Name = "ucrPnlHorizonatalVertical"
        '
        'tbpLayers
        '
        Me.tbpLayers.Controls.Add(Me.ucrPlotsAdditionalLayers)
        resources.ApplyResources(Me.tbpLayers, "tbpLayers")
        Me.tbpLayers.Name = "tbpLayers"
        Me.tbpLayers.Tag = "Layers"
        Me.tbpLayers.UseVisualStyleBackColor = True
        '
        'ucrPlotsAdditionalLayers
        '
        resources.ApplyResources(Me.ucrPlotsAdditionalLayers, "ucrPlotsAdditionalLayers")
        Me.ucrPlotsAdditionalLayers.Name = "ucrPlotsAdditionalLayers"
        '
        'tbpTitles
        '
        Me.tbpTitles.Controls.Add(Me.lblCaption)
        Me.tbpTitles.Controls.Add(Me.lblSubTitle)
        Me.tbpTitles.Controls.Add(Me.Label1)
        Me.tbpTitles.Controls.Add(Me.grpLegendTitle)
        Me.tbpTitles.Controls.Add(Me.ucrInputGraphCaption)
        Me.tbpTitles.Controls.Add(Me.ucrInputGraphSubTitle)
        Me.tbpTitles.Controls.Add(Me.ucrInputGraphTitle)
        resources.ApplyResources(Me.tbpTitles, "tbpTitles")
        Me.tbpTitles.Name = "tbpTitles"
        Me.tbpTitles.Tag = "Titles"
        Me.tbpTitles.UseVisualStyleBackColor = True
        '
        'lblCaption
        '
        resources.ApplyResources(Me.lblCaption, "lblCaption")
        Me.lblCaption.Name = "lblCaption"
        '
        'lblSubTitle
        '
        resources.ApplyResources(Me.lblSubTitle, "lblSubTitle")
        Me.lblSubTitle.Name = "lblSubTitle"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'grpLegendTitle
        '
        Me.grpLegendTitle.Controls.Add(Me.ucrChkOverwriteLegendTitle)
        Me.grpLegendTitle.Controls.Add(Me.ucrChkDisplayLegendTitle)
        Me.grpLegendTitle.Controls.Add(Me.ucrInputLegend)
        Me.grpLegendTitle.Controls.Add(Me.rdoLegendTitleCustom)
        Me.grpLegendTitle.Controls.Add(Me.rdoLegendTitleAuto)
        Me.grpLegendTitle.Controls.Add(Me.ucrPnlLegendTitle)
        resources.ApplyResources(Me.grpLegendTitle, "grpLegendTitle")
        Me.grpLegendTitle.Name = "grpLegendTitle"
        Me.grpLegendTitle.TabStop = False
        '
        'ucrChkOverwriteLegendTitle
        '
        Me.ucrChkOverwriteLegendTitle.Checked = False
        resources.ApplyResources(Me.ucrChkOverwriteLegendTitle, "ucrChkOverwriteLegendTitle")
        Me.ucrChkOverwriteLegendTitle.Name = "ucrChkOverwriteLegendTitle"
        '
        'ucrChkDisplayLegendTitle
        '
        Me.ucrChkDisplayLegendTitle.Checked = False
        resources.ApplyResources(Me.ucrChkDisplayLegendTitle, "ucrChkDisplayLegendTitle")
        Me.ucrChkDisplayLegendTitle.Name = "ucrChkDisplayLegendTitle"
        '
        'ucrInputLegend
        '
        Me.ucrInputLegend.AddQuotesIfUnrecognised = True
        Me.ucrInputLegend.IsMultiline = False
        Me.ucrInputLegend.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLegend, "ucrInputLegend")
        Me.ucrInputLegend.Name = "ucrInputLegend"
        '
        'rdoLegendTitleCustom
        '
        resources.ApplyResources(Me.rdoLegendTitleCustom, "rdoLegendTitleCustom")
        Me.rdoLegendTitleCustom.Name = "rdoLegendTitleCustom"
        Me.rdoLegendTitleCustom.TabStop = True
        Me.rdoLegendTitleCustom.UseVisualStyleBackColor = True
        '
        'rdoLegendTitleAuto
        '
        resources.ApplyResources(Me.rdoLegendTitleAuto, "rdoLegendTitleAuto")
        Me.rdoLegendTitleAuto.Name = "rdoLegendTitleAuto"
        Me.rdoLegendTitleAuto.TabStop = True
        Me.rdoLegendTitleAuto.UseVisualStyleBackColor = True
        '
        'ucrPnlLegendTitle
        '
        resources.ApplyResources(Me.ucrPnlLegendTitle, "ucrPnlLegendTitle")
        Me.ucrPnlLegendTitle.Name = "ucrPnlLegendTitle"
        '
        'ucrInputGraphCaption
        '
        Me.ucrInputGraphCaption.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphCaption.IsMultiline = False
        Me.ucrInputGraphCaption.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphCaption, "ucrInputGraphCaption")
        Me.ucrInputGraphCaption.Name = "ucrInputGraphCaption"
        '
        'ucrInputGraphSubTitle
        '
        Me.ucrInputGraphSubTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphSubTitle.IsMultiline = False
        Me.ucrInputGraphSubTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphSubTitle, "ucrInputGraphSubTitle")
        Me.ucrInputGraphSubTitle.Name = "ucrInputGraphSubTitle"
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphTitle.IsMultiline = False
        Me.ucrInputGraphTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphTitle, "ucrInputGraphTitle")
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        '
        'tbpXAxis
        '
        Me.tbpXAxis.Controls.Add(Me.ucrXAxis)
        resources.ApplyResources(Me.tbpXAxis, "tbpXAxis")
        Me.tbpXAxis.Name = "tbpXAxis"
        Me.tbpXAxis.UseVisualStyleBackColor = True
        '
        'ucrXAxis
        '
        resources.ApplyResources(Me.ucrXAxis, "ucrXAxis")
        Me.ucrXAxis.Name = "ucrXAxis"
        '
        'tbpYAxis
        '
        Me.tbpYAxis.Controls.Add(Me.ucrYAxis)
        resources.ApplyResources(Me.tbpYAxis, "tbpYAxis")
        Me.tbpYAxis.Name = "tbpYAxis"
        Me.tbpYAxis.UseVisualStyleBackColor = True
        '
        'ucrYAxis
        '
        resources.ApplyResources(Me.ucrYAxis, "ucrYAxis")
        Me.ucrYAxis.Name = "ucrYAxis"
        '
        'tbpTheme
        '
        Me.tbpTheme.Controls.Add(Me.cmdSimpleOptions)
        Me.tbpTheme.Controls.Add(Me.urChkSelectTheme)
        Me.tbpTheme.Controls.Add(Me.grpCommonOptions)
        Me.tbpTheme.Controls.Add(Me.lblFont)
        Me.tbpTheme.Controls.Add(Me.cmdAllOptions)
        Me.tbpTheme.Controls.Add(Me.ucrInputThemes)
        resources.ApplyResources(Me.tbpTheme, "tbpTheme")
        Me.tbpTheme.Name = "tbpTheme"
        Me.tbpTheme.Tag = "Theme"
        Me.tbpTheme.UseVisualStyleBackColor = True
        '
        'cmdSimpleOptions
        '
        resources.ApplyResources(Me.cmdSimpleOptions, "cmdSimpleOptions")
        Me.cmdSimpleOptions.Name = "cmdSimpleOptions"
        Me.cmdSimpleOptions.UseVisualStyleBackColor = True
        '
        'urChkSelectTheme
        '
        Me.urChkSelectTheme.Checked = False
        resources.ApplyResources(Me.urChkSelectTheme, "urChkSelectTheme")
        Me.urChkSelectTheme.Name = "urChkSelectTheme"
        '
        'grpCommonOptions
        '
        Me.grpCommonOptions.Controls.Add(Me.ucrNudYaxisMarkSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrNudXaxisMarkSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrNudYSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrNudXSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrNudXAngle)
        Me.grpCommonOptions.Controls.Add(Me.ucrInputLegendPosition)
        Me.grpCommonOptions.Controls.Add(Me.ucrChkYaxisTickMarkLabelSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrChkXaxisTickMarkLabelSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrChkYaxisSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrChkXaxisSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrChkXaxisAngle)
        Me.grpCommonOptions.Controls.Add(Me.ucrChkLegendPosition)
        resources.ApplyResources(Me.grpCommonOptions, "grpCommonOptions")
        Me.grpCommonOptions.Name = "grpCommonOptions"
        Me.grpCommonOptions.TabStop = False
        '
        'ucrNudYaxisMarkSize
        '
        Me.ucrNudYaxisMarkSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYaxisMarkSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudYaxisMarkSize, "ucrNudYaxisMarkSize")
        Me.ucrNudYaxisMarkSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYaxisMarkSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYaxisMarkSize.Name = "ucrNudYaxisMarkSize"
        Me.ucrNudYaxisMarkSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudXaxisMarkSize
        '
        Me.ucrNudXaxisMarkSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXaxisMarkSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudXaxisMarkSize, "ucrNudXaxisMarkSize")
        Me.ucrNudXaxisMarkSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXaxisMarkSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXaxisMarkSize.Name = "ucrNudXaxisMarkSize"
        Me.ucrNudXaxisMarkSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudYSize
        '
        Me.ucrNudYSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudYSize, "ucrNudYSize")
        Me.ucrNudYSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYSize.Name = "ucrNudYSize"
        Me.ucrNudYSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudXSize
        '
        Me.ucrNudXSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudXSize, "ucrNudXSize")
        Me.ucrNudXSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXSize.Name = "ucrNudXSize"
        Me.ucrNudXSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudXAngle
        '
        Me.ucrNudXAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudXAngle, "ucrNudXAngle")
        Me.ucrNudXAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAngle.Name = "ucrNudXAngle"
        Me.ucrNudXAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLegendPosition, "ucrInputLegendPosition")
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        '
        'ucrChkYaxisTickMarkLabelSize
        '
        Me.ucrChkYaxisTickMarkLabelSize.Checked = False
        resources.ApplyResources(Me.ucrChkYaxisTickMarkLabelSize, "ucrChkYaxisTickMarkLabelSize")
        Me.ucrChkYaxisTickMarkLabelSize.Name = "ucrChkYaxisTickMarkLabelSize"
        '
        'ucrChkXaxisTickMarkLabelSize
        '
        Me.ucrChkXaxisTickMarkLabelSize.Checked = False
        resources.ApplyResources(Me.ucrChkXaxisTickMarkLabelSize, "ucrChkXaxisTickMarkLabelSize")
        Me.ucrChkXaxisTickMarkLabelSize.Name = "ucrChkXaxisTickMarkLabelSize"
        '
        'ucrChkYaxisSize
        '
        Me.ucrChkYaxisSize.Checked = False
        resources.ApplyResources(Me.ucrChkYaxisSize, "ucrChkYaxisSize")
        Me.ucrChkYaxisSize.Name = "ucrChkYaxisSize"
        '
        'ucrChkXaxisSize
        '
        Me.ucrChkXaxisSize.Checked = False
        resources.ApplyResources(Me.ucrChkXaxisSize, "ucrChkXaxisSize")
        Me.ucrChkXaxisSize.Name = "ucrChkXaxisSize"
        '
        'ucrChkXaxisAngle
        '
        Me.ucrChkXaxisAngle.Checked = False
        resources.ApplyResources(Me.ucrChkXaxisAngle, "ucrChkXaxisAngle")
        Me.ucrChkXaxisAngle.Name = "ucrChkXaxisAngle"
        '
        'ucrChkLegendPosition
        '
        Me.ucrChkLegendPosition.Checked = False
        resources.ApplyResources(Me.ucrChkLegendPosition, "ucrChkLegendPosition")
        Me.ucrChkLegendPosition.Name = "ucrChkLegendPosition"
        '
        'lblFont
        '
        resources.ApplyResources(Me.lblFont, "lblFont")
        Me.lblFont.Name = "lblFont"
        '
        'cmdAllOptions
        '
        resources.ApplyResources(Me.cmdAllOptions, "cmdAllOptions")
        Me.cmdAllOptions.Name = "cmdAllOptions"
        Me.cmdAllOptions.UseVisualStyleBackColor = True
        '
        'ucrInputThemes
        '
        Me.ucrInputThemes.AddQuotesIfUnrecognised = True
        Me.ucrInputThemes.GetSetSelectedIndex = -1
        Me.ucrInputThemes.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputThemes, "ucrInputThemes")
        Me.ucrInputThemes.Name = "ucrInputThemes"
        '
        'tbpCoordinates
        '
        Me.tbpCoordinates.Controls.Add(Me.grpPolarCordinates)
        Me.tbpCoordinates.Controls.Add(Me.ucrChkSameScale)
        Me.tbpCoordinates.Controls.Add(Me.ucrChkHorizontalPlot)
        resources.ApplyResources(Me.tbpCoordinates, "tbpCoordinates")
        Me.tbpCoordinates.Name = "tbpCoordinates"
        Me.tbpCoordinates.UseVisualStyleBackColor = True
        '
        'grpPolarCordinates
        '
        Me.grpPolarCordinates.Controls.Add(Me.ucrInputPolarCoordinates)
        Me.grpPolarCordinates.Controls.Add(Me.lblPolarCoordinate)
        Me.grpPolarCordinates.Controls.Add(Me.lblStartingAngle)
        Me.grpPolarCordinates.Controls.Add(Me.ucrChkUsePolarCoordinates)
        Me.grpPolarCordinates.Controls.Add(Me.lblPi)
        Me.grpPolarCordinates.Controls.Add(Me.ucrChkDirectionAnticlockwise)
        Me.grpPolarCordinates.Controls.Add(Me.ucrInputStartingAngle)
        resources.ApplyResources(Me.grpPolarCordinates, "grpPolarCordinates")
        Me.grpPolarCordinates.Name = "grpPolarCordinates"
        Me.grpPolarCordinates.TabStop = False
        '
        'ucrInputPolarCoordinates
        '
        Me.ucrInputPolarCoordinates.AddQuotesIfUnrecognised = True
        Me.ucrInputPolarCoordinates.GetSetSelectedIndex = -1
        Me.ucrInputPolarCoordinates.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPolarCoordinates, "ucrInputPolarCoordinates")
        Me.ucrInputPolarCoordinates.Name = "ucrInputPolarCoordinates"
        '
        'lblPolarCoordinate
        '
        resources.ApplyResources(Me.lblPolarCoordinate, "lblPolarCoordinate")
        Me.lblPolarCoordinate.Name = "lblPolarCoordinate"
        '
        'lblStartingAngle
        '
        resources.ApplyResources(Me.lblStartingAngle, "lblStartingAngle")
        Me.lblStartingAngle.Name = "lblStartingAngle"
        '
        'ucrChkUsePolarCoordinates
        '
        Me.ucrChkUsePolarCoordinates.Checked = False
        resources.ApplyResources(Me.ucrChkUsePolarCoordinates, "ucrChkUsePolarCoordinates")
        Me.ucrChkUsePolarCoordinates.Name = "ucrChkUsePolarCoordinates"
        '
        'lblPi
        '
        resources.ApplyResources(Me.lblPi, "lblPi")
        Me.lblPi.Name = "lblPi"
        Me.lblPi.Tag = ""
        '
        'ucrChkDirectionAnticlockwise
        '
        Me.ucrChkDirectionAnticlockwise.Checked = False
        resources.ApplyResources(Me.ucrChkDirectionAnticlockwise, "ucrChkDirectionAnticlockwise")
        Me.ucrChkDirectionAnticlockwise.Name = "ucrChkDirectionAnticlockwise"
        '
        'ucrInputStartingAngle
        '
        Me.ucrInputStartingAngle.AddQuotesIfUnrecognised = True
        Me.ucrInputStartingAngle.IsMultiline = False
        Me.ucrInputStartingAngle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputStartingAngle, "ucrInputStartingAngle")
        Me.ucrInputStartingAngle.Name = "ucrInputStartingAngle"
        '
        'ucrChkSameScale
        '
        Me.ucrChkSameScale.Checked = False
        resources.ApplyResources(Me.ucrChkSameScale, "ucrChkSameScale")
        Me.ucrChkSameScale.Name = "ucrChkSameScale"
        '
        'ucrChkHorizontalPlot
        '
        Me.ucrChkHorizontalPlot.Checked = False
        resources.ApplyResources(Me.ucrChkHorizontalPlot, "ucrChkHorizontalPlot")
        Me.ucrChkHorizontalPlot.Name = "ucrChkHorizontalPlot"
        '
        'tbpColour
        '
        Me.tbpColour.Controls.Add(Me.ucrChkAddColour)
        Me.tbpColour.Controls.Add(Me.ucrChkAddFillScale)
        Me.tbpColour.Controls.Add(Me.grpColourScale)
        Me.tbpColour.Controls.Add(Me.grpFillScale)
        resources.ApplyResources(Me.tbpColour, "tbpColour")
        Me.tbpColour.Name = "tbpColour"
        Me.tbpColour.UseVisualStyleBackColor = True
        '
        'ucrChkAddFillScale
        '
        Me.ucrChkAddFillScale.Checked = False
        resources.ApplyResources(Me.ucrChkAddFillScale, "ucrChkAddFillScale")
        Me.ucrChkAddFillScale.Name = "ucrChkAddFillScale"
        '
        'grpColourScale
        '
        Me.grpColourScale.Controls.Add(Me.ucrChkColourDiscrete)
        Me.grpColourScale.Controls.Add(Me.ucrNudColourScaleTransparency)
        Me.grpColourScale.Controls.Add(Me.ucrInputColourScalePalette)
        Me.grpColourScale.Controls.Add(Me.ucrNudColourScaleMapEnds)
        Me.grpColourScale.Controls.Add(Me.ucrNudColourScaleMapBegins)
        Me.grpColourScale.Controls.Add(Me.ucrChkColourScaleReverseOrder)
        Me.grpColourScale.Controls.Add(Me.lblColourScaleMapEnds)
        Me.grpColourScale.Controls.Add(Me.lblColourScaleMapBegins)
        Me.grpColourScale.Controls.Add(Me.lblColourScalePalette)
        Me.grpColourScale.Controls.Add(Me.lblColourScaleTransparency)
        resources.ApplyResources(Me.grpColourScale, "grpColourScale")
        Me.grpColourScale.Name = "grpColourScale"
        Me.grpColourScale.TabStop = False
        '
        'ucrChkColourDiscrete
        '
        Me.ucrChkColourDiscrete.Checked = False
        resources.ApplyResources(Me.ucrChkColourDiscrete, "ucrChkColourDiscrete")
        Me.ucrChkColourDiscrete.Name = "ucrChkColourDiscrete"
        '
        'ucrNudColourScaleTransparency
        '
        Me.ucrNudColourScaleTransparency.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColourScaleTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudColourScaleTransparency, "ucrNudColourScaleTransparency")
        Me.ucrNudColourScaleTransparency.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColourScaleTransparency.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColourScaleTransparency.Name = "ucrNudColourScaleTransparency"
        Me.ucrNudColourScaleTransparency.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputColourScalePalette
        '
        Me.ucrInputColourScalePalette.AddQuotesIfUnrecognised = True
        Me.ucrInputColourScalePalette.GetSetSelectedIndex = -1
        Me.ucrInputColourScalePalette.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputColourScalePalette, "ucrInputColourScalePalette")
        Me.ucrInputColourScalePalette.Name = "ucrInputColourScalePalette"
        '
        'ucrNudColourScaleMapEnds
        '
        Me.ucrNudColourScaleMapEnds.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColourScaleMapEnds.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudColourScaleMapEnds, "ucrNudColourScaleMapEnds")
        Me.ucrNudColourScaleMapEnds.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColourScaleMapEnds.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColourScaleMapEnds.Name = "ucrNudColourScaleMapEnds"
        Me.ucrNudColourScaleMapEnds.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudColourScaleMapBegins
        '
        Me.ucrNudColourScaleMapBegins.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColourScaleMapBegins.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudColourScaleMapBegins, "ucrNudColourScaleMapBegins")
        Me.ucrNudColourScaleMapBegins.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColourScaleMapBegins.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColourScaleMapBegins.Name = "ucrNudColourScaleMapBegins"
        Me.ucrNudColourScaleMapBegins.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkColourScaleReverseOrder
        '
        Me.ucrChkColourScaleReverseOrder.Checked = False
        resources.ApplyResources(Me.ucrChkColourScaleReverseOrder, "ucrChkColourScaleReverseOrder")
        Me.ucrChkColourScaleReverseOrder.Name = "ucrChkColourScaleReverseOrder"
        '
        'lblColourScaleMapEnds
        '
        resources.ApplyResources(Me.lblColourScaleMapEnds, "lblColourScaleMapEnds")
        Me.lblColourScaleMapEnds.Name = "lblColourScaleMapEnds"
        '
        'lblColourScaleMapBegins
        '
        resources.ApplyResources(Me.lblColourScaleMapBegins, "lblColourScaleMapBegins")
        Me.lblColourScaleMapBegins.Name = "lblColourScaleMapBegins"
        '
        'lblColourScalePalette
        '
        resources.ApplyResources(Me.lblColourScalePalette, "lblColourScalePalette")
        Me.lblColourScalePalette.Name = "lblColourScalePalette"
        '
        'lblColourScaleTransparency
        '
        resources.ApplyResources(Me.lblColourScaleTransparency, "lblColourScaleTransparency")
        Me.lblColourScaleTransparency.Name = "lblColourScaleTransparency"
        '
        'grpFillScale
        '
        Me.grpFillScale.Controls.Add(Me.ucrChkFillDiscrete)
        Me.grpFillScale.Controls.Add(Me.ucrNudFillScaleTransparency)
        Me.grpFillScale.Controls.Add(Me.ucrNudFillScaleMapEnds)
        Me.grpFillScale.Controls.Add(Me.ucrNudFillScaleMapBegins)
        Me.grpFillScale.Controls.Add(Me.ucrInputFillScaleColour)
        Me.grpFillScale.Controls.Add(Me.ucrChkFillScaleReverseColourOrder)
        Me.grpFillScale.Controls.Add(Me.lblFillScaleMapEnds)
        Me.grpFillScale.Controls.Add(Me.lblFillScaleBeginColour)
        Me.grpFillScale.Controls.Add(Me.lblFillScaleColourPalettte)
        Me.grpFillScale.Controls.Add(Me.lblFillScaleTransparency)
        resources.ApplyResources(Me.grpFillScale, "grpFillScale")
        Me.grpFillScale.Name = "grpFillScale"
        Me.grpFillScale.TabStop = False
        '
        'ucrChkFillDiscrete
        '
        Me.ucrChkFillDiscrete.Checked = False
        resources.ApplyResources(Me.ucrChkFillDiscrete, "ucrChkFillDiscrete")
        Me.ucrChkFillDiscrete.Name = "ucrChkFillDiscrete"
        '
        'ucrNudFillScaleTransparency
        '
        Me.ucrNudFillScaleTransparency.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFillScaleTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudFillScaleTransparency, "ucrNudFillScaleTransparency")
        Me.ucrNudFillScaleTransparency.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFillScaleTransparency.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFillScaleTransparency.Name = "ucrNudFillScaleTransparency"
        Me.ucrNudFillScaleTransparency.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudFillScaleMapEnds
        '
        Me.ucrNudFillScaleMapEnds.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFillScaleMapEnds.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudFillScaleMapEnds, "ucrNudFillScaleMapEnds")
        Me.ucrNudFillScaleMapEnds.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFillScaleMapEnds.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFillScaleMapEnds.Name = "ucrNudFillScaleMapEnds"
        Me.ucrNudFillScaleMapEnds.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudFillScaleMapBegins
        '
        Me.ucrNudFillScaleMapBegins.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFillScaleMapBegins.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudFillScaleMapBegins, "ucrNudFillScaleMapBegins")
        Me.ucrNudFillScaleMapBegins.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFillScaleMapBegins.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFillScaleMapBegins.Name = "ucrNudFillScaleMapBegins"
        Me.ucrNudFillScaleMapBegins.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputFillScaleColour
        '
        Me.ucrInputFillScaleColour.AddQuotesIfUnrecognised = True
        Me.ucrInputFillScaleColour.GetSetSelectedIndex = -1
        Me.ucrInputFillScaleColour.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFillScaleColour, "ucrInputFillScaleColour")
        Me.ucrInputFillScaleColour.Name = "ucrInputFillScaleColour"
        '
        'ucrChkFillScaleReverseColourOrder
        '
        Me.ucrChkFillScaleReverseColourOrder.Checked = False
        resources.ApplyResources(Me.ucrChkFillScaleReverseColourOrder, "ucrChkFillScaleReverseColourOrder")
        Me.ucrChkFillScaleReverseColourOrder.Name = "ucrChkFillScaleReverseColourOrder"
        '
        'lblFillScaleMapEnds
        '
        resources.ApplyResources(Me.lblFillScaleMapEnds, "lblFillScaleMapEnds")
        Me.lblFillScaleMapEnds.Name = "lblFillScaleMapEnds"
        '
        'lblFillScaleBeginColour
        '
        resources.ApplyResources(Me.lblFillScaleBeginColour, "lblFillScaleBeginColour")
        Me.lblFillScaleBeginColour.Name = "lblFillScaleBeginColour"
        '
        'lblFillScaleColourPalettte
        '
        resources.ApplyResources(Me.lblFillScaleColourPalettte, "lblFillScaleColourPalettte")
        Me.lblFillScaleColourPalettte.Name = "lblFillScaleColourPalettte"
        '
        'lblFillScaleTransparency
        '
        resources.ApplyResources(Me.lblFillScaleTransparency, "lblFillScaleTransparency")
        Me.lblFillScaleTransparency.Name = "lblFillScaleTransparency"
        '
        'ucrBaseSubdialog
        '
        resources.ApplyResources(Me.ucrBaseSubdialog, "ucrBaseSubdialog")
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        '
        'ucrChkAddColour
        '
        Me.ucrChkAddColour.Checked = False
        resources.ApplyResources(Me.ucrChkAddColour, "ucrChkAddColour")
        Me.ucrChkAddColour.Name = "ucrChkAddColour"
        '
        'sdgPlots
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.tbpPlotsOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPlots"
        Me.Tag = "Plot_Options"
        Me.tbpPlotsOptions.ResumeLayout(False)
        Me.tbpFacet.ResumeLayout(False)
        Me.tbpFacet.PerformLayout()
        Me.tbpLayers.ResumeLayout(False)
        Me.tbpTitles.ResumeLayout(False)
        Me.tbpTitles.PerformLayout()
        Me.grpLegendTitle.ResumeLayout(False)
        Me.grpLegendTitle.PerformLayout()
        Me.tbpXAxis.ResumeLayout(False)
        Me.tbpYAxis.ResumeLayout(False)
        Me.tbpTheme.ResumeLayout(False)
        Me.tbpTheme.PerformLayout()
        Me.grpCommonOptions.ResumeLayout(False)
        Me.tbpCoordinates.ResumeLayout(False)
        Me.grpPolarCordinates.ResumeLayout(False)
        Me.grpPolarCordinates.PerformLayout()
        Me.tbpColour.ResumeLayout(False)
        Me.grpColourScale.ResumeLayout(False)
        Me.grpColourScale.PerformLayout()
        Me.grpFillScale.ResumeLayout(False)
        Me.grpFillScale.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbpPlotsOptions As TabControl
    Friend WithEvents tbpTheme As TabPage
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents tbpTitles As TabPage
    Friend WithEvents tbpFacet As TabPage
    Friend WithEvents tbpLayers As TabPage
    Friend WithEvents rdoHorizontal As RadioButton
    Friend WithEvents rdoVertical As RadioButton
    Friend WithEvents lblFactor2 As Label
    Friend WithEvents lblFactor1 As Label
    Friend WithEvents ucr2ndFactorReceiver As ucrReceiverSingle
    Friend WithEvents ucr1stFactorReceiver As ucrReceiverSingle
    Friend WithEvents tbpXAxis As TabPage
    Friend WithEvents tbpYAxis As TabPage
    Friend WithEvents ucrInputThemes As ucrInputComboBox
    Friend WithEvents cmdAllOptions As Button
    Friend WithEvents lblFont As Label
    Friend WithEvents ucrPlotsAdditionalLayers As ucrAdditionalLayers
    Friend WithEvents grpCommonOptions As GroupBox
    Friend WithEvents ucrFacetSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpLegendTitle As GroupBox
    Friend WithEvents rdoLegendTitleCustom As RadioButton
    Friend WithEvents rdoLegendTitleAuto As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrInputGraphTitle As ucrInputTextBox
    Friend WithEvents ucrXAxis As ucrAxes
    Friend WithEvents ucrYAxis As ucrAxes
    Friend WithEvents ucrInputLegend As ucrInputTextBox
    Friend WithEvents tbpCoordinates As TabPage
    Friend WithEvents ucrChkNoOfRowsOrColumns As ucrCheck
    Friend WithEvents ucrChkIncludeFacets As ucrCheck
    Friend WithEvents ucrChkFreeSpace As ucrCheck
    Friend WithEvents ucrChkFreeScalesY As ucrCheck
    Friend WithEvents ucrChkFreeScalesX As ucrCheck
    Friend WithEvents ucrChkMargin As ucrCheck
    Friend WithEvents ucrPnlHorizonatalVertical As UcrPanel
    Friend WithEvents ucrNudNumberofRows As ucrNud
    Friend WithEvents ucrPnlLegendTitle As UcrPanel
    Friend WithEvents ucrChkDisplayLegendTitle As ucrCheck
    Friend WithEvents ucrChkOverwriteLegendTitle As ucrCheck
    Friend WithEvents lblCaption As Label
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents ucrInputGraphCaption As ucrInputTextBox
    Friend WithEvents ucrInputGraphSubTitle As ucrInputTextBox
    Friend WithEvents urChkSelectTheme As ucrCheck
    Friend WithEvents ucrChkHorizontalPlot As ucrCheck

    Friend WithEvents ucrChkYaxisTickMarkLabelSize As ucrCheck
    Friend WithEvents ucrChkXaxisTickMarkLabelSize As ucrCheck
    Friend WithEvents ucrChkYaxisSize As ucrCheck
    Friend WithEvents ucrChkXaxisSize As ucrCheck
    Friend WithEvents ucrChkXaxisAngle As ucrCheck
    Friend WithEvents ucrChkLegendPosition As ucrCheck
    Friend WithEvents ucrNudYSize As ucrNud
    Friend WithEvents ucrNudXSize As ucrNud
    Friend WithEvents ucrNudXAngle As ucrNud
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents ucrNudYaxisMarkSize As ucrNud
    Friend WithEvents ucrNudXaxisMarkSize As ucrNud

    Friend WithEvents ucrChkLabeler As ucrCheck
    Friend WithEvents cmdSimpleOptions As Button
    Friend WithEvents ucrChkSameScale As ucrCheck
    Friend WithEvents ucrChkUsePolarCoordinates As ucrCheck
    Friend WithEvents ucrChkDirectionAnticlockwise As ucrCheck
    Friend WithEvents ucrInputStartingAngle As ucrInputTextBox
    Friend WithEvents lblPi As Label
    Friend WithEvents grpPolarCordinates As GroupBox
    Friend WithEvents lblStartingAngle As Label
    Friend WithEvents ucrInputPolarCoordinates As ucrInputComboBox
    Friend WithEvents lblPolarCoordinate As Label
    Friend WithEvents ucrChkDrop As ucrCheck
    Friend WithEvents tbpColour As TabPage
    Friend WithEvents grpFillScale As GroupBox
    Friend WithEvents lblFillScaleMapEnds As Label
    Friend WithEvents lblFillScaleBeginColour As Label
    Friend WithEvents lblFillScaleColourPalettte As Label
    Friend WithEvents lblFillScaleTransparency As Label
    Friend WithEvents ucrChkFillScaleReverseColourOrder As ucrCheck
    Friend WithEvents grpColourScale As GroupBox
    Friend WithEvents ucrNudColourScaleTransparency As ucrNud
    Friend WithEvents ucrInputColourScalePalette As ucrInputComboBox
    Friend WithEvents ucrNudColourScaleMapEnds As ucrNud
    Friend WithEvents ucrNudColourScaleMapBegins As ucrNud
    Friend WithEvents ucrChkColourScaleReverseOrder As ucrCheck
    Friend WithEvents lblColourScaleMapEnds As Label
    Friend WithEvents lblColourScaleMapBegins As Label
    Friend WithEvents lblColourScalePalette As Label
    Friend WithEvents lblColourScaleTransparency As Label
    Friend WithEvents ucrNudFillScaleTransparency As ucrNud
    Friend WithEvents ucrNudFillScaleMapEnds As ucrNud
    Friend WithEvents ucrNudFillScaleMapBegins As ucrNud
    Friend WithEvents ucrInputFillScaleColour As ucrInputComboBox
    Friend WithEvents ucrChkAddFillScale As ucrCheck
    Friend WithEvents ucrChkColourDiscrete As ucrCheck
    Friend WithEvents ucrChkFillDiscrete As ucrCheck
    Friend WithEvents ucrChkAddColour As ucrCheck
End Class


