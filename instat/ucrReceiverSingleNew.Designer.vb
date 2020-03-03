<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrReceiverSingleNew
    Inherits instat.ucrCore

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cboBox
        '
        Me.cboBox.FormattingEnabled = True
        Me.cboBox.Location = New System.Drawing.Point(68, 75)
        Me.cboBox.Name = "cboBox"
        Me.cboBox.Size = New System.Drawing.Size(144, 21)
        Me.cboBox.TabIndex = 0
        '
        'ucrReceiverSingleNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cboBox)
        Me.Name = "ucrReceiverSingleNew"
        Me.Size = New System.Drawing.Size(261, 127)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboBox As ComboBox
End Class
