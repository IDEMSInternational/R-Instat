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
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(325, 298)
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
        Me.cmdModelOptions.Location = New System.Drawing.Point(325, 271)
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
        Me.lblModelPreview.Location = New System.Drawing.Point(10, 274)
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
        Me.rdoTwoSample.Size = New System.Drawing.Size(121, 28)
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
        Me.rdoGeneralCase.Location = New System.Drawing.Point(130, 11)
        Me.rdoGeneralCase.Name = "rdoGeneralCase"
        Me.rdoGeneralCase.Size = New System.Drawing.Size(121, 28)
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
        'ucrSaveModels
        '
        Me.ucrSaveModels.Location = New System.Drawing.Point(9, 297)
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
        Me.ucrSelectorSimpleReg.Location = New System.Drawing.Point(10, 49)
        Me.ucrSelectorSimpleReg.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSimpleReg.Name = "ucrSelectorSimpleReg"
        Me.ucrSelectorSimpleReg.Size = New System.Drawing.Size(226, 186)
        Me.ucrSelectorSimpleReg.TabIndex = 2
        '
        'ucrChkFunction
        '
        Me.ucrChkFunction.Checked = False
        Me.ucrChkFunction.Location = New System.Drawing.Point(267, 158)
        Me.ucrChkFunction.Name = "ucrChkFunction"
        Me.ucrChkFunction.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkFunction.TabIndex = 0
        '
        'ucrPnlModelType
        '
        Me.ucrPnlModelType.Location = New System.Drawing.Point(120, 3)
        Me.ucrPnlModelType.Name = "ucrPnlModelType"
        Me.ucrPnlModelType.Size = New System.Drawing.Size(267, 43)
        Me.ucrPnlModelType.TabIndex = 3
        '
        'ucrModelPreview
        '
        Me.ucrModelPreview.AddQuotesIfUnrecognised = True
        Me.ucrModelPreview.IsMultiline = False
        Me.ucrModelPreview.IsReadOnly = False
        Me.ucrModelPreview.Location = New System.Drawing.Point(96, 270)
        Me.ucrModelPreview.Name = "ucrModelPreview"
        Me.ucrModelPreview.Size = New System.Drawing.Size(204, 21)
        Me.ucrModelPreview.TabIndex = 23
        '
        'ucrDistributionChoice
        '
        Me.ucrDistributionChoice.Location = New System.Drawing.Point(9, 238)
        Me.ucrDistributionChoice.Name = "ucrDistributionChoice"
        Me.ucrDistributionChoice.Size = New System.Drawing.Size(208, 27)
        Me.ucrDistributionChoice.TabIndex = 24
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 329)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(406, 54)
        Me.ucrBase.TabIndex = 17
        '
        'dlgRegressionSimple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 387)
        Me.Controls.Add(Me.ucrSaveModels)
        Me.Controls.Add(Me.rdoTwoSample)
        Me.Controls.Add(Me.rdoGeneralCase)
        Me.Controls.Add(Me.ucrChkConvertToVariate)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblNumeric)
        Me.Controls.Add(Me.ucrReceiverExplanatory)
        Me.Controls.Add(Me.ucrReceiverResponse)
        Me.Controls.Add(Me.ucrSelectorSimpleReg)
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
    Friend WithEvents ucrSaveModels As ucrSave
End Class