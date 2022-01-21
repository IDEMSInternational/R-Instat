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
Partial Class sdgThemes
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
        Me.ucrBaseSubdialogue = New instat.ucrButtonsSubdialogue()
        Me.tbThemeFacets = New System.Windows.Forms.TabPage()
        Me.grpSpaceBetweenStripsAxes = New System.Windows.Forms.GroupBox()
        Me.ucrStripsSpaceWrap = New instat.ucrGridUnit()
        Me.ucrStripsSpaceGrid = New instat.ucrGridUnit()
        Me.grpFacetBackground = New System.Windows.Forms.GroupBox()
        Me.ucrStripBackGround = New instat.ucrElementRectControl()
        Me.grpFacetLabels = New System.Windows.Forms.GroupBox()
        Me.ucrStripTextYAxis = New instat.ucrELementTextControl()
        Me.ucrStripTextXAxis = New instat.ucrELementTextControl()
        Me.ucrStripText = New instat.ucrELementTextControl()
        Me.tbThemePanelAndBackground = New System.Windows.Forms.TabPage()
        Me.grpPanelSpacing = New System.Windows.Forms.GroupBox()
        Me.ucrPanelSpacingYAxis = New instat.ucrGridUnit()
        Me.ucrPanelSpacingXAxis = New instat.ucrGridUnit()
        Me.ucrPanelSpacing = New instat.ucrGridUnit()
        Me.grpBorderAndBackground = New System.Windows.Forms.GroupBox()
        Me.ucrPanelBackGround = New instat.ucrElementRectControl()
        Me.ucrPanelBorder = New instat.ucrElementRectControl()
        Me.grpPanelGrid = New System.Windows.Forms.GroupBox()
        Me.ucrPanelGridMinor = New instat.ucrElementLineControl()
        Me.ucrPanelGridMajor = New instat.ucrElementLineControl()
        Me.ucrPanelGrid = New instat.ucrElementLineControl()
        Me.tbThemeLegend = New System.Windows.Forms.TabPage()
        Me.grpLegendKeyAdjustment = New System.Windows.Forms.GroupBox()
        Me.ucrLegendKeyWidth = New instat.ucrGridUnit()
        Me.ucrLegendKeyHeight = New instat.ucrGridUnit()
        Me.ucrLegendKeySize = New instat.ucrGridUnit()
        Me.grpLegendTitleAndText = New System.Windows.Forms.GroupBox()
        Me.ucrLegendText = New instat.ucrELementTextControl()
        Me.ucrLegendTitle = New instat.ucrELementTextControl()
        Me.grpLegendAdjustments = New System.Windows.Forms.GroupBox()
        Me.ucrInputLegendJustification = New instat.ucrInputComboBox()
        Me.ucrInputLegendBox = New instat.ucrInputComboBox()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrInputLegendDirection = New instat.ucrInputComboBox()
        Me.ucrInputLegendBoxJust = New instat.ucrInputComboBox()
        Me.ucrChkLegendJustification = New instat.ucrCheck()
        Me.ucrChkLegendBox = New instat.ucrCheck()
        Me.urChkLegendPosition = New instat.ucrCheck()
        Me.ucrChkLegendDirection = New instat.ucrCheck()
        Me.urChkLegendBoxJust = New instat.ucrCheck()
        Me.grpLegendBackGroundAndKey = New System.Windows.Forms.GroupBox()
        Me.ucrLegendBoxBackground = New instat.ucrElementRectControl()
        Me.ucrLegendBackground = New instat.ucrElementRectControl()
        Me.ucrLegendKey = New instat.ucrElementRectControl()
        Me.tbThemeYaxis = New System.Windows.Forms.TabPage()
        Me.grpYAxisTitle = New System.Windows.Forms.GroupBox()
        Me.ucrThemeTitleYRightAxis = New instat.ucrELementTextControl()
        Me.ucrThemeTitleYAxis = New instat.ucrELementTextControl()
        Me.grpTickMarkLabelsYAxis = New System.Windows.Forms.GroupBox()
        Me.ucrThemeYRightAxis = New instat.ucrELementTextControl()
        Me.ucrThemeLeftYAxis = New instat.ucrELementTextControl()
        Me.grpTickMarkers = New System.Windows.Forms.GroupBox()
        Me.ucrTickMarksYAxis = New instat.ucrElementLineControl()
        Me.ucrYAxisLines = New instat.ucrElementLineControl()
        Me.tbThemeXAxis = New System.Windows.Forms.TabPage()
        Me.grpTickMarkLabelsXAxis = New System.Windows.Forms.GroupBox()
        Me.ucrThemeTopXAxis = New instat.ucrELementTextControl()
        Me.ucrThemeBottomXAxis = New instat.ucrELementTextControl()
        Me.grpTickMarks = New System.Windows.Forms.GroupBox()
        Me.ucrXAxisLines = New instat.ucrElementLineControl()
        Me.ucrTickMarksXAxis = New instat.ucrElementLineControl()
        Me.grpXAxisTitle = New System.Windows.Forms.GroupBox()
        Me.ucrThemeTitleXTopAxis = New instat.ucrELementTextControl()
        Me.ucrThemeTitleXAxis = New instat.ucrELementTextControl()
        Me.tbXYAxes = New System.Windows.Forms.TabPage()
        Me.grpTickLength = New System.Windows.Forms.GroupBox()
        Me.ucrTickLength = New instat.ucrGridUnit()
        Me.ucrThemeAxesLines = New instat.ucrElementLineControl()
        Me.ucrThemeAxesTickLabels = New instat.ucrELementTextControl()
        Me.ucrTickMarksAxes = New instat.ucrElementLineControl()
        Me.ucrThemeAxesTitle = New instat.ucrELementTextControl()
        Me.tbPLot = New System.Windows.Forms.TabPage()
        Me.grpPlotMargin = New System.Windows.Forms.GroupBox()
        Me.ucrPlotMargin = New instat.ucrGridUnit()
        Me.grpPlotBackground = New System.Windows.Forms.GroupBox()
        Me.ucrPlotBackground = New instat.ucrElementRectControl()
        Me.grpPlotTitleAndCaption = New System.Windows.Forms.GroupBox()
        Me.ucrPlotCaption = New instat.ucrELementTextControl()
        Me.ucrPlotSubTitle = New instat.ucrELementTextControl()
        Me.ucrPlotTitle = New instat.ucrELementTextControl()
        Me.tbLegend = New System.Windows.Forms.TabControl()
        Me.tbThemeLegendMoreOptions = New System.Windows.Forms.TabPage()
        Me.grpLegendBoxSpacing = New System.Windows.Forms.GroupBox()
        Me.ucrLegendBoxSpacing = New instat.ucrGridUnit()
        Me.grpLegendSpacing = New System.Windows.Forms.GroupBox()
        Me.ucrLegendSpacingYAxis = New instat.ucrGridUnit()
        Me.ucrLegendSpacingXAxis = New instat.ucrGridUnit()
        Me.ucrLegendSpacing = New instat.ucrGridUnit()
        Me.tbThemePanelMoreOptions = New System.Windows.Forms.TabPage()
        Me.grpPanelGridMajorMinor = New System.Windows.Forms.GroupBox()
        Me.ucrPanelGridMinorYAxis = New instat.ucrELementTextControl()
        Me.ucrPanelGridMinorXAxis = New instat.ucrELementTextControl()
        Me.ucrPanelGridMajorYAxis = New instat.ucrELementTextControl()
        Me.ucrPanelGridMajorXAxis = New instat.ucrELementTextControl()
        Me.tbThemeFacets.SuspendLayout()
        Me.grpSpaceBetweenStripsAxes.SuspendLayout()
        Me.grpFacetBackground.SuspendLayout()
        Me.grpFacetLabels.SuspendLayout()
        Me.tbThemePanelAndBackground.SuspendLayout()
        Me.grpPanelSpacing.SuspendLayout()
        Me.grpBorderAndBackground.SuspendLayout()
        Me.grpPanelGrid.SuspendLayout()
        Me.tbThemeLegend.SuspendLayout()
        Me.grpLegendKeyAdjustment.SuspendLayout()
        Me.grpLegendTitleAndText.SuspendLayout()
        Me.grpLegendAdjustments.SuspendLayout()
        Me.grpLegendBackGroundAndKey.SuspendLayout()
        Me.tbThemeYaxis.SuspendLayout()
        Me.grpYAxisTitle.SuspendLayout()
        Me.grpTickMarkLabelsYAxis.SuspendLayout()
        Me.grpTickMarkers.SuspendLayout()
        Me.tbThemeXAxis.SuspendLayout()
        Me.grpTickMarkLabelsXAxis.SuspendLayout()
        Me.grpTickMarks.SuspendLayout()
        Me.grpXAxisTitle.SuspendLayout()
        Me.tbXYAxes.SuspendLayout()
        Me.grpTickLength.SuspendLayout()
        Me.tbPLot.SuspendLayout()
        Me.grpPlotMargin.SuspendLayout()
        Me.grpPlotBackground.SuspendLayout()
        Me.grpPlotTitleAndCaption.SuspendLayout()
        Me.tbLegend.SuspendLayout()
        Me.tbThemeLegendMoreOptions.SuspendLayout()
        Me.grpLegendBoxSpacing.SuspendLayout()
        Me.grpLegendSpacing.SuspendLayout()
        Me.tbThemePanelMoreOptions.SuspendLayout()
        Me.grpPanelGridMajorMinor.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBaseSubdialogue
        '
        Me.ucrBaseSubdialogue.AutoSize = True
        Me.ucrBaseSubdialogue.Location = New System.Drawing.Point(344, 621)
        Me.ucrBaseSubdialogue.Name = "ucrBaseSubdialogue"
        Me.ucrBaseSubdialogue.Size = New System.Drawing.Size(224, 30)
        Me.ucrBaseSubdialogue.TabIndex = 1
        '
        'tbThemeFacets
        '
        Me.tbThemeFacets.Controls.Add(Me.grpSpaceBetweenStripsAxes)
        Me.tbThemeFacets.Controls.Add(Me.grpFacetBackground)
        Me.tbThemeFacets.Controls.Add(Me.grpFacetLabels)
        Me.tbThemeFacets.Location = New System.Drawing.Point(4, 22)
        Me.tbThemeFacets.Name = "tbThemeFacets"
        Me.tbThemeFacets.Size = New System.Drawing.Size(817, 583)
        Me.tbThemeFacets.TabIndex = 4
        Me.tbThemeFacets.Text = "Facets"
        Me.tbThemeFacets.UseVisualStyleBackColor = True
        '
        'grpSpaceBetweenStripsAxes
        '
        Me.grpSpaceBetweenStripsAxes.Controls.Add(Me.ucrStripsSpaceWrap)
        Me.grpSpaceBetweenStripsAxes.Controls.Add(Me.ucrStripsSpaceGrid)
        Me.grpSpaceBetweenStripsAxes.Location = New System.Drawing.Point(5, 268)
        Me.grpSpaceBetweenStripsAxes.Name = "grpSpaceBetweenStripsAxes"
        Me.grpSpaceBetweenStripsAxes.Size = New System.Drawing.Size(531, 150)
        Me.grpSpaceBetweenStripsAxes.TabIndex = 1
        Me.grpSpaceBetweenStripsAxes.TabStop = False
        Me.grpSpaceBetweenStripsAxes.Text = "Space between Strips and Axes"
        '
        'ucrStripsSpaceWrap
        '
        Me.ucrStripsSpaceWrap.AutoSize = True
        Me.ucrStripsSpaceWrap.Location = New System.Drawing.Point(265, 21)
        Me.ucrStripsSpaceWrap.Name = "ucrStripsSpaceWrap"
        Me.ucrStripsSpaceWrap.Size = New System.Drawing.Size(261, 125)
        Me.ucrStripsSpaceWrap.TabIndex = 1
        '
        'ucrStripsSpaceGrid
        '
        Me.ucrStripsSpaceGrid.AutoSize = True
        Me.ucrStripsSpaceGrid.Location = New System.Drawing.Point(6, 21)
        Me.ucrStripsSpaceGrid.Name = "ucrStripsSpaceGrid"
        Me.ucrStripsSpaceGrid.Size = New System.Drawing.Size(260, 122)
        Me.ucrStripsSpaceGrid.TabIndex = 0
        '
        'grpFacetBackground
        '
        Me.grpFacetBackground.Controls.Add(Me.ucrStripBackGround)
        Me.grpFacetBackground.Location = New System.Drawing.Point(541, 268)
        Me.grpFacetBackground.Name = "grpFacetBackground"
        Me.grpFacetBackground.Size = New System.Drawing.Size(263, 148)
        Me.grpFacetBackground.TabIndex = 2
        Me.grpFacetBackground.TabStop = False
        Me.grpFacetBackground.Text = "Facet Label Background "
        '
        'ucrStripBackGround
        '
        Me.ucrStripBackGround.AutoSize = True
        Me.ucrStripBackGround.Location = New System.Drawing.Point(2, 21)
        Me.ucrStripBackGround.Name = "ucrStripBackGround"
        Me.ucrStripBackGround.Size = New System.Drawing.Size(253, 128)
        Me.ucrStripBackGround.TabIndex = 0
        '
        'grpFacetLabels
        '
        Me.grpFacetLabels.Controls.Add(Me.ucrStripTextYAxis)
        Me.grpFacetLabels.Controls.Add(Me.ucrStripTextXAxis)
        Me.grpFacetLabels.Controls.Add(Me.ucrStripText)
        Me.grpFacetLabels.Location = New System.Drawing.Point(6, 6)
        Me.grpFacetLabels.Name = "grpFacetLabels"
        Me.grpFacetLabels.Size = New System.Drawing.Size(798, 255)
        Me.grpFacetLabels.TabIndex = 0
        Me.grpFacetLabels.TabStop = False
        Me.grpFacetLabels.Text = "Facet Labels"
        '
        'ucrStripTextYAxis
        '
        Me.ucrStripTextYAxis.AutoSize = True
        Me.ucrStripTextYAxis.Location = New System.Drawing.Point(536, 21)
        Me.ucrStripTextYAxis.Name = "ucrStripTextYAxis"
        Me.ucrStripTextYAxis.Size = New System.Drawing.Size(255, 226)
        Me.ucrStripTextYAxis.TabIndex = 2
        '
        'ucrStripTextXAxis
        '
        Me.ucrStripTextXAxis.AutoSize = True
        Me.ucrStripTextXAxis.Location = New System.Drawing.Point(275, 21)
        Me.ucrStripTextXAxis.Name = "ucrStripTextXAxis"
        Me.ucrStripTextXAxis.Size = New System.Drawing.Size(255, 226)
        Me.ucrStripTextXAxis.TabIndex = 1
        '
        'ucrStripText
        '
        Me.ucrStripText.AutoSize = True
        Me.ucrStripText.Location = New System.Drawing.Point(14, 21)
        Me.ucrStripText.Name = "ucrStripText"
        Me.ucrStripText.Size = New System.Drawing.Size(255, 226)
        Me.ucrStripText.TabIndex = 0
        '
        'tbThemePanelAndBackground
        '
        Me.tbThemePanelAndBackground.Controls.Add(Me.grpPanelSpacing)
        Me.tbThemePanelAndBackground.Controls.Add(Me.grpBorderAndBackground)
        Me.tbThemePanelAndBackground.Controls.Add(Me.grpPanelGrid)
        Me.tbThemePanelAndBackground.Location = New System.Drawing.Point(4, 22)
        Me.tbThemePanelAndBackground.Name = "tbThemePanelAndBackground"
        Me.tbThemePanelAndBackground.Size = New System.Drawing.Size(817, 583)
        Me.tbThemePanelAndBackground.TabIndex = 3
        Me.tbThemePanelAndBackground.Text = "Panel and Background  "
        Me.tbThemePanelAndBackground.UseVisualStyleBackColor = True
        '
        'grpPanelSpacing
        '
        Me.grpPanelSpacing.Controls.Add(Me.ucrPanelSpacingYAxis)
        Me.grpPanelSpacing.Controls.Add(Me.ucrPanelSpacingXAxis)
        Me.grpPanelSpacing.Controls.Add(Me.ucrPanelSpacing)
        Me.grpPanelSpacing.Location = New System.Drawing.Point(4, 315)
        Me.grpPanelSpacing.Name = "grpPanelSpacing"
        Me.grpPanelSpacing.Size = New System.Drawing.Size(800, 150)
        Me.grpPanelSpacing.TabIndex = 2
        Me.grpPanelSpacing.TabStop = False
        Me.grpPanelSpacing.Text = "Panel Spacing"
        '
        'ucrPanelSpacingYAxis
        '
        Me.ucrPanelSpacingYAxis.AutoSize = True
        Me.ucrPanelSpacingYAxis.Location = New System.Drawing.Point(530, 21)
        Me.ucrPanelSpacingYAxis.Name = "ucrPanelSpacingYAxis"
        Me.ucrPanelSpacingYAxis.Size = New System.Drawing.Size(261, 122)
        Me.ucrPanelSpacingYAxis.TabIndex = 2
        '
        'ucrPanelSpacingXAxis
        '
        Me.ucrPanelSpacingXAxis.AutoSize = True
        Me.ucrPanelSpacingXAxis.Location = New System.Drawing.Point(268, 21)
        Me.ucrPanelSpacingXAxis.Name = "ucrPanelSpacingXAxis"
        Me.ucrPanelSpacingXAxis.Size = New System.Drawing.Size(262, 122)
        Me.ucrPanelSpacingXAxis.TabIndex = 1
        '
        'ucrPanelSpacing
        '
        Me.ucrPanelSpacing.AutoSize = True
        Me.ucrPanelSpacing.Location = New System.Drawing.Point(7, 21)
        Me.ucrPanelSpacing.Name = "ucrPanelSpacing"
        Me.ucrPanelSpacing.Size = New System.Drawing.Size(260, 122)
        Me.ucrPanelSpacing.TabIndex = 0
        '
        'grpBorderAndBackground
        '
        Me.grpBorderAndBackground.Controls.Add(Me.ucrPanelBackGround)
        Me.grpBorderAndBackground.Controls.Add(Me.ucrPanelBorder)
        Me.grpBorderAndBackground.Location = New System.Drawing.Point(3, 157)
        Me.grpBorderAndBackground.Name = "grpBorderAndBackground"
        Me.grpBorderAndBackground.Size = New System.Drawing.Size(532, 151)
        Me.grpBorderAndBackground.TabIndex = 1
        Me.grpBorderAndBackground.TabStop = False
        Me.grpBorderAndBackground.Text = "Panel Border and Background "
        '
        'ucrPanelBackGround
        '
        Me.ucrPanelBackGround.AutoSize = True
        Me.ucrPanelBackGround.Location = New System.Drawing.Point(275, 21)
        Me.ucrPanelBackGround.Name = "ucrPanelBackGround"
        Me.ucrPanelBackGround.Size = New System.Drawing.Size(253, 132)
        Me.ucrPanelBackGround.TabIndex = 1
        '
        'ucrPanelBorder
        '
        Me.ucrPanelBorder.AutoSize = True
        Me.ucrPanelBorder.Location = New System.Drawing.Point(14, 21)
        Me.ucrPanelBorder.Name = "ucrPanelBorder"
        Me.ucrPanelBorder.Size = New System.Drawing.Size(253, 132)
        Me.ucrPanelBorder.TabIndex = 0
        '
        'grpPanelGrid
        '
        Me.grpPanelGrid.Controls.Add(Me.ucrPanelGridMinor)
        Me.grpPanelGrid.Controls.Add(Me.ucrPanelGridMajor)
        Me.grpPanelGrid.Controls.Add(Me.ucrPanelGrid)
        Me.grpPanelGrid.Location = New System.Drawing.Point(4, 12)
        Me.grpPanelGrid.Name = "grpPanelGrid"
        Me.grpPanelGrid.Size = New System.Drawing.Size(786, 139)
        Me.grpPanelGrid.TabIndex = 0
        Me.grpPanelGrid.TabStop = False
        Me.grpPanelGrid.Text = "Panel Grid"
        '
        'ucrPanelGridMinor
        '
        Me.ucrPanelGridMinor.AutoSize = True
        Me.ucrPanelGridMinor.Location = New System.Drawing.Point(527, 15)
        Me.ucrPanelGridMinor.Name = "ucrPanelGridMinor"
        Me.ucrPanelGridMinor.Size = New System.Drawing.Size(254, 122)
        Me.ucrPanelGridMinor.TabIndex = 2
        '
        'ucrPanelGridMajor
        '
        Me.ucrPanelGridMajor.AutoSize = True
        Me.ucrPanelGridMajor.Location = New System.Drawing.Point(269, 15)
        Me.ucrPanelGridMajor.Name = "ucrPanelGridMajor"
        Me.ucrPanelGridMajor.Size = New System.Drawing.Size(254, 122)
        Me.ucrPanelGridMajor.TabIndex = 1
        '
        'ucrPanelGrid
        '
        Me.ucrPanelGrid.AutoSize = True
        Me.ucrPanelGrid.Location = New System.Drawing.Point(10, 15)
        Me.ucrPanelGrid.Name = "ucrPanelGrid"
        Me.ucrPanelGrid.Size = New System.Drawing.Size(254, 122)
        Me.ucrPanelGrid.TabIndex = 0
        '
        'tbThemeLegend
        '
        Me.tbThemeLegend.Controls.Add(Me.grpLegendKeyAdjustment)
        Me.tbThemeLegend.Controls.Add(Me.grpLegendTitleAndText)
        Me.tbThemeLegend.Controls.Add(Me.grpLegendAdjustments)
        Me.tbThemeLegend.Controls.Add(Me.grpLegendBackGroundAndKey)
        Me.tbThemeLegend.Location = New System.Drawing.Point(4, 22)
        Me.tbThemeLegend.Name = "tbThemeLegend"
        Me.tbThemeLegend.Padding = New System.Windows.Forms.Padding(3)
        Me.tbThemeLegend.Size = New System.Drawing.Size(817, 583)
        Me.tbThemeLegend.TabIndex = 2
        Me.tbThemeLegend.Text = "Legend"
        Me.tbThemeLegend.UseVisualStyleBackColor = True
        '
        'grpLegendKeyAdjustment
        '
        Me.grpLegendKeyAdjustment.Controls.Add(Me.ucrLegendKeyWidth)
        Me.grpLegendKeyAdjustment.Controls.Add(Me.ucrLegendKeyHeight)
        Me.grpLegendKeyAdjustment.Controls.Add(Me.ucrLegendKeySize)
        Me.grpLegendKeyAdjustment.Location = New System.Drawing.Point(7, 426)
        Me.grpLegendKeyAdjustment.Name = "grpLegendKeyAdjustment"
        Me.grpLegendKeyAdjustment.Size = New System.Drawing.Size(800, 150)
        Me.grpLegendKeyAdjustment.TabIndex = 3
        Me.grpLegendKeyAdjustment.TabStop = False
        Me.grpLegendKeyAdjustment.Text = "Legend Key Measurement"
        '
        'ucrLegendKeyWidth
        '
        Me.ucrLegendKeyWidth.AutoSize = True
        Me.ucrLegendKeyWidth.Location = New System.Drawing.Point(531, 21)
        Me.ucrLegendKeyWidth.Name = "ucrLegendKeyWidth"
        Me.ucrLegendKeyWidth.Size = New System.Drawing.Size(261, 122)
        Me.ucrLegendKeyWidth.TabIndex = 2
        '
        'ucrLegendKeyHeight
        '
        Me.ucrLegendKeyHeight.AutoSize = True
        Me.ucrLegendKeyHeight.Location = New System.Drawing.Point(269, 21)
        Me.ucrLegendKeyHeight.Name = "ucrLegendKeyHeight"
        Me.ucrLegendKeyHeight.Size = New System.Drawing.Size(263, 122)
        Me.ucrLegendKeyHeight.TabIndex = 1
        '
        'ucrLegendKeySize
        '
        Me.ucrLegendKeySize.AutoSize = True
        Me.ucrLegendKeySize.Location = New System.Drawing.Point(9, 21)
        Me.ucrLegendKeySize.Name = "ucrLegendKeySize"
        Me.ucrLegendKeySize.Size = New System.Drawing.Size(260, 122)
        Me.ucrLegendKeySize.TabIndex = 0
        '
        'grpLegendTitleAndText
        '
        Me.grpLegendTitleAndText.Controls.Add(Me.ucrLegendText)
        Me.grpLegendTitleAndText.Controls.Add(Me.ucrLegendTitle)
        Me.grpLegendTitleAndText.Location = New System.Drawing.Point(6, 6)
        Me.grpLegendTitleAndText.Name = "grpLegendTitleAndText"
        Me.grpLegendTitleAndText.Size = New System.Drawing.Size(535, 255)
        Me.grpLegendTitleAndText.TabIndex = 0
        Me.grpLegendTitleAndText.TabStop = False
        Me.grpLegendTitleAndText.Text = "Legend Title and Text"
        '
        'ucrLegendText
        '
        Me.ucrLegendText.AutoSize = True
        Me.ucrLegendText.Location = New System.Drawing.Point(275, 21)
        Me.ucrLegendText.Name = "ucrLegendText"
        Me.ucrLegendText.Size = New System.Drawing.Size(255, 226)
        Me.ucrLegendText.TabIndex = 1
        '
        'ucrLegendTitle
        '
        Me.ucrLegendTitle.AutoSize = True
        Me.ucrLegendTitle.Location = New System.Drawing.Point(14, 21)
        Me.ucrLegendTitle.Name = "ucrLegendTitle"
        Me.ucrLegendTitle.Size = New System.Drawing.Size(255, 226)
        Me.ucrLegendTitle.TabIndex = 0
        '
        'grpLegendAdjustments
        '
        Me.grpLegendAdjustments.Controls.Add(Me.ucrInputLegendJustification)
        Me.grpLegendAdjustments.Controls.Add(Me.ucrInputLegendBox)
        Me.grpLegendAdjustments.Controls.Add(Me.ucrInputLegendPosition)
        Me.grpLegendAdjustments.Controls.Add(Me.ucrInputLegendDirection)
        Me.grpLegendAdjustments.Controls.Add(Me.ucrInputLegendBoxJust)
        Me.grpLegendAdjustments.Controls.Add(Me.ucrChkLegendJustification)
        Me.grpLegendAdjustments.Controls.Add(Me.ucrChkLegendBox)
        Me.grpLegendAdjustments.Controls.Add(Me.urChkLegendPosition)
        Me.grpLegendAdjustments.Controls.Add(Me.ucrChkLegendDirection)
        Me.grpLegendAdjustments.Controls.Add(Me.urChkLegendBoxJust)
        Me.grpLegendAdjustments.Location = New System.Drawing.Point(550, 6)
        Me.grpLegendAdjustments.Name = "grpLegendAdjustments"
        Me.grpLegendAdjustments.Size = New System.Drawing.Size(260, 164)
        Me.grpLegendAdjustments.TabIndex = 1
        Me.grpLegendAdjustments.TabStop = False
        Me.grpLegendAdjustments.Text = "Legend Adjustments"
        '
        'ucrInputLegendJustification
        '
        Me.ucrInputLegendJustification.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendJustification.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendJustification.GetSetSelectedIndex = -1
        Me.ucrInputLegendJustification.IsReadOnly = False
        Me.ucrInputLegendJustification.Location = New System.Drawing.Point(152, 126)
        Me.ucrInputLegendJustification.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLegendJustification.Name = "ucrInputLegendJustification"
        Me.ucrInputLegendJustification.Size = New System.Drawing.Size(105, 21)
        Me.ucrInputLegendJustification.TabIndex = 9
        '
        'ucrInputLegendBox
        '
        Me.ucrInputLegendBox.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendBox.GetSetSelectedIndex = -1
        Me.ucrInputLegendBox.IsReadOnly = False
        Me.ucrInputLegendBox.Location = New System.Drawing.Point(152, 98)
        Me.ucrInputLegendBox.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLegendBox.Name = "ucrInputLegendBox"
        Me.ucrInputLegendBox.Size = New System.Drawing.Size(105, 21)
        Me.ucrInputLegendBox.TabIndex = 7
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(152, 19)
        Me.ucrInputLegendPosition.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(105, 21)
        Me.ucrInputLegendPosition.TabIndex = 1
        '
        'ucrInputLegendDirection
        '
        Me.ucrInputLegendDirection.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendDirection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendDirection.GetSetSelectedIndex = -1
        Me.ucrInputLegendDirection.IsReadOnly = False
        Me.ucrInputLegendDirection.Location = New System.Drawing.Point(152, 45)
        Me.ucrInputLegendDirection.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLegendDirection.Name = "ucrInputLegendDirection"
        Me.ucrInputLegendDirection.Size = New System.Drawing.Size(105, 21)
        Me.ucrInputLegendDirection.TabIndex = 3
        '
        'ucrInputLegendBoxJust
        '
        Me.ucrInputLegendBoxJust.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendBoxJust.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendBoxJust.GetSetSelectedIndex = -1
        Me.ucrInputLegendBoxJust.IsReadOnly = False
        Me.ucrInputLegendBoxJust.Location = New System.Drawing.Point(177, 71)
        Me.ucrInputLegendBoxJust.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLegendBoxJust.Name = "ucrInputLegendBoxJust"
        Me.ucrInputLegendBoxJust.Size = New System.Drawing.Size(80, 21)
        Me.ucrInputLegendBoxJust.TabIndex = 5
        '
        'ucrChkLegendJustification
        '
        Me.ucrChkLegendJustification.AutoSize = True
        Me.ucrChkLegendJustification.Checked = False
        Me.ucrChkLegendJustification.Location = New System.Drawing.Point(6, 128)
        Me.ucrChkLegendJustification.Name = "ucrChkLegendJustification"
        Me.ucrChkLegendJustification.Size = New System.Drawing.Size(147, 23)
        Me.ucrChkLegendJustification.TabIndex = 8
        '
        'ucrChkLegendBox
        '
        Me.ucrChkLegendBox.AutoSize = True
        Me.ucrChkLegendBox.Checked = False
        Me.ucrChkLegendBox.Location = New System.Drawing.Point(6, 100)
        Me.ucrChkLegendBox.Name = "ucrChkLegendBox"
        Me.ucrChkLegendBox.Size = New System.Drawing.Size(147, 23)
        Me.ucrChkLegendBox.TabIndex = 6
        '
        'urChkLegendPosition
        '
        Me.urChkLegendPosition.AutoSize = True
        Me.urChkLegendPosition.Checked = False
        Me.urChkLegendPosition.Location = New System.Drawing.Point(6, 21)
        Me.urChkLegendPosition.Name = "urChkLegendPosition"
        Me.urChkLegendPosition.Size = New System.Drawing.Size(147, 23)
        Me.urChkLegendPosition.TabIndex = 0
        '
        'ucrChkLegendDirection
        '
        Me.ucrChkLegendDirection.AutoSize = True
        Me.ucrChkLegendDirection.Checked = False
        Me.ucrChkLegendDirection.Location = New System.Drawing.Point(6, 47)
        Me.ucrChkLegendDirection.Name = "ucrChkLegendDirection"
        Me.ucrChkLegendDirection.Size = New System.Drawing.Size(147, 23)
        Me.ucrChkLegendDirection.TabIndex = 2
        '
        'urChkLegendBoxJust
        '
        Me.urChkLegendBoxJust.AutoSize = True
        Me.urChkLegendBoxJust.Checked = False
        Me.urChkLegendBoxJust.Location = New System.Drawing.Point(6, 73)
        Me.urChkLegendBoxJust.Name = "urChkLegendBoxJust"
        Me.urChkLegendBoxJust.Size = New System.Drawing.Size(165, 23)
        Me.urChkLegendBoxJust.TabIndex = 4
        '
        'grpLegendBackGroundAndKey
        '
        Me.grpLegendBackGroundAndKey.Controls.Add(Me.ucrLegendBoxBackground)
        Me.grpLegendBackGroundAndKey.Controls.Add(Me.ucrLegendBackground)
        Me.grpLegendBackGroundAndKey.Controls.Add(Me.ucrLegendKey)
        Me.grpLegendBackGroundAndKey.Location = New System.Drawing.Point(6, 269)
        Me.grpLegendBackGroundAndKey.Name = "grpLegendBackGroundAndKey"
        Me.grpLegendBackGroundAndKey.Size = New System.Drawing.Size(801, 150)
        Me.grpLegendBackGroundAndKey.TabIndex = 2
        Me.grpLegendBackGroundAndKey.TabStop = False
        Me.grpLegendBackGroundAndKey.Text = "Legend Background and Key"
        '
        'ucrLegendBoxBackground
        '
        Me.ucrLegendBoxBackground.AutoSize = True
        Me.ucrLegendBoxBackground.Location = New System.Drawing.Point(275, 21)
        Me.ucrLegendBoxBackground.Name = "ucrLegendBoxBackground"
        Me.ucrLegendBoxBackground.Size = New System.Drawing.Size(253, 130)
        Me.ucrLegendBoxBackground.TabIndex = 1
        '
        'ucrLegendBackground
        '
        Me.ucrLegendBackground.AutoSize = True
        Me.ucrLegendBackground.Location = New System.Drawing.Point(14, 21)
        Me.ucrLegendBackground.Name = "ucrLegendBackground"
        Me.ucrLegendBackground.Size = New System.Drawing.Size(253, 130)
        Me.ucrLegendBackground.TabIndex = 0
        '
        'ucrLegendKey
        '
        Me.ucrLegendKey.AutoSize = True
        Me.ucrLegendKey.Location = New System.Drawing.Point(536, 21)
        Me.ucrLegendKey.Name = "ucrLegendKey"
        Me.ucrLegendKey.Size = New System.Drawing.Size(253, 130)
        Me.ucrLegendKey.TabIndex = 2
        '
        'tbThemeYaxis
        '
        Me.tbThemeYaxis.Controls.Add(Me.grpYAxisTitle)
        Me.tbThemeYaxis.Controls.Add(Me.grpTickMarkLabelsYAxis)
        Me.tbThemeYaxis.Controls.Add(Me.grpTickMarkers)
        Me.tbThemeYaxis.Location = New System.Drawing.Point(4, 22)
        Me.tbThemeYaxis.Name = "tbThemeYaxis"
        Me.tbThemeYaxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbThemeYaxis.Size = New System.Drawing.Size(817, 583)
        Me.tbThemeYaxis.TabIndex = 1
        Me.tbThemeYaxis.Text = "Y-Axis"
        Me.tbThemeYaxis.UseVisualStyleBackColor = True
        '
        'grpYAxisTitle
        '
        Me.grpYAxisTitle.Controls.Add(Me.ucrThemeTitleYRightAxis)
        Me.grpYAxisTitle.Controls.Add(Me.ucrThemeTitleYAxis)
        Me.grpYAxisTitle.Location = New System.Drawing.Point(6, 6)
        Me.grpYAxisTitle.Name = "grpYAxisTitle"
        Me.grpYAxisTitle.Size = New System.Drawing.Size(535, 269)
        Me.grpYAxisTitle.TabIndex = 0
        Me.grpYAxisTitle.TabStop = False
        Me.grpYAxisTitle.Text = "Y-Lab Title"
        '
        'ucrThemeTitleYRightAxis
        '
        Me.ucrThemeTitleYRightAxis.AutoSize = True
        Me.ucrThemeTitleYRightAxis.Location = New System.Drawing.Point(275, 21)
        Me.ucrThemeTitleYRightAxis.Name = "ucrThemeTitleYRightAxis"
        Me.ucrThemeTitleYRightAxis.Size = New System.Drawing.Size(262, 227)
        Me.ucrThemeTitleYRightAxis.TabIndex = 1
        '
        'ucrThemeTitleYAxis
        '
        Me.ucrThemeTitleYAxis.AutoSize = True
        Me.ucrThemeTitleYAxis.Location = New System.Drawing.Point(14, 21)
        Me.ucrThemeTitleYAxis.Name = "ucrThemeTitleYAxis"
        Me.ucrThemeTitleYAxis.Size = New System.Drawing.Size(259, 227)
        Me.ucrThemeTitleYAxis.TabIndex = 0
        '
        'grpTickMarkLabelsYAxis
        '
        Me.grpTickMarkLabelsYAxis.Controls.Add(Me.ucrThemeYRightAxis)
        Me.grpTickMarkLabelsYAxis.Controls.Add(Me.ucrThemeLeftYAxis)
        Me.grpTickMarkLabelsYAxis.Location = New System.Drawing.Point(6, 277)
        Me.grpTickMarkLabelsYAxis.Name = "grpTickMarkLabelsYAxis"
        Me.grpTickMarkLabelsYAxis.Size = New System.Drawing.Size(535, 258)
        Me.grpTickMarkLabelsYAxis.TabIndex = 2
        Me.grpTickMarkLabelsYAxis.TabStop = False
        Me.grpTickMarkLabelsYAxis.Text = "Tick Mark Labels "
        '
        'ucrThemeYRightAxis
        '
        Me.ucrThemeYRightAxis.AutoSize = True
        Me.ucrThemeYRightAxis.Location = New System.Drawing.Point(275, 21)
        Me.ucrThemeYRightAxis.Name = "ucrThemeYRightAxis"
        Me.ucrThemeYRightAxis.Size = New System.Drawing.Size(262, 226)
        Me.ucrThemeYRightAxis.TabIndex = 1
        '
        'ucrThemeLeftYAxis
        '
        Me.ucrThemeLeftYAxis.AutoSize = True
        Me.ucrThemeLeftYAxis.Location = New System.Drawing.Point(14, 21)
        Me.ucrThemeLeftYAxis.Name = "ucrThemeLeftYAxis"
        Me.ucrThemeLeftYAxis.Size = New System.Drawing.Size(259, 226)
        Me.ucrThemeLeftYAxis.TabIndex = 0
        '
        'grpTickMarkers
        '
        Me.grpTickMarkers.Controls.Add(Me.ucrTickMarksYAxis)
        Me.grpTickMarkers.Controls.Add(Me.ucrYAxisLines)
        Me.grpTickMarkers.Location = New System.Drawing.Point(550, 6)
        Me.grpTickMarkers.Name = "grpTickMarkers"
        Me.grpTickMarkers.Size = New System.Drawing.Size(260, 269)
        Me.grpTickMarkers.TabIndex = 1
        Me.grpTickMarkers.TabStop = False
        Me.grpTickMarkers.Text = "TickMarkers"
        '
        'ucrTickMarksYAxis
        '
        Me.ucrTickMarksYAxis.AutoSize = True
        Me.ucrTickMarksYAxis.Location = New System.Drawing.Point(4, 21)
        Me.ucrTickMarksYAxis.Name = "ucrTickMarksYAxis"
        Me.ucrTickMarksYAxis.Size = New System.Drawing.Size(255, 123)
        Me.ucrTickMarksYAxis.TabIndex = 0
        '
        'ucrYAxisLines
        '
        Me.ucrYAxisLines.AutoSize = True
        Me.ucrYAxisLines.Location = New System.Drawing.Point(4, 142)
        Me.ucrYAxisLines.Name = "ucrYAxisLines"
        Me.ucrYAxisLines.Size = New System.Drawing.Size(254, 124)
        Me.ucrYAxisLines.TabIndex = 1
        '
        'tbThemeXAxis
        '
        Me.tbThemeXAxis.Controls.Add(Me.grpTickMarkLabelsXAxis)
        Me.tbThemeXAxis.Controls.Add(Me.grpTickMarks)
        Me.tbThemeXAxis.Controls.Add(Me.grpXAxisTitle)
        Me.tbThemeXAxis.Location = New System.Drawing.Point(4, 22)
        Me.tbThemeXAxis.Name = "tbThemeXAxis"
        Me.tbThemeXAxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbThemeXAxis.Size = New System.Drawing.Size(817, 583)
        Me.tbThemeXAxis.TabIndex = 0
        Me.tbThemeXAxis.Text = "X-Axis"
        Me.tbThemeXAxis.UseVisualStyleBackColor = True
        '
        'grpTickMarkLabelsXAxis
        '
        Me.grpTickMarkLabelsXAxis.Controls.Add(Me.ucrThemeTopXAxis)
        Me.grpTickMarkLabelsXAxis.Controls.Add(Me.ucrThemeBottomXAxis)
        Me.grpTickMarkLabelsXAxis.Location = New System.Drawing.Point(6, 277)
        Me.grpTickMarkLabelsXAxis.Name = "grpTickMarkLabelsXAxis"
        Me.grpTickMarkLabelsXAxis.Size = New System.Drawing.Size(535, 258)
        Me.grpTickMarkLabelsXAxis.TabIndex = 2
        Me.grpTickMarkLabelsXAxis.TabStop = False
        Me.grpTickMarkLabelsXAxis.Text = "Tick Mark Labels "
        '
        'ucrThemeTopXAxis
        '
        Me.ucrThemeTopXAxis.AutoSize = True
        Me.ucrThemeTopXAxis.Location = New System.Drawing.Point(275, 21)
        Me.ucrThemeTopXAxis.Name = "ucrThemeTopXAxis"
        Me.ucrThemeTopXAxis.Size = New System.Drawing.Size(258, 226)
        Me.ucrThemeTopXAxis.TabIndex = 1
        '
        'ucrThemeBottomXAxis
        '
        Me.ucrThemeBottomXAxis.AutoSize = True
        Me.ucrThemeBottomXAxis.Location = New System.Drawing.Point(14, 21)
        Me.ucrThemeBottomXAxis.Name = "ucrThemeBottomXAxis"
        Me.ucrThemeBottomXAxis.Size = New System.Drawing.Size(259, 226)
        Me.ucrThemeBottomXAxis.TabIndex = 0
        '
        'grpTickMarks
        '
        Me.grpTickMarks.Controls.Add(Me.ucrXAxisLines)
        Me.grpTickMarks.Controls.Add(Me.ucrTickMarksXAxis)
        Me.grpTickMarks.Location = New System.Drawing.Point(550, 6)
        Me.grpTickMarks.Name = "grpTickMarks"
        Me.grpTickMarks.Size = New System.Drawing.Size(260, 269)
        Me.grpTickMarks.TabIndex = 1
        Me.grpTickMarks.TabStop = False
        Me.grpTickMarks.Text = "TickMarkers"
        '
        'ucrXAxisLines
        '
        Me.ucrXAxisLines.AutoSize = True
        Me.ucrXAxisLines.Location = New System.Drawing.Point(4, 142)
        Me.ucrXAxisLines.Name = "ucrXAxisLines"
        Me.ucrXAxisLines.Size = New System.Drawing.Size(254, 124)
        Me.ucrXAxisLines.TabIndex = 1
        '
        'ucrTickMarksXAxis
        '
        Me.ucrTickMarksXAxis.AutoSize = True
        Me.ucrTickMarksXAxis.Location = New System.Drawing.Point(4, 21)
        Me.ucrTickMarksXAxis.Name = "ucrTickMarksXAxis"
        Me.ucrTickMarksXAxis.Size = New System.Drawing.Size(254, 124)
        Me.ucrTickMarksXAxis.TabIndex = 0
        '
        'grpXAxisTitle
        '
        Me.grpXAxisTitle.Controls.Add(Me.ucrThemeTitleXTopAxis)
        Me.grpXAxisTitle.Controls.Add(Me.ucrThemeTitleXAxis)
        Me.grpXAxisTitle.Location = New System.Drawing.Point(6, 6)
        Me.grpXAxisTitle.Name = "grpXAxisTitle"
        Me.grpXAxisTitle.Size = New System.Drawing.Size(535, 269)
        Me.grpXAxisTitle.TabIndex = 0
        Me.grpXAxisTitle.TabStop = False
        Me.grpXAxisTitle.Text = "X-Lab Title"
        '
        'ucrThemeTitleXTopAxis
        '
        Me.ucrThemeTitleXTopAxis.AutoSize = True
        Me.ucrThemeTitleXTopAxis.Location = New System.Drawing.Point(275, 21)
        Me.ucrThemeTitleXTopAxis.Name = "ucrThemeTitleXTopAxis"
        Me.ucrThemeTitleXTopAxis.Size = New System.Drawing.Size(252, 230)
        Me.ucrThemeTitleXTopAxis.TabIndex = 1
        '
        'ucrThemeTitleXAxis
        '
        Me.ucrThemeTitleXAxis.AutoSize = True
        Me.ucrThemeTitleXAxis.Location = New System.Drawing.Point(14, 21)
        Me.ucrThemeTitleXAxis.Name = "ucrThemeTitleXAxis"
        Me.ucrThemeTitleXAxis.Size = New System.Drawing.Size(260, 231)
        Me.ucrThemeTitleXAxis.TabIndex = 0
        '
        'tbXYAxes
        '
        Me.tbXYAxes.Controls.Add(Me.grpTickLength)
        Me.tbXYAxes.Controls.Add(Me.ucrThemeAxesLines)
        Me.tbXYAxes.Controls.Add(Me.ucrThemeAxesTickLabels)
        Me.tbXYAxes.Controls.Add(Me.ucrTickMarksAxes)
        Me.tbXYAxes.Controls.Add(Me.ucrThemeAxesTitle)
        Me.tbXYAxes.Location = New System.Drawing.Point(4, 22)
        Me.tbXYAxes.Name = "tbXYAxes"
        Me.tbXYAxes.Size = New System.Drawing.Size(817, 583)
        Me.tbXYAxes.TabIndex = 6
        Me.tbXYAxes.Text = "XY-Axes"
        Me.tbXYAxes.UseVisualStyleBackColor = True
        '
        'grpTickLength
        '
        Me.grpTickLength.Controls.Add(Me.ucrTickLength)
        Me.grpTickLength.Location = New System.Drawing.Point(541, 27)
        Me.grpTickLength.Name = "grpTickLength"
        Me.grpTickLength.Size = New System.Drawing.Size(272, 151)
        Me.grpTickLength.TabIndex = 2
        Me.grpTickLength.TabStop = False
        Me.grpTickLength.Text = "grpTickLength"
        '
        'ucrTickLength
        '
        Me.ucrTickLength.AutoSize = True
        Me.ucrTickLength.Location = New System.Drawing.Point(6, 23)
        Me.ucrTickLength.Name = "ucrTickLength"
        Me.ucrTickLength.Size = New System.Drawing.Size(260, 122)
        Me.ucrTickLength.TabIndex = 0
        '
        'ucrThemeAxesLines
        '
        Me.ucrThemeAxesLines.AutoSize = True
        Me.ucrThemeAxesLines.Location = New System.Drawing.Point(283, 256)
        Me.ucrThemeAxesLines.Name = "ucrThemeAxesLines"
        Me.ucrThemeAxesLines.Size = New System.Drawing.Size(253, 122)
        Me.ucrThemeAxesLines.TabIndex = 4
        '
        'ucrThemeAxesTickLabels
        '
        Me.ucrThemeAxesTickLabels.AutoSize = True
        Me.ucrThemeAxesTickLabels.Location = New System.Drawing.Point(281, 27)
        Me.ucrThemeAxesTickLabels.Name = "ucrThemeAxesTickLabels"
        Me.ucrThemeAxesTickLabels.Size = New System.Drawing.Size(255, 228)
        Me.ucrThemeAxesTickLabels.TabIndex = 1
        '
        'ucrTickMarksAxes
        '
        Me.ucrTickMarksAxes.AutoSize = True
        Me.ucrTickMarksAxes.Location = New System.Drawing.Point(21, 256)
        Me.ucrTickMarksAxes.Name = "ucrTickMarksAxes"
        Me.ucrTickMarksAxes.Size = New System.Drawing.Size(257, 122)
        Me.ucrTickMarksAxes.TabIndex = 3
        '
        'ucrThemeAxesTitle
        '
        Me.ucrThemeAxesTitle.AutoSize = True
        Me.ucrThemeAxesTitle.Location = New System.Drawing.Point(20, 27)
        Me.ucrThemeAxesTitle.Name = "ucrThemeAxesTitle"
        Me.ucrThemeAxesTitle.Size = New System.Drawing.Size(255, 228)
        Me.ucrThemeAxesTitle.TabIndex = 0
        '
        'tbPLot
        '
        Me.tbPLot.Controls.Add(Me.grpPlotMargin)
        Me.tbPLot.Controls.Add(Me.grpPlotBackground)
        Me.tbPLot.Controls.Add(Me.grpPlotTitleAndCaption)
        Me.tbPLot.Location = New System.Drawing.Point(4, 22)
        Me.tbPLot.Name = "tbPLot"
        Me.tbPLot.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPLot.Size = New System.Drawing.Size(817, 583)
        Me.tbPLot.TabIndex = 7
        Me.tbPLot.Text = "Plot"
        Me.tbPLot.UseVisualStyleBackColor = True
        '
        'grpPlotMargin
        '
        Me.grpPlotMargin.Controls.Add(Me.ucrPlotMargin)
        Me.grpPlotMargin.Location = New System.Drawing.Point(285, 269)
        Me.grpPlotMargin.Name = "grpPlotMargin"
        Me.grpPlotMargin.Size = New System.Drawing.Size(271, 153)
        Me.grpPlotMargin.TabIndex = 2
        Me.grpPlotMargin.TabStop = False
        Me.grpPlotMargin.Text = "Margin"
        '
        'ucrPlotMargin
        '
        Me.ucrPlotMargin.AutoSize = True
        Me.ucrPlotMargin.Location = New System.Drawing.Point(5, 23)
        Me.ucrPlotMargin.Name = "ucrPlotMargin"
        Me.ucrPlotMargin.Size = New System.Drawing.Size(260, 123)
        Me.ucrPlotMargin.TabIndex = 0
        '
        'grpPlotBackground
        '
        Me.grpPlotBackground.Controls.Add(Me.ucrPlotBackground)
        Me.grpPlotBackground.Location = New System.Drawing.Point(6, 269)
        Me.grpPlotBackground.Name = "grpPlotBackground"
        Me.grpPlotBackground.Size = New System.Drawing.Size(269, 153)
        Me.grpPlotBackground.TabIndex = 1
        Me.grpPlotBackground.TabStop = False
        Me.grpPlotBackground.Text = "Background "
        '
        'ucrPlotBackground
        '
        Me.ucrPlotBackground.AutoSize = True
        Me.ucrPlotBackground.Location = New System.Drawing.Point(14, 21)
        Me.ucrPlotBackground.Name = "ucrPlotBackground"
        Me.ucrPlotBackground.Size = New System.Drawing.Size(253, 131)
        Me.ucrPlotBackground.TabIndex = 0
        '
        'grpPlotTitleAndCaption
        '
        Me.grpPlotTitleAndCaption.Controls.Add(Me.ucrPlotCaption)
        Me.grpPlotTitleAndCaption.Controls.Add(Me.ucrPlotSubTitle)
        Me.grpPlotTitleAndCaption.Controls.Add(Me.ucrPlotTitle)
        Me.grpPlotTitleAndCaption.Location = New System.Drawing.Point(6, 6)
        Me.grpPlotTitleAndCaption.Name = "grpPlotTitleAndCaption"
        Me.grpPlotTitleAndCaption.Size = New System.Drawing.Size(804, 255)
        Me.grpPlotTitleAndCaption.TabIndex = 0
        Me.grpPlotTitleAndCaption.TabStop = False
        Me.grpPlotTitleAndCaption.Text = "Plot Title and Caption"
        '
        'ucrPlotCaption
        '
        Me.ucrPlotCaption.AutoSize = True
        Me.ucrPlotCaption.Location = New System.Drawing.Point(536, 21)
        Me.ucrPlotCaption.Name = "ucrPlotCaption"
        Me.ucrPlotCaption.Size = New System.Drawing.Size(255, 226)
        Me.ucrPlotCaption.TabIndex = 2
        '
        'ucrPlotSubTitle
        '
        Me.ucrPlotSubTitle.AutoSize = True
        Me.ucrPlotSubTitle.Location = New System.Drawing.Point(275, 21)
        Me.ucrPlotSubTitle.Name = "ucrPlotSubTitle"
        Me.ucrPlotSubTitle.Size = New System.Drawing.Size(255, 226)
        Me.ucrPlotSubTitle.TabIndex = 1
        '
        'ucrPlotTitle
        '
        Me.ucrPlotTitle.AutoSize = True
        Me.ucrPlotTitle.Location = New System.Drawing.Point(14, 21)
        Me.ucrPlotTitle.Name = "ucrPlotTitle"
        Me.ucrPlotTitle.Size = New System.Drawing.Size(255, 226)
        Me.ucrPlotTitle.TabIndex = 0
        '
        'tbLegend
        '
        Me.tbLegend.Controls.Add(Me.tbPLot)
        Me.tbLegend.Controls.Add(Me.tbXYAxes)
        Me.tbLegend.Controls.Add(Me.tbThemeXAxis)
        Me.tbLegend.Controls.Add(Me.tbThemeYaxis)
        Me.tbLegend.Controls.Add(Me.tbThemeLegend)
        Me.tbLegend.Controls.Add(Me.tbThemeLegendMoreOptions)
        Me.tbLegend.Controls.Add(Me.tbThemePanelAndBackground)
        Me.tbLegend.Controls.Add(Me.tbThemePanelMoreOptions)
        Me.tbLegend.Controls.Add(Me.tbThemeFacets)
        Me.tbLegend.Location = New System.Drawing.Point(4, 8)
        Me.tbLegend.Name = "tbLegend"
        Me.tbLegend.SelectedIndex = 0
        Me.tbLegend.Size = New System.Drawing.Size(825, 609)
        Me.tbLegend.TabIndex = 0
        '
        'tbThemeLegendMoreOptions
        '
        Me.tbThemeLegendMoreOptions.Controls.Add(Me.grpLegendBoxSpacing)
        Me.tbThemeLegendMoreOptions.Controls.Add(Me.grpLegendSpacing)
        Me.tbThemeLegendMoreOptions.Location = New System.Drawing.Point(4, 22)
        Me.tbThemeLegendMoreOptions.Name = "tbThemeLegendMoreOptions"
        Me.tbThemeLegendMoreOptions.Size = New System.Drawing.Size(817, 583)
        Me.tbThemeLegendMoreOptions.TabIndex = 10
        Me.tbThemeLegendMoreOptions.Text = "Legend (More Options)"
        Me.tbThemeLegendMoreOptions.UseVisualStyleBackColor = True
        '
        'grpLegendBoxSpacing
        '
        Me.grpLegendBoxSpacing.Controls.Add(Me.ucrLegendBoxSpacing)
        Me.grpLegendBoxSpacing.Location = New System.Drawing.Point(6, 172)
        Me.grpLegendBoxSpacing.Name = "grpLegendBoxSpacing"
        Me.grpLegendBoxSpacing.Size = New System.Drawing.Size(272, 154)
        Me.grpLegendBoxSpacing.TabIndex = 1
        Me.grpLegendBoxSpacing.TabStop = False
        Me.grpLegendBoxSpacing.Text = "Legend Box Spacing"
        '
        'ucrLegendBoxSpacing
        '
        Me.ucrLegendBoxSpacing.AutoSize = True
        Me.ucrLegendBoxSpacing.Location = New System.Drawing.Point(4, 21)
        Me.ucrLegendBoxSpacing.Name = "ucrLegendBoxSpacing"
        Me.ucrLegendBoxSpacing.Size = New System.Drawing.Size(262, 127)
        Me.ucrLegendBoxSpacing.TabIndex = 0
        '
        'grpLegendSpacing
        '
        Me.grpLegendSpacing.Controls.Add(Me.ucrLegendSpacingYAxis)
        Me.grpLegendSpacing.Controls.Add(Me.ucrLegendSpacingXAxis)
        Me.grpLegendSpacing.Controls.Add(Me.ucrLegendSpacing)
        Me.grpLegendSpacing.Location = New System.Drawing.Point(6, 6)
        Me.grpLegendSpacing.Name = "grpLegendSpacing"
        Me.grpLegendSpacing.Size = New System.Drawing.Size(798, 150)
        Me.grpLegendSpacing.TabIndex = 0
        Me.grpLegendSpacing.TabStop = False
        Me.grpLegendSpacing.Text = "Legend Spacing"
        '
        'ucrLegendSpacingYAxis
        '
        Me.ucrLegendSpacingYAxis.AutoSize = True
        Me.ucrLegendSpacingYAxis.Location = New System.Drawing.Point(532, 21)
        Me.ucrLegendSpacingYAxis.Name = "ucrLegendSpacingYAxis"
        Me.ucrLegendSpacingYAxis.Size = New System.Drawing.Size(260, 122)
        Me.ucrLegendSpacingYAxis.TabIndex = 2
        '
        'ucrLegendSpacingXAxis
        '
        Me.ucrLegendSpacingXAxis.AutoSize = True
        Me.ucrLegendSpacingXAxis.Location = New System.Drawing.Point(268, 21)
        Me.ucrLegendSpacingXAxis.Name = "ucrLegendSpacingXAxis"
        Me.ucrLegendSpacingXAxis.Size = New System.Drawing.Size(261, 122)
        Me.ucrLegendSpacingXAxis.TabIndex = 1
        '
        'ucrLegendSpacing
        '
        Me.ucrLegendSpacing.AutoSize = True
        Me.ucrLegendSpacing.Location = New System.Drawing.Point(6, 21)
        Me.ucrLegendSpacing.Name = "ucrLegendSpacing"
        Me.ucrLegendSpacing.Size = New System.Drawing.Size(260, 122)
        Me.ucrLegendSpacing.TabIndex = 0
        '
        'tbThemePanelMoreOptions
        '
        Me.tbThemePanelMoreOptions.Controls.Add(Me.grpPanelGridMajorMinor)
        Me.tbThemePanelMoreOptions.Location = New System.Drawing.Point(4, 22)
        Me.tbThemePanelMoreOptions.Name = "tbThemePanelMoreOptions"
        Me.tbThemePanelMoreOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tbThemePanelMoreOptions.Size = New System.Drawing.Size(817, 583)
        Me.tbThemePanelMoreOptions.TabIndex = 9
        Me.tbThemePanelMoreOptions.Text = "Panel (More Options)"
        Me.tbThemePanelMoreOptions.UseVisualStyleBackColor = True
        '
        'grpPanelGridMajorMinor
        '
        Me.grpPanelGridMajorMinor.Controls.Add(Me.ucrPanelGridMinorYAxis)
        Me.grpPanelGridMajorMinor.Controls.Add(Me.ucrPanelGridMinorXAxis)
        Me.grpPanelGridMajorMinor.Controls.Add(Me.ucrPanelGridMajorYAxis)
        Me.grpPanelGridMajorMinor.Controls.Add(Me.ucrPanelGridMajorXAxis)
        Me.grpPanelGridMajorMinor.Location = New System.Drawing.Point(6, 6)
        Me.grpPanelGridMajorMinor.Name = "grpPanelGridMajorMinor"
        Me.grpPanelGridMajorMinor.Size = New System.Drawing.Size(539, 486)
        Me.grpPanelGridMajorMinor.TabIndex = 0
        Me.grpPanelGridMajorMinor.TabStop = False
        Me.grpPanelGridMajorMinor.Text = "Panel Grid"
        '
        'ucrPanelGridMinorYAxis
        '
        Me.ucrPanelGridMinorYAxis.AutoSize = True
        Me.ucrPanelGridMinorYAxis.Location = New System.Drawing.Point(275, 251)
        Me.ucrPanelGridMinorYAxis.Name = "ucrPanelGridMinorYAxis"
        Me.ucrPanelGridMinorYAxis.Size = New System.Drawing.Size(258, 226)
        Me.ucrPanelGridMinorYAxis.TabIndex = 3
        '
        'ucrPanelGridMinorXAxis
        '
        Me.ucrPanelGridMinorXAxis.AutoSize = True
        Me.ucrPanelGridMinorXAxis.Location = New System.Drawing.Point(14, 251)
        Me.ucrPanelGridMinorXAxis.Name = "ucrPanelGridMinorXAxis"
        Me.ucrPanelGridMinorXAxis.Size = New System.Drawing.Size(259, 226)
        Me.ucrPanelGridMinorXAxis.TabIndex = 2
        '
        'ucrPanelGridMajorYAxis
        '
        Me.ucrPanelGridMajorYAxis.AutoSize = True
        Me.ucrPanelGridMajorYAxis.Location = New System.Drawing.Point(275, 21)
        Me.ucrPanelGridMajorYAxis.Name = "ucrPanelGridMajorYAxis"
        Me.ucrPanelGridMajorYAxis.Size = New System.Drawing.Size(258, 226)
        Me.ucrPanelGridMajorYAxis.TabIndex = 1
        '
        'ucrPanelGridMajorXAxis
        '
        Me.ucrPanelGridMajorXAxis.AutoSize = True
        Me.ucrPanelGridMajorXAxis.Location = New System.Drawing.Point(14, 21)
        Me.ucrPanelGridMajorXAxis.Name = "ucrPanelGridMajorXAxis"
        Me.ucrPanelGridMajorXAxis.Size = New System.Drawing.Size(259, 226)
        Me.ucrPanelGridMajorXAxis.TabIndex = 0
        '
        'sdgThemes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(833, 653)
        Me.Controls.Add(Me.tbLegend)
        Me.Controls.Add(Me.ucrBaseSubdialogue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgThemes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Themes"
        Me.tbThemeFacets.ResumeLayout(False)
        Me.grpSpaceBetweenStripsAxes.ResumeLayout(False)
        Me.grpSpaceBetweenStripsAxes.PerformLayout()
        Me.grpFacetBackground.ResumeLayout(False)
        Me.grpFacetBackground.PerformLayout()
        Me.grpFacetLabels.ResumeLayout(False)
        Me.grpFacetLabels.PerformLayout()
        Me.tbThemePanelAndBackground.ResumeLayout(False)
        Me.grpPanelSpacing.ResumeLayout(False)
        Me.grpPanelSpacing.PerformLayout()
        Me.grpBorderAndBackground.ResumeLayout(False)
        Me.grpBorderAndBackground.PerformLayout()
        Me.grpPanelGrid.ResumeLayout(False)
        Me.grpPanelGrid.PerformLayout()
        Me.tbThemeLegend.ResumeLayout(False)
        Me.grpLegendKeyAdjustment.ResumeLayout(False)
        Me.grpLegendKeyAdjustment.PerformLayout()
        Me.grpLegendTitleAndText.ResumeLayout(False)
        Me.grpLegendTitleAndText.PerformLayout()
        Me.grpLegendAdjustments.ResumeLayout(False)
        Me.grpLegendAdjustments.PerformLayout()
        Me.grpLegendBackGroundAndKey.ResumeLayout(False)
        Me.grpLegendBackGroundAndKey.PerformLayout()
        Me.tbThemeYaxis.ResumeLayout(False)
        Me.grpYAxisTitle.ResumeLayout(False)
        Me.grpYAxisTitle.PerformLayout()
        Me.grpTickMarkLabelsYAxis.ResumeLayout(False)
        Me.grpTickMarkLabelsYAxis.PerformLayout()
        Me.grpTickMarkers.ResumeLayout(False)
        Me.grpTickMarkers.PerformLayout()
        Me.tbThemeXAxis.ResumeLayout(False)
        Me.grpTickMarkLabelsXAxis.ResumeLayout(False)
        Me.grpTickMarkLabelsXAxis.PerformLayout()
        Me.grpTickMarks.ResumeLayout(False)
        Me.grpTickMarks.PerformLayout()
        Me.grpXAxisTitle.ResumeLayout(False)
        Me.grpXAxisTitle.PerformLayout()
        Me.tbXYAxes.ResumeLayout(False)
        Me.tbXYAxes.PerformLayout()
        Me.grpTickLength.ResumeLayout(False)
        Me.grpTickLength.PerformLayout()
        Me.tbPLot.ResumeLayout(False)
        Me.grpPlotMargin.ResumeLayout(False)
        Me.grpPlotMargin.PerformLayout()
        Me.grpPlotBackground.ResumeLayout(False)
        Me.grpPlotBackground.PerformLayout()
        Me.grpPlotTitleAndCaption.ResumeLayout(False)
        Me.grpPlotTitleAndCaption.PerformLayout()
        Me.tbLegend.ResumeLayout(False)
        Me.tbThemeLegendMoreOptions.ResumeLayout(False)
        Me.grpLegendBoxSpacing.ResumeLayout(False)
        Me.grpLegendBoxSpacing.PerformLayout()
        Me.grpLegendSpacing.ResumeLayout(False)
        Me.grpLegendSpacing.PerformLayout()
        Me.tbThemePanelMoreOptions.ResumeLayout(False)
        Me.grpPanelGridMajorMinor.ResumeLayout(False)
        Me.grpPanelGridMajorMinor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSubdialogue As ucrButtonsSubdialogue
    Friend WithEvents tbThemeFacets As TabPage
    Friend WithEvents grpFacetBackground As GroupBox
    Friend WithEvents ucrStripBackGround As ucrElementRectControl
    Friend WithEvents grpFacetLabels As GroupBox
    Friend WithEvents ucrStripTextYAxis As ucrELementTextControl
    Friend WithEvents ucrStripTextXAxis As ucrELementTextControl
    Friend WithEvents ucrStripText As ucrELementTextControl
    Friend WithEvents tbThemePanelAndBackground As TabPage
    Friend WithEvents grpBorderAndBackground As GroupBox
    Friend WithEvents ucrPanelBackGround As ucrElementRectControl
    Friend WithEvents ucrPanelBorder As ucrElementRectControl
    Friend WithEvents grpPanelGrid As GroupBox
    Friend WithEvents ucrPanelGridMinor As ucrElementLineControl
    Friend WithEvents ucrPanelGridMajor As ucrElementLineControl
    Friend WithEvents ucrPanelGrid As ucrElementLineControl
    Friend WithEvents tbThemeLegend As TabPage
    Friend WithEvents grpLegendTitleAndText As GroupBox
    Friend WithEvents ucrLegendText As ucrELementTextControl
    Friend WithEvents ucrLegendTitle As ucrELementTextControl
    Friend WithEvents grpLegendAdjustments As GroupBox
    Friend WithEvents ucrChkLegendJustification As ucrCheck
    Friend WithEvents ucrInputLegendJustification As ucrInputComboBox
    Friend WithEvents ucrChkLegendBox As ucrCheck
    Friend WithEvents ucrInputLegendBox As ucrInputComboBox
    Friend WithEvents urChkLegendPosition As ucrCheck
    Friend WithEvents ucrChkLegendDirection As ucrCheck
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents ucrInputLegendDirection As ucrInputComboBox
    Friend WithEvents urChkLegendBoxJust As ucrCheck
    Friend WithEvents ucrInputLegendBoxJust As ucrInputComboBox
    Friend WithEvents grpLegendBackGroundAndKey As GroupBox
    Friend WithEvents ucrLegendBoxBackground As ucrElementRectControl
    Friend WithEvents ucrLegendBackground As ucrElementRectControl
    Friend WithEvents ucrLegendKey As ucrElementRectControl
    Friend WithEvents tbThemeYaxis As TabPage
    Friend WithEvents grpYAxisTitle As GroupBox
    Friend WithEvents ucrThemeTitleYRightAxis As ucrELementTextControl
    Friend WithEvents ucrThemeTitleYAxis As ucrELementTextControl
    Friend WithEvents grpTickMarkLabelsYAxis As GroupBox
    Friend WithEvents ucrThemeYRightAxis As ucrELementTextControl
    Friend WithEvents ucrThemeLeftYAxis As ucrELementTextControl
    Friend WithEvents grpTickMarkers As GroupBox
    Friend WithEvents tbThemeXAxis As TabPage
    Friend WithEvents grpTickMarkLabelsXAxis As GroupBox
    Friend WithEvents ucrThemeTopXAxis As ucrELementTextControl
    Friend WithEvents ucrThemeBottomXAxis As ucrELementTextControl
    Friend WithEvents grpXAxisTitle As GroupBox
    Friend WithEvents ucrThemeTitleXTopAxis As ucrELementTextControl
    Friend WithEvents ucrThemeTitleXAxis As ucrELementTextControl
    Friend WithEvents grpTickMarks As GroupBox
    Friend WithEvents ucrXAxisLines As ucrElementLineControl
    Friend WithEvents ucrTickMarksXAxis As ucrElementLineControl
    Friend WithEvents tbXYAxes As TabPage
    Friend WithEvents ucrThemeAxesLines As ucrElementLineControl
    Friend WithEvents ucrThemeAxesTickLabels As ucrELementTextControl
    Friend WithEvents ucrTickMarksAxes As ucrElementLineControl
    Friend WithEvents ucrThemeAxesTitle As ucrELementTextControl
    Friend WithEvents tbPLot As TabPage
    Friend WithEvents grpPlotBackground As GroupBox
    Friend WithEvents grpPlotTitleAndCaption As GroupBox
    Friend WithEvents ucrPlotCaption As ucrELementTextControl
    Friend WithEvents ucrPlotSubTitle As ucrELementTextControl
    Friend WithEvents ucrPlotTitle As ucrELementTextControl
    Friend WithEvents tbLegend As TabControl
    Friend WithEvents grpLegendKeyAdjustment As GroupBox
    Friend WithEvents ucrLegendKeyWidth As ucrGridUnit
    Friend WithEvents ucrLegendKeyHeight As ucrGridUnit
    Friend WithEvents ucrLegendKeySize As ucrGridUnit
    Friend WithEvents grpPanelSpacing As GroupBox
    Friend WithEvents ucrPanelSpacingYAxis As ucrGridUnit
    Friend WithEvents ucrPanelSpacingXAxis As ucrGridUnit
    Friend WithEvents ucrPanelSpacing As ucrGridUnit
    Friend WithEvents grpTickLength As GroupBox
    Friend WithEvents ucrTickLength As ucrGridUnit
    Friend WithEvents grpPlotMargin As GroupBox
    Friend WithEvents ucrPlotMargin As ucrGridUnit
    Friend WithEvents grpSpaceBetweenStripsAxes As GroupBox
    Friend WithEvents ucrStripsSpaceWrap As ucrGridUnit
    Friend WithEvents ucrStripsSpaceGrid As ucrGridUnit
    Friend WithEvents tbThemeLegendMoreOptions As TabPage
    Friend WithEvents tbThemePanelMoreOptions As TabPage
    Friend WithEvents grpPanelGridMajorMinor As GroupBox
    Friend WithEvents ucrPanelGridMajorYAxis As ucrELementTextControl
    Friend WithEvents ucrPanelGridMajorXAxis As ucrELementTextControl
    Friend WithEvents ucrPanelGridMinorYAxis As ucrELementTextControl
    Friend WithEvents ucrPanelGridMinorXAxis As ucrELementTextControl
    Friend WithEvents grpLegendSpacing As GroupBox
    Friend WithEvents ucrLegendSpacingYAxis As ucrGridUnit
    Friend WithEvents ucrLegendSpacingXAxis As ucrGridUnit
    Friend WithEvents ucrLegendSpacing As ucrGridUnit
    Friend WithEvents grpLegendBoxSpacing As GroupBox
    Friend WithEvents ucrLegendBoxSpacing As ucrGridUnit
    Friend WithEvents ucrYAxisLines As ucrElementLineControl
    Friend WithEvents ucrPlotBackground As ucrElementRectControl
    Friend WithEvents ucrTickMarksYAxis As ucrElementLineControl
End Class
