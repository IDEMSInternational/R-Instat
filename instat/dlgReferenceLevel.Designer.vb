<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgReferenceLevel
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverReferenceLevels = New instat.ucrReceiverSingle()
        Me.lblFactorSelected = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.ucrFactorReferenceLevels = New instat.ucrFactor()
        Me.ucrSelectorForReferenceLevels = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(4, 295)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrReceiverReferenceLevels
        '
        Me.ucrReceiverReferenceLevels.Location = New System.Drawing.Point(261, 58)
        Me.ucrReceiverReferenceLevels.Name = "ucrReceiverReferenceLevels"
        Me.ucrReceiverReferenceLevels.Selector = Nothing
        Me.ucrReceiverReferenceLevels.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverReferenceLevels.TabIndex = 3
        '
        'lblFactorSelected
        '
        Me.lblFactorSelected.AutoSize = True
        Me.lblFactorSelected.Location = New System.Drawing.Point(261, 42)
        Me.lblFactorSelected.Name = "lblFactorSelected"
        Me.lblFactorSelected.Size = New System.Drawing.Size(80, 13)
        Me.lblFactorSelected.TabIndex = 4
        Me.lblFactorSelected.Tag = "Factor_selected"
        Me.lblFactorSelected.Text = "Factor selected"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(-2, 208)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(215, 13)
        Me.lblInfo.TabIndex = 5
        Me.lblInfo.Tag = "REQUIRES_A_FACTOR_LEVEL_SELECTOR"
        Me.lblInfo.Text = "REQUIRES A FACTOR LEVEL SELECTOR"
        '
        'ucrFactorReferenceLevels
        '
        Me.ucrFactorReferenceLevels.AutoSize = True
        Me.ucrFactorReferenceLevels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrFactorReferenceLevels.clsReceiver = Nothing
        Me.ucrFactorReferenceLevels.Location = New System.Drawing.Point(251, 90)
        Me.ucrFactorReferenceLevels.Name = "ucrFactorReferenceLevels"
        Me.ucrFactorReferenceLevels.shtCurrSheet = Nothing
        Me.ucrFactorReferenceLevels.Size = New System.Drawing.Size(267, 181)
        Me.ucrFactorReferenceLevels.TabIndex = 7
        '
        'ucrSelectorForReferenceLevels
        '
        Me.ucrSelectorForReferenceLevels.Location = New System.Drawing.Point(13, 13)
        Me.ucrSelectorForReferenceLevels.Name = "ucrSelectorForReferenceLevels"
        Me.ucrSelectorForReferenceLevels.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorForReferenceLevels.TabIndex = 8
        '
        'dlgReferenceLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 350)
        Me.Controls.Add(Me.ucrSelectorForReferenceLevels)
        Me.Controls.Add(Me.ucrFactorReferenceLevels)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblFactorSelected)
        Me.Controls.Add(Me.ucrReceiverReferenceLevels)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgReferenceLevel"
        Me.Tag = "Reference_Level"
        Me.Text = "Reference Level"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverReferenceLevels As ucrReceiverSingle
    Friend WithEvents lblFactorSelected As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents ucrFactorReferenceLevels As ucrFactor
    Friend WithEvents ucrSelectorForReferenceLevels As ucrSelectorByDataFrameAddRemove
End Class
