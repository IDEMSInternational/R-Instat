<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgViewAndRemoveLinks
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
        Me.lblLinks = New System.Windows.Forms.Label()
        Me.lblLink = New System.Windows.Forms.Label()
        Me.ucrReceiverLink = New instat.ucrReceiverSingle()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.ucrInputFrom = New instat.ucrInputTextBox()
        Me.ucrInputTo = New instat.ucrInputTextBox()
        Me.chkDeleteLink = New System.Windows.Forms.CheckBox()
        Me.ucrSlelectorLinks = New instat.ucrSelector()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 134)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 1
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
        Me.lblLink.Location = New System.Drawing.Point(160, 9)
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Size = New System.Drawing.Size(30, 13)
        Me.lblLink.TabIndex = 4
        Me.lblLink.Text = "Link:"
        '
        'ucrReceiverLink
        '
        Me.ucrReceiverLink.frmParent = Me
        Me.ucrReceiverLink.Location = New System.Drawing.Point(163, 26)
        Me.ucrReceiverLink.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLink.Name = "ucrReceiverLink"
        Me.ucrReceiverLink.Selector = Nothing
        Me.ucrReceiverLink.Size = New System.Drawing.Size(130, 20)
        Me.ucrReceiverLink.TabIndex = 5
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(160, 57)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 7
        Me.lblFrom.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(299, 56)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 8
        Me.lblTo.Text = "To:"
        '
        'ucrInputFrom
        '
        Me.ucrInputFrom.IsReadOnly = False
        Me.ucrInputFrom.Location = New System.Drawing.Point(199, 51)
        Me.ucrInputFrom.Name = "ucrInputFrom"
        Me.ucrInputFrom.Size = New System.Drawing.Size(94, 21)
        Me.ucrInputFrom.TabIndex = 9
        '
        'ucrInputTo
        '
        Me.ucrInputTo.IsReadOnly = False
        Me.ucrInputTo.Location = New System.Drawing.Point(328, 51)
        Me.ucrInputTo.Name = "ucrInputTo"
        Me.ucrInputTo.Size = New System.Drawing.Size(94, 21)
        Me.ucrInputTo.TabIndex = 10
        '
        'chkDeleteLink
        '
        Me.chkDeleteLink.AutoSize = True
        Me.chkDeleteLink.Location = New System.Drawing.Point(163, 89)
        Me.chkDeleteLink.Name = "chkDeleteLink"
        Me.chkDeleteLink.Size = New System.Drawing.Size(80, 17)
        Me.chkDeleteLink.TabIndex = 11
        Me.chkDeleteLink.Text = "Delete Link"
        Me.chkDeleteLink.UseVisualStyleBackColor = True
        '
        'ucrSlelectorLinks
        '
        Me.ucrSlelectorLinks.bShowHiddenColumns = False
        Me.ucrSlelectorLinks.Location = New System.Drawing.Point(16, 30)
        Me.ucrSlelectorLinks.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSlelectorLinks.Name = "ucrSlelectorLinks"
        Me.ucrSlelectorLinks.Size = New System.Drawing.Size(120, 98)
        Me.ucrSlelectorLinks.TabIndex = 12
        '
        'dlgViewAndRemoveLinks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 193)
        Me.Controls.Add(Me.ucrSlelectorLinks)
        Me.Controls.Add(Me.chkDeleteLink)
        Me.Controls.Add(Me.ucrInputTo)
        Me.Controls.Add(Me.ucrInputFrom)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.ucrReceiverLink)
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
    Friend WithEvents ucrReceiverLink As ucrReceiverSingle
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents ucrInputFrom As ucrInputTextBox
    Friend WithEvents ucrInputTo As ucrInputTextBox
    Friend WithEvents chkDeleteLink As CheckBox
    Friend WithEvents ucrSlelectorLinks As ucrSelector
End Class
