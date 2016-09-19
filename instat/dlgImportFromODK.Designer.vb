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
        Me.lblChoosePlatform = New System.Windows.Forms.Label()
        Me.rdoKobo = New System.Windows.Forms.RadioButton()
        Me.rdoOna = New System.Windows.Forms.RadioButton()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblChooseForm = New System.Windows.Forms.Label()
        Me.cmdFindForms = New System.Windows.Forms.Button()
        Me.ucrInputChooseForm = New instat.ucrInputComboBox()
        Me.ucrInputPassword = New instat.ucrInputTextBox()
        Me.ucrInputUsername = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.chkViewPassword = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblChoosePlatform
        '
        Me.lblChoosePlatform.AutoSize = True
        Me.lblChoosePlatform.Location = New System.Drawing.Point(9, 9)
        Me.lblChoosePlatform.Name = "lblChoosePlatform"
        Me.lblChoosePlatform.Size = New System.Drawing.Size(90, 13)
        Me.lblChoosePlatform.TabIndex = 0
        Me.lblChoosePlatform.Text = "Choose Platform :"
        '
        'rdoKobo
        '
        Me.rdoKobo.AutoSize = True
        Me.rdoKobo.Location = New System.Drawing.Point(105, 7)
        Me.rdoKobo.Name = "rdoKobo"
        Me.rdoKobo.Size = New System.Drawing.Size(50, 17)
        Me.rdoKobo.TabIndex = 1
        Me.rdoKobo.TabStop = True
        Me.rdoKobo.Text = "Kobo"
        Me.rdoKobo.UseVisualStyleBackColor = True
        '
        'rdoOna
        '
        Me.rdoOna.AutoSize = True
        Me.rdoOna.Location = New System.Drawing.Point(161, 7)
        Me.rdoOna.Name = "rdoOna"
        Me.rdoOna.Size = New System.Drawing.Size(45, 17)
        Me.rdoOna.TabIndex = 2
        Me.rdoOna.TabStop = True
        Me.rdoOna.Text = "Ona"
        Me.rdoOna.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(9, 37)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(61, 13)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "Username :"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(9, 68)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(59, 13)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password :"
        '
        'lblChooseForm
        '
        Me.lblChooseForm.AutoSize = True
        Me.lblChooseForm.Location = New System.Drawing.Point(9, 123)
        Me.lblChooseForm.Name = "lblChooseForm"
        Me.lblChooseForm.Size = New System.Drawing.Size(72, 13)
        Me.lblChooseForm.TabIndex = 6
        Me.lblChooseForm.Text = "Choose form :"
        '
        'cmdFindForms
        '
        Me.cmdFindForms.Location = New System.Drawing.Point(12, 88)
        Me.cmdFindForms.Name = "cmdFindForms"
        Me.cmdFindForms.Size = New System.Drawing.Size(102, 23)
        Me.cmdFindForms.TabIndex = 14
        Me.cmdFindForms.Text = "Find Froms"
        Me.cmdFindForms.UseVisualStyleBackColor = True
        '
        'ucrInputChooseForm
        '
        Me.ucrInputChooseForm.IsReadOnly = False
        Me.ucrInputChooseForm.Location = New System.Drawing.Point(105, 117)
        Me.ucrInputChooseForm.Name = "ucrInputChooseForm"
        Me.ucrInputChooseForm.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputChooseForm.TabIndex = 13
        '
        'ucrInputPassword
        '
        Me.ucrInputPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucrInputPassword.IsReadOnly = False
        Me.ucrInputPassword.Location = New System.Drawing.Point(105, 61)
        Me.ucrInputPassword.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrInputPassword.Name = "ucrInputPassword"
        Me.ucrInputPassword.Size = New System.Drawing.Size(137, 20)
        Me.ucrInputPassword.TabIndex = 12
        '
        'ucrInputUsername
        '
        Me.ucrInputUsername.IsReadOnly = False
        Me.ucrInputUsername.Location = New System.Drawing.Point(105, 32)
        Me.ucrInputUsername.Name = "ucrInputUsername"
        Me.ucrInputUsername.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputUsername.TabIndex = 11
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 144)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(420, 52)
        Me.ucrBase.TabIndex = 10
        '
        'chkViewPassword
        '
        Me.chkViewPassword.AutoSize = True
        Me.chkViewPassword.Location = New System.Drawing.Point(250, 63)
        Me.chkViewPassword.Name = "chkViewPassword"
        Me.chkViewPassword.Size = New System.Drawing.Size(98, 17)
        Me.chkViewPassword.TabIndex = 15
        Me.chkViewPassword.Text = "View Password"
        Me.chkViewPassword.UseVisualStyleBackColor = True
        '
        'dlgImportFromODK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 201)
        Me.Controls.Add(Me.chkViewPassword)
        Me.Controls.Add(Me.cmdFindForms)
        Me.Controls.Add(Me.ucrInputChooseForm)
        Me.Controls.Add(Me.ucrInputPassword)
        Me.Controls.Add(Me.ucrInputUsername)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblChooseForm)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.rdoOna)
        Me.Controls.Add(Me.rdoKobo)
        Me.Controls.Add(Me.lblChoosePlatform)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportFromODK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import from ODK"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblChoosePlatform As Label
    Friend WithEvents rdoKobo As RadioButton
    Friend WithEvents rdoOna As RadioButton
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblChooseForm As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputUsername As ucrInputTextBox
    Friend WithEvents ucrInputPassword As ucrInputTextBox
    Friend WithEvents ucrInputChooseForm As ucrInputComboBox
    Friend WithEvents cmdFindForms As Button
    Friend WithEvents chkViewPassword As CheckBox
End Class
