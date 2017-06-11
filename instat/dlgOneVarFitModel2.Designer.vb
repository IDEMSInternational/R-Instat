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
        Me.lblHyp = New System.Windows.Forms.Label()
        Me.chkBinModify = New System.Windows.Forms.CheckBox()
        Me.lblSuccessIf = New System.Windows.Forms.Label()
        Me.lblConfidenceLimit = New System.Windows.Forms.Label()
        Me.nudCI = New System.Windows.Forms.NumericUpDown()
        Me.rdoGeneral = New System.Windows.Forms.RadioButton()
        Me.rdoSpecific = New System.Windows.Forms.RadioButton()
        Me.nudHyp = New System.Windows.Forms.NumericUpDown()
        Me.nudBinomialConditions = New System.Windows.Forms.NumericUpDown()
        Me.lblEquals = New System.Windows.Forms.Label()
        Me.ucrVariables = New instat.ucrInputComboBox()
        Me.ucrOperator = New instat.ucrInputComboBox()
        Me.ucrFamily = New instat.ucrDistributions()
        Me.ucrSaveModel = New instat.ucrInputComboBox()
        Me.UcrReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorOneVarFitMod = New instat.ucrSelectorByDataFrameAddRemove()
        Me.UcrBase = New instat.ucrButtons()
        Me.grpConditions = New System.Windows.Forms.GroupBox()
        Me.rdoEnorm = New System.Windows.Forms.RadioButton()
        Me.rdoVarSign = New System.Windows.Forms.RadioButton()
        Me.rdoMeanWilcox = New System.Windows.Forms.RadioButton()
        CType(Me.nudCI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHyp, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'chkSaveModel
        '
        Me.chkSaveModel.AutoSize = True
        Me.chkSaveModel.Location = New System.Drawing.Point(10, 277)
        Me.chkSaveModel.Name = "chkSaveModel"
        Me.chkSaveModel.Size = New System.Drawing.Size(86, 17)
        Me.chkSaveModel.TabIndex = 5
        Me.chkSaveModel.Text = "Save Model:"
        Me.chkSaveModel.UseVisualStyleBackColor = True
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
        'nudCI
        '
        Me.nudCI.DecimalPlaces = 2
        Me.nudCI.Location = New System.Drawing.Point(100, 21)
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
        Me.nudHyp.Location = New System.Drawing.Point(100, 51)
        Me.nudHyp.Name = "nudHyp"
        Me.nudHyp.Size = New System.Drawing.Size(58, 20)
        Me.nudHyp.TabIndex = 29
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
        'ucrSaveModel
        '
        Me.ucrSaveModel.AddQuotesIfUnrecognised = True
        Me.ucrSaveModel.IsReadOnly = False
        Me.ucrSaveModel.Location = New System.Drawing.Point(92, 275)
        Me.ucrSaveModel.Name = "ucrSaveModel"
        Me.ucrSaveModel.Size = New System.Drawing.Size(137, 21)
        Me.ucrSaveModel.TabIndex = 3
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
        Me.grpConditions.Controls.Add(Me.rdoEnorm)
        Me.grpConditions.Controls.Add(Me.lblConfidenceLimit)
        Me.grpConditions.Controls.Add(Me.rdoVarSign)
        Me.grpConditions.Controls.Add(Me.nudCI)
        Me.grpConditions.Controls.Add(Me.rdoMeanWilcox)
        Me.grpConditions.Controls.Add(Me.lblEquals)
        Me.grpConditions.Controls.Add(Me.lblHyp)
        Me.grpConditions.Controls.Add(Me.ucrVariables)
        Me.grpConditions.Controls.Add(Me.nudHyp)
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
        'dlgOneVarFitModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 364)
        Me.Controls.Add(Me.grpConditions)
        Me.Controls.Add(Me.ucrSaveModel)
        Me.Controls.Add(Me.rdoSpecific)
        Me.Controls.Add(Me.rdoGeneral)
        Me.Controls.Add(Me.ucrFamily)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.LblVariable)
        Me.Controls.Add(Me.cmdFittingOptions)
        Me.Controls.Add(Me.chkSaveModel)
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
        CType(Me.nudCI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHyp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBinomialConditions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConditions.ResumeLayout(False)
        Me.grpConditions.PerformLayout()
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
    Friend WithEvents ucrFamily As ucrDistributions
    Friend WithEvents lblHyp As Label
    Friend WithEvents chkBinModify As CheckBox
    Friend WithEvents lblSuccessIf As Label
    Friend WithEvents lblConfidenceLimit As Label
    Friend WithEvents nudCI As NumericUpDown
    Friend WithEvents ucrOperator As ucrInputComboBox
    Friend WithEvents rdoGeneral As RadioButton
    Friend WithEvents rdoSpecific As RadioButton
    Friend WithEvents nudHyp As NumericUpDown
    Friend WithEvents nudBinomialConditions As NumericUpDown
    Friend WithEvents ucrVariables As ucrInputComboBox
    Friend WithEvents lblEquals As Label
    Friend WithEvents grpConditions As GroupBox
    Friend WithEvents rdoEnorm As RadioButton
    Friend WithEvents rdoVarSign As RadioButton
    Friend WithEvents rdoMeanWilcox As RadioButton
End Class