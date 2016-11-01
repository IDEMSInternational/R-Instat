<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgAddNewDistribution
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.ucrBaseSubDialog = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'ucrBaseSubDialog
        '
        Me.ucrBaseSubDialog.Location = New System.Drawing.Point(13, 222)
        Me.ucrBaseSubDialog.Name = "ucrBaseSubDialog"
        Me.ucrBaseSubDialog.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSubDialog.TabIndex = 0
        '
        'sdgAddNewDistribution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 264)
        Me.Controls.Add(Me.ucrBaseSubDialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgAddNewDistribution"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Distribution"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseSubDialog As ucrButtonsSubdialogue
End Class
