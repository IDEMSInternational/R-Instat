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
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDOY = New System.Windows.Forms.Label()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.lblRainfall = New System.Windows.Forms.Label()
        Me.lblEvaporation = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblTotalOverDays = New System.Windows.Forms.Label()
        Me.lblWaterBalanceLessThan = New System.Windows.Forms.Label()
        Me.cmdDoyRange = New System.Windows.Forms.Button()
        Me.rdoVariableEvaporation = New System.Windows.Forms.RadioButton()
        Me.rdoValueEvaporation = New System.Windows.Forms.RadioButton()
        Me.grpEndofSeason = New System.Windows.Forms.GroupBox()
        Me.ucrInputFilled = New instat.ucrInputTextBox()
        Me.ucrChkFilled = New instat.ucrCheck()
        Me.ucrInputEndofSeasonOccurence = New instat.ucrInputTextBox()
        Me.ucrInputSeasonDoy = New instat.ucrInputTextBox()
        Me.ucrInputEndofSeasonDate = New instat.ucrInputTextBox()
        Me.ucrChkEndofSeasonOccurence = New instat.ucrCheck()
        Me.ucrChkEndofSeasonDate = New instat.ucrCheck()
        Me.ucrChkEndofSeasonDoy = New instat.ucrCheck()
        Me.grpEndofRains = New System.Windows.Forms.GroupBox()
        Me.ucrInputEndofRainsDate = New instat.ucrInputTextBox()
        Me.ucrInputEndofRainsOccurence = New instat.ucrInputTextBox()
        Me.ucrInputEndRainDoy = New instat.ucrInputTextBox()
        Me.ucrChkEndofRainsDoy = New instat.ucrCheck()
        Me.ucrChkEndofRainsDate = New instat.ucrCheck()
        Me.ucrChkEndofRainsOccurence = New instat.ucrCheck()
        Me.rdoEndOfSeasons = New System.Windows.Forms.RadioButton()
        Me.rdoEndOfRains = New System.Windows.Forms.RadioButton()
        Me.ucrPnlEndOfRainsAndSeasons = New instat.UcrPanel()
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
        Me.ucrNudWB = New instat.ucrNud()
        Me.ucrChkWB = New instat.ucrCheck()
        Me.ucrSaveObject = New instat.ucrSave()
        Me.grpEndofSeason.SuspendLayout()
        Me.grpEndofRains.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(459, 206)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(47, 20)
        Me.lblYear.TabIndex = 5
        Me.lblYear.Text = "Year:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(459, 136)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 20)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date:"
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.Location = New System.Drawing.Point(459, 272)
        Me.lblDOY.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(97, 20)
        Me.lblDOY.TabIndex = 7
        Me.lblDOY.Text = "Day of Year:"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(24, 465)
        Me.lblCapacity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(74, 20)
        Me.lblCapacity.TabIndex = 20
        Me.lblCapacity.Tag = "Capacity:"
        Me.lblCapacity.Text = "Capacity:"
        '
        'lblRainfall
        '
        Me.lblRainfall.AutoSize = True
        Me.lblRainfall.Location = New System.Drawing.Point(459, 338)
        Me.lblRainfall.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRainfall.Name = "lblRainfall"
        Me.lblRainfall.Size = New System.Drawing.Size(104, 20)
        Me.lblRainfall.TabIndex = 9
        Me.lblRainfall.Text = "Rain Column:"
        '
        'lblEvaporation
        '
        Me.lblEvaporation.AutoSize = True
        Me.lblEvaporation.Location = New System.Drawing.Point(22, 518)
        Me.lblEvaporation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEvaporation.Name = "lblEvaporation"
        Me.lblEvaporation.Size = New System.Drawing.Size(98, 20)
        Me.lblEvaporation.TabIndex = 24
        Me.lblEvaporation.Text = "Evaporation:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(459, 69)
        Me.lblStation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(64, 20)
        Me.lblStation.TabIndex = 1
        Me.lblStation.Text = "Station:"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(22, 465)
        Me.lblAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(69, 20)
        Me.lblAmount.TabIndex = 14
        Me.lblAmount.Text = "Amount:"
        '
        'lblTotalOverDays
        '
        Me.lblTotalOverDays.AutoSize = True
        Me.lblTotalOverDays.Location = New System.Drawing.Point(242, 465)
        Me.lblTotalOverDays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalOverDays.Name = "lblTotalOverDays"
        Me.lblTotalOverDays.Size = New System.Drawing.Size(96, 20)
        Me.lblTotalOverDays.TabIndex = 16
        Me.lblTotalOverDays.Text = "Over Day(s):"
        '
        'lblWaterBalanceLessThan
        '
        Me.lblWaterBalanceLessThan.AutoSize = True
        Me.lblWaterBalanceLessThan.Location = New System.Drawing.Point(202, 465)
        Me.lblWaterBalanceLessThan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWaterBalanceLessThan.Name = "lblWaterBalanceLessThan"
        Me.lblWaterBalanceLessThan.Size = New System.Drawing.Size(136, 20)
        Me.lblWaterBalanceLessThan.TabIndex = 22
        Me.lblWaterBalanceLessThan.Tag = "Water Balance <="
        Me.lblWaterBalanceLessThan.Text = "Water Balance <="
        '
        'cmdDoyRange
        '
        Me.cmdDoyRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDoyRange.Location = New System.Drawing.Point(33, 405)
        Me.cmdDoyRange.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDoyRange.Name = "cmdDoyRange"
        Me.cmdDoyRange.Size = New System.Drawing.Size(158, 39)
        Me.cmdDoyRange.TabIndex = 11
        Me.cmdDoyRange.Tag = ""
        Me.cmdDoyRange.Text = "Day Range"
        Me.cmdDoyRange.UseVisualStyleBackColor = True
        '
        'rdoVariableEvaporation
        '
        Me.rdoVariableEvaporation.AutoSize = True
        Me.rdoVariableEvaporation.Location = New System.Drawing.Point(334, 513)
        Me.rdoVariableEvaporation.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoVariableEvaporation.Name = "rdoVariableEvaporation"
        Me.rdoVariableEvaporation.Size = New System.Drawing.Size(92, 24)
        Me.rdoVariableEvaporation.TabIndex = 28
        Me.rdoVariableEvaporation.Text = "Variable"
        Me.rdoVariableEvaporation.UseVisualStyleBackColor = True
        '
        'rdoValueEvaporation
        '
        Me.rdoValueEvaporation.AutoSize = True
        Me.rdoValueEvaporation.Location = New System.Drawing.Point(144, 513)
        Me.rdoValueEvaporation.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoValueEvaporation.Name = "rdoValueEvaporation"
        Me.rdoValueEvaporation.Size = New System.Drawing.Size(75, 24)
        Me.rdoValueEvaporation.TabIndex = 26
        Me.rdoValueEvaporation.Text = "Value"
        Me.rdoValueEvaporation.UseVisualStyleBackColor = True
        '
        'grpEndofSeason
        '
        Me.grpEndofSeason.Controls.Add(Me.ucrInputFilled)
        Me.grpEndofSeason.Controls.Add(Me.ucrChkFilled)
        Me.grpEndofSeason.Controls.Add(Me.ucrInputEndofSeasonOccurence)
        Me.grpEndofSeason.Controls.Add(Me.ucrInputSeasonDoy)
        Me.grpEndofSeason.Controls.Add(Me.ucrInputEndofSeasonDate)
        Me.grpEndofSeason.Controls.Add(Me.ucrChkEndofSeasonOccurence)
        Me.grpEndofSeason.Controls.Add(Me.ucrChkEndofSeasonDate)
        Me.grpEndofSeason.Controls.Add(Me.ucrChkEndofSeasonDoy)
        Me.grpEndofSeason.Location = New System.Drawing.Point(4, 604)
        Me.grpEndofSeason.Margin = New System.Windows.Forms.Padding(4)
        Me.grpEndofSeason.Name = "grpEndofSeason"
        Me.grpEndofSeason.Padding = New System.Windows.Forms.Padding(4)
        Me.grpEndofSeason.Size = New System.Drawing.Size(708, 124)
        Me.grpEndofSeason.TabIndex = 32
        Me.grpEndofSeason.TabStop = False
        Me.grpEndofSeason.Text = "End of Season"
        '
        'ucrInputFilled
        '
        Me.ucrInputFilled.AddQuotesIfUnrecognised = True
        Me.ucrInputFilled.AutoSize = True
        Me.ucrInputFilled.IsMultiline = False
        Me.ucrInputFilled.IsReadOnly = False
        Me.ucrInputFilled.Location = New System.Drawing.Point(182, 80)
        Me.ucrInputFilled.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputFilled.Name = "ucrInputFilled"
        Me.ucrInputFilled.Size = New System.Drawing.Size(156, 32)
        Me.ucrInputFilled.TabIndex = 49
        '
        'ucrChkFilled
        '
        Me.ucrChkFilled.AutoSize = True
        Me.ucrChkFilled.Checked = False
        Me.ucrChkFilled.Location = New System.Drawing.Point(6, 80)
        Me.ucrChkFilled.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkFilled.Name = "ucrChkFilled"
        Me.ucrChkFilled.Size = New System.Drawing.Size(158, 34)
        Me.ucrChkFilled.TabIndex = 50
        '
        'ucrInputEndofSeasonOccurence
        '
        Me.ucrInputEndofSeasonOccurence.AddQuotesIfUnrecognised = True
        Me.ucrInputEndofSeasonOccurence.AutoSize = True
        Me.ucrInputEndofSeasonOccurence.IsMultiline = False
        Me.ucrInputEndofSeasonOccurence.IsReadOnly = False
        Me.ucrInputEndofSeasonOccurence.Location = New System.Drawing.Point(542, 22)
        Me.ucrInputEndofSeasonOccurence.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputEndofSeasonOccurence.Name = "ucrInputEndofSeasonOccurence"
        Me.ucrInputEndofSeasonOccurence.Size = New System.Drawing.Size(156, 32)
        Me.ucrInputEndofSeasonOccurence.TabIndex = 38
        '
        'ucrInputSeasonDoy
        '
        Me.ucrInputSeasonDoy.AddQuotesIfUnrecognised = True
        Me.ucrInputSeasonDoy.AutoSize = True
        Me.ucrInputSeasonDoy.IsMultiline = False
        Me.ucrInputSeasonDoy.IsReadOnly = False
        Me.ucrInputSeasonDoy.Location = New System.Drawing.Point(74, 22)
        Me.ucrInputSeasonDoy.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputSeasonDoy.Name = "ucrInputSeasonDoy"
        Me.ucrInputSeasonDoy.Size = New System.Drawing.Size(100, 32)
        Me.ucrInputSeasonDoy.TabIndex = 32
        '
        'ucrInputEndofSeasonDate
        '
        Me.ucrInputEndofSeasonDate.AddQuotesIfUnrecognised = True
        Me.ucrInputEndofSeasonDate.AutoSize = True
        Me.ucrInputEndofSeasonDate.IsMultiline = False
        Me.ucrInputEndofSeasonDate.IsReadOnly = False
        Me.ucrInputEndofSeasonDate.Location = New System.Drawing.Point(248, 22)
        Me.ucrInputEndofSeasonDate.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputEndofSeasonDate.Name = "ucrInputEndofSeasonDate"
        Me.ucrInputEndofSeasonDate.Size = New System.Drawing.Size(165, 32)
        Me.ucrInputEndofSeasonDate.TabIndex = 37
        '
        'ucrChkEndofSeasonOccurence
        '
        Me.ucrChkEndofSeasonOccurence.AutoSize = True
        Me.ucrChkEndofSeasonOccurence.Checked = False
        Me.ucrChkEndofSeasonOccurence.Location = New System.Drawing.Point(422, 26)
        Me.ucrChkEndofSeasonOccurence.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkEndofSeasonOccurence.Name = "ucrChkEndofSeasonOccurence"
        Me.ucrChkEndofSeasonOccurence.Size = New System.Drawing.Size(126, 51)
        Me.ucrChkEndofSeasonOccurence.TabIndex = 48
        '
        'ucrChkEndofSeasonDate
        '
        Me.ucrChkEndofSeasonDate.AutoSize = True
        Me.ucrChkEndofSeasonDate.Checked = False
        Me.ucrChkEndofSeasonDate.Location = New System.Drawing.Point(182, 24)
        Me.ucrChkEndofSeasonDate.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkEndofSeasonDate.Name = "ucrChkEndofSeasonDate"
        Me.ucrChkEndofSeasonDate.Size = New System.Drawing.Size(80, 51)
        Me.ucrChkEndofSeasonDate.TabIndex = 47
        '
        'ucrChkEndofSeasonDoy
        '
        Me.ucrChkEndofSeasonDoy.AutoSize = True
        Me.ucrChkEndofSeasonDoy.Checked = False
        Me.ucrChkEndofSeasonDoy.Location = New System.Drawing.Point(6, 24)
        Me.ucrChkEndofSeasonDoy.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkEndofSeasonDoy.Name = "ucrChkEndofSeasonDoy"
        Me.ucrChkEndofSeasonDoy.Size = New System.Drawing.Size(87, 51)
        Me.ucrChkEndofSeasonDoy.TabIndex = 46
        '
        'grpEndofRains
        '
        Me.grpEndofRains.Controls.Add(Me.ucrInputEndofRainsDate)
        Me.grpEndofRains.Controls.Add(Me.ucrInputEndofRainsOccurence)
        Me.grpEndofRains.Controls.Add(Me.ucrInputEndRainDoy)
        Me.grpEndofRains.Controls.Add(Me.ucrChkEndofRainsDoy)
        Me.grpEndofRains.Controls.Add(Me.ucrChkEndofRainsDate)
        Me.grpEndofRains.Controls.Add(Me.ucrChkEndofRainsOccurence)
        Me.grpEndofRains.Location = New System.Drawing.Point(4, 639)
        Me.grpEndofRains.Margin = New System.Windows.Forms.Padding(4)
        Me.grpEndofRains.Name = "grpEndofRains"
        Me.grpEndofRains.Padding = New System.Windows.Forms.Padding(4)
        Me.grpEndofRains.Size = New System.Drawing.Size(644, 60)
        Me.grpEndofRains.TabIndex = 18
        Me.grpEndofRains.TabStop = False
        Me.grpEndofRains.Text = "End of Rains"
        '
        'ucrInputEndofRainsDate
        '
        Me.ucrInputEndofRainsDate.AddQuotesIfUnrecognised = True
        Me.ucrInputEndofRainsDate.AutoSize = True
        Me.ucrInputEndofRainsDate.IsMultiline = False
        Me.ucrInputEndofRainsDate.IsReadOnly = False
        Me.ucrInputEndofRainsDate.Location = New System.Drawing.Point(248, 26)
        Me.ucrInputEndofRainsDate.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputEndofRainsDate.Name = "ucrInputEndofRainsDate"
        Me.ucrInputEndofRainsDate.Size = New System.Drawing.Size(140, 26)
        Me.ucrInputEndofRainsDate.TabIndex = 36
        '
        'ucrInputEndofRainsOccurence
        '
        Me.ucrInputEndofRainsOccurence.AddQuotesIfUnrecognised = True
        Me.ucrInputEndofRainsOccurence.AutoSize = True
        Me.ucrInputEndofRainsOccurence.IsMultiline = False
        Me.ucrInputEndofRainsOccurence.IsReadOnly = False
        Me.ucrInputEndofRainsOccurence.Location = New System.Drawing.Point(512, 24)
        Me.ucrInputEndofRainsOccurence.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputEndofRainsOccurence.Name = "ucrInputEndofRainsOccurence"
        Me.ucrInputEndofRainsOccurence.Size = New System.Drawing.Size(141, 30)
        Me.ucrInputEndofRainsOccurence.TabIndex = 39
        '
        'ucrInputEndRainDoy
        '
        Me.ucrInputEndRainDoy.AddQuotesIfUnrecognised = True
        Me.ucrInputEndRainDoy.AutoSize = True
        Me.ucrInputEndRainDoy.IsMultiline = False
        Me.ucrInputEndRainDoy.IsReadOnly = False
        Me.ucrInputEndRainDoy.Location = New System.Drawing.Point(75, 26)
        Me.ucrInputEndRainDoy.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputEndRainDoy.Name = "ucrInputEndRainDoy"
        Me.ucrInputEndRainDoy.Size = New System.Drawing.Size(98, 32)
        Me.ucrInputEndRainDoy.TabIndex = 50
        '
        'ucrChkEndofRainsDoy
        '
        Me.ucrChkEndofRainsDoy.AutoSize = True
        Me.ucrChkEndofRainsDoy.Checked = False
        Me.ucrChkEndofRainsDoy.Location = New System.Drawing.Point(8, 27)
        Me.ucrChkEndofRainsDoy.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkEndofRainsDoy.Name = "ucrChkEndofRainsDoy"
        Me.ucrChkEndofRainsDoy.Size = New System.Drawing.Size(90, 51)
        Me.ucrChkEndofRainsDoy.TabIndex = 49
        '
        'ucrChkEndofRainsDate
        '
        Me.ucrChkEndofRainsDate.AutoSize = True
        Me.ucrChkEndofRainsDate.Checked = False
        Me.ucrChkEndofRainsDate.Location = New System.Drawing.Point(177, 26)
        Me.ucrChkEndofRainsDate.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkEndofRainsDate.Name = "ucrChkEndofRainsDate"
        Me.ucrChkEndofRainsDate.Size = New System.Drawing.Size(78, 51)
        Me.ucrChkEndofRainsDate.TabIndex = 48
        '
        'ucrChkEndofRainsOccurence
        '
        Me.ucrChkEndofRainsOccurence.AutoSize = True
        Me.ucrChkEndofRainsOccurence.Checked = False
        Me.ucrChkEndofRainsOccurence.Location = New System.Drawing.Point(396, 24)
        Me.ucrChkEndofRainsOccurence.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkEndofRainsOccurence.Name = "ucrChkEndofRainsOccurence"
        Me.ucrChkEndofRainsOccurence.Size = New System.Drawing.Size(136, 51)
        Me.ucrChkEndofRainsOccurence.TabIndex = 47
        '
        'rdoEndOfSeasons
        '
        Me.rdoEndOfSeasons.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoEndOfSeasons.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEndOfSeasons.FlatAppearance.BorderSize = 2
        Me.rdoEndOfSeasons.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEndOfSeasons.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoEndOfSeasons.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoEndOfSeasons.Location = New System.Drawing.Point(326, 15)
        Me.rdoEndOfSeasons.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoEndOfSeasons.Name = "rdoEndOfSeasons"
        Me.rdoEndOfSeasons.Size = New System.Drawing.Size(195, 40)
        Me.rdoEndOfSeasons.TabIndex = 36
        Me.rdoEndOfSeasons.Text = "End of Season"
        Me.rdoEndOfSeasons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoEndOfSeasons.UseVisualStyleBackColor = True
        '
        'rdoEndOfRains
        '
        Me.rdoEndOfRains.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoEndOfRains.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEndOfRains.FlatAppearance.BorderSize = 2
        Me.rdoEndOfRains.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEndOfRains.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoEndOfRains.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoEndOfRains.Location = New System.Drawing.Point(134, 15)
        Me.rdoEndOfRains.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoEndOfRains.Name = "rdoEndOfRains"
        Me.rdoEndOfRains.Size = New System.Drawing.Size(195, 40)
        Me.rdoEndOfRains.TabIndex = 35
        Me.rdoEndOfRains.Text = "End of Rains"
        Me.rdoEndOfRains.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoEndOfRains.UseVisualStyleBackColor = True
        '
        'ucrPnlEndOfRainsAndSeasons
        '
        Me.ucrPnlEndOfRainsAndSeasons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlEndOfRainsAndSeasons.Location = New System.Drawing.Point(118, 14)
        Me.ucrPnlEndOfRainsAndSeasons.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlEndOfRainsAndSeasons.Name = "ucrPnlEndOfRainsAndSeasons"
        Me.ucrPnlEndOfRainsAndSeasons.Size = New System.Drawing.Size(410, 52)
        Me.ucrPnlEndOfRainsAndSeasons.TabIndex = 34
        '
        'ucrReceiverEvaporation
        '
        Me.ucrReceiverEvaporation.AutoSize = True
        Me.ucrReceiverEvaporation.frmParent = Me
        Me.ucrReceiverEvaporation.Location = New System.Drawing.Point(430, 513)
        Me.ucrReceiverEvaporation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEvaporation.Name = "ucrReceiverEvaporation"
        Me.ucrReceiverEvaporation.Selector = Nothing
        Me.ucrReceiverEvaporation.Size = New System.Drawing.Size(210, 30)
        Me.ucrReceiverEvaporation.strNcFilePath = ""
        Me.ucrReceiverEvaporation.TabIndex = 29
        Me.ucrReceiverEvaporation.ucrSelector = Nothing
        '
        'ucrInputEvaporation
        '
        Me.ucrInputEvaporation.AddQuotesIfUnrecognised = True
        Me.ucrInputEvaporation.AutoSize = True
        Me.ucrInputEvaporation.IsMultiline = False
        Me.ucrInputEvaporation.IsReadOnly = False
        Me.ucrInputEvaporation.Location = New System.Drawing.Point(230, 513)
        Me.ucrInputEvaporation.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputEvaporation.Name = "ucrInputEvaporation"
        Me.ucrInputEvaporation.Size = New System.Drawing.Size(96, 32)
        Me.ucrInputEvaporation.TabIndex = 27
        '
        'ucrPnlEvaporation
        '
        Me.ucrPnlEvaporation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlEvaporation.Location = New System.Drawing.Point(144, 506)
        Me.ucrPnlEvaporation.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlEvaporation.Name = "ucrPnlEvaporation"
        Me.ucrPnlEvaporation.Size = New System.Drawing.Size(518, 40)
        Me.ucrPnlEvaporation.TabIndex = 25
        '
        'ucrInputFilterPreview
        '
        Me.ucrInputFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterPreview.AutoSize = True
        Me.ucrInputFilterPreview.IsMultiline = False
        Me.ucrInputFilterPreview.IsReadOnly = True
        Me.ucrInputFilterPreview.Location = New System.Drawing.Point(196, 410)
        Me.ucrInputFilterPreview.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        Me.ucrInputFilterPreview.Size = New System.Drawing.Size(363, 33)
        Me.ucrInputFilterPreview.TabIndex = 12
        '
        'ucrNudTotalOverDays
        '
        Me.ucrNudTotalOverDays.AutoSize = True
        Me.ucrNudTotalOverDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTotalOverDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTotalOverDays.Location = New System.Drawing.Point(350, 462)
        Me.ucrNudTotalOverDays.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudTotalOverDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTotalOverDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTotalOverDays.Name = "ucrNudTotalOverDays"
        Me.ucrNudTotalOverDays.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudTotalOverDays.TabIndex = 17
        Me.ucrNudTotalOverDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudAmount
        '
        Me.ucrNudAmount.AutoSize = True
        Me.ucrNudAmount.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAmount.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAmount.Location = New System.Drawing.Point(102, 462)
        Me.ucrNudAmount.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudAmount.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAmount.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAmount.Name = "ucrNudAmount"
        Me.ucrNudAmount.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudAmount.TabIndex = 15
        Me.ucrNudAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudWBLessThan
        '
        Me.ucrNudWBLessThan.AutoSize = True
        Me.ucrNudWBLessThan.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWBLessThan.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWBLessThan.Location = New System.Drawing.Point(351, 462)
        Me.ucrNudWBLessThan.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudWBLessThan.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWBLessThan.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWBLessThan.Name = "ucrNudWBLessThan"
        Me.ucrNudWBLessThan.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudWBLessThan.TabIndex = 23
        Me.ucrNudWBLessThan.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudCapacity
        '
        Me.ucrNudCapacity.AutoSize = True
        Me.ucrNudCapacity.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCapacity.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCapacity.Location = New System.Drawing.Point(104, 462)
        Me.ucrNudCapacity.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudCapacity.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCapacity.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCapacity.Name = "ucrNudCapacity"
        Me.ucrNudCapacity.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudCapacity.TabIndex = 21
        Me.ucrNudCapacity.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(464, 88)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(214, 30)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 2
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(464, 225)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(214, 30)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 6
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(464, 156)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(214, 30)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 4
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.AutoSize = True
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(464, 291)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(214, 30)
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.TabIndex = 8
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrReceiverRainfall
        '
        Me.ucrReceiverRainfall.AutoSize = True
        Me.ucrReceiverRainfall.frmParent = Me
        Me.ucrReceiverRainfall.Location = New System.Drawing.Point(464, 357)
        Me.ucrReceiverRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainfall.Name = "ucrReceiverRainfall"
        Me.ucrReceiverRainfall.Selector = Nothing
        Me.ucrReceiverRainfall.Size = New System.Drawing.Size(214, 30)
        Me.ucrReceiverRainfall.strNcFilePath = ""
        Me.ucrReceiverRainfall.TabIndex = 10
        Me.ucrReceiverRainfall.ucrSelector = Nothing
        '
        'ucrSelectorForWaterBalance
        '
        Me.ucrSelectorForWaterBalance.AutoSize = True
        Me.ucrSelectorForWaterBalance.bDropUnusedFilterLevels = False
        Me.ucrSelectorForWaterBalance.bShowHiddenColumns = False
        Me.ucrSelectorForWaterBalance.bUseCurrentFilter = True
        Me.ucrSelectorForWaterBalance.Location = New System.Drawing.Point(4, 104)
        Me.ucrSelectorForWaterBalance.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForWaterBalance.Name = "ucrSelectorForWaterBalance"
        Me.ucrSelectorForWaterBalance.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorForWaterBalance.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(4, 779)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 33
        '
        'ucrNudWB
        '
        Me.ucrNudWB.AutoSize = True
        Me.ucrNudWB.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWB.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWB.Location = New System.Drawing.Point(189, 561)
        Me.ucrNudWB.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudWB.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWB.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWB.Name = "ucrNudWB"
        Me.ucrNudWB.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudWB.TabIndex = 47
        Me.ucrNudWB.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkWB
        '
        Me.ucrChkWB.AutoSize = True
        Me.ucrChkWB.Checked = False
        Me.ucrChkWB.Location = New System.Drawing.Point(26, 561)
        Me.ucrChkWB.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkWB.Name = "ucrChkWB"
        Me.ucrChkWB.Size = New System.Drawing.Size(150, 34)
        Me.ucrChkWB.TabIndex = 46
        '
        'ucrSaveObject
        '
        Me.ucrSaveObject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveObject.Location = New System.Drawing.Point(9, 735)
        Me.ucrSaveObject.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveObject.Name = "ucrSaveObject"
        Me.ucrSaveObject.Size = New System.Drawing.Size(550, 36)
        Me.ucrSaveObject.TabIndex = 49
        '
        'dlgEndOfRainsSeason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(716, 860)
        Me.Controls.Add(Me.ucrSaveObject)
        Me.Controls.Add(Me.ucrReceiverEvaporation)
        Me.Controls.Add(Me.ucrInputEvaporation)
        Me.Controls.Add(Me.ucrNudWB)
        Me.Controls.Add(Me.ucrChkWB)
        Me.Controls.Add(Me.rdoEndOfSeasons)
        Me.Controls.Add(Me.rdoEndOfRains)
        Me.Controls.Add(Me.ucrPnlEndOfRainsAndSeasons)
        Me.Controls.Add(Me.rdoVariableEvaporation)
        Me.Controls.Add(Me.grpEndofSeason)
        Me.Controls.Add(Me.rdoValueEvaporation)
        Me.Controls.Add(Me.ucrPnlEvaporation)
        Me.Controls.Add(Me.ucrInputFilterPreview)
        Me.Controls.Add(Me.cmdDoyRange)
        Me.Controls.Add(Me.ucrNudTotalOverDays)
        Me.Controls.Add(Me.lblTotalOverDays)
        Me.Controls.Add(Me.ucrNudAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblEvaporation)
        Me.Controls.Add(Me.ucrNudWBLessThan)
        Me.Controls.Add(Me.lblWaterBalanceLessThan)
        Me.Controls.Add(Me.lblCapacity)
        Me.Controls.Add(Me.ucrNudCapacity)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverDOY)
        Me.Controls.Add(Me.lblDOY)
        Me.Controls.Add(Me.lblRainfall)
        Me.Controls.Add(Me.ucrReceiverRainfall)
        Me.Controls.Add(Me.ucrSelectorForWaterBalance)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpEndofRains)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
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

    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblEvaporation As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents lblDOY As Label
    Friend WithEvents lblCapacity As Label
    Friend WithEvents lblRainfall As Label
    Friend WithEvents ucrReceiverRainfall As ucrReceiverSingle
    Friend WithEvents ucrSelectorForWaterBalance As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents lblAmount As Label
    Friend WithEvents ucrNudAmount As ucrNud
    Friend WithEvents lblTotalOverDays As Label
    Friend WithEvents ucrNudTotalOverDays As ucrNud
    Friend WithEvents ucrNudWBLessThan As ucrNud
    Friend WithEvents ucrNudCapacity As ucrNud
    Friend WithEvents ucrInputSeasonDoy As ucrInputTextBox
    Friend WithEvents lblWaterBalanceLessThan As Label
    Friend WithEvents ucrInputFilterPreview As ucrInputTextBox
    Friend WithEvents cmdDoyRange As Button
    Friend WithEvents ucrReceiverEvaporation As ucrReceiverSingle
    Friend WithEvents rdoVariableEvaporation As RadioButton
    Friend WithEvents rdoValueEvaporation As RadioButton
    Friend WithEvents ucrPnlEvaporation As UcrPanel
    Friend WithEvents ucrInputEndofRainsOccurence As ucrInputTextBox
    Friend WithEvents ucrInputEndofSeasonOccurence As ucrInputTextBox
    Friend WithEvents ucrInputEndofSeasonDate As ucrInputTextBox
    Friend WithEvents ucrInputEndofRainsDate As ucrInputTextBox
    Friend WithEvents grpEndofSeason As GroupBox
    Friend WithEvents grpEndofRains As GroupBox
    Friend WithEvents ucrChkEndofSeasonDoy As ucrCheck
    Friend WithEvents ucrChkEndofSeasonOccurence As ucrCheck
    Friend WithEvents ucrChkEndofSeasonDate As ucrCheck
    Friend WithEvents ucrChkEndofRainsDoy As ucrCheck
    Friend WithEvents ucrChkEndofRainsDate As ucrCheck
    Friend WithEvents ucrChkEndofRainsOccurence As ucrCheck
    Friend WithEvents ucrInputEndRainDoy As ucrInputTextBox
    Friend WithEvents rdoEndOfSeasons As RadioButton
    Friend WithEvents rdoEndOfRains As RadioButton
    Friend WithEvents ucrPnlEndOfRainsAndSeasons As UcrPanel
    Friend WithEvents ucrInputEvaporation As ucrInputTextBox
    Friend WithEvents ucrNudWB As ucrNud
    Friend WithEvents ucrChkWB As ucrCheck
    Friend WithEvents ucrInputFilled As ucrInputTextBox
    Friend WithEvents ucrChkFilled As ucrCheck
    Friend WithEvents ucrSaveObject As ucrSave
End Class