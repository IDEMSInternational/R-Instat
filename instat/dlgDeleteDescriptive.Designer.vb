<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorDeleteObject = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblObjectsToDelete = New System.Windows.Forms.Label()
        Me.ucrReceiverObjectsToDelete = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 196)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorDeleteObject
        '
        Me.ucrSelectorDeleteObject.Location = New System.Drawing.Point(13, 13)
        Me.ucrSelectorDeleteObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDeleteObject.Name = "ucrSelectorDeleteObject"
        Me.ucrSelectorDeleteObject.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDeleteObject.TabIndex = 1
        '
        'lblObjectsToDelete
        '
        Me.lblObjectsToDelete.AutoSize = True
        Me.lblObjectsToDelete.Location = New System.Drawing.Point(264, 23)
        Me.lblObjectsToDelete.Name = "lblObjectsToDelete"
        Me.lblObjectsToDelete.Size = New System.Drawing.Size(89, 13)
        Me.lblObjectsToDelete.TabIndex = 2
        Me.lblObjectsToDelete.Tag = "Objects_to_Delete"
        Me.lblObjectsToDelete.Text = "Objects to Delete"
        '
        'ucrReceiverObjectsToDelete
        '
        Me.ucrReceiverObjectsToDelete.Location = New System.Drawing.Point(267, 39)
        Me.ucrReceiverObjectsToDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverObjectsToDelete.Name = "ucrReceiverObjectsToDelete"
        Me.ucrReceiverObjectsToDelete.Selector = Nothing
        Me.ucrReceiverObjectsToDelete.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverObjectsToDelete.TabIndex = 3
        '
        'dlgDeleteDescriptive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 260)
        Me.Controls.Add(Me.ucrReceiverObjectsToDelete)
        Me.Controls.Add(Me.lblObjectsToDelete)
        Me.Controls.Add(Me.ucrSelectorDeleteObject)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgDeleteDescriptive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Delete_Object"
        Me.Text = "Delete Object"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDeleteObject As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblObjectsToDelete As Label
    Friend WithEvents ucrReceiverObjectsToDelete As ucrReceiverMultiple
End Class
