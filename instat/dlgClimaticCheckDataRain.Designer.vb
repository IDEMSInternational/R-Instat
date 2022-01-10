<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimaticCheckDataRain
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
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblmm = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblRainDays = New System.Windows.Forms.Label()
        Me.lblSkewnessWeight = New System.Windows.Forms.Label()
        Me.grpLogicalCalculatedColumns = New System.Windows.Forms.GroupBox()
        Me.ucrChkLogicalColumns = New instat.ucrCheck()
        Me.ucrChkCalculatedColumns = New instat.ucrCheck()
        Me.lblCoeff = New System.Windows.Forms.Label()
        Me.cmdOmitMonths = New System.Windows.Forms.Button()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.lblMissingThreshold = New System.Windows.Forms.Label()
        Me.lblThresholdmm = New System.Windows.Forms.Label()
        Me.lblGreater = New System.Windows.Forms.Label()
        Me.ucrInputSameValue = New instat.ucrInputTextBox()
        Me.ucrInputThreshold = New instat.ucrInputTextBox()
        Me.ucrInputThresholdValue = New instat.ucrInputTextBox()
        Me.ucrNudCoeff = New instat.ucrNud()
        Me.ucrChkOmitZero = New instat.ucrCheck()
        Me.ucrNudSkewnessWeight = New instat.ucrNud()
        Me.ucrNudWetDays = New instat.ucrNud()
        Me.ucrNudSame = New instat.ucrNud()
        Me.ucrNudLarge = New instat.ucrNud()
        Me.ucrChkOutlier = New instat.ucrCheck()
        Me.ucrChkDryMonth = New instat.ucrCheck()
        Me.ucrChkWetDays = New instat.ucrCheck()
        Me.ucrChkSame = New instat.ucrCheck()
        Me.ucrChkLarge = New instat.ucrCheck()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrReceiverDay = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorRain = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpLogicalCalculatedColumns.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(267, 22)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 1
        Me.lblStation.Text = "Station:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(267, 66)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYear.Location = New System.Drawing.Point(267, 110)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 5
        Me.lblYear.Text = "Year:"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDay.Location = New System.Drawing.Point(267, 198)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(29, 13)
        Me.lblDay.TabIndex = 9
        Me.lblDay.Text = "Day:"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMonth.Location = New System.Drawing.Point(267, 154)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 7
        Me.lblMonth.Text = "Month:"
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElement.Location = New System.Drawing.Point(267, 242)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(48, 13)
        Me.lblElement.TabIndex = 11
        Me.lblElement.Text = "Element:"
        '
        'lblmm
        '
        Me.lblmm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblmm.Location = New System.Drawing.Point(159, 207)
        Me.lblmm.Name = "lblmm"
        Me.lblmm.Size = New System.Drawing.Size(96, 27)
        Me.lblmm.TabIndex = 15
        Me.lblmm.Text = "mm(Large or negative Value)"
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDays.Location = New System.Drawing.Point(159, 246)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(29, 13)
        Me.lblDays.TabIndex = 18
        Me.lblDays.Text = "days"
        '
        'lblRainDays
        '
        Me.lblRainDays.AutoSize = True
        Me.lblRainDays.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRainDays.Location = New System.Drawing.Point(159, 274)
        Me.lblRainDays.Name = "lblRainDays"
        Me.lblRainDays.Size = New System.Drawing.Size(49, 13)
        Me.lblRainDays.TabIndex = 23
        Me.lblRainDays.Text = "rain days"
        '
        'lblSkewnessWeight
        '
        Me.lblSkewnessWeight.AutoSize = True
        Me.lblSkewnessWeight.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSkewnessWeight.Location = New System.Drawing.Point(235, 333)
        Me.lblSkewnessWeight.Name = "lblSkewnessWeight"
        Me.lblSkewnessWeight.Size = New System.Drawing.Size(96, 13)
        Me.lblSkewnessWeight.TabIndex = 31
        Me.lblSkewnessWeight.Text = "Skewness Weight:"
        '
        'grpLogicalCalculatedColumns
        '
        Me.grpLogicalCalculatedColumns.Controls.Add(Me.ucrChkLogicalColumns)
        Me.grpLogicalCalculatedColumns.Controls.Add(Me.ucrChkCalculatedColumns)
        Me.grpLogicalCalculatedColumns.Location = New System.Drawing.Point(6, 385)
        Me.grpLogicalCalculatedColumns.Name = "grpLogicalCalculatedColumns"
        Me.grpLogicalCalculatedColumns.Size = New System.Drawing.Size(399, 55)
        Me.grpLogicalCalculatedColumns.TabIndex = 37
        Me.grpLogicalCalculatedColumns.TabStop = False
        Me.grpLogicalCalculatedColumns.Text = "Include in Original Data"
        '
        'ucrChkLogicalColumns
        '
        Me.ucrChkLogicalColumns.AutoSize = True
        Me.ucrChkLogicalColumns.Checked = False
        Me.ucrChkLogicalColumns.Location = New System.Drawing.Point(6, 21)
        Me.ucrChkLogicalColumns.Name = "ucrChkLogicalColumns"
        Me.ucrChkLogicalColumns.Size = New System.Drawing.Size(185, 23)
        Me.ucrChkLogicalColumns.TabIndex = 0
        '
        'ucrChkCalculatedColumns
        '
        Me.ucrChkCalculatedColumns.AutoSize = True
        Me.ucrChkCalculatedColumns.Checked = False
        Me.ucrChkCalculatedColumns.Location = New System.Drawing.Point(227, 21)
        Me.ucrChkCalculatedColumns.Name = "ucrChkCalculatedColumns"
        Me.ucrChkCalculatedColumns.Size = New System.Drawing.Size(154, 23)
        Me.ucrChkCalculatedColumns.TabIndex = 1
        '
        'lblCoeff
        '
        Me.lblCoeff.AutoSize = True
        Me.lblCoeff.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCoeff.Location = New System.Drawing.Point(296, 363)
        Me.lblCoeff.Name = "lblCoeff"
        Me.lblCoeff.Size = New System.Drawing.Size(35, 13)
        Me.lblCoeff.TabIndex = 35
        Me.lblCoeff.Text = "Coeff:"
        '
        'cmdOmitMonths
        '
        Me.cmdOmitMonths.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOmitMonths.Location = New System.Drawing.Point(345, 299)
        Me.cmdOmitMonths.Name = "cmdOmitMonths"
        Me.cmdOmitMonths.Size = New System.Drawing.Size(75, 23)
        Me.cmdOmitMonths.TabIndex = 28
        Me.cmdOmitMonths.Text = "Omit Months"
        Me.cmdOmitMonths.UseVisualStyleBackColor = True
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblThreshold.Location = New System.Drawing.Point(56, 363)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(57, 13)
        Me.lblThreshold.TabIndex = 33
        Me.lblThreshold.Text = "Threshold:"
        '
        'lblMissingThreshold
        '
        Me.lblMissingThreshold.AutoSize = True
        Me.lblMissingThreshold.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMissingThreshold.Location = New System.Drawing.Point(79, 304)
        Me.lblMissingThreshold.Name = "lblMissingThreshold"
        Me.lblMissingThreshold.Size = New System.Drawing.Size(125, 13)
        Me.lblMissingThreshold.TabIndex = 25
        Me.lblMissingThreshold.Text = "Monthly rainfall less than:"
        '
        'lblThresholdmm
        '
        Me.lblThresholdmm.AutoSize = True
        Me.lblThresholdmm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblThresholdmm.Location = New System.Drawing.Point(320, 304)
        Me.lblThresholdmm.Name = "lblThresholdmm"
        Me.lblThresholdmm.Size = New System.Drawing.Size(23, 13)
        Me.lblThresholdmm.TabIndex = 27
        Me.lblThresholdmm.Text = "mm"
        '
        'lblGreater
        '
        Me.lblGreater.AutoSize = True
        Me.lblGreater.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblGreater.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGreater.Location = New System.Drawing.Point(186, 244)
        Me.lblGreater.Name = "lblGreater"
        Me.lblGreater.Size = New System.Drawing.Size(18, 20)
        Me.lblGreater.TabIndex = 19
        Me.lblGreater.Text = ">"
        '
        'ucrInputSameValue
        '
        Me.ucrInputSameValue.AddQuotesIfUnrecognised = True
        Me.ucrInputSameValue.AutoSize = True
        Me.ucrInputSameValue.IsMultiline = False
        Me.ucrInputSameValue.IsReadOnly = False
        Me.ucrInputSameValue.Location = New System.Drawing.Point(207, 243)
        Me.ucrInputSameValue.Name = "ucrInputSameValue"
        Me.ucrInputSameValue.Size = New System.Drawing.Size(40, 20)
        Me.ucrInputSameValue.TabIndex = 20
        '
        'ucrInputThreshold
        '
        Me.ucrInputThreshold.AddQuotesIfUnrecognised = True
        Me.ucrInputThreshold.AutoSize = True
        Me.ucrInputThreshold.IsMultiline = False
        Me.ucrInputThreshold.IsReadOnly = False
        Me.ucrInputThreshold.Location = New System.Drawing.Point(274, 300)
        Me.ucrInputThreshold.Name = "ucrInputThreshold"
        Me.ucrInputThreshold.Size = New System.Drawing.Size(46, 21)
        Me.ucrInputThreshold.TabIndex = 26
        '
        'ucrInputThresholdValue
        '
        Me.ucrInputThresholdValue.AddQuotesIfUnrecognised = True
        Me.ucrInputThresholdValue.AutoSize = True
        Me.ucrInputThresholdValue.IsMultiline = False
        Me.ucrInputThresholdValue.IsReadOnly = False
        Me.ucrInputThresholdValue.Location = New System.Drawing.Point(116, 359)
        Me.ucrInputThresholdValue.Name = "ucrInputThresholdValue"
        Me.ucrInputThresholdValue.Size = New System.Drawing.Size(54, 21)
        Me.ucrInputThresholdValue.TabIndex = 34
        '
        'ucrNudCoeff
        '
        Me.ucrNudCoeff.AutoSize = True
        Me.ucrNudCoeff.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCoeff.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCoeff.Location = New System.Drawing.Point(334, 358)
        Me.ucrNudCoeff.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCoeff.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCoeff.Name = "ucrNudCoeff"
        Me.ucrNudCoeff.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCoeff.TabIndex = 36
        Me.ucrNudCoeff.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkOmitZero
        '
        Me.ucrChkOmitZero.AutoSize = True
        Me.ucrChkOmitZero.Checked = False
        Me.ucrChkOmitZero.Location = New System.Drawing.Point(108, 332)
        Me.ucrChkOmitZero.Name = "ucrChkOmitZero"
        Me.ucrChkOmitZero.Size = New System.Drawing.Size(113, 23)
        Me.ucrChkOmitZero.TabIndex = 30
        '
        'ucrNudSkewnessWeight
        '
        Me.ucrNudSkewnessWeight.AutoSize = True
        Me.ucrNudSkewnessWeight.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSkewnessWeight.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSkewnessWeight.Location = New System.Drawing.Point(334, 332)
        Me.ucrNudSkewnessWeight.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSkewnessWeight.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSkewnessWeight.Name = "ucrNudSkewnessWeight"
        Me.ucrNudSkewnessWeight.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSkewnessWeight.TabIndex = 32
        Me.ucrNudSkewnessWeight.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudWetDays
        '
        Me.ucrNudWetDays.AutoSize = True
        Me.ucrNudWetDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWetDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWetDays.Location = New System.Drawing.Point(106, 271)
        Me.ucrNudWetDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWetDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWetDays.Name = "ucrNudWetDays"
        Me.ucrNudWetDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWetDays.TabIndex = 22
        Me.ucrNudWetDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSame
        '
        Me.ucrNudSame.AutoSize = True
        Me.ucrNudSame.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSame.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSame.Location = New System.Drawing.Point(106, 242)
        Me.ucrNudSame.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSame.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSame.Name = "ucrNudSame"
        Me.ucrNudSame.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSame.TabIndex = 17
        Me.ucrNudSame.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLarge
        '
        Me.ucrNudLarge.AutoSize = True
        Me.ucrNudLarge.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLarge.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLarge.Location = New System.Drawing.Point(106, 213)
        Me.ucrNudLarge.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLarge.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLarge.Name = "ucrNudLarge"
        Me.ucrNudLarge.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLarge.TabIndex = 14
        Me.ucrNudLarge.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkOutlier
        '
        Me.ucrChkOutlier.AutoSize = True
        Me.ucrChkOutlier.Checked = False
        Me.ucrChkOutlier.Location = New System.Drawing.Point(6, 332)
        Me.ucrChkOutlier.Name = "ucrChkOutlier"
        Me.ucrChkOutlier.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkOutlier.TabIndex = 29
        '
        'ucrChkDryMonth
        '
        Me.ucrChkDryMonth.AutoSize = True
        Me.ucrChkDryMonth.Checked = False
        Me.ucrChkDryMonth.Location = New System.Drawing.Point(6, 301)
        Me.ucrChkDryMonth.Name = "ucrChkDryMonth"
        Me.ucrChkDryMonth.Size = New System.Drawing.Size(92, 23)
        Me.ucrChkDryMonth.TabIndex = 24
        '
        'ucrChkWetDays
        '
        Me.ucrChkWetDays.AutoSize = True
        Me.ucrChkWetDays.Checked = False
        Me.ucrChkWetDays.Location = New System.Drawing.Point(6, 271)
        Me.ucrChkWetDays.Name = "ucrChkWetDays"
        Me.ucrChkWetDays.Size = New System.Drawing.Size(92, 23)
        Me.ucrChkWetDays.TabIndex = 21
        '
        'ucrChkSame
        '
        Me.ucrChkSame.AutoSize = True
        Me.ucrChkSame.Checked = False
        Me.ucrChkSame.Location = New System.Drawing.Point(6, 242)
        Me.ucrChkSame.Name = "ucrChkSame"
        Me.ucrChkSame.Size = New System.Drawing.Size(92, 23)
        Me.ucrChkSame.TabIndex = 16
        '
        'ucrChkLarge
        '
        Me.ucrChkLarge.AutoSize = True
        Me.ucrChkLarge.Checked = False
        Me.ucrChkLarge.Location = New System.Drawing.Point(6, 213)
        Me.ucrChkLarge.Name = "ucrChkLarge"
        Me.ucrChkLarge.Size = New System.Drawing.Size(75, 23)
        Me.ucrChkLarge.TabIndex = 13
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.AutoSize = True
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(270, 167)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 8
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.AutoSize = True
        Me.ucrReceiverElement.frmParent = Me
        Me.ucrReceiverElement.Location = New System.Drawing.Point(270, 255)
        Me.ucrReceiverElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.TabIndex = 12
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrReceiverDay
        '
        Me.ucrReceiverDay.AutoSize = True
        Me.ucrReceiverDay.frmParent = Me
        Me.ucrReceiverDay.Location = New System.Drawing.Point(270, 211)
        Me.ucrReceiverDay.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDay.Name = "ucrReceiverDay"
        Me.ucrReceiverDay.Selector = Nothing
        Me.ucrReceiverDay.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDay.strNcFilePath = ""
        Me.ucrReceiverDay.TabIndex = 10
        Me.ucrReceiverDay.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(270, 123)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 6
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(270, 79)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 4
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(270, 35)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 2
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorRain
        '
        Me.ucrSelectorRain.AutoSize = True
        Me.ucrSelectorRain.bDropUnusedFilterLevels = False
        Me.ucrSelectorRain.bShowHiddenColumns = False
        Me.ucrSelectorRain.bUseCurrentFilter = True
        Me.ucrSelectorRain.Location = New System.Drawing.Point(6, 16)
        Me.ucrSelectorRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorRain.Name = "ucrSelectorRain"
        Me.ucrSelectorRain.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorRain.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(6, 449)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 38
        '
        'dlgClimaticCheckDataRain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(424, 504)
        Me.Controls.Add(Me.ucrInputSameValue)
        Me.Controls.Add(Me.lblGreater)
        Me.Controls.Add(Me.lblThresholdmm)
        Me.Controls.Add(Me.ucrInputThreshold)
        Me.Controls.Add(Me.lblMissingThreshold)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.ucrInputThresholdValue)
        Me.Controls.Add(Me.cmdOmitMonths)
        Me.Controls.Add(Me.lblCoeff)
        Me.Controls.Add(Me.ucrNudCoeff)
        Me.Controls.Add(Me.ucrChkOmitZero)
        Me.Controls.Add(Me.lblSkewnessWeight)
        Me.Controls.Add(Me.ucrNudSkewnessWeight)
        Me.Controls.Add(Me.lblRainDays)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lblmm)
        Me.Controls.Add(Me.ucrNudWetDays)
        Me.Controls.Add(Me.ucrNudSame)
        Me.Controls.Add(Me.ucrNudLarge)
        Me.Controls.Add(Me.ucrChkOutlier)
        Me.Controls.Add(Me.ucrChkDryMonth)
        Me.Controls.Add(Me.ucrChkWetDays)
        Me.Controls.Add(Me.ucrChkSame)
        Me.Controls.Add(Me.ucrChkLarge)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.ucrReceiverDay)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrSelectorRain)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpLogicalCalculatedColumns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticCheckDataRain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Climatic Check Data Rainfall"
        Me.grpLogicalCalculatedColumns.ResumeLayout(False)
        Me.grpLogicalCalculatedColumns.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorRain As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrChkOutlier As ucrCheck
    Friend WithEvents ucrChkDryMonth As ucrCheck
    Friend WithEvents ucrChkWetDays As ucrCheck
    Friend WithEvents ucrChkSame As ucrCheck
    Friend WithEvents ucrChkLarge As ucrCheck
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents ucrReceiverDay As ucrReceiverSingle
    Friend WithEvents lblMonth As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblElement As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrNudLarge As ucrNud
    Friend WithEvents ucrNudWetDays As ucrNud
    Friend WithEvents ucrNudSame As ucrNud
    Friend WithEvents lblmm As Label
    Friend WithEvents lblDays As Label
    Friend WithEvents lblRainDays As Label
    Friend WithEvents lblSkewnessWeight As Label
    Friend WithEvents ucrNudSkewnessWeight As ucrNud
    Friend WithEvents ucrChkCalculatedColumns As ucrCheck
    Friend WithEvents ucrChkLogicalColumns As ucrCheck
    Friend WithEvents grpLogicalCalculatedColumns As GroupBox
    Friend WithEvents ucrChkOmitZero As ucrCheck
    Friend WithEvents lblCoeff As Label
    Friend WithEvents ucrNudCoeff As ucrNud
    Friend WithEvents cmdOmitMonths As Button
    Friend WithEvents ucrInputThresholdValue As ucrInputTextBox
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblMissingThreshold As Label
    Friend WithEvents ucrInputThreshold As ucrInputTextBox
    Friend WithEvents lblThresholdmm As Label
    Friend WithEvents lblGreater As Label
    Friend WithEvents ucrInputSameValue As ucrInputTextBox
End Class
