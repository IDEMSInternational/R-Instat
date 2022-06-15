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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorMachineLearning = New instat.ucrSelectorByDataFrame()
        Me.ucrReceiverClassificationResponseVariable = New instat.ucrReceiverSingle()
        Me.lblResponceVariable = New System.Windows.Forms.Label()
        Me.grpExplanatoryVariable = New System.Windows.Forms.GroupBox()
        Me.rdoExplanatoryVariable = New System.Windows.Forms.RadioButton()
        Me.rdoExplanatoryModel = New System.Windows.Forms.RadioButton()
        Me.ucrPnlExplanatoryVariable = New instat.UcrPanel()
        Me.ucrReceiverMultipleExplanatoryVariable = New instat.ucrReceiverMultiple()
        Me.lblExplanatoryVariable = New System.Windows.Forms.Label()
        Me.grpModelType = New System.Windows.Forms.GroupBox()
        Me.rdoRegression = New System.Windows.Forms.RadioButton()
        Me.rdoClassification = New System.Windows.Forms.RadioButton()
        Me.ucrPnlModelType = New instat.UcrPanel()
        Me.ucrModelName = New instat.ucrSave()
        Me.ucrInputClassificationMethod = New instat.ucrInputComboBox()
        Me.lblClassificationMethod = New System.Windows.Forms.Label()
        Me.lblTrainSize = New System.Windows.Forms.Label()
        Me.ucrNudTrainTestSize = New instat.ucrNud()
        Me.ucrInputRegressionMethod = New instat.ucrInputComboBox()
        Me.ucrReceiverRegressionResponse = New instat.ucrReceiverSingle()
        Me.ucrChkClassificationPerformance = New instat.ucrCheck()
        Me.ucrChkRegressionPerformance = New instat.ucrCheck()
        Me.ucrReceiverExpressionModel = New instat.ucrReceiverExpression()
        Me.grpExplanatoryVariable.SuspendLayout()
        Me.grpModelType.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(7, 400)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 15
        '
        'ucrSelectorMachineLearning
        '
        Me.ucrSelectorMachineLearning.AutoSize = True
        Me.ucrSelectorMachineLearning.bDropUnusedFilterLevels = False
        Me.ucrSelectorMachineLearning.bShowHiddenColumns = False
        Me.ucrSelectorMachineLearning.bUseCurrentFilter = True
        Me.ucrSelectorMachineLearning.Location = New System.Drawing.Point(7, 19)
        Me.ucrSelectorMachineLearning.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorMachineLearning.Name = "ucrSelectorMachineLearning"
        Me.ucrSelectorMachineLearning.Size = New System.Drawing.Size(151, 180)
        Me.ucrSelectorMachineLearning.TabIndex = 0
        '
        'ucrReceiverClassificationResponseVariable
        '
        Me.ucrReceiverClassificationResponseVariable.AutoSize = True
        Me.ucrReceiverClassificationResponseVariable.frmParent = Me
        Me.ucrReceiverClassificationResponseVariable.Location = New System.Drawing.Point(242, 68)
        Me.ucrReceiverClassificationResponseVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverClassificationResponseVariable.Name = "ucrReceiverClassificationResponseVariable"
        Me.ucrReceiverClassificationResponseVariable.Selector = Nothing
        Me.ucrReceiverClassificationResponseVariable.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverClassificationResponseVariable.strNcFilePath = ""
        Me.ucrReceiverClassificationResponseVariable.TabIndex = 2
        Me.ucrReceiverClassificationResponseVariable.ucrSelector = Nothing
        '
        'lblResponceVariable
        '
        Me.lblResponceVariable.AutoSize = True
        Me.lblResponceVariable.Location = New System.Drawing.Point(239, 55)
        Me.lblResponceVariable.Name = "lblResponceVariable"
        Me.lblResponceVariable.Size = New System.Drawing.Size(99, 13)
        Me.lblResponceVariable.TabIndex = 4
        Me.lblResponceVariable.Text = "Response Variable:"
        '
        'grpExplanatoryVariable
        '
        Me.grpExplanatoryVariable.Controls.Add(Me.rdoExplanatoryVariable)
        Me.grpExplanatoryVariable.Controls.Add(Me.rdoExplanatoryModel)
        Me.grpExplanatoryVariable.Controls.Add(Me.ucrPnlExplanatoryVariable)
        Me.grpExplanatoryVariable.Location = New System.Drawing.Point(236, 98)
        Me.grpExplanatoryVariable.Name = "grpExplanatoryVariable"
        Me.grpExplanatoryVariable.Size = New System.Drawing.Size(170, 48)
        Me.grpExplanatoryVariable.TabIndex = 6
        Me.grpExplanatoryVariable.TabStop = False
        Me.grpExplanatoryVariable.Text = "Predictor"
        '
        'rdoExplanatoryVariable
        '
        Me.rdoExplanatoryVariable.AutoSize = True
        Me.rdoExplanatoryVariable.Location = New System.Drawing.Point(8, 21)
        Me.rdoExplanatoryVariable.Name = "rdoExplanatoryVariable"
        Me.rdoExplanatoryVariable.Size = New System.Drawing.Size(63, 17)
        Me.rdoExplanatoryVariable.TabIndex = 0
        Me.rdoExplanatoryVariable.TabStop = True
        Me.rdoExplanatoryVariable.Text = "Variable"
        Me.rdoExplanatoryVariable.UseVisualStyleBackColor = True
        '
        'rdoExplanatoryModel
        '
        Me.rdoExplanatoryModel.AutoSize = True
        Me.rdoExplanatoryModel.Location = New System.Drawing.Point(94, 21)
        Me.rdoExplanatoryModel.Name = "rdoExplanatoryModel"
        Me.rdoExplanatoryModel.Size = New System.Drawing.Size(54, 17)
        Me.rdoExplanatoryModel.TabIndex = 2
        Me.rdoExplanatoryModel.TabStop = True
        Me.rdoExplanatoryModel.Text = "Model"
        Me.rdoExplanatoryModel.UseVisualStyleBackColor = True
        '
        'ucrPnlExplanatoryVariable
        '
        Me.ucrPnlExplanatoryVariable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlExplanatoryVariable.Location = New System.Drawing.Point(6, 18)
        Me.ucrPnlExplanatoryVariable.Name = "ucrPnlExplanatoryVariable"
        Me.ucrPnlExplanatoryVariable.Size = New System.Drawing.Size(158, 22)
        Me.ucrPnlExplanatoryVariable.TabIndex = 1
        '
        'ucrReceiverMultipleExplanatoryVariable
        '
        Me.ucrReceiverMultipleExplanatoryVariable.AutoSize = True
        Me.ucrReceiverMultipleExplanatoryVariable.frmParent = Me
        Me.ucrReceiverMultipleExplanatoryVariable.Location = New System.Drawing.Point(242, 175)
        Me.ucrReceiverMultipleExplanatoryVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleExplanatoryVariable.Name = "ucrReceiverMultipleExplanatoryVariable"
        Me.ucrReceiverMultipleExplanatoryVariable.Selector = Nothing
        Me.ucrReceiverMultipleExplanatoryVariable.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleExplanatoryVariable.strNcFilePath = ""
        Me.ucrReceiverMultipleExplanatoryVariable.TabIndex = 3
        Me.ucrReceiverMultipleExplanatoryVariable.ucrSelector = Nothing
        '
        'lblExplanatoryVariable
        '
        Me.lblExplanatoryVariable.AutoSize = True
        Me.lblExplanatoryVariable.Location = New System.Drawing.Point(239, 162)
        Me.lblExplanatoryVariable.Name = "lblExplanatoryVariable"
        Me.lblExplanatoryVariable.Size = New System.Drawing.Size(111, 13)
        Me.lblExplanatoryVariable.TabIndex = 5
        Me.lblExplanatoryVariable.Text = "Explanatory Variables:"
        '
        'grpModelType
        '
        Me.grpModelType.Controls.Add(Me.rdoRegression)
        Me.grpModelType.Controls.Add(Me.rdoClassification)
        Me.grpModelType.Controls.Add(Me.ucrPnlModelType)
        Me.grpModelType.Location = New System.Drawing.Point(7, 206)
        Me.grpModelType.Name = "grpModelType"
        Me.grpModelType.Size = New System.Drawing.Size(184, 52)
        Me.grpModelType.TabIndex = 7
        Me.grpModelType.TabStop = False
        Me.grpModelType.Text = "Type"
        '
        'rdoRegression
        '
        Me.rdoRegression.AutoSize = True
        Me.rdoRegression.Location = New System.Drawing.Point(97, 24)
        Me.rdoRegression.Name = "rdoRegression"
        Me.rdoRegression.Size = New System.Drawing.Size(78, 17)
        Me.rdoRegression.TabIndex = 2
        Me.rdoRegression.TabStop = True
        Me.rdoRegression.Text = "Regression"
        Me.rdoRegression.UseVisualStyleBackColor = True
        '
        'rdoClassification
        '
        Me.rdoClassification.AutoSize = True
        Me.rdoClassification.Location = New System.Drawing.Point(7, 24)
        Me.rdoClassification.Name = "rdoClassification"
        Me.rdoClassification.Size = New System.Drawing.Size(86, 17)
        Me.rdoClassification.TabIndex = 1
        Me.rdoClassification.TabStop = True
        Me.rdoClassification.Text = "Classification"
        Me.rdoClassification.UseVisualStyleBackColor = True
        '
        'ucrPnlModelType
        '
        Me.ucrPnlModelType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlModelType.Location = New System.Drawing.Point(6, 19)
        Me.ucrPnlModelType.Name = "ucrPnlModelType"
        Me.ucrPnlModelType.Size = New System.Drawing.Size(172, 26)
        Me.ucrPnlModelType.TabIndex = 0
        '
        'ucrModelName
        '
        Me.ucrModelName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrModelName.Location = New System.Drawing.Point(7, 358)
        Me.ucrModelName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrModelName.Name = "ucrModelName"
        Me.ucrModelName.Size = New System.Drawing.Size(403, 34)
        Me.ucrModelName.TabIndex = 14
        '
        'ucrInputClassificationMethod
        '
        Me.ucrInputClassificationMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputClassificationMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputClassificationMethod.GetSetSelectedIndex = -1
        Me.ucrInputClassificationMethod.IsReadOnly = False
        Me.ucrInputClassificationMethod.Location = New System.Drawing.Point(71, 327)
        Me.ucrInputClassificationMethod.Name = "ucrInputClassificationMethod"
        Me.ucrInputClassificationMethod.Size = New System.Drawing.Size(71, 21)
        Me.ucrInputClassificationMethod.TabIndex = 22
        '
        'lblClassificationMethod
        '
        Me.lblClassificationMethod.AutoSize = True
        Me.lblClassificationMethod.Location = New System.Drawing.Point(21, 330)
        Me.lblClassificationMethod.Name = "lblClassificationMethod"
        Me.lblClassificationMethod.Size = New System.Drawing.Size(46, 13)
        Me.lblClassificationMethod.TabIndex = 12
        Me.lblClassificationMethod.Text = "Method:"
        '
        'lblTrainSize
        '
        Me.lblTrainSize.AutoSize = True
        Me.lblTrainSize.Location = New System.Drawing.Point(11, 300)
        Me.lblTrainSize.Name = "lblTrainSize"
        Me.lblTrainSize.Size = New System.Drawing.Size(57, 13)
        Me.lblTrainSize.TabIndex = 10
        Me.lblTrainSize.Text = "Train Size:"
        '
        'ucrNudTrainTestSize
        '
        Me.ucrNudTrainTestSize.AutoSize = True
        Me.ucrNudTrainTestSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTrainTestSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTrainTestSize.Location = New System.Drawing.Point(71, 298)
        Me.ucrNudTrainTestSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTrainTestSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTrainTestSize.Name = "ucrNudTrainTestSize"
        Me.ucrNudTrainTestSize.Size = New System.Drawing.Size(71, 20)
        Me.ucrNudTrainTestSize.TabIndex = 11
        Me.ucrNudTrainTestSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputRegressionMethod
        '
        Me.ucrInputRegressionMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputRegressionMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputRegressionMethod.GetSetSelectedIndex = -1
        Me.ucrInputRegressionMethod.IsReadOnly = False
        Me.ucrInputRegressionMethod.Location = New System.Drawing.Point(71, 327)
        Me.ucrInputRegressionMethod.Name = "ucrInputRegressionMethod"
        Me.ucrInputRegressionMethod.Size = New System.Drawing.Size(71, 21)
        Me.ucrInputRegressionMethod.TabIndex = 13
        '
        'ucrReceiverRegressionResponse
        '
        Me.ucrReceiverRegressionResponse.AutoSize = True
        Me.ucrReceiverRegressionResponse.frmParent = Me
        Me.ucrReceiverRegressionResponse.Location = New System.Drawing.Point(242, 68)
        Me.ucrReceiverRegressionResponse.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRegressionResponse.Name = "ucrReceiverRegressionResponse"
        Me.ucrReceiverRegressionResponse.Selector = Nothing
        Me.ucrReceiverRegressionResponse.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRegressionResponse.strNcFilePath = ""
        Me.ucrReceiverRegressionResponse.TabIndex = 1
        Me.ucrReceiverRegressionResponse.ucrSelector = Nothing
        '
        'ucrChkClassificationPerformance
        '
        Me.ucrChkClassificationPerformance.AutoSize = True
        Me.ucrChkClassificationPerformance.Checked = False
        Me.ucrChkClassificationPerformance.Location = New System.Drawing.Point(14, 266)
        Me.ucrChkClassificationPerformance.Name = "ucrChkClassificationPerformance"
        Me.ucrChkClassificationPerformance.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkClassificationPerformance.TabIndex = 9
        '
        'ucrChkRegressionPerformance
        '
        Me.ucrChkRegressionPerformance.AutoSize = True
        Me.ucrChkRegressionPerformance.Checked = False
        Me.ucrChkRegressionPerformance.Location = New System.Drawing.Point(14, 266)
        Me.ucrChkRegressionPerformance.Name = "ucrChkRegressionPerformance"
        Me.ucrChkRegressionPerformance.Size = New System.Drawing.Size(184, 23)
        Me.ucrChkRegressionPerformance.TabIndex = 8
        '
        'ucrReceiverExpressionModel
        '
        Me.ucrReceiverExpressionModel.AutoSize = True
        Me.ucrReceiverExpressionModel.frmParent = Me
        Me.ucrReceiverExpressionModel.Location = New System.Drawing.Point(242, 175)
        Me.ucrReceiverExpressionModel.Name = "ucrReceiverExpressionModel"
        Me.ucrReceiverExpressionModel.Selector = Nothing
        Me.ucrReceiverExpressionModel.Size = New System.Drawing.Size(168, 21)
        Me.ucrReceiverExpressionModel.strNcFilePath = ""
        Me.ucrReceiverExpressionModel.TabIndex = 23
        Me.ucrReceiverExpressionModel.ucrSelector = Nothing
        '
        'dlgMachineLearning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(418, 460)
        Me.Controls.Add(Me.ucrReceiverExpressionModel)
        Me.Controls.Add(Me.ucrChkRegressionPerformance)
        Me.Controls.Add(Me.ucrChkClassificationPerformance)
        Me.Controls.Add(Me.ucrReceiverRegressionResponse)
        Me.Controls.Add(Me.ucrInputRegressionMethod)
        Me.Controls.Add(Me.ucrNudTrainTestSize)
        Me.Controls.Add(Me.lblTrainSize)
        Me.Controls.Add(Me.lblClassificationMethod)
        Me.Controls.Add(Me.ucrInputClassificationMethod)
        Me.Controls.Add(Me.ucrModelName)
        Me.Controls.Add(Me.grpModelType)
        Me.Controls.Add(Me.lblExplanatoryVariable)
        Me.Controls.Add(Me.ucrReceiverMultipleExplanatoryVariable)
        Me.Controls.Add(Me.grpExplanatoryVariable)
        Me.Controls.Add(Me.lblResponceVariable)
        Me.Controls.Add(Me.ucrReceiverClassificationResponseVariable)
        Me.Controls.Add(Me.ucrSelectorMachineLearning)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMachineLearning"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Machine Learning (caret) "
        Me.grpExplanatoryVariable.ResumeLayout(False)
        Me.grpExplanatoryVariable.PerformLayout()
        Me.grpModelType.ResumeLayout(False)
        Me.grpModelType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorMachineLearning As ucrSelectorByDataFrame
    Friend WithEvents ucrReceiverClassificationResponseVariable As ucrReceiverSingle
    Friend WithEvents grpModelType As GroupBox
    Friend WithEvents rdoRegression As RadioButton
    Friend WithEvents rdoClassification As RadioButton
    Friend WithEvents ucrPnlModelType As UcrPanel
    Friend WithEvents lblExplanatoryVariable As Label
    Friend WithEvents ucrReceiverMultipleExplanatoryVariable As ucrReceiverMultiple
    Friend WithEvents grpExplanatoryVariable As GroupBox
    Friend WithEvents rdoExplanatoryVariable As RadioButton
    Friend WithEvents rdoExplanatoryModel As RadioButton
    Friend WithEvents ucrPnlExplanatoryVariable As UcrPanel
    Friend WithEvents lblResponceVariable As Label
    Friend WithEvents ucrModelName As ucrSave
    Friend WithEvents lblClassificationMethod As Label
    Friend WithEvents ucrInputClassificationMethod As ucrInputComboBox
    Friend WithEvents ucrNudTrainTestSize As ucrNud
    Friend WithEvents lblTrainSize As Label
    Friend WithEvents ucrInputRegressionMethod As ucrInputComboBox
    Friend WithEvents ucrReceiverRegressionResponse As ucrReceiverSingle
    Friend WithEvents ucrChkClassificationPerformance As ucrCheck
    Friend WithEvents ucrChkRegressionPerformance As ucrCheck
    Friend WithEvents ucrReceiverExpressionModel As ucrReceiverExpression
End Class
