<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgImportFromClimMob
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
        Me.cmdChooseFile = New System.Windows.Forms.Button()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.ucrInputKeyPath = New instat.ucrInputTextBox()
        Me.lblKkey = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdChooseFile
        '
        Me.cmdChooseFile.Location = New System.Drawing.Point(393, 22)
        Me.cmdChooseFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdChooseFile.Name = "cmdChooseFile"
        Me.cmdChooseFile.Size = New System.Drawing.Size(150, 35)
        Me.cmdChooseFile.TabIndex = 2
        Me.cmdChooseFile.Text = "Choose File..."
        Me.cmdChooseFile.UseVisualStyleBackColor = True
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(15, 73)
        Me.ucrBaseSubdialog.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(336, 45)
        Me.ucrBaseSubdialog.TabIndex = 3
        '
        'ucrInputKeyPath
        '
        Me.ucrInputKeyPath.AddQuotesIfUnrecognised = True
        Me.ucrInputKeyPath.AutoSize = True
        Me.ucrInputKeyPath.IsMultiline = False
        Me.ucrInputKeyPath.IsReadOnly = False
        Me.ucrInputKeyPath.Location = New System.Drawing.Point(75, 26)
        Me.ucrInputKeyPath.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputKeyPath.Name = "ucrInputKeyPath"
        Me.ucrInputKeyPath.Size = New System.Drawing.Size(294, 42)
        Me.ucrInputKeyPath.TabIndex = 1
        '
        'lblKkey
        '
        Me.lblKkey.AutoSize = True
        Me.lblKkey.Location = New System.Drawing.Point(17, 29)
        Me.lblKkey.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKkey.Name = "lblKkey"
        Me.lblKkey.Size = New System.Drawing.Size(39, 20)
        Me.lblKkey.TabIndex = 0
        Me.lblKkey.Text = "Key:"
        '
        'sdgImportFromClimMob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 132)
        Me.Controls.Add(Me.cmdChooseFile)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.ucrInputKeyPath)
        Me.Controls.Add(Me.lblKkey)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "sdgImportFromClimMob"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import From ClimMob"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdChooseFile As Button
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents ucrInputKeyPath As ucrInputTextBox
    Friend WithEvents lblKkey As Label
End Class
