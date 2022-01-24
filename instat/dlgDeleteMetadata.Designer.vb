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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorForDeleteMetadata = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblMetadataToDelete = New System.Windows.Forms.Label()
        Me.ucrReceiverMetadataToDelete = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 203)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 3
        '
        'ucrSelectorForDeleteMetadata
        '
        Me.ucrSelectorForDeleteMetadata.AutoSize = True
        Me.ucrSelectorForDeleteMetadata.bDropUnusedFilterLevels = False
        Me.ucrSelectorForDeleteMetadata.bShowHiddenColumns = False
        Me.ucrSelectorForDeleteMetadata.bUseCurrentFilter = True
        Me.ucrSelectorForDeleteMetadata.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorForDeleteMetadata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDeleteMetadata.Name = "ucrSelectorForDeleteMetadata"
        Me.ucrSelectorForDeleteMetadata.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForDeleteMetadata.TabIndex = 2
        '
        'lblMetadataToDelete
        '
        Me.lblMetadataToDelete.Location = New System.Drawing.Point(252, 23)
        Me.lblMetadataToDelete.Name = "lblMetadataToDelete"
        Me.lblMetadataToDelete.Size = New System.Drawing.Size(100, 23)
        Me.lblMetadataToDelete.TabIndex = 1
        Me.lblMetadataToDelete.Text = "Metadata to Delete"
        '
        'ucrReceiverMetadataToDelete
        '
        Me.ucrReceiverMetadataToDelete.AutoSize = True
        Me.ucrReceiverMetadataToDelete.frmParent = Me
        Me.ucrReceiverMetadataToDelete.Location = New System.Drawing.Point(255, 46)
        Me.ucrReceiverMetadataToDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMetadataToDelete.Name = "ucrReceiverMetadataToDelete"
        Me.ucrReceiverMetadataToDelete.Selector = Nothing
        Me.ucrReceiverMetadataToDelete.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMetadataToDelete.strNcFilePath = ""
        Me.ucrReceiverMetadataToDelete.TabIndex = 0
        Me.ucrReceiverMetadataToDelete.ucrSelector = Nothing
        '
        'dlgDeleteMetadata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(431, 264)
        Me.Controls.Add(Me.ucrReceiverMetadataToDelete)
        Me.Controls.Add(Me.lblMetadataToDelete)
        Me.Controls.Add(Me.ucrSelectorForDeleteMetadata)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDeleteMetadata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Metadata"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForDeleteMetadata As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblMetadataToDelete As Label
    Friend WithEvents ucrReceiverMetadataToDelete As ucrReceiverMultiple
End Class
