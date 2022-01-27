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
Partial Class ucrSave
    Inherits instat.ucrCore

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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ucrChkSave = New instat.ucrCheck()
        Me.lblSaveText = New System.Windows.Forms.Label()
        Me.ucrInputComboSave = New instat.ucrInputComboBox()
        Me.ucrInputTextSave = New instat.ucrInputTextBox()
        Me.btnColumnPosition = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrChkSave
        '
        Me.ucrChkSave.AutoSize = True
        Me.ucrChkSave.Checked = False
        Me.ucrChkSave.Location = New System.Drawing.Point(0, 0)
        Me.ucrChkSave.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkSave.Name = "ucrChkSave"
        Me.ucrChkSave.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkSave.TabIndex = 0
        '
        'lblSaveText
        '
        Me.lblSaveText.AutoSize = True
        Me.lblSaveText.Location = New System.Drawing.Point(0, 3)
        Me.lblSaveText.Name = "lblSaveText"
        Me.lblSaveText.Size = New System.Drawing.Size(39, 13)
        Me.lblSaveText.TabIndex = 1
        Me.lblSaveText.Text = "Label1"
        '
        'ucrInputComboSave
        '
        Me.ucrInputComboSave.AddQuotesIfUnrecognised = True
        Me.ucrInputComboSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.ucrInputComboSave.GetSetSelectedIndex = -1
        Me.ucrInputComboSave.IsReadOnly = False
        Me.ucrInputComboSave.Location = New System.Drawing.Point(194, 0)
        Me.ucrInputComboSave.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrInputComboSave.Name = "ucrInputComboSave"
        Me.ucrInputComboSave.Size = New System.Drawing.Size(155, 34)
        Me.ucrInputComboSave.TabIndex = 4
        '
        'ucrInputTextSave
        '
        Me.ucrInputTextSave.AddQuotesIfUnrecognised = True
        Me.ucrInputTextSave.AutoSize = True
        Me.ucrInputTextSave.IsMultiline = False
        Me.ucrInputTextSave.IsReadOnly = False
        Me.ucrInputTextSave.Location = New System.Drawing.Point(182, 0)
        Me.ucrInputTextSave.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrInputTextSave.Name = "ucrInputTextSave"
        Me.ucrInputTextSave.Size = New System.Drawing.Size(155, 34)
        Me.ucrInputTextSave.TabIndex = 3
        '
        'btnColumnPosition
        '
        Me.btnColumnPosition.AutoSize = True
        Me.btnColumnPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnColumnPosition.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnColumnPosition.Location = New System.Drawing.Point(349, 0)
        Me.btnColumnPosition.Name = "btnColumnPosition"
        Me.btnColumnPosition.Size = New System.Drawing.Size(54, 34)
        Me.btnColumnPosition.TabIndex = 5
        Me.btnColumnPosition.Text = "Position"
        Me.btnColumnPosition.UseVisualStyleBackColor = True
        '
        'ucrSave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = False
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.ucrInputComboSave)
        Me.Controls.Add(Me.ucrInputTextSave)
        Me.Controls.Add(Me.lblSaveText)
        Me.Controls.Add(Me.ucrChkSave)
        Me.Controls.Add(Me.btnColumnPosition)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ucrSave"
        Me.Size = New System.Drawing.Size(403, 34)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrChkSave As ucrCheck
    Friend WithEvents lblSaveText As Label
    Friend WithEvents ucrInputComboSave As ucrInputComboBox
    Friend WithEvents ucrInputTextSave As ucrInputTextBox
    Friend WithEvents btnColumnPosition As Button
End Class
