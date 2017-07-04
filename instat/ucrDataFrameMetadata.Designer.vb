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
Partial Class ucrDataFrameMetadata
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
        Me.grdMetaData = New unvell.ReoGrid.ReoGridControl()
        Me.txtMetadata = New System.Windows.Forms.TextBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'grdMetaData
        '
        Me.grdMetaData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdMetaData.BackColor = System.Drawing.Color.White
        Me.grdMetaData.ColumnHeaderContextMenuStrip = Nothing
        Me.grdMetaData.LeadHeaderContextMenuStrip = Nothing
        Me.grdMetaData.Location = New System.Drawing.Point(0, 20)
        Me.grdMetaData.Name = "grdMetaData"
        Me.grdMetaData.RowHeaderContextMenuStrip = Nothing
        Me.grdMetaData.Script = Nothing
        Me.grdMetaData.SheetTabContextMenuStrip = Nothing
        Me.grdMetaData.SheetTabNewButtonVisible = False
        Me.grdMetaData.SheetTabVisible = False
        Me.grdMetaData.SheetTabWidth = 100
        Me.grdMetaData.Size = New System.Drawing.Size(477, 297)
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
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(477, 20)
        Me.lblHeader.TabIndex = 7
        Me.lblHeader.Text = "Data Frame Metadata"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucrDataFrameMetadata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.grdMetaData)
        Me.Controls.Add(Me.txtMetadata)
        Me.Name = "ucrDataFrameMetadata"
        Me.Size = New System.Drawing.Size(477, 317)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdMetaData As unvell.ReoGrid.ReoGridControl
    Friend WithEvents txtMetadata As TextBox
    Friend WithEvents lblHeader As Label
End Class
