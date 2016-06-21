<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFourVariableModelling
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
        Me.ucrBaseFourVariableModelling = New instat.ucrButtons()
        Me.chkFunction = New System.Windows.Forms.CheckBox()
        Me.chkConvertToVariate = New System.Windows.Forms.CheckBox()
        Me.cmdModelOptions = New System.Windows.Forms.Button()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.ucrModelPreview = New instat.ucrInputTextBox()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.ucrFamily = New instat.ucrDistributions()
        Me.grpModelOperators = New System.Windows.Forms.GroupBox()
        Me.cmdJointLines = New System.Windows.Forms.Button()
        Me.cmdConditional = New System.Windows.Forms.Button()
        Me.cmdCommonIntercept = New System.Windows.Forms.Button()
        Me.cmdParallelLines = New System.Windows.Forms.Button()
        Me.lblFirstRandomEffect = New System.Windows.Forms.Label()
        Me.ucrFirstRandomEffect = New instat.ucrReceiverSingle()
        Me.chkSaveModel = New System.Windows.Forms.CheckBox()
        Me.ucrModelName = New instat.ucrVariableName()
        Me.lblFirstExplanatoryVariable = New System.Windows.Forms.Label()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.ucrFirstExplanatory = New instat.ucrReceiverSingle()
        Me.ucrResponse = New instat.ucrReceiverSingle()
        Me.ucrSelectorThreeVariableModelling = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblSecondRandomEffect = New System.Windows.Forms.Label()
        Me.ucrSecondRandomEffect = New instat.ucrReceiverSingle()
        Me.grpModelOperators.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBaseFourVariableModelling
        '
        Me.ucrBaseFourVariableModelling.Location = New System.Drawing.Point(3, 281)
        Me.ucrBaseFourVariableModelling.Name = "ucrBaseFourVariableModelling"
        Me.ucrBaseFourVariableModelling.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseFourVariableModelling.TabIndex = 0
        '
        'chkFunction
        '
        Me.chkFunction.AutoSize = True
        Me.chkFunction.Location = New System.Drawing.Point(353, 58)
        Me.chkFunction.Name = "chkFunction"
        Me.chkFunction.Size = New System.Drawing.Size(67, 17)
        Me.chkFunction.TabIndex = 23
        Me.chkFunction.Tag = "Function"
        Me.chkFunction.Text = "Function"
        Me.chkFunction.UseVisualStyleBackColor = True
        '
        'chkConvertToVariate
        '
        Me.chkConvertToVariate.AutoSize = True
        Me.chkConvertToVariate.Location = New System.Drawing.Point(353, 11)
        Me.chkConvertToVariate.Name = "chkConvertToVariate"
        Me.chkConvertToVariate.Size = New System.Drawing.Size(71, 30)
        Me.chkConvertToVariate.TabIndex = 20
        Me.chkConvertToVariate.Tag = "Convert_to_Variate"
        Me.chkConvertToVariate.Text = "Convert " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to Variate"
        Me.chkConvertToVariate.UseVisualStyleBackColor = True
        '
        'cmdModelOptions
        '
        Me.cmdModelOptions.Location = New System.Drawing.Point(286, 223)
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.Size = New System.Drawing.Size(122, 23)
        Me.cmdModelOptions.TabIndex = 30
        Me.cmdModelOptions.Tag = "Model_Options"
        Me.cmdModelOptions.Text = "Model Options..."
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'lblModelPreview
        '
        Me.lblModelPreview.AutoSize = True
        Me.lblModelPreview.Location = New System.Drawing.Point(17, 188)
        Me.lblModelPreview.Name = "lblModelPreview"
        Me.lblModelPreview.Size = New System.Drawing.Size(77, 13)
        Me.lblModelPreview.TabIndex = 27
        Me.lblModelPreview.Tag = "Model_Preview"
        Me.lblModelPreview.Text = "Model Preview"
        '
        'ucrModelPreview
        '
        Me.ucrModelPreview.IsReadOnly = False
        Me.ucrModelPreview.Location = New System.Drawing.Point(97, 183)
        Me.ucrModelPreview.Name = "ucrModelPreview"
        Me.ucrModelPreview.Size = New System.Drawing.Size(142, 21)
        Me.ucrModelPreview.TabIndex = 28
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(289, 252)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(122, 23)
        Me.cmdDisplayOptions.TabIndex = 33
        Me.cmdDisplayOptions.Tag = "Display_Options"
        Me.cmdDisplayOptions.Text = "Display Options..."
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'ucrFamily
        '
        Me.ucrFamily.Location = New System.Drawing.Point(12, 206)
        Me.ucrFamily.Name = "ucrFamily"
        Me.ucrFamily.Size = New System.Drawing.Size(225, 43)
        Me.ucrFamily.TabIndex = 29
        '
        'grpModelOperators
        '
        Me.grpModelOperators.Controls.Add(Me.cmdJointLines)
        Me.grpModelOperators.Controls.Add(Me.cmdConditional)
        Me.grpModelOperators.Controls.Add(Me.cmdCommonIntercept)
        Me.grpModelOperators.Controls.Add(Me.cmdParallelLines)
        Me.grpModelOperators.Location = New System.Drawing.Point(242, 82)
        Me.grpModelOperators.Name = "grpModelOperators"
        Me.grpModelOperators.Size = New System.Drawing.Size(149, 46)
        Me.grpModelOperators.TabIndex = 24
        Me.grpModelOperators.TabStop = False
        Me.grpModelOperators.Tag = "Model_Operators"
        Me.grpModelOperators.Text = "Model Operators"
        '
        'cmdJointLines
        '
        Me.cmdJointLines.Location = New System.Drawing.Point(75, 14)
        Me.cmdJointLines.Name = "cmdJointLines"
        Me.cmdJointLines.Size = New System.Drawing.Size(28, 23)
        Me.cmdJointLines.TabIndex = 2
        Me.cmdJointLines.Tag = "*"
        Me.cmdJointLines.Text = "*"
        Me.cmdJointLines.UseVisualStyleBackColor = True
        '
        'cmdConditional
        '
        Me.cmdConditional.Location = New System.Drawing.Point(41, 14)
        Me.cmdConditional.Name = "cmdConditional"
        Me.cmdConditional.Size = New System.Drawing.Size(27, 23)
        Me.cmdConditional.TabIndex = 1
        Me.cmdConditional.Text = ":"
        Me.cmdConditional.UseVisualStyleBackColor = True
        '
        'cmdCommonIntercept
        '
        Me.cmdCommonIntercept.Location = New System.Drawing.Point(110, 14)
        Me.cmdCommonIntercept.Name = "cmdCommonIntercept"
        Me.cmdCommonIntercept.Size = New System.Drawing.Size(27, 23)
        Me.cmdCommonIntercept.TabIndex = 3
        Me.cmdCommonIntercept.Tag = "/"
        Me.cmdCommonIntercept.Text = "/"
        Me.cmdCommonIntercept.UseVisualStyleBackColor = True
        '
        'cmdParallelLines
        '
        Me.cmdParallelLines.Location = New System.Drawing.Point(7, 14)
        Me.cmdParallelLines.Name = "cmdParallelLines"
        Me.cmdParallelLines.Size = New System.Drawing.Size(28, 23)
        Me.cmdParallelLines.TabIndex = 0
        Me.cmdParallelLines.Tag = "+"
        Me.cmdParallelLines.Text = "+"
        Me.cmdParallelLines.UseVisualStyleBackColor = True
        '
        'lblFirstRandomEffect
        '
        Me.lblFirstRandomEffect.AutoSize = True
        Me.lblFirstRandomEffect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstRandomEffect.Location = New System.Drawing.Point(257, 135)
        Me.lblFirstRandomEffect.Name = "lblFirstRandomEffect"
        Me.lblFirstRandomEffect.Size = New System.Drawing.Size(100, 13)
        Me.lblFirstRandomEffect.TabIndex = 25
        Me.lblFirstRandomEffect.Tag = "First_Random_Effect"
        Me.lblFirstRandomEffect.Text = "First Random Effect"
        '
        'ucrFirstRandomEffect
        '
        Me.ucrFirstRandomEffect.Location = New System.Drawing.Point(258, 152)
        Me.ucrFirstRandomEffect.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFirstRandomEffect.Name = "ucrFirstRandomEffect"
        Me.ucrFirstRandomEffect.Selector = Nothing
        Me.ucrFirstRandomEffect.Size = New System.Drawing.Size(106, 26)
        Me.ucrFirstRandomEffect.TabIndex = 26
        '
        'chkSaveModel
        '
        Me.chkSaveModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkSaveModel.Location = New System.Drawing.Point(12, 251)
        Me.chkSaveModel.Name = "chkSaveModel"
        Me.chkSaveModel.Size = New System.Drawing.Size(104, 24)
        Me.chkSaveModel.TabIndex = 31
        Me.chkSaveModel.Tag = "Save_Model"
        Me.chkSaveModel.Text = "Save Model"
        Me.chkSaveModel.UseVisualStyleBackColor = True
        '
        'ucrModelName
        '
        Me.ucrModelName.Location = New System.Drawing.Point(120, 249)
        Me.ucrModelName.Name = "ucrModelName"
        Me.ucrModelName.Size = New System.Drawing.Size(149, 23)
        Me.ucrModelName.TabIndex = 32
        '
        'lblFirstExplanatoryVariable
        '
        Me.lblFirstExplanatoryVariable.AutoSize = True
        Me.lblFirstExplanatoryVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstExplanatoryVariable.Location = New System.Drawing.Point(237, 41)
        Me.lblFirstExplanatoryVariable.Name = "lblFirstExplanatoryVariable"
        Me.lblFirstExplanatoryVariable.Size = New System.Drawing.Size(125, 13)
        Me.lblFirstExplanatoryVariable.TabIndex = 21
        Me.lblFirstExplanatoryVariable.Tag = "First_Explanatory_Variable"
        Me.lblFirstExplanatoryVariable.Text = "First Explanatory Variable"
        '
        'lblResponse
        '
        Me.lblResponse.AutoSize = True
        Me.lblResponse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResponse.Location = New System.Drawing.Point(246, 0)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(96, 13)
        Me.lblResponse.TabIndex = 18
        Me.lblResponse.Tag = "Response_Variable"
        Me.lblResponse.Text = "Response Variable"
        '
        'ucrFirstExplanatory
        '
        Me.ucrFirstExplanatory.Location = New System.Drawing.Point(244, 57)
        Me.ucrFirstExplanatory.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFirstExplanatory.Name = "ucrFirstExplanatory"
        Me.ucrFirstExplanatory.Selector = Nothing
        Me.ucrFirstExplanatory.Size = New System.Drawing.Size(106, 26)
        Me.ucrFirstExplanatory.TabIndex = 22
        '
        'ucrResponse
        '
        Me.ucrResponse.Location = New System.Drawing.Point(244, 14)
        Me.ucrResponse.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrResponse.Name = "ucrResponse"
        Me.ucrResponse.Selector = Nothing
        Me.ucrResponse.Size = New System.Drawing.Size(106, 26)
        Me.ucrResponse.TabIndex = 19
        '
        'ucrSelectorThreeVariableModelling
        '
        Me.ucrSelectorThreeVariableModelling.Location = New System.Drawing.Point(7, -4)
        Me.ucrSelectorThreeVariableModelling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorThreeVariableModelling.Name = "ucrSelectorThreeVariableModelling"
        Me.ucrSelectorThreeVariableModelling.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorThreeVariableModelling.TabIndex = 17
        '
        'lblSecondRandomEffect
        '
        Me.lblSecondRandomEffect.AutoSize = True
        Me.lblSecondRandomEffect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondRandomEffect.Location = New System.Drawing.Point(257, 181)
        Me.lblSecondRandomEffect.Name = "lblSecondRandomEffect"
        Me.lblSecondRandomEffect.Size = New System.Drawing.Size(118, 13)
        Me.lblSecondRandomEffect.TabIndex = 34
        Me.lblSecondRandomEffect.Tag = "Second_Random_Effect"
        Me.lblSecondRandomEffect.Text = "Second Random Effect"
        '
        'ucrSecondRandomEffect
        '
        Me.ucrSecondRandomEffect.Location = New System.Drawing.Point(259, 197)
        Me.ucrSecondRandomEffect.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondRandomEffect.Name = "ucrSecondRandomEffect"
        Me.ucrSecondRandomEffect.Selector = Nothing
        Me.ucrSecondRandomEffect.Size = New System.Drawing.Size(106, 26)
        Me.ucrSecondRandomEffect.TabIndex = 35
        '
        'dlgFourVariableModelling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 337)
        Me.Controls.Add(Me.lblSecondRandomEffect)
        Me.Controls.Add(Me.ucrSecondRandomEffect)
        Me.Controls.Add(Me.chkFunction)
        Me.Controls.Add(Me.chkConvertToVariate)
        Me.Controls.Add(Me.cmdModelOptions)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.ucrModelPreview)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrFamily)
        Me.Controls.Add(Me.grpModelOperators)
        Me.Controls.Add(Me.lblFirstRandomEffect)
        Me.Controls.Add(Me.ucrFirstRandomEffect)
        Me.Controls.Add(Me.chkSaveModel)
        Me.Controls.Add(Me.ucrModelName)
        Me.Controls.Add(Me.lblFirstExplanatoryVariable)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.ucrFirstExplanatory)
        Me.Controls.Add(Me.ucrResponse)
        Me.Controls.Add(Me.ucrSelectorThreeVariableModelling)
        Me.Controls.Add(Me.ucrBaseFourVariableModelling)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFourVariableModelling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Four_Variable_Modelling"
        Me.Text = "Four Variable Modelling"
        Me.grpModelOperators.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseFourVariableModelling As ucrButtons
    Friend WithEvents chkFunction As CheckBox
    Friend WithEvents chkConvertToVariate As CheckBox
    Friend WithEvents cmdModelOptions As Button
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents ucrModelPreview As ucrInputTextBox
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents ucrFamily As ucrDistributions
    Friend WithEvents grpModelOperators As GroupBox
    Friend WithEvents cmdJointLines As Button
    Friend WithEvents cmdConditional As Button
    Friend WithEvents cmdCommonIntercept As Button
    Friend WithEvents cmdParallelLines As Button
    Friend WithEvents lblFirstRandomEffect As Label
    Friend WithEvents ucrFirstRandomEffect As ucrReceiverSingle
    Friend WithEvents chkSaveModel As CheckBox
    Friend WithEvents ucrModelName As ucrVariableName
    Friend WithEvents lblFirstExplanatoryVariable As Label
    Friend WithEvents lblResponse As Label
    Friend WithEvents ucrFirstExplanatory As ucrReceiverSingle
    Friend WithEvents ucrResponse As ucrReceiverSingle
    Friend WithEvents ucrSelectorThreeVariableModelling As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblSecondRandomEffect As Label
    Friend WithEvents ucrSecondRandomEffect As ucrReceiverSingle
End Class
