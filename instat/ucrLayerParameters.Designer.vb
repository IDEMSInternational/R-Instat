<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrLayerParameters
    Inherits instat.ucrGeom

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
        Me.chkParam1 = New System.Windows.Forms.CheckBox()
        Me.chkParam2 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'chkParam1
        '
        Me.chkParam1.AutoSize = True
        Me.chkParam1.Location = New System.Drawing.Point(7, 62)
        Me.chkParam1.Name = "chkParam1"
        Me.chkParam1.Size = New System.Drawing.Size(15, 14)
        Me.chkParam1.TabIndex = 2
        Me.chkParam1.UseVisualStyleBackColor = True
        '
        'chkParam2
        '
        Me.chkParam2.AutoSize = True
        Me.chkParam2.Location = New System.Drawing.Point(7, 85)
        Me.chkParam2.Name = "chkParam2"
        Me.chkParam2.Size = New System.Drawing.Size(15, 14)
        Me.chkParam2.TabIndex = 2
        Me.chkParam2.UseVisualStyleBackColor = True
        '
        'ucrLayerParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.chkParam2)
        Me.Controls.Add(Me.chkParam1)
        Me.Name = "ucrLayerParameters"
        Me.Size = New System.Drawing.Size(187, 237)
        Me.Controls.SetChildIndex(Me.chkParam1, 0)
        Me.Controls.SetChildIndex(Me.chkParam2, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkParam1 As CheckBox
    Friend WithEvents chkParam2 As CheckBox
End Class
