<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgHideShowColumns
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
        Me.UcrSelectorForHiddenColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.UcrReceiverHiddenColumns = New instat.ucrReceiverMultiple()
        Me.Hidden_Columns = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 205)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'UcrSelectorForHiddenColumns
        '
        Me.UcrSelectorForHiddenColumns.Location = New System.Drawing.Point(13, 13)
        Me.UcrSelectorForHiddenColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrSelectorForHiddenColumns.Name = "UcrSelectorForHiddenColumns"
        Me.UcrSelectorForHiddenColumns.Size = New System.Drawing.Size(210, 180)
        Me.UcrSelectorForHiddenColumns.TabIndex = 1
        '
        'UcrReceiverHiddenColumns
        '
        Me.UcrReceiverHiddenColumns.Location = New System.Drawing.Point(249, 51)
        Me.UcrReceiverHiddenColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverHiddenColumns.Name = "UcrReceiverHiddenColumns"
        Me.UcrReceiverHiddenColumns.Selector = Nothing
        Me.UcrReceiverHiddenColumns.Size = New System.Drawing.Size(120, 100)
        Me.UcrReceiverHiddenColumns.TabIndex = 2
        '
        'Hidden_Columns
        '
        Me.Hidden_Columns.AutoSize = True
        Me.Hidden_Columns.Location = New System.Drawing.Point(246, 23)
        Me.Hidden_Columns.Name = "Hidden_Columns"
        Me.Hidden_Columns.Size = New System.Drawing.Size(90, 13)
        Me.Hidden_Columns.TabIndex = 3
        Me.Hidden_Columns.Text = "Hidden Column(s)"
        '
        'dlgHideShowColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 264)
        Me.Controls.Add(Me.Hidden_Columns)
        Me.Controls.Add(Me.UcrReceiverHiddenColumns)
        Me.Controls.Add(Me.UcrSelectorForHiddenColumns)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgHideShowColumns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Hidden_Columns"
        Me.Text = "Hidden Column(s)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents UcrSelectorForHiddenColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents UcrReceiverHiddenColumns As ucrReceiverMultiple
    Friend WithEvents Hidden_Columns As Label
End Class
