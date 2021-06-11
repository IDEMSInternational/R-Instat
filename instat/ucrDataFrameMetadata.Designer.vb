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
        Me.components = New System.ComponentModel.Container()
        Me.grdMetaData = New unvell.ReoGrid.ReoGridControl()
        Me.cellContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.rowRightClickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.deleteDataFrame = New System.Windows.Forms.ToolStripMenuItem()
        Me.renameSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.hideSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.unhideSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.copySheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.reorderSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHeaderDataFrameMetaData = New System.Windows.Forms.Label()
        Me.tlpTableContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.mnuAddComment = New System.Windows.Forms.ToolStripMenuItem()
        Me.cellContextMenuStrip.SuspendLayout()
        Me.rowRightClickMenu.SuspendLayout()
        Me.tlpTableContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdMetaData
        '
        Me.grdMetaData.BackColor = System.Drawing.Color.White
        Me.grdMetaData.ColumnHeaderContextMenuStrip = Nothing
        Me.grdMetaData.ContextMenuStrip = Me.cellContextMenuStrip
        Me.grdMetaData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMetaData.LeadHeaderContextMenuStrip = Nothing
        Me.grdMetaData.Location = New System.Drawing.Point(3, 23)
        Me.grdMetaData.Name = "grdMetaData"
        Me.grdMetaData.RowHeaderContextMenuStrip = Me.rowRightClickMenu
        Me.grdMetaData.Script = Nothing
        Me.grdMetaData.SheetTabContextMenuStrip = Nothing
        Me.grdMetaData.SheetTabNewButtonVisible = False
        Me.grdMetaData.SheetTabVisible = False
        Me.grdMetaData.SheetTabWidth = 100
        Me.grdMetaData.ShowScrollEndSpacing = True
        Me.grdMetaData.Size = New System.Drawing.Size(471, 291)
        Me.grdMetaData.TabIndex = 1
        Me.grdMetaData.Text = "Meta Data"
        '
        'cellContextMenuStrip
        '
        Me.cellContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelp})
        Me.cellContextMenuStrip.Name = "cellContextMenuStrip"
        Me.cellContextMenuStrip.Size = New System.Drawing.Size(100, 26)
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(99, 22)
        Me.mnuHelp.Text = "Help"
        '
        'rowRightClickMenu
        '
        Me.rowRightClickMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.rowRightClickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.deleteDataFrame, Me.renameSheet, Me.mnuAddComment, Me.hideSheet, Me.unhideSheet, Me.copySheet, Me.reorderSheet, Me.viewSheet})
        Me.rowRightClickMenu.Name = "statusColumnMenu"
        Me.rowRightClickMenu.Size = New System.Drawing.Size(181, 202)
        '
        'deleteDataFrame
        '
        Me.deleteDataFrame.Name = "deleteDataFrame"
        Me.deleteDataFrame.Size = New System.Drawing.Size(180, 22)
        Me.deleteDataFrame.Text = "Delete..."
        '
        'renameSheet
        '
        Me.renameSheet.Name = "renameSheet"
        Me.renameSheet.Size = New System.Drawing.Size(180, 22)
        Me.renameSheet.Text = "Rename..."
        '
        'hideSheet
        '
        Me.hideSheet.Name = "hideSheet"
        Me.hideSheet.Size = New System.Drawing.Size(180, 22)
        Me.hideSheet.Text = "Hide"
        '
        'unhideSheet
        '
        Me.unhideSheet.Name = "unhideSheet"
        Me.unhideSheet.Size = New System.Drawing.Size(180, 22)
        Me.unhideSheet.Text = "Unhide..."
        '
        'copySheet
        '
        Me.copySheet.Name = "copySheet"
        Me.copySheet.Size = New System.Drawing.Size(180, 22)
        Me.copySheet.Text = "Copy..."
        '
        'reorderSheet
        '
        Me.reorderSheet.Enabled = False
        Me.reorderSheet.Name = "reorderSheet"
        Me.reorderSheet.Size = New System.Drawing.Size(180, 22)
        Me.reorderSheet.Text = "Reorder..."
        '
        'viewSheet
        '
        Me.viewSheet.Name = "viewSheet"
        Me.viewSheet.Size = New System.Drawing.Size(180, 22)
        Me.viewSheet.Text = "View Data Frame"
        '
        'lblHeaderDataFrameMetaData
        '
        Me.lblHeaderDataFrameMetaData.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblHeaderDataFrameMetaData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeaderDataFrameMetaData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblHeaderDataFrameMetaData.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHeaderDataFrameMetaData.Location = New System.Drawing.Point(3, 0)
        Me.lblHeaderDataFrameMetaData.Name = "lblHeaderDataFrameMetaData"
        Me.lblHeaderDataFrameMetaData.Size = New System.Drawing.Size(471, 20)
        Me.lblHeaderDataFrameMetaData.TabIndex = 7
        Me.lblHeaderDataFrameMetaData.Text = "Data Frame Metadata"
        Me.lblHeaderDataFrameMetaData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpTableContainer
        '
        Me.tlpTableContainer.ColumnCount = 1
        Me.tlpTableContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.Controls.Add(Me.grdMetaData, 0, 1)
        Me.tlpTableContainer.Controls.Add(Me.lblHeaderDataFrameMetaData, 0, 0)
        Me.tlpTableContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTableContainer.Location = New System.Drawing.Point(0, 0)
        Me.tlpTableContainer.Name = "tlpTableContainer"
        Me.tlpTableContainer.RowCount = 2
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.Size = New System.Drawing.Size(477, 317)
        Me.tlpTableContainer.TabIndex = 8
        '
        'mnuAddComment
        '
        Me.mnuAddComment.Name = "mnuAddComment"
        Me.mnuAddComment.Size = New System.Drawing.Size(180, 22)
        Me.mnuAddComment.Text = "Add Comment..."
        '
        'ucrDataFrameMetadata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpTableContainer)
        Me.Name = "ucrDataFrameMetadata"
        Me.Size = New System.Drawing.Size(477, 317)
        Me.cellContextMenuStrip.ResumeLayout(False)
        Me.rowRightClickMenu.ResumeLayout(False)
        Me.tlpTableContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdMetaData As unvell.ReoGrid.ReoGridControl
    Friend WithEvents lblHeaderDataFrameMetaData As Label
    Friend WithEvents tlpTableContainer As TableLayoutPanel
    Friend WithEvents cellContextMenuStrip As ContextMenuStrip
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents rowRightClickMenu As ContextMenuStrip
    Friend WithEvents deleteDataFrame As ToolStripMenuItem
    Friend WithEvents renameSheet As ToolStripMenuItem
    Friend WithEvents hideSheet As ToolStripMenuItem
    Friend WithEvents unhideSheet As ToolStripMenuItem
    Friend WithEvents copySheet As ToolStripMenuItem
    Friend WithEvents reorderSheet As ToolStripMenuItem
    Friend WithEvents viewSheet As ToolStripMenuItem
    Friend WithEvents mnuAddComment As ToolStripMenuItem
End Class
