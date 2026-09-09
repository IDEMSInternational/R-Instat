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
        Me.cmdHSConstants = New System.Windows.Forms.Button()
        Me.cmdLocation = New System.Windows.Forms.Button()
        Me.cmdPMConstants = New System.Windows.Forms.Button()
        Me.cmdHSMissingOptions = New System.Windows.Forms.Button()
        Me.cmdEvapOptions = New System.Windows.Forms.Button()
        Me.rdoHargreavesSamani = New System.Windows.Forms.RadioButton()
        Me.rdoPenmanMonteith = New System.Windows.Forms.RadioButton()
        Me.lblSolar = New System.Windows.Forms.Label()
        Me.lblRadiation = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblCrop = New System.Windows.Forms.Label()
        Me.lblTimeStep = New System.Windows.Forms.Label()
        Me.lblHumidityMin = New System.Windows.Forms.Label()
        Me.lblHumidityMax = New System.Windows.Forms.Label()
        Me.lblTmin = New System.Windows.Forms.Label()
        Me.lblTmax = New System.Windows.Forms.Label()
        Me.rdoPriestleyTaylor = New System.Windows.Forms.RadioButton()
        Me.lblRA = New System.Windows.Forms.Label()
        Me.lblAlpha = New System.Windows.Forms.Label()
        Me.ucrReceiverWindSpeed = New instat.ucrReceiverSingle()
        Me.ucrChkWind = New instat.ucrCheck()
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
        Me.ucrReceiverExtraRadiation = New instat.ucrReceiverSingle()
        Me.ucrNudAlpha = New instat.ucrNud()
        Me.cmdPTConstants = New System.Windows.Forms.Button()
        Me.lblStationReceiver = New System.Windows.Forms.Label()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'cmdHSConstants
        '
        Me.cmdHSConstants.Location = New System.Drawing.Point(214, 428)
        Me.cmdHSConstants.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdHSConstants.Name = "cmdHSConstants"
        Me.cmdHSConstants.Size = New System.Drawing.Size(154, 29)
        Me.cmdHSConstants.TabIndex = 69
        Me.cmdHSConstants.Tag = "Options"
        Me.cmdHSConstants.Text = "Constants"
        Me.cmdHSConstants.UseVisualStyleBackColor = True
        '
        'cmdLocation
        '
        Me.cmdLocation.Location = New System.Drawing.Point(12, 426)
        Me.cmdLocation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdLocation.Name = "cmdLocation"
        Me.cmdLocation.Size = New System.Drawing.Size(154, 29)
        Me.cmdLocation.TabIndex = 68
        Me.cmdLocation.Tag = "Options"
        Me.cmdLocation.Text = "Location"
        Me.cmdLocation.UseVisualStyleBackColor = True
        '
        'cmdPMConstants
        '
        Me.cmdPMConstants.Location = New System.Drawing.Point(214, 428)
        Me.cmdPMConstants.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdPMConstants.Name = "cmdPMConstants"
        Me.cmdPMConstants.Size = New System.Drawing.Size(154, 29)
        Me.cmdPMConstants.TabIndex = 67
        Me.cmdPMConstants.Tag = "Options"
        Me.cmdPMConstants.Text = "Constants"
        Me.cmdPMConstants.UseVisualStyleBackColor = True
        '
        'cmdHSMissingOptions
        '
        Me.cmdHSMissingOptions.Location = New System.Drawing.Point(399, 426)
        Me.cmdHSMissingOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdHSMissingOptions.Name = "cmdHSMissingOptions"
        Me.cmdHSMissingOptions.Size = New System.Drawing.Size(154, 29)
        Me.cmdHSMissingOptions.TabIndex = 66
        Me.cmdHSMissingOptions.Tag = "Options"
        Me.cmdHSMissingOptions.Text = "Missing Options"
        Me.cmdHSMissingOptions.UseVisualStyleBackColor = True
        '
        'cmdEvapOptions
        '
        Me.cmdEvapOptions.Location = New System.Drawing.Point(399, 426)
        Me.cmdEvapOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdEvapOptions.Name = "cmdEvapOptions"
        Me.cmdEvapOptions.Size = New System.Drawing.Size(154, 29)
        Me.cmdEvapOptions.TabIndex = 65
        Me.cmdEvapOptions.Tag = "Options"
        Me.cmdEvapOptions.Text = "Missing Options"
        Me.cmdEvapOptions.UseVisualStyleBackColor = True
        '
        'rdoHargreavesSamani
        '
        Me.rdoHargreavesSamani.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoHargreavesSamani.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHargreavesSamani.FlatAppearance.BorderSize = 2
        Me.rdoHargreavesSamani.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHargreavesSamani.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoHargreavesSamani.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHargreavesSamani.Location = New System.Drawing.Point(188, 12)
        Me.rdoHargreavesSamani.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoHargreavesSamani.Name = "rdoHargreavesSamani"
        Me.rdoHargreavesSamani.Size = New System.Drawing.Size(164, 34)
        Me.rdoHargreavesSamani.TabIndex = 43
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
        Me.rdoPenmanMonteith.Location = New System.Drawing.Point(54, 12)
        Me.rdoPenmanMonteith.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoPenmanMonteith.Name = "rdoPenmanMonteith"
        Me.rdoPenmanMonteith.Size = New System.Drawing.Size(136, 34)
        Me.rdoPenmanMonteith.TabIndex = 41
        Me.rdoPenmanMonteith.TabStop = True
        Me.rdoPenmanMonteith.Text = "Penman-Monteith"
        Me.rdoPenmanMonteith.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPenmanMonteith.UseVisualStyleBackColor = True
        '
        'lblSolar
        '
        Me.lblSolar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSolar.Location = New System.Drawing.Point(12, 336)
        Me.lblSolar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSolar.Name = "lblSolar"
        Me.lblSolar.Size = New System.Drawing.Size(72, 22)
        Me.lblSolar.TabIndex = 59
        Me.lblSolar.Text = "Solar"
        '
        'lblRadiation
        '
        Me.lblRadiation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRadiation.Location = New System.Drawing.Point(399, 300)
        Me.lblRadiation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRadiation.Name = "lblRadiation"
        Me.lblRadiation.Size = New System.Drawing.Size(150, 16)
        Me.lblRadiation.TabIndex = 55
        Me.lblRadiation.Text = "Solar:"
        '
        'lblDate
        '
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(399, 56)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(54, 16)
        Me.lblDate.TabIndex = 45
        Me.lblDate.Text = "Date:"
        '
        'lblCrop
        '
        Me.lblCrop.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCrop.Location = New System.Drawing.Point(12, 371)
        Me.lblCrop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCrop.Name = "lblCrop"
        Me.lblCrop.Size = New System.Drawing.Size(89, 25)
        Me.lblCrop.TabIndex = 61
        Me.lblCrop.Text = "Crop"
        '
        'lblTimeStep
        '
        Me.lblTimeStep.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTimeStep.Location = New System.Drawing.Point(12, 300)
        Me.lblTimeStep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimeStep.Name = "lblTimeStep"
        Me.lblTimeStep.Size = New System.Drawing.Size(115, 25)
        Me.lblTimeStep.TabIndex = 57
        Me.lblTimeStep.Text = "Time Step"
        '
        'lblHumidityMin
        '
        Me.lblHumidityMin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHumidityMin.Location = New System.Drawing.Point(399, 250)
        Me.lblHumidityMin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHumidityMin.Name = "lblHumidityMin"
        Me.lblHumidityMin.Size = New System.Drawing.Size(154, 16)
        Me.lblHumidityMin.TabIndex = 53
        Me.lblHumidityMin.Text = "Humidity Min:"
        '
        'lblHumidityMax
        '
        Me.lblHumidityMax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHumidityMax.Location = New System.Drawing.Point(399, 201)
        Me.lblHumidityMax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHumidityMax.Name = "lblHumidityMax"
        Me.lblHumidityMax.Size = New System.Drawing.Size(155, 16)
        Me.lblHumidityMax.TabIndex = 51
        Me.lblHumidityMax.Text = "Humidity Max:"
        '
        'lblTmin
        '
        Me.lblTmin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTmin.Location = New System.Drawing.Point(399, 105)
        Me.lblTmin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTmin.Name = "lblTmin"
        Me.lblTmin.Size = New System.Drawing.Size(52, 16)
        Me.lblTmin.TabIndex = 47
        Me.lblTmin.Text = "Tmin:"
        '
        'lblTmax
        '
        Me.lblTmax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTmax.Location = New System.Drawing.Point(399, 154)
        Me.lblTmax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTmax.Name = "lblTmax"
        Me.lblTmax.Size = New System.Drawing.Size(59, 16)
        Me.lblTmax.TabIndex = 49
        Me.lblTmax.Text = "Tmax:"
        '
        'rdoPriestleyTaylor
        '
        Me.rdoPriestleyTaylor.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPriestleyTaylor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPriestleyTaylor.FlatAppearance.BorderSize = 2
        Me.rdoPriestleyTaylor.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPriestleyTaylor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPriestleyTaylor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPriestleyTaylor.Location = New System.Drawing.Point(349, 12)
        Me.rdoPriestleyTaylor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoPriestleyTaylor.Name = "rdoPriestleyTaylor"
        Me.rdoPriestleyTaylor.Size = New System.Drawing.Size(164, 34)
        Me.rdoPriestleyTaylor.TabIndex = 70
        Me.rdoPriestleyTaylor.TabStop = True
        Me.rdoPriestleyTaylor.Text = "Priestley-Taylor"
        Me.rdoPriestleyTaylor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPriestleyTaylor.UseVisualStyleBackColor = True
        '
        'lblRA
        '
        Me.lblRA.AutoSize = True
        Me.lblRA.Location = New System.Drawing.Point(399, 201)
        Me.lblRA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRA.Name = "lblRA"
        Me.lblRA.Size = New System.Drawing.Size(156, 16)
        Me.lblRA.TabIndex = 39
        Me.lblRA.Text = "Extraterrestrial Radiation:"
        '
        'lblAlpha
        '
        Me.lblAlpha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAlpha.Location = New System.Drawing.Point(15, 371)
        Me.lblAlpha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAlpha.Name = "lblAlpha"
        Me.lblAlpha.Size = New System.Drawing.Size(89, 25)
        Me.lblAlpha.TabIndex = 37
        Me.lblAlpha.Text = "Alpha"
        '
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.AutoSize = True
        Me.ucrReceiverWindSpeed.frmParent = Me
        Me.ucrReceiverWindSpeed.Location = New System.Drawing.Point(399, 391)
        Me.ucrReceiverWindSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.Size = New System.Drawing.Size(154, 25)
        Me.ucrReceiverWindSpeed.strNcFilePath = ""
        Me.ucrReceiverWindSpeed.TabIndex = 42
        Me.ucrReceiverWindSpeed.ucrSelector = Nothing
        '
        'ucrChkWind
        '
        Me.ucrChkWind.AutoSize = True
        Me.ucrChkWind.Checked = False
        Me.ucrChkWind.Location = New System.Drawing.Point(399, 362)
        Me.ucrChkWind.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.ucrChkWind.Name = "ucrChkWind"
        Me.ucrChkWind.Size = New System.Drawing.Size(154, 29)
        Me.ucrChkWind.TabIndex = 39
        '
        'ucrInputSolar
        '
        Me.ucrInputSolar.AddQuotesIfUnrecognised = True
        Me.ucrInputSolar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSolar.GetSetSelectedIndex = -1
        Me.ucrInputSolar.IsReadOnly = False
        Me.ucrInputSolar.Location = New System.Drawing.Point(142, 332)
        Me.ucrInputSolar.Margin = New System.Windows.Forms.Padding(11, 11, 11, 11)
        Me.ucrInputSolar.Name = "ucrInputSolar"
        Me.ucrInputSolar.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputSolar.TabIndex = 60
        '
        'ucrReceiverRadiation
        '
        Me.ucrReceiverRadiation.AutoSize = True
        Me.ucrReceiverRadiation.frmParent = Me
        Me.ucrReceiverRadiation.Location = New System.Drawing.Point(399, 320)
        Me.ucrReceiverRadiation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRadiation.Name = "ucrReceiverRadiation"
        Me.ucrReceiverRadiation.Selector = Nothing
        Me.ucrReceiverRadiation.Size = New System.Drawing.Size(154, 25)
        Me.ucrReceiverRadiation.strNcFilePath = ""
        Me.ucrReceiverRadiation.TabIndex = 56
        Me.ucrReceiverRadiation.ucrSelector = Nothing
        '
        'ucrInputCrop
        '
        Me.ucrInputCrop.AddQuotesIfUnrecognised = True
        Me.ucrInputCrop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCrop.GetSetSelectedIndex = -1
        Me.ucrInputCrop.IsReadOnly = False
        Me.ucrInputCrop.Location = New System.Drawing.Point(142, 365)
        Me.ucrInputCrop.Margin = New System.Windows.Forms.Padding(11, 11, 11, 11)
        Me.ucrInputCrop.Name = "ucrInputCrop"
        Me.ucrInputCrop.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputCrop.TabIndex = 62
        '
        'ucrNewColName
        '
        Me.ucrNewColName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrNewColName.Location = New System.Drawing.Point(12, 480)
        Me.ucrNewColName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrNewColName.Name = "ucrNewColName"
        Me.ucrNewColName.Size = New System.Drawing.Size(485, 30)
        Me.ucrNewColName.TabIndex = 63
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(399, 76)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(154, 25)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 46
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrPnlMethod
        '
        Me.ucrPnlMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMethod.Location = New System.Drawing.Point(51, 10)
        Me.ucrPnlMethod.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.ucrPnlMethod.Name = "ucrPnlMethod"
        Me.ucrPnlMethod.Size = New System.Drawing.Size(496, 46)
        Me.ucrPnlMethod.TabIndex = 40
        '
        'ucrInputTimeStep
        '
        Me.ucrInputTimeStep.AddQuotesIfUnrecognised = True
        Me.ucrInputTimeStep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputTimeStep.GetSetSelectedIndex = -1
        Me.ucrInputTimeStep.IsReadOnly = False
        Me.ucrInputTimeStep.Location = New System.Drawing.Point(142, 300)
        Me.ucrInputTimeStep.Margin = New System.Windows.Forms.Padding(11, 11, 11, 11)
        Me.ucrInputTimeStep.Name = "ucrInputTimeStep"
        Me.ucrInputTimeStep.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputTimeStep.TabIndex = 58
        '
        'ucrReceiverHumidityMin
        '
        Me.ucrReceiverHumidityMin.AutoSize = True
        Me.ucrReceiverHumidityMin.frmParent = Me
        Me.ucrReceiverHumidityMin.Location = New System.Drawing.Point(399, 270)
        Me.ucrReceiverHumidityMin.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverHumidityMin.Name = "ucrReceiverHumidityMin"
        Me.ucrReceiverHumidityMin.Selector = Nothing
        Me.ucrReceiverHumidityMin.Size = New System.Drawing.Size(154, 25)
        Me.ucrReceiverHumidityMin.strNcFilePath = ""
        Me.ucrReceiverHumidityMin.TabIndex = 54
        Me.ucrReceiverHumidityMin.ucrSelector = Nothing
        '
        'ucrReceiverHumidityMax
        '
        Me.ucrReceiverHumidityMax.AutoSize = True
        Me.ucrReceiverHumidityMax.frmParent = Me
        Me.ucrReceiverHumidityMax.Location = New System.Drawing.Point(399, 221)
        Me.ucrReceiverHumidityMax.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverHumidityMax.Name = "ucrReceiverHumidityMax"
        Me.ucrReceiverHumidityMax.Selector = Nothing
        Me.ucrReceiverHumidityMax.Size = New System.Drawing.Size(154, 25)
        Me.ucrReceiverHumidityMax.strNcFilePath = ""
        Me.ucrReceiverHumidityMax.TabIndex = 52
        Me.ucrReceiverHumidityMax.ucrSelector = Nothing
        '
        'ucrReceiverTmin
        '
        Me.ucrReceiverTmin.AutoSize = True
        Me.ucrReceiverTmin.frmParent = Me
        Me.ucrReceiverTmin.Location = New System.Drawing.Point(399, 124)
        Me.ucrReceiverTmin.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTmin.Name = "ucrReceiverTmin"
        Me.ucrReceiverTmin.Selector = Nothing
        Me.ucrReceiverTmin.Size = New System.Drawing.Size(154, 25)
        Me.ucrReceiverTmin.strNcFilePath = ""
        Me.ucrReceiverTmin.TabIndex = 48
        Me.ucrReceiverTmin.ucrSelector = Nothing
        '
        'ucrReceiverTmax
        '
        Me.ucrReceiverTmax.AutoSize = True
        Me.ucrReceiverTmax.frmParent = Me
        Me.ucrReceiverTmax.Location = New System.Drawing.Point(399, 172)
        Me.ucrReceiverTmax.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTmax.Name = "ucrReceiverTmax"
        Me.ucrReceiverTmax.Selector = Nothing
        Me.ucrReceiverTmax.Size = New System.Drawing.Size(154, 25)
        Me.ucrReceiverTmax.strNcFilePath = ""
        Me.ucrReceiverTmax.TabIndex = 50
        Me.ucrReceiverTmax.ucrSelector = Nothing
        '
        'ucrSelectorEvapotranspiration
        '
        Me.ucrSelectorEvapotranspiration.AutoSize = True
        Me.ucrSelectorEvapotranspiration.bDropUnusedFilterLevels = False
        Me.ucrSelectorEvapotranspiration.bShowHiddenColumns = False
        Me.ucrSelectorEvapotranspiration.bUseCurrentFilter = True
        Me.ucrSelectorEvapotranspiration.Location = New System.Drawing.Point(12, 60)
        Me.ucrSelectorEvapotranspiration.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorEvapotranspiration.Name = "ucrSelectorEvapotranspiration"
        Me.ucrSelectorEvapotranspiration.Size = New System.Drawing.Size(266, 229)
        Me.ucrSelectorEvapotranspiration.TabIndex = 44
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(12, 524)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(511, 65)
        Me.ucrBase.TabIndex = 64
        '
        'ucrReceiverExtraRadiation
        '
        Me.ucrReceiverExtraRadiation.AutoSize = True
        Me.ucrReceiverExtraRadiation.frmParent = Me
        Me.ucrReceiverExtraRadiation.Location = New System.Drawing.Point(399, 221)
        Me.ucrReceiverExtraRadiation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverExtraRadiation.Name = "ucrReceiverExtraRadiation"
        Me.ucrReceiverExtraRadiation.Selector = Nothing
        Me.ucrReceiverExtraRadiation.Size = New System.Drawing.Size(154, 25)
        Me.ucrReceiverExtraRadiation.strNcFilePath = ""
        Me.ucrReceiverExtraRadiation.TabIndex = 40
        Me.ucrReceiverExtraRadiation.ucrSelector = Nothing
        '
        'ucrNudAlpha
        '
        Me.ucrNudAlpha.AutoSize = True
        Me.ucrNudAlpha.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAlpha.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAlpha.Location = New System.Drawing.Point(142, 368)
        Me.ucrNudAlpha.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudAlpha.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAlpha.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAlpha.Name = "ucrNudAlpha"
        Me.ucrNudAlpha.Size = New System.Drawing.Size(62, 29)
        Me.ucrNudAlpha.TabIndex = 71
        Me.ucrNudAlpha.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmdPTConstants
        '
        Me.cmdPTConstants.Location = New System.Drawing.Point(214, 426)
        Me.cmdPTConstants.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdPTConstants.Name = "cmdPTConstants"
        Me.cmdPTConstants.Size = New System.Drawing.Size(154, 29)
        Me.cmdPTConstants.TabIndex = 72
        Me.cmdPTConstants.Tag = "Options"
        Me.cmdPTConstants.Text = "Constants"
        Me.cmdPTConstants.UseVisualStyleBackColor = True
        '
        'lblStationReceiver
        '
        Me.lblStationReceiver.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStationReceiver.Location = New System.Drawing.Point(399, 250)
        Me.lblStationReceiver.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStationReceiver.Name = "lblStationReceiver"
        Me.lblStationReceiver.Size = New System.Drawing.Size(154, 16)
        Me.lblStationReceiver.TabIndex = 73
        Me.lblStationReceiver.Text = "Station:"
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(399, 270)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(154, 25)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 74
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'dlgEvapotranspiration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(566, 598)
        Me.Controls.Add(Me.ucrNudAlpha)
        Me.Controls.Add(Me.rdoPriestleyTaylor)
        Me.Controls.Add(Me.cmdHSConstants)
        Me.Controls.Add(Me.cmdLocation)
        Me.Controls.Add(Me.cmdPMConstants)
        Me.Controls.Add(Me.cmdHSMissingOptions)
        Me.Controls.Add(Me.ucrReceiverWindSpeed)
        Me.Controls.Add(Me.ucrChkWind)
        Me.Controls.Add(Me.cmdEvapOptions)
        Me.Controls.Add(Me.rdoHargreavesSamani)
        Me.Controls.Add(Me.rdoPenmanMonteith)
        Me.Controls.Add(Me.lblSolar)
        Me.Controls.Add(Me.ucrInputSolar)
        Me.Controls.Add(Me.lblRadiation)
        Me.Controls.Add(Me.ucrReceiverRadiation)
        Me.Controls.Add(Me.ucrInputCrop)
        Me.Controls.Add(Me.ucrNewColName)
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
        Me.Controls.Add(Me.lblRA)
        Me.Controls.Add(Me.ucrReceiverExtraRadiation)
        Me.Controls.Add(Me.lblAlpha)
        Me.Controls.Add(Me.cmdPTConstants)
        Me.Controls.Add(Me.lblStationReceiver)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgEvapotranspiration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evapotranspiration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdHSConstants As Button
    Friend WithEvents cmdLocation As Button
    Friend WithEvents cmdPMConstants As Button
    Friend WithEvents cmdHSMissingOptions As Button
    Friend WithEvents ucrReceiverWindSpeed As ucrReceiverSingle
    Friend WithEvents ucrChkWind As ucrCheck
    Friend WithEvents cmdEvapOptions As Button
    Friend WithEvents rdoHargreavesSamani As RadioButton
    Friend WithEvents rdoPenmanMonteith As RadioButton
    Friend WithEvents lblSolar As Label
    Friend WithEvents ucrInputSolar As ucrInputComboBox
    Friend WithEvents lblRadiation As Label
    Friend WithEvents ucrReceiverRadiation As ucrReceiverSingle
    Friend WithEvents ucrInputCrop As ucrInputComboBox
    Friend WithEvents ucrNewColName As ucrSave
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrPnlMethod As UcrPanel
    Friend WithEvents lblCrop As Label
    Friend WithEvents lblTimeStep As Label
    Friend WithEvents ucrInputTimeStep As ucrInputComboBox
    Friend WithEvents lblHumidityMin As Label
    Friend WithEvents ucrReceiverHumidityMin As ucrReceiverSingle
    Friend WithEvents lblHumidityMax As Label
    Friend WithEvents ucrReceiverHumidityMax As ucrReceiverSingle
    Friend WithEvents lblTmin As Label
    Friend WithEvents ucrReceiverTmin As ucrReceiverSingle
    Friend WithEvents lblTmax As Label
    Friend WithEvents ucrReceiverTmax As ucrReceiverSingle
    Friend WithEvents ucrSelectorEvapotranspiration As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents rdoPriestleyTaylor As RadioButton
    Friend WithEvents ucrReceiverExtraRadiation As ucrReceiverSingle
    Friend WithEvents lblRA As Label
    Friend WithEvents ucrNudAlpha As ucrNud
    Friend WithEvents lblAlpha As Label
    Friend WithEvents cmdPTConstants As Button
    Friend WithEvents lblStationReceiver As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
End Class