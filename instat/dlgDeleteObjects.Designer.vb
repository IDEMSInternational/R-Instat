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
        Me.ucrReceiverObjectsToDelete = New instat.ucrReceiverMultiple()
        Me.ucrSelectorDeleteObject = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblObjectsToDelete
        '
        Me.lblObjectsToDelete.AutoSize = True
        Me.lblObjectsToDelete.Location = New System.Drawing.Point(254, 45)
        Me.lblObjectsToDelete.Name = "lblObjectsToDelete"
        Me.lblObjectsToDelete.Size = New System.Drawing.Size(92, 13)
        Me.lblObjectsToDelete.TabIndex = 1
        Me.lblObjectsToDelete.Tag = "Objects_to_Delete"
        Me.lblObjectsToDelete.Text = "Objects to Delete:"
        '
        'ucrReceiverObjectsToDelete
        '
        Me.ucrReceiverObjectsToDelete.frmParent = Me
        Me.ucrReceiverObjectsToDelete.Location = New System.Drawing.Point(254, 60)
        Me.ucrReceiverObjectsToDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverObjectsToDelete.Name = "ucrReceiverObjectsToDelete"
        Me.ucrReceiverObjectsToDelete.Selector = Nothing
        Me.ucrReceiverObjectsToDelete.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverObjectsToDelete.strNcFilePath = ""
        Me.ucrReceiverObjectsToDelete.TabIndex = 2
        Me.ucrReceiverObjectsToDelete.ucrSelector = Nothing
        '
        'ucrSelectorDeleteObject
        '
        Me.ucrSelectorDeleteObject.bShowHiddenColumns = False
        Me.ucrSelectorDeleteObject.bUseCurrentFilter = True
        Me.ucrSelectorDeleteObject.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorDeleteObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDeleteObject.Name = "ucrSelectorDeleteObject"
        Me.ucrSelectorDeleteObject.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDeleteObject.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 204)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 3
        '
        'dlgDeleteObjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 260)
        Me.Controls.Add(Me.ucrReceiverObjectsToDelete)
        Me.Controls.Add(Me.lblObjectsToDelete)
        Me.Controls.Add(Me.ucrSelectorDeleteObject)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
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
End Class
