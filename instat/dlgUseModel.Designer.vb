﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.lblRpackage = New System.Windows.Forms.Label()
        Me.ucrSaveResult = New instat.ucrSave()
        Me.ucrChkIncludeArguments = New instat.ucrCheck()
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
        Me.ucrInputModels = New instat.ucrInputTextBox()
        Me.ucrSelectorUseModel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverForTestColumn = New instat.ucrReceiverExpression()
        Me.ucrInputComboRPackage = New instat.ucrInputComboBox()
        Me.ucrTryModelling = New instat.ucrTry()
        Me.grpGeneral.SuspendLayout()
        Me.grpPrediction.SuspendLayout()
        Me.grpExtrRemes.SuspendLayout()
        Me.grpSegmented.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblModel.Location = New System.Drawing.Point(25, 22)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(77, 17)
        Me.lblModel.TabIndex = 11
        Me.lblModel.Tag = "Test"
        Me.lblModel.Text = "Expression"
        '
        'cmdsummary
        '
        Me.cmdsummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdsummary.Location = New System.Drawing.Point(96, 15)
        Me.cmdsummary.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdsummary.Name = "cmdsummary"
        Me.cmdsummary.Size = New System.Drawing.Size(92, 37)
        Me.cmdsummary.TabIndex = 126
        Me.cmdsummary.Text = "summary"
        Me.cmdsummary.UseVisualStyleBackColor = True
        '
        'cmdanova
        '
        Me.cmdanova.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdanova.Location = New System.Drawing.Point(4, 15)
        Me.cmdanova.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdanova.Name = "cmdanova"
        Me.cmdanova.Size = New System.Drawing.Size(92, 37)
        Me.cmdanova.TabIndex = 124
        Me.cmdanova.Text = "anova"
        Me.cmdanova.UseVisualStyleBackColor = True
        '
        'cmdresiduals
        '
        Me.cmdresiduals.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdresiduals.Location = New System.Drawing.Point(187, 15)
        Me.cmdresiduals.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdresiduals.Name = "cmdresiduals"
        Me.cmdresiduals.Size = New System.Drawing.Size(92, 37)
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
        Me.grpGeneral.Location = New System.Drawing.Point(344, 130)
        Me.grpGeneral.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpGeneral.Name = "grpGeneral"
        Me.grpGeneral.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpGeneral.Size = New System.Drawing.Size(284, 175)
        Me.grpGeneral.TabIndex = 25
        Me.grpGeneral.TabStop = False
        Me.grpGeneral.Text = "General"
        '
        'Button2
        '
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(187, 123)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 37)
        Me.Button2.TabIndex = 161
        Me.Button2.Text = "Anova"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdDurbinWatsonTest
        '
        Me.cmdDurbinWatsonTest.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDurbinWatsonTest.Location = New System.Drawing.Point(4, 123)
        Me.cmdDurbinWatsonTest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDurbinWatsonTest.Name = "cmdDurbinWatsonTest"
        Me.cmdDurbinWatsonTest.Size = New System.Drawing.Size(184, 37)
        Me.cmdDurbinWatsonTest.TabIndex = 160
        Me.cmdDurbinWatsonTest.Text = "durbinWatsonTest"
        Me.cmdDurbinWatsonTest.UseVisualStyleBackColor = True
        '
        'cmdNcvTest
        '
        Me.cmdNcvTest.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNcvTest.Location = New System.Drawing.Point(187, 86)
        Me.cmdNcvTest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdNcvTest.Name = "cmdNcvTest"
        Me.cmdNcvTest.Size = New System.Drawing.Size(92, 37)
        Me.cmdNcvTest.TabIndex = 159
        Me.cmdNcvTest.Text = "ncvTest"
        Me.cmdNcvTest.UseVisualStyleBackColor = True
        '
        'cmdOutlierTest
        '
        Me.cmdOutlierTest.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOutlierTest.Location = New System.Drawing.Point(96, 86)
        Me.cmdOutlierTest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdOutlierTest.Name = "cmdOutlierTest"
        Me.cmdOutlierTest.Size = New System.Drawing.Size(92, 37)
        Me.cmdOutlierTest.TabIndex = 158
        Me.cmdOutlierTest.Text = "outlierTest"
        Me.cmdOutlierTest.UseVisualStyleBackColor = True
        '
        'cmdBIC
        '
        Me.cmdBIC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBIC.Location = New System.Drawing.Point(4, 86)
        Me.cmdBIC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdBIC.Name = "cmdBIC"
        Me.cmdBIC.Size = New System.Drawing.Size(92, 37)
        Me.cmdBIC.TabIndex = 157
        Me.cmdBIC.Text = "BIC"
        Me.cmdBIC.UseVisualStyleBackColor = True
        '
        'cmdAIC
        '
        Me.cmdAIC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAIC.Location = New System.Drawing.Point(187, 50)
        Me.cmdAIC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdAIC.Name = "cmdAIC"
        Me.cmdAIC.Size = New System.Drawing.Size(92, 37)
        Me.cmdAIC.TabIndex = 156
        Me.cmdAIC.Text = "AIC"
        Me.cmdAIC.UseVisualStyleBackColor = True
        '
        'cmdCoefficient
        '
        Me.cmdCoefficient.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCoefficient.Location = New System.Drawing.Point(96, 50)
        Me.cmdCoefficient.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCoefficient.Name = "cmdCoefficient"
        Me.cmdCoefficient.Size = New System.Drawing.Size(92, 37)
        Me.cmdCoefficient.TabIndex = 155
        Me.cmdCoefficient.Text = "coefficient"
        Me.cmdCoefficient.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPrint.Location = New System.Drawing.Point(4, 50)
        Me.cmdPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(92, 37)
        Me.cmdPrint.TabIndex = 154
        Me.cmdPrint.Text = "print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'grpPrediction
        '
        Me.grpPrediction.Controls.Add(Me.cmdPredict)
        Me.grpPrediction.Location = New System.Drawing.Point(347, 130)
        Me.grpPrediction.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpPrediction.Name = "grpPrediction"
        Me.grpPrediction.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpPrediction.Size = New System.Drawing.Size(284, 55)
        Me.grpPrediction.TabIndex = 27
        Me.grpPrediction.TabStop = False
        Me.grpPrediction.Text = "Prediction"
        '
        'cmdPredict
        '
        Me.cmdPredict.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPredict.Location = New System.Drawing.Point(4, 15)
        Me.cmdPredict.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPredict.Name = "cmdPredict"
        Me.cmdPredict.Size = New System.Drawing.Size(96, 37)
        Me.cmdPredict.TabIndex = 124
        Me.cmdPredict.Text = "prediction"
        Me.cmdPredict.UseVisualStyleBackColor = True
        '
        'lblModels
        '
        Me.lblModels.AutoSize = True
        Me.lblModels.Location = New System.Drawing.Point(112, 60)
        Me.lblModels.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModels.Name = "lblModels"
        Me.lblModels.Size = New System.Drawing.Size(57, 17)
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
        Me.grpExtrRemes.Location = New System.Drawing.Point(347, 133)
        Me.grpExtrRemes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpExtrRemes.Name = "grpExtrRemes"
        Me.grpExtrRemes.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpExtrRemes.Size = New System.Drawing.Size(303, 136)
        Me.grpExtrRemes.TabIndex = 30
        Me.grpExtrRemes.TabStop = False
        Me.grpExtrRemes.Text = "extRemes"
        '
        'cmdPlotFevd
        '
        Me.cmdPlotFevd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlotFevd.Location = New System.Drawing.Point(203, 18)
        Me.cmdPlotFevd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPlotFevd.Name = "cmdPlotFevd"
        Me.cmdPlotFevd.Size = New System.Drawing.Size(92, 37)
        Me.cmdPlotFevd.TabIndex = 159
        Me.cmdPlotFevd.Text = "plot.fevd"
        Me.cmdPlotFevd.UseVisualStyleBackColor = True
        '
        'cmdSummaryFevd
        '
        Me.cmdSummaryFevd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSummaryFevd.Location = New System.Drawing.Point(93, 18)
        Me.cmdSummaryFevd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSummaryFevd.Name = "cmdSummaryFevd"
        Me.cmdSummaryFevd.Size = New System.Drawing.Size(111, 37)
        Me.cmdSummaryFevd.TabIndex = 158
        Me.cmdSummaryFevd.Text = "summary.fevd"
        Me.cmdSummaryFevd.UseVisualStyleBackColor = True
        '
        'cmdPrintFevd
        '
        Me.cmdPrintFevd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPrintFevd.Location = New System.Drawing.Point(2, 18)
        Me.cmdPrintFevd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPrintFevd.Name = "cmdPrintFevd"
        Me.cmdPrintFevd.Size = New System.Drawing.Size(92, 37)
        Me.cmdPrintFevd.TabIndex = 157
        Me.cmdPrintFevd.Text = "print.fevd"
        Me.cmdPrintFevd.UseVisualStyleBackColor = True
        '
        'cmdLrTest
        '
        Me.cmdLrTest.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLrTest.Location = New System.Drawing.Point(203, 90)
        Me.cmdLrTest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLrTest.Name = "cmdLrTest"
        Me.cmdLrTest.Size = New System.Drawing.Size(92, 37)
        Me.cmdLrTest.TabIndex = 156
        Me.cmdLrTest.Text = "lr.Test"
        Me.cmdLrTest.UseVisualStyleBackColor = True
        '
        'cmdIsFixedfevd
        '
        Me.cmdIsFixedfevd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdIsFixedfevd.Location = New System.Drawing.Point(93, 90)
        Me.cmdIsFixedfevd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdIsFixedfevd.Name = "cmdIsFixedfevd"
        Me.cmdIsFixedfevd.Size = New System.Drawing.Size(111, 37)
        Me.cmdIsFixedfevd.TabIndex = 155
        Me.cmdIsFixedfevd.Text = "is.fixedfevd"
        Me.cmdIsFixedfevd.UseVisualStyleBackColor = True
        '
        'cmdFindpars
        '
        Me.cmdFindpars.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFindpars.Location = New System.Drawing.Point(2, 90)
        Me.cmdFindpars.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFindpars.Name = "cmdFindpars"
        Me.cmdFindpars.Size = New System.Drawing.Size(92, 37)
        Me.cmdFindpars.TabIndex = 154
        Me.cmdFindpars.Text = "findpars"
        Me.cmdFindpars.UseVisualStyleBackColor = True
        '
        'cmdDistill
        '
        Me.cmdDistill.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDistill.Location = New System.Drawing.Point(93, 54)
        Me.cmdDistill.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDistill.Name = "cmdDistill"
        Me.cmdDistill.Size = New System.Drawing.Size(111, 37)
        Me.cmdDistill.TabIndex = 126
        Me.cmdDistill.Text = "distill"
        Me.cmdDistill.UseVisualStyleBackColor = True
        '
        'cmdCi
        '
        Me.cmdCi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCi.Location = New System.Drawing.Point(2, 54)
        Me.cmdCi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCi.Name = "cmdCi"
        Me.cmdCi.Size = New System.Drawing.Size(92, 37)
        Me.cmdCi.TabIndex = 124
        Me.cmdCi.Text = "ci"
        Me.cmdCi.UseVisualStyleBackColor = True
        '
        'cmdErlevd
        '
        Me.cmdErlevd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdErlevd.Location = New System.Drawing.Point(203, 54)
        Me.cmdErlevd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdErlevd.Name = "cmdErlevd"
        Me.cmdErlevd.Size = New System.Drawing.Size(92, 37)
        Me.cmdErlevd.TabIndex = 153
        Me.cmdErlevd.Text = "erlevd"
        Me.cmdErlevd.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClear.Location = New System.Drawing.Point(529, 313)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(99, 28)
        Me.cmdClear.TabIndex = 31
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHelp.Location = New System.Drawing.Point(613, 96)
        Me.cmdHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(80, 28)
        Me.cmdHelp.TabIndex = 33
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'lblRpackage
        '
        Me.lblRpackage.AutoSize = True
        Me.lblRpackage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRpackage.Location = New System.Drawing.Point(364, 102)
        Me.lblRpackage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRpackage.Name = "lblRpackage"
        Me.lblRpackage.Size = New System.Drawing.Size(80, 17)
        Me.lblRpackage.TabIndex = 36
        Me.lblRpackage.Text = "R package:"
        '
        'ucrSaveResult
        '
        Me.ucrSaveResult.Location = New System.Drawing.Point(12, 399)
        Me.ucrSaveResult.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveResult.Name = "ucrSaveResult"
        Me.ucrSaveResult.Size = New System.Drawing.Size(369, 30)
        Me.ucrSaveResult.TabIndex = 35
        '
        'ucrChkIncludeArguments
        '
        Me.ucrChkIncludeArguments.Checked = False
        Me.ucrChkIncludeArguments.Location = New System.Drawing.Point(593, 15)
        Me.ucrChkIncludeArguments.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrChkIncludeArguments.Name = "ucrChkIncludeArguments"
        Me.ucrChkIncludeArguments.Size = New System.Drawing.Size(173, 25)
        Me.ucrChkIncludeArguments.TabIndex = 32
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
        Me.grpSegmented.Location = New System.Drawing.Point(347, 132)
        Me.grpSegmented.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSegmented.Name = "grpSegmented"
        Me.grpSegmented.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSegmented.Size = New System.Drawing.Size(369, 165)
        Me.grpSegmented.TabIndex = 162
        Me.grpSegmented.TabStop = False
        Me.grpSegmented.Text = "segmented"
        '
        'cmdSlope
        '
        Me.cmdSlope.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSlope.Location = New System.Drawing.Point(277, 86)
        Me.cmdSlope.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSlope.Name = "cmdSlope"
        Me.cmdSlope.Size = New System.Drawing.Size(92, 37)
        Me.cmdSlope.TabIndex = 164
        Me.cmdSlope.Text = "slope"
        Me.cmdSlope.UseVisualStyleBackColor = True
        '
        'cmdPscore
        '
        Me.cmdPscore.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPscore.Location = New System.Drawing.Point(187, 12)
        Me.cmdPscore.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPscore.Name = "cmdPscore"
        Me.cmdPscore.Size = New System.Drawing.Size(92, 37)
        Me.cmdPscore.TabIndex = 163
        Me.cmdPscore.Text = "pscore"
        Me.cmdPscore.UseVisualStyleBackColor = True
        '
        'cmdDavies
        '
        Me.cmdDavies.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDavies.Location = New System.Drawing.Point(4, 12)
        Me.cmdDavies.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDavies.Name = "cmdDavies"
        Me.cmdDavies.Size = New System.Drawing.Size(92, 37)
        Me.cmdDavies.TabIndex = 162
        Me.cmdDavies.Text = "davies"
        Me.cmdDavies.UseVisualStyleBackColor = True
        '
        'cmdIntercept
        '
        Me.cmdIntercept.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdIntercept.Location = New System.Drawing.Point(187, 123)
        Me.cmdIntercept.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdIntercept.Name = "cmdIntercept"
        Me.cmdIntercept.Size = New System.Drawing.Size(92, 37)
        Me.cmdIntercept.TabIndex = 161
        Me.cmdIntercept.Text = "intercept"
        Me.cmdIntercept.UseVisualStyleBackColor = True
        '
        'cmdBroken
        '
        Me.cmdBroken.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBroken.Location = New System.Drawing.Point(4, 123)
        Me.cmdBroken.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdBroken.Name = "cmdBroken"
        Me.cmdBroken.Size = New System.Drawing.Size(92, 37)
        Me.cmdBroken.TabIndex = 160
        Me.cmdBroken.Text = "broken"
        Me.cmdBroken.UseVisualStyleBackColor = True
        '
        'cmdPoints
        '
        Me.cmdPoints.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPoints.Location = New System.Drawing.Point(187, 86)
        Me.cmdPoints.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPoints.Name = "cmdPoints"
        Me.cmdPoints.Size = New System.Drawing.Size(92, 37)
        Me.cmdPoints.TabIndex = 159
        Me.cmdPoints.Text = "points"
        Me.cmdPoints.UseVisualStyleBackColor = True
        '
        'cmdPlotLines
        '
        Me.cmdPlotLines.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlotLines.Location = New System.Drawing.Point(96, 86)
        Me.cmdPlotLines.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPlotLines.Name = "cmdPlotLines"
        Me.cmdPlotLines.Size = New System.Drawing.Size(92, 37)
        Me.cmdPlotLines.TabIndex = 158
        Me.cmdPlotLines.Text = "plot "
        Me.cmdPlotLines.UseVisualStyleBackColor = True
        '
        'cmdSegmentedPredict
        '
        Me.cmdSegmentedPredict.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSegmentedPredict.Location = New System.Drawing.Point(4, 86)
        Me.cmdSegmentedPredict.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSegmentedPredict.Name = "cmdSegmentedPredict"
        Me.cmdSegmentedPredict.Size = New System.Drawing.Size(92, 37)
        Me.cmdSegmentedPredict.TabIndex = 157
        Me.cmdSegmentedPredict.Text = "predict"
        Me.cmdSegmentedPredict.UseVisualStyleBackColor = True
        '
        'cmdVcov
        '
        Me.cmdVcov.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdVcov.Location = New System.Drawing.Point(187, 50)
        Me.cmdVcov.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdVcov.Name = "cmdVcov"
        Me.cmdVcov.Size = New System.Drawing.Size(92, 37)
        Me.cmdVcov.TabIndex = 156
        Me.cmdVcov.Text = "vcov"
        Me.cmdVcov.UseVisualStyleBackColor = True
        '
        'cmdConfint
        '
        Me.cmdConfint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfint.Location = New System.Drawing.Point(96, 50)
        Me.cmdConfint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdConfint.Name = "cmdConfint"
        Me.cmdConfint.Size = New System.Drawing.Size(92, 37)
        Me.cmdConfint.TabIndex = 155
        Me.cmdConfint.Text = "confint"
        Me.cmdConfint.UseVisualStyleBackColor = True
        '
        'cmdSegmentedSummary
        '
        Me.cmdSegmentedSummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSegmentedSummary.Location = New System.Drawing.Point(4, 50)
        Me.cmdSegmentedSummary.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSegmentedSummary.Name = "cmdSegmentedSummary"
        Me.cmdSegmentedSummary.Size = New System.Drawing.Size(92, 37)
        Me.cmdSegmentedSummary.TabIndex = 154
        Me.cmdSegmentedSummary.Text = "summary"
        Me.cmdSegmentedSummary.UseVisualStyleBackColor = True
        '
        'cmdAapc
        '
        Me.cmdAapc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAapc.Location = New System.Drawing.Point(96, 123)
        Me.cmdAapc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdAapc.Name = "cmdAapc"
        Me.cmdAapc.Size = New System.Drawing.Size(92, 37)
        Me.cmdAapc.TabIndex = 126
        Me.cmdAapc.Text = "aapc"
        Me.cmdAapc.UseVisualStyleBackColor = True
        '
        'cmdSegmented
        '
        Me.cmdSegmented.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSegmented.Location = New System.Drawing.Point(96, 12)
        Me.cmdSegmented.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSegmented.Name = "cmdSegmented"
        Me.cmdSegmented.Size = New System.Drawing.Size(92, 37)
        Me.cmdSegmented.TabIndex = 124
        Me.cmdSegmented.Text = "segmented"
        Me.cmdSegmented.UseVisualStyleBackColor = True
        '
        'cmdSegmentedPrint
        '
        Me.cmdSegmentedPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSegmentedPrint.Location = New System.Drawing.Point(277, 50)
        Me.cmdSegmentedPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSegmentedPrint.Name = "cmdSegmentedPrint"
        Me.cmdSegmentedPrint.Size = New System.Drawing.Size(92, 37)
        Me.cmdSegmentedPrint.TabIndex = 153
        Me.cmdSegmentedPrint.Text = "print"
        Me.cmdSegmentedPrint.UseVisualStyleBackColor = True
        '
        'ucrInputModels
        '
        Me.ucrInputModels.AddQuotesIfUnrecognised = True
        Me.ucrInputModels.IsMultiline = False
        Me.ucrInputModels.IsReadOnly = False
        Me.ucrInputModels.Location = New System.Drawing.Point(177, 55)
        Me.ucrInputModels.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputModels.Name = "ucrInputModels"
        Me.ucrInputModels.Size = New System.Drawing.Size(285, 26)
        Me.ucrInputModels.TabIndex = 29
        '
        'ucrSelectorUseModel
        '
        Me.ucrSelectorUseModel.bDropUnusedFilterLevels = False
        Me.ucrSelectorUseModel.bShowHiddenColumns = False
        Me.ucrSelectorUseModel.bUseCurrentFilter = True
        Me.ucrSelectorUseModel.Location = New System.Drawing.Point(13, 84)
        Me.ucrSelectorUseModel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorUseModel.Name = "ucrSelectorUseModel"
        Me.ucrSelectorUseModel.Size = New System.Drawing.Size(280, 222)
        Me.ucrSelectorUseModel.TabIndex = 26
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 446)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 20
        '
        'ucrReceiverForTestColumn
        '
        Me.ucrReceiverForTestColumn.frmParent = Me
        Me.ucrReceiverForTestColumn.Location = New System.Drawing.Point(109, 14)
        Me.ucrReceiverForTestColumn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ucrReceiverForTestColumn.Name = "ucrReceiverForTestColumn"
        Me.ucrReceiverForTestColumn.Selector = Nothing
        Me.ucrReceiverForTestColumn.Size = New System.Drawing.Size(477, 33)
        Me.ucrReceiverForTestColumn.strNcFilePath = ""
        Me.ucrReceiverForTestColumn.TabIndex = 12
        Me.ucrReceiverForTestColumn.ucrSelector = Nothing
        '
        'ucrInputComboRPackage
        '
        Me.ucrInputComboRPackage.AddQuotesIfUnrecognised = True
        Me.ucrInputComboRPackage.IsReadOnly = False
        Me.ucrInputComboRPackage.Location = New System.Drawing.Point(451, 97)
        Me.ucrInputComboRPackage.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.ucrInputComboRPackage.Name = "ucrInputComboRPackage"
        Me.ucrInputComboRPackage.Size = New System.Drawing.Size(163, 26)
        Me.ucrInputComboRPackage.TabIndex = 5
        '
        'ucrTryModelling
        '
        Me.ucrTryModelling.Location = New System.Drawing.Point(3, 351)
        Me.ucrTryModelling.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrTryModelling.Name = "ucrTryModelling"
        Me.ucrTryModelling.Size = New System.Drawing.Size(640, 34)
        Me.ucrTryModelling.TabIndex = 163
        '
        'dlgUseModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 521)
        Me.Controls.Add(Me.grpGeneral)
        Me.Controls.Add(Me.ucrTryModelling)
        Me.Controls.Add(Me.lblRpackage)
        Me.Controls.Add(Me.ucrSaveResult)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.ucrChkIncludeArguments)
        Me.Controls.Add(Me.grpSegmented)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.grpExtrRemes)
        Me.Controls.Add(Me.ucrInputModels)
        Me.Controls.Add(Me.lblModels)
        Me.Controls.Add(Me.grpPrediction)
        Me.Controls.Add(Me.ucrSelectorUseModel)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.ucrReceiverForTestColumn)
        Me.Controls.Add(Me.ucrInputComboRPackage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "dlgUseModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Use Model "
        Me.grpGeneral.ResumeLayout(False)
        Me.grpPrediction.ResumeLayout(False)
        Me.grpExtrRemes.ResumeLayout(False)
        Me.grpSegmented.ResumeLayout(False)
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
    Friend WithEvents cmdHelp As Button
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
End Class
