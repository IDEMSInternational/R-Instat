<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrLayerParamsControls
    Inherits instat.ucrCore

    'UserControl overrides dispose to clean up the component list.
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
        Me.ucrReceiverMetadataProperty = New instat.ucrReceiverMetadataProperty()
        Me.ucrChkParamName = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'ucrReceiverMetadataProperty
        '
        Me.ucrReceiverMetadataProperty.Location = New System.Drawing.Point(101, 2)
        Me.ucrReceiverMetadataProperty.Name = "ucrReceiverMetadataProperty"
        Me.ucrReceiverMetadataProperty.Size = New System.Drawing.Size(161, 23)
        Me.ucrReceiverMetadataProperty.TabIndex = 1
        '
        'ucrChkParamName
        '
        Me.ucrChkParamName.Checked = False
        Me.ucrChkParamName.Dock = System.Windows.Forms.DockStyle.Left
        Me.ucrChkParamName.Location = New System.Drawing.Point(0, 0)
        Me.ucrChkParamName.Name = "ucrChkParamName"
        Me.ucrChkParamName.Size = New System.Drawing.Size(100, 25)
        Me.ucrChkParamName.TabIndex = 2
        '
        'ucrLayerParamsControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkParamName)
        Me.Controls.Add(Me.ucrReceiverMetadataProperty)
        Me.Name = "ucrLayerParamsControls"
        Me.Size = New System.Drawing.Size(265, 25)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucrReceiverMetadataProperty As ucrReceiverMetadataProperty
    Friend WithEvents ucrChkParamName As ucrCheck
End Class
