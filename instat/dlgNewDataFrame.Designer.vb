﻿' R- Instat
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.dataTypeGridView = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNames = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colDefault = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colLevels = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colLabel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rdoLists = New System.Windows.Forms.RadioButton()
        Me.lblCategories = New System.Windows.Forms.Label()
        Me.lblLists = New System.Windows.Forms.Label()
        Me.ucrNudCols = New instat.ucrNud()
        Me.ucrChkRCommand = New instat.ucrCheck()
        Me.ucrInputListInCategory = New instat.ucrInputComboBox()
        Me.ucrInputCategory = New instat.ucrInputComboBox()
        Me.ucrInputLists = New instat.ucrInputTextBox()
        Me.ucrChkIncludeLabel = New instat.ucrCheck()
        Me.ucrChkVariable = New instat.ucrCheck()
        Me.ucrTryNewDataFrame = New instat.ucrTry()
        Me.ucrInputCommand = New instat.ucrInputTextBox()
        Me.ucrPnlDataFrame = New instat.UcrPanel()
        Me.ucrNewDFName = New instat.ucrSave()
        Me.ucrNudRows = New instat.ucrNud()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuStripCommand.SuspendLayout()
        CType(Me.dataTypeGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRows
        '
        Me.lblRows.AutoSize = True
        Me.lblRows.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRows.Location = New System.Drawing.Point(265, 58)
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Size = New System.Drawing.Size(37, 13)
        Me.lblRows.TabIndex = 8
        Me.lblRows.Text = "Rows:"
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(37, 59)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(50, 13)
        Me.lblColumns.TabIndex = 10
        Me.lblColumns.Text = "Columns:"
        '
        'rdoCommand
        '
        Me.rdoCommand.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCommand.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCommand.FlatAppearance.BorderSize = 2
        Me.rdoCommand.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCommand.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCommand.Location = New System.Drawing.Point(333, 15)
        Me.rdoCommand.Name = "rdoCommand"
        Me.rdoCommand.Size = New System.Drawing.Size(78, 27)
        Me.rdoCommand.TabIndex = 2
        Me.rdoCommand.TabStop = True
        Me.rdoCommand.Text = "Command"
        Me.rdoCommand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCommand.UseVisualStyleBackColor = True
        '
        'rdoRandom
        '
        Me.rdoRandom.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRandom.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRandom.FlatAppearance.BorderSize = 2
        Me.rdoRandom.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRandom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRandom.Location = New System.Drawing.Point(192, 15)
        Me.rdoRandom.Name = "rdoRandom"
        Me.rdoRandom.Size = New System.Drawing.Size(73, 27)
        Me.rdoRandom.TabIndex = 3
        Me.rdoRandom.TabStop = True
        Me.rdoRandom.Text = "Random"
        Me.rdoRandom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRandom.UseVisualStyleBackColor = True
        '
        'rdoEmpty
        '
        Me.rdoEmpty.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoEmpty.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEmpty.FlatAppearance.BorderSize = 2
        Me.rdoEmpty.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoEmpty.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoEmpty.Location = New System.Drawing.Point(45, 15)
        Me.rdoEmpty.Name = "rdoEmpty"
        Me.rdoEmpty.Size = New System.Drawing.Size(74, 27)
        Me.rdoEmpty.TabIndex = 4
        Me.rdoEmpty.TabStop = True
        Me.rdoEmpty.Text = "New"
        Me.rdoEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoEmpty.UseVisualStyleBackColor = True
        '
        'rdoConstruct
        '
        Me.rdoConstruct.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoConstruct.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoConstruct.FlatAppearance.BorderSize = 2
        Me.rdoConstruct.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoConstruct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoConstruct.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoConstruct.Location = New System.Drawing.Point(265, 15)
        Me.rdoConstruct.Name = "rdoConstruct"
        Me.rdoConstruct.Size = New System.Drawing.Size(69, 27)
        Me.rdoConstruct.TabIndex = 1
        Me.rdoConstruct.TabStop = True
        Me.rdoConstruct.Text = "Construct"
        Me.rdoConstruct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoConstruct.UseVisualStyleBackColor = True
        '
        'dataGridView
        '
        Me.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRowNum, Me.colName, Me.colExpression})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridView.DefaultCellStyle = DataGridViewCellStyle14
        Me.dataGridView.Location = New System.Drawing.Point(19, 81)
        Me.dataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.dataGridView.Name = "dataGridView"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dataGridView.RowHeadersVisible = False
        Me.dataGridView.RowTemplate.Height = 28
        Me.dataGridView.Size = New System.Drawing.Size(417, 159)
        Me.dataGridView.TabIndex = 9
        '
        'colRowNum
        '
        Me.colRowNum.HeaderText = "No."
        Me.colRowNum.Name = "colRowNum"
        Me.colRowNum.ReadOnly = True
        Me.colRowNum.Width = 40
        '
        'colName
        '
        Me.colName.HeaderText = "Column Name"
        Me.colName.Name = "colName"
        Me.colName.Width = 130
        '
        'colExpression
        '
        Me.colExpression.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colExpression.HeaderText = "Expression"
        Me.colExpression.Name = "colExpression"
        '
        'mnuStripCommand
        '
        Me.mnuStripCommand.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuStripCommand.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemCut, Me.mnuItemCopy, Me.mnuItemPaste, Me.mnuItemUndo, Me.SelectAllToolStripMenuItem})
        Me.mnuStripCommand.Name = "mnuStripCommand"
        Me.mnuStripCommand.Size = New System.Drawing.Size(165, 114)
        '
        'mnuItemCut
        '
        Me.mnuItemCut.Name = "mnuItemCut"
        Me.mnuItemCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuItemCut.Size = New System.Drawing.Size(164, 22)
        Me.mnuItemCut.Text = "Cut"
        '
        'mnuItemCopy
        '
        Me.mnuItemCopy.Name = "mnuItemCopy"
        Me.mnuItemCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuItemCopy.Size = New System.Drawing.Size(164, 22)
        Me.mnuItemCopy.Text = "Copy"
        '
        'mnuItemPaste
        '
        Me.mnuItemPaste.Name = "mnuItemPaste"
        Me.mnuItemPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuItemPaste.Size = New System.Drawing.Size(164, 22)
        Me.mnuItemPaste.Text = "Paste"
        '
        'mnuItemUndo
        '
        Me.mnuItemUndo.Name = "mnuItemUndo"
        Me.mnuItemUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.mnuItemUndo.Size = New System.Drawing.Size(164, 22)
        Me.mnuItemUndo.Text = "Undo"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'lblCommand
        '
        Me.lblCommand.AutoSize = True
        Me.lblCommand.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCommand.Location = New System.Drawing.Point(19, 59)
        Me.lblCommand.Name = "lblCommand"
        Me.lblCommand.Size = New System.Drawing.Size(57, 13)
        Me.lblCommand.TabIndex = 5
        Me.lblCommand.Text = "Command:"
        '
        'btnExample
        '
        Me.btnExample.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExample.Location = New System.Drawing.Point(96, 55)
        Me.btnExample.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExample.Name = "btnExample"
        Me.btnExample.Size = New System.Drawing.Size(166, 22)
        Me.btnExample.TabIndex = 6
        Me.btnExample.Text = "Command Examples"
        Me.btnExample.UseVisualStyleBackColor = True
        '
        'dataTypeGridView
        '
        Me.dataTypeGridView.AllowUserToAddRows = False
        Me.dataTypeGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataTypeGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dataTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataTypeGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.colNames, Me.cbType, Me.colDefault, Me.colLevels, Me.colLabel})
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataTypeGridView.DefaultCellStyle = DataGridViewCellStyle17
        Me.dataTypeGridView.Location = New System.Drawing.Point(20, 133)
        Me.dataTypeGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.dataTypeGridView.Name = "dataTypeGridView"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataTypeGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dataTypeGridView.RowHeadersVisible = False
        Me.dataTypeGridView.RowTemplate.Height = 28
        Me.dataTypeGridView.Size = New System.Drawing.Size(416, 115)
        Me.dataTypeGridView.TabIndex = 163
        '
        'no
        '
        Me.no.FillWeight = 90.0!
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 30
        '
        'colNames
        '
        Me.colNames.HeaderText = "Name"
        Me.colNames.Name = "colNames"
        Me.colNames.Width = 60
        '
        'cbType
        '
        Me.cbType.HeaderText = "Type"
        Me.cbType.Items.AddRange(New Object() {"Character", "Numeric", "Factor", "Integer"})
        Me.cbType.MaxDropDownItems = 4
        Me.cbType.Name = "cbType"
        Me.cbType.Width = 60
        '
        'colDefault
        '
        Me.colDefault.HeaderText = "Default"
        Me.colDefault.Items.AddRange(New Object() {"NA", "0", "1", "1,1000"})
        Me.colDefault.Name = "colDefault"
        '
        'colLevels
        '
        Me.colLevels.HeaderText = "Levels"
        Me.colLevels.Items.AddRange(New Object() {"No, Yes", "Bad, Poor, Average, Good, Great", "0-4,5-9,10-14,15-19, 20-64, 65+", "1:5"})
        Me.colLevels.Name = "colLevels"
        '
        'colLabel
        '
        Me.colLabel.HeaderText = "Label"
        Me.colLabel.Name = "colLabel"
        Me.colLabel.Visible = False
        Me.colLabel.Width = 80
        '
        'rdoLists
        '
        Me.rdoLists.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoLists.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLists.FlatAppearance.BorderSize = 2
        Me.rdoLists.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLists.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoLists.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLists.Location = New System.Drawing.Point(119, 15)
        Me.rdoLists.Name = "rdoLists"
        Me.rdoLists.Size = New System.Drawing.Size(74, 27)
        Me.rdoLists.TabIndex = 165
        Me.rdoLists.TabStop = True
        Me.rdoLists.Text = "Lists"
        Me.rdoLists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoLists.UseVisualStyleBackColor = True
        '
        'lblCategories
        '
        Me.lblCategories.AutoSize = True
        Me.lblCategories.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCategories.Location = New System.Drawing.Point(19, 59)
        Me.lblCategories.Name = "lblCategories"
        Me.lblCategories.Size = New System.Drawing.Size(52, 13)
        Me.lblCategories.TabIndex = 169
        Me.lblCategories.Text = "Category:"
        '
        'lblLists
        '
        Me.lblLists.AutoSize = True
        Me.lblLists.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLists.Location = New System.Drawing.Point(40, 87)
        Me.lblLists.Name = "lblLists"
        Me.lblLists.Size = New System.Drawing.Size(31, 13)
        Me.lblLists.TabIndex = 174
        Me.lblLists.Text = "Lists:"
        '
        'ucrNudCols
        '
        Me.ucrNudCols.AutoSize = True
        Me.ucrNudCols.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCols.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCols.Location = New System.Drawing.Point(101, 56)
        Me.ucrNudCols.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudCols.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCols.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCols.Name = "ucrNudCols"
        Me.ucrNudCols.Size = New System.Drawing.Size(55, 20)
        Me.ucrNudCols.TabIndex = 11
        Me.ucrNudCols.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkRCommand
        '
        Me.ucrChkRCommand.AutoSize = True
        Me.ucrChkRCommand.Checked = False
        Me.ucrChkRCommand.Location = New System.Drawing.Point(19, 114)
        Me.ucrChkRCommand.Name = "ucrChkRCommand"
        Me.ucrChkRCommand.Size = New System.Drawing.Size(177, 23)
        Me.ucrChkRCommand.TabIndex = 175
        '
        'ucrInputListInCategory
        '
        Me.ucrInputListInCategory.AddQuotesIfUnrecognised = True
        Me.ucrInputListInCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputListInCategory.GetSetSelectedIndex = -1
        Me.ucrInputListInCategory.IsReadOnly = False
        Me.ucrInputListInCategory.Location = New System.Drawing.Point(86, 84)
        Me.ucrInputListInCategory.Name = "ucrInputListInCategory"
        Me.ucrInputListInCategory.Size = New System.Drawing.Size(166, 26)
        Me.ucrInputListInCategory.TabIndex = 173
        '
        'ucrInputCategory
        '
        Me.ucrInputCategory.AddQuotesIfUnrecognised = True
        Me.ucrInputCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCategory.GetSetSelectedIndex = -1
        Me.ucrInputCategory.IsReadOnly = False
        Me.ucrInputCategory.Location = New System.Drawing.Point(86, 52)
        Me.ucrInputCategory.Name = "ucrInputCategory"
        Me.ucrInputCategory.Size = New System.Drawing.Size(166, 26)
        Me.ucrInputCategory.TabIndex = 172
        '
        'ucrInputLists
        '
        Me.ucrInputLists.AddQuotesIfUnrecognised = True
        Me.ucrInputLists.AutoSize = True
        Me.ucrInputLists.IsMultiline = True
        Me.ucrInputLists.IsReadOnly = False
        Me.ucrInputLists.Location = New System.Drawing.Point(21, 143)
        Me.ucrInputLists.Name = "ucrInputLists"
        Me.ucrInputLists.Size = New System.Drawing.Size(415, 31)
        Me.ucrInputLists.TabIndex = 171
        '
        'ucrChkIncludeLabel
        '
        Me.ucrChkIncludeLabel.AutoSize = True
        Me.ucrChkIncludeLabel.Checked = False
        Me.ucrChkIncludeLabel.Location = New System.Drawing.Point(194, 101)
        Me.ucrChkIncludeLabel.Name = "ucrChkIncludeLabel"
        Me.ucrChkIncludeLabel.Size = New System.Drawing.Size(160, 23)
        Me.ucrChkIncludeLabel.TabIndex = 164
        '
        'ucrChkVariable
        '
        Me.ucrChkVariable.AutoSize = True
        Me.ucrChkVariable.Checked = False
        Me.ucrChkVariable.Location = New System.Drawing.Point(37, 101)
        Me.ucrChkVariable.Name = "ucrChkVariable"
        Me.ucrChkVariable.Size = New System.Drawing.Size(138, 27)
        Me.ucrChkVariable.TabIndex = 162
        '
        'ucrTryNewDataFrame
        '
        Me.ucrTryNewDataFrame.AutoSize = True
        Me.ucrTryNewDataFrame.Location = New System.Drawing.Point(10, 253)
        Me.ucrTryNewDataFrame.Name = "ucrTryNewDataFrame"
        Me.ucrTryNewDataFrame.RunCommandAsMultipleLines = False
        Me.ucrTryNewDataFrame.Size = New System.Drawing.Size(404, 33)
        Me.ucrTryNewDataFrame.TabIndex = 161
        '
        'ucrInputCommand
        '
        Me.ucrInputCommand.AddQuotesIfUnrecognised = True
        Me.ucrInputCommand.AutoSize = True
        Me.ucrInputCommand.IsMultiline = True
        Me.ucrInputCommand.IsReadOnly = False
        Me.ucrInputCommand.Location = New System.Drawing.Point(19, 81)
        Me.ucrInputCommand.Name = "ucrInputCommand"
        Me.ucrInputCommand.Size = New System.Drawing.Size(417, 159)
        Me.ucrInputCommand.TabIndex = 7
        '
        'ucrPnlDataFrame
        '
        Me.ucrPnlDataFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDataFrame.Location = New System.Drawing.Point(17, 10)
        Me.ucrPnlDataFrame.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrPnlDataFrame.Name = "ucrPnlDataFrame"
        Me.ucrPnlDataFrame.Size = New System.Drawing.Size(433, 43)
        Me.ucrPnlDataFrame.TabIndex = 0
        '
        'ucrNewDFName
        '
        Me.ucrNewDFName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrNewDFName.Location = New System.Drawing.Point(20, 290)
        Me.ucrNewDFName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNewDFName.Name = "ucrNewDFName"
        Me.ucrNewDFName.Size = New System.Drawing.Size(416, 24)
        Me.ucrNewDFName.TabIndex = 14
        '
        'ucrNudRows
        '
        Me.ucrNudRows.AutoSize = True
        Me.ucrNudRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRows.Location = New System.Drawing.Point(323, 56)
        Me.ucrNudRows.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRows.Name = "ucrNudRows"
        Me.ucrNudRows.Size = New System.Drawing.Size(57, 20)
        Me.ucrNudRows.TabIndex = 9
        Me.ucrNudRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(20, 318)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 15
        '
        'dlgNewDataFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(458, 378)
        Me.Controls.Add(Me.ucrNudCols)
        Me.Controls.Add(Me.dataTypeGridView)
        Me.Controls.Add(Me.ucrChkRCommand)
        Me.Controls.Add(Me.lblLists)
        Me.Controls.Add(Me.ucrInputListInCategory)
        Me.Controls.Add(Me.ucrInputCategory)
        Me.Controls.Add(Me.ucrInputLists)
        Me.Controls.Add(Me.lblCategories)
        Me.Controls.Add(Me.rdoLists)
        Me.Controls.Add(Me.ucrChkIncludeLabel)
        Me.Controls.Add(Me.ucrChkVariable)
        Me.Controls.Add(Me.ucrTryNewDataFrame)
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
        Me.Controls.Add(Me.ucrNudRows)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.lblRows)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgNewDataFrame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Data Frame"
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuStripCommand.ResumeLayout(False)
        CType(Me.dataTypeGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ucrTryNewDataFrame As ucrTry
    Friend WithEvents ucrChkVariable As ucrCheck
    Friend WithEvents dataTypeGridView As DataGridView
    Friend WithEvents ucrChkIncludeLabel As ucrCheck
    Friend WithEvents rdoLists As RadioButton
    Friend WithEvents lblCategories As Label
    Friend WithEvents ucrInputLists As ucrInputTextBox
    Friend WithEvents ucrInputCategory As ucrInputComboBox
    Friend WithEvents ucrInputListInCategory As ucrInputComboBox
    Friend WithEvents lblLists As Label
    Friend WithEvents ucrChkRCommand As ucrCheck
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents colNames As DataGridViewTextBoxColumn
    Friend WithEvents cbType As DataGridViewComboBoxColumn
    Friend WithEvents colDefault As DataGridViewComboBoxColumn
    Friend WithEvents colLevels As DataGridViewComboBoxColumn
    Friend WithEvents colLabel As DataGridViewTextBoxColumn
End Class
