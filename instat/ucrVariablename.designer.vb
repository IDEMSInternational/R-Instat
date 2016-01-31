<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrVariableName
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
        Me.txtValidation = New System.Windows.Forms.TextBox()
        Me.lblColumnName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtValidation
        '
        Me.txtValidation.Location = New System.Drawing.Point(81, 3)
        Me.txtValidation.Name = "txtValidation"
        Me.txtValidation.Size = New System.Drawing.Size(141, 20)
        Me.txtValidation.TabIndex = 0
        '
        'lblColumnName
        '
        Me.lblColumnName.AutoSize = True
        Me.lblColumnName.Location = New System.Drawing.Point(4, 6)
        Me.lblColumnName.Name = "lblColumnName"
        Me.lblColumnName.Size = New System.Drawing.Size(76, 13)
        Me.lblColumnName.TabIndex = 1
        Me.lblColumnName.Tag = "Variable_Name"
        Me.lblColumnName.Text = "Variable Name"
        '
        'ucrVariableName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblColumnName)
        Me.Controls.Add(Me.txtValidation)
        Me.Name = "ucrVariableName"
        Me.Size = New System.Drawing.Size(227, 23)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtValidation As TextBox
    Friend WithEvents lblColumnName As Label
End Class
