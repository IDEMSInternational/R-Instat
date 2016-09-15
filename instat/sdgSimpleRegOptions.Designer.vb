<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgSimpleRegOptions
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
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.tbGraphics = New System.Windows.Forms.TabPage()
        Me.grpModel = New System.Windows.Forms.GroupBox()
        Me.chkFittedModel = New System.Windows.Forms.CheckBox()
        Me.chkPredictionInterval = New System.Windows.Forms.CheckBox()
        Me.nudGraphicsCLevel = New System.Windows.Forms.NumericUpDown()
        Me.lblGraphicsCLevel = New System.Windows.Forms.Label()
        Me.chkGraphicsCLimits = New System.Windows.Forms.CheckBox()
        Me.grpResiduals = New System.Windows.Forms.GroupBox()
        Me.chkFourinOne = New System.Windows.Forms.CheckBox()
        Me.tbDisplay = New System.Windows.Forms.TabPage()
        Me.chkDisplayCLimits = New System.Windows.Forms.CheckBox()
        Me.nudDisplayCLevel = New System.Windows.Forms.NumericUpDown()
        Me.lblDisplayCLevel = New System.Windows.Forms.Label()
        Me.chkEstimates = New System.Windows.Forms.CheckBox()
        Me.chkPvalues = New System.Windows.Forms.CheckBox()
        Me.chkANOVA = New System.Windows.Forms.CheckBox()
        Me.chkModel = New System.Windows.Forms.CheckBox()
        Me.tbRegOptions = New System.Windows.Forms.TabControl()
        Me.tbGraphics.SuspendLayout()
        Me.grpModel.SuspendLayout()
        CType(Me.nudGraphicsCLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpResiduals.SuspendLayout()
        Me.tbDisplay.SuspendLayout()
        CType(Me.nudDisplayCLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbRegOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.Location = New System.Drawing.Point(41, 201)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(142, 30)
        Me.ucrSdgButtons.TabIndex = 0
        '
        'tbGraphics
        '
        Me.tbGraphics.Controls.Add(Me.grpModel)
        Me.tbGraphics.Controls.Add(Me.grpResiduals)
        Me.tbGraphics.Location = New System.Drawing.Point(4, 22)
        Me.tbGraphics.Name = "tbGraphics"
        Me.tbGraphics.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGraphics.Size = New System.Drawing.Size(246, 167)
        Me.tbGraphics.TabIndex = 1
        Me.tbGraphics.Tag = "Graphics"
        Me.tbGraphics.Text = "Graphics"
        Me.tbGraphics.UseVisualStyleBackColor = True
        '
        'grpModel
        '
        Me.grpModel.Controls.Add(Me.chkFittedModel)
        Me.grpModel.Controls.Add(Me.chkPredictionInterval)
        Me.grpModel.Controls.Add(Me.nudGraphicsCLevel)
        Me.grpModel.Controls.Add(Me.lblGraphicsCLevel)
        Me.grpModel.Controls.Add(Me.chkGraphicsCLimits)
        Me.grpModel.Location = New System.Drawing.Point(16, 56)
        Me.grpModel.Name = "grpModel"
        Me.grpModel.Size = New System.Drawing.Size(219, 102)
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
        Me.chkPredictionInterval.Location = New System.Drawing.Point(50, 81)
        Me.chkPredictionInterval.Name = "chkPredictionInterval"
        Me.chkPredictionInterval.Size = New System.Drawing.Size(111, 17)
        Me.chkPredictionInterval.TabIndex = 4
        Me.chkPredictionInterval.Tag = "Prediction_Interval"
        Me.chkPredictionInterval.Text = "Prediction Interval"
        Me.chkPredictionInterval.UseVisualStyleBackColor = True
        '
        'nudGraphicsCLevel
        '
        Me.nudGraphicsCLevel.DecimalPlaces = 2
        Me.nudGraphicsCLevel.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudGraphicsCLevel.Location = New System.Drawing.Point(167, 56)
        Me.nudGraphicsCLevel.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudGraphicsCLevel.Name = "nudGraphicsCLevel"
        Me.nudGraphicsCLevel.Size = New System.Drawing.Size(46, 20)
        Me.nudGraphicsCLevel.TabIndex = 3
        Me.nudGraphicsCLevel.Value = New Decimal(New Integer() {95, 0, 0, 131072})
        '
        'lblGraphicsCLevel
        '
        Me.lblGraphicsCLevel.AutoSize = True
        Me.lblGraphicsCLevel.Location = New System.Drawing.Point(71, 58)
        Me.lblGraphicsCLevel.Name = "lblGraphicsCLevel"
        Me.lblGraphicsCLevel.Size = New System.Drawing.Size(90, 13)
        Me.lblGraphicsCLevel.TabIndex = 2
        Me.lblGraphicsCLevel.Tag = "Confidence_Level"
        Me.lblGraphicsCLevel.Text = "Confidence Level"
        '
        'chkGraphicsCLimits
        '
        Me.chkGraphicsCLimits.AutoSize = True
        Me.chkGraphicsCLimits.Location = New System.Drawing.Point(49, 36)
        Me.chkGraphicsCLimits.Name = "chkGraphicsCLimits"
        Me.chkGraphicsCLimits.Size = New System.Drawing.Size(109, 17)
        Me.chkGraphicsCLimits.TabIndex = 1
        Me.chkGraphicsCLimits.Tag = "Confidence_Limits"
        Me.chkGraphicsCLimits.Text = "Confidence Limits"
        Me.chkGraphicsCLimits.UseVisualStyleBackColor = True
        '
        'grpResiduals
        '
        Me.grpResiduals.Controls.Add(Me.chkFourinOne)
        Me.grpResiduals.Location = New System.Drawing.Point(16, 6)
        Me.grpResiduals.Name = "grpResiduals"
        Me.grpResiduals.Size = New System.Drawing.Size(219, 46)
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
        'tbDisplay
        '
        Me.tbDisplay.Controls.Add(Me.chkDisplayCLimits)
        Me.tbDisplay.Controls.Add(Me.nudDisplayCLevel)
        Me.tbDisplay.Controls.Add(Me.lblDisplayCLevel)
        Me.tbDisplay.Controls.Add(Me.chkEstimates)
        Me.tbDisplay.Controls.Add(Me.chkPvalues)
        Me.tbDisplay.Controls.Add(Me.chkANOVA)
        Me.tbDisplay.Controls.Add(Me.chkModel)
        Me.tbDisplay.Location = New System.Drawing.Point(4, 22)
        Me.tbDisplay.Name = "tbDisplay"
        Me.tbDisplay.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDisplay.Size = New System.Drawing.Size(246, 167)
        Me.tbDisplay.TabIndex = 0
        Me.tbDisplay.Tag = "Display"
        Me.tbDisplay.Text = "Display"
        Me.tbDisplay.UseVisualStyleBackColor = True
        '
        'chkDisplayCLimits
        '
        Me.chkDisplayCLimits.AutoSize = True
        Me.chkDisplayCLimits.Location = New System.Drawing.Point(7, 102)
        Me.chkDisplayCLimits.Name = "chkDisplayCLimits"
        Me.chkDisplayCLimits.Size = New System.Drawing.Size(109, 17)
        Me.chkDisplayCLimits.TabIndex = 4
        Me.chkDisplayCLimits.Tag = "Confidence_Limits"
        Me.chkDisplayCLimits.Text = "Confidence Limits"
        Me.chkDisplayCLimits.UseVisualStyleBackColor = True
        '
        'nudDisplayCLevel
        '
        Me.nudDisplayCLevel.DecimalPlaces = 2
        Me.nudDisplayCLevel.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudDisplayCLevel.Location = New System.Drawing.Point(149, 124)
        Me.nudDisplayCLevel.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDisplayCLevel.Name = "nudDisplayCLevel"
        Me.nudDisplayCLevel.Size = New System.Drawing.Size(45, 20)
        Me.nudDisplayCLevel.TabIndex = 6
        Me.nudDisplayCLevel.Value = New Decimal(New Integer() {95, 0, 0, 131072})
        '
        'lblDisplayCLevel
        '
        Me.lblDisplayCLevel.AutoSize = True
        Me.lblDisplayCLevel.Location = New System.Drawing.Point(34, 126)
        Me.lblDisplayCLevel.Name = "lblDisplayCLevel"
        Me.lblDisplayCLevel.Size = New System.Drawing.Size(90, 13)
        Me.lblDisplayCLevel.TabIndex = 5
        Me.lblDisplayCLevel.Tag = "Confidence_Level"
        Me.lblDisplayCLevel.Text = "Confidence Level"
        '
        'chkEstimates
        '
        Me.chkEstimates.AutoSize = True
        Me.chkEstimates.Location = New System.Drawing.Point(6, 73)
        Me.chkEstimates.Name = "chkEstimates"
        Me.chkEstimates.Size = New System.Drawing.Size(71, 17)
        Me.chkEstimates.TabIndex = 3
        Me.chkEstimates.Tag = "Estimates"
        Me.chkEstimates.Text = "Estimates"
        Me.chkEstimates.UseVisualStyleBackColor = True
        '
        'chkPvalues
        '
        Me.chkPvalues.AutoSize = True
        Me.chkPvalues.Location = New System.Drawing.Point(118, 46)
        Me.chkPvalues.Name = "chkPvalues"
        Me.chkPvalues.Size = New System.Drawing.Size(67, 17)
        Me.chkPvalues.TabIndex = 2
        Me.chkPvalues.Tag = "P_values"
        Me.chkPvalues.Text = "P-values"
        Me.chkPvalues.UseVisualStyleBackColor = True
        '
        'chkANOVA
        '
        Me.chkANOVA.AutoSize = True
        Me.chkANOVA.Location = New System.Drawing.Point(6, 44)
        Me.chkANOVA.Name = "chkANOVA"
        Me.chkANOVA.Size = New System.Drawing.Size(63, 17)
        Me.chkANOVA.TabIndex = 1
        Me.chkANOVA.Tag = "ANOVA"
        Me.chkANOVA.Text = "ANOVA"
        Me.chkANOVA.UseVisualStyleBackColor = True
        '
        'chkModel
        '
        Me.chkModel.AutoSize = True
        Me.chkModel.Location = New System.Drawing.Point(6, 15)
        Me.chkModel.Name = "chkModel"
        Me.chkModel.Size = New System.Drawing.Size(55, 17)
        Me.chkModel.TabIndex = 0
        Me.chkModel.Tag = "Model"
        Me.chkModel.Text = "Model"
        Me.chkModel.UseVisualStyleBackColor = True
        '
        'tbRegOptions
        '
        Me.tbRegOptions.Controls.Add(Me.tbDisplay)
        Me.tbRegOptions.Controls.Add(Me.tbGraphics)
        Me.tbRegOptions.Location = New System.Drawing.Point(2, 3)
        Me.tbRegOptions.Name = "tbRegOptions"
        Me.tbRegOptions.SelectedIndex = 0
        Me.tbRegOptions.Size = New System.Drawing.Size(254, 193)
        Me.tbRegOptions.TabIndex = 0
        '
        'sdgSimpleRegOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 233)
        Me.Controls.Add(Me.tbRegOptions)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgSimpleRegOptions"
        Me.Tag = "Graph_Display_Options"
        Me.Text = "Graph Display Options"
        Me.tbGraphics.ResumeLayout(False)
        Me.grpModel.ResumeLayout(False)
        Me.grpModel.PerformLayout()
        CType(Me.nudGraphicsCLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpResiduals.ResumeLayout(False)
        Me.grpResiduals.PerformLayout()
        Me.tbDisplay.ResumeLayout(False)
        Me.tbDisplay.PerformLayout()
        CType(Me.nudDisplayCLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbRegOptions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents tbGraphics As TabPage
    Friend WithEvents grpModel As GroupBox
    Friend WithEvents chkFittedModel As CheckBox
    Friend WithEvents chkPredictionInterval As CheckBox
    Friend WithEvents nudGraphicsCLevel As NumericUpDown
    Friend WithEvents lblGraphicsCLevel As Label
    Friend WithEvents chkGraphicsCLimits As CheckBox
    Friend WithEvents grpResiduals As GroupBox
    Friend WithEvents chkFourinOne As CheckBox
    Friend WithEvents tbDisplay As TabPage
    Friend WithEvents chkDisplayCLimits As CheckBox
    Friend WithEvents nudDisplayCLevel As NumericUpDown
    Friend WithEvents lblDisplayCLevel As Label
    Friend WithEvents chkEstimates As CheckBox
    Friend WithEvents chkPvalues As CheckBox
    Friend WithEvents chkANOVA As CheckBox
    Friend WithEvents chkModel As CheckBox
    Friend WithEvents tbRegOptions As TabControl
End Class
