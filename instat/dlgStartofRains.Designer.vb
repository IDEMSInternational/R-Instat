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
        Me.ucrInputThreshold = New instat.ucrInputComboBox()
        Me.lblRainfall = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDOY = New System.Windows.Forms.Label()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.ucrInputNewStatusColumnName = New instat.ucrInputTextBox()
        Me.ucrChkAsDate = New instat.ucrCheck()
        Me.ucrChkStatus = New instat.ucrCheck()
        Me.ucrInputNewDateColumnName = New instat.ucrInputTextBox()
        Me.ucrSelectorForStartofRains = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputNewDoyColumnName = New instat.ucrInputTextBox()
        Me.ucrChkAsDoy = New instat.ucrCheck()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverRainfall = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputFilterPreview = New instat.ucrInputTextBox()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.grpConditionsForSatrtofRains = New System.Windows.Forms.GroupBox()
        Me.cmdAdditionnal = New System.Windows.Forms.Button()
        Me.ucrChkAdditional = New instat.ucrCheck()
        Me.ucrReceiverEvap = New instat.ucrReceiverSingle()
        Me.lblFraction = New System.Windows.Forms.Label()
        Me.ucrNudEvapo = New instat.ucrNud()
        Me.rdoEvapo = New System.Windows.Forms.RadioButton()
        Me.lblTROverDays = New System.Windows.Forms.Label()
        Me.ucrNudTROverDays = New instat.ucrNud()
        Me.ucrNudTRAmount = New instat.ucrNud()
        Me.lblTRVal = New System.Windows.Forms.Label()
        Me.ucrChkTotalRainfall = New instat.ucrCheck()
        Me.ucrNudTRPercentile = New instat.ucrNud()
        Me.rdoTRAmount = New System.Windows.Forms.RadioButton()
        Me.rdoTRPercentile = New System.Windows.Forms.RadioButton()
        Me.ucrPnlTRCalculateBy = New instat.UcrPanel()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.grpRainParameters = New System.Windows.Forms.GroupBox()
        Me.cmdDoyRange = New System.Windows.Forms.Button()
        Me.ucrSaveDefinitionsObject = New instat.ucrSave()
        Me.ucrChkDefinitions = New instat.ucrCheck()
        Me.grpDisplay.SuspendLayout()
        Me.grpConditionsForSatrtofRains.SuspendLayout()
        Me.grpRainParameters.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrInputThreshold
        '
        Me.ucrInputThreshold.AddQuotesIfUnrecognised = True
        Me.ucrInputThreshold.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputThreshold.GetSetSelectedIndex = -1
        Me.ucrInputThreshold.IsReadOnly = False
        Me.ucrInputThreshold.Location = New System.Drawing.Point(105, 14)
        Me.ucrInputThreshold.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputThreshold.Name = "ucrInputThreshold"
        Me.ucrInputThreshold.Size = New System.Drawing.Size(93, 32)
        Me.ucrInputThreshold.TabIndex = 13
        '
        'lblRainfall
        '
        Me.lblRainfall.AutoSize = True
        Me.lblRainfall.Location = New System.Drawing.Point(440, 280)
        Me.lblRainfall.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRainfall.Name = "lblRainfall"
        Me.lblRainfall.Size = New System.Drawing.Size(104, 20)
        Me.lblRainfall.TabIndex = 62
        Me.lblRainfall.Text = "Rain Column:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(440, 22)
        Me.lblStation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(64, 20)
        Me.lblStation.TabIndex = 54
        Me.lblStation.Text = "Station:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(440, 152)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(47, 20)
        Me.lblYear.TabIndex = 58
        Me.lblYear.Text = "Year:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(440, 87)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 20)
        Me.lblDate.TabIndex = 56
        Me.lblDate.Text = "Date:"
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.Location = New System.Drawing.Point(440, 216)
        Me.lblDOY.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(97, 20)
        Me.lblDOY.TabIndex = 60
        Me.lblDOY.Text = "Day of Year:"
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.ucrInputNewStatusColumnName)
        Me.grpDisplay.Controls.Add(Me.ucrChkAsDate)
        Me.grpDisplay.Controls.Add(Me.ucrChkStatus)
        Me.grpDisplay.Controls.Add(Me.ucrInputNewDateColumnName)
        Me.grpDisplay.Location = New System.Drawing.Point(20, 684)
        Me.grpDisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDisplay.Size = New System.Drawing.Size(802, 74)
        Me.grpDisplay.TabIndex = 66
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Display"
        '
        'ucrInputNewStatusColumnName
        '
        Me.ucrInputNewStatusColumnName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewStatusColumnName.AutoSize = True
        Me.ucrInputNewStatusColumnName.IsMultiline = False
        Me.ucrInputNewStatusColumnName.IsReadOnly = False
        Me.ucrInputNewStatusColumnName.Location = New System.Drawing.Point(668, 27)
        Me.ucrInputNewStatusColumnName.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputNewStatusColumnName.Name = "ucrInputNewStatusColumnName"
        Me.ucrInputNewStatusColumnName.Size = New System.Drawing.Size(130, 32)
        Me.ucrInputNewStatusColumnName.TabIndex = 51
        '
        'ucrChkAsDate
        '
        Me.ucrChkAsDate.AutoSize = True
        Me.ucrChkAsDate.Checked = False
        Me.ucrChkAsDate.Location = New System.Drawing.Point(320, 27)
        Me.ucrChkAsDate.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkAsDate.Name = "ucrChkAsDate"
        Me.ucrChkAsDate.Size = New System.Drawing.Size(76, 51)
        Me.ucrChkAsDate.TabIndex = 48
        '
        'ucrChkStatus
        '
        Me.ucrChkStatus.AutoSize = True
        Me.ucrChkStatus.Checked = False
        Me.ucrChkStatus.Location = New System.Drawing.Point(534, 27)
        Me.ucrChkStatus.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkStatus.Name = "ucrChkStatus"
        Me.ucrChkStatus.Size = New System.Drawing.Size(126, 51)
        Me.ucrChkStatus.TabIndex = 50
        '
        'ucrInputNewDateColumnName
        '
        Me.ucrInputNewDateColumnName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewDateColumnName.AutoSize = True
        Me.ucrInputNewDateColumnName.IsMultiline = False
        Me.ucrInputNewDateColumnName.IsReadOnly = False
        Me.ucrInputNewDateColumnName.Location = New System.Drawing.Point(400, 27)
        Me.ucrInputNewDateColumnName.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputNewDateColumnName.Name = "ucrInputNewDateColumnName"
        Me.ucrInputNewDateColumnName.Size = New System.Drawing.Size(128, 32)
        Me.ucrInputNewDateColumnName.TabIndex = 49
        '
        'ucrSelectorForStartofRains
        '
        Me.ucrSelectorForStartofRains.AutoSize = True
        Me.ucrSelectorForStartofRains.bDropUnusedFilterLevels = False
        Me.ucrSelectorForStartofRains.bShowHiddenColumns = False
        Me.ucrSelectorForStartofRains.bUseCurrentFilter = True
        Me.ucrSelectorForStartofRains.Location = New System.Drawing.Point(21, 9)
        Me.ucrSelectorForStartofRains.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForStartofRains.Name = "ucrSelectorForStartofRains"
        Me.ucrSelectorForStartofRains.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorForStartofRains.TabIndex = 53
        '
        'ucrInputNewDoyColumnName
        '
        Me.ucrInputNewDoyColumnName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewDoyColumnName.AutoSize = True
        Me.ucrInputNewDoyColumnName.IsMultiline = False
        Me.ucrInputNewDoyColumnName.IsReadOnly = False
        Me.ucrInputNewDoyColumnName.Location = New System.Drawing.Point(194, 724)
        Me.ucrInputNewDoyColumnName.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputNewDoyColumnName.Name = "ucrInputNewDoyColumnName"
        Me.ucrInputNewDoyColumnName.Size = New System.Drawing.Size(132, 32)
        Me.ucrInputNewDoyColumnName.TabIndex = 68
        '
        'ucrChkAsDoy
        '
        Me.ucrChkAsDoy.AutoSize = True
        Me.ucrChkAsDoy.Checked = False
        Me.ucrChkAsDoy.Location = New System.Drawing.Point(30, 724)
        Me.ucrChkAsDoy.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkAsDoy.Name = "ucrChkAsDoy"
        Me.ucrChkAsDoy.Size = New System.Drawing.Size(162, 34)
        Me.ucrChkAsDoy.TabIndex = 67
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(435, 46)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(214, 30)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 55
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(435, 111)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(214, 30)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 57
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(435, 176)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(214, 30)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 59
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverRainfall
        '
        Me.ucrReceiverRainfall.AutoSize = True
        Me.ucrReceiverRainfall.frmParent = Me
        Me.ucrReceiverRainfall.Location = New System.Drawing.Point(435, 304)
        Me.ucrReceiverRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainfall.Name = "ucrReceiverRainfall"
        Me.ucrReceiverRainfall.Selector = Nothing
        Me.ucrReceiverRainfall.Size = New System.Drawing.Size(214, 30)
        Me.ucrReceiverRainfall.strNcFilePath = ""
        Me.ucrReceiverRainfall.TabIndex = 63
        Me.ucrReceiverRainfall.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(21, 820)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 69
        '
        'ucrInputFilterPreview
        '
        Me.ucrInputFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterPreview.AutoSize = True
        Me.ucrInputFilterPreview.IsMultiline = False
        Me.ucrInputFilterPreview.IsReadOnly = True
        Me.ucrInputFilterPreview.Location = New System.Drawing.Point(416, 16)
        Me.ucrInputFilterPreview.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        Me.ucrInputFilterPreview.Size = New System.Drawing.Size(363, 33)
        Me.ucrInputFilterPreview.TabIndex = 15
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.AutoSize = True
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(435, 240)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(214, 30)
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.TabIndex = 61
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'grpConditionsForSatrtofRains
        '
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.cmdAdditionnal)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrChkAdditional)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrReceiverEvap)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.lblFraction)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrNudEvapo)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.rdoEvapo)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.lblTROverDays)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrNudTROverDays)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrNudTRAmount)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.lblTRVal)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrChkTotalRainfall)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrNudTRPercentile)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.rdoTRAmount)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.rdoTRPercentile)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.ucrPnlTRCalculateBy)
        Me.grpConditionsForSatrtofRains.Location = New System.Drawing.Point(20, 401)
        Me.grpConditionsForSatrtofRains.Margin = New System.Windows.Forms.Padding(4)
        Me.grpConditionsForSatrtofRains.Name = "grpConditionsForSatrtofRains"
        Me.grpConditionsForSatrtofRains.Padding = New System.Windows.Forms.Padding(4)
        Me.grpConditionsForSatrtofRains.Size = New System.Drawing.Size(802, 278)
        Me.grpConditionsForSatrtofRains.TabIndex = 65
        Me.grpConditionsForSatrtofRains.TabStop = False
        Me.grpConditionsForSatrtofRains.Text = "Conditions for Start of Rains"
        '
        'cmdAdditionnal
        '
        Me.cmdAdditionnal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAdditionnal.Location = New System.Drawing.Point(238, 220)
        Me.cmdAdditionnal.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAdditionnal.Name = "cmdAdditionnal"
        Me.cmdAdditionnal.Size = New System.Drawing.Size(158, 39)
        Me.cmdAdditionnal.TabIndex = 16
        Me.cmdAdditionnal.Tag = ""
        Me.cmdAdditionnal.Text = "Add"
        Me.cmdAdditionnal.UseVisualStyleBackColor = True
        '
        'ucrChkAdditional
        '
        Me.ucrChkAdditional.AutoSize = True
        Me.ucrChkAdditional.Checked = False
        Me.ucrChkAdditional.Location = New System.Drawing.Point(6, 226)
        Me.ucrChkAdditional.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkAdditional.Name = "ucrChkAdditional"
        Me.ucrChkAdditional.Size = New System.Drawing.Size(214, 51)
        Me.ucrChkAdditional.TabIndex = 45
        '
        'ucrReceiverEvap
        '
        Me.ucrReceiverEvap.AutoSize = True
        Me.ucrReceiverEvap.frmParent = Me
        Me.ucrReceiverEvap.Location = New System.Drawing.Point(434, 122)
        Me.ucrReceiverEvap.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEvap.Name = "ucrReceiverEvap"
        Me.ucrReceiverEvap.Selector = Nothing
        Me.ucrReceiverEvap.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverEvap.strNcFilePath = ""
        Me.ucrReceiverEvap.TabIndex = 24
        Me.ucrReceiverEvap.ucrSelector = Nothing
        '
        'lblFraction
        '
        Me.lblFraction.AutoSize = True
        Me.lblFraction.Location = New System.Drawing.Point(628, 124)
        Me.lblFraction.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFraction.Name = "lblFraction"
        Me.lblFraction.Size = New System.Drawing.Size(71, 20)
        Me.lblFraction.TabIndex = 25
        Me.lblFraction.Text = "Fraction:"
        '
        'ucrNudEvapo
        '
        Me.ucrNudEvapo.AutoSize = True
        Me.ucrNudEvapo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudEvapo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudEvapo.Location = New System.Drawing.Point(726, 117)
        Me.ucrNudEvapo.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudEvapo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudEvapo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudEvapo.Name = "ucrNudEvapo"
        Me.ucrNudEvapo.Size = New System.Drawing.Size(63, 30)
        Me.ucrNudEvapo.TabIndex = 26
        Me.ucrNudEvapo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoEvapo
        '
        Me.rdoEvapo.AutoSize = True
        Me.rdoEvapo.Location = New System.Drawing.Point(298, 124)
        Me.rdoEvapo.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoEvapo.Name = "rdoEvapo"
        Me.rdoEvapo.Size = New System.Drawing.Size(119, 24)
        Me.rdoEvapo.TabIndex = 23
        Me.rdoEvapo.TabStop = True
        Me.rdoEvapo.Text = "Evaporation"
        Me.rdoEvapo.UseVisualStyleBackColor = True
        '
        'lblTROverDays
        '
        Me.lblTROverDays.AutoSize = True
        Me.lblTROverDays.Location = New System.Drawing.Point(216, 38)
        Me.lblTROverDays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTROverDays.Name = "lblTROverDays"
        Me.lblTROverDays.Size = New System.Drawing.Size(86, 20)
        Me.lblTROverDays.TabIndex = 18
        Me.lblTROverDays.Tag = ""
        Me.lblTROverDays.Text = "Over Days:"
        '
        'ucrNudTROverDays
        '
        Me.ucrNudTROverDays.AutoSize = True
        Me.ucrNudTROverDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTROverDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTROverDays.Location = New System.Drawing.Point(315, 32)
        Me.ucrNudTROverDays.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudTROverDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTROverDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTROverDays.Name = "ucrNudTROverDays"
        Me.ucrNudTROverDays.Size = New System.Drawing.Size(63, 30)
        Me.ucrNudTROverDays.TabIndex = 19
        Me.ucrNudTROverDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTRAmount
        '
        Me.ucrNudTRAmount.AutoSize = True
        Me.ucrNudTRAmount.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTRAmount.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTRAmount.Location = New System.Drawing.Point(434, 87)
        Me.ucrNudTRAmount.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudTRAmount.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTRAmount.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTRAmount.Name = "ucrNudTRAmount"
        Me.ucrNudTRAmount.Size = New System.Drawing.Size(63, 30)
        Me.ucrNudTRAmount.TabIndex = 22
        Me.ucrNudTRAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblTRVal
        '
        Me.lblTRVal.AutoSize = True
        Me.lblTRVal.Location = New System.Drawing.Point(30, 90)
        Me.lblTRVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTRVal.Name = "lblTRVal"
        Me.lblTRVal.Size = New System.Drawing.Size(54, 20)
        Me.lblTRVal.TabIndex = 20
        Me.lblTRVal.Text = "Value:"
        '
        'ucrChkTotalRainfall
        '
        Me.ucrChkTotalRainfall.AutoSize = True
        Me.ucrChkTotalRainfall.Checked = False
        Me.ucrChkTotalRainfall.Location = New System.Drawing.Point(6, 33)
        Me.ucrChkTotalRainfall.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkTotalRainfall.Name = "ucrChkTotalRainfall"
        Me.ucrChkTotalRainfall.Size = New System.Drawing.Size(196, 51)
        Me.ucrChkTotalRainfall.TabIndex = 17
        '
        'ucrNudTRPercentile
        '
        Me.ucrNudTRPercentile.AutoSize = True
        Me.ucrNudTRPercentile.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTRPercentile.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTRPercentile.Location = New System.Drawing.Point(434, 164)
        Me.ucrNudTRPercentile.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudTRPercentile.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTRPercentile.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTRPercentile.Name = "ucrNudTRPercentile"
        Me.ucrNudTRPercentile.Size = New System.Drawing.Size(63, 30)
        Me.ucrNudTRPercentile.TabIndex = 28
        Me.ucrNudTRPercentile.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoTRAmount
        '
        Me.rdoTRAmount.AutoSize = True
        Me.rdoTRAmount.Location = New System.Drawing.Point(298, 90)
        Me.rdoTRAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoTRAmount.Name = "rdoTRAmount"
        Me.rdoTRAmount.Size = New System.Drawing.Size(90, 24)
        Me.rdoTRAmount.TabIndex = 21
        Me.rdoTRAmount.TabStop = True
        Me.rdoTRAmount.Text = "Amount"
        Me.rdoTRAmount.UseVisualStyleBackColor = True
        '
        'rdoTRPercentile
        '
        Me.rdoTRPercentile.AutoSize = True
        Me.rdoTRPercentile.Location = New System.Drawing.Point(298, 164)
        Me.rdoTRPercentile.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoTRPercentile.Name = "rdoTRPercentile"
        Me.rdoTRPercentile.Size = New System.Drawing.Size(104, 24)
        Me.rdoTRPercentile.TabIndex = 27
        Me.rdoTRPercentile.TabStop = True
        Me.rdoTRPercentile.Text = "Percentile"
        Me.rdoTRPercentile.UseVisualStyleBackColor = True
        '
        'ucrPnlTRCalculateBy
        '
        Me.ucrPnlTRCalculateBy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlTRCalculateBy.Location = New System.Drawing.Point(195, 82)
        Me.ucrPnlTRCalculateBy.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlTRCalculateBy.Name = "ucrPnlTRCalculateBy"
        Me.ucrPnlTRCalculateBy.Size = New System.Drawing.Size(248, 112)
        Me.ucrPnlTRCalculateBy.TabIndex = 4
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(15, 18)
        Me.lblThreshold.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(83, 20)
        Me.lblThreshold.TabIndex = 12
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Threshold:"
        '
        'grpRainParameters
        '
        Me.grpRainParameters.Controls.Add(Me.ucrInputThreshold)
        Me.grpRainParameters.Controls.Add(Me.ucrInputFilterPreview)
        Me.grpRainParameters.Controls.Add(Me.cmdDoyRange)
        Me.grpRainParameters.Controls.Add(Me.lblThreshold)
        Me.grpRainParameters.Location = New System.Drawing.Point(20, 333)
        Me.grpRainParameters.Margin = New System.Windows.Forms.Padding(4)
        Me.grpRainParameters.Name = "grpRainParameters"
        Me.grpRainParameters.Padding = New System.Windows.Forms.Padding(4)
        Me.grpRainParameters.Size = New System.Drawing.Size(802, 60)
        Me.grpRainParameters.TabIndex = 64
        Me.grpRainParameters.TabStop = False
        '
        'cmdDoyRange
        '
        Me.cmdDoyRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDoyRange.Location = New System.Drawing.Point(238, 12)
        Me.cmdDoyRange.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDoyRange.Name = "cmdDoyRange"
        Me.cmdDoyRange.Size = New System.Drawing.Size(158, 39)
        Me.cmdDoyRange.TabIndex = 14
        Me.cmdDoyRange.Tag = ""
        Me.cmdDoyRange.Text = "Day Range"
        Me.cmdDoyRange.UseVisualStyleBackColor = True
        '
        'ucrSaveDefinitionsObject
        '
        Me.ucrSaveDefinitionsObject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveDefinitionsObject.Location = New System.Drawing.Point(218, 773)
        Me.ucrSaveDefinitionsObject.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveDefinitionsObject.Name = "ucrSaveDefinitionsObject"
        Me.ucrSaveDefinitionsObject.Size = New System.Drawing.Size(257, 36)
        Me.ucrSaveDefinitionsObject.TabIndex = 71
        '
        'ucrChkDefinitions
        '
        Me.ucrChkDefinitions.AutoSize = True
        Me.ucrChkDefinitions.Checked = False
        Me.ucrChkDefinitions.Location = New System.Drawing.Point(21, 773)
        Me.ucrChkDefinitions.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkDefinitions.Name = "ucrChkDefinitions"
        Me.ucrChkDefinitions.Size = New System.Drawing.Size(182, 34)
        Me.ucrChkDefinitions.TabIndex = 70
        '
        'dlgStartofRains
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(832, 903)
        Me.Controls.Add(Me.ucrSaveDefinitionsObject)
        Me.Controls.Add(Me.ucrChkDefinitions)
        Me.Controls.Add(Me.lblRainfall)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblDOY)
        Me.Controls.Add(Me.ucrSelectorForStartofRains)
        Me.Controls.Add(Me.ucrInputNewDoyColumnName)
        Me.Controls.Add(Me.ucrChkAsDoy)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverRainfall)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverDOY)
        Me.Controls.Add(Me.grpConditionsForSatrtofRains)
        Me.Controls.Add(Me.grpRainParameters)
        Me.Controls.Add(Me.grpDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStartofRains"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start of Rains"
        Me.grpDisplay.ResumeLayout(False)
        Me.grpDisplay.PerformLayout()
        Me.grpConditionsForSatrtofRains.ResumeLayout(False)
        Me.grpConditionsForSatrtofRains.PerformLayout()
        Me.grpRainParameters.ResumeLayout(False)
        Me.grpRainParameters.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrInputThreshold As ucrInputComboBox
    Friend WithEvents lblRainfall As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblDOY As Label
    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents ucrInputNewStatusColumnName As ucrInputTextBox
    Friend WithEvents ucrChkAsDate As ucrCheck
    Friend WithEvents ucrChkStatus As ucrCheck
    Friend WithEvents ucrInputNewDateColumnName As ucrInputTextBox
    Friend WithEvents ucrSelectorForStartofRains As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputNewDoyColumnName As ucrInputTextBox
    Friend WithEvents ucrChkAsDoy As ucrCheck
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverRainfall As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents grpConditionsForSatrtofRains As GroupBox
    Friend WithEvents cmdAdditionnal As Button
    Friend WithEvents ucrChkAdditional As ucrCheck
    Friend WithEvents ucrReceiverEvap As ucrReceiverSingle
    Friend WithEvents lblFraction As Label
    Friend WithEvents ucrNudEvapo As ucrNud
    Friend WithEvents rdoEvapo As RadioButton
    Friend WithEvents lblTROverDays As Label
    Friend WithEvents ucrNudTROverDays As ucrNud
    Friend WithEvents ucrNudTRAmount As ucrNud
    Friend WithEvents lblTRVal As Label
    Friend WithEvents ucrChkTotalRainfall As ucrCheck
    Friend WithEvents ucrNudTRPercentile As ucrNud
    Friend WithEvents rdoTRAmount As RadioButton
    Friend WithEvents rdoTRPercentile As RadioButton
    Friend WithEvents ucrPnlTRCalculateBy As UcrPanel
    Friend WithEvents grpRainParameters As GroupBox
    Friend WithEvents ucrInputFilterPreview As ucrInputTextBox
    Friend WithEvents cmdDoyRange As Button
    Friend WithEvents lblThreshold As Label
    Friend WithEvents ucrSaveDefinitionsObject As ucrSave
    Friend WithEvents ucrChkDefinitions As ucrCheck
End Class