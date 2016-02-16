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
        Me.cmdScriptChange = New System.Windows.Forms.Button()
        Me.cmdOutputChange = New System.Windows.Forms.Button()
        Me.cmdCommentsChange = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdApply = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.lblRScript = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tbpImport = New System.Windows.Forms.TabPage()
        Me.lblShowLines = New System.Windows.Forms.Label()
        Me.nudNoLines = New System.Windows.Forms.NumericUpDown()
        Me.tbcOptions.SuspendLayout()
        Me.tbpLanguageSettings.SuspendLayout()
        Me.tbpComments.SuspendLayout()
        Me.tbpFormat.SuspendLayout()
        Me.tbpImport.SuspendLayout()
        CType(Me.nudNoLines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcOptions
        '
        Me.tbcOptions.Controls.Add(Me.tbpLanguageSettings)
        Me.tbcOptions.Controls.Add(Me.tbpComments)
        Me.tbcOptions.Controls.Add(Me.tbpFormat)
        Me.tbcOptions.Controls.Add(Me.tbpImport)
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
        Me.tbpFormat.Controls.Add(Me.lblTitle)
        Me.tbpFormat.Controls.Add(Me.lblComments)
        Me.tbpFormat.Controls.Add(Me.lblOutput)
        Me.tbpFormat.Controls.Add(Me.lblRScript)
        Me.tbpFormat.Controls.Add(Me.cmdCommentsChange)
        Me.tbpFormat.Controls.Add(Me.cmdOutputChange)
        Me.tbpFormat.Controls.Add(Me.cmdScriptChange)
        Me.tbpFormat.Location = New System.Drawing.Point(4, 22)
        Me.tbpFormat.Name = "tbpFormat"
        Me.tbpFormat.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpFormat.Size = New System.Drawing.Size(392, 233)
        Me.tbpFormat.TabIndex = 2
        Me.tbpFormat.Text = "Format Options"
        Me.tbpFormat.UseVisualStyleBackColor = True
        '
        'cmdScriptChange
        '
        Me.cmdScriptChange.Location = New System.Drawing.Point(85, 58)
        Me.cmdScriptChange.Name = "cmdScriptChange"
        Me.cmdScriptChange.Size = New System.Drawing.Size(100, 23)
        Me.cmdScriptChange.TabIndex = 10
        Me.cmdScriptChange.Text = "Preview Settings"
        Me.cmdScriptChange.UseVisualStyleBackColor = True
        '
        'cmdOutputChange
        '
        Me.cmdOutputChange.Location = New System.Drawing.Point(85, 97)
        Me.cmdOutputChange.Name = "cmdOutputChange"
        Me.cmdOutputChange.Size = New System.Drawing.Size(100, 23)
        Me.cmdOutputChange.TabIndex = 16
        Me.cmdOutputChange.Text = "Preview Settings"
        Me.cmdOutputChange.UseVisualStyleBackColor = True
        '
        'cmdCommentsChange
        '
        Me.cmdCommentsChange.Location = New System.Drawing.Point(85, 136)
        Me.cmdCommentsChange.Name = "cmdCommentsChange"
        Me.cmdCommentsChange.Size = New System.Drawing.Size(100, 23)
        Me.cmdCommentsChange.TabIndex = 16
        Me.cmdCommentsChange.Text = "Preview Settings"
        Me.cmdCommentsChange.UseVisualStyleBackColor = True
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
        'lblRScript
        '
        Me.lblRScript.AutoSize = True
        Me.lblRScript.Location = New System.Drawing.Point(6, 68)
        Me.lblRScript.Name = "lblRScript"
        Me.lblRScript.Size = New System.Drawing.Size(45, 13)
        Me.lblRScript.TabIndex = 17
        Me.lblRScript.Text = "R Script"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(6, 107)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(50, 13)
        Me.lblOutput.TabIndex = 18
        Me.lblOutput.Text = "R Output"
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Location = New System.Drawing.Point(6, 146)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(56, 13)
        Me.lblComments.TabIndex = 19
        Me.lblComments.Text = "Comments"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(6, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(333, 15)
        Me.lblTitle.TabIndex = 20
        Me.lblTitle.Text = "Preview and Set the Font and Color Formats for the following Options"
        '
        'tbpImport
        '
        Me.tbpImport.Controls.Add(Me.nudNoLines)
        Me.tbpImport.Controls.Add(Me.lblShowLines)
        Me.tbpImport.Location = New System.Drawing.Point(4, 22)
        Me.tbpImport.Name = "tbpImport"
        Me.tbpImport.Size = New System.Drawing.Size(392, 233)
        Me.tbpImport.TabIndex = 3
        Me.tbpImport.Text = "Import Data"
        Me.tbpImport.UseVisualStyleBackColor = True
        '
        'lblShowLines
        '
        Me.lblShowLines.AutoSize = True
        Me.lblShowLines.Location = New System.Drawing.Point(21, 21)
        Me.lblShowLines.Name = "lblShowLines"
        Me.lblShowLines.Size = New System.Drawing.Size(158, 13)
        Me.lblShowLines.TabIndex = 0
        Me.lblShowLines.Text = "Number of lines to show on load"
        '
        'nudNoLines
        '
        Me.nudNoLines.Location = New System.Drawing.Point(244, 21)
        Me.nudNoLines.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudNoLines.Name = "nudNoLines"
        Me.nudNoLines.Size = New System.Drawing.Size(75, 20)
        Me.nudNoLines.TabIndex = 1
        Me.nudNoLines.Value = New Decimal(New Integer() {10, 0, 0, 0})
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
        Me.tbpFormat.PerformLayout()
        Me.tbpImport.ResumeLayout(False)
        Me.tbpImport.PerformLayout()
        CType(Me.nudNoLines, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmdScriptChange As Button
    Friend WithEvents cmdOutputChange As Button
    Friend WithEvents cmdCommentsChange As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblComments As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblRScript As Label
    Friend WithEvents tbpImport As TabPage
    Friend WithEvents nudNoLines As NumericUpDown
    Friend WithEvents lblShowLines As Label
End Class
