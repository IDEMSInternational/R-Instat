<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrReceiverSingleNew
    Inherits instat.ucrReceiver

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
        Me.components = New System.ComponentModel.Container()
        Me.cboReceiverSingle = New System.Windows.Forms.ComboBox()
        Me.mnuRightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuRightClickRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRightClickCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRightClick.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboReceiverSingle
        '
        Me.cboReceiverSingle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboReceiverSingle.FormattingEnabled = True
        Me.cboReceiverSingle.Location = New System.Drawing.Point(0, 0)
        Me.cboReceiverSingle.Name = "cboReceiverSingle"
        Me.cboReceiverSingle.Size = New System.Drawing.Size(121, 21)
        Me.cboReceiverSingle.TabIndex = 0
        '
        'mnuRightClick
        '
        Me.mnuRightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRightClickRemove, Me.mnuRightClickCopy})
        Me.mnuRightClick.Name = "SelectionMenuStrip"
        Me.mnuRightClick.Size = New System.Drawing.Size(118, 48)
        '
        'mnuRightClickRemove
        '
        Me.mnuRightClickRemove.Name = "mnuRightClickRemove"
        Me.mnuRightClickRemove.Size = New System.Drawing.Size(117, 22)
        Me.mnuRightClickRemove.Tag = "remove"
        Me.mnuRightClickRemove.Text = "Remove"
        '
        'mnuRightClickCopy
        '
        Me.mnuRightClickCopy.Name = "mnuRightClickCopy"
        Me.mnuRightClickCopy.Size = New System.Drawing.Size(117, 22)
        Me.mnuRightClickCopy.Text = "Copy"
        '
        'ucrReceiverSingleNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cboReceiverSingle)
        Me.Name = "ucrReceiverSingleNew"
        Me.Size = New System.Drawing.Size(121, 22)
        Me.mnuRightClick.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboReceiverSingle As ComboBox
    Friend WithEvents mnuRightClick As ContextMenuStrip
    Friend WithEvents mnuRightClickRemove As ToolStripMenuItem
    Friend WithEvents mnuRightClickCopy As ToolStripMenuItem
End Class
