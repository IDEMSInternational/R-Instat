﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.chkLabel = New System.Windows.Forms.CheckBox()
        Me.lblMaximumSize = New System.Windows.Forms.Label()
        Me.cmbgeom = New System.Windows.Forms.ComboBox()
        Me.lblLabelAlpha = New System.Windows.Forms.Label()
        Me.lblMinimumSize = New System.Windows.Forms.Label()
        Me.lblgeom = New System.Windows.Forms.Label()
        Me.tbScatterplotMatrix = New System.Windows.Forms.TabPage()
        Me.lblFactorVariable = New System.Windows.Forms.Label()
        Me.chkColour = New System.Windows.Forms.CheckBox()
        Me.lblAlpha = New System.Windows.Forms.Label()
        Me.ucrReceiveFactor = New instat.ucrReceiverSingle()
        Me.rdoScatterplotMatrix = New System.Windows.Forms.RadioButton()
        Me.rdoCorrelationPlot = New System.Windows.Forms.RadioButton()
        Me.rdoPairwisePlot = New System.Windows.Forms.RadioButton()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.grpGraphs = New System.Windows.Forms.GroupBox()
        Me.ucrBaseSdgCorrPlot = New instat.ucrButtonsSubdialogue()
        Me.ucrSaveGraph = New instat.ucrSaveGraph()
        Me.ucrSelectFactor = New instat.ucrSelectorByDataFrameAddRemove()
        Me.nudAlphaScatter = New System.Windows.Forms.NumericUpDown()
        Me.nudMinimunSize = New System.Windows.Forms.NumericUpDown()
        Me.nudMaximumSize = New System.Windows.Forms.NumericUpDown()
        Me.nudAlphaCorr = New System.Windows.Forms.NumericUpDown()
        Me.tbSaveGraphs.SuspendLayout()
        Me.tbCorrelationPlot.SuspendLayout()
        Me.tbScatterplotMatrix.SuspendLayout()
        Me.grpGraphs.SuspendLayout()
        CType(Me.nudAlphaScatter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinimunSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaximumSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAlphaCorr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbSaveGraphs
        '
        Me.tbSaveGraphs.Controls.Add(Me.tbPairwisePlot)
        Me.tbSaveGraphs.Controls.Add(Me.tbCorrelationPlot)
        Me.tbSaveGraphs.Controls.Add(Me.tbScatterplotMatrix)
        Me.tbSaveGraphs.Location = New System.Drawing.Point(10, 75)
        Me.tbSaveGraphs.Name = "tbSaveGraphs"
        Me.tbSaveGraphs.SelectedIndex = 0
        Me.tbSaveGraphs.Size = New System.Drawing.Size(352, 283)
        Me.tbSaveGraphs.TabIndex = 1
        '
        'tbPairwisePlot
        '
        Me.tbPairwisePlot.Location = New System.Drawing.Point(4, 22)
        Me.tbPairwisePlot.Name = "tbPairwisePlot"
        Me.tbPairwisePlot.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPairwisePlot.Size = New System.Drawing.Size(344, 257)
        Me.tbPairwisePlot.TabIndex = 0
        Me.tbPairwisePlot.Tag = "Pairwise_Plot"
        Me.tbPairwisePlot.Text = "Pairwise Plot"
        Me.tbPairwisePlot.UseVisualStyleBackColor = True
        '
        'tbCorrelationPlot
        '
        Me.tbCorrelationPlot.Controls.Add(Me.chkLabel)
        Me.tbCorrelationPlot.Controls.Add(Me.nudAlphaCorr)
        Me.tbCorrelationPlot.Controls.Add(Me.nudMaximumSize)
        Me.tbCorrelationPlot.Controls.Add(Me.nudMinimunSize)
        Me.tbCorrelationPlot.Controls.Add(Me.lblMaximumSize)
        Me.tbCorrelationPlot.Controls.Add(Me.cmbgeom)
        Me.tbCorrelationPlot.Controls.Add(Me.lblLabelAlpha)
        Me.tbCorrelationPlot.Controls.Add(Me.lblMinimumSize)
        Me.tbCorrelationPlot.Controls.Add(Me.lblgeom)
        Me.tbCorrelationPlot.Location = New System.Drawing.Point(4, 22)
        Me.tbCorrelationPlot.Name = "tbCorrelationPlot"
        Me.tbCorrelationPlot.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCorrelationPlot.Size = New System.Drawing.Size(344, 257)
        Me.tbCorrelationPlot.TabIndex = 1
        Me.tbCorrelationPlot.Tag = "Correlation_Plot"
        Me.tbCorrelationPlot.Text = "Correlation Plot"
        Me.tbCorrelationPlot.UseVisualStyleBackColor = True
        '
        'chkLabel
        '
        Me.chkLabel.AutoSize = True
        Me.chkLabel.Location = New System.Drawing.Point(11, 76)
        Me.chkLabel.Name = "chkLabel"
        Me.chkLabel.Size = New System.Drawing.Size(52, 17)
        Me.chkLabel.TabIndex = 27
        Me.chkLabel.Tag = "Label"
        Me.chkLabel.Text = "Label"
        Me.chkLabel.UseVisualStyleBackColor = True
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
        'cmbgeom
        '
        Me.cmbgeom.FormattingEnabled = True
        Me.cmbgeom.Items.AddRange(New Object() {"tile", "circle", "text", "blank"})
        Me.cmbgeom.Location = New System.Drawing.Point(65, 17)
        Me.cmbgeom.Name = "cmbgeom"
        Me.cmbgeom.Size = New System.Drawing.Size(121, 21)
        Me.cmbgeom.TabIndex = 22
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
        Me.tbScatterplotMatrix.Controls.Add(Me.ucrSelectFactor)
        Me.tbScatterplotMatrix.Controls.Add(Me.lblFactorVariable)
        Me.tbScatterplotMatrix.Controls.Add(Me.chkColour)
        Me.tbScatterplotMatrix.Controls.Add(Me.lblAlpha)
        Me.tbScatterplotMatrix.Controls.Add(Me.nudAlphaScatter)
        Me.tbScatterplotMatrix.Controls.Add(Me.ucrReceiveFactor)
        Me.tbScatterplotMatrix.Location = New System.Drawing.Point(4, 22)
        Me.tbScatterplotMatrix.Name = "tbScatterplotMatrix"
        Me.tbScatterplotMatrix.Padding = New System.Windows.Forms.Padding(3)
        Me.tbScatterplotMatrix.Size = New System.Drawing.Size(344, 257)
        Me.tbScatterplotMatrix.TabIndex = 2
        Me.tbScatterplotMatrix.Tag = "Scatterplot_Matrix"
        Me.tbScatterplotMatrix.Text = "Scatterplot Matrix"
        Me.tbScatterplotMatrix.UseVisualStyleBackColor = True
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
        'chkColour
        '
        Me.chkColour.AutoSize = True
        Me.chkColour.Location = New System.Drawing.Point(7, 38)
        Me.chkColour.Name = "chkColour"
        Me.chkColour.Size = New System.Drawing.Size(103, 17)
        Me.chkColour.TabIndex = 9
        Me.chkColour.Tag = "Colour by Factor"
        Me.chkColour.Text = "Colour by Factor"
        Me.chkColour.UseVisualStyleBackColor = True
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
        Me.ucrReceiveFactor.Location = New System.Drawing.Point(213, 81)
        Me.ucrReceiveFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiveFactor.Name = "ucrReceiveFactor"
        Me.ucrReceiveFactor.Selector = Nothing
        Me.ucrReceiveFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiveFactor.TabIndex = 12
        '
        'rdoScatterplotMatrix
        '
        Me.rdoScatterplotMatrix.AutoSize = True
        Me.rdoScatterplotMatrix.Location = New System.Drawing.Point(177, 41)
        Me.rdoScatterplotMatrix.Name = "rdoScatterplotMatrix"
        Me.rdoScatterplotMatrix.Size = New System.Drawing.Size(107, 17)
        Me.rdoScatterplotMatrix.TabIndex = 3
        Me.rdoScatterplotMatrix.Tag = "Scatterplot_Matrix"
        Me.rdoScatterplotMatrix.Text = "Scatterplot Matrix"
        Me.rdoScatterplotMatrix.UseVisualStyleBackColor = True
        '
        'rdoCorrelationPlot
        '
        Me.rdoCorrelationPlot.AutoSize = True
        Me.rdoCorrelationPlot.Location = New System.Drawing.Point(177, 19)
        Me.rdoCorrelationPlot.Name = "rdoCorrelationPlot"
        Me.rdoCorrelationPlot.Size = New System.Drawing.Size(96, 17)
        Me.rdoCorrelationPlot.TabIndex = 1
        Me.rdoCorrelationPlot.Tag = "Correlation_Plot"
        Me.rdoCorrelationPlot.Text = "Correlation Plot"
        Me.rdoCorrelationPlot.UseVisualStyleBackColor = True
        '
        'rdoPairwisePlot
        '
        Me.rdoPairwisePlot.AutoSize = True
        Me.rdoPairwisePlot.Location = New System.Drawing.Point(6, 41)
        Me.rdoPairwisePlot.Name = "rdoPairwisePlot"
        Me.rdoPairwisePlot.Size = New System.Drawing.Size(85, 17)
        Me.rdoPairwisePlot.TabIndex = 2
        Me.rdoPairwisePlot.Tag = "Pairwise_Plot"
        Me.rdoPairwisePlot.Text = "Pairwise Plot"
        Me.rdoPairwisePlot.UseVisualStyleBackColor = True
        '
        'rdoNone
        '
        Me.rdoNone.AutoSize = True
        Me.rdoNone.Checked = True
        Me.rdoNone.Location = New System.Drawing.Point(6, 19)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(51, 17)
        Me.rdoNone.TabIndex = 0
        Me.rdoNone.TabStop = True
        Me.rdoNone.Tag = "None"
        Me.rdoNone.Text = "None"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'grpGraphs
        '
        Me.grpGraphs.Controls.Add(Me.rdoScatterplotMatrix)
        Me.grpGraphs.Controls.Add(Me.rdoCorrelationPlot)
        Me.grpGraphs.Controls.Add(Me.rdoPairwisePlot)
        Me.grpGraphs.Controls.Add(Me.rdoNone)
        Me.grpGraphs.Location = New System.Drawing.Point(10, 6)
        Me.grpGraphs.Name = "grpGraphs"
        Me.grpGraphs.Size = New System.Drawing.Size(348, 64)
        Me.grpGraphs.TabIndex = 0
        Me.grpGraphs.TabStop = False
        Me.grpGraphs.Tag = "Graphs"
        Me.grpGraphs.Text = "Graphs"
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
        Me.ucrSaveGraph.Location = New System.Drawing.Point(13, 364)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(236, 22)
        Me.ucrSaveGraph.TabIndex = 2
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
        'nudAlphaScatter
        '
        Me.nudAlphaScatter.DecimalPlaces = 2
        Me.nudAlphaScatter.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudAlphaScatter.Location = New System.Drawing.Point(46, 11)
        Me.nudAlphaScatter.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudAlphaScatter.Name = "nudAlphaScatter"
        Me.nudAlphaScatter.Size = New System.Drawing.Size(51, 20)
        Me.nudAlphaScatter.TabIndex = 7
        Me.nudAlphaScatter.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudMinimunSize
        '
        Me.nudMinimunSize.Location = New System.Drawing.Point(84, 47)
        Me.nudMinimunSize.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudMinimunSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMinimunSize.Name = "nudMinimunSize"
        Me.nudMinimunSize.Size = New System.Drawing.Size(31, 20)
        Me.nudMinimunSize.TabIndex = 24
        Me.nudMinimunSize.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'nudMaximumSize
        '
        Me.nudMaximumSize.Location = New System.Drawing.Point(248, 47)
        Me.nudMaximumSize.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudMaximumSize.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudMaximumSize.Name = "nudMaximumSize"
        Me.nudMaximumSize.Size = New System.Drawing.Size(31, 20)
        Me.nudMaximumSize.TabIndex = 25
        Me.nudMaximumSize.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'nudAlphaCorr
        '
        Me.nudAlphaCorr.DecimalPlaces = 2
        Me.nudAlphaCorr.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudAlphaCorr.Location = New System.Drawing.Point(239, 75)
        Me.nudAlphaCorr.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudAlphaCorr.Name = "nudAlphaCorr"
        Me.nudAlphaCorr.Size = New System.Drawing.Size(51, 20)
        Me.nudAlphaCorr.TabIndex = 26
        Me.nudAlphaCorr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'sdgCorrPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 428)
        Me.Controls.Add(Me.grpGraphs)
        Me.Controls.Add(Me.ucrBaseSdgCorrPlot)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.tbSaveGraphs)
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
        Me.grpGraphs.ResumeLayout(False)
        Me.grpGraphs.PerformLayout()
        CType(Me.nudAlphaScatter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinimunSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMaximumSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAlphaCorr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseSdgCorrPlot As ucrButtonsSubdialogue
    Friend WithEvents ucrSaveGraph As ucrSaveGraph
    Friend WithEvents tbSaveGraphs As TabControl
    Friend WithEvents tbPairwisePlot As TabPage
    Friend WithEvents tbCorrelationPlot As TabPage
    Friend WithEvents tbScatterplotMatrix As TabPage
    Friend WithEvents chkLabel As CheckBox
    Friend WithEvents lblMaximumSize As Label
    Friend WithEvents cmbgeom As ComboBox
    Friend WithEvents lblLabelAlpha As Label
    Friend WithEvents lblMinimumSize As Label
    Friend WithEvents lblgeom As Label
    Friend WithEvents chkColour As CheckBox
    Friend WithEvents lblAlpha As Label
    Friend WithEvents ucrReceiveFactor As ucrReceiverSingle
    Friend WithEvents lblFactorVariable As Label
    Friend WithEvents ucrSelectFactor As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoScatterplotMatrix As RadioButton
    Friend WithEvents rdoCorrelationPlot As RadioButton
    Friend WithEvents rdoPairwisePlot As RadioButton
    Friend WithEvents rdoNone As RadioButton
    Friend WithEvents grpGraphs As GroupBox
    Friend WithEvents nudAlphaScatter As NumericUpDown
    Friend WithEvents nudMinimunSize As NumericUpDown
    Friend WithEvents nudMaximumSize As NumericUpDown
    Friend WithEvents nudAlphaCorr As NumericUpDown
End Class