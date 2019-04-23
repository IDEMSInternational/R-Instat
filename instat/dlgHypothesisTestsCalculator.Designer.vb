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
        Me.components = New System.ComponentModel.Container()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.grpMainKeyboard = New System.Windows.Forms.GroupBox()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.cmdComma = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdConf = New System.Windows.Forms.Button()
        Me.cmdBrackets = New System.Windows.Forms.Button()
        Me.cmdAlt = New System.Windows.Forms.Button()
        Me.cmdSquiggle = New System.Windows.Forms.Button()
        Me.cmdSquareBrackets = New System.Windows.Forms.Button()
        Me.cmdTry = New System.Windows.Forms.Button()
        Me.grpStats1 = New System.Windows.Forms.GroupBox()
        Me.cmdT = New System.Windows.Forms.Button()
        Me.cmdProp = New System.Windows.Forms.Button()
        Me.cmdPoisson = New System.Windows.Forms.Button()
        Me.cmdVar = New System.Windows.Forms.Button()
        Me.cmdShapiro = New System.Windows.Forms.Button()
        Me.cmdWilcox = New System.Windows.Forms.Button()
        Me.cmdKruskal = New System.Windows.Forms.Button()
        Me.cmdChisq = New System.Windows.Forms.Button()
        Me.cmdbox = New System.Windows.Forms.Button()
        Me.cmdKs = New System.Windows.Forms.Button()
        Me.cmdFriedman = New System.Windows.Forms.Button()
        Me.cmdOneway = New System.Windows.Forms.Button()
        Me.cmdCor = New System.Windows.Forms.Button()
        Me.cmdBinom = New System.Windows.Forms.Button()
        Me.cmdBartlett = New System.Windows.Forms.Button()
        Me.cmdfisher = New System.Windows.Forms.Button()
        Me.cmdClearStats2 = New System.Windows.Forms.Button()
        Me.cmdPropTrend = New System.Windows.Forms.Button()
        Me.cmdPowerProp = New System.Windows.Forms.Button()
        Me.cmdPowerT = New System.Windows.Forms.Button()
        Me.cmdPaiwiseWilcox = New System.Windows.Forms.Button()
        Me.cmdMood = New System.Windows.Forms.Button()
        Me.cmdPowerAnova = New System.Windows.Forms.Button()
        Me.cmdMcnemar = New System.Windows.Forms.Button()
        Me.cmdPairwiseProp = New System.Windows.Forms.Button()
        Me.cmdfligner = New System.Windows.Forms.Button()
        Me.cmdPairwiset = New System.Windows.Forms.Button()
        Me.cmdMauchly = New System.Windows.Forms.Button()
        Me.lblRpackage = New System.Windows.Forms.Label()
        Me.tpConf = New System.Windows.Forms.ToolTip(Me.components)
        Me.tpAlt = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdAnsari = New System.Windows.Forms.Button()
        Me.cmdMantelhaen = New System.Windows.Forms.Button()
        Me.cmdQuade = New System.Windows.Forms.Button()
        Me.cmdPP = New System.Windows.Forms.Button()
        Me.grpStats2 = New System.Windows.Forms.GroupBox()
        Me.grpAgricolae = New System.Windows.Forms.GroupBox()
        Me.cmdPBIB = New System.Windows.Forms.Button()
        Me.cmdAgriKruskal = New System.Windows.Forms.Button()
        Me.cmdScheffe = New System.Windows.Forms.Button()
        Me.cmdDurbin = New System.Windows.Forms.Button()
        Me.cmdAgriFriedman = New System.Windows.Forms.Button()
        Me.cmdSNK = New System.Windows.Forms.Button()
        Me.cmdWaerden = New System.Windows.Forms.Button()
        Me.cmdAgriWaller = New System.Windows.Forms.Button()
        Me.cmdAgriNonAdditivity = New System.Windows.Forms.Button()
        Me.cmdMedian = New System.Windows.Forms.Button()
        Me.cmdREGW = New System.Windows.Forms.Button()
        Me.cmdLSD = New System.Windows.Forms.Button()
        Me.cmdDuncan = New System.Windows.Forms.Button()
        Me.cmdBIB = New System.Windows.Forms.Button()
        Me.ucrReceiverMultiple = New instat.ucrReceiverMultiple()
        Me.ucrSaveResult = New instat.ucrSave()
        Me.ucrInputComboRPackage = New instat.ucrInputComboBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputTryMessage = New instat.ucrInputTextBox()
        Me.ucrChkBy = New instat.ucrCheck()
        Me.ucrSelectorColumn = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkIncludeArguments = New instat.ucrCheck()
        Me.ucrReceiverForTestColumn = New instat.ucrReceiverExpression()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.grpMainKeyboard.SuspendLayout()
        Me.grpStats1.SuspendLayout()
        Me.grpStats2.SuspendLayout()
        Me.grpAgricolae.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTest.Location = New System.Drawing.Point(19, 29)
        Me.lblTest.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(28, 13)
        Me.lblTest.TabIndex = 0
        Me.lblTest.Tag = "Test"
        Me.lblTest.Text = "Test"
        '
        'grpMainKeyboard
        '
        Me.grpMainKeyboard.Controls.Add(Me.cmdPlus)
        Me.grpMainKeyboard.Controls.Add(Me.cmdComma)
        Me.grpMainKeyboard.Controls.Add(Me.cmdDelete)
        Me.grpMainKeyboard.Controls.Add(Me.cmdClear)
        Me.grpMainKeyboard.Controls.Add(Me.cmdConf)
        Me.grpMainKeyboard.Controls.Add(Me.cmdBrackets)
        Me.grpMainKeyboard.Controls.Add(Me.cmdAlt)
        Me.grpMainKeyboard.Controls.Add(Me.cmdSquiggle)
        Me.grpMainKeyboard.Controls.Add(Me.cmdSquareBrackets)
        Me.grpMainKeyboard.Location = New System.Drawing.Point(386, 247)
        Me.grpMainKeyboard.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpMainKeyboard.Name = "grpMainKeyboard"
        Me.grpMainKeyboard.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpMainKeyboard.Size = New System.Drawing.Size(167, 103)
        Me.grpMainKeyboard.TabIndex = 9
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
        'cmdAlt
        '
        Me.cmdAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdAlt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAlt.Location = New System.Drawing.Point(4, 70)
        Me.cmdAlt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAlt.Name = "cmdAlt"
        Me.cmdAlt.Size = New System.Drawing.Size(70, 30)
        Me.cmdAlt.TabIndex = 143
        Me.cmdAlt.Text = "Alt=""two"""
        Me.cmdAlt.UseVisualStyleBackColor = True
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
        Me.cmdTry.TabIndex = 10
        Me.cmdTry.Text = "Try"
        Me.cmdTry.UseVisualStyleBackColor = True
        '
        'grpStats1
        '
        Me.grpStats1.Controls.Add(Me.cmdT)
        Me.grpStats1.Controls.Add(Me.cmdProp)
        Me.grpStats1.Controls.Add(Me.cmdPoisson)
        Me.grpStats1.Controls.Add(Me.cmdVar)
        Me.grpStats1.Controls.Add(Me.cmdShapiro)
        Me.grpStats1.Controls.Add(Me.cmdWilcox)
        Me.grpStats1.Controls.Add(Me.cmdKruskal)
        Me.grpStats1.Controls.Add(Me.cmdChisq)
        Me.grpStats1.Controls.Add(Me.cmdbox)
        Me.grpStats1.Controls.Add(Me.cmdKs)
        Me.grpStats1.Controls.Add(Me.cmdFriedman)
        Me.grpStats1.Controls.Add(Me.cmdOneway)
        Me.grpStats1.Controls.Add(Me.cmdCor)
        Me.grpStats1.Controls.Add(Me.cmdBinom)
        Me.grpStats1.Controls.Add(Me.cmdBartlett)
        Me.grpStats1.Controls.Add(Me.cmdfisher)
        Me.grpStats1.Location = New System.Drawing.Point(266, 76)
        Me.grpStats1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpStats1.Name = "grpStats1"
        Me.grpStats1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpStats1.Size = New System.Drawing.Size(287, 141)
        Me.grpStats1.TabIndex = 6
        Me.grpStats1.TabStop = False
        Me.grpStats1.Text = "Stats1"
        '
        'cmdT
        '
        Me.cmdT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdT.Location = New System.Drawing.Point(73, 104)
        Me.cmdT.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdT.Name = "cmdT"
        Me.cmdT.Size = New System.Drawing.Size(69, 30)
        Me.cmdT.TabIndex = 167
        Me.cmdT.Text = "t"
        Me.cmdT.UseVisualStyleBackColor = True
        '
        'cmdProp
        '
        Me.cmdProp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdProp.Location = New System.Drawing.Point(211, 74)
        Me.cmdProp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdProp.Name = "cmdProp"
        Me.cmdProp.Size = New System.Drawing.Size(69, 30)
        Me.cmdProp.TabIndex = 165
        Me.cmdProp.Text = "prop"
        Me.cmdProp.UseVisualStyleBackColor = True
        '
        'cmdPoisson
        '
        Me.cmdPoisson.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPoisson.Location = New System.Drawing.Point(142, 74)
        Me.cmdPoisson.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPoisson.Name = "cmdPoisson"
        Me.cmdPoisson.Size = New System.Drawing.Size(69, 30)
        Me.cmdPoisson.TabIndex = 164
        Me.cmdPoisson.Text = "poisson"
        Me.cmdPoisson.UseVisualStyleBackColor = True
        '
        'cmdVar
        '
        Me.cmdVar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdVar.Location = New System.Drawing.Point(142, 104)
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
        Me.cmdShapiro.Location = New System.Drawing.Point(4, 104)
        Me.cmdShapiro.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdShapiro.Name = "cmdShapiro"
        Me.cmdShapiro.Size = New System.Drawing.Size(69, 30)
        Me.cmdShapiro.TabIndex = 161
        Me.cmdShapiro.Text = "shapiro"
        Me.cmdShapiro.UseVisualStyleBackColor = True
        '
        'cmdWilcox
        '
        Me.cmdWilcox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdWilcox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdWilcox.Location = New System.Drawing.Point(211, 104)
        Me.cmdWilcox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdWilcox.Name = "cmdWilcox"
        Me.cmdWilcox.Size = New System.Drawing.Size(69, 30)
        Me.cmdWilcox.TabIndex = 163
        Me.cmdWilcox.Tag = "Del"
        Me.cmdWilcox.Text = "wilcox"
        Me.cmdWilcox.UseVisualStyleBackColor = True
        '
        'cmdKruskal
        '
        Me.cmdKruskal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdKruskal.Location = New System.Drawing.Point(211, 44)
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
        'cmdbox
        '
        Me.cmdbox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdbox.Location = New System.Drawing.Point(142, 14)
        Me.cmdbox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdbox.Name = "cmdbox"
        Me.cmdbox.Size = New System.Drawing.Size(69, 30)
        Me.cmdbox.TabIndex = 153
        Me.cmdbox.Text = " box"
        Me.cmdbox.UseVisualStyleBackColor = True
        '
        'cmdKs
        '
        Me.cmdKs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdKs.Location = New System.Drawing.Point(4, 74)
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
        Me.cmdFriedman.Location = New System.Drawing.Point(142, 44)
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
        Me.cmdOneway.Location = New System.Drawing.Point(73, 74)
        Me.cmdOneway.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdOneway.Name = "cmdOneway"
        Me.cmdOneway.Size = New System.Drawing.Size(69, 30)
        Me.cmdOneway.TabIndex = 148
        Me.cmdOneway.Text = "oneway"
        Me.cmdOneway.UseVisualStyleBackColor = True
        '
        'cmdCor
        '
        Me.cmdCor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCor.Location = New System.Drawing.Point(4, 44)
        Me.cmdCor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCor.Name = "cmdCor"
        Me.cmdCor.Size = New System.Drawing.Size(69, 30)
        Me.cmdCor.TabIndex = 158
        Me.cmdCor.Text = "cor"
        Me.cmdCor.UseVisualStyleBackColor = True
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
        Me.cmdfisher.Location = New System.Drawing.Point(73, 44)
        Me.cmdfisher.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdfisher.Name = "cmdfisher"
        Me.cmdfisher.Size = New System.Drawing.Size(69, 30)
        Me.cmdfisher.TabIndex = 121
        Me.cmdfisher.Text = " fisher"
        Me.cmdfisher.UseVisualStyleBackColor = True
        '
        'cmdClearStats2
        '
        Me.cmdClearStats2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdClearStats2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClearStats2.Location = New System.Drawing.Point(231, 101)
        Me.cmdClearStats2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClearStats2.Name = "cmdClearStats2"
        Me.cmdClearStats2.Size = New System.Drawing.Size(86, 30)
        Me.cmdClearStats2.TabIndex = 168
        Me.cmdClearStats2.Text = "Clear"
        Me.cmdClearStats2.UseVisualStyleBackColor = True
        '
        'cmdPropTrend
        '
        Me.cmdPropTrend.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPropTrend.Location = New System.Drawing.Point(5, 101)
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
        Me.cmdPowerProp.Location = New System.Drawing.Point(149, 72)
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
        Me.cmdPowerT.Location = New System.Drawing.Point(231, 72)
        Me.cmdPowerT.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPowerT.Name = "cmdPowerT"
        Me.cmdPowerT.Size = New System.Drawing.Size(86, 30)
        Me.cmdPowerT.TabIndex = 157
        Me.cmdPowerT.Text = "power.t"
        Me.cmdPowerT.UseVisualStyleBackColor = True
        '
        'cmdPaiwiseWilcox
        '
        Me.cmdPaiwiseWilcox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPaiwiseWilcox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPaiwiseWilcox.Location = New System.Drawing.Point(231, 43)
        Me.cmdPaiwiseWilcox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPaiwiseWilcox.Name = "cmdPaiwiseWilcox"
        Me.cmdPaiwiseWilcox.Size = New System.Drawing.Size(86, 30)
        Me.cmdPaiwiseWilcox.TabIndex = 156
        Me.cmdPaiwiseWilcox.Tag = "Del"
        Me.cmdPaiwiseWilcox.Text = "pairwise.wilcox"
        Me.cmdPaiwiseWilcox.UseVisualStyleBackColor = True
        '
        'cmdMood
        '
        Me.cmdMood.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMood.Location = New System.Drawing.Point(73, 43)
        Me.cmdMood.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMood.Name = "cmdMood"
        Me.cmdMood.Size = New System.Drawing.Size(77, 30)
        Me.cmdMood.TabIndex = 147
        Me.cmdMood.Text = "mood"
        Me.cmdMood.UseVisualStyleBackColor = True
        '
        'cmdPowerAnova
        '
        Me.cmdPowerAnova.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPowerAnova.Location = New System.Drawing.Point(73, 72)
        Me.cmdPowerAnova.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPowerAnova.Name = "cmdPowerAnova"
        Me.cmdPowerAnova.Size = New System.Drawing.Size(77, 30)
        Me.cmdPowerAnova.TabIndex = 146
        Me.cmdPowerAnova.Text = "power.anova"
        Me.cmdPowerAnova.UseVisualStyleBackColor = True
        '
        'cmdMcnemar
        '
        Me.cmdMcnemar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMcnemar.Location = New System.Drawing.Point(5, 43)
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
        Me.cmdPairwiseProp.Location = New System.Drawing.Point(149, 43)
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
        Me.cmdfligner.Location = New System.Drawing.Point(73, 14)
        Me.cmdfligner.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdfligner.Name = "cmdfligner"
        Me.cmdfligner.Size = New System.Drawing.Size(77, 30)
        Me.cmdfligner.TabIndex = 129
        Me.cmdfligner.Text = "fligner"
        Me.cmdfligner.UseVisualStyleBackColor = True
        '
        'cmdPairwiset
        '
        Me.cmdPairwiset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPairwiset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPairwiset.Location = New System.Drawing.Point(5, 72)
        Me.cmdPairwiset.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPairwiset.Name = "cmdPairwiset"
        Me.cmdPairwiset.Size = New System.Drawing.Size(69, 30)
        Me.cmdPairwiset.TabIndex = 144
        Me.cmdPairwiset.Text = "pairwise.t"
        Me.cmdPairwiset.UseVisualStyleBackColor = True
        '
        'cmdMauchly
        '
        Me.cmdMauchly.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMauchly.Location = New System.Drawing.Point(231, 14)
        Me.cmdMauchly.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMauchly.Name = "cmdMauchly"
        Me.cmdMauchly.Size = New System.Drawing.Size(86, 30)
        Me.cmdMauchly.TabIndex = 117
        Me.cmdMauchly.Text = "mauchly"
        Me.cmdMauchly.UseVisualStyleBackColor = True
        '
        'lblRpackage
        '
        Me.lblRpackage.AutoSize = True
        Me.lblRpackage.Location = New System.Drawing.Point(250, 55)
        Me.lblRpackage.Name = "lblRpackage"
        Me.lblRpackage.Size = New System.Drawing.Size(63, 13)
        Me.lblRpackage.TabIndex = 4
        Me.lblRpackage.Text = "R package:"
        '
        'cmdAnsari
        '
        Me.cmdAnsari.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAnsari.Location = New System.Drawing.Point(5, 14)
        Me.cmdAnsari.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAnsari.Name = "cmdAnsari"
        Me.cmdAnsari.Size = New System.Drawing.Size(69, 30)
        Me.cmdAnsari.TabIndex = 169
        Me.cmdAnsari.Text = "ansari"
        Me.cmdAnsari.UseVisualStyleBackColor = True
        '
        'cmdMantelhaen
        '
        Me.cmdMantelhaen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMantelhaen.Location = New System.Drawing.Point(149, 14)
        Me.cmdMantelhaen.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMantelhaen.Name = "cmdMantelhaen"
        Me.cmdMantelhaen.Size = New System.Drawing.Size(83, 30)
        Me.cmdMantelhaen.TabIndex = 170
        Me.cmdMantelhaen.Text = "mantelhaen"
        Me.cmdMantelhaen.UseVisualStyleBackColor = True
        '
        'cmdQuade
        '
        Me.cmdQuade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQuade.Location = New System.Drawing.Point(149, 101)
        Me.cmdQuade.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQuade.Name = "cmdQuade"
        Me.cmdQuade.Size = New System.Drawing.Size(83, 30)
        Me.cmdQuade.TabIndex = 171
        Me.cmdQuade.Text = "quade"
        Me.cmdQuade.UseVisualStyleBackColor = True
        '
        'cmdPP
        '
        Me.cmdPP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPP.Location = New System.Drawing.Point(73, 101)
        Me.cmdPP.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPP.Name = "cmdPP"
        Me.cmdPP.Size = New System.Drawing.Size(77, 30)
        Me.cmdPP.TabIndex = 172
        Me.cmdPP.Text = "PP"
        Me.cmdPP.UseVisualStyleBackColor = True
        '
        'grpStats2
        '
        Me.grpStats2.Controls.Add(Me.cmdPP)
        Me.grpStats2.Controls.Add(Me.cmdQuade)
        Me.grpStats2.Controls.Add(Me.cmdClearStats2)
        Me.grpStats2.Controls.Add(Me.cmdAnsari)
        Me.grpStats2.Controls.Add(Me.cmdfligner)
        Me.grpStats2.Controls.Add(Me.cmdMcnemar)
        Me.grpStats2.Controls.Add(Me.cmdMantelhaen)
        Me.grpStats2.Controls.Add(Me.cmdMauchly)
        Me.grpStats2.Controls.Add(Me.cmdMood)
        Me.grpStats2.Controls.Add(Me.cmdPairwiset)
        Me.grpStats2.Controls.Add(Me.cmdPropTrend)
        Me.grpStats2.Controls.Add(Me.cmdPowerAnova)
        Me.grpStats2.Controls.Add(Me.cmdPairwiseProp)
        Me.grpStats2.Controls.Add(Me.cmdPaiwiseWilcox)
        Me.grpStats2.Controls.Add(Me.cmdPowerT)
        Me.grpStats2.Controls.Add(Me.cmdPowerProp)
        Me.grpStats2.Location = New System.Drawing.Point(247, 79)
        Me.grpStats2.Name = "grpStats2"
        Me.grpStats2.Size = New System.Drawing.Size(325, 135)
        Me.grpStats2.TabIndex = 14
        Me.grpStats2.TabStop = False
        Me.grpStats2.Text = "Stats2"
        '
        'grpAgricolae
        '
        Me.grpAgricolae.Controls.Add(Me.cmdPBIB)
        Me.grpAgricolae.Controls.Add(Me.cmdAgriKruskal)
        Me.grpAgricolae.Controls.Add(Me.cmdScheffe)
        Me.grpAgricolae.Controls.Add(Me.cmdDurbin)
        Me.grpAgricolae.Controls.Add(Me.cmdAgriFriedman)
        Me.grpAgricolae.Controls.Add(Me.cmdSNK)
        Me.grpAgricolae.Controls.Add(Me.cmdWaerden)
        Me.grpAgricolae.Controls.Add(Me.cmdAgriWaller)
        Me.grpAgricolae.Controls.Add(Me.cmdAgriNonAdditivity)
        Me.grpAgricolae.Controls.Add(Me.cmdMedian)
        Me.grpAgricolae.Controls.Add(Me.cmdREGW)
        Me.grpAgricolae.Controls.Add(Me.cmdLSD)
        Me.grpAgricolae.Controls.Add(Me.cmdDuncan)
        Me.grpAgricolae.Controls.Add(Me.cmdBIB)
        Me.grpAgricolae.Location = New System.Drawing.Point(252, 79)
        Me.grpAgricolae.Name = "grpAgricolae"
        Me.grpAgricolae.Size = New System.Drawing.Size(314, 134)
        Me.grpAgricolae.TabIndex = 15
        Me.grpAgricolae.TabStop = False
        Me.grpAgricolae.Text = "Agricolae"
        '
        'cmdPBIB
        '
        Me.cmdPBIB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPBIB.Location = New System.Drawing.Point(6, 72)
        Me.cmdPBIB.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPBIB.Name = "cmdPBIB"
        Me.cmdPBIB.Size = New System.Drawing.Size(77, 30)
        Me.cmdPBIB.TabIndex = 186
        Me.cmdPBIB.Text = "PBIB"
        Me.cmdPBIB.UseVisualStyleBackColor = True
        '
        'cmdAgriKruskal
        '
        Me.cmdAgriKruskal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAgriKruskal.Location = New System.Drawing.Point(6, 43)
        Me.cmdAgriKruskal.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAgriKruskal.Name = "cmdAgriKruskal"
        Me.cmdAgriKruskal.Size = New System.Drawing.Size(77, 30)
        Me.cmdAgriKruskal.TabIndex = 185
        Me.cmdAgriKruskal.Text = "kruskal"
        Me.cmdAgriKruskal.UseVisualStyleBackColor = True
        '
        'cmdScheffe
        '
        Me.cmdScheffe.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdScheffe.Location = New System.Drawing.Point(158, 72)
        Me.cmdScheffe.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdScheffe.Name = "cmdScheffe"
        Me.cmdScheffe.Size = New System.Drawing.Size(77, 30)
        Me.cmdScheffe.TabIndex = 184
        Me.cmdScheffe.Text = "scheffe"
        Me.cmdScheffe.UseVisualStyleBackColor = True
        '
        'cmdDurbin
        '
        Me.cmdDurbin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDurbin.Location = New System.Drawing.Point(158, 14)
        Me.cmdDurbin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDurbin.Name = "cmdDurbin"
        Me.cmdDurbin.Size = New System.Drawing.Size(77, 30)
        Me.cmdDurbin.TabIndex = 183
        Me.cmdDurbin.Text = "durbin"
        Me.cmdDurbin.UseVisualStyleBackColor = True
        '
        'cmdAgriFriedman
        '
        Me.cmdAgriFriedman.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAgriFriedman.Location = New System.Drawing.Point(234, 14)
        Me.cmdAgriFriedman.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAgriFriedman.Name = "cmdAgriFriedman"
        Me.cmdAgriFriedman.Size = New System.Drawing.Size(77, 30)
        Me.cmdAgriFriedman.TabIndex = 182
        Me.cmdAgriFriedman.Text = "friedman"
        Me.cmdAgriFriedman.UseVisualStyleBackColor = True
        '
        'cmdSNK
        '
        Me.cmdSNK.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSNK.Location = New System.Drawing.Point(6, 101)
        Me.cmdSNK.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSNK.Name = "cmdSNK"
        Me.cmdSNK.Size = New System.Drawing.Size(77, 30)
        Me.cmdSNK.TabIndex = 181
        Me.cmdSNK.Text = "SNK"
        Me.cmdSNK.UseVisualStyleBackColor = True
        '
        'cmdWaerden
        '
        Me.cmdWaerden.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdWaerden.Location = New System.Drawing.Point(82, 101)
        Me.cmdWaerden.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdWaerden.Name = "cmdWaerden"
        Me.cmdWaerden.Size = New System.Drawing.Size(77, 30)
        Me.cmdWaerden.TabIndex = 180
        Me.cmdWaerden.Text = "waerden"
        Me.cmdWaerden.UseVisualStyleBackColor = True
        '
        'cmdAgriWaller
        '
        Me.cmdAgriWaller.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAgriWaller.Location = New System.Drawing.Point(158, 101)
        Me.cmdAgriWaller.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAgriWaller.Name = "cmdAgriWaller"
        Me.cmdAgriWaller.Size = New System.Drawing.Size(77, 30)
        Me.cmdAgriWaller.TabIndex = 179
        Me.cmdAgriWaller.Text = "waller "
        Me.cmdAgriWaller.UseVisualStyleBackColor = True
        '
        'cmdAgriNonAdditivity
        '
        Me.cmdAgriNonAdditivity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAgriNonAdditivity.Location = New System.Drawing.Point(234, 43)
        Me.cmdAgriNonAdditivity.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAgriNonAdditivity.Name = "cmdAgriNonAdditivity"
        Me.cmdAgriNonAdditivity.Size = New System.Drawing.Size(77, 30)
        Me.cmdAgriNonAdditivity.TabIndex = 178
        Me.cmdAgriNonAdditivity.Text = "nonadditivity "
        Me.cmdAgriNonAdditivity.UseVisualStyleBackColor = True
        '
        'cmdMedian
        '
        Me.cmdMedian.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMedian.Location = New System.Drawing.Point(158, 43)
        Me.cmdMedian.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMedian.Name = "cmdMedian"
        Me.cmdMedian.Size = New System.Drawing.Size(77, 30)
        Me.cmdMedian.TabIndex = 177
        Me.cmdMedian.Text = "median"
        Me.cmdMedian.UseVisualStyleBackColor = True
        '
        'cmdREGW
        '
        Me.cmdREGW.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdREGW.Location = New System.Drawing.Point(82, 72)
        Me.cmdREGW.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdREGW.Name = "cmdREGW"
        Me.cmdREGW.Size = New System.Drawing.Size(77, 30)
        Me.cmdREGW.TabIndex = 176
        Me.cmdREGW.Text = "REGW"
        Me.cmdREGW.UseVisualStyleBackColor = True
        '
        'cmdLSD
        '
        Me.cmdLSD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLSD.Location = New System.Drawing.Point(82, 43)
        Me.cmdLSD.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLSD.Name = "cmdLSD"
        Me.cmdLSD.Size = New System.Drawing.Size(77, 30)
        Me.cmdLSD.TabIndex = 175
        Me.cmdLSD.Text = "LSD"
        Me.cmdLSD.UseVisualStyleBackColor = True
        '
        'cmdDuncan
        '
        Me.cmdDuncan.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDuncan.Location = New System.Drawing.Point(82, 14)
        Me.cmdDuncan.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDuncan.Name = "cmdDuncan"
        Me.cmdDuncan.Size = New System.Drawing.Size(77, 30)
        Me.cmdDuncan.TabIndex = 174
        Me.cmdDuncan.Text = "duncan"
        Me.cmdDuncan.UseVisualStyleBackColor = True
        '
        'cmdBIB
        '
        Me.cmdBIB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBIB.Location = New System.Drawing.Point(6, 14)
        Me.cmdBIB.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBIB.Name = "cmdBIB"
        Me.cmdBIB.Size = New System.Drawing.Size(77, 30)
        Me.cmdBIB.TabIndex = 173
        Me.cmdBIB.Text = "BIB"
        Me.cmdBIB.UseVisualStyleBackColor = True
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.frmParent = Me
        Me.ucrReceiverMultiple.Location = New System.Drawing.Point(250, 250)
        Me.ucrReceiverMultiple.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Selector = Nothing
        Me.ucrReceiverMultiple.Size = New System.Drawing.Size(113, 100)
        Me.ucrReceiverMultiple.strNcFilePath = ""
        Me.ucrReceiverMultiple.TabIndex = 8
        Me.ucrReceiverMultiple.ucrSelector = Nothing
        '
        'ucrSaveResult
        '
        Me.ucrSaveResult.Location = New System.Drawing.Point(10, 385)
        Me.ucrSaveResult.Name = "ucrSaveResult"
        Me.ucrSaveResult.Size = New System.Drawing.Size(277, 24)
        Me.ucrSaveResult.TabIndex = 12
        '
        'ucrInputComboRPackage
        '
        Me.ucrInputComboRPackage.AddQuotesIfUnrecognised = True
        Me.ucrInputComboRPackage.IsReadOnly = False
        Me.ucrInputComboRPackage.Location = New System.Drawing.Point(317, 51)
        Me.ucrInputComboRPackage.Name = "ucrInputComboRPackage"
        Me.ucrInputComboRPackage.Size = New System.Drawing.Size(123, 21)
        Me.ucrInputComboRPackage.TabIndex = 5
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 426)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(452, 52)
        Me.ucrBase.TabIndex = 13
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
        Me.ucrInputTryMessage.TabIndex = 11
        '
        'ucrChkBy
        '
        Me.ucrChkBy.Checked = False
        Me.ucrChkBy.Location = New System.Drawing.Point(251, 226)
        Me.ucrChkBy.Name = "ucrChkBy"
        Me.ucrChkBy.Size = New System.Drawing.Size(69, 20)
        Me.ucrChkBy.TabIndex = 7
        '
        'ucrSelectorColumn
        '
        Me.ucrSelectorColumn.bDropUnusedFilterLevels = False
        Me.ucrSelectorColumn.bShowHiddenColumns = False
        Me.ucrSelectorColumn.bUseCurrentFilter = True
        Me.ucrSelectorColumn.Location = New System.Drawing.Point(19, 56)
        Me.ucrSelectorColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorColumn.Name = "ucrSelectorColumn"
        Me.ucrSelectorColumn.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorColumn.TabIndex = 3
        '
        'ucrChkIncludeArguments
        '
        Me.ucrChkIncludeArguments.Checked = False
        Me.ucrChkIncludeArguments.Location = New System.Drawing.Point(445, 25)
        Me.ucrChkIncludeArguments.Name = "ucrChkIncludeArguments"
        Me.ucrChkIncludeArguments.Size = New System.Drawing.Size(131, 20)
        Me.ucrChkIncludeArguments.TabIndex = 2
        '
        'ucrReceiverForTestColumn
        '
        Me.ucrReceiverForTestColumn.frmParent = Me
        Me.ucrReceiverForTestColumn.Location = New System.Drawing.Point(50, 25)
        Me.ucrReceiverForTestColumn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrReceiverForTestColumn.Name = "ucrReceiverForTestColumn"
        Me.ucrReceiverForTestColumn.Selector = Nothing
        Me.ucrReceiverForTestColumn.Size = New System.Drawing.Size(390, 27)
        Me.ucrReceiverForTestColumn.strNcFilePath = ""
        Me.ucrReceiverForTestColumn.TabIndex = 1
        Me.ucrReceiverForTestColumn.ucrSelector = Nothing
        '
        'cmdHelp
        '
        Me.cmdHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHelp.Location = New System.Drawing.Point(478, 224)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdHelp.TabIndex = 16
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'dlgHypothesisTestsCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 487)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.ucrReceiverMultiple)
        Me.Controls.Add(Me.grpStats2)
        Me.Controls.Add(Me.grpStats1)
        Me.Controls.Add(Me.ucrSaveResult)
        Me.Controls.Add(Me.ucrInputComboRPackage)
        Me.Controls.Add(Me.lblRpackage)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrInputTryMessage)
        Me.Controls.Add(Me.cmdTry)
        Me.Controls.Add(Me.ucrChkBy)
        Me.Controls.Add(Me.grpMainKeyboard)
        Me.Controls.Add(Me.ucrSelectorColumn)
        Me.Controls.Add(Me.ucrChkIncludeArguments)
        Me.Controls.Add(Me.lblTest)
        Me.Controls.Add(Me.ucrReceiverForTestColumn)
        Me.Controls.Add(Me.grpAgricolae)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgHypothesisTestsCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hypothesis Tests"
        Me.grpMainKeyboard.ResumeLayout(False)
        Me.grpStats1.ResumeLayout(False)
        Me.grpStats2.ResumeLayout(False)
        Me.grpAgricolae.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTest As Label
    Friend WithEvents ucrReceiverForTestColumn As ucrReceiverExpression
    Friend WithEvents ucrChkIncludeArguments As ucrCheck
    Friend WithEvents ucrSelectorColumn As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpMainKeyboard As GroupBox
    Friend WithEvents cmdPlus As Button
    Friend WithEvents cmdComma As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdSquiggle As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdConf As Button
    Friend WithEvents cmdBrackets As Button
    Friend WithEvents cmdAlt As Button
    Friend WithEvents cmdSquareBrackets As Button
    Friend WithEvents ucrChkBy As ucrCheck
    Friend WithEvents ucrReceiverMultiple As ucrReceiverMultiple
    Friend WithEvents ucrInputTryMessage As ucrInputTextBox
    Friend WithEvents cmdTry As Button
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpStats1 As GroupBox
    Friend WithEvents cmdPowerT As Button
    Friend WithEvents cmdPaiwiseWilcox As Button
    Friend WithEvents cmdKruskal As Button
    Friend WithEvents cmdChisq As Button
    Friend WithEvents cmdbox As Button
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
    Friend WithEvents cmdProp As Button
    Friend WithEvents cmdPoisson As Button
    Friend WithEvents cmdT As Button
    Friend WithEvents cmdClearStats2 As Button
    Friend WithEvents tpConf As ToolTip
    Friend WithEvents tpAlt As ToolTip
    Friend WithEvents ucrInputComboRPackage As ucrInputComboBox
    Friend WithEvents ucrSaveResult As ucrSave
    Friend WithEvents cmdPP As Button
    Friend WithEvents cmdQuade As Button
    Friend WithEvents cmdMantelhaen As Button
    Friend WithEvents cmdAnsari As Button
    Friend WithEvents grpAgricolae As GroupBox
    Friend WithEvents grpStats2 As GroupBox
    Friend WithEvents cmdPBIB As Button
    Friend WithEvents cmdAgriKruskal As Button
    Friend WithEvents cmdScheffe As Button
    Friend WithEvents cmdDurbin As Button
    Friend WithEvents cmdAgriFriedman As Button
    Friend WithEvents cmdSNK As Button
    Friend WithEvents cmdWaerden As Button
    Friend WithEvents cmdAgriWaller As Button
    Friend WithEvents cmdAgriNonAdditivity As Button
    Friend WithEvents cmdMedian As Button
    Friend WithEvents cmdREGW As Button
    Friend WithEvents cmdLSD As Button
    Friend WithEvents cmdDuncan As Button
    Friend WithEvents cmdBIB As Button
    Friend WithEvents cmdHelp As Button
End Class
