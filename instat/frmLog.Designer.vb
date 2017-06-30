<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLog
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
        Me.components = New System.ComponentModel.Container()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.mnuContextLogFile = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuOpenLogFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuContextLogFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLog
        '
        Me.txtLog.ContextMenuStrip = Me.mnuContextLogFile
        Me.txtLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLog.Location = New System.Drawing.Point(0, 0)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLog.Size = New System.Drawing.Size(531, 415)
        Me.txtLog.TabIndex = 0
        Me.txtLog.TabStop = False
        '
        'mnuContextLogFile
        '
        Me.mnuContextLogFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpenLogFile})
        Me.mnuContextLogFile.Name = "mnuContextLogFile"
        Me.mnuContextLogFile.Size = New System.Drawing.Size(148, 26)
        '
        'mnuOpenLogFile
        '
        Me.mnuOpenLogFile.Name = "mnuOpenLogFile"
        Me.mnuOpenLogFile.Size = New System.Drawing.Size(147, 22)
        Me.mnuOpenLogFile.Text = "Open Log File"
        '
        'frmLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 415)
        Me.Controls.Add(Me.txtLog)
        Me.Name = "frmLog"
        Me.ShowIcon = False
        Me.Text = "Log Window"
        Me.mnuContextLogFile.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLog As TextBox
    Friend WithEvents mnuContextLogFile As ContextMenuStrip
    Friend WithEvents mnuOpenLogFile As ToolStripMenuItem
End Class
