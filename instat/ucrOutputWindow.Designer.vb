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
Partial Class ucrOutputWindow
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
        Me.mnuContextRTB = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyRTB = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyImageRTB = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.deleteRTB = New System.Windows.Forms.ToolStripMenuItem()
        Me.clearRTB = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.tlpTableContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.ucrWPFrtfElementHost = New System.Windows.Forms.Integration.ElementHost()
        Me.ucrRichTextBox = New instat.ucrWPFRichTextBox()
        Me.mnuHideCommands = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuContextRTB.SuspendLayout()
        Me.tlpTableContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuContextRTB
        '
        Me.mnuContextRTB.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuContextRTB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyRTB, Me.CopyImageRTB, Me.mnuHideCommands, Me.ToolStripSeparator1, Me.deleteRTB, Me.clearRTB})
        Me.mnuContextRTB.Name = "mnuContextRTB"
        Me.mnuContextRTB.Size = New System.Drawing.Size(278, 193)
        '
        'CopyRTB
        '
        Me.CopyRTB.Name = "CopyRTB"
        Me.CopyRTB.Size = New System.Drawing.Size(277, 30)
        Me.CopyRTB.Text = "Copy RichText"
        '
        'CopyImageRTB
        '
        Me.CopyImageRTB.Enabled = False
        Me.CopyImageRTB.Name = "CopyImageRTB"
        Me.CopyImageRTB.Size = New System.Drawing.Size(277, 30)
        Me.CopyImageRTB.Text = "Copy Image"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(274, 6)
        '
        'deleteRTB
        '
        Me.deleteRTB.Name = "deleteRTB"
        Me.deleteRTB.Size = New System.Drawing.Size(277, 30)
        Me.deleteRTB.Text = "Delete Selected"
        '
        'clearRTB
        '
        Me.clearRTB.Name = "clearRTB"
        Me.clearRTB.Size = New System.Drawing.Size(277, 30)
        Me.clearRTB.Text = "Clear"
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
        Me.lblHeader.Size = New System.Drawing.Size(1075, 31)
        Me.lblHeader.TabIndex = 6
        Me.lblHeader.Text = "Output Window"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpTableContainer
        '
        Me.tlpTableContainer.ColumnCount = 1
        Me.tlpTableContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.Controls.Add(Me.ucrWPFrtfElementHost, 0, 1)
        Me.tlpTableContainer.Controls.Add(Me.lblHeader, 0, 0)
        Me.tlpTableContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTableContainer.Location = New System.Drawing.Point(0, 0)
        Me.tlpTableContainer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tlpTableContainer.Name = "tlpTableContainer"
        Me.tlpTableContainer.RowCount = 2
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.Size = New System.Drawing.Size(1083, 403)
        Me.tlpTableContainer.TabIndex = 7
        '
        'ucrWPFrtfElementHost
        '
        Me.ucrWPFrtfElementHost.ContextMenuStrip = Me.mnuContextRTB
        Me.ucrWPFrtfElementHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrWPFrtfElementHost.Location = New System.Drawing.Point(4, 36)
        Me.ucrWPFrtfElementHost.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrWPFrtfElementHost.Name = "ucrWPFrtfElementHost"
        Me.ucrWPFrtfElementHost.Size = New System.Drawing.Size(1075, 362)
        Me.ucrWPFrtfElementHost.TabIndex = 0
        Me.ucrWPFrtfElementHost.Text = "ucrWPFrtfElementHost"
        Me.ucrWPFrtfElementHost.Child = Me.ucrRichTextBox
        '
        'mnuHideCommands
        '
        Me.mnuHideCommands.Name = "mnuHideCommands"
        Me.mnuHideCommands.Size = New System.Drawing.Size(277, 30)
        Me.mnuHideCommands.Text = "Hide (future) commands"
        '
        'ucrOutputWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpTableContainer)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ucrOutputWindow"
        Me.Size = New System.Drawing.Size(1083, 403)
        Me.mnuContextRTB.ResumeLayout(False)
        Me.tlpTableContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrWPFrtfElementHost As Integration.ElementHost
    Friend ucrRichTextBox As ucrWPFRichTextBox
    Friend WithEvents mnuContextRTB As ContextMenuStrip
    Friend WithEvents CopyRTB As ToolStripMenuItem
    Friend WithEvents CopyImageRTB As ToolStripMenuItem
    Friend WithEvents lblHeader As Label
    Friend WithEvents tlpTableContainer As TableLayoutPanel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents clearRTB As ToolStripMenuItem
    Friend WithEvents deleteRTB As ToolStripMenuItem
    Friend WithEvents mnuHideCommands As ToolStripMenuItem
End Class
