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
        Me.lblSelectedLink = New System.Windows.Forms.Label()
        Me.rdoViewLink = New System.Windows.Forms.RadioButton()
        Me.rdoDeleteLink = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverViewLinks = New instat.ucrReceiverSingle()
        Me.ucrPnlLinks = New instat.UcrPanel()
        Me.ucrSelectorLinks = New instat.ucrSelector()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblLinks
        '
        Me.lblLinks.AutoSize = True
        Me.lblLinks.Location = New System.Drawing.Point(12, 15)
        Me.lblLinks.Name = "lblLinks"
        Me.lblLinks.Size = New System.Drawing.Size(35, 13)
        Me.lblLinks.TabIndex = 0
        Me.lblLinks.Text = "Links:"
        '
        'lblSelectedLink
        '
        Me.lblSelectedLink.AutoSize = True
        Me.lblSelectedLink.Location = New System.Drawing.Point(196, 28)
        Me.lblSelectedLink.Name = "lblSelectedLink"
        Me.lblSelectedLink.Size = New System.Drawing.Size(75, 13)
        Me.lblSelectedLink.TabIndex = 2
        Me.lblSelectedLink.Text = "Selected Link:"
        '
        'rdoViewLink
        '
        Me.rdoViewLink.AutoSize = True
        Me.rdoViewLink.Location = New System.Drawing.Point(194, 74)
        Me.rdoViewLink.Name = "rdoViewLink"
        Me.rdoViewLink.Size = New System.Drawing.Size(71, 17)
        Me.rdoViewLink.TabIndex = 5
        Me.rdoViewLink.TabStop = True
        Me.rdoViewLink.Text = "View Link"
        Me.rdoViewLink.UseVisualStyleBackColor = True
        '
        'rdoDeleteLink
        '
        Me.rdoDeleteLink.AutoSize = True
        Me.rdoDeleteLink.Location = New System.Drawing.Point(194, 97)
        Me.rdoDeleteLink.Name = "rdoDeleteLink"
        Me.rdoDeleteLink.Size = New System.Drawing.Size(79, 17)
        Me.rdoDeleteLink.TabIndex = 6
        Me.rdoDeleteLink.TabStop = True
        Me.rdoDeleteLink.Text = "Delete Link"
        Me.rdoDeleteLink.UseVisualStyleBackColor = True
        '
        'ucrReceiverViewLinks
        '
        Me.ucrReceiverViewLinks.frmParent = Me
        Me.ucrReceiverViewLinks.Location = New System.Drawing.Point(194, 43)
        Me.ucrReceiverViewLinks.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverViewLinks.Name = "ucrReceiverViewLinks"
        Me.ucrReceiverViewLinks.Selector = Nothing
        Me.ucrReceiverViewLinks.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverViewLinks.strNcFilePath = ""
        Me.ucrReceiverViewLinks.TabIndex = 3
        Me.ucrReceiverViewLinks.ucrSelector = Nothing
        '
        'ucrPnlLinks
        '
        Me.ucrPnlLinks.Location = New System.Drawing.Point(184, 66)
        Me.ucrPnlLinks.Name = "ucrPnlLinks"
        Me.ucrPnlLinks.Size = New System.Drawing.Size(130, 62)
        Me.ucrPnlLinks.TabIndex = 4
        '
        'ucrSelectorLinks
        '
        Me.ucrSelectorLinks.bShowHiddenColumns = False
        Me.ucrSelectorLinks.Location = New System.Drawing.Point(10, 30)
        Me.ucrSelectorLinks.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorLinks.Name = "ucrSelectorLinks"
        Me.ucrSelectorLinks.Size = New System.Drawing.Size(120, 98)
        Me.ucrSelectorLinks.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 134)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 7
        '
        'dlgViewAndRemoveLinks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 191)
        Me.Controls.Add(Me.ucrReceiverViewLinks)
        Me.Controls.Add(Me.rdoDeleteLink)
        Me.Controls.Add(Me.rdoViewLink)
        Me.Controls.Add(Me.ucrPnlLinks)
        Me.Controls.Add(Me.ucrSelectorLinks)
        Me.Controls.Add(Me.lblSelectedLink)
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
    Friend WithEvents lblSelectedLink As Label
    Friend WithEvents ucrSelectorLinks As ucrSelector
    Friend WithEvents rdoDeleteLink As RadioButton
    Friend WithEvents rdoViewLink As RadioButton
    Friend WithEvents ucrPnlLinks As UcrPanel
    Friend WithEvents ucrReceiverViewLinks As ucrReceiverSingle
End Class
