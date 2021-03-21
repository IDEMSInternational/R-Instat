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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgThemes))
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
        resources.ApplyResources(Me.ucrBaseSubdialogue, "ucrBaseSubdialogue")
        Me.ucrBaseSubdialogue.Name = "ucrBaseSubdialogue"
        '
        'tbThemeFacets
        '
        Me.tbThemeFacets.Controls.Add(Me.grpSpaceBetweenStripsAxes)
        Me.tbThemeFacets.Controls.Add(Me.grpFacetBackground)
        Me.tbThemeFacets.Controls.Add(Me.grpFacetLabels)
        resources.ApplyResources(Me.tbThemeFacets, "tbThemeFacets")
        Me.tbThemeFacets.Name = "tbThemeFacets"
        Me.tbThemeFacets.UseVisualStyleBackColor = True
        '
        'grpSpaceBetweenStripsAxes
        '
        Me.grpSpaceBetweenStripsAxes.Controls.Add(Me.ucrStripsSpaceWrap)
        Me.grpSpaceBetweenStripsAxes.Controls.Add(Me.ucrStripsSpaceGrid)
        resources.ApplyResources(Me.grpSpaceBetweenStripsAxes, "grpSpaceBetweenStripsAxes")
        Me.grpSpaceBetweenStripsAxes.Name = "grpSpaceBetweenStripsAxes"
        Me.grpSpaceBetweenStripsAxes.TabStop = False
        '
        'ucrStripsSpaceWrap
        '
        resources.ApplyResources(Me.ucrStripsSpaceWrap, "ucrStripsSpaceWrap")
        Me.ucrStripsSpaceWrap.Name = "ucrStripsSpaceWrap"
        '
        'ucrStripsSpaceGrid
        '
        resources.ApplyResources(Me.ucrStripsSpaceGrid, "ucrStripsSpaceGrid")
        Me.ucrStripsSpaceGrid.Name = "ucrStripsSpaceGrid"
        '
        'grpFacetBackground
        '
        Me.grpFacetBackground.Controls.Add(Me.ucrStripBackGround)
        resources.ApplyResources(Me.grpFacetBackground, "grpFacetBackground")
        Me.grpFacetBackground.Name = "grpFacetBackground"
        Me.grpFacetBackground.TabStop = False
        '
        'ucrStripBackGround
        '
        resources.ApplyResources(Me.ucrStripBackGround, "ucrStripBackGround")
        Me.ucrStripBackGround.Name = "ucrStripBackGround"
        '
        'grpFacetLabels
        '
        Me.grpFacetLabels.Controls.Add(Me.ucrStripTextYAxis)
        Me.grpFacetLabels.Controls.Add(Me.ucrStripTextXAxis)
        Me.grpFacetLabels.Controls.Add(Me.ucrStripText)
        resources.ApplyResources(Me.grpFacetLabels, "grpFacetLabels")
        Me.grpFacetLabels.Name = "grpFacetLabels"
        Me.grpFacetLabels.TabStop = False
        '
        'ucrStripTextYAxis
        '
        resources.ApplyResources(Me.ucrStripTextYAxis, "ucrStripTextYAxis")
        Me.ucrStripTextYAxis.Name = "ucrStripTextYAxis"
        '
        'ucrStripTextXAxis
        '
        resources.ApplyResources(Me.ucrStripTextXAxis, "ucrStripTextXAxis")
        Me.ucrStripTextXAxis.Name = "ucrStripTextXAxis"
        '
        'ucrStripText
        '
        resources.ApplyResources(Me.ucrStripText, "ucrStripText")
        Me.ucrStripText.Name = "ucrStripText"
        '
        'tbThemePanelAndBackground
        '
        Me.tbThemePanelAndBackground.Controls.Add(Me.grpPanelSpacing)
        Me.tbThemePanelAndBackground.Controls.Add(Me.grpBorderAndBackground)
        Me.tbThemePanelAndBackground.Controls.Add(Me.grpPanelGrid)
        resources.ApplyResources(Me.tbThemePanelAndBackground, "tbThemePanelAndBackground")
        Me.tbThemePanelAndBackground.Name = "tbThemePanelAndBackground"
        Me.tbThemePanelAndBackground.UseVisualStyleBackColor = True
        '
        'grpPanelSpacing
        '
        Me.grpPanelSpacing.Controls.Add(Me.ucrPanelSpacingYAxis)
        Me.grpPanelSpacing.Controls.Add(Me.ucrPanelSpacingXAxis)
        Me.grpPanelSpacing.Controls.Add(Me.ucrPanelSpacing)
        resources.ApplyResources(Me.grpPanelSpacing, "grpPanelSpacing")
        Me.grpPanelSpacing.Name = "grpPanelSpacing"
        Me.grpPanelSpacing.TabStop = False
        '
        'ucrPanelSpacingYAxis
        '
        resources.ApplyResources(Me.ucrPanelSpacingYAxis, "ucrPanelSpacingYAxis")
        Me.ucrPanelSpacingYAxis.Name = "ucrPanelSpacingYAxis"
        '
        'ucrPanelSpacingXAxis
        '
        resources.ApplyResources(Me.ucrPanelSpacingXAxis, "ucrPanelSpacingXAxis")
        Me.ucrPanelSpacingXAxis.Name = "ucrPanelSpacingXAxis"
        '
        'ucrPanelSpacing
        '
        resources.ApplyResources(Me.ucrPanelSpacing, "ucrPanelSpacing")
        Me.ucrPanelSpacing.Name = "ucrPanelSpacing"
        '
        'grpBorderAndBackground
        '
        Me.grpBorderAndBackground.Controls.Add(Me.ucrPanelBackGround)
        Me.grpBorderAndBackground.Controls.Add(Me.ucrPanelBorder)
        resources.ApplyResources(Me.grpBorderAndBackground, "grpBorderAndBackground")
        Me.grpBorderAndBackground.Name = "grpBorderAndBackground"
        Me.grpBorderAndBackground.TabStop = False
        '
        'ucrPanelBackGround
        '
        resources.ApplyResources(Me.ucrPanelBackGround, "ucrPanelBackGround")
        Me.ucrPanelBackGround.Name = "ucrPanelBackGround"
        '
        'ucrPanelBorder
        '
        resources.ApplyResources(Me.ucrPanelBorder, "ucrPanelBorder")
        Me.ucrPanelBorder.Name = "ucrPanelBorder"
        '
        'grpPanelGrid
        '
        Me.grpPanelGrid.Controls.Add(Me.ucrPanelGridMinor)
        Me.grpPanelGrid.Controls.Add(Me.ucrPanelGridMajor)
        Me.grpPanelGrid.Controls.Add(Me.ucrPanelGrid)
        resources.ApplyResources(Me.grpPanelGrid, "grpPanelGrid")
        Me.grpPanelGrid.Name = "grpPanelGrid"
        Me.grpPanelGrid.TabStop = False
        '
        'ucrPanelGridMinor
        '
        resources.ApplyResources(Me.ucrPanelGridMinor, "ucrPanelGridMinor")
        Me.ucrPanelGridMinor.Name = "ucrPanelGridMinor"
        '
        'ucrPanelGridMajor
        '
        resources.ApplyResources(Me.ucrPanelGridMajor, "ucrPanelGridMajor")
        Me.ucrPanelGridMajor.Name = "ucrPanelGridMajor"
        '
        'ucrPanelGrid
        '
        resources.ApplyResources(Me.ucrPanelGrid, "ucrPanelGrid")
        Me.ucrPanelGrid.Name = "ucrPanelGrid"
        '
        'tbThemeLegend
        '
        Me.tbThemeLegend.Controls.Add(Me.grpLegendKeyAdjustment)
        Me.tbThemeLegend.Controls.Add(Me.grpLegendTitleAndText)
        Me.tbThemeLegend.Controls.Add(Me.grpLegendAdjustments)
        Me.tbThemeLegend.Controls.Add(Me.grpLegendBackGroundAndKey)
        resources.ApplyResources(Me.tbThemeLegend, "tbThemeLegend")
        Me.tbThemeLegend.Name = "tbThemeLegend"
        Me.tbThemeLegend.UseVisualStyleBackColor = True
        '
        'grpLegendKeyAdjustment
        '
        Me.grpLegendKeyAdjustment.Controls.Add(Me.ucrLegendKeyWidth)
        Me.grpLegendKeyAdjustment.Controls.Add(Me.ucrLegendKeyHeight)
        Me.grpLegendKeyAdjustment.Controls.Add(Me.ucrLegendKeySize)
        resources.ApplyResources(Me.grpLegendKeyAdjustment, "grpLegendKeyAdjustment")
        Me.grpLegendKeyAdjustment.Name = "grpLegendKeyAdjustment"
        Me.grpLegendKeyAdjustment.TabStop = False
        '
        'ucrLegendKeyWidth
        '
        resources.ApplyResources(Me.ucrLegendKeyWidth, "ucrLegendKeyWidth")
        Me.ucrLegendKeyWidth.Name = "ucrLegendKeyWidth"
        '
        'ucrLegendKeyHeight
        '
        resources.ApplyResources(Me.ucrLegendKeyHeight, "ucrLegendKeyHeight")
        Me.ucrLegendKeyHeight.Name = "ucrLegendKeyHeight"
        '
        'ucrLegendKeySize
        '
        resources.ApplyResources(Me.ucrLegendKeySize, "ucrLegendKeySize")
        Me.ucrLegendKeySize.Name = "ucrLegendKeySize"
        '
        'grpLegendTitleAndText
        '
        Me.grpLegendTitleAndText.Controls.Add(Me.ucrLegendText)
        Me.grpLegendTitleAndText.Controls.Add(Me.ucrLegendTitle)
        resources.ApplyResources(Me.grpLegendTitleAndText, "grpLegendTitleAndText")
        Me.grpLegendTitleAndText.Name = "grpLegendTitleAndText"
        Me.grpLegendTitleAndText.TabStop = False
        '
        'ucrLegendText
        '
        resources.ApplyResources(Me.ucrLegendText, "ucrLegendText")
        Me.ucrLegendText.Name = "ucrLegendText"
        '
        'ucrLegendTitle
        '
        resources.ApplyResources(Me.ucrLegendTitle, "ucrLegendTitle")
        Me.ucrLegendTitle.Name = "ucrLegendTitle"
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
        resources.ApplyResources(Me.grpLegendAdjustments, "grpLegendAdjustments")
        Me.grpLegendAdjustments.Name = "grpLegendAdjustments"
        Me.grpLegendAdjustments.TabStop = False
        '
        'ucrInputLegendJustification
        '
        Me.ucrInputLegendJustification.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendJustification.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLegendJustification, "ucrInputLegendJustification")
        Me.ucrInputLegendJustification.Name = "ucrInputLegendJustification"
        '
        'ucrInputLegendBox
        '
        Me.ucrInputLegendBox.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendBox.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLegendBox, "ucrInputLegendBox")
        Me.ucrInputLegendBox.Name = "ucrInputLegendBox"
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLegendPosition, "ucrInputLegendPosition")
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        '
        'ucrInputLegendDirection
        '
        Me.ucrInputLegendDirection.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendDirection.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLegendDirection, "ucrInputLegendDirection")
        Me.ucrInputLegendDirection.Name = "ucrInputLegendDirection"
        '
        'ucrInputLegendBoxJust
        '
        Me.ucrInputLegendBoxJust.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendBoxJust.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLegendBoxJust, "ucrInputLegendBoxJust")
        Me.ucrInputLegendBoxJust.Name = "ucrInputLegendBoxJust"
        '
        'ucrChkLegendJustification
        '
        Me.ucrChkLegendJustification.Checked = False
        resources.ApplyResources(Me.ucrChkLegendJustification, "ucrChkLegendJustification")
        Me.ucrChkLegendJustification.Name = "ucrChkLegendJustification"
        '
        'ucrChkLegendBox
        '
        Me.ucrChkLegendBox.Checked = False
        resources.ApplyResources(Me.ucrChkLegendBox, "ucrChkLegendBox")
        Me.ucrChkLegendBox.Name = "ucrChkLegendBox"
        '
        'urChkLegendPosition
        '
        Me.urChkLegendPosition.Checked = False
        resources.ApplyResources(Me.urChkLegendPosition, "urChkLegendPosition")
        Me.urChkLegendPosition.Name = "urChkLegendPosition"
        '
        'ucrChkLegendDirection
        '
        Me.ucrChkLegendDirection.Checked = False
        resources.ApplyResources(Me.ucrChkLegendDirection, "ucrChkLegendDirection")
        Me.ucrChkLegendDirection.Name = "ucrChkLegendDirection"
        '
        'urChkLegendBoxJust
        '
        Me.urChkLegendBoxJust.Checked = False
        resources.ApplyResources(Me.urChkLegendBoxJust, "urChkLegendBoxJust")
        Me.urChkLegendBoxJust.Name = "urChkLegendBoxJust"
        '
        'grpLegendBackGroundAndKey
        '
        Me.grpLegendBackGroundAndKey.Controls.Add(Me.ucrLegendBoxBackground)
        Me.grpLegendBackGroundAndKey.Controls.Add(Me.ucrLegendBackground)
        Me.grpLegendBackGroundAndKey.Controls.Add(Me.ucrLegendKey)
        resources.ApplyResources(Me.grpLegendBackGroundAndKey, "grpLegendBackGroundAndKey")
        Me.grpLegendBackGroundAndKey.Name = "grpLegendBackGroundAndKey"
        Me.grpLegendBackGroundAndKey.TabStop = False
        '
        'ucrLegendBoxBackground
        '
        resources.ApplyResources(Me.ucrLegendBoxBackground, "ucrLegendBoxBackground")
        Me.ucrLegendBoxBackground.Name = "ucrLegendBoxBackground"
        '
        'ucrLegendBackground
        '
        resources.ApplyResources(Me.ucrLegendBackground, "ucrLegendBackground")
        Me.ucrLegendBackground.Name = "ucrLegendBackground"
        '
        'ucrLegendKey
        '
        resources.ApplyResources(Me.ucrLegendKey, "ucrLegendKey")
        Me.ucrLegendKey.Name = "ucrLegendKey"
        '
        'tbThemeYaxis
        '
        Me.tbThemeYaxis.Controls.Add(Me.grpYAxisTitle)
        Me.tbThemeYaxis.Controls.Add(Me.grpTickMarkLabelsYAxis)
        Me.tbThemeYaxis.Controls.Add(Me.grpTickMarkers)
        resources.ApplyResources(Me.tbThemeYaxis, "tbThemeYaxis")
        Me.tbThemeYaxis.Name = "tbThemeYaxis"
        Me.tbThemeYaxis.UseVisualStyleBackColor = True
        '
        'grpYAxisTitle
        '
        Me.grpYAxisTitle.Controls.Add(Me.ucrThemeTitleYRightAxis)
        Me.grpYAxisTitle.Controls.Add(Me.ucrThemeTitleYAxis)
        resources.ApplyResources(Me.grpYAxisTitle, "grpYAxisTitle")
        Me.grpYAxisTitle.Name = "grpYAxisTitle"
        Me.grpYAxisTitle.TabStop = False
        '
        'ucrThemeTitleYRightAxis
        '
        resources.ApplyResources(Me.ucrThemeTitleYRightAxis, "ucrThemeTitleYRightAxis")
        Me.ucrThemeTitleYRightAxis.Name = "ucrThemeTitleYRightAxis"
        '
        'ucrThemeTitleYAxis
        '
        resources.ApplyResources(Me.ucrThemeTitleYAxis, "ucrThemeTitleYAxis")
        Me.ucrThemeTitleYAxis.Name = "ucrThemeTitleYAxis"
        '
        'grpTickMarkLabelsYAxis
        '
        Me.grpTickMarkLabelsYAxis.Controls.Add(Me.ucrThemeYRightAxis)
        Me.grpTickMarkLabelsYAxis.Controls.Add(Me.ucrThemeLeftYAxis)
        resources.ApplyResources(Me.grpTickMarkLabelsYAxis, "grpTickMarkLabelsYAxis")
        Me.grpTickMarkLabelsYAxis.Name = "grpTickMarkLabelsYAxis"
        Me.grpTickMarkLabelsYAxis.TabStop = False
        '
        'ucrThemeYRightAxis
        '
        resources.ApplyResources(Me.ucrThemeYRightAxis, "ucrThemeYRightAxis")
        Me.ucrThemeYRightAxis.Name = "ucrThemeYRightAxis"
        '
        'ucrThemeLeftYAxis
        '
        resources.ApplyResources(Me.ucrThemeLeftYAxis, "ucrThemeLeftYAxis")
        Me.ucrThemeLeftYAxis.Name = "ucrThemeLeftYAxis"
        '
        'grpTickMarkers
        '
        Me.grpTickMarkers.Controls.Add(Me.ucrTickMarksYAxis)
        Me.grpTickMarkers.Controls.Add(Me.ucrYAxisLines)
        resources.ApplyResources(Me.grpTickMarkers, "grpTickMarkers")
        Me.grpTickMarkers.Name = "grpTickMarkers"
        Me.grpTickMarkers.TabStop = False
        '
        'ucrTickMarksYAxis
        '
        resources.ApplyResources(Me.ucrTickMarksYAxis, "ucrTickMarksYAxis")
        Me.ucrTickMarksYAxis.Name = "ucrTickMarksYAxis"
        '
        'ucrYAxisLines
        '
        resources.ApplyResources(Me.ucrYAxisLines, "ucrYAxisLines")
        Me.ucrYAxisLines.Name = "ucrYAxisLines"
        '
        'tbThemeXAxis
        '
        Me.tbThemeXAxis.Controls.Add(Me.grpTickMarkLabelsXAxis)
        Me.tbThemeXAxis.Controls.Add(Me.grpTickMarks)
        Me.tbThemeXAxis.Controls.Add(Me.grpXAxisTitle)
        resources.ApplyResources(Me.tbThemeXAxis, "tbThemeXAxis")
        Me.tbThemeXAxis.Name = "tbThemeXAxis"
        Me.tbThemeXAxis.UseVisualStyleBackColor = True
        '
        'grpTickMarkLabelsXAxis
        '
        Me.grpTickMarkLabelsXAxis.Controls.Add(Me.ucrThemeTopXAxis)
        Me.grpTickMarkLabelsXAxis.Controls.Add(Me.ucrThemeBottomXAxis)
        resources.ApplyResources(Me.grpTickMarkLabelsXAxis, "grpTickMarkLabelsXAxis")
        Me.grpTickMarkLabelsXAxis.Name = "grpTickMarkLabelsXAxis"
        Me.grpTickMarkLabelsXAxis.TabStop = False
        '
        'ucrThemeTopXAxis
        '
        resources.ApplyResources(Me.ucrThemeTopXAxis, "ucrThemeTopXAxis")
        Me.ucrThemeTopXAxis.Name = "ucrThemeTopXAxis"
        '
        'ucrThemeBottomXAxis
        '
        resources.ApplyResources(Me.ucrThemeBottomXAxis, "ucrThemeBottomXAxis")
        Me.ucrThemeBottomXAxis.Name = "ucrThemeBottomXAxis"
        '
        'grpTickMarks
        '
        Me.grpTickMarks.Controls.Add(Me.ucrXAxisLines)
        Me.grpTickMarks.Controls.Add(Me.ucrTickMarksXAxis)
        resources.ApplyResources(Me.grpTickMarks, "grpTickMarks")
        Me.grpTickMarks.Name = "grpTickMarks"
        Me.grpTickMarks.TabStop = False
        '
        'ucrXAxisLines
        '
        resources.ApplyResources(Me.ucrXAxisLines, "ucrXAxisLines")
        Me.ucrXAxisLines.Name = "ucrXAxisLines"
        '
        'ucrTickMarksXAxis
        '
        resources.ApplyResources(Me.ucrTickMarksXAxis, "ucrTickMarksXAxis")
        Me.ucrTickMarksXAxis.Name = "ucrTickMarksXAxis"
        '
        'grpXAxisTitle
        '
        Me.grpXAxisTitle.Controls.Add(Me.ucrThemeTitleXTopAxis)
        Me.grpXAxisTitle.Controls.Add(Me.ucrThemeTitleXAxis)
        resources.ApplyResources(Me.grpXAxisTitle, "grpXAxisTitle")
        Me.grpXAxisTitle.Name = "grpXAxisTitle"
        Me.grpXAxisTitle.TabStop = False
        '
        'ucrThemeTitleXTopAxis
        '
        resources.ApplyResources(Me.ucrThemeTitleXTopAxis, "ucrThemeTitleXTopAxis")
        Me.ucrThemeTitleXTopAxis.Name = "ucrThemeTitleXTopAxis"
        '
        'ucrThemeTitleXAxis
        '
        resources.ApplyResources(Me.ucrThemeTitleXAxis, "ucrThemeTitleXAxis")
        Me.ucrThemeTitleXAxis.Name = "ucrThemeTitleXAxis"
        '
        'tbXYAxes
        '
        Me.tbXYAxes.Controls.Add(Me.grpTickLength)
        Me.tbXYAxes.Controls.Add(Me.ucrThemeAxesLines)
        Me.tbXYAxes.Controls.Add(Me.ucrThemeAxesTickLabels)
        Me.tbXYAxes.Controls.Add(Me.ucrTickMarksAxes)
        Me.tbXYAxes.Controls.Add(Me.ucrThemeAxesTitle)
        resources.ApplyResources(Me.tbXYAxes, "tbXYAxes")
        Me.tbXYAxes.Name = "tbXYAxes"
        Me.tbXYAxes.UseVisualStyleBackColor = True
        '
        'grpTickLength
        '
        Me.grpTickLength.Controls.Add(Me.ucrTickLength)
        resources.ApplyResources(Me.grpTickLength, "grpTickLength")
        Me.grpTickLength.Name = "grpTickLength"
        Me.grpTickLength.TabStop = False
        '
        'ucrTickLength
        '
        resources.ApplyResources(Me.ucrTickLength, "ucrTickLength")
        Me.ucrTickLength.Name = "ucrTickLength"
        '
        'ucrThemeAxesLines
        '
        resources.ApplyResources(Me.ucrThemeAxesLines, "ucrThemeAxesLines")
        Me.ucrThemeAxesLines.Name = "ucrThemeAxesLines"
        '
        'ucrThemeAxesTickLabels
        '
        resources.ApplyResources(Me.ucrThemeAxesTickLabels, "ucrThemeAxesTickLabels")
        Me.ucrThemeAxesTickLabels.Name = "ucrThemeAxesTickLabels"
        '
        'ucrTickMarksAxes
        '
        resources.ApplyResources(Me.ucrTickMarksAxes, "ucrTickMarksAxes")
        Me.ucrTickMarksAxes.Name = "ucrTickMarksAxes"
        '
        'ucrThemeAxesTitle
        '
        resources.ApplyResources(Me.ucrThemeAxesTitle, "ucrThemeAxesTitle")
        Me.ucrThemeAxesTitle.Name = "ucrThemeAxesTitle"
        '
        'tbPLot
        '
        Me.tbPLot.Controls.Add(Me.grpPlotMargin)
        Me.tbPLot.Controls.Add(Me.grpPlotBackground)
        Me.tbPLot.Controls.Add(Me.grpPlotTitleAndCaption)
        resources.ApplyResources(Me.tbPLot, "tbPLot")
        Me.tbPLot.Name = "tbPLot"
        Me.tbPLot.UseVisualStyleBackColor = True
        '
        'grpPlotMargin
        '
        Me.grpPlotMargin.Controls.Add(Me.ucrPlotMargin)
        resources.ApplyResources(Me.grpPlotMargin, "grpPlotMargin")
        Me.grpPlotMargin.Name = "grpPlotMargin"
        Me.grpPlotMargin.TabStop = False
        '
        'ucrPlotMargin
        '
        resources.ApplyResources(Me.ucrPlotMargin, "ucrPlotMargin")
        Me.ucrPlotMargin.Name = "ucrPlotMargin"
        '
        'grpPlotBackground
        '
        Me.grpPlotBackground.Controls.Add(Me.ucrPlotBackground)
        resources.ApplyResources(Me.grpPlotBackground, "grpPlotBackground")
        Me.grpPlotBackground.Name = "grpPlotBackground"
        Me.grpPlotBackground.TabStop = False
        '
        'ucrPlotBackground
        '
        resources.ApplyResources(Me.ucrPlotBackground, "ucrPlotBackground")
        Me.ucrPlotBackground.Name = "ucrPlotBackground"
        '
        'grpPlotTitleAndCaption
        '
        Me.grpPlotTitleAndCaption.Controls.Add(Me.ucrPlotCaption)
        Me.grpPlotTitleAndCaption.Controls.Add(Me.ucrPlotSubTitle)
        Me.grpPlotTitleAndCaption.Controls.Add(Me.ucrPlotTitle)
        resources.ApplyResources(Me.grpPlotTitleAndCaption, "grpPlotTitleAndCaption")
        Me.grpPlotTitleAndCaption.Name = "grpPlotTitleAndCaption"
        Me.grpPlotTitleAndCaption.TabStop = False
        '
        'ucrPlotCaption
        '
        resources.ApplyResources(Me.ucrPlotCaption, "ucrPlotCaption")
        Me.ucrPlotCaption.Name = "ucrPlotCaption"
        '
        'ucrPlotSubTitle
        '
        resources.ApplyResources(Me.ucrPlotSubTitle, "ucrPlotSubTitle")
        Me.ucrPlotSubTitle.Name = "ucrPlotSubTitle"
        '
        'ucrPlotTitle
        '
        resources.ApplyResources(Me.ucrPlotTitle, "ucrPlotTitle")
        Me.ucrPlotTitle.Name = "ucrPlotTitle"
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
        resources.ApplyResources(Me.tbLegend, "tbLegend")
        Me.tbLegend.Name = "tbLegend"
        Me.tbLegend.SelectedIndex = 0
        '
        'tbThemeLegendMoreOptions
        '
        Me.tbThemeLegendMoreOptions.Controls.Add(Me.grpLegendBoxSpacing)
        Me.tbThemeLegendMoreOptions.Controls.Add(Me.grpLegendSpacing)
        resources.ApplyResources(Me.tbThemeLegendMoreOptions, "tbThemeLegendMoreOptions")
        Me.tbThemeLegendMoreOptions.Name = "tbThemeLegendMoreOptions"
        Me.tbThemeLegendMoreOptions.UseVisualStyleBackColor = True
        '
        'grpLegendBoxSpacing
        '
        Me.grpLegendBoxSpacing.Controls.Add(Me.ucrLegendBoxSpacing)
        resources.ApplyResources(Me.grpLegendBoxSpacing, "grpLegendBoxSpacing")
        Me.grpLegendBoxSpacing.Name = "grpLegendBoxSpacing"
        Me.grpLegendBoxSpacing.TabStop = False
        '
        'ucrLegendBoxSpacing
        '
        resources.ApplyResources(Me.ucrLegendBoxSpacing, "ucrLegendBoxSpacing")
        Me.ucrLegendBoxSpacing.Name = "ucrLegendBoxSpacing"
        '
        'grpLegendSpacing
        '
        Me.grpLegendSpacing.Controls.Add(Me.ucrLegendSpacingYAxis)
        Me.grpLegendSpacing.Controls.Add(Me.ucrLegendSpacingXAxis)
        Me.grpLegendSpacing.Controls.Add(Me.ucrLegendSpacing)
        resources.ApplyResources(Me.grpLegendSpacing, "grpLegendSpacing")
        Me.grpLegendSpacing.Name = "grpLegendSpacing"
        Me.grpLegendSpacing.TabStop = False
        '
        'ucrLegendSpacingYAxis
        '
        resources.ApplyResources(Me.ucrLegendSpacingYAxis, "ucrLegendSpacingYAxis")
        Me.ucrLegendSpacingYAxis.Name = "ucrLegendSpacingYAxis"
        '
        'ucrLegendSpacingXAxis
        '
        resources.ApplyResources(Me.ucrLegendSpacingXAxis, "ucrLegendSpacingXAxis")
        Me.ucrLegendSpacingXAxis.Name = "ucrLegendSpacingXAxis"
        '
        'ucrLegendSpacing
        '
        resources.ApplyResources(Me.ucrLegendSpacing, "ucrLegendSpacing")
        Me.ucrLegendSpacing.Name = "ucrLegendSpacing"
        '
        'tbThemePanelMoreOptions
        '
        Me.tbThemePanelMoreOptions.Controls.Add(Me.grpPanelGridMajorMinor)
        resources.ApplyResources(Me.tbThemePanelMoreOptions, "tbThemePanelMoreOptions")
        Me.tbThemePanelMoreOptions.Name = "tbThemePanelMoreOptions"
        Me.tbThemePanelMoreOptions.UseVisualStyleBackColor = True
        '
        'grpPanelGridMajorMinor
        '
        Me.grpPanelGridMajorMinor.Controls.Add(Me.ucrPanelGridMinorYAxis)
        Me.grpPanelGridMajorMinor.Controls.Add(Me.ucrPanelGridMinorXAxis)
        Me.grpPanelGridMajorMinor.Controls.Add(Me.ucrPanelGridMajorYAxis)
        Me.grpPanelGridMajorMinor.Controls.Add(Me.ucrPanelGridMajorXAxis)
        resources.ApplyResources(Me.grpPanelGridMajorMinor, "grpPanelGridMajorMinor")
        Me.grpPanelGridMajorMinor.Name = "grpPanelGridMajorMinor"
        Me.grpPanelGridMajorMinor.TabStop = False
        '
        'ucrPanelGridMinorYAxis
        '
        resources.ApplyResources(Me.ucrPanelGridMinorYAxis, "ucrPanelGridMinorYAxis")
        Me.ucrPanelGridMinorYAxis.Name = "ucrPanelGridMinorYAxis"
        '
        'ucrPanelGridMinorXAxis
        '
        resources.ApplyResources(Me.ucrPanelGridMinorXAxis, "ucrPanelGridMinorXAxis")
        Me.ucrPanelGridMinorXAxis.Name = "ucrPanelGridMinorXAxis"
        '
        'ucrPanelGridMajorYAxis
        '
        resources.ApplyResources(Me.ucrPanelGridMajorYAxis, "ucrPanelGridMajorYAxis")
        Me.ucrPanelGridMajorYAxis.Name = "ucrPanelGridMajorYAxis"
        '
        'ucrPanelGridMajorXAxis
        '
        resources.ApplyResources(Me.ucrPanelGridMajorXAxis, "ucrPanelGridMajorXAxis")
        Me.ucrPanelGridMajorXAxis.Name = "ucrPanelGridMajorXAxis"
        '
        'sdgThemes
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbLegend)
        Me.Controls.Add(Me.ucrBaseSubdialogue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgThemes"
        Me.tbThemeFacets.ResumeLayout(False)
        Me.grpSpaceBetweenStripsAxes.ResumeLayout(False)
        Me.grpFacetBackground.ResumeLayout(False)
        Me.grpFacetLabels.ResumeLayout(False)
        Me.tbThemePanelAndBackground.ResumeLayout(False)
        Me.grpPanelSpacing.ResumeLayout(False)
        Me.grpBorderAndBackground.ResumeLayout(False)
        Me.grpPanelGrid.ResumeLayout(False)
        Me.tbThemeLegend.ResumeLayout(False)
        Me.grpLegendKeyAdjustment.ResumeLayout(False)
        Me.grpLegendTitleAndText.ResumeLayout(False)
        Me.grpLegendAdjustments.ResumeLayout(False)
        Me.grpLegendBackGroundAndKey.ResumeLayout(False)
        Me.tbThemeYaxis.ResumeLayout(False)
        Me.grpYAxisTitle.ResumeLayout(False)
        Me.grpTickMarkLabelsYAxis.ResumeLayout(False)
        Me.grpTickMarkers.ResumeLayout(False)
        Me.tbThemeXAxis.ResumeLayout(False)
        Me.grpTickMarkLabelsXAxis.ResumeLayout(False)
        Me.grpTickMarks.ResumeLayout(False)
        Me.grpXAxisTitle.ResumeLayout(False)
        Me.tbXYAxes.ResumeLayout(False)
        Me.grpTickLength.ResumeLayout(False)
        Me.tbPLot.ResumeLayout(False)
        Me.grpPlotMargin.ResumeLayout(False)
        Me.grpPlotBackground.ResumeLayout(False)
        Me.grpPlotTitleAndCaption.ResumeLayout(False)
        Me.tbLegend.ResumeLayout(False)
        Me.tbThemeLegendMoreOptions.ResumeLayout(False)
        Me.grpLegendBoxSpacing.ResumeLayout(False)
        Me.grpLegendSpacing.ResumeLayout(False)
        Me.tbThemePanelMoreOptions.ResumeLayout(False)
        Me.grpPanelGridMajorMinor.ResumeLayout(False)
        Me.ResumeLayout(False)

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
