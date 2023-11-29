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
Partial Class dlgDeleteObjects
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblObjectsToDelete = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.ucrInputComboType = New instat.ucrInputComboBox()
        Me.ucrReceiverObjectsToDelete = New instat.ucrReceiverMultiple()
        Me.ucrSelectorDeleteObject = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblObjectsToDelete
        '
        Me.lblObjectsToDelete.AutoSize = True
        Me.lblObjectsToDelete.Location = New System.Drawing.Point(372, 124)
        Me.lblObjectsToDelete.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObjectsToDelete.Name = "lblObjectsToDelete"
        Me.lblObjectsToDelete.Size = New System.Drawing.Size(136, 20)
        Me.lblObjectsToDelete.TabIndex = 1
        Me.lblObjectsToDelete.Tag = "Objects_to_Delete"
        Me.lblObjectsToDelete.Text = "Objects to Delete:"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(373, 56)
        Me.lblType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(47, 20)
        Me.lblType.TabIndex = 3
        Me.lblType.Text = "Type:"
        '
        'ucrInputComboType
        '
        Me.ucrInputComboType.AddQuotesIfUnrecognised = True
        Me.ucrInputComboType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboType.GetSetSelectedIndex = -1
        Me.ucrInputComboType.IsReadOnly = False
        Me.ucrInputComboType.Location = New System.Drawing.Point(378, 80)
        Me.ucrInputComboType.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputComboType.Name = "ucrInputComboType"
        Me.ucrInputComboType.Size = New System.Drawing.Size(194, 32)
        Me.ucrInputComboType.TabIndex = 4
        '
        'ucrReceiverObjectsToDelete
        '
        Me.ucrReceiverObjectsToDelete.AutoSize = True
        Me.ucrReceiverObjectsToDelete.frmParent = Me
        Me.ucrReceiverObjectsToDelete.Location = New System.Drawing.Point(377, 146)
        Me.ucrReceiverObjectsToDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverObjectsToDelete.Name = "ucrReceiverObjectsToDelete"
        Me.ucrReceiverObjectsToDelete.Selector = Nothing
        Me.ucrReceiverObjectsToDelete.Size = New System.Drawing.Size(195, 150)
        Me.ucrReceiverObjectsToDelete.strNcFilePath = ""
        Me.ucrReceiverObjectsToDelete.TabIndex = 2
        Me.ucrReceiverObjectsToDelete.ucrSelector = Nothing
        '
        'ucrSelectorDeleteObject
        '
        Me.ucrSelectorDeleteObject.AutoSize = True
        Me.ucrSelectorDeleteObject.bDropUnusedFilterLevels = False
        Me.ucrSelectorDeleteObject.bShowHiddenColumns = False
        Me.ucrSelectorDeleteObject.bUseCurrentFilter = True
        Me.ucrSelectorDeleteObject.Location = New System.Drawing.Point(15, 15)
        Me.ucrSelectorDeleteObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDeleteObject.Name = "ucrSelectorDeleteObject"
        Me.ucrSelectorDeleteObject.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorDeleteObject.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 306)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 5
        '
        'dlgDeleteObjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(624, 390)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.ucrInputComboType)
        Me.Controls.Add(Me.ucrReceiverObjectsToDelete)
        Me.Controls.Add(Me.lblObjectsToDelete)
        Me.Controls.Add(Me.ucrSelectorDeleteObject)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDeleteObjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Delete_Objects"
        Me.Text = "Delete Objects"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDeleteObject As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblObjectsToDelete As Label
    Friend WithEvents ucrReceiverObjectsToDelete As ucrReceiverMultiple
    Friend WithEvents lblType As Label
    Friend WithEvents ucrInputComboType As ucrInputComboBox
End Class
