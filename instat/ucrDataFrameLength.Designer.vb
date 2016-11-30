<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrDataFrameLength
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
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtLength
        '
        Me.txtLength.Enabled = False
        Me.txtLength.Location = New System.Drawing.Point(0, 0)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(51, 20)
        Me.txtLength.TabIndex = 0
        '
        'ucrDataFrameLength
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtLength)
        Me.Name = "ucrDataFrameLength"
        Me.Size = New System.Drawing.Size(53, 23)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLength As TextBox
End Class
