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
        Me.ucrSaveHist = New instat.ucrSaveGraph()
        Me.ucrVariablesAsFactorforHist = New instat.ucrVariablesAsFactor()
        Me.SuspendLayout()
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(10, 263)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdOptions.TabIndex = 8
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdHistogramOptions
        '
        Me.cmdHistogramOptions.Location = New System.Drawing.Point(10, 228)
        Me.cmdHistogramOptions.Name = "cmdHistogramOptions"
        Me.cmdHistogramOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdHistogramOptions.TabIndex = 8
        Me.cmdHistogramOptions.Tag = "Histogram_Options"
        Me.cmdHistogramOptions.Text = "Histogram Options"
        Me.cmdHistogramOptions.UseVisualStyleBackColor = True
        '
        'rdoHistogram
        '
        Me.rdoHistogram.AutoSize = True
        Me.rdoHistogram.Location = New System.Drawing.Point(10, 10)
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
        Me.rdoDensity.Location = New System.Drawing.Point(125, 10)
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
        Me.rdoFreequencyPolygon.Location = New System.Drawing.Point(255, 10)
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
        Me.lblfactor.Location = New System.Drawing.Point(255, 196)
        Me.lblfactor.Name = "lblfactor"
        Me.lblfactor.Size = New System.Drawing.Size(37, 13)
        Me.lblfactor.TabIndex = 5
        Me.lblfactor.Tag = "Factor"
        Me.lblfactor.Text = "Factor"
        '
        'cmdDensityOptions
        '
        Me.cmdDensityOptions.Location = New System.Drawing.Point(10, 228)
        Me.cmdDensityOptions.Name = "cmdDensityOptions"
        Me.cmdDensityOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdDensityOptions.TabIndex = 8
        Me.cmdDensityOptions.Tag = "Density_Options"
        Me.cmdDensityOptions.Text = "Density Options"
        Me.cmdDensityOptions.UseVisualStyleBackColor = True
        '
        'cmdFrequencyOptions
        '
        Me.cmdFrequencyOptions.Location = New System.Drawing.Point(10, 227)
        Me.cmdFrequencyOptions.Name = "cmdFrequencyOptions"
        Me.cmdFrequencyOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdFrequencyOptions.TabIndex = 7
        Me.cmdFrequencyOptions.Tag = "Frequency_Polygon_Options"
        Me.cmdFrequencyOptions.Text = "Frequency Polygon Options"
        Me.cmdFrequencyOptions.UseVisualStyleBackColor = True
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.Location = New System.Drawing.Point(255, 212)
        Me.ucrFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Selector = Nothing
        Me.ucrFactorReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrFactorReceiver.TabIndex = 6
        '
        'ucrHistogramSelector
        '
        Me.ucrHistogramSelector.bShowHiddenColumns = False
        Me.ucrHistogramSelector.bUseCurrentFilter = False
        Me.ucrHistogramSelector.Location = New System.Drawing.Point(10, 35)
        Me.ucrHistogramSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrHistogramSelector.Name = "ucrHistogramSelector"
        Me.ucrHistogramSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrHistogramSelector.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 330)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 10
        '
        'ucrSaveHist
        '
        Me.ucrSaveHist.Location = New System.Drawing.Point(10, 299)
        Me.ucrSaveHist.Name = "ucrSaveHist"
        Me.ucrSaveHist.Size = New System.Drawing.Size(265, 20)
        Me.ucrSaveHist.TabIndex = 9
        '
        'ucrVariablesAsFactorforHist
        '
        Me.ucrVariablesAsFactorforHist.Location = New System.Drawing.Point(255, 50)
        Me.ucrVariablesAsFactorforHist.Name = "ucrVariablesAsFactorforHist"
        Me.ucrVariablesAsFactorforHist.Size = New System.Drawing.Size(125, 136)
        Me.ucrVariablesAsFactorforHist.TabIndex = 4
        Me.ucrVariablesAsFactorforHist.ucrVariableSelector = Nothing
        '
        'dlgHistogram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 384)
        Me.Controls.Add(Me.ucrVariablesAsFactorforHist)
        Me.Controls.Add(Me.ucrSaveHist)
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
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgHistogram"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Histogram"
        Me.Text = "Histogram Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
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
    Friend WithEvents ucrSaveHist As ucrSaveGraph
    Friend WithEvents ucrVariablesAsFactorforHist As ucrVariablesAsFactor
End Class
