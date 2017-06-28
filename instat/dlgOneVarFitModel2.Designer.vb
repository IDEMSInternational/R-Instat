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
        Me.cmdFittingOptions = New System.Windows.Forms.Button()
        Me.LblVariable = New System.Windows.Forms.Label()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.lblSuccessIf = New System.Windows.Forms.Label()
        Me.lblEquals = New System.Windows.Forms.Label()
        Me.rdoExactCase = New System.Windows.Forms.RadioButton()
        Me.rdoGeneralCase = New System.Windows.Forms.RadioButton()
        Me.grpConditions = New System.Windows.Forms.GroupBox()
        Me.lblHyp = New System.Windows.Forms.Label()
        Me.lblConfidenceLimit = New System.Windows.Forms.Label()
        Me.grpVarAndWilcox = New System.Windows.Forms.GroupBox()
        Me.rdoEnorm = New System.Windows.Forms.RadioButton()
        Me.rdoMeanWilcox = New System.Windows.Forms.RadioButton()
        Me.rdoVarSign = New System.Windows.Forms.RadioButton()
        Me.grpVarAndWilcoxSign = New System.Windows.Forms.GroupBox()
        Me.rdoWilcoxSignTest = New System.Windows.Forms.RadioButton()
        Me.rdoVarSignTest = New System.Windows.Forms.RadioButton()
        Me.ucrPnlWilcoxVarTest = New instat.UcrPanel()
        Me.ucrPnlStats = New instat.UcrPanel()
        Me.ucrChkConvertVariate = New instat.ucrCheck()
        Me.ucrPnlGeneralExactCase = New instat.UcrPanel()
        Me.ucrSaveModel = New instat.ucrSave()
        Me.ucrChkBinModify = New instat.ucrCheck()
        Me.ucrNudBinomialConditions = New instat.ucrNud()
        Me.ucrOperator = New instat.ucrInputComboBox()
        Me.ucrVariables = New instat.ucrInputComboBox()
        Me.ucrNudHyp = New instat.ucrNud()
        Me.ucrNudCI = New instat.ucrNud()
        Me.ucrFamily = New instat.ucrDistributions()
        Me.UcrReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorOneVarFitMod = New instat.ucrSelectorByDataFrameAddRemove()
        Me.UcrBase = New instat.ucrButtons()
        Me.grpConditions.SuspendLayout()
        Me.grpVarAndWilcox.SuspendLayout()
        Me.grpVarAndWilcoxSign.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdFittingOptions
        '
        Me.cmdFittingOptions.Location = New System.Drawing.Point(312, 282)
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
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(313, 311)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(92, 23)
        Me.cmdDisplayOptions.TabIndex = 10
        Me.cmdDisplayOptions.Text = "Display Options"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'lblSuccessIf
        '
        Me.lblSuccessIf.AutoSize = True
        Me.lblSuccessIf.Location = New System.Drawing.Point(3, 110)
        Me.lblSuccessIf.Name = "lblSuccessIf"
        Me.lblSuccessIf.Size = New System.Drawing.Size(66, 13)
        Me.lblSuccessIf.TabIndex = 19
        Me.lblSuccessIf.Text = "Success if X"
        '
        'lblEquals
        '
        Me.lblEquals.AutoSize = True
        Me.lblEquals.Location = New System.Drawing.Point(71, 108)
        Me.lblEquals.Name = "lblEquals"
        Me.lblEquals.Size = New System.Drawing.Size(13, 13)
        Me.lblEquals.TabIndex = 33
        Me.lblEquals.Text = "="
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
        'grpConditions
        '
        Me.grpConditions.Controls.Add(Me.grpVarAndWilcoxSign)
        Me.grpConditions.Controls.Add(Me.grpVarAndWilcox)
        Me.grpConditions.Controls.Add(Me.ucrChkBinModify)
        Me.grpConditions.Controls.Add(Me.lblEquals)
        Me.grpConditions.Controls.Add(Me.ucrNudBinomialConditions)
        Me.grpConditions.Controls.Add(Me.ucrOperator)
        Me.grpConditions.Controls.Add(Me.ucrVariables)
        Me.grpConditions.Controls.Add(Me.lblSuccessIf)
        Me.grpConditions.Controls.Add(Me.lblHyp)
        Me.grpConditions.Controls.Add(Me.ucrNudHyp)
        Me.grpConditions.Controls.Add(Me.lblConfidenceLimit)
        Me.grpConditions.Controls.Add(Me.ucrNudCI)
        Me.grpConditions.Location = New System.Drawing.Point(249, 123)
        Me.grpConditions.Name = "grpConditions"
        Me.grpConditions.Size = New System.Drawing.Size(196, 153)
        Me.grpConditions.TabIndex = 34
        Me.grpConditions.TabStop = False
        Me.grpConditions.Text = "Conditions"
        '
        'lblHyp
        '
        Me.lblHyp.AutoSize = True
        Me.lblHyp.Location = New System.Drawing.Point(6, 40)
        Me.lblHyp.Name = "lblHyp"
        Me.lblHyp.Size = New System.Drawing.Size(83, 13)
        Me.lblHyp.TabIndex = 46
        Me.lblHyp.Text = "Null Hypothesis:"
        '
        'lblConfidenceLimit
        '
        Me.lblConfidenceLimit.AutoSize = True
        Me.lblConfidenceLimit.Location = New System.Drawing.Point(6, 13)
        Me.lblConfidenceLimit.Name = "lblConfidenceLimit"
        Me.lblConfidenceLimit.Size = New System.Drawing.Size(88, 13)
        Me.lblConfidenceLimit.TabIndex = 47
        Me.lblConfidenceLimit.Text = "Confidence Limit:"
        '
        'grpVarAndWilcox
        '
        Me.grpVarAndWilcox.Controls.Add(Me.rdoEnorm)
        Me.grpVarAndWilcox.Controls.Add(Me.rdoMeanWilcox)
        Me.grpVarAndWilcox.Controls.Add(Me.rdoVarSign)
        Me.grpVarAndWilcox.Controls.Add(Me.ucrPnlStats)
        Me.grpVarAndWilcox.Location = New System.Drawing.Point(7, 60)
        Me.grpVarAndWilcox.Name = "grpVarAndWilcox"
        Me.grpVarAndWilcox.Size = New System.Drawing.Size(130, 75)
        Me.grpVarAndWilcox.TabIndex = 55
        Me.grpVarAndWilcox.TabStop = False
        '
        'rdoEnorm
        '
        Me.rdoEnorm.AutoSize = True
        Me.rdoEnorm.Location = New System.Drawing.Point(10, 50)
        Me.rdoEnorm.Name = "rdoEnorm"
        Me.rdoEnorm.Size = New System.Drawing.Size(54, 17)
        Me.rdoEnorm.TabIndex = 65
        Me.rdoEnorm.TabStop = True
        Me.rdoEnorm.Text = "enorm"
        Me.rdoEnorm.UseVisualStyleBackColor = True
        '
        'rdoMeanWilcox
        '
        Me.rdoMeanWilcox.AutoSize = True
        Me.rdoMeanWilcox.Location = New System.Drawing.Point(10, 12)
        Me.rdoMeanWilcox.Name = "rdoMeanWilcox"
        Me.rdoMeanWilcox.Size = New System.Drawing.Size(97, 17)
        Me.rdoMeanWilcox.TabIndex = 66
        Me.rdoMeanWilcox.TabStop = True
        Me.rdoMeanWilcox.Text = "Compare Mean"
        Me.rdoMeanWilcox.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rdoMeanWilcox.UseVisualStyleBackColor = True
        '
        'rdoVarSign
        '
        Me.rdoVarSign.AutoSize = True
        Me.rdoVarSign.Location = New System.Drawing.Point(10, 31)
        Me.rdoVarSign.Name = "rdoVarSign"
        Me.rdoVarSign.Size = New System.Drawing.Size(112, 17)
        Me.rdoVarSign.TabIndex = 64
        Me.rdoVarSign.TabStop = True
        Me.rdoVarSign.Text = "Compare Variance"
        Me.rdoVarSign.UseVisualStyleBackColor = True
        '
        'grpVarAndWilcoxSign
        '
        Me.grpVarAndWilcoxSign.Controls.Add(Me.rdoWilcoxSignTest)
        Me.grpVarAndWilcoxSign.Controls.Add(Me.rdoVarSignTest)
        Me.grpVarAndWilcoxSign.Controls.Add(Me.ucrPnlWilcoxVarTest)
        Me.grpVarAndWilcoxSign.Location = New System.Drawing.Point(5, 64)
        Me.grpVarAndWilcoxSign.Name = "grpVarAndWilcoxSign"
        Me.grpVarAndWilcoxSign.Size = New System.Drawing.Size(127, 71)
        Me.grpVarAndWilcoxSign.TabIndex = 62
        Me.grpVarAndWilcoxSign.TabStop = False
        '
        'rdoWilcoxSignTest
        '
        Me.rdoWilcoxSignTest.AutoSize = True
        Me.rdoWilcoxSignTest.Location = New System.Drawing.Point(8, 13)
        Me.rdoWilcoxSignTest.Name = "rdoWilcoxSignTest"
        Me.rdoWilcoxSignTest.Size = New System.Drawing.Size(97, 17)
        Me.rdoWilcoxSignTest.TabIndex = 65
        Me.rdoWilcoxSignTest.TabStop = True
        Me.rdoWilcoxSignTest.Text = "Compare Mean"
        Me.rdoWilcoxSignTest.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rdoWilcoxSignTest.UseVisualStyleBackColor = True
        '
        'rdoVarSignTest
        '
        Me.rdoVarSignTest.AutoSize = True
        Me.rdoVarSignTest.Location = New System.Drawing.Point(8, 36)
        Me.rdoVarSignTest.Name = "rdoVarSignTest"
        Me.rdoVarSignTest.Size = New System.Drawing.Size(109, 17)
        Me.rdoVarSignTest.TabIndex = 64
        Me.rdoVarSignTest.TabStop = True
        Me.rdoVarSignTest.Text = "Compare Vaiance"
        Me.rdoVarSignTest.UseVisualStyleBackColor = True
        '
        'ucrPnlWilcoxVarTest
        '
        Me.ucrPnlWilcoxVarTest.Location = New System.Drawing.Point(6, 11)
        Me.ucrPnlWilcoxVarTest.Name = "ucrPnlWilcoxVarTest"
        Me.ucrPnlWilcoxVarTest.Size = New System.Drawing.Size(117, 48)
        Me.ucrPnlWilcoxVarTest.TabIndex = 63
        '
        'ucrPnlStats
        '
        Me.ucrPnlStats.Location = New System.Drawing.Point(6, 10)
        Me.ucrPnlStats.Name = "ucrPnlStats"
        Me.ucrPnlStats.Size = New System.Drawing.Size(118, 63)
        Me.ucrPnlStats.TabIndex = 63
        '
        'ucrChkConvertVariate
        '
        Me.ucrChkConvertVariate.Checked = False
        Me.ucrChkConvertVariate.Location = New System.Drawing.Point(249, 98)
        Me.ucrChkConvertVariate.Name = "ucrChkConvertVariate"
        Me.ucrChkConvertVariate.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkConvertVariate.TabIndex = 42
        '
        'ucrPnlGeneralExactCase
        '
        Me.ucrPnlGeneralExactCase.Location = New System.Drawing.Point(10, 7)
        Me.ucrPnlGeneralExactCase.Name = "ucrPnlGeneralExactCase"
        Me.ucrPnlGeneralExactCase.Size = New System.Drawing.Size(410, 35)
        Me.ucrPnlGeneralExactCase.TabIndex = 39
        '
        'ucrSaveModel
        '
        Me.ucrSaveModel.Location = New System.Drawing.Point(10, 314)
        Me.ucrSaveModel.Name = "ucrSaveModel"
        Me.ucrSaveModel.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveModel.TabIndex = 38
        '
        'ucrChkBinModify
        '
        Me.ucrChkBinModify.Checked = False
        Me.ucrChkBinModify.Location = New System.Drawing.Point(9, 76)
        Me.ucrChkBinModify.Name = "ucrChkBinModify"
        Me.ucrChkBinModify.Size = New System.Drawing.Size(174, 20)
        Me.ucrChkBinModify.TabIndex = 54
        '
        'ucrNudBinomialConditions
        '
        Me.ucrNudBinomialConditions.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBinomialConditions.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBinomialConditions.Location = New System.Drawing.Point(135, 104)
        Me.ucrNudBinomialConditions.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBinomialConditions.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBinomialConditions.Name = "ucrNudBinomialConditions"
        Me.ucrNudBinomialConditions.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudBinomialConditions.TabIndex = 50
        Me.ucrNudBinomialConditions.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrOperator
        '
        Me.ucrOperator.AddQuotesIfUnrecognised = True
        Me.ucrOperator.IsReadOnly = False
        Me.ucrOperator.Location = New System.Drawing.Point(87, 104)
        Me.ucrOperator.Name = "ucrOperator"
        Me.ucrOperator.Size = New System.Drawing.Size(44, 21)
        Me.ucrOperator.TabIndex = 24
        '
        'ucrVariables
        '
        Me.ucrVariables.AddQuotesIfUnrecognised = True
        Me.ucrVariables.IsReadOnly = False
        Me.ucrVariables.Location = New System.Drawing.Point(90, 108)
        Me.ucrVariables.Name = "ucrVariables"
        Me.ucrVariables.Size = New System.Drawing.Size(88, 21)
        Me.ucrVariables.TabIndex = 32
        '
        'ucrNudHyp
        '
        Me.ucrNudHyp.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHyp.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHyp.Location = New System.Drawing.Point(101, 38)
        Me.ucrNudHyp.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudHyp.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHyp.Name = "ucrNudHyp"
        Me.ucrNudHyp.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudHyp.TabIndex = 49
        Me.ucrNudHyp.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudCI
        '
        Me.ucrNudCI.DecimalPlaces = New Decimal(New Integer() {2, 0, 0, 0})
        Me.ucrNudCI.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCI.Location = New System.Drawing.Point(100, 10)
        Me.ucrNudCI.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCI.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCI.Name = "ucrNudCI"
        Me.ucrNudCI.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCI.TabIndex = 48
        Me.ucrNudCI.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrFamily
        '
        Me.ucrFamily.Location = New System.Drawing.Point(10, 266)
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
        Me.UcrBase.Location = New System.Drawing.Point(10, 344)
        Me.UcrBase.Name = "UcrBase"
        Me.UcrBase.Size = New System.Drawing.Size(410, 52)
        Me.UcrBase.TabIndex = 0
        '
        'dlgOneVarFitModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 402)
        Me.Controls.Add(Me.ucrChkConvertVariate)
        Me.Controls.Add(Me.rdoExactCase)
        Me.Controls.Add(Me.rdoGeneralCase)
        Me.Controls.Add(Me.ucrPnlGeneralExactCase)
        Me.Controls.Add(Me.ucrSaveModel)
        Me.Controls.Add(Me.grpConditions)
        Me.Controls.Add(Me.ucrFamily)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.LblVariable)
        Me.Controls.Add(Me.cmdFittingOptions)
        Me.Controls.Add(Me.UcrReceiver)
        Me.Controls.Add(Me.ucrSelectorOneVarFitMod)
        Me.Controls.Add(Me.UcrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneVarFitModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Variable Fit Model"
        Me.grpConditions.ResumeLayout(False)
        Me.grpConditions.PerformLayout()
        Me.grpVarAndWilcox.ResumeLayout(False)
        Me.grpVarAndWilcox.PerformLayout()
        Me.grpVarAndWilcoxSign.ResumeLayout(False)
        Me.grpVarAndWilcoxSign.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrBase As ucrButtons
    Friend WithEvents ucrSelectorOneVarFitMod As ucrSelectorByDataFrameAddRemove
    Friend WithEvents UcrReceiver As ucrReceiverSingle
    Friend WithEvents cmdFittingOptions As Button
    Friend WithEvents LblVariable As Label
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents ucrFamily As ucrDistributions
    Friend WithEvents lblSuccessIf As Label
    Friend WithEvents ucrOperator As ucrInputComboBox
    Friend WithEvents ucrVariables As ucrInputComboBox
    Friend WithEvents lblEquals As Label
    Friend WithEvents ucrSaveModel As ucrSave
    Friend WithEvents rdoExactCase As RadioButton
    Friend WithEvents rdoGeneralCase As RadioButton
    Friend WithEvents ucrPnlGeneralExactCase As UcrPanel
    Friend WithEvents ucrChkConvertVariate As ucrCheck
    Friend WithEvents ucrNudBinomialConditions As ucrNud
    Friend WithEvents ucrNudHyp As ucrNud
    Friend WithEvents ucrNudCI As ucrNud
    Friend WithEvents grpConditions As GroupBox
    Friend WithEvents ucrChkBinModify As ucrCheck
    Friend WithEvents lblConfidenceLimit As Label
    Friend WithEvents lblHyp As Label
    Friend WithEvents grpVarAndWilcox As GroupBox
    Friend WithEvents rdoMeanWilcox As RadioButton
    Friend WithEvents rdoVarSign As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents rdoEnorm As RadioButton
    Friend WithEvents ucrPnlStats As UcrPanel
    Friend WithEvents grpVarAndWilcoxSign As GroupBox
    Friend WithEvents rdoWilcoxSignTest As RadioButton
    Friend WithEvents rdoVarSignTest As RadioButton
    Friend WithEvents ucrPnlWilcoxVarTest As UcrPanel
End Class