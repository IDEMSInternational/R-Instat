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
        Me.rdoExplanatoryVariable = New System.Windows.Forms.RadioButton()
        Me.rdoExplanatoryModel = New System.Windows.Forms.RadioButton()
        Me.ucrPnlExplanatoryVariable = New instat.UcrPanel()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.lblTrainSize = New System.Windows.Forms.Label()
        Me.rdoClassification = New System.Windows.Forms.RadioButton()
        Me.rdoRegression = New System.Windows.Forms.RadioButton()
        Me.grpModelType = New System.Windows.Forms.GroupBox()
        Me.ucrPnlModelType = New instat.UcrPanel()
        Me.ucrNudTrainSize = New instat.ucrNud()
        Me.ucrInputClassificationMethod = New instat.ucrInputComboBox()
        Me.ucrModelName = New instat.ucrSave()
        Me.ucrReceiverClassificationResponseVariable = New instat.ucrReceiverSingle()
        Me.ucrSelectorMachineLearning = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverMultipleExplanatoryVariable = New instat.ucrReceiverMultiple()
        Me.ucrReceiverRegressionResponse = New instat.ucrReceiverSingle()
        Me.ucrInputRegressionMethod = New instat.ucrInputComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.grpModelType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblExplanatoryModel
        '
        Me.lblExplanatoryModel.AutoSize = True
        Me.lblExplanatoryModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExplanatoryModel.Location = New System.Drawing.Point(247, 147)
        Me.lblExplanatoryModel.Name = "lblExplanatoryModel"
        Me.lblExplanatoryModel.Size = New System.Drawing.Size(97, 13)
        Me.lblExplanatoryModel.TabIndex = 5
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
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Predictor"
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
        'rdoExplanatoryModel
        '
        Me.rdoExplanatoryModel.AutoSize = True
        Me.rdoExplanatoryModel.Enabled = False
        Me.rdoExplanatoryModel.Location = New System.Drawing.Point(80, 19)
        Me.rdoExplanatoryModel.Name = "rdoExplanatoryModel"
        Me.rdoExplanatoryModel.Size = New System.Drawing.Size(54, 17)
        Me.rdoExplanatoryModel.TabIndex = 2
        Me.rdoExplanatoryModel.TabStop = True
        Me.rdoExplanatoryModel.Text = "Model"
        Me.rdoExplanatoryModel.UseVisualStyleBackColor = True
        '
        'ucrPnlExplanatoryVariable
        '
        Me.ucrPnlExplanatoryVariable.Location = New System.Drawing.Point(4, 15)
        Me.ucrPnlExplanatoryVariable.Name = "ucrPnlExplanatoryVariable"
        Me.ucrPnlExplanatoryVariable.Size = New System.Drawing.Size(137, 26)
        Me.ucrPnlExplanatoryVariable.TabIndex = 0
        '
        'lblMethod
        '
        Me.lblMethod.AutoSize = True
        Me.lblMethod.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMethod.Location = New System.Drawing.Point(10, 285)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(46, 13)
        Me.lblMethod.TabIndex = 10
        Me.lblMethod.Text = "Method:"
        '
        'lblTrainSize
        '
        Me.lblTrainSize.AutoSize = True
        Me.lblTrainSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTrainSize.Location = New System.Drawing.Point(10, 258)
        Me.lblTrainSize.Name = "lblTrainSize"
        Me.lblTrainSize.Size = New System.Drawing.Size(57, 13)
        Me.lblTrainSize.TabIndex = 8
        Me.lblTrainSize.Text = "Train Size:"
        '
        'rdoClassification
        '
        Me.rdoClassification.AutoSize = True
        Me.rdoClassification.Location = New System.Drawing.Point(11, 19)
        Me.rdoClassification.Name = "rdoClassification"
        Me.rdoClassification.Size = New System.Drawing.Size(86, 17)
        Me.rdoClassification.TabIndex = 1
        Me.rdoClassification.TabStop = True
        Me.rdoClassification.Text = "Classification"
        Me.rdoClassification.UseVisualStyleBackColor = True
        '
        'rdoRegression
        '
        Me.rdoRegression.AutoSize = True
        Me.rdoRegression.Location = New System.Drawing.Point(105, 19)
        Me.rdoRegression.Name = "rdoRegression"
        Me.rdoRegression.Size = New System.Drawing.Size(78, 17)
        Me.rdoRegression.TabIndex = 2
        Me.rdoRegression.TabStop = True
        Me.rdoRegression.Text = "Regression"
        Me.rdoRegression.UseVisualStyleBackColor = True
        '
        'grpModelType
        '
        Me.grpModelType.Controls.Add(Me.rdoClassification)
        Me.grpModelType.Controls.Add(Me.rdoRegression)
        Me.grpModelType.Controls.Add(Me.ucrPnlModelType)
        Me.grpModelType.Location = New System.Drawing.Point(12, 199)
        Me.grpModelType.Name = "grpModelType"
        Me.grpModelType.Size = New System.Drawing.Size(206, 47)
        Me.grpModelType.TabIndex = 7
        Me.grpModelType.TabStop = False
        Me.grpModelType.Text = "Type"
        '
        'ucrPnlModelType
        '
        Me.ucrPnlModelType.Location = New System.Drawing.Point(4, 15)
        Me.ucrPnlModelType.Name = "ucrPnlModelType"
        Me.ucrPnlModelType.Size = New System.Drawing.Size(183, 26)
        Me.ucrPnlModelType.TabIndex = 0
        '
        'ucrNudTrainSize
        '
        Me.ucrNudTrainSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTrainSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTrainSize.Location = New System.Drawing.Point(73, 256)
        Me.ucrNudTrainSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTrainSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTrainSize.Name = "ucrNudTrainSize"
        Me.ucrNudTrainSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTrainSize.TabIndex = 9
        Me.ucrNudTrainSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputClassificationMethod
        '
        Me.ucrInputClassificationMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputClassificationMethod.GetSetSelectedIndex = -1
        Me.ucrInputClassificationMethod.IsReadOnly = False
        Me.ucrInputClassificationMethod.Location = New System.Drawing.Point(62, 283)
        Me.ucrInputClassificationMethod.Name = "ucrInputClassificationMethod"
        Me.ucrInputClassificationMethod.Size = New System.Drawing.Size(94, 21)
        Me.ucrInputClassificationMethod.TabIndex = 11
        '
        'ucrModelName
        '
        Me.ucrModelName.Location = New System.Drawing.Point(8, 316)
        Me.ucrModelName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrModelName.Name = "ucrModelName"
        Me.ucrModelName.Size = New System.Drawing.Size(302, 24)
        Me.ucrModelName.TabIndex = 12
        '
        'ucrReceiverClassificationResponseVariable
        '
        Me.ucrReceiverClassificationResponseVariable.frmParent = Me
        Me.ucrReceiverClassificationResponseVariable.Location = New System.Drawing.Point(245, 59)
        Me.ucrReceiverClassificationResponseVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverClassificationResponseVariable.Name = "ucrReceiverClassificationResponseVariable"
        Me.ucrReceiverClassificationResponseVariable.Selector = Nothing
        Me.ucrReceiverClassificationResponseVariable.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverClassificationResponseVariable.strNcFilePath = ""
        Me.ucrReceiverClassificationResponseVariable.TabIndex = 2
        Me.ucrReceiverClassificationResponseVariable.ucrSelector = Nothing
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
        Me.ucrBase.TabIndex = 13
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
        'ucrReceiverRegressionResponse
        '
        Me.ucrReceiverRegressionResponse.frmParent = Me
        Me.ucrReceiverRegressionResponse.Location = New System.Drawing.Point(245, 59)
        Me.ucrReceiverRegressionResponse.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRegressionResponse.Name = "ucrReceiverRegressionResponse"
        Me.ucrReceiverRegressionResponse.Selector = Nothing
        Me.ucrReceiverRegressionResponse.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRegressionResponse.strNcFilePath = ""
        Me.ucrReceiverRegressionResponse.TabIndex = 3
        Me.ucrReceiverRegressionResponse.ucrSelector = Nothing
        '
        'ucrInputRegressionMethod
        '
        Me.ucrInputRegressionMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputRegressionMethod.GetSetSelectedIndex = -1
        Me.ucrInputRegressionMethod.IsReadOnly = False
        Me.ucrInputRegressionMethod.Location = New System.Drawing.Point(62, 283)
        Me.ucrInputRegressionMethod.Name = "ucrInputRegressionMethod"
        Me.ucrInputRegressionMethod.Size = New System.Drawing.Size(94, 21)
        Me.ucrInputRegressionMethod.TabIndex = 14
        '
        'dlgMachineLearning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 399)
        Me.Controls.Add(Me.ucrInputRegressionMethod)
        Me.Controls.Add(Me.grpModelType)
        Me.Controls.Add(Me.ucrNudTrainSize)
        Me.Controls.Add(Me.lblTrainSize)
        Me.Controls.Add(Me.lblMethod)
        Me.Controls.Add(Me.ucrInputClassificationMethod)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ucrModelName)
        Me.Controls.Add(Me.lblExplanatoryModel)
        Me.Controls.Add(Me.ucrReceiverClassificationResponseVariable)
        Me.Controls.Add(Me.lblResponseVariable)
        Me.Controls.Add(Me.ucrSelectorMachineLearning)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverMultipleExplanatoryVariable)
        Me.Controls.Add(Me.ucrReceiverRegressionResponse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMachineLearning"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Machine Learning (caret) "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpModelType.ResumeLayout(False)
        Me.grpModelType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrModelName As ucrSave
    Friend WithEvents lblExplanatoryModel As Label
    Friend WithEvents ucrReceiverClassificationResponseVariable As ucrReceiverSingle
    Friend WithEvents lblResponseVariable As Label
    Friend WithEvents ucrSelectorMachineLearning As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoExplanatoryModel As RadioButton
    Friend WithEvents ucrPnlExplanatoryVariable As UcrPanel
    Friend WithEvents ucrReceiverMultipleExplanatoryVariable As ucrReceiverMultiple
    Friend WithEvents lblMethod As Label
    Friend WithEvents ucrInputClassificationMethod As ucrInputComboBox
    Friend WithEvents rdoExplanatoryVariable As RadioButton
    Friend WithEvents ucrNudTrainSize As ucrNud
    Friend WithEvents lblTrainSize As Label
    Friend WithEvents grpModelType As GroupBox
    Friend WithEvents rdoClassification As RadioButton
    Friend WithEvents rdoRegression As RadioButton
    Friend WithEvents ucrPnlModelType As UcrPanel
    Friend WithEvents ucrReceiverRegressionResponse As ucrReceiverSingle
    Friend WithEvents ucrInputRegressionMethod As ucrInputComboBox
End Class
