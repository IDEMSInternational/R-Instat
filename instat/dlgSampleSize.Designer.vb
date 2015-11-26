<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSampleSize
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
        Me.ucrBase = New instat.ucrButtons()
        Me.grpDifferences = New System.Windows.Forms.GroupBox()
        Me.rdoProportions = New System.Windows.Forms.RadioButton()
        Me.rdoMeans = New System.Windows.Forms.RadioButton()
        Me.chkSaveResults = New System.Windows.Forms.CheckBox()
        Me.cboSave = New System.Windows.Forms.ComboBox()
        Me.grpRequiredParameters = New System.Windows.Forms.GroupBox()
        Me.chkTwoSidedalt = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtProportion1 = New System.Windows.Forms.TextBox()
        Me.txtstandardDeviation = New System.Windows.Forms.TextBox()
        Me.lblSignificanceLevel = New System.Windows.Forms.Label()
        Me.lblProportion1 = New System.Windows.Forms.Label()
        Me.lblStandardDeviation = New System.Windows.Forms.Label()
        Me.grpCalculate = New System.Windows.Forms.GroupBox()
        Me.rdoRelativeRisk = New System.Windows.Forms.RadioButton()
        Me.rdoDifference = New System.Windows.Forms.RadioButton()
        Me.rdoPower = New System.Windows.Forms.RadioButton()
        Me.rdoSampleSize = New System.Windows.Forms.RadioButton()
        Me.grpInputParameters = New System.Windows.Forms.GroupBox()
        Me.txtRelativeRisk = New System.Windows.Forms.TextBox()
        Me.lblRelativeRisk = New System.Windows.Forms.Label()
        Me.txtProportion2 = New System.Windows.Forms.TextBox()
        Me.lblProportion2 = New System.Windows.Forms.Label()
        Me.txtPower = New System.Windows.Forms.TextBox()
        Me.lblPower = New System.Windows.Forms.Label()
        Me.txtSampleSize = New System.Windows.Forms.TextBox()
        Me.lblSampleSize = New System.Windows.Forms.Label()
        Me.lblDifference = New System.Windows.Forms.Label()
        Me.txtDifference = New System.Windows.Forms.TextBox()
        Me.grpDifferences.SuspendLayout()
        Me.grpRequiredParameters.SuspendLayout()
        Me.grpCalculate.SuspendLayout()
        Me.grpInputParameters.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(1, 324)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'grpDifferences
        '
        Me.grpDifferences.Controls.Add(Me.rdoProportions)
        Me.grpDifferences.Controls.Add(Me.rdoMeans)
        Me.grpDifferences.Location = New System.Drawing.Point(12, 12)
        Me.grpDifferences.Name = "grpDifferences"
        Me.grpDifferences.Size = New System.Drawing.Size(227, 46)
        Me.grpDifferences.TabIndex = 2
        Me.grpDifferences.TabStop = False
        Me.grpDifferences.Tag = "Differences_Between_two"
        Me.grpDifferences.Text = "Differences Between two"
        '
        'rdoProportions
        '
        Me.rdoProportions.AutoSize = True
        Me.rdoProportions.Location = New System.Drawing.Point(92, 20)
        Me.rdoProportions.Name = "rdoProportions"
        Me.rdoProportions.Size = New System.Drawing.Size(78, 17)
        Me.rdoProportions.TabIndex = 0
        Me.rdoProportions.TabStop = True
        Me.rdoProportions.Tag = "Proportions"
        Me.rdoProportions.Text = "Proportions"
        Me.rdoProportions.UseVisualStyleBackColor = True
        '
        'rdoMeans
        '
        Me.rdoMeans.AutoSize = True
        Me.rdoMeans.Location = New System.Drawing.Point(5, 20)
        Me.rdoMeans.Name = "rdoMeans"
        Me.rdoMeans.Size = New System.Drawing.Size(57, 17)
        Me.rdoMeans.TabIndex = 0
        Me.rdoMeans.TabStop = True
        Me.rdoMeans.Tag = "Means"
        Me.rdoMeans.Text = "Means"
        Me.rdoMeans.UseVisualStyleBackColor = True
        '
        'chkSaveResults
        '
        Me.chkSaveResults.AutoSize = True
        Me.chkSaveResults.Location = New System.Drawing.Point(256, 12)
        Me.chkSaveResults.Name = "chkSaveResults"
        Me.chkSaveResults.Size = New System.Drawing.Size(89, 17)
        Me.chkSaveResults.TabIndex = 3
        Me.chkSaveResults.Tag = "Save_Results"
        Me.chkSaveResults.Text = "Save Results"
        Me.chkSaveResults.UseVisualStyleBackColor = True
        '
        'cboSave
        '
        Me.cboSave.FormattingEnabled = True
        Me.cboSave.Location = New System.Drawing.Point(256, 36)
        Me.cboSave.Name = "cboSave"
        Me.cboSave.Size = New System.Drawing.Size(121, 21)
        Me.cboSave.TabIndex = 4
        '
        'grpRequiredParameters
        '
        Me.grpRequiredParameters.Controls.Add(Me.chkTwoSidedalt)
        Me.grpRequiredParameters.Controls.Add(Me.TextBox1)
        Me.grpRequiredParameters.Controls.Add(Me.txtProportion1)
        Me.grpRequiredParameters.Controls.Add(Me.txtstandardDeviation)
        Me.grpRequiredParameters.Controls.Add(Me.lblSignificanceLevel)
        Me.grpRequiredParameters.Controls.Add(Me.lblProportion1)
        Me.grpRequiredParameters.Controls.Add(Me.lblStandardDeviation)
        Me.grpRequiredParameters.Location = New System.Drawing.Point(12, 75)
        Me.grpRequiredParameters.Name = "grpRequiredParameters"
        Me.grpRequiredParameters.Size = New System.Drawing.Size(365, 81)
        Me.grpRequiredParameters.TabIndex = 2
        Me.grpRequiredParameters.TabStop = False
        Me.grpRequiredParameters.Tag = "Required_Parameters"
        Me.grpRequiredParameters.Text = "Required Parameters"
        '
        'chkTwoSidedalt
        '
        Me.chkTwoSidedalt.AutoSize = True
        Me.chkTwoSidedalt.Location = New System.Drawing.Point(232, 52)
        Me.chkTwoSidedalt.Name = "chkTwoSidedalt"
        Me.chkTwoSidedalt.Size = New System.Drawing.Size(130, 17)
        Me.chkTwoSidedalt.TabIndex = 2
        Me.chkTwoSidedalt.Tag = "Two_Sided_Alternative"
        Me.chkTwoSidedalt.Text = "Two Sided Alternative"
        Me.chkTwoSidedalt.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(112, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'txtProportion1
        '
        Me.txtProportion1.Location = New System.Drawing.Point(298, 19)
        Me.txtProportion1.Name = "txtProportion1"
        Me.txtProportion1.Size = New System.Drawing.Size(61, 20)
        Me.txtProportion1.TabIndex = 1
        '
        'txtstandardDeviation
        '
        Me.txtstandardDeviation.Location = New System.Drawing.Point(112, 20)
        Me.txtstandardDeviation.Name = "txtstandardDeviation"
        Me.txtstandardDeviation.Size = New System.Drawing.Size(100, 20)
        Me.txtstandardDeviation.TabIndex = 1
        '
        'lblSignificanceLevel
        '
        Me.lblSignificanceLevel.AutoSize = True
        Me.lblSignificanceLevel.Location = New System.Drawing.Point(7, 50)
        Me.lblSignificanceLevel.Name = "lblSignificanceLevel"
        Me.lblSignificanceLevel.Size = New System.Drawing.Size(94, 13)
        Me.lblSignificanceLevel.TabIndex = 0
        Me.lblSignificanceLevel.Tag = "Significance_Level"
        Me.lblSignificanceLevel.Text = "Significance Level"
        '
        'lblProportion1
        '
        Me.lblProportion1.AutoSize = True
        Me.lblProportion1.Location = New System.Drawing.Point(231, 20)
        Me.lblProportion1.Name = "lblProportion1"
        Me.lblProportion1.Size = New System.Drawing.Size(61, 13)
        Me.lblProportion1.TabIndex = 0
        Me.lblProportion1.Tag = "Proportion1"
        Me.lblProportion1.Text = "Proportion1"
        '
        'lblStandardDeviation
        '
        Me.lblStandardDeviation.AutoSize = True
        Me.lblStandardDeviation.Location = New System.Drawing.Point(7, 20)
        Me.lblStandardDeviation.Name = "lblStandardDeviation"
        Me.lblStandardDeviation.Size = New System.Drawing.Size(98, 13)
        Me.lblStandardDeviation.TabIndex = 0
        Me.lblStandardDeviation.Tag = "Standard_Deviation"
        Me.lblStandardDeviation.Text = "Standard Deviation"
        '
        'grpCalculate
        '
        Me.grpCalculate.Controls.Add(Me.rdoRelativeRisk)
        Me.grpCalculate.Controls.Add(Me.rdoDifference)
        Me.grpCalculate.Controls.Add(Me.rdoPower)
        Me.grpCalculate.Controls.Add(Me.rdoSampleSize)
        Me.grpCalculate.Location = New System.Drawing.Point(12, 171)
        Me.grpCalculate.Name = "grpCalculate"
        Me.grpCalculate.Size = New System.Drawing.Size(365, 46)
        Me.grpCalculate.TabIndex = 2
        Me.grpCalculate.TabStop = False
        Me.grpCalculate.Tag = "Calculate"
        Me.grpCalculate.Text = "Calculate"
        '
        'rdoRelativeRisk
        '
        Me.rdoRelativeRisk.AutoSize = True
        Me.rdoRelativeRisk.Location = New System.Drawing.Point(255, 19)
        Me.rdoRelativeRisk.Name = "rdoRelativeRisk"
        Me.rdoRelativeRisk.Size = New System.Drawing.Size(88, 17)
        Me.rdoRelativeRisk.TabIndex = 0
        Me.rdoRelativeRisk.TabStop = True
        Me.rdoRelativeRisk.Tag = "Relative_Risk"
        Me.rdoRelativeRisk.Text = "Relative Risk"
        Me.rdoRelativeRisk.UseVisualStyleBackColor = True
        '
        'rdoDifference
        '
        Me.rdoDifference.AutoSize = True
        Me.rdoDifference.Location = New System.Drawing.Point(172, 19)
        Me.rdoDifference.Name = "rdoDifference"
        Me.rdoDifference.Size = New System.Drawing.Size(77, 17)
        Me.rdoDifference.TabIndex = 0
        Me.rdoDifference.TabStop = True
        Me.rdoDifference.Tag = "Difference "
        Me.rdoDifference.Text = "Difference "
        Me.rdoDifference.UseVisualStyleBackColor = True
        '
        'rdoPower
        '
        Me.rdoPower.AutoSize = True
        Me.rdoPower.Location = New System.Drawing.Point(92, 20)
        Me.rdoPower.Name = "rdoPower"
        Me.rdoPower.Size = New System.Drawing.Size(55, 17)
        Me.rdoPower.TabIndex = 0
        Me.rdoPower.TabStop = True
        Me.rdoPower.Tag = "Power"
        Me.rdoPower.Text = "Power"
        Me.rdoPower.UseVisualStyleBackColor = True
        '
        'rdoSampleSize
        '
        Me.rdoSampleSize.AutoSize = True
        Me.rdoSampleSize.Location = New System.Drawing.Point(5, 20)
        Me.rdoSampleSize.Name = "rdoSampleSize"
        Me.rdoSampleSize.Size = New System.Drawing.Size(83, 17)
        Me.rdoSampleSize.TabIndex = 0
        Me.rdoSampleSize.TabStop = True
        Me.rdoSampleSize.Tag = "Sample_Size"
        Me.rdoSampleSize.Text = "Sample Size"
        Me.rdoSampleSize.UseVisualStyleBackColor = True
        '
        'grpInputParameters
        '
        Me.grpInputParameters.Controls.Add(Me.txtRelativeRisk)
        Me.grpInputParameters.Controls.Add(Me.lblRelativeRisk)
        Me.grpInputParameters.Controls.Add(Me.txtProportion2)
        Me.grpInputParameters.Controls.Add(Me.lblProportion2)
        Me.grpInputParameters.Controls.Add(Me.txtPower)
        Me.grpInputParameters.Controls.Add(Me.lblPower)
        Me.grpInputParameters.Controls.Add(Me.txtDifference)
        Me.grpInputParameters.Controls.Add(Me.lblDifference)
        Me.grpInputParameters.Controls.Add(Me.txtSampleSize)
        Me.grpInputParameters.Controls.Add(Me.lblSampleSize)
        Me.grpInputParameters.Location = New System.Drawing.Point(12, 223)
        Me.grpInputParameters.Name = "grpInputParameters"
        Me.grpInputParameters.Size = New System.Drawing.Size(365, 97)
        Me.grpInputParameters.TabIndex = 2
        Me.grpInputParameters.TabStop = False
        Me.grpInputParameters.Tag = "Input_Parameters"
        Me.grpInputParameters.Text = "Input Parameters"
        '
        'txtRelativeRisk
        '
        Me.txtRelativeRisk.Location = New System.Drawing.Point(286, 71)
        Me.txtRelativeRisk.Name = "txtRelativeRisk"
        Me.txtRelativeRisk.Size = New System.Drawing.Size(73, 20)
        Me.txtRelativeRisk.TabIndex = 1
        '
        'lblRelativeRisk
        '
        Me.lblRelativeRisk.AutoSize = True
        Me.lblRelativeRisk.Location = New System.Drawing.Point(212, 72)
        Me.lblRelativeRisk.Name = "lblRelativeRisk"
        Me.lblRelativeRisk.Size = New System.Drawing.Size(70, 13)
        Me.lblRelativeRisk.TabIndex = 0
        Me.lblRelativeRisk.Tag = "Relative_Risk"
        Me.lblRelativeRisk.Text = "Relative Risk"
        '
        'txtProportion2
        '
        Me.txtProportion2.Location = New System.Drawing.Point(286, 44)
        Me.txtProportion2.Name = "txtProportion2"
        Me.txtProportion2.Size = New System.Drawing.Size(73, 20)
        Me.txtProportion2.TabIndex = 1
        '
        'lblProportion2
        '
        Me.lblProportion2.AutoSize = True
        Me.lblProportion2.Location = New System.Drawing.Point(211, 51)
        Me.lblProportion2.Name = "lblProportion2"
        Me.lblProportion2.Size = New System.Drawing.Size(61, 13)
        Me.lblProportion2.TabIndex = 0
        Me.lblProportion2.Tag = "Proportion2"
        Me.lblProportion2.Text = "Proportion2"
        '
        'txtPower
        '
        Me.txtPower.Location = New System.Drawing.Point(286, 18)
        Me.txtPower.Name = "txtPower"
        Me.txtPower.Size = New System.Drawing.Size(73, 20)
        Me.txtPower.TabIndex = 1
        '
        'lblPower
        '
        Me.lblPower.AutoSize = True
        Me.lblPower.Location = New System.Drawing.Point(212, 25)
        Me.lblPower.Name = "lblPower"
        Me.lblPower.Size = New System.Drawing.Size(37, 13)
        Me.lblPower.TabIndex = 0
        Me.lblPower.Tag = "Power"
        Me.lblPower.Text = "Power"
        '
        'txtSampleSize
        '
        Me.txtSampleSize.Location = New System.Drawing.Point(97, 18)
        Me.txtSampleSize.Name = "txtSampleSize"
        Me.txtSampleSize.Size = New System.Drawing.Size(73, 20)
        Me.txtSampleSize.TabIndex = 1
        '
        'lblSampleSize
        '
        Me.lblSampleSize.AutoSize = True
        Me.lblSampleSize.Location = New System.Drawing.Point(7, 21)
        Me.lblSampleSize.Name = "lblSampleSize"
        Me.lblSampleSize.Size = New System.Drawing.Size(65, 13)
        Me.lblSampleSize.TabIndex = 0
        Me.lblSampleSize.Tag = "Sample_Size"
        Me.lblSampleSize.Text = "Sample Size"
        '
        'lblDifference
        '
        Me.lblDifference.AutoSize = True
        Me.lblDifference.Location = New System.Drawing.Point(7, 47)
        Me.lblDifference.Name = "lblDifference"
        Me.lblDifference.Size = New System.Drawing.Size(56, 13)
        Me.lblDifference.TabIndex = 0
        Me.lblDifference.Tag = "Difference"
        Me.lblDifference.Text = "Difference"
        '
        'txtDifference
        '
        Me.txtDifference.Location = New System.Drawing.Point(97, 44)
        Me.txtDifference.Name = "txtDifference"
        Me.txtDifference.Size = New System.Drawing.Size(73, 20)
        Me.txtDifference.TabIndex = 1
        '
        'dlgSampleSize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 357)
        Me.Controls.Add(Me.cboSave)
        Me.Controls.Add(Me.chkSaveResults)
        Me.Controls.Add(Me.grpRequiredParameters)
        Me.Controls.Add(Me.grpInputParameters)
        Me.Controls.Add(Me.grpCalculate)
        Me.Controls.Add(Me.grpDifferences)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgSampleSize"
        Me.Text = "dlgSampleSizevb"
        Me.grpDifferences.ResumeLayout(False)
        Me.grpDifferences.PerformLayout()
        Me.grpRequiredParameters.ResumeLayout(False)
        Me.grpRequiredParameters.PerformLayout()
        Me.grpCalculate.ResumeLayout(False)
        Me.grpCalculate.PerformLayout()
        Me.grpInputParameters.ResumeLayout(False)
        Me.grpInputParameters.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpDifferences As GroupBox
    Friend WithEvents rdoProportions As RadioButton
    Friend WithEvents rdoMeans As RadioButton
    Friend WithEvents chkSaveResults As CheckBox
    Friend WithEvents cboSave As ComboBox
    Friend WithEvents grpRequiredParameters As GroupBox
    Friend WithEvents chkTwoSidedalt As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtProportion1 As TextBox
    Friend WithEvents txtstandardDeviation As TextBox
    Friend WithEvents lblSignificanceLevel As Label
    Friend WithEvents lblProportion1 As Label
    Friend WithEvents lblStandardDeviation As Label
    Friend WithEvents grpCalculate As GroupBox
    Friend WithEvents rdoRelativeRisk As RadioButton
    Friend WithEvents rdoDifference As RadioButton
    Friend WithEvents rdoPower As RadioButton
    Friend WithEvents rdoSampleSize As RadioButton
    Friend WithEvents grpInputParameters As GroupBox
    Friend WithEvents txtSampleSize As TextBox
    Friend WithEvents lblSampleSize As Label
    Friend WithEvents txtPower As TextBox
    Friend WithEvents lblPower As Label
    Friend WithEvents txtRelativeRisk As TextBox
    Friend WithEvents lblRelativeRisk As Label
    Friend WithEvents txtProportion2 As TextBox
    Friend WithEvents lblProportion2 As Label
    Friend WithEvents txtDifference As TextBox
    Friend WithEvents lblDifference As Label
End Class
