<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgSimpleWithGroups
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
        Me.lblExplanatory = New System.Windows.Forms.Label()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.lblGroupingFactor = New System.Windows.Forms.Label()
        Me.grpModelsOperators = New System.Windows.Forms.GroupBox()
        Me.cmdJointLines = New System.Windows.Forms.Button()
        Me.cmdConditional = New System.Windows.Forms.Button()
        Me.cmdCommonIntercept = New System.Windows.Forms.Button()
        Me.cmdParallelLines = New System.Windows.Forms.Button()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.ucrModelPreview = New instat.ucrInputTextBox()
        Me.ucrFamily = New instat.ucrDistributions()
        Me.ucrGroupingFactor = New instat.ucrReceiverSingle()
        Me.ucrModelName = New instat.ucrVariableName()
        Me.ucrExplanatory = New instat.ucrReceiverSingle()
        Me.ucrResponse = New instat.ucrReceiverSingle()
        Me.ucrSelectorSimpleRegGroups = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseRegWithGroups = New instat.ucrButtons()
        Me.cmdModelOptions = New System.Windows.Forms.Button()
        Me.chkConvertToVariate = New System.Windows.Forms.CheckBox()
        Me.chkFunction = New System.Windows.Forms.CheckBox()
        Me.grpModelsOperators.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkSaveModel
        '
        Me.chkSaveModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkSaveModel.Location = New System.Drawing.Point(8, 249)
        Me.chkSaveModel.Name = "chkSaveModel"
        Me.chkSaveModel.Size = New System.Drawing.Size(104, 24)
        Me.chkSaveModel.TabIndex = 14
        Me.chkSaveModel.Tag = "Save_Model"
        Me.chkSaveModel.Text = "Save Model"
        Me.chkSaveModel.UseVisualStyleBackColor = True
        '
        'lblExplanatory
        '
        Me.lblExplanatory.AutoSize = True
        Me.lblExplanatory.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExplanatory.Location = New System.Drawing.Point(242, 57)
        Me.lblExplanatory.Name = "lblExplanatory"
        Me.lblExplanatory.Size = New System.Drawing.Size(103, 13)
        Me.lblExplanatory.TabIndex = 4
        Me.lblExplanatory.Tag = "Explanatory_Variable"
        Me.lblExplanatory.Text = "Explanatory Variable"
        '
        'lblResponse
        '
        Me.lblResponse.AutoSize = True
        Me.lblResponse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResponse.Location = New System.Drawing.Point(245, 10)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(96, 13)
        Me.lblResponse.TabIndex = 1
        Me.lblResponse.Tag = "Response_Variable"
        Me.lblResponse.Text = "Response Variable"
        '
        'lblGroupingFactor
        '
        Me.lblGroupingFactor.AutoSize = True
        Me.lblGroupingFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroupingFactor.Location = New System.Drawing.Point(247, 154)
        Me.lblGroupingFactor.Name = "lblGroupingFactor"
        Me.lblGroupingFactor.Size = New System.Drawing.Size(83, 13)
        Me.lblGroupingFactor.TabIndex = 8
        Me.lblGroupingFactor.Tag = "Grouping_Factor"
        Me.lblGroupingFactor.Text = "Grouping Factor"
        '
        'grpModelsOperators
        '
        Me.grpModelsOperators.Controls.Add(Me.cmdJointLines)
        Me.grpModelsOperators.Controls.Add(Me.cmdConditional)
        Me.grpModelsOperators.Controls.Add(Me.cmdCommonIntercept)
        Me.grpModelsOperators.Controls.Add(Me.cmdParallelLines)
        Me.grpModelsOperators.Location = New System.Drawing.Point(243, 103)
        Me.grpModelsOperators.Name = "grpModelsOperators"
        Me.grpModelsOperators.Size = New System.Drawing.Size(149, 46)
        Me.grpModelsOperators.TabIndex = 7
        Me.grpModelsOperators.TabStop = False
        Me.grpModelsOperators.Tag = "Models_Operators"
        Me.grpModelsOperators.Text = "Models Operators"
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
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(285, 248)
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
        Me.lblModelPreview.Location = New System.Drawing.Point(13, 192)
        Me.lblModelPreview.Name = "lblModelPreview"
        Me.lblModelPreview.Size = New System.Drawing.Size(77, 13)
        Me.lblModelPreview.TabIndex = 10
        Me.lblModelPreview.Tag = "Model_Preview"
        Me.lblModelPreview.Text = "Model Preview"
        '
        'ucrModelPreview
        '
        Me.ucrModelPreview.Location = New System.Drawing.Point(93, 187)
        Me.ucrModelPreview.Name = "ucrModelPreview"
        Me.ucrModelPreview.Size = New System.Drawing.Size(142, 21)
        Me.ucrModelPreview.TabIndex = 11
        '
        'ucrFamily
        '
        Me.ucrFamily.Location = New System.Drawing.Point(8, 204)
        Me.ucrFamily.Name = "ucrFamily"
        Me.ucrFamily.Size = New System.Drawing.Size(225, 43)
        Me.ucrFamily.TabIndex = 12
        '
        'ucrGroupingFactor
        '
        Me.ucrGroupingFactor.Location = New System.Drawing.Point(245, 168)
        Me.ucrGroupingFactor.Name = "ucrGroupingFactor"
        Me.ucrGroupingFactor.Selector = Nothing
        Me.ucrGroupingFactor.Size = New System.Drawing.Size(106, 26)
        Me.ucrGroupingFactor.TabIndex = 9
        '
        'ucrModelName
        '
        Me.ucrModelName.Location = New System.Drawing.Point(116, 247)
        Me.ucrModelName.Name = "ucrModelName"
        Me.ucrModelName.Size = New System.Drawing.Size(149, 23)
        Me.ucrModelName.TabIndex = 15
        '
        'ucrExplanatory
        '
        Me.ucrExplanatory.Location = New System.Drawing.Point(240, 73)
        Me.ucrExplanatory.Name = "ucrExplanatory"
        Me.ucrExplanatory.Selector = Nothing
        Me.ucrExplanatory.Size = New System.Drawing.Size(106, 26)
        Me.ucrExplanatory.TabIndex = 5
        '
        'ucrResponse
        '
        Me.ucrResponse.Location = New System.Drawing.Point(240, 26)
        Me.ucrResponse.Name = "ucrResponse"
        Me.ucrResponse.Selector = Nothing
        Me.ucrResponse.Size = New System.Drawing.Size(106, 26)
        Me.ucrResponse.TabIndex = 2
        '
        'ucrSelectorSimpleRegGroups
        '
        Me.ucrSelectorSimpleRegGroups.Location = New System.Drawing.Point(3, 5)
        Me.ucrSelectorSimpleRegGroups.Name = "ucrSelectorSimpleRegGroups"
        Me.ucrSelectorSimpleRegGroups.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorSimpleRegGroups.TabIndex = 0
        '
        'ucrBaseRegWithGroups
        '
        Me.ucrBaseRegWithGroups.Location = New System.Drawing.Point(3, 277)
        Me.ucrBaseRegWithGroups.Name = "ucrBaseRegWithGroups"
        Me.ucrBaseRegWithGroups.Size = New System.Drawing.Size(410, 55)
        Me.ucrBaseRegWithGroups.TabIndex = 17
        '
        'cmdModelOptions
        '
        Me.cmdModelOptions.Location = New System.Drawing.Point(282, 213)
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
        Me.chkConvertToVariate.Location = New System.Drawing.Point(349, 26)
        Me.chkConvertToVariate.Name = "chkConvertToVariate"
        Me.chkConvertToVariate.Size = New System.Drawing.Size(71, 30)
        Me.chkConvertToVariate.TabIndex = 3
        Me.chkConvertToVariate.Tag = "Convert_to_Variate"
        Me.chkConvertToVariate.Text = "Convert " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to Variate"
        Me.chkConvertToVariate.UseVisualStyleBackColor = True
        '
        'chkFunction
        '
        Me.chkFunction.AutoSize = True
        Me.chkFunction.Location = New System.Drawing.Point(349, 69)
        Me.chkFunction.Name = "chkFunction"
        Me.chkFunction.Size = New System.Drawing.Size(67, 17)
        Me.chkFunction.TabIndex = 6
        Me.chkFunction.Tag = "Function"
        Me.chkFunction.Text = "Function"
        Me.chkFunction.UseVisualStyleBackColor = True
        '
        'dlgSimpleWithGroups
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 329)
        Me.Controls.Add(Me.chkFunction)
        Me.Controls.Add(Me.chkConvertToVariate)
        Me.Controls.Add(Me.cmdModelOptions)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.ucrModelPreview)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrFamily)
        Me.Controls.Add(Me.grpModelsOperators)
        Me.Controls.Add(Me.lblGroupingFactor)
        Me.Controls.Add(Me.ucrGroupingFactor)
        Me.Controls.Add(Me.chkSaveModel)
        Me.Controls.Add(Me.ucrModelName)
        Me.Controls.Add(Me.lblExplanatory)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.ucrExplanatory)
        Me.Controls.Add(Me.ucrResponse)
        Me.Controls.Add(Me.ucrSelectorSimpleRegGroups)
        Me.Controls.Add(Me.ucrBaseRegWithGroups)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgSimpleWithGroups"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple with groups"
        Me.grpModelsOperators.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseRegWithGroups As ucrButtons
    Friend WithEvents chkSaveModel As CheckBox
    Friend WithEvents ucrModelName As ucrVariableName
    Friend WithEvents lblExplanatory As Label
    Friend WithEvents lblResponse As Label
    Friend WithEvents ucrExplanatory As ucrReceiverSingle
    Friend WithEvents ucrResponse As ucrReceiverSingle
    Friend WithEvents ucrSelectorSimpleRegGroups As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblGroupingFactor As Label
    Friend WithEvents ucrGroupingFactor As ucrReceiverSingle
    Friend WithEvents grpModelsOperators As GroupBox
    Friend WithEvents ucrFamily As ucrDistributions
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents cmdJointLines As Button
    Friend WithEvents cmdConditional As Button
    Friend WithEvents cmdCommonIntercept As Button
    Friend WithEvents cmdParallelLines As Button
    Friend WithEvents ucrModelPreview As ucrInputTextBox
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents cmdModelOptions As Button
    Friend WithEvents chkConvertToVariate As CheckBox
    Friend WithEvents chkFunction As CheckBox
End Class
