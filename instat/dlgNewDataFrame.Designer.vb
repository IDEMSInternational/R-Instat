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
Partial Class dlgNewDataFrame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgNewDataFrame))
        Me.lblRows = New System.Windows.Forms.Label()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.rdoCommand = New System.Windows.Forms.RadioButton()
        Me.rdoRandom = New System.Windows.Forms.RadioButton()
        Me.rdoEmpty = New System.Windows.Forms.RadioButton()
        Me.rdoConstruct = New System.Windows.Forms.RadioButton()
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        Me.colRowNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colExpression = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnuStripCommand = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuItemCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCommand = New System.Windows.Forms.Label()
        Me.btnExample = New System.Windows.Forms.Button()
        Me.btnTry = New System.Windows.Forms.Button()
        Me.ucrInputTryMessage = New instat.ucrInputTextBox()
        Me.ucrInputCommand = New instat.ucrInputTextBox()
        Me.ucrPnlDataFrame = New instat.UcrPanel()
        Me.ucrNewDFName = New instat.ucrSave()
        Me.ucrNudCols = New instat.ucrNud()
        Me.ucrNudRows = New instat.ucrNud()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuStripCommand.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRows
        '
        resources.ApplyResources(Me.lblRows, "lblRows")
        Me.lblRows.Name = "lblRows"
        '
        'lblColumns
        '
        resources.ApplyResources(Me.lblColumns, "lblColumns")
        Me.lblColumns.Name = "lblColumns"
        '
        'rdoCommand
        '
        resources.ApplyResources(Me.rdoCommand, "rdoCommand")
        Me.rdoCommand.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCommand.FlatAppearance.BorderSize = 2
        Me.rdoCommand.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCommand.Name = "rdoCommand"
        Me.rdoCommand.TabStop = True
        Me.rdoCommand.UseVisualStyleBackColor = True
        '
        'rdoRandom
        '
        resources.ApplyResources(Me.rdoRandom, "rdoRandom")
        Me.rdoRandom.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRandom.FlatAppearance.BorderSize = 2
        Me.rdoRandom.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRandom.Name = "rdoRandom"
        Me.rdoRandom.TabStop = True
        Me.rdoRandom.UseVisualStyleBackColor = True
        '
        'rdoEmpty
        '
        resources.ApplyResources(Me.rdoEmpty, "rdoEmpty")
        Me.rdoEmpty.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEmpty.FlatAppearance.BorderSize = 2
        Me.rdoEmpty.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEmpty.Name = "rdoEmpty"
        Me.rdoEmpty.TabStop = True
        Me.rdoEmpty.UseVisualStyleBackColor = True
        '
        'rdoConstruct
        '
        resources.ApplyResources(Me.rdoConstruct, "rdoConstruct")
        Me.rdoConstruct.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoConstruct.FlatAppearance.BorderSize = 2
        Me.rdoConstruct.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoConstruct.Name = "rdoConstruct"
        Me.rdoConstruct.TabStop = True
        Me.rdoConstruct.UseVisualStyleBackColor = True
        '
        'dataGridView
        '
        Me.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRowNum, Me.colName, Me.colExpression})
        resources.ApplyResources(Me.dataGridView, "dataGridView")
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.RowHeadersVisible = False
        Me.dataGridView.RowTemplate.Height = 28
        '
        'colRowNum
        '
        resources.ApplyResources(Me.colRowNum, "colRowNum")
        Me.colRowNum.Name = "colRowNum"
        Me.colRowNum.ReadOnly = True
        '
        'colName
        '
        resources.ApplyResources(Me.colName, "colName")
        Me.colName.Name = "colName"
        '
        'colExpression
        '
        Me.colExpression.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        resources.ApplyResources(Me.colExpression, "colExpression")
        Me.colExpression.Name = "colExpression"
        '
        'mnuStripCommand
        '
        Me.mnuStripCommand.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuStripCommand.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemCut, Me.mnuItemCopy, Me.mnuItemPaste, Me.mnuItemUndo, Me.SelectAllToolStripMenuItem})
        Me.mnuStripCommand.Name = "mnuStripCommand"
        resources.ApplyResources(Me.mnuStripCommand, "mnuStripCommand")
        '
        'mnuItemCut
        '
        Me.mnuItemCut.Name = "mnuItemCut"
        resources.ApplyResources(Me.mnuItemCut, "mnuItemCut")
        '
        'mnuItemCopy
        '
        Me.mnuItemCopy.Name = "mnuItemCopy"
        resources.ApplyResources(Me.mnuItemCopy, "mnuItemCopy")
        '
        'mnuItemPaste
        '
        Me.mnuItemPaste.Name = "mnuItemPaste"
        resources.ApplyResources(Me.mnuItemPaste, "mnuItemPaste")
        '
        'mnuItemUndo
        '
        Me.mnuItemUndo.Name = "mnuItemUndo"
        resources.ApplyResources(Me.mnuItemUndo, "mnuItemUndo")
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        resources.ApplyResources(Me.SelectAllToolStripMenuItem, "SelectAllToolStripMenuItem")
        '
        'lblCommand
        '
        resources.ApplyResources(Me.lblCommand, "lblCommand")
        Me.lblCommand.Name = "lblCommand"
        '
        'btnExample
        '
        resources.ApplyResources(Me.btnExample, "btnExample")
        Me.btnExample.Name = "btnExample"
        Me.btnExample.UseVisualStyleBackColor = True
        '
        'btnTry
        '
        resources.ApplyResources(Me.btnTry, "btnTry")
        Me.btnTry.Name = "btnTry"
        Me.btnTry.UseVisualStyleBackColor = True
        '
        'ucrInputTryMessage
        '
        Me.ucrInputTryMessage.AddQuotesIfUnrecognised = True
        Me.ucrInputTryMessage.IsMultiline = False
        Me.ucrInputTryMessage.IsReadOnly = True
        resources.ApplyResources(Me.ucrInputTryMessage, "ucrInputTryMessage")
        Me.ucrInputTryMessage.Name = "ucrInputTryMessage"
        '
        'ucrInputCommand
        '
        Me.ucrInputCommand.AddQuotesIfUnrecognised = True
        Me.ucrInputCommand.IsMultiline = True
        Me.ucrInputCommand.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputCommand, "ucrInputCommand")
        Me.ucrInputCommand.Name = "ucrInputCommand"
        '
        'ucrPnlDataFrame
        '
        resources.ApplyResources(Me.ucrPnlDataFrame, "ucrPnlDataFrame")
        Me.ucrPnlDataFrame.Name = "ucrPnlDataFrame"
        '
        'ucrNewDFName
        '
        resources.ApplyResources(Me.ucrNewDFName, "ucrNewDFName")
        Me.ucrNewDFName.Name = "ucrNewDFName"
        '
        'ucrNudCols
        '
        Me.ucrNudCols.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCols.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudCols, "ucrNudCols")
        Me.ucrNudCols.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCols.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCols.Name = "ucrNudCols"
        Me.ucrNudCols.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudRows
        '
        Me.ucrNudRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudRows, "ucrNudRows")
        Me.ucrNudRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRows.Name = "ucrNudRows"
        Me.ucrNudRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgNewDataFrame
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputTryMessage)
        Me.Controls.Add(Me.btnTry)
        Me.Controls.Add(Me.ucrInputCommand)
        Me.Controls.Add(Me.btnExample)
        Me.Controls.Add(Me.lblCommand)
        Me.Controls.Add(Me.dataGridView)
        Me.Controls.Add(Me.rdoCommand)
        Me.Controls.Add(Me.rdoRandom)
        Me.Controls.Add(Me.rdoEmpty)
        Me.Controls.Add(Me.rdoConstruct)
        Me.Controls.Add(Me.ucrPnlDataFrame)
        Me.Controls.Add(Me.ucrNewDFName)
        Me.Controls.Add(Me.ucrNudCols)
        Me.Controls.Add(Me.ucrNudRows)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.lblRows)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgNewDataFrame"
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuStripCommand.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblColumns As Label
    Friend WithEvents lblRows As Label
    Friend WithEvents ucrNudRows As ucrNud
    Friend WithEvents ucrNudCols As ucrNud
    Friend WithEvents ucrNewDFName As ucrSave
    Friend WithEvents ucrPnlDataFrame As UcrPanel
    Friend WithEvents rdoCommand As RadioButton
    Friend WithEvents rdoRandom As RadioButton
    Friend WithEvents rdoEmpty As RadioButton
    Friend WithEvents rdoConstruct As RadioButton
    Friend WithEvents dataGridView As DataGridView
    Friend WithEvents lblCommand As Label
    Friend WithEvents mnuStripCommand As ContextMenuStrip
    Friend WithEvents mnuItemCut As ToolStripMenuItem
    Friend WithEvents mnuItemCopy As ToolStripMenuItem
    Friend WithEvents mnuItemPaste As ToolStripMenuItem
    Friend WithEvents mnuItemUndo As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnExample As Button
    Friend WithEvents ucrInputCommand As ucrInputTextBox
    Friend WithEvents colRowNum As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colExpression As DataGridViewTextBoxColumn
    Friend WithEvents ucrInputTryMessage As ucrInputTextBox
    Friend WithEvents btnTry As Button
End Class
