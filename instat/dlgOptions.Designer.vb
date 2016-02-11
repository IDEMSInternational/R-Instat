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
        Me.tbpFormat = New System.Windows.Forms.TabPage()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdApply = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.thpOptions = New System.Windows.Forms.TabControl()
        Me.tbpScript = New System.Windows.Forms.TabPage()
        Me.tbpROutput = New System.Windows.Forms.TabPage()
        Me.tbpComment = New System.Windows.Forms.TabPage()
        Me.lblScriptTitle = New System.Windows.Forms.Label()
        Me.cmdScriptChange = New System.Windows.Forms.Button()
        Me.txtScriptFont = New System.Windows.Forms.TextBox()
        Me.txtScriptColor = New System.Windows.Forms.TextBox()
        Me.lblScriptColor = New System.Windows.Forms.Label()
        Me.lblScriptFont = New System.Windows.Forms.Label()
        Me.lblOutputTitle = New System.Windows.Forms.Label()
        Me.cmdOutputChange = New System.Windows.Forms.Button()
        Me.txtOutputFont = New System.Windows.Forms.TextBox()
        Me.txtOutputcolor = New System.Windows.Forms.TextBox()
        Me.lblOutputColor = New System.Windows.Forms.Label()
        Me.lblOutputFont = New System.Windows.Forms.Label()
        Me.lblCommentsTitle = New System.Windows.Forms.Label()
        Me.cmdCommentsChange = New System.Windows.Forms.Button()
        Me.txtCommentsFont = New System.Windows.Forms.TextBox()
        Me.txtCommentsColor = New System.Windows.Forms.TextBox()
        Me.lblCommentsColor = New System.Windows.Forms.Label()
        Me.lblCommentsFont = New System.Windows.Forms.Label()
        Me.lblScriptSize = New System.Windows.Forms.Label()
        Me.txtScriptSize = New System.Windows.Forms.TextBox()
        Me.txtOutputSize = New System.Windows.Forms.TextBox()
        Me.lblOutputsize = New System.Windows.Forms.Label()
        Me.txtCommentsSize = New System.Windows.Forms.TextBox()
        Me.lblCommentsSize = New System.Windows.Forms.Label()
        Me.tbcOptions.SuspendLayout()
        Me.tbpLanguageSettings.SuspendLayout()
        Me.tbpComments.SuspendLayout()
        Me.tbpFormat.SuspendLayout()
        Me.thpOptions.SuspendLayout()
        Me.tbpScript.SuspendLayout()
        Me.tbpROutput.SuspendLayout()
        Me.tbpComment.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcOptions
        '
        Me.tbcOptions.Controls.Add(Me.tbpLanguageSettings)
        Me.tbcOptions.Controls.Add(Me.tbpComments)
        Me.tbcOptions.Controls.Add(Me.tbpFormat)
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
        'tbpFormat
        '
        Me.tbpFormat.Controls.Add(Me.thpOptions)
        Me.tbpFormat.Location = New System.Drawing.Point(4, 22)
        Me.tbpFormat.Name = "tbpFormat"
        Me.tbpFormat.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpFormat.Size = New System.Drawing.Size(392, 233)
        Me.tbpFormat.TabIndex = 2
        Me.tbpFormat.Text = "Format Options"
        Me.tbpFormat.UseVisualStyleBackColor = True
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
        'thpOptions
        '
        Me.thpOptions.Controls.Add(Me.tbpScript)
        Me.thpOptions.Controls.Add(Me.tbpROutput)
        Me.thpOptions.Controls.Add(Me.tbpComment)
        Me.thpOptions.Location = New System.Drawing.Point(0, 0)
        Me.thpOptions.Name = "thpOptions"
        Me.thpOptions.SelectedIndex = 0
        Me.thpOptions.Size = New System.Drawing.Size(283, 227)
        Me.thpOptions.TabIndex = 0
        '
        'tbpScript
        '
        Me.tbpScript.Controls.Add(Me.txtScriptSize)
        Me.tbpScript.Controls.Add(Me.lblScriptSize)
        Me.tbpScript.Controls.Add(Me.lblScriptTitle)
        Me.tbpScript.Controls.Add(Me.cmdScriptChange)
        Me.tbpScript.Controls.Add(Me.txtScriptFont)
        Me.tbpScript.Controls.Add(Me.txtScriptColor)
        Me.tbpScript.Controls.Add(Me.lblScriptColor)
        Me.tbpScript.Controls.Add(Me.lblScriptFont)
        Me.tbpScript.Location = New System.Drawing.Point(4, 22)
        Me.tbpScript.Name = "tbpScript"
        Me.tbpScript.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpScript.Size = New System.Drawing.Size(275, 201)
        Me.tbpScript.TabIndex = 0
        Me.tbpScript.Text = "R Script"
        Me.tbpScript.UseVisualStyleBackColor = True
        '
        'tbpROutput
        '
        Me.tbpROutput.Controls.Add(Me.txtOutputSize)
        Me.tbpROutput.Controls.Add(Me.lblOutputsize)
        Me.tbpROutput.Controls.Add(Me.lblOutputTitle)
        Me.tbpROutput.Controls.Add(Me.cmdOutputChange)
        Me.tbpROutput.Controls.Add(Me.txtOutputFont)
        Me.tbpROutput.Controls.Add(Me.txtOutputcolor)
        Me.tbpROutput.Controls.Add(Me.lblOutputColor)
        Me.tbpROutput.Controls.Add(Me.lblOutputFont)
        Me.tbpROutput.Location = New System.Drawing.Point(4, 22)
        Me.tbpROutput.Name = "tbpROutput"
        Me.tbpROutput.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpROutput.Size = New System.Drawing.Size(275, 201)
        Me.tbpROutput.TabIndex = 1
        Me.tbpROutput.Text = "R Output"
        Me.tbpROutput.UseVisualStyleBackColor = True
        '
        'tbpComment
        '
        Me.tbpComment.Controls.Add(Me.txtCommentsSize)
        Me.tbpComment.Controls.Add(Me.lblCommentsSize)
        Me.tbpComment.Controls.Add(Me.lblCommentsTitle)
        Me.tbpComment.Controls.Add(Me.cmdCommentsChange)
        Me.tbpComment.Controls.Add(Me.txtCommentsFont)
        Me.tbpComment.Controls.Add(Me.txtCommentsColor)
        Me.tbpComment.Controls.Add(Me.lblCommentsColor)
        Me.tbpComment.Controls.Add(Me.lblCommentsFont)
        Me.tbpComment.Location = New System.Drawing.Point(4, 22)
        Me.tbpComment.Name = "tbpComment"
        Me.tbpComment.Size = New System.Drawing.Size(275, 201)
        Me.tbpComment.TabIndex = 2
        Me.tbpComment.Text = "Comments"
        Me.tbpComment.UseVisualStyleBackColor = True
        '
        'lblScriptTitle
        '
        Me.lblScriptTitle.AutoSize = True
        Me.lblScriptTitle.Location = New System.Drawing.Point(10, 5)
        Me.lblScriptTitle.Name = "lblScriptTitle"
        Me.lblScriptTitle.Size = New System.Drawing.Size(187, 13)
        Me.lblScriptTitle.TabIndex = 11
        Me.lblScriptTitle.Text = "Font and Color options for the R Script"
        '
        'cmdScriptChange
        '
        Me.cmdScriptChange.Location = New System.Drawing.Point(142, 158)
        Me.cmdScriptChange.Name = "cmdScriptChange"
        Me.cmdScriptChange.Size = New System.Drawing.Size(100, 23)
        Me.cmdScriptChange.TabIndex = 10
        Me.cmdScriptChange.Text = "Change settings"
        Me.cmdScriptChange.UseVisualStyleBackColor = True
        '
        'txtScriptFont
        '
        Me.txtScriptFont.Location = New System.Drawing.Point(85, 23)
        Me.txtScriptFont.Name = "txtScriptFont"
        Me.txtScriptFont.ReadOnly = True
        Me.txtScriptFont.Size = New System.Drawing.Size(157, 20)
        Me.txtScriptFont.TabIndex = 9
        '
        'txtScriptColor
        '
        Me.txtScriptColor.Location = New System.Drawing.Point(142, 66)
        Me.txtScriptColor.Name = "txtScriptColor"
        Me.txtScriptColor.ReadOnly = True
        Me.txtScriptColor.Size = New System.Drawing.Size(100, 20)
        Me.txtScriptColor.TabIndex = 8
        '
        'lblScriptColor
        '
        Me.lblScriptColor.AutoSize = True
        Me.lblScriptColor.Location = New System.Drawing.Point(10, 69)
        Me.lblScriptColor.Name = "lblScriptColor"
        Me.lblScriptColor.Size = New System.Drawing.Size(55, 13)
        Me.lblScriptColor.TabIndex = 7
        Me.lblScriptColor.Text = "Font Color"
        '
        'lblScriptFont
        '
        Me.lblScriptFont.AutoSize = True
        Me.lblScriptFont.Location = New System.Drawing.Point(10, 26)
        Me.lblScriptFont.Name = "lblScriptFont"
        Me.lblScriptFont.Size = New System.Drawing.Size(60, 13)
        Me.lblScriptFont.TabIndex = 6
        Me.lblScriptFont.Text = "Font Family"
        '
        'lblOutputTitle
        '
        Me.lblOutputTitle.AutoSize = True
        Me.lblOutputTitle.Location = New System.Drawing.Point(7, 8)
        Me.lblOutputTitle.Name = "lblOutputTitle"
        Me.lblOutputTitle.Size = New System.Drawing.Size(192, 13)
        Me.lblOutputTitle.TabIndex = 17
        Me.lblOutputTitle.Text = "Font and Color options for the R Output"
        '
        'cmdOutputChange
        '
        Me.cmdOutputChange.Location = New System.Drawing.Point(139, 140)
        Me.cmdOutputChange.Name = "cmdOutputChange"
        Me.cmdOutputChange.Size = New System.Drawing.Size(100, 23)
        Me.cmdOutputChange.TabIndex = 16
        Me.cmdOutputChange.Text = "Change settings"
        Me.cmdOutputChange.UseVisualStyleBackColor = True
        '
        'txtOutputFont
        '
        Me.txtOutputFont.Location = New System.Drawing.Point(82, 27)
        Me.txtOutputFont.Name = "txtOutputFont"
        Me.txtOutputFont.ReadOnly = True
        Me.txtOutputFont.Size = New System.Drawing.Size(157, 20)
        Me.txtOutputFont.TabIndex = 15
        '
        'txtOutputcolor
        '
        Me.txtOutputcolor.Location = New System.Drawing.Point(139, 70)
        Me.txtOutputcolor.Name = "txtOutputcolor"
        Me.txtOutputcolor.ReadOnly = True
        Me.txtOutputcolor.Size = New System.Drawing.Size(100, 20)
        Me.txtOutputcolor.TabIndex = 14
        '
        'lblOutputColor
        '
        Me.lblOutputColor.AutoSize = True
        Me.lblOutputColor.Location = New System.Drawing.Point(7, 73)
        Me.lblOutputColor.Name = "lblOutputColor"
        Me.lblOutputColor.Size = New System.Drawing.Size(55, 13)
        Me.lblOutputColor.TabIndex = 13
        Me.lblOutputColor.Text = "Font Color"
        '
        'lblOutputFont
        '
        Me.lblOutputFont.AutoSize = True
        Me.lblOutputFont.Location = New System.Drawing.Point(7, 30)
        Me.lblOutputFont.Name = "lblOutputFont"
        Me.lblOutputFont.Size = New System.Drawing.Size(60, 13)
        Me.lblOutputFont.TabIndex = 12
        Me.lblOutputFont.Text = "Font Family"
        '
        'lblCommentsTitle
        '
        Me.lblCommentsTitle.AutoSize = True
        Me.lblCommentsTitle.Location = New System.Drawing.Point(7, 9)
        Me.lblCommentsTitle.Name = "lblCommentsTitle"
        Me.lblCommentsTitle.Size = New System.Drawing.Size(198, 13)
        Me.lblCommentsTitle.TabIndex = 17
        Me.lblCommentsTitle.Text = "Font and Color options for the Comments"
        '
        'cmdCommentsChange
        '
        Me.cmdCommentsChange.Location = New System.Drawing.Point(139, 141)
        Me.cmdCommentsChange.Name = "cmdCommentsChange"
        Me.cmdCommentsChange.Size = New System.Drawing.Size(100, 23)
        Me.cmdCommentsChange.TabIndex = 16
        Me.cmdCommentsChange.Text = "Change settings"
        Me.cmdCommentsChange.UseVisualStyleBackColor = True
        '
        'txtCommentsFont
        '
        Me.txtCommentsFont.Location = New System.Drawing.Point(82, 26)
        Me.txtCommentsFont.Name = "txtCommentsFont"
        Me.txtCommentsFont.ReadOnly = True
        Me.txtCommentsFont.Size = New System.Drawing.Size(157, 20)
        Me.txtCommentsFont.TabIndex = 15
        '
        'txtCommentsColor
        '
        Me.txtCommentsColor.Location = New System.Drawing.Point(139, 69)
        Me.txtCommentsColor.Name = "txtCommentsColor"
        Me.txtCommentsColor.ReadOnly = True
        Me.txtCommentsColor.Size = New System.Drawing.Size(100, 20)
        Me.txtCommentsColor.TabIndex = 14
        '
        'lblCommentsColor
        '
        Me.lblCommentsColor.AutoSize = True
        Me.lblCommentsColor.Location = New System.Drawing.Point(7, 72)
        Me.lblCommentsColor.Name = "lblCommentsColor"
        Me.lblCommentsColor.Size = New System.Drawing.Size(55, 13)
        Me.lblCommentsColor.TabIndex = 13
        Me.lblCommentsColor.Text = "Font Color"
        '
        'lblCommentsFont
        '
        Me.lblCommentsFont.AutoSize = True
        Me.lblCommentsFont.Location = New System.Drawing.Point(7, 29)
        Me.lblCommentsFont.Name = "lblCommentsFont"
        Me.lblCommentsFont.Size = New System.Drawing.Size(60, 13)
        Me.lblCommentsFont.TabIndex = 12
        Me.lblCommentsFont.Text = "Font Family"
        '
        'lblScriptSize
        '
        Me.lblScriptSize.AutoSize = True
        Me.lblScriptSize.Location = New System.Drawing.Point(10, 107)
        Me.lblScriptSize.Name = "lblScriptSize"
        Me.lblScriptSize.Size = New System.Drawing.Size(51, 13)
        Me.lblScriptSize.TabIndex = 12
        Me.lblScriptSize.Text = "Font Size"
        '
        'txtScriptSize
        '
        Me.txtScriptSize.Location = New System.Drawing.Point(142, 100)
        Me.txtScriptSize.Name = "txtScriptSize"
        Me.txtScriptSize.ReadOnly = True
        Me.txtScriptSize.Size = New System.Drawing.Size(100, 20)
        Me.txtScriptSize.TabIndex = 13
        '
        'txtOutputSize
        '
        Me.txtOutputSize.Location = New System.Drawing.Point(139, 107)
        Me.txtOutputSize.Name = "txtOutputSize"
        Me.txtOutputSize.ReadOnly = True
        Me.txtOutputSize.Size = New System.Drawing.Size(100, 20)
        Me.txtOutputSize.TabIndex = 19
        '
        'lblOutputsize
        '
        Me.lblOutputsize.AutoSize = True
        Me.lblOutputsize.Location = New System.Drawing.Point(7, 114)
        Me.lblOutputsize.Name = "lblOutputsize"
        Me.lblOutputsize.Size = New System.Drawing.Size(51, 13)
        Me.lblOutputsize.TabIndex = 18
        Me.lblOutputsize.Text = "Font Size"
        '
        'txtCommentsSize
        '
        Me.txtCommentsSize.Location = New System.Drawing.Point(140, 102)
        Me.txtCommentsSize.Name = "txtCommentsSize"
        Me.txtCommentsSize.ReadOnly = True
        Me.txtCommentsSize.Size = New System.Drawing.Size(100, 20)
        Me.txtCommentsSize.TabIndex = 19
        '
        'lblCommentsSize
        '
        Me.lblCommentsSize.AutoSize = True
        Me.lblCommentsSize.Location = New System.Drawing.Point(8, 109)
        Me.lblCommentsSize.Name = "lblCommentsSize"
        Me.lblCommentsSize.Size = New System.Drawing.Size(51, 13)
        Me.lblCommentsSize.TabIndex = 18
        Me.lblCommentsSize.Text = "Font Size"
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
        Me.tbpFormat.ResumeLayout(False)
        Me.thpOptions.ResumeLayout(False)
        Me.tbpScript.ResumeLayout(False)
        Me.tbpScript.PerformLayout()
        Me.tbpROutput.ResumeLayout(False)
        Me.tbpROutput.PerformLayout()
        Me.tbpComment.ResumeLayout(False)
        Me.tbpComment.PerformLayout()
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
    Friend WithEvents tbpFormat As TabPage
    Friend WithEvents thpOptions As TabControl
    Friend WithEvents tbpScript As TabPage
    Friend WithEvents txtScriptSize As TextBox
    Friend WithEvents lblScriptSize As Label
    Friend WithEvents lblScriptTitle As Label
    Friend WithEvents cmdScriptChange As Button
    Friend WithEvents txtScriptFont As TextBox
    Friend WithEvents txtScriptColor As TextBox
    Friend WithEvents lblScriptColor As Label
    Friend WithEvents lblScriptFont As Label
    Friend WithEvents tbpROutput As TabPage
    Friend WithEvents txtOutputSize As TextBox
    Friend WithEvents lblOutputsize As Label
    Friend WithEvents lblOutputTitle As Label
    Friend WithEvents cmdOutputChange As Button
    Friend WithEvents txtOutputFont As TextBox
    Friend WithEvents txtOutputcolor As TextBox
    Friend WithEvents lblOutputColor As Label
    Friend WithEvents lblOutputFont As Label
    Friend WithEvents tbpComment As TabPage
    Friend WithEvents txtCommentsSize As TextBox
    Friend WithEvents lblCommentsSize As Label
    Friend WithEvents lblCommentsTitle As Label
    Friend WithEvents cmdCommentsChange As Button
    Friend WithEvents txtCommentsFont As TextBox
    Friend WithEvents txtCommentsColor As TextBox
    Friend WithEvents lblCommentsColor As Label
    Friend WithEvents lblCommentsFont As Label
End Class
