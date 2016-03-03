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
        Me.grpModelstofit = New System.Windows.Forms.GroupBox()
        Me.chkCommonIntercept = New System.Windows.Forms.CheckBox()
        Me.chkJointLines = New System.Windows.Forms.CheckBox()
        Me.chkParallelLines = New System.Windows.Forms.CheckBox()
        Me.chkSingle = New System.Windows.Forms.CheckBox()
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.ucrGroupingFactor = New instat.ucrReceiverSingle()
        Me.ucrModelName = New instat.ucrVariableName()
        Me.ucrExplanatory = New instat.ucrReceiverSingle()
        Me.ucrResponse = New instat.ucrReceiverSingle()
        Me.ucrSelectorSimpleRegGroups = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseRegWithGroups = New instat.ucrButtons()
        Me.grpModelstofit.SuspendLayout()
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
        Me.lblExplanatory.Location = New System.Drawing.Point(294, 67)
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
        Me.lblResponse.Location = New System.Drawing.Point(297, 15)
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
        Me.lblGroupingFactor.Location = New System.Drawing.Point(297, 121)
        Me.lblGroupingFactor.Name = "lblGroupingFactor"
        Me.lblGroupingFactor.Size = New System.Drawing.Size(83, 13)
        Me.lblGroupingFactor.TabIndex = 16
        Me.lblGroupingFactor.Tag = "Grouping_Factor"
        Me.lblGroupingFactor.Text = "Grouping Factor"
        '
        'grpModelstofit
        '
        Me.grpModelstofit.Controls.Add(Me.chkCommonIntercept)
        Me.grpModelstofit.Controls.Add(Me.chkJointLines)
        Me.grpModelstofit.Controls.Add(Me.chkParallelLines)
        Me.grpModelstofit.Controls.Add(Me.chkSingle)
        Me.grpModelstofit.Controls.Add(Me.chkAll)
        Me.grpModelstofit.Location = New System.Drawing.Point(9, 186)
        Me.grpModelstofit.Name = "grpModelstofit"
        Me.grpModelstofit.Size = New System.Drawing.Size(393, 55)
        Me.grpModelstofit.TabIndex = 18
        Me.grpModelstofit.TabStop = False
        Me.grpModelstofit.Tag = "Models_to_fit"
        Me.grpModelstofit.Text = "Models to fit"
        '
        'chkCommonIntercept
        '
        Me.chkCommonIntercept.AutoSize = True
        Me.chkCommonIntercept.Location = New System.Drawing.Point(278, 14)
        Me.chkCommonIntercept.Name = "chkCommonIntercept"
        Me.chkCommonIntercept.Size = New System.Drawing.Size(112, 17)
        Me.chkCommonIntercept.TabIndex = 4
        Me.chkCommonIntercept.Tag = "Common_Intercept"
        Me.chkCommonIntercept.Text = "Common Intercept"
        Me.chkCommonIntercept.UseVisualStyleBackColor = True
        '
        'chkJointLines
        '
        Me.chkJointLines.AutoSize = True
        Me.chkJointLines.Location = New System.Drawing.Point(160, 34)
        Me.chkJointLines.Name = "chkJointLines"
        Me.chkJointLines.Size = New System.Drawing.Size(76, 17)
        Me.chkJointLines.TabIndex = 3
        Me.chkJointLines.Tag = "Joint_Lines"
        Me.chkJointLines.Text = "Joint Lines"
        Me.chkJointLines.UseVisualStyleBackColor = True
        '
        'chkParallelLines
        '
        Me.chkParallelLines.AutoSize = True
        Me.chkParallelLines.Location = New System.Drawing.Point(24, 34)
        Me.chkParallelLines.Name = "chkParallelLines"
        Me.chkParallelLines.Size = New System.Drawing.Size(88, 17)
        Me.chkParallelLines.TabIndex = 2
        Me.chkParallelLines.Tag = "Parallel_Lines"
        Me.chkParallelLines.Text = "Parallel Lines"
        Me.chkParallelLines.UseVisualStyleBackColor = True
        '
        'chkSingle
        '
        Me.chkSingle.AutoSize = True
        Me.chkSingle.Location = New System.Drawing.Point(160, 14)
        Me.chkSingle.Name = "chkSingle"
        Me.chkSingle.Size = New System.Drawing.Size(55, 17)
        Me.chkSingle.TabIndex = 1
        Me.chkSingle.Tag = "Single"
        Me.chkSingle.Text = "Single"
        Me.chkSingle.UseVisualStyleBackColor = True
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(24, 15)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(37, 17)
        Me.chkAll.TabIndex = 0
        Me.chkAll.Tag = "All"
        Me.chkAll.Text = "All"
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'ucrGroupingFactor
        '
        Me.ucrGroupingFactor.Location = New System.Drawing.Point(295, 137)
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
        Me.ucrExplanatory.Location = New System.Drawing.Point(292, 83)
        Me.ucrExplanatory.Name = "ucrExplanatory"
        Me.ucrExplanatory.Selector = Nothing
        Me.ucrExplanatory.Size = New System.Drawing.Size(106, 26)
        Me.ucrExplanatory.TabIndex = 14
        '
        'ucrResponse
        '
        Me.ucrResponse.Location = New System.Drawing.Point(292, 31)
        Me.ucrResponse.Name = "ucrResponse"
        Me.ucrResponse.Selector = Nothing
        Me.ucrResponse.Size = New System.Drawing.Size(106, 26)
        Me.ucrResponse.TabIndex = 12
        '
        'ucrSelectorSimpleRegGroups
        '
        Me.ucrSelectorSimpleRegGroups.Location = New System.Drawing.Point(8, 6)
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
        'dlgSimpleWithGroups
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 329)
        Me.Controls.Add(Me.grpModelstofit)
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
        Me.grpModelstofit.ResumeLayout(False)
        Me.grpModelstofit.PerformLayout()
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
    Friend WithEvents grpModelstofit As GroupBox
    Friend WithEvents chkCommonIntercept As CheckBox
    Friend WithEvents chkJointLines As CheckBox
    Friend WithEvents chkParallelLines As CheckBox
    Friend WithEvents chkSingle As CheckBox
    Friend WithEvents chkAll As CheckBox
End Class
