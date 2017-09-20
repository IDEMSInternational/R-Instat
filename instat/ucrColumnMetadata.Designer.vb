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
Partial Class ucrColumnMetadata
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
        Me.grdVariables = New unvell.ReoGrid.ReoGridControl()
        Me.columnContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuColumnRename = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDuplicateColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInsertColsBefore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInsertColsAfter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteCol = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuConvertToFactor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCovertToOrderedFactors = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertVariate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertToDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvert = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHideColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUnhideColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUnhideAllColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem21 = New System.Windows.Forms.ToolStripSeparator()
        Me.FreezeToHereToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnfreezeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.columnFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clearColumnFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.mnuConvertToLogical = New System.Windows.Forms.ToolStripMenuItem()
        Me.columnContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdVariables
        '
        Me.grdVariables.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdVariables.BackColor = System.Drawing.Color.White
        Me.grdVariables.ColumnHeaderContextMenuStrip = Nothing
        Me.grdVariables.LeadHeaderContextMenuStrip = Nothing
        Me.grdVariables.Location = New System.Drawing.Point(0, 20)
        Me.grdVariables.Name = "grdVariables"
        Me.grdVariables.RowHeaderContextMenuStrip = Me.columnContextMenuStrip
        Me.grdVariables.Script = Nothing
        Me.grdVariables.SheetTabContextMenuStrip = Nothing
        Me.grdVariables.SheetTabNewButtonVisible = True
        Me.grdVariables.SheetTabVisible = True
        Me.grdVariables.SheetTabWidth = 200
        Me.grdVariables.ShowScrollEndSpacing = True
        Me.grdVariables.Size = New System.Drawing.Size(344, 118)
        Me.grdVariables.TabIndex = 2
        Me.grdVariables.Text = "Variables"
        '
        'columnContextMenuStrip
        '
        Me.columnContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColumnRename, Me.mnuDuplicateColumn, Me.mnuInsertColsBefore, Me.mnuInsertColsAfter, Me.mnuDeleteCol, Me.toolStripMenuItem2, Me.mnuConvertToFactor, Me.mnuCovertToOrderedFactors, Me.mnuConvertText, Me.mnuConvertToLogical, Me.mnuConvertVariate, Me.mnuConvertToDate, Me.mnuConvert, Me.ToolStripSeparator1, Me.mnuHideColumns, Me.mnuUnhideColumns, Me.mnuUnhideAllColumns, Me.toolStripMenuItem21, Me.FreezeToHereToolStripMenuItem, Me.UnfreezeToolStripMenuItem, Me.ToolStripSeparator3, Me.SortToolStripMenuItem, Me.columnFilterToolStripMenuItem, Me.clearColumnFilterToolStripMenuItem})
        Me.columnContextMenuStrip.Name = "columnContextMenuStrip"
        Me.columnContextMenuStrip.Size = New System.Drawing.Size(213, 490)
        '
        'mnuColumnRename
        '
        Me.mnuColumnRename.Name = "mnuColumnRename"
        Me.mnuColumnRename.Size = New System.Drawing.Size(212, 22)
        Me.mnuColumnRename.Text = "Rename Column..."
        '
        'mnuDuplicateColumn
        '
        Me.mnuDuplicateColumn.Name = "mnuDuplicateColumn"
        Me.mnuDuplicateColumn.Size = New System.Drawing.Size(212, 22)
        Me.mnuDuplicateColumn.Text = "Duplicate Column..."
        '
        'mnuInsertColsBefore
        '
        Me.mnuInsertColsBefore.Name = "mnuInsertColsBefore"
        Me.mnuInsertColsBefore.Size = New System.Drawing.Size(212, 22)
        Me.mnuInsertColsBefore.Text = "Insert Column(s) Before"
        '
        'mnuInsertColsAfter
        '
        Me.mnuInsertColsAfter.Name = "mnuInsertColsAfter"
        Me.mnuInsertColsAfter.Size = New System.Drawing.Size(212, 22)
        Me.mnuInsertColsAfter.Text = "Insert Column(s) After"
        '
        'mnuDeleteCol
        '
        Me.mnuDeleteCol.Name = "mnuDeleteCol"
        Me.mnuDeleteCol.Size = New System.Drawing.Size(212, 22)
        Me.mnuDeleteCol.Text = "Delete Column(s)"
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(209, 6)
        '
        'mnuConvertToFactor
        '
        Me.mnuConvertToFactor.Name = "mnuConvertToFactor"
        Me.mnuConvertToFactor.Size = New System.Drawing.Size(212, 22)
        Me.mnuConvertToFactor.Text = "Convert to Factor"
        '
        'mnuCovertToOrderedFactors
        '
        Me.mnuCovertToOrderedFactors.Name = "mnuCovertToOrderedFactors"
        Me.mnuCovertToOrderedFactors.Size = New System.Drawing.Size(212, 22)
        Me.mnuCovertToOrderedFactors.Text = "Convert to Ordered Factor"
        '
        'mnuConvertText
        '
        Me.mnuConvertText.Name = "mnuConvertText"
        Me.mnuConvertText.Size = New System.Drawing.Size(212, 22)
        Me.mnuConvertText.Text = "Convert to Character"
        '
        'mnuConvertVariate
        '
        Me.mnuConvertVariate.Name = "mnuConvertVariate"
        Me.mnuConvertVariate.Size = New System.Drawing.Size(212, 22)
        Me.mnuConvertVariate.Text = "Convert to Numeric"
        '
        'mnuConvertToDate
        '
        Me.mnuConvertToDate.Name = "mnuConvertToDate"
        Me.mnuConvertToDate.Size = New System.Drawing.Size(212, 22)
        Me.mnuConvertToDate.Text = "Convert to Date..."
        '
        'mnuConvert
        '
        Me.mnuConvert.Name = "mnuConvert"
        Me.mnuConvert.Size = New System.Drawing.Size(212, 22)
        Me.mnuConvert.Text = "Convert..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(209, 6)
        '
        'mnuHideColumns
        '
        Me.mnuHideColumns.Name = "mnuHideColumns"
        Me.mnuHideColumns.Size = New System.Drawing.Size(212, 22)
        Me.mnuHideColumns.Text = "Hide"
        '
        'mnuUnhideColumns
        '
        Me.mnuUnhideColumns.Name = "mnuUnhideColumns"
        Me.mnuUnhideColumns.Size = New System.Drawing.Size(212, 22)
        Me.mnuUnhideColumns.Text = "Unhide..."
        '
        'mnuUnhideAllColumns
        '
        Me.mnuUnhideAllColumns.Name = "mnuUnhideAllColumns"
        Me.mnuUnhideAllColumns.Size = New System.Drawing.Size(212, 22)
        Me.mnuUnhideAllColumns.Tag = "Unhide_All"
        Me.mnuUnhideAllColumns.Text = "Unhide All"
        '
        'toolStripMenuItem21
        '
        Me.toolStripMenuItem21.Name = "toolStripMenuItem21"
        Me.toolStripMenuItem21.Size = New System.Drawing.Size(209, 6)
        '
        'FreezeToHereToolStripMenuItem
        '
        Me.FreezeToHereToolStripMenuItem.Name = "FreezeToHereToolStripMenuItem"
        Me.FreezeToHereToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.FreezeToHereToolStripMenuItem.Text = "Freeze to Here"
        '
        'UnfreezeToolStripMenuItem
        '
        Me.UnfreezeToolStripMenuItem.Name = "UnfreezeToolStripMenuItem"
        Me.UnfreezeToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.UnfreezeToolStripMenuItem.Text = "Unfreeze"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(209, 6)
        '
        'SortToolStripMenuItem
        '
        Me.SortToolStripMenuItem.Name = "SortToolStripMenuItem"
        Me.SortToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.SortToolStripMenuItem.Text = "Sort..."
        '
        'columnFilterToolStripMenuItem
        '
        Me.columnFilterToolStripMenuItem.Name = "columnFilterToolStripMenuItem"
        Me.columnFilterToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.columnFilterToolStripMenuItem.Text = "Filter..."
        '
        'clearColumnFilterToolStripMenuItem
        '
        Me.clearColumnFilterToolStripMenuItem.Name = "clearColumnFilterToolStripMenuItem"
        Me.clearColumnFilterToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.clearColumnFilterToolStripMenuItem.Text = "Remove Current Filter"
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(344, 20)
        Me.lblHeader.TabIndex = 6
        Me.lblHeader.Text = "Column Metadata"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mnuConvertToLogical
        '
        Me.mnuConvertToLogical.Name = "mnuConvertToLogical"
        Me.mnuConvertToLogical.Size = New System.Drawing.Size(212, 22)
        Me.mnuConvertToLogical.Text = "Convert to Logical"
        '
        'ucrColumnMetadata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.grdVariables)
        Me.Name = "ucrColumnMetadata"
        Me.Size = New System.Drawing.Size(344, 138)
        Me.columnContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdVariables As unvell.ReoGrid.ReoGridControl
    Friend WithEvents lblHeader As Label
    Private WithEvents columnContextMenuStrip As ContextMenuStrip
    Friend WithEvents mnuColumnRename As ToolStripMenuItem
    Friend WithEvents mnuDuplicateColumn As ToolStripMenuItem
    Private WithEvents mnuInsertColsBefore As ToolStripMenuItem
    Friend WithEvents mnuInsertColsAfter As ToolStripMenuItem
    Private WithEvents mnuDeleteCol As ToolStripMenuItem
    Private WithEvents toolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents mnuConvertToFactor As ToolStripMenuItem
    Friend WithEvents mnuCovertToOrderedFactors As ToolStripMenuItem
    Friend WithEvents mnuConvertText As ToolStripMenuItem
    Friend WithEvents mnuConvertVariate As ToolStripMenuItem
    Friend WithEvents mnuConvertToDate As ToolStripMenuItem
    Friend WithEvents mnuConvert As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Private WithEvents mnuHideColumns As ToolStripMenuItem
    Private WithEvents mnuUnhideColumns As ToolStripMenuItem
    Friend WithEvents mnuUnhideAllColumns As ToolStripMenuItem
    Private WithEvents toolStripMenuItem21 As ToolStripSeparator
    Friend WithEvents FreezeToHereToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnfreezeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SortToolStripMenuItem As ToolStripMenuItem
    Private WithEvents columnFilterToolStripMenuItem As ToolStripMenuItem
    Private WithEvents clearColumnFilterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuConvertToLogical As ToolStripMenuItem
End Class
