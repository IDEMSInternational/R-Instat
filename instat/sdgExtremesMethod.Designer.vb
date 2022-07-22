<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgExtremesMethod
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
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.ucrPanelExtreme = New instat.UcrPanel()
        Me.tbRegOptions = New System.Windows.Forms.TabControl()
        Me.tbFitMethod = New System.Windows.Forms.TabPage()
        Me.grpInitialValues = New System.Windows.Forms.GroupBox()
        Me.ucrNudIterations = New instat.ucrNud()
        Me.lblNumberOfIterations = New System.Windows.Forms.Label()
        Me.ucrNudLocationPrior = New instat.ucrNud()
        Me.ucrNudScalePrior = New instat.ucrNud()
        Me.ucrNudShapePrior = New instat.ucrNud()
        Me.ucrNudLocationInitial = New instat.ucrNud()
        Me.ucrNudScaleInitial = New instat.ucrNud()
        Me.ucrNudShapeInitial = New instat.ucrNud()
        Me.lblLocationInitial = New System.Windows.Forms.Label()
        Me.lblScaleInitial = New System.Windows.Forms.Label()
        Me.lblShapeInitial = New System.Windows.Forms.Label()
        Me.lblLocationPrior = New System.Windows.Forms.Label()
        Me.lblScalePrior = New System.Windows.Forms.Label()
        Me.lblShapePrior = New System.Windows.Forms.Label()
        Me.rdoLmoments = New System.Windows.Forms.RadioButton()
        Me.rdoBayesian = New System.Windows.Forms.RadioButton()
        Me.rdoGMLE = New System.Windows.Forms.RadioButton()
        Me.rdoMLE = New System.Windows.Forms.RadioButton()
        Me.grpPriorParameters = New System.Windows.Forms.GroupBox()
        Me.tbDisplayOptions = New System.Windows.Forms.TabPage()
        Me.ucrSavePlots = New instat.ucrSave()
        Me.grpPlots = New System.Windows.Forms.GroupBox()
        Me.rdoNoPlot = New System.Windows.Forms.RadioButton()
        Me.rdoTrace = New System.Windows.Forms.RadioButton()
        Me.rdoRlplot = New System.Windows.Forms.RadioButton()
        Me.rdoHist = New System.Windows.Forms.RadioButton()
        Me.rdoDensity = New System.Windows.Forms.RadioButton()
        Me.rdoZPlot = New System.Windows.Forms.RadioButton()
        Me.rdoProbprob = New System.Windows.Forms.RadioButton()
        Me.rdoQQPlot = New System.Windows.Forms.RadioButton()
        Me.rdoQQ2 = New System.Windows.Forms.RadioButton()
        Me.rdoPrimary = New System.Windows.Forms.RadioButton()
        Me.ucrPnlExtreme = New instat.UcrPanel()
        Me.tbConfidenceInterval = New System.Windows.Forms.TabPage()
        Me.lblReturnLevel = New System.Windows.Forms.Label()
        Me.ucrNudReturnLevel = New instat.ucrNud()
        Me.ucrInputType = New instat.ucrInputComboBox()
        Me.ucrChkType = New instat.ucrCheck()
        Me.tbRegOptions.SuspendLayout()
        Me.tbFitMethod.SuspendLayout()
        Me.tbDisplayOptions.SuspendLayout()
        Me.grpPlots.SuspendLayout()
        Me.tbConfidenceInterval.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.Location = New System.Drawing.Point(9, 518)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(336, 45)
        Me.ucrBase.TabIndex = 5
        '
        'ucrPanelExtreme
        '
        Me.ucrPanelExtreme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPanelExtreme.Location = New System.Drawing.Point(8, 16)
        Me.ucrPanelExtreme.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPanelExtreme.Name = "ucrPanelExtreme"
        Me.ucrPanelExtreme.Size = New System.Drawing.Size(320, 178)
        Me.ucrPanelExtreme.TabIndex = 0
        '
        'tbRegOptions
        '
        Me.tbRegOptions.Controls.Add(Me.tbFitMethod)
        Me.tbRegOptions.Controls.Add(Me.tbDisplayOptions)
        Me.tbRegOptions.Controls.Add(Me.tbConfidenceInterval)
        Me.tbRegOptions.Location = New System.Drawing.Point(5, 6)
        Me.tbRegOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.tbRegOptions.Name = "tbRegOptions"
        Me.tbRegOptions.SelectedIndex = 0
        Me.tbRegOptions.Size = New System.Drawing.Size(557, 461)
        Me.tbRegOptions.TabIndex = 6
        '
        'tbFitMethod
        '
        Me.tbFitMethod.Controls.Add(Me.ucrNudIterations)
        Me.tbFitMethod.Controls.Add(Me.lblNumberOfIterations)
        Me.tbFitMethod.Controls.Add(Me.ucrNudLocationPrior)
        Me.tbFitMethod.Controls.Add(Me.ucrNudScalePrior)
        Me.tbFitMethod.Controls.Add(Me.ucrNudShapePrior)
        Me.tbFitMethod.Controls.Add(Me.ucrNudLocationInitial)
        Me.tbFitMethod.Controls.Add(Me.ucrNudScaleInitial)
        Me.tbFitMethod.Controls.Add(Me.ucrNudShapeInitial)
        Me.tbFitMethod.Controls.Add(Me.lblLocationInitial)
        Me.tbFitMethod.Controls.Add(Me.lblScaleInitial)
        Me.tbFitMethod.Controls.Add(Me.lblShapeInitial)
        Me.tbFitMethod.Controls.Add(Me.lblLocationPrior)
        Me.tbFitMethod.Controls.Add(Me.lblScalePrior)
        Me.tbFitMethod.Controls.Add(Me.lblShapePrior)
        Me.tbFitMethod.Controls.Add(Me.rdoLmoments)
        Me.tbFitMethod.Controls.Add(Me.rdoBayesian)
        Me.tbFitMethod.Controls.Add(Me.rdoGMLE)
        Me.tbFitMethod.Controls.Add(Me.rdoMLE)
        Me.tbFitMethod.Controls.Add(Me.grpPriorParameters)
        Me.tbFitMethod.Controls.Add(Me.grpInitialValues)
        Me.tbFitMethod.Location = New System.Drawing.Point(4, 29)
        Me.tbFitMethod.Margin = New System.Windows.Forms.Padding(4)
        Me.tbFitMethod.Name = "tbFitMethod"
        Me.tbFitMethod.Padding = New System.Windows.Forms.Padding(4)
        Me.tbFitMethod.Size = New System.Drawing.Size(549, 428)
        Me.tbFitMethod.TabIndex = 0
        Me.tbFitMethod.Tag = "Display"
        Me.tbFitMethod.Text = "Fit Method"
        Me.tbFitMethod.UseVisualStyleBackColor = True
        '
        'grpInitialValues
        '
        Me.grpInitialValues.Location = New System.Drawing.Point(333, 195)
        Me.grpInitialValues.Name = "grpInitialValues"
        Me.grpInitialValues.Size = New System.Drawing.Size(214, 136)
        Me.grpInitialValues.TabIndex = 24
        Me.grpInitialValues.TabStop = False
        Me.grpInitialValues.Text = "Initial Values"
        '
        'ucrNudIterations
        '
        Me.ucrNudIterations.AutoSize = True
        Me.ucrNudIterations.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudIterations.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudIterations.Location = New System.Drawing.Point(197, 348)
        Me.ucrNudIterations.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudIterations.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudIterations.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudIterations.Name = "ucrNudIterations"
        Me.ucrNudIterations.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudIterations.TabIndex = 22
        Me.ucrNudIterations.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNumberOfIterations
        '
        Me.lblNumberOfIterations.AutoSize = True
        Me.lblNumberOfIterations.Location = New System.Drawing.Point(26, 352)
        Me.lblNumberOfIterations.Name = "lblNumberOfIterations"
        Me.lblNumberOfIterations.Size = New System.Drawing.Size(158, 20)
        Me.lblNumberOfIterations.TabIndex = 21
        Me.lblNumberOfIterations.Text = "Number of Iterations:"
        '
        'ucrNudLocationPrior
        '
        Me.ucrNudLocationPrior.AutoSize = True
        Me.ucrNudLocationPrior.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLocationPrior.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLocationPrior.Location = New System.Drawing.Point(142, 216)
        Me.ucrNudLocationPrior.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudLocationPrior.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLocationPrior.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLocationPrior.Name = "ucrNudLocationPrior"
        Me.ucrNudLocationPrior.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudLocationPrior.TabIndex = 20
        Me.ucrNudLocationPrior.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudScalePrior
        '
        Me.ucrNudScalePrior.AutoSize = True
        Me.ucrNudScalePrior.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudScalePrior.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudScalePrior.Location = New System.Drawing.Point(139, 256)
        Me.ucrNudScalePrior.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudScalePrior.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudScalePrior.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudScalePrior.Name = "ucrNudScalePrior"
        Me.ucrNudScalePrior.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudScalePrior.TabIndex = 19
        Me.ucrNudScalePrior.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudShapePrior
        '
        Me.ucrNudShapePrior.AutoSize = True
        Me.ucrNudShapePrior.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShapePrior.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudShapePrior.Location = New System.Drawing.Point(143, 299)
        Me.ucrNudShapePrior.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudShapePrior.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudShapePrior.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShapePrior.Name = "ucrNudShapePrior"
        Me.ucrNudShapePrior.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudShapePrior.TabIndex = 18
        Me.ucrNudShapePrior.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLocationInitial
        '
        Me.ucrNudLocationInitial.AutoSize = True
        Me.ucrNudLocationInitial.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLocationInitial.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLocationInitial.Location = New System.Drawing.Point(448, 219)
        Me.ucrNudLocationInitial.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudLocationInitial.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLocationInitial.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLocationInitial.Name = "ucrNudLocationInitial"
        Me.ucrNudLocationInitial.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudLocationInitial.TabIndex = 17
        Me.ucrNudLocationInitial.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudScaleInitial
        '
        Me.ucrNudScaleInitial.AutoSize = True
        Me.ucrNudScaleInitial.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudScaleInitial.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudScaleInitial.Location = New System.Drawing.Point(448, 262)
        Me.ucrNudScaleInitial.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudScaleInitial.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudScaleInitial.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudScaleInitial.Name = "ucrNudScaleInitial"
        Me.ucrNudScaleInitial.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudScaleInitial.TabIndex = 16
        Me.ucrNudScaleInitial.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudShapeInitial
        '
        Me.ucrNudShapeInitial.AutoSize = True
        Me.ucrNudShapeInitial.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShapeInitial.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudShapeInitial.Location = New System.Drawing.Point(452, 301)
        Me.ucrNudShapeInitial.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudShapeInitial.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudShapeInitial.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShapeInitial.Name = "ucrNudShapeInitial"
        Me.ucrNudShapeInitial.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudShapeInitial.TabIndex = 15
        Me.ucrNudShapeInitial.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLocationInitial
        '
        Me.lblLocationInitial.AutoSize = True
        Me.lblLocationInitial.Location = New System.Drawing.Point(340, 223)
        Me.lblLocationInitial.Name = "lblLocationInitial"
        Me.lblLocationInitial.Size = New System.Drawing.Size(74, 20)
        Me.lblLocationInitial.TabIndex = 14
        Me.lblLocationInitial.Text = "Location:"
        Me.lblLocationInitial.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblScaleInitial
        '
        Me.lblScaleInitial.AutoSize = True
        Me.lblScaleInitial.Location = New System.Drawing.Point(341, 267)
        Me.lblScaleInitial.Name = "lblScaleInitial"
        Me.lblScaleInitial.Size = New System.Drawing.Size(53, 20)
        Me.lblScaleInitial.TabIndex = 13
        Me.lblScaleInitial.Text = "Scale:"
        '
        'lblShapeInitial
        '
        Me.lblShapeInitial.AutoSize = True
        Me.lblShapeInitial.Location = New System.Drawing.Point(343, 305)
        Me.lblShapeInitial.Name = "lblShapeInitial"
        Me.lblShapeInitial.Size = New System.Drawing.Size(60, 20)
        Me.lblShapeInitial.TabIndex = 12
        Me.lblShapeInitial.Text = "Shape:"
        '
        'lblLocationPrior
        '
        Me.lblLocationPrior.AutoSize = True
        Me.lblLocationPrior.Location = New System.Drawing.Point(23, 220)
        Me.lblLocationPrior.Name = "lblLocationPrior"
        Me.lblLocationPrior.Size = New System.Drawing.Size(74, 20)
        Me.lblLocationPrior.TabIndex = 11
        Me.lblLocationPrior.Text = "Location:"
        '
        'lblScalePrior
        '
        Me.lblScalePrior.AutoSize = True
        Me.lblScalePrior.Location = New System.Drawing.Point(31, 260)
        Me.lblScalePrior.Name = "lblScalePrior"
        Me.lblScalePrior.Size = New System.Drawing.Size(53, 20)
        Me.lblScalePrior.TabIndex = 10
        Me.lblScalePrior.Text = "Scale:"
        '
        'lblShapePrior
        '
        Me.lblShapePrior.AutoSize = True
        Me.lblShapePrior.Location = New System.Drawing.Point(31, 297)
        Me.lblShapePrior.Name = "lblShapePrior"
        Me.lblShapePrior.Size = New System.Drawing.Size(60, 20)
        Me.lblShapePrior.TabIndex = 9
        Me.lblShapePrior.Text = "Shape:"
        '
        'rdoLmoments
        '
        Me.rdoLmoments.AutoSize = True
        Me.rdoLmoments.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLmoments.Location = New System.Drawing.Point(20, 151)
        Me.rdoLmoments.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoLmoments.Name = "rdoLmoments"
        Me.rdoLmoments.Size = New System.Drawing.Size(114, 24)
        Me.rdoLmoments.TabIndex = 8
        Me.rdoLmoments.TabStop = True
        Me.rdoLmoments.Text = "L-moments"
        Me.rdoLmoments.UseVisualStyleBackColor = True
        '
        'rdoBayesian
        '
        Me.rdoBayesian.AutoSize = True
        Me.rdoBayesian.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBayesian.Location = New System.Drawing.Point(20, 116)
        Me.rdoBayesian.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoBayesian.Name = "rdoBayesian"
        Me.rdoBayesian.Size = New System.Drawing.Size(99, 24)
        Me.rdoBayesian.TabIndex = 7
        Me.rdoBayesian.TabStop = True
        Me.rdoBayesian.Text = "Bayesian"
        Me.rdoBayesian.UseVisualStyleBackColor = True
        '
        'rdoGMLE
        '
        Me.rdoGMLE.AutoSize = True
        Me.rdoGMLE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGMLE.Location = New System.Drawing.Point(20, 63)
        Me.rdoGMLE.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoGMLE.Name = "rdoGMLE"
        Me.rdoGMLE.Size = New System.Drawing.Size(309, 44)
        Me.rdoGMLE.TabIndex = 6
        Me.rdoGMLE.TabStop = True
        Me.rdoGMLE.Text = "General Maximum Likelihood Estimator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(GMLE)"
        Me.rdoGMLE.UseVisualStyleBackColor = True
        '
        'rdoMLE
        '
        Me.rdoMLE.AutoSize = True
        Me.rdoMLE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMLE.Location = New System.Drawing.Point(20, 27)
        Me.rdoMLE.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoMLE.Name = "rdoMLE"
        Me.rdoMLE.Size = New System.Drawing.Size(223, 24)
        Me.rdoMLE.TabIndex = 5
        Me.rdoMLE.TabStop = True
        Me.rdoMLE.Text = "Maximum Likelihood (MLE)"
        Me.rdoMLE.UseVisualStyleBackColor = True
        '
        'grpPriorParameters
        '
        Me.grpPriorParameters.Location = New System.Drawing.Point(20, 182)
        Me.grpPriorParameters.Name = "grpPriorParameters"
        Me.grpPriorParameters.Size = New System.Drawing.Size(233, 149)
        Me.grpPriorParameters.TabIndex = 23
        Me.grpPriorParameters.TabStop = False
        Me.grpPriorParameters.Text = "Prior Parameters"
        '
        'tbDisplayOptions
        '
        Me.tbDisplayOptions.Controls.Add(Me.ucrSavePlots)
        Me.tbDisplayOptions.Controls.Add(Me.grpPlots)
        Me.tbDisplayOptions.Location = New System.Drawing.Point(4, 29)
        Me.tbDisplayOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDisplayOptions.Name = "tbDisplayOptions"
        Me.tbDisplayOptions.Padding = New System.Windows.Forms.Padding(4)
        Me.tbDisplayOptions.Size = New System.Drawing.Size(549, 428)
        Me.tbDisplayOptions.TabIndex = 1
        Me.tbDisplayOptions.Tag = "Graphics"
        Me.tbDisplayOptions.Text = "Display Options"
        Me.tbDisplayOptions.UseVisualStyleBackColor = True
        '
        'ucrSavePlots
        '
        Me.ucrSavePlots.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSavePlots.Location = New System.Drawing.Point(29, 238)
        Me.ucrSavePlots.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSavePlots.Name = "ucrSavePlots"
        Me.ucrSavePlots.Size = New System.Drawing.Size(392, 36)
        Me.ucrSavePlots.TabIndex = 3
        '
        'grpPlots
        '
        Me.grpPlots.Controls.Add(Me.rdoNoPlot)
        Me.grpPlots.Controls.Add(Me.rdoTrace)
        Me.grpPlots.Controls.Add(Me.rdoRlplot)
        Me.grpPlots.Controls.Add(Me.rdoHist)
        Me.grpPlots.Controls.Add(Me.rdoDensity)
        Me.grpPlots.Controls.Add(Me.rdoZPlot)
        Me.grpPlots.Controls.Add(Me.rdoProbprob)
        Me.grpPlots.Controls.Add(Me.rdoQQPlot)
        Me.grpPlots.Controls.Add(Me.rdoQQ2)
        Me.grpPlots.Controls.Add(Me.rdoPrimary)
        Me.grpPlots.Controls.Add(Me.ucrPnlExtreme)
        Me.grpPlots.Location = New System.Drawing.Point(29, 14)
        Me.grpPlots.Margin = New System.Windows.Forms.Padding(4)
        Me.grpPlots.Name = "grpPlots"
        Me.grpPlots.Padding = New System.Windows.Forms.Padding(4)
        Me.grpPlots.Size = New System.Drawing.Size(392, 212)
        Me.grpPlots.TabIndex = 2
        Me.grpPlots.TabStop = False
        Me.grpPlots.Text = "Plots"
        '
        'rdoNoPlot
        '
        Me.rdoNoPlot.AutoSize = True
        Me.rdoNoPlot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNoPlot.Location = New System.Drawing.Point(20, 34)
        Me.rdoNoPlot.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoNoPlot.Name = "rdoNoPlot"
        Me.rdoNoPlot.Size = New System.Drawing.Size(85, 24)
        Me.rdoNoPlot.TabIndex = 1
        Me.rdoNoPlot.Text = "No Plot"
        Me.rdoNoPlot.UseVisualStyleBackColor = True
        '
        'rdoTrace
        '
        Me.rdoTrace.AutoSize = True
        Me.rdoTrace.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTrace.Location = New System.Drawing.Point(20, 172)
        Me.rdoTrace.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoTrace.Name = "rdoTrace"
        Me.rdoTrace.Size = New System.Drawing.Size(105, 24)
        Me.rdoTrace.TabIndex = 5
        Me.rdoTrace.Text = "Trace Plot"
        Me.rdoTrace.UseVisualStyleBackColor = True
        '
        'rdoRlplot
        '
        Me.rdoRlplot.AutoSize = True
        Me.rdoRlplot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRlplot.Location = New System.Drawing.Point(20, 138)
        Me.rdoRlplot.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoRlplot.Name = "rdoRlplot"
        Me.rdoRlplot.Size = New System.Drawing.Size(80, 24)
        Me.rdoRlplot.TabIndex = 4
        Me.rdoRlplot.Text = "Rl Plot"
        Me.rdoRlplot.UseVisualStyleBackColor = True
        '
        'rdoHist
        '
        Me.rdoHist.AutoSize = True
        Me.rdoHist.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHist.Location = New System.Drawing.Point(224, 104)
        Me.rdoHist.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoHist.Name = "rdoHist"
        Me.rdoHist.Size = New System.Drawing.Size(93, 24)
        Me.rdoHist.TabIndex = 8
        Me.rdoHist.Text = "Hist Plot"
        Me.rdoHist.UseVisualStyleBackColor = True
        '
        'rdoDensity
        '
        Me.rdoDensity.AutoSize = True
        Me.rdoDensity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDensity.Location = New System.Drawing.Point(224, 140)
        Me.rdoDensity.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoDensity.Name = "rdoDensity"
        Me.rdoDensity.Size = New System.Drawing.Size(118, 24)
        Me.rdoDensity.TabIndex = 9
        Me.rdoDensity.Text = "Density Plot"
        Me.rdoDensity.UseVisualStyleBackColor = True
        '
        'rdoZPlot
        '
        Me.rdoZPlot.AutoSize = True
        Me.rdoZPlot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoZPlot.Location = New System.Drawing.Point(224, 69)
        Me.rdoZPlot.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoZPlot.Name = "rdoZPlot"
        Me.rdoZPlot.Size = New System.Drawing.Size(101, 24)
        Me.rdoZPlot.TabIndex = 7
        Me.rdoZPlot.Text = "Zplot Plot"
        Me.rdoZPlot.UseVisualStyleBackColor = True
        '
        'rdoProbprob
        '
        Me.rdoProbprob.AutoSize = True
        Me.rdoProbprob.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoProbprob.Location = New System.Drawing.Point(20, 104)
        Me.rdoProbprob.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoProbprob.Name = "rdoProbprob"
        Me.rdoProbprob.Size = New System.Drawing.Size(135, 24)
        Me.rdoProbprob.TabIndex = 3
        Me.rdoProbprob.Text = "Prob-prob Plot"
        Me.rdoProbprob.UseVisualStyleBackColor = True
        '
        'rdoQQPlot
        '
        Me.rdoQQPlot.AutoSize = True
        Me.rdoQQPlot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoQQPlot.Location = New System.Drawing.Point(224, 34)
        Me.rdoQQPlot.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoQQPlot.Name = "rdoQQPlot"
        Me.rdoQQPlot.Size = New System.Drawing.Size(89, 24)
        Me.rdoQQPlot.TabIndex = 6
        Me.rdoQQPlot.Text = "QQ Plot"
        Me.rdoQQPlot.UseVisualStyleBackColor = True
        '
        'rdoQQ2
        '
        Me.rdoQQ2.AutoSize = True
        Me.rdoQQ2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoQQ2.Location = New System.Drawing.Point(224, 172)
        Me.rdoQQ2.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoQQ2.Name = "rdoQQ2"
        Me.rdoQQ2.Size = New System.Drawing.Size(98, 24)
        Me.rdoQQ2.TabIndex = 10
        Me.rdoQQ2.Text = "QQ2 Plot"
        Me.rdoQQ2.UseVisualStyleBackColor = True
        '
        'rdoPrimary
        '
        Me.rdoPrimary.AutoSize = True
        Me.rdoPrimary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPrimary.Location = New System.Drawing.Point(20, 69)
        Me.rdoPrimary.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoPrimary.Name = "rdoPrimary"
        Me.rdoPrimary.Size = New System.Drawing.Size(86, 24)
        Me.rdoPrimary.TabIndex = 2
        Me.rdoPrimary.Text = "Primary"
        Me.rdoPrimary.UseVisualStyleBackColor = True
        '
        'ucrPnlExtreme
        '
        Me.ucrPnlExtreme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlExtreme.Location = New System.Drawing.Point(12, 23)
        Me.ucrPnlExtreme.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlExtreme.Name = "ucrPnlExtreme"
        Me.ucrPnlExtreme.Size = New System.Drawing.Size(358, 176)
        Me.ucrPnlExtreme.TabIndex = 0
        '
        'tbConfidenceInterval
        '
        Me.tbConfidenceInterval.Controls.Add(Me.lblReturnLevel)
        Me.tbConfidenceInterval.Controls.Add(Me.ucrNudReturnLevel)
        Me.tbConfidenceInterval.Controls.Add(Me.ucrInputType)
        Me.tbConfidenceInterval.Controls.Add(Me.ucrChkType)
        Me.tbConfidenceInterval.Location = New System.Drawing.Point(4, 29)
        Me.tbConfidenceInterval.Margin = New System.Windows.Forms.Padding(4)
        Me.tbConfidenceInterval.Name = "tbConfidenceInterval"
        Me.tbConfidenceInterval.Padding = New System.Windows.Forms.Padding(4)
        Me.tbConfidenceInterval.Size = New System.Drawing.Size(549, 428)
        Me.tbConfidenceInterval.TabIndex = 2
        Me.tbConfidenceInterval.Tag = "Save"
        Me.tbConfidenceInterval.Text = "Confidence Interval"
        Me.tbConfidenceInterval.UseVisualStyleBackColor = True
        '
        'lblReturnLevel
        '
        Me.lblReturnLevel.AutoSize = True
        Me.lblReturnLevel.Location = New System.Drawing.Point(356, 17)
        Me.lblReturnLevel.Name = "lblReturnLevel"
        Me.lblReturnLevel.Size = New System.Drawing.Size(103, 20)
        Me.lblReturnLevel.TabIndex = 3
        Me.lblReturnLevel.Text = "Return Level:"
        '
        'ucrNudReturnLevel
        '
        Me.ucrNudReturnLevel.AutoSize = True
        Me.ucrNudReturnLevel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudReturnLevel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudReturnLevel.Location = New System.Drawing.Point(466, 13)
        Me.ucrNudReturnLevel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudReturnLevel.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudReturnLevel.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudReturnLevel.Name = "ucrNudReturnLevel"
        Me.ucrNudReturnLevel.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudReturnLevel.TabIndex = 2
        Me.ucrNudReturnLevel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputType
        '
        Me.ucrInputType.AddQuotesIfUnrecognised = True
        Me.ucrInputType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputType.GetSetSelectedIndex = -1
        Me.ucrInputType.IsReadOnly = False
        Me.ucrInputType.Location = New System.Drawing.Point(174, 13)
        Me.ucrInputType.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputType.Name = "ucrInputType"
        Me.ucrInputType.Size = New System.Drawing.Size(175, 32)
        Me.ucrInputType.TabIndex = 1
        '
        'ucrChkType
        '
        Me.ucrChkType.AutoSize = True
        Me.ucrChkType.Checked = False
        Me.ucrChkType.Location = New System.Drawing.Point(12, 14)
        Me.ucrChkType.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkType.Name = "ucrChkType"
        Me.ucrChkType.Size = New System.Drawing.Size(150, 34)
        Me.ucrChkType.TabIndex = 0
        '
        'sdgExtremesMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(575, 641)
        Me.Controls.Add(Me.tbRegOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPanelExtreme)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgExtremesMethod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extremes Method"
        Me.tbRegOptions.ResumeLayout(False)
        Me.tbFitMethod.ResumeLayout(False)
        Me.tbFitMethod.PerformLayout()
        Me.tbDisplayOptions.ResumeLayout(False)
        Me.grpPlots.ResumeLayout(False)
        Me.grpPlots.PerformLayout()
        Me.tbConfidenceInterval.ResumeLayout(False)
        Me.tbConfidenceInterval.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents ucrPanelExtreme As UcrPanel
    Friend WithEvents tbRegOptions As TabControl
    Friend WithEvents tbFitMethod As TabPage
    Friend WithEvents rdoLmoments As RadioButton
    Friend WithEvents rdoBayesian As RadioButton
    Friend WithEvents rdoGMLE As RadioButton
    Friend WithEvents rdoMLE As RadioButton
    Friend WithEvents tbDisplayOptions As TabPage
    Friend WithEvents tbConfidenceInterval As TabPage
    Friend WithEvents grpPlots As GroupBox
    Friend WithEvents rdoNoPlot As RadioButton
    Friend WithEvents rdoTrace As RadioButton
    Friend WithEvents rdoRlplot As RadioButton
    Friend WithEvents rdoHist As RadioButton
    Friend WithEvents rdoDensity As RadioButton
    Friend WithEvents rdoZPlot As RadioButton
    Friend WithEvents rdoProbprob As RadioButton
    Friend WithEvents rdoQQPlot As RadioButton
    Friend WithEvents rdoQQ2 As RadioButton
    Friend WithEvents rdoPrimary As RadioButton
    Friend WithEvents ucrPnlExtreme As UcrPanel
    Friend WithEvents ucrSavePlots As ucrSave
    Friend WithEvents ucrInputType As ucrInputComboBox
    Friend WithEvents ucrChkType As ucrCheck
    Friend WithEvents ucrNudReturnLevel As ucrNud
    Friend WithEvents lblReturnLevel As Label
    Friend WithEvents lblLocationInitial As Label
    Friend WithEvents lblScaleInitial As Label
    Friend WithEvents lblShapeInitial As Label
    Friend WithEvents lblLocationPrior As Label
    Friend WithEvents lblScalePrior As Label
    Friend WithEvents lblShapePrior As Label
    Friend WithEvents ucrNudLocationPrior As ucrNud
    Friend WithEvents ucrNudScalePrior As ucrNud
    Friend WithEvents ucrNudShapePrior As ucrNud
    Friend WithEvents ucrNudLocationInitial As ucrNud
    Friend WithEvents ucrNudScaleInitial As ucrNud
    Friend WithEvents ucrNudShapeInitial As ucrNud
    Friend WithEvents grpInitialValues As GroupBox
    Friend WithEvents ucrNudIterations As ucrNud
    Friend WithEvents lblNumberOfIterations As Label
    Friend WithEvents grpPriorParameters As GroupBox
End Class
