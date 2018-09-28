<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgComment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgComment))
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.ucrBaseSdg = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'txtComment
        '
        resources.ApplyResources(Me.txtComment, "txtComment")
        Me.txtComment.Name = "txtComment"
        '
        'ucrBaseSdg
        '
        resources.ApplyResources(Me.ucrBaseSdg, "ucrBaseSdg")
        Me.ucrBaseSdg.Name = "ucrBaseSdg"
        '
        'sdgComment
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrBaseSdg)
        Me.Controls.Add(Me.txtComment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgComment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtComment As TextBox
    Friend WithEvents ucrBaseSdg As ucrButtonsSubdialogue
End Class
