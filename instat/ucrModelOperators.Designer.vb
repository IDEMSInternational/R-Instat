<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrModelOperators
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.grpModelOperators = New System.Windows.Forms.GroupBox()
        Me.cmdJointLines = New System.Windows.Forms.Button()
        Me.cmdConditional = New System.Windows.Forms.Button()
        Me.cmdCommonIntercept = New System.Windows.Forms.Button()
        Me.cmdParallelLines = New System.Windows.Forms.Button()
        Me.grpModelOperators.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpModelOperators
        '
        Me.grpModelOperators.Controls.Add(Me.cmdJointLines)
        Me.grpModelOperators.Controls.Add(Me.cmdConditional)
        Me.grpModelOperators.Controls.Add(Me.cmdCommonIntercept)
        Me.grpModelOperators.Controls.Add(Me.cmdParallelLines)
        Me.grpModelOperators.Location = New System.Drawing.Point(1, -1)
        Me.grpModelOperators.Name = "grpModelOperators"
        Me.grpModelOperators.Size = New System.Drawing.Size(143, 42)
        Me.grpModelOperators.TabIndex = 25
        Me.grpModelOperators.TabStop = False
        Me.grpModelOperators.Tag = "Model_Operators"
        Me.grpModelOperators.Text = "Model Operators"
        '
        'cmdJointLines
        '
        Me.cmdJointLines.Location = New System.Drawing.Point(75, 14)
        Me.cmdJointLines.Name = "cmdJointLines"
        Me.cmdJointLines.Size = New System.Drawing.Size(28, 23)
        Me.cmdJointLines.TabIndex = 2
        Me.cmdJointLines.Tag = "*"
        Me.cmdJointLines.Text = "*"
        Me.cmdJointLines.UseVisualStyleBackColor = True
        '
        'cmdConditional
        '
        Me.cmdConditional.Location = New System.Drawing.Point(41, 14)
        Me.cmdConditional.Name = "cmdConditional"
        Me.cmdConditional.Size = New System.Drawing.Size(27, 23)
        Me.cmdConditional.TabIndex = 1
        Me.cmdConditional.Text = ":"
        Me.cmdConditional.UseVisualStyleBackColor = True
        '
        'cmdCommonIntercept
        '
        Me.cmdCommonIntercept.Location = New System.Drawing.Point(110, 14)
        Me.cmdCommonIntercept.Name = "cmdCommonIntercept"
        Me.cmdCommonIntercept.Size = New System.Drawing.Size(27, 23)
        Me.cmdCommonIntercept.TabIndex = 3
        Me.cmdCommonIntercept.Tag = "/"
        Me.cmdCommonIntercept.Text = "/"
        Me.cmdCommonIntercept.UseVisualStyleBackColor = True
        '
        'cmdParallelLines
        '
        Me.cmdParallelLines.Location = New System.Drawing.Point(7, 14)
        Me.cmdParallelLines.Name = "cmdParallelLines"
        Me.cmdParallelLines.Size = New System.Drawing.Size(28, 23)
        Me.cmdParallelLines.TabIndex = 0
        Me.cmdParallelLines.Tag = "+"
        Me.cmdParallelLines.Text = "+"
        Me.cmdParallelLines.UseVisualStyleBackColor = True
        '
        'ucrModelOperators
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpModelOperators)
        Me.Name = "ucrModelOperators"
        Me.Size = New System.Drawing.Size(144, 43)
        Me.grpModelOperators.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpModelOperators As GroupBox
    Friend WithEvents cmdJointLines As Button
    Friend WithEvents cmdConditional As Button
    Friend WithEvents cmdCommonIntercept As Button
    Friend WithEvents cmdParallelLines As Button
End Class
