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
        Me.tbDisplayOptions = New System.Windows.Forms.TabPage()
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
        Me.tbRegOptions = New System.Windows.Forms.TabControl()
        Me.tbFitMethod = New System.Windows.Forms.TabPage()
        Me.lblPrior = New System.Windows.Forms.Label()
        Me.rdoMle = New System.Windows.Forms.RadioButton()
        Me.rdoBayesian = New System.Windows.Forms.RadioButton()
        Me.rdoGMLE = New System.Windows.Forms.RadioButton()
        Me.rdoLmoments = New System.Windows.Forms.RadioButton()
        Me.lblNumberOfIterations = New System.Windows.Forms.Label()
        Me.grpFitMethod = New System.Windows.Forms.GroupBox()
        Me.grpInitial = New System.Windows.Forms.GroupBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblScale = New System.Windows.Forms.Label()
        Me.lblShape = New System.Windows.Forms.Label()
        Me.ucrNudScale = New instat.ucrNud()
        Me.ucrNudLocation = New instat.ucrNud()
        Me.ucrNudShape = New instat.ucrNud()
        Me.ucrInputPrior = New instat.ucrInputTextBox()
        Me.ucrNudNumberOfIterations = New instat.ucrNud()
        Me.ucrPnlFitMethodExtremes = New instat.UcrPanel()
        Me.ucrSavePlots = New instat.ucrSave()
        Me.ucrPnlDisplayOptionsExtreme = New instat.UcrPanel()
        Me.ucrChkType = New instat.ucrCheck()
        Me.ucrNudReturnLevel = New instat.ucrNud()
        Me.ucrInputType = New instat.ucrInputComboBox()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.tbConfidenceInterval.SuspendLayout()
        Me.tbDisplayOptions.SuspendLayout()
        Me.grpPlots.SuspendLayout()
        Me.tbRegOptions.SuspendLayout()
        Me.tbFitMethod.SuspendLayout()
        Me.grpFitMethod.SuspendLayout()
        Me.grpInitial.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbConfidenceInterval
        '
        Me.tbConfidenceInterval.Controls.Add(Me.lblReturnLevel)
        Me.tbConfidenceInterval.Controls.Add(Me.ucrChkType)
        Me.tbConfidenceInterval.Controls.Add(Me.ucrNudReturnLevel)
        Me.tbConfidenceInterval.Controls.Add(Me.ucrInputType)
        Me.tbConfidenceInterval.Location = New System.Drawing.Point(4, 22)
        Me.tbConfidenceInterval.Name = "tbConfidenceInterval"
        Me.tbConfidenceInterval.Padding = New System.Windows.Forms.Padding(3)
        Me.tbConfidenceInterval.Size = New System.Drawing.Size(363, 285)
        Me.tbConfidenceInterval.TabIndex = 2
        Me.tbConfidenceInterval.Tag = "Save"
        Me.tbConfidenceInterval.Text = "Confidence Interval"
        Me.tbConfidenceInterval.UseVisualStyleBackColor = True
        '
        'lblReturnLevel
        '
        Me.lblReturnLevel.AutoSize = True
        Me.lblReturnLevel.Location = New System.Drawing.Point(237, 11)
        Me.lblReturnLevel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReturnLevel.Name = "lblReturnLevel"
        Me.lblReturnLevel.Size = New System.Drawing.Size(71, 13)
        Me.lblReturnLevel.TabIndex = 3
        Me.lblReturnLevel.Text = "Return Level:"
        '
        'tbDisplayOptions
        '
        Me.tbDisplayOptions.Controls.Add(Me.ucrSavePlots)
        Me.tbDisplayOptions.Controls.Add(Me.grpPlots)
        Me.tbDisplayOptions.Location = New System.Drawing.Point(4, 22)
        Me.tbDisplayOptions.Name = "tbDisplayOptions"
        Me.tbDisplayOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDisplayOptions.Size = New System.Drawing.Size(363, 285)
        Me.tbDisplayOptions.TabIndex = 1
        Me.tbDisplayOptions.Tag = "Graphics"
        Me.tbDisplayOptions.Text = "Display Options"
        Me.tbDisplayOptions.UseVisualStyleBackColor = True
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
        Me.grpPlots.Controls.Add(Me.ucrPnlDisplayOptionsExtreme)
        Me.grpPlots.Location = New System.Drawing.Point(19, 9)
        Me.grpPlots.Name = "grpPlots"
        Me.grpPlots.Size = New System.Drawing.Size(261, 141)
        Me.grpPlots.TabIndex = 2
        Me.grpPlots.TabStop = False
        Me.grpPlots.Text = "Plots"
        '
        'rdoNoPlot
        '
        Me.rdoNoPlot.AutoSize = True
        Me.rdoNoPlot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNoPlot.Location = New System.Drawing.Point(13, 22)
        Me.rdoNoPlot.Name = "rdoNoPlot"
        Me.rdoNoPlot.Size = New System.Drawing.Size(60, 17)
        Me.rdoNoPlot.TabIndex = 1
        Me.rdoNoPlot.Text = "No Plot"
        Me.rdoNoPlot.UseVisualStyleBackColor = True
        '
        'rdoTrace
        '
        Me.rdoTrace.AutoSize = True
        Me.rdoTrace.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTrace.Location = New System.Drawing.Point(13, 115)
        Me.rdoTrace.Name = "rdoTrace"
        Me.rdoTrace.Size = New System.Drawing.Size(74, 17)
        Me.rdoTrace.TabIndex = 5
        Me.rdoTrace.Text = "Trace Plot"
        Me.rdoTrace.UseVisualStyleBackColor = True
        '
        'rdoRlplot
        '
        Me.rdoRlplot.AutoSize = True
        Me.rdoRlplot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRlplot.Location = New System.Drawing.Point(13, 92)
        Me.rdoRlplot.Name = "rdoRlplot"
        Me.rdoRlplot.Size = New System.Drawing.Size(56, 17)
        Me.rdoRlplot.TabIndex = 4
        Me.rdoRlplot.Text = "Rl Plot"
        Me.rdoRlplot.UseVisualStyleBackColor = True
        '
        'rdoHist
        '
        Me.rdoHist.AutoSize = True
        Me.rdoHist.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHist.Location = New System.Drawing.Point(149, 69)
        Me.rdoHist.Name = "rdoHist"
        Me.rdoHist.Size = New System.Drawing.Size(64, 17)
        Me.rdoHist.TabIndex = 8
        Me.rdoHist.Text = "Hist Plot"
        Me.rdoHist.UseVisualStyleBackColor = True
        '
        'rdoDensity
        '
        Me.rdoDensity.AutoSize = True
        Me.rdoDensity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDensity.Location = New System.Drawing.Point(149, 93)
        Me.rdoDensity.Name = "rdoDensity"
        Me.rdoDensity.Size = New System.Drawing.Size(81, 17)
        Me.rdoDensity.TabIndex = 9
        Me.rdoDensity.Text = "Density Plot"
        Me.rdoDensity.UseVisualStyleBackColor = True
        '
        'rdoZPlot
        '
        Me.rdoZPlot.AutoSize = True
        Me.rdoZPlot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoZPlot.Location = New System.Drawing.Point(149, 46)
        Me.rdoZPlot.Name = "rdoZPlot"
        Me.rdoZPlot.Size = New System.Drawing.Size(70, 17)
        Me.rdoZPlot.TabIndex = 7
        Me.rdoZPlot.Text = "Zplot Plot"
        Me.rdoZPlot.UseVisualStyleBackColor = True
        '
        'rdoProbprob
        '
        Me.rdoProbprob.AutoSize = True
        Me.rdoProbprob.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoProbprob.Location = New System.Drawing.Point(13, 69)
        Me.rdoProbprob.Name = "rdoProbprob"
        Me.rdoProbprob.Size = New System.Drawing.Size(92, 17)
        Me.rdoProbprob.TabIndex = 3
        Me.rdoProbprob.Text = "Prob-prob Plot"
        Me.rdoProbprob.UseVisualStyleBackColor = True
        '
        'rdoQQPlot
        '
        Me.rdoQQPlot.AutoSize = True
        Me.rdoQQPlot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoQQPlot.Location = New System.Drawing.Point(149, 23)
        Me.rdoQQPlot.Name = "rdoQQPlot"
        Me.rdoQQPlot.Size = New System.Drawing.Size(62, 17)
        Me.rdoQQPlot.TabIndex = 6
        Me.rdoQQPlot.Text = "QQ Plot"
        Me.rdoQQPlot.UseVisualStyleBackColor = True
        '
        'rdoQQ2
        '
        Me.rdoQQ2.AutoSize = True
        Me.rdoQQ2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoQQ2.Location = New System.Drawing.Point(149, 115)
        Me.rdoQQ2.Name = "rdoQQ2"
        Me.rdoQQ2.Size = New System.Drawing.Size(68, 17)
        Me.rdoQQ2.TabIndex = 10
        Me.rdoQQ2.Text = "QQ2 Plot"
        Me.rdoQQ2.UseVisualStyleBackColor = True
        '
        'rdoPrimary
        '
        Me.rdoPrimary.AutoSize = True
        Me.rdoPrimary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPrimary.Location = New System.Drawing.Point(13, 46)
        Me.rdoPrimary.Name = "rdoPrimary"
        Me.rdoPrimary.Size = New System.Drawing.Size(59, 17)
        Me.rdoPrimary.TabIndex = 2
        Me.rdoPrimary.Text = "Primary"
        Me.rdoPrimary.UseVisualStyleBackColor = True
        '
        'tbRegOptions
        '
        Me.tbRegOptions.Controls.Add(Me.tbFitMethod)
        Me.tbRegOptions.Controls.Add(Me.tbDisplayOptions)
        Me.tbRegOptions.Controls.Add(Me.tbConfidenceInterval)
        Me.tbRegOptions.Location = New System.Drawing.Point(3, 4)
        Me.tbRegOptions.Name = "tbRegOptions"
        Me.tbRegOptions.SelectedIndex = 0
        Me.tbRegOptions.Size = New System.Drawing.Size(371, 311)
        Me.tbRegOptions.TabIndex = 6
        '
        'tbFitMethod
        '
        Me.tbFitMethod.Controls.Add(Me.ucrInputPrior)
        Me.tbFitMethod.Controls.Add(Me.lblPrior)
        Me.tbFitMethod.Controls.Add(Me.rdoMle)
        Me.tbFitMethod.Controls.Add(Me.rdoBayesian)
        Me.tbFitMethod.Controls.Add(Me.rdoGMLE)
        Me.tbFitMethod.Controls.Add(Me.rdoLmoments)
        Me.tbFitMethod.Controls.Add(Me.ucrNudNumberOfIterations)
        Me.tbFitMethod.Controls.Add(Me.lblNumberOfIterations)
        Me.tbFitMethod.Controls.Add(Me.grpFitMethod)
        Me.tbFitMethod.Controls.Add(Me.grpInitial)
        Me.tbFitMethod.Location = New System.Drawing.Point(4, 22)
        Me.tbFitMethod.Name = "tbFitMethod"
        Me.tbFitMethod.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFitMethod.Size = New System.Drawing.Size(363, 285)
        Me.tbFitMethod.TabIndex = 0
        Me.tbFitMethod.Tag = "Display"
        Me.tbFitMethod.Text = "Fit Method"
        Me.tbFitMethod.UseVisualStyleBackColor = True
        '
        'lblPrior
        '
        Me.lblPrior.AutoSize = True
        Me.lblPrior.Location = New System.Drawing.Point(12, 129)
        Me.lblPrior.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrior.Name = "lblPrior"
        Me.lblPrior.Size = New System.Drawing.Size(87, 13)
        Me.lblPrior.TabIndex = 76
        Me.lblPrior.Text = "Prior Parameters:"
        '
        'rdoMle
        '
        Me.rdoMle.AutoSize = True
        Me.rdoMle.Location = New System.Drawing.Point(15, 22)
        Me.rdoMle.Margin = New System.Windows.Forms.Padding(2)
        Me.rdoMle.Name = "rdoMle"
        Me.rdoMle.Size = New System.Drawing.Size(148, 17)
        Me.rdoMle.TabIndex = 72
        Me.rdoMle.TabStop = True
        Me.rdoMle.Text = "Maximum Likelihood(MLE)"
        Me.rdoMle.UseVisualStyleBackColor = True
        '
        'rdoBayesian
        '
        Me.rdoBayesian.AutoSize = True
        Me.rdoBayesian.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBayesian.Location = New System.Drawing.Point(15, 66)
        Me.rdoBayesian.Name = "rdoBayesian"
        Me.rdoBayesian.Size = New System.Drawing.Size(68, 17)
        Me.rdoBayesian.TabIndex = 71
        Me.rdoBayesian.Text = "Bayesian"
        Me.rdoBayesian.UseVisualStyleBackColor = True
        '
        'rdoGMLE
        '
        Me.rdoGMLE.AutoSize = True
        Me.rdoGMLE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGMLE.Location = New System.Drawing.Point(15, 43)
        Me.rdoGMLE.Name = "rdoGMLE"
        Me.rdoGMLE.Size = New System.Drawing.Size(242, 17)
        Me.rdoGMLE.TabIndex = 70
        Me.rdoGMLE.Text = "General Maximum Likelihood Estimator(GMLE)"
        Me.rdoGMLE.UseVisualStyleBackColor = True
        '
        'rdoLmoments
        '
        Me.rdoLmoments.AutoSize = True
        Me.rdoLmoments.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLmoments.Location = New System.Drawing.Point(15, 88)
        Me.rdoLmoments.Name = "rdoLmoments"
        Me.rdoLmoments.Size = New System.Drawing.Size(77, 17)
        Me.rdoLmoments.TabIndex = 69
        Me.rdoLmoments.Text = "L-Moments"
        Me.rdoLmoments.UseVisualStyleBackColor = True
        '
        'lblNumberOfIterations
        '
        Me.lblNumberOfIterations.AutoSize = True
        Me.lblNumberOfIterations.Location = New System.Drawing.Point(12, 265)
        Me.lblNumberOfIterations.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumberOfIterations.Name = "lblNumberOfIterations"
        Me.lblNumberOfIterations.Size = New System.Drawing.Size(105, 13)
        Me.lblNumberOfIterations.TabIndex = 63
        Me.lblNumberOfIterations.Text = "Number of Iterations:"
        '
        'grpFitMethod
        '
        Me.grpFitMethod.Controls.Add(Me.ucrPnlFitMethodExtremes)
        Me.grpFitMethod.Location = New System.Drawing.Point(5, 5)
        Me.grpFitMethod.Margin = New System.Windows.Forms.Padding(2)
        Me.grpFitMethod.Name = "grpFitMethod"
        Me.grpFitMethod.Padding = New System.Windows.Forms.Padding(2)
        Me.grpFitMethod.Size = New System.Drawing.Size(269, 113)
        Me.grpFitMethod.TabIndex = 73
        Me.grpFitMethod.TabStop = False
        Me.grpFitMethod.Text = "Fit Method"
        '
        'grpInitial
        '
        Me.grpInitial.Controls.Add(Me.ucrNudScale)
        Me.grpInitial.Controls.Add(Me.ucrNudLocation)
        Me.grpInitial.Controls.Add(Me.lblLocation)
        Me.grpInitial.Controls.Add(Me.ucrNudShape)
        Me.grpInitial.Controls.Add(Me.lblScale)
        Me.grpInitial.Controls.Add(Me.lblShape)
        Me.grpInitial.Location = New System.Drawing.Point(15, 154)
        Me.grpInitial.Margin = New System.Windows.Forms.Padding(2)
        Me.grpInitial.Name = "grpInitial"
        Me.grpInitial.Padding = New System.Windows.Forms.Padding(2)
        Me.grpInitial.Size = New System.Drawing.Size(133, 92)
        Me.grpInitial.TabIndex = 86
        Me.grpInitial.TabStop = False
        Me.grpInitial.Text = "Initial Values:"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(8, 23)
        Me.lblLocation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(51, 13)
        Me.lblLocation.TabIndex = 85
        Me.lblLocation.Text = "Location:"
        '
        'lblScale
        '
        Me.lblScale.AutoSize = True
        Me.lblScale.Location = New System.Drawing.Point(22, 47)
        Me.lblScale.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblScale.Name = "lblScale"
        Me.lblScale.Size = New System.Drawing.Size(37, 13)
        Me.lblScale.TabIndex = 84
        Me.lblScale.Text = "Scale:"
        '
        'lblShape
        '
        Me.lblShape.AutoSize = True
        Me.lblShape.Location = New System.Drawing.Point(18, 72)
        Me.lblShape.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblShape.Name = "lblShape"
        Me.lblShape.Size = New System.Drawing.Size(41, 13)
        Me.lblShape.TabIndex = 83
        Me.lblShape.Text = "Shape:"
        '
        'ucrNudScale
        '
        Me.ucrNudScale.AutoSize = True
        Me.ucrNudScale.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudScale.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudScale.Location = New System.Drawing.Point(65, 40)
        Me.ucrNudScale.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrNudScale.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudScale.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudScale.Name = "ucrNudScale"
        Me.ucrNudScale.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudScale.TabIndex = 82
        Me.ucrNudScale.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLocation
        '
        Me.ucrNudLocation.AutoSize = True
        Me.ucrNudLocation.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLocation.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLocation.Location = New System.Drawing.Point(65, 15)
        Me.ucrNudLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrNudLocation.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLocation.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLocation.Name = "ucrNudLocation"
        Me.ucrNudLocation.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLocation.TabIndex = 81
        Me.ucrNudLocation.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudShape
        '
        Me.ucrNudShape.AutoSize = True
        Me.ucrNudShape.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShape.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudShape.Location = New System.Drawing.Point(65, 65)
        Me.ucrNudShape.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrNudShape.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudShape.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShape.Name = "ucrNudShape"
        Me.ucrNudShape.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudShape.TabIndex = 80
        Me.ucrNudShape.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputPrior
        '
        Me.ucrInputPrior.AddQuotesIfUnrecognised = True
        Me.ucrInputPrior.AutoSize = True
        Me.ucrInputPrior.IsMultiline = False
        Me.ucrInputPrior.IsReadOnly = False
        Me.ucrInputPrior.Location = New System.Drawing.Point(123, 129)
        Me.ucrInputPrior.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrInputPrior.Name = "ucrInputPrior"
        Me.ucrInputPrior.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPrior.TabIndex = 78
        '
        'ucrNudNumberOfIterations
        '
        Me.ucrNudNumberOfIterations.AutoSize = True
        Me.ucrNudNumberOfIterations.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfIterations.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberOfIterations.Location = New System.Drawing.Point(123, 261)
        Me.ucrNudNumberOfIterations.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrNudNumberOfIterations.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberOfIterations.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfIterations.Name = "ucrNudNumberOfIterations"
        Me.ucrNudNumberOfIterations.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumberOfIterations.TabIndex = 64
        Me.ucrNudNumberOfIterations.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlFitMethodExtremes
        '
        Me.ucrPnlFitMethodExtremes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlFitMethodExtremes.Location = New System.Drawing.Point(6, 15)
        Me.ucrPnlFitMethodExtremes.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrPnlFitMethodExtremes.Name = "ucrPnlFitMethodExtremes"
        Me.ucrPnlFitMethodExtremes.Size = New System.Drawing.Size(247, 92)
        Me.ucrPnlFitMethodExtremes.TabIndex = 74
        '
        'ucrSavePlots
        '
        Me.ucrSavePlots.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSavePlots.Location = New System.Drawing.Point(19, 159)
        Me.ucrSavePlots.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSavePlots.Name = "ucrSavePlots"
        Me.ucrSavePlots.Size = New System.Drawing.Size(261, 24)
        Me.ucrSavePlots.TabIndex = 3
        '
        'ucrPnlDisplayOptionsExtreme
        '
        Me.ucrPnlDisplayOptionsExtreme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDisplayOptionsExtreme.Location = New System.Drawing.Point(8, 15)
        Me.ucrPnlDisplayOptionsExtreme.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlDisplayOptionsExtreme.Name = "ucrPnlDisplayOptionsExtreme"
        Me.ucrPnlDisplayOptionsExtreme.Size = New System.Drawing.Size(239, 117)
        Me.ucrPnlDisplayOptionsExtreme.TabIndex = 0
        '
        'ucrChkType
        '
        Me.ucrChkType.AutoSize = True
        Me.ucrChkType.Checked = False
        Me.ucrChkType.Location = New System.Drawing.Point(8, 9)
        Me.ucrChkType.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrChkType.Name = "ucrChkType"
        Me.ucrChkType.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkType.TabIndex = 0
        '
        'ucrNudReturnLevel
        '
        Me.ucrNudReturnLevel.AutoSize = True
        Me.ucrNudReturnLevel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudReturnLevel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudReturnLevel.Location = New System.Drawing.Point(311, 9)
        Me.ucrNudReturnLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrNudReturnLevel.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudReturnLevel.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudReturnLevel.Name = "ucrNudReturnLevel"
        Me.ucrNudReturnLevel.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudReturnLevel.TabIndex = 2
        Me.ucrNudReturnLevel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputType
        '
        Me.ucrInputType.AddQuotesIfUnrecognised = True
        Me.ucrInputType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputType.GetSetSelectedIndex = -1
        Me.ucrInputType.IsReadOnly = False
        Me.ucrInputType.Location = New System.Drawing.Point(109, 12)
        Me.ucrInputType.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrInputType.Name = "ucrInputType"
        Me.ucrInputType.Size = New System.Drawing.Size(117, 21)
        Me.ucrInputType.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.Location = New System.Drawing.Point(6, 345)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(224, 30)
        Me.ucrBase.TabIndex = 5
        '
        'sdgExtremesMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(383, 400)
        Me.Controls.Add(Me.tbRegOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
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
        Me.grpInitial.ResumeLayout(False)
        Me.grpInitial.PerformLayout()
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
    Friend WithEvents ucrPnlDisplayOptionsExtreme As UcrPanel
    Friend WithEvents tbRegOptions As TabControl
    Friend WithEvents tbFitMethod As TabPage
    Friend WithEvents rdoMle As RadioButton
    Friend WithEvents rdoBayesian As RadioButton
    Friend WithEvents rdoGMLE As RadioButton
    Friend WithEvents rdoLmoments As RadioButton
    Friend WithEvents ucrNudNumberOfIterations As ucrNud
    Friend WithEvents lblNumberOfIterations As Label
    Friend WithEvents grpFitMethod As GroupBox
    Friend WithEvents ucrPnlFitMethodExtremes As UcrPanel
    Friend WithEvents lblPrior As Label
    Friend WithEvents ucrInputPrior As ucrInputTextBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblScale As Label
    Friend WithEvents lblShape As Label
    Friend WithEvents ucrNudScale As ucrNud
    Friend WithEvents ucrNudLocation As ucrNud
    Friend WithEvents ucrNudShape As ucrNud
    Friend WithEvents grpInitial As GroupBox
End Class
