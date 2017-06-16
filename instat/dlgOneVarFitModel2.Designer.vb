<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgOneVarFitModel
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
        Me.chkConvertToVariate = New System.Windows.Forms.CheckBox()
        Me.cmdFittingOptions = New System.Windows.Forms.Button()
        Me.LblVariable = New System.Windows.Forms.Label()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.lblHyp = New System.Windows.Forms.Label()
        Me.chkBinModify = New System.Windows.Forms.CheckBox()
        Me.lblSuccessIf = New System.Windows.Forms.Label()
        Me.lblConfidenceLimit = New System.Windows.Forms.Label()
        Me.nudBinomialConditions = New System.Windows.Forms.NumericUpDown()
        Me.lblEquals = New System.Windows.Forms.Label()
        Me.ucrVariables = New instat.ucrInputComboBox()
        Me.ucrOperator = New instat.ucrInputComboBox()
        Me.ucrFamily = New instat.ucrDistributions()
        Me.UcrReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorOneVarFitMod = New instat.ucrSelectorByDataFrameAddRemove()
        Me.UcrBase = New instat.ucrButtons()
        Me.grpConditions = New System.Windows.Forms.GroupBox()
        Me.ucrNudHyp = New instat.ucrNud()
        Me.ucrNudCI = New instat.ucrNud()
        Me.rdoEnorm = New System.Windows.Forms.RadioButton()
        Me.rdoVarSign = New System.Windows.Forms.RadioButton()
        Me.rdoMeanWilcox = New System.Windows.Forms.RadioButton()
        Me.ucrSaveModel = New instat.ucrSave()
        Me.rdoExactCase = New System.Windows.Forms.RadioButton()
        Me.rdoGeneralCase = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGeneralExactCase = New instat.UcrPanel()
        CType(Me.nudBinomialConditions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConditions.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkConvertToVariate
        '
        Me.chkConvertToVariate.AutoSize = True
        Me.chkConvertToVariate.Location = New System.Drawing.Point(249, 98)
        Me.chkConvertToVariate.Name = "chkConvertToVariate"
        Me.chkConvertToVariate.Size = New System.Drawing.Size(111, 17)
        Me.chkConvertToVariate.TabIndex = 4
        Me.chkConvertToVariate.Text = "Convert to Variate"
        Me.chkConvertToVariate.UseVisualStyleBackColor = True
        '
        'cmdFittingOptions
        '
        Me.cmdFittingOptions.Location = New System.Drawing.Point(312, 244)
        Me.cmdFittingOptions.Name = "cmdFittingOptions"
        Me.cmdFittingOptions.Size = New System.Drawing.Size(92, 23)
        Me.cmdFittingOptions.TabIndex = 7
        Me.cmdFittingOptions.Text = "Fitting Options"
        Me.cmdFittingOptions.UseVisualStyleBackColor = True
        '
        'LblVariable
        '
        Me.LblVariable.AutoSize = True
        Me.LblVariable.Location = New System.Drawing.Point(249, 47)
        Me.LblVariable.Name = "LblVariable"
        Me.LblVariable.Size = New System.Drawing.Size(48, 13)
        Me.LblVariable.TabIndex = 8
        Me.LblVariable.Text = "Variable:"
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(313, 273)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(92, 23)
        Me.cmdDisplayOptions.TabIndex = 10
        Me.cmdDisplayOptions.Text = "Display Options"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'lblHyp
        '
        Me.lblHyp.AutoSize = True
        Me.lblHyp.Location = New System.Drawing.Point(6, 51)
        Me.lblHyp.Name = "lblHyp"
        Me.lblHyp.Size = New System.Drawing.Size(83, 13)
        Me.lblHyp.TabIndex = 17
        Me.lblHyp.Text = "Null Hypothesis:"
        '
        'chkBinModify
        '
        Me.chkBinModify.AutoSize = True
        Me.chkBinModify.Location = New System.Drawing.Point(9, 77)
        Me.chkBinModify.Name = "chkBinModify"
        Me.chkBinModify.Size = New System.Drawing.Size(172, 17)
        Me.chkBinModify.TabIndex = 18
        Me.chkBinModify.Text = "Modify Conditions for 'Success'"
        Me.chkBinModify.UseVisualStyleBackColor = True
        '
        'lblSuccessIf
        '
        Me.lblSuccessIf.AutoSize = True
        Me.lblSuccessIf.Location = New System.Drawing.Point(6, 108)
        Me.lblSuccessIf.Name = "lblSuccessIf"
        Me.lblSuccessIf.Size = New System.Drawing.Size(66, 13)
        Me.lblSuccessIf.TabIndex = 19
        Me.lblSuccessIf.Text = "Success if X"
        '
        'lblConfidenceLimit
        '
        Me.lblConfidenceLimit.AutoSize = True
        Me.lblConfidenceLimit.Location = New System.Drawing.Point(6, 24)
        Me.lblConfidenceLimit.Name = "lblConfidenceLimit"
        Me.lblConfidenceLimit.Size = New System.Drawing.Size(88, 13)
        Me.lblConfidenceLimit.TabIndex = 22
        Me.lblConfidenceLimit.Text = "Confidence Limit:"
        '
        'nudBinomialConditions
        '
        Me.nudBinomialConditions.DecimalPlaces = 2
        Me.nudBinomialConditions.Location = New System.Drawing.Point(128, 104)
        Me.nudBinomialConditions.Name = "nudBinomialConditions"
        Me.nudBinomialConditions.Size = New System.Drawing.Size(51, 20)
        Me.nudBinomialConditions.TabIndex = 30
        '
        'lblEquals
        '
        Me.lblEquals.AutoSize = True
        Me.lblEquals.Location = New System.Drawing.Point(72, 108)
        Me.lblEquals.Name = "lblEquals"
        Me.lblEquals.Size = New System.Drawing.Size(13, 13)
        Me.lblEquals.TabIndex = 33
        Me.lblEquals.Text = "="
        '
        'ucrVariables
        '
        Me.ucrVariables.AddQuotesIfUnrecognised = True
        Me.ucrVariables.IsReadOnly = False
        Me.ucrVariables.Location = New System.Drawing.Point(91, 104)
        Me.ucrVariables.Name = "ucrVariables"
        Me.ucrVariables.Size = New System.Drawing.Size(88, 21)
        Me.ucrVariables.TabIndex = 32
        '
        'ucrOperator
        '
        Me.ucrOperator.AddQuotesIfUnrecognised = True
        Me.ucrOperator.IsReadOnly = False
        Me.ucrOperator.Location = New System.Drawing.Point(78, 104)
        Me.ucrOperator.Name = "ucrOperator"
        Me.ucrOperator.Size = New System.Drawing.Size(44, 21)
        Me.ucrOperator.TabIndex = 24
        '
        'ucrFamily
        '
        Me.ucrFamily.Location = New System.Drawing.Point(10, 228)
        Me.ucrFamily.Name = "ucrFamily"
        Me.ucrFamily.Size = New System.Drawing.Size(219, 30)
        Me.ucrFamily.TabIndex = 11
        '
        'UcrReceiver
        '
        Me.UcrReceiver.frmParent = Me
        Me.UcrReceiver.Location = New System.Drawing.Point(249, 64)
        Me.UcrReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiver.Name = "UcrReceiver"
        Me.UcrReceiver.Selector = Nothing
        Me.UcrReceiver.Size = New System.Drawing.Size(137, 20)
        Me.UcrReceiver.strNcFilePath = ""
        Me.UcrReceiver.TabIndex = 2
        Me.UcrReceiver.ucrSelector = Nothing
        '
        'ucrSelectorOneVarFitMod
        '
        Me.ucrSelectorOneVarFitMod.bShowHiddenColumns = False
        Me.ucrSelectorOneVarFitMod.bUseCurrentFilter = True
        Me.ucrSelectorOneVarFitMod.Location = New System.Drawing.Point(10, 42)
        Me.ucrSelectorOneVarFitMod.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOneVarFitMod.Name = "ucrSelectorOneVarFitMod"
        Me.ucrSelectorOneVarFitMod.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorOneVarFitMod.TabIndex = 1
        '
        'UcrBase
        '
        Me.UcrBase.Location = New System.Drawing.Point(10, 306)
        Me.UcrBase.Name = "UcrBase"
        Me.UcrBase.Size = New System.Drawing.Size(410, 52)
        Me.UcrBase.TabIndex = 0
        '
        'grpConditions
        '
        Me.grpConditions.Controls.Add(Me.ucrNudHyp)
        Me.grpConditions.Controls.Add(Me.ucrNudCI)
        Me.grpConditions.Controls.Add(Me.rdoEnorm)
        Me.grpConditions.Controls.Add(Me.lblConfidenceLimit)
        Me.grpConditions.Controls.Add(Me.rdoVarSign)
        Me.grpConditions.Controls.Add(Me.rdoMeanWilcox)
        Me.grpConditions.Controls.Add(Me.lblEquals)
        Me.grpConditions.Controls.Add(Me.lblHyp)
        Me.grpConditions.Controls.Add(Me.ucrVariables)
        Me.grpConditions.Controls.Add(Me.nudBinomialConditions)
        Me.grpConditions.Controls.Add(Me.chkBinModify)
        Me.grpConditions.Controls.Add(Me.lblSuccessIf)
        Me.grpConditions.Controls.Add(Me.ucrOperator)
        Me.grpConditions.Location = New System.Drawing.Point(249, 93)
        Me.grpConditions.Name = "grpConditions"
        Me.grpConditions.Size = New System.Drawing.Size(186, 145)
        Me.grpConditions.TabIndex = 34
        Me.grpConditions.TabStop = False
        Me.grpConditions.Text = "Conditions"
        '
        'ucrNudHyp
        '
        Me.ucrNudHyp.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHyp.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHyp.Location = New System.Drawing.Point(101, 49)
        Me.ucrNudHyp.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudHyp.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHyp.Name = "ucrNudHyp"
        Me.ucrNudHyp.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudHyp.TabIndex = 40
        Me.ucrNudHyp.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudCI
        '
        Me.ucrNudCI.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCI.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCI.Location = New System.Drawing.Point(100, 19)
        Me.ucrNudCI.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCI.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCI.Name = "ucrNudCI"
        Me.ucrNudCI.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCI.TabIndex = 39
        Me.ucrNudCI.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoEnorm
        '
        Me.rdoEnorm.AutoSize = True
        Me.rdoEnorm.Location = New System.Drawing.Point(9, 122)
        Me.rdoEnorm.Name = "rdoEnorm"
        Me.rdoEnorm.Size = New System.Drawing.Size(54, 17)
        Me.rdoEnorm.TabIndex = 37
        Me.rdoEnorm.TabStop = True
        Me.rdoEnorm.Text = "enorm"
        Me.rdoEnorm.UseVisualStyleBackColor = True
        '
        'rdoVarSign
        '
        Me.rdoVarSign.AutoSize = True
        Me.rdoVarSign.Location = New System.Drawing.Point(9, 99)
        Me.rdoVarSign.Name = "rdoVarSign"
        Me.rdoVarSign.Size = New System.Drawing.Size(112, 17)
        Me.rdoVarSign.TabIndex = 36
        Me.rdoVarSign.TabStop = True
        Me.rdoVarSign.Text = "Compare Variance"
        Me.rdoVarSign.UseVisualStyleBackColor = True
        '
        'rdoMeanWilcox
        '
        Me.rdoMeanWilcox.AutoSize = True
        Me.rdoMeanWilcox.Location = New System.Drawing.Point(9, 76)
        Me.rdoMeanWilcox.Name = "rdoMeanWilcox"
        Me.rdoMeanWilcox.Size = New System.Drawing.Size(97, 17)
        Me.rdoMeanWilcox.TabIndex = 35
        Me.rdoMeanWilcox.TabStop = True
        Me.rdoMeanWilcox.Text = "Compare Mean"
        Me.rdoMeanWilcox.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rdoMeanWilcox.UseVisualStyleBackColor = True
        '
        'ucrSaveModel
        '
        Me.ucrSaveModel.Location = New System.Drawing.Point(10, 276)
        Me.ucrSaveModel.Name = "ucrSaveModel"
        Me.ucrSaveModel.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveModel.TabIndex = 38
        '
        'rdoExactCase
        '
        Me.rdoExactCase.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoExactCase.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoExactCase.FlatAppearance.BorderSize = 2
        Me.rdoExactCase.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoExactCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoExactCase.Location = New System.Drawing.Point(194, 11)
        Me.rdoExactCase.Name = "rdoExactCase"
        Me.rdoExactCase.Size = New System.Drawing.Size(199, 28)
        Me.rdoExactCase.TabIndex = 41
        Me.rdoExactCase.Text = "Exact Solution"
        Me.rdoExactCase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoExactCase.UseVisualStyleBackColor = True
        '
        'rdoGeneralCase
        '
        Me.rdoGeneralCase.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGeneralCase.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGeneralCase.FlatAppearance.BorderSize = 2
        Me.rdoGeneralCase.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGeneralCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGeneralCase.Location = New System.Drawing.Point(19, 11)
        Me.rdoGeneralCase.Name = "rdoGeneralCase"
        Me.rdoGeneralCase.Size = New System.Drawing.Size(179, 28)
        Me.rdoGeneralCase.TabIndex = 40
        Me.rdoGeneralCase.Text = "General Case"
        Me.rdoGeneralCase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGeneralCase.UseVisualStyleBackColor = True
        '
        'ucrPnlGeneralExactCase
        '
        Me.ucrPnlGeneralExactCase.Location = New System.Drawing.Point(10, 7)
        Me.ucrPnlGeneralExactCase.Name = "ucrPnlGeneralExactCase"
        Me.ucrPnlGeneralExactCase.Size = New System.Drawing.Size(410, 35)
        Me.ucrPnlGeneralExactCase.TabIndex = 39
        '
        'dlgOneVarFitModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 364)
        Me.Controls.Add(Me.rdoExactCase)
        Me.Controls.Add(Me.rdoGeneralCase)
        Me.Controls.Add(Me.ucrPnlGeneralExactCase)
        Me.Controls.Add(Me.ucrSaveModel)
        Me.Controls.Add(Me.grpConditions)
        Me.Controls.Add(Me.ucrFamily)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.LblVariable)
        Me.Controls.Add(Me.cmdFittingOptions)
        Me.Controls.Add(Me.chkConvertToVariate)
        Me.Controls.Add(Me.UcrReceiver)
        Me.Controls.Add(Me.ucrSelectorOneVarFitMod)
        Me.Controls.Add(Me.UcrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneVarFitModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Variable Fit Model"
        CType(Me.nudBinomialConditions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConditions.ResumeLayout(False)
        Me.grpConditions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrBase As ucrButtons
    Friend WithEvents ucrSelectorOneVarFitMod As ucrSelectorByDataFrameAddRemove
    Friend WithEvents UcrReceiver As ucrReceiverSingle
    Friend WithEvents chkConvertToVariate As CheckBox
    Friend WithEvents cmdFittingOptions As Button
    Friend WithEvents LblVariable As Label
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents ucrFamily As ucrDistributions
    Friend WithEvents lblHyp As Label
    Friend WithEvents chkBinModify As CheckBox
    Friend WithEvents lblSuccessIf As Label
    Friend WithEvents lblConfidenceLimit As Label
    Friend WithEvents ucrOperator As ucrInputComboBox
    Friend WithEvents nudBinomialConditions As NumericUpDown
    Friend WithEvents ucrVariables As ucrInputComboBox
    Friend WithEvents lblEquals As Label
    Friend WithEvents grpConditions As GroupBox
    Friend WithEvents rdoEnorm As RadioButton
    Friend WithEvents rdoVarSign As RadioButton
    Friend WithEvents rdoMeanWilcox As RadioButton
    Friend WithEvents ucrSaveModel As ucrSave
    Friend WithEvents ucrNudHyp As ucrNud
    Friend WithEvents ucrNudCI As ucrNud
    Friend WithEvents rdoExactCase As RadioButton
    Friend WithEvents rdoGeneralCase As RadioButton
    Friend WithEvents ucrPnlGeneralExactCase As UcrPanel
End Class