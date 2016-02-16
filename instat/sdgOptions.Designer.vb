<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgOptions
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
        Me.tbcOptions = New System.Windows.Forms.TabControl()
        Me.tbpDisplay = New System.Windows.Forms.TabPage()
        Me.tbpGraphics = New System.Windows.Forms.TabPage()
        Me.chkModel = New System.Windows.Forms.CheckBox()
        Me.chkANOVATable = New System.Windows.Forms.CheckBox()
        Me.chkANOVAPValues = New System.Windows.Forms.CheckBox()
        Me.chkEstimates = New System.Windows.Forms.CheckBox()
        Me.chkEstimateValues = New System.Windows.Forms.CheckBox()
        Me.chkTableOfMeans = New System.Windows.Forms.CheckBox()
        Me.lblConfidenceLevel = New System.Windows.Forms.Label()
        Me.nudConfidenceLevel = New System.Windows.Forms.NumericUpDown()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.chkResiduals = New System.Windows.Forms.CheckBox()
        Me.chkMeans = New System.Windows.Forms.CheckBox()
        Me.grpResiduals = New System.Windows.Forms.GroupBox()
        Me.grpModel = New System.Windows.Forms.GroupBox()
        Me.chkFourInOne = New System.Windows.Forms.CheckBox()
        Me.chkVsAdditionalVariable = New System.Windows.Forms.CheckBox()
        Me.chkFittedModel = New System.Windows.Forms.CheckBox()
        Me.chkConfidenceInterval = New System.Windows.Forms.CheckBox()
        Me.chkPredictedInterval = New System.Windows.Forms.CheckBox()
        Me.lblConfidenceLevel_ = New System.Windows.Forms.Label()
        Me.nudConfidenceLevel_ = New System.Windows.Forms.NumericUpDown()
        Me.tbcOptions.SuspendLayout()
        Me.tbpDisplay.SuspendLayout()
        Me.tbpGraphics.SuspendLayout()
        CType(Me.nudConfidenceLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpResiduals.SuspendLayout()
        Me.grpModel.SuspendLayout()
        CType(Me.nudConfidenceLevel_, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcOptions
        '
        Me.tbcOptions.Controls.Add(Me.tbpDisplay)
        Me.tbcOptions.Controls.Add(Me.tbpGraphics)
        Me.tbcOptions.Location = New System.Drawing.Point(-1, -1)
        Me.tbcOptions.Name = "tbcOptions"
        Me.tbcOptions.SelectedIndex = 0
        Me.tbcOptions.Size = New System.Drawing.Size(334, 280)
        Me.tbcOptions.TabIndex = 1
        '
        'tbpDisplay
        '
        Me.tbpDisplay.Controls.Add(Me.nudConfidenceLevel)
        Me.tbpDisplay.Controls.Add(Me.lblConfidenceLevel)
        Me.tbpDisplay.Controls.Add(Me.chkTableOfMeans)
        Me.tbpDisplay.Controls.Add(Me.chkEstimateValues)
        Me.tbpDisplay.Controls.Add(Me.chkEstimates)
        Me.tbpDisplay.Controls.Add(Me.chkANOVAPValues)
        Me.tbpDisplay.Controls.Add(Me.chkANOVATable)
        Me.tbpDisplay.Controls.Add(Me.chkModel)
        Me.tbpDisplay.Location = New System.Drawing.Point(4, 22)
        Me.tbpDisplay.Name = "tbpDisplay"
        Me.tbpDisplay.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDisplay.Size = New System.Drawing.Size(326, 198)
        Me.tbpDisplay.TabIndex = 0
        Me.tbpDisplay.Tag = "Display"
        Me.tbpDisplay.Text = "Display"
        Me.tbpDisplay.UseVisualStyleBackColor = True
        '
        'tbpGraphics
        '
        Me.tbpGraphics.Controls.Add(Me.grpModel)
        Me.tbpGraphics.Controls.Add(Me.grpResiduals)
        Me.tbpGraphics.Controls.Add(Me.chkMeans)
        Me.tbpGraphics.Controls.Add(Me.chkResiduals)
        Me.tbpGraphics.Location = New System.Drawing.Point(4, 22)
        Me.tbpGraphics.Name = "tbpGraphics"
        Me.tbpGraphics.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGraphics.Size = New System.Drawing.Size(326, 254)
        Me.tbpGraphics.TabIndex = 1
        Me.tbpGraphics.Tag = "Graphics"
        Me.tbpGraphics.Text = "Graphics"
        Me.tbpGraphics.UseVisualStyleBackColor = True
        '
        'chkModel
        '
        Me.chkModel.AutoSize = True
        Me.chkModel.Checked = True
        Me.chkModel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkModel.Location = New System.Drawing.Point(5, 7)
        Me.chkModel.Name = "chkModel"
        Me.chkModel.Size = New System.Drawing.Size(55, 17)
        Me.chkModel.TabIndex = 0
        Me.chkModel.Tag = "Model"
        Me.chkModel.Text = "Model"
        Me.chkModel.UseVisualStyleBackColor = True
        '
        'chkANOVATable
        '
        Me.chkANOVATable.AutoSize = True
        Me.chkANOVATable.Checked = True
        Me.chkANOVATable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkANOVATable.Location = New System.Drawing.Point(5, 33)
        Me.chkANOVATable.Name = "chkANOVATable"
        Me.chkANOVATable.Size = New System.Drawing.Size(93, 17)
        Me.chkANOVATable.TabIndex = 1
        Me.chkANOVATable.Tag = "ANOVA Table"
        Me.chkANOVATable.Text = "ANOVA Table"
        Me.chkANOVATable.UseVisualStyleBackColor = True
        '
        'chkANOVAPValues
        '
        Me.chkANOVAPValues.AutoSize = True
        Me.chkANOVAPValues.Location = New System.Drawing.Point(5, 59)
        Me.chkANOVAPValues.Name = "chkANOVAPValues"
        Me.chkANOVAPValues.Size = New System.Drawing.Size(107, 17)
        Me.chkANOVAPValues.TabIndex = 2
        Me.chkANOVAPValues.Tag = "ANOVA P-values"
        Me.chkANOVAPValues.Text = "ANOVA P-values"
        Me.chkANOVAPValues.UseVisualStyleBackColor = True
        '
        'chkEstimates
        '
        Me.chkEstimates.AutoSize = True
        Me.chkEstimates.Checked = True
        Me.chkEstimates.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEstimates.Location = New System.Drawing.Point(4, 85)
        Me.chkEstimates.Name = "chkEstimates"
        Me.chkEstimates.Size = New System.Drawing.Size(71, 17)
        Me.chkEstimates.TabIndex = 3
        Me.chkEstimates.Tag = "Estimates"
        Me.chkEstimates.Text = "Estimates"
        Me.chkEstimates.UseVisualStyleBackColor = True
        '
        'chkEstimateValues
        '
        Me.chkEstimateValues.AutoSize = True
        Me.chkEstimateValues.Checked = True
        Me.chkEstimateValues.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEstimateValues.Location = New System.Drawing.Point(4, 111)
        Me.chkEstimateValues.Name = "chkEstimateValues"
        Me.chkEstimateValues.Size = New System.Drawing.Size(110, 17)
        Me.chkEstimateValues.TabIndex = 4
        Me.chkEstimateValues.Tag = "Estimate_P_values"
        Me.chkEstimateValues.Text = "Estimate P values"
        Me.chkEstimateValues.UseVisualStyleBackColor = True
        '
        'chkTableOfMeans
        '
        Me.chkTableOfMeans.AutoSize = True
        Me.chkTableOfMeans.Location = New System.Drawing.Point(4, 137)
        Me.chkTableOfMeans.Name = "chkTableOfMeans"
        Me.chkTableOfMeans.Size = New System.Drawing.Size(99, 17)
        Me.chkTableOfMeans.TabIndex = 5
        Me.chkTableOfMeans.Tag = "Table_of_means"
        Me.chkTableOfMeans.Text = "Table of means"
        Me.chkTableOfMeans.UseVisualStyleBackColor = True
        '
        'lblConfidenceLevel
        '
        Me.lblConfidenceLevel.AutoSize = True
        Me.lblConfidenceLevel.Location = New System.Drawing.Point(2, 163)
        Me.lblConfidenceLevel.Name = "lblConfidenceLevel"
        Me.lblConfidenceLevel.Size = New System.Drawing.Size(86, 13)
        Me.lblConfidenceLevel.TabIndex = 6
        Me.lblConfidenceLevel.Tag = "Confidence_level"
        Me.lblConfidenceLevel.Text = "Confidence level"
        '
        'nudConfidenceLevel
        '
        Me.nudConfidenceLevel.Location = New System.Drawing.Point(95, 161)
        Me.nudConfidenceLevel.Name = "nudConfidenceLevel"
        Me.nudConfidenceLevel.Size = New System.Drawing.Size(44, 20)
        Me.nudConfidenceLevel.TabIndex = 7
        Me.nudConfidenceLevel.Value = New Decimal(New Integer() {95, 0, 0, 0})
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(32, 285)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(225, 30)
        Me.ucrBaseSubdialog.TabIndex = 0
        '
        'chkResiduals
        '
        Me.chkResiduals.AutoSize = True
        Me.chkResiduals.Location = New System.Drawing.Point(4, 7)
        Me.chkResiduals.Name = "chkResiduals"
        Me.chkResiduals.Size = New System.Drawing.Size(72, 17)
        Me.chkResiduals.TabIndex = 0
        Me.chkResiduals.Tag = "Residuals"
        Me.chkResiduals.Text = "Residuals"
        Me.chkResiduals.UseVisualStyleBackColor = True
        '
        'chkMeans
        '
        Me.chkMeans.AutoSize = True
        Me.chkMeans.Location = New System.Drawing.Point(4, 31)
        Me.chkMeans.Name = "chkMeans"
        Me.chkMeans.Size = New System.Drawing.Size(58, 17)
        Me.chkMeans.TabIndex = 1
        Me.chkMeans.Tag = "Means"
        Me.chkMeans.Text = "Means"
        Me.chkMeans.UseVisualStyleBackColor = True
        '
        'grpResiduals
        '
        Me.grpResiduals.Controls.Add(Me.chkVsAdditionalVariable)
        Me.grpResiduals.Controls.Add(Me.chkFourInOne)
        Me.grpResiduals.Location = New System.Drawing.Point(2, 51)
        Me.grpResiduals.Name = "grpResiduals"
        Me.grpResiduals.Size = New System.Drawing.Size(254, 66)
        Me.grpResiduals.TabIndex = 3
        Me.grpResiduals.TabStop = False
        Me.grpResiduals.Tag = "Residuals"
        Me.grpResiduals.Text = "Residuals"
        '
        'grpModel
        '
        Me.grpModel.Controls.Add(Me.nudConfidenceLevel_)
        Me.grpModel.Controls.Add(Me.lblConfidenceLevel_)
        Me.grpModel.Controls.Add(Me.chkPredictedInterval)
        Me.grpModel.Controls.Add(Me.chkConfidenceInterval)
        Me.grpModel.Controls.Add(Me.chkFittedModel)
        Me.grpModel.Location = New System.Drawing.Point(2, 126)
        Me.grpModel.Name = "grpModel"
        Me.grpModel.Size = New System.Drawing.Size(252, 110)
        Me.grpModel.TabIndex = 4
        Me.grpModel.TabStop = False
        Me.grpModel.Tag = "Model"
        Me.grpModel.Text = "Model"
        '
        'chkFourInOne
        '
        Me.chkFourInOne.AutoSize = True
        Me.chkFourInOne.Location = New System.Drawing.Point(2, 20)
        Me.chkFourInOne.Name = "chkFourInOne"
        Me.chkFourInOne.Size = New System.Drawing.Size(79, 17)
        Me.chkFourInOne.TabIndex = 0
        Me.chkFourInOne.Tag = "Four_in_one"
        Me.chkFourInOne.Text = "Four in one"
        Me.chkFourInOne.UseVisualStyleBackColor = True
        '
        'chkVsAdditionalVariable
        '
        Me.chkVsAdditionalVariable.AutoSize = True
        Me.chkVsAdditionalVariable.Location = New System.Drawing.Point(2, 44)
        Me.chkVsAdditionalVariable.Name = "chkVsAdditionalVariable"
        Me.chkVsAdditionalVariable.Size = New System.Drawing.Size(126, 17)
        Me.chkVsAdditionalVariable.TabIndex = 1
        Me.chkVsAdditionalVariable.Tag = "Vs additional variable"
        Me.chkVsAdditionalVariable.Text = "Vs additional variable"
        Me.chkVsAdditionalVariable.UseVisualStyleBackColor = True
        '
        'chkFittedModel
        '
        Me.chkFittedModel.AutoSize = True
        Me.chkFittedModel.Location = New System.Drawing.Point(2, 20)
        Me.chkFittedModel.Name = "chkFittedModel"
        Me.chkFittedModel.Size = New System.Drawing.Size(83, 17)
        Me.chkFittedModel.TabIndex = 0
        Me.chkFittedModel.Tag = "Fitted_model"
        Me.chkFittedModel.Text = "Fitted model"
        Me.chkFittedModel.UseVisualStyleBackColor = True
        '
        'chkConfidenceInterval
        '
        Me.chkConfidenceInterval.AutoSize = True
        Me.chkConfidenceInterval.Location = New System.Drawing.Point(2, 40)
        Me.chkConfidenceInterval.Name = "chkConfidenceInterval"
        Me.chkConfidenceInterval.Size = New System.Drawing.Size(117, 17)
        Me.chkConfidenceInterval.TabIndex = 1
        Me.chkConfidenceInterval.Tag = "Confidence_interval"
        Me.chkConfidenceInterval.Text = "Confidence interval"
        Me.chkConfidenceInterval.UseVisualStyleBackColor = True
        '
        'chkPredictedInterval
        '
        Me.chkPredictedInterval.AutoSize = True
        Me.chkPredictedInterval.Location = New System.Drawing.Point(3, 86)
        Me.chkPredictedInterval.Name = "chkPredictedInterval"
        Me.chkPredictedInterval.Size = New System.Drawing.Size(108, 17)
        Me.chkPredictedInterval.TabIndex = 2
        Me.chkPredictedInterval.Tag = "Predicted_interval"
        Me.chkPredictedInterval.Text = "Predicted interval"
        Me.chkPredictedInterval.UseVisualStyleBackColor = True
        '
        'lblConfidenceLevel_
        '
        Me.lblConfidenceLevel_.AutoSize = True
        Me.lblConfidenceLevel_.Location = New System.Drawing.Point(3, 64)
        Me.lblConfidenceLevel_.Name = "lblConfidenceLevel_"
        Me.lblConfidenceLevel_.Size = New System.Drawing.Size(86, 13)
        Me.lblConfidenceLevel_.TabIndex = 3
        Me.lblConfidenceLevel_.Tag = "Confidence_level"
        Me.lblConfidenceLevel_.Text = "Confidence level"
        '
        'nudConfidenceLevel_
        '
        Me.nudConfidenceLevel_.Location = New System.Drawing.Point(133, 62)
        Me.nudConfidenceLevel_.Name = "nudConfidenceLevel_"
        Me.nudConfidenceLevel_.Size = New System.Drawing.Size(41, 20)
        Me.nudConfidenceLevel_.TabIndex = 4
        Me.nudConfidenceLevel_.Value = New Decimal(New Integer() {95, 0, 0, 0})
        '
        'sdgOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 316)
        Me.Controls.Add(Me.tbcOptions)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgOptions"
        Me.Tag = "Options"
        Me.Text = "Options"
        Me.tbcOptions.ResumeLayout(False)
        Me.tbpDisplay.ResumeLayout(False)
        Me.tbpDisplay.PerformLayout()
        Me.tbpGraphics.ResumeLayout(False)
        Me.tbpGraphics.PerformLayout()
        CType(Me.nudConfidenceLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpResiduals.ResumeLayout(False)
        Me.grpResiduals.PerformLayout()
        Me.grpModel.ResumeLayout(False)
        Me.grpModel.PerformLayout()
        CType(Me.nudConfidenceLevel_, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents tbcOptions As TabControl
    Friend WithEvents tbpDisplay As TabPage
    Friend WithEvents lblConfidenceLevel As Label
    Friend WithEvents chkTableOfMeans As CheckBox
    Friend WithEvents chkEstimateValues As CheckBox
    Friend WithEvents chkEstimates As CheckBox
    Friend WithEvents chkANOVAPValues As CheckBox
    Friend WithEvents chkANOVATable As CheckBox
    Friend WithEvents chkModel As CheckBox
    Friend WithEvents tbpGraphics As TabPage
    Friend WithEvents nudConfidenceLevel As NumericUpDown
    Friend WithEvents grpModel As GroupBox
    Friend WithEvents nudConfidenceLevel_ As NumericUpDown
    Friend WithEvents lblConfidenceLevel_ As Label
    Friend WithEvents chkPredictedInterval As CheckBox
    Friend WithEvents chkConfidenceInterval As CheckBox
    Friend WithEvents chkFittedModel As CheckBox
    Friend WithEvents grpResiduals As GroupBox
    Friend WithEvents chkVsAdditionalVariable As CheckBox
    Friend WithEvents chkFourInOne As CheckBox
    Friend WithEvents chkMeans As CheckBox
    Friend WithEvents chkResiduals As CheckBox
End Class
