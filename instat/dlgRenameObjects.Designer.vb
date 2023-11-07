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
        Me.ucrInputType = New instat.ucrInputComboBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 310)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 7
        '
        'ucrSelectorForRenameObject
        '
        Me.ucrSelectorForRenameObject.AutoSize = True
        Me.ucrSelectorForRenameObject.bDropUnusedFilterLevels = False
        Me.ucrSelectorForRenameObject.bShowHiddenColumns = False
        Me.ucrSelectorForRenameObject.bUseCurrentFilter = True
        Me.ucrSelectorForRenameObject.Location = New System.Drawing.Point(15, 15)
        Me.ucrSelectorForRenameObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForRenameObject.Name = "ucrSelectorForRenameObject"
        Me.ucrSelectorForRenameObject.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorForRenameObject.TabIndex = 0
        '
        'ucrReceiverCurrentName
        '
        Me.ucrReceiverCurrentName.AutoSize = True
        Me.ucrReceiverCurrentName.frmParent = Me
        Me.ucrReceiverCurrentName.Location = New System.Drawing.Point(389, 152)
        Me.ucrReceiverCurrentName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCurrentName.Name = "ucrReceiverCurrentName"
        Me.ucrReceiverCurrentName.Selector = Nothing
        Me.ucrReceiverCurrentName.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverCurrentName.strNcFilePath = ""
        Me.ucrReceiverCurrentName.TabIndex = 2
        Me.ucrReceiverCurrentName.ucrSelector = Nothing
        '
        'lblCurrentName
        '
        Me.lblCurrentName.Location = New System.Drawing.Point(389, 130)
        Me.lblCurrentName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentName.Name = "lblCurrentName"
        Me.lblCurrentName.Size = New System.Drawing.Size(150, 22)
        Me.lblCurrentName.TabIndex = 1
        Me.lblCurrentName.Tag = "Current_Name"
        Me.lblCurrentName.Text = "Current Name:"
        '
        'lblNewName
        '
        Me.lblNewName.Location = New System.Drawing.Point(389, 202)
        Me.lblNewName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNewName.Name = "lblNewName"
        Me.lblNewName.Size = New System.Drawing.Size(150, 20)
        Me.lblNewName.TabIndex = 3
        Me.lblNewName.Tag = "New_Name"
        Me.lblNewName.Text = "New Name:"
        '
        'ucrInputNewName
        '
        Me.ucrInputNewName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewName.AutoSize = True
        Me.ucrInputNewName.IsMultiline = False
        Me.ucrInputNewName.IsReadOnly = False
        Me.ucrInputNewName.Location = New System.Drawing.Point(389, 234)
        Me.ucrInputNewName.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputNewName.Name = "ucrInputNewName"
        Me.ucrInputNewName.Size = New System.Drawing.Size(180, 32)
        Me.ucrInputNewName.TabIndex = 4
        '
        'ucrInputType
        '
        Me.ucrInputType.AddQuotesIfUnrecognised = True
        Me.ucrInputType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputType.GetSetSelectedIndex = -1
        Me.ucrInputType.IsReadOnly = False
        Me.ucrInputType.Location = New System.Drawing.Point(389, 84)
        Me.ucrInputType.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputType.Name = "ucrInputType"
        Me.ucrInputType.Size = New System.Drawing.Size(180, 32)
        Me.ucrInputType.TabIndex = 6
        '
        'lblType
        '
        Me.lblType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblType.Location = New System.Drawing.Point(389, 64)
        Me.lblType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(98, 20)
        Me.lblType.TabIndex = 5
        Me.lblType.Tag = "New_Name"
        Me.lblType.Text = "Type:"
        '
        'dlgRenameObjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(626, 396)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.ucrInputType)
        Me.Controls.Add(Me.ucrReceiverCurrentName)
        Me.Controls.Add(Me.ucrInputNewName)
        Me.Controls.Add(Me.lblNewName)
        Me.Controls.Add(Me.lblCurrentName)
        Me.Controls.Add(Me.ucrSelectorForRenameObject)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRenameObjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Rename_Object"
        Me.Text = "Rename Object"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForRenameObject As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverCurrentName As ucrReceiverSingle
    Friend WithEvents lblCurrentName As Label
    Friend WithEvents lblNewName As Label
    Friend WithEvents ucrInputNewName As ucrInputTextBox
    Friend WithEvents ucrInputType As ucrInputComboBox
    Friend WithEvents lblType As Label
End Class
