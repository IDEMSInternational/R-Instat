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
        Me.ucrChkAsDoy = New instat.ucrCheck()
        Me.ucrInputNewDoyColumnName = New instat.ucrInputTextBox()
        Me.grpTemDisplay = New System.Windows.Forms.GroupBox()
        Me.grpWinter = New System.Windows.Forms.GroupBox()
        Me.ucrInputDayWinter = New instat.ucrInputTextBox()
        Me.ucrInputOccuWinter = New instat.ucrInputTextBox()
        Me.ucrChkDateWinter = New instat.ucrCheck()
        Me.ucrChkOccuWinter = New instat.ucrCheck()
        Me.ucrInputDateWinter = New instat.ucrInputTextBox()
        Me.ucrChkDayWinter = New instat.ucrCheck()
        Me.ucrInputTextTempday = New instat.ucrInputTextBox()
        Me.ucrInputTextTemOccu = New instat.ucrInputTextBox()
        Me.ucrChkTemDate = New instat.ucrCheck()
        Me.ucrChkTemOccu = New instat.ucrCheck()
        Me.ucrInputTextTemdate = New instat.ucrInputTextBox()
        Me.ucrChkTemDay = New instat.ucrCheck()
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
        Me.ucrNudTotalOverDays = New instat.ucrNud()
        Me.lblTotalOverDays = New System.Windows.Forms.Label()
        Me.ucrNudAmount = New instat.ucrNud()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.grpTem = New System.Windows.Forms.GroupBox()
        Me.lblTmax = New System.Windows.Forms.Label()
        Me.ucrReceiverTmax = New instat.ucrReceiverSingle()
        Me.lblTmin = New System.Windows.Forms.Label()
        Me.ucrReceiverTmin = New instat.ucrReceiverSingle()
        Me.rdoWinter = New System.Windows.Forms.RadioButton()
        Me.rdoSummer = New System.Windows.Forms.RadioButton()
        Me.ucrPnlTem = New instat.UcrPanel()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.grpRainParameters = New System.Windows.Forms.GroupBox()
        Me.ucrInputThreshold = New instat.ucrInputComboBox()
        Me.ucrInputFilterPreview = New instat.ucrInputTextBox()
        Me.cmdDoyRange = New System.Windows.Forms.Button()
        Me.ucrSaveDefinition = New instat.ucrSave()
        Me.ucrSelectorForStartofRains = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverRainfall = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrPnlStart = New instat.UcrPanel()
        Me.rdoTemperature = New System.Windows.Forms.RadioButton()
        Me.rdoRain = New System.Windows.Forms.RadioButton()
        Me.lblTem = New System.Windows.Forms.Label()
        Me.ucrReceiverTem = New instat.ucrReceiverSingle()
        Me.ucrSaveDefinitionTem = New instat.ucrSave()
        Me.ucrSaveDefinitionwinter = New instat.ucrSave()
        Me.grpDisplay.SuspendLayout()
        Me.grpTemDisplay.SuspendLayout()
        Me.grpWinter.SuspendLayout()
        Me.grpConditionsForSatrtofRains.SuspendLayout()
        Me.grpTem.SuspendLayout()
        Me.grpRainParameters.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRainfall
        '
        Me.lblRainfall.AutoSize = True
        Me.lblRainfall.Location = New System.Drawing.Point(293, 219)
        Me.lblRainfall.Name = "lblRainfall"
        Me.lblRainfall.Size = New System.Drawing.Size(70, 13)
        Me.lblRainfall.TabIndex = 62
        Me.lblRainfall.Text = "Rain Column:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(293, 47)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 54
        Me.lblStation.Text = "Station:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(293, 133)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 58
        Me.lblYear.Text = "Year:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(293, 90)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 56
        Me.lblDate.Text = "Date:"
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.Location = New System.Drawing.Point(293, 176)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(66, 13)
        Me.lblDOY.TabIndex = 60
        Me.lblDOY.Text = "Day of Year:"
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.ucrInputNewStatusColumnName)
        Me.grpDisplay.Controls.Add(Me.ucrChkAsDate)
        Me.grpDisplay.Controls.Add(Me.ucrChkStatus)
        Me.grpDisplay.Controls.Add(Me.ucrInputNewDateColumnName)
        Me.grpDisplay.Controls.Add(Me.ucrChkAsDoy)
        Me.grpDisplay.Controls.Add(Me.ucrInputNewDoyColumnName)
        Me.grpDisplay.Location = New System.Drawing.Point(13, 487)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(535, 43)
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
        Me.ucrInputNewStatusColumnName.Location = New System.Drawing.Point(443, 15)
        Me.ucrInputNewStatusColumnName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputNewStatusColumnName.Name = "ucrInputNewStatusColumnName"
        Me.ucrInputNewStatusColumnName.Size = New System.Drawing.Size(87, 21)
        Me.ucrInputNewStatusColumnName.TabIndex = 51
        '
        'ucrChkAsDate
        '
        Me.ucrChkAsDate.AutoSize = True
        Me.ucrChkAsDate.Checked = False
        Me.ucrChkAsDate.Location = New System.Drawing.Point(184, 15)
        Me.ucrChkAsDate.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkAsDate.Name = "ucrChkAsDate"
        Me.ucrChkAsDate.Size = New System.Drawing.Size(51, 23)
        Me.ucrChkAsDate.TabIndex = 48
        '
        'ucrChkStatus
        '
        Me.ucrChkStatus.AutoSize = True
        Me.ucrChkStatus.Checked = False
        Me.ucrChkStatus.Location = New System.Drawing.Point(356, 15)
        Me.ucrChkStatus.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkStatus.Name = "ucrChkStatus"
        Me.ucrChkStatus.Size = New System.Drawing.Size(84, 24)
        Me.ucrChkStatus.TabIndex = 50
        '
        'ucrInputNewDateColumnName
        '
        Me.ucrInputNewDateColumnName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewDateColumnName.AutoSize = True
        Me.ucrInputNewDateColumnName.IsMultiline = False
        Me.ucrInputNewDateColumnName.IsReadOnly = False
        Me.ucrInputNewDateColumnName.Location = New System.Drawing.Point(238, 15)
        Me.ucrInputNewDateColumnName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputNewDateColumnName.Name = "ucrInputNewDateColumnName"
        Me.ucrInputNewDateColumnName.Size = New System.Drawing.Size(85, 21)
        Me.ucrInputNewDateColumnName.TabIndex = 49
        '
        'ucrChkAsDoy
        '
        Me.ucrChkAsDoy.AutoSize = True
        Me.ucrChkAsDoy.Checked = False
        Me.ucrChkAsDoy.Location = New System.Drawing.Point(5, 15)
        Me.ucrChkAsDoy.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkAsDoy.Name = "ucrChkAsDoy"
        Me.ucrChkAsDoy.Size = New System.Drawing.Size(51, 23)
        Me.ucrChkAsDoy.TabIndex = 67
        '
        'ucrInputNewDoyColumnName
        '
        Me.ucrInputNewDoyColumnName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewDoyColumnName.AutoSize = True
        Me.ucrInputNewDoyColumnName.IsMultiline = False
        Me.ucrInputNewDoyColumnName.IsReadOnly = False
        Me.ucrInputNewDoyColumnName.Location = New System.Drawing.Point(59, 13)
        Me.ucrInputNewDoyColumnName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputNewDoyColumnName.Name = "ucrInputNewDoyColumnName"
        Me.ucrInputNewDoyColumnName.Size = New System.Drawing.Size(88, 21)
        Me.ucrInputNewDoyColumnName.TabIndex = 68
        '
        'grpTemDisplay
        '
        Me.grpTemDisplay.Controls.Add(Me.ucrInputTextTempday)
        Me.grpTemDisplay.Controls.Add(Me.ucrInputTextTemOccu)
        Me.grpTemDisplay.Controls.Add(Me.ucrChkTemDate)
        Me.grpTemDisplay.Controls.Add(Me.ucrChkTemOccu)
        Me.grpTemDisplay.Controls.Add(Me.ucrInputTextTemdate)
        Me.grpTemDisplay.Controls.Add(Me.ucrChkTemDay)
        Me.grpTemDisplay.Location = New System.Drawing.Point(13, 486)
        Me.grpTemDisplay.Name = "grpTemDisplay"
        Me.grpTemDisplay.Size = New System.Drawing.Size(535, 43)
        Me.grpTemDisplay.TabIndex = 68
        Me.grpTemDisplay.TabStop = False
        Me.grpTemDisplay.Text = "Display"
        '
        'grpWinter
        '
        Me.grpWinter.Controls.Add(Me.ucrInputDayWinter)
        Me.grpWinter.Controls.Add(Me.ucrInputOccuWinter)
        Me.grpWinter.Controls.Add(Me.ucrChkDateWinter)
        Me.grpWinter.Controls.Add(Me.ucrChkOccuWinter)
        Me.grpWinter.Controls.Add(Me.ucrInputDateWinter)
        Me.grpWinter.Controls.Add(Me.ucrChkDayWinter)
        Me.grpWinter.Location = New System.Drawing.Point(12, 489)
        Me.grpWinter.Name = "grpWinter"
        Me.grpWinter.Size = New System.Drawing.Size(535, 43)
        Me.grpWinter.TabIndex = 76
        Me.grpWinter.TabStop = False
        Me.grpWinter.Text = "Display"
        '
        'ucrInputDayWinter
        '
        Me.ucrInputDayWinter.AddQuotesIfUnrecognised = True
        Me.ucrInputDayWinter.AutoSize = True
        Me.ucrInputDayWinter.IsMultiline = False
        Me.ucrInputDayWinter.IsReadOnly = False
        Me.ucrInputDayWinter.Location = New System.Drawing.Point(61, 14)
        Me.ucrInputDayWinter.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputDayWinter.Name = "ucrInputDayWinter"
        Me.ucrInputDayWinter.Size = New System.Drawing.Size(88, 21)
        Me.ucrInputDayWinter.TabIndex = 75
        '
        'ucrInputOccuWinter
        '
        Me.ucrInputOccuWinter.AddQuotesIfUnrecognised = True
        Me.ucrInputOccuWinter.AutoSize = True
        Me.ucrInputOccuWinter.IsMultiline = False
        Me.ucrInputOccuWinter.IsReadOnly = False
        Me.ucrInputOccuWinter.Location = New System.Drawing.Point(443, 15)
        Me.ucrInputOccuWinter.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputOccuWinter.Name = "ucrInputOccuWinter"
        Me.ucrInputOccuWinter.Size = New System.Drawing.Size(87, 21)
        Me.ucrInputOccuWinter.TabIndex = 51
        '
        'ucrChkDateWinter
        '
        Me.ucrChkDateWinter.AutoSize = True
        Me.ucrChkDateWinter.Checked = False
        Me.ucrChkDateWinter.Location = New System.Drawing.Point(184, 15)
        Me.ucrChkDateWinter.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkDateWinter.Name = "ucrChkDateWinter"
        Me.ucrChkDateWinter.Size = New System.Drawing.Size(51, 23)
        Me.ucrChkDateWinter.TabIndex = 48
        '
        'ucrChkOccuWinter
        '
        Me.ucrChkOccuWinter.AutoSize = True
        Me.ucrChkOccuWinter.Checked = False
        Me.ucrChkOccuWinter.Location = New System.Drawing.Point(356, 15)
        Me.ucrChkOccuWinter.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkOccuWinter.Name = "ucrChkOccuWinter"
        Me.ucrChkOccuWinter.Size = New System.Drawing.Size(84, 24)
        Me.ucrChkOccuWinter.TabIndex = 50
        '
        'ucrInputDateWinter
        '
        Me.ucrInputDateWinter.AddQuotesIfUnrecognised = True
        Me.ucrInputDateWinter.AutoSize = True
        Me.ucrInputDateWinter.IsMultiline = False
        Me.ucrInputDateWinter.IsReadOnly = False
        Me.ucrInputDateWinter.Location = New System.Drawing.Point(238, 15)
        Me.ucrInputDateWinter.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputDateWinter.Name = "ucrInputDateWinter"
        Me.ucrInputDateWinter.Size = New System.Drawing.Size(85, 21)
        Me.ucrInputDateWinter.TabIndex = 49
        '
        'ucrChkDayWinter
        '
        Me.ucrChkDayWinter.AutoSize = True
        Me.ucrChkDayWinter.Checked = False
        Me.ucrChkDayWinter.Location = New System.Drawing.Point(5, 15)
        Me.ucrChkDayWinter.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkDayWinter.Name = "ucrChkDayWinter"
        Me.ucrChkDayWinter.Size = New System.Drawing.Size(51, 23)
        Me.ucrChkDayWinter.TabIndex = 67
        '
        'ucrInputTextTempday
        '
        Me.ucrInputTextTempday.AddQuotesIfUnrecognised = True
        Me.ucrInputTextTempday.AutoSize = True
        Me.ucrInputTextTempday.IsMultiline = False
        Me.ucrInputTextTempday.IsReadOnly = False
        Me.ucrInputTextTempday.Location = New System.Drawing.Point(61, 14)
        Me.ucrInputTextTempday.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputTextTempday.Name = "ucrInputTextTempday"
        Me.ucrInputTextTempday.Size = New System.Drawing.Size(88, 21)
        Me.ucrInputTextTempday.TabIndex = 75
        '
        'ucrInputTextTemOccu
        '
        Me.ucrInputTextTemOccu.AddQuotesIfUnrecognised = True
        Me.ucrInputTextTemOccu.AutoSize = True
        Me.ucrInputTextTemOccu.IsMultiline = False
        Me.ucrInputTextTemOccu.IsReadOnly = False
        Me.ucrInputTextTemOccu.Location = New System.Drawing.Point(443, 15)
        Me.ucrInputTextTemOccu.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputTextTemOccu.Name = "ucrInputTextTemOccu"
        Me.ucrInputTextTemOccu.Size = New System.Drawing.Size(87, 21)
        Me.ucrInputTextTemOccu.TabIndex = 51
        '
        'ucrChkTemDate
        '
        Me.ucrChkTemDate.AutoSize = True
        Me.ucrChkTemDate.Checked = False
        Me.ucrChkTemDate.Location = New System.Drawing.Point(184, 15)
        Me.ucrChkTemDate.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkTemDate.Name = "ucrChkTemDate"
        Me.ucrChkTemDate.Size = New System.Drawing.Size(51, 23)
        Me.ucrChkTemDate.TabIndex = 48
        '
        'ucrChkTemOccu
        '
        Me.ucrChkTemOccu.AutoSize = True
        Me.ucrChkTemOccu.Checked = False
        Me.ucrChkTemOccu.Location = New System.Drawing.Point(356, 15)
        Me.ucrChkTemOccu.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkTemOccu.Name = "ucrChkTemOccu"
        Me.ucrChkTemOccu.Size = New System.Drawing.Size(84, 24)
        Me.ucrChkTemOccu.TabIndex = 50
        '
        'ucrInputTextTemdate
        '
        Me.ucrInputTextTemdate.AddQuotesIfUnrecognised = True
        Me.ucrInputTextTemdate.AutoSize = True
        Me.ucrInputTextTemdate.IsMultiline = False
        Me.ucrInputTextTemdate.IsReadOnly = False
        Me.ucrInputTextTemdate.Location = New System.Drawing.Point(238, 15)
        Me.ucrInputTextTemdate.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputTextTemdate.Name = "ucrInputTextTemdate"
        Me.ucrInputTextTemdate.Size = New System.Drawing.Size(85, 21)
        Me.ucrInputTextTemdate.TabIndex = 49
        '
        'ucrChkTemDay
        '
        Me.ucrChkTemDay.AutoSize = True
        Me.ucrChkTemDay.Checked = False
        Me.ucrChkTemDay.Location = New System.Drawing.Point(5, 15)
        Me.ucrChkTemDay.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkTemDay.Name = "ucrChkTemDay"
        Me.ucrChkTemDay.Size = New System.Drawing.Size(51, 23)
        Me.ucrChkTemDay.TabIndex = 67
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
        Me.grpConditionsForSatrtofRains.Location = New System.Drawing.Point(13, 298)
        Me.grpConditionsForSatrtofRains.Name = "grpConditionsForSatrtofRains"
        Me.grpConditionsForSatrtofRains.Size = New System.Drawing.Size(535, 185)
        Me.grpConditionsForSatrtofRains.TabIndex = 65
        Me.grpConditionsForSatrtofRains.TabStop = False
        Me.grpConditionsForSatrtofRains.Text = "Conditions for Start of Rains"
        '
        'cmdAdditionnal
        '
        Me.cmdAdditionnal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAdditionnal.Location = New System.Drawing.Point(159, 147)
        Me.cmdAdditionnal.Name = "cmdAdditionnal"
        Me.cmdAdditionnal.Size = New System.Drawing.Size(105, 26)
        Me.cmdAdditionnal.TabIndex = 16
        Me.cmdAdditionnal.Tag = ""
        Me.cmdAdditionnal.Text = "Add"
        Me.cmdAdditionnal.UseVisualStyleBackColor = True
        '
        'ucrChkAdditional
        '
        Me.ucrChkAdditional.AutoSize = True
        Me.ucrChkAdditional.Checked = False
        Me.ucrChkAdditional.Location = New System.Drawing.Point(4, 151)
        Me.ucrChkAdditional.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkAdditional.Name = "ucrChkAdditional"
        Me.ucrChkAdditional.Size = New System.Drawing.Size(143, 29)
        Me.ucrChkAdditional.TabIndex = 45
        '
        'ucrReceiverEvap
        '
        Me.ucrReceiverEvap.AutoSize = True
        Me.ucrReceiverEvap.frmParent = Me
        Me.ucrReceiverEvap.Location = New System.Drawing.Point(289, 81)
        Me.ucrReceiverEvap.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEvap.Name = "ucrReceiverEvap"
        Me.ucrReceiverEvap.Selector = Nothing
        Me.ucrReceiverEvap.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverEvap.strNcFilePath = ""
        Me.ucrReceiverEvap.TabIndex = 24
        Me.ucrReceiverEvap.ucrSelector = Nothing
        '
        'lblFraction
        '
        Me.lblFraction.AutoSize = True
        Me.lblFraction.Location = New System.Drawing.Point(419, 83)
        Me.lblFraction.Name = "lblFraction"
        Me.lblFraction.Size = New System.Drawing.Size(48, 13)
        Me.lblFraction.TabIndex = 25
        Me.lblFraction.Text = "Fraction:"
        '
        'ucrNudEvapo
        '
        Me.ucrNudEvapo.AutoSize = True
        Me.ucrNudEvapo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudEvapo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudEvapo.Location = New System.Drawing.Point(484, 78)
        Me.ucrNudEvapo.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudEvapo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudEvapo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudEvapo.Name = "ucrNudEvapo"
        Me.ucrNudEvapo.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudEvapo.TabIndex = 26
        Me.ucrNudEvapo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoEvapo
        '
        Me.rdoEvapo.AutoSize = True
        Me.rdoEvapo.Location = New System.Drawing.Point(199, 83)
        Me.rdoEvapo.Name = "rdoEvapo"
        Me.rdoEvapo.Size = New System.Drawing.Size(82, 17)
        Me.rdoEvapo.TabIndex = 23
        Me.rdoEvapo.TabStop = True
        Me.rdoEvapo.Text = "Evaporation"
        Me.rdoEvapo.UseVisualStyleBackColor = True
        '
        'lblTROverDays
        '
        Me.lblTROverDays.AutoSize = True
        Me.lblTROverDays.Location = New System.Drawing.Point(144, 25)
        Me.lblTROverDays.Name = "lblTROverDays"
        Me.lblTROverDays.Size = New System.Drawing.Size(60, 13)
        Me.lblTROverDays.TabIndex = 18
        Me.lblTROverDays.Tag = ""
        Me.lblTROverDays.Text = "Over Days:"
        '
        'ucrNudTROverDays
        '
        Me.ucrNudTROverDays.AutoSize = True
        Me.ucrNudTROverDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTROverDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTROverDays.Location = New System.Drawing.Point(210, 21)
        Me.ucrNudTROverDays.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudTROverDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTROverDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTROverDays.Name = "ucrNudTROverDays"
        Me.ucrNudTROverDays.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudTROverDays.TabIndex = 19
        Me.ucrNudTROverDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTRAmount
        '
        Me.ucrNudTRAmount.AutoSize = True
        Me.ucrNudTRAmount.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTRAmount.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTRAmount.Location = New System.Drawing.Point(289, 58)
        Me.ucrNudTRAmount.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudTRAmount.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTRAmount.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTRAmount.Name = "ucrNudTRAmount"
        Me.ucrNudTRAmount.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudTRAmount.TabIndex = 22
        Me.ucrNudTRAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblTRVal
        '
        Me.lblTRVal.AutoSize = True
        Me.lblTRVal.Location = New System.Drawing.Point(20, 60)
        Me.lblTRVal.Name = "lblTRVal"
        Me.lblTRVal.Size = New System.Drawing.Size(37, 13)
        Me.lblTRVal.TabIndex = 20
        Me.lblTRVal.Text = "Value:"
        '
        'ucrChkTotalRainfall
        '
        Me.ucrChkTotalRainfall.AutoSize = True
        Me.ucrChkTotalRainfall.Checked = False
        Me.ucrChkTotalRainfall.Location = New System.Drawing.Point(4, 22)
        Me.ucrChkTotalRainfall.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkTotalRainfall.Name = "ucrChkTotalRainfall"
        Me.ucrChkTotalRainfall.Size = New System.Drawing.Size(131, 34)
        Me.ucrChkTotalRainfall.TabIndex = 17
        '
        'ucrNudTRPercentile
        '
        Me.ucrNudTRPercentile.AutoSize = True
        Me.ucrNudTRPercentile.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTRPercentile.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTRPercentile.Location = New System.Drawing.Point(289, 109)
        Me.ucrNudTRPercentile.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudTRPercentile.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTRPercentile.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTRPercentile.Name = "ucrNudTRPercentile"
        Me.ucrNudTRPercentile.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudTRPercentile.TabIndex = 28
        Me.ucrNudTRPercentile.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoTRAmount
        '
        Me.rdoTRAmount.AutoSize = True
        Me.rdoTRAmount.Location = New System.Drawing.Point(199, 60)
        Me.rdoTRAmount.Name = "rdoTRAmount"
        Me.rdoTRAmount.Size = New System.Drawing.Size(61, 17)
        Me.rdoTRAmount.TabIndex = 21
        Me.rdoTRAmount.TabStop = True
        Me.rdoTRAmount.Text = "Amount"
        Me.rdoTRAmount.UseVisualStyleBackColor = True
        '
        'rdoTRPercentile
        '
        Me.rdoTRPercentile.AutoSize = True
        Me.rdoTRPercentile.Location = New System.Drawing.Point(199, 109)
        Me.rdoTRPercentile.Name = "rdoTRPercentile"
        Me.rdoTRPercentile.Size = New System.Drawing.Size(72, 17)
        Me.rdoTRPercentile.TabIndex = 27
        Me.rdoTRPercentile.TabStop = True
        Me.rdoTRPercentile.Text = "Percentile"
        Me.rdoTRPercentile.UseVisualStyleBackColor = True
        '
        'ucrPnlTRCalculateBy
        '
        Me.ucrPnlTRCalculateBy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlTRCalculateBy.Location = New System.Drawing.Point(130, 55)
        Me.ucrPnlTRCalculateBy.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlTRCalculateBy.Name = "ucrPnlTRCalculateBy"
        Me.ucrPnlTRCalculateBy.Size = New System.Drawing.Size(165, 75)
        Me.ucrPnlTRCalculateBy.TabIndex = 4
        '
        'ucrNudTotalOverDays
        '
        Me.ucrNudTotalOverDays.AutoSize = True
        Me.ucrNudTotalOverDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTotalOverDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTotalOverDays.Location = New System.Drawing.Point(226, 238)
        Me.ucrNudTotalOverDays.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudTotalOverDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTotalOverDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTotalOverDays.Name = "ucrNudTotalOverDays"
        Me.ucrNudTotalOverDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTotalOverDays.TabIndex = 78
        Me.ucrNudTotalOverDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblTotalOverDays
        '
        Me.lblTotalOverDays.AutoSize = True
        Me.lblTotalOverDays.Location = New System.Drawing.Point(154, 240)
        Me.lblTotalOverDays.Name = "lblTotalOverDays"
        Me.lblTotalOverDays.Size = New System.Drawing.Size(66, 13)
        Me.lblTotalOverDays.TabIndex = 77
        Me.lblTotalOverDays.Text = "Over Day(s):"
        '
        'ucrNudAmount
        '
        Me.ucrNudAmount.AutoSize = True
        Me.ucrNudAmount.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAmount.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAmount.Location = New System.Drawing.Point(61, 238)
        Me.ucrNudAmount.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudAmount.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAmount.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAmount.Name = "ucrNudAmount"
        Me.ucrNudAmount.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAmount.TabIndex = 76
        Me.ucrNudAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(8, 240)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(46, 13)
        Me.lblAmount.TabIndex = 75
        Me.lblAmount.Text = "Amount:"
        '
        'grpTem
        '
        Me.grpTem.Controls.Add(Me.lblTmax)
        Me.grpTem.Controls.Add(Me.ucrReceiverTmax)
        Me.grpTem.Controls.Add(Me.lblTmin)
        Me.grpTem.Controls.Add(Me.ucrReceiverTmin)
        Me.grpTem.Controls.Add(Me.rdoWinter)
        Me.grpTem.Controls.Add(Me.rdoSummer)
        Me.grpTem.Controls.Add(Me.ucrPnlTem)
        Me.grpTem.Location = New System.Drawing.Point(290, 219)
        Me.grpTem.Name = "grpTem"
        Me.grpTem.Size = New System.Drawing.Size(227, 92)
        Me.grpTem.TabIndex = 80
        Me.grpTem.TabStop = False
        Me.grpTem.Text = "Temperatures"
        '
        'lblTmax
        '
        Me.lblTmax.AutoSize = True
        Me.lblTmax.Location = New System.Drawing.Point(6, 61)
        Me.lblTmax.Name = "lblTmax"
        Me.lblTmax.Size = New System.Drawing.Size(33, 13)
        Me.lblTmax.TabIndex = 77
        Me.lblTmax.Text = "Tmax"
        '
        'ucrReceiverTmax
        '
        Me.ucrReceiverTmax.AutoSize = True
        Me.ucrReceiverTmax.frmParent = Me
        Me.ucrReceiverTmax.Location = New System.Drawing.Point(42, 58)
        Me.ucrReceiverTmax.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTmax.Name = "ucrReceiverTmax"
        Me.ucrReceiverTmax.Selector = Nothing
        Me.ucrReceiverTmax.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverTmax.strNcFilePath = ""
        Me.ucrReceiverTmax.TabIndex = 78
        Me.ucrReceiverTmax.ucrSelector = Nothing
        '
        'lblTmin
        '
        Me.lblTmin.AutoSize = True
        Me.lblTmin.Location = New System.Drawing.Point(9, 61)
        Me.lblTmin.Name = "lblTmin"
        Me.lblTmin.Size = New System.Drawing.Size(30, 13)
        Me.lblTmin.TabIndex = 75
        Me.lblTmin.Text = "Tmin"
        '
        'ucrReceiverTmin
        '
        Me.ucrReceiverTmin.AutoSize = True
        Me.ucrReceiverTmin.frmParent = Me
        Me.ucrReceiverTmin.Location = New System.Drawing.Point(42, 58)
        Me.ucrReceiverTmin.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTmin.Name = "ucrReceiverTmin"
        Me.ucrReceiverTmin.Selector = Nothing
        Me.ucrReceiverTmin.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverTmin.strNcFilePath = ""
        Me.ucrReceiverTmin.TabIndex = 76
        Me.ucrReceiverTmin.ucrSelector = Nothing
        '
        'rdoWinter
        '
        Me.rdoWinter.AutoSize = True
        Me.rdoWinter.Location = New System.Drawing.Point(143, 22)
        Me.rdoWinter.Name = "rdoWinter"
        Me.rdoWinter.Size = New System.Drawing.Size(56, 17)
        Me.rdoWinter.TabIndex = 2
        Me.rdoWinter.TabStop = True
        Me.rdoWinter.Text = "Winter"
        Me.rdoWinter.UseVisualStyleBackColor = True
        '
        'rdoSummer
        '
        Me.rdoSummer.AutoSize = True
        Me.rdoSummer.Location = New System.Drawing.Point(17, 22)
        Me.rdoSummer.Name = "rdoSummer"
        Me.rdoSummer.Size = New System.Drawing.Size(63, 17)
        Me.rdoSummer.TabIndex = 1
        Me.rdoSummer.TabStop = True
        Me.rdoSummer.Text = "Summer"
        Me.rdoSummer.UseVisualStyleBackColor = True
        '
        'ucrPnlTem
        '
        Me.ucrPnlTem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlTem.Location = New System.Drawing.Point(6, 19)
        Me.ucrPnlTem.Name = "ucrPnlTem"
        Me.ucrPnlTem.Size = New System.Drawing.Size(215, 20)
        Me.ucrPnlTem.TabIndex = 0
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(10, 12)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(57, 13)
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
        Me.grpRainParameters.Location = New System.Drawing.Point(13, 255)
        Me.grpRainParameters.Name = "grpRainParameters"
        Me.grpRainParameters.Size = New System.Drawing.Size(535, 40)
        Me.grpRainParameters.TabIndex = 64
        Me.grpRainParameters.TabStop = False
        '
        'ucrInputThreshold
        '
        Me.ucrInputThreshold.AddQuotesIfUnrecognised = True
        Me.ucrInputThreshold.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputThreshold.GetSetSelectedIndex = -1
        Me.ucrInputThreshold.IsReadOnly = False
        Me.ucrInputThreshold.Location = New System.Drawing.Point(70, 9)
        Me.ucrInputThreshold.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputThreshold.Name = "ucrInputThreshold"
        Me.ucrInputThreshold.Size = New System.Drawing.Size(62, 21)
        Me.ucrInputThreshold.TabIndex = 13
        '
        'ucrInputFilterPreview
        '
        Me.ucrInputFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterPreview.AutoSize = True
        Me.ucrInputFilterPreview.IsMultiline = False
        Me.ucrInputFilterPreview.IsReadOnly = True
        Me.ucrInputFilterPreview.Location = New System.Drawing.Point(277, 11)
        Me.ucrInputFilterPreview.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        Me.ucrInputFilterPreview.Size = New System.Drawing.Size(242, 22)
        Me.ucrInputFilterPreview.TabIndex = 15
        '
        'cmdDoyRange
        '
        Me.cmdDoyRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDoyRange.Location = New System.Drawing.Point(159, 8)
        Me.cmdDoyRange.Name = "cmdDoyRange"
        Me.cmdDoyRange.Size = New System.Drawing.Size(105, 26)
        Me.cmdDoyRange.TabIndex = 14
        Me.cmdDoyRange.Tag = ""
        Me.cmdDoyRange.Text = "Day Range"
        Me.cmdDoyRange.UseVisualStyleBackColor = True
        '
        'ucrSaveDefinition
        '
        Me.ucrSaveDefinition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveDefinition.Location = New System.Drawing.Point(13, 538)
        Me.ucrSaveDefinition.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveDefinition.Name = "ucrSaveDefinition"
        Me.ucrSaveDefinition.Size = New System.Drawing.Size(320, 24)
        Me.ucrSaveDefinition.TabIndex = 53
        '
        'ucrSelectorForStartofRains
        '
        Me.ucrSelectorForStartofRains.AutoSize = True
        Me.ucrSelectorForStartofRains.bDropUnusedFilterLevels = False
        Me.ucrSelectorForStartofRains.bShowHiddenColumns = False
        Me.ucrSelectorForStartofRains.bUseCurrentFilter = True
        Me.ucrSelectorForStartofRains.Location = New System.Drawing.Point(14, 38)
        Me.ucrSelectorForStartofRains.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForStartofRains.Name = "ucrSelectorForStartofRains"
        Me.ucrSelectorForStartofRains.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForStartofRains.TabIndex = 53
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(290, 63)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 55
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(290, 106)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 57
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(290, 149)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 59
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverRainfall
        '
        Me.ucrReceiverRainfall.AutoSize = True
        Me.ucrReceiverRainfall.frmParent = Me
        Me.ucrReceiverRainfall.Location = New System.Drawing.Point(290, 235)
        Me.ucrReceiverRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainfall.Name = "ucrReceiverRainfall"
        Me.ucrReceiverRainfall.Selector = Nothing
        Me.ucrReceiverRainfall.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverRainfall.strNcFilePath = ""
        Me.ucrReceiverRainfall.TabIndex = 63
        Me.ucrReceiverRainfall.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(14, 571)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 69
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.AutoSize = True
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(290, 192)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.TabIndex = 61
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrPnlStart
        '
        Me.ucrPnlStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlStart.Location = New System.Drawing.Point(26, 3)
        Me.ucrPnlStart.Name = "ucrPnlStart"
        Me.ucrPnlStart.Size = New System.Drawing.Size(477, 32)
        Me.ucrPnlStart.TabIndex = 70
        '
        'rdoTemperature
        '
        Me.rdoTemperature.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTemperature.BackColor = System.Drawing.SystemColors.Control
        Me.rdoTemperature.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTemperature.FlatAppearance.BorderSize = 2
        Me.rdoTemperature.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTemperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTemperature.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTemperature.Location = New System.Drawing.Point(253, 5)
        Me.rdoTemperature.Name = "rdoTemperature"
        Me.rdoTemperature.Size = New System.Drawing.Size(110, 28)
        Me.rdoTemperature.TabIndex = 72
        Me.rdoTemperature.TabStop = True
        Me.rdoTemperature.Tag = "Temperature"
        Me.rdoTemperature.Text = "Temperature"
        Me.rdoTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTemperature.UseVisualStyleBackColor = False
        '
        'rdoRain
        '
        Me.rdoRain.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRain.BackColor = System.Drawing.SystemColors.Control
        Me.rdoRain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRain.FlatAppearance.BorderSize = 2
        Me.rdoRain.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRain.Location = New System.Drawing.Point(132, 5)
        Me.rdoRain.Name = "rdoRain"
        Me.rdoRain.Size = New System.Drawing.Size(123, 28)
        Me.rdoRain.TabIndex = 71
        Me.rdoRain.TabStop = True
        Me.rdoRain.Tag = "Rain"
        Me.rdoRain.Text = "Rain"
        Me.rdoRain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRain.UseVisualStyleBackColor = False
        '
        'lblTem
        '
        Me.lblTem.AutoSize = True
        Me.lblTem.Location = New System.Drawing.Point(293, 219)
        Me.lblTem.Name = "lblTem"
        Me.lblTem.Size = New System.Drawing.Size(108, 13)
        Me.lblTem.TabIndex = 73
        Me.lblTem.Text = "Temperature Column:"
        '
        'ucrReceiverTem
        '
        Me.ucrReceiverTem.AutoSize = True
        Me.ucrReceiverTem.frmParent = Me
        Me.ucrReceiverTem.Location = New System.Drawing.Point(290, 235)
        Me.ucrReceiverTem.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTem.Name = "ucrReceiverTem"
        Me.ucrReceiverTem.Selector = Nothing
        Me.ucrReceiverTem.Size = New System.Drawing.Size(227, 92)
        Me.ucrReceiverTem.strNcFilePath = ""
        Me.ucrReceiverTem.TabIndex = 74
        Me.ucrReceiverTem.ucrSelector = Nothing
        '
        'ucrSaveDefinitionTem
        '
        Me.ucrSaveDefinitionTem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveDefinitionTem.Location = New System.Drawing.Point(13, 537)
        Me.ucrSaveDefinitionTem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveDefinitionTem.Name = "ucrSaveDefinitionTem"
        Me.ucrSaveDefinitionTem.Size = New System.Drawing.Size(320, 24)
        Me.ucrSaveDefinitionTem.TabIndex = 79
        '
        'ucrSaveDefinitionwinter
        '
        Me.ucrSaveDefinitionwinter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveDefinitionwinter.Location = New System.Drawing.Point(13, 533)
        Me.ucrSaveDefinitionwinter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveDefinitionwinter.Name = "ucrSaveDefinitionwinter"
        Me.ucrSaveDefinitionwinter.Size = New System.Drawing.Size(320, 24)
        Me.ucrSaveDefinitionwinter.TabIndex = 81
        '
        'dlgStartofRains
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(555, 633)
        Me.Controls.Add(Me.grpWinter)
        Me.Controls.Add(Me.ucrSaveDefinitionwinter)
        Me.Controls.Add(Me.ucrNudTotalOverDays)
        Me.Controls.Add(Me.grpTem)
        Me.Controls.Add(Me.lblTotalOverDays)
        Me.Controls.Add(Me.grpRainParameters)
        Me.Controls.Add(Me.ucrNudAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.grpTemDisplay)
        Me.Controls.Add(Me.ucrSaveDefinitionTem)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.lblTem)
        Me.Controls.Add(Me.ucrReceiverTem)
        Me.Controls.Add(Me.rdoTemperature)
        Me.Controls.Add(Me.rdoRain)
        Me.Controls.Add(Me.ucrPnlStart)
        Me.Controls.Add(Me.ucrSaveDefinition)
        Me.Controls.Add(Me.lblRainfall)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblDOY)
        Me.Controls.Add(Me.ucrSelectorForStartofRains)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverRainfall)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverDOY)
        Me.Controls.Add(Me.grpConditionsForSatrtofRains)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStartofRains"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start of the Season"
        Me.grpDisplay.ResumeLayout(False)
        Me.grpDisplay.PerformLayout()
        Me.grpTemDisplay.ResumeLayout(False)
        Me.grpTemDisplay.PerformLayout()
        Me.grpWinter.ResumeLayout(False)
        Me.grpWinter.PerformLayout()
        Me.grpConditionsForSatrtofRains.ResumeLayout(False)
        Me.grpConditionsForSatrtofRains.PerformLayout()
        Me.grpTem.ResumeLayout(False)
        Me.grpTem.PerformLayout()
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
    Friend WithEvents ucrSaveDefinition As ucrSave
    Friend WithEvents ucrPnlStart As UcrPanel
    Friend WithEvents rdoTemperature As RadioButton
    Friend WithEvents rdoRain As RadioButton
    Friend WithEvents lblTem As Label
    Friend WithEvents ucrReceiverTem As ucrReceiverSingle
    Friend WithEvents ucrNudTotalOverDays As ucrNud
    Friend WithEvents lblTotalOverDays As Label
    Friend WithEvents ucrNudAmount As ucrNud
    Friend WithEvents lblAmount As Label
    Friend WithEvents grpTemDisplay As GroupBox
    Friend WithEvents ucrInputTextTempday As ucrInputTextBox
    Friend WithEvents ucrInputTextTemOccu As ucrInputTextBox
    Friend WithEvents ucrChkTemDate As ucrCheck
    Friend WithEvents ucrChkTemOccu As ucrCheck
    Friend WithEvents ucrInputTextTemdate As ucrInputTextBox
    Friend WithEvents ucrChkTemDay As ucrCheck
    Friend WithEvents ucrSaveDefinitionTem As ucrSave
    Friend WithEvents grpTem As GroupBox
    Friend WithEvents lblTmax As Label
    Friend WithEvents ucrReceiverTmax As ucrReceiverSingle
    Friend WithEvents lblTmin As Label
    Friend WithEvents ucrReceiverTmin As ucrReceiverSingle
    Friend WithEvents rdoWinter As RadioButton
    Friend WithEvents rdoSummer As RadioButton
    Friend WithEvents ucrPnlTem As UcrPanel
    Friend WithEvents grpWinter As GroupBox
    Friend WithEvents ucrInputDayWinter As ucrInputTextBox
    Friend WithEvents ucrInputOccuWinter As ucrInputTextBox
    Friend WithEvents ucrChkDateWinter As ucrCheck
    Friend WithEvents ucrChkOccuWinter As ucrCheck
    Friend WithEvents ucrInputDateWinter As ucrInputTextBox
    Friend WithEvents ucrChkDayWinter As ucrCheck
    Friend WithEvents ucrSaveDefinitionwinter As ucrSave
End Class