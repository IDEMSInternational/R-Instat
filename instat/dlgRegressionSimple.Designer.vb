<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgRegressionSimple
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
        Me.lblResidualMsg = New System.Windows.Forms.Label()
        Me.lblDF = New System.Windows.Forms.Label()
        Me.txtResidualMsg = New System.Windows.Forms.TextBox()
        Me.txtdf = New System.Windows.Forms.TextBox()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.cmdModelOptions = New System.Windows.Forms.Button()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.rdoTwoSample = New System.Windows.Forms.RadioButton()
        Me.rdoGeneralCase = New System.Windows.Forms.RadioButton()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.lblNumeric = New System.Windows.Forms.Label()
        Me.lblExplanatory = New System.Windows.Forms.Label()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.grpParameters = New System.Windows.Forms.GroupBox()
        Me.lblDifferenceInMeans = New System.Windows.Forms.Label()
        Me.ucrNudHypothesis = New instat.ucrNud()
        Me.ucrNudCI = New instat.ucrNud()
        Me.lblConfidenceInterval = New System.Windows.Forms.Label()
        Me.ucrChkPairedTest = New instat.ucrCheck()
        Me.rdoCompareVariance = New System.Windows.Forms.RadioButton()
        Me.rdoCompareMeans = New System.Windows.Forms.RadioButton()
        Me.ucrPnlMeansAndVariance = New instat.UcrPanel()
        Me.ucrSaveModels = New instat.ucrSave()
        Me.ucrChkConvertToVariate = New instat.ucrCheck()
        Me.ucrReceiverExplanatory = New instat.ucrReceiverSingle()
        Me.ucrReceiverResponse = New instat.ucrReceiverSingle()
        Me.ucrSelectorSimpleReg = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkFunction = New instat.ucrCheck()
        Me.ucrPnlModelType = New instat.UcrPanel()
        Me.ucrModelPreview = New instat.ucrInputTextBox()
        Me.ucrDistributionChoice = New instat.ucrDistributions()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpParameters.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblResidualMsg
        '
        Me.lblResidualMsg.AutoSize = True
        Me.lblResidualMsg.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResidualMsg.Location = New System.Drawing.Point(7, 11)
        Me.lblResidualMsg.Name = "lblResidualMsg"
        Me.lblResidualMsg.Size = New System.Drawing.Size(94, 13)
        Me.lblResidualMsg.TabIndex = 0
        Me.lblResidualMsg.Tag = "Residual_Msg"
        '
        'lblDF
        '
        Me.lblDF.AutoSize = True
        Me.lblDF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDF.Location = New System.Drawing.Point(7, 43)
        Me.lblDF.Name = "lblDF"
        Me.lblDF.Size = New System.Drawing.Size(100, 13)
        Me.lblDF.TabIndex = 1
        Me.lblDF.Tag = "Degrees_of_freedom"
        '
        'txtResidualMsg
        '
        Me.txtResidualMsg.Location = New System.Drawing.Point(118, 11)
        Me.txtResidualMsg.Name = "txtResidualMsg"
        Me.txtResidualMsg.Size = New System.Drawing.Size(149, 20)
        Me.txtResidualMsg.TabIndex = 2
        '
        'txtdf
        '
        Me.txtdf.Location = New System.Drawing.Point(118, 43)
        Me.txtdf.Name = "txtdf"
        Me.txtdf.Size = New System.Drawing.Size(58, 20)
        Me.txtdf.TabIndex = 12
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(325, 286)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(110, 23)
        Me.cmdDisplayOptions.TabIndex = 16
        Me.cmdDisplayOptions.Tag = "Display_Options..."
        Me.cmdDisplayOptions.Text = "Display Options..."
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'cmdModelOptions
        '
        Me.cmdModelOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdModelOptions.Location = New System.Drawing.Point(325, 259)
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.Size = New System.Drawing.Size(110, 23)
        Me.cmdModelOptions.TabIndex = 15
        Me.cmdModelOptions.Tag = "Model_Options..."
        Me.cmdModelOptions.Text = "Model Options..."
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'lblModelPreview
        '
        Me.lblModelPreview.AutoSize = True
        Me.lblModelPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblModelPreview.Location = New System.Drawing.Point(10, 262)
        Me.lblModelPreview.Name = "lblModelPreview"
        Me.lblModelPreview.Size = New System.Drawing.Size(80, 13)
        Me.lblModelPreview.TabIndex = 11
        Me.lblModelPreview.Text = "Model Preview:"
        '
        'rdoTwoSample
        '
        Me.rdoTwoSample.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTwoSample.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoSample.FlatAppearance.BorderSize = 2
        Me.rdoTwoSample.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTwoSample.Location = New System.Drawing.Point(249, 11)
        Me.rdoTwoSample.Name = "rdoTwoSample"
        Me.rdoTwoSample.Size = New System.Drawing.Size(100, 28)
        Me.rdoTwoSample.TabIndex = 21
        Me.rdoTwoSample.Text = "Two Sample"
        Me.rdoTwoSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTwoSample.UseVisualStyleBackColor = True
        '
        'rdoGeneralCase
        '
        Me.rdoGeneralCase.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGeneralCase.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGeneralCase.FlatAppearance.BorderSize = 2
        Me.rdoGeneralCase.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGeneralCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGeneralCase.Location = New System.Drawing.Point(151, 11)
        Me.rdoGeneralCase.Name = "rdoGeneralCase"
        Me.rdoGeneralCase.Size = New System.Drawing.Size(100, 28)
        Me.rdoGeneralCase.TabIndex = 20
        Me.rdoGeneralCase.Text = "General Case"
        Me.rdoGeneralCase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGeneralCase.UseVisualStyleBackColor = True
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactor.Location = New System.Drawing.Point(264, 117)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(106, 13)
        Me.lblFactor.TabIndex = 6
        Me.lblFactor.Text = "Explanatory Variable:"
        '
        'lblNumeric
        '
        Me.lblNumeric.AutoSize = True
        Me.lblNumeric.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeric.Location = New System.Drawing.Point(264, 55)
        Me.lblNumeric.Name = "lblNumeric"
        Me.lblNumeric.Size = New System.Drawing.Size(99, 13)
        Me.lblNumeric.TabIndex = 3
        Me.lblNumeric.Text = "Response Variable:"
        '
        'lblExplanatory
        '
        Me.lblExplanatory.Location = New System.Drawing.Point(0, 0)
        Me.lblExplanatory.Name = "lblExplanatory"
        Me.lblExplanatory.Size = New System.Drawing.Size(100, 23)
        Me.lblExplanatory.TabIndex = 23
        '
        'lblResponse
        '
        Me.lblResponse.Location = New System.Drawing.Point(0, 0)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(100, 23)
        Me.lblResponse.TabIndex = 24
        '
        'grpParameters
        '
        Me.grpParameters.Controls.Add(Me.lblDifferenceInMeans)
        Me.grpParameters.Controls.Add(Me.ucrNudHypothesis)
        Me.grpParameters.Controls.Add(Me.ucrNudCI)
        Me.grpParameters.Controls.Add(Me.lblConfidenceInterval)
        Me.grpParameters.Controls.Add(Me.ucrChkPairedTest)
        Me.grpParameters.Controls.Add(Me.rdoCompareVariance)
        Me.grpParameters.Controls.Add(Me.rdoCompareMeans)
        Me.grpParameters.Controls.Add(Me.ucrPnlMeansAndVariance)
        Me.grpParameters.Location = New System.Drawing.Point(489, 131)
        Me.grpParameters.Name = "grpParameters"
        Me.grpParameters.Size = New System.Drawing.Size(200, 100)
        Me.grpParameters.TabIndex = 0
        Me.grpParameters.TabStop = False
        '
        'lblDifferenceInMeans
        '
        Me.lblDifferenceInMeans.Location = New System.Drawing.Point(540, 256)
        Me.lblDifferenceInMeans.Name = "lblDifferenceInMeans"
        Me.lblDifferenceInMeans.Size = New System.Drawing.Size(100, 23)
        Me.lblDifferenceInMeans.TabIndex = 19
        '
        'ucrNudHypothesis
        '
        Me.ucrNudHypothesis.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHypothesis.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHypothesis.Location = New System.Drawing.Point(578, 220)
        Me.ucrNudHypothesis.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudHypothesis.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHypothesis.Name = "ucrNudHypothesis"
        Me.ucrNudHypothesis.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudHypothesis.TabIndex = 13
        Me.ucrNudHypothesis.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudCI
        '
        Me.ucrNudCI.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCI.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCI.Location = New System.Drawing.Point(554, 223)
        Me.ucrNudCI.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCI.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCI.Name = "ucrNudCI"
        Me.ucrNudCI.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCI.TabIndex = 15
        Me.ucrNudCI.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblConfidenceInterval
        '
        Me.lblConfidenceInterval.Location = New System.Drawing.Point(589, 243)
        Me.lblConfidenceInterval.Name = "lblConfidenceInterval"
        Me.lblConfidenceInterval.Size = New System.Drawing.Size(100, 23)
        Me.lblConfidenceInterval.TabIndex = 18
        '
        'ucrChkPairedTest
        '
        Me.ucrChkPairedTest.Checked = False
        Me.ucrChkPairedTest.Location = New System.Drawing.Point(489, 140)
        Me.ucrChkPairedTest.Name = "ucrChkPairedTest"
        Me.ucrChkPairedTest.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkPairedTest.TabIndex = 14
        '
        'rdoCompareVariance
        '
        Me.rdoCompareVariance.Location = New System.Drawing.Point(0, 0)
        Me.rdoCompareVariance.Name = "rdoCompareVariance"
        Me.rdoCompareVariance.Size = New System.Drawing.Size(104, 24)
        Me.rdoCompareVariance.TabIndex = 20
        Me.rdoCompareVariance.TabStop = True
        Me.rdoCompareVariance.Tag = ""
        Me.rdoCompareVariance.UseVisualStyleBackColor = True
        '
        'rdoCompareMeans
        '
        Me.rdoCompareMeans.Location = New System.Drawing.Point(0, 0)
        Me.rdoCompareMeans.Name = "rdoCompareMeans"
        Me.rdoCompareMeans.Size = New System.Drawing.Size(104, 24)
        Me.rdoCompareMeans.TabIndex = 21
        Me.rdoCompareMeans.TabStop = True
        Me.rdoCompareMeans.Tag = ""
        Me.rdoCompareMeans.UseVisualStyleBackColor = True
        '
        'ucrPnlMeansAndVariance
        '
        Me.ucrPnlMeansAndVariance.Location = New System.Drawing.Point(489, 286)
        Me.ucrPnlMeansAndVariance.Name = "ucrPnlMeansAndVariance"
        Me.ucrPnlMeansAndVariance.Size = New System.Drawing.Size(187, 76)
        Me.ucrPnlMeansAndVariance.TabIndex = 17
        '
        'ucrSaveModels
        '
        Me.ucrSaveModels.Location = New System.Drawing.Point(9, 285)
        Me.ucrSaveModels.Name = "ucrSaveModels"
        Me.ucrSaveModels.Size = New System.Drawing.Size(291, 24)
        Me.ucrSaveModels.TabIndex = 1
        '
        'ucrChkConvertToVariate
        '
        Me.ucrChkConvertToVariate.Checked = False
        Me.ucrChkConvertToVariate.Location = New System.Drawing.Point(267, 92)
        Me.ucrChkConvertToVariate.Name = "ucrChkConvertToVariate"
        Me.ucrChkConvertToVariate.Size = New System.Drawing.Size(120, 20)
        Me.ucrChkConvertToVariate.TabIndex = 4
        '
        'ucrReceiverExplanatory
        '
        Me.ucrReceiverExplanatory.frmParent = Me
        Me.ucrReceiverExplanatory.Location = New System.Drawing.Point(267, 135)
        Me.ucrReceiverExplanatory.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverExplanatory.Name = "ucrReceiverExplanatory"
        Me.ucrReceiverExplanatory.Selector = Nothing
        Me.ucrReceiverExplanatory.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverExplanatory.strNcFilePath = ""
        Me.ucrReceiverExplanatory.TabIndex = 22
        Me.ucrReceiverExplanatory.ucrSelector = Nothing
        '
        'ucrReceiverResponse
        '
        Me.ucrReceiverResponse.frmParent = Me
        Me.ucrReceiverResponse.Location = New System.Drawing.Point(267, 69)
        Me.ucrReceiverResponse.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverResponse.Name = "ucrReceiverResponse"
        Me.ucrReceiverResponse.Selector = Nothing
        Me.ucrReceiverResponse.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverResponse.strNcFilePath = ""
        Me.ucrReceiverResponse.TabIndex = 4
        Me.ucrReceiverResponse.ucrSelector = Nothing
        '
        'ucrSelectorSimpleReg
        '
        Me.ucrSelectorSimpleReg.bShowHiddenColumns = False
        Me.ucrSelectorSimpleReg.bUseCurrentFilter = True
        Me.ucrSelectorSimpleReg.Location = New System.Drawing.Point(10, 37)
        Me.ucrSelectorSimpleReg.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSimpleReg.Name = "ucrSelectorSimpleReg"
        Me.ucrSelectorSimpleReg.Size = New System.Drawing.Size(226, 186)
        Me.ucrSelectorSimpleReg.TabIndex = 2
        '
        'ucrChkFunction
        '
        Me.ucrChkFunction.Checked = False
        Me.ucrChkFunction.Location = New System.Drawing.Point(489, 86)
        Me.ucrChkFunction.Name = "ucrChkFunction"
        Me.ucrChkFunction.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkFunction.TabIndex = 0
        '
        'ucrPnlModelType
        '
        Me.ucrPnlModelType.Location = New System.Drawing.Point(143, -5)
        Me.ucrPnlModelType.Name = "ucrPnlModelType"
        Me.ucrPnlModelType.Size = New System.Drawing.Size(219, 54)
        Me.ucrPnlModelType.TabIndex = 3
        '
        'ucrModelPreview
        '
        Me.ucrModelPreview.AddQuotesIfUnrecognised = True
        Me.ucrModelPreview.IsMultiline = False
        Me.ucrModelPreview.IsReadOnly = False
        Me.ucrModelPreview.Location = New System.Drawing.Point(96, 258)
        Me.ucrModelPreview.Name = "ucrModelPreview"
        Me.ucrModelPreview.Size = New System.Drawing.Size(204, 21)
        Me.ucrModelPreview.TabIndex = 23
        '
        'ucrDistributionChoice
        '
        Me.ucrDistributionChoice.Location = New System.Drawing.Point(9, 226)
        Me.ucrDistributionChoice.Name = "ucrDistributionChoice"
        Me.ucrDistributionChoice.Size = New System.Drawing.Size(208, 27)
        Me.ucrDistributionChoice.TabIndex = 24
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 317)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(406, 54)
        Me.ucrBase.TabIndex = 17
        '
        'dlgRegressionSimple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 372)
        Me.Controls.Add(Me.grpParameters)
        Me.Controls.Add(Me.ucrSaveModels)
        Me.Controls.Add(Me.rdoTwoSample)
        Me.Controls.Add(Me.rdoGeneralCase)
        Me.Controls.Add(Me.ucrChkConvertToVariate)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblNumeric)
        Me.Controls.Add(Me.ucrReceiverExplanatory)
        Me.Controls.Add(Me.ucrReceiverResponse)
        Me.Controls.Add(Me.ucrSelectorSimpleReg)
        Me.Controls.Add(Me.lblExplanatory)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.ucrChkFunction)
        Me.Controls.Add(Me.ucrPnlModelType)
        Me.Controls.Add(Me.ucrModelPreview)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.ucrDistributionChoice)
        Me.Controls.Add(Me.cmdModelOptions)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRegressionSimple"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Simple_Regression"
        Me.Text = "Two Variable Fit Model"
        Me.grpParameters.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblResidualMsg As Label
    Friend WithEvents lblDF As Label
    Friend WithEvents txtResidualMsg As TextBox
    Friend WithEvents txtdf As TextBox
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents cmdModelOptions As Button
    Friend WithEvents ucrDistributionChoice As ucrDistributions
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents ucrModelPreview As ucrInputTextBox
    Friend WithEvents ucrChkFunction As ucrCheck
    Friend WithEvents ucrPnlModelType As UcrPanel
    Friend WithEvents rdoTwoSample As RadioButton
    Friend WithEvents rdoGeneralCase As RadioButton
    Friend WithEvents ucrChkConvertToVariate As ucrCheck
    Friend WithEvents lblFactor As Label
    Friend WithEvents lblNumeric As Label
    Friend WithEvents ucrReceiverExplanatory As ucrReceiverSingle
    Friend WithEvents ucrReceiverResponse As ucrReceiverSingle
    Friend WithEvents ucrSelectorSimpleReg As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblExplanatory As Label
    Friend WithEvents lblResponse As Label
    Friend WithEvents ucrSaveModels As ucrSave
    Friend WithEvents grpParameters As GroupBox
    Friend WithEvents rdoCompareVariance As RadioButton
    Friend WithEvents rdoCompareMeans As RadioButton
    Friend WithEvents ucrPnlMeansAndVariance As UcrPanel
    Friend WithEvents ucrChkPairedTest As ucrCheck
    Friend WithEvents lblConfidenceInterval As Label
    Friend WithEvents ucrNudHypothesis As ucrNud
    Friend WithEvents ucrNudCI As ucrNud
    Friend WithEvents lblDifferenceInMeans As Label
End Class