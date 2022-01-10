<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgSelectMonth
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
        Me.lblSelectMonth = New System.Windows.Forms.Label()
        Me.ucrMonthAsFactor = New instat.ucrFactor()
        Me.ucrBaseSdg = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'lblSelectMonth
        '
        Me.lblSelectMonth.AutoSize = True
        Me.lblSelectMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectMonth.Location = New System.Drawing.Point(18, 23)
        Me.lblSelectMonth.Name = "lblSelectMonth"
        Me.lblSelectMonth.Size = New System.Drawing.Size(120, 13)
        Me.lblSelectMonth.TabIndex = 14
        Me.lblSelectMonth.Text = "Select Month(s) to Omit:"
        '
        'ucrMonthAsFactor
        '
        Me.ucrMonthAsFactor.AutoSize = True
        Me.ucrMonthAsFactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrMonthAsFactor.clsReceiver = Nothing
        Me.ucrMonthAsFactor.Location = New System.Drawing.Point(14, 40)
        Me.ucrMonthAsFactor.Name = "ucrMonthAsFactor"
        Me.ucrMonthAsFactor.shtCurrSheet = Nothing
        Me.ucrMonthAsFactor.Size = New System.Drawing.Size(231, 219)
        Me.ucrMonthAsFactor.TabIndex = 3
        Me.ucrMonthAsFactor.ucrChkLevels = Nothing
        '
        'ucrBaseSdg
        '
        Me.ucrBaseSdg.AutoSize = True
        Me.ucrBaseSdg.Location = New System.Drawing.Point(53, 265)
        Me.ucrBaseSdg.Name = "ucrBaseSdg"
        Me.ucrBaseSdg.Size = New System.Drawing.Size(224, 30)
        Me.ucrBaseSdg.TabIndex = 0
        '
        'sdgSelectMonth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(259, 298)
        Me.Controls.Add(Me.lblSelectMonth)
        Me.Controls.Add(Me.ucrMonthAsFactor)
        Me.Controls.Add(Me.ucrBaseSdg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgSelectMonth"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Month"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSdg As ucrButtonsSubdialogue
    Friend WithEvents ucrMonthAsFactor As ucrFactor
    Friend WithEvents lblSelectMonth As Label
End Class
