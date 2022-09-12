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
        Me.ucrNudPageNumber = New instat.ucrNud()
        Me.ucrSdgPICSARainfalbuttons = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'lblTitleSize
        '
        Me.lblTitleSize.AutoSize = True
        Me.lblTitleSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitleSize.Location = New System.Drawing.Point(12, 21)
        Me.lblTitleSize.Name = "lblTitleSize"
        Me.lblTitleSize.Size = New System.Drawing.Size(100, 13)
        Me.lblTitleSize.TabIndex = 30
        Me.lblTitleSize.Text = "Enter page number:"
        '
        'ucrNudPageNumber
        '
        Me.ucrNudPageNumber.AutoSize = True
        Me.ucrNudPageNumber.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPageNumber.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPageNumber.Location = New System.Drawing.Point(152, 20)
        Me.ucrNudPageNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudPageNumber.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPageNumber.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPageNumber.Name = "ucrNudPageNumber"
        Me.ucrNudPageNumber.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPageNumber.TabIndex = 29
        Me.ucrNudPageNumber.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSdgPICSARainfalbuttons
        '
        Me.ucrSdgPICSARainfalbuttons.AutoSize = True
        Me.ucrSdgPICSARainfalbuttons.Location = New System.Drawing.Point(13, 47)
        Me.ucrSdgPICSARainfalbuttons.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrSdgPICSARainfalbuttons.Name = "ucrSdgPICSARainfalbuttons"
        Me.ucrSdgPICSARainfalbuttons.Size = New System.Drawing.Size(224, 30)
        Me.ucrSdgPICSARainfalbuttons.TabIndex = 31
        '
        'sdgWindowNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 86)
        Me.Controls.Add(Me.ucrSdgPICSARainfalbuttons)
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
    Friend WithEvents ucrSdgPICSARainfalbuttons As ucrButtonsSubdialogue
End Class
