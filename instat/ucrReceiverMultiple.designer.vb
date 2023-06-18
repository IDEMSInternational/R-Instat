' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

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
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripDelete.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstSelectedVariables
        '
        Me.lstSelectedVariables.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.lstSelectedVariables.ContextMenuStrip = Me.MenuStripDelete
        Me.lstSelectedVariables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstSelectedVariables.FullRowSelect = True
        Me.lstSelectedVariables.GridLines = True
        Me.lstSelectedVariables.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstSelectedVariables.HideSelection = False
        Me.lstSelectedVariables.Location = New System.Drawing.Point(0, 0)
        Me.lstSelectedVariables.Name = "lstSelectedVariables"
        Me.lstSelectedVariables.ShowItemToolTips = True
        Me.lstSelectedVariables.Size = New System.Drawing.Size(120, 100)
        Me.lstSelectedVariables.TabIndex = 1
        Me.lstSelectedVariables.UseCompatibleStateImageBehavior = False
        Me.lstSelectedVariables.View = System.Windows.Forms.View.Details
        '
        'MenuStripDelete
        '
        Me.MenuStripDelete.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.MenuStripDelete.Name = "ContextMenuStrip1"
        Me.MenuStripDelete.Size = New System.Drawing.Size(118, 48)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RemoveToolStripMenuItem.Tag = "remove"
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ucrReceiverMultiple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.lstSelectedVariables)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ucrReceiverMultiple"
        Me.Size = New System.Drawing.Size(120, 100)
        Me.MenuStripDelete.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstSelectedVariables As ListView
    Friend WithEvents MenuStripDelete As ContextMenuStrip
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
End Class
