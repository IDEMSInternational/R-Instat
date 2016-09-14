<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFitModel
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorByDataFrameAddRemoveForFitModel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblResponseVariable = New System.Windows.Forms.Label()
        Me.ucrReceiverResponseVar = New instat.ucrReceiverSingle()
        Me.cmdModelOptions = New System.Windows.Forms.Button()
        Me.ucrDistributionForFitModel = New instat.ucrDistributions()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.ucrInputModelPreview = New instat.ucrInputTextBox()
        Me.ucrSaveModel = New instat.ucrSaveModel()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.lblExplanatoryModel = New System.Windows.Forms.Label()
        Me.ucrReceiverExpressionFitModel = New instat.ucrReceiverExpression()
        Me.cmdDiv = New System.Windows.Forms.Button()
        Me.grpFirstCalc = New System.Windows.Forms.GroupBox()
        Me.cmdMultiply = New System.Windows.Forms.Button()
        Me.cmdColon = New System.Windows.Forms.Button()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.cmdPower = New System.Windows.Forms.Button()
        Me.cmdClosingBracket = New System.Windows.Forms.Button()
        Me.cmdOpeningBracket = New System.Windows.Forms.Button()
        Me.cmdDoubleBracket = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdZero = New System.Windows.Forms.Button()
        Me.cmdMinus = New System.Windows.Forms.Button()
        Me.grpSecondCalc = New System.Windows.Forms.GroupBox()
        Me.cmdCos = New System.Windows.Forms.Button()
        Me.cmdSqrt = New System.Windows.Forms.Button()
        Me.cmdSin = New System.Windows.Forms.Button()
        Me.cmdLog = New System.Windows.Forms.Button()
        Me.cmdTan = New System.Windows.Forms.Button()
        Me.cmdExp = New System.Windows.Forms.Button()
        Me.grpFirstCalc.SuspendLayout()
        Me.grpSecondCalc.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 319)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorByDataFrameAddRemoveForFitModel
        '
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.bShowHiddenColumns = False
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.bUseCurrentFilter = False
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.Name = "ucrSelectorByDataFrameAddRemoveForFitModel"
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.TabIndex = 1
        '
        'lblResponseVariable
        '
        Me.lblResponseVariable.AutoSize = True
        Me.lblResponseVariable.Location = New System.Drawing.Point(240, 26)
        Me.lblResponseVariable.Name = "lblResponseVariable"
        Me.lblResponseVariable.Size = New System.Drawing.Size(96, 13)
        Me.lblResponseVariable.TabIndex = 2
        Me.lblResponseVariable.Text = "Response Variable"
        '
        'ucrReceiverResponseVar
        '
        Me.ucrReceiverResponseVar.Location = New System.Drawing.Point(243, 43)
        Me.ucrReceiverResponseVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverResponseVar.Name = "ucrReceiverResponseVar"
        Me.ucrReceiverResponseVar.Selector = Nothing
        Me.ucrReceiverResponseVar.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverResponseVar.TabIndex = 3
        '
        'cmdModelOptions
        '
        Me.cmdModelOptions.Location = New System.Drawing.Point(296, 231)
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.Size = New System.Drawing.Size(105, 23)
        Me.cmdModelOptions.TabIndex = 4
        Me.cmdModelOptions.Text = "Model options"
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'ucrDistributionForFitModel
        '
        Me.ucrDistributionForFitModel.Location = New System.Drawing.Point(12, 222)
        Me.ucrDistributionForFitModel.Name = "ucrDistributionForFitModel"
        Me.ucrDistributionForFitModel.Size = New System.Drawing.Size(207, 43)
        Me.ucrDistributionForFitModel.TabIndex = 5
        '
        'lblModelPreview
        '
        Me.lblModelPreview.AutoSize = True
        Me.lblModelPreview.Location = New System.Drawing.Point(9, 272)
        Me.lblModelPreview.Name = "lblModelPreview"
        Me.lblModelPreview.Size = New System.Drawing.Size(79, 13)
        Me.lblModelPreview.TabIndex = 6
        Me.lblModelPreview.Text = "Model preview:"
        '
        'ucrInputModelPreview
        '
        Me.ucrInputModelPreview.IsReadOnly = False
        Me.ucrInputModelPreview.Location = New System.Drawing.Point(94, 266)
        Me.ucrInputModelPreview.Name = "ucrInputModelPreview"
        Me.ucrInputModelPreview.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputModelPreview.TabIndex = 7
        '
        'ucrSaveModel
        '
        Me.ucrSaveModel.Location = New System.Drawing.Point(9, 293)
        Me.ucrSaveModel.Name = "ucrSaveModel"
        Me.ucrSaveModel.Size = New System.Drawing.Size(265, 20)
        Me.ucrSaveModel.TabIndex = 8
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(296, 290)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(105, 23)
        Me.cmdDisplayOptions.TabIndex = 9
        Me.cmdDisplayOptions.Text = "Display options"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'lblExplanatoryModel
        '
        Me.lblExplanatoryModel.AutoSize = True
        Me.lblExplanatoryModel.Location = New System.Drawing.Point(240, 72)
        Me.lblExplanatoryModel.Name = "lblExplanatoryModel"
        Me.lblExplanatoryModel.Size = New System.Drawing.Size(94, 13)
        Me.lblExplanatoryModel.TabIndex = 10
        Me.lblExplanatoryModel.Text = "Explanatory Model"
        '
        'ucrReceiverExpressionFitModel
        '
        Me.ucrReceiverExpressionFitModel.Location = New System.Drawing.Point(243, 88)
        Me.ucrReceiverExpressionFitModel.Name = "ucrReceiverExpressionFitModel"
        Me.ucrReceiverExpressionFitModel.Selector = Nothing
        Me.ucrReceiverExpressionFitModel.Size = New System.Drawing.Size(256, 20)
        Me.ucrReceiverExpressionFitModel.TabIndex = 11
        '
        'cmdDiv
        '
        Me.cmdDiv.Location = New System.Drawing.Point(97, 11)
        Me.cmdDiv.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDiv.Name = "cmdDiv"
        Me.cmdDiv.Size = New System.Drawing.Size(29, 30)
        Me.cmdDiv.TabIndex = 156
        Me.cmdDiv.Text = "/"
        Me.cmdDiv.UseVisualStyleBackColor = True
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
        Me.grpFirstCalc.Location = New System.Drawing.Point(242, 115)
        Me.grpFirstCalc.Name = "grpFirstCalc"
        Me.grpFirstCalc.Size = New System.Drawing.Size(131, 110)
        Me.grpFirstCalc.TabIndex = 161
        Me.grpFirstCalc.TabStop = False
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Location = New System.Drawing.Point(67, 11)
        Me.cmdMultiply.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(29, 30)
        Me.cmdMultiply.TabIndex = 167
        Me.cmdMultiply.Text = "*"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdColon
        '
        Me.cmdColon.Location = New System.Drawing.Point(37, 11)
        Me.cmdColon.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdColon.Name = "cmdColon"
        Me.cmdColon.Size = New System.Drawing.Size(29, 30)
        Me.cmdColon.TabIndex = 166
        Me.cmdColon.Text = ":"
        Me.cmdColon.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Location = New System.Drawing.Point(7, 11)
        Me.cmdPlus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(29, 30)
        Me.cmdPlus.TabIndex = 165
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        Me.cmdPower.Location = New System.Drawing.Point(97, 42)
        Me.cmdPower.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.Size = New System.Drawing.Size(29, 32)
        Me.cmdPower.TabIndex = 164
        Me.cmdPower.Text = "^"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdClosingBracket
        '
        Me.cmdClosingBracket.Location = New System.Drawing.Point(67, 42)
        Me.cmdClosingBracket.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClosingBracket.Name = "cmdClosingBracket"
        Me.cmdClosingBracket.Size = New System.Drawing.Size(29, 32)
        Me.cmdClosingBracket.TabIndex = 164
        Me.cmdClosingBracket.Text = ")"
        Me.cmdClosingBracket.UseVisualStyleBackColor = True
        '
        'cmdOpeningBracket
        '
        Me.cmdOpeningBracket.Location = New System.Drawing.Point(37, 42)
        Me.cmdOpeningBracket.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdOpeningBracket.Name = "cmdOpeningBracket"
        Me.cmdOpeningBracket.Size = New System.Drawing.Size(29, 32)
        Me.cmdOpeningBracket.TabIndex = 163
        Me.cmdOpeningBracket.Text = "("
        Me.cmdOpeningBracket.UseVisualStyleBackColor = True
        '
        'cmdDoubleBracket
        '
        Me.cmdDoubleBracket.Location = New System.Drawing.Point(7, 42)
        Me.cmdDoubleBracket.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDoubleBracket.Name = "cmdDoubleBracket"
        Me.cmdDoubleBracket.Size = New System.Drawing.Size(29, 32)
        Me.cmdDoubleBracket.TabIndex = 162
        Me.cmdDoubleBracket.Text = "( )"
        Me.cmdDoubleBracket.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(67, 75)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(60, 30)
        Me.cmdClear.TabIndex = 161
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdZero
        '
        Me.cmdZero.Location = New System.Drawing.Point(37, 75)
        Me.cmdZero.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdZero.Name = "cmdZero"
        Me.cmdZero.Size = New System.Drawing.Size(29, 30)
        Me.cmdZero.TabIndex = 160
        Me.cmdZero.Text = "0"
        Me.cmdZero.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        Me.cmdMinus.Location = New System.Drawing.Point(7, 75)
        Me.cmdMinus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.Size = New System.Drawing.Size(29, 30)
        Me.cmdMinus.TabIndex = 159
        Me.cmdMinus.Text = "-"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'grpSecondCalc
        '
        Me.grpSecondCalc.Controls.Add(Me.cmdCos)
        Me.grpSecondCalc.Controls.Add(Me.cmdSqrt)
        Me.grpSecondCalc.Controls.Add(Me.cmdSin)
        Me.grpSecondCalc.Controls.Add(Me.cmdLog)
        Me.grpSecondCalc.Controls.Add(Me.cmdTan)
        Me.grpSecondCalc.Controls.Add(Me.cmdExp)
        Me.grpSecondCalc.Location = New System.Drawing.Point(373, 115)
        Me.grpSecondCalc.Name = "grpSecondCalc"
        Me.grpSecondCalc.Size = New System.Drawing.Size(126, 109)
        Me.grpSecondCalc.TabIndex = 162
        Me.grpSecondCalc.TabStop = False
        '
        'cmdCos
        '
        Me.cmdCos.Location = New System.Drawing.Point(62, 10)
        Me.cmdCos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCos.Name = "cmdCos"
        Me.cmdCos.Size = New System.Drawing.Size(56, 30)
        Me.cmdCos.TabIndex = 164
        Me.cmdCos.Text = "cos"
        Me.cmdCos.UseVisualStyleBackColor = True
        '
        'cmdSqrt
        '
        Me.cmdSqrt.Location = New System.Drawing.Point(5, 10)
        Me.cmdSqrt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSqrt.Name = "cmdSqrt"
        Me.cmdSqrt.Size = New System.Drawing.Size(56, 30)
        Me.cmdSqrt.TabIndex = 163
        Me.cmdSqrt.Text = "sqrt"
        Me.cmdSqrt.UseVisualStyleBackColor = True
        '
        'cmdSin
        '
        Me.cmdSin.Location = New System.Drawing.Point(62, 41)
        Me.cmdSin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSin.Name = "cmdSin"
        Me.cmdSin.Size = New System.Drawing.Size(56, 30)
        Me.cmdSin.TabIndex = 162
        Me.cmdSin.Text = "sin"
        Me.cmdSin.UseVisualStyleBackColor = True
        '
        'cmdLog
        '
        Me.cmdLog.Location = New System.Drawing.Point(5, 41)
        Me.cmdLog.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLog.Name = "cmdLog"
        Me.cmdLog.Size = New System.Drawing.Size(56, 30)
        Me.cmdLog.TabIndex = 161
        Me.cmdLog.Text = "log"
        Me.cmdLog.UseVisualStyleBackColor = True
        '
        'cmdTan
        '
        Me.cmdTan.Location = New System.Drawing.Point(62, 72)
        Me.cmdTan.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTan.Name = "cmdTan"
        Me.cmdTan.Size = New System.Drawing.Size(56, 30)
        Me.cmdTan.TabIndex = 160
        Me.cmdTan.Text = "tan"
        Me.cmdTan.UseVisualStyleBackColor = True
        '
        'cmdExp
        '
        Me.cmdExp.Location = New System.Drawing.Point(5, 72)
        Me.cmdExp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdExp.Name = "cmdExp"
        Me.cmdExp.Size = New System.Drawing.Size(56, 30)
        Me.cmdExp.TabIndex = 159
        Me.cmdExp.Text = "exp"
        Me.cmdExp.UseVisualStyleBackColor = True
        '
        'dlgFitModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 371)
        Me.Controls.Add(Me.grpSecondCalc)
        Me.Controls.Add(Me.grpFirstCalc)
        Me.Controls.Add(Me.ucrReceiverExpressionFitModel)
        Me.Controls.Add(Me.lblExplanatoryModel)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrSaveModel)
        Me.Controls.Add(Me.ucrInputModelPreview)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.ucrDistributionForFitModel)
        Me.Controls.Add(Me.cmdModelOptions)
        Me.Controls.Add(Me.ucrReceiverResponseVar)
        Me.Controls.Add(Me.lblResponseVariable)
        Me.Controls.Add(Me.ucrSelectorByDataFrameAddRemoveForFitModel)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFitModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Fit_Model"
        Me.Text = "Fit Model"
        Me.grpFirstCalc.ResumeLayout(False)
        Me.grpSecondCalc.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorByDataFrameAddRemoveForFitModel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblResponseVariable As Label
    Friend WithEvents ucrReceiverResponseVar As ucrReceiverSingle
    Friend WithEvents cmdModelOptions As Button
    Friend WithEvents ucrDistributionForFitModel As ucrDistributions
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents ucrInputModelPreview As ucrInputTextBox
    Friend WithEvents ucrSaveModel As ucrSaveModel
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents lblExplanatoryModel As Label
    Friend WithEvents ucrReceiverExpressionFitModel As ucrReceiverExpression
    Friend WithEvents cmdDiv As Button
    Friend WithEvents grpFirstCalc As GroupBox
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmdColon As Button
    Friend WithEvents cmdPlus As Button
    Friend WithEvents cmdClosingBracket As Button
    Friend WithEvents cmdOpeningBracket As Button
    Friend WithEvents cmdDoubleBracket As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdZero As Button
    Friend WithEvents cmdMinus As Button
    Friend WithEvents grpSecondCalc As GroupBox
    Friend WithEvents cmdCos As Button
    Friend WithEvents cmdSqrt As Button
    Friend WithEvents cmdSin As Button
    Friend WithEvents cmdLog As Button
    Friend WithEvents cmdTan As Button
    Friend WithEvents cmdExp As Button
    Friend WithEvents cmdPower As Button
End Class
