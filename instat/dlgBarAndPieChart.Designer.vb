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
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.lblSecondFactor = New System.Windows.Forms.Label()
        Me.cmdBarChartOptions = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.cmdPieChartOptions = New System.Windows.Forms.Button()
        Me.ucrSecondReceiver = New instat.ucrReceiverSingle()
        Me.ucrFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrBarChartSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveBar = New instat.ucrSaveGraph()
        Me.rdoPieChart = New System.Windows.Forms.RadioButton()
        Me.rdoBarChart = New System.Windows.Forms.RadioButton()
        Me.grpSelection = New System.Windows.Forms.GroupBox()
        Me.chkFlipCoordinates = New System.Windows.Forms.CheckBox()
        Me.grpSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(255, 69)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(40, 13)
        Me.lblFactor.TabIndex = 2
        Me.lblFactor.Tag = "Factor:"
        Me.lblFactor.Text = "Factor:"
        '
        'lblSecondFactor
        '
        Me.lblSecondFactor.AutoSize = True
        Me.lblSecondFactor.Location = New System.Drawing.Point(254, 120)
        Me.lblSecondFactor.Name = "lblSecondFactor"
        Me.lblSecondFactor.Size = New System.Drawing.Size(128, 13)
        Me.lblSecondFactor.TabIndex = 4
        Me.lblSecondFactor.Tag = "Second_Factor:"
        Me.lblSecondFactor.Text = "Second Factor (Optional):"
        '
        'cmdBarChartOptions
        '
        Me.cmdBarChartOptions.Location = New System.Drawing.Point(11, 230)
        Me.cmdBarChartOptions.Name = "cmdBarChartOptions"
        Me.cmdBarChartOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdBarChartOptions.TabIndex = 6
        Me.cmdBarChartOptions.Tag = "Bar_Chart_Options"
        Me.cmdBarChartOptions.Text = "Bar Chart Options"
        Me.cmdBarChartOptions.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(10, 262)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdOptions.TabIndex = 7
        Me.cmdOptions.Tag = "Plot_Options..."
        Me.cmdOptions.Text = "Plot Options..."
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdPieChartOptions
        '
        Me.cmdPieChartOptions.Location = New System.Drawing.Point(12, 231)
        Me.cmdPieChartOptions.Name = "cmdPieChartOptions"
        Me.cmdPieChartOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdPieChartOptions.TabIndex = 9
        Me.cmdPieChartOptions.Tag = "Pie_Chart_Options"
        Me.cmdPieChartOptions.Text = "Pie Chart Options"
        Me.cmdPieChartOptions.UseVisualStyleBackColor = True
        '
        'ucrSecondReceiver
        '
        Me.ucrSecondReceiver.Location = New System.Drawing.Point(255, 135)
        Me.ucrSecondReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondReceiver.Name = "ucrSecondReceiver"
        Me.ucrSecondReceiver.Selector = Nothing
        Me.ucrSecondReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrSecondReceiver.TabIndex = 5
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.Location = New System.Drawing.Point(255, 85)
        Me.ucrFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Selector = Nothing
        Me.ucrFactorReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrFactorReceiver.TabIndex = 3
        '
        'ucrBarChartSelector
        '
        Me.ucrBarChartSelector.bShowHiddenColumns = False
        Me.ucrBarChartSelector.bUseCurrentFilter = True
        Me.ucrBarChartSelector.Location = New System.Drawing.Point(10, 41)
        Me.ucrBarChartSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrBarChartSelector.Name = "ucrBarChartSelector"
        Me.ucrBarChartSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrBarChartSelector.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 322)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 9
        '
        'ucrSaveBar
        '
        Me.ucrSaveBar.Location = New System.Drawing.Point(10, 295)
        Me.ucrSaveBar.Name = "ucrSaveBar"
        Me.ucrSaveBar.Size = New System.Drawing.Size(265, 20)
        Me.ucrSaveBar.TabIndex = 8
        '
        'rdoPieChart
        '
        Me.rdoPieChart.AutoSize = True
        Me.rdoPieChart.Location = New System.Drawing.Point(280, 10)
        Me.rdoPieChart.Name = "rdoPieChart"
        Me.rdoPieChart.Size = New System.Drawing.Size(68, 17)
        Me.rdoPieChart.TabIndex = 1
        Me.rdoPieChart.TabStop = True
        Me.rdoPieChart.Tag = "Pie_Chart"
        Me.rdoPieChart.Text = "Pie Chart"
        Me.rdoPieChart.UseVisualStyleBackColor = True
        '
        'rdoBarChart
        '
        Me.rdoBarChart.AutoSize = True
        Me.rdoBarChart.Location = New System.Drawing.Point(10, 10)
        Me.rdoBarChart.Name = "rdoBarChart"
        Me.rdoBarChart.Size = New System.Drawing.Size(69, 17)
        Me.rdoBarChart.TabIndex = 0
        Me.rdoBarChart.TabStop = True
        Me.rdoBarChart.Tag = "Bar_Chart"
        Me.rdoBarChart.Text = "Bar Chart"
        Me.rdoBarChart.UseVisualStyleBackColor = True
        '
        'grpSelection
        '
        Me.grpSelection.Controls.Add(Me.rdoBarChart)
        Me.grpSelection.Controls.Add(Me.rdoPieChart)
        Me.grpSelection.Location = New System.Drawing.Point(10, 4)
        Me.grpSelection.Name = "grpSelection"
        Me.grpSelection.Size = New System.Drawing.Size(397, 31)
        Me.grpSelection.TabIndex = 0
        Me.grpSelection.TabStop = False
        '
        'chkFlipCoordinates
        '
        Me.chkFlipCoordinates.AutoSize = True
        Me.chkFlipCoordinates.Location = New System.Drawing.Point(258, 249)
        Me.chkFlipCoordinates.Name = "chkFlipCoordinates"
        Me.chkFlipCoordinates.Size = New System.Drawing.Size(100, 17)
        Me.chkFlipCoordinates.TabIndex = 10
        Me.chkFlipCoordinates.Tag = "Horizontal_Boxplot"
        Me.chkFlipCoordinates.Text = "Flip coordinates"
        Me.chkFlipCoordinates.UseVisualStyleBackColor = True
        '
        'dlgBarAndPieChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 379)
        Me.Controls.Add(Me.chkFlipCoordinates)
        Me.Controls.Add(Me.ucrSaveBar)
        Me.Controls.Add(Me.grpSelection)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblSecondFactor)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrSecondReceiver)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.ucrBarChartSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.cmdBarChartOptions)
        Me.Controls.Add(Me.cmdPieChartOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgBarAndPieChart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Bar_And_Pie_Chart"
        Me.Text = "Bar and Pie Chart"
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
    Friend WithEvents cmdPieChartOptions As Button
    Friend WithEvents ucrSaveBar As ucrSaveGraph
    Friend WithEvents rdoPieChart As RadioButton
    Friend WithEvents rdoBarChart As RadioButton
    Friend WithEvents grpSelection As GroupBox
    Friend WithEvents chkFlipCoordinates As CheckBox
End Class
