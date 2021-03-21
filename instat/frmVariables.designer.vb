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
Partial Class frmVariables
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
        Me.grdVariables = New unvell.ReoGrid.ReoGridControl()
        Me.SuspendLayout()
        '
        'grdVariables
        '
        Me.grdVariables.BackColor = System.Drawing.Color.White
        Me.grdVariables.ColumnHeaderContextMenuStrip = Nothing
        Me.grdVariables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdVariables.LeadHeaderContextMenuStrip = Nothing
        Me.grdVariables.Location = New System.Drawing.Point(0, 0)
        Me.grdVariables.Name = "grdVariables"
        Me.grdVariables.RowHeaderContextMenuStrip = Nothing
        Me.grdVariables.Script = Nothing
        Me.grdVariables.SheetTabContextMenuStrip = Nothing
        Me.grdVariables.SheetTabNewButtonVisible = True
        Me.grdVariables.SheetTabVisible = True
        Me.grdVariables.SheetTabWidth = 300
        Me.grdVariables.Size = New System.Drawing.Size(344, 138)
        Me.grdVariables.TabIndex = 2
        Me.grdVariables.Text = "Variables"
        '
        'frmVariables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 138)
        Me.Controls.Add(Me.grdVariables)
        Me.Name = "frmVariables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Column Metadata"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdVariables As unvell.ReoGrid.ReoGridControl
End Class
