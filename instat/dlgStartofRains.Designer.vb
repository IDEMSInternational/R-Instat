<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgStartofRains
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
        Me.nudAmount = New System.Windows.Forms.NumericUpDown()
        Me.nudMinimum = New System.Windows.Forms.NumericUpDown()
        Me.lblRainfall = New System.Windows.Forms.Label()
        Me.grpConditionsForSatrtofRains = New System.Windows.Forms.GroupBox()
        Me.pnlTotalRainfall = New System.Windows.Forms.Panel()
        Me.lblOverDays = New System.Windows.Forms.Label()
        Me.nudPercentile = New System.Windows.Forms.NumericUpDown()
        Me.lblVal = New System.Windows.Forms.Label()
        Me.nudOverDays = New System.Windows.Forms.NumericUpDown()
        Me.rdoPercentile = New System.Windows.Forms.RadioButton()
        Me.rdoAmount = New System.Windows.Forms.RadioButton()
        Me.pnlDrySpell = New System.Windows.Forms.Panel()
        Me.lblMaximumDays = New System.Windows.Forms.Label()
        Me.lblLengthofTime = New System.Windows.Forms.Label()
        Me.nudMaximumDays = New System.Windows.Forms.NumericUpDown()
        Me.nudLengthofTime = New System.Windows.Forms.NumericUpDown()
        Me.pnlConsecutiveRainyDays = New System.Windows.Forms.Panel()
        Me.lblMinimum = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.nudOutOfDays = New System.Windows.Forms.NumericUpDown()
        Me.pnlDryPeriod = New System.Windows.Forms.Panel()
        Me.lblDPMaxRain = New System.Windows.Forms.Label()
        Me.lblDPLength = New System.Windows.Forms.Label()
        Me.nudDPMaxRain = New System.Windows.Forms.NumericUpDown()
        Me.nudDPRainPeriod = New System.Windows.Forms.NumericUpDown()
        Me.nudDPOverallInterval = New System.Windows.Forms.NumericUpDown()
        Me.lblDPOverallInterval = New System.Windows.Forms.Label()
        Me.chkDryPeriod = New System.Windows.Forms.CheckBox()
        Me.chkDrySpell = New System.Windows.Forms.CheckBox()
        Me.chkTotalRainfall = New System.Windows.Forms.CheckBox()
        Me.chkConsecutiveRainyDays = New System.Windows.Forms.CheckBox()
        Me.grpRainParameters = New System.Windows.Forms.GroupBox()
        Me.nudThreshold = New System.Windows.Forms.NumericUpDown()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.nudFrom = New System.Windows.Forms.NumericUpDown()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.nudTo = New System.Windows.Forms.NumericUpDown()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblDOY = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverRainfall = New instat.ucrReceiverSingle()
        Me.ucrSelectorForStartofRains = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.nudAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinimum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConditionsForSatrtofRains.SuspendLayout()
        Me.pnlTotalRainfall.SuspendLayout()
        CType(Me.nudPercentile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudOverDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDrySpell.SuspendLayout()
        CType(Me.nudMaximumDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLengthofTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConsecutiveRainyDays.SuspendLayout()
        CType(Me.nudOutOfDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDryPeriod.SuspendLayout()
        CType(Me.nudDPMaxRain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDPRainPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDPOverallInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRainParameters.SuspendLayout()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudAmount
        '
        Me.nudAmount.Location = New System.Drawing.Point(342, 4)
        Me.nudAmount.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudAmount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudAmount.Name = "nudAmount"
        Me.nudAmount.Size = New System.Drawing.Size(52, 20)
        Me.nudAmount.TabIndex = 4
        Me.nudAmount.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'nudMinimum
        '
        Me.nudMinimum.Location = New System.Drawing.Point(64, 7)
        Me.nudMinimum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMinimum.Name = "nudMinimum"
        Me.nudMinimum.Size = New System.Drawing.Size(47, 20)
        Me.nudMinimum.TabIndex = 1
        Me.nudMinimum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblRainfall
        '
        Me.lblRainfall.AutoSize = True
        Me.lblRainfall.Location = New System.Drawing.Point(246, 70)
        Me.lblRainfall.Name = "lblRainfall"
        Me.lblRainfall.Size = New System.Drawing.Size(70, 13)
        Me.lblRainfall.TabIndex = 3
        Me.lblRainfall.Text = "Rain Column:"
        '
        'grpConditionsForSatrtofRains
        '
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.pnlTotalRainfall)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.pnlDrySpell)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.pnlConsecutiveRainyDays)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.pnlDryPeriod)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.chkDryPeriod)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.chkDrySpell)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.chkTotalRainfall)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.chkConsecutiveRainyDays)
        Me.grpConditionsForSatrtofRains.Location = New System.Drawing.Point(9, 238)
        Me.grpConditionsForSatrtofRains.Name = "grpConditionsForSatrtofRains"
        Me.grpConditionsForSatrtofRains.Size = New System.Drawing.Size(579, 160)
        Me.grpConditionsForSatrtofRains.TabIndex = 10
        Me.grpConditionsForSatrtofRains.TabStop = False
        Me.grpConditionsForSatrtofRains.Text = "Conditions for Start of Rains"
        '
        'pnlTotalRainfall
        '
        Me.pnlTotalRainfall.Controls.Add(Me.lblOverDays)
        Me.pnlTotalRainfall.Controls.Add(Me.nudAmount)
        Me.pnlTotalRainfall.Controls.Add(Me.nudPercentile)
        Me.pnlTotalRainfall.Controls.Add(Me.lblVal)
        Me.pnlTotalRainfall.Controls.Add(Me.nudOverDays)
        Me.pnlTotalRainfall.Controls.Add(Me.rdoPercentile)
        Me.pnlTotalRainfall.Controls.Add(Me.rdoAmount)
        Me.pnlTotalRainfall.Location = New System.Drawing.Point(145, 45)
        Me.pnlTotalRainfall.Name = "pnlTotalRainfall"
        Me.pnlTotalRainfall.Size = New System.Drawing.Size(398, 49)
        Me.pnlTotalRainfall.TabIndex = 3
        '
        'lblOverDays
        '
        Me.lblOverDays.AutoSize = True
        Me.lblOverDays.Location = New System.Drawing.Point(3, 4)
        Me.lblOverDays.Name = "lblOverDays"
        Me.lblOverDays.Size = New System.Drawing.Size(60, 13)
        Me.lblOverDays.TabIndex = 0
        Me.lblOverDays.Tag = ""
        Me.lblOverDays.Text = "Over Days:"
        '
        'nudPercentile
        '
        Me.nudPercentile.Location = New System.Drawing.Point(342, 25)
        Me.nudPercentile.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudPercentile.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPercentile.Name = "nudPercentile"
        Me.nudPercentile.Size = New System.Drawing.Size(52, 20)
        Me.nudPercentile.TabIndex = 6
        Me.nudPercentile.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'lblVal
        '
        Me.lblVal.AutoSize = True
        Me.lblVal.Location = New System.Drawing.Point(128, 6)
        Me.lblVal.Name = "lblVal"
        Me.lblVal.Size = New System.Drawing.Size(136, 13)
        Me.lblVal.TabIndex = 2
        Me.lblVal.Text = "Calculate Rainfall Value by:"
        '
        'nudOverDays
        '
        Me.nudOverDays.Location = New System.Drawing.Point(65, 1)
        Me.nudOverDays.Maximum = New Decimal(New Integer() {366, 0, 0, 0})
        Me.nudOverDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudOverDays.Name = "nudOverDays"
        Me.nudOverDays.Size = New System.Drawing.Size(46, 20)
        Me.nudOverDays.TabIndex = 1
        Me.nudOverDays.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rdoPercentile
        '
        Me.rdoPercentile.AutoSize = True
        Me.rdoPercentile.Location = New System.Drawing.Point(265, 25)
        Me.rdoPercentile.Name = "rdoPercentile"
        Me.rdoPercentile.Size = New System.Drawing.Size(72, 17)
        Me.rdoPercentile.TabIndex = 5
        Me.rdoPercentile.TabStop = True
        Me.rdoPercentile.Text = "Percentile"
        Me.rdoPercentile.UseVisualStyleBackColor = True
        '
        'rdoAmount
        '
        Me.rdoAmount.AutoSize = True
        Me.rdoAmount.Location = New System.Drawing.Point(265, 4)
        Me.rdoAmount.Name = "rdoAmount"
        Me.rdoAmount.Size = New System.Drawing.Size(61, 17)
        Me.rdoAmount.TabIndex = 3
        Me.rdoAmount.TabStop = True
        Me.rdoAmount.Text = "Amount"
        Me.rdoAmount.UseVisualStyleBackColor = True
        '
        'pnlDrySpell
        '
        Me.pnlDrySpell.Controls.Add(Me.lblMaximumDays)
        Me.pnlDrySpell.Controls.Add(Me.lblLengthofTime)
        Me.pnlDrySpell.Controls.Add(Me.nudMaximumDays)
        Me.pnlDrySpell.Controls.Add(Me.nudLengthofTime)
        Me.pnlDrySpell.Location = New System.Drawing.Point(96, 95)
        Me.pnlDrySpell.Name = "pnlDrySpell"
        Me.pnlDrySpell.Size = New System.Drawing.Size(302, 24)
        Me.pnlDrySpell.TabIndex = 5
        '
        'lblMaximumDays
        '
        Me.lblMaximumDays.AutoSize = True
        Me.lblMaximumDays.Location = New System.Drawing.Point(3, 5)
        Me.lblMaximumDays.Name = "lblMaximumDays"
        Me.lblMaximumDays.Size = New System.Drawing.Size(81, 13)
        Me.lblMaximumDays.TabIndex = 0
        Me.lblMaximumDays.Text = "Maximum Days:"
        '
        'lblLengthofTime
        '
        Me.lblLengthofTime.AutoSize = True
        Me.lblLengthofTime.Location = New System.Drawing.Point(159, 6)
        Me.lblLengthofTime.Name = "lblLengthofTime"
        Me.lblLengthofTime.Size = New System.Drawing.Size(81, 13)
        Me.lblLengthofTime.TabIndex = 2
        Me.lblLengthofTime.Text = "Length of Time:"
        '
        'nudMaximumDays
        '
        Me.nudMaximumDays.Location = New System.Drawing.Point(86, 2)
        Me.nudMaximumDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMaximumDays.Name = "nudMaximumDays"
        Me.nudMaximumDays.Size = New System.Drawing.Size(47, 20)
        Me.nudMaximumDays.TabIndex = 1
        Me.nudMaximumDays.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudLengthofTime
        '
        Me.nudLengthofTime.Location = New System.Drawing.Point(246, 2)
        Me.nudLengthofTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLengthofTime.Name = "nudLengthofTime"
        Me.nudLengthofTime.Size = New System.Drawing.Size(52, 20)
        Me.nudLengthofTime.TabIndex = 3
        Me.nudLengthofTime.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'pnlConsecutiveRainyDays
        '
        Me.pnlConsecutiveRainyDays.Controls.Add(Me.lblMinimum)
        Me.pnlConsecutiveRainyDays.Controls.Add(Me.nudMinimum)
        Me.pnlConsecutiveRainyDays.Controls.Add(Me.lblWidth)
        Me.pnlConsecutiveRainyDays.Controls.Add(Me.nudOutOfDays)
        Me.pnlConsecutiveRainyDays.Location = New System.Drawing.Point(145, 10)
        Me.pnlConsecutiveRainyDays.Name = "pnlConsecutiveRainyDays"
        Me.pnlConsecutiveRainyDays.Size = New System.Drawing.Size(258, 32)
        Me.pnlConsecutiveRainyDays.TabIndex = 1
        '
        'lblMinimum
        '
        Me.lblMinimum.AutoSize = True
        Me.lblMinimum.Location = New System.Drawing.Point(4, 11)
        Me.lblMinimum.Name = "lblMinimum"
        Me.lblMinimum.Size = New System.Drawing.Size(51, 13)
        Me.lblMinimum.TabIndex = 0
        Me.lblMinimum.Text = "Minimum:"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(120, 11)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblWidth.TabIndex = 2
        Me.lblWidth.Text = "Out of Days:"
        '
        'nudOutOfDays
        '
        Me.nudOutOfDays.Location = New System.Drawing.Point(196, 9)
        Me.nudOutOfDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudOutOfDays.Name = "nudOutOfDays"
        Me.nudOutOfDays.Size = New System.Drawing.Size(52, 20)
        Me.nudOutOfDays.TabIndex = 3
        Me.nudOutOfDays.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'pnlDryPeriod
        '
        Me.pnlDryPeriod.Controls.Add(Me.lblDPMaxRain)
        Me.pnlDryPeriod.Controls.Add(Me.lblDPLength)
        Me.pnlDryPeriod.Controls.Add(Me.nudDPMaxRain)
        Me.pnlDryPeriod.Controls.Add(Me.nudDPRainPeriod)
        Me.pnlDryPeriod.Controls.Add(Me.nudDPOverallInterval)
        Me.pnlDryPeriod.Controls.Add(Me.lblDPOverallInterval)
        Me.pnlDryPeriod.Location = New System.Drawing.Point(96, 120)
        Me.pnlDryPeriod.Name = "pnlDryPeriod"
        Me.pnlDryPeriod.Size = New System.Drawing.Size(480, 25)
        Me.pnlDryPeriod.TabIndex = 7
        '
        'lblDPMaxRain
        '
        Me.lblDPMaxRain.AutoSize = True
        Me.lblDPMaxRain.Location = New System.Drawing.Point(3, 6)
        Me.lblDPMaxRain.Name = "lblDPMaxRain"
        Me.lblDPMaxRain.Size = New System.Drawing.Size(79, 13)
        Me.lblDPMaxRain.TabIndex = 1
        Me.lblDPMaxRain.Text = "Maximum Rain:"
        '
        'lblDPLength
        '
        Me.lblDPLength.AutoSize = True
        Me.lblDPLength.Location = New System.Drawing.Point(139, 7)
        Me.lblDPLength.Name = "lblDPLength"
        Me.lblDPLength.Size = New System.Drawing.Size(101, 13)
        Me.lblDPLength.TabIndex = 3
        Me.lblDPLength.Text = "Rain Period Length:"
        '
        'nudDPMaxRain
        '
        Me.nudDPMaxRain.Location = New System.Drawing.Point(86, 3)
        Me.nudDPMaxRain.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDPMaxRain.Name = "nudDPMaxRain"
        Me.nudDPMaxRain.Size = New System.Drawing.Size(47, 20)
        Me.nudDPMaxRain.TabIndex = 2
        Me.nudDPMaxRain.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudDPRainPeriod
        '
        Me.nudDPRainPeriod.Location = New System.Drawing.Point(246, 3)
        Me.nudDPRainPeriod.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDPRainPeriod.Name = "nudDPRainPeriod"
        Me.nudDPRainPeriod.Size = New System.Drawing.Size(52, 20)
        Me.nudDPRainPeriod.TabIndex = 4
        Me.nudDPRainPeriod.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudDPOverallInterval
        '
        Me.nudDPOverallInterval.Location = New System.Drawing.Point(422, 4)
        Me.nudDPOverallInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDPOverallInterval.Name = "nudDPOverallInterval"
        Me.nudDPOverallInterval.Size = New System.Drawing.Size(52, 20)
        Me.nudDPOverallInterval.TabIndex = 0
        Me.nudDPOverallInterval.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblDPOverallInterval
        '
        Me.lblDPOverallInterval.AutoSize = True
        Me.lblDPOverallInterval.Location = New System.Drawing.Point(304, 7)
        Me.lblDPOverallInterval.Name = "lblDPOverallInterval"
        Me.lblDPOverallInterval.Size = New System.Drawing.Size(117, 13)
        Me.lblDPOverallInterval.TabIndex = 5
        Me.lblDPOverallInterval.Text = "Overall Interval Length:"
        '
        'chkDryPeriod
        '
        Me.chkDryPeriod.AutoSize = True
        Me.chkDryPeriod.Location = New System.Drawing.Point(7, 125)
        Me.chkDryPeriod.Name = "chkDryPeriod"
        Me.chkDryPeriod.Size = New System.Drawing.Size(75, 17)
        Me.chkDryPeriod.TabIndex = 6
        Me.chkDryPeriod.Text = "Dry Period"
        Me.chkDryPeriod.UseVisualStyleBackColor = True
        '
        'chkDrySpell
        '
        Me.chkDrySpell.AutoSize = True
        Me.chkDrySpell.Location = New System.Drawing.Point(7, 98)
        Me.chkDrySpell.Name = "chkDrySpell"
        Me.chkDrySpell.Size = New System.Drawing.Size(68, 17)
        Me.chkDrySpell.TabIndex = 4
        Me.chkDrySpell.Text = "Dry Spell"
        Me.chkDrySpell.UseVisualStyleBackColor = True
        '
        'chkTotalRainfall
        '
        Me.chkTotalRainfall.AutoSize = True
        Me.chkTotalRainfall.Location = New System.Drawing.Point(7, 45)
        Me.chkTotalRainfall.Name = "chkTotalRainfall"
        Me.chkTotalRainfall.Size = New System.Drawing.Size(88, 17)
        Me.chkTotalRainfall.TabIndex = 2
        Me.chkTotalRainfall.Text = "Total Rainfall"
        Me.chkTotalRainfall.UseVisualStyleBackColor = True
        '
        'chkConsecutiveRainyDays
        '
        Me.chkConsecutiveRainyDays.AutoSize = True
        Me.chkConsecutiveRainyDays.Location = New System.Drawing.Point(7, 20)
        Me.chkConsecutiveRainyDays.Name = "chkConsecutiveRainyDays"
        Me.chkConsecutiveRainyDays.Size = New System.Drawing.Size(142, 17)
        Me.chkConsecutiveRainyDays.TabIndex = 0
        Me.chkConsecutiveRainyDays.Text = "Consecutive Rainy Days"
        Me.chkConsecutiveRainyDays.UseVisualStyleBackColor = True
        '
        'grpRainParameters
        '
        Me.grpRainParameters.Controls.Add(Me.nudThreshold)
        Me.grpRainParameters.Controls.Add(Me.lblThreshold)
        Me.grpRainParameters.Controls.Add(Me.nudFrom)
        Me.grpRainParameters.Controls.Add(Me.lblFrom)
        Me.grpRainParameters.Controls.Add(Me.nudTo)
        Me.grpRainParameters.Controls.Add(Me.lblTo)
        Me.grpRainParameters.Location = New System.Drawing.Point(9, 192)
        Me.grpRainParameters.Name = "grpRainParameters"
        Me.grpRainParameters.Size = New System.Drawing.Size(380, 40)
        Me.grpRainParameters.TabIndex = 9
        Me.grpRainParameters.TabStop = False
        '
        'nudThreshold
        '
        Me.nudThreshold.DecimalPlaces = 2
        Me.nudThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudThreshold.Location = New System.Drawing.Point(66, 11)
        Me.nudThreshold.Name = "nudThreshold"
        Me.nudThreshold.Size = New System.Drawing.Size(53, 20)
        Me.nudThreshold.TabIndex = 1
        Me.nudThreshold.Value = New Decimal(New Integer() {85, 0, 0, 131072})
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(6, 13)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(57, 13)
        Me.lblThreshold.TabIndex = 0
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Threshold:"
        '
        'nudFrom
        '
        Me.nudFrom.Location = New System.Drawing.Point(188, 11)
        Me.nudFrom.Maximum = New Decimal(New Integer() {366, 0, 0, 0})
        Me.nudFrom.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudFrom.Name = "nudFrom"
        Me.nudFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.nudFrom.Size = New System.Drawing.Size(53, 20)
        Me.nudFrom.TabIndex = 3
        Me.nudFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudFrom.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nudFrom.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(149, 13)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 2
        Me.lblFrom.Text = "From:"
        '
        'nudTo
        '
        Me.nudTo.Location = New System.Drawing.Point(321, 10)
        Me.nudTo.Maximum = New Decimal(New Integer() {366, 0, 0, 0})
        Me.nudTo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudTo.Name = "nudTo"
        Me.nudTo.Size = New System.Drawing.Size(53, 20)
        Me.nudTo.TabIndex = 5
        Me.nudTo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(284, 13)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 4
        Me.lblTo.Tag = ""
        Me.lblTo.Text = "To:"
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.Location = New System.Drawing.Point(247, 154)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(66, 13)
        Me.lblDOY.TabIndex = 7
        Me.lblDOY.Text = "Day of Year:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(247, 28)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(248, 113)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 5
        Me.lblYear.Text = "Year:"
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(246, 128)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverYear.TabIndex = 6
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(246, 43)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDate.TabIndex = 2
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(246, 169)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDOY.TabIndex = 8
        '
        'ucrReceiverRainfall
        '
        Me.ucrReceiverRainfall.frmParent = Me
        Me.ucrReceiverRainfall.Location = New System.Drawing.Point(246, 85)
        Me.ucrReceiverRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainfall.Name = "ucrReceiverRainfall"
        Me.ucrReceiverRainfall.Selector = Nothing
        Me.ucrReceiverRainfall.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverRainfall.TabIndex = 4
        '
        'ucrSelectorForStartofRains
        '
        Me.ucrSelectorForStartofRains.bShowHiddenColumns = False
        Me.ucrSelectorForStartofRains.bUseCurrentFilter = True
        Me.ucrSelectorForStartofRains.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorForStartofRains.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForStartofRains.Name = "ucrSelectorForStartofRains"
        Me.ucrSelectorForStartofRains.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForStartofRains.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 404)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 11
        '
        'dlgStartofRains
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 459)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverDOY)
        Me.Controls.Add(Me.lblDOY)
        Me.Controls.Add(Me.grpRainParameters)
        Me.Controls.Add(Me.grpConditionsForSatrtofRains)
        Me.Controls.Add(Me.lblRainfall)
        Me.Controls.Add(Me.ucrReceiverRainfall)
        Me.Controls.Add(Me.ucrSelectorForStartofRains)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStartofRains"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start of Rains"
        CType(Me.nudAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinimum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConditionsForSatrtofRains.ResumeLayout(False)
        Me.grpConditionsForSatrtofRains.PerformLayout()
        Me.pnlTotalRainfall.ResumeLayout(False)
        Me.pnlTotalRainfall.PerformLayout()
        CType(Me.nudPercentile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudOverDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDrySpell.ResumeLayout(False)
        Me.pnlDrySpell.PerformLayout()
        CType(Me.nudMaximumDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLengthofTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConsecutiveRainyDays.ResumeLayout(False)
        Me.pnlConsecutiveRainyDays.PerformLayout()
        CType(Me.nudOutOfDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDryPeriod.ResumeLayout(False)
        Me.pnlDryPeriod.PerformLayout()
        CType(Me.nudDPMaxRain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDPRainPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDPOverallInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRainParameters.ResumeLayout(False)
        Me.grpRainParameters.PerformLayout()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents nudAmount As NumericUpDown
    Friend WithEvents nudMinimum As NumericUpDown
    Friend WithEvents ucrSelectorForStartofRains As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRainfall As ucrReceiverSingle
    Friend WithEvents lblRainfall As Label
    Friend WithEvents grpConditionsForSatrtofRains As GroupBox
    Friend WithEvents nudLengthofTime As NumericUpDown
    Friend WithEvents nudMaximumDays As NumericUpDown
    Friend WithEvents lblLengthofTime As Label
    Friend WithEvents lblMaximumDays As Label
    Friend WithEvents lblVal As Label
    Friend WithEvents lblMinimum As Label
    Friend WithEvents chkDrySpell As CheckBox
    Friend WithEvents chkTotalRainfall As CheckBox
    Friend WithEvents chkConsecutiveRainyDays As CheckBox
    Friend WithEvents grpRainParameters As GroupBox
    Friend WithEvents nudFrom As NumericUpDown
    Friend WithEvents lblFrom As Label
    Friend WithEvents nudOverDays As NumericUpDown
    Friend WithEvents nudTo As NumericUpDown
    Friend WithEvents lblTo As Label
    Friend WithEvents lblOverDays As Label
    Friend WithEvents lblDOY As Label
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents lblWidth As Label
    Friend WithEvents nudOutOfDays As NumericUpDown
    Friend WithEvents nudThreshold As NumericUpDown
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblYear As Label
    Friend WithEvents rdoPercentile As RadioButton
    Friend WithEvents rdoAmount As RadioButton
    Friend WithEvents nudDPOverallInterval As NumericUpDown
    Friend WithEvents lblDPOverallInterval As Label
    Friend WithEvents nudDPRainPeriod As NumericUpDown
    Friend WithEvents nudDPMaxRain As NumericUpDown
    Friend WithEvents lblDPLength As Label
    Friend WithEvents lblDPMaxRain As Label
    Friend WithEvents chkDryPeriod As CheckBox
    Friend WithEvents nudPercentile As NumericUpDown
    Friend WithEvents pnlConsecutiveRainyDays As Panel
    Friend WithEvents pnlDryPeriod As Panel
    Friend WithEvents pnlDrySpell As Panel
    Friend WithEvents pnlTotalRainfall As Panel
End Class