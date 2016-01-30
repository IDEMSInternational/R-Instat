<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrReceiverMultiple
    Inherits instat.ucrReceiver

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstSelectedVariables = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'lstSelectedVariables
        '
        Me.lstSelectedVariables.Location = New System.Drawing.Point(3, 5)
        Me.lstSelectedVariables.Name = "lstSelectedVariables"
        Me.lstSelectedVariables.Size = New System.Drawing.Size(113, 95)
        Me.lstSelectedVariables.TabIndex = 1
        Me.lstSelectedVariables.UseCompatibleStateImageBehavior = False
        '
        'ucrReceiverMultiple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.lstSelectedVariables)
        Me.Name = "ucrReceiverMultiple"
        Me.Size = New System.Drawing.Size(121, 128)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstSelectedVariables As ListView
End Class
