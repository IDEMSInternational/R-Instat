<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgPLModelOptions
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ucrChkTreatsNAs = New instat.ucrCheck()
        Me.ucrNudShape = New instat.ucrNud()
        Me.ucrNudSigma = New instat.ucrNud()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.ucrNudMean = New instat.ucrNud()
        Me.lblSigma = New System.Windows.Forms.Label()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.ucrNudMaxIterations = New instat.ucrNud()
        Me.ucrInputNA = New instat.ucrInputTextBox()
        Me.ucrInputWeight = New instat.ucrInputTextBox()
        Me.ucrInputMethod = New instat.ucrInputComboBox()
        Me.ucrNudSteffenson = New instat.ucrNud()
        Me.ucrNudOuterIterations = New instat.ucrNud()
        Me.lblOuterIterations = New System.Windows.Forms.Label()
        Me.lblMaximumIterations = New System.Windows.Forms.Label()
        Me.grpPriors = New System.Windows.Forms.GroupBox()
        Me.ucrChkMultivariateNormal = New instat.ucrCheck()
        Me.ucrChkGamma = New instat.ucrCheck()
        Me.lblShape = New System.Windows.Forms.Label()
        Me.lblMean = New System.Windows.Forms.Label()
        Me.ucrNudRate = New instat.ucrNud()
        Me.ucrChkMaxit = New instat.ucrCheck()
        Me.ucrChkMethod = New instat.ucrCheck()
        Me.ucrChkEpsilon = New instat.ucrCheck()
        Me.ucrChkSteffenson = New instat.ucrCheck()
        Me.ucrInputEpsilon = New instat.ucrInputTextBox()
        Me.grpPriors.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrChkTreatsNAs
        '
        Me.ucrChkTreatsNAs.AutoSize = True
        Me.ucrChkTreatsNAs.Checked = False
        Me.ucrChkTreatsNAs.Location = New System.Drawing.Point(16, 220)
        Me.ucrChkTreatsNAs.Name = "ucrChkTreatsNAs"
        Me.ucrChkTreatsNAs.Size = New System.Drawing.Size(93, 23)
        Me.ucrChkTreatsNAs.TabIndex = 334
        '
        'ucrNudShape
        '
        Me.ucrNudShape.AutoSize = True
        Me.ucrNudShape.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShape.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudShape.Location = New System.Drawing.Point(181, 79)
        Me.ucrNudShape.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudShape.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudShape.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShape.Name = "ucrNudShape"
        Me.ucrNudShape.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudShape.TabIndex = 23
        Me.ucrNudShape.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSigma
        '
        Me.ucrNudSigma.AutoSize = True
        Me.ucrNudSigma.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigma.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSigma.Location = New System.Drawing.Point(181, 51)
        Me.ucrNudSigma.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudSigma.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSigma.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigma.Name = "ucrNudSigma"
        Me.ucrNudSigma.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSigma.TabIndex = 24
        Me.ucrNudSigma.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(123, 113)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(33, 13)
        Me.lblRate.TabIndex = 11
        Me.lblRate.Text = "Rate:"
        '
        'ucrNudMean
        '
        Me.ucrNudMean.AutoSize = True
        Me.ucrNudMean.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMean.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMean.Location = New System.Drawing.Point(181, 21)
        Me.ucrNudMean.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudMean.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMean.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMean.Name = "ucrNudMean"
        Me.ucrNudMean.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMean.TabIndex = 21
        Me.ucrNudMean.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblSigma
        '
        Me.lblSigma.AutoSize = True
        Me.lblSigma.Location = New System.Drawing.Point(123, 54)
        Me.lblSigma.Name = "lblSigma"
        Me.lblSigma.Size = New System.Drawing.Size(39, 13)
        Me.lblSigma.TabIndex = 8
        Me.lblSigma.Text = "Sigma:"
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.AutoSize = True
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(16, 192)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(85, 23)
        Me.ucrChkWeights.TabIndex = 336
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.Location = New System.Drawing.Point(22, 380)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(224, 30)
        Me.ucrBase.TabIndex = 342
        '
        'ucrNudMaxIterations
        '
        Me.ucrNudMaxIterations.AutoSize = True
        Me.ucrNudMaxIterations.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxIterations.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxIterations.Location = New System.Drawing.Point(224, 251)
        Me.ucrNudMaxIterations.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudMaxIterations.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxIterations.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxIterations.Name = "ucrNudMaxIterations"
        Me.ucrNudMaxIterations.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxIterations.TabIndex = 341
        Me.ucrNudMaxIterations.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputNA
        '
        Me.ucrInputNA.AddQuotesIfUnrecognised = True
        Me.ucrInputNA.AutoSize = True
        Me.ucrInputNA.IsMultiline = False
        Me.ucrInputNA.IsReadOnly = False
        Me.ucrInputNA.Location = New System.Drawing.Point(136, 219)
        Me.ucrInputNA.Name = "ucrInputNA"
        Me.ucrInputNA.Size = New System.Drawing.Size(105, 21)
        Me.ucrInputNA.TabIndex = 339
        '
        'ucrInputWeight
        '
        Me.ucrInputWeight.AddQuotesIfUnrecognised = True
        Me.ucrInputWeight.AutoSize = True
        Me.ucrInputWeight.IsMultiline = False
        Me.ucrInputWeight.IsReadOnly = False
        Me.ucrInputWeight.Location = New System.Drawing.Point(136, 190)
        Me.ucrInputWeight.Name = "ucrInputWeight"
        Me.ucrInputWeight.Size = New System.Drawing.Size(105, 21)
        Me.ucrInputWeight.TabIndex = 338
        '
        'ucrInputMethod
        '
        Me.ucrInputMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMethod.GetSetSelectedIndex = -1
        Me.ucrInputMethod.IsReadOnly = False
        Me.ucrInputMethod.Location = New System.Drawing.Point(136, 162)
        Me.ucrInputMethod.Name = "ucrInputMethod"
        Me.ucrInputMethod.Size = New System.Drawing.Size(105, 26)
        Me.ucrInputMethod.TabIndex = 337
        '
        'ucrNudSteffenson
        '
        Me.ucrNudSteffenson.AutoSize = True
        Me.ucrNudSteffenson.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSteffenson.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSteffenson.Location = New System.Drawing.Point(225, 350)
        Me.ucrNudSteffenson.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudSteffenson.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSteffenson.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSteffenson.Name = "ucrNudSteffenson"
        Me.ucrNudSteffenson.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSteffenson.TabIndex = 335
        Me.ucrNudSteffenson.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudOuterIterations
        '
        Me.ucrNudOuterIterations.AutoSize = True
        Me.ucrNudOuterIterations.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudOuterIterations.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudOuterIterations.Location = New System.Drawing.Point(224, 286)
        Me.ucrNudOuterIterations.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudOuterIterations.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudOuterIterations.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudOuterIterations.Name = "ucrNudOuterIterations"
        Me.ucrNudOuterIterations.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudOuterIterations.TabIndex = 333
        Me.ucrNudOuterIterations.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblOuterIterations
        '
        Me.lblOuterIterations.AutoSize = True
        Me.lblOuterIterations.Location = New System.Drawing.Point(116, 289)
        Me.lblOuterIterations.Name = "lblOuterIterations"
        Me.lblOuterIterations.Size = New System.Drawing.Size(85, 13)
        Me.lblOuterIterations.TabIndex = 329
        Me.lblOuterIterations.Text = " Outer Iterations:"
        '
        'lblMaximumIterations
        '
        Me.lblMaximumIterations.AutoSize = True
        Me.lblMaximumIterations.Location = New System.Drawing.Point(116, 253)
        Me.lblMaximumIterations.Name = "lblMaximumIterations"
        Me.lblMaximumIterations.Size = New System.Drawing.Size(100, 13)
        Me.lblMaximumIterations.TabIndex = 331
        Me.lblMaximumIterations.Text = "Maximum Iterations:"
        '
        'grpPriors
        '
        Me.grpPriors.Controls.Add(Me.ucrChkMultivariateNormal)
        Me.grpPriors.Controls.Add(Me.ucrChkGamma)
        Me.grpPriors.Controls.Add(Me.lblShape)
        Me.grpPriors.Controls.Add(Me.lblMean)
        Me.grpPriors.Controls.Add(Me.ucrNudRate)
        Me.grpPriors.Controls.Add(Me.ucrNudShape)
        Me.grpPriors.Controls.Add(Me.ucrNudSigma)
        Me.grpPriors.Controls.Add(Me.lblRate)
        Me.grpPriors.Controls.Add(Me.ucrNudMean)
        Me.grpPriors.Controls.Add(Me.lblSigma)
        Me.grpPriors.Location = New System.Drawing.Point(10, 12)
        Me.grpPriors.Name = "grpPriors"
        Me.grpPriors.Size = New System.Drawing.Size(252, 145)
        Me.grpPriors.TabIndex = 328
        Me.grpPriors.TabStop = False
        Me.grpPriors.Text = "Priors"
        '
        'ucrChkMultivariateNormal
        '
        Me.ucrChkMultivariateNormal.AutoSize = True
        Me.ucrChkMultivariateNormal.Checked = False
        Me.ucrChkMultivariateNormal.Location = New System.Drawing.Point(6, 21)
        Me.ucrChkMultivariateNormal.Name = "ucrChkMultivariateNormal"
        Me.ucrChkMultivariateNormal.Size = New System.Drawing.Size(93, 23)
        Me.ucrChkMultivariateNormal.TabIndex = 28
        '
        'ucrChkGamma
        '
        Me.ucrChkGamma.AutoSize = True
        Me.ucrChkGamma.Checked = False
        Me.ucrChkGamma.Location = New System.Drawing.Point(6, 86)
        Me.ucrChkGamma.Name = "ucrChkGamma"
        Me.ucrChkGamma.Size = New System.Drawing.Size(93, 23)
        Me.ucrChkGamma.TabIndex = 25
        '
        'lblShape
        '
        Me.lblShape.AutoSize = True
        Me.lblShape.Location = New System.Drawing.Point(123, 86)
        Me.lblShape.Name = "lblShape"
        Me.lblShape.Size = New System.Drawing.Size(41, 13)
        Me.lblShape.TabIndex = 5
        Me.lblShape.Text = "Shape:"
        '
        'lblMean
        '
        Me.lblMean.AutoSize = True
        Me.lblMean.Location = New System.Drawing.Point(123, 25)
        Me.lblMean.Name = "lblMean"
        Me.lblMean.Size = New System.Drawing.Size(43, 13)
        Me.lblMean.TabIndex = 4
        Me.lblMean.Text = "Mean:"
        '
        'ucrNudRate
        '
        Me.ucrNudRate.AutoSize = True
        Me.ucrNudRate.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRate.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRate.Location = New System.Drawing.Point(181, 107)
        Me.ucrNudRate.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudRate.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRate.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRate.Name = "ucrNudRate"
        Me.ucrNudRate.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudRate.TabIndex = 22
        Me.ucrNudRate.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkMaxit
        '
        Me.ucrChkMaxit.AutoSize = True
        Me.ucrChkMaxit.Checked = False
        Me.ucrChkMaxit.Location = New System.Drawing.Point(16, 261)
        Me.ucrChkMaxit.Name = "ucrChkMaxit"
        Me.ucrChkMaxit.Size = New System.Drawing.Size(93, 23)
        Me.ucrChkMaxit.TabIndex = 344
        '
        'ucrChkMethod
        '
        Me.ucrChkMethod.AutoSize = True
        Me.ucrChkMethod.Checked = False
        Me.ucrChkMethod.Location = New System.Drawing.Point(16, 164)
        Me.ucrChkMethod.Name = "ucrChkMethod"
        Me.ucrChkMethod.Size = New System.Drawing.Size(93, 23)
        Me.ucrChkMethod.TabIndex = 345
        '
        'ucrChkEpsilon
        '
        Me.ucrChkEpsilon.AutoSize = True
        Me.ucrChkEpsilon.Checked = False
        Me.ucrChkEpsilon.Location = New System.Drawing.Point(16, 314)
        Me.ucrChkEpsilon.Name = "ucrChkEpsilon"
        Me.ucrChkEpsilon.Size = New System.Drawing.Size(93, 23)
        Me.ucrChkEpsilon.TabIndex = 346
        '
        'ucrChkSteffenson
        '
        Me.ucrChkSteffenson.AutoSize = True
        Me.ucrChkSteffenson.Checked = False
        Me.ucrChkSteffenson.Location = New System.Drawing.Point(16, 351)
        Me.ucrChkSteffenson.Name = "ucrChkSteffenson"
        Me.ucrChkSteffenson.Size = New System.Drawing.Size(93, 23)
        Me.ucrChkSteffenson.TabIndex = 347
        '
        'ucrInputEpsilon
        '
        Me.ucrInputEpsilon.AddQuotesIfUnrecognised = True
        Me.ucrInputEpsilon.AutoSize = True
        Me.ucrInputEpsilon.IsMultiline = False
        Me.ucrInputEpsilon.IsReadOnly = False
        Me.ucrInputEpsilon.Location = New System.Drawing.Point(136, 314)
        Me.ucrInputEpsilon.Name = "ucrInputEpsilon"
        Me.ucrInputEpsilon.Size = New System.Drawing.Size(105, 21)
        Me.ucrInputEpsilon.TabIndex = 348
        '
        'sdgPLModelOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 422)
        Me.Controls.Add(Me.ucrInputEpsilon)
        Me.Controls.Add(Me.ucrChkSteffenson)
        Me.Controls.Add(Me.ucrChkEpsilon)
        Me.Controls.Add(Me.ucrChkMethod)
        Me.Controls.Add(Me.ucrChkMaxit)
        Me.Controls.Add(Me.ucrChkTreatsNAs)
        Me.Controls.Add(Me.ucrChkWeights)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrNudMaxIterations)
        Me.Controls.Add(Me.ucrInputNA)
        Me.Controls.Add(Me.ucrInputWeight)
        Me.Controls.Add(Me.ucrInputMethod)
        Me.Controls.Add(Me.ucrNudSteffenson)
        Me.Controls.Add(Me.ucrNudOuterIterations)
        Me.Controls.Add(Me.lblOuterIterations)
        Me.Controls.Add(Me.lblMaximumIterations)
        Me.Controls.Add(Me.grpPriors)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPLModelOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PLackett-Luce Model Options"
        Me.grpPriors.ResumeLayout(False)
        Me.grpPriors.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrChkTreatsNAs As ucrCheck
    Friend WithEvents ucrNudShape As ucrNud
    Friend WithEvents ucrNudSigma As ucrNud
    Friend WithEvents lblRate As Label
    Friend WithEvents ucrNudMean As ucrNud
    Friend WithEvents lblSigma As Label
    Friend WithEvents ucrChkWeights As ucrCheck
    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents ucrNudMaxIterations As ucrNud
    Friend WithEvents ucrInputNA As ucrInputTextBox
    Friend WithEvents ucrInputWeight As ucrInputTextBox
    Friend WithEvents ucrInputMethod As ucrInputComboBox
    Friend WithEvents ucrNudSteffenson As ucrNud
    Friend WithEvents ucrNudOuterIterations As ucrNud
    Friend WithEvents lblOuterIterations As Label
    Friend WithEvents lblMaximumIterations As Label
    Friend WithEvents grpPriors As GroupBox
    Friend WithEvents ucrChkMultivariateNormal As ucrCheck
    Friend WithEvents ucrChkGamma As ucrCheck
    Friend WithEvents lblShape As Label
    Friend WithEvents lblMean As Label
    Friend WithEvents ucrNudRate As ucrNud
    Friend WithEvents ucrChkMaxit As ucrCheck
    Friend WithEvents ucrChkMethod As ucrCheck
    Friend WithEvents ucrChkEpsilon As ucrCheck
    Friend WithEvents ucrChkSteffenson As ucrCheck
    Friend WithEvents ucrInputEpsilon As ucrInputTextBox
End Class
