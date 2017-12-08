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
Partial Class ucrSelector
    Inherits instat.ucrCore

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrSelector))
        Me.lstAvailableVariable = New System.Windows.Forms.ListView()
        Me.SelectionMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectionMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstAvailableVariable
        '
        Me.lstAvailableVariable.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.lstAvailableVariable.ContextMenuStrip = Me.SelectionMenuStrip
        resources.ApplyResources(Me.lstAvailableVariable, "lstAvailableVariable")
        Me.lstAvailableVariable.FullRowSelect = True
        Me.lstAvailableVariable.GridLines = True
        Me.lstAvailableVariable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstAvailableVariable.HideSelection = False
        Me.lstAvailableVariable.Name = "lstAvailableVariable"
        Me.lstAvailableVariable.ShowItemToolTips = True
        Me.lstAvailableVariable.UseCompatibleStateImageBehavior = False
        Me.lstAvailableVariable.View = System.Windows.Forms.View.Details
        '
        'SelectionMenuStrip
        '
        Me.SelectionMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSelectedToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.ClearSelectionToolStripMenuItem, Me.AddAllToolStripMenuItem})
        Me.SelectionMenuStrip.Name = "SelectionMenuStrip"
        resources.ApplyResources(Me.SelectionMenuStrip, "SelectionMenuStrip")
        '
        'AddSelectedToolStripMenuItem
        '
        Me.AddSelectedToolStripMenuItem.Name = "AddSelectedToolStripMenuItem"
        resources.ApplyResources(Me.AddSelectedToolStripMenuItem, "AddSelectedToolStripMenuItem")
        Me.AddSelectedToolStripMenuItem.Tag = "Add_selected"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        resources.ApplyResources(Me.SelectAllToolStripMenuItem, "SelectAllToolStripMenuItem")
        Me.SelectAllToolStripMenuItem.Tag = "Select_All"
        '
        'ClearSelectionToolStripMenuItem
        '
        Me.ClearSelectionToolStripMenuItem.Name = "ClearSelectionToolStripMenuItem"
        resources.ApplyResources(Me.ClearSelectionToolStripMenuItem, "ClearSelectionToolStripMenuItem")
        Me.ClearSelectionToolStripMenuItem.Tag = "Clear_Selection"
        '
        'AddAllToolStripMenuItem
        '
        Me.AddAllToolStripMenuItem.Name = "AddAllToolStripMenuItem"
        resources.ApplyResources(Me.AddAllToolStripMenuItem, "AddAllToolStripMenuItem")
        '
        'ucrSelector
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lstAvailableVariable)
        Me.Name = "ucrSelector"
        Me.SelectionMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Protected Friend WithEvents lstAvailableVariable As ListView
    Friend WithEvents SelectionMenuStrip As ContextMenuStrip
    Friend WithEvents AddSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearSelectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAllToolStripMenuItem As ToolStripMenuItem
End Class
