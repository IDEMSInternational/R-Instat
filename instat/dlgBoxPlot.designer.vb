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
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblByFactors = New System.Windows.Forms.Label()
        Me.lblBySecondFactor = New System.Windows.Forms.Label()
        Me.cmdBoxPlotOptions = New System.Windows.Forms.Button()
        Me.ucrVariablesAsFactorForBoxplot = New instat.ucrVariablesAsFactor()
        Me.ucrSecondFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorBoxPlot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrByFactorsReceiver = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.rdoBoxplot = New System.Windows.Forms.RadioButton()
        Me.rdoJitter = New System.Windows.Forms.RadioButton()
        Me.rdoViolin = New System.Windows.Forms.RadioButton()
        Me.ucrPnlPlots = New instat.UcrPanel()
        Me.ucrChkVarwidth = New instat.ucrCheck()
        Me.ucrChkHorizontalBoxplot = New instat.ucrCheck()
        Me.ucrSaveBoxplot = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(10, 268)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdOptions.TabIndex = 8
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblByFactors
        '
        Me.lblByFactors.AutoSize = True
        Me.lblByFactors.Location = New System.Drawing.Point(254, 199)
        Me.lblByFactors.Name = "lblByFactors"
        Me.lblByFactors.Size = New System.Drawing.Size(88, 13)
        Me.lblByFactors.TabIndex = 2
        Me.lblByFactors.Tag = "By_Factor:"
        Me.lblByFactors.Text = "Factor (Optional):"
        '
        'lblBySecondFactor
        '
        Me.lblBySecondFactor.AutoSize = True
        Me.lblBySecondFactor.Location = New System.Drawing.Point(254, 243)
        Me.lblBySecondFactor.Name = "lblBySecondFactor"
        Me.lblBySecondFactor.Size = New System.Drawing.Size(128, 13)
        Me.lblBySecondFactor.TabIndex = 4
        Me.lblBySecondFactor.Tag = "By_Second_Factor:"
        Me.lblBySecondFactor.Text = "Second Factor (Optional):"
        '
        'cmdBoxPlotOptions
        '
        Me.cmdBoxPlotOptions.Location = New System.Drawing.Point(10, 237)
        Me.cmdBoxPlotOptions.Name = "cmdBoxPlotOptions"
        Me.cmdBoxPlotOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdBoxPlotOptions.TabIndex = 7
        Me.cmdBoxPlotOptions.Tag = "BoxPlot_Options"
        Me.cmdBoxPlotOptions.Text = "Boxplot Options"
        Me.cmdBoxPlotOptions.UseVisualStyleBackColor = True
        '
        'ucrVariablesAsFactorForBoxplot
        '
        Me.ucrVariablesAsFactorForBoxplot.frmParent = Me
        Me.ucrVariablesAsFactorForBoxplot.Location = New System.Drawing.Point(254, 67)
        Me.ucrVariablesAsFactorForBoxplot.Name = "ucrVariablesAsFactorForBoxplot"
        Me.ucrVariablesAsFactorForBoxplot.Selector = Nothing
        Me.ucrVariablesAsFactorForBoxplot.Size = New System.Drawing.Size(120, 130)
        Me.ucrVariablesAsFactorForBoxplot.TabIndex = 1
        Me.ucrVariablesAsFactorForBoxplot.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForBoxplot.ucrVariableSelector = Nothing
        '
        'ucrSecondFactorReceiver
        '
        Me.ucrSecondFactorReceiver.frmParent = Me
        Me.ucrSecondFactorReceiver.Location = New System.Drawing.Point(254, 257)
        Me.ucrSecondFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondFactorReceiver.Name = "ucrSecondFactorReceiver"
        Me.ucrSecondFactorReceiver.Selector = Nothing
        Me.ucrSecondFactorReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrSecondFactorReceiver.TabIndex = 5
        Me.ucrSecondFactorReceiver.ucrSelector = Nothing
        '
        'ucrSelectorBoxPlot
        '
        Me.ucrSelectorBoxPlot.bShowHiddenColumns = False
        Me.ucrSelectorBoxPlot.bUseCurrentFilter = True
        Me.ucrSelectorBoxPlot.Location = New System.Drawing.Point(10, 50)
        Me.ucrSelectorBoxPlot.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorBoxPlot.Name = "ucrSelectorBoxPlot"
        Me.ucrSelectorBoxPlot.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorBoxPlot.TabIndex = 0
        '
        'ucrByFactorsReceiver
        '
        Me.ucrByFactorsReceiver.frmParent = Me
        Me.ucrByFactorsReceiver.Location = New System.Drawing.Point(254, 214)
        Me.ucrByFactorsReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrByFactorsReceiver.Name = "ucrByFactorsReceiver"
        Me.ucrByFactorsReceiver.Selector = Nothing
        Me.ucrByFactorsReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrByFactorsReceiver.TabIndex = 3
        Me.ucrByFactorsReceiver.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 363)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 9
        '
        'rdoBoxplot
        '
        Me.rdoBoxplot.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBoxplot.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoxplot.FlatAppearance.BorderSize = 2
        Me.rdoBoxplot.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoxplot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBoxplot.Location = New System.Drawing.Point(100, 13)
        Me.rdoBoxplot.Name = "rdoBoxplot"
        Me.rdoBoxplot.Size = New System.Drawing.Size(90, 24)
        Me.rdoBoxplot.TabIndex = 12
        Me.rdoBoxplot.TabStop = True
        Me.rdoBoxplot.Text = "Boxplot"
        Me.rdoBoxplot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBoxplot.UseVisualStyleBackColor = True
        '
        'rdoJitter
        '
        Me.rdoJitter.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoJitter.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoJitter.FlatAppearance.BorderSize = 2
        Me.rdoJitter.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoJitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoJitter.Location = New System.Drawing.Point(188, 13)
        Me.rdoJitter.Name = "rdoJitter"
        Me.rdoJitter.Size = New System.Drawing.Size(90, 24)
        Me.rdoJitter.TabIndex = 13
        Me.rdoJitter.TabStop = True
        Me.rdoJitter.Text = "Jitter Plot"
        Me.rdoJitter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoJitter.UseVisualStyleBackColor = True
        '
        'rdoViolin
        '
        Me.rdoViolin.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoViolin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoViolin.FlatAppearance.BorderSize = 2
        Me.rdoViolin.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoViolin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoViolin.Location = New System.Drawing.Point(276, 13)
        Me.rdoViolin.Name = "rdoViolin"
        Me.rdoViolin.Size = New System.Drawing.Size(90, 24)
        Me.rdoViolin.TabIndex = 14
        Me.rdoViolin.TabStop = True
        Me.rdoViolin.Text = "Violin Plot"
        Me.rdoViolin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoViolin.UseVisualStyleBackColor = True
        '
        'ucrPnlPlots
        '
        Me.ucrPnlPlots.Location = New System.Drawing.Point(100, 11)
        Me.ucrPnlPlots.Name = "ucrPnlPlots"
        Me.ucrPnlPlots.Size = New System.Drawing.Size(274, 34)
        Me.ucrPnlPlots.TabIndex = 15
        '
        'ucrChkVarwidth
        '
        Me.ucrChkVarwidth.Checked = False
        Me.ucrChkVarwidth.Location = New System.Drawing.Point(254, 305)
        Me.ucrChkVarwidth.Name = "ucrChkVarwidth"
        Me.ucrChkVarwidth.Size = New System.Drawing.Size(135, 20)
        Me.ucrChkVarwidth.TabIndex = 16
        '
        'ucrChkHorizontalBoxplot
        '
        Me.ucrChkHorizontalBoxplot.Checked = False
        Me.ucrChkHorizontalBoxplot.Location = New System.Drawing.Point(10, 305)
        Me.ucrChkHorizontalBoxplot.Name = "ucrChkHorizontalBoxplot"
        Me.ucrChkHorizontalBoxplot.Size = New System.Drawing.Size(135, 20)
        Me.ucrChkHorizontalBoxplot.TabIndex = 17
        '
        'ucrSaveBoxplot
        '
        Me.ucrSaveBoxplot.Location = New System.Drawing.Point(10, 337)
        Me.ucrSaveBoxplot.Name = "ucrSaveBoxplot"
        Me.ucrSaveBoxplot.Size = New System.Drawing.Size(243, 24)
        Me.ucrSaveBoxplot.TabIndex = 18
        '
        'dlgBoxplot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 418)
        Me.Controls.Add(Me.ucrSaveBoxplot)
        Me.Controls.Add(Me.ucrChkHorizontalBoxplot)
        Me.Controls.Add(Me.ucrChkVarwidth)
        Me.Controls.Add(Me.rdoViolin)
        Me.Controls.Add(Me.rdoJitter)
        Me.Controls.Add(Me.rdoBoxplot)
        Me.Controls.Add(Me.ucrVariablesAsFactorForBoxplot)
        Me.Controls.Add(Me.cmdBoxPlotOptions)
        Me.Controls.Add(Me.ucrSecondFactorReceiver)
        Me.Controls.Add(Me.ucrSelectorBoxPlot)
        Me.Controls.Add(Me.lblBySecondFactor)
        Me.Controls.Add(Me.lblByFactors)
        Me.Controls.Add(Me.ucrByFactorsReceiver)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlPlots)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgBoxplot"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Boxplot"
        Me.Text = "Boxplot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrByFactorsReceiver As ucrReceiverSingle
    Friend WithEvents lblByFactors As Label
    Friend WithEvents ucrSelectorBoxPlot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSecondFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblBySecondFactor As Label
    Friend WithEvents cmdBoxPlotOptions As Button
    Friend WithEvents ucrVariablesAsFactorForBoxplot As ucrVariablesAsFactor
    Friend WithEvents rdoBoxplot As RadioButton
    Friend WithEvents rdoJitter As RadioButton
    Friend WithEvents rdoViolin As RadioButton
    Friend WithEvents ucrSaveBoxplot As ucrSave
    Friend WithEvents ucrChkHorizontalBoxplot As ucrCheck
    Friend WithEvents ucrChkVarwidth As ucrCheck
    Friend WithEvents ucrPnlPlots As UcrPanel
End Class
