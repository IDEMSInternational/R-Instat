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
        Me.tbGraphics = New System.Windows.Forms.TabPage()
        Me.tcGraphics = New System.Windows.Forms.TabControl()
        Me.tbModel = New System.Windows.Forms.TabPage()
        Me.chkConfIntervalband = New System.Windows.Forms.CheckBox()
        Me.grpRugs = New System.Windows.Forms.GroupBox()
        Me.rdoPartial = New System.Windows.Forms.RadioButton()
        Me.rdo1 = New System.Windows.Forms.RadioButton()
        Me.rdo2 = New System.Windows.Forms.RadioButton()
        Me.nudWhiteSpace = New System.Windows.Forms.NumericUpDown()
        Me.chkFittedModel = New System.Windows.Forms.CheckBox()
        Me.nudGraphicsCLevel = New System.Windows.Forms.NumericUpDown()
        Me.lblWhiteSpace = New System.Windows.Forms.Label()
        Me.lblGraphicsSignLevel = New System.Windows.Forms.Label()
        Me.chkPartial = New System.Windows.Forms.CheckBox()
        Me.chkJitter = New System.Windows.Forms.CheckBox()
        Me.chkRugs = New System.Windows.Forms.CheckBox()
        Me.grpScale = New System.Windows.Forms.GroupBox()
        Me.rdoResponse = New System.Windows.Forms.RadioButton()
        Me.rdoLinear = New System.Windows.Forms.RadioButton()
        Me.grpPlotType = New System.Windows.Forms.GroupBox()
        Me.rdoContrast = New System.Windows.Forms.RadioButton()
        Me.rdoConditional = New System.Windows.Forms.RadioButton()
        Me.tbResiduals = New System.Windows.Forms.TabPage()
        Me.chkIndividualPlots = New System.Windows.Forms.CheckBox()
        Me.chkMultiplePlots = New System.Windows.Forms.CheckBox()
        Me.grpIndividualPlots = New System.Windows.Forms.GroupBox()
        Me.rdoCooksDistanceLeverage = New System.Windows.Forms.RadioButton()
        Me.rdoCooksDistance = New System.Windows.Forms.RadioButton()
        Me.rdoResidualsLeverage = New System.Windows.Forms.RadioButton()
        Me.rdoScaleLocation = New System.Windows.Forms.RadioButton()
        Me.rdoQQ = New System.Windows.Forms.RadioButton()
        Me.rdoResidualsFitted = New System.Windows.Forms.RadioButton()
        Me.grpMultiplePlots = New System.Windows.Forms.GroupBox()
        Me.rdoSixPlots3Rows = New System.Windows.Forms.RadioButton()
        Me.rdoFourPlots = New System.Windows.Forms.RadioButton()
        Me.rdoSixPlots2Rows = New System.Windows.Forms.RadioButton()
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
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.tbGraphics.SuspendLayout()
        Me.tcGraphics.SuspendLayout()
        Me.tbModel.SuspendLayout()
        Me.grpRugs.SuspendLayout()
        CType(Me.nudWhiteSpace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGraphicsCLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpScale.SuspendLayout()
        Me.grpPlotType.SuspendLayout()
        Me.tbResiduals.SuspendLayout()
        Me.grpIndividualPlots.SuspendLayout()
        Me.grpMultiplePlots.SuspendLayout()
        Me.tbDisplay.SuspendLayout()
        CType(Me.nudDisplayCLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbRegOptions.SuspendLayout()
        Me.tbSave.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbGraphics
        '
        Me.tbGraphics.Controls.Add(Me.tcGraphics)
        Me.tbGraphics.Location = New System.Drawing.Point(4, 22)
        Me.tbGraphics.Name = "tbGraphics"
        Me.tbGraphics.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGraphics.Size = New System.Drawing.Size(313, 316)
        Me.tbGraphics.TabIndex = 1
        Me.tbGraphics.Tag = "Graphics"
        Me.tbGraphics.Text = "Graphics"
        Me.tbGraphics.UseVisualStyleBackColor = True
        '
        'tcGraphics
        '
        Me.tcGraphics.Controls.Add(Me.tbModel)
        Me.tcGraphics.Controls.Add(Me.tbResiduals)
        Me.tcGraphics.Location = New System.Drawing.Point(6, 3)
        Me.tcGraphics.Name = "tcGraphics"
        Me.tcGraphics.SelectedIndex = 0
        Me.tcGraphics.Size = New System.Drawing.Size(304, 307)
        Me.tcGraphics.TabIndex = 10
        '
        'tbModel
        '
        Me.tbModel.AccessibleDescription = ""
        Me.tbModel.Controls.Add(Me.chkConfIntervalband)
        Me.tbModel.Controls.Add(Me.grpRugs)
        Me.tbModel.Controls.Add(Me.nudWhiteSpace)
        Me.tbModel.Controls.Add(Me.chkFittedModel)
        Me.tbModel.Controls.Add(Me.nudGraphicsCLevel)
        Me.tbModel.Controls.Add(Me.lblWhiteSpace)
        Me.tbModel.Controls.Add(Me.lblGraphicsSignLevel)
        Me.tbModel.Controls.Add(Me.chkPartial)
        Me.tbModel.Controls.Add(Me.chkJitter)
        Me.tbModel.Controls.Add(Me.chkRugs)
        Me.tbModel.Controls.Add(Me.grpScale)
        Me.tbModel.Controls.Add(Me.grpPlotType)
        Me.tbModel.Location = New System.Drawing.Point(4, 22)
        Me.tbModel.Name = "tbModel"
        Me.tbModel.Padding = New System.Windows.Forms.Padding(3)
        Me.tbModel.Size = New System.Drawing.Size(296, 281)
        Me.tbModel.TabIndex = 0
        Me.tbModel.Tag = "Model"
        Me.tbModel.Text = "Model"
        Me.tbModel.UseVisualStyleBackColor = True
        '
        'chkConfIntervalband
        '
        Me.chkConfIntervalband.AutoSize = True
        Me.chkConfIntervalband.Location = New System.Drawing.Point(115, 205)
        Me.chkConfIntervalband.Name = "chkConfIntervalband"
        Me.chkConfIntervalband.Size = New System.Drawing.Size(66, 17)
        Me.chkConfIntervalband.TabIndex = 10
        Me.chkConfIntervalband.Tag = "C.I band"
        Me.chkConfIntervalband.Text = "C.I band"
        Me.chkConfIntervalband.UseVisualStyleBackColor = True
        '
        'grpRugs
        '
        Me.grpRugs.Controls.Add(Me.rdoPartial)
        Me.grpRugs.Controls.Add(Me.rdo1)
        Me.grpRugs.Controls.Add(Me.rdo2)
        Me.grpRugs.Location = New System.Drawing.Point(10, 228)
        Me.grpRugs.Name = "grpRugs"
        Me.grpRugs.Size = New System.Drawing.Size(190, 46)
        Me.grpRugs.TabIndex = 7
        Me.grpRugs.TabStop = False
        '
        'rdoPartial
        '
        Me.rdoPartial.AutoSize = True
        Me.rdoPartial.Location = New System.Drawing.Point(6, 17)
        Me.rdoPartial.Name = "rdoPartial"
        Me.rdoPartial.Size = New System.Drawing.Size(54, 17)
        Me.rdoPartial.TabIndex = 5
        Me.rdoPartial.TabStop = True
        Me.rdoPartial.Tag = "Partial"
        Me.rdoPartial.Text = "Partial"
        Me.rdoPartial.UseVisualStyleBackColor = True
        '
        'rdo1
        '
        Me.rdo1.AutoSize = True
        Me.rdo1.Location = New System.Drawing.Point(80, 17)
        Me.rdo1.Name = "rdo1"
        Me.rdo1.Size = New System.Drawing.Size(31, 17)
        Me.rdo1.TabIndex = 3
        Me.rdo1.TabStop = True
        Me.rdo1.Tag = "1"
        Me.rdo1.Text = "1"
        Me.rdo1.UseVisualStyleBackColor = True
        '
        'rdo2
        '
        Me.rdo2.AutoSize = True
        Me.rdo2.Location = New System.Drawing.Point(131, 17)
        Me.rdo2.Name = "rdo2"
        Me.rdo2.Size = New System.Drawing.Size(31, 17)
        Me.rdo2.TabIndex = 4
        Me.rdo2.TabStop = True
        Me.rdo2.Tag = "2"
        Me.rdo2.Text = "2"
        Me.rdo2.UseVisualStyleBackColor = True
        '
        'nudWhiteSpace
        '
        Me.nudWhiteSpace.DecimalPlaces = 1
        Me.nudWhiteSpace.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudWhiteSpace.Location = New System.Drawing.Point(109, 147)
        Me.nudWhiteSpace.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudWhiteSpace.Name = "nudWhiteSpace"
        Me.nudWhiteSpace.Size = New System.Drawing.Size(46, 20)
        Me.nudWhiteSpace.TabIndex = 9
        Me.nudWhiteSpace.Value = New Decimal(New Integer() {2, 0, 0, 65536})
        '
        'chkFittedModel
        '
        Me.chkFittedModel.AutoSize = True
        Me.chkFittedModel.Location = New System.Drawing.Point(10, 10)
        Me.chkFittedModel.Name = "chkFittedModel"
        Me.chkFittedModel.Size = New System.Drawing.Size(84, 17)
        Me.chkFittedModel.TabIndex = 0
        Me.chkFittedModel.Tag = "Fitted_Model"
        Me.chkFittedModel.Text = "Fitted Model"
        Me.chkFittedModel.UseVisualStyleBackColor = True
        '
        'nudGraphicsCLevel
        '
        Me.nudGraphicsCLevel.DecimalPlaces = 2
        Me.nudGraphicsCLevel.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudGraphicsCLevel.Location = New System.Drawing.Point(109, 121)
        Me.nudGraphicsCLevel.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudGraphicsCLevel.Name = "nudGraphicsCLevel"
        Me.nudGraphicsCLevel.Size = New System.Drawing.Size(46, 20)
        Me.nudGraphicsCLevel.TabIndex = 3
        Me.nudGraphicsCLevel.Value = New Decimal(New Integer() {5, 0, 0, 131072})
        '
        'lblWhiteSpace
        '
        Me.lblWhiteSpace.AutoSize = True
        Me.lblWhiteSpace.Location = New System.Drawing.Point(9, 149)
        Me.lblWhiteSpace.Name = "lblWhiteSpace"
        Me.lblWhiteSpace.Size = New System.Drawing.Size(72, 13)
        Me.lblWhiteSpace.TabIndex = 8
        Me.lblWhiteSpace.Tag = "White_Space:"
        Me.lblWhiteSpace.Text = "White Space:"
        '
        'lblGraphicsSignLevel
        '
        Me.lblGraphicsSignLevel.AutoSize = True
        Me.lblGraphicsSignLevel.Location = New System.Drawing.Point(9, 124)
        Me.lblGraphicsSignLevel.Name = "lblGraphicsSignLevel"
        Me.lblGraphicsSignLevel.Size = New System.Drawing.Size(97, 13)
        Me.lblGraphicsSignLevel.TabIndex = 2
        Me.lblGraphicsSignLevel.Tag = "Significance_Level:"
        Me.lblGraphicsSignLevel.Text = "Significance Level:"
        '
        'chkPartial
        '
        Me.chkPartial.AutoSize = True
        Me.chkPartial.Location = New System.Drawing.Point(10, 182)
        Me.chkPartial.Name = "chkPartial"
        Me.chkPartial.Size = New System.Drawing.Size(55, 17)
        Me.chkPartial.TabIndex = 6
        Me.chkPartial.Tag = "Partial"
        Me.chkPartial.Text = "Partial"
        Me.chkPartial.UseVisualStyleBackColor = True
        '
        'chkJitter
        '
        Me.chkJitter.AutoSize = True
        Me.chkJitter.Location = New System.Drawing.Point(10, 205)
        Me.chkJitter.Name = "chkJitter"
        Me.chkJitter.Size = New System.Drawing.Size(48, 17)
        Me.chkJitter.TabIndex = 7
        Me.chkJitter.Tag = "Jitter"
        Me.chkJitter.Text = "Jitter"
        Me.chkJitter.UseVisualStyleBackColor = True
        '
        'chkRugs
        '
        Me.chkRugs.AutoSize = True
        Me.chkRugs.Location = New System.Drawing.Point(115, 182)
        Me.chkRugs.Name = "chkRugs"
        Me.chkRugs.Size = New System.Drawing.Size(51, 17)
        Me.chkRugs.TabIndex = 2
        Me.chkRugs.Tag = "Rugs"
        Me.chkRugs.Text = "Rugs"
        Me.chkRugs.UseVisualStyleBackColor = True
        '
        'grpScale
        '
        Me.grpScale.Controls.Add(Me.rdoResponse)
        Me.grpScale.Controls.Add(Me.rdoLinear)
        Me.grpScale.Location = New System.Drawing.Point(178, 33)
        Me.grpScale.Name = "grpScale"
        Me.grpScale.Size = New System.Drawing.Size(112, 75)
        Me.grpScale.TabIndex = 6
        Me.grpScale.TabStop = False
        Me.grpScale.Tag = "Scale"
        Me.grpScale.Text = "Scale"
        '
        'rdoResponse
        '
        Me.rdoResponse.AutoSize = True
        Me.rdoResponse.Location = New System.Drawing.Point(6, 42)
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
        Me.rdoLinear.Location = New System.Drawing.Point(6, 19)
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
        Me.grpPlotType.Location = New System.Drawing.Point(10, 33)
        Me.grpPlotType.Name = "grpPlotType"
        Me.grpPlotType.Size = New System.Drawing.Size(111, 75)
        Me.grpPlotType.TabIndex = 5
        Me.grpPlotType.TabStop = False
        Me.grpPlotType.Tag = "Plot_type"
        Me.grpPlotType.Text = "Plot type"
        '
        'rdoContrast
        '
        Me.rdoContrast.AutoSize = True
        Me.rdoContrast.Location = New System.Drawing.Point(10, 42)
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
        Me.rdoConditional.Location = New System.Drawing.Point(10, 19)
        Me.rdoConditional.Name = "rdoConditional"
        Me.rdoConditional.Size = New System.Drawing.Size(77, 17)
        Me.rdoConditional.TabIndex = 2
        Me.rdoConditional.Tag = "Conditional"
        Me.rdoConditional.Text = "Conditional"
        Me.rdoConditional.UseVisualStyleBackColor = True
        '
        'tbResiduals
        '
        Me.tbResiduals.Controls.Add(Me.chkIndividualPlots)
        Me.tbResiduals.Controls.Add(Me.chkMultiplePlots)
        Me.tbResiduals.Controls.Add(Me.grpIndividualPlots)
        Me.tbResiduals.Controls.Add(Me.grpMultiplePlots)
        Me.tbResiduals.Location = New System.Drawing.Point(4, 22)
        Me.tbResiduals.Name = "tbResiduals"
        Me.tbResiduals.Padding = New System.Windows.Forms.Padding(3)
        Me.tbResiduals.Size = New System.Drawing.Size(296, 281)
        Me.tbResiduals.TabIndex = 1
        Me.tbResiduals.Tag = "Residuals"
        Me.tbResiduals.Text = "Residuals"
        Me.tbResiduals.UseVisualStyleBackColor = True
        '
        'chkIndividualPlots
        '
        Me.chkIndividualPlots.AutoSize = True
        Me.chkIndividualPlots.Location = New System.Drawing.Point(10, 127)
        Me.chkIndividualPlots.Name = "chkIndividualPlots"
        Me.chkIndividualPlots.Size = New System.Drawing.Size(97, 17)
        Me.chkIndividualPlots.TabIndex = 3
        Me.chkIndividualPlots.TabStop = False
        Me.chkIndividualPlots.Tag = "Individual_Plots"
        Me.chkIndividualPlots.Text = "Individual Plots"
        Me.chkIndividualPlots.UseVisualStyleBackColor = True
        '
        'chkMultiplePlots
        '
        Me.chkMultiplePlots.AutoSize = True
        Me.chkMultiplePlots.Location = New System.Drawing.Point(10, 10)
        Me.chkMultiplePlots.Name = "chkMultiplePlots"
        Me.chkMultiplePlots.Size = New System.Drawing.Size(88, 17)
        Me.chkMultiplePlots.TabIndex = 2
        Me.chkMultiplePlots.Tag = "Multiple_Plots"
        Me.chkMultiplePlots.Text = "Multiple Plots"
        Me.chkMultiplePlots.UseVisualStyleBackColor = True
        '
        'grpIndividualPlots
        '
        Me.grpIndividualPlots.Controls.Add(Me.rdoCooksDistanceLeverage)
        Me.grpIndividualPlots.Controls.Add(Me.rdoCooksDistance)
        Me.grpIndividualPlots.Controls.Add(Me.rdoResidualsLeverage)
        Me.grpIndividualPlots.Controls.Add(Me.rdoScaleLocation)
        Me.grpIndividualPlots.Controls.Add(Me.rdoQQ)
        Me.grpIndividualPlots.Controls.Add(Me.rdoResidualsFitted)
        Me.grpIndividualPlots.Location = New System.Drawing.Point(10, 149)
        Me.grpIndividualPlots.Name = "grpIndividualPlots"
        Me.grpIndividualPlots.Size = New System.Drawing.Size(278, 89)
        Me.grpIndividualPlots.TabIndex = 1
        Me.grpIndividualPlots.TabStop = False
        Me.grpIndividualPlots.Tag = ""
        '
        'rdoCooksDistanceLeverage
        '
        Me.rdoCooksDistanceLeverage.AutoSize = True
        Me.rdoCooksDistanceLeverage.Location = New System.Drawing.Point(10, 65)
        Me.rdoCooksDistanceLeverage.Name = "rdoCooksDistanceLeverage"
        Me.rdoCooksDistanceLeverage.Size = New System.Drawing.Size(159, 17)
        Me.rdoCooksDistanceLeverage.TabIndex = 6
        Me.rdoCooksDistanceLeverage.TabStop = True
        Me.rdoCooksDistanceLeverage.Tag = "Cook's_Distance_v_Leverage"
        Me.rdoCooksDistanceLeverage.Text = "Cook's Distance v Leverage"
        Me.rdoCooksDistanceLeverage.UseVisualStyleBackColor = True
        '
        'rdoCooksDistance
        '
        Me.rdoCooksDistance.AutoSize = True
        Me.rdoCooksDistance.Location = New System.Drawing.Point(174, 65)
        Me.rdoCooksDistance.Name = "rdoCooksDistance"
        Me.rdoCooksDistance.Size = New System.Drawing.Size(102, 17)
        Me.rdoCooksDistance.TabIndex = 5
        Me.rdoCooksDistance.TabStop = True
        Me.rdoCooksDistance.Tag = "Cook's_Distance"
        Me.rdoCooksDistance.Text = "Cook's Distance"
        Me.rdoCooksDistance.UseVisualStyleBackColor = True
        '
        'rdoResidualsLeverage
        '
        Me.rdoResidualsLeverage.AutoSize = True
        Me.rdoResidualsLeverage.Location = New System.Drawing.Point(10, 42)
        Me.rdoResidualsLeverage.Name = "rdoResidualsLeverage"
        Me.rdoResidualsLeverage.Size = New System.Drawing.Size(128, 17)
        Me.rdoResidualsLeverage.TabIndex = 4
        Me.rdoResidualsLeverage.TabStop = True
        Me.rdoResidualsLeverage.Tag = "Residuals_v_Leverage"
        Me.rdoResidualsLeverage.Text = "Residuals v Leverage"
        Me.rdoResidualsLeverage.UseVisualStyleBackColor = True
        '
        'rdoScaleLocation
        '
        Me.rdoScaleLocation.AutoSize = True
        Me.rdoScaleLocation.Location = New System.Drawing.Point(174, 42)
        Me.rdoScaleLocation.Name = "rdoScaleLocation"
        Me.rdoScaleLocation.Size = New System.Drawing.Size(96, 17)
        Me.rdoScaleLocation.TabIndex = 3
        Me.rdoScaleLocation.TabStop = True
        Me.rdoScaleLocation.Tag = "Scale-Location"
        Me.rdoScaleLocation.Text = "Scale-Location"
        Me.rdoScaleLocation.UseVisualStyleBackColor = True
        '
        'rdoQQ
        '
        Me.rdoQQ.AutoSize = True
        Me.rdoQQ.Location = New System.Drawing.Point(174, 19)
        Me.rdoQQ.Name = "rdoQQ"
        Me.rdoQQ.Size = New System.Drawing.Size(44, 17)
        Me.rdoQQ.TabIndex = 2
        Me.rdoQQ.TabStop = True
        Me.rdoQQ.Tag = "Q-Q"
        Me.rdoQQ.Text = "Q-Q"
        Me.rdoQQ.UseVisualStyleBackColor = True
        '
        'rdoResidualsFitted
        '
        Me.rdoResidualsFitted.AutoSize = True
        Me.rdoResidualsFitted.Location = New System.Drawing.Point(10, 19)
        Me.rdoResidualsFitted.Name = "rdoResidualsFitted"
        Me.rdoResidualsFitted.Size = New System.Drawing.Size(109, 17)
        Me.rdoResidualsFitted.TabIndex = 1
        Me.rdoResidualsFitted.TabStop = True
        Me.rdoResidualsFitted.Tag = "Residuals_v_Fitted"
        Me.rdoResidualsFitted.Text = "Residuals v Fitted"
        Me.rdoResidualsFitted.UseVisualStyleBackColor = True
        '
        'grpMultiplePlots
        '
        Me.grpMultiplePlots.Controls.Add(Me.rdoSixPlots3Rows)
        Me.grpMultiplePlots.Controls.Add(Me.rdoFourPlots)
        Me.grpMultiplePlots.Controls.Add(Me.rdoSixPlots2Rows)
        Me.grpMultiplePlots.Location = New System.Drawing.Point(10, 33)
        Me.grpMultiplePlots.Name = "grpMultiplePlots"
        Me.grpMultiplePlots.Size = New System.Drawing.Size(278, 78)
        Me.grpMultiplePlots.TabIndex = 0
        Me.grpMultiplePlots.TabStop = False
        Me.grpMultiplePlots.Tag = ""
        '
        'rdoSixPlots3Rows
        '
        Me.rdoSixPlots3Rows.AutoSize = True
        Me.rdoSixPlots3Rows.Location = New System.Drawing.Point(174, 19)
        Me.rdoSixPlots3Rows.Name = "rdoSixPlots3Rows"
        Me.rdoSixPlots3Rows.Size = New System.Drawing.Size(102, 17)
        Me.rdoSixPlots3Rows.TabIndex = 2
        Me.rdoSixPlots3Rows.TabStop = True
        Me.rdoSixPlots3Rows.Tag = "Six_Plots(3 rows)"
        Me.rdoSixPlots3Rows.Text = "Six Plots(3 rows)"
        Me.rdoSixPlots3Rows.UseVisualStyleBackColor = True
        '
        'rdoFourPlots
        '
        Me.rdoFourPlots.AutoSize = True
        Me.rdoFourPlots.Location = New System.Drawing.Point(10, 19)
        Me.rdoFourPlots.Name = "rdoFourPlots"
        Me.rdoFourPlots.Size = New System.Drawing.Size(72, 17)
        Me.rdoFourPlots.TabIndex = 1
        Me.rdoFourPlots.TabStop = True
        Me.rdoFourPlots.Tag = "Four_Plots"
        Me.rdoFourPlots.Text = "Four Plots"
        Me.rdoFourPlots.UseVisualStyleBackColor = True
        '
        'rdoSixPlots2Rows
        '
        Me.rdoSixPlots2Rows.AutoSize = True
        Me.rdoSixPlots2Rows.Location = New System.Drawing.Point(10, 42)
        Me.rdoSixPlots2Rows.Name = "rdoSixPlots2Rows"
        Me.rdoSixPlots2Rows.Size = New System.Drawing.Size(105, 17)
        Me.rdoSixPlots2Rows.TabIndex = 0
        Me.rdoSixPlots2Rows.TabStop = True
        Me.rdoSixPlots2Rows.Tag = "Six_Plots(2 rows)"
        Me.rdoSixPlots2Rows.Text = "Six_Plots(2 rows)"
        Me.rdoSixPlots2Rows.UseVisualStyleBackColor = True
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
        Me.tbDisplay.Size = New System.Drawing.Size(313, 316)
        Me.tbDisplay.TabIndex = 0
        Me.tbDisplay.Tag = "Display"
        Me.tbDisplay.Text = "Display"
        Me.tbDisplay.UseVisualStyleBackColor = True
        '
        'chkDisplayCLimits
        '
        Me.chkDisplayCLimits.AutoSize = True
        Me.chkDisplayCLimits.Location = New System.Drawing.Point(10, 91)
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
        Me.nudDisplayCLevel.Location = New System.Drawing.Point(147, 108)
        Me.nudDisplayCLevel.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDisplayCLevel.Name = "nudDisplayCLevel"
        Me.nudDisplayCLevel.Size = New System.Drawing.Size(45, 20)
        Me.nudDisplayCLevel.TabIndex = 6
        Me.nudDisplayCLevel.Value = New Decimal(New Integer() {95, 0, 0, 131072})
        '
        'lblDisplayCLevel
        '
        Me.lblDisplayCLevel.AutoSize = True
        Me.lblDisplayCLevel.Location = New System.Drawing.Point(49, 111)
        Me.lblDisplayCLevel.Name = "lblDisplayCLevel"
        Me.lblDisplayCLevel.Size = New System.Drawing.Size(93, 13)
        Me.lblDisplayCLevel.TabIndex = 5
        Me.lblDisplayCLevel.Tag = "Confidence_Level:"
        Me.lblDisplayCLevel.Text = "Confidence Level:"
        '
        'chkEstimates
        '
        Me.chkEstimates.AutoSize = True
        Me.chkEstimates.Location = New System.Drawing.Point(10, 66)
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
        Me.chkPvalues.Location = New System.Drawing.Point(125, 41)
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
        Me.chkANOVA.Location = New System.Drawing.Point(10, 41)
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
        Me.chkModel.Location = New System.Drawing.Point(10, 16)
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
        Me.tbRegOptions.Size = New System.Drawing.Size(321, 342)
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
        Me.tbSave.Size = New System.Drawing.Size(313, 316)
        Me.tbSave.TabIndex = 2
        Me.tbSave.Tag = "Save"
        Me.tbSave.Text = "Save"
        Me.tbSave.UseVisualStyleBackColor = True
        '
        'ucrLeverageColumnName
        '
        Me.ucrLeverageColumnName.IsReadOnly = False
        Me.ucrLeverageColumnName.Location = New System.Drawing.Point(115, 93)
        Me.ucrLeverageColumnName.Name = "ucrLeverageColumnName"
        Me.ucrLeverageColumnName.Size = New System.Drawing.Size(115, 21)
        Me.ucrLeverageColumnName.TabIndex = 19
        '
        'ucrStdResidualsColumnName
        '
        Me.ucrStdResidualsColumnName.IsReadOnly = False
        Me.ucrStdResidualsColumnName.Location = New System.Drawing.Point(115, 66)
        Me.ucrStdResidualsColumnName.Name = "ucrStdResidualsColumnName"
        Me.ucrStdResidualsColumnName.Size = New System.Drawing.Size(115, 21)
        Me.ucrStdResidualsColumnName.TabIndex = 17
        '
        'ucrResidualsColumnName
        '
        Me.ucrResidualsColumnName.IsReadOnly = False
        Me.ucrResidualsColumnName.Location = New System.Drawing.Point(115, 39)
        Me.ucrResidualsColumnName.Name = "ucrResidualsColumnName"
        Me.ucrResidualsColumnName.Size = New System.Drawing.Size(115, 21)
        Me.ucrResidualsColumnName.TabIndex = 15
        '
        'ucrFittedColumnName
        '
        Me.ucrFittedColumnName.IsReadOnly = False
        Me.ucrFittedColumnName.Location = New System.Drawing.Point(115, 12)
        Me.ucrFittedColumnName.Name = "ucrFittedColumnName"
        Me.ucrFittedColumnName.Size = New System.Drawing.Size(115, 21)
        Me.ucrFittedColumnName.TabIndex = 13
        '
        'chkFittedValues
        '
        Me.chkFittedValues.AutoSize = True
        Me.chkFittedValues.Location = New System.Drawing.Point(10, 16)
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
        Me.chkResiduals.Location = New System.Drawing.Point(10, 41)
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
        Me.chkStdResiduals.Location = New System.Drawing.Point(10, 66)
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
        Me.chkLeverage.Location = New System.Drawing.Point(10, 91)
        Me.chkLeverage.Name = "chkLeverage"
        Me.chkLeverage.Size = New System.Drawing.Size(71, 17)
        Me.chkLeverage.TabIndex = 1
        Me.chkLeverage.Tag = "Leverage"
        Me.chkLeverage.Text = "Leverage"
        Me.chkLeverage.UseVisualStyleBackColor = True
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.Location = New System.Drawing.Point(94, 347)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(142, 30)
        Me.ucrSdgButtons.TabIndex = 0
        '
        'sdgSimpleRegOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 378)
        Me.Controls.Add(Me.tbRegOptions)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgSimpleRegOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Graph_and_Display_Options"
        Me.Text = "Graph and Display Options"
        Me.tbGraphics.ResumeLayout(False)
        Me.tcGraphics.ResumeLayout(False)
        Me.tbModel.ResumeLayout(False)
        Me.tbModel.PerformLayout()
        Me.grpRugs.ResumeLayout(False)
        Me.grpRugs.PerformLayout()
        CType(Me.nudWhiteSpace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGraphicsCLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpScale.ResumeLayout(False)
        Me.grpScale.PerformLayout()
        Me.grpPlotType.ResumeLayout(False)
        Me.grpPlotType.PerformLayout()
        Me.tbResiduals.ResumeLayout(False)
        Me.tbResiduals.PerformLayout()
        Me.grpIndividualPlots.ResumeLayout(False)
        Me.grpIndividualPlots.PerformLayout()
        Me.grpMultiplePlots.ResumeLayout(False)
        Me.grpMultiplePlots.PerformLayout()
        Me.tbDisplay.ResumeLayout(False)
        Me.tbDisplay.PerformLayout()
        CType(Me.nudDisplayCLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbRegOptions.ResumeLayout(False)
        Me.tbSave.ResumeLayout(False)
        Me.tbSave.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents tbGraphics As TabPage
    Friend WithEvents chkFittedModel As CheckBox
    Friend WithEvents nudGraphicsCLevel As NumericUpDown
    Friend WithEvents lblGraphicsSignLevel As Label
    Friend WithEvents grpMultiplePlots As GroupBox
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
    Friend WithEvents chkJitter As CheckBox
    Friend WithEvents nudWhiteSpace As NumericUpDown
    Friend WithEvents lblWhiteSpace As Label
    Friend WithEvents chkPartial As CheckBox
    Friend WithEvents rdoPartial As RadioButton
    Friend WithEvents grpRugs As GroupBox
    Friend WithEvents tcGraphics As TabControl
    Friend WithEvents tbModel As TabPage
    Friend WithEvents tbResiduals As TabPage
    Friend WithEvents grpIndividualPlots As GroupBox
    Friend WithEvents rdoCooksDistanceLeverage As RadioButton
    Friend WithEvents rdoCooksDistance As RadioButton
    Friend WithEvents rdoResidualsLeverage As RadioButton
    Friend WithEvents rdoScaleLocation As RadioButton
    Friend WithEvents rdoQQ As RadioButton
    Friend WithEvents rdoResidualsFitted As RadioButton
    Friend WithEvents rdoSixPlots3Rows As RadioButton
    Friend WithEvents rdoFourPlots As RadioButton
    Friend WithEvents rdoSixPlots2Rows As RadioButton
    Friend WithEvents chkMultiplePlots As CheckBox
    Friend WithEvents chkIndividualPlots As CheckBox
    Friend WithEvents chkConfIntervalband As CheckBox
End Class
