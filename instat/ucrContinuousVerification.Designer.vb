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
        Me.components = New System.ComponentModel.Container()
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
        Me.ttVerificationSummaries = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrChkSelectAll = New instat.ucrCheck()
        Me.ucrChkCorrelations = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblJmia
        '
        Me.lblJmia.AutoSize = True
        Me.lblJmia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblJmia.Location = New System.Drawing.Point(423, 176)
        Me.lblJmia.Name = "lblJmia"
        Me.lblJmia.Size = New System.Drawing.Size(15, 13)
        Me.lblJmia.TabIndex = 20
        Me.lblJmia.Text = "J:"
        '
        'ucrInputJmia
        '
        Me.ucrInputJmia.AddQuotesIfUnrecognised = True
        Me.ucrInputJmia.AutoSize = True
        Me.ucrInputJmia.IsMultiline = False
        Me.ucrInputJmia.IsReadOnly = False
        Me.ucrInputJmia.Location = New System.Drawing.Point(442, 172)
        Me.ucrInputJmia.Name = "ucrInputJmia"
        Me.ucrInputJmia.Size = New System.Drawing.Size(32, 21)
        Me.ucrInputJmia.TabIndex = 21
        '
        'ucrChkRelativeIndexOfAgreement
        '
        Me.ucrChkRelativeIndexOfAgreement.AutoSize = True
        Me.ucrChkRelativeIndexOfAgreement.Checked = False
        Me.ucrChkRelativeIndexOfAgreement.Location = New System.Drawing.Point(183, 146)
        Me.ucrChkRelativeIndexOfAgreement.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkRelativeIndexOfAgreement.Name = "ucrChkRelativeIndexOfAgreement"
        Me.ucrChkRelativeIndexOfAgreement.Size = New System.Drawing.Size(191, 23)
        Me.ucrChkRelativeIndexOfAgreement.TabIndex = 13
        '
        'ucrChkRatioOfStandardDeviation
        '
        Me.ucrChkRatioOfStandardDeviation.AutoSize = True
        Me.ucrChkRatioOfStandardDeviation.Checked = False
        Me.ucrChkRatioOfStandardDeviation.Location = New System.Drawing.Point(14, 168)
        Me.ucrChkRatioOfStandardDeviation.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkRatioOfStandardDeviation.Name = "ucrChkRatioOfStandardDeviation"
        Me.ucrChkRatioOfStandardDeviation.Size = New System.Drawing.Size(159, 23)
        Me.ucrChkRatioOfStandardDeviation.TabIndex = 7
        '
        'ucrChkCoefDetermination
        '
        Me.ucrChkCoefDetermination.AutoSize = True
        Me.ucrChkCoefDetermination.Checked = False
        Me.ucrChkCoefDetermination.Location = New System.Drawing.Point(14, 146)
        Me.ucrChkCoefDetermination.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkCoefDetermination.Name = "ucrChkCoefDetermination"
        Me.ucrChkCoefDetermination.Size = New System.Drawing.Size(159, 23)
        Me.ucrChkCoefDetermination.TabIndex = 15
        '
        'ucrChkRatioOfRootMeanSquaredError
        '
        Me.ucrChkRatioOfRootMeanSquaredError.AutoSize = True
        Me.ucrChkRatioOfRootMeanSquaredError.Checked = False
        Me.ucrChkRatioOfRootMeanSquaredError.Location = New System.Drawing.Point(376, 36)
        Me.ucrChkRatioOfRootMeanSquaredError.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkRatioOfRootMeanSquaredError.Name = "ucrChkRatioOfRootMeanSquaredError"
        Me.ucrChkRatioOfRootMeanSquaredError.Size = New System.Drawing.Size(179, 23)
        Me.ucrChkRatioOfRootMeanSquaredError.TabIndex = 6
        '
        'ucrChkRelativeNashSutcliffeEff
        '
        Me.ucrChkRelativeNashSutcliffeEff.AutoSize = True
        Me.ucrChkRelativeNashSutcliffeEff.Checked = False
        Me.ucrChkRelativeNashSutcliffeEff.Location = New System.Drawing.Point(183, 80)
        Me.ucrChkRelativeNashSutcliffeEff.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkRelativeNashSutcliffeEff.Name = "ucrChkRelativeNashSutcliffeEff"
        Me.ucrChkRelativeNashSutcliffeEff.Size = New System.Drawing.Size(152, 23)
        Me.ucrChkRelativeNashSutcliffeEff.TabIndex = 10
        '
        'ucrChkModifiedIndexOfAgreement
        '
        Me.ucrChkModifiedIndexOfAgreement.AutoSize = True
        Me.ucrChkModifiedIndexOfAgreement.Checked = False
        Me.ucrChkModifiedIndexOfAgreement.Location = New System.Drawing.Point(183, 102)
        Me.ucrChkModifiedIndexOfAgreement.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkModifiedIndexOfAgreement.Name = "ucrChkModifiedIndexOfAgreement"
        Me.ucrChkModifiedIndexOfAgreement.Size = New System.Drawing.Size(183, 23)
        Me.ucrChkModifiedIndexOfAgreement.TabIndex = 11
        '
        'ucrChkCoefPersistence
        '
        Me.ucrChkCoefPersistence.AutoSize = True
        Me.ucrChkCoefPersistence.Checked = False
        Me.ucrChkCoefPersistence.Location = New System.Drawing.Point(183, 168)
        Me.ucrChkCoefPersistence.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkCoefPersistence.Name = "ucrChkCoefPersistence"
        Me.ucrChkCoefPersistence.Size = New System.Drawing.Size(152, 23)
        Me.ucrChkCoefPersistence.TabIndex = 14
        '
        'ucrChkNashSutcliffeEfficiency
        '
        Me.ucrChkNashSutcliffeEfficiency.AutoSize = True
        Me.ucrChkNashSutcliffeEfficiency.Checked = False
        Me.ucrChkNashSutcliffeEfficiency.Location = New System.Drawing.Point(183, 36)
        Me.ucrChkNashSutcliffeEfficiency.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkNashSutcliffeEfficiency.Name = "ucrChkNashSutcliffeEfficiency"
        Me.ucrChkNashSutcliffeEfficiency.Size = New System.Drawing.Size(152, 23)
        Me.ucrChkNashSutcliffeEfficiency.TabIndex = 8
        '
        'ucrChkSumOfSquaredResiduals
        '
        Me.ucrChkSumOfSquaredResiduals.AutoSize = True
        Me.ucrChkSumOfSquaredResiduals.Checked = False
        Me.ucrChkSumOfSquaredResiduals.Location = New System.Drawing.Point(376, 124)
        Me.ucrChkSumOfSquaredResiduals.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkSumOfSquaredResiduals.Name = "ucrChkSumOfSquaredResiduals"
        Me.ucrChkSumOfSquaredResiduals.Size = New System.Drawing.Size(188, 23)
        Me.ucrChkSumOfSquaredResiduals.TabIndex = 19
        '
        'ucrChkKlingGuptaEfficiency
        '
        Me.ucrChkKlingGuptaEfficiency.AutoSize = True
        Me.ucrChkKlingGuptaEfficiency.Checked = False
        Me.ucrChkKlingGuptaEfficiency.Location = New System.Drawing.Point(376, 58)
        Me.ucrChkKlingGuptaEfficiency.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkKlingGuptaEfficiency.Name = "ucrChkKlingGuptaEfficiency"
        Me.ucrChkKlingGuptaEfficiency.Size = New System.Drawing.Size(188, 23)
        Me.ucrChkKlingGuptaEfficiency.TabIndex = 16
        '
        'ucrChkVolumetricEfficiency
        '
        Me.ucrChkVolumetricEfficiency.AutoSize = True
        Me.ucrChkVolumetricEfficiency.Checked = False
        Me.ucrChkVolumetricEfficiency.Location = New System.Drawing.Point(376, 80)
        Me.ucrChkVolumetricEfficiency.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkVolumetricEfficiency.Name = "ucrChkVolumetricEfficiency"
        Me.ucrChkVolumetricEfficiency.Size = New System.Drawing.Size(188, 23)
        Me.ucrChkVolumetricEfficiency.TabIndex = 17
        '
        'ucrChkPercentBias
        '
        Me.ucrChkPercentBias.AutoSize = True
        Me.ucrChkPercentBias.Checked = False
        Me.ucrChkPercentBias.Location = New System.Drawing.Point(376, 146)
        Me.ucrChkPercentBias.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkPercentBias.Name = "ucrChkPercentBias"
        Me.ucrChkPercentBias.Size = New System.Drawing.Size(188, 23)
        Me.ucrChkPercentBias.TabIndex = 5
        '
        'ucrChkModNashSutcliffeEff
        '
        Me.ucrChkModNashSutcliffeEff.AutoSize = True
        Me.ucrChkModNashSutcliffeEff.Checked = False
        Me.ucrChkModNashSutcliffeEff.Location = New System.Drawing.Point(183, 58)
        Me.ucrChkModNashSutcliffeEff.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkModNashSutcliffeEff.Name = "ucrChkModNashSutcliffeEff"
        Me.ucrChkModNashSutcliffeEff.Size = New System.Drawing.Size(152, 23)
        Me.ucrChkModNashSutcliffeEff.TabIndex = 9
        '
        'ucrChkMeanError
        '
        Me.ucrChkMeanError.AutoSize = True
        Me.ucrChkMeanError.Checked = False
        Me.ucrChkMeanError.Location = New System.Drawing.Point(14, 58)
        Me.ucrChkMeanError.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkMeanError.Name = "ucrChkMeanError"
        Me.ucrChkMeanError.Size = New System.Drawing.Size(159, 23)
        Me.ucrChkMeanError.TabIndex = 1
        '
        'ucrChkMeanSquaredError
        '
        Me.ucrChkMeanSquaredError.AutoSize = True
        Me.ucrChkMeanSquaredError.Checked = False
        Me.ucrChkMeanSquaredError.Location = New System.Drawing.Point(376, 102)
        Me.ucrChkMeanSquaredError.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkMeanSquaredError.Name = "ucrChkMeanSquaredError"
        Me.ucrChkMeanSquaredError.Size = New System.Drawing.Size(188, 23)
        Me.ucrChkMeanSquaredError.TabIndex = 18
        '
        'ucrChkRootMeanSquaredError
        '
        Me.ucrChkRootMeanSquaredError.AutoSize = True
        Me.ucrChkRootMeanSquaredError.Checked = False
        Me.ucrChkRootMeanSquaredError.Location = New System.Drawing.Point(14, 102)
        Me.ucrChkRootMeanSquaredError.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkRootMeanSquaredError.Name = "ucrChkRootMeanSquaredError"
        Me.ucrChkRootMeanSquaredError.Size = New System.Drawing.Size(159, 23)
        Me.ucrChkRootMeanSquaredError.TabIndex = 3
        '
        'cmdHelp
        '
        Me.cmdHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHelp.Location = New System.Drawing.Point(474, 170)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(65, 23)
        Me.cmdHelp.TabIndex = 22
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'ucrChkNormRootMeanSquaredError
        '
        Me.ucrChkNormRootMeanSquaredError.AutoSize = True
        Me.ucrChkNormRootMeanSquaredError.Checked = False
        Me.ucrChkNormRootMeanSquaredError.Location = New System.Drawing.Point(14, 124)
        Me.ucrChkNormRootMeanSquaredError.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkNormRootMeanSquaredError.Name = "ucrChkNormRootMeanSquaredError"
        Me.ucrChkNormRootMeanSquaredError.Size = New System.Drawing.Size(159, 23)
        Me.ucrChkNormRootMeanSquaredError.TabIndex = 4
        '
        'ucrChkMeanAbsoluteError
        '
        Me.ucrChkMeanAbsoluteError.AutoSize = True
        Me.ucrChkMeanAbsoluteError.Checked = False
        Me.ucrChkMeanAbsoluteError.Location = New System.Drawing.Point(14, 80)
        Me.ucrChkMeanAbsoluteError.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkMeanAbsoluteError.Name = "ucrChkMeanAbsoluteError"
        Me.ucrChkMeanAbsoluteError.Size = New System.Drawing.Size(159, 23)
        Me.ucrChkMeanAbsoluteError.TabIndex = 2
        '
        'ucrChkIndexOfAgreement
        '
        Me.ucrChkIndexOfAgreement.AutoSize = True
        Me.ucrChkIndexOfAgreement.Checked = False
        Me.ucrChkIndexOfAgreement.Location = New System.Drawing.Point(183, 124)
        Me.ucrChkIndexOfAgreement.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkIndexOfAgreement.Name = "ucrChkIndexOfAgreement"
        Me.ucrChkIndexOfAgreement.Size = New System.Drawing.Size(152, 23)
        Me.ucrChkIndexOfAgreement.TabIndex = 12
        '
        'ucrChkSelectAll
        '
        Me.ucrChkSelectAll.AutoSize = True
        Me.ucrChkSelectAll.Checked = False
        Me.ucrChkSelectAll.Location = New System.Drawing.Point(14, 6)
        Me.ucrChkSelectAll.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkSelectAll.Name = "ucrChkSelectAll"
        Me.ucrChkSelectAll.Size = New System.Drawing.Size(121, 23)
        Me.ucrChkSelectAll.TabIndex = 8
        '
        'ucrChkCorrelations
        '
        Me.ucrChkCorrelations.AutoSize = True
        Me.ucrChkCorrelations.Checked = False
        Me.ucrChkCorrelations.Location = New System.Drawing.Point(14, 36)
        Me.ucrChkCorrelations.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkCorrelations.Name = "ucrChkCorrelations"
        Me.ucrChkCorrelations.Size = New System.Drawing.Size(159, 23)
        Me.ucrChkCorrelations.TabIndex = 23
        '
        'ucrContinuousVerification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.Controls.Add(Me.ucrChkCorrelations)
        Me.Controls.Add(Me.lblJmia)
        Me.Controls.Add(Me.ucrInputJmia)
        Me.Controls.Add(Me.ucrChkSelectAll)
        Me.Controls.Add(Me.ucrChkRelativeIndexOfAgreement)
        Me.Controls.Add(Me.ucrChkCoefPersistence)
        Me.Controls.Add(Me.ucrChkRatioOfStandardDeviation)
        Me.Controls.Add(Me.ucrChkIndexOfAgreement)
        Me.Controls.Add(Me.ucrChkCoefDetermination)
        Me.Controls.Add(Me.ucrChkMeanAbsoluteError)
        Me.Controls.Add(Me.ucrChkRatioOfRootMeanSquaredError)
        Me.Controls.Add(Me.ucrChkNormRootMeanSquaredError)
        Me.Controls.Add(Me.ucrChkRelativeNashSutcliffeEff)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.ucrChkModifiedIndexOfAgreement)
        Me.Controls.Add(Me.ucrChkRootMeanSquaredError)
        Me.Controls.Add(Me.ucrChkMeanSquaredError)
        Me.Controls.Add(Me.ucrChkNashSutcliffeEfficiency)
        Me.Controls.Add(Me.ucrChkMeanError)
        Me.Controls.Add(Me.ucrChkSumOfSquaredResiduals)
        Me.Controls.Add(Me.ucrChkModNashSutcliffeEff)
        Me.Controls.Add(Me.ucrChkKlingGuptaEfficiency)
        Me.Controls.Add(Me.ucrChkPercentBias)
        Me.Controls.Add(Me.ucrChkVolumetricEfficiency)
        Me.Name = "ucrContinuousVerification"
        Me.Size = New System.Drawing.Size(574, 198)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents ttVerificationSummaries As ToolTip
    Friend WithEvents ucrChkCorrelations As ucrCheck
End Class
