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
        Me.lstBoxAvailable = New System.Windows.Forms.ListBox()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.UcrButtons1 = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lstBoxAvailable
        '
        Me.lstBoxAvailable.FormattingEnabled = True
        Me.lstBoxAvailable.Location = New System.Drawing.Point(33, 29)
        Me.lstBoxAvailable.Name = "lstBoxAvailable"
        Me.lstBoxAvailable.Size = New System.Drawing.Size(117, 173)
        Me.lstBoxAvailable.TabIndex = 1
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.Location = New System.Drawing.Point(30, 13)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(96, 13)
        Me.lblAvailable.TabIndex = 4
        Me.lblAvailable.Text = "Available Variables"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(285, 29)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(72, 13)
        Me.lblY.TabIndex = 5
        Me.lblY.Text = "Y - Variable(s)"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(285, 150)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(64, 13)
        Me.lblX.TabIndex = 6
        Me.lblX.Text = "X  - Variable"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(156, 53)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(92, 23)
        Me.cmdAdd.TabIndex = 7
        Me.cmdAdd.Text = "Y variable"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdRemove
        '
        Me.cmdRemove.Location = New System.Drawing.Point(156, 164)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(92, 23)
        Me.cmdRemove.TabIndex = 8
        Me.cmdRemove.Text = "X variable"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Title"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(33, 253)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(326, 20)
        Me.txtTitle.TabIndex = 11
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(288, 56)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(100, 20)
        Me.txtY.TabIndex = 12
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(288, 166)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(100, 20)
        Me.txtX.TabIndex = 13
        '
        'UcrButtons1
        '
        Me.UcrButtons1.Location = New System.Drawing.Point(37, 295)
        Me.UcrButtons1.Name = "UcrButtons1"
        Me.UcrButtons1.Size = New System.Drawing.Size(333, 32)
        Me.UcrButtons1.TabIndex = 0
        '
        'dlgPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 333)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.txtY)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblAvailable)
        Me.Controls.Add(Me.lstBoxAvailable)
        Me.Controls.Add(Me.UcrButtons1)
        Me.Name = "dlgPlot"
        Me.Text = "Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrButtons1 As ucrButtons
    Friend WithEvents lstBoxAvailable As ListBox
    Friend WithEvents lblAvailable As Label
    Friend WithEvents lblY As Label
    Friend WithEvents lblX As Label
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdRemove As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtY As TextBox
    Friend WithEvents txtX As TextBox
End Class
