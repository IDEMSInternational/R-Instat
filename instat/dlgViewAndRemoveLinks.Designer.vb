<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgViewAndRemoveLinks
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
        Me.lblLinks = New System.Windows.Forms.Label()
        Me.lblLink = New System.Windows.Forms.Label()
        Me.rdoViewLink = New System.Windows.Forms.RadioButton()
        Me.rdoDeleteLink = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverViewLinks = New instat.ucrReceiverSingle()
        Me.ucrpnlDeleteView = New instat.UcrPanel()
        Me.ucrSelectorLinks = New instat.ucrSelector()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblLinks
        '
        Me.lblLinks.AutoSize = True
        Me.lblLinks.Location = New System.Drawing.Point(13, 13)
        Me.lblLinks.Name = "lblLinks"
        Me.lblLinks.Size = New System.Drawing.Size(35, 13)
        Me.lblLinks.TabIndex = 3
        Me.lblLinks.Text = "Links:"
        '
        'lblLink
        '
        Me.lblLink.AutoSize = True
        Me.lblLink.Location = New System.Drawing.Point(153, 13)
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Size = New System.Drawing.Size(30, 13)
        Me.lblLink.TabIndex = 4
        Me.lblLink.Text = "Link:"
        '
        'rdoViewLink
        '
        Me.rdoViewLink.AutoSize = True
        Me.rdoViewLink.Location = New System.Drawing.Point(163, 99)
        Me.rdoViewLink.Name = "rdoViewLink"
        Me.rdoViewLink.Size = New System.Drawing.Size(71, 17)
        Me.rdoViewLink.TabIndex = 14
        Me.rdoViewLink.TabStop = True
        Me.rdoViewLink.Text = "View Link"
        Me.rdoViewLink.UseVisualStyleBackColor = True
        '
        'rdoDeleteLink
        '
        Me.rdoDeleteLink.AutoSize = True
        Me.rdoDeleteLink.Location = New System.Drawing.Point(259, 99)
        Me.rdoDeleteLink.Name = "rdoDeleteLink"
        Me.rdoDeleteLink.Size = New System.Drawing.Size(79, 17)
        Me.rdoDeleteLink.TabIndex = 15
        Me.rdoDeleteLink.TabStop = True
        Me.rdoDeleteLink.Text = "Delete Link"
        Me.rdoDeleteLink.UseVisualStyleBackColor = True
        '
        'ucrReceiverViewLinks
        '
        Me.ucrReceiverViewLinks.frmParent = Me
        Me.ucrReceiverViewLinks.Location = New System.Drawing.Point(153, 30)
        Me.ucrReceiverViewLinks.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverViewLinks.Name = "ucrReceiverViewLinks"
        Me.ucrReceiverViewLinks.Selector = Nothing
        Me.ucrReceiverViewLinks.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverViewLinks.TabIndex = 16
        Me.ucrReceiverViewLinks.ucrSelector = Nothing
        '
        'ucrpnlDeleteView
        '
        Me.ucrpnlDeleteView.Location = New System.Drawing.Point(163, 84)
        Me.ucrpnlDeleteView.Name = "ucrpnlDeleteView"
        Me.ucrpnlDeleteView.Size = New System.Drawing.Size(187, 41)
        Me.ucrpnlDeleteView.TabIndex = 13
        '
        'ucrSelectorLinks
        '
        Me.ucrSelectorLinks.bShowHiddenColumns = False
        Me.ucrSelectorLinks.Location = New System.Drawing.Point(16, 30)
        Me.ucrSelectorLinks.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorLinks.Name = "ucrSelectorLinks"
        Me.ucrSelectorLinks.Size = New System.Drawing.Size(120, 98)
        Me.ucrSelectorLinks.TabIndex = 12
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 134)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 1
        '
        'dlgViewAndRemoveLinks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 193)
        Me.Controls.Add(Me.ucrReceiverViewLinks)
        Me.Controls.Add(Me.rdoDeleteLink)
        Me.Controls.Add(Me.rdoViewLink)
        Me.Controls.Add(Me.ucrpnlDeleteView)
        Me.Controls.Add(Me.ucrSelectorLinks)
        Me.Controls.Add(Me.lblLink)
        Me.Controls.Add(Me.lblLinks)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgViewAndRemoveLinks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View and Remove Links"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblLinks As Label
    Friend WithEvents lblLink As Label
    Friend WithEvents ucrSelectorLinks As ucrSelector
    Friend WithEvents rdoDeleteLink As RadioButton
    Friend WithEvents rdoViewLink As RadioButton
    Friend WithEvents ucrpnlDeleteView As UcrPanel
    Friend WithEvents ucrReceiverViewLinks As ucrReceiverSingle
End Class
