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
        Me.ucrChkTreatsNAs.Location = New System.Drawing.Point(10, 232)
        Me.ucrChkTreatsNAs.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkTreatsNAs.Name = "ucrChkTreatsNAs"
        Me.ucrChkTreatsNAs.Size = New System.Drawing.Size(93, 34)
        Me.ucrChkTreatsNAs.TabIndex = 5
        '
        'ucrNudShape
        '
        Me.ucrNudShape.AutoSize = True
        Me.ucrNudShape.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShape.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudShape.Location = New System.Drawing.Point(181, 81)
        Me.ucrNudShape.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudShape.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudShape.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShape.Name = "ucrNudShape"
        Me.ucrNudShape.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudShape.TabIndex = 7
        Me.ucrNudShape.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSigma
        '
        Me.ucrNudSigma.AutoSize = True
        Me.ucrNudSigma.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigma.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSigma.Location = New System.Drawing.Point(181, 48)
        Me.ucrNudSigma.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudSigma.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSigma.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigma.Name = "ucrNudSigma"
        Me.ucrNudSigma.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSigma.TabIndex = 4
        Me.ucrNudSigma.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(125, 111)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(33, 13)
        Me.lblRate.TabIndex = 8
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
        Me.ucrNudMean.TabIndex = 2
        Me.ucrNudMean.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblSigma
        '
        Me.lblSigma.AutoSize = True
        Me.lblSigma.Location = New System.Drawing.Point(124, 48)
        Me.lblSigma.Name = "lblSigma"
        Me.lblSigma.Size = New System.Drawing.Size(39, 13)
        Me.lblSigma.TabIndex = 3
        Me.lblSigma.Text = "Sigma:"
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.AutoSize = True
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(10, 196)
        Me.ucrChkWeights.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(105, 34)
        Me.ucrChkWeights.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.Location = New System.Drawing.Point(13, 401)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(335, 42)
        Me.ucrBase.TabIndex = 16
        '
        'ucrNudMaxIterations
        '
        Me.ucrNudMaxIterations.AutoSize = True
        Me.ucrNudMaxIterations.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxIterations.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxIterations.Location = New System.Drawing.Point(209, 270)
        Me.ucrNudMaxIterations.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudMaxIterations.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxIterations.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxIterations.Name = "ucrNudMaxIterations"
        Me.ucrNudMaxIterations.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxIterations.TabIndex = 9
        Me.ucrNudMaxIterations.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputNA
        '
        Me.ucrInputNA.AddQuotesIfUnrecognised = True
        Me.ucrInputNA.AutoSize = True
        Me.ucrInputNA.IsMultiline = False
        Me.ucrInputNA.IsReadOnly = False
        Me.ucrInputNA.Location = New System.Drawing.Point(120, 231)
        Me.ucrInputNA.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputNA.Name = "ucrInputNA"
        Me.ucrInputNA.Size = New System.Drawing.Size(139, 27)
        Me.ucrInputNA.TabIndex = 6
        '
        'ucrInputWeight
        '
        Me.ucrInputWeight.AddQuotesIfUnrecognised = True
        Me.ucrInputWeight.AutoSize = True
        Me.ucrInputWeight.IsMultiline = False
        Me.ucrInputWeight.IsReadOnly = False
        Me.ucrInputWeight.Location = New System.Drawing.Point(119, 197)
        Me.ucrInputWeight.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputWeight.Name = "ucrInputWeight"
        Me.ucrInputWeight.Size = New System.Drawing.Size(140, 29)
        Me.ucrInputWeight.TabIndex = 4
        '
        'ucrInputMethod
        '
        Me.ucrInputMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMethod.GetSetSelectedIndex = -1
        Me.ucrInputMethod.IsReadOnly = False
        Me.ucrInputMethod.Location = New System.Drawing.Point(119, 163)
        Me.ucrInputMethod.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputMethod.Name = "ucrInputMethod"
        Me.ucrInputMethod.Size = New System.Drawing.Size(140, 26)
        Me.ucrInputMethod.TabIndex = 2
        '
        'ucrNudSteffenson
        '
        Me.ucrNudSteffenson.AutoSize = True
        Me.ucrNudSteffenson.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSteffenson.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSteffenson.Location = New System.Drawing.Point(120, 367)
        Me.ucrNudSteffenson.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudSteffenson.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSteffenson.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSteffenson.Name = "ucrNudSteffenson"
        Me.ucrNudSteffenson.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSteffenson.TabIndex = 15
        Me.ucrNudSteffenson.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudOuterIterations
        '
        Me.ucrNudOuterIterations.AutoSize = True
        Me.ucrNudOuterIterations.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudOuterIterations.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudOuterIterations.Location = New System.Drawing.Point(209, 300)
        Me.ucrNudOuterIterations.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudOuterIterations.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudOuterIterations.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudOuterIterations.Name = "ucrNudOuterIterations"
        Me.ucrNudOuterIterations.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudOuterIterations.TabIndex = 11
        Me.ucrNudOuterIterations.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblOuterIterations
        '
        Me.lblOuterIterations.AutoSize = True
        Me.lblOuterIterations.Location = New System.Drawing.Point(108, 303)
        Me.lblOuterIterations.Name = "lblOuterIterations"
        Me.lblOuterIterations.Size = New System.Drawing.Size(85, 13)
        Me.lblOuterIterations.TabIndex = 10
        Me.lblOuterIterations.Text = " Outer Iterations:"
        '
        'lblMaximumIterations
        '
        Me.lblMaximumIterations.AutoSize = True
        Me.lblMaximumIterations.Location = New System.Drawing.Point(109, 272)
        Me.lblMaximumIterations.Name = "lblMaximumIterations"
        Me.lblMaximumIterations.Size = New System.Drawing.Size(100, 13)
        Me.lblMaximumIterations.TabIndex = 8
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
        Me.grpPriors.Size = New System.Drawing.Size(267, 143)
        Me.grpPriors.TabIndex = 0
        Me.grpPriors.TabStop = False
        Me.grpPriors.Text = "Priors"
        '
        'ucrChkMultivariateNormal
        '
        Me.ucrChkMultivariateNormal.AutoSize = True
        Me.ucrChkMultivariateNormal.Checked = False
        Me.ucrChkMultivariateNormal.Location = New System.Drawing.Point(7, 19)
        Me.ucrChkMultivariateNormal.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkMultivariateNormal.Name = "ucrChkMultivariateNormal"
        Me.ucrChkMultivariateNormal.Size = New System.Drawing.Size(93, 34)
        Me.ucrChkMultivariateNormal.TabIndex = 0
        '
        'ucrChkGamma
        '
        Me.ucrChkGamma.AutoSize = True
        Me.ucrChkGamma.Checked = False
        Me.ucrChkGamma.Location = New System.Drawing.Point(7, 79)
        Me.ucrChkGamma.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkGamma.Name = "ucrChkGamma"
        Me.ucrChkGamma.Size = New System.Drawing.Size(93, 34)
        Me.ucrChkGamma.TabIndex = 5
        '
        'lblShape
        '
        Me.lblShape.AutoSize = True
        Me.lblShape.Location = New System.Drawing.Point(124, 84)
        Me.lblShape.Name = "lblShape"
        Me.lblShape.Size = New System.Drawing.Size(41, 13)
        Me.lblShape.TabIndex = 6
        Me.lblShape.Text = "Shape:"
        '
        'lblMean
        '
        Me.lblMean.AutoSize = True
        Me.lblMean.Location = New System.Drawing.Point(123, 23)
        Me.lblMean.Name = "lblMean"
        Me.lblMean.Size = New System.Drawing.Size(37, 13)
        Me.lblMean.TabIndex = 1
        Me.lblMean.Text = "Mean:"
        '
        'ucrNudRate
        '
        Me.ucrNudRate.AutoSize = True
        Me.ucrNudRate.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRate.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRate.Location = New System.Drawing.Point(181, 109)
        Me.ucrNudRate.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudRate.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRate.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRate.Name = "ucrNudRate"
        Me.ucrNudRate.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudRate.TabIndex = 9
        Me.ucrNudRate.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkMaxit
        '
        Me.ucrChkMaxit.AutoSize = True
        Me.ucrChkMaxit.Checked = False
        Me.ucrChkMaxit.Location = New System.Drawing.Point(10, 268)
        Me.ucrChkMaxit.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkMaxit.Name = "ucrChkMaxit"
        Me.ucrChkMaxit.Size = New System.Drawing.Size(93, 34)
        Me.ucrChkMaxit.TabIndex = 7
        '
        'ucrChkMethod
        '
        Me.ucrChkMethod.AutoSize = True
        Me.ucrChkMethod.Checked = False
        Me.ucrChkMethod.Location = New System.Drawing.Point(10, 162)
        Me.ucrChkMethod.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkMethod.Name = "ucrChkMethod"
        Me.ucrChkMethod.Size = New System.Drawing.Size(93, 34)
        Me.ucrChkMethod.TabIndex = 1
        '
        'ucrChkEpsilon
        '
        Me.ucrChkEpsilon.AutoSize = True
        Me.ucrChkEpsilon.Checked = False
        Me.ucrChkEpsilon.Location = New System.Drawing.Point(10, 331)
        Me.ucrChkEpsilon.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkEpsilon.Name = "ucrChkEpsilon"
        Me.ucrChkEpsilon.Size = New System.Drawing.Size(93, 34)
        Me.ucrChkEpsilon.TabIndex = 12
        '
        'ucrChkSteffenson
        '
        Me.ucrChkSteffenson.AutoSize = True
        Me.ucrChkSteffenson.Checked = False
        Me.ucrChkSteffenson.Location = New System.Drawing.Point(10, 367)
        Me.ucrChkSteffenson.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkSteffenson.Name = "ucrChkSteffenson"
        Me.ucrChkSteffenson.Size = New System.Drawing.Size(93, 34)
        Me.ucrChkSteffenson.TabIndex = 14
        '
        'ucrInputEpsilon
        '
        Me.ucrInputEpsilon.AddQuotesIfUnrecognised = True
        Me.ucrInputEpsilon.AutoSize = True
        Me.ucrInputEpsilon.IsMultiline = False
        Me.ucrInputEpsilon.IsReadOnly = False
        Me.ucrInputEpsilon.Location = New System.Drawing.Point(120, 333)
        Me.ucrInputEpsilon.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputEpsilon.Name = "ucrInputEpsilon"
        Me.ucrInputEpsilon.Size = New System.Drawing.Size(139, 28)
        Me.ucrInputEpsilon.TabIndex = 13
        '
        'sdgPLModelOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 448)
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
        Me.Text = "Plackett-Luce Model Options"
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
