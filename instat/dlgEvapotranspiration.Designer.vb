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
        Me.lblMissingMethod = New System.Windows.Forms.Label()
        Me.lblSolar = New System.Windows.Forms.Label()
        Me.lblRadiation = New System.Windows.Forms.Label()
        Me.rdoHargreavesSamani = New System.Windows.Forms.RadioButton()
        Me.rdoPenmanMonteith = New System.Windows.Forms.RadioButton()
        Me.cmdEvapOptions = New System.Windows.Forms.Button()
        Me.ucrInputMissingMethod = New instat.ucrInputComboBox()
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
        Me.ucrReceiverWindSpeed = New instat.ucrReceiverSingle()
        Me.ucrChkWind = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblTmax
        '
        Me.lblTmax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTmax.Location = New System.Drawing.Point(311, 120)
        Me.lblTmax.Name = "lblTmax"
        Me.lblTmax.Size = New System.Drawing.Size(47, 13)
        Me.lblTmax.TabIndex = 8
        Me.lblTmax.Text = "Tmax:"
        '
        'lblTmin
        '
        Me.lblTmin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTmin.Location = New System.Drawing.Point(311, 85)
        Me.lblTmin.Name = "lblTmin"
        Me.lblTmin.Size = New System.Drawing.Size(42, 14)
        Me.lblTmin.TabIndex = 6
        Me.lblTmin.Text = "Tmin:"
        '
        'lblHumidityMax
        '
        Me.lblHumidityMax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHumidityMax.Location = New System.Drawing.Point(311, 156)
        Me.lblHumidityMax.Name = "lblHumidityMax"
        Me.lblHumidityMax.Size = New System.Drawing.Size(124, 19)
        Me.lblHumidityMax.TabIndex = 10
        Me.lblHumidityMax.Text = "Humidity Max:"
        '
        'lblHumidityMin
        '
        Me.lblHumidityMin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHumidityMin.Location = New System.Drawing.Point(311, 197)
        Me.lblHumidityMin.Name = "lblHumidityMin"
        Me.lblHumidityMin.Size = New System.Drawing.Size(123, 19)
        Me.lblHumidityMin.TabIndex = 12
        Me.lblHumidityMin.Text = "Humidity Min:"
        '
        'lblTimeStep
        '
        Me.lblTimeStep.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTimeStep.Location = New System.Drawing.Point(2, 242)
        Me.lblTimeStep.Name = "lblTimeStep"
        Me.lblTimeStep.Size = New System.Drawing.Size(107, 20)
        Me.lblTimeStep.TabIndex = 22
        Me.lblTimeStep.Text = "Time Step"
        '
        'lblCrop
        '
        Me.lblCrop.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCrop.Location = New System.Drawing.Point(2, 344)
        Me.lblCrop.Name = "lblCrop"
        Me.lblCrop.Size = New System.Drawing.Size(71, 20)
        Me.lblCrop.TabIndex = 30
        Me.lblCrop.Text = "Crop"
        '
        'lblDate
        '
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(311, 48)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(43, 14)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date:"
        '
        'lblMissingMethod
        '
        Me.lblMissingMethod.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMissingMethod.Location = New System.Drawing.Point(2, 310)
        Me.lblMissingMethod.Name = "lblMissingMethod"
        Me.lblMissingMethod.Size = New System.Drawing.Size(107, 20)
        Me.lblMissingMethod.TabIndex = 28
        Me.lblMissingMethod.Text = "Missing Method"
        '
        'lblSolar
        '
        Me.lblSolar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSolar.Location = New System.Drawing.Point(2, 275)
        Me.lblSolar.Name = "lblSolar"
        Me.lblSolar.Size = New System.Drawing.Size(58, 18)
        Me.lblSolar.TabIndex = 26
        Me.lblSolar.Text = "Solar"
        '
        'lblRadiation
        '
        Me.lblRadiation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRadiation.Location = New System.Drawing.Point(311, 237)
        Me.lblRadiation.Name = "lblRadiation"
        Me.lblRadiation.Size = New System.Drawing.Size(120, 17)
        Me.lblRadiation.TabIndex = 14
        Me.lblRadiation.Text = "Solar:"
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
        'cmdEvapOptions
        '
        Me.cmdEvapOptions.Location = New System.Drawing.Point(314, 343)
        Me.cmdEvapOptions.Name = "cmdEvapOptions"
        Me.cmdEvapOptions.Size = New System.Drawing.Size(123, 23)
        Me.cmdEvapOptions.TabIndex = 34
        Me.cmdEvapOptions.Tag = "Options"
        Me.cmdEvapOptions.Text = "Missing Options"
        Me.cmdEvapOptions.UseVisualStyleBackColor = True
        '
        'ucrInputMissingMethod
        '
        Me.ucrInputMissingMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputMissingMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMissingMethod.GetSetSelectedIndex = -1
        Me.ucrInputMissingMethod.IsReadOnly = False
        Me.ucrInputMissingMethod.Location = New System.Drawing.Point(109, 310)
        Me.ucrInputMissingMethod.Name = "ucrInputMissingMethod"
        Me.ucrInputMissingMethod.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputMissingMethod.TabIndex = 29
        '
        'ucrInputSolar
        '
        Me.ucrInputSolar.AddQuotesIfUnrecognised = True
        Me.ucrInputSolar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSolar.GetSetSelectedIndex = -1
        Me.ucrInputSolar.IsReadOnly = False
        Me.ucrInputSolar.Location = New System.Drawing.Point(109, 275)
        Me.ucrInputSolar.Name = "ucrInputSolar"
        Me.ucrInputSolar.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSolar.TabIndex = 27
        '
        'ucrReceiverRadiation
        '
        Me.ucrReceiverRadiation.AutoSize = True
        Me.ucrReceiverRadiation.frmParent = Me
        Me.ucrReceiverRadiation.Location = New System.Drawing.Point(314, 254)
        Me.ucrReceiverRadiation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRadiation.Name = "ucrReceiverRadiation"
        Me.ucrReceiverRadiation.Selector = Nothing
        Me.ucrReceiverRadiation.Size = New System.Drawing.Size(123, 20)
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
        Me.ucrInputCrop.Location = New System.Drawing.Point(109, 343)
        Me.ucrInputCrop.Name = "ucrInputCrop"
        Me.ucrInputCrop.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputCrop.TabIndex = 31
        '
        'ucrNewColName
        '
        Me.ucrNewColName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrNewColName.Location = New System.Drawing.Point(5, 386)
        Me.ucrNewColName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNewColName.Name = "ucrNewColName"
        Me.ucrNewColName.Size = New System.Drawing.Size(388, 24)
        Me.ucrNewColName.TabIndex = 32
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(314, 63)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(123, 20)
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
        Me.ucrInputTimeStep.Location = New System.Drawing.Point(109, 241)
        Me.ucrInputTimeStep.Name = "ucrInputTimeStep"
        Me.ucrInputTimeStep.Size = New System.Drawing.Size(113, 21)
        Me.ucrInputTimeStep.TabIndex = 23
        '
        'ucrReceiverHumidityMin
        '
        Me.ucrReceiverHumidityMin.AutoSize = True
        Me.ucrReceiverHumidityMin.frmParent = Me
        Me.ucrReceiverHumidityMin.Location = New System.Drawing.Point(314, 216)
        Me.ucrReceiverHumidityMin.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverHumidityMin.Name = "ucrReceiverHumidityMin"
        Me.ucrReceiverHumidityMin.Selector = Nothing
        Me.ucrReceiverHumidityMin.Size = New System.Drawing.Size(123, 20)
        Me.ucrReceiverHumidityMin.strNcFilePath = ""
        Me.ucrReceiverHumidityMin.TabIndex = 13
        Me.ucrReceiverHumidityMin.ucrSelector = Nothing
        '
        'ucrReceiverHumidityMax
        '
        Me.ucrReceiverHumidityMax.AutoSize = True
        Me.ucrReceiverHumidityMax.frmParent = Me
        Me.ucrReceiverHumidityMax.Location = New System.Drawing.Point(314, 175)
        Me.ucrReceiverHumidityMax.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverHumidityMax.Name = "ucrReceiverHumidityMax"
        Me.ucrReceiverHumidityMax.Selector = Nothing
        Me.ucrReceiverHumidityMax.Size = New System.Drawing.Size(123, 20)
        Me.ucrReceiverHumidityMax.strNcFilePath = ""
        Me.ucrReceiverHumidityMax.TabIndex = 11
        Me.ucrReceiverHumidityMax.ucrSelector = Nothing
        '
        'ucrReceiverTmin
        '
        Me.ucrReceiverTmin.AutoSize = True
        Me.ucrReceiverTmin.frmParent = Me
        Me.ucrReceiverTmin.Location = New System.Drawing.Point(314, 99)
        Me.ucrReceiverTmin.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTmin.Name = "ucrReceiverTmin"
        Me.ucrReceiverTmin.Selector = Nothing
        Me.ucrReceiverTmin.Size = New System.Drawing.Size(123, 20)
        Me.ucrReceiverTmin.strNcFilePath = ""
        Me.ucrReceiverTmin.TabIndex = 7
        Me.ucrReceiverTmin.ucrSelector = Nothing
        '
        'ucrReceiverTmax
        '
        Me.ucrReceiverTmax.AutoSize = True
        Me.ucrReceiverTmax.frmParent = Me
        Me.ucrReceiverTmax.Location = New System.Drawing.Point(314, 133)
        Me.ucrReceiverTmax.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTmax.Name = "ucrReceiverTmax"
        Me.ucrReceiverTmax.Selector = Nothing
        Me.ucrReceiverTmax.Size = New System.Drawing.Size(123, 20)
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
        Me.ucrSelectorEvapotranspiration.Location = New System.Drawing.Point(5, 50)
        Me.ucrSelectorEvapotranspiration.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorEvapotranspiration.Name = "ucrSelectorEvapotranspiration"
        Me.ucrSelectorEvapotranspiration.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorEvapotranspiration.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(5, 421)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 33
        '
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.AutoSize = True
        Me.ucrReceiverWindSpeed.frmParent = Me
        Me.ucrReceiverWindSpeed.Location = New System.Drawing.Point(314, 297)
        Me.ucrReceiverWindSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.Size = New System.Drawing.Size(123, 20)
        Me.ucrReceiverWindSpeed.strNcFilePath = ""
        Me.ucrReceiverWindSpeed.TabIndex = 2
        Me.ucrReceiverWindSpeed.ucrSelector = Nothing
        '
        'ucrChkWind
        '
        Me.ucrChkWind.AutoSize = True
        Me.ucrChkWind.Checked = False
        Me.ucrChkWind.Location = New System.Drawing.Point(314, 277)
        Me.ucrChkWind.Name = "ucrChkWind"
        Me.ucrChkWind.Size = New System.Drawing.Size(123, 31)
        Me.ucrChkWind.TabIndex = 0
        '
        'dlgEvapotranspiration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(453, 478)
        Me.Controls.Add(Me.ucrReceiverWindSpeed)
        Me.Controls.Add(Me.ucrChkWind)
        Me.Controls.Add(Me.cmdEvapOptions)
        Me.Controls.Add(Me.rdoHargreavesSamani)
        Me.Controls.Add(Me.rdoPenmanMonteith)
        Me.Controls.Add(Me.ucrInputMissingMethod)
        Me.Controls.Add(Me.lblMissingMethod)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgEvapotranspiration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evapotranspiration"
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
    Friend WithEvents ucrInputMissingMethod As ucrInputComboBox
    Friend WithEvents lblMissingMethod As Label
    Friend WithEvents ucrNewColName As ucrSave
    Friend WithEvents ucrReceiverTmax As ucrReceiverSingle
    Friend WithEvents ucrInputSolar As ucrInputComboBox
    Friend WithEvents lblSolar As Label
    Friend WithEvents ucrReceiverRadiation As ucrReceiverSingle
    Friend WithEvents lblRadiation As Label
    Friend WithEvents rdoHargreavesSamani As RadioButton
    Friend WithEvents rdoPenmanMonteith As RadioButton
    Friend WithEvents cmdEvapOptions As Button
    Friend WithEvents ucrReceiverWindSpeed As ucrReceiverSingle
    Friend WithEvents ucrChkWind As ucrCheck
End Class