<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPlacketLuceModel
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ucrSelectorTraitsPL = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverMultipleTraits = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblTraits = New System.Windows.Forms.Label()
        Me.cmdModelOptions = New System.Windows.Forms.Button()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.ucrSaveResult = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'ucrSelectorTraitsPL
        '
        Me.ucrSelectorTraitsPL.AutoSize = True
        Me.ucrSelectorTraitsPL.bDropUnusedFilterLevels = False
        Me.ucrSelectorTraitsPL.bShowHiddenColumns = False
        Me.ucrSelectorTraitsPL.bUseCurrentFilter = True
        Me.ucrSelectorTraitsPL.Location = New System.Drawing.Point(9, 20)
        Me.ucrSelectorTraitsPL.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTraitsPL.Name = "ucrSelectorTraitsPL"
        Me.ucrSelectorTraitsPL.Size = New System.Drawing.Size(234, 183)
        Me.ucrSelectorTraitsPL.TabIndex = 0
        '
        'ucrReceiverMultipleTraits
        '
        Me.ucrReceiverMultipleTraits.AutoSize = True
        Me.ucrReceiverMultipleTraits.frmParent = Me
        Me.ucrReceiverMultipleTraits.Location = New System.Drawing.Point(269, 46)
        Me.ucrReceiverMultipleTraits.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleTraits.Name = "ucrReceiverMultipleTraits"
        Me.ucrReceiverMultipleTraits.Selector = Nothing
        Me.ucrReceiverMultipleTraits.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleTraits.strNcFilePath = ""
        Me.ucrReceiverMultipleTraits.TabIndex = 1
        Me.ucrReceiverMultipleTraits.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(4, 280)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 2
        '
        'lblTraits
        '
        Me.lblTraits.AutoSize = True
        Me.lblTraits.Location = New System.Drawing.Point(266, 29)
        Me.lblTraits.Name = "lblTraits"
        Me.lblTraits.Size = New System.Drawing.Size(84, 13)
        Me.lblTraits.TabIndex = 3
        Me.lblTraits.Text = "Traits To Model:"
        '
        'cmdModelOptions
        '
        Me.cmdModelOptions.Location = New System.Drawing.Point(269, 165)
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.Size = New System.Drawing.Size(120, 23)
        Me.cmdModelOptions.TabIndex = 31
        Me.cmdModelOptions.Text = "Model Options"
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(269, 208)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(120, 23)
        Me.cmdDisplayOptions.TabIndex = 32
        Me.cmdDisplayOptions.Text = "Display Options"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'ucrSaveResult
        '
        Me.ucrSaveResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveResult.Location = New System.Drawing.Point(4, 243)
        Me.ucrSaveResult.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveResult.Name = "ucrSaveResult"
        Me.ucrSaveResult.Size = New System.Drawing.Size(267, 24)
        Me.ucrSaveResult.TabIndex = 33
        '
        'dlgPlacketLuceModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 339)
        Me.Controls.Add(Me.ucrSaveResult)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.cmdModelOptions)
        Me.Controls.Add(Me.lblTraits)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverMultipleTraits)
        Me.Controls.Add(Me.ucrSelectorTraitsPL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPlacketLuceModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Placket-Luce Model (No Covariates)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorTraitsPL As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverMultipleTraits As ucrReceiverMultiple
    Friend WithEvents lblTraits As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents cmdModelOptions As Button
    Friend WithEvents ucrSaveResult As ucrSave
End Class
