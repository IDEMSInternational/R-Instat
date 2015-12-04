<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFont
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
        Me.lstFontType = New System.Windows.Forms.ListBox()
        Me.lblFontType = New System.Windows.Forms.Label()
        Me.lstFontStyle = New System.Windows.Forms.ListBox()
        Me.lblFontStyle = New System.Windows.Forms.Label()
        Me.lstFontSize = New System.Windows.Forms.ListBox()
        Me.lblFontSize = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpEffects = New System.Windows.Forms.GroupBox()
        Me.grpSample = New System.Windows.Forms.GroupBox()
        Me.chkStrikeOut = New System.Windows.Forms.CheckBox()
        Me.chkUnderline = New System.Windows.Forms.CheckBox()
        Me.cboScript = New System.Windows.Forms.ComboBox()
        Me.lblScript = New System.Windows.Forms.Label()
        Me.llAaBbYyZz = New System.Windows.Forms.Label()
        Me.grpEffects.SuspendLayout()
        Me.grpSample.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstFontType
        '
        Me.lstFontType.FormattingEnabled = True
        Me.lstFontType.Location = New System.Drawing.Point(12, 29)
        Me.lstFontType.Name = "lstFontType"
        Me.lstFontType.Size = New System.Drawing.Size(97, 95)
        Me.lstFontType.TabIndex = 0
        '
        'lblFontType
        '
        Me.lblFontType.AutoSize = True
        Me.lblFontType.Location = New System.Drawing.Point(12, 13)
        Me.lblFontType.Name = "lblFontType"
        Me.lblFontType.Size = New System.Drawing.Size(51, 13)
        Me.lblFontType.TabIndex = 1
        Me.lblFontType.Tag = "Font_type"
        Me.lblFontType.Text = "Font type"
        '
        'lstFontStyle
        '
        Me.lstFontStyle.FormattingEnabled = True
        Me.lstFontStyle.Location = New System.Drawing.Point(124, 29)
        Me.lstFontStyle.Name = "lstFontStyle"
        Me.lstFontStyle.Size = New System.Drawing.Size(91, 95)
        Me.lstFontStyle.TabIndex = 2
        '
        'lblFontStyle
        '
        Me.lblFontStyle.AutoSize = True
        Me.lblFontStyle.Location = New System.Drawing.Point(121, 9)
        Me.lblFontStyle.Name = "lblFontStyle"
        Me.lblFontStyle.Size = New System.Drawing.Size(52, 13)
        Me.lblFontStyle.TabIndex = 1
        Me.lblFontStyle.Tag = "Font Style"
        Me.lblFontStyle.Text = "Font style"
        '
        'lstFontSize
        '
        Me.lstFontSize.FormattingEnabled = True
        Me.lstFontSize.Location = New System.Drawing.Point(232, 29)
        Me.lstFontSize.Name = "lstFontSize"
        Me.lstFontSize.Size = New System.Drawing.Size(39, 95)
        Me.lstFontSize.TabIndex = 3
        '
        'lblFontSize
        '
        Me.lblFontSize.AutoSize = True
        Me.lblFontSize.Location = New System.Drawing.Point(220, 13)
        Me.lblFontSize.Name = "lblFontSize"
        Me.lblFontSize.Size = New System.Drawing.Size(51, 13)
        Me.lblFontSize.TabIndex = 4
        Me.lblFontSize.Tag = "Font_size"
        Me.lblFontSize.Text = "Font Size"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 240)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 5
        '
        'grpEffects
        '
        Me.grpEffects.Controls.Add(Me.chkUnderline)
        Me.grpEffects.Controls.Add(Me.chkStrikeOut)
        Me.grpEffects.Location = New System.Drawing.Point(12, 130)
        Me.grpEffects.Name = "grpEffects"
        Me.grpEffects.Size = New System.Drawing.Size(121, 87)
        Me.grpEffects.TabIndex = 6
        Me.grpEffects.TabStop = False
        Me.grpEffects.Tag = "Effectss"
        Me.grpEffects.Text = "Effects"
        '
        'grpSample
        '
        Me.grpSample.Controls.Add(Me.llAaBbYyZz)
        Me.grpSample.Location = New System.Drawing.Point(182, 130)
        Me.grpSample.Name = "grpSample"
        Me.grpSample.Size = New System.Drawing.Size(159, 44)
        Me.grpSample.TabIndex = 6
        Me.grpSample.TabStop = False
        Me.grpSample.Tag = "Sample"
        Me.grpSample.Text = "Sample"
        '
        'chkStrikeOut
        '
        Me.chkStrikeOut.AutoSize = True
        Me.chkStrikeOut.Location = New System.Drawing.Point(7, 20)
        Me.chkStrikeOut.Name = "chkStrikeOut"
        Me.chkStrikeOut.Size = New System.Drawing.Size(68, 17)
        Me.chkStrikeOut.TabIndex = 0
        Me.chkStrikeOut.Tag = "Strikeout"
        Me.chkStrikeOut.Text = "Strikeout"
        Me.chkStrikeOut.UseVisualStyleBackColor = True
        '
        'chkUnderline
        '
        Me.chkUnderline.AutoSize = True
        Me.chkUnderline.Location = New System.Drawing.Point(7, 43)
        Me.chkUnderline.Name = "chkUnderline"
        Me.chkUnderline.Size = New System.Drawing.Size(71, 17)
        Me.chkUnderline.TabIndex = 0
        Me.chkUnderline.Tag = "Underline"
        Me.chkUnderline.Text = "Underline"
        Me.chkUnderline.UseVisualStyleBackColor = True
        '
        'cboScript
        '
        Me.cboScript.FormattingEnabled = True
        Me.cboScript.Location = New System.Drawing.Point(182, 196)
        Me.cboScript.Name = "cboScript"
        Me.cboScript.Size = New System.Drawing.Size(121, 21)
        Me.cboScript.TabIndex = 7
        '
        'lblScript
        '
        Me.lblScript.AutoSize = True
        Me.lblScript.Location = New System.Drawing.Point(179, 177)
        Me.lblScript.Name = "lblScript"
        Me.lblScript.Size = New System.Drawing.Size(37, 13)
        Me.lblScript.TabIndex = 8
        Me.lblScript.Tag = "Script"
        Me.lblScript.Text = "Script:"
        '
        'llAaBbYyZz
        '
        Me.llAaBbYyZz.AutoSize = True
        Me.llAaBbYyZz.Location = New System.Drawing.Point(47, 21)
        Me.llAaBbYyZz.Name = "llAaBbYyZz"
        Me.llAaBbYyZz.Size = New System.Drawing.Size(57, 13)
        Me.llAaBbYyZz.TabIndex = 0
        Me.llAaBbYyZz.Tag = "AaBbYyZz"
        Me.llAaBbYyZz.Text = "AaBbYyZz"
        '
        'dlgFont
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 284)
        Me.Controls.Add(Me.lblScript)
        Me.Controls.Add(Me.cboScript)
        Me.Controls.Add(Me.grpSample)
        Me.Controls.Add(Me.grpEffects)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblFontSize)
        Me.Controls.Add(Me.lstFontSize)
        Me.Controls.Add(Me.lstFontStyle)
        Me.Controls.Add(Me.lblFontStyle)
        Me.Controls.Add(Me.lblFontType)
        Me.Controls.Add(Me.lstFontType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgFont"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Font"
        Me.Text = "Font"
        Me.grpEffects.ResumeLayout(False)
        Me.grpEffects.PerformLayout()
        Me.grpSample.ResumeLayout(False)
        Me.grpSample.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstFontType As ListBox
    Friend WithEvents lblFontType As Label
    Friend WithEvents lstFontStyle As ListBox
    Friend WithEvents lblFontStyle As Label
    Friend WithEvents lstFontSize As ListBox
    Friend WithEvents lblFontSize As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpEffects As GroupBox
    Friend WithEvents grpSample As GroupBox
    Friend WithEvents chkUnderline As CheckBox
    Friend WithEvents chkStrikeOut As CheckBox
    Friend WithEvents cboScript As ComboBox
    Friend WithEvents lblScript As Label
    Friend WithEvents llAaBbYyZz As Label
End Class
