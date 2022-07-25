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
        Me.tbConfidenceInterval = New System.Windows.Forms.TabPage()
        Me.lblReturnLevel = New System.Windows.Forms.Label()
        Me.ucrInputType = New instat.ucrInputComboBox()
        Me.ucrChkType = New instat.ucrCheck()
        Me.ucrNudReturnLevel = New instat.ucrNud()
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
        Me.tbRegOptions = New System.Windows.Forms.TabControl()
        Me.tbFitMethod = New System.Windows.Forms.TabPage()
        Me.rdoMle = New System.Windows.Forms.RadioButton()
        Me.rdoBayesian = New System.Windows.Forms.RadioButton()
        Me.rdoGMLE = New System.Windows.Forms.RadioButton()
        Me.rdoLmoments = New System.Windows.Forms.RadioButton()
        Me.ucrNudNumberOfIterations = New instat.ucrNud()
        Me.lblNumberOfIterations = New System.Windows.Forms.Label()
        Me.ucrNudLocationPrior = New instat.ucrNud()
        Me.ucrNudScalePrior = New instat.ucrNud()
        Me.ucrNudShapePrior = New instat.ucrNud()
        Me.ucrNudLocationInitial = New instat.ucrNud()
        Me.ucrNudScaleInitial = New instat.ucrNud()
        Me.ucrNudshapeInitial = New instat.ucrNud()
        Me.lblLocationInitial = New System.Windows.Forms.Label()
        Me.lblScaleInitial = New System.Windows.Forms.Label()
        Me.lblShapeInitial = New System.Windows.Forms.Label()
        Me.lblLocationPrior = New System.Windows.Forms.Label()
        Me.lblScalePrior = New System.Windows.Forms.Label()
        Me.lblShapePrior = New System.Windows.Forms.Label()
        Me.grpPrior = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.grpFitMethod = New System.Windows.Forms.GroupBox()
        Me.ucrPnlExtremes = New instat.UcrPanel()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.tbConfidenceInterval.SuspendLayout()
        Me.tbDisplayOptions.SuspendLayout()
        Me.grpPlots.SuspendLayout()
        Me.tbRegOptions.SuspendLayout()
        Me.tbFitMethod.SuspendLayout()
        Me.grpFitMethod.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbConfidenceInterval
        '
        Me.tbConfidenceInterval.Controls.Add(Me.lblReturnLevel)
        Me.tbConfidenceInterval.Controls.Add(Me.ucrInputType)
        Me.tbConfidenceInterval.Controls.Add(Me.ucrChkType)
        Me.tbConfidenceInterval.Controls.Add(Me.ucrNudReturnLevel)
        Me.tbConfidenceInterval.Location = New System.Drawing.Point(4, 29)
        Me.tbConfidenceInterval.Margin = New System.Windows.Forms.Padding(4)
        Me.tbConfidenceInterval.Name = "tbConfidenceInterval"
        Me.tbConfidenceInterval.Padding = New System.Windows.Forms.Padding(4)
        Me.tbConfidenceInterval.Size = New System.Drawing.Size(549, 433)
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
        'tbDisplayOptions
        '
        Me.tbDisplayOptions.Controls.Add(Me.ucrSavePlots)
        Me.tbDisplayOptions.Controls.Add(Me.grpPlots)
        Me.tbDisplayOptions.Location = New System.Drawing.Point(4, 29)
        Me.tbDisplayOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDisplayOptions.Name = "tbDisplayOptions"
        Me.tbDisplayOptions.Padding = New System.Windows.Forms.Padding(4)
        Me.tbDisplayOptions.Size = New System.Drawing.Size(549, 433)
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
        'tbRegOptions
        '
        Me.tbRegOptions.Controls.Add(Me.tbFitMethod)
        Me.tbRegOptions.Controls.Add(Me.tbDisplayOptions)
        Me.tbRegOptions.Controls.Add(Me.tbConfidenceInterval)
        Me.tbRegOptions.Location = New System.Drawing.Point(5, 6)
        Me.tbRegOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.tbRegOptions.Name = "tbRegOptions"
        Me.tbRegOptions.SelectedIndex = 0
        Me.tbRegOptions.Size = New System.Drawing.Size(557, 466)
        Me.tbRegOptions.TabIndex = 6
        '
        'tbFitMethod
        '
        Me.tbFitMethod.Controls.Add(Me.rdoMle)
        Me.tbFitMethod.Controls.Add(Me.rdoBayesian)
        Me.tbFitMethod.Controls.Add(Me.rdoGMLE)
        Me.tbFitMethod.Controls.Add(Me.rdoLmoments)
        Me.tbFitMethod.Controls.Add(Me.ucrNudNumberOfIterations)
        Me.tbFitMethod.Controls.Add(Me.lblNumberOfIterations)
        Me.tbFitMethod.Controls.Add(Me.ucrNudLocationPrior)
        Me.tbFitMethod.Controls.Add(Me.ucrNudScalePrior)
        Me.tbFitMethod.Controls.Add(Me.ucrNudShapePrior)
        Me.tbFitMethod.Controls.Add(Me.ucrNudLocationInitial)
        Me.tbFitMethod.Controls.Add(Me.ucrNudScaleInitial)
        Me.tbFitMethod.Controls.Add(Me.ucrNudshapeInitial)
        Me.tbFitMethod.Controls.Add(Me.lblLocationInitial)
        Me.tbFitMethod.Controls.Add(Me.lblScaleInitial)
        Me.tbFitMethod.Controls.Add(Me.lblShapeInitial)
        Me.tbFitMethod.Controls.Add(Me.lblLocationPrior)
        Me.tbFitMethod.Controls.Add(Me.lblScalePrior)
        Me.tbFitMethod.Controls.Add(Me.lblShapePrior)
        Me.tbFitMethod.Controls.Add(Me.grpPrior)
        Me.tbFitMethod.Controls.Add(Me.GroupBox5)
        Me.tbFitMethod.Controls.Add(Me.grpFitMethod)
        Me.tbFitMethod.Location = New System.Drawing.Point(4, 29)
        Me.tbFitMethod.Margin = New System.Windows.Forms.Padding(4)
        Me.tbFitMethod.Name = "tbFitMethod"
        Me.tbFitMethod.Padding = New System.Windows.Forms.Padding(4)
        Me.tbFitMethod.Size = New System.Drawing.Size(549, 433)
        Me.tbFitMethod.TabIndex = 0
        Me.tbFitMethod.Tag = "Display"
        Me.tbFitMethod.Text = "Fit Method"
        Me.tbFitMethod.UseVisualStyleBackColor = True
        '
        'rdoMle
        '
        Me.rdoMle.AutoSize = True
        Me.rdoMle.Location = New System.Drawing.Point(23, 33)
        Me.rdoMle.Name = "rdoMle"
        Me.rdoMle.Size = New System.Drawing.Size(219, 24)
        Me.rdoMle.TabIndex = 72
        Me.rdoMle.TabStop = True
        Me.rdoMle.Text = "Maximum Likelihood(MLE)"
        Me.rdoMle.UseVisualStyleBackColor = True
        '
        'rdoBayesian
        '
        Me.rdoBayesian.AutoSize = True
        Me.rdoBayesian.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBayesian.Location = New System.Drawing.Point(23, 99)
        Me.rdoBayesian.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoBayesian.Name = "rdoBayesian"
        Me.rdoBayesian.Size = New System.Drawing.Size(99, 24)
        Me.rdoBayesian.TabIndex = 71
        Me.rdoBayesian.Text = "Bayesian"
        Me.rdoBayesian.UseVisualStyleBackColor = True
        '
        'rdoGMLE
        '
        Me.rdoGMLE.AutoSize = True
        Me.rdoGMLE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGMLE.Location = New System.Drawing.Point(23, 65)
        Me.rdoGMLE.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoGMLE.Name = "rdoGMLE"
        Me.rdoGMLE.Size = New System.Drawing.Size(365, 24)
        Me.rdoGMLE.TabIndex = 70
        Me.rdoGMLE.Text = "General Maximum Likelihood Estimator(GMLE)"
        Me.rdoGMLE.UseVisualStyleBackColor = True
        '
        'rdoLmoments
        '
        Me.rdoLmoments.AutoSize = True
        Me.rdoLmoments.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLmoments.Location = New System.Drawing.Point(23, 132)
        Me.rdoLmoments.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoLmoments.Name = "rdoLmoments"
        Me.rdoLmoments.Size = New System.Drawing.Size(114, 24)
        Me.rdoLmoments.TabIndex = 69
        Me.rdoLmoments.Text = "L-Moments"
        Me.rdoLmoments.UseVisualStyleBackColor = True
        '
        'ucrNudNumberOfIterations
        '
        Me.ucrNudNumberOfIterations.AutoSize = True
        Me.ucrNudNumberOfIterations.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfIterations.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberOfIterations.Location = New System.Drawing.Point(193, 372)
        Me.ucrNudNumberOfIterations.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudNumberOfIterations.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberOfIterations.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfIterations.Name = "ucrNudNumberOfIterations"
        Me.ucrNudNumberOfIterations.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudNumberOfIterations.TabIndex = 64
        Me.ucrNudNumberOfIterations.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNumberOfIterations
        '
        Me.lblNumberOfIterations.AutoSize = True
        Me.lblNumberOfIterations.Location = New System.Drawing.Point(22, 376)
        Me.lblNumberOfIterations.Name = "lblNumberOfIterations"
        Me.lblNumberOfIterations.Size = New System.Drawing.Size(158, 20)
        Me.lblNumberOfIterations.TabIndex = 63
        Me.lblNumberOfIterations.Text = "Number of Iterations:"
        '
        'ucrNudLocationPrior
        '
        Me.ucrNudLocationPrior.AutoSize = True
        Me.ucrNudLocationPrior.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLocationPrior.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLocationPrior.Location = New System.Drawing.Point(138, 240)
        Me.ucrNudLocationPrior.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudLocationPrior.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLocationPrior.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLocationPrior.Name = "ucrNudLocationPrior"
        Me.ucrNudLocationPrior.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudLocationPrior.TabIndex = 62
        Me.ucrNudLocationPrior.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudScalePrior
        '
        Me.ucrNudScalePrior.AutoSize = True
        Me.ucrNudScalePrior.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudScalePrior.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudScalePrior.Location = New System.Drawing.Point(135, 280)
        Me.ucrNudScalePrior.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudScalePrior.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudScalePrior.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudScalePrior.Name = "ucrNudScalePrior"
        Me.ucrNudScalePrior.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudScalePrior.TabIndex = 61
        Me.ucrNudScalePrior.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudShapePrior
        '
        Me.ucrNudShapePrior.AutoSize = True
        Me.ucrNudShapePrior.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShapePrior.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudShapePrior.Location = New System.Drawing.Point(139, 323)
        Me.ucrNudShapePrior.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudShapePrior.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudShapePrior.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShapePrior.Name = "ucrNudShapePrior"
        Me.ucrNudShapePrior.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudShapePrior.TabIndex = 60
        Me.ucrNudShapePrior.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLocationInitial
        '
        Me.ucrNudLocationInitial.AutoSize = True
        Me.ucrNudLocationInitial.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLocationInitial.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLocationInitial.Location = New System.Drawing.Point(444, 243)
        Me.ucrNudLocationInitial.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudLocationInitial.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLocationInitial.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLocationInitial.Name = "ucrNudLocationInitial"
        Me.ucrNudLocationInitial.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudLocationInitial.TabIndex = 59
        Me.ucrNudLocationInitial.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudScaleInitial
        '
        Me.ucrNudScaleInitial.AutoSize = True
        Me.ucrNudScaleInitial.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudScaleInitial.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudScaleInitial.Location = New System.Drawing.Point(444, 286)
        Me.ucrNudScaleInitial.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudScaleInitial.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudScaleInitial.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudScaleInitial.Name = "ucrNudScaleInitial"
        Me.ucrNudScaleInitial.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudScaleInitial.TabIndex = 58
        Me.ucrNudScaleInitial.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudshapeInitial
        '
        Me.ucrNudshapeInitial.AutoSize = True
        Me.ucrNudshapeInitial.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudshapeInitial.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudshapeInitial.Location = New System.Drawing.Point(448, 325)
        Me.ucrNudshapeInitial.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudshapeInitial.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudshapeInitial.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudshapeInitial.Name = "ucrNudshapeInitial"
        Me.ucrNudshapeInitial.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudshapeInitial.TabIndex = 57
        Me.ucrNudshapeInitial.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLocationInitial
        '
        Me.lblLocationInitial.AutoSize = True
        Me.lblLocationInitial.Location = New System.Drawing.Point(336, 247)
        Me.lblLocationInitial.Name = "lblLocationInitial"
        Me.lblLocationInitial.Size = New System.Drawing.Size(74, 20)
        Me.lblLocationInitial.TabIndex = 56
        Me.lblLocationInitial.Text = "Location:"
        Me.lblLocationInitial.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblScaleInitial
        '
        Me.lblScaleInitial.AutoSize = True
        Me.lblScaleInitial.Location = New System.Drawing.Point(337, 291)
        Me.lblScaleInitial.Name = "lblScaleInitial"
        Me.lblScaleInitial.Size = New System.Drawing.Size(53, 20)
        Me.lblScaleInitial.TabIndex = 55
        Me.lblScaleInitial.Text = "Scale:"
        '
        'lblShapeInitial
        '
        Me.lblShapeInitial.AutoSize = True
        Me.lblShapeInitial.Location = New System.Drawing.Point(339, 329)
        Me.lblShapeInitial.Name = "lblShapeInitial"
        Me.lblShapeInitial.Size = New System.Drawing.Size(60, 20)
        Me.lblShapeInitial.TabIndex = 54
        Me.lblShapeInitial.Text = "Shape:"
        '
        'lblLocationPrior
        '
        Me.lblLocationPrior.AutoSize = True
        Me.lblLocationPrior.Location = New System.Drawing.Point(19, 244)
        Me.lblLocationPrior.Name = "lblLocationPrior"
        Me.lblLocationPrior.Size = New System.Drawing.Size(74, 20)
        Me.lblLocationPrior.TabIndex = 53
        Me.lblLocationPrior.Text = "Location:"
        '
        'lblScalePrior
        '
        Me.lblScalePrior.AutoSize = True
        Me.lblScalePrior.Location = New System.Drawing.Point(27, 284)
        Me.lblScalePrior.Name = "lblScalePrior"
        Me.lblScalePrior.Size = New System.Drawing.Size(53, 20)
        Me.lblScalePrior.TabIndex = 52
        Me.lblScalePrior.Text = "Scale:"
        '
        'lblShapePrior
        '
        Me.lblShapePrior.AutoSize = True
        Me.lblShapePrior.Location = New System.Drawing.Point(27, 321)
        Me.lblShapePrior.Name = "lblShapePrior"
        Me.lblShapePrior.Size = New System.Drawing.Size(60, 20)
        Me.lblShapePrior.TabIndex = 51
        Me.lblShapePrior.Text = "Shape:"
        '
        'grpPrior
        '
        Me.grpPrior.Location = New System.Drawing.Point(16, 206)
        Me.grpPrior.Name = "grpPrior"
        Me.grpPrior.Size = New System.Drawing.Size(233, 149)
        Me.grpPrior.TabIndex = 65
        Me.grpPrior.TabStop = False
        Me.grpPrior.Text = "Prior Parameters"
        Me.grpPrior.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(329, 219)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(214, 136)
        Me.GroupBox5.TabIndex = 66
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Initial Values"
        '
        'grpFitMethod
        '
        Me.grpFitMethod.Controls.Add(Me.ucrPnlExtremes)
        Me.grpFitMethod.Location = New System.Drawing.Point(7, 7)
        Me.grpFitMethod.Name = "grpFitMethod"
        Me.grpFitMethod.Size = New System.Drawing.Size(403, 169)
        Me.grpFitMethod.TabIndex = 73
        Me.grpFitMethod.TabStop = False
        Me.grpFitMethod.Text = "Fit Method"
        '
        'ucrPnlExtremes
        '
        Me.ucrPnlExtremes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlExtremes.Location = New System.Drawing.Point(9, 22)
        Me.ucrPnlExtremes.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrPnlExtremes.Name = "ucrPnlExtremes"
        Me.ucrPnlExtremes.Size = New System.Drawing.Size(370, 138)
        Me.ucrPnlExtremes.TabIndex = 74
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
        'sdgExtremesMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(575, 600)
        Me.Controls.Add(Me.tbRegOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgExtremesMethod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extremes Method"
        Me.tbConfidenceInterval.ResumeLayout(False)
        Me.tbConfidenceInterval.PerformLayout()
        Me.tbDisplayOptions.ResumeLayout(False)
        Me.grpPlots.ResumeLayout(False)
        Me.grpPlots.PerformLayout()
        Me.tbRegOptions.ResumeLayout(False)
        Me.tbFitMethod.ResumeLayout(False)
        Me.tbFitMethod.PerformLayout()
        Me.grpFitMethod.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents tbConfidenceInterval As TabPage
    Friend WithEvents lblReturnLevel As Label
    Friend WithEvents ucrInputType As ucrInputComboBox
    Friend WithEvents ucrChkType As ucrCheck
    Friend WithEvents ucrNudReturnLevel As ucrNud
    Friend WithEvents tbDisplayOptions As TabPage
    Friend WithEvents ucrSavePlots As ucrSave
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
    Friend WithEvents tbRegOptions As TabControl
    Friend WithEvents tbFitMethod As TabPage
    Friend WithEvents rdoMle As RadioButton
    Friend WithEvents rdoBayesian As RadioButton
    Friend WithEvents rdoGMLE As RadioButton
    Friend WithEvents rdoLmoments As RadioButton
    Friend WithEvents ucrNudNumberOfIterations As ucrNud
    Friend WithEvents lblNumberOfIterations As Label
    Friend WithEvents ucrNudLocationPrior As ucrNud
    Friend WithEvents ucrNudScalePrior As ucrNud
    Friend WithEvents ucrNudShapePrior As ucrNud
    Friend WithEvents ucrNudLocationInitial As ucrNud
    Friend WithEvents ucrNudScaleInitial As ucrNud
    Friend WithEvents ucrNudshapeInitial As ucrNud
    Friend WithEvents lblLocationInitial As Label
    Friend WithEvents lblScaleInitial As Label
    Friend WithEvents lblShapeInitial As Label
    Friend WithEvents lblLocationPrior As Label
    Friend WithEvents lblScalePrior As Label
    Friend WithEvents lblShapePrior As Label
    Friend WithEvents grpPrior As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents grpFitMethod As GroupBox
    Friend WithEvents ucrPnlExtremes As UcrPanel
End Class
