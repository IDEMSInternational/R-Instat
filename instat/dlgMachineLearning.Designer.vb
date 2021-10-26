<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMachineLearning
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
        Me.lblExplanatoryModel = New System.Windows.Forms.Label()
        Me.lblResponseVariable = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoExplanatoryModel = New System.Windows.Forms.RadioButton()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.rdoExplanatoryVariable = New System.Windows.Forms.RadioButton()
        Me.ucrInputMethod = New instat.ucrInputComboBox()
        Me.ucrPnlExplanatoryVariable = New instat.UcrPanel()
        Me.ucrModelName = New instat.ucrSave()
        Me.ucrReceiverExpressionFitModel = New instat.ucrReceiverExpression()
        Me.ucrReceiverResponseVariable = New instat.ucrReceiverSingle()
        Me.ucrSelectorMachineLearning = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverMultipleExplanatoryVariable = New instat.ucrReceiverMultiple()
        Me.lblTrainSize = New System.Windows.Forms.Label()
        Me.ucrNudTrainSize = New instat.ucrNud()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblExplanatoryModel
        '
        Me.lblExplanatoryModel.AutoSize = True
        Me.lblExplanatoryModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExplanatoryModel.Location = New System.Drawing.Point(247, 147)
        Me.lblExplanatoryModel.Name = "lblExplanatoryModel"
        Me.lblExplanatoryModel.Size = New System.Drawing.Size(97, 13)
        Me.lblExplanatoryModel.TabIndex = 4
        Me.lblExplanatoryModel.Text = "Explanatory Model:"
        '
        'lblResponseVariable
        '
        Me.lblResponseVariable.AutoSize = True
        Me.lblResponseVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResponseVariable.Location = New System.Drawing.Point(246, 44)
        Me.lblResponseVariable.Name = "lblResponseVariable"
        Me.lblResponseVariable.Size = New System.Drawing.Size(99, 13)
        Me.lblResponseVariable.TabIndex = 1
        Me.lblResponseVariable.Text = "Response Variable:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoExplanatoryVariable)
        Me.GroupBox1.Controls.Add(Me.rdoExplanatoryModel)
        Me.GroupBox1.Controls.Add(Me.ucrPnlExplanatoryVariable)
        Me.GroupBox1.Location = New System.Drawing.Point(245, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(151, 47)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'rdoExplanatoryModel
        '
        Me.rdoExplanatoryModel.AutoSize = True
        Me.rdoExplanatoryModel.Location = New System.Drawing.Point(80, 19)
        Me.rdoExplanatoryModel.Name = "rdoExplanatoryModel"
        Me.rdoExplanatoryModel.Size = New System.Drawing.Size(54, 17)
        Me.rdoExplanatoryModel.TabIndex = 2
        Me.rdoExplanatoryModel.TabStop = True
        Me.rdoExplanatoryModel.Text = "Model"
        Me.rdoExplanatoryModel.UseVisualStyleBackColor = True
        '
        'lblMethod
        '
        Me.lblMethod.AutoSize = True
        Me.lblMethod.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMethod.Location = New System.Drawing.Point(10, 254)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(46, 13)
        Me.lblMethod.TabIndex = 7
        Me.lblMethod.Text = "Method:"
        '
        'rdoExplanatoryVariable
        '
        Me.rdoExplanatoryVariable.AutoSize = True
        Me.rdoExplanatoryVariable.Location = New System.Drawing.Point(13, 19)
        Me.rdoExplanatoryVariable.Name = "rdoExplanatoryVariable"
        Me.rdoExplanatoryVariable.Size = New System.Drawing.Size(63, 17)
        Me.rdoExplanatoryVariable.TabIndex = 1
        Me.rdoExplanatoryVariable.TabStop = True
        Me.rdoExplanatoryVariable.Text = "Variable"
        Me.rdoExplanatoryVariable.UseVisualStyleBackColor = True
        '
        'ucrInputMethod
        '
        Me.ucrInputMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputMethod.GetSetSelectedIndex = -1
        Me.ucrInputMethod.IsReadOnly = False
        Me.ucrInputMethod.Location = New System.Drawing.Point(62, 252)
        Me.ucrInputMethod.Name = "ucrInputMethod"
        Me.ucrInputMethod.Size = New System.Drawing.Size(94, 21)
        Me.ucrInputMethod.TabIndex = 8
        '
        'ucrPnlExplanatoryVariable
        '
        Me.ucrPnlExplanatoryVariable.Location = New System.Drawing.Point(4, 15)
        Me.ucrPnlExplanatoryVariable.Name = "ucrPnlExplanatoryVariable"
        Me.ucrPnlExplanatoryVariable.Size = New System.Drawing.Size(137, 26)
        Me.ucrPnlExplanatoryVariable.TabIndex = 0
        '
        'ucrModelName
        '
        Me.ucrModelName.Location = New System.Drawing.Point(8, 316)
        Me.ucrModelName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrModelName.Name = "ucrModelName"
        Me.ucrModelName.Size = New System.Drawing.Size(302, 24)
        Me.ucrModelName.TabIndex = 9
        '
        'ucrReceiverExpressionFitModel
        '
        Me.ucrReceiverExpressionFitModel.frmParent = Me
        Me.ucrReceiverExpressionFitModel.Location = New System.Drawing.Point(245, 162)
        Me.ucrReceiverExpressionFitModel.Name = "ucrReceiverExpressionFitModel"
        Me.ucrReceiverExpressionFitModel.Selector = Nothing
        Me.ucrReceiverExpressionFitModel.Size = New System.Drawing.Size(120, 21)
        Me.ucrReceiverExpressionFitModel.strNcFilePath = ""
        Me.ucrReceiverExpressionFitModel.TabIndex = 5
        Me.ucrReceiverExpressionFitModel.ucrSelector = Nothing
        '
        'ucrReceiverResponseVariable
        '
        Me.ucrReceiverResponseVariable.frmParent = Me
        Me.ucrReceiverResponseVariable.Location = New System.Drawing.Point(245, 59)
        Me.ucrReceiverResponseVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverResponseVariable.Name = "ucrReceiverResponseVariable"
        Me.ucrReceiverResponseVariable.Selector = Nothing
        Me.ucrReceiverResponseVariable.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverResponseVariable.strNcFilePath = ""
        Me.ucrReceiverResponseVariable.TabIndex = 2
        Me.ucrReceiverResponseVariable.ucrSelector = Nothing
        '
        'ucrSelectorMachineLearning
        '
        Me.ucrSelectorMachineLearning.bDropUnusedFilterLevels = False
        Me.ucrSelectorMachineLearning.bShowHiddenColumns = False
        Me.ucrSelectorMachineLearning.bUseCurrentFilter = True
        Me.ucrSelectorMachineLearning.Location = New System.Drawing.Point(8, 11)
        Me.ucrSelectorMachineLearning.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorMachineLearning.Name = "ucrSelectorMachineLearning"
        Me.ucrSelectorMachineLearning.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorMachineLearning.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(8, 344)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 10
        '
        'ucrReceiverMultipleExplanatoryVariable
        '
        Me.ucrReceiverMultipleExplanatoryVariable.frmParent = Me
        Me.ucrReceiverMultipleExplanatoryVariable.Location = New System.Drawing.Point(245, 162)
        Me.ucrReceiverMultipleExplanatoryVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleExplanatoryVariable.Name = "ucrReceiverMultipleExplanatoryVariable"
        Me.ucrReceiverMultipleExplanatoryVariable.Selector = Nothing
        Me.ucrReceiverMultipleExplanatoryVariable.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleExplanatoryVariable.strNcFilePath = ""
        Me.ucrReceiverMultipleExplanatoryVariable.TabIndex = 6
        Me.ucrReceiverMultipleExplanatoryVariable.ucrSelector = Nothing
        '
        'lblTrainSize
        '
        Me.lblTrainSize.AutoSize = True
        Me.lblTrainSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTrainSize.Location = New System.Drawing.Point(10, 227)
        Me.lblTrainSize.Name = "lblTrainSize"
        Me.lblTrainSize.Size = New System.Drawing.Size(57, 13)
        Me.lblTrainSize.TabIndex = 11
        Me.lblTrainSize.Text = "Train Size:"
        '
        'ucrNudTrainSize
        '
        Me.ucrNudTrainSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTrainSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTrainSize.Location = New System.Drawing.Point(73, 225)
        Me.ucrNudTrainSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTrainSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTrainSize.Name = "ucrNudTrainSize"
        Me.ucrNudTrainSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTrainSize.TabIndex = 12
        Me.ucrNudTrainSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgMachineLearning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 399)
        Me.Controls.Add(Me.ucrNudTrainSize)
        Me.Controls.Add(Me.lblTrainSize)
        Me.Controls.Add(Me.lblMethod)
        Me.Controls.Add(Me.ucrInputMethod)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ucrModelName)
        Me.Controls.Add(Me.ucrReceiverExpressionFitModel)
        Me.Controls.Add(Me.lblExplanatoryModel)
        Me.Controls.Add(Me.ucrReceiverResponseVariable)
        Me.Controls.Add(Me.lblResponseVariable)
        Me.Controls.Add(Me.ucrSelectorMachineLearning)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverMultipleExplanatoryVariable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMachineLearning"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Machine Learning (caret) "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrModelName As ucrSave
    Friend WithEvents ucrReceiverExpressionFitModel As ucrReceiverExpression
    Friend WithEvents lblExplanatoryModel As Label
    Friend WithEvents ucrReceiverResponseVariable As ucrReceiverSingle
    Friend WithEvents lblResponseVariable As Label
    Friend WithEvents ucrSelectorMachineLearning As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoExplanatoryModel As RadioButton
    Friend WithEvents ucrPnlExplanatoryVariable As UcrPanel
    Friend WithEvents ucrReceiverMultipleExplanatoryVariable As ucrReceiverMultiple
    Friend WithEvents lblMethod As Label
    Friend WithEvents ucrInputMethod As ucrInputComboBox
    Friend WithEvents rdoExplanatoryVariable As RadioButton
    Friend WithEvents ucrNudTrainSize As ucrNud
    Friend WithEvents lblTrainSize As Label
End Class
