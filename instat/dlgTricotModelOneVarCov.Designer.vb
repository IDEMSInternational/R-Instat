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
        Me.ucrInputCheckVariety = New instat.ucrInputTextBox()
        Me.lblCheckVariety = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrSelectorTraitsRanking
        '
        Me.ucrSelectorTraitsRanking.AutoSize = True
        Me.ucrSelectorTraitsRanking.bDropUnusedFilterLevels = False
        Me.ucrSelectorTraitsRanking.bShowHiddenColumns = False
        Me.ucrSelectorTraitsRanking.bUseCurrentFilter = True
        Me.ucrSelectorTraitsRanking.Location = New System.Drawing.Point(17, 16)
        Me.ucrSelectorTraitsRanking.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTraitsRanking.Name = "ucrSelectorTraitsRanking"
        Me.ucrSelectorTraitsRanking.Size = New System.Drawing.Size(320, 282)
        Me.ucrSelectorTraitsRanking.TabIndex = 0
        '
        'ucrSelectorVarietyLevel
        '
        Me.ucrSelectorVarietyLevel.AutoSize = True
        Me.ucrSelectorVarietyLevel.bDropUnusedFilterLevels = False
        Me.ucrSelectorVarietyLevel.bShowHiddenColumns = False
        Me.ucrSelectorVarietyLevel.bUseCurrentFilter = True
        Me.ucrSelectorVarietyLevel.Location = New System.Drawing.Point(17, 298)
        Me.ucrSelectorVarietyLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorVarietyLevel.Name = "ucrSelectorVarietyLevel"
        Me.ucrSelectorVarietyLevel.Size = New System.Drawing.Size(320, 282)
        Me.ucrSelectorVarietyLevel.TabIndex = 1
        '
        'ucrTraitsReceiver
        '
        Me.ucrTraitsReceiver.AutoSize = True
        Me.ucrTraitsReceiver.frmParent = Me
        Me.ucrTraitsReceiver.Location = New System.Drawing.Point(396, 94)
        Me.ucrTraitsReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrTraitsReceiver.Name = "ucrTraitsReceiver"
        Me.ucrTraitsReceiver.Selector = Nothing
        Me.ucrTraitsReceiver.Size = New System.Drawing.Size(213, 189)
        Me.ucrTraitsReceiver.strNcFilePath = ""
        Me.ucrTraitsReceiver.TabIndex = 2
        Me.ucrTraitsReceiver.ucrSelector = Nothing
        '
        'ucrVarietyLevelReceiver
        '
        Me.ucrVarietyLevelReceiver.AutoSize = True
        Me.ucrVarietyLevelReceiver.frmParent = Me
        Me.ucrVarietyLevelReceiver.Location = New System.Drawing.Point(395, 385)
        Me.ucrVarietyLevelReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrVarietyLevelReceiver.Name = "ucrVarietyLevelReceiver"
        Me.ucrVarietyLevelReceiver.Selector = Nothing
        Me.ucrVarietyLevelReceiver.Size = New System.Drawing.Size(214, 31)
        Me.ucrVarietyLevelReceiver.strNcFilePath = ""
        Me.ucrVarietyLevelReceiver.TabIndex = 3
        Me.ucrVarietyLevelReceiver.ucrSelector = Nothing
        '
        'lblTraitsToModel
        '
        Me.lblTraitsToModel.AutoSize = True
        Me.lblTraitsToModel.Location = New System.Drawing.Point(392, 71)
        Me.lblTraitsToModel.Name = "lblTraitsToModel"
        Me.lblTraitsToModel.Size = New System.Drawing.Size(117, 20)
        Me.lblTraitsToModel.TabIndex = 4
        Me.lblTraitsToModel.Text = "Traits to Model:"
        '
        'lblExplanatory
        '
        Me.lblExplanatory.AutoSize = True
        Me.lblExplanatory.Location = New System.Drawing.Point(392, 363)
        Me.lblExplanatory.Name = "lblExplanatory"
        Me.lblExplanatory.Size = New System.Drawing.Size(158, 20)
        Me.lblExplanatory.TabIndex = 5
        Me.lblExplanatory.Text = "Explanatory Variable:"
        '
        'ucrTricOneVarSave
        '
        Me.ucrTricOneVarSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrTricOneVarSave.Location = New System.Drawing.Point(17, 635)
        Me.ucrTricOneVarSave.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrTricOneVarSave.Name = "ucrTricOneVarSave"
        Me.ucrTricOneVarSave.Size = New System.Drawing.Size(604, 49)
        Me.ucrTricOneVarSave.TabIndex = 6
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(17, 688)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 9
        '
        'btnModelOptions
        '
        Me.btnModelOptions.Location = New System.Drawing.Point(456, 490)
        Me.btnModelOptions.Name = "btnModelOptions"
        Me.btnModelOptions.Size = New System.Drawing.Size(172, 32)
        Me.btnModelOptions.TabIndex = 10
        Me.btnModelOptions.Text = "Model Options"
        Me.btnModelOptions.UseVisualStyleBackColor = True
        '
        'btnDisplayOptions
        '
        Me.btnDisplayOptions.Location = New System.Drawing.Point(456, 528)
        Me.btnDisplayOptions.Name = "btnDisplayOptions"
        Me.btnDisplayOptions.Size = New System.Drawing.Size(172, 32)
        Me.btnDisplayOptions.TabIndex = 11
        Me.btnDisplayOptions.Text = "Display Options"
        Me.btnDisplayOptions.UseVisualStyleBackColor = True
        '
        'ucrInputCheckVariety
        '
        Me.ucrInputCheckVariety.AddQuotesIfUnrecognised = True
        Me.ucrInputCheckVariety.AutoSize = True
        Me.ucrInputCheckVariety.IsMultiline = False
        Me.ucrInputCheckVariety.IsReadOnly = False
        Me.ucrInputCheckVariety.Location = New System.Drawing.Point(144, 592)
        Me.ucrInputCheckVariety.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputCheckVariety.Name = "ucrInputCheckVariety"
        Me.ucrInputCheckVariety.Size = New System.Drawing.Size(484, 32)
        Me.ucrInputCheckVariety.TabIndex = 13
        '
        'lblCheckVariety
        '
        Me.lblCheckVariety.AutoSize = True
        Me.lblCheckVariety.Location = New System.Drawing.Point(24, 595)
        Me.lblCheckVariety.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCheckVariety.Name = "lblCheckVariety"
        Me.lblCheckVariety.Size = New System.Drawing.Size(111, 20)
        Me.lblCheckVariety.TabIndex = 14
        Me.lblCheckVariety.Text = "Check Variety:"
        '
        'dlgTricotModelOneVarCov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(674, 774)
        Me.Controls.Add(Me.lblCheckVariety)
        Me.Controls.Add(Me.ucrInputCheckVariety)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
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
    Friend WithEvents ucrInputCheckVariety As ucrInputTextBox
    Friend WithEvents lblCheckVariety As Label
End Class
