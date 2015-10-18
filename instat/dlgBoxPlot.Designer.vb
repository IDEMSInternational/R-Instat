<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgBoxPlot
    Inherits instat.GraphicsDialogTemplate

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.cboFactoVariable = New System.Windows.Forms.ComboBox()
        Me.lblAvailableVariables = New System.Windows.Forms.Label()
        Me.lstAvailableVariable = New System.Windows.Forms.ListBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(40, 257)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox9.TabIndex = 96
        Me.CheckBox9.Text = "By"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'cboFactoVariable
        '
        Me.cboFactoVariable.FormattingEnabled = True
        Me.cboFactoVariable.Location = New System.Drawing.Point(40, 43)
        Me.cboFactoVariable.Name = "cboFactoVariable"
        Me.cboFactoVariable.Size = New System.Drawing.Size(123, 21)
        Me.cboFactoVariable.TabIndex = 95
        '
        'lblAvailableVariables
        '
        Me.lblAvailableVariables.AutoSize = True
        Me.lblAvailableVariables.Location = New System.Drawing.Point(37, 18)
        Me.lblAvailableVariables.Name = "lblAvailableVariables"
        Me.lblAvailableVariables.Size = New System.Drawing.Size(93, 13)
        Me.lblAvailableVariables.TabIndex = 94
        Me.lblAvailableVariables.Tag = "Available _Variables "
        Me.lblAvailableVariables.Text = "Data to bePlotted "
        '
        'lstAvailableVariable
        '
        Me.lstAvailableVariable.FormattingEnabled = True
        Me.lstAvailableVariable.Location = New System.Drawing.Point(40, 70)
        Me.lstAvailableVariable.Name = "lstAvailableVariable"
        Me.lstAvailableVariable.Size = New System.Drawing.Size(123, 173)
        Me.lstAvailableVariable.TabIndex = 93
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(206, 222)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 92
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Maximum Box Width"
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(206, 248)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox8.TabIndex = 90
        Me.CheckBox8.Text = "Box width "
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(206, 158)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(112, 17)
        Me.CheckBox6.TabIndex = 83
        Me.CheckBox6.Text = "Connect Medians "
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(206, 135)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(184, 17)
        Me.CheckBox5.TabIndex = 84
        Me.CheckBox5.Text = "Show Confident limits for Medians"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(206, 112)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(101, 17)
        Me.CheckBox4.TabIndex = 85
        Me.CheckBox4.Text = "Show OutLines "
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(206, 89)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(105, 17)
        Me.CheckBox3.TabIndex = 86
        Me.CheckBox3.Text = "Plot Data Points "
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(206, 66)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(110, 17)
        Me.CheckBox2.TabIndex = 87
        Me.CheckBox2.Text = "One line Box Plot "
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(206, 43)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(115, 17)
        Me.CheckBox1.TabIndex = 88
        Me.CheckBox1.Text = "Horizontal Box Plot"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(206, 181)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox7.TabIndex = 89
        Me.CheckBox7.Text = "Show Means"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'dlgBoxPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(384, 362)
        Me.Controls.Add(Me.CheckBox9)
        Me.Controls.Add(Me.cboFactoVariable)
        Me.Controls.Add(Me.lblAvailableVariables)
        Me.Controls.Add(Me.lstAvailableVariable)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CheckBox7)
        Me.Name = "dlgBoxPlot"
        Me.Controls.SetChildIndex(Me.CheckBox7, 0)
        Me.Controls.SetChildIndex(Me.CheckBox1, 0)
        Me.Controls.SetChildIndex(Me.CheckBox2, 0)
        Me.Controls.SetChildIndex(Me.CheckBox3, 0)
        Me.Controls.SetChildIndex(Me.CheckBox4, 0)
        Me.Controls.SetChildIndex(Me.CheckBox5, 0)
        Me.Controls.SetChildIndex(Me.CheckBox6, 0)
        Me.Controls.SetChildIndex(Me.CheckBox8, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        Me.Controls.SetChildIndex(Me.lstAvailableVariable, 0)
        Me.Controls.SetChildIndex(Me.lblAvailableVariables, 0)
        Me.Controls.SetChildIndex(Me.cboFactoVariable, 0)
        Me.Controls.SetChildIndex(Me.CheckBox9, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents cboFactoVariable As ComboBox
    Friend WithEvents lblAvailableVariables As Label
    Friend WithEvents lstAvailableVariable As ListBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
End Class
