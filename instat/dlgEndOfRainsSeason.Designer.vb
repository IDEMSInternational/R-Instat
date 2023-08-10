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
Partial Class dlgEndOfRainsSeason
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
        Me.ucrInputEndRainDoy = New instat.ucrInputTextBox()
        Me.rdoEndOfRains = New System.Windows.Forms.RadioButton()
        Me.ucrInputEndofRainsDate = New instat.ucrInputTextBox()
        Me.lblReplaceNA = New System.Windows.Forms.Label()
        Me.ucrInputEndofSeasonOccurence = New instat.ucrInputTextBox()
        Me.ucrInputSeasonDoy = New instat.ucrInputTextBox()
        Me.ucrInputEndofSeasonDate = New instat.ucrInputTextBox()
        Me.rdoVariableEvaporation = New System.Windows.Forms.RadioButton()
        Me.grpEndofSeason = New System.Windows.Forms.GroupBox()
        Me.ucrChkEndofSeasonOccurence = New instat.ucrCheck()
        Me.ucrChkEndofSeasonDate = New instat.ucrCheck()
        Me.ucrChkEndofSeasonDoy = New instat.ucrCheck()
        Me.ucrInputEndofRainsOccurence = New instat.ucrInputTextBox()
        Me.cmdDoyRange = New System.Windows.Forms.Button()
        Me.lblTotalOverDays = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblWaterBalanceLessThan = New System.Windows.Forms.Label()
        Me.lblEvaporation = New System.Windows.Forms.Label()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.rdoValueEvaporation = New System.Windows.Forms.RadioButton()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblRainfall = New System.Windows.Forms.Label()
        Me.ucrChkEndofRainsDoy = New instat.ucrCheck()
        Me.ucrNudWB = New instat.ucrNud()
        Me.ucrChkWB = New instat.ucrCheck()
        Me.rdoEndOfSeasons = New System.Windows.Forms.RadioButton()
        Me.ucrPnlEndOfRainsAndSeasons = New instat.UcrPanel()
        Me.ucrInputReplaceNA = New instat.ucrInputTextBox()
        Me.ucrReceiverEvaporation = New instat.ucrReceiverSingle()
        Me.ucrInputEvaporation = New instat.ucrInputTextBox()
        Me.ucrPnlEvaporation = New instat.UcrPanel()
        Me.ucrInputFilterPreview = New instat.ucrInputTextBox()
        Me.ucrNudTotalOverDays = New instat.ucrNud()
        Me.ucrNudAmount = New instat.ucrNud()
        Me.ucrNudWBLessThan = New instat.ucrNud()
        Me.ucrNudCapacity = New instat.ucrNud()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverRainfall = New instat.ucrReceiverSingle()
        Me.ucrSelectorForWaterBalance = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpEndofRains = New System.Windows.Forms.GroupBox()
        Me.ucrChkEndofRainsDate = New instat.ucrCheck()
        Me.ucrChkEndofRainsOccurence = New instat.ucrCheck()
        Me.lblDOY = New System.Windows.Forms.Label()
        Me.grpEndofSeason.SuspendLayout()
        Me.grpEndofRains.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrInputEndRainDoy
        '
        Me.ucrInputEndRainDoy.AddQuotesIfUnrecognised = True
        Me.ucrInputEndRainDoy.AutoSize = True
        Me.ucrInputEndRainDoy.IsMultiline = False
        Me.ucrInputEndRainDoy.IsReadOnly = False
        Me.ucrInputEndRainDoy.Location = New System.Drawing.Point(50, 19)
        Me.ucrInputEndRainDoy.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputEndRainDoy.Name = "ucrInputEndRainDoy"
        Me.ucrInputEndRainDoy.Size = New System.Drawing.Size(65, 21)
        Me.ucrInputEndRainDoy.TabIndex = 50
        '
        'rdoEndOfRains
        '
        Me.rdoEndOfRains.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoEndOfRains.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEndOfRains.FlatAppearance.BorderSize = 2
        Me.rdoEndOfRains.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEndOfRains.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoEndOfRains.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoEndOfRains.Location = New System.Drawing.Point(88, 19)
        Me.rdoEndOfRains.Name = "rdoEndOfRains"
        Me.rdoEndOfRains.Size = New System.Drawing.Size(130, 27)
        Me.rdoEndOfRains.TabIndex = 118
        Me.rdoEndOfRains.Text = "End of Rains"
        Me.rdoEndOfRains.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoEndOfRains.UseVisualStyleBackColor = True
        '
        'ucrInputEndofRainsDate
        '
        Me.ucrInputEndofRainsDate.AddQuotesIfUnrecognised = True
        Me.ucrInputEndofRainsDate.AutoSize = True
        Me.ucrInputEndofRainsDate.IsMultiline = False
        Me.ucrInputEndofRainsDate.IsReadOnly = False
        Me.ucrInputEndofRainsDate.Location = New System.Drawing.Point(165, 21)
        Me.ucrInputEndofRainsDate.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputEndofRainsDate.Name = "ucrInputEndofRainsDate"
        Me.ucrInputEndofRainsDate.Size = New System.Drawing.Size(93, 17)
        Me.ucrInputEndofRainsDate.TabIndex = 36
        '
        'lblReplaceNA
        '
        Me.lblReplaceNA.AutoSize = True
        Me.lblReplaceNA.Location = New System.Drawing.Point(80, 411)
        Me.lblReplaceNA.Name = "lblReplaceNA"
        Me.lblReplaceNA.Size = New System.Drawing.Size(90, 13)
        Me.lblReplaceNA.TabIndex = 113
        Me.lblReplaceNA.Text = "Replace NA with:"
        '
        'ucrInputEndofSeasonOccurence
        '
        Me.ucrInputEndofSeasonOccurence.AddQuotesIfUnrecognised = True
        Me.ucrInputEndofSeasonOccurence.AutoSize = True
        Me.ucrInputEndofSeasonOccurence.IsMultiline = False
        Me.ucrInputEndofSeasonOccurence.IsReadOnly = False
        Me.ucrInputEndofSeasonOccurence.Location = New System.Drawing.Point(361, 15)
        Me.ucrInputEndofSeasonOccurence.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputEndofSeasonOccurence.Name = "ucrInputEndofSeasonOccurence"
        Me.ucrInputEndofSeasonOccurence.Size = New System.Drawing.Size(104, 21)
        Me.ucrInputEndofSeasonOccurence.TabIndex = 38
        '
        'ucrInputSeasonDoy
        '
        Me.ucrInputSeasonDoy.AddQuotesIfUnrecognised = True
        Me.ucrInputSeasonDoy.AutoSize = True
        Me.ucrInputSeasonDoy.IsMultiline = False
        Me.ucrInputSeasonDoy.IsReadOnly = False
        Me.ucrInputSeasonDoy.Location = New System.Drawing.Point(49, 15)
        Me.ucrInputSeasonDoy.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSeasonDoy.Name = "ucrInputSeasonDoy"
        Me.ucrInputSeasonDoy.Size = New System.Drawing.Size(67, 21)
        Me.ucrInputSeasonDoy.TabIndex = 32
        '
        'ucrInputEndofSeasonDate
        '
        Me.ucrInputEndofSeasonDate.AddQuotesIfUnrecognised = True
        Me.ucrInputEndofSeasonDate.AutoSize = True
        Me.ucrInputEndofSeasonDate.IsMultiline = False
        Me.ucrInputEndofSeasonDate.IsReadOnly = False
        Me.ucrInputEndofSeasonDate.Location = New System.Drawing.Point(165, 15)
        Me.ucrInputEndofSeasonDate.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputEndofSeasonDate.Name = "ucrInputEndofSeasonDate"
        Me.ucrInputEndofSeasonDate.Size = New System.Drawing.Size(110, 21)
        Me.ucrInputEndofSeasonDate.TabIndex = 37
        '
        'rdoVariableEvaporation
        '
        Me.rdoVariableEvaporation.AutoSize = True
        Me.rdoVariableEvaporation.Location = New System.Drawing.Point(222, 351)
        Me.rdoVariableEvaporation.Name = "rdoVariableEvaporation"
        Me.rdoVariableEvaporation.Size = New System.Drawing.Size(63, 17)
        Me.rdoVariableEvaporation.TabIndex = 111
        Me.rdoVariableEvaporation.Text = "Variable"
        Me.rdoVariableEvaporation.UseVisualStyleBackColor = True
        '
        'grpEndofSeason
        '
        Me.grpEndofSeason.Controls.Add(Me.ucrInputEndofSeasonOccurence)
        Me.grpEndofSeason.Controls.Add(Me.ucrInputSeasonDoy)
        Me.grpEndofSeason.Controls.Add(Me.ucrInputEndofSeasonDate)
        Me.grpEndofSeason.Controls.Add(Me.ucrChkEndofSeasonOccurence)
        Me.grpEndofSeason.Controls.Add(Me.ucrChkEndofSeasonDate)
        Me.grpEndofSeason.Controls.Add(Me.ucrChkEndofSeasonDoy)
        Me.grpEndofSeason.Location = New System.Drawing.Point(2, 435)
        Me.grpEndofSeason.Name = "grpEndofSeason"
        Me.grpEndofSeason.Size = New System.Drawing.Size(472, 41)
        Me.grpEndofSeason.TabIndex = 115
        Me.grpEndofSeason.TabStop = False
        Me.grpEndofSeason.Text = "End of Season"
        '
        'ucrChkEndofSeasonOccurence
        '
        Me.ucrChkEndofSeasonOccurence.AutoSize = True
        Me.ucrChkEndofSeasonOccurence.Checked = False
        Me.ucrChkEndofSeasonOccurence.Location = New System.Drawing.Point(281, 17)
        Me.ucrChkEndofSeasonOccurence.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkEndofSeasonOccurence.Name = "ucrChkEndofSeasonOccurence"
        Me.ucrChkEndofSeasonOccurence.Size = New System.Drawing.Size(84, 34)
        Me.ucrChkEndofSeasonOccurence.TabIndex = 48
        '
        'ucrChkEndofSeasonDate
        '
        Me.ucrChkEndofSeasonDate.AutoSize = True
        Me.ucrChkEndofSeasonDate.Checked = False
        Me.ucrChkEndofSeasonDate.Location = New System.Drawing.Point(121, 16)
        Me.ucrChkEndofSeasonDate.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkEndofSeasonDate.Name = "ucrChkEndofSeasonDate"
        Me.ucrChkEndofSeasonDate.Size = New System.Drawing.Size(53, 34)
        Me.ucrChkEndofSeasonDate.TabIndex = 47
        '
        'ucrChkEndofSeasonDoy
        '
        Me.ucrChkEndofSeasonDoy.AutoSize = True
        Me.ucrChkEndofSeasonDoy.Checked = False
        Me.ucrChkEndofSeasonDoy.Location = New System.Drawing.Point(4, 16)
        Me.ucrChkEndofSeasonDoy.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkEndofSeasonDoy.Name = "ucrChkEndofSeasonDoy"
        Me.ucrChkEndofSeasonDoy.Size = New System.Drawing.Size(58, 34)
        Me.ucrChkEndofSeasonDoy.TabIndex = 46
        '
        'ucrInputEndofRainsOccurence
        '
        Me.ucrInputEndofRainsOccurence.AddQuotesIfUnrecognised = True
        Me.ucrInputEndofRainsOccurence.AutoSize = True
        Me.ucrInputEndofRainsOccurence.IsMultiline = False
        Me.ucrInputEndofRainsOccurence.IsReadOnly = False
        Me.ucrInputEndofRainsOccurence.Location = New System.Drawing.Point(341, 16)
        Me.ucrInputEndofRainsOccurence.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputEndofRainsOccurence.Name = "ucrInputEndofRainsOccurence"
        Me.ucrInputEndofRainsOccurence.Size = New System.Drawing.Size(94, 20)
        Me.ucrInputEndofRainsOccurence.TabIndex = 39
        '
        'cmdDoyRange
        '
        Me.cmdDoyRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDoyRange.Location = New System.Drawing.Point(21, 279)
        Me.cmdDoyRange.Name = "cmdDoyRange"
        Me.cmdDoyRange.Size = New System.Drawing.Size(105, 26)
        Me.cmdDoyRange.TabIndex = 96
        Me.cmdDoyRange.Tag = ""
        Me.cmdDoyRange.Text = "Day Range"
        Me.cmdDoyRange.UseVisualStyleBackColor = True
        '
        'lblTotalOverDays
        '
        Me.lblTotalOverDays.AutoSize = True
        Me.lblTotalOverDays.Location = New System.Drawing.Point(160, 319)
        Me.lblTotalOverDays.Name = "lblTotalOverDays"
        Me.lblTotalOverDays.Size = New System.Drawing.Size(66, 13)
        Me.lblTotalOverDays.TabIndex = 100
        Me.lblTotalOverDays.Text = "Over Day(s):"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(14, 319)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(46, 13)
        Me.lblAmount.TabIndex = 98
        Me.lblAmount.Text = "Amount:"
        '
        'lblWaterBalanceLessThan
        '
        Me.lblWaterBalanceLessThan.AutoSize = True
        Me.lblWaterBalanceLessThan.Location = New System.Drawing.Point(134, 319)
        Me.lblWaterBalanceLessThan.Name = "lblWaterBalanceLessThan"
        Me.lblWaterBalanceLessThan.Size = New System.Drawing.Size(93, 13)
        Me.lblWaterBalanceLessThan.TabIndex = 105
        Me.lblWaterBalanceLessThan.Tag = "Water Balance <="
        Me.lblWaterBalanceLessThan.Text = "Water Balance <="
        '
        'lblEvaporation
        '
        Me.lblEvaporation.AutoSize = True
        Me.lblEvaporation.Location = New System.Drawing.Point(14, 354)
        Me.lblEvaporation.Name = "lblEvaporation"
        Me.lblEvaporation.Size = New System.Drawing.Size(67, 13)
        Me.lblEvaporation.TabIndex = 107
        Me.lblEvaporation.Text = "Evaporation:"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(15, 319)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(51, 13)
        Me.lblCapacity.TabIndex = 103
        Me.lblCapacity.Tag = "Capacity:"
        Me.lblCapacity.Text = "Capacity:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(305, 55)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 86
        Me.lblStation.Text = "Station:"
        '
        'rdoValueEvaporation
        '
        Me.rdoValueEvaporation.AutoSize = True
        Me.rdoValueEvaporation.Location = New System.Drawing.Point(95, 351)
        Me.rdoValueEvaporation.Name = "rdoValueEvaporation"
        Me.rdoValueEvaporation.Size = New System.Drawing.Size(52, 17)
        Me.rdoValueEvaporation.TabIndex = 109
        Me.rdoValueEvaporation.Text = "Value"
        Me.rdoValueEvaporation.UseVisualStyleBackColor = True
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(305, 146)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 90
        Me.lblYear.Text = "Year:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(305, 100)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 88
        Me.lblDate.Text = "Date:"
        '
        'lblRainfall
        '
        Me.lblRainfall.AutoSize = True
        Me.lblRainfall.Location = New System.Drawing.Point(305, 234)
        Me.lblRainfall.Name = "lblRainfall"
        Me.lblRainfall.Size = New System.Drawing.Size(70, 13)
        Me.lblRainfall.TabIndex = 94
        Me.lblRainfall.Text = "Rain Column:"
        '
        'ucrChkEndofRainsDoy
        '
        Me.ucrChkEndofRainsDoy.AutoSize = True
        Me.ucrChkEndofRainsDoy.Checked = False
        Me.ucrChkEndofRainsDoy.Location = New System.Drawing.Point(5, 18)
        Me.ucrChkEndofRainsDoy.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkEndofRainsDoy.Name = "ucrChkEndofRainsDoy"
        Me.ucrChkEndofRainsDoy.Size = New System.Drawing.Size(60, 34)
        Me.ucrChkEndofRainsDoy.TabIndex = 49
        '
        'ucrNudWB
        '
        Me.ucrNudWB.AutoSize = True
        Me.ucrNudWB.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWB.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWB.Location = New System.Drawing.Point(125, 383)
        Me.ucrNudWB.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudWB.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWB.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWB.Name = "ucrNudWB"
        Me.ucrNudWB.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWB.TabIndex = 121
        Me.ucrNudWB.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkWB
        '
        Me.ucrChkWB.AutoSize = True
        Me.ucrChkWB.Checked = False
        Me.ucrChkWB.Location = New System.Drawing.Point(16, 383)
        Me.ucrChkWB.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrChkWB.Name = "ucrChkWB"
        Me.ucrChkWB.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkWB.TabIndex = 120
        '
        'rdoEndOfSeasons
        '
        Me.rdoEndOfSeasons.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoEndOfSeasons.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEndOfSeasons.FlatAppearance.BorderSize = 2
        Me.rdoEndOfSeasons.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEndOfSeasons.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoEndOfSeasons.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoEndOfSeasons.Location = New System.Drawing.Point(216, 19)
        Me.rdoEndOfSeasons.Name = "rdoEndOfSeasons"
        Me.rdoEndOfSeasons.Size = New System.Drawing.Size(130, 27)
        Me.rdoEndOfSeasons.TabIndex = 119
        Me.rdoEndOfSeasons.Text = "End of Season"
        Me.rdoEndOfSeasons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoEndOfSeasons.UseVisualStyleBackColor = True
        '
        'ucrPnlEndOfRainsAndSeasons
        '
        Me.ucrPnlEndOfRainsAndSeasons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlEndOfRainsAndSeasons.Location = New System.Drawing.Point(83, 16)
        Me.ucrPnlEndOfRainsAndSeasons.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlEndOfRainsAndSeasons.Name = "ucrPnlEndOfRainsAndSeasons"
        Me.ucrPnlEndOfRainsAndSeasons.Size = New System.Drawing.Size(268, 33)
        Me.ucrPnlEndOfRainsAndSeasons.TabIndex = 117
        '
        'ucrInputReplaceNA
        '
        Me.ucrInputReplaceNA.AddQuotesIfUnrecognised = True
        Me.ucrInputReplaceNA.AutoSize = True
        Me.ucrInputReplaceNA.IsMultiline = False
        Me.ucrInputReplaceNA.IsReadOnly = False
        Me.ucrInputReplaceNA.Location = New System.Drawing.Point(175, 406)
        Me.ucrInputReplaceNA.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputReplaceNA.Name = "ucrInputReplaceNA"
        Me.ucrInputReplaceNA.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputReplaceNA.TabIndex = 114
        '
        'ucrReceiverEvaporation
        '
        Me.ucrReceiverEvaporation.AutoSize = True
        Me.ucrReceiverEvaporation.frmParent = Me
        Me.ucrReceiverEvaporation.Location = New System.Drawing.Point(286, 351)
        Me.ucrReceiverEvaporation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEvaporation.Name = "ucrReceiverEvaporation"
        Me.ucrReceiverEvaporation.Selector = Nothing
        Me.ucrReceiverEvaporation.Size = New System.Drawing.Size(140, 20)
        Me.ucrReceiverEvaporation.strNcFilePath = ""
        Me.ucrReceiverEvaporation.TabIndex = 112
        Me.ucrReceiverEvaporation.ucrSelector = Nothing
        '
        'ucrInputEvaporation
        '
        Me.ucrInputEvaporation.AddQuotesIfUnrecognised = True
        Me.ucrInputEvaporation.AutoSize = True
        Me.ucrInputEvaporation.IsMultiline = False
        Me.ucrInputEvaporation.IsReadOnly = False
        Me.ucrInputEvaporation.Location = New System.Drawing.Point(152, 351)
        Me.ucrInputEvaporation.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputEvaporation.Name = "ucrInputEvaporation"
        Me.ucrInputEvaporation.Size = New System.Drawing.Size(64, 21)
        Me.ucrInputEvaporation.TabIndex = 110
        '
        'ucrPnlEvaporation
        '
        Me.ucrPnlEvaporation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlEvaporation.Location = New System.Drawing.Point(95, 346)
        Me.ucrPnlEvaporation.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlEvaporation.Name = "ucrPnlEvaporation"
        Me.ucrPnlEvaporation.Size = New System.Drawing.Size(345, 27)
        Me.ucrPnlEvaporation.TabIndex = 108
        '
        'ucrInputFilterPreview
        '
        Me.ucrInputFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterPreview.AutoSize = True
        Me.ucrInputFilterPreview.IsMultiline = False
        Me.ucrInputFilterPreview.IsReadOnly = True
        Me.ucrInputFilterPreview.Location = New System.Drawing.Point(130, 282)
        Me.ucrInputFilterPreview.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        Me.ucrInputFilterPreview.Size = New System.Drawing.Size(242, 22)
        Me.ucrInputFilterPreview.TabIndex = 97
        '
        'ucrNudTotalOverDays
        '
        Me.ucrNudTotalOverDays.AutoSize = True
        Me.ucrNudTotalOverDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTotalOverDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTotalOverDays.Location = New System.Drawing.Point(232, 317)
        Me.ucrNudTotalOverDays.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudTotalOverDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTotalOverDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTotalOverDays.Name = "ucrNudTotalOverDays"
        Me.ucrNudTotalOverDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTotalOverDays.TabIndex = 101
        Me.ucrNudTotalOverDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudAmount
        '
        Me.ucrNudAmount.AutoSize = True
        Me.ucrNudAmount.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAmount.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAmount.Location = New System.Drawing.Point(67, 317)
        Me.ucrNudAmount.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudAmount.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAmount.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAmount.Name = "ucrNudAmount"
        Me.ucrNudAmount.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAmount.TabIndex = 99
        Me.ucrNudAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudWBLessThan
        '
        Me.ucrNudWBLessThan.AutoSize = True
        Me.ucrNudWBLessThan.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWBLessThan.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWBLessThan.Location = New System.Drawing.Point(233, 317)
        Me.ucrNudWBLessThan.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudWBLessThan.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWBLessThan.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWBLessThan.Name = "ucrNudWBLessThan"
        Me.ucrNudWBLessThan.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWBLessThan.TabIndex = 106
        Me.ucrNudWBLessThan.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudCapacity
        '
        Me.ucrNudCapacity.AutoSize = True
        Me.ucrNudCapacity.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCapacity.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCapacity.Location = New System.Drawing.Point(68, 317)
        Me.ucrNudCapacity.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudCapacity.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCapacity.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCapacity.Name = "ucrNudCapacity"
        Me.ucrNudCapacity.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCapacity.TabIndex = 104
        Me.ucrNudCapacity.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(308, 68)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 87
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(308, 159)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 91
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(308, 113)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 89
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.AutoSize = True
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(308, 203)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.TabIndex = 93
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrReceiverRainfall
        '
        Me.ucrReceiverRainfall.AutoSize = True
        Me.ucrReceiverRainfall.frmParent = Me
        Me.ucrReceiverRainfall.Location = New System.Drawing.Point(308, 247)
        Me.ucrReceiverRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainfall.Name = "ucrReceiverRainfall"
        Me.ucrReceiverRainfall.Selector = Nothing
        Me.ucrReceiverRainfall.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverRainfall.strNcFilePath = ""
        Me.ucrReceiverRainfall.TabIndex = 95
        Me.ucrReceiverRainfall.ucrSelector = Nothing
        '
        'ucrSelectorForWaterBalance
        '
        Me.ucrSelectorForWaterBalance.AutoSize = True
        Me.ucrSelectorForWaterBalance.bDropUnusedFilterLevels = False
        Me.ucrSelectorForWaterBalance.bShowHiddenColumns = False
        Me.ucrSelectorForWaterBalance.bUseCurrentFilter = True
        Me.ucrSelectorForWaterBalance.Location = New System.Drawing.Point(2, 78)
        Me.ucrSelectorForWaterBalance.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForWaterBalance.Name = "ucrSelectorForWaterBalance"
        Me.ucrSelectorForWaterBalance.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForWaterBalance.TabIndex = 85
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(2, 481)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 116
        '
        'grpEndofRains
        '
        Me.grpEndofRains.Controls.Add(Me.ucrInputEndofRainsDate)
        Me.grpEndofRains.Controls.Add(Me.ucrInputEndofRainsOccurence)
        Me.grpEndofRains.Controls.Add(Me.ucrInputEndRainDoy)
        Me.grpEndofRains.Controls.Add(Me.ucrChkEndofRainsDoy)
        Me.grpEndofRains.Controls.Add(Me.ucrChkEndofRainsDate)
        Me.grpEndofRains.Controls.Add(Me.ucrChkEndofRainsOccurence)
        Me.grpEndofRains.Location = New System.Drawing.Point(2, 435)
        Me.grpEndofRains.Name = "grpEndofRains"
        Me.grpEndofRains.Size = New System.Drawing.Size(429, 40)
        Me.grpEndofRains.TabIndex = 102
        Me.grpEndofRains.TabStop = False
        Me.grpEndofRains.Text = "End of Rains"
        '
        'ucrChkEndofRainsDate
        '
        Me.ucrChkEndofRainsDate.AutoSize = True
        Me.ucrChkEndofRainsDate.Checked = False
        Me.ucrChkEndofRainsDate.Location = New System.Drawing.Point(118, 17)
        Me.ucrChkEndofRainsDate.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkEndofRainsDate.Name = "ucrChkEndofRainsDate"
        Me.ucrChkEndofRainsDate.Size = New System.Drawing.Size(52, 34)
        Me.ucrChkEndofRainsDate.TabIndex = 48
        '
        'ucrChkEndofRainsOccurence
        '
        Me.ucrChkEndofRainsOccurence.AutoSize = True
        Me.ucrChkEndofRainsOccurence.Checked = False
        Me.ucrChkEndofRainsOccurence.Location = New System.Drawing.Point(264, 16)
        Me.ucrChkEndofRainsOccurence.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkEndofRainsOccurence.Name = "ucrChkEndofRainsOccurence"
        Me.ucrChkEndofRainsOccurence.Size = New System.Drawing.Size(91, 34)
        Me.ucrChkEndofRainsOccurence.TabIndex = 47
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.Location = New System.Drawing.Point(305, 190)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(66, 13)
        Me.lblDOY.TabIndex = 92
        Me.lblDOY.Text = "Day of Year:"
        '
        'dlgEndOfRainsSeason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(477, 549)
        Me.Controls.Add(Me.rdoEndOfRains)
        Me.Controls.Add(Me.lblReplaceNA)
        Me.Controls.Add(Me.rdoVariableEvaporation)
        Me.Controls.Add(Me.grpEndofSeason)
        Me.Controls.Add(Me.cmdDoyRange)
        Me.Controls.Add(Me.lblTotalOverDays)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblWaterBalanceLessThan)
        Me.Controls.Add(Me.lblEvaporation)
        Me.Controls.Add(Me.lblCapacity)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.rdoValueEvaporation)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblRainfall)
        Me.Controls.Add(Me.ucrNudWB)
        Me.Controls.Add(Me.ucrChkWB)
        Me.Controls.Add(Me.rdoEndOfSeasons)
        Me.Controls.Add(Me.ucrPnlEndOfRainsAndSeasons)
        Me.Controls.Add(Me.ucrInputReplaceNA)
        Me.Controls.Add(Me.ucrReceiverEvaporation)
        Me.Controls.Add(Me.ucrInputEvaporation)
        Me.Controls.Add(Me.ucrPnlEvaporation)
        Me.Controls.Add(Me.ucrInputFilterPreview)
        Me.Controls.Add(Me.ucrNudTotalOverDays)
        Me.Controls.Add(Me.ucrNudAmount)
        Me.Controls.Add(Me.ucrNudWBLessThan)
        Me.Controls.Add(Me.ucrNudCapacity)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverDOY)
        Me.Controls.Add(Me.ucrReceiverRainfall)
        Me.Controls.Add(Me.ucrSelectorForWaterBalance)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpEndofRains)
        Me.Controls.Add(Me.lblDOY)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgEndOfRainsSeason"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "End_of_Rains_Season"
        Me.Text = "End of Rains/Season"
        Me.grpEndofSeason.ResumeLayout(False)
        Me.grpEndofSeason.PerformLayout()
        Me.grpEndofRains.ResumeLayout(False)
        Me.grpEndofRains.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrInputEndRainDoy As ucrInputTextBox
    Friend WithEvents rdoEndOfRains As RadioButton
    Friend WithEvents ucrInputEndofRainsDate As ucrInputTextBox
    Friend WithEvents lblReplaceNA As Label
    Friend WithEvents ucrInputEndofSeasonOccurence As ucrInputTextBox
    Friend WithEvents ucrInputSeasonDoy As ucrInputTextBox
    Friend WithEvents ucrInputEndofSeasonDate As ucrInputTextBox
    Friend WithEvents rdoVariableEvaporation As RadioButton
    Friend WithEvents grpEndofSeason As GroupBox
    Friend WithEvents ucrChkEndofSeasonOccurence As ucrCheck
    Friend WithEvents ucrChkEndofSeasonDate As ucrCheck
    Friend WithEvents ucrChkEndofSeasonDoy As ucrCheck
    Friend WithEvents ucrInputEndofRainsOccurence As ucrInputTextBox
    Friend WithEvents cmdDoyRange As Button
    Friend WithEvents lblTotalOverDays As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblWaterBalanceLessThan As Label
    Friend WithEvents lblEvaporation As Label
    Friend WithEvents lblCapacity As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents rdoValueEvaporation As RadioButton
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblRainfall As Label
    Friend WithEvents ucrChkEndofRainsDoy As ucrCheck
    Friend WithEvents ucrNudWB As ucrNud
    Friend WithEvents ucrChkWB As ucrCheck
    Friend WithEvents rdoEndOfSeasons As RadioButton
    Friend WithEvents ucrPnlEndOfRainsAndSeasons As UcrPanel
    Friend WithEvents ucrInputReplaceNA As ucrInputTextBox
    Friend WithEvents ucrReceiverEvaporation As ucrReceiverSingle
    Friend WithEvents ucrInputEvaporation As ucrInputTextBox
    Friend WithEvents ucrPnlEvaporation As UcrPanel
    Friend WithEvents ucrInputFilterPreview As ucrInputTextBox
    Friend WithEvents ucrNudTotalOverDays As ucrNud
    Friend WithEvents ucrNudAmount As ucrNud
    Friend WithEvents ucrNudWBLessThan As ucrNud
    Friend WithEvents ucrNudCapacity As ucrNud
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents ucrReceiverRainfall As ucrReceiverSingle
    Friend WithEvents ucrSelectorForWaterBalance As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpEndofRains As GroupBox
    Friend WithEvents ucrChkEndofRainsDate As ucrCheck
    Friend WithEvents ucrChkEndofRainsOccurence As ucrCheck
    Friend WithEvents lblDOY As Label
End Class