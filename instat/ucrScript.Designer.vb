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
        Me.mnuRunCurrentStatementSelection = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRunAllText = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuOpenScriptasFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLoadScriptFromFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveScript = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHeaderScript = New System.Windows.Forms.Label()
        Me.tlpTableContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdLoadScript = New System.Windows.Forms.Button()
        Me.cmdRemoveTab = New System.Windows.Forms.Button()
        Me.cmdAddTab = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdRunAll = New System.Windows.Forms.Button()
        Me.cmdRunStatementSelection = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.toolTipScriptWindow = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuContextScript.SuspendLayout()
        Me.tlpTableContainer.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuContextScript
        '
        Me.mnuContextScript.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuContextScript.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUndo, Me.mnuRedo, Me.ToolStripSeparator1, Me.mnuCut, Me.mnuCopy, Me.mnuPaste, Me.mnuSelectAll, Me.mnuClear, Me.ToolStripSeparator2, Me.mnuRunCurrentStatementSelection, Me.mnuRunAllText, Me.ToolStripSeparator3, Me.mnuOpenScriptasFile, Me.mnuLoadScriptFromFile, Me.mnuSaveScript, Me.ToolStripSeparator4, Me.mnuHelp})
        Me.mnuContextScript.Name = "mnuContextLogFile"
        Me.mnuContextScript.Size = New System.Drawing.Size(306, 314)
        '
        'mnuUndo
        '
        Me.mnuUndo.Name = "mnuUndo"
        Me.mnuUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.mnuUndo.Size = New System.Drawing.Size(305, 22)
        Me.mnuUndo.Text = "Undo"
        '
        'mnuRedo
        '
        Me.mnuRedo.Name = "mnuRedo"
        Me.mnuRedo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.mnuRedo.Size = New System.Drawing.Size(305, 22)
        Me.mnuRedo.Text = "Redo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(302, 6)
        '
        'mnuCut
        '
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuCut.Size = New System.Drawing.Size(305, 22)
        Me.mnuCut.Text = "Cut"
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopy.Size = New System.Drawing.Size(305, 22)
        Me.mnuCopy.Text = "Copy"
        '
        'mnuPaste
        '
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuPaste.Size = New System.Drawing.Size(305, 22)
        Me.mnuPaste.Text = "Paste"
        '
        'mnuSelectAll
        '
        Me.mnuSelectAll.Name = "mnuSelectAll"
        Me.mnuSelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuSelectAll.Size = New System.Drawing.Size(305, 22)
        Me.mnuSelectAll.Text = "Select All"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.mnuClear.Size = New System.Drawing.Size(305, 22)
        Me.mnuClear.Text = "Clear All"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(302, 6)
        '
        'mnuRunCurrentStatementSelection
        '
        Me.mnuRunCurrentStatementSelection.Name = "mnuRunCurrentStatementSelection"
        Me.mnuRunCurrentStatementSelection.Size = New System.Drawing.Size(305, 22)
        Me.mnuRunCurrentStatementSelection.Text = "Run Current Statement/Selection Ctrl+Enter"
        '
        'mnuRunAllText
        '
        Me.mnuRunAllText.Name = "mnuRunAllText"
        Me.mnuRunAllText.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuRunAllText.Size = New System.Drawing.Size(305, 22)
        Me.mnuRunAllText.Text = "Run All Text"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(302, 6)
        '
        'mnuOpenScriptasFile
        '
        Me.mnuOpenScriptasFile.Name = "mnuOpenScriptasFile"
        Me.mnuOpenScriptasFile.Size = New System.Drawing.Size(305, 22)
        Me.mnuOpenScriptasFile.Text = "Open Script as File"
        '
        'mnuLoadScriptFromFile
        '
        Me.mnuLoadScriptFromFile.Name = "mnuLoadScriptFromFile"
        Me.mnuLoadScriptFromFile.Size = New System.Drawing.Size(305, 22)
        Me.mnuLoadScriptFromFile.Text = "Load Script from File..."
        '
        'mnuSaveScript
        '
        Me.mnuSaveScript.Name = "mnuSaveScript"
        Me.mnuSaveScript.Size = New System.Drawing.Size(305, 22)
        Me.mnuSaveScript.Text = "Save Script..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(302, 6)
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(305, 22)
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
        Me.Panel.Controls.Add(Me.cmdSave)
        Me.Panel.Controls.Add(Me.cmdLoadScript)
        Me.Panel.Controls.Add(Me.cmdRemoveTab)
        Me.Panel.Controls.Add(Me.cmdAddTab)
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
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(186, 1)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(55, 23)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdLoadScript
        '
        Me.cmdLoadScript.Location = New System.Drawing.Point(129, 1)
        Me.cmdLoadScript.Name = "cmdLoadScript"
        Me.cmdLoadScript.Size = New System.Drawing.Size(55, 23)
        Me.cmdLoadScript.TabIndex = 2
        Me.cmdLoadScript.Text = "Load"
        Me.cmdLoadScript.UseVisualStyleBackColor = True
        '
        'cmdRemoveTab
        '
        Me.cmdRemoveTab.Location = New System.Drawing.Point(334, 1)
        Me.cmdRemoveTab.Name = "cmdRemoveTab"
        Me.cmdRemoveTab.Size = New System.Drawing.Size(75, 23)
        Me.cmdRemoveTab.TabIndex = 5
        Me.cmdRemoveTab.Text = "Remove"
        Me.cmdRemoveTab.UseVisualStyleBackColor = True
        '
        'cmdAddTab
        '
        Me.cmdAddTab.Location = New System.Drawing.Point(257, 1)
        Me.cmdAddTab.Name = "cmdAddTab"
        Me.cmdAddTab.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddTab.TabIndex = 4
        Me.cmdAddTab.Text = "New"
        Me.cmdAddTab.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(502, 1)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(55, 23)
        Me.cmdHelp.TabIndex = 7
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(411, 1)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(80, 23)
        Me.cmdClear.TabIndex = 6
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdRunAll
        '
        Me.cmdRunAll.Location = New System.Drawing.Point(58, 1)
        Me.cmdRunAll.Name = "cmdRunAll"
        Me.cmdRunAll.Size = New System.Drawing.Size(55, 23)
        Me.cmdRunAll.TabIndex = 1
        Me.cmdRunAll.Text = "Run All"
        Me.cmdRunAll.UseVisualStyleBackColor = True
        '
        'cmdRunStatementSelection
        '
        Me.cmdRunStatementSelection.Location = New System.Drawing.Point(2, 1)
        Me.cmdRunStatementSelection.Name = "cmdRunStatementSelection"
        Me.cmdRunStatementSelection.Size = New System.Drawing.Size(55, 23)
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
    Friend WithEvents cmdAddTab As Button
    Friend WithEvents cmdRemoveTab As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdLoadScript As Button
End Class