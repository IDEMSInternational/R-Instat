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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrSave))
        Me.ucrChkSave = New instat.ucrCheck()
        Me.lblSaveText = New System.Windows.Forms.Label()
        Me.ucrInputComboSave = New instat.ucrInputComboBox()
        Me.ucrInputTextSave = New instat.ucrInputTextBox()
        Me.btnColumnPosition = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrChkSave
        '
        Me.ucrChkSave.Checked = False
        resources.ApplyResources(Me.ucrChkSave, "ucrChkSave")
        Me.ucrChkSave.Name = "ucrChkSave"
        '
        'lblSaveText
        '
        resources.ApplyResources(Me.lblSaveText, "lblSaveText")
        Me.lblSaveText.Name = "lblSaveText"
        '
        'ucrInputComboSave
        '
        Me.ucrInputComboSave.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputComboSave, "ucrInputComboSave")
        Me.ucrInputComboSave.GetSetSelectedIndex = -1
        Me.ucrInputComboSave.IsReadOnly = False
        Me.ucrInputComboSave.Name = "ucrInputComboSave"
        '
        'ucrInputTextSave
        '
        Me.ucrInputTextSave.AddQuotesIfUnrecognised = True
        Me.ucrInputTextSave.IsMultiline = False
        Me.ucrInputTextSave.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTextSave, "ucrInputTextSave")
        Me.ucrInputTextSave.Name = "ucrInputTextSave"
        '
        'btnColumnPosition
        '
        resources.ApplyResources(Me.btnColumnPosition, "btnColumnPosition")
        Me.btnColumnPosition.Name = "btnColumnPosition"
        Me.btnColumnPosition.UseVisualStyleBackColor = True
        '
        'ucrSave
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblSaveText)
        Me.Controls.Add(Me.ucrChkSave)
        Me.Controls.Add(Me.ucrInputTextSave)
        Me.Controls.Add(Me.btnColumnPosition)
        Me.Controls.Add(Me.ucrInputComboSave)
        Me.Name = "ucrSave"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrChkSave As ucrCheck
    Friend WithEvents lblSaveText As Label
    Friend WithEvents ucrInputComboSave As ucrInputComboBox
    Friend WithEvents ucrInputTextSave As ucrInputTextBox
    Friend WithEvents btnColumnPosition As Button
End Class
