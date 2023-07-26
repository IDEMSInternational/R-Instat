<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgWindowNumber
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
        Me.lblTitleSize = New System.Windows.Forms.Label()
        Me.lblPages = New System.Windows.Forms.Label()
        Me.ucrBaseWindowNumber = New instat.ucrButtonsSubdialogue()
        Me.ucrNudPageNumber = New instat.ucrNud()
        Me.SuspendLayout()
        '
        'lblTitleSize
        '
        Me.lblTitleSize.AutoSize = True
        Me.lblTitleSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitleSize.Location = New System.Drawing.Point(4, 19)
        Me.lblTitleSize.Name = "lblTitleSize"
        Me.lblTitleSize.Size = New System.Drawing.Size(44, 13)
        Me.lblTitleSize.TabIndex = 30
        Me.lblTitleSize.Text = "Number"
        '
        'lblPages
        '
        Me.lblPages.AutoSize = True
        Me.lblPages.Location = New System.Drawing.Point(112, 21)
        Me.lblPages.Name = "lblPages"
        Me.lblPages.Size = New System.Drawing.Size(0, 13)
        Me.lblPages.TabIndex = 32
        '
        'ucrBaseWindowNumber
        '
        Me.ucrBaseWindowNumber.AutoSize = True
        Me.ucrBaseWindowNumber.Location = New System.Drawing.Point(31, 47)
        Me.ucrBaseWindowNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBaseWindowNumber.Name = "ucrBaseWindowNumber"
        Me.ucrBaseWindowNumber.Size = New System.Drawing.Size(224, 30)
        Me.ucrBaseWindowNumber.TabIndex = 31
        '
        'ucrNudPageNumber
        '
        Me.ucrNudPageNumber.AutoSize = True
        Me.ucrNudPageNumber.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPageNumber.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPageNumber.Location = New System.Drawing.Point(180, 18)
        Me.ucrNudPageNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudPageNumber.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPageNumber.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPageNumber.Name = "ucrNudPageNumber"
        Me.ucrNudPageNumber.Size = New System.Drawing.Size(93, 20)
        Me.ucrNudPageNumber.TabIndex = 29
        Me.ucrNudPageNumber.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'sdgWindowNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 81)
        Me.Controls.Add(Me.lblPages)
        Me.Controls.Add(Me.ucrBaseWindowNumber)
        Me.Controls.Add(Me.lblTitleSize)
        Me.Controls.Add(Me.ucrNudPageNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgWindowNumber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Window_Number"
        Me.Text = "Window Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitleSize As Label
    Friend WithEvents ucrNudPageNumber As ucrNud
    Friend WithEvents ucrBaseWindowNumber As ucrButtonsSubdialogue
    Friend WithEvents lblPages As Label
End Class
