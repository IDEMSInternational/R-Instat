<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTricotModelOneVarCov
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
        Me.ucrSelectorTraitsRanking = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSelectorVarietyLevel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrTraitsReceiver = New instat.ucrReceiverMultiple()
        Me.ucrVarietyLevelReceiver = New instat.ucrReceiverSingle()
        Me.lblTraitsToModel = New System.Windows.Forms.Label()
        Me.lblExplanatory = New System.Windows.Forms.Label()
        Me.ucrTricOneVarSave = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.btnModelOptions = New System.Windows.Forms.Button()
        Me.btnDisplayOptions = New System.Windows.Forms.Button()
        Me.cmdCheckVariety = New System.Windows.Forms.Button()
        Me.ucrInputCheckVariety = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'ucrSelectorTraitsRanking
        '
        Me.ucrSelectorTraitsRanking.AutoSize = True
        Me.ucrSelectorTraitsRanking.bDropUnusedFilterLevels = False
        Me.ucrSelectorTraitsRanking.bShowHiddenColumns = False
        Me.ucrSelectorTraitsRanking.bUseCurrentFilter = True
        Me.ucrSelectorTraitsRanking.Location = New System.Drawing.Point(6, 4)
        Me.ucrSelectorTraitsRanking.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTraitsRanking.Name = "ucrSelectorTraitsRanking"
        Me.ucrSelectorTraitsRanking.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorTraitsRanking.TabIndex = 0
        '
        'ucrSelectorVarietyLevel
        '
        Me.ucrSelectorVarietyLevel.AutoSize = True
        Me.ucrSelectorVarietyLevel.bDropUnusedFilterLevels = False
        Me.ucrSelectorVarietyLevel.bShowHiddenColumns = False
        Me.ucrSelectorVarietyLevel.bUseCurrentFilter = True
        Me.ucrSelectorVarietyLevel.Location = New System.Drawing.Point(6, 183)
        Me.ucrSelectorVarietyLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorVarietyLevel.Name = "ucrSelectorVarietyLevel"
        Me.ucrSelectorVarietyLevel.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorVarietyLevel.TabIndex = 1
        '
        'ucrTraitsReceiver
        '
        Me.ucrTraitsReceiver.AutoSize = True
        Me.ucrTraitsReceiver.frmParent = Me
        Me.ucrTraitsReceiver.Location = New System.Drawing.Point(252, 50)
        Me.ucrTraitsReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrTraitsReceiver.Name = "ucrTraitsReceiver"
        Me.ucrTraitsReceiver.Selector = Nothing
        Me.ucrTraitsReceiver.Size = New System.Drawing.Size(179, 129)
        Me.ucrTraitsReceiver.strNcFilePath = ""
        Me.ucrTraitsReceiver.TabIndex = 2
        Me.ucrTraitsReceiver.ucrSelector = Nothing
        '
        'ucrVarietyLevelReceiver
        '
        Me.ucrVarietyLevelReceiver.AutoSize = True
        Me.ucrVarietyLevelReceiver.frmParent = Me
        Me.ucrVarietyLevelReceiver.Location = New System.Drawing.Point(252, 244)
        Me.ucrVarietyLevelReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrVarietyLevelReceiver.Name = "ucrVarietyLevelReceiver"
        Me.ucrVarietyLevelReceiver.Selector = Nothing
        Me.ucrVarietyLevelReceiver.Size = New System.Drawing.Size(179, 20)
        Me.ucrVarietyLevelReceiver.strNcFilePath = ""
        Me.ucrVarietyLevelReceiver.TabIndex = 3
        Me.ucrVarietyLevelReceiver.ucrSelector = Nothing
        '
        'lblTraitsToModel
        '
        Me.lblTraitsToModel.AutoSize = True
        Me.lblTraitsToModel.Location = New System.Drawing.Point(249, 28)
        Me.lblTraitsToModel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTraitsToModel.Name = "lblTraitsToModel"
        Me.lblTraitsToModel.Size = New System.Drawing.Size(80, 13)
        Me.lblTraitsToModel.TabIndex = 4
        Me.lblTraitsToModel.Text = "Traits to Model:"
        '
        'lblExplanatory
        '
        Me.lblExplanatory.AutoSize = True
        Me.lblExplanatory.Location = New System.Drawing.Point(249, 220)
        Me.lblExplanatory.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblExplanatory.Name = "lblExplanatory"
        Me.lblExplanatory.Size = New System.Drawing.Size(106, 13)
        Me.lblExplanatory.TabIndex = 5
        Me.lblExplanatory.Text = "Explanatory Variable:"
        '
        'ucrTricOneVarSave
        '
        Me.ucrTricOneVarSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrTricOneVarSave.Location = New System.Drawing.Point(6, 406)
        Me.ucrTricOneVarSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrTricOneVarSave.Name = "ucrTricOneVarSave"
        Me.ucrTricOneVarSave.Size = New System.Drawing.Size(403, 32)
        Me.ucrTricOneVarSave.TabIndex = 6
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(6, 441)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 9
        '
        'btnModelOptions
        '
        Me.btnModelOptions.Location = New System.Drawing.Point(317, 312)
        Me.btnModelOptions.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModelOptions.Name = "btnModelOptions"
        Me.btnModelOptions.Size = New System.Drawing.Size(115, 21)
        Me.btnModelOptions.TabIndex = 10
        Me.btnModelOptions.Text = "Model Options"
        Me.btnModelOptions.UseVisualStyleBackColor = True
        '
        'btnDisplayOptions
        '
        Me.btnDisplayOptions.Location = New System.Drawing.Point(317, 337)
        Me.btnDisplayOptions.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDisplayOptions.Name = "btnDisplayOptions"
        Me.btnDisplayOptions.Size = New System.Drawing.Size(115, 21)
        Me.btnDisplayOptions.TabIndex = 11
        Me.btnDisplayOptions.Text = "Display Options"
        Me.btnDisplayOptions.UseVisualStyleBackColor = True
        '
        'cmdCheckVariety
        '
        Me.cmdCheckVariety.Location = New System.Drawing.Point(6, 378)
        Me.cmdCheckVariety.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCheckVariety.Name = "cmdCheckVariety"
        Me.cmdCheckVariety.Size = New System.Drawing.Size(113, 21)
        Me.cmdCheckVariety.TabIndex = 12
        Me.cmdCheckVariety.Text = "Check Variety"
        Me.cmdCheckVariety.UseVisualStyleBackColor = True
        '
        'ucrInputCheckVariety
        '
        Me.ucrInputCheckVariety.AddQuotesIfUnrecognised = True
        Me.ucrInputCheckVariety.AutoSize = True
        Me.ucrInputCheckVariety.IsMultiline = False
        Me.ucrInputCheckVariety.IsReadOnly = False
        Me.ucrInputCheckVariety.Location = New System.Drawing.Point(124, 378)
        Me.ucrInputCheckVariety.Name = "ucrInputCheckVariety"
        Me.ucrInputCheckVariety.Size = New System.Drawing.Size(307, 21)
        Me.ucrInputCheckVariety.TabIndex = 13
        '
        'dlgTricotModelOneVarCov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 501)
        Me.Controls.Add(Me.ucrInputCheckVariety)
        Me.Controls.Add(Me.cmdCheckVariety)
        Me.Controls.Add(Me.btnDisplayOptions)
        Me.Controls.Add(Me.btnModelOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrTricOneVarSave)
        Me.Controls.Add(Me.lblExplanatory)
        Me.Controls.Add(Me.lblTraitsToModel)
        Me.Controls.Add(Me.ucrVarietyLevelReceiver)
        Me.Controls.Add(Me.ucrTraitsReceiver)
        Me.Controls.Add(Me.ucrSelectorVarietyLevel)
        Me.Controls.Add(Me.ucrSelectorTraitsRanking)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "dlgTricotModelOneVarCov"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plackett Luce (one covariate)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorTraitsRanking As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectorVarietyLevel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrTraitsReceiver As ucrReceiverMultiple
    Friend WithEvents lblExplanatory As Label
    Friend WithEvents lblTraitsToModel As Label
    Friend WithEvents ucrVarietyLevelReceiver As ucrReceiverSingle
    Friend WithEvents ucrTricOneVarSave As ucrSave
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents btnDisplayOptions As Button
    Friend WithEvents btnModelOptions As Button
    Friend WithEvents cmdCheckVariety As Button
    Friend WithEvents ucrInputCheckVariety As ucrInputTextBox
End Class
