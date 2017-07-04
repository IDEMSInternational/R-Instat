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
        Me.mnuOpenLogFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuContextLogFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLog
        '
        Me.txtLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLog.ContextMenuStrip = Me.mnuContextLogFile
        Me.txtLog.Location = New System.Drawing.Point(0, 20)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLog.Size = New System.Drawing.Size(531, 395)
        Me.txtLog.TabIndex = 0
        Me.txtLog.TabStop = False
        '
        'mnuContextLogFile
        '
        Me.mnuContextLogFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpenLogFile, Me.mnuCopy})
        Me.mnuContextLogFile.Name = "mnuContextLogFile"
        Me.mnuContextLogFile.Size = New System.Drawing.Size(153, 70)
        '
        'mnuOpenLogFile
        '
        Me.mnuOpenLogFile.Name = "mnuOpenLogFile"
        Me.mnuOpenLogFile.Size = New System.Drawing.Size(152, 22)
        Me.mnuOpenLogFile.Text = "Open Log File"
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(531, 20)
        Me.lblHeader.TabIndex = 8
        Me.lblHeader.Text = "Log"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.Size = New System.Drawing.Size(152, 22)
        Me.mnuCopy.Text = "Copy"
        '
        'ucrLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.txtLog)
        Me.Name = "ucrLog"
        Me.Size = New System.Drawing.Size(531, 415)
        Me.mnuContextLogFile.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLog As TextBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents mnuContextLogFile As ContextMenuStrip
    Friend WithEvents mnuOpenLogFile As ToolStripMenuItem
    Friend WithEvents mnuCopy As ToolStripMenuItem
End Class