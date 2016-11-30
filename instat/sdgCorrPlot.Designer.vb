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
        Me.chkCorrelationMatrix = New System.Windows.Forms.CheckBox()
        Me.chkScatterplotMatrix = New System.Windows.Forms.CheckBox()
        Me.chkCorrelationPlot = New System.Windows.Forms.CheckBox()
        Me.chkPairwisePlot = New System.Windows.Forms.CheckBox()
        Me.tbSaveGraphs = New System.Windows.Forms.TabControl()
        Me.tbPairwisePlot = New System.Windows.Forms.TabPage()
        Me.tbCorrelationPlot = New System.Windows.Forms.TabPage()
        Me.chkLabel = New System.Windows.Forms.CheckBox()
        Me.nudAlphaCorr = New System.Windows.Forms.NumericUpDown()
        Me.nudMaximumSize = New System.Windows.Forms.NumericUpDown()
        Me.nudMinimunSize = New System.Windows.Forms.NumericUpDown()
        Me.lblMaximumSize = New System.Windows.Forms.Label()
        Me.cmbgeom = New System.Windows.Forms.ComboBox()
        Me.lblLabelAlpha = New System.Windows.Forms.Label()
        Me.lblMinimumSize = New System.Windows.Forms.Label()
        Me.lblgeom = New System.Windows.Forms.Label()
        Me.tbScatterplotMatrix = New System.Windows.Forms.TabPage()
        Me.ucrSelectFactor = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblFactorVariable = New System.Windows.Forms.Label()
        Me.chkColour = New System.Windows.Forms.CheckBox()
        Me.lblAlpha = New System.Windows.Forms.Label()
        Me.nudAlphaScatter = New System.Windows.Forms.NumericUpDown()
        Me.ucrReceiveFactor = New instat.ucrReceiverSingle()
        Me.ucrBaseSdgCorrPlot = New instat.ucrButtonsSubdialogue()
        Me.ucrSaveGraph = New instat.ucrSaveGraph()
        Me.tbSaveGraphs.SuspendLayout()
        Me.tbCorrelationPlot.SuspendLayout()
        CType(Me.nudAlphaCorr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaximumSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinimunSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbScatterplotMatrix.SuspendLayout()
        CType(Me.nudAlphaScatter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkCorrelationMatrix
        '
        Me.chkCorrelationMatrix.AutoSize = True
        Me.chkCorrelationMatrix.Location = New System.Drawing.Point(10, 10)
        Me.chkCorrelationMatrix.Name = "chkCorrelationMatrix"
        Me.chkCorrelationMatrix.Size = New System.Drawing.Size(107, 17)
        Me.chkCorrelationMatrix.TabIndex = 0
        Me.chkCorrelationMatrix.Tag = "Correlation_Matrix"
        Me.chkCorrelationMatrix.Text = "Correlation Matrix"
        Me.chkCorrelationMatrix.UseVisualStyleBackColor = True
        '
        'chkScatterplotMatrix
        '
        Me.chkScatterplotMatrix.AutoSize = True
        Me.chkScatterplotMatrix.Location = New System.Drawing.Point(10, 79)
        Me.chkScatterplotMatrix.Name = "chkScatterplotMatrix"
        Me.chkScatterplotMatrix.Size = New System.Drawing.Size(108, 17)
        Me.chkScatterplotMatrix.TabIndex = 1
        Me.chkScatterplotMatrix.Tag = "Scatterplot_Matrix"
        Me.chkScatterplotMatrix.Text = "Scatterplot Matrix"
        Me.chkScatterplotMatrix.UseVisualStyleBackColor = True
        '
        'chkCorrelationPlot
        '
        Me.chkCorrelationPlot.AutoSize = True
        Me.chkCorrelationPlot.Location = New System.Drawing.Point(10, 56)
        Me.chkCorrelationPlot.Name = "chkCorrelationPlot"
        Me.chkCorrelationPlot.Size = New System.Drawing.Size(97, 17)
        Me.chkCorrelationPlot.TabIndex = 2
        Me.chkCorrelationPlot.Tag = "Correlation_Plot"
        Me.chkCorrelationPlot.Text = "Correlation Plot"
        Me.chkCorrelationPlot.UseVisualStyleBackColor = True
        '
        'chkPairwisePlot
        '
        Me.chkPairwisePlot.AutoSize = True
        Me.chkPairwisePlot.Location = New System.Drawing.Point(10, 33)
        Me.chkPairwisePlot.Name = "chkPairwisePlot"
        Me.chkPairwisePlot.Size = New System.Drawing.Size(89, 17)
        Me.chkPairwisePlot.TabIndex = 3
        Me.chkPairwisePlot.Tag = "Pairwise_Plot"
        Me.chkPairwisePlot.Text = "Pairwise_Plot"
        Me.chkPairwisePlot.UseVisualStyleBackColor = True
        '
        'tbSaveGraphs
        '
        Me.tbSaveGraphs.Controls.Add(Me.tbPairwisePlot)
        Me.tbSaveGraphs.Controls.Add(Me.tbCorrelationPlot)
        Me.tbSaveGraphs.Controls.Add(Me.tbScatterplotMatrix)
        Me.tbSaveGraphs.Location = New System.Drawing.Point(10, 102)
        Me.tbSaveGraphs.Name = "tbSaveGraphs"
        Me.tbSaveGraphs.SelectedIndex = 0
        Me.tbSaveGraphs.Size = New System.Drawing.Size(352, 283)
        Me.tbSaveGraphs.TabIndex = 4
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
        'ucrReceiveFactor
        '
        Me.ucrReceiveFactor.Location = New System.Drawing.Point(213, 81)
        Me.ucrReceiveFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiveFactor.Name = "ucrReceiveFactor"
        Me.ucrReceiveFactor.Selector = Nothing
        Me.ucrReceiveFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiveFactor.TabIndex = 12
        '
        'ucrBaseSdgCorrPlot
        '
        Me.ucrBaseSdgCorrPlot.Location = New System.Drawing.Point(108, 419)
        Me.ucrBaseSdgCorrPlot.Name = "ucrBaseSdgCorrPlot"
        Me.ucrBaseSdgCorrPlot.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSdgCorrPlot.TabIndex = 6
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(14, 391)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(236, 22)
        Me.ucrSaveGraph.TabIndex = 5
        '
        'sdgCorrPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 455)
        Me.Controls.Add(Me.chkCorrelationMatrix)
        Me.Controls.Add(Me.chkScatterplotMatrix)
        Me.Controls.Add(Me.ucrBaseSdgCorrPlot)
        Me.Controls.Add(Me.chkPairwisePlot)
        Me.Controls.Add(Me.chkCorrelationPlot)
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
        CType(Me.nudAlphaCorr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMaximumSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinimunSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbScatterplotMatrix.ResumeLayout(False)
        Me.tbScatterplotMatrix.PerformLayout()
        CType(Me.nudAlphaScatter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSdgCorrPlot As ucrButtonsSubdialogue
    Friend WithEvents ucrSaveGraph As ucrSaveGraph
    Friend WithEvents tbSaveGraphs As TabControl
    Friend WithEvents tbPairwisePlot As TabPage
    Friend WithEvents tbCorrelationPlot As TabPage
    Friend WithEvents tbScatterplotMatrix As TabPage
    Friend WithEvents chkCorrelationMatrix As CheckBox
    Friend WithEvents chkScatterplotMatrix As CheckBox
    Friend WithEvents chkCorrelationPlot As CheckBox
    Friend WithEvents chkPairwisePlot As CheckBox
    Friend WithEvents chkLabel As CheckBox
    Friend WithEvents nudAlphaCorr As NumericUpDown
    Friend WithEvents nudMaximumSize As NumericUpDown
    Friend WithEvents nudMinimunSize As NumericUpDown
    Friend WithEvents lblMaximumSize As Label
    Friend WithEvents cmbgeom As ComboBox
    Friend WithEvents lblLabelAlpha As Label
    Friend WithEvents lblMinimumSize As Label
    Friend WithEvents lblgeom As Label
    Friend WithEvents chkColour As CheckBox
    Friend WithEvents lblAlpha As Label
    Friend WithEvents nudAlphaScatter As NumericUpDown
    Friend WithEvents ucrReceiveFactor As ucrReceiverSingle
    Friend WithEvents lblFactorVariable As Label
    Friend WithEvents ucrSelectFactor As ucrSelectorByDataFrameAddRemove
End Class
