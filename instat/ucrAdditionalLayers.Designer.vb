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
Partial Class ucrAdditionalLayers
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.lblLayers = New System.Windows.Forms.Label()
        Me.lstLayers = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(134, 121)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 6
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(134, 92)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 7
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(134, 63)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 8
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'lblLayers
        '
        Me.lblLayers.AutoSize = True
        Me.lblLayers.Location = New System.Drawing.Point(4, 13)
        Me.lblLayers.Name = "lblLayers"
        Me.lblLayers.Size = New System.Drawing.Size(41, 13)
        Me.lblLayers.TabIndex = 5
        Me.lblLayers.Text = "Layers:"
        '
        'lstLayers
        '
        Me.lstLayers.Location = New System.Drawing.Point(3, 28)
        Me.lstLayers.Name = "lstLayers"
        Me.lstLayers.Size = New System.Drawing.Size(125, 149)
        Me.lstLayers.TabIndex = 4
        Me.lstLayers.UseCompatibleStateImageBehavior = False
        Me.lstLayers.View = System.Windows.Forms.View.List
        Me.lstLayers.FullRowSelect = True
        '
        'ucrAdditionalLayers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lblLayers)
        Me.Controls.Add(Me.lstLayers)
        Me.Name = "ucrAdditionalLayers"
        Me.Size = New System.Drawing.Size(213, 180)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents lblLayers As Label
    Friend WithEvents lstLayers As ListView
End Class
