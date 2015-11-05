<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrReceiverMultiple
    Inherits instat.ucrReceiver

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
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.lstSelectedVariables = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(6, 3)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(95, 13)
        Me.lblSelectedVariables.TabIndex = 80
        Me.lblSelectedVariables.Tag = "Selected_Variables"
        Me.lblSelectedVariables.Text = "Selected Variables"
        '
        'lstSelectedVariables
        '
        Me.lstSelectedVariables.FormattingEnabled = True
        Me.lstSelectedVariables.Location = New System.Drawing.Point(13, 23)
        Me.lstSelectedVariables.Name = "lstSelectedVariables"
        Me.lstSelectedVariables.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstSelectedVariables.Size = New System.Drawing.Size(84, 95)
        Me.lstSelectedVariables.Sorted = True
        Me.lstSelectedVariables.TabIndex = 79
        '
        'ucrReceiverMultiple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.lstSelectedVariables)
        Me.Name = "ucrReceiverMultiple"
        Me.Size = New System.Drawing.Size(106, 126)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents lstSelectedVariables As ListBox
End Class
