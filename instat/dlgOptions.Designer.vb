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
        Me.tbcOptions = New System.Windows.Forms.TabControl()
        Me.tbpLanguageSettings = New System.Windows.Forms.TabPage()
        Me.rdoEnglish = New System.Windows.Forms.RadioButton()
        Me.rdoFrench = New System.Windows.Forms.RadioButton()
        Me.rdoKiswahili = New System.Windows.Forms.RadioButton()
        Me.tbpComments = New System.Windows.Forms.TabPage()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.tbpOutput = New System.Windows.Forms.TabPage()
        Me.cmdChangeSettings = New System.Windows.Forms.Button()
        Me.txtFontFamily = New System.Windows.Forms.TextBox()
        Me.txtFontColor = New System.Windows.Forms.TextBox()
        Me.lblColorFont = New System.Windows.Forms.Label()
        Me.lblFamilyFont = New System.Windows.Forms.Label()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdApply = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tbcOptions.SuspendLayout()
        Me.tbpLanguageSettings.SuspendLayout()
        Me.tbpComments.SuspendLayout()
        Me.tbpOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcOptions
        '
        Me.tbcOptions.Controls.Add(Me.tbpLanguageSettings)
        Me.tbcOptions.Controls.Add(Me.tbpComments)
        Me.tbcOptions.Controls.Add(Me.tbpOutput)
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
        'rdoEnglish
        '
        Me.rdoEnglish.AutoSize = True
        Me.rdoEnglish.Checked = True
        Me.rdoEnglish.Location = New System.Drawing.Point(20, 65)
        Me.rdoEnglish.Name = "rdoEnglish"
        Me.rdoEnglish.Size = New System.Drawing.Size(59, 17)
        Me.rdoEnglish.TabIndex = 0
        Me.rdoEnglish.TabStop = True
        Me.rdoEnglish.Tag = "English"
        Me.rdoEnglish.Text = "English"
        Me.rdoEnglish.UseVisualStyleBackColor = True
        '
        'rdoFrench
        '
        Me.rdoFrench.AutoSize = True
        Me.rdoFrench.Location = New System.Drawing.Point(20, 42)
        Me.rdoFrench.Name = "rdoFrench"
        Me.rdoFrench.Size = New System.Drawing.Size(58, 17)
        Me.rdoFrench.TabIndex = 0
        Me.rdoFrench.Tag = "French"
        Me.rdoFrench.Text = "French"
        Me.rdoFrench.UseVisualStyleBackColor = True
        '
        'rdoKiswahili
        '
        Me.rdoKiswahili.AutoSize = True
        Me.rdoKiswahili.Location = New System.Drawing.Point(20, 19)
        Me.rdoKiswahili.Name = "rdoKiswahili"
        Me.rdoKiswahili.Size = New System.Drawing.Size(65, 17)
        Me.rdoKiswahili.TabIndex = 0
        Me.rdoKiswahili.Tag = "Kiswahili"
        Me.rdoKiswahili.Text = "Kiswahili"
        Me.rdoKiswahili.UseVisualStyleBackColor = True
        '
        'tbpComments
        '
        Me.tbpComments.Controls.Add(Me.txtComment)
        Me.tbpComments.Controls.Add(Me.lblComment)
        Me.tbpComments.Location = New System.Drawing.Point(4, 22)
        Me.tbpComments.Name = "tbpComments"
        Me.tbpComments.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpComments.Size = New System.Drawing.Size(392, 233)
        Me.tbpComments.TabIndex = 1
        Me.tbpComments.Tag = "Comments"
        Me.tbpComments.Text = "Comments"
        Me.tbpComments.UseVisualStyleBackColor = True
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(110, 20)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(276, 20)
        Me.txtComment.TabIndex = 1
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Location = New System.Drawing.Point(7, 20)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(51, 13)
        Me.lblComment.TabIndex = 0
        Me.lblComment.Tag = "Comment"
        Me.lblComment.Text = "Comment"
        '
        'tbpOutput
        '
        Me.tbpOutput.Controls.Add(Me.lblTitle)
        Me.tbpOutput.Controls.Add(Me.cmdChangeSettings)
        Me.tbpOutput.Controls.Add(Me.txtFontFamily)
        Me.tbpOutput.Controls.Add(Me.txtFontColor)
        Me.tbpOutput.Controls.Add(Me.lblColorFont)
        Me.tbpOutput.Controls.Add(Me.lblFamilyFont)
        Me.tbpOutput.Location = New System.Drawing.Point(4, 22)
        Me.tbpOutput.Name = "tbpOutput"
        Me.tbpOutput.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpOutput.Size = New System.Drawing.Size(392, 233)
        Me.tbpOutput.TabIndex = 2
        Me.tbpOutput.Text = "Output Window"
        Me.tbpOutput.UseVisualStyleBackColor = True
        '
        'cmdChangeSettings
        '
        Me.cmdChangeSettings.Location = New System.Drawing.Point(153, 145)
        Me.cmdChangeSettings.Name = "cmdChangeSettings"
        Me.cmdChangeSettings.Size = New System.Drawing.Size(100, 23)
        Me.cmdChangeSettings.TabIndex = 4
        Me.cmdChangeSettings.Text = "Change settings"
        Me.cmdChangeSettings.UseVisualStyleBackColor = True
        '
        'txtFontFamily
        '
        Me.txtFontFamily.Location = New System.Drawing.Point(96, 63)
        Me.txtFontFamily.Name = "txtFontFamily"
        Me.txtFontFamily.ReadOnly = True
        Me.txtFontFamily.Size = New System.Drawing.Size(157, 20)
        Me.txtFontFamily.TabIndex = 3
        '
        'txtFontColor
        '
        Me.txtFontColor.Location = New System.Drawing.Point(153, 106)
        Me.txtFontColor.Name = "txtFontColor"
        Me.txtFontColor.ReadOnly = True
        Me.txtFontColor.Size = New System.Drawing.Size(100, 20)
        Me.txtFontColor.TabIndex = 2
        '
        'lblColorFont
        '
        Me.lblColorFont.AutoSize = True
        Me.lblColorFont.Location = New System.Drawing.Point(21, 109)
        Me.lblColorFont.Name = "lblColorFont"
        Me.lblColorFont.Size = New System.Drawing.Size(55, 13)
        Me.lblColorFont.TabIndex = 1
        Me.lblColorFont.Text = "Font Color"
        '
        'lblFamilyFont
        '
        Me.lblFamilyFont.AutoSize = True
        Me.lblFamilyFont.Location = New System.Drawing.Point(21, 66)
        Me.lblFamilyFont.Name = "lblFamilyFont"
        Me.lblFamilyFont.Size = New System.Drawing.Size(60, 13)
        Me.lblFamilyFont.TabIndex = 0
        Me.lblFamilyFont.Text = "Font Family"
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(17, 279)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 2
        Me.cmdOk.Tag = "Ok"
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdApply
        '
        Me.cmdApply.Location = New System.Drawing.Point(98, 279)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(75, 23)
        Me.cmdApply.TabIndex = 2
        Me.cmdApply.Tag = "Apply"
        Me.cmdApply.Text = "&Apply"
        Me.cmdApply.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(179, 279)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(261, 280)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdHelp.TabIndex = 3
        Me.cmdHelp.Tag = "Help"
        Me.cmdHelp.Text = "&Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(21, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(223, 13)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Font and Color options for the Output Window"
        '
        'dlgOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 330)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdApply)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.tbcOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Options"
        Me.Text = "Options"
        Me.tbcOptions.ResumeLayout(False)
        Me.tbpLanguageSettings.ResumeLayout(False)
        Me.tbpLanguageSettings.PerformLayout()
        Me.tbpComments.ResumeLayout(False)
        Me.tbpComments.PerformLayout()
        Me.tbpOutput.ResumeLayout(False)
        Me.tbpOutput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbcOptions As TabControl
    Friend WithEvents tbpLanguageSettings As TabPage
    Friend WithEvents rdoEnglish As RadioButton
    Friend WithEvents rdoFrench As RadioButton
    Friend WithEvents rdoKiswahili As RadioButton
    Friend WithEvents cmdOk As Button
    Friend WithEvents cmdApply As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents tbpComments As TabPage
    Friend WithEvents txtComment As TextBox
    Friend WithEvents lblComment As Label
    Friend WithEvents cmdHelp As Button
    Friend WithEvents tbpOutput As TabPage
    Friend WithEvents cmdChangeSettings As Button
    Friend WithEvents txtFontFamily As TextBox
    Friend WithEvents txtFontColor As TextBox
    Friend WithEvents lblColorFont As Label
    Friend WithEvents lblFamilyFont As Label
    Friend WithEvents lblTitle As Label
End Class
