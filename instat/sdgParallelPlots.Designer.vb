<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgParallelPlots
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
        Me.ucrBaseSdgParallelPlot = New instat.ucrButtonsSubdialogue()
        Me.ucrInputMissing = New instat.ucrInputComboBox()
        Me.ucrInputOrder = New instat.ucrInputComboBox()
        Me.lblMissing = New System.Windows.Forms.Label()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBaseSdgParallelPlot
        '
        Me.ucrBaseSdgParallelPlot.AutoSize = True
        Me.ucrBaseSdgParallelPlot.Location = New System.Drawing.Point(29, 89)
        Me.ucrBaseSdgParallelPlot.Name = "ucrBaseSdgParallelPlot"
        Me.ucrBaseSdgParallelPlot.Size = New System.Drawing.Size(224, 30)
        Me.ucrBaseSdgParallelPlot.TabIndex = 4
        '
        'ucrInputMissing
        '
        Me.ucrInputMissing.AddQuotesIfUnrecognised = True
        Me.ucrInputMissing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMissing.GetSetSelectedIndex = -1
        Me.ucrInputMissing.IsReadOnly = False
        Me.ucrInputMissing.Location = New System.Drawing.Point(74, 18)
        Me.ucrInputMissing.Name = "ucrInputMissing"
        Me.ucrInputMissing.Size = New System.Drawing.Size(127, 21)
        Me.ucrInputMissing.TabIndex = 1
        '
        'ucrInputOrder
        '
        Me.ucrInputOrder.AddQuotesIfUnrecognised = True
        Me.ucrInputOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputOrder.GetSetSelectedIndex = -1
        Me.ucrInputOrder.IsReadOnly = False
        Me.ucrInputOrder.Location = New System.Drawing.Point(74, 47)
        Me.ucrInputOrder.Name = "ucrInputOrder"
        Me.ucrInputOrder.Size = New System.Drawing.Size(128, 21)
        Me.ucrInputOrder.TabIndex = 3
        '
        'lblMissing
        '
        Me.lblMissing.AutoSize = True
        Me.lblMissing.Location = New System.Drawing.Point(8, 21)
        Me.lblMissing.Name = "lblMissing"
        Me.lblMissing.Size = New System.Drawing.Size(45, 13)
        Me.lblMissing.TabIndex = 0
        Me.lblMissing.Text = "Missing:"
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOrder.Location = New System.Drawing.Point(8, 47)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(36, 13)
        Me.lblOrder.TabIndex = 2
        Me.lblOrder.Text = "Order:"
        '
        'sdgParallelPlots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(213, 121)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.lblMissing)
        Me.Controls.Add(Me.ucrInputOrder)
        Me.Controls.Add(Me.ucrInputMissing)
        Me.Controls.Add(Me.ucrBaseSdgParallelPlot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgParallelPlots"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parallel Plots"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSdgParallelPlot As ucrButtonsSubdialogue
    Friend WithEvents ucrInputMissing As ucrInputComboBox
    Friend WithEvents ucrInputOrder As ucrInputComboBox
    Friend WithEvents lblMissing As Label
    Friend WithEvents lblOrder As Label
End Class
