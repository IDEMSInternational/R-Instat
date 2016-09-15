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
        Me.tbSdgCorrelation = New System.Windows.Forms.TabControl()
        Me.tbDisplay = New System.Windows.Forms.TabPage()
        Me.chkCorrelationMatrix = New System.Windows.Forms.CheckBox()
        Me.tbGraphics = New System.Windows.Forms.TabPage()
        Me.ucrSaveGraph = New instat.ucrSaveGraph()
        Me.tbSaveGraphs = New System.Windows.Forms.TabControl()
        Me.tbPairwisePlot = New System.Windows.Forms.TabPage()
        Me.tbCorrelationPlot = New System.Windows.Forms.TabPage()
        Me.chkLabel = New System.Windows.Forms.CheckBox()
        Me.nudLabelAlpha = New System.Windows.Forms.NumericUpDown()
        Me.nudMaximumSize = New System.Windows.Forms.NumericUpDown()
        Me.nudMinimunSize = New System.Windows.Forms.NumericUpDown()
        Me.lblMaximumSize = New System.Windows.Forms.Label()
        Me.cmbgeom = New System.Windows.Forms.ComboBox()
        Me.lblLabelAlpha = New System.Windows.Forms.Label()
        Me.lblMinimumSize = New System.Windows.Forms.Label()
        Me.lblgeom = New System.Windows.Forms.Label()
        Me.tbScatterplotMatrix = New System.Windows.Forms.TabPage()
        Me.chkColor = New System.Windows.Forms.CheckBox()
        Me.lblAlpha = New System.Windows.Forms.Label()
        Me.nudAlpha = New System.Windows.Forms.NumericUpDown()
        Me.grpGraphOptions = New System.Windows.Forms.GroupBox()
        Me.rdoScatterplotMatrix = New System.Windows.Forms.RadioButton()
        Me.rdoCorrelationPlot = New System.Windows.Forms.RadioButton()
        Me.rdoPairwisePlot = New System.Windows.Forms.RadioButton()
        Me.ucrBaseSdgCorrPlot = New instat.ucrButtonsSubdialogue()
        Me.tbSdgCorrelation.SuspendLayout()
        Me.tbDisplay.SuspendLayout()
        Me.tbGraphics.SuspendLayout()
        Me.tbSaveGraphs.SuspendLayout()
        Me.tbCorrelationPlot.SuspendLayout()
        CType(Me.nudLabelAlpha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaximumSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinimunSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbScatterplotMatrix.SuspendLayout()
        CType(Me.nudAlpha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGraphOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbSdgCorrelation
        '
        Me.tbSdgCorrelation.Controls.Add(Me.tbDisplay)
        Me.tbSdgCorrelation.Controls.Add(Me.tbGraphics)
        Me.tbSdgCorrelation.Location = New System.Drawing.Point(12, 12)
        Me.tbSdgCorrelation.Name = "tbSdgCorrelation"
        Me.tbSdgCorrelation.SelectedIndex = 0
        Me.tbSdgCorrelation.Size = New System.Drawing.Size(274, 266)
        Me.tbSdgCorrelation.TabIndex = 1
        Me.tbSdgCorrelation.Tag = ""
        '
        'tbDisplay
        '
        Me.tbDisplay.Controls.Add(Me.chkCorrelationMatrix)
        Me.tbDisplay.Location = New System.Drawing.Point(4, 22)
        Me.tbDisplay.Name = "tbDisplay"
        Me.tbDisplay.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDisplay.Size = New System.Drawing.Size(266, 240)
        Me.tbDisplay.TabIndex = 1
        Me.tbDisplay.Tag = "Display"
        Me.tbDisplay.Text = "Display"
        Me.tbDisplay.UseVisualStyleBackColor = True
        '
        'chkCorrelationMatrix
        '
        Me.chkCorrelationMatrix.AutoSize = True
        Me.chkCorrelationMatrix.Location = New System.Drawing.Point(16, 21)
        Me.chkCorrelationMatrix.Name = "chkCorrelationMatrix"
        Me.chkCorrelationMatrix.Size = New System.Drawing.Size(107, 17)
        Me.chkCorrelationMatrix.TabIndex = 1
        Me.chkCorrelationMatrix.Tag = "Correlation_Matrix"
        Me.chkCorrelationMatrix.Text = "Correlation Matrix"
        Me.chkCorrelationMatrix.UseVisualStyleBackColor = True
        '
        'tbGraphics
        '
        Me.tbGraphics.Controls.Add(Me.ucrSaveGraph)
        Me.tbGraphics.Controls.Add(Me.tbSaveGraphs)
        Me.tbGraphics.Controls.Add(Me.grpGraphOptions)
        Me.tbGraphics.Location = New System.Drawing.Point(4, 22)
        Me.tbGraphics.Name = "tbGraphics"
        Me.tbGraphics.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGraphics.Size = New System.Drawing.Size(266, 240)
        Me.tbGraphics.TabIndex = 2
        Me.tbGraphics.Tag = "Graphics"
        Me.tbGraphics.Text = "Graphics"
        Me.tbGraphics.UseVisualStyleBackColor = True
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(16, 92)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(225, 22)
        Me.ucrSaveGraph.TabIndex = 7
        '
        'tbSaveGraphs
        '
        Me.tbSaveGraphs.Controls.Add(Me.tbPairwisePlot)
        Me.tbSaveGraphs.Controls.Add(Me.tbCorrelationPlot)
        Me.tbSaveGraphs.Controls.Add(Me.tbScatterplotMatrix)
        Me.tbSaveGraphs.Location = New System.Drawing.Point(9, 120)
        Me.tbSaveGraphs.Name = "tbSaveGraphs"
        Me.tbSaveGraphs.SelectedIndex = 0
        Me.tbSaveGraphs.Size = New System.Drawing.Size(252, 114)
        Me.tbSaveGraphs.TabIndex = 6
        '
        'tbPairwisePlot
        '
        Me.tbPairwisePlot.Location = New System.Drawing.Point(4, 22)
        Me.tbPairwisePlot.Name = "tbPairwisePlot"
        Me.tbPairwisePlot.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPairwisePlot.Size = New System.Drawing.Size(244, 88)
        Me.tbPairwisePlot.TabIndex = 0
        Me.tbPairwisePlot.Tag = "Pairwise_Plot"
        Me.tbPairwisePlot.Text = "Pairwise Plot"
        Me.tbPairwisePlot.UseVisualStyleBackColor = True
        '
        'tbCorrelationPlot
        '
        Me.tbCorrelationPlot.Controls.Add(Me.chkLabel)
        Me.tbCorrelationPlot.Controls.Add(Me.nudLabelAlpha)
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
        Me.tbCorrelationPlot.Size = New System.Drawing.Size(244, 88)
        Me.tbCorrelationPlot.TabIndex = 1
        Me.tbCorrelationPlot.Tag = "Correlation_Plot"
        Me.tbCorrelationPlot.Text = "Correlation Plot"
        Me.tbCorrelationPlot.UseVisualStyleBackColor = True
        '
        'chkLabel
        '
        Me.chkLabel.AutoSize = True
        Me.chkLabel.Location = New System.Drawing.Point(24, 56)
        Me.chkLabel.Name = "chkLabel"
        Me.chkLabel.Size = New System.Drawing.Size(52, 17)
        Me.chkLabel.TabIndex = 9
        Me.chkLabel.Tag = "Label"
        Me.chkLabel.Text = "Label"
        Me.chkLabel.UseVisualStyleBackColor = True
        '
        'nudLabelAlpha
        '
        Me.nudLabelAlpha.DecimalPlaces = 2
        Me.nudLabelAlpha.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudLabelAlpha.Location = New System.Drawing.Point(177, 54)
        Me.nudLabelAlpha.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLabelAlpha.Name = "nudLabelAlpha"
        Me.nudLabelAlpha.Size = New System.Drawing.Size(51, 20)
        Me.nudLabelAlpha.TabIndex = 8
        Me.nudLabelAlpha.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudMaximumSize
        '
        Me.nudMaximumSize.Location = New System.Drawing.Point(210, 31)
        Me.nudMaximumSize.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudMaximumSize.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudMaximumSize.Name = "nudMaximumSize"
        Me.nudMaximumSize.Size = New System.Drawing.Size(31, 20)
        Me.nudMaximumSize.TabIndex = 7
        Me.nudMaximumSize.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'nudMinimunSize
        '
        Me.nudMinimunSize.Location = New System.Drawing.Point(96, 30)
        Me.nudMinimunSize.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudMinimunSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMinimunSize.Name = "nudMinimunSize"
        Me.nudMinimunSize.Size = New System.Drawing.Size(31, 20)
        Me.nudMinimunSize.TabIndex = 6
        Me.nudMinimunSize.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lblMaximumSize
        '
        Me.lblMaximumSize.AutoSize = True
        Me.lblMaximumSize.Location = New System.Drawing.Point(132, 33)
        Me.lblMaximumSize.Name = "lblMaximumSize"
        Me.lblMaximumSize.Size = New System.Drawing.Size(74, 13)
        Me.lblMaximumSize.TabIndex = 5
        Me.lblMaximumSize.Tag = "Maximum_Size"
        Me.lblMaximumSize.Text = "Maximum Size"
        '
        'cmbgeom
        '
        Me.cmbgeom.FormattingEnabled = True
        Me.cmbgeom.Items.AddRange(New Object() {"tile", "circle", "text", "blank"})
        Me.cmbgeom.Location = New System.Drawing.Point(114, 3)
        Me.cmbgeom.Name = "cmbgeom"
        Me.cmbgeom.Size = New System.Drawing.Size(121, 21)
        Me.cmbgeom.TabIndex = 4
        '
        'lblLabelAlpha
        '
        Me.lblLabelAlpha.AutoSize = True
        Me.lblLabelAlpha.Location = New System.Drawing.Point(104, 56)
        Me.lblLabelAlpha.Name = "lblLabelAlpha"
        Me.lblLabelAlpha.Size = New System.Drawing.Size(63, 13)
        Me.lblLabelAlpha.TabIndex = 3
        Me.lblLabelAlpha.Tag = "Label_Alpha"
        Me.lblLabelAlpha.Text = "Label Alpha"
        '
        'lblMinimumSize
        '
        Me.lblMinimumSize.AutoSize = True
        Me.lblMinimumSize.Location = New System.Drawing.Point(21, 34)
        Me.lblMinimumSize.Name = "lblMinimumSize"
        Me.lblMinimumSize.Size = New System.Drawing.Size(71, 13)
        Me.lblMinimumSize.TabIndex = 1
        Me.lblMinimumSize.Tag = "Minimum_Size"
        Me.lblMinimumSize.Text = "Minimum Size"
        '
        'lblgeom
        '
        Me.lblgeom.AutoSize = True
        Me.lblgeom.Location = New System.Drawing.Point(17, 12)
        Me.lblgeom.Name = "lblgeom"
        Me.lblgeom.Size = New System.Drawing.Size(33, 13)
        Me.lblgeom.TabIndex = 0
        Me.lblgeom.Tag = "geom"
        Me.lblgeom.Text = "geom"
        '
        'tbScatterplotMatrix
        '
        Me.tbScatterplotMatrix.Controls.Add(Me.chkColor)
        Me.tbScatterplotMatrix.Controls.Add(Me.lblAlpha)
        Me.tbScatterplotMatrix.Controls.Add(Me.nudAlpha)
        Me.tbScatterplotMatrix.Location = New System.Drawing.Point(4, 22)
        Me.tbScatterplotMatrix.Name = "tbScatterplotMatrix"
        Me.tbScatterplotMatrix.Padding = New System.Windows.Forms.Padding(3)
        Me.tbScatterplotMatrix.Size = New System.Drawing.Size(244, 88)
        Me.tbScatterplotMatrix.TabIndex = 2
        Me.tbScatterplotMatrix.Tag = "Scatterplot_Matrix"
        Me.tbScatterplotMatrix.Text = "Scatterplot Matrix"
        Me.tbScatterplotMatrix.UseVisualStyleBackColor = True
        '
        'chkColor
        '
        Me.chkColor.AutoSize = True
        Me.chkColor.Location = New System.Drawing.Point(20, 38)
        Me.chkColor.Name = "chkColor"
        Me.chkColor.Size = New System.Drawing.Size(50, 17)
        Me.chkColor.TabIndex = 3
        Me.chkColor.Tag = "Color"
        Me.chkColor.Text = "Color"
        Me.chkColor.UseVisualStyleBackColor = True
        '
        'lblAlpha
        '
        Me.lblAlpha.AutoSize = True
        Me.lblAlpha.Location = New System.Drawing.Point(15, 12)
        Me.lblAlpha.Name = "lblAlpha"
        Me.lblAlpha.Size = New System.Drawing.Size(34, 13)
        Me.lblAlpha.TabIndex = 1
        Me.lblAlpha.Tag = "Alpha"
        Me.lblAlpha.Text = "Alpha"
        '
        'nudAlpha
        '
        Me.nudAlpha.DecimalPlaces = 2
        Me.nudAlpha.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudAlpha.Location = New System.Drawing.Point(55, 12)
        Me.nudAlpha.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudAlpha.Name = "nudAlpha"
        Me.nudAlpha.Size = New System.Drawing.Size(51, 20)
        Me.nudAlpha.TabIndex = 0
        Me.nudAlpha.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'grpGraphOptions
        '
        Me.grpGraphOptions.Controls.Add(Me.rdoScatterplotMatrix)
        Me.grpGraphOptions.Controls.Add(Me.rdoCorrelationPlot)
        Me.grpGraphOptions.Controls.Add(Me.rdoPairwisePlot)
        Me.grpGraphOptions.Location = New System.Drawing.Point(16, 2)
        Me.grpGraphOptions.Name = "grpGraphOptions"
        Me.grpGraphOptions.Size = New System.Drawing.Size(142, 83)
        Me.grpGraphOptions.TabIndex = 4
        Me.grpGraphOptions.TabStop = False
        Me.grpGraphOptions.Tag = "Graph_Options"
        Me.grpGraphOptions.Text = "Graph Options"
        '
        'rdoScatterplotMatrix
        '
        Me.rdoScatterplotMatrix.AutoSize = True
        Me.rdoScatterplotMatrix.Location = New System.Drawing.Point(17, 63)
        Me.rdoScatterplotMatrix.Name = "rdoScatterplotMatrix"
        Me.rdoScatterplotMatrix.Size = New System.Drawing.Size(107, 17)
        Me.rdoScatterplotMatrix.TabIndex = 2
        Me.rdoScatterplotMatrix.TabStop = True
        Me.rdoScatterplotMatrix.Tag = "Scatterplot_Matrix"
        Me.rdoScatterplotMatrix.Text = "Scatterplot Matrix"
        Me.rdoScatterplotMatrix.UseVisualStyleBackColor = True
        '
        'rdoCorrelationPlot
        '
        Me.rdoCorrelationPlot.AutoSize = True
        Me.rdoCorrelationPlot.Location = New System.Drawing.Point(17, 40)
        Me.rdoCorrelationPlot.Name = "rdoCorrelationPlot"
        Me.rdoCorrelationPlot.Size = New System.Drawing.Size(96, 17)
        Me.rdoCorrelationPlot.TabIndex = 1
        Me.rdoCorrelationPlot.TabStop = True
        Me.rdoCorrelationPlot.Tag = "Correlation_Plot"
        Me.rdoCorrelationPlot.Text = "Correlation Plot"
        Me.rdoCorrelationPlot.UseVisualStyleBackColor = True
        '
        'rdoPairwisePlot
        '
        Me.rdoPairwisePlot.AutoSize = True
        Me.rdoPairwisePlot.Location = New System.Drawing.Point(17, 20)
        Me.rdoPairwisePlot.Name = "rdoPairwisePlot"
        Me.rdoPairwisePlot.Size = New System.Drawing.Size(85, 17)
        Me.rdoPairwisePlot.TabIndex = 0
        Me.rdoPairwisePlot.TabStop = True
        Me.rdoPairwisePlot.Tag = "Pairwise_Plot"
        Me.rdoPairwisePlot.Text = "Pairwise Plot"
        Me.rdoPairwisePlot.UseVisualStyleBackColor = True
        '
        'ucrBaseSdgCorrPlot
        '
        Me.ucrBaseSdgCorrPlot.Location = New System.Drawing.Point(44, 275)
        Me.ucrBaseSdgCorrPlot.Name = "ucrBaseSdgCorrPlot"
        Me.ucrBaseSdgCorrPlot.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSdgCorrPlot.TabIndex = 0
        '
        'sdgCorrPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 305)
        Me.Controls.Add(Me.tbSdgCorrelation)
        Me.Controls.Add(Me.ucrBaseSdgCorrPlot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCorrPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "corrplot"
        Me.Text = "corrplot"
        Me.tbSdgCorrelation.ResumeLayout(False)
        Me.tbDisplay.ResumeLayout(False)
        Me.tbDisplay.PerformLayout()
        Me.tbGraphics.ResumeLayout(False)
        Me.tbSaveGraphs.ResumeLayout(False)
        Me.tbCorrelationPlot.ResumeLayout(False)
        Me.tbCorrelationPlot.PerformLayout()
        CType(Me.nudLabelAlpha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMaximumSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinimunSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbScatterplotMatrix.ResumeLayout(False)
        Me.tbScatterplotMatrix.PerformLayout()
        CType(Me.nudAlpha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGraphOptions.ResumeLayout(False)
        Me.grpGraphOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseSdgCorrPlot As ucrButtonsSubdialogue
    Friend WithEvents tbSdgCorrelation As TabControl
    Friend WithEvents tbDisplay As TabPage
    Friend WithEvents chkCorrelationMatrix As CheckBox
    Friend WithEvents tbGraphics As TabPage
    Friend WithEvents grpGraphOptions As GroupBox
    Friend WithEvents rdoScatterplotMatrix As RadioButton
    Friend WithEvents rdoCorrelationPlot As RadioButton
    Friend WithEvents rdoPairwisePlot As RadioButton
    Friend WithEvents ucrSaveGraph As ucrSaveGraph
    Friend WithEvents tbSaveGraphs As TabControl
    Friend WithEvents tbPairwisePlot As TabPage
    Friend WithEvents tbCorrelationPlot As TabPage
    Friend WithEvents tbScatterplotMatrix As TabPage
    Friend WithEvents chkColor As CheckBox
    Friend WithEvents lblAlpha As Label
    Friend WithEvents nudAlpha As NumericUpDown
    Friend WithEvents nudMaximumSize As NumericUpDown
    Friend WithEvents nudMinimunSize As NumericUpDown
    Friend WithEvents lblMaximumSize As Label
    Friend WithEvents cmbgeom As ComboBox
    Friend WithEvents lblLabelAlpha As Label
    Friend WithEvents lblMinimumSize As Label
    Friend WithEvents lblgeom As Label
    Friend WithEvents nudLabelAlpha As NumericUpDown
    Friend WithEvents chkLabel As CheckBox
End Class
