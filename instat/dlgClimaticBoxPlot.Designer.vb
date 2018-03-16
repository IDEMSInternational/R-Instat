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
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.grpLayout = New System.Windows.Forms.GroupBox()
        Me.rdoDataThenYear = New System.Windows.Forms.RadioButton()
        Me.rdoYearThenData = New System.Windows.Forms.RadioButton()
        Me.ucrPnlLayoutOptions = New instat.UcrPanel()
        Me.cmdBoxPlotOptions = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.rdoViolin = New System.Windows.Forms.RadioButton()
        Me.rdoJitter = New System.Windows.Forms.RadioButton()
        Me.rdoBoxplot = New System.Windows.Forms.RadioButton()
        Me.grpFacets = New System.Windows.Forms.GroupBox()
        Me.ucrReceiver2ndFacet = New instat.ucrReceiverSingle()
        Me.ucrReceiverFacetBy = New instat.ucrReceiverSingle()
        Me.ucrChkMargins = New instat.ucrCheck()
        Me.lblSecondFacet = New System.Windows.Forms.Label()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.ucrChkVerticalXTickMarkers = New instat.ucrCheck()
        Me.ucrVariablesAsFactorForClimaticBoxplot = New instat.ucrVariablesAsFactor()
        Me.ucrPnlPlots = New instat.UcrPanel()
        Me.ucrReceiverXVariable = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSavePlot = New instat.ucrSave()
        Me.ucrChkHorizontalBoxplot = New instat.ucrCheck()
        Me.ucrChkVarWidth = New instat.ucrCheck()
        Me.ucrSelectorClimaticBoxPlot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpLayout.SuspendLayout()
        Me.grpFacets.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblXVariable
        '
        resources.ApplyResources(Me.lblXVariable, "lblXVariable")
        Me.lblXVariable.Name = "lblXVariable"
        '
        'grpLayout
        '
        Me.grpLayout.Controls.Add(Me.rdoDataThenYear)
        Me.grpLayout.Controls.Add(Me.rdoYearThenData)
        Me.grpLayout.Controls.Add(Me.ucrPnlLayoutOptions)
        resources.ApplyResources(Me.grpLayout, "grpLayout")
        Me.grpLayout.Name = "grpLayout"
        Me.grpLayout.TabStop = False
        '
        'rdoDataThenYear
        '
        resources.ApplyResources(Me.rdoDataThenYear, "rdoDataThenYear")
        Me.rdoDataThenYear.Name = "rdoDataThenYear"
        Me.rdoDataThenYear.TabStop = True
        Me.rdoDataThenYear.UseVisualStyleBackColor = True
        '
        'rdoYearThenData
        '
        resources.ApplyResources(Me.rdoYearThenData, "rdoYearThenData")
        Me.rdoYearThenData.Name = "rdoYearThenData"
        Me.rdoYearThenData.TabStop = True
        Me.rdoYearThenData.UseVisualStyleBackColor = True
        '
        'ucrPnlLayoutOptions
        '
        resources.ApplyResources(Me.ucrPnlLayoutOptions, "ucrPnlLayoutOptions")
        Me.ucrPnlLayoutOptions.Name = "ucrPnlLayoutOptions"
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
        'grpFacets
        '
        Me.grpFacets.Controls.Add(Me.ucrReceiver2ndFacet)
        Me.grpFacets.Controls.Add(Me.ucrReceiverFacetBy)
        Me.grpFacets.Controls.Add(Me.ucrChkMargins)
        Me.grpFacets.Controls.Add(Me.lblSecondFacet)
        Me.grpFacets.Controls.Add(Me.lblFacetBy)
        resources.ApplyResources(Me.grpFacets, "grpFacets")
        Me.grpFacets.Name = "grpFacets"
        Me.grpFacets.TabStop = False
        '
        'ucrReceiver2ndFacet
        '
        Me.ucrReceiver2ndFacet.frmParent = Me
        resources.ApplyResources(Me.ucrReceiver2ndFacet, "ucrReceiver2ndFacet")
        Me.ucrReceiver2ndFacet.Name = "ucrReceiver2ndFacet"
        Me.ucrReceiver2ndFacet.Selector = Nothing
        Me.ucrReceiver2ndFacet.strNcFilePath = ""
        Me.ucrReceiver2ndFacet.ucrSelector = Nothing
        '
        'ucrReceiverFacetBy
        '
        Me.ucrReceiverFacetBy.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFacetBy, "ucrReceiverFacetBy")
        Me.ucrReceiverFacetBy.Name = "ucrReceiverFacetBy"
        Me.ucrReceiverFacetBy.Selector = Nothing
        Me.ucrReceiverFacetBy.strNcFilePath = ""
        Me.ucrReceiverFacetBy.ucrSelector = Nothing
        '
        'ucrChkMargins
        '
        Me.ucrChkMargins.Checked = False
        resources.ApplyResources(Me.ucrChkMargins, "ucrChkMargins")
        Me.ucrChkMargins.Name = "ucrChkMargins"
        '
        'lblSecondFacet
        '
        resources.ApplyResources(Me.lblSecondFacet, "lblSecondFacet")
        Me.lblSecondFacet.Name = "lblSecondFacet"
        '
        'lblFacetBy
        '
        resources.ApplyResources(Me.lblFacetBy, "lblFacetBy")
        Me.lblFacetBy.Name = "lblFacetBy"
        '
        'ucrChkVerticalXTickMarkers
        '
        Me.ucrChkVerticalXTickMarkers.Checked = False
        resources.ApplyResources(Me.ucrChkVerticalXTickMarkers, "ucrChkVerticalXTickMarkers")
        Me.ucrChkVerticalXTickMarkers.Name = "ucrChkVerticalXTickMarkers"
        '
        'ucrVariablesAsFactorForClimaticBoxplot
        '
        Me.ucrVariablesAsFactorForClimaticBoxplot.frmParent = Me
        resources.ApplyResources(Me.ucrVariablesAsFactorForClimaticBoxplot, "ucrVariablesAsFactorForClimaticBoxplot")
        Me.ucrVariablesAsFactorForClimaticBoxplot.Name = "ucrVariablesAsFactorForClimaticBoxplot"
        Me.ucrVariablesAsFactorForClimaticBoxplot.Selector = Nothing
        Me.ucrVariablesAsFactorForClimaticBoxplot.strNcFilePath = ""
        Me.ucrVariablesAsFactorForClimaticBoxplot.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForClimaticBoxplot.ucrVariableSelector = Nothing
        '
        'ucrPnlPlots
        '
        resources.ApplyResources(Me.ucrPnlPlots, "ucrPnlPlots")
        Me.ucrPnlPlots.Name = "ucrPnlPlots"
        '
        'ucrReceiverXVariable
        '
        Me.ucrReceiverXVariable.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverXVariable, "ucrReceiverXVariable")
        Me.ucrReceiverXVariable.Name = "ucrReceiverXVariable"
        Me.ucrReceiverXVariable.Selector = Nothing
        Me.ucrReceiverXVariable.strNcFilePath = ""
        Me.ucrReceiverXVariable.ucrSelector = Nothing
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
        Me.ucrSelectorClimaticBoxPlot.bShowHiddenColumns = False
        Me.ucrSelectorClimaticBoxPlot.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorClimaticBoxPlot, "ucrSelectorClimaticBoxPlot")
        Me.ucrSelectorClimaticBoxPlot.Name = "ucrSelectorClimaticBoxPlot"
        '
        'dlgClimaticBoxPlot
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkVerticalXTickMarkers)
        Me.Controls.Add(Me.grpFacets)
        Me.Controls.Add(Me.ucrVariablesAsFactorForClimaticBoxplot)
        Me.Controls.Add(Me.rdoViolin)
        Me.Controls.Add(Me.rdoJitter)
        Me.Controls.Add(Me.rdoBoxplot)
        Me.Controls.Add(Me.ucrPnlPlots)
        Me.Controls.Add(Me.cmdBoxPlotOptions)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.grpLayout)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrReceiverXVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSavePlot)
        Me.Controls.Add(Me.ucrChkHorizontalBoxplot)
        Me.Controls.Add(Me.ucrChkVarWidth)
        Me.Controls.Add(Me.ucrSelectorClimaticBoxPlot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticBoxPlot"
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
    Friend WithEvents lblXVariable As Label
    Friend WithEvents ucrReceiverXVariable As ucrReceiverSingle
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
    Friend WithEvents ucrVariablesAsFactorForClimaticBoxplot As ucrVariablesAsFactor
    Friend WithEvents grpFacets As GroupBox
    Friend WithEvents ucrReceiver2ndFacet As ucrReceiverSingle
    Friend WithEvents ucrReceiverFacetBy As ucrReceiverSingle
    Friend WithEvents ucrChkMargins As ucrCheck
    Friend WithEvents lblSecondFacet As Label
    Friend WithEvents lblFacetBy As Label
    Friend WithEvents ucrChkVerticalXTickMarkers As ucrCheck
End Class
