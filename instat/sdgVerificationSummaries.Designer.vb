<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgVerificationSummaries
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
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.tbSummaries = New System.Windows.Forms.TabControl()
        Me.tbContinuous = New System.Windows.Forms.TabPage()
        Me.ucrContinuousVerification = New instat.ucrContinuousVerification()
        Me.tbBinary = New System.Windows.Forms.TabPage()
        Me.grpOrdinary = New System.Windows.Forms.GroupBox()
        Me.ucrChkHitRate = New instat.ucrCheck()
        Me.ucrChkFalseAlarmRatio = New instat.ucrCheck()
        Me.ucrChkBias = New instat.ucrCheck()
        Me.ucrChkHeidkeSkillScore = New instat.ucrCheck()
        Me.ucrChkEquitableThreatScore = New instat.ucrCheck()
        Me.ucrChkPercentCorrect = New instat.ucrCheck()
        Me.ucrChkThreatScore = New instat.ucrCheck()
        Me.grpExtreme = New System.Windows.Forms.GroupBox()
        Me.ucrChkSymmetricExtremeDependencyScore = New instat.ucrCheck()
        Me.ucrChkExremalDependencyIndex = New instat.ucrCheck()
        Me.ucrChkExtremeDependencyScore = New instat.ucrCheck()
        Me.ucrChkSymmetricExtremalDependenceIndex = New instat.ucrCheck()
        Me.tbCategorical = New System.Windows.Forms.TabPage()
        Me.ucrChkCatPercentCorrect = New instat.ucrCheck()
        Me.ucrChkCatHeidkeSkillScore = New instat.ucrCheck()
        Me.ucrChkCatPierceSkillScore = New instat.ucrCheck()
        Me.ucrChkGerrityScore = New instat.ucrCheck()
        Me.tbSummaries.SuspendLayout()
        Me.tbContinuous.SuspendLayout()
        Me.tbBinary.SuspendLayout()
        Me.grpOrdinary.SuspendLayout()
        Me.grpExtreme.SuspendLayout()
        Me.tbCategorical.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.Location = New System.Drawing.Point(212, 268)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(224, 30)
        Me.ucrBase.TabIndex = 1
        '
        'tbSummaries
        '
        Me.tbSummaries.Controls.Add(Me.tbContinuous)
        Me.tbSummaries.Controls.Add(Me.tbBinary)
        Me.tbSummaries.Controls.Add(Me.tbCategorical)
        Me.tbSummaries.Location = New System.Drawing.Point(12, 12)
        Me.tbSummaries.Name = "tbSummaries"
        Me.tbSummaries.SelectedIndex = 0
        Me.tbSummaries.Size = New System.Drawing.Size(557, 255)
        Me.tbSummaries.TabIndex = 0
        '
        'tbContinuous
        '
        Me.tbContinuous.Controls.Add(Me.ucrContinuousVerification)
        Me.tbContinuous.Location = New System.Drawing.Point(4, 22)
        Me.tbContinuous.Name = "tbContinuous"
        Me.tbContinuous.Padding = New System.Windows.Forms.Padding(3)
        Me.tbContinuous.Size = New System.Drawing.Size(549, 229)
        Me.tbContinuous.TabIndex = 0
        Me.tbContinuous.Text = "Continuous"
        Me.tbContinuous.UseVisualStyleBackColor = True
        '
        'ucrContinuousVerification
        '
        Me.ucrContinuousVerification.AutoSize = True
        Me.ucrContinuousVerification.Location = New System.Drawing.Point(-1, 6)
        Me.ucrContinuousVerification.Name = "ucrContinuousVerification"
        Me.ucrContinuousVerification.Size = New System.Drawing.Size(569, 196)
        Me.ucrContinuousVerification.TabIndex = 0
        '
        'tbBinary
        '
        Me.tbBinary.Controls.Add(Me.grpOrdinary)
        Me.tbBinary.Controls.Add(Me.grpExtreme)
        Me.tbBinary.Location = New System.Drawing.Point(4, 22)
        Me.tbBinary.Name = "tbBinary"
        Me.tbBinary.Padding = New System.Windows.Forms.Padding(3)
        Me.tbBinary.Size = New System.Drawing.Size(549, 229)
        Me.tbBinary.TabIndex = 1
        Me.tbBinary.Text = "Binary"
        Me.tbBinary.UseVisualStyleBackColor = True
        '
        'grpOrdinary
        '
        Me.grpOrdinary.Controls.Add(Me.ucrChkHitRate)
        Me.grpOrdinary.Controls.Add(Me.ucrChkFalseAlarmRatio)
        Me.grpOrdinary.Controls.Add(Me.ucrChkBias)
        Me.grpOrdinary.Controls.Add(Me.ucrChkHeidkeSkillScore)
        Me.grpOrdinary.Controls.Add(Me.ucrChkEquitableThreatScore)
        Me.grpOrdinary.Controls.Add(Me.ucrChkPercentCorrect)
        Me.grpOrdinary.Controls.Add(Me.ucrChkThreatScore)
        Me.grpOrdinary.Location = New System.Drawing.Point(6, 6)
        Me.grpOrdinary.Name = "grpOrdinary"
        Me.grpOrdinary.Size = New System.Drawing.Size(537, 104)
        Me.grpOrdinary.TabIndex = 13
        Me.grpOrdinary.TabStop = False
        Me.grpOrdinary.Text = "Ordinary"
        '
        'ucrChkHitRate
        '
        Me.ucrChkHitRate.AutoSize = True
        Me.ucrChkHitRate.Checked = False
        Me.ucrChkHitRate.Location = New System.Drawing.Point(6, 19)
        Me.ucrChkHitRate.Name = "ucrChkHitRate"
        Me.ucrChkHitRate.Size = New System.Drawing.Size(136, 23)
        Me.ucrChkHitRate.TabIndex = 4
        '
        'ucrChkFalseAlarmRatio
        '
        Me.ucrChkFalseAlarmRatio.AutoSize = True
        Me.ucrChkFalseAlarmRatio.Checked = False
        Me.ucrChkFalseAlarmRatio.Location = New System.Drawing.Point(6, 79)
        Me.ucrChkFalseAlarmRatio.Name = "ucrChkFalseAlarmRatio"
        Me.ucrChkFalseAlarmRatio.Size = New System.Drawing.Size(118, 23)
        Me.ucrChkFalseAlarmRatio.TabIndex = 1
        '
        'ucrChkBias
        '
        Me.ucrChkBias.AutoSize = True
        Me.ucrChkBias.Checked = False
        Me.ucrChkBias.Location = New System.Drawing.Point(185, 59)
        Me.ucrChkBias.Name = "ucrChkBias"
        Me.ucrChkBias.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkBias.TabIndex = 6
        '
        'ucrChkHeidkeSkillScore
        '
        Me.ucrChkHeidkeSkillScore.AutoSize = True
        Me.ucrChkHeidkeSkillScore.Checked = False
        Me.ucrChkHeidkeSkillScore.Location = New System.Drawing.Point(185, 19)
        Me.ucrChkHeidkeSkillScore.Name = "ucrChkHeidkeSkillScore"
        Me.ucrChkHeidkeSkillScore.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkHeidkeSkillScore.TabIndex = 8
        '
        'ucrChkEquitableThreatScore
        '
        Me.ucrChkEquitableThreatScore.AutoSize = True
        Me.ucrChkEquitableThreatScore.Checked = False
        Me.ucrChkEquitableThreatScore.Location = New System.Drawing.Point(6, 59)
        Me.ucrChkEquitableThreatScore.Name = "ucrChkEquitableThreatScore"
        Me.ucrChkEquitableThreatScore.Size = New System.Drawing.Size(136, 23)
        Me.ucrChkEquitableThreatScore.TabIndex = 2
        '
        'ucrChkPercentCorrect
        '
        Me.ucrChkPercentCorrect.AutoSize = True
        Me.ucrChkPercentCorrect.Checked = False
        Me.ucrChkPercentCorrect.Location = New System.Drawing.Point(185, 39)
        Me.ucrChkPercentCorrect.Name = "ucrChkPercentCorrect"
        Me.ucrChkPercentCorrect.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkPercentCorrect.TabIndex = 7
        '
        'ucrChkThreatScore
        '
        Me.ucrChkThreatScore.AutoSize = True
        Me.ucrChkThreatScore.Checked = False
        Me.ucrChkThreatScore.Location = New System.Drawing.Point(6, 39)
        Me.ucrChkThreatScore.Name = "ucrChkThreatScore"
        Me.ucrChkThreatScore.Size = New System.Drawing.Size(136, 23)
        Me.ucrChkThreatScore.TabIndex = 3
        '
        'grpExtreme
        '
        Me.grpExtreme.Controls.Add(Me.ucrChkSymmetricExtremeDependencyScore)
        Me.grpExtreme.Controls.Add(Me.ucrChkExremalDependencyIndex)
        Me.grpExtreme.Controls.Add(Me.ucrChkExtremeDependencyScore)
        Me.grpExtreme.Controls.Add(Me.ucrChkSymmetricExtremalDependenceIndex)
        Me.grpExtreme.Location = New System.Drawing.Point(6, 109)
        Me.grpExtreme.Name = "grpExtreme"
        Me.grpExtreme.Size = New System.Drawing.Size(537, 71)
        Me.grpExtreme.TabIndex = 12
        Me.grpExtreme.TabStop = False
        Me.grpExtreme.Text = "Extreme"
        '
        'ucrChkSymmetricExtremeDependencyScore
        '
        Me.ucrChkSymmetricExtremeDependencyScore.AutoSize = True
        Me.ucrChkSymmetricExtremeDependencyScore.Checked = False
        Me.ucrChkSymmetricExtremeDependencyScore.Location = New System.Drawing.Point(6, 19)
        Me.ucrChkSymmetricExtremeDependencyScore.Name = "ucrChkSymmetricExtremeDependencyScore"
        Me.ucrChkSymmetricExtremeDependencyScore.Size = New System.Drawing.Size(171, 23)
        Me.ucrChkSymmetricExtremeDependencyScore.TabIndex = 10
        '
        'ucrChkExremalDependencyIndex
        '
        Me.ucrChkExremalDependencyIndex.AutoSize = True
        Me.ucrChkExremalDependencyIndex.Checked = False
        Me.ucrChkExremalDependencyIndex.Location = New System.Drawing.Point(185, 45)
        Me.ucrChkExremalDependencyIndex.Name = "ucrChkExremalDependencyIndex"
        Me.ucrChkExremalDependencyIndex.Size = New System.Drawing.Size(181, 23)
        Me.ucrChkExremalDependencyIndex.TabIndex = 9
        '
        'ucrChkExtremeDependencyScore
        '
        Me.ucrChkExtremeDependencyScore.AutoSize = True
        Me.ucrChkExtremeDependencyScore.Checked = False
        Me.ucrChkExtremeDependencyScore.Location = New System.Drawing.Point(6, 45)
        Me.ucrChkExtremeDependencyScore.Name = "ucrChkExtremeDependencyScore"
        Me.ucrChkExtremeDependencyScore.Size = New System.Drawing.Size(171, 23)
        Me.ucrChkExtremeDependencyScore.TabIndex = 11
        '
        'ucrChkSymmetricExtremalDependenceIndex
        '
        Me.ucrChkSymmetricExtremalDependenceIndex.AutoSize = True
        Me.ucrChkSymmetricExtremalDependenceIndex.Checked = False
        Me.ucrChkSymmetricExtremalDependenceIndex.Location = New System.Drawing.Point(185, 19)
        Me.ucrChkSymmetricExtremalDependenceIndex.Name = "ucrChkSymmetricExtremalDependenceIndex"
        Me.ucrChkSymmetricExtremalDependenceIndex.Size = New System.Drawing.Size(179, 23)
        Me.ucrChkSymmetricExtremalDependenceIndex.TabIndex = 5
        '
        'tbCategorical
        '
        Me.tbCategorical.Controls.Add(Me.ucrChkCatPercentCorrect)
        Me.tbCategorical.Controls.Add(Me.ucrChkCatHeidkeSkillScore)
        Me.tbCategorical.Controls.Add(Me.ucrChkCatPierceSkillScore)
        Me.tbCategorical.Controls.Add(Me.ucrChkGerrityScore)
        Me.tbCategorical.Location = New System.Drawing.Point(4, 22)
        Me.tbCategorical.Name = "tbCategorical"
        Me.tbCategorical.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCategorical.Size = New System.Drawing.Size(549, 229)
        Me.tbCategorical.TabIndex = 2
        Me.tbCategorical.Text = "Categorical"
        Me.tbCategorical.UseVisualStyleBackColor = True
        '
        'ucrChkCatPercentCorrect
        '
        Me.ucrChkCatPercentCorrect.AutoSize = True
        Me.ucrChkCatPercentCorrect.Checked = False
        Me.ucrChkCatPercentCorrect.Location = New System.Drawing.Point(14, 18)
        Me.ucrChkCatPercentCorrect.Name = "ucrChkCatPercentCorrect"
        Me.ucrChkCatPercentCorrect.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkCatPercentCorrect.TabIndex = 4
        '
        'ucrChkCatHeidkeSkillScore
        '
        Me.ucrChkCatHeidkeSkillScore.AutoSize = True
        Me.ucrChkCatHeidkeSkillScore.Checked = False
        Me.ucrChkCatHeidkeSkillScore.Location = New System.Drawing.Point(14, 40)
        Me.ucrChkCatHeidkeSkillScore.Name = "ucrChkCatHeidkeSkillScore"
        Me.ucrChkCatHeidkeSkillScore.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkCatHeidkeSkillScore.TabIndex = 3
        '
        'ucrChkCatPierceSkillScore
        '
        Me.ucrChkCatPierceSkillScore.AutoSize = True
        Me.ucrChkCatPierceSkillScore.Checked = False
        Me.ucrChkCatPierceSkillScore.Location = New System.Drawing.Point(135, 18)
        Me.ucrChkCatPierceSkillScore.Name = "ucrChkCatPierceSkillScore"
        Me.ucrChkCatPierceSkillScore.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkCatPierceSkillScore.TabIndex = 2
        '
        'ucrChkGerrityScore
        '
        Me.ucrChkGerrityScore.AutoSize = True
        Me.ucrChkGerrityScore.Checked = False
        Me.ucrChkGerrityScore.Location = New System.Drawing.Point(135, 42)
        Me.ucrChkGerrityScore.Name = "ucrChkGerrityScore"
        Me.ucrChkGerrityScore.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkGerrityScore.TabIndex = 1
        '
        'sdgVerificationSummaries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(578, 300)
        Me.Controls.Add(Me.tbSummaries)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgVerificationSummaries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summaries"
        Me.tbSummaries.ResumeLayout(False)
        Me.tbContinuous.ResumeLayout(False)
        Me.tbContinuous.PerformLayout()
        Me.tbBinary.ResumeLayout(False)
        Me.grpOrdinary.ResumeLayout(False)
        Me.grpOrdinary.PerformLayout()
        Me.grpExtreme.ResumeLayout(False)
        Me.grpExtreme.PerformLayout()
        Me.tbCategorical.ResumeLayout(False)
        Me.tbCategorical.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents tbSummaries As TabControl
    Friend WithEvents tbContinuous As TabPage
    Friend WithEvents tbBinary As TabPage
    Friend WithEvents tbCategorical As TabPage
    Friend WithEvents ucrChkHitRate As ucrCheck
    Friend WithEvents ucrChkThreatScore As ucrCheck
    Friend WithEvents ucrChkEquitableThreatScore As ucrCheck
    Friend WithEvents ucrChkFalseAlarmRatio As ucrCheck
    Friend WithEvents ucrChkCatPercentCorrect As ucrCheck
    Friend WithEvents ucrChkCatHeidkeSkillScore As ucrCheck
    Friend WithEvents ucrChkCatPierceSkillScore As ucrCheck
    Friend WithEvents ucrChkGerrityScore As ucrCheck
    Friend WithEvents ucrContinuousVerification As ucrContinuousVerification
    Friend WithEvents ucrChkHeidkeSkillScore As ucrCheck
    Friend WithEvents ucrChkPercentCorrect As ucrCheck
    Friend WithEvents ucrChkBias As ucrCheck
    Friend WithEvents ucrChkSymmetricExtremalDependenceIndex As ucrCheck
    Friend WithEvents ucrChkExtremeDependencyScore As ucrCheck
    Friend WithEvents ucrChkSymmetricExtremeDependencyScore As ucrCheck
    Friend WithEvents ucrChkExremalDependencyIndex As ucrCheck
    Friend WithEvents grpExtreme As GroupBox
    Friend WithEvents grpOrdinary As GroupBox
End Class
