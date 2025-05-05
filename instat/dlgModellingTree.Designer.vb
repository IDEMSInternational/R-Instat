<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgModellingTree
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
        Me.lblReceiverModellingTree = New System.Windows.Forms.Label()
        Me.ucrReceiverModellingTree = New instat.ucrReceiverMultiple()
        Me.ucrModelName = New instat.ucrSave()
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
        Me.ucrReceiverExpressionModellingTree = New instat.ucrReceiverExpression()
        Me.lblExplanatoryModel = New System.Windows.Forms.Label()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.ucrInputModelPreview = New instat.ucrInputTextBox()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.cmdModelOptions = New System.Windows.Forms.Button()
        Me.ucrSelectorByDataFrameAddRemoveForModellingTree = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.UcrSelectorByDataFrameForModellingTreeSecond = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputCheck = New instat.ucrInputTextBox()
        Me.lblCheckVareity = New System.Windows.Forms.Label()
        Me.grpSecondCalc.SuspendLayout()
        Me.grpFirstCalc.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblReceiverModellingTree
        '
        Me.lblReceiverModellingTree.AutoSize = True
        Me.lblReceiverModellingTree.Location = New System.Drawing.Point(376, 72)
        Me.lblReceiverModellingTree.Name = "lblReceiverModellingTree"
        Me.lblReceiverModellingTree.Size = New System.Drawing.Size(117, 20)
        Me.lblReceiverModellingTree.TabIndex = 1
        Me.lblReceiverModellingTree.Text = "Traits to Model:"
        '
        'ucrReceiverModellingTree
        '
        Me.ucrReceiverModellingTree.AutoSize = True
        Me.ucrReceiverModellingTree.frmParent = Me
        Me.ucrReceiverModellingTree.Location = New System.Drawing.Point(376, 95)
        Me.ucrReceiverModellingTree.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverModellingTree.Name = "ucrReceiverModellingTree"
        Me.ucrReceiverModellingTree.Selector = Nothing
        Me.ucrReceiverModellingTree.Size = New System.Drawing.Size(236, 152)
        Me.ucrReceiverModellingTree.strNcFilePath = ""
        Me.ucrReceiverModellingTree.TabIndex = 2
        Me.ucrReceiverModellingTree.ucrSelector = Nothing
        '
        'ucrModelName
        '
        Me.ucrModelName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrModelName.Location = New System.Drawing.Point(16, 706)
        Me.ucrModelName.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrModelName.Name = "ucrModelName"
        Me.ucrModelName.Size = New System.Drawing.Size(453, 36)
        Me.ucrModelName.TabIndex = 12
        '
        'grpSecondCalc
        '
        Me.grpSecondCalc.Controls.Add(Me.cmdCos)
        Me.grpSecondCalc.Controls.Add(Me.cmdSqrt)
        Me.grpSecondCalc.Controls.Add(Me.cmdSin)
        Me.grpSecondCalc.Controls.Add(Me.cmdLog)
        Me.grpSecondCalc.Controls.Add(Me.cmdTan)
        Me.grpSecondCalc.Controls.Add(Me.cmdExp)
        Me.grpSecondCalc.Location = New System.Drawing.Point(572, 434)
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
        Me.grpFirstCalc.Location = New System.Drawing.Point(376, 434)
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
        'ucrReceiverExpressionModellingTree
        '
        Me.ucrReceiverExpressionModellingTree.AutoSize = True
        Me.ucrReceiverExpressionModellingTree.frmParent = Me
        Me.ucrReceiverExpressionModellingTree.Location = New System.Drawing.Point(376, 391)
        Me.ucrReceiverExpressionModellingTree.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrReceiverExpressionModellingTree.Name = "ucrReceiverExpressionModellingTree"
        Me.ucrReceiverExpressionModellingTree.Selector = Nothing
        Me.ucrReceiverExpressionModellingTree.Size = New System.Drawing.Size(384, 45)
        Me.ucrReceiverExpressionModellingTree.strNcFilePath = ""
        Me.ucrReceiverExpressionModellingTree.TabIndex = 5
        Me.ucrReceiverExpressionModellingTree.ucrSelector = Nothing
        '
        'lblExplanatoryModel
        '
        Me.lblExplanatoryModel.AutoSize = True
        Me.lblExplanatoryModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExplanatoryModel.Location = New System.Drawing.Point(377, 367)
        Me.lblExplanatoryModel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExplanatoryModel.Name = "lblExplanatoryModel"
        Me.lblExplanatoryModel.Size = New System.Drawing.Size(143, 20)
        Me.lblExplanatoryModel.TabIndex = 4
        Me.lblExplanatoryModel.Text = "Explanatory Model:"
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(566, 654)
        Me.cmdDisplayOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(186, 34)
        Me.cmdDisplayOptions.TabIndex = 14
        Me.cmdDisplayOptions.Text = "Display Options"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'ucrInputModelPreview
        '
        Me.ucrInputModelPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputModelPreview.AutoSize = True
        Me.ucrInputModelPreview.IsMultiline = False
        Me.ucrInputModelPreview.IsReadOnly = False
        Me.ucrInputModelPreview.Location = New System.Drawing.Point(156, 656)
        Me.ucrInputModelPreview.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputModelPreview.Name = "ucrInputModelPreview"
        Me.ucrInputModelPreview.Size = New System.Drawing.Size(392, 32)
        Me.ucrInputModelPreview.TabIndex = 11
        '
        'lblModelPreview
        '
        Me.lblModelPreview.AutoSize = True
        Me.lblModelPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblModelPreview.Location = New System.Drawing.Point(18, 660)
        Me.lblModelPreview.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModelPreview.Name = "lblModelPreview"
        Me.lblModelPreview.Size = New System.Drawing.Size(114, 20)
        Me.lblModelPreview.TabIndex = 10
        Me.lblModelPreview.Text = "Model Preview:"
        '
        'cmdModelOptions
        '
        Me.cmdModelOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdModelOptions.Location = New System.Drawing.Point(566, 612)
        Me.cmdModelOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.Size = New System.Drawing.Size(186, 34)
        Me.cmdModelOptions.TabIndex = 13
        Me.cmdModelOptions.Text = "Model Options"
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'ucrSelectorByDataFrameAddRemoveForModellingTree
        '
        Me.ucrSelectorByDataFrameAddRemoveForModellingTree.AutoSize = True
        Me.ucrSelectorByDataFrameAddRemoveForModellingTree.bDropUnusedFilterLevels = False
        Me.ucrSelectorByDataFrameAddRemoveForModellingTree.bShowHiddenColumns = False
        Me.ucrSelectorByDataFrameAddRemoveForModellingTree.bUseCurrentFilter = True
        Me.ucrSelectorByDataFrameAddRemoveForModellingTree.Location = New System.Drawing.Point(16, 20)
        Me.ucrSelectorByDataFrameAddRemoveForModellingTree.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByDataFrameAddRemoveForModellingTree.Name = "ucrSelectorByDataFrameAddRemoveForModellingTree"
        Me.ucrSelectorByDataFrameAddRemoveForModellingTree.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorByDataFrameAddRemoveForModellingTree.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(16, 759)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 15
        '
        'UcrSelectorByDataFrameForModellingTreeSecond
        '
        Me.UcrSelectorByDataFrameForModellingTreeSecond.AutoSize = True
        Me.UcrSelectorByDataFrameForModellingTreeSecond.bDropUnusedFilterLevels = False
        Me.UcrSelectorByDataFrameForModellingTreeSecond.bShowHiddenColumns = False
        Me.UcrSelectorByDataFrameForModellingTreeSecond.bUseCurrentFilter = True
        Me.UcrSelectorByDataFrameForModellingTreeSecond.Location = New System.Drawing.Point(16, 326)
        Me.UcrSelectorByDataFrameForModellingTreeSecond.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrSelectorByDataFrameForModellingTreeSecond.Name = "UcrSelectorByDataFrameForModellingTreeSecond"
        Me.UcrSelectorByDataFrameForModellingTreeSecond.Size = New System.Drawing.Size(320, 274)
        Me.UcrSelectorByDataFrameForModellingTreeSecond.TabIndex = 3
        '
        'ucrInputCheck
        '
        Me.ucrInputCheck.AddQuotesIfUnrecognised = True
        Me.ucrInputCheck.AutoSize = True
        Me.ucrInputCheck.IsMultiline = False
        Me.ucrInputCheck.IsReadOnly = False
        Me.ucrInputCheck.Location = New System.Drawing.Point(83, 616)
        Me.ucrInputCheck.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputCheck.Name = "ucrInputCheck"
        Me.ucrInputCheck.Size = New System.Drawing.Size(465, 30)
        Me.ucrInputCheck.TabIndex = 9
        '
        'lblCheckVareity
        '
        Me.lblCheckVareity.AutoSize = True
        Me.lblCheckVareity.Location = New System.Drawing.Point(18, 618)
        Me.lblCheckVareity.Name = "lblCheckVareity"
        Me.lblCheckVareity.Size = New System.Drawing.Size(58, 20)
        Me.lblCheckVareity.TabIndex = 8
        Me.lblCheckVareity.Text = "Check:"
        '
        'dlgModellingTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(778, 850)
        Me.Controls.Add(Me.lblCheckVareity)
        Me.Controls.Add(Me.ucrInputCheck)
        Me.Controls.Add(Me.UcrSelectorByDataFrameForModellingTreeSecond)
        Me.Controls.Add(Me.lblReceiverModellingTree)
        Me.Controls.Add(Me.ucrReceiverModellingTree)
        Me.Controls.Add(Me.ucrModelName)
        Me.Controls.Add(Me.grpSecondCalc)
        Me.Controls.Add(Me.grpFirstCalc)
        Me.Controls.Add(Me.ucrReceiverExpressionModellingTree)
        Me.Controls.Add(Me.lblExplanatoryModel)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrInputModelPreview)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.cmdModelOptions)
        Me.Controls.Add(Me.ucrSelectorByDataFrameAddRemoveForModellingTree)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgModellingTree"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modelling Tree"
        Me.grpSecondCalc.ResumeLayout(False)
        Me.grpFirstCalc.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblReceiverModellingTree As Label
    Friend WithEvents ucrReceiverModellingTree As ucrReceiverMultiple
    Friend WithEvents UcrSelectorByDataFrameForModellingTreeSecond As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrModelName As ucrSave
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
    Friend WithEvents ucrReceiverExpressionModellingTree As ucrReceiverExpression
    Friend WithEvents lblExplanatoryModel As Label
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents ucrInputModelPreview As ucrInputTextBox
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents cmdModelOptions As Button
    Friend WithEvents ucrSelectorByDataFrameAddRemoveForModellingTree As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputCheck As ucrInputTextBox
    Friend WithEvents lblCheckVareity As Label
End Class
