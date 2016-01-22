<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgExtremes
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
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverDataToFit = New instat.ucrReceiverSingle()
        Me.lblDataToFit = New System.Windows.Forms.Label()
        Me.grpDistributions = New System.Windows.Forms.GroupBox()
        Me.rdoGEV = New System.Windows.Forms.RadioButton()
        Me.rdoGumbel = New System.Windows.Forms.RadioButton()
        Me.grpEstimationMethods = New System.Windows.Forms.GroupBox()
        Me.cboMethodOfMoments = New System.Windows.Forms.ComboBox()
        Me.cboMaximumLikelihood = New System.Windows.Forms.ComboBox()
        Me.lblSaveEstimates = New System.Windows.Forms.Label()
        Me.chkMethodOfMoments = New System.Windows.Forms.CheckBox()
        Me.chkMaximumLikelihood = New System.Windows.Forms.CheckBox()
        Me.chkRestrictValues = New System.Windows.Forms.CheckBox()
        Me.lblBetween = New System.Windows.Forms.Label()
        Me.txtBetween = New System.Windows.Forms.TextBox()
        Me.lblAnd = New System.Windows.Forms.Label()
        Me.txtAnd = New System.Windows.Forms.TextBox()
        Me.chkProbabilityPlot = New System.Windows.Forms.CheckBox()
        Me.grpDistributions.SuspendLayout()
        Me.grpEstimationMethods.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(21, 261)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 51)
        Me.ucrBase.TabIndex = 0
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(12, 12)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(206, 127)
        Me.ucrAddRemove.TabIndex = 1
        '
        'ucrReceiverDataToFit
        '
        Me.ucrReceiverDataToFit.Location = New System.Drawing.Point(224, 28)
        Me.ucrReceiverDataToFit.Name = "ucrReceiverDataToFit"
        Me.ucrReceiverDataToFit.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverDataToFit.TabIndex = 2
        '
        'lblDataToFit
        '
        Me.lblDataToFit.AutoSize = True
        Me.lblDataToFit.Location = New System.Drawing.Point(231, 12)
        Me.lblDataToFit.Name = "lblDataToFit"
        Me.lblDataToFit.Size = New System.Drawing.Size(83, 13)
        Me.lblDataToFit.TabIndex = 3
        Me.lblDataToFit.Tag = "Data_to_be_fitted"
        Me.lblDataToFit.Text = "Data to be fitted"
        '
        'grpDistributions
        '
        Me.grpDistributions.Controls.Add(Me.rdoGEV)
        Me.grpDistributions.Controls.Add(Me.rdoGumbel)
        Me.grpDistributions.Location = New System.Drawing.Point(338, 12)
        Me.grpDistributions.Name = "grpDistributions"
        Me.grpDistributions.Size = New System.Drawing.Size(104, 95)
        Me.grpDistributions.TabIndex = 4
        Me.grpDistributions.TabStop = False
        Me.grpDistributions.Tag = "Distributions"
        Me.grpDistributions.Text = "Distributions"
        '
        'rdoGEV
        '
        Me.rdoGEV.AutoSize = True
        Me.rdoGEV.Location = New System.Drawing.Point(7, 57)
        Me.rdoGEV.Name = "rdoGEV"
        Me.rdoGEV.Size = New System.Drawing.Size(47, 17)
        Me.rdoGEV.TabIndex = 1
        Me.rdoGEV.TabStop = True
        Me.rdoGEV.Tag = "GEV"
        Me.rdoGEV.Text = "GEV"
        Me.rdoGEV.UseVisualStyleBackColor = True
        '
        'rdoGumbel
        '
        Me.rdoGumbel.AutoSize = True
        Me.rdoGumbel.Location = New System.Drawing.Point(7, 24)
        Me.rdoGumbel.Name = "rdoGumbel"
        Me.rdoGumbel.Size = New System.Drawing.Size(61, 17)
        Me.rdoGumbel.TabIndex = 0
        Me.rdoGumbel.TabStop = True
        Me.rdoGumbel.Tag = "Gumbel"
        Me.rdoGumbel.Text = "Gumbel"
        Me.rdoGumbel.UseVisualStyleBackColor = True
        '
        'grpEstimationMethods
        '
        Me.grpEstimationMethods.Controls.Add(Me.cboMethodOfMoments)
        Me.grpEstimationMethods.Controls.Add(Me.cboMaximumLikelihood)
        Me.grpEstimationMethods.Controls.Add(Me.lblSaveEstimates)
        Me.grpEstimationMethods.Controls.Add(Me.chkMethodOfMoments)
        Me.grpEstimationMethods.Controls.Add(Me.chkMaximumLikelihood)
        Me.grpEstimationMethods.Location = New System.Drawing.Point(21, 154)
        Me.grpEstimationMethods.Name = "grpEstimationMethods"
        Me.grpEstimationMethods.Size = New System.Drawing.Size(241, 91)
        Me.grpEstimationMethods.TabIndex = 6
        Me.grpEstimationMethods.TabStop = False
        Me.grpEstimationMethods.Tag = "Estimation_methods"
        Me.grpEstimationMethods.Text = "Estimation methods"
        '
        'cboMethodOfMoments
        '
        Me.cboMethodOfMoments.FormattingEnabled = True
        Me.cboMethodOfMoments.Location = New System.Drawing.Point(147, 65)
        Me.cboMethodOfMoments.Name = "cboMethodOfMoments"
        Me.cboMethodOfMoments.Size = New System.Drawing.Size(84, 21)
        Me.cboMethodOfMoments.TabIndex = 4
        '
        'cboMaximumLikelihood
        '
        Me.cboMaximumLikelihood.FormattingEnabled = True
        Me.cboMaximumLikelihood.Location = New System.Drawing.Point(147, 32)
        Me.cboMaximumLikelihood.Name = "cboMaximumLikelihood"
        Me.cboMaximumLikelihood.Size = New System.Drawing.Size(84, 21)
        Me.cboMaximumLikelihood.TabIndex = 3
        '
        'lblSaveEstimates
        '
        Me.lblSaveEstimates.AutoSize = True
        Me.lblSaveEstimates.Location = New System.Drawing.Point(144, 16)
        Me.lblSaveEstimates.Name = "lblSaveEstimates"
        Me.lblSaveEstimates.Size = New System.Drawing.Size(90, 13)
        Me.lblSaveEstimates.TabIndex = 2
        Me.lblSaveEstimates.Tag = "Save_estimates_in"
        Me.lblSaveEstimates.Text = "Save estimates in"
        '
        'chkMethodOfMoments
        '
        Me.chkMethodOfMoments.AutoSize = True
        Me.chkMethodOfMoments.Location = New System.Drawing.Point(6, 67)
        Me.chkMethodOfMoments.Name = "chkMethodOfMoments"
        Me.chkMethodOfMoments.Size = New System.Drawing.Size(119, 17)
        Me.chkMethodOfMoments.TabIndex = 1
        Me.chkMethodOfMoments.Tag = "Method_of_moments"
        Me.chkMethodOfMoments.Text = "Method of moments"
        Me.chkMethodOfMoments.UseVisualStyleBackColor = True
        '
        'chkMaximumLikelihood
        '
        Me.chkMaximumLikelihood.AutoSize = True
        Me.chkMaximumLikelihood.Location = New System.Drawing.Point(6, 34)
        Me.chkMaximumLikelihood.Name = "chkMaximumLikelihood"
        Me.chkMaximumLikelihood.Size = New System.Drawing.Size(117, 17)
        Me.chkMaximumLikelihood.TabIndex = 0
        Me.chkMaximumLikelihood.Tag = "Maximum_likelihood_"
        Me.chkMaximumLikelihood.Text = "Maximum likelihood"
        Me.chkMaximumLikelihood.UseVisualStyleBackColor = True
        '
        'chkRestrictValues
        '
        Me.chkRestrictValues.AutoSize = True
        Me.chkRestrictValues.Location = New System.Drawing.Point(287, 122)
        Me.chkRestrictValues.Name = "chkRestrictValues"
        Me.chkRestrictValues.Size = New System.Drawing.Size(120, 17)
        Me.chkRestrictValues.TabIndex = 7
        Me.chkRestrictValues.Tag = "Restrict_data_values"
        Me.chkRestrictValues.Text = "Restrict data values"
        Me.chkRestrictValues.UseVisualStyleBackColor = True
        '
        'lblBetween
        '
        Me.lblBetween.AutoSize = True
        Me.lblBetween.Location = New System.Drawing.Point(284, 154)
        Me.lblBetween.Name = "lblBetween"
        Me.lblBetween.Size = New System.Drawing.Size(48, 13)
        Me.lblBetween.TabIndex = 8
        Me.lblBetween.Tag = "between"
        Me.lblBetween.Text = "between"
        '
        'txtBetween
        '
        Me.txtBetween.Location = New System.Drawing.Point(338, 151)
        Me.txtBetween.Name = "txtBetween"
        Me.txtBetween.Size = New System.Drawing.Size(33, 20)
        Me.txtBetween.TabIndex = 10
        '
        'lblAnd
        '
        Me.lblAnd.AutoSize = True
        Me.lblAnd.Location = New System.Drawing.Point(377, 151)
        Me.lblAnd.Name = "lblAnd"
        Me.lblAnd.Size = New System.Drawing.Size(25, 13)
        Me.lblAnd.TabIndex = 11
        Me.lblAnd.Tag = "and"
        Me.lblAnd.Text = "and"
        '
        'txtAnd
        '
        Me.txtAnd.Location = New System.Drawing.Point(408, 147)
        Me.txtAnd.Name = "txtAnd"
        Me.txtAnd.Size = New System.Drawing.Size(35, 20)
        Me.txtAnd.TabIndex = 12
        '
        'chkProbabilityPlot
        '
        Me.chkProbabilityPlot.AutoSize = True
        Me.chkProbabilityPlot.Location = New System.Drawing.Point(287, 223)
        Me.chkProbabilityPlot.Name = "chkProbabilityPlot"
        Me.chkProbabilityPlot.Size = New System.Drawing.Size(94, 17)
        Me.chkProbabilityPlot.TabIndex = 13
        Me.chkProbabilityPlot.Tag = "Probability_plot"
        Me.chkProbabilityPlot.Text = "Probability plot"
        Me.chkProbabilityPlot.UseVisualStyleBackColor = True
        '
        'dlgExtremes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 315)
        Me.Controls.Add(Me.chkProbabilityPlot)
        Me.Controls.Add(Me.txtAnd)
        Me.Controls.Add(Me.lblAnd)
        Me.Controls.Add(Me.txtBetween)
        Me.Controls.Add(Me.lblBetween)
        Me.Controls.Add(Me.chkRestrictValues)
        Me.Controls.Add(Me.grpEstimationMethods)
        Me.Controls.Add(Me.grpDistributions)
        Me.Controls.Add(Me.lblDataToFit)
        Me.Controls.Add(Me.ucrReceiverDataToFit)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgExtremes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Fit_an_Extreme_distribution"
        Me.Text = "Fit an Extreme distribution"
        Me.grpDistributions.ResumeLayout(False)
        Me.grpDistributions.PerformLayout()
        Me.grpEstimationMethods.ResumeLayout(False)
        Me.grpEstimationMethods.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverDataToFit As ucrReceiverSingle
    Friend WithEvents lblDataToFit As Label
    Friend WithEvents grpDistributions As GroupBox
    Friend WithEvents rdoGEV As RadioButton
    Friend WithEvents rdoGumbel As RadioButton
    Friend WithEvents grpEstimationMethods As GroupBox
    Friend WithEvents cboMethodOfMoments As ComboBox
    Friend WithEvents cboMaximumLikelihood As ComboBox
    Friend WithEvents lblSaveEstimates As Label
    Friend WithEvents chkMethodOfMoments As CheckBox
    Friend WithEvents chkMaximumLikelihood As CheckBox
    Friend WithEvents chkRestrictValues As CheckBox
    Friend WithEvents lblBetween As Label
    Friend WithEvents txtBetween As TextBox
    Friend WithEvents lblAnd As Label
    Friend WithEvents txtAnd As TextBox
    Friend WithEvents chkProbabilityPlot As CheckBox
End Class
