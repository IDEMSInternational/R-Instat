<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrLayerParamsControls
    Inherits System.Windows.Forms.UserControl

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
        Me.chkParamName = New System.Windows.Forms.CheckBox()
        Me.ucrReceiverMetadataProperty = New instat.ucrReceiverMetadataProperty()
        Me.SuspendLayout()
        '
        'chkParamName
        '
        Me.chkParamName.AutoSize = True
        Me.chkParamName.Location = New System.Drawing.Point(3, 6)
        Me.chkParamName.Name = "chkParamName"
        Me.chkParamName.Size = New System.Drawing.Size(15, 14)
        Me.chkParamName.TabIndex = 0
        Me.chkParamName.UseVisualStyleBackColor = True
        '
        'ucrReceiverMetadataProperty
        '
        Me.ucrReceiverMetadataProperty.Location = New System.Drawing.Point(101, 2)
        Me.ucrReceiverMetadataProperty.Name = "ucrReceiverMetadataProperty"
        Me.ucrReceiverMetadataProperty.Size = New System.Drawing.Size(161, 23)
        Me.ucrReceiverMetadataProperty.TabIndex = 1
        '
        'ucrLayerParamsControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrReceiverMetadataProperty)
        Me.Controls.Add(Me.chkParamName)
        Me.Name = "ucrLayerParamsControls"
        Me.Size = New System.Drawing.Size(265, 25)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkParamName As CheckBox
    Friend WithEvents ucrReceiverMetadataProperty As ucrReceiverMetadataProperty
End Class
