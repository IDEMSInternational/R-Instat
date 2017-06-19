﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.lblRainfall = New System.Windows.Forms.Label()
        Me.grpConditionsForSatrtofRains = New System.Windows.Forms.GroupBox()
        Me.ucrChkNumberOfRainyDays = New instat.ucrCheck()
        Me.ucrChkTotalRainfall = New instat.ucrCheck()
        Me.pnlTotalRainfall = New System.Windows.Forms.Panel()
        Me.ucrNudTRAmount = New instat.ucrNud()
        Me.lblTROverDays = New System.Windows.Forms.Label()
        Me.ucrNudTROverDays = New instat.ucrNud()
        Me.ucrNudTRPercentile = New instat.ucrNud()
        Me.lblTRVal = New System.Windows.Forms.Label()
        Me.rdoTRPercentile = New System.Windows.Forms.RadioButton()
        Me.rdoTRAmount = New System.Windows.Forms.RadioButton()
        Me.pnlDrySpell = New System.Windows.Forms.Panel()
        Me.lblDSMaximumDays = New System.Windows.Forms.Label()
        Me.lblDSLengthofTime = New System.Windows.Forms.Label()
        Me.nudDSMaximumDays = New System.Windows.Forms.NumericUpDown()
        Me.pnlConsecutiveRainyDays = New System.Windows.Forms.Panel()
        Me.ucrNudRDMinimumDays = New instat.ucrNud()
        Me.ucrNudRDOutOfDays = New instat.ucrNud()
        Me.lblRDMinimum = New System.Windows.Forms.Label()
        Me.lblRDWidth = New System.Windows.Forms.Label()
        Me.pnlDryPeriod = New System.Windows.Forms.Panel()
        Me.lblDPMaxRain = New System.Windows.Forms.Label()
        Me.lblDPLength = New System.Windows.Forms.Label()
        Me.nudDPMaxRain = New System.Windows.Forms.NumericUpDown()
        Me.nudDPRainPeriod = New System.Windows.Forms.NumericUpDown()
        Me.nudDPOverallInterval = New System.Windows.Forms.NumericUpDown()
        Me.lblDPOverallInterval = New System.Windows.Forms.Label()
        Me.chkDryPeriod = New System.Windows.Forms.CheckBox()
        Me.chkDrySpell = New System.Windows.Forms.CheckBox()
        Me.ucrPnlTRCalculateBy = New instat.UcrPanel()
        Me.grpRainParameters = New System.Windows.Forms.GroupBox()
        Me.ucrNudThreshold = New instat.ucrNud()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
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
        Me.lblStation = New System.Windows.Forms.Label()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrNudDSLengthOfTime = New instat.ucrNud()
        Me.grpConditionsForSatrtofRains.SuspendLayout()
        Me.pnlTotalRainfall.SuspendLayout()
        Me.pnlDrySpell.SuspendLayout()
        CType(Me.nudDSMaximumDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConsecutiveRainyDays.SuspendLayout()
        Me.pnlDryPeriod.SuspendLayout()
        CType(Me.nudDPMaxRain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDPRainPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDPOverallInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRainParameters.SuspendLayout()
        Me.SuspendLayout()
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
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrChkNumberOfRainyDays)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrChkTotalRainfall)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.pnlTotalRainfall)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.pnlDrySpell)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.pnlConsecutiveRainyDays)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.pnlDryPeriod)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.chkDryPeriod)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.chkDrySpell)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrPnlTRCalculateBy)
        Me.grpConditionsForSatrtofRains.Location = New System.Drawing.Point(9, 238)
        Me.grpConditionsForSatrtofRains.Name = "grpConditionsForSatrtofRains"
        Me.grpConditionsForSatrtofRains.Size = New System.Drawing.Size(579, 160)
        Me.grpConditionsForSatrtofRains.TabIndex = 10
        Me.grpConditionsForSatrtofRains.TabStop = False
        Me.grpConditionsForSatrtofRains.Text = "Conditions for Start of Rains"
        '
        'ucrChkNumberOfRainyDays
        '
        Me.ucrChkNumberOfRainyDays.Checked = False
        Me.ucrChkNumberOfRainyDays.Location = New System.Drawing.Point(7, 69)
        Me.ucrChkNumberOfRainyDays.Name = "ucrChkNumberOfRainyDays"
        Me.ucrChkNumberOfRainyDays.Size = New System.Drawing.Size(131, 20)
        Me.ucrChkNumberOfRainyDays.TabIndex = 10
        '
        'ucrChkTotalRainfall
        '
        Me.ucrChkTotalRainfall.Checked = False
        Me.ucrChkTotalRainfall.Location = New System.Drawing.Point(7, 19)
        Me.ucrChkTotalRainfall.Name = "ucrChkTotalRainfall"
        Me.ucrChkTotalRainfall.Size = New System.Drawing.Size(131, 20)
        Me.ucrChkTotalRainfall.TabIndex = 8
        '
        'pnlTotalRainfall
        '
        Me.pnlTotalRainfall.Controls.Add(Me.ucrNudTRAmount)
        Me.pnlTotalRainfall.Controls.Add(Me.lblTROverDays)
        Me.pnlTotalRainfall.Controls.Add(Me.ucrNudTROverDays)
        Me.pnlTotalRainfall.Controls.Add(Me.ucrNudTRPercentile)
        Me.pnlTotalRainfall.Controls.Add(Me.lblTRVal)
        Me.pnlTotalRainfall.Controls.Add(Me.rdoTRPercentile)
        Me.pnlTotalRainfall.Controls.Add(Me.rdoTRAmount)
        Me.pnlTotalRainfall.Location = New System.Drawing.Point(144, 13)
        Me.pnlTotalRainfall.Name = "pnlTotalRainfall"
        Me.pnlTotalRainfall.Size = New System.Drawing.Size(398, 49)
        Me.pnlTotalRainfall.TabIndex = 3
        '
        'ucrNudTRAmount
        '
        Me.ucrNudTRAmount.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTRAmount.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTRAmount.Location = New System.Drawing.Point(342, 3)
        Me.ucrNudTRAmount.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTRAmount.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTRAmount.Name = "ucrNudTRAmount"
        Me.ucrNudTRAmount.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTRAmount.TabIndex = 8
        Me.ucrNudTRAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
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
        'ucrNudTROverDays
        '
        Me.ucrNudTROverDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTROverDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTROverDays.Location = New System.Drawing.Point(66, 1)
        Me.ucrNudTROverDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTROverDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTROverDays.Name = "ucrNudTROverDays"
        Me.ucrNudTROverDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTROverDays.TabIndex = 7
        Me.ucrNudTROverDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTRPercentile
        '
        Me.ucrNudTRPercentile.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTRPercentile.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTRPercentile.Location = New System.Drawing.Point(342, 26)
        Me.ucrNudTRPercentile.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTRPercentile.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTRPercentile.Name = "ucrNudTRPercentile"
        Me.ucrNudTRPercentile.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTRPercentile.TabIndex = 6
        Me.ucrNudTRPercentile.Value = New Decimal(New Integer() {0, 0, 0, 0})
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
        Me.pnlDrySpell.Controls.Add(Me.ucrNudDSLengthOfTime)
        Me.pnlDrySpell.Controls.Add(Me.lblDSMaximumDays)
        Me.pnlDrySpell.Controls.Add(Me.lblDSLengthofTime)
        Me.pnlDrySpell.Controls.Add(Me.nudDSMaximumDays)
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
        'pnlConsecutiveRainyDays
        '
        Me.pnlConsecutiveRainyDays.Controls.Add(Me.ucrNudRDMinimumDays)
        Me.pnlConsecutiveRainyDays.Controls.Add(Me.ucrNudRDOutOfDays)
        Me.pnlConsecutiveRainyDays.Controls.Add(Me.lblRDMinimum)
        Me.pnlConsecutiveRainyDays.Controls.Add(Me.lblRDWidth)
        Me.pnlConsecutiveRainyDays.Location = New System.Drawing.Point(144, 62)
        Me.pnlConsecutiveRainyDays.Name = "pnlConsecutiveRainyDays"
        Me.pnlConsecutiveRainyDays.Size = New System.Drawing.Size(258, 32)
        Me.pnlConsecutiveRainyDays.TabIndex = 1
        '
        'ucrNudRDMinimumDays
        '
        Me.ucrNudRDMinimumDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRDMinimumDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRDMinimumDays.Location = New System.Drawing.Point(61, 7)
        Me.ucrNudRDMinimumDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRDMinimumDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRDMinimumDays.Name = "ucrNudRDMinimumDays"
        Me.ucrNudRDMinimumDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudRDMinimumDays.TabIndex = 9
        Me.ucrNudRDMinimumDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudRDOutOfDays
        '
        Me.ucrNudRDOutOfDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRDOutOfDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRDOutOfDays.Location = New System.Drawing.Point(186, 7)
        Me.ucrNudRDOutOfDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRDOutOfDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRDOutOfDays.Name = "ucrNudRDOutOfDays"
        Me.ucrNudRDOutOfDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudRDOutOfDays.TabIndex = 10
        Me.ucrNudRDOutOfDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
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
        'ucrPnlTRCalculateBy
        '
        Me.ucrPnlTRCalculateBy.Location = New System.Drawing.Point(408, 13)
        Me.ucrPnlTRCalculateBy.Name = "ucrPnlTRCalculateBy"
        Me.ucrPnlTRCalculateBy.Size = New System.Drawing.Size(134, 49)
        Me.ucrPnlTRCalculateBy.TabIndex = 9
        '
        'grpRainParameters
        '
        Me.grpRainParameters.Controls.Add(Me.ucrNudThreshold)
        Me.grpRainParameters.Controls.Add(Me.ucrNudTo)
        Me.grpRainParameters.Controls.Add(Me.ucrNudFrom)
        Me.grpRainParameters.Controls.Add(Me.lblThreshold)
        Me.grpRainParameters.Controls.Add(Me.lblFrom)
        Me.grpRainParameters.Controls.Add(Me.lblTo)
        Me.grpRainParameters.Location = New System.Drawing.Point(9, 192)
        Me.grpRainParameters.Name = "grpRainParameters"
        Me.grpRainParameters.Size = New System.Drawing.Size(380, 40)
        Me.grpRainParameters.TabIndex = 9
        Me.grpRainParameters.TabStop = False
        '
        'ucrNudThreshold
        '
        Me.ucrNudThreshold.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudThreshold.Location = New System.Drawing.Point(69, 11)
        Me.ucrNudThreshold.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThreshold.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreshold.Name = "ucrNudThreshold"
        Me.ucrNudThreshold.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudThreshold.TabIndex = 10
        Me.ucrNudThreshold.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTo
        '
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTo.Location = New System.Drawing.Point(313, 11)
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTo.TabIndex = 9
        Me.ucrNudTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrom.Location = New System.Drawing.Point(188, 11)
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFrom.TabIndex = 8
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
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
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(149, 13)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 2
        Me.lblFrom.Text = "From:"
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
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 6
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(246, 43)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 2
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(246, 169)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.TabIndex = 8
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrReceiverRainfall
        '
        Me.ucrReceiverRainfall.frmParent = Me
        Me.ucrReceiverRainfall.Location = New System.Drawing.Point(246, 85)
        Me.ucrReceiverRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainfall.Name = "ucrReceiverRainfall"
        Me.ucrReceiverRainfall.Selector = Nothing
        Me.ucrReceiverRainfall.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverRainfall.strNcFilePath = ""
        Me.ucrReceiverRainfall.TabIndex = 4
        Me.ucrReceiverRainfall.ucrSelector = Nothing
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
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(419, 28)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 13
        Me.lblStation.Text = "Station:"
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(418, 43)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 14
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrNudDSLengthOfTime
        '
        Me.ucrNudDSLengthOfTime.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDSLengthOfTime.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDSLengthOfTime.Location = New System.Drawing.Point(291, 3)
        Me.ucrNudDSLengthOfTime.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDSLengthOfTime.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDSLengthOfTime.Name = "ucrNudDSLengthOfTime"
        Me.ucrNudDSLengthOfTime.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDSLengthOfTime.TabIndex = 11
        Me.ucrNudDSLengthOfTime.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgStartofRains
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 488)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
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
        Me.grpConditionsForSatrtofRains.ResumeLayout(False)
        Me.grpConditionsForSatrtofRains.PerformLayout()
        Me.pnlTotalRainfall.ResumeLayout(False)
        Me.pnlTotalRainfall.PerformLayout()
        Me.pnlDrySpell.ResumeLayout(False)
        Me.pnlDrySpell.PerformLayout()
        CType(Me.nudDSMaximumDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConsecutiveRainyDays.ResumeLayout(False)
        Me.pnlConsecutiveRainyDays.PerformLayout()
        Me.pnlDryPeriod.ResumeLayout(False)
        Me.pnlDryPeriod.PerformLayout()
        CType(Me.nudDPMaxRain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDPRainPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDPOverallInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRainParameters.ResumeLayout(False)
        Me.grpRainParameters.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForStartofRains As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRainfall As ucrReceiverSingle
    Friend WithEvents lblRainfall As Label
    Friend WithEvents grpConditionsForSatrtofRains As GroupBox
    Friend WithEvents nudDSMaximumDays As NumericUpDown
    Friend WithEvents lblDSLengthofTime As Label
    Friend WithEvents lblDSMaximumDays As Label
    Friend WithEvents lblTRVal As Label
    Friend WithEvents lblRDMinimum As Label
    Friend WithEvents chkDrySpell As CheckBox
    Friend WithEvents grpRainParameters As GroupBox
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents lblTROverDays As Label
    Friend WithEvents lblDOY As Label
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents lblRDWidth As Label
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
    Friend WithEvents pnlConsecutiveRainyDays As Panel
    Friend WithEvents pnlDryPeriod As Panel
    Friend WithEvents pnlDrySpell As Panel
    Friend WithEvents pnlTotalRainfall As Panel
    Friend WithEvents ucrSaveStartofRains As ucrSave
    Friend WithEvents ucrNudTROverDays As ucrNud
    Friend WithEvents ucrNudTRPercentile As ucrNud
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrNudTo As ucrNud
    Friend WithEvents ucrNudFrom As ucrNud
    Friend WithEvents ucrChkTotalRainfall As ucrCheck
    Friend WithEvents ucrNudTRAmount As ucrNud
    Friend WithEvents ucrPnlTRCalculateBy As UcrPanel
    Friend WithEvents ucrNudRDMinimumDays As ucrNud
    Friend WithEvents ucrNudRDOutOfDays As ucrNud
    Friend WithEvents ucrNudThreshold As ucrNud
    Friend WithEvents ucrChkNumberOfRainyDays As ucrCheck
    Friend WithEvents ucrNudDSLengthOfTime As ucrNud
End Class