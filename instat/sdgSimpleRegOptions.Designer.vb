<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgSimpleRegOptions
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
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.tbRegOptions = New System.Windows.Forms.TabControl()
        Me.tbDisplay = New System.Windows.Forms.TabPage()
        Me.nudConfidenceInteval = New System.Windows.Forms.NumericUpDown()
        Me.lblConfidenceInterval = New System.Windows.Forms.Label()
        Me.chkEstimatesPvalues = New System.Windows.Forms.CheckBox()
        Me.chkEstimates = New System.Windows.Forms.CheckBox()
        Me.chkAnovaPvalues = New System.Windows.Forms.CheckBox()
        Me.chkAnovaTable = New System.Windows.Forms.CheckBox()
        Me.chkModel = New System.Windows.Forms.CheckBox()
        Me.tbGraphics = New System.Windows.Forms.TabPage()
        Me.grpModel = New System.Windows.Forms.GroupBox()
        Me.chkFittedModel = New System.Windows.Forms.CheckBox()
        Me.chkPredictionInterval = New System.Windows.Forms.CheckBox()
        Me.nudConvidenceLevel = New System.Windows.Forms.NumericUpDown()
        Me.lblConfidenceLevel = New System.Windows.Forms.Label()
        Me.chkConfidenceInterval = New System.Windows.Forms.CheckBox()
        Me.grpResiduals = New System.Windows.Forms.GroupBox()
        Me.chkFourinOne = New System.Windows.Forms.CheckBox()
        Me.chkAddionalVariable = New System.Windows.Forms.CheckBox()
        Me.tbRegOptions.SuspendLayout()
        Me.tbDisplay.SuspendLayout()
        CType(Me.nudConfidenceInteval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbGraphics.SuspendLayout()
        Me.grpModel.SuspendLayout()
        CType(Me.nudConvidenceLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpResiduals.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.Location = New System.Drawing.Point(41, 226)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(142, 30)
        Me.ucrSdgButtons.TabIndex = 0
        '
        'tbRegOptions
        '
        Me.tbRegOptions.Controls.Add(Me.tbDisplay)
        Me.tbRegOptions.Controls.Add(Me.tbGraphics)
        Me.tbRegOptions.Location = New System.Drawing.Point(2, 3)
        Me.tbRegOptions.Name = "tbRegOptions"
        Me.tbRegOptions.SelectedIndex = 0
        Me.tbRegOptions.Size = New System.Drawing.Size(251, 221)
        Me.tbRegOptions.TabIndex = 0
        '
        'tbDisplay
        '
        Me.tbDisplay.Controls.Add(Me.nudConfidenceInteval)
        Me.tbDisplay.Controls.Add(Me.lblConfidenceInterval)
        Me.tbDisplay.Controls.Add(Me.chkEstimatesPvalues)
        Me.tbDisplay.Controls.Add(Me.chkEstimates)
        Me.tbDisplay.Controls.Add(Me.chkAnovaPvalues)
        Me.tbDisplay.Controls.Add(Me.chkAnovaTable)
        Me.tbDisplay.Controls.Add(Me.chkModel)
        Me.tbDisplay.Location = New System.Drawing.Point(4, 22)
        Me.tbDisplay.Name = "tbDisplay"
        Me.tbDisplay.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDisplay.Size = New System.Drawing.Size(243, 195)
        Me.tbDisplay.TabIndex = 0
        Me.tbDisplay.Tag = "Display"
        Me.tbDisplay.Text = "Display"
        Me.tbDisplay.UseVisualStyleBackColor = True
        '
        'nudConfidenceInteval
        '
        Me.nudConfidenceInteval.Location = New System.Drawing.Point(118, 106)
        Me.nudConfidenceInteval.Name = "nudConfidenceInteval"
        Me.nudConfidenceInteval.Size = New System.Drawing.Size(39, 20)
        Me.nudConfidenceInteval.TabIndex = 6
        Me.nudConfidenceInteval.Value = New Decimal(New Integer() {95, 0, 0, 0})
        '
        'lblConfidenceInterval
        '
        Me.lblConfidenceInterval.AutoSize = True
        Me.lblConfidenceInterval.Location = New System.Drawing.Point(3, 108)
        Me.lblConfidenceInterval.Name = "lblConfidenceInterval"
        Me.lblConfidenceInterval.Size = New System.Drawing.Size(99, 13)
        Me.lblConfidenceInterval.TabIndex = 5
        Me.lblConfidenceInterval.Tag = "Confidence_Interval"
        Me.lblConfidenceInterval.Text = "Confidence Interval"
        '
        'chkEstimatesPvalues
        '
        Me.chkEstimatesPvalues.AutoSize = True
        Me.chkEstimatesPvalues.Location = New System.Drawing.Point(134, 60)
        Me.chkEstimatesPvalues.Name = "chkEstimatesPvalues"
        Me.chkEstimatesPvalues.Size = New System.Drawing.Size(115, 17)
        Me.chkEstimatesPvalues.TabIndex = 4
        Me.chkEstimatesPvalues.Tag = "Estimates_P_values"
        Me.chkEstimatesPvalues.Text = "Estimates P-values"
        Me.chkEstimatesPvalues.ThreeState = True
        Me.chkEstimatesPvalues.UseVisualStyleBackColor = True
        '
        'chkEstimates
        '
        Me.chkEstimates.AutoSize = True
        Me.chkEstimates.Location = New System.Drawing.Point(134, 21)
        Me.chkEstimates.Name = "chkEstimates"
        Me.chkEstimates.Size = New System.Drawing.Size(71, 17)
        Me.chkEstimates.TabIndex = 3
        Me.chkEstimates.Tag = "Estimates"
        Me.chkEstimates.Text = "Estimates"
        Me.chkEstimates.UseVisualStyleBackColor = True
        '
        'chkAnovaPvalues
        '
        Me.chkAnovaPvalues.AutoSize = True
        Me.chkAnovaPvalues.Location = New System.Drawing.Point(5, 72)
        Me.chkAnovaPvalues.Name = "chkAnovaPvalues"
        Me.chkAnovaPvalues.Size = New System.Drawing.Size(101, 17)
        Me.chkAnovaPvalues.TabIndex = 2
        Me.chkAnovaPvalues.Tag = "Anova_P_values"
        Me.chkAnovaPvalues.Text = "Anova P-values"
        Me.chkAnovaPvalues.UseVisualStyleBackColor = True
        '
        'chkAnovaTable
        '
        Me.chkAnovaTable.AutoSize = True
        Me.chkAnovaTable.Location = New System.Drawing.Point(6, 21)
        Me.chkAnovaTable.Name = "chkAnovaTable"
        Me.chkAnovaTable.Size = New System.Drawing.Size(87, 17)
        Me.chkAnovaTable.TabIndex = 1
        Me.chkAnovaTable.Tag = "Anova_Table"
        Me.chkAnovaTable.Text = "Anova Table"
        Me.chkAnovaTable.UseVisualStyleBackColor = True
        '
        'chkModel
        '
        Me.chkModel.AutoSize = True
        Me.chkModel.Location = New System.Drawing.Point(6, 49)
        Me.chkModel.Name = "chkModel"
        Me.chkModel.Size = New System.Drawing.Size(55, 17)
        Me.chkModel.TabIndex = 0
        Me.chkModel.Tag = "Model"
        Me.chkModel.Text = "Model"
        Me.chkModel.UseVisualStyleBackColor = True
        '
        'tbGraphics
        '
        Me.tbGraphics.Controls.Add(Me.grpModel)
        Me.tbGraphics.Controls.Add(Me.grpResiduals)
        Me.tbGraphics.Location = New System.Drawing.Point(4, 22)
        Me.tbGraphics.Name = "tbGraphics"
        Me.tbGraphics.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGraphics.Size = New System.Drawing.Size(243, 195)
        Me.tbGraphics.TabIndex = 1
        Me.tbGraphics.Tag = "Graphics"
        Me.tbGraphics.Text = "Graphics"
        Me.tbGraphics.UseVisualStyleBackColor = True
        '
        'grpModel
        '
        Me.grpModel.Controls.Add(Me.chkFittedModel)
        Me.grpModel.Controls.Add(Me.chkPredictionInterval)
        Me.grpModel.Controls.Add(Me.nudConvidenceLevel)
        Me.grpModel.Controls.Add(Me.lblConfidenceLevel)
        Me.grpModel.Controls.Add(Me.chkConfidenceInterval)
        Me.grpModel.Location = New System.Drawing.Point(16, 80)
        Me.grpModel.Name = "grpModel"
        Me.grpModel.Size = New System.Drawing.Size(219, 104)
        Me.grpModel.TabIndex = 1
        Me.grpModel.TabStop = False
        Me.grpModel.Tag = "Model"
        Me.grpModel.Text = "Model"
        '
        'chkFittedModel
        '
        Me.chkFittedModel.AutoSize = True
        Me.chkFittedModel.Location = New System.Drawing.Point(19, 19)
        Me.chkFittedModel.Name = "chkFittedModel"
        Me.chkFittedModel.Size = New System.Drawing.Size(84, 17)
        Me.chkFittedModel.TabIndex = 0
        Me.chkFittedModel.Tag = "Fitted_Model"
        Me.chkFittedModel.Text = "Fitted Model"
        Me.chkFittedModel.UseVisualStyleBackColor = True
        '
        'chkPredictionInterval
        '
        Me.chkPredictionInterval.AutoSize = True
        Me.chkPredictionInterval.Location = New System.Drawing.Point(49, 80)
        Me.chkPredictionInterval.Name = "chkPredictionInterval"
        Me.chkPredictionInterval.Size = New System.Drawing.Size(101, 17)
        Me.chkPredictionInterval.TabIndex = 3
        Me.chkPredictionInterval.Tag = "Anova_P_values"
        Me.chkPredictionInterval.Text = "Anova P-values"
        Me.chkPredictionInterval.UseVisualStyleBackColor = True
        '
        'nudConvidenceLevel
        '
        Me.nudConvidenceLevel.Location = New System.Drawing.Point(167, 56)
        Me.nudConvidenceLevel.Name = "nudConvidenceLevel"
        Me.nudConvidenceLevel.Size = New System.Drawing.Size(39, 20)
        Me.nudConvidenceLevel.TabIndex = 4
        Me.nudConvidenceLevel.Value = New Decimal(New Integer() {95, 0, 0, 0})
        '
        'lblConfidenceLevel
        '
        Me.lblConfidenceLevel.AutoSize = True
        Me.lblConfidenceLevel.Location = New System.Drawing.Point(71, 58)
        Me.lblConfidenceLevel.Name = "lblConfidenceLevel"
        Me.lblConfidenceLevel.Size = New System.Drawing.Size(90, 13)
        Me.lblConfidenceLevel.TabIndex = 2
        Me.lblConfidenceLevel.Tag = "Confidence_Level"
        Me.lblConfidenceLevel.Text = "Confidence Level"
        '
        'chkConfidenceInterval
        '
        Me.chkConfidenceInterval.AutoSize = True
        Me.chkConfidenceInterval.Location = New System.Drawing.Point(49, 36)
        Me.chkConfidenceInterval.Name = "chkConfidenceInterval"
        Me.chkConfidenceInterval.Size = New System.Drawing.Size(118, 17)
        Me.chkConfidenceInterval.TabIndex = 1
        Me.chkConfidenceInterval.Tag = "Confidence_Interval"
        Me.chkConfidenceInterval.Text = "Confidence Interval"
        Me.chkConfidenceInterval.UseVisualStyleBackColor = True
        '
        'grpResiduals
        '
        Me.grpResiduals.Controls.Add(Me.chkFourinOne)
        Me.grpResiduals.Controls.Add(Me.chkAddionalVariable)
        Me.grpResiduals.Location = New System.Drawing.Point(16, 6)
        Me.grpResiduals.Name = "grpResiduals"
        Me.grpResiduals.Size = New System.Drawing.Size(219, 68)
        Me.grpResiduals.TabIndex = 0
        Me.grpResiduals.TabStop = False
        Me.grpResiduals.Tag = "Residuals"
        Me.grpResiduals.Text = "Residuals"
        '
        'chkFourinOne
        '
        Me.chkFourinOne.AutoSize = True
        Me.chkFourinOne.Location = New System.Drawing.Point(19, 19)
        Me.chkFourinOne.Name = "chkFourinOne"
        Me.chkFourinOne.Size = New System.Drawing.Size(81, 17)
        Me.chkFourinOne.TabIndex = 0
        Me.chkFourinOne.Tag = "Four_in_One"
        Me.chkFourinOne.Text = "Four in One"
        Me.chkFourinOne.UseVisualStyleBackColor = True
        '
        'chkAddionalVariable
        '
        Me.chkAddionalVariable.AutoSize = True
        Me.chkAddionalVariable.Location = New System.Drawing.Point(19, 42)
        Me.chkAddionalVariable.Name = "chkAddionalVariable"
        Me.chkAddionalVariable.Size = New System.Drawing.Size(122, 17)
        Me.chkAddionalVariable.TabIndex = 1
        Me.chkAddionalVariable.Tag = "vs_Addional_Variable"
        Me.chkAddionalVariable.Text = "vs Addional Variable"
        Me.chkAddionalVariable.UseVisualStyleBackColor = True
        '
        'sdgSimpleRegOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 257)
        Me.Controls.Add(Me.tbRegOptions)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgSimpleRegOptions"
        Me.Tag = "Simple_Regression_Options"
        Me.Text = "Simple Regression Options"
        Me.tbRegOptions.ResumeLayout(False)
        Me.tbDisplay.ResumeLayout(False)
        Me.tbDisplay.PerformLayout()
        CType(Me.nudConfidenceInteval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbGraphics.ResumeLayout(False)
        Me.grpModel.ResumeLayout(False)
        Me.grpModel.PerformLayout()
        CType(Me.nudConvidenceLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpResiduals.ResumeLayout(False)
        Me.grpResiduals.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents tbRegOptions As TabControl
    Friend WithEvents tbDisplay As TabPage
    Friend WithEvents nudConfidenceInteval As NumericUpDown
    Friend WithEvents lblConfidenceInterval As Label
    Friend WithEvents chkEstimatesPvalues As CheckBox
    Friend WithEvents chkEstimates As CheckBox
    Friend WithEvents chkAnovaPvalues As CheckBox
    Friend WithEvents chkAnovaTable As CheckBox
    Friend WithEvents chkModel As CheckBox
    Friend WithEvents tbGraphics As TabPage
    Friend WithEvents grpModel As GroupBox
    Friend WithEvents grpResiduals As GroupBox
    Friend WithEvents chkFittedModel As CheckBox
    Friend WithEvents chkPredictionInterval As CheckBox
    Friend WithEvents nudConvidenceLevel As NumericUpDown
    Friend WithEvents lblConfidenceLevel As Label
    Friend WithEvents chkConfidenceInterval As CheckBox
    Friend WithEvents chkFourinOne As CheckBox
    Friend WithEvents chkAddionalVariable As CheckBox
End Class
