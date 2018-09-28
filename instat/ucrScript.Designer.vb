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
        Me.txtScript = New System.Windows.Forms.TextBox()
        Me.mnuContextScript = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.RToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRunCurrentLine = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRunSelectedText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRunAllText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenScriptasFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLoadScriptFromFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveScript = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClearContents = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.tlpTableContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuContextScript.SuspendLayout()
        Me.tlpTableContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtScript
        '
        Me.txtScript.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtScript.ContextMenuStrip = Me.mnuContextScript
        Me.txtScript.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtScript.Location = New System.Drawing.Point(4, 87)
        Me.txtScript.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtScript.Multiline = True
        Me.txtScript.Name = "txtScript"
        Me.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtScript.Size = New System.Drawing.Size(608, 391)
        Me.txtScript.TabIndex = 0
        Me.txtScript.WordWrap = False
        '
        'mnuContextScript
        '
        Me.mnuContextScript.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuContextScript.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCut, Me.mnuCopy, Me.mnuPaste, Me.mnuUndo, Me.RToolStripMenuItem, Me.mnuRunCurrentLine, Me.mnuRunSelectedText, Me.mnuRunAllText, Me.mnuOpenScriptasFile, Me.mnuLoadScriptFromFile, Me.mnuSaveScript, Me.mnuClearContents, Me.ToolStripSeparator1, Me.mnuHelp})
        Me.mnuContextScript.Name = "mnuContextLogFile"
        Me.mnuContextScript.Size = New System.Drawing.Size(316, 409)
        '
        'mnuCut
        '
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuCut.Size = New System.Drawing.Size(315, 30)
        Me.mnuCut.Text = "Cut"
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopy.Size = New System.Drawing.Size(315, 30)
        Me.mnuCopy.Text = "Copy"
        '
        'mnuPaste
        '
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuPaste.Size = New System.Drawing.Size(315, 30)
        Me.mnuPaste.Text = "Paste"
        '
        'mnuUndo
        '
        Me.mnuUndo.Name = "mnuUndo"
        Me.mnuUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.mnuUndo.Size = New System.Drawing.Size(315, 30)
        Me.mnuUndo.Text = "Undo"
        '
        'RToolStripMenuItem
        '
        Me.RToolStripMenuItem.Name = "RToolStripMenuItem"
        Me.RToolStripMenuItem.Size = New System.Drawing.Size(312, 6)
        '
        'mnuRunCurrentLine
        '
        Me.mnuRunCurrentLine.Name = "mnuRunCurrentLine"
        Me.mnuRunCurrentLine.Size = New System.Drawing.Size(315, 30)
        Me.mnuRunCurrentLine.Text = "Run Current Line"
        '
        'mnuRunSelectedText
        '
        Me.mnuRunSelectedText.Name = "mnuRunSelectedText"
        Me.mnuRunSelectedText.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.mnuRunSelectedText.Size = New System.Drawing.Size(315, 30)
        Me.mnuRunSelectedText.Text = "Run Selected Text"
        '
        'mnuRunAllText
        '
        Me.mnuRunAllText.Name = "mnuRunAllText"
        Me.mnuRunAllText.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuRunAllText.Size = New System.Drawing.Size(315, 30)
        Me.mnuRunAllText.Text = "Run All Text"
        '
        'mnuOpenScriptasFile
        '
        Me.mnuOpenScriptasFile.Name = "mnuOpenScriptasFile"
        Me.mnuOpenScriptasFile.Size = New System.Drawing.Size(315, 30)
        Me.mnuOpenScriptasFile.Text = "Open Script as File"
        '
        'mnuLoadScriptFromFile
        '
        Me.mnuLoadScriptFromFile.Name = "mnuLoadScriptFromFile"
        Me.mnuLoadScriptFromFile.Size = New System.Drawing.Size(315, 30)
        Me.mnuLoadScriptFromFile.Text = "Load Script from File..."
        '
        'mnuSaveScript
        '
        Me.mnuSaveScript.Name = "mnuSaveScript"
        Me.mnuSaveScript.Size = New System.Drawing.Size(315, 30)
        Me.mnuSaveScript.Text = "Save Script..."
        '
        'mnuClearContents
        '
        Me.mnuClearContents.Name = "mnuClearContents"
        Me.mnuClearContents.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.mnuClearContents.Size = New System.Drawing.Size(315, 30)
        Me.mnuClearContents.Text = "Clear Script"
        '
        'cmdRun
        '
        Me.cmdRun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdRun.Location = New System.Drawing.Point(4, 36)
        Me.cmdRun.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(608, 41)
        Me.cmdRun.TabIndex = 1
        Me.cmdRun.Text = "Run All"
        Me.cmdRun.UseVisualStyleBackColor = True
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHeader.Location = New System.Drawing.Point(4, 0)
        Me.lblHeader.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(608, 31)
        Me.lblHeader.TabIndex = 8
        Me.lblHeader.Text = "Script"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpTableContainer
        '
        Me.tlpTableContainer.ColumnCount = 1
        Me.tlpTableContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.Controls.Add(Me.lblHeader, 0, 0)
        Me.tlpTableContainer.Controls.Add(Me.txtScript, 0, 2)
        Me.tlpTableContainer.Controls.Add(Me.cmdRun, 0, 1)
        Me.tlpTableContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTableContainer.Location = New System.Drawing.Point(0, 0)
        Me.tlpTableContainer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tlpTableContainer.Name = "tlpTableContainer"
        Me.tlpTableContainer.RowCount = 3
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tlpTableContainer.Size = New System.Drawing.Size(616, 483)
        Me.tlpTableContainer.TabIndex = 9
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(315, 30)
        Me.mnuHelp.Text = "Help"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(312, 6)
        '
        'ucrScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpTableContainer)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ucrScript"
        Me.Size = New System.Drawing.Size(616, 483)
        Me.Tag = "Script_Window"
        Me.mnuContextScript.ResumeLayout(False)
        Me.tlpTableContainer.ResumeLayout(False)
        Me.tlpTableContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtScript As TextBox
    Friend WithEvents cmdRun As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents tlpTableContainer As TableLayoutPanel
    Friend WithEvents mnuContextScript As ContextMenuStrip
    Friend WithEvents mnuRunSelectedText As ToolStripMenuItem
    Friend WithEvents mnuClearContents As ToolStripMenuItem
    Friend WithEvents mnuOpenScriptasFile As ToolStripMenuItem
    Friend WithEvents mnuSaveScript As ToolStripMenuItem
    Friend WithEvents mnuLoadScriptFromFile As ToolStripMenuItem
    Friend WithEvents mnuCopy As ToolStripMenuItem
    Friend WithEvents mnuCut As ToolStripMenuItem
    Friend WithEvents mnuPaste As ToolStripMenuItem
    Friend WithEvents mnuUndo As ToolStripMenuItem
    Friend WithEvents RToolStripMenuItem As ToolStripSeparator
    Friend WithEvents mnuRunAllText As ToolStripMenuItem
    Friend WithEvents mnuRunCurrentLine As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuHelp As ToolStripMenuItem
End Class