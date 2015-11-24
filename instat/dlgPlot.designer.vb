<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPlot
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
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblXvariable = New System.Windows.Forms.Label()
        Me.lblYvariable = New System.Windows.Forms.Label()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.ucrReceiverY = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(15, 158)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(326, 20)
        Me.txtTitle.TabIndex = 22
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 142)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 21
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Title"
        '
        'lblXvariable
        '
        Me.lblXvariable.AutoSize = True
        Me.lblXvariable.Location = New System.Drawing.Point(222, 60)
        Me.lblXvariable.Name = "lblXvariable"
        Me.lblXvariable.Size = New System.Drawing.Size(64, 13)
        Me.lblXvariable.TabIndex = 18
        Me.lblXvariable.Tag = "X_variable"
        Me.lblXvariable.Text = "X  - Variable"
        '
        'lblYvariable
        '
        Me.lblYvariable.AutoSize = True
        Me.lblYvariable.Location = New System.Drawing.Point(222, 15)
        Me.lblYvariable.Name = "lblYvariable"
        Me.lblYvariable.Size = New System.Drawing.Size(72, 13)
        Me.lblYvariable.TabIndex = 17
        Me.lblYvariable.Tag = "Y_variables "
        Me.lblYvariable.Text = "Y - Variable(s)"
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.Location = New System.Drawing.Point(27, 15)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(0, 13)
        Me.lblAvailable.TabIndex = 16
        '
        'ucrReceiverY
        '
        Me.ucrReceiverY.Location = New System.Drawing.Point(225, 31)
        Me.ucrReceiverY.Name = "ucrReceiverY"
        Me.ucrReceiverY.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverY.TabIndex = 26
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.Location = New System.Drawing.Point(225, 76)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverX.TabIndex = 25
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(2, 12)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 127)
        Me.ucrAddRemove.TabIndex = 23
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 184)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(322, 32)
        Me.ucrBase.TabIndex = 14
        '
        'dlgPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 229)
        Me.Controls.Add(Me.ucrReceiverY)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblXvariable)
        Me.Controls.Add(Me.lblYvariable)
        Me.Controls.Add(Me.lblAvailable)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblXvariable As Label
    Friend WithEvents lblYvariable As Label
    Friend WithEvents lblAvailable As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents ucrReceiverY As ucrReceiverSingle
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
