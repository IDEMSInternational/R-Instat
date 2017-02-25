<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrMultipleInput
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
        Me.txtNumericItems = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtNumericItems
        '
        Me.txtNumericItems.Location = New System.Drawing.Point(4, 4)
        Me.txtNumericItems.Name = "txtNumericItems"
        Me.txtNumericItems.Size = New System.Drawing.Size(143, 20)
        Me.txtNumericItems.TabIndex = 0
        '
        'ucrMultipleNumeric
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtNumericItems)
        Me.Name = "ucrMultipleNumeric"
        Me.Size = New System.Drawing.Size(150, 29)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumericItems As TextBox
End Class
