<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDotPlot
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
        Me.cmdDotPlotOptions = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.lblSecondFactor = New System.Windows.Forms.Label()
        Me.ucrVariablesAsFactorDotPlot = New instat.ucrVariablesAsFactor()
        Me.ucrSaveDotPlot = New instat.ucrSaveGraph()
        Me.ucrDotPlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSecondFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.rdoXBinAxis = New System.Windows.Forms.RadioButton()
        Me.rdoYBinAxis = New System.Windows.Forms.RadioButton()
        Me.lblBinAxis = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdDotPlotOptions
        '
        Me.cmdDotPlotOptions.Location = New System.Drawing.Point(10, 200)
        Me.cmdDotPlotOptions.Name = "cmdDotPlotOptions"
        Me.cmdDotPlotOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdDotPlotOptions.TabIndex = 7
        Me.cmdDotPlotOptions.Tag = "Dot_Plot_Options"
        Me.cmdDotPlotOptions.Text = "Dot Plot Options"
        Me.cmdDotPlotOptions.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(10, 231)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdOptions.TabIndex = 8
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(255, 182)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(88, 13)
        Me.lblFactor.TabIndex = 3
        Me.lblFactor.Tag = "Factor_Optional:"
        Me.lblFactor.Text = "Factor (Optional):"
        '
        'lblSecondFactor
        '
        Me.lblSecondFactor.AutoSize = True
        Me.lblSecondFactor.Location = New System.Drawing.Point(254, 229)
        Me.lblSecondFactor.Name = "lblSecondFactor"
        Me.lblSecondFactor.Size = New System.Drawing.Size(128, 13)
        Me.lblSecondFactor.TabIndex = 5
        Me.lblSecondFactor.Tag = "Second_Factor_Optional:"
        Me.lblSecondFactor.Text = "Second Factor (Optional):"
        '
        'ucrVariablesAsFactorDotPlot
        '
        Me.ucrVariablesAsFactorDotPlot.Location = New System.Drawing.Point(255, 42)
        Me.ucrVariablesAsFactorDotPlot.Name = "ucrVariablesAsFactorDotPlot"
        Me.ucrVariablesAsFactorDotPlot.Size = New System.Drawing.Size(125, 133)
        Me.ucrVariablesAsFactorDotPlot.TabIndex = 11
        Me.ucrVariablesAsFactorDotPlot.ucrVariableSelector = Nothing
        '
        'ucrSaveDotPlot
        '
        Me.ucrSaveDotPlot.Location = New System.Drawing.Point(10, 266)
        Me.ucrSaveDotPlot.Name = "ucrSaveDotPlot"
        Me.ucrSaveDotPlot.Size = New System.Drawing.Size(265, 20)
        Me.ucrSaveDotPlot.TabIndex = 10
        '
        'ucrDotPlotSelector
        '
        Me.ucrDotPlotSelector.bShowHiddenColumns = False
        Me.ucrDotPlotSelector.bUseCurrentFilter = True
        Me.ucrDotPlotSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrDotPlotSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDotPlotSelector.Name = "ucrDotPlotSelector"
        Me.ucrDotPlotSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrDotPlotSelector.TabIndex = 0
        '
        'ucrSecondFactorReceiver
        '
        Me.ucrSecondFactorReceiver.Location = New System.Drawing.Point(255, 243)
        Me.ucrSecondFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondFactorReceiver.Name = "ucrSecondFactorReceiver"
        Me.ucrSecondFactorReceiver.Selector = Nothing
        Me.ucrSecondFactorReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrSecondFactorReceiver.TabIndex = 6
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.Location = New System.Drawing.Point(255, 198)
        Me.ucrFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Selector = Nothing
        Me.ucrFactorReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrFactorReceiver.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 292)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 9
        '
        'rdoXBinAxis
        '
        Me.rdoXBinAxis.AutoSize = True
        Me.rdoXBinAxis.Location = New System.Drawing.Point(311, 12)
        Me.rdoXBinAxis.Name = "rdoXBinAxis"
        Me.rdoXBinAxis.Size = New System.Drawing.Size(30, 17)
        Me.rdoXBinAxis.TabIndex = 12
        Me.rdoXBinAxis.TabStop = True
        Me.rdoXBinAxis.Text = "x"
        Me.rdoXBinAxis.UseVisualStyleBackColor = True
        '
        'rdoYBinAxis
        '
        Me.rdoYBinAxis.AutoSize = True
        Me.rdoYBinAxis.Location = New System.Drawing.Point(351, 12)
        Me.rdoYBinAxis.Name = "rdoYBinAxis"
        Me.rdoYBinAxis.Size = New System.Drawing.Size(30, 17)
        Me.rdoYBinAxis.TabIndex = 13
        Me.rdoYBinAxis.TabStop = True
        Me.rdoYBinAxis.Text = "y"
        Me.rdoYBinAxis.UseVisualStyleBackColor = True
        '
        'lblBinAxis
        '
        Me.lblBinAxis.AutoSize = True
        Me.lblBinAxis.Location = New System.Drawing.Point(252, 14)
        Me.lblBinAxis.Name = "lblBinAxis"
        Me.lblBinAxis.Size = New System.Drawing.Size(50, 13)
        Me.lblBinAxis.TabIndex = 14
        Me.lblBinAxis.Tag = "Bin_Axis"
        Me.lblBinAxis.Text = "Bin Axis :"
        '
        'dlgDotPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 350)
        Me.Controls.Add(Me.lblBinAxis)
        Me.Controls.Add(Me.rdoYBinAxis)
        Me.Controls.Add(Me.rdoXBinAxis)
        Me.Controls.Add(Me.ucrVariablesAsFactorDotPlot)
        Me.Controls.Add(Me.ucrSaveDotPlot)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.cmdDotPlotOptions)
        Me.Controls.Add(Me.ucrDotPlotSelector)
        Me.Controls.Add(Me.lblSecondFactor)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrSecondFactorReceiver)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDotPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Dot_Plot"
        Me.Text = "Dot Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDotPlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdDotPlotOptions As Button
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrSecondFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblSecondFactor As Label
    Friend WithEvents ucrSaveDotPlot As ucrSaveGraph
    Friend WithEvents ucrVariablesAsFactorDotPlot As ucrVariablesAsFactor
    Friend WithEvents rdoXBinAxis As RadioButton
    Friend WithEvents rdoYBinAxis As RadioButton
    Friend WithEvents lblBinAxis As Label
End Class
