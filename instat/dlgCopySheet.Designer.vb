<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCopySheet
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
        Me.ucrReceiveColumns = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.ucrSelectColumnstoCopy = New instat.ucrSelectorByDataFrame()
        Me.SuspendLayout()
        '
        'ucrReceiveColumns
        '
        Me.ucrReceiveColumns.Location = New System.Drawing.Point(282, 73)
        Me.ucrReceiveColumns.Name = "ucrReceiveColumns"
        Me.ucrReceiveColumns.Selector = Nothing
        Me.ucrReceiveColumns.Size = New System.Drawing.Size(121, 104)
        Me.ucrReceiveColumns.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucrBase.Location = New System.Drawing.Point(0, 183)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(403, 53)
        Me.ucrBase.TabIndex = 1
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.Location = New System.Drawing.Point(287, 57)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(109, 13)
        Me.lblColumns.TabIndex = 3
        Me.lblColumns.Text = "Columns to be copied"
        '
        'ucrSelectColumnstoCopy
        '
        Me.ucrSelectColumnstoCopy.Location = New System.Drawing.Point(0, 0)
        Me.ucrSelectColumnstoCopy.Name = "ucrSelectColumnstoCopy"
        Me.ucrSelectColumnstoCopy.Size = New System.Drawing.Size(147, 177)
        Me.ucrSelectColumnstoCopy.TabIndex = 4
        '
        'dlgCopySheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 236)
        Me.Controls.Add(Me.ucrSelectColumnstoCopy)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiveColumns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgCopySheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Copy Sheet (s) "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrReceiveColumns As ucrReceiverMultiple
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrSelectColumnstoCopy As ucrSelectorByDataFrame
End Class
