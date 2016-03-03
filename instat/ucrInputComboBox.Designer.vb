<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrInputComboBox
    Inherits instat.ucrInput

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
        Me.cboInput = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cboInput
        '
        Me.cboInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboInput.FormattingEnabled = True
        Me.cboInput.Location = New System.Drawing.Point(0, 0)
        Me.cboInput.Name = "cboInput"
        Me.cboInput.Size = New System.Drawing.Size(137, 21)
        Me.cboInput.TabIndex = 0
        '
        'ucrInputComboBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cboInput)
        Me.Name = "ucrInputComboBox"
        Me.Size = New System.Drawing.Size(137, 25)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboInput As ComboBox
End Class
