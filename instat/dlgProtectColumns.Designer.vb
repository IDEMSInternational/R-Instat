<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgProtectColumns
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
        Me.ucrSelectorforProtectedColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverforProtectedColumns = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblProtectColumns = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrSelectorforProtectedColumns
        '
        Me.ucrSelectorforProtectedColumns.Location = New System.Drawing.Point(32, 0)
        Me.ucrSelectorforProtectedColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorforProtectedColumns.Name = "ucrSelectorforProtectedColumns"
        Me.ucrSelectorforProtectedColumns.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorforProtectedColumns.TabIndex = 0
        '
        'ucrReceiverforProtectedColumns
        '
        Me.ucrReceiverforProtectedColumns.Location = New System.Drawing.Point(290, 80)
        Me.ucrReceiverforProtectedColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverforProtectedColumns.Name = "ucrReceiverforProtectedColumns"
        Me.ucrReceiverforProtectedColumns.Selector = Nothing
        Me.ucrReceiverforProtectedColumns.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverforProtectedColumns.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(16, 197)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 2
        '
        'lblProtectColumns
        '
        Me.lblProtectColumns.AutoSize = True
        Me.lblProtectColumns.Location = New System.Drawing.Point(287, 63)
        Me.lblProtectColumns.Name = "lblProtectColumns"
        Me.lblProtectColumns.Size = New System.Drawing.Size(96, 13)
        Me.lblProtectColumns.TabIndex = 3
        Me.lblProtectColumns.Text = "Protected Columns"
        '
        'dlgProtectColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 252)
        Me.Controls.Add(Me.lblProtectColumns)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverforProtectedColumns)
        Me.Controls.Add(Me.ucrSelectorforProtectedColumns)
        Me.Name = "dlgProtectColumns"
        Me.Text = "Protect Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorforProtectedColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverforProtectedColumns As ucrReceiverMultiple
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblProtectColumns As Label
End Class
