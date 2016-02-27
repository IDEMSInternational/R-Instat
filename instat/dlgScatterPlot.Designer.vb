<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgScatterPlot
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
        Me.ucrBase = New instat.ucrButtons()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrScatterPlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverY = New instat.ucrReceiverSingle()
        Me.ucrFactorOptionalReceiver = New instat.ucrReceiverSingle()
        Me.lblFactorOptional = New System.Windows.Forms.Label()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.lblYVariable = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 198)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 8
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(276, 165)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdOptions.TabIndex = 7
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrScatterPlotSelector
        '
        Me.ucrScatterPlotSelector.Location = New System.Drawing.Point(4, 4)
        Me.ucrScatterPlotSelector.Name = "ucrScatterPlotSelector"
        Me.ucrScatterPlotSelector.Size = New System.Drawing.Size(242, 179)
        Me.ucrScatterPlotSelector.TabIndex = 0
        '
        'ucrReceiverY
        '
        Me.ucrReceiverY.Location = New System.Drawing.Point(271, 32)
        Me.ucrReceiverY.Name = "ucrReceiverY"
        Me.ucrReceiverY.Selector = Nothing
        Me.ucrReceiverY.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverY.TabIndex = 2
        '
        'ucrFactorOptionalReceiver
        '
        Me.ucrFactorOptionalReceiver.Location = New System.Drawing.Point(271, 133)
        Me.ucrFactorOptionalReceiver.Name = "ucrFactorOptionalReceiver"
        Me.ucrFactorOptionalReceiver.Selector = Nothing
        Me.ucrFactorOptionalReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrFactorOptionalReceiver.TabIndex = 6
        '
        'lblFactorOptional
        '
        Me.lblFactorOptional.AutoSize = True
        Me.lblFactorOptional.Location = New System.Drawing.Point(268, 117)
        Me.lblFactorOptional.Name = "lblFactorOptional"
        Me.lblFactorOptional.Size = New System.Drawing.Size(82, 13)
        Me.lblFactorOptional.TabIndex = 5
        Me.lblFactorOptional.Tag = "Factor_Optional"
        Me.lblFactorOptional.Text = "Factor(Optional)"
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.Location = New System.Drawing.Point(271, 77)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverX.TabIndex = 4
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.Location = New System.Drawing.Point(268, 61)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(64, 13)
        Me.lblXVariable.TabIndex = 3
        Me.lblXVariable.Tag = "X_Variable"
        Me.lblXVariable.Text = "X  - Variable"
        '
        'lblYVariable
        '
        Me.lblYVariable.AutoSize = True
        Me.lblYVariable.Location = New System.Drawing.Point(268, 16)
        Me.lblYVariable.Name = "lblYVariable"
        Me.lblYVariable.Size = New System.Drawing.Size(72, 13)
        Me.lblYVariable.TabIndex = 1
        Me.lblYVariable.Tag = "Y_Variable"
        Me.lblYVariable.Text = "Y - Variable(s)"
        '
        'dlgScatterPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 259)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrScatterPlotSelector)
        Me.Controls.Add(Me.ucrReceiverY)
        Me.Controls.Add(Me.ucrFactorOptionalReceiver)
        Me.Controls.Add(Me.lblFactorOptional)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.lblYVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgScatterPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scatter Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrScatterPlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverY As ucrReceiverSingle
    Friend WithEvents ucrFactorOptionalReceiver As ucrReceiverSingle
    Friend WithEvents lblFactorOptional As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents lblXVariable As Label
    Friend WithEvents lblYVariable As Label
End Class
