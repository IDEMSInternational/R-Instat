<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorColourByMetadata = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverMetadataProperty = New instat.ucrReceiverSingle()
        Me.lblMetadataProp = New System.Windows.Forms.Label()
        Me.ucrChkRemoveColours = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 201)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorColourByMetadata
        '
        Me.ucrSelectorColourByMetadata.bShowHiddenColumns = False
        Me.ucrSelectorColourByMetadata.bUseCurrentFilter = True
        Me.ucrSelectorColourByMetadata.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorColourByMetadata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorColourByMetadata.Name = "ucrSelectorColourByMetadata"
        Me.ucrSelectorColourByMetadata.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorColourByMetadata.TabIndex = 1
        '
        'ucrReceiverMetadataProperty
        '
        Me.ucrReceiverMetadataProperty.frmParent = Me
        Me.ucrReceiverMetadataProperty.Location = New System.Drawing.Point(263, 60)
        Me.ucrReceiverMetadataProperty.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMetadataProperty.Name = "ucrReceiverMetadataProperty"
        Me.ucrReceiverMetadataProperty.Selector = Nothing
        Me.ucrReceiverMetadataProperty.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMetadataProperty.strNcFilePath = ""
        Me.ucrReceiverMetadataProperty.TabIndex = 2
        Me.ucrReceiverMetadataProperty.ucrSelector = Nothing
        '
        'lblMetadataProp
        '
        Me.lblMetadataProp.AutoSize = True
        Me.lblMetadataProp.Location = New System.Drawing.Point(263, 45)
        Me.lblMetadataProp.Name = "lblMetadataProp"
        Me.lblMetadataProp.Size = New System.Drawing.Size(97, 13)
        Me.lblMetadataProp.TabIndex = 3
        Me.lblMetadataProp.Text = "Metadata Property:"
        '
        'ucrChkRemoveColours
        '
        Me.ucrChkRemoveColours.Checked = False
        Me.ucrChkRemoveColours.Location = New System.Drawing.Point(263, 84)
        Me.ucrChkRemoveColours.Name = "ucrChkRemoveColours"
        Me.ucrChkRemoveColours.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkRemoveColours.TabIndex = 4
        '
        'dlgColourbyProperty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 261)
        Me.Controls.Add(Me.ucrChkRemoveColours)
        Me.Controls.Add(Me.lblMetadataProp)
        Me.Controls.Add(Me.ucrReceiverMetadataProperty)
        Me.Controls.Add(Me.ucrSelectorColourByMetadata)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgColourbyProperty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Colour_by_Property"
        Me.Text = "Colour by Property"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorColourByMetadata As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverMetadataProperty As ucrReceiverSingle
    Friend WithEvents lblMetadataProp As Label
    Friend WithEvents ucrChkRemoveColours As ucrCheck
End Class
