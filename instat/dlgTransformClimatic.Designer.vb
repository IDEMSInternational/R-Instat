<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTransformClimatic
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDOY = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.rdoSpell = New System.Windows.Forms.RadioButton()
        Me.rdoSum = New System.Windows.Forms.RadioButton()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.rdoWaterBalance = New System.Windows.Forms.RadioButton()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.grpTransform = New System.Windows.Forms.GroupBox()
        Me.lblSumRows = New System.Windows.Forms.Label()
        Me.lblSumOver = New System.Windows.Forms.Label()
        Me.lblNewColName = New System.Windows.Forms.Label()
        Me.grpCount = New System.Windows.Forms.GroupBox()
        Me.lblCountRows = New System.Windows.Forms.Label()
        Me.lblCountOver = New System.Windows.Forms.Label()
        Me.grpSpells = New System.Windows.Forms.GroupBox()
        Me.lblSpellAnd = New System.Windows.Forms.Label()
        Me.lblValuesBetween = New System.Windows.Forms.Label()
        Me.grpWaterbalance = New System.Windows.Forms.GroupBox()
        Me.lblWBEvaporation = New System.Windows.Forms.Label()
        Me.lblWBCapacity = New System.Windows.Forms.Label()
        Me.ucrInputEvaporation = New instat.ucrInputTextBox()
        Me.ucrNudWBCapacity = New instat.ucrNud()
        Me.ucrInputSpellUpper = New instat.ucrInputTextBox()
        Me.ucrInputSpellLower = New instat.ucrInputTextBox()
        Me.ucrChkValuesUnderthreshold = New instat.ucrCheck()
        Me.ucrNudCountOver = New instat.ucrNud()
        Me.ucrInputColName = New instat.ucrInputTextBox()
        Me.ucrNudSumOver = New instat.ucrNud()
        Me.ucrInputSum = New instat.ucrInputComboBox()
        Me.ucrNudThreshold = New instat.ucrNud()
        Me.ucrPnlTransform = New instat.UcrPanel()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorTransform = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverData = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpTransform.SuspendLayout()
        Me.grpCount.SuspendLayout()
        Me.grpSpells.SuspendLayout()
        Me.grpWaterbalance.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(315, 142)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 29
        Me.lblYear.Text = "Year:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(314, 96)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 25
        Me.lblDate.Text = "Date:"
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.Location = New System.Drawing.Point(314, 184)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(66, 13)
        Me.lblDOY.TabIndex = 31
        Me.lblDOY.Text = "Day of Year:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(314, 51)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 35
        Me.lblStation.Text = "Station:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(313, 227)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(70, 13)
        Me.lblData.TabIndex = 27
        Me.lblData.Text = "Rain Column:"
        '
        'rdoSpell
        '
        Me.rdoSpell.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSpell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoSpell.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSpell.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSpell.FlatAppearance.BorderSize = 2
        Me.rdoSpell.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSpell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSpell.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoSpell.Location = New System.Drawing.Point(247, 17)
        Me.rdoSpell.Name = "rdoSpell"
        Me.rdoSpell.Size = New System.Drawing.Size(100, 28)
        Me.rdoSpell.TabIndex = 40
        Me.rdoSpell.Text = "Spell"
        Me.rdoSpell.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoSpell.UseVisualStyleBackColor = True
        '
        'rdoSum
        '
        Me.rdoSum.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSum.Checked = True
        Me.rdoSum.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSum.FlatAppearance.BorderSize = 2
        Me.rdoSum.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoSum.Location = New System.Drawing.Point(49, 17)
        Me.rdoSum.Name = "rdoSum"
        Me.rdoSum.Size = New System.Drawing.Size(100, 28)
        Me.rdoSum.TabIndex = 38
        Me.rdoSum.TabStop = True
        Me.rdoSum.Text = "Sum"
        Me.rdoSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSum.UseVisualStyleBackColor = True
        '
        'rdoCount
        '
        Me.rdoCount.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoCount.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCount.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCount.FlatAppearance.BorderSize = 2
        Me.rdoCount.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoCount.Location = New System.Drawing.Point(149, 17)
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.Size = New System.Drawing.Size(100, 28)
        Me.rdoCount.TabIndex = 39
        Me.rdoCount.Text = "Count"
        Me.rdoCount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoCount.UseVisualStyleBackColor = True
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
        Me.rdoWaterBalance.Location = New System.Drawing.Point(345, 17)
        Me.rdoWaterBalance.Name = "rdoWaterBalance"
        Me.rdoWaterBalance.Size = New System.Drawing.Size(100, 28)
        Me.rdoWaterBalance.TabIndex = 41
        Me.rdoWaterBalance.Text = "Water Balance"
        Me.rdoWaterBalance.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoWaterBalance.UseVisualStyleBackColor = True
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(69, 249)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(69, 13)
        Me.lblThreshold.TabIndex = 44
        Me.lblThreshold.Tag = "Threshold <="
        Me.lblThreshold.Text = "Threshold <="
        '
        'grpTransform
        '
        Me.grpTransform.Controls.Add(Me.lblSumRows)
        Me.grpTransform.Controls.Add(Me.ucrNudSumOver)
        Me.grpTransform.Controls.Add(Me.lblSumOver)
        Me.grpTransform.Controls.Add(Me.ucrInputSum)
        Me.grpTransform.Location = New System.Drawing.Point(10, 273)
        Me.grpTransform.Name = "grpTransform"
        Me.grpTransform.Size = New System.Drawing.Size(284, 58)
        Me.grpTransform.TabIndex = 46
        Me.grpTransform.TabStop = False
        Me.grpTransform.Text = "Sum"
        '
        'lblSumRows
        '
        Me.lblSumRows.AutoSize = True
        Me.lblSumRows.Location = New System.Drawing.Point(229, 18)
        Me.lblSumRows.Name = "lblSumRows"
        Me.lblSumRows.Size = New System.Drawing.Size(29, 13)
        Me.lblSumRows.TabIndex = 48
        Me.lblSumRows.Tag = "rows"
        Me.lblSumRows.Text = "rows"
        '
        'lblSumOver
        '
        Me.lblSumOver.AutoSize = True
        Me.lblSumOver.Location = New System.Drawing.Point(137, 18)
        Me.lblSumOver.Name = "lblSumOver"
        Me.lblSumOver.Size = New System.Drawing.Size(30, 13)
        Me.lblSumOver.TabIndex = 46
        Me.lblSumOver.Tag = "Over"
        Me.lblSumOver.Text = "Over"
        '
        'lblNewColName
        '
        Me.lblNewColName.AutoSize = True
        Me.lblNewColName.Location = New System.Drawing.Point(10, 409)
        Me.lblNewColName.Name = "lblNewColName"
        Me.lblNewColName.Size = New System.Drawing.Size(101, 13)
        Me.lblNewColName.TabIndex = 50
        Me.lblNewColName.Tag = "New Column Name:"
        Me.lblNewColName.Text = "New Column Name:"
        '
        'grpCount
        '
        Me.grpCount.Controls.Add(Me.ucrChkValuesUnderthreshold)
        Me.grpCount.Controls.Add(Me.lblCountRows)
        Me.grpCount.Controls.Add(Me.ucrNudCountOver)
        Me.grpCount.Controls.Add(Me.lblCountOver)
        Me.grpCount.Location = New System.Drawing.Point(313, 273)
        Me.grpCount.Name = "grpCount"
        Me.grpCount.Size = New System.Drawing.Size(256, 58)
        Me.grpCount.TabIndex = 51
        Me.grpCount.TabStop = False
        Me.grpCount.Text = "Count"
        '
        'lblCountRows
        '
        Me.lblCountRows.AutoSize = True
        Me.lblCountRows.Location = New System.Drawing.Point(115, 20)
        Me.lblCountRows.Name = "lblCountRows"
        Me.lblCountRows.Size = New System.Drawing.Size(29, 13)
        Me.lblCountRows.TabIndex = 55
        Me.lblCountRows.Tag = "rows"
        Me.lblCountRows.Text = "rows"
        '
        'lblCountOver
        '
        Me.lblCountOver.AutoSize = True
        Me.lblCountOver.Location = New System.Drawing.Point(-1, 20)
        Me.lblCountOver.Name = "lblCountOver"
        Me.lblCountOver.Size = New System.Drawing.Size(61, 13)
        Me.lblCountOver.TabIndex = 53
        Me.lblCountOver.Tag = "Count_Over"
        Me.lblCountOver.Text = "Count Over"
        '
        'grpSpells
        '
        Me.grpSpells.Controls.Add(Me.ucrInputSpellUpper)
        Me.grpSpells.Controls.Add(Me.ucrInputSpellLower)
        Me.grpSpells.Controls.Add(Me.lblSpellAnd)
        Me.grpSpells.Controls.Add(Me.lblValuesBetween)
        Me.grpSpells.Location = New System.Drawing.Point(318, 337)
        Me.grpSpells.Name = "grpSpells"
        Me.grpSpells.Size = New System.Drawing.Size(251, 60)
        Me.grpSpells.TabIndex = 0
        Me.grpSpells.TabStop = False
        Me.grpSpells.Text = "Spells"
        '
        'lblSpellAnd
        '
        Me.lblSpellAnd.AutoSize = True
        Me.lblSpellAnd.Location = New System.Drawing.Point(151, 20)
        Me.lblSpellAnd.Name = "lblSpellAnd"
        Me.lblSpellAnd.Size = New System.Drawing.Size(25, 13)
        Me.lblSpellAnd.TabIndex = 59
        Me.lblSpellAnd.Tag = "and"
        Me.lblSpellAnd.Text = "and"
        '
        'lblValuesBetween
        '
        Me.lblValuesBetween.AutoSize = True
        Me.lblValuesBetween.Location = New System.Drawing.Point(0, 20)
        Me.lblValuesBetween.Name = "lblValuesBetween"
        Me.lblValuesBetween.Size = New System.Drawing.Size(84, 13)
        Me.lblValuesBetween.TabIndex = 58
        Me.lblValuesBetween.Tag = "Values_Between"
        Me.lblValuesBetween.Text = "Values Between"
        '
        'grpWaterbalance
        '
        Me.grpWaterbalance.Controls.Add(Me.ucrInputEvaporation)
        Me.grpWaterbalance.Controls.Add(Me.lblWBEvaporation)
        Me.grpWaterbalance.Controls.Add(Me.ucrNudWBCapacity)
        Me.grpWaterbalance.Controls.Add(Me.lblWBCapacity)
        Me.grpWaterbalance.Location = New System.Drawing.Point(10, 330)
        Me.grpWaterbalance.Name = "grpWaterbalance"
        Me.grpWaterbalance.Size = New System.Drawing.Size(292, 67)
        Me.grpWaterbalance.TabIndex = 52
        Me.grpWaterbalance.TabStop = False
        Me.grpWaterbalance.Text = "Water Balance"
        '
        'lblWBEvaporation
        '
        Me.lblWBEvaporation.AutoSize = True
        Me.lblWBEvaporation.Location = New System.Drawing.Point(146, 20)
        Me.lblWBEvaporation.Name = "lblWBEvaporation"
        Me.lblWBEvaporation.Size = New System.Drawing.Size(64, 13)
        Me.lblWBEvaporation.TabIndex = 52
        Me.lblWBEvaporation.Tag = "Evaporation"
        Me.lblWBEvaporation.Text = "Evaporation"
        '
        'lblWBCapacity
        '
        Me.lblWBCapacity.AutoSize = True
        Me.lblWBCapacity.Location = New System.Drawing.Point(20, 21)
        Me.lblWBCapacity.Name = "lblWBCapacity"
        Me.lblWBCapacity.Size = New System.Drawing.Size(48, 13)
        Me.lblWBCapacity.TabIndex = 50
        Me.lblWBCapacity.Tag = "Capacity"
        Me.lblWBCapacity.Text = "Capacity"
        '
        'ucrInputEvaporation
        '
        Me.ucrInputEvaporation.AddQuotesIfUnrecognised = True
        Me.ucrInputEvaporation.IsMultiline = False
        Me.ucrInputEvaporation.IsReadOnly = False
        Me.ucrInputEvaporation.Location = New System.Drawing.Point(212, 16)
        Me.ucrInputEvaporation.Name = "ucrInputEvaporation"
        Me.ucrInputEvaporation.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputEvaporation.TabIndex = 53
        '
        'ucrNudWBCapacity
        '
        Me.ucrNudWBCapacity.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWBCapacity.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWBCapacity.Location = New System.Drawing.Point(75, 20)
        Me.ucrNudWBCapacity.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWBCapacity.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWBCapacity.Name = "ucrNudWBCapacity"
        Me.ucrNudWBCapacity.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWBCapacity.TabIndex = 51
        Me.ucrNudWBCapacity.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputSpellUpper
        '
        Me.ucrInputSpellUpper.AddQuotesIfUnrecognised = True
        Me.ucrInputSpellUpper.IsMultiline = False
        Me.ucrInputSpellUpper.IsReadOnly = False
        Me.ucrInputSpellUpper.Location = New System.Drawing.Point(180, 15)
        Me.ucrInputSpellUpper.Name = "ucrInputSpellUpper"
        Me.ucrInputSpellUpper.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputSpellUpper.TabIndex = 61
        '
        'ucrInputSpellLower
        '
        Me.ucrInputSpellLower.AddQuotesIfUnrecognised = True
        Me.ucrInputSpellLower.IsMultiline = False
        Me.ucrInputSpellLower.IsReadOnly = False
        Me.ucrInputSpellLower.Location = New System.Drawing.Point(86, 17)
        Me.ucrInputSpellLower.Name = "ucrInputSpellLower"
        Me.ucrInputSpellLower.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputSpellLower.TabIndex = 60
        '
        'ucrChkValuesUnderthreshold
        '
        Me.ucrChkValuesUnderthreshold.Checked = False
        Me.ucrChkValuesUnderthreshold.Location = New System.Drawing.Point(149, 20)
        Me.ucrChkValuesUnderthreshold.Name = "ucrChkValuesUnderthreshold"
        Me.ucrChkValuesUnderthreshold.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkValuesUnderthreshold.TabIndex = 56
        '
        'ucrNudCountOver
        '
        Me.ucrNudCountOver.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCountOver.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCountOver.Location = New System.Drawing.Point(62, 20)
        Me.ucrNudCountOver.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCountOver.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCountOver.Name = "ucrNudCountOver"
        Me.ucrNudCountOver.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCountOver.TabIndex = 54
        Me.ucrNudCountOver.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputColName
        '
        Me.ucrInputColName.AddQuotesIfUnrecognised = True
        Me.ucrInputColName.IsMultiline = False
        Me.ucrInputColName.IsReadOnly = False
        Me.ucrInputColName.Location = New System.Drawing.Point(116, 406)
        Me.ucrInputColName.Name = "ucrInputColName"
        Me.ucrInputColName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputColName.TabIndex = 49
        '
        'ucrNudSumOver
        '
        Me.ucrNudSumOver.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSumOver.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSumOver.Location = New System.Drawing.Point(173, 18)
        Me.ucrNudSumOver.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSumOver.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSumOver.Name = "ucrNudSumOver"
        Me.ucrNudSumOver.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSumOver.TabIndex = 47
        Me.ucrNudSumOver.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputSum
        '
        Me.ucrInputSum.AddQuotesIfUnrecognised = True
        Me.ucrInputSum.IsReadOnly = False
        Me.ucrInputSum.Location = New System.Drawing.Point(16, 18)
        Me.ucrInputSum.Name = "ucrInputSum"
        Me.ucrInputSum.Size = New System.Drawing.Size(106, 21)
        Me.ucrInputSum.TabIndex = 0
        '
        'ucrNudThreshold
        '
        Me.ucrNudThreshold.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudThreshold.Location = New System.Drawing.Point(144, 249)
        Me.ucrNudThreshold.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThreshold.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreshold.Name = "ucrNudThreshold"
        Me.ucrNudThreshold.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudThreshold.TabIndex = 45
        Me.ucrNudThreshold.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlTransform
        '
        Me.ucrPnlTransform.Location = New System.Drawing.Point(27, 16)
        Me.ucrPnlTransform.Name = "ucrPnlTransform"
        Me.ucrPnlTransform.Size = New System.Drawing.Size(446, 29)
        Me.ucrPnlTransform.TabIndex = 37
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(313, 66)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverStation.TabIndex = 36
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorTransform
        '
        Me.ucrSelectorTransform.bShowHiddenColumns = False
        Me.ucrSelectorTransform.bUseCurrentFilter = True
        Me.ucrSelectorTransform.Location = New System.Drawing.Point(9, 60)
        Me.ucrSelectorTransform.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTransform.Name = "ucrSelectorTransform"
        Me.ucrSelectorTransform.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorTransform.TabIndex = 34
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(313, 157)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverYear.TabIndex = 30
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(313, 111)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDate.TabIndex = 26
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(313, 199)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDOY.TabIndex = 32
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrReceiverData
        '
        Me.ucrReceiverData.frmParent = Me
        Me.ucrReceiverData.Location = New System.Drawing.Point(313, 242)
        Me.ucrReceiverData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverData.Name = "ucrReceiverData"
        Me.ucrReceiverData.Selector = Nothing
        Me.ucrReceiverData.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverData.TabIndex = 28
        Me.ucrReceiverData.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 436)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(402, 52)
        Me.ucrBase.TabIndex = 0
        '
        'dlgTransformClimatic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 492)
        Me.Controls.Add(Me.grpWaterbalance)
        Me.Controls.Add(Me.grpSpells)
        Me.Controls.Add(Me.grpCount)
        Me.Controls.Add(Me.lblNewColName)
        Me.Controls.Add(Me.ucrInputColName)
        Me.Controls.Add(Me.grpTransform)
        Me.Controls.Add(Me.ucrNudThreshold)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.rdoWaterBalance)
        Me.Controls.Add(Me.rdoSpell)
        Me.Controls.Add(Me.rdoSum)
        Me.Controls.Add(Me.rdoCount)
        Me.Controls.Add(Me.ucrPnlTransform)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrSelectorTransform)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverDOY)
        Me.Controls.Add(Me.lblDOY)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.ucrReceiverData)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTransformClimatic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transform"
        Me.grpTransform.ResumeLayout(False)
        Me.grpTransform.PerformLayout()
        Me.grpCount.ResumeLayout(False)
        Me.grpCount.PerformLayout()
        Me.grpSpells.ResumeLayout(False)
        Me.grpSpells.PerformLayout()
        Me.grpWaterbalance.ResumeLayout(False)
        Me.grpWaterbalance.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents lblDOY As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrSelectorTransform As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblData As Label
    Friend WithEvents ucrReceiverData As ucrReceiverSingle
    Friend WithEvents rdoWaterBalance As RadioButton
    Friend WithEvents rdoSpell As RadioButton
    Friend WithEvents rdoSum As RadioButton
    Friend WithEvents rdoCount As RadioButton
    Friend WithEvents ucrPnlTransform As UcrPanel
    Friend WithEvents grpTransform As GroupBox
    Friend WithEvents lblSumRows As Label
    Friend WithEvents ucrNudSumOver As ucrNud
    Friend WithEvents lblSumOver As Label
    Friend WithEvents ucrInputSum As ucrInputComboBox
    Friend WithEvents ucrNudThreshold As ucrNud
    Friend WithEvents lblThreshold As Label
    Friend WithEvents ucrInputColName As ucrInputTextBox
    Friend WithEvents lblNewColName As Label
    Friend WithEvents grpCount As GroupBox
    Friend WithEvents ucrChkValuesUnderthreshold As ucrCheck
    Friend WithEvents lblCountRows As Label
    Friend WithEvents ucrNudCountOver As ucrNud
    Friend WithEvents lblCountOver As Label
    Friend WithEvents grpWaterbalance As GroupBox
    Friend WithEvents ucrInputEvaporation As ucrInputTextBox
    Friend WithEvents lblWBEvaporation As Label
    Friend WithEvents ucrNudWBCapacity As ucrNud
    Friend WithEvents lblWBCapacity As Label
    Friend WithEvents grpSpells As GroupBox
    Friend WithEvents ucrInputSpellUpper As ucrInputTextBox
    Friend WithEvents ucrInputSpellLower As ucrInputTextBox
    Friend WithEvents lblSpellAnd As Label
    Friend WithEvents lblValuesBetween As Label
End Class
