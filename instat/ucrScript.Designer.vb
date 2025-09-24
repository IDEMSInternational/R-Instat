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
Partial Class ucrScript
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
        Me.mnuContextScript = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFindNext = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFindPrev = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReplace = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReplaceAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRunCurrentStatementSelection = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRunAllText = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuReformatCode = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuOpenScriptasFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLoadScriptFromFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveScript = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHeaderScript = New System.Windows.Forms.Label()
        Me.tlpTableContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.cmdInsert = New instat.ucrSplitButton()
        Me.contextMenuStriptInsert = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuItemInsertStatement = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemInsertCommentUncomment = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdLoadScript = New System.Windows.Forms.Button()
        Me.cmdRemoveTab = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdRunAll = New System.Windows.Forms.Button()
        Me.cmdRunStatementSelection = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.toolTipScriptWindow = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdAddTab = New instat.ucrSplitButton()
        Me.mnuNewTab = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuItemNewRScript = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemNewQuartoScript = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuContextScript.SuspendLayout()
        Me.tlpTableContainer.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.contextMenuStriptInsert.SuspendLayout()
        Me.mnuNewTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuContextScript
        '
        Me.mnuContextScript.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuContextScript.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUndo, Me.mnuRedo, Me.ToolStripSeparator1, Me.mnuCut, Me.mnuCopy, Me.mnuPaste, Me.mnuSelectAll, Me.mnuClear, Me.ToolStripSeparator2, Me.mnuFindNext, Me.mnuFindPrev, Me.mnuReplace, Me.mnuReplaceAll, Me.ToolStripSeparator6, Me.mnuRunCurrentStatementSelection, Me.mnuRunAllText, Me.ToolStripSeparator5, Me.mnuReformatCode, Me.ToolStripSeparator3, Me.mnuOpenScriptasFile, Me.mnuLoadScriptFromFile, Me.mnuSaveScript, Me.ToolStripSeparator4, Me.mnuHelp})
        Me.mnuContextScript.Name = "mnuContextLogFile"
        Me.mnuContextScript.Size = New System.Drawing.Size(249, 436)
        '
        'mnuUndo
        '
        Me.mnuUndo.Name = "mnuUndo"
        Me.mnuUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.mnuUndo.Size = New System.Drawing.Size(248, 22)
        Me.mnuUndo.Text = "Undo"
        '
        'mnuRedo
        '
        Me.mnuRedo.Name = "mnuRedo"
        Me.mnuRedo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.mnuRedo.Size = New System.Drawing.Size(248, 22)
        Me.mnuRedo.Text = "Redo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(245, 6)
        '
        'mnuCut
        '
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuCut.Size = New System.Drawing.Size(248, 22)
        Me.mnuCut.Text = "Cut"
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopy.Size = New System.Drawing.Size(248, 22)
        Me.mnuCopy.Text = "Copy"
        '
        'mnuPaste
        '
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuPaste.Size = New System.Drawing.Size(248, 22)
        Me.mnuPaste.Text = "Paste"
        '
        'mnuSelectAll
        '
        Me.mnuSelectAll.Name = "mnuSelectAll"
        Me.mnuSelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuSelectAll.Size = New System.Drawing.Size(248, 22)
        Me.mnuSelectAll.Text = "Select All"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.mnuClear.Size = New System.Drawing.Size(248, 22)
        Me.mnuClear.Text = "Clear All"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(245, 6)
        '
        'mnuFindNext
        '
        Me.mnuFindNext.Name = "mnuFindNext"
        Me.mnuFindNext.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuFindNext.Size = New System.Drawing.Size(248, 22)
        Me.mnuFindNext.Text = "Find Next"
        Me.mnuFindNext.ToolTipText = "Highlights the next occurrence of the selected text, and moves the cursor there"
        '
        'mnuFindPrev
        '
        Me.mnuFindPrev.Name = "mnuFindPrev"
        Me.mnuFindPrev.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuFindPrev.Size = New System.Drawing.Size(248, 22)
        Me.mnuFindPrev.Text = "Find Prev"
        Me.mnuFindPrev.ToolTipText = "Highlights the previous occurrence of the selected text, and moves the cursor the" &
    "re"
        '
        'mnuReplace
        '
        Me.mnuReplace.Name = "mnuReplace"
        Me.mnuReplace.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuReplace.Size = New System.Drawing.Size(248, 22)
        Me.mnuReplace.Text = "Replace"
        Me.mnuReplace.ToolTipText = "Replaces the next occurrence of the selected text with the contents of the clipbo" &
    "ard, and moves the cursor there"
        '
        'mnuReplaceAll
        '
        Me.mnuReplaceAll.Name = "mnuReplaceAll"
        Me.mnuReplaceAll.Size = New System.Drawing.Size(248, 22)
        Me.mnuReplaceAll.Text = "Replace All"
        Me.mnuReplaceAll.ToolTipText = "Replaces all occurrences of the selected text with the contents of the clipboard," &
    " and moves the cursor to the start of the script"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(245, 6)
        '
        'mnuRunCurrentStatementSelection
        '
        Me.mnuRunCurrentStatementSelection.Name = "mnuRunCurrentStatementSelection"
        Me.mnuRunCurrentStatementSelection.Size = New System.Drawing.Size(248, 22)
        Me.mnuRunCurrentStatementSelection.Text = "Run Current Statement/Selection"
        '
        'mnuRunAllText
        '
        Me.mnuRunAllText.Name = "mnuRunAllText"
        Me.mnuRunAllText.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuRunAllText.Size = New System.Drawing.Size(248, 22)
        Me.mnuRunAllText.Text = "Run All Text"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(245, 6)
        '
        'mnuReformatCode
        '
        Me.mnuReformatCode.Name = "mnuReformatCode"
        Me.mnuReformatCode.Size = New System.Drawing.Size(248, 22)
        Me.mnuReformatCode.Text = "Reformat Code"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(245, 6)
        '
        'mnuOpenScriptasFile
        '
        Me.mnuOpenScriptasFile.Name = "mnuOpenScriptasFile"
        Me.mnuOpenScriptasFile.Size = New System.Drawing.Size(248, 22)
        Me.mnuOpenScriptasFile.Text = "Open Script as File"
        '
        'mnuLoadScriptFromFile
        '
        Me.mnuLoadScriptFromFile.Name = "mnuLoadScriptFromFile"
        Me.mnuLoadScriptFromFile.Size = New System.Drawing.Size(248, 22)
        Me.mnuLoadScriptFromFile.Text = "Load from File..."
        '
        'mnuSaveScript
        '
        Me.mnuSaveScript.Name = "mnuSaveScript"
        Me.mnuSaveScript.Size = New System.Drawing.Size(248, 22)
        Me.mnuSaveScript.Text = "Save to File..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(245, 6)
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(248, 22)
        Me.mnuHelp.Text = "Help"
        '
        'lblHeaderScript
        '
        Me.lblHeaderScript.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblHeaderScript.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeaderScript.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblHeaderScript.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHeaderScript.Location = New System.Drawing.Point(3, 0)
        Me.lblHeaderScript.Name = "lblHeaderScript"
        Me.lblHeaderScript.Size = New System.Drawing.Size(664, 20)
        Me.lblHeaderScript.TabIndex = 0
        Me.lblHeaderScript.Text = "Script Window"
        Me.lblHeaderScript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpTableContainer
        '
        Me.tlpTableContainer.ColumnCount = 1
        Me.tlpTableContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.Controls.Add(Me.lblHeaderScript, 0, 0)
        Me.tlpTableContainer.Controls.Add(Me.Panel, 0, 1)
        Me.tlpTableContainer.Controls.Add(Me.TabControl, 0, 2)
        Me.tlpTableContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTableContainer.Location = New System.Drawing.Point(0, 0)
        Me.tlpTableContainer.Name = "tlpTableContainer"
        Me.tlpTableContainer.RowCount = 3
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 225.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpTableContainer.Size = New System.Drawing.Size(670, 500)
        Me.tlpTableContainer.TabIndex = 9
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.cmdAddTab)
        Me.Panel.Controls.Add(Me.cmdInsert)
        Me.Panel.Controls.Add(Me.cmdSave)
        Me.Panel.Controls.Add(Me.cmdLoadScript)
        Me.Panel.Controls.Add(Me.cmdRemoveTab)
        Me.Panel.Controls.Add(Me.cmdHelp)
        Me.Panel.Controls.Add(Me.cmdClear)
        Me.Panel.Controls.Add(Me.cmdRunAll)
        Me.Panel.Controls.Add(Me.cmdRunStatementSelection)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel.Location = New System.Drawing.Point(3, 23)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(664, 27)
        Me.Panel.TabIndex = 10
        '
        'cmdInsert
        '
        Me.cmdInsert.AutoSize = True
        Me.cmdInsert.ContextMenuStrip = Me.contextMenuStriptInsert
        Me.cmdInsert.Location = New System.Drawing.Point(353, 1)
        Me.cmdInsert.Name = "cmdInsert"
        Me.cmdInsert.Size = New System.Drawing.Size(71, 23)
        Me.cmdInsert.SplitMenuStrip = Me.contextMenuStriptInsert
        Me.cmdInsert.TabIndex = 11
        Me.cmdInsert.Tag = "Insert"
        Me.cmdInsert.Text = "Insert"
        Me.cmdInsert.UseVisualStyleBackColor = True
        '
        'contextMenuStriptInsert
        '
        Me.contextMenuStriptInsert.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.contextMenuStriptInsert.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemInsertStatement, Me.toolStripMenuItemInsertCommentUncomment})
        Me.contextMenuStriptInsert.Name = "contextMenuStripToScript"
        Me.contextMenuStriptInsert.Size = New System.Drawing.Size(201, 48)
        '
        'toolStripMenuItemInsertStatement
        '
        Me.toolStripMenuItemInsertStatement.Name = "toolStripMenuItemInsertStatement"
        Me.toolStripMenuItemInsertStatement.Size = New System.Drawing.Size(200, 22)
        Me.toolStripMenuItemInsertStatement.Text = "Statements"
        '
        'toolStripMenuItemInsertCommentUncomment
        '
        Me.toolStripMenuItemInsertCommentUncomment.Name = "toolStripMenuItemInsertCommentUncomment"
        Me.toolStripMenuItemInsertCommentUncomment.Size = New System.Drawing.Size(200, 22)
        Me.toolStripMenuItemInsertCommentUncomment.Text = "Comment/Uncomment"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(205, 1)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(66, 23)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdLoadScript
        '
        Me.cmdLoadScript.Location = New System.Drawing.Point(141, 1)
        Me.cmdLoadScript.Name = "cmdLoadScript"
        Me.cmdLoadScript.Size = New System.Drawing.Size(62, 23)
        Me.cmdLoadScript.TabIndex = 2
        Me.cmdLoadScript.Text = "Load"
        Me.cmdLoadScript.UseVisualStyleBackColor = True
        '
        'cmdRemoveTab
        '
        Me.cmdRemoveTab.Location = New System.Drawing.Point(427, 1)
        Me.cmdRemoveTab.Name = "cmdRemoveTab"
        Me.cmdRemoveTab.Size = New System.Drawing.Size(75, 23)
        Me.cmdRemoveTab.TabIndex = 5
        Me.cmdRemoveTab.Text = "Remove"
        Me.cmdRemoveTab.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(591, 1)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(55, 23)
        Me.cmdHelp.TabIndex = 7
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(505, 1)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(80, 23)
        Me.cmdClear.TabIndex = 6
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdRunAll
        '
        Me.cmdRunAll.Location = New System.Drawing.Point(67, 1)
        Me.cmdRunAll.Name = "cmdRunAll"
        Me.cmdRunAll.Size = New System.Drawing.Size(71, 23)
        Me.cmdRunAll.TabIndex = 1
        Me.cmdRunAll.Text = "Run All"
        Me.cmdRunAll.UseVisualStyleBackColor = True
        '
        'cmdRunStatementSelection
        '
        Me.cmdRunStatementSelection.Location = New System.Drawing.Point(2, 1)
        Me.cmdRunStatementSelection.Name = "cmdRunStatementSelection"
        Me.cmdRunStatementSelection.Size = New System.Drawing.Size(61, 23)
        Me.cmdRunStatementSelection.TabIndex = 0
        Me.cmdRunStatementSelection.Text = "Run"
        Me.cmdRunStatementSelection.UseVisualStyleBackColor = True
        '
        'TabControl
        '
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(3, 56)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(664, 441)
        Me.TabControl.TabIndex = 1
        '
        'cmdAddTab
        '
        Me.cmdAddTab.ContextMenuStrip = Me.mnuNewTab
        Me.cmdAddTab.Location = New System.Drawing.Point(274, 1)
        Me.cmdAddTab.Name = "cmdAddTab"
        Me.cmdAddTab.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddTab.SplitMenuStrip = Me.mnuNewTab
        Me.cmdAddTab.TabIndex = 4
        Me.cmdAddTab.Tag = ""
        Me.cmdAddTab.Text = "New"
        Me.cmdAddTab.UseVisualStyleBackColor = True
        '
        'mnuNewTab
        '
        Me.mnuNewTab.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemNewRScript, Me.toolStripMenuItemNewQuartoScript})
        Me.mnuNewTab.Name = "contextMenuStripToScript"
        Me.mnuNewTab.Size = New System.Drawing.Size(172, 48)
        '
        'toolStripMenuItemNewRScript
        '
        Me.toolStripMenuItemNewRScript.Name = "toolStripMenuItemNewRScript"
        Me.toolStripMenuItemNewRScript.Size = New System.Drawing.Size(171, 22)
        Me.toolStripMenuItemNewRScript.Text = "New R Script"
        '
        'toolStripMenuItemNewQuartoScript
        '
        Me.toolStripMenuItemNewQuartoScript.Name = "toolStripMenuItemNewQuartoScript"
        Me.toolStripMenuItemNewQuartoScript.Size = New System.Drawing.Size(171, 22)
        Me.toolStripMenuItemNewQuartoScript.Text = "New Quarto Script"
        '
        'ucrScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.Controls.Add(Me.tlpTableContainer)
        Me.Name = "ucrScript"
        Me.Size = New System.Drawing.Size(670, 500)
        Me.Tag = "Script_Window"
        Me.mnuContextScript.ResumeLayout(False)
        Me.tlpTableContainer.ResumeLayout(False)
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.contextMenuStriptInsert.ResumeLayout(False)
        Me.mnuNewTab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHeaderScript As Label
    Friend WithEvents tlpTableContainer As TableLayoutPanel
    Friend WithEvents mnuContextScript As ContextMenuStrip
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuOpenScriptasFile As ToolStripMenuItem
    Friend WithEvents mnuSaveScript As ToolStripMenuItem
    Friend WithEvents mnuLoadScriptFromFile As ToolStripMenuItem
    Friend WithEvents mnuCopy As ToolStripMenuItem
    Friend WithEvents mnuCut As ToolStripMenuItem
    Friend WithEvents mnuPaste As ToolStripMenuItem
    Friend WithEvents mnuRunAllText As ToolStripMenuItem
    Friend WithEvents mnuRunCurrentStatementSelection As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents Panel As Panel
    Friend WithEvents cmdRunAll As Button
    Friend WithEvents cmdRunStatementSelection As Button
    Friend WithEvents toolTipScriptWindow As ToolTip
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdHelp As Button
    Friend WithEvents mnuUndo As ToolStripMenuItem
    Friend WithEvents mnuRedo As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuSelectAll As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents TabControl As TabControl
    Friend WithEvents cmdRemoveTab As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdLoadScript As Button
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents mnuReformatCode As ToolStripMenuItem
    Friend WithEvents cmdInsert As ucrSplitButton
    Friend WithEvents contextMenuStriptInsert As ContextMenuStrip
    Friend WithEvents toolStripMenuItemInsertStatement As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemInsertCommentUncomment As ToolStripMenuItem
    Friend WithEvents mnuFindNext As ToolStripMenuItem
    Friend WithEvents mnuFindPrev As ToolStripMenuItem
    Friend WithEvents mnuReplace As ToolStripMenuItem
    Friend WithEvents mnuReplaceAll As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents cmdAddTab As ucrSplitButton
    Friend WithEvents mnuNewTab As ContextMenuStrip
    Friend WithEvents toolStripMenuItemNewRScript As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemNewQuartoScript As ToolStripMenuItem
End Class