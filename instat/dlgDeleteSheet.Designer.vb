<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDeleteSheet
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
        Me.ucrDataFrameToDelete = New instat.ucrDataFrame()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 67)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrDataFrameToDelete
        '
        Me.ucrDataFrameToDelete.bUseCurrentFilter = True
        Me.ucrDataFrameToDelete.Location = New System.Drawing.Point(10, 10)
        Me.ucrDataFrameToDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameToDelete.Name = "ucrDataFrameToDelete"
        Me.ucrDataFrameToDelete.Size = New System.Drawing.Size(120, 40)
        Me.ucrDataFrameToDelete.TabIndex = 1
        '
        'dlgDeleteSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 127)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrDataFrameToDelete)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDeleteSheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Data Frame"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrDataFrameToDelete As ucrDataFrame
    Friend WithEvents ucrBase As ucrButtons
End Class
