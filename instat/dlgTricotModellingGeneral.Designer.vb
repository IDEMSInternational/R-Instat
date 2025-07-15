<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTricotModellingGeneral
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
        Me.ucrInputCheckVariety = New instat.ucrInputTextBox()
        Me.btnDisplayOptions = New System.Windows.Forms.Button()
        Me.btnModelOptions = New System.Windows.Forms.Button()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveModellingGeneral = New instat.ucrSave()
        Me.lblExplanatory = New System.Windows.Forms.Label()
        Me.lblTraitsToModel = New System.Windows.Forms.Label()
        Me.ucrTraitsReceiver = New instat.ucrReceiverMultiple()
        Me.ucrSelectorVarietyLevel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSelectorTraitsRanking = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpSecondCalc = New System.Windows.Forms.GroupBox()
        Me.cmdCos = New System.Windows.Forms.Button()
        Me.cmdSqrt = New System.Windows.Forms.Button()
        Me.cmdSin = New System.Windows.Forms.Button()
        Me.cmdLog = New System.Windows.Forms.Button()
        Me.cmdTan = New System.Windows.Forms.Button()
        Me.cmdExp = New System.Windows.Forms.Button()
        Me.grpFirstCalc = New System.Windows.Forms.GroupBox()
        Me.cmdMultiply = New System.Windows.Forms.Button()
        Me.cmdColon = New System.Windows.Forms.Button()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.cmdPower = New System.Windows.Forms.Button()
        Me.cmdClosingBracket = New System.Windows.Forms.Button()
        Me.cmdOpeningBracket = New System.Windows.Forms.Button()
        Me.cmdDiv = New System.Windows.Forms.Button()
        Me.cmdDoubleBracket = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdZero = New System.Windows.Forms.Button()
        Me.cmdMinus = New System.Windows.Forms.Button()
        Me.ucrReceiverExpressionModellingGeneral = New instat.ucrReceiverExpression()
        Me.lblCheckVareity = New System.Windows.Forms.Label()
        Me.grpSecondCalc.SuspendLayout()
        Me.grpFirstCalc.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrInputCheckVariety
        '
        Me.ucrInputCheckVariety.AddQuotesIfUnrecognised = True
        Me.ucrInputCheckVariety.AutoSize = True
        Me.ucrInputCheckVariety.IsMultiline = False
        Me.ucrInputCheckVariety.IsReadOnly = False
        Me.ucrInputCheckVariety.Location = New System.Drawing.Point(86, 603)
        Me.ucrInputCheckVariety.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputCheckVariety.Name = "ucrInputCheckVariety"
        Me.ucrInputCheckVariety.Size = New System.Drawing.Size(400, 32)
        Me.ucrInputCheckVariety.TabIndex = 9
        '
        'btnDisplayOptions
        '
        Me.btnDisplayOptions.Location = New System.Drawing.Point(604, 603)
        Me.btnDisplayOptions.Name = "btnDisplayOptions"
        Me.btnDisplayOptions.Size = New System.Drawing.Size(172, 32)
        Me.btnDisplayOptions.TabIndex = 11
        Me.btnDisplayOptions.Text = "Display Options"
        Me.btnDisplayOptions.UseVisualStyleBackColor = True
        '
        'btnModelOptions
        '
        Me.btnModelOptions.Location = New System.Drawing.Point(604, 565)
        Me.btnModelOptions.Name = "btnModelOptions"
        Me.btnModelOptions.Size = New System.Drawing.Size(172, 32)
        Me.btnModelOptions.TabIndex = 10
        Me.btnModelOptions.Text = "Model Options"
        Me.btnModelOptions.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 708)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 13
        '
        'ucrSaveModellingGeneral
        '
        Me.ucrSaveModellingGeneral.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveModellingGeneral.Location = New System.Drawing.Point(15, 646)
        Me.ucrSaveModellingGeneral.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveModellingGeneral.Name = "ucrSaveModellingGeneral"
        Me.ucrSaveModellingGeneral.Size = New System.Drawing.Size(604, 48)
        Me.ucrSaveModellingGeneral.TabIndex = 12
        '
        'lblExplanatory
        '
        Me.lblExplanatory.AutoSize = True
        Me.lblExplanatory.Location = New System.Drawing.Point(386, 284)
        Me.lblExplanatory.Name = "lblExplanatory"
        Me.lblExplanatory.Size = New System.Drawing.Size(158, 20)
        Me.lblExplanatory.TabIndex = 4
        Me.lblExplanatory.Text = "Explanatory Variable:"
        '
        'lblTraitsToModel
        '
        Me.lblTraitsToModel.AutoSize = True
        Me.lblTraitsToModel.Location = New System.Drawing.Point(393, 62)
        Me.lblTraitsToModel.Name = "lblTraitsToModel"
        Me.lblTraitsToModel.Size = New System.Drawing.Size(117, 20)
        Me.lblTraitsToModel.TabIndex = 1
        Me.lblTraitsToModel.Text = "Traits to Model:"
        '
        'ucrTraitsReceiver
        '
        Me.ucrTraitsReceiver.AutoSize = True
        Me.ucrTraitsReceiver.frmParent = Me
        Me.ucrTraitsReceiver.Location = New System.Drawing.Point(390, 85)
        Me.ucrTraitsReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrTraitsReceiver.Name = "ucrTraitsReceiver"
        Me.ucrTraitsReceiver.Selector = Nothing
        Me.ucrTraitsReceiver.Size = New System.Drawing.Size(259, 181)
        Me.ucrTraitsReceiver.strNcFilePath = ""
        Me.ucrTraitsReceiver.TabIndex = 2
        Me.ucrTraitsReceiver.ucrSelector = Nothing
        '
        'ucrSelectorVarietyLevel
        '
        Me.ucrSelectorVarietyLevel.AutoSize = True
        Me.ucrSelectorVarietyLevel.bDropUnusedFilterLevels = False
        Me.ucrSelectorVarietyLevel.bShowHiddenColumns = False
        Me.ucrSelectorVarietyLevel.bUseCurrentFilter = True
        Me.ucrSelectorVarietyLevel.Location = New System.Drawing.Point(15, 306)
        Me.ucrSelectorVarietyLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorVarietyLevel.Name = "ucrSelectorVarietyLevel"
        Me.ucrSelectorVarietyLevel.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorVarietyLevel.TabIndex = 3
        '
        'ucrSelectorTraitsRanking
        '
        Me.ucrSelectorTraitsRanking.AutoSize = True
        Me.ucrSelectorTraitsRanking.bDropUnusedFilterLevels = False
        Me.ucrSelectorTraitsRanking.bShowHiddenColumns = False
        Me.ucrSelectorTraitsRanking.bUseCurrentFilter = True
        Me.ucrSelectorTraitsRanking.Location = New System.Drawing.Point(15, 15)
        Me.ucrSelectorTraitsRanking.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTraitsRanking.Name = "ucrSelectorTraitsRanking"
        Me.ucrSelectorTraitsRanking.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorTraitsRanking.TabIndex = 0
        '
        'grpSecondCalc
        '
        Me.grpSecondCalc.Controls.Add(Me.cmdCos)
        Me.grpSecondCalc.Controls.Add(Me.cmdSqrt)
        Me.grpSecondCalc.Controls.Add(Me.cmdSin)
        Me.grpSecondCalc.Controls.Add(Me.cmdLog)
        Me.grpSecondCalc.Controls.Add(Me.cmdTan)
        Me.grpSecondCalc.Controls.Add(Me.cmdExp)
        Me.grpSecondCalc.Location = New System.Drawing.Point(587, 348)
        Me.grpSecondCalc.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSecondCalc.Name = "grpSecondCalc"
        Me.grpSecondCalc.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSecondCalc.Size = New System.Drawing.Size(189, 166)
        Me.grpSecondCalc.TabIndex = 7
        Me.grpSecondCalc.TabStop = False
        '
        'cmdCos
        '
        Me.cmdCos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCos.Location = New System.Drawing.Point(93, 15)
        Me.cmdCos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCos.Name = "cmdCos"
        Me.cmdCos.Size = New System.Drawing.Size(84, 45)
        Me.cmdCos.TabIndex = 1
        Me.cmdCos.Text = "cos"
        Me.cmdCos.UseVisualStyleBackColor = True
        '
        'cmdSqrt
        '
        Me.cmdSqrt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSqrt.Location = New System.Drawing.Point(8, 15)
        Me.cmdSqrt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSqrt.Name = "cmdSqrt"
        Me.cmdSqrt.Size = New System.Drawing.Size(84, 45)
        Me.cmdSqrt.TabIndex = 0
        Me.cmdSqrt.Text = "sqrt"
        Me.cmdSqrt.UseVisualStyleBackColor = True
        '
        'cmdSin
        '
        Me.cmdSin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSin.Location = New System.Drawing.Point(93, 63)
        Me.cmdSin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSin.Name = "cmdSin"
        Me.cmdSin.Size = New System.Drawing.Size(84, 45)
        Me.cmdSin.TabIndex = 3
        Me.cmdSin.Text = "sin"
        Me.cmdSin.UseVisualStyleBackColor = True
        '
        'cmdLog
        '
        Me.cmdLog.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLog.Location = New System.Drawing.Point(8, 63)
        Me.cmdLog.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLog.Name = "cmdLog"
        Me.cmdLog.Size = New System.Drawing.Size(84, 45)
        Me.cmdLog.TabIndex = 2
        Me.cmdLog.Text = "log"
        Me.cmdLog.UseVisualStyleBackColor = True
        '
        'cmdTan
        '
        Me.cmdTan.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTan.Location = New System.Drawing.Point(93, 111)
        Me.cmdTan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdTan.Name = "cmdTan"
        Me.cmdTan.Size = New System.Drawing.Size(84, 45)
        Me.cmdTan.TabIndex = 5
        Me.cmdTan.Text = "tan"
        Me.cmdTan.UseVisualStyleBackColor = True
        '
        'cmdExp
        '
        Me.cmdExp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdExp.Location = New System.Drawing.Point(8, 111)
        Me.cmdExp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdExp.Name = "cmdExp"
        Me.cmdExp.Size = New System.Drawing.Size(84, 45)
        Me.cmdExp.TabIndex = 4
        Me.cmdExp.Text = "exp"
        Me.cmdExp.UseVisualStyleBackColor = True
        '
        'grpFirstCalc
        '
        Me.grpFirstCalc.Controls.Add(Me.cmdMultiply)
        Me.grpFirstCalc.Controls.Add(Me.cmdColon)
        Me.grpFirstCalc.Controls.Add(Me.cmdPlus)
        Me.grpFirstCalc.Controls.Add(Me.cmdPower)
        Me.grpFirstCalc.Controls.Add(Me.cmdClosingBracket)
        Me.grpFirstCalc.Controls.Add(Me.cmdOpeningBracket)
        Me.grpFirstCalc.Controls.Add(Me.cmdDiv)
        Me.grpFirstCalc.Controls.Add(Me.cmdDoubleBracket)
        Me.grpFirstCalc.Controls.Add(Me.cmdClear)
        Me.grpFirstCalc.Controls.Add(Me.cmdZero)
        Me.grpFirstCalc.Controls.Add(Me.cmdMinus)
        Me.grpFirstCalc.Location = New System.Drawing.Point(390, 348)
        Me.grpFirstCalc.Margin = New System.Windows.Forms.Padding(4)
        Me.grpFirstCalc.Name = "grpFirstCalc"
        Me.grpFirstCalc.Padding = New System.Windows.Forms.Padding(4)
        Me.grpFirstCalc.Size = New System.Drawing.Size(196, 166)
        Me.grpFirstCalc.TabIndex = 6
        Me.grpFirstCalc.TabStop = False
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdMultiply.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMultiply.Location = New System.Drawing.Point(100, 15)
        Me.cmdMultiply.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(44, 45)
        Me.cmdMultiply.TabIndex = 2
        Me.cmdMultiply.Text = "*"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdColon
        '
        Me.cmdColon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdColon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdColon.Location = New System.Drawing.Point(56, 15)
        Me.cmdColon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdColon.Name = "cmdColon"
        Me.cmdColon.Size = New System.Drawing.Size(44, 45)
        Me.cmdColon.TabIndex = 1
        Me.cmdColon.Text = ":"
        Me.cmdColon.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdPlus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlus.Location = New System.Drawing.Point(10, 15)
        Me.cmdPlus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(44, 45)
        Me.cmdPlus.TabIndex = 0
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        Me.cmdPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdPower.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPower.Location = New System.Drawing.Point(146, 62)
        Me.cmdPower.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.Size = New System.Drawing.Size(44, 48)
        Me.cmdPower.TabIndex = 7
        Me.cmdPower.Text = "^"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdClosingBracket
        '
        Me.cmdClosingBracket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdClosingBracket.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClosingBracket.Location = New System.Drawing.Point(100, 62)
        Me.cmdClosingBracket.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdClosingBracket.Name = "cmdClosingBracket"
        Me.cmdClosingBracket.Size = New System.Drawing.Size(44, 48)
        Me.cmdClosingBracket.TabIndex = 6
        Me.cmdClosingBracket.Text = ")"
        Me.cmdClosingBracket.UseVisualStyleBackColor = True
        '
        'cmdOpeningBracket
        '
        Me.cmdOpeningBracket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdOpeningBracket.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOpeningBracket.Location = New System.Drawing.Point(56, 62)
        Me.cmdOpeningBracket.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdOpeningBracket.Name = "cmdOpeningBracket"
        Me.cmdOpeningBracket.Size = New System.Drawing.Size(44, 48)
        Me.cmdOpeningBracket.TabIndex = 5
        Me.cmdOpeningBracket.Text = "("
        Me.cmdOpeningBracket.UseVisualStyleBackColor = True
        '
        'cmdDiv
        '
        Me.cmdDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdDiv.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDiv.Location = New System.Drawing.Point(146, 15)
        Me.cmdDiv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDiv.Name = "cmdDiv"
        Me.cmdDiv.Size = New System.Drawing.Size(44, 45)
        Me.cmdDiv.TabIndex = 3
        Me.cmdDiv.Text = "/"
        Me.cmdDiv.UseVisualStyleBackColor = True
        '
        'cmdDoubleBracket
        '
        Me.cmdDoubleBracket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdDoubleBracket.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDoubleBracket.Location = New System.Drawing.Point(10, 62)
        Me.cmdDoubleBracket.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDoubleBracket.Name = "cmdDoubleBracket"
        Me.cmdDoubleBracket.Size = New System.Drawing.Size(44, 48)
        Me.cmdDoubleBracket.TabIndex = 4
        Me.cmdDoubleBracket.Text = "( )"
        Me.cmdDoubleBracket.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClear.Location = New System.Drawing.Point(100, 111)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(90, 45)
        Me.cmdClear.TabIndex = 10
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdZero
        '
        Me.cmdZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.cmdZero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdZero.Location = New System.Drawing.Point(56, 111)
        Me.cmdZero.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdZero.Name = "cmdZero"
        Me.cmdZero.Size = New System.Drawing.Size(44, 45)
        Me.cmdZero.TabIndex = 9
        Me.cmdZero.Text = "l()"
        Me.cmdZero.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        Me.cmdMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdMinus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMinus.Location = New System.Drawing.Point(10, 111)
        Me.cmdMinus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.Size = New System.Drawing.Size(44, 45)
        Me.cmdMinus.TabIndex = 8
        Me.cmdMinus.Text = "-"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'ucrReceiverExpressionModellingGeneral
        '
        Me.ucrReceiverExpressionModellingGeneral.AutoSize = True
        Me.ucrReceiverExpressionModellingGeneral.frmParent = Me
        Me.ucrReceiverExpressionModellingGeneral.Location = New System.Drawing.Point(390, 306)
        Me.ucrReceiverExpressionModellingGeneral.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrReceiverExpressionModellingGeneral.Name = "ucrReceiverExpressionModellingGeneral"
        Me.ucrReceiverExpressionModellingGeneral.Selector = Nothing
        Me.ucrReceiverExpressionModellingGeneral.Size = New System.Drawing.Size(384, 45)
        Me.ucrReceiverExpressionModellingGeneral.strNcFilePath = ""
        Me.ucrReceiverExpressionModellingGeneral.TabIndex = 5
        Me.ucrReceiverExpressionModellingGeneral.ucrSelector = Nothing
        '
        'lblCheckVareity
        '
        Me.lblCheckVareity.AutoSize = True
        Me.lblCheckVareity.Location = New System.Drawing.Point(11, 603)
        Me.lblCheckVareity.Name = "lblCheckVareity"
        Me.lblCheckVareity.Size = New System.Drawing.Size(58, 20)
        Me.lblCheckVareity.TabIndex = 56
        Me.lblCheckVareity.Text = "Check:"
        '
        'dlgTricotModellingGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(797, 797)
        Me.Controls.Add(Me.lblCheckVareity)
        Me.Controls.Add(Me.ucrReceiverExpressionModellingGeneral)
        Me.Controls.Add(Me.grpSecondCalc)
        Me.Controls.Add(Me.grpFirstCalc)
        Me.Controls.Add(Me.ucrInputCheckVariety)
        Me.Controls.Add(Me.btnDisplayOptions)
        Me.Controls.Add(Me.btnModelOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSaveModellingGeneral)
        Me.Controls.Add(Me.lblExplanatory)
        Me.Controls.Add(Me.lblTraitsToModel)
        Me.Controls.Add(Me.ucrTraitsReceiver)
        Me.Controls.Add(Me.ucrSelectorVarietyLevel)
        Me.Controls.Add(Me.ucrSelectorTraitsRanking)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTricotModellingGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modelling (General)"
        Me.grpSecondCalc.ResumeLayout(False)
        Me.grpFirstCalc.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrInputCheckVariety As ucrInputTextBox
    Friend WithEvents btnDisplayOptions As Button
    Friend WithEvents btnModelOptions As Button
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSaveModellingGeneral As ucrSave
    Friend WithEvents lblExplanatory As Label
    Friend WithEvents lblTraitsToModel As Label
    Friend WithEvents ucrTraitsReceiver As ucrReceiverMultiple
    Friend WithEvents ucrSelectorVarietyLevel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectorTraitsRanking As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpSecondCalc As GroupBox
    Friend WithEvents cmdCos As Button
    Friend WithEvents cmdSqrt As Button
    Friend WithEvents cmdSin As Button
    Friend WithEvents cmdLog As Button
    Friend WithEvents cmdTan As Button
    Friend WithEvents cmdExp As Button
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
    Friend WithEvents cmdZero As Button
    Friend WithEvents cmdMinus As Button
    Friend WithEvents ucrReceiverExpressionModellingGeneral As ucrReceiverExpression
    Friend WithEvents lblCheckVareity As Label
End Class