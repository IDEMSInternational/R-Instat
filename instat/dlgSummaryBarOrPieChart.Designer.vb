<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgSummaryBarOrPieChart
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrYReceiver = New instat.ucrReceiverSingle()
        Me.ucrFactorReceiver = New instat.ucrReceiverSingle()
        Me.lblYvariable = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.cmdBarChartOptions = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrSecondFactorReceiver = New instat.ucrReceiverSingle()
        Me.lblSecondFactor = New System.Windows.Forms.Label()
        Me.cmdPieChartOptions = New System.Windows.Forms.Button()
        Me.ucrSummarybarSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSaveSummaryBar = New instat.ucrSave()
        Me.rdoBarChart = New System.Windows.Forms.RadioButton()
        Me.rdoPieChart = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 316)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 11
        '
        'ucrYReceiver
        '
        Me.ucrYReceiver.frmParent = Me
        Me.ucrYReceiver.Location = New System.Drawing.Point(255, 85)
        Me.ucrYReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrYReceiver.Name = "ucrYReceiver"
        Me.ucrYReceiver.Selector = Nothing
        Me.ucrYReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrYReceiver.TabIndex = 3
        Me.ucrYReceiver.ucrSelector = Nothing
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.frmParent = Me
        Me.ucrFactorReceiver.Location = New System.Drawing.Point(255, 131)
        Me.ucrFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Selector = Nothing
        Me.ucrFactorReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrFactorReceiver.TabIndex = 5
        Me.ucrFactorReceiver.ucrSelector = Nothing
        '
        'lblYvariable
        '
        Me.lblYvariable.AutoSize = True
        Me.lblYvariable.Location = New System.Drawing.Point(256, 70)
        Me.lblYvariable.Name = "lblYvariable"
        Me.lblYvariable.Size = New System.Drawing.Size(58, 13)
        Me.lblYvariable.TabIndex = 2
        Me.lblYvariable.Tag = "Y_Variable:"
        Me.lblYvariable.Text = "Y Variable:"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(256, 116)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(40, 13)
        Me.lblFactor.TabIndex = 4
        Me.lblFactor.Tag = "Factor:"
        Me.lblFactor.Text = "Factor:"
        '
        'cmdBarChartOptions
        '
        Me.cmdBarChartOptions.Location = New System.Drawing.Point(10, 228)
        Me.cmdBarChartOptions.Name = "cmdBarChartOptions"
        Me.cmdBarChartOptions.Size = New System.Drawing.Size(121, 23)
        Me.cmdBarChartOptions.TabIndex = 8
        Me.cmdBarChartOptions.Tag = "Bar_Chart_Options"
        Me.cmdBarChartOptions.Text = "Bar Chart Options"
        Me.cmdBarChartOptions.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(10, 257)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(121, 23)
        Me.cmdOptions.TabIndex = 9
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrSecondFactorReceiver
        '
        Me.ucrSecondFactorReceiver.frmParent = Me
        Me.ucrSecondFactorReceiver.Location = New System.Drawing.Point(255, 178)
        Me.ucrSecondFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondFactorReceiver.Name = "ucrSecondFactorReceiver"
        Me.ucrSecondFactorReceiver.Selector = Nothing
        Me.ucrSecondFactorReceiver.Size = New System.Drawing.Size(120, 26)
        Me.ucrSecondFactorReceiver.TabIndex = 7
        Me.ucrSecondFactorReceiver.ucrSelector = Nothing
        '
        'lblSecondFactor
        '
        Me.lblSecondFactor.AutoSize = True
        Me.lblSecondFactor.Location = New System.Drawing.Point(256, 163)
        Me.lblSecondFactor.Name = "lblSecondFactor"
        Me.lblSecondFactor.Size = New System.Drawing.Size(80, 13)
        Me.lblSecondFactor.TabIndex = 6
        Me.lblSecondFactor.Tag = "Second+Factor:"
        Me.lblSecondFactor.Text = "Second Factor:"
        '
        'cmdPieChartOptions
        '
        Me.cmdPieChartOptions.Location = New System.Drawing.Point(10, 228)
        Me.cmdPieChartOptions.Name = "cmdPieChartOptions"
        Me.cmdPieChartOptions.Size = New System.Drawing.Size(121, 23)
        Me.cmdPieChartOptions.TabIndex = 8
        Me.cmdPieChartOptions.Tag = "Pie_Chart_Options"
        Me.cmdPieChartOptions.Text = "Pie Chart Options"
        Me.cmdPieChartOptions.UseVisualStyleBackColor = True
        '
        'ucrSummarybarSelector
        '
        Me.ucrSummarybarSelector.bShowHiddenColumns = False
        Me.ucrSummarybarSelector.bUseCurrentFilter = True
        Me.ucrSummarybarSelector.Location = New System.Drawing.Point(10, 40)
        Me.ucrSummarybarSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSummarybarSelector.Name = "ucrSummarybarSelector"
        Me.ucrSummarybarSelector.Size = New System.Drawing.Size(242, 192)
        Me.ucrSummarybarSelector.TabIndex = 1
        '
        'ucrSaveSummaryBar
        '
        Me.ucrSaveSummaryBar.Location = New System.Drawing.Point(10, 286)
        Me.ucrSaveSummaryBar.Name = "ucrSaveSummaryBar"
        Me.ucrSaveSummaryBar.Size = New System.Drawing.Size(365, 24)
        Me.ucrSaveSummaryBar.TabIndex = 12
        '
        'rdoBarChart
        '
        Me.rdoBarChart.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBarChart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBarChart.FlatAppearance.BorderSize = 2
        Me.rdoBarChart.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBarChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBarChart.Location = New System.Drawing.Point(92, 9)
        Me.rdoBarChart.Name = "rdoBarChart"
        Me.rdoBarChart.Size = New System.Drawing.Size(100, 27)
        Me.rdoBarChart.TabIndex = 0
        Me.rdoBarChart.TabStop = True
        Me.rdoBarChart.Tag = "Bar_Chart"
        Me.rdoBarChart.Text = "Bar Chart"
        Me.rdoBarChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBarChart.UseVisualStyleBackColor = True
        '
        'rdoPieChart
        '
        Me.rdoPieChart.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPieChart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPieChart.FlatAppearance.BorderSize = 2
        Me.rdoPieChart.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPieChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPieChart.Location = New System.Drawing.Point(191, 9)
        Me.rdoPieChart.Name = "rdoPieChart"
        Me.rdoPieChart.Size = New System.Drawing.Size(100, 27)
        Me.rdoPieChart.TabIndex = 1
        Me.rdoPieChart.TabStop = True
        Me.rdoPieChart.Text = "Pie Chart"
        Me.rdoPieChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPieChart.UseVisualStyleBackColor = True
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.Location = New System.Drawing.Point(80, 2)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(216, 35)
        Me.ucrPnlOptions.TabIndex = 13
        '
        'dlgSummaryBarOrPieChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 371)
        Me.Controls.Add(Me.rdoPieChart)
        Me.Controls.Add(Me.ucrSaveSummaryBar)
        Me.Controls.Add(Me.rdoBarChart)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.cmdPieChartOptions)
        Me.Controls.Add(Me.cmdBarChartOptions)
        Me.Controls.Add(Me.lblSecondFactor)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrSecondFactorReceiver)
        Me.Controls.Add(Me.lblYvariable)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.ucrYReceiver)
        Me.Controls.Add(Me.ucrSummarybarSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSummaryBarOrPieChart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Bar_or_Pie_Chart_From_Summary"
        Me.Text = "Bar or Pie Chart From Summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSummarybarSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrYReceiver As ucrReceiverSingle
    Friend WithEvents ucrFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblYvariable As Label
    Friend WithEvents lblFactor As Label
    Friend WithEvents cmdBarChartOptions As Button
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrSecondFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblSecondFactor As Label
    Friend WithEvents cmdPieChartOptions As Button
    Friend WithEvents rdoPieChart As RadioButton
    Friend WithEvents ucrSaveSummaryBar As ucrSave
    Friend WithEvents rdoBarChart As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
End Class
