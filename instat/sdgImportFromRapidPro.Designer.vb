<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgImportFromRapidPro
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
        Me.lblToken = New System.Windows.Forms.Label()
        Me.ucrInputTokenPath = New instat.ucrInputTextBox()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.cmdChooseFile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblToken
        '
        Me.lblToken.AutoSize = True
        Me.lblToken.Location = New System.Drawing.Point(10, 25)
        Me.lblToken.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToken.Name = "lblToken"
        Me.lblToken.Size = New System.Drawing.Size(57, 20)
        Me.lblToken.TabIndex = 0
        Me.lblToken.Text = "Token:"
        '
        'ucrInputTokenPath
        '
        Me.ucrInputTokenPath.AddQuotesIfUnrecognised = True
        Me.ucrInputTokenPath.AutoSize = True
        Me.ucrInputTokenPath.IsMultiline = False
        Me.ucrInputTokenPath.IsReadOnly = False
        Me.ucrInputTokenPath.Location = New System.Drawing.Point(69, 22)
        Me.ucrInputTokenPath.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputTokenPath.Name = "ucrInputTokenPath"
        Me.ucrInputTokenPath.Size = New System.Drawing.Size(294, 42)
        Me.ucrInputTokenPath.TabIndex = 1
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(26, 117)
        Me.ucrBaseSubdialog.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(336, 45)
        Me.ucrBaseSubdialog.TabIndex = 2
        '
        'cmdChooseFile
        '
        Me.cmdChooseFile.Location = New System.Drawing.Point(387, 17)
        Me.cmdChooseFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdChooseFile.Name = "cmdChooseFile"
        Me.cmdChooseFile.Size = New System.Drawing.Size(150, 35)
        Me.cmdChooseFile.TabIndex = 3
        Me.cmdChooseFile.Text = "Choose File..."
        Me.cmdChooseFile.UseVisualStyleBackColor = True
        '
        'sdgImportFromRapidPro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 163)
        Me.Controls.Add(Me.cmdChooseFile)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.ucrInputTokenPath)
        Me.Controls.Add(Me.lblToken)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgImportFromRapidPro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import from RapidPro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblToken As Label
    Friend WithEvents ucrInputTokenPath As ucrInputTextBox
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents cmdChooseFile As Button
End Class
