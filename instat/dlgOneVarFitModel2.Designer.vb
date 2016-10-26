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
        Me.UcrBase = New instat.ucrButtons()
        Me.ucrSelectorOneVarFitMod = New instat.ucrSelectorByDataFrameAddRemove()
        Me.UcrReceiver = New instat.ucrReceiverSingle()
        Me.ucrSaveModel = New instat.ucrInputComboBox()
        Me.chkConvertToVariate = New System.Windows.Forms.CheckBox()
        Me.chkSaveModel = New System.Windows.Forms.CheckBox()
        Me.cmdFittingOptions = New System.Windows.Forms.Button()
        Me.LblVariable = New System.Windows.Forms.Label()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.UcrDistributions = New instat.ucrDistributions()
        Me.nudCI = New instat.ucrInputConfidenceLimit()
        Me.rdoGeneral = New System.Windows.Forms.RadioButton()
        Me.rdoSpecial = New System.Windows.Forms.RadioButton()
        Me.nudHyp = New System.Windows.Forms.NumericUpDown()
        Me.lblprobability = New System.Windows.Forms.Label()
        Me.lblMean = New System.Windows.Forms.Label()
        CType(Me.nudHyp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UcrBase
        '
        Me.UcrBase.Location = New System.Drawing.Point(10, 270)
        Me.UcrBase.Name = "UcrBase"
        Me.UcrBase.Size = New System.Drawing.Size(410, 52)
        Me.UcrBase.TabIndex = 0
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
        'UcrReceiver
        '
        Me.UcrReceiver.Location = New System.Drawing.Point(269, 64)
        Me.UcrReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiver.Name = "UcrReceiver"
        Me.UcrReceiver.Selector = Nothing
        Me.UcrReceiver.Size = New System.Drawing.Size(137, 20)
        Me.UcrReceiver.TabIndex = 2
        '
        'ucrSaveModel
        '
        Me.ucrSaveModel.IsReadOnly = False
        Me.ucrSaveModel.Location = New System.Drawing.Point(99, 239)
        Me.ucrSaveModel.Name = "ucrSaveModel"
        Me.ucrSaveModel.Size = New System.Drawing.Size(137, 21)
        Me.ucrSaveModel.TabIndex = 3
        '
        'chkConvertToVariate
        '
        Me.chkConvertToVariate.AutoSize = True
        Me.chkConvertToVariate.Location = New System.Drawing.Point(269, 90)
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
        'UcrDistributions
        '
        Me.UcrDistributions.Location = New System.Drawing.Point(269, 104)
        Me.UcrDistributions.Name = "UcrDistributions"
        Me.UcrDistributions.Size = New System.Drawing.Size(225, 43)
        Me.UcrDistributions.TabIndex = 11
        '
        'nudCI
        '
        Me.nudCI.Location = New System.Drawing.Point(265, 177)
        Me.nudCI.Name = "nudCI"
        Me.nudCI.Size = New System.Drawing.Size(154, 23)
        Me.nudCI.TabIndex = 12
        '
        'rdoGeneral
        '
        Me.rdoGeneral.AutoSize = True
        Me.rdoGeneral.Location = New System.Drawing.Point(12, 12)
        Me.rdoGeneral.Name = "rdoGeneral"
        Me.rdoGeneral.Size = New System.Drawing.Size(62, 17)
        Me.rdoGeneral.TabIndex = 13
        Me.rdoGeneral.TabStop = True
        Me.rdoGeneral.Text = "General"
        Me.rdoGeneral.UseVisualStyleBackColor = True
        '
        'rdoSpecial
        '
        Me.rdoSpecial.AutoSize = True
        Me.rdoSpecial.Location = New System.Drawing.Point(269, 12)
        Me.rdoSpecial.Name = "rdoSpecial"
        Me.rdoSpecial.Size = New System.Drawing.Size(60, 17)
        Me.rdoSpecial.TabIndex = 14
        Me.rdoSpecial.TabStop = True
        Me.rdoSpecial.Text = "Special"
        Me.rdoSpecial.UseVisualStyleBackColor = True
        '
        'nudHyp
        '
        Me.nudHyp.Location = New System.Drawing.Point(331, 146)
        Me.nudHyp.Name = "nudHyp"
        Me.nudHyp.Size = New System.Drawing.Size(40, 20)
        Me.nudHyp.TabIndex = 15
        '
        'lblprobability
        '
        Me.lblprobability.AutoSize = True
        Me.lblprobability.Location = New System.Drawing.Point(267, 150)
        Me.lblprobability.Name = "lblprobability"
        Me.lblprobability.Size = New System.Drawing.Size(58, 13)
        Me.lblprobability.TabIndex = 16
        Me.lblprobability.Text = "Probability:"
        '
        'lblMean
        '
        Me.lblMean.AutoSize = True
        Me.lblMean.Location = New System.Drawing.Point(267, 150)
        Me.lblMean.Name = "lblMean"
        Me.lblMean.Size = New System.Drawing.Size(37, 13)
        Me.lblMean.TabIndex = 17
        Me.lblMean.Text = "Mean:"
        '
        'dlgOneVarFitModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 322)
        Me.Controls.Add(Me.lblMean)
        Me.Controls.Add(Me.lblprobability)
        Me.Controls.Add(Me.nudHyp)
        Me.Controls.Add(Me.rdoSpecial)
        Me.Controls.Add(Me.rdoGeneral)
        Me.Controls.Add(Me.nudCI)
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
        CType(Me.nudHyp, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents nudCI As ucrInputConfidenceLimit
    Friend WithEvents rdoGeneral As RadioButton
    Friend WithEvents rdoSpecial As RadioButton
    Friend WithEvents nudHyp As NumericUpDown
    Friend WithEvents lblprobability As Label
    Friend WithEvents lblMean As Label
End Class
