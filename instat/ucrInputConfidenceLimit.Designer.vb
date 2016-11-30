<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrInputConfidenceLimit
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
        Me.ucrConfidenceLimit = New instat.ucrInputComboBox()
        Me.lblConfidenceLimit = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrConfidenceLimit
        '
        Me.ucrConfidenceLimit.Location = New System.Drawing.Point(94, 0)
        Me.ucrConfidenceLimit.Name = "ucrConfidenceLimit"
        Me.ucrConfidenceLimit.Size = New System.Drawing.Size(56, 24)
        Me.ucrConfidenceLimit.TabIndex = 0
        '
        'lblConfidenceLimit
        '
        Me.lblConfidenceLimit.AutoSize = True
        Me.lblConfidenceLimit.Location = New System.Drawing.Point(3, 3)
        Me.lblConfidenceLimit.Name = "lblConfidenceLimit"
        Me.lblConfidenceLimit.Size = New System.Drawing.Size(88, 13)
        Me.lblConfidenceLimit.TabIndex = 1
        Me.lblConfidenceLimit.Text = "Confidence Limit:"
        '
        'ucrInputConfidenceLimit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblConfidenceLimit)
        Me.Controls.Add(Me.ucrConfidenceLimit)
        Me.Name = "ucrInputConfidenceLimit"
        Me.Size = New System.Drawing.Size(154, 23)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrConfidenceLimit As ucrInputComboBox
    Friend WithEvents lblConfidenceLimit As Label
End Class
