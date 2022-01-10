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
Partial Class dlgCalculationsSummary
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.lblCalculations = New System.Windows.Forms.Label()
        Me.lstCalculations = New System.Windows.Forms.ListView()
        Me.cmdDuplicate = New System.Windows.Forms.Button()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(143, 114)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 11
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(143, 85)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 12
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(143, 56)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 13
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'lblCalculations
        '
        Me.lblCalculations.AutoSize = True
        Me.lblCalculations.Location = New System.Drawing.Point(13, 21)
        Me.lblCalculations.Name = "lblCalculations"
        Me.lblCalculations.Size = New System.Drawing.Size(67, 13)
        Me.lblCalculations.TabIndex = 10
        Me.lblCalculations.Text = "Calculations:"
        '
        'lstCalculations
        '
        Me.lstCalculations.FullRowSelect = True
        Me.lstCalculations.HideSelection = False
        Me.lstCalculations.Location = New System.Drawing.Point(12, 36)
        Me.lstCalculations.Name = "lstCalculations"
        Me.lstCalculations.Size = New System.Drawing.Size(125, 149)
        Me.lstCalculations.TabIndex = 9
        Me.lstCalculations.UseCompatibleStateImageBehavior = False
        Me.lstCalculations.View = System.Windows.Forms.View.List
        '
        'cmdDuplicate
        '
        Me.cmdDuplicate.Location = New System.Drawing.Point(143, 143)
        Me.cmdDuplicate.Name = "cmdDuplicate"
        Me.cmdDuplicate.Size = New System.Drawing.Size(75, 23)
        Me.cmdDuplicate.TabIndex = 14
        Me.cmdDuplicate.Text = "Duplicate"
        Me.cmdDuplicate.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(12, 191)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'dlgCalculationsSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(420, 247)
        Me.Controls.Add(Me.cmdDuplicate)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lblCalculations)
        Me.Controls.Add(Me.lstCalculations)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCalculationsSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "General Summaries"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents lblCalculations As Label
    Friend WithEvents lstCalculations As ListView
    Friend WithEvents cmdDuplicate As Button
End Class
