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
        Me.grpScale = New System.Windows.Forms.GroupBox()
        Me.rdoResponse = New System.Windows.Forms.RadioButton()
        Me.rdoLinear = New System.Windows.Forms.RadioButton()
        Me.grpPlotType = New System.Windows.Forms.GroupBox()
        Me.rdoContrast = New System.Windows.Forms.RadioButton()
        Me.rdoConditional = New System.Windows.Forms.RadioButton()
        Me.grpModel = New System.Windows.Forms.GroupBox()
        Me.chkFittedModel = New System.Windows.Forms.CheckBox()
        Me.chkPredictionInterval = New System.Windows.Forms.CheckBox()
        Me.nudGraphicsCLevel = New System.Windows.Forms.NumericUpDown()
        Me.lblGraphicsCLevel = New System.Windows.Forms.Label()
        Me.chkGraphicsCLimits = New System.Windows.Forms.CheckBox()
        Me.grpResiduals = New System.Windows.Forms.GroupBox()
        Me.rdo2 = New System.Windows.Forms.RadioButton()
        Me.rdo1 = New System.Windows.Forms.RadioButton()
        Me.chkRugs = New System.Windows.Forms.CheckBox()
        Me.chkPartial = New System.Windows.Forms.CheckBox()
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
        Me.tbSave = New System.Windows.Forms.TabPage()
        Me.ucrLeverageColumnName = New instat.ucrInputComboBox()
        Me.ucrStdResidualsColumnName = New instat.ucrInputComboBox()
        Me.ucrResidualsColumnName = New instat.ucrInputComboBox()
        Me.ucrFittedColumnName = New instat.ucrInputComboBox()
        Me.chkFittedValues = New System.Windows.Forms.CheckBox()
        Me.chkResiduals = New System.Windows.Forms.CheckBox()
        Me.chkStdResiduals = New System.Windows.Forms.CheckBox()
        Me.chkLeverage = New System.Windows.Forms.CheckBox()
        Me.chkJitter = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudWhiteSpace = New System.Windows.Forms.NumericUpDown()
        Me.lblWhiteSpace = New System.Windows.Forms.Label()
        Me.tbGraphics.SuspendLayout()
        Me.grpScale.SuspendLayout()
        Me.grpPlotType.SuspendLayout()
        Me.grpModel.SuspendLayout()
        CType(Me.nudGraphicsCLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpResiduals.SuspendLayout()
        Me.tbDisplay.SuspendLayout()
        CType(Me.nudDisplayCLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbRegOptions.SuspendLayout()
        Me.tbSave.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWhiteSpace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.Location = New System.Drawing.Point(72, 377)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(142, 30)
        Me.ucrSdgButtons.TabIndex = 0
        '
        'tbGraphics
        '
        Me.tbGraphics.Controls.Add(Me.nudWhiteSpace)
        Me.tbGraphics.Controls.Add(Me.lblWhiteSpace)
        Me.tbGraphics.Controls.Add(Me.chkJitter)
        Me.tbGraphics.Controls.Add(Me.grpScale)
        Me.tbGraphics.Controls.Add(Me.grpPlotType)
        Me.tbGraphics.Controls.Add(Me.grpModel)
        Me.tbGraphics.Controls.Add(Me.grpResiduals)
        Me.tbGraphics.Location = New System.Drawing.Point(4, 22)
        Me.tbGraphics.Name = "tbGraphics"
        Me.tbGraphics.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGraphics.Size = New System.Drawing.Size(347, 350)
        Me.tbGraphics.TabIndex = 1
        Me.tbGraphics.Tag = "Graphics"
        Me.tbGraphics.Text = "Graphics"
        Me.tbGraphics.UseVisualStyleBackColor = True
        '
        'grpScale
        '
        Me.grpScale.Controls.Add(Me.rdoResponse)
        Me.grpScale.Controls.Add(Me.rdoLinear)
        Me.grpScale.Location = New System.Drawing.Point(26, 261)
        Me.grpScale.Name = "grpScale"
        Me.grpScale.Size = New System.Drawing.Size(200, 32)
        Me.grpScale.TabIndex = 6
        Me.grpScale.TabStop = False
        Me.grpScale.Tag = "Scale"
        Me.grpScale.Text = "Scale"
        '
        'rdoResponse
        '
        Me.rdoResponse.AutoSize = True
        Me.rdoResponse.Location = New System.Drawing.Point(97, 11)
        Me.rdoResponse.Name = "rdoResponse"
        Me.rdoResponse.Size = New System.Drawing.Size(73, 17)
        Me.rdoResponse.TabIndex = 8
        Me.rdoResponse.TabStop = True
        Me.rdoResponse.Tag = "Response"
        Me.rdoResponse.Text = "Response"
        Me.rdoResponse.UseVisualStyleBackColor = True
        '
        'rdoLinear
        '
        Me.rdoLinear.AutoSize = True
        Me.rdoLinear.Location = New System.Drawing.Point(4, 11)
        Me.rdoLinear.Name = "rdoLinear"
        Me.rdoLinear.Size = New System.Drawing.Size(54, 17)
        Me.rdoLinear.TabIndex = 7
        Me.rdoLinear.TabStop = True
        Me.rdoLinear.Tag = "Linear"
        Me.rdoLinear.Text = "Linear"
        Me.rdoLinear.UseVisualStyleBackColor = True
        '
        'grpPlotType
        '
        Me.grpPlotType.Controls.Add(Me.rdoContrast)
        Me.grpPlotType.Controls.Add(Me.rdoConditional)
        Me.grpPlotType.Location = New System.Drawing.Point(16, 222)
        Me.grpPlotType.Name = "grpPlotType"
        Me.grpPlotType.Size = New System.Drawing.Size(219, 39)
        Me.grpPlotType.TabIndex = 5
        Me.grpPlotType.TabStop = False
        Me.grpPlotType.Tag = "Plot_type"
        Me.grpPlotType.Text = "Plot type"
        '
        'rdoContrast
        '
        Me.rdoContrast.AutoSize = True
        Me.rdoContrast.Location = New System.Drawing.Point(101, 15)
        Me.rdoContrast.Name = "rdoContrast"
        Me.rdoContrast.Size = New System.Drawing.Size(64, 17)
        Me.rdoContrast.TabIndex = 3
        Me.rdoContrast.Tag = "Contrast"
        Me.rdoContrast.Text = "Contrast"
        Me.rdoContrast.UseVisualStyleBackColor = True
        '
        'rdoConditional
        '
        Me.rdoConditional.AutoSize = True
        Me.rdoConditional.Location = New System.Drawing.Point(18, 15)
        Me.rdoConditional.Name = "rdoConditional"
        Me.rdoConditional.Size = New System.Drawing.Size(77, 17)
        Me.rdoConditional.TabIndex = 2
        Me.rdoConditional.Tag = "Conditional"
        Me.rdoConditional.Text = "Conditional"
        Me.rdoConditional.UseVisualStyleBackColor = True
        '
        'grpModel
        '
        Me.grpModel.Controls.Add(Me.NumericUpDown1)
        Me.grpModel.Controls.Add(Me.Label1)
        Me.grpModel.Controls.Add(Me.chkFittedModel)
        Me.grpModel.Controls.Add(Me.chkPredictionInterval)
        Me.grpModel.Controls.Add(Me.nudGraphicsCLevel)
        Me.grpModel.Controls.Add(Me.lblGraphicsCLevel)
        Me.grpModel.Controls.Add(Me.chkGraphicsCLimits)
        Me.grpModel.Location = New System.Drawing.Point(16, 114)
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
        Me.grpResiduals.Controls.Add(Me.rdo2)
        Me.grpResiduals.Controls.Add(Me.rdo1)
        Me.grpResiduals.Controls.Add(Me.chkRugs)
        Me.grpResiduals.Controls.Add(Me.chkPartial)
        Me.grpResiduals.Controls.Add(Me.chkFourinOne)
        Me.grpResiduals.Location = New System.Drawing.Point(16, 6)
        Me.grpResiduals.Name = "grpResiduals"
        Me.grpResiduals.Size = New System.Drawing.Size(219, 102)
        Me.grpResiduals.TabIndex = 0
        Me.grpResiduals.TabStop = False
        Me.grpResiduals.Tag = "Residuals"
        Me.grpResiduals.Text = "Residuals"
        '
        'rdo2
        '
        Me.rdo2.AutoSize = True
        Me.rdo2.Location = New System.Drawing.Point(106, 79)
        Me.rdo2.Name = "rdo2"
        Me.rdo2.Size = New System.Drawing.Size(31, 17)
        Me.rdo2.TabIndex = 4
        Me.rdo2.TabStop = True
        Me.rdo2.Tag = "2"
        Me.rdo2.Text = "2"
        Me.rdo2.UseVisualStyleBackColor = True
        '
        'rdo1
        '
        Me.rdo1.AutoSize = True
        Me.rdo1.Location = New System.Drawing.Point(69, 79)
        Me.rdo1.Name = "rdo1"
        Me.rdo1.Size = New System.Drawing.Size(31, 17)
        Me.rdo1.TabIndex = 3
        Me.rdo1.TabStop = True
        Me.rdo1.Tag = "1"
        Me.rdo1.Text = "1"
        Me.rdo1.UseVisualStyleBackColor = True
        '
        'chkRugs
        '
        Me.chkRugs.AutoSize = True
        Me.chkRugs.Location = New System.Drawing.Point(19, 65)
        Me.chkRugs.Name = "chkRugs"
        Me.chkRugs.Size = New System.Drawing.Size(51, 17)
        Me.chkRugs.TabIndex = 2
        Me.chkRugs.Tag = "Rugs"
        Me.chkRugs.Text = "Rugs"
        Me.chkRugs.UseVisualStyleBackColor = True
        '
        'chkPartial
        '
        Me.chkPartial.AutoSize = True
        Me.chkPartial.Location = New System.Drawing.Point(19, 42)
        Me.chkPartial.Name = "chkPartial"
        Me.chkPartial.Size = New System.Drawing.Size(55, 17)
        Me.chkPartial.TabIndex = 1
        Me.chkPartial.Tag = "Partial"
        Me.chkPartial.Text = "Partial"
        Me.chkPartial.UseVisualStyleBackColor = True
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
        Me.tbDisplay.Size = New System.Drawing.Size(347, 350)
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
        Me.tbRegOptions.Controls.Add(Me.tbSave)
        Me.tbRegOptions.Location = New System.Drawing.Point(2, 3)
        Me.tbRegOptions.Name = "tbRegOptions"
        Me.tbRegOptions.SelectedIndex = 0
        Me.tbRegOptions.Size = New System.Drawing.Size(355, 376)
        Me.tbRegOptions.TabIndex = 0
        '
        'tbSave
        '
        Me.tbSave.Controls.Add(Me.ucrLeverageColumnName)
        Me.tbSave.Controls.Add(Me.ucrStdResidualsColumnName)
        Me.tbSave.Controls.Add(Me.ucrResidualsColumnName)
        Me.tbSave.Controls.Add(Me.ucrFittedColumnName)
        Me.tbSave.Controls.Add(Me.chkFittedValues)
        Me.tbSave.Controls.Add(Me.chkResiduals)
        Me.tbSave.Controls.Add(Me.chkStdResiduals)
        Me.tbSave.Controls.Add(Me.chkLeverage)
        Me.tbSave.Location = New System.Drawing.Point(4, 22)
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSave.Size = New System.Drawing.Size(347, 350)
        Me.tbSave.TabIndex = 2
        Me.tbSave.Tag = "Save"
        Me.tbSave.Text = "Save"
        Me.tbSave.UseVisualStyleBackColor = True
        '
        'ucrLeverageColumnName
        '
        Me.ucrLeverageColumnName.IsReadOnly = False
        Me.ucrLeverageColumnName.Location = New System.Drawing.Point(108, 120)
        Me.ucrLeverageColumnName.Name = "ucrLeverageColumnName"
        Me.ucrLeverageColumnName.Size = New System.Drawing.Size(115, 21)
        Me.ucrLeverageColumnName.TabIndex = 19
        '
        'ucrStdResidualsColumnName
        '
        Me.ucrStdResidualsColumnName.IsReadOnly = False
        Me.ucrStdResidualsColumnName.Location = New System.Drawing.Point(108, 83)
        Me.ucrStdResidualsColumnName.Name = "ucrStdResidualsColumnName"
        Me.ucrStdResidualsColumnName.Size = New System.Drawing.Size(115, 21)
        Me.ucrStdResidualsColumnName.TabIndex = 17
        '
        'ucrResidualsColumnName
        '
        Me.ucrResidualsColumnName.IsReadOnly = False
        Me.ucrResidualsColumnName.Location = New System.Drawing.Point(108, 45)
        Me.ucrResidualsColumnName.Name = "ucrResidualsColumnName"
        Me.ucrResidualsColumnName.Size = New System.Drawing.Size(115, 21)
        Me.ucrResidualsColumnName.TabIndex = 15
        '
        'ucrFittedColumnName
        '
        Me.ucrFittedColumnName.IsReadOnly = False
        Me.ucrFittedColumnName.Location = New System.Drawing.Point(108, 9)
        Me.ucrFittedColumnName.Name = "ucrFittedColumnName"
        Me.ucrFittedColumnName.Size = New System.Drawing.Size(115, 21)
        Me.ucrFittedColumnName.TabIndex = 13
        '
        'chkFittedValues
        '
        Me.chkFittedValues.AutoSize = True
        Me.chkFittedValues.Location = New System.Drawing.Point(13, 13)
        Me.chkFittedValues.Name = "chkFittedValues"
        Me.chkFittedValues.Size = New System.Drawing.Size(87, 17)
        Me.chkFittedValues.TabIndex = 4
        Me.chkFittedValues.Tag = "Fitted_Values"
        Me.chkFittedValues.Text = "Fitted Values"
        Me.chkFittedValues.UseVisualStyleBackColor = True
        '
        'chkResiduals
        '
        Me.chkResiduals.AutoSize = True
        Me.chkResiduals.Location = New System.Drawing.Point(13, 49)
        Me.chkResiduals.Name = "chkResiduals"
        Me.chkResiduals.Size = New System.Drawing.Size(72, 17)
        Me.chkResiduals.TabIndex = 3
        Me.chkResiduals.Tag = "Residuals"
        Me.chkResiduals.Text = "Residuals"
        Me.chkResiduals.UseVisualStyleBackColor = True
        '
        'chkStdResiduals
        '
        Me.chkStdResiduals.AutoSize = True
        Me.chkStdResiduals.Location = New System.Drawing.Point(13, 87)
        Me.chkStdResiduals.Name = "chkStdResiduals"
        Me.chkStdResiduals.Size = New System.Drawing.Size(91, 17)
        Me.chkStdResiduals.TabIndex = 2
        Me.chkStdResiduals.Tag = "Std_Residuals"
        Me.chkStdResiduals.Text = "Std Residuals"
        Me.chkStdResiduals.UseVisualStyleBackColor = True
        '
        'chkLeverage
        '
        Me.chkLeverage.AutoSize = True
        Me.chkLeverage.Location = New System.Drawing.Point(13, 124)
        Me.chkLeverage.Name = "chkLeverage"
        Me.chkLeverage.Size = New System.Drawing.Size(71, 17)
        Me.chkLeverage.TabIndex = 1
        Me.chkLeverage.Tag = "Leverage"
        Me.chkLeverage.Text = "Leverage"
        Me.chkLeverage.UseVisualStyleBackColor = True
        '
        'chkJitter
        '
        Me.chkJitter.AutoSize = True
        Me.chkJitter.Location = New System.Drawing.Point(42, 295)
        Me.chkJitter.Name = "chkJitter"
        Me.chkJitter.Size = New System.Drawing.Size(48, 17)
        Me.chkJitter.TabIndex = 7
        Me.chkJitter.Tag = "Jitter"
        Me.chkJitter.Text = "Jitter"
        Me.chkJitter.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.DecimalPlaces = 2
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NumericUpDown1.Location = New System.Drawing.Point(134, 207)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(46, 20)
        Me.NumericUpDown1.TabIndex = 6
        Me.NumericUpDown1.Value = New Decimal(New Integer() {95, 0, 0, 131072})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Tag = "Confidence_Level"
        Me.Label1.Text = "Confidence Level"
        '
        'nudWhiteSpace
        '
        Me.nudWhiteSpace.DecimalPlaces = 1
        Me.nudWhiteSpace.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudWhiteSpace.Location = New System.Drawing.Point(159, 308)
        Me.nudWhiteSpace.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudWhiteSpace.Name = "nudWhiteSpace"
        Me.nudWhiteSpace.Size = New System.Drawing.Size(46, 20)
        Me.nudWhiteSpace.TabIndex = 9
        Me.nudWhiteSpace.Value = New Decimal(New Integer() {2, 0, 0, 65536})
        '
        'lblWhiteSpace
        '
        Me.lblWhiteSpace.AutoSize = True
        Me.lblWhiteSpace.Location = New System.Drawing.Point(63, 310)
        Me.lblWhiteSpace.Name = "lblWhiteSpace"
        Me.lblWhiteSpace.Size = New System.Drawing.Size(69, 13)
        Me.lblWhiteSpace.TabIndex = 8
        Me.lblWhiteSpace.Tag = "White_Space"
        Me.lblWhiteSpace.Text = "White Space"
        '
        'sdgSimpleRegOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 405)
        Me.Controls.Add(Me.tbRegOptions)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgSimpleRegOptions"
        Me.Tag = "Graph_Display_Options"
        Me.Text = "Graph Display Options"
        Me.tbGraphics.ResumeLayout(False)
        Me.tbGraphics.PerformLayout()
        Me.grpScale.ResumeLayout(False)
        Me.grpScale.PerformLayout()
        Me.grpPlotType.ResumeLayout(False)
        Me.grpPlotType.PerformLayout()
        Me.grpModel.ResumeLayout(False)
        Me.grpModel.PerformLayout()
        CType(Me.nudGraphicsCLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpResiduals.ResumeLayout(False)
        Me.grpResiduals.PerformLayout()
        Me.tbDisplay.ResumeLayout(False)
        Me.tbDisplay.PerformLayout()
        CType(Me.nudDisplayCLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbRegOptions.ResumeLayout(False)
        Me.tbSave.ResumeLayout(False)
        Me.tbSave.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWhiteSpace, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tbSave As TabPage
    Friend WithEvents chkFittedValues As CheckBox
    Friend WithEvents chkResiduals As CheckBox
    Friend WithEvents chkStdResiduals As CheckBox
    Friend WithEvents chkLeverage As CheckBox
    Friend WithEvents ucrFittedColumnName As ucrInputComboBox
    Friend WithEvents ucrLeverageColumnName As ucrInputComboBox
    Friend WithEvents ucrStdResidualsColumnName As ucrInputComboBox
    Friend WithEvents ucrResidualsColumnName As ucrInputComboBox
    Friend WithEvents rdoContrast As RadioButton
    Friend WithEvents rdoConditional As RadioButton
    Friend WithEvents grpPlotType As GroupBox
    Friend WithEvents grpScale As GroupBox
    Friend WithEvents rdoResponse As RadioButton
    Friend WithEvents rdoLinear As RadioButton
    Friend WithEvents rdo2 As RadioButton
    Friend WithEvents rdo1 As RadioButton
    Friend WithEvents chkRugs As CheckBox
    Friend WithEvents chkPartial As CheckBox
    Friend WithEvents chkJitter As CheckBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents nudWhiteSpace As NumericUpDown
    Friend WithEvents lblWhiteSpace As Label
End Class
