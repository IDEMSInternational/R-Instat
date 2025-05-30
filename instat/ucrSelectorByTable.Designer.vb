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
Partial Class ucrSelectorByTable
    Inherits instat.ucrSelector

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
        Me.ucrAvailableTables = New instat.ucrTables()
        Me.SuspendLayout()
        '
        'lstAvailableVariable
        '
        Me.lstAvailableVariable.Dock = System.Windows.Forms.DockStyle.None
        Me.lstAvailableVariable.Location = New System.Drawing.Point(0, 140)
        Me.lstAvailableVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.lstAvailableVariable.TabIndex = 1
        '
        'ucrAvailableTables
        '
        Me.ucrAvailableTables.AutoSize = True
        Me.ucrAvailableTables.Location = New System.Drawing.Point(0, 0)
        Me.ucrAvailableTables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAvailableTables.Name = "ucrAvailableTables"
        Me.ucrAvailableTables.Size = New System.Drawing.Size(224, 131)
        Me.ucrAvailableTables.TabIndex = 0
        '
        'ucrSelectorByTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.ucrAvailableTables)
        Me.Name = "ucrSelectorByTable"
        Me.Size = New System.Drawing.Size(336, 364)
        Me.Controls.SetChildIndex(Me.lstAvailableVariable, 0)
        Me.Controls.SetChildIndex(Me.ucrAvailableTables, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents ucrAvailableTables As ucrTables
End Class
