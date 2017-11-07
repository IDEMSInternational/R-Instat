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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrDataFrameMetadata))
        Me.grdMetaData = New unvell.ReoGrid.ReoGridControl()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.tlpTableContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpTableContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdMetaData
        '
        Me.grdMetaData.BackColor = System.Drawing.Color.White
        Me.grdMetaData.ColumnHeaderContextMenuStrip = Nothing
        resources.ApplyResources(Me.grdMetaData, "grdMetaData")
        Me.grdMetaData.LeadHeaderContextMenuStrip = Nothing
        Me.grdMetaData.Name = "grdMetaData"
        Me.grdMetaData.RowHeaderContextMenuStrip = Nothing
        Me.grdMetaData.Script = Nothing
        Me.grdMetaData.SheetTabContextMenuStrip = Nothing
        Me.grdMetaData.SheetTabNewButtonVisible = False
        Me.grdMetaData.SheetTabVisible = False
        Me.grdMetaData.SheetTabWidth = 100
        Me.grdMetaData.ShowScrollEndSpacing = True
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(190, Byte), Integer))
        resources.ApplyResources(Me.lblHeader, "lblHeader")
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHeader.Name = "lblHeader"
        '
        'tlpTableContainer
        '
        resources.ApplyResources(Me.tlpTableContainer, "tlpTableContainer")
        Me.tlpTableContainer.Controls.Add(Me.grdMetaData, 0, 1)
        Me.tlpTableContainer.Controls.Add(Me.lblHeader, 0, 0)
        Me.tlpTableContainer.Name = "tlpTableContainer"
        '
        'ucrDataFrameMetadata
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpTableContainer)
        Me.Name = "ucrDataFrameMetadata"
        Me.tlpTableContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdMetaData As unvell.ReoGrid.ReoGridControl
    Friend WithEvents lblHeader As Label
    Friend WithEvents tlpTableContainer As TableLayoutPanel
End Class
