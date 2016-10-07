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
        Me.ucrBaseSdgCorrPlot = New instat.ucrButtonsSubdialogue()
        Me.ucrSaveGraph = New instat.ucrSaveGraph()
        Me.tbSaveGraphs.SuspendLayout()
        Me.tbCorrelationPlot.SuspendLayout()
        CType(Me.nudLabelAlpha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaximumSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinimunSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbScatterplotMatrix.SuspendLayout()
        CType(Me.nudAlpha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkCorrelationMatrix
        '
        Me.chkCorrelationMatrix.AutoSize = True
        Me.chkCorrelationMatrix.Location = New System.Drawing.Point(12, 7)
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
        Me.chkScatterplotMatrix.Location = New System.Drawing.Point(12, 30)
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
        Me.chkCorrelationPlot.Location = New System.Drawing.Point(12, 53)
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
        Me.chkPairwisePlot.Location = New System.Drawing.Point(12, 76)
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
        Me.tbSaveGraphs.Location = New System.Drawing.Point(32, 95)
        Me.tbSaveGraphs.Name = "tbSaveGraphs"
        Me.tbSaveGraphs.SelectedIndex = 0
        Me.tbSaveGraphs.Size = New System.Drawing.Size(252, 139)
        Me.tbSaveGraphs.TabIndex = 4
        '
        'tbPairwisePlot
        '
        Me.tbPairwisePlot.Location = New System.Drawing.Point(4, 22)
        Me.tbPairwisePlot.Name = "tbPairwisePlot"
        Me.tbPairwisePlot.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPairwisePlot.Size = New System.Drawing.Size(244, 113)
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
        Me.tbCorrelationPlot.Size = New System.Drawing.Size(244, 113)
        Me.tbCorrelationPlot.TabIndex = 1
        Me.tbCorrelationPlot.Tag = "Correlation_Plot"
        Me.tbCorrelationPlot.Text = "Correlation Plot"
        Me.tbCorrelationPlot.UseVisualStyleBackColor = True
        '
        'chkLabel
        '
        Me.chkLabel.AutoSize = True
        Me.chkLabel.Location = New System.Drawing.Point(17, 74)
        Me.chkLabel.Name = "chkLabel"
        Me.chkLabel.Size = New System.Drawing.Size(52, 17)
        Me.chkLabel.TabIndex = 27
        Me.chkLabel.Tag = "Label"
        Me.chkLabel.Text = "Label"
        Me.chkLabel.UseVisualStyleBackColor = True
        '
        'nudLabelAlpha
        '
        Me.nudLabelAlpha.DecimalPlaces = 2
        Me.nudLabelAlpha.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudLabelAlpha.Location = New System.Drawing.Point(170, 72)
        Me.nudLabelAlpha.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLabelAlpha.Name = "nudLabelAlpha"
        Me.nudLabelAlpha.Size = New System.Drawing.Size(51, 20)
        Me.nudLabelAlpha.TabIndex = 26
        Me.nudLabelAlpha.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudMaximumSize
        '
        Me.nudMaximumSize.Location = New System.Drawing.Point(203, 49)
        Me.nudMaximumSize.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudMaximumSize.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudMaximumSize.Name = "nudMaximumSize"
        Me.nudMaximumSize.Size = New System.Drawing.Size(31, 20)
        Me.nudMaximumSize.TabIndex = 25
        Me.nudMaximumSize.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'nudMinimunSize
        '
        Me.nudMinimunSize.Location = New System.Drawing.Point(89, 48)
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
        Me.lblMaximumSize.Location = New System.Drawing.Point(125, 51)
        Me.lblMaximumSize.Name = "lblMaximumSize"
        Me.lblMaximumSize.Size = New System.Drawing.Size(74, 13)
        Me.lblMaximumSize.TabIndex = 23
        Me.lblMaximumSize.Tag = "Maximum_Size"
        Me.lblMaximumSize.Text = "Maximum Size"
        '
        'cmbgeom
        '
        Me.cmbgeom.FormattingEnabled = True
        Me.cmbgeom.Items.AddRange(New Object() {"tile", "circle", "text", "blank"})
        Me.cmbgeom.Location = New System.Drawing.Point(107, 21)
        Me.cmbgeom.Name = "cmbgeom"
        Me.cmbgeom.Size = New System.Drawing.Size(121, 21)
        Me.cmbgeom.TabIndex = 22
        '
        'lblLabelAlpha
        '
        Me.lblLabelAlpha.AutoSize = True
        Me.lblLabelAlpha.Location = New System.Drawing.Point(97, 74)
        Me.lblLabelAlpha.Name = "lblLabelAlpha"
        Me.lblLabelAlpha.Size = New System.Drawing.Size(63, 13)
        Me.lblLabelAlpha.TabIndex = 21
        Me.lblLabelAlpha.Tag = "Label_Alpha"
        Me.lblLabelAlpha.Text = "Label Alpha"
        '
        'lblMinimumSize
        '
        Me.lblMinimumSize.AutoSize = True
        Me.lblMinimumSize.Location = New System.Drawing.Point(14, 52)
        Me.lblMinimumSize.Name = "lblMinimumSize"
        Me.lblMinimumSize.Size = New System.Drawing.Size(71, 13)
        Me.lblMinimumSize.TabIndex = 20
        Me.lblMinimumSize.Tag = "Minimum_Size"
        Me.lblMinimumSize.Text = "Minimum Size"
        '
        'lblgeom
        '
        Me.lblgeom.AutoSize = True
        Me.lblgeom.Location = New System.Drawing.Point(10, 30)
        Me.lblgeom.Name = "lblgeom"
        Me.lblgeom.Size = New System.Drawing.Size(33, 13)
        Me.lblgeom.TabIndex = 19
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
        Me.tbScatterplotMatrix.Size = New System.Drawing.Size(244, 113)
        Me.tbScatterplotMatrix.TabIndex = 2
        Me.tbScatterplotMatrix.Tag = "Scatterplot_Matrix"
        Me.tbScatterplotMatrix.Text = "Scatterplot Matrix"
        Me.tbScatterplotMatrix.UseVisualStyleBackColor = True
        '
        'chkColor
        '
        Me.chkColor.AutoSize = True
        Me.chkColor.Location = New System.Drawing.Point(82, 61)
        Me.chkColor.Name = "chkColor"
        Me.chkColor.Size = New System.Drawing.Size(50, 17)
        Me.chkColor.TabIndex = 9
        Me.chkColor.Tag = "Color"
        Me.chkColor.Text = "Color"
        Me.chkColor.UseVisualStyleBackColor = True
        '
        'lblAlpha
        '
        Me.lblAlpha.AutoSize = True
        Me.lblAlpha.Location = New System.Drawing.Point(77, 35)
        Me.lblAlpha.Name = "lblAlpha"
        Me.lblAlpha.Size = New System.Drawing.Size(34, 13)
        Me.lblAlpha.TabIndex = 8
        Me.lblAlpha.Tag = "Alpha"
        Me.lblAlpha.Text = "Alpha"
        '
        'nudAlpha
        '
        Me.nudAlpha.DecimalPlaces = 2
        Me.nudAlpha.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudAlpha.Location = New System.Drawing.Point(117, 35)
        Me.nudAlpha.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudAlpha.Name = "nudAlpha"
        Me.nudAlpha.Size = New System.Drawing.Size(51, 20)
        Me.nudAlpha.TabIndex = 7
        Me.nudAlpha.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrBaseSdgCorrPlot
        '
        Me.ucrBaseSdgCorrPlot.Location = New System.Drawing.Point(76, 262)
        Me.ucrBaseSdgCorrPlot.Name = "ucrBaseSdgCorrPlot"
        Me.ucrBaseSdgCorrPlot.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSdgCorrPlot.TabIndex = 6
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(12, 234)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(236, 22)
        Me.ucrSaveGraph.TabIndex = 5
        '
        'sdgCorrPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 294)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Correlation_Display_and_Graphics"
        Me.Text = "Correlation Display and Graphics"
        Me.tbSaveGraphs.ResumeLayout(False)
        Me.tbCorrelationPlot.ResumeLayout(False)
        Me.tbCorrelationPlot.PerformLayout()
        CType(Me.nudLabelAlpha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMaximumSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinimunSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbScatterplotMatrix.ResumeLayout(False)
        Me.tbScatterplotMatrix.PerformLayout()
        CType(Me.nudAlpha, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents nudLabelAlpha As NumericUpDown
    Friend WithEvents nudMaximumSize As NumericUpDown
    Friend WithEvents nudMinimunSize As NumericUpDown
    Friend WithEvents lblMaximumSize As Label
    Friend WithEvents cmbgeom As ComboBox
    Friend WithEvents lblLabelAlpha As Label
    Friend WithEvents lblMinimumSize As Label
    Friend WithEvents lblgeom As Label
    Friend WithEvents chkColor As CheckBox
    Friend WithEvents lblAlpha As Label
    Friend WithEvents nudAlpha As NumericUpDown
End Class
