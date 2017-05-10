<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetupLoading
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
        Me.components = New System.ComponentModel.Container()
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pgbProgres = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblLoading
        '
        Me.lblLoading.AutoSize = True
        Me.lblLoading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.Location = New System.Drawing.Point(29, 60)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(199, 40)
        Me.lblLoading.TabIndex = 0
        Me.lblLoading.Text = "Loading packages from R. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please wait."
        Me.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoading.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "This may take several minutes."
        Me.Label1.UseWaitCursor = True
        '
        'pgbProgres
        '
        Me.pgbProgres.Location = New System.Drawing.Point(13, 123)
        Me.pgbProgres.MarqueeAnimationSpeed = 75
        Me.pgbProgres.Name = "pgbProgres"
        Me.pgbProgres.Size = New System.Drawing.Size(236, 13)
        Me.pgbProgres.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pgbProgres.TabIndex = 2
        Me.pgbProgres.UseWaitCursor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'frmSetupLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 182)
        Me.ControlBox = False
        Me.Controls.Add(Me.pgbProgres)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLoading)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(540, 49)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetupLoading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Setup Loading"
        Me.TopMost = True
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLoading As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pgbProgres As ProgressBar
    Friend WithEvents Timer1 As Timer
End Class
