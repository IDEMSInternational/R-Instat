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
Partial Class ucrSelectorAddRemove
    Inherits instat.ucrSelector

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.contextMenuStripAdd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripAddSelected = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripAddAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparatorContext = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAdd = New instat.ucrSplitButton()
        Me.contextMenuStripAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstAvailableVariable
        '
        Me.lstAvailableVariable.Dock = System.Windows.Forms.DockStyle.None
        '
        'cmdOptions
        '
        Me.cmdOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.cmdOptions.Location = New System.Drawing.Point(230, 144)
        Me.cmdOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(86, 51)
        Me.cmdOptions.TabIndex = 84
        Me.cmdOptions.Tag = "Data_Options"
        Me.cmdOptions.Text = "Data Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'contextMenuStripAdd
        '
        Me.contextMenuStripAdd.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.contextMenuStripAdd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripAddSelected, Me.toolStripAddAll, Me.ToolStripSeparatorContext, Me.toolStripHelp})
        Me.contextMenuStripAdd.Name = "SelectionMenuStrip"
        Me.contextMenuStripAdd.Size = New System.Drawing.Size(190, 106)
        '
        'toolStripAddSelected
        '
        Me.toolStripAddSelected.Name = "toolStripAddSelected"
        Me.toolStripAddSelected.Size = New System.Drawing.Size(189, 32)
        Me.toolStripAddSelected.Tag = "Add_selected"
        Me.toolStripAddSelected.Text = "Add Selected"
        '
        'toolStripAddAll
        '
        Me.toolStripAddAll.Name = "toolStripAddAll"
        Me.toolStripAddAll.Size = New System.Drawing.Size(189, 32)
        Me.toolStripAddAll.Text = "Add All"
        '
        'ToolStripSeparatorContext
        '
        Me.ToolStripSeparatorContext.Name = "ToolStripSeparatorContext"
        Me.ToolStripSeparatorContext.Size = New System.Drawing.Size(186, 6)
        '
        'toolStripHelp
        '
        Me.toolStripHelp.Name = "toolStripHelp"
        Me.toolStripHelp.Size = New System.Drawing.Size(189, 32)
        Me.toolStripHelp.Text = "Help"
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.ContextMenuStrip = Me.contextMenuStripAdd
        Me.btnAdd.Location = New System.Drawing.Point(228, 21)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 51)
        Me.btnAdd.SplitMenuStrip = Me.contextMenuStripAdd
        Me.btnAdd.TabIndex = 86
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'ucrSelectorAddRemove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmdOptions)
        Me.Name = "ucrSelectorAddRemove"
        Me.Size = New System.Drawing.Size(336, 296)
        Me.Controls.SetChildIndex(Me.lstAvailableVariable, 0)
        Me.Controls.SetChildIndex(Me.cmdOptions, 0)
        Me.Controls.SetChildIndex(Me.btnAdd, 0)
        Me.contextMenuStripAdd.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOptions As Button
    Friend WithEvents contextMenuStripAdd As ContextMenuStrip
    Friend WithEvents toolStripAddSelected As ToolStripMenuItem
    Friend WithEvents toolStripAddAll As ToolStripMenuItem
    Friend WithEvents ToolStripSeparatorContext As ToolStripSeparator
    Friend WithEvents toolStripHelp As ToolStripMenuItem
    Friend WithEvents btnAdd As ucrSplitButton
End Class
