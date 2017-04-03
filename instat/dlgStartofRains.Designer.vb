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
        Me.nudTRAmount = New System.Windows.Forms.NumericUpDown()
        Me.nudRDMinimum = New System.Windows.Forms.NumericUpDown()
        Me.lblRainfall = New System.Windows.Forms.Label()
        Me.grpConditionsForSatrtofRains = New System.Windows.Forms.GroupBox()
        Me.pnlTotalRainfall = New System.Windows.Forms.Panel()
        Me.lblTROverDays = New System.Windows.Forms.Label()
        Me.nudTRPercentile = New System.Windows.Forms.NumericUpDown()
        Me.lblTRVal = New System.Windows.Forms.Label()
        Me.nudTROverDays = New System.Windows.Forms.NumericUpDown()
        Me.rdoTRPercentile = New System.Windows.Forms.RadioButton()
        Me.rdoTRAmount = New System.Windows.Forms.RadioButton()
        Me.pnlDrySpell = New System.Windows.Forms.Panel()
        Me.lblDSMaximumDays = New System.Windows.Forms.Label()
        Me.lblDSLengthofTime = New System.Windows.Forms.Label()
        Me.nudDSMaximumDays = New System.Windows.Forms.NumericUpDown()
        Me.nudDSLengthofTime = New System.Windows.Forms.NumericUpDown()
        Me.pnlConsecutiveRainyDays = New System.Windows.Forms.Panel()
        Me.lblRDMinimum = New System.Windows.Forms.Label()
        Me.lblRDWidth = New System.Windows.Forms.Label()
        Me.nudRDOutOfDays = New System.Windows.Forms.NumericUpDown()
        Me.pnlDryPeriod = New System.Windows.Forms.Panel()
        Me.lblDPMaxRain = New System.Windows.Forms.Label()
        Me.lblDPLength = New System.Windows.Forms.Label()
        Me.nudDPMaxRain = New System.Windows.Forms.NumericUpDown()
        Me.nudDPRainPeriod = New System.Windows.Forms.NumericUpDown()
        Me.nudDPOverallInterval = New System.Windows.Forms.NumericUpDown()
        Me.lblDPOverallInterval = New System.Windows.Forms.Label()
        Me.chkDryPeriod = New System.Windows.Forms.CheckBox()
        Me.chkDrySpell = New System.Windows.Forms.CheckBox()
        Me.chkConsecutiveRainyDays = New System.Windows.Forms.CheckBox()
        Me.chkTotalRainfall = New System.Windows.Forms.CheckBox()
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
        Me.ucrSaveStartofRains = New instat.ucrSave()
        CType(Me.nudTRAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRDMinimum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConditionsForSatrtofRains.SuspendLayout()
        Me.pnlTotalRainfall.SuspendLayout()
        CType(Me.nudTRPercentile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTROverDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDrySpell.SuspendLayout()
        CType(Me.nudDSMaximumDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDSLengthofTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConsecutiveRainyDays.SuspendLayout()
        CType(Me.nudRDOutOfDays, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'nudTRAmount
        '
        Me.nudTRAmount.Location = New System.Drawing.Point(342, 4)
        Me.nudTRAmount.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudTRAmount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudTRAmount.Name = "nudTRAmount"
        Me.nudTRAmount.Size = New System.Drawing.Size(52, 20)
        Me.nudTRAmount.TabIndex = 4
        Me.nudTRAmount.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'nudRDMinimum
        '
        Me.nudRDMinimum.Location = New System.Drawing.Point(64, 7)
        Me.nudRDMinimum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudRDMinimum.Name = "nudRDMinimum"
        Me.nudRDMinimum.Size = New System.Drawing.Size(47, 20)
        Me.nudRDMinimum.TabIndex = 1
        Me.nudRDMinimum.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.chkConsecutiveRainyDays)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.chkTotalRainfall)
        Me.grpConditionsForSatrtofRains.Location = New System.Drawing.Point(9, 238)
        Me.grpConditionsForSatrtofRains.Name = "grpConditionsForSatrtofRains"
        Me.grpConditionsForSatrtofRains.Size = New System.Drawing.Size(579, 160)
        Me.grpConditionsForSatrtofRains.TabIndex = 10
        Me.grpConditionsForSatrtofRains.TabStop = False
        Me.grpConditionsForSatrtofRains.Text = "Conditions for Start of Rains"
        '
        'pnlTotalRainfall
        '
        Me.pnlTotalRainfall.Controls.Add(Me.lblTROverDays)
        Me.pnlTotalRainfall.Controls.Add(Me.nudTRAmount)
        Me.pnlTotalRainfall.Controls.Add(Me.nudTRPercentile)
        Me.pnlTotalRainfall.Controls.Add(Me.lblTRVal)
        Me.pnlTotalRainfall.Controls.Add(Me.nudTROverDays)
        Me.pnlTotalRainfall.Controls.Add(Me.rdoTRPercentile)
        Me.pnlTotalRainfall.Controls.Add(Me.rdoTRAmount)
        Me.pnlTotalRainfall.Location = New System.Drawing.Point(144, 13)
        Me.pnlTotalRainfall.Name = "pnlTotalRainfall"
        Me.pnlTotalRainfall.Size = New System.Drawing.Size(398, 49)
        Me.pnlTotalRainfall.TabIndex = 3
        '
        'lblTROverDays
        '
        Me.lblTROverDays.AutoSize = True
        Me.lblTROverDays.Location = New System.Drawing.Point(3, 4)
        Me.lblTROverDays.Name = "lblTROverDays"
        Me.lblTROverDays.Size = New System.Drawing.Size(60, 13)
        Me.lblTROverDays.TabIndex = 0
        Me.lblTROverDays.Tag = ""
        Me.lblTROverDays.Text = "Over Days:"
        '
        'nudTRPercentile
        '
        Me.nudTRPercentile.Location = New System.Drawing.Point(342, 25)
        Me.nudTRPercentile.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudTRPercentile.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudTRPercentile.Name = "nudTRPercentile"
        Me.nudTRPercentile.Size = New System.Drawing.Size(52, 20)
        Me.nudTRPercentile.TabIndex = 6
        Me.nudTRPercentile.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'lblTRVal
        '
        Me.lblTRVal.AutoSize = True
        Me.lblTRVal.Location = New System.Drawing.Point(128, 6)
        Me.lblTRVal.Name = "lblTRVal"
        Me.lblTRVal.Size = New System.Drawing.Size(136, 13)
        Me.lblTRVal.TabIndex = 2
        Me.lblTRVal.Text = "Calculate Rainfall Value by:"
        '
        'nudTROverDays
        '
        Me.nudTROverDays.Location = New System.Drawing.Point(65, 2)
        Me.nudTROverDays.Maximum = New Decimal(New Integer() {366, 0, 0, 0})
        Me.nudTROverDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudTROverDays.Name = "nudTROverDays"
        Me.nudTROverDays.Size = New System.Drawing.Size(46, 20)
        Me.nudTROverDays.TabIndex = 1
        Me.nudTROverDays.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rdoTRPercentile
        '
        Me.rdoTRPercentile.AutoSize = True
        Me.rdoTRPercentile.Location = New System.Drawing.Point(265, 25)
        Me.rdoTRPercentile.Name = "rdoTRPercentile"
        Me.rdoTRPercentile.Size = New System.Drawing.Size(72, 17)
        Me.rdoTRPercentile.TabIndex = 5
        Me.rdoTRPercentile.TabStop = True
        Me.rdoTRPercentile.Text = "Percentile"
        Me.rdoTRPercentile.UseVisualStyleBackColor = True
        '
        'rdoTRAmount
        '
        Me.rdoTRAmount.AutoSize = True
        Me.rdoTRAmount.Location = New System.Drawing.Point(265, 4)
        Me.rdoTRAmount.Name = "rdoTRAmount"
        Me.rdoTRAmount.Size = New System.Drawing.Size(61, 17)
        Me.rdoTRAmount.TabIndex = 3
        Me.rdoTRAmount.TabStop = True
        Me.rdoTRAmount.Text = "Amount"
        Me.rdoTRAmount.UseVisualStyleBackColor = True
        '
        'pnlDrySpell
        '
        Me.pnlDrySpell.Controls.Add(Me.lblDSMaximumDays)
        Me.pnlDrySpell.Controls.Add(Me.lblDSLengthofTime)
        Me.pnlDrySpell.Controls.Add(Me.nudDSMaximumDays)
        Me.pnlDrySpell.Controls.Add(Me.nudDSLengthofTime)
        Me.pnlDrySpell.Location = New System.Drawing.Point(96, 95)
        Me.pnlDrySpell.Name = "pnlDrySpell"
        Me.pnlDrySpell.Size = New System.Drawing.Size(421, 24)
        Me.pnlDrySpell.TabIndex = 5
        '
        'lblDSMaximumDays
        '
        Me.lblDSMaximumDays.AutoSize = True
        Me.lblDSMaximumDays.Location = New System.Drawing.Point(3, 5)
        Me.lblDSMaximumDays.Name = "lblDSMaximumDays"
        Me.lblDSMaximumDays.Size = New System.Drawing.Size(100, 13)
        Me.lblDSMaximumDays.TabIndex = 0
        Me.lblDSMaximumDays.Text = "Maximum Dry Days:"
        '
        'lblDSLengthofTime
        '
        Me.lblDSLengthofTime.AutoSize = True
        Me.lblDSLengthofTime.Location = New System.Drawing.Point(168, 5)
        Me.lblDSLengthofTime.Name = "lblDSLengthofTime"
        Me.lblDSLengthofTime.Size = New System.Drawing.Size(117, 13)
        Me.lblDSLengthofTime.TabIndex = 2
        Me.lblDSLengthofTime.Text = "Overall Interval Length:"
        '
        'nudDSMaximumDays
        '
        Me.nudDSMaximumDays.Location = New System.Drawing.Point(113, 3)
        Me.nudDSMaximumDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDSMaximumDays.Name = "nudDSMaximumDays"
        Me.nudDSMaximumDays.Size = New System.Drawing.Size(47, 20)
        Me.nudDSMaximumDays.TabIndex = 1
        Me.nudDSMaximumDays.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudDSLengthofTime
        '
        Me.nudDSLengthofTime.Location = New System.Drawing.Point(289, 2)
        Me.nudDSLengthofTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDSLengthofTime.Name = "nudDSLengthofTime"
        Me.nudDSLengthofTime.Size = New System.Drawing.Size(52, 20)
        Me.nudDSLengthofTime.TabIndex = 3
        Me.nudDSLengthofTime.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'pnlConsecutiveRainyDays
        '
        Me.pnlConsecutiveRainyDays.Controls.Add(Me.lblRDMinimum)
        Me.pnlConsecutiveRainyDays.Controls.Add(Me.nudRDMinimum)
        Me.pnlConsecutiveRainyDays.Controls.Add(Me.lblRDWidth)
        Me.pnlConsecutiveRainyDays.Controls.Add(Me.nudRDOutOfDays)
        Me.pnlConsecutiveRainyDays.Location = New System.Drawing.Point(144, 62)
        Me.pnlConsecutiveRainyDays.Name = "pnlConsecutiveRainyDays"
        Me.pnlConsecutiveRainyDays.Size = New System.Drawing.Size(258, 32)
        Me.pnlConsecutiveRainyDays.TabIndex = 1
        '
        'lblRDMinimum
        '
        Me.lblRDMinimum.AutoSize = True
        Me.lblRDMinimum.Location = New System.Drawing.Point(4, 11)
        Me.lblRDMinimum.Name = "lblRDMinimum"
        Me.lblRDMinimum.Size = New System.Drawing.Size(51, 13)
        Me.lblRDMinimum.TabIndex = 0
        Me.lblRDMinimum.Text = "Minimum:"
        '
        'lblRDWidth
        '
        Me.lblRDWidth.AutoSize = True
        Me.lblRDWidth.Location = New System.Drawing.Point(120, 11)
        Me.lblRDWidth.Name = "lblRDWidth"
        Me.lblRDWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblRDWidth.TabIndex = 2
        Me.lblRDWidth.Text = "Out of Days:"
        '
        'nudRDOutOfDays
        '
        Me.nudRDOutOfDays.Location = New System.Drawing.Point(196, 9)
        Me.nudRDOutOfDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudRDOutOfDays.Name = "nudRDOutOfDays"
        Me.nudRDOutOfDays.Size = New System.Drawing.Size(52, 20)
        Me.nudRDOutOfDays.TabIndex = 3
        Me.nudRDOutOfDays.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        Me.lblDPLength.Size = New System.Drawing.Size(100, 13)
        Me.lblDPLength.TabIndex = 3
        Me.lblDPLength.Text = "Maximum Dry Days:"
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
        'chkConsecutiveRainyDays
        '
        Me.chkConsecutiveRainyDays.AutoSize = True
        Me.chkConsecutiveRainyDays.Location = New System.Drawing.Point(6, 72)
        Me.chkConsecutiveRainyDays.Name = "chkConsecutiveRainyDays"
        Me.chkConsecutiveRainyDays.Size = New System.Drawing.Size(132, 17)
        Me.chkConsecutiveRainyDays.TabIndex = 0
        Me.chkConsecutiveRainyDays.Text = "Number of Rainy Days"
        Me.chkConsecutiveRainyDays.UseVisualStyleBackColor = True
        '
        'chkTotalRainfall
        '
        Me.chkTotalRainfall.AutoSize = True
        Me.chkTotalRainfall.Location = New System.Drawing.Point(9, 19)
        Me.chkTotalRainfall.Name = "chkTotalRainfall"
        Me.chkTotalRainfall.Size = New System.Drawing.Size(88, 17)
        Me.chkTotalRainfall.TabIndex = 2
        Me.chkTotalRainfall.Text = "Total Rainfall"
        Me.chkTotalRainfall.UseVisualStyleBackColor = True
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
        Me.ucrBase.Location = New System.Drawing.Point(9, 434)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 11
        '
        'ucrSaveStartofRains
        '
        Me.ucrSaveStartofRains.Location = New System.Drawing.Point(9, 404)
        Me.ucrSaveStartofRains.Name = "ucrSaveStartofRains"
        Me.ucrSaveStartofRains.Size = New System.Drawing.Size(316, 24)
        Me.ucrSaveStartofRains.TabIndex = 12
        '
        'dlgStartofRains
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 488)
        Me.Controls.Add(Me.ucrSaveStartofRains)
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
        CType(Me.nudTRAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRDMinimum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConditionsForSatrtofRains.ResumeLayout(False)
        Me.grpConditionsForSatrtofRains.PerformLayout()
        Me.pnlTotalRainfall.ResumeLayout(False)
        Me.pnlTotalRainfall.PerformLayout()
        CType(Me.nudTRPercentile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTROverDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDrySpell.ResumeLayout(False)
        Me.pnlDrySpell.PerformLayout()
        CType(Me.nudDSMaximumDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDSLengthofTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConsecutiveRainyDays.ResumeLayout(False)
        Me.pnlConsecutiveRainyDays.PerformLayout()
        CType(Me.nudRDOutOfDays, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents nudTRAmount As NumericUpDown
    Friend WithEvents nudRDMinimum As NumericUpDown
    Friend WithEvents ucrSelectorForStartofRains As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRainfall As ucrReceiverSingle
    Friend WithEvents lblRainfall As Label
    Friend WithEvents grpConditionsForSatrtofRains As GroupBox
    Friend WithEvents nudDSLengthofTime As NumericUpDown
    Friend WithEvents nudDSMaximumDays As NumericUpDown
    Friend WithEvents lblDSLengthofTime As Label
    Friend WithEvents lblDSMaximumDays As Label
    Friend WithEvents lblTRVal As Label
    Friend WithEvents lblRDMinimum As Label
    Friend WithEvents chkDrySpell As CheckBox
    Friend WithEvents chkTotalRainfall As CheckBox
    Friend WithEvents chkConsecutiveRainyDays As CheckBox
    Friend WithEvents grpRainParameters As GroupBox
    Friend WithEvents nudFrom As NumericUpDown
    Friend WithEvents lblFrom As Label
    Friend WithEvents nudTROverDays As NumericUpDown
    Friend WithEvents nudTo As NumericUpDown
    Friend WithEvents lblTo As Label
    Friend WithEvents lblTROverDays As Label
    Friend WithEvents lblDOY As Label
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents lblRDWidth As Label
    Friend WithEvents nudRDOutOfDays As NumericUpDown
    Friend WithEvents nudThreshold As NumericUpDown
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblYear As Label
    Friend WithEvents rdoTRPercentile As RadioButton
    Friend WithEvents rdoTRAmount As RadioButton
    Friend WithEvents nudDPOverallInterval As NumericUpDown
    Friend WithEvents lblDPOverallInterval As Label
    Friend WithEvents nudDPRainPeriod As NumericUpDown
    Friend WithEvents nudDPMaxRain As NumericUpDown
    Friend WithEvents lblDPLength As Label
    Friend WithEvents lblDPMaxRain As Label
    Friend WithEvents chkDryPeriod As CheckBox
    Friend WithEvents nudTRPercentile As NumericUpDown
    Friend WithEvents pnlConsecutiveRainyDays As Panel
    Friend WithEvents pnlDryPeriod As Panel
    Friend WithEvents pnlDrySpell As Panel
    Friend WithEvents pnlTotalRainfall As Panel
    Friend WithEvents ucrSaveStartofRains As ucrSave
End Class