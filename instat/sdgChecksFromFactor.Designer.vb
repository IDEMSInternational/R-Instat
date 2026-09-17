<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgChecksFromFactor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.lblChecks = New System.Windows.Forms.Label()
        Me.ucrChecksLevels = New instat.ucrFactor()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.Location = New System.Drawing.Point(9, 260)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(224, 30)
        Me.ucrBase.TabIndex = 0
        '
        'lblChecks
        '
        Me.lblChecks.AutoSize = True
        Me.lblChecks.Location = New System.Drawing.Point(9, 9)
        Me.lblChecks.Name = "lblChecks"
        Me.lblChecks.Size = New System.Drawing.Size(150, 13)
        Me.lblChecks.TabIndex = 2
        Me.lblChecks.Text = "Select the check levels:"
        '
        'ucrChecksLevels
        '
        Me.ucrChecksLevels.AutoSize = True
        Me.ucrChecksLevels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrChecksLevels.Location = New System.Drawing.Point(9, 27)
        Me.ucrChecksLevels.Name = "ucrChecksLevels"
        Me.ucrChecksLevels.Size = New System.Drawing.Size(274, 224)
        Me.ucrChecksLevels.TabIndex = 1
        '
        'sdgChecksFromFactor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.Controls.Add(Me.ucrChecksLevels)
        Me.Controls.Add(Me.lblChecks)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgChecksFromFactor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Checks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents lblChecks As Label
    Friend WithEvents ucrChecksLevels As ucrFactor
End Class