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
        Me.cmdSWGOptions = New System.Windows.Forms.Button()
        Me.ucrModelPreview = New instat.ucrInputTextBox()
        Me.ucrFamily = New instat.ucrDistributions()
        Me.ucrGroupingFactor = New instat.ucrReceiverSingle()
        Me.ucrModelName = New instat.ucrVariableName()
        Me.ucrExplanatory = New instat.ucrReceiverSingle()
        Me.ucrResponse = New instat.ucrReceiverSingle()
        Me.ucrSelectorSimpleRegGroups = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseRegWithGroups = New instat.ucrButtons()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.grpModelsOperators.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkSaveModel
        '
        Me.chkSaveModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkSaveModel.Location = New System.Drawing.Point(8, 249)
        Me.chkSaveModel.Name = "chkSaveModel"
        Me.chkSaveModel.Size = New System.Drawing.Size(104, 24)
        Me.chkSaveModel.TabIndex = 8
        Me.chkSaveModel.Tag = "Save_Model"
        Me.chkSaveModel.Text = "Save Model"
        Me.chkSaveModel.UseVisualStyleBackColor = True
        '
        'lblExplanatory
        '
        Me.lblExplanatory.AutoSize = True
        Me.lblExplanatory.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExplanatory.Location = New System.Drawing.Point(287, 71)
        Me.lblExplanatory.Name = "lblExplanatory"
        Me.lblExplanatory.Size = New System.Drawing.Size(103, 13)
        Me.lblExplanatory.TabIndex = 13
        Me.lblExplanatory.Tag = "Explanatory_Variable"
        Me.lblExplanatory.Text = "Explanatory Variable"
        '
        'lblResponse
        '
        Me.lblResponse.AutoSize = True
        Me.lblResponse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResponse.Location = New System.Drawing.Point(290, 24)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(96, 13)
        Me.lblResponse.TabIndex = 11
        Me.lblResponse.Tag = "Response_Variable"
        Me.lblResponse.Text = "Response Variable"
        '
        'lblGroupingFactor
        '
        Me.lblGroupingFactor.AutoSize = True
        Me.lblGroupingFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroupingFactor.Location = New System.Drawing.Point(290, 117)
        Me.lblGroupingFactor.Name = "lblGroupingFactor"
        Me.lblGroupingFactor.Size = New System.Drawing.Size(83, 13)
        Me.lblGroupingFactor.TabIndex = 16
        Me.lblGroupingFactor.Tag = "Grouping_Factor"
        Me.lblGroupingFactor.Text = "Grouping Factor"
        '
        'grpModelsOperators
        '
        Me.grpModelsOperators.Controls.Add(Me.cmdJointLines)
        Me.grpModelsOperators.Controls.Add(Me.cmdConditional)
        Me.grpModelsOperators.Controls.Add(Me.cmdCommonIntercept)
        Me.grpModelsOperators.Controls.Add(Me.cmdParallelLines)
        Me.grpModelsOperators.Location = New System.Drawing.Point(251, 163)
        Me.grpModelsOperators.Name = "grpModelsOperators"
        Me.grpModelsOperators.Size = New System.Drawing.Size(149, 46)
        Me.grpModelsOperators.TabIndex = 18
        Me.grpModelsOperators.TabStop = False
        Me.grpModelsOperators.Tag = "Models_Operators"
        Me.grpModelsOperators.Text = "Models Operators"
        '
        'cmdJointLines
        '
        Me.cmdJointLines.Location = New System.Drawing.Point(75, 14)
        Me.cmdJointLines.Name = "cmdJointLines"
        Me.cmdJointLines.Size = New System.Drawing.Size(28, 23)
        Me.cmdJointLines.TabIndex = 8
        Me.cmdJointLines.Tag = "*"
        Me.cmdJointLines.Text = "*"
        Me.cmdJointLines.UseVisualStyleBackColor = True
        '
        'cmdConditional
        '
        Me.cmdConditional.Location = New System.Drawing.Point(41, 14)
        Me.cmdConditional.Name = "cmdConditional"
        Me.cmdConditional.Size = New System.Drawing.Size(27, 23)
        Me.cmdConditional.TabIndex = 7
        Me.cmdConditional.Text = ":"
        Me.cmdConditional.UseVisualStyleBackColor = True
        '
        'cmdCommonIntercept
        '
        Me.cmdCommonIntercept.Location = New System.Drawing.Point(110, 14)
        Me.cmdCommonIntercept.Name = "cmdCommonIntercept"
        Me.cmdCommonIntercept.Size = New System.Drawing.Size(27, 23)
        Me.cmdCommonIntercept.TabIndex = 6
        Me.cmdCommonIntercept.Tag = "/"
        Me.cmdCommonIntercept.Text = "/"
        Me.cmdCommonIntercept.UseVisualStyleBackColor = True
        '
        'cmdParallelLines
        '
        Me.cmdParallelLines.Location = New System.Drawing.Point(7, 14)
        Me.cmdParallelLines.Name = "cmdParallelLines"
        Me.cmdParallelLines.Size = New System.Drawing.Size(28, 23)
        Me.cmdParallelLines.TabIndex = 5
        Me.cmdParallelLines.Tag = "+"
        Me.cmdParallelLines.Text = "+"
        Me.cmdParallelLines.UseVisualStyleBackColor = True
        '
        'cmdSWGOptions
        '
        Me.cmdSWGOptions.Location = New System.Drawing.Point(271, 236)
        Me.cmdSWGOptions.Name = "cmdSWGOptions"
        Me.cmdSWGOptions.Size = New System.Drawing.Size(122, 23)
        Me.cmdSWGOptions.TabIndex = 21
        Me.cmdSWGOptions.Tag = "Regression_Options"
        Me.cmdSWGOptions.Text = "Regression Options"
        Me.cmdSWGOptions.UseVisualStyleBackColor = True
        '
        'ucrModelPreview
        '
        Me.ucrModelPreview.Location = New System.Drawing.Point(118, 224)
        Me.ucrModelPreview.Name = "ucrModelPreview"
        Me.ucrModelPreview.Size = New System.Drawing.Size(142, 21)
        Me.ucrModelPreview.TabIndex = 22
        '
        'ucrFamily
        '
        Me.ucrFamily.Location = New System.Drawing.Point(15, 3)
        Me.ucrFamily.Name = "ucrFamily"
        Me.ucrFamily.Size = New System.Drawing.Size(225, 43)
        Me.ucrFamily.TabIndex = 20
        '
        'ucrGroupingFactor
        '
        Me.ucrGroupingFactor.Location = New System.Drawing.Point(288, 131)
        Me.ucrGroupingFactor.Name = "ucrGroupingFactor"
        Me.ucrGroupingFactor.Selector = Nothing
        Me.ucrGroupingFactor.Size = New System.Drawing.Size(106, 26)
        Me.ucrGroupingFactor.TabIndex = 17
        '
        'ucrModelName
        '
        Me.ucrModelName.Location = New System.Drawing.Point(116, 247)
        Me.ucrModelName.Name = "ucrModelName"
        Me.ucrModelName.Size = New System.Drawing.Size(149, 23)
        Me.ucrModelName.TabIndex = 10
        '
        'ucrExplanatory
        '
        Me.ucrExplanatory.Location = New System.Drawing.Point(285, 87)
        Me.ucrExplanatory.Name = "ucrExplanatory"
        Me.ucrExplanatory.Selector = Nothing
        Me.ucrExplanatory.Size = New System.Drawing.Size(106, 26)
        Me.ucrExplanatory.TabIndex = 14
        '
        'ucrResponse
        '
        Me.ucrResponse.Location = New System.Drawing.Point(285, 40)
        Me.ucrResponse.Name = "ucrResponse"
        Me.ucrResponse.Selector = Nothing
        Me.ucrResponse.Size = New System.Drawing.Size(106, 26)
        Me.ucrResponse.TabIndex = 12
        '
        'ucrSelectorSimpleRegGroups
        '
        Me.ucrSelectorSimpleRegGroups.Location = New System.Drawing.Point(8, 46)
        Me.ucrSelectorSimpleRegGroups.Name = "ucrSelectorSimpleRegGroups"
        Me.ucrSelectorSimpleRegGroups.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorSimpleRegGroups.TabIndex = 9
        '
        'ucrBaseRegWithGroups
        '
        Me.ucrBaseRegWithGroups.Location = New System.Drawing.Point(3, 277)
        Me.ucrBaseRegWithGroups.Name = "ucrBaseRegWithGroups"
        Me.ucrBaseRegWithGroups.Size = New System.Drawing.Size(410, 55)
        Me.ucrBaseRegWithGroups.TabIndex = 0
        '
        'lblModelPreview
        '
        Me.lblModelPreview.AutoSize = True
        Me.lblModelPreview.Location = New System.Drawing.Point(13, 230)
        Me.lblModelPreview.Name = "lblModelPreview"
        Me.lblModelPreview.Size = New System.Drawing.Size(77, 13)
        Me.lblModelPreview.TabIndex = 23
        Me.lblModelPreview.Tag = "Model_Preview"
        Me.lblModelPreview.Text = "Model Preview"
        '
        'dlgSimpleWithGroups
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 329)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.ucrModelPreview)
        Me.Controls.Add(Me.cmdSWGOptions)
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
    Friend WithEvents cmdSWGOptions As Button
    Friend WithEvents cmdJointLines As Button
    Friend WithEvents cmdConditional As Button
    Friend WithEvents cmdCommonIntercept As Button
    Friend WithEvents cmdParallelLines As Button
    Friend WithEvents ucrModelPreview As ucrInputTextBox
    Friend WithEvents lblModelPreview As Label
End Class
