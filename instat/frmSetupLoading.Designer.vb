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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pgbProgres = New System.Windows.Forms.ProgressBar()
        Me.lblWaiting = New System.Windows.Forms.Label()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(437, 111)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Sorry for the wait." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "An R command is taking some time to complete. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please be " &
    "patient while the process finishes."
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pgbProgres
        '
        Me.pgbProgres.Location = New System.Drawing.Point(43, 117)
        Me.pgbProgres.MarqueeAnimationSpeed = 75
        Me.pgbProgres.Name = "pgbProgres"
        Me.pgbProgres.Size = New System.Drawing.Size(351, 16)
        Me.pgbProgres.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pgbProgres.TabIndex = 2
        '
        'lblWaiting
        '
        Me.lblWaiting.AutoSize = True
        Me.lblWaiting.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaiting.Location = New System.Drawing.Point(21, 162)
        Me.lblWaiting.Name = "lblWaiting"
        Me.lblWaiting.Size = New System.Drawing.Size(159, 20)
        Me.lblWaiting.TabIndex = 3
        Me.lblWaiting.Text = "While you're waiting..."
        '
        'lblSeparator
        '
        Me.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeparator.Location = New System.Drawing.Point(18, 145)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(400, 2)
        Me.lblSeparator.TabIndex = 4
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMessage.Location = New System.Drawing.Point(22, 194)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(393, 89)
        Me.lblMessage.TabIndex = 5
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSetupLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(437, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.lblWaiting)
        Me.Controls.Add(Me.pgbProgres)
        Me.Controls.Add(Me.lblHeader)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(540, 49)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetupLoading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "An R Command is Running"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents pgbProgres As ProgressBar
    Friend WithEvents lblWaiting As Label
    Friend WithEvents lblSeparator As Label
    Friend WithEvents lblMessage As Label
End Class
