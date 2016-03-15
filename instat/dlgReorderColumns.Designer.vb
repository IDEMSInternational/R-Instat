<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgReorderColumns
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
        Me.ucrSelectColumnstoOrder = New instat.ucrSelectorByDataFrame()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiveColumns = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'ucrSelectColumnstoOrder
        '
        Me.ucrSelectColumnstoOrder.Location = New System.Drawing.Point(3, 0)
        Me.ucrSelectColumnstoOrder.Name = "ucrSelectColumnstoOrder"
        Me.ucrSelectColumnstoOrder.Size = New System.Drawing.Size(147, 177)
        Me.ucrSelectColumnstoOrder.TabIndex = 12
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.Location = New System.Drawing.Point(177, 48)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(160, 13)
        Me.lblColumns.TabIndex = 11
        Me.lblColumns.Text = "Insert Columns in their new order"
        '
        'ucrBase
        '
        Me.ucrBase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucrBase.Location = New System.Drawing.Point(3, 183)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 53)
        Me.ucrBase.TabIndex = 10
        '
        'ucrReceiveColumns
        '
        Me.ucrReceiveColumns.Location = New System.Drawing.Point(180, 73)
        Me.ucrReceiveColumns.Name = "ucrReceiveColumns"
        Me.ucrReceiveColumns.Selector = Nothing
        Me.ucrReceiveColumns.Size = New System.Drawing.Size(121, 104)
        Me.ucrReceiveColumns.TabIndex = 9
        '
        'dlgReorderColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 235)
        Me.Controls.Add(Me.ucrSelectColumnstoOrder)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiveColumns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgReorderColumns"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reorder Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectColumnstoOrder As ucrSelectorByDataFrame
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiveColumns As ucrReceiverMultiple
End Class
