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
        Me.urChkSelectTheme = New instat.ucrCheck()
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
        Me.ucrChkAddColour = New instat.ucrCheck()
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
        Me.tbpAnnotation = New System.Windows.Forms.TabPage()
        Me.ucrChkAnnotation = New instat.ucrCheck()
        Me.grpAnnotation = New System.Windows.Forms.GroupBox()
        Me.ucrChkParse = New instat.ucrCheck()
        Me.ucrInputFill = New instat.ucrColors()
        Me.ucrInputColour = New instat.ucrColors()
        Me.lblCurvature = New System.Windows.Forms.Label()
        Me.ucrNudAlpha = New instat.ucrNud()
        Me.lblAlpha = New System.Windows.Forms.Label()
        Me.lblLineend = New System.Windows.Forms.Label()
        Me.lblAngle = New System.Windows.Forms.Label()
        Me.ucrNudAngle = New instat.ucrNud()
        Me.lblShape = New System.Windows.Forms.Label()
        Me.lblAnnotationGeoms = New System.Windows.Forms.Label()
        Me.ucrInputAnnotationGeoms = New instat.ucrInputComboBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.ucrNudSize = New instat.ucrNud()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.lblXmax = New System.Windows.Forms.Label()
        Me.ucrInputXmax = New instat.ucrInputTextBox()
        Me.ucrInputYmin = New instat.ucrInputTextBox()
        Me.ucrInputXmin = New instat.ucrInputTextBox()
        Me.lblYmin = New System.Windows.Forms.Label()
        Me.lblXmin = New System.Windows.Forms.Label()
        Me.lblXend = New System.Windows.Forms.Label()
        Me.lblYmax = New System.Windows.Forms.Label()
        Me.ucrInputYmax = New instat.ucrInputTextBox()
        Me.ucrInputYend = New instat.ucrInputTextBox()
        Me.ucrInputXend = New instat.ucrInputTextBox()
        Me.lblYend = New System.Windows.Forms.Label()
        Me.ucrNudLinetype = New instat.ucrNud()
        Me.lblLinetype = New System.Windows.Forms.Label()
        Me.lblPointrangeFatten = New System.Windows.Forms.Label()
        Me.ucrNudPointrangeFatten = New instat.ucrNud()
        Me.ucrNudCrossbarFatten = New instat.ucrNud()
        Me.lblCrossbarFatten = New System.Windows.Forms.Label()
        Me.ucrNudCurvature = New instat.ucrNud()
        Me.ucrNudShape = New instat.ucrNud()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.ucrInputLabel = New instat.ucrInputTextBox()
        Me.ucrInputLineend = New instat.ucrInputComboBox()
        Me.ucrInputY = New instat.ucrInputTextBox()
        Me.ucrInputX = New instat.ucrInputTextBox()
        Me.ucrReceiverY = New instat.ucrReceiverSingle()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
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
        Me.tbpAnnotation.SuspendLayout()
        Me.grpAnnotation.SuspendLayout()
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
        Me.tbpPlotsOptions.Controls.Add(Me.tbpAnnotation)
        Me.tbpPlotsOptions.Location = New System.Drawing.Point(7, 3)
        Me.tbpPlotsOptions.Name = "tbpPlotsOptions"
        Me.tbpPlotsOptions.SelectedIndex = 0
        Me.tbpPlotsOptions.Size = New System.Drawing.Size(677, 449)
        Me.tbpPlotsOptions.TabIndex = 0
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
        Me.tbpFacet.Location = New System.Drawing.Point(4, 22)
        Me.tbpFacet.Name = "tbpFacet"
        Me.tbpFacet.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpFacet.Size = New System.Drawing.Size(669, 423)
        Me.tbpFacet.TabIndex = 3
        Me.tbpFacet.Tag = "Facet"
        Me.tbpFacet.Text = "Facets"
        Me.tbpFacet.UseVisualStyleBackColor = True
        '
        'ucrChkDrop
        '
        Me.ucrChkDrop.AutoSize = True
        Me.ucrChkDrop.Checked = False
        Me.ucrChkDrop.Location = New System.Drawing.Point(273, 269)
        Me.ucrChkDrop.Name = "ucrChkDrop"
        Me.ucrChkDrop.Size = New System.Drawing.Size(156, 23)
        Me.ucrChkDrop.TabIndex = 11
        '
        'ucrNudNumberofRows
        '
        Me.ucrNudNumberofRows.AutoSize = True
        Me.ucrNudNumberofRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberofRows.Location = New System.Drawing.Point(169, 252)
        Me.ucrNudNumberofRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberofRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofRows.Name = "ucrNudNumberofRows"
        Me.ucrNudNumberofRows.Size = New System.Drawing.Size(46, 20)
        Me.ucrNudNumberofRows.TabIndex = 15
        Me.ucrNudNumberofRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkNoOfRowsOrColumns
        '
        Me.ucrChkNoOfRowsOrColumns.AutoSize = True
        Me.ucrChkNoOfRowsOrColumns.Checked = False
        Me.ucrChkNoOfRowsOrColumns.Location = New System.Drawing.Point(7, 254)
        Me.ucrChkNoOfRowsOrColumns.Name = "ucrChkNoOfRowsOrColumns"
        Me.ucrChkNoOfRowsOrColumns.Size = New System.Drawing.Size(156, 23)
        Me.ucrChkNoOfRowsOrColumns.TabIndex = 14
        '
        'ucrChkIncludeFacets
        '
        Me.ucrChkIncludeFacets.AutoSize = True
        Me.ucrChkIncludeFacets.Checked = False
        Me.ucrChkIncludeFacets.Location = New System.Drawing.Point(8, 13)
        Me.ucrChkIncludeFacets.Name = "ucrChkIncludeFacets"
        Me.ucrChkIncludeFacets.Size = New System.Drawing.Size(121, 23)
        Me.ucrChkIncludeFacets.TabIndex = 0
        '
        'ucrChkLabeler
        '
        Me.ucrChkLabeler.AutoSize = True
        Me.ucrChkLabeler.Checked = False
        Me.ucrChkLabeler.Location = New System.Drawing.Point(273, 245)
        Me.ucrChkLabeler.Name = "ucrChkLabeler"
        Me.ucrChkLabeler.Size = New System.Drawing.Size(220, 23)
        Me.ucrChkLabeler.TabIndex = 10
        '
        'ucrChkFreeSpace
        '
        Me.ucrChkFreeSpace.AutoSize = True
        Me.ucrChkFreeSpace.Checked = False
        Me.ucrChkFreeSpace.Location = New System.Drawing.Point(273, 221)
        Me.ucrChkFreeSpace.Name = "ucrChkFreeSpace"
        Me.ucrChkFreeSpace.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkFreeSpace.TabIndex = 9
        '
        'ucrChkFreeScalesY
        '
        Me.ucrChkFreeScalesY.AutoSize = True
        Me.ucrChkFreeScalesY.Checked = False
        Me.ucrChkFreeScalesY.Location = New System.Drawing.Point(273, 197)
        Me.ucrChkFreeScalesY.Name = "ucrChkFreeScalesY"
        Me.ucrChkFreeScalesY.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkFreeScalesY.TabIndex = 8
        '
        'ucrChkFreeScalesX
        '
        Me.ucrChkFreeScalesX.AutoSize = True
        Me.ucrChkFreeScalesX.Checked = False
        Me.ucrChkFreeScalesX.Location = New System.Drawing.Point(273, 173)
        Me.ucrChkFreeScalesX.Name = "ucrChkFreeScalesX"
        Me.ucrChkFreeScalesX.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkFreeScalesX.TabIndex = 7
        '
        'ucrChkMargin
        '
        Me.ucrChkMargin.AutoSize = True
        Me.ucrChkMargin.Checked = False
        Me.ucrChkMargin.Location = New System.Drawing.Point(273, 149)
        Me.ucrChkMargin.Name = "ucrChkMargin"
        Me.ucrChkMargin.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkMargin.TabIndex = 6
        '
        'ucrFacetSelector
        '
        Me.ucrFacetSelector.AutoSize = True
        Me.ucrFacetSelector.bDropUnusedFilterLevels = False
        Me.ucrFacetSelector.bShowHiddenColumns = False
        Me.ucrFacetSelector.bUseCurrentFilter = True
        Me.ucrFacetSelector.Location = New System.Drawing.Point(8, 36)
        Me.ucrFacetSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFacetSelector.Name = "ucrFacetSelector"
        Me.ucrFacetSelector.Size = New System.Drawing.Size(213, 183)
        Me.ucrFacetSelector.TabIndex = 1
        '
        'rdoHorizontal
        '
        Me.rdoHorizontal.AutoSize = True
        Me.rdoHorizontal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHorizontal.Location = New System.Drawing.Point(8, 230)
        Me.rdoHorizontal.Name = "rdoHorizontal"
        Me.rdoHorizontal.Size = New System.Drawing.Size(72, 17)
        Me.rdoHorizontal.TabIndex = 12
        Me.rdoHorizontal.TabStop = True
        Me.rdoHorizontal.Tag = "Horizontal"
        Me.rdoHorizontal.Text = "Horizontal"
        Me.rdoHorizontal.UseVisualStyleBackColor = True
        '
        'rdoVertical
        '
        Me.rdoVertical.AutoSize = True
        Me.rdoVertical.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoVertical.Location = New System.Drawing.Point(104, 230)
        Me.rdoVertical.Name = "rdoVertical"
        Me.rdoVertical.Size = New System.Drawing.Size(60, 17)
        Me.rdoVertical.TabIndex = 13
        Me.rdoVertical.TabStop = True
        Me.rdoVertical.Tag = "Vertical"
        Me.rdoVertical.Text = "Vertical"
        Me.rdoVertical.UseVisualStyleBackColor = True
        '
        'lblFactor2
        '
        Me.lblFactor2.AutoSize = True
        Me.lblFactor2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactor2.Location = New System.Drawing.Point(274, 99)
        Me.lblFactor2.Name = "lblFactor2"
        Me.lblFactor2.Size = New System.Drawing.Size(109, 13)
        Me.lblFactor2.TabIndex = 4
        Me.lblFactor2.Text = "2nd Factor (Optional):"
        '
        'lblFactor1
        '
        Me.lblFactor1.AutoSize = True
        Me.lblFactor1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactor1.Location = New System.Drawing.Point(272, 44)
        Me.lblFactor1.Name = "lblFactor1"
        Me.lblFactor1.Size = New System.Drawing.Size(57, 13)
        Me.lblFactor1.TabIndex = 2
        Me.lblFactor1.Tag = ""
        Me.lblFactor1.Text = "1st Factor:"
        '
        'ucr2ndFactorReceiver
        '
        Me.ucr2ndFactorReceiver.AutoSize = True
        Me.ucr2ndFactorReceiver.frmParent = Nothing
        Me.ucr2ndFactorReceiver.Location = New System.Drawing.Point(273, 114)
        Me.ucr2ndFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr2ndFactorReceiver.Name = "ucr2ndFactorReceiver"
        Me.ucr2ndFactorReceiver.Selector = Nothing
        Me.ucr2ndFactorReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucr2ndFactorReceiver.strNcFilePath = ""
        Me.ucr2ndFactorReceiver.TabIndex = 5
        Me.ucr2ndFactorReceiver.ucrSelector = Nothing
        '
        'ucr1stFactorReceiver
        '
        Me.ucr1stFactorReceiver.AutoSize = True
        Me.ucr1stFactorReceiver.frmParent = Nothing
        Me.ucr1stFactorReceiver.Location = New System.Drawing.Point(273, 59)
        Me.ucr1stFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucr1stFactorReceiver.strNcFilePath = ""
        Me.ucr1stFactorReceiver.TabIndex = 3
        Me.ucr1stFactorReceiver.ucrSelector = Nothing
        '
        'ucrPnlHorizonatalVertical
        '
        Me.ucrPnlHorizonatalVertical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlHorizonatalVertical.Location = New System.Drawing.Point(8, 228)
        Me.ucrPnlHorizonatalVertical.Name = "ucrPnlHorizonatalVertical"
        Me.ucrPnlHorizonatalVertical.Size = New System.Drawing.Size(165, 20)
        Me.ucrPnlHorizonatalVertical.TabIndex = 30
        '
        'tbpLayers
        '
        Me.tbpLayers.Controls.Add(Me.ucrPlotsAdditionalLayers)
        Me.tbpLayers.Location = New System.Drawing.Point(4, 22)
        Me.tbpLayers.Name = "tbpLayers"
        Me.tbpLayers.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpLayers.Size = New System.Drawing.Size(669, 423)
        Me.tbpLayers.TabIndex = 4
        Me.tbpLayers.Tag = "Layers"
        Me.tbpLayers.Text = "Layers"
        Me.tbpLayers.UseVisualStyleBackColor = True
        '
        'ucrPlotsAdditionalLayers
        '
        Me.ucrPlotsAdditionalLayers.AutoSize = True
        Me.ucrPlotsAdditionalLayers.Location = New System.Drawing.Point(7, 6)
        Me.ucrPlotsAdditionalLayers.Name = "ucrPlotsAdditionalLayers"
        Me.ucrPlotsAdditionalLayers.Size = New System.Drawing.Size(218, 191)
        Me.ucrPlotsAdditionalLayers.TabIndex = 0
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
        Me.tbpTitles.Location = New System.Drawing.Point(4, 22)
        Me.tbpTitles.Name = "tbpTitles"
        Me.tbpTitles.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTitles.Size = New System.Drawing.Size(669, 423)
        Me.tbpTitles.TabIndex = 2
        Me.tbpTitles.Tag = "Titles"
        Me.tbpTitles.Text = "Titles"
        Me.tbpTitles.UseVisualStyleBackColor = True
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCaption.Location = New System.Drawing.Point(6, 68)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(78, 13)
        Me.lblCaption.TabIndex = 10
        Me.lblCaption.Text = "Graph Caption:"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSubTitle.Location = New System.Drawing.Point(6, 41)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(84, 13)
        Me.lblSubTitle.TabIndex = 10
        Me.lblSubTitle.Text = "Graph Sub Title:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(7, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Graph Title:"
        '
        'grpLegendTitle
        '
        Me.grpLegendTitle.Controls.Add(Me.ucrChkOverwriteLegendTitle)
        Me.grpLegendTitle.Controls.Add(Me.ucrChkDisplayLegendTitle)
        Me.grpLegendTitle.Controls.Add(Me.ucrInputLegend)
        Me.grpLegendTitle.Controls.Add(Me.rdoLegendTitleCustom)
        Me.grpLegendTitle.Controls.Add(Me.rdoLegendTitleAuto)
        Me.grpLegendTitle.Controls.Add(Me.ucrPnlLegendTitle)
        Me.grpLegendTitle.Location = New System.Drawing.Point(10, 171)
        Me.grpLegendTitle.Name = "grpLegendTitle"
        Me.grpLegendTitle.Size = New System.Drawing.Size(299, 105)
        Me.grpLegendTitle.TabIndex = 8
        Me.grpLegendTitle.TabStop = False
        Me.grpLegendTitle.Text = "Legend Title"
        Me.grpLegendTitle.Visible = False
        '
        'ucrChkOverwriteLegendTitle
        '
        Me.ucrChkOverwriteLegendTitle.AutoSize = True
        Me.ucrChkOverwriteLegendTitle.Checked = False
        Me.ucrChkOverwriteLegendTitle.Location = New System.Drawing.Point(6, 75)
        Me.ucrChkOverwriteLegendTitle.Name = "ucrChkOverwriteLegendTitle"
        Me.ucrChkOverwriteLegendTitle.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkOverwriteLegendTitle.TabIndex = 14
        '
        'ucrChkDisplayLegendTitle
        '
        Me.ucrChkDisplayLegendTitle.AutoSize = True
        Me.ucrChkDisplayLegendTitle.Checked = False
        Me.ucrChkDisplayLegendTitle.Location = New System.Drawing.Point(6, 51)
        Me.ucrChkDisplayLegendTitle.Name = "ucrChkDisplayLegendTitle"
        Me.ucrChkDisplayLegendTitle.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkDisplayLegendTitle.TabIndex = 13
        '
        'ucrInputLegend
        '
        Me.ucrInputLegend.AddQuotesIfUnrecognised = True
        Me.ucrInputLegend.AutoSize = True
        Me.ucrInputLegend.IsMultiline = False
        Me.ucrInputLegend.IsReadOnly = False
        Me.ucrInputLegend.Location = New System.Drawing.Point(133, 74)
        Me.ucrInputLegend.Name = "ucrInputLegend"
        Me.ucrInputLegend.Size = New System.Drawing.Size(160, 21)
        Me.ucrInputLegend.TabIndex = 11
        '
        'rdoLegendTitleCustom
        '
        Me.rdoLegendTitleCustom.AutoSize = True
        Me.rdoLegendTitleCustom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLegendTitleCustom.Location = New System.Drawing.Point(73, 23)
        Me.rdoLegendTitleCustom.Name = "rdoLegendTitleCustom"
        Me.rdoLegendTitleCustom.Size = New System.Drawing.Size(60, 17)
        Me.rdoLegendTitleCustom.TabIndex = 10
        Me.rdoLegendTitleCustom.TabStop = True
        Me.rdoLegendTitleCustom.Text = "Custom"
        Me.rdoLegendTitleCustom.UseVisualStyleBackColor = True
        '
        'rdoLegendTitleAuto
        '
        Me.rdoLegendTitleAuto.AutoSize = True
        Me.rdoLegendTitleAuto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLegendTitleAuto.Location = New System.Drawing.Point(6, 23)
        Me.rdoLegendTitleAuto.Name = "rdoLegendTitleAuto"
        Me.rdoLegendTitleAuto.Size = New System.Drawing.Size(47, 17)
        Me.rdoLegendTitleAuto.TabIndex = 9
        Me.rdoLegendTitleAuto.TabStop = True
        Me.rdoLegendTitleAuto.Text = "Auto"
        Me.rdoLegendTitleAuto.UseVisualStyleBackColor = True
        '
        'ucrPnlLegendTitle
        '
        Me.ucrPnlLegendTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlLegendTitle.Location = New System.Drawing.Point(4, 20)
        Me.ucrPnlLegendTitle.Name = "ucrPnlLegendTitle"
        Me.ucrPnlLegendTitle.Size = New System.Drawing.Size(117, 25)
        Me.ucrPnlLegendTitle.TabIndex = 12
        '
        'ucrInputGraphCaption
        '
        Me.ucrInputGraphCaption.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphCaption.AutoSize = True
        Me.ucrInputGraphCaption.IsMultiline = False
        Me.ucrInputGraphCaption.IsReadOnly = False
        Me.ucrInputGraphCaption.Location = New System.Drawing.Point(126, 71)
        Me.ucrInputGraphCaption.Name = "ucrInputGraphCaption"
        Me.ucrInputGraphCaption.Size = New System.Drawing.Size(166, 21)
        Me.ucrInputGraphCaption.TabIndex = 9
        '
        'ucrInputGraphSubTitle
        '
        Me.ucrInputGraphSubTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphSubTitle.AutoSize = True
        Me.ucrInputGraphSubTitle.IsMultiline = False
        Me.ucrInputGraphSubTitle.IsReadOnly = False
        Me.ucrInputGraphSubTitle.Location = New System.Drawing.Point(126, 44)
        Me.ucrInputGraphSubTitle.Name = "ucrInputGraphSubTitle"
        Me.ucrInputGraphSubTitle.Size = New System.Drawing.Size(166, 21)
        Me.ucrInputGraphSubTitle.TabIndex = 9
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphTitle.AutoSize = True
        Me.ucrInputGraphTitle.IsMultiline = False
        Me.ucrInputGraphTitle.IsReadOnly = False
        Me.ucrInputGraphTitle.Location = New System.Drawing.Point(126, 17)
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        Me.ucrInputGraphTitle.Size = New System.Drawing.Size(166, 21)
        Me.ucrInputGraphTitle.TabIndex = 9
        '
        'tbpXAxis
        '
        Me.tbpXAxis.Controls.Add(Me.ucrXAxis)
        Me.tbpXAxis.Location = New System.Drawing.Point(4, 22)
        Me.tbpXAxis.Name = "tbpXAxis"
        Me.tbpXAxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpXAxis.Size = New System.Drawing.Size(669, 423)
        Me.tbpXAxis.TabIndex = 5
        Me.tbpXAxis.Text = "X-Axis"
        Me.tbpXAxis.UseVisualStyleBackColor = True
        '
        'ucrXAxis
        '
        Me.ucrXAxis.AutoSize = True
        Me.ucrXAxis.Location = New System.Drawing.Point(0, 1)
        Me.ucrXAxis.Name = "ucrXAxis"
        Me.ucrXAxis.Size = New System.Drawing.Size(669, 419)
        Me.ucrXAxis.TabIndex = 0
        '
        'tbpYAxis
        '
        Me.tbpYAxis.Controls.Add(Me.ucrYAxis)
        Me.tbpYAxis.Location = New System.Drawing.Point(4, 22)
        Me.tbpYAxis.Name = "tbpYAxis"
        Me.tbpYAxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpYAxis.Size = New System.Drawing.Size(669, 423)
        Me.tbpYAxis.TabIndex = 6
        Me.tbpYAxis.Text = "Y-Axis"
        Me.tbpYAxis.UseVisualStyleBackColor = True
        '
        'ucrYAxis
        '
        Me.ucrYAxis.AutoSize = True
        Me.ucrYAxis.Location = New System.Drawing.Point(0, 1)
        Me.ucrYAxis.Name = "ucrYAxis"
        Me.ucrYAxis.Size = New System.Drawing.Size(669, 416)
        Me.ucrYAxis.TabIndex = 0
        '
        'tbpTheme
        '
        Me.tbpTheme.Controls.Add(Me.cmdSimpleOptions)
        Me.tbpTheme.Controls.Add(Me.grpCommonOptions)
        Me.tbpTheme.Controls.Add(Me.lblFont)
        Me.tbpTheme.Controls.Add(Me.cmdAllOptions)
        Me.tbpTheme.Controls.Add(Me.urChkSelectTheme)
        Me.tbpTheme.Controls.Add(Me.ucrInputThemes)
        Me.tbpTheme.Location = New System.Drawing.Point(4, 22)
        Me.tbpTheme.Name = "tbpTheme"
        Me.tbpTheme.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTheme.Size = New System.Drawing.Size(669, 423)
        Me.tbpTheme.TabIndex = 1
        Me.tbpTheme.Tag = "Theme"
        Me.tbpTheme.Text = "Themes"
        Me.tbpTheme.UseVisualStyleBackColor = True
        '
        'cmdSimpleOptions
        '
        Me.cmdSimpleOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSimpleOptions.Location = New System.Drawing.Point(174, 49)
        Me.cmdSimpleOptions.Name = "cmdSimpleOptions"
        Me.cmdSimpleOptions.Size = New System.Drawing.Size(135, 23)
        Me.cmdSimpleOptions.TabIndex = 107
        Me.cmdSimpleOptions.Text = "Simple Options"
        Me.cmdSimpleOptions.UseVisualStyleBackColor = True
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
        Me.grpCommonOptions.Location = New System.Drawing.Point(7, 81)
        Me.grpCommonOptions.Name = "grpCommonOptions"
        Me.grpCommonOptions.Size = New System.Drawing.Size(497, 243)
        Me.grpCommonOptions.TabIndex = 5
        Me.grpCommonOptions.TabStop = False
        Me.grpCommonOptions.Text = "Common Options"
        '
        'ucrNudYaxisMarkSize
        '
        Me.ucrNudYaxisMarkSize.AutoSize = True
        Me.ucrNudYaxisMarkSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYaxisMarkSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudYaxisMarkSize.Location = New System.Drawing.Point(246, 205)
        Me.ucrNudYaxisMarkSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYaxisMarkSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYaxisMarkSize.Name = "ucrNudYaxisMarkSize"
        Me.ucrNudYaxisMarkSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudYaxisMarkSize.TabIndex = 11
        Me.ucrNudYaxisMarkSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudXaxisMarkSize
        '
        Me.ucrNudXaxisMarkSize.AutoSize = True
        Me.ucrNudXaxisMarkSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXaxisMarkSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudXaxisMarkSize.Location = New System.Drawing.Point(246, 169)
        Me.ucrNudXaxisMarkSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXaxisMarkSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXaxisMarkSize.Name = "ucrNudXaxisMarkSize"
        Me.ucrNudXaxisMarkSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudXaxisMarkSize.TabIndex = 10
        Me.ucrNudXaxisMarkSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudYSize
        '
        Me.ucrNudYSize.AutoSize = True
        Me.ucrNudYSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudYSize.Location = New System.Drawing.Point(246, 133)
        Me.ucrNudYSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYSize.Name = "ucrNudYSize"
        Me.ucrNudYSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudYSize.TabIndex = 9
        Me.ucrNudYSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudXSize
        '
        Me.ucrNudXSize.AutoSize = True
        Me.ucrNudXSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudXSize.Location = New System.Drawing.Point(246, 97)
        Me.ucrNudXSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXSize.Name = "ucrNudXSize"
        Me.ucrNudXSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudXSize.TabIndex = 8
        Me.ucrNudXSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudXAngle
        '
        Me.ucrNudXAngle.AutoSize = True
        Me.ucrNudXAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudXAngle.Location = New System.Drawing.Point(246, 61)
        Me.ucrNudXAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAngle.Name = "ucrNudXAngle"
        Me.ucrNudXAngle.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudXAngle.TabIndex = 7
        Me.ucrNudXAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(246, 25)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLegendPosition.TabIndex = 6
        '
        'ucrChkYaxisTickMarkLabelSize
        '
        Me.ucrChkYaxisTickMarkLabelSize.AutoSize = True
        Me.ucrChkYaxisTickMarkLabelSize.Checked = False
        Me.ucrChkYaxisTickMarkLabelSize.Location = New System.Drawing.Point(6, 205)
        Me.ucrChkYaxisTickMarkLabelSize.Name = "ucrChkYaxisTickMarkLabelSize"
        Me.ucrChkYaxisTickMarkLabelSize.Size = New System.Drawing.Size(234, 23)
        Me.ucrChkYaxisTickMarkLabelSize.TabIndex = 5
        '
        'ucrChkXaxisTickMarkLabelSize
        '
        Me.ucrChkXaxisTickMarkLabelSize.AutoSize = True
        Me.ucrChkXaxisTickMarkLabelSize.Checked = False
        Me.ucrChkXaxisTickMarkLabelSize.Location = New System.Drawing.Point(6, 169)
        Me.ucrChkXaxisTickMarkLabelSize.Name = "ucrChkXaxisTickMarkLabelSize"
        Me.ucrChkXaxisTickMarkLabelSize.Size = New System.Drawing.Size(234, 23)
        Me.ucrChkXaxisTickMarkLabelSize.TabIndex = 4
        '
        'ucrChkYaxisSize
        '
        Me.ucrChkYaxisSize.AutoSize = True
        Me.ucrChkYaxisSize.Checked = False
        Me.ucrChkYaxisSize.Location = New System.Drawing.Point(6, 133)
        Me.ucrChkYaxisSize.Name = "ucrChkYaxisSize"
        Me.ucrChkYaxisSize.Size = New System.Drawing.Size(234, 23)
        Me.ucrChkYaxisSize.TabIndex = 3
        '
        'ucrChkXaxisSize
        '
        Me.ucrChkXaxisSize.AutoSize = True
        Me.ucrChkXaxisSize.Checked = False
        Me.ucrChkXaxisSize.Location = New System.Drawing.Point(6, 97)
        Me.ucrChkXaxisSize.Name = "ucrChkXaxisSize"
        Me.ucrChkXaxisSize.Size = New System.Drawing.Size(234, 23)
        Me.ucrChkXaxisSize.TabIndex = 2
        '
        'ucrChkXaxisAngle
        '
        Me.ucrChkXaxisAngle.AutoSize = True
        Me.ucrChkXaxisAngle.Checked = False
        Me.ucrChkXaxisAngle.Location = New System.Drawing.Point(6, 61)
        Me.ucrChkXaxisAngle.Name = "ucrChkXaxisAngle"
        Me.ucrChkXaxisAngle.Size = New System.Drawing.Size(234, 23)
        Me.ucrChkXaxisAngle.TabIndex = 1
        '
        'ucrChkLegendPosition
        '
        Me.ucrChkLegendPosition.AutoSize = True
        Me.ucrChkLegendPosition.Checked = False
        Me.ucrChkLegendPosition.Location = New System.Drawing.Point(6, 25)
        Me.ucrChkLegendPosition.Name = "ucrChkLegendPosition"
        Me.ucrChkLegendPosition.Size = New System.Drawing.Size(234, 23)
        Me.ucrChkLegendPosition.TabIndex = 0
        '
        'lblFont
        '
        Me.lblFont.AutoSize = True
        Me.lblFont.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFont.Location = New System.Drawing.Point(233, 49)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(0, 13)
        Me.lblFont.TabIndex = 4
        '
        'cmdAllOptions
        '
        Me.cmdAllOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAllOptions.Location = New System.Drawing.Point(29, 49)
        Me.cmdAllOptions.Name = "cmdAllOptions"
        Me.cmdAllOptions.Size = New System.Drawing.Size(139, 23)
        Me.cmdAllOptions.TabIndex = 2
        Me.cmdAllOptions.Text = "All Options"
        Me.cmdAllOptions.UseVisualStyleBackColor = True
        '
        'urChkSelectTheme
        '
        Me.urChkSelectTheme.AutoSize = True
        Me.urChkSelectTheme.Checked = False
        Me.urChkSelectTheme.Location = New System.Drawing.Point(29, 19)
        Me.urChkSelectTheme.Name = "urChkSelectTheme"
        Me.urChkSelectTheme.Size = New System.Drawing.Size(139, 23)
        Me.urChkSelectTheme.TabIndex = 106
        '
        'ucrInputThemes
        '
        Me.ucrInputThemes.AddQuotesIfUnrecognised = True
        Me.ucrInputThemes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputThemes.GetSetSelectedIndex = -1
        Me.ucrInputThemes.IsReadOnly = False
        Me.ucrInputThemes.Location = New System.Drawing.Point(174, 19)
        Me.ucrInputThemes.Name = "ucrInputThemes"
        Me.ucrInputThemes.Size = New System.Drawing.Size(171, 21)
        Me.ucrInputThemes.TabIndex = 1
        '
        'tbpCoordinates
        '
        Me.tbpCoordinates.Controls.Add(Me.grpPolarCordinates)
        Me.tbpCoordinates.Controls.Add(Me.ucrChkSameScale)
        Me.tbpCoordinates.Controls.Add(Me.ucrChkHorizontalPlot)
        Me.tbpCoordinates.Location = New System.Drawing.Point(4, 22)
        Me.tbpCoordinates.Name = "tbpCoordinates"
        Me.tbpCoordinates.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCoordinates.Size = New System.Drawing.Size(669, 423)
        Me.tbpCoordinates.TabIndex = 7
        Me.tbpCoordinates.Text = "Coordinates"
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
        Me.grpPolarCordinates.Location = New System.Drawing.Point(3, 67)
        Me.grpPolarCordinates.Name = "grpPolarCordinates"
        Me.grpPolarCordinates.Size = New System.Drawing.Size(300, 136)
        Me.grpPolarCordinates.TabIndex = 22
        Me.grpPolarCordinates.TabStop = False
        Me.grpPolarCordinates.Text = "Polar Cordinates"
        '
        'ucrInputPolarCoordinates
        '
        Me.ucrInputPolarCoordinates.AddQuotesIfUnrecognised = True
        Me.ucrInputPolarCoordinates.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPolarCoordinates.GetSetSelectedIndex = -1
        Me.ucrInputPolarCoordinates.IsReadOnly = False
        Me.ucrInputPolarCoordinates.Location = New System.Drawing.Point(141, 43)
        Me.ucrInputPolarCoordinates.Name = "ucrInputPolarCoordinates"
        Me.ucrInputPolarCoordinates.Size = New System.Drawing.Size(65, 21)
        Me.ucrInputPolarCoordinates.TabIndex = 24
        '
        'lblPolarCoordinate
        '
        Me.lblPolarCoordinate.AutoSize = True
        Me.lblPolarCoordinate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPolarCoordinate.Location = New System.Drawing.Point(10, 46)
        Me.lblPolarCoordinate.Name = "lblPolarCoordinate"
        Me.lblPolarCoordinate.Size = New System.Drawing.Size(88, 13)
        Me.lblPolarCoordinate.TabIndex = 23
        Me.lblPolarCoordinate.Text = "Polar Coordinate:"
        '
        'lblStartingAngle
        '
        Me.lblStartingAngle.AutoSize = True
        Me.lblStartingAngle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStartingAngle.Location = New System.Drawing.Point(10, 99)
        Me.lblStartingAngle.Name = "lblStartingAngle"
        Me.lblStartingAngle.Size = New System.Drawing.Size(76, 13)
        Me.lblStartingAngle.TabIndex = 22
        Me.lblStartingAngle.Text = "Starting Angle:"
        '
        'ucrChkUsePolarCoordinates
        '
        Me.ucrChkUsePolarCoordinates.AutoSize = True
        Me.ucrChkUsePolarCoordinates.Checked = False
        Me.ucrChkUsePolarCoordinates.Location = New System.Drawing.Point(12, 19)
        Me.ucrChkUsePolarCoordinates.Name = "ucrChkUsePolarCoordinates"
        Me.ucrChkUsePolarCoordinates.Size = New System.Drawing.Size(194, 23)
        Me.ucrChkUsePolarCoordinates.TabIndex = 16
        '
        'lblPi
        '
        Me.lblPi.AutoSize = True
        Me.lblPi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPi.Location = New System.Drawing.Point(191, 103)
        Me.lblPi.Name = "lblPi"
        Me.lblPi.Size = New System.Drawing.Size(15, 13)
        Me.lblPi.TabIndex = 21
        Me.lblPi.Tag = ""
        Me.lblPi.Text = "pi"
        '
        'ucrChkDirectionAnticlockwise
        '
        Me.ucrChkDirectionAnticlockwise.AutoSize = True
        Me.ucrChkDirectionAnticlockwise.Checked = False
        Me.ucrChkDirectionAnticlockwise.Location = New System.Drawing.Point(12, 70)
        Me.ucrChkDirectionAnticlockwise.Name = "ucrChkDirectionAnticlockwise"
        Me.ucrChkDirectionAnticlockwise.Size = New System.Drawing.Size(194, 23)
        Me.ucrChkDirectionAnticlockwise.TabIndex = 17
        '
        'ucrInputStartingAngle
        '
        Me.ucrInputStartingAngle.AddQuotesIfUnrecognised = True
        Me.ucrInputStartingAngle.AutoSize = True
        Me.ucrInputStartingAngle.IsMultiline = False
        Me.ucrInputStartingAngle.IsReadOnly = False
        Me.ucrInputStartingAngle.Location = New System.Drawing.Point(141, 95)
        Me.ucrInputStartingAngle.Name = "ucrInputStartingAngle"
        Me.ucrInputStartingAngle.Size = New System.Drawing.Size(43, 21)
        Me.ucrInputStartingAngle.TabIndex = 19
        '
        'ucrChkSameScale
        '
        Me.ucrChkSameScale.AutoSize = True
        Me.ucrChkSameScale.Checked = False
        Me.ucrChkSameScale.Location = New System.Drawing.Point(13, 41)
        Me.ucrChkSameScale.Name = "ucrChkSameScale"
        Me.ucrChkSameScale.Size = New System.Drawing.Size(233, 23)
        Me.ucrChkSameScale.TabIndex = 15
        '
        'ucrChkHorizontalPlot
        '
        Me.ucrChkHorizontalPlot.AutoSize = True
        Me.ucrChkHorizontalPlot.Checked = False
        Me.ucrChkHorizontalPlot.Location = New System.Drawing.Point(13, 15)
        Me.ucrChkHorizontalPlot.Name = "ucrChkHorizontalPlot"
        Me.ucrChkHorizontalPlot.Size = New System.Drawing.Size(233, 23)
        Me.ucrChkHorizontalPlot.TabIndex = 14
        '
        'tbpColour
        '
        Me.tbpColour.Controls.Add(Me.ucrChkAddColour)
        Me.tbpColour.Controls.Add(Me.ucrChkAddFillScale)
        Me.tbpColour.Controls.Add(Me.grpColourScale)
        Me.tbpColour.Controls.Add(Me.grpFillScale)
        Me.tbpColour.Location = New System.Drawing.Point(4, 22)
        Me.tbpColour.Name = "tbpColour"
        Me.tbpColour.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpColour.Size = New System.Drawing.Size(669, 423)
        Me.tbpColour.TabIndex = 8
        Me.tbpColour.Text = "Colour"
        Me.tbpColour.UseVisualStyleBackColor = True
        '
        'ucrChkAddColour
        '
        Me.ucrChkAddColour.AutoSize = True
        Me.ucrChkAddColour.Checked = False
        Me.ucrChkAddColour.Location = New System.Drawing.Point(23, 210)
        Me.ucrChkAddColour.Name = "ucrChkAddColour"
        Me.ucrChkAddColour.Size = New System.Drawing.Size(326, 23)
        Me.ucrChkAddColour.TabIndex = 27
        '
        'ucrChkAddFillScale
        '
        Me.ucrChkAddFillScale.AutoSize = True
        Me.ucrChkAddFillScale.Checked = False
        Me.ucrChkAddFillScale.Location = New System.Drawing.Point(23, 6)
        Me.ucrChkAddFillScale.Name = "ucrChkAddFillScale"
        Me.ucrChkAddFillScale.Size = New System.Drawing.Size(326, 23)
        Me.ucrChkAddFillScale.TabIndex = 26
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
        Me.grpColourScale.Location = New System.Drawing.Point(13, 236)
        Me.grpColourScale.Name = "grpColourScale"
        Me.grpColourScale.Size = New System.Drawing.Size(444, 171)
        Me.grpColourScale.TabIndex = 25
        Me.grpColourScale.TabStop = False
        Me.grpColourScale.Text = "Colour Scale"
        '
        'ucrChkColourDiscrete
        '
        Me.ucrChkColourDiscrete.AutoSize = True
        Me.ucrChkColourDiscrete.Checked = False
        Me.ucrChkColourDiscrete.Location = New System.Drawing.Point(7, 125)
        Me.ucrChkColourDiscrete.Name = "ucrChkColourDiscrete"
        Me.ucrChkColourDiscrete.Size = New System.Drawing.Size(352, 23)
        Me.ucrChkColourDiscrete.TabIndex = 12
        '
        'ucrNudColourScaleTransparency
        '
        Me.ucrNudColourScaleTransparency.AutoSize = True
        Me.ucrNudColourScaleTransparency.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColourScaleTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudColourScaleTransparency.Location = New System.Drawing.Point(268, 46)
        Me.ucrNudColourScaleTransparency.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColourScaleTransparency.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColourScaleTransparency.Name = "ucrNudColourScaleTransparency"
        Me.ucrNudColourScaleTransparency.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudColourScaleTransparency.TabIndex = 11
        Me.ucrNudColourScaleTransparency.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputColourScalePalette
        '
        Me.ucrInputColourScalePalette.AddQuotesIfUnrecognised = True
        Me.ucrInputColourScalePalette.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputColourScalePalette.GetSetSelectedIndex = -1
        Me.ucrInputColourScalePalette.IsReadOnly = False
        Me.ucrInputColourScalePalette.Location = New System.Drawing.Point(268, 19)
        Me.ucrInputColourScalePalette.Name = "ucrInputColourScalePalette"
        Me.ucrInputColourScalePalette.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputColourScalePalette.TabIndex = 10
        '
        'ucrNudColourScaleMapEnds
        '
        Me.ucrNudColourScaleMapEnds.AutoSize = True
        Me.ucrNudColourScaleMapEnds.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColourScaleMapEnds.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudColourScaleMapEnds.Location = New System.Drawing.Point(268, 97)
        Me.ucrNudColourScaleMapEnds.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColourScaleMapEnds.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColourScaleMapEnds.Name = "ucrNudColourScaleMapEnds"
        Me.ucrNudColourScaleMapEnds.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudColourScaleMapEnds.TabIndex = 9
        Me.ucrNudColourScaleMapEnds.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudColourScaleMapBegins
        '
        Me.ucrNudColourScaleMapBegins.AutoSize = True
        Me.ucrNudColourScaleMapBegins.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColourScaleMapBegins.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudColourScaleMapBegins.Location = New System.Drawing.Point(268, 71)
        Me.ucrNudColourScaleMapBegins.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColourScaleMapBegins.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColourScaleMapBegins.Name = "ucrNudColourScaleMapBegins"
        Me.ucrNudColourScaleMapBegins.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudColourScaleMapBegins.TabIndex = 8
        Me.ucrNudColourScaleMapBegins.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkColourScaleReverseOrder
        '
        Me.ucrChkColourScaleReverseOrder.AutoSize = True
        Me.ucrChkColourScaleReverseOrder.Checked = False
        Me.ucrChkColourScaleReverseOrder.Location = New System.Drawing.Point(7, 145)
        Me.ucrChkColourScaleReverseOrder.Name = "ucrChkColourScaleReverseOrder"
        Me.ucrChkColourScaleReverseOrder.Size = New System.Drawing.Size(352, 23)
        Me.ucrChkColourScaleReverseOrder.TabIndex = 5
        '
        'lblColourScaleMapEnds
        '
        Me.lblColourScaleMapEnds.AutoSize = True
        Me.lblColourScaleMapEnds.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColourScaleMapEnds.Location = New System.Drawing.Point(7, 100)
        Me.lblColourScaleMapEnds.Name = "lblColourScaleMapEnds"
        Me.lblColourScaleMapEnds.Size = New System.Drawing.Size(198, 13)
        Me.lblColourScaleMapEnds.TabIndex = 3
        Me.lblColourScaleMapEnds.Text = "Corrected Hue Where Colour Map Ends:"
        '
        'lblColourScaleMapBegins
        '
        Me.lblColourScaleMapBegins.AutoSize = True
        Me.lblColourScaleMapBegins.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColourScaleMapBegins.Location = New System.Drawing.Point(7, 75)
        Me.lblColourScaleMapBegins.Name = "lblColourScaleMapBegins"
        Me.lblColourScaleMapBegins.Size = New System.Drawing.Size(206, 13)
        Me.lblColourScaleMapBegins.TabIndex = 2
        Me.lblColourScaleMapBegins.Text = "Corrected Hue Where Colour Map Begins:"
        '
        'lblColourScalePalette
        '
        Me.lblColourScalePalette.AutoSize = True
        Me.lblColourScalePalette.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColourScalePalette.Location = New System.Drawing.Point(7, 25)
        Me.lblColourScalePalette.Name = "lblColourScalePalette"
        Me.lblColourScalePalette.Size = New System.Drawing.Size(76, 13)
        Me.lblColourScalePalette.TabIndex = 1
        Me.lblColourScalePalette.Text = "Colour Palette:"
        '
        'lblColourScaleTransparency
        '
        Me.lblColourScaleTransparency.AutoSize = True
        Me.lblColourScaleTransparency.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColourScaleTransparency.Location = New System.Drawing.Point(7, 50)
        Me.lblColourScaleTransparency.Name = "lblColourScaleTransparency"
        Me.lblColourScaleTransparency.Size = New System.Drawing.Size(75, 13)
        Me.lblColourScaleTransparency.TabIndex = 0
        Me.lblColourScaleTransparency.Text = "Transparency:"
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
        Me.grpFillScale.Location = New System.Drawing.Point(13, 30)
        Me.grpFillScale.Name = "grpFillScale"
        Me.grpFillScale.Size = New System.Drawing.Size(444, 163)
        Me.grpFillScale.TabIndex = 23
        Me.grpFillScale.TabStop = False
        Me.grpFillScale.Text = "Fill Scale"
        '
        'ucrChkFillDiscrete
        '
        Me.ucrChkFillDiscrete.AutoSize = True
        Me.ucrChkFillDiscrete.Checked = False
        Me.ucrChkFillDiscrete.Location = New System.Drawing.Point(7, 119)
        Me.ucrChkFillDiscrete.Name = "ucrChkFillDiscrete"
        Me.ucrChkFillDiscrete.Size = New System.Drawing.Size(352, 23)
        Me.ucrChkFillDiscrete.TabIndex = 10
        '
        'ucrNudFillScaleTransparency
        '
        Me.ucrNudFillScaleTransparency.AutoSize = True
        Me.ucrNudFillScaleTransparency.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFillScaleTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFillScaleTransparency.Location = New System.Drawing.Point(268, 43)
        Me.ucrNudFillScaleTransparency.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFillScaleTransparency.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFillScaleTransparency.Name = "ucrNudFillScaleTransparency"
        Me.ucrNudFillScaleTransparency.Size = New System.Drawing.Size(50, 21)
        Me.ucrNudFillScaleTransparency.TabIndex = 9
        Me.ucrNudFillScaleTransparency.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudFillScaleMapEnds
        '
        Me.ucrNudFillScaleMapEnds.AutoSize = True
        Me.ucrNudFillScaleMapEnds.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFillScaleMapEnds.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFillScaleMapEnds.Location = New System.Drawing.Point(268, 94)
        Me.ucrNudFillScaleMapEnds.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFillScaleMapEnds.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFillScaleMapEnds.Name = "ucrNudFillScaleMapEnds"
        Me.ucrNudFillScaleMapEnds.Size = New System.Drawing.Size(50, 22)
        Me.ucrNudFillScaleMapEnds.TabIndex = 8
        Me.ucrNudFillScaleMapEnds.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudFillScaleMapBegins
        '
        Me.ucrNudFillScaleMapBegins.AutoSize = True
        Me.ucrNudFillScaleMapBegins.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFillScaleMapBegins.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFillScaleMapBegins.Location = New System.Drawing.Point(268, 69)
        Me.ucrNudFillScaleMapBegins.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFillScaleMapBegins.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFillScaleMapBegins.Name = "ucrNudFillScaleMapBegins"
        Me.ucrNudFillScaleMapBegins.Size = New System.Drawing.Size(50, 27)
        Me.ucrNudFillScaleMapBegins.TabIndex = 7
        Me.ucrNudFillScaleMapBegins.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputFillScaleColour
        '
        Me.ucrInputFillScaleColour.AddQuotesIfUnrecognised = True
        Me.ucrInputFillScaleColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFillScaleColour.GetSetSelectedIndex = -1
        Me.ucrInputFillScaleColour.IsReadOnly = False
        Me.ucrInputFillScaleColour.Location = New System.Drawing.Point(268, 14)
        Me.ucrInputFillScaleColour.Name = "ucrInputFillScaleColour"
        Me.ucrInputFillScaleColour.Size = New System.Drawing.Size(137, 24)
        Me.ucrInputFillScaleColour.TabIndex = 6
        '
        'ucrChkFillScaleReverseColourOrder
        '
        Me.ucrChkFillScaleReverseColourOrder.AutoSize = True
        Me.ucrChkFillScaleReverseColourOrder.Checked = False
        Me.ucrChkFillScaleReverseColourOrder.Location = New System.Drawing.Point(7, 139)
        Me.ucrChkFillScaleReverseColourOrder.Name = "ucrChkFillScaleReverseColourOrder"
        Me.ucrChkFillScaleReverseColourOrder.Size = New System.Drawing.Size(352, 23)
        Me.ucrChkFillScaleReverseColourOrder.TabIndex = 5
        '
        'lblFillScaleMapEnds
        '
        Me.lblFillScaleMapEnds.AutoSize = True
        Me.lblFillScaleMapEnds.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFillScaleMapEnds.Location = New System.Drawing.Point(7, 98)
        Me.lblFillScaleMapEnds.Name = "lblFillScaleMapEnds"
        Me.lblFillScaleMapEnds.Size = New System.Drawing.Size(198, 13)
        Me.lblFillScaleMapEnds.TabIndex = 3
        Me.lblFillScaleMapEnds.Text = "Corrected Hue Where Colour Map Ends:"
        '
        'lblFillScaleBeginColour
        '
        Me.lblFillScaleBeginColour.AutoSize = True
        Me.lblFillScaleBeginColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFillScaleBeginColour.Location = New System.Drawing.Point(7, 73)
        Me.lblFillScaleBeginColour.Name = "lblFillScaleBeginColour"
        Me.lblFillScaleBeginColour.Size = New System.Drawing.Size(206, 13)
        Me.lblFillScaleBeginColour.TabIndex = 2
        Me.lblFillScaleBeginColour.Text = "Corrected Hue Where Colour Map Begins:"
        '
        'lblFillScaleColourPalettte
        '
        Me.lblFillScaleColourPalettte.AutoSize = True
        Me.lblFillScaleColourPalettte.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFillScaleColourPalettte.Location = New System.Drawing.Point(7, 23)
        Me.lblFillScaleColourPalettte.Name = "lblFillScaleColourPalettte"
        Me.lblFillScaleColourPalettte.Size = New System.Drawing.Size(76, 13)
        Me.lblFillScaleColourPalettte.TabIndex = 1
        Me.lblFillScaleColourPalettte.Text = "Colour Palette:"
        '
        'lblFillScaleTransparency
        '
        Me.lblFillScaleTransparency.AutoSize = True
        Me.lblFillScaleTransparency.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFillScaleTransparency.Location = New System.Drawing.Point(7, 48)
        Me.lblFillScaleTransparency.Name = "lblFillScaleTransparency"
        Me.lblFillScaleTransparency.Size = New System.Drawing.Size(75, 13)
        Me.lblFillScaleTransparency.TabIndex = 0
        Me.lblFillScaleTransparency.Text = "Transparency:"
        '
        'tbpAnnotation
        '
        Me.tbpAnnotation.Controls.Add(Me.ucrChkAnnotation)
        Me.tbpAnnotation.Controls.Add(Me.grpAnnotation)
        Me.tbpAnnotation.Location = New System.Drawing.Point(4, 22)
        Me.tbpAnnotation.Name = "tbpAnnotation"
        Me.tbpAnnotation.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAnnotation.Size = New System.Drawing.Size(669, 423)
        Me.tbpAnnotation.TabIndex = 9
        Me.tbpAnnotation.Text = "Annotation"
        Me.tbpAnnotation.UseVisualStyleBackColor = True
        '
        'ucrChkAnnotation
        '
        Me.ucrChkAnnotation.AutoSize = True
        Me.ucrChkAnnotation.Checked = False
        Me.ucrChkAnnotation.Location = New System.Drawing.Point(7, 17)
        Me.ucrChkAnnotation.Name = "ucrChkAnnotation"
        Me.ucrChkAnnotation.Size = New System.Drawing.Size(278, 23)
        Me.ucrChkAnnotation.TabIndex = 44
        '
        'grpAnnotation
        '
        Me.grpAnnotation.Controls.Add(Me.ucrChkParse)
        Me.grpAnnotation.Controls.Add(Me.ucrInputFill)
        Me.grpAnnotation.Controls.Add(Me.ucrInputColour)
        Me.grpAnnotation.Controls.Add(Me.lblCurvature)
        Me.grpAnnotation.Controls.Add(Me.ucrNudAlpha)
        Me.grpAnnotation.Controls.Add(Me.lblAlpha)
        Me.grpAnnotation.Controls.Add(Me.lblLineend)
        Me.grpAnnotation.Controls.Add(Me.lblAngle)
        Me.grpAnnotation.Controls.Add(Me.ucrNudAngle)
        Me.grpAnnotation.Controls.Add(Me.lblShape)
        Me.grpAnnotation.Controls.Add(Me.lblAnnotationGeoms)
        Me.grpAnnotation.Controls.Add(Me.ucrInputAnnotationGeoms)
        Me.grpAnnotation.Controls.Add(Me.lblSize)
        Me.grpAnnotation.Controls.Add(Me.ucrNudSize)
        Me.grpAnnotation.Controls.Add(Me.lblColour)
        Me.grpAnnotation.Controls.Add(Me.lblY)
        Me.grpAnnotation.Controls.Add(Me.lblX)
        Me.grpAnnotation.Controls.Add(Me.lblFill)
        Me.grpAnnotation.Controls.Add(Me.lblXmax)
        Me.grpAnnotation.Controls.Add(Me.ucrInputXmax)
        Me.grpAnnotation.Controls.Add(Me.ucrInputYmin)
        Me.grpAnnotation.Controls.Add(Me.ucrInputXmin)
        Me.grpAnnotation.Controls.Add(Me.lblYmin)
        Me.grpAnnotation.Controls.Add(Me.lblXmin)
        Me.grpAnnotation.Controls.Add(Me.lblXend)
        Me.grpAnnotation.Controls.Add(Me.lblYmax)
        Me.grpAnnotation.Controls.Add(Me.ucrInputYmax)
        Me.grpAnnotation.Controls.Add(Me.ucrInputYend)
        Me.grpAnnotation.Controls.Add(Me.ucrInputXend)
        Me.grpAnnotation.Controls.Add(Me.lblYend)
        Me.grpAnnotation.Controls.Add(Me.ucrNudLinetype)
        Me.grpAnnotation.Controls.Add(Me.lblLinetype)
        Me.grpAnnotation.Controls.Add(Me.lblPointrangeFatten)
        Me.grpAnnotation.Controls.Add(Me.ucrNudPointrangeFatten)
        Me.grpAnnotation.Controls.Add(Me.ucrNudCrossbarFatten)
        Me.grpAnnotation.Controls.Add(Me.lblCrossbarFatten)
        Me.grpAnnotation.Controls.Add(Me.ucrNudCurvature)
        Me.grpAnnotation.Controls.Add(Me.ucrNudShape)
        Me.grpAnnotation.Controls.Add(Me.lblLabel)
        Me.grpAnnotation.Controls.Add(Me.ucrInputLabel)
        Me.grpAnnotation.Controls.Add(Me.ucrInputLineend)
        Me.grpAnnotation.Controls.Add(Me.ucrInputY)
        Me.grpAnnotation.Controls.Add(Me.ucrInputX)
        Me.grpAnnotation.Controls.Add(Me.ucrReceiverY)
        Me.grpAnnotation.Location = New System.Drawing.Point(7, 43)
        Me.grpAnnotation.Name = "grpAnnotation"
        Me.grpAnnotation.Size = New System.Drawing.Size(459, 374)
        Me.grpAnnotation.TabIndex = 43
        Me.grpAnnotation.TabStop = False
        Me.grpAnnotation.Text = "Annotation"
        '
        'ucrChkParse
        '
        Me.ucrChkParse.AutoSize = True
        Me.ucrChkParse.Checked = False
        Me.ucrChkParse.Location = New System.Drawing.Point(75, 230)
        Me.ucrChkParse.Name = "ucrChkParse"
        Me.ucrChkParse.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkParse.TabIndex = 102
        '
        'ucrInputFill
        '
        Me.ucrInputFill.AddQuotesIfUnrecognised = True
        Me.ucrInputFill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFill.GetSetSelectedIndex = -1
        Me.ucrInputFill.IsReadOnly = False
        Me.ucrInputFill.Location = New System.Drawing.Point(75, 179)
        Me.ucrInputFill.Name = "ucrInputFill"
        Me.ucrInputFill.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputFill.TabIndex = 101
        '
        'ucrInputColour
        '
        Me.ucrInputColour.AddQuotesIfUnrecognised = True
        Me.ucrInputColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputColour.GetSetSelectedIndex = -1
        Me.ucrInputColour.IsReadOnly = False
        Me.ucrInputColour.Location = New System.Drawing.Point(75, 81)
        Me.ucrInputColour.Name = "ucrInputColour"
        Me.ucrInputColour.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputColour.TabIndex = 100
        '
        'lblCurvature
        '
        Me.lblCurvature.AutoSize = True
        Me.lblCurvature.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCurvature.Location = New System.Drawing.Point(7, 184)
        Me.lblCurvature.Name = "lblCurvature"
        Me.lblCurvature.Size = New System.Drawing.Size(58, 13)
        Me.lblCurvature.TabIndex = 85
        Me.lblCurvature.Text = "curvature :"
        '
        'ucrNudAlpha
        '
        Me.ucrNudAlpha.AutoSize = True
        Me.ucrNudAlpha.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAlpha.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAlpha.Location = New System.Drawing.Point(75, 130)
        Me.ucrNudAlpha.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAlpha.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAlpha.Name = "ucrNudAlpha"
        Me.ucrNudAlpha.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAlpha.TabIndex = 20
        Me.ucrNudAlpha.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblAlpha
        '
        Me.lblAlpha.AutoSize = True
        Me.lblAlpha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAlpha.Location = New System.Drawing.Point(26, 135)
        Me.lblAlpha.Name = "lblAlpha"
        Me.lblAlpha.Size = New System.Drawing.Size(39, 13)
        Me.lblAlpha.TabIndex = 19
        Me.lblAlpha.Text = "alpha :"
        '
        'lblLineend
        '
        Me.lblLineend.AutoSize = True
        Me.lblLineend.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineend.Location = New System.Drawing.Point(18, 184)
        Me.lblLineend.Name = "lblLineend"
        Me.lblLineend.Size = New System.Drawing.Size(47, 13)
        Me.lblLineend.TabIndex = 83
        Me.lblLineend.Text = "lineend :"
        '
        'lblAngle
        '
        Me.lblAngle.AutoSize = True
        Me.lblAngle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAngle.Location = New System.Drawing.Point(26, 208)
        Me.lblAngle.Name = "lblAngle"
        Me.lblAngle.Size = New System.Drawing.Size(39, 13)
        Me.lblAngle.TabIndex = 80
        Me.lblAngle.Text = "angle :"
        '
        'ucrNudAngle
        '
        Me.ucrNudAngle.AutoSize = True
        Me.ucrNudAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAngle.Location = New System.Drawing.Point(75, 204)
        Me.ucrNudAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAngle.Name = "ucrNudAngle"
        Me.ucrNudAngle.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAngle.TabIndex = 78
        Me.ucrNudAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblShape
        '
        Me.lblShape.AutoSize = True
        Me.lblShape.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblShape.Location = New System.Drawing.Point(23, 210)
        Me.lblShape.Name = "lblShape"
        Me.lblShape.Size = New System.Drawing.Size(42, 13)
        Me.lblShape.TabIndex = 79
        Me.lblShape.Text = "shape :"
        '
        'lblAnnotationGeoms
        '
        Me.lblAnnotationGeoms.AutoSize = True
        Me.lblAnnotationGeoms.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAnnotationGeoms.Location = New System.Drawing.Point(25, 24)
        Me.lblAnnotationGeoms.Name = "lblAnnotationGeoms"
        Me.lblAnnotationGeoms.Size = New System.Drawing.Size(41, 13)
        Me.lblAnnotationGeoms.TabIndex = 77
        Me.lblAnnotationGeoms.Text = "Geom :"
        '
        'ucrInputAnnotationGeoms
        '
        Me.ucrInputAnnotationGeoms.AddQuotesIfUnrecognised = True
        Me.ucrInputAnnotationGeoms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputAnnotationGeoms.GetSetSelectedIndex = -1
        Me.ucrInputAnnotationGeoms.IsReadOnly = False
        Me.ucrInputAnnotationGeoms.Location = New System.Drawing.Point(75, 19)
        Me.ucrInputAnnotationGeoms.Name = "ucrInputAnnotationGeoms"
        Me.ucrInputAnnotationGeoms.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputAnnotationGeoms.TabIndex = 76
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSize.Location = New System.Drawing.Point(34, 111)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(31, 13)
        Me.lblSize.TabIndex = 75
        Me.lblSize.Text = "size :"
        '
        'ucrNudSize
        '
        Me.ucrNudSize.AutoSize = True
        Me.ucrNudSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSize.Location = New System.Drawing.Point(75, 106)
        Me.ucrNudSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSize.Name = "ucrNudSize"
        Me.ucrNudSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSize.TabIndex = 74
        Me.ucrNudSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColour.Location = New System.Drawing.Point(23, 87)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(42, 13)
        Me.lblColour.TabIndex = 73
        Me.lblColour.Text = "colour :"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblY.Location = New System.Drawing.Point(291, 56)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(18, 13)
        Me.lblY.TabIndex = 69
        Me.lblY.Text = "y :"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblX.Location = New System.Drawing.Point(294, 31)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(15, 13)
        Me.lblX.TabIndex = 68
        Me.lblX.Text = "x:"
        '
        'lblFill
        '
        Me.lblFill.AutoSize = True
        Me.lblFill.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFill.Location = New System.Drawing.Point(43, 184)
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Size = New System.Drawing.Size(22, 13)
        Me.lblFill.TabIndex = 61
        Me.lblFill.Text = "fill :"
        '
        'lblXmax
        '
        Me.lblXmax.AutoSize = True
        Me.lblXmax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXmax.Location = New System.Drawing.Point(272, 132)
        Me.lblXmax.Name = "lblXmax"
        Me.lblXmax.Size = New System.Drawing.Size(37, 13)
        Me.lblXmax.TabIndex = 51
        Me.lblXmax.Text = "xmax :"
        '
        'ucrInputXmax
        '
        Me.ucrInputXmax.AddQuotesIfUnrecognised = True
        Me.ucrInputXmax.AutoSize = True
        Me.ucrInputXmax.IsMultiline = False
        Me.ucrInputXmax.IsReadOnly = False
        Me.ucrInputXmax.Location = New System.Drawing.Point(318, 127)
        Me.ucrInputXmax.Name = "ucrInputXmax"
        Me.ucrInputXmax.Size = New System.Drawing.Size(116, 21)
        Me.ucrInputXmax.TabIndex = 50
        '
        'ucrInputYmin
        '
        Me.ucrInputYmin.AddQuotesIfUnrecognised = True
        Me.ucrInputYmin.AutoSize = True
        Me.ucrInputYmin.IsMultiline = False
        Me.ucrInputYmin.IsReadOnly = False
        Me.ucrInputYmin.Location = New System.Drawing.Point(318, 102)
        Me.ucrInputYmin.Name = "ucrInputYmin"
        Me.ucrInputYmin.Size = New System.Drawing.Size(116, 21)
        Me.ucrInputYmin.TabIndex = 49
        '
        'ucrInputXmin
        '
        Me.ucrInputXmin.AddQuotesIfUnrecognised = True
        Me.ucrInputXmin.AutoSize = True
        Me.ucrInputXmin.IsMultiline = False
        Me.ucrInputXmin.IsReadOnly = False
        Me.ucrInputXmin.Location = New System.Drawing.Point(318, 77)
        Me.ucrInputXmin.Name = "ucrInputXmin"
        Me.ucrInputXmin.Size = New System.Drawing.Size(116, 21)
        Me.ucrInputXmin.TabIndex = 48
        '
        'lblYmin
        '
        Me.lblYmin.AutoSize = True
        Me.lblYmin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYmin.Location = New System.Drawing.Point(275, 106)
        Me.lblYmin.Name = "lblYmin"
        Me.lblYmin.Size = New System.Drawing.Size(34, 13)
        Me.lblYmin.TabIndex = 47
        Me.lblYmin.Text = "ymin :"
        '
        'lblXmin
        '
        Me.lblXmin.AutoSize = True
        Me.lblXmin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXmin.Location = New System.Drawing.Point(275, 81)
        Me.lblXmin.Name = "lblXmin"
        Me.lblXmin.Size = New System.Drawing.Size(34, 13)
        Me.lblXmin.TabIndex = 46
        Me.lblXmin.Text = "xmin :"
        '
        'lblXend
        '
        Me.lblXend.AutoSize = True
        Me.lblXend.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXend.Location = New System.Drawing.Point(273, 181)
        Me.lblXend.Name = "lblXend"
        Me.lblXend.Size = New System.Drawing.Size(36, 13)
        Me.lblXend.TabIndex = 40
        Me.lblXend.Text = "xend :"
        '
        'lblYmax
        '
        Me.lblYmax.AutoSize = True
        Me.lblYmax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYmax.Location = New System.Drawing.Point(272, 156)
        Me.lblYmax.Name = "lblYmax"
        Me.lblYmax.Size = New System.Drawing.Size(37, 13)
        Me.lblYmax.TabIndex = 39
        Me.lblYmax.Text = "ymax :"
        '
        'ucrInputYmax
        '
        Me.ucrInputYmax.AddQuotesIfUnrecognised = True
        Me.ucrInputYmax.AutoSize = True
        Me.ucrInputYmax.IsMultiline = False
        Me.ucrInputYmax.IsReadOnly = False
        Me.ucrInputYmax.Location = New System.Drawing.Point(319, 152)
        Me.ucrInputYmax.Name = "ucrInputYmax"
        Me.ucrInputYmax.Size = New System.Drawing.Size(115, 21)
        Me.ucrInputYmax.TabIndex = 38
        '
        'ucrInputYend
        '
        Me.ucrInputYend.AddQuotesIfUnrecognised = True
        Me.ucrInputYend.AutoSize = True
        Me.ucrInputYend.IsMultiline = False
        Me.ucrInputYend.IsReadOnly = False
        Me.ucrInputYend.Location = New System.Drawing.Point(319, 202)
        Me.ucrInputYend.Name = "ucrInputYend"
        Me.ucrInputYend.Size = New System.Drawing.Size(115, 21)
        Me.ucrInputYend.TabIndex = 37
        '
        'ucrInputXend
        '
        Me.ucrInputXend.AddQuotesIfUnrecognised = True
        Me.ucrInputXend.AutoSize = True
        Me.ucrInputXend.IsMultiline = False
        Me.ucrInputXend.IsReadOnly = False
        Me.ucrInputXend.Location = New System.Drawing.Point(319, 177)
        Me.ucrInputXend.Name = "ucrInputXend"
        Me.ucrInputXend.Size = New System.Drawing.Size(115, 21)
        Me.ucrInputXend.TabIndex = 36
        '
        'lblYend
        '
        Me.lblYend.AutoSize = True
        Me.lblYend.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYend.Location = New System.Drawing.Point(273, 206)
        Me.lblYend.Name = "lblYend"
        Me.lblYend.Size = New System.Drawing.Size(36, 13)
        Me.lblYend.TabIndex = 35
        Me.lblYend.Text = "yend :"
        '
        'ucrNudLinetype
        '
        Me.ucrNudLinetype.AutoSize = True
        Me.ucrNudLinetype.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLinetype.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLinetype.Location = New System.Drawing.Point(75, 154)
        Me.ucrNudLinetype.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLinetype.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLinetype.Name = "ucrNudLinetype"
        Me.ucrNudLinetype.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLinetype.TabIndex = 62
        Me.ucrNudLinetype.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLinetype
        '
        Me.lblLinetype.AutoSize = True
        Me.lblLinetype.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLinetype.Location = New System.Drawing.Point(16, 159)
        Me.lblLinetype.Name = "lblLinetype"
        Me.lblLinetype.Size = New System.Drawing.Size(49, 13)
        Me.lblLinetype.TabIndex = 63
        Me.lblLinetype.Text = "linetype :"
        '
        'lblPointrangeFatten
        '
        Me.lblPointrangeFatten.AutoSize = True
        Me.lblPointrangeFatten.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPointrangeFatten.Location = New System.Drawing.Point(25, 184)
        Me.lblPointrangeFatten.Name = "lblPointrangeFatten"
        Me.lblPointrangeFatten.Size = New System.Drawing.Size(40, 13)
        Me.lblPointrangeFatten.TabIndex = 89
        Me.lblPointrangeFatten.Text = "fatten :"
        '
        'ucrNudPointrangeFatten
        '
        Me.ucrNudPointrangeFatten.AutoSize = True
        Me.ucrNudPointrangeFatten.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPointrangeFatten.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPointrangeFatten.Location = New System.Drawing.Point(75, 179)
        Me.ucrNudPointrangeFatten.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPointrangeFatten.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPointrangeFatten.Name = "ucrNudPointrangeFatten"
        Me.ucrNudPointrangeFatten.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPointrangeFatten.TabIndex = 88
        Me.ucrNudPointrangeFatten.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudCrossbarFatten
        '
        Me.ucrNudCrossbarFatten.AutoSize = True
        Me.ucrNudCrossbarFatten.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCrossbarFatten.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCrossbarFatten.Location = New System.Drawing.Point(75, 179)
        Me.ucrNudCrossbarFatten.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCrossbarFatten.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCrossbarFatten.Name = "ucrNudCrossbarFatten"
        Me.ucrNudCrossbarFatten.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCrossbarFatten.TabIndex = 87
        Me.ucrNudCrossbarFatten.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblCrossbarFatten
        '
        Me.lblCrossbarFatten.AutoSize = True
        Me.lblCrossbarFatten.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCrossbarFatten.Location = New System.Drawing.Point(25, 184)
        Me.lblCrossbarFatten.Name = "lblCrossbarFatten"
        Me.lblCrossbarFatten.Size = New System.Drawing.Size(40, 13)
        Me.lblCrossbarFatten.TabIndex = 86
        Me.lblCrossbarFatten.Text = "fatten :"
        '
        'ucrNudCurvature
        '
        Me.ucrNudCurvature.AutoSize = True
        Me.ucrNudCurvature.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCurvature.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCurvature.Location = New System.Drawing.Point(75, 179)
        Me.ucrNudCurvature.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCurvature.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCurvature.Name = "ucrNudCurvature"
        Me.ucrNudCurvature.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCurvature.TabIndex = 84
        Me.ucrNudCurvature.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudShape
        '
        Me.ucrNudShape.AutoSize = True
        Me.ucrNudShape.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShape.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudShape.Location = New System.Drawing.Point(75, 204)
        Me.ucrNudShape.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudShape.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShape.Name = "ucrNudShape"
        Me.ucrNudShape.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudShape.TabIndex = 81
        Me.ucrNudShape.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabel.Location = New System.Drawing.Point(30, 159)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(35, 13)
        Me.lblLabel.TabIndex = 91
        Me.lblLabel.Text = "label :"
        '
        'ucrInputLabel
        '
        Me.ucrInputLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputLabel.AutoSize = True
        Me.ucrInputLabel.IsMultiline = False
        Me.ucrInputLabel.IsReadOnly = False
        Me.ucrInputLabel.Location = New System.Drawing.Point(75, 154)
        Me.ucrInputLabel.Name = "ucrInputLabel"
        Me.ucrInputLabel.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLabel.TabIndex = 90
        '
        'ucrInputLineend
        '
        Me.ucrInputLineend.AddQuotesIfUnrecognised = True
        Me.ucrInputLineend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLineend.GetSetSelectedIndex = -1
        Me.ucrInputLineend.IsReadOnly = False
        Me.ucrInputLineend.Location = New System.Drawing.Point(75, 179)
        Me.ucrInputLineend.Name = "ucrInputLineend"
        Me.ucrInputLineend.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLineend.TabIndex = 82
        '
        'ucrInputY
        '
        Me.ucrInputY.AddQuotesIfUnrecognised = True
        Me.ucrInputY.AutoSize = True
        Me.ucrInputY.IsMultiline = False
        Me.ucrInputY.IsReadOnly = False
        Me.ucrInputY.Location = New System.Drawing.Point(318, 52)
        Me.ucrInputY.Name = "ucrInputY"
        Me.ucrInputY.Size = New System.Drawing.Size(116, 21)
        Me.ucrInputY.TabIndex = 70
        '
        'ucrInputX
        '
        Me.ucrInputX.AddQuotesIfUnrecognised = True
        Me.ucrInputX.AutoSize = True
        Me.ucrInputX.IsMultiline = False
        Me.ucrInputX.IsReadOnly = False
        Me.ucrInputX.Location = New System.Drawing.Point(318, 27)
        Me.ucrInputX.Name = "ucrInputX"
        Me.ucrInputX.Size = New System.Drawing.Size(116, 21)
        Me.ucrInputX.TabIndex = 71
        '
        'ucrReceiverY
        '
        Me.ucrReceiverY.AutoSize = True
        Me.ucrReceiverY.frmParent = Nothing
        Me.ucrReceiverY.Location = New System.Drawing.Point(318, 52)
        Me.ucrReceiverY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverY.Name = "ucrReceiverY"
        Me.ucrReceiverY.Selector = Nothing
        Me.ucrReceiverY.Size = New System.Drawing.Size(116, 21)
        Me.ucrReceiverY.strNcFilePath = ""
        Me.ucrReceiverY.TabIndex = 99
        Me.ucrReceiverY.ucrSelector = Nothing
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(249, 470)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(224, 29)
        Me.ucrBaseSubdialog.TabIndex = 1
        '
        'sdgPlots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(687, 502)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.tbpPlotsOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPlots"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Plot_Options"
        Me.Text = "Plot Options"
        Me.tbpPlotsOptions.ResumeLayout(False)
        Me.tbpFacet.ResumeLayout(False)
        Me.tbpFacet.PerformLayout()
        Me.tbpLayers.ResumeLayout(False)
        Me.tbpLayers.PerformLayout()
        Me.tbpTitles.ResumeLayout(False)
        Me.tbpTitles.PerformLayout()
        Me.grpLegendTitle.ResumeLayout(False)
        Me.grpLegendTitle.PerformLayout()
        Me.tbpXAxis.ResumeLayout(False)
        Me.tbpXAxis.PerformLayout()
        Me.tbpYAxis.ResumeLayout(False)
        Me.tbpYAxis.PerformLayout()
        Me.tbpTheme.ResumeLayout(False)
        Me.tbpTheme.PerformLayout()
        Me.grpCommonOptions.ResumeLayout(False)
        Me.grpCommonOptions.PerformLayout()
        Me.tbpCoordinates.ResumeLayout(False)
        Me.tbpCoordinates.PerformLayout()
        Me.grpPolarCordinates.ResumeLayout(False)
        Me.grpPolarCordinates.PerformLayout()
        Me.tbpColour.ResumeLayout(False)
        Me.tbpColour.PerformLayout()
        Me.grpColourScale.ResumeLayout(False)
        Me.grpColourScale.PerformLayout()
        Me.grpFillScale.ResumeLayout(False)
        Me.grpFillScale.PerformLayout()
        Me.tbpAnnotation.ResumeLayout(False)
        Me.tbpAnnotation.PerformLayout()
        Me.grpAnnotation.ResumeLayout(False)
        Me.grpAnnotation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents tbpAnnotation As TabPage
    Friend WithEvents ucrNudAlpha As ucrNud
    Friend WithEvents lblAlpha As Label
    Friend WithEvents grpAnnotation As GroupBox
    Friend WithEvents lblCurvature As Label
    Friend WithEvents lblLineend As Label
    Friend WithEvents ucrInputLineend As ucrInputComboBox
    Friend WithEvents lblAngle As Label
    Friend WithEvents ucrNudAngle As ucrNud
    Friend WithEvents lblShape As Label
    Friend WithEvents lblAnnotationGeoms As Label
    Friend WithEvents ucrInputAnnotationGeoms As ucrInputComboBox
    Friend WithEvents lblSize As Label
    Friend WithEvents ucrNudSize As ucrNud
    Friend WithEvents lblColour As Label
    Friend WithEvents ucrInputX As ucrInputTextBox
    Friend WithEvents ucrInputY As ucrInputTextBox
    Friend WithEvents lblY As Label
    Friend WithEvents lblX As Label
    Friend WithEvents lblFill As Label
    Friend WithEvents lblXmax As Label
    Friend WithEvents ucrInputXmax As ucrInputTextBox
    Friend WithEvents ucrInputYmin As ucrInputTextBox
    Friend WithEvents ucrInputXmin As ucrInputTextBox
    Friend WithEvents lblYmin As Label
    Friend WithEvents lblXmin As Label
    Friend WithEvents lblXend As Label
    Friend WithEvents lblYmax As Label
    Friend WithEvents ucrInputYmax As ucrInputTextBox
    Friend WithEvents ucrInputYend As ucrInputTextBox
    Friend WithEvents ucrInputXend As ucrInputTextBox
    Friend WithEvents lblYend As Label
    Friend WithEvents lblPointrangeFatten As Label
    Friend WithEvents ucrNudPointrangeFatten As ucrNud
    Friend WithEvents ucrNudCrossbarFatten As ucrNud
    Friend WithEvents lblCrossbarFatten As Label
    Friend WithEvents ucrNudCurvature As ucrNud
    Friend WithEvents ucrNudShape As ucrNud
    Friend WithEvents ucrChkAnnotation As ucrCheck
    Friend WithEvents lblLabel As Label
    Friend WithEvents ucrInputLabel As ucrInputTextBox
    Friend WithEvents ucrNudLinetype As ucrNud
    Friend WithEvents lblLinetype As Label
    Friend WithEvents ucrReceiverY As ucrReceiverSingle
    Friend WithEvents ucrInputColour As ucrColors
    Friend WithEvents ucrInputFill As ucrColors
    Friend WithEvents ucrChkParse As ucrCheck
End Class


