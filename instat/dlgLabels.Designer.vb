<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgLabels
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
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrReceiverLabels = New instat.ucrReceiverSingle()
        Me.ucrFactorLabels = New instat.ucrFactor()
        Me.ucrSelectorForLabels = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.cmdAddLevel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(271, 18)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(37, 13)
        Me.lblFactor.TabIndex = 3
        Me.lblFactor.Tag = "Factor"
        Me.lblFactor.Text = "Factor"
        '
        'ucrReceiverLabels
        '
        Me.ucrReceiverLabels.Location = New System.Drawing.Point(274, 34)
        Me.ucrReceiverLabels.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLabels.Name = "ucrReceiverLabels"
        Me.ucrReceiverLabels.Selector = Nothing
        Me.ucrReceiverLabels.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverLabels.TabIndex = 4
        '
        'ucrFactorLabels
        '
        Me.ucrFactorLabels.AutoSize = True
        Me.ucrFactorLabels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrFactorLabels.clsReceiver = Nothing
        Me.ucrFactorLabels.Location = New System.Drawing.Point(274, 66)
        Me.ucrFactorLabels.Name = "ucrFactorLabels"
        Me.ucrFactorLabels.shtCurrSheet = Nothing
        Me.ucrFactorLabels.Size = New System.Drawing.Size(267, 171)
        Me.ucrFactorLabels.TabIndex = 2
        '
        'ucrSelectorForLabels
        '
        Me.ucrSelectorForLabels.bShowHiddenColumns = False
        Me.ucrSelectorForLabels.bUseCurrentFilter = False
        Me.ucrSelectorForLabels.Location = New System.Drawing.Point(12, 12)
        Me.ucrSelectorForLabels.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForLabels.Name = "ucrSelectorForLabels"
        Me.ucrSelectorForLabels.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorForLabels.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 287)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'cmdAddLevel
        '
        Me.cmdAddLevel.Location = New System.Drawing.Point(274, 243)
        Me.cmdAddLevel.Name = "cmdAddLevel"
        Me.cmdAddLevel.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddLevel.TabIndex = 5
        Me.cmdAddLevel.Text = "Add Level"
        Me.cmdAddLevel.UseVisualStyleBackColor = True
        '
        'dlgLabels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 348)
        Me.Controls.Add(Me.cmdAddLevel)
        Me.Controls.Add(Me.ucrReceiverLabels)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrFactorLabels)
        Me.Controls.Add(Me.ucrSelectorForLabels)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgLabels"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Labels"
        Me.Text = "Labels/Levels"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForLabels As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFactorLabels As ucrFactor
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrReceiverLabels As ucrReceiverSingle
    Friend WithEvents cmdAddLevel As Button
End Class
