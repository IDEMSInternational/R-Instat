<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTricotModellingGeneral
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
        Me.ucrInputCheckVariety = New instat.ucrInputTextBox()
        Me.btnDisplayOptions = New System.Windows.Forms.Button()
        Me.btnModelOptions = New System.Windows.Forms.Button()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveModellingGeneral = New instat.ucrSave()
        Me.lblExplanatory = New System.Windows.Forms.Label()
        Me.lblTraitsToModel = New System.Windows.Forms.Label()
        Me.ucrTraitsReceiver = New instat.ucrReceiverMultiple()
        Me.ucrSelectorVarietyLevel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSelectorTraitsRanking = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblCheckVareity = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleExplanatoryVariables = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'ucrInputCheckVariety
        '
        Me.ucrInputCheckVariety.AddQuotesIfUnrecognised = True
        Me.ucrInputCheckVariety.AutoSize = True
        Me.ucrInputCheckVariety.IsMultiline = False
        Me.ucrInputCheckVariety.IsReadOnly = False
        Me.ucrInputCheckVariety.Location = New System.Drawing.Point(86, 603)
        Me.ucrInputCheckVariety.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputCheckVariety.Name = "ucrInputCheckVariety"
        Me.ucrInputCheckVariety.Size = New System.Drawing.Size(400, 32)
        Me.ucrInputCheckVariety.TabIndex = 9
        '
        'btnDisplayOptions
        '
        Me.btnDisplayOptions.Location = New System.Drawing.Point(502, 603)
        Me.btnDisplayOptions.Name = "btnDisplayOptions"
        Me.btnDisplayOptions.Size = New System.Drawing.Size(172, 32)
        Me.btnDisplayOptions.TabIndex = 11
        Me.btnDisplayOptions.Text = "Display Options"
        Me.btnDisplayOptions.UseVisualStyleBackColor = True
        '
        'btnModelOptions
        '
        Me.btnModelOptions.Location = New System.Drawing.Point(502, 565)
        Me.btnModelOptions.Name = "btnModelOptions"
        Me.btnModelOptions.Size = New System.Drawing.Size(172, 32)
        Me.btnModelOptions.TabIndex = 10
        Me.btnModelOptions.Text = "Model Options"
        Me.btnModelOptions.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 708)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 13
        '
        'ucrSaveModellingGeneral
        '
        Me.ucrSaveModellingGeneral.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveModellingGeneral.Location = New System.Drawing.Point(15, 646)
        Me.ucrSaveModellingGeneral.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveModellingGeneral.Name = "ucrSaveModellingGeneral"
        Me.ucrSaveModellingGeneral.Size = New System.Drawing.Size(604, 48)
        Me.ucrSaveModellingGeneral.TabIndex = 12
        '
        'lblExplanatory
        '
        Me.lblExplanatory.AutoSize = True
        Me.lblExplanatory.Location = New System.Drawing.Point(415, 297)
        Me.lblExplanatory.Name = "lblExplanatory"
        Me.lblExplanatory.Size = New System.Drawing.Size(158, 20)
        Me.lblExplanatory.TabIndex = 4
        Me.lblExplanatory.Text = "Explanatory Variable:"
        '
        'lblTraitsToModel
        '
        Me.lblTraitsToModel.AutoSize = True
        Me.lblTraitsToModel.Location = New System.Drawing.Point(415, 59)
        Me.lblTraitsToModel.Name = "lblTraitsToModel"
        Me.lblTraitsToModel.Size = New System.Drawing.Size(117, 20)
        Me.lblTraitsToModel.TabIndex = 1
        Me.lblTraitsToModel.Text = "Traits to Model:"
        '
        'ucrTraitsReceiver
        '
        Me.ucrTraitsReceiver.AutoSize = True
        Me.ucrTraitsReceiver.frmParent = Me
        Me.ucrTraitsReceiver.Location = New System.Drawing.Point(415, 82)
        Me.ucrTraitsReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrTraitsReceiver.Name = "ucrTraitsReceiver"
        Me.ucrTraitsReceiver.Selector = Nothing
        Me.ucrTraitsReceiver.Size = New System.Drawing.Size(259, 181)
        Me.ucrTraitsReceiver.strNcFilePath = ""
        Me.ucrTraitsReceiver.TabIndex = 2
        Me.ucrTraitsReceiver.ucrSelector = Nothing
        '
        'ucrSelectorVarietyLevel
        '
        Me.ucrSelectorVarietyLevel.AutoSize = True
        Me.ucrSelectorVarietyLevel.bDropUnusedFilterLevels = False
        Me.ucrSelectorVarietyLevel.bShowHiddenColumns = False
        Me.ucrSelectorVarietyLevel.bUseCurrentFilter = True
        Me.ucrSelectorVarietyLevel.Location = New System.Drawing.Point(15, 306)
        Me.ucrSelectorVarietyLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorVarietyLevel.Name = "ucrSelectorVarietyLevel"
        Me.ucrSelectorVarietyLevel.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorVarietyLevel.TabIndex = 3
        '
        'ucrSelectorTraitsRanking
        '
        Me.ucrSelectorTraitsRanking.AutoSize = True
        Me.ucrSelectorTraitsRanking.bDropUnusedFilterLevels = False
        Me.ucrSelectorTraitsRanking.bShowHiddenColumns = False
        Me.ucrSelectorTraitsRanking.bUseCurrentFilter = True
        Me.ucrSelectorTraitsRanking.Location = New System.Drawing.Point(15, 15)
        Me.ucrSelectorTraitsRanking.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTraitsRanking.Name = "ucrSelectorTraitsRanking"
        Me.ucrSelectorTraitsRanking.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorTraitsRanking.TabIndex = 0
        '
        'lblCheckVareity
        '
        Me.lblCheckVareity.AutoSize = True
        Me.lblCheckVareity.Location = New System.Drawing.Point(11, 603)
        Me.lblCheckVareity.Name = "lblCheckVareity"
        Me.lblCheckVareity.Size = New System.Drawing.Size(58, 20)
        Me.lblCheckVareity.TabIndex = 56
        Me.lblCheckVareity.Text = "Check:"
        '
        'ucrReceiverMultipleExplanatoryVariables
        '
        Me.ucrReceiverMultipleExplanatoryVariables.AutoSize = True
        Me.ucrReceiverMultipleExplanatoryVariables.frmParent = Me
        Me.ucrReceiverMultipleExplanatoryVariables.Location = New System.Drawing.Point(415, 320)
        Me.ucrReceiverMultipleExplanatoryVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleExplanatoryVariables.Name = "ucrReceiverMultipleExplanatoryVariables"
        Me.ucrReceiverMultipleExplanatoryVariables.Selector = Nothing
        Me.ucrReceiverMultipleExplanatoryVariables.Size = New System.Drawing.Size(259, 181)
        Me.ucrReceiverMultipleExplanatoryVariables.strNcFilePath = ""
        Me.ucrReceiverMultipleExplanatoryVariables.TabIndex = 57
        Me.ucrReceiverMultipleExplanatoryVariables.ucrSelector = Nothing
        '
        'dlgTricotModellingGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(703, 797)
        Me.Controls.Add(Me.ucrReceiverMultipleExplanatoryVariables)
        Me.Controls.Add(Me.lblCheckVareity)
        Me.Controls.Add(Me.ucrInputCheckVariety)
        Me.Controls.Add(Me.btnDisplayOptions)
        Me.Controls.Add(Me.btnModelOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSaveModellingGeneral)
        Me.Controls.Add(Me.lblExplanatory)
        Me.Controls.Add(Me.lblTraitsToModel)
        Me.Controls.Add(Me.ucrTraitsReceiver)
        Me.Controls.Add(Me.ucrSelectorVarietyLevel)
        Me.Controls.Add(Me.ucrSelectorTraitsRanking)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTricotModellingGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modelling (General)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrInputCheckVariety As ucrInputTextBox
    Friend WithEvents btnDisplayOptions As Button
    Friend WithEvents btnModelOptions As Button
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSaveModellingGeneral As ucrSave
    Friend WithEvents lblExplanatory As Label
    Friend WithEvents lblTraitsToModel As Label
    Friend WithEvents ucrTraitsReceiver As ucrReceiverMultiple
    Friend WithEvents ucrSelectorVarietyLevel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectorTraitsRanking As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblCheckVareity As Label
    Friend WithEvents ucrReceiverMultipleExplanatoryVariables As ucrReceiverMultiple
End Class