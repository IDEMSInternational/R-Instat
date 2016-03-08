<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgHistogram
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
        Me.lblVariableToPlot = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.cmdHistogramOptions = New System.Windows.Forms.Button()
        Me.rdoHistogram = New System.Windows.Forms.RadioButton()
        Me.rdoDensity = New System.Windows.Forms.RadioButton()
        Me.rdoFreequencyPolygon = New System.Windows.Forms.RadioButton()
        Me.lblfactor = New System.Windows.Forms.Label()
        Me.cmdDensityOptions = New System.Windows.Forms.Button()
        Me.cmdFrequencyOptions = New System.Windows.Forms.Button()
        Me.ucrFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrHistogramSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrXReceiver = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'lblVariableToPlot
        '
        Me.lblVariableToPlot.AutoSize = True
        Me.lblVariableToPlot.Location = New System.Drawing.Point(288, 63)
        Me.lblVariableToPlot.Name = "lblVariableToPlot"
        Me.lblVariableToPlot.Size = New System.Drawing.Size(78, 13)
        Me.lblVariableToPlot.TabIndex = 4
        Me.lblVariableToPlot.Tag = "Variable_to_Plot"
        Me.lblVariableToPlot.Text = "Variable to Plot"
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(255, 215)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdOptions.TabIndex = 9
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdHistogramOptions
        '
        Me.cmdHistogramOptions.Location = New System.Drawing.Point(254, 186)
        Me.cmdHistogramOptions.Name = "cmdHistogramOptions"
        Me.cmdHistogramOptions.Size = New System.Drawing.Size(103, 23)
        Me.cmdHistogramOptions.TabIndex = 8
        Me.cmdHistogramOptions.Tag = "Histogram_Options"
        Me.cmdHistogramOptions.Text = "Histogram Options"
        Me.cmdHistogramOptions.UseVisualStyleBackColor = True
        '
        'rdoHistogram
        '
        Me.rdoHistogram.AutoSize = True
        Me.rdoHistogram.Location = New System.Drawing.Point(22, 13)
        Me.rdoHistogram.Name = "rdoHistogram"
        Me.rdoHistogram.Size = New System.Drawing.Size(72, 17)
        Me.rdoHistogram.TabIndex = 0
        Me.rdoHistogram.TabStop = True
        Me.rdoHistogram.Tag = "Histogram"
        Me.rdoHistogram.Text = "Histogram"
        Me.rdoHistogram.UseVisualStyleBackColor = True
        '
        'rdoDensity
        '
        Me.rdoDensity.AutoSize = True
        Me.rdoDensity.Location = New System.Drawing.Point(168, 13)
        Me.rdoDensity.Name = "rdoDensity"
        Me.rdoDensity.Size = New System.Drawing.Size(60, 17)
        Me.rdoDensity.TabIndex = 1
        Me.rdoDensity.TabStop = True
        Me.rdoDensity.Tag = "Density"
        Me.rdoDensity.Text = "Density"
        Me.rdoDensity.UseVisualStyleBackColor = True
        '
        'rdoFreequencyPolygon
        '
        Me.rdoFreequencyPolygon.AutoSize = True
        Me.rdoFreequencyPolygon.Location = New System.Drawing.Point(302, 13)
        Me.rdoFreequencyPolygon.Name = "rdoFreequencyPolygon"
        Me.rdoFreequencyPolygon.Size = New System.Drawing.Size(116, 17)
        Me.rdoFreequencyPolygon.TabIndex = 2
        Me.rdoFreequencyPolygon.TabStop = True
        Me.rdoFreequencyPolygon.Tag = "Frequency_Polygon"
        Me.rdoFreequencyPolygon.Text = "Frequency Polygon"
        Me.rdoFreequencyPolygon.UseVisualStyleBackColor = True
        '
        'lblfactor
        '
        Me.lblfactor.AutoSize = True
        Me.lblfactor.Location = New System.Drawing.Point(293, 126)
        Me.lblfactor.Name = "lblfactor"
        Me.lblfactor.Size = New System.Drawing.Size(37, 13)
        Me.lblfactor.TabIndex = 6
        Me.lblfactor.Tag = "Factor"
        Me.lblfactor.Text = "Factor"
        '
        'cmdDensityOptions
        '
        Me.cmdDensityOptions.Location = New System.Drawing.Point(254, 186)
        Me.cmdDensityOptions.Name = "cmdDensityOptions"
        Me.cmdDensityOptions.Size = New System.Drawing.Size(103, 23)
        Me.cmdDensityOptions.TabIndex = 8
        Me.cmdDensityOptions.Tag = "Density_Options"
        Me.cmdDensityOptions.Text = "Density Options"
        Me.cmdDensityOptions.UseVisualStyleBackColor = True
        '
        'cmdFrequencyOptions
        '
        Me.cmdFrequencyOptions.Location = New System.Drawing.Point(255, 186)
        Me.cmdFrequencyOptions.Name = "cmdFrequencyOptions"
        Me.cmdFrequencyOptions.Size = New System.Drawing.Size(163, 23)
        Me.cmdFrequencyOptions.TabIndex = 8
        Me.cmdFrequencyOptions.Tag = "Frequency_Polygon_Options"
        Me.cmdFrequencyOptions.Text = "Frequency Polygon Options"
        Me.cmdFrequencyOptions.UseVisualStyleBackColor = True
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.Location = New System.Drawing.Point(286, 142)
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Selector = Nothing
        Me.ucrFactorReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrFactorReceiver.TabIndex = 7
        '
        'ucrHistogramSelector
        '
        Me.ucrHistogramSelector.Location = New System.Drawing.Point(6, 42)
        Me.ucrHistogramSelector.Name = "ucrHistogramSelector"
        Me.ucrHistogramSelector.Size = New System.Drawing.Size(242, 179)
        Me.ucrHistogramSelector.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 241)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 58)
        Me.ucrBase.TabIndex = 10
        '
        'ucrXReceiver
        '
        Me.ucrXReceiver.Location = New System.Drawing.Point(286, 82)
        Me.ucrXReceiver.Name = "ucrXReceiver"
        Me.ucrXReceiver.Selector = Nothing
        Me.ucrXReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrXReceiver.TabIndex = 5
        '
        'dlgHistogram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 294)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.rdoFreequencyPolygon)
        Me.Controls.Add(Me.rdoDensity)
        Me.Controls.Add(Me.rdoHistogram)
        Me.Controls.Add(Me.cmdFrequencyOptions)
        Me.Controls.Add(Me.cmdDensityOptions)
        Me.Controls.Add(Me.cmdHistogramOptions)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrHistogramSelector)
        Me.Controls.Add(Me.lblfactor)
        Me.Controls.Add(Me.lblVariableToPlot)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrXReceiver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgHistogram"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Histogram"
        Me.Text = "Histogram Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrXReceiver As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblVariableToPlot As Label
    Friend WithEvents ucrHistogramSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdOptions As Button
    Friend WithEvents cmdHistogramOptions As Button
    Friend WithEvents rdoHistogram As RadioButton
    Friend WithEvents rdoDensity As RadioButton
    Friend WithEvents rdoFreequencyPolygon As RadioButton
    Friend WithEvents ucrFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblfactor As Label
    Friend WithEvents cmdDensityOptions As Button
    Friend WithEvents cmdFrequencyOptions As Button
End Class
