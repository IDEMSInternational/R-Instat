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
        Me.lblDataFrameToReorder = New System.Windows.Forms.Label()
        Me.ucrSheetsToReorder = New instat.ucrReorder()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblDataFrameToReorder
        '
        Me.lblDataFrameToReorder.Location = New System.Drawing.Point(10, 22)
        Me.lblDataFrameToReorder.Name = "lblDataFrameToReorder"
        Me.lblDataFrameToReorder.Size = New System.Drawing.Size(132, 12)
        Me.lblDataFrameToReorder.TabIndex = 0
        Me.lblDataFrameToReorder.Text = "Data Frames to Reorder:"
        '
        'ucrSheetsToReorder
        '
        Me.ucrSheetsToReorder.Location = New System.Drawing.Point(8, 35)
        Me.ucrSheetsToReorder.Name = "ucrSheetsToReorder"
        Me.ucrSheetsToReorder.Size = New System.Drawing.Size(154, 139)
        Me.ucrSheetsToReorder.TabIndex = 1
        Me.ucrSheetsToReorder.ucrDataFrameList = Nothing
        Me.ucrSheetsToReorder.ucrReceiver = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 180)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 2
        '
        'dlgReorderSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 238)
        Me.Controls.Add(Me.lblDataFrameToReorder)
        Me.Controls.Add(Me.ucrSheetsToReorder)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReorderSheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reoder Sheets"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSheetsToReorder As ucrReorder
    Friend WithEvents lblDataFrameToReorder As Label
End Class
