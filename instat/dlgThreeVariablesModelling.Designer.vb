<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgThreeVariableModelling
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
        Me.chkSaveModel = New System.Windows.Forms.CheckBox()
        Me.lblFirstExplanatoryVariable = New System.Windows.Forms.Label()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.lblSecondExplanatoryVariable = New System.Windows.Forms.Label()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.cmdModelOptions = New System.Windows.Forms.Button()
        Me.chkConvertToVariate = New System.Windows.Forms.CheckBox()
        Me.chkFirstFunction = New System.Windows.Forms.CheckBox()
        Me.ucrModelPreview = New instat.ucrInputTextBox()
        Me.ucrFamily = New instat.ucrDistributions()
        Me.ucrSecondExplanatory = New instat.ucrReceiverSingle()
        Me.ucrFirstExplanatory = New instat.ucrReceiverSingle()
        Me.ucrResponse = New instat.ucrReceiverSingle()
        Me.ucrSelectorThreeVariableModelling = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseThreeVariableModelling = New instat.ucrButtons()
        Me.chkSecondFunction = New System.Windows.Forms.CheckBox()
        Me.ucrModelName = New instat.ucrInputComboBox()
        Me.ucrModelOperator = New instat.ucrInputComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkResponseFunction = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'chkSaveModel
        '
        Me.chkSaveModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkSaveModel.Location = New System.Drawing.Point(9, 269)
        Me.chkSaveModel.Name = "chkSaveModel"
        Me.chkSaveModel.Size = New System.Drawing.Size(104, 24)
        Me.chkSaveModel.TabIndex = 14
        Me.chkSaveModel.Tag = "Save_Model"
        Me.chkSaveModel.Text = "Save Model:"
        Me.chkSaveModel.UseVisualStyleBackColor = True
        '
        'lblFirstExplanatoryVariable
        '
        Me.lblFirstExplanatoryVariable.AutoSize = True
        Me.lblFirstExplanatoryVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstExplanatoryVariable.Location = New System.Drawing.Point(229, 67)
        Me.lblFirstExplanatoryVariable.Name = "lblFirstExplanatoryVariable"
        Me.lblFirstExplanatoryVariable.Size = New System.Drawing.Size(125, 13)
        Me.lblFirstExplanatoryVariable.TabIndex = 4
        Me.lblFirstExplanatoryVariable.Tag = "First_Explanatory_Variable"
        Me.lblFirstExplanatoryVariable.Text = "First Explanatory Variable"
        '
        'lblResponse
        '
        Me.lblResponse.AutoSize = True
        Me.lblResponse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResponse.Location = New System.Drawing.Point(229, 14)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(96, 13)
        Me.lblResponse.TabIndex = 1
        Me.lblResponse.Tag = "Response_Variable"
        Me.lblResponse.Text = "Response Variable"
        '
        'lblSecondExplanatoryVariable
        '
        Me.lblSecondExplanatoryVariable.AutoSize = True
        Me.lblSecondExplanatoryVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondExplanatoryVariable.Location = New System.Drawing.Point(229, 154)
        Me.lblSecondExplanatoryVariable.Name = "lblSecondExplanatoryVariable"
        Me.lblSecondExplanatoryVariable.Size = New System.Drawing.Size(143, 13)
        Me.lblSecondExplanatoryVariable.TabIndex = 8
        Me.lblSecondExplanatoryVariable.Tag = "Second_Explanatory_Variable"
        Me.lblSecondExplanatoryVariable.Text = "Second Explanatory Variable"
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(286, 268)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(122, 23)
        Me.cmdDisplayOptions.TabIndex = 16
        Me.cmdDisplayOptions.Tag = "Display_Options"
        Me.cmdDisplayOptions.Text = "Display Options..."
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'lblModelPreview
        '
        Me.lblModelPreview.AutoSize = True
        Me.lblModelPreview.Location = New System.Drawing.Point(6, 249)
        Me.lblModelPreview.Name = "lblModelPreview"
        Me.lblModelPreview.Size = New System.Drawing.Size(80, 13)
        Me.lblModelPreview.TabIndex = 10
        Me.lblModelPreview.Tag = "Model_Preview"
        Me.lblModelPreview.Text = "Model Preview:"
        '
        'cmdModelOptions
        '
        Me.cmdModelOptions.Location = New System.Drawing.Point(286, 214)
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.Size = New System.Drawing.Size(122, 23)
        Me.cmdModelOptions.TabIndex = 13
        Me.cmdModelOptions.Tag = "Model_Options"
        Me.cmdModelOptions.Text = "Model Options..."
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'chkConvertToVariate
        '
        Me.chkConvertToVariate.AutoSize = True
        Me.chkConvertToVariate.Location = New System.Drawing.Point(375, 32)
        Me.chkConvertToVariate.Name = "chkConvertToVariate"
        Me.chkConvertToVariate.Size = New System.Drawing.Size(111, 17)
        Me.chkConvertToVariate.TabIndex = 3
        Me.chkConvertToVariate.Tag = "Convert_to_Variate"
        Me.chkConvertToVariate.Text = "Convert to Variate"
        Me.chkConvertToVariate.UseVisualStyleBackColor = True
        '
        'chkFirstFunction
        '
        Me.chkFirstFunction.AutoSize = True
        Me.chkFirstFunction.Location = New System.Drawing.Point(375, 85)
        Me.chkFirstFunction.Name = "chkFirstFunction"
        Me.chkFirstFunction.Size = New System.Drawing.Size(67, 17)
        Me.chkFirstFunction.TabIndex = 6
        Me.chkFirstFunction.Tag = "Function"
        Me.chkFirstFunction.Text = "Function"
        Me.chkFirstFunction.UseVisualStyleBackColor = True
        '
        'ucrModelPreview
        '
        Me.ucrModelPreview.IsReadOnly = False
        Me.ucrModelPreview.Location = New System.Drawing.Point(91, 243)
        Me.ucrModelPreview.Name = "ucrModelPreview"
        Me.ucrModelPreview.Size = New System.Drawing.Size(176, 21)
        Me.ucrModelPreview.TabIndex = 11
        '
        'ucrFamily
        '
        Me.ucrFamily.Location = New System.Drawing.Point(9, 203)
        Me.ucrFamily.Name = "ucrFamily"
        Me.ucrFamily.Size = New System.Drawing.Size(225, 43)
        Me.ucrFamily.TabIndex = 12
        '
        'ucrSecondExplanatory
        '
        Me.ucrSecondExplanatory.Location = New System.Drawing.Point(232, 168)
        Me.ucrSecondExplanatory.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondExplanatory.Name = "ucrSecondExplanatory"
        Me.ucrSecondExplanatory.Selector = Nothing
        Me.ucrSecondExplanatory.Size = New System.Drawing.Size(140, 26)
        Me.ucrSecondExplanatory.TabIndex = 9
        '
        'ucrFirstExplanatory
        '
        Me.ucrFirstExplanatory.Location = New System.Drawing.Point(232, 83)
        Me.ucrFirstExplanatory.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFirstExplanatory.Name = "ucrFirstExplanatory"
        Me.ucrFirstExplanatory.Selector = Nothing
        Me.ucrFirstExplanatory.Size = New System.Drawing.Size(140, 26)
        Me.ucrFirstExplanatory.TabIndex = 5
        '
        'ucrResponse
        '
        Me.ucrResponse.Location = New System.Drawing.Point(232, 29)
        Me.ucrResponse.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrResponse.Name = "ucrResponse"
        Me.ucrResponse.Selector = Nothing
        Me.ucrResponse.Size = New System.Drawing.Size(140, 26)
        Me.ucrResponse.TabIndex = 2
        '
        'ucrSelectorThreeVariableModelling
        '
        Me.ucrSelectorThreeVariableModelling.bShowHiddenColumns = False
        Me.ucrSelectorThreeVariableModelling.bUseCurrentFilter = False
        Me.ucrSelectorThreeVariableModelling.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorThreeVariableModelling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorThreeVariableModelling.Name = "ucrSelectorThreeVariableModelling"
        Me.ucrSelectorThreeVariableModelling.Size = New System.Drawing.Size(214, 185)
        Me.ucrSelectorThreeVariableModelling.TabIndex = 0
        '
        'ucrBaseThreeVariableModelling
        '
        Me.ucrBaseThreeVariableModelling.Location = New System.Drawing.Point(9, 297)
        Me.ucrBaseThreeVariableModelling.Name = "ucrBaseThreeVariableModelling"
        Me.ucrBaseThreeVariableModelling.Size = New System.Drawing.Size(404, 54)
        Me.ucrBaseThreeVariableModelling.TabIndex = 17
        '
        'chkSecondFunction
        '
        Me.chkSecondFunction.AutoSize = True
        Me.chkSecondFunction.Location = New System.Drawing.Point(375, 168)
        Me.chkSecondFunction.Name = "chkSecondFunction"
        Me.chkSecondFunction.Size = New System.Drawing.Size(67, 17)
        Me.chkSecondFunction.TabIndex = 18
        Me.chkSecondFunction.Tag = "Function"
        Me.chkSecondFunction.Text = "Function"
        Me.chkSecondFunction.UseVisualStyleBackColor = True
        '
        'ucrModelName
        '
        Me.ucrModelName.IsReadOnly = False
        Me.ucrModelName.Location = New System.Drawing.Point(91, 270)
        Me.ucrModelName.Name = "ucrModelName"
        Me.ucrModelName.Size = New System.Drawing.Size(176, 21)
        Me.ucrModelName.TabIndex = 19
        '
        'ucrModelOperator
        '
        Me.ucrModelOperator.IsReadOnly = False
        Me.ucrModelOperator.Location = New System.Drawing.Point(315, 121)
        Me.ucrModelOperator.Name = "ucrModelOperator"
        Me.ucrModelOperator.Size = New System.Drawing.Size(39, 21)
        Me.ucrModelOperator.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Model Operator:"
        '
        'chkResponseFunction
        '
        Me.chkResponseFunction.AutoSize = True
        Me.chkResponseFunction.Location = New System.Drawing.Point(375, 32)
        Me.chkResponseFunction.Name = "chkResponseFunction"
        Me.chkResponseFunction.Size = New System.Drawing.Size(67, 17)
        Me.chkResponseFunction.TabIndex = 22
        Me.chkResponseFunction.Text = "Function"
        Me.chkResponseFunction.UseVisualStyleBackColor = True
        '
        'dlgThreeVariableModelling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 353)
        Me.Controls.Add(Me.chkResponseFunction)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrModelOperator)
        Me.Controls.Add(Me.ucrModelName)
        Me.Controls.Add(Me.chkSecondFunction)
        Me.Controls.Add(Me.chkFirstFunction)
        Me.Controls.Add(Me.chkConvertToVariate)
        Me.Controls.Add(Me.cmdModelOptions)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.ucrModelPreview)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrFamily)
        Me.Controls.Add(Me.lblSecondExplanatoryVariable)
        Me.Controls.Add(Me.ucrSecondExplanatory)
        Me.Controls.Add(Me.chkSaveModel)
        Me.Controls.Add(Me.lblFirstExplanatoryVariable)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.ucrFirstExplanatory)
        Me.Controls.Add(Me.ucrResponse)
        Me.Controls.Add(Me.ucrSelectorThreeVariableModelling)
        Me.Controls.Add(Me.ucrBaseThreeVariableModelling)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgThreeVariableModelling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Three_Variable_Modelling"
        Me.Text = "Three Variable Modelling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseThreeVariableModelling As ucrButtons
    Friend WithEvents chkSaveModel As CheckBox
    Friend WithEvents lblFirstExplanatoryVariable As Label
    Friend WithEvents lblResponse As Label
    Friend WithEvents ucrFirstExplanatory As ucrReceiverSingle
    Friend WithEvents ucrResponse As ucrReceiverSingle
    Friend WithEvents ucrSelectorThreeVariableModelling As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblSecondExplanatoryVariable As Label
    Friend WithEvents ucrSecondExplanatory As ucrReceiverSingle
    Friend WithEvents ucrFamily As ucrDistributions
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents ucrModelPreview As ucrInputTextBox
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents cmdModelOptions As Button
    Friend WithEvents chkConvertToVariate As CheckBox
    Friend WithEvents chkFirstFunction As CheckBox
    Friend WithEvents chkSecondFunction As CheckBox
    Friend WithEvents ucrModelName As ucrInputComboBox
    Friend WithEvents ucrModelOperator As ucrInputComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkResponseFunction As CheckBox
End Class
