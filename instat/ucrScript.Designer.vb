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
        Me.txtScript = New System.Windows.Forms.TextBox()
        Me.mnuContextScript = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuRunSelectedText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenScript = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenScriptFromFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveScript = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClearContents = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.tlpTableContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.mnuContextScript.SuspendLayout()
        Me.tlpTableContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtScript
        '
        Me.txtScript.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtScript.ContextMenuStrip = Me.mnuContextScript
        Me.txtScript.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtScript.Location = New System.Drawing.Point(3, 56)
        Me.txtScript.Multiline = True
        Me.txtScript.Name = "txtScript"
        Me.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtScript.Size = New System.Drawing.Size(405, 255)
        Me.txtScript.TabIndex = 0
        '
        'mnuContextScript
        '
        Me.mnuContextScript.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRunSelectedText, Me.mnuOpenScript, Me.mnuOpenScriptFromFile, Me.mnuSaveScript, Me.mnuClearContents})
        Me.mnuContextScript.Name = "mnuContextLogFile"
        Me.mnuContextScript.Size = New System.Drawing.Size(254, 136)
        '
        'mnuRunSelectedText
        '
        Me.mnuRunSelectedText.Name = "mnuRunSelectedText"
        Me.mnuRunSelectedText.Size = New System.Drawing.Size(253, 22)
        Me.mnuRunSelectedText.Text = "Run Selected Text"
        '
        'mnuOpenScript
        '
        Me.mnuOpenScript.Name = "mnuOpenScript"
        Me.mnuOpenScript.Size = New System.Drawing.Size(253, 22)
        Me.mnuOpenScript.Text = "Open Script in RStudio/Text Editor"
        '
        'mnuOpenScriptFromFile
        '
        Me.mnuOpenScriptFromFile.Name = "mnuOpenScriptFromFile"
        Me.mnuOpenScriptFromFile.Size = New System.Drawing.Size(253, 22)
        Me.mnuOpenScriptFromFile.Text = "Open Script From File..."
        '
        'mnuSaveScript
        '
        Me.mnuSaveScript.Name = "mnuSaveScript"
        Me.mnuSaveScript.Size = New System.Drawing.Size(253, 22)
        Me.mnuSaveScript.Text = "Save Script..."
        '
        'mnuClearContents
        '
        Me.mnuClearContents.Name = "mnuClearContents"
        Me.mnuClearContents.Size = New System.Drawing.Size(253, 22)
        Me.mnuClearContents.Text = "Clear Script"
        '
        'cmdRun
        '
        Me.cmdRun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdRun.Location = New System.Drawing.Point(3, 23)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(405, 27)
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
        Me.lblHeader.Location = New System.Drawing.Point(3, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(405, 20)
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
        Me.tlpTableContainer.Name = "tlpTableContainer"
        Me.tlpTableContainer.RowCount = 3
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpTableContainer.Size = New System.Drawing.Size(411, 314)
        Me.tlpTableContainer.TabIndex = 9
        '
        'ucrScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpTableContainer)
        Me.Name = "ucrScript"
        Me.Size = New System.Drawing.Size(411, 314)
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
    Friend WithEvents mnuOpenScript As ToolStripMenuItem
    Friend WithEvents mnuSaveScript As ToolStripMenuItem
    Friend WithEvents mnuOpenScriptFromFile As ToolStripMenuItem
End Class