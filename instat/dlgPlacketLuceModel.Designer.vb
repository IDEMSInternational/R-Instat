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
        Me.ucrSaveResult = New instat.ucrSave()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.cmdModelOptions = New System.Windows.Forms.Button()
        Me.lblTraits = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverMultipleTraits = New instat.ucrReceiverMultiple()
        Me.ucrSelectorTraitsPL = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'ucrSaveResult
        '
        Me.ucrSaveResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveResult.Location = New System.Drawing.Point(7, 234)
        Me.ucrSaveResult.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveResult.Name = "ucrSaveResult"
        Me.ucrSaveResult.Size = New System.Drawing.Size(267, 24)
        Me.ucrSaveResult.TabIndex = 40
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(272, 199)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(120, 23)
        Me.cmdDisplayOptions.TabIndex = 39
        Me.cmdDisplayOptions.Text = "Display Options"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'cmdModelOptions
        '
        Me.cmdModelOptions.Location = New System.Drawing.Point(272, 156)
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.Size = New System.Drawing.Size(120, 23)
        Me.cmdModelOptions.TabIndex = 38
        Me.cmdModelOptions.Text = "Model Options"
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'lblTraits
        '
        Me.lblTraits.AutoSize = True
        Me.lblTraits.Location = New System.Drawing.Point(269, 20)
        Me.lblTraits.Name = "lblTraits"
        Me.lblTraits.Size = New System.Drawing.Size(84, 13)
        Me.lblTraits.TabIndex = 37
        Me.lblTraits.Text = "Traits To Model:"
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(7, 271)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 36
        '
        'ucrReceiverMultipleTraits
        '
        Me.ucrReceiverMultipleTraits.AutoSize = True
        Me.ucrReceiverMultipleTraits.frmParent = Me
        Me.ucrReceiverMultipleTraits.Location = New System.Drawing.Point(272, 37)
        Me.ucrReceiverMultipleTraits.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleTraits.Name = "ucrReceiverMultipleTraits"
        Me.ucrReceiverMultipleTraits.Selector = Nothing
        Me.ucrReceiverMultipleTraits.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleTraits.strNcFilePath = ""
        Me.ucrReceiverMultipleTraits.TabIndex = 35
        Me.ucrReceiverMultipleTraits.ucrSelector = Nothing
        '
        'ucrSelectorTraitsPL
        '
        Me.ucrSelectorTraitsPL.AutoSize = True
        Me.ucrSelectorTraitsPL.bDropUnusedFilterLevels = False
        Me.ucrSelectorTraitsPL.bShowHiddenColumns = False
        Me.ucrSelectorTraitsPL.bUseCurrentFilter = True
        Me.ucrSelectorTraitsPL.Location = New System.Drawing.Point(12, 11)
        Me.ucrSelectorTraitsPL.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTraitsPL.Name = "ucrSelectorTraitsPL"
        Me.ucrSelectorTraitsPL.Size = New System.Drawing.Size(234, 183)
        Me.ucrSelectorTraitsPL.TabIndex = 34
        '
        'dlgPlacketLuceModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 331)
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

    Friend WithEvents ucrSaveResult As ucrSave
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents cmdModelOptions As Button
    Friend WithEvents lblTraits As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverMultipleTraits As ucrReceiverMultiple
    Friend WithEvents ucrSelectorTraitsPL As ucrSelectorByDataFrameAddRemove
End Class
