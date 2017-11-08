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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrLog))
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.mnuContextLogFile = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuOpenLogFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.tlpTableContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.mnuContextLogFile.SuspendLayout()
        Me.tlpTableContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLog
        '
        Me.txtLog.ContextMenuStrip = Me.mnuContextLogFile
        resources.ApplyResources(Me.txtLog, "txtLog")
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.TabStop = False
        '
        'mnuContextLogFile
        '
        Me.mnuContextLogFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpenLogFile, Me.mnuCopy})
        Me.mnuContextLogFile.Name = "mnuContextLogFile"
        resources.ApplyResources(Me.mnuContextLogFile, "mnuContextLogFile")
        '
        'mnuOpenLogFile
        '
        Me.mnuOpenLogFile.Name = "mnuOpenLogFile"
        resources.ApplyResources(Me.mnuOpenLogFile, "mnuOpenLogFile")
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        resources.ApplyResources(Me.mnuCopy, "mnuCopy")
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(190, Byte), Integer))
        resources.ApplyResources(Me.lblHeader, "lblHeader")
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHeader.Name = "lblHeader"
        '
        'tlpTableContainer
        '
        resources.ApplyResources(Me.tlpTableContainer, "tlpTableContainer")
        Me.tlpTableContainer.Controls.Add(Me.lblHeader, 0, 0)
        Me.tlpTableContainer.Controls.Add(Me.txtLog, 0, 1)
        Me.tlpTableContainer.Name = "tlpTableContainer"
        '
        'ucrLog
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpTableContainer)
        Me.Name = "ucrLog"
        Me.mnuContextLogFile.ResumeLayout(False)
        Me.tlpTableContainer.ResumeLayout(False)
        Me.tlpTableContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtLog As TextBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents mnuContextLogFile As ContextMenuStrip
    Friend WithEvents mnuOpenLogFile As ToolStripMenuItem
    Friend WithEvents mnuCopy As ToolStripMenuItem
    Friend WithEvents tlpTableContainer As TableLayoutPanel
End Class