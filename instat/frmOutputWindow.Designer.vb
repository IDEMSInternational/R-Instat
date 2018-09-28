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
Partial Class frmOutputWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ucrWPFrtfElementHost = New System.Windows.Forms.Integration.ElementHost()
        Me.ucrRichTextBox = New instat.ucrWPFRichTextBox()
        Me.mnuContextRTB = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyRTB = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyImageRTB = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuContextRTB.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrWPFrtfElementHost
        '
        Me.ucrWPFrtfElementHost.ContextMenuStrip = Me.mnuContextRTB
        Me.ucrWPFrtfElementHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrWPFrtfElementHost.Location = New System.Drawing.Point(0, 0)
        Me.ucrWPFrtfElementHost.Name = "ucrWPFrtfElementHost"
        Me.ucrWPFrtfElementHost.Size = New System.Drawing.Size(722, 262)
        Me.ucrWPFrtfElementHost.TabIndex = 0
        Me.ucrWPFrtfElementHost.Text = "ucrWPFrtfElementHost"
        Me.ucrWPFrtfElementHost.Child = Me.ucrRichTextBox
        '
        'mnuContextRTB
        '
        Me.mnuContextRTB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyRTB, Me.CopyImageRTB})
        Me.mnuContextRTB.Name = "mnuContextRTB"
        Me.mnuContextRTB.Size = New System.Drawing.Size(151, 48)
        '
        'CopyRTB
        '
        Me.CopyRTB.Name = "CopyRTB"
        Me.CopyRTB.Size = New System.Drawing.Size(150, 22)
        Me.CopyRTB.Text = "Copy RichText"
        '
        'CopyImageRTB
        '
        Me.CopyImageRTB.Enabled = False
        Me.CopyImageRTB.Name = "CopyImageRTB"
        Me.CopyImageRTB.Size = New System.Drawing.Size(150, 22)
        Me.CopyImageRTB.Text = "Copy Image"
        '
        'frmOutputWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 262)
        Me.Controls.Add(Me.ucrWPFrtfElementHost)
        Me.Name = "frmOutputWindow"
        Me.ShowIcon = False
        Me.Text = "Output Window"
        Me.mnuContextRTB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrWPFrtfElementHost As Integration.ElementHost
    Friend ucrRichTextBox As ucrWPFRichTextBox
    Friend WithEvents mnuContextRTB As ContextMenuStrip
    Friend WithEvents CopyRTB As ToolStripMenuItem
    Friend WithEvents CopyImageRTB As ToolStripMenuItem
End Class
