<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgWaterBalance
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
        Me.ucrNudFrom = New instat.ucrNud()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.lblRainfall = New System.Windows.Forms.Label()
        Me.lblEvaporation = New System.Windows.Forms.Label()
        Me.ucrInputEvaporation = New instat.ucrInputTextBox()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverRainfall = New instat.ucrReceiverSingle()
        Me.ucrSelectorForWaterBalance = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.rdoBoth = New System.Windows.Forms.RadioButton()
        Me.rdoRain = New System.Windows.Forms.RadioButton()
        Me.rdoWaterBalance = New System.Windows.Forms.RadioButton()
        Me.ucrPnlEndofRains = New instat.UcrPanel()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.grpRain = New System.Windows.Forms.GroupBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.ucrNudAmount = New instat.ucrNud()
        Me.lblTotalOverDays = New System.Windows.Forms.Label()
        Me.ucrNudTotalOverDays = New instat.ucrNud()
        Me.grpWaterBalance = New System.Windows.Forms.GroupBox()
        Me.ucrNudWBLessThan = New instat.ucrNud()
        Me.ucrNudCapacity = New instat.ucrNud()
        Me.ucrInputEndRainColName = New instat.ucrInputTextBox()
        Me.lblEndRainsColName = New System.Windows.Forms.Label()
        Me.lblWBColName = New System.Windows.Forms.Label()
        Me.ucrInputWBColName = New instat.ucrInputTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrReceiverEvaporation = New instat.ucrReceiverSingle()
        Me.ucrChkEvaporationAsReceiver = New instat.ucrCheck()
        Me.grpRain.SuspendLayout()
        Me.grpWaterBalance.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(248, 130)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 17
        Me.lblYear.Text = "Year:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(247, 89)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 13
        Me.lblDate.Text = "Date:"
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.Location = New System.Drawing.Point(247, 172)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(66, 13)
        Me.lblDOY.TabIndex = 19
        Me.lblDOY.Text = "Day of Year:"
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrom.Location = New System.Drawing.Point(73, 263)
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFrom.TabIndex = 36
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(12, 265)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(55, 13)
        Me.lblFrom.TabIndex = 2
        Me.lblFrom.Text = "From Day:"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(17, 29)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(51, 13)
        Me.lblCapacity.TabIndex = 0
        Me.lblCapacity.Tag = "Capacity:"
        Me.lblCapacity.Text = "Capacity:"
        '
        'lblRainfall
        '
        Me.lblRainfall.AutoSize = True
        Me.lblRainfall.Location = New System.Drawing.Point(246, 214)
        Me.lblRainfall.Name = "lblRainfall"
        Me.lblRainfall.Size = New System.Drawing.Size(70, 13)
        Me.lblRainfall.TabIndex = 15
        Me.lblRainfall.Text = "Rain Column:"
        '
        'lblEvaporation
        '
        Me.lblEvaporation.AutoSize = True
        Me.lblEvaporation.Location = New System.Drawing.Point(17, 60)
        Me.lblEvaporation.Name = "lblEvaporation"
        Me.lblEvaporation.Size = New System.Drawing.Size(67, 13)
        Me.lblEvaporation.TabIndex = 24
        Me.lblEvaporation.Text = "Evaporation:"
        '
        'ucrInputEvaporation
        '
        Me.ucrInputEvaporation.AddQuotesIfUnrecognised = True
        Me.ucrInputEvaporation.IsMultiline = False
        Me.ucrInputEvaporation.IsReadOnly = False
        Me.ucrInputEvaporation.Location = New System.Drawing.Point(88, 58)
        Me.ucrInputEvaporation.Name = "ucrInputEvaporation"
        Me.ucrInputEvaporation.Size = New System.Drawing.Size(143, 21)
        Me.ucrInputEvaporation.TabIndex = 26
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(246, 145)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 18
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(246, 104)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 14
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(246, 187)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.TabIndex = 20
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrReceiverRainfall
        '
        Me.ucrReceiverRainfall.frmParent = Me
        Me.ucrReceiverRainfall.Location = New System.Drawing.Point(246, 229)
        Me.ucrReceiverRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainfall.Name = "ucrReceiverRainfall"
        Me.ucrReceiverRainfall.Selector = Nothing
        Me.ucrReceiverRainfall.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverRainfall.strNcFilePath = ""
        Me.ucrReceiverRainfall.TabIndex = 16
        Me.ucrReceiverRainfall.ucrSelector = Nothing
        '
        'ucrSelectorForWaterBalance
        '
        Me.ucrSelectorForWaterBalance.bShowHiddenColumns = False
        Me.ucrSelectorForWaterBalance.bUseCurrentFilter = True
        Me.ucrSelectorForWaterBalance.Location = New System.Drawing.Point(9, 49)
        Me.ucrSelectorForWaterBalance.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForWaterBalance.Name = "ucrSelectorForWaterBalance"
        Me.ucrSelectorForWaterBalance.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForWaterBalance.TabIndex = 12
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(8, 457)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 56)
        Me.ucrBase.TabIndex = 23
        '
        'rdoBoth
        '
        Me.rdoBoth.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBoth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoBoth.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBoth.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.FlatAppearance.BorderSize = 2
        Me.rdoBoth.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBoth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoBoth.Location = New System.Drawing.Point(242, 14)
        Me.rdoBoth.Name = "rdoBoth"
        Me.rdoBoth.Size = New System.Drawing.Size(100, 28)
        Me.rdoBoth.TabIndex = 31
        Me.rdoBoth.Text = "Both"
        Me.rdoBoth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBoth.UseVisualStyleBackColor = True
        '
        'rdoRain
        '
        Me.rdoRain.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRain.FlatAppearance.BorderSize = 2
        Me.rdoRain.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRain.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoRain.Location = New System.Drawing.Point(46, 14)
        Me.rdoRain.Name = "rdoRain"
        Me.rdoRain.Size = New System.Drawing.Size(100, 28)
        Me.rdoRain.TabIndex = 29
        Me.rdoRain.Text = "Rain"
        Me.rdoRain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRain.UseVisualStyleBackColor = True
        '
        'rdoWaterBalance
        '
        Me.rdoWaterBalance.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoWaterBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoWaterBalance.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoWaterBalance.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWaterBalance.FlatAppearance.BorderSize = 2
        Me.rdoWaterBalance.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWaterBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoWaterBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoWaterBalance.Location = New System.Drawing.Point(144, 14)
        Me.rdoWaterBalance.Name = "rdoWaterBalance"
        Me.rdoWaterBalance.Size = New System.Drawing.Size(100, 28)
        Me.rdoWaterBalance.TabIndex = 30
        Me.rdoWaterBalance.Text = "Water Balance"
        Me.rdoWaterBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoWaterBalance.UseVisualStyleBackColor = True
        '
        'ucrPnlEndofRains
        '
        Me.ucrPnlEndofRains.Location = New System.Drawing.Point(22, 13)
        Me.ucrPnlEndofRains.Name = "ucrPnlEndofRains"
        Me.ucrPnlEndofRains.Size = New System.Drawing.Size(349, 29)
        Me.ucrPnlEndofRains.TabIndex = 28
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(247, 50)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 32
        Me.lblStation.Text = "Station:"
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(246, 65)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 33
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'grpRain
        '
        Me.grpRain.Controls.Add(Me.lblAmount)
        Me.grpRain.Controls.Add(Me.ucrNudAmount)
        Me.grpRain.Controls.Add(Me.lblTotalOverDays)
        Me.grpRain.Controls.Add(Me.ucrNudTotalOverDays)
        Me.grpRain.Location = New System.Drawing.Point(512, 89)
        Me.grpRain.Name = "grpRain"
        Me.grpRain.Size = New System.Drawing.Size(185, 88)
        Me.grpRain.TabIndex = 34
        Me.grpRain.TabStop = False
        Me.grpRain.Text = "Rain"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(32, 48)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(68, 13)
        Me.lblAmount.TabIndex = 35
        Me.lblAmount.Text = "Amount (mm)"
        '
        'ucrNudAmount
        '
        Me.ucrNudAmount.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAmount.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAmount.Location = New System.Drawing.Point(113, 45)
        Me.ucrNudAmount.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAmount.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAmount.Name = "ucrNudAmount"
        Me.ucrNudAmount.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAmount.TabIndex = 34
        Me.ucrNudAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblTotalOverDays
        '
        Me.lblTotalOverDays.AutoSize = True
        Me.lblTotalOverDays.Location = New System.Drawing.Point(10, 23)
        Me.lblTotalOverDays.Name = "lblTotalOverDays"
        Me.lblTotalOverDays.Size = New System.Drawing.Size(90, 13)
        Me.lblTotalOverDays.TabIndex = 33
        Me.lblTotalOverDays.Text = "Total Over Day(s)"
        '
        'ucrNudTotalOverDays
        '
        Me.ucrNudTotalOverDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTotalOverDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTotalOverDays.Location = New System.Drawing.Point(106, 19)
        Me.ucrNudTotalOverDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTotalOverDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTotalOverDays.Name = "ucrNudTotalOverDays"
        Me.ucrNudTotalOverDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTotalOverDays.TabIndex = 0
        Me.ucrNudTotalOverDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'grpWaterBalance
        '
        Me.grpWaterBalance.Controls.Add(Me.ucrChkEvaporationAsReceiver)
        Me.grpWaterBalance.Controls.Add(Me.ucrInputEvaporation)
        Me.grpWaterBalance.Controls.Add(Me.ucrReceiverEvaporation)
        Me.grpWaterBalance.Controls.Add(Me.ucrNudWBLessThan)
        Me.grpWaterBalance.Controls.Add(Me.Label1)
        Me.grpWaterBalance.Controls.Add(Me.lblCapacity)
        Me.grpWaterBalance.Controls.Add(Me.lblEvaporation)
        Me.grpWaterBalance.Controls.Add(Me.ucrNudCapacity)
        Me.grpWaterBalance.Location = New System.Drawing.Point(9, 304)
        Me.grpWaterBalance.Name = "grpWaterBalance"
        Me.grpWaterBalance.Size = New System.Drawing.Size(404, 93)
        Me.grpWaterBalance.TabIndex = 35
        Me.grpWaterBalance.TabStop = False
        Me.grpWaterBalance.Text = "Water Balance"
        '
        'ucrNudWBLessThan
        '
        Me.ucrNudWBLessThan.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWBLessThan.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWBLessThan.Location = New System.Drawing.Point(266, 26)
        Me.ucrNudWBLessThan.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWBLessThan.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWBLessThan.Name = "ucrNudWBLessThan"
        Me.ucrNudWBLessThan.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWBLessThan.TabIndex = 37
        Me.ucrNudWBLessThan.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudCapacity
        '
        Me.ucrNudCapacity.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCapacity.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCapacity.Location = New System.Drawing.Point(70, 26)
        Me.ucrNudCapacity.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCapacity.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCapacity.Name = "ucrNudCapacity"
        Me.ucrNudCapacity.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCapacity.TabIndex = 36
        Me.ucrNudCapacity.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputEndRainColName
        '
        Me.ucrInputEndRainColName.AddQuotesIfUnrecognised = True
        Me.ucrInputEndRainColName.IsMultiline = False
        Me.ucrInputEndRainColName.IsReadOnly = False
        Me.ucrInputEndRainColName.Location = New System.Drawing.Point(589, 187)
        Me.ucrInputEndRainColName.Name = "ucrInputEndRainColName"
        Me.ucrInputEndRainColName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputEndRainColName.TabIndex = 50
        '
        'lblEndRainsColName
        '
        Me.lblEndRainsColName.AutoSize = True
        Me.lblEndRainsColName.Location = New System.Drawing.Point(467, 191)
        Me.lblEndRainsColName.Name = "lblEndRainsColName"
        Me.lblEndRainsColName.Size = New System.Drawing.Size(120, 13)
        Me.lblEndRainsColName.TabIndex = 51
        Me.lblEndRainsColName.Tag = "End of Rains Col Name:"
        Me.lblEndRainsColName.Text = "End of Rains Col Name:"
        '
        'lblWBColName
        '
        Me.lblWBColName.AutoSize = True
        Me.lblWBColName.Location = New System.Drawing.Point(6, 436)
        Me.lblWBColName.Name = "lblWBColName"
        Me.lblWBColName.Size = New System.Drawing.Size(150, 13)
        Me.lblWBColName.TabIndex = 53
        Me.lblWBColName.Tag = "Water Balance Col Name:"
        Me.lblWBColName.Text = "Water Balance Column Name:"
        '
        'ucrInputWBColName
        '
        Me.ucrInputWBColName.AddQuotesIfUnrecognised = True
        Me.ucrInputWBColName.IsMultiline = False
        Me.ucrInputWBColName.IsReadOnly = False
        Me.ucrInputWBColName.Location = New System.Drawing.Point(158, 432)
        Me.ucrInputWBColName.Name = "ucrInputWBColName"
        Me.ucrInputWBColName.Size = New System.Drawing.Size(167, 21)
        Me.ucrInputWBColName.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Tag = "Water Balance <="
        Me.Label1.Text = "Water Balance <="
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(158, 265)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(45, 13)
        Me.lblTo.TabIndex = 4
        Me.lblTo.Tag = ""
        Me.lblTo.Text = "To Day:"
        '
        'ucrNudTo
        '
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTo.Location = New System.Drawing.Point(209, 263)
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTo.TabIndex = 36
        Me.ucrNudTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverEvaporation
        '
        Me.ucrReceiverEvaporation.frmParent = Me
        Me.ucrReceiverEvaporation.Location = New System.Drawing.Point(88, 58)
        Me.ucrReceiverEvaporation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEvaporation.Name = "ucrReceiverEvaporation"
        Me.ucrReceiverEvaporation.Selector = Nothing
        Me.ucrReceiverEvaporation.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverEvaporation.strNcFilePath = ""
        Me.ucrReceiverEvaporation.TabIndex = 54
        Me.ucrReceiverEvaporation.ucrSelector = Nothing
        '
        'ucrChkEvaporationAsReceiver
        '
        Me.ucrChkEvaporationAsReceiver.Checked = False
        Me.ucrChkEvaporationAsReceiver.Location = New System.Drawing.Point(241, 58)
        Me.ucrChkEvaporationAsReceiver.Name = "ucrChkEvaporationAsReceiver"
        Me.ucrChkEvaporationAsReceiver.Size = New System.Drawing.Size(157, 20)
        Me.ucrChkEvaporationAsReceiver.TabIndex = 58
        '
        'dlgWaterBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 519)
        Me.Controls.Add(Me.ucrNudTo)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.ucrNudFrom)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.lblWBColName)
        Me.Controls.Add(Me.ucrInputWBColName)
        Me.Controls.Add(Me.lblEndRainsColName)
        Me.Controls.Add(Me.ucrInputEndRainColName)
        Me.Controls.Add(Me.grpWaterBalance)
        Me.Controls.Add(Me.grpRain)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.rdoBoth)
        Me.Controls.Add(Me.rdoRain)
        Me.Controls.Add(Me.rdoWaterBalance)
        Me.Controls.Add(Me.ucrPnlEndofRains)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgWaterBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "End_of_Rains_Season"
        Me.Text = "End of Rains/Season"
        Me.grpRain.ResumeLayout(False)
        Me.grpRain.PerformLayout()
        Me.grpWaterBalance.ResumeLayout(False)
        Me.grpWaterBalance.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrInputEvaporation As ucrInputTextBox
    Friend WithEvents lblEvaporation As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents lblDOY As Label
    Friend WithEvents lblCapacity As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblRainfall As Label
    Friend WithEvents ucrReceiverRainfall As ucrReceiverSingle
    Friend WithEvents ucrSelectorForWaterBalance As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents rdoBoth As RadioButton
    Friend WithEvents rdoRain As RadioButton
    Friend WithEvents rdoWaterBalance As RadioButton
    Friend WithEvents ucrPnlEndofRains As UcrPanel
    Friend WithEvents grpWaterBalance As GroupBox
    Friend WithEvents grpRain As GroupBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents ucrNudAmount As ucrNud
    Friend WithEvents lblTotalOverDays As Label
    Friend WithEvents ucrNudTotalOverDays As ucrNud
    Friend WithEvents ucrNudWBLessThan As ucrNud
    Friend WithEvents ucrNudCapacity As ucrNud
    Friend WithEvents ucrNudFrom As ucrNud
    Friend WithEvents ucrInputEndRainColName As ucrInputTextBox
    Friend WithEvents lblEndRainsColName As Label
    Friend WithEvents lblWBColName As Label
    Friend WithEvents ucrInputWBColName As ucrInputTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrNudTo As ucrNud
    Friend WithEvents lblTo As Label
    Friend WithEvents ucrChkEvaporationAsReceiver As ucrCheck
    Friend WithEvents ucrReceiverEvaporation As ucrReceiverSingle
End Class