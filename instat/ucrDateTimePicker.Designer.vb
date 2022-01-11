<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrDateTimePicker
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
        Me.dtpDateTime = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'dtpDateTime
        '
        Me.dtpDateTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpDateTime.Location = New System.Drawing.Point(0, 0)
        Me.dtpDateTime.Name = "dtpDateTime"
        Me.dtpDateTime.Size = New System.Drawing.Size(163, 20)
        Me.dtpDateTime.TabIndex = 0
        '
        'ucrDateTimePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.dtpDateTime)
        Me.Name = "ucrDateTimePicker"
        Me.Size = New System.Drawing.Size(163, 20)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtpDateTime As DateTimePicker
End Class
