<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgEvapotranspiration
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
        Me.lblTmax = New System.Windows.Forms.Label()
        Me.lblTmin = New System.Windows.Forms.Label()
        Me.lblHumidityMax = New System.Windows.Forms.Label()
        Me.lblHumidityMin = New System.Windows.Forms.Label()
        Me.lblTimeStep = New System.Windows.Forms.Label()
        Me.lblCrop = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.grpMissingDataOpts = New System.Windows.Forms.GroupBox()
        Me.ucrChkInterpMissingEntries = New instat.ucrCheck()
        Me.ucrChkInterpMissingDays = New instat.ucrCheck()
        Me.lblMissingMethod = New System.Windows.Forms.Label()
        Me.lblMaxMissingDays = New System.Windows.Forms.Label()
        Me.lblMaxDurationMissingData = New System.Windows.Forms.Label()
        Me.lblMaxPerctMissindData = New System.Windows.Forms.Label()
        Me.lblSolar = New System.Windows.Forms.Label()
        Me.lblRadiation = New System.Windows.Forms.Label()
        Me.grpWindSpeed = New System.Windows.Forms.GroupBox()
        Me.ucrChkWind = New instat.ucrCheck()
        Me.ucrReceiverWindSpeed = New instat.ucrReceiverSingle()
        Me.rdoHargreavesSamani = New System.Windows.Forms.RadioButton()
        Me.rdoPenmanMonteith = New System.Windows.Forms.RadioButton()
        Me.ucrNudMaxDurationMissingData = New instat.ucrNud()
        Me.ucrNudMaxMissingDays = New instat.ucrNud()
        Me.ucrInputMissingMethod = New instat.ucrInputComboBox()
        Me.ucrNudMaxMissingData = New instat.ucrNud()
        Me.ucrInputSolar = New instat.ucrInputComboBox()
        Me.ucrReceiverRadiation = New instat.ucrReceiverSingle()
        Me.ucrInputCrop = New instat.ucrInputComboBox()
        Me.ucrNewColName = New instat.ucrSave()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrPnlMethod = New instat.UcrPanel()
        Me.ucrInputTimeStep = New instat.ucrInputComboBox()
        Me.ucrReceiverHumidityMin = New instat.ucrReceiverSingle()
        Me.ucrReceiverHumidityMax = New instat.ucrReceiverSingle()
        Me.ucrReceiverTmin = New instat.ucrReceiverSingle()
        Me.ucrReceiverTmax = New instat.ucrReceiverSingle()
        Me.ucrSelectorEvapotranspiration = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpMissingDataOpts.SuspendLayout()
        Me.grpWindSpeed.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTmax
        '
        Me.lblTmax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTmax.Location = New System.Drawing.Point(321, 154)
        Me.lblTmax.Name = "lblTmax"
        Me.lblTmax.Size = New System.Drawing.Size(44, 13)
        Me.lblTmax.TabIndex = 8
        Me.lblTmax.Text = "Tmax:"
        '
        'lblTmin
        '
        Me.lblTmin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTmin.Location = New System.Drawing.Point(321, 107)
        Me.lblTmin.Name = "lblTmin"
        Me.lblTmin.Size = New System.Drawing.Size(39, 14)
        Me.lblTmin.TabIndex = 6
        Me.lblTmin.Text = "Tmin:"
        '
        'lblHumidityMax
        '
        Me.lblHumidityMax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHumidityMax.Location = New System.Drawing.Point(323, 195)
        Me.lblHumidityMax.Name = "lblHumidityMax"
        Me.lblHumidityMax.Size = New System.Drawing.Size(78, 17)
        Me.lblHumidityMax.TabIndex = 10
        Me.lblHumidityMax.Text = "Humidity Max:"
        '
        'lblHumidityMin
        '
        Me.lblHumidityMin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHumidityMin.Location = New System.Drawing.Point(324, 240)
        Me.lblHumidityMin.Name = "lblHumidityMin"
        Me.lblHumidityMin.Size = New System.Drawing.Size(77, 17)
        Me.lblHumidityMin.TabIndex = 12
        Me.lblHumidityMin.Text = "Humidity Min:"
        '
        'lblTimeStep
        '
        Me.lblTimeStep.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTimeStep.Location = New System.Drawing.Point(5, 336)
        Me.lblTimeStep.Name = "lblTimeStep"
        Me.lblTimeStep.Size = New System.Drawing.Size(58, 20)
        Me.lblTimeStep.TabIndex = 22
        Me.lblTimeStep.Text = "Time Step"
        '
        'lblCrop
        '
        Me.lblCrop.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCrop.Location = New System.Drawing.Point(5, 523)
        Me.lblCrop.Name = "lblCrop"
        Me.lblCrop.Size = New System.Drawing.Size(31, 20)
        Me.lblCrop.TabIndex = 30
        Me.lblCrop.Text = "Crop"
        '
        'lblDate
        '
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(323, 64)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(40, 14)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date:"
        '
        'grpMissingDataOpts
        '
        Me.grpMissingDataOpts.Controls.Add(Me.ucrChkInterpMissingEntries)
        Me.grpMissingDataOpts.Controls.Add(Me.ucrChkInterpMissingDays)
        Me.grpMissingDataOpts.Location = New System.Drawing.Point(5, 362)
        Me.grpMissingDataOpts.Name = "grpMissingDataOpts"
        Me.grpMissingDataOpts.Size = New System.Drawing.Size(198, 98)
        Me.grpMissingDataOpts.TabIndex = 24
        Me.grpMissingDataOpts.TabStop = False
        Me.grpMissingDataOpts.Text = "Missing Data Options"
        '
        'ucrChkInterpMissingEntries
        '
        Me.ucrChkInterpMissingEntries.AutoSize = True
        Me.ucrChkInterpMissingEntries.Checked = False
        Me.ucrChkInterpMissingEntries.Location = New System.Drawing.Point(6, 56)
        Me.ucrChkInterpMissingEntries.Name = "ucrChkInterpMissingEntries"
        Me.ucrChkInterpMissingEntries.Size = New System.Drawing.Size(188, 23)
        Me.ucrChkInterpMissingEntries.TabIndex = 5
        '
        'ucrChkInterpMissingDays
        '
        Me.ucrChkInterpMissingDays.AutoSize = True
        Me.ucrChkInterpMissingDays.Checked = False
        Me.ucrChkInterpMissingDays.Location = New System.Drawing.Point(6, 31)
        Me.ucrChkInterpMissingDays.Name = "ucrChkInterpMissingDays"
        Me.ucrChkInterpMissingDays.Size = New System.Drawing.Size(168, 23)
        Me.ucrChkInterpMissingDays.TabIndex = 6
        '
        'lblMissingMethod
        '
        Me.lblMissingMethod.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMissingMethod.Location = New System.Drawing.Point(5, 496)
        Me.lblMissingMethod.Name = "lblMissingMethod"
        Me.lblMissingMethod.Size = New System.Drawing.Size(107, 20)
        Me.lblMissingMethod.TabIndex = 28
        Me.lblMissingMethod.Text = "Missing Method"
        '
        'lblMaxMissingDays
        '
        Me.lblMaxMissingDays.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxMissingDays.Location = New System.Drawing.Point(5, 262)
        Me.lblMaxMissingDays.Name = "lblMaxMissingDays"
        Me.lblMaxMissingDays.Size = New System.Drawing.Size(100, 20)
        Me.lblMaxMissingDays.TabIndex = 16
        Me.lblMaxMissingDays.Text = "Max Missing Days"
        '
        'lblMaxDurationMissingData
        '
        Me.lblMaxDurationMissingData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxDurationMissingData.Location = New System.Drawing.Point(5, 285)
        Me.lblMaxDurationMissingData.Name = "lblMaxDurationMissingData"
        Me.lblMaxDurationMissingData.Size = New System.Drawing.Size(71, 17)
        Me.lblMaxDurationMissingData.TabIndex = 18
        Me.lblMaxDurationMissingData.Text = "Max Duration Missing Data"
        '
        'lblMaxPerctMissindData
        '
        Me.lblMaxPerctMissindData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxPerctMissindData.Location = New System.Drawing.Point(5, 309)
        Me.lblMaxPerctMissindData.Name = "lblMaxPerctMissindData"
        Me.lblMaxPerctMissindData.Size = New System.Drawing.Size(100, 19)
        Me.lblMaxPerctMissindData.TabIndex = 20
        Me.lblMaxPerctMissindData.Text = "Max  Missing Data"
        '
        'lblSolar
        '
        Me.lblSolar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSolar.Location = New System.Drawing.Point(5, 469)
        Me.lblSolar.Name = "lblSolar"
        Me.lblSolar.Size = New System.Drawing.Size(38, 18)
        Me.lblSolar.TabIndex = 26
        Me.lblSolar.Text = "Solar"
        '
        'lblRadiation
        '
        Me.lblRadiation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRadiation.Location = New System.Drawing.Point(323, 285)
        Me.lblRadiation.Name = "lblRadiation"
        Me.lblRadiation.Size = New System.Drawing.Size(117, 17)
        Me.lblRadiation.TabIndex = 14
        Me.lblRadiation.Text = "Radiation:"
        '
        'grpWindSpeed
        '
        Me.grpWindSpeed.Controls.Add(Me.ucrChkWind)
        Me.grpWindSpeed.Controls.Add(Me.ucrReceiverWindSpeed)
        Me.grpWindSpeed.Location = New System.Drawing.Point(210, 363)
        Me.grpWindSpeed.Name = "grpWindSpeed"
        Me.grpWindSpeed.Size = New System.Drawing.Size(235, 97)
        Me.grpWindSpeed.TabIndex = 25
        Me.grpWindSpeed.TabStop = False
        Me.grpWindSpeed.Text = "Wind Speed"
        '
        'ucrChkWind
        '
        Me.ucrChkWind.AutoSize = True
        Me.ucrChkWind.Checked = False
        Me.ucrChkWind.Location = New System.Drawing.Point(5, 31)
        Me.ucrChkWind.Name = "ucrChkWind"
        Me.ucrChkWind.Size = New System.Drawing.Size(103, 23)
        Me.ucrChkWind.TabIndex = 0
        '
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.AutoSize = True
        Me.ucrReceiverWindSpeed.frmParent = Me
        Me.ucrReceiverWindSpeed.Location = New System.Drawing.Point(109, 30)
        Me.ucrReceiverWindSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindSpeed.strNcFilePath = ""
        Me.ucrReceiverWindSpeed.TabIndex = 2
        Me.ucrReceiverWindSpeed.ucrSelector = Nothing
        '
        'rdoHargreavesSamani
        '
        Me.rdoHargreavesSamani.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoHargreavesSamani.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHargreavesSamani.FlatAppearance.BorderSize = 2
        Me.rdoHargreavesSamani.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHargreavesSamani.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoHargreavesSamani.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHargreavesSamani.Location = New System.Drawing.Point(210, 12)
        Me.rdoHargreavesSamani.Name = "rdoHargreavesSamani"
        Me.rdoHargreavesSamani.Size = New System.Drawing.Size(131, 27)
        Me.rdoHargreavesSamani.TabIndex = 2
        Me.rdoHargreavesSamani.TabStop = True
        Me.rdoHargreavesSamani.Text = "Hargreaves- Samani"
        Me.rdoHargreavesSamani.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoHargreavesSamani.UseVisualStyleBackColor = True
        '
        'rdoPenmanMonteith
        '
        Me.rdoPenmanMonteith.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPenmanMonteith.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPenmanMonteith.FlatAppearance.BorderSize = 2
        Me.rdoPenmanMonteith.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPenmanMonteith.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPenmanMonteith.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPenmanMonteith.Location = New System.Drawing.Point(103, 12)
        Me.rdoPenmanMonteith.Name = "rdoPenmanMonteith"
        Me.rdoPenmanMonteith.Size = New System.Drawing.Size(109, 27)
        Me.rdoPenmanMonteith.TabIndex = 1
        Me.rdoPenmanMonteith.TabStop = True
        Me.rdoPenmanMonteith.Text = "Penman-Monteith"
        Me.rdoPenmanMonteith.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPenmanMonteith.UseVisualStyleBackColor = True
        '
        'ucrNudMaxDurationMissingData
        '
        Me.ucrNudMaxDurationMissingData.AutoSize = True
        Me.ucrNudMaxDurationMissingData.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxDurationMissingData.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxDurationMissingData.Location = New System.Drawing.Point(180, 309)
        Me.ucrNudMaxDurationMissingData.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxDurationMissingData.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxDurationMissingData.Name = "ucrNudMaxDurationMissingData"
        Me.ucrNudMaxDurationMissingData.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxDurationMissingData.TabIndex = 21
        Me.ucrNudMaxDurationMissingData.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaxMissingDays
        '
        Me.ucrNudMaxMissingDays.AutoSize = True
        Me.ucrNudMaxMissingDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxMissingDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxMissingDays.Location = New System.Drawing.Point(180, 262)
        Me.ucrNudMaxMissingDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxMissingDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxMissingDays.Name = "ucrNudMaxMissingDays"
        Me.ucrNudMaxMissingDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxMissingDays.TabIndex = 17
        Me.ucrNudMaxMissingDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputMissingMethod
        '
        Me.ucrInputMissingMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputMissingMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMissingMethod.GetSetSelectedIndex = -1
        Me.ucrInputMissingMethod.IsReadOnly = False
        Me.ucrInputMissingMethod.Location = New System.Drawing.Point(139, 493)
        Me.ucrInputMissingMethod.Name = "ucrInputMissingMethod"
        Me.ucrInputMissingMethod.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputMissingMethod.TabIndex = 29
        '
        'ucrNudMaxMissingData
        '
        Me.ucrNudMaxMissingData.AutoSize = True
        Me.ucrNudMaxMissingData.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxMissingData.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxMissingData.Location = New System.Drawing.Point(180, 285)
        Me.ucrNudMaxMissingData.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxMissingData.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxMissingData.Name = "ucrNudMaxMissingData"
        Me.ucrNudMaxMissingData.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxMissingData.TabIndex = 19
        Me.ucrNudMaxMissingData.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputSolar
        '
        Me.ucrInputSolar.AddQuotesIfUnrecognised = True
        Me.ucrInputSolar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSolar.GetSetSelectedIndex = -1
        Me.ucrInputSolar.IsReadOnly = False
        Me.ucrInputSolar.Location = New System.Drawing.Point(139, 466)
        Me.ucrInputSolar.Name = "ucrInputSolar"
        Me.ucrInputSolar.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSolar.TabIndex = 27
        '
        'ucrReceiverRadiation
        '
        Me.ucrReceiverRadiation.AutoSize = True
        Me.ucrReceiverRadiation.frmParent = Me
        Me.ucrReceiverRadiation.Location = New System.Drawing.Point(324, 304)
        Me.ucrReceiverRadiation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRadiation.Name = "ucrReceiverRadiation"
        Me.ucrReceiverRadiation.Selector = Nothing
        Me.ucrReceiverRadiation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRadiation.strNcFilePath = ""
        Me.ucrReceiverRadiation.TabIndex = 15
        Me.ucrReceiverRadiation.ucrSelector = Nothing
        '
        'ucrInputCrop
        '
        Me.ucrInputCrop.AddQuotesIfUnrecognised = True
        Me.ucrInputCrop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCrop.GetSetSelectedIndex = -1
        Me.ucrInputCrop.IsReadOnly = False
        Me.ucrInputCrop.Location = New System.Drawing.Point(139, 520)
        Me.ucrInputCrop.Name = "ucrInputCrop"
        Me.ucrInputCrop.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputCrop.TabIndex = 31
        '
        'ucrNewColName
        '
        Me.ucrNewColName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrNewColName.Location = New System.Drawing.Point(5, 555)
        Me.ucrNewColName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNewColName.Name = "ucrNewColName"
        Me.ucrNewColName.Size = New System.Drawing.Size(388, 24)
        Me.ucrNewColName.TabIndex = 32
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(324, 79)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 5
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrPnlMethod
        '
        Me.ucrPnlMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMethod.Location = New System.Drawing.Point(102, 10)
        Me.ucrPnlMethod.Name = "ucrPnlMethod"
        Me.ucrPnlMethod.Size = New System.Drawing.Size(244, 37)
        Me.ucrPnlMethod.TabIndex = 0
        '
        'ucrInputTimeStep
        '
        Me.ucrInputTimeStep.AddQuotesIfUnrecognised = True
        Me.ucrInputTimeStep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputTimeStep.GetSetSelectedIndex = -1
        Me.ucrInputTimeStep.IsReadOnly = False
        Me.ucrInputTimeStep.Location = New System.Drawing.Point(180, 335)
        Me.ucrInputTimeStep.Name = "ucrInputTimeStep"
        Me.ucrInputTimeStep.Size = New System.Drawing.Size(106, 21)
        Me.ucrInputTimeStep.TabIndex = 23
        '
        'ucrReceiverHumidityMin
        '
        Me.ucrReceiverHumidityMin.AutoSize = True
        Me.ucrReceiverHumidityMin.frmParent = Me
        Me.ucrReceiverHumidityMin.Location = New System.Drawing.Point(324, 259)
        Me.ucrReceiverHumidityMin.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverHumidityMin.Name = "ucrReceiverHumidityMin"
        Me.ucrReceiverHumidityMin.Selector = Nothing
        Me.ucrReceiverHumidityMin.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverHumidityMin.strNcFilePath = ""
        Me.ucrReceiverHumidityMin.TabIndex = 13
        Me.ucrReceiverHumidityMin.ucrSelector = Nothing
        '
        'ucrReceiverHumidityMax
        '
        Me.ucrReceiverHumidityMax.AutoSize = True
        Me.ucrReceiverHumidityMax.frmParent = Me
        Me.ucrReceiverHumidityMax.Location = New System.Drawing.Point(324, 214)
        Me.ucrReceiverHumidityMax.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverHumidityMax.Name = "ucrReceiverHumidityMax"
        Me.ucrReceiverHumidityMax.Selector = Nothing
        Me.ucrReceiverHumidityMax.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverHumidityMax.strNcFilePath = ""
        Me.ucrReceiverHumidityMax.TabIndex = 11
        Me.ucrReceiverHumidityMax.ucrSelector = Nothing
        '
        'ucrReceiverTmin
        '
        Me.ucrReceiverTmin.AutoSize = True
        Me.ucrReceiverTmin.frmParent = Me
        Me.ucrReceiverTmin.Location = New System.Drawing.Point(324, 124)
        Me.ucrReceiverTmin.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTmin.Name = "ucrReceiverTmin"
        Me.ucrReceiverTmin.Selector = Nothing
        Me.ucrReceiverTmin.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTmin.strNcFilePath = ""
        Me.ucrReceiverTmin.TabIndex = 7
        Me.ucrReceiverTmin.ucrSelector = Nothing
        '
        'ucrReceiverTmax
        '
        Me.ucrReceiverTmax.AutoSize = True
        Me.ucrReceiverTmax.frmParent = Me
        Me.ucrReceiverTmax.Location = New System.Drawing.Point(324, 169)
        Me.ucrReceiverTmax.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTmax.Name = "ucrReceiverTmax"
        Me.ucrReceiverTmax.Selector = Nothing
        Me.ucrReceiverTmax.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTmax.strNcFilePath = ""
        Me.ucrReceiverTmax.TabIndex = 9
        Me.ucrReceiverTmax.ucrSelector = Nothing
        '
        'ucrSelectorEvapotranspiration
        '
        Me.ucrSelectorEvapotranspiration.AutoSize = True
        Me.ucrSelectorEvapotranspiration.bDropUnusedFilterLevels = False
        Me.ucrSelectorEvapotranspiration.bShowHiddenColumns = False
        Me.ucrSelectorEvapotranspiration.bUseCurrentFilter = True
        Me.ucrSelectorEvapotranspiration.Location = New System.Drawing.Point(5, 65)
        Me.ucrSelectorEvapotranspiration.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorEvapotranspiration.Name = "ucrSelectorEvapotranspiration"
        Me.ucrSelectorEvapotranspiration.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorEvapotranspiration.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(5, 583)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 33
        '
        'dlgEvapotranspiration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(452, 640)
        Me.Controls.Add(Me.rdoHargreavesSamani)
        Me.Controls.Add(Me.rdoPenmanMonteith)
        Me.Controls.Add(Me.lblMaxPerctMissindData)
        Me.Controls.Add(Me.ucrNudMaxDurationMissingData)
        Me.Controls.Add(Me.ucrNudMaxMissingDays)
        Me.Controls.Add(Me.lblMaxDurationMissingData)
        Me.Controls.Add(Me.lblMaxMissingDays)
        Me.Controls.Add(Me.ucrInputMissingMethod)
        Me.Controls.Add(Me.ucrNudMaxMissingData)
        Me.Controls.Add(Me.lblMissingMethod)
        Me.Controls.Add(Me.grpWindSpeed)
        Me.Controls.Add(Me.lblSolar)
        Me.Controls.Add(Me.ucrInputSolar)
        Me.Controls.Add(Me.lblRadiation)
        Me.Controls.Add(Me.ucrReceiverRadiation)
        Me.Controls.Add(Me.ucrInputCrop)
        Me.Controls.Add(Me.ucrNewColName)
        Me.Controls.Add(Me.grpMissingDataOpts)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrPnlMethod)
        Me.Controls.Add(Me.lblCrop)
        Me.Controls.Add(Me.lblTimeStep)
        Me.Controls.Add(Me.ucrInputTimeStep)
        Me.Controls.Add(Me.lblHumidityMin)
        Me.Controls.Add(Me.ucrReceiverHumidityMin)
        Me.Controls.Add(Me.lblHumidityMax)
        Me.Controls.Add(Me.ucrReceiverHumidityMax)
        Me.Controls.Add(Me.lblTmin)
        Me.Controls.Add(Me.ucrReceiverTmin)
        Me.Controls.Add(Me.lblTmax)
        Me.Controls.Add(Me.ucrReceiverTmax)
        Me.Controls.Add(Me.ucrSelectorEvapotranspiration)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgEvapotranspiration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evapotranspiration"
        Me.grpMissingDataOpts.ResumeLayout(False)
        Me.grpMissingDataOpts.PerformLayout()
        Me.grpWindSpeed.ResumeLayout(False)
        Me.grpWindSpeed.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorEvapotranspiration As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblTmax As Label
    Friend WithEvents lblHumidityMin As Label
    Friend WithEvents ucrReceiverHumidityMin As ucrReceiverSingle
    Friend WithEvents lblHumidityMax As Label
    Friend WithEvents ucrReceiverHumidityMax As ucrReceiverSingle
    Friend WithEvents lblTmin As Label
    Friend WithEvents ucrReceiverTmin As ucrReceiverSingle
    Friend WithEvents lblCrop As Label
    Friend WithEvents ucrInputCrop As ucrInputComboBox
    Friend WithEvents lblTimeStep As Label
    Friend WithEvents ucrInputTimeStep As ucrInputComboBox
    Friend WithEvents ucrPnlMethod As UcrPanel
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lblDate As Label
    Friend WithEvents grpMissingDataOpts As GroupBox
    Friend WithEvents lblMaxMissingDays As Label
    Friend WithEvents lblMaxDurationMissingData As Label
    Friend WithEvents lblMaxPerctMissindData As Label
    Friend WithEvents ucrChkInterpMissingEntries As ucrCheck
    Friend WithEvents ucrChkInterpMissingDays As ucrCheck
    Friend WithEvents ucrNudMaxMissingDays As ucrNud
    Friend WithEvents ucrNudMaxDurationMissingData As ucrNud
    Friend WithEvents ucrNudMaxMissingData As ucrNud
    Friend WithEvents ucrInputMissingMethod As ucrInputComboBox
    Friend WithEvents lblMissingMethod As Label
    Friend WithEvents ucrNewColName As ucrSave
    Friend WithEvents ucrReceiverTmax As ucrReceiverSingle
    Friend WithEvents grpWindSpeed As GroupBox
    Friend WithEvents ucrChkWind As ucrCheck
    Friend WithEvents ucrReceiverWindSpeed As ucrReceiverSingle
    Friend WithEvents ucrInputSolar As ucrInputComboBox
    Friend WithEvents lblSolar As Label
    Friend WithEvents ucrReceiverRadiation As ucrReceiverSingle
    Friend WithEvents lblRadiation As Label
    Friend WithEvents rdoHargreavesSamani As RadioButton
    Friend WithEvents rdoPenmanMonteith As RadioButton
End Class