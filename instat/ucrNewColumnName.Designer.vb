<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrNewColumnName
    Inherits System.Windows.Forms.UserControl

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
        Me.lblColumnName = New System.Windows.Forms.Label()
        Me.cboColumnName = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblColumnName
        '
        Me.lblColumnName.AutoSize = True
        Me.lblColumnName.Location = New System.Drawing.Point(3, 10)
        Me.lblColumnName.Name = "lblColumnName"
        Me.lblColumnName.Size = New System.Drawing.Size(101, 13)
        Me.lblColumnName.TabIndex = 0
        Me.lblColumnName.Tag = "new_column_name:"
        Me.lblColumnName.Text = "New Column Name:"
        '
        'cboColumnName
        '
        Me.cboColumnName.FormattingEnabled = True
        Me.cboColumnName.Location = New System.Drawing.Point(107, 7)
        Me.cboColumnName.Name = "cboColumnName"
        Me.cboColumnName.Size = New System.Drawing.Size(257, 21)
        Me.cboColumnName.TabIndex = 1
        '
        'ucrNewColumnName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cboColumnName)
        Me.Controls.Add(Me.lblColumnName)
        Me.Name = "ucrNewColumnName"
        Me.Size = New System.Drawing.Size(367, 35)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblColumnName As Label
    Friend WithEvents cboColumnName As ComboBox
End Class
