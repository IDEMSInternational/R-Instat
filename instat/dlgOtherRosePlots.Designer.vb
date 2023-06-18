<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgOtherRosePlots
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
        Me.rdoPercentileRose = New System.Windows.Forms.RadioButton()
        Me.rdoPolarFrequency = New System.Windows.Forms.RadioButton()
        Me.rdoPolarAnnulus = New System.Windows.Forms.RadioButton()
        Me.rdoPolarPlot = New System.Windows.Forms.RadioButton()
        Me.rdoPolarCluster = New System.Windows.Forms.RadioButton()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblWindDirection = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblWindSpeed = New System.Windows.Forms.Label()
        Me.lblStatistic = New System.Windows.Forms.Label()
        Me.lblPollutant = New System.Windows.Forms.Label()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.lblNoOfClusters = New System.Windows.Forms.Label()
        Me.lblPercentile = New System.Windows.Forms.Label()
        Me.lblFacetTwo = New System.Windows.Forms.Label()
        Me.lblFacetOne = New System.Windows.Forms.Label()
        Me.ucrReceiverFacetOne = New instat.ucrReceiverSingle()
        Me.ucrReceiverFacetTwo = New instat.ucrReceiverSingle()
        Me.ucrNudPercentile = New instat.ucrNud()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrInputColor = New instat.ucrInputComboBox()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindDirection = New instat.ucrReceiverSingle()
        Me.ucrSelectorOtherRosePlots = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverPollutant = New instat.ucrReceiverSingle()
        Me.ucrChkForcePositive = New instat.ucrCheck()
        Me.ucrChkNormalise = New instat.ucrCheck()
        Me.ucrReceiverMultiplePollutants = New instat.ucrReceiverMultiple()
        Me.ucrReceiverWindSpeed = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrNudNmberOfClusters = New instat.ucrNud()
        Me.ucrInputMethod = New instat.ucrInputComboBox()
        Me.ucrInputStatistic = New instat.ucrInputComboBox()
        Me.ucrChkPadDate = New instat.ucrCheck()
        Me.ucrChkSmooth = New instat.ucrCheck()
        Me.ucrChkExcludeMissing = New instat.ucrCheck()
        Me.ucrChkTransform = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'rdoPercentileRose
        '
        Me.rdoPercentileRose.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPercentileRose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPercentileRose.FlatAppearance.BorderSize = 2
        Me.rdoPercentileRose.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPercentileRose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPercentileRose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPercentileRose.Location = New System.Drawing.Point(120, 12)
        Me.rdoPercentileRose.Name = "rdoPercentileRose"
        Me.rdoPercentileRose.Size = New System.Drawing.Size(96, 28)
        Me.rdoPercentileRose.TabIndex = 88
        Me.rdoPercentileRose.TabStop = True
        Me.rdoPercentileRose.Tag = ""
        Me.rdoPercentileRose.Text = "Percentile Rose"
        Me.rdoPercentileRose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPercentileRose.UseVisualStyleBackColor = True
        '
        'rdoPolarFrequency
        '
        Me.rdoPolarFrequency.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPolarFrequency.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPolarFrequency.FlatAppearance.BorderSize = 2
        Me.rdoPolarFrequency.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPolarFrequency.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPolarFrequency.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPolarFrequency.Location = New System.Drawing.Point(24, 12)
        Me.rdoPolarFrequency.Name = "rdoPolarFrequency"
        Me.rdoPolarFrequency.Size = New System.Drawing.Size(98, 28)
        Me.rdoPolarFrequency.TabIndex = 90
        Me.rdoPolarFrequency.TabStop = True
        Me.rdoPolarFrequency.Tag = ""
        Me.rdoPolarFrequency.Text = "Polar Frequency"
        Me.rdoPolarFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPolarFrequency.UseVisualStyleBackColor = True
        '
        'rdoPolarAnnulus
        '
        Me.rdoPolarAnnulus.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPolarAnnulus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPolarAnnulus.FlatAppearance.BorderSize = 2
        Me.rdoPolarAnnulus.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPolarAnnulus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPolarAnnulus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPolarAnnulus.Location = New System.Drawing.Point(311, 12)
        Me.rdoPolarAnnulus.Name = "rdoPolarAnnulus"
        Me.rdoPolarAnnulus.Size = New System.Drawing.Size(100, 28)
        Me.rdoPolarAnnulus.TabIndex = 91
        Me.rdoPolarAnnulus.TabStop = True
        Me.rdoPolarAnnulus.Tag = ""
        Me.rdoPolarAnnulus.Text = "Polar Annulus"
        Me.rdoPolarAnnulus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPolarAnnulus.UseVisualStyleBackColor = True
        '
        'rdoPolarPlot
        '
        Me.rdoPolarPlot.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPolarPlot.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPolarPlot.FlatAppearance.BorderSize = 2
        Me.rdoPolarPlot.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPolarPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPolarPlot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPolarPlot.Location = New System.Drawing.Point(214, 12)
        Me.rdoPolarPlot.Name = "rdoPolarPlot"
        Me.rdoPolarPlot.Size = New System.Drawing.Size(99, 28)
        Me.rdoPolarPlot.TabIndex = 92
        Me.rdoPolarPlot.TabStop = True
        Me.rdoPolarPlot.Tag = ""
        Me.rdoPolarPlot.Text = "Polar Plot"
        Me.rdoPolarPlot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPolarPlot.UseVisualStyleBackColor = True
        '
        'rdoPolarCluster
        '
        Me.rdoPolarCluster.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPolarCluster.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPolarCluster.FlatAppearance.BorderSize = 2
        Me.rdoPolarCluster.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPolarCluster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPolarCluster.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPolarCluster.Location = New System.Drawing.Point(408, 12)
        Me.rdoPolarCluster.Name = "rdoPolarCluster"
        Me.rdoPolarCluster.Size = New System.Drawing.Size(95, 28)
        Me.rdoPolarCluster.TabIndex = 89
        Me.rdoPolarCluster.TabStop = True
        Me.rdoPolarCluster.Tag = ""
        Me.rdoPolarCluster.Text = "Polar Cluster"
        Me.rdoPolarCluster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPolarCluster.UseVisualStyleBackColor = True
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(14, 284)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(34, 13)
        Me.lblColor.TabIndex = 17
        Me.lblColor.Text = "Color:"
        '
        'lblWindDirection
        '
        Me.lblWindDirection.AutoSize = True
        Me.lblWindDirection.Location = New System.Drawing.Point(259, 145)
        Me.lblWindDirection.Name = "lblWindDirection"
        Me.lblWindDirection.Size = New System.Drawing.Size(80, 13)
        Me.lblWindDirection.TabIndex = 7
        Me.lblWindDirection.Text = "Wind Direction:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(259, 57)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date:"
        '
        'lblWindSpeed
        '
        Me.lblWindSpeed.AutoSize = True
        Me.lblWindSpeed.Location = New System.Drawing.Point(260, 98)
        Me.lblWindSpeed.Name = "lblWindSpeed"
        Me.lblWindSpeed.Size = New System.Drawing.Size(69, 13)
        Me.lblWindSpeed.TabIndex = 5
        Me.lblWindSpeed.Text = "Wind Speed:"
        '
        'lblStatistic
        '
        Me.lblStatistic.AutoSize = True
        Me.lblStatistic.Location = New System.Drawing.Point(14, 254)
        Me.lblStatistic.Name = "lblStatistic"
        Me.lblStatistic.Size = New System.Drawing.Size(47, 13)
        Me.lblStatistic.TabIndex = 97
        Me.lblStatistic.Text = "Statistic:"
        '
        'lblPollutant
        '
        Me.lblPollutant.AutoSize = True
        Me.lblPollutant.Location = New System.Drawing.Point(259, 190)
        Me.lblPollutant.Name = "lblPollutant"
        Me.lblPollutant.Size = New System.Drawing.Size(51, 13)
        Me.lblPollutant.TabIndex = 9
        Me.lblPollutant.Text = "Pollutant:"
        '
        'lblMethod
        '
        Me.lblMethod.AutoSize = True
        Me.lblMethod.Location = New System.Drawing.Point(14, 255)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(46, 13)
        Me.lblMethod.TabIndex = 18
        Me.lblMethod.Text = "Method:"
        '
        'lblNoOfClusters
        '
        Me.lblNoOfClusters.AutoSize = True
        Me.lblNoOfClusters.Location = New System.Drawing.Point(11, 254)
        Me.lblNoOfClusters.Name = "lblNoOfClusters"
        Me.lblNoOfClusters.Size = New System.Drawing.Size(76, 13)
        Me.lblNoOfClusters.TabIndex = 94
        Me.lblNoOfClusters.Text = "No of Clusters:"
        '
        'lblPercentile
        '
        Me.lblPercentile.AutoSize = True
        Me.lblPercentile.Location = New System.Drawing.Point(14, 312)
        Me.lblPercentile.Name = "lblPercentile"
        Me.lblPercentile.Size = New System.Drawing.Size(57, 13)
        Me.lblPercentile.TabIndex = 23
        Me.lblPercentile.Text = "Percentile:"
        '
        'lblFacetTwo
        '
        Me.lblFacetTwo.AutoSize = True
        Me.lblFacetTwo.Location = New System.Drawing.Point(403, 99)
        Me.lblFacetTwo.Name = "lblFacetTwo"
        Me.lblFacetTwo.Size = New System.Drawing.Size(91, 13)
        Me.lblFacetTwo.TabIndex = 14
        Me.lblFacetTwo.Text = "Facet2 (Optional):"
        '
        'lblFacetOne
        '
        Me.lblFacetOne.AutoSize = True
        Me.lblFacetOne.Location = New System.Drawing.Point(403, 57)
        Me.lblFacetOne.Name = "lblFacetOne"
        Me.lblFacetOne.Size = New System.Drawing.Size(85, 13)
        Me.lblFacetOne.TabIndex = 12
        Me.lblFacetOne.Text = "Facet (Optional):"
        '
        'ucrReceiverFacetOne
        '
        Me.ucrReceiverFacetOne.AutoSize = True
        Me.ucrReceiverFacetOne.frmParent = Me
        Me.ucrReceiverFacetOne.Location = New System.Drawing.Point(403, 72)
        Me.ucrReceiverFacetOne.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacetOne.Name = "ucrReceiverFacetOne"
        Me.ucrReceiverFacetOne.Selector = Nothing
        Me.ucrReceiverFacetOne.Size = New System.Drawing.Size(110, 20)
        Me.ucrReceiverFacetOne.strNcFilePath = ""
        Me.ucrReceiverFacetOne.TabIndex = 13
        Me.ucrReceiverFacetOne.ucrSelector = Nothing
        '
        'ucrReceiverFacetTwo
        '
        Me.ucrReceiverFacetTwo.AutoSize = True
        Me.ucrReceiverFacetTwo.frmParent = Me
        Me.ucrReceiverFacetTwo.Location = New System.Drawing.Point(403, 113)
        Me.ucrReceiverFacetTwo.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacetTwo.Name = "ucrReceiverFacetTwo"
        Me.ucrReceiverFacetTwo.Selector = Nothing
        Me.ucrReceiverFacetTwo.Size = New System.Drawing.Size(110, 20)
        Me.ucrReceiverFacetTwo.strNcFilePath = ""
        Me.ucrReceiverFacetTwo.TabIndex = 15
        Me.ucrReceiverFacetTwo.ucrSelector = Nothing
        '
        'ucrNudPercentile
        '
        Me.ucrNudPercentile.AutoSize = True
        Me.ucrNudPercentile.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPercentile.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPercentile.Location = New System.Drawing.Point(85, 307)
        Me.ucrNudPercentile.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPercentile.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPercentile.Name = "ucrNudPercentile"
        Me.ucrNudPercentile.Size = New System.Drawing.Size(56, 20)
        Me.ucrNudPercentile.TabIndex = 22
        Me.ucrNudPercentile.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(14, 390)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(325, 34)
        Me.ucrSaveGraph.TabIndex = 26
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(17, 9)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(496, 33)
        Me.ucrPnlOptions.TabIndex = 86
        '
        'ucrInputColor
        '
        Me.ucrInputColor.AddQuotesIfUnrecognised = True
        Me.ucrInputColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputColor.GetSetSelectedIndex = -1
        Me.ucrInputColor.IsReadOnly = False
        Me.ucrInputColor.Location = New System.Drawing.Point(85, 279)
        Me.ucrInputColor.Name = "ucrInputColor"
        Me.ucrInputColor.Size = New System.Drawing.Size(97, 21)
        Me.ucrInputColor.TabIndex = 21
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(259, 72)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 2
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverWindDirection
        '
        Me.ucrReceiverWindDirection.AutoSize = True
        Me.ucrReceiverWindDirection.frmParent = Me
        Me.ucrReceiverWindDirection.Location = New System.Drawing.Point(259, 160)
        Me.ucrReceiverWindDirection.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection.Name = "ucrReceiverWindDirection"
        Me.ucrReceiverWindDirection.Selector = Nothing
        Me.ucrReceiverWindDirection.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindDirection.strNcFilePath = ""
        Me.ucrReceiverWindDirection.TabIndex = 8
        Me.ucrReceiverWindDirection.ucrSelector = Nothing
        '
        'ucrSelectorOtherRosePlots
        '
        Me.ucrSelectorOtherRosePlots.AutoSize = True
        Me.ucrSelectorOtherRosePlots.bDropUnusedFilterLevels = False
        Me.ucrSelectorOtherRosePlots.bShowHiddenColumns = False
        Me.ucrSelectorOtherRosePlots.bUseCurrentFilter = True
        Me.ucrSelectorOtherRosePlots.Location = New System.Drawing.Point(14, 55)
        Me.ucrSelectorOtherRosePlots.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOtherRosePlots.Name = "ucrSelectorOtherRosePlots"
        Me.ucrSelectorOtherRosePlots.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorOtherRosePlots.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 426)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 27
        '
        'ucrReceiverPollutant
        '
        Me.ucrReceiverPollutant.AutoSize = True
        Me.ucrReceiverPollutant.frmParent = Me
        Me.ucrReceiverPollutant.Location = New System.Drawing.Point(259, 205)
        Me.ucrReceiverPollutant.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPollutant.Name = "ucrReceiverPollutant"
        Me.ucrReceiverPollutant.Selector = Nothing
        Me.ucrReceiverPollutant.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPollutant.strNcFilePath = ""
        Me.ucrReceiverPollutant.TabIndex = 10
        Me.ucrReceiverPollutant.ucrSelector = Nothing
        '
        'ucrChkForcePositive
        '
        Me.ucrChkForcePositive.AutoSize = True
        Me.ucrChkForcePositive.Checked = False
        Me.ucrChkForcePositive.Location = New System.Drawing.Point(14, 362)
        Me.ucrChkForcePositive.Name = "ucrChkForcePositive"
        Me.ucrChkForcePositive.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkForcePositive.TabIndex = 25
        '
        'ucrChkNormalise
        '
        Me.ucrChkNormalise.AutoSize = True
        Me.ucrChkNormalise.Checked = False
        Me.ucrChkNormalise.Location = New System.Drawing.Point(14, 363)
        Me.ucrChkNormalise.Name = "ucrChkNormalise"
        Me.ucrChkNormalise.Size = New System.Drawing.Size(156, 23)
        Me.ucrChkNormalise.TabIndex = 85
        '
        'ucrReceiverMultiplePollutants
        '
        Me.ucrReceiverMultiplePollutants.AutoSize = True
        Me.ucrReceiverMultiplePollutants.frmParent = Me
        Me.ucrReceiverMultiplePollutants.Location = New System.Drawing.Point(259, 207)
        Me.ucrReceiverMultiplePollutants.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultiplePollutants.Name = "ucrReceiverMultiplePollutants"
        Me.ucrReceiverMultiplePollutants.Selector = Nothing
        Me.ucrReceiverMultiplePollutants.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultiplePollutants.strNcFilePath = ""
        Me.ucrReceiverMultiplePollutants.TabIndex = 11
        Me.ucrReceiverMultiplePollutants.ucrSelector = Nothing
        '
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.AutoSize = True
        Me.ucrReceiverWindSpeed.frmParent = Me
        Me.ucrReceiverWindSpeed.Location = New System.Drawing.Point(259, 113)
        Me.ucrReceiverWindSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindSpeed.strNcFilePath = ""
        Me.ucrReceiverWindSpeed.TabIndex = 6
        Me.ucrReceiverWindSpeed.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.AutoSize = True
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(259, 113)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 4
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrNudNmberOfClusters
        '
        Me.ucrNudNmberOfClusters.AutoSize = True
        Me.ucrNudNmberOfClusters.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNmberOfClusters.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNmberOfClusters.Location = New System.Drawing.Point(97, 250)
        Me.ucrNudNmberOfClusters.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNmberOfClusters.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNmberOfClusters.Name = "ucrNudNmberOfClusters"
        Me.ucrNudNmberOfClusters.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNmberOfClusters.TabIndex = 20
        Me.ucrNudNmberOfClusters.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputMethod
        '
        Me.ucrInputMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMethod.GetSetSelectedIndex = -1
        Me.ucrInputMethod.IsReadOnly = False
        Me.ucrInputMethod.Location = New System.Drawing.Point(83, 249)
        Me.ucrInputMethod.Name = "ucrInputMethod"
        Me.ucrInputMethod.Size = New System.Drawing.Size(97, 21)
        Me.ucrInputMethod.TabIndex = 19
        '
        'ucrInputStatistic
        '
        Me.ucrInputStatistic.AddQuotesIfUnrecognised = True
        Me.ucrInputStatistic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStatistic.GetSetSelectedIndex = -1
        Me.ucrInputStatistic.IsReadOnly = False
        Me.ucrInputStatistic.Location = New System.Drawing.Point(83, 249)
        Me.ucrInputStatistic.Name = "ucrInputStatistic"
        Me.ucrInputStatistic.Size = New System.Drawing.Size(97, 21)
        Me.ucrInputStatistic.TabIndex = 81
        '
        'ucrChkPadDate
        '
        Me.ucrChkPadDate.AutoSize = True
        Me.ucrChkPadDate.Checked = False
        Me.ucrChkPadDate.Location = New System.Drawing.Point(15, 307)
        Me.ucrChkPadDate.Name = "ucrChkPadDate"
        Me.ucrChkPadDate.Size = New System.Drawing.Size(130, 23)
        Me.ucrChkPadDate.TabIndex = 84
        '
        'ucrChkSmooth
        '
        Me.ucrChkSmooth.AutoSize = True
        Me.ucrChkSmooth.Checked = False
        Me.ucrChkSmooth.Location = New System.Drawing.Point(14, 337)
        Me.ucrChkSmooth.Name = "ucrChkSmooth"
        Me.ucrChkSmooth.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkSmooth.TabIndex = 103
        '
        'ucrChkExcludeMissing
        '
        Me.ucrChkExcludeMissing.AutoSize = True
        Me.ucrChkExcludeMissing.Checked = False
        Me.ucrChkExcludeMissing.Location = New System.Drawing.Point(14, 337)
        Me.ucrChkExcludeMissing.Name = "ucrChkExcludeMissing"
        Me.ucrChkExcludeMissing.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkExcludeMissing.TabIndex = 24
        '
        'ucrChkTransform
        '
        Me.ucrChkTransform.AutoSize = True
        Me.ucrChkTransform.Checked = False
        Me.ucrChkTransform.Location = New System.Drawing.Point(14, 337)
        Me.ucrChkTransform.Name = "ucrChkTransform"
        Me.ucrChkTransform.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkTransform.TabIndex = 87
        '
        'dlgOtherRosePlots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(527, 488)
        Me.Controls.Add(Me.lblFacetTwo)
        Me.Controls.Add(Me.lblFacetOne)
        Me.Controls.Add(Me.ucrReceiverFacetOne)
        Me.Controls.Add(Me.ucrReceiverFacetTwo)
        Me.Controls.Add(Me.ucrNudPercentile)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.rdoPercentileRose)
        Me.Controls.Add(Me.rdoPolarFrequency)
        Me.Controls.Add(Me.rdoPolarAnnulus)
        Me.Controls.Add(Me.rdoPolarPlot)
        Me.Controls.Add(Me.rdoPolarCluster)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrInputColor)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblWindDirection)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverWindDirection)
        Me.Controls.Add(Me.ucrSelectorOtherRosePlots)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblPollutant)
        Me.Controls.Add(Me.ucrReceiverPollutant)
        Me.Controls.Add(Me.lblNoOfClusters)
        Me.Controls.Add(Me.ucrChkForcePositive)
        Me.Controls.Add(Me.ucrChkNormalise)
        Me.Controls.Add(Me.lblPercentile)
        Me.Controls.Add(Me.ucrReceiverMultiplePollutants)
        Me.Controls.Add(Me.ucrReceiverWindSpeed)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.lblWindSpeed)
        Me.Controls.Add(Me.lblMethod)
        Me.Controls.Add(Me.lblStatistic)
        Me.Controls.Add(Me.ucrNudNmberOfClusters)
        Me.Controls.Add(Me.ucrInputMethod)
        Me.Controls.Add(Me.ucrInputStatistic)
        Me.Controls.Add(Me.ucrChkExcludeMissing)
        Me.Controls.Add(Me.ucrChkTransform)
        Me.Controls.Add(Me.ucrChkPadDate)
        Me.Controls.Add(Me.ucrChkSmooth)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOtherRosePlots"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Other Rose Plots"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrChkSmooth As ucrCheck
    Friend WithEvents ucrChkExcludeMissing As ucrCheck
    Friend WithEvents ucrNudPercentile As ucrNud
    Friend WithEvents ucrChkPadDate As ucrCheck
    Friend WithEvents ucrNudNmberOfClusters As ucrNud
    Friend WithEvents ucrChkTransform As ucrCheck
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents rdoPercentileRose As RadioButton
    Friend WithEvents rdoPolarFrequency As RadioButton
    Friend WithEvents rdoPolarAnnulus As RadioButton
    Friend WithEvents rdoPolarPlot As RadioButton
    Friend WithEvents rdoPolarCluster As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents ucrInputColor As ucrInputComboBox
    Friend WithEvents lblColor As Label
    Friend WithEvents lblWindDirection As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblWindSpeed As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverWindDirection As ucrReceiverSingle
    Friend WithEvents ucrSelectorOtherRosePlots As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblStatistic As Label
    Friend WithEvents lblPollutant As Label
    Friend WithEvents ucrReceiverPollutant As ucrReceiverSingle
    Friend WithEvents ucrInputMethod As ucrInputComboBox
    Friend WithEvents ucrInputStatistic As ucrInputComboBox
    Friend WithEvents lblMethod As Label
    Friend WithEvents lblNoOfClusters As Label
    Friend WithEvents ucrChkForcePositive As ucrCheck
    Friend WithEvents ucrChkNormalise As ucrCheck
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents lblPercentile As Label
    Friend WithEvents ucrReceiverMultiplePollutants As ucrReceiverMultiple
    Friend WithEvents ucrReceiverWindSpeed As ucrReceiverSingle
    Friend WithEvents lblFacetTwo As Label
    Friend WithEvents lblFacetOne As Label
    Friend WithEvents ucrReceiverFacetOne As ucrReceiverSingle
    Friend WithEvents ucrReceiverFacetTwo As ucrReceiverSingle
End Class
