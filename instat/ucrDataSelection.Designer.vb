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
Partial Class ucrDataSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrDataSelection))
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.lstSelectedVariables = New System.Windows.Forms.ListBox()
        Me.lblAvailableVariables = New System.Windows.Forms.Label()
        Me.lstAvailableVariable = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnRemove
        '
        resources.ApplyResources(Me.btnRemove, "btnRemove")
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Tag = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Tag = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblSelectedVariables
        '
        resources.ApplyResources(Me.lblSelectedVariables, "lblSelectedVariables")
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Tag = "Selected_Variables"
        '
        'lstSelectedVariables
        '
        Me.lstSelectedVariables.FormattingEnabled = True
        resources.ApplyResources(Me.lstSelectedVariables, "lstSelectedVariables")
        Me.lstSelectedVariables.Name = "lstSelectedVariables"
        Me.lstSelectedVariables.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstSelectedVariables.Sorted = True
        '
        'lblAvailableVariables
        '
        resources.ApplyResources(Me.lblAvailableVariables, "lblAvailableVariables")
        Me.lblAvailableVariables.Name = "lblAvailableVariables"
        Me.lblAvailableVariables.Tag = "Available_Variables "
        '
        'lstAvailableVariable
        '
        Me.lstAvailableVariable.FormattingEnabled = True
        resources.ApplyResources(Me.lstAvailableVariable, "lstAvailableVariable")
        Me.lstAvailableVariable.Name = "lstAvailableVariable"
        Me.lstAvailableVariable.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstAvailableVariable.Sorted = True
        Me.lstAvailableVariable.Tag = ""
        '
        'ucrDataSelection
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.lstSelectedVariables)
        Me.Controls.Add(Me.lblAvailableVariables)
        Me.Controls.Add(Me.lstAvailableVariable)
        Me.Name = "ucrDataSelection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents lstSelectedVariables As ListBox
    Friend WithEvents lblAvailableVariables As Label
    Friend WithEvents lstAvailableVariable As ListBox
End Class
