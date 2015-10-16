<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dataselectiontemplate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.lblAvailableVariables = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(290, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Tag = "Selected_Variables"
        Me.Label1.Text = "Factor Variable"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(287, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(81, 21)
        Me.ComboBox1.TabIndex = 29
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(106, 84)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 28
        Me.btnRemove.Tag = "Remove"
        Me.btnRemove.Text = "Remove "
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(106, 46)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 27
        Me.btnAdd.Tag = "Add"
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(189, 11)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(95, 13)
        Me.lblSelectedVariables.TabIndex = 26
        Me.lblSelectedVariables.Tag = "Selected_Variables"
        Me.lblSelectedVariables.Text = "Selected Variables"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(196, 31)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(84, 95)
        Me.ListBox2.TabIndex = 25
        '
        'lblAvailableVariables
        '
        Me.lblAvailableVariables.AutoSize = True
        Me.lblAvailableVariables.Location = New System.Drawing.Point(9, 11)
        Me.lblAvailableVariables.Name = "lblAvailableVariables"
        Me.lblAvailableVariables.Size = New System.Drawing.Size(102, 13)
        Me.lblAvailableVariables.TabIndex = 24
        Me.lblAvailableVariables.Tag = "Available _Variables "
        Me.lblAvailableVariables.Text = "Available  Variables "
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(16, 31)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(84, 95)
        Me.ListBox1.TabIndex = 23
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 179)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.lblAvailableVariables)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents lblAvailableVariables As Label
    Friend WithEvents ListBox1 As ListBox
End Class
