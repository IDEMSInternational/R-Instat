﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDeleteDescriptive
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
        Me.lblObjectsToDelete = New System.Windows.Forms.Label()
        Me.ucrReceiverObjectsToDelete = New instat.ucrReceiverMultiple()
        Me.ucrSelectorDeleteObject = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblObjectsToDelete
        '
        Me.lblObjectsToDelete.Location = New System.Drawing.Point(270, 43)
        Me.lblObjectsToDelete.Name = "lblObjectsToDelete"
        Me.lblObjectsToDelete.Size = New System.Drawing.Size(100, 23)
        Me.lblObjectsToDelete.TabIndex = 1
        Me.lblObjectsToDelete.Tag = "Objects_to_Delete"
        Me.lblObjectsToDelete.Text = "Objects to Delete:"
        '
        'ucrReceiverObjectsToDelete
        '
        Me.ucrReceiverObjectsToDelete.frmParent = Me
        Me.ucrReceiverObjectsToDelete.Location = New System.Drawing.Point(269, 60)
        Me.ucrReceiverObjectsToDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverObjectsToDelete.Name = "ucrReceiverObjectsToDelete"
        Me.ucrReceiverObjectsToDelete.Selector = Nothing
        Me.ucrReceiverObjectsToDelete.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverObjectsToDelete.TabIndex = 2
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
        'dlgDeleteDescriptive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 264)
        Me.Controls.Add(Me.ucrReceiverObjectsToDelete)
        Me.Controls.Add(Me.lblObjectsToDelete)
        Me.Controls.Add(Me.ucrSelectorDeleteObject)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDeleteDescriptive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Delete_Objects"
        Me.Text = "Delete Objects"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDeleteObject As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblObjectsToDelete As Label
    Friend WithEvents ucrReceiverObjectsToDelete As ucrReceiverMultiple
End Class
