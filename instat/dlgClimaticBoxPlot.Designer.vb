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
        Me.lblWithinYear = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.grpLayout = New System.Windows.Forms.GroupBox()
        Me.rdoDataThenYear = New System.Windows.Forms.RadioButton()
        Me.rdoYearThenData = New System.Windows.Forms.RadioButton()
        Me.cmdBoxPlotOptions = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.rdoViolin = New System.Windows.Forms.RadioButton()
        Me.rdoJitter = New System.Windows.Forms.RadioButton()
        Me.rdoBoxplot = New System.Windows.Forms.RadioButton()
        Me.grpFacets = New System.Windows.Forms.GroupBox()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.lblSecondFacet = New System.Windows.Forms.Label()
        Me.ucrReceiver2ndFacet = New instat.ucrReceiverSingle()
        Me.ucrReceiverFacet = New instat.ucrReceiverSingle()
        Me.ucrChkMargins = New instat.ucrCheck()
        Me.UcrVariablesAsFactor1 = New instat.ucrVariablesAsFactor()
        Me.ucrPnlPlots = New instat.UcrPanel()
        Me.ucrPnlLayoutOptions = New instat.UcrPanel()
        Me.ucrReceiverWithinYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSavePlot = New instat.ucrSave()
        Me.ucrChkHorizontalBoxplot = New instat.ucrCheck()
        Me.ucrChkVarWidth = New instat.ucrCheck()
        Me.ucrSelectorClimaticBoxPlot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpLayout.SuspendLayout()
        Me.grpFacets.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWithinYear
        '
        Me.lblWithinYear.AutoSize = True
        Me.lblWithinYear.Location = New System.Drawing.Point(251, 246)
        Me.lblWithinYear.Name = "lblWithinYear"
        Me.lblWithinYear.Size = New System.Drawing.Size(65, 13)
        Me.lblWithinYear.TabIndex = 28
        Me.lblWithinYear.Text = "Within Year:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(251, 203)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 26
        Me.lblYear.Text = "Year:"
        '
        'grpLayout
        '
        Me.grpLayout.Controls.Add(Me.rdoDataThenYear)
        Me.grpLayout.Controls.Add(Me.rdoYearThenData)
        Me.grpLayout.Controls.Add(Me.ucrPnlLayoutOptions)
        Me.grpLayout.Location = New System.Drawing.Point(6, 359)
        Me.grpLayout.Name = "grpLayout"
        Me.grpLayout.Size = New System.Drawing.Size(124, 74)
        Me.grpLayout.TabIndex = 34
        Me.grpLayout.TabStop = False
        Me.grpLayout.Text = "Layout"
        '
        'rdoDataThenYear
        '
        Me.rdoDataThenYear.AutoSize = True
        Me.rdoDataThenYear.Enabled = False
        Me.rdoDataThenYear.Location = New System.Drawing.Point(4, 47)
        Me.rdoDataThenYear.Name = "rdoDataThenYear"
        Me.rdoDataThenYear.Size = New System.Drawing.Size(101, 17)
        Me.rdoDataThenYear.TabIndex = 39
        Me.rdoDataThenYear.TabStop = True
        Me.rdoDataThenYear.Text = "Data Then Year"
        Me.rdoDataThenYear.UseVisualStyleBackColor = True
        '
        'rdoYearThenData
        '
        Me.rdoYearThenData.AutoSize = True
        Me.rdoYearThenData.Enabled = False
        Me.rdoYearThenData.Location = New System.Drawing.Point(4, 21)
        Me.rdoYearThenData.Name = "rdoYearThenData"
        Me.rdoYearThenData.Size = New System.Drawing.Size(101, 17)
        Me.rdoYearThenData.TabIndex = 39
        Me.rdoYearThenData.TabStop = True
        Me.rdoYearThenData.Text = "Year Then Data"
        Me.rdoYearThenData.UseVisualStyleBackColor = True
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
        'grpFacets
        '
        Me.grpFacets.Controls.Add(Me.ucrReceiver2ndFacet)
        Me.grpFacets.Controls.Add(Me.ucrReceiverFacet)
        Me.grpFacets.Controls.Add(Me.ucrChkMargins)
        Me.grpFacets.Controls.Add(Me.lblSecondFacet)
        Me.grpFacets.Controls.Add(Me.lblFacetBy)
        Me.grpFacets.Location = New System.Drawing.Point(249, 291)
        Me.grpFacets.Name = "grpFacets"
        Me.grpFacets.Size = New System.Drawing.Size(174, 138)
        Me.grpFacets.TabIndex = 42
        Me.grpFacets.TabStop = False
        Me.grpFacets.Text = "Facets"
        '
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.Location = New System.Drawing.Point(2, 25)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(52, 13)
        Me.lblFacetBy.TabIndex = 28
        Me.lblFacetBy.Text = "Facet By:"
        '
        'lblSecondFacet
        '
        Me.lblSecondFacet.AutoSize = True
        Me.lblSecondFacet.Location = New System.Drawing.Point(2, 68)
        Me.lblSecondFacet.Name = "lblSecondFacet"
        Me.lblSecondFacet.Size = New System.Drawing.Size(77, 13)
        Me.lblSecondFacet.TabIndex = 28
        Me.lblSecondFacet.Text = "Second Facet:"
        '
        'ucrReceiver2ndFacet
        '
        Me.ucrReceiver2ndFacet.frmParent = Nothing
        Me.ucrReceiver2ndFacet.Location = New System.Drawing.Point(5, 86)
        Me.ucrReceiver2ndFacet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiver2ndFacet.Name = "ucrReceiver2ndFacet"
        Me.ucrReceiver2ndFacet.Selector = Nothing
        Me.ucrReceiver2ndFacet.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiver2ndFacet.strNcFilePath = ""
        Me.ucrReceiver2ndFacet.TabIndex = 44
        Me.ucrReceiver2ndFacet.ucrSelector = Nothing
        '
        'ucrReceiverFacet
        '
        Me.ucrReceiverFacet.frmParent = Nothing
        Me.ucrReceiverFacet.Location = New System.Drawing.Point(5, 38)
        Me.ucrReceiverFacet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacet.Name = "ucrReceiverFacet"
        Me.ucrReceiverFacet.Selector = Nothing
        Me.ucrReceiverFacet.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverFacet.strNcFilePath = ""
        Me.ucrReceiverFacet.TabIndex = 45
        Me.ucrReceiverFacet.ucrSelector = Nothing
        '
        'ucrChkMargins
        '
        Me.ucrChkMargins.Checked = False
        Me.ucrChkMargins.Location = New System.Drawing.Point(5, 112)
        Me.ucrChkMargins.Name = "ucrChkMargins"
        Me.ucrChkMargins.Size = New System.Drawing.Size(109, 20)
        Me.ucrChkMargins.TabIndex = 43
        '
        'UcrVariablesAsFactor1
        '
        Me.UcrVariablesAsFactor1.frmParent = Me
        Me.UcrVariablesAsFactor1.Location = New System.Drawing.Point(254, 70)
        Me.UcrVariablesAsFactor1.Name = "UcrVariablesAsFactor1"
        Me.UcrVariablesAsFactor1.Selector = Nothing
        Me.UcrVariablesAsFactor1.Size = New System.Drawing.Size(120, 130)
        Me.UcrVariablesAsFactor1.strNcFilePath = ""
        Me.UcrVariablesAsFactor1.TabIndex = 41
        Me.UcrVariablesAsFactor1.ucrSelector = Nothing
        Me.UcrVariablesAsFactor1.ucrVariableSelector = Nothing
        '
        'ucrPnlPlots
        '
        Me.ucrPnlPlots.Location = New System.Drawing.Point(57, 8)
        Me.ucrPnlPlots.Name = "ucrPnlPlots"
        Me.ucrPnlPlots.Size = New System.Drawing.Size(322, 35)
        Me.ucrPnlPlots.TabIndex = 37
        '
        'ucrPnlLayoutOptions
        '
        Me.ucrPnlLayoutOptions.Location = New System.Drawing.Point(6, 17)
        Me.ucrPnlLayoutOptions.Name = "ucrPnlLayoutOptions"
        Me.ucrPnlLayoutOptions.Size = New System.Drawing.Size(114, 29)
        Me.ucrPnlLayoutOptions.TabIndex = 38
        '
        'ucrReceiverWithinYear
        '
        Me.ucrReceiverWithinYear.frmParent = Me
        Me.ucrReceiverWithinYear.Location = New System.Drawing.Point(254, 259)
        Me.ucrReceiverWithinYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWithinYear.Name = "ucrReceiverWithinYear"
        Me.ucrReceiverWithinYear.Selector = Nothing
        Me.ucrReceiverWithinYear.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverWithinYear.strNcFilePath = ""
        Me.ucrReceiverWithinYear.TabIndex = 29
        Me.ucrReceiverWithinYear.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(254, 216)
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
        Me.ucrBase.Location = New System.Drawing.Point(10, 467)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 21
        '
        'ucrSavePlot
        '
        Me.ucrSavePlot.Location = New System.Drawing.Point(10, 439)
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
        'dlgClimaticBoxPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 525)
        Me.Controls.Add(Me.grpFacets)
        Me.Controls.Add(Me.UcrVariablesAsFactor1)
        Me.Controls.Add(Me.rdoViolin)
        Me.Controls.Add(Me.rdoJitter)
        Me.Controls.Add(Me.rdoBoxplot)
        Me.Controls.Add(Me.ucrPnlPlots)
        Me.Controls.Add(Me.cmdBoxPlotOptions)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.grpLayout)
        Me.Controls.Add(Me.ucrReceiverWithinYear)
        Me.Controls.Add(Me.lblWithinYear)
        Me.Controls.Add(Me.lblYear)
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
        Me.grpFacets.ResumeLayout(False)
        Me.grpFacets.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSavePlot As ucrSave
    Friend WithEvents ucrChkHorizontalBoxplot As ucrCheck
    Friend WithEvents ucrChkVarWidth As ucrCheck
    Friend WithEvents ucrSelectorClimaticBoxPlot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverWithinYear As ucrReceiverSingle
    Friend WithEvents lblWithinYear As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents grpLayout As GroupBox
    Friend WithEvents cmdBoxPlotOptions As Button
    Friend WithEvents cmdOptions As Button
    Friend WithEvents rdoViolin As RadioButton
    Friend WithEvents rdoJitter As RadioButton
    Friend WithEvents rdoBoxplot As RadioButton
    Friend WithEvents ucrPnlPlots As UcrPanel
    Friend WithEvents rdoYearThenData As RadioButton
    Friend WithEvents ucrPnlLayoutOptions As UcrPanel
    Friend WithEvents rdoDataThenYear As RadioButton
    Friend WithEvents UcrVariablesAsFactor1 As ucrVariablesAsFactor
    Friend WithEvents grpFacets As GroupBox
    Friend WithEvents ucrReceiver2ndFacet As ucrReceiverSingle
    Friend WithEvents ucrReceiverFacet As ucrReceiverSingle
    Friend WithEvents ucrChkMargins As ucrCheck
    Friend WithEvents lblSecondFacet As Label
    Friend WithEvents lblFacetBy As Label
End Class
