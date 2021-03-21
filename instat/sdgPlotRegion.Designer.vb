<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgPlotRegion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgPlotRegion))
        Me.tbcPlotRegion = New System.Windows.Forms.TabControl()
        Me.tbpLayout = New System.Windows.Forms.TabPage()
        Me.ucrNudNumberofColours = New instat.ucrNud()
        Me.ucrChkSetColourBreaks = New instat.ucrCheck()
        Me.ucrChkPlotAnomaly = New instat.ucrCheck()
        Me.ucrInputColourBarMax = New instat.ucrInputTextBox()
        Me.ucrInputColourBarMin = New instat.ucrInputTextBox()
        Me.lblNumberofColours = New System.Windows.Forms.Label()
        Me.lblColourBarMax = New System.Windows.Forms.Label()
        Me.ucrInputInterval = New instat.ucrInputTextBox()
        Me.lblColourBarMin = New System.Windows.Forms.Label()
        Me.ucrInputMaxBreakPoint = New instat.ucrInputTextBox()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.ucrInputMinBreakPoint = New instat.ucrInputTextBox()
        Me.lblMaxBreakPoint = New System.Windows.Forms.Label()
        Me.lblMinBreakPoint = New System.Windows.Forms.Label()
        Me.ucrInputPlotWidth = New instat.ucrInputTextBox()
        Me.lblPlotWidth = New System.Windows.Forms.Label()
        Me.ucrInputPlotHeight = New instat.ucrInputTextBox()
        Me.lblPlotHeight = New System.Windows.Forms.Label()
        Me.ucrInputMaxLatitude = New instat.ucrInputTextBox()
        Me.lblMaxLatitude = New System.Windows.Forms.Label()
        Me.ucrInputMinLatitude = New instat.ucrInputTextBox()
        Me.lblMinLatitude = New System.Windows.Forms.Label()
        Me.ucrInputMaxLongitude = New instat.ucrInputTextBox()
        Me.lblMaxLongitude = New System.Windows.Forms.Label()
        Me.ucrInputMinLongitude = New instat.ucrInputTextBox()
        Me.lblMinLongitude = New System.Windows.Forms.Label()
        Me.ucrInputAddtoTitle = New instat.ucrInputTextBox()
        Me.lblAddtoTitle = New System.Windows.Forms.Label()
        Me.tbpAdditionalFeatures = New System.Windows.Forms.TabPage()
        Me.ucrInputPlotCapitals = New instat.ucrInputComboBox()
        Me.lblPlotCapitals = New System.Windows.Forms.Label()
        Me.lblLatitudOffset = New System.Windows.Forms.Label()
        Me.lblSizeofCityLabels = New System.Windows.Forms.Label()
        Me.lblSizeofCities = New System.Windows.Forms.Label()
        Me.lblThickness = New System.Windows.Forms.Label()
        Me.ucrNudLatitudeOffset = New instat.ucrNud()
        Me.ucrNudSizeofCityLabels = New instat.ucrNud()
        Me.ucrNudSizeofCities = New instat.ucrNud()
        Me.ucrNudThickness = New instat.ucrNud()
        Me.ucrChkPlotOwnLocations = New instat.ucrCheck()
        Me.ucrChkLabelCities = New instat.ucrCheck()
        Me.ucrChkPlotCities = New instat.ucrCheck()
        Me.ucrChkPlotRivers = New instat.ucrCheck()
        Me.ucrChkPlotCountries = New instat.ucrCheck()
        Me.ucrChkPlotCoastLines = New instat.ucrCheck()
        Me.ucrChkPlotHighResolution = New instat.ucrCheck()
        Me.ucrButtonsSdgPlotRegion = New instat.ucrButtonsSubdialogue()
        Me.tbcPlotRegion.SuspendLayout()
        Me.tbpLayout.SuspendLayout()
        Me.tbpAdditionalFeatures.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcPlotRegion
        '
        Me.tbcPlotRegion.Controls.Add(Me.tbpLayout)
        Me.tbcPlotRegion.Controls.Add(Me.tbpAdditionalFeatures)
        resources.ApplyResources(Me.tbcPlotRegion, "tbcPlotRegion")
        Me.tbcPlotRegion.Name = "tbcPlotRegion"
        Me.tbcPlotRegion.SelectedIndex = 0
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
        resources.ApplyResources(Me.tbpLayout, "tbpLayout")
        Me.tbpLayout.Name = "tbpLayout"
        Me.tbpLayout.UseVisualStyleBackColor = True
        '
        'ucrNudNumberofColours
        '
        Me.ucrNudNumberofColours.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofColours.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudNumberofColours, "ucrNudNumberofColours")
        Me.ucrNudNumberofColours.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberofColours.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofColours.Name = "ucrNudNumberofColours"
        Me.ucrNudNumberofColours.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkSetColourBreaks
        '
        Me.ucrChkSetColourBreaks.Checked = False
        resources.ApplyResources(Me.ucrChkSetColourBreaks, "ucrChkSetColourBreaks")
        Me.ucrChkSetColourBreaks.Name = "ucrChkSetColourBreaks"
        '
        'ucrChkPlotAnomaly
        '
        Me.ucrChkPlotAnomaly.Checked = False
        resources.ApplyResources(Me.ucrChkPlotAnomaly, "ucrChkPlotAnomaly")
        Me.ucrChkPlotAnomaly.Name = "ucrChkPlotAnomaly"
        '
        'ucrInputColourBarMax
        '
        Me.ucrInputColourBarMax.AddQuotesIfUnrecognised = True
        Me.ucrInputColourBarMax.IsMultiline = False
        Me.ucrInputColourBarMax.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputColourBarMax, "ucrInputColourBarMax")
        Me.ucrInputColourBarMax.Name = "ucrInputColourBarMax"
        '
        'ucrInputColourBarMin
        '
        Me.ucrInputColourBarMin.AddQuotesIfUnrecognised = True
        Me.ucrInputColourBarMin.IsMultiline = False
        Me.ucrInputColourBarMin.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputColourBarMin, "ucrInputColourBarMin")
        Me.ucrInputColourBarMin.Name = "ucrInputColourBarMin"
        '
        'lblNumberofColours
        '
        resources.ApplyResources(Me.lblNumberofColours, "lblNumberofColours")
        Me.lblNumberofColours.Name = "lblNumberofColours"
        '
        'lblColourBarMax
        '
        resources.ApplyResources(Me.lblColourBarMax, "lblColourBarMax")
        Me.lblColourBarMax.Name = "lblColourBarMax"
        '
        'ucrInputInterval
        '
        Me.ucrInputInterval.AddQuotesIfUnrecognised = True
        Me.ucrInputInterval.IsMultiline = False
        Me.ucrInputInterval.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputInterval, "ucrInputInterval")
        Me.ucrInputInterval.Name = "ucrInputInterval"
        '
        'lblColourBarMin
        '
        resources.ApplyResources(Me.lblColourBarMin, "lblColourBarMin")
        Me.lblColourBarMin.Name = "lblColourBarMin"
        '
        'ucrInputMaxBreakPoint
        '
        Me.ucrInputMaxBreakPoint.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxBreakPoint.IsMultiline = False
        Me.ucrInputMaxBreakPoint.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMaxBreakPoint, "ucrInputMaxBreakPoint")
        Me.ucrInputMaxBreakPoint.Name = "ucrInputMaxBreakPoint"
        '
        'lblInterval
        '
        resources.ApplyResources(Me.lblInterval, "lblInterval")
        Me.lblInterval.Name = "lblInterval"
        '
        'ucrInputMinBreakPoint
        '
        Me.ucrInputMinBreakPoint.AddQuotesIfUnrecognised = True
        Me.ucrInputMinBreakPoint.IsMultiline = False
        Me.ucrInputMinBreakPoint.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinBreakPoint, "ucrInputMinBreakPoint")
        Me.ucrInputMinBreakPoint.Name = "ucrInputMinBreakPoint"
        '
        'lblMaxBreakPoint
        '
        resources.ApplyResources(Me.lblMaxBreakPoint, "lblMaxBreakPoint")
        Me.lblMaxBreakPoint.Name = "lblMaxBreakPoint"
        '
        'lblMinBreakPoint
        '
        resources.ApplyResources(Me.lblMinBreakPoint, "lblMinBreakPoint")
        Me.lblMinBreakPoint.Name = "lblMinBreakPoint"
        '
        'ucrInputPlotWidth
        '
        Me.ucrInputPlotWidth.AddQuotesIfUnrecognised = True
        Me.ucrInputPlotWidth.IsMultiline = False
        Me.ucrInputPlotWidth.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPlotWidth, "ucrInputPlotWidth")
        Me.ucrInputPlotWidth.Name = "ucrInputPlotWidth"
        '
        'lblPlotWidth
        '
        resources.ApplyResources(Me.lblPlotWidth, "lblPlotWidth")
        Me.lblPlotWidth.Name = "lblPlotWidth"
        '
        'ucrInputPlotHeight
        '
        Me.ucrInputPlotHeight.AddQuotesIfUnrecognised = True
        Me.ucrInputPlotHeight.IsMultiline = False
        Me.ucrInputPlotHeight.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPlotHeight, "ucrInputPlotHeight")
        Me.ucrInputPlotHeight.Name = "ucrInputPlotHeight"
        '
        'lblPlotHeight
        '
        resources.ApplyResources(Me.lblPlotHeight, "lblPlotHeight")
        Me.lblPlotHeight.Name = "lblPlotHeight"
        '
        'ucrInputMaxLatitude
        '
        Me.ucrInputMaxLatitude.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxLatitude.IsMultiline = False
        Me.ucrInputMaxLatitude.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMaxLatitude, "ucrInputMaxLatitude")
        Me.ucrInputMaxLatitude.Name = "ucrInputMaxLatitude"
        '
        'lblMaxLatitude
        '
        resources.ApplyResources(Me.lblMaxLatitude, "lblMaxLatitude")
        Me.lblMaxLatitude.Name = "lblMaxLatitude"
        '
        'ucrInputMinLatitude
        '
        Me.ucrInputMinLatitude.AddQuotesIfUnrecognised = True
        Me.ucrInputMinLatitude.IsMultiline = False
        Me.ucrInputMinLatitude.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinLatitude, "ucrInputMinLatitude")
        Me.ucrInputMinLatitude.Name = "ucrInputMinLatitude"
        '
        'lblMinLatitude
        '
        resources.ApplyResources(Me.lblMinLatitude, "lblMinLatitude")
        Me.lblMinLatitude.Name = "lblMinLatitude"
        '
        'ucrInputMaxLongitude
        '
        Me.ucrInputMaxLongitude.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxLongitude.IsMultiline = False
        Me.ucrInputMaxLongitude.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMaxLongitude, "ucrInputMaxLongitude")
        Me.ucrInputMaxLongitude.Name = "ucrInputMaxLongitude"
        '
        'lblMaxLongitude
        '
        resources.ApplyResources(Me.lblMaxLongitude, "lblMaxLongitude")
        Me.lblMaxLongitude.Name = "lblMaxLongitude"
        '
        'ucrInputMinLongitude
        '
        Me.ucrInputMinLongitude.AddQuotesIfUnrecognised = True
        Me.ucrInputMinLongitude.IsMultiline = False
        Me.ucrInputMinLongitude.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinLongitude, "ucrInputMinLongitude")
        Me.ucrInputMinLongitude.Name = "ucrInputMinLongitude"
        '
        'lblMinLongitude
        '
        resources.ApplyResources(Me.lblMinLongitude, "lblMinLongitude")
        Me.lblMinLongitude.Name = "lblMinLongitude"
        '
        'ucrInputAddtoTitle
        '
        Me.ucrInputAddtoTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputAddtoTitle.IsMultiline = False
        Me.ucrInputAddtoTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputAddtoTitle, "ucrInputAddtoTitle")
        Me.ucrInputAddtoTitle.Name = "ucrInputAddtoTitle"
        '
        'lblAddtoTitle
        '
        resources.ApplyResources(Me.lblAddtoTitle, "lblAddtoTitle")
        Me.lblAddtoTitle.Name = "lblAddtoTitle"
        '
        'tbpAdditionalFeatures
        '
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrInputPlotCapitals)
        Me.tbpAdditionalFeatures.Controls.Add(Me.lblPlotCapitals)
        Me.tbpAdditionalFeatures.Controls.Add(Me.lblLatitudOffset)
        Me.tbpAdditionalFeatures.Controls.Add(Me.lblSizeofCityLabels)
        Me.tbpAdditionalFeatures.Controls.Add(Me.lblSizeofCities)
        Me.tbpAdditionalFeatures.Controls.Add(Me.lblThickness)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrNudLatitudeOffset)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrNudSizeofCityLabels)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrNudSizeofCities)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrNudThickness)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrChkPlotOwnLocations)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrChkLabelCities)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrChkPlotCities)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrChkPlotRivers)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrChkPlotCountries)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrChkPlotCoastLines)
        Me.tbpAdditionalFeatures.Controls.Add(Me.ucrChkPlotHighResolution)
        resources.ApplyResources(Me.tbpAdditionalFeatures, "tbpAdditionalFeatures")
        Me.tbpAdditionalFeatures.Name = "tbpAdditionalFeatures"
        Me.tbpAdditionalFeatures.UseVisualStyleBackColor = True
        '
        'ucrInputPlotCapitals
        '
        Me.ucrInputPlotCapitals.AddQuotesIfUnrecognised = True
        Me.ucrInputPlotCapitals.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPlotCapitals, "ucrInputPlotCapitals")
        Me.ucrInputPlotCapitals.Name = "ucrInputPlotCapitals"
        '
        'lblPlotCapitals
        '
        resources.ApplyResources(Me.lblPlotCapitals, "lblPlotCapitals")
        Me.lblPlotCapitals.Name = "lblPlotCapitals"
        '
        'lblLatitudOffset
        '
        resources.ApplyResources(Me.lblLatitudOffset, "lblLatitudOffset")
        Me.lblLatitudOffset.Name = "lblLatitudOffset"
        '
        'lblSizeofCityLabels
        '
        resources.ApplyResources(Me.lblSizeofCityLabels, "lblSizeofCityLabels")
        Me.lblSizeofCityLabels.Name = "lblSizeofCityLabels"
        '
        'lblSizeofCities
        '
        resources.ApplyResources(Me.lblSizeofCities, "lblSizeofCities")
        Me.lblSizeofCities.Name = "lblSizeofCities"
        '
        'lblThickness
        '
        resources.ApplyResources(Me.lblThickness, "lblThickness")
        Me.lblThickness.Name = "lblThickness"
        '
        'ucrNudLatitudeOffset
        '
        Me.ucrNudLatitudeOffset.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLatitudeOffset.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudLatitudeOffset, "ucrNudLatitudeOffset")
        Me.ucrNudLatitudeOffset.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLatitudeOffset.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLatitudeOffset.Name = "ucrNudLatitudeOffset"
        Me.ucrNudLatitudeOffset.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSizeofCityLabels
        '
        Me.ucrNudSizeofCityLabels.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSizeofCityLabels.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSizeofCityLabels, "ucrNudSizeofCityLabels")
        Me.ucrNudSizeofCityLabels.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSizeofCityLabels.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSizeofCityLabels.Name = "ucrNudSizeofCityLabels"
        Me.ucrNudSizeofCityLabels.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSizeofCities
        '
        Me.ucrNudSizeofCities.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSizeofCities.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSizeofCities, "ucrNudSizeofCities")
        Me.ucrNudSizeofCities.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSizeofCities.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSizeofCities.Name = "ucrNudSizeofCities"
        Me.ucrNudSizeofCities.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudThickness
        '
        Me.ucrNudThickness.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThickness.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudThickness, "ucrNudThickness")
        Me.ucrNudThickness.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThickness.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThickness.Name = "ucrNudThickness"
        Me.ucrNudThickness.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkPlotOwnLocations
        '
        Me.ucrChkPlotOwnLocations.Checked = False
        resources.ApplyResources(Me.ucrChkPlotOwnLocations, "ucrChkPlotOwnLocations")
        Me.ucrChkPlotOwnLocations.Name = "ucrChkPlotOwnLocations"
        '
        'ucrChkLabelCities
        '
        Me.ucrChkLabelCities.Checked = False
        resources.ApplyResources(Me.ucrChkLabelCities, "ucrChkLabelCities")
        Me.ucrChkLabelCities.Name = "ucrChkLabelCities"
        '
        'ucrChkPlotCities
        '
        Me.ucrChkPlotCities.Checked = False
        resources.ApplyResources(Me.ucrChkPlotCities, "ucrChkPlotCities")
        Me.ucrChkPlotCities.Name = "ucrChkPlotCities"
        '
        'ucrChkPlotRivers
        '
        Me.ucrChkPlotRivers.Checked = False
        resources.ApplyResources(Me.ucrChkPlotRivers, "ucrChkPlotRivers")
        Me.ucrChkPlotRivers.Name = "ucrChkPlotRivers"
        '
        'ucrChkPlotCountries
        '
        Me.ucrChkPlotCountries.Checked = False
        resources.ApplyResources(Me.ucrChkPlotCountries, "ucrChkPlotCountries")
        Me.ucrChkPlotCountries.Name = "ucrChkPlotCountries"
        '
        'ucrChkPlotCoastLines
        '
        Me.ucrChkPlotCoastLines.Checked = False
        resources.ApplyResources(Me.ucrChkPlotCoastLines, "ucrChkPlotCoastLines")
        Me.ucrChkPlotCoastLines.Name = "ucrChkPlotCoastLines"
        '
        'ucrChkPlotHighResolution
        '
        Me.ucrChkPlotHighResolution.Checked = False
        resources.ApplyResources(Me.ucrChkPlotHighResolution, "ucrChkPlotHighResolution")
        Me.ucrChkPlotHighResolution.Name = "ucrChkPlotHighResolution"
        '
        'ucrButtonsSdgPlotRegion
        '
        resources.ApplyResources(Me.ucrButtonsSdgPlotRegion, "ucrButtonsSdgPlotRegion")
        Me.ucrButtonsSdgPlotRegion.Name = "ucrButtonsSdgPlotRegion"
        '
        'sdgPlotRegion
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbcPlotRegion)
        Me.Controls.Add(Me.ucrButtonsSdgPlotRegion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgPlotRegion"
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
    Friend WithEvents ucrChkPlotOwnLocations As ucrCheck
End Class
