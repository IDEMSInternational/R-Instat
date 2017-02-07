<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgImportFromODK
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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblChooseForm = New System.Windows.Forms.Label()
        Me.cmdFindForms = New System.Windows.Forms.Button()
        Me.grpPlatform = New System.Windows.Forms.GroupBox()
        Me.rdoOna = New System.Windows.Forms.RadioButton()
        Me.rdoKobo = New System.Windows.Forms.RadioButton()
        Me.ucrPnlPlatform = New instat.UcrPanel()
        Me.ucrChkViewPassword = New instat.ucrCheck()
        Me.ucrInputPassword = New instat.ucrInputTextBox()
        Me.ucrInputChooseForm = New instat.ucrInputComboBox()
        Me.ucrInputUsername = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpPlatform.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(7, 74)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(9, 111)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password:"
        '
        'lblChooseForm
        '
        Me.lblChooseForm.AutoSize = True
        Me.lblChooseForm.Location = New System.Drawing.Point(15, 170)
        Me.lblChooseForm.Name = "lblChooseForm"
        Me.lblChooseForm.Size = New System.Drawing.Size(72, 13)
        Me.lblChooseForm.TabIndex = 7
        Me.lblChooseForm.Text = "Choose Form:"
        '
        'cmdFindForms
        '
        Me.cmdFindForms.Location = New System.Drawing.Point(13, 138)
        Me.cmdFindForms.Name = "cmdFindForms"
        Me.cmdFindForms.Size = New System.Drawing.Size(102, 23)
        Me.cmdFindForms.TabIndex = 6
        Me.cmdFindForms.Text = "Find Forms"
        Me.cmdFindForms.UseVisualStyleBackColor = True
        '
        'grpPlatform
        '
        Me.grpPlatform.Controls.Add(Me.rdoOna)
        Me.grpPlatform.Controls.Add(Me.rdoKobo)
        Me.grpPlatform.Controls.Add(Me.ucrPnlPlatform)
        Me.grpPlatform.Location = New System.Drawing.Point(12, 12)
        Me.grpPlatform.Name = "grpPlatform"
        Me.grpPlatform.Size = New System.Drawing.Size(406, 46)
        Me.grpPlatform.TabIndex = 0
        Me.grpPlatform.TabStop = False
        Me.grpPlatform.Text = "Choose Platform"
        '
        'rdoOna
        '
        Me.rdoOna.AutoSize = True
        Me.rdoOna.Location = New System.Drawing.Point(152, 17)
        Me.rdoOna.Name = "rdoOna"
        Me.rdoOna.Size = New System.Drawing.Size(45, 17)
        Me.rdoOna.TabIndex = 1
        Me.rdoOna.TabStop = True
        Me.rdoOna.Text = "Ona"
        Me.rdoOna.UseVisualStyleBackColor = True
        '
        'rdoKobo
        '
        Me.rdoKobo.AutoSize = True
        Me.rdoKobo.Location = New System.Drawing.Point(10, 17)
        Me.rdoKobo.Name = "rdoKobo"
        Me.rdoKobo.Size = New System.Drawing.Size(50, 17)
        Me.rdoKobo.TabIndex = 0
        Me.rdoKobo.TabStop = True
        Me.rdoKobo.Text = "Kobo"
        Me.rdoKobo.UseVisualStyleBackColor = True
        '
        'ucrPnlPlatform
        '
        Me.ucrPnlPlatform.bAddRemoveParameter = True
        Me.ucrPnlPlatform.bChangeParameterValue = True
        Me.ucrPnlPlatform.Location = New System.Drawing.Point(3, 16)
        Me.ucrPnlPlatform.Name = "ucrPnlPlatform"
        Me.ucrPnlPlatform.Size = New System.Drawing.Size(300, 24)
        Me.ucrPnlPlatform.TabIndex = 0
        '
        'ucrChkViewPassword
        '
        Me.ucrChkViewPassword.bAddRemoveParameter = True
        Me.ucrChkViewPassword.bChangeParameterValue = True
        Me.ucrChkViewPassword.Checked = False
        Me.ucrChkViewPassword.Location = New System.Drawing.Point(250, 106)
        Me.ucrChkViewPassword.Name = "ucrChkViewPassword"
        Me.ucrChkViewPassword.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkViewPassword.TabIndex = 5
        '
        'ucrInputPassword
        '
        Me.ucrInputPassword.bAddRemoveParameter = True
        Me.ucrInputPassword.bChangeParameterValue = True
        Me.ucrInputPassword.IsMultiline = False
        Me.ucrInputPassword.IsReadOnly = False
        Me.ucrInputPassword.Location = New System.Drawing.Point(92, 106)
        Me.ucrInputPassword.Name = "ucrInputPassword"
        Me.ucrInputPassword.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPassword.TabIndex = 4
        '
        'ucrInputChooseForm
        '
        Me.ucrInputChooseForm.bAddRemoveParameter = True
        Me.ucrInputChooseForm.bChangeParameterValue = True
        Me.ucrInputChooseForm.IsReadOnly = False
        Me.ucrInputChooseForm.Location = New System.Drawing.Point(98, 167)
        Me.ucrInputChooseForm.Name = "ucrInputChooseForm"
        Me.ucrInputChooseForm.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputChooseForm.TabIndex = 8
        '
        'ucrInputUsername
        '
        Me.ucrInputUsername.bAddRemoveParameter = True
        Me.ucrInputUsername.bChangeParameterValue = True
        Me.ucrInputUsername.IsMultiline = False
        Me.ucrInputUsername.IsReadOnly = False
        Me.ucrInputUsername.Location = New System.Drawing.Point(92, 74)
        Me.ucrInputUsername.Name = "ucrInputUsername"
        Me.ucrInputUsername.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputUsername.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 194)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(420, 52)
        Me.ucrBase.TabIndex = 9
        '
        'dlgImportFromODK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 253)
        Me.Controls.Add(Me.ucrChkViewPassword)
        Me.Controls.Add(Me.grpPlatform)
        Me.Controls.Add(Me.ucrInputPassword)
        Me.Controls.Add(Me.cmdFindForms)
        Me.Controls.Add(Me.ucrInputChooseForm)
        Me.Controls.Add(Me.ucrInputUsername)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblChooseForm)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportFromODK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import from ODK"
        Me.grpPlatform.ResumeLayout(False)
        Me.grpPlatform.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblChooseForm As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputUsername As ucrInputTextBox
    Friend WithEvents ucrInputChooseForm As ucrInputComboBox
    Friend WithEvents cmdFindForms As Button
    Friend WithEvents ucrInputPassword As ucrInputTextBox
    Friend WithEvents grpPlatform As GroupBox
    Friend WithEvents rdoOna As RadioButton
    Friend WithEvents rdoKobo As RadioButton
    Friend WithEvents ucrPnlPlatform As UcrPanel
    Friend WithEvents ucrChkViewPassword As ucrCheck
End Class
