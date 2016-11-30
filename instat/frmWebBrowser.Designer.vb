<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWebBrowser
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
        Me.wbOutput = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'wbOutput
        '
        Me.wbOutput.AllowNavigation = False
        Me.wbOutput.AllowWebBrowserDrop = False
        Me.wbOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbOutput.IsWebBrowserContextMenuEnabled = False
        Me.wbOutput.Location = New System.Drawing.Point(0, 0)
        Me.wbOutput.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbOutput.Name = "wbOutput"
        Me.wbOutput.ScrollBarsEnabled = False
        Me.wbOutput.Size = New System.Drawing.Size(605, 433)
        Me.wbOutput.TabIndex = 0
        Me.wbOutput.WebBrowserShortcutsEnabled = False
        '
        'frmWebBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 433)
        Me.Controls.Add(Me.wbOutput)
        Me.Name = "frmWebBrowser"
        Me.Tag = "HTML_Output_Window"
        Me.Text = "HTML Output Window"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents wbOutput As WebBrowser
End Class
