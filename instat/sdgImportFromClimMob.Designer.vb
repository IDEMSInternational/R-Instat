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
        Me.cmdChooseFile.Location = New System.Drawing.Point(259, 27)
        Me.cmdChooseFile.Name = "cmdChooseFile"
        Me.cmdChooseFile.Size = New System.Drawing.Size(100, 23)
        Me.cmdChooseFile.TabIndex = 7
        Me.cmdChooseFile.Text = "Choose File..."
        Me.cmdChooseFile.UseVisualStyleBackColor = True
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(18, 92)
        Me.ucrBaseSubdialog.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(224, 29)
        Me.ucrBaseSubdialog.TabIndex = 6
        '
        'ucrInputKeyPath
        '
        Me.ucrInputKeyPath.AddQuotesIfUnrecognised = True
        Me.ucrInputKeyPath.AutoSize = True
        Me.ucrInputKeyPath.IsMultiline = False
        Me.ucrInputKeyPath.IsReadOnly = False
        Me.ucrInputKeyPath.Location = New System.Drawing.Point(47, 30)
        Me.ucrInputKeyPath.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputKeyPath.Name = "ucrInputKeyPath"
        Me.ucrInputKeyPath.Size = New System.Drawing.Size(196, 27)
        Me.ucrInputKeyPath.TabIndex = 5
        '
        'lblKkey
        '
        Me.lblKkey.AutoSize = True
        Me.lblKkey.Location = New System.Drawing.Point(8, 32)
        Me.lblKkey.Name = "lblKkey"
        Me.lblKkey.Size = New System.Drawing.Size(28, 13)
        Me.lblKkey.TabIndex = 4
        Me.lblKkey.Text = "Key:"
        '
        'sdgImportFromClimMob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 146)
        Me.Controls.Add(Me.cmdChooseFile)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.ucrInputKeyPath)
        Me.Controls.Add(Me.lblKkey)
        Me.Name = "sdgImportFromClimMob"
        Me.ShowIcon = False
        Me.Text = "Import From ClimMob"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdChooseFile As Button
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents ucrInputKeyPath As ucrInputTextBox
    Friend WithEvents lblKkey As Label
End Class
