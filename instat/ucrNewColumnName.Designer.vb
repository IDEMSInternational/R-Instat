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
Partial Class ucrNewColumnName
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
        Me.lblColumnName = New System.Windows.Forms.Label()
        Me.cboColumnName = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblColumnName
        '
        Me.lblColumnName.AutoSize = True
        Me.lblColumnName.Location = New System.Drawing.Point(3, 10)
        Me.lblColumnName.Name = "lblColumnName"
        Me.lblColumnName.Size = New System.Drawing.Size(101, 13)
        Me.lblColumnName.TabIndex = 0
        Me.lblColumnName.Tag = "new_column_name:"
        Me.lblColumnName.Text = "New Column Name:"
        '
        'cboColumnName
        '
        Me.cboColumnName.FormattingEnabled = True
        Me.cboColumnName.Location = New System.Drawing.Point(107, 7)
        Me.cboColumnName.Name = "cboColumnName"
        Me.cboColumnName.Size = New System.Drawing.Size(257, 21)
        Me.cboColumnName.TabIndex = 1
        '
        'ucrNewColumnName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cboColumnName)
        Me.Controls.Add(Me.lblColumnName)
        Me.Name = "ucrNewColumnName"
        Me.Size = New System.Drawing.Size(367, 35)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblColumnName As Label
    Friend WithEvents cboColumnName As ComboBox
End Class
