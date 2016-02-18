<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgBarAndPieChart
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
        Me.ucrBarChartSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrSecondReceiver = New instat.ucrReceiverSingle()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.lblSecondFactor = New System.Windows.Forms.Label()
        Me.cmdBarChartOptions = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.rdoBarChart = New System.Windows.Forms.RadioButton()
        Me.rdoPieChart = New System.Windows.Forms.RadioButton()
        Me.grpSelection = New System.Windows.Forms.GroupBox()
        Me.grpSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(8, 262)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrBarChartSelector
        '
        Me.ucrBarChartSelector.Location = New System.Drawing.Point(12, 36)
        Me.ucrBarChartSelector.Name = "ucrBarChartSelector"
        Me.ucrBarChartSelector.Size = New System.Drawing.Size(242, 179)
        Me.ucrBarChartSelector.TabIndex = 2
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.Location = New System.Drawing.Point(283, 81)
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrFactorReceiver.TabIndex = 3
        '
        'ucrSecondReceiver
        '
        Me.ucrSecondReceiver.Location = New System.Drawing.Point(283, 139)
        Me.ucrSecondReceiver.Name = "ucrSecondReceiver"
        Me.ucrSecondReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrSecondReceiver.TabIndex = 3
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(290, 56)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(40, 13)
        Me.lblFactor.TabIndex = 4
        Me.lblFactor.Tag = "Factor"
        Me.lblFactor.Text = "Factor "
        '
        'lblSecondFactor
        '
        Me.lblSecondFactor.AutoSize = True
        Me.lblSecondFactor.Location = New System.Drawing.Point(283, 123)
        Me.lblSecondFactor.Name = "lblSecondFactor"
        Me.lblSecondFactor.Size = New System.Drawing.Size(77, 13)
        Me.lblSecondFactor.TabIndex = 4
        Me.lblSecondFactor.Tag = "Second_Factor"
        Me.lblSecondFactor.Text = "Second Factor"
        '
        'cmdBarChartOptions
        '
        Me.cmdBarChartOptions.Location = New System.Drawing.Point(17, 222)
        Me.cmdBarChartOptions.Name = "cmdBarChartOptions"
        Me.cmdBarChartOptions.Size = New System.Drawing.Size(118, 23)
        Me.cmdBarChartOptions.TabIndex = 5
        Me.cmdBarChartOptions.Tag = "Bar_Chart_Options"
        Me.cmdBarChartOptions.Text = "Bar Chart Options"
        Me.cmdBarChartOptions.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(313, 221)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdOptions.TabIndex = 6
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'rdoBarChart
        '
        Me.rdoBarChart.AutoSize = True
        Me.rdoBarChart.Location = New System.Drawing.Point(5, 12)
        Me.rdoBarChart.Name = "rdoBarChart"
        Me.rdoBarChart.Size = New System.Drawing.Size(69, 17)
        Me.rdoBarChart.TabIndex = 1
        Me.rdoBarChart.TabStop = True
        Me.rdoBarChart.Tag = "Bar_Chart"
        Me.rdoBarChart.Text = "Bar Chart"
        Me.rdoBarChart.UseVisualStyleBackColor = True
        '
        'rdoPieChart
        '
        Me.rdoPieChart.AutoSize = True
        Me.rdoPieChart.Location = New System.Drawing.Point(103, 12)
        Me.rdoPieChart.Name = "rdoPieChart"
        Me.rdoPieChart.Size = New System.Drawing.Size(68, 17)
        Me.rdoPieChart.TabIndex = 1
        Me.rdoPieChart.TabStop = True
        Me.rdoPieChart.Tag = "Pie_Chart"
        Me.rdoPieChart.Text = "Pie Chart"
        Me.rdoPieChart.UseVisualStyleBackColor = True
        '
        'grpSelection
        '
        Me.grpSelection.Controls.Add(Me.rdoBarChart)
        Me.grpSelection.Controls.Add(Me.rdoPieChart)
        Me.grpSelection.Location = New System.Drawing.Point(12, 0)
        Me.grpSelection.Name = "grpSelection"
        Me.grpSelection.Size = New System.Drawing.Size(200, 39)
        Me.grpSelection.TabIndex = 8
        Me.grpSelection.TabStop = False
        '
        'dlgBarAndPieChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 317)
        Me.Controls.Add(Me.grpSelection)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.cmdBarChartOptions)
        Me.Controls.Add(Me.lblSecondFactor)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrSecondReceiver)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.ucrBarChartSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgBarAndPieChart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Bar_And_Pie_Chart"
        Me.Text = "Bar And Pie Chart"
        Me.grpSelection.ResumeLayout(False)
        Me.grpSelection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrBarChartSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFactorReceiver As ucrReceiverSingle
    Friend WithEvents ucrSecondReceiver As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents lblSecondFactor As Label
    Friend WithEvents cmdBarChartOptions As Button
    Friend WithEvents cmdOptions As Button
    Friend WithEvents rdoBarChart As RadioButton
    Friend WithEvents rdoPieChart As RadioButton
    Friend WithEvents grpSelection As GroupBox
End Class
