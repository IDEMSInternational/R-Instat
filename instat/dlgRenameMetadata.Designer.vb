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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRenameMetadata))
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
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorForDeleTeMetadata
        '
        Me.ucrSelectorForDeleTeMetadata.bShowHiddenColumns = False
        Me.ucrSelectorForDeleTeMetadata.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForDeleTeMetadata, "ucrSelectorForDeleTeMetadata")
        Me.ucrSelectorForDeleTeMetadata.Name = "ucrSelectorForDeleTeMetadata"
        '
        'ucrReceiverSelectedMetadata
        '
        Me.ucrReceiverSelectedMetadata.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSelectedMetadata, "ucrReceiverSelectedMetadata")
        Me.ucrReceiverSelectedMetadata.Name = "ucrReceiverSelectedMetadata"
        Me.ucrReceiverSelectedMetadata.Selector = Nothing
        Me.ucrReceiverSelectedMetadata.strNcFilePath = ""
        Me.ucrReceiverSelectedMetadata.ucrSelector = Nothing
        '
        'lblSelectedMetadata
        '
        resources.ApplyResources(Me.lblSelectedMetadata, "lblSelectedMetadata")
        Me.lblSelectedMetadata.Name = "lblSelectedMetadata"
        '
        'lblNewMetadataName
        '
        resources.ApplyResources(Me.lblNewMetadataName, "lblNewMetadataName")
        Me.lblNewMetadataName.Name = "lblNewMetadataName"
        '
        'ucrInputNewMetadataName
        '
        Me.ucrInputNewMetadataName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewMetadataName.IsMultiline = False
        Me.ucrInputNewMetadataName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputNewMetadataName, "ucrInputNewMetadataName")
        Me.ucrInputNewMetadataName.Name = "ucrInputNewMetadataName"
        '
        'dlgRenameMetadata
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForDeleTeMetadata As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverSelectedMetadata As ucrReceiverSingle
    Friend WithEvents lblSelectedMetadata As Label
    Friend WithEvents lblNewMetadataName As Label
    Friend WithEvents ucrInputNewMetadataName As ucrInputTextBox
End Class
