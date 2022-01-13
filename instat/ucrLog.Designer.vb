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
Partial Class ucrLog
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
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.mnuContextLogFile = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRunCurrentLine = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRunSelectedText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRunAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSaveLogFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenLogFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHeaderLog = New System.Windows.Forms.Label()
        Me.tlpTableContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.mnuContextLogFile.SuspendLayout()
        Me.tlpTableContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLog
        '
        Me.txtLog.ContextMenuStrip = Me.mnuContextLogFile
        Me.txtLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLog.Location = New System.Drawing.Point(3, 23)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLog.Size = New System.Drawing.Size(525, 389)
        Me.txtLog.TabIndex = 0
        Me.txtLog.TabStop = False
        Me.txtLog.WordWrap = False
        '
        'mnuContextLogFile
        '
        Me.mnuContextLogFile.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuContextLogFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopy, Me.ToolStripSeparator3, Me.mnuRunCurrentLine, Me.mnuRunSelectedText, Me.mnuRunAll, Me.ToolStripSeparator2, Me.mnuSaveLogFile, Me.mnuOpenLogFile, Me.ToolStripSeparator1, Me.mnuHelp})
        Me.mnuContextLogFile.Name = "mnuContextLogFile"
        Me.mnuContextLogFile.Size = New System.Drawing.Size(230, 176)
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopy.Size = New System.Drawing.Size(229, 22)
        Me.mnuCopy.Text = "Copy"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(226, 6)
        '
        'mnuRunCurrentLine
        '
        Me.mnuRunCurrentLine.Name = "mnuRunCurrentLine"
        Me.mnuRunCurrentLine.Size = New System.Drawing.Size(229, 22)
        Me.mnuRunCurrentLine.Text = "Run Current Line"
        '
        'mnuRunSelectedText
        '
        Me.mnuRunSelectedText.Name = "mnuRunSelectedText"
        Me.mnuRunSelectedText.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.mnuRunSelectedText.Size = New System.Drawing.Size(229, 22)
        Me.mnuRunSelectedText.Text = "Run Selected Text"
        '
        'mnuRunAll
        '
        Me.mnuRunAll.Name = "mnuRunAll"
        Me.mnuRunAll.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuRunAll.Size = New System.Drawing.Size(229, 22)
        Me.mnuRunAll.Text = "Run All"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(226, 6)
        '
        'mnuSaveLogFile
        '
        Me.mnuSaveLogFile.Name = "mnuSaveLogFile"
        Me.mnuSaveLogFile.Size = New System.Drawing.Size(229, 22)
        Me.mnuSaveLogFile.Text = "Save Log File..."
        '
        'mnuOpenLogFile
        '
        Me.mnuOpenLogFile.Name = "mnuOpenLogFile"
        Me.mnuOpenLogFile.Size = New System.Drawing.Size(229, 22)
        Me.mnuOpenLogFile.Text = "Open Log File"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(226, 6)
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(229, 22)
        Me.mnuHelp.Text = "Help"
        '
        'lblHeaderLog
        '
        Me.lblHeaderLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblHeaderLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeaderLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblHeaderLog.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHeaderLog.Location = New System.Drawing.Point(3, 0)
        Me.lblHeaderLog.Name = "lblHeaderLog"
        Me.lblHeaderLog.Size = New System.Drawing.Size(525, 20)
        Me.lblHeaderLog.TabIndex = 8
        Me.lblHeaderLog.Text = "Log Window"
        Me.lblHeaderLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpTableContainer
        '
        Me.tlpTableContainer.ColumnCount = 1
        Me.tlpTableContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.Controls.Add(Me.lblHeaderLog, 0, 0)
        Me.tlpTableContainer.Controls.Add(Me.txtLog, 0, 1)
        Me.tlpTableContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTableContainer.Location = New System.Drawing.Point(0, 0)
        Me.tlpTableContainer.Name = "tlpTableContainer"
        Me.tlpTableContainer.RowCount = 2
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.Size = New System.Drawing.Size(531, 415)
        Me.tlpTableContainer.TabIndex = 9
        '
        'ucrLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.Controls.Add(Me.tlpTableContainer)
        Me.Name = "ucrLog"
        Me.Size = New System.Drawing.Size(531, 415)
        Me.mnuContextLogFile.ResumeLayout(False)
        Me.tlpTableContainer.ResumeLayout(False)
        Me.tlpTableContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtLog As TextBox
    Friend WithEvents lblHeaderLog As Label
    Friend WithEvents mnuContextLogFile As ContextMenuStrip
    Friend WithEvents mnuOpenLogFile As ToolStripMenuItem
    Friend WithEvents mnuCopy As ToolStripMenuItem
    Friend WithEvents tlpTableContainer As TableLayoutPanel
    Friend WithEvents mnuRunSelectedText As ToolStripMenuItem
    Friend WithEvents mnuRunCurrentLine As ToolStripMenuItem
    Friend WithEvents mnuSaveLogFile As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents mnuRunAll As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class