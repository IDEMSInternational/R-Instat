<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrReceiverMultiple
    Inherits instat.ucrReceiver

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lstSelectedVariables = New System.Windows.Forms.ListView()
        Me.MenuStripDelete = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripDelete.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstSelectedVariables
        '
        Me.lstSelectedVariables.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.lstSelectedVariables.ContextMenuStrip = Me.MenuStripDelete
        Me.lstSelectedVariables.GridLines = True
        Me.lstSelectedVariables.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstSelectedVariables.Location = New System.Drawing.Point(3, 5)
        Me.lstSelectedVariables.Name = "lstSelectedVariables"
        Me.lstSelectedVariables.Size = New System.Drawing.Size(113, 95)
        Me.lstSelectedVariables.TabIndex = 1
        Me.lstSelectedVariables.UseCompatibleStateImageBehavior = False
        Me.lstSelectedVariables.View = System.Windows.Forms.View.Details
        '
        'MenuStripDelete
        '
        Me.MenuStripDelete.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.MenuStripDelete.Name = "ContextMenuStrip1"
        Me.MenuStripDelete.Size = New System.Drawing.Size(108, 48)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Tag = "delete"
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ucrReceiverMultiple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.lstSelectedVariables)
        Me.Name = "ucrReceiverMultiple"
        Me.Size = New System.Drawing.Size(121, 104)
        Me.MenuStripDelete.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstSelectedVariables As ListView
    Friend WithEvents MenuStripDelete As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
End Class
