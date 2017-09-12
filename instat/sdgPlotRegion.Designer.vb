﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgPlotRegion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ucrButtonsSdgPlotRegion = New instat.ucrButtonsSubdialogue()
        Me.tbcPlotRegion = New System.Windows.Forms.TabControl()
        Me.tbpLayout = New System.Windows.Forms.TabPage()
        Me.tbpAdditionalFeatures = New System.Windows.Forms.TabPage()
        Me.lblAddtoTitle = New System.Windows.Forms.Label()
        Me.ucrInputAddtoTitle = New instat.ucrInputTextBox()
        Me.lblMinLongitude = New System.Windows.Forms.Label()
        Me.ucrInputMinLongitude = New instat.ucrInputTextBox()
        Me.lblMaxLongitude = New System.Windows.Forms.Label()
        Me.ucrInputMaxLongitude = New instat.ucrInputTextBox()
        Me.lblMinLatitude = New System.Windows.Forms.Label()
        Me.ucrInputMinLatitude = New instat.ucrInputTextBox()
        Me.lblMaxLatitude = New System.Windows.Forms.Label()
        Me.ucrInputMaxLatitude = New instat.ucrInputTextBox()
        Me.lblPlotHeight = New System.Windows.Forms.Label()
        Me.ucrInputPlotHeight = New instat.ucrInputTextBox()
        Me.lblPlotWidth = New System.Windows.Forms.Label()
        Me.ucrInputPlotWidth = New instat.ucrInputTextBox()
        Me.ucrChkPlotAnomaly = New instat.ucrCheck()
        Me.ucrChkSetColourBreaks = New instat.ucrCheck()
        Me.lblMinBreakPoint = New System.Windows.Forms.Label()
        Me.ucrInputMinBreakPoint = New instat.ucrInputTextBox()
        Me.lblMaxBreakPoint = New System.Windows.Forms.Label()
        Me.ucrInputMaxBreakPoint = New instat.ucrInputTextBox()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.ucrInputInterval = New instat.ucrInputTextBox()
        Me.lblColourBarMin = New System.Windows.Forms.Label()
        Me.ucrInputColourBarMin = New instat.ucrInputTextBox()
        Me.lblColourBarMax = New System.Windows.Forms.Label()
        Me.ucrInputColourBarMax = New instat.ucrInputTextBox()
        Me.lblNumberofColours = New System.Windows.Forms.Label()
        Me.ucrNudNumberofColours = New instat.ucrNud()
        Me.ucrChkPlotHighResolution = New instat.ucrCheck()
        Me.ucrChkPlotCoastLines = New instat.ucrCheck()
        Me.ucrChkPlotCountries = New instat.ucrCheck()
        Me.ucrChkPlotRivers = New instat.ucrCheck()
        Me.ucrChkPlotCities = New instat.ucrCheck()
        Me.lblThickness = New System.Windows.Forms.Label()
        Me.ucrNudThickness = New instat.ucrNud()
        Me.lblSizeofCities = New System.Windows.Forms.Label()
        Me.ucrNudSizeofCities = New instat.ucrNud()
        Me.ucrChkLabelCities = New instat.ucrCheck()
        Me.lblPlotCapitals = New System.Windows.Forms.Label()
        Me.ucrInputPlotCapitals = New instat.ucrInputComboBox()
        Me.lblSizeofCityLabels = New System.Windows.Forms.Label()
        Me.ucrNudSizeofCityLabels = New instat.ucrNud()
        Me.lblLatitudOffset = New System.Windows.Forms.Label()
        Me.ucrNudLatitudeOffset = New instat.ucrNud()
        Me.tbcPlotRegion.SuspendLayout()
        Me.tbpLayout.SuspendLayout()
        Me.tbpAdditionalFeatures.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrButtonsSdgPlotRegion
        '
        Me.ucrButtonsSdgPlotRegion.Location = New System.Drawing.Point(160, 457)
        Me.ucrButtonsSdgPlotRegion.Name = "ucrButtonsSdgPlotRegion"
        Me.ucrButtonsSdgPlotRegion.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsSdgPlotRegion.TabIndex = 0
        '
        'tbcPlotRegion
        '
        Me.tbcPlotRegion.Controls.Add(Me.tbpLayout)
        Me.tbcPlotRegion.Controls.Add(Me.tbpAdditionalFeatures)
        Me.tbcPlotRegion.Location = New System.Drawing.Point(13, 13)
        Me.tbcPlotRegion.Name = "tbcPlotRegion"
        Me.tbcPlotRegion.SelectedIndex = 0
        Me.tbcPlotRegion.Size = New System.Drawing.Size(452, 449)
        Me.tbcPlotRegion.TabIndex = 1
        '
        'tbpLayout
        '
        Me.tbpLayout.Controls.Add(Me.ucrNudNumberofColours)
        Me.tbpLayout.Controls.Add(Me.ucrChkSetColourBreaks)
        Me.tbpLayout.Controls.Add(Me.ucrChkPlotAnomaly)
        Me.tbpLayout.Controls.Add(Me.ucrInputColourBarMax)
        Me.tbpLayout.Controls.Add(Me.ucrInputColourBarMin)
        Me.tbpLayout.Controls.Add(Me.lblNumberofColours)
        Me.tbpLayout.Controls.Add(Me.lblColourBarMax)
        Me.tbpLayout.Controls.Add(Me.ucrInputInterval)
        Me.tbpLayout.Controls.Add(Me.lblColourBarMin)
        Me.tbpLayout.Controls.Add(Me.ucrInputMaxBreakPoint)
        Me.tbpLayout.Controls.Add(Me.lblInterval)
        Me.tbpLayout.Controls.Add(Me.ucrInputMinBreakPoint)
        Me.tbpLayout.Controls.Add(Me.lblMaxBreakPoint)
        Me.tbpLayout.Controls.Add(Me.lblMinBreakPoint)
        Me.tbpLayout.Controls.Add(Me.ucrInputPlotWidth)
        Me.tbpLayout.Controls.Add(Me.lblPlotWidth)
        Me.tbpLayout.Controls.Add(Me.ucrInputPlotHeight)
        Me.tbpLayout.Controls.Add(Me.lblPlotHeight)
        Me.tbpLayout.Controls.Add(Me.ucrInputMaxLatitude)
        Me.tbpLayout.Controls.Add(Me.lblMaxLatitude)
        Me.tbpLayout.Controls.Add(Me.ucrInputMinLatitude)
        Me.tbpLayout.Controls.Add(Me.lblMinLatitude)
        Me.tbpLayout.Controls.Add(Me.ucrInputMaxLongitude)
        Me.tbpLayout.Controls.Add(Me.lblMaxLongitude)
        Me.tbpLayout.Controls.Add(Me.ucrInputMinLongitude)
        Me.tbpLayout.Controls.Add(Me.lblMinLongitude)
        Me.tbpLayout.Controls.Add(Me.ucrInputAddtoTitle)
        Me.tbpLayout.Controls.Add(Me.lblAddtoTitle)
        Me.tbpLayout.Location = New System.Drawing.Point(4, 22)
        Me.tbpLayout.Name = "tbpLayout"
        Me.tbpLayout.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpLayout.Size = New System.Drawing.Size(444, 423)
        Me.tbpLayout.TabIndex = 0
        Me.tbpLayout.Text = "Layout"
        Me.tbpLayout.UseVisualStyleBackColor = True
        '
        'tbpAdditionalFeatures
        '
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrInputPlotCapitals)
        Me.tbpAdditionalFeatures.Controls.Add(Me.lblPlotCapitals)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrNudLatitudeOffset)
        Me.tbpAdditionalFeatures.Controls.Add(Me.lblLatitudOffset)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrNudSizeofCityLabels)
        Me.tbpAdditionalFeatures.Controls.Add(Me.lblSizeofCityLabels)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrNudSizeofCities)
        Me.tbpAdditionalFeatures.Controls.Add(Me.lblSizeofCities)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrNudThickness)
        Me.tbpAdditionalFeatures.Controls.Add(Me.lblThickness)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrChkLabelCities)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrChkPlotCities)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrChkPlotRivers)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrChkPlotCountries)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrChkPlotCoastLines)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrChkPlotHighResolution)
        Me.tbpAdditionalFeatures.Location = New System.Drawing.Point(4, 22)
        Me.tbpAdditionalFeatures.Name = "tbpAdditionalFeatures"
        Me.tbpAdditionalFeatures.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAdditionalFeatures.Size = New System.Drawing.Size(444, 423)
        Me.tbpAdditionalFeatures.TabIndex = 1
        Me.tbpAdditionalFeatures.Text = "Additional Features"
        Me.tbpAdditionalFeatures.UseVisualStyleBackColor = True
        '
        'lblAddtoTitle
        '
        Me.lblAddtoTitle.AutoSize = True
        Me.lblAddtoTitle.Location = New System.Drawing.Point(7, 16)
        Me.lblAddtoTitle.Name = "lblAddtoTitle"
        Me.lblAddtoTitle.Size = New System.Drawing.Size(61, 13)
        Me.lblAddtoTitle.TabIndex = 0
        Me.lblAddtoTitle.Text = "Add to Title"
        '
        'ucrInputAddtoTitle
        '
        Me.ucrInputAddtoTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputAddtoTitle.IsMultiline = False
        Me.ucrInputAddtoTitle.IsReadOnly = False
        Me.ucrInputAddtoTitle.Location = New System.Drawing.Point(143, 16)
        Me.ucrInputAddtoTitle.Name = "ucrInputAddtoTitle"
        Me.ucrInputAddtoTitle.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputAddtoTitle.TabIndex = 1
        '
        'lblMinLongitude
        '
        Me.lblMinLongitude.AutoSize = True
        Me.lblMinLongitude.Location = New System.Drawing.Point(7, 43)
        Me.lblMinLongitude.Name = "lblMinLongitude"
        Me.lblMinLongitude.Size = New System.Drawing.Size(74, 13)
        Me.lblMinLongitude.TabIndex = 0
        Me.lblMinLongitude.Text = "Min Longitude"
        '
        'ucrInputMinLongitude
        '
        Me.ucrInputMinLongitude.AddQuotesIfUnrecognised = True
        Me.ucrInputMinLongitude.IsMultiline = False
        Me.ucrInputMinLongitude.IsReadOnly = False
        Me.ucrInputMinLongitude.Location = New System.Drawing.Point(143, 43)
        Me.ucrInputMinLongitude.Name = "ucrInputMinLongitude"
        Me.ucrInputMinLongitude.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputMinLongitude.TabIndex = 1
        '
        'lblMaxLongitude
        '
        Me.lblMaxLongitude.AutoSize = True
        Me.lblMaxLongitude.Location = New System.Drawing.Point(7, 70)
        Me.lblMaxLongitude.Name = "lblMaxLongitude"
        Me.lblMaxLongitude.Size = New System.Drawing.Size(77, 13)
        Me.lblMaxLongitude.TabIndex = 0
        Me.lblMaxLongitude.Text = "Max Longitude"
        '
        'ucrInputMaxLongitude
        '
        Me.ucrInputMaxLongitude.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxLongitude.IsMultiline = False
        Me.ucrInputMaxLongitude.IsReadOnly = False
        Me.ucrInputMaxLongitude.Location = New System.Drawing.Point(143, 70)
        Me.ucrInputMaxLongitude.Name = "ucrInputMaxLongitude"
        Me.ucrInputMaxLongitude.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputMaxLongitude.TabIndex = 1
        '
        'lblMinLatitude
        '
        Me.lblMinLatitude.AutoSize = True
        Me.lblMinLatitude.Location = New System.Drawing.Point(7, 97)
        Me.lblMinLatitude.Name = "lblMinLatitude"
        Me.lblMinLatitude.Size = New System.Drawing.Size(65, 13)
        Me.lblMinLatitude.TabIndex = 0
        Me.lblMinLatitude.Text = "Min Latitude"
        '
        'ucrInputMinLatitude
        '
        Me.ucrInputMinLatitude.AddQuotesIfUnrecognised = True
        Me.ucrInputMinLatitude.IsMultiline = False
        Me.ucrInputMinLatitude.IsReadOnly = False
        Me.ucrInputMinLatitude.Location = New System.Drawing.Point(143, 97)
        Me.ucrInputMinLatitude.Name = "ucrInputMinLatitude"
        Me.ucrInputMinLatitude.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputMinLatitude.TabIndex = 1
        '
        'lblMaxLatitude
        '
        Me.lblMaxLatitude.AutoSize = True
        Me.lblMaxLatitude.Location = New System.Drawing.Point(7, 124)
        Me.lblMaxLatitude.Name = "lblMaxLatitude"
        Me.lblMaxLatitude.Size = New System.Drawing.Size(65, 13)
        Me.lblMaxLatitude.TabIndex = 0
        Me.lblMaxLatitude.Text = "Min Latitude"
        '
        'ucrInputMaxLatitude
        '
        Me.ucrInputMaxLatitude.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxLatitude.IsMultiline = False
        Me.ucrInputMaxLatitude.IsReadOnly = False
        Me.ucrInputMaxLatitude.Location = New System.Drawing.Point(143, 124)
        Me.ucrInputMaxLatitude.Name = "ucrInputMaxLatitude"
        Me.ucrInputMaxLatitude.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputMaxLatitude.TabIndex = 1
        '
        'lblPlotHeight
        '
        Me.lblPlotHeight.AutoSize = True
        Me.lblPlotHeight.Location = New System.Drawing.Point(7, 151)
        Me.lblPlotHeight.Name = "lblPlotHeight"
        Me.lblPlotHeight.Size = New System.Drawing.Size(59, 13)
        Me.lblPlotHeight.TabIndex = 0
        Me.lblPlotHeight.Text = "Plot Height"
        '
        'ucrInputPlotHeight
        '
        Me.ucrInputPlotHeight.AddQuotesIfUnrecognised = True
        Me.ucrInputPlotHeight.IsMultiline = False
        Me.ucrInputPlotHeight.IsReadOnly = False
        Me.ucrInputPlotHeight.Location = New System.Drawing.Point(143, 151)
        Me.ucrInputPlotHeight.Name = "ucrInputPlotHeight"
        Me.ucrInputPlotHeight.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPlotHeight.TabIndex = 1
        '
        'lblPlotWidth
        '
        Me.lblPlotWidth.AutoSize = True
        Me.lblPlotWidth.Location = New System.Drawing.Point(7, 178)
        Me.lblPlotWidth.Name = "lblPlotWidth"
        Me.lblPlotWidth.Size = New System.Drawing.Size(56, 13)
        Me.lblPlotWidth.TabIndex = 0
        Me.lblPlotWidth.Text = "Plot Width"
        '
        'ucrInputPlotWidth
        '
        Me.ucrInputPlotWidth.AddQuotesIfUnrecognised = True
        Me.ucrInputPlotWidth.IsMultiline = False
        Me.ucrInputPlotWidth.IsReadOnly = False
        Me.ucrInputPlotWidth.Location = New System.Drawing.Point(143, 178)
        Me.ucrInputPlotWidth.Name = "ucrInputPlotWidth"
        Me.ucrInputPlotWidth.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPlotWidth.TabIndex = 1
        '
        'ucrChkPlotAnomaly
        '
        Me.ucrChkPlotAnomaly.Checked = False
        Me.ucrChkPlotAnomaly.Location = New System.Drawing.Point(10, 205)
        Me.ucrChkPlotAnomaly.Name = "ucrChkPlotAnomaly"
        Me.ucrChkPlotAnomaly.Size = New System.Drawing.Size(210, 20)
        Me.ucrChkPlotAnomaly.TabIndex = 2
        '
        'ucrChkSetColourBreaks
        '
        Me.ucrChkSetColourBreaks.Checked = False
        Me.ucrChkSetColourBreaks.Location = New System.Drawing.Point(10, 231)
        Me.ucrChkSetColourBreaks.Name = "ucrChkSetColourBreaks"
        Me.ucrChkSetColourBreaks.Size = New System.Drawing.Size(210, 20)
        Me.ucrChkSetColourBreaks.TabIndex = 2
        '
        'lblMinBreakPoint
        '
        Me.lblMinBreakPoint.AutoSize = True
        Me.lblMinBreakPoint.Location = New System.Drawing.Point(7, 257)
        Me.lblMinBreakPoint.Name = "lblMinBreakPoint"
        Me.lblMinBreakPoint.Size = New System.Drawing.Size(82, 13)
        Me.lblMinBreakPoint.TabIndex = 0
        Me.lblMinBreakPoint.Text = "Min Break Point"
        '
        'ucrInputMinBreakPoint
        '
        Me.ucrInputMinBreakPoint.AddQuotesIfUnrecognised = True
        Me.ucrInputMinBreakPoint.IsMultiline = False
        Me.ucrInputMinBreakPoint.IsReadOnly = False
        Me.ucrInputMinBreakPoint.Location = New System.Drawing.Point(143, 257)
        Me.ucrInputMinBreakPoint.Name = "ucrInputMinBreakPoint"
        Me.ucrInputMinBreakPoint.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputMinBreakPoint.TabIndex = 1
        '
        'lblMaxBreakPoint
        '
        Me.lblMaxBreakPoint.AutoSize = True
        Me.lblMaxBreakPoint.Location = New System.Drawing.Point(7, 281)
        Me.lblMaxBreakPoint.Name = "lblMaxBreakPoint"
        Me.lblMaxBreakPoint.Size = New System.Drawing.Size(85, 13)
        Me.lblMaxBreakPoint.TabIndex = 0
        Me.lblMaxBreakPoint.Text = "Max Break Point"
        '
        'ucrInputMaxBreakPoint
        '
        Me.ucrInputMaxBreakPoint.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxBreakPoint.IsMultiline = False
        Me.ucrInputMaxBreakPoint.IsReadOnly = False
        Me.ucrInputMaxBreakPoint.Location = New System.Drawing.Point(143, 281)
        Me.ucrInputMaxBreakPoint.Name = "ucrInputMaxBreakPoint"
        Me.ucrInputMaxBreakPoint.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputMaxBreakPoint.TabIndex = 1
        '
        'lblInterval
        '
        Me.lblInterval.AutoSize = True
        Me.lblInterval.Location = New System.Drawing.Point(7, 308)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(42, 13)
        Me.lblInterval.TabIndex = 0
        Me.lblInterval.Text = "Interval"
        '
        'ucrInputInterval
        '
        Me.ucrInputInterval.AddQuotesIfUnrecognised = True
        Me.ucrInputInterval.IsMultiline = False
        Me.ucrInputInterval.IsReadOnly = False
        Me.ucrInputInterval.Location = New System.Drawing.Point(143, 308)
        Me.ucrInputInterval.Name = "ucrInputInterval"
        Me.ucrInputInterval.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputInterval.TabIndex = 1
        '
        'lblColourBarMin
        '
        Me.lblColourBarMin.AutoSize = True
        Me.lblColourBarMin.Location = New System.Drawing.Point(7, 335)
        Me.lblColourBarMin.Name = "lblColourBarMin"
        Me.lblColourBarMin.Size = New System.Drawing.Size(76, 13)
        Me.lblColourBarMin.TabIndex = 0
        Me.lblColourBarMin.Text = "Colour Bar Min"
        '
        'ucrInputColourBarMin
        '
        Me.ucrInputColourBarMin.AddQuotesIfUnrecognised = True
        Me.ucrInputColourBarMin.IsMultiline = False
        Me.ucrInputColourBarMin.IsReadOnly = False
        Me.ucrInputColourBarMin.Location = New System.Drawing.Point(143, 335)
        Me.ucrInputColourBarMin.Name = "ucrInputColourBarMin"
        Me.ucrInputColourBarMin.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputColourBarMin.TabIndex = 1
        '
        'lblColourBarMax
        '
        Me.lblColourBarMax.AutoSize = True
        Me.lblColourBarMax.Location = New System.Drawing.Point(7, 362)
        Me.lblColourBarMax.Name = "lblColourBarMax"
        Me.lblColourBarMax.Size = New System.Drawing.Size(79, 13)
        Me.lblColourBarMax.TabIndex = 0
        Me.lblColourBarMax.Text = "Colour Bar Max"
        '
        'ucrInputColourBarMax
        '
        Me.ucrInputColourBarMax.AddQuotesIfUnrecognised = True
        Me.ucrInputColourBarMax.IsMultiline = False
        Me.ucrInputColourBarMax.IsReadOnly = False
        Me.ucrInputColourBarMax.Location = New System.Drawing.Point(143, 362)
        Me.ucrInputColourBarMax.Name = "ucrInputColourBarMax"
        Me.ucrInputColourBarMax.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputColourBarMax.TabIndex = 1
        '
        'lblNumberofColours
        '
        Me.lblNumberofColours.AutoSize = True
        Me.lblNumberofColours.Location = New System.Drawing.Point(7, 388)
        Me.lblNumberofColours.Name = "lblNumberofColours"
        Me.lblNumberofColours.Size = New System.Drawing.Size(94, 13)
        Me.lblNumberofColours.TabIndex = 0
        Me.lblNumberofColours.Text = "Number of Colours"
        '
        'ucrNudNumberofColours
        '
        Me.ucrNudNumberofColours.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofColours.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberofColours.Location = New System.Drawing.Point(143, 390)
        Me.ucrNudNumberofColours.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberofColours.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofColours.Name = "ucrNudNumberofColours"
        Me.ucrNudNumberofColours.Size = New System.Drawing.Size(62, 20)
        Me.ucrNudNumberofColours.TabIndex = 3
        Me.ucrNudNumberofColours.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkPlotHighResolution
        '
        Me.ucrChkPlotHighResolution.Checked = False
        Me.ucrChkPlotHighResolution.Location = New System.Drawing.Point(7, 16)
        Me.ucrChkPlotHighResolution.Name = "ucrChkPlotHighResolution"
        Me.ucrChkPlotHighResolution.Size = New System.Drawing.Size(278, 20)
        Me.ucrChkPlotHighResolution.TabIndex = 0
        '
        'ucrChkPlotCoastLines
        '
        Me.ucrChkPlotCoastLines.Checked = False
        Me.ucrChkPlotCoastLines.Location = New System.Drawing.Point(7, 42)
        Me.ucrChkPlotCoastLines.Name = "ucrChkPlotCoastLines"
        Me.ucrChkPlotCoastLines.Size = New System.Drawing.Size(278, 20)
        Me.ucrChkPlotCoastLines.TabIndex = 0
        '
        'ucrChkPlotCountries
        '
        Me.ucrChkPlotCountries.Checked = False
        Me.ucrChkPlotCountries.Location = New System.Drawing.Point(7, 68)
        Me.ucrChkPlotCountries.Name = "ucrChkPlotCountries"
        Me.ucrChkPlotCountries.Size = New System.Drawing.Size(278, 20)
        Me.ucrChkPlotCountries.TabIndex = 0
        '
        'ucrChkPlotRivers
        '
        Me.ucrChkPlotRivers.Checked = False
        Me.ucrChkPlotRivers.Location = New System.Drawing.Point(6, 94)
        Me.ucrChkPlotRivers.Name = "ucrChkPlotRivers"
        Me.ucrChkPlotRivers.Size = New System.Drawing.Size(278, 20)
        Me.ucrChkPlotRivers.TabIndex = 0
        '
        'ucrChkPlotCities
        '
        Me.ucrChkPlotCities.Checked = False
        Me.ucrChkPlotCities.Location = New System.Drawing.Point(7, 121)
        Me.ucrChkPlotCities.Name = "ucrChkPlotCities"
        Me.ucrChkPlotCities.Size = New System.Drawing.Size(190, 20)
        Me.ucrChkPlotCities.TabIndex = 0
        '
        'lblThickness
        '
        Me.lblThickness.AutoSize = True
        Me.lblThickness.Location = New System.Drawing.Point(7, 147)
        Me.lblThickness.Name = "lblThickness"
        Me.lblThickness.Size = New System.Drawing.Size(56, 13)
        Me.lblThickness.TabIndex = 1
        Me.lblThickness.Text = "Thickness"
        '
        'ucrNudThickness
        '
        Me.ucrNudThickness.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThickness.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudThickness.Location = New System.Drawing.Point(82, 147)
        Me.ucrNudThickness.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThickness.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThickness.Name = "ucrNudThickness"
        Me.ucrNudThickness.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudThickness.TabIndex = 2
        Me.ucrNudThickness.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblSizeofCities
        '
        Me.lblSizeofCities.AutoSize = True
        Me.lblSizeofCities.Location = New System.Drawing.Point(229, 127)
        Me.lblSizeofCities.Name = "lblSizeofCities"
        Me.lblSizeofCities.Size = New System.Drawing.Size(67, 13)
        Me.lblSizeofCities.TabIndex = 1
        Me.lblSizeofCities.Text = "Size of Cities"
        '
        'ucrNudSizeofCities
        '
        Me.ucrNudSizeofCities.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSizeofCities.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSizeofCities.Location = New System.Drawing.Point(304, 127)
        Me.ucrNudSizeofCities.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSizeofCities.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSizeofCities.Name = "ucrNudSizeofCities"
        Me.ucrNudSizeofCities.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSizeofCities.TabIndex = 2
        Me.ucrNudSizeofCities.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkLabelCities
        '
        Me.ucrChkLabelCities.Checked = False
        Me.ucrChkLabelCities.Location = New System.Drawing.Point(7, 186)
        Me.ucrChkLabelCities.Name = "ucrChkLabelCities"
        Me.ucrChkLabelCities.Size = New System.Drawing.Size(190, 20)
        Me.ucrChkLabelCities.TabIndex = 0
        '
        'lblPlotCapitals
        '
        Me.lblPlotCapitals.AutoSize = True
        Me.lblPlotCapitals.Location = New System.Drawing.Point(6, 223)
        Me.lblPlotCapitals.Name = "lblPlotCapitals"
        Me.lblPlotCapitals.Size = New System.Drawing.Size(65, 13)
        Me.lblPlotCapitals.TabIndex = 3
        Me.lblPlotCapitals.Text = "Plot Capitals"
        '
        'ucrInputPlotCapitals
        '
        Me.ucrInputPlotCapitals.AddQuotesIfUnrecognised = True
        Me.ucrInputPlotCapitals.IsReadOnly = False
        Me.ucrInputPlotCapitals.Location = New System.Drawing.Point(92, 223)
        Me.ucrInputPlotCapitals.Name = "ucrInputPlotCapitals"
        Me.ucrInputPlotCapitals.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPlotCapitals.TabIndex = 4
        '
        'lblSizeofCityLabels
        '
        Me.lblSizeofCityLabels.AutoSize = True
        Me.lblSizeofCityLabels.Location = New System.Drawing.Point(4, 274)
        Me.lblSizeofCityLabels.Name = "lblSizeofCityLabels"
        Me.lblSizeofCityLabels.Size = New System.Drawing.Size(93, 13)
        Me.lblSizeofCityLabels.TabIndex = 1
        Me.lblSizeofCityLabels.Text = "Size of City Labels"
        '
        'ucrNudSizeofCityLabels
        '
        Me.ucrNudSizeofCityLabels.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSizeofCityLabels.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSizeofCityLabels.Location = New System.Drawing.Point(103, 274)
        Me.ucrNudSizeofCityLabels.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSizeofCityLabels.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSizeofCityLabels.Name = "ucrNudSizeofCityLabels"
        Me.ucrNudSizeofCityLabels.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSizeofCityLabels.TabIndex = 2
        Me.ucrNudSizeofCityLabels.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLatitudOffset
        '
        Me.lblLatitudOffset.AutoSize = True
        Me.lblLatitudOffset.Location = New System.Drawing.Point(4, 314)
        Me.lblLatitudOffset.Name = "lblLatitudOffset"
        Me.lblLatitudOffset.Size = New System.Drawing.Size(76, 13)
        Me.lblLatitudOffset.TabIndex = 1
        Me.lblLatitudOffset.Text = "Latitude Offset"
        '
        'ucrNudLatitudeOffset
        '
        Me.ucrNudLatitudeOffset.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLatitudeOffset.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLatitudeOffset.Location = New System.Drawing.Point(103, 314)
        Me.ucrNudLatitudeOffset.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLatitudeOffset.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLatitudeOffset.Name = "ucrNudLatitudeOffset"
        Me.ucrNudLatitudeOffset.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLatitudeOffset.TabIndex = 2
        Me.ucrNudLatitudeOffset.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'sdgPlotRegion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 492)
        Me.Controls.Add(Me.tbcPlotRegion)
        Me.Controls.Add(Me.ucrButtonsSdgPlotRegion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgPlotRegion"
        Me.Text = "Plot Region"
        Me.tbcPlotRegion.ResumeLayout(False)
        Me.tbpLayout.ResumeLayout(False)
        Me.tbpLayout.PerformLayout()
        Me.tbpAdditionalFeatures.ResumeLayout(False)
        Me.tbpAdditionalFeatures.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtonsSdgPlotRegion As ucrButtonsSubdialogue
    Friend WithEvents tbcPlotRegion As TabControl
    Friend WithEvents tbpLayout As TabPage
    Friend WithEvents ucrInputAddtoTitle As ucrInputTextBox
    Friend WithEvents lblAddtoTitle As Label
    Friend WithEvents tbpAdditionalFeatures As TabPage
    Friend WithEvents ucrInputMinLongitude As ucrInputTextBox
    Friend WithEvents lblMinLongitude As Label
    Friend WithEvents ucrInputMaxLongitude As ucrInputTextBox
    Friend WithEvents lblMaxLongitude As Label
    Friend WithEvents ucrInputMinLatitude As ucrInputTextBox
    Friend WithEvents lblMinLatitude As Label
    Friend WithEvents ucrInputMaxLatitude As ucrInputTextBox
    Friend WithEvents lblMaxLatitude As Label
    Friend WithEvents ucrInputPlotHeight As ucrInputTextBox
    Friend WithEvents lblPlotHeight As Label
    Friend WithEvents ucrInputPlotWidth As ucrInputTextBox
    Friend WithEvents lblPlotWidth As Label
    Friend WithEvents ucrChkPlotAnomaly As ucrCheck
    Friend WithEvents ucrChkSetColourBreaks As ucrCheck
    Friend WithEvents ucrInputMinBreakPoint As ucrInputTextBox
    Friend WithEvents lblMinBreakPoint As Label
    Friend WithEvents ucrInputMaxBreakPoint As ucrInputTextBox
    Friend WithEvents lblMaxBreakPoint As Label
    Friend WithEvents ucrInputInterval As ucrInputTextBox
    Friend WithEvents lblInterval As Label
    Friend WithEvents ucrInputColourBarMin As ucrInputTextBox
    Friend WithEvents lblColourBarMin As Label
    Friend WithEvents ucrInputColourBarMax As ucrInputTextBox
    Friend WithEvents lblColourBarMax As Label
    Friend WithEvents ucrNudNumberofColours As ucrNud
    Friend WithEvents lblNumberofColours As Label
    Friend WithEvents ucrChkPlotCities As ucrCheck
    Friend WithEvents ucrChkPlotRivers As ucrCheck
    Friend WithEvents ucrChkPlotCountries As ucrCheck
    Friend WithEvents ucrChkPlotCoastLines As ucrCheck
    Friend WithEvents ucrChkPlotHighResolution As ucrCheck
    Friend WithEvents ucrNudThickness As ucrNud
    Friend WithEvents lblThickness As Label
    Friend WithEvents ucrNudSizeofCities As ucrNud
    Friend WithEvents lblSizeofCities As Label
    Friend WithEvents ucrChkLabelCities As ucrCheck
    Friend WithEvents ucrInputPlotCapitals As ucrInputComboBox
    Friend WithEvents lblPlotCapitals As Label
    Friend WithEvents ucrNudSizeofCityLabels As ucrNud
    Friend WithEvents lblSizeofCityLabels As Label
    Friend WithEvents ucrNudLatitudeOffset As ucrNud
    Friend WithEvents lblLatitudOffset As Label
End Class
