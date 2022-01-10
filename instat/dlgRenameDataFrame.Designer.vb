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
Partial Class dlgRenameDataFrame
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFrameToRename = New instat.ucrDataFrame()
        Me.lblNewName = New System.Windows.Forms.Label()
        Me.ucrInputNewName = New instat.ucrInputTextBox()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.ucrInputLabel = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 117)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 5
        '
        'ucrDataFrameToRename
        '
        Me.ucrDataFrameToRename.AutoSize = True
        Me.ucrDataFrameToRename.bDropUnusedFilterLevels = False
        Me.ucrDataFrameToRename.bUseCurrentFilter = True
        Me.ucrDataFrameToRename.Location = New System.Drawing.Point(10, 10)
        Me.ucrDataFrameToRename.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameToRename.Name = "ucrDataFrameToRename"
        Me.ucrDataFrameToRename.Size = New System.Drawing.Size(152, 43)
        Me.ucrDataFrameToRename.TabIndex = 0
        '
        'lblNewName
        '
        Me.lblNewName.Location = New System.Drawing.Point(196, 14)
        Me.lblNewName.Name = "lblNewName"
        Me.lblNewName.Size = New System.Drawing.Size(100, 26)
        Me.lblNewName.TabIndex = 1
        Me.lblNewName.Tag = "New_Name"
        Me.lblNewName.Text = "New Name:"
        '
        'ucrInputNewName
        '
        Me.ucrInputNewName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewName.AutoSize = True
        Me.ucrInputNewName.IsMultiline = False
        Me.ucrInputNewName.IsReadOnly = False
        Me.ucrInputNewName.Location = New System.Drawing.Point(196, 29)
        Me.ucrInputNewName.Name = "ucrInputNewName"
        Me.ucrInputNewName.Size = New System.Drawing.Size(131, 33)
        Me.ucrInputNewName.TabIndex = 2
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.Location = New System.Drawing.Point(196, 64)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(94, 13)
        Me.lblLabel.TabIndex = 3
        Me.lblLabel.Text = "Data Frame Label:"
        '
        'ucrInputLabel
        '
        Me.ucrInputLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputLabel.AutoSize = True
        Me.ucrInputLabel.IsMultiline = False
        Me.ucrInputLabel.IsReadOnly = False
        Me.ucrInputLabel.Location = New System.Drawing.Point(196, 79)
        Me.ucrInputLabel.Name = "ucrInputLabel"
        Me.ucrInputLabel.Size = New System.Drawing.Size(131, 32)
        Me.ucrInputLabel.TabIndex = 4
        '
        'dlgRenameDataFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(419, 175)
        Me.Controls.Add(Me.ucrInputLabel)
        Me.Controls.Add(Me.lblLabel)
        Me.Controls.Add(Me.ucrInputNewName)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblNewName)
        Me.Controls.Add(Me.ucrDataFrameToRename)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRenameDataFrame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rename Data Frame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrDataFrameToRename As ucrDataFrame
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblNewName As Label
    Friend WithEvents ucrInputNewName As ucrInputTextBox
    Friend WithEvents lblLabel As Label
    Friend WithEvents ucrInputLabel As ucrInputTextBox
End Class
