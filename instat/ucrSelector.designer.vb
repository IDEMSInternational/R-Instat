<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrSelector
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
        Me.components = New System.ComponentModel.Container()
        Me.lstAvailableVariable = New System.Windows.Forms.ListView()
        Me.SelectionMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectionMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstAvailableVariable
        '
        Me.lstAvailableVariable.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.lstAvailableVariable.ContextMenuStrip = Me.SelectionMenuStrip
        Me.lstAvailableVariable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstAvailableVariable.FullRowSelect = True
        Me.lstAvailableVariable.GridLines = True
        Me.lstAvailableVariable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstAvailableVariable.HideSelection = False
        Me.lstAvailableVariable.Location = New System.Drawing.Point(0, 0)
        Me.lstAvailableVariable.Name = "lstAvailableVariable"
        Me.lstAvailableVariable.Size = New System.Drawing.Size(120, 130)
        Me.lstAvailableVariable.TabIndex = 83
        Me.lstAvailableVariable.UseCompatibleStateImageBehavior = False
        Me.lstAvailableVariable.View = System.Windows.Forms.View.Details
        '
        'SelectionMenuStrip
        '
        Me.SelectionMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSelectedToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.ClearSelectionToolStripMenuItem})
        Me.SelectionMenuStrip.Name = "SelectionMenuStrip"
        Me.SelectionMenuStrip.Size = New System.Drawing.Size(153, 70)
        '
        'AddSelectedToolStripMenuItem
        '
        Me.AddSelectedToolStripMenuItem.Name = "AddSelectedToolStripMenuItem"
        Me.AddSelectedToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddSelectedToolStripMenuItem.Tag = "Add_selected"
        Me.AddSelectedToolStripMenuItem.Text = "Add Selected"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SelectAllToolStripMenuItem.Tag = "Select_All"
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ClearSelectionToolStripMenuItem
        '
        Me.ClearSelectionToolStripMenuItem.Name = "ClearSelectionToolStripMenuItem"
        Me.ClearSelectionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearSelectionToolStripMenuItem.Tag = "Clear_Selection"
        Me.ClearSelectionToolStripMenuItem.Text = "Clear Selection"
        '
        'ucrSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lstAvailableVariable)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ucrSelector"
        Me.Size = New System.Drawing.Size(120, 130)
        Me.SelectionMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Protected Friend WithEvents lstAvailableVariable As ListView
    Friend WithEvents SelectionMenuStrip As ContextMenuStrip
    Friend WithEvents AddSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearSelectionToolStripMenuItem As ToolStripMenuItem
End Class
