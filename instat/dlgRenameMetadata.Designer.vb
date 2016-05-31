<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ucrBase.Location = New System.Drawing.Point(12, 219)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorForDeleTeMetadata
        '
        Me.ucrSelectorForDeleTeMetadata.Location = New System.Drawing.Point(13, 13)
        Me.ucrSelectorForDeleTeMetadata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDeleTeMetadata.Name = "ucrSelectorForDeleTeMetadata"
        Me.ucrSelectorForDeleTeMetadata.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForDeleTeMetadata.TabIndex = 1
        '
        'ucrReceiverSelectedMetadata
        '
        Me.ucrReceiverSelectedMetadata.Location = New System.Drawing.Point(243, 34)
        Me.ucrReceiverSelectedMetadata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelectedMetadata.Name = "ucrReceiverSelectedMetadata"
        Me.ucrReceiverSelectedMetadata.Selector = Nothing
        Me.ucrReceiverSelectedMetadata.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSelectedMetadata.TabIndex = 2
        '
        'lblSelectedMetadata
        '
        Me.lblSelectedMetadata.AutoSize = True
        Me.lblSelectedMetadata.Location = New System.Drawing.Point(240, 13)
        Me.lblSelectedMetadata.Name = "lblSelectedMetadata"
        Me.lblSelectedMetadata.Size = New System.Drawing.Size(97, 13)
        Me.lblSelectedMetadata.TabIndex = 3
        Me.lblSelectedMetadata.Text = "Selected Metadata"
        '
        'lblNewMetadataName
        '
        Me.lblNewMetadataName.AutoSize = True
        Me.lblNewMetadataName.Location = New System.Drawing.Point(240, 128)
        Me.lblNewMetadataName.Name = "lblNewMetadataName"
        Me.lblNewMetadataName.Size = New System.Drawing.Size(108, 13)
        Me.lblNewMetadataName.TabIndex = 4
        Me.lblNewMetadataName.Text = "New Metadata Name"
        '
        'ucrInputNewMetadataName
        '
        Me.ucrInputNewMetadataName.Location = New System.Drawing.Point(243, 146)
        Me.ucrInputNewMetadataName.Name = "ucrInputNewMetadataName"
        Me.ucrInputNewMetadataName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputNewMetadataName.TabIndex = 5
        '
        'dlgRenameMetadata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 283)
        Me.Controls.Add(Me.ucrInputNewMetadataName)
        Me.Controls.Add(Me.lblNewMetadataName)
        Me.Controls.Add(Me.lblSelectedMetadata)
        Me.Controls.Add(Me.ucrReceiverSelectedMetadata)
        Me.Controls.Add(Me.ucrSelectorForDeleTeMetadata)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgRenameMetadata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rename Metadata"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForDeleTeMetadata As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverSelectedMetadata As ucrReceiverSingle
    Friend WithEvents lblSelectedMetadata As Label
    Friend WithEvents lblNewMetadataName As Label
    Friend WithEvents ucrInputNewMetadataName As ucrInputTextBox
End Class
