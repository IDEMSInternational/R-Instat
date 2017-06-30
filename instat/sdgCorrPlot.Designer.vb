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
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.rdoPairwisePlot = New System.Windows.Forms.RadioButton()
        Me.rdoCorrelationPlot = New System.Windows.Forms.RadioButton()
        Me.rdoScatterPlotMatrix = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ucrPnlGraphType = New instat.UcrPanel()
        Me.lblFactorVariable = New System.Windows.Forms.Label()
        Me.lblAlpha = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkLabel = New instat.ucrCheck()
        Me.lblgeom = New System.Windows.Forms.Label()
        Me.ucrNudAlphaCorr = New instat.ucrNud()
        Me.ucrInputComboGeom = New instat.ucrInputComboBox()
        Me.ucrNudMaximumSize = New instat.ucrNud()
        Me.lblMaximumSize = New System.Windows.Forms.Label()
        Me.ucrNudMinimunSize = New instat.ucrNud()
        Me.lblMinimumSize = New System.Windows.Forms.Label()
        Me.lblLabelAlpha = New System.Windows.Forms.Label()
        Me.ucrSelectFactor = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrNudAlpha = New instat.ucrNud()
        Me.ucrReceiveFactor = New instat.ucrReceiverSingle()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrChkColor = New instat.ucrCheck()
        Me.ucrBaseSdgCorrPlot = New instat.ucrButtonsSubdialogue()
        Me.GroupBox1.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoNone
        '
        Me.rdoNone.AutoSize = True
        Me.rdoNone.Location = New System.Drawing.Point(36, 33)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(51, 17)
        Me.rdoNone.TabIndex = 2
        Me.rdoNone.Text = "None"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'rdoPairwisePlot
        '
        Me.rdoPairwisePlot.AutoSize = True
        Me.rdoPairwisePlot.Location = New System.Drawing.Point(35, 58)
        Me.rdoPairwisePlot.Name = "rdoPairwisePlot"
        Me.rdoPairwisePlot.Size = New System.Drawing.Size(85, 17)
        Me.rdoPairwisePlot.TabIndex = 3
        Me.rdoPairwisePlot.Text = "Pairwise Plot"
        Me.rdoPairwisePlot.UseVisualStyleBackColor = True
        '
        'rdoCorrelationPlot
        '
        Me.rdoCorrelationPlot.AutoSize = True
        Me.rdoCorrelationPlot.Location = New System.Drawing.Point(218, 32)
        Me.rdoCorrelationPlot.Name = "rdoCorrelationPlot"
        Me.rdoCorrelationPlot.Size = New System.Drawing.Size(96, 17)
        Me.rdoCorrelationPlot.TabIndex = 4
        Me.rdoCorrelationPlot.Text = "Correlation Plot"
        Me.rdoCorrelationPlot.UseVisualStyleBackColor = True
        '
        'rdoScatterPlotMatrix
        '
        Me.rdoScatterPlotMatrix.AutoSize = True
        Me.rdoScatterPlotMatrix.Location = New System.Drawing.Point(218, 57)
        Me.rdoScatterPlotMatrix.Name = "rdoScatterPlotMatrix"
        Me.rdoScatterPlotMatrix.Size = New System.Drawing.Size(90, 17)
        Me.rdoScatterPlotMatrix.TabIndex = 5
        Me.rdoScatterPlotMatrix.Text = "Scatter Matrix"
        Me.rdoScatterPlotMatrix.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucrPnlGraphType)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 98)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Graphs"
        '
        'ucrPnlGraphType
        '
        Me.ucrPnlGraphType.Location = New System.Drawing.Point(12, 19)
        Me.ucrPnlGraphType.Name = "ucrPnlGraphType"
        Me.ucrPnlGraphType.Size = New System.Drawing.Size(318, 73)
        Me.ucrPnlGraphType.TabIndex = 1
        '
        'lblFactorVariable
        '
        Me.lblFactorVariable.AutoSize = True
        Me.lblFactorVariable.Location = New System.Drawing.Point(238, 163)
        Me.lblFactorVariable.Name = "lblFactorVariable"
        Me.lblFactorVariable.Size = New System.Drawing.Size(81, 13)
        Me.lblFactorVariable.TabIndex = 11
        Me.lblFactorVariable.Tag = "Factor_Variable"
        Me.lblFactorVariable.Text = "Factor Variable:"
        '
        'lblAlpha
        '
        Me.lblAlpha.AutoSize = True
        Me.lblAlpha.Location = New System.Drawing.Point(15, 114)
        Me.lblAlpha.Name = "lblAlpha"
        Me.lblAlpha.Size = New System.Drawing.Size(37, 13)
        Me.lblAlpha.TabIndex = 7
        Me.lblAlpha.Tag = "Alpha"
        Me.lblAlpha.Text = "Alpha:"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrChkLabel)
        Me.grpOptions.Controls.Add(Me.lblgeom)
        Me.grpOptions.Controls.Add(Me.ucrNudAlphaCorr)
        Me.grpOptions.Controls.Add(Me.ucrInputComboGeom)
        Me.grpOptions.Controls.Add(Me.ucrNudMaximumSize)
        Me.grpOptions.Controls.Add(Me.lblMaximumSize)
        Me.grpOptions.Controls.Add(Me.ucrNudMinimunSize)
        Me.grpOptions.Controls.Add(Me.lblMinimumSize)
        Me.grpOptions.Controls.Add(Me.lblLabelAlpha)
        Me.grpOptions.Location = New System.Drawing.Point(10, 112)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(346, 269)
        Me.grpOptions.TabIndex = 6
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'ucrChkLabel
        '
        Me.ucrChkLabel.Checked = False
        Me.ucrChkLabel.Location = New System.Drawing.Point(51, 51)
        Me.ucrChkLabel.Name = "ucrChkLabel"
        Me.ucrChkLabel.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkLabel.TabIndex = 4
        '
        'lblgeom
        '
        Me.lblgeom.AutoSize = True
        Me.lblgeom.Location = New System.Drawing.Point(9, 20)
        Me.lblgeom.Name = "lblgeom"
        Me.lblgeom.Size = New System.Drawing.Size(38, 13)
        Me.lblgeom.TabIndex = 0
        Me.lblgeom.Tag = "geom"
        Me.lblgeom.Text = "Geom:"
        '
        'ucrNudAlphaCorr
        '
        Me.ucrNudAlphaCorr.DecimalPlaces = New Decimal(New Integer() {2, 0, 0, 0})
        Me.ucrNudAlphaCorr.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAlphaCorr.Location = New System.Drawing.Point(125, 81)
        Me.ucrNudAlphaCorr.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAlphaCorr.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAlphaCorr.Name = "ucrNudAlphaCorr"
        Me.ucrNudAlphaCorr.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAlphaCorr.TabIndex = 8
        Me.ucrNudAlphaCorr.Value = New Decimal(New Integer() {100, 0, 0, 131072})
        '
        'ucrInputComboGeom
        '
        Me.ucrInputComboGeom.AddQuotesIfUnrecognised = True
        Me.ucrInputComboGeom.IsReadOnly = False
        Me.ucrInputComboGeom.Location = New System.Drawing.Point(51, 15)
        Me.ucrInputComboGeom.Name = "ucrInputComboGeom"
        Me.ucrInputComboGeom.Size = New System.Drawing.Size(73, 21)
        Me.ucrInputComboGeom.TabIndex = 1
        '
        'ucrNudMaximumSize
        '
        Me.ucrNudMaximumSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximumSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaximumSize.Location = New System.Drawing.Point(125, 144)
        Me.ucrNudMaximumSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaximumSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximumSize.Name = "ucrNudMaximumSize"
        Me.ucrNudMaximumSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaximumSize.TabIndex = 6
        Me.ucrNudMaximumSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMaximumSize
        '
        Me.lblMaximumSize.AutoSize = True
        Me.lblMaximumSize.Location = New System.Drawing.Point(44, 147)
        Me.lblMaximumSize.Name = "lblMaximumSize"
        Me.lblMaximumSize.Size = New System.Drawing.Size(77, 13)
        Me.lblMaximumSize.TabIndex = 5
        Me.lblMaximumSize.Tag = "Maximum_Size"
        Me.lblMaximumSize.Text = "Maximum Size:"
        '
        'ucrNudMinimunSize
        '
        Me.ucrNudMinimunSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinimunSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinimunSize.Location = New System.Drawing.Point(125, 109)
        Me.ucrNudMinimunSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinimunSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinimunSize.Name = "ucrNudMinimunSize"
        Me.ucrNudMinimunSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMinimunSize.TabIndex = 3
        Me.ucrNudMinimunSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMinimumSize
        '
        Me.lblMinimumSize.AutoSize = True
        Me.lblMinimumSize.Location = New System.Drawing.Point(44, 113)
        Me.lblMinimumSize.Name = "lblMinimumSize"
        Me.lblMinimumSize.Size = New System.Drawing.Size(74, 13)
        Me.lblMinimumSize.TabIndex = 2
        Me.lblMinimumSize.Tag = "Minimum_Size"
        Me.lblMinimumSize.Text = "Minimum Size:"
        '
        'lblLabelAlpha
        '
        Me.lblLabelAlpha.AutoSize = True
        Me.lblLabelAlpha.Location = New System.Drawing.Point(44, 84)
        Me.lblLabelAlpha.Name = "lblLabelAlpha"
        Me.lblLabelAlpha.Size = New System.Drawing.Size(66, 13)
        Me.lblLabelAlpha.TabIndex = 7
        Me.lblLabelAlpha.Tag = "Label_Alpha"
        Me.lblLabelAlpha.Text = "Label Alpha:"
        '
        'ucrSelectFactor
        '
        Me.ucrSelectFactor.bShowHiddenColumns = False
        Me.ucrSelectFactor.bUseCurrentFilter = True
        Me.ucrSelectFactor.Location = New System.Drawing.Point(15, 161)
        Me.ucrSelectFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectFactor.Name = "ucrSelectFactor"
        Me.ucrSelectFactor.Size = New System.Drawing.Size(226, 188)
        Me.ucrSelectFactor.TabIndex = 10
        '
        'ucrNudAlpha
        '
        Me.ucrNudAlpha.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAlpha.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAlpha.Location = New System.Drawing.Point(54, 112)
        Me.ucrNudAlpha.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAlpha.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAlpha.Name = "ucrNudAlpha"
        Me.ucrNudAlpha.Size = New System.Drawing.Size(46, 19)
        Me.ucrNudAlpha.TabIndex = 8
        Me.ucrNudAlpha.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiveFactor
        '
        Me.ucrReceiveFactor.frmParent = Me
        Me.ucrReceiveFactor.Location = New System.Drawing.Point(240, 178)
        Me.ucrReceiveFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiveFactor.Name = "ucrReceiveFactor"
        Me.ucrReceiveFactor.Selector = Nothing
        Me.ucrReceiveFactor.Size = New System.Drawing.Size(116, 19)
        Me.ucrReceiveFactor.strNcFilePath = ""
        Me.ucrReceiveFactor.TabIndex = 12
        Me.ucrReceiveFactor.ucrSelector = Nothing
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(16, 387)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(253, 24)
        Me.ucrSaveGraph.TabIndex = 13
        '
        'ucrChkColor
        '
        Me.ucrChkColor.Checked = False
        Me.ucrChkColor.Location = New System.Drawing.Point(15, 137)
        Me.ucrChkColor.Name = "ucrChkColor"
        Me.ucrChkColor.Size = New System.Drawing.Size(141, 19)
        Me.ucrChkColor.TabIndex = 9
        '
        'ucrBaseSdgCorrPlot
        '
        Me.ucrBaseSdgCorrPlot.Location = New System.Drawing.Point(108, 418)
        Me.ucrBaseSdgCorrPlot.Name = "ucrBaseSdgCorrPlot"
        Me.ucrBaseSdgCorrPlot.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSdgCorrPlot.TabIndex = 14
        '
        'sdgCorrPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 452)
        Me.Controls.Add(Me.ucrSelectFactor)
        Me.Controls.Add(Me.ucrNudAlpha)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.ucrReceiveFactor)
        Me.Controls.Add(Me.lblAlpha)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.lblFactorVariable)
        Me.Controls.Add(Me.rdoScatterPlotMatrix)
        Me.Controls.Add(Me.ucrChkColor)
        Me.Controls.Add(Me.rdoCorrelationPlot)
        Me.Controls.Add(Me.rdoPairwisePlot)
        Me.Controls.Add(Me.rdoNone)
        Me.Controls.Add(Me.ucrBaseSdgCorrPlot)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCorrPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Correlation_Display_and_Graphics"
        Me.Text = "Correlation Display and Graphics"
        Me.GroupBox1.ResumeLayout(False)
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSdgCorrPlot As ucrButtonsSubdialogue
    Friend WithEvents grpGraphs As GroupBox
    Friend WithEvents ucrPnlGraphType As UcrPanel
    Friend WithEvents rdoScatterPlotMatrix As RadioButton
    Friend WithEvents rdoCorrelationPlot As RadioButton
    Friend WithEvents rdoPairwisePlot As RadioButton
    Friend WithEvents rdoNone As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrChkColor As ucrCheck
    Friend WithEvents lblFactorVariable As Label
    Friend WithEvents lblAlpha As Label
    Friend WithEvents ucrReceiveFactor As ucrReceiverSingle
    Friend WithEvents ucrSelectFactor As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrNudAlpha As ucrNud
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents ucrChkLabel As ucrCheck
    Friend WithEvents lblgeom As Label
    Friend WithEvents ucrNudAlphaCorr As ucrNud
    Friend WithEvents ucrInputComboGeom As ucrInputComboBox
    Friend WithEvents ucrNudMaximumSize As ucrNud
    Friend WithEvents lblMaximumSize As Label
    Friend WithEvents ucrNudMinimunSize As ucrNud
    Friend WithEvents lblMinimumSize As Label
    Friend WithEvents lblLabelAlpha As Label
End Class