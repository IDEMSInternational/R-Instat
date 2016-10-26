<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgContrasts
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
        Me.ucrSelectorForContrast = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverForContrasts = New instat.ucrReceiverSingle()
        Me.lblFactorReceiver = New System.Windows.Forms.Label()
        Me.chkOverwriteExistContrast = New System.Windows.Forms.CheckBox()
        Me.ucrInputContrast = New instat.ucrInputComboBox()
        Me.lblSelectContrast = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 196)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 60)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorForContrast
        '
        Me.ucrSelectorForContrast.bShowHiddenColumns = False
        Me.ucrSelectorForContrast.bUseCurrentFilter = False
        Me.ucrSelectorForContrast.Location = New System.Drawing.Point(13, 13)
        Me.ucrSelectorForContrast.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForContrast.Name = "ucrSelectorForContrast"
        Me.ucrSelectorForContrast.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForContrast.TabIndex = 1
        '
        'ucrReceiverForContrasts
        '
        Me.ucrReceiverForContrasts.Location = New System.Drawing.Point(239, 26)
        Me.ucrReceiverForContrasts.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForContrasts.Name = "ucrReceiverForContrasts"
        Me.ucrReceiverForContrasts.Selector = Nothing
        Me.ucrReceiverForContrasts.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverForContrasts.TabIndex = 2
        '
        'lblFactorReceiver
        '
        Me.lblFactorReceiver.AutoSize = True
        Me.lblFactorReceiver.Location = New System.Drawing.Point(236, 9)
        Me.lblFactorReceiver.Name = "lblFactorReceiver"
        Me.lblFactorReceiver.Size = New System.Drawing.Size(90, 13)
        Me.lblFactorReceiver.TabIndex = 3
        Me.lblFactorReceiver.Text = "Selected Variable"
        '
        'chkOverwriteExistContrast
        '
        Me.chkOverwriteExistContrast.AutoSize = True
        Me.chkOverwriteExistContrast.Location = New System.Drawing.Point(242, 153)
        Me.chkOverwriteExistContrast.Name = "chkOverwriteExistContrast"
        Me.chkOverwriteExistContrast.Size = New System.Drawing.Size(192, 17)
        Me.chkOverwriteExistContrast.TabIndex = 11
        Me.chkOverwriteExistContrast.Text = "Overwrite existing contrast columns"
        Me.chkOverwriteExistContrast.UseVisualStyleBackColor = True
        '
        'ucrInputContrast
        '
        Me.ucrInputContrast.IsReadOnly = False
        Me.ucrInputContrast.Location = New System.Drawing.Point(241, 71)
        Me.ucrInputContrast.Name = "ucrInputContrast"
        Me.ucrInputContrast.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputContrast.TabIndex = 13
        '
        'lblSelectContrast
        '
        Me.lblSelectContrast.AutoSize = True
        Me.lblSelectContrast.Location = New System.Drawing.Point(239, 54)
        Me.lblSelectContrast.Name = "lblSelectContrast"
        Me.lblSelectContrast.Size = New System.Drawing.Size(79, 13)
        Me.lblSelectContrast.TabIndex = 14
        Me.lblSelectContrast.Text = "Select Contrast"
        '
        'dlgContrasts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 256)
        Me.Controls.Add(Me.lblSelectContrast)
        Me.Controls.Add(Me.ucrInputContrast)
        Me.Controls.Add(Me.chkOverwriteExistContrast)
        Me.Controls.Add(Me.lblFactorReceiver)
        Me.Controls.Add(Me.ucrReceiverForContrasts)
        Me.Controls.Add(Me.ucrSelectorForContrast)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgContrasts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Contrasts"
        Me.Text = "Contrasts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForContrast As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverForContrasts As ucrReceiverSingle
    Friend WithEvents lblFactorReceiver As Label
    Friend WithEvents chkOverwriteExistContrast As CheckBox
    Friend WithEvents ucrInputContrast As ucrInputComboBox
    Friend WithEvents lblSelectContrast As Label
End Class
