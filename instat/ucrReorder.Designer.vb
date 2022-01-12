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
Partial Class ucrReorder
    Inherits instat.ucrCore

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
        Me.cmdTop = New System.Windows.Forms.Button()
        Me.cmdUp = New System.Windows.Forms.Button()
        Me.cmdDown = New System.Windows.Forms.Button()
        Me.cmdBottom = New System.Windows.Forms.Button()
        Me.lstAvailableData = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'cmdTop
        '
        Me.cmdTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdTop.Image = Global.instat.My.Resources.Resources.arrows_top
        Me.cmdTop.Location = New System.Drawing.Point(164, 47)
        Me.cmdTop.Name = "cmdTop"
        Me.cmdTop.Size = New System.Drawing.Size(32, 22)
        Me.cmdTop.TabIndex = 0
        Me.cmdTop.UseVisualStyleBackColor = True
        '
        'cmdUp
        '
        Me.cmdUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdUp.Image = Global.instat.My.Resources.Resources.arrows_up
        Me.cmdUp.Location = New System.Drawing.Point(164, 73)
        Me.cmdUp.Name = "cmdUp"
        Me.cmdUp.Size = New System.Drawing.Size(32, 22)
        Me.cmdUp.TabIndex = 1
        Me.cmdUp.UseVisualStyleBackColor = True
        '
        'cmdDown
        '
        Me.cmdDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdDown.Image = Global.instat.My.Resources.Resources.arrows_down
        Me.cmdDown.Location = New System.Drawing.Point(164, 99)
        Me.cmdDown.Name = "cmdDown"
        Me.cmdDown.Size = New System.Drawing.Size(32, 22)
        Me.cmdDown.TabIndex = 2
        Me.cmdDown.UseVisualStyleBackColor = True
        '
        'cmdBottom
        '
        Me.cmdBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdBottom.Image = Global.instat.My.Resources.Resources.arrows_bottom
        Me.cmdBottom.Location = New System.Drawing.Point(164, 125)
        Me.cmdBottom.Name = "cmdBottom"
        Me.cmdBottom.Size = New System.Drawing.Size(32, 22)
        Me.cmdBottom.TabIndex = 3
        Me.cmdBottom.UseVisualStyleBackColor = True
        '
        'lstAvailableData
        '
        Me.lstAvailableData.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstAvailableData.FullRowSelect = True
        Me.lstAvailableData.HideSelection = False
        Me.lstAvailableData.Location = New System.Drawing.Point(0, 0)
        Me.lstAvailableData.Name = "lstAvailableData"
        Me.lstAvailableData.Size = New System.Drawing.Size(154, 195)
        Me.lstAvailableData.TabIndex = 5
        Me.lstAvailableData.UseCompatibleStateImageBehavior = False
        Me.lstAvailableData.View = System.Windows.Forms.View.Details
        '
        'ucrReorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = False
        Me.Controls.Add(Me.lstAvailableData)
        Me.Controls.Add(Me.cmdBottom)
        Me.Controls.Add(Me.cmdDown)
        Me.Controls.Add(Me.cmdUp)
        Me.Controls.Add(Me.cmdTop)
        Me.Name = "ucrReorder"
        Me.Size = New System.Drawing.Size(209, 195)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdTop As Button
    Friend WithEvents cmdUp As Button
    Friend WithEvents cmdDown As Button
    Friend WithEvents cmdBottom As Button
    Friend WithEvents lstAvailableData As ListView
End Class
