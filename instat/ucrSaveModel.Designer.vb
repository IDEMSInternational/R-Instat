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
Partial Class ucrSaveModel
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
        Me.chkSaveModel = New System.Windows.Forms.CheckBox()
        Me.ucrInputModelName = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'chkSaveModel
        '
        Me.chkSaveModel.AutoSize = True
        Me.chkSaveModel.Location = New System.Drawing.Point(0, 3)
        Me.chkSaveModel.Name = "chkSaveModel"
        Me.chkSaveModel.Size = New System.Drawing.Size(83, 17)
        Me.chkSaveModel.TabIndex = 1
        Me.chkSaveModel.Tag = "Save_Model"
        Me.chkSaveModel.Text = "Save Model"
        Me.chkSaveModel.UseVisualStyleBackColor = True
        '
        'ucrInputModelName
        '
        Me.ucrInputModelName.AddQuotesIfUnrecognised = True
        Me.ucrInputModelName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputModelName.GetSetSelectedIndex = -1
        Me.ucrInputModelName.IsReadOnly = False
        Me.ucrInputModelName.Location = New System.Drawing.Point(86, 0)
        Me.ucrInputModelName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInputModelName.Name = "ucrInputModelName"
        Me.ucrInputModelName.Size = New System.Drawing.Size(180, 20)
        Me.ucrInputModelName.TabIndex = 0
        '
        'ucrSaveModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.Controls.Add(Me.chkSaveModel)
        Me.Controls.Add(Me.ucrInputModelName)
        Me.Name = "ucrSaveModel"
        Me.Size = New System.Drawing.Size(266, 23)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkSaveModel As CheckBox
    Friend WithEvents ucrInputModelName As ucrInputComboBox
End Class
