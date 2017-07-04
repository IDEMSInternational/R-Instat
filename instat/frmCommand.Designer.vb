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
Partial Class frmCommand
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
        Me.txtCommand = New System.Windows.Forms.RichTextBox()
        Me.mnuContextRTB = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyRTB = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuContextRTB.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCommand
        '
        Me.txtCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCommand.Location = New System.Drawing.Point(0, 0)
        Me.txtCommand.Name = "txtCommand"
        Me.txtCommand.ReadOnly = True
        Me.txtCommand.Size = New System.Drawing.Size(631, 261)
        Me.txtCommand.TabIndex = 0
        Me.txtCommand.Text = ""
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
        'frmCommand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 261)
        Me.Controls.Add(Me.txtCommand)
        Me.Name = "frmCommand"
        Me.ShowIcon = False
        Me.Tag = "Output_Window"
        Me.Text = "Output Window"
        Me.mnuContextRTB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtCommand As RichTextBox
    Friend WithEvents mnuContextRTB As ContextMenuStrip
    Friend WithEvents CopyRTB As ToolStripMenuItem
End Class
