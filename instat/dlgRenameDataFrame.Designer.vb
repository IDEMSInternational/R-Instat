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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRenameDataFrame))
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
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrDataFrameToRename
        '
        Me.ucrDataFrameToRename.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrDataFrameToRename, "ucrDataFrameToRename")
        Me.ucrDataFrameToRename.Name = "ucrDataFrameToRename"
        '
        'lblNewName
        '
        resources.ApplyResources(Me.lblNewName, "lblNewName")
        Me.lblNewName.Name = "lblNewName"
        Me.lblNewName.Tag = "New_Name"
        '
        'ucrInputNewName
        '
        Me.ucrInputNewName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewName.IsMultiline = False
        Me.ucrInputNewName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputNewName, "ucrInputNewName")
        Me.ucrInputNewName.Name = "ucrInputNewName"
        '
        'lblLabel
        '
        resources.ApplyResources(Me.lblLabel, "lblLabel")
        Me.lblLabel.Name = "lblLabel"
        '
        'ucrInputLabel
        '
        Me.ucrInputLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputLabel.IsMultiline = False
        Me.ucrInputLabel.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLabel, "ucrInputLabel")
        Me.ucrInputLabel.Name = "ucrInputLabel"
        '
        'dlgRenameDataFrame
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
