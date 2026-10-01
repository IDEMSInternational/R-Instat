<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimaticBoxPlot
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
        Me.cmdBoxPlotOptions = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.rdoViolin = New System.Windows.Forms.RadioButton()
        Me.rdoJitter = New System.Windows.Forms.RadioButton()
        Me.rdoBoxplot = New System.Windows.Forms.RadioButton()
        Me.lblWithinYear = New System.Windows.Forms.Label()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblOutlierCoefficient = New System.Windows.Forms.Label()
        Me.ucrNudOutlierCoefficient = New instat.ucrNud()
        Me.ucrReceiverWithinYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrChkOmitBelow = New instat.ucrCheck()
        Me.ucrNudOmitBelow = New instat.ucrNud()
        Me.ucrInputWithinYear = New instat.ucrInputComboBox()
        Me.ucrInputYear = New instat.ucrInputComboBox()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucrPnlPlots = New instat.UcrPanel()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSavePlot = New instat.ucrSave()
        Me.ucrChkHorizontalBoxplot = New instat.ucrCheck()
        Me.ucrChkVarWidth = New instat.ucrCheck()
        Me.ucrSelectorClimaticBoxPlot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkLabel = New instat.ucrCheck()
        Me.ucrReceiverLabelOutliers = New instat.ucrReceiverSingle()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdBoxPlotOptions
        '
        Me.cmdBoxPlotOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBoxPlotOptions.Location = New System.Drawing.Point(15, 362)
        Me.cmdBoxPlotOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBoxPlotOptions.Name = "cmdBoxPlotOptions"
        Me.cmdBoxPlotOptions.Size = New System.Drawing.Size(249, 38)
        Me.cmdBoxPlotOptions.TabIndex = 20
        Me.cmdBoxPlotOptions.Tag = "Boxplot_Options"
        Me.cmdBoxPlotOptions.Text = "Boxplot Options"
        Me.cmdBoxPlotOptions.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(15, 408)
        Me.cmdOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(249, 38)
        Me.cmdOptions.TabIndex = 21
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'rdoViolin
        '
        Me.rdoViolin.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoViolin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoViolin.FlatAppearance.BorderSize = 2
        Me.rdoViolin.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoViolin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoViolin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoViolin.Location = New System.Drawing.Point(436, 18)
        Me.rdoViolin.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoViolin.Name = "rdoViolin"
        Me.rdoViolin.Size = New System.Drawing.Size(180, 40)
        Me.rdoViolin.TabIndex = 3
        Me.rdoViolin.TabStop = True
        Me.rdoViolin.Text = "Violin Plot"
        Me.rdoViolin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoViolin.UseVisualStyleBackColor = True
        '
        'rdoJitter
        '
        Me.rdoJitter.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoJitter.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoJitter.FlatAppearance.BorderSize = 2
        Me.rdoJitter.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoJitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoJitter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoJitter.Location = New System.Drawing.Point(260, 18)
        Me.rdoJitter.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoJitter.Name = "rdoJitter"
        Me.rdoJitter.Size = New System.Drawing.Size(180, 40)
        Me.rdoJitter.TabIndex = 2
        Me.rdoJitter.TabStop = True
        Me.rdoJitter.Text = "Jitter Plot"
        Me.rdoJitter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoJitter.UseVisualStyleBackColor = True
        '
        'rdoBoxplot
        '
        Me.rdoBoxplot.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBoxplot.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoxplot.FlatAppearance.BorderSize = 2
        Me.rdoBoxplot.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoxplot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBoxplot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBoxplot.Location = New System.Drawing.Point(82, 18)
        Me.rdoBoxplot.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoBoxplot.Name = "rdoBoxplot"
        Me.rdoBoxplot.Size = New System.Drawing.Size(180, 40)
        Me.rdoBoxplot.TabIndex = 1
        Me.rdoBoxplot.TabStop = True
        Me.rdoBoxplot.Text = "Boxplot"
        Me.rdoBoxplot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBoxplot.UseVisualStyleBackColor = True
        '
        'lblWithinYear
        '
        Me.lblWithinYear.AutoSize = True
        Me.lblWithinYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWithinYear.Location = New System.Drawing.Point(363, 396)
        Me.lblWithinYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWithinYear.Name = "lblWithinYear"
        Me.lblWithinYear.Size = New System.Drawing.Size(95, 20)
        Me.lblWithinYear.TabIndex = 17
        Me.lblWithinYear.Text = "Within Year:"
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElement.Location = New System.Drawing.Point(364, 220)
        Me.lblElement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(72, 20)
        Me.lblElement.TabIndex = 10
        Me.lblElement.Text = "Element:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYear.Location = New System.Drawing.Point(363, 330)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(47, 20)
        Me.lblYear.TabIndex = 14
        Me.lblYear.Text = "Year:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(363, 160)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 20)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Date:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(363, 99)
        Me.lblStation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(64, 20)
        Me.lblStation.TabIndex = 5
        Me.lblStation.Text = "Station:"
        '
        'lblOutlierCoefficient
        '
        Me.lblOutlierCoefficient.AutoSize = True
        Me.lblOutlierCoefficient.Location = New System.Drawing.Point(364, 476)
        Me.lblOutlierCoefficient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutlierCoefficient.Name = "lblOutlierCoefficient"
        Me.lblOutlierCoefficient.Size = New System.Drawing.Size(139, 20)
        Me.lblOutlierCoefficient.TabIndex = 27
        Me.lblOutlierCoefficient.Text = "Outlier Coefficient:"
        '
        'ucrNudOutlierCoefficient
        '
        Me.ucrNudOutlierCoefficient.AutoSize = True
        Me.ucrNudOutlierCoefficient.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudOutlierCoefficient.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudOutlierCoefficient.Location = New System.Drawing.Point(602, 470)
        Me.ucrNudOutlierCoefficient.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudOutlierCoefficient.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudOutlierCoefficient.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudOutlierCoefficient.Name = "ucrNudOutlierCoefficient"
        Me.ucrNudOutlierCoefficient.Size = New System.Drawing.Size(72, 30)
        Me.ucrNudOutlierCoefficient.TabIndex = 28
        Me.ucrNudOutlierCoefficient.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverWithinYear
        '
        Me.ucrReceiverWithinYear.AutoSize = True
        Me.ucrReceiverWithinYear.frmParent = Me
        Me.ucrReceiverWithinYear.Location = New System.Drawing.Point(368, 417)
        Me.ucrReceiverWithinYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWithinYear.Name = "ucrReceiverWithinYear"
        Me.ucrReceiverWithinYear.Selector = Nothing
        Me.ucrReceiverWithinYear.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverWithinYear.strNcFilePath = ""
        Me.ucrReceiverWithinYear.TabIndex = 18
        Me.ucrReceiverWithinYear.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(368, 352)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 15
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(368, 180)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 9
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(368, 120)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 6
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.AutoSize = True
        Me.ucrReceiverElement.frmParent = Me
        Me.ucrReceiverElement.Location = New System.Drawing.Point(368, 240)
        Me.ucrReceiverElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.TabIndex = 11
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrChkOmitBelow
        '
        Me.ucrChkOmitBelow.AutoSize = True
        Me.ucrChkOmitBelow.Checked = False
        Me.ucrChkOmitBelow.Location = New System.Drawing.Point(368, 279)
        Me.ucrChkOmitBelow.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkOmitBelow.Name = "ucrChkOmitBelow"
        Me.ucrChkOmitBelow.Size = New System.Drawing.Size(204, 34)
        Me.ucrChkOmitBelow.TabIndex = 12
        '
        'ucrNudOmitBelow
        '
        Me.ucrNudOmitBelow.AutoSize = True
        Me.ucrNudOmitBelow.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudOmitBelow.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudOmitBelow.Location = New System.Drawing.Point(574, 279)
        Me.ucrNudOmitBelow.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudOmitBelow.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudOmitBelow.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudOmitBelow.Name = "ucrNudOmitBelow"
        Me.ucrNudOmitBelow.Size = New System.Drawing.Size(72, 30)
        Me.ucrNudOmitBelow.TabIndex = 13
        Me.ucrNudOmitBelow.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputWithinYear
        '
        Me.ucrInputWithinYear.AddQuotesIfUnrecognised = True
        Me.ucrInputWithinYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputWithinYear.GetSetSelectedIndex = -1
        Me.ucrInputWithinYear.IsReadOnly = False
        Me.ucrInputWithinYear.Location = New System.Drawing.Point(550, 417)
        Me.ucrInputWithinYear.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputWithinYear.Name = "ucrInputWithinYear"
        Me.ucrInputWithinYear.Size = New System.Drawing.Size(132, 32)
        Me.ucrInputWithinYear.TabIndex = 19
        '
        'ucrInputYear
        '
        Me.ucrInputYear.AddQuotesIfUnrecognised = True
        Me.ucrInputYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputYear.GetSetSelectedIndex = -1
        Me.ucrInputYear.IsReadOnly = False
        Me.ucrInputYear.Location = New System.Drawing.Point(550, 352)
        Me.ucrInputYear.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputYear.Name = "ucrInputYear"
        Me.ucrInputYear.Size = New System.Drawing.Size(132, 32)
        Me.ucrInputYear.TabIndex = 16
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Location = New System.Drawing.Point(550, 120)
        Me.ucrInputStation.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputStation.Name = "ucrInputStation"
        Me.ucrInputStation.Size = New System.Drawing.Size(132, 32)
        Me.ucrInputStation.TabIndex = 7
        '
        'ucrPnlPlots
        '
        Me.ucrPnlPlots.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlPlots.Location = New System.Drawing.Point(72, 12)
        Me.ucrPnlPlots.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlPlots.Name = "ucrPnlPlots"
        Me.ucrPnlPlots.Size = New System.Drawing.Size(558, 52)
        Me.ucrPnlPlots.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 628)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 26
        '
        'ucrSavePlot
        '
        Me.ucrSavePlot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSavePlot.Location = New System.Drawing.Point(15, 580)
        Me.ucrSavePlot.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSavePlot.Name = "ucrSavePlot"
        Me.ucrSavePlot.Size = New System.Drawing.Size(480, 36)
        Me.ucrSavePlot.TabIndex = 25
        '
        'ucrChkHorizontalBoxplot
        '
        Me.ucrChkHorizontalBoxplot.AutoSize = True
        Me.ucrChkHorizontalBoxplot.Checked = False
        Me.ucrChkHorizontalBoxplot.Location = New System.Drawing.Point(15, 504)
        Me.ucrChkHorizontalBoxplot.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkHorizontalBoxplot.Name = "ucrChkHorizontalBoxplot"
        Me.ucrChkHorizontalBoxplot.Size = New System.Drawing.Size(315, 34)
        Me.ucrChkHorizontalBoxplot.TabIndex = 23
        '
        'ucrChkVarWidth
        '
        Me.ucrChkVarWidth.AutoSize = True
        Me.ucrChkVarWidth.Checked = False
        Me.ucrChkVarWidth.Location = New System.Drawing.Point(15, 465)
        Me.ucrChkVarWidth.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkVarWidth.Name = "ucrChkVarWidth"
        Me.ucrChkVarWidth.Size = New System.Drawing.Size(315, 34)
        Me.ucrChkVarWidth.TabIndex = 22
        '
        'ucrSelectorClimaticBoxPlot
        '
        Me.ucrSelectorClimaticBoxPlot.AutoSize = True
        Me.ucrSelectorClimaticBoxPlot.bDropUnusedFilterLevels = False
        Me.ucrSelectorClimaticBoxPlot.bShowHiddenColumns = False
        Me.ucrSelectorClimaticBoxPlot.bUseCurrentFilter = True
        Me.ucrSelectorClimaticBoxPlot.Location = New System.Drawing.Point(15, 84)
        Me.ucrSelectorClimaticBoxPlot.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorClimaticBoxPlot.Name = "ucrSelectorClimaticBoxPlot"
        Me.ucrSelectorClimaticBoxPlot.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorClimaticBoxPlot.TabIndex = 4
        '
        'ucrChkLabel
        '
        Me.ucrChkLabel.AutoSize = True
        Me.ucrChkLabel.Checked = False
        Me.ucrChkLabel.Location = New System.Drawing.Point(369, 508)
        Me.ucrChkLabel.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkLabel.Name = "ucrChkLabel"
        Me.ucrChkLabel.Size = New System.Drawing.Size(182, 34)
        Me.ucrChkLabel.TabIndex = 35
        '
        'ucrReceiverLabelOutliers
        '
        Me.ucrReceiverLabelOutliers.AutoSize = True
        Me.ucrReceiverLabelOutliers.frmParent = Me
        Me.ucrReceiverLabelOutliers.Location = New System.Drawing.Point(450, 543)
        Me.ucrReceiverLabelOutliers.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLabelOutliers.Name = "ucrReceiverLabelOutliers"
        Me.ucrReceiverLabelOutliers.Selector = Nothing
        Me.ucrReceiverLabelOutliers.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverLabelOutliers.strNcFilePath = ""
        Me.ucrReceiverLabelOutliers.TabIndex = 36
        Me.ucrReceiverLabelOutliers.ucrSelector = Nothing
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(364, 543)
        Me.lblVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(71, 20)
        Me.lblVariable.TabIndex = 37
        Me.lblVariable.Text = "Variable:"
        '
        'dlgClimaticBoxPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(692, 709)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.ucrReceiverLabelOutliers)
        Me.Controls.Add(Me.ucrChkLabel)
        Me.Controls.Add(Me.ucrNudOutlierCoefficient)
        Me.Controls.Add(Me.lblOutlierCoefficient)
        Me.Controls.Add(Me.ucrReceiverWithinYear)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.ucrChkOmitBelow)
        Me.Controls.Add(Me.ucrNudOmitBelow)
        Me.Controls.Add(Me.ucrInputWithinYear)
        Me.Controls.Add(Me.ucrInputYear)
        Me.Controls.Add(Me.ucrInputStation)
        Me.Controls.Add(Me.lblWithinYear)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.rdoViolin)
        Me.Controls.Add(Me.rdoJitter)
        Me.Controls.Add(Me.rdoBoxplot)
        Me.Controls.Add(Me.ucrPnlPlots)
        Me.Controls.Add(Me.cmdBoxPlotOptions)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSavePlot)
        Me.Controls.Add(Me.ucrChkHorizontalBoxplot)
        Me.Controls.Add(Me.ucrChkVarWidth)
        Me.Controls.Add(Me.ucrSelectorClimaticBoxPlot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticBoxPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Climatic Boxplot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSavePlot As ucrSave
    Friend WithEvents ucrChkHorizontalBoxplot As ucrCheck
    Friend WithEvents ucrChkVarWidth As ucrCheck
    Friend WithEvents ucrSelectorClimaticBoxPlot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdBoxPlotOptions As Button
    Friend WithEvents cmdOptions As Button
    Friend WithEvents rdoViolin As RadioButton
    Friend WithEvents rdoJitter As RadioButton
    Friend WithEvents rdoBoxplot As RadioButton
    Friend WithEvents ucrPnlPlots As UcrPanel
    Friend WithEvents lblWithinYear As Label
    Friend WithEvents lblElement As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrInputWithinYear As ucrInputComboBox
    Friend WithEvents ucrInputYear As ucrInputComboBox
    Friend WithEvents ucrChkOmitBelow As ucrCheck
    Friend WithEvents ucrNudOmitBelow As ucrNud
    Friend WithEvents ucrInputStation As ucrInputComboBox
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents ucrReceiverWithinYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrNudOutlierCoefficient As ucrNud
    Friend WithEvents lblOutlierCoefficient As Label
    Friend WithEvents ucrChkLabel As ucrCheck
    Friend WithEvents ucrReceiverLabelOutliers As ucrReceiverSingle
    Friend WithEvents lblVariable As Label
End Class
