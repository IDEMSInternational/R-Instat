<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgModelling
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
        Me.cmdspline = New System.Windows.Forms.Button()
        Me.cmdarima = New System.Windows.Forms.Button()
        Me.cmdloglin = New System.Windows.Forms.Button()
        Me.cmdloess = New System.Windows.Forms.Button()
        Me.cmdlowess = New System.Windows.Forms.Button()
        Me.cmdglm = New System.Windows.Forms.Button()
        Me.cmdar = New System.Windows.Forms.Button()
        Me.cmdaov = New System.Windows.Forms.Button()
        Me.cmdlm = New System.Windows.Forms.Button()
        Me.grpStats = New System.Windows.Forms.GroupBox()
        Me.cmdprincomp = New System.Windows.Forms.Button()
        Me.cmdppr = New System.Windows.Forms.Button()
        Me.cmdnls = New System.Windows.Forms.Button()
        Me.cmdMultiply = New System.Windows.Forms.Button()
        Me.cmdColon = New System.Windows.Forms.Button()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.cmdPower = New System.Windows.Forms.Button()
        Me.cmdClosingBracket = New System.Windows.Forms.Button()
        Me.cmdOpeningBracket = New System.Windows.Forms.Button()
        Me.cmdDiv = New System.Windows.Forms.Button()
        Me.cmdDoubleBracket = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdSquareBrackets = New System.Windows.Forms.Button()
        Me.cmdMinus = New System.Windows.Forms.Button()
        Me.grpFirstCalc = New System.Windows.Forms.GroupBox()
        Me.cmdTilda = New System.Windows.Forms.Button()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.cmdPredict = New System.Windows.Forms.Button()
        Me.grpextRemes = New System.Windows.Forms.GroupBox()
        Me.cmdfevd = New System.Windows.Forms.Button()
        Me.cmdlevd = New System.Windows.Forms.Button()
        Me.cmdnlmer = New System.Windows.Forms.Button()
        Me.cmdlmer = New System.Windows.Forms.Button()
        Me.cmdglmer = New System.Windows.Forms.Button()
        Me.grplme4 = New System.Windows.Forms.GroupBox()
        Me.cmdloglm = New System.Windows.Forms.Button()
        Me.cmdpolr = New System.Windows.Forms.Button()
        Me.cmdglmmPQL = New System.Windows.Forms.Button()
        Me.cmdglmnb = New System.Windows.Forms.Button()
        Me.cmdrlm = New System.Windows.Forms.Button()
        Me.grpMASS = New System.Windows.Forms.GroupBox()
        Me.cmdqda = New System.Windows.Forms.Button()
        Me.cmdmca = New System.Windows.Forms.Button()
        Me.cmdlqs = New System.Windows.Forms.Button()
        Me.cmdlda = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.lblRpackage = New System.Windows.Forms.Label()
        Me.ucrTryModelling = New instat.ucrTry()
        Me.ucrChkIncludeArguments = New instat.ucrCheck()
        Me.ucrSaveResult = New instat.ucrSave()
        Me.ucrInputComboRPackage = New instat.ucrInputComboBox()
        Me.ucrReceiverForTestColumn = New instat.ucrReceiverExpression()
        Me.ucrSelectorModelling = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpStats.SuspendLayout()
        Me.grpFirstCalc.SuspendLayout()
        Me.grpextRemes.SuspendLayout()
        Me.grplme4.SuspendLayout()
        Me.grpMASS.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblModel.Location = New System.Drawing.Point(10, 17)
        Me.lblModel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(39, 13)
        Me.lblModel.TabIndex = 0
        Me.lblModel.Tag = "Test"
        Me.lblModel.Text = "Model:"
        '
        'cmdspline
        '
        Me.cmdspline.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdspline.Location = New System.Drawing.Point(140, 72)
        Me.cmdspline.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdspline.Name = "cmdspline"
        Me.cmdspline.Size = New System.Drawing.Size(69, 30)
        Me.cmdspline.TabIndex = 164
        Me.cmdspline.Text = "spline"
        Me.cmdspline.UseVisualStyleBackColor = True
        '
        'cmdarima
        '
        Me.cmdarima.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdarima.Location = New System.Drawing.Point(140, 14)
        Me.cmdarima.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdarima.Name = "cmdarima"
        Me.cmdarima.Size = New System.Drawing.Size(69, 30)
        Me.cmdarima.TabIndex = 153
        Me.cmdarima.Text = "arima"
        Me.cmdarima.UseVisualStyleBackColor = True
        '
        'cmdloglin
        '
        Me.cmdloglin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdloglin.Location = New System.Drawing.Point(4, 72)
        Me.cmdloglin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdloglin.Name = "cmdloglin"
        Me.cmdloglin.Size = New System.Drawing.Size(69, 30)
        Me.cmdloglin.TabIndex = 151
        Me.cmdloglin.Text = "loglin"
        Me.cmdloglin.UseVisualStyleBackColor = True
        '
        'cmdloess
        '
        Me.cmdloess.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdloess.Location = New System.Drawing.Point(140, 43)
        Me.cmdloess.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdloess.Name = "cmdloess"
        Me.cmdloess.Size = New System.Drawing.Size(69, 30)
        Me.cmdloess.TabIndex = 150
        Me.cmdloess.Text = "loess"
        Me.cmdloess.UseVisualStyleBackColor = True
        '
        'cmdlowess
        '
        Me.cmdlowess.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdlowess.Location = New System.Drawing.Point(72, 72)
        Me.cmdlowess.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdlowess.Name = "cmdlowess"
        Me.cmdlowess.Size = New System.Drawing.Size(69, 30)
        Me.cmdlowess.TabIndex = 148
        Me.cmdlowess.Text = "lowess"
        Me.cmdlowess.UseVisualStyleBackColor = True
        '
        'cmdglm
        '
        Me.cmdglm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdglm.Location = New System.Drawing.Point(4, 43)
        Me.cmdglm.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdglm.Name = "cmdglm"
        Me.cmdglm.Size = New System.Drawing.Size(69, 30)
        Me.cmdglm.TabIndex = 158
        Me.cmdglm.Text = "glm"
        Me.cmdglm.UseVisualStyleBackColor = True
        '
        'cmdar
        '
        Me.cmdar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdar.Location = New System.Drawing.Point(72, 14)
        Me.cmdar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdar.Name = "cmdar"
        Me.cmdar.Size = New System.Drawing.Size(69, 30)
        Me.cmdar.TabIndex = 126
        Me.cmdar.Text = "ar"
        Me.cmdar.UseVisualStyleBackColor = True
        '
        'cmdaov
        '
        Me.cmdaov.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdaov.Location = New System.Drawing.Point(4, 14)
        Me.cmdaov.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdaov.Name = "cmdaov"
        Me.cmdaov.Size = New System.Drawing.Size(69, 30)
        Me.cmdaov.TabIndex = 124
        Me.cmdaov.Text = "aov"
        Me.cmdaov.UseVisualStyleBackColor = True
        '
        'cmdlm
        '
        Me.cmdlm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdlm.Location = New System.Drawing.Point(72, 43)
        Me.cmdlm.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdlm.Name = "cmdlm"
        Me.cmdlm.Size = New System.Drawing.Size(69, 30)
        Me.cmdlm.TabIndex = 121
        Me.cmdlm.Text = "lm"
        Me.cmdlm.UseVisualStyleBackColor = True
        '
        'grpStats
        '
        Me.grpStats.Controls.Add(Me.cmdprincomp)
        Me.grpStats.Controls.Add(Me.cmdppr)
        Me.grpStats.Controls.Add(Me.cmdnls)
        Me.grpStats.Controls.Add(Me.cmdspline)
        Me.grpStats.Controls.Add(Me.cmdarima)
        Me.grpStats.Controls.Add(Me.cmdloglin)
        Me.grpStats.Controls.Add(Me.cmdloess)
        Me.grpStats.Controls.Add(Me.cmdlowess)
        Me.grpStats.Controls.Add(Me.cmdglm)
        Me.grpStats.Controls.Add(Me.cmdlm)
        Me.grpStats.Controls.Add(Me.cmdaov)
        Me.grpStats.Controls.Add(Me.cmdar)
        Me.grpStats.Location = New System.Drawing.Point(292, 68)
        Me.grpStats.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpStats.Name = "grpStats"
        Me.grpStats.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpStats.Size = New System.Drawing.Size(213, 135)
        Me.grpStats.TabIndex = 9
        Me.grpStats.TabStop = False
        Me.grpStats.Text = "stats"
        '
        'cmdprincomp
        '
        Me.cmdprincomp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdprincomp.Location = New System.Drawing.Point(140, 101)
        Me.cmdprincomp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdprincomp.Name = "cmdprincomp"
        Me.cmdprincomp.Size = New System.Drawing.Size(69, 30)
        Me.cmdprincomp.TabIndex = 167
        Me.cmdprincomp.Text = "princomp"
        Me.cmdprincomp.UseVisualStyleBackColor = True
        '
        'cmdppr
        '
        Me.cmdppr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdppr.Location = New System.Drawing.Point(72, 101)
        Me.cmdppr.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdppr.Name = "cmdppr"
        Me.cmdppr.Size = New System.Drawing.Size(69, 30)
        Me.cmdppr.TabIndex = 166
        Me.cmdppr.Text = "ppr"
        Me.cmdppr.UseVisualStyleBackColor = True
        '
        'cmdnls
        '
        Me.cmdnls.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdnls.Location = New System.Drawing.Point(4, 101)
        Me.cmdnls.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdnls.Name = "cmdnls"
        Me.cmdnls.Size = New System.Drawing.Size(69, 30)
        Me.cmdnls.TabIndex = 165
        Me.cmdnls.Text = "nls"
        Me.cmdnls.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdMultiply.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMultiply.Location = New System.Drawing.Point(59, 10)
        Me.cmdMultiply.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(29, 30)
        Me.cmdMultiply.TabIndex = 2
        Me.cmdMultiply.Text = "*"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdColon
        '
        Me.cmdColon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdColon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdColon.Location = New System.Drawing.Point(31, 10)
        Me.cmdColon.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdColon.Name = "cmdColon"
        Me.cmdColon.Size = New System.Drawing.Size(29, 30)
        Me.cmdColon.TabIndex = 1
        Me.cmdColon.Text = ":"
        Me.cmdColon.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdPlus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlus.Location = New System.Drawing.Point(3, 10)
        Me.cmdPlus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(29, 30)
        Me.cmdPlus.TabIndex = 0
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        Me.cmdPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdPower.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPower.Location = New System.Drawing.Point(87, 39)
        Me.cmdPower.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.Size = New System.Drawing.Size(29, 32)
        Me.cmdPower.TabIndex = 7
        Me.cmdPower.Text = "^"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdClosingBracket
        '
        Me.cmdClosingBracket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdClosingBracket.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClosingBracket.Location = New System.Drawing.Point(59, 39)
        Me.cmdClosingBracket.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClosingBracket.Name = "cmdClosingBracket"
        Me.cmdClosingBracket.Size = New System.Drawing.Size(29, 32)
        Me.cmdClosingBracket.TabIndex = 6
        Me.cmdClosingBracket.Text = ")"
        Me.cmdClosingBracket.UseVisualStyleBackColor = True
        '
        'cmdOpeningBracket
        '
        Me.cmdOpeningBracket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdOpeningBracket.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOpeningBracket.Location = New System.Drawing.Point(31, 39)
        Me.cmdOpeningBracket.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdOpeningBracket.Name = "cmdOpeningBracket"
        Me.cmdOpeningBracket.Size = New System.Drawing.Size(29, 32)
        Me.cmdOpeningBracket.TabIndex = 5
        Me.cmdOpeningBracket.Text = "("
        Me.cmdOpeningBracket.UseVisualStyleBackColor = True
        '
        'cmdDiv
        '
        Me.cmdDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdDiv.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDiv.Location = New System.Drawing.Point(87, 10)
        Me.cmdDiv.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDiv.Name = "cmdDiv"
        Me.cmdDiv.Size = New System.Drawing.Size(29, 30)
        Me.cmdDiv.TabIndex = 3
        Me.cmdDiv.Text = "/"
        Me.cmdDiv.UseVisualStyleBackColor = True
        '
        'cmdDoubleBracket
        '
        Me.cmdDoubleBracket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdDoubleBracket.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDoubleBracket.Location = New System.Drawing.Point(3, 39)
        Me.cmdDoubleBracket.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDoubleBracket.Name = "cmdDoubleBracket"
        Me.cmdDoubleBracket.Size = New System.Drawing.Size(29, 32)
        Me.cmdDoubleBracket.TabIndex = 4
        Me.cmdDoubleBracket.Text = "( )"
        Me.cmdDoubleBracket.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClear.Location = New System.Drawing.Point(417, 251)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(57, 30)
        Me.cmdClear.TabIndex = 10
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdSquareBrackets
        '
        Me.cmdSquareBrackets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdSquareBrackets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSquareBrackets.Location = New System.Drawing.Point(31, 70)
        Me.cmdSquareBrackets.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSquareBrackets.Name = "cmdSquareBrackets"
        Me.cmdSquareBrackets.Size = New System.Drawing.Size(29, 30)
        Me.cmdSquareBrackets.TabIndex = 9
        Me.cmdSquareBrackets.Text = "[ ]"
        Me.cmdSquareBrackets.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        Me.cmdMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdMinus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMinus.Location = New System.Drawing.Point(3, 70)
        Me.cmdMinus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.Size = New System.Drawing.Size(29, 30)
        Me.cmdMinus.TabIndex = 8
        Me.cmdMinus.Text = "-"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'grpFirstCalc
        '
        Me.grpFirstCalc.Controls.Add(Me.cmdTilda)
        Me.grpFirstCalc.Controls.Add(Me.cmdMultiply)
        Me.grpFirstCalc.Controls.Add(Me.cmdColon)
        Me.grpFirstCalc.Controls.Add(Me.cmdPlus)
        Me.grpFirstCalc.Controls.Add(Me.cmdPower)
        Me.grpFirstCalc.Controls.Add(Me.cmdClosingBracket)
        Me.grpFirstCalc.Controls.Add(Me.cmdOpeningBracket)
        Me.grpFirstCalc.Controls.Add(Me.cmdDiv)
        Me.grpFirstCalc.Controls.Add(Me.cmdDoubleBracket)
        Me.grpFirstCalc.Controls.Add(Me.cmdSquareBrackets)
        Me.grpFirstCalc.Controls.Add(Me.cmdMinus)
        Me.grpFirstCalc.Location = New System.Drawing.Point(293, 205)
        Me.grpFirstCalc.Name = "grpFirstCalc"
        Me.grpFirstCalc.Size = New System.Drawing.Size(119, 103)
        Me.grpFirstCalc.TabIndex = 10
        Me.grpFirstCalc.TabStop = False
        '
        'cmdTilda
        '
        Me.cmdTilda.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.cmdTilda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTilda.Location = New System.Drawing.Point(59, 70)
        Me.cmdTilda.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTilda.Name = "cmdTilda"
        Me.cmdTilda.Size = New System.Drawing.Size(57, 30)
        Me.cmdTilda.TabIndex = 21
        Me.cmdTilda.Text = "~"
        Me.cmdTilda.UseVisualStyleBackColor = True
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(287, 354)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(125, 23)
        Me.cmdDisplayOptions.TabIndex = 11
        Me.cmdDisplayOptions.Text = "Display Options"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'cmdPredict
        '
        Me.cmdPredict.Enabled = False
        Me.cmdPredict.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPredict.Location = New System.Drawing.Point(418, 355)
        Me.cmdPredict.Name = "cmdPredict"
        Me.cmdPredict.Size = New System.Drawing.Size(105, 23)
        Me.cmdPredict.TabIndex = 12
        Me.cmdPredict.Text = "Predict"
        Me.cmdPredict.UseVisualStyleBackColor = True
        '
        'grpextRemes
        '
        Me.grpextRemes.Controls.Add(Me.cmdfevd)
        Me.grpextRemes.Controls.Add(Me.cmdlevd)
        Me.grpextRemes.Location = New System.Drawing.Point(292, 68)
        Me.grpextRemes.Name = "grpextRemes"
        Me.grpextRemes.Size = New System.Drawing.Size(154, 49)
        Me.grpextRemes.TabIndex = 18
        Me.grpextRemes.TabStop = False
        Me.grpextRemes.Text = "extRemes"
        '
        'cmdfevd
        '
        Me.cmdfevd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdfevd.Location = New System.Drawing.Point(4, 14)
        Me.cmdfevd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdfevd.Name = "cmdfevd"
        Me.cmdfevd.Size = New System.Drawing.Size(69, 30)
        Me.cmdfevd.TabIndex = 169
        Me.cmdfevd.Text = "fevd"
        Me.cmdfevd.UseVisualStyleBackColor = True
        '
        'cmdlevd
        '
        Me.cmdlevd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdlevd.Location = New System.Drawing.Point(72, 14)
        Me.cmdlevd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdlevd.Name = "cmdlevd"
        Me.cmdlevd.Size = New System.Drawing.Size(69, 30)
        Me.cmdlevd.TabIndex = 129
        Me.cmdlevd.Text = "levd"
        Me.cmdlevd.UseVisualStyleBackColor = True
        '
        'cmdnlmer
        '
        Me.cmdnlmer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdnlmer.Location = New System.Drawing.Point(140, 14)
        Me.cmdnlmer.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdnlmer.Name = "cmdnlmer"
        Me.cmdnlmer.Size = New System.Drawing.Size(69, 30)
        Me.cmdnlmer.TabIndex = 153
        Me.cmdnlmer.Text = "nlmer"
        Me.cmdnlmer.UseVisualStyleBackColor = True
        '
        'cmdlmer
        '
        Me.cmdlmer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdlmer.Location = New System.Drawing.Point(72, 14)
        Me.cmdlmer.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdlmer.Name = "cmdlmer"
        Me.cmdlmer.Size = New System.Drawing.Size(69, 30)
        Me.cmdlmer.TabIndex = 126
        Me.cmdlmer.Text = "lmer"
        Me.cmdlmer.UseVisualStyleBackColor = True
        '
        'cmdglmer
        '
        Me.cmdglmer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdglmer.Location = New System.Drawing.Point(4, 14)
        Me.cmdglmer.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdglmer.Name = "cmdglmer"
        Me.cmdglmer.Size = New System.Drawing.Size(69, 30)
        Me.cmdglmer.TabIndex = 124
        Me.cmdglmer.Text = "glmer"
        Me.cmdglmer.UseVisualStyleBackColor = True
        '
        'grplme4
        '
        Me.grplme4.Controls.Add(Me.cmdlmer)
        Me.grplme4.Controls.Add(Me.cmdglmer)
        Me.grplme4.Controls.Add(Me.cmdnlmer)
        Me.grplme4.Location = New System.Drawing.Point(292, 68)
        Me.grplme4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grplme4.Name = "grplme4"
        Me.grplme4.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grplme4.Size = New System.Drawing.Size(213, 47)
        Me.grplme4.TabIndex = 6
        Me.grplme4.TabStop = False
        Me.grplme4.Text = "lme4"
        '
        'cmdloglm
        '
        Me.cmdloglm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdloglm.Location = New System.Drawing.Point(140, 14)
        Me.cmdloglm.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdloglm.Name = "cmdloglm"
        Me.cmdloglm.Size = New System.Drawing.Size(69, 30)
        Me.cmdloglm.TabIndex = 153
        Me.cmdloglm.Text = "loglm"
        Me.cmdloglm.UseVisualStyleBackColor = True
        '
        'cmdpolr
        '
        Me.cmdpolr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdpolr.Location = New System.Drawing.Point(4, 43)
        Me.cmdpolr.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdpolr.Name = "cmdpolr"
        Me.cmdpolr.Size = New System.Drawing.Size(69, 30)
        Me.cmdpolr.TabIndex = 158
        Me.cmdpolr.Text = "polr"
        Me.cmdpolr.UseVisualStyleBackColor = True
        '
        'cmdglmmPQL
        '
        Me.cmdglmmPQL.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdglmmPQL.Location = New System.Drawing.Point(72, 14)
        Me.cmdglmmPQL.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdglmmPQL.Name = "cmdglmmPQL"
        Me.cmdglmmPQL.Size = New System.Drawing.Size(69, 30)
        Me.cmdglmmPQL.TabIndex = 126
        Me.cmdglmmPQL.Text = "glmmPQL"
        Me.cmdglmmPQL.UseVisualStyleBackColor = True
        '
        'cmdglmnb
        '
        Me.cmdglmnb.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdglmnb.Location = New System.Drawing.Point(4, 14)
        Me.cmdglmnb.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdglmnb.Name = "cmdglmnb"
        Me.cmdglmnb.Size = New System.Drawing.Size(69, 30)
        Me.cmdglmnb.TabIndex = 124
        Me.cmdglmnb.Text = "glm.nb"
        Me.cmdglmnb.UseVisualStyleBackColor = True
        '
        'cmdrlm
        '
        Me.cmdrlm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdrlm.Location = New System.Drawing.Point(72, 43)
        Me.cmdrlm.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdrlm.Name = "cmdrlm"
        Me.cmdrlm.Size = New System.Drawing.Size(69, 30)
        Me.cmdrlm.TabIndex = 121
        Me.cmdrlm.Text = "rlm"
        Me.cmdrlm.UseVisualStyleBackColor = True
        '
        'grpMASS
        '
        Me.grpMASS.Controls.Add(Me.cmdqda)
        Me.grpMASS.Controls.Add(Me.cmdmca)
        Me.grpMASS.Controls.Add(Me.cmdlqs)
        Me.grpMASS.Controls.Add(Me.cmdlda)
        Me.grpMASS.Controls.Add(Me.cmdpolr)
        Me.grpMASS.Controls.Add(Me.cmdglmmPQL)
        Me.grpMASS.Controls.Add(Me.cmdglmnb)
        Me.grpMASS.Controls.Add(Me.cmdrlm)
        Me.grpMASS.Controls.Add(Me.cmdloglm)
        Me.grpMASS.Location = New System.Drawing.Point(292, 68)
        Me.grpMASS.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpMASS.Name = "grpMASS"
        Me.grpMASS.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpMASS.Size = New System.Drawing.Size(213, 106)
        Me.grpMASS.TabIndex = 20
        Me.grpMASS.TabStop = False
        Me.grpMASS.Text = "MASS"
        '
        'cmdqda
        '
        Me.cmdqda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdqda.Location = New System.Drawing.Point(140, 72)
        Me.cmdqda.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdqda.Name = "cmdqda"
        Me.cmdqda.Size = New System.Drawing.Size(69, 30)
        Me.cmdqda.TabIndex = 166
        Me.cmdqda.Text = "qda"
        Me.cmdqda.UseVisualStyleBackColor = True
        '
        'cmdmca
        '
        Me.cmdmca.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdmca.Location = New System.Drawing.Point(4, 72)
        Me.cmdmca.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdmca.Name = "cmdmca"
        Me.cmdmca.Size = New System.Drawing.Size(69, 30)
        Me.cmdmca.TabIndex = 161
        Me.cmdmca.Text = "mca"
        Me.cmdmca.UseVisualStyleBackColor = True
        '
        'cmdlqs
        '
        Me.cmdlqs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdlqs.Location = New System.Drawing.Point(72, 72)
        Me.cmdlqs.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdlqs.Name = "cmdlqs"
        Me.cmdlqs.Size = New System.Drawing.Size(69, 30)
        Me.cmdlqs.TabIndex = 160
        Me.cmdlqs.Text = "lqs"
        Me.cmdlqs.UseVisualStyleBackColor = True
        '
        'cmdlda
        '
        Me.cmdlda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdlda.Location = New System.Drawing.Point(140, 43)
        Me.cmdlda.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdlda.Name = "cmdlda"
        Me.cmdlda.Size = New System.Drawing.Size(69, 30)
        Me.cmdlda.TabIndex = 159
        Me.cmdlda.Text = "lda"
        Me.cmdlda.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHelp.Location = New System.Drawing.Point(493, 38)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(60, 23)
        Me.cmdHelp.TabIndex = 7
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'lblRpackage
        '
        Me.lblRpackage.AutoSize = True
        Me.lblRpackage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRpackage.Location = New System.Drawing.Point(292, 43)
        Me.lblRpackage.Name = "lblRpackage"
        Me.lblRpackage.Size = New System.Drawing.Size(63, 13)
        Me.lblRpackage.TabIndex = 3
        Me.lblRpackage.Text = "R package:"
        '
        'ucrTryModelling
        '
        Me.ucrTryModelling.AutoSize = True
        Me.ucrTryModelling.Location = New System.Drawing.Point(4, 314)
        Me.ucrTryModelling.Name = "ucrTryModelling"
        Me.ucrTryModelling.RunCommandAsMultipleLines = False
        Me.ucrTryModelling.Size = New System.Drawing.Size(480, 33)
        Me.ucrTryModelling.TabIndex = 21
        '
        'ucrChkIncludeArguments
        '
        Me.ucrChkIncludeArguments.AutoSize = True
        Me.ucrChkIncludeArguments.Checked = False
        Me.ucrChkIncludeArguments.Location = New System.Drawing.Point(442, 13)
        Me.ucrChkIncludeArguments.Name = "ucrChkIncludeArguments"
        Me.ucrChkIncludeArguments.Size = New System.Drawing.Size(131, 23)
        Me.ucrChkIncludeArguments.TabIndex = 2
        '
        'ucrSaveResult
        '
        Me.ucrSaveResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveResult.Location = New System.Drawing.Point(13, 355)
        Me.ucrSaveResult.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveResult.Name = "ucrSaveResult"
        Me.ucrSaveResult.Size = New System.Drawing.Size(267, 24)
        Me.ucrSaveResult.TabIndex = 13
        '
        'ucrInputComboRPackage
        '
        Me.ucrInputComboRPackage.AddQuotesIfUnrecognised = True
        Me.ucrInputComboRPackage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboRPackage.GetSetSelectedIndex = -1
        Me.ucrInputComboRPackage.IsReadOnly = False
        Me.ucrInputComboRPackage.Location = New System.Drawing.Point(364, 39)
        Me.ucrInputComboRPackage.Name = "ucrInputComboRPackage"
        Me.ucrInputComboRPackage.Size = New System.Drawing.Size(123, 21)
        Me.ucrInputComboRPackage.TabIndex = 4
        '
        'ucrReceiverForTestColumn
        '
        Me.ucrReceiverForTestColumn.AutoSize = True
        Me.ucrReceiverForTestColumn.frmParent = Me
        Me.ucrReceiverForTestColumn.Location = New System.Drawing.Point(63, 13)
        Me.ucrReceiverForTestColumn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrReceiverForTestColumn.Name = "ucrReceiverForTestColumn"
        Me.ucrReceiverForTestColumn.Selector = Nothing
        Me.ucrReceiverForTestColumn.Size = New System.Drawing.Size(368, 27)
        Me.ucrReceiverForTestColumn.strNcFilePath = ""
        Me.ucrReceiverForTestColumn.TabIndex = 1
        Me.ucrReceiverForTestColumn.ucrSelector = Nothing
        '
        'ucrSelectorModelling
        '
        Me.ucrSelectorModelling.AutoSize = True
        Me.ucrSelectorModelling.bDropUnusedFilterLevels = False
        Me.ucrSelectorModelling.bShowHiddenColumns = False
        Me.ucrSelectorModelling.bUseCurrentFilter = True
        Me.ucrSelectorModelling.Location = New System.Drawing.Point(10, 66)
        Me.ucrSelectorModelling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorModelling.Name = "ucrSelectorModelling"
        Me.ucrSelectorModelling.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorModelling.TabIndex = 5
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(13, 387)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 14
        '
        'dlgModelling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(566, 442)
        Me.Controls.Add(Me.ucrTryModelling)
        Me.Controls.Add(Me.grplme4)
        Me.Controls.Add(Me.grpMASS)
        Me.Controls.Add(Me.grpextRemes)
        Me.Controls.Add(Me.ucrChkIncludeArguments)
        Me.Controls.Add(Me.lblRpackage)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.cmdPredict)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.ucrSaveResult)
        Me.Controls.Add(Me.grpFirstCalc)
        Me.Controls.Add(Me.ucrInputComboRPackage)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.ucrReceiverForTestColumn)
        Me.Controls.Add(Me.ucrSelectorModelling)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpStats)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgModelling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fit Model"
        Me.grpStats.ResumeLayout(False)
        Me.grpFirstCalc.ResumeLayout(False)
        Me.grpextRemes.ResumeLayout(False)
        Me.grplme4.ResumeLayout(False)
        Me.grpMASS.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorModelling As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputComboRPackage As ucrInputComboBox
    Friend WithEvents lblModel As Label
    Friend WithEvents ucrReceiverForTestColumn As ucrReceiverExpression
    Friend WithEvents grpStats As GroupBox
    Friend WithEvents cmdspline As Button
    Friend WithEvents cmdarima As Button
    Friend WithEvents cmdloglin As Button
    Friend WithEvents cmdloess As Button
    Friend WithEvents cmdlowess As Button
    Friend WithEvents cmdglm As Button
    Friend WithEvents cmdar As Button
    Friend WithEvents cmdaov As Button
    Friend WithEvents cmdlm As Button
    Friend WithEvents grpFirstCalc As GroupBox
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmdColon As Button
    Friend WithEvents cmdPlus As Button
    Friend WithEvents cmdPower As Button
    Friend WithEvents cmdClosingBracket As Button
    Friend WithEvents cmdOpeningBracket As Button
    Friend WithEvents cmdDiv As Button
    Friend WithEvents cmdDoubleBracket As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdSquareBrackets As Button
    Friend WithEvents cmdMinus As Button
    Friend WithEvents ucrSaveResult As ucrSave
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents cmdPredict As Button
    Friend WithEvents grpextRemes As GroupBox
    Friend WithEvents cmdfevd As Button
    Friend WithEvents cmdlevd As Button
    Friend WithEvents grplme4 As GroupBox
    Friend WithEvents cmdnlmer As Button
    Friend WithEvents cmdlmer As Button
    Friend WithEvents cmdglmer As Button
    Friend WithEvents grpMASS As GroupBox
    Friend WithEvents cmdloglm As Button
    Friend WithEvents cmdpolr As Button
    Friend WithEvents cmdglmmPQL As Button
    Friend WithEvents cmdglmnb As Button
    Friend WithEvents cmdrlm As Button
    Friend WithEvents cmdHelp As Button
    Friend WithEvents lblRpackage As Label
    Friend WithEvents ucrChkIncludeArguments As ucrCheck
    Friend WithEvents cmdTilda As Button
    Friend WithEvents cmdppr As Button
    Friend WithEvents cmdnls As Button
    Friend WithEvents cmdprincomp As Button
    Friend WithEvents cmdlda As Button
    Friend WithEvents cmdlqs As Button
    Friend WithEvents cmdmca As Button
    Friend WithEvents cmdqda As Button
    Friend WithEvents ucrTryModelling As ucrTry
End Class
