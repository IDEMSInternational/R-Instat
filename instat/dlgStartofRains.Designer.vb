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
        Me.grpConditionsForSatrtofRains = New System.Windows.Forms.GroupBox()
        Me.ucrNudDPOverallInterval = New instat.ucrNud()
        Me.ucrNudDSMaximumDays = New instat.ucrNud()
        Me.ucrNudDSLengthOfTime = New instat.ucrNud()
        Me.lblDPOverallInterval = New System.Windows.Forms.Label()
        Me.ucrNudRDMinimumDays = New instat.ucrNud()
        Me.ucrNudDPRainPeriod = New instat.ucrNud()
        Me.lblDPLength = New System.Windows.Forms.Label()
        Me.ucrChkDryPeriod = New instat.ucrCheck()
        Me.lblDSLengthofTime = New System.Windows.Forms.Label()
        Me.lblDPMaxRain = New System.Windows.Forms.Label()
        Me.ucrNudRDOutOfDays = New instat.ucrNud()
        Me.ucrNudDPMaxRain = New instat.ucrNud()
        Me.ucrChkDrySpell = New instat.ucrCheck()
        Me.lblDSMaximumDays = New System.Windows.Forms.Label()
        Me.lblRDMinimum = New System.Windows.Forms.Label()
        Me.lblTROverDays = New System.Windows.Forms.Label()
        Me.lblRDWidth = New System.Windows.Forms.Label()
        Me.ucrChkNumberOfRainyDays = New instat.ucrCheck()
        Me.ucrNudTROverDays = New instat.ucrNud()
        Me.ucrNudTRAmount = New instat.ucrNud()
        Me.lblTRVal = New System.Windows.Forms.Label()
        Me.ucrChkTotalRainfall = New instat.ucrCheck()
        Me.ucrNudTRPercentile = New instat.ucrNud()
        Me.rdoTRAmount = New System.Windows.Forms.RadioButton()
        Me.rdoTRPercentile = New System.Windows.Forms.RadioButton()
        Me.ucrPnlTRCalculateBy = New instat.UcrPanel()
        Me.grpRainParameters = New System.Windows.Forms.GroupBox()
        Me.ucrInputFilterPreview = New instat.ucrInputTextBox()
        Me.cmdDoyRange = New System.Windows.Forms.Button()
        Me.ucrNudThreshold = New instat.ucrNud()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.lblDOY = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblRainfall = New System.Windows.Forms.Label()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.ucrInputNewStatusColumnName = New instat.ucrInputTextBox()
        Me.ucrChkAsDate = New instat.ucrCheck()
        Me.ucrChkStatus = New instat.ucrCheck()
        Me.ucrInputNewDateColumnName = New instat.ucrInputTextBox()
        Me.ucrChkAsDoy = New instat.ucrCheck()
        Me.ucrInputNewDoyColumnName = New instat.ucrInputTextBox()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverRainfall = New instat.ucrReceiverSingle()
        Me.ucrSelectorForStartofRains = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpConditionsForSatrtofRains.SuspendLayout()
        Me.grpRainParameters.SuspendLayout()
        Me.grpDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpConditionsForSatrtofRains
        '
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrNudDPOverallInterval)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrNudDSMaximumDays)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrNudDSLengthOfTime)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.lblDPOverallInterval)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrNudRDMinimumDays)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrNudDPRainPeriod)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.lblDPLength)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrChkDryPeriod)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.lblDSLengthofTime)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.lblDPMaxRain)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrNudRDOutOfDays)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrNudDPMaxRain)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrChkDrySpell)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.lblDSMaximumDays)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.lblRDMinimum)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.lblTROverDays)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.lblRDWidth)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrChkNumberOfRainyDays)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrNudTROverDays)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrNudTRAmount)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.lblTRVal)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrChkTotalRainfall)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrNudTRPercentile)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.rdoTRAmount)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.rdoTRPercentile)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrPnlTRCalculateBy)
        Me.grpConditionsForSatrtofRains.Location = New System.Drawing.Point(4, 284)
        Me.grpConditionsForSatrtofRains.Name = "grpConditionsForSatrtofRains"
        Me.grpConditionsForSatrtofRains.Size = New System.Drawing.Size(686, 174)
        Me.grpConditionsForSatrtofRains.TabIndex = 12
        Me.grpConditionsForSatrtofRains.TabStop = False
        Me.grpConditionsForSatrtofRains.Text = "Conditions for Start of Rains"
        '
        'ucrNudDPOverallInterval
        '
        Me.ucrNudDPOverallInterval.AutoSize = True
        Me.ucrNudDPOverallInterval.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDPOverallInterval.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDPOverallInterval.Location = New System.Drawing.Point(641, 145)
        Me.ucrNudDPOverallInterval.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDPOverallInterval.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDPOverallInterval.Name = "ucrNudDPOverallInterval"
        Me.ucrNudDPOverallInterval.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudDPOverallInterval.TabIndex = 25
        Me.ucrNudDPOverallInterval.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDSMaximumDays
        '
        Me.ucrNudDSMaximumDays.AutoSize = True
        Me.ucrNudDSMaximumDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDSMaximumDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDSMaximumDays.Location = New System.Drawing.Point(255, 112)
        Me.ucrNudDSMaximumDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDSMaximumDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDSMaximumDays.Name = "ucrNudDSMaximumDays"
        Me.ucrNudDSMaximumDays.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudDSMaximumDays.TabIndex = 16
        Me.ucrNudDSMaximumDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDSLengthOfTime
        '
        Me.ucrNudDSLengthOfTime.AutoSize = True
        Me.ucrNudDSLengthOfTime.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDSLengthOfTime.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDSLengthOfTime.Location = New System.Drawing.Point(459, 112)
        Me.ucrNudDSLengthOfTime.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDSLengthOfTime.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDSLengthOfTime.Name = "ucrNudDSLengthOfTime"
        Me.ucrNudDSLengthOfTime.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudDSLengthOfTime.TabIndex = 18
        Me.ucrNudDSLengthOfTime.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblDPOverallInterval
        '
        Me.lblDPOverallInterval.AutoSize = True
        Me.lblDPOverallInterval.Location = New System.Drawing.Point(505, 147)
        Me.lblDPOverallInterval.Name = "lblDPOverallInterval"
        Me.lblDPOverallInterval.Size = New System.Drawing.Size(117, 13)
        Me.lblDPOverallInterval.TabIndex = 24
        Me.lblDPOverallInterval.Text = "Overall Interval Length:"
        '
        'ucrNudRDMinimumDays
        '
        Me.ucrNudRDMinimumDays.AutoSize = True
        Me.ucrNudRDMinimumDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRDMinimumDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRDMinimumDays.Location = New System.Drawing.Point(255, 79)
        Me.ucrNudRDMinimumDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRDMinimumDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRDMinimumDays.Name = "ucrNudRDMinimumDays"
        Me.ucrNudRDMinimumDays.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudRDMinimumDays.TabIndex = 11
        Me.ucrNudRDMinimumDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDPRainPeriod
        '
        Me.ucrNudDPRainPeriod.AutoSize = True
        Me.ucrNudDPRainPeriod.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDPRainPeriod.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDPRainPeriod.Location = New System.Drawing.Point(459, 145)
        Me.ucrNudDPRainPeriod.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDPRainPeriod.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDPRainPeriod.Name = "ucrNudDPRainPeriod"
        Me.ucrNudDPRainPeriod.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudDPRainPeriod.TabIndex = 23
        Me.ucrNudDPRainPeriod.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblDPLength
        '
        Me.lblDPLength.AutoSize = True
        Me.lblDPLength.Location = New System.Drawing.Point(301, 147)
        Me.lblDPLength.Name = "lblDPLength"
        Me.lblDPLength.Size = New System.Drawing.Size(100, 13)
        Me.lblDPLength.TabIndex = 22
        Me.lblDPLength.Text = "Maximum Dry Days:"
        '
        'ucrChkDryPeriod
        '
        Me.ucrChkDryPeriod.AutoSize = True
        Me.ucrChkDryPeriod.Checked = False
        Me.ucrChkDryPeriod.Location = New System.Drawing.Point(4, 145)
        Me.ucrChkDryPeriod.Name = "ucrChkDryPeriod"
        Me.ucrChkDryPeriod.Size = New System.Drawing.Size(94, 23)
        Me.ucrChkDryPeriod.TabIndex = 19
        '
        'lblDSLengthofTime
        '
        Me.lblDSLengthofTime.AutoSize = True
        Me.lblDSLengthofTime.Location = New System.Drawing.Point(301, 116)
        Me.lblDSLengthofTime.Name = "lblDSLengthofTime"
        Me.lblDSLengthofTime.Size = New System.Drawing.Size(117, 13)
        Me.lblDSLengthofTime.TabIndex = 17
        Me.lblDSLengthofTime.Text = "Overall Interval Length:"
        '
        'lblDPMaxRain
        '
        Me.lblDPMaxRain.AutoSize = True
        Me.lblDPMaxRain.Location = New System.Drawing.Point(118, 147)
        Me.lblDPMaxRain.Name = "lblDPMaxRain"
        Me.lblDPMaxRain.Size = New System.Drawing.Size(79, 13)
        Me.lblDPMaxRain.TabIndex = 20
        Me.lblDPMaxRain.Text = "Maximum Rain:"
        '
        'ucrNudRDOutOfDays
        '
        Me.ucrNudRDOutOfDays.AutoSize = True
        Me.ucrNudRDOutOfDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRDOutOfDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRDOutOfDays.Location = New System.Drawing.Point(459, 79)
        Me.ucrNudRDOutOfDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRDOutOfDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRDOutOfDays.Name = "ucrNudRDOutOfDays"
        Me.ucrNudRDOutOfDays.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudRDOutOfDays.TabIndex = 13
        Me.ucrNudRDOutOfDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDPMaxRain
        '
        Me.ucrNudDPMaxRain.AutoSize = True
        Me.ucrNudDPMaxRain.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDPMaxRain.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDPMaxRain.Location = New System.Drawing.Point(255, 145)
        Me.ucrNudDPMaxRain.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDPMaxRain.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDPMaxRain.Name = "ucrNudDPMaxRain"
        Me.ucrNudDPMaxRain.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudDPMaxRain.TabIndex = 21
        Me.ucrNudDPMaxRain.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkDrySpell
        '
        Me.ucrChkDrySpell.AutoSize = True
        Me.ucrChkDrySpell.Checked = False
        Me.ucrChkDrySpell.Location = New System.Drawing.Point(4, 112)
        Me.ucrChkDrySpell.Name = "ucrChkDrySpell"
        Me.ucrChkDrySpell.Size = New System.Drawing.Size(94, 23)
        Me.ucrChkDrySpell.TabIndex = 14
        '
        'lblDSMaximumDays
        '
        Me.lblDSMaximumDays.AutoSize = True
        Me.lblDSMaximumDays.Location = New System.Drawing.Point(97, 116)
        Me.lblDSMaximumDays.Name = "lblDSMaximumDays"
        Me.lblDSMaximumDays.Size = New System.Drawing.Size(100, 13)
        Me.lblDSMaximumDays.TabIndex = 15
        Me.lblDSMaximumDays.Text = "Maximum Dry Days:"
        '
        'lblRDMinimum
        '
        Me.lblRDMinimum.AutoSize = True
        Me.lblRDMinimum.Location = New System.Drawing.Point(146, 82)
        Me.lblRDMinimum.Name = "lblRDMinimum"
        Me.lblRDMinimum.Size = New System.Drawing.Size(51, 13)
        Me.lblRDMinimum.TabIndex = 10
        Me.lblRDMinimum.Text = "Minimum:"
        '
        'lblTROverDays
        '
        Me.lblTROverDays.AutoSize = True
        Me.lblTROverDays.Location = New System.Drawing.Point(144, 26)
        Me.lblTROverDays.Name = "lblTROverDays"
        Me.lblTROverDays.Size = New System.Drawing.Size(60, 13)
        Me.lblTROverDays.TabIndex = 1
        Me.lblTROverDays.Tag = ""
        Me.lblTROverDays.Text = "Over Days:"
        '
        'lblRDWidth
        '
        Me.lblRDWidth.AutoSize = True
        Me.lblRDWidth.Location = New System.Drawing.Point(353, 82)
        Me.lblRDWidth.Name = "lblRDWidth"
        Me.lblRDWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblRDWidth.TabIndex = 12
        Me.lblRDWidth.Text = "Out of Days:"
        '
        'ucrChkNumberOfRainyDays
        '
        Me.ucrChkNumberOfRainyDays.AutoSize = True
        Me.ucrChkNumberOfRainyDays.Checked = False
        Me.ucrChkNumberOfRainyDays.Location = New System.Drawing.Point(4, 79)
        Me.ucrChkNumberOfRainyDays.Name = "ucrChkNumberOfRainyDays"
        Me.ucrChkNumberOfRainyDays.Size = New System.Drawing.Size(143, 23)
        Me.ucrChkNumberOfRainyDays.TabIndex = 9
        '
        'ucrNudTROverDays
        '
        Me.ucrNudTROverDays.AutoSize = True
        Me.ucrNudTROverDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTROverDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTROverDays.Location = New System.Drawing.Point(235, 22)
        Me.ucrNudTROverDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTROverDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTROverDays.Name = "ucrNudTROverDays"
        Me.ucrNudTROverDays.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudTROverDays.TabIndex = 2
        Me.ucrNudTROverDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTRAmount
        '
        Me.ucrNudTRAmount.AutoSize = True
        Me.ucrNudTRAmount.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTRAmount.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTRAmount.Location = New System.Drawing.Point(569, 22)
        Me.ucrNudTRAmount.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTRAmount.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTRAmount.Name = "ucrNudTRAmount"
        Me.ucrNudTRAmount.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudTRAmount.TabIndex = 6
        Me.ucrNudTRAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblTRVal
        '
        Me.lblTRVal.AutoSize = True
        Me.lblTRVal.Location = New System.Drawing.Point(276, 26)
        Me.lblTRVal.Name = "lblTRVal"
        Me.lblTRVal.Size = New System.Drawing.Size(136, 13)
        Me.lblTRVal.TabIndex = 3
        Me.lblTRVal.Text = "Calculate Rainfall Value by:"
        '
        'ucrChkTotalRainfall
        '
        Me.ucrChkTotalRainfall.AutoSize = True
        Me.ucrChkTotalRainfall.Checked = False
        Me.ucrChkTotalRainfall.Location = New System.Drawing.Point(4, 22)
        Me.ucrChkTotalRainfall.Name = "ucrChkTotalRainfall"
        Me.ucrChkTotalRainfall.Size = New System.Drawing.Size(131, 23)
        Me.ucrChkTotalRainfall.TabIndex = 0
        '
        'ucrNudTRPercentile
        '
        Me.ucrNudTRPercentile.AutoSize = True
        Me.ucrNudTRPercentile.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTRPercentile.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTRPercentile.Location = New System.Drawing.Point(569, 48)
        Me.ucrNudTRPercentile.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTRPercentile.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTRPercentile.Name = "ucrNudTRPercentile"
        Me.ucrNudTRPercentile.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudTRPercentile.TabIndex = 8
        Me.ucrNudTRPercentile.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoTRAmount
        '
        Me.rdoTRAmount.AutoSize = True
        Me.rdoTRAmount.Location = New System.Drawing.Point(479, 24)
        Me.rdoTRAmount.Name = "rdoTRAmount"
        Me.rdoTRAmount.Size = New System.Drawing.Size(61, 17)
        Me.rdoTRAmount.TabIndex = 5
        Me.rdoTRAmount.TabStop = True
        Me.rdoTRAmount.Text = "Amount"
        Me.rdoTRAmount.UseVisualStyleBackColor = True
        '
        'rdoTRPercentile
        '
        Me.rdoTRPercentile.AutoSize = True
        Me.rdoTRPercentile.Location = New System.Drawing.Point(479, 48)
        Me.rdoTRPercentile.Name = "rdoTRPercentile"
        Me.rdoTRPercentile.Size = New System.Drawing.Size(72, 17)
        Me.rdoTRPercentile.TabIndex = 7
        Me.rdoTRPercentile.TabStop = True
        Me.rdoTRPercentile.Text = "Percentile"
        Me.rdoTRPercentile.UseVisualStyleBackColor = True
        '
        'ucrPnlTRCalculateBy
        '
        Me.ucrPnlTRCalculateBy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlTRCalculateBy.Location = New System.Drawing.Point(476, 17)
        Me.ucrPnlTRCalculateBy.Name = "ucrPnlTRCalculateBy"
        Me.ucrPnlTRCalculateBy.Size = New System.Drawing.Size(146, 62)
        Me.ucrPnlTRCalculateBy.TabIndex = 4
        '
        'grpRainParameters
        '
        Me.grpRainParameters.Controls.Add(Me.ucrInputFilterPreview)
        Me.grpRainParameters.Controls.Add(Me.cmdDoyRange)
        Me.grpRainParameters.Controls.Add(Me.ucrNudThreshold)
        Me.grpRainParameters.Controls.Add(Me.lblThreshold)
        Me.grpRainParameters.Location = New System.Drawing.Point(4, 238)
        Me.grpRainParameters.Name = "grpRainParameters"
        Me.grpRainParameters.Size = New System.Drawing.Size(686, 40)
        Me.grpRainParameters.TabIndex = 11
        Me.grpRainParameters.TabStop = False
        '
        'ucrInputFilterPreview
        '
        Me.ucrInputFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterPreview.AutoSize = True
        Me.ucrInputFilterPreview.IsMultiline = False
        Me.ucrInputFilterPreview.IsReadOnly = True
        Me.ucrInputFilterPreview.Location = New System.Drawing.Point(277, 13)
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        Me.ucrInputFilterPreview.Size = New System.Drawing.Size(242, 22)
        Me.ucrInputFilterPreview.TabIndex = 3
        '
        'cmdDoyRange
        '
        Me.cmdDoyRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDoyRange.Location = New System.Drawing.Point(159, 10)
        Me.cmdDoyRange.Name = "cmdDoyRange"
        Me.cmdDoyRange.Size = New System.Drawing.Size(105, 26)
        Me.cmdDoyRange.TabIndex = 2
        Me.cmdDoyRange.Tag = ""
        Me.cmdDoyRange.Text = "Day Range"
        Me.cmdDoyRange.UseVisualStyleBackColor = True
        '
        'ucrNudThreshold
        '
        Me.ucrNudThreshold.AutoSize = True
        Me.ucrNudThreshold.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudThreshold.Location = New System.Drawing.Point(69, 11)
        Me.ucrNudThreshold.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThreshold.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreshold.Name = "ucrNudThreshold"
        Me.ucrNudThreshold.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudThreshold.TabIndex = 1
        Me.ucrNudThreshold.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(10, 14)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(57, 13)
        Me.lblThreshold.TabIndex = 0
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Threshold:"
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.Location = New System.Drawing.Point(263, 158)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(66, 13)
        Me.lblDOY.TabIndex = 7
        Me.lblDOY.Text = "Day of Year:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(263, 72)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(263, 115)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 5
        Me.lblYear.Text = "Year:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(263, 29)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 1
        Me.lblStation.Text = "Station:"
        '
        'lblRainfall
        '
        Me.lblRainfall.AutoSize = True
        Me.lblRainfall.Location = New System.Drawing.Point(263, 201)
        Me.lblRainfall.Name = "lblRainfall"
        Me.lblRainfall.Size = New System.Drawing.Size(70, 13)
        Me.lblRainfall.TabIndex = 9
        Me.lblRainfall.Text = "Rain Column:"
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.ucrInputNewStatusColumnName)
        Me.grpDisplay.Controls.Add(Me.ucrChkAsDate)
        Me.grpDisplay.Controls.Add(Me.ucrChkStatus)
        Me.grpDisplay.Controls.Add(Me.ucrInputNewDateColumnName)
        Me.grpDisplay.Location = New System.Drawing.Point(4, 459)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(686, 49)
        Me.grpDisplay.TabIndex = 13
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Display"
        '
        'ucrInputNewStatusColumnName
        '
        Me.ucrInputNewStatusColumnName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewStatusColumnName.AutoSize = True
        Me.ucrInputNewStatusColumnName.IsMultiline = False
        Me.ucrInputNewStatusColumnName.IsReadOnly = False
        Me.ucrInputNewStatusColumnName.Location = New System.Drawing.Point(494, 18)
        Me.ucrInputNewStatusColumnName.Name = "ucrInputNewStatusColumnName"
        Me.ucrInputNewStatusColumnName.Size = New System.Drawing.Size(117, 21)
        Me.ucrInputNewStatusColumnName.TabIndex = 19
        '
        'ucrChkAsDate
        '
        Me.ucrChkAsDate.AutoSize = True
        Me.ucrChkAsDate.Checked = False
        Me.ucrChkAsDate.Location = New System.Drawing.Point(227, 18)
        Me.ucrChkAsDate.Name = "ucrChkAsDate"
        Me.ucrChkAsDate.Size = New System.Drawing.Size(51, 23)
        Me.ucrChkAsDate.TabIndex = 16
        '
        'ucrChkStatus
        '
        Me.ucrChkStatus.AutoSize = True
        Me.ucrChkStatus.Checked = False
        Me.ucrChkStatus.Location = New System.Drawing.Point(405, 18)
        Me.ucrChkStatus.Name = "ucrChkStatus"
        Me.ucrChkStatus.Size = New System.Drawing.Size(84, 23)
        Me.ucrChkStatus.TabIndex = 18
        '
        'ucrInputNewDateColumnName
        '
        Me.ucrInputNewDateColumnName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewDateColumnName.AutoSize = True
        Me.ucrInputNewDateColumnName.IsMultiline = False
        Me.ucrInputNewDateColumnName.IsReadOnly = False
        Me.ucrInputNewDateColumnName.Location = New System.Drawing.Point(281, 18)
        Me.ucrInputNewDateColumnName.Name = "ucrInputNewDateColumnName"
        Me.ucrInputNewDateColumnName.Size = New System.Drawing.Size(115, 21)
        Me.ucrInputNewDateColumnName.TabIndex = 17
        '
        'ucrChkAsDoy
        '
        Me.ucrChkAsDoy.AutoSize = True
        Me.ucrChkAsDoy.Checked = False
        Me.ucrChkAsDoy.Location = New System.Drawing.Point(13, 477)
        Me.ucrChkAsDoy.Name = "ucrChkAsDoy"
        Me.ucrChkAsDoy.Size = New System.Drawing.Size(83, 23)
        Me.ucrChkAsDoy.TabIndex = 14
        '
        'ucrInputNewDoyColumnName
        '
        Me.ucrInputNewDoyColumnName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewDoyColumnName.AutoSize = True
        Me.ucrInputNewDoyColumnName.IsMultiline = False
        Me.ucrInputNewDoyColumnName.IsReadOnly = False
        Me.ucrInputNewDoyColumnName.Location = New System.Drawing.Point(99, 477)
        Me.ucrInputNewDoyColumnName.Name = "ucrInputNewDoyColumnName"
        Me.ucrInputNewDoyColumnName.Size = New System.Drawing.Size(127, 21)
        Me.ucrInputNewDoyColumnName.TabIndex = 15
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(260, 45)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 2
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(260, 88)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 4
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(260, 131)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 6
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.AutoSize = True
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(260, 174)
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
        Me.ucrReceiverRainfall.AutoSize = True
        Me.ucrReceiverRainfall.frmParent = Me
        Me.ucrReceiverRainfall.Location = New System.Drawing.Point(260, 217)
        Me.ucrReceiverRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainfall.Name = "ucrReceiverRainfall"
        Me.ucrReceiverRainfall.Selector = Nothing
        Me.ucrReceiverRainfall.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverRainfall.strNcFilePath = ""
        Me.ucrReceiverRainfall.TabIndex = 10
        Me.ucrReceiverRainfall.ucrSelector = Nothing
        '
        'ucrSelectorForStartofRains
        '
        Me.ucrSelectorForStartofRains.AutoSize = True
        Me.ucrSelectorForStartofRains.bDropUnusedFilterLevels = False
        Me.ucrSelectorForStartofRains.bShowHiddenColumns = False
        Me.ucrSelectorForStartofRains.bUseCurrentFilter = True
        Me.ucrSelectorForStartofRains.Location = New System.Drawing.Point(5, 9)
        Me.ucrSelectorForStartofRains.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForStartofRains.Name = "ucrSelectorForStartofRains"
        Me.ucrSelectorForStartofRains.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForStartofRains.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(5, 514)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 20
        '
        'dlgStartofRains
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(696, 573)
        Me.Controls.Add(Me.lblRainfall)
        Me.Controls.Add(Me.ucrChkAsDoy)
        Me.Controls.Add(Me.ucrInputNewDoyColumnName)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverDOY)
        Me.Controls.Add(Me.ucrReceiverRainfall)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblDOY)
        Me.Controls.Add(Me.grpRainParameters)
        Me.Controls.Add(Me.grpConditionsForSatrtofRains)
        Me.Controls.Add(Me.ucrSelectorForStartofRains)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStartofRains"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start of Rains"
        Me.grpConditionsForSatrtofRains.ResumeLayout(False)
        Me.grpConditionsForSatrtofRains.PerformLayout()
        Me.grpRainParameters.ResumeLayout(False)
        Me.grpRainParameters.PerformLayout()
        Me.grpDisplay.ResumeLayout(False)
        Me.grpDisplay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForStartofRains As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpConditionsForSatrtofRains As GroupBox
    Friend WithEvents lblDSLengthofTime As Label
    Friend WithEvents lblDSMaximumDays As Label
    Friend WithEvents lblTRVal As Label
    Friend WithEvents lblRDMinimum As Label
    Friend WithEvents grpRainParameters As GroupBox
    Friend WithEvents lblTROverDays As Label
    Friend WithEvents lblDOY As Label
    Friend WithEvents ucrReceiverRainfall As ucrReceiverSingle
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents lblRDWidth As Label
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblYear As Label
    Friend WithEvents rdoTRPercentile As RadioButton
    Friend WithEvents rdoTRAmount As RadioButton
    Friend WithEvents lblDPOverallInterval As Label
    Friend WithEvents lblDPLength As Label
    Friend WithEvents lblDPMaxRain As Label
    Friend WithEvents ucrNudTROverDays As ucrNud
    Friend WithEvents ucrNudTRPercentile As ucrNud
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrChkTotalRainfall As ucrCheck
    Friend WithEvents ucrNudTRAmount As ucrNud
    Friend WithEvents ucrPnlTRCalculateBy As UcrPanel
    Friend WithEvents ucrNudRDMinimumDays As ucrNud
    Friend WithEvents ucrNudRDOutOfDays As ucrNud
    Friend WithEvents ucrNudThreshold As ucrNud
    Friend WithEvents ucrChkNumberOfRainyDays As ucrCheck
    Friend WithEvents ucrNudDSLengthOfTime As ucrNud
    Friend WithEvents ucrNudDSMaximumDays As ucrNud
    Friend WithEvents ucrNudDPOverallInterval As ucrNud
    Friend WithEvents ucrNudDPRainPeriod As ucrNud
    Friend WithEvents ucrNudDPMaxRain As ucrNud
    Friend WithEvents ucrChkDrySpell As ucrCheck
    Friend WithEvents ucrChkDryPeriod As ucrCheck
    Friend WithEvents ucrInputNewDoyColumnName As ucrInputTextBox
    Friend WithEvents ucrInputFilterPreview As ucrInputTextBox
    Friend WithEvents cmdDoyRange As Button
    Friend WithEvents ucrInputNewDateColumnName As ucrInputTextBox
    Friend WithEvents ucrChkAsDate As ucrCheck
    Friend WithEvents ucrChkAsDoy As ucrCheck
    Friend WithEvents lblRainfall As Label
    Friend WithEvents ucrChkStatus As ucrCheck
    Friend WithEvents ucrInputNewStatusColumnName As ucrInputTextBox
    Friend WithEvents grpDisplay As GroupBox
End Class