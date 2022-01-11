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
        Me.lblReplaceNA = New System.Windows.Forms.Label()
        Me.grpEndofSeason = New System.Windows.Forms.GroupBox()
        Me.ucrChkEndofSeasonOccurence = New instat.ucrCheck()
        Me.ucrChkEndofSeasonDate = New instat.ucrCheck()
        Me.ucrChkEndofSeasonDoy = New instat.ucrCheck()
        Me.ucrInputSeasonDoy = New instat.ucrInputTextBox()
        Me.ucrInputEndofSeasonDate = New instat.ucrInputTextBox()
        Me.ucrInputEndofSeasonOccurence = New instat.ucrInputTextBox()
        Me.grpEndofRains = New System.Windows.Forms.GroupBox()
        Me.ucrInputEndRainDoy = New instat.ucrInputTextBox()
        Me.ucrChkEndofRainsDoy = New instat.ucrCheck()
        Me.ucrChkEndofRainsDate = New instat.ucrCheck()
        Me.ucrChkEndofRainsOccurence = New instat.ucrCheck()
        Me.ucrInputEndofRainsDate = New instat.ucrInputTextBox()
        Me.ucrInputEndofRainsOccurence = New instat.ucrInputTextBox()
        Me.rdoEndOfSeasons = New System.Windows.Forms.RadioButton()
        Me.rdoEndOfRains = New System.Windows.Forms.RadioButton()
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
        Me.grpEndofSeason.SuspendLayout()
        Me.grpEndofRains.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(271, 137)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 5
        Me.lblYear.Text = "Year:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(271, 91)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date:"
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.Location = New System.Drawing.Point(271, 181)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(66, 13)
        Me.lblDOY.TabIndex = 7
        Me.lblDOY.Text = "Day of Year:"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(16, 310)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(51, 13)
        Me.lblCapacity.TabIndex = 20
        Me.lblCapacity.Tag = "Capacity:"
        Me.lblCapacity.Text = "Capacity:"
        '
        'lblRainfall
        '
        Me.lblRainfall.AutoSize = True
        Me.lblRainfall.Location = New System.Drawing.Point(271, 225)
        Me.lblRainfall.Name = "lblRainfall"
        Me.lblRainfall.Size = New System.Drawing.Size(70, 13)
        Me.lblRainfall.TabIndex = 9
        Me.lblRainfall.Text = "Rain Column:"
        '
        'lblEvaporation
        '
        Me.lblEvaporation.AutoSize = True
        Me.lblEvaporation.Location = New System.Drawing.Point(25, 345)
        Me.lblEvaporation.Name = "lblEvaporation"
        Me.lblEvaporation.Size = New System.Drawing.Size(67, 13)
        Me.lblEvaporation.TabIndex = 24
        Me.lblEvaporation.Text = "Evaporation:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(271, 46)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 1
        Me.lblStation.Text = "Station:"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(15, 310)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(46, 13)
        Me.lblAmount.TabIndex = 14
        Me.lblAmount.Text = "Amount:"
        '
        'lblTotalOverDays
        '
        Me.lblTotalOverDays.AutoSize = True
        Me.lblTotalOverDays.Location = New System.Drawing.Point(161, 310)
        Me.lblTotalOverDays.Name = "lblTotalOverDays"
        Me.lblTotalOverDays.Size = New System.Drawing.Size(66, 13)
        Me.lblTotalOverDays.TabIndex = 16
        Me.lblTotalOverDays.Text = "Over Day(s):"
        '
        'lblWaterBalanceLessThan
        '
        Me.lblWaterBalanceLessThan.AutoSize = True
        Me.lblWaterBalanceLessThan.Location = New System.Drawing.Point(135, 310)
        Me.lblWaterBalanceLessThan.Name = "lblWaterBalanceLessThan"
        Me.lblWaterBalanceLessThan.Size = New System.Drawing.Size(93, 13)
        Me.lblWaterBalanceLessThan.TabIndex = 22
        Me.lblWaterBalanceLessThan.Tag = "Water Balance <="
        Me.lblWaterBalanceLessThan.Text = "Water Balance <="
        '
        'cmdDoyRange
        '
        Me.cmdDoyRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDoyRange.Location = New System.Drawing.Point(22, 270)
        Me.cmdDoyRange.Name = "cmdDoyRange"
        Me.cmdDoyRange.Size = New System.Drawing.Size(105, 26)
        Me.cmdDoyRange.TabIndex = 11
        Me.cmdDoyRange.Tag = ""
        Me.cmdDoyRange.Text = "Day Range"
        Me.cmdDoyRange.UseVisualStyleBackColor = True
        '
        'rdoVariableEvaporation
        '
        Me.rdoVariableEvaporation.AutoSize = True
        Me.rdoVariableEvaporation.Location = New System.Drawing.Point(107, 370)
        Me.rdoVariableEvaporation.Name = "rdoVariableEvaporation"
        Me.rdoVariableEvaporation.Size = New System.Drawing.Size(66, 17)
        Me.rdoVariableEvaporation.TabIndex = 28
        Me.rdoVariableEvaporation.Text = "Variable:"
        Me.rdoVariableEvaporation.UseVisualStyleBackColor = True
        '
        'rdoValueEvaporation
        '
        Me.rdoValueEvaporation.AutoSize = True
        Me.rdoValueEvaporation.Location = New System.Drawing.Point(107, 343)
        Me.rdoValueEvaporation.Name = "rdoValueEvaporation"
        Me.rdoValueEvaporation.Size = New System.Drawing.Size(55, 17)
        Me.rdoValueEvaporation.TabIndex = 26
        Me.rdoValueEvaporation.Text = "Value:"
        Me.rdoValueEvaporation.UseVisualStyleBackColor = True
        '
        'lblReplaceNA
        '
        Me.lblReplaceNA.AutoSize = True
        Me.lblReplaceNA.Location = New System.Drawing.Point(81, 402)
        Me.lblReplaceNA.Name = "lblReplaceNA"
        Me.lblReplaceNA.Size = New System.Drawing.Size(90, 13)
        Me.lblReplaceNA.TabIndex = 30
        Me.lblReplaceNA.Text = "Replace NA with:"
        '
        'grpEndofSeason
        '
        Me.grpEndofSeason.Controls.Add(Me.ucrChkEndofSeasonOccurence)
        Me.grpEndofSeason.Controls.Add(Me.ucrChkEndofSeasonDate)
        Me.grpEndofSeason.Controls.Add(Me.ucrChkEndofSeasonDoy)
        Me.grpEndofSeason.Controls.Add(Me.ucrInputSeasonDoy)
        Me.grpEndofSeason.Controls.Add(Me.ucrInputEndofSeasonDate)
        Me.grpEndofSeason.Controls.Add(Me.ucrInputEndofSeasonOccurence)
        Me.grpEndofSeason.Location = New System.Drawing.Point(3, 426)
        Me.grpEndofSeason.Name = "grpEndofSeason"
        Me.grpEndofSeason.Size = New System.Drawing.Size(428, 42)
        Me.grpEndofSeason.TabIndex = 32
        Me.grpEndofSeason.TabStop = False
        Me.grpEndofSeason.Text = "End of Season"
        '
        'ucrChkEndofSeasonOccurence
        '
        Me.ucrChkEndofSeasonOccurence.AutoSize = True
        Me.ucrChkEndofSeasonOccurence.Checked = False
        Me.ucrChkEndofSeasonOccurence.Location = New System.Drawing.Point(261, 18)
        Me.ucrChkEndofSeasonOccurence.Name = "ucrChkEndofSeasonOccurence"
        Me.ucrChkEndofSeasonOccurence.Size = New System.Drawing.Size(70, 23)
        Me.ucrChkEndofSeasonOccurence.TabIndex = 48
        '
        'ucrChkEndofSeasonDate
        '
        Me.ucrChkEndofSeasonDate.AutoSize = True
        Me.ucrChkEndofSeasonDate.Checked = False
        Me.ucrChkEndofSeasonDate.Location = New System.Drawing.Point(134, 18)
        Me.ucrChkEndofSeasonDate.Name = "ucrChkEndofSeasonDate"
        Me.ucrChkEndofSeasonDate.Size = New System.Drawing.Size(53, 23)
        Me.ucrChkEndofSeasonDate.TabIndex = 47
        '
        'ucrChkEndofSeasonDoy
        '
        Me.ucrChkEndofSeasonDoy.AutoSize = True
        Me.ucrChkEndofSeasonDoy.Checked = False
        Me.ucrChkEndofSeasonDoy.Location = New System.Drawing.Point(4, 18)
        Me.ucrChkEndofSeasonDoy.Name = "ucrChkEndofSeasonDoy"
        Me.ucrChkEndofSeasonDoy.Size = New System.Drawing.Size(58, 23)
        Me.ucrChkEndofSeasonDoy.TabIndex = 46
        '
        'ucrInputSeasonDoy
        '
        Me.ucrInputSeasonDoy.AddQuotesIfUnrecognised = True
        Me.ucrInputSeasonDoy.AutoSize = True
        Me.ucrInputSeasonDoy.IsMultiline = False
        Me.ucrInputSeasonDoy.IsReadOnly = False
        Me.ucrInputSeasonDoy.Location = New System.Drawing.Point(65, 17)
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
        Me.ucrInputEndofSeasonDate.Location = New System.Drawing.Point(188, 17)
        Me.ucrInputEndofSeasonDate.Name = "ucrInputEndofSeasonDate"
        Me.ucrInputEndofSeasonDate.Size = New System.Drawing.Size(72, 21)
        Me.ucrInputEndofSeasonDate.TabIndex = 37
        '
        'ucrInputEndofSeasonOccurence
        '
        Me.ucrInputEndofSeasonOccurence.AddQuotesIfUnrecognised = True
        Me.ucrInputEndofSeasonOccurence.AutoSize = True
        Me.ucrInputEndofSeasonOccurence.IsMultiline = False
        Me.ucrInputEndofSeasonOccurence.IsReadOnly = False
        Me.ucrInputEndofSeasonOccurence.Location = New System.Drawing.Point(333, 17)
        Me.ucrInputEndofSeasonOccurence.Name = "ucrInputEndofSeasonOccurence"
        Me.ucrInputEndofSeasonOccurence.Size = New System.Drawing.Size(93, 21)
        Me.ucrInputEndofSeasonOccurence.TabIndex = 38
        '
        'grpEndofRains
        '
        Me.grpEndofRains.Controls.Add(Me.ucrInputEndRainDoy)
        Me.grpEndofRains.Controls.Add(Me.ucrChkEndofRainsDoy)
        Me.grpEndofRains.Controls.Add(Me.ucrChkEndofRainsDate)
        Me.grpEndofRains.Controls.Add(Me.ucrChkEndofRainsOccurence)
        Me.grpEndofRains.Controls.Add(Me.ucrInputEndofRainsDate)
        Me.grpEndofRains.Controls.Add(Me.ucrInputEndofRainsOccurence)
        Me.grpEndofRains.Location = New System.Drawing.Point(3, 426)
        Me.grpEndofRains.Name = "grpEndofRains"
        Me.grpEndofRains.Size = New System.Drawing.Size(429, 40)
        Me.grpEndofRains.TabIndex = 18
        Me.grpEndofRains.TabStop = False
        Me.grpEndofRains.Text = "End of Rains"
        '
        'ucrInputEndRainDoy
        '
        Me.ucrInputEndRainDoy.AddQuotesIfUnrecognised = True
        Me.ucrInputEndRainDoy.AutoSize = True
        Me.ucrInputEndRainDoy.IsMultiline = False
        Me.ucrInputEndRainDoy.IsReadOnly = False
        Me.ucrInputEndRainDoy.Location = New System.Drawing.Point(68, 17)
        Me.ucrInputEndRainDoy.Name = "ucrInputEndRainDoy"
        Me.ucrInputEndRainDoy.Size = New System.Drawing.Size(67, 21)
        Me.ucrInputEndRainDoy.TabIndex = 50
        '
        'ucrChkEndofRainsDoy
        '
        Me.ucrChkEndofRainsDoy.AutoSize = True
        Me.ucrChkEndofRainsDoy.Checked = False
        Me.ucrChkEndofRainsDoy.Location = New System.Drawing.Point(5, 18)
        Me.ucrChkEndofRainsDoy.Name = "ucrChkEndofRainsDoy"
        Me.ucrChkEndofRainsDoy.Size = New System.Drawing.Size(60, 23)
        Me.ucrChkEndofRainsDoy.TabIndex = 49
        '
        'ucrChkEndofRainsDate
        '
        Me.ucrChkEndofRainsDate.AutoSize = True
        Me.ucrChkEndofRainsDate.Checked = False
        Me.ucrChkEndofRainsDate.Location = New System.Drawing.Point(140, 18)
        Me.ucrChkEndofRainsDate.Name = "ucrChkEndofRainsDate"
        Me.ucrChkEndofRainsDate.Size = New System.Drawing.Size(52, 23)
        Me.ucrChkEndofRainsDate.TabIndex = 48
        '
        'ucrChkEndofRainsOccurence
        '
        Me.ucrChkEndofRainsOccurence.AutoSize = True
        Me.ucrChkEndofRainsOccurence.Checked = False
        Me.ucrChkEndofRainsOccurence.Location = New System.Drawing.Point(264, 18)
        Me.ucrChkEndofRainsOccurence.Name = "ucrChkEndofRainsOccurence"
        Me.ucrChkEndofRainsOccurence.Size = New System.Drawing.Size(77, 23)
        Me.ucrChkEndofRainsOccurence.TabIndex = 47
        '
        'ucrInputEndofRainsDate
        '
        Me.ucrInputEndofRainsDate.AddQuotesIfUnrecognised = True
        Me.ucrInputEndofRainsDate.AutoSize = True
        Me.ucrInputEndofRainsDate.IsMultiline = False
        Me.ucrInputEndofRainsDate.IsReadOnly = False
        Me.ucrInputEndofRainsDate.Location = New System.Drawing.Point(193, 17)
        Me.ucrInputEndofRainsDate.Name = "ucrInputEndofRainsDate"
        Me.ucrInputEndofRainsDate.Size = New System.Drawing.Size(67, 21)
        Me.ucrInputEndofRainsDate.TabIndex = 36
        '
        'ucrInputEndofRainsOccurence
        '
        Me.ucrInputEndofRainsOccurence.AddQuotesIfUnrecognised = True
        Me.ucrInputEndofRainsOccurence.AutoSize = True
        Me.ucrInputEndofRainsOccurence.IsMultiline = False
        Me.ucrInputEndofRainsOccurence.IsReadOnly = False
        Me.ucrInputEndofRainsOccurence.Location = New System.Drawing.Point(346, 17)
        Me.ucrInputEndofRainsOccurence.Name = "ucrInputEndofRainsOccurence"
        Me.ucrInputEndofRainsOccurence.Size = New System.Drawing.Size(79, 21)
        Me.ucrInputEndofRainsOccurence.TabIndex = 39
        '
        'rdoEndOfSeasons
        '
        Me.rdoEndOfSeasons.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoEndOfSeasons.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEndOfSeasons.FlatAppearance.BorderSize = 2
        Me.rdoEndOfSeasons.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEndOfSeasons.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoEndOfSeasons.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoEndOfSeasons.Location = New System.Drawing.Point(217, 10)
        Me.rdoEndOfSeasons.Name = "rdoEndOfSeasons"
        Me.rdoEndOfSeasons.Size = New System.Drawing.Size(130, 27)
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
        Me.rdoEndOfRains.Location = New System.Drawing.Point(89, 10)
        Me.rdoEndOfRains.Name = "rdoEndOfRains"
        Me.rdoEndOfRains.Size = New System.Drawing.Size(130, 27)
        Me.rdoEndOfRains.TabIndex = 35
        Me.rdoEndOfRains.Text = "End of Rains"
        Me.rdoEndOfRains.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoEndOfRains.UseVisualStyleBackColor = True
        '
        'ucrPnlEndOfRainsAndSeasons
        '
        Me.ucrPnlEndOfRainsAndSeasons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlEndOfRainsAndSeasons.Location = New System.Drawing.Point(79, 9)
        Me.ucrPnlEndOfRainsAndSeasons.Name = "ucrPnlEndOfRainsAndSeasons"
        Me.ucrPnlEndOfRainsAndSeasons.Size = New System.Drawing.Size(273, 35)
        Me.ucrPnlEndOfRainsAndSeasons.TabIndex = 34
        '
        'ucrInputReplaceNA
        '
        Me.ucrInputReplaceNA.AddQuotesIfUnrecognised = True
        Me.ucrInputReplaceNA.AutoSize = True
        Me.ucrInputReplaceNA.IsMultiline = False
        Me.ucrInputReplaceNA.IsReadOnly = False
        Me.ucrInputReplaceNA.Location = New System.Drawing.Point(176, 397)
        Me.ucrInputReplaceNA.Name = "ucrInputReplaceNA"
        Me.ucrInputReplaceNA.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputReplaceNA.TabIndex = 31
        '
        'ucrReceiverEvaporation
        '
        Me.ucrReceiverEvaporation.AutoSize = True
        Me.ucrReceiverEvaporation.frmParent = Me
        Me.ucrReceiverEvaporation.Location = New System.Drawing.Point(176, 370)
        Me.ucrReceiverEvaporation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEvaporation.Name = "ucrReceiverEvaporation"
        Me.ucrReceiverEvaporation.Selector = Nothing
        Me.ucrReceiverEvaporation.Size = New System.Drawing.Size(139, 20)
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
        Me.ucrInputEvaporation.Location = New System.Drawing.Point(176, 343)
        Me.ucrInputEvaporation.Name = "ucrInputEvaporation"
        Me.ucrInputEvaporation.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputEvaporation.TabIndex = 27
        '
        'ucrPnlEvaporation
        '
        Me.ucrPnlEvaporation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlEvaporation.Location = New System.Drawing.Point(107, 337)
        Me.ucrPnlEvaporation.Name = "ucrPnlEvaporation"
        Me.ucrPnlEvaporation.Size = New System.Drawing.Size(67, 62)
        Me.ucrPnlEvaporation.TabIndex = 25
        '
        'ucrInputFilterPreview
        '
        Me.ucrInputFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterPreview.AutoSize = True
        Me.ucrInputFilterPreview.IsMultiline = False
        Me.ucrInputFilterPreview.IsReadOnly = True
        Me.ucrInputFilterPreview.Location = New System.Drawing.Point(131, 273)
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        Me.ucrInputFilterPreview.Size = New System.Drawing.Size(242, 22)
        Me.ucrInputFilterPreview.TabIndex = 12
        '
        'ucrNudTotalOverDays
        '
        Me.ucrNudTotalOverDays.AutoSize = True
        Me.ucrNudTotalOverDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTotalOverDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTotalOverDays.Location = New System.Drawing.Point(233, 308)
        Me.ucrNudTotalOverDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTotalOverDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTotalOverDays.Name = "ucrNudTotalOverDays"
        Me.ucrNudTotalOverDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTotalOverDays.TabIndex = 17
        Me.ucrNudTotalOverDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudAmount
        '
        Me.ucrNudAmount.AutoSize = True
        Me.ucrNudAmount.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAmount.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAmount.Location = New System.Drawing.Point(68, 308)
        Me.ucrNudAmount.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAmount.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAmount.Name = "ucrNudAmount"
        Me.ucrNudAmount.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAmount.TabIndex = 15
        Me.ucrNudAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudWBLessThan
        '
        Me.ucrNudWBLessThan.AutoSize = True
        Me.ucrNudWBLessThan.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWBLessThan.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWBLessThan.Location = New System.Drawing.Point(234, 308)
        Me.ucrNudWBLessThan.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWBLessThan.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWBLessThan.Name = "ucrNudWBLessThan"
        Me.ucrNudWBLessThan.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWBLessThan.TabIndex = 23
        Me.ucrNudWBLessThan.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudCapacity
        '
        Me.ucrNudCapacity.AutoSize = True
        Me.ucrNudCapacity.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCapacity.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCapacity.Location = New System.Drawing.Point(69, 308)
        Me.ucrNudCapacity.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCapacity.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCapacity.Name = "ucrNudCapacity"
        Me.ucrNudCapacity.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCapacity.TabIndex = 21
        Me.ucrNudCapacity.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(274, 59)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 2
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(274, 150)
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
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(274, 104)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 4
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.AutoSize = True
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(274, 194)
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
        Me.ucrReceiverRainfall.Location = New System.Drawing.Point(274, 238)
        Me.ucrReceiverRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainfall.Name = "ucrReceiverRainfall"
        Me.ucrReceiverRainfall.Selector = Nothing
        Me.ucrReceiverRainfall.Size = New System.Drawing.Size(143, 20)
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
        Me.ucrSelectorForWaterBalance.Location = New System.Drawing.Point(3, 69)
        Me.ucrSelectorForWaterBalance.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForWaterBalance.Name = "ucrSelectorForWaterBalance"
        Me.ucrSelectorForWaterBalance.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForWaterBalance.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(3, 472)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 33
        '
        'dlgEndOfRainsSeason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(435, 533)
        Me.Controls.Add(Me.rdoEndOfSeasons)
        Me.Controls.Add(Me.rdoEndOfRains)
        Me.Controls.Add(Me.ucrPnlEndOfRainsAndSeasons)
        Me.Controls.Add(Me.ucrInputReplaceNA)
        Me.Controls.Add(Me.lblReplaceNA)
        Me.Controls.Add(Me.rdoVariableEvaporation)
        Me.Controls.Add(Me.grpEndofSeason)
        Me.Controls.Add(Me.rdoValueEvaporation)
        Me.Controls.Add(Me.ucrReceiverEvaporation)
        Me.Controls.Add(Me.ucrInputEvaporation)
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
    Friend WithEvents ucrInputReplaceNA As ucrInputTextBox
    Friend WithEvents lblReplaceNA As Label
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
End Class