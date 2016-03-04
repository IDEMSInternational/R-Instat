<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgCorrPlot
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
        Me.UcrButtonsSubdialogue1 = New instat.ucrButtonsSubdialogue()
        Me.tbGraphics = New System.Windows.Forms.TabPage()
        Me.tbSdgCorrelation = New System.Windows.Forms.TabControl()
        Me.chkGGPairs = New System.Windows.Forms.CheckBox()
        Me.tbGraphics.SuspendLayout()
        Me.tbSdgCorrelation.SuspendLayout()
        Me.SuspendLayout()
        '
        'UcrButtonsSubdialogue1
        '
        Me.UcrButtonsSubdialogue1.Location = New System.Drawing.Point(44, 228)
        Me.UcrButtonsSubdialogue1.Name = "UcrButtonsSubdialogue1"
        Me.UcrButtonsSubdialogue1.Size = New System.Drawing.Size(142, 30)
        Me.UcrButtonsSubdialogue1.TabIndex = 0
        '
        'tbGraphics
        '
        Me.tbGraphics.Controls.Add(Me.chkGGPairs)
        Me.tbGraphics.Location = New System.Drawing.Point(4, 22)
        Me.tbGraphics.Name = "tbGraphics"
        Me.tbGraphics.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGraphics.Size = New System.Drawing.Size(204, 184)
        Me.tbGraphics.TabIndex = 0
        Me.tbGraphics.Tag = "Graphics"
        Me.tbGraphics.Text = "Graphics"
        Me.tbGraphics.UseVisualStyleBackColor = True
        '
        'tbSdgCorrelation
        '
        Me.tbSdgCorrelation.Controls.Add(Me.tbGraphics)
        Me.tbSdgCorrelation.Location = New System.Drawing.Point(12, 12)
        Me.tbSdgCorrelation.Name = "tbSdgCorrelation"
        Me.tbSdgCorrelation.SelectedIndex = 0
        Me.tbSdgCorrelation.Size = New System.Drawing.Size(212, 210)
        Me.tbSdgCorrelation.TabIndex = 1
        Me.tbSdgCorrelation.Tag = ""
        '
        'chkGGPairs
        '
        Me.chkGGPairs.AutoSize = True
        Me.chkGGPairs.Location = New System.Drawing.Point(28, 31)
        Me.chkGGPairs.Name = "chkGGPairs"
        Me.chkGGPairs.Size = New System.Drawing.Size(68, 17)
        Me.chkGGPairs.TabIndex = 0
        Me.chkGGPairs.Tag = "GG_Pairs"
        Me.chkGGPairs.Text = "GG Pairs"
        Me.chkGGPairs.UseVisualStyleBackColor = True
        '
        'sdgCorrPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 261)
        Me.Controls.Add(Me.tbSdgCorrelation)
        Me.Controls.Add(Me.UcrButtonsSubdialogue1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgCorrPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "corrplot"
        Me.Text = "corrplot"
        Me.tbGraphics.ResumeLayout(False)
        Me.tbGraphics.PerformLayout()
        Me.tbSdgCorrelation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrButtonsSubdialogue1 As ucrButtonsSubdialogue
    Friend WithEvents tbGraphics As TabPage
    Friend WithEvents chkGGPairs As CheckBox
    Friend WithEvents tbSdgCorrelation As TabControl
End Class
