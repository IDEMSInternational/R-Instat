<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgMapOption
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
        Me.lblLat = New System.Windows.Forms.Label()
        Me.lblLongMin = New System.Windows.Forms.Label()
        Me.lblLatMax = New System.Windows.Forms.Label()
        Me.lblLongMax = New System.Windows.Forms.Label()
        Me.lblLatMin = New System.Windows.Forms.Label()
        Me.lblLong = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.ucrInputLatMax = New instat.ucrInputTextBox()
        Me.ucrInputLongMax = New instat.ucrInputTextBox()
        Me.ucrInputLatMin = New instat.ucrInputTextBox()
        Me.ucrInputLongMin = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'lblLat
        '
        Me.lblLat.AutoSize = True
        Me.lblLat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLat.Location = New System.Drawing.Point(10, 83)
        Me.lblLat.Name = "lblLat"
        Me.lblLat.Size = New System.Drawing.Size(48, 13)
        Me.lblLat.TabIndex = 21
        Me.lblLat.Text = "Latitude:"
        '
        'lblLongMin
        '
        Me.lblLongMin.AutoSize = True
        Me.lblLongMin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLongMin.Location = New System.Drawing.Point(72, 51)
        Me.lblLongMin.Name = "lblLongMin"
        Me.lblLongMin.Size = New System.Drawing.Size(27, 13)
        Me.lblLongMin.TabIndex = 17
        Me.lblLongMin.Text = "Min:"
        '
        'lblLatMax
        '
        Me.lblLatMax.AutoSize = True
        Me.lblLatMax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLatMax.Location = New System.Drawing.Point(208, 83)
        Me.lblLatMax.Name = "lblLatMax"
        Me.lblLatMax.Size = New System.Drawing.Size(30, 13)
        Me.lblLatMax.TabIndex = 24
        Me.lblLatMax.Text = "Max:"
        '
        'lblLongMax
        '
        Me.lblLongMax.AutoSize = True
        Me.lblLongMax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLongMax.Location = New System.Drawing.Point(208, 51)
        Me.lblLongMax.Name = "lblLongMax"
        Me.lblLongMax.Size = New System.Drawing.Size(30, 13)
        Me.lblLongMax.TabIndex = 19
        Me.lblLongMax.Text = "Max:"
        '
        'lblLatMin
        '
        Me.lblLatMin.AutoSize = True
        Me.lblLatMin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLatMin.Location = New System.Drawing.Point(72, 83)
        Me.lblLatMin.Name = "lblLatMin"
        Me.lblLatMin.Size = New System.Drawing.Size(27, 13)
        Me.lblLatMin.TabIndex = 22
        Me.lblLatMin.Text = "Min:"
        '
        'lblLong
        '
        Me.lblLong.AutoSize = True
        Me.lblLong.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLong.Location = New System.Drawing.Point(10, 51)
        Me.lblLong.Name = "lblLong"
        Me.lblLong.Size = New System.Drawing.Size(57, 13)
        Me.lblLong.TabIndex = 16
        Me.lblLong.Text = "Longitude:"
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.Location = New System.Drawing.Point(112, 132)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(224, 30)
        Me.ucrBase.TabIndex = 25
        '
        'ucrInputLatMax
        '
        Me.ucrInputLatMax.AddQuotesIfUnrecognised = False
        Me.ucrInputLatMax.AutoSize = True
        Me.ucrInputLatMax.IsMultiline = False
        Me.ucrInputLatMax.IsReadOnly = False
        Me.ucrInputLatMax.Location = New System.Drawing.Point(240, 78)
        Me.ucrInputLatMax.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrInputLatMax.Name = "ucrInputLatMax"
        Me.ucrInputLatMax.Size = New System.Drawing.Size(99, 21)
        Me.ucrInputLatMax.TabIndex = 15
        '
        'ucrInputLongMax
        '
        Me.ucrInputLongMax.AddQuotesIfUnrecognised = False
        Me.ucrInputLongMax.AutoSize = True
        Me.ucrInputLongMax.IsMultiline = False
        Me.ucrInputLongMax.IsReadOnly = False
        Me.ucrInputLongMax.Location = New System.Drawing.Point(238, 47)
        Me.ucrInputLongMax.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrInputLongMax.Name = "ucrInputLongMax"
        Me.ucrInputLongMax.Size = New System.Drawing.Size(99, 21)
        Me.ucrInputLongMax.TabIndex = 20
        '
        'ucrInputLatMin
        '
        Me.ucrInputLatMin.AddQuotesIfUnrecognised = False
        Me.ucrInputLatMin.AutoSize = True
        Me.ucrInputLatMin.IsMultiline = False
        Me.ucrInputLatMin.IsReadOnly = False
        Me.ucrInputLatMin.Location = New System.Drawing.Point(102, 78)
        Me.ucrInputLatMin.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrInputLatMin.Name = "ucrInputLatMin"
        Me.ucrInputLatMin.Size = New System.Drawing.Size(99, 21)
        Me.ucrInputLatMin.TabIndex = 23
        '
        'ucrInputLongMin
        '
        Me.ucrInputLongMin.AddQuotesIfUnrecognised = False
        Me.ucrInputLongMin.AutoSize = True
        Me.ucrInputLongMin.IsMultiline = False
        Me.ucrInputLongMin.IsReadOnly = False
        Me.ucrInputLongMin.Location = New System.Drawing.Point(102, 47)
        Me.ucrInputLongMin.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrInputLongMin.Name = "ucrInputLongMin"
        Me.ucrInputLongMin.Size = New System.Drawing.Size(99, 21)
        Me.ucrInputLongMin.TabIndex = 18
        '
        'sdgMapOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(383, 181)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblLat)
        Me.Controls.Add(Me.lblLongMin)
        Me.Controls.Add(Me.lblLatMax)
        Me.Controls.Add(Me.ucrInputLatMax)
        Me.Controls.Add(Me.lblLongMax)
        Me.Controls.Add(Me.ucrInputLongMax)
        Me.Controls.Add(Me.lblLatMin)
        Me.Controls.Add(Me.ucrInputLatMin)
        Me.Controls.Add(Me.lblLong)
        Me.Controls.Add(Me.ucrInputLongMin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgMapOption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Map Options "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLat As Label
    Friend WithEvents lblLongMin As Label
    Friend WithEvents lblLatMax As Label
    Friend WithEvents ucrInputLatMax As ucrInputTextBox
    Friend WithEvents lblLongMax As Label
    Friend WithEvents ucrInputLongMax As ucrInputTextBox
    Friend WithEvents lblLatMin As Label
    Friend WithEvents ucrInputLatMin As ucrInputTextBox
    Friend WithEvents lblLong As Label
    Friend WithEvents ucrInputLongMin As ucrInputTextBox
    Friend WithEvents ucrBase As ucrButtonsSubdialogue
End Class
