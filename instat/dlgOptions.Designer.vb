<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgOptions
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
        Me.tbcOptions = New System.Windows.Forms.TabControl()
        Me.tbpLanguageSettings = New System.Windows.Forms.TabPage()
        Me.rdoKiswahili = New System.Windows.Forms.RadioButton()
        Me.rdoFrench = New System.Windows.Forms.RadioButton()
        Me.rdoEnglish = New System.Windows.Forms.RadioButton()
        Me.tbcOptions.SuspendLayout()
        Me.tbpLanguageSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 278)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 59)
        Me.ucrBase.TabIndex = 0
        '
        'tbcOptions
        '
        Me.tbcOptions.Controls.Add(Me.tbpLanguageSettings)
        Me.tbcOptions.Location = New System.Drawing.Point(13, 13)
        Me.tbcOptions.Name = "tbcOptions"
        Me.tbcOptions.SelectedIndex = 0
        Me.tbcOptions.Size = New System.Drawing.Size(400, 259)
        Me.tbcOptions.TabIndex = 1
        '
        'tbpLanguageSettings
        '
        Me.tbpLanguageSettings.Controls.Add(Me.rdoEnglish)
        Me.tbpLanguageSettings.Controls.Add(Me.rdoFrench)
        Me.tbpLanguageSettings.Controls.Add(Me.rdoKiswahili)
        Me.tbpLanguageSettings.Location = New System.Drawing.Point(4, 22)
        Me.tbpLanguageSettings.Name = "tbpLanguageSettings"
        Me.tbpLanguageSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpLanguageSettings.Size = New System.Drawing.Size(392, 233)
        Me.tbpLanguageSettings.TabIndex = 0
        Me.tbpLanguageSettings.Tag = "Language_Settings"
        Me.tbpLanguageSettings.Text = "Language Settings"
        Me.tbpLanguageSettings.UseVisualStyleBackColor = True
        '
        'rdoKiswahili
        '
        Me.rdoKiswahili.AutoSize = True
        Me.rdoKiswahili.Location = New System.Drawing.Point(20, 19)
        Me.rdoKiswahili.Name = "rdoKiswahili"
        Me.rdoKiswahili.Size = New System.Drawing.Size(65, 17)
        Me.rdoKiswahili.TabIndex = 0
        Me.rdoKiswahili.TabStop = True
        Me.rdoKiswahili.Tag = "Kiswahili"
        Me.rdoKiswahili.Text = "Kiswahili"
        Me.rdoKiswahili.UseVisualStyleBackColor = True
        '
        'rdoFrench
        '
        Me.rdoFrench.AutoSize = True
        Me.rdoFrench.Location = New System.Drawing.Point(20, 42)
        Me.rdoFrench.Name = "rdoFrench"
        Me.rdoFrench.Size = New System.Drawing.Size(58, 17)
        Me.rdoFrench.TabIndex = 0
        Me.rdoFrench.TabStop = True
        Me.rdoFrench.Tag = "French"
        Me.rdoFrench.Text = "French"
        Me.rdoFrench.UseVisualStyleBackColor = True
        '
        'rdoEnglish
        '
        Me.rdoEnglish.AutoSize = True
        Me.rdoEnglish.Location = New System.Drawing.Point(20, 65)
        Me.rdoEnglish.Name = "rdoEnglish"
        Me.rdoEnglish.Size = New System.Drawing.Size(59, 17)
        Me.rdoEnglish.TabIndex = 0
        Me.rdoEnglish.TabStop = True
        Me.rdoEnglish.Tag = "English"
        Me.rdoEnglish.Text = "English"
        Me.rdoEnglish.UseVisualStyleBackColor = True
        '
        'dlgOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 330)
        Me.Controls.Add(Me.tbcOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Options"
        Me.Text = "Options"
        Me.tbcOptions.ResumeLayout(False)
        Me.tbpLanguageSettings.ResumeLayout(False)
        Me.tbpLanguageSettings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents tbcOptions As TabControl
    Friend WithEvents tbpLanguageSettings As TabPage
    Friend WithEvents rdoEnglish As RadioButton
    Friend WithEvents rdoFrench As RadioButton
    Friend WithEvents rdoKiswahili As RadioButton
End Class
