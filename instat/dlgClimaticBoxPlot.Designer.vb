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
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDOY = New System.Windows.Forms.Label()
        Me.lblRainfall = New System.Windows.Forms.Label()
        Me.grpLayout = New System.Windows.Forms.GroupBox()
        Me.cmdBoxPlotOptions = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.rdoViolin = New System.Windows.Forms.RadioButton()
        Me.rdoJitter = New System.Windows.Forms.RadioButton()
        Me.rdoBoxplot = New System.Windows.Forms.RadioButton()
        Me.ucrPnlPlots = New instat.UcrPanel()
        Me.ucrChkMargins = New instat.ucrCheck()
        Me.ucrChk2ndFacet = New instat.ucrCheck()
        Me.ucrChkFacet = New instat.ucrCheck()
        Me.ucrReceiverMoreData = New instat.ucrReceiverSingle()
        Me.ucrChkMoreData = New instat.ucrCheck()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverWithinYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverData = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSavePlot = New instat.ucrSave()
        Me.ucrChkHorizontalBoxplot = New instat.ucrCheck()
        Me.ucrChkVarWidth = New instat.ucrCheck()
        Me.ucrSelectorClimaticBoxPlot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlLayoutOptions = New instat.UcrPanel()
        Me.rdoYearThenData = New System.Windows.Forms.RadioButton()
        Me.rdoDataThenYear = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverFacet = New instat.ucrReceiverSingle()
        Me.ucrReceiver2ndFacet = New instat.ucrReceiverSingle()
        Me.grpLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(263, 77)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 22
        Me.lblStation.Text = "Station:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(263, 206)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(65, 13)
        Me.lblYear.TabIndex = 28
        Me.lblYear.Text = "Within Year:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(263, 121)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 24
        Me.lblDate.Text = "Date:"
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.Location = New System.Drawing.Point(263, 247)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(33, 13)
        Me.lblDOY.TabIndex = 30
        Me.lblDOY.Text = "Data:"
        '
        'lblRainfall
        '
        Me.lblRainfall.AutoSize = True
        Me.lblRainfall.Location = New System.Drawing.Point(263, 163)
        Me.lblRainfall.Name = "lblRainfall"
        Me.lblRainfall.Size = New System.Drawing.Size(32, 13)
        Me.lblRainfall.TabIndex = 26
        Me.lblRainfall.Text = "Year:"
        '
        'grpLayout
        '
        Me.grpLayout.Controls.Add(Me.ucrReceiver2ndFacet)
        Me.grpLayout.Controls.Add(Me.ucrReceiverFacet)
        Me.grpLayout.Controls.Add(Me.rdoDataThenYear)
        Me.grpLayout.Controls.Add(Me.rdoYearThenData)
        Me.grpLayout.Controls.Add(Me.ucrPnlLayoutOptions)
        Me.grpLayout.Controls.Add(Me.ucrChkMargins)
        Me.grpLayout.Controls.Add(Me.ucrChk2ndFacet)
        Me.grpLayout.Controls.Add(Me.ucrChkFacet)
        Me.grpLayout.Location = New System.Drawing.Point(10, 355)
        Me.grpLayout.Name = "grpLayout"
        Me.grpLayout.Size = New System.Drawing.Size(396, 135)
        Me.grpLayout.TabIndex = 34
        Me.grpLayout.TabStop = False
        Me.grpLayout.Text = "Layout"
        '
        'cmdBoxPlotOptions
        '
        Me.cmdBoxPlotOptions.Location = New System.Drawing.Point(10, 241)
        Me.cmdBoxPlotOptions.Name = "cmdBoxPlotOptions"
        Me.cmdBoxPlotOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdBoxPlotOptions.TabIndex = 35
        Me.cmdBoxPlotOptions.Tag = "Boxplot_Options"
        Me.cmdBoxPlotOptions.Text = "Boxplot Options"
        Me.cmdBoxPlotOptions.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(10, 272)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdOptions.TabIndex = 36
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
        Me.rdoViolin.Location = New System.Drawing.Point(262, 12)
        Me.rdoViolin.Name = "rdoViolin"
        Me.rdoViolin.Size = New System.Drawing.Size(98, 27)
        Me.rdoViolin.TabIndex = 40
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
        Me.rdoJitter.Location = New System.Drawing.Point(166, 12)
        Me.rdoJitter.Name = "rdoJitter"
        Me.rdoJitter.Size = New System.Drawing.Size(98, 27)
        Me.rdoJitter.TabIndex = 39
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
        Me.rdoBoxplot.Location = New System.Drawing.Point(70, 12)
        Me.rdoBoxplot.Name = "rdoBoxplot"
        Me.rdoBoxplot.Size = New System.Drawing.Size(98, 27)
        Me.rdoBoxplot.TabIndex = 38
        Me.rdoBoxplot.TabStop = True
        Me.rdoBoxplot.Text = "Boxplot"
        Me.rdoBoxplot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBoxplot.UseVisualStyleBackColor = True
        '
        'ucrPnlPlots
        '
        Me.ucrPnlPlots.Location = New System.Drawing.Point(57, 8)
        Me.ucrPnlPlots.Name = "ucrPnlPlots"
        Me.ucrPnlPlots.Size = New System.Drawing.Size(322, 35)
        Me.ucrPnlPlots.TabIndex = 37
        '
        'ucrChkMargins
        '
        Me.ucrChkMargins.Checked = False
        Me.ucrChkMargins.Location = New System.Drawing.Point(16, 106)
        Me.ucrChkMargins.Name = "ucrChkMargins"
        Me.ucrChkMargins.Size = New System.Drawing.Size(109, 20)
        Me.ucrChkMargins.TabIndex = 37
        '
        'ucrChk2ndFacet
        '
        Me.ucrChk2ndFacet.Checked = False
        Me.ucrChk2ndFacet.Location = New System.Drawing.Point(16, 80)
        Me.ucrChk2ndFacet.Name = "ucrChk2ndFacet"
        Me.ucrChk2ndFacet.Size = New System.Drawing.Size(135, 20)
        Me.ucrChk2ndFacet.TabIndex = 36
        '
        'ucrChkFacet
        '
        Me.ucrChkFacet.Checked = False
        Me.ucrChkFacet.Location = New System.Drawing.Point(16, 52)
        Me.ucrChkFacet.Name = "ucrChkFacet"
        Me.ucrChkFacet.Size = New System.Drawing.Size(135, 20)
        Me.ucrChkFacet.TabIndex = 35
        '
        'ucrReceiverMoreData
        '
        Me.ucrReceiverMoreData.frmParent = Me
        Me.ucrReceiverMoreData.Location = New System.Drawing.Point(263, 317)
        Me.ucrReceiverMoreData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMoreData.Name = "ucrReceiverMoreData"
        Me.ucrReceiverMoreData.Selector = Nothing
        Me.ucrReceiverMoreData.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverMoreData.strNcFilePath = ""
        Me.ucrReceiverMoreData.TabIndex = 33
        Me.ucrReceiverMoreData.ucrSelector = Nothing
        '
        'ucrChkMoreData
        '
        Me.ucrChkMoreData.Checked = False
        Me.ucrChkMoreData.Location = New System.Drawing.Point(263, 294)
        Me.ucrChkMoreData.Name = "ucrChkMoreData"
        Me.ucrChkMoreData.Size = New System.Drawing.Size(135, 20)
        Me.ucrChkMoreData.TabIndex = 32
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(263, 92)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 23
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverWithinYear
        '
        Me.ucrReceiverWithinYear.frmParent = Me
        Me.ucrReceiverWithinYear.Location = New System.Drawing.Point(263, 221)
        Me.ucrReceiverWithinYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWithinYear.Name = "ucrReceiverWithinYear"
        Me.ucrReceiverWithinYear.Selector = Nothing
        Me.ucrReceiverWithinYear.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverWithinYear.strNcFilePath = ""
        Me.ucrReceiverWithinYear.TabIndex = 29
        Me.ucrReceiverWithinYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(263, 136)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 25
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverData
        '
        Me.ucrReceiverData.frmParent = Me
        Me.ucrReceiverData.Location = New System.Drawing.Point(263, 262)
        Me.ucrReceiverData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverData.Name = "ucrReceiverData"
        Me.ucrReceiverData.Selector = Nothing
        Me.ucrReceiverData.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverData.strNcFilePath = ""
        Me.ucrReceiverData.TabIndex = 31
        Me.ucrReceiverData.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(263, 178)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 27
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 526)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 21
        '
        'ucrSavePlot
        '
        Me.ucrSavePlot.Location = New System.Drawing.Point(10, 496)
        Me.ucrSavePlot.Name = "ucrSavePlot"
        Me.ucrSavePlot.Size = New System.Drawing.Size(254, 24)
        Me.ucrSavePlot.TabIndex = 20
        '
        'ucrChkHorizontalBoxplot
        '
        Me.ucrChkHorizontalBoxplot.Checked = False
        Me.ucrChkHorizontalBoxplot.Location = New System.Drawing.Point(10, 329)
        Me.ucrChkHorizontalBoxplot.Name = "ucrChkHorizontalBoxplot"
        Me.ucrChkHorizontalBoxplot.Size = New System.Drawing.Size(210, 20)
        Me.ucrChkHorizontalBoxplot.TabIndex = 19
        '
        'ucrChkVarWidth
        '
        Me.ucrChkVarWidth.Checked = False
        Me.ucrChkVarWidth.Location = New System.Drawing.Point(10, 303)
        Me.ucrChkVarWidth.Name = "ucrChkVarWidth"
        Me.ucrChkVarWidth.Size = New System.Drawing.Size(210, 20)
        Me.ucrChkVarWidth.TabIndex = 18
        '
        'ucrSelectorClimaticBoxPlot
        '
        Me.ucrSelectorClimaticBoxPlot.bShowHiddenColumns = False
        Me.ucrSelectorClimaticBoxPlot.bUseCurrentFilter = True
        Me.ucrSelectorClimaticBoxPlot.Location = New System.Drawing.Point(10, 56)
        Me.ucrSelectorClimaticBoxPlot.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorClimaticBoxPlot.Name = "ucrSelectorClimaticBoxPlot"
        Me.ucrSelectorClimaticBoxPlot.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorClimaticBoxPlot.TabIndex = 15
        '
        'ucrPnlLayoutOptions
        '
        Me.ucrPnlLayoutOptions.Location = New System.Drawing.Point(6, 17)
        Me.ucrPnlLayoutOptions.Name = "ucrPnlLayoutOptions"
        Me.ucrPnlLayoutOptions.Size = New System.Drawing.Size(248, 29)
        Me.ucrPnlLayoutOptions.TabIndex = 38
        '
        'rdoYearThenData
        '
        Me.rdoYearThenData.AutoSize = True
        Me.rdoYearThenData.Location = New System.Drawing.Point(16, 19)
        Me.rdoYearThenData.Name = "rdoYearThenData"
        Me.rdoYearThenData.Size = New System.Drawing.Size(101, 17)
        Me.rdoYearThenData.TabIndex = 39
        Me.rdoYearThenData.TabStop = True
        Me.rdoYearThenData.Text = "Year Then Data"
        Me.rdoYearThenData.UseVisualStyleBackColor = True
        '
        'rdoDataThenYear
        '
        Me.rdoDataThenYear.AutoSize = True
        Me.rdoDataThenYear.Location = New System.Drawing.Point(158, 19)
        Me.rdoDataThenYear.Name = "rdoDataThenYear"
        Me.rdoDataThenYear.Size = New System.Drawing.Size(101, 17)
        Me.rdoDataThenYear.TabIndex = 39
        Me.rdoDataThenYear.TabStop = True
        Me.rdoDataThenYear.Text = "Data Then Year"
        Me.rdoDataThenYear.UseVisualStyleBackColor = True
        '
        'ucrReceiverFacet
        '
        Me.ucrReceiverFacet.frmParent = Me
        Me.ucrReceiverFacet.Location = New System.Drawing.Point(158, 53)
        Me.ucrReceiverFacet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacet.Name = "ucrReceiverFacet"
        Me.ucrReceiverFacet.Selector = Nothing
        Me.ucrReceiverFacet.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFacet.strNcFilePath = ""
        Me.ucrReceiverFacet.TabIndex = 40
        Me.ucrReceiverFacet.ucrSelector = Nothing
        '
        'ucrReceiver2ndFacet
        '
        Me.ucrReceiver2ndFacet.frmParent = Me
        Me.ucrReceiver2ndFacet.Location = New System.Drawing.Point(158, 77)
        Me.ucrReceiver2ndFacet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiver2ndFacet.Name = "ucrReceiver2ndFacet"
        Me.ucrReceiver2ndFacet.Selector = Nothing
        Me.ucrReceiver2ndFacet.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiver2ndFacet.strNcFilePath = ""
        Me.ucrReceiver2ndFacet.TabIndex = 40
        Me.ucrReceiver2ndFacet.ucrSelector = Nothing
        '
        'dlgClimaticBoxPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 577)
        Me.Controls.Add(Me.rdoViolin)
        Me.Controls.Add(Me.rdoJitter)
        Me.Controls.Add(Me.rdoBoxplot)
        Me.Controls.Add(Me.ucrPnlPlots)
        Me.Controls.Add(Me.cmdBoxPlotOptions)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.grpLayout)
        Me.Controls.Add(Me.ucrReceiverMoreData)
        Me.Controls.Add(Me.ucrChkMoreData)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverWithinYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverData)
        Me.Controls.Add(Me.lblDOY)
        Me.Controls.Add(Me.lblRainfall)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSavePlot)
        Me.Controls.Add(Me.ucrChkHorizontalBoxplot)
        Me.Controls.Add(Me.ucrChkVarWidth)
        Me.Controls.Add(Me.ucrSelectorClimaticBoxPlot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticBoxPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Climatic BoxPlot"
        Me.grpLayout.ResumeLayout(False)
        Me.grpLayout.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSavePlot As ucrSave
    Friend WithEvents ucrChkHorizontalBoxplot As ucrCheck
    Friend WithEvents ucrChkVarWidth As ucrCheck
    Friend WithEvents ucrSelectorClimaticBoxPlot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverWithinYear As ucrReceiverSingle
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverData As ucrReceiverSingle
    Friend WithEvents lblDOY As Label
    Friend WithEvents lblRainfall As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrChkMoreData As ucrCheck
    Friend WithEvents ucrReceiverMoreData As ucrReceiverSingle
    Friend WithEvents grpLayout As GroupBox
    Friend WithEvents ucrChkMargins As ucrCheck
    Friend WithEvents ucrChk2ndFacet As ucrCheck
    Friend WithEvents ucrChkFacet As ucrCheck
    Friend WithEvents cmdBoxPlotOptions As Button
    Friend WithEvents cmdOptions As Button
    Friend WithEvents rdoViolin As RadioButton
    Friend WithEvents rdoJitter As RadioButton
    Friend WithEvents rdoBoxplot As RadioButton
    Friend WithEvents ucrPnlPlots As UcrPanel
    Friend WithEvents rdoYearThenData As RadioButton
    Friend WithEvents ucrPnlLayoutOptions As UcrPanel
    Friend WithEvents rdoDataThenYear As RadioButton
    Friend WithEvents ucrReceiverFacet As ucrReceiverSingle
    Friend WithEvents ucrReceiver2ndFacet As ucrReceiverSingle
End Class
