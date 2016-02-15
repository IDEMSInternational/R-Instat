<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrButtonsSubdialogue
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
        Me.cmdReturn = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdReturn
        '
        Me.cmdReturn.Location = New System.Drawing.Point(0, 3)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.Size = New System.Drawing.Size(63, 23)
        Me.cmdReturn.TabIndex = 0
        Me.cmdReturn.Tag = "Return"
        Me.cmdReturn.Text = "Return"
        Me.cmdReturn.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(81, 3)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(60, 23)
        Me.cmdHelp.TabIndex = 1
        Me.cmdHelp.Tag = "Help"
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(159, 3)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(62, 23)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'ucrButtonsSubdialogue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdReturn)
        Me.Name = "ucrButtonsSubdialogue"
        Me.Size = New System.Drawing.Size(142, 30)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdReturn As Button
    Friend WithEvents cmdHelp As Button
    Friend WithEvents cmdCancel As Button
End Class
