<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cmdOptions
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
        Me.rdoBarChart = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.ucrSummarybarSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrYReceiver = New instat.ucrReceiverSingle()
        Me.ucrFactorReceiver = New instat.ucrReceiverSingle()
        Me.lblYvariable = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.cmdPieChartOptions = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 260)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'rdoBarChart
        '
        Me.rdoBarChart.AutoSize = True
        Me.rdoBarChart.Location = New System.Drawing.Point(24, 13)
        Me.rdoBarChart.Name = "rdoBarChart"
        Me.rdoBarChart.Size = New System.Drawing.Size(69, 17)
        Me.rdoBarChart.TabIndex = 1
        Me.rdoBarChart.TabStop = True
        Me.rdoBarChart.Tag = "Bar_Chart"
        Me.rdoBarChart.Text = "Bar Chart"
        Me.rdoBarChart.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(190, 12)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Pie Chart"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'ucrSummarybarSelector
        '
        Me.ucrSummarybarSelector.Location = New System.Drawing.Point(12, 38)
        Me.ucrSummarybarSelector.Name = "ucrSummarybarSelector"
        Me.ucrSummarybarSelector.Size = New System.Drawing.Size(242, 179)
        Me.ucrSummarybarSelector.TabIndex = 2
        '
        'ucrYReceiver
        '
        Me.ucrYReceiver.Location = New System.Drawing.Point(287, 92)
        Me.ucrYReceiver.Name = "ucrYReceiver"
        Me.ucrYReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrYReceiver.TabIndex = 3
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.Location = New System.Drawing.Point(287, 148)
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrFactorReceiver.TabIndex = 4
        '
        'lblYvariable
        '
        Me.lblYvariable.AutoSize = True
        Me.lblYvariable.Location = New System.Drawing.Point(284, 65)
        Me.lblYvariable.Name = "lblYvariable"
        Me.lblYvariable.Size = New System.Drawing.Size(54, 13)
        Me.lblYvariable.TabIndex = 5
        Me.lblYvariable.Tag = "Yvariable"
        Me.lblYvariable.Text = "Y variable"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(293, 132)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(37, 13)
        Me.lblFactor.TabIndex = 5
        Me.lblFactor.Tag = "Factor"
        Me.lblFactor.Text = "Factor"
        '
        'cmdPieChartOptions
        '
        Me.cmdPieChartOptions.Location = New System.Drawing.Point(12, 222)
        Me.cmdPieChartOptions.Name = "cmdPieChartOptions"
        Me.cmdPieChartOptions.Size = New System.Drawing.Size(128, 23)
        Me.cmdPieChartOptions.TabIndex = 6
        Me.cmdPieChartOptions.Tag = "Pie_Chart_Options"
        Me.cmdPieChartOptions.Text = "Pie Chart Options"
        Me.cmdPieChartOptions.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(287, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 319)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdPieChartOptions)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblYvariable)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.ucrYReceiver)
        Me.Controls.Add(Me.ucrSummarybarSelector)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.rdoBarChart)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "cmdOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Options"
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents rdoBarChart As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents ucrSummarybarSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrYReceiver As ucrReceiverSingle
    Friend WithEvents ucrFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblYvariable As Label
    Friend WithEvents lblFactor As Label
    Friend WithEvents cmdPieChartOptions As Button
    Friend WithEvents Button1 As Button
End Class
