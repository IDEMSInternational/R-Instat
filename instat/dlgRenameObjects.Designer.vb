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
Partial Class dlgRenameObjects
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
        Me.ucrSelectorForRenameObject = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverCurrentName = New instat.ucrReceiverSingle()
        Me.lblCurrentName = New System.Windows.Forms.Label()
        Me.lblNewName = New System.Windows.Forms.Label()
        Me.ucrInputNewName = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 207)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 5
        '
        'ucrSelectorForRenameObject
        '
        Me.ucrSelectorForRenameObject.bShowHiddenColumns = False
        Me.ucrSelectorForRenameObject.bUseCurrentFilter = True
        Me.ucrSelectorForRenameObject.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForRenameObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForRenameObject.Name = "ucrSelectorForRenameObject"
        Me.ucrSelectorForRenameObject.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForRenameObject.TabIndex = 0
        '
        'ucrReceiverCurrentName
        '
        Me.ucrReceiverCurrentName.frmParent = Me
        Me.ucrReceiverCurrentName.Location = New System.Drawing.Point(262, 60)
        Me.ucrReceiverCurrentName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCurrentName.Name = "ucrReceiverCurrentName"
        Me.ucrReceiverCurrentName.Selector = Nothing
        Me.ucrReceiverCurrentName.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverCurrentName.strNcFilePath = ""
        Me.ucrReceiverCurrentName.TabIndex = 2
        Me.ucrReceiverCurrentName.ucrSelector = Nothing
        '
        'lblCurrentName
        '
        Me.lblCurrentName.Location = New System.Drawing.Point(262, 44)
        Me.lblCurrentName.Name = "lblCurrentName"
        Me.lblCurrentName.Size = New System.Drawing.Size(100, 15)
        Me.lblCurrentName.TabIndex = 1
        Me.lblCurrentName.Tag = "Current_Name"
        Me.lblCurrentName.Text = "Current Name:"
        '
        'lblNewName
        '
        Me.lblNewName.Location = New System.Drawing.Point(262, 93)
        Me.lblNewName.Name = "lblNewName"
        Me.lblNewName.Size = New System.Drawing.Size(100, 13)
        Me.lblNewName.TabIndex = 3
        Me.lblNewName.Tag = "New_Name"
        Me.lblNewName.Text = "New Name:"
        '
        'ucrInputNewName
        '
        Me.ucrInputNewName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewName.IsMultiline = False
        Me.ucrInputNewName.IsReadOnly = False
        Me.ucrInputNewName.Location = New System.Drawing.Point(262, 107)
        Me.ucrInputNewName.Name = "ucrInputNewName"
        Me.ucrInputNewName.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputNewName.TabIndex = 4
        '
        'dlgRenameObjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 264)
        Me.Controls.Add(Me.ucrReceiverCurrentName)
        Me.Controls.Add(Me.ucrInputNewName)
        Me.Controls.Add(Me.lblNewName)
        Me.Controls.Add(Me.lblCurrentName)
        Me.Controls.Add(Me.ucrSelectorForRenameObject)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRenameObjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Rename_Object"
        Me.Text = "Rename Objects"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForRenameObject As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverCurrentName As ucrReceiverSingle
    Friend WithEvents lblCurrentName As Label
    Friend WithEvents lblNewName As Label
    Friend WithEvents ucrInputNewName As ucrInputTextBox
End Class
