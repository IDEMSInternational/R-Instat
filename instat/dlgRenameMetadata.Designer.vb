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
Partial Class dlgRenameMetadata
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
        Me.ucrSelectorForDeleTeMetadata = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverSelectedMetadata = New instat.ucrReceiverSingle()
        Me.lblSelectedMetadata = New System.Windows.Forms.Label()
        Me.lblNewMetadataName = New System.Windows.Forms.Label()
        Me.ucrInputNewMetadataName = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(3, 208)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 5
        '
        'ucrSelectorForDeleTeMetadata
        '
        Me.ucrSelectorForDeleTeMetadata.bShowHiddenColumns = False
        Me.ucrSelectorForDeleTeMetadata.bUseCurrentFilter = False
        Me.ucrSelectorForDeleTeMetadata.Location = New System.Drawing.Point(3, 9)
        Me.ucrSelectorForDeleTeMetadata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDeleTeMetadata.Name = "ucrSelectorForDeleTeMetadata"
        Me.ucrSelectorForDeleTeMetadata.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForDeleTeMetadata.TabIndex = 4
        '
        'ucrReceiverSelectedMetadata
        '
        Me.ucrReceiverSelectedMetadata.Location = New System.Drawing.Point(219, 48)
        Me.ucrReceiverSelectedMetadata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelectedMetadata.Name = "ucrReceiverSelectedMetadata"
        Me.ucrReceiverSelectedMetadata.Selector = Nothing
        Me.ucrReceiverSelectedMetadata.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSelectedMetadata.TabIndex = 3
        '
        'lblSelectedMetadata
        '
        Me.lblSelectedMetadata.Location = New System.Drawing.Point(216, 25)
        Me.lblSelectedMetadata.Name = "lblSelectedMetadata"
        Me.lblSelectedMetadata.Size = New System.Drawing.Size(100, 23)
        Me.lblSelectedMetadata.TabIndex = 2
        Me.lblSelectedMetadata.Text = "Selected Metadata"
        '
        'lblNewMetadataName
        '
        Me.lblNewMetadataName.Location = New System.Drawing.Point(216, 90)
        Me.lblNewMetadataName.Name = "lblNewMetadataName"
        Me.lblNewMetadataName.Size = New System.Drawing.Size(137, 23)
        Me.lblNewMetadataName.TabIndex = 1
        Me.lblNewMetadataName.Text = "New Metadata Name"
        '
        'ucrInputNewMetadataName
        '
        Me.ucrInputNewMetadataName.IsReadOnly = False
        Me.ucrInputNewMetadataName.Location = New System.Drawing.Point(219, 116)
        Me.ucrInputNewMetadataName.Name = "ucrInputNewMetadataName"
        Me.ucrInputNewMetadataName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputNewMetadataName.TabIndex = 0
        '
        'dlgRenameMetadata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 272)
        Me.Controls.Add(Me.ucrInputNewMetadataName)
        Me.Controls.Add(Me.lblNewMetadataName)
        Me.Controls.Add(Me.lblSelectedMetadata)
        Me.Controls.Add(Me.ucrReceiverSelectedMetadata)
        Me.Controls.Add(Me.ucrSelectorForDeleTeMetadata)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRenameMetadata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rename Metadata"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForDeleTeMetadata As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverSelectedMetadata As ucrReceiverSingle
    Friend WithEvents lblSelectedMetadata As Label
    Friend WithEvents lblNewMetadataName As Label
    Friend WithEvents ucrInputNewMetadataName As ucrInputTextBox
End Class
