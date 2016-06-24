<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgFourVariableModelling
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
        Me.ucrBaseFourVariableModelling = New instat.ucrButtons()
        Me.chkFirstFunction = New System.Windows.Forms.CheckBox()
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
        Me.lblFirstExplanatoryVariable = New System.Windows.Forms.Label()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.ucrFirstExplanatory = New instat.ucrReceiverSingle()
        Me.ucrResponse = New instat.ucrReceiverSingle()
        Me.ucrSelectorFourVariableModelling = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblSecondRandomEffect = New System.Windows.Forms.Label()
        Me.ucrSecondRandomEffect = New instat.ucrReceiverSingle()
        Me.ucrModelName = New instat.ucrInputComboBox()
        Me.grpModelOperators.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBaseFourVariableModelling
        '
        Me.ucrBaseFourVariableModelling.Location = New System.Drawing.Point(9, 313)
        Me.ucrBaseFourVariableModelling.Name = "ucrBaseFourVariableModelling"
        Me.ucrBaseFourVariableModelling.Size = New System.Drawing.Size(405, 52)
        Me.ucrBaseFourVariableModelling.TabIndex = 0
        '
        'chkFirstFunction
        '
        Me.chkFirstFunction.AutoSize = True
        Me.chkFirstFunction.Location = New System.Drawing.Point(273, 100)
        Me.chkFirstFunction.Name = "chkFirstFunction"
        Me.chkFirstFunction.Size = New System.Drawing.Size(67, 17)
        Me.chkFirstFunction.TabIndex = 23
        Me.chkFirstFunction.Tag = "Function"
        Me.chkFirstFunction.Text = "Function"
        Me.chkFirstFunction.UseVisualStyleBackColor = True
        '
        'chkConvertToVariate
        '
        Me.chkConvertToVariate.AutoSize = True
        Me.chkConvertToVariate.Location = New System.Drawing.Point(273, 39)
        Me.chkConvertToVariate.Name = "chkConvertToVariate"
        Me.chkConvertToVariate.Size = New System.Drawing.Size(111, 17)
        Me.chkConvertToVariate.TabIndex = 20
        Me.chkConvertToVariate.Tag = "Convert_to_Variate"
        Me.chkConvertToVariate.Text = "Convert to Variate"
        Me.chkConvertToVariate.UseVisualStyleBackColor = True
        '
        'cmdModelOptions
        '
        Me.cmdModelOptions.Location = New System.Drawing.Point(273, 254)
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.Size = New System.Drawing.Size(106, 23)
        Me.cmdModelOptions.TabIndex = 30
        Me.cmdModelOptions.Tag = "Model_Options"
        Me.cmdModelOptions.Text = "Model Options..."
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'lblModelPreview
        '
        Me.lblModelPreview.AutoSize = True
        Me.lblModelPreview.Location = New System.Drawing.Point(7, 229)
        Me.lblModelPreview.Name = "lblModelPreview"
        Me.lblModelPreview.Size = New System.Drawing.Size(77, 13)
        Me.lblModelPreview.TabIndex = 27
        Me.lblModelPreview.Tag = "Model_Preview"
        Me.lblModelPreview.Text = "Model Preview"
        '
        'ucrModelPreview
        '
        Me.ucrModelPreview.IsReadOnly = False
        Me.ucrModelPreview.Location = New System.Drawing.Point(94, 226)
        Me.ucrModelPreview.Name = "ucrModelPreview"
        Me.ucrModelPreview.Size = New System.Drawing.Size(142, 21)
        Me.ucrModelPreview.TabIndex = 28
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(273, 285)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(106, 23)
        Me.cmdDisplayOptions.TabIndex = 33
        Me.cmdDisplayOptions.Tag = "Display_Options"
        Me.cmdDisplayOptions.Text = "Display Options..."
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'ucrFamily
        '
        Me.ucrFamily.Location = New System.Drawing.Point(5, 245)
        Me.ucrFamily.Name = "ucrFamily"
        Me.ucrFamily.Size = New System.Drawing.Size(225, 35)
        Me.ucrFamily.TabIndex = 29
        '
        'grpModelOperators
        '
        Me.grpModelOperators.Controls.Add(Me.cmdJointLines)
        Me.grpModelOperators.Controls.Add(Me.cmdConditional)
        Me.grpModelOperators.Controls.Add(Me.cmdCommonIntercept)
        Me.grpModelOperators.Controls.Add(Me.cmdParallelLines)
        Me.grpModelOperators.Location = New System.Drawing.Point(273, 120)
        Me.grpModelOperators.Name = "grpModelOperators"
        Me.grpModelOperators.Size = New System.Drawing.Size(142, 44)
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
        Me.lblFirstRandomEffect.Location = New System.Drawing.Point(273, 169)
        Me.lblFirstRandomEffect.Name = "lblFirstRandomEffect"
        Me.lblFirstRandomEffect.Size = New System.Drawing.Size(100, 13)
        Me.lblFirstRandomEffect.TabIndex = 25
        Me.lblFirstRandomEffect.Tag = "First_Random_Effect"
        Me.lblFirstRandomEffect.Text = "First Random Effect"
        '
        'ucrFirstRandomEffect
        '
        Me.ucrFirstRandomEffect.Location = New System.Drawing.Point(273, 187)
        Me.ucrFirstRandomEffect.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFirstRandomEffect.Name = "ucrFirstRandomEffect"
        Me.ucrFirstRandomEffect.Selector = Nothing
        Me.ucrFirstRandomEffect.Size = New System.Drawing.Size(106, 26)
        Me.ucrFirstRandomEffect.TabIndex = 26
        '
        'chkSaveModel
        '
        Me.chkSaveModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkSaveModel.Location = New System.Drawing.Point(10, 286)
        Me.chkSaveModel.Name = "chkSaveModel"
        Me.chkSaveModel.Size = New System.Drawing.Size(104, 24)
        Me.chkSaveModel.TabIndex = 31
        Me.chkSaveModel.Tag = "Save_Model"
        Me.chkSaveModel.Text = "Save Model"
        Me.chkSaveModel.UseVisualStyleBackColor = True
        '
        'lblFirstExplanatoryVariable
        '
        Me.lblFirstExplanatoryVariable.AutoSize = True
        Me.lblFirstExplanatoryVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstExplanatoryVariable.Location = New System.Drawing.Point(273, 60)
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
        Me.lblResponse.Location = New System.Drawing.Point(273, 0)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(96, 13)
        Me.lblResponse.TabIndex = 18
        Me.lblResponse.Tag = "Response_Variable"
        Me.lblResponse.Text = "Response Variable"
        '
        'ucrFirstExplanatory
        '
        Me.ucrFirstExplanatory.Location = New System.Drawing.Point(273, 76)
        Me.ucrFirstExplanatory.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFirstExplanatory.Name = "ucrFirstExplanatory"
        Me.ucrFirstExplanatory.Selector = Nothing
        Me.ucrFirstExplanatory.Size = New System.Drawing.Size(106, 26)
        Me.ucrFirstExplanatory.TabIndex = 22
        '
        'ucrResponse
        '
        Me.ucrResponse.Location = New System.Drawing.Point(273, 14)
        Me.ucrResponse.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrResponse.Name = "ucrResponse"
        Me.ucrResponse.Selector = Nothing
        Me.ucrResponse.Size = New System.Drawing.Size(106, 26)
        Me.ucrResponse.TabIndex = 19
        '
        'ucrSelectorFourVariableModelling
        '
        Me.ucrSelectorFourVariableModelling.bShowHiddenColumns = False
        Me.ucrSelectorFourVariableModelling.Location = New System.Drawing.Point(11, 9)
        Me.ucrSelectorFourVariableModelling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFourVariableModelling.Name = "ucrSelectorFourVariableModelling"
        Me.ucrSelectorFourVariableModelling.Size = New System.Drawing.Size(225, 208)
        Me.ucrSelectorFourVariableModelling.TabIndex = 17
        '
        'lblSecondRandomEffect
        '
        Me.lblSecondRandomEffect.AutoSize = True
        Me.lblSecondRandomEffect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondRandomEffect.Location = New System.Drawing.Point(273, 212)
        Me.lblSecondRandomEffect.Name = "lblSecondRandomEffect"
        Me.lblSecondRandomEffect.Size = New System.Drawing.Size(118, 13)
        Me.lblSecondRandomEffect.TabIndex = 34
        Me.lblSecondRandomEffect.Tag = "Second_Random_Effect"
        Me.lblSecondRandomEffect.Text = "Second Random Effect"
        '
        'ucrSecondRandomEffect
        '
        Me.ucrSecondRandomEffect.Location = New System.Drawing.Point(273, 229)
        Me.ucrSecondRandomEffect.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondRandomEffect.Name = "ucrSecondRandomEffect"
        Me.ucrSecondRandomEffect.Selector = Nothing
        Me.ucrSecondRandomEffect.Size = New System.Drawing.Size(106, 26)
        Me.ucrSecondRandomEffect.TabIndex = 35
        '
        'ucrModelName
        '
        Me.ucrModelName.IsReadOnly = False
        Me.ucrModelName.Location = New System.Drawing.Point(126, 286)
        Me.ucrModelName.Name = "ucrModelName"
        Me.ucrModelName.Size = New System.Drawing.Size(122, 21)
        Me.ucrModelName.TabIndex = 36
        '
        'dlgFourVariableModelling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 368)
        Me.Controls.Add(Me.ucrModelName)
        Me.Controls.Add(Me.lblSecondRandomEffect)
        Me.Controls.Add(Me.ucrSecondRandomEffect)
        Me.Controls.Add(Me.chkFirstFunction)
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
        Me.Controls.Add(Me.lblFirstExplanatoryVariable)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.ucrFirstExplanatory)
        Me.Controls.Add(Me.ucrResponse)
        Me.Controls.Add(Me.ucrSelectorFourVariableModelling)
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
    Friend WithEvents chkFirstFunction As CheckBox
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
    Friend WithEvents lblFirstExplanatoryVariable As Label
    Friend WithEvents lblResponse As Label
    Friend WithEvents ucrFirstExplanatory As ucrReceiverSingle
    Friend WithEvents ucrResponse As ucrReceiverSingle
    Friend WithEvents ucrSelectorFourVariableModelling As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblSecondRandomEffect As Label
    Friend WithEvents ucrSecondRandomEffect As ucrReceiverSingle
    Friend WithEvents ucrModelName As ucrInputComboBox
End Class
