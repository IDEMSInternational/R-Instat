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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgFitModel))
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
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorByDataFrameAddRemoveForFitModel
        '
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.bShowHiddenColumns = False
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrSelectorByDataFrameAddRemoveForFitModel, "ucrSelectorByDataFrameAddRemoveForFitModel")
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.Name = "ucrSelectorByDataFrameAddRemoveForFitModel"
        '
        'lblResponseVariable
        '
        resources.ApplyResources(Me.lblResponseVariable, "lblResponseVariable")
        Me.lblResponseVariable.Name = "lblResponseVariable"
        '
        'ucrReceiverResponseVar
        '
        resources.ApplyResources(Me.ucrReceiverResponseVar, "ucrReceiverResponseVar")
        Me.ucrReceiverResponseVar.Name = "ucrReceiverResponseVar"
        Me.ucrReceiverResponseVar.Selector = Nothing
        '
        'cmdModelOptions
        '
        resources.ApplyResources(Me.cmdModelOptions, "cmdModelOptions")
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'ucrDistributionForFitModel
        '
        resources.ApplyResources(Me.ucrDistributionForFitModel, "ucrDistributionForFitModel")
        Me.ucrDistributionForFitModel.Name = "ucrDistributionForFitModel"
        '
        'lblModelPreview
        '
        resources.ApplyResources(Me.lblModelPreview, "lblModelPreview")
        Me.lblModelPreview.Name = "lblModelPreview"
        '
        'ucrInputModelPreview
        '
        Me.ucrInputModelPreview.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputModelPreview, "ucrInputModelPreview")
        Me.ucrInputModelPreview.Name = "ucrInputModelPreview"
        '
        'ucrSaveModel
        '
        resources.ApplyResources(Me.ucrSaveModel, "ucrSaveModel")
        Me.ucrSaveModel.Name = "ucrSaveModel"
        '
        'cmdDisplayOptions
        '
        resources.ApplyResources(Me.cmdDisplayOptions, "cmdDisplayOptions")
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'lblExplanatoryModel
        '
        resources.ApplyResources(Me.lblExplanatoryModel, "lblExplanatoryModel")
        Me.lblExplanatoryModel.Name = "lblExplanatoryModel"
        '
        'ucrReceiverExpressionFitModel
        '
        resources.ApplyResources(Me.ucrReceiverExpressionFitModel, "ucrReceiverExpressionFitModel")
        Me.ucrReceiverExpressionFitModel.Name = "ucrReceiverExpressionFitModel"
        Me.ucrReceiverExpressionFitModel.Selector = Nothing
        '
        'cmdDiv
        '
        resources.ApplyResources(Me.cmdDiv, "cmdDiv")
        Me.cmdDiv.Name = "cmdDiv"
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
        resources.ApplyResources(Me.grpFirstCalc, "grpFirstCalc")
        Me.grpFirstCalc.Name = "grpFirstCalc"
        Me.grpFirstCalc.TabStop = False
        '
        'cmdMultiply
        '
        resources.ApplyResources(Me.cmdMultiply, "cmdMultiply")
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdColon
        '
        resources.ApplyResources(Me.cmdColon, "cmdColon")
        Me.cmdColon.Name = "cmdColon"
        Me.cmdColon.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        resources.ApplyResources(Me.cmdPlus, "cmdPlus")
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        resources.ApplyResources(Me.cmdPower, "cmdPower")
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdClosingBracket
        '
        resources.ApplyResources(Me.cmdClosingBracket, "cmdClosingBracket")
        Me.cmdClosingBracket.Name = "cmdClosingBracket"
        Me.cmdClosingBracket.UseVisualStyleBackColor = True
        '
        'cmdOpeningBracket
        '
        resources.ApplyResources(Me.cmdOpeningBracket, "cmdOpeningBracket")
        Me.cmdOpeningBracket.Name = "cmdOpeningBracket"
        Me.cmdOpeningBracket.UseVisualStyleBackColor = True
        '
        'cmdDoubleBracket
        '
        resources.ApplyResources(Me.cmdDoubleBracket, "cmdDoubleBracket")
        Me.cmdDoubleBracket.Name = "cmdDoubleBracket"
        Me.cmdDoubleBracket.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        resources.ApplyResources(Me.cmdClear, "cmdClear")
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdZero
        '
        resources.ApplyResources(Me.cmdZero, "cmdZero")
        Me.cmdZero.Name = "cmdZero"
        Me.cmdZero.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        resources.ApplyResources(Me.cmdMinus, "cmdMinus")
        Me.cmdMinus.Name = "cmdMinus"
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
        resources.ApplyResources(Me.grpSecondCalc, "grpSecondCalc")
        Me.grpSecondCalc.Name = "grpSecondCalc"
        Me.grpSecondCalc.TabStop = False
        '
        'cmdCos
        '
        resources.ApplyResources(Me.cmdCos, "cmdCos")
        Me.cmdCos.Name = "cmdCos"
        Me.cmdCos.UseVisualStyleBackColor = True
        '
        'cmdSqrt
        '
        resources.ApplyResources(Me.cmdSqrt, "cmdSqrt")
        Me.cmdSqrt.Name = "cmdSqrt"
        Me.cmdSqrt.UseVisualStyleBackColor = True
        '
        'cmdSin
        '
        resources.ApplyResources(Me.cmdSin, "cmdSin")
        Me.cmdSin.Name = "cmdSin"
        Me.cmdSin.UseVisualStyleBackColor = True
        '
        'cmdLog
        '
        resources.ApplyResources(Me.cmdLog, "cmdLog")
        Me.cmdLog.Name = "cmdLog"
        Me.cmdLog.UseVisualStyleBackColor = True
        '
        'cmdTan
        '
        resources.ApplyResources(Me.cmdTan, "cmdTan")
        Me.cmdTan.Name = "cmdTan"
        Me.cmdTan.UseVisualStyleBackColor = True
        '
        'cmdExp
        '
        resources.ApplyResources(Me.cmdExp, "cmdExp")
        Me.cmdExp.Name = "cmdExp"
        Me.cmdExp.UseVisualStyleBackColor = True
        '
        'dlgFitModel
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Tag = "Fit_Model"
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
