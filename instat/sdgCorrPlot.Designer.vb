<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgCorrPlot
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
        Me.tbSaveGraphs = New System.Windows.Forms.TabControl()
        Me.tbPairwisePlot = New System.Windows.Forms.TabPage()
        Me.tbCorrelationPlot = New System.Windows.Forms.TabPage()
        Me.ucrChkLabel = New instat.ucrCheck()
        Me.ucrInputComboGeom = New instat.ucrInputComboBox()
        Me.ucrNudAlphaCorr = New instat.ucrNud()
        Me.ucrNudMaximumSize = New instat.ucrNud()
        Me.ucrNudMinimunSize = New instat.ucrNud()
        Me.lblMaximumSize = New System.Windows.Forms.Label()
        Me.lblLabelAlpha = New System.Windows.Forms.Label()
        Me.lblMinimumSize = New System.Windows.Forms.Label()
        Me.lblgeom = New System.Windows.Forms.Label()
        Me.tbScatterplotMatrix = New System.Windows.Forms.TabPage()
        Me.ucrChkColor = New instat.ucrCheck()
        Me.ucrNudAlpha = New instat.ucrNud()
        Me.ucrSelectFactor = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblFactorVariable = New System.Windows.Forms.Label()
        Me.lblAlpha = New System.Windows.Forms.Label()
        Me.ucrReceiveFactor = New instat.ucrReceiverSingle()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.rdoPairwisePlot = New System.Windows.Forms.RadioButton()
        Me.rdoCorrelationPlot = New System.Windows.Forms.RadioButton()
        Me.rdoScatterPlotMatrix = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ucrPnlGraphType = New instat.UcrPanel()
        Me.ucrBaseSdgCorrPlot = New instat.ucrButtonsSubdialogue()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.tbSaveGraphs.SuspendLayout()
        Me.tbCorrelationPlot.SuspendLayout()
        Me.tbScatterplotMatrix.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbSaveGraphs
        '
        Me.tbSaveGraphs.Controls.Add(Me.tbPairwisePlot)
        Me.tbSaveGraphs.Controls.Add(Me.tbCorrelationPlot)
        Me.tbSaveGraphs.Controls.Add(Me.tbScatterplotMatrix)
        Me.tbSaveGraphs.Location = New System.Drawing.Point(10, 87)
        Me.tbSaveGraphs.Name = "tbSaveGraphs"
        Me.tbSaveGraphs.SelectedIndex = 0
        Me.tbSaveGraphs.Size = New System.Drawing.Size(348, 271)
        Me.tbSaveGraphs.TabIndex = 1
        '
        'tbPairwisePlot
        '
        Me.tbPairwisePlot.Location = New System.Drawing.Point(4, 22)
        Me.tbPairwisePlot.Name = "tbPairwisePlot"
        Me.tbPairwisePlot.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPairwisePlot.Size = New System.Drawing.Size(340, 245)
        Me.tbPairwisePlot.TabIndex = 0
        Me.tbPairwisePlot.Tag = "Pairwise_Plot"
        Me.tbPairwisePlot.Text = "Pairwise Plot"
        Me.tbPairwisePlot.UseVisualStyleBackColor = True
        '
        'tbCorrelationPlot
        '
        Me.tbCorrelationPlot.Controls.Add(Me.ucrChkLabel)
        Me.tbCorrelationPlot.Controls.Add(Me.ucrInputComboGeom)
        Me.tbCorrelationPlot.Controls.Add(Me.ucrNudAlphaCorr)
        Me.tbCorrelationPlot.Controls.Add(Me.ucrNudMaximumSize)
        Me.tbCorrelationPlot.Controls.Add(Me.ucrNudMinimunSize)
        Me.tbCorrelationPlot.Controls.Add(Me.lblMaximumSize)
        Me.tbCorrelationPlot.Controls.Add(Me.lblLabelAlpha)
        Me.tbCorrelationPlot.Controls.Add(Me.lblMinimumSize)
        Me.tbCorrelationPlot.Controls.Add(Me.lblgeom)
        Me.tbCorrelationPlot.Location = New System.Drawing.Point(4, 22)
        Me.tbCorrelationPlot.Name = "tbCorrelationPlot"
        Me.tbCorrelationPlot.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCorrelationPlot.Size = New System.Drawing.Size(340, 245)
        Me.tbCorrelationPlot.TabIndex = 1
        Me.tbCorrelationPlot.Tag = "Correlation_Plot"
        Me.tbCorrelationPlot.Text = "Correlation Plot"
        Me.tbCorrelationPlot.UseVisualStyleBackColor = True
        '
        'ucrChkLabel
        '
        Me.ucrChkLabel.Checked = False
        Me.ucrChkLabel.Location = New System.Drawing.Point(13, 74)
        Me.ucrChkLabel.Name = "ucrChkLabel"
        Me.ucrChkLabel.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkLabel.TabIndex = 32
        '
        'ucrInputComboGeom
        '
        Me.ucrInputComboGeom.AddQuotesIfUnrecognised = True
        Me.ucrInputComboGeom.IsReadOnly = False
        Me.ucrInputComboGeom.Location = New System.Drawing.Point(51, 17)
        Me.ucrInputComboGeom.Name = "ucrInputComboGeom"
        Me.ucrInputComboGeom.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputComboGeom.TabIndex = 31
        '
        'ucrNudAlphaCorr
        '
        Me.ucrNudAlphaCorr.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAlphaCorr.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAlphaCorr.Location = New System.Drawing.Point(243, 73)
        Me.ucrNudAlphaCorr.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAlphaCorr.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAlphaCorr.Name = "ucrNudAlphaCorr"
        Me.ucrNudAlphaCorr.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAlphaCorr.TabIndex = 30
        Me.ucrNudAlphaCorr.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaximumSize
        '
        Me.ucrNudMaximumSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximumSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaximumSize.Location = New System.Drawing.Point(244, 47)
        Me.ucrNudMaximumSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaximumSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximumSize.Name = "ucrNudMaximumSize"
        Me.ucrNudMaximumSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaximumSize.TabIndex = 29
        Me.ucrNudMaximumSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMinimunSize
        '
        Me.ucrNudMinimunSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinimunSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinimunSize.Location = New System.Drawing.Point(80, 47)
        Me.ucrNudMinimunSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinimunSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinimunSize.Name = "ucrNudMinimunSize"
        Me.ucrNudMinimunSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMinimunSize.TabIndex = 28
        Me.ucrNudMinimunSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMaximumSize
        '
        Me.lblMaximumSize.AutoSize = True
        Me.lblMaximumSize.Location = New System.Drawing.Point(170, 49)
        Me.lblMaximumSize.Name = "lblMaximumSize"
        Me.lblMaximumSize.Size = New System.Drawing.Size(77, 13)
        Me.lblMaximumSize.TabIndex = 23
        Me.lblMaximumSize.Tag = "Maximum_Size"
        Me.lblMaximumSize.Text = "Maximum Size:"
        '
        'lblLabelAlpha
        '
        Me.lblLabelAlpha.AutoSize = True
        Me.lblLabelAlpha.Location = New System.Drawing.Point(171, 77)
        Me.lblLabelAlpha.Name = "lblLabelAlpha"
        Me.lblLabelAlpha.Size = New System.Drawing.Size(66, 13)
        Me.lblLabelAlpha.TabIndex = 21
        Me.lblLabelAlpha.Tag = "Label_Alpha"
        Me.lblLabelAlpha.Text = "Label Alpha:"
        '
        'lblMinimumSize
        '
        Me.lblMinimumSize.AutoSize = True
        Me.lblMinimumSize.Location = New System.Drawing.Point(8, 49)
        Me.lblMinimumSize.Name = "lblMinimumSize"
        Me.lblMinimumSize.Size = New System.Drawing.Size(74, 13)
        Me.lblMinimumSize.TabIndex = 20
        Me.lblMinimumSize.Tag = "Minimum_Size"
        Me.lblMinimumSize.Text = "Minimum Size:"
        '
        'lblgeom
        '
        Me.lblgeom.AutoSize = True
        Me.lblgeom.Location = New System.Drawing.Point(9, 20)
        Me.lblgeom.Name = "lblgeom"
        Me.lblgeom.Size = New System.Drawing.Size(38, 13)
        Me.lblgeom.TabIndex = 19
        Me.lblgeom.Tag = "geom"
        Me.lblgeom.Text = "Geom:"
        '
        'tbScatterplotMatrix
        '
        Me.tbScatterplotMatrix.Controls.Add(Me.ucrChkColor)
        Me.tbScatterplotMatrix.Controls.Add(Me.ucrNudAlpha)
        Me.tbScatterplotMatrix.Controls.Add(Me.ucrSelectFactor)
        Me.tbScatterplotMatrix.Controls.Add(Me.lblFactorVariable)
        Me.tbScatterplotMatrix.Controls.Add(Me.lblAlpha)
        Me.tbScatterplotMatrix.Controls.Add(Me.ucrReceiveFactor)
        Me.tbScatterplotMatrix.Location = New System.Drawing.Point(4, 22)
        Me.tbScatterplotMatrix.Name = "tbScatterplotMatrix"
        Me.tbScatterplotMatrix.Padding = New System.Windows.Forms.Padding(3)
        Me.tbScatterplotMatrix.Size = New System.Drawing.Size(340, 245)
        Me.tbScatterplotMatrix.TabIndex = 2
        Me.tbScatterplotMatrix.Tag = "Scatterplot_Matrix"
        Me.tbScatterplotMatrix.Text = "Scatterplot Matrix"
        Me.tbScatterplotMatrix.UseVisualStyleBackColor = True
        '
        'ucrChkColor
        '
        Me.ucrChkColor.Checked = False
        Me.ucrChkColor.Location = New System.Drawing.Point(5, 36)
        Me.ucrChkColor.Name = "ucrChkColor"
        Me.ucrChkColor.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkColor.TabIndex = 30
        '
        'ucrNudAlpha
        '
        Me.ucrNudAlpha.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAlpha.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAlpha.Location = New System.Drawing.Point(42, 10)
        Me.ucrNudAlpha.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAlpha.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAlpha.Name = "ucrNudAlpha"
        Me.ucrNudAlpha.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAlpha.TabIndex = 29
        Me.ucrNudAlpha.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSelectFactor
        '
        Me.ucrSelectFactor.bShowHiddenColumns = False
        Me.ucrSelectFactor.bUseCurrentFilter = True
        Me.ucrSelectFactor.Location = New System.Drawing.Point(3, 59)
        Me.ucrSelectFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectFactor.Name = "ucrSelectFactor"
        Me.ucrSelectFactor.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectFactor.TabIndex = 13
        '
        'lblFactorVariable
        '
        Me.lblFactorVariable.AutoSize = True
        Me.lblFactorVariable.Location = New System.Drawing.Point(211, 67)
        Me.lblFactorVariable.Name = "lblFactorVariable"
        Me.lblFactorVariable.Size = New System.Drawing.Size(81, 13)
        Me.lblFactorVariable.TabIndex = 7
        Me.lblFactorVariable.Tag = "Factor_Variable"
        Me.lblFactorVariable.Text = "Factor Variable:"
        '
        'lblAlpha
        '
        Me.lblAlpha.AutoSize = True
        Me.lblAlpha.Location = New System.Drawing.Point(6, 13)
        Me.lblAlpha.Name = "lblAlpha"
        Me.lblAlpha.Size = New System.Drawing.Size(37, 13)
        Me.lblAlpha.TabIndex = 8
        Me.lblAlpha.Tag = "Alpha"
        Me.lblAlpha.Text = "Alpha:"
        '
        'ucrReceiveFactor
        '
        Me.ucrReceiveFactor.frmParent = Me
        Me.ucrReceiveFactor.Location = New System.Drawing.Point(213, 81)
        Me.ucrReceiveFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiveFactor.Name = "ucrReceiveFactor"
        Me.ucrReceiveFactor.Selector = Nothing
        Me.ucrReceiveFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiveFactor.strNcFilePath = ""
        Me.ucrReceiveFactor.TabIndex = 12
        Me.ucrReceiveFactor.ucrSelector = Nothing
        '
        'rdoNone
        '
        Me.rdoNone.AutoSize = True
        Me.rdoNone.Location = New System.Drawing.Point(35, 22)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(51, 17)
        Me.rdoNone.TabIndex = 5
        Me.rdoNone.TabStop = True
        Me.rdoNone.Text = "None"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'rdoPairwisePlot
        '
        Me.rdoPairwisePlot.AutoSize = True
        Me.rdoPairwisePlot.Location = New System.Drawing.Point(33, 46)
        Me.rdoPairwisePlot.Name = "rdoPairwisePlot"
        Me.rdoPairwisePlot.Size = New System.Drawing.Size(85, 17)
        Me.rdoPairwisePlot.TabIndex = 6
        Me.rdoPairwisePlot.TabStop = True
        Me.rdoPairwisePlot.Text = "Pairwise Plot"
        Me.rdoPairwisePlot.UseVisualStyleBackColor = True
        '
        'rdoCorrelationPlot
        '
        Me.rdoCorrelationPlot.AutoSize = True
        Me.rdoCorrelationPlot.Location = New System.Drawing.Point(218, 22)
        Me.rdoCorrelationPlot.Name = "rdoCorrelationPlot"
        Me.rdoCorrelationPlot.Size = New System.Drawing.Size(96, 17)
        Me.rdoCorrelationPlot.TabIndex = 7
        Me.rdoCorrelationPlot.TabStop = True
        Me.rdoCorrelationPlot.Text = "Correlation Plot"
        Me.rdoCorrelationPlot.UseVisualStyleBackColor = True
        '
        'rdoScatterPlotMatrix
        '
        Me.rdoScatterPlotMatrix.AutoSize = True
        Me.rdoScatterPlotMatrix.Location = New System.Drawing.Point(217, 46)
        Me.rdoScatterPlotMatrix.Name = "rdoScatterPlotMatrix"
        Me.rdoScatterPlotMatrix.Size = New System.Drawing.Size(90, 17)
        Me.rdoScatterPlotMatrix.TabIndex = 8
        Me.rdoScatterPlotMatrix.TabStop = True
        Me.rdoScatterPlotMatrix.Text = "Scatter Matrix"
        Me.rdoScatterPlotMatrix.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 81)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Graphs"
        '
        'ucrPnlGraphType
        '
        Me.ucrPnlGraphType.Location = New System.Drawing.Point(18, 12)
        Me.ucrPnlGraphType.Name = "ucrPnlGraphType"
        Me.ucrPnlGraphType.Size = New System.Drawing.Size(322, 63)
        Me.ucrPnlGraphType.TabIndex = 4
        '
        'ucrBaseSdgCorrPlot
        '
        Me.ucrBaseSdgCorrPlot.Location = New System.Drawing.Point(108, 392)
        Me.ucrBaseSdgCorrPlot.Name = "ucrBaseSdgCorrPlot"
        Me.ucrBaseSdgCorrPlot.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSdgCorrPlot.TabIndex = 3
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(16, 364)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(319, 24)
        Me.ucrSaveGraph.TabIndex = 21
        '
        'sdgCorrPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 428)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.rdoScatterPlotMatrix)
        Me.Controls.Add(Me.rdoCorrelationPlot)
        Me.Controls.Add(Me.rdoPairwisePlot)
        Me.Controls.Add(Me.rdoNone)
        Me.Controls.Add(Me.ucrPnlGraphType)
        Me.Controls.Add(Me.ucrBaseSdgCorrPlot)
        Me.Controls.Add(Me.tbSaveGraphs)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCorrPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Correlation_Display_and_Graphics"
        Me.Text = "Correlation Display and Graphics"
        Me.tbSaveGraphs.ResumeLayout(False)
        Me.tbCorrelationPlot.ResumeLayout(False)
        Me.tbCorrelationPlot.PerformLayout()
        Me.tbScatterplotMatrix.ResumeLayout(False)
        Me.tbScatterplotMatrix.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSdgCorrPlot As ucrButtonsSubdialogue
    Friend WithEvents tbSaveGraphs As TabControl
    Friend WithEvents tbPairwisePlot As TabPage
    Friend WithEvents tbCorrelationPlot As TabPage
    Friend WithEvents tbScatterplotMatrix As TabPage
    Friend WithEvents lblMaximumSize As Label
    Friend WithEvents lblLabelAlpha As Label
    Friend WithEvents lblMinimumSize As Label
    Friend WithEvents lblgeom As Label
    Friend WithEvents lblAlpha As Label
    Friend WithEvents ucrReceiveFactor As ucrReceiverSingle
    Friend WithEvents lblFactorVariable As Label
    Friend WithEvents ucrSelectFactor As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpGraphs As GroupBox
    Friend WithEvents ucrNudMinimunSize As ucrNud
    Friend WithEvents ucrNudMaximumSize As ucrNud
    Friend WithEvents ucrNudAlphaCorr As ucrNud
    Friend WithEvents ucrInputComboGeom As ucrInputComboBox
    Friend WithEvents ucrPnlGraphType As UcrPanel
    Friend WithEvents rdoScatterPlotMatrix As RadioButton
    Friend WithEvents rdoCorrelationPlot As RadioButton
    Friend WithEvents rdoPairwisePlot As RadioButton
    Friend WithEvents rdoNone As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ucrNudAlpha As ucrNud
    Friend WithEvents ucrChkColor As ucrCheck
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrChkLabel As ucrCheck
End Class