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
Partial Class frmMetaData
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
        Me.grdMetaData = New unvell.ReoGrid.ReoGridControl()
        Me.txtMetadata = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'grdMetaData
        '
        Me.grdMetaData.BackColor = System.Drawing.Color.White
        Me.grdMetaData.ColumnHeaderContextMenuStrip = Nothing
        Me.grdMetaData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMetaData.LeadHeaderContextMenuStrip = Nothing
        Me.grdMetaData.Location = New System.Drawing.Point(0, 0)
        Me.grdMetaData.Name = "grdMetaData"
        Me.grdMetaData.RowHeaderContextMenuStrip = Nothing
        Me.grdMetaData.Script = Nothing
        Me.grdMetaData.SheetTabContextMenuStrip = Nothing
        Me.grdMetaData.SheetTabNewButtonVisible = False
        Me.grdMetaData.SheetTabVisible = False
        Me.grdMetaData.SheetTabWidth = 100
        Me.grdMetaData.Size = New System.Drawing.Size(477, 317)
        Me.grdMetaData.TabIndex = 1
        Me.grdMetaData.Text = "Meta Data"
        '
        'txtMetadata
        '
        Me.txtMetadata.Location = New System.Drawing.Point(213, 11)
        Me.txtMetadata.Multiline = True
        Me.txtMetadata.Name = "txtMetadata"
        Me.txtMetadata.ReadOnly = True
        Me.txtMetadata.Size = New System.Drawing.Size(205, 100)
        Me.txtMetadata.TabIndex = 2
        '
        'frmMetaData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 317)
        Me.Controls.Add(Me.grdMetaData)
        Me.Controls.Add(Me.txtMetadata)
        Me.Name = "frmMetaData"
        Me.ShowIcon = False
        Me.Text = "Data frame Metadata"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdMetaData As unvell.ReoGrid.ReoGridControl
    Friend WithEvents txtMetadata As TextBox
End Class
