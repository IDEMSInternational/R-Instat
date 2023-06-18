<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrTry
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
        Me.cmdTry = New System.Windows.Forms.Button()
        Me.ucrInputTryMessage = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'cmdTry
        '
        Me.cmdTry.Location = New System.Drawing.Point(8, 4)
        Me.cmdTry.Name = "cmdTry"
        Me.cmdTry.Size = New System.Drawing.Size(75, 23)
        Me.cmdTry.TabIndex = 1
        Me.cmdTry.Text = "Try"
        Me.cmdTry.UseVisualStyleBackColor = True
        '
        'ucrInputTryMessage
        '
        Me.ucrInputTryMessage.AddQuotesIfUnrecognised = True
        Me.ucrInputTryMessage.AutoSize = True
        Me.ucrInputTryMessage.IsMultiline = False
        Me.ucrInputTryMessage.IsReadOnly = True
        Me.ucrInputTryMessage.Location = New System.Drawing.Point(89, 6)
        Me.ucrInputTryMessage.Name = "ucrInputTryMessage"
        Me.ucrInputTryMessage.Size = New System.Drawing.Size(297, 21)
        Me.ucrInputTryMessage.TabIndex = 3
        '
        'ucrTry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.Controls.Add(Me.ucrInputTryMessage)
        Me.Controls.Add(Me.cmdTry)
        Me.Name = "ucrTry"
        Me.Size = New System.Drawing.Size(396, 33)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdTry As Button
    Friend WithEvents ucrInputTryMessage As ucrInputTextBox
End Class
