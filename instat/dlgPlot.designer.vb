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
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.lstBoxAvailable = New System.Windows.Forms.ListBox()
        Me.UcrButtons1 = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(285, 168)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(100, 20)
        Me.txtX.TabIndex = 24
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(285, 58)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(100, 20)
        Me.txtY.TabIndex = 23
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(30, 255)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(326, 20)
        Me.txtTitle.TabIndex = 22
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(27, 239)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 21
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Title"
        '
        'cmdRemove
        '
        Me.cmdRemove.Location = New System.Drawing.Point(153, 166)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(92, 23)
        Me.cmdRemove.TabIndex = 20
        Me.cmdRemove.Text = "X variable"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(153, 55)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(92, 23)
        Me.cmdAdd.TabIndex = 19
        Me.cmdAdd.Text = "Y variable"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(282, 152)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(64, 13)
        Me.lblX.TabIndex = 18
        Me.lblX.Text = "X  - Variable"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(282, 31)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(72, 13)
        Me.lblY.TabIndex = 17
        Me.lblY.Text = "Y - Variable(s)"
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.Location = New System.Drawing.Point(27, 15)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(96, 13)
        Me.lblAvailable.TabIndex = 16
        Me.lblAvailable.Text = "Available Variables"
        '
        'lstBoxAvailable
        '
        Me.lstBoxAvailable.FormattingEnabled = True
        Me.lstBoxAvailable.Location = New System.Drawing.Point(30, 31)
        Me.lstBoxAvailable.Name = "lstBoxAvailable"
        Me.lstBoxAvailable.Size = New System.Drawing.Size(117, 173)
        Me.lstBoxAvailable.TabIndex = 15
        '
        'UcrButtons1
        '
        Me.UcrButtons1.Location = New System.Drawing.Point(34, 297)
        Me.UcrButtons1.Name = "UcrButtons1"
        Me.UcrButtons1.Size = New System.Drawing.Size(322, 32)
        Me.UcrButtons1.TabIndex = 14
        '
        'dlgPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 344)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.txtY)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblAvailable)
        Me.Controls.Add(Me.lstBoxAvailable)
        Me.Controls.Add(Me.UcrButtons1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtX As TextBox
    Friend WithEvents txtY As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents cmdRemove As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents lblX As Label
    Friend WithEvents lblY As Label
    Friend WithEvents lblAvailable As Label
    Friend WithEvents lstBoxAvailable As ListBox
    Friend WithEvents UcrButtons1 As ucrButtons
End Class
