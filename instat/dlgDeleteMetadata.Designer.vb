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
Partial Class dlgDeleteMetadata
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDeleteMetadata))
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorForDeleteMetadata = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblMetadataToDelete = New System.Windows.Forms.Label()
        Me.ucrReceiverMetadataToDelete = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorForDeleteMetadata
        '
        Me.ucrSelectorForDeleteMetadata.bShowHiddenColumns = False
        Me.ucrSelectorForDeleteMetadata.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForDeleteMetadata, "ucrSelectorForDeleteMetadata")
        Me.ucrSelectorForDeleteMetadata.Name = "ucrSelectorForDeleteMetadata"
        '
        'lblMetadataToDelete
        '
        resources.ApplyResources(Me.lblMetadataToDelete, "lblMetadataToDelete")
        Me.lblMetadataToDelete.Name = "lblMetadataToDelete"
        '
        'ucrReceiverMetadataToDelete
        '
        Me.ucrReceiverMetadataToDelete.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMetadataToDelete, "ucrReceiverMetadataToDelete")
        Me.ucrReceiverMetadataToDelete.Name = "ucrReceiverMetadataToDelete"
        Me.ucrReceiverMetadataToDelete.Selector = Nothing
        Me.ucrReceiverMetadataToDelete.strNcFilePath = ""
        Me.ucrReceiverMetadataToDelete.ucrSelector = Nothing
        '
        'dlgDeleteMetadata
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrReceiverMetadataToDelete)
        Me.Controls.Add(Me.lblMetadataToDelete)
        Me.Controls.Add(Me.ucrSelectorForDeleteMetadata)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDeleteMetadata"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForDeleteMetadata As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblMetadataToDelete As Label
    Friend WithEvents ucrReceiverMetadataToDelete As ucrReceiverMultiple
End Class
