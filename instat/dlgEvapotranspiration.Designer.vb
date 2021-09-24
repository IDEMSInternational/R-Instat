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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgEvapotranspiration))
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
        Me.lblWindSpeed = New System.Windows.Forms.Label()
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
        resources.ApplyResources(Me.lblTmax, "lblTmax")
        Me.lblTmax.Name = "lblTmax"
        '
        'lblTmin
        '
        resources.ApplyResources(Me.lblTmin, "lblTmin")
        Me.lblTmin.Name = "lblTmin"
        '
        'lblHumidityMax
        '
        resources.ApplyResources(Me.lblHumidityMax, "lblHumidityMax")
        Me.lblHumidityMax.Name = "lblHumidityMax"
        '
        'lblHumidityMin
        '
        resources.ApplyResources(Me.lblHumidityMin, "lblHumidityMin")
        Me.lblHumidityMin.Name = "lblHumidityMin"
        '
        'lblTimeStep
        '
        resources.ApplyResources(Me.lblTimeStep, "lblTimeStep")
        Me.lblTimeStep.Name = "lblTimeStep"
        '
        'lblCrop
        '
        resources.ApplyResources(Me.lblCrop, "lblCrop")
        Me.lblCrop.Name = "lblCrop"
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
        '
        'grpMissingDataOpts
        '
        Me.grpMissingDataOpts.Controls.Add(Me.ucrChkInterpMissingEntries)
        Me.grpMissingDataOpts.Controls.Add(Me.ucrChkInterpMissingDays)
        resources.ApplyResources(Me.grpMissingDataOpts, "grpMissingDataOpts")
        Me.grpMissingDataOpts.Name = "grpMissingDataOpts"
        Me.grpMissingDataOpts.TabStop = False
        '
        'ucrChkInterpMissingEntries
        '
        Me.ucrChkInterpMissingEntries.Checked = False
        resources.ApplyResources(Me.ucrChkInterpMissingEntries, "ucrChkInterpMissingEntries")
        Me.ucrChkInterpMissingEntries.Name = "ucrChkInterpMissingEntries"
        '
        'ucrChkInterpMissingDays
        '
        Me.ucrChkInterpMissingDays.Checked = False
        resources.ApplyResources(Me.ucrChkInterpMissingDays, "ucrChkInterpMissingDays")
        Me.ucrChkInterpMissingDays.Name = "ucrChkInterpMissingDays"
        '
        'lblMissingMethod
        '
        resources.ApplyResources(Me.lblMissingMethod, "lblMissingMethod")
        Me.lblMissingMethod.Name = "lblMissingMethod"
        '
        'lblMaxMissingDays
        '
        resources.ApplyResources(Me.lblMaxMissingDays, "lblMaxMissingDays")
        Me.lblMaxMissingDays.Name = "lblMaxMissingDays"
        '
        'lblMaxDurationMissingData
        '
        resources.ApplyResources(Me.lblMaxDurationMissingData, "lblMaxDurationMissingData")
        Me.lblMaxDurationMissingData.Name = "lblMaxDurationMissingData"
        '
        'lblMaxPerctMissindData
        '
        resources.ApplyResources(Me.lblMaxPerctMissindData, "lblMaxPerctMissindData")
        Me.lblMaxPerctMissindData.Name = "lblMaxPerctMissindData"
        '
        'lblSolar
        '
        resources.ApplyResources(Me.lblSolar, "lblSolar")
        Me.lblSolar.Name = "lblSolar"
        '
        'lblRadiation
        '
        resources.ApplyResources(Me.lblRadiation, "lblRadiation")
        Me.lblRadiation.Name = "lblRadiation"
        '
        'grpWindSpeed
        '
        Me.grpWindSpeed.Controls.Add(Me.ucrChkWind)
        Me.grpWindSpeed.Controls.Add(Me.lblWindSpeed)
        Me.grpWindSpeed.Controls.Add(Me.ucrReceiverWindSpeed)
        resources.ApplyResources(Me.grpWindSpeed, "grpWindSpeed")
        Me.grpWindSpeed.Name = "grpWindSpeed"
        Me.grpWindSpeed.TabStop = False
        '
        'ucrChkWind
        '
        Me.ucrChkWind.Checked = False
        resources.ApplyResources(Me.ucrChkWind, "ucrChkWind")
        Me.ucrChkWind.Name = "ucrChkWind"
        '
        'lblWindSpeed
        '
        resources.ApplyResources(Me.lblWindSpeed, "lblWindSpeed")
        Me.lblWindSpeed.Name = "lblWindSpeed"
        '
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWindSpeed, "ucrReceiverWindSpeed")
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.strNcFilePath = ""
        Me.ucrReceiverWindSpeed.ucrSelector = Nothing
        '
        'rdoHargreavesSamani
        '
        resources.ApplyResources(Me.rdoHargreavesSamani, "rdoHargreavesSamani")
        Me.rdoHargreavesSamani.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHargreavesSamani.FlatAppearance.BorderSize = 2
        Me.rdoHargreavesSamani.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHargreavesSamani.Name = "rdoHargreavesSamani"
        Me.rdoHargreavesSamani.TabStop = True
        Me.rdoHargreavesSamani.UseVisualStyleBackColor = True
        '
        'rdoPenmanMonteith
        '
        resources.ApplyResources(Me.rdoPenmanMonteith, "rdoPenmanMonteith")
        Me.rdoPenmanMonteith.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPenmanMonteith.FlatAppearance.BorderSize = 2
        Me.rdoPenmanMonteith.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPenmanMonteith.Name = "rdoPenmanMonteith"
        Me.rdoPenmanMonteith.TabStop = True
        Me.rdoPenmanMonteith.UseVisualStyleBackColor = True
        '
        'ucrNudMaxDurationMissingData
        '
        Me.ucrNudMaxDurationMissingData.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxDurationMissingData.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMaxDurationMissingData, "ucrNudMaxDurationMissingData")
        Me.ucrNudMaxDurationMissingData.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxDurationMissingData.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxDurationMissingData.Name = "ucrNudMaxDurationMissingData"
        Me.ucrNudMaxDurationMissingData.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaxMissingDays
        '
        Me.ucrNudMaxMissingDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxMissingDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMaxMissingDays, "ucrNudMaxMissingDays")
        Me.ucrNudMaxMissingDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxMissingDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxMissingDays.Name = "ucrNudMaxMissingDays"
        Me.ucrNudMaxMissingDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputMissingMethod
        '
        Me.ucrInputMissingMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputMissingMethod.GetSetSelectedIndex = -1
        Me.ucrInputMissingMethod.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMissingMethod, "ucrInputMissingMethod")
        Me.ucrInputMissingMethod.Name = "ucrInputMissingMethod"
        '
        'ucrNudMaxMissingData
        '
        Me.ucrNudMaxMissingData.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxMissingData.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMaxMissingData, "ucrNudMaxMissingData")
        Me.ucrNudMaxMissingData.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxMissingData.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxMissingData.Name = "ucrNudMaxMissingData"
        Me.ucrNudMaxMissingData.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputSolar
        '
        Me.ucrInputSolar.AddQuotesIfUnrecognised = True
        Me.ucrInputSolar.GetSetSelectedIndex = -1
        Me.ucrInputSolar.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSolar, "ucrInputSolar")
        Me.ucrInputSolar.Name = "ucrInputSolar"
        '
        'ucrReceiverRadiation
        '
        Me.ucrReceiverRadiation.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverRadiation, "ucrReceiverRadiation")
        Me.ucrReceiverRadiation.Name = "ucrReceiverRadiation"
        Me.ucrReceiverRadiation.Selector = Nothing
        Me.ucrReceiverRadiation.strNcFilePath = ""
        Me.ucrReceiverRadiation.ucrSelector = Nothing
        '
        'ucrInputCrop
        '
        Me.ucrInputCrop.AddQuotesIfUnrecognised = True
        Me.ucrInputCrop.GetSetSelectedIndex = -1
        Me.ucrInputCrop.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputCrop, "ucrInputCrop")
        Me.ucrInputCrop.Name = "ucrInputCrop"
        '
        'ucrNewColName
        '
        resources.ApplyResources(Me.ucrNewColName, "ucrNewColName")
        Me.ucrNewColName.Name = "ucrNewColName"
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDate, "ucrReceiverDate")
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrPnlMethod
        '
        resources.ApplyResources(Me.ucrPnlMethod, "ucrPnlMethod")
        Me.ucrPnlMethod.Name = "ucrPnlMethod"
        '
        'ucrInputTimeStep
        '
        Me.ucrInputTimeStep.AddQuotesIfUnrecognised = True
        Me.ucrInputTimeStep.GetSetSelectedIndex = -1
        Me.ucrInputTimeStep.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTimeStep, "ucrInputTimeStep")
        Me.ucrInputTimeStep.Name = "ucrInputTimeStep"
        '
        'ucrReceiverHumidityMin
        '
        Me.ucrReceiverHumidityMin.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverHumidityMin, "ucrReceiverHumidityMin")
        Me.ucrReceiverHumidityMin.Name = "ucrReceiverHumidityMin"
        Me.ucrReceiverHumidityMin.Selector = Nothing
        Me.ucrReceiverHumidityMin.strNcFilePath = ""
        Me.ucrReceiverHumidityMin.ucrSelector = Nothing
        '
        'ucrReceiverHumidityMax
        '
        Me.ucrReceiverHumidityMax.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverHumidityMax, "ucrReceiverHumidityMax")
        Me.ucrReceiverHumidityMax.Name = "ucrReceiverHumidityMax"
        Me.ucrReceiverHumidityMax.Selector = Nothing
        Me.ucrReceiverHumidityMax.strNcFilePath = ""
        Me.ucrReceiverHumidityMax.ucrSelector = Nothing
        '
        'ucrReceiverTmin
        '
        Me.ucrReceiverTmin.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverTmin, "ucrReceiverTmin")
        Me.ucrReceiverTmin.Name = "ucrReceiverTmin"
        Me.ucrReceiverTmin.Selector = Nothing
        Me.ucrReceiverTmin.strNcFilePath = ""
        Me.ucrReceiverTmin.ucrSelector = Nothing
        '
        'ucrReceiverTmax
        '
        Me.ucrReceiverTmax.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverTmax, "ucrReceiverTmax")
        Me.ucrReceiverTmax.Name = "ucrReceiverTmax"
        Me.ucrReceiverTmax.Selector = Nothing
        Me.ucrReceiverTmax.strNcFilePath = ""
        Me.ucrReceiverTmax.ucrSelector = Nothing
        '
        'ucrSelectorEvapotranspiration
        '
        Me.ucrSelectorEvapotranspiration.bDropUnusedFilterLevels = False
        Me.ucrSelectorEvapotranspiration.bShowHiddenColumns = False
        Me.ucrSelectorEvapotranspiration.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorEvapotranspiration, "ucrSelectorEvapotranspiration")
        Me.ucrSelectorEvapotranspiration.Name = "ucrSelectorEvapotranspiration"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgEvapotranspiration
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.grpMissingDataOpts.ResumeLayout(False)
        Me.grpWindSpeed.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents lblWindSpeed As Label
    Friend WithEvents ucrReceiverWindSpeed As ucrReceiverSingle
    Friend WithEvents ucrInputSolar As ucrInputComboBox
    Friend WithEvents lblSolar As Label
    Friend WithEvents ucrReceiverRadiation As ucrReceiverSingle
    Friend WithEvents lblRadiation As Label
    Friend WithEvents rdoHargreavesSamani As RadioButton
    Friend WithEvents rdoPenmanMonteith As RadioButton
End Class