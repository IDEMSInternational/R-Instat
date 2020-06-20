<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrContinuousVerification
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ucrChkME = New instat.ucrCheck()
        Me.grpHyroGOF = New System.Windows.Forms.GroupBox()
        Me.lblJmia = New System.Windows.Forms.Label()
        Me.ucrInputJmia = New instat.ucrInputTextBox()
        Me.ucrChkRelativeIndexOfAgreement = New instat.ucrCheck()
        Me.ucrChkRatioOfStandardDeviation = New instat.ucrCheck()
        Me.ucrChkCoefDetermination = New instat.ucrCheck()
        Me.ucrChkRatioOfRootMeanSquaredError = New instat.ucrCheck()
        Me.ucrChkRelativeNashSutcliffeEff = New instat.ucrCheck()
        Me.ucrChkModifiedIndexOfAgreement = New instat.ucrCheck()
        Me.ucrChkCoefPersistence = New instat.ucrCheck()
        Me.ucrChkNashSutcliffeEfficiency = New instat.ucrCheck()
        Me.ucrChkSumOfSquaredResiduals = New instat.ucrCheck()
        Me.ucrChkKlingGuptaEfficiency = New instat.ucrCheck()
        Me.ucrChkVolumetricEfficiency = New instat.ucrCheck()
        Me.ucrChkPercentBias = New instat.ucrCheck()
        Me.ucrChkModNashSutcliffeEff = New instat.ucrCheck()
        Me.ucrChkMeanError = New instat.ucrCheck()
        Me.ucrChkMeanSquaredError = New instat.ucrCheck()
        Me.ucrChkRootMeanSquaredError = New instat.ucrCheck()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.ucrChkNormRootMeanSquaredError = New instat.ucrCheck()
        Me.ucrChkMeanAbsoluteError = New instat.ucrCheck()
        Me.ucrChkIndexOfAgreement = New instat.ucrCheck()
        Me.ucrChkSelectAll = New instat.ucrCheck()
        Me.ucrChkMAE = New instat.ucrCheck()
        Me.ucrChkMSE = New instat.ucrCheck()
        Me.grpVerification = New System.Windows.Forms.GroupBox()
        Me.grpHyroGOF.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrChkME
        '
        Me.ucrChkME.Checked = False
        Me.ucrChkME.Location = New System.Drawing.Point(22, 41)
        Me.ucrChkME.Name = "ucrChkME"
        Me.ucrChkME.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkME.TabIndex = 7
        '
        'grpHyroGOF
        '
        Me.grpHyroGOF.Controls.Add(Me.lblJmia)
        Me.grpHyroGOF.Controls.Add(Me.ucrInputJmia)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkRelativeIndexOfAgreement)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkRatioOfStandardDeviation)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkCoefDetermination)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkRatioOfRootMeanSquaredError)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkRelativeNashSutcliffeEff)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkModifiedIndexOfAgreement)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkCoefPersistence)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkNashSutcliffeEfficiency)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkSumOfSquaredResiduals)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkKlingGuptaEfficiency)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkVolumetricEfficiency)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkPercentBias)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkModNashSutcliffeEff)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkMeanError)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkMeanSquaredError)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkRootMeanSquaredError)
        Me.grpHyroGOF.Controls.Add(Me.cmdHelp)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkNormRootMeanSquaredError)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkMeanAbsoluteError)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkIndexOfAgreement)
        Me.grpHyroGOF.Location = New System.Drawing.Point(11, 111)
        Me.grpHyroGOF.Name = "grpHyroGOF"
        Me.grpHyroGOF.Size = New System.Drawing.Size(409, 145)
        Me.grpHyroGOF.TabIndex = 11
        Me.grpHyroGOF.TabStop = False
        Me.grpHyroGOF.Text = "HydroGOF"
        '
        'lblJmia
        '
        Me.lblJmia.AutoSize = True
        Me.lblJmia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblJmia.Location = New System.Drawing.Point(284, 125)
        Me.lblJmia.Name = "lblJmia"
        Me.lblJmia.Size = New System.Drawing.Size(12, 13)
        Me.lblJmia.TabIndex = 20
        Me.lblJmia.Text = "j:"
        '
        'ucrInputJmia
        '
        Me.ucrInputJmia.AddQuotesIfUnrecognised = True
        Me.ucrInputJmia.IsMultiline = False
        Me.ucrInputJmia.IsReadOnly = False
        Me.ucrInputJmia.Location = New System.Drawing.Point(299, 122)
        Me.ucrInputJmia.Name = "ucrInputJmia"
        Me.ucrInputJmia.Size = New System.Drawing.Size(32, 21)
        Me.ucrInputJmia.TabIndex = 21
        '
        'ucrChkRelativeIndexOfAgreement
        '
        Me.ucrChkRelativeIndexOfAgreement.Checked = False
        Me.ucrChkRelativeIndexOfAgreement.Location = New System.Drawing.Point(204, 75)
        Me.ucrChkRelativeIndexOfAgreement.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkRelativeIndexOfAgreement.Name = "ucrChkRelativeIndexOfAgreement"
        Me.ucrChkRelativeIndexOfAgreement.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkRelativeIndexOfAgreement.TabIndex = 13
        '
        'ucrChkRatioOfStandardDeviation
        '
        Me.ucrChkRatioOfStandardDeviation.Checked = False
        Me.ucrChkRatioOfStandardDeviation.Location = New System.Drawing.Point(94, 54)
        Me.ucrChkRatioOfStandardDeviation.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkRatioOfStandardDeviation.Name = "ucrChkRatioOfStandardDeviation"
        Me.ucrChkRatioOfStandardDeviation.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkRatioOfStandardDeviation.TabIndex = 7
        '
        'ucrChkCoefDetermination
        '
        Me.ucrChkCoefDetermination.Checked = False
        Me.ucrChkCoefDetermination.Location = New System.Drawing.Point(204, 116)
        Me.ucrChkCoefDetermination.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkCoefDetermination.Name = "ucrChkCoefDetermination"
        Me.ucrChkCoefDetermination.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkCoefDetermination.TabIndex = 15
        '
        'ucrChkRatioOfRootMeanSquaredError
        '
        Me.ucrChkRatioOfRootMeanSquaredError.Checked = False
        Me.ucrChkRatioOfRootMeanSquaredError.Location = New System.Drawing.Point(94, 34)
        Me.ucrChkRatioOfRootMeanSquaredError.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkRatioOfRootMeanSquaredError.Name = "ucrChkRatioOfRootMeanSquaredError"
        Me.ucrChkRatioOfRootMeanSquaredError.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkRatioOfRootMeanSquaredError.TabIndex = 6
        '
        'ucrChkRelativeNashSutcliffeEff
        '
        Me.ucrChkRelativeNashSutcliffeEff.Checked = False
        Me.ucrChkRelativeNashSutcliffeEff.Location = New System.Drawing.Point(94, 115)
        Me.ucrChkRelativeNashSutcliffeEff.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkRelativeNashSutcliffeEff.Name = "ucrChkRelativeNashSutcliffeEff"
        Me.ucrChkRelativeNashSutcliffeEff.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkRelativeNashSutcliffeEff.TabIndex = 10
        '
        'ucrChkModifiedIndexOfAgreement
        '
        Me.ucrChkModifiedIndexOfAgreement.Checked = False
        Me.ucrChkModifiedIndexOfAgreement.Location = New System.Drawing.Point(204, 36)
        Me.ucrChkModifiedIndexOfAgreement.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkModifiedIndexOfAgreement.Name = "ucrChkModifiedIndexOfAgreement"
        Me.ucrChkModifiedIndexOfAgreement.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkModifiedIndexOfAgreement.TabIndex = 11
        '
        'ucrChkCoefPersistence
        '
        Me.ucrChkCoefPersistence.Checked = False
        Me.ucrChkCoefPersistence.Location = New System.Drawing.Point(204, 95)
        Me.ucrChkCoefPersistence.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkCoefPersistence.Name = "ucrChkCoefPersistence"
        Me.ucrChkCoefPersistence.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkCoefPersistence.TabIndex = 14
        '
        'ucrChkNashSutcliffeEfficiency
        '
        Me.ucrChkNashSutcliffeEfficiency.Checked = False
        Me.ucrChkNashSutcliffeEfficiency.Location = New System.Drawing.Point(94, 75)
        Me.ucrChkNashSutcliffeEfficiency.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkNashSutcliffeEfficiency.Name = "ucrChkNashSutcliffeEfficiency"
        Me.ucrChkNashSutcliffeEfficiency.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkNashSutcliffeEfficiency.TabIndex = 8
        '
        'ucrChkSumOfSquaredResiduals
        '
        Me.ucrChkSumOfSquaredResiduals.Checked = False
        Me.ucrChkSumOfSquaredResiduals.Location = New System.Drawing.Point(306, 100)
        Me.ucrChkSumOfSquaredResiduals.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkSumOfSquaredResiduals.Name = "ucrChkSumOfSquaredResiduals"
        Me.ucrChkSumOfSquaredResiduals.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkSumOfSquaredResiduals.TabIndex = 19
        '
        'ucrChkKlingGuptaEfficiency
        '
        Me.ucrChkKlingGuptaEfficiency.Checked = False
        Me.ucrChkKlingGuptaEfficiency.Location = New System.Drawing.Point(306, 38)
        Me.ucrChkKlingGuptaEfficiency.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkKlingGuptaEfficiency.Name = "ucrChkKlingGuptaEfficiency"
        Me.ucrChkKlingGuptaEfficiency.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkKlingGuptaEfficiency.TabIndex = 16
        '
        'ucrChkVolumetricEfficiency
        '
        Me.ucrChkVolumetricEfficiency.Checked = False
        Me.ucrChkVolumetricEfficiency.Location = New System.Drawing.Point(306, 58)
        Me.ucrChkVolumetricEfficiency.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkVolumetricEfficiency.Name = "ucrChkVolumetricEfficiency"
        Me.ucrChkVolumetricEfficiency.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkVolumetricEfficiency.TabIndex = 17
        '
        'ucrChkPercentBias
        '
        Me.ucrChkPercentBias.Checked = False
        Me.ucrChkPercentBias.Location = New System.Drawing.Point(8, 116)
        Me.ucrChkPercentBias.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkPercentBias.Name = "ucrChkPercentBias"
        Me.ucrChkPercentBias.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkPercentBias.TabIndex = 5
        '
        'ucrChkModNashSutcliffeEff
        '
        Me.ucrChkModNashSutcliffeEff.Checked = False
        Me.ucrChkModNashSutcliffeEff.Location = New System.Drawing.Point(94, 95)
        Me.ucrChkModNashSutcliffeEff.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkModNashSutcliffeEff.Name = "ucrChkModNashSutcliffeEff"
        Me.ucrChkModNashSutcliffeEff.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkModNashSutcliffeEff.TabIndex = 9
        '
        'ucrChkMeanError
        '
        Me.ucrChkMeanError.Checked = False
        Me.ucrChkMeanError.Location = New System.Drawing.Point(8, 34)
        Me.ucrChkMeanError.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkMeanError.Name = "ucrChkMeanError"
        Me.ucrChkMeanError.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkMeanError.TabIndex = 1
        '
        'ucrChkMeanSquaredError
        '
        Me.ucrChkMeanSquaredError.Checked = False
        Me.ucrChkMeanSquaredError.Location = New System.Drawing.Point(306, 79)
        Me.ucrChkMeanSquaredError.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkMeanSquaredError.Name = "ucrChkMeanSquaredError"
        Me.ucrChkMeanSquaredError.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkMeanSquaredError.TabIndex = 18
        '
        'ucrChkRootMeanSquaredError
        '
        Me.ucrChkRootMeanSquaredError.Checked = False
        Me.ucrChkRootMeanSquaredError.Location = New System.Drawing.Point(8, 74)
        Me.ucrChkRootMeanSquaredError.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkRootMeanSquaredError.Name = "ucrChkRootMeanSquaredError"
        Me.ucrChkRootMeanSquaredError.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkRootMeanSquaredError.TabIndex = 3
        '
        'cmdHelp
        '
        Me.cmdHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHelp.Location = New System.Drawing.Point(331, 120)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(68, 23)
        Me.cmdHelp.TabIndex = 22
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'ucrChkNormRootMeanSquaredError
        '
        Me.ucrChkNormRootMeanSquaredError.Checked = False
        Me.ucrChkNormRootMeanSquaredError.Location = New System.Drawing.Point(8, 95)
        Me.ucrChkNormRootMeanSquaredError.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkNormRootMeanSquaredError.Name = "ucrChkNormRootMeanSquaredError"
        Me.ucrChkNormRootMeanSquaredError.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkNormRootMeanSquaredError.TabIndex = 4
        '
        'ucrChkMeanAbsoluteError
        '
        Me.ucrChkMeanAbsoluteError.Checked = False
        Me.ucrChkMeanAbsoluteError.Location = New System.Drawing.Point(8, 54)
        Me.ucrChkMeanAbsoluteError.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkMeanAbsoluteError.Name = "ucrChkMeanAbsoluteError"
        Me.ucrChkMeanAbsoluteError.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkMeanAbsoluteError.TabIndex = 2
        '
        'ucrChkIndexOfAgreement
        '
        Me.ucrChkIndexOfAgreement.Checked = False
        Me.ucrChkIndexOfAgreement.Location = New System.Drawing.Point(204, 57)
        Me.ucrChkIndexOfAgreement.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkIndexOfAgreement.Name = "ucrChkIndexOfAgreement"
        Me.ucrChkIndexOfAgreement.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkIndexOfAgreement.TabIndex = 12
        '
        'ucrChkSelectAll
        '
        Me.ucrChkSelectAll.Checked = False
        Me.ucrChkSelectAll.Location = New System.Drawing.Point(19, 1)
        Me.ucrChkSelectAll.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkSelectAll.Name = "ucrChkSelectAll"
        Me.ucrChkSelectAll.Size = New System.Drawing.Size(87, 20)
        Me.ucrChkSelectAll.TabIndex = 8
        '
        'ucrChkMAE
        '
        Me.ucrChkMAE.Checked = False
        Me.ucrChkMAE.Location = New System.Drawing.Point(22, 71)
        Me.ucrChkMAE.Name = "ucrChkMAE"
        Me.ucrChkMAE.Size = New System.Drawing.Size(154, 20)
        Me.ucrChkMAE.TabIndex = 10
        '
        'ucrChkMSE
        '
        Me.ucrChkMSE.Checked = False
        Me.ucrChkMSE.Location = New System.Drawing.Point(162, 41)
        Me.ucrChkMSE.Name = "ucrChkMSE"
        Me.ucrChkMSE.Size = New System.Drawing.Size(161, 20)
        Me.ucrChkMSE.TabIndex = 9
        '
        'grpVerification
        '
        Me.grpVerification.Location = New System.Drawing.Point(11, 25)
        Me.grpVerification.Name = "grpVerification"
        Me.grpVerification.Size = New System.Drawing.Size(409, 81)
        Me.grpVerification.TabIndex = 12
        Me.grpVerification.TabStop = False
        Me.grpVerification.Text = "Verification"
        '
        'ucrContinuousVerification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkME)
        Me.Controls.Add(Me.grpHyroGOF)
        Me.Controls.Add(Me.ucrChkSelectAll)
        Me.Controls.Add(Me.ucrChkMAE)
        Me.Controls.Add(Me.ucrChkMSE)
        Me.Controls.Add(Me.grpVerification)
        Me.Name = "ucrContinuousVerification"
        Me.Size = New System.Drawing.Size(430, 265)
        Me.grpHyroGOF.ResumeLayout(False)
        Me.grpHyroGOF.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrChkME As ucrCheck
    Friend WithEvents grpHyroGOF As GroupBox
    Friend WithEvents lblJmia As Label
    Friend WithEvents ucrInputJmia As ucrInputTextBox
    Friend WithEvents ucrChkRelativeIndexOfAgreement As ucrCheck
    Friend WithEvents ucrChkRatioOfStandardDeviation As ucrCheck
    Friend WithEvents ucrChkCoefDetermination As ucrCheck
    Friend WithEvents ucrChkRatioOfRootMeanSquaredError As ucrCheck
    Friend WithEvents ucrChkRelativeNashSutcliffeEff As ucrCheck
    Friend WithEvents ucrChkModifiedIndexOfAgreement As ucrCheck
    Friend WithEvents ucrChkCoefPersistence As ucrCheck
    Friend WithEvents ucrChkNashSutcliffeEfficiency As ucrCheck
    Friend WithEvents ucrChkSumOfSquaredResiduals As ucrCheck
    Friend WithEvents ucrChkKlingGuptaEfficiency As ucrCheck
    Friend WithEvents ucrChkVolumetricEfficiency As ucrCheck
    Friend WithEvents ucrChkPercentBias As ucrCheck
    Friend WithEvents ucrChkModNashSutcliffeEff As ucrCheck
    Friend WithEvents ucrChkMeanError As ucrCheck
    Friend WithEvents ucrChkMeanSquaredError As ucrCheck
    Friend WithEvents ucrChkRootMeanSquaredError As ucrCheck
    Friend WithEvents cmdHelp As Button
    Friend WithEvents ucrChkNormRootMeanSquaredError As ucrCheck
    Friend WithEvents ucrChkMeanAbsoluteError As ucrCheck
    Friend WithEvents ucrChkIndexOfAgreement As ucrCheck
    Friend WithEvents ucrChkSelectAll As ucrCheck
    Friend WithEvents ucrChkMAE As ucrCheck
    Friend WithEvents ucrChkMSE As ucrCheck
    Friend WithEvents grpVerification As GroupBox
End Class
