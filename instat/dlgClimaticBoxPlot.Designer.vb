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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgClimaticBoxPlot))
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
        Me.ucrChkVerticalXTickMarkers = New instat.ucrCheck()
        Me.ucrPnlPlots = New instat.UcrPanel()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSavePlot = New instat.ucrSave()
        Me.ucrChkHorizontalBoxplot = New instat.ucrCheck()
        Me.ucrChkVarWidth = New instat.ucrCheck()
        Me.ucrSelectorClimaticBoxPlot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'cmdBoxPlotOptions
        '
        resources.ApplyResources(Me.cmdBoxPlotOptions, "cmdBoxPlotOptions")
        Me.cmdBoxPlotOptions.Name = "cmdBoxPlotOptions"
        Me.cmdBoxPlotOptions.Tag = "Boxplot_Options"
        Me.cmdBoxPlotOptions.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'rdoViolin
        '
        resources.ApplyResources(Me.rdoViolin, "rdoViolin")
        Me.rdoViolin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoViolin.FlatAppearance.BorderSize = 2
        Me.rdoViolin.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoViolin.Name = "rdoViolin"
        Me.rdoViolin.TabStop = True
        Me.rdoViolin.UseVisualStyleBackColor = True
        '
        'rdoJitter
        '
        resources.ApplyResources(Me.rdoJitter, "rdoJitter")
        Me.rdoJitter.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoJitter.FlatAppearance.BorderSize = 2
        Me.rdoJitter.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoJitter.Name = "rdoJitter"
        Me.rdoJitter.TabStop = True
        Me.rdoJitter.UseVisualStyleBackColor = True
        '
        'rdoBoxplot
        '
        resources.ApplyResources(Me.rdoBoxplot, "rdoBoxplot")
        Me.rdoBoxplot.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoxplot.FlatAppearance.BorderSize = 2
        Me.rdoBoxplot.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoxplot.Name = "rdoBoxplot"
        Me.rdoBoxplot.TabStop = True
        Me.rdoBoxplot.UseVisualStyleBackColor = True
        '
        'lblWithinYear
        '
        resources.ApplyResources(Me.lblWithinYear, "lblWithinYear")
        Me.lblWithinYear.Name = "lblWithinYear"
        '
        'lblElement
        '
        resources.ApplyResources(Me.lblElement, "lblElement")
        Me.lblElement.Name = "lblElement"
        '
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.Name = "lblYear"
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
        '
        'lblStation
        '
        resources.ApplyResources(Me.lblStation, "lblStation")
        Me.lblStation.Name = "lblStation"
        '
        'ucrReceiverWithinYear
        '
        Me.ucrReceiverWithinYear.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWithinYear, "ucrReceiverWithinYear")
        Me.ucrReceiverWithinYear.Name = "ucrReceiverWithinYear"
        Me.ucrReceiverWithinYear.Selector = Nothing
        Me.ucrReceiverWithinYear.strNcFilePath = ""
        Me.ucrReceiverWithinYear.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverYear, "ucrReceiverYear")
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDate, "ucrReceiverDate")
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStation, "ucrReceiverStation")
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverElement, "ucrReceiverElement")
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrChkOmitBelow
        '
        Me.ucrChkOmitBelow.Checked = False
        resources.ApplyResources(Me.ucrChkOmitBelow, "ucrChkOmitBelow")
        Me.ucrChkOmitBelow.Name = "ucrChkOmitBelow"
        '
        'ucrNudOmitBelow
        '
        Me.ucrNudOmitBelow.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudOmitBelow.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudOmitBelow, "ucrNudOmitBelow")
        Me.ucrNudOmitBelow.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudOmitBelow.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudOmitBelow.Name = "ucrNudOmitBelow"
        Me.ucrNudOmitBelow.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputWithinYear
        '
        Me.ucrInputWithinYear.AddQuotesIfUnrecognised = True
        Me.ucrInputWithinYear.GetSetSelectedIndex = -1
        Me.ucrInputWithinYear.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputWithinYear, "ucrInputWithinYear")
        Me.ucrInputWithinYear.Name = "ucrInputWithinYear"
        '
        'ucrInputYear
        '
        Me.ucrInputYear.AddQuotesIfUnrecognised = True
        Me.ucrInputYear.GetSetSelectedIndex = -1
        Me.ucrInputYear.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYear, "ucrInputYear")
        Me.ucrInputYear.Name = "ucrInputYear"
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputStation, "ucrInputStation")
        Me.ucrInputStation.Name = "ucrInputStation"
        '
        'ucrChkVerticalXTickMarkers
        '
        Me.ucrChkVerticalXTickMarkers.Checked = False
        resources.ApplyResources(Me.ucrChkVerticalXTickMarkers, "ucrChkVerticalXTickMarkers")
        Me.ucrChkVerticalXTickMarkers.Name = "ucrChkVerticalXTickMarkers"
        '
        'ucrPnlPlots
        '
        resources.ApplyResources(Me.ucrPnlPlots, "ucrPnlPlots")
        Me.ucrPnlPlots.Name = "ucrPnlPlots"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSavePlot
        '
        resources.ApplyResources(Me.ucrSavePlot, "ucrSavePlot")
        Me.ucrSavePlot.Name = "ucrSavePlot"
        '
        'ucrChkHorizontalBoxplot
        '
        Me.ucrChkHorizontalBoxplot.Checked = False
        resources.ApplyResources(Me.ucrChkHorizontalBoxplot, "ucrChkHorizontalBoxplot")
        Me.ucrChkHorizontalBoxplot.Name = "ucrChkHorizontalBoxplot"
        '
        'ucrChkVarWidth
        '
        Me.ucrChkVarWidth.Checked = False
        resources.ApplyResources(Me.ucrChkVarWidth, "ucrChkVarWidth")
        Me.ucrChkVarWidth.Name = "ucrChkVarWidth"
        '
        'ucrSelectorClimaticBoxPlot
        '
        Me.ucrSelectorClimaticBoxPlot.bDropUnusedFilterLevels = False
        Me.ucrSelectorClimaticBoxPlot.bShowHiddenColumns = False
        Me.ucrSelectorClimaticBoxPlot.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorClimaticBoxPlot, "ucrSelectorClimaticBoxPlot")
        Me.ucrSelectorClimaticBoxPlot.Name = "ucrSelectorClimaticBoxPlot"
        '
        'dlgClimaticBoxPlot
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Controls.Add(Me.ucrChkVerticalXTickMarkers)
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticBoxPlot"
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
    Friend WithEvents ucrChkVerticalXTickMarkers As ucrCheck
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
End Class
