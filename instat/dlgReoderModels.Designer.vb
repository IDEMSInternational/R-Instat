<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgReoderModels
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
        Me.rdoColumnMetadata = New System.Windows.Forms.RadioButton()
        Me.rdoDataFrameMetadata = New System.Windows.Forms.RadioButton()
        Me.ucrDataFrameColumnMetadata = New instat.ucrDataFrame()
        Me.ucrReorderMetadata = New instat.ucrReorder()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 181)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'rdoColumnMetadata
        '
        Me.rdoColumnMetadata.AutoSize = True
        Me.rdoColumnMetadata.Location = New System.Drawing.Point(184, 12)
        Me.rdoColumnMetadata.Name = "rdoColumnMetadata"
        Me.rdoColumnMetadata.Size = New System.Drawing.Size(108, 17)
        Me.rdoColumnMetadata.TabIndex = 1
        Me.rdoColumnMetadata.TabStop = True
        Me.rdoColumnMetadata.Text = "Column Metadata"
        Me.rdoColumnMetadata.UseVisualStyleBackColor = True
        '
        'rdoDataFrameMetadata
        '
        Me.rdoDataFrameMetadata.AutoSize = True
        Me.rdoDataFrameMetadata.Location = New System.Drawing.Point(13, 12)
        Me.rdoDataFrameMetadata.Name = "rdoDataFrameMetadata"
        Me.rdoDataFrameMetadata.Size = New System.Drawing.Size(125, 17)
        Me.rdoDataFrameMetadata.TabIndex = 2
        Me.rdoDataFrameMetadata.TabStop = True
        Me.rdoDataFrameMetadata.Text = "DataFrame Metadata"
        Me.rdoDataFrameMetadata.UseVisualStyleBackColor = True
        '
        'ucrDataFrameColumnMetadata
        '
        Me.ucrDataFrameColumnMetadata.Location = New System.Drawing.Point(13, 32)
        Me.ucrDataFrameColumnMetadata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameColumnMetadata.Name = "ucrDataFrameColumnMetadata"
        Me.ucrDataFrameColumnMetadata.Size = New System.Drawing.Size(120, 40)
        Me.ucrDataFrameColumnMetadata.TabIndex = 3
        '
        'ucrReorderMetadata
        '
        Me.ucrReorderMetadata.Location = New System.Drawing.Point(184, 36)
        Me.ucrReorderMetadata.Name = "ucrReorderMetadata"
        Me.ucrReorderMetadata.Size = New System.Drawing.Size(154, 139)
        Me.ucrReorderMetadata.TabIndex = 4
        Me.ucrReorderMetadata.ucrDataFrameList = Nothing
        Me.ucrReorderMetadata.ucrReceiver = Nothing
        '
        'dlgReoderModels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 261)
        Me.Controls.Add(Me.ucrReorderMetadata)
        Me.Controls.Add(Me.ucrDataFrameColumnMetadata)
        Me.Controls.Add(Me.rdoDataFrameMetadata)
        Me.Controls.Add(Me.rdoColumnMetadata)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgReoderModels"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Reoder"
        Me.Text = "Reoder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents rdoColumnMetadata As RadioButton
    Friend WithEvents rdoDataFrameMetadata As RadioButton
    Friend WithEvents ucrDataFrameColumnMetadata As ucrDataFrame
    Friend WithEvents ucrReorderMetadata As ucrReorder
End Class
