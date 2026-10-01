<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgUseModel
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
        Me.components = New System.ComponentModel.Container()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.cmdsummary = New System.Windows.Forms.Button()
        Me.cmdanova = New System.Windows.Forms.Button()
        Me.cmdresiduals = New System.Windows.Forms.Button()
        Me.grpGeneral = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdDurbinWatsonTest = New System.Windows.Forms.Button()
        Me.cmdNcvTest = New System.Windows.Forms.Button()
        Me.cmdOutlierTest = New System.Windows.Forms.Button()
        Me.cmdBIC = New System.Windows.Forms.Button()
        Me.cmdAIC = New System.Windows.Forms.Button()
        Me.cmdCoefficient = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.grpPrediction = New System.Windows.Forms.GroupBox()
        Me.cmdPredict = New System.Windows.Forms.Button()
        Me.lblModels = New System.Windows.Forms.Label()
        Me.grpExtrRemes = New System.Windows.Forms.GroupBox()
        Me.cmdPlotFevd = New System.Windows.Forms.Button()
        Me.cmdSummaryFevd = New System.Windows.Forms.Button()
        Me.cmdPrintFevd = New System.Windows.Forms.Button()
        Me.cmdLrTest = New System.Windows.Forms.Button()
        Me.cmdIsFixedfevd = New System.Windows.Forms.Button()
        Me.cmdFindpars = New System.Windows.Forms.Button()
        Me.cmdDistill = New System.Windows.Forms.Button()
        Me.cmdCi = New System.Windows.Forms.Button()
        Me.cmdErlevd = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.lblRpackage = New System.Windows.Forms.Label()
        Me.grpSegmented = New System.Windows.Forms.GroupBox()
        Me.cmdSlope = New System.Windows.Forms.Button()
        Me.cmdPscore = New System.Windows.Forms.Button()
        Me.cmdDavies = New System.Windows.Forms.Button()
        Me.cmdIntercept = New System.Windows.Forms.Button()
        Me.cmdBroken = New System.Windows.Forms.Button()
        Me.cmdPoints = New System.Windows.Forms.Button()
        Me.cmdPlotLines = New System.Windows.Forms.Button()
        Me.cmdSegmentedPredict = New System.Windows.Forms.Button()
        Me.cmdVcov = New System.Windows.Forms.Button()
        Me.cmdConfint = New System.Windows.Forms.Button()
        Me.cmdSegmentedSummary = New System.Windows.Forms.Button()
        Me.cmdAapc = New System.Windows.Forms.Button()
        Me.cmdSegmented = New System.Windows.Forms.Button()
        Me.cmdSegmentedPrint = New System.Windows.Forms.Button()
        Me.ContextMenuStripPrediction = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuPrediction = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripGeneral = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuStats = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuCar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripExtRemes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuExtRemes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripSegmented = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuSegmented = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpEmmeans = New System.Windows.Forms.GroupBox()
        Me.cmdcurlySign = New System.Windows.Forms.Button()
        Me.cmdQuotes = New System.Windows.Forms.Button()
        Me.cmdXtable = New System.Windows.Forms.Button()
        Me.cmdTest = New System.Windows.Forms.Button()
        Me.cmdPairs = New System.Windows.Forms.Button()
        Me.cmdRefgrid = New System.Windows.Forms.Button()
        Me.cmdEmmeansSummary = New System.Windows.Forms.Button()
        Me.cmdpwpp = New System.Windows.Forms.Button()
        Me.cmdEmmeansPlot = New System.Windows.Forms.Button()
        Me.cmdIntplot = New System.Windows.Forms.Button()
        Me.cmdContrast = New System.Windows.Forms.Button()
        Me.cmdEmmeanConfint = New System.Windows.Forms.Button()
        Me.cmdTrends = New System.Windows.Forms.Button()
        Me.cmdEmmeans = New System.Windows.Forms.Button()
        Me.cmdJoint = New System.Windows.Forms.Button()
        Me.ContextMenuStripEmmeans = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuEmmeans = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRHelpEmmeans = New instat.ucrSplitButton()
        Me.cmdRHelpSegmented = New instat.ucrSplitButton()
        Me.cmdRHelpExtRemes = New instat.ucrSplitButton()
        Me.cmdRHelpGeneral = New instat.ucrSplitButton()
        Me.cmdRHelpPrediction = New instat.ucrSplitButton()
        Me.ucrTryModelling = New instat.ucrTry()
        Me.ucrSaveResult = New instat.ucrSave()
        Me.ucrChkIncludeArguments = New instat.ucrCheck()
        Me.ucrInputModels = New instat.ucrInputTextBox()
        Me.ucrSelectorUseModel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverForTestColumn = New instat.ucrReceiverExpression()
        Me.ucrInputComboRPackage = New instat.ucrInputComboBox()
        Me.grpGeneral.SuspendLayout()
        Me.grpPrediction.SuspendLayout()
        Me.grpExtrRemes.SuspendLayout()
        Me.grpSegmented.SuspendLayout()
        Me.ContextMenuStripPrediction.SuspendLayout()
        Me.ContextMenuStripGeneral.SuspendLayout()
        Me.ContextMenuStripExtRemes.SuspendLayout()
        Me.ContextMenuStripSegmented.SuspendLayout()
        Me.grpEmmeans.SuspendLayout()
        Me.ContextMenuStripEmmeans.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblModel.Location = New System.Drawing.Point(19, 18)
        Me.lblModel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(58, 13)
        Me.lblModel.TabIndex = 11
        Me.lblModel.Tag = "Test"
        Me.lblModel.Text = "Expression"
        '
        'cmdsummary
        '
        Me.cmdsummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdsummary.Location = New System.Drawing.Point(72, 12)
        Me.cmdsummary.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdsummary.Name = "cmdsummary"
        Me.cmdsummary.Size = New System.Drawing.Size(69, 30)
        Me.cmdsummary.TabIndex = 126
        Me.cmdsummary.Text = "summary"
        Me.cmdsummary.UseVisualStyleBackColor = True
        '
        'cmdanova
        '
        Me.cmdanova.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdanova.Location = New System.Drawing.Point(3, 12)
        Me.cmdanova.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdanova.Name = "cmdanova"
        Me.cmdanova.Size = New System.Drawing.Size(69, 30)
        Me.cmdanova.TabIndex = 124
        Me.cmdanova.Text = "anova"
        Me.cmdanova.UseVisualStyleBackColor = True
        '
        'cmdresiduals
        '
        Me.cmdresiduals.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdresiduals.Location = New System.Drawing.Point(140, 12)
        Me.cmdresiduals.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdresiduals.Name = "cmdresiduals"
        Me.cmdresiduals.Size = New System.Drawing.Size(69, 30)
        Me.cmdresiduals.TabIndex = 153
        Me.cmdresiduals.Text = "residuals"
        Me.cmdresiduals.UseVisualStyleBackColor = True
        '
        'grpGeneral
        '
        Me.grpGeneral.Controls.Add(Me.Button2)
        Me.grpGeneral.Controls.Add(Me.cmdDurbinWatsonTest)
        Me.grpGeneral.Controls.Add(Me.cmdNcvTest)
        Me.grpGeneral.Controls.Add(Me.cmdOutlierTest)
        Me.grpGeneral.Controls.Add(Me.cmdBIC)
        Me.grpGeneral.Controls.Add(Me.cmdAIC)
        Me.grpGeneral.Controls.Add(Me.cmdCoefficient)
        Me.grpGeneral.Controls.Add(Me.cmdPrint)
        Me.grpGeneral.Controls.Add(Me.cmdsummary)
        Me.grpGeneral.Controls.Add(Me.cmdanova)
        Me.grpGeneral.Controls.Add(Me.cmdresiduals)
        Me.grpGeneral.Location = New System.Drawing.Point(258, 106)
        Me.grpGeneral.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpGeneral.Name = "grpGeneral"
        Me.grpGeneral.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpGeneral.Size = New System.Drawing.Size(213, 142)
        Me.grpGeneral.TabIndex = 25
        Me.grpGeneral.TabStop = False
        Me.grpGeneral.Text = "General"
        '
        'Button2
        '
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(140, 100)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 30)
        Me.Button2.TabIndex = 161
        Me.Button2.Text = "Anova"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdDurbinWatsonTest
        '
        Me.cmdDurbinWatsonTest.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDurbinWatsonTest.Location = New System.Drawing.Point(3, 100)
        Me.cmdDurbinWatsonTest.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDurbinWatsonTest.Name = "cmdDurbinWatsonTest"
        Me.cmdDurbinWatsonTest.Size = New System.Drawing.Size(138, 30)
        Me.cmdDurbinWatsonTest.TabIndex = 160
        Me.cmdDurbinWatsonTest.Text = "durbinWatsonTest"
        Me.cmdDurbinWatsonTest.UseVisualStyleBackColor = True
        '
        'cmdNcvTest
        '
        Me.cmdNcvTest.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNcvTest.Location = New System.Drawing.Point(140, 70)
        Me.cmdNcvTest.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdNcvTest.Name = "cmdNcvTest"
        Me.cmdNcvTest.Size = New System.Drawing.Size(69, 30)
        Me.cmdNcvTest.TabIndex = 159
        Me.cmdNcvTest.Text = "ncvTest"
        Me.cmdNcvTest.UseVisualStyleBackColor = True
        '
        'cmdOutlierTest
        '
        Me.cmdOutlierTest.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOutlierTest.Location = New System.Drawing.Point(72, 70)
        Me.cmdOutlierTest.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdOutlierTest.Name = "cmdOutlierTest"
        Me.cmdOutlierTest.Size = New System.Drawing.Size(69, 30)
        Me.cmdOutlierTest.TabIndex = 158
        Me.cmdOutlierTest.Text = "outlierTest"
        Me.cmdOutlierTest.UseVisualStyleBackColor = True
        '
        'cmdBIC
        '
        Me.cmdBIC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBIC.Location = New System.Drawing.Point(3, 70)
        Me.cmdBIC.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBIC.Name = "cmdBIC"
        Me.cmdBIC.Size = New System.Drawing.Size(69, 30)
        Me.cmdBIC.TabIndex = 157
        Me.cmdBIC.Text = "BIC"
        Me.cmdBIC.UseVisualStyleBackColor = True
        '
        'cmdAIC
        '
        Me.cmdAIC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAIC.Location = New System.Drawing.Point(140, 41)
        Me.cmdAIC.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAIC.Name = "cmdAIC"
        Me.cmdAIC.Size = New System.Drawing.Size(69, 30)
        Me.cmdAIC.TabIndex = 156
        Me.cmdAIC.Text = "AIC"
        Me.cmdAIC.UseVisualStyleBackColor = True
        '
        'cmdCoefficient
        '
        Me.cmdCoefficient.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCoefficient.Location = New System.Drawing.Point(72, 41)
        Me.cmdCoefficient.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCoefficient.Name = "cmdCoefficient"
        Me.cmdCoefficient.Size = New System.Drawing.Size(69, 30)
        Me.cmdCoefficient.TabIndex = 155
        Me.cmdCoefficient.Text = "coefficient"
        Me.cmdCoefficient.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPrint.Location = New System.Drawing.Point(3, 41)
        Me.cmdPrint.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(69, 30)
        Me.cmdPrint.TabIndex = 154
        Me.cmdPrint.Text = "print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'grpPrediction
        '
        Me.grpPrediction.Controls.Add(Me.cmdPredict)
        Me.grpPrediction.Location = New System.Drawing.Point(260, 106)
        Me.grpPrediction.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpPrediction.Name = "grpPrediction"
        Me.grpPrediction.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpPrediction.Size = New System.Drawing.Size(213, 45)
        Me.grpPrediction.TabIndex = 27
        Me.grpPrediction.TabStop = False
        Me.grpPrediction.Text = "Prediction"
        '
        'cmdPredict
        '
        Me.cmdPredict.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPredict.Location = New System.Drawing.Point(3, 12)
        Me.cmdPredict.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPredict.Name = "cmdPredict"
        Me.cmdPredict.Size = New System.Drawing.Size(72, 30)
        Me.cmdPredict.TabIndex = 124
        Me.cmdPredict.Text = "prediction"
        Me.cmdPredict.UseVisualStyleBackColor = True
        '
        'lblModels
        '
        Me.lblModels.AutoSize = True
        Me.lblModels.Location = New System.Drawing.Point(84, 49)
        Me.lblModels.Name = "lblModels"
        Me.lblModels.Size = New System.Drawing.Size(44, 13)
        Me.lblModels.TabIndex = 28
        Me.lblModels.Text = "Models:"
        '
        'grpExtrRemes
        '
        Me.grpExtrRemes.Controls.Add(Me.cmdPlotFevd)
        Me.grpExtrRemes.Controls.Add(Me.cmdSummaryFevd)
        Me.grpExtrRemes.Controls.Add(Me.cmdPrintFevd)
        Me.grpExtrRemes.Controls.Add(Me.cmdLrTest)
        Me.grpExtrRemes.Controls.Add(Me.cmdIsFixedfevd)
        Me.grpExtrRemes.Controls.Add(Me.cmdFindpars)
        Me.grpExtrRemes.Controls.Add(Me.cmdDistill)
        Me.grpExtrRemes.Controls.Add(Me.cmdCi)
        Me.grpExtrRemes.Controls.Add(Me.cmdErlevd)
        Me.grpExtrRemes.Location = New System.Drawing.Point(260, 108)
        Me.grpExtrRemes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpExtrRemes.Name = "grpExtrRemes"
        Me.grpExtrRemes.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpExtrRemes.Size = New System.Drawing.Size(227, 110)
        Me.grpExtrRemes.TabIndex = 30
        Me.grpExtrRemes.TabStop = False
        Me.grpExtrRemes.Text = "extRemes"
        '
        'cmdPlotFevd
        '
        Me.cmdPlotFevd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlotFevd.Location = New System.Drawing.Point(152, 15)
        Me.cmdPlotFevd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPlotFevd.Name = "cmdPlotFevd"
        Me.cmdPlotFevd.Size = New System.Drawing.Size(69, 30)
        Me.cmdPlotFevd.TabIndex = 159
        Me.cmdPlotFevd.Text = "plot"
        Me.cmdPlotFevd.UseVisualStyleBackColor = True
        '
        'cmdSummaryFevd
        '
        Me.cmdSummaryFevd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSummaryFevd.Location = New System.Drawing.Point(70, 15)
        Me.cmdSummaryFevd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSummaryFevd.Name = "cmdSummaryFevd"
        Me.cmdSummaryFevd.Size = New System.Drawing.Size(83, 30)
        Me.cmdSummaryFevd.TabIndex = 158
        Me.cmdSummaryFevd.Text = "summary"
        Me.cmdSummaryFevd.UseVisualStyleBackColor = True
        '
        'cmdPrintFevd
        '
        Me.cmdPrintFevd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPrintFevd.Location = New System.Drawing.Point(2, 15)
        Me.cmdPrintFevd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPrintFevd.Name = "cmdPrintFevd"
        Me.cmdPrintFevd.Size = New System.Drawing.Size(69, 30)
        Me.cmdPrintFevd.TabIndex = 157
        Me.cmdPrintFevd.Text = "print"
        Me.cmdPrintFevd.UseVisualStyleBackColor = True
        '
        'cmdLrTest
        '
        Me.cmdLrTest.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLrTest.Location = New System.Drawing.Point(152, 73)
        Me.cmdLrTest.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLrTest.Name = "cmdLrTest"
        Me.cmdLrTest.Size = New System.Drawing.Size(69, 30)
        Me.cmdLrTest.TabIndex = 156
        Me.cmdLrTest.Text = "lr.Test"
        Me.cmdLrTest.UseVisualStyleBackColor = True
        '
        'cmdIsFixedfevd
        '
        Me.cmdIsFixedfevd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdIsFixedfevd.Location = New System.Drawing.Point(70, 73)
        Me.cmdIsFixedfevd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdIsFixedfevd.Name = "cmdIsFixedfevd"
        Me.cmdIsFixedfevd.Size = New System.Drawing.Size(83, 30)
        Me.cmdIsFixedfevd.TabIndex = 155
        Me.cmdIsFixedfevd.Text = "is.fixedfevd"
        Me.cmdIsFixedfevd.UseVisualStyleBackColor = True
        '
        'cmdFindpars
        '
        Me.cmdFindpars.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFindpars.Location = New System.Drawing.Point(2, 73)
        Me.cmdFindpars.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdFindpars.Name = "cmdFindpars"
        Me.cmdFindpars.Size = New System.Drawing.Size(69, 30)
        Me.cmdFindpars.TabIndex = 154
        Me.cmdFindpars.Text = "findpars"
        Me.cmdFindpars.UseVisualStyleBackColor = True
        '
        'cmdDistill
        '
        Me.cmdDistill.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDistill.Location = New System.Drawing.Point(70, 44)
        Me.cmdDistill.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDistill.Name = "cmdDistill"
        Me.cmdDistill.Size = New System.Drawing.Size(83, 30)
        Me.cmdDistill.TabIndex = 126
        Me.cmdDistill.Text = "distill"
        Me.cmdDistill.UseVisualStyleBackColor = True
        '
        'cmdCi
        '
        Me.cmdCi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCi.Location = New System.Drawing.Point(2, 44)
        Me.cmdCi.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCi.Name = "cmdCi"
        Me.cmdCi.Size = New System.Drawing.Size(69, 30)
        Me.cmdCi.TabIndex = 124
        Me.cmdCi.Text = "ci"
        Me.cmdCi.UseVisualStyleBackColor = True
        '
        'cmdErlevd
        '
        Me.cmdErlevd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdErlevd.Location = New System.Drawing.Point(152, 44)
        Me.cmdErlevd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdErlevd.Name = "cmdErlevd"
        Me.cmdErlevd.Size = New System.Drawing.Size(69, 30)
        Me.cmdErlevd.TabIndex = 153
        Me.cmdErlevd.Text = "erlevd"
        Me.cmdErlevd.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClear.Location = New System.Drawing.Point(397, 254)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(74, 23)
        Me.cmdClear.TabIndex = 31
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'lblRpackage
        '
        Me.lblRpackage.AutoSize = True
        Me.lblRpackage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRpackage.Location = New System.Drawing.Point(260, 83)
        Me.lblRpackage.Name = "lblRpackage"
        Me.lblRpackage.Size = New System.Drawing.Size(63, 13)
        Me.lblRpackage.TabIndex = 36
        Me.lblRpackage.Text = "R package:"
        '
        'grpSegmented
        '
        Me.grpSegmented.Controls.Add(Me.cmdSlope)
        Me.grpSegmented.Controls.Add(Me.cmdPscore)
        Me.grpSegmented.Controls.Add(Me.cmdDavies)
        Me.grpSegmented.Controls.Add(Me.cmdIntercept)
        Me.grpSegmented.Controls.Add(Me.cmdBroken)
        Me.grpSegmented.Controls.Add(Me.cmdPoints)
        Me.grpSegmented.Controls.Add(Me.cmdPlotLines)
        Me.grpSegmented.Controls.Add(Me.cmdSegmentedPredict)
        Me.grpSegmented.Controls.Add(Me.cmdVcov)
        Me.grpSegmented.Controls.Add(Me.cmdConfint)
        Me.grpSegmented.Controls.Add(Me.cmdSegmentedSummary)
        Me.grpSegmented.Controls.Add(Me.cmdAapc)
        Me.grpSegmented.Controls.Add(Me.cmdSegmented)
        Me.grpSegmented.Controls.Add(Me.cmdSegmentedPrint)
        Me.grpSegmented.Location = New System.Drawing.Point(260, 107)
        Me.grpSegmented.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpSegmented.Name = "grpSegmented"
        Me.grpSegmented.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpSegmented.Size = New System.Drawing.Size(277, 134)
        Me.grpSegmented.TabIndex = 162
        Me.grpSegmented.TabStop = False
        Me.grpSegmented.Text = "segmented"
        '
        'cmdSlope
        '
        Me.cmdSlope.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSlope.Location = New System.Drawing.Point(208, 70)
        Me.cmdSlope.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSlope.Name = "cmdSlope"
        Me.cmdSlope.Size = New System.Drawing.Size(69, 30)
        Me.cmdSlope.TabIndex = 164
        Me.cmdSlope.Text = "slope"
        Me.cmdSlope.UseVisualStyleBackColor = True
        '
        'cmdPscore
        '
        Me.cmdPscore.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPscore.Location = New System.Drawing.Point(140, 10)
        Me.cmdPscore.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPscore.Name = "cmdPscore"
        Me.cmdPscore.Size = New System.Drawing.Size(69, 30)
        Me.cmdPscore.TabIndex = 163
        Me.cmdPscore.Text = "pscore"
        Me.cmdPscore.UseVisualStyleBackColor = True
        '
        'cmdDavies
        '
        Me.cmdDavies.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDavies.Location = New System.Drawing.Point(3, 10)
        Me.cmdDavies.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDavies.Name = "cmdDavies"
        Me.cmdDavies.Size = New System.Drawing.Size(69, 30)
        Me.cmdDavies.TabIndex = 162
        Me.cmdDavies.Text = "davies"
        Me.cmdDavies.UseVisualStyleBackColor = True
        '
        'cmdIntercept
        '
        Me.cmdIntercept.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdIntercept.Location = New System.Drawing.Point(140, 100)
        Me.cmdIntercept.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdIntercept.Name = "cmdIntercept"
        Me.cmdIntercept.Size = New System.Drawing.Size(69, 30)
        Me.cmdIntercept.TabIndex = 161
        Me.cmdIntercept.Text = "intercept"
        Me.cmdIntercept.UseVisualStyleBackColor = True
        '
        'cmdBroken
        '
        Me.cmdBroken.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBroken.Location = New System.Drawing.Point(3, 100)
        Me.cmdBroken.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBroken.Name = "cmdBroken"
        Me.cmdBroken.Size = New System.Drawing.Size(69, 30)
        Me.cmdBroken.TabIndex = 160
        Me.cmdBroken.Text = "broken"
        Me.cmdBroken.UseVisualStyleBackColor = True
        '
        'cmdPoints
        '
        Me.cmdPoints.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPoints.Location = New System.Drawing.Point(140, 70)
        Me.cmdPoints.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPoints.Name = "cmdPoints"
        Me.cmdPoints.Size = New System.Drawing.Size(69, 30)
        Me.cmdPoints.TabIndex = 159
        Me.cmdPoints.Text = "points"
        Me.cmdPoints.UseVisualStyleBackColor = True
        '
        'cmdPlotLines
        '
        Me.cmdPlotLines.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlotLines.Location = New System.Drawing.Point(72, 70)
        Me.cmdPlotLines.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPlotLines.Name = "cmdPlotLines"
        Me.cmdPlotLines.Size = New System.Drawing.Size(69, 30)
        Me.cmdPlotLines.TabIndex = 158
        Me.cmdPlotLines.Text = "plot "
        Me.cmdPlotLines.UseVisualStyleBackColor = True
        '
        'cmdSegmentedPredict
        '
        Me.cmdSegmentedPredict.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSegmentedPredict.Location = New System.Drawing.Point(3, 70)
        Me.cmdSegmentedPredict.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSegmentedPredict.Name = "cmdSegmentedPredict"
        Me.cmdSegmentedPredict.Size = New System.Drawing.Size(69, 30)
        Me.cmdSegmentedPredict.TabIndex = 157
        Me.cmdSegmentedPredict.Text = "predict"
        Me.cmdSegmentedPredict.UseVisualStyleBackColor = True
        '
        'cmdVcov
        '
        Me.cmdVcov.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdVcov.Location = New System.Drawing.Point(140, 41)
        Me.cmdVcov.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdVcov.Name = "cmdVcov"
        Me.cmdVcov.Size = New System.Drawing.Size(69, 30)
        Me.cmdVcov.TabIndex = 156
        Me.cmdVcov.Text = "vcov"
        Me.cmdVcov.UseVisualStyleBackColor = True
        '
        'cmdConfint
        '
        Me.cmdConfint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfint.Location = New System.Drawing.Point(72, 41)
        Me.cmdConfint.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdConfint.Name = "cmdConfint"
        Me.cmdConfint.Size = New System.Drawing.Size(69, 30)
        Me.cmdConfint.TabIndex = 155
        Me.cmdConfint.Text = "confint"
        Me.cmdConfint.UseVisualStyleBackColor = True
        '
        'cmdSegmentedSummary
        '
        Me.cmdSegmentedSummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSegmentedSummary.Location = New System.Drawing.Point(3, 41)
        Me.cmdSegmentedSummary.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSegmentedSummary.Name = "cmdSegmentedSummary"
        Me.cmdSegmentedSummary.Size = New System.Drawing.Size(69, 30)
        Me.cmdSegmentedSummary.TabIndex = 154
        Me.cmdSegmentedSummary.Text = "summary"
        Me.cmdSegmentedSummary.UseVisualStyleBackColor = True
        '
        'cmdAapc
        '
        Me.cmdAapc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAapc.Location = New System.Drawing.Point(72, 100)
        Me.cmdAapc.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAapc.Name = "cmdAapc"
        Me.cmdAapc.Size = New System.Drawing.Size(69, 30)
        Me.cmdAapc.TabIndex = 126
        Me.cmdAapc.Text = "aapc"
        Me.cmdAapc.UseVisualStyleBackColor = True
        '
        'cmdSegmented
        '
        Me.cmdSegmented.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSegmented.Location = New System.Drawing.Point(72, 10)
        Me.cmdSegmented.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSegmented.Name = "cmdSegmented"
        Me.cmdSegmented.Size = New System.Drawing.Size(69, 30)
        Me.cmdSegmented.TabIndex = 124
        Me.cmdSegmented.Text = "segmented"
        Me.cmdSegmented.UseVisualStyleBackColor = True
        '
        'cmdSegmentedPrint
        '
        Me.cmdSegmentedPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSegmentedPrint.Location = New System.Drawing.Point(208, 41)
        Me.cmdSegmentedPrint.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSegmentedPrint.Name = "cmdSegmentedPrint"
        Me.cmdSegmentedPrint.Size = New System.Drawing.Size(69, 30)
        Me.cmdSegmentedPrint.TabIndex = 153
        Me.cmdSegmentedPrint.Text = "print"
        Me.cmdSegmentedPrint.UseVisualStyleBackColor = True
        '
        'ContextMenuStripPrediction
        '
        Me.ContextMenuStripPrediction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuPrediction})
        Me.ContextMenuStripPrediction.Name = "ContextMenuStrip1"
        Me.ContextMenuStripPrediction.Size = New System.Drawing.Size(129, 26)
        '
        'ToolStripMenuPrediction
        '
        Me.ToolStripMenuPrediction.Name = "ToolStripMenuPrediction"
        Me.ToolStripMenuPrediction.Size = New System.Drawing.Size(128, 22)
        Me.ToolStripMenuPrediction.Text = "prediction"
        '
        'ContextMenuStripGeneral
        '
        Me.ContextMenuStripGeneral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuStats, Me.ToolStripMenuCar})
        Me.ContextMenuStripGeneral.Name = "ContextMenuStrip1"
        Me.ContextMenuStripGeneral.Size = New System.Drawing.Size(99, 48)
        '
        'ToolStripMenuStats
        '
        Me.ToolStripMenuStats.Name = "ToolStripMenuStats"
        Me.ToolStripMenuStats.Size = New System.Drawing.Size(98, 22)
        Me.ToolStripMenuStats.Text = "stats"
        '
        'ToolStripMenuCar
        '
        Me.ToolStripMenuCar.Name = "ToolStripMenuCar"
        Me.ToolStripMenuCar.Size = New System.Drawing.Size(98, 22)
        Me.ToolStripMenuCar.Text = "car"
        '
        'ContextMenuStripExtRemes
        '
        Me.ContextMenuStripExtRemes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuExtRemes})
        Me.ContextMenuStripExtRemes.Name = "ContextMenuStrip1"
        Me.ContextMenuStripExtRemes.Size = New System.Drawing.Size(126, 26)
        '
        'ToolStripMenuExtRemes
        '
        Me.ToolStripMenuExtRemes.Name = "ToolStripMenuExtRemes"
        Me.ToolStripMenuExtRemes.Size = New System.Drawing.Size(125, 22)
        Me.ToolStripMenuExtRemes.Text = "extRemes"
        '
        'ContextMenuStripSegmented
        '
        Me.ContextMenuStripSegmented.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuSegmented})
        Me.ContextMenuStripSegmented.Name = "ContextMenuStrip1"
        Me.ContextMenuStripSegmented.Size = New System.Drawing.Size(134, 26)
        '
        'ToolStripMenuSegmented
        '
        Me.ToolStripMenuSegmented.Name = "ToolStripMenuSegmented"
        Me.ToolStripMenuSegmented.Size = New System.Drawing.Size(133, 22)
        Me.ToolStripMenuSegmented.Text = "segmented"
        '
        'grpEmmeans
        '
        Me.grpEmmeans.Controls.Add(Me.cmdcurlySign)
        Me.grpEmmeans.Controls.Add(Me.cmdQuotes)
        Me.grpEmmeans.Controls.Add(Me.cmdXtable)
        Me.grpEmmeans.Controls.Add(Me.cmdTest)
        Me.grpEmmeans.Controls.Add(Me.cmdPairs)
        Me.grpEmmeans.Controls.Add(Me.cmdRefgrid)
        Me.grpEmmeans.Controls.Add(Me.cmdEmmeansSummary)
        Me.grpEmmeans.Controls.Add(Me.cmdpwpp)
        Me.grpEmmeans.Controls.Add(Me.cmdEmmeansPlot)
        Me.grpEmmeans.Controls.Add(Me.cmdIntplot)
        Me.grpEmmeans.Controls.Add(Me.cmdContrast)
        Me.grpEmmeans.Controls.Add(Me.cmdEmmeanConfint)
        Me.grpEmmeans.Controls.Add(Me.cmdTrends)
        Me.grpEmmeans.Controls.Add(Me.cmdEmmeans)
        Me.grpEmmeans.Controls.Add(Me.cmdJoint)
        Me.grpEmmeans.Location = New System.Drawing.Point(260, 106)
        Me.grpEmmeans.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpEmmeans.Name = "grpEmmeans"
        Me.grpEmmeans.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpEmmeans.Size = New System.Drawing.Size(282, 142)
        Me.grpEmmeans.TabIndex = 162
        Me.grpEmmeans.TabStop = False
        Me.grpEmmeans.Text = "Emmeans"
        '
        'cmdcurlySign
        '
        Me.cmdcurlySign.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdcurlySign.Location = New System.Drawing.Point(140, 99)
        Me.cmdcurlySign.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdcurlySign.Name = "cmdcurlySign"
        Me.cmdcurlySign.Size = New System.Drawing.Size(69, 30)
        Me.cmdcurlySign.TabIndex = 167
        Me.cmdcurlySign.Text = "~"
        Me.cmdcurlySign.UseVisualStyleBackColor = True
        '
        'cmdQuotes
        '
        Me.cmdQuotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQuotes.Location = New System.Drawing.Point(72, 99)
        Me.cmdQuotes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQuotes.Name = "cmdQuotes"
        Me.cmdQuotes.Size = New System.Drawing.Size(69, 30)
        Me.cmdQuotes.TabIndex = 166
        Me.cmdQuotes.Text = """   """
        Me.cmdQuotes.UseVisualStyleBackColor = True
        '
        'cmdXtable
        '
        Me.cmdXtable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdXtable.Location = New System.Drawing.Point(3, 99)
        Me.cmdXtable.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdXtable.Name = "cmdXtable"
        Me.cmdXtable.Size = New System.Drawing.Size(69, 30)
        Me.cmdXtable.TabIndex = 165
        Me.cmdXtable.Text = "xtable"
        Me.cmdXtable.UseVisualStyleBackColor = True
        '
        'cmdTest
        '
        Me.cmdTest.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTest.Location = New System.Drawing.Point(209, 70)
        Me.cmdTest.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(69, 30)
        Me.cmdTest.TabIndex = 164
        Me.cmdTest.Text = "test"
        Me.cmdTest.UseVisualStyleBackColor = True
        '
        'cmdPairs
        '
        Me.cmdPairs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPairs.Location = New System.Drawing.Point(209, 41)
        Me.cmdPairs.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPairs.Name = "cmdPairs"
        Me.cmdPairs.Size = New System.Drawing.Size(69, 30)
        Me.cmdPairs.TabIndex = 163
        Me.cmdPairs.Text = "pairs"
        Me.cmdPairs.UseVisualStyleBackColor = True
        '
        'cmdRefgrid
        '
        Me.cmdRefgrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRefgrid.Location = New System.Drawing.Point(209, 12)
        Me.cmdRefgrid.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdRefgrid.Name = "cmdRefgrid"
        Me.cmdRefgrid.Size = New System.Drawing.Size(69, 30)
        Me.cmdRefgrid.TabIndex = 162
        Me.cmdRefgrid.Text = "refgrid"
        Me.cmdRefgrid.UseVisualStyleBackColor = True
        '
        'cmdEmmeansSummary
        '
        Me.cmdEmmeansSummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEmmeansSummary.Location = New System.Drawing.Point(140, 70)
        Me.cmdEmmeansSummary.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdEmmeansSummary.Name = "cmdEmmeansSummary"
        Me.cmdEmmeansSummary.Size = New System.Drawing.Size(69, 30)
        Me.cmdEmmeansSummary.TabIndex = 159
        Me.cmdEmmeansSummary.Text = "summary"
        Me.cmdEmmeansSummary.UseVisualStyleBackColor = True
        '
        'cmdpwpp
        '
        Me.cmdpwpp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdpwpp.Location = New System.Drawing.Point(72, 70)
        Me.cmdpwpp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdpwpp.Name = "cmdpwpp"
        Me.cmdpwpp.Size = New System.Drawing.Size(69, 30)
        Me.cmdpwpp.TabIndex = 158
        Me.cmdpwpp.Text = "pwpp"
        Me.cmdpwpp.UseVisualStyleBackColor = True
        '
        'cmdEmmeansPlot
        '
        Me.cmdEmmeansPlot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEmmeansPlot.Location = New System.Drawing.Point(3, 70)
        Me.cmdEmmeansPlot.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdEmmeansPlot.Name = "cmdEmmeansPlot"
        Me.cmdEmmeansPlot.Size = New System.Drawing.Size(69, 30)
        Me.cmdEmmeansPlot.TabIndex = 157
        Me.cmdEmmeansPlot.Text = "plot"
        Me.cmdEmmeansPlot.UseVisualStyleBackColor = True
        '
        'cmdIntplot
        '
        Me.cmdIntplot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdIntplot.Location = New System.Drawing.Point(140, 41)
        Me.cmdIntplot.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdIntplot.Name = "cmdIntplot"
        Me.cmdIntplot.Size = New System.Drawing.Size(69, 30)
        Me.cmdIntplot.TabIndex = 156
        Me.cmdIntplot.Text = "intplot"
        Me.cmdIntplot.UseVisualStyleBackColor = True
        '
        'cmdContrast
        '
        Me.cmdContrast.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdContrast.Location = New System.Drawing.Point(72, 41)
        Me.cmdContrast.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdContrast.Name = "cmdContrast"
        Me.cmdContrast.Size = New System.Drawing.Size(69, 30)
        Me.cmdContrast.TabIndex = 155
        Me.cmdContrast.Text = "contrast"
        Me.cmdContrast.UseVisualStyleBackColor = True
        '
        'cmdEmmeanConfint
        '
        Me.cmdEmmeanConfint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEmmeanConfint.Location = New System.Drawing.Point(3, 41)
        Me.cmdEmmeanConfint.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdEmmeanConfint.Name = "cmdEmmeanConfint"
        Me.cmdEmmeanConfint.Size = New System.Drawing.Size(69, 30)
        Me.cmdEmmeanConfint.TabIndex = 154
        Me.cmdEmmeanConfint.Text = "confint"
        Me.cmdEmmeanConfint.UseVisualStyleBackColor = True
        '
        'cmdTrends
        '
        Me.cmdTrends.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTrends.Location = New System.Drawing.Point(72, 12)
        Me.cmdTrends.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTrends.Name = "cmdTrends"
        Me.cmdTrends.Size = New System.Drawing.Size(69, 30)
        Me.cmdTrends.TabIndex = 126
        Me.cmdTrends.Text = "trends"
        Me.cmdTrends.UseVisualStyleBackColor = True
        '
        'cmdEmmeans
        '
        Me.cmdEmmeans.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEmmeans.Location = New System.Drawing.Point(3, 12)
        Me.cmdEmmeans.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdEmmeans.Name = "cmdEmmeans"
        Me.cmdEmmeans.Size = New System.Drawing.Size(69, 30)
        Me.cmdEmmeans.TabIndex = 124
        Me.cmdEmmeans.Text = "emmeans"
        Me.cmdEmmeans.UseVisualStyleBackColor = True
        '
        'cmdJoint
        '
        Me.cmdJoint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdJoint.Location = New System.Drawing.Point(140, 12)
        Me.cmdJoint.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdJoint.Name = "cmdJoint"
        Me.cmdJoint.Size = New System.Drawing.Size(69, 30)
        Me.cmdJoint.TabIndex = 153
        Me.cmdJoint.Text = "joint"
        Me.cmdJoint.UseVisualStyleBackColor = True
        '
        'ContextMenuStripEmmeans
        '
        Me.ContextMenuStripEmmeans.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuEmmeans})
        Me.ContextMenuStripEmmeans.Name = "ContextMenuStrip1"
        Me.ContextMenuStripEmmeans.Size = New System.Drawing.Size(127, 26)
        '
        'ToolStripMenuEmmeans
        '
        Me.ToolStripMenuEmmeans.Name = "ToolStripMenuEmmeans"
        Me.ToolStripMenuEmmeans.Size = New System.Drawing.Size(126, 22)
        Me.ToolStripMenuEmmeans.Text = "emmeans"
        '
        'cmdRHelpEmmeans
        '
        Me.cmdRHelpEmmeans.AutoSize = True
        Me.cmdRHelpEmmeans.ContextMenuStrip = Me.ContextMenuStripEmmeans
        Me.cmdRHelpEmmeans.Location = New System.Drawing.Point(460, 79)
        Me.cmdRHelpEmmeans.Name = "cmdRHelpEmmeans"
        Me.cmdRHelpEmmeans.Size = New System.Drawing.Size(68, 23)
        Me.cmdRHelpEmmeans.SplitMenuStrip = Me.ContextMenuStripEmmeans
        Me.cmdRHelpEmmeans.TabIndex = 223
        Me.cmdRHelpEmmeans.Text = "R Help"
        Me.cmdRHelpEmmeans.UseVisualStyleBackColor = True
        '
        'cmdRHelpSegmented
        '
        Me.cmdRHelpSegmented.AutoSize = True
        Me.cmdRHelpSegmented.ContextMenuStrip = Me.ContextMenuStripSegmented
        Me.cmdRHelpSegmented.Location = New System.Drawing.Point(460, 80)
        Me.cmdRHelpSegmented.Name = "cmdRHelpSegmented"
        Me.cmdRHelpSegmented.Size = New System.Drawing.Size(68, 23)
        Me.cmdRHelpSegmented.SplitMenuStrip = Me.ContextMenuStripSegmented
        Me.cmdRHelpSegmented.TabIndex = 222
        Me.cmdRHelpSegmented.Text = "R Help"
        Me.cmdRHelpSegmented.UseVisualStyleBackColor = True
        '
        'cmdRHelpExtRemes
        '
        Me.cmdRHelpExtRemes.AutoSize = True
        Me.cmdRHelpExtRemes.ContextMenuStrip = Me.ContextMenuStripExtRemes
        Me.cmdRHelpExtRemes.Location = New System.Drawing.Point(461, 79)
        Me.cmdRHelpExtRemes.Name = "cmdRHelpExtRemes"
        Me.cmdRHelpExtRemes.Size = New System.Drawing.Size(68, 23)
        Me.cmdRHelpExtRemes.SplitMenuStrip = Me.ContextMenuStripExtRemes
        Me.cmdRHelpExtRemes.TabIndex = 221
        Me.cmdRHelpExtRemes.Text = "R Help"
        Me.cmdRHelpExtRemes.UseVisualStyleBackColor = True
        '
        'cmdRHelpGeneral
        '
        Me.cmdRHelpGeneral.AutoSize = True
        Me.cmdRHelpGeneral.ContextMenuStrip = Me.ContextMenuStripGeneral
        Me.cmdRHelpGeneral.Location = New System.Drawing.Point(460, 80)
        Me.cmdRHelpGeneral.Name = "cmdRHelpGeneral"
        Me.cmdRHelpGeneral.Size = New System.Drawing.Size(68, 23)
        Me.cmdRHelpGeneral.SplitMenuStrip = Me.ContextMenuStripGeneral
        Me.cmdRHelpGeneral.TabIndex = 220
        Me.cmdRHelpGeneral.Text = "R Help"
        Me.cmdRHelpGeneral.UseVisualStyleBackColor = True
        '
        'cmdRHelpPrediction
        '
        Me.cmdRHelpPrediction.AutoSize = True
        Me.cmdRHelpPrediction.ContextMenuStrip = Me.ContextMenuStripPrediction
        Me.cmdRHelpPrediction.Location = New System.Drawing.Point(460, 79)
        Me.cmdRHelpPrediction.Name = "cmdRHelpPrediction"
        Me.cmdRHelpPrediction.Size = New System.Drawing.Size(68, 23)
        Me.cmdRHelpPrediction.SplitMenuStrip = Me.ContextMenuStripPrediction
        Me.cmdRHelpPrediction.TabIndex = 219
        Me.cmdRHelpPrediction.Text = "R Help"
        Me.cmdRHelpPrediction.UseVisualStyleBackColor = True
        '
        'ucrTryModelling
        '
        Me.ucrTryModelling.AutoSize = True
        Me.ucrTryModelling.Location = New System.Drawing.Point(2, 285)
        Me.ucrTryModelling.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrTryModelling.Name = "ucrTryModelling"
        Me.ucrTryModelling.RunCommandAsMultipleLines = False
        Me.ucrTryModelling.Size = New System.Drawing.Size(480, 37)
        Me.ucrTryModelling.TabIndex = 163
        '
        'ucrSaveResult
        '
        Me.ucrSaveResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveResult.Location = New System.Drawing.Point(10, 329)
        Me.ucrSaveResult.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveResult.Name = "ucrSaveResult"
        Me.ucrSaveResult.Size = New System.Drawing.Size(277, 24)
        Me.ucrSaveResult.TabIndex = 35
        '
        'ucrChkIncludeArguments
        '
        Me.ucrChkIncludeArguments.AutoSize = True
        Me.ucrChkIncludeArguments.Checked = False
        Me.ucrChkIncludeArguments.Location = New System.Drawing.Point(445, 12)
        Me.ucrChkIncludeArguments.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkIncludeArguments.Name = "ucrChkIncludeArguments"
        Me.ucrChkIncludeArguments.Size = New System.Drawing.Size(130, 23)
        Me.ucrChkIncludeArguments.TabIndex = 32
        '
        'ucrInputModels
        '
        Me.ucrInputModels.AddQuotesIfUnrecognised = True
        Me.ucrInputModels.AutoSize = True
        Me.ucrInputModels.IsMultiline = False
        Me.ucrInputModels.IsReadOnly = False
        Me.ucrInputModels.Location = New System.Drawing.Point(133, 45)
        Me.ucrInputModels.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputModels.Name = "ucrInputModels"
        Me.ucrInputModels.Size = New System.Drawing.Size(214, 21)
        Me.ucrInputModels.TabIndex = 29
        '
        'ucrSelectorUseModel
        '
        Me.ucrSelectorUseModel.AutoSize = True
        Me.ucrSelectorUseModel.bDropUnusedFilterLevels = False
        Me.ucrSelectorUseModel.bShowHiddenColumns = False
        Me.ucrSelectorUseModel.bUseCurrentFilter = True
        Me.ucrSelectorUseModel.Location = New System.Drawing.Point(10, 68)
        Me.ucrSelectorUseModel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorUseModel.Name = "ucrSelectorUseModel"
        Me.ucrSelectorUseModel.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorUseModel.TabIndex = 26
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 362)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 20
        '
        'ucrReceiverForTestColumn
        '
        Me.ucrReceiverForTestColumn.AutoSize = True
        Me.ucrReceiverForTestColumn.frmParent = Me
        Me.ucrReceiverForTestColumn.Location = New System.Drawing.Point(82, 11)
        Me.ucrReceiverForTestColumn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrReceiverForTestColumn.Name = "ucrReceiverForTestColumn"
        Me.ucrReceiverForTestColumn.Selector = Nothing
        Me.ucrReceiverForTestColumn.Size = New System.Drawing.Size(358, 27)
        Me.ucrReceiverForTestColumn.strNcFilePath = ""
        Me.ucrReceiverForTestColumn.TabIndex = 12
        Me.ucrReceiverForTestColumn.ucrSelector = Nothing
        '
        'ucrInputComboRPackage
        '
        Me.ucrInputComboRPackage.AddQuotesIfUnrecognised = True
        Me.ucrInputComboRPackage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboRPackage.GetSetSelectedIndex = -1
        Me.ucrInputComboRPackage.IsReadOnly = False
        Me.ucrInputComboRPackage.Location = New System.Drawing.Point(328, 80)
        Me.ucrInputComboRPackage.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputComboRPackage.Name = "ucrInputComboRPackage"
        Me.ucrInputComboRPackage.Size = New System.Drawing.Size(122, 21)
        Me.ucrInputComboRPackage.TabIndex = 5
        '
        'dlgUseModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(582, 423)
        Me.Controls.Add(Me.cmdRHelpEmmeans)
        Me.Controls.Add(Me.cmdRHelpSegmented)
        Me.Controls.Add(Me.cmdRHelpExtRemes)
        Me.Controls.Add(Me.cmdRHelpGeneral)
        Me.Controls.Add(Me.cmdRHelpPrediction)
        Me.Controls.Add(Me.ucrTryModelling)
        Me.Controls.Add(Me.lblRpackage)
        Me.Controls.Add(Me.ucrSaveResult)
        Me.Controls.Add(Me.ucrChkIncludeArguments)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.ucrInputModels)
        Me.Controls.Add(Me.lblModels)
        Me.Controls.Add(Me.ucrSelectorUseModel)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.ucrReceiverForTestColumn)
        Me.Controls.Add(Me.ucrInputComboRPackage)
        Me.Controls.Add(Me.grpSegmented)
        Me.Controls.Add(Me.grpGeneral)
        Me.Controls.Add(Me.grpExtrRemes)
        Me.Controls.Add(Me.grpPrediction)
        Me.Controls.Add(Me.grpEmmeans)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimizeBox = False
        Me.Name = "dlgUseModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Use Model "
        Me.grpGeneral.ResumeLayout(False)
        Me.grpPrediction.ResumeLayout(False)
        Me.grpExtrRemes.ResumeLayout(False)
        Me.grpSegmented.ResumeLayout(False)
        Me.ContextMenuStripPrediction.ResumeLayout(False)
        Me.ContextMenuStripGeneral.ResumeLayout(False)
        Me.ContextMenuStripExtRemes.ResumeLayout(False)
        Me.ContextMenuStripSegmented.ResumeLayout(False)
        Me.grpEmmeans.ResumeLayout(False)
        Me.ContextMenuStripEmmeans.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrInputComboRPackage As ucrInputComboBox
    Friend WithEvents lblModel As Label
    Friend WithEvents ucrReceiverForTestColumn As ucrReceiverExpression
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpGeneral As GroupBox
    Friend WithEvents cmdsummary As Button
    Friend WithEvents cmdanova As Button
    Friend WithEvents cmdresiduals As Button
    Friend WithEvents ucrSelectorUseModel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpPrediction As GroupBox
    Friend WithEvents cmdPredict As Button
    Friend WithEvents ucrInputModels As ucrInputTextBox
    Friend WithEvents lblModels As Label
    Friend WithEvents cmdNcvTest As Button
    Friend WithEvents cmdOutlierTest As Button
    Friend WithEvents cmdBIC As Button
    Friend WithEvents cmdAIC As Button
    Friend WithEvents cmdCoefficient As Button
    Friend WithEvents cmdPrint As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cmdDurbinWatsonTest As Button
    Friend WithEvents grpExtrRemes As GroupBox
    Friend WithEvents cmdLrTest As Button
    Friend WithEvents cmdIsFixedfevd As Button
    Friend WithEvents cmdFindpars As Button
    Friend WithEvents cmdDistill As Button
    Friend WithEvents cmdCi As Button
    Friend WithEvents cmdErlevd As Button
    Friend WithEvents cmdClear As Button

    Friend WithEvents ucrChkIncludeArguments As ucrCheck
    Friend WithEvents ucrSaveResult As ucrSave
    Friend WithEvents lblRpackage As Label
    Friend WithEvents cmdPlotFevd As Button
    Friend WithEvents cmdSummaryFevd As Button
    Friend WithEvents cmdPrintFevd As Button

    Friend WithEvents grpSegmented As GroupBox
    Friend WithEvents cmdIntercept As Button
    Friend WithEvents cmdBroken As Button
    Friend WithEvents cmdPoints As Button
    Friend WithEvents cmdPlotLines As Button
    Friend WithEvents cmdSegmentedPredict As Button
    Friend WithEvents cmdVcov As Button
    Friend WithEvents cmdConfint As Button
    Friend WithEvents cmdSegmentedSummary As Button
    Friend WithEvents cmdAapc As Button
    Friend WithEvents cmdSegmented As Button
    Friend WithEvents cmdSegmentedPrint As Button
    Friend WithEvents cmdDavies As Button
    Friend WithEvents cmdSlope As Button
    Friend WithEvents cmdPscore As Button
    Friend WithEvents ucrTryModelling As ucrTry
    Friend WithEvents cmdRHelpSegmented As ucrSplitButton
    Friend WithEvents cmdRHelpExtRemes As ucrSplitButton
    Friend WithEvents cmdRHelpGeneral As ucrSplitButton
    Friend WithEvents cmdRHelpPrediction As ucrSplitButton
    Friend WithEvents ContextMenuStripGeneral As ContextMenuStrip
    Friend WithEvents ToolStripMenuStats As ToolStripMenuItem
    Friend WithEvents ToolStripMenuCar As ToolStripMenuItem
    Friend WithEvents ContextMenuStripPrediction As ContextMenuStrip
    Friend WithEvents ToolStripMenuPrediction As ToolStripMenuItem
    Friend WithEvents ContextMenuStripExtRemes As ContextMenuStrip
    Friend WithEvents ToolStripMenuExtRemes As ToolStripMenuItem
    Friend WithEvents ContextMenuStripSegmented As ContextMenuStrip
    Friend WithEvents ToolStripMenuSegmented As ToolStripMenuItem
    Friend WithEvents grpEmmeans As GroupBox
    Friend WithEvents cmdEmmeansSummary As Button
    Friend WithEvents cmdpwpp As Button
    Friend WithEvents cmdEmmeansPlot As Button
    Friend WithEvents cmdIntplot As Button
    Friend WithEvents cmdContrast As Button
    Friend WithEvents cmdEmmeanConfint As Button
    Friend WithEvents cmdTrends As Button
    Friend WithEvents cmdEmmeans As Button
    Friend WithEvents cmdJoint As Button
    Friend WithEvents cmdXtable As Button
    Friend WithEvents cmdTest As Button
    Friend WithEvents cmdPairs As Button
    Friend WithEvents cmdRefgrid As Button
    Friend WithEvents cmdRHelpEmmeans As ucrSplitButton
    Friend WithEvents ContextMenuStripEmmeans As ContextMenuStrip
    Friend WithEvents ToolStripMenuEmmeans As ToolStripMenuItem
    Friend WithEvents cmdcurlySign As Button
    Friend WithEvents cmdQuotes As Button
End Class
