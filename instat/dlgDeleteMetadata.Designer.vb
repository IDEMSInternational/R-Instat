<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ucrBase.Location = New System.Drawing.Point(12, 209)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorForDeleteMetadata
        '
        Me.ucrSelectorForDeleteMetadata.Location = New System.Drawing.Point(13, 13)
        Me.ucrSelectorForDeleteMetadata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDeleteMetadata.Name = "ucrSelectorForDeleteMetadata"
        Me.ucrSelectorForDeleteMetadata.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForDeleteMetadata.TabIndex = 1
        '
        'lblMetadataToDelete
        '
        Me.lblMetadataToDelete.AutoSize = True
        Me.lblMetadataToDelete.Location = New System.Drawing.Point(243, 13)
        Me.lblMetadataToDelete.Name = "lblMetadataToDelete"
        Me.lblMetadataToDelete.Size = New System.Drawing.Size(98, 13)
        Me.lblMetadataToDelete.TabIndex = 2
        Me.lblMetadataToDelete.Text = "Metadata to Delete"
        '
        'ucrReceiverMetadataToDelete
        '
        Me.ucrReceiverMetadataToDelete.Location = New System.Drawing.Point(246, 30)
        Me.ucrReceiverMetadataToDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMetadataToDelete.Name = "ucrReceiverMetadataToDelete"
        Me.ucrReceiverMetadataToDelete.Selector = Nothing
        Me.ucrReceiverMetadataToDelete.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMetadataToDelete.TabIndex = 3
        '
        'dlgDeleteMetadata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 273)
        Me.Controls.Add(Me.ucrReceiverMetadataToDelete)
        Me.Controls.Add(Me.lblMetadataToDelete)
        Me.Controls.Add(Me.ucrSelectorForDeleteMetadata)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
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
