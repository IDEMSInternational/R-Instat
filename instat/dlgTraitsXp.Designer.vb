<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTraitsXp
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
        Me.lblTrait = New System.Windows.Forms.Label()
        Me.ucrSaveTraits = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverTrait = New instat.ucrReceiverSingle()
        Me.ucrTraitGraphSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblTrait
        '
        Me.lblTrait.AutoSize = True
        Me.lblTrait.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTrait.Location = New System.Drawing.Point(265, 48)
        Me.lblTrait.Name = "lblTrait"
        Me.lblTrait.Size = New System.Drawing.Size(31, 13)
        Me.lblTrait.TabIndex = 1
        Me.lblTrait.Text = "Trait:"
        '
        'ucrSaveTraits
        '
        Me.ucrSaveTraits.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTraits.Location = New System.Drawing.Point(7, 201)
        Me.ucrSaveTraits.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveTraits.Name = "ucrSaveTraits"
        Me.ucrSaveTraits.Size = New System.Drawing.Size(273, 33)
        Me.ucrSaveTraits.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(7, 243)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 4
        '
        'ucrReceiverTrait
        '
        Me.ucrReceiverTrait.AutoSize = True
        Me.ucrReceiverTrait.frmParent = Me
        Me.ucrReceiverTrait.Location = New System.Drawing.Point(266, 63)
        Me.ucrReceiverTrait.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTrait.Name = "ucrReceiverTrait"
        Me.ucrReceiverTrait.Selector = Nothing
        Me.ucrReceiverTrait.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTrait.strNcFilePath = ""
        Me.ucrReceiverTrait.TabIndex = 2
        Me.ucrReceiverTrait.ucrSelector = Nothing
        '
        'ucrTraitGraphSelector
        '
        Me.ucrTraitGraphSelector.AutoSize = True
        Me.ucrTraitGraphSelector.bDropUnusedFilterLevels = False
        Me.ucrTraitGraphSelector.bShowHiddenColumns = False
        Me.ucrTraitGraphSelector.bUseCurrentFilter = True
        Me.ucrTraitGraphSelector.Location = New System.Drawing.Point(7, 14)
        Me.ucrTraitGraphSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrTraitGraphSelector.Name = "ucrTraitGraphSelector"
        Me.ucrTraitGraphSelector.Size = New System.Drawing.Size(213, 183)
        Me.ucrTraitGraphSelector.TabIndex = 0
        '
        'dlgTraitsXp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(420, 304)
        Me.Controls.Add(Me.ucrSaveTraits)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblTrait)
        Me.Controls.Add(Me.ucrReceiverTrait)
        Me.Controls.Add(Me.ucrTraitGraphSelector)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTraitsXp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Traits_Graph"
        Me.Text = "TraitsXp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrTraitGraphSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverTrait As ucrReceiverSingle
    Friend WithEvents lblTrait As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSaveTraits As ucrSave
End Class
