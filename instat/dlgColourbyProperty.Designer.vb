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
Partial Class dlgColourbyProperty
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgColourbyProperty))
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorColourByMetadata = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverMetadataProperty = New instat.ucrReceiverSingle()
        Me.lblMetadataProp = New System.Windows.Forms.Label()
        Me.ucrChkRemoveColours = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorColourByMetadata
        '
        Me.ucrSelectorColourByMetadata.bShowHiddenColumns = False
        Me.ucrSelectorColourByMetadata.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorColourByMetadata, "ucrSelectorColourByMetadata")
        Me.ucrSelectorColourByMetadata.Name = "ucrSelectorColourByMetadata"
        '
        'ucrReceiverMetadataProperty
        '
        Me.ucrReceiverMetadataProperty.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMetadataProperty, "ucrReceiverMetadataProperty")
        Me.ucrReceiverMetadataProperty.Name = "ucrReceiverMetadataProperty"
        Me.ucrReceiverMetadataProperty.Selector = Nothing
        Me.ucrReceiverMetadataProperty.strNcFilePath = ""
        Me.ucrReceiverMetadataProperty.ucrSelector = Nothing
        '
        'lblMetadataProp
        '
        resources.ApplyResources(Me.lblMetadataProp, "lblMetadataProp")
        Me.lblMetadataProp.Name = "lblMetadataProp"
        '
        'ucrChkRemoveColours
        '
        Me.ucrChkRemoveColours.Checked = False
        resources.ApplyResources(Me.ucrChkRemoveColours, "ucrChkRemoveColours")
        Me.ucrChkRemoveColours.Name = "ucrChkRemoveColours"
        '
        'dlgColourbyProperty
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkRemoveColours)
        Me.Controls.Add(Me.lblMetadataProp)
        Me.Controls.Add(Me.ucrReceiverMetadataProperty)
        Me.Controls.Add(Me.ucrSelectorColourByMetadata)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgColourbyProperty"
        Me.Tag = "Colour_by_Property"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorColourByMetadata As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverMetadataProperty As ucrReceiverSingle
    Friend WithEvents lblMetadataProp As Label
    Friend WithEvents ucrChkRemoveColours As ucrCheck
End Class
