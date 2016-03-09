<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgBoxplot
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
        Me.lblYVarToPlot = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblByFactors = New System.Windows.Forms.Label()
        Me.lblBySecondFactor = New System.Windows.Forms.Label()
        Me.cmdBoxPlotOptions = New System.Windows.Forms.Button()
        Me.ucrYvariableReceiver = New instat.ucrReceiverSingle()
        Me.ucrSecondFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorBoxPlot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrByFactorsReceiver = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblYVarToPlot
        '
        Me.lblYVarToPlot.AutoSize = True
        Me.lblYVarToPlot.Location = New System.Drawing.Point(271, 58)
        Me.lblYVarToPlot.Name = "lblYVarToPlot"
        Me.lblYVarToPlot.Size = New System.Drawing.Size(91, 13)
        Me.lblYVarToPlot.TabIndex = 1
        Me.lblYVarToPlot.Tag = "Y_variables_to_plot"
        Me.lblYVarToPlot.Text = "Y variables to plot"
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(307, 208)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdOptions.TabIndex = 7
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblByFactors
        '
        Me.lblByFactors.AutoSize = True
        Me.lblByFactors.Location = New System.Drawing.Point(278, 104)
        Me.lblByFactors.Name = "lblByFactors"
        Me.lblByFactors.Size = New System.Drawing.Size(60, 13)
        Me.lblByFactors.TabIndex = 3
        Me.lblByFactors.Tag = "By_factor_s_"
        Me.lblByFactors.Text = "By factor(s)"
        '
        'lblBySecondFactor
        '
        Me.lblBySecondFactor.AutoSize = True
        Me.lblBySecondFactor.Location = New System.Drawing.Point(278, 158)
        Me.lblBySecondFactor.Name = "lblBySecondFactor"
        Me.lblBySecondFactor.Size = New System.Drawing.Size(92, 13)
        Me.lblBySecondFactor.TabIndex = 5
        Me.lblBySecondFactor.Tag = "By_Second_Factor"
        Me.lblBySecondFactor.Text = "By Second Factor"
        '
        'cmdBoxPlotOptions
        '
        Me.cmdBoxPlotOptions.Location = New System.Drawing.Point(171, 208)
        Me.cmdBoxPlotOptions.Name = "cmdBoxPlotOptions"
        Me.cmdBoxPlotOptions.Size = New System.Drawing.Size(104, 23)
        Me.cmdBoxPlotOptions.TabIndex = 8
        Me.cmdBoxPlotOptions.Tag = "BoxPlot_Options"
        Me.cmdBoxPlotOptions.Text = "BoxPlot Options"
        Me.cmdBoxPlotOptions.UseVisualStyleBackColor = True
        '
        'ucrYvariableReceiver
        '
        Me.ucrYvariableReceiver.Location = New System.Drawing.Point(276, 75)
        Me.ucrYvariableReceiver.Name = "ucrYvariableReceiver"
        Me.ucrYvariableReceiver.Selector = Nothing
        Me.ucrYvariableReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrYvariableReceiver.TabIndex = 2
        '
        'ucrSecondFactorReceiver
        '
        Me.ucrSecondFactorReceiver.Location = New System.Drawing.Point(276, 176)
        Me.ucrSecondFactorReceiver.Name = "ucrSecondFactorReceiver"
        Me.ucrSecondFactorReceiver.Selector = Nothing
        Me.ucrSecondFactorReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrSecondFactorReceiver.TabIndex = 6
        '
        'ucrSelectorBoxPlot
        '
        Me.ucrSelectorBoxPlot.Location = New System.Drawing.Point(12, 9)
        Me.ucrSelectorBoxPlot.Name = "ucrSelectorBoxPlot"
        Me.ucrSelectorBoxPlot.Size = New System.Drawing.Size(230, 215)
        Me.ucrSelectorBoxPlot.TabIndex = 0
        '
        'ucrByFactorsReceiver
        '
        Me.ucrByFactorsReceiver.Location = New System.Drawing.Point(276, 120)
        Me.ucrByFactorsReceiver.Name = "ucrByFactorsReceiver"
        Me.ucrByFactorsReceiver.Selector = Nothing
        Me.ucrByFactorsReceiver.Size = New System.Drawing.Size(126, 26)
        Me.ucrByFactorsReceiver.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(0, 236)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 51)
        Me.ucrBase.TabIndex = 12
        '
        'dlgBoxplot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 291)
        Me.Controls.Add(Me.cmdBoxPlotOptions)
        Me.Controls.Add(Me.ucrYvariableReceiver)
        Me.Controls.Add(Me.ucrSecondFactorReceiver)
        Me.Controls.Add(Me.ucrSelectorBoxPlot)
        Me.Controls.Add(Me.lblBySecondFactor)
        Me.Controls.Add(Me.lblByFactors)
        Me.Controls.Add(Me.ucrByFactorsReceiver)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblYVarToPlot)
        Me.Controls.Add(Me.ucrBase)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgBoxplot"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Boxplot"
        Me.Text = "Boxplot"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblYVarToPlot As Label
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrByFactorsReceiver As ucrReceiverSingle
    Friend WithEvents lblByFactors As Label
    Friend WithEvents ucrSelectorBoxPlot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSecondFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblBySecondFactor As Label
    Friend WithEvents ucrYvariableReceiver As ucrReceiverSingle
    Friend WithEvents cmdBoxPlotOptions As Button
End Class
