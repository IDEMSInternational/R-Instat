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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFrameReoderSheets = New instat.ucrDataFrame()
        Me.ucrSheetsToReoder = New instat.ucrReorder()
        Me.lblSheetsToReoder = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 175)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(411, 56)
        Me.ucrBase.TabIndex = 0
        '
        'ucrDataFrameReoderSheets
        '
        Me.ucrDataFrameReoderSheets.Location = New System.Drawing.Point(13, 13)
        Me.ucrDataFrameReoderSheets.Name = "ucrDataFrameReoderSheets"
        Me.ucrDataFrameReoderSheets.Size = New System.Drawing.Size(127, 41)
        Me.ucrDataFrameReoderSheets.TabIndex = 1
        '
        'ucrSheetsToReoder
        '
        Me.ucrSheetsToReoder.Location = New System.Drawing.Point(215, 30)
        Me.ucrSheetsToReoder.Name = "ucrSheetsToReoder"
        Me.ucrSheetsToReoder.Size = New System.Drawing.Size(154, 139)
        Me.ucrSheetsToReoder.TabIndex = 2
        Me.ucrSheetsToReoder.ucrDataFrameList = Nothing
        Me.ucrSheetsToReoder.ucrReceiver = Nothing
        '
        'lblSheetsToReoder
        '
        Me.lblSheetsToReoder.AutoSize = True
        Me.lblSheetsToReoder.Location = New System.Drawing.Point(212, 14)
        Me.lblSheetsToReoder.Name = "lblSheetsToReoder"
        Me.lblSheetsToReoder.Size = New System.Drawing.Size(90, 13)
        Me.lblSheetsToReoder.TabIndex = 3
        Me.lblSheetsToReoder.Text = "Sheets to Reoder"
        '
        'dlgReorderSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 232)
        Me.Controls.Add(Me.lblSheetsToReoder)
        Me.Controls.Add(Me.ucrSheetsToReoder)
        Me.Controls.Add(Me.ucrDataFrameReoderSheets)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgReorderSheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reorder Sheets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameReoderSheets As ucrDataFrame
    Friend WithEvents ucrSheetsToReoder As ucrReorder
    Friend WithEvents lblSheetsToReoder As Label
End Class
