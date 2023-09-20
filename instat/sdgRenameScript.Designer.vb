<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgRenameScript
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
        Me.lblCurrentName = New System.Windows.Forms.Label()
        Me.lblNewName = New System.Windows.Forms.Label()
        Me.ucrInputCurrentName = New instat.ucrInputTextBox()
        Me.ucrInputNewName = New instat.ucrInputTextBox()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'lblCurrentName
        '
        Me.lblCurrentName.AutoSize = True
        Me.lblCurrentName.Location = New System.Drawing.Point(20, 24)
        Me.lblCurrentName.Name = "lblCurrentName"
        Me.lblCurrentName.Size = New System.Drawing.Size(108, 20)
        Me.lblCurrentName.TabIndex = 35
        Me.lblCurrentName.Text = "Current Name"
        '
        'lblNewName
        '
        Me.lblNewName.AutoSize = True
        Me.lblNewName.Location = New System.Drawing.Point(18, 93)
        Me.lblNewName.Name = "lblNewName"
        Me.lblNewName.Size = New System.Drawing.Size(86, 20)
        Me.lblNewName.TabIndex = 36
        Me.lblNewName.Text = "New Name"
        '
        'ucrInputCurrentName
        '
        Me.ucrInputCurrentName.AddQuotesIfUnrecognised = True
        Me.ucrInputCurrentName.AutoSize = True
        Me.ucrInputCurrentName.IsMultiline = False
        Me.ucrInputCurrentName.IsReadOnly = False
        Me.ucrInputCurrentName.Location = New System.Drawing.Point(20, 53)
        Me.ucrInputCurrentName.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputCurrentName.Name = "ucrInputCurrentName"
        Me.ucrInputCurrentName.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputCurrentName.TabIndex = 40
        '
        'ucrInputNewName
        '
        Me.ucrInputNewName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewName.AutoSize = True
        Me.ucrInputNewName.IsMultiline = False
        Me.ucrInputNewName.IsReadOnly = False
        Me.ucrInputNewName.Location = New System.Drawing.Point(18, 122)
        Me.ucrInputNewName.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputNewName.Name = "ucrInputNewName"
        Me.ucrInputNewName.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputNewName.TabIndex = 37
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(15, 164)
        Me.ucrBaseSubdialog.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(336, 45)
        Me.ucrBaseSubdialog.TabIndex = 34
        '
        'sdgRenameScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(366, 220)
        Me.Controls.Add(Me.ucrInputCurrentName)
        Me.Controls.Add(Me.ucrInputNewName)
        Me.Controls.Add(Me.lblNewName)
        Me.Controls.Add(Me.lblCurrentName)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgRenameScript"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rename Script"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents lblCurrentName As Label
    Friend WithEvents lblNewName As Label
    Friend WithEvents ucrInputNewName As ucrInputTextBox
    Friend WithEvents ucrInputCurrentName As ucrInputTextBox
End Class
