<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgUseGraph
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
        Me.dlgOpenGraph = New System.Windows.Forms.OpenFileDialog()
        Me.cmdOpenGraph = New System.Windows.Forms.Button()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'dlgOpenGraph
        '
        Me.dlgOpenGraph.FileName = "OpenFileDialog1"
        '
        'cmdOpenGraph
        '
        Me.cmdOpenGraph.Location = New System.Drawing.Point(101, 3)
        Me.cmdOpenGraph.Name = "cmdOpenGraph"
        Me.cmdOpenGraph.Size = New System.Drawing.Size(221, 32)
        Me.cmdOpenGraph.TabIndex = 1
        Me.cmdOpenGraph.Text = "Open Graph"
        Me.cmdOpenGraph.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(6, 59)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'dlgUseGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 127)
        Me.Controls.Add(Me.cmdOpenGraph)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgUseGraph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Use_Graph"
        Me.Text = "Use Graph"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents dlgOpenGraph As OpenFileDialog
    Friend WithEvents cmdOpenGraph As Button
End Class
