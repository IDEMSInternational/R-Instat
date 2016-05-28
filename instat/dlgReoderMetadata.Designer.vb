<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgReoderMetadata
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
        Me.ucrDataFrameReoderMetadata = New instat.ucrDataFrame()
        Me.lblMetataDataColumns = New System.Windows.Forms.Label()
        Me.ucrReorderMetadata = New instat.ucrReorder()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(5, 174)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrDataFrameReoderMetadata
        '
        Me.ucrDataFrameReoderMetadata.Location = New System.Drawing.Point(9, 9)
        Me.ucrDataFrameReoderMetadata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameReoderMetadata.Name = "ucrDataFrameReoderMetadata"
        Me.ucrDataFrameReoderMetadata.Size = New System.Drawing.Size(120, 40)
        Me.ucrDataFrameReoderMetadata.TabIndex = 1
        '
        'lblMetataDataColumns
        '
        Me.lblMetataDataColumns.AutoSize = True
        Me.lblMetataDataColumns.Location = New System.Drawing.Point(233, 16)
        Me.lblMetataDataColumns.Name = "lblMetataDataColumns"
        Me.lblMetataDataColumns.Size = New System.Drawing.Size(95, 13)
        Me.lblMetataDataColumns.TabIndex = 2
        Me.lblMetataDataColumns.Text = "Metadata Columns"
        '
        'ucrReorderMetadata
        '
        Me.ucrReorderMetadata.Location = New System.Drawing.Point(236, 32)
        Me.ucrReorderMetadata.Name = "ucrReorderMetadata"
        Me.ucrReorderMetadata.Size = New System.Drawing.Size(154, 139)
        Me.ucrReorderMetadata.TabIndex = 3
        Me.ucrReorderMetadata.ucrDataFrameList = Nothing
        Me.ucrReorderMetadata.ucrReceiver = Nothing
        '
        'dlgReoderMetadata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 238)
        Me.Controls.Add(Me.ucrReorderMetadata)
        Me.Controls.Add(Me.lblMetataDataColumns)
        Me.Controls.Add(Me.ucrDataFrameReoderMetadata)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgReoderMetadata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Reoder_Metadata"
        Me.Text = "Reoder Metadata"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameReoderMetadata As ucrDataFrame
    Friend WithEvents lblMetataDataColumns As Label
    Friend WithEvents ucrReorderMetadata As ucrReorder
End Class
