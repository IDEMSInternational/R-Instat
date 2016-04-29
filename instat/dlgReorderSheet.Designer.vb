<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgReorderSheet
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblSheetsToReoder = New System.Windows.Forms.Label()
        Me.ucrSheetsToReoder = New instat.ucrReorder()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblSheetsToReoder
        '
        Me.lblSheetsToReoder.AutoSize = True
        Me.lblSheetsToReoder.Location = New System.Drawing.Point(12, 9)
        Me.lblSheetsToReoder.Name = "lblSheetsToReoder"
        Me.lblSheetsToReoder.Size = New System.Drawing.Size(90, 13)
        Me.lblSheetsToReoder.TabIndex = 3
        Me.lblSheetsToReoder.Text = "Sheets to Reoder"
        '
        'ucrSheetsToReoder
        '
        Me.ucrSheetsToReoder.Location = New System.Drawing.Point(12, 25)
        Me.ucrSheetsToReoder.Name = "ucrSheetsToReoder"
        Me.ucrSheetsToReoder.Size = New System.Drawing.Size(154, 139)
        Me.ucrSheetsToReoder.TabIndex = 2
        Me.ucrSheetsToReoder.ucrDataFrameList = Nothing
        Me.ucrSheetsToReoder.ucrReceiver = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 175)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(411, 56)
        Me.ucrBase.TabIndex = 0
        '
        'dlgReorderSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 232)
        Me.Controls.Add(Me.lblSheetsToReoder)
        Me.Controls.Add(Me.ucrSheetsToReoder)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgReorderSheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reorder Sheets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSheetsToReoder As ucrReorder
    Friend WithEvents lblSheetsToReoder As Label
End Class
