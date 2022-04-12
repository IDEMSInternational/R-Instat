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
        Me.lblHeaderOutputWindow = New System.Windows.Forms.Label()
        Me.tlpTableContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.ucrOutputPages = New instat.ucrOutputPagess()
        Me.tlpTableContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeaderOutputWindow
        '
        Me.lblHeaderOutputWindow.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblHeaderOutputWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeaderOutputWindow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblHeaderOutputWindow.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHeaderOutputWindow.Location = New System.Drawing.Point(3, 0)
        Me.lblHeaderOutputWindow.Name = "lblHeaderOutputWindow"
        Me.lblHeaderOutputWindow.Size = New System.Drawing.Size(716, 20)
        Me.lblHeaderOutputWindow.TabIndex = 6
        Me.lblHeaderOutputWindow.Text = "Output Window"
        Me.lblHeaderOutputWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpTableContainer
        '
        Me.tlpTableContainer.BackColor = System.Drawing.Color.White
        Me.tlpTableContainer.ColumnCount = 1
        Me.tlpTableContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.Controls.Add(Me.lblHeaderOutputWindow, 0, 0)
        Me.tlpTableContainer.Controls.Add(Me.ucrOutputPages, 0, 1)
        Me.tlpTableContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTableContainer.Location = New System.Drawing.Point(0, 0)
        Me.tlpTableContainer.Name = "tlpTableContainer"
        Me.tlpTableContainer.RowCount = 2
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.Size = New System.Drawing.Size(722, 262)
        Me.tlpTableContainer.TabIndex = 7
        '
        'ucrOutputPages
        '
        Me.ucrOutputPages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrOutputPages.Location = New System.Drawing.Point(3, 23)
        Me.ucrOutputPages.Name = "ucrOutputPages"
        Me.ucrOutputPages.Size = New System.Drawing.Size(716, 236)
        Me.ucrOutputPages.TabIndex = 7
        '
        'ucrOutputWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.Controls.Add(Me.tlpTableContainer)
        Me.Name = "ucrOutputWindow"
        Me.Size = New System.Drawing.Size(722, 262)
        Me.tlpTableContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHeaderOutputWindow As Label
    Friend WithEvents tlpTableContainer As TableLayoutPanel
    Friend WithEvents ucrOutputPages As ucrOutputPagess
End Class
