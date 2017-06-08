<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgReorderColumns
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
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.ucrReorderColumns = New instat.ucrReorder()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFrameSelect = New instat.ucrDataFrame()
        Me.SuspendLayout()
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.Location = New System.Drawing.Point(210, 37)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(103, 13)
        Me.lblColumns.TabIndex = 1
        Me.lblColumns.Text = "Columns to Reorder:"
        '
        'ucrReorderColumns
        '
        Me.ucrReorderColumns.Location = New System.Drawing.Point(210, 49)
        Me.ucrReorderColumns.Name = "ucrReorderColumns"
        Me.ucrReorderColumns.Size = New System.Drawing.Size(154, 139)
        Me.ucrReorderColumns.TabIndex = 2
        Me.ucrReorderColumns.ucrDataFrameList = Nothing
        Me.ucrReorderColumns.ucrReceiver = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 194)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 3
        '
        'ucrDataFrameSelect
        '
        Me.ucrDataFrameSelect.bUseCurrentFilter = True
        Me.ucrDataFrameSelect.Location = New System.Drawing.Point(10, 10)
        Me.ucrDataFrameSelect.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameSelect.Name = "ucrDataFrameSelect"
        Me.ucrDataFrameSelect.Size = New System.Drawing.Size(120, 40)
        Me.ucrDataFrameSelect.TabIndex = 0
        '
        'dlgReorderColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 249)
        Me.Controls.Add(Me.ucrDataFrameSelect)
        Me.Controls.Add(Me.ucrReorderColumns)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReorderColumns"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reorder Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReorderColumns As ucrReorder
    Friend WithEvents ucrDataFrameSelect As ucrDataFrame
End Class
