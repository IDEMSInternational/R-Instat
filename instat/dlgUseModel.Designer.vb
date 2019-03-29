<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgUseModel
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
        Me.lblModel = New System.Windows.Forms.Label()
        Me.cmdTry = New System.Windows.Forms.Button()
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
        Me.cmdLrTest = New System.Windows.Forms.Button()
        Me.cmdIsFixedfevd = New System.Windows.Forms.Button()
        Me.cmdFindpars = New System.Windows.Forms.Button()
        Me.cmdDistill = New System.Windows.Forms.Button()
        Me.cmdCi = New System.Windows.Forms.Button()
        Me.cmdErlevd = New System.Windows.Forms.Button()
        Me.ucrInputModels = New instat.ucrInputTextBox()
        Me.ucrSelectorUseModel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputTryMessage = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverForTestColumn = New instat.ucrReceiverExpression()
        Me.ucrInputComboRPackage = New instat.ucrInputComboBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.grpGeneral.SuspendLayout()
        Me.grpPrediction.SuspendLayout()
        Me.grpExtrRemes.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblModel.Location = New System.Drawing.Point(19, 21)
        Me.lblModel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(58, 13)
        Me.lblModel.TabIndex = 11
        Me.lblModel.Tag = "Test"
        Me.lblModel.Text = "Expression"
        '
        'cmdTry
        '
        Me.cmdTry.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTry.Location = New System.Drawing.Point(9, 293)
        Me.cmdTry.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTry.Name = "cmdTry"
        Me.cmdTry.Size = New System.Drawing.Size(74, 23)
        Me.cmdTry.TabIndex = 15
        Me.cmdTry.Text = "Try"
        Me.cmdTry.UseVisualStyleBackColor = True
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
        Me.grpGeneral.Location = New System.Drawing.Point(262, 106)
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
        Me.grpExtrRemes.Controls.Add(Me.cmdLrTest)
        Me.grpExtrRemes.Controls.Add(Me.cmdIsFixedfevd)
        Me.grpExtrRemes.Controls.Add(Me.cmdFindpars)
        Me.grpExtrRemes.Controls.Add(Me.cmdDistill)
        Me.grpExtrRemes.Controls.Add(Me.cmdCi)
        Me.grpExtrRemes.Controls.Add(Me.cmdErlevd)
        Me.grpExtrRemes.Location = New System.Drawing.Point(264, 106)
        Me.grpExtrRemes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpExtrRemes.Name = "grpExtrRemes"
        Me.grpExtrRemes.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpExtrRemes.Size = New System.Drawing.Size(213, 77)
        Me.grpExtrRemes.TabIndex = 30
        Me.grpExtrRemes.TabStop = False
        Me.grpExtrRemes.Text = "extRemes"
        '
        'cmdLrTest
        '
        Me.cmdLrTest.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLrTest.Location = New System.Drawing.Point(140, 41)
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
        Me.cmdIsFixedfevd.Location = New System.Drawing.Point(72, 41)
        Me.cmdIsFixedfevd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdIsFixedfevd.Name = "cmdIsFixedfevd"
        Me.cmdIsFixedfevd.Size = New System.Drawing.Size(69, 30)
        Me.cmdIsFixedfevd.TabIndex = 155
        Me.cmdIsFixedfevd.Text = "is.fixedfevd"
        Me.cmdIsFixedfevd.UseVisualStyleBackColor = True
        '
        'cmdFindpars
        '
        Me.cmdFindpars.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFindpars.Location = New System.Drawing.Point(3, 41)
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
        Me.cmdDistill.Location = New System.Drawing.Point(72, 12)
        Me.cmdDistill.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDistill.Name = "cmdDistill"
        Me.cmdDistill.Size = New System.Drawing.Size(69, 30)
        Me.cmdDistill.TabIndex = 126
        Me.cmdDistill.Text = "distill"
        Me.cmdDistill.UseVisualStyleBackColor = True
        '
        'cmdCi
        '
        Me.cmdCi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCi.Location = New System.Drawing.Point(3, 12)
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
        Me.cmdErlevd.Location = New System.Drawing.Point(140, 12)
        Me.cmdErlevd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdErlevd.Name = "cmdErlevd"
        Me.cmdErlevd.Size = New System.Drawing.Size(69, 30)
        Me.cmdErlevd.TabIndex = 153
        Me.cmdErlevd.Text = "erlevd"
        Me.cmdErlevd.UseVisualStyleBackColor = True
        '
        'ucrInputModels
        '
        Me.ucrInputModels.AddQuotesIfUnrecognised = True
        Me.ucrInputModels.IsMultiline = False
        Me.ucrInputModels.IsReadOnly = False
        Me.ucrInputModels.Location = New System.Drawing.Point(133, 45)
        Me.ucrInputModels.Name = "ucrInputModels"
        Me.ucrInputModels.Size = New System.Drawing.Size(214, 21)
        Me.ucrInputModels.TabIndex = 29
        '
        'ucrSelectorUseModel
        '
        Me.ucrSelectorUseModel.bDropUnusedFilterLevels = False
        Me.ucrSelectorUseModel.bShowHiddenColumns = False
        Me.ucrSelectorUseModel.bUseCurrentFilter = True
        Me.ucrSelectorUseModel.Location = New System.Drawing.Point(10, 68)
        Me.ucrSelectorUseModel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorUseModel.Name = "ucrSelectorUseModel"
        Me.ucrSelectorUseModel.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorUseModel.TabIndex = 26
        '
        'ucrInputTryMessage
        '
        Me.ucrInputTryMessage.AddQuotesIfUnrecognised = True
        Me.ucrInputTryMessage.IsMultiline = False
        Me.ucrInputTryMessage.IsReadOnly = True
        Me.ucrInputTryMessage.Location = New System.Drawing.Point(87, 294)
        Me.ucrInputTryMessage.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrInputTryMessage.Name = "ucrInputTryMessage"
        Me.ucrInputTryMessage.Size = New System.Drawing.Size(321, 22)
        Me.ucrInputTryMessage.TabIndex = 16
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 315)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 20
        '
        'ucrReceiverForTestColumn
        '
        Me.ucrReceiverForTestColumn.frmParent = Me
        Me.ucrReceiverForTestColumn.Location = New System.Drawing.Point(82, 17)
        Me.ucrReceiverForTestColumn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrReceiverForTestColumn.Name = "ucrReceiverForTestColumn"
        Me.ucrReceiverForTestColumn.Selector = Nothing
        Me.ucrReceiverForTestColumn.Size = New System.Drawing.Size(393, 27)
        Me.ucrReceiverForTestColumn.strNcFilePath = ""
        Me.ucrReceiverForTestColumn.TabIndex = 12
        Me.ucrReceiverForTestColumn.ucrSelector = Nothing
        '
        'ucrInputComboRPackage
        '
        Me.ucrInputComboRPackage.AddQuotesIfUnrecognised = True
        Me.ucrInputComboRPackage.IsReadOnly = False
        Me.ucrInputComboRPackage.Location = New System.Drawing.Point(262, 79)
        Me.ucrInputComboRPackage.Name = "ucrInputComboRPackage"
        Me.ucrInputComboRPackage.Size = New System.Drawing.Size(141, 21)
        Me.ucrInputComboRPackage.TabIndex = 5
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
        'dlgUseModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 381)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.grpGeneral)
        Me.Controls.Add(Me.grpExtrRemes)
        Me.Controls.Add(Me.ucrInputModels)
        Me.Controls.Add(Me.lblModels)
        Me.Controls.Add(Me.grpPrediction)
        Me.Controls.Add(Me.ucrSelectorUseModel)
        Me.Controls.Add(Me.ucrInputTryMessage)
        Me.Controls.Add(Me.cmdTry)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.ucrReceiverForTestColumn)
        Me.Controls.Add(Me.ucrInputComboRPackage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimizeBox = False
        Me.Name = "dlgUseModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dlgUseModel"
        Me.grpGeneral.ResumeLayout(False)
        Me.grpPrediction.ResumeLayout(False)
        Me.grpExtrRemes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrInputComboRPackage As ucrInputComboBox
    Friend WithEvents lblModel As Label
    Friend WithEvents ucrReceiverForTestColumn As ucrReceiverExpression
    Friend WithEvents ucrInputTryMessage As ucrInputTextBox
    Friend WithEvents cmdTry As Button
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
End Class
