<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrRadio
    Inherits instat.ucrCore

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
        Me.rdoRadio = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'rdoRadio
        '
        Me.rdoRadio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoRadio.Location = New System.Drawing.Point(0, 0)
        Me.rdoRadio.Name = "rdoRadio"
        Me.rdoRadio.Size = New System.Drawing.Size(100, 20)
        Me.rdoRadio.TabIndex = 0
        Me.rdoRadio.TabStop = True
        Me.rdoRadio.Text = "RadioButton1"
        Me.rdoRadio.UseVisualStyleBackColor = True
        '
        'ucrRadio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rdoRadio)
        Me.Name = "ucrRadio"
        Me.Size = New System.Drawing.Size(100, 20)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rdoRadio As RadioButton
End Class
