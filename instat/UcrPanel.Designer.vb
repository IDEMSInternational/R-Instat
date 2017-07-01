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
Partial Class UcrPanel
    Inherits instat.ucrCore

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlRadios = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'pnlRadios
        '
        Me.pnlRadios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRadios.Location = New System.Drawing.Point(0, 0)
        Me.pnlRadios.Name = "pnlRadios"
        Me.pnlRadios.Size = New System.Drawing.Size(187, 106)
        Me.pnlRadios.TabIndex = 0
        '
        'UcrPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.pnlRadios)
        Me.Name = "UcrPanel"
        Me.Size = New System.Drawing.Size(187, 106)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlRadios As Panel
End Class
