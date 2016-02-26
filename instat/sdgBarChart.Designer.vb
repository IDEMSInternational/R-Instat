<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgBarChart
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
        Me.rdoStack = New System.Windows.Forms.RadioButton()
        Me.rdoDodge = New System.Windows.Forms.RadioButton()
        Me.rdoFill = New System.Windows.Forms.RadioButton()
        Me.grpPosition = New System.Windows.Forms.GroupBox()
        Me.UcrButtonsSubdialogue1 = New instat.ucrButtonsSubdialogue()
        Me.grpPosition.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoStack
        '
        Me.rdoStack.AutoSize = True
        Me.rdoStack.Location = New System.Drawing.Point(6, 15)
        Me.rdoStack.Name = "rdoStack"
        Me.rdoStack.Size = New System.Drawing.Size(53, 17)
        Me.rdoStack.TabIndex = 1
        Me.rdoStack.TabStop = True
        Me.rdoStack.Text = "Stack"
        Me.rdoStack.UseVisualStyleBackColor = True
        '
        'rdoDodge
        '
        Me.rdoDodge.AutoSize = True
        Me.rdoDodge.Location = New System.Drawing.Point(120, 15)
        Me.rdoDodge.Name = "rdoDodge"
        Me.rdoDodge.Size = New System.Drawing.Size(57, 17)
        Me.rdoDodge.TabIndex = 2
        Me.rdoDodge.TabStop = True
        Me.rdoDodge.Text = "Dodge"
        Me.rdoDodge.UseVisualStyleBackColor = True
        '
        'rdoFill
        '
        Me.rdoFill.AutoSize = True
        Me.rdoFill.Location = New System.Drawing.Point(70, 15)
        Me.rdoFill.Name = "rdoFill"
        Me.rdoFill.Size = New System.Drawing.Size(37, 17)
        Me.rdoFill.TabIndex = 3
        Me.rdoFill.TabStop = True
        Me.rdoFill.Text = "Fill"
        Me.rdoFill.UseVisualStyleBackColor = True
        '
        'grpPosition
        '
        Me.grpPosition.Controls.Add(Me.rdoStack)
        Me.grpPosition.Controls.Add(Me.rdoDodge)
        Me.grpPosition.Controls.Add(Me.rdoFill)
        Me.grpPosition.Location = New System.Drawing.Point(12, 12)
        Me.grpPosition.Name = "grpPosition"
        Me.grpPosition.Size = New System.Drawing.Size(200, 38)
        Me.grpPosition.TabIndex = 4
        Me.grpPosition.TabStop = False
        Me.grpPosition.Text = "Position"
        '
        'UcrButtonsSubdialogue1
        '
        Me.UcrButtonsSubdialogue1.Location = New System.Drawing.Point(63, 220)
        Me.UcrButtonsSubdialogue1.Name = "UcrButtonsSubdialogue1"
        Me.UcrButtonsSubdialogue1.Size = New System.Drawing.Size(142, 30)
        Me.UcrButtonsSubdialogue1.TabIndex = 0
        '
        'sdgBarChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.grpPosition)
        Me.Controls.Add(Me.UcrButtonsSubdialogue1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgBarChart"
        Me.Text = "Bar Chart Options"
        Me.grpPosition.ResumeLayout(False)
        Me.grpPosition.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrButtonsSubdialogue1 As ucrButtonsSubdialogue
    Friend WithEvents rdoStack As RadioButton
    Friend WithEvents rdoDodge As RadioButton
    Friend WithEvents rdoFill As RadioButton
    Friend WithEvents grpPosition As GroupBox
End Class
