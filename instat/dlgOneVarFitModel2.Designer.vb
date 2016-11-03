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
        Me.chkSaveModel = New System.Windows.Forms.CheckBox()
        Me.cmdFittingOptions = New System.Windows.Forms.Button()
        Me.LblVariable = New System.Windows.Forms.Label()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.lblprobability = New System.Windows.Forms.Label()
        Me.lblMean = New System.Windows.Forms.Label()
        Me.chkBinModify = New System.Windows.Forms.CheckBox()
        Me.lblSuccessIf = New System.Windows.Forms.Label()
        Me.lblConfidenceLimit = New System.Windows.Forms.Label()
        Me.nudCI = New System.Windows.Forms.NumericUpDown()
        Me.rdoGeneral = New System.Windows.Forms.RadioButton()
        Me.rdoSpecific = New System.Windows.Forms.RadioButton()
        Me.nudHyp = New System.Windows.Forms.NumericUpDown()
        Me.nudBinomialConditions = New System.Windows.Forms.NumericUpDown()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblEquals = New System.Windows.Forms.Label()
        Me.cboVariables = New instat.ucrInputComboBox()
        Me.ucrOperator = New instat.ucrInputComboBox()
        Me.UcrDistributions = New instat.ucrDistributions()
        Me.ucrSaveModel = New instat.ucrInputComboBox()
        Me.UcrReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorOneVarFitMod = New instat.ucrSelectorByDataFrameAddRemove()
        Me.UcrBase = New instat.ucrButtons()
        CType(Me.nudCI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHyp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBinomialConditions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkConvertToVariate
        '
        Me.chkConvertToVariate.AutoSize = True
        Me.chkConvertToVariate.Location = New System.Drawing.Point(269, 150)
        Me.chkConvertToVariate.Name = "chkConvertToVariate"
        Me.chkConvertToVariate.Size = New System.Drawing.Size(111, 17)
        Me.chkConvertToVariate.TabIndex = 4
        Me.chkConvertToVariate.Text = "Convert to Variate"
        Me.chkConvertToVariate.UseVisualStyleBackColor = True
        '
        'chkSaveModel
        '
        Me.chkSaveModel.AutoSize = True
        Me.chkSaveModel.Location = New System.Drawing.Point(10, 241)
        Me.chkSaveModel.Name = "chkSaveModel"
        Me.chkSaveModel.Size = New System.Drawing.Size(86, 17)
        Me.chkSaveModel.TabIndex = 5
        Me.chkSaveModel.Text = "Save Model:"
        Me.chkSaveModel.UseVisualStyleBackColor = True
        '
        'cmdFittingOptions
        '
        Me.cmdFittingOptions.Location = New System.Drawing.Point(270, 207)
        Me.cmdFittingOptions.Name = "cmdFittingOptions"
        Me.cmdFittingOptions.Size = New System.Drawing.Size(92, 23)
        Me.cmdFittingOptions.TabIndex = 7
        Me.cmdFittingOptions.Text = "Fitting Options"
        Me.cmdFittingOptions.UseVisualStyleBackColor = True
        '
        'LblVariable
        '
        Me.LblVariable.AutoSize = True
        Me.LblVariable.Location = New System.Drawing.Point(268, 47)
        Me.LblVariable.Name = "LblVariable"
        Me.LblVariable.Size = New System.Drawing.Size(48, 13)
        Me.LblVariable.TabIndex = 8
        Me.LblVariable.Text = "Variable:"
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(270, 236)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(92, 23)
        Me.cmdDisplayOptions.TabIndex = 10
        Me.cmdDisplayOptions.Text = "Display Options"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'lblprobability
        '
        Me.lblprobability.AutoSize = True
        Me.lblprobability.Location = New System.Drawing.Point(269, 151)
        Me.lblprobability.Name = "lblprobability"
        Me.lblprobability.Size = New System.Drawing.Size(58, 13)
        Me.lblprobability.TabIndex = 16
        Me.lblprobability.Text = "Probability:"
        '
        'lblMean
        '
        Me.lblMean.AutoSize = True
        Me.lblMean.Location = New System.Drawing.Point(268, 151)
        Me.lblMean.Name = "lblMean"
        Me.lblMean.Size = New System.Drawing.Size(37, 13)
        Me.lblMean.TabIndex = 17
        Me.lblMean.Text = "Mean:"
        '
        'chkBinModify
        '
        Me.chkBinModify.AutoSize = True
        Me.chkBinModify.Location = New System.Drawing.Point(272, 210)
        Me.chkBinModify.Name = "chkBinModify"
        Me.chkBinModify.Size = New System.Drawing.Size(172, 17)
        Me.chkBinModify.TabIndex = 18
        Me.chkBinModify.Text = "Modify Conditions for 'Success'"
        Me.chkBinModify.UseVisualStyleBackColor = True
        '
        'lblSuccessIf
        '
        Me.lblSuccessIf.AutoSize = True
        Me.lblSuccessIf.Location = New System.Drawing.Point(277, 241)
        Me.lblSuccessIf.Name = "lblSuccessIf"
        Me.lblSuccessIf.Size = New System.Drawing.Size(66, 13)
        Me.lblSuccessIf.TabIndex = 19
        Me.lblSuccessIf.Text = "Success if X"
        '
        'lblConfidenceLimit
        '
        Me.lblConfidenceLimit.AutoSize = True
        Me.lblConfidenceLimit.Location = New System.Drawing.Point(268, 127)
        Me.lblConfidenceLimit.Name = "lblConfidenceLimit"
        Me.lblConfidenceLimit.Size = New System.Drawing.Size(88, 13)
        Me.lblConfidenceLimit.TabIndex = 22
        Me.lblConfidenceLimit.Text = "Confidence Limit:"
        '
        'nudCI
        '
        Me.nudCI.DecimalPlaces = 2
        Me.nudCI.Location = New System.Drawing.Point(362, 125)
        Me.nudCI.Name = "nudCI"
        Me.nudCI.Size = New System.Drawing.Size(58, 20)
        Me.nudCI.TabIndex = 23
        '
        'rdoGeneral
        '
        Me.rdoGeneral.AutoSize = True
        Me.rdoGeneral.Location = New System.Drawing.Point(10, 12)
        Me.rdoGeneral.Name = "rdoGeneral"
        Me.rdoGeneral.Size = New System.Drawing.Size(89, 17)
        Me.rdoGeneral.TabIndex = 26
        Me.rdoGeneral.TabStop = True
        Me.rdoGeneral.Text = "General Case"
        Me.rdoGeneral.UseVisualStyleBackColor = True
        '
        'rdoSpecific
        '
        Me.rdoSpecific.AutoSize = True
        Me.rdoSpecific.Location = New System.Drawing.Point(268, 12)
        Me.rdoSpecific.Name = "rdoSpecific"
        Me.rdoSpecific.Size = New System.Drawing.Size(93, 17)
        Me.rdoSpecific.TabIndex = 27
        Me.rdoSpecific.TabStop = True
        Me.rdoSpecific.Text = "Exact Solution"
        Me.rdoSpecific.UseVisualStyleBackColor = True
        '
        'nudHyp
        '
        Me.nudHyp.Location = New System.Drawing.Point(330, 149)
        Me.nudHyp.Name = "nudHyp"
        Me.nudHyp.Size = New System.Drawing.Size(48, 20)
        Me.nudHyp.TabIndex = 29
        '
        'nudBinomialConditions
        '
        Me.nudBinomialConditions.DecimalPlaces = 2
        Me.nudBinomialConditions.Location = New System.Drawing.Point(399, 237)
        Me.nudBinomialConditions.Name = "nudBinomialConditions"
        Me.nudBinomialConditions.Size = New System.Drawing.Size(51, 20)
        Me.nudBinomialConditions.TabIndex = 30
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(268, 151)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(33, 13)
        Me.lblRate.TabIndex = 31
        Me.lblRate.Text = "Rate:"
        '
        'lblEquals
        '
        Me.lblEquals.AutoSize = True
        Me.lblEquals.Location = New System.Drawing.Point(343, 241)
        Me.lblEquals.Name = "lblEquals"
        Me.lblEquals.Size = New System.Drawing.Size(13, 13)
        Me.lblEquals.TabIndex = 33
        Me.lblEquals.Text = "="
        '
        'cboVariables
        '
        Me.cboVariables.IsReadOnly = False
        Me.cboVariables.Location = New System.Drawing.Point(362, 237)
        Me.cboVariables.Name = "cboVariables"
        Me.cboVariables.Size = New System.Drawing.Size(88, 21)
        Me.cboVariables.TabIndex = 32
        '
        'ucrOperator
        '
        Me.ucrOperator.IsReadOnly = False
        Me.ucrOperator.Location = New System.Drawing.Point(349, 237)
        Me.ucrOperator.Name = "ucrOperator"
        Me.ucrOperator.Size = New System.Drawing.Size(44, 21)
        Me.ucrOperator.TabIndex = 24
        '
        'UcrDistributions
        '
        Me.UcrDistributions.Location = New System.Drawing.Point(268, 85)
        Me.UcrDistributions.Name = "UcrDistributions"
        Me.UcrDistributions.Size = New System.Drawing.Size(225, 43)
        Me.UcrDistributions.TabIndex = 11
        '
        'ucrSaveModel
        '
        Me.ucrSaveModel.IsReadOnly = False
        Me.ucrSaveModel.Location = New System.Drawing.Point(99, 239)
        Me.ucrSaveModel.Name = "ucrSaveModel"
        Me.ucrSaveModel.Size = New System.Drawing.Size(137, 21)
        Me.ucrSaveModel.TabIndex = 3
        '
        'UcrReceiver
        '
        Me.UcrReceiver.Location = New System.Drawing.Point(268, 64)
        Me.UcrReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiver.Name = "UcrReceiver"
        Me.UcrReceiver.Selector = Nothing
        Me.UcrReceiver.Size = New System.Drawing.Size(137, 20)
        Me.UcrReceiver.TabIndex = 2
        '
        'ucrSelectorOneVarFitMod
        '
        Me.ucrSelectorOneVarFitMod.bShowHiddenColumns = False
        Me.ucrSelectorOneVarFitMod.bUseCurrentFilter = False
        Me.ucrSelectorOneVarFitMod.Location = New System.Drawing.Point(10, 42)
        Me.ucrSelectorOneVarFitMod.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOneVarFitMod.Name = "ucrSelectorOneVarFitMod"
        Me.ucrSelectorOneVarFitMod.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorOneVarFitMod.TabIndex = 1
        '
        'UcrBase
        '
        Me.UcrBase.Location = New System.Drawing.Point(10, 270)
        Me.UcrBase.Name = "UcrBase"
        Me.UcrBase.Size = New System.Drawing.Size(410, 52)
        Me.UcrBase.TabIndex = 0
        '
        'dlgOneVarFitModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 322)
        Me.Controls.Add(Me.lblEquals)
        Me.Controls.Add(Me.cboVariables)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.nudBinomialConditions)
        Me.Controls.Add(Me.nudHyp)
        Me.Controls.Add(Me.rdoSpecific)
        Me.Controls.Add(Me.rdoGeneral)
        Me.Controls.Add(Me.ucrOperator)
        Me.Controls.Add(Me.nudCI)
        Me.Controls.Add(Me.lblConfidenceLimit)
        Me.Controls.Add(Me.lblSuccessIf)
        Me.Controls.Add(Me.chkBinModify)
        Me.Controls.Add(Me.lblMean)
        Me.Controls.Add(Me.lblprobability)
        Me.Controls.Add(Me.UcrDistributions)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.LblVariable)
        Me.Controls.Add(Me.cmdFittingOptions)
        Me.Controls.Add(Me.chkSaveModel)
        Me.Controls.Add(Me.chkConvertToVariate)
        Me.Controls.Add(Me.ucrSaveModel)
        Me.Controls.Add(Me.UcrReceiver)
        Me.Controls.Add(Me.ucrSelectorOneVarFitMod)
        Me.Controls.Add(Me.UcrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneVarFitModel"
        Me.Text = "Fitting a Model for One Variable"
        CType(Me.nudCI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHyp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBinomialConditions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrBase As ucrButtons
    Friend WithEvents ucrSelectorOneVarFitMod As ucrSelectorByDataFrameAddRemove
    Friend WithEvents UcrReceiver As ucrReceiverSingle
    Friend WithEvents ucrSaveModel As ucrInputComboBox
    Friend WithEvents chkConvertToVariate As CheckBox
    Friend WithEvents chkSaveModel As CheckBox
    Friend WithEvents cmdFittingOptions As Button
    Friend WithEvents LblVariable As Label
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents UcrDistributions As ucrDistributions
    Friend WithEvents lblprobability As Label
    Friend WithEvents lblMean As Label
    Friend WithEvents chkBinModify As CheckBox
    Friend WithEvents lblSuccessIf As Label
    Friend WithEvents lblConfidenceLimit As Label
    Friend WithEvents nudCI As NumericUpDown
    Friend WithEvents ucrOperator As ucrInputComboBox
    Friend WithEvents rdoGeneral As RadioButton
    Friend WithEvents rdoSpecific As RadioButton
    Friend WithEvents nudHyp As NumericUpDown
    Friend WithEvents nudBinomialConditions As NumericUpDown
    Friend WithEvents lblRate As Label
    Friend WithEvents cboVariables As ucrInputComboBox
    Friend WithEvents lblEquals As Label
End Class
