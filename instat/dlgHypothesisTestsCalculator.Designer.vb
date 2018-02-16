<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgHypothesisTestsCalculator
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
        Me.lblData = New System.Windows.Forms.Label()
        Me.grpMainKeyboard = New System.Windows.Forms.GroupBox()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.cmdComma = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdConf = New System.Windows.Forms.Button()
        Me.cmdBrackets = New System.Windows.Forms.Button()
        Me.cmdExponential = New System.Windows.Forms.Button()
        Me.cmdSquiggle = New System.Windows.Forms.Button()
        Me.cmdSquareBrackets = New System.Windows.Forms.Button()
        Me.cmdTry = New System.Windows.Forms.Button()
        Me.grpTests = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnWilcox = New System.Windows.Forms.Button()
        Me.btnProp = New System.Windows.Forms.Button()
        Me.btnPoisson = New System.Windows.Forms.Button()
        Me.cmdWilcox = New System.Windows.Forms.Button()
        Me.cmdVar = New System.Windows.Forms.Button()
        Me.cmdShapiro = New System.Windows.Forms.Button()
        Me.cmdPropTrend = New System.Windows.Forms.Button()
        Me.cmdPowerProp = New System.Windows.Forms.Button()
        Me.cmdPowerT = New System.Windows.Forms.Button()
        Me.cmdPaiwiseWilcox = New System.Windows.Forms.Button()
        Me.cmdKruskal = New System.Windows.Forms.Button()
        Me.cmdChisq = New System.Windows.Forms.Button()
        Me.cmdBox = New System.Windows.Forms.Button()
        Me.cmdKs = New System.Windows.Forms.Button()
        Me.cmdFriedman = New System.Windows.Forms.Button()
        Me.cmdOneway = New System.Windows.Forms.Button()
        Me.cmdMood = New System.Windows.Forms.Button()
        Me.cmdPowerAnova = New System.Windows.Forms.Button()
        Me.cmdCor = New System.Windows.Forms.Button()
        Me.cmdMcnemar = New System.Windows.Forms.Button()
        Me.cmdPairwiseProp = New System.Windows.Forms.Button()
        Me.cmdfligner = New System.Windows.Forms.Button()
        Me.cmdBinom = New System.Windows.Forms.Button()
        Me.cmdBartlett = New System.Windows.Forms.Button()
        Me.cmdfisher = New System.Windows.Forms.Button()
        Me.cmdPairwiset = New System.Windows.Forms.Button()
        Me.cmdMauchly = New System.Windows.Forms.Button()
        Me.lblRpackage = New System.Windows.Forms.Label()
        Me.ucrChkSaveTestObject = New instat.ucrCheck()
        Me.ucrSaveResultInto = New instat.ucrInputComboBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputTryMessage = New instat.ucrInputTextBox()
        Me.ucrChkBy = New instat.ucrCheck()
        Me.ucrReceiverMultiple = New instat.ucrReceiverMultiple()
        Me.ucrSelectorColumn = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkShowArguments = New instat.ucrCheck()
        Me.ucrReceiverForTestColumn = New instat.ucrReceiverExpression()
        Me.grpMainKeyboard.SuspendLayout()
        Me.grpTests.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblData.Location = New System.Drawing.Point(19, 29)
        Me.lblData.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(30, 13)
        Me.lblData.TabIndex = 156
        Me.lblData.Tag = "Data"
        Me.lblData.Text = "Data"
        '
        'grpMainKeyboard
        '
        Me.grpMainKeyboard.Controls.Add(Me.cmdPlus)
        Me.grpMainKeyboard.Controls.Add(Me.cmdComma)
        Me.grpMainKeyboard.Controls.Add(Me.cmdDelete)
        Me.grpMainKeyboard.Controls.Add(Me.cmdClear)
        Me.grpMainKeyboard.Controls.Add(Me.cmdConf)
        Me.grpMainKeyboard.Controls.Add(Me.cmdBrackets)
        Me.grpMainKeyboard.Controls.Add(Me.cmdExponential)
        Me.grpMainKeyboard.Controls.Add(Me.cmdSquiggle)
        Me.grpMainKeyboard.Controls.Add(Me.cmdSquareBrackets)
        Me.grpMainKeyboard.Location = New System.Drawing.Point(674, 68)
        Me.grpMainKeyboard.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpMainKeyboard.Name = "grpMainKeyboard"
        Me.grpMainKeyboard.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpMainKeyboard.Size = New System.Drawing.Size(167, 103)
        Me.grpMainKeyboard.TabIndex = 160
        Me.grpMainKeyboard.TabStop = False
        '
        'cmdPlus
        '
        Me.cmdPlus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlus.Location = New System.Drawing.Point(73, 70)
        Me.cmdPlus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(45, 30)
        Me.cmdPlus.TabIndex = 151
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdComma
        '
        Me.cmdComma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdComma.Location = New System.Drawing.Point(117, 12)
        Me.cmdComma.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdComma.Name = "cmdComma"
        Me.cmdComma.Size = New System.Drawing.Size(45, 30)
        Me.cmdComma.TabIndex = 152
        Me.cmdComma.Tag = ""
        Me.cmdComma.Text = ","
        Me.cmdComma.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDelete.Location = New System.Drawing.Point(117, 41)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(45, 30)
        Me.cmdDelete.TabIndex = 149
        Me.cmdDelete.Text = "Del"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClear.Location = New System.Drawing.Point(117, 70)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(45, 30)
        Me.cmdClear.TabIndex = 148
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdConf
        '
        Me.cmdConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdConf.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConf.Location = New System.Drawing.Point(4, 41)
        Me.cmdConf.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdConf.Name = "cmdConf"
        Me.cmdConf.Size = New System.Drawing.Size(70, 30)
        Me.cmdConf.TabIndex = 147
        Me.cmdConf.Tag = "Del"
        Me.cmdConf.Text = "Conf=0.95"
        Me.cmdConf.UseVisualStyleBackColor = True
        '
        'cmdBrackets
        '
        Me.cmdBrackets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrackets.Location = New System.Drawing.Point(73, 12)
        Me.cmdBrackets.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBrackets.Name = "cmdBrackets"
        Me.cmdBrackets.Size = New System.Drawing.Size(45, 30)
        Me.cmdBrackets.TabIndex = 145
        Me.cmdBrackets.Text = "( )"
        Me.cmdBrackets.UseVisualStyleBackColor = True
        '
        'cmdExponential
        '
        Me.cmdExponential.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdExponential.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdExponential.Location = New System.Drawing.Point(4, 70)
        Me.cmdExponential.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdExponential.Name = "cmdExponential"
        Me.cmdExponential.Size = New System.Drawing.Size(70, 30)
        Me.cmdExponential.TabIndex = 143
        Me.cmdExponential.Text = "Alt=""two"""
        Me.cmdExponential.UseVisualStyleBackColor = True
        '
        'cmdSquiggle
        '
        Me.cmdSquiggle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSquiggle.Location = New System.Drawing.Point(73, 41)
        Me.cmdSquiggle.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSquiggle.Name = "cmdSquiggle"
        Me.cmdSquiggle.Size = New System.Drawing.Size(45, 30)
        Me.cmdSquiggle.TabIndex = 149
        Me.cmdSquiggle.Text = "~"
        Me.cmdSquiggle.UseVisualStyleBackColor = True
        '
        'cmdSquareBrackets
        '
        Me.cmdSquareBrackets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSquareBrackets.Location = New System.Drawing.Point(4, 12)
        Me.cmdSquareBrackets.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSquareBrackets.Name = "cmdSquareBrackets"
        Me.cmdSquareBrackets.Size = New System.Drawing.Size(70, 30)
        Me.cmdSquareBrackets.TabIndex = 142
        Me.cmdSquareBrackets.Text = "[ ]"
        Me.cmdSquareBrackets.UseVisualStyleBackColor = True
        '
        'cmdTry
        '
        Me.cmdTry.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTry.Location = New System.Drawing.Point(13, 353)
        Me.cmdTry.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTry.Name = "cmdTry"
        Me.cmdTry.Size = New System.Drawing.Size(74, 23)
        Me.cmdTry.TabIndex = 163
        Me.cmdTry.Text = "Try"
        Me.cmdTry.UseVisualStyleBackColor = True
        '
        'grpTests
        '
        Me.grpTests.Controls.Add(Me.btnClear)
        Me.grpTests.Controls.Add(Me.btnT)
        Me.grpTests.Controls.Add(Me.btnWilcox)
        Me.grpTests.Controls.Add(Me.btnProp)
        Me.grpTests.Controls.Add(Me.btnPoisson)
        Me.grpTests.Controls.Add(Me.cmdWilcox)
        Me.grpTests.Controls.Add(Me.cmdVar)
        Me.grpTests.Controls.Add(Me.cmdShapiro)
        Me.grpTests.Controls.Add(Me.cmdPropTrend)
        Me.grpTests.Controls.Add(Me.cmdPowerProp)
        Me.grpTests.Controls.Add(Me.cmdPowerT)
        Me.grpTests.Controls.Add(Me.cmdPaiwiseWilcox)
        Me.grpTests.Controls.Add(Me.cmdKruskal)
        Me.grpTests.Controls.Add(Me.cmdChisq)
        Me.grpTests.Controls.Add(Me.cmdBox)
        Me.grpTests.Controls.Add(Me.cmdKs)
        Me.grpTests.Controls.Add(Me.cmdFriedman)
        Me.grpTests.Controls.Add(Me.cmdOneway)
        Me.grpTests.Controls.Add(Me.cmdMood)
        Me.grpTests.Controls.Add(Me.cmdPowerAnova)
        Me.grpTests.Controls.Add(Me.cmdCor)
        Me.grpTests.Controls.Add(Me.cmdMcnemar)
        Me.grpTests.Controls.Add(Me.cmdPairwiseProp)
        Me.grpTests.Controls.Add(Me.cmdfligner)
        Me.grpTests.Controls.Add(Me.cmdBinom)
        Me.grpTests.Controls.Add(Me.cmdBartlett)
        Me.grpTests.Controls.Add(Me.cmdfisher)
        Me.grpTests.Controls.Add(Me.cmdPairwiset)
        Me.grpTests.Controls.Add(Me.cmdMauchly)
        Me.grpTests.Location = New System.Drawing.Point(247, 68)
        Me.grpTests.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpTests.Name = "grpTests"
        Me.grpTests.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpTests.Size = New System.Drawing.Size(423, 168)
        Me.grpTests.TabIndex = 167
        Me.grpTests.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClear.Location = New System.Drawing.Point(348, 130)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(69, 30)
        Me.btnClear.TabIndex = 168
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnT
        '
        Me.btnT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnT.Location = New System.Drawing.Point(73, 130)
        Me.btnT.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(69, 30)
        Me.btnT.TabIndex = 167
        Me.btnT.Text = "t"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnWilcox
        '
        Me.btnWilcox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnWilcox.Location = New System.Drawing.Point(211, 130)
        Me.btnWilcox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnWilcox.Name = "btnWilcox"
        Me.btnWilcox.Size = New System.Drawing.Size(69, 30)
        Me.btnWilcox.TabIndex = 166
        Me.btnWilcox.Text = "wilcox"
        Me.btnWilcox.UseVisualStyleBackColor = True
        '
        'btnProp
        '
        Me.btnProp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProp.Location = New System.Drawing.Point(280, 130)
        Me.btnProp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnProp.Name = "btnProp"
        Me.btnProp.Size = New System.Drawing.Size(69, 30)
        Me.btnProp.TabIndex = 165
        Me.btnProp.Text = "prop"
        Me.btnProp.UseVisualStyleBackColor = True
        '
        'btnPoisson
        '
        Me.btnPoisson.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPoisson.Location = New System.Drawing.Point(348, 101)
        Me.btnPoisson.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnPoisson.Name = "btnPoisson"
        Me.btnPoisson.Size = New System.Drawing.Size(69, 30)
        Me.btnPoisson.TabIndex = 164
        Me.btnPoisson.Text = "poisson"
        Me.btnPoisson.UseVisualStyleBackColor = True
        '
        'cmdWilcox
        '
        Me.cmdWilcox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdWilcox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdWilcox.Location = New System.Drawing.Point(348, 43)
        Me.cmdWilcox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdWilcox.Name = "cmdWilcox"
        Me.cmdWilcox.Size = New System.Drawing.Size(69, 30)
        Me.cmdWilcox.TabIndex = 163
        Me.cmdWilcox.Tag = "Del"
        Me.cmdWilcox.Text = "wilcox"
        Me.cmdWilcox.UseVisualStyleBackColor = True
        '
        'cmdVar
        '
        Me.cmdVar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdVar.Location = New System.Drawing.Point(142, 130)
        Me.cmdVar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdVar.Name = "cmdVar"
        Me.cmdVar.Size = New System.Drawing.Size(69, 30)
        Me.cmdVar.TabIndex = 162
        Me.cmdVar.Text = "var"
        Me.cmdVar.UseVisualStyleBackColor = True
        '
        'cmdShapiro
        '
        Me.cmdShapiro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdShapiro.Location = New System.Drawing.Point(4, 130)
        Me.cmdShapiro.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdShapiro.Name = "cmdShapiro"
        Me.cmdShapiro.Size = New System.Drawing.Size(69, 30)
        Me.cmdShapiro.TabIndex = 161
        Me.cmdShapiro.Text = "shapiro"
        Me.cmdShapiro.UseVisualStyleBackColor = True
        '
        'cmdPropTrend
        '
        Me.cmdPropTrend.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPropTrend.Location = New System.Drawing.Point(280, 101)
        Me.cmdPropTrend.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPropTrend.Name = "cmdPropTrend"
        Me.cmdPropTrend.Size = New System.Drawing.Size(69, 30)
        Me.cmdPropTrend.TabIndex = 160
        Me.cmdPropTrend.Text = "prop.trend"
        Me.cmdPropTrend.UseVisualStyleBackColor = True
        '
        'cmdPowerProp
        '
        Me.cmdPowerProp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPowerProp.Location = New System.Drawing.Point(80, 72)
        Me.cmdPowerProp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPowerProp.Name = "cmdPowerProp"
        Me.cmdPowerProp.Size = New System.Drawing.Size(83, 30)
        Me.cmdPowerProp.TabIndex = 159
        Me.cmdPowerProp.Text = "power.prop"
        Me.cmdPowerProp.UseVisualStyleBackColor = True
        '
        'cmdPowerT
        '
        Me.cmdPowerT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPowerT.Location = New System.Drawing.Point(211, 101)
        Me.cmdPowerT.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPowerT.Name = "cmdPowerT"
        Me.cmdPowerT.Size = New System.Drawing.Size(69, 30)
        Me.cmdPowerT.TabIndex = 157
        Me.cmdPowerT.Text = "power.t"
        Me.cmdPowerT.UseVisualStyleBackColor = True
        '
        'cmdPaiwiseWilcox
        '
        Me.cmdPaiwiseWilcox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPaiwiseWilcox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPaiwiseWilcox.Location = New System.Drawing.Point(324, 72)
        Me.cmdPaiwiseWilcox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPaiwiseWilcox.Name = "cmdPaiwiseWilcox"
        Me.cmdPaiwiseWilcox.Size = New System.Drawing.Size(93, 30)
        Me.cmdPaiwiseWilcox.TabIndex = 156
        Me.cmdPaiwiseWilcox.Tag = "Del"
        Me.cmdPaiwiseWilcox.Text = "pairwise.wilcox"
        Me.cmdPaiwiseWilcox.UseVisualStyleBackColor = True
        '
        'cmdKruskal
        '
        Me.cmdKruskal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdKruskal.Location = New System.Drawing.Point(211, 43)
        Me.cmdKruskal.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdKruskal.Name = "cmdKruskal"
        Me.cmdKruskal.Size = New System.Drawing.Size(69, 30)
        Me.cmdKruskal.TabIndex = 155
        Me.cmdKruskal.Text = " kruskal"
        Me.cmdKruskal.UseVisualStyleBackColor = True
        '
        'cmdChisq
        '
        Me.cmdChisq.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdChisq.Location = New System.Drawing.Point(211, 14)
        Me.cmdChisq.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdChisq.Name = "cmdChisq"
        Me.cmdChisq.Size = New System.Drawing.Size(69, 30)
        Me.cmdChisq.TabIndex = 154
        Me.cmdChisq.Text = "chisq"
        Me.cmdChisq.UseVisualStyleBackColor = True
        '
        'cmdBox
        '
        Me.cmdBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBox.Location = New System.Drawing.Point(142, 14)
        Me.cmdBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBox.Name = "cmdBox"
        Me.cmdBox.Size = New System.Drawing.Size(69, 30)
        Me.cmdBox.TabIndex = 153
        Me.cmdBox.Text = " Box"
        Me.cmdBox.UseVisualStyleBackColor = True
        '
        'cmdKs
        '
        Me.cmdKs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdKs.Location = New System.Drawing.Point(142, 43)
        Me.cmdKs.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdKs.Name = "cmdKs"
        Me.cmdKs.Size = New System.Drawing.Size(69, 30)
        Me.cmdKs.TabIndex = 151
        Me.cmdKs.Text = "ks"
        Me.cmdKs.UseVisualStyleBackColor = True
        '
        'cmdFriedman
        '
        Me.cmdFriedman.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFriedman.Location = New System.Drawing.Point(73, 43)
        Me.cmdFriedman.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdFriedman.Name = "cmdFriedman"
        Me.cmdFriedman.Size = New System.Drawing.Size(69, 30)
        Me.cmdFriedman.TabIndex = 150
        Me.cmdFriedman.Text = "friedman"
        Me.cmdFriedman.UseVisualStyleBackColor = True
        '
        'cmdOneway
        '
        Me.cmdOneway.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOneway.Location = New System.Drawing.Point(142, 101)
        Me.cmdOneway.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdOneway.Name = "cmdOneway"
        Me.cmdOneway.Size = New System.Drawing.Size(69, 30)
        Me.cmdOneway.TabIndex = 148
        Me.cmdOneway.Text = "oneway"
        Me.cmdOneway.UseVisualStyleBackColor = True
        '
        'cmdMood
        '
        Me.cmdMood.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMood.Location = New System.Drawing.Point(73, 101)
        Me.cmdMood.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMood.Name = "cmdMood"
        Me.cmdMood.Size = New System.Drawing.Size(69, 30)
        Me.cmdMood.TabIndex = 147
        Me.cmdMood.Text = "mood"
        Me.cmdMood.UseVisualStyleBackColor = True
        '
        'cmdPowerAnova
        '
        Me.cmdPowerAnova.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPowerAnova.Location = New System.Drawing.Point(4, 72)
        Me.cmdPowerAnova.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPowerAnova.Name = "cmdPowerAnova"
        Me.cmdPowerAnova.Size = New System.Drawing.Size(77, 30)
        Me.cmdPowerAnova.TabIndex = 146
        Me.cmdPowerAnova.Text = "power.anova"
        Me.cmdPowerAnova.UseVisualStyleBackColor = True
        '
        'cmdCor
        '
        Me.cmdCor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCor.Location = New System.Drawing.Point(280, 14)
        Me.cmdCor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCor.Name = "cmdCor"
        Me.cmdCor.Size = New System.Drawing.Size(69, 30)
        Me.cmdCor.TabIndex = 158
        Me.cmdCor.Text = "cor"
        Me.cmdCor.UseVisualStyleBackColor = True
        '
        'cmdMcnemar
        '
        Me.cmdMcnemar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMcnemar.Location = New System.Drawing.Point(4, 101)
        Me.cmdMcnemar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMcnemar.Name = "cmdMcnemar"
        Me.cmdMcnemar.Size = New System.Drawing.Size(69, 30)
        Me.cmdMcnemar.TabIndex = 145
        Me.cmdMcnemar.Text = "mcnemar"
        Me.cmdMcnemar.UseVisualStyleBackColor = True
        '
        'cmdPairwiseProp
        '
        Me.cmdPairwiseProp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPairwiseProp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPairwiseProp.Location = New System.Drawing.Point(162, 72)
        Me.cmdPairwiseProp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPairwiseProp.Name = "cmdPairwiseProp"
        Me.cmdPairwiseProp.Size = New System.Drawing.Size(83, 30)
        Me.cmdPairwiseProp.TabIndex = 132
        Me.cmdPairwiseProp.Tag = "Del"
        Me.cmdPairwiseProp.Text = "pairwise.Prop"
        Me.cmdPairwiseProp.UseVisualStyleBackColor = True
        '
        'cmdfligner
        '
        Me.cmdfligner.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdfligner.Location = New System.Drawing.Point(4, 43)
        Me.cmdfligner.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdfligner.Name = "cmdfligner"
        Me.cmdfligner.Size = New System.Drawing.Size(69, 30)
        Me.cmdfligner.TabIndex = 129
        Me.cmdfligner.Text = "fligner"
        Me.cmdfligner.UseVisualStyleBackColor = True
        '
        'cmdBinom
        '
        Me.cmdBinom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBinom.Location = New System.Drawing.Point(73, 14)
        Me.cmdBinom.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBinom.Name = "cmdBinom"
        Me.cmdBinom.Size = New System.Drawing.Size(69, 30)
        Me.cmdBinom.TabIndex = 126
        Me.cmdBinom.Text = " binom"
        Me.cmdBinom.UseVisualStyleBackColor = True
        '
        'cmdBartlett
        '
        Me.cmdBartlett.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBartlett.Location = New System.Drawing.Point(4, 14)
        Me.cmdBartlett.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBartlett.Name = "cmdBartlett"
        Me.cmdBartlett.Size = New System.Drawing.Size(69, 30)
        Me.cmdBartlett.TabIndex = 124
        Me.cmdBartlett.Text = "bartlett"
        Me.cmdBartlett.UseVisualStyleBackColor = True
        '
        'cmdfisher
        '
        Me.cmdfisher.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdfisher.Location = New System.Drawing.Point(348, 14)
        Me.cmdfisher.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdfisher.Name = "cmdfisher"
        Me.cmdfisher.Size = New System.Drawing.Size(69, 30)
        Me.cmdfisher.TabIndex = 121
        Me.cmdfisher.Text = " fisher"
        Me.cmdfisher.UseVisualStyleBackColor = True
        '
        'cmdPairwiset
        '
        Me.cmdPairwiset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPairwiset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPairwiset.Location = New System.Drawing.Point(244, 72)
        Me.cmdPairwiset.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPairwiset.Name = "cmdPairwiset"
        Me.cmdPairwiset.Size = New System.Drawing.Size(81, 30)
        Me.cmdPairwiset.TabIndex = 144
        Me.cmdPairwiset.Text = "pairwise.t"
        Me.cmdPairwiset.UseVisualStyleBackColor = True
        '
        'cmdMauchly
        '
        Me.cmdMauchly.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMauchly.Location = New System.Drawing.Point(280, 43)
        Me.cmdMauchly.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMauchly.Name = "cmdMauchly"
        Me.cmdMauchly.Size = New System.Drawing.Size(69, 30)
        Me.cmdMauchly.TabIndex = 117
        Me.cmdMauchly.Text = "mauchly"
        Me.cmdMauchly.UseVisualStyleBackColor = True
        '
        'lblRpackage
        '
        Me.lblRpackage.AutoSize = True
        Me.lblRpackage.Location = New System.Drawing.Point(250, 57)
        Me.lblRpackage.Name = "lblRpackage"
        Me.lblRpackage.Size = New System.Drawing.Size(63, 13)
        Me.lblRpackage.TabIndex = 168
        Me.lblRpackage.Text = "R package:"
        '
        'ucrChkSaveTestObject
        '
        Me.ucrChkSaveTestObject.Checked = False
        Me.ucrChkSaveTestObject.Location = New System.Drawing.Point(19, 400)
        Me.ucrChkSaveTestObject.Name = "ucrChkSaveTestObject"
        Me.ucrChkSaveTestObject.Size = New System.Drawing.Size(135, 20)
        Me.ucrChkSaveTestObject.TabIndex = 180
        '
        'ucrSaveResultInto
        '
        Me.ucrSaveResultInto.AddQuotesIfUnrecognised = True
        Me.ucrSaveResultInto.IsReadOnly = False
        Me.ucrSaveResultInto.Location = New System.Drawing.Point(157, 398)
        Me.ucrSaveResultInto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrSaveResultInto.Name = "ucrSaveResultInto"
        Me.ucrSaveResultInto.Size = New System.Drawing.Size(253, 22)
        Me.ucrSaveResultInto.TabIndex = 179
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 426)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(452, 52)
        Me.ucrBase.TabIndex = 165
        '
        'ucrInputTryMessage
        '
        Me.ucrInputTryMessage.AddQuotesIfUnrecognised = True
        Me.ucrInputTryMessage.IsMultiline = False
        Me.ucrInputTryMessage.IsReadOnly = True
        Me.ucrInputTryMessage.Location = New System.Drawing.Point(89, 354)
        Me.ucrInputTryMessage.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrInputTryMessage.Name = "ucrInputTryMessage"
        Me.ucrInputTryMessage.Size = New System.Drawing.Size(321, 22)
        Me.ucrInputTryMessage.TabIndex = 164
        '
        'ucrChkBy
        '
        Me.ucrChkBy.Checked = False
        Me.ucrChkBy.Location = New System.Drawing.Point(218, 251)
        Me.ucrChkBy.Name = "ucrChkBy"
        Me.ucrChkBy.Size = New System.Drawing.Size(69, 20)
        Me.ucrChkBy.TabIndex = 162
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.frmParent = Me
        Me.ucrReceiverMultiple.Location = New System.Drawing.Point(290, 251)
        Me.ucrReceiverMultiple.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Selector = Nothing
        Me.ucrReceiverMultiple.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultiple.strNcFilePath = ""
        Me.ucrReceiverMultiple.TabIndex = 161
        Me.ucrReceiverMultiple.ucrSelector = Nothing
        '
        'ucrSelectorColumn
        '
        Me.ucrSelectorColumn.bShowHiddenColumns = False
        Me.ucrSelectorColumn.bUseCurrentFilter = True
        Me.ucrSelectorColumn.Location = New System.Drawing.Point(19, 56)
        Me.ucrSelectorColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorColumn.Name = "ucrSelectorColumn"
        Me.ucrSelectorColumn.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorColumn.TabIndex = 159
        '
        'ucrChkShowArguments
        '
        Me.ucrChkShowArguments.Checked = False
        Me.ucrChkShowArguments.Location = New System.Drawing.Point(576, 25)
        Me.ucrChkShowArguments.Name = "ucrChkShowArguments"
        Me.ucrChkShowArguments.Size = New System.Drawing.Size(274, 20)
        Me.ucrChkShowArguments.TabIndex = 158
        '
        'ucrReceiverForTestColumn
        '
        Me.ucrReceiverForTestColumn.frmParent = Me
        Me.ucrReceiverForTestColumn.Location = New System.Drawing.Point(50, 25)
        Me.ucrReceiverForTestColumn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrReceiverForTestColumn.Name = "ucrReceiverForTestColumn"
        Me.ucrReceiverForTestColumn.Selector = Nothing
        Me.ucrReceiverForTestColumn.Size = New System.Drawing.Size(510, 28)
        Me.ucrReceiverForTestColumn.strNcFilePath = ""
        Me.ucrReceiverForTestColumn.TabIndex = 157
        Me.ucrReceiverForTestColumn.ucrSelector = Nothing
        '
        'dlgHypothesisTestsCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 487)
        Me.Controls.Add(Me.ucrChkSaveTestObject)
        Me.Controls.Add(Me.ucrSaveResultInto)
        Me.Controls.Add(Me.lblRpackage)
        Me.Controls.Add(Me.grpTests)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrInputTryMessage)
        Me.Controls.Add(Me.cmdTry)
        Me.Controls.Add(Me.ucrChkBy)
        Me.Controls.Add(Me.ucrReceiverMultiple)
        Me.Controls.Add(Me.grpMainKeyboard)
        Me.Controls.Add(Me.ucrSelectorColumn)
        Me.Controls.Add(Me.ucrChkShowArguments)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.ucrReceiverForTestColumn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgHypothesisTestsCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hypothesis Tests"
        Me.grpMainKeyboard.ResumeLayout(False)
        Me.grpTests.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblData As Label
    Friend WithEvents ucrReceiverForTestColumn As ucrReceiverExpression
    Friend WithEvents ucrChkShowArguments As ucrCheck
    Friend WithEvents ucrSelectorColumn As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpMainKeyboard As GroupBox
    Friend WithEvents cmdPlus As Button
    Friend WithEvents cmdComma As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdSquiggle As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdConf As Button
    Friend WithEvents cmdBrackets As Button
    Friend WithEvents cmdExponential As Button
    Friend WithEvents cmdSquareBrackets As Button
    Friend WithEvents ucrChkBy As ucrCheck
    Friend WithEvents ucrReceiverMultiple As ucrReceiverMultiple
    Friend WithEvents ucrInputTryMessage As ucrInputTextBox
    Friend WithEvents cmdTry As Button
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpTests As GroupBox
    Friend WithEvents cmdPowerT As Button
    Friend WithEvents cmdPaiwiseWilcox As Button
    Friend WithEvents cmdKruskal As Button
    Friend WithEvents cmdChisq As Button
    Friend WithEvents cmdBox As Button
    Friend WithEvents cmdKs As Button
    Friend WithEvents cmdFriedman As Button
    Friend WithEvents cmdOneway As Button
    Friend WithEvents cmdMood As Button
    Friend WithEvents cmdPowerAnova As Button
    Friend WithEvents cmdCor As Button
    Friend WithEvents cmdMcnemar As Button
    Friend WithEvents cmdPairwiseProp As Button
    Friend WithEvents cmdfligner As Button
    Friend WithEvents cmdBinom As Button
    Friend WithEvents cmdBartlett As Button
    Friend WithEvents cmdfisher As Button
    Friend WithEvents cmdPairwiset As Button
    Friend WithEvents cmdMauchly As Button
    Friend WithEvents cmdPowerProp As Button
    Friend WithEvents cmdVar As Button
    Friend WithEvents cmdShapiro As Button
    Friend WithEvents cmdPropTrend As Button
    Friend WithEvents cmdWilcox As Button
    Friend WithEvents lblRpackage As Label
    Friend WithEvents ucrSaveResultInto As ucrInputComboBox
    Friend WithEvents btnProp As Button
    Friend WithEvents btnPoisson As Button
    Friend WithEvents btnT As Button
    Friend WithEvents btnWilcox As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents ucrChkSaveTestObject As ucrCheck
End Class
