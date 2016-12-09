<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOutputWindow
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
        Me.components = New System.ComponentModel.Container()
        Me.ucrWPFrtfElementHost = New System.Windows.Forms.Integration.ElementHost()
        Me.ucrRichTextBox = New instat.ucrWPFRichTextBox()
        Me.mnuContextRTB = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyRTB = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuContextRTB.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrWPFrtfElementHost
        '
        Me.ucrWPFrtfElementHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrWPFrtfElementHost.Location = New System.Drawing.Point(0, 0)
        Me.ucrWPFrtfElementHost.Name = "ucrWPFrtfElementHost"
        Me.ucrWPFrtfElementHost.Size = New System.Drawing.Size(722, 262)
        Me.ucrWPFrtfElementHost.TabIndex = 0
        Me.ucrWPFrtfElementHost.Text = "ucrWPFrtfElementHost"
        Me.ucrWPFrtfElementHost.Child = Me.ucrRichTextBox
        '
        'mnuContextRTB
        '
        Me.mnuContextRTB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyRTB})
        Me.mnuContextRTB.Name = "mnuContextRTB"
        Me.mnuContextRTB.Size = New System.Drawing.Size(103, 26)
        '
        'CopyRTB
        '
        Me.CopyRTB.Name = "CopyRTB"
        Me.CopyRTB.Size = New System.Drawing.Size(102, 22)
        Me.CopyRTB.Text = "Copy"
        '
        'frmOutputWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 262)
        Me.Controls.Add(Me.ucrWPFrtfElementHost)
        Me.Name = "frmOutputWindow"
        Me.ShowIcon = False
        Me.Text = "Output Window"
        Me.mnuContextRTB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrWPFrtfElementHost As Integration.ElementHost
    Friend ucrRichTextBox As ucrWPFRichTextBox
    Friend WithEvents mnuContextRTB As ContextMenuStrip
    Friend WithEvents CopyRTB As ToolStripMenuItem
End Class
