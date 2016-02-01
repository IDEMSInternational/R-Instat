<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrVariableName
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txtValidation = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtValidation
        '
        Me.txtValidation.Location = New System.Drawing.Point(3, 3)
        Me.txtValidation.Name = "txtValidation"
        Me.txtValidation.Size = New System.Drawing.Size(141, 20)
        Me.txtValidation.TabIndex = 0
        '
        'ucrVariableName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtValidation)
        Me.Name = "ucrVariableName"
        Me.Size = New System.Drawing.Size(149, 23)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtValidation As TextBox
End Class
