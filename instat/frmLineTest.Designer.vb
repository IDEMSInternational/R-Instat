<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLineTest
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLine = New System.Windows.Forms.TextBox()
        Me.txtDelim = New System.Windows.Forms.TextBox()
        Me.fraWord = New System.Windows.Forms.GroupBox()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.txtFirstWord = New System.Windows.Forms.TextBox()
        Me.txtReplace = New System.Windows.Forms.TextBox()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.fraWord.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Line of Text"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Delimeter "
        '
        'txtLine
        '
        Me.txtLine.Location = New System.Drawing.Point(115, 13)
        Me.txtLine.Name = "txtLine"
        Me.txtLine.Size = New System.Drawing.Size(100, 20)
        Me.txtLine.TabIndex = 1
        Me.txtLine.Text = "The rain in Spain stays mainly in the plain"
        '
        'txtDelim
        '
        Me.txtDelim.Location = New System.Drawing.Point(115, 38)
        Me.txtDelim.Name = "txtDelim"
        Me.txtDelim.Size = New System.Drawing.Size(100, 20)
        Me.txtDelim.TabIndex = 1
        Me.txtDelim.Text = ","
        '
        'fraWord
        '
        Me.fraWord.Controls.Add(Me.btnFirst)
        Me.fraWord.Controls.Add(Me.txtFirstWord)
        Me.fraWord.Location = New System.Drawing.Point(12, 64)
        Me.fraWord.Name = "fraWord"
        Me.fraWord.Size = New System.Drawing.Size(200, 68)
        Me.fraWord.TabIndex = 2
        Me.fraWord.TabStop = False
        Me.fraWord.Text = "Get First Word"
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(6, 19)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnFirst.TabIndex = 0
        Me.btnFirst.Text = "GET WORD"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'txtFirstWord
        '
        Me.txtFirstWord.Location = New System.Drawing.Point(100, 19)
        Me.txtFirstWord.Name = "txtFirstWord"
        Me.txtFirstWord.ReadOnly = True
        Me.txtFirstWord.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstWord.TabIndex = 1
        '
        'txtReplace
        '
        Me.txtReplace.Location = New System.Drawing.Point(112, 154)
        Me.txtReplace.Name = "txtReplace"
        Me.txtReplace.ReadOnly = True
        Me.txtReplace.Size = New System.Drawing.Size(100, 20)
        Me.txtReplace.TabIndex = 1
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(18, 154)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(75, 23)
        Me.btnReplace.TabIndex = 0
        Me.btnReplace.Text = "REPLACE"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'frmLineTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.fraWord)
        Me.Controls.Add(Me.txtReplace)
        Me.Controls.Add(Me.txtDelim)
        Me.Controls.Add(Me.txtLine)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLineTest"
        Me.Text = "frmLineTest"
        Me.fraWord.ResumeLayout(False)
        Me.fraWord.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLine As TextBox
    Friend WithEvents txtDelim As TextBox
    Friend WithEvents fraWord As GroupBox
    Friend WithEvents btnFirst As Button
    Friend WithEvents txtFirstWord As TextBox
    Friend WithEvents txtReplace As TextBox
    Friend WithEvents btnReplace As Button
End Class
