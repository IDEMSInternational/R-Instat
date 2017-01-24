<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcrPanel
    Inherits instat.ucrCore

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
        Me.pnlRadios = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'pnlRadios
        '
        Me.pnlRadios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRadios.Location = New System.Drawing.Point(0, 0)
        Me.pnlRadios.Name = "pnlRadios"
        Me.pnlRadios.Size = New System.Drawing.Size(187, 106)
        Me.pnlRadios.TabIndex = 0
        '
        'UcrPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.pnlRadios)
        Me.Name = "UcrPanel"
        Me.Size = New System.Drawing.Size(187, 106)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlRadios As Panel
End Class
