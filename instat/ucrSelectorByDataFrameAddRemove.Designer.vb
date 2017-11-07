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
Partial Class ucrSelectorByDataFrameAddRemove
    Inherits instat.ucrSelectorByDataFrame

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrSelectorByDataFrameAddRemove))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDataOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrAvailableDataFrames
        '
        resources.ApplyResources(Me.ucrAvailableDataFrames, "ucrAvailableDataFrames")
        '
        'lstAvailableVariable
        '
        resources.ApplyResources(Me.lstAvailableVariable, "lstAvailableVariable")
        '
        'btnAdd
        '
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Tag = "add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDataOptions
        '
        resources.ApplyResources(Me.btnDataOptions, "btnDataOptions")
        Me.btnDataOptions.Name = "btnDataOptions"
        Me.btnDataOptions.Tag = "Data_Options"
        Me.btnDataOptions.UseVisualStyleBackColor = True
        '
        'ucrSelectorByDataFrameAddRemove
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnDataOptions)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "ucrSelectorByDataFrameAddRemove"
        Me.Controls.SetChildIndex(Me.ucrAvailableDataFrames, 0)
        Me.Controls.SetChildIndex(Me.lstAvailableVariable, 0)
        Me.Controls.SetChildIndex(Me.btnAdd, 0)
        Me.Controls.SetChildIndex(Me.btnDataOptions, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDataOptions As Button
End Class
